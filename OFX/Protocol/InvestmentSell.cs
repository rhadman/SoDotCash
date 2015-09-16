namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class InvestmentSell : AbstractInvestmentTransaction {
        
        private SecurityId sECIDField;
        
        private string uNITSField;
        
        private string uNITPRICEField;
        
        private string mARKDOWNField;
        
        private string cOMMISSIONField;
        
        private string tAXESField;
        
        private string fEESField;
        
        private string lOADField;
        
        private string wITHHOLDINGField;
        
        private BooleanType tAXEXEMPTField;
        
        private bool tAXEXEMPTFieldSpecified;
        
        private string tOTALField;
        
        private string gAINField;
        
        private Currency cURRENCYField;
        
        private Currency oRIGCURRENCYField;
        
        private SubAccountEnum sUBACCTSECField;
        
        private SubAccountEnum sUBACCTFUNDField;
        
        private string lOANIDField;
        
        private string sTATEWITHHOLDINGField;
        
        private string pENALTYField;
        
        private Investment401kSourceEnum iNV401KSOURCEField;
        
        private bool iNV401KSOURCEFieldSpecified;
        
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
        public string UNITPRICE {
            get {
                return uNITPRICEField;
            }
            set {
                uNITPRICEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string MARKDOWN {
            get {
                return mARKDOWNField;
            }
            set {
                mARKDOWNField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string COMMISSION {
            get {
                return cOMMISSIONField;
            }
            set {
                cOMMISSIONField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string TAXES {
            get {
                return tAXESField;
            }
            set {
                tAXESField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string FEES {
            get {
                return fEESField;
            }
            set {
                fEESField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string LOAD {
            get {
                return lOADField;
            }
            set {
                lOADField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string WITHHOLDING {
            get {
                return wITHHOLDINGField;
            }
            set {
                wITHHOLDINGField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType TAXEXEMPT {
            get {
                return tAXEXEMPTField;
            }
            set {
                tAXEXEMPTField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TAXEXEMPTSpecified {
            get {
                return tAXEXEMPTFieldSpecified;
            }
            set {
                tAXEXEMPTFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string TOTAL {
            get {
                return tOTALField;
            }
            set {
                tOTALField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string GAIN {
            get {
                return gAINField;
            }
            set {
                gAINField = value;
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
        public Currency ORIGCURRENCY {
            get {
                return oRIGCURRENCYField;
            }
            set {
                oRIGCURRENCYField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SubAccountEnum SUBACCTSEC {
            get {
                return sUBACCTSECField;
            }
            set {
                sUBACCTSECField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SubAccountEnum SUBACCTFUND {
            get {
                return sUBACCTFUNDField;
            }
            set {
                sUBACCTFUNDField = value;
            }
        }
        
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
        public string STATEWITHHOLDING {
            get {
                return sTATEWITHHOLDINGField;
            }
            set {
                sTATEWITHHOLDINGField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string PENALTY {
            get {
                return pENALTYField;
            }
            set {
                pENALTYField = value;
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