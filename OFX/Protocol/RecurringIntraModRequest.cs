namespace OFX.Protocol
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    public partial class RecurringIntraModRequest : AbstractRecurringIntraRequest {
        
        private string rECSRVRTIDField;
        
        private RecurringInstructions rECURRINSTField;
        
        private IntraRequest iNTRARQField;
        
        private BooleanType mODPENDINGField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string RECSRVRTID {
            get {
                return this.rECSRVRTIDField;
            }
            set {
                this.rECSRVRTIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public RecurringInstructions RECURRINST {
            get {
                return this.rECURRINSTField;
            }
            set {
                this.rECURRINSTField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public IntraRequest INTRARQ {
            get {
                return this.iNTRARQField;
            }
            set {
                this.iNTRARQField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BooleanType MODPENDING {
            get {
                return this.mODPENDINGField;
            }
            set {
                this.mODPENDINGField = value;
            }
        }
    }
}