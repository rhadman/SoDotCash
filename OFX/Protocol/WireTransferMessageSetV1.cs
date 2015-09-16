namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class WireTransferMessageSetV1 : AbstractMessageSetVersion {
        
        private DaysEnum[] pROCDAYSOFFField;
        
        private string pROCENDTMField;
        
        private BooleanType cANSCHEDField;
        
        private string dOMXFERFEEField;
        
        private string iNTLXFERFEEField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PROCDAYSOFF", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public DaysEnum[] PROCDAYSOFF {
            get {
                return pROCDAYSOFFField;
            }
            set {
                pROCDAYSOFFField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string PROCENDTM {
            get {
                return pROCENDTMField;
            }
            set {
                pROCENDTMField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType CANSCHED {
            get {
                return cANSCHEDField;
            }
            set {
                cANSCHEDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DOMXFERFEE {
            get {
                return dOMXFERFEEField;
            }
            set {
                dOMXFERFEEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string INTLXFERFEE {
            get {
                return iNTLXFERFEEField;
            }
            set {
                iNTLXFERFEEField = value;
            }
        }
    }
}