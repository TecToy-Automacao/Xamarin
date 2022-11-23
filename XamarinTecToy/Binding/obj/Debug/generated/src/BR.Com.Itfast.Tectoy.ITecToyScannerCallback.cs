using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace BR.Com.Itfast.Tectoy {

	// Metadata.xml XPath interface reference: path="/api/package[@name='br.com.itfast.tectoy']/interface[@name='TecToyScannerCallback']"
	[Register ("br/com/itfast/tectoy/TecToyScannerCallback", "", "BR.Com.Itfast.Tectoy.ITecToyScannerCallbackInvoker")]
	public partial interface ITecToyScannerCallback : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.itfast.tectoy']/interface[@name='TecToyScannerCallback']/method[@name='retornarCodigo' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("retornarCodigo", "(Ljava/lang/String;)V", "GetRetornarCodigo_Ljava_lang_String_Handler:BR.Com.Itfast.Tectoy.ITecToyScannerCallbackInvoker, Binding")]
		void RetornarCodigo (string p0);

	}

	[global::Android.Runtime.Register ("br/com/itfast/tectoy/TecToyScannerCallback", DoNotGenerateAcw=true)]
	internal partial class ITecToyScannerCallbackInvoker : global::Java.Lang.Object, ITecToyScannerCallback {
		static readonly JniPeerMembers _members = new XAPeerMembers ("br/com/itfast/tectoy/TecToyScannerCallback", typeof (ITecToyScannerCallbackInvoker));

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

		public static ITecToyScannerCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ITecToyScannerCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'br.com.itfast.tectoy.TecToyScannerCallback'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ITecToyScannerCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_retornarCodigo_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRetornarCodigo_Ljava_lang_String_Handler ()
		{
			if (cb_retornarCodigo_Ljava_lang_String_ == null)
				cb_retornarCodigo_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_RetornarCodigo_Ljava_lang_String_);
			return cb_retornarCodigo_Ljava_lang_String_;
		}

		static void n_RetornarCodigo_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Itfast.Tectoy.ITecToyScannerCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RetornarCodigo (p0);
		}
#pragma warning restore 0169

		IntPtr id_retornarCodigo_Ljava_lang_String_;
		public unsafe void RetornarCodigo (string p0)
		{
			if (id_retornarCodigo_Ljava_lang_String_ == IntPtr.Zero)
				id_retornarCodigo_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "retornarCodigo", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_retornarCodigo_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}
}
