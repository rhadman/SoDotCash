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
                return this.uNITSSTREETField;
            }
            set {
                this.uNITSSTREETField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string UNITSUSER {
            get {
                return this.uNITSUSERField;
            }
            set {
                this.uNITSUSERField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType REINVDIV {
            get {
                return this.rEINVDIVField;
            }
            set {
                this.rEINVDIVField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool REINVDIVSpecified {
            get {
                return this.rEINVDIVFieldSpecified;
            }
            set {
                this.rEINVDIVFieldSpecified = value;
            }
        }
    }
}