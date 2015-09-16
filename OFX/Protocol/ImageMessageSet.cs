namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class ImageMessageSet : AbstractMessageSet {
        
        private ImageMessageSetV1 iMAGEMSGSETV1Field;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ImageMessageSetV1 IMAGEMSGSETV1 {
            get {
                return iMAGEMSGSETV1Field;
            }
            set {
                iMAGEMSGSETV1Field = value;
            }
        }
    }
}