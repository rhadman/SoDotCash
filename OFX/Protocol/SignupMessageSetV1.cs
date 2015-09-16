namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class SignupMessageSetV1 : AbstractMessageSetVersion {
        
        private object itemField;
        
        private BooleanType cHGUSERINFOField;
        
        private BooleanType aVAILACCTSField;
        
        private BooleanType cLIENTACTREQField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CLIENTENROLL", typeof(ClientEnroll), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("OTHERENROLL", typeof(OtherEnroll), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("WEBENROLL", typeof(WebEnroll), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public object Item {
            get {
                return itemField;
            }
            set {
                itemField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType CHGUSERINFO {
            get {
                return cHGUSERINFOField;
            }
            set {
                cHGUSERINFOField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType AVAILACCTS {
            get {
                return aVAILACCTSField;
            }
            set {
                aVAILACCTSField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType CLIENTACTREQ {
            get {
                return cLIENTACTREQField;
            }
            set {
                cLIENTACTREQField = value;
            }
        }
    }
}