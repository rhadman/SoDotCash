namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class DebtInfo : AbstractSecurityInfo {
        
        private string pARVALUEField;
        
        private DebtEnum dEBTTYPEField;
        
        private DebtClassEnum dEBTCLASSField;
        
        private bool dEBTCLASSFieldSpecified;
        
        private string cOUPONRTField;
        
        private string dTCOUPONField;
        
        private CouponFrequencyEnum cOUPONFREQField;
        
        private bool cOUPONFREQFieldSpecified;
        
        private string cALLPRICEField;
        
        private string yIELDTOCALLField;
        
        private string dTCALLField;
        
        private CallTypeEnum cALLTYPEField;
        
        private bool cALLTYPEFieldSpecified;
        
        private string yIELDTOMATField;
        
        private string dTMATField;
        
        private AssetClassEnum aSSETCLASSField;
        
        private bool aSSETCLASSFieldSpecified;
        
        private string fIASSETCLASSField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string PARVALUE {
            get {
                return this.pARVALUEField;
            }
            set {
                this.pARVALUEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public DebtEnum DEBTTYPE {
            get {
                return this.dEBTTYPEField;
            }
            set {
                this.dEBTTYPEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public DebtClassEnum DEBTCLASS {
            get {
                return this.dEBTCLASSField;
            }
            set {
                this.dEBTCLASSField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DEBTCLASSSpecified {
            get {
                return this.dEBTCLASSFieldSpecified;
            }
            set {
                this.dEBTCLASSFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string COUPONRT {
            get {
                return this.cOUPONRTField;
            }
            set {
                this.cOUPONRTField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DTCOUPON {
            get {
                return this.dTCOUPONField;
            }
            set {
                this.dTCOUPONField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public CouponFrequencyEnum COUPONFREQ {
            get {
                return this.cOUPONFREQField;
            }
            set {
                this.cOUPONFREQField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool COUPONFREQSpecified {
            get {
                return this.cOUPONFREQFieldSpecified;
            }
            set {
                this.cOUPONFREQFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string CALLPRICE {
            get {
                return this.cALLPRICEField;
            }
            set {
                this.cALLPRICEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string YIELDTOCALL {
            get {
                return this.yIELDTOCALLField;
            }
            set {
                this.yIELDTOCALLField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DTCALL {
            get {
                return this.dTCALLField;
            }
            set {
                this.dTCALLField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public CallTypeEnum CALLTYPE {
            get {
                return this.cALLTYPEField;
            }
            set {
                this.cALLTYPEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CALLTYPESpecified {
            get {
                return this.cALLTYPEFieldSpecified;
            }
            set {
                this.cALLTYPEFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string YIELDTOMAT {
            get {
                return this.yIELDTOMATField;
            }
            set {
                this.yIELDTOMATField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DTMAT {
            get {
                return this.dTMATField;
            }
            set {
                this.dTMATField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public AssetClassEnum ASSETCLASS {
            get {
                return this.aSSETCLASSField;
            }
            set {
                this.aSSETCLASSField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ASSETCLASSSpecified {
            get {
                return this.aSSETCLASSFieldSpecified;
            }
            set {
                this.aSSETCLASSFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string FIASSETCLASS {
            get {
                return this.fIASSETCLASSField;
            }
            set {
                this.fIASSETCLASSField = value;
            }
        }
    }
}