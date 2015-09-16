namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class PaymentInquiryResponse {
        
        private string sRVRTIDField;
        
        private PaymentProcessingStatus pMTPRCSTSField;
        
        private string cHECKNUMField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string SRVRTID {
            get {
                return this.sRVRTIDField;
            }
            set {
                this.sRVRTIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PaymentProcessingStatus PMTPRCSTS {
            get {
                return this.pMTPRCSTSField;
            }
            set {
                this.pMTPRCSTSField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string CHECKNUM {
            get {
                return this.cHECKNUMField;
            }
            set {
                this.cHECKNUMField = value;
            }
        }
    }
}