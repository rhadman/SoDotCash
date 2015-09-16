namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class PaymentMailSyncRequest : AbstractSyncRequest {
        
        private BooleanType iNCIMAGESField;
        
        private BooleanType uSEHTMLField;
        
        private PaymentMailTransactionRequest[] pMTMAILTRNRQField;
        
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
        [System.Xml.Serialization.XmlElementAttribute("PMTMAILTRNRQ", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PaymentMailTransactionRequest[] PMTMAILTRNRQ {
            get {
                return this.pMTMAILTRNRQField;
            }
            set {
                this.pMTMAILTRNRQField = value;
            }
        }
    }
}