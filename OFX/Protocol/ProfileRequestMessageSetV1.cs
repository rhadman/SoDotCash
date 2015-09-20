namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class ProfileRequestMessageSetV1 : AbstractRequestMessageSet {
        
        private ProfileTransactionRequest[] pROFTRNRQField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PROFTRNRQ", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ProfileTransactionRequest[] PROFTRNRQ {
            get {
                return pROFTRNRQField;
            }
            set {
                pROFTRNRQField = value;
            }
        }
    }
}