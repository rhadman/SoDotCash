namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class TaxW2ResponseMessageSetV1 : AbstractResponseMessageSet {
        
        private TaxW2TransactionResponse[] tAXW2TRNRSField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TAXW2TRNRS", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public TaxW2TransactionResponse[] TAXW2TRNRS {
            get {
                return tAXW2TRNRSField;
            }
            set {
                tAXW2TRNRSField = value;
            }
        }
    }
}