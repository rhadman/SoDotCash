namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class RecurringIntraTransactionResponse : AbstractTransactionResponse {
        
        private AbstractRecurringIntraResponse itemField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RECINTRACANRS", typeof(RecurringIntraCancellationResponse), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("RECINTRAMODRS", typeof(RecurringIntraModResponse), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("RECINTRARS", typeof(RecurringIntraResponse), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public AbstractRecurringIntraResponse Item {
            get {
                return itemField;
            }
            set {
                itemField = value;
            }
        }
    }
}