namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class PresentmentDlvMessageSetV1 : AbstractMessageSetVersion {
        
        private PresentmentDlvProfile pRESDLVPROFField;
        
        private EmailProfile eMAILPROFField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PresentmentDlvProfile PRESDLVPROF {
            get {
                return pRESDLVPROFField;
            }
            set {
                pRESDLVPROFField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public EmailProfile EMAILPROF {
            get {
                return eMAILPROFField;
            }
            set {
                eMAILPROFField = value;
            }
        }
    }
}