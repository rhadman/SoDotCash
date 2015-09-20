namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class PayeeTransactionResponse : AbstractTransactionResponse {
        
        private AbstractPayeeResponse itemField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PAYEEDELRS", typeof(PayeeDeleteResponse), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("PAYEEMODRS", typeof(PayeeModResponse), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("PAYEERS", typeof(PayeeResponse), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public AbstractPayeeResponse Item {
            get {
                return itemField;
            }
            set {
                itemField = value;
            }
        }
    }
}