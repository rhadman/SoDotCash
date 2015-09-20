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
                return bANKACCTFROMField;
            }
            set {
                bANKACCTFROMField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public IncTransaction INCTRAN {
            get {
                return iNCTRANField;
            }
            set {
                iNCTRANField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType INCTRANIMG {
            get {
                return iNCTRANIMGField;
            }
            set {
                iNCTRANIMGField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool INCTRANIMGSpecified {
            get {
                return iNCTRANIMGFieldSpecified;
            }
            set {
                iNCTRANIMGFieldSpecified = value;
            }
        }
    }
}