using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace SoDotCash.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    [Table("FIUser")]
    public class FinancialInstitutionUser
    {
        [Key]
        public int fiUserId { get; set; }

        public int fiId { get; set; }

        [StringLength(50)]
        public string userId { get; set; }

        [StringLength(50)]
        public string password { get; set; }

        [InverseProperty("users")]
        [ForeignKey("fiId")]
        public virtual FinancialInstitution financialInstitution { get; set; }

        private ICollection<Account> _accounts;
        public virtual ICollection<Account> accounts
        {
            get { return _accounts ?? (_accounts = new Collection<Account>()); }
            set { _accounts = value; }
        }
    }

}