namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class SellMutualFund : AbstractInvestmentSellTransaction {
        
        private SellTypeEnum sELLTYPEField;
        
        private string aVGCOSTBASISField;
        
        private string rELFITIDField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SellTypeEnum SELLTYPE {
            get {
                return sELLTYPEField;
            }
            set {
                sELLTYPEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string AVGCOSTBASIS {
            get {
                return aVGCOSTBASISField;
            }
            set {
                aVGCOSTBASISField = value;
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