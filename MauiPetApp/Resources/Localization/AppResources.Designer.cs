﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MauiPetApp.Resources.Localization {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class AppResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal AppResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("MauiPetApp.Resources.Localization.AppResources", typeof(AppResources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Chats.
        /// </summary>
        internal static string ChatsPageTitle {
            get {
                return ResourceManager.GetString("ChatsPageTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Data.
        /// </summary>
        internal static string DataTabTitle {
            get {
                return ResourceManager.GetString("DataTabTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Files.
        /// </summary>
        internal static string FilesPageTitle {
            get {
                return ResourceManager.GetString("FilesPageTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Images.
        /// </summary>
        internal static string ImagesPageTitle {
            get {
                return ResourceManager.GetString("ImagesPageTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to page.
        /// </summary>
        internal static string Page {
            get {
                return ResourceManager.GetString("Page", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Select Theme.
        /// </summary>
        internal static string SettingsPageThemePickerTitle {
            get {
                return ResourceManager.GetString("SettingsPageThemePickerTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Settings.
        /// </summary>
        internal static string SettingsPageTitle {
            get {
                return ResourceManager.GetString("SettingsPageTitle", resourceCulture);
            }
        }
    }
}
