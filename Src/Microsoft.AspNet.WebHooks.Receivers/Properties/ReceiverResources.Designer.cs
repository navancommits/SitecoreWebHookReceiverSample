﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.AspNet.WebHooks.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class ReceiverResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ReceiverResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.AspNet.WebHooks.Properties.ReceiverResources", typeof(ReceiverResources).Assembly);
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
        ///   Looks up a localized string similar to Registered configuration setting &apos;{0}&apos; for ID &apos;{1}&apos;&apos;..
        /// </summary>
        internal static string Config_AddedName {
            get {
                return ResourceManager.GetString("Config_AddedName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not add configuration for receiver &apos;{0}&apos; and id &apos;{1}&apos;: {2}.
        /// </summary>
        internal static string Config_AddFailure {
            get {
                return ResourceManager.GetString("Config_AddFailure", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The &apos;{0}&apos; application setting must have a comma-separated value of one or more secrets of the form &lt;secret&gt; or &lt;id&gt;=&lt;secret&gt;..
        /// </summary>
        internal static string Config_BadValue {
            get {
                return ResourceManager.GetString("Config_BadValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Did not find any applications settings of the form &apos;{0}&apos;. To receive WebHooks, please add corresponding applications settings..
        /// </summary>
        internal static string Config_NoConfig {
            get {
                return ResourceManager.GetString("Config_NoConfig", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not deserialize instance of type &apos;{0}&apos; as &apos;{1}&apos;: {2}.
        /// </summary>
        internal static string GetDataOrDefault_Failure {
            get {
                return ResourceManager.GetString("GetDataOrDefault_Failure", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Multiple types were found that match the WebHook receiver named &apos;{0}&apos;. This can happen if multiple receivers are defined with the same name but different casing which is not supported. The request for &apos;{0}&apos; has found the following matching receivers: {1}{2}..
        /// </summary>
        internal static string Manager_MultipleAmbiguousReceiversFound {
            get {
                return ResourceManager.GetString("Manager_MultipleAmbiguousReceiversFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Registered &apos;{0}&apos; instances with the following names: {1}..
        /// </summary>
        internal static string Manager_RegisteredNames {
            get {
                return ResourceManager.GetString("Manager_RegisteredNames", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No WebHook receiver has been registered with the name &apos;{0}&apos;. Please use one of the registered receivers..
        /// </summary>
        internal static string Manager_UnknownReceiver {
            get {
                return ResourceManager.GetString("Manager_UnknownReceiver", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not enqueue WebHook: {0}.
        /// </summary>
        internal static string QueueHandler_EnqueueError {
            get {
                return ResourceManager.GetString("QueueHandler_EnqueueError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The &apos;{0}&apos; query parameter provided in the HTTP request did not match the expected value..
        /// </summary>
        internal static string Receiver_BadCode {
            get {
                return ResourceManager.GetString("Receiver_BadCode", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The WebHook request contained invalid HTML form URL-encoded data: &apos;{0}&apos;..
        /// </summary>
        internal static string Receiver_BadFormData {
            get {
                return ResourceManager.GetString("Receiver_BadFormData", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Expecting exactly one &apos;{0}&apos; header field in the WebHook request but found {1}. Please ensure that the request contains exactly one &apos;{0}&apos; header field..
        /// </summary>
        internal static string Receiver_BadHeader {
            get {
                return ResourceManager.GetString("Receiver_BadHeader", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The WebHook request contained invalid JSON: &apos;{0}&apos;..
        /// </summary>
        internal static string Receiver_BadJson {
            get {
                return ResourceManager.GetString("Receiver_BadJson", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The HTTP &apos;{0}&apos; method is not supported by the &apos;{1}&apos; WebHook receiver..
        /// </summary>
        internal static string Receiver_BadMethod {
            get {
                return ResourceManager.GetString("Receiver_BadMethod", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not find a valid configuration for WebHook receiver &apos;{0}&apos; and instance &apos;{1}&apos;. The setting must be set to a value between {2} and {3} characters long..
        /// </summary>
        internal static string Receiver_BadSecret {
            get {
                return ResourceManager.GetString("Receiver_BadSecret", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The WebHook signature provided by the &apos;{0}&apos; header field does not match the value expected by the &apos;{1}&apos; receiver. WebHook request is invalid..
        /// </summary>
        internal static string Receiver_BadSignature {
            get {
                return ResourceManager.GetString("Receiver_BadSignature", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The WebHook request contained invalid XML: &apos;{0}&apos;..
        /// </summary>
        internal static string Receiver_BadXml {
            get {
                return ResourceManager.GetString("Receiver_BadXml", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The WebHook request entity body cannot be empty..
        /// </summary>
        internal static string Receiver_NoBody {
            get {
                return ResourceManager.GetString("Receiver_NoBody", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The WebHook verification request must contain a &apos;{0}&apos; query parameter..
        /// </summary>
        internal static string Receiver_NoCode {
            get {
                return ResourceManager.GetString("Receiver_NoCode", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The WebHook request must contain an entity body formatted as HTML form URL-encoded data..
        /// </summary>
        internal static string Receiver_NoFormData {
            get {
                return ResourceManager.GetString("Receiver_NoFormData", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The WebHook receiver &apos;{0}&apos; requires HTTPS in order to be secure. Please register a WebHook URI of type &apos;{1}&apos;..
        /// </summary>
        internal static string Receiver_NoHttps {
            get {
                return ResourceManager.GetString("Receiver_NoHttps", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The WebHook request must contain an entity body formatted as JSON..
        /// </summary>
        internal static string Receiver_NoJson {
            get {
                return ResourceManager.GetString("Receiver_NoJson", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The WebHook request must contain an entity body formatted as XML..
        /// </summary>
        internal static string Receiver_NoXml {
            get {
                return ResourceManager.GetString("Receiver_NoXml", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to WebHook receiver &apos;{0}&apos; could not process WebHook due to error: {1}.
        /// </summary>
        internal static string ReceiverController_Failure {
            get {
                return ResourceManager.GetString("ReceiverController_Failure", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Processing incoming WebHook request with receiver &apos;{0}&apos; and id &apos;{1}&apos;..
        /// </summary>
        internal static string ReceiverController_Processing {
            get {
                return ResourceManager.GetString("ReceiverController_Processing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No WebHook receiver is registered with the name &apos;{0}&apos;..
        /// </summary>
        internal static string ReceiverController_Unknown {
            get {
                return ResourceManager.GetString("ReceiverController_Unknown", resourceCulture);
            }
        }
    }
}
