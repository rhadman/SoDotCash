using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoDotCash.Models
{
    /// <summary>
    /// Type-safe enum pattern for account types
    /// </summary>
    public sealed class AccountType
    {
        /// <summary>
        /// String name of enum value
        /// </summary>
        private readonly String name;

        /// <summary>
        /// Unique integer value of enum
        /// </summary>
        private readonly int value;

        /// <summary>
        /// Mapping from string to enum entry. Also used for enumeration of all values
        /// </summary>
        private static readonly Dictionary<string, AccountType> instance = new Dictionary<string, AccountType>();

        public static readonly AccountType CHECKING = new AccountType(1, "Checking");
        public static readonly AccountType SAVINGS = new AccountType(2, "Savings");
        public static readonly AccountType CREDITCARD = new AccountType(3, "Credit Card");


        private AccountType(int value, String name)
        {
            this.value = value;
            this.name = name;
            // Add to mapping
            instance[name] = this;
        }

        public override String ToString()
        {
            return name;
        }

        /// <summary>
        /// Type conversion from string to enum object
        /// </summary>
        /// <param name="str">String form of a member of the enum</param>
        public static explicit operator AccountType(string str)
        {
            AccountType result;
            if (instance.TryGetValue(str, out result))
                return result;
            throw new InvalidCastException();
        }

        /// <summary>
        /// Enumerator over all values
        /// </summary>
        /// <returns>Enumerable over the </returns>
        public static IEnumerable<AccountType> All()
        {
            return instance.Values;
        }

    }
}
