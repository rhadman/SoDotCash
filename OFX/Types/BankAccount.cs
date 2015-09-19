using OFX.Protocol;

namespace OFX.Types
{
    /// <summary>
    /// Information for a bank account
    /// </summary>
    public class BankAccount : Account
    {
        public BankAccount(string routingId, string accountId, string description, bool active)
            : base(description, active, accountId)
        {
            RoutingId = routingId;
            //AccountId = accountId;
        }

        /// <summary>
        /// Create proper typed Account from OFX object
        /// </summary>
        /// <param name="ofxAccount">OFX BankAccount object</param>
        /// <returns></returns>
        public new static Account Create(Protocol.BankAccount ofxAccount)
        {
            // Route to proper constructor
            if (ofxAccount.ACCTTYPE == AccountEnum.SAVINGS)
                return new SavingsAccount(ofxAccount);
            return new CheckingAccount(ofxAccount);
        }

        /// <summary>
        /// Internal constructor so derived classes can have alternate constructors
        /// </summary>
        protected BankAccount(Protocol.BankAccount ofxAccount) :
            base("", true, ofxAccount.ACCTID)
        {
            RoutingId = ofxAccount.BANKID;
            //AccountId = ofxAccount.ACCTID;
        }

        /// <summary>
        /// Routing ID associated with bank account
        /// </summary>
        public string RoutingId { get; }
    }

}
