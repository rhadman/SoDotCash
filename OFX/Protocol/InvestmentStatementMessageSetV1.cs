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
                return tRANDNLDField;
            }
            set {
                tRANDNLDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType OODNLD {
            get {
                return oODNLDField;
            }
            set {
                oODNLDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType POSDNLD {
            get {
                return pOSDNLDField;
            }
            set {
                pOSDNLDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType BALDNLD {
            get {
                return bALDNLDField;
            }
            set {
                bALDNLDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType CANEMAIL {
            get {
                return cANEMAILField;
            }
            set {
                cANEMAILField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType INV401KDNLD {
            get {
                return iNV401KDNLDField;
            }
            set {
                iNV401KDNLDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool INV401KDNLDSpecified {
            get {
                return iNV401KDNLDFieldSpecified;
            }
            set {
                iNV401KDNLDFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType CLOSINGAVAIL {
            get {
                return cLOSINGAVAILField;
            }
            set {
                cLOSINGAVAILField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CLOSINGAVAILSpecified {
            get {
                return cLOSINGAVAILFieldSpecified;
            }
            set {
                cLOSINGAVAILFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ImageProfile IMAGEPROF {
            get {
                return iMAGEPROFField;
            }
            set {
                iMAGEPROFField = value;
            }
        }
    }
}