namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class MailSyncRequest : AbstractSyncRequest {
        
        private BooleanType iNCIMAGESField;
        
        private BooleanType uSEHTMLField;
        
        private MailTransactionRequest[] mAILTRNRQField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType INCIMAGES {
            get {
                return this.iNCIMAGESField;
            }
            set {
                this.iNCIMAGESField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType USEHTML {
            get {
                return this.uSEHTMLField;
            }
            set {
                this.uSEHTMLField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MAILTRNRQ", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public MailTransactionRequest[] MAILTRNRQ {
            get {
                return this.mAILTRNRQField;
            }
            set {
                this.mAILTRNRQField = value;
            }
        }
    }
}