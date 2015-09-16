namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class InvestmentStatementRequest {
        
        private InvestmentAccount iNVACCTFROMField;
        
        private IncTransaction iNCTRANField;
        
        private BooleanType iNCOOField;
        
        private IncPosition iNCPOSField;
        
        private BooleanType iNCBALField;
        
        private BooleanType iNC401KField;
        
        private bool iNC401KFieldSpecified;
        
        private BooleanType iNC401KBALField;
        
        private bool iNC401KBALFieldSpecified;
        
        private BooleanType iNCTRANIMGField;
        
        private bool iNCTRANIMGFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public InvestmentAccount INVACCTFROM {
            get {
                return iNVACCTFROMField;
            }
            set {
                iNVACCTFROMField = value;
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
        public BooleanType INCOO {
            get {
                return iNCOOField;
            }
            set {
                iNCOOField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public IncPosition INCPOS {
            get {
                return iNCPOSField;
            }
            set {
                iNCPOSField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType INCBAL {
            get {
                return iNCBALField;
            }
            set {
                iNCBALField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType INC401K {
            get {
                return iNC401KField;
            }
            set {
                iNC401KField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool INC401KSpecified {
            get {
                return iNC401KFieldSpecified;
            }
            set {
                iNC401KFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType INC401KBAL {
            get {
                return iNC401KBALField;
            }
            set {
                iNC401KBALField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool INC401KBALSpecified {
            get {
                return iNC401KBALFieldSpecified;
            }
            set {
                iNC401KBALFieldSpecified = value;
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