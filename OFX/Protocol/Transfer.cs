namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class Transfer : AbstractInvestmentTransaction {
        
        private SecurityId sECIDField;
        
        private SubAccountEnum sUBACCTSECField;
        
        private string uNITSField;
        
        private InOutEnum tFERACTIONField;
        
        private PositionTypeEnum pOSTYPEField;
        
        private InvestmentAccount iNVACCTFROMField;
        
        private string aVGCOSTBASISField;
        
        private string uNITPRICEField;
        
        private string dTPURCHASEField;
        
        private Investment401kSourceEnum iNV401KSOURCEField;
        
        private bool iNV401KSOURCEFieldSpecified;
        
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
        public InOutEnum TFERACTION {
            get {
                return this.tFERACTIONField;
            }
            set {
                this.tFERACTIONField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PositionTypeEnum POSTYPE {
            get {
                return this.pOSTYPEField;
            }
            set {
                this.pOSTYPEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public InvestmentAccount INVACCTFROM {
            get {
                return this.iNVACCTFROMField;
            }
            set {
                this.iNVACCTFROMField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string AVGCOSTBASIS {
            get {
                return this.aVGCOSTBASISField;
            }
            set {
                this.aVGCOSTBASISField = value;
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
        public string DTPURCHASE {
            get {
                return this.dTPURCHASEField;
            }
            set {
                this.dTPURCHASEField = value;
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