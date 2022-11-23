using System;

[assembly:global::Android.Runtime.NamespaceMapping (Java = "br.com.itfast.tectoy", Managed="BR.Com.Itfast.Tectoy")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.sunmi.idcardservice", Managed="Com.Sunmi.Idcardservice")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.sunmi.scanner", Managed="Com.Sunmi.Scanner")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.xcheng.printerservice", Managed="Com.Xcheng.Printerservice")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "woyou.aidlservice.jiuiv5", Managed="Woyou.Aidlservice.Jiuiv5")]

delegate int _JniMarshal_PP_I (IntPtr jnienv, IntPtr klass);
delegate IntPtr _JniMarshal_PP_L (IntPtr jnienv, IntPtr klass);
delegate void _JniMarshal_PP_V (IntPtr jnienv, IntPtr klass);
delegate bool _JniMarshal_PP_Z (IntPtr jnienv, IntPtr klass);
delegate void _JniMarshal_PPFL_V (IntPtr jnienv, IntPtr klass, float p0, IntPtr p1);
delegate int _JniMarshal_PPI_I (IntPtr jnienv, IntPtr klass, int p0);
delegate void _JniMarshal_PPI_V (IntPtr jnienv, IntPtr klass, int p0);
delegate int _JniMarshal_PPII_I (IntPtr jnienv, IntPtr klass, int p0, int p1);
delegate int _JniMarshal_PPIIL_I (IntPtr jnienv, IntPtr klass, int p0, int p1, IntPtr p2);
delegate int _JniMarshal_PPIL_I (IntPtr jnienv, IntPtr klass, int p0, IntPtr p1);
delegate void _JniMarshal_PPIL_V (IntPtr jnienv, IntPtr klass, int p0, IntPtr p1);
delegate bool _JniMarshal_PPILLI_Z (IntPtr jnienv, IntPtr klass, int p0, IntPtr p1, IntPtr p2, int p3);
delegate int _JniMarshal_PPILLL_I (IntPtr jnienv, IntPtr klass, int p0, IntPtr p1, IntPtr p2, IntPtr p3);
delegate void _JniMarshal_PPJJ_V (IntPtr jnienv, IntPtr klass, long p0, long p1);
delegate int _JniMarshal_PPL_I (IntPtr jnienv, IntPtr klass, IntPtr p0);
delegate IntPtr _JniMarshal_PPL_L (IntPtr jnienv, IntPtr klass, IntPtr p0);
delegate void _JniMarshal_PPL_V (IntPtr jnienv, IntPtr klass, IntPtr p0);
delegate bool _JniMarshal_PPL_Z (IntPtr jnienv, IntPtr klass, IntPtr p0);
delegate void _JniMarshal_PPLI_V (IntPtr jnienv, IntPtr klass, IntPtr p0, int p1);
delegate void _JniMarshal_PPLIIIIL_V (IntPtr jnienv, IntPtr klass, IntPtr p0, int p1, int p2, int p3, int p4, IntPtr p5);
delegate void _JniMarshal_PPLIIIZL_V (IntPtr jnienv, IntPtr klass, IntPtr p0, int p1, int p2, int p3, bool p4, IntPtr p5);
delegate void _JniMarshal_PPLIIL_V (IntPtr jnienv, IntPtr klass, IntPtr p0, int p1, int p2, IntPtr p3);
delegate void _JniMarshal_PPLIL_V (IntPtr jnienv, IntPtr klass, IntPtr p0, int p1, IntPtr p2);
delegate int _JniMarshal_PPLILL_I (IntPtr jnienv, IntPtr klass, IntPtr p0, int p1, IntPtr p2, IntPtr p3);
delegate void _JniMarshal_PPLIZL_V (IntPtr jnienv, IntPtr klass, IntPtr p0, int p1, bool p2, IntPtr p3);
delegate int _JniMarshal_PPLL_I (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1);
delegate void _JniMarshal_PPLL_V (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1);
delegate void _JniMarshal_PPLLFL_V (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, float p2, IntPtr p3);
delegate bool _JniMarshal_PPLLII_Z (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, int p2, int p3);
delegate void _JniMarshal_PPLLL_V (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, IntPtr p2);
delegate void _JniMarshal_PPLLLL_V (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, IntPtr p2, IntPtr p3);
delegate int _JniMarshal_PPLLLLL_I (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, IntPtr p2, IntPtr p3, IntPtr p4);
delegate void _JniMarshal_PPZ_V (IntPtr jnienv, IntPtr klass, bool p0);
delegate void _JniMarshal_PPZL_V (IntPtr jnienv, IntPtr klass, bool p0, IntPtr p1);
#if !NET
namespace System.Runtime.Versioning {
    [System.Diagnostics.Conditional("NEVER")]
    [AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Constructor | AttributeTargets.Event | AttributeTargets.Method | AttributeTargets.Module | AttributeTargets.Property | AttributeTargets.Struct, AllowMultiple = true, Inherited = false)]
    internal sealed class SupportedOSPlatformAttribute : Attribute {
        public SupportedOSPlatformAttribute (string platformName) { }
    }
}
#endif

