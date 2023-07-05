using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace BR.Com.Itfast.Tectoy {

	// Metadata.xml XPath interface reference: path="/api/package[@name='br.com.itfast.tectoy']/interface[@name='TecToyNfcCallback']"
	[Register ("br/com/itfast/tectoy/TecToyNfcCallback", "", "BR.Com.Itfast.Tectoy.ITecToyNfcCallbackInvoker")]
	public partial interface ITecToyNfcCallback : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.itfast.tectoy']/interface[@name='TecToyNfcCallback']/method[@name='retornarValor' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("retornarValor", "(Ljava/lang/String;)V", "GetRetornarValor_Ljava_lang_String_Handler:BR.Com.Itfast.Tectoy.ITecToyNfcCallbackInvoker, Binding")]
		void RetornarValor (string p0);

	}

	[global::Android.Runtime.Register ("br/com/itfast/tectoy/TecToyNfcCallback", DoNotGenerateAcw=true)]
	internal partial class ITecToyNfcCallbackInvoker : global::Java.Lang.Object, ITecToyNfcCallback {
		static readonly JniPeerMembers _members = new XAPeerMembers ("br/com/itfast/tectoy/TecToyNfcCallback", typeof (ITecToyNfcCallbackInvoker));

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

		public static ITecToyNfcCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ITecToyNfcCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'br.com.itfast.tectoy.TecToyNfcCallback'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ITecToyNfcCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_retornarValor_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRetornarValor_Ljava_lang_String_Handler ()
		{
			if (cb_retornarValor_Ljava_lang_String_ == null)
				cb_retornarValor_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_RetornarValor_Ljava_lang_String_));
			return cb_retornarValor_Ljava_lang_String_;
		}

		static void n_RetornarValor_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Itfast.Tectoy.ITecToyNfcCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RetornarValor (p0);
		}
#pragma warning restore 0169

		IntPtr id_retornarValor_Ljava_lang_String_;
		public unsafe void RetornarValor (string p0)
		{
			if (id_retornarValor_Ljava_lang_String_ == IntPtr.Zero)
				id_retornarValor_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "retornarValor", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_retornarValor_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}
}
