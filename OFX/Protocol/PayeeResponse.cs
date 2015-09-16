namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class PayeeResponse : AbstractPayeeResponse {
        
        private Payee pAYEEField;
        
        private BankAccount bANKACCTTOField;
        
        private ExtendedPayee eXTDPAYEEField;
        
        private string[] pAYACCTField;
        
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
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ExtendedPayee EXTDPAYEE {
            get {
                return this.eXTDPAYEEField;
            }
            set {
                this.eXTDPAYEEField = value;
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