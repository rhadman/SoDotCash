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
                return vERField;
            }
            set {
                vERField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string URL {
            get {
                return uRLField;
            }
            set {
                uRLField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SecurityEnum OFXSEC {
            get {
                return oFXSECField;
            }
            set {
                oFXSECField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType TRANSPSEC {
            get {
                return tRANSPSECField;
            }
            set {
                tRANSPSECField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string SIGNONREALM {
            get {
                return sIGNONREALMField;
            }
            set {
                sIGNONREALMField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("LANGUAGE", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public LanguageEnum[] LANGUAGE {
            get {
                return lANGUAGEField;
            }
            set {
                lANGUAGEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SyncEnum SYNCMODE {
            get {
                return sYNCMODEField;
            }
            set {
                sYNCMODEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType REFRESHSUPT {
            get {
                return rEFRESHSUPTField;
            }
            set {
                rEFRESHSUPTField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool REFRESHSUPTSpecified {
            get {
                return rEFRESHSUPTFieldSpecified;
            }
            set {
                rEFRESHSUPTFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType RESPFILEER {
            get {
                return rESPFILEERField;
            }
            set {
                rESPFILEERField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string SPNAME {
            get {
                return sPNAMEField;
            }
            set {
                sPNAMEField = value;
            }
        }
    }
}