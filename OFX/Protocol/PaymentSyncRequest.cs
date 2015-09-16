namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class PaymentSyncRequest : AbstractSyncRequest {
        
        private BankAccount bANKACCTFROMField;
        
        private PaymentTransactionRequest[] pMTTRNRQField;
        
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
        [System.Xml.Serialization.XmlElementAttribute("PMTTRNRQ", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PaymentTransactionRequest[] PMTTRNRQ {
            get {
                return pMTTRNRQField;
            }
            set {
                pMTTRNRQField = value;
            }
        }
    }
}