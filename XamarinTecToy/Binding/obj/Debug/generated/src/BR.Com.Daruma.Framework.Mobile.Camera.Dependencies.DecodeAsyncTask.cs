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

namespace BR.Com.Daruma.Framework.Mobile.Camera.Dependencies {

	// Metadata.xml XPath class reference: path="/api/package[@name='br.com.daruma.framework.mobile.camera.dependencies']/class[@name='DecodeAsyncTask']"
	[global::Android.Runtime.Register ("br/com/daruma/framework/mobile/camera/dependencies/DecodeAsyncTask", DoNotGenerateAcw=true)]
	public partial class DecodeAsyncTask : global::Android.OS.AsyncTask {
		// Metadata.xml XPath field reference: path="/api/package[@name='br.com.daruma.framework.mobile.camera.dependencies']/class[@name='DecodeAsyncTask']/field[@name='BARCODE_BITMAP']"
		[Register ("BARCODE_BITMAP")]
		public const string BarcodeBitmap = (string) "barcode_bitmap";

		static readonly JniPeerMembers _members = new XAPeerMembers ("br/com/daruma/framework/mobile/camera/dependencies/DecodeAsyncTask", typeof (DecodeAsyncTask));

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

		protected DecodeAsyncTask (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
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
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Daruma.Framework.Mobile.Camera.Dependencies.DecodeAsyncTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Handler);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.OS.Handler Handler {
			// Metadata.xml XPath method reference: path="/api/package[@name='br.com.daruma.framework.mobile.camera.dependencies']/class[@name='DecodeAsyncTask']/method[@name='getHandler' and count(parameter)=0]"
			[Register ("getHandler", "()Landroid/os/Handler;", "GetGetHandlerHandler")]
			get {
				const string __id = "getHandler.()Landroid/os/Handler;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.OS.Handler> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_doInBackground_arrayLjava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetDoInBackground_arrayLjava_lang_Integer_Handler ()
		{
			if (cb_doInBackground_arrayLjava_lang_Integer_ == null)
				cb_doInBackground_arrayLjava_lang_Integer_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_L (n_DoInBackground_arrayLjava_lang_Integer_));
			return cb_doInBackground_arrayLjava_lang_Integer_;
		}

		static IntPtr n_DoInBackground_arrayLjava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Daruma.Framework.Mobile.Camera.Dependencies.DecodeAsyncTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Java.Lang.Integer[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Integer));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.DoInBackground (p0));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.daruma.framework.mobile.camera.dependencies']/class[@name='DecodeAsyncTask']/method[@name='doInBackground' and count(parameter)=1 and parameter[1][@type='java.lang.Integer...']]"
		[Register ("doInBackground", "([Ljava/lang/Integer;)Ljava/lang/Void;", "GetDoInBackground_arrayLjava_lang_Integer_Handler")]
		public virtual unsafe global::Java.Lang.Void DoInBackground (params global::Java.Lang.Integer[] p0)
		{
			const string __id = "doInBackground.([Ljava/lang/Integer;)Ljava/lang/Void;";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Void> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				global::System.GC.KeepAlive (p0);
			}
		}

        protected override Java.Lang.Object DoInBackground(params Java.Lang.Object[] @params)
        {
            throw new NotImplementedException();
        }
    }
}