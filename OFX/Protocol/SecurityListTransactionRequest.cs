namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class SecurityListTransactionRequest : AbstractTransactionRequest {
        
        private SecurityRequest[] sECLISTRQField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute("SECRQ", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        public SecurityRequest[] SECLISTRQ {
            get {
                return sECLISTRQField;
            }
            set {
                sECLISTRQField = value;
            }
        }
    }
}