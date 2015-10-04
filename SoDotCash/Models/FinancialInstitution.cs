using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SoDotCash.Models
{

    /// <summary>
    /// Entities in the FI table describe known financial institutions and the associated OFX update properties
    /// </summary>
    [Table("FI")]
    public class FinancialInstitution
    {
        /// <summary>
        /// So.Cash unique database PK for this FI. Not exposed to user.
        /// </summary>
        [Key]
        public int FiId { get; set; }

        /// <summary>
        /// Name of the Financial Institution for display purposes.
        /// </summary>
        [StringLength(50)]
        [Index(IsUnique = true)]
        public string Name { get; set;  }

        /// <summary>
        /// URL of OFX online update service endpoint
        /// </summary>
        [StringLength(200)]
        public string OfxUpdateUrl { get; set; }

        /// <summary>
        /// FI assigned Organization ID. Must be provided in requests to the FI.
        /// </summary>
        [StringLength(20)]
        public string OfxOrganizationId { get; set; }

        /// <summary>
        /// FI assigned Financial Unit ID. Must be provided in requests to the FI.
        /// </summary>
        [StringLength(20)]
        public string OfxFinancialUnitId { get; set; }

        /// <summary>
        /// Relationship link to credentials associated with this FI
        /// </summary>
        private ICollection<FinancialInstitutionUser> _users;
        public virtual ICollection<FinancialInstitutionUser> Users
        {
            get { return _users ?? (_users = new Collection<FinancialInstitutionUser>()); }
            set { _users = value; }
        }
    }

}