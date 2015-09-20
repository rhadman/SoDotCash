namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class PresentmentDetailTransactionRequest : AbstractTransactionRequest {
        
        private PresentmentDetailRequest pRESDETAILRQField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PresentmentDetailRequest PRESDETAILRQ {
            get {
                return pRESDETAILRQField;
            }
            set {
                pRESDETAILRQField = value;
            }
        }
    }
}