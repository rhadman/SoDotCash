using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using SoDotCash.Models;
using SoDotCash.Services;

namespace SoDotCashTest
{
    /// <summary>
    /// Test cases for the DataService.
    /// The DataService provides a thin business logic layer on top of Database operations.
    /// The tests here ensure that the business logic is properly implemented in terms of DB operations.
    /// </summary>
    [TestClass]
    public class DataServiceTest
    {

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
            mockTransactionSet.Verify(m => m.Add(newTransaction), Times.Once());

            // Verify that the transaction ended properly
            mockContext.Verify(m => m.SaveChanges(), Times.Once());
        }

        /// <summary>
        /// Test deleting a transaction
        /// </summary>
        [TestMethod]
        public void TestDeleteTransaction()
        {
            // Transaction to delete
            var transaction = new Transaction
            {
                Amount = 100,
                CategoryName = "TestCat",
                Description = "TestDesc",
                FiTransactionId = "TRN1"
            };

            // Mock for Entity() call on context
            var mockEntityEntry = new Mock<DbEntityEntry<Transaction>>();
            mockEntityEntry.SetupAllProperties();

            // Mock setup for DataService
            var mockTransactionSet = new Mock<DbSet<Transaction>>();
            var mockContext = new Mock<SoCashDbContext>();
            mockContext.Setup(m => m.Set<Transaction>()).Returns(mockTransactionSet.Object);


            // Delete the transaction
            using (var service = new DataService(mockContext.Object))
                service.DeleteTransaction(transaction);

            // Verify that the service removed the transaction on the mock db exactly once
            mockTransactionSet.Verify(m => m.Remove(transaction), Times.Once());

            // Verify that the transaction ended properly
            mockContext.Verify(m => m.SaveChanges(), Times.Once());
        }

        /// <summary>
        /// Test updating a transaction
        /// </summary>
        [TestMethod]
        public void TestUpdateTransaction()
        {
            // Transaction used for test
            var transaction = new Transaction
            {
                Amount = 100,
                CategoryName = "TestCat",
                Description = "TestDesc",
                FiTransactionId = "TRN1"
            };

            // Mock setup for DataService
            var mockTransactionSet = new Mock<DbSet<Transaction>>();
            var mockContext = new Mock<SoCashDbContext>();
            mockContext.Setup(m => m.Set<Transaction>()).Returns(mockTransactionSet.Object);


            // Update the transaction
            using (var service = new DataService(mockContext.Object))
                service.UpdateTransaction(transaction);

            // Verify that the service joined the transaction to the session in a modified state
            mockContext.Verify(m => m.SetModified(transaction), Times.Once());

            // Verify that the transaction ended properly
            mockContext.Verify(m => m.SaveChanges(), Times.Once());
        }

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
            mockSet.Verify(m => m.Add(newAccount), Times.Once());

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
            var financialInstitution = new OFX.Types.FinancialInstitution("Test FI", new Uri("http://test.com/"), "Test Org ID", "Test Unit ID");

            // Dummy FI User
            var financialInstitutionUser = new FinancialInstitutionUser { UserId = "Test User", Password = "Test Password" };


            // Add the account in a transaction
            using (var service = new DataService(mockContext.Object))
            {

                service.AddAccount(newAccount, financialInstitution, financialInstitutionUser);
            }

            // Verify that the service added 1 account, 1 fi and 1 fi user
            mockAccountSet.Verify(m => m.Add(newAccount), Times.Once());
            mockFiSet.Verify(m => m.Add(It.IsAny<FinancialInstitution>()), Times.Once());
            mockFiUserSet.Verify(m => m.Add(financialInstitutionUser), Times.Once());

            // Verify that the transaction ended properly
            mockContext.Verify(m => m.SaveChanges(), Times.Once());
        }

        /// <summary>
        /// Test deleting and account
        /// </summary>
        [TestMethod]
        public void TestDeleteAccount()
        {
            // Account for test
            var account = new Account
            {
                AccountName = "Test Account",
                AccountType = AccountType.Checking.ToString(),
                Currency = "USD"
            };

            // Mock setup for DataService
            var mockAccountSet = new Mock<DbSet<Account>>();
            var mockContext = new Mock<SoCashDbContext>();
            mockContext.Setup(m => m.Set<Account>()).Returns(mockAccountSet.Object);

            // Delete the account
            using (var service = new DataService(mockContext.Object))
                service.DeleteAccount(account);

            // Verify that the service removed the account on the mock db exactly once
            mockAccountSet.Verify(m => m.Remove(account), Times.Once());

            // Verify that the transaction ended properly
            mockContext.Verify(m => m.SaveChanges(), Times.Once());
        }

        /// <summary>
        /// Test updating an account
        /// </summary>
        [TestMethod]
        public void TestUpdateAccount()
        {
            // Account for test
            var account = new Account
            {
                AccountName = "Test Account",
                AccountType = AccountType.Checking.ToString(),
                Currency = "USD"
            };

            // Mock setup for DataService
            var mockAccountSet = new Mock<DbSet<Account>>();
            var mockContext = new Mock<SoCashDbContext>();
            mockContext.Setup(m => m.Set<Account>()).Returns(mockAccountSet.Object);

            // Update the account
            using (var service = new DataService(mockContext.Object))
                service.UpdateAccount(account);

            // Verify that the service attached the account on the mock db exactly once
            mockContext.Verify(m => m.SetModified(account), Times.Once());

            // Verify that the transaction ended properly
            mockContext.Verify(m => m.SaveChanges(), Times.Once());
        }

        /// <summary>
        /// Test unlinking a FI from an account
        /// </summary>
        [TestMethod]
        public void TestUnlinkAccount()
        {
            // Mocked FI User
            var mockFiUser = new Mock<FinancialInstitutionUser>();
            mockFiUser.SetupAllProperties();

            // Account for test
            var account = new Account
            {
                AccountName = "Test Account",
                AccountType = AccountType.Checking.ToString(),
                Currency = "USD",
                FinancialInstitutionUser = mockFiUser.Object
            };

            // Mock setup for DataService
            var data = new List<Account> { account };
            var dataMock = new Mock<IList<Account>>();
            dataMock.As<IQueryable<Account>>().Setup(m => m.Provider).Returns(data.AsQueryable().Provider);
            dataMock.As<IQueryable<Account>>().Setup(m => m.Expression).Returns(data.AsQueryable().Expression);
            dataMock.As<IQueryable<Account>>().Setup(m => m.ElementType).Returns(data.AsQueryable().ElementType);
            dataMock.As<IQueryable<Account>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            var mockContext = new Mock<SoCashDbContext>();
            mockFiUser.Setup(m => m.Accounts).Returns(dataMock.Object);

            // Unlink the account
            using (var service = new DataService(mockContext.Object))
                service.UnlinkAccount(account);

            // Verify that the service attached the account on the mock db exactly once
            mockContext.Verify(m => m.SetModified(account), Times.Once());

            // Verify that the account has the FiUser removed
            dataMock.Verify(m => m.Remove(account), Times.Once());

            // Verify that the transaction ended properly
            mockContext.Verify(m => m.SaveChanges(), Times.Once());
        }

        /// <summary>
        /// Test updating the information associated with a financialinstitutionuser
        /// </summary>
        [TestMethod]
        public void TestUpdateFiUser()
        {
            // FiUser for test
            var fiUser = new FinancialInstitutionUser {UserId = "OriginalId", Password = "OriginalPw"};

            // Mock setup for DataService
            var mockFiUserSet = new Mock<DbSet<FinancialInstitutionUser>>();
            var mockContext = new Mock<SoCashDbContext>();
            mockContext.Setup(m => m.Set<FinancialInstitutionUser>()).Returns(mockFiUserSet.Object);

            // Update the user
            using (var service = new DataService(mockContext.Object))
                service.UpdateFiUser(fiUser);

            // Verify that the service attached the user on the mock db exactly once
            mockContext.Verify(m => m.SetModified(fiUser), Times.Once());

            // Verify that the transaction ended properly
            mockContext.Verify(m => m.SaveChanges(), Times.Once());
        }
    }
}
