namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class StatementImage {
        
        private string iMAGEURLField;
        
        private string[] pREFETCHURLField;
        
        private string dTEXPIREField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string IMAGEURL {
            get {
                return this.iMAGEURLField;
            }
            set {
                this.iMAGEURLField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PREFETCHURL", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[] PREFETCHURL {
            get {
                return this.pREFETCHURLField;
            }
            set {
                this.pREFETCHURLField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DTEXPIRE {
            get {
                return this.dTEXPIREField;
            }
            set {
                this.dTEXPIREField = value;
            }
        }
    }
}