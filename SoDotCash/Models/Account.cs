using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
            FiUserId = other.FiUserId;
            AccountName = other.AccountName;
            AccountType = other.AccountType;
            Currency = other.Currency;
            FiAccountId = other.FiAccountId;
        }

        [Key]
        public int AccountId { get; set; }

        public int? FiUserId { get; set; }

        [StringLength(50)]
        public string AccountName { get; set; }

        [StringLength(15)]
        public string AccountType { get; set; }

        [StringLength(3)]
        public string Currency { get; set; }

        [StringLength(50)]
        public string FiAccountId { get; set; }

        /// <summary>
        /// Shortcut accessor for determining if an account is associated with a FI
        /// </summary>
        public bool IsAssociatedWithFinancialInstitution => FiUserId != null;
        
        [InverseProperty("Accounts")]
        [ForeignKey("FiUserId")]
        public virtual FinancialInstitutionUser FinancialInstitutionUser { get; set; }

        private ICollection<Transaction> _transactions;
        public virtual ICollection<Transaction> Transactions
        {
            get { return _transactions ?? (_transactions = new Collection<Transaction>()); }
            set { _transactions = value; }
        }
    }
}