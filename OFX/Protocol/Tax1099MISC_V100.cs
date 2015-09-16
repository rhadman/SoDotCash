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
                return rENTSField;
            }
            set {
                rENTSField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ROYALTIES {
            get {
                return rOYALTIESField;
            }
            set {
                rOYALTIESField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string OTHERINCOME {
            get {
                return oTHERINCOMEField;
            }
            set {
                oTHERINCOMEField = value;
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
        public string FISHBOATPRO {
            get {
                return fISHBOATPROField;
            }
            set {
                fISHBOATPROField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string MEDHEALTHPAY {
            get {
                return mEDHEALTHPAYField;
            }
            set {
                mEDHEALTHPAYField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string NONEMPCOMP {
            get {
                return nONEMPCOMPField;
            }
            set {
                nONEMPCOMPField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string SUBPMTS {
            get {
                return sUBPMTSField;
            }
            set {
                sUBPMTSField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType PAYER5KSALES {
            get {
                return pAYER5KSALESField;
            }
            set {
                pAYER5KSALESField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PAYER5KSALESSpecified {
            get {
                return pAYER5KSALESFieldSpecified;
            }
            set {
                pAYER5KSALESFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string CROPINSPRO {
            get {
                return cROPINSPROField;
            }
            set {
                cROPINSPROField = value;
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
                return itemsField;
            }
            set {
                itemsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemsChoiceType3[] ItemsElementName {
            get {
                return itemsElementNameField;
            }
            set {
                itemsElementNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string GROSSATTOR {
            get {
                return gROSSATTORField;
            }
            set {
                gROSSATTORField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string EXCSGLDN {
            get {
                return eXCSGLDNField;
            }
            set {
                eXCSGLDNField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string SEC409ADEFERRALS {
            get {
                return sEC409ADEFERRALSField;
            }
            set {
                sEC409ADEFERRALSField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string SEC409AINCOME {
            get {
                return sEC409AINCOMEField;
            }
            set {
                sEC409AINCOMEField = value;
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
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType TINNOT {
            get {
                return tINNOTField;
            }
            set {
                tINNOTField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TINNOTSpecified {
            get {
                return tINNOTFieldSpecified;
            }
            set {
                tINNOTFieldSpecified = value;
            }
        }
    }
}