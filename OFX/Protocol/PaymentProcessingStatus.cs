namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class PaymentProcessingStatus {
        
        private PaymentProcessStatusEnum pMTPRCCODEField;
        
        private string dTPMTPRCField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PaymentProcessStatusEnum PMTPRCCODE {
            get {
                return pMTPRCCODEField;
            }
            set {
                pMTPRCCODEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DTPMTPRC {
            get {
                return dTPMTPRCField;
            }
            set {
                dTPMTPRCField = value;
            }
        }
    }
}