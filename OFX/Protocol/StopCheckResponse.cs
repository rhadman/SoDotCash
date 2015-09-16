namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class StopCheckResponse {
        
        private CurrencyEnum cURDEFField;
        
        private BankAccount bANKACCTFROMField;
        
        private StopCheckNumber[] sTPCHKNUMField;
        
        private string fEEField;
        
        private string fEEMSGField;
        
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
        public BankAccount BANKACCTFROM {
            get {
                return this.bANKACCTFROMField;
            }
            set {
                this.bANKACCTFROMField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("STPCHKNUM", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public StopCheckNumber[] STPCHKNUM {
            get {
                return this.sTPCHKNUMField;
            }
            set {
                this.sTPCHKNUMField = value;
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
        public string FEEMSG {
            get {
                return this.fEEMSGField;
            }
            set {
                this.fEEMSGField = value;
            }
        }
    }
}