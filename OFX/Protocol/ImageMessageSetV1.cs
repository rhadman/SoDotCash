namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class ImageMessageSetV1 : AbstractMessageSetVersion {
        
        private string dFLTIMAGEDELAYField;
        
        private string dFLTIMAGETTLField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DFLTIMAGEDELAY {
            get {
                return dFLTIMAGEDELAYField;
            }
            set {
                dFLTIMAGEDELAYField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DFLTIMAGETTL {
            get {
                return dFLTIMAGETTLField;
            }
            set {
                dFLTIMAGETTLField = value;
            }
        }
    }
}