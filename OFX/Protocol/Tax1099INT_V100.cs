namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class Tax1099INT_V100 : AbstractTaxForm1099 {
        
        private string pAYERRTNField;
        
        private string iNTINCOMEField;
        
        private string eRLWITHPENField;
        
        private string iNTUSBNDTRSField;
        
        private string fEDTAXWHField;
        
        private string iNVESTEXPField;
        
        private string fORTAXPDField;
        
        private string fORCNTField;
        
        private PayerAddress pAYERADDRField;
        
        private string pAYERIDField;
        
        private RecurringAddress rECADDRField;
        
        private string rECIDField;
        
        private string rECACCTField;
        
        private BooleanType tINNOTField;
        
        private bool tINNOTFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string PAYERRTN {
            get {
                return pAYERRTNField;
            }
            set {
                pAYERRTNField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string INTINCOME {
            get {
                return iNTINCOMEField;
            }
            set {
                iNTINCOMEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ERLWITHPEN {
            get {
                return eRLWITHPENField;
            }
            set {
                eRLWITHPENField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string INTUSBNDTRS {
            get {
                return iNTUSBNDTRSField;
            }
            set {
                iNTUSBNDTRSField = value;
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
        public string INVESTEXP {
            get {
                return iNVESTEXPField;
            }
            set {
                iNVESTEXPField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string FORTAXPD {
            get {
                return fORTAXPDField;
            }
            set {
                fORTAXPDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string FORCNT {
            get {
                return fORCNTField;
            }
            set {
                fORCNTField = value;
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