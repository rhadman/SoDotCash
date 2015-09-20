namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class LocalInfo {
        
        private string lOCALITYField;
        
        private string lOCALWAGESField;
        
        private string lOCALTAXWHField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string LOCALITY {
            get {
                return lOCALITYField;
            }
            set {
                lOCALITYField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string LOCALWAGES {
            get {
                return lOCALWAGESField;
            }
            set {
                lOCALWAGESField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string LOCALTAXWH {
            get {
                return lOCALTAXWHField;
            }
            set {
                lOCALTAXWHField = value;
            }
        }
    }
}