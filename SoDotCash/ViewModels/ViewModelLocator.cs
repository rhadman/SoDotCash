using System;
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
                //a navigation server already exists so no need to register
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