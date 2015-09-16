namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class BillPaymentstatus {
        
        private string sRVRTIDField;
        
        private BillPaymentstatusCodeEnum bILLPMTSTATUSCODEField;
        
        private string dTEFFField;
        
        private StatusModBYEnum sTATUSMODBYField;
        
        private bool sTATUSMODBYFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string SRVRTID {
            get {
                return sRVRTIDField;
            }
            set {
                sRVRTIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BillPaymentstatusCodeEnum BILLPMTSTATUSCODE {
            get {
                return bILLPMTSTATUSCODEField;
            }
            set {
                bILLPMTSTATUSCODEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DTEFF {
            get {
                return dTEFFField;
            }
            set {
                dTEFFField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public StatusModBYEnum STATUSMODBY {
            get {
                return sTATUSMODBYField;
            }
            set {
                sTATUSMODBYField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool STATUSMODBYSpecified {
            get {
                return sTATUSMODBYFieldSpecified;
            }
            set {
                sTATUSMODBYFieldSpecified = value;
            }
        }
    }
}