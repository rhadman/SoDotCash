namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class InvestmentBankTransaction {
        
        private StatementTransaction sTMTTRNField;
        
        private SubAccountEnum sUBACCTFUNDField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public StatementTransaction STMTTRN {
            get {
                return this.sTMTTRNField;
            }
            set {
                this.sTMTTRNField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SubAccountEnum SUBACCTFUND {
            get {
                return this.sUBACCTFUNDField;
            }
            set {
                this.sUBACCTFUNDField = value;
            }
        }
    }
}