namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class RecurringInterTransactionRequest : AbstractTransactionRequest {
        
        private AbstractRecurringInterRequest itemField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RECINTERCANRQ", typeof(RecurringInterCancellationRequest), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("RECINTERMODRQ", typeof(RecurringInterModRequest), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("RECINTERRQ", typeof(RecurringInterRequest), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public AbstractRecurringInterRequest Item {
            get {
                return itemField;
            }
            set {
                itemField = value;
            }
        }
    }
}