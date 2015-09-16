namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class Portion {
        
        private AssetClassEnum aSSETCLASSField;
        
        private string pERCENTField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public AssetClassEnum ASSETCLASS {
            get {
                return this.aSSETCLASSField;
            }
            set {
                this.aSSETCLASSField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string PERCENT {
            get {
                return this.pERCENTField;
            }
            set {
                this.pERCENTField = value;
            }
        }
    }
}