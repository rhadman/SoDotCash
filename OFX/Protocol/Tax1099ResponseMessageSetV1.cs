namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class Tax1099ResponseMessageSetV1 : AbstractResponseMessageSet {
        
        private Tax1099TransactionResponse[] tAX1099TRNRSField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TAX1099TRNRS", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Tax1099TransactionResponse[] TAX1099TRNRS {
            get {
                return tAX1099TRNRSField;
            }
            set {
                tAX1099TRNRSField = value;
            }
        }
    }
}