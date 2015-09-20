namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class WireTransferMessageSet : AbstractMessageSet {
        
        private WireTransferMessageSetV1 wIREXFERMSGSETV1Field;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public WireTransferMessageSetV1 WIREXFERMSGSETV1 {
            get {
                return wIREXFERMSGSETV1Field;
            }
            set {
                wIREXFERMSGSETV1Field = value;
            }
        }
    }
}