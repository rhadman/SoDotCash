namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class PresentmentDirResponseMessageSetV1 : AbstractResponseMessageSet {
        
        private FindBillerTransactionResponse fINDBILLERTRNRSField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public FindBillerTransactionResponse FINDBILLERTRNRS {
            get {
                return fINDBILLERTRNRSField;
            }
            set {
                fINDBILLERTRNRSField = value;
            }
        }
    }
}