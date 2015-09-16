namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class RecurringAddress {
        
        private string rECNAME1Field;
        
        private string rECNAME2Field;
        
        private string aDDR1Field;
        
        private string aDDR2Field;
        
        private string aDDR3Field;
        
        private string cITYField;
        
        private string sTATEField;
        
        private string pOSTALCODEField;
        
        private string cOUNTRYSTRINGField;
        
        private string pHONEField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string RECNAME1 {
            get {
                return rECNAME1Field;
            }
            set {
                rECNAME1Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string RECNAME2 {
            get {
                return rECNAME2Field;
            }
            set {
                rECNAME2Field = value;
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
        public string COUNTRYSTRING {
            get {
                return cOUNTRYSTRINGField;
            }
            set {
                cOUNTRYSTRINGField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string PHONE {
            get {
                return pHONEField;
            }
            set {
                pHONEField = value;
            }
        }
    }
}