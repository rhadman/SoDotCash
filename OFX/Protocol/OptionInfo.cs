namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class OptionInfo : AbstractSecurityInfo {
        
        private OptionTypeEnum oPTTYPEField;
        
        private string sTRIKEPRICEField;
        
        private string dTEXPIREField;
        
        private string sHPERCTRCTField;
        
        private SecurityId sECIDField;
        
        private AssetClassEnum aSSETCLASSField;
        
        private bool aSSETCLASSFieldSpecified;
        
        private string fIASSETCLASSField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public OptionTypeEnum OPTTYPE {
            get {
                return this.oPTTYPEField;
            }
            set {
                this.oPTTYPEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string STRIKEPRICE {
            get {
                return this.sTRIKEPRICEField;
            }
            set {
                this.sTRIKEPRICEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DTEXPIRE {
            get {
                return this.dTEXPIREField;
            }
            set {
                this.dTEXPIREField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string SHPERCTRCT {
            get {
                return this.sHPERCTRCTField;
            }
            set {
                this.sHPERCTRCTField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SecurityId SECID {
            get {
                return this.sECIDField;
            }
            set {
                this.sECIDField = value;
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