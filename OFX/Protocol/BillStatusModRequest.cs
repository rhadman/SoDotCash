namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class BillStatusModRequest {
        
        private string bILLIDField;
        
        private BillStatus bILLSTATUSField;
        
        private BillPaymentstatus bILLPMTSTATUSField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string BILLID {
            get {
                return bILLIDField;
            }
            set {
                bILLIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BillStatus BILLSTATUS {
            get {
                return bILLSTATUSField;
            }
            set {
                bILLSTATUSField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BillPaymentstatus BILLPMTSTATUS {
            get {
                return bILLPMTSTATUSField;
            }
            set {
                bILLPMTSTATUSField = value;
            }
        }
    }
}