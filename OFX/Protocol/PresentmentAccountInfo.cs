namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class PresentmentAccountInfo : AbstractAccountInfo {
        
        private PresentmentAccount pRESACCTFROMField;
        
        private ServiceStatus2Enum sVCSTATUSField;
        
        private string rEASONField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PresentmentAccount PRESACCTFROM {
            get {
                return this.pRESACCTFROMField;
            }
            set {
                this.pRESACCTFROMField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ServiceStatus2Enum SVCSTATUS {
            get {
                return this.sVCSTATUSField;
            }
            set {
                this.sVCSTATUSField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string REASON {
            get {
                return this.rEASONField;
            }
            set {
                this.rEASONField = value;
            }
        }
    }
}