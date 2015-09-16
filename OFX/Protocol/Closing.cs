namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class Closing {
        
        private string fITIDField;
        
        private string dTOPENField;
        
        private string dTCLOSEField;
        
        private string dTNEXTField;
        
        private string bALOPENField;
        
        private string bALCLOSEField;
        
        private string bALMINField;
        
        private string dEPANDCREDITField;
        
        private string cHKANDDEBField;
        
        private string tOTALFEESField;
        
        private string tOTALINTField;
        
        private string dTPOSTSTARTField;
        
        private string dTPOSTENDField;
        
        private string mKTGINFOField;
        
        private ImageData iMAGEDATAField;
        
        private Currency itemField;
        
        private ItemChoiceType7 itemElementNameField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string FITID {
            get {
                return this.fITIDField;
            }
            set {
                this.fITIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DTOPEN {
            get {
                return this.dTOPENField;
            }
            set {
                this.dTOPENField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DTCLOSE {
            get {
                return this.dTCLOSEField;
            }
            set {
                this.dTCLOSEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DTNEXT {
            get {
                return this.dTNEXTField;
            }
            set {
                this.dTNEXTField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string BALOPEN {
            get {
                return this.bALOPENField;
            }
            set {
                this.bALOPENField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string BALCLOSE {
            get {
                return this.bALCLOSEField;
            }
            set {
                this.bALCLOSEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string BALMIN {
            get {
                return this.bALMINField;
            }
            set {
                this.bALMINField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DEPANDCREDIT {
            get {
                return this.dEPANDCREDITField;
            }
            set {
                this.dEPANDCREDITField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string CHKANDDEB {
            get {
                return this.cHKANDDEBField;
            }
            set {
                this.cHKANDDEBField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string TOTALFEES {
            get {
                return this.tOTALFEESField;
            }
            set {
                this.tOTALFEESField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string TOTALINT {
            get {
                return this.tOTALINTField;
            }
            set {
                this.tOTALINTField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DTPOSTSTART {
            get {
                return this.dTPOSTSTARTField;
            }
            set {
                this.dTPOSTSTARTField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DTPOSTEND {
            get {
                return this.dTPOSTENDField;
            }
            set {
                this.dTPOSTENDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string MKTGINFO {
            get {
                return this.mKTGINFOField;
            }
            set {
                this.mKTGINFOField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ImageData IMAGEDATA {
            get {
                return this.iMAGEDATAField;
            }
            set {
                this.iMAGEDATAField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CURRENCY", typeof(Currency), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("ORIGCURRENCY", typeof(Currency), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public Currency Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType7 ItemElementName {
            get {
                return this.itemElementNameField;
            }
            set {
                this.itemElementNameField = value;
            }
        }
    }
}