namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class Tax1098MessageSet : AbstractMessageSet {
        
        private Tax1098MessageSetV1 tAX1098MSGSETV1Field;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Tax1098MessageSetV1 TAX1098MSGSETV1 {
            get {
                return tAX1098MSGSETV1Field;
            }
            set {
                tAX1098MSGSETV1Field = value;
            }
        }
    }
}