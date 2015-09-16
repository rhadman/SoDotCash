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
                return this.eSCRWTOTALField;
            }
            set {
                this.eSCRWTOTALField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ESCRWTAX {
            get {
                return this.eSCRWTAXField;
            }
            set {
                this.eSCRWTAXField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ESCRWINS {
            get {
                return this.eSCRWINSField;
            }
            set {
                this.eSCRWINSField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ESCRWPMI {
            get {
                return this.eSCRWPMIField;
            }
            set {
                this.eSCRWPMIField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ESCRWFEES {
            get {
                return this.eSCRWFEESField;
            }
            set {
                this.eSCRWFEESField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ESCRWOTHER {
            get {
                return this.eSCRWOTHERField;
            }
            set {
                this.eSCRWOTHERField = value;
            }
        }
    }
}