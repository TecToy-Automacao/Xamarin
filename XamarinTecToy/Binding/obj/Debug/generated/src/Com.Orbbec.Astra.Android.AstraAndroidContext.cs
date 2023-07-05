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

namespace Com.Orbbec.Astra.Android {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.orbbec.astra.android']/class[@name='AstraAndroidContext']"
	[global::Android.Runtime.Register ("com/orbbec/astra/android/AstraAndroidContext", DoNotGenerateAcw=true)]
	public partial class AstraAndroidContext : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/orbbec/astra/android/AstraAndroidContext", typeof (AstraAndroidContext));

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

		protected AstraAndroidContext (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.orbbec.astra.android']/class[@name='AstraAndroidContext']/constructor[@name='AstraAndroidContext' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe AstraAndroidContext (global::Android.Content.Context p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.orbbec.astra.android']/class[@name='AstraAndroidContext']/constructor[@name='AstraAndroidContext' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.orbbec.astra.android.AstraDeviceManagerListener']]"
		[Register (".ctor", "(Landroid/content/Context;Lcom/orbbec/astra/android/AstraDeviceManagerListener;)V", "")]
		public unsafe AstraAndroidContext (global::Android.Content.Context p0, global::Com.Orbbec.Astra.Android.IAstraDeviceManagerListener p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Lcom/orbbec/astra/android/AstraDeviceManagerListener;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		static Delegate cb_getAvailableDevicesSize;
#pragma warning disable 0169
		static Delegate GetGetAvailableDevicesSizeHandler ()
		{
			if (cb_getAvailableDevicesSize == null)
				cb_getAvailableDevicesSize = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_GetAvailableDevicesSize));
			return cb_getAvailableDevicesSize;
		}

		static int n_GetAvailableDevicesSize (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Orbbec.Astra.Android.AstraAndroidContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AvailableDevicesSize;
		}
#pragma warning restore 0169

		public virtual unsafe int AvailableDevicesSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.orbbec.astra.android']/class[@name='AstraAndroidContext']/method[@name='getAvailableDevicesSize' and count(parameter)=0]"
			[Register ("getAvailableDevicesSize", "()I", "GetGetAvailableDevicesSizeHandler")]
			get {
				const string __id = "getAvailableDevicesSize.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_initialize;
#pragma warning disable 0169
		static Delegate GetInitializeHandler ()
		{
			if (cb_initialize == null)
				cb_initialize = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_Initialize));
			return cb_initialize;
		}

		static void n_Initialize (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Orbbec.Astra.Android.AstraAndroidContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Initialize ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.orbbec.astra.android']/class[@name='AstraAndroidContext']/method[@name='initialize' and count(parameter)=0]"
		[Register ("initialize", "()V", "GetInitializeHandler")]
		public virtual unsafe void Initialize ()
		{
			const string __id = "initialize.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_openAllDevices;
#pragma warning disable 0169
		static Delegate GetOpenAllDevicesHandler ()
		{
			if (cb_openAllDevices == null)
				cb_openAllDevices = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_OpenAllDevices));
			return cb_openAllDevices;
		}

		static void n_OpenAllDevices (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Orbbec.Astra.Android.AstraAndroidContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OpenAllDevices ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.orbbec.astra.android']/class[@name='AstraAndroidContext']/method[@name='openAllDevices' and count(parameter)=0]"
		[Register ("openAllDevices", "()V", "GetOpenAllDevicesHandler")]
		public virtual unsafe void OpenAllDevices ()
		{
			const string __id = "openAllDevices.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.orbbec.astra.android']/class[@name='AstraAndroidContext']/method[@name='setUsbFileDescriptor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setUsbFileDescriptor", "(I)V", "")]
		public static unsafe void SetUsbFileDescriptor (int p0)
		{
			const string __id = "setUsbFileDescriptor.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.orbbec.astra.android']/class[@name='AstraAndroidContext']/method[@name='setUsbPath' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setUsbPath", "(Ljava/lang/String;)V", "")]
		public static unsafe void SetUsbPath (string p0)
		{
			const string __id = "setUsbPath.(Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.orbbec.astra.android']/class[@name='AstraAndroidContext']/method[@name='set_android_context' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("set_android_context", "(Landroid/content/Context;Ljava/lang/String;)V", "")]
		public static unsafe void Set_android_context (global::Android.Content.Context p0, string p1)
		{
			const string __id = "set_android_context.(Landroid/content/Context;Ljava/lang/String;)V";
			IntPtr native_p1 = JNIEnv.NewString ((string)p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate cb_terminate;
#pragma warning disable 0169
		static Delegate GetTerminateHandler ()
		{
			if (cb_terminate == null)
				cb_terminate = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_Terminate));
			return cb_terminate;
		}

		static void n_Terminate (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Orbbec.Astra.Android.AstraAndroidContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Terminate ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.orbbec.astra.android']/class[@name='AstraAndroidContext']/method[@name='terminate' and count(parameter)=0]"
		[Register ("terminate", "()V", "GetTerminateHandler")]
		public virtual unsafe void Terminate ()
		{
			const string __id = "terminate.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}