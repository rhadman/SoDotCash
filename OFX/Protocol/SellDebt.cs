namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class SellDebt : AbstractInvestmentSellTransaction {
        
        private SellReasonEnum sELLREASONField;
        
        private string aCCRDINTField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SellReasonEnum SELLREASON {
            get {
                return this.sELLREASONField;
            }
            set {
                this.sELLREASONField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ACCRDINT {
            get {
                return this.aCCRDINTField;
            }
            set {
                this.aCCRDINTField = value;
            }
        }
    }
}