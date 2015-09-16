namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class LoanClosing {
        
        private string fITIDField;
        
        private string dTOPENField;
        
        private string dTCLOSEField;
        
        private string dTNEXTField;
        
        private string bALOPENField;
        
        private PrincipalBalanceType pRINBALField;
        
        private LoanInterestType lOANINTField;
        
        private LoanRateType lOANRATEField;
        
        private EstimatedPayoff eSTPAYOFFField;
        
        private string bALLOONAMTField;
        
        private LoanPaymentAmount lOANPMTField;
        
        private string lOANRMNPMTSField;
        
        private Balance[] bALLISTField;
        
        private EscrowBalance eSCRWBALField;
        
        private string dTPOSTSTARTField;
        
        private string dTPOSTENDField;
        
        private string mKTGINFOField;
        
        private ImageData iMAGEDATAField;
        
        private Currency itemField;
        
        private ItemChoiceType11 itemElementNameField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string FITID {
            get {
                return this.fITIDField;
            }
            set {
                this.fITIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DTOPEN {
            get {
                return this.dTOPENField;
            }
            set {
                this.dTOPENField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DTCLOSE {
            get {
                return this.dTCLOSEField;
            }
            set {
                this.dTCLOSEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DTNEXT {
            get {
                return this.dTNEXTField;
            }
            set {
                this.dTNEXTField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string BALOPEN {
            get {
                return this.bALOPENField;
            }
            set {
                this.bALOPENField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PrincipalBalanceType PRINBAL {
            get {
                return this.pRINBALField;
            }
            set {
                this.pRINBALField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public LoanInterestType LOANINT {
            get {
                return this.lOANINTField;
            }
            set {
                this.lOANINTField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public LoanRateType LOANRATE {
            get {
                return this.lOANRATEField;
            }
            set {
                this.lOANRATEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public EstimatedPayoff ESTPAYOFF {
            get {
                return this.eSTPAYOFFField;
            }
            set {
                this.eSTPAYOFFField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string BALLOONAMT {
            get {
                return this.bALLOONAMTField;
            }
            set {
                this.bALLOONAMTField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public LoanPaymentAmount LOANPMT {
            get {
                return this.lOANPMTField;
            }
            set {
                this.lOANPMTField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string LOANRMNPMTS {
            get {
                return this.lOANRMNPMTSField;
            }
            set {
                this.lOANRMNPMTSField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute("BAL", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        public Balance[] BALLIST {
            get {
                return this.bALLISTField;
            }
            set {
                this.bALLISTField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public EscrowBalance ESCRWBAL {
            get {
                return this.eSCRWBALField;
            }
            set {
                this.eSCRWBALField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DTPOSTSTART {
            get {
                return this.dTPOSTSTARTField;
            }
            set {
                this.dTPOSTSTARTField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DTPOSTEND {
            get {
                return this.dTPOSTENDField;
            }
            set {
                this.dTPOSTENDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string MKTGINFO {
            get {
                return this.mKTGINFOField;
            }
            set {
                this.mKTGINFOField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ImageData IMAGEDATA {
            get {
                return this.iMAGEDATAField;
            }
            set {
                this.iMAGEDATAField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CURRENCY", typeof(Currency), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("ORIGCURRENCY", typeof(Currency), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public Currency Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType11 ItemElementName {
            get {
                return this.itemElementNameField;
            }
            set {
                this.itemElementNameField = value;
            }
        }
    }
}