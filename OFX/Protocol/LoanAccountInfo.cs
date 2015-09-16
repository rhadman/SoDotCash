namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class LoanAccountInfo : AbstractAccountInfo {
        
        private LoanAccount lOANACCTFROMField;
        
        private LoanTypeEnum lOANTYPEField;
        
        private bool lOANTYPEFieldSpecified;
        
        private string lOANINITNUMPMTSField;
        
        private string lOANINITBALField;
        
        private LoanFrequencyEnum lOANFREQField;
        
        private string dTLOANSTARTField;
        
        private string dTLOANMATURITYField;
        
        private PrincipalBalanceType pRINBALField;
        
        private string bALLOONAMTField;
        
        private LoanInterestType lOANINTField;
        
        private LoanRateType lOANIRATEField;
        
        private LoanPaymentAmount lOANPMTField;
        
        private string lOANRMNPMTSField;
        
        private BooleanType sUPTXDLField;
        
        private BooleanType xFERSRCField;
        
        private BooleanType xFERDESTField;
        
        private ServiceStatusEnum sVCSTATUSField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public LoanAccount LOANACCTFROM {
            get {
                return this.lOANACCTFROMField;
            }
            set {
                this.lOANACCTFROMField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public LoanTypeEnum LOANTYPE {
            get {
                return this.lOANTYPEField;
            }
            set {
                this.lOANTYPEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LOANTYPESpecified {
            get {
                return this.lOANTYPEFieldSpecified;
            }
            set {
                this.lOANTYPEFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string LOANINITNUMPMTS {
            get {
                return this.lOANINITNUMPMTSField;
            }
            set {
                this.lOANINITNUMPMTSField = value;
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
        public LoanFrequencyEnum LOANFREQ {
            get {
                return this.lOANFREQField;
            }
            set {
                this.lOANFREQField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DTLOANSTART {
            get {
                return this.dTLOANSTARTField;
            }
            set {
                this.dTLOANSTARTField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DTLOANMATURITY {
            get {
                return this.dTLOANMATURITYField;
            }
            set {
                this.dTLOANMATURITYField = value;
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
        public string BALLOONAMT {
            get {
                return this.bALLOONAMTField;
            }
            set {
                this.bALLOONAMTField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public LoanInterestType LOANINT {
            get {
                return this.lOANINTField;
            }
            set {
                this.lOANINTField = value;
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
        public LoanPaymentAmount LOANPMT {
            get {
                return this.lOANPMTField;
            }
            set {
                this.lOANPMTField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string LOANRMNPMTS {
            get {
                return this.lOANRMNPMTSField;
            }
            set {
                this.lOANRMNPMTSField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType SUPTXDL {
            get {
                return this.sUPTXDLField;
            }
            set {
                this.sUPTXDLField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType XFERSRC {
            get {
                return this.xFERSRCField;
            }
            set {
                this.xFERSRCField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType XFERDEST {
            get {
                return this.xFERDESTField;
            }
            set {
                this.xFERDESTField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ServiceStatusEnum SVCSTATUS {
            get {
                return this.sVCSTATUSField;
            }
            set {
                this.sVCSTATUSField = value;
            }
        }
    }
}