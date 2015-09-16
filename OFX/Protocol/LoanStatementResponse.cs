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
                return cURDEFField;
            }
            set {
                cURDEFField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public LoanAccount LOANACCTFROM {
            get {
                return lOANACCTFROMField;
            }
            set {
                lOANACCTFROMField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public LoanTransactionList LOANTRANLIST {
            get {
                return lOANTRANLISTField;
            }
            set {
                lOANTRANLISTField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PrincipalBalanceType PRINBAL {
            get {
                return pRINBALField;
            }
            set {
                pRINBALField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public AvailableBalance AVAILBAL {
            get {
                return aVAILBALField;
            }
            set {
                aVAILBALField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string MKTGINFO {
            get {
                return mKTGINFOField;
            }
            set {
                mKTGINFOField = value;
            }
        }
    }
}