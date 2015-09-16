namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class MailSyncResponse : AbstractSyncResponse {
        
        private MailTransactionResponse[] mAILTRNRSField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MAILTRNRS", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public MailTransactionResponse[] MAILTRNRS {
            get {
                return mAILTRNRSField;
            }
            set {
                mAILTRNRSField = value;
            }
        }
    }
}