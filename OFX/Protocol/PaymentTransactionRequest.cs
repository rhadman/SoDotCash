namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class PaymentTransactionRequest : AbstractTransactionRequest {
        
        private AbstractPaymentRequest itemField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PMTCANCRQ", typeof(PaymentCancelRequest), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("PMTMODRQ", typeof(PaymentModRequest), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("PMTRQ", typeof(PaymentRequest), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public AbstractPaymentRequest Item {
            get {
                return itemField;
            }
            set {
                itemField = value;
            }
        }
    }
}