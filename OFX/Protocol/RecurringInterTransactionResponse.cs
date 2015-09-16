namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class RecurringInterTransactionResponse : AbstractTransactionResponse {
        
        private AbstractRecurringInterResponse itemField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RECINTERCANRS", typeof(RecurringInterCancellationResponse), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("RECINTERMODRS", typeof(RecurringInterModResponse), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("RECINTERRS", typeof(RecurringInterResponse), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public AbstractRecurringInterResponse Item {
            get {
                return itemField;
            }
            set {
                itemField = value;
            }
        }
    }
}