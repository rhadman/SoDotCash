namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class LoanPaymentAmount {
        
        private string pMTAMTField;
        
        private string dTPMTDUEField;
        
        private EscrowAmount eSCRWAMTField;
        
        private LoanPaymentEnum lOANPMTTYPEField;
        
        private bool lOANPMTTYPEFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string PMTAMT {
            get {
                return this.pMTAMTField;
            }
            set {
                this.pMTAMTField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DTPMTDUE {
            get {
                return this.dTPMTDUEField;
            }
            set {
                this.dTPMTDUEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public EscrowAmount ESCRWAMT {
            get {
                return this.eSCRWAMTField;
            }
            set {
                this.eSCRWAMTField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public LoanPaymentEnum LOANPMTTYPE {
            get {
                return this.lOANPMTTYPEField;
            }
            set {
                this.lOANPMTTYPEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LOANPMTTYPESpecified {
            get {
                return this.lOANPMTTYPEFieldSpecified;
            }
            set {
                this.lOANPMTTYPEFieldSpecified = value;
            }
        }
    }
}