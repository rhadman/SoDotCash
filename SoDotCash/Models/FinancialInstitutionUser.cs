using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace SoDotCash.Models
{
    /// <summary>
    /// Describes an account at a financual institution, including authentication credentials
    /// </summary>
    [Table("FIUser")]
    public class FinancialInstitutionUser
    {
        [Key]
        public int FiUserId { get; set; }

        public int FiId { get; set; }

        [StringLength(50)]
        public string UserId { get; set; }

        [StringLength(50)]
        public string Password { get; set; }

        [InverseProperty("Users")]
        [ForeignKey("FiId")]
        public virtual FinancialInstitution FinancialInstitution { get; set; }

        private ICollection<Account> _accounts;
        public virtual ICollection<Account> Accounts
        {
            get { return _accounts ?? (_accounts = new Collection<Account>()); }
            set { _accounts = value; }
        }
    }

}