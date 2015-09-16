namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class SecurityListRequestMessageSetV1 : AbstractRequestMessageSet {
        
        private SecurityListTransactionRequest[] sECLISTTRNRQField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SECLISTTRNRQ", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SecurityListTransactionRequest[] SECLISTTRNRQ {
            get {
                return sECLISTTRNRQField;
            }
            set {
                sECLISTTRNRQField = value;
            }
        }
    }
}