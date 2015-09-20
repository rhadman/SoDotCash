using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OFX.Internal;
using OFX.Protocol;

namespace OFX.Types
{
    /// <summary>
    /// Container class for transaction data retrieved from an OFX provider
    /// </summary>
    public class Transaction
    {
        public Transaction(DateTimeOffset postDate, string transactionId, int amount, string name)
        {
            PostDate = postDate;
            TransactionId = transactionId;
            Amount = amount;
            Name = name;
        }

        /// <summary>
        /// Construct a statement transaction by parsing an OFX transaction entity
        /// </summary>
        /// <param name="ofxTransaction"></param>
        public Transaction(StatementTransaction ofxTransaction)
        {
            // Assign to internal state
            PostDate = OFXUtils.DateFromOFX(ofxTransaction.DTPOSTED);
            TransactionId = ofxTransaction.FITID;
            Amount = OFXUtils.DecimalStringToFixedInt(ofxTransaction.TRNAMT);
            Name = (string) ofxTransaction.Item;
        }

        public override string ToString()
        {
            return "TRANS " + TransactionId + " on " + PostDate + " for " + Amount + " Desc: " + Name;
        }

        /// <summary>
        /// Date transaction has posted
        /// </summary>
        public DateTimeOffset PostDate { get; }

        /// <summary>
        /// Unique ID for this transaction assigned by the Financial Institution
        /// </summary>
        public string TransactionId { get; }

        /// <summary>
        /// Amount of the transaction in integral units of the currency (cents for USD)
        /// </summary>
        public int Amount { get; }

        /// <summary>
        /// Name associated with this transaction
        /// </summary>
        public string Name { get; }

    }

}
