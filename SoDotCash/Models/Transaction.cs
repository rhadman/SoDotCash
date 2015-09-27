using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;

namespace SoDotCash.Models
{

    [Table("Transaction")]
    public class Transaction : EditableEntity
    {
        public Transaction()
        {
            // Default date to today
            date = DateTime.Now;
            fiTransactionId = "";
            category = "";
        }

        [Key]
        public int transactionId { get; set; }

        public int accountId { get; set; }

        [StringLength(50)]
        public string fiTransactionId { get; set; }

        [StringLength(100)]
        public string description { get; set; }

        [StringLength(25)]
        public string category { get; set; }

        [Column(TypeName="datetime")]
        public DateTime date { get; set; }

        public int amount { get; set; }

        [InverseProperty("transactions")]
        [ForeignKey("accountId")]
        [Required]
        public virtual Account account { get; set; }

        /// <summary>
        /// Unmapped balance data. Must be filled in on load.
        /// </summary>
        [NotMapped]
        public int balance { get; set; }

        /// <summary>
        /// Proxy property which converts the balance in cents into dollars
        /// </summary>
        public decimal localizedBalance => balance/100m;

        /// <summary>
        /// Proxy property which converts the amount in cents into dollars
        /// TODO: Handle different currency types
        /// </summary>
        public decimal localizedAmount
        {
            get { return amount/100m; }
            set { amount = (int) (value*100m); }
        }


    }

}