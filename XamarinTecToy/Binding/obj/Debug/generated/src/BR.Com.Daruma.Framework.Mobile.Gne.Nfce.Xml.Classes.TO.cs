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

	// Metadata.xml XPath class reference: path="/api/package[@name='br.com.daruma.framework.mobile.gne.nfce.xml.classes']/class[@name='TO']"
	[global::Android.Runtime.Register ("br/com/daruma/framework/mobile/gne/nfce/xml/classes/TO", DoNotGenerateAcw=true)]
	public partial class TO : global::BR.Com.Daruma.Framework.Mobile.Gne.Tags {
		static readonly JniPeerMembers _members = new XAPeerMembers ("br/com/daruma/framework/mobile/gne/nfce/xml/classes/TO", typeof (TO));

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

		protected TO (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='br.com.daruma.framework.mobile.gne.nfce.xml.classes']/class[@name='TO']/constructor[@name='TO' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe TO () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_getChaveConHomoTO;
#pragma warning disable 0169
		static Delegate GetGetChaveConHomoTOHandler ()
		{
			if (cb_getChaveConHomoTO == null)
				cb_getChaveConHomoTO = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetChaveConHomoTO));
			return cb_getChaveConHomoTO;
		}

		static IntPtr n_GetChaveConHomoTO (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Daruma.Framework.Mobile.Gne.Nfce.Xml.Classes.TO> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ChaveConHomoTO);
		}
#pragma warning restore 0169

		static Delegate cb_setChaveConHomoTO_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetChaveConHomoTO_Ljava_lang_String_Handler ()
		{
			if (cb_setChaveConHomoTO_Ljava_lang_String_ == null)
				cb_setChaveConHomoTO_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_SetChaveConHomoTO_Ljava_lang_String_));
			return cb_setChaveConHomoTO_Ljava_lang_String_;
		}

		static void n_SetChaveConHomoTO_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Daruma.Framework.Mobile.Gne.Nfce.Xml.Classes.TO> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ChaveConHomoTO = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string ChaveConHomoTO {
			// Metadata.xml XPath method reference: path="/api/package[@name='br.com.daruma.framework.mobile.gne.nfce.xml.classes']/class[@name='TO']/method[@name='getChaveConHomoTO' and count(parameter)=0]"
			[Register ("getChaveConHomoTO", "()Ljava/lang/String;", "GetGetChaveConHomoTOHandler")]
			get {
				const string __id = "getChaveConHomoTO.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='br.com.daruma.framework.mobile.gne.nfce.xml.classes']/class[@name='TO']/method[@name='setChaveConHomoTO' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setChaveConHomoTO", "(Ljava/lang/String;)V", "GetSetChaveConHomoTO_Ljava_lang_String_Handler")]
			set {
				const string __id = "setChaveConHomoTO.(Ljava/lang/String;)V";
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

		static Delegate cb_getChaveConProdTO;
#pragma warning disable 0169
		static Delegate GetGetChaveConProdTOHandler ()
		{
			if (cb_getChaveConProdTO == null)
				cb_getChaveConProdTO = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetChaveConProdTO));
			return cb_getChaveConProdTO;
		}

		static IntPtr n_GetChaveConProdTO (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Daruma.Framework.Mobile.Gne.Nfce.Xml.Classes.TO> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ChaveConProdTO);
		}
#pragma warning restore 0169

		static Delegate cb_setChaveConProdTO_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetChaveConProdTO_Ljava_lang_String_Handler ()
		{
			if (cb_setChaveConProdTO_Ljava_lang_String_ == null)
				cb_setChaveConProdTO_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_SetChaveConProdTO_Ljava_lang_String_));
			return cb_setChaveConProdTO_Ljava_lang_String_;
		}

		static void n_SetChaveConProdTO_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Daruma.Framework.Mobile.Gne.Nfce.Xml.Classes.TO> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ChaveConProdTO = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string ChaveConProdTO {
			// Metadata.xml XPath method reference: path="/api/package[@name='br.com.daruma.framework.mobile.gne.nfce.xml.classes']/class[@name='TO']/method[@name='getChaveConProdTO' and count(parameter)=0]"
			[Register ("getChaveConProdTO", "()Ljava/lang/String;", "GetGetChaveConProdTOHandler")]
			get {
				const string __id = "getChaveConProdTO.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='br.com.daruma.framework.mobile.gne.nfce.xml.classes']/class[@name='TO']/method[@name='setChaveConProdTO' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setChaveConProdTO", "(Ljava/lang/String;)V", "GetSetChaveConProdTO_Ljava_lang_String_Handler")]
			set {
				const string __id = "setChaveConProdTO.(Ljava/lang/String;)V";
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

		static Delegate cb_getHomoTO;
#pragma warning disable 0169
		static Delegate GetGetHomoTOHandler ()
		{
			if (cb_getHomoTO == null)
				cb_getHomoTO = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetHomoTO));
			return cb_getHomoTO;
		}

		static IntPtr n_GetHomoTO (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Daruma.Framework.Mobile.Gne.Nfce.Xml.Classes.TO> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.HomoTO);
		}
#pragma warning restore 0169

		static Delegate cb_setHomoTO_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetHomoTO_Ljava_lang_String_Handler ()
		{
			if (cb_setHomoTO_Ljava_lang_String_ == null)
				cb_setHomoTO_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_SetHomoTO_Ljava_lang_String_));
			return cb_setHomoTO_Ljava_lang_String_;
		}

		static void n_SetHomoTO_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Daruma.Framework.Mobile.Gne.Nfce.Xml.Classes.TO> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.HomoTO = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string HomoTO {
			// Metadata.xml XPath method reference: path="/api/package[@name='br.com.daruma.framework.mobile.gne.nfce.xml.classes']/class[@name='TO']/method[@name='getHomoTO' and count(parameter)=0]"
			[Register ("getHomoTO", "()Ljava/lang/String;", "GetGetHomoTOHandler")]
			get {
				const string __id = "getHomoTO.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='br.com.daruma.framework.mobile.gne.nfce.xml.classes']/class[@name='TO']/method[@name='setHomoTO' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setHomoTO", "(Ljava/lang/String;)V", "GetSetHomoTO_Ljava_lang_String_Handler")]
			set {
				const string __id = "setHomoTO.(Ljava/lang/String;)V";
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

		static Delegate cb_getProdTO;
#pragma warning disable 0169
		static Delegate GetGetProdTOHandler ()
		{
			if (cb_getProdTO == null)
				cb_getProdTO = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetProdTO));
			return cb_getProdTO;
		}

		static IntPtr n_GetProdTO (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Daruma.Framework.Mobile.Gne.Nfce.Xml.Classes.TO> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ProdTO);
		}
#pragma warning restore 0169

		static Delegate cb_setProdTO_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetProdTO_Ljava_lang_String_Handler ()
		{
			if (cb_setProdTO_Ljava_lang_String_ == null)
				cb_setProdTO_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_SetProdTO_Ljava_lang_String_));
			return cb_setProdTO_Ljava_lang_String_;
		}

		static void n_SetProdTO_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Daruma.Framework.Mobile.Gne.Nfce.Xml.Classes.TO> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ProdTO = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string ProdTO {
			// Metadata.xml XPath method reference: path="/api/package[@name='br.com.daruma.framework.mobile.gne.nfce.xml.classes']/class[@name='TO']/method[@name='getProdTO' and count(parameter)=0]"
			[Register ("getProdTO", "()Ljava/lang/String;", "GetGetProdTOHandler")]
			get {
				const string __id = "getProdTO.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='br.com.daruma.framework.mobile.gne.nfce.xml.classes']/class[@name='TO']/method[@name='setProdTO' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setProdTO", "(Ljava/lang/String;)V", "GetSetProdTO_Ljava_lang_String_Handler")]
			set {
				const string __id = "setProdTO.(Ljava/lang/String;)V";
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
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Daruma.Framework.Mobile.Gne.Nfce.Xml.Classes.TO> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.InserirTag (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.daruma.framework.mobile.gne.nfce.xml.classes']/class[@name='TO']/method[@name='inserirTag' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
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
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Daruma.Framework.Mobile.Gne.Nfce.Xml.Classes.TO> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewArray (__this.PesquisarTag (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.daruma.framework.mobile.gne.nfce.xml.classes']/class[@name='TO']/method[@name='pesquisarTag' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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