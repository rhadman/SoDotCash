namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class ProfileRequest {
        
        private ClientRoutingEnum cLIENTROUTINGField;
        
        private string dTPROFUPField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ClientRoutingEnum CLIENTROUTING {
            get {
                return cLIENTROUTINGField;
            }
            set {
                cLIENTROUTINGField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DTPROFUP {
            get {
                return dTPROFUPField;
            }
            set {
                dTPROFUPField = value;
            }
        }
    }
}