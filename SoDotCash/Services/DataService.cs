using System;
using System.Collections.Generic;
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
    public class DataService : BaseService
    {
        /// <summary>
        /// No-argument constructor uses a real database context
        /// </summary>
        public DataService()
        {
        }

        /// <summary>
        /// Allows mock framework to pass in a mock db context for testing
        /// </summary>
        /// <param name="dbContext">Alternate DB Context to use for service opperations</param>
        public DataService(SoCashDbContext dbContext) : base(dbContext)
        {
        }

        /// <summary>
        /// Initialize data storage for the application
        /// This is a static method since the basic storage location for the application must be configured before
        ///   a database context can be created.
        /// </summary>
        public static void Initialize()
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


            // TODO: FIXME: For now we drop and recreate the database if the model changes. 
            //   This is fine for development and demonstration purposes, but should be changed
            //   for long-term maintained production.
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<SoCashDbContext>());

            // Open the database and perform necessary schema adjustments
            using (var dataService = new DataService())
            {
                dataService.InitializeDatabase();
            }
        }

        /// <summary>
        /// Called internally to complete the database initialization after storage location is configured
        /// </summary>
        private void InitializeDatabase()
        {
            DbContext.Database.Initialize(false);
        }


        /// <summary>
        /// Determine if there are any existing accounts in the database
        /// </summary>
        /// <returns>
        /// True - There are existing accounts
        /// False - There are no accounts
        /// </returns>
        public bool AnyExistingAccounts()
        {
            return DbContext.Accounts.Any();
        }

        /// <summary>
        /// Add a new transaction to an account.
        /// Called from the UI for manual entry
        /// </summary>
        /// <param name="account">Account to add transactions to</param>
        /// <param name="transaction">Transaction to add</param>
        public void AddTransaction(Account account, Transaction transaction)
        {
            // Retrieve matching account from DB - we need to get an entity in the current db session
            var updateAccount = DbContext.Accounts.First(dbAccount => dbAccount.AccountId == account.AccountId);
            updateAccount.Transactions.Add(transaction);
        }

        /// <summary>
        /// Delete a transaction from the database
        /// Called from the UI for manual entry
        /// </summary>
        /// <param name="transaction">Transaction to delete</param>
        public void DeleteTransaction(Transaction transaction)
        {
            // Add the transaction to the context in unchanged state creating a current reference
            DbContext.SetUnchanged(transaction);
            // Delete from database
            DbContext.Set<Transaction>().Remove(transaction);
        }

        /// <summary>
        /// Update values of an existing transaction
        /// Called from the UI for edits
        /// </summary>
        /// <param name="transaction">Modified transaction</param>
        public void UpdateTransaction(Transaction transaction)
        {
            // Attach to context and mark as modified
            DbContext.SetModified(transaction);
        }

        /// <summary>
        /// Add an account to the database
        /// </summary>
        /// <param name="account">Populated account entity to add to database</param>
        /// <returns>Created account</returns>
        public Account AddAccount(Account account)
        {
            // Add to database
            DbContext.Accounts.Add(account);

            return account;
        }

        /// <summary>
        /// Add an account to the database - Using OFX data specification
        /// </summary>
        /// <param name="account">Populated account object to add to database</param>
        /// <param name="financialInstitution">OFX financial institution to link in database. Will be created if necessary.</param>
        /// <param name="fiUser">User credentials for the financial institution</param>
        /// <returns>Created account</returns>
        public Account AddAccount(Account account, OFX.Types.FinancialInstitution financialInstitution, FinancialInstitutionUser fiUser)
        {
            // TODO: See if there's an existing FI or user with this info already
            // Look for existing FI entry with the same name
            FinancialInstitution fi;
            try
            {
                fi = DbContext.FinancialInstitutions.First(i => i.Name == financialInstitution.Name);
            }
            catch (Exception ex)
            {
                // Can result in InvalidOperationException or NullReferenceException depending on provider
                if (ex is InvalidOperationException || ex is NullReferenceException)
                {
                    // FI Doesn't exist, add a new one
                    fi = new FinancialInstitution
                    {
                        Name = financialInstitution.Name,
                        OfxFinancialUnitId = financialInstitution.FinancialId,
                        OfxOrganizationId = financialInstitution.OrganizationId,
                        OfxUpdateUrl = financialInstitution.ServiceEndpoint.ToString()
                    };
                    DbContext.FinancialInstitutions.Add(fi);
                }
                else
                    throw; // Unhandled
            }

            // Look for existing user under this FI with same userId
            try
            {
                fiUser = fi.Users.First(u => u.UserId == fiUser.UserId);
            }
            catch (Exception ex)
            {
                // Can result in InvalidOperationException or NullReferenceException depending on provider
                if (ex is InvalidOperationException || ex is NullReferenceException)
                {
                    // User doesn't exist, add as new
                    fi.Users.Add(fiUser);
                    DbContext.FinancialInstitutionUsers.Add(fiUser);
                }
                else
                    throw; // Unhandled
            }

            fiUser.Accounts.Add(account);
            DbContext.Accounts.Add(account);

            return account;
        }


        /// <summary>
        /// Delete the specified account from the database.
        /// Deletes all transactions and removes the FIUser if there are no other accounts attached.
        /// </summary>
        /// <param name="account">Account to delete</param>
        public void DeleteAccount(Account account)
        {
            // Add the account to the context in unchanged state creating a current reference
            DbContext.SetUnchanged(account);

            // Delete fiUser if this is the only account referencing it
            if (account.FinancialInstitutionUser != null &&
                account.FinancialInstitutionUser.Accounts.Count == 1)
                DbContext.FinancialInstitutionUsers.Remove(account.FinancialInstitutionUser);

            // Remove the account
            DbContext.Set<Account>().Remove(account);
        }

        /// <summary>
        /// Update an account in the database with the provided data
        /// </summary>
        /// <param name="account">Account to update</param>
        public void UpdateAccount(Account account)
        {
            // Attach to context and mark as modified
            DbContext.SetModified(account);
        }

        /// <summary>
        /// Unlink an account from its associated financial institution and user
        /// </summary>
        /// <param name="account">Account to unlink</param>
        public void UnlinkAccount(Account account)
        {
            // Attach to context and mark as modified
            DbContext.SetModified(account);

            // Hold reference to associated FiUser
            var fiUser = account.FinancialInstitutionUser;

            // Remove account
            fiUser.Accounts.Remove(account);

            // If the fiUser is no longer attached to any accounts, remove fiUser
            if (!fiUser.Accounts.Any())
                DbContext.FinancialInstitutionUsers.Remove(fiUser);
        }

        /// <summary>
        /// Update a FI user in the database with the provided data
        /// </summary>
        /// <param name="user">FI User data to update</param>
        public void UpdateFiUser(FinancialInstitutionUser user)
        {
            // Attach to context and mark as modified
            DbContext.SetModified(user);
        }

        /// <summary>
        /// Retrieve all accounts from the database along with any associated Financial Institution records
        /// </summary>
        /// <returns>Collection of all accounts in database</returns>
        public IEnumerable<Account> GetAccountsWithFi()
        {
            return
                new List<Account>(
                    DbContext.Accounts.Include("FinancialInstitutionUser")
                        .Include("FinancialInstitutionUser.FinancialInstitution"));
        }

        /// <summary>
        /// Retrieve all transactions for an account from the database ordered by date
        /// </summary>
        /// <param name="account">The account to retrieve transactions for</param>
        /// <returns>Collection of all transactions associated with the provided account</returns>
        public IEnumerable<Transaction> GetTransactionsByDate(Account account)
        {
            // Retrieve the current account record in this session - to ensure the transaction list is not stale
            var dbAccount = DbContext.Accounts.First(a => a.AccountId == account.AccountId);

            // Retrieve transactions ordered by date
            return from t in dbAccount.Transactions orderby t.Date select t;
        }


        /// <summary>
        /// Retrieve an account from the database by account id
        /// </summary>
        /// <param name="accountId">Numeric Id of the account to retrieve</param>
        /// <returns>Account matching the Id, or null if there are no matching accounts</returns>
        public Account GetAccountById(int accountId)
        {
            return DbContext.Accounts.First(dbAccount => dbAccount.AccountId == accountId);
        }

        /// <summary>
        /// Retrieve accounts from the database by the FI-assigned account Id
        /// </summary>
        /// <param name="fiAccountId">Account id to retrieve</param>
        /// <returns>Collection of account matching the Id</returns>
        public IEnumerable<Account> GetAccountByFinancialId(string fiAccountId)
        {
            return DbContext.Accounts.Where(a => a.FiAccountId == fiAccountId);
        }
    }
}
