using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using SoDotCash.Models;
using SoDotCash.Services;

namespace SoDotCash.ViewModels
{
    /// <summary>
    /// Possible types of sources for new accounts
    /// </summary>
    public enum EAccountSource
    {
        Automatic,
        Manual
    };

    /// <summary>
    /// This class contains properties that a View can data bind to.
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class AddAccountViewModel : ViewModelBase
    {

        #region [ Always Visible Fields ]


        /// <summary>
        /// Retrieve all account types for populating a selection list
        /// </summary>
        public IEnumerable<AccountType> AllAccountTypes => AccountType.All();

        /// <summary>
        /// Bound selected account source
        /// </summary>
        private EAccountSource _AccountSource;
        public EAccountSource AccountSource
        {
            get { return _AccountSource; }
            set
            {
                _AccountSource = value;
                RaisePropertyChanged();
                RaisePropertyChanged("IsManualEntry");
                RaisePropertyChanged("IsAutomaticEntry");
            }
        }

        /// <summary>
        /// User entered account name
        /// </summary>
        public string AccountName { get; set; }

        #endregion

        #region [ Manual Entry Fields ]

        /// <summary>
        /// Bound to manual entry grid to control visibility
        /// </summary>
        public bool IsManualEntry => AccountSource == EAccountSource.Manual;

        /// <summary>
        /// The selected account type
        /// </summary>
        public string SelectedAccountType { get; set; }


        #endregion

        #region [ Automatic Entry Fields ]

        /// <summary>
        /// Bound to autoamtic entry grid to control visibility
        /// </summary>
        public bool IsAutomaticEntry => AccountSource == EAccountSource.Automatic;

        /// <summary>
        /// Retrieve all financial institutions supported by OFX - ordered by name
        /// </summary>
        public IEnumerable<OFX.Types.FinancialInstitution> AllFinancialInstitutions => OFX.OFX2Service.ListFinancialInstitutions().OrderBy(fi => fi.Name);

        /// <summary>
        /// Bound to the user selection of financial institution
        /// </summary>
        public OFX.Types.FinancialInstitution SelectedFinancialInstitution { get; set; }

        /// <summary>
        /// Username used to authenticate with the financial institution
        /// </summary>
        public string FinancialInstitutionUsername { get; set; }

        /// <summary>
        /// Password used to authenticate with the financial institution
        /// </summary>
        public string FinancialInstitutionPassword { get; set; }

        /// <summary>
        /// List of accounts available from financial institution using the provided credentials
        /// </summary>
        private IEnumerable<Account> _AvailableAccounts;
        public IEnumerable<Account> AvailableAccounts
        {
            get { return _AvailableAccounts; }
            set
            {
                _AvailableAccounts = value;
                RaisePropertyChanged();
                RaisePropertyChanged("HasAvailableAccounts");
            }
        }

        /// <summary>
        /// The account selected from the list presented by the FI
        /// </summary>
        private Account _SelectedAccount;
        public Account SelectedAccount
        {
            get {  return _SelectedAccount; }
            set
            {
                _SelectedAccount = value;
                //_createAccountCommand.RaiseCanExecuteChanged();
            }
        }

        /// <summary>
        /// Bound to autoamtic entry grid to control visibility
        /// </summary>
        public bool HasAvailableAccounts => AvailableAccounts!=null && AvailableAccounts.Any();

        /// <summary>
        /// Binding for the Retrieve Accounts button
        /// </summary>
        private ICommand _retrieveAccountsCommand;
        public ICommand RetrieveAccountsCommand
        {
            get { return _retrieveAccountsCommand ?? (_retrieveAccountsCommand = new RelayCommand(PopulateAccounts, () => FinancialInstitutionUsername!=null && SelectedFinancialInstitution!=null && FinancialInstitutionPassword!=null)); }
        }

        /// <summary>
        /// Cancels action. Returns to previous view.
        /// </summary>
        public async void PopulateAccounts()
        {
            // Clear current list of accounts
            AvailableAccounts = null;

            // TODO: Spinner/progress indicator

            // Form Credentials
            var fiCredentials = new OFX.Types.Credentials(FinancialInstitutionUsername,
                FinancialInstitutionPassword.ToString());

            // Retrieve accounts from fI
            AvailableAccounts = await UpdateService.EnumerateNewAccounts(SelectedFinancialInstitution, fiCredentials);
        }

        #endregion


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
            locator.Main.ActiveViewModel = locator.Accounts;
        }

        /// <summary>
        /// Binding for the Create Account button
        /// </summary>
        private RelayCommand _createAccountCommand;
        public ICommand CreateAccountCommand
        {
            get { return _createAccountCommand ?? (_createAccountCommand = new RelayCommand(CreateAccount, CanCreateAccount)); }
        }

        /// <summary>
        /// Determine whether enough information has been provided to create a manual-entry account
        /// </summary>
        /// <returns>
        /// True - A manual entry account can be created
        /// False - A manual entry account cannot be created
        /// </returns>
        private bool CanCreateManualAccount()
        {
            // Manual entry must be selected
            if (!IsManualEntry)
                return false;

            // A name must be provided
            if (string.IsNullOrEmpty(AccountName))
                return false;

            // A type must be selected
            if (SelectedAccountType == null)
                return false;

            // We can create a manual account!
            return true;
        }

        /// <summary>
        /// Determine whether enough information has been provided to create an automatic-update account
        /// </summary>
        /// <returns>
        /// True - An automatic-update account can be created
        /// False - An automatic-update account cannot be created
        /// </returns>
        private bool CanCreateAutomaticAccount()
        {
            // Automatic entry must be selected
            if (!IsAutomaticEntry)
                return false;

            // A name must be provided
            if (string.IsNullOrEmpty(AccountName))
                return false;

            // A Financial institution must be selected
            if (SelectedFinancialInstitution == null)
                return false;

            // A username must be entered
            if (string.IsNullOrEmpty(FinancialInstitutionUsername))
                return false;

            // A password must be entered
            if (string.IsNullOrEmpty(FinancialInstitutionPassword))
                return false;

            // A financial institution account must be selected
            if (SelectedAccount == null)
                return false;

            // We can create an automatic entry account!
            return true;

        }


        /// <summary>
        /// Called to determine whether there's enough information selected to create an account
        /// </summary>
        /// <returns>
        /// True - An account can be created
        /// False - An account cannot be created
        /// </returns>
        public bool CanCreateAccount()
        {
            return CanCreateManualAccount() || CanCreateAutomaticAccount();
        }

        /// <summary>
        /// Create a manual-entry account from the provided information
        /// </summary>
        protected void CreateManualAccount()
        {
            // Add the new account
            using (var db = new SoCashDbContext())
            {
                var newAccount = new Account
                {
                    accountName = AccountName,
                    accountType = SelectedAccountType,
                    currency = "USD"
                };
                db.Accounts.Add(newAccount);
                db.SaveChanges();
            }
        }

        /// <summary>
        /// Create an automatic-update account from the provided information
        /// </summary>
        protected void CreateAutomaticAccount()
        {
            // Add the new account, financial institution and user
            using (var db = new SoCashDbContext())
            {
                // TODO: See if there's an existing FI or user with this info already
                // Look for existing FI entry with the same name
                FinancialInstitution fi;
                try
                {
                    fi = db.FinancialInstitutions.First(i => i.name == SelectedFinancialInstitution.Name);
                }
                catch (InvalidOperationException)
                {
                    // FI Doesn't exist, add a new one
                    fi = new FinancialInstitution
                    {
                        name = SelectedFinancialInstitution.Name,
                        ofxFinancialUnitId = SelectedFinancialInstitution.FinancialId,
                        ofxOrganizationId = SelectedFinancialInstitution.OrganizationId,
                        ofxUpdateUrl = SelectedFinancialInstitution.ServiceEndpoint.ToString()
                    };
                    db.FinancialInstitutions.Add(fi);
                }

                // Look for existing user under this FI with same userId
                FinancialInstitutionUser fiUser;
                try
                {
                    fiUser = fi.users.First(u => u.userId == FinancialInstitutionUsername && u.password == FinancialInstitutionPassword);
                }
                catch (Exception)
                {
                    // User doesn't exist, add a new one
                    fiUser = new FinancialInstitutionUser
                    {
                        userId = FinancialInstitutionUsername,
                        password = FinancialInstitutionPassword
                    };
                    fi.users.Add(fiUser);
                    db.FinancialInstitutionUsers.Add(fiUser);
                }

                // Create Account
                var newAccount = new Account(SelectedAccount);
                // Replace name with the user's chosen name
                newAccount.accountName = AccountName;
                fiUser.accounts.Add(newAccount);
                db.Accounts.Add(newAccount);

                db.SaveChanges();
            }
        }

        /// <summary>
        /// Creates the new account from the information in the form.
        /// </summary>
        public void CreateAccount()
        {
            // Create the account of the appropriate manual/automatic type
            if (CanCreateManualAccount())
                CreateManualAccount();
            else if (CanCreateAutomaticAccount())
               CreateAutomaticAccount();

            // Transition back to accounts view
            var locator = new ViewModelLocator();
            locator.Main.ActiveViewModel = locator.Accounts;
        }


    }
}