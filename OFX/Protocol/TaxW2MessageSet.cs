namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class TaxW2MessageSet : AbstractMessageSet {
        
        private TaxW2MessageSetV1 tAXW2MSGSETV1Field;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public TaxW2MessageSetV1 TAXW2MSGSETV1 {
            get {
                return tAXW2MSGSETV1Field;
            }
            set {
                tAXW2MSGSETV1Field = value;
            }
        }
    }
}