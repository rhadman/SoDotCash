using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoDotCash.Models
{
    /// <summary>
    /// Possible account types. These were derived from the OFX specification.
    /// </summary>
    public enum EAccountType { Checking, Savings, MoneyMarket, LineOfCredit, CreditCard, Cash }

    /// <summary>
    /// List of all known account types
    /// </summary>
    public class AccountTypes : Dictionary<EAccountType, AccountList>
    {
        public AccountTypes()
        {
            foreach (EAccountType accountType in Enum.GetValues(typeof (EAccountType)))
                Add(accountType, new AccountList() {Name = accountType.ToString(), Accounts = new ObservableCollection<Account>()});
        }

    }
}
