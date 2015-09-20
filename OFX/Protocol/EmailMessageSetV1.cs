namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class EmailMessageSetV1 : AbstractMessageSetVersion {
        
        private BooleanType mAILSUPField;
        
        private BooleanType gETMIMESUPField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType MAILSUP {
            get {
                return mAILSUPField;
            }
            set {
                mAILSUPField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType GETMIMESUP {
            get {
                return gETMIMESUPField;
            }
            set {
                gETMIMESUPField = value;
            }
        }
    }
}