namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class SecurityListResponseMessageSetV1 : AbstractResponseMessageSet {
        
        private SecurityListTransactionResponse[] sECLISTTRNRSField;
        
        private SecurityList sECLISTField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SECLISTTRNRS", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SecurityListTransactionResponse[] SECLISTTRNRS {
            get {
                return sECLISTTRNRSField;
            }
            set {
                sECLISTTRNRSField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SecurityList SECLIST {
            get {
                return sECLISTField;
            }
            set {
                sECLISTField = value;
            }
        }
    }
}