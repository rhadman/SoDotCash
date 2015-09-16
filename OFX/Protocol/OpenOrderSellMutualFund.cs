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
                return this.sELLTYPEField;
            }
            set {
                this.sELLTYPEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public UnitTypeEnum UNITTYPE {
            get {
                return this.uNITTYPEField;
            }
            set {
                this.uNITTYPEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType SELLALL {
            get {
                return this.sELLALLField;
            }
            set {
                this.sELLALLField = value;
            }
        }
    }
}