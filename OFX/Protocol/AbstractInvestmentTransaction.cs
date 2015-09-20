namespace OFX.Protocol
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Transfer))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Split))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ReturnOfCapital))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Reinvest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MarginInterest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(JournalSecurity))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(JournalFund))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(InvestmentSell))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(InvestmentExpense))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(InvestmentBuy))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Income))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ClosureOption))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public abstract partial class AbstractInvestmentTransaction : AbstractInvestmentTransactionBase {
        
        private InvestmentTransaction iNVTRANField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public InvestmentTransaction INVTRAN {
            get {
                return iNVTRANField;
            }
            set {
                iNVTRANField = value;
            }
        }
    }
}