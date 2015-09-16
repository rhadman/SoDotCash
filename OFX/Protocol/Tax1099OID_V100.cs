namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class Tax1099OID_V100 : AbstractTaxForm1099 {
        
        private string oRIGISDISCField;
        
        private string oTHERPERINTField;
        
        private string eRLWITHPENField;
        
        private string fEDTAXWHField;
        
        private string dESCRIPTIONField;
        
        private string oIDONUSTRESField;
        
        private string iNVESTEXPField;
        
        private PayerAddress pAYERADDRField;
        
        private string pAYERIDField;
        
        private RecurringAddress rECADDRField;
        
        private string rECIDField;
        
        private string rECACCTField;
        
        private BooleanType tINNOTField;
        
        private bool tINNOTFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ORIGISDISC {
            get {
                return this.oRIGISDISCField;
            }
            set {
                this.oRIGISDISCField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string OTHERPERINT {
            get {
                return this.oTHERPERINTField;
            }
            set {
                this.oTHERPERINTField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ERLWITHPEN {
            get {
                return this.eRLWITHPENField;
            }
            set {
                this.eRLWITHPENField = value;
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
        public string DESCRIPTION {
            get {
                return this.dESCRIPTIONField;
            }
            set {
                this.dESCRIPTIONField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string OIDONUSTRES {
            get {
                return this.oIDONUSTRESField;
            }
            set {
                this.oIDONUSTRESField = value;
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