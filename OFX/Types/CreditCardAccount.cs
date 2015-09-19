namespace OFX.Types
{

    /// <summary>
    /// Information for a credit card account
    /// </summary>
    public class CreditCardAccount : Account
    {
        public CreditCardAccount(string accountId, string description, bool active)
            : base(description, active, accountId)
        {
            //AccountId = accountId;
        }

        public CreditCardAccount(Protocol.CreditCardAccount ofxAccount) :
            base("", true, ofxAccount.ACCTID)
        {
            //AccountId = ofxAccount.ACCTID;
        }

        public override string ToString()
        {
            return "Credit Card (" + AccountId + ")";
        }
    }
}
