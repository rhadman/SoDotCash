namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class PaymentResponse : AbstractPaymentResponse {
        
        private string pAYEELSTIDField;
        
        private CurrencyEnum cURDEFField;
        
        private PaymentInfo pMTINFOField;
        
        private ExtendedPayee eXTDPAYEEField;
        
        private string cHECKNUMField;
        
        private PaymentProcessingStatus pMTPRCSTSField;
        
        private string rECSRVRTIDField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string PAYEELSTID {
            get {
                return pAYEELSTIDField;
            }
            set {
                pAYEELSTIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public CurrencyEnum CURDEF {
            get {
                return cURDEFField;
            }
            set {
                cURDEFField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PaymentInfo PMTINFO {
            get {
                return pMTINFOField;
            }
            set {
                pMTINFOField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ExtendedPayee EXTDPAYEE {
            get {
                return eXTDPAYEEField;
            }
            set {
                eXTDPAYEEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string CHECKNUM {
            get {
                return cHECKNUMField;
            }
            set {
                cHECKNUMField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PaymentProcessingStatus PMTPRCSTS {
            get {
                return pMTPRCSTSField;
            }
            set {
                pMTPRCSTSField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string RECSRVRTID {
            get {
                return rECSRVRTIDField;
            }
            set {
                rECSRVRTIDField = value;
            }
        }
    }
}