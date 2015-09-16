namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class BankAccount : AbstractAccount {
        
        private string bANKIDField;
        
        private string bRANCHIDField;
        
        private string aCCTIDField;
        
        private AccountEnum aCCTTYPEField;
        
        private string aCCTKEYField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string BANKID {
            get {
                return this.bANKIDField;
            }
            set {
                this.bANKIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string BRANCHID {
            get {
                return this.bRANCHIDField;
            }
            set {
                this.bRANCHIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ACCTID {
            get {
                return this.aCCTIDField;
            }
            set {
                this.aCCTIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public AccountEnum ACCTTYPE {
            get {
                return this.aCCTTYPEField;
            }
            set {
                this.aCCTTYPEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ACCTKEY {
            get {
                return this.aCCTKEYField;
            }
            set {
                this.aCCTKEYField = value;
            }
        }
    }
}