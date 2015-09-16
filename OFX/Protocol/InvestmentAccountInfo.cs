namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class InvestmentAccountInfo : AbstractAccountInfo {
        
        private InvestmentAccount iNVACCTFROMField;
        
        private UsProductEnum uSPRODUCTTYPEField;
        
        private BooleanType cHECKINGField;
        
        private ServiceStatusEnum sVCSTATUSField;
        
        private InvestmentAccountEnum iNVACCTTYPEField;
        
        private bool iNVACCTTYPEFieldSpecified;
        
        private string oPTIONLEVELField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public InvestmentAccount INVACCTFROM {
            get {
                return this.iNVACCTFROMField;
            }
            set {
                this.iNVACCTFROMField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public UsProductEnum USPRODUCTTYPE {
            get {
                return this.uSPRODUCTTYPEField;
            }
            set {
                this.uSPRODUCTTYPEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType CHECKING {
            get {
                return this.cHECKINGField;
            }
            set {
                this.cHECKINGField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ServiceStatusEnum SVCSTATUS {
            get {
                return this.sVCSTATUSField;
            }
            set {
                this.sVCSTATUSField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public InvestmentAccountEnum INVACCTTYPE {
            get {
                return this.iNVACCTTYPEField;
            }
            set {
                this.iNVACCTTYPEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool INVACCTTYPESpecified {
            get {
                return this.iNVACCTTYPEFieldSpecified;
            }
            set {
                this.iNVACCTTYPEFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string OPTIONLEVEL {
            get {
                return this.oPTIONLEVELField;
            }
            set {
                this.oPTIONLEVELField = value;
            }
        }
    }
}