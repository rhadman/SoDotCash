namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class Tax1099DIV_V100 : AbstractTaxForm1099 {
        
        private string oRDDIVField;
        
        private string qUALIFIEDDIVField;
        
        private string tOTCAPGAINField;
        
        private string pOSTMAY5CAPGAINField;
        
        private string p28GAINField;
        
        private string uNRECSEC1250Field;
        
        private string sEC1202Field;
        
        private string qUAL5YEARField;
        
        private string nONTAXDISTField;
        
        private string fEDTAXWHField;
        
        private string iNVESTEXPField;
        
        private string fORTAXPDField;
        
        private string fORCNTField;
        
        private string cASHLIQField;
        
        private string nONCASHLIQField;
        
        private PayerAddress pAYERADDRField;
        
        private string pAYERIDField;
        
        private RecurringAddress rECADDRField;
        
        private string rECIDField;
        
        private string rECACCTField;
        
        private BooleanType tINNOTField;
        
        private bool tINNOTFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ORDDIV {
            get {
                return this.oRDDIVField;
            }
            set {
                this.oRDDIVField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string QUALIFIEDDIV {
            get {
                return this.qUALIFIEDDIVField;
            }
            set {
                this.qUALIFIEDDIVField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string TOTCAPGAIN {
            get {
                return this.tOTCAPGAINField;
            }
            set {
                this.tOTCAPGAINField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string POSTMAY5CAPGAIN {
            get {
                return this.pOSTMAY5CAPGAINField;
            }
            set {
                this.pOSTMAY5CAPGAINField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string P28GAIN {
            get {
                return this.p28GAINField;
            }
            set {
                this.p28GAINField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string UNRECSEC1250 {
            get {
                return this.uNRECSEC1250Field;
            }
            set {
                this.uNRECSEC1250Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string SEC1202 {
            get {
                return this.sEC1202Field;
            }
            set {
                this.sEC1202Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string QUAL5YEAR {
            get {
                return this.qUAL5YEARField;
            }
            set {
                this.qUAL5YEARField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string NONTAXDIST {
            get {
                return this.nONTAXDISTField;
            }
            set {
                this.nONTAXDISTField = value;
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
        public string INVESTEXP {
            get {
                return this.iNVESTEXPField;
            }
            set {
                this.iNVESTEXPField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string FORTAXPD {
            get {
                return this.fORTAXPDField;
            }
            set {
                this.fORTAXPDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string FORCNT {
            get {
                return this.fORCNTField;
            }
            set {
                this.fORCNTField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string CASHLIQ {
            get {
                return this.cASHLIQField;
            }
            set {
                this.cASHLIQField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string NONCASHLIQ {
            get {
                return this.nONCASHLIQField;
            }
            set {
                this.nONCASHLIQField = value;
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
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType TINNOT {
            get {
                return this.tINNOTField;
            }
            set {
                this.tINNOTField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TINNOTSpecified {
            get {
                return this.tINNOTFieldSpecified;
            }
            set {
                this.tINNOTFieldSpecified = value;
            }
        }
    }
}