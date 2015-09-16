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
                return pROCDAYSOFFField;
            }
            set {
                pROCDAYSOFFField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string PROCENDTM {
            get {
                return pROCENDTMField;
            }
            set {
                pROCENDTMField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType CANSCHED {
            get {
                return cANSCHEDField;
            }
            set {
                cANSCHEDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType CANRECUR {
            get {
                return cANRECURField;
            }
            set {
                cANRECURField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType CANLOAN {
            get {
                return cANLOANField;
            }
            set {
                cANLOANField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CANLOANSpecified {
            get {
                return cANLOANFieldSpecified;
            }
            set {
                cANLOANFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType CANSCHEDLOAN {
            get {
                return cANSCHEDLOANField;
            }
            set {
                cANSCHEDLOANField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CANSCHEDLOANSpecified {
            get {
                return cANSCHEDLOANFieldSpecified;
            }
            set {
                cANSCHEDLOANFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType CANRECURLOAN {
            get {
                return cANRECURLOANField;
            }
            set {
                cANRECURLOANField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CANRECURLOANSpecified {
            get {
                return cANRECURLOANFieldSpecified;
            }
            set {
                cANRECURLOANFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType CANMODXFERS {
            get {
                return cANMODXFERSField;
            }
            set {
                cANMODXFERSField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType CANMODMDLS {
            get {
                return cANMODMDLSField;
            }
            set {
                cANMODMDLSField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string MODELWND {
            get {
                return mODELWNDField;
            }
            set {
                mODELWNDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DAYSWITH {
            get {
                return dAYSWITHField;
            }
            set {
                dAYSWITHField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DFLTDAYSTOPAY {
            get {
                return dFLTDAYSTOPAYField;
            }
            set {
                dFLTDAYSTOPAYField = value;
            }
        }
    }
}