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
                return sTTAXWHField;
            }
            set {
                sTTAXWHField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string PAYERSTATE {
            get {
                return pAYERSTATEField;
            }
            set {
                pAYERSTATEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string PAYERSTID {
            get {
                return pAYERSTIDField;
            }
            set {
                pAYERSTIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string STINCOME {
            get {
                return sTINCOMEField;
            }
            set {
                sTINCOMEField = value;
            }
        }
    }
}