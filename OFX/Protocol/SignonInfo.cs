namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class SignonInfo {
        
        private string sIGNONREALMField;
        
        private string mINField;
        
        private string mAXField;
        
        private CharTypeEnum cHARTYPEField;
        
        private BooleanType cASESENField;
        
        private BooleanType sPECIALField;
        
        private BooleanType sPACESField;
        
        private BooleanType pINCHField;
        
        private BooleanType cHGPINFIRSTField;
        
        private string uSERCRED1LABELField;
        
        private string uSERCRED2LABELField;
        
        private BooleanType cLIENTUIDREQField;
        
        private bool cLIENTUIDREQFieldSpecified;
        
        private BooleanType aUTHTOKENFIRSTField;
        
        private bool aUTHTOKENFIRSTFieldSpecified;
        
        private string aUTHTOKENLABELField;
        
        private string aUTHTOKENINFOURLField;
        
        private BooleanType mFACHALLENGESUPTField;
        
        private bool mFACHALLENGESUPTFieldSpecified;
        
        private BooleanType mFACHALLENGEFIRSTField;
        
        private bool mFACHALLENGEFIRSTFieldSpecified;
        
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
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string MIN {
            get {
                return this.mINField;
            }
            set {
                this.mINField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string MAX {
            get {
                return this.mAXField;
            }
            set {
                this.mAXField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public CharTypeEnum CHARTYPE {
            get {
                return this.cHARTYPEField;
            }
            set {
                this.cHARTYPEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType CASESEN {
            get {
                return this.cASESENField;
            }
            set {
                this.cASESENField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType SPECIAL {
            get {
                return this.sPECIALField;
            }
            set {
                this.sPECIALField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType SPACES {
            get {
                return this.sPACESField;
            }
            set {
                this.sPACESField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType PINCH {
            get {
                return this.pINCHField;
            }
            set {
                this.pINCHField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType CHGPINFIRST {
            get {
                return this.cHGPINFIRSTField;
            }
            set {
                this.cHGPINFIRSTField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string USERCRED1LABEL {
            get {
                return this.uSERCRED1LABELField;
            }
            set {
                this.uSERCRED1LABELField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string USERCRED2LABEL {
            get {
                return this.uSERCRED2LABELField;
            }
            set {
                this.uSERCRED2LABELField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType CLIENTUIDREQ {
            get {
                return this.cLIENTUIDREQField;
            }
            set {
                this.cLIENTUIDREQField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CLIENTUIDREQSpecified {
            get {
                return this.cLIENTUIDREQFieldSpecified;
            }
            set {
                this.cLIENTUIDREQFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType AUTHTOKENFIRST {
            get {
                return this.aUTHTOKENFIRSTField;
            }
            set {
                this.aUTHTOKENFIRSTField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AUTHTOKENFIRSTSpecified {
            get {
                return this.aUTHTOKENFIRSTFieldSpecified;
            }
            set {
                this.aUTHTOKENFIRSTFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string AUTHTOKENLABEL {
            get {
                return this.aUTHTOKENLABELField;
            }
            set {
                this.aUTHTOKENLABELField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string AUTHTOKENINFOURL {
            get {
                return this.aUTHTOKENINFOURLField;
            }
            set {
                this.aUTHTOKENINFOURLField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType MFACHALLENGESUPT {
            get {
                return this.mFACHALLENGESUPTField;
            }
            set {
                this.mFACHALLENGESUPTField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MFACHALLENGESUPTSpecified {
            get {
                return this.mFACHALLENGESUPTFieldSpecified;
            }
            set {
                this.mFACHALLENGESUPTFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType MFACHALLENGEFIRST {
            get {
                return this.mFACHALLENGEFIRSTField;
            }
            set {
                this.mFACHALLENGEFIRSTField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MFACHALLENGEFIRSTSpecified {
            get {
                return this.mFACHALLENGEFIRSTFieldSpecified;
            }
            set {
                this.mFACHALLENGEFIRSTFieldSpecified = value;
            }
        }
    }
}