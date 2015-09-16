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
                return bALAMTField;
            }
            set {
                bALAMTField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ESCRWTAXBAL {
            get {
                return eSCRWTAXBALField;
            }
            set {
                eSCRWTAXBALField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ESCRWINSBAL {
            get {
                return eSCRWINSBALField;
            }
            set {
                eSCRWINSBALField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ESCRWPMIBAL {
            get {
                return eSCRWPMIBALField;
            }
            set {
                eSCRWPMIBALField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ESCRWFEESBAL {
            get {
                return eSCRWFEESBALField;
            }
            set {
                eSCRWFEESBALField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ESCRWOTHERBAL {
            get {
                return eSCRWOTHERBALField;
            }
            set {
                eSCRWOTHERBALField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DTASOF {
            get {
                return dTASOFField;
            }
            set {
                dTASOFField = value;
            }
        }
    }
}