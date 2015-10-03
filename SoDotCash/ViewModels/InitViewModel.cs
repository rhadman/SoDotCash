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

        public ICommand ViewLoaded => new RelayCommand(Loaded);
        
        public InitViewModel(IModernNavigationService navService)
        {
            _modernNavigationService = navService;
        }

        private void Loaded()
        {
            using (BackgroundTaskTracker.BeginTask("InitDB"))
            {
               Load();
            }

            if(DataService.AnyExistAccounts())
                _modernNavigationService.NavigateTo(nameof(ViewModelLocator.Accounts));
            else
                _modernNavigationService.NavigateTo(nameof(ViewModelLocator.Welcome));
            
        }

        async private Task Load()
        {
            await LoadDB();
        }

        async private Task LoadDB()
        {
            DataService.InitDb();
        }
        
    }
}