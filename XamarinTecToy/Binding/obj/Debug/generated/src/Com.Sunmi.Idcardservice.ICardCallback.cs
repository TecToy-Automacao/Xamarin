using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Sunmi.Idcardservice {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.sunmi.idcardservice']/class[@name='CardCallback.Default']"
	[global::Android.Runtime.Register ("com/sunmi/idcardservice/CardCallback$Default", DoNotGenerateAcw=true)]
	public partial class CardCallbackDefault : global::Java.Lang.Object, global::Com.Sunmi.Idcardservice.ICardCallback {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/sunmi/idcardservice/CardCallback$Default", typeof (CardCallbackDefault));

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

		protected CardCallbackDefault (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.sunmi.idcardservice']/class[@name='CardCallback.Default']/constructor[@name='CardCallback.Default' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CardCallbackDefault () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Sunmi.Idcardservice.CardCallbackDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.sunmi.idcardservice']/class[@name='CardCallback.Default']/method[@name='asBinder' and count(parameter)=0]"
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

		static Delegate cb_getCardData_Lcom_sunmi_idcardservice_IDCardInfo_I;
#pragma warning disable 0169
		static Delegate GetGetCardData_Lcom_sunmi_idcardservice_IDCardInfo_IHandler ()
		{
			if (cb_getCardData_Lcom_sunmi_idcardservice_IDCardInfo_I == null)
				cb_getCardData_Lcom_sunmi_idcardservice_IDCardInfo_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLI_V) n_GetCardData_Lcom_sunmi_idcardservice_IDCardInfo_I);
			return cb_getCardData_Lcom_sunmi_idcardservice_IDCardInfo_I;
		}

		static void n_GetCardData_Lcom_sunmi_idcardservice_IDCardInfo_I (IntPtr jnienv, IntPtr native__this, IntPtr native_info, int code)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Sunmi.Idcardservice.CardCallbackDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var info = global::Java.Lang.Object.GetObject<global::Com.Sunmi.Idcardservice.IDCardInfo> (native_info, JniHandleOwnership.DoNotTransfer);
			__this.GetCardData (info, code);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.sunmi.idcardservice']/class[@name='CardCallback.Default']/method[@name='getCardData' and count(parameter)=2 and parameter[1][@type='com.sunmi.idcardservice.IDCardInfo'] and parameter[2][@type='int']]"
		[Register ("getCardData", "(Lcom/sunmi/idcardservice/IDCardInfo;I)V", "GetGetCardData_Lcom_sunmi_idcardservice_IDCardInfo_IHandler")]
		public virtual unsafe void GetCardData (global::Com.Sunmi.Idcardservice.IDCardInfo info, int code)
		{
			const string __id = "getCardData.(Lcom/sunmi/idcardservice/IDCardInfo;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((info == null) ? IntPtr.Zero : ((global::Java.Lang.Object) info).Handle);
				__args [1] = new JniArgumentValue (code);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (info);
			}
		}

	}

	// Metadata.xml XPath class reference: path="/api/package[@name='com.sunmi.idcardservice']/class[@name='CardCallback.Stub']"
	[global::Android.Runtime.Register ("com/sunmi/idcardservice/CardCallback$Stub", DoNotGenerateAcw=true)]
	public abstract partial class CardCallbackStub : global::Android.OS.Binder, global::Com.Sunmi.Idcardservice.ICardCallback {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/sunmi/idcardservice/CardCallback$Stub", typeof (CardCallbackStub));

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

		protected CardCallbackStub (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.sunmi.idcardservice']/class[@name='CardCallback.Stub']/constructor[@name='CardCallback.Stub' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CardCallbackStub () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		public static unsafe global::Com.Sunmi.Idcardservice.ICardCallback DefaultImpl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.sunmi.idcardservice']/class[@name='CardCallback.Stub']/method[@name='getDefaultImpl' and count(parameter)=0]"
			[Register ("getDefaultImpl", "()Lcom/sunmi/idcardservice/CardCallback;", "")]
			get {
				const string __id = "getDefaultImpl.()Lcom/sunmi/idcardservice/CardCallback;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Com.Sunmi.Idcardservice.ICardCallback> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Sunmi.Idcardservice.CardCallbackStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.sunmi.idcardservice']/class[@name='CardCallback.Stub']/method[@name='asBinder' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.sunmi.idcardservice']/class[@name='CardCallback.Stub']/method[@name='asInterface' and count(parameter)=1 and parameter[1][@type='android.os.IBinder']]"
		[Register ("asInterface", "(Landroid/os/IBinder;)Lcom/sunmi/idcardservice/CardCallback;", "")]
		public static unsafe global::Com.Sunmi.Idcardservice.ICardCallback AsInterface (global::Android.OS.IBinder obj)
		{
			const string __id = "asInterface.(Landroid/os/IBinder;)Lcom/sunmi/idcardservice/CardCallback;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Sunmi.Idcardservice.ICardCallback> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Sunmi.Idcardservice.CardCallbackStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var data = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_data, JniHandleOwnership.DoNotTransfer);
			var reply = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_reply, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnTransact (code, data, reply, flags);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.sunmi.idcardservice']/class[@name='CardCallback.Stub']/method[@name='onTransact' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='android.os.Parcel'] and parameter[3][@type='android.os.Parcel'] and parameter[4][@type='int']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.sunmi.idcardservice']/class[@name='CardCallback.Stub']/method[@name='setDefaultImpl' and count(parameter)=1 and parameter[1][@type='com.sunmi.idcardservice.CardCallback']]"
		[Register ("setDefaultImpl", "(Lcom/sunmi/idcardservice/CardCallback;)Z", "")]
		public static unsafe bool SetDefaultImpl (global::Com.Sunmi.Idcardservice.ICardCallback impl)
		{
			const string __id = "setDefaultImpl.(Lcom/sunmi/idcardservice/CardCallback;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((impl == null) ? IntPtr.Zero : ((global::Java.Lang.Object) impl).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (impl);
			}
		}

		static Delegate cb_getCardData_Lcom_sunmi_idcardservice_IDCardInfo_I;
#pragma warning disable 0169
		static Delegate GetGetCardData_Lcom_sunmi_idcardservice_IDCardInfo_IHandler ()
		{
			if (cb_getCardData_Lcom_sunmi_idcardservice_IDCardInfo_I == null)
				cb_getCardData_Lcom_sunmi_idcardservice_IDCardInfo_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLI_V) n_GetCardData_Lcom_sunmi_idcardservice_IDCardInfo_I);
			return cb_getCardData_Lcom_sunmi_idcardservice_IDCardInfo_I;
		}

		static void n_GetCardData_Lcom_sunmi_idcardservice_IDCardInfo_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Sunmi.Idcardservice.CardCallbackStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Sunmi.Idcardservice.IDCardInfo> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.GetCardData (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.sunmi.idcardservice']/interface[@name='CardCallback']/method[@name='getCardData' and count(parameter)=2 and parameter[1][@type='com.sunmi.idcardservice.IDCardInfo'] and parameter[2][@type='int']]"
		[Register ("getCardData", "(Lcom/sunmi/idcardservice/IDCardInfo;I)V", "GetGetCardData_Lcom_sunmi_idcardservice_IDCardInfo_IHandler")]
		public abstract void GetCardData (global::Com.Sunmi.Idcardservice.IDCardInfo p0, int p1);

	}

	[global::Android.Runtime.Register ("com/sunmi/idcardservice/CardCallback$Stub", DoNotGenerateAcw=true)]
	internal partial class CardCallbackStubInvoker : CardCallbackStub {
		public CardCallbackStubInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/sunmi/idcardservice/CardCallback$Stub", typeof (CardCallbackStubInvoker));

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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.sunmi.idcardservice']/interface[@name='CardCallback']/method[@name='getCardData' and count(parameter)=2 and parameter[1][@type='com.sunmi.idcardservice.IDCardInfo'] and parameter[2][@type='int']]"
		[Register ("getCardData", "(Lcom/sunmi/idcardservice/IDCardInfo;I)V", "GetGetCardData_Lcom_sunmi_idcardservice_IDCardInfo_IHandler")]
		public override unsafe void GetCardData (global::Com.Sunmi.Idcardservice.IDCardInfo p0, int p1)
		{
			const string __id = "getCardData.(Lcom/sunmi/idcardservice/IDCardInfo;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.sunmi.idcardservice']/interface[@name='CardCallback']"
	[Register ("com/sunmi/idcardservice/CardCallback", "", "Com.Sunmi.Idcardservice.ICardCallbackInvoker")]
	public partial interface ICardCallback : global::Android.OS.IInterface {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.sunmi.idcardservice']/interface[@name='CardCallback']/method[@name='getCardData' and count(parameter)=2 and parameter[1][@type='com.sunmi.idcardservice.IDCardInfo'] and parameter[2][@type='int']]"
		[Register ("getCardData", "(Lcom/sunmi/idcardservice/IDCardInfo;I)V", "GetGetCardData_Lcom_sunmi_idcardservice_IDCardInfo_IHandler:Com.Sunmi.Idcardservice.ICardCallbackInvoker, Binding")]
		void GetCardData (global::Com.Sunmi.Idcardservice.IDCardInfo p0, int p1);

	}

	[global::Android.Runtime.Register ("com/sunmi/idcardservice/CardCallback", DoNotGenerateAcw=true)]
	internal partial class ICardCallbackInvoker : global::Java.Lang.Object, ICardCallback {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/sunmi/idcardservice/CardCallback", typeof (ICardCallbackInvoker));

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

		public static ICardCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ICardCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.sunmi.idcardservice.CardCallback'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ICardCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getCardData_Lcom_sunmi_idcardservice_IDCardInfo_I;
#pragma warning disable 0169
		static Delegate GetGetCardData_Lcom_sunmi_idcardservice_IDCardInfo_IHandler ()
		{
			if (cb_getCardData_Lcom_sunmi_idcardservice_IDCardInfo_I == null)
				cb_getCardData_Lcom_sunmi_idcardservice_IDCardInfo_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLI_V) n_GetCardData_Lcom_sunmi_idcardservice_IDCardInfo_I);
			return cb_getCardData_Lcom_sunmi_idcardservice_IDCardInfo_I;
		}

		static void n_GetCardData_Lcom_sunmi_idcardservice_IDCardInfo_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Sunmi.Idcardservice.ICardCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Sunmi.Idcardservice.IDCardInfo> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.GetCardData (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_getCardData_Lcom_sunmi_idcardservice_IDCardInfo_I;
		public unsafe void GetCardData (global::Com.Sunmi.Idcardservice.IDCardInfo p0, int p1)
		{
			if (id_getCardData_Lcom_sunmi_idcardservice_IDCardInfo_I == IntPtr.Zero)
				id_getCardData_Lcom_sunmi_idcardservice_IDCardInfo_I = JNIEnv.GetMethodID (class_ref, "getCardData", "(Lcom/sunmi/idcardservice/IDCardInfo;I)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_getCardData_Lcom_sunmi_idcardservice_IDCardInfo_I, __args);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Sunmi.Idcardservice.ICardCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
