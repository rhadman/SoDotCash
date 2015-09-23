using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using SoDotCash.ViewModels;

namespace SoDotCash.Views
{
    /// <summary>
    /// Interaction logic for AddAccountView.xaml
    /// </summary>
    public partial class AddAccountView : UserControl
    {
        public AddAccountView()
        {
            InitializeComponent();
        }

        
        private void textBox_Password_PasswordChanged(object sender, RoutedEventArgs e)
        {
            // Password box entries can't be bound directly, so we route here
            if (this.DataContext != null)
            { ((dynamic)this.DataContext).FinancialInstitutionPassword = ((PasswordBox)sender).Password; }
        }
    }
}
