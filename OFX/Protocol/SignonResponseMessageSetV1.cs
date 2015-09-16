namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class SignonResponseMessageSetV1 : AbstractResponseMessageSet {
        
        private SignonResponse sONRSField;
        
        private PinChangeTransactionResponse pINCHTRNRSField;
        
        private ChallengeTransactionResponse cHALLENGETRNRSField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SignonResponse SONRS {
            get {
                return this.sONRSField;
            }
            set {
                this.sONRSField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PinChangeTransactionResponse PINCHTRNRS {
            get {
                return this.pINCHTRNRSField;
            }
            set {
                this.pINCHTRNRSField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ChallengeTransactionResponse CHALLENGETRNRS {
            get {
                return this.cHALLENGETRNRSField;
            }
            set {
                this.cHALLENGETRNRSField = value;
            }
        }
    }
}