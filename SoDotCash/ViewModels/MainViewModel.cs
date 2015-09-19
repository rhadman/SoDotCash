using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Windows;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using OFX;
using OFX.Protocol;
using OFX.Types;

//using SoDotCash.Models;

//using SoDotCash.Models;

namespace SoDotCash.ViewModels
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {

        #region [ Public Bound Properties ]

        public string TestString
        {
            get { return _testString; }
            set
            {
                _testString = value;
                RaisePropertyChanged();
            }
        }

        public RelayCommand<int> LoadTransactionsRelay { get; set; }
        public RelayCommand<OFX.Types.Account> SelectedAccountChangedCommand { get; set; }


        //public ObservableCollection<UserAccount> UserAccounts { get; set; } = new ObservableCollection<UserAccount>();
        public Dictionary<AccountEnum, ObservableCollection<OFX.Types.Account>> AccountsView { get; set; } =
            new Dictionary<AccountEnum, ObservableCollection<OFX.Types.Account>>();

        public ObservableCollection<OFX.Types.Account> DumbAccounts { get; set; } =
            new ObservableCollection<OFX.Types.Account>();

        public ObservableCollection<Statement> Statements { get; set; }

        public OFX.Types.Account SelectedAccount
        {
            get { return _selectedAccount; }
            set
            {
                _selectedAccount = value;
                SelectedAccountChanged();
                RaisePropertyChanged();
            }
        }

        public bool RetrievingTransactions
        {
            get { return _retrievingTransactions; }
            set
            {
                _retrievingTransactions = value;
                RaisePropertyChanged();
            }
        }

        #endregion

        #region [ Private Backing Fields ]

        private string _testString;
        private bool _retrievingTransactions;
        private OFX.Types.Account _selectedAccount;

        #endregion

        #region [ Private fields ]

        private IEnumerable<Statement> _statementCollection = new Collection<Statement>();

        #endregion

        #region [ Constructors ]


        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel()
        {
            Statements = new ObservableCollection<Statement>();
            LoadTransactionsRelay = new RelayCommand<int>(LoadTransactionsCommand);

            InitDB();

            TestString = IsInDesignMode
                ? "This is a string that is shown when designing"
                : "This is a string that is shown at runtime";

            //AccountsView.Add(AccountEnum.CHECKING,
            //    new ObservableCollection<OFX.Types.Account>
            //    {
            //        new OFX.Types.Account("test", true) {AccountType = AccountEnum.CHECKING}
            //    });

            //DumbAccounts.Add(new OFX.Types.Account("test", true) { AccountType = AccountEnum.CHECKING });
        }

        #endregion

        #region [ Database Init ]

        private void InitDB()
        {


            AppDomain.CurrentDomain.SetData("DataDirectory", Path.Combine(AppDomain.CurrentDomain.BaseDirectory, ""));

            //Database.SetInitializer(new DropCreateDatabaseAlways<SoCashDbContext>());

            // TODO: FIXME: For now we drop and recreate the database if the model changes. This is fine for development, but not
            //   for production
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<Models.SoCashDbContext>());

            using (var db = new Models.SoCashDbContext())
            {
                /*
                var fi = new FinancialInstitution()
                {
                    //fiID = 1,
                    name = "Chase",
                    ofxUpdateUrl = "https://ofx.chase.com",
                    ofxOrganizationId = "B1",
                    ofxFinancialUnitId = "10898"
                };
                db.FinancialInstitutions.Add(fi);
                */
                db.SaveChanges();
            }
        }

        #endregion

        #region [ Relay Commands ]

        private async void LoadTransactionsCommand(int counter = 0)
        {
            RetrievingTransactions = true;
            
            var fi = new OFX.Types.FinancialInstitution("State Employees Credit Union",
                new Uri("https://onlineaccess.ncsecu.org/secuofx/secu.ofx"),
                "SECU", "1001");
            var creds = new Credentials("username", "password");
            var service = new OFX2Service(fi, creds);
            try
            {
                var acts = await service.ListAccounts();
                var endTime = DateTimeOffset.Now;
                var startTime = endTime - new TimeSpan(30, 0, 0, 0);


                //TODO: IMPLEMENT ITERATING OVER ACCOUNTS AND HANDLE EXCEPTIONS MORE GRACIOUSLY
                //var stmts = new List<OFX.Types.Statement>();

                //foreach (var account in acts)
                //{
                //    stmts.AddRange(await service.GetStatement(account, startTime, endTime));
                //}

                //_statementCollection = stmts;

                _statementCollection = await service.GetStatement(acts.First(), startTime, endTime);

                //Statements = new ObservableCollection<Statement>(statements);
                RaisePropertyChanged("Statements");

                var accountList = acts.GroupBy(act => act.AccountType);

                AccountsView = new Dictionary<AccountEnum, ObservableCollection<OFX.Types.Account>>();

                foreach (var act in accountList)
                {
                    AccountsView.Add(act.Key, new ObservableCollection<OFX.Types.Account>(act.ToList()));
                }
                RaisePropertyChanged("AccountsView");
            }
            catch (Exception ex)
            {
                if (counter > 5)
                {
                    MessageBox.Show($"An Error Occured When Retrieved your account info.  Please Try Again\n{ex.Message}\n{ex.StackTrace}", "Error");
                    return;
                }
                LoadTransactionsCommand(++counter);
            }


            RetrievingTransactions = false;
        }

        public void SetSelectedItem(object account)
        {
            if ((account as OFX.Types.Account) == null)
                return;

            SelectedAccount = (OFX.Types.Account) account;
        }

        #endregion

        #region [ Helper Commands ]

        private void SelectedAccountChanged()
        {
            Statements.Clear();
            foreach (
                var statement in
                    _statementCollection.Where(
                        statement => statement.OwningAccount.AccountId == SelectedAccount.AccountId)
                        )
            {
                Statements.Add(statement);
            }
            
        }

        #endregion
    }
}