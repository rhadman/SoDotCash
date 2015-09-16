namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class LoanAccount : AbstractAccount {
        
        private string lOANACCTIDField;
        
        private LoanAccountEnum lOANACCTTYPEField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string LOANACCTID {
            get {
                return this.lOANACCTIDField;
            }
            set {
                this.lOANACCTIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public LoanAccountEnum LOANACCTTYPE {
            get {
                return this.lOANACCTTYPEField;
            }
            set {
                this.lOANACCTTYPEField = value;
            }
        }
    }
}