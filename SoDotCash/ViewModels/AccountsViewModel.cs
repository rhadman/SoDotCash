using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Windows.Data;
using System.Windows.Input;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using Microsoft.Win32;
using SoDotCash.Models;
using SoDotCash.Services;

namespace SoDotCash.ViewModels
{
    /// <summary>
    /// ViewModel handling data exposure and backing functionality for the AccountsView view element
    /// </summary>
    public class AccountsViewModel : ViewModelBase
    {

        public AccountsViewModel()
        {
            // Start on Overview tab
            ActiveTabIndex = TabIndex.Overview;
        }

        /// <summary>
        /// Enumeration providing names to the tabs on the view
        /// </summary>
        public enum TabIndex
        {
            Overview = 0,
            Ledger,
            Import,
            Configuration
        };


        #region [ Public Bound Properties ]

        /// <summary>
        /// Provides the collection of accounts mapped by the account type of each
        /// </summary>
        public Dictionary<string, ObservableCollection<Account>> AccountsView
        {
            get
            {
                var accountsByType = new Dictionary<string, ObservableCollection<Account>>();

                // Retrieve the accounts from the database
                using (var db = new SoCashDbContext())
                {
                    // Map all accounts by type
                    foreach (var account in db.Accounts)
                    {
                        // Add category if needed
                        ObservableCollection<Account> accountList;
                        if (!accountsByType.ContainsKey(account.AccountType))
                        {
                            accountList = new ObservableCollection<Account>();
                            accountsByType.Add(account.AccountType, accountList);
                        }
                        else
                        {
                            accountList = accountsByType[account.AccountType];
                        }

                        // Add to the list under this type
                        accountList.Add(account);
                    }
                }
                return accountsByType;
            }
        }

        /// <summary>
        /// Bound current account
        /// </summary>
        private Account _selectedAccount;
        public Account SelectedAccount
        {
            get { return _selectedAccount; }
            set
            {
                // Assign
                _selectedAccount = value;

                // Update indicator of whether this account allows the user to add transactions manually
                RaisePropertyChanged(() => IsManualAccount);

                // Transactions will be updated since this is a different account
                RaisePropertyChanged(() => Transactions);
            }
        }

        /// <summary>
        /// Bound current transaction
        /// </summary>
        private Transaction _selectedTransaction;
        public Transaction SelectedTransaction
        {
            get { return _selectedTransaction; }
            set
            {
                // Assign
                _selectedTransaction = value;
                RaisePropertyChanged();
            }
        }


        /// <summary>
        /// Bound index of the active tab in the account data display section
        /// </summary>
        private TabIndex _activeTabIndex;
        public TabIndex ActiveTabIndex
        {
            get { return _activeTabIndex;}
            set
            {
                _activeTabIndex = value;
                RaisePropertyChanged();
                RaisePropertyChanged(() => ActiveTabIndexAsInt);
            }
        }
        public int ActiveTabIndexAsInt
        {
            get { return (int) _activeTabIndex; }
            set
            {
                _activeTabIndex = (TabIndex) value;
                RaisePropertyChanged();
                RaisePropertyChanged(() => ActiveTabIndex);
            }
        }

        /// <summary>
        /// Provides the collection of transactions for the currently selected account
        /// </summary>
        private ObservableCollection<Transaction>_transactions ; 
        public ObservableCollection<Transaction> Transactions
        {
            get
            {
                if (SelectedAccount == null)
                    return null;
                using (var db = new SoCashDbContext())
                {
                    // Retrieve account - we need to get an entity in the current db session
                    var dbAccount = db.Accounts.First(account => account.AccountId == SelectedAccount.AccountId);
                    var transactions = from t in dbAccount.Transactions orderby t.Date select t;

                    // Calculate running balance and attach edit notifications
                    int balance = 0;
                    foreach (var transaction in transactions)
                    {
                        // Calculate balance
                        balance += transaction.Amount;
                        transaction.Balance = balance;

                        // Attach notifications for edit events
                        transaction.EditEnded += OnTransactionEditEnded;
                    }

                    // Reverse transactions so newest are listed first
                    _transactions = new ObservableCollection<Transaction>(transactions.Reverse());

                    // Ensure the new item row is at the top of the view
                    ((IEditableCollectionView) CollectionViewSource.GetDefaultView(_transactions)).NewItemPlaceholderPosition = NewItemPlaceholderPosition.AtBeginning;

                    // Get notified when the user modifies entries in the datagrid
                   _transactions.CollectionChanged += TransactionsOnCollectionChanged;
                    return _transactions;

                }
            }
        }

        /// <summary>
        /// Determination of whether the user should be able to add transactions to the ledger
        /// </summary>
        public bool IsManualAccount
        {
            get
            {
                // If there is no selected account, transactions cannot be added
                if (SelectedAccount == null)
                    return false;
                // If the account is associated with a financial institution user, it is an auto-update account
                //  and users may not add transactions manually
                return (!SelectedAccount.IsAssociatedWithFinancialInstitution);
            }
        }

        #endregion


        /// <summary>
        /// Handle modification events from the DataGrid containing transactions
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="notifyCollectionChangedEventArgs"></param>
        private void TransactionsOnCollectionChanged(object sender, NotifyCollectionChangedEventArgs notifyCollectionChangedEventArgs)
        {
            switch (notifyCollectionChangedEventArgs.Action)
            {
                // Handle a new transaction in the collection
                case NotifyCollectionChangedAction.Add:
                    {
                        // Attach notification event handlers for this transaction
                        var transaction = (Transaction)notifyCollectionChangedEventArgs.NewItems[0];
                        transaction.EditBegun += OnNewTransactionEditBegun;
                        transaction.EditEnded += OnTransactionEditEnded;

                        break;
                    }
            }
        }

        /// <summary>
        /// Called after the DB context has been opened for editing a new transaction
        /// </summary>
        /// <param name="sender">Always a Transaction</param>
        /// <param name="eventArgs">Not used</param>
        private void OnNewTransactionEditBegun(object sender, EventArgs eventArgs)
        {
            var transaction = (Transaction)sender;

            // Ensure the Account is attached to the same context as the transaction
            transaction.EditContext.Entry(SelectedAccount).State = EntityState.Unchanged;
            transaction.Account = SelectedAccount;

            // This is a new transaction. Ensure it is being ADDED to the database
            transaction.EditContext.Entry(transaction).State = EntityState.Added;
        }

        /// <summary>
        /// Called after the transaction is saved to the database
        /// </summary>
        /// <param name="sender">Always a Transaction</param>
        /// <param name="eventArgs">Not used</param>
        private void OnTransactionEditEnded(object sender, EventArgs eventArgs)
        {
            // Need to re-sort the data and recalculate balances
            RaisePropertyChanged(() => Transactions);
        }

        /// <summary>
        /// Binding for the Add Account button
        /// </summary>
        private ICommand _addAccountCommand;
        public ICommand AddAccountCommand
        {
            get { return _addAccountCommand ?? (_addAccountCommand = new RelayCommand(AddAccount, () => true)); }
        }

        /// <summary>
        /// Transitions to Add Account view
        /// </summary>
        public void AddAccount()
        {
            // Transition view
            var locator = new ViewModelLocator();
            locator.Main.ActiveViewModel = locator.AddAccount;
        }

        /// <summary>
        /// Binding for the Delete Transaction action (delete key from ledger)
        /// </summary>
        private ICommand _deleteTransactionCommand;
        public ICommand DeleteTransactionCommand
        {
            get { return _deleteTransactionCommand ?? (_deleteTransactionCommand = new RelayCommand(DeleteTransaction, () => IsManualAccount)); }
        }

        /// <summary>
        /// Deletes the transaction currently selected in the datagrid
        /// </summary>
        public void DeleteTransaction()
        {
            // Delete the transaction
            DataService.DeleteTransaction(SelectedTransaction);

            // Need to re-sort the data and recalculate balances
            RaisePropertyChanged(() => Transactions);
        }

        /// <summary>
        /// Binding for the Import Transactions button
        /// </summary>
        private ICommand _importTransactionsCommand;
        public ICommand ImportTransactionsCommand
        {
            get { return _importTransactionsCommand ?? (_importTransactionsCommand = new RelayCommand(ImportTransactions, () => SelectedAccount!=null )); }
        }

        /// <summary>
        /// Prompts for an OFX file and imports transactions
        /// </summary>
        public void ImportTransactions()
        {
            var fileDialog = new OpenFileDialog {Filter = "Bank Statements (*.ofx, *.qfx)|*.ofx;*.qfx"};
            if (fileDialog.ShowDialog() != true)
            {
                // Cancel selected, ignore
                return;
            }

            // Open the file the user selected for read
            using (var ofxFileStream = fileDialog.OpenFile())
            {
                // Parse the file and merge transactions into the current account
                UpdateService.MergeOfxFileIntoAccount(SelectedAccount, ofxFileStream);
            }

            // Update transactions
            RaisePropertyChanged(() => Transactions);

            // Move to transactions tab
            ActiveTabIndex = TabIndex.Ledger;
        }


        /// <summary>
        /// Binding for the Download Transactions button
        /// </summary>
        private ICommand _downloadTransactionsCommand;
        public ICommand DownloadTransactionsCommand
        {
            get { return _downloadTransactionsCommand ?? (_downloadTransactionsCommand = new RelayCommand(DownloadTransactions, () => SelectedAccount?.FiUserId != null)); }
        }

        /// <summary>
        /// Initiates a download of transactions from the remote financial institution
        /// </summary>
        public async void DownloadTransactions()
        {
            // Download transactions asynchronously and wait for response
            await UpdateService.DownloadOfxTransactionsForAccount(SelectedAccount).ConfigureAwait(false);

            // Update transactions
            RaisePropertyChanged(() => Transactions);

            // Move to transactions tab
            ActiveTabIndex = TabIndex.Ledger;
        }

        /// <summary>
        /// Binding for the Delete Account button
        /// </summary>
        private ICommand _deleteAccountCommand;
        public ICommand DeleteAccountCommand
        {
            get { return _deleteAccountCommand ?? (_deleteAccountCommand = new RelayCommand(DeleteSelectedAccount, () => true)); }
        }

        /// <summary>
        /// Deletes the selected account from the database
        /// </summary>
        public void DeleteSelectedAccount()
        {
            // Delete the account
            UpdateService.DeleteAccount(SelectedAccount);
            
            // Set to no account
            SelectedAccount = null;

            // Return to Overview tab
            ActiveTabIndex = 0;

            // Notify that the list of accounts has changed
            RaisePropertyChanged(() => AccountsView);
        }
    }
}
