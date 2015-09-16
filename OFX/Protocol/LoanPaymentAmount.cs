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
                return pMTAMTField;
            }
            set {
                pMTAMTField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DTPMTDUE {
            get {
                return dTPMTDUEField;
            }
            set {
                dTPMTDUEField = value;
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
        public LoanPaymentEnum LOANPMTTYPE {
            get {
                return lOANPMTTYPEField;
            }
            set {
                lOANPMTTYPEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LOANPMTTYPESpecified {
            get {
                return lOANPMTTYPEFieldSpecified;
            }
            set {
                lOANPMTTYPEFieldSpecified = value;
            }
        }
    }
}