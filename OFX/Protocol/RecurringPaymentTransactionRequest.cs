namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class RecurringPaymentTransactionRequest : AbstractTransactionRequest {
        
        private AbstractRecurringPaymentRequest itemField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RECPMTCANCRQ", typeof(RecurringPaymentCancelRequest), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("RECPMTMODRQ", typeof(RecurringPaymentModRequest), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("RECPMTRQ", typeof(RecurringPaymentRequest), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public AbstractRecurringPaymentRequest Item {
            get {
                return itemField;
            }
            set {
                itemField = value;
            }
        }
    }
}