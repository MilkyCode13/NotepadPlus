﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NotepadPlus.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.10.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool AutoSaveEnabled {
            get {
                return ((bool)(this["AutoSaveEnabled"]));
            }
            set {
                this["AutoSaveEnabled"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("60000")]
        public int AutoSaveFrequency {
            get {
                return ((int)(this["AutoSaveFrequency"]));
            }
            set {
                this["AutoSaveFrequency"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("light")]
        public string Theme {
            get {
                return ((string)(this["Theme"]));
            }
            set {
                this["Theme"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::System.Collections.Specialized.StringCollection OpenedFiles {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["OpenedFiles"]));
            }
            set {
                this["OpenedFiles"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool JournalingEnabled {
            get {
                return ((bool)(this["JournalingEnabled"]));
            }
            set {
                this["JournalingEnabled"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("600000")]
        public int JournalingFrequency {
            get {
                return ((int)(this["JournalingFrequency"]));
            }
            set {
                this["JournalingFrequency"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("RoyalBlue")]
        public global::System.Drawing.Color SyntaxColorKeyword {
            get {
                return ((global::System.Drawing.Color)(this["SyntaxColorKeyword"]));
            }
            set {
                this["SyntaxColorKeyword"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("BlueViolet")]
        public global::System.Drawing.Color SyntaxColorClass {
            get {
                return ((global::System.Drawing.Color)(this["SyntaxColorClass"]));
            }
            set {
                this["SyntaxColorClass"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("BlueViolet")]
        public global::System.Drawing.Color SyntaxColorNamespace {
            get {
                return ((global::System.Drawing.Color)(this["SyntaxColorNamespace"]));
            }
            set {
                this["SyntaxColorNamespace"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("YellowGreen")]
        public global::System.Drawing.Color SyntaxColorMethod {
            get {
                return ((global::System.Drawing.Color)(this["SyntaxColorMethod"]));
            }
            set {
                this["SyntaxColorMethod"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Aqua")]
        public global::System.Drawing.Color SyntaxColorProperty {
            get {
                return ((global::System.Drawing.Color)(this["SyntaxColorProperty"]));
            }
            set {
                this["SyntaxColorProperty"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("SandyBrown")]
        public global::System.Drawing.Color SyntaxColorString {
            get {
                return ((global::System.Drawing.Color)(this["SyntaxColorString"]));
            }
            set {
                this["SyntaxColorString"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Green")]
        public global::System.Drawing.Color SyntaxColorComment {
            get {
                return ((global::System.Drawing.Color)(this["SyntaxColorComment"]));
            }
            set {
                this["SyntaxColorComment"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Magenta")]
        public global::System.Drawing.Color SyntaxColorNumber {
            get {
                return ((global::System.Drawing.Color)(this["SyntaxColorNumber"]));
            }
            set {
                this["SyntaxColorNumber"] = value;
            }
        }
    }
}
