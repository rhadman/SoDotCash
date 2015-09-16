namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class PaymentInquiryTransactionResponse : AbstractTransactionResponse {
        
        private PaymentInquiryResponse pMTINQRSField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PaymentInquiryResponse PMTINQRS {
            get {
                return pMTINQRSField;
            }
            set {
                pMTINQRSField = value;
            }
        }
    }
}