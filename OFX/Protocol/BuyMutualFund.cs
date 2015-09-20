namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class BuyMutualFund : AbstractInvestmentBuyTransaction {
        
        private BuyEnum bUYTYPEField;
        
        private string rELFITIDField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BuyEnum BUYTYPE {
            get {
                return bUYTYPEField;
            }
            set {
                bUYTYPEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string RELFITID {
            get {
                return rELFITIDField;
            }
            set {
                rELFITIDField = value;
            }
        }
    }
}