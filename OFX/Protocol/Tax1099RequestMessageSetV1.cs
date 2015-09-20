namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class Tax1099RequestMessageSetV1 : AbstractRequestMessageSet {
        
        private Tax1099TransactionRequest[] tAX1099TRNRQField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TAX1099TRNRQ", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Tax1099TransactionRequest[] TAX1099TRNRQ {
            get {
                return tAX1099TRNRQField;
            }
            set {
                tAX1099TRNRQField = value;
            }
        }
    }
}