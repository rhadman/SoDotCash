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
                return this.pMTNUMBERField;
            }
            set {
                this.pMTNUMBERField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string LOANINITBAL {
            get {
                return this.lOANINITBALField;
            }
            set {
                this.lOANINITBALField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PrincipalBalanceType PRINBAL {
            get {
                return this.pRINBALField;
            }
            set {
                this.pRINBALField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public LoanTransactionAmount LOANTRNAMT {
            get {
                return this.lOANTRNAMTField;
            }
            set {
                this.lOANTRNAMTField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public LoanRateType LOANIRATE {
            get {
                return this.lOANIRATEField;
            }
            set {
                this.lOANIRATEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public AmortizationType AMRTTYPE {
            get {
                return this.aMRTTYPEField;
            }
            set {
                this.aMRTTYPEField = value;
            }
        }
    }
}