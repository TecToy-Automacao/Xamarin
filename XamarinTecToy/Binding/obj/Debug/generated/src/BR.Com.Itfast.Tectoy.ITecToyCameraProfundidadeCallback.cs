using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace BR.Com.Itfast.Tectoy {

	// Metadata.xml XPath interface reference: path="/api/package[@name='br.com.itfast.tectoy']/interface[@name='TecToyCameraProfundidadeCallback']"
	[Register ("br/com/itfast/tectoy/TecToyCameraProfundidadeCallback", "", "BR.Com.Itfast.Tectoy.ITecToyCameraProfundidadeCallbackInvoker")]
	public partial interface ITecToyCameraProfundidadeCallback : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.itfast.tectoy']/interface[@name='TecToyCameraProfundidadeCallback']/method[@name='retornarDistancia' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("retornarDistancia", "(I)V", "GetRetornarDistancia_IHandler:BR.Com.Itfast.Tectoy.ITecToyCameraProfundidadeCallbackInvoker, Binding")]
		void RetornarDistancia (int p0);

	}

	[global::Android.Runtime.Register ("br/com/itfast/tectoy/TecToyCameraProfundidadeCallback", DoNotGenerateAcw=true)]
	internal partial class ITecToyCameraProfundidadeCallbackInvoker : global::Java.Lang.Object, ITecToyCameraProfundidadeCallback {
		static readonly JniPeerMembers _members = new XAPeerMembers ("br/com/itfast/tectoy/TecToyCameraProfundidadeCallback", typeof (ITecToyCameraProfundidadeCallbackInvoker));

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

		public static ITecToyCameraProfundidadeCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ITecToyCameraProfundidadeCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'br.com.itfast.tectoy.TecToyCameraProfundidadeCallback'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ITecToyCameraProfundidadeCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_retornarDistancia_I;
#pragma warning disable 0169
		static Delegate GetRetornarDistancia_IHandler ()
		{
			if (cb_retornarDistancia_I == null)
				cb_retornarDistancia_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_V (n_RetornarDistancia_I));
			return cb_retornarDistancia_I;
		}

		static void n_RetornarDistancia_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Itfast.Tectoy.ITecToyCameraProfundidadeCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RetornarDistancia (p0);
		}
#pragma warning restore 0169

		IntPtr id_retornarDistancia_I;
		public unsafe void RetornarDistancia (int p0)
		{
			if (id_retornarDistancia_I == IntPtr.Zero)
				id_retornarDistancia_I = JNIEnv.GetMethodID (class_ref, "retornarDistancia", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_retornarDistancia_I, __args);
		}

	}
}
