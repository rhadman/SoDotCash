namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class SecurityList {
        
        private AbstractSecurityInfo[] itemsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DEBTINFO", typeof(DebtInfo), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("MFINFO", typeof(MutualFundInfo), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("OPTINFO", typeof(OptionInfo), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("OTHERINFO", typeof(OtherInfo), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("STOCKINFO", typeof(StockInfo), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public AbstractSecurityInfo[] Items {
            get {
                return itemsField;
            }
            set {
                itemsField = value;
            }
        }
    }
}