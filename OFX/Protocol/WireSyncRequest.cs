namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class WireSyncRequest : AbstractSyncRequest {
        
        private BankAccount bANKACCTFROMField;
        
        private WireTransactionRequest[] wIRETRNRQField;
        
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
        [System.Xml.Serialization.XmlElementAttribute("WIRETRNRQ", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public WireTransactionRequest[] WIRETRNRQ {
            get {
                return wIRETRNRQField;
            }
            set {
                wIRETRNRQField = value;
            }
        }
    }
}