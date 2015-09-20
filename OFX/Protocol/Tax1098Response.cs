namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class Tax1098Response {
        
        private string aCCTNUMField;
        
        private string sSNField;
        
        private Tax1098_V100[] tAX1098_V100Field;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ACCTNUM {
            get {
                return aCCTNUMField;
            }
            set {
                aCCTNUMField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string SSN {
            get {
                return sSNField;
            }
            set {
                sSNField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TAX1098_V100", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Tax1098_V100[] TAX1098_V100 {
            get {
                return tAX1098_V100Field;
            }
            set {
                tAX1098_V100Field = value;
            }
        }
    }
}