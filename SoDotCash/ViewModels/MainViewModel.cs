using System.Collections.Generic;
using GalaSoft.MvvmLight;
using OFX.Types;
using SoDotCash.Services;
using SoDotCash.Models;

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

        #region [ Constructors ]


        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel()
        {
            // Initialize the databas
            DataService.InitDb();

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
    }
}