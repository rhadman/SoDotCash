namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class InvestmentBuy : AbstractInvestmentTransaction {
        
        private SecurityId sECIDField;
        
        private string uNITSField;
        
        private string uNITPRICEField;
        
        private string mARKUPField;
        
        private string cOMMISSIONField;
        
        private string tAXESField;
        
        private string fEESField;
        
        private string lOADField;
        
        private string tOTALField;
        
        private Currency cURRENCYField;
        
        private Currency oRIGCURRENCYField;
        
        private SubAccountEnum sUBACCTSECField;
        
        private SubAccountEnum sUBACCTFUNDField;
        
        private string lOANIDField;
        
        private string lOANPRINCIPALField;
        
        private string lOANINTERESTField;
        
        private Investment401kSourceEnum iNV401KSOURCEField;
        
        private bool iNV401KSOURCEFieldSpecified;
        
        private string dTPAYROLLField;
        
        private BooleanType pRIORYEARCONTRIBField;
        
        private bool pRIORYEARCONTRIBFieldSpecified;
        
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
        public string UNITPRICE {
            get {
                return this.uNITPRICEField;
            }
            set {
                this.uNITPRICEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string MARKUP {
            get {
                return this.mARKUPField;
            }
            set {
                this.mARKUPField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string COMMISSION {
            get {
                return this.cOMMISSIONField;
            }
            set {
                this.cOMMISSIONField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string TAXES {
            get {
                return this.tAXESField;
            }
            set {
                this.tAXESField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string FEES {
            get {
                return this.fEESField;
            }
            set {
                this.fEESField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string LOAD {
            get {
                return this.lOADField;
            }
            set {
                this.lOADField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string TOTAL {
            get {
                return this.tOTALField;
            }
            set {
                this.tOTALField = value;
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
        public Currency ORIGCURRENCY {
            get {
                return this.oRIGCURRENCYField;
            }
            set {
                this.oRIGCURRENCYField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SubAccountEnum SUBACCTSEC {
            get {
                return this.sUBACCTSECField;
            }
            set {
                this.sUBACCTSECField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SubAccountEnum SUBACCTFUND {
            get {
                return this.sUBACCTFUNDField;
            }
            set {
                this.sUBACCTFUNDField = value;
            }
        }
        
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
        public string LOANPRINCIPAL {
            get {
                return this.lOANPRINCIPALField;
            }
            set {
                this.lOANPRINCIPALField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string LOANINTEREST {
            get {
                return this.lOANINTERESTField;
            }
            set {
                this.lOANINTERESTField = value;
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
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DTPAYROLL {
            get {
                return this.dTPAYROLLField;
            }
            set {
                this.dTPAYROLLField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType PRIORYEARCONTRIB {
            get {
                return this.pRIORYEARCONTRIBField;
            }
            set {
                this.pRIORYEARCONTRIBField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PRIORYEARCONTRIBSpecified {
            get {
                return this.pRIORYEARCONTRIBFieldSpecified;
            }
            set {
                this.pRIORYEARCONTRIBFieldSpecified = value;
            }
        }
    }
}