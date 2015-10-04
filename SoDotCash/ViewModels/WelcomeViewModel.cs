using System.Windows.Input;
using GalaSoft.MvvmLight.CommandWpf;
using SoDotCash.ViewModels.Navigation;

namespace SoDotCash.ViewModels
{
    /// <summary>
    /// This class contains the buisiness logic interface for the Welcome View
    /// </summary>
    public class WelcomeViewModel : ModernViewModelBase
    {
        private readonly IModernNavigationService _modernNavigationService;

        public WelcomeViewModel(IModernNavigationService navService)
        {
            _modernNavigationService = navService;
        }

        /// <summary>
        /// Binding for the Download Transactions button
        /// </summary>
        private ICommand _getStartedCommand;
        public ICommand GetStartedCommand
        {
            get { return _getStartedCommand ?? (_getStartedCommand = new RelayCommand(GetStarted, () => true)); }
        }

        /// <summary>
        /// Progresses from the welcome screen on to the accounts screen and positions to add account
        /// </summary>
        public void GetStarted()
        {
            // Transition view to add account
            _modernNavigationService.NavigateTo(nameof(ViewModelLocator.AddAccount));

            // Do not allow navigation back to welcome screen
            _modernNavigationService.ClearNavigationHistory();
        }
    }
}