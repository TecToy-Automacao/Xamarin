//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

#nullable restore
using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace BR.Com.Daruma.Framework.Mobile.Gne.Sat {

	// Metadata.xml XPath class reference: path="/api/package[@name='br.com.daruma.framework.mobile.gne.sat']/class[@name='Dimep']"
	[global::Android.Runtime.Register ("br/com/daruma/framework/mobile/gne/sat/Dimep", DoNotGenerateAcw=true)]
	public partial class Dimep : global::BR.Com.Daruma.Framework.Mobile.Gne.Sat.Interface_Sat {
		static readonly JniPeerMembers _members = new XAPeerMembers ("br/com/daruma/framework/mobile/gne/sat/Dimep", typeof (Dimep));

		internal static new IntPtr class_ref {
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

		protected Dimep (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		static Delegate cb_getCodAvisoErro;
#pragma warning disable 0169
		static Delegate GetGetCodAvisoErroHandler ()
		{
			if (cb_getCodAvisoErro == null)
				cb_getCodAvisoErro = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetCodAvisoErro));
			return cb_getCodAvisoErro;
		}

		static IntPtr n_GetCodAvisoErro (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Daruma.Framework.Mobile.Gne.Sat.Dimep> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CodAvisoErro);
		}
#pragma warning restore 0169

		public override unsafe string CodAvisoErro {
			// Metadata.xml XPath method reference: path="/api/package[@name='br.com.daruma.framework.mobile.gne.sat']/class[@name='Dimep']/method[@name='getCodAvisoErro' and count(parameter)=0]"
			[Register ("getCodAvisoErro", "()Ljava/lang/String;", "GetGetCodAvisoErroHandler")]
			get {
				const string __id = "getCodAvisoErro.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getMsgAvisoErro;
#pragma warning disable 0169
		static Delegate GetGetMsgAvisoErroHandler ()
		{
			if (cb_getMsgAvisoErro == null)
				cb_getMsgAvisoErro = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetMsgAvisoErro));
			return cb_getMsgAvisoErro;
		}

		static IntPtr n_GetMsgAvisoErro (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Daruma.Framework.Mobile.Gne.Sat.Dimep> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.MsgAvisoErro);
		}
#pragma warning restore 0169

		public override unsafe string MsgAvisoErro {
			// Metadata.xml XPath method reference: path="/api/package[@name='br.com.daruma.framework.mobile.gne.sat']/class[@name='Dimep']/method[@name='getMsgAvisoErro' and count(parameter)=0]"
			[Register ("getMsgAvisoErro", "()Ljava/lang/String;", "GetGetMsgAvisoErroHandler")]
			get {
				const string __id = "getMsgAvisoErro.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_ConsultarStatusOperacional;
#pragma warning disable 0169
		static Delegate GetConsultarStatusOperacionalHandler ()
		{
			if (cb_ConsultarStatusOperacional == null)
				cb_ConsultarStatusOperacional = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_ConsultarStatusOperacional));
			return cb_ConsultarStatusOperacional;
		}

		static int n_ConsultarStatusOperacional (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Daruma.Framework.Mobile.Gne.Sat.Dimep> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ConsultarStatusOperacional ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.daruma.framework.mobile.gne.sat']/class[@name='Dimep']/method[@name='ConsultarStatusOperacional' and count(parameter)=0]"
		[Register ("ConsultarStatusOperacional", "()I", "GetConsultarStatusOperacionalHandler")]
		public override unsafe int ConsultarStatusOperacional ()
		{
			const string __id = "ConsultarStatusOperacional.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_ConsultarStatusOperacionalStr;
#pragma warning disable 0169
		static Delegate GetConsultarStatusOperacionalStrHandler ()
		{
			if (cb_ConsultarStatusOperacionalStr == null)
				cb_ConsultarStatusOperacionalStr = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_ConsultarStatusOperacionalStr));
			return cb_ConsultarStatusOperacionalStr;
		}

		static IntPtr n_ConsultarStatusOperacionalStr (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Daruma.Framework.Mobile.Gne.Sat.Dimep> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ConsultarStatusOperacionalStr ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.daruma.framework.mobile.gne.sat']/class[@name='Dimep']/method[@name='ConsultarStatusOperacionalStr' and count(parameter)=0]"
		[Register ("ConsultarStatusOperacionalStr", "()Ljava/lang/String;", "GetConsultarStatusOperacionalStrHandler")]
		public override unsafe string ConsultarStatusOperacionalStr ()
		{
			const string __id = "ConsultarStatusOperacionalStr.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_abreComunicacao_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetAbreComunicacao_Landroid_content_Context_Handler ()
		{
			if (cb_abreComunicacao_Landroid_content_Context_ == null)
				cb_abreComunicacao_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_Z (n_AbreComunicacao_Landroid_content_Context_));
			return cb_abreComunicacao_Landroid_content_Context_;
		}

		static bool n_AbreComunicacao_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Daruma.Framework.Mobile.Gne.Sat.Dimep> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.AbreComunicacao (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.daruma.framework.mobile.gne.sat']/class[@name='Dimep']/method[@name='abreComunicacao' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("abreComunicacao", "(Landroid/content/Context;)Z", "GetAbreComunicacao_Landroid_content_Context_Handler")]
		public override unsafe bool AbreComunicacao (global::Android.Content.Context p0)
		{
			const string __id = "abreComunicacao.(Landroid/content/Context;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate cb_cancelaUltimaVenda_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetCancelaUltimaVenda_Ljava_lang_String_Handler ()
		{
			if (cb_cancelaUltimaVenda_Ljava_lang_String_ == null)
				cb_cancelaUltimaVenda_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_L (n_CancelaUltimaVenda_Ljava_lang_String_));
			return cb_cancelaUltimaVenda_Ljava_lang_String_;
		}

		static IntPtr n_CancelaUltimaVenda_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Daruma.Framework.Mobile.Gne.Sat.Dimep> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.CancelaUltimaVenda (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.daruma.framework.mobile.gne.sat']/class[@name='Dimep']/method[@name='cancelaUltimaVenda' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("cancelaUltimaVenda", "(Ljava/lang/String;)Ljava/lang/String;", "GetCancelaUltimaVenda_Ljava_lang_String_Handler")]
		public override unsafe string CancelaUltimaVenda (string p0)
		{
			const string __id = "cancelaUltimaVenda.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_enviaDados_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetEnviaDados_Ljava_lang_String_IHandler ()
		{
			if (cb_enviaDados_Ljava_lang_String_I == null)
				cb_enviaDados_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLI_L (n_EnviaDados_Ljava_lang_String_I));
			return cb_enviaDados_Ljava_lang_String_I;
		}

		static IntPtr n_EnviaDados_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Daruma.Framework.Mobile.Gne.Sat.Dimep> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.EnviaDados (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.daruma.framework.mobile.gne.sat']/class[@name='Dimep']/method[@name='enviaDados' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("enviaDados", "(Ljava/lang/String;I)Ljava/lang/String;", "GetEnviaDados_Ljava_lang_String_IHandler")]
		public override unsafe string EnviaDados (string p0, int p1)
		{
			const string __id = "enviaDados.(Ljava/lang/String;I)Ljava/lang/String;";
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}