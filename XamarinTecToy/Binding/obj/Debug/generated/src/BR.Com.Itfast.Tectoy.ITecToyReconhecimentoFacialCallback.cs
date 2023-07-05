using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace BR.Com.Itfast.Tectoy {

	// Metadata.xml XPath interface reference: path="/api/package[@name='br.com.itfast.tectoy']/interface[@name='TecToyReconhecimentoFacialCallback']"
	[Register ("br/com/itfast/tectoy/TecToyReconhecimentoFacialCallback", "", "BR.Com.Itfast.Tectoy.ITecToyReconhecimentoFacialCallbackInvoker")]
	public partial interface ITecToyReconhecimentoFacialCallback : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.itfast.tectoy']/interface[@name='TecToyReconhecimentoFacialCallback']/method[@name='retoroErro' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("retoroErro", "(Ljava/lang/String;)V", "GetRetoroErro_Ljava_lang_String_Handler:BR.Com.Itfast.Tectoy.ITecToyReconhecimentoFacialCallbackInvoker, Binding")]
		void RetoroErro (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.itfast.tectoy']/interface[@name='TecToyReconhecimentoFacialCallback']/method[@name='retoroSucesso' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("retoroSucesso", "(Ljava/lang/String;Ljava/lang/String;)V", "GetRetoroSucesso_Ljava_lang_String_Ljava_lang_String_Handler:BR.Com.Itfast.Tectoy.ITecToyReconhecimentoFacialCallbackInvoker, Binding")]
		void RetoroSucesso (string p0, string p1);

	}

	[global::Android.Runtime.Register ("br/com/itfast/tectoy/TecToyReconhecimentoFacialCallback", DoNotGenerateAcw=true)]
	internal partial class ITecToyReconhecimentoFacialCallbackInvoker : global::Java.Lang.Object, ITecToyReconhecimentoFacialCallback {
		static readonly JniPeerMembers _members = new XAPeerMembers ("br/com/itfast/tectoy/TecToyReconhecimentoFacialCallback", typeof (ITecToyReconhecimentoFacialCallbackInvoker));

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

		public static ITecToyReconhecimentoFacialCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ITecToyReconhecimentoFacialCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'br.com.itfast.tectoy.TecToyReconhecimentoFacialCallback'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ITecToyReconhecimentoFacialCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_retoroErro_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRetoroErro_Ljava_lang_String_Handler ()
		{
			if (cb_retoroErro_Ljava_lang_String_ == null)
				cb_retoroErro_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_RetoroErro_Ljava_lang_String_));
			return cb_retoroErro_Ljava_lang_String_;
		}

		static void n_RetoroErro_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Itfast.Tectoy.ITecToyReconhecimentoFacialCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RetoroErro (p0);
		}
#pragma warning restore 0169

		IntPtr id_retoroErro_Ljava_lang_String_;
		public unsafe void RetoroErro (string p0)
		{
			if (id_retoroErro_Ljava_lang_String_ == IntPtr.Zero)
				id_retoroErro_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "retoroErro", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_retoroErro_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_retoroSucesso_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRetoroSucesso_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_retoroSucesso_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_retoroSucesso_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_V (n_RetoroSucesso_Ljava_lang_String_Ljava_lang_String_));
			return cb_retoroSucesso_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_RetoroSucesso_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Itfast.Tectoy.ITecToyReconhecimentoFacialCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.RetoroSucesso (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_retoroSucesso_Ljava_lang_String_Ljava_lang_String_;
		public unsafe void RetoroSucesso (string p0, string p1)
		{
			if (id_retoroSucesso_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_retoroSucesso_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "retoroSucesso", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			IntPtr native_p1 = JNIEnv.NewString ((string)p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_retoroSucesso_Ljava_lang_String_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

	}
}
