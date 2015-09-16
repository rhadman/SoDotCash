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
                return this.lOANIDField;
            }
            set {
                this.lOANIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string LOANDESC {
            get {
                return this.lOANDESCField;
            }
            set {
                this.lOANDESCField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string INITIALLOANBAL {
            get {
                return this.iNITIALLOANBALField;
            }
            set {
                this.iNITIALLOANBALField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string LOANSTARTDATE {
            get {
                return this.lOANSTARTDATEField;
            }
            set {
                this.lOANSTARTDATEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string CURRENTLOANBAL {
            get {
                return this.cURRENTLOANBALField;
            }
            set {
                this.cURRENTLOANBALField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DTASOF {
            get {
                return this.dTASOFField;
            }
            set {
                this.dTASOFField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string LOANRATE {
            get {
                return this.lOANRATEField;
            }
            set {
                this.lOANRATEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string LOANPMTAMT {
            get {
                return this.lOANPMTAMTField;
            }
            set {
                this.lOANPMTAMTField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public InvestmentFrequencyEnum LOANPMTFREQ {
            get {
                return this.lOANPMTFREQField;
            }
            set {
                this.lOANPMTFREQField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LOANPMTFREQSpecified {
            get {
                return this.lOANPMTFREQFieldSpecified;
            }
            set {
                this.lOANPMTFREQFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string LOANPMTSINITIAL {
            get {
                return this.lOANPMTSINITIALField;
            }
            set {
                this.lOANPMTSINITIALField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string LOANPMTSREMAINING {
            get {
                return this.lOANPMTSREMAININGField;
            }
            set {
                this.lOANPMTSREMAININGField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string LOANMATURITYDATE {
            get {
                return this.lOANMATURITYDATEField;
            }
            set {
                this.lOANMATURITYDATEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string LOANTOTALPROJINTEREST {
            get {
                return this.lOANTOTALPROJINTERESTField;
            }
            set {
                this.lOANTOTALPROJINTERESTField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string LOANINTERESTTODATE {
            get {
                return this.lOANINTERESTTODATEField;
            }
            set {
                this.lOANINTERESTTODATEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string LOANNEXTPMTDATE {
            get {
                return this.lOANNEXTPMTDATEField;
            }
            set {
                this.lOANNEXTPMTDATEField = value;
            }
        }
    }
}