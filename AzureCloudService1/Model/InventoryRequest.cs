﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;

// 
// This source code was auto-generated by xsd, Version=4.6.1055.0.
// 


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://retalix.com/R10/services")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="http://retalix.com/R10/services", IsNullable=true)]
public partial class DateTime {
    
    private string typeCodeField;
    
    private string valueField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string TypeCode {
        get {
            return this.typeCodeField;
        }
        set {
            this.typeCodeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value {
        get {
            return this.valueField;
        }
        set {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://retalix.com/R10/services")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="http://retalix.com/R10/services", IsNullable=false)]
public partial class InventoryRequest {
    
    private InventoryRequestInventoryAction[] inventoryActionField;
    
    private string majorVersionField;
    
    private string minorVersionField;
    
    private string fixVersionField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("InventoryAction")]
    public InventoryRequestInventoryAction[] InventoryAction {
        get {
            return this.inventoryActionField;
        }
        set {
            this.inventoryActionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string MajorVersion {
        get {
            return this.majorVersionField;
        }
        set {
            this.majorVersionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string MinorVersion {
        get {
            return this.minorVersionField;
        }
        set {
            this.minorVersionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string FixVersion {
        get {
            return this.fixVersionField;
        }
        set {
            this.fixVersionField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://retalix.com/R10/services")]
public partial class InventoryRequestInventoryAction {
    
    private string idField;
    
    private string descriptionField;
    
    private string approveOperatorField;
    
    private DateTime[] dateTimeField;
    
    private InventoryRequestInventoryActionInventoryItemInventoryPackage[] inventoryItemField;
    
    private InventoryRequestInventoryActionScopeInventoryLocation[] scopeField;
    
    private string actionField;
    
    private string typeField;
    
    /// <remarks/>
    public string Id {
        get {
            return this.idField;
        }
        set {
            this.idField = value;
        }
    }
    
    /// <remarks/>
    public string Description {
        get {
            return this.descriptionField;
        }
        set {
            this.descriptionField = value;
        }
    }
    
    /// <remarks/>
    public string ApproveOperator {
        get {
            return this.approveOperatorField;
        }
        set {
            this.approveOperatorField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("DateTime", IsNullable=true)]
    public DateTime[] DateTime {
        get {
            return this.dateTimeField;
        }
        set {
            this.dateTimeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("InventoryPackage", typeof(InventoryRequestInventoryActionInventoryItemInventoryPackage), IsNullable=false)]
    public InventoryRequestInventoryActionInventoryItemInventoryPackage[] InventoryItem {
        get {
            return this.inventoryItemField;
        }
        set {
            this.inventoryItemField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("InventoryLocation", typeof(InventoryRequestInventoryActionScopeInventoryLocation), IsNullable=false)]
    public InventoryRequestInventoryActionScopeInventoryLocation[] Scope {
        get {
            return this.scopeField;
        }
        set {
            this.scopeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Action {
        get {
            return this.actionField;
        }
        set {
            this.actionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Type {
        get {
            return this.typeField;
        }
        set {
            this.typeField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://retalix.com/R10/services")]
public partial class InventoryRequestInventoryActionInventoryItemInventoryPackage {
    
    private string packageField;
    
    private string quantityField;
    
    private string operatorField;
    
    private DateTime[] dateTimeField;
    
    /// <remarks/>
    public string Package {
        get {
            return this.packageField;
        }
        set {
            this.packageField = value;
        }
    }
    
    /// <remarks/>
    public string Quantity {
        get {
            return this.quantityField;
        }
        set {
            this.quantityField = value;
        }
    }
    
    /// <remarks/>
    public string Operator {
        get {
            return this.operatorField;
        }
        set {
            this.operatorField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("DateTime", IsNullable=true)]
    public DateTime[] DateTime {
        get {
            return this.dateTimeField;
        }
        set {
            this.dateTimeField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://retalix.com/R10/services")]
public partial class InventoryRequestInventoryActionScopeInventoryLocation {
    
    private string businessUnitField;
    
    /// <remarks/>
    public string BusinessUnit {
        get {
            return this.businessUnitField;
        }
        set {
            this.businessUnitField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://retalix.com/R10/services")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="http://retalix.com/R10/services", IsNullable=false)]
public partial class NewDataSet {
    
    private object[] itemsField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("DateTime", typeof(DateTime), IsNullable=true)]
    [System.Xml.Serialization.XmlElementAttribute("InventoryRequest", typeof(InventoryRequest))]
    public object[] Items {
        get {
            return this.itemsField;
        }
        set {
            this.itemsField = value;
        }
    }
}
