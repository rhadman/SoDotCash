namespace OFX.Protocol
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WireTransactionRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EnrollTransactionRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ChangeUserInfoTransactionRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AccountTransactionRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AccountInfoTransactionRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MFAChallengeTransactionRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PinChangeTransactionRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ChallengeTransactionRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SecurityListTransactionRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ProfileTransactionRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ImageTransactionRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LoanMailTransactionRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LoanStatementEndTransactionRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AmortizationTransactionRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LoanStatementTransactionRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(InvestmentStatementEndTransactionRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(InvestmentStatementTransactionRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(InvestmentMailTransactionRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RecurringInterTransactionRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(InterTransactionRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MailTransactionRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(GetMimeTransactionRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CreditCardStatementTransactionRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CreditCardStatementEndTransactionRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FindBillerTransactionRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PresentmentNotifyTransactionRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PresentmentMailTransactionRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PresentmentListTransactionRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PresentmentGroupAccountInfoTransactionRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PresentmentDetailTransactionRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BillTableStructureTransactionRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BillStatusModTransactionRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RecurringPaymentTransactionRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PaymentTransactionRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PaymentMailTransactionRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PaymentInquiryTransactionRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PayeeTransactionRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RecurringIntraTransactionRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(StatementEndTransactionRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(StatementTransactionRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(StopCheckTransactionRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IntraTransactionRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BankMailTransactionRequest))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public abstract partial class AbstractTransactionRequest : AbstractRequest {
        
        private string tRNUIDField;
        
        private string cLTCOOKIEField;
        
        private string tANField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string TRNUID {
            get {
                return tRNUIDField;
            }
            set {
                tRNUIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string CLTCOOKIE {
            get {
                return cLTCOOKIEField;
            }
            set {
                cLTCOOKIEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string TAN {
            get {
                return tANField;
            }
            set {
                tANField = value;
            }
        }
    }
}