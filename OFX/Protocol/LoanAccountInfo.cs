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
                return lOANACCTFROMField;
            }
            set {
                lOANACCTFROMField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public LoanTypeEnum LOANTYPE {
            get {
                return lOANTYPEField;
            }
            set {
                lOANTYPEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LOANTYPESpecified {
            get {
                return lOANTYPEFieldSpecified;
            }
            set {
                lOANTYPEFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string LOANINITNUMPMTS {
            get {
                return lOANINITNUMPMTSField;
            }
            set {
                lOANINITNUMPMTSField = value;
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
        public LoanFrequencyEnum LOANFREQ {
            get {
                return lOANFREQField;
            }
            set {
                lOANFREQField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DTLOANSTART {
            get {
                return dTLOANSTARTField;
            }
            set {
                dTLOANSTARTField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DTLOANMATURITY {
            get {
                return dTLOANMATURITYField;
            }
            set {
                dTLOANMATURITYField = value;
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
        public string BALLOONAMT {
            get {
                return bALLOONAMTField;
            }
            set {
                bALLOONAMTField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public LoanInterestType LOANINT {
            get {
                return lOANINTField;
            }
            set {
                lOANINTField = value;
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
        public LoanPaymentAmount LOANPMT {
            get {
                return lOANPMTField;
            }
            set {
                lOANPMTField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string LOANRMNPMTS {
            get {
                return lOANRMNPMTSField;
            }
            set {
                lOANRMNPMTSField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType SUPTXDL {
            get {
                return sUPTXDLField;
            }
            set {
                sUPTXDLField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType XFERSRC {
            get {
                return xFERSRCField;
            }
            set {
                xFERSRCField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType XFERDEST {
            get {
                return xFERDESTField;
            }
            set {
                xFERDESTField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ServiceStatusEnum SVCSTATUS {
            get {
                return sVCSTATUSField;
            }
            set {
                sVCSTATUSField = value;
            }
        }
    }
}