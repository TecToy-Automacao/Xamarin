using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace BR.Com.Itfast.Tectoy {

	// Metadata.xml XPath class reference: path="/api/package[@name='br.com.itfast.tectoy']/class[@name='TecToy']"
	[global::Android.Runtime.Register ("br/com/itfast/tectoy/TecToy", DoNotGenerateAcw=true)]
	public partial class TecToy : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("br/com/itfast/tectoy/TecToy", typeof (TecToy));

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

		protected TecToy (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='br.com.itfast.tectoy']/class[@name='TecToy']/constructor[@name='TecToy' and count(parameter)=2 and parameter[1][@type='br.com.itfast.tectoy.Dispositivo'] and parameter[2][@type='android.content.Context']]"
		[Register (".ctor", "(Lbr/com/itfast/tectoy/Dispositivo;Landroid/content/Context;)V", "")]
		public unsafe TecToy (global::BR.Com.Itfast.Tectoy.Dispositivo dispositivo, global::Android.Content.Context context) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lbr/com/itfast/tectoy/Dispositivo;Landroid/content/Context;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((dispositivo == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dispositivo).Handle);
				__args [1] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (dispositivo);
				global::System.GC.KeepAlive (context);
			}
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
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Itfast.Tectoy.TecToy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AbrirGaveta ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.itfast.tectoy']/class[@name='TecToy']/method[@name='abrirGaveta' and count(parameter)=0]"
		[Register ("abrirGaveta", "()V", "GetAbrirGavetaHandler")]
		public virtual unsafe void AbrirGaveta ()
		{
			const string __id = "abrirGaveta.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_bmpDisplay_Landroid_graphics_Bitmap_;
#pragma warning disable 0169
		static Delegate GetBmpDisplay_Landroid_graphics_Bitmap_Handler ()
		{
			if (cb_bmpDisplay_Landroid_graphics_Bitmap_ == null)
				cb_bmpDisplay_Landroid_graphics_Bitmap_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_BmpDisplay_Landroid_graphics_Bitmap_);
			return cb_bmpDisplay_Landroid_graphics_Bitmap_;
		}

		static void n_BmpDisplay_Landroid_graphics_Bitmap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_bmp)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Itfast.Tectoy.TecToy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var bmp = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_bmp, JniHandleOwnership.DoNotTransfer);
			__this.BmpDisplay (bmp);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.itfast.tectoy']/class[@name='TecToy']/method[@name='bmpDisplay' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap']]"
		[Register ("bmpDisplay", "(Landroid/graphics/Bitmap;)V", "GetBmpDisplay_Landroid_graphics_Bitmap_Handler")]
		public virtual unsafe void BmpDisplay (global::Android.Graphics.Bitmap bmp)
		{
			const string __id = "bmpDisplay.(Landroid/graphics/Bitmap;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((bmp == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bmp).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (bmp);
			}
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
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Itfast.Tectoy.TecToy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DispositivoNFC ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.itfast.tectoy']/class[@name='TecToy']/method[@name='dispositivoNFC' and count(parameter)=0]"
		[Register ("dispositivoNFC", "()Landroid/nfc/NfcAdapter;", "GetDispositivoNFCHandler")]
		public virtual unsafe global::Android.Nfc.NfcAdapter DispositivoNFC ()
		{
			const string __id = "dispositivoNFC.()Landroid/nfc/NfcAdapter;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Android.Nfc.NfcAdapter> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_escreveDisplay_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetEscreveDisplay_Ljava_lang_String_Handler ()
		{
			if (cb_escreveDisplay_Ljava_lang_String_ == null)
				cb_escreveDisplay_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_EscreveDisplay_Ljava_lang_String_);
			return cb_escreveDisplay_Ljava_lang_String_;
		}

		static void n_EscreveDisplay_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_strTexto)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Itfast.Tectoy.TecToy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var strTexto = JNIEnv.GetString (native_strTexto, JniHandleOwnership.DoNotTransfer);
			__this.EscreveDisplay (strTexto);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.itfast.tectoy']/class[@name='TecToy']/method[@name='escreveDisplay' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("escreveDisplay", "(Ljava/lang/String;)V", "GetEscreveDisplay_Ljava_lang_String_Handler")]
		public virtual unsafe void EscreveDisplay (string strTexto)
		{
			const string __id = "escreveDisplay.(Ljava/lang/String;)V";
			IntPtr native_strTexto = JNIEnv.NewString ((string)strTexto);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_strTexto);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_strTexto);
			}
		}

		static Delegate cb_escreveDisplay_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetEscreveDisplay_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_escreveDisplay_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_escreveDisplay_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_EscreveDisplay_Ljava_lang_String_Ljava_lang_String_);
			return cb_escreveDisplay_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_EscreveDisplay_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_strLinha1, IntPtr native_strLinha2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Itfast.Tectoy.TecToy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var strLinha1 = JNIEnv.GetString (native_strLinha1, JniHandleOwnership.DoNotTransfer);
			var strLinha2 = JNIEnv.GetString (native_strLinha2, JniHandleOwnership.DoNotTransfer);
			__this.EscreveDisplay (strLinha1, strLinha2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.itfast.tectoy']/class[@name='TecToy']/method[@name='escreveDisplay' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("escreveDisplay", "(Ljava/lang/String;Ljava/lang/String;)V", "GetEscreveDisplay_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void EscreveDisplay (string strLinha1, string strLinha2)
		{
			const string __id = "escreveDisplay.(Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_strLinha1 = JNIEnv.NewString ((string)strLinha1);
			IntPtr native_strLinha2 = JNIEnv.NewString ((string)strLinha2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_strLinha1);
				__args [1] = new JniArgumentValue (native_strLinha2);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_strLinha1);
				JNIEnv.DeleteLocalRef (native_strLinha2);
			}
		}

		static Delegate cb_escreverNFC_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetEscreverNFC_Ljava_lang_String_Handler ()
		{
			if (cb_escreverNFC_Ljava_lang_String_ == null)
				cb_escreverNFC_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_EscreverNFC_Ljava_lang_String_);
			return cb_escreverNFC_Ljava_lang_String_;
		}

		static void n_EscreverNFC_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_texto)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Itfast.Tectoy.TecToy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var texto = JNIEnv.GetString (native_texto, JniHandleOwnership.DoNotTransfer);
			__this.EscreverNFC (texto);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.itfast.tectoy']/class[@name='TecToy']/method[@name='escreverNFC' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("escreverNFC", "(Ljava/lang/String;)V", "GetEscreverNFC_Ljava_lang_String_Handler")]
		public virtual unsafe void EscreverNFC (string texto)
		{
			const string __id = "escreverNFC.(Ljava/lang/String;)V";
			IntPtr native_texto = JNIEnv.NewString ((string)texto);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_texto);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_texto);
			}
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
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Itfast.Tectoy.TecToy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GavetaAberta ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.itfast.tectoy']/class[@name='TecToy']/method[@name='gavetaAberta' and count(parameter)=0]"
		[Register ("gavetaAberta", "()Z", "GetGavetaAbertaHandler")]
		public virtual unsafe bool GavetaAberta ()
		{
			const string __id = "gavetaAberta.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_imprimir_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetImprimir_Ljava_lang_String_Handler ()
		{
			if (cb_imprimir_Ljava_lang_String_ == null)
				cb_imprimir_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Imprimir_Ljava_lang_String_);
			return cb_imprimir_Ljava_lang_String_;
		}

		static void n_Imprimir_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_strTexto)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Itfast.Tectoy.TecToy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var strTexto = JNIEnv.GetString (native_strTexto, JniHandleOwnership.DoNotTransfer);
			__this.Imprimir (strTexto);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.itfast.tectoy']/class[@name='TecToy']/method[@name='imprimir' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("imprimir", "(Ljava/lang/String;)V", "GetImprimir_Ljava_lang_String_Handler")]
		public virtual unsafe void Imprimir (string strTexto)
		{
			const string __id = "imprimir.(Ljava/lang/String;)V";
			IntPtr native_strTexto = JNIEnv.NewString ((string)strTexto);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_strTexto);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_strTexto);
			}
		}

		static Delegate cb_iniciarNFC_Landroid_content_Intent_Lbr_com_itfast_tectoy_TecToyNfcCallback_;
#pragma warning disable 0169
		static Delegate GetIniciarNFC_Landroid_content_Intent_Lbr_com_itfast_tectoy_TecToyNfcCallback_Handler ()
		{
			if (cb_iniciarNFC_Landroid_content_Intent_Lbr_com_itfast_tectoy_TecToyNfcCallback_ == null)
				cb_iniciarNFC_Landroid_content_Intent_Lbr_com_itfast_tectoy_TecToyNfcCallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_IniciarNFC_Landroid_content_Intent_Lbr_com_itfast_tectoy_TecToyNfcCallback_);
			return cb_iniciarNFC_Landroid_content_Intent_Lbr_com_itfast_tectoy_TecToyNfcCallback_;
		}

		static void n_IniciarNFC_Landroid_content_Intent_Lbr_com_itfast_tectoy_TecToyNfcCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_intent, IntPtr native_nfcCallback)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Itfast.Tectoy.TecToy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var intent = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_intent, JniHandleOwnership.DoNotTransfer);
			var nfcCallback = (global::BR.Com.Itfast.Tectoy.ITecToyNfcCallback)global::Java.Lang.Object.GetObject<global::BR.Com.Itfast.Tectoy.ITecToyNfcCallback> (native_nfcCallback, JniHandleOwnership.DoNotTransfer);
			__this.IniciarNFC (intent, nfcCallback);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.itfast.tectoy']/class[@name='TecToy']/method[@name='iniciarNFC' and count(parameter)=2 and parameter[1][@type='android.content.Intent'] and parameter[2][@type='br.com.itfast.tectoy.TecToyNfcCallback']]"
		[Register ("iniciarNFC", "(Landroid/content/Intent;Lbr/com/itfast/tectoy/TecToyNfcCallback;)V", "GetIniciarNFC_Landroid_content_Intent_Lbr_com_itfast_tectoy_TecToyNfcCallback_Handler")]
		public virtual unsafe void IniciarNFC (global::Android.Content.Intent intent, global::BR.Com.Itfast.Tectoy.ITecToyNfcCallback nfcCallback)
		{
			const string __id = "iniciarNFC.(Landroid/content/Intent;Lbr/com/itfast/tectoy/TecToyNfcCallback;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((intent == null) ? IntPtr.Zero : ((global::Java.Lang.Object) intent).Handle);
				__args [1] = new JniArgumentValue ((nfcCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) nfcCallback).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (intent);
				global::System.GC.KeepAlive (nfcCallback);
			}
		}

		static Delegate cb_iniciarScanner_Lbr_com_itfast_tectoy_TecToyScannerCallback_;
#pragma warning disable 0169
		static Delegate GetIniciarScanner_Lbr_com_itfast_tectoy_TecToyScannerCallback_Handler ()
		{
			if (cb_iniciarScanner_Lbr_com_itfast_tectoy_TecToyScannerCallback_ == null)
				cb_iniciarScanner_Lbr_com_itfast_tectoy_TecToyScannerCallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_IniciarScanner_Lbr_com_itfast_tectoy_TecToyScannerCallback_);
			return cb_iniciarScanner_Lbr_com_itfast_tectoy_TecToyScannerCallback_;
		}

		static void n_IniciarScanner_Lbr_com_itfast_tectoy_TecToyScannerCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native__callback)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Itfast.Tectoy.TecToy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var @callback = (global::BR.Com.Itfast.Tectoy.ITecToyScannerCallback)global::Java.Lang.Object.GetObject<global::BR.Com.Itfast.Tectoy.ITecToyScannerCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.IniciarScanner (@callback);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.itfast.tectoy']/class[@name='TecToy']/method[@name='iniciarScanner' and count(parameter)=1 and parameter[1][@type='br.com.itfast.tectoy.TecToyScannerCallback']]"
		[Register ("iniciarScanner", "(Lbr/com/itfast/tectoy/TecToyScannerCallback;)V", "GetIniciarScanner_Lbr_com_itfast_tectoy_TecToyScannerCallback_Handler")]
		public virtual unsafe void IniciarScanner (global::BR.Com.Itfast.Tectoy.ITecToyScannerCallback @callback)
		{
			const string __id = "iniciarScanner.(Lbr/com/itfast/tectoy/TecToyScannerCallback;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (@callback);
			}
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
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Itfast.Tectoy.TecToy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.LimparDisplay ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.itfast.tectoy']/class[@name='TecToy']/method[@name='limparDisplay' and count(parameter)=0]"
		[Register ("limparDisplay", "()V", "GetLimparDisplayHandler")]
		public virtual unsafe void LimparDisplay ()
		{
			const string __id = "limparDisplay.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_onNewIntentNFC_Landroid_content_Intent_;
#pragma warning disable 0169
		static Delegate GetOnNewIntentNFC_Landroid_content_Intent_Handler ()
		{
			if (cb_onNewIntentNFC_Landroid_content_Intent_ == null)
				cb_onNewIntentNFC_Landroid_content_Intent_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnNewIntentNFC_Landroid_content_Intent_);
			return cb_onNewIntentNFC_Landroid_content_Intent_;
		}

		static void n_OnNewIntentNFC_Landroid_content_Intent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_intent)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Itfast.Tectoy.TecToy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var intent = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_intent, JniHandleOwnership.DoNotTransfer);
			__this.OnNewIntentNFC (intent);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.itfast.tectoy']/class[@name='TecToy']/method[@name='onNewIntentNFC' and count(parameter)=1 and parameter[1][@type='android.content.Intent']]"
		[Register ("onNewIntentNFC", "(Landroid/content/Intent;)V", "GetOnNewIntentNFC_Landroid_content_Intent_Handler")]
		public virtual unsafe void OnNewIntentNFC (global::Android.Content.Intent intent)
		{
			const string __id = "onNewIntentNFC.(Landroid/content/Intent;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((intent == null) ? IntPtr.Zero : ((global::Java.Lang.Object) intent).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (intent);
			}
		}

		static Delegate cb_onPauseNFC_Landroid_app_Activity_;
#pragma warning disable 0169
		static Delegate GetOnPauseNFC_Landroid_app_Activity_Handler ()
		{
			if (cb_onPauseNFC_Landroid_app_Activity_ == null)
				cb_onPauseNFC_Landroid_app_Activity_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnPauseNFC_Landroid_app_Activity_);
			return cb_onPauseNFC_Landroid_app_Activity_;
		}

		static void n_OnPauseNFC_Landroid_app_Activity_ (IntPtr jnienv, IntPtr native__this, IntPtr native_activity)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Itfast.Tectoy.TecToy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var activity = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_activity, JniHandleOwnership.DoNotTransfer);
			__this.OnPauseNFC (activity);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.itfast.tectoy']/class[@name='TecToy']/method[@name='onPauseNFC' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("onPauseNFC", "(Landroid/app/Activity;)V", "GetOnPauseNFC_Landroid_app_Activity_Handler")]
		public virtual unsafe void OnPauseNFC (global::Android.App.Activity activity)
		{
			const string __id = "onPauseNFC.(Landroid/app/Activity;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((activity == null) ? IntPtr.Zero : ((global::Java.Lang.Object) activity).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (activity);
			}
		}

		static Delegate cb_onResumeNFC_Landroid_app_Activity_Landroid_app_PendingIntent_;
#pragma warning disable 0169
		static Delegate GetOnResumeNFC_Landroid_app_Activity_Landroid_app_PendingIntent_Handler ()
		{
			if (cb_onResumeNFC_Landroid_app_Activity_Landroid_app_PendingIntent_ == null)
				cb_onResumeNFC_Landroid_app_Activity_Landroid_app_PendingIntent_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_OnResumeNFC_Landroid_app_Activity_Landroid_app_PendingIntent_);
			return cb_onResumeNFC_Landroid_app_Activity_Landroid_app_PendingIntent_;
		}

		static void n_OnResumeNFC_Landroid_app_Activity_Landroid_app_PendingIntent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_activity, IntPtr native_pendingIntent)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Itfast.Tectoy.TecToy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var activity = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_activity, JniHandleOwnership.DoNotTransfer);
			var pendingIntent = global::Java.Lang.Object.GetObject<global::Android.App.PendingIntent> (native_pendingIntent, JniHandleOwnership.DoNotTransfer);
			__this.OnResumeNFC (activity, pendingIntent);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.itfast.tectoy']/class[@name='TecToy']/method[@name='onResumeNFC' and count(parameter)=2 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='android.app.PendingIntent']]"
		[Register ("onResumeNFC", "(Landroid/app/Activity;Landroid/app/PendingIntent;)V", "GetOnResumeNFC_Landroid_app_Activity_Landroid_app_PendingIntent_Handler")]
		public virtual unsafe void OnResumeNFC (global::Android.App.Activity activity, global::Android.App.PendingIntent pendingIntent)
		{
			const string __id = "onResumeNFC.(Landroid/app/Activity;Landroid/app/PendingIntent;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((activity == null) ? IntPtr.Zero : ((global::Java.Lang.Object) activity).Handle);
				__args [1] = new JniArgumentValue ((pendingIntent == null) ? IntPtr.Zero : ((global::Java.Lang.Object) pendingIntent).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (activity);
				global::System.GC.KeepAlive (pendingIntent);
			}
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
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Itfast.Tectoy.TecToy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PararScanner ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.itfast.tectoy']/class[@name='TecToy']/method[@name='pararScanner' and count(parameter)=0]"
		[Register ("pararScanner", "()V", "GetPararScannerHandler")]
		public virtual unsafe void PararScanner ()
		{
			const string __id = "pararScanner.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_qrCodeDisplay_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetQrCodeDisplay_Ljava_lang_String_Handler ()
		{
			if (cb_qrCodeDisplay_Ljava_lang_String_ == null)
				cb_qrCodeDisplay_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_QrCodeDisplay_Ljava_lang_String_);
			return cb_qrCodeDisplay_Ljava_lang_String_;
		}

		static void n_QrCodeDisplay_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_strConteudo)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Itfast.Tectoy.TecToy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var strConteudo = JNIEnv.GetString (native_strConteudo, JniHandleOwnership.DoNotTransfer);
			__this.QrCodeDisplay (strConteudo);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.itfast.tectoy']/class[@name='TecToy']/method[@name='qrCodeDisplay' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("qrCodeDisplay", "(Ljava/lang/String;)V", "GetQrCodeDisplay_Ljava_lang_String_Handler")]
		public virtual unsafe void QrCodeDisplay (string strConteudo)
		{
			const string __id = "qrCodeDisplay.(Ljava/lang/String;)V";
			IntPtr native_strConteudo = JNIEnv.NewString ((string)strConteudo);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_strConteudo);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_strConteudo);
			}
		}

	}
}
