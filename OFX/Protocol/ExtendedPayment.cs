namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class ExtendedPayment {
        
        private ExtendedPaymentForEnum eXTDPMTFORField;
        
        private bool eXTDPMTFORFieldSpecified;
        
        private string eXTDPMTCHKField;
        
        private object[] itemsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ExtendedPaymentForEnum EXTDPMTFOR {
            get {
                return eXTDPMTFORField;
            }
            set {
                eXTDPMTFORField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool EXTDPMTFORSpecified {
            get {
                return eXTDPMTFORFieldSpecified;
            }
            set {
                eXTDPMTFORFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string EXTDPMTCHK {
            get {
                return eXTDPMTCHKField;
            }
            set {
                eXTDPMTCHKField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EXTDPMTDSC", typeof(string), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("EXTDPMTINV", typeof(ExtendedPaymentInvoice), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public object[] Items {
            get {
                return itemsField;
            }
            set {
                itemsField = value;
            }
        }
    }
}