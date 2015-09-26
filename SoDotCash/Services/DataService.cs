using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoDotCash.Models;

namespace SoDotCash.Services
{
    /// <summary>
    /// Provides functionality for accessing and manipulating application data.
    /// Reusable application logic should be placed here
    /// </summary>
    public class DataService
    {
        /// <summary>
        /// Determine if there are any existing accounts in the database
        /// </summary>
        /// <returns>
        /// True - There are existing accounts
        /// False - There are no accounts
        /// </returns>
        public static bool AnyExistAccounts()
        {
            using (var db = new SoCashDbContext())
            {
                return db.Accounts.Any();
            }
        }
    }
}
