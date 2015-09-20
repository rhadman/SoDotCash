namespace OFX.Protocol
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Tax1099R_V100))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Tax1099OID_V100))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Tax1099MISC_V100))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Tax1099INT_V100))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Tax1099DIV_V100))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Tax1099B_V100))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public abstract partial class AbstractTaxForm1099 {
        
        private string sRVRTIDField;
        
        private string tAXYEARField;
        
        private BooleanType vOIDField;
        
        private bool vOIDFieldSpecified;
        
        private BooleanType cORRECTEDField;
        
        private bool cORRECTEDFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string SRVRTID {
            get {
                return sRVRTIDField;
            }
            set {
                sRVRTIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="gYear")]
        public string TAXYEAR {
            get {
                return tAXYEARField;
            }
            set {
                tAXYEARField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType VOID {
            get {
                return vOIDField;
            }
            set {
                vOIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool VOIDSpecified {
            get {
                return vOIDFieldSpecified;
            }
            set {
                vOIDFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType CORRECTED {
            get {
                return cORRECTEDField;
            }
            set {
                cORRECTEDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CORRECTEDSpecified {
            get {
                return cORRECTEDFieldSpecified;
            }
            set {
                cORRECTEDFieldSpecified = value;
            }
        }
    }
}