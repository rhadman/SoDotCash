
using System.Data.Entity;
using System.Linq;

namespace SoDotCash.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        string OutputString;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void inputButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            using (var db = new UsageContext())
            {
                // Create and save a new User
                var user = new User { firstName = firstNameInput.Text, middleName = middleNameInput.Text, lastName = lastNameInput.Text, password = passwordInput.Text };
                // add user to Users db
                db.Users.Add(user);
                // save our update
                db.SaveChanges();
                
            }
        }

        private void outputButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            using (var db = new UsageContext())
            {
                // Display all Users from the database 
                
                var query = from b in db.Users
                            orderby b.UserId
                            select b;

                foreach (var item in query)
                {
                    // Write out all attributes
                    outputInput.Text = outputInput.Text + "User ID: " + item.UserId + ", Name: " + item.firstName + " " + item.middleName + " " + item.lastName + ", Password: " + item.password;
                }
            }
            
        }
    }
}
