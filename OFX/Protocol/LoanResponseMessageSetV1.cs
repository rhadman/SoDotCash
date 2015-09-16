namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class LoanResponseMessageSetV1 : AbstractResponseMessageSet {
        
        private AbstractResponse[] itemsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AMRTSTMTTRNRS", typeof(AmortizationTransactionResponse), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("LOANMAILSYNCRS", typeof(LoanMailSyncResponse), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("LOANMAILTRNRS", typeof(LoanMailTransactionResponse), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("LOANSTMTENDTRNRS", typeof(LoanStatementEndTransactionResponse), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("LOANSTMTTRNRS", typeof(LoanStatementTransactionResponse), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public AbstractResponse[] Items {
            get {
                return itemsField;
            }
            set {
                itemsField = value;
            }
        }
    }
}