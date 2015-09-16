namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class BankMailTransactionResponse : AbstractTransactionResponse {
        
        private AbstractMailResponse itemField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BANKMAILRS", typeof(BankMailResponse), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("CHKMAILRS", typeof(CheckMailResponse), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("DEPMAILRS", typeof(DepositMailResponse), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public AbstractMailResponse Item {
            get {
                return itemField;
            }
            set {
                itemField = value;
            }
        }
    }
}