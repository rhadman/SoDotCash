namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class PresentmentBillInfo {
        
        private string bILLIDField;
        
        private PresentmentAccount pRESACCTFROMField;
        
        private string pAYEEIDField;
        
        private string bILLREFINFOField;
        
        private string aMTDUEField;
        
        private string mINAMTDUEField;
        
        private string dTPMTDUEField;
        
        private string dTBILLField;
        
        private string dTOPENField;
        
        private string dTCLOSEField;
        
        private string pREVBALField;
        
        private string aCTIVITYField;
        
        private string aCCTBALField;
        
        private Invoice iNVOICEField;
        
        private BooleanType nOTIFYDESIREDField;
        
        private BillTypeEnum bILLTYPEField;
        
        private bool bILLTYPEFieldSpecified;
        
        private BillStatus[] bILLSTATUSField;
        
        private BillPaymentstatus[] bILLPMTSTATUSField;
        
        private StatementImage sTMNTIMAGEField;
        
        private object itemField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string BILLID {
            get {
                return this.bILLIDField;
            }
            set {
                this.bILLIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PresentmentAccount PRESACCTFROM {
            get {
                return this.pRESACCTFROMField;
            }
            set {
                this.pRESACCTFROMField = value;
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
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string BILLREFINFO {
            get {
                return this.bILLREFINFOField;
            }
            set {
                this.bILLREFINFOField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string AMTDUE {
            get {
                return this.aMTDUEField;
            }
            set {
                this.aMTDUEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string MINAMTDUE {
            get {
                return this.mINAMTDUEField;
            }
            set {
                this.mINAMTDUEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DTPMTDUE {
            get {
                return this.dTPMTDUEField;
            }
            set {
                this.dTPMTDUEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DTBILL {
            get {
                return this.dTBILLField;
            }
            set {
                this.dTBILLField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DTOPEN {
            get {
                return this.dTOPENField;
            }
            set {
                this.dTOPENField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DTCLOSE {
            get {
                return this.dTCLOSEField;
            }
            set {
                this.dTCLOSEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string PREVBAL {
            get {
                return this.pREVBALField;
            }
            set {
                this.pREVBALField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ACTIVITY {
            get {
                return this.aCTIVITYField;
            }
            set {
                this.aCTIVITYField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ACCTBAL {
            get {
                return this.aCCTBALField;
            }
            set {
                this.aCCTBALField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Invoice INVOICE {
            get {
                return this.iNVOICEField;
            }
            set {
                this.iNVOICEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType NOTIFYDESIRED {
            get {
                return this.nOTIFYDESIREDField;
            }
            set {
                this.nOTIFYDESIREDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BillTypeEnum BILLTYPE {
            get {
                return this.bILLTYPEField;
            }
            set {
                this.bILLTYPEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BILLTYPESpecified {
            get {
                return this.bILLTYPEFieldSpecified;
            }
            set {
                this.bILLTYPEFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BILLSTATUS", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BillStatus[] BILLSTATUS {
            get {
                return this.bILLSTATUSField;
            }
            set {
                this.bILLSTATUSField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BILLPMTSTATUS", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BillPaymentstatus[] BILLPMTSTATUS {
            get {
                return this.bILLPMTSTATUSField;
            }
            set {
                this.bILLPMTSTATUSField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public StatementImage STMNTIMAGE {
            get {
                return this.sTMNTIMAGEField;
            }
            set {
                this.sTMNTIMAGEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BILLDETAILTABLE", typeof(BillDetailTable), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("DETAILAVAILABLE", typeof(BooleanType), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public object Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
    }
}