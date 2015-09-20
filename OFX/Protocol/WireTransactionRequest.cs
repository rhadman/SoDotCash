namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class WireTransactionRequest : AbstractTransactionRequest {
        
        private AbstractWireRequest itemField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("WIRECANRQ", typeof(WireCancellationRequest), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("WIRERQ", typeof(WireRequest), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public AbstractWireRequest Item {
            get {
                return itemField;
            }
            set {
                itemField = value;
            }
        }
    }
}