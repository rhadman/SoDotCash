namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class BankMailTransactionRequest : AbstractTransactionRequest {
        
        private BankMailRequest bANKMAILRQField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BankMailRequest BANKMAILRQ {
            get {
                return bANKMAILRQField;
            }
            set {
                bANKMAILRQField = value;
            }
        }
    }
}