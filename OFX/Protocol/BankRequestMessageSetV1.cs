namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class BankRequestMessageSetV1 : AbstractRequestMessageSet {
        
        private AbstractRequest[] itemsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BANKMAILSYNCRQ", typeof(BankMailSyncRequest), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("BANKMAILTRNRQ", typeof(BankMailTransactionRequest), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("INTRASYNCRQ", typeof(IntraSyncRequest), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("INTRATRNRQ", typeof(IntraTransactionRequest), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("RECINTRASYNCRQ", typeof(RecurringIntraSyncRequest), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("RECINTRATRNRQ", typeof(RecurringIntraTransactionRequest), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("STMTENDTRNRQ", typeof(StatementEndTransactionRequest), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("STMTTRNRQ", typeof(StatementTransactionRequest), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("STPCHKSYNCRQ", typeof(StopCheckSyncRequest), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("STPCHKTRNRQ", typeof(StopCheckTransactionRequest), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public AbstractRequest[] Items {
            get {
                return itemsField;
            }
            set {
                itemsField = value;
            }
        }
    }
}