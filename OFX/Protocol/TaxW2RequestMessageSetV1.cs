namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class TaxW2RequestMessageSetV1 : AbstractRequestMessageSet {
        
        private TaxW2TransactionRequest[] tAXW2TRNRQField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TAXW2TRNRQ", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public TaxW2TransactionRequest[] TAXW2TRNRQ {
            get {
                return tAXW2TRNRQField;
            }
            set {
                tAXW2TRNRQField = value;
            }
        }
    }
}