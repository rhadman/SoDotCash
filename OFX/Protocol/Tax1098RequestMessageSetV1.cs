namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class Tax1098RequestMessageSetV1 : AbstractRequestMessageSet {
        
        private Tax1098TransactionRequest[] tAX1098TRNRQField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TAX1098TRNRQ", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Tax1098TransactionRequest[] TAX1098TRNRQ {
            get {
                return tAX1098TRNRQField;
            }
            set {
                tAX1098TRNRQField = value;
            }
        }
    }
}