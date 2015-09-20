namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class IntraTransactionResponse : AbstractTransactionResponse {
        
        private AbstractIntraResponse itemField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("INTRACANRS", typeof(IntraCancellationResponse), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("INTRAMODRS", typeof(IntraModResponse), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("INTRARS", typeof(IntraResponse), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public AbstractIntraResponse Item {
            get {
                return itemField;
            }
            set {
                itemField = value;
            }
        }
    }
}