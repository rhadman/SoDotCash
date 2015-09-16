namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class PresentmentDlvMessageSet : AbstractMessageSet {
        
        private PresentmentDlvMessageSetV1[] pRESDLVMSGSETV1Field;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PRESDLVMSGSETV1", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PresentmentDlvMessageSetV1[] PRESDLVMSGSETV1 {
            get {
                return pRESDLVMSGSETV1Field;
            }
            set {
                pRESDLVMSGSETV1Field = value;
            }
        }
    }
}