namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class MFAChallengeTransactionRequest : AbstractTransactionRequest {
        
        private MFAChallengeRequest mFACHALLENGERQField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public MFAChallengeRequest MFACHALLENGERQ {
            get {
                return mFACHALLENGERQField;
            }
            set {
                mFACHALLENGERQField = value;
            }
        }
    }
}