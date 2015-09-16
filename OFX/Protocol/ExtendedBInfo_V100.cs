namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class ExtendedBInfo_V100 {
        
        private ProceedDescription_V100[] pROCDET_V100Field;
        
        private string tEINTERESTField;
        
        private string pABINTERESTField;
        
        private string tEINTDIVIDENDField;
        
        private string pABDIVIDENDField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PROCDET_V100", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ProceedDescription_V100[] PROCDET_V100 {
            get {
                return this.pROCDET_V100Field;
            }
            set {
                this.pROCDET_V100Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string TEINTEREST {
            get {
                return this.tEINTERESTField;
            }
            set {
                this.tEINTERESTField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string PABINTEREST {
            get {
                return this.pABINTERESTField;
            }
            set {
                this.pABINTERESTField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string TEINTDIVIDEND {
            get {
                return this.tEINTDIVIDENDField;
            }
            set {
                this.tEINTDIVIDENDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string PABDIVIDEND {
            get {
                return this.pABDIVIDENDField;
            }
            set {
                this.pABDIVIDENDField = value;
            }
        }
    }
}