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

using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;

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
            SimpleIoc.Default.Register<TransactionsViewModel>();
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
        /// The single transactions view model. The transactions view populates from the parent's DataContext, so this VM is a
        ///   shell that assists with navigation
        /// </summary>
        public TransactionsViewModel Transactions => ServiceLocator.Current.GetInstance<TransactionsViewModel>();


        public static void Cleanup()
        {
            // TODO Clear the ViewModels
        }
    }
}