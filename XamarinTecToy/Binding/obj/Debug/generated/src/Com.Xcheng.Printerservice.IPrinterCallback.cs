using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Xcheng.Printerservice {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.xcheng.printerservice']/class[@name='IPrinterCallback.Default']"
	[global::Android.Runtime.Register ("com/xcheng/printerservice/IPrinterCallback$Default", DoNotGenerateAcw=true)]
	public partial class PrinterCallbackDefault : global::Java.Lang.Object, global::Com.Xcheng.Printerservice.IPrinterCallback {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/xcheng/printerservice/IPrinterCallback$Default", typeof (PrinterCallbackDefault));

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

		protected PrinterCallbackDefault (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.xcheng.printerservice']/class[@name='IPrinterCallback.Default']/constructor[@name='IPrinterCallback.Default' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe PrinterCallbackDefault () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Xcheng.Printerservice.PrinterCallbackDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.xcheng.printerservice']/class[@name='IPrinterCallback.Default']/method[@name='asBinder' and count(parameter)=0]"
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

		static Delegate cb_onComplete;
#pragma warning disable 0169
		static Delegate GetOnCompleteHandler ()
		{
			if (cb_onComplete == null)
				cb_onComplete = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnComplete);
			return cb_onComplete;
		}

		static void n_OnComplete (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Xcheng.Printerservice.PrinterCallbackDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnComplete ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.xcheng.printerservice']/class[@name='IPrinterCallback.Default']/method[@name='onComplete' and count(parameter)=0]"
		[Register ("onComplete", "()V", "GetOnCompleteHandler")]
		public virtual unsafe void OnComplete ()
		{
			const string __id = "onComplete.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_onException_ILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnException_ILjava_lang_String_Handler ()
		{
			if (cb_onException_ILjava_lang_String_ == null)
				cb_onException_ILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIL_V) n_OnException_ILjava_lang_String_);
			return cb_onException_ILjava_lang_String_;
		}

		static void n_OnException_ILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, int code, IntPtr native_msg)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Xcheng.Printerservice.PrinterCallbackDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var msg = JNIEnv.GetString (native_msg, JniHandleOwnership.DoNotTransfer);
			__this.OnException (code, msg);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.xcheng.printerservice']/class[@name='IPrinterCallback.Default']/method[@name='onException' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register ("onException", "(ILjava/lang/String;)V", "GetOnException_ILjava_lang_String_Handler")]
		public virtual unsafe void OnException (int code, string msg)
		{
			const string __id = "onException.(ILjava/lang/String;)V";
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

		static Delegate cb_onLength_JJ;
#pragma warning disable 0169
		static Delegate GetOnLength_JJHandler ()
		{
			if (cb_onLength_JJ == null)
				cb_onLength_JJ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJJ_V) n_OnLength_JJ);
			return cb_onLength_JJ;
		}

		static void n_OnLength_JJ (IntPtr jnienv, IntPtr native__this, long current, long total)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Xcheng.Printerservice.PrinterCallbackDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnLength (current, total);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.xcheng.printerservice']/class[@name='IPrinterCallback.Default']/method[@name='onLength' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='long']]"
		[Register ("onLength", "(JJ)V", "GetOnLength_JJHandler")]
		public virtual unsafe void OnLength (long current, long total)
		{
			const string __id = "onLength.(JJ)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (current);
				__args [1] = new JniArgumentValue (total);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}

	// Metadata.xml XPath class reference: path="/api/package[@name='com.xcheng.printerservice']/class[@name='IPrinterCallback.Stub']"
	[global::Android.Runtime.Register ("com/xcheng/printerservice/IPrinterCallback$Stub", DoNotGenerateAcw=true)]
	public abstract partial class PrinterCallbackStub : global::Android.OS.Binder, global::Com.Xcheng.Printerservice.IPrinterCallback {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/xcheng/printerservice/IPrinterCallback$Stub", typeof (PrinterCallbackStub));

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

		protected PrinterCallbackStub (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.xcheng.printerservice']/class[@name='IPrinterCallback.Stub']/constructor[@name='IPrinterCallback.Stub' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe PrinterCallbackStub () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		public static unsafe global::Com.Xcheng.Printerservice.IPrinterCallback DefaultImpl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.xcheng.printerservice']/class[@name='IPrinterCallback.Stub']/method[@name='getDefaultImpl' and count(parameter)=0]"
			[Register ("getDefaultImpl", "()Lcom/xcheng/printerservice/IPrinterCallback;", "")]
			get {
				const string __id = "getDefaultImpl.()Lcom/xcheng/printerservice/IPrinterCallback;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Com.Xcheng.Printerservice.IPrinterCallback> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Xcheng.Printerservice.PrinterCallbackStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.xcheng.printerservice']/class[@name='IPrinterCallback.Stub']/method[@name='asBinder' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.xcheng.printerservice']/class[@name='IPrinterCallback.Stub']/method[@name='asInterface' and count(parameter)=1 and parameter[1][@type='android.os.IBinder']]"
		[Register ("asInterface", "(Landroid/os/IBinder;)Lcom/xcheng/printerservice/IPrinterCallback;", "")]
		public static unsafe global::Com.Xcheng.Printerservice.IPrinterCallback AsInterface (global::Android.OS.IBinder obj)
		{
			const string __id = "asInterface.(Landroid/os/IBinder;)Lcom/xcheng/printerservice/IPrinterCallback;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Xcheng.Printerservice.IPrinterCallback> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Xcheng.Printerservice.PrinterCallbackStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var data = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_data, JniHandleOwnership.DoNotTransfer);
			var reply = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_reply, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnTransact (code, data, reply, flags);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.xcheng.printerservice']/class[@name='IPrinterCallback.Stub']/method[@name='onTransact' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='android.os.Parcel'] and parameter[3][@type='android.os.Parcel'] and parameter[4][@type='int']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.xcheng.printerservice']/class[@name='IPrinterCallback.Stub']/method[@name='setDefaultImpl' and count(parameter)=1 and parameter[1][@type='com.xcheng.printerservice.IPrinterCallback']]"
		[Register ("setDefaultImpl", "(Lcom/xcheng/printerservice/IPrinterCallback;)Z", "")]
		public static unsafe bool SetDefaultImpl (global::Com.Xcheng.Printerservice.IPrinterCallback impl)
		{
			const string __id = "setDefaultImpl.(Lcom/xcheng/printerservice/IPrinterCallback;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((impl == null) ? IntPtr.Zero : ((global::Java.Lang.Object) impl).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (impl);
			}
		}

		static Delegate cb_onComplete;
#pragma warning disable 0169
		static Delegate GetOnCompleteHandler ()
		{
			if (cb_onComplete == null)
				cb_onComplete = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnComplete);
			return cb_onComplete;
		}

		static void n_OnComplete (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Xcheng.Printerservice.PrinterCallbackStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnComplete ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.xcheng.printerservice']/interface[@name='IPrinterCallback']/method[@name='onComplete' and count(parameter)=0]"
		[Register ("onComplete", "()V", "GetOnCompleteHandler")]
		public abstract void OnComplete ();

		static Delegate cb_onException_ILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnException_ILjava_lang_String_Handler ()
		{
			if (cb_onException_ILjava_lang_String_ == null)
				cb_onException_ILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIL_V) n_OnException_ILjava_lang_String_);
			return cb_onException_ILjava_lang_String_;
		}

		static void n_OnException_ILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Xcheng.Printerservice.PrinterCallbackStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnException (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.xcheng.printerservice']/interface[@name='IPrinterCallback']/method[@name='onException' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register ("onException", "(ILjava/lang/String;)V", "GetOnException_ILjava_lang_String_Handler")]
		public abstract void OnException (int p0, string p1);

		static Delegate cb_onLength_JJ;
#pragma warning disable 0169
		static Delegate GetOnLength_JJHandler ()
		{
			if (cb_onLength_JJ == null)
				cb_onLength_JJ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJJ_V) n_OnLength_JJ);
			return cb_onLength_JJ;
		}

		static void n_OnLength_JJ (IntPtr jnienv, IntPtr native__this, long p0, long p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Xcheng.Printerservice.PrinterCallbackStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnLength (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.xcheng.printerservice']/interface[@name='IPrinterCallback']/method[@name='onLength' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='long']]"
		[Register ("onLength", "(JJ)V", "GetOnLength_JJHandler")]
		public abstract void OnLength (long p0, long p1);

	}

	[global::Android.Runtime.Register ("com/xcheng/printerservice/IPrinterCallback$Stub", DoNotGenerateAcw=true)]
	internal partial class PrinterCallbackStubInvoker : PrinterCallbackStub {
		public PrinterCallbackStubInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/xcheng/printerservice/IPrinterCallback$Stub", typeof (PrinterCallbackStubInvoker));

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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.xcheng.printerservice']/interface[@name='IPrinterCallback']/method[@name='onComplete' and count(parameter)=0]"
		[Register ("onComplete", "()V", "GetOnCompleteHandler")]
		public override unsafe void OnComplete ()
		{
			const string __id = "onComplete.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.xcheng.printerservice']/interface[@name='IPrinterCallback']/method[@name='onException' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register ("onException", "(ILjava/lang/String;)V", "GetOnException_ILjava_lang_String_Handler")]
		public override unsafe void OnException (int p0, string p1)
		{
			const string __id = "onException.(ILjava/lang/String;)V";
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.xcheng.printerservice']/interface[@name='IPrinterCallback']/method[@name='onLength' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='long']]"
		[Register ("onLength", "(JJ)V", "GetOnLength_JJHandler")]
		public override unsafe void OnLength (long p0, long p1)
		{
			const string __id = "onLength.(JJ)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.xcheng.printerservice']/interface[@name='IPrinterCallback']"
	[Register ("com/xcheng/printerservice/IPrinterCallback", "", "Com.Xcheng.Printerservice.IPrinterCallbackInvoker")]
	public partial interface IPrinterCallback : global::Android.OS.IInterface {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.xcheng.printerservice']/interface[@name='IPrinterCallback']/method[@name='onComplete' and count(parameter)=0]"
		[Register ("onComplete", "()V", "GetOnCompleteHandler:Com.Xcheng.Printerservice.IPrinterCallbackInvoker, Binding")]
		void OnComplete ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.xcheng.printerservice']/interface[@name='IPrinterCallback']/method[@name='onException' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register ("onException", "(ILjava/lang/String;)V", "GetOnException_ILjava_lang_String_Handler:Com.Xcheng.Printerservice.IPrinterCallbackInvoker, Binding")]
		void OnException (int p0, string p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.xcheng.printerservice']/interface[@name='IPrinterCallback']/method[@name='onLength' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='long']]"
		[Register ("onLength", "(JJ)V", "GetOnLength_JJHandler:Com.Xcheng.Printerservice.IPrinterCallbackInvoker, Binding")]
		void OnLength (long p0, long p1);

	}

	[global::Android.Runtime.Register ("com/xcheng/printerservice/IPrinterCallback", DoNotGenerateAcw=true)]
	internal partial class IPrinterCallbackInvoker : global::Java.Lang.Object, IPrinterCallback {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/xcheng/printerservice/IPrinterCallback", typeof (IPrinterCallbackInvoker));

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

		public static IPrinterCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IPrinterCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.xcheng.printerservice.IPrinterCallback'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IPrinterCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onComplete;
#pragma warning disable 0169
		static Delegate GetOnCompleteHandler ()
		{
			if (cb_onComplete == null)
				cb_onComplete = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnComplete);
			return cb_onComplete;
		}

		static void n_OnComplete (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Xcheng.Printerservice.IPrinterCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnComplete ();
		}
#pragma warning restore 0169

		IntPtr id_onComplete;
		public unsafe void OnComplete ()
		{
			if (id_onComplete == IntPtr.Zero)
				id_onComplete = JNIEnv.GetMethodID (class_ref, "onComplete", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onComplete);
		}

		static Delegate cb_onException_ILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnException_ILjava_lang_String_Handler ()
		{
			if (cb_onException_ILjava_lang_String_ == null)
				cb_onException_ILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIL_V) n_OnException_ILjava_lang_String_);
			return cb_onException_ILjava_lang_String_;
		}

		static void n_OnException_ILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Xcheng.Printerservice.IPrinterCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnException (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onException_ILjava_lang_String_;
		public unsafe void OnException (int p0, string p1)
		{
			if (id_onException_ILjava_lang_String_ == IntPtr.Zero)
				id_onException_ILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onException", "(ILjava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString ((string)p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onException_ILjava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_onLength_JJ;
#pragma warning disable 0169
		static Delegate GetOnLength_JJHandler ()
		{
			if (cb_onLength_JJ == null)
				cb_onLength_JJ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJJ_V) n_OnLength_JJ);
			return cb_onLength_JJ;
		}

		static void n_OnLength_JJ (IntPtr jnienv, IntPtr native__this, long p0, long p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Xcheng.Printerservice.IPrinterCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnLength (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onLength_JJ;
		public unsafe void OnLength (long p0, long p1)
		{
			if (id_onLength_JJ == IntPtr.Zero)
				id_onLength_JJ = JNIEnv.GetMethodID (class_ref, "onLength", "(JJ)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onLength_JJ, __args);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Xcheng.Printerservice.IPrinterCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
