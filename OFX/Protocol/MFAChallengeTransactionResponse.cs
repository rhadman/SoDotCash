namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class MFAChallengeTransactionResponse : AbstractTransactionResponse {
        
        private MFAChallenge[] mFACHALLENGERSField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute("MFACHALLENGE", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        public MFAChallenge[] MFACHALLENGERS {
            get {
                return mFACHALLENGERSField;
            }
            set {
                mFACHALLENGERSField = value;
            }
        }
    }
}