namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class InvestmentStatementResponse {
        
        private string dTASOFField;
        
        private CurrencyEnum cURDEFField;
        
        private InvestmentAccount iNVACCTFROMField;
        
        private InvestmentTransactionList iNVTRANLISTField;
        
        private InvestmentPositionList iNVPOSLISTField;
        
        private InvestmentBalance iNVBALField;
        
        private InvestmentOpenOrderList iNVOOLISTField;
        
        private string mKTGINFOField;
        
        private Investment401k iNV401KField;
        
        private Investment401kBalance iNV401KBALField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DTASOF {
            get {
                return dTASOFField;
            }
            set {
                dTASOFField = value;
            }
        }
        
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
        public InvestmentAccount INVACCTFROM {
            get {
                return iNVACCTFROMField;
            }
            set {
                iNVACCTFROMField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public InvestmentTransactionList INVTRANLIST {
            get {
                return iNVTRANLISTField;
            }
            set {
                iNVTRANLISTField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public InvestmentPositionList INVPOSLIST {
            get {
                return iNVPOSLISTField;
            }
            set {
                iNVPOSLISTField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public InvestmentBalance INVBAL {
            get {
                return iNVBALField;
            }
            set {
                iNVBALField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public InvestmentOpenOrderList INVOOLIST {
            get {
                return iNVOOLISTField;
            }
            set {
                iNVOOLISTField = value;
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
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Investment401k INV401K {
            get {
                return iNV401KField;
            }
            set {
                iNV401KField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Investment401kBalance INV401KBAL {
            get {
                return iNV401KBALField;
            }
            set {
                iNV401KBALField = value;
            }
        }
    }
}