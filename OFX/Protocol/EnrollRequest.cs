namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class EnrollRequest {
        
        private string fIRSTNAMEField;
        
        private string mIDDLENAMEField;
        
        private string lASTNAMEField;
        
        private string aDDR1Field;
        
        private string aDDR2Field;
        
        private string aDDR3Field;
        
        private string cITYField;
        
        private string sTATEField;
        
        private string pOSTALCODEField;
        
        private string cOUNTRYField;
        
        private string dAYPHONEField;
        
        private string eVEPHONEField;
        
        private string eMAILField;
        
        private string uSERIDField;
        
        private string tAXIDField;
        
        private string sECURITYNAMEField;
        
        private string dATEBIRTHField;
        
        private AbstractAccount itemField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string FIRSTNAME {
            get {
                return fIRSTNAMEField;
            }
            set {
                fIRSTNAMEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string MIDDLENAME {
            get {
                return mIDDLENAMEField;
            }
            set {
                mIDDLENAMEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string LASTNAME {
            get {
                return lASTNAMEField;
            }
            set {
                lASTNAMEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ADDR1 {
            get {
                return aDDR1Field;
            }
            set {
                aDDR1Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ADDR2 {
            get {
                return aDDR2Field;
            }
            set {
                aDDR2Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ADDR3 {
            get {
                return aDDR3Field;
            }
            set {
                aDDR3Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string CITY {
            get {
                return cITYField;
            }
            set {
                cITYField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string STATE {
            get {
                return sTATEField;
            }
            set {
                sTATEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string POSTALCODE {
            get {
                return pOSTALCODEField;
            }
            set {
                pOSTALCODEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string COUNTRY {
            get {
                return cOUNTRYField;
            }
            set {
                cOUNTRYField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DAYPHONE {
            get {
                return dAYPHONEField;
            }
            set {
                dAYPHONEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string EVEPHONE {
            get {
                return eVEPHONEField;
            }
            set {
                eVEPHONEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string EMAIL {
            get {
                return eMAILField;
            }
            set {
                eMAILField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string USERID {
            get {
                return uSERIDField;
            }
            set {
                uSERIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string TAXID {
            get {
                return tAXIDField;
            }
            set {
                tAXIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string SECURITYNAME {
            get {
                return sECURITYNAMEField;
            }
            set {
                sECURITYNAMEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DATEBIRTH {
            get {
                return dATEBIRTHField;
            }
            set {
                dATEBIRTHField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BANKACCTFROM", typeof(BankAccount), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("CCACCTFROM", typeof(CreditCardAccount), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("INVACCTFROM", typeof(InvestmentAccount), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("PRESACCTFROM", typeof(PresentmentAccount), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public AbstractAccount Item {
            get {
                return itemField;
            }
            set {
                itemField = value;
            }
        }
    }
}