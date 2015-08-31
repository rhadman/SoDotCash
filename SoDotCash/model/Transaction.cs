using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NodaTime;

namespace SoDotCash.model
{
    /// <summary>
    /// Data container for a single financial transaction
    /// </summary>
    class Transaction
    {
        // TODO: Unique ID of transaction

        /// <summary>
        /// Date the transaction was executed
        /// </summary>
        protected NodaTime.LocalDate m_date;

        /// <summary>
        /// A human-readable description of the transaction
        /// </summary>
        protected string m_description;

        /// <summary>
        /// The value of the transaction in the single currency unit of the containing ledger
        /// </summary>
        protected Int64 m_value; 

    }
}
