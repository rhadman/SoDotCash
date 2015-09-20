namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class StocksBonds {
        
        private string sTKBNDAMTField;
        
        private BooleanType sBGROSField;
        
        private bool sBGROSFieldSpecified;
        
        private BooleanType sBGROSLESSField;
        
        private bool sBGROSLESSFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string STKBNDAMT {
            get {
                return sTKBNDAMTField;
            }
            set {
                sTKBNDAMTField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType SBGROS {
            get {
                return sBGROSField;
            }
            set {
                sBGROSField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SBGROSSpecified {
            get {
                return sBGROSFieldSpecified;
            }
            set {
                sBGROSFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType SBGROSLESS {
            get {
                return sBGROSLESSField;
            }
            set {
                sBGROSLESSField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SBGROSLESSSpecified {
            get {
                return sBGROSLESSFieldSpecified;
            }
            set {
                sBGROSLESSFieldSpecified = value;
            }
        }
    }
}