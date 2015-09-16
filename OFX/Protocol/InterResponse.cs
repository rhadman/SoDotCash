namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class InterResponse : AbstractInterResponse {
        
        private CurrencyEnum cURDEFField;
        
        private string sRVRTIDField;
        
        private TransferInfo xFERINFOField;
        
        private string itemField;
        
        private ItemChoiceType10 itemElementNameField;
        
        private string rEFNUMField;
        
        private string rECSRVRTIDField;
        
        private TransferProcessingStatus xFERPRCSTSField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public CurrencyEnum CURDEF {
            get {
                return cURDEFField;
            }
            set {
                cURDEFField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string SRVRTID {
            get {
                return sRVRTIDField;
            }
            set {
                sRVRTIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public TransferInfo XFERINFO {
            get {
                return xFERINFOField;
            }
            set {
                xFERINFOField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DTPOSTED", typeof(string), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("DTXFERPRJ", typeof(string), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public string Item {
            get {
                return itemField;
            }
            set {
                itemField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType10 ItemElementName {
            get {
                return itemElementNameField;
            }
            set {
                itemElementNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string REFNUM {
            get {
                return rEFNUMField;
            }
            set {
                rEFNUMField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string RECSRVRTID {
            get {
                return rECSRVRTIDField;
            }
            set {
                rECSRVRTIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public TransferProcessingStatus XFERPRCSTS {
            get {
                return xFERPRCSTSField;
            }
            set {
                xFERPRCSTSField = value;
            }
        }
    }
}