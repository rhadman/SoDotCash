using System;
using System.IO;
using System.Xml.Serialization;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OFX;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Collections.Generic;
using OFX.Protocol;
using OFX.Types;
using FinancialInstitution = OFX.Types.FinancialInstitution;

namespace SoDotCashTest
{
    /// <summary>
    /// Tests for OFX data structure serialization/deserialization logic and compatibility with remote services
    /// </summary>
    [TestClass]
    public class OFXTest
    {
        private static readonly Credentials UserCredentials = new Credentials("myuser", "mypass");
        private static readonly FinancialInstitution ChaseBankFi = new FinancialInstitution(new Uri("https://ofx.chase.com"), "B1", "10898"); 
        private static readonly OFX2Service ChaseBankService = new OFX2Service(ChaseBankFi, UserCredentials);


        public OFXTest()
        {
            Trace.Listeners.Add(new TextWriterTraceListener(Console.Out));
        }
        private TestContext testContextInstance;

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

                // Expect: Response message set 1 is CreditcardResponse
                //Assert.IsInstanceOfType(obj.Items[1], typeof(OFX.CreditcardResponseMessageSetV1));

                DumpStatement(OFX.Types.Statement.CreateFromOFXResponse(obj));

            }
        }

        /// <summary>
        /// </summary>
        [TestMethod]
        public async Task TestListProfiles()
        {
            OFX.Protocol.OFX result = await ChaseBankService.ListProfiles();
        }

        /// <summary>
        /// </summary>
        [TestMethod]
        public async Task TestListAccounts()
        {
            IEnumerable<OFX.Types.Account> accounts = await ChaseBankService.ListAccounts();

            foreach (var account in accounts)
            {
                Trace.WriteLine(account.GetType().Name);
            }
        }

        /// <summary>
        /// </summary>
        [TestMethod]
        public async Task TestGetStatement()
        {
            IEnumerable<OFX.Types.Account> accounts = await ChaseBankService.ListAccounts();
            foreach (var account in accounts)
            {
                var startTime = DateTimeOffset.Now.Subtract(new TimeSpan(30, 0, 0, 0));
                var statements =
                    await ChaseBankService.GetStatement((OFX.Types.CreditCardAccount)account, startTime, DateTimeOffset.Now);
                DumpStatement(statements);
            }
        }

        /// <summary>
        /// Validatation of deserialization of sample Credit Card response data with transaction entries.
        /// Validates OFX deserialization logic for typical valid use case.
        /// </summary>
        [TestMethod]
        public void TestCCResponse()
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
    }
}
