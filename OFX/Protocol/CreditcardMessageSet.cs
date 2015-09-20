namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class CreditcardMessageSet : AbstractMessageSet {
        
        private CreditcardMessageSetV1 cREDITCARDMSGSETV1Field;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public CreditcardMessageSetV1 CREDITCARDMSGSETV1 {
            get {
                return cREDITCARDMSGSETV1Field;
            }
            set {
                cREDITCARDMSGSETV1Field = value;
            }
        }
    }
}