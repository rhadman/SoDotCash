namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class ChangeUserInfoSyncResponse : AbstractSyncResponse {
        
        private ChangeUserInfoTransactionResponse[] cHGUSERINFOTRNRSField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CHGUSERINFOTRNRS", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ChangeUserInfoTransactionResponse[] CHGUSERINFOTRNRS {
            get {
                return cHGUSERINFOTRNRSField;
            }
            set {
                cHGUSERINFOTRNRSField = value;
            }
        }
    }
}