using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace BR.Com.Daruma.Framework.Mobile.Tef {

	// Metadata.xml XPath interface reference: path="/api/package[@name='br.com.daruma.framework.mobile.tef']/interface[@name='TefIT4RCallback']"
	[Register ("br/com/daruma/framework/mobile/tef/TefIT4RCallback", "", "BR.Com.Daruma.Framework.Mobile.Tef.ITefIT4RCallbackInvoker")]
	public partial interface ITefIT4RCallback : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.daruma.framework.mobile.tef']/interface[@name='TefIT4RCallback']/method[@name='retornarDadosTransacao' and count(parameter)=14 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='java.lang.String'] and parameter[7][@type='java.lang.String'] and parameter[8][@type='java.lang.String'] and parameter[9][@type='java.lang.String'] and parameter[10][@type='java.lang.String'] and parameter[11][@type='java.lang.String'] and parameter[12][@type='java.lang.String'] and parameter[13][@type='java.lang.String'] and parameter[14][@type='java.lang.String']]"
		[Register ("retornarDadosTransacao", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "GetRetornarDadosTransacao_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler:BR.Com.Daruma.Framework.Mobile.Tef.ITefIT4RCallbackInvoker, Binding")]
		void RetornarDadosTransacao (string p0, string p1, string p2, string p3, string p4, string p5, string p6, string p7, string p8, string p9, string p10, string p11, string p12, string p13);

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.daruma.framework.mobile.tef']/interface[@name='TefIT4RCallback']/method[@name='retornarFinalizacao' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("retornarFinalizacao", "(Ljava/lang/String;)V", "GetRetornarFinalizacao_Ljava_lang_String_Handler:BR.Com.Daruma.Framework.Mobile.Tef.ITefIT4RCallbackInvoker, Binding")]
		void RetornarFinalizacao (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.daruma.framework.mobile.tef']/interface[@name='TefIT4RCallback']/method[@name='retornarMensagemProgresso' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("retornarMensagemProgresso", "(Ljava/lang/String;)V", "GetRetornarMensagemProgresso_Ljava_lang_String_Handler:BR.Com.Daruma.Framework.Mobile.Tef.ITefIT4RCallbackInvoker, Binding")]
		void RetornarMensagemProgresso (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.daruma.framework.mobile.tef']/interface[@name='TefIT4RCallback']/method[@name='retornarOpcaoColeta' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("retornarOpcaoColeta", "(Ljava/lang/String;)V", "GetRetornarOpcaoColeta_Ljava_lang_String_Handler:BR.Com.Daruma.Framework.Mobile.Tef.ITefIT4RCallbackInvoker, Binding")]
		void RetornarOpcaoColeta (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.daruma.framework.mobile.tef']/interface[@name='TefIT4RCallback']/method[@name='retornarValor' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("retornarValor", "(Ljava/lang/String;)V", "GetRetornarValor_Ljava_lang_String_Handler:BR.Com.Daruma.Framework.Mobile.Tef.ITefIT4RCallbackInvoker, Binding")]
		void RetornarValor (string p0);

	}

	[global::Android.Runtime.Register ("br/com/daruma/framework/mobile/tef/TefIT4RCallback", DoNotGenerateAcw=true)]
	internal partial class ITefIT4RCallbackInvoker : global::Java.Lang.Object, ITefIT4RCallback {
		static readonly JniPeerMembers _members = new XAPeerMembers ("br/com/daruma/framework/mobile/tef/TefIT4RCallback", typeof (ITefIT4RCallbackInvoker));

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

		public static ITefIT4RCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ITefIT4RCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'br.com.daruma.framework.mobile.tef.TefIT4RCallback'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ITefIT4RCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_retornarDadosTransacao_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRetornarDadosTransacao_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_retornarDadosTransacao_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_retornarDadosTransacao_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLLLLLLLLLLLLLL_V (n_RetornarDadosTransacao_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_));
			return cb_retornarDadosTransacao_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_RetornarDadosTransacao_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4, IntPtr native_p5, IntPtr native_p6, IntPtr native_p7, IntPtr native_p8, IntPtr native_p9, IntPtr native_p10, IntPtr native_p11, IntPtr native_p12, IntPtr native_p13)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Daruma.Framework.Mobile.Tef.ITefIT4RCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			var p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			var p4 = JNIEnv.GetString (native_p4, JniHandleOwnership.DoNotTransfer);
			var p5 = JNIEnv.GetString (native_p5, JniHandleOwnership.DoNotTransfer);
			var p6 = JNIEnv.GetString (native_p6, JniHandleOwnership.DoNotTransfer);
			var p7 = JNIEnv.GetString (native_p7, JniHandleOwnership.DoNotTransfer);
			var p8 = JNIEnv.GetString (native_p8, JniHandleOwnership.DoNotTransfer);
			var p9 = JNIEnv.GetString (native_p9, JniHandleOwnership.DoNotTransfer);
			var p10 = JNIEnv.GetString (native_p10, JniHandleOwnership.DoNotTransfer);
			var p11 = JNIEnv.GetString (native_p11, JniHandleOwnership.DoNotTransfer);
			var p12 = JNIEnv.GetString (native_p12, JniHandleOwnership.DoNotTransfer);
			var p13 = JNIEnv.GetString (native_p13, JniHandleOwnership.DoNotTransfer);
			__this.RetornarDadosTransacao (p0, p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13);
		}
#pragma warning restore 0169

		IntPtr id_retornarDadosTransacao_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		public unsafe void RetornarDadosTransacao (string p0, string p1, string p2, string p3, string p4, string p5, string p6, string p7, string p8, string p9, string p10, string p11, string p12, string p13)
		{
			if (id_retornarDadosTransacao_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_retornarDadosTransacao_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "retornarDadosTransacao", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			IntPtr native_p1 = JNIEnv.NewString ((string)p1);
			IntPtr native_p2 = JNIEnv.NewString ((string)p2);
			IntPtr native_p3 = JNIEnv.NewString ((string)p3);
			IntPtr native_p4 = JNIEnv.NewString ((string)p4);
			IntPtr native_p5 = JNIEnv.NewString ((string)p5);
			IntPtr native_p6 = JNIEnv.NewString ((string)p6);
			IntPtr native_p7 = JNIEnv.NewString ((string)p7);
			IntPtr native_p8 = JNIEnv.NewString ((string)p8);
			IntPtr native_p9 = JNIEnv.NewString ((string)p9);
			IntPtr native_p10 = JNIEnv.NewString ((string)p10);
			IntPtr native_p11 = JNIEnv.NewString ((string)p11);
			IntPtr native_p12 = JNIEnv.NewString ((string)p12);
			IntPtr native_p13 = JNIEnv.NewString ((string)p13);
			JValue* __args = stackalloc JValue [14];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue (native_p3);
			__args [4] = new JValue (native_p4);
			__args [5] = new JValue (native_p5);
			__args [6] = new JValue (native_p6);
			__args [7] = new JValue (native_p7);
			__args [8] = new JValue (native_p8);
			__args [9] = new JValue (native_p9);
			__args [10] = new JValue (native_p10);
			__args [11] = new JValue (native_p11);
			__args [12] = new JValue (native_p12);
			__args [13] = new JValue (native_p13);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_retornarDadosTransacao_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
			JNIEnv.DeleteLocalRef (native_p3);
			JNIEnv.DeleteLocalRef (native_p4);
			JNIEnv.DeleteLocalRef (native_p5);
			JNIEnv.DeleteLocalRef (native_p6);
			JNIEnv.DeleteLocalRef (native_p7);
			JNIEnv.DeleteLocalRef (native_p8);
			JNIEnv.DeleteLocalRef (native_p9);
			JNIEnv.DeleteLocalRef (native_p10);
			JNIEnv.DeleteLocalRef (native_p11);
			JNIEnv.DeleteLocalRef (native_p12);
			JNIEnv.DeleteLocalRef (native_p13);
		}

		static Delegate cb_retornarFinalizacao_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRetornarFinalizacao_Ljava_lang_String_Handler ()
		{
			if (cb_retornarFinalizacao_Ljava_lang_String_ == null)
				cb_retornarFinalizacao_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_RetornarFinalizacao_Ljava_lang_String_));
			return cb_retornarFinalizacao_Ljava_lang_String_;
		}

		static void n_RetornarFinalizacao_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Daruma.Framework.Mobile.Tef.ITefIT4RCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RetornarFinalizacao (p0);
		}
#pragma warning restore 0169

		IntPtr id_retornarFinalizacao_Ljava_lang_String_;
		public unsafe void RetornarFinalizacao (string p0)
		{
			if (id_retornarFinalizacao_Ljava_lang_String_ == IntPtr.Zero)
				id_retornarFinalizacao_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "retornarFinalizacao", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_retornarFinalizacao_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_retornarMensagemProgresso_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRetornarMensagemProgresso_Ljava_lang_String_Handler ()
		{
			if (cb_retornarMensagemProgresso_Ljava_lang_String_ == null)
				cb_retornarMensagemProgresso_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_RetornarMensagemProgresso_Ljava_lang_String_));
			return cb_retornarMensagemProgresso_Ljava_lang_String_;
		}

		static void n_RetornarMensagemProgresso_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Daruma.Framework.Mobile.Tef.ITefIT4RCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RetornarMensagemProgresso (p0);
		}
#pragma warning restore 0169

		IntPtr id_retornarMensagemProgresso_Ljava_lang_String_;
		public unsafe void RetornarMensagemProgresso (string p0)
		{
			if (id_retornarMensagemProgresso_Ljava_lang_String_ == IntPtr.Zero)
				id_retornarMensagemProgresso_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "retornarMensagemProgresso", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_retornarMensagemProgresso_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_retornarOpcaoColeta_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRetornarOpcaoColeta_Ljava_lang_String_Handler ()
		{
			if (cb_retornarOpcaoColeta_Ljava_lang_String_ == null)
				cb_retornarOpcaoColeta_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_RetornarOpcaoColeta_Ljava_lang_String_));
			return cb_retornarOpcaoColeta_Ljava_lang_String_;
		}

		static void n_RetornarOpcaoColeta_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Daruma.Framework.Mobile.Tef.ITefIT4RCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RetornarOpcaoColeta (p0);
		}
#pragma warning restore 0169

		IntPtr id_retornarOpcaoColeta_Ljava_lang_String_;
		public unsafe void RetornarOpcaoColeta (string p0)
		{
			if (id_retornarOpcaoColeta_Ljava_lang_String_ == IntPtr.Zero)
				id_retornarOpcaoColeta_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "retornarOpcaoColeta", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_retornarOpcaoColeta_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
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
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Daruma.Framework.Mobile.Tef.ITefIT4RCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
