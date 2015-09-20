namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class OpenOrderSellMutualFund : AbstractOpenOrder {
        
        private SellTypeEnum sELLTYPEField;
        
        private UnitTypeEnum uNITTYPEField;
        
        private BooleanType sELLALLField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SellTypeEnum SELLTYPE {
            get {
                return sELLTYPEField;
            }
            set {
                sELLTYPEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public UnitTypeEnum UNITTYPE {
            get {
                return uNITTYPEField;
            }
            set {
                uNITTYPEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType SELLALL {
            get {
                return sELLALLField;
            }
            set {
                sELLALLField = value;
            }
        }
    }
}