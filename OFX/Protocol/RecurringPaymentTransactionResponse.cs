namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class RecurringPaymentTransactionResponse : AbstractTransactionResponse {
        
        private AbstractRecurringPaymentResponse itemField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RECPMTCANCRS", typeof(RecurringPaymentCancelResponse), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("RECPMTMODRS", typeof(RecurringPaymentModResponse), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("RECPMTRS", typeof(RecurringPaymentResponse), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public AbstractRecurringPaymentResponse Item {
            get {
                return itemField;
            }
            set {
                itemField = value;
            }
        }
    }
}