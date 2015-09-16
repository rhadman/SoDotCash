namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class PresentmentDetailTransactionResponse : AbstractTransactionResponse {
        
        private PresentmentDetail[] pRESDETAILRSField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute("PRESDETAIL", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        public PresentmentDetail[] PRESDETAILRS {
            get {
                return pRESDETAILRSField;
            }
            set {
                pRESDETAILRSField = value;
            }
        }
    }
}