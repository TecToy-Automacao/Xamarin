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

namespace BR.Com.Daruma.Framework.Mobile.Gne.Nfce.Xml.Classes {

	// Metadata.xml XPath class reference: path="/api/package[@name='br.com.daruma.framework.mobile.gne.nfce.xml.classes']/class[@name='DF']"
	[global::Android.Runtime.Register ("br/com/daruma/framework/mobile/gne/nfce/xml/classes/DF", DoNotGenerateAcw=true)]
	public partial class DF : global::BR.Com.Daruma.Framework.Mobile.Gne.Tags {
		static readonly JniPeerMembers _members = new XAPeerMembers ("br/com/daruma/framework/mobile/gne/nfce/xml/classes/DF", typeof (DF));

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

		protected DF (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='br.com.daruma.framework.mobile.gne.nfce.xml.classes']/class[@name='DF']/constructor[@name='DF' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DF () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_getChaveConHomoDF;
#pragma warning disable 0169
		static Delegate GetGetChaveConHomoDFHandler ()
		{
			if (cb_getChaveConHomoDF == null)
				cb_getChaveConHomoDF = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetChaveConHomoDF));
			return cb_getChaveConHomoDF;
		}

		static IntPtr n_GetChaveConHomoDF (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Daruma.Framework.Mobile.Gne.Nfce.Xml.Classes.DF> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ChaveConHomoDF);
		}
#pragma warning restore 0169

		static Delegate cb_setChaveConHomoDF_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetChaveConHomoDF_Ljava_lang_String_Handler ()
		{
			if (cb_setChaveConHomoDF_Ljava_lang_String_ == null)
				cb_setChaveConHomoDF_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_SetChaveConHomoDF_Ljava_lang_String_));
			return cb_setChaveConHomoDF_Ljava_lang_String_;
		}

		static void n_SetChaveConHomoDF_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Daruma.Framework.Mobile.Gne.Nfce.Xml.Classes.DF> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ChaveConHomoDF = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string ChaveConHomoDF {
			// Metadata.xml XPath method reference: path="/api/package[@name='br.com.daruma.framework.mobile.gne.nfce.xml.classes']/class[@name='DF']/method[@name='getChaveConHomoDF' and count(parameter)=0]"
			[Register ("getChaveConHomoDF", "()Ljava/lang/String;", "GetGetChaveConHomoDFHandler")]
			get {
				const string __id = "getChaveConHomoDF.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='br.com.daruma.framework.mobile.gne.nfce.xml.classes']/class[@name='DF']/method[@name='setChaveConHomoDF' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setChaveConHomoDF", "(Ljava/lang/String;)V", "GetSetChaveConHomoDF_Ljava_lang_String_Handler")]
			set {
				const string __id = "setChaveConHomoDF.(Ljava/lang/String;)V";
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

		static Delegate cb_getChaveConProdDF;
#pragma warning disable 0169
		static Delegate GetGetChaveConProdDFHandler ()
		{
			if (cb_getChaveConProdDF == null)
				cb_getChaveConProdDF = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetChaveConProdDF));
			return cb_getChaveConProdDF;
		}

		static IntPtr n_GetChaveConProdDF (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Daruma.Framework.Mobile.Gne.Nfce.Xml.Classes.DF> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ChaveConProdDF);
		}
#pragma warning restore 0169

		static Delegate cb_setChaveConProdDF_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetChaveConProdDF_Ljava_lang_String_Handler ()
		{
			if (cb_setChaveConProdDF_Ljava_lang_String_ == null)
				cb_setChaveConProdDF_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_SetChaveConProdDF_Ljava_lang_String_));
			return cb_setChaveConProdDF_Ljava_lang_String_;
		}

		static void n_SetChaveConProdDF_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Daruma.Framework.Mobile.Gne.Nfce.Xml.Classes.DF> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ChaveConProdDF = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string ChaveConProdDF {
			// Metadata.xml XPath method reference: path="/api/package[@name='br.com.daruma.framework.mobile.gne.nfce.xml.classes']/class[@name='DF']/method[@name='getChaveConProdDF' and count(parameter)=0]"
			[Register ("getChaveConProdDF", "()Ljava/lang/String;", "GetGetChaveConProdDFHandler")]
			get {
				const string __id = "getChaveConProdDF.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='br.com.daruma.framework.mobile.gne.nfce.xml.classes']/class[@name='DF']/method[@name='setChaveConProdDF' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setChaveConProdDF", "(Ljava/lang/String;)V", "GetSetChaveConProdDF_Ljava_lang_String_Handler")]
			set {
				const string __id = "setChaveConProdDF.(Ljava/lang/String;)V";
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

		static Delegate cb_getHomoDF;
#pragma warning disable 0169
		static Delegate GetGetHomoDFHandler ()
		{
			if (cb_getHomoDF == null)
				cb_getHomoDF = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetHomoDF));
			return cb_getHomoDF;
		}

		static IntPtr n_GetHomoDF (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Daruma.Framework.Mobile.Gne.Nfce.Xml.Classes.DF> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.HomoDF);
		}
#pragma warning restore 0169

		static Delegate cb_setHomoDF_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetHomoDF_Ljava_lang_String_Handler ()
		{
			if (cb_setHomoDF_Ljava_lang_String_ == null)
				cb_setHomoDF_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_SetHomoDF_Ljava_lang_String_));
			return cb_setHomoDF_Ljava_lang_String_;
		}

		static void n_SetHomoDF_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Daruma.Framework.Mobile.Gne.Nfce.Xml.Classes.DF> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.HomoDF = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string HomoDF {
			// Metadata.xml XPath method reference: path="/api/package[@name='br.com.daruma.framework.mobile.gne.nfce.xml.classes']/class[@name='DF']/method[@name='getHomoDF' and count(parameter)=0]"
			[Register ("getHomoDF", "()Ljava/lang/String;", "GetGetHomoDFHandler")]
			get {
				const string __id = "getHomoDF.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='br.com.daruma.framework.mobile.gne.nfce.xml.classes']/class[@name='DF']/method[@name='setHomoDF' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setHomoDF", "(Ljava/lang/String;)V", "GetSetHomoDF_Ljava_lang_String_Handler")]
			set {
				const string __id = "setHomoDF.(Ljava/lang/String;)V";
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

		static Delegate cb_getProdDF;
#pragma warning disable 0169
		static Delegate GetGetProdDFHandler ()
		{
			if (cb_getProdDF == null)
				cb_getProdDF = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetProdDF));
			return cb_getProdDF;
		}

		static IntPtr n_GetProdDF (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Daruma.Framework.Mobile.Gne.Nfce.Xml.Classes.DF> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ProdDF);
		}
#pragma warning restore 0169

		static Delegate cb_setProdDF_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetProdDF_Ljava_lang_String_Handler ()
		{
			if (cb_setProdDF_Ljava_lang_String_ == null)
				cb_setProdDF_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_SetProdDF_Ljava_lang_String_));
			return cb_setProdDF_Ljava_lang_String_;
		}

		static void n_SetProdDF_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Daruma.Framework.Mobile.Gne.Nfce.Xml.Classes.DF> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ProdDF = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string ProdDF {
			// Metadata.xml XPath method reference: path="/api/package[@name='br.com.daruma.framework.mobile.gne.nfce.xml.classes']/class[@name='DF']/method[@name='getProdDF' and count(parameter)=0]"
			[Register ("getProdDF", "()Ljava/lang/String;", "GetGetProdDFHandler")]
			get {
				const string __id = "getProdDF.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='br.com.daruma.framework.mobile.gne.nfce.xml.classes']/class[@name='DF']/method[@name='setProdDF' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setProdDF", "(Ljava/lang/String;)V", "GetSetProdDF_Ljava_lang_String_Handler")]
			set {
				const string __id = "setProdDF.(Ljava/lang/String;)V";
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

		static Delegate cb_inserirTag_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetInserirTag_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_inserirTag_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_inserirTag_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_V (n_InserirTag_Ljava_lang_String_Ljava_lang_String_));
			return cb_inserirTag_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_InserirTag_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Daruma.Framework.Mobile.Gne.Nfce.Xml.Classes.DF> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.InserirTag (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.daruma.framework.mobile.gne.nfce.xml.classes']/class[@name='DF']/method[@name='inserirTag' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("inserirTag", "(Ljava/lang/String;Ljava/lang/String;)V", "GetInserirTag_Ljava_lang_String_Ljava_lang_String_Handler")]
		public override unsafe void InserirTag (string p0, string p1)
		{
			const string __id = "inserirTag.(Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			IntPtr native_p1 = JNIEnv.NewString ((string)p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_pesquisarTag_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPesquisarTag_Ljava_lang_String_Handler ()
		{
			if (cb_pesquisarTag_Ljava_lang_String_ == null)
				cb_pesquisarTag_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_L (n_PesquisarTag_Ljava_lang_String_));
			return cb_pesquisarTag_Ljava_lang_String_;
		}

		static IntPtr n_PesquisarTag_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Daruma.Framework.Mobile.Gne.Nfce.Xml.Classes.DF> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewArray (__this.PesquisarTag (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.daruma.framework.mobile.gne.nfce.xml.classes']/class[@name='DF']/method[@name='pesquisarTag' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("pesquisarTag", "(Ljava/lang/String;)[C", "GetPesquisarTag_Ljava_lang_String_Handler")]
		public override unsafe char[] PesquisarTag (string p0)
		{
			const string __id = "pesquisarTag.(Ljava/lang/String;)[C";
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (char[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (char));
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}