﻿/*
*************************************************************************
DC EMV
Open Source EMV
Copyright (C) 2018  Vicente Da Silva

This program is free software: you can redistribute it and/or modify
it under the terms of the GNU Affero General Public License as published
by the Free Software Foundation, either version 3 of the License, or
any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU Affero General Public License for more details.

You should have received a copy of the GNU Affero General Public License
along with this program.  If not, see http://www.gnu.org/licenses/
*************************************************************************
*/

//------------------------------------------------------------------------------
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
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.xserver.com/perso")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.xserver.com/perso", IsNullable=false)]
public partial class perso {
    
    private keyType[] keysField;
    
    private applicationType[] applicationField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("key", IsNullable=false)]
    public keyType[] keys {
        get {
            return this.keysField;
        }
        set {
            this.keysField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("application")]
    public applicationType[] application {
        get {
            return this.applicationField;
        }
        set {
            this.applicationField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.xserver.com/perso")]
public partial class keyType {
    
    private string valueField;
    
    private KeyTypesEnum typeField;
    
    private bool typeFieldSpecified;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Value {
        get {
            return this.valueField;
        }
        set {
            this.valueField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public KeyTypesEnum Type {
        get {
            return this.typeField;
        }
        set {
            this.typeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool TypeSpecified {
        get {
            return this.typeFieldSpecified;
        }
        set {
            this.typeFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.xserver.com/perso")]
public enum KeyTypesEnum {
    
    /// <remarks/>
    CardMasterKey,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.xserver.com/perso")]
public partial class storeDataType {
    
    private tlvXMLType[] tlvxmlField;
    
    private string dataField;
    
    private string dGIField;
    
    private string descriptionField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("tlvxml")]
    public tlvXMLType[] tlvxml {
        get {
            return this.tlvxmlField;
        }
        set {
            this.tlvxmlField = value;
        }
    }
    
    /// <remarks/>
    public string data {
        get {
            return this.dataField;
        }
        set {
            this.dataField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string DGI {
        get {
            return this.dGIField;
        }
        set {
            this.dGIField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Description {
        get {
            return this.descriptionField;
        }
        set {
            this.descriptionField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.xserver.com/perso")]
public partial class tlvXMLType {
    
    private tagType tagField;
    
    private tlvXMLType[] childrenField;
    
    private valueType valueField;
    
    private valueC9Type valueC9Field;
    
    /// <remarks/>
    public tagType tag {
        get {
            return this.tagField;
        }
        set {
            this.tagField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("tlvxml", IsNullable=false)]
    public tlvXMLType[] children {
        get {
            return this.childrenField;
        }
        set {
            this.childrenField = value;
        }
    }
    
    /// <remarks/>
    public valueType value {
        get {
            return this.valueField;
        }
        set {
            this.valueField = value;
        }
    }
    
    /// <remarks/>
    public valueC9Type valueC9 {
        get {
            return this.valueC9Field;
        }
        set {
            this.valueC9Field = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.xserver.com/perso")]
public partial class tagType {
    
    private string nameField;
    
    private string descriptionField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Name {
        get {
            return this.nameField;
        }
        set {
            this.nameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Description {
        get {
            return this.descriptionField;
        }
        set {
            this.descriptionField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.xserver.com/perso")]
public partial class valueType {
    
    private FormattingEnum formattingField;
    
    private string valueField;
    
    public valueType() {
        this.formattingField = FormattingEnum.HEX;
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    [System.ComponentModel.DefaultValueAttribute(FormattingEnum.HEX)]
    public FormattingEnum Formatting {
        get {
            return this.formattingField;
        }
        set {
            this.formattingField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.xserver.com/perso")]
public enum FormattingEnum {
    
    /// <remarks/>
    HEX,
    
    /// <remarks/>
    ASCII,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.xserver.com/perso")]
public partial class valueC9Type {
    
    private C9_ApplicationInstanceEnum c9_ApplicationInstanceField;
    
    private bool c9_ApplicationInstanceFieldSpecified;
    
    private C9_PinSharingEnum c9_PinSharingField;
    
    private bool c9_PinSharingFieldSpecified;
    
    private C9_InterfacesAvailableEnum c9_InterfacesAvailableField;
    
    private bool c9_InterfacesAvailableFieldSpecified;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public C9_ApplicationInstanceEnum C9_ApplicationInstance {
        get {
            return this.c9_ApplicationInstanceField;
        }
        set {
            this.c9_ApplicationInstanceField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool C9_ApplicationInstanceSpecified {
        get {
            return this.c9_ApplicationInstanceFieldSpecified;
        }
        set {
            this.c9_ApplicationInstanceFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public C9_PinSharingEnum C9_PinSharing {
        get {
            return this.c9_PinSharingField;
        }
        set {
            this.c9_PinSharingField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool C9_PinSharingSpecified {
        get {
            return this.c9_PinSharingFieldSpecified;
        }
        set {
            this.c9_PinSharingFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public C9_InterfacesAvailableEnum C9_InterfacesAvailable {
        get {
            return this.c9_InterfacesAvailableField;
        }
        set {
            this.c9_InterfacesAvailableField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool C9_InterfacesAvailableSpecified {
        get {
            return this.c9_InterfacesAvailableFieldSpecified;
        }
        set {
            this.c9_InterfacesAvailableFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.xserver.com/perso")]
public enum C9_ApplicationInstanceEnum {
    
    /// <remarks/>
    Main,
    
    /// <remarks/>
    Alias,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.xserver.com/perso")]
public enum C9_PinSharingEnum {
    
    /// <remarks/>
    NoPinSharingOrAliasNotApplicable,
    
    /// <remarks/>
    PinSharingBetweenInstances,
    
    /// <remarks/>
    GlobalPinSharing,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.xserver.com/perso")]
public enum C9_InterfacesAvailableEnum {
    
    /// <remarks/>
    DualInterfaceContactOnly,
    
    /// <remarks/>
    DualInterfaceContactAndContactless,
    
    /// <remarks/>
    DualInterfaceContactlessOnly,
    
    /// <remarks/>
    ContactOnly,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.xserver.com/perso")]
public partial class tokensType {
    
    private tlvXMLType tlvxmlField;
    
    /// <remarks/>
    public tlvXMLType tlvxml {
        get {
            return this.tlvxmlField;
        }
        set {
            this.tlvxmlField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.xserver.com/perso")]
public partial class installType {
    
    private tokensType tokensField;
    
    private string executableLoadFileAIDField;
    
    private string executableModuleAIDField;
    
    private string applicationAIDField;
    
    private string privilegesField;
    
    private string installTokenField;
    
    /// <remarks/>
    public tokensType tokens {
        get {
            return this.tokensField;
        }
        set {
            this.tokensField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string ExecutableLoadFileAID {
        get {
            return this.executableLoadFileAIDField;
        }
        set {
            this.executableLoadFileAIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string ExecutableModuleAID {
        get {
            return this.executableModuleAIDField;
        }
        set {
            this.executableModuleAIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string ApplicationAID {
        get {
            return this.applicationAIDField;
        }
        set {
            this.applicationAIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Privileges {
        get {
            return this.privilegesField;
        }
        set {
            this.privilegesField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string InstallToken {
        get {
            return this.installTokenField;
        }
        set {
            this.installTokenField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.xserver.com/perso")]
public partial class commandsType {
    
    private installType installField;
    
    private storeDataType[] storeDataField;
    
    /// <remarks/>
    public installType install {
        get {
            return this.installField;
        }
        set {
            this.installField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("storeData")]
    public storeDataType[] storeData {
        get {
            return this.storeDataField;
        }
        set {
            this.storeDataField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.xserver.com/perso")]
public partial class applicationType {
    
    private commandsType commandsField;
    
    private string typeField;
    
    /// <remarks/>
    public commandsType commands {
        get {
            return this.commandsField;
        }
        set {
            this.commandsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string type {
        get {
            return this.typeField;
        }
        set {
            this.typeField = value;
        }
    }
}