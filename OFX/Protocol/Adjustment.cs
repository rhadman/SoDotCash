namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class Adjustment {
        
        private string aDJNOField;
        
        private string aDJDESCField;
        
        private string aDJAMTField;
        
        private string aDJDATEField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ADJNO {
            get {
                return this.aDJNOField;
            }
            set {
                this.aDJNOField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ADJDESC {
            get {
                return this.aDJDESCField;
            }
            set {
                this.aDJDESCField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ADJAMT {
            get {
                return this.aDJAMTField;
            }
            set {
                this.aDJAMTField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ADJDATE {
            get {
                return this.aDJDATEField;
            }
            set {
                this.aDJDATEField = value;
            }
        }
    }
}