namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class EmailMessageSet : AbstractMessageSet {
        
        private EmailMessageSetV1 eMAILMSGSETV1Field;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public EmailMessageSetV1 EMAILMSGSETV1 {
            get {
                return eMAILMSGSETV1Field;
            }
            set {
                eMAILMSGSETV1Field = value;
            }
        }
    }
}