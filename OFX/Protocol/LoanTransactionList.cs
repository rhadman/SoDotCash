namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class LoanTransactionList {
        
        private string dTSTARTField;
        
        private string dTENDField;
        
        private LoanStatementTransaction[] lOANSTMTTRNField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DTSTART {
            get {
                return dTSTARTField;
            }
            set {
                dTSTARTField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DTEND {
            get {
                return dTENDField;
            }
            set {
                dTENDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("LOANSTMTTRN", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public LoanStatementTransaction[] LOANSTMTTRN {
            get {
                return lOANSTMTTRNField;
            }
            set {
                lOANSTMTTRNField = value;
            }
        }
    }
}