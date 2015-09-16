namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class StopCheckProfile {
        
        private DaysEnum[] pROCDAYSOFFField;
        
        private string pROCENDTMField;
        
        private BooleanType cANUSERANGEField;
        
        private BooleanType cANUSEDESCField;
        
        private string sTPCHKFEEField;
        
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
        public BooleanType CANUSERANGE {
            get {
                return cANUSERANGEField;
            }
            set {
                cANUSERANGEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType CANUSEDESC {
            get {
                return cANUSEDESCField;
            }
            set {
                cANUSEDESCField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string STPCHKFEE {
            get {
                return sTPCHKFEEField;
            }
            set {
                sTPCHKFEEField = value;
            }
        }
    }
}