using System.Windows;
using System.Windows.Controls;


namespace SoDotCash.Views
{
    /// <summary>
    /// Interaction logic for AddAccountView.xaml
    /// </summary>
    public partial class AddAccountView
    {
        public AddAccountView()
        {
            InitializeComponent();
        }

        
        private void textBox_Password_PasswordChanged(object sender, RoutedEventArgs e)
        {
            // Password box entries can't be bound directly, so we route here
            if (DataContext != null)
            { ((dynamic)DataContext).FinancialInstitutionPassword = ((PasswordBox)sender).Password; }
        }
    }
}
