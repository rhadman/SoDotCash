namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class LoanTransactionAmount {
        
        private string pRINAMTField;
        
        private string iNTAMTField;
        
        private EscrowAmount eSCRWAMTField;
        
        private string iNSURANCEField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string PRINAMT {
            get {
                return pRINAMTField;
            }
            set {
                pRINAMTField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string INTAMT {
            get {
                return iNTAMTField;
            }
            set {
                iNTAMTField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public EscrowAmount ESCRWAMT {
            get {
                return eSCRWAMTField;
            }
            set {
                eSCRWAMTField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string INSURANCE {
            get {
                return iNSURANCEField;
            }
            set {
                iNSURANCEField = value;
            }
        }
    }
}