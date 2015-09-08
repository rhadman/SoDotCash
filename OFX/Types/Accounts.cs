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
        /// Description of the account
        /// </summary>
        public string Description { get; }

        /// <summary>
        /// Status of the account - whether it's active or not
        /// </summary>
        public bool Active { get; }
    }


    /// <summary>
    /// Information for a credit card account
    /// </summary>
    public class CreditCardAccount : Account
    {
        public CreditCardAccount(string accountId, string description, bool active) : base(description, active)
        {
            AccountId = accountId;
        }

        /// <summary>
        /// Account number of this credit card account
        /// </summary>
        public string AccountId { get; }
    }

    /// <summary>
    /// Information for a bank account
    /// </summary>
    public class BankAccount : Account
    {
        public BankAccount(string routingId, string accountId, string description, bool active)
            : base(description, active)
        {
            RoutingId = routingId;
            AccountId = accountId;
        }

        /// <summary>
        /// Routing ID associated with bank account
        /// </summary>
        public string RoutingId { get; }

        /// <summary>
        /// Account ID associated with bank account
        /// </summary>
        public string AccountId { get; }
    }

    /// <summary>
    /// Derived-type for checking account
    /// </summary>
    public class CheckingAccount : BankAccount
    {
        public CheckingAccount(string routingId, string accountId, string description, bool active) 
            : base(routingId, accountId, description, active)
        {
        }
    }

    /// <summary>
    /// Derived-type for savings account
    /// </summary>
    public class SavingsAccount : BankAccount
    {
        public SavingsAccount(string routingId, string accountId, string description, bool active) 
            : base(routingId, accountId, description, active)
        {
        }
    }
}
