namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class SignupResponseMessageSetV1 : AbstractResponseMessageSet {
        
        private AbstractResponse[] itemsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ACCTINFOTRNRS", typeof(AccountInfoTransactionResponse), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("ACCTSYNCRS", typeof(AccountSyncResponse), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("ACCTTRNRS", typeof(AccountTransactionResponse), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("CHGUSERINFOSYNCRS", typeof(ChangeUserInfoSyncResponse), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("CHGUSERINFOTRNRS", typeof(ChangeUserInfoTransactionResponse), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("ENROLLTRNRS", typeof(EnrollTransactionResponse), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public AbstractResponse[] Items {
            get {
                return itemsField;
            }
            set {
                itemsField = value;
            }
        }
    }
}