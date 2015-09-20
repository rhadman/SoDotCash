namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class Tax1098ResponseMessageSetV1 : AbstractResponseMessageSet {
        
        private Tax1098TransactionResponse[] tAX1098TRNRSField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TAX1098TRNRS", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Tax1098TransactionResponse[] TAX1098TRNRS {
            get {
                return tAX1098TRNRSField;
            }
            set {
                tAX1098TRNRSField = value;
            }
        }
    }
}