using System.Data.Entity;

namespace SoDotCash.Models
{
    class SoCashDbContext : DbContext
    {
        public SoCashDbContext() :
            base("name=SoCash")
        {
        }

        /// <summary>
        /// Accessor for FinancialInstitution entities in the database
        /// </summary>
        public DbSet<FinancialInstitution> FinancialInstitutions { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }
    }

}
