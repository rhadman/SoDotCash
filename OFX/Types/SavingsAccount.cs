namespace OFX.Types
{
    /// <summary>
    /// Derived-type for savings account
    /// </summary>
    public class SavingsAccount : BankAccount
    {
        public SavingsAccount(string routingId, string accountId, string description, bool active) 
            : base(routingId, accountId, description, active)
        {
            // Stub - ensures the type is correct even though no extra content from parent
        }

        public SavingsAccount(Protocol.BankAccount ofxAccount) :
            base(ofxAccount)
        {
            // Stub - ensures the type is correct even though no extra content from parent
        }

        public override string ToString()
        {
            return "Savings (" + RoutingId + ":" + AccountId + ")";
        }

    }
}
