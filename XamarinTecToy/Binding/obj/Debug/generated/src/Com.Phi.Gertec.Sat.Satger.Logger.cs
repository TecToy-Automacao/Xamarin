//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

#nullable restore
using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Phi.Gertec.Sat.Satger {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.phi.gertec.sat.satger']/class[@name='Logger']"
	[global::Android.Runtime.Register ("com/phi/gertec/sat/satger/Logger", DoNotGenerateAcw=true)]
	public partial class Logger : global::Java.Lang.Object {

        // Metadata.xml XPath field reference: path="/api/package[@name='com.phi.gertec.sat.satger']/class[@name='Logger']/field[@name='logger']"
        public static Java.Util.Logging.FileHandler GetLogger()
        {
            const string __id = "logger.Ljava/util/logging/FileHandler;";

            var __v = _members.StaticFields.GetObjectValue(__id);
            return global::Java.Lang.Object.GetObject<global::Java.Util.Logging.FileHandler>(__v.Handle, JniHandleOwnership.TransferLocalRef);
        }

        // Metadata.xml XPath field reference: path="/api/package[@name='com.phi.gertec.sat.satger']/class[@name='Logger']/field[@name='logger']"
        public static void SetLogger(Java.Util.Logging.FileHandler value)
        {
            const string __id = "logger.Ljava/util/logging/FileHandler;";

            IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle(value);
            try
            {
                _members.StaticFields.SetValue(__id, new JniObjectReference(native_value));
            }
            finally
            {
                global::Android.Runtime.JNIEnv.DeleteLocalRef(native_value);
            }
        }

        static readonly JniPeerMembers _members = new XAPeerMembers ("com/phi/gertec/sat/satger/Logger", typeof (Logger));

		internal static IntPtr class_ref {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		protected Logger (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.phi.gertec.sat.satger']/class[@name='Logger']/constructor[@name='Logger' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Logger () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.phi.gertec.sat.satger']/class[@name='Logger']/method[@name='addRecordToLog' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("addRecordToLog", "(Ljava/lang/String;)V", "")]
		public static unsafe void AddRecordToLog (string p0)
		{
			const string __id = "addRecordToLog.(Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}