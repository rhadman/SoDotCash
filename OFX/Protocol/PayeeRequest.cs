namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class PayeeRequest : AbstractPayeeRequest {
        
        private object itemField;
        
        private BankAccount bANKACCTTOField;
        
        private string[] pAYACCTField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PAYEE", typeof(Payee), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("PAYEEID", typeof(string), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public object Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BankAccount BANKACCTTO {
            get {
                return this.bANKACCTTOField;
            }
            set {
                this.bANKACCTTOField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PAYACCT", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[] PAYACCT {
            get {
                return this.pAYACCTField;
            }
            set {
                this.pAYACCTField = value;
            }
        }
    }
}