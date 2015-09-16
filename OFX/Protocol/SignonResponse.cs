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
                return this.sTATUSField;
            }
            set {
                this.sTATUSField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DTSERVER {
            get {
                return this.dTSERVERField;
            }
            set {
                this.dTSERVERField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string USERKEY {
            get {
                return this.uSERKEYField;
            }
            set {
                this.uSERKEYField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string TSKEYEXPIRE {
            get {
                return this.tSKEYEXPIREField;
            }
            set {
                this.tSKEYEXPIREField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public LanguageEnum LANGUAGE {
            get {
                return this.lANGUAGEField;
            }
            set {
                this.lANGUAGEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DTPROFUP {
            get {
                return this.dTPROFUPField;
            }
            set {
                this.dTPROFUPField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DTACCTUP {
            get {
                return this.dTACCTUPField;
            }
            set {
                this.dTACCTUPField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public FinancialInstitution FI {
            get {
                return this.fiField;
            }
            set {
                this.fiField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string SESSCOOKIE {
            get {
                return this.sESSCOOKIEField;
            }
            set {
                this.sESSCOOKIEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ACCESSKEY {
            get {
                return this.aCCESSKEYField;
            }
            set {
                this.aCCESSKEYField = value;
            }
        }
    }
}