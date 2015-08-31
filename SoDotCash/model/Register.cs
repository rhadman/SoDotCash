using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoDotCash.model
{
    /// <summary>
    /// A Register contains a list of all transactions associated with an account
    ///   and provides related functionality (such as retrieving balances)
    /// </summary>
    class Register
    {
        /// <summary>
        /// The 3-letter ISO currency identifier of the currency of the values in this register.
        /// </summary>
        protected string m_currency;

        /// <summary>
        /// The ordered set of transactions that make up the register
        /// </summary>
        protected List<Transaction> m_transactions = new List<Transaction>();
    }
}
