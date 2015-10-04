using GalaSoft.MvvmLight.Views;

namespace SoDotCash.ViewModels.Navigation
{
    /// <summary>
    /// Basic NavigationService Interface provided by ModernUI
    /// </summary>
    public interface IModernNavigationService : INavigationService
    {
        object Parameter { get; }
        
        void ClearNavigationHistory();

    }
}