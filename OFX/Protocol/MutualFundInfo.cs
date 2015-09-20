namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class MutualFundInfo : AbstractSecurityInfo {
        
        private MutualFundTypeEnum mFTYPEField;
        
        private bool mFTYPEFieldSpecified;
        
        private string yIELDField;
        
        private string dTYIELDASOFField;
        
        private Portion[] mFASSETCLASSField;
        
        private FinancialInstitutionPortion[] fIMFASSETCLASSField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public MutualFundTypeEnum MFTYPE {
            get {
                return mFTYPEField;
            }
            set {
                mFTYPEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MFTYPESpecified {
            get {
                return mFTYPEFieldSpecified;
            }
            set {
                mFTYPEFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string YIELD {
            get {
                return yIELDField;
            }
            set {
                yIELDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DTYIELDASOF {
            get {
                return dTYIELDASOFField;
            }
            set {
                dTYIELDASOFField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute("PORTION", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        public Portion[] MFASSETCLASS {
            get {
                return mFASSETCLASSField;
            }
            set {
                mFASSETCLASSField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute("FIPORTION", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        public FinancialInstitutionPortion[] FIMFASSETCLASS {
            get {
                return fIMFASSETCLASSField;
            }
            set {
                fIMFASSETCLASSField = value;
            }
        }
    }
}