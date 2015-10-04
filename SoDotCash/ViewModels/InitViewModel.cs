using System.Threading.Tasks;
using System.Windows.Input;
using GalaSoft.MvvmLight.CommandWpf;
using SoDotCash.Services;
using SoDotCash.ViewModels.Navigation;

namespace SoDotCash.ViewModels
{
    public class InitViewModel : ModernViewModelBase
    {
        /// <summary>
        /// Service for changing current page
        /// </summary>
        private readonly IModernNavigationService _modernNavigationService;

        /// <summary>
        /// Indicator of whether initialization has been called
        /// </summary>
        private bool _initialized;

        /// <summary>
        /// Mapped OnLoaded event trigger - Allows actions when the view is loaded
        /// </summary>
        public ICommand ViewLoaded => new RelayCommand(Loaded);

        public InitViewModel(IModernNavigationService navService)
        {
            _modernNavigationService = navService;
        }

        /// <summary>
        /// Called when the view associated with this viewmodel loads
        /// </summary>
        private void Loaded()
        {
            // Initialize only once
            if (!_initialized)
            {
                _initialized = true;
                // Perform the rest of the init asyncronously
                AsyncInit();
            }
        }

        /// <summary>
        /// Async wrapper for database init followed by proper page transition
        /// </summary>
        private async void AsyncInit()
        {
            // Initialize database
            await Task.Run(() => DataService.Initialize());

            // If there are accounts, start in the accounts view
            using (var dataService = new DataService())
            {
                if (dataService.AnyExistingAccounts())
                    _modernNavigationService.NavigateTo(nameof(ViewModelLocator.Accounts));
                else
                    // No existing accounts, show welcome screen
                    _modernNavigationService.NavigateTo(nameof(ViewModelLocator.Welcome));
            }

            //prevent the user from navigating to this point or further back
            _modernNavigationService.ClearNavigationHistory();
        }

    }
}