﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.4952
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Fb2ePubGui {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "9.0.0.0")]
    internal sealed partial class FB2EpubSettings : global::System.Configuration.ApplicationSettingsBase {
        
        private static FB2EpubSettings defaultInstance = ((FB2EpubSettings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new FB2EpubSettings())));
        
        public static FB2EpubSettings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool Transliterate {
            get {
                return ((bool)(this["Transliterate"]));
            }
            set {
                this["Transliterate"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool TransliterateFileName {
            get {
                return ((bool)(this["TransliterateFileName"]));
            }
            set {
                this["TransliterateFileName"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool FB2Info {
            get {
                return ((bool)(this["FB2Info"]));
            }
            set {
                this["FB2Info"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("2")]
        public int FixMode {
            get {
                return ((int)(this["FixMode"]));
            }
            set {
                this["FixMode"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool AddSequences {
            get {
                return ((bool)(this["AddSequences"]));
            }
            set {
                this["AddSequences"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool TransliterateTOC {
            get {
                return ((bool)(this["TransliterateTOC"]));
            }
            set {
                this["TransliterateTOC"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool FlatStructure {
            get {
                return ((bool)(this["FlatStructure"]));
            }
            set {
                this["FlatStructure"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool ConvertAlphaPNG {
            get {
                return ((bool)(this["ConvertAlphaPNG"]));
            }
            set {
                this["ConvertAlphaPNG"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool EmbedStyles {
            get {
                return ((bool)(this["EmbedStyles"]));
            }
            set {
                this["EmbedStyles"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("\r\n          <Fonts xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xs" +
            "d=\"http://www.w3.org/2001/XMLSchema\">\r\n            <Font generic_family=\"\" style" +
            "=\"normal\" font-variant=\"\" font-weight=\"normal\">\r\n              <Destinations typ" +
            "e=\"Embedded\">\r\n                <Path>%ResourceFolder%\\Fonts/LiberationSerif-Regu" +
            "lar.ttf</Path>\r\n              </Destinations>\r\n              <decorate>true</dec" +
            "orate>\r\n              <CSSTargets>body</CSSTargets>\r\n              <CSSTargets>." +
            "epub</CSSTargets>\r\n            </Font>\r\n            <Font generic_family=\"\" styl" +
            "e=\"italic\" font-variant=\"\" font-weight=\"normal\">\r\n              <Destinations ty" +
            "pe=\"Embedded\">\r\n                <Path>%ResourceFolder%\\Fonts/LiberationSerif-Ita" +
            "lic.ttf</Path>\r\n              </Destinations>\r\n              <decorate>true</dec" +
            "orate>\r\n              <CSSTargets>body</CSSTargets>\r\n              <CSSTargets>." +
            "epub</CSSTargets>\r\n            </Font>\r\n            <Font generic_family=\"\" styl" +
            "e=\"normal\" font-variant=\"\" font-weight=\"bold\">\r\n              <Destinations type" +
            "=\"Embedded\">\r\n                <Path>%ResourceFolder%\\Fonts/LiberationSerif-Bold." +
            "ttf</Path>\r\n              </Destinations>\r\n              <decorate>true</decorat" +
            "e>\r\n              <CSSTargets>body</CSSTargets>\r\n              <CSSTargets>.epub" +
            "</CSSTargets>\r\n            </Font>\r\n            <Font generic_family=\"\" style=\"i" +
            "talic\" font-variant=\"\" font-weight=\"bold\">\r\n              <Destinations type=\"Em" +
            "bedded\">\r\n                <Path>%ResourceFolder%\\Fonts/LiberationSerif-BoldItali" +
            "c.ttf</Path>\r\n              </Destinations>\r\n              <decorate>true</decor" +
            "ate>\r\n              <CSSTargets>body</CSSTargets>\r\n              <CSSTargets>.ep" +
            "ub</CSSTargets>\r\n            </Font>\t\t\r\n            <Font generic_family=\"\" styl" +
            "e=\"italic\" font-variant=\"\" font-weight=\"\">\r\n              <Destinations type=\"Em" +
            "bedded\">\r\n                <Path>%ResourceFolder%\\Fonts/LiberationSerif-Italic.tt" +
            "f</Path>\r\n              </Destinations>\r\n              <decorate>true</decorate>" +
            "\r\n              <CSSTargets>code</CSSTargets>\r\n            </Font>\r\n          </" +
            "Fonts>\r\n        ")]
        public global::FontsSettings.FontSettings Fonts {
            get {
                return ((global::FontsSettings.FontSettings)(this["Fonts"]));
            }
            set {
                this["Fonts"] = value;
            }
        }
    }
}