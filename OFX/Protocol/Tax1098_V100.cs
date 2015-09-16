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
                return sRVRTIDField;
            }
            set {
                sRVRTIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="gYear")]
        public string TAXYEAR {
            get {
                return tAXYEARField;
            }
            set {
                tAXYEARField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string MORTGAGEINTEREST {
            get {
                return mORTGAGEINTERESTField;
            }
            set {
                mORTGAGEINTERESTField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string POINTS {
            get {
                return pOINTSField;
            }
            set {
                pOINTSField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string OVERPAIDREFUND {
            get {
                return oVERPAIDREFUNDField;
            }
            set {
                oVERPAIDREFUNDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string OTHERLOANINFO {
            get {
                return oTHERLOANINFOField;
            }
            set {
                oTHERLOANINFOField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public LenderAddress LENDERADDR {
            get {
                return lENDERADDRField;
            }
            set {
                lENDERADDRField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string LENDERID {
            get {
                return lENDERIDField;
            }
            set {
                lENDERIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BorrowerAddress BORROWERADDR {
            get {
                return bORROWERADDRField;
            }
            set {
                bORROWERADDRField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string BORROWERID {
            get {
                return bORROWERIDField;
            }
            set {
                bORROWERIDField = value;
            }
        }
    }
}