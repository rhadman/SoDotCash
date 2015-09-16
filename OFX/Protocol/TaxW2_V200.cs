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
                return this.eMPLOYERField;
            }
            set {
                this.eMPLOYERField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Employee EMPLOYEE {
            get {
                return this.eMPLOYEEField;
            }
            set {
                this.eMPLOYEEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string WAGES {
            get {
                return this.wAGESField;
            }
            set {
                this.wAGESField = value;
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
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string SSWAGES {
            get {
                return this.sSWAGESField;
            }
            set {
                this.sSWAGESField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string SSTAXWH {
            get {
                return this.sSTAXWHField;
            }
            set {
                this.sSTAXWHField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string MEDICAREWAGES {
            get {
                return this.mEDICAREWAGESField;
            }
            set {
                this.mEDICAREWAGESField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string MEDICARETAXWH {
            get {
                return this.mEDICARETAXWHField;
            }
            set {
                this.mEDICARETAXWHField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string SSTIPS {
            get {
                return this.sSTIPSField;
            }
            set {
                this.sSTIPSField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ALLOCATEDTIPS {
            get {
                return this.aLLOCATEDTIPSField;
            }
            set {
                this.aLLOCATEDTIPSField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ADVANCEDEIC {
            get {
                return this.aDVANCEDEICField;
            }
            set {
                this.aDVANCEDEICField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DEPCAREBENEFIT {
            get {
                return this.dEPCAREBENEFITField;
            }
            set {
                this.dEPCAREBENEFITField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string NONQUALPLAN {
            get {
                return this.nONQUALPLANField;
            }
            set {
                this.nONQUALPLANField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CODES", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Codes[] CODES {
            get {
                return this.cODESField;
            }
            set {
                this.cODESField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("OTHER", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Other[] OTHER {
            get {
                return this.oTHERField;
            }
            set {
                this.oTHERField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType STATUTORY {
            get {
                return this.sTATUTORYField;
            }
            set {
                this.sTATUTORYField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool STATUTORYSpecified {
            get {
                return this.sTATUTORYFieldSpecified;
            }
            set {
                this.sTATUTORYFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType RETIREMENTPLAN {
            get {
                return this.rETIREMENTPLANField;
            }
            set {
                this.rETIREMENTPLANField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RETIREMENTPLANSpecified {
            get {
                return this.rETIREMENTPLANFieldSpecified;
            }
            set {
                this.rETIREMENTPLANFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType THIRDPARTYSICKPAY {
            get {
                return this.tHIRDPARTYSICKPAYField;
            }
            set {
                this.tHIRDPARTYSICKPAYField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool THIRDPARTYSICKPAYSpecified {
            get {
                return this.tHIRDPARTYSICKPAYFieldSpecified;
            }
            set {
                this.tHIRDPARTYSICKPAYFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType DEFERREDCOMP {
            get {
                return this.dEFERREDCOMPField;
            }
            set {
                this.dEFERREDCOMPField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DEFERREDCOMPSpecified {
            get {
                return this.dEFERREDCOMPFieldSpecified;
            }
            set {
                this.dEFERREDCOMPFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("STATEINFO", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public StateInfo[] STATEINFO {
            get {
                return this.sTATEINFOField;
            }
            set {
                this.sTATEINFOField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("LOCALINFO", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public LocalInfo[] LOCALINFO {
            get {
                return this.lOCALINFOField;
            }
            set {
                this.lOCALINFOField = value;
            }
        }
    }
}