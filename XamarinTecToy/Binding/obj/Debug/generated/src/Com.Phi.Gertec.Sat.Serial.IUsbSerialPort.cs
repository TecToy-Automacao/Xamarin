using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Phi.Gertec.Sat.Serial {

	[Register ("com/phi/gertec/sat/serial/UsbSerialPort", DoNotGenerateAcw=true)]
	public abstract class UsbSerialPort : Java.Lang.Object {
		internal UsbSerialPort ()
		{
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.phi.gertec.sat.serial']/interface[@name='UsbSerialPort']/field[@name='DATABITS_5']"
		[Register ("DATABITS_5")]
		public const int Databits5 = (int) 5;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.phi.gertec.sat.serial']/interface[@name='UsbSerialPort']/field[@name='DATABITS_6']"
		[Register ("DATABITS_6")]
		public const int Databits6 = (int) 6;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.phi.gertec.sat.serial']/interface[@name='UsbSerialPort']/field[@name='DATABITS_7']"
		[Register ("DATABITS_7")]
		public const int Databits7 = (int) 7;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.phi.gertec.sat.serial']/interface[@name='UsbSerialPort']/field[@name='DATABITS_8']"
		[Register ("DATABITS_8")]
		public const int Databits8 = (int) 8;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.phi.gertec.sat.serial']/interface[@name='UsbSerialPort']/field[@name='FLOWCONTROL_NONE']"
		[Register ("FLOWCONTROL_NONE")]
		public const int FlowcontrolNone = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.phi.gertec.sat.serial']/interface[@name='UsbSerialPort']/field[@name='FLOWCONTROL_RTSCTS_IN']"
		[Register ("FLOWCONTROL_RTSCTS_IN")]
		public const int FlowcontrolRtsctsIn = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.phi.gertec.sat.serial']/interface[@name='UsbSerialPort']/field[@name='FLOWCONTROL_RTSCTS_OUT']"
		[Register ("FLOWCONTROL_RTSCTS_OUT")]
		public const int FlowcontrolRtsctsOut = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.phi.gertec.sat.serial']/interface[@name='UsbSerialPort']/field[@name='FLOWCONTROL_XONXOFF_IN']"
		[Register ("FLOWCONTROL_XONXOFF_IN")]
		public const int FlowcontrolXonxoffIn = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.phi.gertec.sat.serial']/interface[@name='UsbSerialPort']/field[@name='FLOWCONTROL_XONXOFF_OUT']"
		[Register ("FLOWCONTROL_XONXOFF_OUT")]
		public const int FlowcontrolXonxoffOut = (int) 8;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.phi.gertec.sat.serial']/interface[@name='UsbSerialPort']/field[@name='PARITY_EVEN']"
		[Register ("PARITY_EVEN")]
		public const int ParityEven = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.phi.gertec.sat.serial']/interface[@name='UsbSerialPort']/field[@name='PARITY_MARK']"
		[Register ("PARITY_MARK")]
		public const int ParityMark = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.phi.gertec.sat.serial']/interface[@name='UsbSerialPort']/field[@name='PARITY_NONE']"
		[Register ("PARITY_NONE")]
		public const int ParityNone = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.phi.gertec.sat.serial']/interface[@name='UsbSerialPort']/field[@name='PARITY_ODD']"
		[Register ("PARITY_ODD")]
		public const int ParityOdd = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.phi.gertec.sat.serial']/interface[@name='UsbSerialPort']/field[@name='PARITY_SPACE']"
		[Register ("PARITY_SPACE")]
		public const int ParitySpace = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.phi.gertec.sat.serial']/interface[@name='UsbSerialPort']/field[@name='STOPBITS_1']"
		[Register ("STOPBITS_1")]
		public const int Stopbits1 = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.phi.gertec.sat.serial']/interface[@name='UsbSerialPort']/field[@name='STOPBITS_1_5']"
		[Register ("STOPBITS_1_5")]
		public const int Stopbits15 = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.phi.gertec.sat.serial']/interface[@name='UsbSerialPort']/field[@name='STOPBITS_2']"
		[Register ("STOPBITS_2")]
		public const int Stopbits2 = (int) 2;

	}

	[Register ("com/phi/gertec/sat/serial/UsbSerialPort", DoNotGenerateAcw=true)]
	[global::System.Obsolete (@"Use the 'UsbSerialPort' type. This type will be removed in a future release.", error: true)]
	public abstract class UsbSerialPortConsts : UsbSerialPort {
		private UsbSerialPortConsts ()
		{
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.phi.gertec.sat.serial']/interface[@name='UsbSerialPort']"
	[Register ("com/phi/gertec/sat/serial/UsbSerialPort", "", "Com.Phi.Gertec.Sat.Serial.IUsbSerialPortInvoker")]
	public partial interface IUsbSerialPort : IJavaObject, IJavaPeerable {
		bool CD {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.phi.gertec.sat.serial']/interface[@name='UsbSerialPort']/method[@name='getCD' and count(parameter)=0]"
			[Register ("getCD", "()Z", "GetGetCDHandler:Com.Phi.Gertec.Sat.Serial.IUsbSerialPortInvoker, Binding")]
			get; 
		}

		bool CTS {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.phi.gertec.sat.serial']/interface[@name='UsbSerialPort']/method[@name='getCTS' and count(parameter)=0]"
			[Register ("getCTS", "()Z", "GetGetCTSHandler:Com.Phi.Gertec.Sat.Serial.IUsbSerialPortInvoker, Binding")]
			get; 
		}

		bool DSR {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.phi.gertec.sat.serial']/interface[@name='UsbSerialPort']/method[@name='getDSR' and count(parameter)=0]"
			[Register ("getDSR", "()Z", "GetGetDSRHandler:Com.Phi.Gertec.Sat.Serial.IUsbSerialPortInvoker, Binding")]
			get; 
		}

		bool DTR {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.phi.gertec.sat.serial']/interface[@name='UsbSerialPort']/method[@name='getDTR' and count(parameter)=0]"
			[Register ("getDTR", "()Z", "GetGetDTRHandler:Com.Phi.Gertec.Sat.Serial.IUsbSerialPortInvoker, Binding")]
			get; 

			// Metadata.xml XPath method reference: path="/api/package[@name='com.phi.gertec.sat.serial']/interface[@name='UsbSerialPort']/method[@name='setDTR' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setDTR", "(Z)V", "GetSetDTR_ZHandler:Com.Phi.Gertec.Sat.Serial.IUsbSerialPortInvoker, Binding")]
			set; 
		}

		global::Com.Phi.Gertec.Sat.Serial.IUsbSerialDriver Driver {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.phi.gertec.sat.serial']/interface[@name='UsbSerialPort']/method[@name='getDriver' and count(parameter)=0]"
			[Register ("getDriver", "()Lcom/phi/gertec/sat/serial/UsbSerialDriver;", "GetGetDriverHandler:Com.Phi.Gertec.Sat.Serial.IUsbSerialPortInvoker, Binding")]
			get; 
		}

		int PortNumber {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.phi.gertec.sat.serial']/interface[@name='UsbSerialPort']/method[@name='getPortNumber' and count(parameter)=0]"
			[Register ("getPortNumber", "()I", "GetGetPortNumberHandler:Com.Phi.Gertec.Sat.Serial.IUsbSerialPortInvoker, Binding")]
			get; 
		}

		bool RI {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.phi.gertec.sat.serial']/interface[@name='UsbSerialPort']/method[@name='getRI' and count(parameter)=0]"
			[Register ("getRI", "()Z", "GetGetRIHandler:Com.Phi.Gertec.Sat.Serial.IUsbSerialPortInvoker, Binding")]
			get; 
		}

		bool RTS {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.phi.gertec.sat.serial']/interface[@name='UsbSerialPort']/method[@name='getRTS' and count(parameter)=0]"
			[Register ("getRTS", "()Z", "GetGetRTSHandler:Com.Phi.Gertec.Sat.Serial.IUsbSerialPortInvoker, Binding")]
			get; 

			// Metadata.xml XPath method reference: path="/api/package[@name='com.phi.gertec.sat.serial']/interface[@name='UsbSerialPort']/method[@name='setRTS' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setRTS", "(Z)V", "GetSetRTS_ZHandler:Com.Phi.Gertec.Sat.Serial.IUsbSerialPortInvoker, Binding")]
			set; 
		}

		string Serial {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.phi.gertec.sat.serial']/interface[@name='UsbSerialPort']/method[@name='getSerial' and count(parameter)=0]"
			[Register ("getSerial", "()Ljava/lang/String;", "GetGetSerialHandler:Com.Phi.Gertec.Sat.Serial.IUsbSerialPortInvoker, Binding")]
			get; 
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.phi.gertec.sat.serial']/interface[@name='UsbSerialPort']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "GetCloseHandler:Com.Phi.Gertec.Sat.Serial.IUsbSerialPortInvoker, Binding")]
		void Close ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.phi.gertec.sat.serial']/interface[@name='UsbSerialPort']/method[@name='open' and count(parameter)=1 and parameter[1][@type='android.hardware.usb.UsbDeviceConnection']]"
		[Register ("open", "(Landroid/hardware/usb/UsbDeviceConnection;)V", "GetOpen_Landroid_hardware_usb_UsbDeviceConnection_Handler:Com.Phi.Gertec.Sat.Serial.IUsbSerialPortInvoker, Binding")]
		void Open (global::Android.Hardware.Usb.UsbDeviceConnection p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.phi.gertec.sat.serial']/interface[@name='UsbSerialPort']/method[@name='purgeHwBuffers' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='boolean']]"
		[Register ("purgeHwBuffers", "(ZZ)Z", "GetPurgeHwBuffers_ZZHandler:Com.Phi.Gertec.Sat.Serial.IUsbSerialPortInvoker, Binding")]
		bool PurgeHwBuffers (bool p0, bool p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.phi.gertec.sat.serial']/interface[@name='UsbSerialPort']/method[@name='read' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
		[Register ("read", "([BI)I", "GetRead_arrayBIHandler:Com.Phi.Gertec.Sat.Serial.IUsbSerialPortInvoker, Binding")]
		int Read (byte[] p0, int p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.phi.gertec.sat.serial']/interface[@name='UsbSerialPort']/method[@name='reada' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("reada", "(I)I", "GetReada_IHandler:Com.Phi.Gertec.Sat.Serial.IUsbSerialPortInvoker, Binding")]
		int Reada (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.phi.gertec.sat.serial']/interface[@name='UsbSerialPort']/method[@name='reada' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("reada", "(II)I", "GetReada_IIHandler:Com.Phi.Gertec.Sat.Serial.IUsbSerialPortInvoker, Binding")]
		int Reada (int p0, int p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.phi.gertec.sat.serial']/interface[@name='UsbSerialPort']/method[@name='setParameters' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("setParameters", "(IIII)V", "GetSetParameters_IIIIHandler:Com.Phi.Gertec.Sat.Serial.IUsbSerialPortInvoker, Binding")]
		void SetParameters (int p0, int p1, int p2, int p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.phi.gertec.sat.serial']/interface[@name='UsbSerialPort']/method[@name='startUsbReadRequest' and count(parameter)=0]"
		[Register ("startUsbReadRequest", "()V", "GetStartUsbReadRequestHandler:Com.Phi.Gertec.Sat.Serial.IUsbSerialPortInvoker, Binding")]
		void StartUsbReadRequest ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.phi.gertec.sat.serial']/interface[@name='UsbSerialPort']/method[@name='stopUsbReadRequest' and count(parameter)=0]"
		[Register ("stopUsbReadRequest", "()V", "GetStopUsbReadRequestHandler:Com.Phi.Gertec.Sat.Serial.IUsbSerialPortInvoker, Binding")]
		void StopUsbReadRequest ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.phi.gertec.sat.serial']/interface[@name='UsbSerialPort']/method[@name='write' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
		[Register ("write", "([BI)I", "GetWrite_arrayBIHandler:Com.Phi.Gertec.Sat.Serial.IUsbSerialPortInvoker, Binding")]
		int Write (byte[] p0, int p1);

	}

	[global::Android.Runtime.Register ("com/phi/gertec/sat/serial/UsbSerialPort", DoNotGenerateAcw=true)]
	internal partial class IUsbSerialPortInvoker : global::Java.Lang.Object, IUsbSerialPort {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/phi/gertec/sat/serial/UsbSerialPort", typeof (IUsbSerialPortInvoker));

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

		public static IUsbSerialPort GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IUsbSerialPort> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.phi.gertec.sat.serial.UsbSerialPort'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IUsbSerialPortInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getCD;
#pragma warning disable 0169
		static Delegate GetGetCDHandler ()
		{
			if (cb_getCD == null)
				cb_getCD = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_Z (n_GetCD));
			return cb_getCD;
		}

		static bool n_GetCD (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Phi.Gertec.Sat.Serial.IUsbSerialPort> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CD;
		}
#pragma warning restore 0169

		IntPtr id_getCD;
		public unsafe bool CD {
			get {
				if (id_getCD == IntPtr.Zero)
					id_getCD = JNIEnv.GetMethodID (class_ref, "getCD", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_getCD);
			}
		}

		static Delegate cb_getCTS;
#pragma warning disable 0169
		static Delegate GetGetCTSHandler ()
		{
			if (cb_getCTS == null)
				cb_getCTS = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_Z (n_GetCTS));
			return cb_getCTS;
		}

		static bool n_GetCTS (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Phi.Gertec.Sat.Serial.IUsbSerialPort> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CTS;
		}
#pragma warning restore 0169

		IntPtr id_getCTS;
		public unsafe bool CTS {
			get {
				if (id_getCTS == IntPtr.Zero)
					id_getCTS = JNIEnv.GetMethodID (class_ref, "getCTS", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_getCTS);
			}
		}

		static Delegate cb_getDSR;
#pragma warning disable 0169
		static Delegate GetGetDSRHandler ()
		{
			if (cb_getDSR == null)
				cb_getDSR = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_Z (n_GetDSR));
			return cb_getDSR;
		}

		static bool n_GetDSR (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Phi.Gertec.Sat.Serial.IUsbSerialPort> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DSR;
		}
#pragma warning restore 0169

		IntPtr id_getDSR;
		public unsafe bool DSR {
			get {
				if (id_getDSR == IntPtr.Zero)
					id_getDSR = JNIEnv.GetMethodID (class_ref, "getDSR", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_getDSR);
			}
		}

		static Delegate cb_getDTR;
#pragma warning disable 0169
		static Delegate GetGetDTRHandler ()
		{
			if (cb_getDTR == null)
				cb_getDTR = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_Z (n_GetDTR));
			return cb_getDTR;
		}

		static bool n_GetDTR (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Phi.Gertec.Sat.Serial.IUsbSerialPort> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DTR;
		}
#pragma warning restore 0169

		static Delegate cb_setDTR_Z;
#pragma warning disable 0169
		static Delegate GetSetDTR_ZHandler ()
		{
			if (cb_setDTR_Z == null)
				cb_setDTR_Z = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPZ_V (n_SetDTR_Z));
			return cb_setDTR_Z;
		}

		static void n_SetDTR_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Phi.Gertec.Sat.Serial.IUsbSerialPort> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DTR = p0;
		}
#pragma warning restore 0169

		IntPtr id_getDTR;
		IntPtr id_setDTR_Z;
		public unsafe bool DTR {
			get {
				if (id_getDTR == IntPtr.Zero)
					id_getDTR = JNIEnv.GetMethodID (class_ref, "getDTR", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_getDTR);
			}
			set {
				if (id_setDTR_Z == IntPtr.Zero)
					id_setDTR_Z = JNIEnv.GetMethodID (class_ref, "setDTR", "(Z)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDTR_Z, __args);
			}
		}

		static Delegate cb_getDriver;
#pragma warning disable 0169
		static Delegate GetGetDriverHandler ()
		{
			if (cb_getDriver == null)
				cb_getDriver = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetDriver));
			return cb_getDriver;
		}

		static IntPtr n_GetDriver (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Phi.Gertec.Sat.Serial.IUsbSerialPort> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Driver);
		}
#pragma warning restore 0169

		IntPtr id_getDriver;
		public unsafe global::Com.Phi.Gertec.Sat.Serial.IUsbSerialDriver Driver {
			get {
				if (id_getDriver == IntPtr.Zero)
					id_getDriver = JNIEnv.GetMethodID (class_ref, "getDriver", "()Lcom/phi/gertec/sat/serial/UsbSerialDriver;");
				return global::Java.Lang.Object.GetObject<global::Com.Phi.Gertec.Sat.Serial.IUsbSerialDriver> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDriver), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getPortNumber;
#pragma warning disable 0169
		static Delegate GetGetPortNumberHandler ()
		{
			if (cb_getPortNumber == null)
				cb_getPortNumber = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_GetPortNumber));
			return cb_getPortNumber;
		}

		static int n_GetPortNumber (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Phi.Gertec.Sat.Serial.IUsbSerialPort> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PortNumber;
		}
#pragma warning restore 0169

		IntPtr id_getPortNumber;
		public unsafe int PortNumber {
			get {
				if (id_getPortNumber == IntPtr.Zero)
					id_getPortNumber = JNIEnv.GetMethodID (class_ref, "getPortNumber", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getPortNumber);
			}
		}

		static Delegate cb_getRI;
#pragma warning disable 0169
		static Delegate GetGetRIHandler ()
		{
			if (cb_getRI == null)
				cb_getRI = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_Z (n_GetRI));
			return cb_getRI;
		}

		static bool n_GetRI (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Phi.Gertec.Sat.Serial.IUsbSerialPort> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RI;
		}
#pragma warning restore 0169

		IntPtr id_getRI;
		public unsafe bool RI {
			get {
				if (id_getRI == IntPtr.Zero)
					id_getRI = JNIEnv.GetMethodID (class_ref, "getRI", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_getRI);
			}
		}

		static Delegate cb_getRTS;
#pragma warning disable 0169
		static Delegate GetGetRTSHandler ()
		{
			if (cb_getRTS == null)
				cb_getRTS = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_Z (n_GetRTS));
			return cb_getRTS;
		}

		static bool n_GetRTS (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Phi.Gertec.Sat.Serial.IUsbSerialPort> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RTS;
		}
#pragma warning restore 0169

		static Delegate cb_setRTS_Z;
#pragma warning disable 0169
		static Delegate GetSetRTS_ZHandler ()
		{
			if (cb_setRTS_Z == null)
				cb_setRTS_Z = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPZ_V (n_SetRTS_Z));
			return cb_setRTS_Z;
		}

		static void n_SetRTS_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Phi.Gertec.Sat.Serial.IUsbSerialPort> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RTS = p0;
		}
#pragma warning restore 0169

		IntPtr id_getRTS;
		IntPtr id_setRTS_Z;
		public unsafe bool RTS {
			get {
				if (id_getRTS == IntPtr.Zero)
					id_getRTS = JNIEnv.GetMethodID (class_ref, "getRTS", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_getRTS);
			}
			set {
				if (id_setRTS_Z == IntPtr.Zero)
					id_setRTS_Z = JNIEnv.GetMethodID (class_ref, "setRTS", "(Z)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setRTS_Z, __args);
			}
		}

		static Delegate cb_getSerial;
#pragma warning disable 0169
		static Delegate GetGetSerialHandler ()
		{
			if (cb_getSerial == null)
				cb_getSerial = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetSerial));
			return cb_getSerial;
		}

		static IntPtr n_GetSerial (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Phi.Gertec.Sat.Serial.IUsbSerialPort> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Serial);
		}
#pragma warning restore 0169

		IntPtr id_getSerial;
		public unsafe string Serial {
			get {
				if (id_getSerial == IntPtr.Zero)
					id_getSerial = JNIEnv.GetMethodID (class_ref, "getSerial", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSerial), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_close;
#pragma warning disable 0169
		static Delegate GetCloseHandler ()
		{
			if (cb_close == null)
				cb_close = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_Close));
			return cb_close;
		}

		static void n_Close (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Phi.Gertec.Sat.Serial.IUsbSerialPort> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		IntPtr id_close;
		public unsafe void Close ()
		{
			if (id_close == IntPtr.Zero)
				id_close = JNIEnv.GetMethodID (class_ref, "close", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_close);
		}

		static Delegate cb_open_Landroid_hardware_usb_UsbDeviceConnection_;
#pragma warning disable 0169
		static Delegate GetOpen_Landroid_hardware_usb_UsbDeviceConnection_Handler ()
		{
			if (cb_open_Landroid_hardware_usb_UsbDeviceConnection_ == null)
				cb_open_Landroid_hardware_usb_UsbDeviceConnection_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_Open_Landroid_hardware_usb_UsbDeviceConnection_));
			return cb_open_Landroid_hardware_usb_UsbDeviceConnection_;
		}

		static void n_Open_Landroid_hardware_usb_UsbDeviceConnection_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Phi.Gertec.Sat.Serial.IUsbSerialPort> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Hardware.Usb.UsbDeviceConnection> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Open (p0);
		}
#pragma warning restore 0169

		IntPtr id_open_Landroid_hardware_usb_UsbDeviceConnection_;
		public unsafe void Open (global::Android.Hardware.Usb.UsbDeviceConnection p0)
		{
			if (id_open_Landroid_hardware_usb_UsbDeviceConnection_ == IntPtr.Zero)
				id_open_Landroid_hardware_usb_UsbDeviceConnection_ = JNIEnv.GetMethodID (class_ref, "open", "(Landroid/hardware/usb/UsbDeviceConnection;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_open_Landroid_hardware_usb_UsbDeviceConnection_, __args);
		}

		static Delegate cb_purgeHwBuffers_ZZ;
#pragma warning disable 0169
		static Delegate GetPurgeHwBuffers_ZZHandler ()
		{
			if (cb_purgeHwBuffers_ZZ == null)
				cb_purgeHwBuffers_ZZ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPZZ_Z (n_PurgeHwBuffers_ZZ));
			return cb_purgeHwBuffers_ZZ;
		}

		static bool n_PurgeHwBuffers_ZZ (IntPtr jnienv, IntPtr native__this, bool p0, bool p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Phi.Gertec.Sat.Serial.IUsbSerialPort> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PurgeHwBuffers (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_purgeHwBuffers_ZZ;
		public unsafe bool PurgeHwBuffers (bool p0, bool p1)
		{
			if (id_purgeHwBuffers_ZZ == IntPtr.Zero)
				id_purgeHwBuffers_ZZ = JNIEnv.GetMethodID (class_ref, "purgeHwBuffers", "(ZZ)Z");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_purgeHwBuffers_ZZ, __args);
		}

		static Delegate cb_read_arrayBI;
#pragma warning disable 0169
		static Delegate GetRead_arrayBIHandler ()
		{
			if (cb_read_arrayBI == null)
				cb_read_arrayBI = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLI_I (n_Read_arrayBI));
			return cb_read_arrayBI;
		}

		static int n_Read_arrayBI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Phi.Gertec.Sat.Serial.IUsbSerialPort> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.Read (p0, p1);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_read_arrayBI;
		public unsafe int Read (byte[] p0, int p1)
		{
			if (id_read_arrayBI == IntPtr.Zero)
				id_read_arrayBI = JNIEnv.GetMethodID (class_ref, "read", "([BI)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_read_arrayBI, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static Delegate cb_reada_I;
#pragma warning disable 0169
		static Delegate GetReada_IHandler ()
		{
			if (cb_reada_I == null)
				cb_reada_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_I (n_Reada_I));
			return cb_reada_I;
		}

		static int n_Reada_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Phi.Gertec.Sat.Serial.IUsbSerialPort> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Reada (p0);
		}
#pragma warning restore 0169

		IntPtr id_reada_I;
		public unsafe int Reada (int p0)
		{
			if (id_reada_I == IntPtr.Zero)
				id_reada_I = JNIEnv.GetMethodID (class_ref, "reada", "(I)I");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_reada_I, __args);
		}

		static Delegate cb_reada_II;
#pragma warning disable 0169
		static Delegate GetReada_IIHandler ()
		{
			if (cb_reada_II == null)
				cb_reada_II = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPII_I (n_Reada_II));
			return cb_reada_II;
		}

		static int n_Reada_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Phi.Gertec.Sat.Serial.IUsbSerialPort> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Reada (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_reada_II;
		public unsafe int Reada (int p0, int p1)
		{
			if (id_reada_II == IntPtr.Zero)
				id_reada_II = JNIEnv.GetMethodID (class_ref, "reada", "(II)I");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_reada_II, __args);
		}

		static Delegate cb_setParameters_IIII;
#pragma warning disable 0169
		static Delegate GetSetParameters_IIIIHandler ()
		{
			if (cb_setParameters_IIII == null)
				cb_setParameters_IIII = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIIII_V (n_SetParameters_IIII));
			return cb_setParameters_IIII;
		}

		static void n_SetParameters_IIII (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2, int p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Phi.Gertec.Sat.Serial.IUsbSerialPort> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetParameters (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		IntPtr id_setParameters_IIII;
		public unsafe void SetParameters (int p0, int p1, int p2, int p3)
		{
			if (id_setParameters_IIII == IntPtr.Zero)
				id_setParameters_IIII = JNIEnv.GetMethodID (class_ref, "setParameters", "(IIII)V");
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (p3);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setParameters_IIII, __args);
		}

		static Delegate cb_startUsbReadRequest;
#pragma warning disable 0169
		static Delegate GetStartUsbReadRequestHandler ()
		{
			if (cb_startUsbReadRequest == null)
				cb_startUsbReadRequest = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_StartUsbReadRequest));
			return cb_startUsbReadRequest;
		}

		static void n_StartUsbReadRequest (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Phi.Gertec.Sat.Serial.IUsbSerialPort> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StartUsbReadRequest ();
		}
#pragma warning restore 0169

		IntPtr id_startUsbReadRequest;
		public unsafe void StartUsbReadRequest ()
		{
			if (id_startUsbReadRequest == IntPtr.Zero)
				id_startUsbReadRequest = JNIEnv.GetMethodID (class_ref, "startUsbReadRequest", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_startUsbReadRequest);
		}

		static Delegate cb_stopUsbReadRequest;
#pragma warning disable 0169
		static Delegate GetStopUsbReadRequestHandler ()
		{
			if (cb_stopUsbReadRequest == null)
				cb_stopUsbReadRequest = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_StopUsbReadRequest));
			return cb_stopUsbReadRequest;
		}

		static void n_StopUsbReadRequest (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Phi.Gertec.Sat.Serial.IUsbSerialPort> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StopUsbReadRequest ();
		}
#pragma warning restore 0169

		IntPtr id_stopUsbReadRequest;
		public unsafe void StopUsbReadRequest ()
		{
			if (id_stopUsbReadRequest == IntPtr.Zero)
				id_stopUsbReadRequest = JNIEnv.GetMethodID (class_ref, "stopUsbReadRequest", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_stopUsbReadRequest);
		}

		static Delegate cb_write_arrayBI;
#pragma warning disable 0169
		static Delegate GetWrite_arrayBIHandler ()
		{
			if (cb_write_arrayBI == null)
				cb_write_arrayBI = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLI_I (n_Write_arrayBI));
			return cb_write_arrayBI;
		}

		static int n_Write_arrayBI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Phi.Gertec.Sat.Serial.IUsbSerialPort> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.Write (p0, p1);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_write_arrayBI;
		public unsafe int Write (byte[] p0, int p1)
		{
			if (id_write_arrayBI == IntPtr.Zero)
				id_write_arrayBI = JNIEnv.GetMethodID (class_ref, "write", "([BI)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_write_arrayBI, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

	}
}
