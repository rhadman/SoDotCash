namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class BillPayResponseMessageSetV1 : AbstractResponseMessageSet {
        
        private AbstractResponse[] itemsField;
        
        private AbstractResponse[] items1Field;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PAYEESYNCRS", typeof(PayeeSyncResponse), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("PAYEETRNRS", typeof(PayeeTransactionResponse), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public AbstractResponse[] Items {
            get {
                return itemsField;
            }
            set {
                itemsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PMTINQTRNRS", typeof(PaymentInquiryTransactionResponse), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("PMTMAILSYNCRS", typeof(PaymentMailSyncResponse), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("PMTMAILTRNRS", typeof(PaymentMailTransactionResponse), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("PMTSYNCRS", typeof(PaymentSyncResponse), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("PMTTRNRS", typeof(PaymentTransactionResponse), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("RECPMTSYNCRS", typeof(RecurringPaymentSyncResponse), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("RECPMTTRNRS", typeof(RecurringPaymentTransactionResponse), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public AbstractResponse[] Items1 {
            get {
                return items1Field;
            }
            set {
                items1Field = value;
            }
        }
    }
}