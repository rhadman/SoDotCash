namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class SignupMessageSet : AbstractMessageSet {
        
        private SignupMessageSetV1 sIGNUPMSGSETV1Field;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SignupMessageSetV1 SIGNUPMSGSETV1 {
            get {
                return sIGNUPMSGSETV1Field;
            }
            set {
                sIGNUPMSGSETV1Field = value;
            }
        }
    }
}