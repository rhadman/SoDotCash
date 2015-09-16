namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class PayeeModRequest : AbstractPayeeRequest {
        
        private string pAYEELSTIDField;
        
        private Payee pAYEEField;
        
        private BankAccount bANKACCTTOField;
        
        private string[] pAYACCTField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string PAYEELSTID {
            get {
                return this.pAYEELSTIDField;
            }
            set {
                this.pAYEELSTIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Payee PAYEE {
            get {
                return this.pAYEEField;
            }
            set {
                this.pAYEEField = value;
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