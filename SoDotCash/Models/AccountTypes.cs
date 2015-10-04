using System;
using System.Collections.Generic;

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
        private readonly string _name;

        /// <summary>
        /// Unique integer value of enum
        /// </summary>
        public int Value { get; }

        /// <summary>
        /// Mapping from string to enum entry. Also used for enumeration of all values
        /// </summary>
        private static readonly Dictionary<string, AccountType> Instance = new Dictionary<string, AccountType>();

        public static readonly AccountType Checking = new AccountType(1, "Checking");
        public static readonly AccountType Savings = new AccountType(2, "Savings");
        public static readonly AccountType Creditcard = new AccountType(3, "Credit Card");
        public static readonly AccountType Cash = new AccountType(4, "Cash");

        private AccountType(int value, string name)
        {
            Value = value;
            _name = name;
            // Add to mapping
            Instance[name] = this;
        }

        public override string ToString()
        {
            return _name;
        }

        /// <summary>
        /// Type conversion from string to enum object
        /// </summary>
        /// <param name="str">String form of a member of the enum</param>
        public static explicit operator AccountType(string str)
        {
            AccountType result;
            if (Instance.TryGetValue(str, out result))
                return result;
            throw new InvalidCastException();
        }

        /// <summary>
        /// Enumerator over all values
        /// </summary>
        /// <returns>Enumerable over the </returns>
        public static IEnumerable<AccountType> All()
        {
            return Instance.Values;
        }

    }
}
