namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class Split : AbstractInvestmentTransaction {
        
        private SecurityId sECIDField;
        
        private SubAccountEnum sUBACCTSECField;
        
        private string oLDUNITSField;
        
        private string nEWUNITSField;
        
        private string nUMERATORField;
        
        private string dENOMINATORField;
        
        private Currency cURRENCYField;
        
        private Currency oRIGCURRENCYField;
        
        private string fRACCASHField;
        
        private SubAccountEnum sUBACCTFUNDField;
        
        private bool sUBACCTFUNDFieldSpecified;
        
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
        public string OLDUNITS {
            get {
                return this.oLDUNITSField;
            }
            set {
                this.oLDUNITSField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string NEWUNITS {
            get {
                return this.nEWUNITSField;
            }
            set {
                this.nEWUNITSField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string NUMERATOR {
            get {
                return this.nUMERATORField;
            }
            set {
                this.nUMERATORField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DENOMINATOR {
            get {
                return this.dENOMINATORField;
            }
            set {
                this.dENOMINATORField = value;
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
        public string FRACCASH {
            get {
                return this.fRACCASHField;
            }
            set {
                this.fRACCASHField = value;
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
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SUBACCTFUNDSpecified {
            get {
                return this.sUBACCTFUNDFieldSpecified;
            }
            set {
                this.sUBACCTFUNDFieldSpecified = value;
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