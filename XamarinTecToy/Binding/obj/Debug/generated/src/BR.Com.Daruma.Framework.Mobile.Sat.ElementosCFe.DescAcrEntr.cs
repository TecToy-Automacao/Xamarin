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

	// Metadata.xml XPath class reference: path="/api/package[@name='br.com.daruma.framework.mobile.sat.elementosCFe']/class[@name='DescAcrEntr']"
	[global::Android.Runtime.Register ("br/com/daruma/framework/mobile/sat/elementosCFe/DescAcrEntr", DoNotGenerateAcw=true)]
	public partial class DescAcrEntr : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("br/com/daruma/framework/mobile/sat/elementosCFe/DescAcrEntr", typeof (DescAcrEntr));

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

		protected DescAcrEntr (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='br.com.daruma.framework.mobile.sat.elementosCFe']/class[@name='DescAcrEntr']/constructor[@name='DescAcrEntr' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe DescAcrEntr (string p0, string p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_getvAcresSubtot;
#pragma warning disable 0169
		static Delegate GetGetvAcresSubtotHandler ()
		{
			if (cb_getvAcresSubtot == null)
				cb_getvAcresSubtot = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetvAcresSubtot));
			return cb_getvAcresSubtot;
		}

		static IntPtr n_GetvAcresSubtot (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Daruma.Framework.Mobile.Sat.ElementosCFe.DescAcrEntr> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.GetvAcresSubtot ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.daruma.framework.mobile.sat.elementosCFe']/class[@name='DescAcrEntr']/method[@name='getvAcresSubtot' and count(parameter)=0]"
		[Register ("getvAcresSubtot", "()Ljava/lang/String;", "GetGetvAcresSubtotHandler")]
		public virtual unsafe string GetvAcresSubtot ()
		{
			const string __id = "getvAcresSubtot.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getvDescSubtot;
#pragma warning disable 0169
		static Delegate GetGetvDescSubtotHandler ()
		{
			if (cb_getvDescSubtot == null)
				cb_getvDescSubtot = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetvDescSubtot));
			return cb_getvDescSubtot;
		}

		static IntPtr n_GetvDescSubtot (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Daruma.Framework.Mobile.Sat.ElementosCFe.DescAcrEntr> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.GetvDescSubtot ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.daruma.framework.mobile.sat.elementosCFe']/class[@name='DescAcrEntr']/method[@name='getvDescSubtot' and count(parameter)=0]"
		[Register ("getvDescSubtot", "()Ljava/lang/String;", "GetGetvDescSubtotHandler")]
		public virtual unsafe string GetvDescSubtot ()
		{
			const string __id = "getvDescSubtot.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setvAcresSubtot_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetvAcresSubtot_Ljava_lang_String_Handler ()
		{
			if (cb_setvAcresSubtot_Ljava_lang_String_ == null)
				cb_setvAcresSubtot_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_SetvAcresSubtot_Ljava_lang_String_));
			return cb_setvAcresSubtot_Ljava_lang_String_;
		}

		static void n_SetvAcresSubtot_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Daruma.Framework.Mobile.Sat.ElementosCFe.DescAcrEntr> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetvAcresSubtot (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.daruma.framework.mobile.sat.elementosCFe']/class[@name='DescAcrEntr']/method[@name='setvAcresSubtot' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setvAcresSubtot", "(Ljava/lang/String;)V", "GetSetvAcresSubtot_Ljava_lang_String_Handler")]
		public virtual unsafe void SetvAcresSubtot (string p0)
		{
			const string __id = "setvAcresSubtot.(Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setvDescSubtot_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetvDescSubtot_Ljava_lang_String_Handler ()
		{
			if (cb_setvDescSubtot_Ljava_lang_String_ == null)
				cb_setvDescSubtot_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_SetvDescSubtot_Ljava_lang_String_));
			return cb_setvDescSubtot_Ljava_lang_String_;
		}

		static void n_SetvDescSubtot_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Daruma.Framework.Mobile.Sat.ElementosCFe.DescAcrEntr> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetvDescSubtot (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.daruma.framework.mobile.sat.elementosCFe']/class[@name='DescAcrEntr']/method[@name='setvDescSubtot' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setvDescSubtot", "(Ljava/lang/String;)V", "GetSetvDescSubtot_Ljava_lang_String_Handler")]
		public virtual unsafe void SetvDescSubtot (string p0)
		{
			const string __id = "setvDescSubtot.(Ljava/lang/String;)V";
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