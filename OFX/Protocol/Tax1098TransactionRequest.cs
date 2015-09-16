namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class Tax1098TransactionRequest {
        
        private string tRNUIDField;
        
        private string cLTCOOKIEField;
        
        private string tANField;
        
        private Tax1098Request tAX1098RQField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string TRNUID {
            get {
                return tRNUIDField;
            }
            set {
                tRNUIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string CLTCOOKIE {
            get {
                return cLTCOOKIEField;
            }
            set {
                cLTCOOKIEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string TAN {
            get {
                return tANField;
            }
            set {
                tANField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Tax1098Request TAX1098RQ {
            get {
                return tAX1098RQField;
            }
            set {
                tAX1098RQField = value;
            }
        }
    }
}