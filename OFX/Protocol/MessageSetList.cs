namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class MessageSetList {
        
        private AbstractMessageSet[] itemsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BANKMSGSET", typeof(BankMessageSet), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("BILLPAYMSGSET", typeof(BillPayMessageSet), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("CREDITCARDMSGSET", typeof(CreditcardMessageSet), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("EMAILMSGSET", typeof(EmailMessageSet), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("IMAGEMSGSET", typeof(ImageMessageSet), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("INTERXFERMSGSET", typeof(InterTransferMessageSet), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("INVSTMTMSGSET", typeof(InvestmentStatementMessageSet), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("LOANMSGSET", typeof(LoanMessageSet), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("PRESDIRMSGSET", typeof(PresentmentDirMessageSet), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("PRESDLVMSGSET", typeof(PresentmentDlvMessageSet), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("PROFMSGSET", typeof(ProfileMessageSet), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("SECLISTMSGSET", typeof(SecurityListMessageSet), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("SIGNONMSGSET", typeof(SignonMessageSet), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("SIGNUPMSGSET", typeof(SignupMessageSet), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("TAX1098MSGSET", typeof(Tax1098MessageSet), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("TAX1099MSGSET", typeof(Tax1099MessageSet), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("TAXW2MSGSET", typeof(TaxW2MessageSet), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("WIREXFERMSGSET", typeof(WireTransferMessageSet), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public AbstractMessageSet[] Items {
            get {
                return itemsField;
            }
            set {
                itemsField = value;
            }
        }
    }
}