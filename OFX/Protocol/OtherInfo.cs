namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class OtherInfo : AbstractSecurityInfo {
        
        private string tYPEDESCField;
        
        private AssetClassEnum aSSETCLASSField;
        
        private bool aSSETCLASSFieldSpecified;
        
        private string fIASSETCLASSField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string TYPEDESC {
            get {
                return this.tYPEDESCField;
            }
            set {
                this.tYPEDESCField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public AssetClassEnum ASSETCLASS {
            get {
                return this.aSSETCLASSField;
            }
            set {
                this.aSSETCLASSField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ASSETCLASSSpecified {
            get {
                return this.aSSETCLASSFieldSpecified;
            }
            set {
                this.aSSETCLASSFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string FIASSETCLASS {
            get {
                return this.fIASSETCLASSField;
            }
            set {
                this.fIASSETCLASSField = value;
            }
        }
    }
}