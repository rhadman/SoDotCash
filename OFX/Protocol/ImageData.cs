namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class ImageData {
        
        private ImageTypeEnum iMAGETYPEField;
        
        private string iMAGEREFField;
        
        private ImageRefTypeEnum iMAGEREFTYPEField;
        
        private string itemField;
        
        private ItemChoiceType6 itemElementNameField;
        
        private string iMAGETTLField;
        
        private CheckSupportEnum cHECKSUPField;
        
        private bool cHECKSUPFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ImageTypeEnum IMAGETYPE {
            get {
                return iMAGETYPEField;
            }
            set {
                iMAGETYPEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string IMAGEREF {
            get {
                return iMAGEREFField;
            }
            set {
                iMAGEREFField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ImageRefTypeEnum IMAGEREFTYPE {
            get {
                return iMAGEREFTYPEField;
            }
            set {
                iMAGEREFTYPEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DTIMAGEAVAIL", typeof(string), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("IMAGEDELAY", typeof(string), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
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
        public ItemChoiceType6 ItemElementName {
            get {
                return itemElementNameField;
            }
            set {
                itemElementNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string IMAGETTL {
            get {
                return iMAGETTLField;
            }
            set {
                iMAGETTLField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public CheckSupportEnum CHECKSUP {
            get {
                return cHECKSUPField;
            }
            set {
                cHECKSUPField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CHECKSUPSpecified {
            get {
                return cHECKSUPFieldSpecified;
            }
            set {
                cHECKSUPFieldSpecified = value;
            }
        }
    }
}