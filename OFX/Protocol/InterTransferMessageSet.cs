namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class InterTransferMessageSet : AbstractMessageSet {
        
        private InterTransferMessageSetV1 iNTERXFERMSGSETV1Field;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public InterTransferMessageSetV1 INTERXFERMSGSETV1 {
            get {
                return iNTERXFERMSGSETV1Field;
            }
            set {
                iNTERXFERMSGSETV1Field = value;
            }
        }
    }
}