namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class Tax1099R_V100 : AbstractTaxForm1099 {
        
        private string gROSSDISTField;
        
        private string tAXAMTField;
        
        private BooleanType tAXAMTNDField;
        
        private bool tAXAMTNDFieldSpecified;
        
        private BooleanType tOTALDISTField;
        
        private bool tOTALDISTFieldSpecified;
        
        private string cAPGAINField;
        
        private string fEDTAXWHField;
        
        private string eMPCONTINSField;
        
        private string nETUNAPEMPField;
        
        private string[] dISTCODEField;
        
        private BooleanType iRASEPSIMPField;
        
        private bool iRASEPSIMPFieldSpecified;
        
        private string aNNCTRCTDISTField;
        
        private string aNNCTRCTPERField;
        
        private string pERTOTDISTField;
        
        private string tOTEMPCONTField;
        
        private StateTaxWithheldAggregate[] sTTAXWHAGGField;
        
        private LocalTaxWithheldAggregate[] lCLTAXWHAGGField;
        
        private PayerAddress pAYERADDRField;
        
        private string pAYERIDField;
        
        private RecurringAddress rECADDRField;
        
        private string rECIDField;
        
        private string rECACCTField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string GROSSDIST {
            get {
                return this.gROSSDISTField;
            }
            set {
                this.gROSSDISTField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string TAXAMT {
            get {
                return this.tAXAMTField;
            }
            set {
                this.tAXAMTField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType TAXAMTND {
            get {
                return this.tAXAMTNDField;
            }
            set {
                this.tAXAMTNDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TAXAMTNDSpecified {
            get {
                return this.tAXAMTNDFieldSpecified;
            }
            set {
                this.tAXAMTNDFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType TOTALDIST {
            get {
                return this.tOTALDISTField;
            }
            set {
                this.tOTALDISTField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TOTALDISTSpecified {
            get {
                return this.tOTALDISTFieldSpecified;
            }
            set {
                this.tOTALDISTFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string CAPGAIN {
            get {
                return this.cAPGAINField;
            }
            set {
                this.cAPGAINField = value;
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
        public string EMPCONTINS {
            get {
                return this.eMPCONTINSField;
            }
            set {
                this.eMPCONTINSField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string NETUNAPEMP {
            get {
                return this.nETUNAPEMPField;
            }
            set {
                this.nETUNAPEMPField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DISTCODE", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[] DISTCODE {
            get {
                return this.dISTCODEField;
            }
            set {
                this.dISTCODEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType IRASEPSIMP {
            get {
                return this.iRASEPSIMPField;
            }
            set {
                this.iRASEPSIMPField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IRASEPSIMPSpecified {
            get {
                return this.iRASEPSIMPFieldSpecified;
            }
            set {
                this.iRASEPSIMPFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ANNCTRCTDIST {
            get {
                return this.aNNCTRCTDISTField;
            }
            set {
                this.aNNCTRCTDISTField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ANNCTRCTPER {
            get {
                return this.aNNCTRCTPERField;
            }
            set {
                this.aNNCTRCTPERField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string PERTOTDIST {
            get {
                return this.pERTOTDISTField;
            }
            set {
                this.pERTOTDISTField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string TOTEMPCONT {
            get {
                return this.tOTEMPCONTField;
            }
            set {
                this.tOTEMPCONTField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("STTAXWHAGG", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public StateTaxWithheldAggregate[] STTAXWHAGG {
            get {
                return this.sTTAXWHAGGField;
            }
            set {
                this.sTTAXWHAGGField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("LCLTAXWHAGG", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public LocalTaxWithheldAggregate[] LCLTAXWHAGG {
            get {
                return this.lCLTAXWHAGGField;
            }
            set {
                this.lCLTAXWHAGGField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PayerAddress PAYERADDR {
            get {
                return this.pAYERADDRField;
            }
            set {
                this.pAYERADDRField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string PAYERID {
            get {
                return this.pAYERIDField;
            }
            set {
                this.pAYERIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public RecurringAddress RECADDR {
            get {
                return this.rECADDRField;
            }
            set {
                this.rECADDRField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string RECID {
            get {
                return this.rECIDField;
            }
            set {
                this.rECIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string RECACCT {
            get {
                return this.rECACCTField;
            }
            set {
                this.rECACCTField = value;
            }
        }
    }
}