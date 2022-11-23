using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Sunmi.Idcardservice {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.sunmi.idcardservice']/class[@name='MiFareCardAidl.Default']"
	[global::Android.Runtime.Register ("com/sunmi/idcardservice/MiFareCardAidl$Default", DoNotGenerateAcw=true)]
	public partial class MiFareCardAidlDefault : global::Java.Lang.Object, global::Com.Sunmi.Idcardservice.IMiFareCardAidl {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/sunmi/idcardservice/MiFareCardAidl$Default", typeof (MiFareCardAidlDefault));

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

		protected MiFareCardAidlDefault (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.sunmi.idcardservice']/class[@name='MiFareCardAidl.Default']/constructor[@name='MiFareCardAidl.Default' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MiFareCardAidlDefault () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Sunmi.Idcardservice.MiFareCardAidlDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.sunmi.idcardservice']/class[@name='MiFareCardAidl.Default']/method[@name='asBinder' and count(parameter)=0]"
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

		static Delegate cb_beep_I;
#pragma warning disable 0169
		static Delegate GetBeep_IHandler ()
		{
			if (cb_beep_I == null)
				cb_beep_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_I) n_Beep_I);
			return cb_beep_I;
		}

		static int n_Beep_I (IntPtr jnienv, IntPtr native__this, int delaytime)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Sunmi.Idcardservice.MiFareCardAidlDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Beep (delaytime);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.sunmi.idcardservice']/class[@name='MiFareCardAidl.Default']/method[@name='beep' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("beep", "(I)I", "GetBeep_IHandler")]
		public virtual unsafe int Beep (int delaytime)
		{
			const string __id = "beep.(I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (delaytime);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_exchangePro_arrayBIarrayBarrayI;
#pragma warning disable 0169
		static Delegate GetExchangePro_arrayBIarrayBarrayIHandler ()
		{
			if (cb_exchangePro_arrayBIarrayBarrayI == null)
				cb_exchangePro_arrayBIarrayBarrayI = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLILL_I) n_ExchangePro_arrayBIarrayBarrayI);
			return cb_exchangePro_arrayBIarrayBarrayI;
		}

		static int n_ExchangePro_arrayBIarrayBarrayI (IntPtr jnienv, IntPtr native__this, IntPtr native_cmd, int cmdlen, IntPtr native_resp, IntPtr native_resplen)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Sunmi.Idcardservice.MiFareCardAidlDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var cmd = (byte[]) JNIEnv.GetArray (native_cmd, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var resp = (byte[]) JNIEnv.GetArray (native_resp, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var resplen = (int[]) JNIEnv.GetArray (native_resplen, JniHandleOwnership.DoNotTransfer, typeof (int));
			int __ret = __this.ExchangePro (cmd, cmdlen, resp, resplen);
			if (cmd != null)
				JNIEnv.CopyArray (cmd, native_cmd);
			if (resp != null)
				JNIEnv.CopyArray (resp, native_resp);
			if (resplen != null)
				JNIEnv.CopyArray (resplen, native_resplen);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.sunmi.idcardservice']/class[@name='MiFareCardAidl.Default']/method[@name='exchangePro' and count(parameter)=4 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='byte[]'] and parameter[4][@type='int[]']]"
		[Register ("exchangePro", "([BI[B[I)I", "GetExchangePro_arrayBIarrayBarrayIHandler")]
		public virtual unsafe int ExchangePro (byte[] cmd, int cmdlen, byte[] resp, int[] resplen)
		{
			const string __id = "exchangePro.([BI[B[I)I";
			IntPtr native_cmd = JNIEnv.NewArray (cmd);
			IntPtr native_resp = JNIEnv.NewArray (resp);
			IntPtr native_resplen = JNIEnv.NewArray (resplen);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_cmd);
				__args [1] = new JniArgumentValue (cmdlen);
				__args [2] = new JniArgumentValue (native_resp);
				__args [3] = new JniArgumentValue (native_resplen);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				if (cmd != null) {
					JNIEnv.CopyArray (native_cmd, cmd);
					JNIEnv.DeleteLocalRef (native_cmd);
				}
				if (resp != null) {
					JNIEnv.CopyArray (native_resp, resp);
					JNIEnv.DeleteLocalRef (native_resp);
				}
				if (resplen != null) {
					JNIEnv.CopyArray (native_resplen, resplen);
					JNIEnv.DeleteLocalRef (native_resplen);
				}
				global::System.GC.KeepAlive (cmd);
				global::System.GC.KeepAlive (resp);
				global::System.GC.KeepAlive (resplen);
			}
		}

		static Delegate cb_getCPUCardState_arrayB;
#pragma warning disable 0169
		static Delegate GetGetCPUCardState_arrayBHandler ()
		{
			if (cb_getCPUCardState_arrayB == null)
				cb_getCPUCardState_arrayB = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_I) n_GetCPUCardState_arrayB);
			return cb_getCPUCardState_arrayB;
		}

		static int n_GetCPUCardState_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_cardState)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Sunmi.Idcardservice.MiFareCardAidlDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var cardState = (byte[]) JNIEnv.GetArray (native_cardState, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.GetCPUCardState (cardState);
			if (cardState != null)
				JNIEnv.CopyArray (cardState, native_cardState);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.sunmi.idcardservice']/class[@name='MiFareCardAidl.Default']/method[@name='getCPUCardState' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("getCPUCardState", "([B)I", "GetGetCPUCardState_arrayBHandler")]
		public virtual unsafe int GetCPUCardState (byte[] cardState)
		{
			const string __id = "getCPUCardState.([B)I";
			IntPtr native_cardState = JNIEnv.NewArray (cardState);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_cardState);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				if (cardState != null) {
					JNIEnv.CopyArray (native_cardState, cardState);
					JNIEnv.DeleteLocalRef (native_cardState);
				}
				global::System.GC.KeepAlive (cardState);
			}
		}

		static Delegate cb_getEMID_arrayBarrayB;
#pragma warning disable 0169
		static Delegate GetGetEMID_arrayBarrayBHandler ()
		{
			if (cb_getEMID_arrayBarrayB == null)
				cb_getEMID_arrayBarrayB = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_I) n_GetEMID_arrayBarrayB);
			return cb_getEMID_arrayBarrayB;
		}

		static int n_GetEMID_arrayBarrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_datalen, IntPtr native_data)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Sunmi.Idcardservice.MiFareCardAidlDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var datalen = (byte[]) JNIEnv.GetArray (native_datalen, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var data = (byte[]) JNIEnv.GetArray (native_data, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.GetEMID (datalen, data);
			if (datalen != null)
				JNIEnv.CopyArray (datalen, native_datalen);
			if (data != null)
				JNIEnv.CopyArray (data, native_data);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.sunmi.idcardservice']/class[@name='MiFareCardAidl.Default']/method[@name='getEMID' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]']]"
		[Register ("getEMID", "([B[B)I", "GetGetEMID_arrayBarrayBHandler")]
		public virtual unsafe int GetEMID (byte[] datalen, byte[] data)
		{
			const string __id = "getEMID.([B[B)I";
			IntPtr native_datalen = JNIEnv.NewArray (datalen);
			IntPtr native_data = JNIEnv.NewArray (data);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_datalen);
				__args [1] = new JniArgumentValue (native_data);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				if (datalen != null) {
					JNIEnv.CopyArray (native_datalen, datalen);
					JNIEnv.DeleteLocalRef (native_datalen);
				}
				if (data != null) {
					JNIEnv.CopyArray (native_data, data);
					JNIEnv.DeleteLocalRef (native_data);
				}
				global::System.GC.KeepAlive (datalen);
				global::System.GC.KeepAlive (data);
			}
		}

		static Delegate cb_openCupCard_arrayBarrayBarrayBarrayBarrayB;
#pragma warning disable 0169
		static Delegate GetOpenCupCard_arrayBarrayBarrayBarrayBarrayBHandler ()
		{
			if (cb_openCupCard_arrayBarrayBarrayBarrayBarrayB == null)
				cb_openCupCard_arrayBarrayBarrayBarrayBarrayB = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLLL_I) n_OpenCupCard_arrayBarrayBarrayBarrayBarrayB);
			return cb_openCupCard_arrayBarrayBarrayBarrayBarrayB;
		}

		static int n_OpenCupCard_arrayBarrayBarrayBarrayBarrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_cardtype, IntPtr native_snrlen, IntPtr native_snr, IntPtr native_atrlen, IntPtr native_atr)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Sunmi.Idcardservice.MiFareCardAidlDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var cardtype = (byte[]) JNIEnv.GetArray (native_cardtype, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var snrlen = (byte[]) JNIEnv.GetArray (native_snrlen, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var snr = (byte[]) JNIEnv.GetArray (native_snr, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var atrlen = (byte[]) JNIEnv.GetArray (native_atrlen, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var atr = (byte[]) JNIEnv.GetArray (native_atr, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.OpenCupCard (cardtype, snrlen, snr, atrlen, atr);
			if (cardtype != null)
				JNIEnv.CopyArray (cardtype, native_cardtype);
			if (snrlen != null)
				JNIEnv.CopyArray (snrlen, native_snrlen);
			if (snr != null)
				JNIEnv.CopyArray (snr, native_snr);
			if (atrlen != null)
				JNIEnv.CopyArray (atrlen, native_atrlen);
			if (atr != null)
				JNIEnv.CopyArray (atr, native_atr);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.sunmi.idcardservice']/class[@name='MiFareCardAidl.Default']/method[@name='openCupCard' and count(parameter)=5 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]'] and parameter[3][@type='byte[]'] and parameter[4][@type='byte[]'] and parameter[5][@type='byte[]']]"
		[Register ("openCupCard", "([B[B[B[B[B)I", "GetOpenCupCard_arrayBarrayBarrayBarrayBarrayBHandler")]
		public virtual unsafe int OpenCupCard (byte[] cardtype, byte[] snrlen, byte[] snr, byte[] atrlen, byte[] atr)
		{
			const string __id = "openCupCard.([B[B[B[B[B)I";
			IntPtr native_cardtype = JNIEnv.NewArray (cardtype);
			IntPtr native_snrlen = JNIEnv.NewArray (snrlen);
			IntPtr native_snr = JNIEnv.NewArray (snr);
			IntPtr native_atrlen = JNIEnv.NewArray (atrlen);
			IntPtr native_atr = JNIEnv.NewArray (atr);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (native_cardtype);
				__args [1] = new JniArgumentValue (native_snrlen);
				__args [2] = new JniArgumentValue (native_snr);
				__args [3] = new JniArgumentValue (native_atrlen);
				__args [4] = new JniArgumentValue (native_atr);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				if (cardtype != null) {
					JNIEnv.CopyArray (native_cardtype, cardtype);
					JNIEnv.DeleteLocalRef (native_cardtype);
				}
				if (snrlen != null) {
					JNIEnv.CopyArray (native_snrlen, snrlen);
					JNIEnv.DeleteLocalRef (native_snrlen);
				}
				if (snr != null) {
					JNIEnv.CopyArray (native_snr, snr);
					JNIEnv.DeleteLocalRef (native_snr);
				}
				if (atrlen != null) {
					JNIEnv.CopyArray (native_atrlen, atrlen);
					JNIEnv.DeleteLocalRef (native_atrlen);
				}
				if (atr != null) {
					JNIEnv.CopyArray (native_atr, atr);
					JNIEnv.DeleteLocalRef (native_atr);
				}
				global::System.GC.KeepAlive (cardtype);
				global::System.GC.KeepAlive (snrlen);
				global::System.GC.KeepAlive (snr);
				global::System.GC.KeepAlive (atrlen);
				global::System.GC.KeepAlive (atr);
			}
		}

		static Delegate cb_readNAN_IarrayBarrayBarrayB;
#pragma warning disable 0169
		static Delegate GetReadNAN_IarrayBarrayBarrayBHandler ()
		{
			if (cb_readNAN_IarrayBarrayBarrayB == null)
				cb_readNAN_IarrayBarrayBarrayB = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPILLL_I) n_ReadNAN_IarrayBarrayBarrayB);
			return cb_readNAN_IarrayBarrayBarrayB;
		}

		static int n_ReadNAN_IarrayBarrayBarrayB (IntPtr jnienv, IntPtr native__this, int nCardType, IntPtr native_Cardno, IntPtr native_CardName, IntPtr native_lpErrMsg)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Sunmi.Idcardservice.MiFareCardAidlDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var Cardno = (byte[]) JNIEnv.GetArray (native_Cardno, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var CardName = (byte[]) JNIEnv.GetArray (native_CardName, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var lpErrMsg = (byte[]) JNIEnv.GetArray (native_lpErrMsg, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.ReadNAN (nCardType, Cardno, CardName, lpErrMsg);
			if (Cardno != null)
				JNIEnv.CopyArray (Cardno, native_Cardno);
			if (CardName != null)
				JNIEnv.CopyArray (CardName, native_CardName);
			if (lpErrMsg != null)
				JNIEnv.CopyArray (lpErrMsg, native_lpErrMsg);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.sunmi.idcardservice']/class[@name='MiFareCardAidl.Default']/method[@name='readNAN' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='byte[]'] and parameter[3][@type='byte[]'] and parameter[4][@type='byte[]']]"
		[Register ("readNAN", "(I[B[B[B)I", "GetReadNAN_IarrayBarrayBarrayBHandler")]
		public virtual unsafe int ReadNAN (int nCardType, byte[] Cardno, byte[] CardName, byte[] lpErrMsg)
		{
			const string __id = "readNAN.(I[B[B[B)I";
			IntPtr native_Cardno = JNIEnv.NewArray (Cardno);
			IntPtr native_CardName = JNIEnv.NewArray (CardName);
			IntPtr native_lpErrMsg = JNIEnv.NewArray (lpErrMsg);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (nCardType);
				__args [1] = new JniArgumentValue (native_Cardno);
				__args [2] = new JniArgumentValue (native_CardName);
				__args [3] = new JniArgumentValue (native_lpErrMsg);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				if (Cardno != null) {
					JNIEnv.CopyArray (native_Cardno, Cardno);
					JNIEnv.DeleteLocalRef (native_Cardno);
				}
				if (CardName != null) {
					JNIEnv.CopyArray (native_CardName, CardName);
					JNIEnv.DeleteLocalRef (native_CardName);
				}
				if (lpErrMsg != null) {
					JNIEnv.CopyArray (native_lpErrMsg, lpErrMsg);
					JNIEnv.DeleteLocalRef (native_lpErrMsg);
				}
				global::System.GC.KeepAlive (Cardno);
				global::System.GC.KeepAlive (CardName);
				global::System.GC.KeepAlive (lpErrMsg);
			}
		}

		static Delegate cb_readSBInfo_arrayBarrayB;
#pragma warning disable 0169
		static Delegate GetReadSBInfo_arrayBarrayBHandler ()
		{
			if (cb_readSBInfo_arrayBarrayB == null)
				cb_readSBInfo_arrayBarrayB = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_I) n_ReadSBInfo_arrayBarrayB);
			return cb_readSBInfo_arrayBarrayB;
		}

		static int n_ReadSBInfo_arrayBarrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_info, IntPtr native_err)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Sunmi.Idcardservice.MiFareCardAidlDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var info = (byte[]) JNIEnv.GetArray (native_info, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var err = (byte[]) JNIEnv.GetArray (native_err, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.ReadSBInfo (info, err);
			if (info != null)
				JNIEnv.CopyArray (info, native_info);
			if (err != null)
				JNIEnv.CopyArray (err, native_err);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.sunmi.idcardservice']/class[@name='MiFareCardAidl.Default']/method[@name='readSBInfo' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]']]"
		[Register ("readSBInfo", "([B[B)I", "GetReadSBInfo_arrayBarrayBHandler")]
		public virtual unsafe int ReadSBInfo (byte[] info, byte[] err)
		{
			const string __id = "readSBInfo.([B[B)I";
			IntPtr native_info = JNIEnv.NewArray (info);
			IntPtr native_err = JNIEnv.NewArray (err);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_info);
				__args [1] = new JniArgumentValue (native_err);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				if (info != null) {
					JNIEnv.CopyArray (native_info, info);
					JNIEnv.DeleteLocalRef (native_info);
				}
				if (err != null) {
					JNIEnv.CopyArray (native_err, err);
					JNIEnv.DeleteLocalRef (native_err);
				}
				global::System.GC.KeepAlive (info);
				global::System.GC.KeepAlive (err);
			}
		}

		static Delegate cb_rfAuthEntication_IIarrayB;
#pragma warning disable 0169
		static Delegate GetRfAuthEntication_IIarrayBHandler ()
		{
			if (cb_rfAuthEntication_IIarrayB == null)
				cb_rfAuthEntication_IIarrayB = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIIL_I) n_RfAuthEntication_IIarrayB);
			return cb_rfAuthEntication_IIarrayB;
		}

		static int n_RfAuthEntication_IIarrayB (IntPtr jnienv, IntPtr native__this, int mode, int nsecno, IntPtr native_key)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Sunmi.Idcardservice.MiFareCardAidlDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var key = (byte[]) JNIEnv.GetArray (native_key, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.RfAuthEntication (mode, nsecno, key);
			if (key != null)
				JNIEnv.CopyArray (key, native_key);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.sunmi.idcardservice']/class[@name='MiFareCardAidl.Default']/method[@name='rfAuthEntication' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='byte[]']]"
		[Register ("rfAuthEntication", "(II[B)I", "GetRfAuthEntication_IIarrayBHandler")]
		public virtual unsafe int RfAuthEntication (int mode, int nsecno, byte[] key)
		{
			const string __id = "rfAuthEntication.(II[B)I";
			IntPtr native_key = JNIEnv.NewArray (key);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (mode);
				__args [1] = new JniArgumentValue (nsecno);
				__args [2] = new JniArgumentValue (native_key);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				if (key != null) {
					JNIEnv.CopyArray (native_key, key);
					JNIEnv.DeleteLocalRef (native_key);
				}
				global::System.GC.KeepAlive (key);
			}
		}

		static Delegate cb_rfCard_arrayBarrayB;
#pragma warning disable 0169
		static Delegate GetRfCard_arrayBarrayBHandler ()
		{
			if (cb_rfCard_arrayBarrayB == null)
				cb_rfCard_arrayBarrayB = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_I) n_RfCard_arrayBarrayB);
			return cb_rfCard_arrayBarrayB;
		}

		static int n_RfCard_arrayBarrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_cardtype, IntPtr native_cardID)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Sunmi.Idcardservice.MiFareCardAidlDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var cardtype = (byte[]) JNIEnv.GetArray (native_cardtype, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var cardID = (byte[]) JNIEnv.GetArray (native_cardID, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.RfCard (cardtype, cardID);
			if (cardtype != null)
				JNIEnv.CopyArray (cardtype, native_cardtype);
			if (cardID != null)
				JNIEnv.CopyArray (cardID, native_cardID);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.sunmi.idcardservice']/class[@name='MiFareCardAidl.Default']/method[@name='rfCard' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]']]"
		[Register ("rfCard", "([B[B)I", "GetRfCard_arrayBarrayBHandler")]
		public virtual unsafe int RfCard (byte[] cardtype, byte[] cardID)
		{
			const string __id = "rfCard.([B[B)I";
			IntPtr native_cardtype = JNIEnv.NewArray (cardtype);
			IntPtr native_cardID = JNIEnv.NewArray (cardID);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_cardtype);
				__args [1] = new JniArgumentValue (native_cardID);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				if (cardtype != null) {
					JNIEnv.CopyArray (native_cardtype, cardtype);
					JNIEnv.DeleteLocalRef (native_cardtype);
				}
				if (cardID != null) {
					JNIEnv.CopyArray (native_cardID, cardID);
					JNIEnv.DeleteLocalRef (native_cardID);
				}
				global::System.GC.KeepAlive (cardtype);
				global::System.GC.KeepAlive (cardID);
			}
		}

		static Delegate cb_rfDecrement_II;
#pragma warning disable 0169
		static Delegate GetRfDecrement_IIHandler ()
		{
			if (cb_rfDecrement_II == null)
				cb_rfDecrement_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPII_I) n_RfDecrement_II);
			return cb_rfDecrement_II;
		}

		static int n_RfDecrement_II (IntPtr jnienv, IntPtr native__this, int nblock, int decvalue)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Sunmi.Idcardservice.MiFareCardAidlDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RfDecrement (nblock, decvalue);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.sunmi.idcardservice']/class[@name='MiFareCardAidl.Default']/method[@name='rfDecrement' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("rfDecrement", "(II)I", "GetRfDecrement_IIHandler")]
		public virtual unsafe int RfDecrement (int nblock, int decvalue)
		{
			const string __id = "rfDecrement.(II)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (nblock);
				__args [1] = new JniArgumentValue (decvalue);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_rfIncrement_II;
#pragma warning disable 0169
		static Delegate GetRfIncrement_IIHandler ()
		{
			if (cb_rfIncrement_II == null)
				cb_rfIncrement_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPII_I) n_RfIncrement_II);
			return cb_rfIncrement_II;
		}

		static int n_RfIncrement_II (IntPtr jnienv, IntPtr native__this, int nblock, int incvalue)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Sunmi.Idcardservice.MiFareCardAidlDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RfIncrement (nblock, incvalue);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.sunmi.idcardservice']/class[@name='MiFareCardAidl.Default']/method[@name='rfIncrement' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("rfIncrement", "(II)I", "GetRfIncrement_IIHandler")]
		public virtual unsafe int RfIncrement (int nblock, int incvalue)
		{
			const string __id = "rfIncrement.(II)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (nblock);
				__args [1] = new JniArgumentValue (incvalue);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_rfInitVal_II;
#pragma warning disable 0169
		static Delegate GetRfInitVal_IIHandler ()
		{
			if (cb_rfInitVal_II == null)
				cb_rfInitVal_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPII_I) n_RfInitVal_II);
			return cb_rfInitVal_II;
		}

		static int n_RfInitVal_II (IntPtr jnienv, IntPtr native__this, int nblock, int writevalue)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Sunmi.Idcardservice.MiFareCardAidlDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RfInitVal (nblock, writevalue);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.sunmi.idcardservice']/class[@name='MiFareCardAidl.Default']/method[@name='rfInitVal' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("rfInitVal", "(II)I", "GetRfInitVal_IIHandler")]
		public virtual unsafe int RfInitVal (int nblock, int writevalue)
		{
			const string __id = "rfInitVal.(II)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (nblock);
				__args [1] = new JniArgumentValue (writevalue);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_rfRead_IarrayB;
#pragma warning disable 0169
		static Delegate GetRfRead_IarrayBHandler ()
		{
			if (cb_rfRead_IarrayB == null)
				cb_rfRead_IarrayB = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIL_I) n_RfRead_IarrayB);
			return cb_rfRead_IarrayB;
		}

		static int n_RfRead_IarrayB (IntPtr jnienv, IntPtr native__this, int nblock, IntPtr native_readdata)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Sunmi.Idcardservice.MiFareCardAidlDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var readdata = (byte[]) JNIEnv.GetArray (native_readdata, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.RfRead (nblock, readdata);
			if (readdata != null)
				JNIEnv.CopyArray (readdata, native_readdata);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.sunmi.idcardservice']/class[@name='MiFareCardAidl.Default']/method[@name='rfRead' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='byte[]']]"
		[Register ("rfRead", "(I[B)I", "GetRfRead_IarrayBHandler")]
		public virtual unsafe int RfRead (int nblock, byte[] readdata)
		{
			const string __id = "rfRead.(I[B)I";
			IntPtr native_readdata = JNIEnv.NewArray (readdata);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (nblock);
				__args [1] = new JniArgumentValue (native_readdata);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				if (readdata != null) {
					JNIEnv.CopyArray (native_readdata, readdata);
					JNIEnv.DeleteLocalRef (native_readdata);
				}
				global::System.GC.KeepAlive (readdata);
			}
		}

		static Delegate cb_rfReadVal_IarrayI;
#pragma warning disable 0169
		static Delegate GetRfReadVal_IarrayIHandler ()
		{
			if (cb_rfReadVal_IarrayI == null)
				cb_rfReadVal_IarrayI = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIL_I) n_RfReadVal_IarrayI);
			return cb_rfReadVal_IarrayI;
		}

		static int n_RfReadVal_IarrayI (IntPtr jnienv, IntPtr native__this, int nblock, IntPtr native_readvalue)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Sunmi.Idcardservice.MiFareCardAidlDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var readvalue = (int[]) JNIEnv.GetArray (native_readvalue, JniHandleOwnership.DoNotTransfer, typeof (int));
			int __ret = __this.RfReadVal (nblock, readvalue);
			if (readvalue != null)
				JNIEnv.CopyArray (readvalue, native_readvalue);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.sunmi.idcardservice']/class[@name='MiFareCardAidl.Default']/method[@name='rfReadVal' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int[]']]"
		[Register ("rfReadVal", "(I[I)I", "GetRfReadVal_IarrayIHandler")]
		public virtual unsafe int RfReadVal (int nblock, int[] readvalue)
		{
			const string __id = "rfReadVal.(I[I)I";
			IntPtr native_readvalue = JNIEnv.NewArray (readvalue);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (nblock);
				__args [1] = new JniArgumentValue (native_readvalue);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				if (readvalue != null) {
					JNIEnv.CopyArray (native_readvalue, readvalue);
					JNIEnv.DeleteLocalRef (native_readvalue);
				}
				global::System.GC.KeepAlive (readvalue);
			}
		}

		static Delegate cb_rfWrite_IarrayB;
#pragma warning disable 0169
		static Delegate GetRfWrite_IarrayBHandler ()
		{
			if (cb_rfWrite_IarrayB == null)
				cb_rfWrite_IarrayB = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIL_I) n_RfWrite_IarrayB);
			return cb_rfWrite_IarrayB;
		}

		static int n_RfWrite_IarrayB (IntPtr jnienv, IntPtr native__this, int nblock, IntPtr native_writedata)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Sunmi.Idcardservice.MiFareCardAidlDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var writedata = (byte[]) JNIEnv.GetArray (native_writedata, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.RfWrite (nblock, writedata);
			if (writedata != null)
				JNIEnv.CopyArray (writedata, native_writedata);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.sunmi.idcardservice']/class[@name='MiFareCardAidl.Default']/method[@name='rfWrite' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='byte[]']]"
		[Register ("rfWrite", "(I[B)I", "GetRfWrite_IarrayBHandler")]
		public virtual unsafe int RfWrite (int nblock, byte[] writedata)
		{
			const string __id = "rfWrite.(I[B)I";
			IntPtr native_writedata = JNIEnv.NewArray (writedata);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (nblock);
				__args [1] = new JniArgumentValue (native_writedata);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				if (writedata != null) {
					JNIEnv.CopyArray (native_writedata, writedata);
					JNIEnv.DeleteLocalRef (native_writedata);
				}
				global::System.GC.KeepAlive (writedata);
			}
		}

		static Delegate cb_rfhalt;
#pragma warning disable 0169
		static Delegate GetRfhaltHandler ()
		{
			if (cb_rfhalt == null)
				cb_rfhalt = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_Rfhalt);
			return cb_rfhalt;
		}

		static int n_Rfhalt (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Sunmi.Idcardservice.MiFareCardAidlDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Rfhalt ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.sunmi.idcardservice']/class[@name='MiFareCardAidl.Default']/method[@name='rfhalt' and count(parameter)=0]"
		[Register ("rfhalt", "()I", "GetRfhaltHandler")]
		public virtual unsafe int Rfhalt ()
		{
			const string __id = "rfhalt.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

	}

	// Metadata.xml XPath class reference: path="/api/package[@name='com.sunmi.idcardservice']/class[@name='MiFareCardAidl.Stub']"
	[global::Android.Runtime.Register ("com/sunmi/idcardservice/MiFareCardAidl$Stub", DoNotGenerateAcw=true)]
	public abstract partial class MiFareCardAidlStub : global::Android.OS.Binder, global::Com.Sunmi.Idcardservice.IMiFareCardAidl {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/sunmi/idcardservice/MiFareCardAidl$Stub", typeof (MiFareCardAidlStub));

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

		protected MiFareCardAidlStub (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.sunmi.idcardservice']/class[@name='MiFareCardAidl.Stub']/constructor[@name='MiFareCardAidl.Stub' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MiFareCardAidlStub () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		public static unsafe global::Com.Sunmi.Idcardservice.IMiFareCardAidl DefaultImpl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.sunmi.idcardservice']/class[@name='MiFareCardAidl.Stub']/method[@name='getDefaultImpl' and count(parameter)=0]"
			[Register ("getDefaultImpl", "()Lcom/sunmi/idcardservice/MiFareCardAidl;", "")]
			get {
				const string __id = "getDefaultImpl.()Lcom/sunmi/idcardservice/MiFareCardAidl;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Com.Sunmi.Idcardservice.IMiFareCardAidl> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Sunmi.Idcardservice.MiFareCardAidlStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.sunmi.idcardservice']/class[@name='MiFareCardAidl.Stub']/method[@name='asBinder' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.sunmi.idcardservice']/class[@name='MiFareCardAidl.Stub']/method[@name='asInterface' and count(parameter)=1 and parameter[1][@type='android.os.IBinder']]"
		[Register ("asInterface", "(Landroid/os/IBinder;)Lcom/sunmi/idcardservice/MiFareCardAidl;", "")]
		public static unsafe global::Com.Sunmi.Idcardservice.IMiFareCardAidl AsInterface (global::Android.OS.IBinder obj)
		{
			const string __id = "asInterface.(Landroid/os/IBinder;)Lcom/sunmi/idcardservice/MiFareCardAidl;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Sunmi.Idcardservice.IMiFareCardAidl> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Sunmi.Idcardservice.MiFareCardAidlStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var data = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_data, JniHandleOwnership.DoNotTransfer);
			var reply = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_reply, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnTransact (code, data, reply, flags);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.sunmi.idcardservice']/class[@name='MiFareCardAidl.Stub']/method[@name='onTransact' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='android.os.Parcel'] and parameter[3][@type='android.os.Parcel'] and parameter[4][@type='int']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.sunmi.idcardservice']/class[@name='MiFareCardAidl.Stub']/method[@name='setDefaultImpl' and count(parameter)=1 and parameter[1][@type='com.sunmi.idcardservice.MiFareCardAidl']]"
		[Register ("setDefaultImpl", "(Lcom/sunmi/idcardservice/MiFareCardAidl;)Z", "")]
		public static unsafe bool SetDefaultImpl (global::Com.Sunmi.Idcardservice.IMiFareCardAidl impl)
		{
			const string __id = "setDefaultImpl.(Lcom/sunmi/idcardservice/MiFareCardAidl;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((impl == null) ? IntPtr.Zero : ((global::Java.Lang.Object) impl).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (impl);
			}
		}

		static Delegate cb_beep_I;
#pragma warning disable 0169
		static Delegate GetBeep_IHandler ()
		{
			if (cb_beep_I == null)
				cb_beep_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_I) n_Beep_I);
			return cb_beep_I;
		}

		static int n_Beep_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Sunmi.Idcardservice.MiFareCardAidlStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Beep (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.sunmi.idcardservice']/interface[@name='MiFareCardAidl']/method[@name='beep' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("beep", "(I)I", "GetBeep_IHandler")]
		public abstract int Beep (int p0);

		static Delegate cb_exchangePro_arrayBIarrayBarrayI;
#pragma warning disable 0169
		static Delegate GetExchangePro_arrayBIarrayBarrayIHandler ()
		{
			if (cb_exchangePro_arrayBIarrayBarrayI == null)
				cb_exchangePro_arrayBIarrayBarrayI = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLILL_I) n_ExchangePro_arrayBIarrayBarrayI);
			return cb_exchangePro_arrayBIarrayBarrayI;
		}

		static int n_ExchangePro_arrayBIarrayBarrayI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2, IntPtr native_p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Sunmi.Idcardservice.MiFareCardAidlStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p2 = (byte[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p3 = (int[]) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (int));
			int __ret = __this.ExchangePro (p0, p1, p2, p3);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			if (p3 != null)
				JNIEnv.CopyArray (p3, native_p3);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.sunmi.idcardservice']/interface[@name='MiFareCardAidl']/method[@name='exchangePro' and count(parameter)=4 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='byte[]'] and parameter[4][@type='int[]']]"
		[Register ("exchangePro", "([BI[B[I)I", "GetExchangePro_arrayBIarrayBarrayIHandler")]
		public abstract int ExchangePro (byte[] p0, int p1, byte[] p2, int[] p3);

		static Delegate cb_getCPUCardState_arrayB;
#pragma warning disable 0169
		static Delegate GetGetCPUCardState_arrayBHandler ()
		{
			if (cb_getCPUCardState_arrayB == null)
				cb_getCPUCardState_arrayB = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_I) n_GetCPUCardState_arrayB);
			return cb_getCPUCardState_arrayB;
		}

		static int n_GetCPUCardState_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Sunmi.Idcardservice.MiFareCardAidlStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.GetCPUCardState (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.sunmi.idcardservice']/interface[@name='MiFareCardAidl']/method[@name='getCPUCardState' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("getCPUCardState", "([B)I", "GetGetCPUCardState_arrayBHandler")]
		public abstract int GetCPUCardState (byte[] p0);

		static Delegate cb_getEMID_arrayBarrayB;
#pragma warning disable 0169
		static Delegate GetGetEMID_arrayBarrayBHandler ()
		{
			if (cb_getEMID_arrayBarrayB == null)
				cb_getEMID_arrayBarrayB = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_I) n_GetEMID_arrayBarrayB);
			return cb_getEMID_arrayBarrayB;
		}

		static int n_GetEMID_arrayBarrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Sunmi.Idcardservice.MiFareCardAidlStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.GetEMID (p0, p1);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.sunmi.idcardservice']/interface[@name='MiFareCardAidl']/method[@name='getEMID' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]']]"
		[Register ("getEMID", "([B[B)I", "GetGetEMID_arrayBarrayBHandler")]
		public abstract int GetEMID (byte[] p0, byte[] p1);

		static Delegate cb_openCupCard_arrayBarrayBarrayBarrayBarrayB;
#pragma warning disable 0169
		static Delegate GetOpenCupCard_arrayBarrayBarrayBarrayBarrayBHandler ()
		{
			if (cb_openCupCard_arrayBarrayBarrayBarrayBarrayB == null)
				cb_openCupCard_arrayBarrayBarrayBarrayBarrayB = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLLL_I) n_OpenCupCard_arrayBarrayBarrayBarrayBarrayB);
			return cb_openCupCard_arrayBarrayBarrayBarrayBarrayB;
		}

		static int n_OpenCupCard_arrayBarrayBarrayBarrayBarrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Sunmi.Idcardservice.MiFareCardAidlStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p2 = (byte[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p3 = (byte[]) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p4 = (byte[]) JNIEnv.GetArray (native_p4, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.OpenCupCard (p0, p1, p2, p3, p4);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			if (p3 != null)
				JNIEnv.CopyArray (p3, native_p3);
			if (p4 != null)
				JNIEnv.CopyArray (p4, native_p4);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.sunmi.idcardservice']/interface[@name='MiFareCardAidl']/method[@name='openCupCard' and count(parameter)=5 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]'] and parameter[3][@type='byte[]'] and parameter[4][@type='byte[]'] and parameter[5][@type='byte[]']]"
		[Register ("openCupCard", "([B[B[B[B[B)I", "GetOpenCupCard_arrayBarrayBarrayBarrayBarrayBHandler")]
		public abstract int OpenCupCard (byte[] p0, byte[] p1, byte[] p2, byte[] p3, byte[] p4);

		static Delegate cb_readNAN_IarrayBarrayBarrayB;
#pragma warning disable 0169
		static Delegate GetReadNAN_IarrayBarrayBarrayBHandler ()
		{
			if (cb_readNAN_IarrayBarrayBarrayB == null)
				cb_readNAN_IarrayBarrayBarrayB = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPILLL_I) n_ReadNAN_IarrayBarrayBarrayB);
			return cb_readNAN_IarrayBarrayBarrayB;
		}

		static int n_ReadNAN_IarrayBarrayBarrayB (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Sunmi.Idcardservice.MiFareCardAidlStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p2 = (byte[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p3 = (byte[]) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.ReadNAN (p0, p1, p2, p3);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			if (p3 != null)
				JNIEnv.CopyArray (p3, native_p3);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.sunmi.idcardservice']/interface[@name='MiFareCardAidl']/method[@name='readNAN' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='byte[]'] and parameter[3][@type='byte[]'] and parameter[4][@type='byte[]']]"
		[Register ("readNAN", "(I[B[B[B)I", "GetReadNAN_IarrayBarrayBarrayBHandler")]
		public abstract int ReadNAN (int p0, byte[] p1, byte[] p2, byte[] p3);

		static Delegate cb_readSBInfo_arrayBarrayB;
#pragma warning disable 0169
		static Delegate GetReadSBInfo_arrayBarrayBHandler ()
		{
			if (cb_readSBInfo_arrayBarrayB == null)
				cb_readSBInfo_arrayBarrayB = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_I) n_ReadSBInfo_arrayBarrayB);
			return cb_readSBInfo_arrayBarrayB;
		}

		static int n_ReadSBInfo_arrayBarrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Sunmi.Idcardservice.MiFareCardAidlStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.ReadSBInfo (p0, p1);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.sunmi.idcardservice']/interface[@name='MiFareCardAidl']/method[@name='readSBInfo' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]']]"
		[Register ("readSBInfo", "([B[B)I", "GetReadSBInfo_arrayBarrayBHandler")]
		public abstract int ReadSBInfo (byte[] p0, byte[] p1);

		static Delegate cb_rfAuthEntication_IIarrayB;
#pragma warning disable 0169
		static Delegate GetRfAuthEntication_IIarrayBHandler ()
		{
			if (cb_rfAuthEntication_IIarrayB == null)
				cb_rfAuthEntication_IIarrayB = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIIL_I) n_RfAuthEntication_IIarrayB);
			return cb_rfAuthEntication_IIarrayB;
		}

		static int n_RfAuthEntication_IIarrayB (IntPtr jnienv, IntPtr native__this, int p0, int p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Sunmi.Idcardservice.MiFareCardAidlStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p2 = (byte[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.RfAuthEntication (p0, p1, p2);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.sunmi.idcardservice']/interface[@name='MiFareCardAidl']/method[@name='rfAuthEntication' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='byte[]']]"
		[Register ("rfAuthEntication", "(II[B)I", "GetRfAuthEntication_IIarrayBHandler")]
		public abstract int RfAuthEntication (int p0, int p1, byte[] p2);

		static Delegate cb_rfCard_arrayBarrayB;
#pragma warning disable 0169
		static Delegate GetRfCard_arrayBarrayBHandler ()
		{
			if (cb_rfCard_arrayBarrayB == null)
				cb_rfCard_arrayBarrayB = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_I) n_RfCard_arrayBarrayB);
			return cb_rfCard_arrayBarrayB;
		}

		static int n_RfCard_arrayBarrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Sunmi.Idcardservice.MiFareCardAidlStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.RfCard (p0, p1);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.sunmi.idcardservice']/interface[@name='MiFareCardAidl']/method[@name='rfCard' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]']]"
		[Register ("rfCard", "([B[B)I", "GetRfCard_arrayBarrayBHandler")]
		public abstract int RfCard (byte[] p0, byte[] p1);

		static Delegate cb_rfDecrement_II;
#pragma warning disable 0169
		static Delegate GetRfDecrement_IIHandler ()
		{
			if (cb_rfDecrement_II == null)
				cb_rfDecrement_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPII_I) n_RfDecrement_II);
			return cb_rfDecrement_II;
		}

		static int n_RfDecrement_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Sunmi.Idcardservice.MiFareCardAidlStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RfDecrement (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.sunmi.idcardservice']/interface[@name='MiFareCardAidl']/method[@name='rfDecrement' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("rfDecrement", "(II)I", "GetRfDecrement_IIHandler")]
		public abstract int RfDecrement (int p0, int p1);

		static Delegate cb_rfIncrement_II;
#pragma warning disable 0169
		static Delegate GetRfIncrement_IIHandler ()
		{
			if (cb_rfIncrement_II == null)
				cb_rfIncrement_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPII_I) n_RfIncrement_II);
			return cb_rfIncrement_II;
		}

		static int n_RfIncrement_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Sunmi.Idcardservice.MiFareCardAidlStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RfIncrement (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.sunmi.idcardservice']/interface[@name='MiFareCardAidl']/method[@name='rfIncrement' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("rfIncrement", "(II)I", "GetRfIncrement_IIHandler")]
		public abstract int RfIncrement (int p0, int p1);

		static Delegate cb_rfInitVal_II;
#pragma warning disable 0169
		static Delegate GetRfInitVal_IIHandler ()
		{
			if (cb_rfInitVal_II == null)
				cb_rfInitVal_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPII_I) n_RfInitVal_II);
			return cb_rfInitVal_II;
		}

		static int n_RfInitVal_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Sunmi.Idcardservice.MiFareCardAidlStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RfInitVal (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.sunmi.idcardservice']/interface[@name='MiFareCardAidl']/method[@name='rfInitVal' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("rfInitVal", "(II)I", "GetRfInitVal_IIHandler")]
		public abstract int RfInitVal (int p0, int p1);

		static Delegate cb_rfRead_IarrayB;
#pragma warning disable 0169
		static Delegate GetRfRead_IarrayBHandler ()
		{
			if (cb_rfRead_IarrayB == null)
				cb_rfRead_IarrayB = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIL_I) n_RfRead_IarrayB);
			return cb_rfRead_IarrayB;
		}

		static int n_RfRead_IarrayB (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Sunmi.Idcardservice.MiFareCardAidlStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.RfRead (p0, p1);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.sunmi.idcardservice']/interface[@name='MiFareCardAidl']/method[@name='rfRead' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='byte[]']]"
		[Register ("rfRead", "(I[B)I", "GetRfRead_IarrayBHandler")]
		public abstract int RfRead (int p0, byte[] p1);

		static Delegate cb_rfReadVal_IarrayI;
#pragma warning disable 0169
		static Delegate GetRfReadVal_IarrayIHandler ()
		{
			if (cb_rfReadVal_IarrayI == null)
				cb_rfReadVal_IarrayI = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIL_I) n_RfReadVal_IarrayI);
			return cb_rfReadVal_IarrayI;
		}

		static int n_RfReadVal_IarrayI (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Sunmi.Idcardservice.MiFareCardAidlStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p1 = (int[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (int));
			int __ret = __this.RfReadVal (p0, p1);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.sunmi.idcardservice']/interface[@name='MiFareCardAidl']/method[@name='rfReadVal' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int[]']]"
		[Register ("rfReadVal", "(I[I)I", "GetRfReadVal_IarrayIHandler")]
		public abstract int RfReadVal (int p0, int[] p1);

		static Delegate cb_rfWrite_IarrayB;
#pragma warning disable 0169
		static Delegate GetRfWrite_IarrayBHandler ()
		{
			if (cb_rfWrite_IarrayB == null)
				cb_rfWrite_IarrayB = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIL_I) n_RfWrite_IarrayB);
			return cb_rfWrite_IarrayB;
		}

		static int n_RfWrite_IarrayB (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Sunmi.Idcardservice.MiFareCardAidlStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.RfWrite (p0, p1);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.sunmi.idcardservice']/interface[@name='MiFareCardAidl']/method[@name='rfWrite' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='byte[]']]"
		[Register ("rfWrite", "(I[B)I", "GetRfWrite_IarrayBHandler")]
		public abstract int RfWrite (int p0, byte[] p1);

		static Delegate cb_rfhalt;
#pragma warning disable 0169
		static Delegate GetRfhaltHandler ()
		{
			if (cb_rfhalt == null)
				cb_rfhalt = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_Rfhalt);
			return cb_rfhalt;
		}

		static int n_Rfhalt (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Sunmi.Idcardservice.MiFareCardAidlStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Rfhalt ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.sunmi.idcardservice']/interface[@name='MiFareCardAidl']/method[@name='rfhalt' and count(parameter)=0]"
		[Register ("rfhalt", "()I", "GetRfhaltHandler")]
		public abstract int Rfhalt ();

	}

	[global::Android.Runtime.Register ("com/sunmi/idcardservice/MiFareCardAidl$Stub", DoNotGenerateAcw=true)]
	internal partial class MiFareCardAidlStubInvoker : MiFareCardAidlStub {
		public MiFareCardAidlStubInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/sunmi/idcardservice/MiFareCardAidl$Stub", typeof (MiFareCardAidlStubInvoker));

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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.sunmi.idcardservice']/interface[@name='MiFareCardAidl']/method[@name='beep' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("beep", "(I)I", "GetBeep_IHandler")]
		public override unsafe int Beep (int p0)
		{
			const string __id = "beep.(I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.sunmi.idcardservice']/interface[@name='MiFareCardAidl']/method[@name='exchangePro' and count(parameter)=4 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='byte[]'] and parameter[4][@type='int[]']]"
		[Register ("exchangePro", "([BI[B[I)I", "GetExchangePro_arrayBIarrayBarrayIHandler")]
		public override unsafe int ExchangePro (byte[] p0, int p1, byte[] p2, int[] p3)
		{
			const string __id = "exchangePro.([BI[B[I)I";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (native_p3);
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
				return __rm;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
				if (p3 != null) {
					JNIEnv.CopyArray (native_p3, p3);
					JNIEnv.DeleteLocalRef (native_p3);
				}
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p2);
				global::System.GC.KeepAlive (p3);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.sunmi.idcardservice']/interface[@name='MiFareCardAidl']/method[@name='getCPUCardState' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("getCPUCardState", "([B)I", "GetGetCPUCardState_arrayBHandler")]
		public override unsafe int GetCPUCardState (byte[] p0)
		{
			const string __id = "getCPUCardState.([B)I";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
				return __rm;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.sunmi.idcardservice']/interface[@name='MiFareCardAidl']/method[@name='getEMID' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]']]"
		[Register ("getEMID", "([B[B)I", "GetGetEMID_arrayBarrayBHandler")]
		public override unsafe int GetEMID (byte[] p0, byte[] p1)
		{
			const string __id = "getEMID.([B[B)I";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
				return __rm;
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
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.sunmi.idcardservice']/interface[@name='MiFareCardAidl']/method[@name='openCupCard' and count(parameter)=5 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]'] and parameter[3][@type='byte[]'] and parameter[4][@type='byte[]'] and parameter[5][@type='byte[]']]"
		[Register ("openCupCard", "([B[B[B[B[B)I", "GetOpenCupCard_arrayBarrayBarrayBarrayBarrayBHandler")]
		public override unsafe int OpenCupCard (byte[] p0, byte[] p1, byte[] p2, byte[] p3, byte[] p4)
		{
			const string __id = "openCupCard.([B[B[B[B[B)I";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			IntPtr native_p4 = JNIEnv.NewArray (p4);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (native_p3);
				__args [4] = new JniArgumentValue (native_p4);
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
				return __rm;
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
				if (p3 != null) {
					JNIEnv.CopyArray (native_p3, p3);
					JNIEnv.DeleteLocalRef (native_p3);
				}
				if (p4 != null) {
					JNIEnv.CopyArray (native_p4, p4);
					JNIEnv.DeleteLocalRef (native_p4);
				}
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
				global::System.GC.KeepAlive (p2);
				global::System.GC.KeepAlive (p3);
				global::System.GC.KeepAlive (p4);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.sunmi.idcardservice']/interface[@name='MiFareCardAidl']/method[@name='readNAN' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='byte[]'] and parameter[3][@type='byte[]'] and parameter[4][@type='byte[]']]"
		[Register ("readNAN", "(I[B[B[B)I", "GetReadNAN_IarrayBarrayBarrayBHandler")]
		public override unsafe int ReadNAN (int p0, byte[] p1, byte[] p2, byte[] p3)
		{
			const string __id = "readNAN.(I[B[B[B)I";
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (native_p3);
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
				return __rm;
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
				if (p3 != null) {
					JNIEnv.CopyArray (native_p3, p3);
					JNIEnv.DeleteLocalRef (native_p3);
				}
				global::System.GC.KeepAlive (p1);
				global::System.GC.KeepAlive (p2);
				global::System.GC.KeepAlive (p3);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.sunmi.idcardservice']/interface[@name='MiFareCardAidl']/method[@name='readSBInfo' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]']]"
		[Register ("readSBInfo", "([B[B)I", "GetReadSBInfo_arrayBarrayBHandler")]
		public override unsafe int ReadSBInfo (byte[] p0, byte[] p1)
		{
			const string __id = "readSBInfo.([B[B)I";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
				return __rm;
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
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.sunmi.idcardservice']/interface[@name='MiFareCardAidl']/method[@name='rfAuthEntication' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='byte[]']]"
		[Register ("rfAuthEntication", "(II[B)I", "GetRfAuthEntication_IIarrayBHandler")]
		public override unsafe int RfAuthEntication (int p0, int p1, byte[] p2)
		{
			const string __id = "rfAuthEntication.(II[B)I";
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (native_p2);
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
				return __rm;
			} finally {
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
				global::System.GC.KeepAlive (p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.sunmi.idcardservice']/interface[@name='MiFareCardAidl']/method[@name='rfCard' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]']]"
		[Register ("rfCard", "([B[B)I", "GetRfCard_arrayBarrayBHandler")]
		public override unsafe int RfCard (byte[] p0, byte[] p1)
		{
			const string __id = "rfCard.([B[B)I";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
				return __rm;
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
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.sunmi.idcardservice']/interface[@name='MiFareCardAidl']/method[@name='rfDecrement' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("rfDecrement", "(II)I", "GetRfDecrement_IIHandler")]
		public override unsafe int RfDecrement (int p0, int p1)
		{
			const string __id = "rfDecrement.(II)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.sunmi.idcardservice']/interface[@name='MiFareCardAidl']/method[@name='rfIncrement' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("rfIncrement", "(II)I", "GetRfIncrement_IIHandler")]
		public override unsafe int RfIncrement (int p0, int p1)
		{
			const string __id = "rfIncrement.(II)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.sunmi.idcardservice']/interface[@name='MiFareCardAidl']/method[@name='rfInitVal' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("rfInitVal", "(II)I", "GetRfInitVal_IIHandler")]
		public override unsafe int RfInitVal (int p0, int p1)
		{
			const string __id = "rfInitVal.(II)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.sunmi.idcardservice']/interface[@name='MiFareCardAidl']/method[@name='rfRead' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='byte[]']]"
		[Register ("rfRead", "(I[B)I", "GetRfRead_IarrayBHandler")]
		public override unsafe int RfRead (int p0, byte[] p1)
		{
			const string __id = "rfRead.(I[B)I";
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
				return __rm;
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				global::System.GC.KeepAlive (p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.sunmi.idcardservice']/interface[@name='MiFareCardAidl']/method[@name='rfReadVal' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int[]']]"
		[Register ("rfReadVal", "(I[I)I", "GetRfReadVal_IarrayIHandler")]
		public override unsafe int RfReadVal (int p0, int[] p1)
		{
			const string __id = "rfReadVal.(I[I)I";
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
				return __rm;
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				global::System.GC.KeepAlive (p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.sunmi.idcardservice']/interface[@name='MiFareCardAidl']/method[@name='rfWrite' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='byte[]']]"
		[Register ("rfWrite", "(I[B)I", "GetRfWrite_IarrayBHandler")]
		public override unsafe int RfWrite (int p0, byte[] p1)
		{
			const string __id = "rfWrite.(I[B)I";
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
				return __rm;
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				global::System.GC.KeepAlive (p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.sunmi.idcardservice']/interface[@name='MiFareCardAidl']/method[@name='rfhalt' and count(parameter)=0]"
		[Register ("rfhalt", "()I", "GetRfhaltHandler")]
		public override unsafe int Rfhalt ()
		{
			const string __id = "rfhalt.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.sunmi.idcardservice']/interface[@name='MiFareCardAidl']"
	[Register ("com/sunmi/idcardservice/MiFareCardAidl", "", "Com.Sunmi.Idcardservice.IMiFareCardAidlInvoker")]
	public partial interface IMiFareCardAidl : global::Android.OS.IInterface {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.sunmi.idcardservice']/interface[@name='MiFareCardAidl']/method[@name='beep' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("beep", "(I)I", "GetBeep_IHandler:Com.Sunmi.Idcardservice.IMiFareCardAidlInvoker, Binding")]
		int Beep (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.sunmi.idcardservice']/interface[@name='MiFareCardAidl']/method[@name='exchangePro' and count(parameter)=4 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='byte[]'] and parameter[4][@type='int[]']]"
		[Register ("exchangePro", "([BI[B[I)I", "GetExchangePro_arrayBIarrayBarrayIHandler:Com.Sunmi.Idcardservice.IMiFareCardAidlInvoker, Binding")]
		int ExchangePro (byte[] p0, int p1, byte[] p2, int[] p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.sunmi.idcardservice']/interface[@name='MiFareCardAidl']/method[@name='getCPUCardState' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("getCPUCardState", "([B)I", "GetGetCPUCardState_arrayBHandler:Com.Sunmi.Idcardservice.IMiFareCardAidlInvoker, Binding")]
		int GetCPUCardState (byte[] p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.sunmi.idcardservice']/interface[@name='MiFareCardAidl']/method[@name='getEMID' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]']]"
		[Register ("getEMID", "([B[B)I", "GetGetEMID_arrayBarrayBHandler:Com.Sunmi.Idcardservice.IMiFareCardAidlInvoker, Binding")]
		int GetEMID (byte[] p0, byte[] p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.sunmi.idcardservice']/interface[@name='MiFareCardAidl']/method[@name='openCupCard' and count(parameter)=5 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]'] and parameter[3][@type='byte[]'] and parameter[4][@type='byte[]'] and parameter[5][@type='byte[]']]"
		[Register ("openCupCard", "([B[B[B[B[B)I", "GetOpenCupCard_arrayBarrayBarrayBarrayBarrayBHandler:Com.Sunmi.Idcardservice.IMiFareCardAidlInvoker, Binding")]
		int OpenCupCard (byte[] p0, byte[] p1, byte[] p2, byte[] p3, byte[] p4);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.sunmi.idcardservice']/interface[@name='MiFareCardAidl']/method[@name='readNAN' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='byte[]'] and parameter[3][@type='byte[]'] and parameter[4][@type='byte[]']]"
		[Register ("readNAN", "(I[B[B[B)I", "GetReadNAN_IarrayBarrayBarrayBHandler:Com.Sunmi.Idcardservice.IMiFareCardAidlInvoker, Binding")]
		int ReadNAN (int p0, byte[] p1, byte[] p2, byte[] p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.sunmi.idcardservice']/interface[@name='MiFareCardAidl']/method[@name='readSBInfo' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]']]"
		[Register ("readSBInfo", "([B[B)I", "GetReadSBInfo_arrayBarrayBHandler:Com.Sunmi.Idcardservice.IMiFareCardAidlInvoker, Binding")]
		int ReadSBInfo (byte[] p0, byte[] p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.sunmi.idcardservice']/interface[@name='MiFareCardAidl']/method[@name='rfAuthEntication' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='byte[]']]"
		[Register ("rfAuthEntication", "(II[B)I", "GetRfAuthEntication_IIarrayBHandler:Com.Sunmi.Idcardservice.IMiFareCardAidlInvoker, Binding")]
		int RfAuthEntication (int p0, int p1, byte[] p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.sunmi.idcardservice']/interface[@name='MiFareCardAidl']/method[@name='rfCard' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]']]"
		[Register ("rfCard", "([B[B)I", "GetRfCard_arrayBarrayBHandler:Com.Sunmi.Idcardservice.IMiFareCardAidlInvoker, Binding")]
		int RfCard (byte[] p0, byte[] p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.sunmi.idcardservice']/interface[@name='MiFareCardAidl']/method[@name='rfDecrement' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("rfDecrement", "(II)I", "GetRfDecrement_IIHandler:Com.Sunmi.Idcardservice.IMiFareCardAidlInvoker, Binding")]
		int RfDecrement (int p0, int p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.sunmi.idcardservice']/interface[@name='MiFareCardAidl']/method[@name='rfIncrement' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("rfIncrement", "(II)I", "GetRfIncrement_IIHandler:Com.Sunmi.Idcardservice.IMiFareCardAidlInvoker, Binding")]
		int RfIncrement (int p0, int p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.sunmi.idcardservice']/interface[@name='MiFareCardAidl']/method[@name='rfInitVal' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("rfInitVal", "(II)I", "GetRfInitVal_IIHandler:Com.Sunmi.Idcardservice.IMiFareCardAidlInvoker, Binding")]
		int RfInitVal (int p0, int p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.sunmi.idcardservice']/interface[@name='MiFareCardAidl']/method[@name='rfRead' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='byte[]']]"
		[Register ("rfRead", "(I[B)I", "GetRfRead_IarrayBHandler:Com.Sunmi.Idcardservice.IMiFareCardAidlInvoker, Binding")]
		int RfRead (int p0, byte[] p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.sunmi.idcardservice']/interface[@name='MiFareCardAidl']/method[@name='rfReadVal' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int[]']]"
		[Register ("rfReadVal", "(I[I)I", "GetRfReadVal_IarrayIHandler:Com.Sunmi.Idcardservice.IMiFareCardAidlInvoker, Binding")]
		int RfReadVal (int p0, int[] p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.sunmi.idcardservice']/interface[@name='MiFareCardAidl']/method[@name='rfWrite' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='byte[]']]"
		[Register ("rfWrite", "(I[B)I", "GetRfWrite_IarrayBHandler:Com.Sunmi.Idcardservice.IMiFareCardAidlInvoker, Binding")]
		int RfWrite (int p0, byte[] p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.sunmi.idcardservice']/interface[@name='MiFareCardAidl']/method[@name='rfhalt' and count(parameter)=0]"
		[Register ("rfhalt", "()I", "GetRfhaltHandler:Com.Sunmi.Idcardservice.IMiFareCardAidlInvoker, Binding")]
		int Rfhalt ();

	}

	[global::Android.Runtime.Register ("com/sunmi/idcardservice/MiFareCardAidl", DoNotGenerateAcw=true)]
	internal partial class IMiFareCardAidlInvoker : global::Java.Lang.Object, IMiFareCardAidl {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/sunmi/idcardservice/MiFareCardAidl", typeof (IMiFareCardAidlInvoker));

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

		public static IMiFareCardAidl GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMiFareCardAidl> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.sunmi.idcardservice.MiFareCardAidl'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMiFareCardAidlInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_beep_I;
#pragma warning disable 0169
		static Delegate GetBeep_IHandler ()
		{
			if (cb_beep_I == null)
				cb_beep_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_I) n_Beep_I);
			return cb_beep_I;
		}

		static int n_Beep_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Sunmi.Idcardservice.IMiFareCardAidl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Beep (p0);
		}
#pragma warning restore 0169

		IntPtr id_beep_I;
		public unsafe int Beep (int p0)
		{
			if (id_beep_I == IntPtr.Zero)
				id_beep_I = JNIEnv.GetMethodID (class_ref, "beep", "(I)I");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_beep_I, __args);
		}

		static Delegate cb_exchangePro_arrayBIarrayBarrayI;
#pragma warning disable 0169
		static Delegate GetExchangePro_arrayBIarrayBarrayIHandler ()
		{
			if (cb_exchangePro_arrayBIarrayBarrayI == null)
				cb_exchangePro_arrayBIarrayBarrayI = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLILL_I) n_ExchangePro_arrayBIarrayBarrayI);
			return cb_exchangePro_arrayBIarrayBarrayI;
		}

		static int n_ExchangePro_arrayBIarrayBarrayI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2, IntPtr native_p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Sunmi.Idcardservice.IMiFareCardAidl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p2 = (byte[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p3 = (int[]) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (int));
			int __ret = __this.ExchangePro (p0, p1, p2, p3);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			if (p3 != null)
				JNIEnv.CopyArray (p3, native_p3);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_exchangePro_arrayBIarrayBarrayI;
		public unsafe int ExchangePro (byte[] p0, int p1, byte[] p2, int[] p3)
		{
			if (id_exchangePro_arrayBIarrayBarrayI == IntPtr.Zero)
				id_exchangePro_arrayBIarrayBarrayI = JNIEnv.GetMethodID (class_ref, "exchangePro", "([BI[B[I)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue (native_p3);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_exchangePro_arrayBIarrayBarrayI, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
			if (p3 != null) {
				JNIEnv.CopyArray (native_p3, p3);
				JNIEnv.DeleteLocalRef (native_p3);
			}
			return __ret;
		}

		static Delegate cb_getCPUCardState_arrayB;
#pragma warning disable 0169
		static Delegate GetGetCPUCardState_arrayBHandler ()
		{
			if (cb_getCPUCardState_arrayB == null)
				cb_getCPUCardState_arrayB = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_I) n_GetCPUCardState_arrayB);
			return cb_getCPUCardState_arrayB;
		}

		static int n_GetCPUCardState_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Sunmi.Idcardservice.IMiFareCardAidl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.GetCPUCardState (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getCPUCardState_arrayB;
		public unsafe int GetCPUCardState (byte[] p0)
		{
			if (id_getCPUCardState_arrayB == IntPtr.Zero)
				id_getCPUCardState_arrayB = JNIEnv.GetMethodID (class_ref, "getCPUCardState", "([B)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getCPUCardState_arrayB, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static Delegate cb_getEMID_arrayBarrayB;
#pragma warning disable 0169
		static Delegate GetGetEMID_arrayBarrayBHandler ()
		{
			if (cb_getEMID_arrayBarrayB == null)
				cb_getEMID_arrayBarrayB = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_I) n_GetEMID_arrayBarrayB);
			return cb_getEMID_arrayBarrayB;
		}

		static int n_GetEMID_arrayBarrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Sunmi.Idcardservice.IMiFareCardAidl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.GetEMID (p0, p1);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getEMID_arrayBarrayB;
		public unsafe int GetEMID (byte[] p0, byte[] p1)
		{
			if (id_getEMID_arrayBarrayB == IntPtr.Zero)
				id_getEMID_arrayBarrayB = JNIEnv.GetMethodID (class_ref, "getEMID", "([B[B)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getEMID_arrayBarrayB, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			return __ret;
		}

		static Delegate cb_openCupCard_arrayBarrayBarrayBarrayBarrayB;
#pragma warning disable 0169
		static Delegate GetOpenCupCard_arrayBarrayBarrayBarrayBarrayBHandler ()
		{
			if (cb_openCupCard_arrayBarrayBarrayBarrayBarrayB == null)
				cb_openCupCard_arrayBarrayBarrayBarrayBarrayB = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLLL_I) n_OpenCupCard_arrayBarrayBarrayBarrayBarrayB);
			return cb_openCupCard_arrayBarrayBarrayBarrayBarrayB;
		}

		static int n_OpenCupCard_arrayBarrayBarrayBarrayBarrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Sunmi.Idcardservice.IMiFareCardAidl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p2 = (byte[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p3 = (byte[]) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p4 = (byte[]) JNIEnv.GetArray (native_p4, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.OpenCupCard (p0, p1, p2, p3, p4);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			if (p3 != null)
				JNIEnv.CopyArray (p3, native_p3);
			if (p4 != null)
				JNIEnv.CopyArray (p4, native_p4);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_openCupCard_arrayBarrayBarrayBarrayBarrayB;
		public unsafe int OpenCupCard (byte[] p0, byte[] p1, byte[] p2, byte[] p3, byte[] p4)
		{
			if (id_openCupCard_arrayBarrayBarrayBarrayBarrayB == IntPtr.Zero)
				id_openCupCard_arrayBarrayBarrayBarrayBarrayB = JNIEnv.GetMethodID (class_ref, "openCupCard", "([B[B[B[B[B)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			IntPtr native_p4 = JNIEnv.NewArray (p4);
			JValue* __args = stackalloc JValue [5];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue (native_p3);
			__args [4] = new JValue (native_p4);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_openCupCard_arrayBarrayBarrayBarrayBarrayB, __args);
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
			if (p3 != null) {
				JNIEnv.CopyArray (native_p3, p3);
				JNIEnv.DeleteLocalRef (native_p3);
			}
			if (p4 != null) {
				JNIEnv.CopyArray (native_p4, p4);
				JNIEnv.DeleteLocalRef (native_p4);
			}
			return __ret;
		}

		static Delegate cb_readNAN_IarrayBarrayBarrayB;
#pragma warning disable 0169
		static Delegate GetReadNAN_IarrayBarrayBarrayBHandler ()
		{
			if (cb_readNAN_IarrayBarrayBarrayB == null)
				cb_readNAN_IarrayBarrayBarrayB = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPILLL_I) n_ReadNAN_IarrayBarrayBarrayB);
			return cb_readNAN_IarrayBarrayBarrayB;
		}

		static int n_ReadNAN_IarrayBarrayBarrayB (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Sunmi.Idcardservice.IMiFareCardAidl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p2 = (byte[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p3 = (byte[]) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.ReadNAN (p0, p1, p2, p3);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			if (p3 != null)
				JNIEnv.CopyArray (p3, native_p3);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_readNAN_IarrayBarrayBarrayB;
		public unsafe int ReadNAN (int p0, byte[] p1, byte[] p2, byte[] p3)
		{
			if (id_readNAN_IarrayBarrayBarrayB == IntPtr.Zero)
				id_readNAN_IarrayBarrayBarrayB = JNIEnv.GetMethodID (class_ref, "readNAN", "(I[B[B[B)I");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue (native_p3);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_readNAN_IarrayBarrayBarrayB, __args);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
			if (p3 != null) {
				JNIEnv.CopyArray (native_p3, p3);
				JNIEnv.DeleteLocalRef (native_p3);
			}
			return __ret;
		}

		static Delegate cb_readSBInfo_arrayBarrayB;
#pragma warning disable 0169
		static Delegate GetReadSBInfo_arrayBarrayBHandler ()
		{
			if (cb_readSBInfo_arrayBarrayB == null)
				cb_readSBInfo_arrayBarrayB = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_I) n_ReadSBInfo_arrayBarrayB);
			return cb_readSBInfo_arrayBarrayB;
		}

		static int n_ReadSBInfo_arrayBarrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Sunmi.Idcardservice.IMiFareCardAidl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.ReadSBInfo (p0, p1);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_readSBInfo_arrayBarrayB;
		public unsafe int ReadSBInfo (byte[] p0, byte[] p1)
		{
			if (id_readSBInfo_arrayBarrayB == IntPtr.Zero)
				id_readSBInfo_arrayBarrayB = JNIEnv.GetMethodID (class_ref, "readSBInfo", "([B[B)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_readSBInfo_arrayBarrayB, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			return __ret;
		}

		static Delegate cb_rfAuthEntication_IIarrayB;
#pragma warning disable 0169
		static Delegate GetRfAuthEntication_IIarrayBHandler ()
		{
			if (cb_rfAuthEntication_IIarrayB == null)
				cb_rfAuthEntication_IIarrayB = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIIL_I) n_RfAuthEntication_IIarrayB);
			return cb_rfAuthEntication_IIarrayB;
		}

		static int n_RfAuthEntication_IIarrayB (IntPtr jnienv, IntPtr native__this, int p0, int p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Sunmi.Idcardservice.IMiFareCardAidl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p2 = (byte[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.RfAuthEntication (p0, p1, p2);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_rfAuthEntication_IIarrayB;
		public unsafe int RfAuthEntication (int p0, int p1, byte[] p2)
		{
			if (id_rfAuthEntication_IIarrayB == IntPtr.Zero)
				id_rfAuthEntication_IIarrayB = JNIEnv.GetMethodID (class_ref, "rfAuthEntication", "(II[B)I");
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (native_p2);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_rfAuthEntication_IIarrayB, __args);
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
			return __ret;
		}

		static Delegate cb_rfCard_arrayBarrayB;
#pragma warning disable 0169
		static Delegate GetRfCard_arrayBarrayBHandler ()
		{
			if (cb_rfCard_arrayBarrayB == null)
				cb_rfCard_arrayBarrayB = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_I) n_RfCard_arrayBarrayB);
			return cb_rfCard_arrayBarrayB;
		}

		static int n_RfCard_arrayBarrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Sunmi.Idcardservice.IMiFareCardAidl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.RfCard (p0, p1);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_rfCard_arrayBarrayB;
		public unsafe int RfCard (byte[] p0, byte[] p1)
		{
			if (id_rfCard_arrayBarrayB == IntPtr.Zero)
				id_rfCard_arrayBarrayB = JNIEnv.GetMethodID (class_ref, "rfCard", "([B[B)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_rfCard_arrayBarrayB, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			return __ret;
		}

		static Delegate cb_rfDecrement_II;
#pragma warning disable 0169
		static Delegate GetRfDecrement_IIHandler ()
		{
			if (cb_rfDecrement_II == null)
				cb_rfDecrement_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPII_I) n_RfDecrement_II);
			return cb_rfDecrement_II;
		}

		static int n_RfDecrement_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Sunmi.Idcardservice.IMiFareCardAidl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RfDecrement (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_rfDecrement_II;
		public unsafe int RfDecrement (int p0, int p1)
		{
			if (id_rfDecrement_II == IntPtr.Zero)
				id_rfDecrement_II = JNIEnv.GetMethodID (class_ref, "rfDecrement", "(II)I");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_rfDecrement_II, __args);
		}

		static Delegate cb_rfIncrement_II;
#pragma warning disable 0169
		static Delegate GetRfIncrement_IIHandler ()
		{
			if (cb_rfIncrement_II == null)
				cb_rfIncrement_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPII_I) n_RfIncrement_II);
			return cb_rfIncrement_II;
		}

		static int n_RfIncrement_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Sunmi.Idcardservice.IMiFareCardAidl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RfIncrement (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_rfIncrement_II;
		public unsafe int RfIncrement (int p0, int p1)
		{
			if (id_rfIncrement_II == IntPtr.Zero)
				id_rfIncrement_II = JNIEnv.GetMethodID (class_ref, "rfIncrement", "(II)I");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_rfIncrement_II, __args);
		}

		static Delegate cb_rfInitVal_II;
#pragma warning disable 0169
		static Delegate GetRfInitVal_IIHandler ()
		{
			if (cb_rfInitVal_II == null)
				cb_rfInitVal_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPII_I) n_RfInitVal_II);
			return cb_rfInitVal_II;
		}

		static int n_RfInitVal_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Sunmi.Idcardservice.IMiFareCardAidl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RfInitVal (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_rfInitVal_II;
		public unsafe int RfInitVal (int p0, int p1)
		{
			if (id_rfInitVal_II == IntPtr.Zero)
				id_rfInitVal_II = JNIEnv.GetMethodID (class_ref, "rfInitVal", "(II)I");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_rfInitVal_II, __args);
		}

		static Delegate cb_rfRead_IarrayB;
#pragma warning disable 0169
		static Delegate GetRfRead_IarrayBHandler ()
		{
			if (cb_rfRead_IarrayB == null)
				cb_rfRead_IarrayB = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIL_I) n_RfRead_IarrayB);
			return cb_rfRead_IarrayB;
		}

		static int n_RfRead_IarrayB (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Sunmi.Idcardservice.IMiFareCardAidl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.RfRead (p0, p1);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_rfRead_IarrayB;
		public unsafe int RfRead (int p0, byte[] p1)
		{
			if (id_rfRead_IarrayB == IntPtr.Zero)
				id_rfRead_IarrayB = JNIEnv.GetMethodID (class_ref, "rfRead", "(I[B)I");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_rfRead_IarrayB, __args);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			return __ret;
		}

		static Delegate cb_rfReadVal_IarrayI;
#pragma warning disable 0169
		static Delegate GetRfReadVal_IarrayIHandler ()
		{
			if (cb_rfReadVal_IarrayI == null)
				cb_rfReadVal_IarrayI = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIL_I) n_RfReadVal_IarrayI);
			return cb_rfReadVal_IarrayI;
		}

		static int n_RfReadVal_IarrayI (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Sunmi.Idcardservice.IMiFareCardAidl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p1 = (int[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (int));
			int __ret = __this.RfReadVal (p0, p1);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_rfReadVal_IarrayI;
		public unsafe int RfReadVal (int p0, int[] p1)
		{
			if (id_rfReadVal_IarrayI == IntPtr.Zero)
				id_rfReadVal_IarrayI = JNIEnv.GetMethodID (class_ref, "rfReadVal", "(I[I)I");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_rfReadVal_IarrayI, __args);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			return __ret;
		}

		static Delegate cb_rfWrite_IarrayB;
#pragma warning disable 0169
		static Delegate GetRfWrite_IarrayBHandler ()
		{
			if (cb_rfWrite_IarrayB == null)
				cb_rfWrite_IarrayB = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIL_I) n_RfWrite_IarrayB);
			return cb_rfWrite_IarrayB;
		}

		static int n_RfWrite_IarrayB (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Sunmi.Idcardservice.IMiFareCardAidl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.RfWrite (p0, p1);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_rfWrite_IarrayB;
		public unsafe int RfWrite (int p0, byte[] p1)
		{
			if (id_rfWrite_IarrayB == IntPtr.Zero)
				id_rfWrite_IarrayB = JNIEnv.GetMethodID (class_ref, "rfWrite", "(I[B)I");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_rfWrite_IarrayB, __args);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			return __ret;
		}

		static Delegate cb_rfhalt;
#pragma warning disable 0169
		static Delegate GetRfhaltHandler ()
		{
			if (cb_rfhalt == null)
				cb_rfhalt = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_Rfhalt);
			return cb_rfhalt;
		}

		static int n_Rfhalt (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Sunmi.Idcardservice.IMiFareCardAidl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Rfhalt ();
		}
#pragma warning restore 0169

		IntPtr id_rfhalt;
		public unsafe int Rfhalt ()
		{
			if (id_rfhalt == IntPtr.Zero)
				id_rfhalt = JNIEnv.GetMethodID (class_ref, "rfhalt", "()I");
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_rfhalt);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Sunmi.Idcardservice.IMiFareCardAidl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
