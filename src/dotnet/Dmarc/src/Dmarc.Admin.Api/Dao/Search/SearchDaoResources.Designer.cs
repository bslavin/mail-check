﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Dmarc.Admin.Api.Dao.Search {
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
    public class SearchDaoResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        internal SearchDaoResources() {
        }
        
        /// <summary>
        ///    Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Dmarc.Admin.Api.Dao.Search.SearchDaoResources", typeof(SearchDaoResources).GetTypeInfo().Assembly);
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
        ///    Looks up a localized string similar to  (SELECT 
        ///&apos;user&apos; as &apos;type&apos;,
        ///u.id as &apos;id&apos;,
        ///u.firstname as &apos;firstname&apos;,
        ///u.lastname as &apos;lastname&apos;,
        ///u.email as &apos;email&apos;,
        ///u.global_admin as &apos;global_admin&apos;,
        ///null as &apos;name&apos;
        ///FROM user u
        ///WHERE (@search IS NULL 
        ///	OR LOWER(u.firstname) LIKE CONCAT(LOWER(@search), &apos;%&apos;)
        ///	OR LOWER(u.lastname) LIKE CONCAT(LOWER(@search), &apos;%&apos;)
        ///	OR LOWER(u.email) LIKE CONCAT(&apos;%&apos;, LOWER(@search), &apos;%&apos;))
        ///ORDER BY u.email
        ///LIMIT 0, @limit)
        ///
        ///UNION
        ///
        ///(SELECT 
        ///&apos;group&apos; as &apos;type&apos;,
        ///g.id as &apos;id&apos;,
        ///null as &apos;firstname&apos;,
        ///null as &apos;lastnam [rest of string was truncated]&quot;;.
        /// </summary>
        public static string SelectUserGroupDomainByEmailNameName {
            get {
                return ResourceManager.GetString("SelectUserGroupDomainByEmailNameName", resourceCulture);
            }
        }
    }
}
