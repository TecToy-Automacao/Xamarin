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

namespace BR.Com.Daruma.Framework.Mobile.Sat.Impostos {

	// Metadata.xml XPath class reference: path="/api/package[@name='br.com.daruma.framework.mobile.sat.impostos']/class[@name='Cofinsqtde']"
	[global::Android.Runtime.Register ("br/com/daruma/framework/mobile/sat/impostos/Cofinsqtde", DoNotGenerateAcw=true)]
	public partial class Cofinsqtde : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("br/com/daruma/framework/mobile/sat/impostos/Cofinsqtde", typeof (Cofinsqtde));

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

		protected Cofinsqtde (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='br.com.daruma.framework.mobile.sat.impostos']/class[@name='Cofinsqtde']/constructor[@name='Cofinsqtde' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Cofinsqtde () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='br.com.daruma.framework.mobile.sat.impostos']/class[@name='Cofinsqtde']/constructor[@name='Cofinsqtde' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register (".ctor", "(Z)V", "")]
		public unsafe Cofinsqtde (bool p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Z)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='br.com.daruma.framework.mobile.sat.impostos']/class[@name='Cofinsqtde']/constructor[@name='Cofinsqtde' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe Cofinsqtde (string p0, string p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			IntPtr native_p1 = JNIEnv.NewString ((string)p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_getCST;
#pragma warning disable 0169
		static Delegate GetGetCSTHandler ()
		{
			if (cb_getCST == null)
				cb_getCST = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetCST));
			return cb_getCST;
		}

		static IntPtr n_GetCST (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Daruma.Framework.Mobile.Sat.Impostos.Cofinsqtde> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CST);
		}
#pragma warning restore 0169

		static Delegate cb_setCST_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetCST_Ljava_lang_String_Handler ()
		{
			if (cb_setCST_Ljava_lang_String_ == null)
				cb_setCST_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_SetCST_Ljava_lang_String_));
			return cb_setCST_Ljava_lang_String_;
		}

		static void n_SetCST_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Daruma.Framework.Mobile.Sat.Impostos.Cofinsqtde> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CST = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string CST {
			// Metadata.xml XPath method reference: path="/api/package[@name='br.com.daruma.framework.mobile.sat.impostos']/class[@name='Cofinsqtde']/method[@name='getCST' and count(parameter)=0]"
			[Register ("getCST", "()Ljava/lang/String;", "GetGetCSTHandler")]
			get {
				const string __id = "getCST.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='br.com.daruma.framework.mobile.sat.impostos']/class[@name='Cofinsqtde']/method[@name='setCST' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setCST", "(Ljava/lang/String;)V", "GetSetCST_Ljava_lang_String_Handler")]
			set {
				const string __id = "setCST.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_completaDadosImposto_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetCompletaDadosImposto_Ljava_lang_String_Handler ()
		{
			if (cb_completaDadosImposto_Ljava_lang_String_ == null)
				cb_completaDadosImposto_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_CompletaDadosImposto_Ljava_lang_String_));
			return cb_completaDadosImposto_Ljava_lang_String_;
		}

		static void n_CompletaDadosImposto_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Daruma.Framework.Mobile.Sat.Impostos.Cofinsqtde> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CompletaDadosImposto (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.daruma.framework.mobile.sat.impostos']/class[@name='Cofinsqtde']/method[@name='completaDadosImposto' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("completaDadosImposto", "(Ljava/lang/String;)V", "GetCompletaDadosImposto_Ljava_lang_String_Handler")]
		public virtual unsafe void CompletaDadosImposto (string p0)
		{
			const string __id = "completaDadosImposto.(Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_completaXml;
#pragma warning disable 0169
		static Delegate GetCompletaXmlHandler ()
		{
			if (cb_completaXml == null)
				cb_completaXml = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_CompletaXml));
			return cb_completaXml;
		}

		static void n_CompletaXml (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Daruma.Framework.Mobile.Sat.Impostos.Cofinsqtde> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CompletaXml ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.daruma.framework.mobile.sat.impostos']/class[@name='Cofinsqtde']/method[@name='completaXml' and count(parameter)=0]"
		[Register ("completaXml", "()V", "GetCompletaXmlHandler")]
		public virtual unsafe void CompletaXml ()
		{
			const string __id = "completaXml.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_getqBCProd;
#pragma warning disable 0169
		static Delegate GetGetqBCProdHandler ()
		{
			if (cb_getqBCProd == null)
				cb_getqBCProd = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetqBCProd));
			return cb_getqBCProd;
		}

		static IntPtr n_GetqBCProd (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Daruma.Framework.Mobile.Sat.Impostos.Cofinsqtde> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.GetqBCProd ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.daruma.framework.mobile.sat.impostos']/class[@name='Cofinsqtde']/method[@name='getqBCProd' and count(parameter)=0]"
		[Register ("getqBCProd", "()Ljava/lang/String;", "GetGetqBCProdHandler")]
		public virtual unsafe string GetqBCProd ()
		{
			const string __id = "getqBCProd.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getvAliqProd;
#pragma warning disable 0169
		static Delegate GetGetvAliqProdHandler ()
		{
			if (cb_getvAliqProd == null)
				cb_getvAliqProd = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetvAliqProd));
			return cb_getvAliqProd;
		}

		static IntPtr n_GetvAliqProd (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Daruma.Framework.Mobile.Sat.Impostos.Cofinsqtde> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.GetvAliqProd ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.daruma.framework.mobile.sat.impostos']/class[@name='Cofinsqtde']/method[@name='getvAliqProd' and count(parameter)=0]"
		[Register ("getvAliqProd", "()Ljava/lang/String;", "GetGetvAliqProdHandler")]
		public virtual unsafe string GetvAliqProd ()
		{
			const string __id = "getvAliqProd.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setqBCProd_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetqBCProd_Ljava_lang_String_Handler ()
		{
			if (cb_setqBCProd_Ljava_lang_String_ == null)
				cb_setqBCProd_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_SetqBCProd_Ljava_lang_String_));
			return cb_setqBCProd_Ljava_lang_String_;
		}

		static void n_SetqBCProd_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Daruma.Framework.Mobile.Sat.Impostos.Cofinsqtde> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetqBCProd (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.daruma.framework.mobile.sat.impostos']/class[@name='Cofinsqtde']/method[@name='setqBCProd' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setqBCProd", "(Ljava/lang/String;)V", "GetSetqBCProd_Ljava_lang_String_Handler")]
		public virtual unsafe void SetqBCProd (string p0)
		{
			const string __id = "setqBCProd.(Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setvAliqProd_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetvAliqProd_Ljava_lang_String_Handler ()
		{
			if (cb_setvAliqProd_Ljava_lang_String_ == null)
				cb_setvAliqProd_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_SetvAliqProd_Ljava_lang_String_));
			return cb_setvAliqProd_Ljava_lang_String_;
		}

		static void n_SetvAliqProd_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Daruma.Framework.Mobile.Sat.Impostos.Cofinsqtde> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetvAliqProd (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.daruma.framework.mobile.sat.impostos']/class[@name='Cofinsqtde']/method[@name='setvAliqProd' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setvAliqProd", "(Ljava/lang/String;)V", "GetSetvAliqProd_Ljava_lang_String_Handler")]
		public virtual unsafe void SetvAliqProd (string p0)
		{
			const string __id = "setvAliqProd.(Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}