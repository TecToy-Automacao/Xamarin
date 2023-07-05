using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace BR.Com.Daruma.Framework.Mobile.Camera.Dependencies {

	// Metadata.xml XPath interface reference: path="/api/package[@name='br.com.daruma.framework.mobile.camera.dependencies']/interface[@name='ISendHandler']"
	[Register ("br/com/daruma/framework/mobile/camera/dependencies/ISendHandler", "", "BR.Com.Daruma.Framework.Mobile.Camera.Dependencies.ISendHandlerInvoker")]
	public partial interface ISendHandler : IJavaObject, IJavaPeerable {
		global::Android.OS.Handler Handler {
			// Metadata.xml XPath method reference: path="/api/package[@name='br.com.daruma.framework.mobile.camera.dependencies']/interface[@name='ISendHandler']/method[@name='getHandler' and count(parameter)=0]"
			[Register ("getHandler", "()Landroid/os/Handler;", "GetGetHandlerHandler:BR.Com.Daruma.Framework.Mobile.Camera.Dependencies.ISendHandlerInvoker, Binding")]
			get; 
		}

	}

	[global::Android.Runtime.Register ("br/com/daruma/framework/mobile/camera/dependencies/ISendHandler", DoNotGenerateAcw=true)]
	internal partial class ISendHandlerInvoker : global::Java.Lang.Object, ISendHandler {
		static readonly JniPeerMembers _members = new XAPeerMembers ("br/com/daruma/framework/mobile/camera/dependencies/ISendHandler", typeof (ISendHandlerInvoker));

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

		public static ISendHandler GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ISendHandler> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'br.com.daruma.framework.mobile.camera.dependencies.ISendHandler'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ISendHandlerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getHandler;
#pragma warning disable 0169
		static Delegate GetGetHandlerHandler ()
		{
			if (cb_getHandler == null)
				cb_getHandler = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetHandler));
			return cb_getHandler;
		}

		static IntPtr n_GetHandler (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Daruma.Framework.Mobile.Camera.Dependencies.ISendHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Handler);
		}
#pragma warning restore 0169

		IntPtr id_getHandler;
		public unsafe global::Android.OS.Handler Handler {
			get {
				if (id_getHandler == IntPtr.Zero)
					id_getHandler = JNIEnv.GetMethodID (class_ref, "getHandler", "()Landroid/os/Handler;");
				return global::Java.Lang.Object.GetObject<global::Android.OS.Handler> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getHandler), JniHandleOwnership.TransferLocalRef);
			}
		}

	}
}
