using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SoDotCash.Models
{

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

        [Key]
        public int TransactionId { get; set; }

        public int AccountId { get; set; }

        [StringLength(50)]
        public string FiTransactionId { get; set; }

        [StringLength(100)]
        public string Description { get; set; }

        [StringLength(25)]
        public string CategoryName { get; set; }

        [Column(TypeName="datetime")]
        public DateTime Date { get; set; }

        public int Amount { get; set; }

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


    }

}