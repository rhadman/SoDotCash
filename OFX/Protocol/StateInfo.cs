namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class StateInfo {
        
        private string sTATECODEField;
        
        private string eMPLOYERSTIDField;
        
        private string sTATEWAGESField;
        
        private string sTATETAXWHField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string STATECODE {
            get {
                return sTATECODEField;
            }
            set {
                sTATECODEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string EMPLOYERSTID {
            get {
                return eMPLOYERSTIDField;
            }
            set {
                eMPLOYERSTIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string STATEWAGES {
            get {
                return sTATEWAGESField;
            }
            set {
                sTATEWAGESField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string STATETAXWH {
            get {
                return sTATETAXWHField;
            }
            set {
                sTATETAXWHField = value;
            }
        }
    }
}