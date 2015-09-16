namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class BillPayMessageSetV1 : AbstractMessageSetVersion {
        
        private string dAYSWITHField;
        
        private string dFLTDAYSTOPAYField;
        
        private string xFERDAYSWITHField;
        
        private string xFERDFLTDAYSTOPAYField;
        
        private DaysEnum[] pROCDAYSOFFField;
        
        private string pROCENDTMField;
        
        private string mODELWNDField;
        
        private string pOSTPROCWNDField;
        
        private BooleanType sTSVIAMODSField;
        
        private BooleanType pMTBYADDRField;
        
        private BooleanType pMTBYXFERField;
        
        private BooleanType pMTBYPAYEEIDField;
        
        private BooleanType cANADDPAYEEField;
        
        private BooleanType hASEXTDPMTField;
        
        private BooleanType cANMODPMTSField;
        
        private BooleanType cANMODMDLSField;
        
        private BooleanType dIFFFIRSTPMTField;
        
        private BooleanType dIFFLASTPMTField;
        
        private BooleanType bILLPUBCONTEXTField;
        
        private bool bILLPUBCONTEXTFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DAYSWITH {
            get {
                return this.dAYSWITHField;
            }
            set {
                this.dAYSWITHField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DFLTDAYSTOPAY {
            get {
                return this.dFLTDAYSTOPAYField;
            }
            set {
                this.dFLTDAYSTOPAYField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string XFERDAYSWITH {
            get {
                return this.xFERDAYSWITHField;
            }
            set {
                this.xFERDAYSWITHField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string XFERDFLTDAYSTOPAY {
            get {
                return this.xFERDFLTDAYSTOPAYField;
            }
            set {
                this.xFERDFLTDAYSTOPAYField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PROCDAYSOFF", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public DaysEnum[] PROCDAYSOFF {
            get {
                return this.pROCDAYSOFFField;
            }
            set {
                this.pROCDAYSOFFField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string PROCENDTM {
            get {
                return this.pROCENDTMField;
            }
            set {
                this.pROCENDTMField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string MODELWND {
            get {
                return this.mODELWNDField;
            }
            set {
                this.mODELWNDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string POSTPROCWND {
            get {
                return this.pOSTPROCWNDField;
            }
            set {
                this.pOSTPROCWNDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType STSVIAMODS {
            get {
                return this.sTSVIAMODSField;
            }
            set {
                this.sTSVIAMODSField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType PMTBYADDR {
            get {
                return this.pMTBYADDRField;
            }
            set {
                this.pMTBYADDRField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType PMTBYXFER {
            get {
                return this.pMTBYXFERField;
            }
            set {
                this.pMTBYXFERField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType PMTBYPAYEEID {
            get {
                return this.pMTBYPAYEEIDField;
            }
            set {
                this.pMTBYPAYEEIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType CANADDPAYEE {
            get {
                return this.cANADDPAYEEField;
            }
            set {
                this.cANADDPAYEEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType HASEXTDPMT {
            get {
                return this.hASEXTDPMTField;
            }
            set {
                this.hASEXTDPMTField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType CANMODPMTS {
            get {
                return this.cANMODPMTSField;
            }
            set {
                this.cANMODPMTSField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType CANMODMDLS {
            get {
                return this.cANMODMDLSField;
            }
            set {
                this.cANMODMDLSField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType DIFFFIRSTPMT {
            get {
                return this.dIFFFIRSTPMTField;
            }
            set {
                this.dIFFFIRSTPMTField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType DIFFLASTPMT {
            get {
                return this.dIFFLASTPMTField;
            }
            set {
                this.dIFFLASTPMTField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType BILLPUBCONTEXT {
            get {
                return this.bILLPUBCONTEXTField;
            }
            set {
                this.bILLPUBCONTEXTField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BILLPUBCONTEXTSpecified {
            get {
                return this.bILLPUBCONTEXTFieldSpecified;
            }
            set {
                this.bILLPUBCONTEXTFieldSpecified = value;
            }
        }
    }
}