namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class WireTransactionResponse : AbstractTransactionResponse {
        
        private AbstractWireResponse itemField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("WIRECANRS", typeof(WireCancellationResponse), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("WIRERS", typeof(WireResponse), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public AbstractWireResponse Item {
            get {
                return itemField;
            }
            set {
                itemField = value;
            }
        }
    }
}