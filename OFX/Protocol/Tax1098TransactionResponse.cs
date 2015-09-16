namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class Tax1098TransactionResponse {
        
        private string tRNUIDField;
        
        private Status sTATUSField;
        
        private string cLTCOOKIEField;
        
        private Tax1098Response tAX1098RSField;
        
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
        public Status STATUS {
            get {
                return this.sTATUSField;
            }
            set {
                this.sTATUSField = value;
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
        public Tax1098Response TAX1098RS {
            get {
                return this.tAX1098RSField;
            }
            set {
                this.tAX1098RSField = value;
            }
        }
    }
}