using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace BR.Com.Itfast.Tectoy {

	// Metadata.xml XPath interface reference: path="/api/package[@name='br.com.itfast.tectoy']/interface[@name='TecToyServices']"
	[Register ("br/com/itfast/tectoy/TecToyServices", "", "BR.Com.Itfast.Tectoy.ITecToyServicesInvoker")]
	public partial interface ITecToyServices : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.itfast.tectoy']/interface[@name='TecToyServices']/method[@name='abrirGaveta' and count(parameter)=0]"
		[Register ("abrirGaveta", "()V", "GetAbrirGavetaHandler:BR.Com.Itfast.Tectoy.ITecToyServicesInvoker, Binding")]
		void AbrirGaveta ();

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.itfast.tectoy']/interface[@name='TecToyServices']/method[@name='bmpDisplay' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap']]"
		[Register ("bmpDisplay", "(Landroid/graphics/Bitmap;)V", "GetBmpDisplay_Landroid_graphics_Bitmap_Handler:BR.Com.Itfast.Tectoy.ITecToyServicesInvoker, Binding")]
		void BmpDisplay (global::Android.Graphics.Bitmap p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.itfast.tectoy']/interface[@name='TecToyServices']/method[@name='dispositivoNFC' and count(parameter)=0]"
		[Register ("dispositivoNFC", "()Landroid/nfc/NfcAdapter;", "GetDispositivoNFCHandler:BR.Com.Itfast.Tectoy.ITecToyServicesInvoker, Binding")]
		global::Android.Nfc.NfcAdapter DispositivoNFC ();

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.itfast.tectoy']/interface[@name='TecToyServices']/method[@name='escreveDisplay' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("escreveDisplay", "(Ljava/lang/String;)V", "GetEscreveDisplay_Ljava_lang_String_Handler:BR.Com.Itfast.Tectoy.ITecToyServicesInvoker, Binding")]
		void EscreveDisplay (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.itfast.tectoy']/interface[@name='TecToyServices']/method[@name='escreveDisplay' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("escreveDisplay", "(Ljava/lang/String;Ljava/lang/String;)V", "GetEscreveDisplay_Ljava_lang_String_Ljava_lang_String_Handler:BR.Com.Itfast.Tectoy.ITecToyServicesInvoker, Binding")]
		void EscreveDisplay (string p0, string p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.itfast.tectoy']/interface[@name='TecToyServices']/method[@name='gavetaAberta' and count(parameter)=0]"
		[Register ("gavetaAberta", "()Z", "GetGavetaAbertaHandler:BR.Com.Itfast.Tectoy.ITecToyServicesInvoker, Binding")]
		bool GavetaAberta ();

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.itfast.tectoy']/interface[@name='TecToyServices']/method[@name='imprimir' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("imprimir", "(Ljava/lang/String;)Z", "GetImprimir_Ljava_lang_String_Handler:BR.Com.Itfast.Tectoy.ITecToyServicesInvoker, Binding")]
		bool Imprimir (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.itfast.tectoy']/interface[@name='TecToyServices']/method[@name='iniciarNFC' and count(parameter)=2 and parameter[1][@type='br.com.itfast.tectoy.TecToyNfcCallback'] and parameter[2][@type='android.content.Intent']]"
		[Register ("iniciarNFC", "(Lbr/com/itfast/tectoy/TecToyNfcCallback;Landroid/content/Intent;)V", "GetIniciarNFC_Lbr_com_itfast_tectoy_TecToyNfcCallback_Landroid_content_Intent_Handler:BR.Com.Itfast.Tectoy.ITecToyServicesInvoker, Binding")]
		void IniciarNFC (global::BR.Com.Itfast.Tectoy.ITecToyNfcCallback p0, global::Android.Content.Intent p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.itfast.tectoy']/interface[@name='TecToyServices']/method[@name='iniciarScanner' and count(parameter)=1 and parameter[1][@type='br.com.itfast.tectoy.TecToyScannerCallback']]"
		[Register ("iniciarScanner", "(Lbr/com/itfast/tectoy/TecToyScannerCallback;)V", "GetIniciarScanner_Lbr_com_itfast_tectoy_TecToyScannerCallback_Handler:BR.Com.Itfast.Tectoy.ITecToyServicesInvoker, Binding")]
		void IniciarScanner (global::BR.Com.Itfast.Tectoy.ITecToyScannerCallback p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.itfast.tectoy']/interface[@name='TecToyServices']/method[@name='limparDisplay' and count(parameter)=0]"
		[Register ("limparDisplay", "()V", "GetLimparDisplayHandler:BR.Com.Itfast.Tectoy.ITecToyServicesInvoker, Binding")]
		void LimparDisplay ();

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.itfast.tectoy']/interface[@name='TecToyServices']/method[@name='pararScanner' and count(parameter)=0]"
		[Register ("pararScanner", "()V", "GetPararScannerHandler:BR.Com.Itfast.Tectoy.ITecToyServicesInvoker, Binding")]
		void PararScanner ();

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.itfast.tectoy']/interface[@name='TecToyServices']/method[@name='qrCodeDisplay' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("qrCodeDisplay", "(Ljava/lang/String;)V", "GetQrCodeDisplay_Ljava_lang_String_Handler:BR.Com.Itfast.Tectoy.ITecToyServicesInvoker, Binding")]
		void QrCodeDisplay (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.itfast.tectoy']/interface[@name='TecToyServices']/method[@name='statusImpressora' and count(parameter)=0]"
		[Register ("statusImpressora", "()Lbr/com/itfast/tectoy/StatusImpressora;", "GetStatusImpressoraHandler:BR.Com.Itfast.Tectoy.ITecToyServicesInvoker, Binding")]
		global::BR.Com.Itfast.Tectoy.StatusImpressora StatusImpressora ();

	}

	[global::Android.Runtime.Register ("br/com/itfast/tectoy/TecToyServices", DoNotGenerateAcw=true)]
	internal partial class ITecToyServicesInvoker : global::Java.Lang.Object, ITecToyServices {
		static readonly JniPeerMembers _members = new XAPeerMembers ("br/com/itfast/tectoy/TecToyServices", typeof (ITecToyServicesInvoker));

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

		public static ITecToyServices GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ITecToyServices> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'br.com.itfast.tectoy.TecToyServices'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ITecToyServicesInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_abrirGaveta;
#pragma warning disable 0169
		static Delegate GetAbrirGavetaHandler ()
		{
			if (cb_abrirGaveta == null)
				cb_abrirGaveta = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_AbrirGaveta);
			return cb_abrirGaveta;
		}

		static void n_AbrirGaveta (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Itfast.Tectoy.ITecToyServices> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AbrirGaveta ();
		}
#pragma warning restore 0169

		IntPtr id_abrirGaveta;
		public unsafe void AbrirGaveta ()
		{
			if (id_abrirGaveta == IntPtr.Zero)
				id_abrirGaveta = JNIEnv.GetMethodID (class_ref, "abrirGaveta", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_abrirGaveta);
		}

		static Delegate cb_bmpDisplay_Landroid_graphics_Bitmap_;
#pragma warning disable 0169
		static Delegate GetBmpDisplay_Landroid_graphics_Bitmap_Handler ()
		{
			if (cb_bmpDisplay_Landroid_graphics_Bitmap_ == null)
				cb_bmpDisplay_Landroid_graphics_Bitmap_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_BmpDisplay_Landroid_graphics_Bitmap_);
			return cb_bmpDisplay_Landroid_graphics_Bitmap_;
		}

		static void n_BmpDisplay_Landroid_graphics_Bitmap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Itfast.Tectoy.ITecToyServices> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.BmpDisplay (p0);
		}
#pragma warning restore 0169

		IntPtr id_bmpDisplay_Landroid_graphics_Bitmap_;
		public unsafe void BmpDisplay (global::Android.Graphics.Bitmap p0)
		{
			if (id_bmpDisplay_Landroid_graphics_Bitmap_ == IntPtr.Zero)
				id_bmpDisplay_Landroid_graphics_Bitmap_ = JNIEnv.GetMethodID (class_ref, "bmpDisplay", "(Landroid/graphics/Bitmap;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_bmpDisplay_Landroid_graphics_Bitmap_, __args);
		}

		static Delegate cb_dispositivoNFC;
#pragma warning disable 0169
		static Delegate GetDispositivoNFCHandler ()
		{
			if (cb_dispositivoNFC == null)
				cb_dispositivoNFC = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_DispositivoNFC);
			return cb_dispositivoNFC;
		}

		static IntPtr n_DispositivoNFC (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Itfast.Tectoy.ITecToyServices> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DispositivoNFC ());
		}
#pragma warning restore 0169

		IntPtr id_dispositivoNFC;
		public unsafe global::Android.Nfc.NfcAdapter DispositivoNFC ()
		{
			if (id_dispositivoNFC == IntPtr.Zero)
				id_dispositivoNFC = JNIEnv.GetMethodID (class_ref, "dispositivoNFC", "()Landroid/nfc/NfcAdapter;");
			return global::Java.Lang.Object.GetObject<global::Android.Nfc.NfcAdapter> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_dispositivoNFC), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_escreveDisplay_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetEscreveDisplay_Ljava_lang_String_Handler ()
		{
			if (cb_escreveDisplay_Ljava_lang_String_ == null)
				cb_escreveDisplay_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_EscreveDisplay_Ljava_lang_String_);
			return cb_escreveDisplay_Ljava_lang_String_;
		}

		static void n_EscreveDisplay_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Itfast.Tectoy.ITecToyServices> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.EscreveDisplay (p0);
		}
#pragma warning restore 0169

		IntPtr id_escreveDisplay_Ljava_lang_String_;
		public unsafe void EscreveDisplay (string p0)
		{
			if (id_escreveDisplay_Ljava_lang_String_ == IntPtr.Zero)
				id_escreveDisplay_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "escreveDisplay", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_escreveDisplay_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_escreveDisplay_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetEscreveDisplay_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_escreveDisplay_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_escreveDisplay_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_EscreveDisplay_Ljava_lang_String_Ljava_lang_String_);
			return cb_escreveDisplay_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_EscreveDisplay_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Itfast.Tectoy.ITecToyServices> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.EscreveDisplay (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_escreveDisplay_Ljava_lang_String_Ljava_lang_String_;
		public unsafe void EscreveDisplay (string p0, string p1)
		{
			if (id_escreveDisplay_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_escreveDisplay_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "escreveDisplay", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			IntPtr native_p1 = JNIEnv.NewString ((string)p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_escreveDisplay_Ljava_lang_String_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_gavetaAberta;
#pragma warning disable 0169
		static Delegate GetGavetaAbertaHandler ()
		{
			if (cb_gavetaAberta == null)
				cb_gavetaAberta = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_GavetaAberta);
			return cb_gavetaAberta;
		}

		static bool n_GavetaAberta (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Itfast.Tectoy.ITecToyServices> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GavetaAberta ();
		}
#pragma warning restore 0169

		IntPtr id_gavetaAberta;
		public unsafe bool GavetaAberta ()
		{
			if (id_gavetaAberta == IntPtr.Zero)
				id_gavetaAberta = JNIEnv.GetMethodID (class_ref, "gavetaAberta", "()Z");
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_gavetaAberta);
		}

		static Delegate cb_imprimir_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetImprimir_Ljava_lang_String_Handler ()
		{
			if (cb_imprimir_Ljava_lang_String_ == null)
				cb_imprimir_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_Imprimir_Ljava_lang_String_);
			return cb_imprimir_Ljava_lang_String_;
		}

		static bool n_Imprimir_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Itfast.Tectoy.ITecToyServices> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Imprimir (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_imprimir_Ljava_lang_String_;
		public unsafe bool Imprimir (string p0)
		{
			if (id_imprimir_Ljava_lang_String_ == IntPtr.Zero)
				id_imprimir_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "imprimir", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_imprimir_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_iniciarNFC_Lbr_com_itfast_tectoy_TecToyNfcCallback_Landroid_content_Intent_;
#pragma warning disable 0169
		static Delegate GetIniciarNFC_Lbr_com_itfast_tectoy_TecToyNfcCallback_Landroid_content_Intent_Handler ()
		{
			if (cb_iniciarNFC_Lbr_com_itfast_tectoy_TecToyNfcCallback_Landroid_content_Intent_ == null)
				cb_iniciarNFC_Lbr_com_itfast_tectoy_TecToyNfcCallback_Landroid_content_Intent_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_IniciarNFC_Lbr_com_itfast_tectoy_TecToyNfcCallback_Landroid_content_Intent_);
			return cb_iniciarNFC_Lbr_com_itfast_tectoy_TecToyNfcCallback_Landroid_content_Intent_;
		}

		static void n_IniciarNFC_Lbr_com_itfast_tectoy_TecToyNfcCallback_Landroid_content_Intent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Itfast.Tectoy.ITecToyServices> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::BR.Com.Itfast.Tectoy.ITecToyNfcCallback)global::Java.Lang.Object.GetObject<global::BR.Com.Itfast.Tectoy.ITecToyNfcCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.IniciarNFC (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_iniciarNFC_Lbr_com_itfast_tectoy_TecToyNfcCallback_Landroid_content_Intent_;
		public unsafe void IniciarNFC (global::BR.Com.Itfast.Tectoy.ITecToyNfcCallback p0, global::Android.Content.Intent p1)
		{
			if (id_iniciarNFC_Lbr_com_itfast_tectoy_TecToyNfcCallback_Landroid_content_Intent_ == IntPtr.Zero)
				id_iniciarNFC_Lbr_com_itfast_tectoy_TecToyNfcCallback_Landroid_content_Intent_ = JNIEnv.GetMethodID (class_ref, "iniciarNFC", "(Lbr/com/itfast/tectoy/TecToyNfcCallback;Landroid/content/Intent;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_iniciarNFC_Lbr_com_itfast_tectoy_TecToyNfcCallback_Landroid_content_Intent_, __args);
		}

		static Delegate cb_iniciarScanner_Lbr_com_itfast_tectoy_TecToyScannerCallback_;
#pragma warning disable 0169
		static Delegate GetIniciarScanner_Lbr_com_itfast_tectoy_TecToyScannerCallback_Handler ()
		{
			if (cb_iniciarScanner_Lbr_com_itfast_tectoy_TecToyScannerCallback_ == null)
				cb_iniciarScanner_Lbr_com_itfast_tectoy_TecToyScannerCallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_IniciarScanner_Lbr_com_itfast_tectoy_TecToyScannerCallback_);
			return cb_iniciarScanner_Lbr_com_itfast_tectoy_TecToyScannerCallback_;
		}

		static void n_IniciarScanner_Lbr_com_itfast_tectoy_TecToyScannerCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Itfast.Tectoy.ITecToyServices> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::BR.Com.Itfast.Tectoy.ITecToyScannerCallback)global::Java.Lang.Object.GetObject<global::BR.Com.Itfast.Tectoy.ITecToyScannerCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.IniciarScanner (p0);
		}
#pragma warning restore 0169

		IntPtr id_iniciarScanner_Lbr_com_itfast_tectoy_TecToyScannerCallback_;
		public unsafe void IniciarScanner (global::BR.Com.Itfast.Tectoy.ITecToyScannerCallback p0)
		{
			if (id_iniciarScanner_Lbr_com_itfast_tectoy_TecToyScannerCallback_ == IntPtr.Zero)
				id_iniciarScanner_Lbr_com_itfast_tectoy_TecToyScannerCallback_ = JNIEnv.GetMethodID (class_ref, "iniciarScanner", "(Lbr/com/itfast/tectoy/TecToyScannerCallback;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_iniciarScanner_Lbr_com_itfast_tectoy_TecToyScannerCallback_, __args);
		}

		static Delegate cb_limparDisplay;
#pragma warning disable 0169
		static Delegate GetLimparDisplayHandler ()
		{
			if (cb_limparDisplay == null)
				cb_limparDisplay = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_LimparDisplay);
			return cb_limparDisplay;
		}

		static void n_LimparDisplay (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Itfast.Tectoy.ITecToyServices> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.LimparDisplay ();
		}
#pragma warning restore 0169

		IntPtr id_limparDisplay;
		public unsafe void LimparDisplay ()
		{
			if (id_limparDisplay == IntPtr.Zero)
				id_limparDisplay = JNIEnv.GetMethodID (class_ref, "limparDisplay", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_limparDisplay);
		}

		static Delegate cb_pararScanner;
#pragma warning disable 0169
		static Delegate GetPararScannerHandler ()
		{
			if (cb_pararScanner == null)
				cb_pararScanner = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_PararScanner);
			return cb_pararScanner;
		}

		static void n_PararScanner (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Itfast.Tectoy.ITecToyServices> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PararScanner ();
		}
#pragma warning restore 0169

		IntPtr id_pararScanner;
		public unsafe void PararScanner ()
		{
			if (id_pararScanner == IntPtr.Zero)
				id_pararScanner = JNIEnv.GetMethodID (class_ref, "pararScanner", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_pararScanner);
		}

		static Delegate cb_qrCodeDisplay_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetQrCodeDisplay_Ljava_lang_String_Handler ()
		{
			if (cb_qrCodeDisplay_Ljava_lang_String_ == null)
				cb_qrCodeDisplay_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_QrCodeDisplay_Ljava_lang_String_);
			return cb_qrCodeDisplay_Ljava_lang_String_;
		}

		static void n_QrCodeDisplay_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Itfast.Tectoy.ITecToyServices> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.QrCodeDisplay (p0);
		}
#pragma warning restore 0169

		IntPtr id_qrCodeDisplay_Ljava_lang_String_;
		public unsafe void QrCodeDisplay (string p0)
		{
			if (id_qrCodeDisplay_Ljava_lang_String_ == IntPtr.Zero)
				id_qrCodeDisplay_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "qrCodeDisplay", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_qrCodeDisplay_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_statusImpressora;
#pragma warning disable 0169
		static Delegate GetStatusImpressoraHandler ()
		{
			if (cb_statusImpressora == null)
				cb_statusImpressora = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_StatusImpressora);
			return cb_statusImpressora;
		}

		static IntPtr n_StatusImpressora (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Itfast.Tectoy.ITecToyServices> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.StatusImpressora ());
		}
#pragma warning restore 0169

		IntPtr id_statusImpressora;
		public unsafe global::BR.Com.Itfast.Tectoy.StatusImpressora StatusImpressora ()
		{
			if (id_statusImpressora == IntPtr.Zero)
				id_statusImpressora = JNIEnv.GetMethodID (class_ref, "statusImpressora", "()Lbr/com/itfast/tectoy/StatusImpressora;");
			return global::Java.Lang.Object.GetObject<global::BR.Com.Itfast.Tectoy.StatusImpressora> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_statusImpressora), JniHandleOwnership.TransferLocalRef);
		}

	}
}
