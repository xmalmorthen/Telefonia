﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GSMApplication.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("GSM Pasive Interceptor")]
        public string MCWG_Cnn_lblTitle {
            get {
                return ((string)(this["MCWG_Cnn_lblTitle"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("GPI")]
        public string MCWG_Cnn_lblTitle2 {
            get {
                return ((string)(this["MCWG_Cnn_lblTitle2"]));
            }
            set {
                this["MCWG_Cnn_lblTitle2"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=.;Initial Catalog=GSMPI;Persist Security Info=True;User ID=sa;Passwor" +
            "d=as;Connect Timeout=5;ConnectRetryCount=3;ConnectRetryInterval=5")]
        public string GSMPIConnectionString {
            get {
                return ((string)(this["GSMPIConnectionString"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Traffic")]
        public string OutputBasePath {
            get {
                return ((string)(this["OutputBasePath"]));
            }
            set {
                this["OutputBasePath"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("gsm")]
        public string sshUser {
            get {
                return ((string)(this["sshUser"]));
            }
            set {
                this["sshUser"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("10101011")]
        public string sshPass {
            get {
                return ((string)(this["sshPass"]));
            }
            set {
                this["sshPass"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("gpi-desarrollo.no-ip.org")]
        public string sshHost {
            get {
                return ((string)(this["sshHost"]));
            }
            set {
                this["sshHost"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("5")]
        public string NLogMinutesAfter {
            get {
                return ((string)(this["NLogMinutesAfter"]));
            }
            set {
                this["NLogMinutesAfter"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("2")]
        public string NlogCountErrorRecords {
            get {
                return ((string)(this["NlogCountErrorRecords"]));
            }
            set {
                this["NlogCountErrorRecords"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("sudo")]
        public string superUserCommand {
            get {
                return ((string)(this["superUserCommand"]));
            }
            set {
                this["superUserCommand"] = value;
            }
        }
    }
}
