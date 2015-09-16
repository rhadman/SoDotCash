using System.Collections.Generic;
using System.Net;

namespace OFX.Types
{
    /// <summary>
    /// User account use to abstract away the multiple layers required for an account
    /// </summary>
    public class UserAccount
    {
        public OFXCredentials Credentials { get; private set; }
        public OFXFinancialInstitution FinancialInstitution { get; private set; }

        public List<Account> Accounts = new List<Account>();
    }

}
