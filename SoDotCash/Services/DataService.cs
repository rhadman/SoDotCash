using System;
using System.Data.Entity;
using System.Deployment.Application;
using System.IO;
using System.Linq;
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
        public static void InitDb()
        {
            // Set the root directory where the database file will be placed
            if (ApplicationDeployment.IsNetworkDeployed)
            {
                // End-user install, create and use the application data directory for this user and application
                var appStoragePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                    "SoDotCash");

                // Create the directory if it does not exist
                if (!Directory.Exists(appStoragePath))
                    Directory.CreateDirectory(appStoragePath);

                AppDomain.CurrentDomain.SetData("DataDirectory", appStoragePath);
            }
            else
            {
                // Developer. Use the directory of the application executable
                AppDomain.CurrentDomain.SetData("DataDirectory", Path.Combine(AppDomain.CurrentDomain.BaseDirectory, ""));
            }


            // TODO: FIXME: For now we drop and recreate the database if the model changes. This is fine for development, but not
            //   for production
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<SoCashDbContext>());

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

        /// <summary>
        /// Add a new transaction to an account.
        /// Called from the UI for manual entry
        /// </summary>
        /// <param name="account">Account to add transactions to</param>
        /// <param name="transaction">Transaction to add</param>
        public static void AddTransaction(Account account, Transaction transaction)
        {
            using (var db = new SoCashDbContext())
            {
                // Retrieve matching account from DB - we need to get an entity in the current db session
                var updateAccount = db.Accounts.First(dbAccount => dbAccount.AccountId == account.AccountId);

                updateAccount.Transactions.Add(transaction);

                db.SaveChanges();
            }
        }

        /// <summary>
        /// Delete a transaction from the database
        /// Called from the UI for manual entry
        /// </summary>
        /// <param name="transaction">Transaction to delete</param>
        public static void DeleteTransaction(Transaction transaction)
        {
            using (var db = new SoCashDbContext())
            {
                // Add the transaction to the context in unchanged state creating a current reference
                db.Entry(transaction).State = EntityState.Unchanged;
                // Delete from database
                db.Set<Transaction>().Remove(transaction);
                // Commit
                db.SaveChanges();
            }
        }

        /// <summary>
        /// Update values of an existing transaction
        /// Called from the UI for edits
        /// </summary>
        /// <param name="transaction">Modified transaction</param>
        public static void UpdateTransaction(Transaction transaction)
        {
            using (var db = new SoCashDbContext())
            {
                // Attach to context and mark as modified
                db.Entry(transaction).State = EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}
