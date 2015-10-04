using System;
using System.IO;
using System.Xml.Serialization;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OFX;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using OFX.Protocol;
using OFX.Types;
using FinancialInstitution = OFX.Types.FinancialInstitution;

namespace SoDotCashTest
{
    /// <summary>
    /// Tests for OFX data structure serialization/deserialization logic and compatibility with remote services
    /// </summary>
    [TestClass]
    public class OfxTest
    {

        public OfxTest()
        {
            // Log trace log to console (when run in debug mode)
            Trace.Listeners.Add(new TextWriterTraceListener(Console.Out));
        }

        /// <summary>
        /// Helper function to log the contents of OFX statements out to the debug console
        /// </summary>
        /// <param name="statements">Statements to log</param>
        protected void DumpStatement(IEnumerable<OFX.Types.Statement> statements)
        {
            foreach (var statement in statements)
            {
                Trace.WriteLine("Statement for " + statement.OwningAccount.ToString());
                foreach (var transaction in statement.Transactions)
                {
                    Trace.WriteLine(transaction);
                }
            }
        }

        /// <summary>
        /// Test the ability to list financial institutions from the embedded data file
        /// </summary>
        [TestMethod]
        public void TestListFinancialInstitutions()
        {
            // Retrieve financial institutions
            var financialInstitutions = OFX2Service.ListFinancialInstitutions();

            // Must not be null
            Assert.IsNotNull(financialInstitutions);

            // Must have at least 1 entry
            Assert.IsTrue(financialInstitutions.Count >0);

            // All entries must have a name URL, FI and ORG specified
            foreach (var fi in financialInstitutions)
            {
                Assert.IsNotNull(fi.Name);
                Assert.IsNotNull(fi.ServiceEndpoint);
                Assert.IsNotNull(fi.FinancialId);
                Assert.IsNotNull(fi.OrganizationId);
            }

            // Log number of entries to assist with manual diagnostics
            Trace.WriteLine("There are " + financialInstitutions.Count + " institutions in the embedded FI list.");
        }

        /// <summary>
        /// Test the ability to list profiles from financial institutions in the embedded data file
        /// </summary>
        [TestMethod]
        public async Task TestListFiProfiles()
        {
            // Retrieve financial institutions
            var financialInstitutions = OFX2Service.ListFinancialInstitutions();

            // Default empty credentials
            var emptyCredentials = new Credentials("","");

            // Step through each, count success and failure
            int successCount = 0;
            int failureCount = 0;
            foreach (var fi in financialInstitutions)
            {
                var ofxService = new OFX2Service(fi, emptyCredentials);

                // Only test a few entries during a normal run. Each entry can take a significant amount of time to test.
                if (successCount + failureCount > 5)
                    continue;

                try
                {
                    var profiles = await ofxService.ListProfiles();

                    // At least 1 profile should come back
                    if (profiles.Items.Length == 0)
                    {
                        // Manual diagnostics assistance
                        Trace.WriteLine("No profiles returned for " + fi.Name + " at " + fi.ServiceEndpoint);
                        failureCount++;
                    }
                    else
                    {
                        successCount++;
                    }
                }
                catch (Exception)
                {
                    // Any exception is a failure
                    failureCount++;

                    // Manual diagnostics assistance
                    Trace.WriteLine("Failed to list profiles for " + fi.Name + " at " + fi.ServiceEndpoint);
                }
            }

            // At least 1 of the profiles should succed
            Assert.IsTrue(successCount >= 1);

        }


        /// <summary>
        /// Validatation of deserialization of sample Credit Card response data with transaction entries.
        /// Validates OFX deserialization logic for typical valid use case.
        /// </summary>
        [TestMethod]
        public void TestCcResponse()
        {
            // Open test input file - Credit Card Response containing sample transaction data
            Stream fs = File.OpenRead(@"test_cc_response_tx.ofx");

            // Instantiate an XML serializer which will be used to deserialize the sample data into the Object model
            XmlSerializer serializer = new XmlSerializer(typeof(OFX.Protocol.OFX));

            // Deserialize the XML data 
            OFX.Protocol.OFX obj = (OFX.Protocol.OFX)serializer.Deserialize(fs);

            // Expect: 2 response sets
            Assert.IsNotNull(obj.Items);
            Assert.AreEqual(obj.Items.Length, 2);

            // Expect: Response message set 0 is SignonResponse
            Assert.IsInstanceOfType(obj.Items[0], typeof(SignonResponseMessageSetV1));

            // Expect: Response message set 1 is CreditcardResponse
            Assert.IsInstanceOfType(obj.Items[1], typeof(CreditcardResponseMessageSetV1));
        }

        /// <summary>
        /// Test parsing an OFX1 style response file
        /// </summary>
        [TestMethod]
        public void TestOfx1()
        {
            using (var stream = new FileStream("test_cc_1.ofx", FileMode.Open))
            {
                OFX1ToOFX2Converter converter = new OFX1ToOFX2Converter(stream);

                // Deserialize the XML data 
                var obj = converter.ConvertToOFX();

                // Expect: 2 response sets
                Assert.IsNotNull(obj.Items);
                Assert.AreEqual(obj.Items.Length, 2);

                // Expect: Response message set 0 is SignonResponse
                Assert.IsInstanceOfType(obj.Items[0], typeof(SignonResponseMessageSetV1));

                // Parses the response to ensure it's valid, and records response data to trace log
                DumpStatement(Statement.CreateFromOFXResponse(obj));

            }
        }

        /// <summary>
        /// Test parsing an OFX1 style response file that is invalid
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestOfx1Invalid()
        {
            using (var stream = new FileStream("test_cc_2.ofx", FileMode.Open))
            {
                OFX1ToOFX2Converter converter = new OFX1ToOFX2Converter(stream);

                // Deserialize the XML data 
                var obj = converter.ConvertToOFX();

                // Expect: 2 response sets
                Assert.IsNotNull(obj.Items);
                Assert.AreEqual(obj.Items.Length, 2);

                // Expect: Response message set 0 is SignonResponse
                Assert.IsInstanceOfType(obj.Items[0], typeof(SignonResponseMessageSetV1));

                // Parses the response to ensure it's valid, and records response data to trace log
                DumpStatement(Statement.CreateFromOFXResponse(obj));

            }
        }

        #region Requires User Credentials

        // Tests in this section require valid user credentials

        /// <summary>
        /// User credentials to use for authenticated requests.
        /// </summary>
        private static readonly Credentials UserCredentials = new Credentials("myuser", "mypass");

        /// <summary>
        /// The FI to contact for authenticated requests
        /// </summary>
        private static readonly FinancialInstitution AuthenticatedFi = new FinancialInstitution("Chase Bank", new Uri("https://ofx.chase.com"), "B1", "10898");

        /// <summary>
        /// Service associated with the above FI and credentials
        /// </summary>
        private static readonly OFX2Service AuthenticatedOfxService = new OFX2Service(AuthenticatedFi, UserCredentials);


        /// <summary>
        /// Test that accounts can be retrieved from the configured authenticated Financial Institution using OFX service
        /// </summary>
        [TestMethod]
        [Ignore]
        public async Task TestListAccounts()
        {
            // Retrieve accounts using provided credentials
            IEnumerable<OFX.Types.Account> accounts = await AuthenticatedOfxService.ListAccounts();

            // At least 1 account must be returned
            Assert.IsNotNull(accounts);
            Assert.IsTrue(accounts.Any());

            // Ensure each account has a type associated
            foreach (var account in accounts)
                Assert.IsNotNull(account.GetType().Name);
        }

        /// <summary>
        /// Test that statements can be retrieved from all accounts returned from the authenticated FI
        /// </summary>
        [TestMethod]
        [Ignore]
        public async Task TestGetStatement()
        {
            // Retrieve accounts using provided credentials
            IEnumerable<OFX.Types.Account> accounts = await AuthenticatedOfxService.ListAccounts();

            // At least 1 account must be returned
            Assert.IsNotNull(accounts);
            Assert.IsTrue(accounts.Any());

            // Retrieve transactions for the last 30 days
            var startTime = DateTimeOffset.Now.Subtract(new TimeSpan(30, 0, 0, 0));

            // Retrieve statements for each account
            foreach (var account in accounts)
            {
                // Retrieve statement for the account.
                var statements =
                    await AuthenticatedOfxService.GetStatement((OFX.Types.CreditCardAccount)account, startTime, DateTimeOffset.Now);

                // Should only be one statement
                Assert.Equals(statements.Count(), 1);

                // Iterates statements and transactions, records to debug file and raises exception if the data is invalid
                DumpStatement(statements);
            }
        }

        #endregion


    }
}
