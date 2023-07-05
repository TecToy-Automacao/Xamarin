using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace BR.Com.Daruma.Framework.Mobile.Log.Listeners {

	// Metadata.xml XPath interface reference: path="/api/package[@name='br.com.daruma.framework.mobile.log.listeners']/interface[@name='ITraceListener']"
	[Register ("br/com/daruma/framework/mobile/log/listeners/ITraceListener", "", "BR.Com.Daruma.Framework.Mobile.Log.Listeners.ITraceListenerInvoker")]
	public partial interface ITraceListener : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.daruma.framework.mobile.log.listeners']/interface[@name='ITraceListener']/method[@name='check' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register ("check", "(ILjava/lang/String;)Z", "GetCheck_ILjava_lang_String_Handler:BR.Com.Daruma.Framework.Mobile.Log.Listeners.ITraceListenerInvoker, Binding")]
		bool Check (int p0, string p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.daruma.framework.mobile.log.listeners']/interface[@name='ITraceListener']/method[@name='traceOcurred' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.util.Date']]"
		[Register ("traceOcurred", "(ILjava/lang/String;Ljava/lang/String;Ljava/util/Date;)V", "GetTraceOcurred_ILjava_lang_String_Ljava_lang_String_Ljava_util_Date_Handler:BR.Com.Daruma.Framework.Mobile.Log.Listeners.ITraceListenerInvoker, Binding")]
		void TraceOcurred (int p0, string p1, string p2, global::Java.Util.Date p3);

	}

	[global::Android.Runtime.Register ("br/com/daruma/framework/mobile/log/listeners/ITraceListener", DoNotGenerateAcw=true)]
	internal partial class ITraceListenerInvoker : global::Java.Lang.Object, ITraceListener {
		static readonly JniPeerMembers _members = new XAPeerMembers ("br/com/daruma/framework/mobile/log/listeners/ITraceListener", typeof (ITraceListenerInvoker));

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

		public static ITraceListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ITraceListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'br.com.daruma.framework.mobile.log.listeners.ITraceListener'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ITraceListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_check_ILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetCheck_ILjava_lang_String_Handler ()
		{
			if (cb_check_ILjava_lang_String_ == null)
				cb_check_ILjava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIL_Z (n_Check_ILjava_lang_String_));
			return cb_check_ILjava_lang_String_;
		}

		static bool n_Check_ILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Daruma.Framework.Mobile.Log.Listeners.ITraceListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Check (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_check_ILjava_lang_String_;
		public unsafe bool Check (int p0, string p1)
		{
			if (id_check_ILjava_lang_String_ == IntPtr.Zero)
				id_check_ILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "check", "(ILjava/lang/String;)Z");
			IntPtr native_p1 = JNIEnv.NewString ((string)p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			var __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_check_ILjava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static Delegate cb_traceOcurred_ILjava_lang_String_Ljava_lang_String_Ljava_util_Date_;
#pragma warning disable 0169
		static Delegate GetTraceOcurred_ILjava_lang_String_Ljava_lang_String_Ljava_util_Date_Handler ()
		{
			if (cb_traceOcurred_ILjava_lang_String_Ljava_lang_String_Ljava_util_Date_ == null)
				cb_traceOcurred_ILjava_lang_String_Ljava_lang_String_Ljava_util_Date_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPILLL_V (n_TraceOcurred_ILjava_lang_String_Ljava_lang_String_Ljava_util_Date_));
			return cb_traceOcurred_ILjava_lang_String_Ljava_lang_String_Ljava_util_Date_;
		}

		static void n_TraceOcurred_ILjava_lang_String_Ljava_lang_String_Ljava_util_Date_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Daruma.Framework.Mobile.Log.Listeners.ITraceListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			var p3 = global::Java.Lang.Object.GetObject<global::Java.Util.Date> (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.TraceOcurred (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		IntPtr id_traceOcurred_ILjava_lang_String_Ljava_lang_String_Ljava_util_Date_;
		public unsafe void TraceOcurred (int p0, string p1, string p2, global::Java.Util.Date p3)
		{
			if (id_traceOcurred_ILjava_lang_String_Ljava_lang_String_Ljava_util_Date_ == IntPtr.Zero)
				id_traceOcurred_ILjava_lang_String_Ljava_lang_String_Ljava_util_Date_ = JNIEnv.GetMethodID (class_ref, "traceOcurred", "(ILjava/lang/String;Ljava/lang/String;Ljava/util/Date;)V");
			IntPtr native_p1 = JNIEnv.NewString ((string)p1);
			IntPtr native_p2 = JNIEnv.NewString ((string)p2);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_traceOcurred_ILjava_lang_String_Ljava_lang_String_Ljava_util_Date_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
		}

	}

	// event args for br.com.daruma.framework.mobile.log.listeners.ITraceListener.check
	public partial class CheckEventArgs : global::System.EventArgs {
		bool handled;

		public bool Handled {
			get { return handled; }
			set { handled = value; }
		}

		public CheckEventArgs (bool handled, int p0, string p1)
		{
			this.handled = handled;
			this.p0 = p0;
			this.p1 = p1;
		}

		int p0;

		public int P0 {
			get { return p0; }
		}

		string p1;

		public string P1 {
			get { return p1; }
		}

	}

	// event args for br.com.daruma.framework.mobile.log.listeners.ITraceListener.traceOcurred
	public partial class TraceOcurredEventArgs : global::System.EventArgs {
		public TraceOcurredEventArgs (int p0, string p1, string p2, global::Java.Util.Date p3)
		{
			this.p0 = p0;
			this.p1 = p1;
			this.p2 = p2;
			this.p3 = p3;
		}

		int p0;

		public int P0 {
			get { return p0; }
		}

		string p1;

		public string P1 {
			get { return p1; }
		}

		string p2;

		public string P2 {
			get { return p2; }
		}

		global::Java.Util.Date p3;

		public global::Java.Util.Date P3 {
			get { return p3; }
		}

	}

	[global::Android.Runtime.Register ("mono/br/com/daruma/framework/mobile/log/listeners/ITraceListenerImplementor")]
	internal sealed partial class ITraceListenerImplementor : global::Java.Lang.Object, ITraceListener {

		object sender;

		public ITraceListenerImplementor (object sender) : base (global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/br/com/daruma/framework/mobile/log/listeners/ITraceListenerImplementor", "()V"), JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

		#pragma warning disable 0649
		public EventHandler<CheckEventArgs> CheckHandler;
		#pragma warning restore 0649

		public bool Check (int p0, string p1)
		{
			var __h = CheckHandler;
			if (__h == null)
				return false;
			var __e = new CheckEventArgs (true, p0, p1);
			__h (sender, __e);
			return __e.Handled;
		}

		#pragma warning disable 0649
		public EventHandler<TraceOcurredEventArgs> TraceOcurredHandler;
		#pragma warning restore 0649

		public void TraceOcurred (int p0, string p1, string p2, global::Java.Util.Date p3)
		{
			var __h = TraceOcurredHandler;
			if (__h != null)
				__h (sender, new TraceOcurredEventArgs (p0, p1, p2, p3));
		}

		internal static bool __IsEmpty (ITraceListenerImplementor value)
		{
			return value.CheckHandler == null && value.TraceOcurredHandler == null;
		}

	}
}
