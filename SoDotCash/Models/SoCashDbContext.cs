using System.Data.Entity;

namespace SoDotCash.Models
{
    /// <summary>
    /// The DbContest provides transparent transaction wrappers around access to the database
    ///  using EntityFramework bound classes representing tables in the database.
    /// </summary>
    public class SoCashDbContext : DbContext
    {
        public SoCashDbContext() :
            base("name=SoCash")
        {
        }

        /// <summary>
        /// Accessor for FinancialInstitution entities in the database
        /// These represent the financial institutions we know about, including access information for OFX-based
        ///  data retrieval
        /// </summary>
        public DbSet<FinancialInstitution> FinancialInstitutions { get; set; }

        /// <summary>
        /// Accessor for FinancialInstitutionUser entities in the database.
        /// These store the user access credentials for the financial institutions.
        /// </summary>
        public DbSet<FinancialInstitutionUser> FinancialInstitutionUsers { get; set; }


        /// <summary>
        /// Accessor for Account entities in the database.
        /// These store individual accounts which record transactions
        /// </summary>
        public DbSet<Account> Accounts { get; set; }


    }

}
