namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class Tax1099MISC_V100 : AbstractTaxForm1099 {
        
        private string rENTSField;
        
        private string rOYALTIESField;
        
        private string oTHERINCOMEField;
        
        private string fEDTAXWHField;
        
        private string fISHBOATPROField;
        
        private string mEDHEALTHPAYField;
        
        private string nONEMPCOMPField;
        
        private string sUBPMTSField;
        
        private BooleanType pAYER5KSALESField;
        
        private bool pAYER5KSALESFieldSpecified;
        
        private string cROPINSPROField;
        
        private object[] itemsField;
        
        private ItemsChoiceType3[] itemsElementNameField;
        
        private string gROSSATTORField;
        
        private string eXCSGLDNField;
        
        private string sEC409ADEFERRALSField;
        
        private string sEC409AINCOMEField;
        
        private PayerAddress pAYERADDRField;
        
        private string pAYERIDField;
        
        private RecurringAddress rECADDRField;
        
        private string rECIDField;
        
        private string rECACCTField;
        
        private BooleanType tINNOTField;
        
        private bool tINNOTFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string RENTS {
            get {
                return this.rENTSField;
            }
            set {
                this.rENTSField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ROYALTIES {
            get {
                return this.rOYALTIESField;
            }
            set {
                this.rOYALTIESField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string OTHERINCOME {
            get {
                return this.oTHERINCOMEField;
            }
            set {
                this.oTHERINCOMEField = value;
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
        public string FISHBOATPRO {
            get {
                return this.fISHBOATPROField;
            }
            set {
                this.fISHBOATPROField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string MEDHEALTHPAY {
            get {
                return this.mEDHEALTHPAYField;
            }
            set {
                this.mEDHEALTHPAYField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string NONEMPCOMP {
            get {
                return this.nONEMPCOMPField;
            }
            set {
                this.nONEMPCOMPField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string SUBPMTS {
            get {
                return this.sUBPMTSField;
            }
            set {
                this.sUBPMTSField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType PAYER5KSALES {
            get {
                return this.pAYER5KSALESField;
            }
            set {
                this.pAYER5KSALESField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PAYER5KSALESSpecified {
            get {
                return this.pAYER5KSALESFieldSpecified;
            }
            set {
                this.pAYER5KSALESFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string CROPINSPRO {
            get {
                return this.cROPINSPROField;
            }
            set {
                this.cROPINSPROField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ADDLSTTAXWHAGG", typeof(AdditionalStateTaxWithheldAggregate), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("PAYERSTATE", typeof(string), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("PAYERSTID", typeof(string), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("STINCOME", typeof(string), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("STTAXWH", typeof(string), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public object[] Items {
            get {
                return this.itemsField;
            }
            set {
                this.itemsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemsChoiceType3[] ItemsElementName {
            get {
                return this.itemsElementNameField;
            }
            set {
                this.itemsElementNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string GROSSATTOR {
            get {
                return this.gROSSATTORField;
            }
            set {
                this.gROSSATTORField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string EXCSGLDN {
            get {
                return this.eXCSGLDNField;
            }
            set {
                this.eXCSGLDNField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string SEC409ADEFERRALS {
            get {
                return this.sEC409ADEFERRALSField;
            }
            set {
                this.sEC409ADEFERRALSField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string SEC409AINCOME {
            get {
                return this.sEC409AINCOMEField;
            }
            set {
                this.sEC409AINCOMEField = value;
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