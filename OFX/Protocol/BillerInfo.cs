namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class BillerInfo {
        
        private string bILLPUBField;
        
        private string bILLERIDField;
        
        private string nAMEField;
        
        private string aDDR1Field;
        
        private string aDDR2Field;
        
        private string aDDR3Field;
        
        private string cITYField;
        
        private string sTATEField;
        
        private string pOSTALCODEField;
        
        private string cOUNTRYField;
        
        private string sICField;
        
        private string pHONEField;
        
        private PaymentInstrument[] pAYMENTINSTRUMENTSField;
        
        private string aCCTFORMATField;
        
        private string aCCTEDITMASKField;
        
        private string hELPMESSAGEField;
        
        private string rESTRICTField;
        
        private string lOGOField;
        
        private string vALIDATEField;
        
        private string bILLERINFOURLField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string BILLPUB {
            get {
                return bILLPUBField;
            }
            set {
                bILLPUBField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string BILLERID {
            get {
                return bILLERIDField;
            }
            set {
                bILLERIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string NAME {
            get {
                return nAMEField;
            }
            set {
                nAMEField = value;
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
        public string SIC {
            get {
                return sICField;
            }
            set {
                sICField = value;
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
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute("PAYMENTINSTRUMENT", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        public PaymentInstrument[] PAYMENTINSTRUMENTS {
            get {
                return pAYMENTINSTRUMENTSField;
            }
            set {
                pAYMENTINSTRUMENTSField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ACCTFORMAT {
            get {
                return aCCTFORMATField;
            }
            set {
                aCCTFORMATField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ACCTEDITMASK {
            get {
                return aCCTEDITMASKField;
            }
            set {
                aCCTEDITMASKField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string HELPMESSAGE {
            get {
                return hELPMESSAGEField;
            }
            set {
                hELPMESSAGEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string RESTRICT {
            get {
                return rESTRICTField;
            }
            set {
                rESTRICTField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string LOGO {
            get {
                return lOGOField;
            }
            set {
                lOGOField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string VALIDATE {
            get {
                return vALIDATEField;
            }
            set {
                vALIDATEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string BILLERINFOURL {
            get {
                return bILLERINFOURLField;
            }
            set {
                bILLERINFOURLField = value;
            }
        }
    }
}