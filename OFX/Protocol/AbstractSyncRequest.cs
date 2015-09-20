namespace OFX.Protocol
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WireSyncRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ChangeUserInfoSyncRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AccountSyncRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LoanMailSyncRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(InvestmentMailSyncRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RecurringInterSyncRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(InterSyncRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MailSyncRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PresentmentMailSyncRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PaymentMailSyncRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RecurringPaymentSyncRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PaymentSyncRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PayeeSyncRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BankMailSyncRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RecurringIntraSyncRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(StopCheckSyncRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IntraSyncRequest))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public abstract partial class AbstractSyncRequest : AbstractRequest {
        
        private object itemField;
        
        private ItemChoiceType itemElementNameField;
        
        private BooleanType rEJECTIFMISSINGField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("REFRESH", typeof(BooleanType), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("TOKEN", typeof(string), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("TOKENONLY", typeof(BooleanType), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public object Item {
            get {
                return itemField;
            }
            set {
                itemField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType ItemElementName {
            get {
                return itemElementNameField;
            }
            set {
                itemElementNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType REJECTIFMISSING {
            get {
                return rEJECTIFMISSINGField;
            }
            set {
                rEJECTIFMISSINGField = value;
            }
        }
    }
}