namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class StatementEndResponse {
        
        private CurrencyEnum cURDEFField;
        
        private BankAccount bANKACCTFROMField;
        
        private Closing[] cLOSINGField;
        
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
        public BankAccount BANKACCTFROM {
            get {
                return bANKACCTFROMField;
            }
            set {
                bANKACCTFROMField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CLOSING", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Closing[] CLOSING {
            get {
                return cLOSINGField;
            }
            set {
                cLOSINGField = value;
            }
        }
    }
}