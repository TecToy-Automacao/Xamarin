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

	// Metadata.xml XPath class reference: path="/api/package[@name='br.com.daruma.framework.mobile.gne.nfce.xml.classes']/class[@name='ProdAuxiliar']"
	[global::Android.Runtime.Register ("br/com/daruma/framework/mobile/gne/nfce/xml/classes/ProdAuxiliar", DoNotGenerateAcw=true)]
	public partial class ProdAuxiliar : global::BR.Com.Daruma.Framework.Mobile.Gne.Tags {
		static readonly JniPeerMembers _members = new XAPeerMembers ("br/com/daruma/framework/mobile/gne/nfce/xml/classes/ProdAuxiliar", typeof (ProdAuxiliar));

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

		protected ProdAuxiliar (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='br.com.daruma.framework.mobile.gne.nfce.xml.classes']/class[@name='ProdAuxiliar']/constructor[@name='ProdAuxiliar' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ProdAuxiliar () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_getCEST;
#pragma warning disable 0169
		static Delegate GetGetCESTHandler ()
		{
			if (cb_getCEST == null)
				cb_getCEST = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetCEST));
			return cb_getCEST;
		}

		static IntPtr n_GetCEST (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Daruma.Framework.Mobile.Gne.Nfce.Xml.Classes.ProdAuxiliar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CEST);
		}
#pragma warning restore 0169

		static Delegate cb_setCEST_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetCEST_Ljava_lang_String_Handler ()
		{
			if (cb_setCEST_Ljava_lang_String_ == null)
				cb_setCEST_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_SetCEST_Ljava_lang_String_));
			return cb_setCEST_Ljava_lang_String_;
		}

		static void n_SetCEST_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Daruma.Framework.Mobile.Gne.Nfce.Xml.Classes.ProdAuxiliar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CEST = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string CEST {
			// Metadata.xml XPath method reference: path="/api/package[@name='br.com.daruma.framework.mobile.gne.nfce.xml.classes']/class[@name='ProdAuxiliar']/method[@name='getCEST' and count(parameter)=0]"
			[Register ("getCEST", "()Ljava/lang/String;", "GetGetCESTHandler")]
			get {
				const string __id = "getCEST.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='br.com.daruma.framework.mobile.gne.nfce.xml.classes']/class[@name='ProdAuxiliar']/method[@name='setCEST' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setCEST", "(Ljava/lang/String;)V", "GetSetCEST_Ljava_lang_String_Handler")]
			set {
				const string __id = "setCEST.(Ljava/lang/String;)V";
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

		static Delegate cb_getCFOP;
#pragma warning disable 0169
		static Delegate GetGetCFOPHandler ()
		{
			if (cb_getCFOP == null)
				cb_getCFOP = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetCFOP));
			return cb_getCFOP;
		}

		static IntPtr n_GetCFOP (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Daruma.Framework.Mobile.Gne.Nfce.Xml.Classes.ProdAuxiliar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CFOP);
		}
#pragma warning restore 0169

		static Delegate cb_setCFOP_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetCFOP_Ljava_lang_String_Handler ()
		{
			if (cb_setCFOP_Ljava_lang_String_ == null)
				cb_setCFOP_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_SetCFOP_Ljava_lang_String_));
			return cb_setCFOP_Ljava_lang_String_;
		}

		static void n_SetCFOP_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Daruma.Framework.Mobile.Gne.Nfce.Xml.Classes.ProdAuxiliar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CFOP = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string CFOP {
			// Metadata.xml XPath method reference: path="/api/package[@name='br.com.daruma.framework.mobile.gne.nfce.xml.classes']/class[@name='ProdAuxiliar']/method[@name='getCFOP' and count(parameter)=0]"
			[Register ("getCFOP", "()Ljava/lang/String;", "GetGetCFOPHandler")]
			get {
				const string __id = "getCFOP.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='br.com.daruma.framework.mobile.gne.nfce.xml.classes']/class[@name='ProdAuxiliar']/method[@name='setCFOP' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setCFOP", "(Ljava/lang/String;)V", "GetSetCFOP_Ljava_lang_String_Handler")]
			set {
				const string __id = "setCFOP.(Ljava/lang/String;)V";
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

		static Delegate cb_getCNPJFab;
#pragma warning disable 0169
		static Delegate GetGetCNPJFabHandler ()
		{
			if (cb_getCNPJFab == null)
				cb_getCNPJFab = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetCNPJFab));
			return cb_getCNPJFab;
		}

		static IntPtr n_GetCNPJFab (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Daruma.Framework.Mobile.Gne.Nfce.Xml.Classes.ProdAuxiliar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CNPJFab);
		}
#pragma warning restore 0169

		static Delegate cb_setCNPJFab_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetCNPJFab_Ljava_lang_String_Handler ()
		{
			if (cb_setCNPJFab_Ljava_lang_String_ == null)
				cb_setCNPJFab_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_SetCNPJFab_Ljava_lang_String_));
			return cb_setCNPJFab_Ljava_lang_String_;
		}

		static void n_SetCNPJFab_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Daruma.Framework.Mobile.Gne.Nfce.Xml.Classes.ProdAuxiliar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CNPJFab = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string CNPJFab {
			// Metadata.xml XPath method reference: path="/api/package[@name='br.com.daruma.framework.mobile.gne.nfce.xml.classes']/class[@name='ProdAuxiliar']/method[@name='getCNPJFab' and count(parameter)=0]"
			[Register ("getCNPJFab", "()Ljava/lang/String;", "GetGetCNPJFabHandler")]
			get {
				const string __id = "getCNPJFab.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='br.com.daruma.framework.mobile.gne.nfce.xml.classes']/class[@name='ProdAuxiliar']/method[@name='setCNPJFab' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setCNPJFab", "(Ljava/lang/String;)V", "GetSetCNPJFab_Ljava_lang_String_Handler")]
			set {
				const string __id = "setCNPJFab.(Ljava/lang/String;)V";
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

		static Delegate cb_getIndEscala;
#pragma warning disable 0169
		static Delegate GetGetIndEscalaHandler ()
		{
			if (cb_getIndEscala == null)
				cb_getIndEscala = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetIndEscala));
			return cb_getIndEscala;
		}

		static IntPtr n_GetIndEscala (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Daruma.Framework.Mobile.Gne.Nfce.Xml.Classes.ProdAuxiliar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.IndEscala);
		}
#pragma warning restore 0169

		static Delegate cb_setIndEscala_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetIndEscala_Ljava_lang_String_Handler ()
		{
			if (cb_setIndEscala_Ljava_lang_String_ == null)
				cb_setIndEscala_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_SetIndEscala_Ljava_lang_String_));
			return cb_setIndEscala_Ljava_lang_String_;
		}

		static void n_SetIndEscala_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Daruma.Framework.Mobile.Gne.Nfce.Xml.Classes.ProdAuxiliar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.IndEscala = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string IndEscala {
			// Metadata.xml XPath method reference: path="/api/package[@name='br.com.daruma.framework.mobile.gne.nfce.xml.classes']/class[@name='ProdAuxiliar']/method[@name='getIndEscala' and count(parameter)=0]"
			[Register ("getIndEscala", "()Ljava/lang/String;", "GetGetIndEscalaHandler")]
			get {
				const string __id = "getIndEscala.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='br.com.daruma.framework.mobile.gne.nfce.xml.classes']/class[@name='ProdAuxiliar']/method[@name='setIndEscala' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setIndEscala", "(Ljava/lang/String;)V", "GetSetIndEscala_Ljava_lang_String_Handler")]
			set {
				const string __id = "setIndEscala.(Ljava/lang/String;)V";
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

		static Delegate cb_getIndTot;
#pragma warning disable 0169
		static Delegate GetGetIndTotHandler ()
		{
			if (cb_getIndTot == null)
				cb_getIndTot = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetIndTot));
			return cb_getIndTot;
		}

		static IntPtr n_GetIndTot (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Daruma.Framework.Mobile.Gne.Nfce.Xml.Classes.ProdAuxiliar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.IndTot);
		}
#pragma warning restore 0169

		static Delegate cb_setIndTot_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetIndTot_Ljava_lang_String_Handler ()
		{
			if (cb_setIndTot_Ljava_lang_String_ == null)
				cb_setIndTot_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_SetIndTot_Ljava_lang_String_));
			return cb_setIndTot_Ljava_lang_String_;
		}

		static void n_SetIndTot_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Daruma.Framework.Mobile.Gne.Nfce.Xml.Classes.ProdAuxiliar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.IndTot = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string IndTot {
			// Metadata.xml XPath method reference: path="/api/package[@name='br.com.daruma.framework.mobile.gne.nfce.xml.classes']/class[@name='ProdAuxiliar']/method[@name='getIndTot' and count(parameter)=0]"
			[Register ("getIndTot", "()Ljava/lang/String;", "GetGetIndTotHandler")]
			get {
				const string __id = "getIndTot.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='br.com.daruma.framework.mobile.gne.nfce.xml.classes']/class[@name='ProdAuxiliar']/method[@name='setIndTot' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setIndTot", "(Ljava/lang/String;)V", "GetSetIndTot_Ljava_lang_String_Handler")]
			set {
				const string __id = "setIndTot.(Ljava/lang/String;)V";
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

		static Delegate cb_getNCM;
#pragma warning disable 0169
		static Delegate GetGetNCMHandler ()
		{
			if (cb_getNCM == null)
				cb_getNCM = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetNCM));
			return cb_getNCM;
		}

		static IntPtr n_GetNCM (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Daruma.Framework.Mobile.Gne.Nfce.Xml.Classes.ProdAuxiliar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.NCM);
		}
#pragma warning restore 0169

		static Delegate cb_setNCM_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetNCM_Ljava_lang_String_Handler ()
		{
			if (cb_setNCM_Ljava_lang_String_ == null)
				cb_setNCM_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_SetNCM_Ljava_lang_String_));
			return cb_setNCM_Ljava_lang_String_;
		}

		static void n_SetNCM_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Daruma.Framework.Mobile.Gne.Nfce.Xml.Classes.ProdAuxiliar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.NCM = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string NCM {
			// Metadata.xml XPath method reference: path="/api/package[@name='br.com.daruma.framework.mobile.gne.nfce.xml.classes']/class[@name='ProdAuxiliar']/method[@name='getNCM' and count(parameter)=0]"
			[Register ("getNCM", "()Ljava/lang/String;", "GetGetNCMHandler")]
			get {
				const string __id = "getNCM.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='br.com.daruma.framework.mobile.gne.nfce.xml.classes']/class[@name='ProdAuxiliar']/method[@name='setNCM' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setNCM", "(Ljava/lang/String;)V", "GetSetNCM_Ljava_lang_String_Handler")]
			set {
				const string __id = "setNCM.(Ljava/lang/String;)V";
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

		static Delegate cb_getcBarra;
#pragma warning disable 0169
		static Delegate GetGetcBarraHandler ()
		{
			if (cb_getcBarra == null)
				cb_getcBarra = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetcBarra));
			return cb_getcBarra;
		}

		static IntPtr n_GetcBarra (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Daruma.Framework.Mobile.Gne.Nfce.Xml.Classes.ProdAuxiliar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.GetcBarra ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.daruma.framework.mobile.gne.nfce.xml.classes']/class[@name='ProdAuxiliar']/method[@name='getcBarra' and count(parameter)=0]"
		[Register ("getcBarra", "()Ljava/lang/String;", "GetGetcBarraHandler")]
		public virtual unsafe string GetcBarra ()
		{
			const string __id = "getcBarra.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getcBarraTrib;
#pragma warning disable 0169
		static Delegate GetGetcBarraTribHandler ()
		{
			if (cb_getcBarraTrib == null)
				cb_getcBarraTrib = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetcBarraTrib));
			return cb_getcBarraTrib;
		}

		static IntPtr n_GetcBarraTrib (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Daruma.Framework.Mobile.Gne.Nfce.Xml.Classes.ProdAuxiliar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.GetcBarraTrib ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.daruma.framework.mobile.gne.nfce.xml.classes']/class[@name='ProdAuxiliar']/method[@name='getcBarraTrib' and count(parameter)=0]"
		[Register ("getcBarraTrib", "()Ljava/lang/String;", "GetGetcBarraTribHandler")]
		public virtual unsafe string GetcBarraTrib ()
		{
			const string __id = "getcBarraTrib.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getcBenef;
#pragma warning disable 0169
		static Delegate GetGetcBenefHandler ()
		{
			if (cb_getcBenef == null)
				cb_getcBenef = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetcBenef));
			return cb_getcBenef;
		}

		static IntPtr n_GetcBenef (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Daruma.Framework.Mobile.Gne.Nfce.Xml.Classes.ProdAuxiliar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.GetcBenef ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.daruma.framework.mobile.gne.nfce.xml.classes']/class[@name='ProdAuxiliar']/method[@name='getcBenef' and count(parameter)=0]"
		[Register ("getcBenef", "()Ljava/lang/String;", "GetGetcBenefHandler")]
		public virtual unsafe string GetcBenef ()
		{
			const string __id = "getcBenef.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getcEAN;
#pragma warning disable 0169
		static Delegate GetGetcEANHandler ()
		{
			if (cb_getcEAN == null)
				cb_getcEAN = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetcEAN));
			return cb_getcEAN;
		}

		static IntPtr n_GetcEAN (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Daruma.Framework.Mobile.Gne.Nfce.Xml.Classes.ProdAuxiliar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.GetcEAN ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.daruma.framework.mobile.gne.nfce.xml.classes']/class[@name='ProdAuxiliar']/method[@name='getcEAN' and count(parameter)=0]"
		[Register ("getcEAN", "()Ljava/lang/String;", "GetGetcEANHandler")]
		public virtual unsafe string GetcEAN ()
		{
			const string __id = "getcEAN.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getcEANTrib;
#pragma warning disable 0169
		static Delegate GetGetcEANTribHandler ()
		{
			if (cb_getcEANTrib == null)
				cb_getcEANTrib = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetcEANTrib));
			return cb_getcEANTrib;
		}

		static IntPtr n_GetcEANTrib (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Daruma.Framework.Mobile.Gne.Nfce.Xml.Classes.ProdAuxiliar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.GetcEANTrib ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.daruma.framework.mobile.gne.nfce.xml.classes']/class[@name='ProdAuxiliar']/method[@name='getcEANTrib' and count(parameter)=0]"
		[Register ("getcEANTrib", "()Ljava/lang/String;", "GetGetcEANTribHandler")]
		public virtual unsafe string GetcEANTrib ()
		{
			const string __id = "getcEANTrib.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
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
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Daruma.Framework.Mobile.Gne.Nfce.Xml.Classes.ProdAuxiliar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.InserirTag (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.daruma.framework.mobile.gne.nfce.xml.classes']/class[@name='ProdAuxiliar']/method[@name='inserirTag' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
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
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Daruma.Framework.Mobile.Gne.Nfce.Xml.Classes.ProdAuxiliar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewArray (__this.PesquisarTag (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.daruma.framework.mobile.gne.nfce.xml.classes']/class[@name='ProdAuxiliar']/method[@name='pesquisarTag' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_setcBarra_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetcBarra_Ljava_lang_String_Handler ()
		{
			if (cb_setcBarra_Ljava_lang_String_ == null)
				cb_setcBarra_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_SetcBarra_Ljava_lang_String_));
			return cb_setcBarra_Ljava_lang_String_;
		}

		static void n_SetcBarra_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Daruma.Framework.Mobile.Gne.Nfce.Xml.Classes.ProdAuxiliar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetcBarra (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.daruma.framework.mobile.gne.nfce.xml.classes']/class[@name='ProdAuxiliar']/method[@name='setcBarra' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setcBarra", "(Ljava/lang/String;)V", "GetSetcBarra_Ljava_lang_String_Handler")]
		public virtual unsafe void SetcBarra (string p0)
		{
			const string __id = "setcBarra.(Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setcBarraTrib_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetcBarraTrib_Ljava_lang_String_Handler ()
		{
			if (cb_setcBarraTrib_Ljava_lang_String_ == null)
				cb_setcBarraTrib_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_SetcBarraTrib_Ljava_lang_String_));
			return cb_setcBarraTrib_Ljava_lang_String_;
		}

		static void n_SetcBarraTrib_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Daruma.Framework.Mobile.Gne.Nfce.Xml.Classes.ProdAuxiliar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetcBarraTrib (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.daruma.framework.mobile.gne.nfce.xml.classes']/class[@name='ProdAuxiliar']/method[@name='setcBarraTrib' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setcBarraTrib", "(Ljava/lang/String;)V", "GetSetcBarraTrib_Ljava_lang_String_Handler")]
		public virtual unsafe void SetcBarraTrib (string p0)
		{
			const string __id = "setcBarraTrib.(Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setcBenef_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetcBenef_Ljava_lang_String_Handler ()
		{
			if (cb_setcBenef_Ljava_lang_String_ == null)
				cb_setcBenef_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_SetcBenef_Ljava_lang_String_));
			return cb_setcBenef_Ljava_lang_String_;
		}

		static void n_SetcBenef_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Daruma.Framework.Mobile.Gne.Nfce.Xml.Classes.ProdAuxiliar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetcBenef (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.daruma.framework.mobile.gne.nfce.xml.classes']/class[@name='ProdAuxiliar']/method[@name='setcBenef' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setcBenef", "(Ljava/lang/String;)V", "GetSetcBenef_Ljava_lang_String_Handler")]
		public virtual unsafe void SetcBenef (string p0)
		{
			const string __id = "setcBenef.(Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setcEAN_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetcEAN_Ljava_lang_String_Handler ()
		{
			if (cb_setcEAN_Ljava_lang_String_ == null)
				cb_setcEAN_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_SetcEAN_Ljava_lang_String_));
			return cb_setcEAN_Ljava_lang_String_;
		}

		static void n_SetcEAN_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Daruma.Framework.Mobile.Gne.Nfce.Xml.Classes.ProdAuxiliar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetcEAN (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.daruma.framework.mobile.gne.nfce.xml.classes']/class[@name='ProdAuxiliar']/method[@name='setcEAN' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setcEAN", "(Ljava/lang/String;)V", "GetSetcEAN_Ljava_lang_String_Handler")]
		public virtual unsafe void SetcEAN (string p0)
		{
			const string __id = "setcEAN.(Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setcEANTrib_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetcEANTrib_Ljava_lang_String_Handler ()
		{
			if (cb_setcEANTrib_Ljava_lang_String_ == null)
				cb_setcEANTrib_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_SetcEANTrib_Ljava_lang_String_));
			return cb_setcEANTrib_Ljava_lang_String_;
		}

		static void n_SetcEANTrib_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Daruma.Framework.Mobile.Gne.Nfce.Xml.Classes.ProdAuxiliar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetcEANTrib (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.daruma.framework.mobile.gne.nfce.xml.classes']/class[@name='ProdAuxiliar']/method[@name='setcEANTrib' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setcEANTrib", "(Ljava/lang/String;)V", "GetSetcEANTrib_Ljava_lang_String_Handler")]
		public virtual unsafe void SetcEANTrib (string p0)
		{
			const string __id = "setcEANTrib.(Ljava/lang/String;)V";
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