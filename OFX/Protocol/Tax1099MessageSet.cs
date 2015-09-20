namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class Tax1099MessageSet : AbstractMessageSet {
        
        private Tax1099MessageSetV1 tAX1099MSGSETV1Field;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Tax1099MessageSetV1 TAX1099MSGSETV1 {
            get {
                return tAX1099MSGSETV1Field;
            }
            set {
                tAX1099MSGSETV1Field = value;
            }
        }
    }
}