namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class MFAChallenge {
        
        private string mFAPHRASEIDField;
        
        private string mFAPHRASELABELField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string MFAPHRASEID {
            get {
                return mFAPHRASEIDField;
            }
            set {
                mFAPHRASEIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string MFAPHRASELABEL {
            get {
                return mFAPHRASELABELField;
            }
            set {
                mFAPHRASELABELField = value;
            }
        }
    }
}