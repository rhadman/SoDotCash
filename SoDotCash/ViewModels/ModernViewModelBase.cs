using System.Windows.Input;
using GalaSoft.MvvmLight;

namespace SoDotCash.ViewModels
{
    /// <summary>
    /// Extends the basic ViewModel class with commands triggered by ModernUI
    /// </summary>
    public abstract class ModernViewModelBase : ViewModelBase
    {
        /// <summary>
        /// Called before navigating away from the view
        /// </summary>
        /// <value>Command to execute when event is triggered.</value>
        public ICommand NavigatingFromCommand { get; set; }

        /// <summary>
        /// Called after navigating away from the view
        /// </summary>
        /// <value>Command to execute when event is triggered.</value>
        public ICommand NavigatedFromCommand { get; set; }

        /// <summary>
        /// Called after navigating to from the view
        /// </summary>
        /// <value>Command to execute when event is triggered.</value>
        public ICommand NavigatedToCommand { get; set; }

        /// <summary>
        /// Called to navigate to a different page fragment
        /// </summary>
        /// <value>Command to execute when event is triggered.</value>
        public ICommand FragmentNavigationCommand { get; set; }

        /// <summary>
        /// Called when the view is loaded
        /// </summary>
        /// <value>Command to execute when event is triggered.</value>
        public ICommand LoadedCommand { get; set; }

        /// <summary>
        /// Called when visibility is changed
        /// </summary>
        /// <value>Command to execute when event is triggered.</value>
        public ICommand IsVisibleChangedCommand { get; set; }
    }
}