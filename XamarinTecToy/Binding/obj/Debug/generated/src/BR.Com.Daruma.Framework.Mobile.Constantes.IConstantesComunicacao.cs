using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace BR.Com.Daruma.Framework.Mobile.Constantes {

	// Metadata.xml XPath interface reference: path="/api/package[@name='br.com.daruma.framework.mobile.constantes']/interface[@name='IConstantesComunicacao']"
	[Register ("br/com/daruma/framework/mobile/constantes/IConstantesComunicacao", "", "BR.Com.Daruma.Framework.Mobile.Constantes.IConstantesComunicacaoInvoker")]
	public partial interface IConstantesComunicacao : IJavaObject, IJavaPeerable {
		global::BR.Com.Daruma.Framework.Mobile.Constantes.IConstantesComunicacao TagNome {
			// Metadata.xml XPath method reference: path="/api/package[@name='br.com.daruma.framework.mobile.constantes']/interface[@name='IConstantesComunicacao']/method[@name='getTagNome' and count(parameter)=0]"
			[Register ("getTagNome", "()Lbr/com/daruma/framework/mobile/constantes/IConstantesComunicacao;", "GetGetTagNomeHandler:BR.Com.Daruma.Framework.Mobile.Constantes.IConstantesComunicacaoInvoker, Binding")]
			get; 
		}

	}

	[global::Android.Runtime.Register ("br/com/daruma/framework/mobile/constantes/IConstantesComunicacao", DoNotGenerateAcw=true)]
	internal partial class IConstantesComunicacaoInvoker : global::Java.Lang.Object, IConstantesComunicacao {
		static readonly JniPeerMembers _members = new XAPeerMembers ("br/com/daruma/framework/mobile/constantes/IConstantesComunicacao", typeof (IConstantesComunicacaoInvoker));

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

		public static IConstantesComunicacao GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IConstantesComunicacao> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'br.com.daruma.framework.mobile.constantes.IConstantesComunicacao'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IConstantesComunicacaoInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getTagNome;
#pragma warning disable 0169
		static Delegate GetGetTagNomeHandler ()
		{
			if (cb_getTagNome == null)
				cb_getTagNome = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetTagNome));
			return cb_getTagNome;
		}

		static IntPtr n_GetTagNome (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Daruma.Framework.Mobile.Constantes.IConstantesComunicacao> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TagNome);
		}
#pragma warning restore 0169

		IntPtr id_getTagNome;
		public unsafe global::BR.Com.Daruma.Framework.Mobile.Constantes.IConstantesComunicacao TagNome {
			get {
				if (id_getTagNome == IntPtr.Zero)
					id_getTagNome = JNIEnv.GetMethodID (class_ref, "getTagNome", "()Lbr/com/daruma/framework/mobile/constantes/IConstantesComunicacao;");
				return global::Java.Lang.Object.GetObject<global::BR.Com.Daruma.Framework.Mobile.Constantes.IConstantesComunicacao> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTagNome), JniHandleOwnership.TransferLocalRef);
			}
		}

	}
}
