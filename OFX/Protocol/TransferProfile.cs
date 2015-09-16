namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class TransferProfile {
        
        private DaysEnum[] pROCDAYSOFFField;
        
        private string pROCENDTMField;
        
        private BooleanType cANSCHEDField;
        
        private BooleanType cANRECURField;
        
        private BooleanType cANLOANField;
        
        private bool cANLOANFieldSpecified;
        
        private BooleanType cANSCHEDLOANField;
        
        private bool cANSCHEDLOANFieldSpecified;
        
        private BooleanType cANRECURLOANField;
        
        private bool cANRECURLOANFieldSpecified;
        
        private BooleanType cANMODXFERSField;
        
        private BooleanType cANMODMDLSField;
        
        private string mODELWNDField;
        
        private string dAYSWITHField;
        
        private string dFLTDAYSTOPAYField;
        
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
        public BooleanType CANSCHED {
            get {
                return this.cANSCHEDField;
            }
            set {
                this.cANSCHEDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType CANRECUR {
            get {
                return this.cANRECURField;
            }
            set {
                this.cANRECURField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType CANLOAN {
            get {
                return this.cANLOANField;
            }
            set {
                this.cANLOANField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CANLOANSpecified {
            get {
                return this.cANLOANFieldSpecified;
            }
            set {
                this.cANLOANFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType CANSCHEDLOAN {
            get {
                return this.cANSCHEDLOANField;
            }
            set {
                this.cANSCHEDLOANField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CANSCHEDLOANSpecified {
            get {
                return this.cANSCHEDLOANFieldSpecified;
            }
            set {
                this.cANSCHEDLOANFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType CANRECURLOAN {
            get {
                return this.cANRECURLOANField;
            }
            set {
                this.cANRECURLOANField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CANRECURLOANSpecified {
            get {
                return this.cANRECURLOANFieldSpecified;
            }
            set {
                this.cANRECURLOANFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType CANMODXFERS {
            get {
                return this.cANMODXFERSField;
            }
            set {
                this.cANMODXFERSField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType CANMODMDLS {
            get {
                return this.cANMODMDLSField;
            }
            set {
                this.cANMODMDLSField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string MODELWND {
            get {
                return this.mODELWNDField;
            }
            set {
                this.mODELWNDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DAYSWITH {
            get {
                return this.dAYSWITHField;
            }
            set {
                this.dAYSWITHField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DFLTDAYSTOPAY {
            get {
                return this.dFLTDAYSTOPAYField;
            }
            set {
                this.dFLTDAYSTOPAYField = value;
            }
        }
    }
}