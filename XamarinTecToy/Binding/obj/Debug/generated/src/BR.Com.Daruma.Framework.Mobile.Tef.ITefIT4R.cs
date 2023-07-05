using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace BR.Com.Daruma.Framework.Mobile.Tef {

	// Metadata.xml XPath interface reference: path="/api/package[@name='br.com.daruma.framework.mobile.tef']/interface[@name='ITefIT4R']"
	[Register ("br/com/daruma/framework/mobile/tef/ITefIT4R", "", "BR.Com.Daruma.Framework.Mobile.Tef.ITefIT4RInvoker")]
	public partial interface ITefIT4R : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.daruma.framework.mobile.tef']/interface[@name='ITefIT4R']/method[@name='cancelarOperacao' and count(parameter)=0]"
		[Register ("cancelarOperacao", "()V", "GetCancelarOperacaoHandler:BR.Com.Daruma.Framework.Mobile.Tef.ITefIT4RInvoker, Binding")]
		void CancelarOperacao ();

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.daruma.framework.mobile.tef']/interface[@name='ITefIT4R']/method[@name='cancelarTransacao' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("cancelarTransacao", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "GetCancelarTransacao_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler:BR.Com.Daruma.Framework.Mobile.Tef.ITefIT4RInvoker, Binding")]
		void CancelarTransacao (string p0, string p1, string p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.daruma.framework.mobile.tef']/interface[@name='ITefIT4R']/method[@name='relatorioDiario' and count(parameter)=0]"
		[Register ("relatorioDiario", "()V", "GetRelatorioDiarioHandler:BR.Com.Daruma.Framework.Mobile.Tef.ITefIT4RInvoker, Binding")]
		void RelatorioDiario ();

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.daruma.framework.mobile.tef']/interface[@name='ITefIT4R']/method[@name='transacaoCredito' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='br.com.daruma.framework.mobile.tef.TipoFinanciamento'] and parameter[3][@type='java.lang.String']]"
		[Register ("transacaoCredito", "(Ljava/lang/String;Lbr/com/daruma/framework/mobile/tef/TipoFinanciamento;Ljava/lang/String;)V", "GetTransacaoCredito_Ljava_lang_String_Lbr_com_daruma_framework_mobile_tef_TipoFinanciamento_Ljava_lang_String_Handler:BR.Com.Daruma.Framework.Mobile.Tef.ITefIT4RInvoker, Binding")]
		void TransacaoCredito (string p0, global::BR.Com.Daruma.Framework.Mobile.Tef.TipoFinanciamento p1, string p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.daruma.framework.mobile.tef']/interface[@name='ITefIT4R']/method[@name='transacaoDebito' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("transacaoDebito", "(Ljava/lang/String;)V", "GetTransacaoDebito_Ljava_lang_String_Handler:BR.Com.Daruma.Framework.Mobile.Tef.ITefIT4RInvoker, Binding")]
		void TransacaoDebito (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.daruma.framework.mobile.tef']/interface[@name='ITefIT4R']/method[@name='ultimoComprovante' and count(parameter)=0]"
		[Register ("ultimoComprovante", "()V", "GetUltimoComprovanteHandler:BR.Com.Daruma.Framework.Mobile.Tef.ITefIT4RInvoker, Binding")]
		void UltimoComprovante ();

	}

	[global::Android.Runtime.Register ("br/com/daruma/framework/mobile/tef/ITefIT4R", DoNotGenerateAcw=true)]
	internal partial class ITefIT4RInvoker : global::Java.Lang.Object, ITefIT4R {
		static readonly JniPeerMembers _members = new XAPeerMembers ("br/com/daruma/framework/mobile/tef/ITefIT4R", typeof (ITefIT4RInvoker));

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

		public static ITefIT4R GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ITefIT4R> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'br.com.daruma.framework.mobile.tef.ITefIT4R'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ITefIT4RInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_cancelarOperacao;
#pragma warning disable 0169
		static Delegate GetCancelarOperacaoHandler ()
		{
			if (cb_cancelarOperacao == null)
				cb_cancelarOperacao = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_CancelarOperacao));
			return cb_cancelarOperacao;
		}

		static void n_CancelarOperacao (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Daruma.Framework.Mobile.Tef.ITefIT4R> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CancelarOperacao ();
		}
#pragma warning restore 0169

		IntPtr id_cancelarOperacao;
		public unsafe void CancelarOperacao ()
		{
			if (id_cancelarOperacao == IntPtr.Zero)
				id_cancelarOperacao = JNIEnv.GetMethodID (class_ref, "cancelarOperacao", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_cancelarOperacao);
		}

		static Delegate cb_cancelarTransacao_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetCancelarTransacao_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_cancelarTransacao_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_cancelarTransacao_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLLL_V (n_CancelarTransacao_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_));
			return cb_cancelarTransacao_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_CancelarTransacao_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Daruma.Framework.Mobile.Tef.ITefIT4R> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.CancelarTransacao (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_cancelarTransacao_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		public unsafe void CancelarTransacao (string p0, string p1, string p2)
		{
			if (id_cancelarTransacao_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_cancelarTransacao_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "cancelarTransacao", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			IntPtr native_p1 = JNIEnv.NewString ((string)p1);
			IntPtr native_p2 = JNIEnv.NewString ((string)p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_cancelarTransacao_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
		}

		static Delegate cb_relatorioDiario;
#pragma warning disable 0169
		static Delegate GetRelatorioDiarioHandler ()
		{
			if (cb_relatorioDiario == null)
				cb_relatorioDiario = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_RelatorioDiario));
			return cb_relatorioDiario;
		}

		static void n_RelatorioDiario (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Daruma.Framework.Mobile.Tef.ITefIT4R> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RelatorioDiario ();
		}
#pragma warning restore 0169

		IntPtr id_relatorioDiario;
		public unsafe void RelatorioDiario ()
		{
			if (id_relatorioDiario == IntPtr.Zero)
				id_relatorioDiario = JNIEnv.GetMethodID (class_ref, "relatorioDiario", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_relatorioDiario);
		}

		static Delegate cb_transacaoCredito_Ljava_lang_String_Lbr_com_daruma_framework_mobile_tef_TipoFinanciamento_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetTransacaoCredito_Ljava_lang_String_Lbr_com_daruma_framework_mobile_tef_TipoFinanciamento_Ljava_lang_String_Handler ()
		{
			if (cb_transacaoCredito_Ljava_lang_String_Lbr_com_daruma_framework_mobile_tef_TipoFinanciamento_Ljava_lang_String_ == null)
				cb_transacaoCredito_Ljava_lang_String_Lbr_com_daruma_framework_mobile_tef_TipoFinanciamento_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLLL_V (n_TransacaoCredito_Ljava_lang_String_Lbr_com_daruma_framework_mobile_tef_TipoFinanciamento_Ljava_lang_String_));
			return cb_transacaoCredito_Ljava_lang_String_Lbr_com_daruma_framework_mobile_tef_TipoFinanciamento_Ljava_lang_String_;
		}

		static void n_TransacaoCredito_Ljava_lang_String_Lbr_com_daruma_framework_mobile_tef_TipoFinanciamento_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Daruma.Framework.Mobile.Tef.ITefIT4R> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::BR.Com.Daruma.Framework.Mobile.Tef.TipoFinanciamento> (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.TransacaoCredito (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_transacaoCredito_Ljava_lang_String_Lbr_com_daruma_framework_mobile_tef_TipoFinanciamento_Ljava_lang_String_;
		public unsafe void TransacaoCredito (string p0, global::BR.Com.Daruma.Framework.Mobile.Tef.TipoFinanciamento p1, string p2)
		{
			if (id_transacaoCredito_Ljava_lang_String_Lbr_com_daruma_framework_mobile_tef_TipoFinanciamento_Ljava_lang_String_ == IntPtr.Zero)
				id_transacaoCredito_Ljava_lang_String_Lbr_com_daruma_framework_mobile_tef_TipoFinanciamento_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "transacaoCredito", "(Ljava/lang/String;Lbr/com/daruma/framework/mobile/tef/TipoFinanciamento;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			IntPtr native_p2 = JNIEnv.NewString ((string)p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			__args [2] = new JValue (native_p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_transacaoCredito_Ljava_lang_String_Lbr_com_daruma_framework_mobile_tef_TipoFinanciamento_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p2);
		}

		static Delegate cb_transacaoDebito_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetTransacaoDebito_Ljava_lang_String_Handler ()
		{
			if (cb_transacaoDebito_Ljava_lang_String_ == null)
				cb_transacaoDebito_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_TransacaoDebito_Ljava_lang_String_));
			return cb_transacaoDebito_Ljava_lang_String_;
		}

		static void n_TransacaoDebito_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Daruma.Framework.Mobile.Tef.ITefIT4R> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.TransacaoDebito (p0);
		}
#pragma warning restore 0169

		IntPtr id_transacaoDebito_Ljava_lang_String_;
		public unsafe void TransacaoDebito (string p0)
		{
			if (id_transacaoDebito_Ljava_lang_String_ == IntPtr.Zero)
				id_transacaoDebito_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "transacaoDebito", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_transacaoDebito_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_ultimoComprovante;
#pragma warning disable 0169
		static Delegate GetUltimoComprovanteHandler ()
		{
			if (cb_ultimoComprovante == null)
				cb_ultimoComprovante = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_UltimoComprovante));
			return cb_ultimoComprovante;
		}

		static void n_UltimoComprovante (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Daruma.Framework.Mobile.Tef.ITefIT4R> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UltimoComprovante ();
		}
#pragma warning restore 0169

		IntPtr id_ultimoComprovante;
		public unsafe void UltimoComprovante ()
		{
			if (id_ultimoComprovante == IntPtr.Zero)
				id_ultimoComprovante = JNIEnv.GetMethodID (class_ref, "ultimoComprovante", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_ultimoComprovante);
		}

	}
}
