using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Woyou.Aidlservice.Jiuiv5 {

	// Metadata.xml XPath class reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/class[@name='IWoyouService.Default']"
	[global::Android.Runtime.Register ("woyou/aidlservice/jiuiv5/IWoyouService$Default", DoNotGenerateAcw=true)]
	public partial class WoyouServiceDefault : global::Java.Lang.Object, global::Woyou.Aidlservice.Jiuiv5.IWoyouService {
		static readonly JniPeerMembers _members = new XAPeerMembers ("woyou/aidlservice/jiuiv5/IWoyouService$Default", typeof (WoyouServiceDefault));

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

		protected WoyouServiceDefault (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/class[@name='IWoyouService.Default']/constructor[@name='IWoyouService.Default' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe WoyouServiceDefault () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_getCutPaperTimes;
#pragma warning disable 0169
		static Delegate GetGetCutPaperTimesHandler ()
		{
			if (cb_getCutPaperTimes == null)
				cb_getCutPaperTimes = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetCutPaperTimes);
			return cb_getCutPaperTimes;
		}

		static int n_GetCutPaperTimes (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.WoyouServiceDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CutPaperTimes;
		}
#pragma warning restore 0169

		public virtual unsafe int CutPaperTimes {
			// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/class[@name='IWoyouService.Default']/method[@name='getCutPaperTimes' and count(parameter)=0]"
			[Register ("getCutPaperTimes", "()I", "GetGetCutPaperTimesHandler")]
			get {
				const string __id = "getCutPaperTimes.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getDrawerStatus;
#pragma warning disable 0169
		static Delegate GetGetDrawerStatusHandler ()
		{
			if (cb_getDrawerStatus == null)
				cb_getDrawerStatus = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_GetDrawerStatus);
			return cb_getDrawerStatus;
		}

		static bool n_GetDrawerStatus (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.WoyouServiceDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DrawerStatus;
		}
#pragma warning restore 0169

		public virtual unsafe bool DrawerStatus {
			// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/class[@name='IWoyouService.Default']/method[@name='getDrawerStatus' and count(parameter)=0]"
			[Register ("getDrawerStatus", "()Z", "GetGetDrawerStatusHandler")]
			get {
				const string __id = "getDrawerStatus.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getFirmwareStatus;
#pragma warning disable 0169
		static Delegate GetGetFirmwareStatusHandler ()
		{
			if (cb_getFirmwareStatus == null)
				cb_getFirmwareStatus = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetFirmwareStatus);
			return cb_getFirmwareStatus;
		}

		static int n_GetFirmwareStatus (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.WoyouServiceDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.FirmwareStatus;
		}
#pragma warning restore 0169

		public virtual unsafe int FirmwareStatus {
			// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/class[@name='IWoyouService.Default']/method[@name='getFirmwareStatus' and count(parameter)=0]"
			[Register ("getFirmwareStatus", "()I", "GetGetFirmwareStatusHandler")]
			get {
				const string __id = "getFirmwareStatus.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getOpenDrawerTimes;
#pragma warning disable 0169
		static Delegate GetGetOpenDrawerTimesHandler ()
		{
			if (cb_getOpenDrawerTimes == null)
				cb_getOpenDrawerTimes = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetOpenDrawerTimes);
			return cb_getOpenDrawerTimes;
		}

		static int n_GetOpenDrawerTimes (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.WoyouServiceDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.OpenDrawerTimes;
		}
#pragma warning restore 0169

		public virtual unsafe int OpenDrawerTimes {
			// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/class[@name='IWoyouService.Default']/method[@name='getOpenDrawerTimes' and count(parameter)=0]"
			[Register ("getOpenDrawerTimes", "()I", "GetGetOpenDrawerTimesHandler")]
			get {
				const string __id = "getOpenDrawerTimes.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getPrintedLength;
#pragma warning disable 0169
		static Delegate GetGetPrintedLengthHandler ()
		{
			if (cb_getPrintedLength == null)
				cb_getPrintedLength = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetPrintedLength);
			return cb_getPrintedLength;
		}

		static int n_GetPrintedLength (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.WoyouServiceDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PrintedLength;
		}
#pragma warning restore 0169

		public virtual unsafe int PrintedLength {
			// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/class[@name='IWoyouService.Default']/method[@name='getPrintedLength' and count(parameter)=0]"
			[Register ("getPrintedLength", "()I", "GetGetPrintedLengthHandler")]
			get {
				const string __id = "getPrintedLength.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getPrinterBBMDistance;
#pragma warning disable 0169
		static Delegate GetGetPrinterBBMDistanceHandler ()
		{
			if (cb_getPrinterBBMDistance == null)
				cb_getPrinterBBMDistance = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetPrinterBBMDistance);
			return cb_getPrinterBBMDistance;
		}

		static int n_GetPrinterBBMDistance (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.WoyouServiceDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PrinterBBMDistance;
		}
#pragma warning restore 0169

		public virtual unsafe int PrinterBBMDistance {
			// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/class[@name='IWoyouService.Default']/method[@name='getPrinterBBMDistance' and count(parameter)=0]"
			[Register ("getPrinterBBMDistance", "()I", "GetGetPrinterBBMDistanceHandler")]
			get {
				const string __id = "getPrinterBBMDistance.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getPrinterModal;
#pragma warning disable 0169
		static Delegate GetGetPrinterModalHandler ()
		{
			if (cb_getPrinterModal == null)
				cb_getPrinterModal = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetPrinterModal);
			return cb_getPrinterModal;
		}

		static IntPtr n_GetPrinterModal (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.WoyouServiceDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.PrinterModal);
		}
#pragma warning restore 0169

		public virtual unsafe string PrinterModal {
			// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/class[@name='IWoyouService.Default']/method[@name='getPrinterModal' and count(parameter)=0]"
			[Register ("getPrinterModal", "()Ljava/lang/String;", "GetGetPrinterModalHandler")]
			get {
				const string __id = "getPrinterModal.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getPrinterMode;
#pragma warning disable 0169
		static Delegate GetGetPrinterModeHandler ()
		{
			if (cb_getPrinterMode == null)
				cb_getPrinterMode = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetPrinterMode);
			return cb_getPrinterMode;
		}

		static int n_GetPrinterMode (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.WoyouServiceDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PrinterMode;
		}
#pragma warning restore 0169

		public virtual unsafe int PrinterMode {
			// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/class[@name='IWoyouService.Default']/method[@name='getPrinterMode' and count(parameter)=0]"
			[Register ("getPrinterMode", "()I", "GetGetPrinterModeHandler")]
			get {
				const string __id = "getPrinterMode.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getPrinterSerialNo;
#pragma warning disable 0169
		static Delegate GetGetPrinterSerialNoHandler ()
		{
			if (cb_getPrinterSerialNo == null)
				cb_getPrinterSerialNo = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetPrinterSerialNo);
			return cb_getPrinterSerialNo;
		}

		static IntPtr n_GetPrinterSerialNo (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.WoyouServiceDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.PrinterSerialNo);
		}
#pragma warning restore 0169

		public virtual unsafe string PrinterSerialNo {
			// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/class[@name='IWoyouService.Default']/method[@name='getPrinterSerialNo' and count(parameter)=0]"
			[Register ("getPrinterSerialNo", "()Ljava/lang/String;", "GetGetPrinterSerialNoHandler")]
			get {
				const string __id = "getPrinterSerialNo.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getPrinterVersion;
#pragma warning disable 0169
		static Delegate GetGetPrinterVersionHandler ()
		{
			if (cb_getPrinterVersion == null)
				cb_getPrinterVersion = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetPrinterVersion);
			return cb_getPrinterVersion;
		}

		static IntPtr n_GetPrinterVersion (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.WoyouServiceDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.PrinterVersion);
		}
#pragma warning restore 0169

		public virtual unsafe string PrinterVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/class[@name='IWoyouService.Default']/method[@name='getPrinterVersion' and count(parameter)=0]"
			[Register ("getPrinterVersion", "()Ljava/lang/String;", "GetGetPrinterVersionHandler")]
			get {
				const string __id = "getPrinterVersion.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getServiceVersion;
#pragma warning disable 0169
		static Delegate GetGetServiceVersionHandler ()
		{
			if (cb_getServiceVersion == null)
				cb_getServiceVersion = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetServiceVersion);
			return cb_getServiceVersion;
		}

		static IntPtr n_GetServiceVersion (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.WoyouServiceDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ServiceVersion);
		}
#pragma warning restore 0169

		public virtual unsafe string ServiceVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/class[@name='IWoyouService.Default']/method[@name='getServiceVersion' and count(parameter)=0]"
			[Register ("getServiceVersion", "()Ljava/lang/String;", "GetGetServiceVersionHandler")]
			get {
				const string __id = "getServiceVersion.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_asBinder;
#pragma warning disable 0169
		static Delegate GetAsBinderHandler ()
		{
			if (cb_asBinder == null)
				cb_asBinder = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_AsBinder);
			return cb_asBinder;
		}

		static IntPtr n_AsBinder (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.WoyouServiceDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/class[@name='IWoyouService.Default']/method[@name='asBinder' and count(parameter)=0]"
		[Register ("asBinder", "()Landroid/os/IBinder;", "GetAsBinderHandler")]
		public virtual unsafe global::Android.OS.IBinder AsBinder ()
		{
			const string __id = "asBinder.()Landroid/os/IBinder;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_commitPrinterBuffer;
#pragma warning disable 0169
		static Delegate GetCommitPrinterBufferHandler ()
		{
			if (cb_commitPrinterBuffer == null)
				cb_commitPrinterBuffer = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_CommitPrinterBuffer);
			return cb_commitPrinterBuffer;
		}

		static void n_CommitPrinterBuffer (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.WoyouServiceDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CommitPrinterBuffer ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/class[@name='IWoyouService.Default']/method[@name='commitPrinterBuffer' and count(parameter)=0]"
		[Register ("commitPrinterBuffer", "()V", "GetCommitPrinterBufferHandler")]
		public virtual unsafe void CommitPrinterBuffer ()
		{
			const string __id = "commitPrinterBuffer.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_commitPrinterBufferWithCallback_Lwoyou_aidlservice_jiuiv5_ICallback_;
#pragma warning disable 0169
		static Delegate GetCommitPrinterBufferWithCallback_Lwoyou_aidlservice_jiuiv5_ICallback_Handler ()
		{
			if (cb_commitPrinterBufferWithCallback_Lwoyou_aidlservice_jiuiv5_ICallback_ == null)
				cb_commitPrinterBufferWithCallback_Lwoyou_aidlservice_jiuiv5_ICallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_CommitPrinterBufferWithCallback_Lwoyou_aidlservice_jiuiv5_ICallback_);
			return cb_commitPrinterBufferWithCallback_Lwoyou_aidlservice_jiuiv5_ICallback_;
		}

		static void n_CommitPrinterBufferWithCallback_Lwoyou_aidlservice_jiuiv5_ICallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native__callback)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.WoyouServiceDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var @callback = (global::Woyou.Aidlservice.Jiuiv5.ICallback)global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.ICallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.CommitPrinterBufferWithCallback (@callback);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/class[@name='IWoyouService.Default']/method[@name='commitPrinterBufferWithCallback' and count(parameter)=1 and parameter[1][@type='woyou.aidlservice.jiuiv5.ICallback']]"
		[Register ("commitPrinterBufferWithCallback", "(Lwoyou/aidlservice/jiuiv5/ICallback;)V", "GetCommitPrinterBufferWithCallback_Lwoyou_aidlservice_jiuiv5_ICallback_Handler")]
		public virtual unsafe void CommitPrinterBufferWithCallback (global::Woyou.Aidlservice.Jiuiv5.ICallback @callback)
		{
			const string __id = "commitPrinterBufferWithCallback.(Lwoyou/aidlservice/jiuiv5/ICallback;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (@callback);
			}
		}

		static Delegate cb_cutPaper_Lwoyou_aidlservice_jiuiv5_ICallback_;
#pragma warning disable 0169
		static Delegate GetCutPaper_Lwoyou_aidlservice_jiuiv5_ICallback_Handler ()
		{
			if (cb_cutPaper_Lwoyou_aidlservice_jiuiv5_ICallback_ == null)
				cb_cutPaper_Lwoyou_aidlservice_jiuiv5_ICallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_CutPaper_Lwoyou_aidlservice_jiuiv5_ICallback_);
			return cb_cutPaper_Lwoyou_aidlservice_jiuiv5_ICallback_;
		}

		static void n_CutPaper_Lwoyou_aidlservice_jiuiv5_ICallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native__callback)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.WoyouServiceDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var @callback = (global::Woyou.Aidlservice.Jiuiv5.ICallback)global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.ICallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.CutPaper (@callback);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/class[@name='IWoyouService.Default']/method[@name='cutPaper' and count(parameter)=1 and parameter[1][@type='woyou.aidlservice.jiuiv5.ICallback']]"
		[Register ("cutPaper", "(Lwoyou/aidlservice/jiuiv5/ICallback;)V", "GetCutPaper_Lwoyou_aidlservice_jiuiv5_ICallback_Handler")]
		public virtual unsafe void CutPaper (global::Woyou.Aidlservice.Jiuiv5.ICallback @callback)
		{
			const string __id = "cutPaper.(Lwoyou/aidlservice/jiuiv5/ICallback;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (@callback);
			}
		}

		static Delegate cb_enterPrinterBuffer_Z;
#pragma warning disable 0169
		static Delegate GetEnterPrinterBuffer_ZHandler ()
		{
			if (cb_enterPrinterBuffer_Z == null)
				cb_enterPrinterBuffer_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_EnterPrinterBuffer_Z);
			return cb_enterPrinterBuffer_Z;
		}

		static void n_EnterPrinterBuffer_Z (IntPtr jnienv, IntPtr native__this, bool clean)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.WoyouServiceDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.EnterPrinterBuffer (clean);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/class[@name='IWoyouService.Default']/method[@name='enterPrinterBuffer' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("enterPrinterBuffer", "(Z)V", "GetEnterPrinterBuffer_ZHandler")]
		public virtual unsafe void EnterPrinterBuffer (bool clean)
		{
			const string __id = "enterPrinterBuffer.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (clean);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_exitPrinterBuffer_Z;
#pragma warning disable 0169
		static Delegate GetExitPrinterBuffer_ZHandler ()
		{
			if (cb_exitPrinterBuffer_Z == null)
				cb_exitPrinterBuffer_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_ExitPrinterBuffer_Z);
			return cb_exitPrinterBuffer_Z;
		}

		static void n_ExitPrinterBuffer_Z (IntPtr jnienv, IntPtr native__this, bool commit)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.WoyouServiceDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ExitPrinterBuffer (commit);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/class[@name='IWoyouService.Default']/method[@name='exitPrinterBuffer' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("exitPrinterBuffer", "(Z)V", "GetExitPrinterBuffer_ZHandler")]
		public virtual unsafe void ExitPrinterBuffer (bool commit)
		{
			const string __id = "exitPrinterBuffer.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (commit);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_exitPrinterBufferWithCallback_ZLwoyou_aidlservice_jiuiv5_ICallback_;
#pragma warning disable 0169
		static Delegate GetExitPrinterBufferWithCallback_ZLwoyou_aidlservice_jiuiv5_ICallback_Handler ()
		{
			if (cb_exitPrinterBufferWithCallback_ZLwoyou_aidlservice_jiuiv5_ICallback_ == null)
				cb_exitPrinterBufferWithCallback_ZLwoyou_aidlservice_jiuiv5_ICallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZL_V) n_ExitPrinterBufferWithCallback_ZLwoyou_aidlservice_jiuiv5_ICallback_);
			return cb_exitPrinterBufferWithCallback_ZLwoyou_aidlservice_jiuiv5_ICallback_;
		}

		static void n_ExitPrinterBufferWithCallback_ZLwoyou_aidlservice_jiuiv5_ICallback_ (IntPtr jnienv, IntPtr native__this, bool commit, IntPtr native__callback)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.WoyouServiceDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var @callback = (global::Woyou.Aidlservice.Jiuiv5.ICallback)global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.ICallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.ExitPrinterBufferWithCallback (commit, @callback);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/class[@name='IWoyouService.Default']/method[@name='exitPrinterBufferWithCallback' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='woyou.aidlservice.jiuiv5.ICallback']]"
		[Register ("exitPrinterBufferWithCallback", "(ZLwoyou/aidlservice/jiuiv5/ICallback;)V", "GetExitPrinterBufferWithCallback_ZLwoyou_aidlservice_jiuiv5_ICallback_Handler")]
		public virtual unsafe void ExitPrinterBufferWithCallback (bool commit, global::Woyou.Aidlservice.Jiuiv5.ICallback @callback)
		{
			const string __id = "exitPrinterBufferWithCallback.(ZLwoyou/aidlservice/jiuiv5/ICallback;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (commit);
				__args [1] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (@callback);
			}
		}

		static Delegate cb_lineWrap_ILwoyou_aidlservice_jiuiv5_ICallback_;
#pragma warning disable 0169
		static Delegate GetLineWrap_ILwoyou_aidlservice_jiuiv5_ICallback_Handler ()
		{
			if (cb_lineWrap_ILwoyou_aidlservice_jiuiv5_ICallback_ == null)
				cb_lineWrap_ILwoyou_aidlservice_jiuiv5_ICallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIL_V) n_LineWrap_ILwoyou_aidlservice_jiuiv5_ICallback_);
			return cb_lineWrap_ILwoyou_aidlservice_jiuiv5_ICallback_;
		}

		static void n_LineWrap_ILwoyou_aidlservice_jiuiv5_ICallback_ (IntPtr jnienv, IntPtr native__this, int n, IntPtr native__callback)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.WoyouServiceDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var @callback = (global::Woyou.Aidlservice.Jiuiv5.ICallback)global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.ICallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.LineWrap (n, @callback);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/class[@name='IWoyouService.Default']/method[@name='lineWrap' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='woyou.aidlservice.jiuiv5.ICallback']]"
		[Register ("lineWrap", "(ILwoyou/aidlservice/jiuiv5/ICallback;)V", "GetLineWrap_ILwoyou_aidlservice_jiuiv5_ICallback_Handler")]
		public virtual unsafe void LineWrap (int n, global::Woyou.Aidlservice.Jiuiv5.ICallback @callback)
		{
			const string __id = "lineWrap.(ILwoyou/aidlservice/jiuiv5/ICallback;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (n);
				__args [1] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (@callback);
			}
		}

		static Delegate cb_openDrawer_Lwoyou_aidlservice_jiuiv5_ICallback_;
#pragma warning disable 0169
		static Delegate GetOpenDrawer_Lwoyou_aidlservice_jiuiv5_ICallback_Handler ()
		{
			if (cb_openDrawer_Lwoyou_aidlservice_jiuiv5_ICallback_ == null)
				cb_openDrawer_Lwoyou_aidlservice_jiuiv5_ICallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OpenDrawer_Lwoyou_aidlservice_jiuiv5_ICallback_);
			return cb_openDrawer_Lwoyou_aidlservice_jiuiv5_ICallback_;
		}

		static void n_OpenDrawer_Lwoyou_aidlservice_jiuiv5_ICallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native__callback)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.WoyouServiceDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var @callback = (global::Woyou.Aidlservice.Jiuiv5.ICallback)global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.ICallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.OpenDrawer (@callback);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/class[@name='IWoyouService.Default']/method[@name='openDrawer' and count(parameter)=1 and parameter[1][@type='woyou.aidlservice.jiuiv5.ICallback']]"
		[Register ("openDrawer", "(Lwoyou/aidlservice/jiuiv5/ICallback;)V", "GetOpenDrawer_Lwoyou_aidlservice_jiuiv5_ICallback_Handler")]
		public virtual unsafe void OpenDrawer (global::Woyou.Aidlservice.Jiuiv5.ICallback @callback)
		{
			const string __id = "openDrawer.(Lwoyou/aidlservice/jiuiv5/ICallback;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (@callback);
			}
		}

		static Delegate cb_postPrintData_Ljava_lang_String_arrayBII;
#pragma warning disable 0169
		static Delegate GetPostPrintData_Ljava_lang_String_arrayBIIHandler ()
		{
			if (cb_postPrintData_Ljava_lang_String_arrayBII == null)
				cb_postPrintData_Ljava_lang_String_arrayBII = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLII_Z) n_PostPrintData_Ljava_lang_String_arrayBII);
			return cb_postPrintData_Ljava_lang_String_arrayBII;
		}

		static bool n_PostPrintData_Ljava_lang_String_arrayBII (IntPtr jnienv, IntPtr native__this, IntPtr native_packageName, IntPtr native_data, int offset, int length)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.WoyouServiceDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var packageName = JNIEnv.GetString (native_packageName, JniHandleOwnership.DoNotTransfer);
			var data = (byte[]) JNIEnv.GetArray (native_data, JniHandleOwnership.DoNotTransfer, typeof (byte));
			bool __ret = __this.PostPrintData (packageName, data, offset, length);
			if (data != null)
				JNIEnv.CopyArray (data, native_data);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/class[@name='IWoyouService.Default']/method[@name='postPrintData' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='byte[]'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("postPrintData", "(Ljava/lang/String;[BII)Z", "GetPostPrintData_Ljava_lang_String_arrayBIIHandler")]
		public virtual unsafe bool PostPrintData (string packageName, byte[] data, int offset, int length)
		{
			const string __id = "postPrintData.(Ljava/lang/String;[BII)Z";
			IntPtr native_packageName = JNIEnv.NewString ((string)packageName);
			IntPtr native_data = JNIEnv.NewArray (data);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_packageName);
				__args [1] = new JniArgumentValue (native_data);
				__args [2] = new JniArgumentValue (offset);
				__args [3] = new JniArgumentValue (length);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_packageName);
				if (data != null) {
					JNIEnv.CopyArray (native_data, data);
					JNIEnv.DeleteLocalRef (native_data);
				}
				global::System.GC.KeepAlive (data);
			}
		}

		static Delegate cb_printBarCode_Ljava_lang_String_IIIILwoyou_aidlservice_jiuiv5_ICallback_;
#pragma warning disable 0169
		static Delegate GetPrintBarCode_Ljava_lang_String_IIIILwoyou_aidlservice_jiuiv5_ICallback_Handler ()
		{
			if (cb_printBarCode_Ljava_lang_String_IIIILwoyou_aidlservice_jiuiv5_ICallback_ == null)
				cb_printBarCode_Ljava_lang_String_IIIILwoyou_aidlservice_jiuiv5_ICallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLIIIIL_V) n_PrintBarCode_Ljava_lang_String_IIIILwoyou_aidlservice_jiuiv5_ICallback_);
			return cb_printBarCode_Ljava_lang_String_IIIILwoyou_aidlservice_jiuiv5_ICallback_;
		}

		static void n_PrintBarCode_Ljava_lang_String_IIIILwoyou_aidlservice_jiuiv5_ICallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_data, int symbology, int height, int width, int textposition, IntPtr native__callback)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.WoyouServiceDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var data = JNIEnv.GetString (native_data, JniHandleOwnership.DoNotTransfer);
			var @callback = (global::Woyou.Aidlservice.Jiuiv5.ICallback)global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.ICallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.PrintBarCode (data, symbology, height, width, textposition, @callback);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/class[@name='IWoyouService.Default']/method[@name='printBarCode' and count(parameter)=6 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='woyou.aidlservice.jiuiv5.ICallback']]"
		[Register ("printBarCode", "(Ljava/lang/String;IIIILwoyou/aidlservice/jiuiv5/ICallback;)V", "GetPrintBarCode_Ljava_lang_String_IIIILwoyou_aidlservice_jiuiv5_ICallback_Handler")]
		public virtual unsafe void PrintBarCode (string data, int symbology, int height, int width, int textposition, global::Woyou.Aidlservice.Jiuiv5.ICallback @callback)
		{
			const string __id = "printBarCode.(Ljava/lang/String;IIIILwoyou/aidlservice/jiuiv5/ICallback;)V";
			IntPtr native_data = JNIEnv.NewString ((string)data);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue (native_data);
				__args [1] = new JniArgumentValue (symbology);
				__args [2] = new JniArgumentValue (height);
				__args [3] = new JniArgumentValue (width);
				__args [4] = new JniArgumentValue (textposition);
				__args [5] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_data);
				global::System.GC.KeepAlive (@callback);
			}
		}

		static Delegate cb_printBitmap_Landroid_graphics_Bitmap_Lwoyou_aidlservice_jiuiv5_ICallback_;
#pragma warning disable 0169
		static Delegate GetPrintBitmap_Landroid_graphics_Bitmap_Lwoyou_aidlservice_jiuiv5_ICallback_Handler ()
		{
			if (cb_printBitmap_Landroid_graphics_Bitmap_Lwoyou_aidlservice_jiuiv5_ICallback_ == null)
				cb_printBitmap_Landroid_graphics_Bitmap_Lwoyou_aidlservice_jiuiv5_ICallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_PrintBitmap_Landroid_graphics_Bitmap_Lwoyou_aidlservice_jiuiv5_ICallback_);
			return cb_printBitmap_Landroid_graphics_Bitmap_Lwoyou_aidlservice_jiuiv5_ICallback_;
		}

		static void n_PrintBitmap_Landroid_graphics_Bitmap_Lwoyou_aidlservice_jiuiv5_ICallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_bitmap, IntPtr native__callback)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.WoyouServiceDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var bitmap = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_bitmap, JniHandleOwnership.DoNotTransfer);
			var @callback = (global::Woyou.Aidlservice.Jiuiv5.ICallback)global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.ICallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.PrintBitmap (bitmap, @callback);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/class[@name='IWoyouService.Default']/method[@name='printBitmap' and count(parameter)=2 and parameter[1][@type='android.graphics.Bitmap'] and parameter[2][@type='woyou.aidlservice.jiuiv5.ICallback']]"
		[Register ("printBitmap", "(Landroid/graphics/Bitmap;Lwoyou/aidlservice/jiuiv5/ICallback;)V", "GetPrintBitmap_Landroid_graphics_Bitmap_Lwoyou_aidlservice_jiuiv5_ICallback_Handler")]
		public virtual unsafe void PrintBitmap (global::Android.Graphics.Bitmap bitmap, global::Woyou.Aidlservice.Jiuiv5.ICallback @callback)
		{
			const string __id = "printBitmap.(Landroid/graphics/Bitmap;Lwoyou/aidlservice/jiuiv5/ICallback;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((bitmap == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bitmap).Handle);
				__args [1] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (bitmap);
				global::System.GC.KeepAlive (@callback);
			}
		}

		static Delegate cb_printBitmapCustom_Landroid_graphics_Bitmap_ILwoyou_aidlservice_jiuiv5_ICallback_;
#pragma warning disable 0169
		static Delegate GetPrintBitmapCustom_Landroid_graphics_Bitmap_ILwoyou_aidlservice_jiuiv5_ICallback_Handler ()
		{
			if (cb_printBitmapCustom_Landroid_graphics_Bitmap_ILwoyou_aidlservice_jiuiv5_ICallback_ == null)
				cb_printBitmapCustom_Landroid_graphics_Bitmap_ILwoyou_aidlservice_jiuiv5_ICallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLIL_V) n_PrintBitmapCustom_Landroid_graphics_Bitmap_ILwoyou_aidlservice_jiuiv5_ICallback_);
			return cb_printBitmapCustom_Landroid_graphics_Bitmap_ILwoyou_aidlservice_jiuiv5_ICallback_;
		}

		static void n_PrintBitmapCustom_Landroid_graphics_Bitmap_ILwoyou_aidlservice_jiuiv5_ICallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_bitmap, int type, IntPtr native__callback)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.WoyouServiceDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var bitmap = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_bitmap, JniHandleOwnership.DoNotTransfer);
			var @callback = (global::Woyou.Aidlservice.Jiuiv5.ICallback)global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.ICallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.PrintBitmapCustom (bitmap, type, @callback);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/class[@name='IWoyouService.Default']/method[@name='printBitmapCustom' and count(parameter)=3 and parameter[1][@type='android.graphics.Bitmap'] and parameter[2][@type='int'] and parameter[3][@type='woyou.aidlservice.jiuiv5.ICallback']]"
		[Register ("printBitmapCustom", "(Landroid/graphics/Bitmap;ILwoyou/aidlservice/jiuiv5/ICallback;)V", "GetPrintBitmapCustom_Landroid_graphics_Bitmap_ILwoyou_aidlservice_jiuiv5_ICallback_Handler")]
		public virtual unsafe void PrintBitmapCustom (global::Android.Graphics.Bitmap bitmap, int type, global::Woyou.Aidlservice.Jiuiv5.ICallback @callback)
		{
			const string __id = "printBitmapCustom.(Landroid/graphics/Bitmap;ILwoyou/aidlservice/jiuiv5/ICallback;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((bitmap == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bitmap).Handle);
				__args [1] = new JniArgumentValue (type);
				__args [2] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (bitmap);
				global::System.GC.KeepAlive (@callback);
			}
		}

		static Delegate cb_printColumnsString_arrayLjava_lang_String_arrayIarrayILwoyou_aidlservice_jiuiv5_ICallback_;
#pragma warning disable 0169
		static Delegate GetPrintColumnsString_arrayLjava_lang_String_arrayIarrayILwoyou_aidlservice_jiuiv5_ICallback_Handler ()
		{
			if (cb_printColumnsString_arrayLjava_lang_String_arrayIarrayILwoyou_aidlservice_jiuiv5_ICallback_ == null)
				cb_printColumnsString_arrayLjava_lang_String_arrayIarrayILwoyou_aidlservice_jiuiv5_ICallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLL_V) n_PrintColumnsString_arrayLjava_lang_String_arrayIarrayILwoyou_aidlservice_jiuiv5_ICallback_);
			return cb_printColumnsString_arrayLjava_lang_String_arrayIarrayILwoyou_aidlservice_jiuiv5_ICallback_;
		}

		static void n_PrintColumnsString_arrayLjava_lang_String_arrayIarrayILwoyou_aidlservice_jiuiv5_ICallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_colsTextArr, IntPtr native_colsWidthArr, IntPtr native_colsAlign, IntPtr native__callback)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.WoyouServiceDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var colsTextArr = (string[]) JNIEnv.GetArray (native_colsTextArr, JniHandleOwnership.DoNotTransfer, typeof (string));
			var colsWidthArr = (int[]) JNIEnv.GetArray (native_colsWidthArr, JniHandleOwnership.DoNotTransfer, typeof (int));
			var colsAlign = (int[]) JNIEnv.GetArray (native_colsAlign, JniHandleOwnership.DoNotTransfer, typeof (int));
			var @callback = (global::Woyou.Aidlservice.Jiuiv5.ICallback)global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.ICallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.PrintColumnsString (colsTextArr, colsWidthArr, colsAlign, @callback);
			if (colsTextArr != null)
				JNIEnv.CopyArray (colsTextArr, native_colsTextArr);
			if (colsWidthArr != null)
				JNIEnv.CopyArray (colsWidthArr, native_colsWidthArr);
			if (colsAlign != null)
				JNIEnv.CopyArray (colsAlign, native_colsAlign);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/class[@name='IWoyouService.Default']/method[@name='printColumnsString' and count(parameter)=4 and parameter[1][@type='java.lang.String[]'] and parameter[2][@type='int[]'] and parameter[3][@type='int[]'] and parameter[4][@type='woyou.aidlservice.jiuiv5.ICallback']]"
		[Register ("printColumnsString", "([Ljava/lang/String;[I[ILwoyou/aidlservice/jiuiv5/ICallback;)V", "GetPrintColumnsString_arrayLjava_lang_String_arrayIarrayILwoyou_aidlservice_jiuiv5_ICallback_Handler")]
		public virtual unsafe void PrintColumnsString (string[] colsTextArr, int[] colsWidthArr, int[] colsAlign, global::Woyou.Aidlservice.Jiuiv5.ICallback @callback)
		{
			const string __id = "printColumnsString.([Ljava/lang/String;[I[ILwoyou/aidlservice/jiuiv5/ICallback;)V";
			IntPtr native_colsTextArr = JNIEnv.NewArray (colsTextArr);
			IntPtr native_colsWidthArr = JNIEnv.NewArray (colsWidthArr);
			IntPtr native_colsAlign = JNIEnv.NewArray (colsAlign);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_colsTextArr);
				__args [1] = new JniArgumentValue (native_colsWidthArr);
				__args [2] = new JniArgumentValue (native_colsAlign);
				__args [3] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (colsTextArr != null) {
					JNIEnv.CopyArray (native_colsTextArr, colsTextArr);
					JNIEnv.DeleteLocalRef (native_colsTextArr);
				}
				if (colsWidthArr != null) {
					JNIEnv.CopyArray (native_colsWidthArr, colsWidthArr);
					JNIEnv.DeleteLocalRef (native_colsWidthArr);
				}
				if (colsAlign != null) {
					JNIEnv.CopyArray (native_colsAlign, colsAlign);
					JNIEnv.DeleteLocalRef (native_colsAlign);
				}
				global::System.GC.KeepAlive (colsTextArr);
				global::System.GC.KeepAlive (colsWidthArr);
				global::System.GC.KeepAlive (colsAlign);
				global::System.GC.KeepAlive (@callback);
			}
		}

		static Delegate cb_printColumnsText_arrayLjava_lang_String_arrayIarrayILwoyou_aidlservice_jiuiv5_ICallback_;
#pragma warning disable 0169
		static Delegate GetPrintColumnsText_arrayLjava_lang_String_arrayIarrayILwoyou_aidlservice_jiuiv5_ICallback_Handler ()
		{
			if (cb_printColumnsText_arrayLjava_lang_String_arrayIarrayILwoyou_aidlservice_jiuiv5_ICallback_ == null)
				cb_printColumnsText_arrayLjava_lang_String_arrayIarrayILwoyou_aidlservice_jiuiv5_ICallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLL_V) n_PrintColumnsText_arrayLjava_lang_String_arrayIarrayILwoyou_aidlservice_jiuiv5_ICallback_);
			return cb_printColumnsText_arrayLjava_lang_String_arrayIarrayILwoyou_aidlservice_jiuiv5_ICallback_;
		}

		static void n_PrintColumnsText_arrayLjava_lang_String_arrayIarrayILwoyou_aidlservice_jiuiv5_ICallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_colsTextArr, IntPtr native_colsWidthArr, IntPtr native_colsAlign, IntPtr native__callback)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.WoyouServiceDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var colsTextArr = (string[]) JNIEnv.GetArray (native_colsTextArr, JniHandleOwnership.DoNotTransfer, typeof (string));
			var colsWidthArr = (int[]) JNIEnv.GetArray (native_colsWidthArr, JniHandleOwnership.DoNotTransfer, typeof (int));
			var colsAlign = (int[]) JNIEnv.GetArray (native_colsAlign, JniHandleOwnership.DoNotTransfer, typeof (int));
			var @callback = (global::Woyou.Aidlservice.Jiuiv5.ICallback)global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.ICallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.PrintColumnsText (colsTextArr, colsWidthArr, colsAlign, @callback);
			if (colsTextArr != null)
				JNIEnv.CopyArray (colsTextArr, native_colsTextArr);
			if (colsWidthArr != null)
				JNIEnv.CopyArray (colsWidthArr, native_colsWidthArr);
			if (colsAlign != null)
				JNIEnv.CopyArray (colsAlign, native_colsAlign);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/class[@name='IWoyouService.Default']/method[@name='printColumnsText' and count(parameter)=4 and parameter[1][@type='java.lang.String[]'] and parameter[2][@type='int[]'] and parameter[3][@type='int[]'] and parameter[4][@type='woyou.aidlservice.jiuiv5.ICallback']]"
		[Register ("printColumnsText", "([Ljava/lang/String;[I[ILwoyou/aidlservice/jiuiv5/ICallback;)V", "GetPrintColumnsText_arrayLjava_lang_String_arrayIarrayILwoyou_aidlservice_jiuiv5_ICallback_Handler")]
		public virtual unsafe void PrintColumnsText (string[] colsTextArr, int[] colsWidthArr, int[] colsAlign, global::Woyou.Aidlservice.Jiuiv5.ICallback @callback)
		{
			const string __id = "printColumnsText.([Ljava/lang/String;[I[ILwoyou/aidlservice/jiuiv5/ICallback;)V";
			IntPtr native_colsTextArr = JNIEnv.NewArray (colsTextArr);
			IntPtr native_colsWidthArr = JNIEnv.NewArray (colsWidthArr);
			IntPtr native_colsAlign = JNIEnv.NewArray (colsAlign);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_colsTextArr);
				__args [1] = new JniArgumentValue (native_colsWidthArr);
				__args [2] = new JniArgumentValue (native_colsAlign);
				__args [3] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (colsTextArr != null) {
					JNIEnv.CopyArray (native_colsTextArr, colsTextArr);
					JNIEnv.DeleteLocalRef (native_colsTextArr);
				}
				if (colsWidthArr != null) {
					JNIEnv.CopyArray (native_colsWidthArr, colsWidthArr);
					JNIEnv.DeleteLocalRef (native_colsWidthArr);
				}
				if (colsAlign != null) {
					JNIEnv.CopyArray (native_colsAlign, colsAlign);
					JNIEnv.DeleteLocalRef (native_colsAlign);
				}
				global::System.GC.KeepAlive (colsTextArr);
				global::System.GC.KeepAlive (colsWidthArr);
				global::System.GC.KeepAlive (colsAlign);
				global::System.GC.KeepAlive (@callback);
			}
		}

		static Delegate cb_printOriginalText_Ljava_lang_String_Lwoyou_aidlservice_jiuiv5_ICallback_;
#pragma warning disable 0169
		static Delegate GetPrintOriginalText_Ljava_lang_String_Lwoyou_aidlservice_jiuiv5_ICallback_Handler ()
		{
			if (cb_printOriginalText_Ljava_lang_String_Lwoyou_aidlservice_jiuiv5_ICallback_ == null)
				cb_printOriginalText_Ljava_lang_String_Lwoyou_aidlservice_jiuiv5_ICallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_PrintOriginalText_Ljava_lang_String_Lwoyou_aidlservice_jiuiv5_ICallback_);
			return cb_printOriginalText_Ljava_lang_String_Lwoyou_aidlservice_jiuiv5_ICallback_;
		}

		static void n_PrintOriginalText_Ljava_lang_String_Lwoyou_aidlservice_jiuiv5_ICallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_text, IntPtr native__callback)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.WoyouServiceDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var text = JNIEnv.GetString (native_text, JniHandleOwnership.DoNotTransfer);
			var @callback = (global::Woyou.Aidlservice.Jiuiv5.ICallback)global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.ICallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.PrintOriginalText (text, @callback);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/class[@name='IWoyouService.Default']/method[@name='printOriginalText' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='woyou.aidlservice.jiuiv5.ICallback']]"
		[Register ("printOriginalText", "(Ljava/lang/String;Lwoyou/aidlservice/jiuiv5/ICallback;)V", "GetPrintOriginalText_Ljava_lang_String_Lwoyou_aidlservice_jiuiv5_ICallback_Handler")]
		public virtual unsafe void PrintOriginalText (string text, global::Woyou.Aidlservice.Jiuiv5.ICallback @callback)
		{
			const string __id = "printOriginalText.(Ljava/lang/String;Lwoyou/aidlservice/jiuiv5/ICallback;)V";
			IntPtr native_text = JNIEnv.NewString ((string)text);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_text);
				__args [1] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_text);
				global::System.GC.KeepAlive (@callback);
			}
		}

		static Delegate cb_printQRCode_Ljava_lang_String_IILwoyou_aidlservice_jiuiv5_ICallback_;
#pragma warning disable 0169
		static Delegate GetPrintQRCode_Ljava_lang_String_IILwoyou_aidlservice_jiuiv5_ICallback_Handler ()
		{
			if (cb_printQRCode_Ljava_lang_String_IILwoyou_aidlservice_jiuiv5_ICallback_ == null)
				cb_printQRCode_Ljava_lang_String_IILwoyou_aidlservice_jiuiv5_ICallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLIIL_V) n_PrintQRCode_Ljava_lang_String_IILwoyou_aidlservice_jiuiv5_ICallback_);
			return cb_printQRCode_Ljava_lang_String_IILwoyou_aidlservice_jiuiv5_ICallback_;
		}

		static void n_PrintQRCode_Ljava_lang_String_IILwoyou_aidlservice_jiuiv5_ICallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_data, int modulesize, int errorlevel, IntPtr native__callback)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.WoyouServiceDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var data = JNIEnv.GetString (native_data, JniHandleOwnership.DoNotTransfer);
			var @callback = (global::Woyou.Aidlservice.Jiuiv5.ICallback)global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.ICallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.PrintQRCode (data, modulesize, errorlevel, @callback);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/class[@name='IWoyouService.Default']/method[@name='printQRCode' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='woyou.aidlservice.jiuiv5.ICallback']]"
		[Register ("printQRCode", "(Ljava/lang/String;IILwoyou/aidlservice/jiuiv5/ICallback;)V", "GetPrintQRCode_Ljava_lang_String_IILwoyou_aidlservice_jiuiv5_ICallback_Handler")]
		public virtual unsafe void PrintQRCode (string data, int modulesize, int errorlevel, global::Woyou.Aidlservice.Jiuiv5.ICallback @callback)
		{
			const string __id = "printQRCode.(Ljava/lang/String;IILwoyou/aidlservice/jiuiv5/ICallback;)V";
			IntPtr native_data = JNIEnv.NewString ((string)data);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_data);
				__args [1] = new JniArgumentValue (modulesize);
				__args [2] = new JniArgumentValue (errorlevel);
				__args [3] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_data);
				global::System.GC.KeepAlive (@callback);
			}
		}

		static Delegate cb_printText_Ljava_lang_String_Lwoyou_aidlservice_jiuiv5_ICallback_;
#pragma warning disable 0169
		static Delegate GetPrintText_Ljava_lang_String_Lwoyou_aidlservice_jiuiv5_ICallback_Handler ()
		{
			if (cb_printText_Ljava_lang_String_Lwoyou_aidlservice_jiuiv5_ICallback_ == null)
				cb_printText_Ljava_lang_String_Lwoyou_aidlservice_jiuiv5_ICallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_PrintText_Ljava_lang_String_Lwoyou_aidlservice_jiuiv5_ICallback_);
			return cb_printText_Ljava_lang_String_Lwoyou_aidlservice_jiuiv5_ICallback_;
		}

		static void n_PrintText_Ljava_lang_String_Lwoyou_aidlservice_jiuiv5_ICallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_text, IntPtr native__callback)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.WoyouServiceDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var text = JNIEnv.GetString (native_text, JniHandleOwnership.DoNotTransfer);
			var @callback = (global::Woyou.Aidlservice.Jiuiv5.ICallback)global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.ICallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.PrintText (text, @callback);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/class[@name='IWoyouService.Default']/method[@name='printText' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='woyou.aidlservice.jiuiv5.ICallback']]"
		[Register ("printText", "(Ljava/lang/String;Lwoyou/aidlservice/jiuiv5/ICallback;)V", "GetPrintText_Ljava_lang_String_Lwoyou_aidlservice_jiuiv5_ICallback_Handler")]
		public virtual unsafe void PrintText (string text, global::Woyou.Aidlservice.Jiuiv5.ICallback @callback)
		{
			const string __id = "printText.(Ljava/lang/String;Lwoyou/aidlservice/jiuiv5/ICallback;)V";
			IntPtr native_text = JNIEnv.NewString ((string)text);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_text);
				__args [1] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_text);
				global::System.GC.KeepAlive (@callback);
			}
		}

		static Delegate cb_printTextWithFont_Ljava_lang_String_Ljava_lang_String_FLwoyou_aidlservice_jiuiv5_ICallback_;
#pragma warning disable 0169
		static Delegate GetPrintTextWithFont_Ljava_lang_String_Ljava_lang_String_FLwoyou_aidlservice_jiuiv5_ICallback_Handler ()
		{
			if (cb_printTextWithFont_Ljava_lang_String_Ljava_lang_String_FLwoyou_aidlservice_jiuiv5_ICallback_ == null)
				cb_printTextWithFont_Ljava_lang_String_Ljava_lang_String_FLwoyou_aidlservice_jiuiv5_ICallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLFL_V) n_PrintTextWithFont_Ljava_lang_String_Ljava_lang_String_FLwoyou_aidlservice_jiuiv5_ICallback_);
			return cb_printTextWithFont_Ljava_lang_String_Ljava_lang_String_FLwoyou_aidlservice_jiuiv5_ICallback_;
		}

		static void n_PrintTextWithFont_Ljava_lang_String_Ljava_lang_String_FLwoyou_aidlservice_jiuiv5_ICallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_text, IntPtr native_typeface, float fontsize, IntPtr native__callback)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.WoyouServiceDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var text = JNIEnv.GetString (native_text, JniHandleOwnership.DoNotTransfer);
			var typeface = JNIEnv.GetString (native_typeface, JniHandleOwnership.DoNotTransfer);
			var @callback = (global::Woyou.Aidlservice.Jiuiv5.ICallback)global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.ICallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.PrintTextWithFont (text, typeface, fontsize, @callback);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/class[@name='IWoyouService.Default']/method[@name='printTextWithFont' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='float'] and parameter[4][@type='woyou.aidlservice.jiuiv5.ICallback']]"
		[Register ("printTextWithFont", "(Ljava/lang/String;Ljava/lang/String;FLwoyou/aidlservice/jiuiv5/ICallback;)V", "GetPrintTextWithFont_Ljava_lang_String_Ljava_lang_String_FLwoyou_aidlservice_jiuiv5_ICallback_Handler")]
		public virtual unsafe void PrintTextWithFont (string text, string typeface, float fontsize, global::Woyou.Aidlservice.Jiuiv5.ICallback @callback)
		{
			const string __id = "printTextWithFont.(Ljava/lang/String;Ljava/lang/String;FLwoyou/aidlservice/jiuiv5/ICallback;)V";
			IntPtr native_text = JNIEnv.NewString ((string)text);
			IntPtr native_typeface = JNIEnv.NewString ((string)typeface);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_text);
				__args [1] = new JniArgumentValue (native_typeface);
				__args [2] = new JniArgumentValue (fontsize);
				__args [3] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_text);
				JNIEnv.DeleteLocalRef (native_typeface);
				global::System.GC.KeepAlive (@callback);
			}
		}

		static Delegate cb_printerInit_Lwoyou_aidlservice_jiuiv5_ICallback_;
#pragma warning disable 0169
		static Delegate GetPrinterInit_Lwoyou_aidlservice_jiuiv5_ICallback_Handler ()
		{
			if (cb_printerInit_Lwoyou_aidlservice_jiuiv5_ICallback_ == null)
				cb_printerInit_Lwoyou_aidlservice_jiuiv5_ICallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_PrinterInit_Lwoyou_aidlservice_jiuiv5_ICallback_);
			return cb_printerInit_Lwoyou_aidlservice_jiuiv5_ICallback_;
		}

		static void n_PrinterInit_Lwoyou_aidlservice_jiuiv5_ICallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native__callback)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.WoyouServiceDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var @callback = (global::Woyou.Aidlservice.Jiuiv5.ICallback)global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.ICallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.PrinterInit (@callback);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/class[@name='IWoyouService.Default']/method[@name='printerInit' and count(parameter)=1 and parameter[1][@type='woyou.aidlservice.jiuiv5.ICallback']]"
		[Register ("printerInit", "(Lwoyou/aidlservice/jiuiv5/ICallback;)V", "GetPrinterInit_Lwoyou_aidlservice_jiuiv5_ICallback_Handler")]
		public virtual unsafe void PrinterInit (global::Woyou.Aidlservice.Jiuiv5.ICallback @callback)
		{
			const string __id = "printerInit.(Lwoyou/aidlservice/jiuiv5/ICallback;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (@callback);
			}
		}

		static Delegate cb_printerSelfChecking_Lwoyou_aidlservice_jiuiv5_ICallback_;
#pragma warning disable 0169
		static Delegate GetPrinterSelfChecking_Lwoyou_aidlservice_jiuiv5_ICallback_Handler ()
		{
			if (cb_printerSelfChecking_Lwoyou_aidlservice_jiuiv5_ICallback_ == null)
				cb_printerSelfChecking_Lwoyou_aidlservice_jiuiv5_ICallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_PrinterSelfChecking_Lwoyou_aidlservice_jiuiv5_ICallback_);
			return cb_printerSelfChecking_Lwoyou_aidlservice_jiuiv5_ICallback_;
		}

		static void n_PrinterSelfChecking_Lwoyou_aidlservice_jiuiv5_ICallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native__callback)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.WoyouServiceDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var @callback = (global::Woyou.Aidlservice.Jiuiv5.ICallback)global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.ICallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.PrinterSelfChecking (@callback);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/class[@name='IWoyouService.Default']/method[@name='printerSelfChecking' and count(parameter)=1 and parameter[1][@type='woyou.aidlservice.jiuiv5.ICallback']]"
		[Register ("printerSelfChecking", "(Lwoyou/aidlservice/jiuiv5/ICallback;)V", "GetPrinterSelfChecking_Lwoyou_aidlservice_jiuiv5_ICallback_Handler")]
		public virtual unsafe void PrinterSelfChecking (global::Woyou.Aidlservice.Jiuiv5.ICallback @callback)
		{
			const string __id = "printerSelfChecking.(Lwoyou/aidlservice/jiuiv5/ICallback;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (@callback);
			}
		}

		static Delegate cb_sendLCDBitmap_Landroid_graphics_Bitmap_Lwoyou_aidlservice_jiuiv5_ILcdCallback_;
#pragma warning disable 0169
		static Delegate GetSendLCDBitmap_Landroid_graphics_Bitmap_Lwoyou_aidlservice_jiuiv5_ILcdCallback_Handler ()
		{
			if (cb_sendLCDBitmap_Landroid_graphics_Bitmap_Lwoyou_aidlservice_jiuiv5_ILcdCallback_ == null)
				cb_sendLCDBitmap_Landroid_graphics_Bitmap_Lwoyou_aidlservice_jiuiv5_ILcdCallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_SendLCDBitmap_Landroid_graphics_Bitmap_Lwoyou_aidlservice_jiuiv5_ILcdCallback_);
			return cb_sendLCDBitmap_Landroid_graphics_Bitmap_Lwoyou_aidlservice_jiuiv5_ILcdCallback_;
		}

		static void n_SendLCDBitmap_Landroid_graphics_Bitmap_Lwoyou_aidlservice_jiuiv5_ILcdCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_bitmap, IntPtr native__callback)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.WoyouServiceDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var bitmap = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_bitmap, JniHandleOwnership.DoNotTransfer);
			var @callback = (global::Woyou.Aidlservice.Jiuiv5.ILcdCallback)global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.ILcdCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.SendLCDBitmap (bitmap, @callback);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/class[@name='IWoyouService.Default']/method[@name='sendLCDBitmap' and count(parameter)=2 and parameter[1][@type='android.graphics.Bitmap'] and parameter[2][@type='woyou.aidlservice.jiuiv5.ILcdCallback']]"
		[Register ("sendLCDBitmap", "(Landroid/graphics/Bitmap;Lwoyou/aidlservice/jiuiv5/ILcdCallback;)V", "GetSendLCDBitmap_Landroid_graphics_Bitmap_Lwoyou_aidlservice_jiuiv5_ILcdCallback_Handler")]
		public virtual unsafe void SendLCDBitmap (global::Android.Graphics.Bitmap bitmap, global::Woyou.Aidlservice.Jiuiv5.ILcdCallback @callback)
		{
			const string __id = "sendLCDBitmap.(Landroid/graphics/Bitmap;Lwoyou/aidlservice/jiuiv5/ILcdCallback;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((bitmap == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bitmap).Handle);
				__args [1] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (bitmap);
				global::System.GC.KeepAlive (@callback);
			}
		}

		static Delegate cb_sendLCDCommand_I;
#pragma warning disable 0169
		static Delegate GetSendLCDCommand_IHandler ()
		{
			if (cb_sendLCDCommand_I == null)
				cb_sendLCDCommand_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SendLCDCommand_I);
			return cb_sendLCDCommand_I;
		}

		static void n_SendLCDCommand_I (IntPtr jnienv, IntPtr native__this, int flag)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.WoyouServiceDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SendLCDCommand (flag);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/class[@name='IWoyouService.Default']/method[@name='sendLCDCommand' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("sendLCDCommand", "(I)V", "GetSendLCDCommand_IHandler")]
		public virtual unsafe void SendLCDCommand (int flag)
		{
			const string __id = "sendLCDCommand.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (flag);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_sendLCDDoubleString_Ljava_lang_String_Ljava_lang_String_Lwoyou_aidlservice_jiuiv5_ILcdCallback_;
#pragma warning disable 0169
		static Delegate GetSendLCDDoubleString_Ljava_lang_String_Ljava_lang_String_Lwoyou_aidlservice_jiuiv5_ILcdCallback_Handler ()
		{
			if (cb_sendLCDDoubleString_Ljava_lang_String_Ljava_lang_String_Lwoyou_aidlservice_jiuiv5_ILcdCallback_ == null)
				cb_sendLCDDoubleString_Ljava_lang_String_Ljava_lang_String_Lwoyou_aidlservice_jiuiv5_ILcdCallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_SendLCDDoubleString_Ljava_lang_String_Ljava_lang_String_Lwoyou_aidlservice_jiuiv5_ILcdCallback_);
			return cb_sendLCDDoubleString_Ljava_lang_String_Ljava_lang_String_Lwoyou_aidlservice_jiuiv5_ILcdCallback_;
		}

		static void n_SendLCDDoubleString_Ljava_lang_String_Ljava_lang_String_Lwoyou_aidlservice_jiuiv5_ILcdCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_topText, IntPtr native_bottomText, IntPtr native__callback)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.WoyouServiceDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var topText = JNIEnv.GetString (native_topText, JniHandleOwnership.DoNotTransfer);
			var bottomText = JNIEnv.GetString (native_bottomText, JniHandleOwnership.DoNotTransfer);
			var @callback = (global::Woyou.Aidlservice.Jiuiv5.ILcdCallback)global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.ILcdCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.SendLCDDoubleString (topText, bottomText, @callback);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/class[@name='IWoyouService.Default']/method[@name='sendLCDDoubleString' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='woyou.aidlservice.jiuiv5.ILcdCallback']]"
		[Register ("sendLCDDoubleString", "(Ljava/lang/String;Ljava/lang/String;Lwoyou/aidlservice/jiuiv5/ILcdCallback;)V", "GetSendLCDDoubleString_Ljava_lang_String_Ljava_lang_String_Lwoyou_aidlservice_jiuiv5_ILcdCallback_Handler")]
		public virtual unsafe void SendLCDDoubleString (string topText, string bottomText, global::Woyou.Aidlservice.Jiuiv5.ILcdCallback @callback)
		{
			const string __id = "sendLCDDoubleString.(Ljava/lang/String;Ljava/lang/String;Lwoyou/aidlservice/jiuiv5/ILcdCallback;)V";
			IntPtr native_topText = JNIEnv.NewString ((string)topText);
			IntPtr native_bottomText = JNIEnv.NewString ((string)bottomText);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_topText);
				__args [1] = new JniArgumentValue (native_bottomText);
				__args [2] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_topText);
				JNIEnv.DeleteLocalRef (native_bottomText);
				global::System.GC.KeepAlive (@callback);
			}
		}

		static Delegate cb_sendLCDFillString_Ljava_lang_String_IZLwoyou_aidlservice_jiuiv5_ILcdCallback_;
#pragma warning disable 0169
		static Delegate GetSendLCDFillString_Ljava_lang_String_IZLwoyou_aidlservice_jiuiv5_ILcdCallback_Handler ()
		{
			if (cb_sendLCDFillString_Ljava_lang_String_IZLwoyou_aidlservice_jiuiv5_ILcdCallback_ == null)
				cb_sendLCDFillString_Ljava_lang_String_IZLwoyou_aidlservice_jiuiv5_ILcdCallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLIZL_V) n_SendLCDFillString_Ljava_lang_String_IZLwoyou_aidlservice_jiuiv5_ILcdCallback_);
			return cb_sendLCDFillString_Ljava_lang_String_IZLwoyou_aidlservice_jiuiv5_ILcdCallback_;
		}

		static void n_SendLCDFillString_Ljava_lang_String_IZLwoyou_aidlservice_jiuiv5_ILcdCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native__string, int size, bool fill, IntPtr native__callback)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.WoyouServiceDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var @string = JNIEnv.GetString (native__string, JniHandleOwnership.DoNotTransfer);
			var @callback = (global::Woyou.Aidlservice.Jiuiv5.ILcdCallback)global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.ILcdCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.SendLCDFillString (@string, size, fill, @callback);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/class[@name='IWoyouService.Default']/method[@name='sendLCDFillString' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='boolean'] and parameter[4][@type='woyou.aidlservice.jiuiv5.ILcdCallback']]"
		[Register ("sendLCDFillString", "(Ljava/lang/String;IZLwoyou/aidlservice/jiuiv5/ILcdCallback;)V", "GetSendLCDFillString_Ljava_lang_String_IZLwoyou_aidlservice_jiuiv5_ILcdCallback_Handler")]
		public virtual unsafe void SendLCDFillString (string @string, int size, bool fill, global::Woyou.Aidlservice.Jiuiv5.ILcdCallback @callback)
		{
			const string __id = "sendLCDFillString.(Ljava/lang/String;IZLwoyou/aidlservice/jiuiv5/ILcdCallback;)V";
			IntPtr native__string = JNIEnv.NewString ((string)@string);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native__string);
				__args [1] = new JniArgumentValue (size);
				__args [2] = new JniArgumentValue (fill);
				__args [3] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native__string);
				global::System.GC.KeepAlive (@callback);
			}
		}

		static Delegate cb_sendLCDMultiString_arrayLjava_lang_String_arrayILwoyou_aidlservice_jiuiv5_ILcdCallback_;
#pragma warning disable 0169
		static Delegate GetSendLCDMultiString_arrayLjava_lang_String_arrayILwoyou_aidlservice_jiuiv5_ILcdCallback_Handler ()
		{
			if (cb_sendLCDMultiString_arrayLjava_lang_String_arrayILwoyou_aidlservice_jiuiv5_ILcdCallback_ == null)
				cb_sendLCDMultiString_arrayLjava_lang_String_arrayILwoyou_aidlservice_jiuiv5_ILcdCallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_SendLCDMultiString_arrayLjava_lang_String_arrayILwoyou_aidlservice_jiuiv5_ILcdCallback_);
			return cb_sendLCDMultiString_arrayLjava_lang_String_arrayILwoyou_aidlservice_jiuiv5_ILcdCallback_;
		}

		static void n_SendLCDMultiString_arrayLjava_lang_String_arrayILwoyou_aidlservice_jiuiv5_ILcdCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_text, IntPtr native_align, IntPtr native__callback)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.WoyouServiceDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var text = (string[]) JNIEnv.GetArray (native_text, JniHandleOwnership.DoNotTransfer, typeof (string));
			var align = (int[]) JNIEnv.GetArray (native_align, JniHandleOwnership.DoNotTransfer, typeof (int));
			var @callback = (global::Woyou.Aidlservice.Jiuiv5.ILcdCallback)global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.ILcdCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.SendLCDMultiString (text, align, @callback);
			if (text != null)
				JNIEnv.CopyArray (text, native_text);
			if (align != null)
				JNIEnv.CopyArray (align, native_align);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/class[@name='IWoyouService.Default']/method[@name='sendLCDMultiString' and count(parameter)=3 and parameter[1][@type='java.lang.String[]'] and parameter[2][@type='int[]'] and parameter[3][@type='woyou.aidlservice.jiuiv5.ILcdCallback']]"
		[Register ("sendLCDMultiString", "([Ljava/lang/String;[ILwoyou/aidlservice/jiuiv5/ILcdCallback;)V", "GetSendLCDMultiString_arrayLjava_lang_String_arrayILwoyou_aidlservice_jiuiv5_ILcdCallback_Handler")]
		public virtual unsafe void SendLCDMultiString (string[] text, int[] align, global::Woyou.Aidlservice.Jiuiv5.ILcdCallback @callback)
		{
			const string __id = "sendLCDMultiString.([Ljava/lang/String;[ILwoyou/aidlservice/jiuiv5/ILcdCallback;)V";
			IntPtr native_text = JNIEnv.NewArray (text);
			IntPtr native_align = JNIEnv.NewArray (align);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_text);
				__args [1] = new JniArgumentValue (native_align);
				__args [2] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (text != null) {
					JNIEnv.CopyArray (native_text, text);
					JNIEnv.DeleteLocalRef (native_text);
				}
				if (align != null) {
					JNIEnv.CopyArray (native_align, align);
					JNIEnv.DeleteLocalRef (native_align);
				}
				global::System.GC.KeepAlive (text);
				global::System.GC.KeepAlive (align);
				global::System.GC.KeepAlive (@callback);
			}
		}

		static Delegate cb_sendLCDString_Ljava_lang_String_Lwoyou_aidlservice_jiuiv5_ILcdCallback_;
#pragma warning disable 0169
		static Delegate GetSendLCDString_Ljava_lang_String_Lwoyou_aidlservice_jiuiv5_ILcdCallback_Handler ()
		{
			if (cb_sendLCDString_Ljava_lang_String_Lwoyou_aidlservice_jiuiv5_ILcdCallback_ == null)
				cb_sendLCDString_Ljava_lang_String_Lwoyou_aidlservice_jiuiv5_ILcdCallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_SendLCDString_Ljava_lang_String_Lwoyou_aidlservice_jiuiv5_ILcdCallback_);
			return cb_sendLCDString_Ljava_lang_String_Lwoyou_aidlservice_jiuiv5_ILcdCallback_;
		}

		static void n_SendLCDString_Ljava_lang_String_Lwoyou_aidlservice_jiuiv5_ILcdCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native__string, IntPtr native__callback)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.WoyouServiceDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var @string = JNIEnv.GetString (native__string, JniHandleOwnership.DoNotTransfer);
			var @callback = (global::Woyou.Aidlservice.Jiuiv5.ILcdCallback)global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.ILcdCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.SendLCDString (@string, @callback);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/class[@name='IWoyouService.Default']/method[@name='sendLCDString' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='woyou.aidlservice.jiuiv5.ILcdCallback']]"
		[Register ("sendLCDString", "(Ljava/lang/String;Lwoyou/aidlservice/jiuiv5/ILcdCallback;)V", "GetSendLCDString_Ljava_lang_String_Lwoyou_aidlservice_jiuiv5_ILcdCallback_Handler")]
		public virtual unsafe void SendLCDString (string @string, global::Woyou.Aidlservice.Jiuiv5.ILcdCallback @callback)
		{
			const string __id = "sendLCDString.(Ljava/lang/String;Lwoyou/aidlservice/jiuiv5/ILcdCallback;)V";
			IntPtr native__string = JNIEnv.NewString ((string)@string);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native__string);
				__args [1] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native__string);
				global::System.GC.KeepAlive (@callback);
			}
		}

		static Delegate cb_sendRAWData_arrayBLwoyou_aidlservice_jiuiv5_ICallback_;
#pragma warning disable 0169
		static Delegate GetSendRAWData_arrayBLwoyou_aidlservice_jiuiv5_ICallback_Handler ()
		{
			if (cb_sendRAWData_arrayBLwoyou_aidlservice_jiuiv5_ICallback_ == null)
				cb_sendRAWData_arrayBLwoyou_aidlservice_jiuiv5_ICallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_SendRAWData_arrayBLwoyou_aidlservice_jiuiv5_ICallback_);
			return cb_sendRAWData_arrayBLwoyou_aidlservice_jiuiv5_ICallback_;
		}

		static void n_SendRAWData_arrayBLwoyou_aidlservice_jiuiv5_ICallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_data, IntPtr native__callback)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.WoyouServiceDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var data = (byte[]) JNIEnv.GetArray (native_data, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var @callback = (global::Woyou.Aidlservice.Jiuiv5.ICallback)global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.ICallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.SendRAWData (data, @callback);
			if (data != null)
				JNIEnv.CopyArray (data, native_data);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/class[@name='IWoyouService.Default']/method[@name='sendRAWData' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='woyou.aidlservice.jiuiv5.ICallback']]"
		[Register ("sendRAWData", "([BLwoyou/aidlservice/jiuiv5/ICallback;)V", "GetSendRAWData_arrayBLwoyou_aidlservice_jiuiv5_ICallback_Handler")]
		public virtual unsafe void SendRAWData (byte[] data, global::Woyou.Aidlservice.Jiuiv5.ICallback @callback)
		{
			const string __id = "sendRAWData.([BLwoyou/aidlservice/jiuiv5/ICallback;)V";
			IntPtr native_data = JNIEnv.NewArray (data);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_data);
				__args [1] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (data != null) {
					JNIEnv.CopyArray (native_data, data);
					JNIEnv.DeleteLocalRef (native_data);
				}
				global::System.GC.KeepAlive (data);
				global::System.GC.KeepAlive (@callback);
			}
		}

		static Delegate cb_setAlignment_ILwoyou_aidlservice_jiuiv5_ICallback_;
#pragma warning disable 0169
		static Delegate GetSetAlignment_ILwoyou_aidlservice_jiuiv5_ICallback_Handler ()
		{
			if (cb_setAlignment_ILwoyou_aidlservice_jiuiv5_ICallback_ == null)
				cb_setAlignment_ILwoyou_aidlservice_jiuiv5_ICallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIL_V) n_SetAlignment_ILwoyou_aidlservice_jiuiv5_ICallback_);
			return cb_setAlignment_ILwoyou_aidlservice_jiuiv5_ICallback_;
		}

		static void n_SetAlignment_ILwoyou_aidlservice_jiuiv5_ICallback_ (IntPtr jnienv, IntPtr native__this, int alignment, IntPtr native__callback)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.WoyouServiceDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var @callback = (global::Woyou.Aidlservice.Jiuiv5.ICallback)global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.ICallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.SetAlignment (alignment, @callback);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/class[@name='IWoyouService.Default']/method[@name='setAlignment' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='woyou.aidlservice.jiuiv5.ICallback']]"
		[Register ("setAlignment", "(ILwoyou/aidlservice/jiuiv5/ICallback;)V", "GetSetAlignment_ILwoyou_aidlservice_jiuiv5_ICallback_Handler")]
		public virtual unsafe void SetAlignment (int alignment, global::Woyou.Aidlservice.Jiuiv5.ICallback @callback)
		{
			const string __id = "setAlignment.(ILwoyou/aidlservice/jiuiv5/ICallback;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (alignment);
				__args [1] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (@callback);
			}
		}

		static Delegate cb_setFontName_Ljava_lang_String_Lwoyou_aidlservice_jiuiv5_ICallback_;
#pragma warning disable 0169
		static Delegate GetSetFontName_Ljava_lang_String_Lwoyou_aidlservice_jiuiv5_ICallback_Handler ()
		{
			if (cb_setFontName_Ljava_lang_String_Lwoyou_aidlservice_jiuiv5_ICallback_ == null)
				cb_setFontName_Ljava_lang_String_Lwoyou_aidlservice_jiuiv5_ICallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_SetFontName_Ljava_lang_String_Lwoyou_aidlservice_jiuiv5_ICallback_);
			return cb_setFontName_Ljava_lang_String_Lwoyou_aidlservice_jiuiv5_ICallback_;
		}

		static void n_SetFontName_Ljava_lang_String_Lwoyou_aidlservice_jiuiv5_ICallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_typeface, IntPtr native__callback)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.WoyouServiceDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var typeface = JNIEnv.GetString (native_typeface, JniHandleOwnership.DoNotTransfer);
			var @callback = (global::Woyou.Aidlservice.Jiuiv5.ICallback)global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.ICallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.SetFontName (typeface, @callback);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/class[@name='IWoyouService.Default']/method[@name='setFontName' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='woyou.aidlservice.jiuiv5.ICallback']]"
		[Register ("setFontName", "(Ljava/lang/String;Lwoyou/aidlservice/jiuiv5/ICallback;)V", "GetSetFontName_Ljava_lang_String_Lwoyou_aidlservice_jiuiv5_ICallback_Handler")]
		public virtual unsafe void SetFontName (string typeface, global::Woyou.Aidlservice.Jiuiv5.ICallback @callback)
		{
			const string __id = "setFontName.(Ljava/lang/String;Lwoyou/aidlservice/jiuiv5/ICallback;)V";
			IntPtr native_typeface = JNIEnv.NewString ((string)typeface);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_typeface);
				__args [1] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_typeface);
				global::System.GC.KeepAlive (@callback);
			}
		}

		static Delegate cb_setFontSize_FLwoyou_aidlservice_jiuiv5_ICallback_;
#pragma warning disable 0169
		static Delegate GetSetFontSize_FLwoyou_aidlservice_jiuiv5_ICallback_Handler ()
		{
			if (cb_setFontSize_FLwoyou_aidlservice_jiuiv5_ICallback_ == null)
				cb_setFontSize_FLwoyou_aidlservice_jiuiv5_ICallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPFL_V) n_SetFontSize_FLwoyou_aidlservice_jiuiv5_ICallback_);
			return cb_setFontSize_FLwoyou_aidlservice_jiuiv5_ICallback_;
		}

		static void n_SetFontSize_FLwoyou_aidlservice_jiuiv5_ICallback_ (IntPtr jnienv, IntPtr native__this, float fontsize, IntPtr native__callback)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.WoyouServiceDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var @callback = (global::Woyou.Aidlservice.Jiuiv5.ICallback)global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.ICallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.SetFontSize (fontsize, @callback);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/class[@name='IWoyouService.Default']/method[@name='setFontSize' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='woyou.aidlservice.jiuiv5.ICallback']]"
		[Register ("setFontSize", "(FLwoyou/aidlservice/jiuiv5/ICallback;)V", "GetSetFontSize_FLwoyou_aidlservice_jiuiv5_ICallback_Handler")]
		public virtual unsafe void SetFontSize (float fontsize, global::Woyou.Aidlservice.Jiuiv5.ICallback @callback)
		{
			const string __id = "setFontSize.(FLwoyou/aidlservice/jiuiv5/ICallback;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (fontsize);
				__args [1] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (@callback);
			}
		}

		static Delegate cb_tax_arrayBLwoyou_aidlservice_jiuiv5_ITax_;
#pragma warning disable 0169
		static Delegate GetTax_arrayBLwoyou_aidlservice_jiuiv5_ITax_Handler ()
		{
			if (cb_tax_arrayBLwoyou_aidlservice_jiuiv5_ITax_ == null)
				cb_tax_arrayBLwoyou_aidlservice_jiuiv5_ITax_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_Tax_arrayBLwoyou_aidlservice_jiuiv5_ITax_);
			return cb_tax_arrayBLwoyou_aidlservice_jiuiv5_ITax_;
		}

		static void n_Tax_arrayBLwoyou_aidlservice_jiuiv5_ITax_ (IntPtr jnienv, IntPtr native__this, IntPtr native_data, IntPtr native__callback)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.WoyouServiceDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var data = (byte[]) JNIEnv.GetArray (native_data, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var @callback = (global::Woyou.Aidlservice.Jiuiv5.ITax)global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.ITax> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.Tax (data, @callback);
			if (data != null)
				JNIEnv.CopyArray (data, native_data);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/class[@name='IWoyouService.Default']/method[@name='tax' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='woyou.aidlservice.jiuiv5.ITax']]"
		[Register ("tax", "([BLwoyou/aidlservice/jiuiv5/ITax;)V", "GetTax_arrayBLwoyou_aidlservice_jiuiv5_ITax_Handler")]
		public virtual unsafe void Tax (byte[] data, global::Woyou.Aidlservice.Jiuiv5.ITax @callback)
		{
			const string __id = "tax.([BLwoyou/aidlservice/jiuiv5/ITax;)V";
			IntPtr native_data = JNIEnv.NewArray (data);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_data);
				__args [1] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (data != null) {
					JNIEnv.CopyArray (native_data, data);
					JNIEnv.DeleteLocalRef (native_data);
				}
				global::System.GC.KeepAlive (data);
				global::System.GC.KeepAlive (@callback);
			}
		}

		static Delegate cb_updatePrinterState;
#pragma warning disable 0169
		static Delegate GetUpdatePrinterStateHandler ()
		{
			if (cb_updatePrinterState == null)
				cb_updatePrinterState = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_UpdatePrinterState);
			return cb_updatePrinterState;
		}

		static int n_UpdatePrinterState (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.WoyouServiceDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.UpdatePrinterState ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/class[@name='IWoyouService.Default']/method[@name='updatePrinterState' and count(parameter)=0]"
		[Register ("updatePrinterState", "()I", "GetUpdatePrinterStateHandler")]
		public virtual unsafe int UpdatePrinterState ()
		{
			const string __id = "updatePrinterState.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

	}

	// Metadata.xml XPath class reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/class[@name='IWoyouService.Stub']"
	[global::Android.Runtime.Register ("woyou/aidlservice/jiuiv5/IWoyouService$Stub", DoNotGenerateAcw=true)]
	public abstract partial class WoyouServiceStub : global::Android.OS.Binder, global::Woyou.Aidlservice.Jiuiv5.IWoyouService {
		static readonly JniPeerMembers _members = new XAPeerMembers ("woyou/aidlservice/jiuiv5/IWoyouService$Stub", typeof (WoyouServiceStub));

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

		protected WoyouServiceStub (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/class[@name='IWoyouService.Stub']/constructor[@name='IWoyouService.Stub' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe WoyouServiceStub () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		public static unsafe global::Woyou.Aidlservice.Jiuiv5.IWoyouService DefaultImpl {
			// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/class[@name='IWoyouService.Stub']/method[@name='getDefaultImpl' and count(parameter)=0]"
			[Register ("getDefaultImpl", "()Lwoyou/aidlservice/jiuiv5/IWoyouService;", "")]
			get {
				const string __id = "getDefaultImpl.()Lwoyou/aidlservice/jiuiv5/IWoyouService;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.IWoyouService> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_asBinder;
#pragma warning disable 0169
		static Delegate GetAsBinderHandler ()
		{
			if (cb_asBinder == null)
				cb_asBinder = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_AsBinder);
			return cb_asBinder;
		}

		static IntPtr n_AsBinder (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.WoyouServiceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/class[@name='IWoyouService.Stub']/method[@name='asBinder' and count(parameter)=0]"
		[Register ("asBinder", "()Landroid/os/IBinder;", "GetAsBinderHandler")]
		public virtual unsafe global::Android.OS.IBinder AsBinder ()
		{
			const string __id = "asBinder.()Landroid/os/IBinder;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/class[@name='IWoyouService.Stub']/method[@name='asInterface' and count(parameter)=1 and parameter[1][@type='android.os.IBinder']]"
		[Register ("asInterface", "(Landroid/os/IBinder;)Lwoyou/aidlservice/jiuiv5/IWoyouService;", "")]
		public static unsafe global::Woyou.Aidlservice.Jiuiv5.IWoyouService AsInterface (global::Android.OS.IBinder obj)
		{
			const string __id = "asInterface.(Landroid/os/IBinder;)Lwoyou/aidlservice/jiuiv5/IWoyouService;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.IWoyouService> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (obj);
			}
		}

		static Delegate cb_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I;
#pragma warning disable 0169
		static Delegate GetOnTransact_ILandroid_os_Parcel_Landroid_os_Parcel_IHandler ()
		{
			if (cb_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I == null)
				cb_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPILLI_Z) n_OnTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I);
			return cb_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I;
		}

		static bool n_OnTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I (IntPtr jnienv, IntPtr native__this, int code, IntPtr native_data, IntPtr native_reply, int flags)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.WoyouServiceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var data = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_data, JniHandleOwnership.DoNotTransfer);
			var reply = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_reply, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnTransact (code, data, reply, flags);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/class[@name='IWoyouService.Stub']/method[@name='onTransact' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='android.os.Parcel'] and parameter[3][@type='android.os.Parcel'] and parameter[4][@type='int']]"
		[Register ("onTransact", "(ILandroid/os/Parcel;Landroid/os/Parcel;I)Z", "GetOnTransact_ILandroid_os_Parcel_Landroid_os_Parcel_IHandler")]
		public virtual unsafe bool OnTransact (int code, global::Android.OS.Parcel data, global::Android.OS.Parcel reply, int flags)
		{
			const string __id = "onTransact.(ILandroid/os/Parcel;Landroid/os/Parcel;I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (code);
				__args [1] = new JniArgumentValue ((data == null) ? IntPtr.Zero : ((global::Java.Lang.Object) data).Handle);
				__args [2] = new JniArgumentValue ((reply == null) ? IntPtr.Zero : ((global::Java.Lang.Object) reply).Handle);
				__args [3] = new JniArgumentValue (flags);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (data);
				global::System.GC.KeepAlive (reply);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/class[@name='IWoyouService.Stub']/method[@name='setDefaultImpl' and count(parameter)=1 and parameter[1][@type='woyou.aidlservice.jiuiv5.IWoyouService']]"
		[Register ("setDefaultImpl", "(Lwoyou/aidlservice/jiuiv5/IWoyouService;)Z", "")]
		public static unsafe bool SetDefaultImpl (global::Woyou.Aidlservice.Jiuiv5.IWoyouService impl)
		{
			const string __id = "setDefaultImpl.(Lwoyou/aidlservice/jiuiv5/IWoyouService;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((impl == null) ? IntPtr.Zero : ((global::Java.Lang.Object) impl).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (impl);
			}
		}

		static Delegate cb_commitPrinterBuffer;
#pragma warning disable 0169
		static Delegate GetCommitPrinterBufferHandler ()
		{
			if (cb_commitPrinterBuffer == null)
				cb_commitPrinterBuffer = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_CommitPrinterBuffer);
			return cb_commitPrinterBuffer;
		}

		static void n_CommitPrinterBuffer (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.WoyouServiceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CommitPrinterBuffer ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/interface[@name='IWoyouService']/method[@name='commitPrinterBuffer' and count(parameter)=0]"
		[Register ("commitPrinterBuffer", "()V", "GetCommitPrinterBufferHandler")]
		public abstract void CommitPrinterBuffer ();

		static Delegate cb_commitPrinterBufferWithCallback_Lwoyou_aidlservice_jiuiv5_ICallback_;
#pragma warning disable 0169
		static Delegate GetCommitPrinterBufferWithCallback_Lwoyou_aidlservice_jiuiv5_ICallback_Handler ()
		{
			if (cb_commitPrinterBufferWithCallback_Lwoyou_aidlservice_jiuiv5_ICallback_ == null)
				cb_commitPrinterBufferWithCallback_Lwoyou_aidlservice_jiuiv5_ICallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_CommitPrinterBufferWithCallback_Lwoyou_aidlservice_jiuiv5_ICallback_);
			return cb_commitPrinterBufferWithCallback_Lwoyou_aidlservice_jiuiv5_ICallback_;
		}

		static void n_CommitPrinterBufferWithCallback_Lwoyou_aidlservice_jiuiv5_ICallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.WoyouServiceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Woyou.Aidlservice.Jiuiv5.ICallback)global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.ICallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CommitPrinterBufferWithCallback (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/interface[@name='IWoyouService']/method[@name='commitPrinterBufferWithCallback' and count(parameter)=1 and parameter[1][@type='woyou.aidlservice.jiuiv5.ICallback']]"
		[Register ("commitPrinterBufferWithCallback", "(Lwoyou/aidlservice/jiuiv5/ICallback;)V", "GetCommitPrinterBufferWithCallback_Lwoyou_aidlservice_jiuiv5_ICallback_Handler")]
		public abstract void CommitPrinterBufferWithCallback (global::Woyou.Aidlservice.Jiuiv5.ICallback p0);

		static Delegate cb_cutPaper_Lwoyou_aidlservice_jiuiv5_ICallback_;
#pragma warning disable 0169
		static Delegate GetCutPaper_Lwoyou_aidlservice_jiuiv5_ICallback_Handler ()
		{
			if (cb_cutPaper_Lwoyou_aidlservice_jiuiv5_ICallback_ == null)
				cb_cutPaper_Lwoyou_aidlservice_jiuiv5_ICallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_CutPaper_Lwoyou_aidlservice_jiuiv5_ICallback_);
			return cb_cutPaper_Lwoyou_aidlservice_jiuiv5_ICallback_;
		}

		static void n_CutPaper_Lwoyou_aidlservice_jiuiv5_ICallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.WoyouServiceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Woyou.Aidlservice.Jiuiv5.ICallback)global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.ICallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CutPaper (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/interface[@name='IWoyouService']/method[@name='cutPaper' and count(parameter)=1 and parameter[1][@type='woyou.aidlservice.jiuiv5.ICallback']]"
		[Register ("cutPaper", "(Lwoyou/aidlservice/jiuiv5/ICallback;)V", "GetCutPaper_Lwoyou_aidlservice_jiuiv5_ICallback_Handler")]
		public abstract void CutPaper (global::Woyou.Aidlservice.Jiuiv5.ICallback p0);

		static Delegate cb_enterPrinterBuffer_Z;
#pragma warning disable 0169
		static Delegate GetEnterPrinterBuffer_ZHandler ()
		{
			if (cb_enterPrinterBuffer_Z == null)
				cb_enterPrinterBuffer_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_EnterPrinterBuffer_Z);
			return cb_enterPrinterBuffer_Z;
		}

		static void n_EnterPrinterBuffer_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.WoyouServiceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.EnterPrinterBuffer (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/interface[@name='IWoyouService']/method[@name='enterPrinterBuffer' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("enterPrinterBuffer", "(Z)V", "GetEnterPrinterBuffer_ZHandler")]
		public abstract void EnterPrinterBuffer (bool p0);

		static Delegate cb_exitPrinterBuffer_Z;
#pragma warning disable 0169
		static Delegate GetExitPrinterBuffer_ZHandler ()
		{
			if (cb_exitPrinterBuffer_Z == null)
				cb_exitPrinterBuffer_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_ExitPrinterBuffer_Z);
			return cb_exitPrinterBuffer_Z;
		}

		static void n_ExitPrinterBuffer_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.WoyouServiceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ExitPrinterBuffer (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/interface[@name='IWoyouService']/method[@name='exitPrinterBuffer' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("exitPrinterBuffer", "(Z)V", "GetExitPrinterBuffer_ZHandler")]
		public abstract void ExitPrinterBuffer (bool p0);

		static Delegate cb_exitPrinterBufferWithCallback_ZLwoyou_aidlservice_jiuiv5_ICallback_;
#pragma warning disable 0169
		static Delegate GetExitPrinterBufferWithCallback_ZLwoyou_aidlservice_jiuiv5_ICallback_Handler ()
		{
			if (cb_exitPrinterBufferWithCallback_ZLwoyou_aidlservice_jiuiv5_ICallback_ == null)
				cb_exitPrinterBufferWithCallback_ZLwoyou_aidlservice_jiuiv5_ICallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZL_V) n_ExitPrinterBufferWithCallback_ZLwoyou_aidlservice_jiuiv5_ICallback_);
			return cb_exitPrinterBufferWithCallback_ZLwoyou_aidlservice_jiuiv5_ICallback_;
		}

		static void n_ExitPrinterBufferWithCallback_ZLwoyou_aidlservice_jiuiv5_ICallback_ (IntPtr jnienv, IntPtr native__this, bool p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.WoyouServiceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Woyou.Aidlservice.Jiuiv5.ICallback)global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.ICallback> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.ExitPrinterBufferWithCallback (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/interface[@name='IWoyouService']/method[@name='exitPrinterBufferWithCallback' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='woyou.aidlservice.jiuiv5.ICallback']]"
		[Register ("exitPrinterBufferWithCallback", "(ZLwoyou/aidlservice/jiuiv5/ICallback;)V", "GetExitPrinterBufferWithCallback_ZLwoyou_aidlservice_jiuiv5_ICallback_Handler")]
		public abstract void ExitPrinterBufferWithCallback (bool p0, global::Woyou.Aidlservice.Jiuiv5.ICallback p1);

		static Delegate cb_lineWrap_ILwoyou_aidlservice_jiuiv5_ICallback_;
#pragma warning disable 0169
		static Delegate GetLineWrap_ILwoyou_aidlservice_jiuiv5_ICallback_Handler ()
		{
			if (cb_lineWrap_ILwoyou_aidlservice_jiuiv5_ICallback_ == null)
				cb_lineWrap_ILwoyou_aidlservice_jiuiv5_ICallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIL_V) n_LineWrap_ILwoyou_aidlservice_jiuiv5_ICallback_);
			return cb_lineWrap_ILwoyou_aidlservice_jiuiv5_ICallback_;
		}

		static void n_LineWrap_ILwoyou_aidlservice_jiuiv5_ICallback_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.WoyouServiceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Woyou.Aidlservice.Jiuiv5.ICallback)global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.ICallback> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.LineWrap (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/interface[@name='IWoyouService']/method[@name='lineWrap' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='woyou.aidlservice.jiuiv5.ICallback']]"
		[Register ("lineWrap", "(ILwoyou/aidlservice/jiuiv5/ICallback;)V", "GetLineWrap_ILwoyou_aidlservice_jiuiv5_ICallback_Handler")]
		public abstract void LineWrap (int p0, global::Woyou.Aidlservice.Jiuiv5.ICallback p1);

		static Delegate cb_openDrawer_Lwoyou_aidlservice_jiuiv5_ICallback_;
#pragma warning disable 0169
		static Delegate GetOpenDrawer_Lwoyou_aidlservice_jiuiv5_ICallback_Handler ()
		{
			if (cb_openDrawer_Lwoyou_aidlservice_jiuiv5_ICallback_ == null)
				cb_openDrawer_Lwoyou_aidlservice_jiuiv5_ICallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OpenDrawer_Lwoyou_aidlservice_jiuiv5_ICallback_);
			return cb_openDrawer_Lwoyou_aidlservice_jiuiv5_ICallback_;
		}

		static void n_OpenDrawer_Lwoyou_aidlservice_jiuiv5_ICallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.WoyouServiceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Woyou.Aidlservice.Jiuiv5.ICallback)global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.ICallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OpenDrawer (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/interface[@name='IWoyouService']/method[@name='openDrawer' and count(parameter)=1 and parameter[1][@type='woyou.aidlservice.jiuiv5.ICallback']]"
		[Register ("openDrawer", "(Lwoyou/aidlservice/jiuiv5/ICallback;)V", "GetOpenDrawer_Lwoyou_aidlservice_jiuiv5_ICallback_Handler")]
		public abstract void OpenDrawer (global::Woyou.Aidlservice.Jiuiv5.ICallback p0);

		static Delegate cb_postPrintData_Ljava_lang_String_arrayBII;
#pragma warning disable 0169
		static Delegate GetPostPrintData_Ljava_lang_String_arrayBIIHandler ()
		{
			if (cb_postPrintData_Ljava_lang_String_arrayBII == null)
				cb_postPrintData_Ljava_lang_String_arrayBII = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLII_Z) n_PostPrintData_Ljava_lang_String_arrayBII);
			return cb_postPrintData_Ljava_lang_String_arrayBII;
		}

		static bool n_PostPrintData_Ljava_lang_String_arrayBII (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2, int p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.WoyouServiceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			bool __ret = __this.PostPrintData (p0, p1, p2, p3);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/interface[@name='IWoyouService']/method[@name='postPrintData' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='byte[]'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("postPrintData", "(Ljava/lang/String;[BII)Z", "GetPostPrintData_Ljava_lang_String_arrayBIIHandler")]
		public abstract bool PostPrintData (string p0, byte[] p1, int p2, int p3);

		static Delegate cb_printBarCode_Ljava_lang_String_IIIILwoyou_aidlservice_jiuiv5_ICallback_;
#pragma warning disable 0169
		static Delegate GetPrintBarCode_Ljava_lang_String_IIIILwoyou_aidlservice_jiuiv5_ICallback_Handler ()
		{
			if (cb_printBarCode_Ljava_lang_String_IIIILwoyou_aidlservice_jiuiv5_ICallback_ == null)
				cb_printBarCode_Ljava_lang_String_IIIILwoyou_aidlservice_jiuiv5_ICallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLIIIIL_V) n_PrintBarCode_Ljava_lang_String_IIIILwoyou_aidlservice_jiuiv5_ICallback_);
			return cb_printBarCode_Ljava_lang_String_IIIILwoyou_aidlservice_jiuiv5_ICallback_;
		}

		static void n_PrintBarCode_Ljava_lang_String_IIIILwoyou_aidlservice_jiuiv5_ICallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2, int p3, int p4, IntPtr native_p5)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.WoyouServiceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p5 = (global::Woyou.Aidlservice.Jiuiv5.ICallback)global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.ICallback> (native_p5, JniHandleOwnership.DoNotTransfer);
			__this.PrintBarCode (p0, p1, p2, p3, p4, p5);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/interface[@name='IWoyouService']/method[@name='printBarCode' and count(parameter)=6 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='woyou.aidlservice.jiuiv5.ICallback']]"
		[Register ("printBarCode", "(Ljava/lang/String;IIIILwoyou/aidlservice/jiuiv5/ICallback;)V", "GetPrintBarCode_Ljava_lang_String_IIIILwoyou_aidlservice_jiuiv5_ICallback_Handler")]
		public abstract void PrintBarCode (string p0, int p1, int p2, int p3, int p4, global::Woyou.Aidlservice.Jiuiv5.ICallback p5);

		static Delegate cb_printBitmap_Landroid_graphics_Bitmap_Lwoyou_aidlservice_jiuiv5_ICallback_;
#pragma warning disable 0169
		static Delegate GetPrintBitmap_Landroid_graphics_Bitmap_Lwoyou_aidlservice_jiuiv5_ICallback_Handler ()
		{
			if (cb_printBitmap_Landroid_graphics_Bitmap_Lwoyou_aidlservice_jiuiv5_ICallback_ == null)
				cb_printBitmap_Landroid_graphics_Bitmap_Lwoyou_aidlservice_jiuiv5_ICallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_PrintBitmap_Landroid_graphics_Bitmap_Lwoyou_aidlservice_jiuiv5_ICallback_);
			return cb_printBitmap_Landroid_graphics_Bitmap_Lwoyou_aidlservice_jiuiv5_ICallback_;
		}

		static void n_PrintBitmap_Landroid_graphics_Bitmap_Lwoyou_aidlservice_jiuiv5_ICallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.WoyouServiceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Woyou.Aidlservice.Jiuiv5.ICallback)global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.ICallback> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.PrintBitmap (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/interface[@name='IWoyouService']/method[@name='printBitmap' and count(parameter)=2 and parameter[1][@type='android.graphics.Bitmap'] and parameter[2][@type='woyou.aidlservice.jiuiv5.ICallback']]"
		[Register ("printBitmap", "(Landroid/graphics/Bitmap;Lwoyou/aidlservice/jiuiv5/ICallback;)V", "GetPrintBitmap_Landroid_graphics_Bitmap_Lwoyou_aidlservice_jiuiv5_ICallback_Handler")]
		public abstract void PrintBitmap (global::Android.Graphics.Bitmap p0, global::Woyou.Aidlservice.Jiuiv5.ICallback p1);

		static Delegate cb_printBitmapCustom_Landroid_graphics_Bitmap_ILwoyou_aidlservice_jiuiv5_ICallback_;
#pragma warning disable 0169
		static Delegate GetPrintBitmapCustom_Landroid_graphics_Bitmap_ILwoyou_aidlservice_jiuiv5_ICallback_Handler ()
		{
			if (cb_printBitmapCustom_Landroid_graphics_Bitmap_ILwoyou_aidlservice_jiuiv5_ICallback_ == null)
				cb_printBitmapCustom_Landroid_graphics_Bitmap_ILwoyou_aidlservice_jiuiv5_ICallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLIL_V) n_PrintBitmapCustom_Landroid_graphics_Bitmap_ILwoyou_aidlservice_jiuiv5_ICallback_);
			return cb_printBitmapCustom_Landroid_graphics_Bitmap_ILwoyou_aidlservice_jiuiv5_ICallback_;
		}

		static void n_PrintBitmapCustom_Landroid_graphics_Bitmap_ILwoyou_aidlservice_jiuiv5_ICallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.WoyouServiceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p2 = (global::Woyou.Aidlservice.Jiuiv5.ICallback)global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.ICallback> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.PrintBitmapCustom (p0, p1, p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/interface[@name='IWoyouService']/method[@name='printBitmapCustom' and count(parameter)=3 and parameter[1][@type='android.graphics.Bitmap'] and parameter[2][@type='int'] and parameter[3][@type='woyou.aidlservice.jiuiv5.ICallback']]"
		[Register ("printBitmapCustom", "(Landroid/graphics/Bitmap;ILwoyou/aidlservice/jiuiv5/ICallback;)V", "GetPrintBitmapCustom_Landroid_graphics_Bitmap_ILwoyou_aidlservice_jiuiv5_ICallback_Handler")]
		public abstract void PrintBitmapCustom (global::Android.Graphics.Bitmap p0, int p1, global::Woyou.Aidlservice.Jiuiv5.ICallback p2);

		static Delegate cb_printColumnsString_arrayLjava_lang_String_arrayIarrayILwoyou_aidlservice_jiuiv5_ICallback_;
#pragma warning disable 0169
		static Delegate GetPrintColumnsString_arrayLjava_lang_String_arrayIarrayILwoyou_aidlservice_jiuiv5_ICallback_Handler ()
		{
			if (cb_printColumnsString_arrayLjava_lang_String_arrayIarrayILwoyou_aidlservice_jiuiv5_ICallback_ == null)
				cb_printColumnsString_arrayLjava_lang_String_arrayIarrayILwoyou_aidlservice_jiuiv5_ICallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLL_V) n_PrintColumnsString_arrayLjava_lang_String_arrayIarrayILwoyou_aidlservice_jiuiv5_ICallback_);
			return cb_printColumnsString_arrayLjava_lang_String_arrayIarrayILwoyou_aidlservice_jiuiv5_ICallback_;
		}

		static void n_PrintColumnsString_arrayLjava_lang_String_arrayIarrayILwoyou_aidlservice_jiuiv5_ICallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.WoyouServiceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (string[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (string));
			var p1 = (int[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (int));
			var p2 = (int[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (int));
			var p3 = (global::Woyou.Aidlservice.Jiuiv5.ICallback)global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.ICallback> (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.PrintColumnsString (p0, p1, p2, p3);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/interface[@name='IWoyouService']/method[@name='printColumnsString' and count(parameter)=4 and parameter[1][@type='java.lang.String[]'] and parameter[2][@type='int[]'] and parameter[3][@type='int[]'] and parameter[4][@type='woyou.aidlservice.jiuiv5.ICallback']]"
		[Register ("printColumnsString", "([Ljava/lang/String;[I[ILwoyou/aidlservice/jiuiv5/ICallback;)V", "GetPrintColumnsString_arrayLjava_lang_String_arrayIarrayILwoyou_aidlservice_jiuiv5_ICallback_Handler")]
		public abstract void PrintColumnsString (string[] p0, int[] p1, int[] p2, global::Woyou.Aidlservice.Jiuiv5.ICallback p3);

		static Delegate cb_printColumnsText_arrayLjava_lang_String_arrayIarrayILwoyou_aidlservice_jiuiv5_ICallback_;
#pragma warning disable 0169
		static Delegate GetPrintColumnsText_arrayLjava_lang_String_arrayIarrayILwoyou_aidlservice_jiuiv5_ICallback_Handler ()
		{
			if (cb_printColumnsText_arrayLjava_lang_String_arrayIarrayILwoyou_aidlservice_jiuiv5_ICallback_ == null)
				cb_printColumnsText_arrayLjava_lang_String_arrayIarrayILwoyou_aidlservice_jiuiv5_ICallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLL_V) n_PrintColumnsText_arrayLjava_lang_String_arrayIarrayILwoyou_aidlservice_jiuiv5_ICallback_);
			return cb_printColumnsText_arrayLjava_lang_String_arrayIarrayILwoyou_aidlservice_jiuiv5_ICallback_;
		}

		static void n_PrintColumnsText_arrayLjava_lang_String_arrayIarrayILwoyou_aidlservice_jiuiv5_ICallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.WoyouServiceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (string[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (string));
			var p1 = (int[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (int));
			var p2 = (int[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (int));
			var p3 = (global::Woyou.Aidlservice.Jiuiv5.ICallback)global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.ICallback> (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.PrintColumnsText (p0, p1, p2, p3);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/interface[@name='IWoyouService']/method[@name='printColumnsText' and count(parameter)=4 and parameter[1][@type='java.lang.String[]'] and parameter[2][@type='int[]'] and parameter[3][@type='int[]'] and parameter[4][@type='woyou.aidlservice.jiuiv5.ICallback']]"
		[Register ("printColumnsText", "([Ljava/lang/String;[I[ILwoyou/aidlservice/jiuiv5/ICallback;)V", "GetPrintColumnsText_arrayLjava_lang_String_arrayIarrayILwoyou_aidlservice_jiuiv5_ICallback_Handler")]
		public abstract void PrintColumnsText (string[] p0, int[] p1, int[] p2, global::Woyou.Aidlservice.Jiuiv5.ICallback p3);

		static Delegate cb_printOriginalText_Ljava_lang_String_Lwoyou_aidlservice_jiuiv5_ICallback_;
#pragma warning disable 0169
		static Delegate GetPrintOriginalText_Ljava_lang_String_Lwoyou_aidlservice_jiuiv5_ICallback_Handler ()
		{
			if (cb_printOriginalText_Ljava_lang_String_Lwoyou_aidlservice_jiuiv5_ICallback_ == null)
				cb_printOriginalText_Ljava_lang_String_Lwoyou_aidlservice_jiuiv5_ICallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_PrintOriginalText_Ljava_lang_String_Lwoyou_aidlservice_jiuiv5_ICallback_);
			return cb_printOriginalText_Ljava_lang_String_Lwoyou_aidlservice_jiuiv5_ICallback_;
		}

		static void n_PrintOriginalText_Ljava_lang_String_Lwoyou_aidlservice_jiuiv5_ICallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.WoyouServiceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Woyou.Aidlservice.Jiuiv5.ICallback)global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.ICallback> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.PrintOriginalText (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/interface[@name='IWoyouService']/method[@name='printOriginalText' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='woyou.aidlservice.jiuiv5.ICallback']]"
		[Register ("printOriginalText", "(Ljava/lang/String;Lwoyou/aidlservice/jiuiv5/ICallback;)V", "GetPrintOriginalText_Ljava_lang_String_Lwoyou_aidlservice_jiuiv5_ICallback_Handler")]
		public abstract void PrintOriginalText (string p0, global::Woyou.Aidlservice.Jiuiv5.ICallback p1);

		static Delegate cb_printQRCode_Ljava_lang_String_IILwoyou_aidlservice_jiuiv5_ICallback_;
#pragma warning disable 0169
		static Delegate GetPrintQRCode_Ljava_lang_String_IILwoyou_aidlservice_jiuiv5_ICallback_Handler ()
		{
			if (cb_printQRCode_Ljava_lang_String_IILwoyou_aidlservice_jiuiv5_ICallback_ == null)
				cb_printQRCode_Ljava_lang_String_IILwoyou_aidlservice_jiuiv5_ICallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLIIL_V) n_PrintQRCode_Ljava_lang_String_IILwoyou_aidlservice_jiuiv5_ICallback_);
			return cb_printQRCode_Ljava_lang_String_IILwoyou_aidlservice_jiuiv5_ICallback_;
		}

		static void n_PrintQRCode_Ljava_lang_String_IILwoyou_aidlservice_jiuiv5_ICallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2, IntPtr native_p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.WoyouServiceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p3 = (global::Woyou.Aidlservice.Jiuiv5.ICallback)global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.ICallback> (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.PrintQRCode (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/interface[@name='IWoyouService']/method[@name='printQRCode' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='woyou.aidlservice.jiuiv5.ICallback']]"
		[Register ("printQRCode", "(Ljava/lang/String;IILwoyou/aidlservice/jiuiv5/ICallback;)V", "GetPrintQRCode_Ljava_lang_String_IILwoyou_aidlservice_jiuiv5_ICallback_Handler")]
		public abstract void PrintQRCode (string p0, int p1, int p2, global::Woyou.Aidlservice.Jiuiv5.ICallback p3);

		static Delegate cb_printText_Ljava_lang_String_Lwoyou_aidlservice_jiuiv5_ICallback_;
#pragma warning disable 0169
		static Delegate GetPrintText_Ljava_lang_String_Lwoyou_aidlservice_jiuiv5_ICallback_Handler ()
		{
			if (cb_printText_Ljava_lang_String_Lwoyou_aidlservice_jiuiv5_ICallback_ == null)
				cb_printText_Ljava_lang_String_Lwoyou_aidlservice_jiuiv5_ICallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_PrintText_Ljava_lang_String_Lwoyou_aidlservice_jiuiv5_ICallback_);
			return cb_printText_Ljava_lang_String_Lwoyou_aidlservice_jiuiv5_ICallback_;
		}

		static void n_PrintText_Ljava_lang_String_Lwoyou_aidlservice_jiuiv5_ICallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.WoyouServiceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Woyou.Aidlservice.Jiuiv5.ICallback)global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.ICallback> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.PrintText (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/interface[@name='IWoyouService']/method[@name='printText' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='woyou.aidlservice.jiuiv5.ICallback']]"
		[Register ("printText", "(Ljava/lang/String;Lwoyou/aidlservice/jiuiv5/ICallback;)V", "GetPrintText_Ljava_lang_String_Lwoyou_aidlservice_jiuiv5_ICallback_Handler")]
		public abstract void PrintText (string p0, global::Woyou.Aidlservice.Jiuiv5.ICallback p1);

		static Delegate cb_printTextWithFont_Ljava_lang_String_Ljava_lang_String_FLwoyou_aidlservice_jiuiv5_ICallback_;
#pragma warning disable 0169
		static Delegate GetPrintTextWithFont_Ljava_lang_String_Ljava_lang_String_FLwoyou_aidlservice_jiuiv5_ICallback_Handler ()
		{
			if (cb_printTextWithFont_Ljava_lang_String_Ljava_lang_String_FLwoyou_aidlservice_jiuiv5_ICallback_ == null)
				cb_printTextWithFont_Ljava_lang_String_Ljava_lang_String_FLwoyou_aidlservice_jiuiv5_ICallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLFL_V) n_PrintTextWithFont_Ljava_lang_String_Ljava_lang_String_FLwoyou_aidlservice_jiuiv5_ICallback_);
			return cb_printTextWithFont_Ljava_lang_String_Ljava_lang_String_FLwoyou_aidlservice_jiuiv5_ICallback_;
		}

		static void n_PrintTextWithFont_Ljava_lang_String_Ljava_lang_String_FLwoyou_aidlservice_jiuiv5_ICallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, float p2, IntPtr native_p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.WoyouServiceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p3 = (global::Woyou.Aidlservice.Jiuiv5.ICallback)global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.ICallback> (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.PrintTextWithFont (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/interface[@name='IWoyouService']/method[@name='printTextWithFont' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='float'] and parameter[4][@type='woyou.aidlservice.jiuiv5.ICallback']]"
		[Register ("printTextWithFont", "(Ljava/lang/String;Ljava/lang/String;FLwoyou/aidlservice/jiuiv5/ICallback;)V", "GetPrintTextWithFont_Ljava_lang_String_Ljava_lang_String_FLwoyou_aidlservice_jiuiv5_ICallback_Handler")]
		public abstract void PrintTextWithFont (string p0, string p1, float p2, global::Woyou.Aidlservice.Jiuiv5.ICallback p3);

		static Delegate cb_printerInit_Lwoyou_aidlservice_jiuiv5_ICallback_;
#pragma warning disable 0169
		static Delegate GetPrinterInit_Lwoyou_aidlservice_jiuiv5_ICallback_Handler ()
		{
			if (cb_printerInit_Lwoyou_aidlservice_jiuiv5_ICallback_ == null)
				cb_printerInit_Lwoyou_aidlservice_jiuiv5_ICallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_PrinterInit_Lwoyou_aidlservice_jiuiv5_ICallback_);
			return cb_printerInit_Lwoyou_aidlservice_jiuiv5_ICallback_;
		}

		static void n_PrinterInit_Lwoyou_aidlservice_jiuiv5_ICallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.WoyouServiceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Woyou.Aidlservice.Jiuiv5.ICallback)global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.ICallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PrinterInit (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/interface[@name='IWoyouService']/method[@name='printerInit' and count(parameter)=1 and parameter[1][@type='woyou.aidlservice.jiuiv5.ICallback']]"
		[Register ("printerInit", "(Lwoyou/aidlservice/jiuiv5/ICallback;)V", "GetPrinterInit_Lwoyou_aidlservice_jiuiv5_ICallback_Handler")]
		public abstract void PrinterInit (global::Woyou.Aidlservice.Jiuiv5.ICallback p0);

		static Delegate cb_printerSelfChecking_Lwoyou_aidlservice_jiuiv5_ICallback_;
#pragma warning disable 0169
		static Delegate GetPrinterSelfChecking_Lwoyou_aidlservice_jiuiv5_ICallback_Handler ()
		{
			if (cb_printerSelfChecking_Lwoyou_aidlservice_jiuiv5_ICallback_ == null)
				cb_printerSelfChecking_Lwoyou_aidlservice_jiuiv5_ICallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_PrinterSelfChecking_Lwoyou_aidlservice_jiuiv5_ICallback_);
			return cb_printerSelfChecking_Lwoyou_aidlservice_jiuiv5_ICallback_;
		}

		static void n_PrinterSelfChecking_Lwoyou_aidlservice_jiuiv5_ICallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.WoyouServiceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Woyou.Aidlservice.Jiuiv5.ICallback)global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.ICallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PrinterSelfChecking (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/interface[@name='IWoyouService']/method[@name='printerSelfChecking' and count(parameter)=1 and parameter[1][@type='woyou.aidlservice.jiuiv5.ICallback']]"
		[Register ("printerSelfChecking", "(Lwoyou/aidlservice/jiuiv5/ICallback;)V", "GetPrinterSelfChecking_Lwoyou_aidlservice_jiuiv5_ICallback_Handler")]
		public abstract void PrinterSelfChecking (global::Woyou.Aidlservice.Jiuiv5.ICallback p0);

		static Delegate cb_sendLCDBitmap_Landroid_graphics_Bitmap_Lwoyou_aidlservice_jiuiv5_ILcdCallback_;
#pragma warning disable 0169
		static Delegate GetSendLCDBitmap_Landroid_graphics_Bitmap_Lwoyou_aidlservice_jiuiv5_ILcdCallback_Handler ()
		{
			if (cb_sendLCDBitmap_Landroid_graphics_Bitmap_Lwoyou_aidlservice_jiuiv5_ILcdCallback_ == null)
				cb_sendLCDBitmap_Landroid_graphics_Bitmap_Lwoyou_aidlservice_jiuiv5_ILcdCallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_SendLCDBitmap_Landroid_graphics_Bitmap_Lwoyou_aidlservice_jiuiv5_ILcdCallback_);
			return cb_sendLCDBitmap_Landroid_graphics_Bitmap_Lwoyou_aidlservice_jiuiv5_ILcdCallback_;
		}

		static void n_SendLCDBitmap_Landroid_graphics_Bitmap_Lwoyou_aidlservice_jiuiv5_ILcdCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.WoyouServiceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Woyou.Aidlservice.Jiuiv5.ILcdCallback)global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.ILcdCallback> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SendLCDBitmap (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/interface[@name='IWoyouService']/method[@name='sendLCDBitmap' and count(parameter)=2 and parameter[1][@type='android.graphics.Bitmap'] and parameter[2][@type='woyou.aidlservice.jiuiv5.ILcdCallback']]"
		[Register ("sendLCDBitmap", "(Landroid/graphics/Bitmap;Lwoyou/aidlservice/jiuiv5/ILcdCallback;)V", "GetSendLCDBitmap_Landroid_graphics_Bitmap_Lwoyou_aidlservice_jiuiv5_ILcdCallback_Handler")]
		public abstract void SendLCDBitmap (global::Android.Graphics.Bitmap p0, global::Woyou.Aidlservice.Jiuiv5.ILcdCallback p1);

		static Delegate cb_sendLCDCommand_I;
#pragma warning disable 0169
		static Delegate GetSendLCDCommand_IHandler ()
		{
			if (cb_sendLCDCommand_I == null)
				cb_sendLCDCommand_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SendLCDCommand_I);
			return cb_sendLCDCommand_I;
		}

		static void n_SendLCDCommand_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.WoyouServiceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SendLCDCommand (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/interface[@name='IWoyouService']/method[@name='sendLCDCommand' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("sendLCDCommand", "(I)V", "GetSendLCDCommand_IHandler")]
		public abstract void SendLCDCommand (int p0);

		static Delegate cb_sendLCDDoubleString_Ljava_lang_String_Ljava_lang_String_Lwoyou_aidlservice_jiuiv5_ILcdCallback_;
#pragma warning disable 0169
		static Delegate GetSendLCDDoubleString_Ljava_lang_String_Ljava_lang_String_Lwoyou_aidlservice_jiuiv5_ILcdCallback_Handler ()
		{
			if (cb_sendLCDDoubleString_Ljava_lang_String_Ljava_lang_String_Lwoyou_aidlservice_jiuiv5_ILcdCallback_ == null)
				cb_sendLCDDoubleString_Ljava_lang_String_Ljava_lang_String_Lwoyou_aidlservice_jiuiv5_ILcdCallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_SendLCDDoubleString_Ljava_lang_String_Ljava_lang_String_Lwoyou_aidlservice_jiuiv5_ILcdCallback_);
			return cb_sendLCDDoubleString_Ljava_lang_String_Ljava_lang_String_Lwoyou_aidlservice_jiuiv5_ILcdCallback_;
		}

		static void n_SendLCDDoubleString_Ljava_lang_String_Ljava_lang_String_Lwoyou_aidlservice_jiuiv5_ILcdCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.WoyouServiceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = (global::Woyou.Aidlservice.Jiuiv5.ILcdCallback)global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.ILcdCallback> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.SendLCDDoubleString (p0, p1, p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/interface[@name='IWoyouService']/method[@name='sendLCDDoubleString' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='woyou.aidlservice.jiuiv5.ILcdCallback']]"
		[Register ("sendLCDDoubleString", "(Ljava/lang/String;Ljava/lang/String;Lwoyou/aidlservice/jiuiv5/ILcdCallback;)V", "GetSendLCDDoubleString_Ljava_lang_String_Ljava_lang_String_Lwoyou_aidlservice_jiuiv5_ILcdCallback_Handler")]
		public abstract void SendLCDDoubleString (string p0, string p1, global::Woyou.Aidlservice.Jiuiv5.ILcdCallback p2);

		static Delegate cb_sendLCDFillString_Ljava_lang_String_IZLwoyou_aidlservice_jiuiv5_ILcdCallback_;
#pragma warning disable 0169
		static Delegate GetSendLCDFillString_Ljava_lang_String_IZLwoyou_aidlservice_jiuiv5_ILcdCallback_Handler ()
		{
			if (cb_sendLCDFillString_Ljava_lang_String_IZLwoyou_aidlservice_jiuiv5_ILcdCallback_ == null)
				cb_sendLCDFillString_Ljava_lang_String_IZLwoyou_aidlservice_jiuiv5_ILcdCallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLIZL_V) n_SendLCDFillString_Ljava_lang_String_IZLwoyou_aidlservice_jiuiv5_ILcdCallback_);
			return cb_sendLCDFillString_Ljava_lang_String_IZLwoyou_aidlservice_jiuiv5_ILcdCallback_;
		}

		static void n_SendLCDFillString_Ljava_lang_String_IZLwoyou_aidlservice_jiuiv5_ILcdCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, bool p2, IntPtr native_p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.WoyouServiceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p3 = (global::Woyou.Aidlservice.Jiuiv5.ILcdCallback)global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.ILcdCallback> (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.SendLCDFillString (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/interface[@name='IWoyouService']/method[@name='sendLCDFillString' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='boolean'] and parameter[4][@type='woyou.aidlservice.jiuiv5.ILcdCallback']]"
		[Register ("sendLCDFillString", "(Ljava/lang/String;IZLwoyou/aidlservice/jiuiv5/ILcdCallback;)V", "GetSendLCDFillString_Ljava_lang_String_IZLwoyou_aidlservice_jiuiv5_ILcdCallback_Handler")]
		public abstract void SendLCDFillString (string p0, int p1, bool p2, global::Woyou.Aidlservice.Jiuiv5.ILcdCallback p3);

		static Delegate cb_sendLCDMultiString_arrayLjava_lang_String_arrayILwoyou_aidlservice_jiuiv5_ILcdCallback_;
#pragma warning disable 0169
		static Delegate GetSendLCDMultiString_arrayLjava_lang_String_arrayILwoyou_aidlservice_jiuiv5_ILcdCallback_Handler ()
		{
			if (cb_sendLCDMultiString_arrayLjava_lang_String_arrayILwoyou_aidlservice_jiuiv5_ILcdCallback_ == null)
				cb_sendLCDMultiString_arrayLjava_lang_String_arrayILwoyou_aidlservice_jiuiv5_ILcdCallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_SendLCDMultiString_arrayLjava_lang_String_arrayILwoyou_aidlservice_jiuiv5_ILcdCallback_);
			return cb_sendLCDMultiString_arrayLjava_lang_String_arrayILwoyou_aidlservice_jiuiv5_ILcdCallback_;
		}

		static void n_SendLCDMultiString_arrayLjava_lang_String_arrayILwoyou_aidlservice_jiuiv5_ILcdCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.WoyouServiceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (string[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (string));
			var p1 = (int[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (int));
			var p2 = (global::Woyou.Aidlservice.Jiuiv5.ILcdCallback)global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.ILcdCallback> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.SendLCDMultiString (p0, p1, p2);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/interface[@name='IWoyouService']/method[@name='sendLCDMultiString' and count(parameter)=3 and parameter[1][@type='java.lang.String[]'] and parameter[2][@type='int[]'] and parameter[3][@type='woyou.aidlservice.jiuiv5.ILcdCallback']]"
		[Register ("sendLCDMultiString", "([Ljava/lang/String;[ILwoyou/aidlservice/jiuiv5/ILcdCallback;)V", "GetSendLCDMultiString_arrayLjava_lang_String_arrayILwoyou_aidlservice_jiuiv5_ILcdCallback_Handler")]
		public abstract void SendLCDMultiString (string[] p0, int[] p1, global::Woyou.Aidlservice.Jiuiv5.ILcdCallback p2);

		static Delegate cb_sendLCDString_Ljava_lang_String_Lwoyou_aidlservice_jiuiv5_ILcdCallback_;
#pragma warning disable 0169
		static Delegate GetSendLCDString_Ljava_lang_String_Lwoyou_aidlservice_jiuiv5_ILcdCallback_Handler ()
		{
			if (cb_sendLCDString_Ljava_lang_String_Lwoyou_aidlservice_jiuiv5_ILcdCallback_ == null)
				cb_sendLCDString_Ljava_lang_String_Lwoyou_aidlservice_jiuiv5_ILcdCallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_SendLCDString_Ljava_lang_String_Lwoyou_aidlservice_jiuiv5_ILcdCallback_);
			return cb_sendLCDString_Ljava_lang_String_Lwoyou_aidlservice_jiuiv5_ILcdCallback_;
		}

		static void n_SendLCDString_Ljava_lang_String_Lwoyou_aidlservice_jiuiv5_ILcdCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.WoyouServiceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Woyou.Aidlservice.Jiuiv5.ILcdCallback)global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.ILcdCallback> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SendLCDString (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/interface[@name='IWoyouService']/method[@name='sendLCDString' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='woyou.aidlservice.jiuiv5.ILcdCallback']]"
		[Register ("sendLCDString", "(Ljava/lang/String;Lwoyou/aidlservice/jiuiv5/ILcdCallback;)V", "GetSendLCDString_Ljava_lang_String_Lwoyou_aidlservice_jiuiv5_ILcdCallback_Handler")]
		public abstract void SendLCDString (string p0, global::Woyou.Aidlservice.Jiuiv5.ILcdCallback p1);

		static Delegate cb_sendRAWData_arrayBLwoyou_aidlservice_jiuiv5_ICallback_;
#pragma warning disable 0169
		static Delegate GetSendRAWData_arrayBLwoyou_aidlservice_jiuiv5_ICallback_Handler ()
		{
			if (cb_sendRAWData_arrayBLwoyou_aidlservice_jiuiv5_ICallback_ == null)
				cb_sendRAWData_arrayBLwoyou_aidlservice_jiuiv5_ICallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_SendRAWData_arrayBLwoyou_aidlservice_jiuiv5_ICallback_);
			return cb_sendRAWData_arrayBLwoyou_aidlservice_jiuiv5_ICallback_;
		}

		static void n_SendRAWData_arrayBLwoyou_aidlservice_jiuiv5_ICallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.WoyouServiceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p1 = (global::Woyou.Aidlservice.Jiuiv5.ICallback)global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.ICallback> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SendRAWData (p0, p1);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/interface[@name='IWoyouService']/method[@name='sendRAWData' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='woyou.aidlservice.jiuiv5.ICallback']]"
		[Register ("sendRAWData", "([BLwoyou/aidlservice/jiuiv5/ICallback;)V", "GetSendRAWData_arrayBLwoyou_aidlservice_jiuiv5_ICallback_Handler")]
		public abstract void SendRAWData (byte[] p0, global::Woyou.Aidlservice.Jiuiv5.ICallback p1);

		static Delegate cb_setAlignment_ILwoyou_aidlservice_jiuiv5_ICallback_;
#pragma warning disable 0169
		static Delegate GetSetAlignment_ILwoyou_aidlservice_jiuiv5_ICallback_Handler ()
		{
			if (cb_setAlignment_ILwoyou_aidlservice_jiuiv5_ICallback_ == null)
				cb_setAlignment_ILwoyou_aidlservice_jiuiv5_ICallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIL_V) n_SetAlignment_ILwoyou_aidlservice_jiuiv5_ICallback_);
			return cb_setAlignment_ILwoyou_aidlservice_jiuiv5_ICallback_;
		}

		static void n_SetAlignment_ILwoyou_aidlservice_jiuiv5_ICallback_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.WoyouServiceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Woyou.Aidlservice.Jiuiv5.ICallback)global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.ICallback> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetAlignment (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/interface[@name='IWoyouService']/method[@name='setAlignment' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='woyou.aidlservice.jiuiv5.ICallback']]"
		[Register ("setAlignment", "(ILwoyou/aidlservice/jiuiv5/ICallback;)V", "GetSetAlignment_ILwoyou_aidlservice_jiuiv5_ICallback_Handler")]
		public abstract void SetAlignment (int p0, global::Woyou.Aidlservice.Jiuiv5.ICallback p1);

		static Delegate cb_setFontName_Ljava_lang_String_Lwoyou_aidlservice_jiuiv5_ICallback_;
#pragma warning disable 0169
		static Delegate GetSetFontName_Ljava_lang_String_Lwoyou_aidlservice_jiuiv5_ICallback_Handler ()
		{
			if (cb_setFontName_Ljava_lang_String_Lwoyou_aidlservice_jiuiv5_ICallback_ == null)
				cb_setFontName_Ljava_lang_String_Lwoyou_aidlservice_jiuiv5_ICallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_SetFontName_Ljava_lang_String_Lwoyou_aidlservice_jiuiv5_ICallback_);
			return cb_setFontName_Ljava_lang_String_Lwoyou_aidlservice_jiuiv5_ICallback_;
		}

		static void n_SetFontName_Ljava_lang_String_Lwoyou_aidlservice_jiuiv5_ICallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.WoyouServiceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Woyou.Aidlservice.Jiuiv5.ICallback)global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.ICallback> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetFontName (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/interface[@name='IWoyouService']/method[@name='setFontName' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='woyou.aidlservice.jiuiv5.ICallback']]"
		[Register ("setFontName", "(Ljava/lang/String;Lwoyou/aidlservice/jiuiv5/ICallback;)V", "GetSetFontName_Ljava_lang_String_Lwoyou_aidlservice_jiuiv5_ICallback_Handler")]
		public abstract void SetFontName (string p0, global::Woyou.Aidlservice.Jiuiv5.ICallback p1);

		static Delegate cb_setFontSize_FLwoyou_aidlservice_jiuiv5_ICallback_;
#pragma warning disable 0169
		static Delegate GetSetFontSize_FLwoyou_aidlservice_jiuiv5_ICallback_Handler ()
		{
			if (cb_setFontSize_FLwoyou_aidlservice_jiuiv5_ICallback_ == null)
				cb_setFontSize_FLwoyou_aidlservice_jiuiv5_ICallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPFL_V) n_SetFontSize_FLwoyou_aidlservice_jiuiv5_ICallback_);
			return cb_setFontSize_FLwoyou_aidlservice_jiuiv5_ICallback_;
		}

		static void n_SetFontSize_FLwoyou_aidlservice_jiuiv5_ICallback_ (IntPtr jnienv, IntPtr native__this, float p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.WoyouServiceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Woyou.Aidlservice.Jiuiv5.ICallback)global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.ICallback> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetFontSize (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/interface[@name='IWoyouService']/method[@name='setFontSize' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='woyou.aidlservice.jiuiv5.ICallback']]"
		[Register ("setFontSize", "(FLwoyou/aidlservice/jiuiv5/ICallback;)V", "GetSetFontSize_FLwoyou_aidlservice_jiuiv5_ICallback_Handler")]
		public abstract void SetFontSize (float p0, global::Woyou.Aidlservice.Jiuiv5.ICallback p1);

		static Delegate cb_tax_arrayBLwoyou_aidlservice_jiuiv5_ITax_;
#pragma warning disable 0169
		static Delegate GetTax_arrayBLwoyou_aidlservice_jiuiv5_ITax_Handler ()
		{
			if (cb_tax_arrayBLwoyou_aidlservice_jiuiv5_ITax_ == null)
				cb_tax_arrayBLwoyou_aidlservice_jiuiv5_ITax_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_Tax_arrayBLwoyou_aidlservice_jiuiv5_ITax_);
			return cb_tax_arrayBLwoyou_aidlservice_jiuiv5_ITax_;
		}

		static void n_Tax_arrayBLwoyou_aidlservice_jiuiv5_ITax_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.WoyouServiceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p1 = (global::Woyou.Aidlservice.Jiuiv5.ITax)global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.ITax> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Tax (p0, p1);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/interface[@name='IWoyouService']/method[@name='tax' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='woyou.aidlservice.jiuiv5.ITax']]"
		[Register ("tax", "([BLwoyou/aidlservice/jiuiv5/ITax;)V", "GetTax_arrayBLwoyou_aidlservice_jiuiv5_ITax_Handler")]
		public abstract void Tax (byte[] p0, global::Woyou.Aidlservice.Jiuiv5.ITax p1);

		static Delegate cb_updatePrinterState;
#pragma warning disable 0169
		static Delegate GetUpdatePrinterStateHandler ()
		{
			if (cb_updatePrinterState == null)
				cb_updatePrinterState = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_UpdatePrinterState);
			return cb_updatePrinterState;
		}

		static int n_UpdatePrinterState (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.WoyouServiceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.UpdatePrinterState ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/interface[@name='IWoyouService']/method[@name='updatePrinterState' and count(parameter)=0]"
		[Register ("updatePrinterState", "()I", "GetUpdatePrinterStateHandler")]
		public abstract int UpdatePrinterState ();

		static Delegate cb_getCutPaperTimes;
#pragma warning disable 0169
		static Delegate GetGetCutPaperTimesHandler ()
		{
			if (cb_getCutPaperTimes == null)
				cb_getCutPaperTimes = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetCutPaperTimes);
			return cb_getCutPaperTimes;
		}

		static int n_GetCutPaperTimes (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.WoyouServiceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CutPaperTimes;
		}
#pragma warning restore 0169

		public abstract int CutPaperTimes {
			// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/class[@name='IWoyouService.Stub']/method[@name='getCutPaperTimes' and count(parameter)=0]"
			[Register ("getCutPaperTimes", "()I", "GetGetCutPaperTimesHandler")]
			get; 
		}

		static Delegate cb_getDrawerStatus;
#pragma warning disable 0169
		static Delegate GetGetDrawerStatusHandler ()
		{
			if (cb_getDrawerStatus == null)
				cb_getDrawerStatus = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_GetDrawerStatus);
			return cb_getDrawerStatus;
		}

		static bool n_GetDrawerStatus (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.WoyouServiceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DrawerStatus;
		}
#pragma warning restore 0169

		public abstract bool DrawerStatus {
			// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/class[@name='IWoyouService.Stub']/method[@name='getDrawerStatus' and count(parameter)=0]"
			[Register ("getDrawerStatus", "()Z", "GetGetDrawerStatusHandler")]
			get; 
		}

		static Delegate cb_getFirmwareStatus;
#pragma warning disable 0169
		static Delegate GetGetFirmwareStatusHandler ()
		{
			if (cb_getFirmwareStatus == null)
				cb_getFirmwareStatus = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetFirmwareStatus);
			return cb_getFirmwareStatus;
		}

		static int n_GetFirmwareStatus (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.WoyouServiceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.FirmwareStatus;
		}
#pragma warning restore 0169

		public abstract int FirmwareStatus {
			// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/class[@name='IWoyouService.Stub']/method[@name='getFirmwareStatus' and count(parameter)=0]"
			[Register ("getFirmwareStatus", "()I", "GetGetFirmwareStatusHandler")]
			get; 
		}

		static Delegate cb_getOpenDrawerTimes;
#pragma warning disable 0169
		static Delegate GetGetOpenDrawerTimesHandler ()
		{
			if (cb_getOpenDrawerTimes == null)
				cb_getOpenDrawerTimes = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetOpenDrawerTimes);
			return cb_getOpenDrawerTimes;
		}

		static int n_GetOpenDrawerTimes (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.WoyouServiceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.OpenDrawerTimes;
		}
#pragma warning restore 0169

		public abstract int OpenDrawerTimes {
			// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/class[@name='IWoyouService.Stub']/method[@name='getOpenDrawerTimes' and count(parameter)=0]"
			[Register ("getOpenDrawerTimes", "()I", "GetGetOpenDrawerTimesHandler")]
			get; 
		}

		static Delegate cb_getPrintedLength;
#pragma warning disable 0169
		static Delegate GetGetPrintedLengthHandler ()
		{
			if (cb_getPrintedLength == null)
				cb_getPrintedLength = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetPrintedLength);
			return cb_getPrintedLength;
		}

		static int n_GetPrintedLength (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.WoyouServiceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PrintedLength;
		}
#pragma warning restore 0169

		public abstract int PrintedLength {
			// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/class[@name='IWoyouService.Stub']/method[@name='getPrintedLength' and count(parameter)=0]"
			[Register ("getPrintedLength", "()I", "GetGetPrintedLengthHandler")]
			get; 
		}

		static Delegate cb_getPrinterBBMDistance;
#pragma warning disable 0169
		static Delegate GetGetPrinterBBMDistanceHandler ()
		{
			if (cb_getPrinterBBMDistance == null)
				cb_getPrinterBBMDistance = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetPrinterBBMDistance);
			return cb_getPrinterBBMDistance;
		}

		static int n_GetPrinterBBMDistance (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.WoyouServiceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PrinterBBMDistance;
		}
#pragma warning restore 0169

		public abstract int PrinterBBMDistance {
			// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/class[@name='IWoyouService.Stub']/method[@name='getPrinterBBMDistance' and count(parameter)=0]"
			[Register ("getPrinterBBMDistance", "()I", "GetGetPrinterBBMDistanceHandler")]
			get; 
		}

		static Delegate cb_getPrinterModal;
#pragma warning disable 0169
		static Delegate GetGetPrinterModalHandler ()
		{
			if (cb_getPrinterModal == null)
				cb_getPrinterModal = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetPrinterModal);
			return cb_getPrinterModal;
		}

		static IntPtr n_GetPrinterModal (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.WoyouServiceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.PrinterModal);
		}
#pragma warning restore 0169

		public abstract string PrinterModal {
			// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/class[@name='IWoyouService.Stub']/method[@name='getPrinterModal' and count(parameter)=0]"
			[Register ("getPrinterModal", "()Ljava/lang/String;", "GetGetPrinterModalHandler")]
			get; 
		}

		static Delegate cb_getPrinterMode;
#pragma warning disable 0169
		static Delegate GetGetPrinterModeHandler ()
		{
			if (cb_getPrinterMode == null)
				cb_getPrinterMode = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetPrinterMode);
			return cb_getPrinterMode;
		}

		static int n_GetPrinterMode (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.WoyouServiceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PrinterMode;
		}
#pragma warning restore 0169

		public abstract int PrinterMode {
			// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/class[@name='IWoyouService.Stub']/method[@name='getPrinterMode' and count(parameter)=0]"
			[Register ("getPrinterMode", "()I", "GetGetPrinterModeHandler")]
			get; 
		}

		static Delegate cb_getPrinterSerialNo;
#pragma warning disable 0169
		static Delegate GetGetPrinterSerialNoHandler ()
		{
			if (cb_getPrinterSerialNo == null)
				cb_getPrinterSerialNo = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetPrinterSerialNo);
			return cb_getPrinterSerialNo;
		}

		static IntPtr n_GetPrinterSerialNo (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.WoyouServiceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.PrinterSerialNo);
		}
#pragma warning restore 0169

		public abstract string PrinterSerialNo {
			// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/class[@name='IWoyouService.Stub']/method[@name='getPrinterSerialNo' and count(parameter)=0]"
			[Register ("getPrinterSerialNo", "()Ljava/lang/String;", "GetGetPrinterSerialNoHandler")]
			get; 
		}

		static Delegate cb_getPrinterVersion;
#pragma warning disable 0169
		static Delegate GetGetPrinterVersionHandler ()
		{
			if (cb_getPrinterVersion == null)
				cb_getPrinterVersion = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetPrinterVersion);
			return cb_getPrinterVersion;
		}

		static IntPtr n_GetPrinterVersion (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.WoyouServiceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.PrinterVersion);
		}
#pragma warning restore 0169

		public abstract string PrinterVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/class[@name='IWoyouService.Stub']/method[@name='getPrinterVersion' and count(parameter)=0]"
			[Register ("getPrinterVersion", "()Ljava/lang/String;", "GetGetPrinterVersionHandler")]
			get; 
		}

		static Delegate cb_getServiceVersion;
#pragma warning disable 0169
		static Delegate GetGetServiceVersionHandler ()
		{
			if (cb_getServiceVersion == null)
				cb_getServiceVersion = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetServiceVersion);
			return cb_getServiceVersion;
		}

		static IntPtr n_GetServiceVersion (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.WoyouServiceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ServiceVersion);
		}
#pragma warning restore 0169

		public abstract string ServiceVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/class[@name='IWoyouService.Stub']/method[@name='getServiceVersion' and count(parameter)=0]"
			[Register ("getServiceVersion", "()Ljava/lang/String;", "GetGetServiceVersionHandler")]
			get; 
		}

	}

	[global::Android.Runtime.Register ("woyou/aidlservice/jiuiv5/IWoyouService$Stub", DoNotGenerateAcw=true)]
	internal partial class WoyouServiceStubInvoker : WoyouServiceStub {
		public WoyouServiceStubInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("woyou/aidlservice/jiuiv5/IWoyouService$Stub", typeof (WoyouServiceStubInvoker));

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		public override unsafe int CutPaperTimes {
			// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/class[@name='IWoyouService.Stub']/method[@name='getCutPaperTimes' and count(parameter)=0]"
			[Register ("getCutPaperTimes", "()I", "GetGetCutPaperTimesHandler")]
			get {
				const string __id = "getCutPaperTimes.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public override unsafe bool DrawerStatus {
			// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/class[@name='IWoyouService.Stub']/method[@name='getDrawerStatus' and count(parameter)=0]"
			[Register ("getDrawerStatus", "()Z", "GetGetDrawerStatusHandler")]
			get {
				const string __id = "getDrawerStatus.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public override unsafe int FirmwareStatus {
			// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/class[@name='IWoyouService.Stub']/method[@name='getFirmwareStatus' and count(parameter)=0]"
			[Register ("getFirmwareStatus", "()I", "GetGetFirmwareStatusHandler")]
			get {
				const string __id = "getFirmwareStatus.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public override unsafe int OpenDrawerTimes {
			// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/class[@name='IWoyouService.Stub']/method[@name='getOpenDrawerTimes' and count(parameter)=0]"
			[Register ("getOpenDrawerTimes", "()I", "GetGetOpenDrawerTimesHandler")]
			get {
				const string __id = "getOpenDrawerTimes.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public override unsafe int PrintedLength {
			// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/class[@name='IWoyouService.Stub']/method[@name='getPrintedLength' and count(parameter)=0]"
			[Register ("getPrintedLength", "()I", "GetGetPrintedLengthHandler")]
			get {
				const string __id = "getPrintedLength.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public override unsafe int PrinterBBMDistance {
			// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/class[@name='IWoyouService.Stub']/method[@name='getPrinterBBMDistance' and count(parameter)=0]"
			[Register ("getPrinterBBMDistance", "()I", "GetGetPrinterBBMDistanceHandler")]
			get {
				const string __id = "getPrinterBBMDistance.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public override unsafe string PrinterModal {
			// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/class[@name='IWoyouService.Stub']/method[@name='getPrinterModal' and count(parameter)=0]"
			[Register ("getPrinterModal", "()Ljava/lang/String;", "GetGetPrinterModalHandler")]
			get {
				const string __id = "getPrinterModal.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public override unsafe int PrinterMode {
			// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/class[@name='IWoyouService.Stub']/method[@name='getPrinterMode' and count(parameter)=0]"
			[Register ("getPrinterMode", "()I", "GetGetPrinterModeHandler")]
			get {
				const string __id = "getPrinterMode.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public override unsafe string PrinterSerialNo {
			// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/class[@name='IWoyouService.Stub']/method[@name='getPrinterSerialNo' and count(parameter)=0]"
			[Register ("getPrinterSerialNo", "()Ljava/lang/String;", "GetGetPrinterSerialNoHandler")]
			get {
				const string __id = "getPrinterSerialNo.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public override unsafe string PrinterVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/class[@name='IWoyouService.Stub']/method[@name='getPrinterVersion' and count(parameter)=0]"
			[Register ("getPrinterVersion", "()Ljava/lang/String;", "GetGetPrinterVersionHandler")]
			get {
				const string __id = "getPrinterVersion.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public override unsafe string ServiceVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/class[@name='IWoyouService.Stub']/method[@name='getServiceVersion' and count(parameter)=0]"
			[Register ("getServiceVersion", "()Ljava/lang/String;", "GetGetServiceVersionHandler")]
			get {
				const string __id = "getServiceVersion.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/interface[@name='IWoyouService']/method[@name='commitPrinterBuffer' and count(parameter)=0]"
		[Register ("commitPrinterBuffer", "()V", "GetCommitPrinterBufferHandler")]
		public override unsafe void CommitPrinterBuffer ()
		{
			const string __id = "commitPrinterBuffer.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/interface[@name='IWoyouService']/method[@name='commitPrinterBufferWithCallback' and count(parameter)=1 and parameter[1][@type='woyou.aidlservice.jiuiv5.ICallback']]"
		[Register ("commitPrinterBufferWithCallback", "(Lwoyou/aidlservice/jiuiv5/ICallback;)V", "GetCommitPrinterBufferWithCallback_Lwoyou_aidlservice_jiuiv5_ICallback_Handler")]
		public override unsafe void CommitPrinterBufferWithCallback (global::Woyou.Aidlservice.Jiuiv5.ICallback p0)
		{
			const string __id = "commitPrinterBufferWithCallback.(Lwoyou/aidlservice/jiuiv5/ICallback;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/interface[@name='IWoyouService']/method[@name='cutPaper' and count(parameter)=1 and parameter[1][@type='woyou.aidlservice.jiuiv5.ICallback']]"
		[Register ("cutPaper", "(Lwoyou/aidlservice/jiuiv5/ICallback;)V", "GetCutPaper_Lwoyou_aidlservice_jiuiv5_ICallback_Handler")]
		public override unsafe void CutPaper (global::Woyou.Aidlservice.Jiuiv5.ICallback p0)
		{
			const string __id = "cutPaper.(Lwoyou/aidlservice/jiuiv5/ICallback;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/interface[@name='IWoyouService']/method[@name='enterPrinterBuffer' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("enterPrinterBuffer", "(Z)V", "GetEnterPrinterBuffer_ZHandler")]
		public override unsafe void EnterPrinterBuffer (bool p0)
		{
			const string __id = "enterPrinterBuffer.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/interface[@name='IWoyouService']/method[@name='exitPrinterBuffer' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("exitPrinterBuffer", "(Z)V", "GetExitPrinterBuffer_ZHandler")]
		public override unsafe void ExitPrinterBuffer (bool p0)
		{
			const string __id = "exitPrinterBuffer.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/interface[@name='IWoyouService']/method[@name='exitPrinterBufferWithCallback' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='woyou.aidlservice.jiuiv5.ICallback']]"
		[Register ("exitPrinterBufferWithCallback", "(ZLwoyou/aidlservice/jiuiv5/ICallback;)V", "GetExitPrinterBufferWithCallback_ZLwoyou_aidlservice_jiuiv5_ICallback_Handler")]
		public override unsafe void ExitPrinterBufferWithCallback (bool p0, global::Woyou.Aidlservice.Jiuiv5.ICallback p1)
		{
			const string __id = "exitPrinterBufferWithCallback.(ZLwoyou/aidlservice/jiuiv5/ICallback;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/interface[@name='IWoyouService']/method[@name='lineWrap' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='woyou.aidlservice.jiuiv5.ICallback']]"
		[Register ("lineWrap", "(ILwoyou/aidlservice/jiuiv5/ICallback;)V", "GetLineWrap_ILwoyou_aidlservice_jiuiv5_ICallback_Handler")]
		public override unsafe void LineWrap (int p0, global::Woyou.Aidlservice.Jiuiv5.ICallback p1)
		{
			const string __id = "lineWrap.(ILwoyou/aidlservice/jiuiv5/ICallback;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/interface[@name='IWoyouService']/method[@name='openDrawer' and count(parameter)=1 and parameter[1][@type='woyou.aidlservice.jiuiv5.ICallback']]"
		[Register ("openDrawer", "(Lwoyou/aidlservice/jiuiv5/ICallback;)V", "GetOpenDrawer_Lwoyou_aidlservice_jiuiv5_ICallback_Handler")]
		public override unsafe void OpenDrawer (global::Woyou.Aidlservice.Jiuiv5.ICallback p0)
		{
			const string __id = "openDrawer.(Lwoyou/aidlservice/jiuiv5/ICallback;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/interface[@name='IWoyouService']/method[@name='postPrintData' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='byte[]'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("postPrintData", "(Ljava/lang/String;[BII)Z", "GetPostPrintData_Ljava_lang_String_arrayBIIHandler")]
		public override unsafe bool PostPrintData (string p0, byte[] p1, int p2, int p3)
		{
			const string __id = "postPrintData.(Ljava/lang/String;[BII)Z";
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue (p3);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				global::System.GC.KeepAlive (p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/interface[@name='IWoyouService']/method[@name='printBarCode' and count(parameter)=6 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='woyou.aidlservice.jiuiv5.ICallback']]"
		[Register ("printBarCode", "(Ljava/lang/String;IIIILwoyou/aidlservice/jiuiv5/ICallback;)V", "GetPrintBarCode_Ljava_lang_String_IIIILwoyou_aidlservice_jiuiv5_ICallback_Handler")]
		public override unsafe void PrintBarCode (string p0, int p1, int p2, int p3, int p4, global::Woyou.Aidlservice.Jiuiv5.ICallback p5)
		{
			const string __id = "printBarCode.(Ljava/lang/String;IIIILwoyou/aidlservice/jiuiv5/ICallback;)V";
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue (p3);
				__args [4] = new JniArgumentValue (p4);
				__args [5] = new JniArgumentValue ((p5 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p5).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				global::System.GC.KeepAlive (p5);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/interface[@name='IWoyouService']/method[@name='printBitmap' and count(parameter)=2 and parameter[1][@type='android.graphics.Bitmap'] and parameter[2][@type='woyou.aidlservice.jiuiv5.ICallback']]"
		[Register ("printBitmap", "(Landroid/graphics/Bitmap;Lwoyou/aidlservice/jiuiv5/ICallback;)V", "GetPrintBitmap_Landroid_graphics_Bitmap_Lwoyou_aidlservice_jiuiv5_ICallback_Handler")]
		public override unsafe void PrintBitmap (global::Android.Graphics.Bitmap p0, global::Woyou.Aidlservice.Jiuiv5.ICallback p1)
		{
			const string __id = "printBitmap.(Landroid/graphics/Bitmap;Lwoyou/aidlservice/jiuiv5/ICallback;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/interface[@name='IWoyouService']/method[@name='printBitmapCustom' and count(parameter)=3 and parameter[1][@type='android.graphics.Bitmap'] and parameter[2][@type='int'] and parameter[3][@type='woyou.aidlservice.jiuiv5.ICallback']]"
		[Register ("printBitmapCustom", "(Landroid/graphics/Bitmap;ILwoyou/aidlservice/jiuiv5/ICallback;)V", "GetPrintBitmapCustom_Landroid_graphics_Bitmap_ILwoyou_aidlservice_jiuiv5_ICallback_Handler")]
		public override unsafe void PrintBitmapCustom (global::Android.Graphics.Bitmap p0, int p1, global::Woyou.Aidlservice.Jiuiv5.ICallback p2)
		{
			const string __id = "printBitmapCustom.(Landroid/graphics/Bitmap;ILwoyou/aidlservice/jiuiv5/ICallback;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/interface[@name='IWoyouService']/method[@name='printColumnsString' and count(parameter)=4 and parameter[1][@type='java.lang.String[]'] and parameter[2][@type='int[]'] and parameter[3][@type='int[]'] and parameter[4][@type='woyou.aidlservice.jiuiv5.ICallback']]"
		[Register ("printColumnsString", "([Ljava/lang/String;[I[ILwoyou/aidlservice/jiuiv5/ICallback;)V", "GetPrintColumnsString_arrayLjava_lang_String_arrayIarrayILwoyou_aidlservice_jiuiv5_ICallback_Handler")]
		public override unsafe void PrintColumnsString (string[] p0, int[] p1, int[] p2, global::Woyou.Aidlservice.Jiuiv5.ICallback p3)
		{
			const string __id = "printColumnsString.([Ljava/lang/String;[I[ILwoyou/aidlservice/jiuiv5/ICallback;)V";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
				global::System.GC.KeepAlive (p2);
				global::System.GC.KeepAlive (p3);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/interface[@name='IWoyouService']/method[@name='printColumnsText' and count(parameter)=4 and parameter[1][@type='java.lang.String[]'] and parameter[2][@type='int[]'] and parameter[3][@type='int[]'] and parameter[4][@type='woyou.aidlservice.jiuiv5.ICallback']]"
		[Register ("printColumnsText", "([Ljava/lang/String;[I[ILwoyou/aidlservice/jiuiv5/ICallback;)V", "GetPrintColumnsText_arrayLjava_lang_String_arrayIarrayILwoyou_aidlservice_jiuiv5_ICallback_Handler")]
		public override unsafe void PrintColumnsText (string[] p0, int[] p1, int[] p2, global::Woyou.Aidlservice.Jiuiv5.ICallback p3)
		{
			const string __id = "printColumnsText.([Ljava/lang/String;[I[ILwoyou/aidlservice/jiuiv5/ICallback;)V";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
				global::System.GC.KeepAlive (p2);
				global::System.GC.KeepAlive (p3);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/interface[@name='IWoyouService']/method[@name='printOriginalText' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='woyou.aidlservice.jiuiv5.ICallback']]"
		[Register ("printOriginalText", "(Ljava/lang/String;Lwoyou/aidlservice/jiuiv5/ICallback;)V", "GetPrintOriginalText_Ljava_lang_String_Lwoyou_aidlservice_jiuiv5_ICallback_Handler")]
		public override unsafe void PrintOriginalText (string p0, global::Woyou.Aidlservice.Jiuiv5.ICallback p1)
		{
			const string __id = "printOriginalText.(Ljava/lang/String;Lwoyou/aidlservice/jiuiv5/ICallback;)V";
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/interface[@name='IWoyouService']/method[@name='printQRCode' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='woyou.aidlservice.jiuiv5.ICallback']]"
		[Register ("printQRCode", "(Ljava/lang/String;IILwoyou/aidlservice/jiuiv5/ICallback;)V", "GetPrintQRCode_Ljava_lang_String_IILwoyou_aidlservice_jiuiv5_ICallback_Handler")]
		public override unsafe void PrintQRCode (string p0, int p1, int p2, global::Woyou.Aidlservice.Jiuiv5.ICallback p3)
		{
			const string __id = "printQRCode.(Ljava/lang/String;IILwoyou/aidlservice/jiuiv5/ICallback;)V";
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				global::System.GC.KeepAlive (p3);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/interface[@name='IWoyouService']/method[@name='printText' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='woyou.aidlservice.jiuiv5.ICallback']]"
		[Register ("printText", "(Ljava/lang/String;Lwoyou/aidlservice/jiuiv5/ICallback;)V", "GetPrintText_Ljava_lang_String_Lwoyou_aidlservice_jiuiv5_ICallback_Handler")]
		public override unsafe void PrintText (string p0, global::Woyou.Aidlservice.Jiuiv5.ICallback p1)
		{
			const string __id = "printText.(Ljava/lang/String;Lwoyou/aidlservice/jiuiv5/ICallback;)V";
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/interface[@name='IWoyouService']/method[@name='printTextWithFont' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='float'] and parameter[4][@type='woyou.aidlservice.jiuiv5.ICallback']]"
		[Register ("printTextWithFont", "(Ljava/lang/String;Ljava/lang/String;FLwoyou/aidlservice/jiuiv5/ICallback;)V", "GetPrintTextWithFont_Ljava_lang_String_Ljava_lang_String_FLwoyou_aidlservice_jiuiv5_ICallback_Handler")]
		public override unsafe void PrintTextWithFont (string p0, string p1, float p2, global::Woyou.Aidlservice.Jiuiv5.ICallback p3)
		{
			const string __id = "printTextWithFont.(Ljava/lang/String;Ljava/lang/String;FLwoyou/aidlservice/jiuiv5/ICallback;)V";
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			IntPtr native_p1 = JNIEnv.NewString ((string)p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				global::System.GC.KeepAlive (p3);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/interface[@name='IWoyouService']/method[@name='printerInit' and count(parameter)=1 and parameter[1][@type='woyou.aidlservice.jiuiv5.ICallback']]"
		[Register ("printerInit", "(Lwoyou/aidlservice/jiuiv5/ICallback;)V", "GetPrinterInit_Lwoyou_aidlservice_jiuiv5_ICallback_Handler")]
		public override unsafe void PrinterInit (global::Woyou.Aidlservice.Jiuiv5.ICallback p0)
		{
			const string __id = "printerInit.(Lwoyou/aidlservice/jiuiv5/ICallback;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/interface[@name='IWoyouService']/method[@name='printerSelfChecking' and count(parameter)=1 and parameter[1][@type='woyou.aidlservice.jiuiv5.ICallback']]"
		[Register ("printerSelfChecking", "(Lwoyou/aidlservice/jiuiv5/ICallback;)V", "GetPrinterSelfChecking_Lwoyou_aidlservice_jiuiv5_ICallback_Handler")]
		public override unsafe void PrinterSelfChecking (global::Woyou.Aidlservice.Jiuiv5.ICallback p0)
		{
			const string __id = "printerSelfChecking.(Lwoyou/aidlservice/jiuiv5/ICallback;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/interface[@name='IWoyouService']/method[@name='sendLCDBitmap' and count(parameter)=2 and parameter[1][@type='android.graphics.Bitmap'] and parameter[2][@type='woyou.aidlservice.jiuiv5.ILcdCallback']]"
		[Register ("sendLCDBitmap", "(Landroid/graphics/Bitmap;Lwoyou/aidlservice/jiuiv5/ILcdCallback;)V", "GetSendLCDBitmap_Landroid_graphics_Bitmap_Lwoyou_aidlservice_jiuiv5_ILcdCallback_Handler")]
		public override unsafe void SendLCDBitmap (global::Android.Graphics.Bitmap p0, global::Woyou.Aidlservice.Jiuiv5.ILcdCallback p1)
		{
			const string __id = "sendLCDBitmap.(Landroid/graphics/Bitmap;Lwoyou/aidlservice/jiuiv5/ILcdCallback;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/interface[@name='IWoyouService']/method[@name='sendLCDCommand' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("sendLCDCommand", "(I)V", "GetSendLCDCommand_IHandler")]
		public override unsafe void SendLCDCommand (int p0)
		{
			const string __id = "sendLCDCommand.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/interface[@name='IWoyouService']/method[@name='sendLCDDoubleString' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='woyou.aidlservice.jiuiv5.ILcdCallback']]"
		[Register ("sendLCDDoubleString", "(Ljava/lang/String;Ljava/lang/String;Lwoyou/aidlservice/jiuiv5/ILcdCallback;)V", "GetSendLCDDoubleString_Ljava_lang_String_Ljava_lang_String_Lwoyou_aidlservice_jiuiv5_ILcdCallback_Handler")]
		public override unsafe void SendLCDDoubleString (string p0, string p1, global::Woyou.Aidlservice.Jiuiv5.ILcdCallback p2)
		{
			const string __id = "sendLCDDoubleString.(Ljava/lang/String;Ljava/lang/String;Lwoyou/aidlservice/jiuiv5/ILcdCallback;)V";
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			IntPtr native_p1 = JNIEnv.NewString ((string)p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				global::System.GC.KeepAlive (p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/interface[@name='IWoyouService']/method[@name='sendLCDFillString' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='boolean'] and parameter[4][@type='woyou.aidlservice.jiuiv5.ILcdCallback']]"
		[Register ("sendLCDFillString", "(Ljava/lang/String;IZLwoyou/aidlservice/jiuiv5/ILcdCallback;)V", "GetSendLCDFillString_Ljava_lang_String_IZLwoyou_aidlservice_jiuiv5_ILcdCallback_Handler")]
		public override unsafe void SendLCDFillString (string p0, int p1, bool p2, global::Woyou.Aidlservice.Jiuiv5.ILcdCallback p3)
		{
			const string __id = "sendLCDFillString.(Ljava/lang/String;IZLwoyou/aidlservice/jiuiv5/ILcdCallback;)V";
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				global::System.GC.KeepAlive (p3);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/interface[@name='IWoyouService']/method[@name='sendLCDMultiString' and count(parameter)=3 and parameter[1][@type='java.lang.String[]'] and parameter[2][@type='int[]'] and parameter[3][@type='woyou.aidlservice.jiuiv5.ILcdCallback']]"
		[Register ("sendLCDMultiString", "([Ljava/lang/String;[ILwoyou/aidlservice/jiuiv5/ILcdCallback;)V", "GetSendLCDMultiString_arrayLjava_lang_String_arrayILwoyou_aidlservice_jiuiv5_ILcdCallback_Handler")]
		public override unsafe void SendLCDMultiString (string[] p0, int[] p1, global::Woyou.Aidlservice.Jiuiv5.ILcdCallback p2)
		{
			const string __id = "sendLCDMultiString.([Ljava/lang/String;[ILwoyou/aidlservice/jiuiv5/ILcdCallback;)V";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
				global::System.GC.KeepAlive (p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/interface[@name='IWoyouService']/method[@name='sendLCDString' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='woyou.aidlservice.jiuiv5.ILcdCallback']]"
		[Register ("sendLCDString", "(Ljava/lang/String;Lwoyou/aidlservice/jiuiv5/ILcdCallback;)V", "GetSendLCDString_Ljava_lang_String_Lwoyou_aidlservice_jiuiv5_ILcdCallback_Handler")]
		public override unsafe void SendLCDString (string p0, global::Woyou.Aidlservice.Jiuiv5.ILcdCallback p1)
		{
			const string __id = "sendLCDString.(Ljava/lang/String;Lwoyou/aidlservice/jiuiv5/ILcdCallback;)V";
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/interface[@name='IWoyouService']/method[@name='sendRAWData' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='woyou.aidlservice.jiuiv5.ICallback']]"
		[Register ("sendRAWData", "([BLwoyou/aidlservice/jiuiv5/ICallback;)V", "GetSendRAWData_arrayBLwoyou_aidlservice_jiuiv5_ICallback_Handler")]
		public override unsafe void SendRAWData (byte[] p0, global::Woyou.Aidlservice.Jiuiv5.ICallback p1)
		{
			const string __id = "sendRAWData.([BLwoyou/aidlservice/jiuiv5/ICallback;)V";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/interface[@name='IWoyouService']/method[@name='setAlignment' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='woyou.aidlservice.jiuiv5.ICallback']]"
		[Register ("setAlignment", "(ILwoyou/aidlservice/jiuiv5/ICallback;)V", "GetSetAlignment_ILwoyou_aidlservice_jiuiv5_ICallback_Handler")]
		public override unsafe void SetAlignment (int p0, global::Woyou.Aidlservice.Jiuiv5.ICallback p1)
		{
			const string __id = "setAlignment.(ILwoyou/aidlservice/jiuiv5/ICallback;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/interface[@name='IWoyouService']/method[@name='setFontName' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='woyou.aidlservice.jiuiv5.ICallback']]"
		[Register ("setFontName", "(Ljava/lang/String;Lwoyou/aidlservice/jiuiv5/ICallback;)V", "GetSetFontName_Ljava_lang_String_Lwoyou_aidlservice_jiuiv5_ICallback_Handler")]
		public override unsafe void SetFontName (string p0, global::Woyou.Aidlservice.Jiuiv5.ICallback p1)
		{
			const string __id = "setFontName.(Ljava/lang/String;Lwoyou/aidlservice/jiuiv5/ICallback;)V";
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/interface[@name='IWoyouService']/method[@name='setFontSize' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='woyou.aidlservice.jiuiv5.ICallback']]"
		[Register ("setFontSize", "(FLwoyou/aidlservice/jiuiv5/ICallback;)V", "GetSetFontSize_FLwoyou_aidlservice_jiuiv5_ICallback_Handler")]
		public override unsafe void SetFontSize (float p0, global::Woyou.Aidlservice.Jiuiv5.ICallback p1)
		{
			const string __id = "setFontSize.(FLwoyou/aidlservice/jiuiv5/ICallback;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/interface[@name='IWoyouService']/method[@name='tax' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='woyou.aidlservice.jiuiv5.ITax']]"
		[Register ("tax", "([BLwoyou/aidlservice/jiuiv5/ITax;)V", "GetTax_arrayBLwoyou_aidlservice_jiuiv5_ITax_Handler")]
		public override unsafe void Tax (byte[] p0, global::Woyou.Aidlservice.Jiuiv5.ITax p1)
		{
			const string __id = "tax.([BLwoyou/aidlservice/jiuiv5/ITax;)V";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/interface[@name='IWoyouService']/method[@name='updatePrinterState' and count(parameter)=0]"
		[Register ("updatePrinterState", "()I", "GetUpdatePrinterStateHandler")]
		public override unsafe int UpdatePrinterState ()
		{
			const string __id = "updatePrinterState.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/interface[@name='IWoyouService']"
	[Register ("woyou/aidlservice/jiuiv5/IWoyouService", "", "Woyou.Aidlservice.Jiuiv5.IWoyouServiceInvoker")]
	public partial interface IWoyouService : global::Android.OS.IInterface {
		int CutPaperTimes {
			// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/interface[@name='IWoyouService']/method[@name='getCutPaperTimes' and count(parameter)=0]"
			[Register ("getCutPaperTimes", "()I", "GetGetCutPaperTimesHandler:Woyou.Aidlservice.Jiuiv5.IWoyouServiceInvoker, Binding")]
			get; 
		}

		bool DrawerStatus {
			// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/interface[@name='IWoyouService']/method[@name='getDrawerStatus' and count(parameter)=0]"
			[Register ("getDrawerStatus", "()Z", "GetGetDrawerStatusHandler:Woyou.Aidlservice.Jiuiv5.IWoyouServiceInvoker, Binding")]
			get; 
		}

		int FirmwareStatus {
			// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/interface[@name='IWoyouService']/method[@name='getFirmwareStatus' and count(parameter)=0]"
			[Register ("getFirmwareStatus", "()I", "GetGetFirmwareStatusHandler:Woyou.Aidlservice.Jiuiv5.IWoyouServiceInvoker, Binding")]
			get; 
		}

		int OpenDrawerTimes {
			// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/interface[@name='IWoyouService']/method[@name='getOpenDrawerTimes' and count(parameter)=0]"
			[Register ("getOpenDrawerTimes", "()I", "GetGetOpenDrawerTimesHandler:Woyou.Aidlservice.Jiuiv5.IWoyouServiceInvoker, Binding")]
			get; 
		}

		int PrintedLength {
			// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/interface[@name='IWoyouService']/method[@name='getPrintedLength' and count(parameter)=0]"
			[Register ("getPrintedLength", "()I", "GetGetPrintedLengthHandler:Woyou.Aidlservice.Jiuiv5.IWoyouServiceInvoker, Binding")]
			get; 
		}

		int PrinterBBMDistance {
			// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/interface[@name='IWoyouService']/method[@name='getPrinterBBMDistance' and count(parameter)=0]"
			[Register ("getPrinterBBMDistance", "()I", "GetGetPrinterBBMDistanceHandler:Woyou.Aidlservice.Jiuiv5.IWoyouServiceInvoker, Binding")]
			get; 
		}

		string PrinterModal {
			// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/interface[@name='IWoyouService']/method[@name='getPrinterModal' and count(parameter)=0]"
			[Register ("getPrinterModal", "()Ljava/lang/String;", "GetGetPrinterModalHandler:Woyou.Aidlservice.Jiuiv5.IWoyouServiceInvoker, Binding")]
			get; 
		}

		int PrinterMode {
			// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/interface[@name='IWoyouService']/method[@name='getPrinterMode' and count(parameter)=0]"
			[Register ("getPrinterMode", "()I", "GetGetPrinterModeHandler:Woyou.Aidlservice.Jiuiv5.IWoyouServiceInvoker, Binding")]
			get; 
		}

		string PrinterSerialNo {
			// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/interface[@name='IWoyouService']/method[@name='getPrinterSerialNo' and count(parameter)=0]"
			[Register ("getPrinterSerialNo", "()Ljava/lang/String;", "GetGetPrinterSerialNoHandler:Woyou.Aidlservice.Jiuiv5.IWoyouServiceInvoker, Binding")]
			get; 
		}

		string PrinterVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/interface[@name='IWoyouService']/method[@name='getPrinterVersion' and count(parameter)=0]"
			[Register ("getPrinterVersion", "()Ljava/lang/String;", "GetGetPrinterVersionHandler:Woyou.Aidlservice.Jiuiv5.IWoyouServiceInvoker, Binding")]
			get; 
		}

		string ServiceVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/interface[@name='IWoyouService']/method[@name='getServiceVersion' and count(parameter)=0]"
			[Register ("getServiceVersion", "()Ljava/lang/String;", "GetGetServiceVersionHandler:Woyou.Aidlservice.Jiuiv5.IWoyouServiceInvoker, Binding")]
			get; 
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/interface[@name='IWoyouService']/method[@name='commitPrinterBuffer' and count(parameter)=0]"
		[Register ("commitPrinterBuffer", "()V", "GetCommitPrinterBufferHandler:Woyou.Aidlservice.Jiuiv5.IWoyouServiceInvoker, Binding")]
		void CommitPrinterBuffer ();

		// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/interface[@name='IWoyouService']/method[@name='commitPrinterBufferWithCallback' and count(parameter)=1 and parameter[1][@type='woyou.aidlservice.jiuiv5.ICallback']]"
		[Register ("commitPrinterBufferWithCallback", "(Lwoyou/aidlservice/jiuiv5/ICallback;)V", "GetCommitPrinterBufferWithCallback_Lwoyou_aidlservice_jiuiv5_ICallback_Handler:Woyou.Aidlservice.Jiuiv5.IWoyouServiceInvoker, Binding")]
		void CommitPrinterBufferWithCallback (global::Woyou.Aidlservice.Jiuiv5.ICallback p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/interface[@name='IWoyouService']/method[@name='cutPaper' and count(parameter)=1 and parameter[1][@type='woyou.aidlservice.jiuiv5.ICallback']]"
		[Register ("cutPaper", "(Lwoyou/aidlservice/jiuiv5/ICallback;)V", "GetCutPaper_Lwoyou_aidlservice_jiuiv5_ICallback_Handler:Woyou.Aidlservice.Jiuiv5.IWoyouServiceInvoker, Binding")]
		void CutPaper (global::Woyou.Aidlservice.Jiuiv5.ICallback p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/interface[@name='IWoyouService']/method[@name='enterPrinterBuffer' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("enterPrinterBuffer", "(Z)V", "GetEnterPrinterBuffer_ZHandler:Woyou.Aidlservice.Jiuiv5.IWoyouServiceInvoker, Binding")]
		void EnterPrinterBuffer (bool p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/interface[@name='IWoyouService']/method[@name='exitPrinterBuffer' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("exitPrinterBuffer", "(Z)V", "GetExitPrinterBuffer_ZHandler:Woyou.Aidlservice.Jiuiv5.IWoyouServiceInvoker, Binding")]
		void ExitPrinterBuffer (bool p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/interface[@name='IWoyouService']/method[@name='exitPrinterBufferWithCallback' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='woyou.aidlservice.jiuiv5.ICallback']]"
		[Register ("exitPrinterBufferWithCallback", "(ZLwoyou/aidlservice/jiuiv5/ICallback;)V", "GetExitPrinterBufferWithCallback_ZLwoyou_aidlservice_jiuiv5_ICallback_Handler:Woyou.Aidlservice.Jiuiv5.IWoyouServiceInvoker, Binding")]
		void ExitPrinterBufferWithCallback (bool p0, global::Woyou.Aidlservice.Jiuiv5.ICallback p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/interface[@name='IWoyouService']/method[@name='lineWrap' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='woyou.aidlservice.jiuiv5.ICallback']]"
		[Register ("lineWrap", "(ILwoyou/aidlservice/jiuiv5/ICallback;)V", "GetLineWrap_ILwoyou_aidlservice_jiuiv5_ICallback_Handler:Woyou.Aidlservice.Jiuiv5.IWoyouServiceInvoker, Binding")]
		void LineWrap (int p0, global::Woyou.Aidlservice.Jiuiv5.ICallback p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/interface[@name='IWoyouService']/method[@name='openDrawer' and count(parameter)=1 and parameter[1][@type='woyou.aidlservice.jiuiv5.ICallback']]"
		[Register ("openDrawer", "(Lwoyou/aidlservice/jiuiv5/ICallback;)V", "GetOpenDrawer_Lwoyou_aidlservice_jiuiv5_ICallback_Handler:Woyou.Aidlservice.Jiuiv5.IWoyouServiceInvoker, Binding")]
		void OpenDrawer (global::Woyou.Aidlservice.Jiuiv5.ICallback p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/interface[@name='IWoyouService']/method[@name='postPrintData' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='byte[]'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("postPrintData", "(Ljava/lang/String;[BII)Z", "GetPostPrintData_Ljava_lang_String_arrayBIIHandler:Woyou.Aidlservice.Jiuiv5.IWoyouServiceInvoker, Binding")]
		bool PostPrintData (string p0, byte[] p1, int p2, int p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/interface[@name='IWoyouService']/method[@name='printBarCode' and count(parameter)=6 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='woyou.aidlservice.jiuiv5.ICallback']]"
		[Register ("printBarCode", "(Ljava/lang/String;IIIILwoyou/aidlservice/jiuiv5/ICallback;)V", "GetPrintBarCode_Ljava_lang_String_IIIILwoyou_aidlservice_jiuiv5_ICallback_Handler:Woyou.Aidlservice.Jiuiv5.IWoyouServiceInvoker, Binding")]
		void PrintBarCode (string p0, int p1, int p2, int p3, int p4, global::Woyou.Aidlservice.Jiuiv5.ICallback p5);

		// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/interface[@name='IWoyouService']/method[@name='printBitmap' and count(parameter)=2 and parameter[1][@type='android.graphics.Bitmap'] and parameter[2][@type='woyou.aidlservice.jiuiv5.ICallback']]"
		[Register ("printBitmap", "(Landroid/graphics/Bitmap;Lwoyou/aidlservice/jiuiv5/ICallback;)V", "GetPrintBitmap_Landroid_graphics_Bitmap_Lwoyou_aidlservice_jiuiv5_ICallback_Handler:Woyou.Aidlservice.Jiuiv5.IWoyouServiceInvoker, Binding")]
		void PrintBitmap (global::Android.Graphics.Bitmap p0, global::Woyou.Aidlservice.Jiuiv5.ICallback p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/interface[@name='IWoyouService']/method[@name='printBitmapCustom' and count(parameter)=3 and parameter[1][@type='android.graphics.Bitmap'] and parameter[2][@type='int'] and parameter[3][@type='woyou.aidlservice.jiuiv5.ICallback']]"
		[Register ("printBitmapCustom", "(Landroid/graphics/Bitmap;ILwoyou/aidlservice/jiuiv5/ICallback;)V", "GetPrintBitmapCustom_Landroid_graphics_Bitmap_ILwoyou_aidlservice_jiuiv5_ICallback_Handler:Woyou.Aidlservice.Jiuiv5.IWoyouServiceInvoker, Binding")]
		void PrintBitmapCustom (global::Android.Graphics.Bitmap p0, int p1, global::Woyou.Aidlservice.Jiuiv5.ICallback p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/interface[@name='IWoyouService']/method[@name='printColumnsString' and count(parameter)=4 and parameter[1][@type='java.lang.String[]'] and parameter[2][@type='int[]'] and parameter[3][@type='int[]'] and parameter[4][@type='woyou.aidlservice.jiuiv5.ICallback']]"
		[Register ("printColumnsString", "([Ljava/lang/String;[I[ILwoyou/aidlservice/jiuiv5/ICallback;)V", "GetPrintColumnsString_arrayLjava_lang_String_arrayIarrayILwoyou_aidlservice_jiuiv5_ICallback_Handler:Woyou.Aidlservice.Jiuiv5.IWoyouServiceInvoker, Binding")]
		void PrintColumnsString (string[] p0, int[] p1, int[] p2, global::Woyou.Aidlservice.Jiuiv5.ICallback p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/interface[@name='IWoyouService']/method[@name='printColumnsText' and count(parameter)=4 and parameter[1][@type='java.lang.String[]'] and parameter[2][@type='int[]'] and parameter[3][@type='int[]'] and parameter[4][@type='woyou.aidlservice.jiuiv5.ICallback']]"
		[Register ("printColumnsText", "([Ljava/lang/String;[I[ILwoyou/aidlservice/jiuiv5/ICallback;)V", "GetPrintColumnsText_arrayLjava_lang_String_arrayIarrayILwoyou_aidlservice_jiuiv5_ICallback_Handler:Woyou.Aidlservice.Jiuiv5.IWoyouServiceInvoker, Binding")]
		void PrintColumnsText (string[] p0, int[] p1, int[] p2, global::Woyou.Aidlservice.Jiuiv5.ICallback p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/interface[@name='IWoyouService']/method[@name='printOriginalText' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='woyou.aidlservice.jiuiv5.ICallback']]"
		[Register ("printOriginalText", "(Ljava/lang/String;Lwoyou/aidlservice/jiuiv5/ICallback;)V", "GetPrintOriginalText_Ljava_lang_String_Lwoyou_aidlservice_jiuiv5_ICallback_Handler:Woyou.Aidlservice.Jiuiv5.IWoyouServiceInvoker, Binding")]
		void PrintOriginalText (string p0, global::Woyou.Aidlservice.Jiuiv5.ICallback p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/interface[@name='IWoyouService']/method[@name='printQRCode' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='woyou.aidlservice.jiuiv5.ICallback']]"
		[Register ("printQRCode", "(Ljava/lang/String;IILwoyou/aidlservice/jiuiv5/ICallback;)V", "GetPrintQRCode_Ljava_lang_String_IILwoyou_aidlservice_jiuiv5_ICallback_Handler:Woyou.Aidlservice.Jiuiv5.IWoyouServiceInvoker, Binding")]
		void PrintQRCode (string p0, int p1, int p2, global::Woyou.Aidlservice.Jiuiv5.ICallback p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/interface[@name='IWoyouService']/method[@name='printText' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='woyou.aidlservice.jiuiv5.ICallback']]"
		[Register ("printText", "(Ljava/lang/String;Lwoyou/aidlservice/jiuiv5/ICallback;)V", "GetPrintText_Ljava_lang_String_Lwoyou_aidlservice_jiuiv5_ICallback_Handler:Woyou.Aidlservice.Jiuiv5.IWoyouServiceInvoker, Binding")]
		void PrintText (string p0, global::Woyou.Aidlservice.Jiuiv5.ICallback p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/interface[@name='IWoyouService']/method[@name='printTextWithFont' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='float'] and parameter[4][@type='woyou.aidlservice.jiuiv5.ICallback']]"
		[Register ("printTextWithFont", "(Ljava/lang/String;Ljava/lang/String;FLwoyou/aidlservice/jiuiv5/ICallback;)V", "GetPrintTextWithFont_Ljava_lang_String_Ljava_lang_String_FLwoyou_aidlservice_jiuiv5_ICallback_Handler:Woyou.Aidlservice.Jiuiv5.IWoyouServiceInvoker, Binding")]
		void PrintTextWithFont (string p0, string p1, float p2, global::Woyou.Aidlservice.Jiuiv5.ICallback p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/interface[@name='IWoyouService']/method[@name='printerInit' and count(parameter)=1 and parameter[1][@type='woyou.aidlservice.jiuiv5.ICallback']]"
		[Register ("printerInit", "(Lwoyou/aidlservice/jiuiv5/ICallback;)V", "GetPrinterInit_Lwoyou_aidlservice_jiuiv5_ICallback_Handler:Woyou.Aidlservice.Jiuiv5.IWoyouServiceInvoker, Binding")]
		void PrinterInit (global::Woyou.Aidlservice.Jiuiv5.ICallback p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/interface[@name='IWoyouService']/method[@name='printerSelfChecking' and count(parameter)=1 and parameter[1][@type='woyou.aidlservice.jiuiv5.ICallback']]"
		[Register ("printerSelfChecking", "(Lwoyou/aidlservice/jiuiv5/ICallback;)V", "GetPrinterSelfChecking_Lwoyou_aidlservice_jiuiv5_ICallback_Handler:Woyou.Aidlservice.Jiuiv5.IWoyouServiceInvoker, Binding")]
		void PrinterSelfChecking (global::Woyou.Aidlservice.Jiuiv5.ICallback p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/interface[@name='IWoyouService']/method[@name='sendLCDBitmap' and count(parameter)=2 and parameter[1][@type='android.graphics.Bitmap'] and parameter[2][@type='woyou.aidlservice.jiuiv5.ILcdCallback']]"
		[Register ("sendLCDBitmap", "(Landroid/graphics/Bitmap;Lwoyou/aidlservice/jiuiv5/ILcdCallback;)V", "GetSendLCDBitmap_Landroid_graphics_Bitmap_Lwoyou_aidlservice_jiuiv5_ILcdCallback_Handler:Woyou.Aidlservice.Jiuiv5.IWoyouServiceInvoker, Binding")]
		void SendLCDBitmap (global::Android.Graphics.Bitmap p0, global::Woyou.Aidlservice.Jiuiv5.ILcdCallback p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/interface[@name='IWoyouService']/method[@name='sendLCDCommand' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("sendLCDCommand", "(I)V", "GetSendLCDCommand_IHandler:Woyou.Aidlservice.Jiuiv5.IWoyouServiceInvoker, Binding")]
		void SendLCDCommand (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/interface[@name='IWoyouService']/method[@name='sendLCDDoubleString' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='woyou.aidlservice.jiuiv5.ILcdCallback']]"
		[Register ("sendLCDDoubleString", "(Ljava/lang/String;Ljava/lang/String;Lwoyou/aidlservice/jiuiv5/ILcdCallback;)V", "GetSendLCDDoubleString_Ljava_lang_String_Ljava_lang_String_Lwoyou_aidlservice_jiuiv5_ILcdCallback_Handler:Woyou.Aidlservice.Jiuiv5.IWoyouServiceInvoker, Binding")]
		void SendLCDDoubleString (string p0, string p1, global::Woyou.Aidlservice.Jiuiv5.ILcdCallback p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/interface[@name='IWoyouService']/method[@name='sendLCDFillString' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='boolean'] and parameter[4][@type='woyou.aidlservice.jiuiv5.ILcdCallback']]"
		[Register ("sendLCDFillString", "(Ljava/lang/String;IZLwoyou/aidlservice/jiuiv5/ILcdCallback;)V", "GetSendLCDFillString_Ljava_lang_String_IZLwoyou_aidlservice_jiuiv5_ILcdCallback_Handler:Woyou.Aidlservice.Jiuiv5.IWoyouServiceInvoker, Binding")]
		void SendLCDFillString (string p0, int p1, bool p2, global::Woyou.Aidlservice.Jiuiv5.ILcdCallback p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/interface[@name='IWoyouService']/method[@name='sendLCDMultiString' and count(parameter)=3 and parameter[1][@type='java.lang.String[]'] and parameter[2][@type='int[]'] and parameter[3][@type='woyou.aidlservice.jiuiv5.ILcdCallback']]"
		[Register ("sendLCDMultiString", "([Ljava/lang/String;[ILwoyou/aidlservice/jiuiv5/ILcdCallback;)V", "GetSendLCDMultiString_arrayLjava_lang_String_arrayILwoyou_aidlservice_jiuiv5_ILcdCallback_Handler:Woyou.Aidlservice.Jiuiv5.IWoyouServiceInvoker, Binding")]
		void SendLCDMultiString (string[] p0, int[] p1, global::Woyou.Aidlservice.Jiuiv5.ILcdCallback p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/interface[@name='IWoyouService']/method[@name='sendLCDString' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='woyou.aidlservice.jiuiv5.ILcdCallback']]"
		[Register ("sendLCDString", "(Ljava/lang/String;Lwoyou/aidlservice/jiuiv5/ILcdCallback;)V", "GetSendLCDString_Ljava_lang_String_Lwoyou_aidlservice_jiuiv5_ILcdCallback_Handler:Woyou.Aidlservice.Jiuiv5.IWoyouServiceInvoker, Binding")]
		void SendLCDString (string p0, global::Woyou.Aidlservice.Jiuiv5.ILcdCallback p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/interface[@name='IWoyouService']/method[@name='sendRAWData' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='woyou.aidlservice.jiuiv5.ICallback']]"
		[Register ("sendRAWData", "([BLwoyou/aidlservice/jiuiv5/ICallback;)V", "GetSendRAWData_arrayBLwoyou_aidlservice_jiuiv5_ICallback_Handler:Woyou.Aidlservice.Jiuiv5.IWoyouServiceInvoker, Binding")]
		void SendRAWData (byte[] p0, global::Woyou.Aidlservice.Jiuiv5.ICallback p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/interface[@name='IWoyouService']/method[@name='setAlignment' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='woyou.aidlservice.jiuiv5.ICallback']]"
		[Register ("setAlignment", "(ILwoyou/aidlservice/jiuiv5/ICallback;)V", "GetSetAlignment_ILwoyou_aidlservice_jiuiv5_ICallback_Handler:Woyou.Aidlservice.Jiuiv5.IWoyouServiceInvoker, Binding")]
		void SetAlignment (int p0, global::Woyou.Aidlservice.Jiuiv5.ICallback p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/interface[@name='IWoyouService']/method[@name='setFontName' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='woyou.aidlservice.jiuiv5.ICallback']]"
		[Register ("setFontName", "(Ljava/lang/String;Lwoyou/aidlservice/jiuiv5/ICallback;)V", "GetSetFontName_Ljava_lang_String_Lwoyou_aidlservice_jiuiv5_ICallback_Handler:Woyou.Aidlservice.Jiuiv5.IWoyouServiceInvoker, Binding")]
		void SetFontName (string p0, global::Woyou.Aidlservice.Jiuiv5.ICallback p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/interface[@name='IWoyouService']/method[@name='setFontSize' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='woyou.aidlservice.jiuiv5.ICallback']]"
		[Register ("setFontSize", "(FLwoyou/aidlservice/jiuiv5/ICallback;)V", "GetSetFontSize_FLwoyou_aidlservice_jiuiv5_ICallback_Handler:Woyou.Aidlservice.Jiuiv5.IWoyouServiceInvoker, Binding")]
		void SetFontSize (float p0, global::Woyou.Aidlservice.Jiuiv5.ICallback p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/interface[@name='IWoyouService']/method[@name='tax' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='woyou.aidlservice.jiuiv5.ITax']]"
		[Register ("tax", "([BLwoyou/aidlservice/jiuiv5/ITax;)V", "GetTax_arrayBLwoyou_aidlservice_jiuiv5_ITax_Handler:Woyou.Aidlservice.Jiuiv5.IWoyouServiceInvoker, Binding")]
		void Tax (byte[] p0, global::Woyou.Aidlservice.Jiuiv5.ITax p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='woyou.aidlservice.jiuiv5']/interface[@name='IWoyouService']/method[@name='updatePrinterState' and count(parameter)=0]"
		[Register ("updatePrinterState", "()I", "GetUpdatePrinterStateHandler:Woyou.Aidlservice.Jiuiv5.IWoyouServiceInvoker, Binding")]
		int UpdatePrinterState ();

	}

	[global::Android.Runtime.Register ("woyou/aidlservice/jiuiv5/IWoyouService", DoNotGenerateAcw=true)]
	internal partial class IWoyouServiceInvoker : global::Java.Lang.Object, IWoyouService {
		static readonly JniPeerMembers _members = new XAPeerMembers ("woyou/aidlservice/jiuiv5/IWoyouService", typeof (IWoyouServiceInvoker));

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

		public static IWoyouService GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IWoyouService> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'woyou.aidlservice.jiuiv5.IWoyouService'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IWoyouServiceInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getCutPaperTimes;
#pragma warning disable 0169
		static Delegate GetGetCutPaperTimesHandler ()
		{
			if (cb_getCutPaperTimes == null)
				cb_getCutPaperTimes = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetCutPaperTimes);
			return cb_getCutPaperTimes;
		}

		static int n_GetCutPaperTimes (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.IWoyouService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CutPaperTimes;
		}
#pragma warning restore 0169

		IntPtr id_getCutPaperTimes;
		public unsafe int CutPaperTimes {
			get {
				if (id_getCutPaperTimes == IntPtr.Zero)
					id_getCutPaperTimes = JNIEnv.GetMethodID (class_ref, "getCutPaperTimes", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getCutPaperTimes);
			}
		}

		static Delegate cb_getDrawerStatus;
#pragma warning disable 0169
		static Delegate GetGetDrawerStatusHandler ()
		{
			if (cb_getDrawerStatus == null)
				cb_getDrawerStatus = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_GetDrawerStatus);
			return cb_getDrawerStatus;
		}

		static bool n_GetDrawerStatus (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.IWoyouService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DrawerStatus;
		}
#pragma warning restore 0169

		IntPtr id_getDrawerStatus;
		public unsafe bool DrawerStatus {
			get {
				if (id_getDrawerStatus == IntPtr.Zero)
					id_getDrawerStatus = JNIEnv.GetMethodID (class_ref, "getDrawerStatus", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_getDrawerStatus);
			}
		}

		static Delegate cb_getFirmwareStatus;
#pragma warning disable 0169
		static Delegate GetGetFirmwareStatusHandler ()
		{
			if (cb_getFirmwareStatus == null)
				cb_getFirmwareStatus = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetFirmwareStatus);
			return cb_getFirmwareStatus;
		}

		static int n_GetFirmwareStatus (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.IWoyouService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.FirmwareStatus;
		}
#pragma warning restore 0169

		IntPtr id_getFirmwareStatus;
		public unsafe int FirmwareStatus {
			get {
				if (id_getFirmwareStatus == IntPtr.Zero)
					id_getFirmwareStatus = JNIEnv.GetMethodID (class_ref, "getFirmwareStatus", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getFirmwareStatus);
			}
		}

		static Delegate cb_getOpenDrawerTimes;
#pragma warning disable 0169
		static Delegate GetGetOpenDrawerTimesHandler ()
		{
			if (cb_getOpenDrawerTimes == null)
				cb_getOpenDrawerTimes = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetOpenDrawerTimes);
			return cb_getOpenDrawerTimes;
		}

		static int n_GetOpenDrawerTimes (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.IWoyouService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.OpenDrawerTimes;
		}
#pragma warning restore 0169

		IntPtr id_getOpenDrawerTimes;
		public unsafe int OpenDrawerTimes {
			get {
				if (id_getOpenDrawerTimes == IntPtr.Zero)
					id_getOpenDrawerTimes = JNIEnv.GetMethodID (class_ref, "getOpenDrawerTimes", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getOpenDrawerTimes);
			}
		}

		static Delegate cb_getPrintedLength;
#pragma warning disable 0169
		static Delegate GetGetPrintedLengthHandler ()
		{
			if (cb_getPrintedLength == null)
				cb_getPrintedLength = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetPrintedLength);
			return cb_getPrintedLength;
		}

		static int n_GetPrintedLength (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.IWoyouService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PrintedLength;
		}
#pragma warning restore 0169

		IntPtr id_getPrintedLength;
		public unsafe int PrintedLength {
			get {
				if (id_getPrintedLength == IntPtr.Zero)
					id_getPrintedLength = JNIEnv.GetMethodID (class_ref, "getPrintedLength", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getPrintedLength);
			}
		}

		static Delegate cb_getPrinterBBMDistance;
#pragma warning disable 0169
		static Delegate GetGetPrinterBBMDistanceHandler ()
		{
			if (cb_getPrinterBBMDistance == null)
				cb_getPrinterBBMDistance = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetPrinterBBMDistance);
			return cb_getPrinterBBMDistance;
		}

		static int n_GetPrinterBBMDistance (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.IWoyouService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PrinterBBMDistance;
		}
#pragma warning restore 0169

		IntPtr id_getPrinterBBMDistance;
		public unsafe int PrinterBBMDistance {
			get {
				if (id_getPrinterBBMDistance == IntPtr.Zero)
					id_getPrinterBBMDistance = JNIEnv.GetMethodID (class_ref, "getPrinterBBMDistance", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getPrinterBBMDistance);
			}
		}

		static Delegate cb_getPrinterModal;
#pragma warning disable 0169
		static Delegate GetGetPrinterModalHandler ()
		{
			if (cb_getPrinterModal == null)
				cb_getPrinterModal = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetPrinterModal);
			return cb_getPrinterModal;
		}

		static IntPtr n_GetPrinterModal (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.IWoyouService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.PrinterModal);
		}
#pragma warning restore 0169

		IntPtr id_getPrinterModal;
		public unsafe string PrinterModal {
			get {
				if (id_getPrinterModal == IntPtr.Zero)
					id_getPrinterModal = JNIEnv.GetMethodID (class_ref, "getPrinterModal", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPrinterModal), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getPrinterMode;
#pragma warning disable 0169
		static Delegate GetGetPrinterModeHandler ()
		{
			if (cb_getPrinterMode == null)
				cb_getPrinterMode = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetPrinterMode);
			return cb_getPrinterMode;
		}

		static int n_GetPrinterMode (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.IWoyouService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PrinterMode;
		}
#pragma warning restore 0169

		IntPtr id_getPrinterMode;
		public unsafe int PrinterMode {
			get {
				if (id_getPrinterMode == IntPtr.Zero)
					id_getPrinterMode = JNIEnv.GetMethodID (class_ref, "getPrinterMode", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getPrinterMode);
			}
		}

		static Delegate cb_getPrinterSerialNo;
#pragma warning disable 0169
		static Delegate GetGetPrinterSerialNoHandler ()
		{
			if (cb_getPrinterSerialNo == null)
				cb_getPrinterSerialNo = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetPrinterSerialNo);
			return cb_getPrinterSerialNo;
		}

		static IntPtr n_GetPrinterSerialNo (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.IWoyouService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.PrinterSerialNo);
		}
#pragma warning restore 0169

		IntPtr id_getPrinterSerialNo;
		public unsafe string PrinterSerialNo {
			get {
				if (id_getPrinterSerialNo == IntPtr.Zero)
					id_getPrinterSerialNo = JNIEnv.GetMethodID (class_ref, "getPrinterSerialNo", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPrinterSerialNo), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getPrinterVersion;
#pragma warning disable 0169
		static Delegate GetGetPrinterVersionHandler ()
		{
			if (cb_getPrinterVersion == null)
				cb_getPrinterVersion = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetPrinterVersion);
			return cb_getPrinterVersion;
		}

		static IntPtr n_GetPrinterVersion (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.IWoyouService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.PrinterVersion);
		}
#pragma warning restore 0169

		IntPtr id_getPrinterVersion;
		public unsafe string PrinterVersion {
			get {
				if (id_getPrinterVersion == IntPtr.Zero)
					id_getPrinterVersion = JNIEnv.GetMethodID (class_ref, "getPrinterVersion", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPrinterVersion), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getServiceVersion;
#pragma warning disable 0169
		static Delegate GetGetServiceVersionHandler ()
		{
			if (cb_getServiceVersion == null)
				cb_getServiceVersion = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetServiceVersion);
			return cb_getServiceVersion;
		}

		static IntPtr n_GetServiceVersion (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.IWoyouService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ServiceVersion);
		}
#pragma warning restore 0169

		IntPtr id_getServiceVersion;
		public unsafe string ServiceVersion {
			get {
				if (id_getServiceVersion == IntPtr.Zero)
					id_getServiceVersion = JNIEnv.GetMethodID (class_ref, "getServiceVersion", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getServiceVersion), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_commitPrinterBuffer;
#pragma warning disable 0169
		static Delegate GetCommitPrinterBufferHandler ()
		{
			if (cb_commitPrinterBuffer == null)
				cb_commitPrinterBuffer = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_CommitPrinterBuffer);
			return cb_commitPrinterBuffer;
		}

		static void n_CommitPrinterBuffer (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.IWoyouService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CommitPrinterBuffer ();
		}
#pragma warning restore 0169

		IntPtr id_commitPrinterBuffer;
		public unsafe void CommitPrinterBuffer ()
		{
			if (id_commitPrinterBuffer == IntPtr.Zero)
				id_commitPrinterBuffer = JNIEnv.GetMethodID (class_ref, "commitPrinterBuffer", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_commitPrinterBuffer);
		}

		static Delegate cb_commitPrinterBufferWithCallback_Lwoyou_aidlservice_jiuiv5_ICallback_;
#pragma warning disable 0169
		static Delegate GetCommitPrinterBufferWithCallback_Lwoyou_aidlservice_jiuiv5_ICallback_Handler ()
		{
			if (cb_commitPrinterBufferWithCallback_Lwoyou_aidlservice_jiuiv5_ICallback_ == null)
				cb_commitPrinterBufferWithCallback_Lwoyou_aidlservice_jiuiv5_ICallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_CommitPrinterBufferWithCallback_Lwoyou_aidlservice_jiuiv5_ICallback_);
			return cb_commitPrinterBufferWithCallback_Lwoyou_aidlservice_jiuiv5_ICallback_;
		}

		static void n_CommitPrinterBufferWithCallback_Lwoyou_aidlservice_jiuiv5_ICallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.IWoyouService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Woyou.Aidlservice.Jiuiv5.ICallback)global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.ICallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CommitPrinterBufferWithCallback (p0);
		}
#pragma warning restore 0169

		IntPtr id_commitPrinterBufferWithCallback_Lwoyou_aidlservice_jiuiv5_ICallback_;
		public unsafe void CommitPrinterBufferWithCallback (global::Woyou.Aidlservice.Jiuiv5.ICallback p0)
		{
			if (id_commitPrinterBufferWithCallback_Lwoyou_aidlservice_jiuiv5_ICallback_ == IntPtr.Zero)
				id_commitPrinterBufferWithCallback_Lwoyou_aidlservice_jiuiv5_ICallback_ = JNIEnv.GetMethodID (class_ref, "commitPrinterBufferWithCallback", "(Lwoyou/aidlservice/jiuiv5/ICallback;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_commitPrinterBufferWithCallback_Lwoyou_aidlservice_jiuiv5_ICallback_, __args);
		}

		static Delegate cb_cutPaper_Lwoyou_aidlservice_jiuiv5_ICallback_;
#pragma warning disable 0169
		static Delegate GetCutPaper_Lwoyou_aidlservice_jiuiv5_ICallback_Handler ()
		{
			if (cb_cutPaper_Lwoyou_aidlservice_jiuiv5_ICallback_ == null)
				cb_cutPaper_Lwoyou_aidlservice_jiuiv5_ICallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_CutPaper_Lwoyou_aidlservice_jiuiv5_ICallback_);
			return cb_cutPaper_Lwoyou_aidlservice_jiuiv5_ICallback_;
		}

		static void n_CutPaper_Lwoyou_aidlservice_jiuiv5_ICallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.IWoyouService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Woyou.Aidlservice.Jiuiv5.ICallback)global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.ICallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CutPaper (p0);
		}
#pragma warning restore 0169

		IntPtr id_cutPaper_Lwoyou_aidlservice_jiuiv5_ICallback_;
		public unsafe void CutPaper (global::Woyou.Aidlservice.Jiuiv5.ICallback p0)
		{
			if (id_cutPaper_Lwoyou_aidlservice_jiuiv5_ICallback_ == IntPtr.Zero)
				id_cutPaper_Lwoyou_aidlservice_jiuiv5_ICallback_ = JNIEnv.GetMethodID (class_ref, "cutPaper", "(Lwoyou/aidlservice/jiuiv5/ICallback;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_cutPaper_Lwoyou_aidlservice_jiuiv5_ICallback_, __args);
		}

		static Delegate cb_enterPrinterBuffer_Z;
#pragma warning disable 0169
		static Delegate GetEnterPrinterBuffer_ZHandler ()
		{
			if (cb_enterPrinterBuffer_Z == null)
				cb_enterPrinterBuffer_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_EnterPrinterBuffer_Z);
			return cb_enterPrinterBuffer_Z;
		}

		static void n_EnterPrinterBuffer_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.IWoyouService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.EnterPrinterBuffer (p0);
		}
#pragma warning restore 0169

		IntPtr id_enterPrinterBuffer_Z;
		public unsafe void EnterPrinterBuffer (bool p0)
		{
			if (id_enterPrinterBuffer_Z == IntPtr.Zero)
				id_enterPrinterBuffer_Z = JNIEnv.GetMethodID (class_ref, "enterPrinterBuffer", "(Z)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_enterPrinterBuffer_Z, __args);
		}

		static Delegate cb_exitPrinterBuffer_Z;
#pragma warning disable 0169
		static Delegate GetExitPrinterBuffer_ZHandler ()
		{
			if (cb_exitPrinterBuffer_Z == null)
				cb_exitPrinterBuffer_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_ExitPrinterBuffer_Z);
			return cb_exitPrinterBuffer_Z;
		}

		static void n_ExitPrinterBuffer_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.IWoyouService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ExitPrinterBuffer (p0);
		}
#pragma warning restore 0169

		IntPtr id_exitPrinterBuffer_Z;
		public unsafe void ExitPrinterBuffer (bool p0)
		{
			if (id_exitPrinterBuffer_Z == IntPtr.Zero)
				id_exitPrinterBuffer_Z = JNIEnv.GetMethodID (class_ref, "exitPrinterBuffer", "(Z)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_exitPrinterBuffer_Z, __args);
		}

		static Delegate cb_exitPrinterBufferWithCallback_ZLwoyou_aidlservice_jiuiv5_ICallback_;
#pragma warning disable 0169
		static Delegate GetExitPrinterBufferWithCallback_ZLwoyou_aidlservice_jiuiv5_ICallback_Handler ()
		{
			if (cb_exitPrinterBufferWithCallback_ZLwoyou_aidlservice_jiuiv5_ICallback_ == null)
				cb_exitPrinterBufferWithCallback_ZLwoyou_aidlservice_jiuiv5_ICallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZL_V) n_ExitPrinterBufferWithCallback_ZLwoyou_aidlservice_jiuiv5_ICallback_);
			return cb_exitPrinterBufferWithCallback_ZLwoyou_aidlservice_jiuiv5_ICallback_;
		}

		static void n_ExitPrinterBufferWithCallback_ZLwoyou_aidlservice_jiuiv5_ICallback_ (IntPtr jnienv, IntPtr native__this, bool p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.IWoyouService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Woyou.Aidlservice.Jiuiv5.ICallback)global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.ICallback> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.ExitPrinterBufferWithCallback (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_exitPrinterBufferWithCallback_ZLwoyou_aidlservice_jiuiv5_ICallback_;
		public unsafe void ExitPrinterBufferWithCallback (bool p0, global::Woyou.Aidlservice.Jiuiv5.ICallback p1)
		{
			if (id_exitPrinterBufferWithCallback_ZLwoyou_aidlservice_jiuiv5_ICallback_ == IntPtr.Zero)
				id_exitPrinterBufferWithCallback_ZLwoyou_aidlservice_jiuiv5_ICallback_ = JNIEnv.GetMethodID (class_ref, "exitPrinterBufferWithCallback", "(ZLwoyou/aidlservice/jiuiv5/ICallback;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_exitPrinterBufferWithCallback_ZLwoyou_aidlservice_jiuiv5_ICallback_, __args);
		}

		static Delegate cb_lineWrap_ILwoyou_aidlservice_jiuiv5_ICallback_;
#pragma warning disable 0169
		static Delegate GetLineWrap_ILwoyou_aidlservice_jiuiv5_ICallback_Handler ()
		{
			if (cb_lineWrap_ILwoyou_aidlservice_jiuiv5_ICallback_ == null)
				cb_lineWrap_ILwoyou_aidlservice_jiuiv5_ICallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIL_V) n_LineWrap_ILwoyou_aidlservice_jiuiv5_ICallback_);
			return cb_lineWrap_ILwoyou_aidlservice_jiuiv5_ICallback_;
		}

		static void n_LineWrap_ILwoyou_aidlservice_jiuiv5_ICallback_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.IWoyouService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Woyou.Aidlservice.Jiuiv5.ICallback)global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.ICallback> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.LineWrap (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_lineWrap_ILwoyou_aidlservice_jiuiv5_ICallback_;
		public unsafe void LineWrap (int p0, global::Woyou.Aidlservice.Jiuiv5.ICallback p1)
		{
			if (id_lineWrap_ILwoyou_aidlservice_jiuiv5_ICallback_ == IntPtr.Zero)
				id_lineWrap_ILwoyou_aidlservice_jiuiv5_ICallback_ = JNIEnv.GetMethodID (class_ref, "lineWrap", "(ILwoyou/aidlservice/jiuiv5/ICallback;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_lineWrap_ILwoyou_aidlservice_jiuiv5_ICallback_, __args);
		}

		static Delegate cb_openDrawer_Lwoyou_aidlservice_jiuiv5_ICallback_;
#pragma warning disable 0169
		static Delegate GetOpenDrawer_Lwoyou_aidlservice_jiuiv5_ICallback_Handler ()
		{
			if (cb_openDrawer_Lwoyou_aidlservice_jiuiv5_ICallback_ == null)
				cb_openDrawer_Lwoyou_aidlservice_jiuiv5_ICallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OpenDrawer_Lwoyou_aidlservice_jiuiv5_ICallback_);
			return cb_openDrawer_Lwoyou_aidlservice_jiuiv5_ICallback_;
		}

		static void n_OpenDrawer_Lwoyou_aidlservice_jiuiv5_ICallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.IWoyouService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Woyou.Aidlservice.Jiuiv5.ICallback)global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.ICallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OpenDrawer (p0);
		}
#pragma warning restore 0169

		IntPtr id_openDrawer_Lwoyou_aidlservice_jiuiv5_ICallback_;
		public unsafe void OpenDrawer (global::Woyou.Aidlservice.Jiuiv5.ICallback p0)
		{
			if (id_openDrawer_Lwoyou_aidlservice_jiuiv5_ICallback_ == IntPtr.Zero)
				id_openDrawer_Lwoyou_aidlservice_jiuiv5_ICallback_ = JNIEnv.GetMethodID (class_ref, "openDrawer", "(Lwoyou/aidlservice/jiuiv5/ICallback;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_openDrawer_Lwoyou_aidlservice_jiuiv5_ICallback_, __args);
		}

		static Delegate cb_postPrintData_Ljava_lang_String_arrayBII;
#pragma warning disable 0169
		static Delegate GetPostPrintData_Ljava_lang_String_arrayBIIHandler ()
		{
			if (cb_postPrintData_Ljava_lang_String_arrayBII == null)
				cb_postPrintData_Ljava_lang_String_arrayBII = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLII_Z) n_PostPrintData_Ljava_lang_String_arrayBII);
			return cb_postPrintData_Ljava_lang_String_arrayBII;
		}

		static bool n_PostPrintData_Ljava_lang_String_arrayBII (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2, int p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.IWoyouService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			bool __ret = __this.PostPrintData (p0, p1, p2, p3);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_postPrintData_Ljava_lang_String_arrayBII;
		public unsafe bool PostPrintData (string p0, byte[] p1, int p2, int p3)
		{
			if (id_postPrintData_Ljava_lang_String_arrayBII == IntPtr.Zero)
				id_postPrintData_Ljava_lang_String_arrayBII = JNIEnv.GetMethodID (class_ref, "postPrintData", "(Ljava/lang/String;[BII)Z");
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (p3);
			var __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_postPrintData_Ljava_lang_String_arrayBII, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			return __ret;
		}

		static Delegate cb_printBarCode_Ljava_lang_String_IIIILwoyou_aidlservice_jiuiv5_ICallback_;
#pragma warning disable 0169
		static Delegate GetPrintBarCode_Ljava_lang_String_IIIILwoyou_aidlservice_jiuiv5_ICallback_Handler ()
		{
			if (cb_printBarCode_Ljava_lang_String_IIIILwoyou_aidlservice_jiuiv5_ICallback_ == null)
				cb_printBarCode_Ljava_lang_String_IIIILwoyou_aidlservice_jiuiv5_ICallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLIIIIL_V) n_PrintBarCode_Ljava_lang_String_IIIILwoyou_aidlservice_jiuiv5_ICallback_);
			return cb_printBarCode_Ljava_lang_String_IIIILwoyou_aidlservice_jiuiv5_ICallback_;
		}

		static void n_PrintBarCode_Ljava_lang_String_IIIILwoyou_aidlservice_jiuiv5_ICallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2, int p3, int p4, IntPtr native_p5)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.IWoyouService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p5 = (global::Woyou.Aidlservice.Jiuiv5.ICallback)global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.ICallback> (native_p5, JniHandleOwnership.DoNotTransfer);
			__this.PrintBarCode (p0, p1, p2, p3, p4, p5);
		}
#pragma warning restore 0169

		IntPtr id_printBarCode_Ljava_lang_String_IIIILwoyou_aidlservice_jiuiv5_ICallback_;
		public unsafe void PrintBarCode (string p0, int p1, int p2, int p3, int p4, global::Woyou.Aidlservice.Jiuiv5.ICallback p5)
		{
			if (id_printBarCode_Ljava_lang_String_IIIILwoyou_aidlservice_jiuiv5_ICallback_ == IntPtr.Zero)
				id_printBarCode_Ljava_lang_String_IIIILwoyou_aidlservice_jiuiv5_ICallback_ = JNIEnv.GetMethodID (class_ref, "printBarCode", "(Ljava/lang/String;IIIILwoyou/aidlservice/jiuiv5/ICallback;)V");
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			JValue* __args = stackalloc JValue [6];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (p3);
			__args [4] = new JValue (p4);
			__args [5] = new JValue ((p5 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p5).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_printBarCode_Ljava_lang_String_IIIILwoyou_aidlservice_jiuiv5_ICallback_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_printBitmap_Landroid_graphics_Bitmap_Lwoyou_aidlservice_jiuiv5_ICallback_;
#pragma warning disable 0169
		static Delegate GetPrintBitmap_Landroid_graphics_Bitmap_Lwoyou_aidlservice_jiuiv5_ICallback_Handler ()
		{
			if (cb_printBitmap_Landroid_graphics_Bitmap_Lwoyou_aidlservice_jiuiv5_ICallback_ == null)
				cb_printBitmap_Landroid_graphics_Bitmap_Lwoyou_aidlservice_jiuiv5_ICallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_PrintBitmap_Landroid_graphics_Bitmap_Lwoyou_aidlservice_jiuiv5_ICallback_);
			return cb_printBitmap_Landroid_graphics_Bitmap_Lwoyou_aidlservice_jiuiv5_ICallback_;
		}

		static void n_PrintBitmap_Landroid_graphics_Bitmap_Lwoyou_aidlservice_jiuiv5_ICallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.IWoyouService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Woyou.Aidlservice.Jiuiv5.ICallback)global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.ICallback> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.PrintBitmap (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_printBitmap_Landroid_graphics_Bitmap_Lwoyou_aidlservice_jiuiv5_ICallback_;
		public unsafe void PrintBitmap (global::Android.Graphics.Bitmap p0, global::Woyou.Aidlservice.Jiuiv5.ICallback p1)
		{
			if (id_printBitmap_Landroid_graphics_Bitmap_Lwoyou_aidlservice_jiuiv5_ICallback_ == IntPtr.Zero)
				id_printBitmap_Landroid_graphics_Bitmap_Lwoyou_aidlservice_jiuiv5_ICallback_ = JNIEnv.GetMethodID (class_ref, "printBitmap", "(Landroid/graphics/Bitmap;Lwoyou/aidlservice/jiuiv5/ICallback;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_printBitmap_Landroid_graphics_Bitmap_Lwoyou_aidlservice_jiuiv5_ICallback_, __args);
		}

		static Delegate cb_printBitmapCustom_Landroid_graphics_Bitmap_ILwoyou_aidlservice_jiuiv5_ICallback_;
#pragma warning disable 0169
		static Delegate GetPrintBitmapCustom_Landroid_graphics_Bitmap_ILwoyou_aidlservice_jiuiv5_ICallback_Handler ()
		{
			if (cb_printBitmapCustom_Landroid_graphics_Bitmap_ILwoyou_aidlservice_jiuiv5_ICallback_ == null)
				cb_printBitmapCustom_Landroid_graphics_Bitmap_ILwoyou_aidlservice_jiuiv5_ICallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLIL_V) n_PrintBitmapCustom_Landroid_graphics_Bitmap_ILwoyou_aidlservice_jiuiv5_ICallback_);
			return cb_printBitmapCustom_Landroid_graphics_Bitmap_ILwoyou_aidlservice_jiuiv5_ICallback_;
		}

		static void n_PrintBitmapCustom_Landroid_graphics_Bitmap_ILwoyou_aidlservice_jiuiv5_ICallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.IWoyouService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p2 = (global::Woyou.Aidlservice.Jiuiv5.ICallback)global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.ICallback> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.PrintBitmapCustom (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_printBitmapCustom_Landroid_graphics_Bitmap_ILwoyou_aidlservice_jiuiv5_ICallback_;
		public unsafe void PrintBitmapCustom (global::Android.Graphics.Bitmap p0, int p1, global::Woyou.Aidlservice.Jiuiv5.ICallback p2)
		{
			if (id_printBitmapCustom_Landroid_graphics_Bitmap_ILwoyou_aidlservice_jiuiv5_ICallback_ == IntPtr.Zero)
				id_printBitmapCustom_Landroid_graphics_Bitmap_ILwoyou_aidlservice_jiuiv5_ICallback_ = JNIEnv.GetMethodID (class_ref, "printBitmapCustom", "(Landroid/graphics/Bitmap;ILwoyou/aidlservice/jiuiv5/ICallback;)V");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (p1);
			__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_printBitmapCustom_Landroid_graphics_Bitmap_ILwoyou_aidlservice_jiuiv5_ICallback_, __args);
		}

		static Delegate cb_printColumnsString_arrayLjava_lang_String_arrayIarrayILwoyou_aidlservice_jiuiv5_ICallback_;
#pragma warning disable 0169
		static Delegate GetPrintColumnsString_arrayLjava_lang_String_arrayIarrayILwoyou_aidlservice_jiuiv5_ICallback_Handler ()
		{
			if (cb_printColumnsString_arrayLjava_lang_String_arrayIarrayILwoyou_aidlservice_jiuiv5_ICallback_ == null)
				cb_printColumnsString_arrayLjava_lang_String_arrayIarrayILwoyou_aidlservice_jiuiv5_ICallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLL_V) n_PrintColumnsString_arrayLjava_lang_String_arrayIarrayILwoyou_aidlservice_jiuiv5_ICallback_);
			return cb_printColumnsString_arrayLjava_lang_String_arrayIarrayILwoyou_aidlservice_jiuiv5_ICallback_;
		}

		static void n_PrintColumnsString_arrayLjava_lang_String_arrayIarrayILwoyou_aidlservice_jiuiv5_ICallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.IWoyouService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (string[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (string));
			var p1 = (int[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (int));
			var p2 = (int[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (int));
			var p3 = (global::Woyou.Aidlservice.Jiuiv5.ICallback)global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.ICallback> (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.PrintColumnsString (p0, p1, p2, p3);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
		}
#pragma warning restore 0169

		IntPtr id_printColumnsString_arrayLjava_lang_String_arrayIarrayILwoyou_aidlservice_jiuiv5_ICallback_;
		public unsafe void PrintColumnsString (string[] p0, int[] p1, int[] p2, global::Woyou.Aidlservice.Jiuiv5.ICallback p3)
		{
			if (id_printColumnsString_arrayLjava_lang_String_arrayIarrayILwoyou_aidlservice_jiuiv5_ICallback_ == IntPtr.Zero)
				id_printColumnsString_arrayLjava_lang_String_arrayIarrayILwoyou_aidlservice_jiuiv5_ICallback_ = JNIEnv.GetMethodID (class_ref, "printColumnsString", "([Ljava/lang/String;[I[ILwoyou/aidlservice/jiuiv5/ICallback;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_printColumnsString_arrayLjava_lang_String_arrayIarrayILwoyou_aidlservice_jiuiv5_ICallback_, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_printColumnsText_arrayLjava_lang_String_arrayIarrayILwoyou_aidlservice_jiuiv5_ICallback_;
#pragma warning disable 0169
		static Delegate GetPrintColumnsText_arrayLjava_lang_String_arrayIarrayILwoyou_aidlservice_jiuiv5_ICallback_Handler ()
		{
			if (cb_printColumnsText_arrayLjava_lang_String_arrayIarrayILwoyou_aidlservice_jiuiv5_ICallback_ == null)
				cb_printColumnsText_arrayLjava_lang_String_arrayIarrayILwoyou_aidlservice_jiuiv5_ICallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLL_V) n_PrintColumnsText_arrayLjava_lang_String_arrayIarrayILwoyou_aidlservice_jiuiv5_ICallback_);
			return cb_printColumnsText_arrayLjava_lang_String_arrayIarrayILwoyou_aidlservice_jiuiv5_ICallback_;
		}

		static void n_PrintColumnsText_arrayLjava_lang_String_arrayIarrayILwoyou_aidlservice_jiuiv5_ICallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.IWoyouService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (string[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (string));
			var p1 = (int[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (int));
			var p2 = (int[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (int));
			var p3 = (global::Woyou.Aidlservice.Jiuiv5.ICallback)global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.ICallback> (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.PrintColumnsText (p0, p1, p2, p3);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
		}
#pragma warning restore 0169

		IntPtr id_printColumnsText_arrayLjava_lang_String_arrayIarrayILwoyou_aidlservice_jiuiv5_ICallback_;
		public unsafe void PrintColumnsText (string[] p0, int[] p1, int[] p2, global::Woyou.Aidlservice.Jiuiv5.ICallback p3)
		{
			if (id_printColumnsText_arrayLjava_lang_String_arrayIarrayILwoyou_aidlservice_jiuiv5_ICallback_ == IntPtr.Zero)
				id_printColumnsText_arrayLjava_lang_String_arrayIarrayILwoyou_aidlservice_jiuiv5_ICallback_ = JNIEnv.GetMethodID (class_ref, "printColumnsText", "([Ljava/lang/String;[I[ILwoyou/aidlservice/jiuiv5/ICallback;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_printColumnsText_arrayLjava_lang_String_arrayIarrayILwoyou_aidlservice_jiuiv5_ICallback_, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_printOriginalText_Ljava_lang_String_Lwoyou_aidlservice_jiuiv5_ICallback_;
#pragma warning disable 0169
		static Delegate GetPrintOriginalText_Ljava_lang_String_Lwoyou_aidlservice_jiuiv5_ICallback_Handler ()
		{
			if (cb_printOriginalText_Ljava_lang_String_Lwoyou_aidlservice_jiuiv5_ICallback_ == null)
				cb_printOriginalText_Ljava_lang_String_Lwoyou_aidlservice_jiuiv5_ICallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_PrintOriginalText_Ljava_lang_String_Lwoyou_aidlservice_jiuiv5_ICallback_);
			return cb_printOriginalText_Ljava_lang_String_Lwoyou_aidlservice_jiuiv5_ICallback_;
		}

		static void n_PrintOriginalText_Ljava_lang_String_Lwoyou_aidlservice_jiuiv5_ICallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.IWoyouService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Woyou.Aidlservice.Jiuiv5.ICallback)global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.ICallback> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.PrintOriginalText (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_printOriginalText_Ljava_lang_String_Lwoyou_aidlservice_jiuiv5_ICallback_;
		public unsafe void PrintOriginalText (string p0, global::Woyou.Aidlservice.Jiuiv5.ICallback p1)
		{
			if (id_printOriginalText_Ljava_lang_String_Lwoyou_aidlservice_jiuiv5_ICallback_ == IntPtr.Zero)
				id_printOriginalText_Ljava_lang_String_Lwoyou_aidlservice_jiuiv5_ICallback_ = JNIEnv.GetMethodID (class_ref, "printOriginalText", "(Ljava/lang/String;Lwoyou/aidlservice/jiuiv5/ICallback;)V");
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_printOriginalText_Ljava_lang_String_Lwoyou_aidlservice_jiuiv5_ICallback_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_printQRCode_Ljava_lang_String_IILwoyou_aidlservice_jiuiv5_ICallback_;
#pragma warning disable 0169
		static Delegate GetPrintQRCode_Ljava_lang_String_IILwoyou_aidlservice_jiuiv5_ICallback_Handler ()
		{
			if (cb_printQRCode_Ljava_lang_String_IILwoyou_aidlservice_jiuiv5_ICallback_ == null)
				cb_printQRCode_Ljava_lang_String_IILwoyou_aidlservice_jiuiv5_ICallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLIIL_V) n_PrintQRCode_Ljava_lang_String_IILwoyou_aidlservice_jiuiv5_ICallback_);
			return cb_printQRCode_Ljava_lang_String_IILwoyou_aidlservice_jiuiv5_ICallback_;
		}

		static void n_PrintQRCode_Ljava_lang_String_IILwoyou_aidlservice_jiuiv5_ICallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2, IntPtr native_p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.IWoyouService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p3 = (global::Woyou.Aidlservice.Jiuiv5.ICallback)global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.ICallback> (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.PrintQRCode (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		IntPtr id_printQRCode_Ljava_lang_String_IILwoyou_aidlservice_jiuiv5_ICallback_;
		public unsafe void PrintQRCode (string p0, int p1, int p2, global::Woyou.Aidlservice.Jiuiv5.ICallback p3)
		{
			if (id_printQRCode_Ljava_lang_String_IILwoyou_aidlservice_jiuiv5_ICallback_ == IntPtr.Zero)
				id_printQRCode_Ljava_lang_String_IILwoyou_aidlservice_jiuiv5_ICallback_ = JNIEnv.GetMethodID (class_ref, "printQRCode", "(Ljava/lang/String;IILwoyou/aidlservice/jiuiv5/ICallback;)V");
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_printQRCode_Ljava_lang_String_IILwoyou_aidlservice_jiuiv5_ICallback_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_printText_Ljava_lang_String_Lwoyou_aidlservice_jiuiv5_ICallback_;
#pragma warning disable 0169
		static Delegate GetPrintText_Ljava_lang_String_Lwoyou_aidlservice_jiuiv5_ICallback_Handler ()
		{
			if (cb_printText_Ljava_lang_String_Lwoyou_aidlservice_jiuiv5_ICallback_ == null)
				cb_printText_Ljava_lang_String_Lwoyou_aidlservice_jiuiv5_ICallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_PrintText_Ljava_lang_String_Lwoyou_aidlservice_jiuiv5_ICallback_);
			return cb_printText_Ljava_lang_String_Lwoyou_aidlservice_jiuiv5_ICallback_;
		}

		static void n_PrintText_Ljava_lang_String_Lwoyou_aidlservice_jiuiv5_ICallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.IWoyouService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Woyou.Aidlservice.Jiuiv5.ICallback)global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.ICallback> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.PrintText (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_printText_Ljava_lang_String_Lwoyou_aidlservice_jiuiv5_ICallback_;
		public unsafe void PrintText (string p0, global::Woyou.Aidlservice.Jiuiv5.ICallback p1)
		{
			if (id_printText_Ljava_lang_String_Lwoyou_aidlservice_jiuiv5_ICallback_ == IntPtr.Zero)
				id_printText_Ljava_lang_String_Lwoyou_aidlservice_jiuiv5_ICallback_ = JNIEnv.GetMethodID (class_ref, "printText", "(Ljava/lang/String;Lwoyou/aidlservice/jiuiv5/ICallback;)V");
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_printText_Ljava_lang_String_Lwoyou_aidlservice_jiuiv5_ICallback_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_printTextWithFont_Ljava_lang_String_Ljava_lang_String_FLwoyou_aidlservice_jiuiv5_ICallback_;
#pragma warning disable 0169
		static Delegate GetPrintTextWithFont_Ljava_lang_String_Ljava_lang_String_FLwoyou_aidlservice_jiuiv5_ICallback_Handler ()
		{
			if (cb_printTextWithFont_Ljava_lang_String_Ljava_lang_String_FLwoyou_aidlservice_jiuiv5_ICallback_ == null)
				cb_printTextWithFont_Ljava_lang_String_Ljava_lang_String_FLwoyou_aidlservice_jiuiv5_ICallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLFL_V) n_PrintTextWithFont_Ljava_lang_String_Ljava_lang_String_FLwoyou_aidlservice_jiuiv5_ICallback_);
			return cb_printTextWithFont_Ljava_lang_String_Ljava_lang_String_FLwoyou_aidlservice_jiuiv5_ICallback_;
		}

		static void n_PrintTextWithFont_Ljava_lang_String_Ljava_lang_String_FLwoyou_aidlservice_jiuiv5_ICallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, float p2, IntPtr native_p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.IWoyouService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p3 = (global::Woyou.Aidlservice.Jiuiv5.ICallback)global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.ICallback> (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.PrintTextWithFont (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		IntPtr id_printTextWithFont_Ljava_lang_String_Ljava_lang_String_FLwoyou_aidlservice_jiuiv5_ICallback_;
		public unsafe void PrintTextWithFont (string p0, string p1, float p2, global::Woyou.Aidlservice.Jiuiv5.ICallback p3)
		{
			if (id_printTextWithFont_Ljava_lang_String_Ljava_lang_String_FLwoyou_aidlservice_jiuiv5_ICallback_ == IntPtr.Zero)
				id_printTextWithFont_Ljava_lang_String_Ljava_lang_String_FLwoyou_aidlservice_jiuiv5_ICallback_ = JNIEnv.GetMethodID (class_ref, "printTextWithFont", "(Ljava/lang/String;Ljava/lang/String;FLwoyou/aidlservice/jiuiv5/ICallback;)V");
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			IntPtr native_p1 = JNIEnv.NewString ((string)p1);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_printTextWithFont_Ljava_lang_String_Ljava_lang_String_FLwoyou_aidlservice_jiuiv5_ICallback_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_printerInit_Lwoyou_aidlservice_jiuiv5_ICallback_;
#pragma warning disable 0169
		static Delegate GetPrinterInit_Lwoyou_aidlservice_jiuiv5_ICallback_Handler ()
		{
			if (cb_printerInit_Lwoyou_aidlservice_jiuiv5_ICallback_ == null)
				cb_printerInit_Lwoyou_aidlservice_jiuiv5_ICallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_PrinterInit_Lwoyou_aidlservice_jiuiv5_ICallback_);
			return cb_printerInit_Lwoyou_aidlservice_jiuiv5_ICallback_;
		}

		static void n_PrinterInit_Lwoyou_aidlservice_jiuiv5_ICallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.IWoyouService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Woyou.Aidlservice.Jiuiv5.ICallback)global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.ICallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PrinterInit (p0);
		}
#pragma warning restore 0169

		IntPtr id_printerInit_Lwoyou_aidlservice_jiuiv5_ICallback_;
		public unsafe void PrinterInit (global::Woyou.Aidlservice.Jiuiv5.ICallback p0)
		{
			if (id_printerInit_Lwoyou_aidlservice_jiuiv5_ICallback_ == IntPtr.Zero)
				id_printerInit_Lwoyou_aidlservice_jiuiv5_ICallback_ = JNIEnv.GetMethodID (class_ref, "printerInit", "(Lwoyou/aidlservice/jiuiv5/ICallback;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_printerInit_Lwoyou_aidlservice_jiuiv5_ICallback_, __args);
		}

		static Delegate cb_printerSelfChecking_Lwoyou_aidlservice_jiuiv5_ICallback_;
#pragma warning disable 0169
		static Delegate GetPrinterSelfChecking_Lwoyou_aidlservice_jiuiv5_ICallback_Handler ()
		{
			if (cb_printerSelfChecking_Lwoyou_aidlservice_jiuiv5_ICallback_ == null)
				cb_printerSelfChecking_Lwoyou_aidlservice_jiuiv5_ICallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_PrinterSelfChecking_Lwoyou_aidlservice_jiuiv5_ICallback_);
			return cb_printerSelfChecking_Lwoyou_aidlservice_jiuiv5_ICallback_;
		}

		static void n_PrinterSelfChecking_Lwoyou_aidlservice_jiuiv5_ICallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.IWoyouService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Woyou.Aidlservice.Jiuiv5.ICallback)global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.ICallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PrinterSelfChecking (p0);
		}
#pragma warning restore 0169

		IntPtr id_printerSelfChecking_Lwoyou_aidlservice_jiuiv5_ICallback_;
		public unsafe void PrinterSelfChecking (global::Woyou.Aidlservice.Jiuiv5.ICallback p0)
		{
			if (id_printerSelfChecking_Lwoyou_aidlservice_jiuiv5_ICallback_ == IntPtr.Zero)
				id_printerSelfChecking_Lwoyou_aidlservice_jiuiv5_ICallback_ = JNIEnv.GetMethodID (class_ref, "printerSelfChecking", "(Lwoyou/aidlservice/jiuiv5/ICallback;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_printerSelfChecking_Lwoyou_aidlservice_jiuiv5_ICallback_, __args);
		}

		static Delegate cb_sendLCDBitmap_Landroid_graphics_Bitmap_Lwoyou_aidlservice_jiuiv5_ILcdCallback_;
#pragma warning disable 0169
		static Delegate GetSendLCDBitmap_Landroid_graphics_Bitmap_Lwoyou_aidlservice_jiuiv5_ILcdCallback_Handler ()
		{
			if (cb_sendLCDBitmap_Landroid_graphics_Bitmap_Lwoyou_aidlservice_jiuiv5_ILcdCallback_ == null)
				cb_sendLCDBitmap_Landroid_graphics_Bitmap_Lwoyou_aidlservice_jiuiv5_ILcdCallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_SendLCDBitmap_Landroid_graphics_Bitmap_Lwoyou_aidlservice_jiuiv5_ILcdCallback_);
			return cb_sendLCDBitmap_Landroid_graphics_Bitmap_Lwoyou_aidlservice_jiuiv5_ILcdCallback_;
		}

		static void n_SendLCDBitmap_Landroid_graphics_Bitmap_Lwoyou_aidlservice_jiuiv5_ILcdCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.IWoyouService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Woyou.Aidlservice.Jiuiv5.ILcdCallback)global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.ILcdCallback> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SendLCDBitmap (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_sendLCDBitmap_Landroid_graphics_Bitmap_Lwoyou_aidlservice_jiuiv5_ILcdCallback_;
		public unsafe void SendLCDBitmap (global::Android.Graphics.Bitmap p0, global::Woyou.Aidlservice.Jiuiv5.ILcdCallback p1)
		{
			if (id_sendLCDBitmap_Landroid_graphics_Bitmap_Lwoyou_aidlservice_jiuiv5_ILcdCallback_ == IntPtr.Zero)
				id_sendLCDBitmap_Landroid_graphics_Bitmap_Lwoyou_aidlservice_jiuiv5_ILcdCallback_ = JNIEnv.GetMethodID (class_ref, "sendLCDBitmap", "(Landroid/graphics/Bitmap;Lwoyou/aidlservice/jiuiv5/ILcdCallback;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendLCDBitmap_Landroid_graphics_Bitmap_Lwoyou_aidlservice_jiuiv5_ILcdCallback_, __args);
		}

		static Delegate cb_sendLCDCommand_I;
#pragma warning disable 0169
		static Delegate GetSendLCDCommand_IHandler ()
		{
			if (cb_sendLCDCommand_I == null)
				cb_sendLCDCommand_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SendLCDCommand_I);
			return cb_sendLCDCommand_I;
		}

		static void n_SendLCDCommand_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.IWoyouService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SendLCDCommand (p0);
		}
#pragma warning restore 0169

		IntPtr id_sendLCDCommand_I;
		public unsafe void SendLCDCommand (int p0)
		{
			if (id_sendLCDCommand_I == IntPtr.Zero)
				id_sendLCDCommand_I = JNIEnv.GetMethodID (class_ref, "sendLCDCommand", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendLCDCommand_I, __args);
		}

		static Delegate cb_sendLCDDoubleString_Ljava_lang_String_Ljava_lang_String_Lwoyou_aidlservice_jiuiv5_ILcdCallback_;
#pragma warning disable 0169
		static Delegate GetSendLCDDoubleString_Ljava_lang_String_Ljava_lang_String_Lwoyou_aidlservice_jiuiv5_ILcdCallback_Handler ()
		{
			if (cb_sendLCDDoubleString_Ljava_lang_String_Ljava_lang_String_Lwoyou_aidlservice_jiuiv5_ILcdCallback_ == null)
				cb_sendLCDDoubleString_Ljava_lang_String_Ljava_lang_String_Lwoyou_aidlservice_jiuiv5_ILcdCallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_SendLCDDoubleString_Ljava_lang_String_Ljava_lang_String_Lwoyou_aidlservice_jiuiv5_ILcdCallback_);
			return cb_sendLCDDoubleString_Ljava_lang_String_Ljava_lang_String_Lwoyou_aidlservice_jiuiv5_ILcdCallback_;
		}

		static void n_SendLCDDoubleString_Ljava_lang_String_Ljava_lang_String_Lwoyou_aidlservice_jiuiv5_ILcdCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.IWoyouService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = (global::Woyou.Aidlservice.Jiuiv5.ILcdCallback)global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.ILcdCallback> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.SendLCDDoubleString (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_sendLCDDoubleString_Ljava_lang_String_Ljava_lang_String_Lwoyou_aidlservice_jiuiv5_ILcdCallback_;
		public unsafe void SendLCDDoubleString (string p0, string p1, global::Woyou.Aidlservice.Jiuiv5.ILcdCallback p2)
		{
			if (id_sendLCDDoubleString_Ljava_lang_String_Ljava_lang_String_Lwoyou_aidlservice_jiuiv5_ILcdCallback_ == IntPtr.Zero)
				id_sendLCDDoubleString_Ljava_lang_String_Ljava_lang_String_Lwoyou_aidlservice_jiuiv5_ILcdCallback_ = JNIEnv.GetMethodID (class_ref, "sendLCDDoubleString", "(Ljava/lang/String;Ljava/lang/String;Lwoyou/aidlservice/jiuiv5/ILcdCallback;)V");
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			IntPtr native_p1 = JNIEnv.NewString ((string)p1);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendLCDDoubleString_Ljava_lang_String_Ljava_lang_String_Lwoyou_aidlservice_jiuiv5_ILcdCallback_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_sendLCDFillString_Ljava_lang_String_IZLwoyou_aidlservice_jiuiv5_ILcdCallback_;
#pragma warning disable 0169
		static Delegate GetSendLCDFillString_Ljava_lang_String_IZLwoyou_aidlservice_jiuiv5_ILcdCallback_Handler ()
		{
			if (cb_sendLCDFillString_Ljava_lang_String_IZLwoyou_aidlservice_jiuiv5_ILcdCallback_ == null)
				cb_sendLCDFillString_Ljava_lang_String_IZLwoyou_aidlservice_jiuiv5_ILcdCallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLIZL_V) n_SendLCDFillString_Ljava_lang_String_IZLwoyou_aidlservice_jiuiv5_ILcdCallback_);
			return cb_sendLCDFillString_Ljava_lang_String_IZLwoyou_aidlservice_jiuiv5_ILcdCallback_;
		}

		static void n_SendLCDFillString_Ljava_lang_String_IZLwoyou_aidlservice_jiuiv5_ILcdCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, bool p2, IntPtr native_p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.IWoyouService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p3 = (global::Woyou.Aidlservice.Jiuiv5.ILcdCallback)global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.ILcdCallback> (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.SendLCDFillString (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		IntPtr id_sendLCDFillString_Ljava_lang_String_IZLwoyou_aidlservice_jiuiv5_ILcdCallback_;
		public unsafe void SendLCDFillString (string p0, int p1, bool p2, global::Woyou.Aidlservice.Jiuiv5.ILcdCallback p3)
		{
			if (id_sendLCDFillString_Ljava_lang_String_IZLwoyou_aidlservice_jiuiv5_ILcdCallback_ == IntPtr.Zero)
				id_sendLCDFillString_Ljava_lang_String_IZLwoyou_aidlservice_jiuiv5_ILcdCallback_ = JNIEnv.GetMethodID (class_ref, "sendLCDFillString", "(Ljava/lang/String;IZLwoyou/aidlservice/jiuiv5/ILcdCallback;)V");
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendLCDFillString_Ljava_lang_String_IZLwoyou_aidlservice_jiuiv5_ILcdCallback_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_sendLCDMultiString_arrayLjava_lang_String_arrayILwoyou_aidlservice_jiuiv5_ILcdCallback_;
#pragma warning disable 0169
		static Delegate GetSendLCDMultiString_arrayLjava_lang_String_arrayILwoyou_aidlservice_jiuiv5_ILcdCallback_Handler ()
		{
			if (cb_sendLCDMultiString_arrayLjava_lang_String_arrayILwoyou_aidlservice_jiuiv5_ILcdCallback_ == null)
				cb_sendLCDMultiString_arrayLjava_lang_String_arrayILwoyou_aidlservice_jiuiv5_ILcdCallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_SendLCDMultiString_arrayLjava_lang_String_arrayILwoyou_aidlservice_jiuiv5_ILcdCallback_);
			return cb_sendLCDMultiString_arrayLjava_lang_String_arrayILwoyou_aidlservice_jiuiv5_ILcdCallback_;
		}

		static void n_SendLCDMultiString_arrayLjava_lang_String_arrayILwoyou_aidlservice_jiuiv5_ILcdCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.IWoyouService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (string[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (string));
			var p1 = (int[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (int));
			var p2 = (global::Woyou.Aidlservice.Jiuiv5.ILcdCallback)global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.ILcdCallback> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.SendLCDMultiString (p0, p1, p2);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
		}
#pragma warning restore 0169

		IntPtr id_sendLCDMultiString_arrayLjava_lang_String_arrayILwoyou_aidlservice_jiuiv5_ILcdCallback_;
		public unsafe void SendLCDMultiString (string[] p0, int[] p1, global::Woyou.Aidlservice.Jiuiv5.ILcdCallback p2)
		{
			if (id_sendLCDMultiString_arrayLjava_lang_String_arrayILwoyou_aidlservice_jiuiv5_ILcdCallback_ == IntPtr.Zero)
				id_sendLCDMultiString_arrayLjava_lang_String_arrayILwoyou_aidlservice_jiuiv5_ILcdCallback_ = JNIEnv.GetMethodID (class_ref, "sendLCDMultiString", "([Ljava/lang/String;[ILwoyou/aidlservice/jiuiv5/ILcdCallback;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendLCDMultiString_arrayLjava_lang_String_arrayILwoyou_aidlservice_jiuiv5_ILcdCallback_, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_sendLCDString_Ljava_lang_String_Lwoyou_aidlservice_jiuiv5_ILcdCallback_;
#pragma warning disable 0169
		static Delegate GetSendLCDString_Ljava_lang_String_Lwoyou_aidlservice_jiuiv5_ILcdCallback_Handler ()
		{
			if (cb_sendLCDString_Ljava_lang_String_Lwoyou_aidlservice_jiuiv5_ILcdCallback_ == null)
				cb_sendLCDString_Ljava_lang_String_Lwoyou_aidlservice_jiuiv5_ILcdCallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_SendLCDString_Ljava_lang_String_Lwoyou_aidlservice_jiuiv5_ILcdCallback_);
			return cb_sendLCDString_Ljava_lang_String_Lwoyou_aidlservice_jiuiv5_ILcdCallback_;
		}

		static void n_SendLCDString_Ljava_lang_String_Lwoyou_aidlservice_jiuiv5_ILcdCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.IWoyouService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Woyou.Aidlservice.Jiuiv5.ILcdCallback)global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.ILcdCallback> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SendLCDString (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_sendLCDString_Ljava_lang_String_Lwoyou_aidlservice_jiuiv5_ILcdCallback_;
		public unsafe void SendLCDString (string p0, global::Woyou.Aidlservice.Jiuiv5.ILcdCallback p1)
		{
			if (id_sendLCDString_Ljava_lang_String_Lwoyou_aidlservice_jiuiv5_ILcdCallback_ == IntPtr.Zero)
				id_sendLCDString_Ljava_lang_String_Lwoyou_aidlservice_jiuiv5_ILcdCallback_ = JNIEnv.GetMethodID (class_ref, "sendLCDString", "(Ljava/lang/String;Lwoyou/aidlservice/jiuiv5/ILcdCallback;)V");
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendLCDString_Ljava_lang_String_Lwoyou_aidlservice_jiuiv5_ILcdCallback_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_sendRAWData_arrayBLwoyou_aidlservice_jiuiv5_ICallback_;
#pragma warning disable 0169
		static Delegate GetSendRAWData_arrayBLwoyou_aidlservice_jiuiv5_ICallback_Handler ()
		{
			if (cb_sendRAWData_arrayBLwoyou_aidlservice_jiuiv5_ICallback_ == null)
				cb_sendRAWData_arrayBLwoyou_aidlservice_jiuiv5_ICallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_SendRAWData_arrayBLwoyou_aidlservice_jiuiv5_ICallback_);
			return cb_sendRAWData_arrayBLwoyou_aidlservice_jiuiv5_ICallback_;
		}

		static void n_SendRAWData_arrayBLwoyou_aidlservice_jiuiv5_ICallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.IWoyouService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p1 = (global::Woyou.Aidlservice.Jiuiv5.ICallback)global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.ICallback> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SendRAWData (p0, p1);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		IntPtr id_sendRAWData_arrayBLwoyou_aidlservice_jiuiv5_ICallback_;
		public unsafe void SendRAWData (byte[] p0, global::Woyou.Aidlservice.Jiuiv5.ICallback p1)
		{
			if (id_sendRAWData_arrayBLwoyou_aidlservice_jiuiv5_ICallback_ == IntPtr.Zero)
				id_sendRAWData_arrayBLwoyou_aidlservice_jiuiv5_ICallback_ = JNIEnv.GetMethodID (class_ref, "sendRAWData", "([BLwoyou/aidlservice/jiuiv5/ICallback;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendRAWData_arrayBLwoyou_aidlservice_jiuiv5_ICallback_, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setAlignment_ILwoyou_aidlservice_jiuiv5_ICallback_;
#pragma warning disable 0169
		static Delegate GetSetAlignment_ILwoyou_aidlservice_jiuiv5_ICallback_Handler ()
		{
			if (cb_setAlignment_ILwoyou_aidlservice_jiuiv5_ICallback_ == null)
				cb_setAlignment_ILwoyou_aidlservice_jiuiv5_ICallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIL_V) n_SetAlignment_ILwoyou_aidlservice_jiuiv5_ICallback_);
			return cb_setAlignment_ILwoyou_aidlservice_jiuiv5_ICallback_;
		}

		static void n_SetAlignment_ILwoyou_aidlservice_jiuiv5_ICallback_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.IWoyouService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Woyou.Aidlservice.Jiuiv5.ICallback)global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.ICallback> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetAlignment (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_setAlignment_ILwoyou_aidlservice_jiuiv5_ICallback_;
		public unsafe void SetAlignment (int p0, global::Woyou.Aidlservice.Jiuiv5.ICallback p1)
		{
			if (id_setAlignment_ILwoyou_aidlservice_jiuiv5_ICallback_ == IntPtr.Zero)
				id_setAlignment_ILwoyou_aidlservice_jiuiv5_ICallback_ = JNIEnv.GetMethodID (class_ref, "setAlignment", "(ILwoyou/aidlservice/jiuiv5/ICallback;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAlignment_ILwoyou_aidlservice_jiuiv5_ICallback_, __args);
		}

		static Delegate cb_setFontName_Ljava_lang_String_Lwoyou_aidlservice_jiuiv5_ICallback_;
#pragma warning disable 0169
		static Delegate GetSetFontName_Ljava_lang_String_Lwoyou_aidlservice_jiuiv5_ICallback_Handler ()
		{
			if (cb_setFontName_Ljava_lang_String_Lwoyou_aidlservice_jiuiv5_ICallback_ == null)
				cb_setFontName_Ljava_lang_String_Lwoyou_aidlservice_jiuiv5_ICallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_SetFontName_Ljava_lang_String_Lwoyou_aidlservice_jiuiv5_ICallback_);
			return cb_setFontName_Ljava_lang_String_Lwoyou_aidlservice_jiuiv5_ICallback_;
		}

		static void n_SetFontName_Ljava_lang_String_Lwoyou_aidlservice_jiuiv5_ICallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.IWoyouService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Woyou.Aidlservice.Jiuiv5.ICallback)global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.ICallback> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetFontName (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_setFontName_Ljava_lang_String_Lwoyou_aidlservice_jiuiv5_ICallback_;
		public unsafe void SetFontName (string p0, global::Woyou.Aidlservice.Jiuiv5.ICallback p1)
		{
			if (id_setFontName_Ljava_lang_String_Lwoyou_aidlservice_jiuiv5_ICallback_ == IntPtr.Zero)
				id_setFontName_Ljava_lang_String_Lwoyou_aidlservice_jiuiv5_ICallback_ = JNIEnv.GetMethodID (class_ref, "setFontName", "(Ljava/lang/String;Lwoyou/aidlservice/jiuiv5/ICallback;)V");
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setFontName_Ljava_lang_String_Lwoyou_aidlservice_jiuiv5_ICallback_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_setFontSize_FLwoyou_aidlservice_jiuiv5_ICallback_;
#pragma warning disable 0169
		static Delegate GetSetFontSize_FLwoyou_aidlservice_jiuiv5_ICallback_Handler ()
		{
			if (cb_setFontSize_FLwoyou_aidlservice_jiuiv5_ICallback_ == null)
				cb_setFontSize_FLwoyou_aidlservice_jiuiv5_ICallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPFL_V) n_SetFontSize_FLwoyou_aidlservice_jiuiv5_ICallback_);
			return cb_setFontSize_FLwoyou_aidlservice_jiuiv5_ICallback_;
		}

		static void n_SetFontSize_FLwoyou_aidlservice_jiuiv5_ICallback_ (IntPtr jnienv, IntPtr native__this, float p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.IWoyouService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Woyou.Aidlservice.Jiuiv5.ICallback)global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.ICallback> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetFontSize (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_setFontSize_FLwoyou_aidlservice_jiuiv5_ICallback_;
		public unsafe void SetFontSize (float p0, global::Woyou.Aidlservice.Jiuiv5.ICallback p1)
		{
			if (id_setFontSize_FLwoyou_aidlservice_jiuiv5_ICallback_ == IntPtr.Zero)
				id_setFontSize_FLwoyou_aidlservice_jiuiv5_ICallback_ = JNIEnv.GetMethodID (class_ref, "setFontSize", "(FLwoyou/aidlservice/jiuiv5/ICallback;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setFontSize_FLwoyou_aidlservice_jiuiv5_ICallback_, __args);
		}

		static Delegate cb_tax_arrayBLwoyou_aidlservice_jiuiv5_ITax_;
#pragma warning disable 0169
		static Delegate GetTax_arrayBLwoyou_aidlservice_jiuiv5_ITax_Handler ()
		{
			if (cb_tax_arrayBLwoyou_aidlservice_jiuiv5_ITax_ == null)
				cb_tax_arrayBLwoyou_aidlservice_jiuiv5_ITax_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_Tax_arrayBLwoyou_aidlservice_jiuiv5_ITax_);
			return cb_tax_arrayBLwoyou_aidlservice_jiuiv5_ITax_;
		}

		static void n_Tax_arrayBLwoyou_aidlservice_jiuiv5_ITax_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.IWoyouService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p1 = (global::Woyou.Aidlservice.Jiuiv5.ITax)global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.ITax> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Tax (p0, p1);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		IntPtr id_tax_arrayBLwoyou_aidlservice_jiuiv5_ITax_;
		public unsafe void Tax (byte[] p0, global::Woyou.Aidlservice.Jiuiv5.ITax p1)
		{
			if (id_tax_arrayBLwoyou_aidlservice_jiuiv5_ITax_ == IntPtr.Zero)
				id_tax_arrayBLwoyou_aidlservice_jiuiv5_ITax_ = JNIEnv.GetMethodID (class_ref, "tax", "([BLwoyou/aidlservice/jiuiv5/ITax;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_tax_arrayBLwoyou_aidlservice_jiuiv5_ITax_, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_updatePrinterState;
#pragma warning disable 0169
		static Delegate GetUpdatePrinterStateHandler ()
		{
			if (cb_updatePrinterState == null)
				cb_updatePrinterState = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_UpdatePrinterState);
			return cb_updatePrinterState;
		}

		static int n_UpdatePrinterState (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.IWoyouService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.UpdatePrinterState ();
		}
#pragma warning restore 0169

		IntPtr id_updatePrinterState;
		public unsafe int UpdatePrinterState ()
		{
			if (id_updatePrinterState == IntPtr.Zero)
				id_updatePrinterState = JNIEnv.GetMethodID (class_ref, "updatePrinterState", "()I");
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_updatePrinterState);
		}

		static Delegate cb_asBinder;
#pragma warning disable 0169
		static Delegate GetAsBinderHandler ()
		{
			if (cb_asBinder == null)
				cb_asBinder = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_AsBinder);
			return cb_asBinder;
		}

		static IntPtr n_AsBinder (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Woyou.Aidlservice.Jiuiv5.IWoyouService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
		}
#pragma warning restore 0169

		IntPtr id_asBinder;
		public unsafe global::Android.OS.IBinder AsBinder ()
		{
			if (id_asBinder == IntPtr.Zero)
				id_asBinder = JNIEnv.GetMethodID (class_ref, "asBinder", "()Landroid/os/IBinder;");
			return global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_asBinder), JniHandleOwnership.TransferLocalRef);
		}

	}
}
