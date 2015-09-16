namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class EscrowAmount {
        
        private string eSCRWTOTALField;
        
        private string eSCRWTAXField;
        
        private string eSCRWINSField;
        
        private string eSCRWPMIField;
        
        private string eSCRWFEESField;
        
        private string eSCRWOTHERField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ESCRWTOTAL {
            get {
                return eSCRWTOTALField;
            }
            set {
                eSCRWTOTALField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ESCRWTAX {
            get {
                return eSCRWTAXField;
            }
            set {
                eSCRWTAXField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ESCRWINS {
            get {
                return eSCRWINSField;
            }
            set {
                eSCRWINSField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ESCRWPMI {
            get {
                return eSCRWPMIField;
            }
            set {
                eSCRWPMIField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ESCRWFEES {
            get {
                return eSCRWFEESField;
            }
            set {
                eSCRWFEESField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ESCRWOTHER {
            get {
                return eSCRWOTHERField;
            }
            set {
                eSCRWOTHERField = value;
            }
        }
    }
}