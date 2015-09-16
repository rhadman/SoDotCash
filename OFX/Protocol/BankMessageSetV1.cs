namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class BankMessageSetV1 : AbstractMessageSetVersion {
        
        private AccountEnum[] iNVALIDACCTTYPEField;
        
        private BooleanType cLOSINGAVAILField;
        
        private TransferProfile xFERPROFField;
        
        private StopCheckProfile sTPCHKPROFField;
        
        private EmailProfile eMAILPROFField;
        
        private ImageProfile iMAGEPROFField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("INVALIDACCTTYPE", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public AccountEnum[] INVALIDACCTTYPE {
            get {
                return this.iNVALIDACCTTYPEField;
            }
            set {
                this.iNVALIDACCTTYPEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType CLOSINGAVAIL {
            get {
                return this.cLOSINGAVAILField;
            }
            set {
                this.cLOSINGAVAILField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public TransferProfile XFERPROF {
            get {
                return this.xFERPROFField;
            }
            set {
                this.xFERPROFField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public StopCheckProfile STPCHKPROF {
            get {
                return this.sTPCHKPROFField;
            }
            set {
                this.sTPCHKPROFField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public EmailProfile EMAILPROF {
            get {
                return this.eMAILPROFField;
            }
            set {
                this.eMAILPROFField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ImageProfile IMAGEPROF {
            get {
                return this.iMAGEPROFField;
            }
            set {
                this.iMAGEPROFField = value;
            }
        }
    }
}