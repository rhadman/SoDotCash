using System.Windows;
using System.Windows.Input;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using SoDotCash.ViewModels.Navigation;

namespace SoDotCash.ViewModels
{

    /// <summary>
    /// The main application window. This is a shell for views displayed within
    /// </summary>
    public class MainViewModel : ModernViewModelBase
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
        public MainViewModel(IModernNavigationService navService)
        {
            ViewLoaded = new RelayCommand(Loaded);
        }

        /// <summary>
        /// Command handling the view loaded event
        /// </summary>
        public ICommand ViewLoaded { get; }

        /// <summary>
        /// Called when this view is loaded
        /// </summary>
        private void Loaded()
        {
            NavigationCommands.GoToPage.Execute("/Views/Initializing.xaml",
                NavigationService.GetDescendantFromName(Application.Current.MainWindow));
        }


        #endregion
    }
}