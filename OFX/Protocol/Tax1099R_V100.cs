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
                return gROSSDISTField;
            }
            set {
                gROSSDISTField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string TAXAMT {
            get {
                return tAXAMTField;
            }
            set {
                tAXAMTField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType TAXAMTND {
            get {
                return tAXAMTNDField;
            }
            set {
                tAXAMTNDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TAXAMTNDSpecified {
            get {
                return tAXAMTNDFieldSpecified;
            }
            set {
                tAXAMTNDFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType TOTALDIST {
            get {
                return tOTALDISTField;
            }
            set {
                tOTALDISTField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TOTALDISTSpecified {
            get {
                return tOTALDISTFieldSpecified;
            }
            set {
                tOTALDISTFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string CAPGAIN {
            get {
                return cAPGAINField;
            }
            set {
                cAPGAINField = value;
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
        public string EMPCONTINS {
            get {
                return eMPCONTINSField;
            }
            set {
                eMPCONTINSField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string NETUNAPEMP {
            get {
                return nETUNAPEMPField;
            }
            set {
                nETUNAPEMPField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DISTCODE", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[] DISTCODE {
            get {
                return dISTCODEField;
            }
            set {
                dISTCODEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType IRASEPSIMP {
            get {
                return iRASEPSIMPField;
            }
            set {
                iRASEPSIMPField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IRASEPSIMPSpecified {
            get {
                return iRASEPSIMPFieldSpecified;
            }
            set {
                iRASEPSIMPFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ANNCTRCTDIST {
            get {
                return aNNCTRCTDISTField;
            }
            set {
                aNNCTRCTDISTField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ANNCTRCTPER {
            get {
                return aNNCTRCTPERField;
            }
            set {
                aNNCTRCTPERField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string PERTOTDIST {
            get {
                return pERTOTDISTField;
            }
            set {
                pERTOTDISTField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string TOTEMPCONT {
            get {
                return tOTEMPCONTField;
            }
            set {
                tOTEMPCONTField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("STTAXWHAGG", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public StateTaxWithheldAggregate[] STTAXWHAGG {
            get {
                return sTTAXWHAGGField;
            }
            set {
                sTTAXWHAGGField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("LCLTAXWHAGG", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public LocalTaxWithheldAggregate[] LCLTAXWHAGG {
            get {
                return lCLTAXWHAGGField;
            }
            set {
                lCLTAXWHAGGField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PayerAddress PAYERADDR {
            get {
                return pAYERADDRField;
            }
            set {
                pAYERADDRField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string PAYERID {
            get {
                return pAYERIDField;
            }
            set {
                pAYERIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public RecurringAddress RECADDR {
            get {
                return rECADDRField;
            }
            set {
                rECADDRField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string RECID {
            get {
                return rECIDField;
            }
            set {
                rECIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string RECACCT {
            get {
                return rECACCTField;
            }
            set {
                rECACCTField = value;
            }
        }
    }
}