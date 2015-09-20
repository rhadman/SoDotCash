namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class PresentmentMailSyncResponse : AbstractSyncResponse {
        
        private PresentmentAccount pRESACCTFROMField;
        
        private PresentmentMailTransactionResponse[] pRESMAILTRNRSField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PresentmentAccount PRESACCTFROM {
            get {
                return pRESACCTFROMField;
            }
            set {
                pRESACCTFROMField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PRESMAILTRNRS", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PresentmentMailTransactionResponse[] PRESMAILTRNRS {
            get {
                return pRESMAILTRNRSField;
            }
            set {
                pRESMAILTRNRSField = value;
            }
        }
    }
}