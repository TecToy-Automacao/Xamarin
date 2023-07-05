using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Phi.Gertec.Sat.Serial {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.phi.gertec.sat.serial']/interface[@name='UsbSerialDriver']"
	[Register ("com/phi/gertec/sat/serial/UsbSerialDriver", "", "Com.Phi.Gertec.Sat.Serial.IUsbSerialDriverInvoker")]
	public partial interface IUsbSerialDriver : IJavaObject, IJavaPeerable {
		global::Android.Hardware.Usb.UsbDevice Device {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.phi.gertec.sat.serial']/interface[@name='UsbSerialDriver']/method[@name='getDevice' and count(parameter)=0]"
			[Register ("getDevice", "()Landroid/hardware/usb/UsbDevice;", "GetGetDeviceHandler:Com.Phi.Gertec.Sat.Serial.IUsbSerialDriverInvoker, Binding")]
			get; 
		}

		global::System.Collections.Generic.IList<global::Com.Phi.Gertec.Sat.Serial.IUsbSerialPort> Ports {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.phi.gertec.sat.serial']/interface[@name='UsbSerialDriver']/method[@name='getPorts' and count(parameter)=0]"
			[Register ("getPorts", "()Ljava/util/List;", "GetGetPortsHandler:Com.Phi.Gertec.Sat.Serial.IUsbSerialDriverInvoker, Binding")]
			get; 
		}

	}

	[global::Android.Runtime.Register ("com/phi/gertec/sat/serial/UsbSerialDriver", DoNotGenerateAcw=true)]
	internal partial class IUsbSerialDriverInvoker : global::Java.Lang.Object, IUsbSerialDriver {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/phi/gertec/sat/serial/UsbSerialDriver", typeof (IUsbSerialDriverInvoker));

		static IntPtr java_class_ref {
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
			get { return class_ref; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static IUsbSerialDriver GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IUsbSerialDriver> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.phi.gertec.sat.serial.UsbSerialDriver'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IUsbSerialDriverInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getDevice;
#pragma warning disable 0169
		static Delegate GetGetDeviceHandler ()
		{
			if (cb_getDevice == null)
				cb_getDevice = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetDevice));
			return cb_getDevice;
		}

		static IntPtr n_GetDevice (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Phi.Gertec.Sat.Serial.IUsbSerialDriver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Device);
		}
#pragma warning restore 0169

		IntPtr id_getDevice;
		public unsafe global::Android.Hardware.Usb.UsbDevice Device {
			get {
				if (id_getDevice == IntPtr.Zero)
					id_getDevice = JNIEnv.GetMethodID (class_ref, "getDevice", "()Landroid/hardware/usb/UsbDevice;");
				return global::Java.Lang.Object.GetObject<global::Android.Hardware.Usb.UsbDevice> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDevice), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getPorts;
#pragma warning disable 0169
		static Delegate GetGetPortsHandler ()
		{
			if (cb_getPorts == null)
				cb_getPorts = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetPorts));
			return cb_getPorts;
		}

		static IntPtr n_GetPorts (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Phi.Gertec.Sat.Serial.IUsbSerialDriver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Phi.Gertec.Sat.Serial.IUsbSerialPort>.ToLocalJniHandle (__this.Ports);
		}
#pragma warning restore 0169

		IntPtr id_getPorts;
		public unsafe global::System.Collections.Generic.IList<global::Com.Phi.Gertec.Sat.Serial.IUsbSerialPort> Ports {
			get {
				if (id_getPorts == IntPtr.Zero)
					id_getPorts = JNIEnv.GetMethodID (class_ref, "getPorts", "()Ljava/util/List;");
				return global::Android.Runtime.JavaList<global::Com.Phi.Gertec.Sat.Serial.IUsbSerialPort>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPorts), JniHandleOwnership.TransferLocalRef);
			}
		}

	}
}
