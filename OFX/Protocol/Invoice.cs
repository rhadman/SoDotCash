namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class Invoice {
        
        private string iNVNOField;
        
        private string iNVTOTALAMTField;
        
        private string iNVPAIDAMTField;
        
        private string iNVDATEField;
        
        private string iNVDESCField;
        
        private Discount dISCOUNTField;
        
        private Adjustment aDJUSTMENTField;
        
        private LineItem[] lINEITEMField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string INVNO {
            get {
                return iNVNOField;
            }
            set {
                iNVNOField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string INVTOTALAMT {
            get {
                return iNVTOTALAMTField;
            }
            set {
                iNVTOTALAMTField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string INVPAIDAMT {
            get {
                return iNVPAIDAMTField;
            }
            set {
                iNVPAIDAMTField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string INVDATE {
            get {
                return iNVDATEField;
            }
            set {
                iNVDATEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string INVDESC {
            get {
                return iNVDESCField;
            }
            set {
                iNVDESCField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Discount DISCOUNT {
            get {
                return dISCOUNTField;
            }
            set {
                dISCOUNTField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Adjustment ADJUSTMENT {
            get {
                return aDJUSTMENTField;
            }
            set {
                aDJUSTMENTField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("LINEITEM", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public LineItem[] LINEITEM {
            get {
                return lINEITEMField;
            }
            set {
                lINEITEMField = value;
            }
        }
    }
}