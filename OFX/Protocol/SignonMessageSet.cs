namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class SignonMessageSet : AbstractMessageSet {
        
        private SignonMessageSetV1 sIGNONMSGSETV1Field;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SignonMessageSetV1 SIGNONMSGSETV1 {
            get {
                return sIGNONMSGSETV1Field;
            }
            set {
                sIGNONMSGSETV1Field = value;
            }
        }
    }
}