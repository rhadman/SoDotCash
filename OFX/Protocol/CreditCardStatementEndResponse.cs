namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class CreditCardStatementEndResponse {
        
        private CurrencyEnum cURDEFField;
        
        private CreditCardAccount cCACCTFROMField;
        
        private CreditCardClosing[] cCCLOSINGField;
        
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
        public CreditCardAccount CCACCTFROM {
            get {
                return this.cCACCTFROMField;
            }
            set {
                this.cCACCTFROMField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CCCLOSING", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public CreditCardClosing[] CCCLOSING {
            get {
                return this.cCCLOSINGField;
            }
            set {
                this.cCCLOSINGField = value;
            }
        }
    }
}