using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using OFX.Protocol;

namespace SoDotCash.ViewModels
{
    /// <summary>
    /// ViewModel handling data exposure and backing functionality for the AccountsView view element
    /// </summary>
    public class AccountsViewModel : ViewModelBase
    {
        /// <summary>
        /// Name of our view xaml - used for transitions
        /// </summary>
        public static readonly string ViewXaml = "AccountsView.xaml";

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
            locator.Main.ActiveViewSource = AddAccountViewModel.ViewXaml;
        }

    }
}
