using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;

namespace SoDotCash.Models
{

    [Table("Account")]
    public class Account
    {
        public Account()
        {
        }

        public Account(Account other)
        {
            fiUserID = other.fiUserID;
            accountName = other.accountName;
            accountType = other.accountType;
            currency = other.currency;
            fiAccountID = other.fiAccountID;
        }

        [Key]
        public int accountID { get; set; }

        public int? fiUserID { get; set; }

        [StringLength(50)]
        public string accountName { get; set; }

        [StringLength(15)]
        public string accountType { get; set; }

        [StringLength(3)]
        public string currency { get; set; }

        [StringLength(50)]
        public string fiAccountID { get; set; }
        
        [InverseProperty("accounts")]
        [ForeignKey("fiUserID")]
        public virtual FinancialInstitutionUser financialInstitutionUser { get; set; }

        private ICollection<Transaction> _transactions;
        public virtual ICollection<Transaction> transactions
        {
            get { return _transactions ?? (_transactions = new Collection<Transaction>()); }
            set { _transactions = value; }
        }
    }
}