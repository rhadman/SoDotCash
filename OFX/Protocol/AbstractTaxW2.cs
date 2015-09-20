namespace OFX.Protocol
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TaxW2_V200))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TaxW2_V100))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public abstract partial class AbstractTaxW2 {
        
        private string tAXYEARField;
        
        private string cNTRLNOField;
        
        private BooleanType vOIDField;
        
        private bool vOIDFieldSpecified;
        
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
        public string CNTRLNO {
            get {
                return cNTRLNOField;
            }
            set {
                cNTRLNOField = value;
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
    }
}