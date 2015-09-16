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
                return sECIDField;
            }
            set {
                sECIDField = value;
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
        public string OLDUNITS {
            get {
                return oLDUNITSField;
            }
            set {
                oLDUNITSField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string NEWUNITS {
            get {
                return nEWUNITSField;
            }
            set {
                nEWUNITSField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string NUMERATOR {
            get {
                return nUMERATORField;
            }
            set {
                nUMERATORField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DENOMINATOR {
            get {
                return dENOMINATORField;
            }
            set {
                dENOMINATORField = value;
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
        public string FRACCASH {
            get {
                return fRACCASHField;
            }
            set {
                fRACCASHField = value;
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
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SUBACCTFUNDSpecified {
            get {
                return sUBACCTFUNDFieldSpecified;
            }
            set {
                sUBACCTFUNDFieldSpecified = value;
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