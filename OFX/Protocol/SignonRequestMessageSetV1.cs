namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class SignonRequestMessageSetV1 : AbstractRequestMessageSet {
        
        private SignonRequest sONRQField;
        
        private PinChangeTransactionRequest pINCHTRNRQField;
        
        private ChallengeTransactionRequest cHALLENGETRNRQField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SignonRequest SONRQ {
            get {
                return sONRQField;
            }
            set {
                sONRQField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PinChangeTransactionRequest PINCHTRNRQ {
            get {
                return pINCHTRNRQField;
            }
            set {
                pINCHTRNRQField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ChallengeTransactionRequest CHALLENGETRNRQ {
            get {
                return cHALLENGETRNRQField;
            }
            set {
                cHALLENGETRNRQField = value;
            }
        }
    }
}