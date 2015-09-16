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
                return dTCLIENTField;
            }
            set {
                dTCLIENTField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("USERID", typeof(string), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("USERKEY", typeof(string), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("USERPASS", typeof(string), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public string[] Items {
            get {
                return itemsField;
            }
            set {
                itemsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemsChoiceType[] ItemsElementName {
            get {
                return itemsElementNameField;
            }
            set {
                itemsElementNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType GENUSERKEY {
            get {
                return gENUSERKEYField;
            }
            set {
                gENUSERKEYField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool GENUSERKEYSpecified {
            get {
                return gENUSERKEYFieldSpecified;
            }
            set {
                gENUSERKEYFieldSpecified = value;
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
        public string APPID {
            get {
                return aPPIDField;
            }
            set {
                aPPIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string APPVER {
            get {
                return aPPVERField;
            }
            set {
                aPPVERField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string CLIENTUID {
            get {
                return cLIENTUIDField;
            }
            set {
                cLIENTUIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string USERCRED1 {
            get {
                return uSERCRED1Field;
            }
            set {
                uSERCRED1Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string USERCRED2 {
            get {
                return uSERCRED2Field;
            }
            set {
                uSERCRED2Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string AUTHTOKEN {
            get {
                return aUTHTOKENField;
            }
            set {
                aUTHTOKENField = value;
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
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MFACHALLENGEANSWER", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public MFAChallengeAnswer[] MFACHALLENGEANSWER {
            get {
                return mFACHALLENGEANSWERField;
            }
            set {
                mFACHALLENGEANSWERField = value;
            }
        }
    }
}