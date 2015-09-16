namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class ImageProfile {
        
        private BooleanType cLOSINGIMGAVAILField;
        
        private BooleanType tRANIMGAVAILField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType CLOSINGIMGAVAIL {
            get {
                return cLOSINGIMGAVAILField;
            }
            set {
                cLOSINGIMGAVAILField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType TRANIMGAVAIL {
            get {
                return tRANIMGAVAILField;
            }
            set {
                tRANIMGAVAILField = value;
            }
        }
    }
}