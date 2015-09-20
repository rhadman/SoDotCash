namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class RecurringIntraTransactionRequest : AbstractTransactionRequest {
        
        private AbstractRecurringIntraRequest itemField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RECINTRACANRQ", typeof(RecurringIntraCancellationRequest), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("RECINTRAMODRQ", typeof(RecurringIntraModRequest), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("RECINTRARQ", typeof(RecurringIntraRequest), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public AbstractRecurringIntraRequest Item {
            get {
                return itemField;
            }
            set {
                itemField = value;
            }
        }
    }
}