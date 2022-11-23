using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Woyou.Aidlservice.Jiuiv5 {

	// Metadata.xml XPath class reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/class[@name='ICallback.Default']"
	[global::Android.Runtime.Register ("woyou/aidlservice/jiuiv5/ICallback$Default", DoNotGenerateAcw=true)]
	public partial class CallbackDefault : global::Java.Lang.Object, global::Woyou.Aidlservice.Jiuiv5.ICallback {
		static readonly JniPeerMembers _members = new XAPeerMembers ("woyou/aidlservice/jiuiv5/ICallback$Default", typeof (CallbackDefault));

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

		protected CallbackDefault (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/class[@name='ICallback.Default']/constructor[@name='ICallback.Default' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CallbackDefault () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_asBinder;
#pragma warning disable 0169
		static Delegate GetAsBinderHandler ()
		{
			if (cb_asBinder == null)
				cb_asBinder = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_AsBinder);
			return cb_asBinder;
		}

		static IntPtr n_AsBinder (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.CallbackDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/class[@name='ICallback.Default']/method[@name='asBinder' and count(parameter)=0]"
		[Register ("asBinder", "()Landroid/os/IBinder;", "GetAsBinderHandler")]
		public virtual unsafe global::Android.OS.IBinder AsBinder ()
		{
			const string __id = "asBinder.()Landroid/os/IBinder;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_onRaiseException_ILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnRaiseException_ILjava_lang_String_Handler ()
		{
			if (cb_onRaiseException_ILjava_lang_String_ == null)
				cb_onRaiseException_ILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIL_V) n_OnRaiseException_ILjava_lang_String_);
			return cb_onRaiseException_ILjava_lang_String_;
		}

		static void n_OnRaiseException_ILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, int code, IntPtr native_msg)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.CallbackDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var msg = JNIEnv.GetString (native_msg, JniHandleOwnership.DoNotTransfer);
			__this.OnRaiseException (code, msg);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/class[@name='ICallback.Default']/method[@name='onRaiseException' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register ("onRaiseException", "(ILjava/lang/String;)V", "GetOnRaiseException_ILjava_lang_String_Handler")]
		public virtual unsafe void OnRaiseException (int code, string msg)
		{
			const string __id = "onRaiseException.(ILjava/lang/String;)V";
			IntPtr native_msg = JNIEnv.NewString ((string)msg);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (code);
				__args [1] = new JniArgumentValue (native_msg);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_msg);
			}
		}

		static Delegate cb_onReturnString_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnReturnString_Ljava_lang_String_Handler ()
		{
			if (cb_onReturnString_Ljava_lang_String_ == null)
				cb_onReturnString_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnReturnString_Ljava_lang_String_);
			return cb_onReturnString_Ljava_lang_String_;
		}

		static void n_OnReturnString_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_result)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.CallbackDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var result = JNIEnv.GetString (native_result, JniHandleOwnership.DoNotTransfer);
			__this.OnReturnString (result);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/class[@name='ICallback.Default']/method[@name='onReturnString' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("onReturnString", "(Ljava/lang/String;)V", "GetOnReturnString_Ljava_lang_String_Handler")]
		public virtual unsafe void OnReturnString (string result)
		{
			const string __id = "onReturnString.(Ljava/lang/String;)V";
			IntPtr native_result = JNIEnv.NewString ((string)result);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_result);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_result);
			}
		}

		static Delegate cb_onRunResult_Z;
#pragma warning disable 0169
		static Delegate GetOnRunResult_ZHandler ()
		{
			if (cb_onRunResult_Z == null)
				cb_onRunResult_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_OnRunResult_Z);
			return cb_onRunResult_Z;
		}

		static void n_OnRunResult_Z (IntPtr jnienv, IntPtr native__this, bool isSuccess)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.CallbackDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnRunResult (isSuccess);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/class[@name='ICallback.Default']/method[@name='onRunResult' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("onRunResult", "(Z)V", "GetOnRunResult_ZHandler")]
		public virtual unsafe void OnRunResult (bool isSuccess)
		{
			const string __id = "onRunResult.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (isSuccess);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}

	// Metadata.xml XPath class reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/class[@name='ICallback.Stub']"
	[global::Android.Runtime.Register ("woyou/aidlservice/jiuiv5/ICallback$Stub", DoNotGenerateAcw=true)]
	public abstract partial class CallbackStub : global::Android.OS.Binder, global::Woyou.Aidlservice.Jiuiv5.ICallback {
		static readonly JniPeerMembers _members = new XAPeerMembers ("woyou/aidlservice/jiuiv5/ICallback$Stub", typeof (CallbackStub));

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

		protected CallbackStub (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/class[@name='ICallback.Stub']/constructor[@name='ICallback.Stub' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CallbackStub () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		public static unsafe global::Woyou.Aidlservice.Jiuiv5.ICallback DefaultImpl {
			// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/class[@name='ICallback.Stub']/method[@name='getDefaultImpl' and count(parameter)=0]"
			[Register ("getDefaultImpl", "()Lwoyou/aidlservice/jiuiv5/ICallback;", "")]
			get {
				const string __id = "getDefaultImpl.()Lwoyou/aidlservice/jiuiv5/ICallback;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.ICallback> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_asBinder;
#pragma warning disable 0169
		static Delegate GetAsBinderHandler ()
		{
			if (cb_asBinder == null)
				cb_asBinder = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_AsBinder);
			return cb_asBinder;
		}

		static IntPtr n_AsBinder (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.CallbackStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/class[@name='ICallback.Stub']/method[@name='asBinder' and count(parameter)=0]"
		[Register ("asBinder", "()Landroid/os/IBinder;", "GetAsBinderHandler")]
		public virtual unsafe global::Android.OS.IBinder AsBinder ()
		{
			const string __id = "asBinder.()Landroid/os/IBinder;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/class[@name='ICallback.Stub']/method[@name='asInterface' and count(parameter)=1 and parameter[1][@type='android.os.IBinder']]"
		[Register ("asInterface", "(Landroid/os/IBinder;)Lwoyou/aidlservice/jiuiv5/ICallback;", "")]
		public static unsafe global::Woyou.Aidlservice.Jiuiv5.ICallback AsInterface (global::Android.OS.IBinder obj)
		{
			const string __id = "asInterface.(Landroid/os/IBinder;)Lwoyou/aidlservice/jiuiv5/ICallback;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.ICallback> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (obj);
			}
		}

		static Delegate cb_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I;
#pragma warning disable 0169
		static Delegate GetOnTransact_ILandroid_os_Parcel_Landroid_os_Parcel_IHandler ()
		{
			if (cb_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I == null)
				cb_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPILLI_Z) n_OnTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I);
			return cb_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I;
		}

		static bool n_OnTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I (IntPtr jnienv, IntPtr native__this, int code, IntPtr native_data, IntPtr native_reply, int flags)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.CallbackStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var data = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_data, JniHandleOwnership.DoNotTransfer);
			var reply = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_reply, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnTransact (code, data, reply, flags);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/class[@name='ICallback.Stub']/method[@name='onTransact' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='android.os.Parcel'] and parameter[3][@type='android.os.Parcel'] and parameter[4][@type='int']]"
		[Register ("onTransact", "(ILandroid/os/Parcel;Landroid/os/Parcel;I)Z", "GetOnTransact_ILandroid_os_Parcel_Landroid_os_Parcel_IHandler")]
		public virtual unsafe bool OnTransact (int code, global::Android.OS.Parcel data, global::Android.OS.Parcel reply, int flags)
		{
			const string __id = "onTransact.(ILandroid/os/Parcel;Landroid/os/Parcel;I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (code);
				__args [1] = new JniArgumentValue ((data == null) ? IntPtr.Zero : ((global::Java.Lang.Object) data).Handle);
				__args [2] = new JniArgumentValue ((reply == null) ? IntPtr.Zero : ((global::Java.Lang.Object) reply).Handle);
				__args [3] = new JniArgumentValue (flags);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (data);
				global::System.GC.KeepAlive (reply);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/class[@name='ICallback.Stub']/method[@name='setDefaultImpl' and count(parameter)=1 and parameter[1][@type='woyou.aidlservice.jiuiv5.ICallback']]"
		[Register ("setDefaultImpl", "(Lwoyou/aidlservice/jiuiv5/ICallback;)Z", "")]
		public static unsafe bool SetDefaultImpl (global::Woyou.Aidlservice.Jiuiv5.ICallback impl)
		{
			const string __id = "setDefaultImpl.(Lwoyou/aidlservice/jiuiv5/ICallback;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((impl == null) ? IntPtr.Zero : ((global::Java.Lang.Object) impl).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (impl);
			}
		}

		static Delegate cb_onRaiseException_ILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnRaiseException_ILjava_lang_String_Handler ()
		{
			if (cb_onRaiseException_ILjava_lang_String_ == null)
				cb_onRaiseException_ILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIL_V) n_OnRaiseException_ILjava_lang_String_);
			return cb_onRaiseException_ILjava_lang_String_;
		}

		static void n_OnRaiseException_ILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.CallbackStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnRaiseException (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/interface[@name='ICallback']/method[@name='onRaiseException' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register ("onRaiseException", "(ILjava/lang/String;)V", "GetOnRaiseException_ILjava_lang_String_Handler")]
		public abstract void OnRaiseException (int p0, string p1);

		static Delegate cb_onReturnString_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnReturnString_Ljava_lang_String_Handler ()
		{
			if (cb_onReturnString_Ljava_lang_String_ == null)
				cb_onReturnString_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnReturnString_Ljava_lang_String_);
			return cb_onReturnString_Ljava_lang_String_;
		}

		static void n_OnReturnString_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.CallbackStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnReturnString (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/interface[@name='ICallback']/method[@name='onReturnString' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("onReturnString", "(Ljava/lang/String;)V", "GetOnReturnString_Ljava_lang_String_Handler")]
		public abstract void OnReturnString (string p0);

		static Delegate cb_onRunResult_Z;
#pragma warning disable 0169
		static Delegate GetOnRunResult_ZHandler ()
		{
			if (cb_onRunResult_Z == null)
				cb_onRunResult_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_OnRunResult_Z);
			return cb_onRunResult_Z;
		}

		static void n_OnRunResult_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.CallbackStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnRunResult (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/interface[@name='ICallback']/method[@name='onRunResult' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("onRunResult", "(Z)V", "GetOnRunResult_ZHandler")]
		public abstract void OnRunResult (bool p0);

	}

	[global::Android.Runtime.Register ("woyou/aidlservice/jiuiv5/ICallback$Stub", DoNotGenerateAcw=true)]
	internal partial class CallbackStubInvoker : CallbackStub {
		public CallbackStubInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("woyou/aidlservice/jiuiv5/ICallback$Stub", typeof (CallbackStubInvoker));

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/interface[@name='ICallback']/method[@name='onRaiseException' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register ("onRaiseException", "(ILjava/lang/String;)V", "GetOnRaiseException_ILjava_lang_String_Handler")]
		public override unsafe void OnRaiseException (int p0, string p1)
		{
			const string __id = "onRaiseException.(ILjava/lang/String;)V";
			IntPtr native_p1 = JNIEnv.NewString ((string)p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (native_p1);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/interface[@name='ICallback']/method[@name='onReturnString' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("onReturnString", "(Ljava/lang/String;)V", "GetOnReturnString_Ljava_lang_String_Handler")]
		public override unsafe void OnReturnString (string p0)
		{
			const string __id = "onReturnString.(Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/interface[@name='ICallback']/method[@name='onRunResult' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("onRunResult", "(Z)V", "GetOnRunResult_ZHandler")]
		public override unsafe void OnRunResult (bool p0)
		{
			const string __id = "onRunResult.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/interface[@name='ICallback']"
	[Register ("woyou/aidlservice/jiuiv5/ICallback", "", "Woyou.Aidlservice.Jiuiv5.ICallbackInvoker")]
	public partial interface ICallback : global::Android.OS.IInterface {
		// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/interface[@name='ICallback']/method[@name='onRaiseException' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register ("onRaiseException", "(ILjava/lang/String;)V", "GetOnRaiseException_ILjava_lang_String_Handler:Woyou.Aidlservice.Jiuiv5.ICallbackInvoker, Binding")]
		void OnRaiseException (int p0, string p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/interface[@name='ICallback']/method[@name='onReturnString' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("onReturnString", "(Ljava/lang/String;)V", "GetOnReturnString_Ljava_lang_String_Handler:Woyou.Aidlservice.Jiuiv5.ICallbackInvoker, Binding")]
		void OnReturnString (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/interface[@name='ICallback']/method[@name='onRunResult' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("onRunResult", "(Z)V", "GetOnRunResult_ZHandler:Woyou.Aidlservice.Jiuiv5.ICallbackInvoker, Binding")]
		void OnRunResult (bool p0);

	}

	[global::Android.Runtime.Register ("woyou/aidlservice/jiuiv5/ICallback", DoNotGenerateAcw=true)]
	internal partial class ICallbackInvoker : global::Java.Lang.Object, ICallback {
		static readonly JniPeerMembers _members = new XAPeerMembers ("woyou/aidlservice/jiuiv5/ICallback", typeof (ICallbackInvoker));

		static IntPtr java_class_ref {
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
			get { return class_ref; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static ICallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ICallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'woyou.aidlservice.jiuiv5.ICallback'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ICallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onRaiseException_ILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnRaiseException_ILjava_lang_String_Handler ()
		{
			if (cb_onRaiseException_ILjava_lang_String_ == null)
				cb_onRaiseException_ILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIL_V) n_OnRaiseException_ILjava_lang_String_);
			return cb_onRaiseException_ILjava_lang_String_;
		}

		static void n_OnRaiseException_ILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.ICallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnRaiseException (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onRaiseException_ILjava_lang_String_;
		public unsafe void OnRaiseException (int p0, string p1)
		{
			if (id_onRaiseException_ILjava_lang_String_ == IntPtr.Zero)
				id_onRaiseException_ILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onRaiseException", "(ILjava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString ((string)p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onRaiseException_ILjava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_onReturnString_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnReturnString_Ljava_lang_String_Handler ()
		{
			if (cb_onReturnString_Ljava_lang_String_ == null)
				cb_onReturnString_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnReturnString_Ljava_lang_String_);
			return cb_onReturnString_Ljava_lang_String_;
		}

		static void n_OnReturnString_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.ICallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnReturnString (p0);
		}
#pragma warning restore 0169

		IntPtr id_onReturnString_Ljava_lang_String_;
		public unsafe void OnReturnString (string p0)
		{
			if (id_onReturnString_Ljava_lang_String_ == IntPtr.Zero)
				id_onReturnString_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onReturnString", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onReturnString_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_onRunResult_Z;
#pragma warning disable 0169
		static Delegate GetOnRunResult_ZHandler ()
		{
			if (cb_onRunResult_Z == null)
				cb_onRunResult_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_OnRunResult_Z);
			return cb_onRunResult_Z;
		}

		static void n_OnRunResult_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.ICallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnRunResult (p0);
		}
#pragma warning restore 0169

		IntPtr id_onRunResult_Z;
		public unsafe void OnRunResult (bool p0)
		{
			if (id_onRunResult_Z == IntPtr.Zero)
				id_onRunResult_Z = JNIEnv.GetMethodID (class_ref, "onRunResult", "(Z)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onRunResult_Z, __args);
		}

		static Delegate cb_asBinder;
#pragma warning disable 0169
		static Delegate GetAsBinderHandler ()
		{
			if (cb_asBinder == null)
				cb_asBinder = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_AsBinder);
			return cb_asBinder;
		}

		static IntPtr n_AsBinder (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.ICallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
		}
#pragma warning restore 0169

		IntPtr id_asBinder;
		public unsafe global::Android.OS.IBinder AsBinder ()
		{
			if (id_asBinder == IntPtr.Zero)
				id_asBinder = JNIEnv.GetMethodID (class_ref, "asBinder", "()Landroid/os/IBinder;");
			return global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_asBinder), JniHandleOwnership.TransferLocalRef);
		}

	}
}
