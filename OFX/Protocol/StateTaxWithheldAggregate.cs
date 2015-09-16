namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class StateTaxWithheldAggregate {
        
        private string aMOUNTField;
        
        private string pAYERSTATEField;
        
        private string pAYERSTIDField;
        
        private string sTDISTField;
        
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
        public string PAYERSTATE {
            get {
                return this.pAYERSTATEField;
            }
            set {
                this.pAYERSTATEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string PAYERSTID {
            get {
                return this.pAYERSTIDField;
            }
            set {
                this.pAYERSTIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string STDIST {
            get {
                return this.sTDISTField;
            }
            set {
                this.sTDISTField = value;
            }
        }
    }
}