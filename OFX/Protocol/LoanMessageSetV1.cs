namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class LoanMessageSetV1 : AbstractMessageSetVersion {
        
        private BooleanType tRANDNLDField;
        
        private BooleanType cLOSINGAVAILField;
        
        private BooleanType aMRTAVAILField;
        
        private BooleanType cANEMAILField;
        
        private ImageProfile iMAGEPROFField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType TRANDNLD {
            get {
                return this.tRANDNLDField;
            }
            set {
                this.tRANDNLDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType CLOSINGAVAIL {
            get {
                return this.cLOSINGAVAILField;
            }
            set {
                this.cLOSINGAVAILField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType AMRTAVAIL {
            get {
                return this.aMRTAVAILField;
            }
            set {
                this.aMRTAVAILField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType CANEMAIL {
            get {
                return this.cANEMAILField;
            }
            set {
                this.cANEMAILField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ImageProfile IMAGEPROF {
            get {
                return this.iMAGEPROFField;
            }
            set {
                this.iMAGEPROFField = value;
            }
        }
    }
}