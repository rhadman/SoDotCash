namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class WireRequest : AbstractWireRequest {
        
        private BankAccount bANKACCTFROMField;
        
        private WireBeneficiary wIREBENEFICIARYField;
        
        private WireDestinationBank wIREDESTBANKField;
        
        private string tRNAMTField;
        
        private string dTDUEField;
        
        private string pAYINSTRUCTField;
        
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
    }
}