namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class BillPayRequestMessageSetV1 : AbstractRequestMessageSet {
        
        private AbstractRequest[] itemsField;
        
        private AbstractRequest[] items1Field;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PAYEESYNCRQ", typeof(PayeeSyncRequest), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("PAYEETRNRQ", typeof(PayeeTransactionRequest), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public AbstractRequest[] Items {
            get {
                return itemsField;
            }
            set {
                itemsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PMTINQTRNRQ", typeof(PaymentInquiryTransactionRequest), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("PMTMAILSYNCRQ", typeof(PaymentMailSyncRequest), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("PMTMAILTRNRQ", typeof(PaymentMailTransactionRequest), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("PMTSYNCRQ", typeof(PaymentSyncRequest), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("PMTTRNRQ", typeof(PaymentTransactionRequest), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("RECPMTSYNCRQ", typeof(RecurringPaymentSyncRequest), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("RECPMTTRNRQ", typeof(RecurringPaymentTransactionRequest), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public AbstractRequest[] Items1 {
            get {
                return items1Field;
            }
            set {
                items1Field = value;
            }
        }
    }
}