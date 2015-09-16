namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class StatementTransaction {
        
        private TransactionEnum tRNTYPEField;
        
        private string dTPOSTEDField;
        
        private string dTUSERField;
        
        private string dTAVAILField;
        
        private string tRNAMTField;
        
        private string fITIDField;
        
        private string cORRECTFITIDField;
        
        private CorrectiveActionEnum cORRECTACTIONField;
        
        private string sRVRTIDField;
        
        private string cHECKNUMField;
        
        private string rEFNUMField;
        
        private string sICField;
        
        private string pAYEEIDField;
        
        private object itemField;
        
        private string eXTDNAMEField;
        
        private AbstractAccount item1Field;
        
        private string mEMOField;
        
        private Currency item2Field;
        
        private Item2ChoiceType item2ElementNameField;
        
        private Investment401kSourceEnum iNV401KSOURCEField;
        
        private bool iNV401KSOURCEFieldSpecified;
        
        private ImageData[] iMAGEDATAField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public TransactionEnum TRNTYPE {
            get {
                return this.tRNTYPEField;
            }
            set {
                this.tRNTYPEField = value;
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
        public string DTAVAIL {
            get {
                return this.dTAVAILField;
            }
            set {
                this.dTAVAILField = value;
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
        public string SIC {
            get {
                return this.sICField;
            }
            set {
                this.sICField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string PAYEEID {
            get {
                return this.pAYEEIDField;
            }
            set {
                this.pAYEEIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("NAME", typeof(string), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("PAYEE", typeof(Payee), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
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
        [System.Xml.Serialization.XmlElementAttribute("CCACCTTO", typeof(CreditCardAccount), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public AbstractAccount Item1 {
            get {
                return this.item1Field;
            }
            set {
                this.item1Field = value;
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
        [System.Xml.Serialization.XmlElementAttribute("CURRENCY", typeof(Currency), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("ORIGCURRENCY", typeof(Currency), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("Item2ElementName")]
        public Currency Item2 {
            get {
                return this.item2Field;
            }
            set {
                this.item2Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public Item2ChoiceType Item2ElementName {
            get {
                return this.item2ElementNameField;
            }
            set {
                this.item2ElementNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Investment401kSourceEnum INV401KSOURCE {
            get {
                return this.iNV401KSOURCEField;
            }
            set {
                this.iNV401KSOURCEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool INV401KSOURCESpecified {
            get {
                return this.iNV401KSOURCEFieldSpecified;
            }
            set {
                this.iNV401KSOURCEFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("IMAGEDATA", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ImageData[] IMAGEDATA {
            get {
                return this.iMAGEDATAField;
            }
            set {
                this.iMAGEDATAField = value;
            }
        }
    }
}