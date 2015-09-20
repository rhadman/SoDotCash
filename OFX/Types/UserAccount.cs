using System.Collections.Generic;
using System.Collections.ObjectModel;
using OFX.Protocol;

namespace OFX.Types
{
    /// <summary>
    /// User account use to abstract away the multiple layers required for an account
    /// </summary>
    public class UserAccount
    {
        public Credentials Credentials { get; set; }
        public FinancialInstitution FinancialInstitution { get; set; }
        
        public List<Account> Accounts { get; set; } = new List<Account>();
    }

}
