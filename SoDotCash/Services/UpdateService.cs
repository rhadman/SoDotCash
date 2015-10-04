using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using OFX;
using OFX.Types.Exceptions;
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
                using (var dataService = new DataService())
                {
                    // Retrieve matching account from DB - we need to get an entity in the current db session
                    var updateAccount = dataService.GetAccountById(account.AccountId);

                    // If the account has no account ID set, set it from the imported statement
                    if (updateAccount.FiAccountId == null)
                        updateAccount.FiAccountId = statement.OwningAccount.AccountId;
                    else if (updateAccount.FiAccountId != statement.OwningAccount.AccountId)
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
                                updateAccount.Transactions.First(t => t.FiTransactionId == transaction.TransactionId);

                            // Ensure amount and date of transaction match
                            existingTransaction.Amount = transaction.Amount;
                            existingTransaction.Date = transaction.PostDate.Date;
                        }
                        catch (InvalidOperationException)
                        {
                            // No such transaction, add entity

                            // Create model transaction
                            var dbTransaction = new Transaction
                            {
                                Amount = transaction.Amount,
                                CategoryName = "",
                                Date = transaction.PostDate.Date,
                                Description = transaction.Name,
                                FiTransactionId = transaction.TransactionId,

                            };
                            updateAccount.Transactions.Add(dbTransaction);

                        }
                    }

                    // Sum all transactions in the data set and ensure the balance on the date of the end of the statement matches the reported balance
                    var dbBalance = updateAccount.Transactions.Where(t => t.Date <= latestTransaction)
                        .Sum(t => t.Amount);
                    if (dbBalance != statement.AccountBalance)
                    {
                        // Need to add or modify a filler transaction
                        try
                        {
                            // Look for a pre-existing filler transaction as the transaction prior to the start of this statement
                            var fillerTransaction =
                                updateAccount.Transactions.Where(t => t.Date < earliestTransaction)
                                    .OrderByDescending(t => t.Date)
                                    .First();
                            // If this is not a balance adjustment transaction, move to creating a new transaction to adjust
                            if (fillerTransaction.Description != "Balance Adjustment")
                                throw new InvalidOperationException();

                            // An existing balance adjustment is in place. Modify;
                            fillerTransaction.Amount += (statement.AccountBalance - dbBalance);
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
                                Amount = (statement.AccountBalance - dbBalance),
                                CategoryName = "BALADJUST",
                                Description = "Balance Adjustment",
                                FiTransactionId = Guid.NewGuid().ToString(),
                                Date = fillerDate
                            };
                            updateAccount.Transactions.Add(fillerTransaction);
                        }
                    }
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
            using (BackgroundTaskTracker.BeginTask("Importing Transactions"))
            {

                // Deserialize the OFX file data to an object form
                var converter = new OFX1ToOFX2Converter(ofxFileStream);

                // Convert file into statements
                try
                {
                    var statements = OFX.Types.Statement.CreateFromOFXResponse(converter.ConvertToOFX());

                    // Merge statements
                    foreach (var statement in statements)
                        MergeStatementTransactionsIntoAccount(account, statement);

                }
                catch (OfxException ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
                catch (InvalidOperationException ex)
                {
                    MessageBox.Show("The provided OFX file could not be parsed.", "Error");
                }

            }

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

                using (var dataService = new DataService())
                {
                    // Retrieve matching account from DB - we need to get an entity in the current db session
                    var updateAccount = dataService.GetAccountById(account.AccountId);

                    // Form FI connection properties for transaction retrieval
                    var fi = new OFX.Types.FinancialInstitution(
                        updateAccount.FinancialInstitutionUser.FinancialInstitution.Name,
                        new Uri(updateAccount.FinancialInstitutionUser.FinancialInstitution.OfxUpdateUrl),
                        updateAccount.FinancialInstitutionUser.FinancialInstitution.OfxOrganizationId,
                        updateAccount.FinancialInstitutionUser.FinancialInstitution.OfxFinancialUnitId
                        );

                    // Form credentials for login
                    var credentials = new OFX.Types.Credentials(
                        updateAccount.FinancialInstitutionUser.UserId,
                        updateAccount.FinancialInstitutionUser.Password
                        );

                    // Create service
                    ofxService = new OFX2Service(fi, credentials);

                    // Create proper account type for this account
                    var accountType = (AccountType) account.AccountType;
                    if (accountType == AccountType.Checking)
                    {
                        // Split routing and account id from combined string
                        var accountIdComponents = account.FiAccountId.Split(':');
                        ofxAccount = new OFX.Types.CheckingAccount(accountIdComponents[0], accountIdComponents[1],
                            "",
                            true);
                    }
                    else if (accountType == AccountType.Savings)
                    {
                        // Split routing and account id from combined string
                        var accountIdComponents = account.FiAccountId.Split(':');
                        ofxAccount = new OFX.Types.SavingsAccount(accountIdComponents[0], accountIdComponents[1], "",
                            true);
                    }
                    else //if (accountType == AccountType.CREDITCARD)
                    {
                        ofxAccount = new OFX.Types.CreditCardAccount(account.FiAccountId, "", true);
                    }

                    // Use the start time of the latest transaction if we have any
                    try
                    {
                        var lastTransaction =
                            (from transaction in updateAccount.Transactions
                                orderby transaction.Date descending
                                select transaction).First();
                        startTime = new DateTimeOffset(lastTransaction.Date);

                    }
                    catch (InvalidOperationException)
                    {
                        // No transactions - ignore and use default start date.
                    }

                }

                // Retrieve statement(s) (should only be one per protocol, but we can handle any number)
                try
                {
                    var ofxStatments =
                        await ofxService.GetStatement(ofxAccount, startTime, endTime).ConfigureAwait(false);
                    foreach (var ofxStatement in ofxStatments)
                        MergeStatementTransactionsIntoAccount(account, ofxStatement);
                }
                catch (OfxException ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
                catch (InvalidOperationException ex)
                {
                    MessageBox.Show("The data provided by the financial institution could not be parsed.", "Error");
                }

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

                // TODO: If ofxAccountList is null, raise a more detailed exception

                using (var dataService = new DataService())
                {
                    foreach (var ofxAccount in ofxAccountList)
                    {
                        // Convert from OFX account type to db account type and encode account id 
                        AccountType accountType = AccountType.Checking;
                        string accountId = "";
                        if (ofxAccount.GetType() == typeof (OFX.Types.CheckingAccount))
                        {
                            accountType = AccountType.Checking;
                            accountId = ((OFX.Types.CheckingAccount) ofxAccount).RoutingId + ":" + ofxAccount.AccountId;
                        }
                        else if (ofxAccount.GetType() == typeof (OFX.Types.SavingsAccount))
                        {
                            accountType = AccountType.Savings;
                            accountId = ((OFX.Types.SavingsAccount) ofxAccount).RoutingId + ":" + ofxAccount.AccountId;
                        }
                        else if (ofxAccount.GetType() == typeof (OFX.Types.CreditCardAccount))
                        {
                            accountType = AccountType.Creditcard;
                            accountId = ofxAccount.AccountId;
                        }

                        // Look for a matching account in the database
                        if (!dataService.GetAccountByFinancialId(accountId).Any())
                        {
                            // This account is not already in the DB, add to new account list
                            accountList.Add(new Account
                            {
                                AccountName =
                                    accountType + ":" +
                                    ofxAccount.AccountId.Substring(ofxAccount.AccountId.Length - 4),
                                AccountType = accountType.ToString(),
                                Currency = "USD",
                                FiAccountId = accountId
                            });
                        }
                    }
                }

                // Return the finalized list of new accounts
                return accountList;
            }
        }

        /// <summary>
        /// Verify the provided account credentials. Raises an exception if validation fails
        /// </summary>
        /// <param name="financialInstitution">Financial institution to query</param>
        /// <param name="fiCredentials">Credentials for financial institution account</param>
        /// <returns>List of accounts</returns>
        public static async Task VerifyAccountCredentials(FinancialInstitution financialInstitution,
            OFX.Types.Credentials fiCredentials)
        {
            using (BackgroundTaskTracker.BeginTask("Verifying Credentials"))
            {

                // Convert from data model FI into OFX FI
                var ofxFinancialInstitition = new OFX.Types.FinancialInstitution(financialInstitution.Name,
                    new Uri(financialInstitution.OfxUpdateUrl), financialInstitution.OfxOrganizationId,
                    financialInstitution.OfxFinancialUnitId);

                var ofxService = new OFX2Service(ofxFinancialInstitition, fiCredentials);

                // Call list accounts to validate credentials
                await ofxService.ListAccounts().ConfigureAwait(false);
            }
        }
    } // class

} // namespace
