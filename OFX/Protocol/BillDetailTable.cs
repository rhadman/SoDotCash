namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class BillDetailTable {
        
        private string tABLENAMEField;
        
        private string bILLDETAILTABLETYPEField;
        
        private BillDetailRow[] bILLDETAILROWField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string TABLENAME {
            get {
                return this.tABLENAMEField;
            }
            set {
                this.tABLENAMEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string BILLDETAILTABLETYPE {
            get {
                return this.bILLDETAILTABLETYPEField;
            }
            set {
                this.bILLDETAILTABLETYPEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BILLDETAILROW", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BillDetailRow[] BILLDETAILROW {
            get {
                return this.bILLDETAILROWField;
            }
            set {
                this.bILLDETAILROWField = value;
            }
        }
    }
}