namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class SecurityId {
        
        private string uNIQUEIDField;
        
        private string uNIQUEIDTYPEField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string UNIQUEID {
            get {
                return uNIQUEIDField;
            }
            set {
                uNIQUEIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string UNIQUEIDTYPE {
            get {
                return uNIQUEIDTYPEField;
            }
            set {
                uNIQUEIDTYPEField = value;
            }
        }
    }
}