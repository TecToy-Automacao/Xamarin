using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace BR.Com.Itfast.Tectoy.Service {

	// Metadata.xml XPath interface reference: path="/api/package[@name='br.com.itfast.tectoy.service']/interface[@name='ICommunicationDevice']"
	[Register ("br/com/itfast/tectoy/service/ICommunicationDevice", "", "BR.Com.Itfast.Tectoy.Service.ICommunicationDeviceInvoker")]
	public partial interface ICommunicationDevice : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.itfast.tectoy.service']/interface[@name='ICommunicationDevice']/method[@name='read' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("read", "(I)[B", "GetRead_IHandler:BR.Com.Itfast.Tectoy.Service.ICommunicationDeviceInvoker, Binding")]
		byte[] Read (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.itfast.tectoy.service']/interface[@name='ICommunicationDevice']/method[@name='write' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("write", "([B)V", "GetWrite_arrayBHandler:BR.Com.Itfast.Tectoy.Service.ICommunicationDeviceInvoker, Binding")]
		void Write (byte[] p0);

	}

	[global::Android.Runtime.Register ("br/com/itfast/tectoy/service/ICommunicationDevice", DoNotGenerateAcw=true)]
	internal partial class ICommunicationDeviceInvoker : global::Java.Lang.Object, ICommunicationDevice {
		static readonly JniPeerMembers _members = new XAPeerMembers ("br/com/itfast/tectoy/service/ICommunicationDevice", typeof (ICommunicationDeviceInvoker));

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

		public static ICommunicationDevice GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ICommunicationDevice> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'br.com.itfast.tectoy.service.ICommunicationDevice'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ICommunicationDeviceInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_read_I;
#pragma warning disable 0169
		static Delegate GetRead_IHandler ()
		{
			if (cb_read_I == null)
				cb_read_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_L (n_Read_I));
			return cb_read_I;
		}

		static IntPtr n_Read_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Itfast.Tectoy.Service.ICommunicationDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.Read (p0));
		}
#pragma warning restore 0169

		IntPtr id_read_I;
		public unsafe byte[] Read (int p0)
		{
			if (id_read_I == IntPtr.Zero)
				id_read_I = JNIEnv.GetMethodID (class_ref, "read", "(I)[B");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_read_I, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
		}

		static Delegate cb_write_arrayB;
#pragma warning disable 0169
		static Delegate GetWrite_arrayBHandler ()
		{
			if (cb_write_arrayB == null)
				cb_write_arrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_Write_arrayB));
			return cb_write_arrayB;
		}

		static void n_Write_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Itfast.Tectoy.Service.ICommunicationDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.Write (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		IntPtr id_write_arrayB;
		public unsafe void Write (byte[] p0)
		{
			if (id_write_arrayB == IntPtr.Zero)
				id_write_arrayB = JNIEnv.GetMethodID (class_ref, "write", "([B)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_write_arrayB, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
