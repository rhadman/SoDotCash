using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoDotCash.Models
{

    public class Account
    {
        /// <summary>
        /// User-defined name of this account
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The type of this account - affects how transaction data is interpretted
        /// </summary>
        public EAccountType AccountType { get; set;  }
    }


    public class AccountList
    {
        public string Name { get; set; }
        public ObservableCollection<Account> Accounts { get; set; }
    }


}
