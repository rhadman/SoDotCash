namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class StockInfo : AbstractSecurityInfo {
        
        private StockEnum sTOCKTYPEField;
        
        private bool sTOCKTYPEFieldSpecified;
        
        private string yIELDField;
        
        private string dTYIELDASOFField;
        
        private AssetClassEnum aSSETCLASSField;
        
        private bool aSSETCLASSFieldSpecified;
        
        private string fIASSETCLASSField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public StockEnum STOCKTYPE {
            get {
                return this.sTOCKTYPEField;
            }
            set {
                this.sTOCKTYPEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool STOCKTYPESpecified {
            get {
                return this.sTOCKTYPEFieldSpecified;
            }
            set {
                this.sTOCKTYPEFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string YIELD {
            get {
                return this.yIELDField;
            }
            set {
                this.yIELDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DTYIELDASOF {
            get {
                return this.dTYIELDASOFField;
            }
            set {
                this.dTYIELDASOFField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public AssetClassEnum ASSETCLASS {
            get {
                return this.aSSETCLASSField;
            }
            set {
                this.aSSETCLASSField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ASSETCLASSSpecified {
            get {
                return this.aSSETCLASSFieldSpecified;
            }
            set {
                this.aSSETCLASSFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string FIASSETCLASS {
            get {
                return this.fIASSETCLASSField;
            }
            set {
                this.fIASSETCLASSField = value;
            }
        }
    }
}