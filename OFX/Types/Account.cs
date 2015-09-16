using System.Collections.Generic;
using System.Net;

namespace OFX.Types
{

    /// <summary>
    /// Base account type from which other account types derive.
    /// Container for account data.
    /// </summary>
    public class Account
    {
        public Account(string description, bool active)
        {
            Description = description;
            Active = active;
        }

        /// <summary>
        /// Create proper typed Account from OFX object
        /// </summary>
        /// <param name="ofxAccount">OFX BankAccount object</param>
        /// <returns></returns>
        public static Account Create(global::OFX.BankAccount ofxAccount)
        {
            return BankAccount.Create(ofxAccount);
        }

        /// <summary>
        /// Create proper typed Account from OFX object
        /// </summary>
        /// <param name="ofxAccount">OFX CreditCardAccount object</param>
        /// <returns></returns>
        public static Account Create(global::OFX.CreditCardAccount ofxAccount)
        {
            return new CreditCardAccount(ofxAccount);
        }

        /// <summary>
        /// Description of the account
        /// </summary>
        public string Description { get; }

        /// <summary>
        /// Status of the account - whether it's active or not
        /// </summary>
        public bool Active { get; }

        /// <summary>
        /// The type of account - Checking, Savings, Money Market etc
        /// </summary>
        public AccountEnum AccountType { get; private set; }
    }
}
