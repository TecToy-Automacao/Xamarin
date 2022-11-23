using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Sunmi.Idcardservice {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.sunmi.idcardservice']/class[@name='IDCardInfo']"
	[global::Android.Runtime.Register ("com/sunmi/idcardservice/IDCardInfo", DoNotGenerateAcw=true)]
	public partial class IDCardInfo : global::Java.Lang.Object, global::Android.OS.IParcelable {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.sunmi.idcardservice']/class[@name='IDCardInfo']/field[@name='CREATOR']"
		[Register ("CREATOR")]
		public static global::Android.OS.IParcelableCreator Creator {
			get {
				const string __id = "CREATOR.Landroid/os/Parcelable$Creator;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/sunmi/idcardservice/IDCardInfo", typeof (IDCardInfo));

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

		protected IDCardInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.sunmi.idcardservice']/class[@name='IDCardInfo']/constructor[@name='IDCardInfo' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe IDCardInfo () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.sunmi.idcardservice']/class[@name='IDCardInfo']/constructor[@name='IDCardInfo' and count(parameter)=1 and parameter[1][@type='android.os.Parcel']]"
		[Register (".ctor", "(Landroid/os/Parcel;)V", "")]
		protected unsafe IDCardInfo (global::Android.OS.Parcel @in) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/os/Parcel;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((@in == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @in).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (@in);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.sunmi.idcardservice']/class[@name='IDCardInfo']/constructor[@name='IDCardInfo' and count(parameter)=9 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='java.lang.String'] and parameter[7][@type='java.lang.String'] and parameter[8][@type='java.lang.String'] and parameter[9][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe IDCardInfo (string name, string gender, string nation, string birthDay, string address, string idCard, string department, string startDate, string endDate) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_name = JNIEnv.NewString ((string)name);
			IntPtr native_gender = JNIEnv.NewString ((string)gender);
			IntPtr native_nation = JNIEnv.NewString ((string)nation);
			IntPtr native_birthDay = JNIEnv.NewString ((string)birthDay);
			IntPtr native_address = JNIEnv.NewString ((string)address);
			IntPtr native_idCard = JNIEnv.NewString ((string)idCard);
			IntPtr native_department = JNIEnv.NewString ((string)department);
			IntPtr native_startDate = JNIEnv.NewString ((string)startDate);
			IntPtr native_endDate = JNIEnv.NewString ((string)endDate);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [9];
				__args [0] = new JniArgumentValue (native_name);
				__args [1] = new JniArgumentValue (native_gender);
				__args [2] = new JniArgumentValue (native_nation);
				__args [3] = new JniArgumentValue (native_birthDay);
				__args [4] = new JniArgumentValue (native_address);
				__args [5] = new JniArgumentValue (native_idCard);
				__args [6] = new JniArgumentValue (native_department);
				__args [7] = new JniArgumentValue (native_startDate);
				__args [8] = new JniArgumentValue (native_endDate);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
				JNIEnv.DeleteLocalRef (native_gender);
				JNIEnv.DeleteLocalRef (native_nation);
				JNIEnv.DeleteLocalRef (native_birthDay);
				JNIEnv.DeleteLocalRef (native_address);
				JNIEnv.DeleteLocalRef (native_idCard);
				JNIEnv.DeleteLocalRef (native_department);
				JNIEnv.DeleteLocalRef (native_startDate);
				JNIEnv.DeleteLocalRef (native_endDate);
			}
		}

		static Delegate cb_getAddress;
#pragma warning disable 0169
		static Delegate GetGetAddressHandler ()
		{
			if (cb_getAddress == null)
				cb_getAddress = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetAddress);
			return cb_getAddress;
		}

		static IntPtr n_GetAddress (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Sunmi.Idcardservice.IDCardInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Address);
		}
#pragma warning restore 0169

		public virtual unsafe string Address {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.sunmi.idcardservice']/class[@name='IDCardInfo']/method[@name='getAddress' and count(parameter)=0]"
			[Register ("getAddress", "()Ljava/lang/String;", "GetGetAddressHandler")]
			get {
				const string __id = "getAddress.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getBirthDay;
#pragma warning disable 0169
		static Delegate GetGetBirthDayHandler ()
		{
			if (cb_getBirthDay == null)
				cb_getBirthDay = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetBirthDay);
			return cb_getBirthDay;
		}

		static IntPtr n_GetBirthDay (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Sunmi.Idcardservice.IDCardInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.BirthDay);
		}
#pragma warning restore 0169

		public virtual unsafe string BirthDay {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.sunmi.idcardservice']/class[@name='IDCardInfo']/method[@name='getBirthDay' and count(parameter)=0]"
			[Register ("getBirthDay", "()Ljava/lang/String;", "GetGetBirthDayHandler")]
			get {
				const string __id = "getBirthDay.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getDepartment;
#pragma warning disable 0169
		static Delegate GetGetDepartmentHandler ()
		{
			if (cb_getDepartment == null)
				cb_getDepartment = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetDepartment);
			return cb_getDepartment;
		}

		static IntPtr n_GetDepartment (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Sunmi.Idcardservice.IDCardInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Department);
		}
#pragma warning restore 0169

		public virtual unsafe string Department {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.sunmi.idcardservice']/class[@name='IDCardInfo']/method[@name='getDepartment' and count(parameter)=0]"
			[Register ("getDepartment", "()Ljava/lang/String;", "GetGetDepartmentHandler")]
			get {
				const string __id = "getDepartment.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getEndDate;
#pragma warning disable 0169
		static Delegate GetGetEndDateHandler ()
		{
			if (cb_getEndDate == null)
				cb_getEndDate = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetEndDate);
			return cb_getEndDate;
		}

		static IntPtr n_GetEndDate (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Sunmi.Idcardservice.IDCardInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.EndDate);
		}
#pragma warning restore 0169

		public virtual unsafe string EndDate {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.sunmi.idcardservice']/class[@name='IDCardInfo']/method[@name='getEndDate' and count(parameter)=0]"
			[Register ("getEndDate", "()Ljava/lang/String;", "GetGetEndDateHandler")]
			get {
				const string __id = "getEndDate.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getFirstFinger;
#pragma warning disable 0169
		static Delegate GetGetFirstFingerHandler ()
		{
			if (cb_getFirstFinger == null)
				cb_getFirstFinger = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetFirstFinger);
			return cb_getFirstFinger;
		}

		static IntPtr n_GetFirstFinger (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Sunmi.Idcardservice.IDCardInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.FirstFinger);
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Lang.Object FirstFinger {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.sunmi.idcardservice']/class[@name='IDCardInfo']/method[@name='getFirstFinger' and count(parameter)=0]"
			[Register ("getFirstFinger", "()Ljava/lang/Object;", "GetGetFirstFingerHandler")]
			get {
				const string __id = "getFirstFinger.()Ljava/lang/Object;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getGender;
#pragma warning disable 0169
		static Delegate GetGetGenderHandler ()
		{
			if (cb_getGender == null)
				cb_getGender = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetGender);
			return cb_getGender;
		}

		static IntPtr n_GetGender (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Sunmi.Idcardservice.IDCardInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Gender);
		}
#pragma warning restore 0169

		public virtual unsafe string Gender {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.sunmi.idcardservice']/class[@name='IDCardInfo']/method[@name='getGender' and count(parameter)=0]"
			[Register ("getGender", "()Ljava/lang/String;", "GetGetGenderHandler")]
			get {
				const string __id = "getGender.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getIdCard;
#pragma warning disable 0169
		static Delegate GetGetIdCardHandler ()
		{
			if (cb_getIdCard == null)
				cb_getIdCard = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetIdCard);
			return cb_getIdCard;
		}

		static IntPtr n_GetIdCard (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Sunmi.Idcardservice.IDCardInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.IdCard);
		}
#pragma warning restore 0169

		public virtual unsafe string IdCard {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.sunmi.idcardservice']/class[@name='IDCardInfo']/method[@name='getIdCard' and count(parameter)=0]"
			[Register ("getIdCard", "()Ljava/lang/String;", "GetGetIdCardHandler")]
			get {
				const string __id = "getIdCard.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getIdUid;
#pragma warning disable 0169
		static Delegate GetGetIdUidHandler ()
		{
			if (cb_getIdUid == null)
				cb_getIdUid = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetIdUid);
			return cb_getIdUid;
		}

		static IntPtr n_GetIdUid (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Sunmi.Idcardservice.IDCardInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.IdUid);
		}
#pragma warning restore 0169

		static Delegate cb_setIdUid_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetIdUid_Ljava_lang_String_Handler ()
		{
			if (cb_setIdUid_Ljava_lang_String_ == null)
				cb_setIdUid_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetIdUid_Ljava_lang_String_);
			return cb_setIdUid_Ljava_lang_String_;
		}

		static void n_SetIdUid_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_idUid)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Sunmi.Idcardservice.IDCardInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var idUid = JNIEnv.GetString (native_idUid, JniHandleOwnership.DoNotTransfer);
			__this.IdUid = idUid;
		}
#pragma warning restore 0169

		public virtual unsafe string IdUid {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.sunmi.idcardservice']/class[@name='IDCardInfo']/method[@name='getIdUid' and count(parameter)=0]"
			[Register ("getIdUid", "()Ljava/lang/String;", "GetGetIdUidHandler")]
			get {
				const string __id = "getIdUid.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.sunmi.idcardservice']/class[@name='IDCardInfo']/method[@name='setIdUid' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setIdUid", "(Ljava/lang/String;)V", "GetSetIdUid_Ljava_lang_String_Handler")]
			set {
				const string __id = "setIdUid.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getImageAddress;
#pragma warning disable 0169
		static Delegate GetGetImageAddressHandler ()
		{
			if (cb_getImageAddress == null)
				cb_getImageAddress = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetImageAddress);
			return cb_getImageAddress;
		}

		static IntPtr n_GetImageAddress (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Sunmi.Idcardservice.IDCardInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ImageAddress);
		}
#pragma warning restore 0169

		public virtual unsafe string ImageAddress {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.sunmi.idcardservice']/class[@name='IDCardInfo']/method[@name='getImageAddress' and count(parameter)=0]"
			[Register ("getImageAddress", "()Ljava/lang/String;", "GetGetImageAddressHandler")]
			get {
				const string __id = "getImageAddress.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getName;
#pragma warning disable 0169
		static Delegate GetGetNameHandler ()
		{
			if (cb_getName == null)
				cb_getName = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetName);
			return cb_getName;
		}

		static IntPtr n_GetName (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Sunmi.Idcardservice.IDCardInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Name);
		}
#pragma warning restore 0169

		public virtual unsafe string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.sunmi.idcardservice']/class[@name='IDCardInfo']/method[@name='getName' and count(parameter)=0]"
			[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler")]
			get {
				const string __id = "getName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getNation;
#pragma warning disable 0169
		static Delegate GetGetNationHandler ()
		{
			if (cb_getNation == null)
				cb_getNation = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetNation);
			return cb_getNation;
		}

		static IntPtr n_GetNation (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Sunmi.Idcardservice.IDCardInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Nation);
		}
#pragma warning restore 0169

		public virtual unsafe string Nation {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.sunmi.idcardservice']/class[@name='IDCardInfo']/method[@name='getNation' and count(parameter)=0]"
			[Register ("getNation", "()Ljava/lang/String;", "GetGetNationHandler")]
			get {
				const string __id = "getNation.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSecondFinger;
#pragma warning disable 0169
		static Delegate GetGetSecondFingerHandler ()
		{
			if (cb_getSecondFinger == null)
				cb_getSecondFinger = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetSecondFinger);
			return cb_getSecondFinger;
		}

		static IntPtr n_GetSecondFinger (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Sunmi.Idcardservice.IDCardInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SecondFinger);
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Lang.Object SecondFinger {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.sunmi.idcardservice']/class[@name='IDCardInfo']/method[@name='getSecondFinger' and count(parameter)=0]"
			[Register ("getSecondFinger", "()Ljava/lang/Object;", "GetGetSecondFingerHandler")]
			get {
				const string __id = "getSecondFinger.()Ljava/lang/Object;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getStartDate;
#pragma warning disable 0169
		static Delegate GetGetStartDateHandler ()
		{
			if (cb_getStartDate == null)
				cb_getStartDate = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetStartDate);
			return cb_getStartDate;
		}

		static IntPtr n_GetStartDate (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Sunmi.Idcardservice.IDCardInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.StartDate);
		}
#pragma warning restore 0169

		public virtual unsafe string StartDate {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.sunmi.idcardservice']/class[@name='IDCardInfo']/method[@name='getStartDate' and count(parameter)=0]"
			[Register ("getStartDate", "()Ljava/lang/String;", "GetGetStartDateHandler")]
			get {
				const string __id = "getStartDate.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_describeContents;
#pragma warning disable 0169
		static Delegate GetDescribeContentsHandler ()
		{
			if (cb_describeContents == null)
				cb_describeContents = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_DescribeContents);
			return cb_describeContents;
		}

		static int n_DescribeContents (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Sunmi.Idcardservice.IDCardInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescribeContents ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.sunmi.idcardservice']/class[@name='IDCardInfo']/method[@name='describeContents' and count(parameter)=0]"
		[Register ("describeContents", "()I", "GetDescribeContentsHandler")]
		public virtual unsafe int DescribeContents ()
		{
			const string __id = "describeContents.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_readFromParcel_Landroid_os_Parcel_;
#pragma warning disable 0169
		static Delegate GetReadFromParcel_Landroid_os_Parcel_Handler ()
		{
			if (cb_readFromParcel_Landroid_os_Parcel_ == null)
				cb_readFromParcel_Landroid_os_Parcel_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_ReadFromParcel_Landroid_os_Parcel_);
			return cb_readFromParcel_Landroid_os_Parcel_;
		}

		static void n_ReadFromParcel_Landroid_os_Parcel_ (IntPtr jnienv, IntPtr native__this, IntPtr native__in)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Sunmi.Idcardservice.IDCardInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var @in = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native__in, JniHandleOwnership.DoNotTransfer);
			__this.ReadFromParcel (@in);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.sunmi.idcardservice']/class[@name='IDCardInfo']/method[@name='readFromParcel' and count(parameter)=1 and parameter[1][@type='android.os.Parcel']]"
		[Register ("readFromParcel", "(Landroid/os/Parcel;)V", "GetReadFromParcel_Landroid_os_Parcel_Handler")]
		public virtual unsafe void ReadFromParcel (global::Android.OS.Parcel @in)
		{
			const string __id = "readFromParcel.(Landroid/os/Parcel;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((@in == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @in).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (@in);
			}
		}

		static Delegate cb_setImageAddress_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetImageAddress_Ljava_lang_String_Handler ()
		{
			if (cb_setImageAddress_Ljava_lang_String_ == null)
				cb_setImageAddress_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetImageAddress_Ljava_lang_String_);
			return cb_setImageAddress_Ljava_lang_String_;
		}

		static IntPtr n_SetImageAddress_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_imageAddress)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Sunmi.Idcardservice.IDCardInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var imageAddress = JNIEnv.GetString (native_imageAddress, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetImageAddress (imageAddress));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.sunmi.idcardservice']/class[@name='IDCardInfo']/method[@name='setImageAddress' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setImageAddress", "(Ljava/lang/String;)Lcom/sunmi/idcardservice/IDCardInfo;", "GetSetImageAddress_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Sunmi.Idcardservice.IDCardInfo SetImageAddress (string imageAddress)
		{
			const string __id = "setImageAddress.(Ljava/lang/String;)Lcom/sunmi/idcardservice/IDCardInfo;";
			IntPtr native_imageAddress = JNIEnv.NewString ((string)imageAddress);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_imageAddress);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Sunmi.Idcardservice.IDCardInfo> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_imageAddress);
			}
		}

		static Delegate cb_writeToParcel_Landroid_os_Parcel_I;
#pragma warning disable 0169
		static Delegate GetWriteToParcel_Landroid_os_Parcel_IHandler ()
		{
			if (cb_writeToParcel_Landroid_os_Parcel_I == null)
				cb_writeToParcel_Landroid_os_Parcel_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLI_V) n_WriteToParcel_Landroid_os_Parcel_I);
			return cb_writeToParcel_Landroid_os_Parcel_I;
		}

		static void n_WriteToParcel_Landroid_os_Parcel_I (IntPtr jnienv, IntPtr native__this, IntPtr native_dest, int native_flags)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Sunmi.Idcardservice.IDCardInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var dest = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_dest, JniHandleOwnership.DoNotTransfer);
			var flags = (global::Android.OS.ParcelableWriteFlags) native_flags;
			__this.WriteToParcel (dest, flags);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.sunmi.idcardservice']/class[@name='IDCardInfo']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
		[Register ("writeToParcel", "(Landroid/os/Parcel;I)V", "GetWriteToParcel_Landroid_os_Parcel_IHandler")]
		public virtual unsafe void WriteToParcel (global::Android.OS.Parcel dest, [global::Android.Runtime.GeneratedEnum] global::Android.OS.ParcelableWriteFlags flags)
		{
			const string __id = "writeToParcel.(Landroid/os/Parcel;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((dest == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dest).Handle);
				__args [1] = new JniArgumentValue ((int) flags);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (dest);
			}
		}

	}
}
