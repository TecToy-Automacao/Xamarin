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

	// Metadata.xml XPath class reference: path="/api/package[@name='br.com.daruma.framework.mobile.gne.nfce.xml.classes']/class[@name='MA']"
	[global::Android.Runtime.Register ("br/com/daruma/framework/mobile/gne/nfce/xml/classes/MA", DoNotGenerateAcw=true)]
	public partial class MA : global::BR.Com.Daruma.Framework.Mobile.Gne.Tags {
		static readonly JniPeerMembers _members = new XAPeerMembers ("br/com/daruma/framework/mobile/gne/nfce/xml/classes/MA", typeof (MA));

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

		protected MA (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='br.com.daruma.framework.mobile.gne.nfce.xml.classes']/class[@name='MA']/constructor[@name='MA' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MA () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_getChaveConHomoMA;
#pragma warning disable 0169
		static Delegate GetGetChaveConHomoMAHandler ()
		{
			if (cb_getChaveConHomoMA == null)
				cb_getChaveConHomoMA = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetChaveConHomoMA));
			return cb_getChaveConHomoMA;
		}

		static IntPtr n_GetChaveConHomoMA (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Daruma.Framework.Mobile.Gne.Nfce.Xml.Classes.MA> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ChaveConHomoMA);
		}
#pragma warning restore 0169

		static Delegate cb_setChaveConHomoMA_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetChaveConHomoMA_Ljava_lang_String_Handler ()
		{
			if (cb_setChaveConHomoMA_Ljava_lang_String_ == null)
				cb_setChaveConHomoMA_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_SetChaveConHomoMA_Ljava_lang_String_));
			return cb_setChaveConHomoMA_Ljava_lang_String_;
		}

		static void n_SetChaveConHomoMA_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Daruma.Framework.Mobile.Gne.Nfce.Xml.Classes.MA> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ChaveConHomoMA = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string ChaveConHomoMA {
			// Metadata.xml XPath method reference: path="/api/package[@name='br.com.daruma.framework.mobile.gne.nfce.xml.classes']/class[@name='MA']/method[@name='getChaveConHomoMA' and count(parameter)=0]"
			[Register ("getChaveConHomoMA", "()Ljava/lang/String;", "GetGetChaveConHomoMAHandler")]
			get {
				const string __id = "getChaveConHomoMA.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='br.com.daruma.framework.mobile.gne.nfce.xml.classes']/class[@name='MA']/method[@name='setChaveConHomoMA' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setChaveConHomoMA", "(Ljava/lang/String;)V", "GetSetChaveConHomoMA_Ljava_lang_String_Handler")]
			set {
				const string __id = "setChaveConHomoMA.(Ljava/lang/String;)V";
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

		static Delegate cb_getChaveConProdMA;
#pragma warning disable 0169
		static Delegate GetGetChaveConProdMAHandler ()
		{
			if (cb_getChaveConProdMA == null)
				cb_getChaveConProdMA = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetChaveConProdMA));
			return cb_getChaveConProdMA;
		}

		static IntPtr n_GetChaveConProdMA (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Daruma.Framework.Mobile.Gne.Nfce.Xml.Classes.MA> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ChaveConProdMA);
		}
#pragma warning restore 0169

		static Delegate cb_setChaveConProdMA_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetChaveConProdMA_Ljava_lang_String_Handler ()
		{
			if (cb_setChaveConProdMA_Ljava_lang_String_ == null)
				cb_setChaveConProdMA_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_SetChaveConProdMA_Ljava_lang_String_));
			return cb_setChaveConProdMA_Ljava_lang_String_;
		}

		static void n_SetChaveConProdMA_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Daruma.Framework.Mobile.Gne.Nfce.Xml.Classes.MA> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ChaveConProdMA = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string ChaveConProdMA {
			// Metadata.xml XPath method reference: path="/api/package[@name='br.com.daruma.framework.mobile.gne.nfce.xml.classes']/class[@name='MA']/method[@name='getChaveConProdMA' and count(parameter)=0]"
			[Register ("getChaveConProdMA", "()Ljava/lang/String;", "GetGetChaveConProdMAHandler")]
			get {
				const string __id = "getChaveConProdMA.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='br.com.daruma.framework.mobile.gne.nfce.xml.classes']/class[@name='MA']/method[@name='setChaveConProdMA' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setChaveConProdMA", "(Ljava/lang/String;)V", "GetSetChaveConProdMA_Ljava_lang_String_Handler")]
			set {
				const string __id = "setChaveConProdMA.(Ljava/lang/String;)V";
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

		static Delegate cb_getHomoMA;
#pragma warning disable 0169
		static Delegate GetGetHomoMAHandler ()
		{
			if (cb_getHomoMA == null)
				cb_getHomoMA = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetHomoMA));
			return cb_getHomoMA;
		}

		static IntPtr n_GetHomoMA (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Daruma.Framework.Mobile.Gne.Nfce.Xml.Classes.MA> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.HomoMA);
		}
#pragma warning restore 0169

		static Delegate cb_setHomoMA_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetHomoMA_Ljava_lang_String_Handler ()
		{
			if (cb_setHomoMA_Ljava_lang_String_ == null)
				cb_setHomoMA_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_SetHomoMA_Ljava_lang_String_));
			return cb_setHomoMA_Ljava_lang_String_;
		}

		static void n_SetHomoMA_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Daruma.Framework.Mobile.Gne.Nfce.Xml.Classes.MA> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.HomoMA = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string HomoMA {
			// Metadata.xml XPath method reference: path="/api/package[@name='br.com.daruma.framework.mobile.gne.nfce.xml.classes']/class[@name='MA']/method[@name='getHomoMA' and count(parameter)=0]"
			[Register ("getHomoMA", "()Ljava/lang/String;", "GetGetHomoMAHandler")]
			get {
				const string __id = "getHomoMA.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='br.com.daruma.framework.mobile.gne.nfce.xml.classes']/class[@name='MA']/method[@name='setHomoMA' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setHomoMA", "(Ljava/lang/String;)V", "GetSetHomoMA_Ljava_lang_String_Handler")]
			set {
				const string __id = "setHomoMA.(Ljava/lang/String;)V";
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

		static Delegate cb_getProdMA;
#pragma warning disable 0169
		static Delegate GetGetProdMAHandler ()
		{
			if (cb_getProdMA == null)
				cb_getProdMA = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetProdMA));
			return cb_getProdMA;
		}

		static IntPtr n_GetProdMA (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Daruma.Framework.Mobile.Gne.Nfce.Xml.Classes.MA> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ProdMA);
		}
#pragma warning restore 0169

		static Delegate cb_setProdMA_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetProdMA_Ljava_lang_String_Handler ()
		{
			if (cb_setProdMA_Ljava_lang_String_ == null)
				cb_setProdMA_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_SetProdMA_Ljava_lang_String_));
			return cb_setProdMA_Ljava_lang_String_;
		}

		static void n_SetProdMA_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Daruma.Framework.Mobile.Gne.Nfce.Xml.Classes.MA> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ProdMA = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string ProdMA {
			// Metadata.xml XPath method reference: path="/api/package[@name='br.com.daruma.framework.mobile.gne.nfce.xml.classes']/class[@name='MA']/method[@name='getProdMA' and count(parameter)=0]"
			[Register ("getProdMA", "()Ljava/lang/String;", "GetGetProdMAHandler")]
			get {
				const string __id = "getProdMA.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='br.com.daruma.framework.mobile.gne.nfce.xml.classes']/class[@name='MA']/method[@name='setProdMA' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setProdMA", "(Ljava/lang/String;)V", "GetSetProdMA_Ljava_lang_String_Handler")]
			set {
				const string __id = "setProdMA.(Ljava/lang/String;)V";
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
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Daruma.Framework.Mobile.Gne.Nfce.Xml.Classes.MA> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.InserirTag (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.daruma.framework.mobile.gne.nfce.xml.classes']/class[@name='MA']/method[@name='inserirTag' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
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
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Daruma.Framework.Mobile.Gne.Nfce.Xml.Classes.MA> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewArray (__this.PesquisarTag (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.daruma.framework.mobile.gne.nfce.xml.classes']/class[@name='MA']/method[@name='pesquisarTag' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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