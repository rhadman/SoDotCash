namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class InterTransactionRequest : AbstractTransactionRequest {
        
        private AbstractInterRequest itemField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("INTERCANRQ", typeof(InterCancellationRequest), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("INTERMODRQ", typeof(InterModRequest), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("INTERRQ", typeof(InterRequest), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public AbstractInterRequest Item {
            get {
                return itemField;
            }
            set {
                itemField = value;
            }
        }
    }
}