namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class SignonResponse {
        
        private Status sTATUSField;
        
        private string dTSERVERField;
        
        private string uSERKEYField;
        
        private string tSKEYEXPIREField;
        
        private LanguageEnum lANGUAGEField;
        
        private string dTPROFUPField;
        
        private string dTACCTUPField;
        
        private FinancialInstitution fiField;
        
        private string sESSCOOKIEField;
        
        private string aCCESSKEYField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Status STATUS {
            get {
                return sTATUSField;
            }
            set {
                sTATUSField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DTSERVER {
            get {
                return dTSERVERField;
            }
            set {
                dTSERVERField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string USERKEY {
            get {
                return uSERKEYField;
            }
            set {
                uSERKEYField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string TSKEYEXPIRE {
            get {
                return tSKEYEXPIREField;
            }
            set {
                tSKEYEXPIREField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public LanguageEnum LANGUAGE {
            get {
                return lANGUAGEField;
            }
            set {
                lANGUAGEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DTPROFUP {
            get {
                return dTPROFUPField;
            }
            set {
                dTPROFUPField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DTACCTUP {
            get {
                return dTACCTUPField;
            }
            set {
                dTACCTUPField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public FinancialInstitution FI {
            get {
                return fiField;
            }
            set {
                fiField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string SESSCOOKIE {
            get {
                return sESSCOOKIEField;
            }
            set {
                sESSCOOKIEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ACCESSKEY {
            get {
                return aCCESSKEYField;
            }
            set {
                aCCESSKEYField = value;
            }
        }
    }
}