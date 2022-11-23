using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Sunmi.Idcardservice {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.sunmi.idcardservice']/class[@name='IDCardServiceAidl.Default']"
	[global::Android.Runtime.Register ("com/sunmi/idcardservice/IDCardServiceAidl$Default", DoNotGenerateAcw=true)]
	public partial class DCardServiceAidlDefault : global::Java.Lang.Object, global::Com.Sunmi.Idcardservice.IDCardServiceAidl {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/sunmi/idcardservice/IDCardServiceAidl$Default", typeof (DCardServiceAidlDefault));

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

		protected DCardServiceAidlDefault (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.sunmi.idcardservice']/class[@name='IDCardServiceAidl.Default']/constructor[@name='IDCardServiceAidl.Default' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DCardServiceAidlDefault () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_getMiFareCardService;
#pragma warning disable 0169
		static Delegate GetGetMiFareCardServiceHandler ()
		{
			if (cb_getMiFareCardService == null)
				cb_getMiFareCardService = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetMiFareCardService);
			return cb_getMiFareCardService;
		}

		static IntPtr n_GetMiFareCardService (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Sunmi.Idcardservice.DCardServiceAidlDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.MiFareCardService);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Sunmi.Idcardservice.IMiFareCardAidl MiFareCardService {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.sunmi.idcardservice']/class[@name='IDCardServiceAidl.Default']/method[@name='getMiFareCardService' and count(parameter)=0]"
			[Register ("getMiFareCardService", "()Lcom/sunmi/idcardservice/MiFareCardAidl;", "GetGetMiFareCardServiceHandler")]
			get {
				const string __id = "getMiFareCardService.()Lcom/sunmi/idcardservice/MiFareCardAidl;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Sunmi.Idcardservice.IMiFareCardAidl> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Sunmi.Idcardservice.DCardServiceAidlDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.sunmi.idcardservice']/class[@name='IDCardServiceAidl.Default']/method[@name='asBinder' and count(parameter)=0]"
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

		static Delegate cb_cancelAutoReading;
#pragma warning disable 0169
		static Delegate GetCancelAutoReadingHandler ()
		{
			if (cb_cancelAutoReading == null)
				cb_cancelAutoReading = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_CancelAutoReading);
			return cb_cancelAutoReading;
		}

		static void n_CancelAutoReading (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Sunmi.Idcardservice.DCardServiceAidlDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CancelAutoReading ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.sunmi.idcardservice']/class[@name='IDCardServiceAidl.Default']/method[@name='cancelAutoReading' and count(parameter)=0]"
		[Register ("cancelAutoReading", "()V", "GetCancelAutoReadingHandler")]
		public virtual unsafe void CancelAutoReading ()
		{
			const string __id = "cancelAutoReading.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_readCard;
#pragma warning disable 0169
		static Delegate GetReadCardHandler ()
		{
			if (cb_readCard == null)
				cb_readCard = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_ReadCard);
			return cb_readCard;
		}

		static IntPtr n_ReadCard (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Sunmi.Idcardservice.DCardServiceAidlDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ReadCard ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.sunmi.idcardservice']/class[@name='IDCardServiceAidl.Default']/method[@name='readCard' and count(parameter)=0]"
		[Register ("readCard", "()Lcom/sunmi/idcardservice/IDCardInfo;", "GetReadCardHandler")]
		public virtual unsafe global::Com.Sunmi.Idcardservice.IDCardInfo ReadCard ()
		{
			const string __id = "readCard.()Lcom/sunmi/idcardservice/IDCardInfo;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Sunmi.Idcardservice.IDCardInfo> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_readCardAuto_Lcom_sunmi_idcardservice_CardCallback_;
#pragma warning disable 0169
		static Delegate GetReadCardAuto_Lcom_sunmi_idcardservice_CardCallback_Handler ()
		{
			if (cb_readCardAuto_Lcom_sunmi_idcardservice_CardCallback_ == null)
				cb_readCardAuto_Lcom_sunmi_idcardservice_CardCallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_ReadCardAuto_Lcom_sunmi_idcardservice_CardCallback_);
			return cb_readCardAuto_Lcom_sunmi_idcardservice_CardCallback_;
		}

		static void n_ReadCardAuto_Lcom_sunmi_idcardservice_CardCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native__callback)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Sunmi.Idcardservice.DCardServiceAidlDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var @callback = (global::Com.Sunmi.Idcardservice.ICardCallback)global::Java.Lang.Object.GetObject<global::Com.Sunmi.Idcardservice.ICardCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.ReadCardAuto (@callback);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.sunmi.idcardservice']/class[@name='IDCardServiceAidl.Default']/method[@name='readCardAuto' and count(parameter)=1 and parameter[1][@type='com.sunmi.idcardservice.CardCallback']]"
		[Register ("readCardAuto", "(Lcom/sunmi/idcardservice/CardCallback;)V", "GetReadCardAuto_Lcom_sunmi_idcardservice_CardCallback_Handler")]
		public virtual unsafe void ReadCardAuto (global::Com.Sunmi.Idcardservice.ICardCallback @callback)
		{
			const string __id = "readCardAuto.(Lcom/sunmi/idcardservice/CardCallback;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (@callback);
			}
		}

	}

	// Metadata.xml XPath class reference: path="/api/package[@name='com.sunmi.idcardservice']/class[@name='IDCardServiceAidl.Stub']"
	[global::Android.Runtime.Register ("com/sunmi/idcardservice/IDCardServiceAidl$Stub", DoNotGenerateAcw=true)]
	public abstract partial class DCardServiceAidlStub : global::Android.OS.Binder, global::Com.Sunmi.Idcardservice.IDCardServiceAidl {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/sunmi/idcardservice/IDCardServiceAidl$Stub", typeof (DCardServiceAidlStub));

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

		protected DCardServiceAidlStub (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.sunmi.idcardservice']/class[@name='IDCardServiceAidl.Stub']/constructor[@name='IDCardServiceAidl.Stub' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DCardServiceAidlStub () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		public static unsafe global::Com.Sunmi.Idcardservice.IDCardServiceAidl DefaultImpl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.sunmi.idcardservice']/class[@name='IDCardServiceAidl.Stub']/method[@name='getDefaultImpl' and count(parameter)=0]"
			[Register ("getDefaultImpl", "()Lcom/sunmi/idcardservice/IDCardServiceAidl;", "")]
			get {
				const string __id = "getDefaultImpl.()Lcom/sunmi/idcardservice/IDCardServiceAidl;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Com.Sunmi.Idcardservice.IDCardServiceAidl> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Sunmi.Idcardservice.DCardServiceAidlStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.sunmi.idcardservice']/class[@name='IDCardServiceAidl.Stub']/method[@name='asBinder' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.sunmi.idcardservice']/class[@name='IDCardServiceAidl.Stub']/method[@name='asInterface' and count(parameter)=1 and parameter[1][@type='android.os.IBinder']]"
		[Register ("asInterface", "(Landroid/os/IBinder;)Lcom/sunmi/idcardservice/IDCardServiceAidl;", "")]
		public static unsafe global::Com.Sunmi.Idcardservice.IDCardServiceAidl AsInterface (global::Android.OS.IBinder obj)
		{
			const string __id = "asInterface.(Landroid/os/IBinder;)Lcom/sunmi/idcardservice/IDCardServiceAidl;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Sunmi.Idcardservice.IDCardServiceAidl> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Sunmi.Idcardservice.DCardServiceAidlStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var data = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_data, JniHandleOwnership.DoNotTransfer);
			var reply = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_reply, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnTransact (code, data, reply, flags);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.sunmi.idcardservice']/class[@name='IDCardServiceAidl.Stub']/method[@name='onTransact' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='android.os.Parcel'] and parameter[3][@type='android.os.Parcel'] and parameter[4][@type='int']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.sunmi.idcardservice']/class[@name='IDCardServiceAidl.Stub']/method[@name='setDefaultImpl' and count(parameter)=1 and parameter[1][@type='com.sunmi.idcardservice.IDCardServiceAidl']]"
		[Register ("setDefaultImpl", "(Lcom/sunmi/idcardservice/IDCardServiceAidl;)Z", "")]
		public static unsafe bool SetDefaultImpl (global::Com.Sunmi.Idcardservice.IDCardServiceAidl impl)
		{
			const string __id = "setDefaultImpl.(Lcom/sunmi/idcardservice/IDCardServiceAidl;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((impl == null) ? IntPtr.Zero : ((global::Java.Lang.Object) impl).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (impl);
			}
		}

		static Delegate cb_cancelAutoReading;
#pragma warning disable 0169
		static Delegate GetCancelAutoReadingHandler ()
		{
			if (cb_cancelAutoReading == null)
				cb_cancelAutoReading = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_CancelAutoReading);
			return cb_cancelAutoReading;
		}

		static void n_CancelAutoReading (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Sunmi.Idcardservice.DCardServiceAidlStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CancelAutoReading ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.sunmi.idcardservice']/interface[@name='IDCardServiceAidl']/method[@name='cancelAutoReading' and count(parameter)=0]"
		[Register ("cancelAutoReading", "()V", "GetCancelAutoReadingHandler")]
		public abstract void CancelAutoReading ();

		static Delegate cb_readCard;
#pragma warning disable 0169
		static Delegate GetReadCardHandler ()
		{
			if (cb_readCard == null)
				cb_readCard = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_ReadCard);
			return cb_readCard;
		}

		static IntPtr n_ReadCard (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Sunmi.Idcardservice.DCardServiceAidlStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ReadCard ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.sunmi.idcardservice']/interface[@name='IDCardServiceAidl']/method[@name='readCard' and count(parameter)=0]"
		[Register ("readCard", "()Lcom/sunmi/idcardservice/IDCardInfo;", "GetReadCardHandler")]
		public abstract global::Com.Sunmi.Idcardservice.IDCardInfo ReadCard ();

		static Delegate cb_readCardAuto_Lcom_sunmi_idcardservice_CardCallback_;
#pragma warning disable 0169
		static Delegate GetReadCardAuto_Lcom_sunmi_idcardservice_CardCallback_Handler ()
		{
			if (cb_readCardAuto_Lcom_sunmi_idcardservice_CardCallback_ == null)
				cb_readCardAuto_Lcom_sunmi_idcardservice_CardCallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_ReadCardAuto_Lcom_sunmi_idcardservice_CardCallback_);
			return cb_readCardAuto_Lcom_sunmi_idcardservice_CardCallback_;
		}

		static void n_ReadCardAuto_Lcom_sunmi_idcardservice_CardCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Sunmi.Idcardservice.DCardServiceAidlStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Sunmi.Idcardservice.ICardCallback)global::Java.Lang.Object.GetObject<global::Com.Sunmi.Idcardservice.ICardCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ReadCardAuto (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.sunmi.idcardservice']/interface[@name='IDCardServiceAidl']/method[@name='readCardAuto' and count(parameter)=1 and parameter[1][@type='com.sunmi.idcardservice.CardCallback']]"
		[Register ("readCardAuto", "(Lcom/sunmi/idcardservice/CardCallback;)V", "GetReadCardAuto_Lcom_sunmi_idcardservice_CardCallback_Handler")]
		public abstract void ReadCardAuto (global::Com.Sunmi.Idcardservice.ICardCallback p0);

		static Delegate cb_getMiFareCardService;
#pragma warning disable 0169
		static Delegate GetGetMiFareCardServiceHandler ()
		{
			if (cb_getMiFareCardService == null)
				cb_getMiFareCardService = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetMiFareCardService);
			return cb_getMiFareCardService;
		}

		static IntPtr n_GetMiFareCardService (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Sunmi.Idcardservice.DCardServiceAidlStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.MiFareCardService);
		}
#pragma warning restore 0169

		public abstract global::Com.Sunmi.Idcardservice.IMiFareCardAidl MiFareCardService {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.sunmi.idcardservice']/class[@name='IDCardServiceAidl.Stub']/method[@name='getMiFareCardService' and count(parameter)=0]"
			[Register ("getMiFareCardService", "()Lcom/sunmi/idcardservice/MiFareCardAidl;", "GetGetMiFareCardServiceHandler")]
			get; 
		}

	}

	[global::Android.Runtime.Register ("com/sunmi/idcardservice/IDCardServiceAidl$Stub", DoNotGenerateAcw=true)]
	internal partial class DCardServiceAidlStubInvoker : DCardServiceAidlStub {
		public DCardServiceAidlStubInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/sunmi/idcardservice/IDCardServiceAidl$Stub", typeof (DCardServiceAidlStubInvoker));

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

		public override unsafe global::Com.Sunmi.Idcardservice.IMiFareCardAidl MiFareCardService {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.sunmi.idcardservice']/class[@name='IDCardServiceAidl.Stub']/method[@name='getMiFareCardService' and count(parameter)=0]"
			[Register ("getMiFareCardService", "()Lcom/sunmi/idcardservice/MiFareCardAidl;", "GetGetMiFareCardServiceHandler")]
			get {
				const string __id = "getMiFareCardService.()Lcom/sunmi/idcardservice/MiFareCardAidl;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Sunmi.Idcardservice.IMiFareCardAidl> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.sunmi.idcardservice']/interface[@name='IDCardServiceAidl']/method[@name='cancelAutoReading' and count(parameter)=0]"
		[Register ("cancelAutoReading", "()V", "GetCancelAutoReadingHandler")]
		public override unsafe void CancelAutoReading ()
		{
			const string __id = "cancelAutoReading.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.sunmi.idcardservice']/interface[@name='IDCardServiceAidl']/method[@name='readCard' and count(parameter)=0]"
		[Register ("readCard", "()Lcom/sunmi/idcardservice/IDCardInfo;", "GetReadCardHandler")]
		public override unsafe global::Com.Sunmi.Idcardservice.IDCardInfo ReadCard ()
		{
			const string __id = "readCard.()Lcom/sunmi/idcardservice/IDCardInfo;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Sunmi.Idcardservice.IDCardInfo> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.sunmi.idcardservice']/interface[@name='IDCardServiceAidl']/method[@name='readCardAuto' and count(parameter)=1 and parameter[1][@type='com.sunmi.idcardservice.CardCallback']]"
		[Register ("readCardAuto", "(Lcom/sunmi/idcardservice/CardCallback;)V", "GetReadCardAuto_Lcom_sunmi_idcardservice_CardCallback_Handler")]
		public override unsafe void ReadCardAuto (global::Com.Sunmi.Idcardservice.ICardCallback p0)
		{
			const string __id = "readCardAuto.(Lcom/sunmi/idcardservice/CardCallback;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.sunmi.idcardservice']/interface[@name='IDCardServiceAidl']"
	[Register ("com/sunmi/idcardservice/IDCardServiceAidl", "", "Com.Sunmi.Idcardservice.IDCardServiceAidlInvoker")]
	public partial interface IDCardServiceAidl : global::Android.OS.IInterface {
		global::Com.Sunmi.Idcardservice.IMiFareCardAidl MiFareCardService {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.sunmi.idcardservice']/interface[@name='IDCardServiceAidl']/method[@name='getMiFareCardService' and count(parameter)=0]"
			[Register ("getMiFareCardService", "()Lcom/sunmi/idcardservice/MiFareCardAidl;", "GetGetMiFareCardServiceHandler:Com.Sunmi.Idcardservice.IDCardServiceAidlInvoker, Binding")]
			get; 
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.sunmi.idcardservice']/interface[@name='IDCardServiceAidl']/method[@name='cancelAutoReading' and count(parameter)=0]"
		[Register ("cancelAutoReading", "()V", "GetCancelAutoReadingHandler:Com.Sunmi.Idcardservice.IDCardServiceAidlInvoker, Binding")]
		void CancelAutoReading ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.sunmi.idcardservice']/interface[@name='IDCardServiceAidl']/method[@name='readCard' and count(parameter)=0]"
		[Register ("readCard", "()Lcom/sunmi/idcardservice/IDCardInfo;", "GetReadCardHandler:Com.Sunmi.Idcardservice.IDCardServiceAidlInvoker, Binding")]
		global::Com.Sunmi.Idcardservice.IDCardInfo ReadCard ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.sunmi.idcardservice']/interface[@name='IDCardServiceAidl']/method[@name='readCardAuto' and count(parameter)=1 and parameter[1][@type='com.sunmi.idcardservice.CardCallback']]"
		[Register ("readCardAuto", "(Lcom/sunmi/idcardservice/CardCallback;)V", "GetReadCardAuto_Lcom_sunmi_idcardservice_CardCallback_Handler:Com.Sunmi.Idcardservice.IDCardServiceAidlInvoker, Binding")]
		void ReadCardAuto (global::Com.Sunmi.Idcardservice.ICardCallback p0);

	}

	[global::Android.Runtime.Register ("com/sunmi/idcardservice/IDCardServiceAidl", DoNotGenerateAcw=true)]
	internal partial class IDCardServiceAidlInvoker : global::Java.Lang.Object, IDCardServiceAidl {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/sunmi/idcardservice/IDCardServiceAidl", typeof (IDCardServiceAidlInvoker));

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

		public static IDCardServiceAidl GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IDCardServiceAidl> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.sunmi.idcardservice.IDCardServiceAidl'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IDCardServiceAidlInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getMiFareCardService;
#pragma warning disable 0169
		static Delegate GetGetMiFareCardServiceHandler ()
		{
			if (cb_getMiFareCardService == null)
				cb_getMiFareCardService = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetMiFareCardService);
			return cb_getMiFareCardService;
		}

		static IntPtr n_GetMiFareCardService (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Sunmi.Idcardservice.IDCardServiceAidl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.MiFareCardService);
		}
#pragma warning restore 0169

		IntPtr id_getMiFareCardService;
		public unsafe global::Com.Sunmi.Idcardservice.IMiFareCardAidl MiFareCardService {
			get {
				if (id_getMiFareCardService == IntPtr.Zero)
					id_getMiFareCardService = JNIEnv.GetMethodID (class_ref, "getMiFareCardService", "()Lcom/sunmi/idcardservice/MiFareCardAidl;");
				return global::Java.Lang.Object.GetObject<global::Com.Sunmi.Idcardservice.IMiFareCardAidl> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMiFareCardService), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_cancelAutoReading;
#pragma warning disable 0169
		static Delegate GetCancelAutoReadingHandler ()
		{
			if (cb_cancelAutoReading == null)
				cb_cancelAutoReading = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_CancelAutoReading);
			return cb_cancelAutoReading;
		}

		static void n_CancelAutoReading (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Sunmi.Idcardservice.IDCardServiceAidl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CancelAutoReading ();
		}
#pragma warning restore 0169

		IntPtr id_cancelAutoReading;
		public unsafe void CancelAutoReading ()
		{
			if (id_cancelAutoReading == IntPtr.Zero)
				id_cancelAutoReading = JNIEnv.GetMethodID (class_ref, "cancelAutoReading", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_cancelAutoReading);
		}

		static Delegate cb_readCard;
#pragma warning disable 0169
		static Delegate GetReadCardHandler ()
		{
			if (cb_readCard == null)
				cb_readCard = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_ReadCard);
			return cb_readCard;
		}

		static IntPtr n_ReadCard (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Sunmi.Idcardservice.IDCardServiceAidl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ReadCard ());
		}
#pragma warning restore 0169

		IntPtr id_readCard;
		public unsafe global::Com.Sunmi.Idcardservice.IDCardInfo ReadCard ()
		{
			if (id_readCard == IntPtr.Zero)
				id_readCard = JNIEnv.GetMethodID (class_ref, "readCard", "()Lcom/sunmi/idcardservice/IDCardInfo;");
			return global::Java.Lang.Object.GetObject<global::Com.Sunmi.Idcardservice.IDCardInfo> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_readCard), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_readCardAuto_Lcom_sunmi_idcardservice_CardCallback_;
#pragma warning disable 0169
		static Delegate GetReadCardAuto_Lcom_sunmi_idcardservice_CardCallback_Handler ()
		{
			if (cb_readCardAuto_Lcom_sunmi_idcardservice_CardCallback_ == null)
				cb_readCardAuto_Lcom_sunmi_idcardservice_CardCallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_ReadCardAuto_Lcom_sunmi_idcardservice_CardCallback_);
			return cb_readCardAuto_Lcom_sunmi_idcardservice_CardCallback_;
		}

		static void n_ReadCardAuto_Lcom_sunmi_idcardservice_CardCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Sunmi.Idcardservice.IDCardServiceAidl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Sunmi.Idcardservice.ICardCallback)global::Java.Lang.Object.GetObject<global::Com.Sunmi.Idcardservice.ICardCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ReadCardAuto (p0);
		}
#pragma warning restore 0169

		IntPtr id_readCardAuto_Lcom_sunmi_idcardservice_CardCallback_;
		public unsafe void ReadCardAuto (global::Com.Sunmi.Idcardservice.ICardCallback p0)
		{
			if (id_readCardAuto_Lcom_sunmi_idcardservice_CardCallback_ == IntPtr.Zero)
				id_readCardAuto_Lcom_sunmi_idcardservice_CardCallback_ = JNIEnv.GetMethodID (class_ref, "readCardAuto", "(Lcom/sunmi/idcardservice/CardCallback;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_readCardAuto_Lcom_sunmi_idcardservice_CardCallback_, __args);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Sunmi.Idcardservice.IDCardServiceAidl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
