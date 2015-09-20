namespace OFX.Protocol
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BuyStock))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BuyOther))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BuyOption))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BuyMutualFund))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BuyDebt))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public abstract partial class AbstractInvestmentBuyTransaction : AbstractInvestmentTransactionBase {
        
        private InvestmentBuy iNVBUYField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public InvestmentBuy INVBUY {
            get {
                return iNVBUYField;
            }
            set {
                iNVBUYField = value;
            }
        }
    }
}