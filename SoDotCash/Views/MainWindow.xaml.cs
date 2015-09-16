using System;
using System.Data.Entity;
using System.IO;
using SoDotCash.Models;

namespace SoDotCash.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            AppDomain.CurrentDomain.SetData("DataDirectory", Path.Combine(AppDomain.CurrentDomain.BaseDirectory, ""));

            //Database.SetInitializer(new DropCreateDatabaseAlways<SoCashDbContext>());

            // TODO: FIXME: For now we drop and recreate the database if the model changes. This is fine for development, but not
            //   for production
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<SoCashDbContext>());

            using (var db = new SoCashDbContext())
            {
                /*
                var fi = new FinancialInstitution()
                {
                    //fiID = 1,
                    name = "Chase",
                    ofxUpdateUrl = "https://ofx.chase.com",
                    ofxOrganizationId = "B1",
                    ofxFinancialUnitId = "10898"
                };
                db.FinancialInstitutions.Add(fi);
                */
                db.SaveChanges();
            }
            //InitializeComponent();
        }
    }
}
