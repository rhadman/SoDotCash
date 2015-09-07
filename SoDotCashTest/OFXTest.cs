using System;
using System.IO;
using System.Xml.Serialization;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OFX;
using System.Threading.Tasks;

namespace SoDotCashTest
{
    /// <summary>
    /// Tests for OFX data structure serialization/deserialization logic and compatibility with remote services
    /// </summary>
    [TestClass]
    public class OFXTest
    {
        public OFXTest()
        {
        }
        private TestContext testContextInstance;

        /// <summary>
        /// </summary>
        [TestMethod]
        public async Task TestListProfiles()
        {
            OFXFinancialInstitution fi = new OFXFinancialInstitution(new Uri("https://ofx.chase.com"), "B1", "10898");
            OFXCredentials creds = new OFXCredentials("my_username", "my_password");
            OFX2Service service = new OFX2Service(fi, creds);
            OFX.OFX result = await service.listProfiles();
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
            XmlSerializer serializer = new XmlSerializer(typeof(OFX.OFX));

            // Deserialize the XML data 
            OFX.OFX obj = (OFX.OFX)serializer.Deserialize(fs);

            // Expect: 2 response sets
            Assert.IsNotNull(obj.Items);
            Assert.AreEqual(obj.Items.Length, 2);

            // Expect: Response message set 0 is SignonResponse
            Assert.IsInstanceOfType(obj.Items[0], typeof(OFX.SignonResponseMessageSetV1));

            // Expect: Response message set 1 is CreditcardResponse
            Assert.IsInstanceOfType(obj.Items[1], typeof(OFX.CreditcardResponseMessageSetV1));
        }
    }
}
