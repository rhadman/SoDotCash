namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class CreditCardAccountInfo : AbstractAccountInfo {
        
        private CreditCardAccount cCACCTFROMField;
        
        private BooleanType sUPTXDLField;
        
        private BooleanType xFERSRCField;
        
        private BooleanType xFERDESTField;
        
        private ServiceStatusEnum sVCSTATUSField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public CreditCardAccount CCACCTFROM {
            get {
                return this.cCACCTFROMField;
            }
            set {
                this.cCACCTFROMField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType SUPTXDL {
            get {
                return this.sUPTXDLField;
            }
            set {
                this.sUPTXDLField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType XFERSRC {
            get {
                return this.xFERSRCField;
            }
            set {
                this.xFERSRCField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType XFERDEST {
            get {
                return this.xFERDESTField;
            }
            set {
                this.xFERDESTField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ServiceStatusEnum SVCSTATUS {
            get {
                return this.sVCSTATUSField;
            }
            set {
                this.sVCSTATUSField = value;
            }
        }
    }
}