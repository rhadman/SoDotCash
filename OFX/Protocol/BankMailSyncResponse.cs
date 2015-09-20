namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class BankMailSyncResponse : AbstractSyncResponse {
        
        private AbstractAccount itemField;
        
        private BankMailTransactionResponse[] bANKMAILTRNRSField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BANKACCTFROM", typeof(BankAccount), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("CCACCTFROM", typeof(CreditCardAccount), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public AbstractAccount Item {
            get {
                return itemField;
            }
            set {
                itemField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BANKMAILTRNRS", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BankMailTransactionResponse[] BANKMAILTRNRS {
            get {
                return bANKMAILTRNRSField;
            }
            set {
                bANKMAILTRNRSField = value;
            }
        }
    }
}