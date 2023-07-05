using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Orbbec.Astra.Android {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.orbbec.astra.android']/interface[@name='AstraDeviceManagerListener']"
	[Register ("com/orbbec/astra/android/AstraDeviceManagerListener", "", "Com.Orbbec.Astra.Android.IAstraDeviceManagerListenerInvoker")]
	public partial interface IAstraDeviceManagerListener : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.orbbec.astra.android']/interface[@name='AstraDeviceManagerListener']/method[@name='onNoDevice' and count(parameter)=0]"
		[Register ("onNoDevice", "()V", "GetOnNoDeviceHandler:Com.Orbbec.Astra.Android.IAstraDeviceManagerListenerInvoker, Binding")]
		void OnNoDevice ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.orbbec.astra.android']/interface[@name='AstraDeviceManagerListener']/method[@name='onOpenAllDevicesCompleted' and count(parameter)=2 and parameter[1][@type='java.lang.Iterable&lt;android.hardware.usb.UsbDevice&gt;'] and parameter[2][@type='java.lang.Iterable&lt;android.hardware.usb.UsbDeviceConnection&gt;']]"
		[Register ("onOpenAllDevicesCompleted", "(Ljava/lang/Iterable;Ljava/lang/Iterable;)V", "GetOnOpenAllDevicesCompleted_Ljava_lang_Iterable_Ljava_lang_Iterable_Handler:Com.Orbbec.Astra.Android.IAstraDeviceManagerListenerInvoker, Binding")]
		void OnOpenAllDevicesCompleted (global::Java.Lang.IIterable p0, global::Java.Lang.IIterable p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.orbbec.astra.android']/interface[@name='AstraDeviceManagerListener']/method[@name='onOpenDeviceCompleted' and count(parameter)=2 and parameter[1][@type='android.hardware.usb.UsbDevice'] and parameter[2][@type='boolean']]"
		[Register ("onOpenDeviceCompleted", "(Landroid/hardware/usb/UsbDevice;Z)V", "GetOnOpenDeviceCompleted_Landroid_hardware_usb_UsbDevice_ZHandler:Com.Orbbec.Astra.Android.IAstraDeviceManagerListenerInvoker, Binding")]
		void OnOpenDeviceCompleted (global::Android.Hardware.Usb.UsbDevice p0, bool p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.orbbec.astra.android']/interface[@name='AstraDeviceManagerListener']/method[@name='onPermissionDenied' and count(parameter)=1 and parameter[1][@type='android.hardware.usb.UsbDevice']]"
		[Register ("onPermissionDenied", "(Landroid/hardware/usb/UsbDevice;)V", "GetOnPermissionDenied_Landroid_hardware_usb_UsbDevice_Handler:Com.Orbbec.Astra.Android.IAstraDeviceManagerListenerInvoker, Binding")]
		void OnPermissionDenied (global::Android.Hardware.Usb.UsbDevice p0);

	}

	[global::Android.Runtime.Register ("com/orbbec/astra/android/AstraDeviceManagerListener", DoNotGenerateAcw=true)]
	internal partial class IAstraDeviceManagerListenerInvoker : global::Java.Lang.Object, IAstraDeviceManagerListener {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/orbbec/astra/android/AstraDeviceManagerListener", typeof (IAstraDeviceManagerListenerInvoker));

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

		public static IAstraDeviceManagerListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAstraDeviceManagerListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.orbbec.astra.android.AstraDeviceManagerListener'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAstraDeviceManagerListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onNoDevice;
#pragma warning disable 0169
		static Delegate GetOnNoDeviceHandler ()
		{
			if (cb_onNoDevice == null)
				cb_onNoDevice = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_OnNoDevice));
			return cb_onNoDevice;
		}

		static void n_OnNoDevice (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Orbbec.Astra.Android.IAstraDeviceManagerListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnNoDevice ();
		}
#pragma warning restore 0169

		IntPtr id_onNoDevice;
		public unsafe void OnNoDevice ()
		{
			if (id_onNoDevice == IntPtr.Zero)
				id_onNoDevice = JNIEnv.GetMethodID (class_ref, "onNoDevice", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onNoDevice);
		}

		static Delegate cb_onOpenAllDevicesCompleted_Ljava_lang_Iterable_Ljava_lang_Iterable_;
#pragma warning disable 0169
		static Delegate GetOnOpenAllDevicesCompleted_Ljava_lang_Iterable_Ljava_lang_Iterable_Handler ()
		{
			if (cb_onOpenAllDevicesCompleted_Ljava_lang_Iterable_Ljava_lang_Iterable_ == null)
				cb_onOpenAllDevicesCompleted_Ljava_lang_Iterable_Ljava_lang_Iterable_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_V (n_OnOpenAllDevicesCompleted_Ljava_lang_Iterable_Ljava_lang_Iterable_));
			return cb_onOpenAllDevicesCompleted_Ljava_lang_Iterable_Ljava_lang_Iterable_;
		}

		static void n_OnOpenAllDevicesCompleted_Ljava_lang_Iterable_Ljava_lang_Iterable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Orbbec.Astra.Android.IAstraDeviceManagerListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Java.Lang.IIterable)global::Java.Lang.Object.GetObject<global::Java.Lang.IIterable> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Java.Lang.IIterable)global::Java.Lang.Object.GetObject<global::Java.Lang.IIterable> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnOpenAllDevicesCompleted (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onOpenAllDevicesCompleted_Ljava_lang_Iterable_Ljava_lang_Iterable_;
		public unsafe void OnOpenAllDevicesCompleted (global::Java.Lang.IIterable p0, global::Java.Lang.IIterable p1)
		{
			if (id_onOpenAllDevicesCompleted_Ljava_lang_Iterable_Ljava_lang_Iterable_ == IntPtr.Zero)
				id_onOpenAllDevicesCompleted_Ljava_lang_Iterable_Ljava_lang_Iterable_ = JNIEnv.GetMethodID (class_ref, "onOpenAllDevicesCompleted", "(Ljava/lang/Iterable;Ljava/lang/Iterable;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onOpenAllDevicesCompleted_Ljava_lang_Iterable_Ljava_lang_Iterable_, __args);
		}

		static Delegate cb_onOpenDeviceCompleted_Landroid_hardware_usb_UsbDevice_Z;
#pragma warning disable 0169
		static Delegate GetOnOpenDeviceCompleted_Landroid_hardware_usb_UsbDevice_ZHandler ()
		{
			if (cb_onOpenDeviceCompleted_Landroid_hardware_usb_UsbDevice_Z == null)
				cb_onOpenDeviceCompleted_Landroid_hardware_usb_UsbDevice_Z = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLZ_V (n_OnOpenDeviceCompleted_Landroid_hardware_usb_UsbDevice_Z));
			return cb_onOpenDeviceCompleted_Landroid_hardware_usb_UsbDevice_Z;
		}

		static void n_OnOpenDeviceCompleted_Landroid_hardware_usb_UsbDevice_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Orbbec.Astra.Android.IAstraDeviceManagerListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Hardware.Usb.UsbDevice> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnOpenDeviceCompleted (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onOpenDeviceCompleted_Landroid_hardware_usb_UsbDevice_Z;
		public unsafe void OnOpenDeviceCompleted (global::Android.Hardware.Usb.UsbDevice p0, bool p1)
		{
			if (id_onOpenDeviceCompleted_Landroid_hardware_usb_UsbDevice_Z == IntPtr.Zero)
				id_onOpenDeviceCompleted_Landroid_hardware_usb_UsbDevice_Z = JNIEnv.GetMethodID (class_ref, "onOpenDeviceCompleted", "(Landroid/hardware/usb/UsbDevice;Z)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onOpenDeviceCompleted_Landroid_hardware_usb_UsbDevice_Z, __args);
		}

		static Delegate cb_onPermissionDenied_Landroid_hardware_usb_UsbDevice_;
#pragma warning disable 0169
		static Delegate GetOnPermissionDenied_Landroid_hardware_usb_UsbDevice_Handler ()
		{
			if (cb_onPermissionDenied_Landroid_hardware_usb_UsbDevice_ == null)
				cb_onPermissionDenied_Landroid_hardware_usb_UsbDevice_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_OnPermissionDenied_Landroid_hardware_usb_UsbDevice_));
			return cb_onPermissionDenied_Landroid_hardware_usb_UsbDevice_;
		}

		static void n_OnPermissionDenied_Landroid_hardware_usb_UsbDevice_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Orbbec.Astra.Android.IAstraDeviceManagerListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Hardware.Usb.UsbDevice> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnPermissionDenied (p0);
		}
#pragma warning restore 0169

		IntPtr id_onPermissionDenied_Landroid_hardware_usb_UsbDevice_;
		public unsafe void OnPermissionDenied (global::Android.Hardware.Usb.UsbDevice p0)
		{
			if (id_onPermissionDenied_Landroid_hardware_usb_UsbDevice_ == IntPtr.Zero)
				id_onPermissionDenied_Landroid_hardware_usb_UsbDevice_ = JNIEnv.GetMethodID (class_ref, "onPermissionDenied", "(Landroid/hardware/usb/UsbDevice;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onPermissionDenied_Landroid_hardware_usb_UsbDevice_, __args);
		}

	}

	// event args for com.orbbec.astra.android.AstraDeviceManagerListener.onOpenAllDevicesCompleted
	public partial class OpenAllDevicesCompletedEventArgs : global::System.EventArgs {
		public OpenAllDevicesCompletedEventArgs (global::Java.Lang.IIterable p0, global::Java.Lang.IIterable p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		global::Java.Lang.IIterable p0;

		public global::Java.Lang.IIterable P0 {
			get { return p0; }
		}

		global::Java.Lang.IIterable p1;

		public global::Java.Lang.IIterable P1 {
			get { return p1; }
		}

	}

	// event args for com.orbbec.astra.android.AstraDeviceManagerListener.onOpenDeviceCompleted
	public partial class OpenDeviceCompletedEventArgs : global::System.EventArgs {
		public OpenDeviceCompletedEventArgs (global::Android.Hardware.Usb.UsbDevice p0, bool p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		global::Android.Hardware.Usb.UsbDevice p0;

		public global::Android.Hardware.Usb.UsbDevice P0 {
			get { return p0; }
		}

		bool p1;

		public bool P1 {
			get { return p1; }
		}

	}

	// event args for com.orbbec.astra.android.AstraDeviceManagerListener.onPermissionDenied
	public partial class PermissionDeniedEventArgs : global::System.EventArgs {
		public PermissionDeniedEventArgs (global::Android.Hardware.Usb.UsbDevice p0)
		{
			this.p0 = p0;
		}

		global::Android.Hardware.Usb.UsbDevice p0;

		public global::Android.Hardware.Usb.UsbDevice P0 {
			get { return p0; }
		}

	}

	[global::Android.Runtime.Register ("mono/com/orbbec/astra/android/AstraDeviceManagerListenerImplementor")]
	internal sealed partial class IAstraDeviceManagerListenerImplementor : global::Java.Lang.Object, IAstraDeviceManagerListener {

		object sender;

		public IAstraDeviceManagerListenerImplementor (object sender) : base (global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/orbbec/astra/android/AstraDeviceManagerListenerImplementor", "()V"), JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

		#pragma warning disable 0649
		public EventHandler OnNoDeviceHandler;
		#pragma warning restore 0649

		public void OnNoDevice ()
		{
			var __h = OnNoDeviceHandler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}

		#pragma warning disable 0649
		public EventHandler<OpenAllDevicesCompletedEventArgs> OnOpenAllDevicesCompletedHandler;
		#pragma warning restore 0649

		public void OnOpenAllDevicesCompleted (global::Java.Lang.IIterable p0, global::Java.Lang.IIterable p1)
		{
			var __h = OnOpenAllDevicesCompletedHandler;
			if (__h != null)
				__h (sender, new OpenAllDevicesCompletedEventArgs (p0, p1));
		}

		#pragma warning disable 0649
		public EventHandler<OpenDeviceCompletedEventArgs> OnOpenDeviceCompletedHandler;
		#pragma warning restore 0649

		public void OnOpenDeviceCompleted (global::Android.Hardware.Usb.UsbDevice p0, bool p1)
		{
			var __h = OnOpenDeviceCompletedHandler;
			if (__h != null)
				__h (sender, new OpenDeviceCompletedEventArgs (p0, p1));
		}

		#pragma warning disable 0649
		public EventHandler<PermissionDeniedEventArgs> OnPermissionDeniedHandler;
		#pragma warning restore 0649

		public void OnPermissionDenied (global::Android.Hardware.Usb.UsbDevice p0)
		{
			var __h = OnPermissionDeniedHandler;
			if (__h != null)
				__h (sender, new PermissionDeniedEventArgs (p0));
		}

		internal static bool __IsEmpty (IAstraDeviceManagerListenerImplementor value)
		{
			return value.OnNoDeviceHandler == null && value.OnOpenAllDevicesCompletedHandler == null && value.OnOpenDeviceCompletedHandler == null && value.OnPermissionDeniedHandler == null;
		}

	}
}
