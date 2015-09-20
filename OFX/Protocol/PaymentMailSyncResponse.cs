namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class PaymentMailSyncResponse : AbstractSyncResponse {
        
        private PaymentMailTransactionResponse[] pMTMAILTRNRSField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PMTMAILTRNRS", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PaymentMailTransactionResponse[] PMTMAILTRNRS {
            get {
                return pMTMAILTRNRSField;
            }
            set {
                pMTMAILTRNRSField = value;
            }
        }
    }
}