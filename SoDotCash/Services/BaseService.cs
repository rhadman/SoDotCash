using System;
using System.Data.Entity.Infrastructure;
using SoDotCash.Models;

namespace SoDotCash.Services
{
    /// <summary>
    /// Base class for services. Provides common functionality for manipulating and retrieving the Database Context
    /// Moq-friendly design. Use:
    /// var mockContext = Mock<SomeContext>()
    /// mockContext.
    /// </summary>
    public class BaseService : IDisposable
    {
        /// <summary>
        /// No-argument constructor uses a real database context
        /// </summary>
        internal BaseService()
        {
            DbContext = new SoCashDbContext();
        }

        /// <summary>
        /// Allows mock framework to pass in a mock db context for testing
        /// </summary>
        /// <param name="dbContext">Alternate DB Context to use for service opperations</param>
        internal BaseService(SoCashDbContext dbContext)
        {
            DbContext = dbContext;
        }

        /// <summary>
        /// The datbase context use for service operations
        /// </summary>
        public SoCashDbContext DbContext { get; set; }

        /// <summary>
        /// Called when a using() clause referencing this object exits.
        /// Commits outstanding database changes
        /// </summary>
        public void Dispose()
        {
            DbContext.SaveChanges();
            DbContext.Dispose();
        }

    }
}
