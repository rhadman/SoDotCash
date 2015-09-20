namespace OFX.Protocol
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SignonMessageSetV1))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ProfileMessageSetV1))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Tax1098MessageSetV1))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TaxW2MessageSetV1))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Tax1099MessageSetV1))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PresentmentDlvMessageSetV1))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SecurityListMessageSetV1))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PresentmentDirMessageSetV1))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EmailMessageSetV1))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BillPayMessageSetV1))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WireTransferMessageSetV1))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(InterTransferMessageSetV1))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(InvestmentStatementMessageSetV1))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ImageMessageSetV1))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LoanMessageSetV1))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CreditcardMessageSetV1))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BankMessageSetV1))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SignupMessageSetV1))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public abstract partial class AbstractMessageSetVersion {
        
        private MessageSetCore mSGSETCOREField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public MessageSetCore MSGSETCORE {
            get {
                return mSGSETCOREField;
            }
            set {
                mSGSETCOREField = value;
            }
        }
    }
}