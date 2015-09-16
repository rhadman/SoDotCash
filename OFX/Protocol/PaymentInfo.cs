namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class PaymentInfo {
        
        private BankAccount bANKACCTFROMField;
        
        private string tRNAMTField;
        
        private object itemField;
        
        private string pAYEELSTIDField;
        
        private BankAccount bANKACCTTOField;
        
        private ExtendedPayment[] eXTDPMTField;
        
        private string pAYACCTField;
        
        private string dTDUEField;
        
        private string mEMOField;
        
        private string bILLREFINFOField;
        
        private BillPubInfo bILLPUBINFOField;
        
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
        public string TRNAMT {
            get {
                return tRNAMTField;
            }
            set {
                tRNAMTField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PAYEE", typeof(Payee), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("PAYEEID", typeof(string), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public object Item {
            get {
                return itemField;
            }
            set {
                itemField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string PAYEELSTID {
            get {
                return pAYEELSTIDField;
            }
            set {
                pAYEELSTIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BankAccount BANKACCTTO {
            get {
                return bANKACCTTOField;
            }
            set {
                bANKACCTTOField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EXTDPMT", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ExtendedPayment[] EXTDPMT {
            get {
                return eXTDPMTField;
            }
            set {
                eXTDPMTField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string PAYACCT {
            get {
                return pAYACCTField;
            }
            set {
                pAYACCTField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DTDUE {
            get {
                return dTDUEField;
            }
            set {
                dTDUEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string MEMO {
            get {
                return mEMOField;
            }
            set {
                mEMOField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string BILLREFINFO {
            get {
                return bILLREFINFOField;
            }
            set {
                bILLREFINFOField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BillPubInfo BILLPUBINFO {
            get {
                return bILLPUBINFOField;
            }
            set {
                bILLPUBINFOField = value;
            }
        }
    }
}