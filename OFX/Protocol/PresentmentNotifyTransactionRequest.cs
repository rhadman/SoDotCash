namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class PresentmentNotifyTransactionRequest : AbstractTransactionRequest {
        
        private PresentmentNotifyRequest pRESNOTIFYRQField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PresentmentNotifyRequest PRESNOTIFYRQ {
            get {
                return pRESNOTIFYRQField;
            }
            set {
                pRESNOTIFYRQField = value;
            }
        }
    }
}