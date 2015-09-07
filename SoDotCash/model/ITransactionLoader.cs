using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoDotCash.model
{
    /// <summary>
    /// Interface for objects that can load and present financial transaction data to the application for consumption
    /// </summary>
    interface ITransactionLoader
    {
        /// <summary>
        /// Consume the transactions parsed by this loader
        /// </summary>
        IEnumerable<Transaction> transactions
        {
            get;
        }
    }
}
