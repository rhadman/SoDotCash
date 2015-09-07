using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Xml.Serialization;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SoDotCashTest
{
    /// <summary>
    /// Tests for OFX data structures
    /// </summary>
    [TestClass]
    public class OFXTest
    {
        public OFXTest()
        {
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void TestCCResponse()
        {
            Stream fs = File.OpenRead(@"test_cc_response_tx.ofx");
            System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(typeof(OFX.OFX));
            OFX.OFX obj = (OFX.OFX)serializer.Deserialize(fs);

            // 2 response sets
            Assert.IsNotNull(obj.Items);
            Assert.AreEqual(obj.Items.Length, 2);

            // Response message set 0 is SignonResponse
            Assert.IsInstanceOfType(obj.Items[0], typeof(OFX.SignonResponseMessageSetV1));

            // Response message set 1 is CreditcardResponse
            Assert.IsInstanceOfType(obj.Items[1], typeof(OFX.CreditcardResponseMessageSetV1));


        }
    }
}
