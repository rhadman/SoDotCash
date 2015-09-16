namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class SignonRequest {
        
        private string dTCLIENTField;
        
        private string[] itemsField;
        
        private ItemsChoiceType[] itemsElementNameField;
        
        private BooleanType gENUSERKEYField;
        
        private bool gENUSERKEYFieldSpecified;
        
        private LanguageEnum lANGUAGEField;
        
        private FinancialInstitution fiField;
        
        private string sESSCOOKIEField;
        
        private string aPPIDField;
        
        private string aPPVERField;
        
        private string cLIENTUIDField;
        
        private string uSERCRED1Field;
        
        private string uSERCRED2Field;
        
        private string aUTHTOKENField;
        
        private string aCCESSKEYField;
        
        private MFAChallengeAnswer[] mFACHALLENGEANSWERField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DTCLIENT {
            get {
                return this.dTCLIENTField;
            }
            set {
                this.dTCLIENTField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("USERID", typeof(string), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("USERKEY", typeof(string), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("USERPASS", typeof(string), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public string[] Items {
            get {
                return this.itemsField;
            }
            set {
                this.itemsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemsChoiceType[] ItemsElementName {
            get {
                return this.itemsElementNameField;
            }
            set {
                this.itemsElementNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType GENUSERKEY {
            get {
                return this.gENUSERKEYField;
            }
            set {
                this.gENUSERKEYField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool GENUSERKEYSpecified {
            get {
                return this.gENUSERKEYFieldSpecified;
            }
            set {
                this.gENUSERKEYFieldSpecified = value;
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
        public string APPID {
            get {
                return this.aPPIDField;
            }
            set {
                this.aPPIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string APPVER {
            get {
                return this.aPPVERField;
            }
            set {
                this.aPPVERField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string CLIENTUID {
            get {
                return this.cLIENTUIDField;
            }
            set {
                this.cLIENTUIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string USERCRED1 {
            get {
                return this.uSERCRED1Field;
            }
            set {
                this.uSERCRED1Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string USERCRED2 {
            get {
                return this.uSERCRED2Field;
            }
            set {
                this.uSERCRED2Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string AUTHTOKEN {
            get {
                return this.aUTHTOKENField;
            }
            set {
                this.aUTHTOKENField = value;
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
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MFACHALLENGEANSWER", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public MFAChallengeAnswer[] MFACHALLENGEANSWER {
            get {
                return this.mFACHALLENGEANSWERField;
            }
            set {
                this.mFACHALLENGEANSWERField = value;
            }
        }
    }
}