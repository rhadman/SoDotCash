namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class ProfileResponse {
        
        private MessageSetList mSGSETLISTField;
        
        private SignonInfo[] sIGNONINFOLISTField;
        
        private string dTPROFUPField;
        
        private string fINAMEField;
        
        private string aDDR1Field;
        
        private string aDDR2Field;
        
        private string aDDR3Field;
        
        private string cITYField;
        
        private string sTATEField;
        
        private string pOSTALCODEField;
        
        private string cOUNTRYField;
        
        private string cSPHONEField;
        
        private string tSPHONEField;
        
        private string fAXPHONEField;
        
        private string uRLField;
        
        private string eMAILField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public MessageSetList MSGSETLIST {
            get {
                return this.mSGSETLISTField;
            }
            set {
                this.mSGSETLISTField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute("SIGNONINFO", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        public SignonInfo[] SIGNONINFOLIST {
            get {
                return this.sIGNONINFOLISTField;
            }
            set {
                this.sIGNONINFOLISTField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DTPROFUP {
            get {
                return this.dTPROFUPField;
            }
            set {
                this.dTPROFUPField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string FINAME {
            get {
                return this.fINAMEField;
            }
            set {
                this.fINAMEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ADDR1 {
            get {
                return this.aDDR1Field;
            }
            set {
                this.aDDR1Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ADDR2 {
            get {
                return this.aDDR2Field;
            }
            set {
                this.aDDR2Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ADDR3 {
            get {
                return this.aDDR3Field;
            }
            set {
                this.aDDR3Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string CITY {
            get {
                return this.cITYField;
            }
            set {
                this.cITYField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string STATE {
            get {
                return this.sTATEField;
            }
            set {
                this.sTATEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string POSTALCODE {
            get {
                return this.pOSTALCODEField;
            }
            set {
                this.pOSTALCODEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string COUNTRY {
            get {
                return this.cOUNTRYField;
            }
            set {
                this.cOUNTRYField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string CSPHONE {
            get {
                return this.cSPHONEField;
            }
            set {
                this.cSPHONEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string TSPHONE {
            get {
                return this.tSPHONEField;
            }
            set {
                this.tSPHONEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string FAXPHONE {
            get {
                return this.fAXPHONEField;
            }
            set {
                this.fAXPHONEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string URL {
            get {
                return this.uRLField;
            }
            set {
                this.uRLField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string EMAIL {
            get {
                return this.eMAILField;
            }
            set {
                this.eMAILField = value;
            }
        }
    }
}