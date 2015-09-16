namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class StatementRequest {
        
        private BankAccount bANKACCTFROMField;
        
        private IncTransaction iNCTRANField;
        
        private BooleanType iNCTRANIMGField;
        
        private bool iNCTRANIMGFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BankAccount BANKACCTFROM {
            get {
                return this.bANKACCTFROMField;
            }
            set {
                this.bANKACCTFROMField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public IncTransaction INCTRAN {
            get {
                return this.iNCTRANField;
            }
            set {
                this.iNCTRANField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType INCTRANIMG {
            get {
                return this.iNCTRANIMGField;
            }
            set {
                this.iNCTRANIMGField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool INCTRANIMGSpecified {
            get {
                return this.iNCTRANIMGFieldSpecified;
            }
            set {
                this.iNCTRANIMGFieldSpecified = value;
            }
        }
    }
}