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

namespace BR.Com.Daruma.Framework.Mobile.Sat.ElementosCFe {

	// Metadata.xml XPath class reference: path="/api/package[@name='br.com.daruma.framework.mobile.sat.elementosCFe']/class[@name='Prod']"
	[global::Android.Runtime.Register ("br/com/daruma/framework/mobile/sat/elementosCFe/Prod", DoNotGenerateAcw=true)]
	public partial class Prod : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("br/com/daruma/framework/mobile/sat/elementosCFe/Prod", typeof (Prod));

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

		protected Prod (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='br.com.daruma.framework.mobile.sat.elementosCFe']/class[@name='Prod']/constructor[@name='Prod' and count(parameter)=11 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='java.lang.String'] and parameter[7][@type='java.lang.String'] and parameter[8][@type='java.lang.String'] and parameter[9][@type='java.lang.String'] and parameter[10][@type='java.lang.String'] and parameter[11][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe Prod (string p0, string p1, string p2, string p3, string p4, string p5, string p6, string p7, string p8, string p9, string p10) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			IntPtr native_p1 = JNIEnv.NewString ((string)p1);
			IntPtr native_p2 = JNIEnv.NewString ((string)p2);
			IntPtr native_p3 = JNIEnv.NewString ((string)p3);
			IntPtr native_p4 = JNIEnv.NewString ((string)p4);
			IntPtr native_p5 = JNIEnv.NewString ((string)p5);
			IntPtr native_p6 = JNIEnv.NewString ((string)p6);
			IntPtr native_p7 = JNIEnv.NewString ((string)p7);
			IntPtr native_p8 = JNIEnv.NewString ((string)p8);
			IntPtr native_p9 = JNIEnv.NewString ((string)p9);
			IntPtr native_p10 = JNIEnv.NewString ((string)p10);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [11];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (native_p3);
				__args [4] = new JniArgumentValue (native_p4);
				__args [5] = new JniArgumentValue (native_p5);
				__args [6] = new JniArgumentValue (native_p6);
				__args [7] = new JniArgumentValue (native_p7);
				__args [8] = new JniArgumentValue (native_p8);
				__args [9] = new JniArgumentValue (native_p9);
				__args [10] = new JniArgumentValue (native_p10);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
				JNIEnv.DeleteLocalRef (native_p4);
				JNIEnv.DeleteLocalRef (native_p5);
				JNIEnv.DeleteLocalRef (native_p6);
				JNIEnv.DeleteLocalRef (native_p7);
				JNIEnv.DeleteLocalRef (native_p8);
				JNIEnv.DeleteLocalRef (native_p9);
				JNIEnv.DeleteLocalRef (native_p10);
			}
		}

		static Delegate cb_getTipoDescAcr;
#pragma warning disable 0169
		static Delegate GetGetTipoDescAcrHandler ()
		{
			if (cb_getTipoDescAcr == null)
				cb_getTipoDescAcr = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetTipoDescAcr));
			return cb_getTipoDescAcr;
		}

		static IntPtr n_GetTipoDescAcr (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Daruma.Framework.Mobile.Sat.ElementosCFe.Prod> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.TipoDescAcr);
		}
#pragma warning restore 0169

		public virtual unsafe string TipoDescAcr {
			// Metadata.xml XPath method reference: path="/api/package[@name='br.com.daruma.framework.mobile.sat.elementosCFe']/class[@name='Prod']/method[@name='getTipoDescAcr' and count(parameter)=0]"
			[Register ("getTipoDescAcr", "()Ljava/lang/String;", "GetGetTipoDescAcrHandler")]
			get {
				const string __id = "getTipoDescAcr.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getValorTotalSemRateio;
#pragma warning disable 0169
		static Delegate GetGetValorTotalSemRateioHandler ()
		{
			if (cb_getValorTotalSemRateio == null)
				cb_getValorTotalSemRateio = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_D (n_GetValorTotalSemRateio));
			return cb_getValorTotalSemRateio;
		}

		static double n_GetValorTotalSemRateio (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Daruma.Framework.Mobile.Sat.ElementosCFe.Prod> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ValorTotalSemRateio;
		}
#pragma warning restore 0169

		public virtual unsafe double ValorTotalSemRateio {
			// Metadata.xml XPath method reference: path="/api/package[@name='br.com.daruma.framework.mobile.sat.elementosCFe']/class[@name='Prod']/method[@name='getValorTotalSemRateio' and count(parameter)=0]"
			[Register ("getValorTotalSemRateio", "()D", "GetGetValorTotalSemRateioHandler")]
			get {
				const string __id = "getValorTotalSemRateio.()D";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualDoubleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getqCom;
#pragma warning disable 0169
		static Delegate GetGetqComHandler ()
		{
			if (cb_getqCom == null)
				cb_getqCom = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetqCom));
			return cb_getqCom;
		}

		static IntPtr n_GetqCom (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Daruma.Framework.Mobile.Sat.ElementosCFe.Prod> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.GetqCom ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.daruma.framework.mobile.sat.elementosCFe']/class[@name='Prod']/method[@name='getqCom' and count(parameter)=0]"
		[Register ("getqCom", "()Ljava/lang/String;", "GetGetqComHandler")]
		public virtual unsafe string GetqCom ()
		{
			const string __id = "getqCom.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getvDesc;
#pragma warning disable 0169
		static Delegate GetGetvDescHandler ()
		{
			if (cb_getvDesc == null)
				cb_getvDesc = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetvDesc));
			return cb_getvDesc;
		}

		static IntPtr n_GetvDesc (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Daruma.Framework.Mobile.Sat.ElementosCFe.Prod> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.GetvDesc ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.daruma.framework.mobile.sat.elementosCFe']/class[@name='Prod']/method[@name='getvDesc' and count(parameter)=0]"
		[Register ("getvDesc", "()Ljava/lang/String;", "GetGetvDescHandler")]
		public virtual unsafe string GetvDesc ()
		{
			const string __id = "getvDesc.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getvItem;
#pragma warning disable 0169
		static Delegate GetGetvItemHandler ()
		{
			if (cb_getvItem == null)
				cb_getvItem = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetvItem));
			return cb_getvItem;
		}

		static IntPtr n_GetvItem (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Daruma.Framework.Mobile.Sat.ElementosCFe.Prod> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.GetvItem ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.daruma.framework.mobile.sat.elementosCFe']/class[@name='Prod']/method[@name='getvItem' and count(parameter)=0]"
		[Register ("getvItem", "()Ljava/lang/String;", "GetGetvItemHandler")]
		public virtual unsafe string GetvItem ()
		{
			const string __id = "getvItem.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getvOutro;
#pragma warning disable 0169
		static Delegate GetGetvOutroHandler ()
		{
			if (cb_getvOutro == null)
				cb_getvOutro = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetvOutro));
			return cb_getvOutro;
		}

		static IntPtr n_GetvOutro (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Daruma.Framework.Mobile.Sat.ElementosCFe.Prod> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.GetvOutro ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.daruma.framework.mobile.sat.elementosCFe']/class[@name='Prod']/method[@name='getvOutro' and count(parameter)=0]"
		[Register ("getvOutro", "()Ljava/lang/String;", "GetGetvOutroHandler")]
		public virtual unsafe string GetvOutro ()
		{
			const string __id = "getvOutro.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getvUnCom;
#pragma warning disable 0169
		static Delegate GetGetvUnComHandler ()
		{
			if (cb_getvUnCom == null)
				cb_getvUnCom = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetvUnCom));
			return cb_getvUnCom;
		}

		static IntPtr n_GetvUnCom (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Daruma.Framework.Mobile.Sat.ElementosCFe.Prod> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.GetvUnCom ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.daruma.framework.mobile.sat.elementosCFe']/class[@name='Prod']/method[@name='getvUnCom' and count(parameter)=0]"
		[Register ("getvUnCom", "()Ljava/lang/String;", "GetGetvUnComHandler")]
		public virtual unsafe string GetvUnCom ()
		{
			const string __id = "getvUnCom.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_limpaAuxiliares;
#pragma warning disable 0169
		static Delegate GetLimpaAuxiliaresHandler ()
		{
			if (cb_limpaAuxiliares == null)
				cb_limpaAuxiliares = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_LimpaAuxiliares));
			return cb_limpaAuxiliares;
		}

		static void n_LimpaAuxiliares (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Daruma.Framework.Mobile.Sat.ElementosCFe.Prod> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.LimpaAuxiliares ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.daruma.framework.mobile.sat.elementosCFe']/class[@name='Prod']/method[@name='limpaAuxiliares' and count(parameter)=0]"
		[Register ("limpaAuxiliares", "()V", "GetLimpaAuxiliaresHandler")]
		public virtual unsafe void LimpaAuxiliares ()
		{
			const string __id = "limpaAuxiliares.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_setDescAcresc_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetDescAcresc_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_setDescAcresc_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_setDescAcresc_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLLL_V (n_SetDescAcresc_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_));
			return cb_setDescAcresc_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_SetDescAcresc_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Daruma.Framework.Mobile.Sat.ElementosCFe.Prod> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.SetDescAcresc (p0, p1, p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.daruma.framework.mobile.sat.elementosCFe']/class[@name='Prod']/method[@name='setDescAcresc' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("setDescAcresc", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "GetSetDescAcresc_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void SetDescAcresc (string p0, string p1, string p2)
		{
			const string __id = "setDescAcresc.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			IntPtr native_p1 = JNIEnv.NewString ((string)p1);
			IntPtr native_p2 = JNIEnv.NewString ((string)p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_setRateio_DLjava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetRateio_DLjava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_setRateio_DLjava_lang_String_Ljava_lang_String_ == null)
				cb_setRateio_DLjava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPDLL_V (n_SetRateio_DLjava_lang_String_Ljava_lang_String_));
			return cb_setRateio_DLjava_lang_String_Ljava_lang_String_;
		}

		static void n_SetRateio_DLjava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, double p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Daruma.Framework.Mobile.Sat.ElementosCFe.Prod> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.SetRateio (p0, p1, p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.daruma.framework.mobile.sat.elementosCFe']/class[@name='Prod']/method[@name='setRateio' and count(parameter)=3 and parameter[1][@type='double'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("setRateio", "(DLjava/lang/String;Ljava/lang/String;)V", "GetSetRateio_DLjava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void SetRateio (double p0, string p1, string p2)
		{
			const string __id = "setRateio.(DLjava/lang/String;Ljava/lang/String;)V";
			IntPtr native_p1 = JNIEnv.NewString ((string)p1);
			IntPtr native_p2 = JNIEnv.NewString ((string)p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

	}
}