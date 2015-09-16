namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class WireResponse : AbstractWireResponse {
        
        private CurrencyEnum cURDEFField;
        
        private string sRVRTIDField;
        
        private BankAccount bANKACCTFROMField;
        
        private WireBeneficiary wIREBENEFICIARYField;
        
        private WireDestinationBank wIREDESTBANKField;
        
        private string tRNAMTField;
        
        private string dTDUEField;
        
        private string pAYINSTRUCTField;
        
        private string itemField;
        
        private ItemChoiceType12 itemElementNameField;
        
        private string fEEField;
        
        private string cONFMSGField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public CurrencyEnum CURDEF {
            get {
                return cURDEFField;
            }
            set {
                cURDEFField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string SRVRTID {
            get {
                return sRVRTIDField;
            }
            set {
                sRVRTIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BankAccount BANKACCTFROM {
            get {
                return bANKACCTFROMField;
            }
            set {
                bANKACCTFROMField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public WireBeneficiary WIREBENEFICIARY {
            get {
                return wIREBENEFICIARYField;
            }
            set {
                wIREBENEFICIARYField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public WireDestinationBank WIREDESTBANK {
            get {
                return wIREDESTBANKField;
            }
            set {
                wIREDESTBANKField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string TRNAMT {
            get {
                return tRNAMTField;
            }
            set {
                tRNAMTField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DTDUE {
            get {
                return dTDUEField;
            }
            set {
                dTDUEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string PAYINSTRUCT {
            get {
                return pAYINSTRUCTField;
            }
            set {
                pAYINSTRUCTField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DTPOSTED", typeof(string), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("DTXFERPRJ", typeof(string), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public string Item {
            get {
                return itemField;
            }
            set {
                itemField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType12 ItemElementName {
            get {
                return itemElementNameField;
            }
            set {
                itemElementNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string FEE {
            get {
                return fEEField;
            }
            set {
                fEEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string CONFMSG {
            get {
                return cONFMSGField;
            }
            set {
                cONFMSGField = value;
            }
        }
    }
}