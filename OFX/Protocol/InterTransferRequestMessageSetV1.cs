namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class InterTransferRequestMessageSetV1 : AbstractRequestMessageSet {
        
        private AbstractRequest[] itemsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("INTERSYNCRQ", typeof(InterSyncRequest), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("INTERTRNRQ", typeof(InterTransactionRequest), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("RECINTERSYNCRQ", typeof(RecurringInterSyncRequest), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("RECINTERTRNRQ", typeof(RecurringInterTransactionRequest), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
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