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

namespace Com.Orbbec.Astra {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.orbbec.astra']/class[@name='Plane']"
	[global::Android.Runtime.Register ("com/orbbec/astra/Plane", DoNotGenerateAcw=true)]
	public partial class Plane : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/orbbec/astra/Plane", typeof (Plane));

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

		protected Plane (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.orbbec.astra']/class[@name='Plane']/constructor[@name='Plane' and count(parameter)=4 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='float'] and parameter[4][@type='float']]"
		[Register (".ctor", "(FFFF)V", "")]
		public unsafe Plane (float p0, float p1, float p2, float p3) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(FFFF)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue (p3);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getA;
#pragma warning disable 0169
		static Delegate GetGetAHandler ()
		{
			if (cb_getA == null)
				cb_getA = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_F (n_GetA));
			return cb_getA;
		}

		static float n_GetA (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Orbbec.Astra.Plane> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetA ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.orbbec.astra']/class[@name='Plane']/method[@name='getA' and count(parameter)=0]"
		[Register ("getA", "()F", "GetGetAHandler")]
		public virtual unsafe float GetA ()
		{
			const string __id = "getA.()F";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_getB;
#pragma warning disable 0169
		static Delegate GetGetBHandler ()
		{
			if (cb_getB == null)
				cb_getB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_F (n_GetB));
			return cb_getB;
		}

		static float n_GetB (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Orbbec.Astra.Plane> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetB ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.orbbec.astra']/class[@name='Plane']/method[@name='getB' and count(parameter)=0]"
		[Register ("getB", "()F", "GetGetBHandler")]
		public virtual unsafe float GetB ()
		{
			const string __id = "getB.()F";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_getC;
#pragma warning disable 0169
		static Delegate GetGetCHandler ()
		{
			if (cb_getC == null)
				cb_getC = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_F (n_GetC));
			return cb_getC;
		}

		static float n_GetC (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Orbbec.Astra.Plane> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetC ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.orbbec.astra']/class[@name='Plane']/method[@name='getC' and count(parameter)=0]"
		[Register ("getC", "()F", "GetGetCHandler")]
		public virtual unsafe float GetC ()
		{
			const string __id = "getC.()F";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_getD;
#pragma warning disable 0169
		static Delegate GetGetDHandler ()
		{
			if (cb_getD == null)
				cb_getD = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_F (n_GetD));
			return cb_getD;
		}

		static float n_GetD (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Orbbec.Astra.Plane> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetD ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.orbbec.astra']/class[@name='Plane']/method[@name='getD' and count(parameter)=0]"
		[Register ("getD", "()F", "GetGetDHandler")]
		public virtual unsafe float GetD ()
		{
			const string __id = "getD.()F";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

	}
}