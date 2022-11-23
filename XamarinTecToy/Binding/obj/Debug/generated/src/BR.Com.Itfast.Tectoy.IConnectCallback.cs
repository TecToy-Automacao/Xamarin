using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace BR.Com.Itfast.Tectoy {

	// Metadata.xml XPath interface reference: path="/api/package[@name='br.com.itfast.tectoy']/interface[@name='ConnectCallback']"
	[Register ("br/com/itfast/tectoy/ConnectCallback", "", "BR.Com.Itfast.Tectoy.IConnectCallbackInvoker")]
	public partial interface IConnectCallback : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.itfast.tectoy']/interface[@name='ConnectCallback']/method[@name='onSuccess' and count(parameter)=0]"
		[Register ("onSuccess", "()V", "GetOnSuccessHandler:BR.Com.Itfast.Tectoy.IConnectCallbackInvoker, Binding")]
		void OnSuccess ();

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.itfast.tectoy']/interface[@name='ConnectCallback']/method[@name='onfailed' and count(parameter)=0]"
		[Register ("onfailed", "()V", "GetOnfailedHandler:BR.Com.Itfast.Tectoy.IConnectCallbackInvoker, Binding")]
		void Onfailed ();

	}

	[global::Android.Runtime.Register ("br/com/itfast/tectoy/ConnectCallback", DoNotGenerateAcw=true)]
	internal partial class IConnectCallbackInvoker : global::Java.Lang.Object, IConnectCallback {
		static readonly JniPeerMembers _members = new XAPeerMembers ("br/com/itfast/tectoy/ConnectCallback", typeof (IConnectCallbackInvoker));

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

		public static IConnectCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IConnectCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'br.com.itfast.tectoy.ConnectCallback'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IConnectCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onSuccess;
#pragma warning disable 0169
		static Delegate GetOnSuccessHandler ()
		{
			if (cb_onSuccess == null)
				cb_onSuccess = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnSuccess);
			return cb_onSuccess;
		}

		static void n_OnSuccess (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Itfast.Tectoy.IConnectCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnSuccess ();
		}
#pragma warning restore 0169

		IntPtr id_onSuccess;
		public unsafe void OnSuccess ()
		{
			if (id_onSuccess == IntPtr.Zero)
				id_onSuccess = JNIEnv.GetMethodID (class_ref, "onSuccess", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSuccess);
		}

		static Delegate cb_onfailed;
#pragma warning disable 0169
		static Delegate GetOnfailedHandler ()
		{
			if (cb_onfailed == null)
				cb_onfailed = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Onfailed);
			return cb_onfailed;
		}

		static void n_Onfailed (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Itfast.Tectoy.IConnectCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Onfailed ();
		}
#pragma warning restore 0169

		IntPtr id_onfailed;
		public unsafe void Onfailed ()
		{
			if (id_onfailed == IntPtr.Zero)
				id_onfailed = JNIEnv.GetMethodID (class_ref, "onfailed", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onfailed);
		}

	}
}
