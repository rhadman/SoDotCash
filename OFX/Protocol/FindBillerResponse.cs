namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class FindBillerResponse {
        
        private string dTUPDATEField;
        
        private BillerInfo[] bILLERINFOField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DTUPDATE {
            get {
                return dTUPDATEField;
            }
            set {
                dTUPDATEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BILLERINFO", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BillerInfo[] BILLERINFO {
            get {
                return bILLERINFOField;
            }
            set {
                bILLERINFOField = value;
            }
        }
    }
}