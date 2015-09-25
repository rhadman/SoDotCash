using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using OFX;
using SoDotCash.Models;

namespace SoDotCash.Services
{
    /// <summary>
    /// Provides functionality for updating accounts and transactions from external sources such as files or online connectivity
    /// </summary>
    public class UpdateService
    {

        /// <summary>
        /// Merge transactions from the provided statement into the specified account
        /// </summary>
        /// <param name="account">The account into which transactions will be merged</param>
        /// <param name="statement">The statement containing the transactions to merge. The statement owning account ID must match the ID of the passed account.</param>
        public static void MergeStatementTransactionsIntoAccount(Account account, OFX.Types.Statement statement)
        {
            using (BackgroundTaskTracker.BeginTask("Processing Transactions"))
            {
                using (var db = new SoCashDbContext())
                {
                    // Retrieve matching account from DB - we need to get an entity in the current db session
                    var updateAccount = db.Accounts.First(dbAccount => dbAccount.accountID == account.accountID);

                    // If the account has no account ID set, set it from the imported statement
                    if (updateAccount.fiAccountID == null)
                        updateAccount.fiAccountID = statement.OwningAccount.AccountId;
                    else if (updateAccount.fiAccountID != statement.OwningAccount.AccountId)
                    {
                        // TODO: Raise an error - this statement does not match the specified account.
                    }

                    // Add each transaction, and keep track of the earliest and latest dates
                    DateTimeOffset earliestTransaction = DateTimeOffset.MaxValue;
                    DateTimeOffset latestTransaction = DateTimeOffset.MinValue;
                    foreach (var transaction in statement.Transactions)
                    {
                        // Update date of earliest and latest transaction
                        if (earliestTransaction > transaction.PostDate)
                            earliestTransaction = transaction.PostDate;
                        if (latestTransaction < transaction.PostDate)
                            latestTransaction = transaction.PostDate;

                        // See if transaction is already in db
                        try
                        {
                            var existingTransaction =
                                updateAccount.transactions.First(t => t.fiTransactionId == transaction.TransactionId);

                            // Ensure amount and date of transaction match
                            existingTransaction.amount = transaction.Amount;
                            existingTransaction.date = transaction.PostDate.Date;
                        }
                        catch (InvalidOperationException)
                        {
                            // No such transaction, add entity

                            // Create model transaction
                            var dbTransaction = new Transaction
                            {
                                amount = transaction.Amount,
                                category = "",
                                currency = statement.Currency,
                                date = transaction.PostDate.Date,
                                description = transaction.Name,
                                fiTransactionId = transaction.TransactionId,

                            };
                            updateAccount.transactions.Add(dbTransaction);

                        }
                    }

                    // Sum all transactions in the data set and ensure the balance on the date of the end of the statement matches the reported balance
                    var dbBalance = updateAccount.transactions.Where(t => t.date <= latestTransaction)
                        .Sum(t => t.amount);
                    if (dbBalance != statement.AccountBalance)
                    {
                        // Need to add or modify a filler transaction
                        try
                        {
                            // Look for a pre-existing filler transaction as the transaction prior to the start of this statement
                            var fillerTransaction =
                                updateAccount.transactions.Where(t => t.date < earliestTransaction)
                                    .OrderByDescending(t => t.date)
                                    .First();
                            // If this is not a balance adjustment transaction, move to creating a new transaction to adjust
                            if (fillerTransaction.description != "Balance Adjustment")
                                throw new InvalidOperationException();

                            // An existing balance adjustment is in place. Modify;
                            fillerTransaction.amount += (statement.AccountBalance - dbBalance);
                        }
                        catch (InvalidOperationException)
                        {
                            // Determine date of filler - don't use a date in the future
                            var fillerDate = (earliestTransaction - new TimeSpan(1, 0, 0, 0)).DateTime;
                            if (fillerDate > DateTime.Now)
                                fillerDate = DateTime.Now;

                            // No existing balance adjustment transaction exists. Add one.
                            var fillerTransaction = new Transaction
                            {
                                amount = (statement.AccountBalance - dbBalance),
                                category = "BALADJUST",
                                description = "Balance Adjustment",
                                currency = statement.Currency,
                                fiTransactionId = System.Guid.NewGuid().ToString(),
                                date = fillerDate
                            };
                            updateAccount.transactions.Add(fillerTransaction);
                        }
                    }


                    db.SaveChanges();
                }
            }
        }

        /// <summary>
        /// Merge transactions read from an OFX file into the specified account. 
        /// This form takes an already open and positioned stream ready for OFX read operations.
        /// </summary>
        /// <param name="account">The account to merge transactions into</param>
        /// <param name="ofxFileStream">Open and positioned readable stream containing an OFX statement</param>
        public static void MergeOfxFileIntoAccount(Account account, Stream ofxFileStream)
        {
            // Deserialize the OFX file data to an object form
            var converter = new OFX1ToOFX2Converter(ofxFileStream);
            foreach (var statement in OFX.Types.Statement.CreateFromOFXResponse(converter.ConvertToOFX()))
                MergeStatementTransactionsIntoAccount(account, statement);
        }

        /// <summary>
        /// Merge transactions read from an OFX file into the specified account. 
        /// This form takes a string containing the path and filename of the OFX file to open
        /// </summary>
        /// <param name="account">The account to merge transactions into</param>
        /// <param name="ofxFileName">Path and filename of a readable file containing an OFX statement</param>
        public static void MergeOfxFileIntoAccount(Account account, string ofxFileName)
        {
            // Open the file for reading
            using (var ofxFileStream = File.OpenRead(ofxFileName))
            {
                // Pass to stream handler
                MergeOfxFileIntoAccount(account, ofxFileStream);
            }
        }

        /// <summary>
        /// Download OFX transactions for an account and merge them into the account transaction list
        /// </summary>
        /// <param name="account">Account configured with financial institution login information</param>
        public static async Task DownloadOfxTransactionsForAccount(Account account)
        {
            using (BackgroundTaskTracker.BeginTask("Downloading statements"))
            {
                // Default retrieval parameters
                OFX2Service ofxService;
                OFX.Types.Account ofxAccount;
                var endTime = DateTimeOffset.Now;
                var startTime = new DateTimeOffset(new DateTime(1997, 1, 1));

                using (var db = new SoCashDbContext())
                {
                    // Retrieve matching account from DB - we need to get an entity in the current db session
                    var updateAccount = db.Accounts.First(dbAccount => dbAccount.accountID == account.accountID);

                    // Form FI connection properties for transaction retrieval
                    var fi = new OFX.Types.FinancialInstitution(
                        updateAccount.financialInstitutionUser.financialInstitution.name,
                        new Uri(updateAccount.financialInstitutionUser.financialInstitution.ofxUpdateUrl),
                        updateAccount.financialInstitutionUser.financialInstitution.ofxOrganizationId,
                        updateAccount.financialInstitutionUser.financialInstitution.ofxFinancialUnitId
                        );

                    // Form credentials for login
                    var credentials = new OFX.Types.Credentials(
                        updateAccount.financialInstitutionUser.userId,
                        updateAccount.financialInstitutionUser.password
                        );

                    // Create service
                    ofxService = new OFX2Service(fi, credentials);

                    // Create proper account type for this account
                    var accountType = (AccountType) account.accountType;
                    if (accountType == AccountType.CHECKING)
                    {
                        // Split routing and account id from combined string
                        var accountIdComponents = account.fiAccountID.Split(':');
                        ofxAccount = new OFX.Types.CheckingAccount(accountIdComponents[0], accountIdComponents[1],
                            "",
                            true);
                    }
                    else if (accountType == AccountType.SAVINGS)
                    {
                        // Split routing and account id from combined string
                        var accountIdComponents = account.fiAccountID.Split(':');
                        ofxAccount = new OFX.Types.SavingsAccount(accountIdComponents[0], accountIdComponents[1], "",
                            true);
                    }
                    else //if (accountType == AccountType.CREDITCARD)
                    {
                        ofxAccount = new OFX.Types.CreditCardAccount(account.fiAccountID, "", true);
                    }

                    // Use the start time of the latest transaction if we have any
                    try
                    {
                        var lastTransaction =
                            (from transaction in updateAccount.transactions
                                orderby transaction.date descending
                                select transaction).First();
                        startTime = new DateTimeOffset(lastTransaction.date);

                    }
                    catch (InvalidOperationException)
                    {
                        // No transactions - ignore and use default start date.
                    }

                }

                // Retrieve statement(s) (should only be one per protocol, but we can handle any number)
                var ofxStatments = await ofxService.GetStatement(ofxAccount, startTime, endTime).ConfigureAwait(false);
                foreach (var ofxStatement in ofxStatments)
                    MergeStatementTransactionsIntoAccount(account, ofxStatement);
            }

        }

        /// <summary>
        /// Retrieve the list of accounts from a financial institution using OFX and return all accounts that are not already present in the database
        /// </summary>
        /// <param name="financialInstitution">Financial institution to query</param>
        /// <param name="fiCredentials">Credentials for financial institution account</param>
        /// <returns>List of accounts</returns>
        public static async Task<IEnumerable<Account>> EnumerateNewAccounts(
            OFX.Types.FinancialInstitution financialInstitution, OFX.Types.Credentials fiCredentials)
        {

            using (BackgroundTaskTracker.BeginTask("Retrieving Account Information"))
            {

                var ofxService = new OFX2Service(financialInstitution, fiCredentials);
                var accountList = new List<Account>();
                var ofxAccountList = await ofxService.ListAccounts().ConfigureAwait(false);

                // TODO: If ofxAccountList is null, raise an exception

                using (var db = new SoCashDbContext())
                {


                    foreach (var ofxAccount in ofxAccountList)
                    {
                        // Convert from OFX account type to db account type and encode account id 
                        AccountType accountType = AccountType.CHECKING;
                        string accountId = "";
                        if (ofxAccount.GetType() == typeof (OFX.Types.CheckingAccount))
                        {
                            accountType = AccountType.CHECKING;
                            accountId = ((OFX.Types.CheckingAccount) ofxAccount).RoutingId + ":" + ofxAccount.AccountId;
                        }
                        else if (ofxAccount.GetType() == typeof (OFX.Types.SavingsAccount))
                        {
                            accountType = AccountType.SAVINGS;
                            accountId = ((OFX.Types.CheckingAccount) ofxAccount).RoutingId + ":" + ofxAccount.AccountId;
                        }
                        else if (ofxAccount.GetType() == typeof (OFX.Types.CreditCardAccount))
                        {
                            accountType = AccountType.CREDITCARD;
                            accountId = ofxAccount.AccountId;
                        }

                        // Look for a matching account in the database
                        if (!db.Accounts.Any(a => a.fiAccountID == accountId))
                        {
                            // This account is not already in the DB, add to new account list
                            accountList.Add(new Account
                            {
                                accountName =
                                    accountType + ":" +
                                    ofxAccount.AccountId.Substring(ofxAccount.AccountId.Length - 4),
                                accountType = accountType.ToString(),
                                currency = "USD",
                                fiAccountID = accountId
                            });
                        }
                    }
                }

                // Return the finalized list of new accounts
                return accountList;
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
                var deleteAccount = db.Accounts.First(dbAccount => dbAccount.accountID == account.accountID);

                // Delete fiUser if this is the only account referencing it
                if (deleteAccount.financialInstitutionUser != null &&
                    deleteAccount.financialInstitutionUser.accounts.Count == 1)
                    db.FinancialInstitutionUsers.Remove(deleteAccount.financialInstitutionUser);

                // Remove the account
                db.Accounts.Remove(deleteAccount);

                // Commit to db
                db.SaveChanges();
            }
        }



    } // class

} // namespace
