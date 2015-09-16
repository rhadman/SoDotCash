namespace OFX.Protocol
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PositionStock))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PositionOther))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PositionOption))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PositionMutualFund))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PositionDebt))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public abstract partial class AbstractPositionBase {
        
        private InvestmentPosition iNVPOSField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public InvestmentPosition INVPOS {
            get {
                return iNVPOSField;
            }
            set {
                iNVPOSField = value;
            }
        }
    }
}