namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class PresentmentListTransactionRequest : AbstractTransactionRequest {
        
        private string itemField;
        
        private ItemChoiceType2 itemElementNameField;
        
        private PresentmentListRequest pRESLISTRQField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("GROUPID", typeof(string), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("USERID", typeof(string), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public string Item {
            get {
                return itemField;
            }
            set {
                itemField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType2 ItemElementName {
            get {
                return itemElementNameField;
            }
            set {
                itemElementNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PresentmentListRequest PRESLISTRQ {
            get {
                return pRESLISTRQField;
            }
            set {
                pRESLISTRQField = value;
            }
        }
    }
}