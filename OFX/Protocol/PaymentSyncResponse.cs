namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class PaymentSyncResponse : AbstractSyncResponse {
        
        private BankAccount bANKACCTFROMField;
        
        private PaymentTransactionResponse[] pMTTRNRSField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BankAccount BANKACCTFROM {
            get {
                return this.bANKACCTFROMField;
            }
            set {
                this.bANKACCTFROMField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PMTTRNRS", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PaymentTransactionResponse[] PMTTRNRS {
            get {
                return this.pMTTRNRSField;
            }
            set {
                this.pMTTRNRSField = value;
            }
        }
    }
}