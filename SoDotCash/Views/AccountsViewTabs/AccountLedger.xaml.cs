
using System.ComponentModel;
using System.Linq;
using System.Windows;
using System.Windows.Media;
using FirstFloor.ModernUI.Presentation;

namespace SoDotCash.Views.AccountsViewTabs
{
    /// <summary>
    /// Interaction logic for AccountLedger.xaml
    /// </summary>
    public partial class AccountLedger
    {

        private Color _selectedAccentColor;
        private readonly LinkCollection _themes = new LinkCollection();
        private Link _selectedTheme;
        private string _selectedFontSize;

        public AccountLedger()
        {
            InitializeComponent();
            DatagridTransactions.BorderThickness = new Thickness(1);
            DatagridTransactions.BorderBrush = new SolidColorBrush(AppearanceManager.Current.AccentColor);
            
            AppearanceManager.Current.PropertyChanged += CurrentOnPropertyChanged;

        }

        private void CurrentOnPropertyChanged(object sender, PropertyChangedEventArgs propertyChangedEventArgs)
        {
            DatagridTransactions.BorderBrush = new SolidColorBrush(AppearanceManager.Current.AccentColor);
        }
    }
}
