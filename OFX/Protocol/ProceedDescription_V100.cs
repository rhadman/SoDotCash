namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class ProceedDescription_V100 {
        
        private object itemField;
        
        private string dTSALEField;
        
        private string sECNAMEField;
        
        private string nUMSHRSField;
        
        private string cOSTBASISField;
        
        private string sALESPRField;
        
        private LongShortEnum lONGSHORTField;
        
        private bool lONGSHORTFieldSpecified;
        
        private BooleanType wASHSALEField;
        
        private bool wASHSALEFieldSpecified;
        
        private string fEDTAXWHField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DTAQD", typeof(string), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("DTVAR", typeof(BooleanType), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public object Item {
            get {
                return itemField;
            }
            set {
                itemField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DTSALE {
            get {
                return dTSALEField;
            }
            set {
                dTSALEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string SECNAME {
            get {
                return sECNAMEField;
            }
            set {
                sECNAMEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string NUMSHRS {
            get {
                return nUMSHRSField;
            }
            set {
                nUMSHRSField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string COSTBASIS {
            get {
                return cOSTBASISField;
            }
            set {
                cOSTBASISField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string SALESPR {
            get {
                return sALESPRField;
            }
            set {
                sALESPRField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public LongShortEnum LONGSHORT {
            get {
                return lONGSHORTField;
            }
            set {
                lONGSHORTField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LONGSHORTSpecified {
            get {
                return lONGSHORTFieldSpecified;
            }
            set {
                lONGSHORTFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType WASHSALE {
            get {
                return wASHSALEField;
            }
            set {
                wASHSALEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool WASHSALESpecified {
            get {
                return wASHSALEFieldSpecified;
            }
            set {
                wASHSALEFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string FEDTAXWH {
            get {
                return fEDTAXWHField;
            }
            set {
                fEDTAXWHField = value;
            }
        }
    }
}