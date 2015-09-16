namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class OpenOrderBuyOption : AbstractOpenOrder {
        
        private OptionBuyEnum oPTBUYTYPEField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public OptionBuyEnum OPTBUYTYPE {
            get {
                return oPTBUYTYPEField;
            }
            set {
                oPTBUYTYPEField = value;
            }
        }
    }
}