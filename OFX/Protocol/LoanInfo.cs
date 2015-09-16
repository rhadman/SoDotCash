namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class LoanInfo {
        
        private string lOANIDField;
        
        private string lOANDESCField;
        
        private string iNITIALLOANBALField;
        
        private string lOANSTARTDATEField;
        
        private string cURRENTLOANBALField;
        
        private string dTASOFField;
        
        private string lOANRATEField;
        
        private string lOANPMTAMTField;
        
        private InvestmentFrequencyEnum lOANPMTFREQField;
        
        private bool lOANPMTFREQFieldSpecified;
        
        private string lOANPMTSINITIALField;
        
        private string lOANPMTSREMAININGField;
        
        private string lOANMATURITYDATEField;
        
        private string lOANTOTALPROJINTERESTField;
        
        private string lOANINTERESTTODATEField;
        
        private string lOANNEXTPMTDATEField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string LOANID {
            get {
                return lOANIDField;
            }
            set {
                lOANIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string LOANDESC {
            get {
                return lOANDESCField;
            }
            set {
                lOANDESCField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string INITIALLOANBAL {
            get {
                return iNITIALLOANBALField;
            }
            set {
                iNITIALLOANBALField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string LOANSTARTDATE {
            get {
                return lOANSTARTDATEField;
            }
            set {
                lOANSTARTDATEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string CURRENTLOANBAL {
            get {
                return cURRENTLOANBALField;
            }
            set {
                cURRENTLOANBALField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DTASOF {
            get {
                return dTASOFField;
            }
            set {
                dTASOFField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string LOANRATE {
            get {
                return lOANRATEField;
            }
            set {
                lOANRATEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string LOANPMTAMT {
            get {
                return lOANPMTAMTField;
            }
            set {
                lOANPMTAMTField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public InvestmentFrequencyEnum LOANPMTFREQ {
            get {
                return lOANPMTFREQField;
            }
            set {
                lOANPMTFREQField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LOANPMTFREQSpecified {
            get {
                return lOANPMTFREQFieldSpecified;
            }
            set {
                lOANPMTFREQFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string LOANPMTSINITIAL {
            get {
                return lOANPMTSINITIALField;
            }
            set {
                lOANPMTSINITIALField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string LOANPMTSREMAINING {
            get {
                return lOANPMTSREMAININGField;
            }
            set {
                lOANPMTSREMAININGField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string LOANMATURITYDATE {
            get {
                return lOANMATURITYDATEField;
            }
            set {
                lOANMATURITYDATEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string LOANTOTALPROJINTEREST {
            get {
                return lOANTOTALPROJINTERESTField;
            }
            set {
                lOANTOTALPROJINTERESTField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string LOANINTERESTTODATE {
            get {
                return lOANINTERESTTODATEField;
            }
            set {
                lOANINTERESTTODATEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string LOANNEXTPMTDATE {
            get {
                return lOANNEXTPMTDATEField;
            }
            set {
                lOANNEXTPMTDATEField = value;
            }
        }
    }
}