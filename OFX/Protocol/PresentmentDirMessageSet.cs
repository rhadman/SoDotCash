namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class PresentmentDirMessageSet : AbstractMessageSet {
        
        private PresentmentDirMessageSetV1[] pRESDIRMSGSETV1Field;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PRESDIRMSGSETV1", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PresentmentDirMessageSetV1[] PRESDIRMSGSETV1 {
            get {
                return pRESDIRMSGSETV1Field;
            }
            set {
                pRESDIRMSGSETV1Field = value;
            }
        }
    }
}