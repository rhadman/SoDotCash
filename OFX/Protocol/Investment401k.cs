namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class Investment401k {
        
        private string eMPLOYERNAMEField;
        
        private string pLANIDField;
        
        private string pLANJOINDATEField;
        
        private string eMPLOYERCONTACTINFOField;
        
        private string bROKERCONTACTINFOField;
        
        private string dEFERPCTPRETAXField;
        
        private string dEFERPCTAFTERTAXField;
        
        private MatchInfo mATCHINFOField;
        
        private ContributionSecurity[] cONTRIBINFOField;
        
        private string cURRENTVESTPCTField;
        
        private VestInfo[] vESTINFOField;
        
        private LoanInfo[] lOANINFOField;
        
        private Investment401kSummary iNV401KSUMMARYField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string EMPLOYERNAME {
            get {
                return eMPLOYERNAMEField;
            }
            set {
                eMPLOYERNAMEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string PLANID {
            get {
                return pLANIDField;
            }
            set {
                pLANIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string PLANJOINDATE {
            get {
                return pLANJOINDATEField;
            }
            set {
                pLANJOINDATEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string EMPLOYERCONTACTINFO {
            get {
                return eMPLOYERCONTACTINFOField;
            }
            set {
                eMPLOYERCONTACTINFOField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string BROKERCONTACTINFO {
            get {
                return bROKERCONTACTINFOField;
            }
            set {
                bROKERCONTACTINFOField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DEFERPCTPRETAX {
            get {
                return dEFERPCTPRETAXField;
            }
            set {
                dEFERPCTPRETAXField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DEFERPCTAFTERTAX {
            get {
                return dEFERPCTAFTERTAXField;
            }
            set {
                dEFERPCTAFTERTAXField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public MatchInfo MATCHINFO {
            get {
                return mATCHINFOField;
            }
            set {
                mATCHINFOField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute("CONTRIBSECURITY", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        public ContributionSecurity[] CONTRIBINFO {
            get {
                return cONTRIBINFOField;
            }
            set {
                cONTRIBINFOField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string CURRENTVESTPCT {
            get {
                return cURRENTVESTPCTField;
            }
            set {
                cURRENTVESTPCTField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("VESTINFO", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public VestInfo[] VESTINFO {
            get {
                return vESTINFOField;
            }
            set {
                vESTINFOField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("LOANINFO", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public LoanInfo[] LOANINFO {
            get {
                return lOANINFOField;
            }
            set {
                lOANINFOField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Investment401kSummary INV401KSUMMARY {
            get {
                return iNV401KSUMMARYField;
            }
            set {
                iNV401KSUMMARYField = value;
            }
        }
    }
}