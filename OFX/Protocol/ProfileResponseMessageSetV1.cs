namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class ProfileResponseMessageSetV1 : AbstractResponseMessageSet {
        
        private ProfileTransactionResponse[] pROFTRNRSField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PROFTRNRS", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ProfileTransactionResponse[] PROFTRNRS {
            get {
                return pROFTRNRSField;
            }
            set {
                pROFTRNRSField = value;
            }
        }
    }
}