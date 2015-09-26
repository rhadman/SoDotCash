using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using Microsoft.Win32;
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
        public Dictionary<string, ObservableCollection<Models.Account>> AccountsView
        {
            get
            {
                var accountsByType = new Dictionary<string, ObservableCollection<Models.Account>>();

                // Retrieve the accounts from the database
                using (var db = new Models.SoCashDbContext())
                {
                    // Map all accounts by type
                    foreach (var account in db.Accounts)
                    {
                        // Add category if needed
                        ObservableCollection<Models.Account> accountList;
                        if (!accountsByType.ContainsKey(account.accountType))
                        {
                            accountList = new ObservableCollection<Models.Account>();
                            accountsByType.Add(account.accountType, accountList);
                        }
                        else
                        {
                            accountList = accountsByType[account.accountType];
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
        private Models.Account _selectedAccount;
        public Models.Account SelectedAccount
        {
            get { return _selectedAccount; }
            set
            {
                // Assign
                _selectedAccount = value;

                // Ensure we're on the transactions tab
                ActiveTabIndex = TabIndex.Ledger;

                // Transactions will be updated since this is a different account
                RaisePropertyChanged(() => Transactions);
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
        public IEnumerable<Models.Transaction> Transactions
        {
            get
            {
                if (SelectedAccount == null)
                    return null;
                using (var db = new Models.SoCashDbContext())
                {
                    // Retrieve account - we need to get an entity in the current db session
                    var dbAccount = db.Accounts.First(account => account.accountID == SelectedAccount.accountID);
                    var transactions = from t in dbAccount.transactions orderby t.date select t;

                    // Calculate running balance
                    int balance = 0;
                    foreach (var transaction in transactions)
                    {
                        balance += transaction.amount;
                        transaction.balance = balance;
                    }

                    // Reverse transactions so newest are listed first
                    return transactions.Reverse();

                }
            }
        }

        #endregion

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
            var fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Bank Statements (*.ofx, *.qfx)|*.ofx;*.qfx";
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
            get { return _downloadTransactionsCommand ?? (_downloadTransactionsCommand = new RelayCommand(DownloadTransactions, () => SelectedAccount?.fiUserID != null)); }
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
