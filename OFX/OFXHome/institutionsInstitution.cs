namespace OFX.OFXHome
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class institutionsInstitution {
        
        private string nameField;
        
        private string fidField;
        
        private string orgField;
        
        private string brokeridField;
        
        private string urlField;
        
        private string ofxfailField;
        
        private string sslfailField;
        
        private string lastofxvalidationField;
        
        private string lastsslvalidationField;
        
        private institutionsInstitutionProfile profileField;
        
        private short idField;
        
        private bool idFieldSpecified;
        
        /// <remarks/>
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        public string fid {
            get {
                return this.fidField;
            }
            set {
                this.fidField = value;
            }
        }
        
        /// <remarks/>
        public string org {
            get {
                return this.orgField;
            }
            set {
                this.orgField = value;
            }
        }
        
        /// <remarks/>
        public string brokerid {
            get {
                return this.brokeridField;
            }
            set {
                this.brokeridField = value;
            }
        }
        
        /// <remarks/>
        public string url {
            get {
                return this.urlField;
            }
            set {
                this.urlField = value;
            }
        }
        
        /// <remarks/>
        public string ofxfail {
            get {
                return this.ofxfailField;
            }
            set {
                this.ofxfailField = value;
            }
        }
        
        /// <remarks/>
        public string sslfail {
            get {
                return this.sslfailField;
            }
            set {
                this.sslfailField = value;
            }
        }
        
        /// <remarks/>
        public string lastofxvalidation {
            get {
                return this.lastofxvalidationField;
            }
            set {
                this.lastofxvalidationField = value;
            }
        }
        
        /// <remarks/>
        public string lastsslvalidation {
            get {
                return this.lastsslvalidationField;
            }
            set {
                this.lastsslvalidationField = value;
            }
        }
        
        /// <remarks/>
        public institutionsInstitutionProfile profile {
            get {
                return this.profileField;
            }
            set {
                this.profileField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public short id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool idSpecified {
            get {
                return this.idFieldSpecified;
            }
            set {
                this.idFieldSpecified = value;
            }
        }
    }
}