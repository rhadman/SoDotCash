using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoDotCash.Models;

namespace SoDotCash.Services
{
    /// <summary>
    /// Provides functionality for accessing and manipulating application data.
    /// Reusable application logic should be placed here
    /// </summary>
    public class DataService
    {
        /// <summary>
        /// Initialize the database for first use by the application
        /// </summary>
        public static void InitDB()
        {
            // Set the root directory where the database file will be placed
            // NOTE: In the future this would ideally be set to the application data path of the installed application for the current user
            AppDomain.CurrentDomain.SetData("DataDirectory", Path.Combine(AppDomain.CurrentDomain.BaseDirectory, ""));

            // TODO: FIXME: For now we drop and recreate the database if the model changes. This is fine for development, but not
            //   for production
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<Models.SoCashDbContext>());

            //Database.SetInitializer(new DropCreateDatabaseAlways<Models.SoCashDbContext>());

            // Open the database and perform necessary schema adjustments
            using (var db = new SoCashDbContext())
            {
                db.Database.Initialize(false);
            }

        }

        /// <summary>
        /// Determine if there are any existing accounts in the database
        /// </summary>
        /// <returns>
        /// True - There are existing accounts
        /// False - There are no accounts
        /// </returns>
        public static bool AnyExistAccounts()
        {
            using (var db = new SoCashDbContext())
            {
                return db.Accounts.Any();
            }
        }
    }
}
