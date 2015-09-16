namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class SellOption : AbstractInvestmentSellTransaction {
        
        private OptionSellEnum oPTSELLTYPEField;
        
        private string sHPERCTRCTField;
        
        private string rELFITIDField;
        
        private RelatedEnum rELTYPEField;
        
        private bool rELTYPEFieldSpecified;
        
        private SecuredEnum sECUREDField;
        
        private bool sECUREDFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public OptionSellEnum OPTSELLTYPE {
            get {
                return this.oPTSELLTYPEField;
            }
            set {
                this.oPTSELLTYPEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string SHPERCTRCT {
            get {
                return this.sHPERCTRCTField;
            }
            set {
                this.sHPERCTRCTField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string RELFITID {
            get {
                return this.rELFITIDField;
            }
            set {
                this.rELFITIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public RelatedEnum RELTYPE {
            get {
                return this.rELTYPEField;
            }
            set {
                this.rELTYPEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RELTYPESpecified {
            get {
                return this.rELTYPEFieldSpecified;
            }
            set {
                this.rELTYPEFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SecuredEnum SECURED {
            get {
                return this.sECUREDField;
            }
            set {
                this.sECUREDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SECUREDSpecified {
            get {
                return this.sECUREDFieldSpecified;
            }
            set {
                this.sECUREDFieldSpecified = value;
            }
        }
    }
}