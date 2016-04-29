﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AntMe.SharedComponents {
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
    internal class Resource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resource() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("AntMe.SharedComponents.Resource", typeof(Resource).Assembly);
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
        ///   Looks up a localized string similar to AntVI-Stream delivered an invalid start block. Expected: FrameStart. Received: {0}..
        /// </summary>
        internal static string AntvideoReaderInvalidBlockType {
            get {
                return ResourceManager.GetString("AntvideoReaderInvalidBlockType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The input stream could not be read..
        /// </summary>
        internal static string AntvideoReaderNoReadAccessException {
            get {
                return ResourceManager.GetString("AntvideoReaderNoReadAccessException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The input stream has not been set..
        /// </summary>
        internal static string AntvideoReaderNoStreamException {
            get {
                return ResourceManager.GetString("AntvideoReaderNoStreamException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to AntVI-Stream delivered an invalid element: {0}..
        /// </summary>
        internal static string AntvideoSerializerInvalidBlockType {
            get {
                return ResourceManager.GetString("AntvideoSerializerInvalidBlockType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The stream does not contain the AntVi-format..
        /// </summary>
        internal static string AntvideoSerializerWrongHeader {
            get {
                return ResourceManager.GetString("AntvideoSerializerWrongHeader", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The stream contains an AntVI-version that could not be processed ({0}.{1}.{2}.{3})..
        /// </summary>
        internal static string AntvideoSerializerWrongProtocolVersion {
            get {
                return ResourceManager.GetString("AntvideoSerializerWrongProtocolVersion", resourceCulture);
            }
        }
    }
}