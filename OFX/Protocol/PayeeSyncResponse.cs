namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class PayeeSyncResponse : AbstractSyncResponse {
        
        private PayeeTransactionResponse[] pAYEETRNRSField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PAYEETRNRS", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PayeeTransactionResponse[] PAYEETRNRS {
            get {
                return pAYEETRNRSField;
            }
            set {
                pAYEETRNRSField = value;
            }
        }
    }
}