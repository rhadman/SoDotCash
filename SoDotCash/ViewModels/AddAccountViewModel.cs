using System.Collections.Generic;
using System.Windows.Input;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using SoDotCash.Models;

namespace SoDotCash.ViewModels
{
    /// <summary>
    /// This class contains properties that a View can data bind to.
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class AddAccountViewModel : ViewModelBase
    {
        /// <summary>
        /// Name of our view xaml - used for transitions
        /// </summary>
        public static readonly string ViewXaml = "AddAccountView.xaml";

        /// <summary>
        /// Initializes a new instance of the AddAccountViewModel class.
        /// </summary>
        public AddAccountViewModel()
        {
        }

        /// <summary>
        /// Retrieve all account types for populating a selection list
        /// </summary>
        public IEnumerable<AccountType> AllAccountTypes
        {
            get { return AccountType.All(); }
        }

        /// <summary>
        /// The selected account type
        /// </summary>
        public string SelectedAccountType { get; set; }

        /// <summary>
        /// User entered account name
        /// </summary>
        public string AccountName { get; set; }


        /// <summary>
        /// Binding for the Cancel button
        /// </summary>
        private ICommand _cancelCommand;
        public ICommand CancelCommand
        {
            get { return _cancelCommand ?? (_cancelCommand = new RelayCommand(Cancel, () => true)); }
        }

        /// <summary>
        /// Cancels action. Returns to previous view.
        /// </summary>
        public void Cancel()
        {
            // Transition to Accounts View
            var locator = new ViewModelLocator();
            locator.Main.ActiveViewSource = AccountsViewModel.ViewXaml;
        }

        /// <summary>
        /// Binding for the Create Account button
        /// </summary>
        private ICommand _createAccountCommand;
        public ICommand CreateAccountCommand
        {
            get { return _createAccountCommand ?? (_createAccountCommand = new RelayCommand(CreateAccount, () => true )); }
        }

        /// <summary>
        /// Creates the new account from the information in the form.
        /// </summary>
        public void CreateAccount()
        {
            // Add the new account
            using (var db = new Models.SoCashDbContext())
            {
                var newAccount = new Account
                {
                    accountName = this.AccountName,
                    accountID = 0,
                    accountType = SelectedAccountType,
                    currency = "USD"
                };
                db.Accounts.Add(newAccount);
                db.SaveChanges();
            }

            // Transition back to accounts view
            var locator = new ViewModelLocator();
            locator.Main.ActiveViewSource = AccountsViewModel.ViewXaml;
        }


    }
}