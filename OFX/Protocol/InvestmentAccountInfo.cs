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
                return iNVACCTFROMField;
            }
            set {
                iNVACCTFROMField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public UsProductEnum USPRODUCTTYPE {
            get {
                return uSPRODUCTTYPEField;
            }
            set {
                uSPRODUCTTYPEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType CHECKING {
            get {
                return cHECKINGField;
            }
            set {
                cHECKINGField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ServiceStatusEnum SVCSTATUS {
            get {
                return sVCSTATUSField;
            }
            set {
                sVCSTATUSField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public InvestmentAccountEnum INVACCTTYPE {
            get {
                return iNVACCTTYPEField;
            }
            set {
                iNVACCTTYPEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool INVACCTTYPESpecified {
            get {
                return iNVACCTTYPEFieldSpecified;
            }
            set {
                iNVACCTTYPEFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string OPTIONLEVEL {
            get {
                return oPTIONLEVELField;
            }
            set {
                oPTIONLEVELField = value;
            }
        }
    }
}