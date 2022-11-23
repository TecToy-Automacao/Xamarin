using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace BR.Com.Itfast.Tectoy {

	// Metadata.xml XPath interface reference: path="/api/package[@name='br.com.itfast.tectoy']/interface[@name='Control']"
	[Register ("br/com/itfast/tectoy/Control", "", "BR.Com.Itfast.Tectoy.IControlInvoker")]
	public partial interface IControl : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.itfast.tectoy']/interface[@name='Control']/method[@name='connect' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='br.com.itfast.tectoy.ConnectCallback']]"
		[Register ("connect", "(Landroid/content/Context;Lbr/com/itfast/tectoy/ConnectCallback;)V", "GetConnect_Landroid_content_Context_Lbr_com_itfast_tectoy_ConnectCallback_Handler:BR.Com.Itfast.Tectoy.IControlInvoker, Binding")]
		void Connect (global::Android.Content.Context p0, global::BR.Com.Itfast.Tectoy.IConnectCallback p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.itfast.tectoy']/interface[@name='Control']/method[@name='disconnect' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("disconnect", "(Landroid/content/Context;)V", "GetDisconnect_Landroid_content_Context_Handler:BR.Com.Itfast.Tectoy.IControlInvoker, Binding")]
		void Disconnect (global::Android.Content.Context p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.itfast.tectoy']/interface[@name='Control']/method[@name='recvData' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("recvData", "([B)I", "GetRecvData_arrayBHandler:BR.Com.Itfast.Tectoy.IControlInvoker, Binding")]
		int RecvData (byte[] p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.itfast.tectoy']/interface[@name='Control']/method[@name='sendData' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("sendData", "([B)I", "GetSendData_arrayBHandler:BR.Com.Itfast.Tectoy.IControlInvoker, Binding")]
		int SendData (byte[] p0);

	}

	[global::Android.Runtime.Register ("br/com/itfast/tectoy/Control", DoNotGenerateAcw=true)]
	internal partial class IControlInvoker : global::Java.Lang.Object, IControl {
		static readonly JniPeerMembers _members = new XAPeerMembers ("br/com/itfast/tectoy/Control", typeof (IControlInvoker));

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

		public static IControl GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IControl> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'br.com.itfast.tectoy.Control'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IControlInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_connect_Landroid_content_Context_Lbr_com_itfast_tectoy_ConnectCallback_;
#pragma warning disable 0169
		static Delegate GetConnect_Landroid_content_Context_Lbr_com_itfast_tectoy_ConnectCallback_Handler ()
		{
			if (cb_connect_Landroid_content_Context_Lbr_com_itfast_tectoy_ConnectCallback_ == null)
				cb_connect_Landroid_content_Context_Lbr_com_itfast_tectoy_ConnectCallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_Connect_Landroid_content_Context_Lbr_com_itfast_tectoy_ConnectCallback_);
			return cb_connect_Landroid_content_Context_Lbr_com_itfast_tectoy_ConnectCallback_;
		}

		static void n_Connect_Landroid_content_Context_Lbr_com_itfast_tectoy_ConnectCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Itfast.Tectoy.IControl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::BR.Com.Itfast.Tectoy.IConnectCallback)global::Java.Lang.Object.GetObject<global::BR.Com.Itfast.Tectoy.IConnectCallback> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Connect (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_connect_Landroid_content_Context_Lbr_com_itfast_tectoy_ConnectCallback_;
		public unsafe void Connect (global::Android.Content.Context p0, global::BR.Com.Itfast.Tectoy.IConnectCallback p1)
		{
			if (id_connect_Landroid_content_Context_Lbr_com_itfast_tectoy_ConnectCallback_ == IntPtr.Zero)
				id_connect_Landroid_content_Context_Lbr_com_itfast_tectoy_ConnectCallback_ = JNIEnv.GetMethodID (class_ref, "connect", "(Landroid/content/Context;Lbr/com/itfast/tectoy/ConnectCallback;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_connect_Landroid_content_Context_Lbr_com_itfast_tectoy_ConnectCallback_, __args);
		}

		static Delegate cb_disconnect_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetDisconnect_Landroid_content_Context_Handler ()
		{
			if (cb_disconnect_Landroid_content_Context_ == null)
				cb_disconnect_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Disconnect_Landroid_content_Context_);
			return cb_disconnect_Landroid_content_Context_;
		}

		static void n_Disconnect_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Itfast.Tectoy.IControl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Disconnect (p0);
		}
#pragma warning restore 0169

		IntPtr id_disconnect_Landroid_content_Context_;
		public unsafe void Disconnect (global::Android.Content.Context p0)
		{
			if (id_disconnect_Landroid_content_Context_ == IntPtr.Zero)
				id_disconnect_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "disconnect", "(Landroid/content/Context;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_disconnect_Landroid_content_Context_, __args);
		}

		static Delegate cb_recvData_arrayB;
#pragma warning disable 0169
		static Delegate GetRecvData_arrayBHandler ()
		{
			if (cb_recvData_arrayB == null)
				cb_recvData_arrayB = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_I) n_RecvData_arrayB);
			return cb_recvData_arrayB;
		}

		static int n_RecvData_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Itfast.Tectoy.IControl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.RecvData (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_recvData_arrayB;
		public unsafe int RecvData (byte[] p0)
		{
			if (id_recvData_arrayB == IntPtr.Zero)
				id_recvData_arrayB = JNIEnv.GetMethodID (class_ref, "recvData", "([B)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_recvData_arrayB, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static Delegate cb_sendData_arrayB;
#pragma warning disable 0169
		static Delegate GetSendData_arrayBHandler ()
		{
			if (cb_sendData_arrayB == null)
				cb_sendData_arrayB = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_I) n_SendData_arrayB);
			return cb_sendData_arrayB;
		}

		static int n_SendData_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Itfast.Tectoy.IControl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.SendData (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_sendData_arrayB;
		public unsafe int SendData (byte[] p0)
		{
			if (id_sendData_arrayB == IntPtr.Zero)
				id_sendData_arrayB = JNIEnv.GetMethodID (class_ref, "sendData", "([B)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_sendData_arrayB, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

	}
}
