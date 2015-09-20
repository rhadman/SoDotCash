namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class Investment401kSummary {
        
        private YearToDate yEARTODATEField;
        
        private InceptToDate iNCEPTTODATEField;
        
        private PeriodToDate pERIODTODATEField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public YearToDate YEARTODATE {
            get {
                return yEARTODATEField;
            }
            set {
                yEARTODATEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public InceptToDate INCEPTTODATE {
            get {
                return iNCEPTTODATEField;
            }
            set {
                iNCEPTTODATEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PeriodToDate PERIODTODATE {
            get {
                return pERIODTODATEField;
            }
            set {
                pERIODTODATEField = value;
            }
        }
    }
}