using System;
using System.ComponentModel;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;
using GalaSoft.MvvmLight.CommandWpf;
using SoDotCash.Models;
using SoDotCash.Services;

namespace SoDotCash.ViewModels
{
    public class InitViewModel : ModernViewModelBase
    {
        private readonly IModernNavigationService _modernNavigationService;

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
            // Perform the rest of the init asyncronously
            AsyncInit();
        }

        /// <summary>
        /// Async wrapper for database init followed by proper page transition
        /// </summary>
        private async void AsyncInit()
        {
            // Initialize database
            await Task.Run(() => DataService.InitDb());

            // Transition to Welcome screen if no accounts, otherwise account list
            if (DataService.AnyExistAccounts())
                _modernNavigationService.NavigateTo(nameof(ViewModelLocator.Accounts));
            else
                _modernNavigationService.NavigateTo(nameof(ViewModelLocator.Welcome));
        }

    }
}