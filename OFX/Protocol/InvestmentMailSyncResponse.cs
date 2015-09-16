namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class InvestmentMailSyncResponse : AbstractSyncResponse {
        
        private InvestmentAccount iNVACCTFROMField;
        
        private InvestmentMailTransactionResponse[] iNVMAILTRNRSField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public InvestmentAccount INVACCTFROM {
            get {
                return iNVACCTFROMField;
            }
            set {
                iNVACCTFROMField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("INVMAILTRNRS", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public InvestmentMailTransactionResponse[] INVMAILTRNRS {
            get {
                return iNVMAILTRNRSField;
            }
            set {
                iNVMAILTRNRSField = value;
            }
        }
    }
}