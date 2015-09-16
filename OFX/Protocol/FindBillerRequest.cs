namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class FindBillerRequest {
        
        private string dTUPDATEField;
        
        private string bILLERIDField;
        
        private string nAMEField;
        
        private string aDDR1Field;
        
        private string aDDR2Field;
        
        private string aDDR3Field;
        
        private string cITYField;
        
        private string sTATEField;
        
        private string pOSTALCODEField;
        
        private string cOUNTRYField;
        
        private string sICField;
        
        private string cONSUPOSTALCODEField;
        
        private BooleanType iNCIMAGESField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DTUPDATE {
            get {
                return this.dTUPDATEField;
            }
            set {
                this.dTUPDATEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string BILLERID {
            get {
                return this.bILLERIDField;
            }
            set {
                this.bILLERIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string NAME {
            get {
                return this.nAMEField;
            }
            set {
                this.nAMEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ADDR1 {
            get {
                return this.aDDR1Field;
            }
            set {
                this.aDDR1Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ADDR2 {
            get {
                return this.aDDR2Field;
            }
            set {
                this.aDDR2Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ADDR3 {
            get {
                return this.aDDR3Field;
            }
            set {
                this.aDDR3Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string CITY {
            get {
                return this.cITYField;
            }
            set {
                this.cITYField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string STATE {
            get {
                return this.sTATEField;
            }
            set {
                this.sTATEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string POSTALCODE {
            get {
                return this.pOSTALCODEField;
            }
            set {
                this.pOSTALCODEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string COUNTRY {
            get {
                return this.cOUNTRYField;
            }
            set {
                this.cOUNTRYField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string SIC {
            get {
                return this.sICField;
            }
            set {
                this.sICField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string CONSUPOSTALCODE {
            get {
                return this.cONSUPOSTALCODEField;
            }
            set {
                this.cONSUPOSTALCODEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType INCIMAGES {
            get {
                return this.iNCIMAGESField;
            }
            set {
                this.iNCIMAGESField = value;
            }
        }
    }
}