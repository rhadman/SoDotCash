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
                return this.cURDEFField;
            }
            set {
                this.cURDEFField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string SRVRTID {
            get {
                return this.sRVRTIDField;
            }
            set {
                this.sRVRTIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BankAccount BANKACCTFROM {
            get {
                return this.bANKACCTFROMField;
            }
            set {
                this.bANKACCTFROMField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public WireBeneficiary WIREBENEFICIARY {
            get {
                return this.wIREBENEFICIARYField;
            }
            set {
                this.wIREBENEFICIARYField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public WireDestinationBank WIREDESTBANK {
            get {
                return this.wIREDESTBANKField;
            }
            set {
                this.wIREDESTBANKField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string TRNAMT {
            get {
                return this.tRNAMTField;
            }
            set {
                this.tRNAMTField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DTDUE {
            get {
                return this.dTDUEField;
            }
            set {
                this.dTDUEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string PAYINSTRUCT {
            get {
                return this.pAYINSTRUCTField;
            }
            set {
                this.pAYINSTRUCTField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DTPOSTED", typeof(string), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("DTXFERPRJ", typeof(string), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public string Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType12 ItemElementName {
            get {
                return this.itemElementNameField;
            }
            set {
                this.itemElementNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string FEE {
            get {
                return this.fEEField;
            }
            set {
                this.fEEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string CONFMSG {
            get {
                return this.cONFMSGField;
            }
            set {
                this.cONFMSGField = value;
            }
        }
    }
}