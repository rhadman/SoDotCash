namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class InvestmentBalance {
        
        private string aVAILCASHField;
        
        private string mARGINBALANCEField;
        
        private string sHORTBALANCEField;
        
        private string bUYPOWERField;
        
        private Balance[] bALLISTField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string AVAILCASH {
            get {
                return this.aVAILCASHField;
            }
            set {
                this.aVAILCASHField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string MARGINBALANCE {
            get {
                return this.mARGINBALANCEField;
            }
            set {
                this.mARGINBALANCEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string SHORTBALANCE {
            get {
                return this.sHORTBALANCEField;
            }
            set {
                this.sHORTBALANCEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string BUYPOWER {
            get {
                return this.bUYPOWERField;
            }
            set {
                this.bUYPOWERField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute("BAL", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        public Balance[] BALLIST {
            get {
                return this.bALLISTField;
            }
            set {
                this.bALLISTField = value;
            }
        }
    }
}