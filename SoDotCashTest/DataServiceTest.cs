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
        /// Test adding an account by copy
        /// </summary>
        [TestMethod]
        public void TestAddAccountCopy()
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
    }
}
