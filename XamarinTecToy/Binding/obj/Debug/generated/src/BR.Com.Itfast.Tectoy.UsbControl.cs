using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace BR.Com.Itfast.Tectoy {

	// Metadata.xml XPath class reference: path="/api/package[@name='br.com.itfast.tectoy']/class[@name='UsbControl']"
	[global::Android.Runtime.Register ("br/com/itfast/tectoy/UsbControl", DoNotGenerateAcw=true)]
	public sealed partial class UsbControl : global::Java.Lang.Object, global::BR.Com.Itfast.Tectoy.IControl {
		static readonly JniPeerMembers _members = new XAPeerMembers ("br/com/itfast/tectoy/UsbControl", typeof (UsbControl));

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

		internal UsbControl (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='br.com.itfast.tectoy']/class[@name='UsbControl']/constructor[@name='UsbControl' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe UsbControl () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.itfast.tectoy']/class[@name='UsbControl']/method[@name='connect' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='br.com.itfast.tectoy.ConnectCallback']]"
		[Register ("connect", "(Landroid/content/Context;Lbr/com/itfast/tectoy/ConnectCallback;)V", "")]
		public unsafe void Connect (global::Android.Content.Context context, global::BR.Com.Itfast.Tectoy.IConnectCallback connectCallback)
		{
			const string __id = "connect.(Landroid/content/Context;Lbr/com/itfast/tectoy/ConnectCallback;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((connectCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) connectCallback).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (context);
				global::System.GC.KeepAlive (connectCallback);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.itfast.tectoy']/class[@name='UsbControl']/method[@name='disconnect' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("disconnect", "(Landroid/content/Context;)V", "")]
		public unsafe void Disconnect (global::Android.Content.Context context)
		{
			const string __id = "disconnect.(Landroid/content/Context;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.itfast.tectoy']/class[@name='UsbControl']/method[@name='recvData' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("recvData", "([B)I", "")]
		public unsafe int RecvData (byte[] data)
		{
			const string __id = "recvData.([B)I";
			IntPtr native_data = JNIEnv.NewArray (data);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_data);
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
				return __rm;
			} finally {
				if (data != null) {
					JNIEnv.CopyArray (native_data, data);
					JNIEnv.DeleteLocalRef (native_data);
				}
				global::System.GC.KeepAlive (data);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.itfast.tectoy']/class[@name='UsbControl']/method[@name='sendData' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("sendData", "([B)I", "")]
		public unsafe int SendData (byte[] data)
		{
			const string __id = "sendData.([B)I";
			IntPtr native_data = JNIEnv.NewArray (data);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_data);
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
				return __rm;
			} finally {
				if (data != null) {
					JNIEnv.CopyArray (native_data, data);
					JNIEnv.DeleteLocalRef (native_data);
				}
				global::System.GC.KeepAlive (data);
			}
		}

	}
}
