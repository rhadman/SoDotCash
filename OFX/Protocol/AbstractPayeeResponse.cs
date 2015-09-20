namespace OFX.Protocol
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PayeeDeleteResponse))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PayeeModResponse))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PayeeResponse))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public abstract partial class AbstractPayeeResponse {
        
        private string pAYEELSTIDField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string PAYEELSTID {
            get {
                return pAYEELSTIDField;
            }
            set {
                pAYEELSTIDField = value;
            }
        }
    }
}