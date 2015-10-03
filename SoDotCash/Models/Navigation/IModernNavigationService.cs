using GalaSoft.MvvmLight.Views;

namespace SoDotCash.Models
{
    public interface IModernNavigationService : INavigationService
    {
        object Parameter { get; }
    }
}