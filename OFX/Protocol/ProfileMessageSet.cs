namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class ProfileMessageSet : AbstractMessageSet {
        
        private ProfileMessageSetV1 pROFMSGSETV1Field;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ProfileMessageSetV1 PROFMSGSETV1 {
            get {
                return pROFMSGSETV1Field;
            }
            set {
                pROFMSGSETV1Field = value;
            }
        }
    }
}