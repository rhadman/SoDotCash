namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class PositionOption : AbstractPositionBase {
        
        private SecuredEnum sECUREDField;
        
        private bool sECUREDFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SecuredEnum SECURED {
            get {
                return sECUREDField;
            }
            set {
                sECUREDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SECUREDSpecified {
            get {
                return sECUREDFieldSpecified;
            }
            set {
                sECUREDFieldSpecified = value;
            }
        }
    }
}