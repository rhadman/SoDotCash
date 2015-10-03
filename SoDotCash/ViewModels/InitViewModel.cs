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

        public ICommand ViewLoaded => new RelayCommand(Loaded);

        private BackgroundWorker initBackgroundWorker;

        public InitViewModel(IModernNavigationService navService)
        {
            _modernNavigationService = navService;

            initBackgroundWorker = new BackgroundWorker();
            initBackgroundWorker.DoWork += InitBackgroundWorker_DoWork;
            initBackgroundWorker.RunWorkerCompleted += InitBackgroundWorkerOnRunWorkerCompleted;
        }

        private void InitBackgroundWorkerOnRunWorkerCompleted(object sender,
            RunWorkerCompletedEventArgs runWorkerCompletedEventArgs)
        {
            if (DataService.AnyExistAccounts())
                _modernNavigationService.NavigateTo(nameof(ViewModelLocator.Accounts));
            else
                _modernNavigationService.NavigateTo(nameof(ViewModelLocator.Welcome));
        }

        private void InitBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            DataService.InitDb();
        }

        private void Loaded()
        {
            using (BackgroundTaskTracker.BeginTask("InitDB"))
            {
                initBackgroundWorker.RunWorkerAsync();
            }
        }
    }
}