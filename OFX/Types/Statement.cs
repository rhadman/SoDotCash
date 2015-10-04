using System;
using System.Collections.Generic;
using System.Linq;
using OFX.Internal;
using OFX.Protocol;
using OFX.Types.Exceptions;

namespace OFX.Types
{
    /// <summary>
    /// Container class for statement data retrieved from a financial institution for a single account
    /// </summary>
    public class Statement
    {
        /// <summary>
        /// Construct a Statement from source OFX data - StatementResponse object (bank account)
        /// </summary>
        /// <param name="sourceOFX">OFX StatementResponse object retrieved from FI</param>
        public Statement(StatementResponse statementResponse)
        {
            // Parse account information
            OwningAccount = Account.Create(statementResponse.BANKACCTFROM);

            // Parse currency into a string
            Currency = statementResponse.CURDEF.ToString();

            // Parse statement date range
            StartDate = OFXUtils.DateFromOFX(statementResponse.BANKTRANLIST.DTSTART);
            EndDate = OFXUtils.DateFromOFX(statementResponse.BANKTRANLIST.DTEND);

            // Parse account balance
            AccountBalance = OFXUtils.DecimalStringToFixedInt(statementResponse.LEDGERBAL.BALAMT);

            // Convert OFX transactions into our normalized Transaction objects
            if (statementResponse.BANKTRANLIST.STMTTRN != null)
            {
                // Convert OFX transactions into our normalized Transaction objects
                var unorderedTransactions = from ofxTransaction in statementResponse.BANKTRANLIST.STMTTRN
                                        select new Transaction(ofxTransaction);

                Transactions = new List<Transaction>(unorderedTransactions.OrderByDescending(trans => trans.PostDate));
            }
            else
                Transactions = new List<Transaction>();
        }

        /// <summary>
        /// Construct a Statement from source OFX data - StatementResponse object (credit card account)
        /// </summary>
        /// <param name="sourceOFX">OFX CreditCardStatementResponse object retrieved from FI</param>
        public Statement(CreditCardStatementResponse statementResponse)
        {
            // Parse account information
            OwningAccount = Account.Create(statementResponse.CCACCTFROM);

            // Parse currency into a string
            Currency = statementResponse.CURDEF.ToString();

            // Parse statement date range
            StartDate = OFXUtils.DateFromOFX(statementResponse.BANKTRANLIST.DTSTART);
            EndDate = OFXUtils.DateFromOFX(statementResponse.BANKTRANLIST.DTEND);

            // Parse account balance
            AccountBalance = OFXUtils.DecimalStringToFixedInt(statementResponse.LEDGERBAL.BALAMT);

            // Convert OFX transactions into our normalized Transaction objects
            if (statementResponse.BANKTRANLIST.STMTTRN != null)
            {
                var unorderedTransactions = from ofxTransaction in statementResponse.BANKTRANLIST.STMTTRN
                    select new Transaction(ofxTransaction);

                Transactions = new List<Transaction>(unorderedTransactions.OrderByDescending(trans => trans.PostDate));
            }
            else
                Transactions = new List<Transaction>();
        }

        /// <summary>
        /// Construct Statement objects for each statement responses included in the passed OFX response
        /// </summary>
        /// <param name="ofxResponse">OFX object populated with one or more statement responses</param>
        /// <returns></returns>
        public static IEnumerable<Statement> CreateFromOFXResponse(Protocol.OFX ofxResponse)
        {
            List<Statement> statementList = new List<Statement>();

            // Handle Credit Card responses
            foreach (
                var responseMessageSet in
                    ofxResponse.Items.Where(item => item.GetType() == typeof (CreditcardResponseMessageSetV1))
                        .Select(item => (CreditcardResponseMessageSetV1) item))
            {
                foreach (
                    var transactionResponse in
                        responseMessageSet.Items.Where(
                            item => item.GetType() == typeof (CreditCardStatementTransactionResponse))
                            .Select(item => (CreditCardStatementTransactionResponse) item))
                {
                    statementList.Add(new Statement(transactionResponse.CCSTMTRS));
                }
            }

            // Handle Bank responses
            foreach (
                var responseMessageSet in
                    ofxResponse.Items.Where(item => item.GetType() == typeof(BankResponseMessageSetV1))
                        .Select(item => (BankResponseMessageSetV1)item))
            {
                foreach (
                    var transactionResponse in
                        responseMessageSet.Items.Where(
                            item => item.GetType() == typeof(StatementTransactionResponse))
                            .Select(item => (StatementTransactionResponse)item))
                {
                    if(transactionResponse.STMTRS != null)
                        statementList.Add(new Statement(transactionResponse.STMTRS));
                    else
                    {
                        throw new OfxException(transactionResponse.STATUS.MESSAGE);
                    }
                }
            }

            // Return populated list
            return statementList;
        }

        /// <summary>
        /// The account associated with the transactions in this statement
        /// </summary>
        public
        Account OwningAccount { get; }

        /// <summary>
        /// Currency for transactions and balances in this statement
        /// </summary>
        public string Currency { get; }

        /// <summary>
        /// Transactions included in this statement
        /// </summary>
        public List<Transaction> Transactions { get; }

        /// <summary>
        /// Start of the date range of transactions included in this statement
        /// </summary>
        public DateTimeOffset StartDate { get; }

        /// <summary>
        /// End of the date range of transactions included in this statement
        /// </summary>
        public DateTimeOffset EndDate { get; }

        /// <summary>
        /// The account balance reported in this statement request. In the currency units of the account.
        /// </summary>
        public int AccountBalance { get; }

        public decimal LocalizedAccountBalance => AccountBalance/100m;
    }
}
