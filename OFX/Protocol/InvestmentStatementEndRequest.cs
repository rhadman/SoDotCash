namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class InvestmentStatementEndRequest {
        
        private InvestmentAccount iNVACCTFROMField;
        
        private string dTSTARTField;
        
        private string dTENDField;
        
        private BooleanType iNCSTMTIMGField;
        
        private bool iNCSTMTIMGFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public InvestmentAccount INVACCTFROM {
            get {
                return iNVACCTFROMField;
            }
            set {
                iNVACCTFROMField = value;
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
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType INCSTMTIMG {
            get {
                return iNCSTMTIMGField;
            }
            set {
                iNCSTMTIMGField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool INCSTMTIMGSpecified {
            get {
                return iNCSTMTIMGFieldSpecified;
            }
            set {
                iNCSTMTIMGFieldSpecified = value;
            }
        }
    }
}