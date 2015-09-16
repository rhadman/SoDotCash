namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class JournalFund : AbstractInvestmentTransaction {
        
        private SubAccountEnum sUBACCTTOField;
        
        private SubAccountEnum sUBACCTFROMField;
        
        private string tOTALField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SubAccountEnum SUBACCTTO {
            get {
                return sUBACCTTOField;
            }
            set {
                sUBACCTTOField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SubAccountEnum SUBACCTFROM {
            get {
                return sUBACCTFROMField;
            }
            set {
                sUBACCTFROMField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string TOTAL {
            get {
                return tOTALField;
            }
            set {
                tOTALField = value;
            }
        }
    }
}