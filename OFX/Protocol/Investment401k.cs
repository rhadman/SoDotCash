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
                return this.eMPLOYERNAMEField;
            }
            set {
                this.eMPLOYERNAMEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string PLANID {
            get {
                return this.pLANIDField;
            }
            set {
                this.pLANIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string PLANJOINDATE {
            get {
                return this.pLANJOINDATEField;
            }
            set {
                this.pLANJOINDATEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string EMPLOYERCONTACTINFO {
            get {
                return this.eMPLOYERCONTACTINFOField;
            }
            set {
                this.eMPLOYERCONTACTINFOField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string BROKERCONTACTINFO {
            get {
                return this.bROKERCONTACTINFOField;
            }
            set {
                this.bROKERCONTACTINFOField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DEFERPCTPRETAX {
            get {
                return this.dEFERPCTPRETAXField;
            }
            set {
                this.dEFERPCTPRETAXField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DEFERPCTAFTERTAX {
            get {
                return this.dEFERPCTAFTERTAXField;
            }
            set {
                this.dEFERPCTAFTERTAXField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public MatchInfo MATCHINFO {
            get {
                return this.mATCHINFOField;
            }
            set {
                this.mATCHINFOField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute("CONTRIBSECURITY", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        public ContributionSecurity[] CONTRIBINFO {
            get {
                return this.cONTRIBINFOField;
            }
            set {
                this.cONTRIBINFOField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string CURRENTVESTPCT {
            get {
                return this.cURRENTVESTPCTField;
            }
            set {
                this.cURRENTVESTPCTField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("VESTINFO", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public VestInfo[] VESTINFO {
            get {
                return this.vESTINFOField;
            }
            set {
                this.vESTINFOField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("LOANINFO", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public LoanInfo[] LOANINFO {
            get {
                return this.lOANINFOField;
            }
            set {
                this.lOANINFOField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Investment401kSummary INV401KSUMMARY {
            get {
                return this.iNV401KSUMMARYField;
            }
            set {
                this.iNV401KSUMMARYField = value;
            }
        }
    }
}