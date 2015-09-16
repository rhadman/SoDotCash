namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class BillStatusCounts {
        
        private BillStatusCodeEnum bILLSTATUSCODEField;
        
        private string cOUNTField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BillStatusCodeEnum BILLSTATUSCODE {
            get {
                return bILLSTATUSCODEField;
            }
            set {
                bILLSTATUSCODEField = value;
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