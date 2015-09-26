using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.IO;
using GalaSoft.MvvmLight;
using OFX.Types;
using SoDotCash.Services;

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

        #endregion

        #region [ Private Backing Fields ]

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
            // Initialize the databas
            DataService.InitDB();

            // Determing initial view
            var locator = new ViewModelLocator();

            // If there are accounts, start in the accounts view
            if (DataService.AnyExistAccounts())
                ActiveViewModel = locator.Accounts;
            else
                // No existing accounts, show welcome screen
                ActiveViewModel = locator.Welcome;

        }

        #endregion

        #region [ Relay Commands ]

        /*
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
        */


        #endregion


    }
}