using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using SoDotCash.Models;
using SoDotCash.Services;

namespace SoDotCashTest
{
    /// <summary>
    /// Summary description for DataServiceTest
    /// </summary>
    [TestClass]
    public class DataServiceTest
    {
        /// <summary>
        /// Test adding a manual update account
        /// </summary>
        [TestMethod]
        public void TestAddManualUpdateAccount()
        {
            // Mock setup for DataService
            var mockSet = new Mock<DbSet<Account>>();
            var mockContext = new Mock<SoCashDbContext>();
            mockContext.Setup(m => m.Accounts).Returns(mockSet.Object);


            // Account to add
            var newAccount = new Account
            {
                AccountName = "Test Account",
                AccountType = AccountType.Checking.ToString(),
                Currency = "USD"
            };

            // Add the account in a transaction
            using (var service = new DataService(mockContext.Object))
            {

                service.AddAccount(newAccount);
            }

            // Verify that the service added the account on the mock db exactly once
            mockSet.Verify(m => m.Add(It.IsAny<Account>()), Times.Once());

            // Verify that the transaction ended properly
            mockContext.Verify(m => m.SaveChanges(), Times.Once());
        }

        /// <summary>
        /// Test adding an account with financial institution information
        /// </summary>
        [TestMethod]
        public void TestAddAccountFromFi()
        {
            // Mock setup for DataService
            var mockAccountSet = new Mock<DbSet<Account>>();
            var mockFiSet = new Mock<DbSet<FinancialInstitution>>();
            var mockFiUserSet = new Mock<DbSet<FinancialInstitutionUser>>();
            var mockContext = new Mock<SoCashDbContext>();
            mockContext.Setup(m => m.Accounts).Returns(mockAccountSet.Object);
            mockContext.Setup(m => m.FinancialInstitutions).Returns(mockFiSet.Object);
            mockContext.Setup(m => m.FinancialInstitutionUsers).Returns(mockFiUserSet.Object);


            // Account to add
            var newAccount = new Account
            {
                AccountName = "Test Account",
                AccountType = AccountType.Checking.ToString(),
                Currency = "USD"
            };

            // Dummy FI
            var financialInstitution = new OFX.Types.FinancialInstitution("Test FI", new Uri("http://test.com/"),"Test Org ID", "Test Unit ID");

            // Dummy FI User
            var financialInstitutionUser = new FinancialInstitutionUser { UserId = "Test User", Password = "Test Password"};


            // Add the account in a transaction
            using (var service = new DataService(mockContext.Object))
            {

                service.AddAccount(newAccount, financialInstitution, financialInstitutionUser);
            }

            // Verify that the service added 1 account, 1 fi and 1 fi user
            mockAccountSet.Verify(m => m.Add(It.IsAny<Account>()), Times.Once());
            mockFiSet.Verify(m => m.Add(It.IsAny<FinancialInstitution>()), Times.Once());
            mockFiUserSet.Verify(m => m.Add(It.IsAny<FinancialInstitutionUser>()), Times.Once());

            // Verify that the transaction ended properly
            mockContext.Verify(m => m.SaveChanges(), Times.Once());
        }

        /// <summary>
        /// Test functionality for determining if any accounts exist
        /// </summary>
        [TestMethod]
        public void TestAnyExistingAccount()
        {
            // Mock setup for DataService
            var mockSet = new Mock<DbSet<Account>>();
            var mockContext = new Mock<SoCashDbContext>(MockBehavior.Loose);
            mockContext.Setup(m => m.Accounts).Returns(mockSet.Object);
            mockContext.Setup(m => m.Set<Account>()).Returns(mockSet.Object);

            // Start with empty account list
            var data = new List<Account>();
            mockSet.As<IQueryable<Account>>().Setup(m => m.Provider).Returns(data.AsQueryable().Provider);
            mockSet.As<IQueryable<Account>>().Setup(m => m.Expression).Returns(data.AsQueryable().Expression);
            mockSet.As<IQueryable<Account>>().Setup(m => m.ElementType).Returns(data.AsQueryable().ElementType);
            mockSet.As<IQueryable<Account>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            // No accounts in DB
            using (var service = new DataService(mockContext.Object))
                Assert.IsFalse(service.AnyExistingAccounts());

            // Add some records
            data.Add(new Account {AccountName = "Acct1", AccountType = AccountType.Checking.ToString(),Currency = "USD"});
            data.Add(new Account {AccountName = "Acct2", AccountType = AccountType.Savings.ToString(), Currency = "USD"});
            data.Add(new Account {AccountName = "Acct3", AccountType = AccountType.Creditcard.ToString(), Currency = "USD"});

            // There are now accounts in the db
            using (var service = new DataService(mockContext.Object))
                Assert.IsTrue(service.AnyExistingAccounts());

            // Verify that both transactions ended properly
            mockContext.Verify(m => m.SaveChanges(), Times.Exactly(2));
        }

        /// <summary>
        /// Test adding a transaction
        /// </summary>
        [TestMethod]
        public void TestAddTransaction()
        {
            // Mock setup for DataService
            var mockAccountSet = new Mock<DbSet<Account>>();
            var mockTransactionSet = new Mock<ICollection<Transaction>>();
            var mockContext = new Mock<SoCashDbContext>();


            // Account containing mock transaction set
            var account = new Account {Transactions = mockTransactionSet.Object};


            // Place mock account into mock account list
            var data = new List<Account>
            {
                account
            };
            mockAccountSet.As<IQueryable<Account>>().Setup(m => m.Provider).Returns(data.AsQueryable().Provider);
            mockAccountSet.As<IQueryable<Account>>().Setup(m => m.Expression).Returns(data.AsQueryable().Expression);
            mockAccountSet.As<IQueryable<Account>>().Setup(m => m.ElementType).Returns(data.AsQueryable().ElementType);
            mockAccountSet.As<IQueryable<Account>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());
            mockContext.Setup(m => m.Accounts).Returns(mockAccountSet.Object);


            // Transaction to add
            var newTransaction = new Transaction
            {
                Amount = 100,
                CategoryName = "TestCat",
                Description = "TestDesc",
                FiTransactionId = "TRN1"
            };

            // Add the transaction
            using (var service = new DataService(mockContext.Object))
            {

                service.AddTransaction(account, newTransaction);
            }

            // Verify that the service added the transaction on the mock db exactly once
            mockTransactionSet.Verify(m => m.Add(It.IsAny<Transaction>()), Times.Once());

            // Verify that the transaction ended properly
            mockContext.Verify(m => m.SaveChanges(), Times.Once());
        }


    }
}
