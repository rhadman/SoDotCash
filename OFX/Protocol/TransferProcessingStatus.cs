namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class TransferProcessingStatus {
        
        private TransferStatusEnum xFERPRCCODEField;
        
        private string dTXFERPRCField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public TransferStatusEnum XFERPRCCODE {
            get {
                return xFERPRCCODEField;
            }
            set {
                xFERPRCCODEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DTXFERPRC {
            get {
                return dTXFERPRCField;
            }
            set {
                dTXFERPRCField = value;
            }
        }
    }
}