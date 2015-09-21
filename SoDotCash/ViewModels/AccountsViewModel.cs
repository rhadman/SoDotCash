using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using Microsoft.Win32;
using OFX;
using OFX.Types;

namespace SoDotCash.ViewModels
{
    /// <summary>
    /// ViewModel handling data exposure and backing functionality for the AccountsView view element
    /// </summary>
    public class AccountsViewModel : ViewModelBase
    {

        #region [ Public Bound Properties ]

        /// <summary>
        /// The ViewModel tied to the currently active view in the GUI
        /// </summary>
        private ViewModelBase _activeViewModel;
        public ViewModelBase ActiveViewModel
        {
            get { return _activeViewModel; }
            set
            {
                _activeViewModel = value;
                RaisePropertyChanged();
            }
        }

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

                // Ensure we're on the transactions page
                var locator = new ViewModelLocator();
                ActiveViewModel = locator.Transactions;

                // Transactions will be updated since this is a different account
                RaisePropertyChanged("Transactions");
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
                    return dbAccount.transactions.ToList();
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

            // TODO: Move the logic below to a service


            // Read and convert
            using (var ofxFileStream = fileDialog.OpenFile())
            {
                // Deserialize the OFX file data to an object form
                var converter = new OFX1ToOFX2Converter(ofxFileStream);
                foreach (var statement in Statement.CreateFromOFXResponse(converter.ConvertToOFX()))
                {
                    using (var db = new Models.SoCashDbContext())
                    {

                        // Retrieve account - we need to get an entity in the current db session
                        var updateAccount = db.Accounts.First(account => account.accountID == SelectedAccount.accountID);

                        foreach (var transaction in statement.Transactions)
                        {
                            // See if transaction is already in db
                            try
                            {
                                var existingTransaction =
                                    updateAccount.transactions.First(t => t.fiTransactionId == transaction.TransactionId);

                                // Ensure amount and date of transaction match
                                existingTransaction.amount = transaction.Amount;
                                existingTransaction.date = transaction.PostDate.Date;
                            }
                            catch (InvalidOperationException)
                            {
                                // No such transaction, add entity

                                // Create model transaction
                                var dbTransaction = new Models.Transaction
                                {
                                    amount = transaction.Amount,
                                    category = "",
                                    currency = statement.Currency,
                                    date = transaction.PostDate.Date,
                                    description = transaction.Name,
                                    fiTransactionId = transaction.TransactionId
                                };
                                updateAccount.transactions.Add(dbTransaction);
                            }
                        }

                        //db.Accounts.Add(newAccount);
                        db.SaveChanges();
                    }
                }
            }

            // Update transactions
            //ActiveTransactions.RaisePropertyChanged("Transactions");
        }

    }
}
