namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class PayeeSyncRequest : AbstractSyncRequest {
        
        private PayeeTransactionRequest[] pAYEETRNRQField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PAYEETRNRQ", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PayeeTransactionRequest[] PAYEETRNRQ {
            get {
                return pAYEETRNRQField;
            }
            set {
                pAYEETRNRQField = value;
            }
        }
    }
}