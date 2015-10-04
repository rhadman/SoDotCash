/*
  In App.xaml:
  <Application.Resources>
      <vm:ViewModelLocator xmlns:vm="clr-namespace:SoDotCash"
                           x:Key="Locator" />
  </Application.Resources>
  
  In the View:
  DataContext="{Binding Source={StaticResource Locator}, Path=ViewModelName}"

  You can also use Blend to do all this with the tool's support.
  See http://www.galasoft.ch/mvvm
*/

using System;
using System.Windows.Media;
using FirstFloor.ModernUI.Presentation;
using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;
using SoDotCash.ViewModels.Navigation;

namespace SoDotCash.ViewModels
{
    /// <summary>
    /// This class contains static references to all the view models in the
    /// application and provides an entry point for the bindings.
    /// </summary>
    public class ViewModelLocator
    {
        /// <summary>
        /// Initializes a new instance of the ViewModelLocator class.
        /// </summary>
        public ViewModelLocator()
        {
            //load user visual preferences
            switch (Properties.Settings.Default.Theme)
            {
                default:
                case "dark":
                    AppearanceManager.Current.ThemeSource = AppearanceManager.DarkThemeSource;
                    break;
                case "light":
                    AppearanceManager.Current.ThemeSource = AppearanceManager.LightThemeSource;
                    break;
            }

            //try to convert the color in the config file to be a color
            //if any of it fails then set it to the default color
            try
            {
                var convertFromString = ColorConverter.ConvertFromString(Properties.Settings.Default.Accent);
                if (convertFromString != null)
                    AppearanceManager.Current.AccentColor = (Color) convertFromString;
                convertFromString = ColorConverter.ConvertFromString("#FF1BA1E2");
                AppearanceManager.Current.AccentColor = (Color) convertFromString;
            }
            
            catch (Exception)
            {   
                AppearanceManager.Current.AccentColor = (Color) ColorConverter.ConvertFromString("#FF1BA1E2");
            }



            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            SimpleIoc.Default.Register<MainViewModel>();
            SimpleIoc.Default.Register<AccountsViewModel>();
            SimpleIoc.Default.Register<AddAccountViewModel>();
            SimpleIoc.Default.Register<WelcomeViewModel>();
            SimpleIoc.Default.Register<SettingsViewModel>();
            SimpleIoc.Default.Register<InitViewModel>();

            var navigationService = new NavigationService();
            navigationService.Configure(nameof(Main), new Uri("/Views/MainWindow.xaml", UriKind.RelativeOrAbsolute));
            navigationService.Configure(nameof(Accounts), new Uri("/Views/AccountsView.xaml", UriKind.RelativeOrAbsolute));
            navigationService.Configure(nameof(AddAccount), new Uri("/Views/AddAccountView.xaml", UriKind.RelativeOrAbsolute));
            navigationService.Configure(nameof(Welcome), new Uri("/Views/WelcomeView.xaml", UriKind.RelativeOrAbsolute));
            navigationService.Configure(nameof(Settings), new Uri("/Views/SettingsView.xaml", UriKind.RelativeOrAbsolute));
            navigationService.Configure(nameof(Init), new Uri("/Views/Initializing.xaml", UriKind.RelativeOrAbsolute));

            try
            {
                SimpleIoc.Default.Register<IModernNavigationService>(() => navigationService);
            }
            catch
            {
                //a navigation server alreayd exists so no need to register
            }
        }

        /// <summary>
        /// The single main view model - backing the single MainWindow
        /// </summary>
        public MainViewModel Main => ServiceLocator.Current.GetInstance<MainViewModel>();

        /// <summary>
        /// The single accounts view model - backing the single AccountsView
        /// </summary>
        public AccountsViewModel Accounts => ServiceLocator.Current.GetInstance<AccountsViewModel>();

        /// <summary>
        /// The single add account view model - backing the single AddAccountView
        /// </summary>
        public AddAccountViewModel AddAccount => ServiceLocator.Current.GetInstance<AddAccountViewModel>();

        /// <summary>
        /// The single welcome view model - backing the single WelcomeView
        /// </summary>
        public WelcomeViewModel Welcome => ServiceLocator.Current.GetInstance<WelcomeViewModel>();

        /// <summary>
        /// the settings view model
        /// </summary>
        public SettingsViewModel Settings => ServiceLocator.Current.GetInstance<SettingsViewModel>();

        /// <summary>
        /// the initialization view model for the application
        /// </summary>
        public InitViewModel Init => ServiceLocator.Current.GetInstance<InitViewModel>();

        public static void Cleanup()
        {
        }
    }
}