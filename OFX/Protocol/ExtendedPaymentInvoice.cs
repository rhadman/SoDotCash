namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class ExtendedPaymentInvoice {
        
        private Invoice[] iNVOICEField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("INVOICE", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Invoice[] INVOICE {
            get {
                return iNVOICEField;
            }
            set {
                iNVOICEField = value;
            }
        }
    }
}