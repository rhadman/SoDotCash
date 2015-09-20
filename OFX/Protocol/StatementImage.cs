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
                return iMAGEURLField;
            }
            set {
                iMAGEURLField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PREFETCHURL", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[] PREFETCHURL {
            get {
                return pREFETCHURLField;
            }
            set {
                pREFETCHURLField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DTEXPIRE {
            get {
                return dTEXPIREField;
            }
            set {
                dTEXPIREField = value;
            }
        }
    }
}