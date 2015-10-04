using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using FirstFloor.ModernUI.Presentation;
using GalaSoft.MvvmLight;
using SoDotCash.ViewModels.Navigation;
using RelayCommand = GalaSoft.MvvmLight.CommandWpf.RelayCommand;

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

            // Load our settings from the saved configuration (if present)
            LoadSettings();
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

        /// <summary>
        /// Load application settings from saved configuration and apply
        /// </summary>
        private void LoadSettings()
        {
            //load user visual preferences
            switch (Properties.Settings.Default.Theme)
            {
                default:
                // ReSharper disable once RedundantCaseLabel we may add more themes at a later date
                case "dark":
                    AppearanceManager.Current.ThemeSource = AppearanceManager.DarkThemeSource;
                    break;
                case "light":
                    AppearanceManager.Current.ThemeSource = AppearanceManager.LightThemeSource;
                    break;
            }
            
            //Try to convert the color in the config file to be a color
            //  if any of it fails then leave it to the default color
            try
            {   
                var colorFromString = ColorConverter.ConvertFromString(Properties.Settings.Default.Accent) ??
                                      ColorConverter.ConvertFromString("#FF1BA1E2");

                AppearanceManager.Current.AccentColor = (Color)colorFromString;
            }
            catch (Exception)
            {
                AppearanceManager.Current.AccentColor = (Color)ColorConverter.ConvertFromString("#FF1BA1E2");
            }
        }

        #endregion
    }
}