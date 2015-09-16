namespace OFX.Protocol
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OpenOrderSwitchMutualFund))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OpenOrderSellStock))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OpenOrderSellOther))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OpenOrderSellOption))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OpenOrderSellMutualFund))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OpenOrderSellDebt))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OpenOrderBuyStock))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OpenOrderBuyOther))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OpenOrderBuyOption))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OpenOrderBuyMutualFund))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OpenOrderBuyDebt))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public abstract partial class AbstractOpenOrder {
        
        private GeneralOpenOrder ooField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public GeneralOpenOrder OO {
            get {
                return ooField;
            }
            set {
                ooField = value;
            }
        }
    }
}