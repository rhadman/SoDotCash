namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class LocalTaxWithheldAggregate {
        
        private string aMOUNTField;
        
        private string nAMELCLField;
        
        private string lCLDISTField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string AMOUNT {
            get {
                return this.aMOUNTField;
            }
            set {
                this.aMOUNTField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string NAMELCL {
            get {
                return this.nAMELCLField;
            }
            set {
                this.nAMELCLField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string LCLDIST {
            get {
                return this.lCLDISTField;
            }
            set {
                this.lCLDISTField = value;
            }
        }
    }
}