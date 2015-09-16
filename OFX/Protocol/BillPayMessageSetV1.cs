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
                return dAYSWITHField;
            }
            set {
                dAYSWITHField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DFLTDAYSTOPAY {
            get {
                return dFLTDAYSTOPAYField;
            }
            set {
                dFLTDAYSTOPAYField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string XFERDAYSWITH {
            get {
                return xFERDAYSWITHField;
            }
            set {
                xFERDAYSWITHField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string XFERDFLTDAYSTOPAY {
            get {
                return xFERDFLTDAYSTOPAYField;
            }
            set {
                xFERDFLTDAYSTOPAYField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PROCDAYSOFF", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public DaysEnum[] PROCDAYSOFF {
            get {
                return pROCDAYSOFFField;
            }
            set {
                pROCDAYSOFFField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string PROCENDTM {
            get {
                return pROCENDTMField;
            }
            set {
                pROCENDTMField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string MODELWND {
            get {
                return mODELWNDField;
            }
            set {
                mODELWNDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string POSTPROCWND {
            get {
                return pOSTPROCWNDField;
            }
            set {
                pOSTPROCWNDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType STSVIAMODS {
            get {
                return sTSVIAMODSField;
            }
            set {
                sTSVIAMODSField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType PMTBYADDR {
            get {
                return pMTBYADDRField;
            }
            set {
                pMTBYADDRField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType PMTBYXFER {
            get {
                return pMTBYXFERField;
            }
            set {
                pMTBYXFERField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType PMTBYPAYEEID {
            get {
                return pMTBYPAYEEIDField;
            }
            set {
                pMTBYPAYEEIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType CANADDPAYEE {
            get {
                return cANADDPAYEEField;
            }
            set {
                cANADDPAYEEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType HASEXTDPMT {
            get {
                return hASEXTDPMTField;
            }
            set {
                hASEXTDPMTField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType CANMODPMTS {
            get {
                return cANMODPMTSField;
            }
            set {
                cANMODPMTSField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType CANMODMDLS {
            get {
                return cANMODMDLSField;
            }
            set {
                cANMODMDLSField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType DIFFFIRSTPMT {
            get {
                return dIFFFIRSTPMTField;
            }
            set {
                dIFFFIRSTPMTField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType DIFFLASTPMT {
            get {
                return dIFFLASTPMTField;
            }
            set {
                dIFFLASTPMTField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType BILLPUBCONTEXT {
            get {
                return bILLPUBCONTEXTField;
            }
            set {
                bILLPUBCONTEXTField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BILLPUBCONTEXTSpecified {
            get {
                return bILLPUBCONTEXTFieldSpecified;
            }
            set {
                bILLPUBCONTEXTFieldSpecified = value;
            }
        }
    }
}