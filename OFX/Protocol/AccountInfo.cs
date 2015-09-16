namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class AccountInfo {
        
        private string dESCField;
        
        private string pHONEField;
        
        private AbstractAccountInfo[] itemsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DESC {
            get {
                return dESCField;
            }
            set {
                dESCField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string PHONE {
            get {
                return pHONEField;
            }
            set {
                pHONEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BANKACCTINFO", typeof(BankAccountInfo), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("BPACCTINFO", typeof(BillPaymentAccountInfo), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("CCACCTINFO", typeof(CreditCardAccountInfo), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("INVACCTINFO", typeof(InvestmentAccountInfo), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("LOANACCTINFO", typeof(LoanAccountInfo), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("PRESACCTINFO", typeof(PresentmentAccountInfo), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public AbstractAccountInfo[] Items {
            get {
                return itemsField;
            }
            set {
                itemsField = value;
            }
        }
    }
}