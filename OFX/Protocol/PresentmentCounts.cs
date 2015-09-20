namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class PresentmentCounts {
        
        private BillStatusCounts[] bILLSTATUSCOUNTSField;
        
        private BillPaymentstatusCounts[] bILLPMTSTATUSCOUNTSField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BILLSTATUSCOUNTS", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BillStatusCounts[] BILLSTATUSCOUNTS {
            get {
                return bILLSTATUSCOUNTSField;
            }
            set {
                bILLSTATUSCOUNTSField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BILLPMTSTATUSCOUNTS", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BillPaymentstatusCounts[] BILLPMTSTATUSCOUNTS {
            get {
                return bILLPMTSTATUSCOUNTSField;
            }
            set {
                bILLPMTSTATUSCOUNTSField = value;
            }
        }
    }
}