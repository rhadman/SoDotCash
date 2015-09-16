namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class PresentmentListRequest {
        
        private string bILLPUBField;
        
        private string dTSTARTField;
        
        private string dTENDField;
        
        private string dTDUEBYField;
        
        private string bILLERIDField;
        
        private string bILLIDField;
        
        private BillTypeEnum[] bILLTYPEField;
        
        private BillStatusCodeEnum[] bILLSTATUSCODEField;
        
        private BillPaymentstatusCodeEnum[] bILLPMTSTATUSCODEField;
        
        private BooleanType nOTIFYWILLINGField;
        
        private BooleanType iNCLUDEDETAILField;
        
        private BooleanType iNCLUDEBILLSTATUSField;
        
        private bool iNCLUDEBILLSTATUSFieldSpecified;
        
        private BooleanType iNCLUDEBILLPMTSTATUSField;
        
        private bool iNCLUDEBILLPMTSTATUSFieldSpecified;
        
        private BooleanType iNCLUDESTATUSHISTField;
        
        private bool iNCLUDESTATUSHISTFieldSpecified;
        
        private BooleanType iNCLUDECOUNTSField;
        
        private bool iNCLUDECOUNTSFieldSpecified;
        
        private BooleanType iNCLUDESUMMARYField;
        
        private bool iNCLUDESUMMARYFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string BILLPUB {
            get {
                return this.bILLPUBField;
            }
            set {
                this.bILLPUBField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DTSTART {
            get {
                return this.dTSTARTField;
            }
            set {
                this.dTSTARTField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DTEND {
            get {
                return this.dTENDField;
            }
            set {
                this.dTENDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DTDUEBY {
            get {
                return this.dTDUEBYField;
            }
            set {
                this.dTDUEBYField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string BILLERID {
            get {
                return this.bILLERIDField;
            }
            set {
                this.bILLERIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string BILLID {
            get {
                return this.bILLIDField;
            }
            set {
                this.bILLIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BILLTYPE", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BillTypeEnum[] BILLTYPE {
            get {
                return this.bILLTYPEField;
            }
            set {
                this.bILLTYPEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BILLSTATUSCODE", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BillStatusCodeEnum[] BILLSTATUSCODE {
            get {
                return this.bILLSTATUSCODEField;
            }
            set {
                this.bILLSTATUSCODEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BILLPMTSTATUSCODE", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BillPaymentstatusCodeEnum[] BILLPMTSTATUSCODE {
            get {
                return this.bILLPMTSTATUSCODEField;
            }
            set {
                this.bILLPMTSTATUSCODEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType NOTIFYWILLING {
            get {
                return this.nOTIFYWILLINGField;
            }
            set {
                this.nOTIFYWILLINGField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType INCLUDEDETAIL {
            get {
                return this.iNCLUDEDETAILField;
            }
            set {
                this.iNCLUDEDETAILField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType INCLUDEBILLSTATUS {
            get {
                return this.iNCLUDEBILLSTATUSField;
            }
            set {
                this.iNCLUDEBILLSTATUSField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool INCLUDEBILLSTATUSSpecified {
            get {
                return this.iNCLUDEBILLSTATUSFieldSpecified;
            }
            set {
                this.iNCLUDEBILLSTATUSFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType INCLUDEBILLPMTSTATUS {
            get {
                return this.iNCLUDEBILLPMTSTATUSField;
            }
            set {
                this.iNCLUDEBILLPMTSTATUSField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool INCLUDEBILLPMTSTATUSSpecified {
            get {
                return this.iNCLUDEBILLPMTSTATUSFieldSpecified;
            }
            set {
                this.iNCLUDEBILLPMTSTATUSFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType INCLUDESTATUSHIST {
            get {
                return this.iNCLUDESTATUSHISTField;
            }
            set {
                this.iNCLUDESTATUSHISTField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool INCLUDESTATUSHISTSpecified {
            get {
                return this.iNCLUDESTATUSHISTFieldSpecified;
            }
            set {
                this.iNCLUDESTATUSHISTFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType INCLUDECOUNTS {
            get {
                return this.iNCLUDECOUNTSField;
            }
            set {
                this.iNCLUDECOUNTSField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool INCLUDECOUNTSSpecified {
            get {
                return this.iNCLUDECOUNTSFieldSpecified;
            }
            set {
                this.iNCLUDECOUNTSFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType INCLUDESUMMARY {
            get {
                return this.iNCLUDESUMMARYField;
            }
            set {
                this.iNCLUDESUMMARYField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool INCLUDESUMMARYSpecified {
            get {
                return this.iNCLUDESUMMARYFieldSpecified;
            }
            set {
                this.iNCLUDESUMMARYFieldSpecified = value;
            }
        }
    }
}