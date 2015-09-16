namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class IntraModResponse : AbstractIntraResponse {
        
        private string sRVRTIDField;
        
        private TransferInfo xFERINFOField;
        
        private TransferProcessingStatus xFERPRCSTSField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string SRVRTID {
            get {
                return sRVRTIDField;
            }
            set {
                sRVRTIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public TransferInfo XFERINFO {
            get {
                return xFERINFOField;
            }
            set {
                xFERINFOField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public TransferProcessingStatus XFERPRCSTS {
            get {
                return xFERPRCSTSField;
            }
            set {
                xFERPRCSTSField = value;
            }
        }
    }
}