namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class Tax1099Request {
        
        private string aCCTNUMField;
        
        private string rECIDField;
        
        private string[] tAXYEARField;
        
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
        public string RECID {
            get {
                return rECIDField;
            }
            set {
                rECIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TAXYEAR", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="gYear")]
        public string[] TAXYEAR {
            get {
                return tAXYEARField;
            }
            set {
                tAXYEARField = value;
            }
        }
    }
}