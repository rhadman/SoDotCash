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
                return this.iNVNOField;
            }
            set {
                this.iNVNOField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string INVTOTALAMT {
            get {
                return this.iNVTOTALAMTField;
            }
            set {
                this.iNVTOTALAMTField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string INVPAIDAMT {
            get {
                return this.iNVPAIDAMTField;
            }
            set {
                this.iNVPAIDAMTField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string INVDATE {
            get {
                return this.iNVDATEField;
            }
            set {
                this.iNVDATEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string INVDESC {
            get {
                return this.iNVDESCField;
            }
            set {
                this.iNVDESCField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Discount DISCOUNT {
            get {
                return this.dISCOUNTField;
            }
            set {
                this.dISCOUNTField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Adjustment ADJUSTMENT {
            get {
                return this.aDJUSTMENTField;
            }
            set {
                this.aDJUSTMENTField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("LINEITEM", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public LineItem[] LINEITEM {
            get {
                return this.lINEITEMField;
            }
            set {
                this.lINEITEMField = value;
            }
        }
    }
}