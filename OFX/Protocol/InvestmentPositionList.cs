namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class InvestmentPositionList {
        
        private AbstractPositionBase[] itemsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("POSDEBT", typeof(PositionDebt), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("POSMF", typeof(PositionMutualFund), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("POSOPT", typeof(PositionOption), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("POSOTHER", typeof(PositionOther), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("POSSTOCK", typeof(PositionStock), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public AbstractPositionBase[] Items {
            get {
                return itemsField;
            }
            set {
                itemsField = value;
            }
        }
    }
}