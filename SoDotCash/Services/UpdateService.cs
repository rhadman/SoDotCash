using System;
using System.IO;
using System.Linq;

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
        public static void MergeStatementTransactionsIntoAccount(Models.Account account, OFX.Types.Statement statement)
        {
            using (var db = new Models.SoCashDbContext())
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


                foreach (var transaction in statement.Transactions)
                {
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
                        var dbTransaction = new Models.Transaction
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

                db.SaveChanges();
            }
        }

        /// <summary>
        /// Merge transactions read from an OFX file into the specified account. 
        /// This form takes an already open and positioned stream ready for OFX read operations.
        /// </summary>
        /// <param name="account">The account to merge transactions into</param>
        /// <param name="ofxFileStream">Open and positioned readable stream containing an OFX statement</param>
        public static void MergeOfxFileIntoAccount(Models.Account account, Stream ofxFileStream)
        {
            // Deserialize the OFX file data to an object form
            var converter = new OFX.OFX1ToOFX2Converter(ofxFileStream);
            foreach (var statement in OFX.Types.Statement.CreateFromOFXResponse(converter.ConvertToOFX()))
                MergeStatementTransactionsIntoAccount(account, statement);
        }

        /// <summary>
        /// Merge transactions read from an OFX file into the specified account. 
        /// This form takes a string containing the path and filename of the OFX file to open
        /// </summary>
        /// <param name="account">The account to merge transactions into</param>
        /// <param name="ofxFileName">Path and filename of a readable file containing an OFX statement</param>
        public static void MergeOfxFileIntoAccount(Models.Account account, string ofxFileName)
        {
            // Open the file for reading
            using (var ofxFileStream = File.OpenRead(ofxFileName))
            {
                // Pass to stream handler
                MergeOfxFileIntoAccount(account, ofxFileStream);
            }
        }

    }


}
