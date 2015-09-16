namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class AccountRequest {
        
        private AbstractServiceAction itemField;
        
        private ServiceEnum sVCField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SVCADD", typeof(ServiceAdd), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("SVCCHG", typeof(ServiceChange), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("SVCDEL", typeof(ServiceDelete), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public AbstractServiceAction Item {
            get {
                return itemField;
            }
            set {
                itemField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ServiceEnum SVC {
            get {
                return sVCField;
            }
            set {
                sVCField = value;
            }
        }
    }
}