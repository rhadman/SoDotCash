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
                return this.iMAGETYPEField;
            }
            set {
                this.iMAGETYPEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string IMAGEREF {
            get {
                return this.iMAGEREFField;
            }
            set {
                this.iMAGEREFField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ImageRefTypeEnum IMAGEREFTYPE {
            get {
                return this.iMAGEREFTYPEField;
            }
            set {
                this.iMAGEREFTYPEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DTIMAGEAVAIL", typeof(string), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("IMAGEDELAY", typeof(string), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public string Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType6 ItemElementName {
            get {
                return this.itemElementNameField;
            }
            set {
                this.itemElementNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string IMAGETTL {
            get {
                return this.iMAGETTLField;
            }
            set {
                this.iMAGETTLField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public CheckSupportEnum CHECKSUP {
            get {
                return this.cHECKSUPField;
            }
            set {
                this.cHECKSUPField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CHECKSUPSpecified {
            get {
                return this.cHECKSUPFieldSpecified;
            }
            set {
                this.cHECKSUPFieldSpecified = value;
            }
        }
    }
}