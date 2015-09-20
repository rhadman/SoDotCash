namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class Contributions {
        
        private string pRETAXField;
        
        private string aFTERTAXField;
        
        private string mATCHField;
        
        private string pROFITSHARINGField;
        
        private string rOLLOVERField;
        
        private string oTHERVESTField;
        
        private string oTHERNONVESTField;
        
        private string tOTALField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string PRETAX {
            get {
                return pRETAXField;
            }
            set {
                pRETAXField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string AFTERTAX {
            get {
                return aFTERTAXField;
            }
            set {
                aFTERTAXField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string MATCH {
            get {
                return mATCHField;
            }
            set {
                mATCHField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string PROFITSHARING {
            get {
                return pROFITSHARINGField;
            }
            set {
                pROFITSHARINGField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ROLLOVER {
            get {
                return rOLLOVERField;
            }
            set {
                rOLLOVERField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string OTHERVEST {
            get {
                return oTHERVESTField;
            }
            set {
                oTHERVESTField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string OTHERNONVEST {
            get {
                return oTHERNONVESTField;
            }
            set {
                oTHERNONVESTField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string TOTAL {
            get {
                return tOTALField;
            }
            set {
                tOTALField = value;
            }
        }
    }
}