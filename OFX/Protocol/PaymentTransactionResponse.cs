namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class PaymentTransactionResponse : AbstractTransactionResponse {
        
        private AbstractPaymentResponse itemField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PMTCANCRS", typeof(PaymentCancelResponse), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("PMTMODRS", typeof(PaymentModResponse), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("PMTRS", typeof(PaymentResponse), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public AbstractPaymentResponse Item {
            get {
                return itemField;
            }
            set {
                itemField = value;
            }
        }
    }
}