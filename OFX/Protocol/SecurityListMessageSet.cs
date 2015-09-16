namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class SecurityListMessageSet : AbstractMessageSet {
        
        private SecurityListMessageSetV1 sECLISTMSGSETV1Field;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SecurityListMessageSetV1 SECLISTMSGSETV1 {
            get {
                return sECLISTMSGSETV1Field;
            }
            set {
                sECLISTMSGSETV1Field = value;
            }
        }
    }
}