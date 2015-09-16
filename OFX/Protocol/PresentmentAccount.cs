namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class PresentmentAccount : AbstractAccount {
        
        private string bILLPUBField;
        
        private string bILLERIDField;
        
        private string bILLERNAMEField;
        
        private string aCCTIDField;
        
        private PresentmentNameAddress pRESNAMEADDRESSField;
        
        private string uSERIDField;
        
        private string sPNAMEField;
        
        private string pAYEEIDField;
        
        private string pAYEELSTIDField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string BILLPUB {
            get {
                return this.bILLPUBField;
            }
            set {
                this.bILLPUBField = value;
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
        public string BILLERNAME {
            get {
                return this.bILLERNAMEField;
            }
            set {
                this.bILLERNAMEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ACCTID {
            get {
                return this.aCCTIDField;
            }
            set {
                this.aCCTIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PresentmentNameAddress PRESNAMEADDRESS {
            get {
                return this.pRESNAMEADDRESSField;
            }
            set {
                this.pRESNAMEADDRESSField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string USERID {
            get {
                return this.uSERIDField;
            }
            set {
                this.uSERIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string SPNAME {
            get {
                return this.sPNAMEField;
            }
            set {
                this.sPNAMEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string PAYEEID {
            get {
                return this.pAYEEIDField;
            }
            set {
                this.pAYEEIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string PAYEELSTID {
            get {
                return this.pAYEELSTIDField;
            }
            set {
                this.pAYEELSTIDField = value;
            }
        }
    }
}