namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class Tax1098Request {
        
        private string aCCTNUMField;
        
        private string sSNField;
        
        private string[] tAXYEARField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ACCTNUM {
            get {
                return this.aCCTNUMField;
            }
            set {
                this.aCCTNUMField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string SSN {
            get {
                return this.sSNField;
            }
            set {
                this.sSNField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TAXYEAR", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="gYear")]
        public string[] TAXYEAR {
            get {
                return this.tAXYEARField;
            }
            set {
                this.tAXYEARField = value;
            }
        }
    }
}