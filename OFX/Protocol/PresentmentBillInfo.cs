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
                return bILLIDField;
            }
            set {
                bILLIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PresentmentAccount PRESACCTFROM {
            get {
                return pRESACCTFROMField;
            }
            set {
                pRESACCTFROMField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string PAYEEID {
            get {
                return pAYEEIDField;
            }
            set {
                pAYEEIDField = value;
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
        public string AMTDUE {
            get {
                return aMTDUEField;
            }
            set {
                aMTDUEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string MINAMTDUE {
            get {
                return mINAMTDUEField;
            }
            set {
                mINAMTDUEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DTPMTDUE {
            get {
                return dTPMTDUEField;
            }
            set {
                dTPMTDUEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DTBILL {
            get {
                return dTBILLField;
            }
            set {
                dTBILLField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DTOPEN {
            get {
                return dTOPENField;
            }
            set {
                dTOPENField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DTCLOSE {
            get {
                return dTCLOSEField;
            }
            set {
                dTCLOSEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string PREVBAL {
            get {
                return pREVBALField;
            }
            set {
                pREVBALField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ACTIVITY {
            get {
                return aCTIVITYField;
            }
            set {
                aCTIVITYField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ACCTBAL {
            get {
                return aCCTBALField;
            }
            set {
                aCCTBALField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Invoice INVOICE {
            get {
                return iNVOICEField;
            }
            set {
                iNVOICEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType NOTIFYDESIRED {
            get {
                return nOTIFYDESIREDField;
            }
            set {
                nOTIFYDESIREDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BillTypeEnum BILLTYPE {
            get {
                return bILLTYPEField;
            }
            set {
                bILLTYPEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BILLTYPESpecified {
            get {
                return bILLTYPEFieldSpecified;
            }
            set {
                bILLTYPEFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BILLSTATUS", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BillStatus[] BILLSTATUS {
            get {
                return bILLSTATUSField;
            }
            set {
                bILLSTATUSField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BILLPMTSTATUS", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BillPaymentstatus[] BILLPMTSTATUS {
            get {
                return bILLPMTSTATUSField;
            }
            set {
                bILLPMTSTATUSField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public StatementImage STMNTIMAGE {
            get {
                return sTMNTIMAGEField;
            }
            set {
                sTMNTIMAGEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BILLDETAILTABLE", typeof(BillDetailTable), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("DETAILAVAILABLE", typeof(BooleanType), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public object Item {
            get {
                return itemField;
            }
            set {
                itemField = value;
            }
        }
    }
}