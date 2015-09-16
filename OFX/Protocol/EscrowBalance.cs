namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class EscrowBalance {
        
        private string bALAMTField;
        
        private string eSCRWTAXBALField;
        
        private string eSCRWINSBALField;
        
        private string eSCRWPMIBALField;
        
        private string eSCRWFEESBALField;
        
        private string eSCRWOTHERBALField;
        
        private string dTASOFField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string BALAMT {
            get {
                return this.bALAMTField;
            }
            set {
                this.bALAMTField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ESCRWTAXBAL {
            get {
                return this.eSCRWTAXBALField;
            }
            set {
                this.eSCRWTAXBALField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ESCRWINSBAL {
            get {
                return this.eSCRWINSBALField;
            }
            set {
                this.eSCRWINSBALField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ESCRWPMIBAL {
            get {
                return this.eSCRWPMIBALField;
            }
            set {
                this.eSCRWPMIBALField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ESCRWFEESBAL {
            get {
                return this.eSCRWFEESBALField;
            }
            set {
                this.eSCRWFEESBALField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ESCRWOTHERBAL {
            get {
                return this.eSCRWOTHERBALField;
            }
            set {
                this.eSCRWOTHERBALField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DTASOF {
            get {
                return this.dTASOFField;
            }
            set {
                this.dTASOFField = value;
            }
        }
    }
}