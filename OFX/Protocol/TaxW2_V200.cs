namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class TaxW2_V200 : AbstractTaxW2 {
        
        private Employer eMPLOYERField;
        
        private Employee eMPLOYEEField;
        
        private string wAGESField;
        
        private string fEDTAXWHField;
        
        private string sSWAGESField;
        
        private string sSTAXWHField;
        
        private string mEDICAREWAGESField;
        
        private string mEDICARETAXWHField;
        
        private string sSTIPSField;
        
        private string aLLOCATEDTIPSField;
        
        private string aDVANCEDEICField;
        
        private string dEPCAREBENEFITField;
        
        private string nONQUALPLANField;
        
        private Codes[] cODESField;
        
        private Other[] oTHERField;
        
        private BooleanType sTATUTORYField;
        
        private bool sTATUTORYFieldSpecified;
        
        private BooleanType rETIREMENTPLANField;
        
        private bool rETIREMENTPLANFieldSpecified;
        
        private BooleanType tHIRDPARTYSICKPAYField;
        
        private bool tHIRDPARTYSICKPAYFieldSpecified;
        
        private BooleanType dEFERREDCOMPField;
        
        private bool dEFERREDCOMPFieldSpecified;
        
        private StateInfo[] sTATEINFOField;
        
        private LocalInfo[] lOCALINFOField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Employer EMPLOYER {
            get {
                return eMPLOYERField;
            }
            set {
                eMPLOYERField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Employee EMPLOYEE {
            get {
                return eMPLOYEEField;
            }
            set {
                eMPLOYEEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string WAGES {
            get {
                return wAGESField;
            }
            set {
                wAGESField = value;
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
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string SSWAGES {
            get {
                return sSWAGESField;
            }
            set {
                sSWAGESField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string SSTAXWH {
            get {
                return sSTAXWHField;
            }
            set {
                sSTAXWHField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string MEDICAREWAGES {
            get {
                return mEDICAREWAGESField;
            }
            set {
                mEDICAREWAGESField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string MEDICARETAXWH {
            get {
                return mEDICARETAXWHField;
            }
            set {
                mEDICARETAXWHField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string SSTIPS {
            get {
                return sSTIPSField;
            }
            set {
                sSTIPSField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ALLOCATEDTIPS {
            get {
                return aLLOCATEDTIPSField;
            }
            set {
                aLLOCATEDTIPSField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ADVANCEDEIC {
            get {
                return aDVANCEDEICField;
            }
            set {
                aDVANCEDEICField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DEPCAREBENEFIT {
            get {
                return dEPCAREBENEFITField;
            }
            set {
                dEPCAREBENEFITField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string NONQUALPLAN {
            get {
                return nONQUALPLANField;
            }
            set {
                nONQUALPLANField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CODES", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Codes[] CODES {
            get {
                return cODESField;
            }
            set {
                cODESField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("OTHER", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Other[] OTHER {
            get {
                return oTHERField;
            }
            set {
                oTHERField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType STATUTORY {
            get {
                return sTATUTORYField;
            }
            set {
                sTATUTORYField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool STATUTORYSpecified {
            get {
                return sTATUTORYFieldSpecified;
            }
            set {
                sTATUTORYFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType RETIREMENTPLAN {
            get {
                return rETIREMENTPLANField;
            }
            set {
                rETIREMENTPLANField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RETIREMENTPLANSpecified {
            get {
                return rETIREMENTPLANFieldSpecified;
            }
            set {
                rETIREMENTPLANFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType THIRDPARTYSICKPAY {
            get {
                return tHIRDPARTYSICKPAYField;
            }
            set {
                tHIRDPARTYSICKPAYField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool THIRDPARTYSICKPAYSpecified {
            get {
                return tHIRDPARTYSICKPAYFieldSpecified;
            }
            set {
                tHIRDPARTYSICKPAYFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType DEFERREDCOMP {
            get {
                return dEFERREDCOMPField;
            }
            set {
                dEFERREDCOMPField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DEFERREDCOMPSpecified {
            get {
                return dEFERREDCOMPFieldSpecified;
            }
            set {
                dEFERREDCOMPFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("STATEINFO", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public StateInfo[] STATEINFO {
            get {
                return sTATEINFOField;
            }
            set {
                sTATEINFOField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("LOCALINFO", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public LocalInfo[] LOCALINFO {
            get {
                return lOCALINFOField;
            }
            set {
                lOCALINFOField = value;
            }
        }
    }
}