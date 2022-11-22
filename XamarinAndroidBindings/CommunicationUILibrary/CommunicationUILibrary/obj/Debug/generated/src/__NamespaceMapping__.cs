using System;

[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.azure.android.communication.ui.chat", Managed="Com.Azure.Android.Communication.UI.Chat")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.azure.android.communication.ui.chat.implementation", Managed="Com.Azure.Android.Communication.UI.Chat.Implementation")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.azure.android.communication.ui.chat.locator", Managed="Com.Azure.Android.Communication.UI.Chat.Locator")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.azure.android.communication.ui.chat.models", Managed="Com.Azure.Android.Communication.UI.Chat.Models")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.azure.android.communication.ui.chat.presentation.style", Managed="Com.Azure.Android.Communication.UI.Chat.Presentation.Style")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.azure.android.communication.ui.chat.presentation.ui.chat.components", Managed="Com.Azure.Android.Communication.UI.Chat.Presentation.UI.Chat.Components")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.azure.android.communication.ui.chat.presentation.ui.chat.screens", Managed="Com.Azure.Android.Communication.UI.Chat.Presentation.UI.Chat.Screens")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.azure.android.communication.ui.chat.presentation.ui.viewmodel", Managed="Com.Azure.Android.Communication.UI.Chat.Presentation.UI.Viewmodel")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.azure.android.communication.ui.chat.preview", Managed="Com.Azure.Android.Communication.UI.Chat.Preview")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.azure.android.communication.ui.chat.redux", Managed="Com.Azure.Android.Communication.UI.Chat.Redux")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.azure.android.communication.ui.chat.service.sdk.wrapper", Managed="Com.Azure.Android.Communication.UI.Chat.Service.Sdk.Wrapper")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.azure.android.communication.ui.chat.utilities", Managed="Com.Azure.Android.Communication.UI.Chat.Utilities")]

delegate int _JniMarshal_PP_I (IntPtr jnienv, IntPtr klass);
delegate IntPtr _JniMarshal_PP_L (IntPtr jnienv, IntPtr klass);
delegate void _JniMarshal_PP_V (IntPtr jnienv, IntPtr klass);
delegate IntPtr _JniMarshal_PPL_L (IntPtr jnienv, IntPtr klass, IntPtr p0);
delegate void _JniMarshal_PPL_V (IntPtr jnienv, IntPtr klass, IntPtr p0);
delegate IntPtr _JniMarshal_PPLL_L (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1);
delegate void _JniMarshal_PPLL_V (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1);
delegate void _JniMarshal_PPLLL_V (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, IntPtr p2);
#if !NET
namespace System.Runtime.Versioning {
    [System.Diagnostics.Conditional("NEVER")]
    [AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Constructor | AttributeTargets.Event | AttributeTargets.Method | AttributeTargets.Module | AttributeTargets.Property | AttributeTargets.Struct, AllowMultiple = true, Inherited = false)]
    internal sealed class SupportedOSPlatformAttribute : Attribute {
        public SupportedOSPlatformAttribute (string platformName) { }
    }
}
#endif

