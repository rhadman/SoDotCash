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
                return sIGNONREALMField;
            }
            set {
                sIGNONREALMField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string MIN {
            get {
                return mINField;
            }
            set {
                mINField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string MAX {
            get {
                return mAXField;
            }
            set {
                mAXField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public CharTypeEnum CHARTYPE {
            get {
                return cHARTYPEField;
            }
            set {
                cHARTYPEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType CASESEN {
            get {
                return cASESENField;
            }
            set {
                cASESENField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType SPECIAL {
            get {
                return sPECIALField;
            }
            set {
                sPECIALField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType SPACES {
            get {
                return sPACESField;
            }
            set {
                sPACESField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType PINCH {
            get {
                return pINCHField;
            }
            set {
                pINCHField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType CHGPINFIRST {
            get {
                return cHGPINFIRSTField;
            }
            set {
                cHGPINFIRSTField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string USERCRED1LABEL {
            get {
                return uSERCRED1LABELField;
            }
            set {
                uSERCRED1LABELField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string USERCRED2LABEL {
            get {
                return uSERCRED2LABELField;
            }
            set {
                uSERCRED2LABELField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType CLIENTUIDREQ {
            get {
                return cLIENTUIDREQField;
            }
            set {
                cLIENTUIDREQField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CLIENTUIDREQSpecified {
            get {
                return cLIENTUIDREQFieldSpecified;
            }
            set {
                cLIENTUIDREQFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType AUTHTOKENFIRST {
            get {
                return aUTHTOKENFIRSTField;
            }
            set {
                aUTHTOKENFIRSTField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AUTHTOKENFIRSTSpecified {
            get {
                return aUTHTOKENFIRSTFieldSpecified;
            }
            set {
                aUTHTOKENFIRSTFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string AUTHTOKENLABEL {
            get {
                return aUTHTOKENLABELField;
            }
            set {
                aUTHTOKENLABELField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string AUTHTOKENINFOURL {
            get {
                return aUTHTOKENINFOURLField;
            }
            set {
                aUTHTOKENINFOURLField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType MFACHALLENGESUPT {
            get {
                return mFACHALLENGESUPTField;
            }
            set {
                mFACHALLENGESUPTField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MFACHALLENGESUPTSpecified {
            get {
                return mFACHALLENGESUPTFieldSpecified;
            }
            set {
                mFACHALLENGESUPTFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType MFACHALLENGEFIRST {
            get {
                return mFACHALLENGEFIRSTField;
            }
            set {
                mFACHALLENGEFIRSTField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MFACHALLENGEFIRSTSpecified {
            get {
                return mFACHALLENGEFIRSTFieldSpecified;
            }
            set {
                mFACHALLENGEFIRSTFieldSpecified = value;
            }
        }
    }
}