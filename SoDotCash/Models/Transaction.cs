using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SoDotCash.Models
{

    /// <summary>
    /// A transaction represents a single atomic adjustment to the balance of an account - such as a withdrawal, deposit,
    ///   credit or debit.
    /// </summary>
    [Table("Transaction")]
    public class Transaction : EditableEntity
    {
        public Transaction()
        {
            // Default date to today
            Date = DateTime.Now;
            FiTransactionId = "";
            CategoryName = "";
        }

        /// <summary>
        /// So.Cash unique database identifier (PK) for transaction. Internal use only.  Not displayed to end-user.
        /// </summary>
        [Key]
        public int TransactionId { get; set; }

        /// <summary>
        /// Identifier of the account this transaction is associated with.
        /// Do not use this field. Instead use the Account relationship link.
        /// </summary>
        public int AccountId { get; set; }

        /// <summary>
        /// Transaction ID provided by financial institution (or entered by user if this is a manual entry account)
        /// </summary>
        [StringLength(50)]
        public string FiTransactionId { get; set; }

        /// <summary>
        /// Description of this transaction.  User-entered for manual entry accounts. Downloaded from FI for auto-update accounts.
        /// </summary>
        [StringLength(100)]
        public string Description { get; set; }

        /// <summary>
        /// Optional category associated with this transaction. 
        /// Can be used for sorting, statistics and higher level management operations in the future.
        /// </summary>
        [StringLength(25)]
        public string CategoryName { get; set; }

        /// <summary>
        /// The date of the transaction. 
        /// Time component is currently not provided by any known FIs and will be set to midnight.
        /// </summary>
        [Column(TypeName="datetime")]
        public DateTime Date { get; set; }

        /// <summary>
        /// Amount of the transaction in integral units.
        /// Use the currency to convert to localized units, or used LocalizedAmount accessor
        /// </summary>
        public int Amount { get; set; }

        /// <summary>
        /// Relationship link to account holding this transaction
        /// </summary>
        [InverseProperty("Transactions")]
        [ForeignKey("AccountId")]
        [Required]
        public virtual Account Account { get; set; }

        /// <summary>
        /// Unmapped balance data. Must be filled in on load.
        /// </summary>
        [NotMapped]
        public int Balance { get; set; }

        /// <summary>
        /// Proxy property which converts the balance in cents into dollars
        /// TODO: Handle different currency types
        /// </summary>
        public decimal LocalizedBalance => Balance/100m;

        /// <summary>
        /// Proxy property which converts the amount in cents into dollars
        /// TODO: Handle different currency types
        /// </summary>
        public decimal LocalizedAmount
        {
            get { return Amount/100m; }
            set { Amount = (int) (value*100m); }
        }

        /// <summary>
        /// Property used in style templete to determine if the ammount is positive or negitive
        /// </summary>
        public bool IsAmountPositive => LocalizedAmount >= 0;
    }

}