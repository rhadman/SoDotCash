namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class EmailRequestMessageSetV1 : AbstractRequestMessageSet {
        
        private AbstractRequest[] itemsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("GETMIMETRNRQ", typeof(GetMimeTransactionRequest), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("MAILSYNCRQ", typeof(MailSyncRequest), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("MAILTRNRQ", typeof(MailTransactionRequest), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public AbstractRequest[] Items {
            get {
                return itemsField;
            }
            set {
                itemsField = value;
            }
        }
    }
}