namespace OFX.Protocol
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(StockInfo))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OtherInfo))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OptionInfo))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MutualFundInfo))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DebtInfo))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public abstract partial class AbstractSecurityInfo {
        
        private GeneralSecurityInfo sECINFOField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public GeneralSecurityInfo SECINFO {
            get {
                return sECINFOField;
            }
            set {
                sECINFOField = value;
            }
        }
    }
}