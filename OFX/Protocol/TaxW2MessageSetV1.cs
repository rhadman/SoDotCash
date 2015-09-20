namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class TaxW2MessageSetV1 : AbstractMessageSetVersion {
        
        private BooleanType tAXW2DNLDField;
        
        private string[] tAXYEARSUPPORTEDField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType TAXW2DNLD {
            get {
                return tAXW2DNLDField;
            }
            set {
                tAXW2DNLDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TAXYEARSUPPORTED", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="gYear")]
        public string[] TAXYEARSUPPORTED {
            get {
                return tAXYEARSUPPORTEDField;
            }
            set {
                tAXYEARSUPPORTEDField = value;
            }
        }
    }
}