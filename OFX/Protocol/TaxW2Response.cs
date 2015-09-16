namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class TaxW2Response {
        
        private string sSNField;
        
        private AbstractTaxW2[] itemsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string SSN {
            get {
                return sSNField;
            }
            set {
                sSNField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TAXW2_V100", typeof(TaxW2_V100), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("TAXW2_V200", typeof(TaxW2_V200), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public AbstractTaxW2[] Items {
            get {
                return itemsField;
            }
            set {
                itemsField = value;
            }
        }
    }
}