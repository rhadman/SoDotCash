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
                return cCACCTFROMField;
            }
            set {
                cCACCTFROMField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType SUPTXDL {
            get {
                return sUPTXDLField;
            }
            set {
                sUPTXDLField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType XFERSRC {
            get {
                return xFERSRCField;
            }
            set {
                xFERSRCField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType XFERDEST {
            get {
                return xFERDESTField;
            }
            set {
                xFERDESTField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ServiceStatusEnum SVCSTATUS {
            get {
                return sVCSTATUSField;
            }
            set {
                sVCSTATUSField = value;
            }
        }
    }
}