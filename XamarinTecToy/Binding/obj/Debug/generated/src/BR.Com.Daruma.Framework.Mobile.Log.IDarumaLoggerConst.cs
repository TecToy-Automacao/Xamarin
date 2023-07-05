using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace BR.Com.Daruma.Framework.Mobile.Log {

	[Register ("br/com/daruma/framework/mobile/log/DarumaLoggerConst", DoNotGenerateAcw=true)]
	public abstract class DarumaLoggerConst : Java.Lang.Object {
		internal DarumaLoggerConst ()
		{
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='br.com.daruma.framework.mobile.log']/interface[@name='DarumaLoggerConst']/field[@name='BLUETOOTH']"
		[Register ("BLUETOOTH")]
		public const string Bluetooth = (string) "BLUETOOTH";

		// Metadata.xml XPath field reference: path="/api/package[@name='br.com.daruma.framework.mobile.log']/interface[@name='DarumaLoggerConst']/field[@name='COMUNICACAO']"
		[Register ("COMUNICACAO")]
		public const string Comunicacao = (string) "COMUNICACAO";

		// Metadata.xml XPath field reference: path="/api/package[@name='br.com.daruma.framework.mobile.log']/interface[@name='DarumaLoggerConst']/field[@name='FRAMEWORK']"
		[Register ("FRAMEWORK")]
		public const string Framework = (string) "FRAMEWORK";

		// Metadata.xml XPath field reference: path="/api/package[@name='br.com.daruma.framework.mobile.log']/interface[@name='DarumaLoggerConst']/field[@name='LVL_API']"
		[Register ("LVL_API")]
		public const int LvlApi = (int) 4096;

		// Metadata.xml XPath field reference: path="/api/package[@name='br.com.daruma.framework.mobile.log']/interface[@name='DarumaLoggerConst']/field[@name='LVL_DEBUG']"
		[Register ("LVL_DEBUG")]
		public const int LvlDebug = (int) 256;

		// Metadata.xml XPath field reference: path="/api/package[@name='br.com.daruma.framework.mobile.log']/interface[@name='DarumaLoggerConst']/field[@name='LVL_ENTRADA']"
		[Register ("LVL_ENTRADA")]
		public const int LvlEntrada = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='br.com.daruma.framework.mobile.log']/interface[@name='DarumaLoggerConst']/field[@name='LVL_ERRO']"
		[Register ("LVL_ERRO")]
		public const int LvlErro = (int) 65536;

		// Metadata.xml XPath field reference: path="/api/package[@name='br.com.daruma.framework.mobile.log']/interface[@name='DarumaLoggerConst']/field[@name='LVL_SAIDA']"
		[Register ("LVL_SAIDA")]
		public const int LvlSaida = (int) 16;

		// Metadata.xml XPath field reference: path="/api/package[@name='br.com.daruma.framework.mobile.log']/interface[@name='DarumaLoggerConst']/field[@name='NAO_IMPLEMENTADA']"
		[Register ("NAO_IMPLEMENTADA")]
		public const string NaoImplementada = (string) "NAO_IMPLEMENTADA";

		// Metadata.xml XPath field reference: path="/api/package[@name='br.com.daruma.framework.mobile.log']/interface[@name='DarumaLoggerConst']/field[@name='SCANNER']"
		[Register ("SCANNER")]
		public const string Scanner = (string) "SCANNER";

		// Metadata.xml XPath field reference: path="/api/package[@name='br.com.daruma.framework.mobile.log']/interface[@name='DarumaLoggerConst']/field[@name='SERIAL']"
		[Register ("SERIAL")]
		public const string Serial = (string) "SERIAL";

		// Metadata.xml XPath field reference: path="/api/package[@name='br.com.daruma.framework.mobile.log']/interface[@name='DarumaLoggerConst']/field[@name='SOCKET']"
		[Register ("SOCKET")]
		public const string Socket = (string) "SOCKET";

		// Metadata.xml XPath field reference: path="/api/package[@name='br.com.daruma.framework.mobile.log']/interface[@name='DarumaLoggerConst']/field[@name='USB']"
		[Register ("USB")]
		public const string Usb = (string) "USB";

	}

	[Register ("br/com/daruma/framework/mobile/log/DarumaLoggerConst", DoNotGenerateAcw=true)]
	[global::System.Obsolete (@"Use the 'DarumaLoggerConst' type. This type will be removed in a future release.", error: true)]
	public abstract class DarumaLoggerConstConsts : DarumaLoggerConst {
		private DarumaLoggerConstConsts ()
		{
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='br.com.daruma.framework.mobile.log']/interface[@name='DarumaLoggerConst']"
	[Register ("br/com/daruma/framework/mobile/log/DarumaLoggerConst", "", "BR.Com.Daruma.Framework.Mobile.Log.IDarumaLoggerConstInvoker")]
	public partial interface IDarumaLoggerConst : IJavaObject, IJavaPeerable {
	}

	[global::Android.Runtime.Register ("br/com/daruma/framework/mobile/log/DarumaLoggerConst", DoNotGenerateAcw=true)]
	internal partial class IDarumaLoggerConstInvoker : global::Java.Lang.Object, IDarumaLoggerConst {
		static readonly JniPeerMembers _members = new XAPeerMembers ("br/com/daruma/framework/mobile/log/DarumaLoggerConst", typeof (IDarumaLoggerConstInvoker));

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

		public static IDarumaLoggerConst GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IDarumaLoggerConst> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'br.com.daruma.framework.mobile.log.DarumaLoggerConst'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IDarumaLoggerConstInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

	}
}
