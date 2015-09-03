using GalaSoft.MvvmLight;

namespace SoDotCash.ViewModels
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        #region [ Public Bound Properties ]

        public string TestString
        {
            get { return _testString; }
            set
            {
                _testString = value; 
                RaisePropertyChanged();
            }
        }

        #endregion

        #region [ Private Backing Fields ]

        private string _testString;

        #endregion

        #region [ Constructors ]

        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel()
        {
            TestString = IsInDesignMode ? "This is a string that is shown when designing" : "This is a string that is shown at runtime";
        }

        #endregion
    }
}