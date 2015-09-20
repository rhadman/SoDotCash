namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class Tax1099Response {
        
        private string aCCTNUMField;
        
        private string rECIDField;
        
        private AbstractTaxForm1099[] itemsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ACCTNUM {
            get {
                return aCCTNUMField;
            }
            set {
                aCCTNUMField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string RECID {
            get {
                return rECIDField;
            }
            set {
                rECIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TAX1099B_V100", typeof(Tax1099B_V100), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("TAX1099DIV_V100", typeof(Tax1099DIV_V100), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("TAX1099INT_V100", typeof(Tax1099INT_V100), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("TAX1099MISC_V100", typeof(Tax1099MISC_V100), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("TAX1099OID_V100", typeof(Tax1099OID_V100), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("TAX1099R_V100", typeof(Tax1099R_V100), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public AbstractTaxForm1099[] Items {
            get {
                return itemsField;
            }
            set {
                itemsField = value;
            }
        }
    }
}