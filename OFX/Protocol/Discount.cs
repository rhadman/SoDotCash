namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class Discount {
        
        private string dSCRATEField;
        
        private string dSCAMTField;
        
        private string dSCDATEField;
        
        private string dSCDESCField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DSCRATE {
            get {
                return this.dSCRATEField;
            }
            set {
                this.dSCRATEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DSCAMT {
            get {
                return this.dSCAMTField;
            }
            set {
                this.dSCAMTField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DSCDATE {
            get {
                return this.dSCDATEField;
            }
            set {
                this.dSCDATEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DSCDESC {
            get {
                return this.dSCDESCField;
            }
            set {
                this.dSCDESCField = value;
            }
        }
    }
}