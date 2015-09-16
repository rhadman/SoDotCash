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
                return this.iNVACCTFROMField;
            }
            set {
                this.iNVACCTFROMField = value;
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
        public BooleanType INCOO {
            get {
                return this.iNCOOField;
            }
            set {
                this.iNCOOField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public IncPosition INCPOS {
            get {
                return this.iNCPOSField;
            }
            set {
                this.iNCPOSField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType INCBAL {
            get {
                return this.iNCBALField;
            }
            set {
                this.iNCBALField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType INC401K {
            get {
                return this.iNC401KField;
            }
            set {
                this.iNC401KField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool INC401KSpecified {
            get {
                return this.iNC401KFieldSpecified;
            }
            set {
                this.iNC401KFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType INC401KBAL {
            get {
                return this.iNC401KBALField;
            }
            set {
                this.iNC401KBALField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool INC401KBALSpecified {
            get {
                return this.iNC401KBALFieldSpecified;
            }
            set {
                this.iNC401KBALFieldSpecified = value;
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