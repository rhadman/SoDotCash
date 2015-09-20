namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class IntraTransactionRequest : AbstractTransactionRequest {
        
        private AbstractIntraRequest itemField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("INTRACANRQ", typeof(IntraCancellationRequest), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("INTRAMODRQ", typeof(IntraModRequest), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("INTRARQ", typeof(IntraRequest), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public AbstractIntraRequest Item {
            get {
                return itemField;
            }
            set {
                itemField = value;
            }
        }
    }
}