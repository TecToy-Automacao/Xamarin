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

	// Metadata.xml XPath class reference: path="/api/package[@name='br.com.daruma.framework.mobile.sat.impostos']/class[@name='Pis']"
	[global::Android.Runtime.Register ("br/com/daruma/framework/mobile/sat/impostos/Pis", DoNotGenerateAcw=true)]
	public partial class Pis : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("br/com/daruma/framework/mobile/sat/impostos/Pis", typeof (Pis));

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

		protected Pis (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='br.com.daruma.framework.mobile.sat.impostos']/class[@name='Pis']/constructor[@name='Pis' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Pis () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='br.com.daruma.framework.mobile.sat.impostos']/class[@name='Pis']/constructor[@name='Pis' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register (".ctor", "(Z)V", "")]
		public unsafe Pis (bool p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='br.com.daruma.framework.mobile.sat.impostos']/class[@name='Pis']/constructor[@name='Pis' and count(parameter)=1 and parameter[1][@type='br.com.daruma.framework.mobile.sat.impostos.Pisaliq']]"
		[Register (".ctor", "(Lbr/com/daruma/framework/mobile/sat/impostos/Pisaliq;)V", "")]
		public unsafe Pis (global::BR.Com.Daruma.Framework.Mobile.Sat.Impostos.Pisaliq p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lbr/com/daruma/framework/mobile/sat/impostos/Pisaliq;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='br.com.daruma.framework.mobile.sat.impostos']/class[@name='Pis']/constructor[@name='Pis' and count(parameter)=1 and parameter[1][@type='br.com.daruma.framework.mobile.sat.impostos.Pisnt']]"
		[Register (".ctor", "(Lbr/com/daruma/framework/mobile/sat/impostos/Pisnt;)V", "")]
		public unsafe Pis (global::BR.Com.Daruma.Framework.Mobile.Sat.Impostos.Pisnt p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lbr/com/daruma/framework/mobile/sat/impostos/Pisnt;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='br.com.daruma.framework.mobile.sat.impostos']/class[@name='Pis']/constructor[@name='Pis' and count(parameter)=1 and parameter[1][@type='br.com.daruma.framework.mobile.sat.impostos.Pisoutr']]"
		[Register (".ctor", "(Lbr/com/daruma/framework/mobile/sat/impostos/Pisoutr;)V", "")]
		public unsafe Pis (global::BR.Com.Daruma.Framework.Mobile.Sat.Impostos.Pisoutr p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lbr/com/daruma/framework/mobile/sat/impostos/Pisoutr;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='br.com.daruma.framework.mobile.sat.impostos']/class[@name='Pis']/constructor[@name='Pis' and count(parameter)=1 and parameter[1][@type='br.com.daruma.framework.mobile.sat.impostos.Pisqtde']]"
		[Register (".ctor", "(Lbr/com/daruma/framework/mobile/sat/impostos/Pisqtde;)V", "")]
		public unsafe Pis (global::BR.Com.Daruma.Framework.Mobile.Sat.Impostos.Pisqtde p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lbr/com/daruma/framework/mobile/sat/impostos/Pisqtde;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='br.com.daruma.framework.mobile.sat.impostos']/class[@name='Pis']/constructor[@name='Pis' and count(parameter)=1 and parameter[1][@type='br.com.daruma.framework.mobile.sat.impostos.Pissn']]"
		[Register (".ctor", "(Lbr/com/daruma/framework/mobile/sat/impostos/Pissn;)V", "")]
		public unsafe Pis (global::BR.Com.Daruma.Framework.Mobile.Sat.Impostos.Pissn p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lbr/com/daruma/framework/mobile/sat/impostos/Pissn;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='br.com.daruma.framework.mobile.sat.impostos']/class[@name='Pis']/constructor[@name='Pis' and count(parameter)=1 and parameter[1][@type='br.com.daruma.framework.mobile.sat.impostos.Pisst']]"
		[Register (".ctor", "(Lbr/com/daruma/framework/mobile/sat/impostos/Pisst;)V", "")]
		public unsafe Pis (global::BR.Com.Daruma.Framework.Mobile.Sat.Impostos.Pisst p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lbr/com/daruma/framework/mobile/sat/impostos/Pisst;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate cb_getPISALIQ;
#pragma warning disable 0169
		static Delegate GetGetPISALIQHandler ()
		{
			if (cb_getPISALIQ == null)
				cb_getPISALIQ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetPISALIQ));
			return cb_getPISALIQ;
		}

		static IntPtr n_GetPISALIQ (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Daruma.Framework.Mobile.Sat.Impostos.Pis> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PISALIQ);
		}
#pragma warning restore 0169

		static Delegate cb_setPISALIQ_Lbr_com_daruma_framework_mobile_sat_impostos_Pisaliq_;
#pragma warning disable 0169
		static Delegate GetSetPISALIQ_Lbr_com_daruma_framework_mobile_sat_impostos_Pisaliq_Handler ()
		{
			if (cb_setPISALIQ_Lbr_com_daruma_framework_mobile_sat_impostos_Pisaliq_ == null)
				cb_setPISALIQ_Lbr_com_daruma_framework_mobile_sat_impostos_Pisaliq_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_SetPISALIQ_Lbr_com_daruma_framework_mobile_sat_impostos_Pisaliq_));
			return cb_setPISALIQ_Lbr_com_daruma_framework_mobile_sat_impostos_Pisaliq_;
		}

		static void n_SetPISALIQ_Lbr_com_daruma_framework_mobile_sat_impostos_Pisaliq_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Daruma.Framework.Mobile.Sat.Impostos.Pis> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::BR.Com.Daruma.Framework.Mobile.Sat.Impostos.Pisaliq> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PISALIQ = p0;
		}
#pragma warning restore 0169

		public virtual unsafe global::BR.Com.Daruma.Framework.Mobile.Sat.Impostos.Pisaliq PISALIQ {
			// Metadata.xml XPath method reference: path="/api/package[@name='br.com.daruma.framework.mobile.sat.impostos']/class[@name='Pis']/method[@name='getPISALIQ' and count(parameter)=0]"
			[Register ("getPISALIQ", "()Lbr/com/daruma/framework/mobile/sat/impostos/Pisaliq;", "GetGetPISALIQHandler")]
			get {
				const string __id = "getPISALIQ.()Lbr/com/daruma/framework/mobile/sat/impostos/Pisaliq;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::BR.Com.Daruma.Framework.Mobile.Sat.Impostos.Pisaliq> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='br.com.daruma.framework.mobile.sat.impostos']/class[@name='Pis']/method[@name='setPISALIQ' and count(parameter)=1 and parameter[1][@type='br.com.daruma.framework.mobile.sat.impostos.Pisaliq']]"
			[Register ("setPISALIQ", "(Lbr/com/daruma/framework/mobile/sat/impostos/Pisaliq;)V", "GetSetPISALIQ_Lbr_com_daruma_framework_mobile_sat_impostos_Pisaliq_Handler")]
			set {
				const string __id = "setPISALIQ.(Lbr/com/daruma/framework/mobile/sat/impostos/Pisaliq;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		static Delegate cb_getPISNT;
#pragma warning disable 0169
		static Delegate GetGetPISNTHandler ()
		{
			if (cb_getPISNT == null)
				cb_getPISNT = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetPISNT));
			return cb_getPISNT;
		}

		static IntPtr n_GetPISNT (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Daruma.Framework.Mobile.Sat.Impostos.Pis> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PISNT);
		}
#pragma warning restore 0169

		static Delegate cb_setPISNT_Lbr_com_daruma_framework_mobile_sat_impostos_Pisnt_;
#pragma warning disable 0169
		static Delegate GetSetPISNT_Lbr_com_daruma_framework_mobile_sat_impostos_Pisnt_Handler ()
		{
			if (cb_setPISNT_Lbr_com_daruma_framework_mobile_sat_impostos_Pisnt_ == null)
				cb_setPISNT_Lbr_com_daruma_framework_mobile_sat_impostos_Pisnt_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_SetPISNT_Lbr_com_daruma_framework_mobile_sat_impostos_Pisnt_));
			return cb_setPISNT_Lbr_com_daruma_framework_mobile_sat_impostos_Pisnt_;
		}

		static void n_SetPISNT_Lbr_com_daruma_framework_mobile_sat_impostos_Pisnt_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Daruma.Framework.Mobile.Sat.Impostos.Pis> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::BR.Com.Daruma.Framework.Mobile.Sat.Impostos.Pisnt> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PISNT = p0;
		}
#pragma warning restore 0169

		public virtual unsafe global::BR.Com.Daruma.Framework.Mobile.Sat.Impostos.Pisnt PISNT {
			// Metadata.xml XPath method reference: path="/api/package[@name='br.com.daruma.framework.mobile.sat.impostos']/class[@name='Pis']/method[@name='getPISNT' and count(parameter)=0]"
			[Register ("getPISNT", "()Lbr/com/daruma/framework/mobile/sat/impostos/Pisnt;", "GetGetPISNTHandler")]
			get {
				const string __id = "getPISNT.()Lbr/com/daruma/framework/mobile/sat/impostos/Pisnt;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::BR.Com.Daruma.Framework.Mobile.Sat.Impostos.Pisnt> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='br.com.daruma.framework.mobile.sat.impostos']/class[@name='Pis']/method[@name='setPISNT' and count(parameter)=1 and parameter[1][@type='br.com.daruma.framework.mobile.sat.impostos.Pisnt']]"
			[Register ("setPISNT", "(Lbr/com/daruma/framework/mobile/sat/impostos/Pisnt;)V", "GetSetPISNT_Lbr_com_daruma_framework_mobile_sat_impostos_Pisnt_Handler")]
			set {
				const string __id = "setPISNT.(Lbr/com/daruma/framework/mobile/sat/impostos/Pisnt;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		static Delegate cb_getPISOUTR;
#pragma warning disable 0169
		static Delegate GetGetPISOUTRHandler ()
		{
			if (cb_getPISOUTR == null)
				cb_getPISOUTR = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetPISOUTR));
			return cb_getPISOUTR;
		}

		static IntPtr n_GetPISOUTR (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Daruma.Framework.Mobile.Sat.Impostos.Pis> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PISOUTR);
		}
#pragma warning restore 0169

		static Delegate cb_setPISOUTR_Lbr_com_daruma_framework_mobile_sat_impostos_Pisoutr_;
#pragma warning disable 0169
		static Delegate GetSetPISOUTR_Lbr_com_daruma_framework_mobile_sat_impostos_Pisoutr_Handler ()
		{
			if (cb_setPISOUTR_Lbr_com_daruma_framework_mobile_sat_impostos_Pisoutr_ == null)
				cb_setPISOUTR_Lbr_com_daruma_framework_mobile_sat_impostos_Pisoutr_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_SetPISOUTR_Lbr_com_daruma_framework_mobile_sat_impostos_Pisoutr_));
			return cb_setPISOUTR_Lbr_com_daruma_framework_mobile_sat_impostos_Pisoutr_;
		}

		static void n_SetPISOUTR_Lbr_com_daruma_framework_mobile_sat_impostos_Pisoutr_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Daruma.Framework.Mobile.Sat.Impostos.Pis> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::BR.Com.Daruma.Framework.Mobile.Sat.Impostos.Pisoutr> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PISOUTR = p0;
		}
#pragma warning restore 0169

		public virtual unsafe global::BR.Com.Daruma.Framework.Mobile.Sat.Impostos.Pisoutr PISOUTR {
			// Metadata.xml XPath method reference: path="/api/package[@name='br.com.daruma.framework.mobile.sat.impostos']/class[@name='Pis']/method[@name='getPISOUTR' and count(parameter)=0]"
			[Register ("getPISOUTR", "()Lbr/com/daruma/framework/mobile/sat/impostos/Pisoutr;", "GetGetPISOUTRHandler")]
			get {
				const string __id = "getPISOUTR.()Lbr/com/daruma/framework/mobile/sat/impostos/Pisoutr;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::BR.Com.Daruma.Framework.Mobile.Sat.Impostos.Pisoutr> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='br.com.daruma.framework.mobile.sat.impostos']/class[@name='Pis']/method[@name='setPISOUTR' and count(parameter)=1 and parameter[1][@type='br.com.daruma.framework.mobile.sat.impostos.Pisoutr']]"
			[Register ("setPISOUTR", "(Lbr/com/daruma/framework/mobile/sat/impostos/Pisoutr;)V", "GetSetPISOUTR_Lbr_com_daruma_framework_mobile_sat_impostos_Pisoutr_Handler")]
			set {
				const string __id = "setPISOUTR.(Lbr/com/daruma/framework/mobile/sat/impostos/Pisoutr;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		static Delegate cb_getPISQTDE;
#pragma warning disable 0169
		static Delegate GetGetPISQTDEHandler ()
		{
			if (cb_getPISQTDE == null)
				cb_getPISQTDE = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetPISQTDE));
			return cb_getPISQTDE;
		}

		static IntPtr n_GetPISQTDE (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Daruma.Framework.Mobile.Sat.Impostos.Pis> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PISQTDE);
		}
#pragma warning restore 0169

		static Delegate cb_setPISQTDE_Lbr_com_daruma_framework_mobile_sat_impostos_Pisqtde_;
#pragma warning disable 0169
		static Delegate GetSetPISQTDE_Lbr_com_daruma_framework_mobile_sat_impostos_Pisqtde_Handler ()
		{
			if (cb_setPISQTDE_Lbr_com_daruma_framework_mobile_sat_impostos_Pisqtde_ == null)
				cb_setPISQTDE_Lbr_com_daruma_framework_mobile_sat_impostos_Pisqtde_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_SetPISQTDE_Lbr_com_daruma_framework_mobile_sat_impostos_Pisqtde_));
			return cb_setPISQTDE_Lbr_com_daruma_framework_mobile_sat_impostos_Pisqtde_;
		}

		static void n_SetPISQTDE_Lbr_com_daruma_framework_mobile_sat_impostos_Pisqtde_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Daruma.Framework.Mobile.Sat.Impostos.Pis> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::BR.Com.Daruma.Framework.Mobile.Sat.Impostos.Pisqtde> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PISQTDE = p0;
		}
#pragma warning restore 0169

		public virtual unsafe global::BR.Com.Daruma.Framework.Mobile.Sat.Impostos.Pisqtde PISQTDE {
			// Metadata.xml XPath method reference: path="/api/package[@name='br.com.daruma.framework.mobile.sat.impostos']/class[@name='Pis']/method[@name='getPISQTDE' and count(parameter)=0]"
			[Register ("getPISQTDE", "()Lbr/com/daruma/framework/mobile/sat/impostos/Pisqtde;", "GetGetPISQTDEHandler")]
			get {
				const string __id = "getPISQTDE.()Lbr/com/daruma/framework/mobile/sat/impostos/Pisqtde;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::BR.Com.Daruma.Framework.Mobile.Sat.Impostos.Pisqtde> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='br.com.daruma.framework.mobile.sat.impostos']/class[@name='Pis']/method[@name='setPISQTDE' and count(parameter)=1 and parameter[1][@type='br.com.daruma.framework.mobile.sat.impostos.Pisqtde']]"
			[Register ("setPISQTDE", "(Lbr/com/daruma/framework/mobile/sat/impostos/Pisqtde;)V", "GetSetPISQTDE_Lbr_com_daruma_framework_mobile_sat_impostos_Pisqtde_Handler")]
			set {
				const string __id = "setPISQTDE.(Lbr/com/daruma/framework/mobile/sat/impostos/Pisqtde;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		static Delegate cb_getPISSN;
#pragma warning disable 0169
		static Delegate GetGetPISSNHandler ()
		{
			if (cb_getPISSN == null)
				cb_getPISSN = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetPISSN));
			return cb_getPISSN;
		}

		static IntPtr n_GetPISSN (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Daruma.Framework.Mobile.Sat.Impostos.Pis> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PISSN);
		}
#pragma warning restore 0169

		static Delegate cb_setPISSN_Lbr_com_daruma_framework_mobile_sat_impostos_Pissn_;
#pragma warning disable 0169
		static Delegate GetSetPISSN_Lbr_com_daruma_framework_mobile_sat_impostos_Pissn_Handler ()
		{
			if (cb_setPISSN_Lbr_com_daruma_framework_mobile_sat_impostos_Pissn_ == null)
				cb_setPISSN_Lbr_com_daruma_framework_mobile_sat_impostos_Pissn_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_SetPISSN_Lbr_com_daruma_framework_mobile_sat_impostos_Pissn_));
			return cb_setPISSN_Lbr_com_daruma_framework_mobile_sat_impostos_Pissn_;
		}

		static void n_SetPISSN_Lbr_com_daruma_framework_mobile_sat_impostos_Pissn_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Daruma.Framework.Mobile.Sat.Impostos.Pis> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::BR.Com.Daruma.Framework.Mobile.Sat.Impostos.Pissn> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PISSN = p0;
		}
#pragma warning restore 0169

		public virtual unsafe global::BR.Com.Daruma.Framework.Mobile.Sat.Impostos.Pissn PISSN {
			// Metadata.xml XPath method reference: path="/api/package[@name='br.com.daruma.framework.mobile.sat.impostos']/class[@name='Pis']/method[@name='getPISSN' and count(parameter)=0]"
			[Register ("getPISSN", "()Lbr/com/daruma/framework/mobile/sat/impostos/Pissn;", "GetGetPISSNHandler")]
			get {
				const string __id = "getPISSN.()Lbr/com/daruma/framework/mobile/sat/impostos/Pissn;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::BR.Com.Daruma.Framework.Mobile.Sat.Impostos.Pissn> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='br.com.daruma.framework.mobile.sat.impostos']/class[@name='Pis']/method[@name='setPISSN' and count(parameter)=1 and parameter[1][@type='br.com.daruma.framework.mobile.sat.impostos.Pissn']]"
			[Register ("setPISSN", "(Lbr/com/daruma/framework/mobile/sat/impostos/Pissn;)V", "GetSetPISSN_Lbr_com_daruma_framework_mobile_sat_impostos_Pissn_Handler")]
			set {
				const string __id = "setPISSN.(Lbr/com/daruma/framework/mobile/sat/impostos/Pissn;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		static Delegate cb_getPISST;
#pragma warning disable 0169
		static Delegate GetGetPISSTHandler ()
		{
			if (cb_getPISST == null)
				cb_getPISST = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetPISST));
			return cb_getPISST;
		}

		static IntPtr n_GetPISST (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Daruma.Framework.Mobile.Sat.Impostos.Pis> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PISST);
		}
#pragma warning restore 0169

		static Delegate cb_setPISST_Lbr_com_daruma_framework_mobile_sat_impostos_Pisst_;
#pragma warning disable 0169
		static Delegate GetSetPISST_Lbr_com_daruma_framework_mobile_sat_impostos_Pisst_Handler ()
		{
			if (cb_setPISST_Lbr_com_daruma_framework_mobile_sat_impostos_Pisst_ == null)
				cb_setPISST_Lbr_com_daruma_framework_mobile_sat_impostos_Pisst_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_SetPISST_Lbr_com_daruma_framework_mobile_sat_impostos_Pisst_));
			return cb_setPISST_Lbr_com_daruma_framework_mobile_sat_impostos_Pisst_;
		}

		static void n_SetPISST_Lbr_com_daruma_framework_mobile_sat_impostos_Pisst_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Daruma.Framework.Mobile.Sat.Impostos.Pis> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::BR.Com.Daruma.Framework.Mobile.Sat.Impostos.Pisst> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PISST = p0;
		}
#pragma warning restore 0169

		public virtual unsafe global::BR.Com.Daruma.Framework.Mobile.Sat.Impostos.Pisst PISST {
			// Metadata.xml XPath method reference: path="/api/package[@name='br.com.daruma.framework.mobile.sat.impostos']/class[@name='Pis']/method[@name='getPISST' and count(parameter)=0]"
			[Register ("getPISST", "()Lbr/com/daruma/framework/mobile/sat/impostos/Pisst;", "GetGetPISSTHandler")]
			get {
				const string __id = "getPISST.()Lbr/com/daruma/framework/mobile/sat/impostos/Pisst;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::BR.Com.Daruma.Framework.Mobile.Sat.Impostos.Pisst> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='br.com.daruma.framework.mobile.sat.impostos']/class[@name='Pis']/method[@name='setPISST' and count(parameter)=1 and parameter[1][@type='br.com.daruma.framework.mobile.sat.impostos.Pisst']]"
			[Register ("setPISST", "(Lbr/com/daruma/framework/mobile/sat/impostos/Pisst;)V", "GetSetPISST_Lbr_com_daruma_framework_mobile_sat_impostos_Pisst_Handler")]
			set {
				const string __id = "setPISST.(Lbr/com/daruma/framework/mobile/sat/impostos/Pisst;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		static Delegate cb_completaDadosImposto_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetCompletaDadosImposto_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_completaDadosImposto_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_completaDadosImposto_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_V (n_CompletaDadosImposto_Ljava_lang_String_Ljava_lang_String_));
			return cb_completaDadosImposto_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_CompletaDadosImposto_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Daruma.Framework.Mobile.Sat.Impostos.Pis> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.CompletaDadosImposto (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.daruma.framework.mobile.sat.impostos']/class[@name='Pis']/method[@name='completaDadosImposto' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("completaDadosImposto", "(Ljava/lang/String;Ljava/lang/String;)V", "GetCompletaDadosImposto_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void CompletaDadosImposto (string p0, string p1)
		{
			const string __id = "completaDadosImposto.(Ljava/lang/String;Ljava/lang/String;)V";
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
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Daruma.Framework.Mobile.Sat.Impostos.Pis> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CompletaXml ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.daruma.framework.mobile.sat.impostos']/class[@name='Pis']/method[@name='completaXml' and count(parameter)=0]"
		[Register ("completaXml", "()V", "GetCompletaXmlHandler")]
		public virtual unsafe void CompletaXml ()
		{
			const string __id = "completaXml.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}