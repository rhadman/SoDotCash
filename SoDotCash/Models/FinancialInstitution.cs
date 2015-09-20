using System.Collections.Generic;
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
        public int fiID { get; set; }

        [StringLength(50)]
        [Index(IsUnique = true)]
        public string name { get; set;  }

        [StringLength(200)]
        public string ofxUpdateUrl { get; set; }

        [StringLength(20)]
        public string ofxOrganizationId { get; set; }

        [StringLength(20)]
        public string ofxFinancialUnitId { get; set; }

        public virtual ICollection<FinancialInstitutionUser> users { get; set; }
    }

}