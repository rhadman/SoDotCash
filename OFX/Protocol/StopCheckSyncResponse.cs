namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class StopCheckSyncResponse : AbstractSyncResponse {
        
        private BankAccount bANKACCTFROMField;
        
        private StopCheckTransactionResponse[] sTPCHKTRNRSField;
        
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
        [System.Xml.Serialization.XmlElementAttribute("STPCHKTRNRS", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public StopCheckTransactionResponse[] STPCHKTRNRS {
            get {
                return sTPCHKTRNRSField;
            }
            set {
                sTPCHKTRNRSField = value;
            }
        }
    }
}