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

	// Metadata.xml XPath class reference: path="/api/package[@name='br.com.daruma.framework.mobile.gne.nfce.xml.classes']/class[@name='SE']"
	[global::Android.Runtime.Register ("br/com/daruma/framework/mobile/gne/nfce/xml/classes/SE", DoNotGenerateAcw=true)]
	public partial class SE : global::BR.Com.Daruma.Framework.Mobile.Gne.Tags {
		static readonly JniPeerMembers _members = new XAPeerMembers ("br/com/daruma/framework/mobile/gne/nfce/xml/classes/SE", typeof (SE));

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

		protected SE (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='br.com.daruma.framework.mobile.gne.nfce.xml.classes']/class[@name='SE']/constructor[@name='SE' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SE () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_getChaveConHomoSE;
#pragma warning disable 0169
		static Delegate GetGetChaveConHomoSEHandler ()
		{
			if (cb_getChaveConHomoSE == null)
				cb_getChaveConHomoSE = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetChaveConHomoSE));
			return cb_getChaveConHomoSE;
		}

		static IntPtr n_GetChaveConHomoSE (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Daruma.Framework.Mobile.Gne.Nfce.Xml.Classes.SE> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ChaveConHomoSE);
		}
#pragma warning restore 0169

		static Delegate cb_setChaveConHomoSE_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetChaveConHomoSE_Ljava_lang_String_Handler ()
		{
			if (cb_setChaveConHomoSE_Ljava_lang_String_ == null)
				cb_setChaveConHomoSE_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_SetChaveConHomoSE_Ljava_lang_String_));
			return cb_setChaveConHomoSE_Ljava_lang_String_;
		}

		static void n_SetChaveConHomoSE_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Daruma.Framework.Mobile.Gne.Nfce.Xml.Classes.SE> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ChaveConHomoSE = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string ChaveConHomoSE {
			// Metadata.xml XPath method reference: path="/api/package[@name='br.com.daruma.framework.mobile.gne.nfce.xml.classes']/class[@name='SE']/method[@name='getChaveConHomoSE' and count(parameter)=0]"
			[Register ("getChaveConHomoSE", "()Ljava/lang/String;", "GetGetChaveConHomoSEHandler")]
			get {
				const string __id = "getChaveConHomoSE.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='br.com.daruma.framework.mobile.gne.nfce.xml.classes']/class[@name='SE']/method[@name='setChaveConHomoSE' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setChaveConHomoSE", "(Ljava/lang/String;)V", "GetSetChaveConHomoSE_Ljava_lang_String_Handler")]
			set {
				const string __id = "setChaveConHomoSE.(Ljava/lang/String;)V";
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

		static Delegate cb_getChaveConProdSE;
#pragma warning disable 0169
		static Delegate GetGetChaveConProdSEHandler ()
		{
			if (cb_getChaveConProdSE == null)
				cb_getChaveConProdSE = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetChaveConProdSE));
			return cb_getChaveConProdSE;
		}

		static IntPtr n_GetChaveConProdSE (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Daruma.Framework.Mobile.Gne.Nfce.Xml.Classes.SE> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ChaveConProdSE);
		}
#pragma warning restore 0169

		static Delegate cb_setChaveConProdSE_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetChaveConProdSE_Ljava_lang_String_Handler ()
		{
			if (cb_setChaveConProdSE_Ljava_lang_String_ == null)
				cb_setChaveConProdSE_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_SetChaveConProdSE_Ljava_lang_String_));
			return cb_setChaveConProdSE_Ljava_lang_String_;
		}

		static void n_SetChaveConProdSE_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Daruma.Framework.Mobile.Gne.Nfce.Xml.Classes.SE> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ChaveConProdSE = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string ChaveConProdSE {
			// Metadata.xml XPath method reference: path="/api/package[@name='br.com.daruma.framework.mobile.gne.nfce.xml.classes']/class[@name='SE']/method[@name='getChaveConProdSE' and count(parameter)=0]"
			[Register ("getChaveConProdSE", "()Ljava/lang/String;", "GetGetChaveConProdSEHandler")]
			get {
				const string __id = "getChaveConProdSE.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='br.com.daruma.framework.mobile.gne.nfce.xml.classes']/class[@name='SE']/method[@name='setChaveConProdSE' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setChaveConProdSE", "(Ljava/lang/String;)V", "GetSetChaveConProdSE_Ljava_lang_String_Handler")]
			set {
				const string __id = "setChaveConProdSE.(Ljava/lang/String;)V";
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

		static Delegate cb_getHomoSE;
#pragma warning disable 0169
		static Delegate GetGetHomoSEHandler ()
		{
			if (cb_getHomoSE == null)
				cb_getHomoSE = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetHomoSE));
			return cb_getHomoSE;
		}

		static IntPtr n_GetHomoSE (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Daruma.Framework.Mobile.Gne.Nfce.Xml.Classes.SE> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.HomoSE);
		}
#pragma warning restore 0169

		static Delegate cb_setHomoSE_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetHomoSE_Ljava_lang_String_Handler ()
		{
			if (cb_setHomoSE_Ljava_lang_String_ == null)
				cb_setHomoSE_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_SetHomoSE_Ljava_lang_String_));
			return cb_setHomoSE_Ljava_lang_String_;
		}

		static void n_SetHomoSE_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Daruma.Framework.Mobile.Gne.Nfce.Xml.Classes.SE> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.HomoSE = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string HomoSE {
			// Metadata.xml XPath method reference: path="/api/package[@name='br.com.daruma.framework.mobile.gne.nfce.xml.classes']/class[@name='SE']/method[@name='getHomoSE' and count(parameter)=0]"
			[Register ("getHomoSE", "()Ljava/lang/String;", "GetGetHomoSEHandler")]
			get {
				const string __id = "getHomoSE.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='br.com.daruma.framework.mobile.gne.nfce.xml.classes']/class[@name='SE']/method[@name='setHomoSE' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setHomoSE", "(Ljava/lang/String;)V", "GetSetHomoSE_Ljava_lang_String_Handler")]
			set {
				const string __id = "setHomoSE.(Ljava/lang/String;)V";
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

		static Delegate cb_getProdSE;
#pragma warning disable 0169
		static Delegate GetGetProdSEHandler ()
		{
			if (cb_getProdSE == null)
				cb_getProdSE = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetProdSE));
			return cb_getProdSE;
		}

		static IntPtr n_GetProdSE (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Daruma.Framework.Mobile.Gne.Nfce.Xml.Classes.SE> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ProdSE);
		}
#pragma warning restore 0169

		static Delegate cb_setProdSE_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetProdSE_Ljava_lang_String_Handler ()
		{
			if (cb_setProdSE_Ljava_lang_String_ == null)
				cb_setProdSE_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_SetProdSE_Ljava_lang_String_));
			return cb_setProdSE_Ljava_lang_String_;
		}

		static void n_SetProdSE_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Daruma.Framework.Mobile.Gne.Nfce.Xml.Classes.SE> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ProdSE = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string ProdSE {
			// Metadata.xml XPath method reference: path="/api/package[@name='br.com.daruma.framework.mobile.gne.nfce.xml.classes']/class[@name='SE']/method[@name='getProdSE' and count(parameter)=0]"
			[Register ("getProdSE", "()Ljava/lang/String;", "GetGetProdSEHandler")]
			get {
				const string __id = "getProdSE.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='br.com.daruma.framework.mobile.gne.nfce.xml.classes']/class[@name='SE']/method[@name='setProdSE' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setProdSE", "(Ljava/lang/String;)V", "GetSetProdSE_Ljava_lang_String_Handler")]
			set {
				const string __id = "setProdSE.(Ljava/lang/String;)V";
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
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Daruma.Framework.Mobile.Gne.Nfce.Xml.Classes.SE> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.InserirTag (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.daruma.framework.mobile.gne.nfce.xml.classes']/class[@name='SE']/method[@name='inserirTag' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
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
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Daruma.Framework.Mobile.Gne.Nfce.Xml.Classes.SE> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewArray (__this.PesquisarTag (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.daruma.framework.mobile.gne.nfce.xml.classes']/class[@name='SE']/method[@name='pesquisarTag' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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