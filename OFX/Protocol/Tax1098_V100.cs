namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class Tax1098_V100 {
        
        private string sRVRTIDField;
        
        private string tAXYEARField;
        
        private string mORTGAGEINTERESTField;
        
        private string pOINTSField;
        
        private string oVERPAIDREFUNDField;
        
        private string oTHERLOANINFOField;
        
        private LenderAddress lENDERADDRField;
        
        private string lENDERIDField;
        
        private BorrowerAddress bORROWERADDRField;
        
        private string bORROWERIDField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string SRVRTID {
            get {
                return this.sRVRTIDField;
            }
            set {
                this.sRVRTIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="gYear")]
        public string TAXYEAR {
            get {
                return this.tAXYEARField;
            }
            set {
                this.tAXYEARField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string MORTGAGEINTEREST {
            get {
                return this.mORTGAGEINTERESTField;
            }
            set {
                this.mORTGAGEINTERESTField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string POINTS {
            get {
                return this.pOINTSField;
            }
            set {
                this.pOINTSField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string OVERPAIDREFUND {
            get {
                return this.oVERPAIDREFUNDField;
            }
            set {
                this.oVERPAIDREFUNDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string OTHERLOANINFO {
            get {
                return this.oTHERLOANINFOField;
            }
            set {
                this.oTHERLOANINFOField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public LenderAddress LENDERADDR {
            get {
                return this.lENDERADDRField;
            }
            set {
                this.lENDERADDRField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string LENDERID {
            get {
                return this.lENDERIDField;
            }
            set {
                this.lENDERIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BorrowerAddress BORROWERADDR {
            get {
                return this.bORROWERADDRField;
            }
            set {
                this.bORROWERADDRField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string BORROWERID {
            get {
                return this.bORROWERIDField;
            }
            set {
                this.bORROWERIDField = value;
            }
        }
    }
}