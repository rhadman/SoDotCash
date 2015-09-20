namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class PayeeTransactionRequest : AbstractTransactionRequest {
        
        private AbstractPayeeRequest itemField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PAYEEDELRQ", typeof(PayeeDeleteRequest), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("PAYEEMODRQ", typeof(PayeeModRequest), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("PAYEERQ", typeof(PayeeRequest), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public AbstractPayeeRequest Item {
            get {
                return itemField;
            }
            set {
                itemField = value;
            }
        }
    }
}