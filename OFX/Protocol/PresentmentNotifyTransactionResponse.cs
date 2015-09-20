namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class PresentmentNotifyTransactionResponse : AbstractTransactionResponse {
        
        private PresentmentNotifyResponse pRESNOTIFYRSField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PresentmentNotifyResponse PRESNOTIFYRS {
            get {
                return pRESNOTIFYRSField;
            }
            set {
                pRESNOTIFYRSField = value;
            }
        }
    }
}