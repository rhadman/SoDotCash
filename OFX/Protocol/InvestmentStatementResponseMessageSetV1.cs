namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class InvestmentStatementResponseMessageSetV1 : AbstractResponseMessageSet {
        
        private AbstractResponse[] itemsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("INVMAILSYNCRS", typeof(InvestmentMailSyncResponse), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("INVMAILTRNRS", typeof(InvestmentMailTransactionResponse), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("INVSTMTENDTRNRS", typeof(InvestmentStatementEndTransactionResponse), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("INVSTMTTRNRS", typeof(InvestmentStatementTransactionResponse), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
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