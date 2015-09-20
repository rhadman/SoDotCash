namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class BillTableStructureResponse {
        
        private string bILLIDField;
        
        private string bILLDETAILTABLETYPEField;
        
        private ColumnDefinition[] cOLDEFField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string BILLID {
            get {
                return bILLIDField;
            }
            set {
                bILLIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string BILLDETAILTABLETYPE {
            get {
                return bILLDETAILTABLETYPEField;
            }
            set {
                bILLDETAILTABLETYPEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("COLDEF", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ColumnDefinition[] COLDEF {
            get {
                return cOLDEFField;
            }
            set {
                cOLDEFField = value;
            }
        }
    }
}