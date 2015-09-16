namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class InvestmentStatementMessageSetV1 : AbstractMessageSetVersion {
        
        private BooleanType tRANDNLDField;
        
        private BooleanType oODNLDField;
        
        private BooleanType pOSDNLDField;
        
        private BooleanType bALDNLDField;
        
        private BooleanType cANEMAILField;
        
        private BooleanType iNV401KDNLDField;
        
        private bool iNV401KDNLDFieldSpecified;
        
        private BooleanType cLOSINGAVAILField;
        
        private bool cLOSINGAVAILFieldSpecified;
        
        private ImageProfile iMAGEPROFField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType TRANDNLD {
            get {
                return this.tRANDNLDField;
            }
            set {
                this.tRANDNLDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType OODNLD {
            get {
                return this.oODNLDField;
            }
            set {
                this.oODNLDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType POSDNLD {
            get {
                return this.pOSDNLDField;
            }
            set {
                this.pOSDNLDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType BALDNLD {
            get {
                return this.bALDNLDField;
            }
            set {
                this.bALDNLDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType CANEMAIL {
            get {
                return this.cANEMAILField;
            }
            set {
                this.cANEMAILField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType INV401KDNLD {
            get {
                return this.iNV401KDNLDField;
            }
            set {
                this.iNV401KDNLDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool INV401KDNLDSpecified {
            get {
                return this.iNV401KDNLDFieldSpecified;
            }
            set {
                this.iNV401KDNLDFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType CLOSINGAVAIL {
            get {
                return this.cLOSINGAVAILField;
            }
            set {
                this.cLOSINGAVAILField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CLOSINGAVAILSpecified {
            get {
                return this.cLOSINGAVAILFieldSpecified;
            }
            set {
                this.cLOSINGAVAILFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ImageProfile IMAGEPROF {
            get {
                return this.iMAGEPROFField;
            }
            set {
                this.iMAGEPROFField = value;
            }
        }
    }
}