namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class ServiceChange : AbstractServiceAction {
        
        private AbstractAccount itemField;
        
        private AbstractAccount item1Field;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BANKACCTFROM", typeof(BankAccount), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("CCACCTFROM", typeof(CreditCardAccount), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("INVACCTFROM", typeof(InvestmentAccount), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("PRESACCTFROM", typeof(PresentmentAccount), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public AbstractAccount Item {
            get {
                return itemField;
            }
            set {
                itemField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BANKACCTTO", typeof(BankAccount), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("CCACCTTO", typeof(CreditCardAccount), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("INVACCTTO", typeof(InvestmentAccount), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("PRESACCTTO", typeof(PresentmentAccount), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public AbstractAccount Item1 {
            get {
                return item1Field;
            }
            set {
                item1Field = value;
            }
        }
    }
}