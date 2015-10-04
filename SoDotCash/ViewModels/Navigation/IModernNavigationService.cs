using GalaSoft.MvvmLight.Views;

namespace SoDotCash.ViewModels.Navigation
{
    public interface IModernNavigationService : INavigationService
    {
        object Parameter { get; }

        void ClearNavigationHistory();
    }
}