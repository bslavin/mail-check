﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Dmarc.AggregateReport.Parser.Common.Test.Serialisation.AggregateReportDeserialisation {
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
    public class IdentifiersDeserialiserTestsResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        internal IdentifiersDeserialiserTestsResources() {
        }
        
        /// <summary>
        ///    Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Dmarc.AggregateReport.Parser.Common.Test.Serialisation.AggregateReportDeserialisa" +
                            "tion.IdentifiersDeserialiserTestsResources", typeof(IdentifiersDeserialiserTestsResources).GetTypeInfo().Assembly);
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
        ///    Looks up a localized string similar to &lt;identifiers&gt;
        ///		  &lt;header_from&gt;gov.uk&lt;/header_from&gt;
        ///		  &lt;envelope_to&gt;gov.uk&lt;/envelope_to&gt;
        ///		  &lt;envelope_to&gt;gov.uk&lt;/envelope_to&gt;
        ///	&lt;/identifiers&gt;.
        /// </summary>
        public static string DuplicateEnvelopeToTag {
            get {
                return ResourceManager.GetString("DuplicateEnvelopeToTag", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to &lt;identifiers&gt;
        ///      &lt;header_from&gt;gov.uk&lt;/header_from&gt;
        ///      &lt;header_from&gt;gov.uk&lt;/header_from&gt;
        ///      &lt;envelope_to&gt;gov.uk&lt;/envelope_to&gt;
        ///	&lt;/identifiers&gt;.
        /// </summary>
        public static string DuplicateHeaderFromTag {
            get {
                return ResourceManager.GetString("DuplicateHeaderFromTag", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to &lt;identifiers&gt;
        ///      &lt;header_from&gt;gov.uk&lt;/header_from&gt;
        ///	&lt;/identifiers&gt;.
        /// </summary>
        public static string NoEnvelopeToTag {
            get {
                return ResourceManager.GetString("NoEnvelopeToTag", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to &lt;identifiers&gt;
        ///      &lt;header_from&gt;gov.uk&lt;/header_from&gt;
        ///      &lt;envelope_to&gt;&lt;/envelope_to&gt;
        ///	&lt;/identifiers&gt;.
        /// </summary>
        public static string NoEnvelopeToValue {
            get {
                return ResourceManager.GetString("NoEnvelopeToValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to &lt;identifiers&gt;
        ///      &lt;envelope_to&gt;gov.uk&lt;/envelope_to&gt;
        ///	&lt;/identifiers&gt;.
        /// </summary>
        public static string NoHeaderFromTag {
            get {
                return ResourceManager.GetString("NoHeaderFromTag", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to &lt;identifiers&gt;
        ///		&lt;header_from&gt;&lt;/header_from&gt;
        ///		&lt;envelope_to&gt;gov.uk&lt;/envelope_to&gt;
        ///	&lt;/identifiers&gt;.
        /// </summary>
        public static string NoHeaderFromValue {
            get {
                return ResourceManager.GetString("NoHeaderFromValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to &lt;identifiers&gt;
        ///	&lt;not_identifiers&gt;
        ///		  &lt;header_from&gt;gov.uk&lt;/header_from&gt;
        ///		  &lt;envelope_to&gt;gov.uk&lt;/envelope_to&gt;
        ///	&lt;/not_identifiers&gt;
        ///&lt;/identifiers&gt;.
        /// </summary>
        public static string NotDirectDescendant {
            get {
                return ResourceManager.GetString("NotDirectDescendant", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to &lt;not_identifiers&gt;
        ///		  &lt;header_from&gt;gov.uk&lt;/header_from&gt;
        ///		  &lt;envelope_to&gt;gov.uk&lt;/envelope_to&gt;
        ///	&lt;/not_identifiers&gt;.
        /// </summary>
        public static string NotIdentifiers {
            get {
                return ResourceManager.GetString("NotIdentifiers", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to &lt;identifiers&gt;
        ///		  &lt;header_from&gt;gov.uk&lt;/header_from&gt;
        ///		  &lt;envelope_to&gt;gov.uk&lt;/envelope_to&gt;
        ///	&lt;/identifiers&gt;.
        /// </summary>
        public static string StandardIdentifiers {
            get {
                return ResourceManager.GetString("StandardIdentifiers", resourceCulture);
            }
        }
    }
}