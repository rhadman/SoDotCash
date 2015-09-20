namespace OFX.Protocol
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SellStock))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SellOther))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SellOption))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SellMutualFund))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SellDebt))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public abstract partial class AbstractInvestmentSellTransaction : AbstractInvestmentTransactionBase {
        
        private InvestmentSell iNVSELLField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public InvestmentSell INVSELL {
            get {
                return iNVSELLField;
            }
            set {
                iNVSELLField = value;
            }
        }
    }
}