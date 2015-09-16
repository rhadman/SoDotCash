namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class MatchInfo {
        
        private string mATCHPCTField;
        
        private string mAXMATCHAMTField;
        
        private string mAXMATCHPCTField;
        
        private string sTARTOFYEARField;
        
        private string bASEMATCHAMTField;
        
        private string bASEMATCHPCTField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string MATCHPCT {
            get {
                return mATCHPCTField;
            }
            set {
                mATCHPCTField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string MAXMATCHAMT {
            get {
                return mAXMATCHAMTField;
            }
            set {
                mAXMATCHAMTField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string MAXMATCHPCT {
            get {
                return mAXMATCHPCTField;
            }
            set {
                mAXMATCHPCTField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string STARTOFYEAR {
            get {
                return sTARTOFYEARField;
            }
            set {
                sTARTOFYEARField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string BASEMATCHAMT {
            get {
                return bASEMATCHAMTField;
            }
            set {
                bASEMATCHAMTField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string BASEMATCHPCT {
            get {
                return bASEMATCHPCTField;
            }
            set {
                bASEMATCHPCTField = value;
            }
        }
    }
}