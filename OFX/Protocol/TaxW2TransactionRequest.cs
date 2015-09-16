namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class TaxW2TransactionRequest {
        
        private string tRNUIDField;
        
        private string cLTCOOKIEField;
        
        private string tANField;
        
        private TaxW2Request tAXW2RQField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string TRNUID {
            get {
                return this.tRNUIDField;
            }
            set {
                this.tRNUIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string CLTCOOKIE {
            get {
                return this.cLTCOOKIEField;
            }
            set {
                this.cLTCOOKIEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string TAN {
            get {
                return this.tANField;
            }
            set {
                this.tANField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public TaxW2Request TAXW2RQ {
            get {
                return this.tAXW2RQField;
            }
            set {
                this.tAXW2RQField = value;
            }
        }
    }
}