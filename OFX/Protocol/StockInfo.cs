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
                return sTOCKTYPEField;
            }
            set {
                sTOCKTYPEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool STOCKTYPESpecified {
            get {
                return sTOCKTYPEFieldSpecified;
            }
            set {
                sTOCKTYPEFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string YIELD {
            get {
                return yIELDField;
            }
            set {
                yIELDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DTYIELDASOF {
            get {
                return dTYIELDASOFField;
            }
            set {
                dTYIELDASOFField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public AssetClassEnum ASSETCLASS {
            get {
                return aSSETCLASSField;
            }
            set {
                aSSETCLASSField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ASSETCLASSSpecified {
            get {
                return aSSETCLASSFieldSpecified;
            }
            set {
                aSSETCLASSFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string FIASSETCLASS {
            get {
                return fIASSETCLASSField;
            }
            set {
                fIASSETCLASSField = value;
            }
        }
    }
}