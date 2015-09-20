namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class PresentmentDeliveryRequestMessageSetV1 : AbstractRequestMessageSet {
        
        private AbstractRequest[] itemsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BILLSTATUSMODTRNRQ", typeof(BillStatusModTransactionRequest), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("BILLTBLSTRUCTTRNRQ", typeof(BillTableStructureTransactionRequest), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("PRESDETAILTRNRQ", typeof(PresentmentDetailTransactionRequest), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("PRESGRPACCTINFOTRNRQ", typeof(PresentmentGroupAccountInfoTransactionRequest), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("PRESLISTTRNRQ", typeof(PresentmentListTransactionRequest), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("PRESMAILSYNCRQ", typeof(PresentmentMailSyncRequest), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("PRESMAILTRNRQ", typeof(PresentmentMailTransactionRequest), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("PRESNOTIFYTRNRQ", typeof(PresentmentNotifyTransactionRequest), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public AbstractRequest[] Items {
            get {
                return itemsField;
            }
            set {
                itemsField = value;
            }
        }
    }
}