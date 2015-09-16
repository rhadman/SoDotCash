namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class MessageSetCore {
        
        private string vERField;
        
        private string uRLField;
        
        private SecurityEnum oFXSECField;
        
        private BooleanType tRANSPSECField;
        
        private string sIGNONREALMField;
        
        private LanguageEnum[] lANGUAGEField;
        
        private SyncEnum sYNCMODEField;
        
        private BooleanType rEFRESHSUPTField;
        
        private bool rEFRESHSUPTFieldSpecified;
        
        private BooleanType rESPFILEERField;
        
        private string sPNAMEField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string VER {
            get {
                return this.vERField;
            }
            set {
                this.vERField = value;
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
        public SecurityEnum OFXSEC {
            get {
                return this.oFXSECField;
            }
            set {
                this.oFXSECField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType TRANSPSEC {
            get {
                return this.tRANSPSECField;
            }
            set {
                this.tRANSPSECField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string SIGNONREALM {
            get {
                return this.sIGNONREALMField;
            }
            set {
                this.sIGNONREALMField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("LANGUAGE", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public LanguageEnum[] LANGUAGE {
            get {
                return this.lANGUAGEField;
            }
            set {
                this.lANGUAGEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SyncEnum SYNCMODE {
            get {
                return this.sYNCMODEField;
            }
            set {
                this.sYNCMODEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType REFRESHSUPT {
            get {
                return this.rEFRESHSUPTField;
            }
            set {
                this.rEFRESHSUPTField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool REFRESHSUPTSpecified {
            get {
                return this.rEFRESHSUPTFieldSpecified;
            }
            set {
                this.rEFRESHSUPTFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType RESPFILEER {
            get {
                return this.rESPFILEERField;
            }
            set {
                this.rESPFILEERField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string SPNAME {
            get {
                return this.sPNAMEField;
            }
            set {
                this.sPNAMEField = value;
            }
        }
    }
}