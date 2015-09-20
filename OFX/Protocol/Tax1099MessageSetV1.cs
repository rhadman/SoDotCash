namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class Tax1099MessageSetV1 : AbstractMessageSetVersion {
        
        private BooleanType tAX1099DNLDField;
        
        private BooleanType eXTD1099BField;
        
        private string[] tAXYEARSUPPORTEDField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType TAX1099DNLD {
            get {
                return tAX1099DNLDField;
            }
            set {
                tAX1099DNLDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType EXTD1099B {
            get {
                return eXTD1099BField;
            }
            set {
                eXTD1099BField = value;
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