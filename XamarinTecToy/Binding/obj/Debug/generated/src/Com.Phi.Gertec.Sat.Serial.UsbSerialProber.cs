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

	// Metadata.xml XPath class reference: path="/api/package[@name='com.phi.gertec.sat.serial']/class[@name='UsbSerialProber']"
	[global::Android.Runtime.Register ("com/phi/gertec/sat/serial/UsbSerialProber", DoNotGenerateAcw=true)]
	public partial class UsbSerialProber : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/phi/gertec/sat/serial/UsbSerialProber", typeof (UsbSerialProber));

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

		protected UsbSerialProber (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.phi.gertec.sat.serial']/class[@name='UsbSerialProber']/constructor[@name='UsbSerialProber' and count(parameter)=1 and parameter[1][@type='com.phi.gertec.sat.serial.ProbeTable']]"
		[Register (".ctor", "(Lcom/phi/gertec/sat/serial/ProbeTable;)V", "")]
		public unsafe UsbSerialProber (global::Com.Phi.Gertec.Sat.Serial.ProbeTable p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/phi/gertec/sat/serial/ProbeTable;)V";

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

		public static unsafe global::Com.Phi.Gertec.Sat.Serial.ProbeTable DefaultProbeTable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.phi.gertec.sat.serial']/class[@name='UsbSerialProber']/method[@name='getDefaultProbeTable' and count(parameter)=0]"
			[Register ("getDefaultProbeTable", "()Lcom/phi/gertec/sat/serial/ProbeTable;", "")]
			get {
				const string __id = "getDefaultProbeTable.()Lcom/phi/gertec/sat/serial/ProbeTable;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Com.Phi.Gertec.Sat.Serial.ProbeTable> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public static unsafe global::Com.Phi.Gertec.Sat.Serial.UsbSerialProber DefaultProber {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.phi.gertec.sat.serial']/class[@name='UsbSerialProber']/method[@name='getDefaultProber' and count(parameter)=0]"
			[Register ("getDefaultProber", "()Lcom/phi/gertec/sat/serial/UsbSerialProber;", "")]
			get {
				const string __id = "getDefaultProber.()Lcom/phi/gertec/sat/serial/UsbSerialProber;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Com.Phi.Gertec.Sat.Serial.UsbSerialProber> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_findAllDrivers_Landroid_hardware_usb_UsbManager_;
#pragma warning disable 0169
		static Delegate GetFindAllDrivers_Landroid_hardware_usb_UsbManager_Handler ()
		{
			if (cb_findAllDrivers_Landroid_hardware_usb_UsbManager_ == null)
				cb_findAllDrivers_Landroid_hardware_usb_UsbManager_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_L (n_FindAllDrivers_Landroid_hardware_usb_UsbManager_));
			return cb_findAllDrivers_Landroid_hardware_usb_UsbManager_;
		}

		static IntPtr n_FindAllDrivers_Landroid_hardware_usb_UsbManager_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Phi.Gertec.Sat.Serial.UsbSerialProber> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Hardware.Usb.UsbManager> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Com.Phi.Gertec.Sat.Serial.IUsbSerialDriver>.ToLocalJniHandle (__this.FindAllDrivers (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.phi.gertec.sat.serial']/class[@name='UsbSerialProber']/method[@name='findAllDrivers' and count(parameter)=1 and parameter[1][@type='android.hardware.usb.UsbManager']]"
		[Register ("findAllDrivers", "(Landroid/hardware/usb/UsbManager;)Ljava/util/List;", "GetFindAllDrivers_Landroid_hardware_usb_UsbManager_Handler")]
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Phi.Gertec.Sat.Serial.IUsbSerialDriver> FindAllDrivers (global::Android.Hardware.Usb.UsbManager p0)
		{
			const string __id = "findAllDrivers.(Landroid/hardware/usb/UsbManager;)Ljava/util/List;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaList<global::Com.Phi.Gertec.Sat.Serial.IUsbSerialDriver>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate cb_probeDevice_Landroid_hardware_usb_UsbDevice_;
#pragma warning disable 0169
		static Delegate GetProbeDevice_Landroid_hardware_usb_UsbDevice_Handler ()
		{
			if (cb_probeDevice_Landroid_hardware_usb_UsbDevice_ == null)
				cb_probeDevice_Landroid_hardware_usb_UsbDevice_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_L (n_ProbeDevice_Landroid_hardware_usb_UsbDevice_));
			return cb_probeDevice_Landroid_hardware_usb_UsbDevice_;
		}

		static IntPtr n_ProbeDevice_Landroid_hardware_usb_UsbDevice_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Phi.Gertec.Sat.Serial.UsbSerialProber> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Hardware.Usb.UsbDevice> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ProbeDevice (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.phi.gertec.sat.serial']/class[@name='UsbSerialProber']/method[@name='probeDevice' and count(parameter)=1 and parameter[1][@type='android.hardware.usb.UsbDevice']]"
		[Register ("probeDevice", "(Landroid/hardware/usb/UsbDevice;)Lcom/phi/gertec/sat/serial/UsbSerialDriver;", "GetProbeDevice_Landroid_hardware_usb_UsbDevice_Handler")]
		public virtual unsafe global::Com.Phi.Gertec.Sat.Serial.IUsbSerialDriver ProbeDevice (global::Android.Hardware.Usb.UsbDevice p0)
		{
			const string __id = "probeDevice.(Landroid/hardware/usb/UsbDevice;)Lcom/phi/gertec/sat/serial/UsbSerialDriver;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Phi.Gertec.Sat.Serial.IUsbSerialDriver> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

	}
}