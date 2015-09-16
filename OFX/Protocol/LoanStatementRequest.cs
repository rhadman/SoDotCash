namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class LoanStatementRequest {
        
        private LoanAccount lOANACCTFROMField;
        
        private IncTransaction iNCTRANField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public LoanAccount LOANACCTFROM {
            get {
                return lOANACCTFROMField;
            }
            set {
                lOANACCTFROMField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public IncTransaction INCTRAN {
            get {
                return iNCTRANField;
            }
            set {
                iNCTRANField = value;
            }
        }
    }
}