namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class LoanStatementResponse {
        
        private CurrencyEnum cURDEFField;
        
        private LoanAccount lOANACCTFROMField;
        
        private LoanTransactionList lOANTRANLISTField;
        
        private PrincipalBalanceType pRINBALField;
        
        private AvailableBalance aVAILBALField;
        
        private string mKTGINFOField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public CurrencyEnum CURDEF {
            get {
                return this.cURDEFField;
            }
            set {
                this.cURDEFField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public LoanAccount LOANACCTFROM {
            get {
                return this.lOANACCTFROMField;
            }
            set {
                this.lOANACCTFROMField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public LoanTransactionList LOANTRANLIST {
            get {
                return this.lOANTRANLISTField;
            }
            set {
                this.lOANTRANLISTField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PrincipalBalanceType PRINBAL {
            get {
                return this.pRINBALField;
            }
            set {
                this.pRINBALField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public AvailableBalance AVAILBAL {
            get {
                return this.aVAILBALField;
            }
            set {
                this.aVAILBALField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string MKTGINFO {
            get {
                return this.mKTGINFOField;
            }
            set {
                this.mKTGINFOField = value;
            }
        }
    }
}