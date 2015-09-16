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
                return this.yEARTODATEField;
            }
            set {
                this.yEARTODATEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public InceptToDate INCEPTTODATE {
            get {
                return this.iNCEPTTODATEField;
            }
            set {
                this.iNCEPTTODATEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PeriodToDate PERIODTODATE {
            get {
                return this.pERIODTODATEField;
            }
            set {
                this.pERIODTODATEField = value;
            }
        }
    }
}