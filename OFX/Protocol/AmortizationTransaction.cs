namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class AmortizationTransaction {
        
        private string pMTNUMBERField;
        
        private string lOANINITBALField;
        
        private PrincipalBalanceType pRINBALField;
        
        private LoanTransactionAmount lOANTRNAMTField;
        
        private LoanRateType lOANIRATEField;
        
        private AmortizationType aMRTTYPEField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string PMTNUMBER {
            get {
                return pMTNUMBERField;
            }
            set {
                pMTNUMBERField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string LOANINITBAL {
            get {
                return lOANINITBALField;
            }
            set {
                lOANINITBALField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PrincipalBalanceType PRINBAL {
            get {
                return pRINBALField;
            }
            set {
                pRINBALField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public LoanTransactionAmount LOANTRNAMT {
            get {
                return lOANTRNAMTField;
            }
            set {
                lOANTRNAMTField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public LoanRateType LOANIRATE {
            get {
                return lOANIRATEField;
            }
            set {
                lOANIRATEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public AmortizationType AMRTTYPE {
            get {
                return aMRTTYPEField;
            }
            set {
                aMRTTYPEField = value;
            }
        }
    }
}