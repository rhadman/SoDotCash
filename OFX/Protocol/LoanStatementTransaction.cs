namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class LoanStatementTransaction {
        
        private LoanTransactionEnum lOANTRNTYPEField;
        
        private string dTPOSTEDField;
        
        private string dTUSERField;
        
        private string tRNAMTField;
        
        private LoanTransactionAmount lOANTRNAMTField;
        
        private string fITIDField;
        
        private string cORRECTFITIDField;
        
        private CorrectiveActionEnum cORRECTACTIONField;
        
        private string sRVRTIDField;
        
        private string cHECKNUMField;
        
        private string rEFNUMField;
        
        private string nAMEField;
        
        private string eXTDNAMEField;
        
        private AbstractAccount itemField;
        
        private string mEMOField;
        
        private ImageData iMAGEDATAField;
        
        private Currency item1Field;
        
        private Item1ChoiceType item1ElementNameField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public LoanTransactionEnum LOANTRNTYPE {
            get {
                return this.lOANTRNTYPEField;
            }
            set {
                this.lOANTRNTYPEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DTPOSTED {
            get {
                return this.dTPOSTEDField;
            }
            set {
                this.dTPOSTEDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DTUSER {
            get {
                return this.dTUSERField;
            }
            set {
                this.dTUSERField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string TRNAMT {
            get {
                return this.tRNAMTField;
            }
            set {
                this.tRNAMTField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public LoanTransactionAmount LOANTRNAMT {
            get {
                return this.lOANTRNAMTField;
            }
            set {
                this.lOANTRNAMTField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string FITID {
            get {
                return this.fITIDField;
            }
            set {
                this.fITIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string CORRECTFITID {
            get {
                return this.cORRECTFITIDField;
            }
            set {
                this.cORRECTFITIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public CorrectiveActionEnum CORRECTACTION {
            get {
                return this.cORRECTACTIONField;
            }
            set {
                this.cORRECTACTIONField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string SRVRTID {
            get {
                return this.sRVRTIDField;
            }
            set {
                this.sRVRTIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string CHECKNUM {
            get {
                return this.cHECKNUMField;
            }
            set {
                this.cHECKNUMField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string REFNUM {
            get {
                return this.rEFNUMField;
            }
            set {
                this.rEFNUMField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string NAME {
            get {
                return this.nAMEField;
            }
            set {
                this.nAMEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string EXTDNAME {
            get {
                return this.eXTDNAMEField;
            }
            set {
                this.eXTDNAMEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BANKACCTTO", typeof(BankAccount), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("LOANACCTTO", typeof(LoanAccount), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public AbstractAccount Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string MEMO {
            get {
                return this.mEMOField;
            }
            set {
                this.mEMOField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ImageData IMAGEDATA {
            get {
                return this.iMAGEDATAField;
            }
            set {
                this.iMAGEDATAField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CURRENCY", typeof(Currency), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("ORIGCURRENCY", typeof(Currency), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("Item1ElementName")]
        public Currency Item1 {
            get {
                return this.item1Field;
            }
            set {
                this.item1Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public Item1ChoiceType Item1ElementName {
            get {
                return this.item1ElementNameField;
            }
            set {
                this.item1ElementNameField = value;
            }
        }
    }
}