using System;
using System.Text;
using System.Collections.Generic;
using System.Data.Entity;
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
    }
}
