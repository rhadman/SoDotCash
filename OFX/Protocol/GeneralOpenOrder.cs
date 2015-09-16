namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class GeneralOpenOrder {
        
        private string fITIDField;
        
        private string sRVRTIDField;
        
        private SecurityId sECIDField;
        
        private string dTPLACEDField;
        
        private string uNITSField;
        
        private SubAccountEnum sUBACCTField;
        
        private DurationEnum dURATIONField;
        
        private RestrictionEnum rESTRICTIONField;
        
        private string mINUNITSField;
        
        private string lIMITPRICEField;
        
        private string sTOPPRICEField;
        
        private string mEMOField;
        
        private Currency cURRENCYField;
        
        private Investment401kSourceEnum iNV401KSOURCEField;
        
        private bool iNV401KSOURCEFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string FITID {
            get {
                return this.fITIDField;
            }
            set {
                this.fITIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string SRVRTID {
            get {
                return this.sRVRTIDField;
            }
            set {
                this.sRVRTIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SecurityId SECID {
            get {
                return this.sECIDField;
            }
            set {
                this.sECIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DTPLACED {
            get {
                return this.dTPLACEDField;
            }
            set {
                this.dTPLACEDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string UNITS {
            get {
                return this.uNITSField;
            }
            set {
                this.uNITSField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SubAccountEnum SUBACCT {
            get {
                return this.sUBACCTField;
            }
            set {
                this.sUBACCTField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public DurationEnum DURATION {
            get {
                return this.dURATIONField;
            }
            set {
                this.dURATIONField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public RestrictionEnum RESTRICTION {
            get {
                return this.rESTRICTIONField;
            }
            set {
                this.rESTRICTIONField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string MINUNITS {
            get {
                return this.mINUNITSField;
            }
            set {
                this.mINUNITSField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string LIMITPRICE {
            get {
                return this.lIMITPRICEField;
            }
            set {
                this.lIMITPRICEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string STOPPRICE {
            get {
                return this.sTOPPRICEField;
            }
            set {
                this.sTOPPRICEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string MEMO {
            get {
                return this.mEMOField;
            }
            set {
                this.mEMOField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Currency CURRENCY {
            get {
                return this.cURRENCYField;
            }
            set {
                this.cURRENCYField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Investment401kSourceEnum INV401KSOURCE {
            get {
                return this.iNV401KSOURCEField;
            }
            set {
                this.iNV401KSOURCEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool INV401KSOURCESpecified {
            get {
                return this.iNV401KSOURCEFieldSpecified;
            }
            set {
                this.iNV401KSOURCEFieldSpecified = value;
            }
        }
    }
}