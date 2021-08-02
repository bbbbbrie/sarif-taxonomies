﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by xsd, Version=4.8.3928.0.
// 
namespace Taxonomy {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://iase.disa.mil/cci")]
    [System.Xml.Serialization.XmlRootAttribute("cci_list", Namespace="http://iase.disa.mil/cci", IsNullable=false)]
    public partial class CCIListType {
        
        private MetadataType metadataField;
        
        private ItemType[] cci_itemsField;
        
        /// <remarks/>
        public MetadataType metadata {
            get {
                return this.metadataField;
            }
            set {
                this.metadataField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("cci_item", IsNullable=false)]
        public ItemType[] cci_items {
            get {
                return this.cci_itemsField;
            }
            set {
                this.cci_itemsField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://iase.disa.mil/cci")]
    public partial class MetadataType {
        
        private string versionField;
        
        private System.DateTime publishdateField;
        
        /// <remarks/>
        public string version {
            get {
                return this.versionField;
            }
            set {
                this.versionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public System.DateTime publishdate {
            get {
                return this.publishdateField;
            }
            set {
                this.publishdateField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://iase.disa.mil/cci")]
    public partial class ValidatedType {
        
        private string[] noteField;
        
        private string orgField;
        
        private System.DateTime dateField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("note")]
        public string[] note {
            get {
                return this.noteField;
            }
            set {
                this.noteField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string org {
            get {
                return this.orgField;
            }
            set {
                this.orgField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="date")]
        public System.DateTime date {
            get {
                return this.dateField;
            }
            set {
                this.dateField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://iase.disa.mil/cci")]
    public partial class ReferenceType {
        
        private ValidatedType[] validatedField;
        
        private string creatorField;
        
        private string titleField;
        
        private string versionField;
        
        private string locationField;
        
        private string indexField;
        
        public ReferenceType() {
            this.creatorField = "unknown author";
            this.versionField = "1";
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("validated")]
        public ValidatedType[] validated {
            get {
                return this.validatedField;
            }
            set {
                this.validatedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute("unknown author")]
        public string creator {
            get {
                return this.creatorField;
            }
            set {
                this.creatorField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string title {
            get {
                return this.titleField;
            }
            set {
                this.titleField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute("1")]
        public string version {
            get {
                return this.versionField;
            }
            set {
                this.versionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string location {
            get {
                return this.locationField;
            }
            set {
                this.locationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string index {
            get {
                return this.indexField;
            }
            set {
                this.indexField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://iase.disa.mil/cci")]
    public partial class ItemType {
        
        private StatusType statusField;
        
        private System.DateTime publishdateField;
        
        private string contributorField;
        
        private string definitionField;
        
        private CCIType[] typeField;
        
        private string parameterField;
        
        private string[] noteField;
        
        private ReferenceType[] referencesField;
        
        private string idField;
        
        /// <remarks/>
        public StatusType status {
            get {
                return this.statusField;
            }
            set {
                this.statusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public System.DateTime publishdate {
            get {
                return this.publishdateField;
            }
            set {
                this.publishdateField = value;
            }
        }
        
        /// <remarks/>
        public string contributor {
            get {
                return this.contributorField;
            }
            set {
                this.contributorField = value;
            }
        }
        
        /// <remarks/>
        public string definition {
            get {
                return this.definitionField;
            }
            set {
                this.definitionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("type")]
        public CCIType[] type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }
        
        /// <remarks/>
        public string parameter {
            get {
                return this.parameterField;
            }
            set {
                this.parameterField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("note")]
        public string[] note {
            get {
                return this.noteField;
            }
            set {
                this.noteField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("reference", IsNullable=false)]
        public ReferenceType[] references {
            get {
                return this.referencesField;
            }
            set {
                this.referencesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://iase.disa.mil/cci")]
    public enum StatusType {
        
        /// <remarks/>
        draft,
        
        /// <remarks/>
        published,
        
        /// <remarks/>
        deprecated,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://iase.disa.mil/cci")]
    public enum CCIType {
        
        /// <remarks/>
        policy,
        
        /// <remarks/>
        technical,
    }
}
