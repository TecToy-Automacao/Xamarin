using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Sunmi.Scanner {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.sunmi.scanner']/class[@name='IScanInterface.Default']"
	[global::Android.Runtime.Register ("com/sunmi/scanner/IScanInterface$Default", DoNotGenerateAcw=true)]
	public partial class ScanInterfaceDefault : global::Java.Lang.Object, global::Com.Sunmi.Scanner.IScanInterface {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/sunmi/scanner/IScanInterface$Default", typeof (ScanInterfaceDefault));

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

		protected ScanInterfaceDefault (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.sunmi.scanner']/class[@name='IScanInterface.Default']/constructor[@name='IScanInterface.Default' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ScanInterfaceDefault () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_getScannerModel;
#pragma warning disable 0169
		static Delegate GetGetScannerModelHandler ()
		{
			if (cb_getScannerModel == null)
				cb_getScannerModel = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetScannerModel);
			return cb_getScannerModel;
		}

		static int n_GetScannerModel (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Sunmi.Scanner.ScanInterfaceDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ScannerModel;
		}
#pragma warning restore 0169

		public virtual unsafe int ScannerModel {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.sunmi.scanner']/class[@name='IScanInterface.Default']/method[@name='getScannerModel' and count(parameter)=0]"
			[Register ("getScannerModel", "()I", "GetGetScannerModelHandler")]
			get {
				const string __id = "getScannerModel.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Sunmi.Scanner.ScanInterfaceDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.sunmi.scanner']/class[@name='IScanInterface.Default']/method[@name='asBinder' and count(parameter)=0]"
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

		static Delegate cb_scan;
#pragma warning disable 0169
		static Delegate GetScanHandler ()
		{
			if (cb_scan == null)
				cb_scan = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Scan);
			return cb_scan;
		}

		static void n_Scan (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Sunmi.Scanner.ScanInterfaceDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Scan ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.sunmi.scanner']/class[@name='IScanInterface.Default']/method[@name='scan' and count(parameter)=0]"
		[Register ("scan", "()V", "GetScanHandler")]
		public virtual unsafe void Scan ()
		{
			const string __id = "scan.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_sendKeyEvent_Landroid_view_KeyEvent_;
#pragma warning disable 0169
		static Delegate GetSendKeyEvent_Landroid_view_KeyEvent_Handler ()
		{
			if (cb_sendKeyEvent_Landroid_view_KeyEvent_ == null)
				cb_sendKeyEvent_Landroid_view_KeyEvent_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SendKeyEvent_Landroid_view_KeyEvent_);
			return cb_sendKeyEvent_Landroid_view_KeyEvent_;
		}

		static void n_SendKeyEvent_Landroid_view_KeyEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_key)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Sunmi.Scanner.ScanInterfaceDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var key = global::Java.Lang.Object.GetObject<global::Android.Views.KeyEvent> (native_key, JniHandleOwnership.DoNotTransfer);
			__this.SendKeyEvent (key);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.sunmi.scanner']/class[@name='IScanInterface.Default']/method[@name='sendKeyEvent' and count(parameter)=1 and parameter[1][@type='android.view.KeyEvent']]"
		[Register ("sendKeyEvent", "(Landroid/view/KeyEvent;)V", "GetSendKeyEvent_Landroid_view_KeyEvent_Handler")]
		public virtual unsafe void SendKeyEvent (global::Android.Views.KeyEvent key)
		{
			const string __id = "sendKeyEvent.(Landroid/view/KeyEvent;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((key == null) ? IntPtr.Zero : ((global::Java.Lang.Object) key).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (key);
			}
		}

		static Delegate cb_stop;
#pragma warning disable 0169
		static Delegate GetStopHandler ()
		{
			if (cb_stop == null)
				cb_stop = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Stop);
			return cb_stop;
		}

		static void n_Stop (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Sunmi.Scanner.ScanInterfaceDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Stop ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.sunmi.scanner']/class[@name='IScanInterface.Default']/method[@name='stop' and count(parameter)=0]"
		[Register ("stop", "()V", "GetStopHandler")]
		public virtual unsafe void Stop ()
		{
			const string __id = "stop.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}

	// Metadata.xml XPath class reference: path="/api/package[@name='com.sunmi.scanner']/class[@name='IScanInterface.Stub']"
	[global::Android.Runtime.Register ("com/sunmi/scanner/IScanInterface$Stub", DoNotGenerateAcw=true)]
	public abstract partial class ScanInterfaceStub : global::Android.OS.Binder, global::Com.Sunmi.Scanner.IScanInterface {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/sunmi/scanner/IScanInterface$Stub", typeof (ScanInterfaceStub));

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

		protected ScanInterfaceStub (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.sunmi.scanner']/class[@name='IScanInterface.Stub']/constructor[@name='IScanInterface.Stub' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ScanInterfaceStub () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		public static unsafe global::Com.Sunmi.Scanner.IScanInterface DefaultImpl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.sunmi.scanner']/class[@name='IScanInterface.Stub']/method[@name='getDefaultImpl' and count(parameter)=0]"
			[Register ("getDefaultImpl", "()Lcom/sunmi/scanner/IScanInterface;", "")]
			get {
				const string __id = "getDefaultImpl.()Lcom/sunmi/scanner/IScanInterface;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Com.Sunmi.Scanner.IScanInterface> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Sunmi.Scanner.ScanInterfaceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.sunmi.scanner']/class[@name='IScanInterface.Stub']/method[@name='asBinder' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.sunmi.scanner']/class[@name='IScanInterface.Stub']/method[@name='asInterface' and count(parameter)=1 and parameter[1][@type='android.os.IBinder']]"
		[Register ("asInterface", "(Landroid/os/IBinder;)Lcom/sunmi/scanner/IScanInterface;", "")]
		public static unsafe global::Com.Sunmi.Scanner.IScanInterface AsInterface (global::Android.OS.IBinder obj)
		{
			const string __id = "asInterface.(Landroid/os/IBinder;)Lcom/sunmi/scanner/IScanInterface;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Sunmi.Scanner.IScanInterface> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Sunmi.Scanner.ScanInterfaceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var data = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_data, JniHandleOwnership.DoNotTransfer);
			var reply = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_reply, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnTransact (code, data, reply, flags);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.sunmi.scanner']/class[@name='IScanInterface.Stub']/method[@name='onTransact' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='android.os.Parcel'] and parameter[3][@type='android.os.Parcel'] and parameter[4][@type='int']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.sunmi.scanner']/class[@name='IScanInterface.Stub']/method[@name='setDefaultImpl' and count(parameter)=1 and parameter[1][@type='com.sunmi.scanner.IScanInterface']]"
		[Register ("setDefaultImpl", "(Lcom/sunmi/scanner/IScanInterface;)Z", "")]
		public static unsafe bool SetDefaultImpl (global::Com.Sunmi.Scanner.IScanInterface impl)
		{
			const string __id = "setDefaultImpl.(Lcom/sunmi/scanner/IScanInterface;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((impl == null) ? IntPtr.Zero : ((global::Java.Lang.Object) impl).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (impl);
			}
		}

		static Delegate cb_scan;
#pragma warning disable 0169
		static Delegate GetScanHandler ()
		{
			if (cb_scan == null)
				cb_scan = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Scan);
			return cb_scan;
		}

		static void n_Scan (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Sunmi.Scanner.ScanInterfaceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Scan ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.sunmi.scanner']/interface[@name='IScanInterface']/method[@name='scan' and count(parameter)=0]"
		[Register ("scan", "()V", "GetScanHandler")]
		public abstract void Scan ();

		static Delegate cb_sendKeyEvent_Landroid_view_KeyEvent_;
#pragma warning disable 0169
		static Delegate GetSendKeyEvent_Landroid_view_KeyEvent_Handler ()
		{
			if (cb_sendKeyEvent_Landroid_view_KeyEvent_ == null)
				cb_sendKeyEvent_Landroid_view_KeyEvent_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SendKeyEvent_Landroid_view_KeyEvent_);
			return cb_sendKeyEvent_Landroid_view_KeyEvent_;
		}

		static void n_SendKeyEvent_Landroid_view_KeyEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Sunmi.Scanner.ScanInterfaceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Views.KeyEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SendKeyEvent (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.sunmi.scanner']/interface[@name='IScanInterface']/method[@name='sendKeyEvent' and count(parameter)=1 and parameter[1][@type='android.view.KeyEvent']]"
		[Register ("sendKeyEvent", "(Landroid/view/KeyEvent;)V", "GetSendKeyEvent_Landroid_view_KeyEvent_Handler")]
		public abstract void SendKeyEvent (global::Android.Views.KeyEvent p0);

		static Delegate cb_stop;
#pragma warning disable 0169
		static Delegate GetStopHandler ()
		{
			if (cb_stop == null)
				cb_stop = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Stop);
			return cb_stop;
		}

		static void n_Stop (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Sunmi.Scanner.ScanInterfaceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Stop ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.sunmi.scanner']/interface[@name='IScanInterface']/method[@name='stop' and count(parameter)=0]"
		[Register ("stop", "()V", "GetStopHandler")]
		public abstract void Stop ();

		static Delegate cb_getScannerModel;
#pragma warning disable 0169
		static Delegate GetGetScannerModelHandler ()
		{
			if (cb_getScannerModel == null)
				cb_getScannerModel = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetScannerModel);
			return cb_getScannerModel;
		}

		static int n_GetScannerModel (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Sunmi.Scanner.ScanInterfaceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ScannerModel;
		}
#pragma warning restore 0169

		public abstract int ScannerModel {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.sunmi.scanner']/class[@name='IScanInterface.Stub']/method[@name='getScannerModel' and count(parameter)=0]"
			[Register ("getScannerModel", "()I", "GetGetScannerModelHandler")]
			get; 
		}

	}

	[global::Android.Runtime.Register ("com/sunmi/scanner/IScanInterface$Stub", DoNotGenerateAcw=true)]
	internal partial class ScanInterfaceStubInvoker : ScanInterfaceStub {
		public ScanInterfaceStubInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/sunmi/scanner/IScanInterface$Stub", typeof (ScanInterfaceStubInvoker));

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

		public override unsafe int ScannerModel {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.sunmi.scanner']/class[@name='IScanInterface.Stub']/method[@name='getScannerModel' and count(parameter)=0]"
			[Register ("getScannerModel", "()I", "GetGetScannerModelHandler")]
			get {
				const string __id = "getScannerModel.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.sunmi.scanner']/interface[@name='IScanInterface']/method[@name='scan' and count(parameter)=0]"
		[Register ("scan", "()V", "GetScanHandler")]
		public override unsafe void Scan ()
		{
			const string __id = "scan.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.sunmi.scanner']/interface[@name='IScanInterface']/method[@name='sendKeyEvent' and count(parameter)=1 and parameter[1][@type='android.view.KeyEvent']]"
		[Register ("sendKeyEvent", "(Landroid/view/KeyEvent;)V", "GetSendKeyEvent_Landroid_view_KeyEvent_Handler")]
		public override unsafe void SendKeyEvent (global::Android.Views.KeyEvent p0)
		{
			const string __id = "sendKeyEvent.(Landroid/view/KeyEvent;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.sunmi.scanner']/interface[@name='IScanInterface']/method[@name='stop' and count(parameter)=0]"
		[Register ("stop", "()V", "GetStopHandler")]
		public override unsafe void Stop ()
		{
			const string __id = "stop.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.sunmi.scanner']/interface[@name='IScanInterface']"
	[Register ("com/sunmi/scanner/IScanInterface", "", "Com.Sunmi.Scanner.IScanInterfaceInvoker")]
	public partial interface IScanInterface : global::Android.OS.IInterface {
		int ScannerModel {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.sunmi.scanner']/interface[@name='IScanInterface']/method[@name='getScannerModel' and count(parameter)=0]"
			[Register ("getScannerModel", "()I", "GetGetScannerModelHandler:Com.Sunmi.Scanner.IScanInterfaceInvoker, Binding")]
			get; 
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.sunmi.scanner']/interface[@name='IScanInterface']/method[@name='scan' and count(parameter)=0]"
		[Register ("scan", "()V", "GetScanHandler:Com.Sunmi.Scanner.IScanInterfaceInvoker, Binding")]
		void Scan ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.sunmi.scanner']/interface[@name='IScanInterface']/method[@name='sendKeyEvent' and count(parameter)=1 and parameter[1][@type='android.view.KeyEvent']]"
		[Register ("sendKeyEvent", "(Landroid/view/KeyEvent;)V", "GetSendKeyEvent_Landroid_view_KeyEvent_Handler:Com.Sunmi.Scanner.IScanInterfaceInvoker, Binding")]
		void SendKeyEvent (global::Android.Views.KeyEvent p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.sunmi.scanner']/interface[@name='IScanInterface']/method[@name='stop' and count(parameter)=0]"
		[Register ("stop", "()V", "GetStopHandler:Com.Sunmi.Scanner.IScanInterfaceInvoker, Binding")]
		void Stop ();

	}

	[global::Android.Runtime.Register ("com/sunmi/scanner/IScanInterface", DoNotGenerateAcw=true)]
	internal partial class IScanInterfaceInvoker : global::Java.Lang.Object, IScanInterface {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/sunmi/scanner/IScanInterface", typeof (IScanInterfaceInvoker));

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

		public static IScanInterface GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IScanInterface> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.sunmi.scanner.IScanInterface'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IScanInterfaceInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getScannerModel;
#pragma warning disable 0169
		static Delegate GetGetScannerModelHandler ()
		{
			if (cb_getScannerModel == null)
				cb_getScannerModel = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetScannerModel);
			return cb_getScannerModel;
		}

		static int n_GetScannerModel (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Sunmi.Scanner.IScanInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ScannerModel;
		}
#pragma warning restore 0169

		IntPtr id_getScannerModel;
		public unsafe int ScannerModel {
			get {
				if (id_getScannerModel == IntPtr.Zero)
					id_getScannerModel = JNIEnv.GetMethodID (class_ref, "getScannerModel", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getScannerModel);
			}
		}

		static Delegate cb_scan;
#pragma warning disable 0169
		static Delegate GetScanHandler ()
		{
			if (cb_scan == null)
				cb_scan = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Scan);
			return cb_scan;
		}

		static void n_Scan (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Sunmi.Scanner.IScanInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Scan ();
		}
#pragma warning restore 0169

		IntPtr id_scan;
		public unsafe void Scan ()
		{
			if (id_scan == IntPtr.Zero)
				id_scan = JNIEnv.GetMethodID (class_ref, "scan", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_scan);
		}

		static Delegate cb_sendKeyEvent_Landroid_view_KeyEvent_;
#pragma warning disable 0169
		static Delegate GetSendKeyEvent_Landroid_view_KeyEvent_Handler ()
		{
			if (cb_sendKeyEvent_Landroid_view_KeyEvent_ == null)
				cb_sendKeyEvent_Landroid_view_KeyEvent_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SendKeyEvent_Landroid_view_KeyEvent_);
			return cb_sendKeyEvent_Landroid_view_KeyEvent_;
		}

		static void n_SendKeyEvent_Landroid_view_KeyEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Sunmi.Scanner.IScanInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Views.KeyEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SendKeyEvent (p0);
		}
#pragma warning restore 0169

		IntPtr id_sendKeyEvent_Landroid_view_KeyEvent_;
		public unsafe void SendKeyEvent (global::Android.Views.KeyEvent p0)
		{
			if (id_sendKeyEvent_Landroid_view_KeyEvent_ == IntPtr.Zero)
				id_sendKeyEvent_Landroid_view_KeyEvent_ = JNIEnv.GetMethodID (class_ref, "sendKeyEvent", "(Landroid/view/KeyEvent;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendKeyEvent_Landroid_view_KeyEvent_, __args);
		}

		static Delegate cb_stop;
#pragma warning disable 0169
		static Delegate GetStopHandler ()
		{
			if (cb_stop == null)
				cb_stop = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Stop);
			return cb_stop;
		}

		static void n_Stop (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Sunmi.Scanner.IScanInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Stop ();
		}
#pragma warning restore 0169

		IntPtr id_stop;
		public unsafe void Stop ()
		{
			if (id_stop == IntPtr.Zero)
				id_stop = JNIEnv.GetMethodID (class_ref, "stop", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_stop);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Sunmi.Scanner.IScanInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
