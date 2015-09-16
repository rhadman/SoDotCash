using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;

namespace SoDotCash.Models
{

    [Table("Account")]
    public class Account
    {

        [Key]
        public int accountID { get; set; }

        public int fiUserId { get; set; }

        [StringLength(50)]
        public string accountName { get; set; }

        [StringLength(15)]
        public string accountType { get; set; }

        [StringLength(3)]
        public string currency { get; set; }

        [InverseProperty("accounts")]
        [ForeignKey("fiUserId")]
        public virtual FinancialInstitutionUser financialInstitutionUser { get; set; }

        public virtual ICollection<Transaction> transactions { get; set; }
    }
}