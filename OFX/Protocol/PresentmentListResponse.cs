namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class PresentmentListResponse {
        
        private string bILLPUBField;
        
        private string uSERIDField;
        
        private string dTSTARTField;
        
        private string dTENDField;
        
        private PresentmentBillInfo[] pRESLISTField;
        
        private PresentmentCounts pRESCOUNTSField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string BILLPUB {
            get {
                return bILLPUBField;
            }
            set {
                bILLPUBField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string USERID {
            get {
                return uSERIDField;
            }
            set {
                uSERIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DTSTART {
            get {
                return dTSTARTField;
            }
            set {
                dTSTARTField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DTEND {
            get {
                return dTENDField;
            }
            set {
                dTENDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute("PRESBILLINFO", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        public PresentmentBillInfo[] PRESLIST {
            get {
                return pRESLISTField;
            }
            set {
                pRESLISTField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PresentmentCounts PRESCOUNTS {
            get {
                return pRESCOUNTSField;
            }
            set {
                pRESCOUNTSField = value;
            }
        }
    }
}