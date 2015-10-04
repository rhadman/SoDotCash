using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SoDotCash.Models
{
    /// <summary>
    /// Encapsulation of Financial Institution account-related information
    /// </summary>
    [Table("Account")]
    public class Account
    {
        public Account()
        {
        }

        /// <summary>
        /// Copy constructor
        /// </summary>
        /// <param name="other"></param>
        public Account(Account other)
        {
            FiUserId = other.FiUserId;
            AccountName = other.AccountName;
            AccountType = other.AccountType;
            Currency = other.Currency;
            FiAccountId = other.FiAccountId;
        }

        /// <summary>
        /// So.Cash Unique ID of this account. Internal use. Not displayed to end-user.
        /// </summary>
        [Key]
        public int AccountId { get; set; }

        /// <summary>
        /// Optional identifier linking to a FinancialInstitutionUser. Don't use this directly,
        ///   instead use FinancialInstitutionUser member.
        /// </summary>
        public int? FiUserId { get; set; }

        /// <summary>
        /// Name of this account as assigned by user
        /// </summary>
        [StringLength(50)]
        public string AccountName { get; set; }

        /// <summary>
        /// Account type. String representation of AccountType enum value
        /// </summary>
        [StringLength(15)]
        public string AccountType { get; set; }

        /// <summary>
        /// Currency of values in this account.
        /// </summary>
        [StringLength(3)]
        public string Currency { get; set; }

        /// <summary>
        /// Account Id for this account assigned by financial institution. This is only
        ///   valid if the account is attached to a FI online, or has loaded transactions
        ///   from an OFX file.
        /// </summary>
        [StringLength(50)]
        public string FiAccountId { get; set; }

        /// <summary>
        /// Shortcut accessor for determining if an account is associated with a FI
        /// </summary>
        public bool IsAssociatedWithFinancialInstitution => FiUserId != null;
        
        /// <summary>
        /// Relationship link to credentials and financial institution used for automatic updates.
        /// This is null for manual update accounts
        /// </summary>
        [InverseProperty("Accounts")]
        [ForeignKey("FiUserId")]
        public virtual FinancialInstitutionUser FinancialInstitutionUser { get; set; }

        /// <summary>
        /// Relationship link to transactions in this account
        /// </summary>
        private ICollection<Transaction> _transactions;
        public virtual ICollection<Transaction> Transactions
        {
            get { return _transactions ?? (_transactions = new Collection<Transaction>()); }
            set { _transactions = value; }
        }
    }
}