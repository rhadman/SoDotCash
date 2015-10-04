using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Controls;
using System.Windows.Input;
using GalaSoft.MvvmLight.CommandWpf;
using SoDotCash.Models;
using SoDotCash.Services;
using SoDotCash.ViewModels.Navigation;

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
    public class AddAccountViewModel : ModernViewModelBase
    {
        /// <summary>
        /// Reference to navigation service
        /// </summary>
        private readonly IModernNavigationService _modernNavigationService;

        public AddAccountViewModel(IModernNavigationService navService)
        {
            _modernNavigationService = navService;
        }

        /// <summary>
        /// Mapped OnLoaded event trigger - Allows actions when the view is loaded
        /// </summary>
        public ICommand ViewLoaded => new RelayCommand(Loaded);

        /// <summary>
        /// Called when the view associated with this viewmodel is displayed
        /// </summary>
        private void Loaded()
        {
            // Clear properties
            AccountSource = EAccountSource.Automatic;
            AccountName = null;
            SelectedFinancialInstitution = null;
            FinancialInstitutionUsername = null;
            AccountRetrievalFailed = false;
            NoAccountsRetrieved = false;
            AvailableAccounts = null;
            SelectedAccount = null;
        }

        #region [ Always Visible Fields ]


        /// <summary>
        /// Retrieve all account types for populating a selection list
        /// </summary>
        public IEnumerable<AccountType> AllAccountTypes => AccountType.All();

        /// <summary>
        /// Bound selected account source
        /// </summary>
        private EAccountSource _accountSource;

        public EAccountSource AccountSource
        {
            get { return _accountSource; }
            set
            {
                _accountSource = value;
                RaisePropertyChanged();
                RaisePropertyChanged(() => IsManualEntry);
                RaisePropertyChanged(() => IsAutomaticEntry);
            }
        }

        /// <summary>
        /// User entered account name
        /// </summary>
        private string _accountName;
        public string AccountName
        {
            get {  return _accountName; }
            set
            {
                _accountName = value;
                RaisePropertyChanged();
            }
        }

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
        /// Bound to automatic entry grid to control visibility
        /// </summary>
        public bool IsAutomaticEntry => AccountSource == EAccountSource.Automatic;

        /// <summary>
        /// Retrieve all financial institutions supported by OFX - ordered by name
        /// </summary>
        public IEnumerable<OFX.Types.FinancialInstitution> AllFinancialInstitutions
            => OFX.OFX2Service.ListFinancialInstitutions().OrderBy(fi => fi.Name);

        /// <summary>
        /// Bound to the user selection of financial institution
        /// </summary>
        private OFX.Types.FinancialInstitution _selectedFinancialInstitution;

        public OFX.Types.FinancialInstitution SelectedFinancialInstitution
        {
            get { return _selectedFinancialInstitution; }
            set
            {
                _selectedFinancialInstitution = value;
                RaisePropertyChanged();
            }
        }

        /// <summary>
        /// Username used to authenticate with the financial institution
        /// </summary>
        private string _financialInstitutionUsername;

        public string FinancialInstitutionUsername
        {
            get { return _financialInstitutionUsername; }
            set
            {
                _financialInstitutionUsername = value;
                RaisePropertyChanged();
            }
        }


        /// <summary>
        /// List of accounts available from financial institution using the provided credentials
        /// </summary>
        private IEnumerable<Account> _availableAccounts;

        public IEnumerable<Account> AvailableAccounts
        {
            get { return _availableAccounts; }
            set
            {
                _availableAccounts = value;
                RaisePropertyChanged();
                RaisePropertyChanged(() => HasAvailableAccounts);
            }
        }

        /// <summary>
        /// The account selected from the list presented by the FI
        /// </summary>
        public Account SelectedAccount { get; set; }

        /// <summary>
        /// Bound to autoamtic entry grid to control visibility
        /// </summary>
        public bool HasAvailableAccounts => AvailableAccounts != null && AvailableAccounts.Any();

        /// <summary>
        /// Bound indicator of whether account retrieval failed (invalid credentials)
        /// </summary>
        private bool _accountRetrievalFailed;

        public bool AccountRetrievalFailed
        {
            get { return _accountRetrievalFailed; }
            set
            {
                _accountRetrievalFailed = value;
                RaisePropertyChanged();
            }
        }

        /// <summary>
        /// Bound indicator of whether the account retrieval succeded but no new accounts were retrieved
        /// </summary>
        private bool _noAccountsRetrieved;

        public bool NoAccountsRetrieved
        {
            get { return _noAccountsRetrieved; }
            set
            {
                _noAccountsRetrieved = value;
                RaisePropertyChanged();
            }
        }

        /// <summary>
        /// Binding for the Retrieve Accounts button
        /// </summary>
        private ICommand _retrieveAccountsCommand;

        public ICommand RetrieveAccountsCommand
            =>
                _retrieveAccountsCommand ??
                (_retrieveAccountsCommand = new RelayCommand<object>(PopulateAccounts, CanPopulateAccounts));

        /// <summary>
        /// Called to determine whether the user has provided enough information to populate FI account list
        /// </summary>
        /// <param name="passwordEntry">Reference to password entry box</param>
        /// <returns>True - enough information is present.  False - Insufficient information entered</returns>
        private bool CanPopulateAccounts(object passwordEntry)
        {
            // Must have a username
            if (string.IsNullOrEmpty(FinancialInstitutionUsername))
                return false;

            // Must have a selected FI
            if (SelectedFinancialInstitution == null)
                return false;

            // Retrieve password from entry
            var passwordBox = passwordEntry as PasswordBox;
            var password = passwordBox?.Password;

            // Must have a password entered
            return !string.IsNullOrEmpty(password);
        }

        /// <summary>
        /// Cancels action. Returns to previous view.
        /// </summary>
        public async void PopulateAccounts(object passwordEntry)
        {
            // Retrieve password from entry
            var passwordBox = passwordEntry as PasswordBox;
            var password = passwordBox?.Password;

            // Reset account retrieval failed indicator
            AccountRetrievalFailed = false;

            // Clear current list of accounts
            AvailableAccounts = null;

            // Form Credentials
            var fiCredentials = new OFX.Types.Credentials(FinancialInstitutionUsername, password);

            try
            {
                // Retrieve accounts from fI
                AvailableAccounts =
                    await
                        UpdateService.EnumerateNewAccounts(SelectedFinancialInstitution, fiCredentials)
                            .ConfigureAwait(false);

                // If no accounts were retrieved, notify user
                NoAccountsRetrieved = !AvailableAccounts.Any();
            }
            catch (Exception)
            {
                // Error retrieving accounts
                AccountRetrievalFailed = true;
            }
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
        //private RelayCommand<string> _createAccountCommand;
        public RelayCommand<object> CreateAccountCommand => new RelayCommand<object>(CreateAccount, CanCreateAccount);

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
        private bool CanCreateAutomaticAccount(object passwordEntry)
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

            // Retrieve password from entry
            var passwordBox = passwordEntry as PasswordBox;
            var password = passwordBox?.Password;

            // A password must be entered
            if (string.IsNullOrEmpty(password))
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
        public bool CanCreateAccount(object passwordEntry)
        {
            return CanCreateManualAccount() || CanCreateAutomaticAccount(passwordEntry);
        }

        /// <summary>
        /// Create a manual-entry account from the provided information
        /// </summary>
        /// <returns>Created account</returns>
        protected Account CreateManualAccount()
        {
            // Fill in account data
            var newAccount = new Account
            {
                AccountName = AccountName,
                AccountType = SelectedAccountType,
                Currency = "USD"
            };

            using (var dataService = new DataService())
            {
                // Add to database
                dataService.AddAccount(newAccount);
            }

            return newAccount;
        }

        /// <summary>
        /// Create an automatic-update account from the provided information
        /// </summary>
        /// <returns>Created account</returns>
        protected Account CreateAutomaticAccount(object passwordEntry)
        {
            // Retrieve password from entry
            var passwordBox = passwordEntry as PasswordBox;
            var password = passwordBox?.Password;

            // Attach account name to account
            SelectedAccount.AccountName = AccountName;

            Account newAccount;
            using (var dataService = new DataService())
            {
                // Add to database
                newAccount = dataService.AddAccount(SelectedAccount, SelectedFinancialInstitution,
                    new FinancialInstitutionUser
                    {
                        UserId = FinancialInstitutionUsername,
                        Password = password
                    }
                    );
            }

            // Start an automatic background retrieval of transactions for this account
            var unwaitedTask = UpdateService.DownloadOfxTransactionsForAccount(newAccount);
            unwaitedTask.ConfigureAwait(false);

            return newAccount;
        }

        /// <summary>
        /// Creates the new account from the information in the form.
        /// </summary>
        public void CreateAccount(object passwordEntry)
        {
            // Create the account of the appropriate manual/automatic type
            Account newAccount;
            if (CanCreateManualAccount())
                newAccount = CreateManualAccount();
            else if (CanCreateAutomaticAccount(passwordEntry))
                // Create the automatic account
                newAccount = CreateAutomaticAccount(passwordEntry);
            else
                return; // Unreachable

            var locator = new ViewModelLocator();
            
            // Update accounts on accounts view
            locator.Accounts.UpdateAccounts();

            // Navigate to empty tab
            locator.Accounts.SelectedTabSource = null;

            // Transition back to accounts view
            _modernNavigationService.NavigateTo(nameof(ViewModelLocator.Accounts));

            // Do not allow navigation back to add account screen
            _modernNavigationService.ClearNavigationHistory();
        }


    }
}