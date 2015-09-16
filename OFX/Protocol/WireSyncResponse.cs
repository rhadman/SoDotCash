namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class WireSyncResponse : AbstractSyncResponse {
        
        private BankAccount bANKACCTFROMField;
        
        private WireTransactionResponse[] wIRETRNRSField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BankAccount BANKACCTFROM {
            get {
                return bANKACCTFROMField;
            }
            set {
                bANKACCTFROMField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("WIRETRNRS", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public WireTransactionResponse[] WIRETRNRS {
            get {
                return wIRETRNRSField;
            }
            set {
                wIRETRNRSField = value;
            }
        }
    }
}