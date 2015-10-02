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

        /// <summary>
        /// Add an account to the database
        /// </summary>
        /// <param name="account">Populated account entity to add to database</param>
        /// <returns>Created account</returns>
        public static Account AddAccount(Account account)
        {
            // Add the new account
            using (var db = new SoCashDbContext())
            {
                // Add to database
                db.Accounts.Add(account);

                // Commit changes
                db.SaveChanges();
            }

            return account;
        }

        /// <summary>
        /// Add an account to the database - Using OFX data specification
        /// </summary>
        /// <param name="account">Populated account object to add to database</param>
        /// <param name="financialInstitution">OFX financial institution to link in database. Will be created if necessary.</param>
        /// <param name="fiUser">User credentials for the financial institution</param>
        /// <returns>Created account</returns>
        public static Account AddAccount(Account account, OFX.Types.FinancialInstitution financialInstitution, FinancialInstitutionUser fiUser)
        {
            // Add the new account, financial institution and user
            using (var db = new SoCashDbContext())
            {
                // TODO: See if there's an existing FI or user with this info already
                // Look for existing FI entry with the same name
                FinancialInstitution fi;
                try
                {
                    fi = db.FinancialInstitutions.First(i => i.Name == financialInstitution.Name);
                }
                catch (InvalidOperationException)
                {
                    // FI Doesn't exist, add a new one
                    fi = new FinancialInstitution
                    {
                        Name = financialInstitution.Name,
                        OfxFinancialUnitId = financialInstitution.FinancialId,
                        OfxOrganizationId = financialInstitution.OrganizationId,
                        OfxUpdateUrl = financialInstitution.ServiceEndpoint.ToString()
                    };
                    db.FinancialInstitutions.Add(fi);
                }

                // Look for existing user under this FI with same userId
                try
                {
                    fiUser = fi.Users.First(u => u.UserId == fiUser.UserId && u.Password == fiUser.Password);
                }
                catch (Exception)
                {
                    // User doesn't exist, add as new
                    fi.Users.Add(fiUser);
                    db.FinancialInstitutionUsers.Add(fiUser);
                }

                fiUser.Accounts.Add(account);
                db.Accounts.Add(account);

                db.SaveChanges();

                return account;
            }
        }


        /// <summary>
        /// Delete the specified account from the database.
        /// Deletes all transactions and removes the FIUser if there are no other accounts attached.
        /// </summary>
        /// <param name="account">Account to delete</param>
        public static void DeleteAccount(Account account)
        {
            using (var db = new SoCashDbContext())
            {
                // Retrieve matching account from DB - we need to get an entity in the current db session
                var deleteAccount = db.Accounts.First(dbAccount => dbAccount.AccountId == account.AccountId);

                // Delete fiUser if this is the only account referencing it
                if (deleteAccount.FinancialInstitutionUser != null &&
                    deleteAccount.FinancialInstitutionUser.Accounts.Count == 1)
                    db.FinancialInstitutionUsers.Remove(deleteAccount.FinancialInstitutionUser);

                // Remove the account
                db.Accounts.Remove(deleteAccount);

                // Commit to db
                db.SaveChanges();
            }
        }

        /// <summary>
        /// Update an account in the database with the provided data
        /// </summary>
        /// <param name="account">Account to update</param>
        public static void UpdateAccount(Account account)
        {
            using (var db = new SoCashDbContext())
            {
                // Attach to context and mark as modified
                db.Entry(account).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        /// <summary>
        /// Unlink an account from its associated financial institution and user
        /// </summary>
        /// <param name="account">Account to unlink</param>
        public static void UnlinkAccount(Account account)
        {
            using (var db = new SoCashDbContext())
            {
                // Attach to context and mark as modified
                db.Entry(account).State = EntityState.Modified;

                // Hold reference to associated FiUser
                var fiUser = account.FinancialInstitutionUser;

                // Remove account
                fiUser.Accounts.Remove(account);

                // If the fiUser is no longer attached to any accounts, remove fiUser
                if (!fiUser.Accounts.Any())
                    db.FinancialInstitutionUsers.Remove(fiUser);

                // Save changes to db
                db.SaveChanges();
            }
        }

        /// <summary>
        /// Update a FI user in the database with the provided data
        /// </summary>
        /// <param name="user">FI User data to update</param>
        public static void UpdateFiUser(FinancialInstitutionUser user)
        {
            using (var db = new SoCashDbContext())
            {
                // Attach to context and mark as modified
                db.Entry(user).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

    }
}
