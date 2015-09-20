namespace OFX.Protocol
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WireSyncResponse))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ChangeUserInfoSyncResponse))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AccountSyncResponse))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LoanMailSyncResponse))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(InvestmentMailSyncResponse))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RecurringInterSyncResponse))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(InterSyncResponse))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MailSyncResponse))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PresentmentMailSyncResponse))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PaymentMailSyncResponse))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RecurringPaymentSyncResponse))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PaymentSyncResponse))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PayeeSyncResponse))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BankMailSyncResponse))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RecurringIntraSyncResponse))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(StopCheckSyncResponse))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IntraSyncResponse))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public abstract partial class AbstractSyncResponse : AbstractResponse {
        
        private string tOKENField;
        
        private BooleanType lOSTSYNCField;
        
        private bool lOSTSYNCFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string TOKEN {
            get {
                return tOKENField;
            }
            set {
                tOKENField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType LOSTSYNC {
            get {
                return lOSTSYNCField;
            }
            set {
                lOSTSYNCField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LOSTSYNCSpecified {
            get {
                return lOSTSYNCFieldSpecified;
            }
            set {
                lOSTSYNCFieldSpecified = value;
            }
        }
    }
}