﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Dmarc.ForensicReport.Parser.Lambda.Dao.Rfc822Header {
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
    public class Rfc822HeaderDaoResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        internal Rfc822HeaderDaoResources() {
        }
        
        /// <summary>
        ///    Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Dmarc.ForensicReport.Parser.Lambda.Dao.Rfc822Header.Rfc822HeaderDaoResources", typeof(Rfc822HeaderDaoResources).GetTypeInfo().Assembly);
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
        ///    Looks up a localized string similar to INSERT INTO `rfc822_header_mapping` (
        ///`field_id`, 
        ///`order_in_set`, 
        ///`date`, 
        ///`set_id`) 
        ///VALUES (
        ///@field_id, 
        ///@order_in_set, 
        ///@date, 
        ///@set_id);.
        /// </summary>
        public static string InsertRfc822DateHeader {
            get {
                return ResourceManager.GetString("InsertRfc822DateHeader", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to INSERT INTO `rfc822_header_mapping` (
        ///`field_id`, 
        ///`order_in_set`, 
        ///`email_address_id`, 
        ///`set_id`) 
        ///VALUES (
        ///@field_id, 
        ///@order_in_set, 
        ///@email_address_id, 
        ///@set_id);.
        /// </summary>
        public static string InsertRfc822EmailAddressHeader {
            get {
                return ResourceManager.GetString("InsertRfc822EmailAddressHeader", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to INSERT INTO `rfc822_header_mapping` (
        ///`field_id`, 
        ///`order_in_set`, 
        ///`ip_address_id`, 
        ///`set_id`) 
        ///VALUES (
        ///@field_id, 
        ///@order_in_set, 
        ///@ip_address_id, 
        ///@set_id);.
        /// </summary>
        public static string InsertRfc822IpAddressHeader {
            get {
                return ResourceManager.GetString("InsertRfc822IpAddressHeader", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to INSERT INTO `rfc822_header_mapping` (
        ///`field_id`, 
        ///`order_in_set`, 
        ///`text_value_id`, 
        ///`set_id`) 
        ///VALUES (
        ///@field_id, 
        ///@order_in_set, 
        ///@text_value_id, 
        ///@set_id);.
        /// </summary>
        public static string InsertRfc822TextHeader {
            get {
                return ResourceManager.GetString("InsertRfc822TextHeader", resourceCulture);
            }
        }
    }
}
