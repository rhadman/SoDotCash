namespace OFX.Protocol
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PaymentCancelResponse))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PaymentModResponse))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PaymentResponse))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public abstract partial class AbstractPaymentResponse {
        
        private string sRVRTIDField;
        
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
    }
}