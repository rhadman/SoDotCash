namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class PresentmentDetail {
        
        private string bILLIDField;
        
        private PresentmentAccount pRESACCTFROMField;
        
        private BillDetailTable[] bILLDETAILTABLEField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string BILLID {
            get {
                return bILLIDField;
            }
            set {
                bILLIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PresentmentAccount PRESACCTFROM {
            get {
                return pRESACCTFROMField;
            }
            set {
                pRESACCTFROMField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BILLDETAILTABLE", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BillDetailTable[] BILLDETAILTABLE {
            get {
                return bILLDETAILTABLEField;
            }
            set {
                bILLDETAILTABLEField = value;
            }
        }
    }
}