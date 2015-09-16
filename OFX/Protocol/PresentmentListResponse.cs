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
                return this.bILLPUBField;
            }
            set {
                this.bILLPUBField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string USERID {
            get {
                return this.uSERIDField;
            }
            set {
                this.uSERIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DTSTART {
            get {
                return this.dTSTARTField;
            }
            set {
                this.dTSTARTField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DTEND {
            get {
                return this.dTENDField;
            }
            set {
                this.dTENDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute("PRESBILLINFO", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        public PresentmentBillInfo[] PRESLIST {
            get {
                return this.pRESLISTField;
            }
            set {
                this.pRESLISTField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PresentmentCounts PRESCOUNTS {
            get {
                return this.pRESCOUNTSField;
            }
            set {
                this.pRESCOUNTSField = value;
            }
        }
    }
}