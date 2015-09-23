using OFX.Protocol;

namespace OFX.Types
{

    /// <summary>
    /// Base account type from which other account types derive.
    /// Container for account data.
    /// </summary>
    public class Account
    {
        public Account(string description, bool active, string actId)
        {
            Description = description;
            Active = active;
            AccountId = actId;
        }

        /// <summary>
        /// Create proper typed Account from OFX object
        /// </summary>
        /// <param name="ofxAccount">OFX BankAccount object</param>
        /// <returns></returns>
        public static Account Create(Protocol.BankAccount ofxAccount)
        {
            return BankAccount.Create(ofxAccount);
        }

        /// <summary>
        /// Create proper typed Account from OFX object
        /// </summary>
        /// <param name="ofxAccount">OFX CreditCardAccount object</param>
        /// <returns></returns>
        public static Account Create(Protocol.CreditCardAccount ofxAccount)
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
        /// The type-specific account ID string for this account.
        /// May be interpretted differently for different account types.
        /// </summary>
        public string AccountId { get; private set; }
    }
}
