using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace SoDotCash
{
    class DatabaseClasses
    { }

        public class User
        {
            public int UserId { get; set; }
            public string firstName { get; set; }
            public string middleName { get; set; }
            public string lastName { get; set; }
            public string password { get; set; }


            public virtual List<Account> Account { get; set; }
        }

        public class Account
        {
            // Enum that sets the different types of allowed accounts
            public enum enumAccountType
            {
                Checking,
                Savings,
                Investment
            };

            public int AccountId { get; set; }
            public int UserId { get; set; }
            public enumAccountType AccountType { get; set; }
            public string AccountName { get; set; }
            public decimal Balance { get; set; }

            public virtual List<Transaction> Transaction { get; set; }
        }

        public class Transaction
        {
            // Enum that sets the different types of allowed transactions
            public enum enumTransactionType
            {
                Debit,
                Credit,
                Withdrawal,
                Interest
            };

            public int TransactionId { get; set; }
            public int AccountId { get; set; }
            public enumTransactionType typeOfTransaction { get; set; }
            public string Description { get; set; }
            public string Category { get; set; }
            // DateTimeOffset so all dates stored as UTC
            public DateTimeOffset dateOfTransaction { get; set; }
            public decimal amountOfTransaction { get; set; }


            public virtual Account Account { get; set; }
        }



        public class UsageContext : DbContext
        {
            // name=Usage is so DbContext knows where to connect to
            public UsageContext() : base("name=Usage")
            {

            }

            public DbSet<User> Users { get; set; }
            public DbSet<Account> Accounts { get; set; }
            public DbSet<Transaction> Transactions { get; set; }
        }
}
