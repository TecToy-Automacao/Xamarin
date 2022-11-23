using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace BR.Com.Itfast.Tectoy {

	// Metadata.xml XPath class reference: path="/api/package[@name='br.com.itfast.tectoy']/class[@name='Dispositivo']"
	[global::Android.Runtime.Register ("br/com/itfast/tectoy/Dispositivo", DoNotGenerateAcw=true)]
	public sealed partial class Dispositivo : global::Java.Lang.Enum {

		// Metadata.xml XPath field reference: path="/api/package[@name='br.com.itfast.tectoy']/class[@name='Dispositivo']/field[@name='D2S']"
		[Register ("D2S")]
		public static global::BR.Com.Itfast.Tectoy.Dispositivo D2s {
			get {
				const string __id = "D2S.Lbr/com/itfast/tectoy/Dispositivo;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::BR.Com.Itfast.Tectoy.Dispositivo> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='br.com.itfast.tectoy']/class[@name='Dispositivo']/field[@name='D2_MINI']"
		[Register ("D2_MINI")]
		public static global::BR.Com.Itfast.Tectoy.Dispositivo D2Mini {
			get {
				const string __id = "D2_MINI.Lbr/com/itfast/tectoy/Dispositivo;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::BR.Com.Itfast.Tectoy.Dispositivo> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='br.com.itfast.tectoy']/class[@name='Dispositivo']/field[@name='DESCONHECIDO']"
		[Register ("DESCONHECIDO")]
		public static global::BR.Com.Itfast.Tectoy.Dispositivo Desconhecido {
			get {
				const string __id = "DESCONHECIDO.Lbr/com/itfast/tectoy/Dispositivo;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::BR.Com.Itfast.Tectoy.Dispositivo> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='br.com.itfast.tectoy']/class[@name='Dispositivo']/field[@name='K2']"
		[Register ("K2")]
		public static global::BR.Com.Itfast.Tectoy.Dispositivo K2 {
			get {
				const string __id = "K2.Lbr/com/itfast/tectoy/Dispositivo;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::BR.Com.Itfast.Tectoy.Dispositivo> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='br.com.itfast.tectoy']/class[@name='Dispositivo']/field[@name='T2_MINI']"
		[Register ("T2_MINI")]
		public static global::BR.Com.Itfast.Tectoy.Dispositivo T2Mini {
			get {
				const string __id = "T2_MINI.Lbr/com/itfast/tectoy/Dispositivo;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::BR.Com.Itfast.Tectoy.Dispositivo> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='br.com.itfast.tectoy']/class[@name='Dispositivo']/field[@name='V2']"
		[Register ("V2")]
		public static global::BR.Com.Itfast.Tectoy.Dispositivo V2 {
			get {
				const string __id = "V2.Lbr/com/itfast/tectoy/Dispositivo;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::BR.Com.Itfast.Tectoy.Dispositivo> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='br.com.itfast.tectoy']/class[@name='Dispositivo']/field[@name='V2_PRO']"
		[Register ("V2_PRO")]
		public static global::BR.Com.Itfast.Tectoy.Dispositivo V2Pro {
			get {
				const string __id = "V2_PRO.Lbr/com/itfast/tectoy/Dispositivo;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::BR.Com.Itfast.Tectoy.Dispositivo> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("br/com/itfast/tectoy/Dispositivo", typeof (Dispositivo));

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

		internal Dispositivo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.itfast.tectoy']/class[@name='Dispositivo']/method[@name='obtemDispositivo' and count(parameter)=0]"
		[Register ("obtemDispositivo", "()I", "")]
		private unsafe int ObtemDispositivo ()
		{
			const string __id = "obtemDispositivo.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.itfast.tectoy']/class[@name='Dispositivo']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lbr/com/itfast/tectoy/Dispositivo;", "")]
		public static unsafe global::BR.Com.Itfast.Tectoy.Dispositivo ValueOf (string name)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lbr/com/itfast/tectoy/Dispositivo;";
			IntPtr native_name = JNIEnv.NewString ((string)name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::BR.Com.Itfast.Tectoy.Dispositivo> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.itfast.tectoy']/class[@name='Dispositivo']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lbr/com/itfast/tectoy/Dispositivo;", "")]
		public static unsafe global::BR.Com.Itfast.Tectoy.Dispositivo[] Values ()
		{
			const string __id = "values.()[Lbr/com/itfast/tectoy/Dispositivo;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::BR.Com.Itfast.Tectoy.Dispositivo[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::BR.Com.Itfast.Tectoy.Dispositivo));
			} finally {
			}
		}

	}
}
