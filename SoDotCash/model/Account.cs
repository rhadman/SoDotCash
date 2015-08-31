using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoDotCash.model
{
    /// <summary>
    /// Encapsulates a single account - usually at a financial institution.
    /// Examples of accounts are Checking, Savings, Loans, Credit Cards or even a manually tracked Petty Cash account.
    /// </summary>
    class Account
    {
        /// <summary>
        /// Possible account types. These were derived from the OFX specification.
        /// </summary>
        public enum AccountType { Checking, Savings, MoneyMarket, LineOfCredit, CreditCard, Cash }

        /// <summary>
        /// User-defined name of this account
        /// </summary>
        protected string m_name;

        /// <summary>
        /// The type of this account - affects how transaction data is interpretted
        /// </summary>
        protected AccountType m_accountType;

        /// <summary>
        /// Relate this account to a financial instution with login credentials.
        /// Note that a single login at a financial institution may contain multiple FinancialAccounts
        /// </summary>
        protected InstitutionConnection m_connection;

        /// <summary>
        /// The transaction register. This is an integral part of the account, but may be best represented by its own class
        /// </summary>
        protected Register m_register = new Register();

        // TODO: Information about the last time this account was updated. This should allow us to understand how to request only new transactions.


    }
}
