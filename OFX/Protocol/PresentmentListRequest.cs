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
                return bILLPUBField;
            }
            set {
                bILLPUBField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DTSTART {
            get {
                return dTSTARTField;
            }
            set {
                dTSTARTField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DTEND {
            get {
                return dTENDField;
            }
            set {
                dTENDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DTDUEBY {
            get {
                return dTDUEBYField;
            }
            set {
                dTDUEBYField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string BILLERID {
            get {
                return bILLERIDField;
            }
            set {
                bILLERIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string BILLID {
            get {
                return bILLIDField;
            }
            set {
                bILLIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BILLTYPE", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BillTypeEnum[] BILLTYPE {
            get {
                return bILLTYPEField;
            }
            set {
                bILLTYPEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BILLSTATUSCODE", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BillStatusCodeEnum[] BILLSTATUSCODE {
            get {
                return bILLSTATUSCODEField;
            }
            set {
                bILLSTATUSCODEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BILLPMTSTATUSCODE", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BillPaymentstatusCodeEnum[] BILLPMTSTATUSCODE {
            get {
                return bILLPMTSTATUSCODEField;
            }
            set {
                bILLPMTSTATUSCODEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType NOTIFYWILLING {
            get {
                return nOTIFYWILLINGField;
            }
            set {
                nOTIFYWILLINGField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType INCLUDEDETAIL {
            get {
                return iNCLUDEDETAILField;
            }
            set {
                iNCLUDEDETAILField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType INCLUDEBILLSTATUS {
            get {
                return iNCLUDEBILLSTATUSField;
            }
            set {
                iNCLUDEBILLSTATUSField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool INCLUDEBILLSTATUSSpecified {
            get {
                return iNCLUDEBILLSTATUSFieldSpecified;
            }
            set {
                iNCLUDEBILLSTATUSFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType INCLUDEBILLPMTSTATUS {
            get {
                return iNCLUDEBILLPMTSTATUSField;
            }
            set {
                iNCLUDEBILLPMTSTATUSField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool INCLUDEBILLPMTSTATUSSpecified {
            get {
                return iNCLUDEBILLPMTSTATUSFieldSpecified;
            }
            set {
                iNCLUDEBILLPMTSTATUSFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType INCLUDESTATUSHIST {
            get {
                return iNCLUDESTATUSHISTField;
            }
            set {
                iNCLUDESTATUSHISTField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool INCLUDESTATUSHISTSpecified {
            get {
                return iNCLUDESTATUSHISTFieldSpecified;
            }
            set {
                iNCLUDESTATUSHISTFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType INCLUDECOUNTS {
            get {
                return iNCLUDECOUNTSField;
            }
            set {
                iNCLUDECOUNTSField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool INCLUDECOUNTSSpecified {
            get {
                return iNCLUDECOUNTSFieldSpecified;
            }
            set {
                iNCLUDECOUNTSFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType INCLUDESUMMARY {
            get {
                return iNCLUDESUMMARYField;
            }
            set {
                iNCLUDESUMMARYField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool INCLUDESUMMARYSpecified {
            get {
                return iNCLUDESUMMARYFieldSpecified;
            }
            set {
                iNCLUDESUMMARYFieldSpecified = value;
            }
        }
    }
}