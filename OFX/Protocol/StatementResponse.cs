namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class StatementResponse {
        
        private CurrencyEnum cURDEFField;
        
        private BankAccount bANKACCTFROMField;
        
        private BankTransactionList bANKTRANLISTField;
        
        private LedgerBalance lEDGERBALField;
        
        private AvailableBalance aVAILBALField;
        
        private Balance[] bALLISTField;
        
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
        public BankAccount BANKACCTFROM {
            get {
                return bANKACCTFROMField;
            }
            set {
                bANKACCTFROMField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BankTransactionList BANKTRANLIST {
            get {
                return bANKTRANLISTField;
            }
            set {
                bANKTRANLISTField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public LedgerBalance LEDGERBAL {
            get {
                return lEDGERBALField;
            }
            set {
                lEDGERBALField = value;
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
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute("BAL", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        public Balance[] BALLIST {
            get {
                return bALLISTField;
            }
            set {
                bALLISTField = value;
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