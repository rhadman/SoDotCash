namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class AdditionalStateTaxWithheldAggregate {
        
        private string sTTAXWHField;
        
        private string pAYERSTATEField;
        
        private string pAYERSTIDField;
        
        private string sTINCOMEField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string STTAXWH {
            get {
                return this.sTTAXWHField;
            }
            set {
                this.sTTAXWHField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string PAYERSTATE {
            get {
                return this.pAYERSTATEField;
            }
            set {
                this.pAYERSTATEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string PAYERSTID {
            get {
                return this.pAYERSTIDField;
            }
            set {
                this.pAYERSTIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string STINCOME {
            get {
                return this.sTINCOMEField;
            }
            set {
                this.sTINCOMEField = value;
            }
        }
    }
}