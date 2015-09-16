namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class LoanStatementEndTransactionRequest : AbstractTransactionRequest {
        
        private LoanStatementEndRequest lOANSTMTENDRQField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public LoanStatementEndRequest LOANSTMTENDRQ {
            get {
                return lOANSTMTENDRQField;
            }
            set {
                lOANSTMTENDRQField = value;
            }
        }
    }
}