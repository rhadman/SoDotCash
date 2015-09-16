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
                return this.dTASOFField;
            }
            set {
                this.dTASOFField = value;
            }
        }
        
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
        public InvestmentAccount INVACCTFROM {
            get {
                return this.iNVACCTFROMField;
            }
            set {
                this.iNVACCTFROMField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public InvestmentTransactionList INVTRANLIST {
            get {
                return this.iNVTRANLISTField;
            }
            set {
                this.iNVTRANLISTField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public InvestmentPositionList INVPOSLIST {
            get {
                return this.iNVPOSLISTField;
            }
            set {
                this.iNVPOSLISTField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public InvestmentBalance INVBAL {
            get {
                return this.iNVBALField;
            }
            set {
                this.iNVBALField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public InvestmentOpenOrderList INVOOLIST {
            get {
                return this.iNVOOLISTField;
            }
            set {
                this.iNVOOLISTField = value;
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
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Investment401k INV401K {
            get {
                return this.iNV401KField;
            }
            set {
                this.iNV401KField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Investment401kBalance INV401KBAL {
            get {
                return this.iNV401KBALField;
            }
            set {
                this.iNV401KBALField = value;
            }
        }
    }
}