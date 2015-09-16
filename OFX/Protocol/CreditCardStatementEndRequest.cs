namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class CreditCardStatementEndRequest {
        
        private CreditCardAccount cCACCTFROMField;
        
        private string dTSTARTField;
        
        private string dTENDField;
        
        private BooleanType iNCSTMTIMGField;
        
        private bool iNCSTMTIMGFieldSpecified;
        
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
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DTSTART {
            get {
                return this.dTSTARTField;
            }
            set {
                this.dTSTARTField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DTEND {
            get {
                return this.dTENDField;
            }
            set {
                this.dTENDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType INCSTMTIMG {
            get {
                return this.iNCSTMTIMGField;
            }
            set {
                this.iNCSTMTIMGField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool INCSTMTIMGSpecified {
            get {
                return this.iNCSTMTIMGFieldSpecified;
            }
            set {
                this.iNCSTMTIMGFieldSpecified = value;
            }
        }
    }
}