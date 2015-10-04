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
        /// <summary>
        /// So.Cash unique id for this FI User
        /// </summary>
        [Key]
        public int FiUserId { get; set; }

        /// <summary>
        /// Identifier of the related financial institution.
        /// Do not use this field directly. Use FinancialInstitution relationship link.
        /// </summary>
        public int FiId { get; set; }

        /// <summary>
        /// User provided login for the OFX online update service
        /// </summary>
        [StringLength(50)]
        public string UserId { get; set; }

        /// <summary>
        /// User provided password for the OFX online update service
        /// </summary>
        [StringLength(50)]
        public string Password { get; set; }


        /// <summary>
        /// Relationship link to the FI this user and credentials apply
        /// </summary>
        [InverseProperty("Users")]
        [ForeignKey("FiId")]
        public virtual FinancialInstitution FinancialInstitution { get; set; }

        /// <summary>
        /// Relationship link to So.Cash accounts that are linked to this FI with these credentials
        /// </summary>
        private ICollection<Account> _accounts;
        public virtual ICollection<Account> Accounts
        {
            get { return _accounts ?? (_accounts = new Collection<Account>()); }
            set { _accounts = value; }
        }
    }

}