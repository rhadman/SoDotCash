using System.Collections.Generic;
using System.Collections.ObjectModel;
using GalaSoft.MvvmLight;
using OFX;
using OFX.Types;

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

        public ObservableCollection<UserAccount> UserAccounts { get; set; } = new ObservableCollection<UserAccount>();

        #endregion

        #region [ Private Backing Fields ]

        private string _testString;

        

        #endregion


        #region [ Constructors ]



        //protected async void LoadAccounts(string username, string password)
        //{
        //    var chaseBankFi = new OFX.OFXFinancialInstitution(new Uri("https://ofx.chase.com"), "B1", "10898");
        //    var userCredentials = new OFX.OFXCredentials(username, password);
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
            TestString = IsInDesignMode
                ? "This is a string that is shown when designing"
                : "This is a string that is shown at runtime";

                var usrAct = new UserAccount();
                usrAct.Accounts = new List<OFX.Types.Account>();
                usrAct.Accounts.Add(new OFX.Types.Account("test",true) {AccountType = AccountEnum.CHECKING});
                UserAccounts.Add(usrAct);
            
            //LoadAccounts("myuser", "mypass");
        }

        #endregion
    }
}