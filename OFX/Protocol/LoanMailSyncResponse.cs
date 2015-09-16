namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class LoanMailSyncResponse : AbstractSyncResponse {
        
        private LoanAccount itemField;
        
        private LoanMailTransactionResponse[] lOANMAILTRNRSField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("LOANACCTFROM", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public LoanAccount Item {
            get {
                return itemField;
            }
            set {
                itemField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("LOANMAILTRNRS", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public LoanMailTransactionResponse[] LOANMAILTRNRS {
            get {
                return lOANMAILTRNRSField;
            }
            set {
                lOANMAILTRNRSField = value;
            }
        }
    }
}