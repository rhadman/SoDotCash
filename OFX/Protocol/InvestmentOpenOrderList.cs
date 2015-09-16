namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class InvestmentOpenOrderList {
        
        private AbstractOpenOrder[] itemsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("OOBUYDEBT", typeof(OpenOrderBuyDebt), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("OOBUYMF", typeof(OpenOrderBuyMutualFund), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("OOBUYOPT", typeof(OpenOrderBuyOption), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("OOBUYOTHER", typeof(OpenOrderBuyOther), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("OOBUYSTOCK", typeof(OpenOrderBuyStock), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("OOSELLDEBT", typeof(OpenOrderSellDebt), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("OOSELLMF", typeof(OpenOrderSellMutualFund), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("OOSELLOPT", typeof(OpenOrderSellOption), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("OOSELLOTHER", typeof(OpenOrderSellOther), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("OOSELLSTOCK", typeof(OpenOrderSellStock), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("SWITCHMF", typeof(OpenOrderSwitchMutualFund), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public AbstractOpenOrder[] Items {
            get {
                return itemsField;
            }
            set {
                itemsField = value;
            }
        }
    }
}