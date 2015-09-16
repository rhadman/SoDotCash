namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class RecurringPaymentRequest : AbstractRecurringPaymentRequest {
        
        private RecurringInstructions rECURRINSTField;
        
        private PaymentInfo pMTINFOField;
        
        private string iNITIALAMTField;
        
        private string fINALAMTField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public RecurringInstructions RECURRINST {
            get {
                return rECURRINSTField;
            }
            set {
                rECURRINSTField = value;
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
        public string INITIALAMT {
            get {
                return iNITIALAMTField;
            }
            set {
                iNITIALAMTField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string FINALAMT {
            get {
                return fINALAMTField;
            }
            set {
                fINALAMTField = value;
            }
        }
    }
}