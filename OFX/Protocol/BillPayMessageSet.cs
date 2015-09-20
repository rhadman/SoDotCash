namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class BillPayMessageSet : AbstractMessageSet {
        
        private BillPayMessageSetV1 bILLPAYMSGSETV1Field;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BillPayMessageSetV1 BILLPAYMSGSETV1 {
            get {
                return bILLPAYMSGSETV1Field;
            }
            set {
                bILLPAYMSGSETV1Field = value;
            }
        }
    }
}