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
                return pARVALUEField;
            }
            set {
                pARVALUEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public DebtEnum DEBTTYPE {
            get {
                return dEBTTYPEField;
            }
            set {
                dEBTTYPEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public DebtClassEnum DEBTCLASS {
            get {
                return dEBTCLASSField;
            }
            set {
                dEBTCLASSField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DEBTCLASSSpecified {
            get {
                return dEBTCLASSFieldSpecified;
            }
            set {
                dEBTCLASSFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string COUPONRT {
            get {
                return cOUPONRTField;
            }
            set {
                cOUPONRTField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DTCOUPON {
            get {
                return dTCOUPONField;
            }
            set {
                dTCOUPONField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public CouponFrequencyEnum COUPONFREQ {
            get {
                return cOUPONFREQField;
            }
            set {
                cOUPONFREQField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool COUPONFREQSpecified {
            get {
                return cOUPONFREQFieldSpecified;
            }
            set {
                cOUPONFREQFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string CALLPRICE {
            get {
                return cALLPRICEField;
            }
            set {
                cALLPRICEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string YIELDTOCALL {
            get {
                return yIELDTOCALLField;
            }
            set {
                yIELDTOCALLField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DTCALL {
            get {
                return dTCALLField;
            }
            set {
                dTCALLField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public CallTypeEnum CALLTYPE {
            get {
                return cALLTYPEField;
            }
            set {
                cALLTYPEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CALLTYPESpecified {
            get {
                return cALLTYPEFieldSpecified;
            }
            set {
                cALLTYPEFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string YIELDTOMAT {
            get {
                return yIELDTOMATField;
            }
            set {
                yIELDTOMATField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DTMAT {
            get {
                return dTMATField;
            }
            set {
                dTMATField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public AssetClassEnum ASSETCLASS {
            get {
                return aSSETCLASSField;
            }
            set {
                aSSETCLASSField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ASSETCLASSSpecified {
            get {
                return aSSETCLASSFieldSpecified;
            }
            set {
                aSSETCLASSFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string FIASSETCLASS {
            get {
                return fIASSETCLASSField;
            }
            set {
                fIASSETCLASSField = value;
            }
        }
    }
}