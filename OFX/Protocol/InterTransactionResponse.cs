namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class InterTransactionResponse : AbstractTransactionResponse {
        
        private AbstractInterResponse itemField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("INTERCANRS", typeof(InterCancellationResponse), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("INTERMODRS", typeof(InterModResponse), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("INTERRS", typeof(InterResponse), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public AbstractInterResponse Item {
            get {
                return itemField;
            }
            set {
                itemField = value;
            }
        }
    }
}