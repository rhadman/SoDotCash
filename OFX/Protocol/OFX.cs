namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    [System.Xml.Serialization.XmlRootAttribute( IsNullable=false)]
    public partial class OFX {
        
        private AbstractTopLevelMessageSet[] itemsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BANKMSGSRQV1", typeof(BankRequestMessageSetV1), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("BANKMSGSRSV1", typeof(BankResponseMessageSetV1), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("BILLPAYMSGSRQV1", typeof(BillPayRequestMessageSetV1), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("BILLPAYMSGSRSV1", typeof(BillPayResponseMessageSetV1), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("CREDITCARDMSGSRQV1", typeof(CreditcardRequestMessageSetV1), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("CREDITCARDMSGSRSV1", typeof(CreditcardResponseMessageSetV1), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("EMAILMSGSRQV1", typeof(EmailRequestMessageSetV1), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("EMAILMSGSRSV1", typeof(EmailResponseMessageSetV1), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("IMAGEMSGSRQV1", typeof(ImageRequestMessageSetV1), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("INTERXFERMSGSRQV1", typeof(InterTransferRequestMessageSetV1), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("INTERXFERMSGSRSV1", typeof(InterTransferResponseMessageSetV1), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("INVSTMTMSGSRQV1", typeof(InvestmentStatementRequestMessageSetV1), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("INVSTMTMSGSRSV1", typeof(InvestmentStatementResponseMessageSetV1), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("LOANMSGSRQV1", typeof(LoanRequestMessageSetV1), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("LOANMSGSRSV1", typeof(LoanResponseMessageSetV1), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("PRESDIRMSGSRQV1", typeof(PresentmentDirRequestMessageSetV1), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("PRESDIRMSGSRSV1", typeof(PresentmentDirResponseMessageSetV1), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("PRESDLVMSGSRQV1", typeof(PresentmentDeliveryRequestMessageSetV1), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("PRESDLVMSGSRSV1", typeof(PresentmentDeliveryResponseMessageSetV1), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("PROFMSGSRQV1", typeof(ProfileRequestMessageSetV1), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("PROFMSGSRSV1", typeof(ProfileResponseMessageSetV1), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("SECLISTMSGSRQV1", typeof(SecurityListRequestMessageSetV1), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("SECLISTMSGSRSV1", typeof(SecurityListResponseMessageSetV1), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("SIGNONMSGSRQV1", typeof(SignonRequestMessageSetV1), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("SIGNONMSGSRSV1", typeof(SignonResponseMessageSetV1), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("SIGNUPMSGSRQV1", typeof(SignupRequestMessageSetV1), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("SIGNUPMSGSRSV1", typeof(SignupResponseMessageSetV1), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("TAX1098MSGSRQV1", typeof(Tax1098RequestMessageSetV1), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("TAX1098MSGSRSV1", typeof(Tax1098ResponseMessageSetV1), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("TAX1099MSGSRQV1", typeof(Tax1099RequestMessageSetV1), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("TAX1099MSGSRSV1", typeof(Tax1099ResponseMessageSetV1), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("TAXW2MSGSRQV1", typeof(TaxW2RequestMessageSetV1), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("TAXW2MSGSRSV1", typeof(TaxW2ResponseMessageSetV1), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("WIREXFERMSGSRQV1", typeof(WireTransferRequestMessageSetV1), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("WIREXFERMSGSRSV1", typeof(WireTransferResponseMessageSetV1), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public AbstractTopLevelMessageSet[] Items {
            get {
                return itemsField;
            }
            set {
                itemsField = value;
            }
        }
    }
}