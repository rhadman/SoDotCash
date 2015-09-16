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
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DTSALE {
            get {
                return this.dTSALEField;
            }
            set {
                this.dTSALEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string SECNAME {
            get {
                return this.sECNAMEField;
            }
            set {
                this.sECNAMEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string NUMSHRS {
            get {
                return this.nUMSHRSField;
            }
            set {
                this.nUMSHRSField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string COSTBASIS {
            get {
                return this.cOSTBASISField;
            }
            set {
                this.cOSTBASISField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string SALESPR {
            get {
                return this.sALESPRField;
            }
            set {
                this.sALESPRField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public LongShortEnum LONGSHORT {
            get {
                return this.lONGSHORTField;
            }
            set {
                this.lONGSHORTField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LONGSHORTSpecified {
            get {
                return this.lONGSHORTFieldSpecified;
            }
            set {
                this.lONGSHORTFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType WASHSALE {
            get {
                return this.wASHSALEField;
            }
            set {
                this.wASHSALEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool WASHSALESpecified {
            get {
                return this.wASHSALEFieldSpecified;
            }
            set {
                this.wASHSALEFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string FEDTAXWH {
            get {
                return this.fEDTAXWHField;
            }
            set {
                this.fEDTAXWHField = value;
            }
        }
    }
}