namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class PresentmentMailSyncRequest : AbstractSyncRequest {
        
        private BooleanType iNCIMAGESField;
        
        private BooleanType uSEHTMLField;
        
        private PresentmentAccount pRESACCTFROMField;
        
        private PresentmentMailTransactionRequest[] pRESMAILTRNRQField;
        
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
        public PresentmentAccount PRESACCTFROM {
            get {
                return pRESACCTFROMField;
            }
            set {
                pRESACCTFROMField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PRESMAILTRNRQ", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PresentmentMailTransactionRequest[] PRESMAILTRNRQ {
            get {
                return pRESMAILTRNRQField;
            }
            set {
                pRESMAILTRNRQField = value;
            }
        }
    }
}