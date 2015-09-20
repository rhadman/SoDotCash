namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class BillTableStructureTransactionResponse : AbstractTransactionResponse {
        
        private BillTableStructureResponse bILLTBLSTRUCTRSField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BillTableStructureResponse BILLTBLSTRUCTRS {
            get {
                return bILLTBLSTRUCTRSField;
            }
            set {
                bILLTBLSTRUCTRSField = value;
            }
        }
    }
}