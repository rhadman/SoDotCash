namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class InvestmentStatementMessageSet : AbstractMessageSet {
        
        private InvestmentStatementMessageSetV1 iNVSTMTMSGSETV1Field;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public InvestmentStatementMessageSetV1 INVSTMTMSGSETV1 {
            get {
                return iNVSTMTMSGSETV1Field;
            }
            set {
                iNVSTMTMSGSETV1Field = value;
            }
        }
    }
}