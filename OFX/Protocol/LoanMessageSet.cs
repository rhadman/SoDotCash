namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class LoanMessageSet : AbstractMessageSet {
        
        private LoanMessageSetV1 lOANMSGSETV1Field;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public LoanMessageSetV1 LOANMSGSETV1 {
            get {
                return lOANMSGSETV1Field;
            }
            set {
                lOANMSGSETV1Field = value;
            }
        }
    }
}