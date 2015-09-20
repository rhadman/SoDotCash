namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class OpenOrderSwitchMutualFund : AbstractOpenOrder {
        
        private SecurityId sECIDField;
        
        private UnitTypeEnum uNITTYPEField;
        
        private BooleanType sWITCHALLField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SecurityId SECID {
            get {
                return sECIDField;
            }
            set {
                sECIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public UnitTypeEnum UNITTYPE {
            get {
                return uNITTYPEField;
            }
            set {
                uNITTYPEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType SWITCHALL {
            get {
                return sWITCHALLField;
            }
            set {
                sWITCHALLField = value;
            }
        }
    }
}