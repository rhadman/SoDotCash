namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class PresentmentDlvProfile {
        
        private BooleanType cANSUPPORTGROUPIDField;
        
        private DaysEnum[] pROCDAYSOFFField;
        
        private BooleanType cANSUPPORTIMAGESField;
        
        private string pROCENDTMField;
        
        private BooleanType cANUPDATEPRESNAMEADDRESSField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType CANSUPPORTGROUPID {
            get {
                return this.cANSUPPORTGROUPIDField;
            }
            set {
                this.cANSUPPORTGROUPIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PROCDAYSOFF", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public DaysEnum[] PROCDAYSOFF {
            get {
                return this.pROCDAYSOFFField;
            }
            set {
                this.pROCDAYSOFFField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType CANSUPPORTIMAGES {
            get {
                return this.cANSUPPORTIMAGESField;
            }
            set {
                this.cANSUPPORTIMAGESField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string PROCENDTM {
            get {
                return this.pROCENDTMField;
            }
            set {
                this.pROCENDTMField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType CANUPDATEPRESNAMEADDRESS {
            get {
                return this.cANUPDATEPRESNAMEADDRESSField;
            }
            set {
                this.cANUPDATEPRESNAMEADDRESSField = value;
            }
        }
    }
}