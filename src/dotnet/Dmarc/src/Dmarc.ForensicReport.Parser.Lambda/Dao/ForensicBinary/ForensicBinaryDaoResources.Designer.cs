﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Dmarc.ForensicReport.Parser.Lambda.Dao.ForensicBinary {
    using System;
    using System.Reflection;
    
    
    /// <summary>
    ///    A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class ForensicBinaryDaoResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        internal ForensicBinaryDaoResources() {
        }
        
        /// <summary>
        ///    Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Dmarc.ForensicReport.Parser.Lambda.Dao.ForensicBinary.ForensicBinaryDaoResources", typeof(ForensicBinaryDaoResources).GetTypeInfo().Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///    Overrides the current thread's CurrentUICulture property for all
        ///    resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to INSERT INTO `forensic_binary_match` (
        ///`report_id`, 
        ///`binary_id`, 
        ///`filename`, 
        ///`extension`, 
        ///`disposition`, 
        ///`content_type_id`, 
        ///`order`, 
        ///`depth`) VALUES.
        /// </summary>
        public static string InsertForensicBinary {
            get {
                return ResourceManager.GetString("InsertForensicBinary", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to (
        ///@a{0},
        ///@b{0},
        ///@c{0},
        ///@d{0},
        ///@e{0},
        ///@f{0},
        ///@g{0},
        ///@h{0}).
        /// </summary>
        public static string InsertForensicBinaryValueFormatString {
            get {
                return ResourceManager.GetString("InsertForensicBinaryValueFormatString", resourceCulture);
            }
        }
    }
}
