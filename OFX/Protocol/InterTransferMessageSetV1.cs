namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class InterTransferMessageSetV1 : AbstractMessageSetVersion {
        
        private TransferProfile xFERPROFField;
        
        private BooleanType cANBILLPAYField;
        
        private string cANCELWNDField;
        
        private string dOMXFERFEEField;
        
        private string iNTLXFERFEEField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public TransferProfile XFERPROF {
            get {
                return xFERPROFField;
            }
            set {
                xFERPROFField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType CANBILLPAY {
            get {
                return cANBILLPAYField;
            }
            set {
                cANBILLPAYField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string CANCELWND {
            get {
                return cANCELWNDField;
            }
            set {
                cANCELWNDField = value;
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