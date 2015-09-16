namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class BillStatus {
        
        private BillStatusCodeEnum bILLSTATUSCODEField;
        
        private string dTEFFField;
        
        private StatusModBYEnum sTATUSMODBYField;
        
        private bool sTATUSMODBYFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BillStatusCodeEnum BILLSTATUSCODE {
            get {
                return this.bILLSTATUSCODEField;
            }
            set {
                this.bILLSTATUSCODEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DTEFF {
            get {
                return this.dTEFFField;
            }
            set {
                this.dTEFFField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public StatusModBYEnum STATUSMODBY {
            get {
                return this.sTATUSMODBYField;
            }
            set {
                this.sTATUSMODBYField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool STATUSMODBYSpecified {
            get {
                return this.sTATUSMODBYFieldSpecified;
            }
            set {
                this.sTATUSMODBYFieldSpecified = value;
            }
        }
    }
}