using System.Collections.Generic;

namespace OFX.Types
{
    /// <summary>
    /// User account use to abstract away the multiple layers required for an account
    /// </summary>
    public class UserAccount
    {
        public Credentials Credentials { get; private set; }
        public FinancialInstitution FinancialInstitution { get; private set; }

        public List<Account> Accounts = new List<Account>();
    }

}
