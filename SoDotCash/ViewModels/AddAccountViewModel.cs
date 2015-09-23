using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Windows;
using System.Windows.Input;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using OFX;
using OFX.Protocol;
using SoDotCash.Models;

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
        public Account SelectedAccount { get; set; }

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

            // Retrieve accounts from fI
            var ofxService = new OFX2Service(SelectedFinancialInstitution, new OFX.Types.Credentials(FinancialInstitutionUsername, FinancialInstitutionPassword.ToString()));
            var accountList = new List<Account>();
            var ofxAccountList = await ofxService.ListAccounts();

            // TODO: If ofxAccountList is null, display error message

            foreach (var ofxAccount in ofxAccountList)
            {
                // Convert from OFX account type to db account type
                AccountType accountType;
                switch (ofxAccount.AccountType)
                {
                    case AccountEnum.SAVINGS:
                        accountType = AccountType.SAVINGS;
                        break;
                    case AccountEnum.CREDITLINE:
                        accountType = AccountType.CREDITCARD;
                        break;
                    default:
                        accountType = AccountType.CHECKING;
                        break;
                }
                accountList.Add(new Account {accountName=accountType.ToString() + ":" + ofxAccount.AccountId + "(" + ofxAccount.Description+")", accountType=accountType.ToString(),currency="USD", fiAccountID = ofxAccount.AccountId});
            }
            AvailableAccounts = accountList;
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
        private ICommand _createAccountCommand;
        public ICommand CreateAccountCommand
        {
            get { return _createAccountCommand ?? (_createAccountCommand = new RelayCommand(CreateAccount, CanCreateAccount)); }
        }


        /// <summary>
        /// Called to determine whether there's enough information selected to create an account
        /// </summary>
        /// <returns></returns>
        public bool CanCreateAccount()
        {
            return true;
        }

        /// <summary>
        /// Creates the new account from the information in the form.
        /// </summary>
        public void CreateAccount()
        {
            // Add the new account
            using (var db = new SoCashDbContext())
            {
                var newAccount = new Account
                {
                    accountName = AccountName,
                    accountID = 0,
                    accountType = SelectedAccountType,
                    currency = "USD"
                };
                db.Accounts.Add(newAccount);
                db.SaveChanges();
            }

            // Transition back to accounts view
            var locator = new ViewModelLocator();
            locator.Main.ActiveViewModel = locator.Accounts;
        }


    }
}