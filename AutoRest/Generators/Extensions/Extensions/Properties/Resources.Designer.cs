﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.Rest.Generator.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.Rest.Generator.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to Head method &apos;{0}&apos; should contain only 200 level responses, or 404..
        /// </summary>
        internal static string HeadMethodInvalidResponses {
            get {
                return ResourceManager.GetString("HeadMethodInvalidResponses", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Azure resource {0} is missing required &apos;properties&apos; property..
        /// </summary>
        internal static string MissingProperties {
            get {
                return ResourceManager.GetString("MissingProperties", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} needs to have a value..
        /// </summary>
        internal static string ODataEmpty {
            get {
                return ResourceManager.GetString("ODataEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Method with {0} needs to have &quot;$filter&quot; parameter..
        /// </summary>
        internal static string ODataFilterMissing {
            get {
                return ResourceManager.GetString("ODataFilterMissing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} needs to have a valid definition reference..
        /// </summary>
        internal static string ODataInvalidReferance {
            get {
                return ResourceManager.GetString("ODataInvalidReferance", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Schema definition for Resource type with x-ms-azure-resource extension should have following properties: {0}.
        /// </summary>
        internal static string ResourcePropertyMismatch {
            get {
                return ResourceManager.GetString("ResourcePropertyMismatch", resourceCulture);
            }
        }
    }
}
