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
                return fITIDField;
            }
            set {
                fITIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string SRVRTID {
            get {
                return sRVRTIDField;
            }
            set {
                sRVRTIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SecurityId SECID {
            get {
                return sECIDField;
            }
            set {
                sECIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DTPLACED {
            get {
                return dTPLACEDField;
            }
            set {
                dTPLACEDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string UNITS {
            get {
                return uNITSField;
            }
            set {
                uNITSField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SubAccountEnum SUBACCT {
            get {
                return sUBACCTField;
            }
            set {
                sUBACCTField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public DurationEnum DURATION {
            get {
                return dURATIONField;
            }
            set {
                dURATIONField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public RestrictionEnum RESTRICTION {
            get {
                return rESTRICTIONField;
            }
            set {
                rESTRICTIONField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string MINUNITS {
            get {
                return mINUNITSField;
            }
            set {
                mINUNITSField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string LIMITPRICE {
            get {
                return lIMITPRICEField;
            }
            set {
                lIMITPRICEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string STOPPRICE {
            get {
                return sTOPPRICEField;
            }
            set {
                sTOPPRICEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string MEMO {
            get {
                return mEMOField;
            }
            set {
                mEMOField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Currency CURRENCY {
            get {
                return cURRENCYField;
            }
            set {
                cURRENCYField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Investment401kSourceEnum INV401KSOURCE {
            get {
                return iNV401KSOURCEField;
            }
            set {
                iNV401KSOURCEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool INV401KSOURCESpecified {
            get {
                return iNV401KSOURCEFieldSpecified;
            }
            set {
                iNV401KSOURCEFieldSpecified = value;
            }
        }
    }
}