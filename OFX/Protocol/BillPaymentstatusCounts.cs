namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class BillPaymentstatusCounts {
        
        private BillPaymentstatusCodeEnum bILLPMTSTATUSCODEField;
        
        private string cOUNTField;
        
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
        public string COUNT {
            get {
                return cOUNTField;
            }
            set {
                cOUNTField = value;
            }
        }
    }
}