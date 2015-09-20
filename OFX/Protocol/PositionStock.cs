namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class PositionStock : AbstractPositionBase {
        
        private string uNITSSTREETField;
        
        private string uNITSUSERField;
        
        private BooleanType rEINVDIVField;
        
        private bool rEINVDIVFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string UNITSSTREET {
            get {
                return uNITSSTREETField;
            }
            set {
                uNITSSTREETField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string UNITSUSER {
            get {
                return uNITSUSERField;
            }
            set {
                uNITSUSERField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType REINVDIV {
            get {
                return rEINVDIVField;
            }
            set {
                rEINVDIVField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool REINVDIVSpecified {
            get {
                return rEINVDIVFieldSpecified;
            }
            set {
                rEINVDIVFieldSpecified = value;
            }
        }
    }
}