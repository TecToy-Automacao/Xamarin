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

namespace Com.Phi.Gertec.Sat.Serial {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.phi.gertec.sat.serial']/class[@name='ProbeTable']"
	[global::Android.Runtime.Register ("com/phi/gertec/sat/serial/ProbeTable", DoNotGenerateAcw=true)]
	public partial class ProbeTable : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/phi/gertec/sat/serial/ProbeTable", typeof (ProbeTable));

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

		protected ProbeTable (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.phi.gertec.sat.serial']/class[@name='ProbeTable']/constructor[@name='ProbeTable' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ProbeTable () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_addDriver_Ljava_lang_Class_;
#pragma warning disable 0169
		static Delegate GetAddDriver_Ljava_lang_Class_Handler ()
		{
			if (cb_addDriver_Ljava_lang_Class_ == null)
				cb_addDriver_Ljava_lang_Class_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_L (n_AddDriver_Ljava_lang_Class_));
			return cb_addDriver_Ljava_lang_Class_;
		}

		static IntPtr n_AddDriver_Ljava_lang_Class_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Phi.Gertec.Sat.Serial.ProbeTable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddDriver (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.phi.gertec.sat.serial']/class[@name='ProbeTable']/method[@name='addDriver' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;? extends com.phi.gertec.sat.serial.UsbSerialDriver&gt;']]"
		[Register ("addDriver", "(Ljava/lang/Class;)Lcom/phi/gertec/sat/serial/ProbeTable;", "GetAddDriver_Ljava_lang_Class_Handler")]
		public virtual unsafe global::Com.Phi.Gertec.Sat.Serial.ProbeTable AddDriver (global::Java.Lang.Class p0)
		{
			const string __id = "addDriver.(Ljava/lang/Class;)Lcom/phi/gertec/sat/serial/ProbeTable;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Phi.Gertec.Sat.Serial.ProbeTable> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate cb_addProduct_IILjava_lang_Class_;
#pragma warning disable 0169
		static Delegate GetAddProduct_IILjava_lang_Class_Handler ()
		{
			if (cb_addProduct_IILjava_lang_Class_ == null)
				cb_addProduct_IILjava_lang_Class_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIIL_L (n_AddProduct_IILjava_lang_Class_));
			return cb_addProduct_IILjava_lang_Class_;
		}

		static IntPtr n_AddProduct_IILjava_lang_Class_ (IntPtr jnienv, IntPtr native__this, int p0, int p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Phi.Gertec.Sat.Serial.ProbeTable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddProduct (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.phi.gertec.sat.serial']/class[@name='ProbeTable']/method[@name='addProduct' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.Class&lt;? extends com.phi.gertec.sat.serial.UsbSerialDriver&gt;']]"
		[Register ("addProduct", "(IILjava/lang/Class;)Lcom/phi/gertec/sat/serial/ProbeTable;", "GetAddProduct_IILjava_lang_Class_Handler")]
		public virtual unsafe global::Com.Phi.Gertec.Sat.Serial.ProbeTable AddProduct (int p0, int p1, global::Java.Lang.Class p2)
		{
			const string __id = "addProduct.(IILjava/lang/Class;)Lcom/phi/gertec/sat/serial/ProbeTable;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Phi.Gertec.Sat.Serial.ProbeTable> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p2);
			}
		}

		static Delegate cb_findDriver_II;
#pragma warning disable 0169
		static Delegate GetFindDriver_IIHandler ()
		{
			if (cb_findDriver_II == null)
				cb_findDriver_II = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPII_L (n_FindDriver_II));
			return cb_findDriver_II;
		}

		static IntPtr n_FindDriver_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Phi.Gertec.Sat.Serial.ProbeTable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.FindDriver (p0, p1));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.phi.gertec.sat.serial']/class[@name='ProbeTable']/method[@name='findDriver' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("findDriver", "(II)Ljava/lang/Class;", "GetFindDriver_IIHandler")]
		public virtual unsafe global::Java.Lang.Class FindDriver (int p0, int p1)
		{
			const string __id = "findDriver.(II)Ljava/lang/Class;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}