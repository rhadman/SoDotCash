namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class PresentmentGroupAccountInfoTransactionRequest : AbstractTransactionRequest {
        
        private string itemField;
        
        private ItemChoiceType1 itemElementNameField;
        
        private AccountInfoRequest aCCTINFORQField;
        
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
        public ItemChoiceType1 ItemElementName {
            get {
                return itemElementNameField;
            }
            set {
                itemElementNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public AccountInfoRequest ACCTINFORQ {
            get {
                return aCCTINFORQField;
            }
            set {
                aCCTINFORQField = value;
            }
        }
    }
}