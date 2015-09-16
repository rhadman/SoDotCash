namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class InvestmentMailSyncRequest : AbstractSyncRequest {
        
        private BooleanType iNCIMAGESField;
        
        private BooleanType uSEHTMLField;
        
        private InvestmentAccount iNVACCTFROMField;
        
        private InvestmentMailTransactionRequest[] iNVMAILTRNRQField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType INCIMAGES {
            get {
                return iNCIMAGESField;
            }
            set {
                iNCIMAGESField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType USEHTML {
            get {
                return uSEHTMLField;
            }
            set {
                uSEHTMLField = value;
            }
        }
        
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
        [System.Xml.Serialization.XmlElementAttribute("INVMAILTRNRQ", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public InvestmentMailTransactionRequest[] INVMAILTRNRQ {
            get {
                return iNVMAILTRNRQField;
            }
            set {
                iNVMAILTRNRQField = value;
            }
        }
    }
}