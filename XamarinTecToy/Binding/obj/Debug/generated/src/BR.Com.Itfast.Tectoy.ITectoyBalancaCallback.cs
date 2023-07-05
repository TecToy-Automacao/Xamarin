using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace BR.Com.Itfast.Tectoy {

	// Metadata.xml XPath interface reference: path="/api/package[@name='br.com.itfast.tectoy']/interface[@name='TectoyBalancaCallback']"
	[Register ("br/com/itfast/tectoy/TectoyBalancaCallback", "", "BR.Com.Itfast.Tectoy.ITectoyBalancaCallbackInvoker")]
	public partial interface ITectoyBalancaCallback : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.itfast.tectoy']/interface[@name='TectoyBalancaCallback']/method[@name='retornaPeso' and count(parameter)=1 and parameter[1][@type='java.util.Map']]"
		[Register ("retornaPeso", "(Ljava/util/Map;)V", "GetRetornaPeso_Ljava_util_Map_Handler:BR.Com.Itfast.Tectoy.ITectoyBalancaCallbackInvoker, Binding")]
		void RetornaPeso (global::System.Collections.IDictionary p0);

	}

	[global::Android.Runtime.Register ("br/com/itfast/tectoy/TectoyBalancaCallback", DoNotGenerateAcw=true)]
	internal partial class ITectoyBalancaCallbackInvoker : global::Java.Lang.Object, ITectoyBalancaCallback {
		static readonly JniPeerMembers _members = new XAPeerMembers ("br/com/itfast/tectoy/TectoyBalancaCallback", typeof (ITectoyBalancaCallbackInvoker));

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

		public static ITectoyBalancaCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ITectoyBalancaCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'br.com.itfast.tectoy.TectoyBalancaCallback'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ITectoyBalancaCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_retornaPeso_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetRetornaPeso_Ljava_util_Map_Handler ()
		{
			if (cb_retornaPeso_Ljava_util_Map_ == null)
				cb_retornaPeso_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_RetornaPeso_Ljava_util_Map_));
			return cb_retornaPeso_Ljava_util_Map_;
		}

		static void n_RetornaPeso_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Itfast.Tectoy.ITectoyBalancaCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaDictionary.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RetornaPeso (p0);
		}
#pragma warning restore 0169

		IntPtr id_retornaPeso_Ljava_util_Map_;
		public unsafe void RetornaPeso (global::System.Collections.IDictionary p0)
		{
			if (id_retornaPeso_Ljava_util_Map_ == IntPtr.Zero)
				id_retornaPeso_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "retornaPeso", "(Ljava/util/Map;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_retornaPeso_Ljava_util_Map_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}
}
