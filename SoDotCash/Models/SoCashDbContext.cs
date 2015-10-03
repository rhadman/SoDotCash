using System.Data.Entity;
using System.Data.Entity.Infrastructure;

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
        public virtual DbSet<FinancialInstitution> FinancialInstitutions { get; set; }

        /// <summary>
        /// Accessor for FinancialInstitutionUser entities in the database.
        /// These store the user access credentials for the financial institutions.
        /// </summary>
        public virtual DbSet<FinancialInstitutionUser> FinancialInstitutionUsers { get; set; }


        /// <summary>
        /// Accessor for Account entities in the database.
        /// These store individual accounts which record transactions
        /// </summary>
        public virtual DbSet<Account> Accounts { get; set; }

        /// <summary>
        /// Mockable wrapper for attaching an entity to the context and setting state to modified
        /// </summary>
        /// <param name="entity">Entity to attach and set to modified</param>
        public virtual void SetModified(object entity)
        {
            Entry(entity).State = EntityState.Modified;
        }

        /// <summary>
        /// Mockable wrapper for attaching an entity to the context and setting state to unchanged
        /// </summary>
        /// <param name="entity">Entity to attach and set to unchanged</param>
        public virtual void SetUnchanged(object entity)
        {
            Entry(entity).State = EntityState.Unchanged;
        }

        /// <summary>
        /// Mockable wrapper for attaching an entity to the context and setting state to added
        /// </summary>
        /// <param name="entity">Entity to attach and set to added</param>
        public virtual void SetAdded(object entity)
        {
            Entry(entity).State = EntityState.Added;
        }
    }

}
