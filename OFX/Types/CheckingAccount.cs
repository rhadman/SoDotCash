namespace OFX.Types
{

    /// <summary>
    /// Derived-type for checking account
    /// </summary>
    public class CheckingAccount : BankAccount
    {
        public CheckingAccount(string routingId, string accountId, string description, bool active) 
            : base(routingId, accountId, description, active)
        {
            // Stub - ensures the type is correct even though no extra content from parent
        }

        public CheckingAccount(Protocol.BankAccount ofxAccount) :
            base(ofxAccount)
        {
            // Stub - ensures the type is correct even though no extra content from parent
        }

        public override string ToString()
        {
            return "Checking (" + RoutingId + ":"+ AccountId+ ")";
        }
    }
}
