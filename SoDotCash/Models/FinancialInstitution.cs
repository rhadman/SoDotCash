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
        [Key]
        public int FiId { get; set; }

        [StringLength(50)]
        [Index(IsUnique = true)]
        public string Name { get; set;  }

        [StringLength(200)]
        public string OfxUpdateUrl { get; set; }

        [StringLength(20)]
        public string OfxOrganizationId { get; set; }

        [StringLength(20)]
        public string OfxFinancialUnitId { get; set; }

        private ICollection<FinancialInstitutionUser> _users;
        public virtual ICollection<FinancialInstitutionUser> Users
        {
            get { return _users ?? (_users = new Collection<FinancialInstitutionUser>()); }
            set { _users = value; }
        }
    }

}