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
using FinancialInstitution = OFX.Protocol.FinancialInstitution;

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

        public RelayCommand LoadTransactionsRelay { get; set; }

        //public ObservableCollection<UserAccount> UserAccounts { get; set; } = new ObservableCollection<UserAccount>();
        public Dictionary<AccountEnum, ObservableCollection<OFX.Types.Account>> AccountsView { get; set; } = new Dictionary<AccountEnum, ObservableCollection<OFX.Types.Account>>();
        public ObservableCollection<OFX.Types.Account> DumbAccounts { get; set; } = new ObservableCollection<OFX.Types.Account>();
        public ObservableCollection<Statement> Statements { get; set; }
        #endregion

        #region [ Private Backing Fields ]

        private string _testString;

        

        #endregion


        #region [ Constructors ]



        //protected async void LoadAccounts(string username, string password)
        //{
        //    var chaseBankFi = new OFX.FinancialInstitution(new Uri("https://ofx.chase.com"), "B1", "10898");
        //    var userCredentials = new OFX.Credentials(username, password);
        //    var ofxService = new OFX.OFX2Service(chaseBankFi, userCredentials);

        //    DateTimeOffset endTime = DateTimeOffset.Now;
        //    DateTimeOffset startTime = endTime - new TimeSpan(1, 0, 0, 0);
        //    foreach (var account in await ofxService.ListAccounts())
        //    {
        //        Models.Account viewAccount;
        //        if (account is OFX.Types.CheckingAccount)
        //        {
        //            viewAccount = new Models.Account
        //            {
        //                Name = ((OFX.Types.CheckingAccount)account).AccountId,
        //                AccountType = EAccountType.Checking
        //            };
        //        }
        //        else if (account is OFX.Types.SavingsAccount)
        //        {
        //            viewAccount = new Models.Account
        //            {
        //                Name = ((OFX.Types.SavingsAccount)account).AccountId,
        //                AccountType = EAccountType.Savings
        //            };
        //        }
        //        else //(account is OFX.Types.CreditCardAccount)
        //        {
        //            viewAccount = new Models.Account
        //            {
        //                Name = ((OFX.Types.CreditCardAccount)account).AccountId,
        //                AccountType = EAccountType.CreditCard
        //            };
        //        }

        //        //AccountViewItems[viewAccount.AccountType].Accounts.Add(viewAccount);

        //        /*
        //        var statements = await ofxService.GetStatement(account, startTime, endTime);
        //        if (statements != null)
        //        {
        //            foreach (var statement in statements)
        //            {
        //            }
        //        }
        //        */
        //    }
        //}

        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel()
        {
            Statements = new ObservableCollection<Statement>();
            LoadTransactionsRelay = new RelayCommand(LoadTransactionsCommand);

            #region [ Database Init]

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

        #endregion

            TestString = IsInDesignMode
                ? "This is a string that is shown when designing"
                : "This is a string that is shown at runtime";
            
            AccountsView.Add(AccountEnum.CHECKING,
                new ObservableCollection<OFX.Types.Account>
                {
                                new OFX.Types.Account("test", true) {AccountType = AccountEnum.CHECKING}
                            
                    
                });

            
            DumbAccounts.Add(new OFX.Types.Account("test", true) { AccountType = AccountEnum.CHECKING });
        }

        private async void LoadTransactionsCommand()
        {
            var fi = new OFX.Types.FinancialInstitution("State Employees Credit Union", new Uri("https://onlineaccess.ncsecu.org/secuofx/secu.ofx"),
                "SECU", "1001");
            var creds = new Credentials("UserName", "Password");
            var service = new OFX2Service(fi, creds);
            try
            {
                var acts = await service.ListAccounts();
                var endTime = DateTimeOffset.Now;
                var startTime = endTime - new TimeSpan(1, 0, 0, 0);

                var statements = await service.GetStatement(acts.First(), startTime, endTime);

                Statements = new ObservableCollection<Statement>(statements);
            }
            catch (Exception)
            {
                
                throw;
            }
            

            
        }

        #endregion
    }
}