namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class BankMessageSet : AbstractMessageSet {
        
        private BankMessageSetV1 bANKMSGSETV1Field;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BankMessageSetV1 BANKMSGSETV1 {
            get {
                return this.bANKMSGSETV1Field;
            }
            set {
                this.bANKMSGSETV1Field = value;
            }
        }
    }
}