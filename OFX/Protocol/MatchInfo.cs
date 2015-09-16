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
                return this.mATCHPCTField;
            }
            set {
                this.mATCHPCTField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string MAXMATCHAMT {
            get {
                return this.mAXMATCHAMTField;
            }
            set {
                this.mAXMATCHAMTField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string MAXMATCHPCT {
            get {
                return this.mAXMATCHPCTField;
            }
            set {
                this.mAXMATCHPCTField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string STARTOFYEAR {
            get {
                return this.sTARTOFYEARField;
            }
            set {
                this.sTARTOFYEARField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string BASEMATCHAMT {
            get {
                return this.bASEMATCHAMTField;
            }
            set {
                this.bASEMATCHAMTField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string BASEMATCHPCT {
            get {
                return this.bASEMATCHPCTField;
            }
            set {
                this.bASEMATCHPCTField = value;
            }
        }
    }
}