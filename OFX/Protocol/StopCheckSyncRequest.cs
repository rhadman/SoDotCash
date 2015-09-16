namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class StopCheckSyncRequest : AbstractSyncRequest {
        
        private BankAccount bANKACCTFROMField;
        
        private StopCheckTransactionRequest[] sTPCHKTRNRQField;
        
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
        [System.Xml.Serialization.XmlElementAttribute("STPCHKTRNRQ", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public StopCheckTransactionRequest[] STPCHKTRNRQ {
            get {
                return sTPCHKTRNRQField;
            }
            set {
                sTPCHKTRNRQField = value;
            }
        }
    }
}