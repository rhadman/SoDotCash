namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class CreditCardStatementResponse {
        
        private CurrencyEnum cURDEFField;
        
        private CreditCardAccount cCACCTFROMField;
        
        private BankTransactionList bANKTRANLISTField;
        
        private LedgerBalance lEDGERBALField;
        
        private AvailableBalance aVAILBALField;
        
        private Balance[] bALLISTField;
        
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
        public CreditCardAccount CCACCTFROM {
            get {
                return this.cCACCTFROMField;
            }
            set {
                this.cCACCTFROMField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BankTransactionList BANKTRANLIST {
            get {
                return this.bANKTRANLISTField;
            }
            set {
                this.bANKTRANLISTField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public LedgerBalance LEDGERBAL {
            get {
                return this.lEDGERBALField;
            }
            set {
                this.lEDGERBALField = value;
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
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute("BAL", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        public Balance[] BALLIST {
            get {
                return this.bALLISTField;
            }
            set {
                this.bALLISTField = value;
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