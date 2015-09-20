using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SoDotCash.Models
{

    [Table("Transaction")]
    public class Transaction
    {

        [Key]
        public int transactionId { get; set; }

        public int accountId { get; set; }

        [StringLength(50)]
        public string fiTransactionId { get; set; }

        [StringLength(100)]
        public string description { get; set; }

        [StringLength(25)]
        public string category { get; set; }

        [StringLength(3)]
        public string currency { get; set; }

        [Column(TypeName="Date")]
        public DateTime date { get; set; }

        public int amount { get; set; }

        [InverseProperty("transactions")]
        [ForeignKey("accountId")]
        public virtual Account account { get; set; }



        /// <summary>
        /// Proxy property which converts the amount in dollars into cents
        /// TODO: Handle different currency types
        /// </summary>
        public decimal localizedAmount => amount / 100m;
    }

}