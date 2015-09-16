namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class AccountInfoResponse {
        
        private string dTACCTUPField;
        
        private AccountInfo[] aCCTINFOField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DTACCTUP {
            get {
                return dTACCTUPField;
            }
            set {
                dTACCTUPField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ACCTINFO", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public AccountInfo[] ACCTINFO {
            get {
                return aCCTINFOField;
            }
            set {
                aCCTINFOField = value;
            }
        }
    }
}