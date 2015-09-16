namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class PaymentInstrument {
        
        private PaymentInstrumentEnum pMTINSTRUMENTTYPEField;
        
        private string bRANDField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PaymentInstrumentEnum PMTINSTRUMENTTYPE {
            get {
                return this.pMTINSTRUMENTTYPEField;
            }
            set {
                this.pMTINSTRUMENTTYPEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string BRAND {
            get {
                return this.bRANDField;
            }
            set {
                this.bRANDField = value;
            }
        }
    }
}