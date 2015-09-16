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
                return fITIDField;
            }
            set {
                fITIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DTOPEN {
            get {
                return dTOPENField;
            }
            set {
                dTOPENField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DTCLOSE {
            get {
                return dTCLOSEField;
            }
            set {
                dTCLOSEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DTNEXT {
            get {
                return dTNEXTField;
            }
            set {
                dTNEXTField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string BALOPEN {
            get {
                return bALOPENField;
            }
            set {
                bALOPENField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string BALCLOSE {
            get {
                return bALCLOSEField;
            }
            set {
                bALCLOSEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string BALMIN {
            get {
                return bALMINField;
            }
            set {
                bALMINField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DEPANDCREDIT {
            get {
                return dEPANDCREDITField;
            }
            set {
                dEPANDCREDITField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string CHKANDDEB {
            get {
                return cHKANDDEBField;
            }
            set {
                cHKANDDEBField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string TOTALFEES {
            get {
                return tOTALFEESField;
            }
            set {
                tOTALFEESField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string TOTALINT {
            get {
                return tOTALINTField;
            }
            set {
                tOTALINTField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DTPOSTSTART {
            get {
                return dTPOSTSTARTField;
            }
            set {
                dTPOSTSTARTField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DTPOSTEND {
            get {
                return dTPOSTENDField;
            }
            set {
                dTPOSTENDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string MKTGINFO {
            get {
                return mKTGINFOField;
            }
            set {
                mKTGINFOField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ImageData IMAGEDATA {
            get {
                return iMAGEDATAField;
            }
            set {
                iMAGEDATAField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CURRENCY", typeof(Currency), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("ORIGCURRENCY", typeof(Currency), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public Currency Item {
            get {
                return itemField;
            }
            set {
                itemField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType7 ItemElementName {
            get {
                return itemElementNameField;
            }
            set {
                itemElementNameField = value;
            }
        }
    }
}