namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class BuyOption : AbstractInvestmentBuyTransaction {
        
        private OptionBuyEnum oPTBUYTYPEField;
        
        private string sHPERCTRCTField;
        
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
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string SHPERCTRCT {
            get {
                return sHPERCTRCTField;
            }
            set {
                sHPERCTRCTField = value;
            }
        }
    }
}