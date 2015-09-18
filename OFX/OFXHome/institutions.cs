namespace OFX.OFXHome
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class institutions {
        
        private institutionsInstitution[] institutionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("institution")]
        public institutionsInstitution[] institution {
            get {
                return this.institutionField;
            }
            set {
                this.institutionField = value;
            }
        }
    }
}