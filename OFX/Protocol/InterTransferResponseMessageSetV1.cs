namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class InterTransferResponseMessageSetV1 : AbstractResponseMessageSet {
        
        private AbstractResponse[] itemsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("INTERSYNCRS", typeof(InterSyncResponse), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("INTERTRNRS", typeof(InterTransactionResponse), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("RECINTERSYNCRS", typeof(RecurringInterSyncResponse), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("RECINTERTRNRS", typeof(RecurringInterTransactionResponse), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public AbstractResponse[] Items {
            get {
                return itemsField;
            }
            set {
                itemsField = value;
            }
        }
    }
}