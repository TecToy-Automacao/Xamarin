using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Xcheng.Printerservice {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.xcheng.printerservice']/class[@name='IPrinterService.Default']"
	[global::Android.Runtime.Register ("com/xcheng/printerservice/IPrinterService$Default", DoNotGenerateAcw=true)]
	public partial class PrinterServiceDefault : global::Java.Lang.Object, global::Com.Xcheng.Printerservice.IPrinterService {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/xcheng/printerservice/IPrinterService$Default", typeof (PrinterServiceDefault));

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

		protected PrinterServiceDefault (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.xcheng.printerservice']/class[@name='IPrinterService.Default']/constructor[@name='IPrinterService.Default' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe PrinterServiceDefault () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_getBootloaderVersion;
#pragma warning disable 0169
		static Delegate GetGetBootloaderVersionHandler ()
		{
			if (cb_getBootloaderVersion == null)
				cb_getBootloaderVersion = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetBootloaderVersion);
			return cb_getBootloaderVersion;
		}

		static IntPtr n_GetBootloaderVersion (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Xcheng.Printerservice.PrinterServiceDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.BootloaderVersion);
		}
#pragma warning restore 0169

		public virtual unsafe string BootloaderVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.xcheng.printerservice']/class[@name='IPrinterService.Default']/method[@name='getBootloaderVersion' and count(parameter)=0]"
			[Register ("getBootloaderVersion", "()Ljava/lang/String;", "GetGetBootloaderVersionHandler")]
			get {
				const string __id = "getBootloaderVersion.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getFirmwareVersion;
#pragma warning disable 0169
		static Delegate GetGetFirmwareVersionHandler ()
		{
			if (cb_getFirmwareVersion == null)
				cb_getFirmwareVersion = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetFirmwareVersion);
			return cb_getFirmwareVersion;
		}

		static IntPtr n_GetFirmwareVersion (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Xcheng.Printerservice.PrinterServiceDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.FirmwareVersion);
		}
#pragma warning restore 0169

		public virtual unsafe string FirmwareVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.xcheng.printerservice']/class[@name='IPrinterService.Default']/method[@name='getFirmwareVersion' and count(parameter)=0]"
			[Register ("getFirmwareVersion", "()Ljava/lang/String;", "GetGetFirmwareVersionHandler")]
			get {
				const string __id = "getFirmwareVersion.()Ljava/lang/String;";
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Xcheng.Printerservice.PrinterServiceDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.xcheng.printerservice']/class[@name='IPrinterService.Default']/method[@name='asBinder' and count(parameter)=0]"
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

		static Delegate cb_printBarCode_Ljava_lang_String_IIIZLcom_xcheng_printerservice_IPrinterCallback_;
#pragma warning disable 0169
		static Delegate GetPrintBarCode_Ljava_lang_String_IIIZLcom_xcheng_printerservice_IPrinterCallback_Handler ()
		{
			if (cb_printBarCode_Ljava_lang_String_IIIZLcom_xcheng_printerservice_IPrinterCallback_ == null)
				cb_printBarCode_Ljava_lang_String_IIIZLcom_xcheng_printerservice_IPrinterCallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLIIIZL_V) n_PrintBarCode_Ljava_lang_String_IIIZLcom_xcheng_printerservice_IPrinterCallback_);
			return cb_printBarCode_Ljava_lang_String_IIIZLcom_xcheng_printerservice_IPrinterCallback_;
		}

		static void n_PrintBarCode_Ljava_lang_String_IIIZLcom_xcheng_printerservice_IPrinterCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_content, int align, int width, int height, bool showContent, IntPtr native__callback)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Xcheng.Printerservice.PrinterServiceDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var content = JNIEnv.GetString (native_content, JniHandleOwnership.DoNotTransfer);
			var @callback = (global::Com.Xcheng.Printerservice.IPrinterCallback)global::Java.Lang.Object.GetObject<global::Com.Xcheng.Printerservice.IPrinterCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.PrintBarCode (content, align, width, height, showContent, @callback);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.xcheng.printerservice']/class[@name='IPrinterService.Default']/method[@name='printBarCode' and count(parameter)=6 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='boolean'] and parameter[6][@type='com.xcheng.printerservice.IPrinterCallback']]"
		[Register ("printBarCode", "(Ljava/lang/String;IIIZLcom/xcheng/printerservice/IPrinterCallback;)V", "GetPrintBarCode_Ljava_lang_String_IIIZLcom_xcheng_printerservice_IPrinterCallback_Handler")]
		public virtual unsafe void PrintBarCode (string content, int align, int width, int height, bool showContent, global::Com.Xcheng.Printerservice.IPrinterCallback @callback)
		{
			const string __id = "printBarCode.(Ljava/lang/String;IIIZLcom/xcheng/printerservice/IPrinterCallback;)V";
			IntPtr native_content = JNIEnv.NewString ((string)content);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue (native_content);
				__args [1] = new JniArgumentValue (align);
				__args [2] = new JniArgumentValue (width);
				__args [3] = new JniArgumentValue (height);
				__args [4] = new JniArgumentValue (showContent);
				__args [5] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_content);
				global::System.GC.KeepAlive (@callback);
			}
		}

		static Delegate cb_printBitmap_Landroid_graphics_Bitmap_Lcom_xcheng_printerservice_IPrinterCallback_;
#pragma warning disable 0169
		static Delegate GetPrintBitmap_Landroid_graphics_Bitmap_Lcom_xcheng_printerservice_IPrinterCallback_Handler ()
		{
			if (cb_printBitmap_Landroid_graphics_Bitmap_Lcom_xcheng_printerservice_IPrinterCallback_ == null)
				cb_printBitmap_Landroid_graphics_Bitmap_Lcom_xcheng_printerservice_IPrinterCallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_PrintBitmap_Landroid_graphics_Bitmap_Lcom_xcheng_printerservice_IPrinterCallback_);
			return cb_printBitmap_Landroid_graphics_Bitmap_Lcom_xcheng_printerservice_IPrinterCallback_;
		}

		static void n_PrintBitmap_Landroid_graphics_Bitmap_Lcom_xcheng_printerservice_IPrinterCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_bitmap, IntPtr native__callback)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Xcheng.Printerservice.PrinterServiceDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var bitmap = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_bitmap, JniHandleOwnership.DoNotTransfer);
			var @callback = (global::Com.Xcheng.Printerservice.IPrinterCallback)global::Java.Lang.Object.GetObject<global::Com.Xcheng.Printerservice.IPrinterCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.PrintBitmap (bitmap, @callback);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.xcheng.printerservice']/class[@name='IPrinterService.Default']/method[@name='printBitmap' and count(parameter)=2 and parameter[1][@type='android.graphics.Bitmap'] and parameter[2][@type='com.xcheng.printerservice.IPrinterCallback']]"
		[Register ("printBitmap", "(Landroid/graphics/Bitmap;Lcom/xcheng/printerservice/IPrinterCallback;)V", "GetPrintBitmap_Landroid_graphics_Bitmap_Lcom_xcheng_printerservice_IPrinterCallback_Handler")]
		public virtual unsafe void PrintBitmap (global::Android.Graphics.Bitmap bitmap, global::Com.Xcheng.Printerservice.IPrinterCallback @callback)
		{
			const string __id = "printBitmap.(Landroid/graphics/Bitmap;Lcom/xcheng/printerservice/IPrinterCallback;)V";
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

		static Delegate cb_printBitmapWithAttributes_Landroid_graphics_Bitmap_Ljava_util_Map_Lcom_xcheng_printerservice_IPrinterCallback_;
#pragma warning disable 0169
		static Delegate GetPrintBitmapWithAttributes_Landroid_graphics_Bitmap_Ljava_util_Map_Lcom_xcheng_printerservice_IPrinterCallback_Handler ()
		{
			if (cb_printBitmapWithAttributes_Landroid_graphics_Bitmap_Ljava_util_Map_Lcom_xcheng_printerservice_IPrinterCallback_ == null)
				cb_printBitmapWithAttributes_Landroid_graphics_Bitmap_Ljava_util_Map_Lcom_xcheng_printerservice_IPrinterCallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_PrintBitmapWithAttributes_Landroid_graphics_Bitmap_Ljava_util_Map_Lcom_xcheng_printerservice_IPrinterCallback_);
			return cb_printBitmapWithAttributes_Landroid_graphics_Bitmap_Ljava_util_Map_Lcom_xcheng_printerservice_IPrinterCallback_;
		}

		static void n_PrintBitmapWithAttributes_Landroid_graphics_Bitmap_Ljava_util_Map_Lcom_xcheng_printerservice_IPrinterCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_bitmap, IntPtr native_attributes, IntPtr native__callback)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Xcheng.Printerservice.PrinterServiceDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var bitmap = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_bitmap, JniHandleOwnership.DoNotTransfer);
			var attributes = global::Android.Runtime.JavaDictionary.FromJniHandle (native_attributes, JniHandleOwnership.DoNotTransfer);
			var @callback = (global::Com.Xcheng.Printerservice.IPrinterCallback)global::Java.Lang.Object.GetObject<global::Com.Xcheng.Printerservice.IPrinterCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.PrintBitmapWithAttributes (bitmap, attributes, @callback);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.xcheng.printerservice']/class[@name='IPrinterService.Default']/method[@name='printBitmapWithAttributes' and count(parameter)=3 and parameter[1][@type='android.graphics.Bitmap'] and parameter[2][@type='java.util.Map'] and parameter[3][@type='com.xcheng.printerservice.IPrinterCallback']]"
		[Register ("printBitmapWithAttributes", "(Landroid/graphics/Bitmap;Ljava/util/Map;Lcom/xcheng/printerservice/IPrinterCallback;)V", "GetPrintBitmapWithAttributes_Landroid_graphics_Bitmap_Ljava_util_Map_Lcom_xcheng_printerservice_IPrinterCallback_Handler")]
		public virtual unsafe void PrintBitmapWithAttributes (global::Android.Graphics.Bitmap bitmap, global::System.Collections.IDictionary attributes, global::Com.Xcheng.Printerservice.IPrinterCallback @callback)
		{
			const string __id = "printBitmapWithAttributes.(Landroid/graphics/Bitmap;Ljava/util/Map;Lcom/xcheng/printerservice/IPrinterCallback;)V";
			IntPtr native_attributes = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (attributes);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((bitmap == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bitmap).Handle);
				__args [1] = new JniArgumentValue (native_attributes);
				__args [2] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_attributes);
				global::System.GC.KeepAlive (bitmap);
				global::System.GC.KeepAlive (attributes);
				global::System.GC.KeepAlive (@callback);
			}
		}

		static Delegate cb_printColumnsTextWithAttributes_arrayLjava_lang_String_Ljava_util_List_Lcom_xcheng_printerservice_IPrinterCallback_;
#pragma warning disable 0169
		static Delegate GetPrintColumnsTextWithAttributes_arrayLjava_lang_String_Ljava_util_List_Lcom_xcheng_printerservice_IPrinterCallback_Handler ()
		{
			if (cb_printColumnsTextWithAttributes_arrayLjava_lang_String_Ljava_util_List_Lcom_xcheng_printerservice_IPrinterCallback_ == null)
				cb_printColumnsTextWithAttributes_arrayLjava_lang_String_Ljava_util_List_Lcom_xcheng_printerservice_IPrinterCallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_PrintColumnsTextWithAttributes_arrayLjava_lang_String_Ljava_util_List_Lcom_xcheng_printerservice_IPrinterCallback_);
			return cb_printColumnsTextWithAttributes_arrayLjava_lang_String_Ljava_util_List_Lcom_xcheng_printerservice_IPrinterCallback_;
		}

		static void n_PrintColumnsTextWithAttributes_arrayLjava_lang_String_Ljava_util_List_Lcom_xcheng_printerservice_IPrinterCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_text, IntPtr native_attributes, IntPtr native__callback)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Xcheng.Printerservice.PrinterServiceDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var text = (string[]) JNIEnv.GetArray (native_text, JniHandleOwnership.DoNotTransfer, typeof (string));
			var attributes = global::Android.Runtime.JavaList.FromJniHandle (native_attributes, JniHandleOwnership.DoNotTransfer);
			var @callback = (global::Com.Xcheng.Printerservice.IPrinterCallback)global::Java.Lang.Object.GetObject<global::Com.Xcheng.Printerservice.IPrinterCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.PrintColumnsTextWithAttributes (text, attributes, @callback);
			if (text != null)
				JNIEnv.CopyArray (text, native_text);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.xcheng.printerservice']/class[@name='IPrinterService.Default']/method[@name='printColumnsTextWithAttributes' and count(parameter)=3 and parameter[1][@type='java.lang.String[]'] and parameter[2][@type='java.util.List'] and parameter[3][@type='com.xcheng.printerservice.IPrinterCallback']]"
		[Register ("printColumnsTextWithAttributes", "([Ljava/lang/String;Ljava/util/List;Lcom/xcheng/printerservice/IPrinterCallback;)V", "GetPrintColumnsTextWithAttributes_arrayLjava_lang_String_Ljava_util_List_Lcom_xcheng_printerservice_IPrinterCallback_Handler")]
		public virtual unsafe void PrintColumnsTextWithAttributes (string[] text, global::System.Collections.IList attributes, global::Com.Xcheng.Printerservice.IPrinterCallback @callback)
		{
			const string __id = "printColumnsTextWithAttributes.([Ljava/lang/String;Ljava/util/List;Lcom/xcheng/printerservice/IPrinterCallback;)V";
			IntPtr native_text = JNIEnv.NewArray (text);
			IntPtr native_attributes = global::Android.Runtime.JavaList.ToLocalJniHandle (attributes);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_text);
				__args [1] = new JniArgumentValue (native_attributes);
				__args [2] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (text != null) {
					JNIEnv.CopyArray (native_text, text);
					JNIEnv.DeleteLocalRef (native_text);
				}
				JNIEnv.DeleteLocalRef (native_attributes);
				global::System.GC.KeepAlive (text);
				global::System.GC.KeepAlive (attributes);
				global::System.GC.KeepAlive (@callback);
			}
		}

		static Delegate cb_printQRCode_Ljava_lang_String_IILcom_xcheng_printerservice_IPrinterCallback_;
#pragma warning disable 0169
		static Delegate GetPrintQRCode_Ljava_lang_String_IILcom_xcheng_printerservice_IPrinterCallback_Handler ()
		{
			if (cb_printQRCode_Ljava_lang_String_IILcom_xcheng_printerservice_IPrinterCallback_ == null)
				cb_printQRCode_Ljava_lang_String_IILcom_xcheng_printerservice_IPrinterCallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLIIL_V) n_PrintQRCode_Ljava_lang_String_IILcom_xcheng_printerservice_IPrinterCallback_);
			return cb_printQRCode_Ljava_lang_String_IILcom_xcheng_printerservice_IPrinterCallback_;
		}

		static void n_PrintQRCode_Ljava_lang_String_IILcom_xcheng_printerservice_IPrinterCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_text, int align, int size, IntPtr native__callback)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Xcheng.Printerservice.PrinterServiceDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var text = JNIEnv.GetString (native_text, JniHandleOwnership.DoNotTransfer);
			var @callback = (global::Com.Xcheng.Printerservice.IPrinterCallback)global::Java.Lang.Object.GetObject<global::Com.Xcheng.Printerservice.IPrinterCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.PrintQRCode (text, align, size, @callback);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.xcheng.printerservice']/class[@name='IPrinterService.Default']/method[@name='printQRCode' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='com.xcheng.printerservice.IPrinterCallback']]"
		[Register ("printQRCode", "(Ljava/lang/String;IILcom/xcheng/printerservice/IPrinterCallback;)V", "GetPrintQRCode_Ljava_lang_String_IILcom_xcheng_printerservice_IPrinterCallback_Handler")]
		public virtual unsafe void PrintQRCode (string text, int align, int size, global::Com.Xcheng.Printerservice.IPrinterCallback @callback)
		{
			const string __id = "printQRCode.(Ljava/lang/String;IILcom/xcheng/printerservice/IPrinterCallback;)V";
			IntPtr native_text = JNIEnv.NewString ((string)text);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_text);
				__args [1] = new JniArgumentValue (align);
				__args [2] = new JniArgumentValue (size);
				__args [3] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_text);
				global::System.GC.KeepAlive (@callback);
			}
		}

		static Delegate cb_printText_Ljava_lang_String_Lcom_xcheng_printerservice_IPrinterCallback_;
#pragma warning disable 0169
		static Delegate GetPrintText_Ljava_lang_String_Lcom_xcheng_printerservice_IPrinterCallback_Handler ()
		{
			if (cb_printText_Ljava_lang_String_Lcom_xcheng_printerservice_IPrinterCallback_ == null)
				cb_printText_Ljava_lang_String_Lcom_xcheng_printerservice_IPrinterCallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_PrintText_Ljava_lang_String_Lcom_xcheng_printerservice_IPrinterCallback_);
			return cb_printText_Ljava_lang_String_Lcom_xcheng_printerservice_IPrinterCallback_;
		}

		static void n_PrintText_Ljava_lang_String_Lcom_xcheng_printerservice_IPrinterCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_text, IntPtr native__callback)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Xcheng.Printerservice.PrinterServiceDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var text = JNIEnv.GetString (native_text, JniHandleOwnership.DoNotTransfer);
			var @callback = (global::Com.Xcheng.Printerservice.IPrinterCallback)global::Java.Lang.Object.GetObject<global::Com.Xcheng.Printerservice.IPrinterCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.PrintText (text, @callback);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.xcheng.printerservice']/class[@name='IPrinterService.Default']/method[@name='printText' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.xcheng.printerservice.IPrinterCallback']]"
		[Register ("printText", "(Ljava/lang/String;Lcom/xcheng/printerservice/IPrinterCallback;)V", "GetPrintText_Ljava_lang_String_Lcom_xcheng_printerservice_IPrinterCallback_Handler")]
		public virtual unsafe void PrintText (string text, global::Com.Xcheng.Printerservice.IPrinterCallback @callback)
		{
			const string __id = "printText.(Ljava/lang/String;Lcom/xcheng/printerservice/IPrinterCallback;)V";
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

		static Delegate cb_printTextWithAttributes_Ljava_lang_String_Ljava_util_Map_Lcom_xcheng_printerservice_IPrinterCallback_;
#pragma warning disable 0169
		static Delegate GetPrintTextWithAttributes_Ljava_lang_String_Ljava_util_Map_Lcom_xcheng_printerservice_IPrinterCallback_Handler ()
		{
			if (cb_printTextWithAttributes_Ljava_lang_String_Ljava_util_Map_Lcom_xcheng_printerservice_IPrinterCallback_ == null)
				cb_printTextWithAttributes_Ljava_lang_String_Ljava_util_Map_Lcom_xcheng_printerservice_IPrinterCallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_PrintTextWithAttributes_Ljava_lang_String_Ljava_util_Map_Lcom_xcheng_printerservice_IPrinterCallback_);
			return cb_printTextWithAttributes_Ljava_lang_String_Ljava_util_Map_Lcom_xcheng_printerservice_IPrinterCallback_;
		}

		static void n_PrintTextWithAttributes_Ljava_lang_String_Ljava_util_Map_Lcom_xcheng_printerservice_IPrinterCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_text, IntPtr native_attributes, IntPtr native__callback)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Xcheng.Printerservice.PrinterServiceDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var text = JNIEnv.GetString (native_text, JniHandleOwnership.DoNotTransfer);
			var attributes = global::Android.Runtime.JavaDictionary.FromJniHandle (native_attributes, JniHandleOwnership.DoNotTransfer);
			var @callback = (global::Com.Xcheng.Printerservice.IPrinterCallback)global::Java.Lang.Object.GetObject<global::Com.Xcheng.Printerservice.IPrinterCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.PrintTextWithAttributes (text, attributes, @callback);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.xcheng.printerservice']/class[@name='IPrinterService.Default']/method[@name='printTextWithAttributes' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.Map'] and parameter[3][@type='com.xcheng.printerservice.IPrinterCallback']]"
		[Register ("printTextWithAttributes", "(Ljava/lang/String;Ljava/util/Map;Lcom/xcheng/printerservice/IPrinterCallback;)V", "GetPrintTextWithAttributes_Ljava_lang_String_Ljava_util_Map_Lcom_xcheng_printerservice_IPrinterCallback_Handler")]
		public virtual unsafe void PrintTextWithAttributes (string text, global::System.Collections.IDictionary attributes, global::Com.Xcheng.Printerservice.IPrinterCallback @callback)
		{
			const string __id = "printTextWithAttributes.(Ljava/lang/String;Ljava/util/Map;Lcom/xcheng/printerservice/IPrinterCallback;)V";
			IntPtr native_text = JNIEnv.NewString ((string)text);
			IntPtr native_attributes = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (attributes);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_text);
				__args [1] = new JniArgumentValue (native_attributes);
				__args [2] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_text);
				JNIEnv.DeleteLocalRef (native_attributes);
				global::System.GC.KeepAlive (attributes);
				global::System.GC.KeepAlive (@callback);
			}
		}

		static Delegate cb_printWrapPaper_ILcom_xcheng_printerservice_IPrinterCallback_;
#pragma warning disable 0169
		static Delegate GetPrintWrapPaper_ILcom_xcheng_printerservice_IPrinterCallback_Handler ()
		{
			if (cb_printWrapPaper_ILcom_xcheng_printerservice_IPrinterCallback_ == null)
				cb_printWrapPaper_ILcom_xcheng_printerservice_IPrinterCallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIL_V) n_PrintWrapPaper_ILcom_xcheng_printerservice_IPrinterCallback_);
			return cb_printWrapPaper_ILcom_xcheng_printerservice_IPrinterCallback_;
		}

		static void n_PrintWrapPaper_ILcom_xcheng_printerservice_IPrinterCallback_ (IntPtr jnienv, IntPtr native__this, int n, IntPtr native__callback)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Xcheng.Printerservice.PrinterServiceDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var @callback = (global::Com.Xcheng.Printerservice.IPrinterCallback)global::Java.Lang.Object.GetObject<global::Com.Xcheng.Printerservice.IPrinterCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.PrintWrapPaper (n, @callback);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.xcheng.printerservice']/class[@name='IPrinterService.Default']/method[@name='printWrapPaper' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.xcheng.printerservice.IPrinterCallback']]"
		[Register ("printWrapPaper", "(ILcom/xcheng/printerservice/IPrinterCallback;)V", "GetPrintWrapPaper_ILcom_xcheng_printerservice_IPrinterCallback_Handler")]
		public virtual unsafe void PrintWrapPaper (int n, global::Com.Xcheng.Printerservice.IPrinterCallback @callback)
		{
			const string __id = "printWrapPaper.(ILcom/xcheng/printerservice/IPrinterCallback;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (n);
				__args [1] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (@callback);
			}
		}

		static Delegate cb_printerInit_Lcom_xcheng_printerservice_IPrinterCallback_;
#pragma warning disable 0169
		static Delegate GetPrinterInit_Lcom_xcheng_printerservice_IPrinterCallback_Handler ()
		{
			if (cb_printerInit_Lcom_xcheng_printerservice_IPrinterCallback_ == null)
				cb_printerInit_Lcom_xcheng_printerservice_IPrinterCallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_PrinterInit_Lcom_xcheng_printerservice_IPrinterCallback_);
			return cb_printerInit_Lcom_xcheng_printerservice_IPrinterCallback_;
		}

		static void n_PrinterInit_Lcom_xcheng_printerservice_IPrinterCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native__callback)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Xcheng.Printerservice.PrinterServiceDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var @callback = (global::Com.Xcheng.Printerservice.IPrinterCallback)global::Java.Lang.Object.GetObject<global::Com.Xcheng.Printerservice.IPrinterCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.PrinterInit (@callback);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.xcheng.printerservice']/class[@name='IPrinterService.Default']/method[@name='printerInit' and count(parameter)=1 and parameter[1][@type='com.xcheng.printerservice.IPrinterCallback']]"
		[Register ("printerInit", "(Lcom/xcheng/printerservice/IPrinterCallback;)V", "GetPrinterInit_Lcom_xcheng_printerservice_IPrinterCallback_Handler")]
		public virtual unsafe void PrinterInit (global::Com.Xcheng.Printerservice.IPrinterCallback @callback)
		{
			const string __id = "printerInit.(Lcom/xcheng/printerservice/IPrinterCallback;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (@callback);
			}
		}

		static Delegate cb_printerPaper_Lcom_xcheng_printerservice_IPrinterCallback_;
#pragma warning disable 0169
		static Delegate GetPrinterPaper_Lcom_xcheng_printerservice_IPrinterCallback_Handler ()
		{
			if (cb_printerPaper_Lcom_xcheng_printerservice_IPrinterCallback_ == null)
				cb_printerPaper_Lcom_xcheng_printerservice_IPrinterCallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_PrinterPaper_Lcom_xcheng_printerservice_IPrinterCallback_);
			return cb_printerPaper_Lcom_xcheng_printerservice_IPrinterCallback_;
		}

		static bool n_PrinterPaper_Lcom_xcheng_printerservice_IPrinterCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native__callback)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Xcheng.Printerservice.PrinterServiceDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var @callback = (global::Com.Xcheng.Printerservice.IPrinterCallback)global::Java.Lang.Object.GetObject<global::Com.Xcheng.Printerservice.IPrinterCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.PrinterPaper (@callback);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.xcheng.printerservice']/class[@name='IPrinterService.Default']/method[@name='printerPaper' and count(parameter)=1 and parameter[1][@type='com.xcheng.printerservice.IPrinterCallback']]"
		[Register ("printerPaper", "(Lcom/xcheng/printerservice/IPrinterCallback;)Z", "GetPrinterPaper_Lcom_xcheng_printerservice_IPrinterCallback_Handler")]
		public virtual unsafe bool PrinterPaper (global::Com.Xcheng.Printerservice.IPrinterCallback @callback)
		{
			const string __id = "printerPaper.(Lcom/xcheng/printerservice/IPrinterCallback;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (@callback);
			}
		}

		static Delegate cb_printerReset_Lcom_xcheng_printerservice_IPrinterCallback_;
#pragma warning disable 0169
		static Delegate GetPrinterReset_Lcom_xcheng_printerservice_IPrinterCallback_Handler ()
		{
			if (cb_printerReset_Lcom_xcheng_printerservice_IPrinterCallback_ == null)
				cb_printerReset_Lcom_xcheng_printerservice_IPrinterCallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_PrinterReset_Lcom_xcheng_printerservice_IPrinterCallback_);
			return cb_printerReset_Lcom_xcheng_printerservice_IPrinterCallback_;
		}

		static void n_PrinterReset_Lcom_xcheng_printerservice_IPrinterCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native__callback)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Xcheng.Printerservice.PrinterServiceDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var @callback = (global::Com.Xcheng.Printerservice.IPrinterCallback)global::Java.Lang.Object.GetObject<global::Com.Xcheng.Printerservice.IPrinterCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.PrinterReset (@callback);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.xcheng.printerservice']/class[@name='IPrinterService.Default']/method[@name='printerReset' and count(parameter)=1 and parameter[1][@type='com.xcheng.printerservice.IPrinterCallback']]"
		[Register ("printerReset", "(Lcom/xcheng/printerservice/IPrinterCallback;)V", "GetPrinterReset_Lcom_xcheng_printerservice_IPrinterCallback_Handler")]
		public virtual unsafe void PrinterReset (global::Com.Xcheng.Printerservice.IPrinterCallback @callback)
		{
			const string __id = "printerReset.(Lcom/xcheng/printerservice/IPrinterCallback;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (@callback);
			}
		}

		static Delegate cb_printerTemperature_Lcom_xcheng_printerservice_IPrinterCallback_;
#pragma warning disable 0169
		static Delegate GetPrinterTemperature_Lcom_xcheng_printerservice_IPrinterCallback_Handler ()
		{
			if (cb_printerTemperature_Lcom_xcheng_printerservice_IPrinterCallback_ == null)
				cb_printerTemperature_Lcom_xcheng_printerservice_IPrinterCallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_I) n_PrinterTemperature_Lcom_xcheng_printerservice_IPrinterCallback_);
			return cb_printerTemperature_Lcom_xcheng_printerservice_IPrinterCallback_;
		}

		static int n_PrinterTemperature_Lcom_xcheng_printerservice_IPrinterCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native__callback)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Xcheng.Printerservice.PrinterServiceDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var @callback = (global::Com.Xcheng.Printerservice.IPrinterCallback)global::Java.Lang.Object.GetObject<global::Com.Xcheng.Printerservice.IPrinterCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.PrinterTemperature (@callback);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.xcheng.printerservice']/class[@name='IPrinterService.Default']/method[@name='printerTemperature' and count(parameter)=1 and parameter[1][@type='com.xcheng.printerservice.IPrinterCallback']]"
		[Register ("printerTemperature", "(Lcom/xcheng/printerservice/IPrinterCallback;)I", "GetPrinterTemperature_Lcom_xcheng_printerservice_IPrinterCallback_Handler")]
		public virtual unsafe int PrinterTemperature (global::Com.Xcheng.Printerservice.IPrinterCallback @callback)
		{
			const string __id = "printerTemperature.(Lcom/xcheng/printerservice/IPrinterCallback;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (@callback);
			}
		}

		static Delegate cb_sendRAWData_arrayBLcom_xcheng_printerservice_IPrinterCallback_;
#pragma warning disable 0169
		static Delegate GetSendRAWData_arrayBLcom_xcheng_printerservice_IPrinterCallback_Handler ()
		{
			if (cb_sendRAWData_arrayBLcom_xcheng_printerservice_IPrinterCallback_ == null)
				cb_sendRAWData_arrayBLcom_xcheng_printerservice_IPrinterCallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_SendRAWData_arrayBLcom_xcheng_printerservice_IPrinterCallback_);
			return cb_sendRAWData_arrayBLcom_xcheng_printerservice_IPrinterCallback_;
		}

		static void n_SendRAWData_arrayBLcom_xcheng_printerservice_IPrinterCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_data, IntPtr native__callback)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Xcheng.Printerservice.PrinterServiceDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var data = (byte[]) JNIEnv.GetArray (native_data, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var @callback = (global::Com.Xcheng.Printerservice.IPrinterCallback)global::Java.Lang.Object.GetObject<global::Com.Xcheng.Printerservice.IPrinterCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.SendRAWData (data, @callback);
			if (data != null)
				JNIEnv.CopyArray (data, native_data);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.xcheng.printerservice']/class[@name='IPrinterService.Default']/method[@name='sendRAWData' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='com.xcheng.printerservice.IPrinterCallback']]"
		[Register ("sendRAWData", "([BLcom/xcheng/printerservice/IPrinterCallback;)V", "GetSendRAWData_arrayBLcom_xcheng_printerservice_IPrinterCallback_Handler")]
		public virtual unsafe void SendRAWData (byte[] data, global::Com.Xcheng.Printerservice.IPrinterCallback @callback)
		{
			const string __id = "sendRAWData.([BLcom/xcheng/printerservice/IPrinterCallback;)V";
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

		static Delegate cb_setPrinterSpeed_ILcom_xcheng_printerservice_IPrinterCallback_;
#pragma warning disable 0169
		static Delegate GetSetPrinterSpeed_ILcom_xcheng_printerservice_IPrinterCallback_Handler ()
		{
			if (cb_setPrinterSpeed_ILcom_xcheng_printerservice_IPrinterCallback_ == null)
				cb_setPrinterSpeed_ILcom_xcheng_printerservice_IPrinterCallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIL_V) n_SetPrinterSpeed_ILcom_xcheng_printerservice_IPrinterCallback_);
			return cb_setPrinterSpeed_ILcom_xcheng_printerservice_IPrinterCallback_;
		}

		static void n_SetPrinterSpeed_ILcom_xcheng_printerservice_IPrinterCallback_ (IntPtr jnienv, IntPtr native__this, int level, IntPtr native__callback)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Xcheng.Printerservice.PrinterServiceDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var @callback = (global::Com.Xcheng.Printerservice.IPrinterCallback)global::Java.Lang.Object.GetObject<global::Com.Xcheng.Printerservice.IPrinterCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.SetPrinterSpeed (level, @callback);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.xcheng.printerservice']/class[@name='IPrinterService.Default']/method[@name='setPrinterSpeed' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.xcheng.printerservice.IPrinterCallback']]"
		[Register ("setPrinterSpeed", "(ILcom/xcheng/printerservice/IPrinterCallback;)V", "GetSetPrinterSpeed_ILcom_xcheng_printerservice_IPrinterCallback_Handler")]
		public virtual unsafe void SetPrinterSpeed (int level, global::Com.Xcheng.Printerservice.IPrinterCallback @callback)
		{
			const string __id = "setPrinterSpeed.(ILcom/xcheng/printerservice/IPrinterCallback;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (level);
				__args [1] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (@callback);
			}
		}

		static Delegate cb_upgradePrinter;
#pragma warning disable 0169
		static Delegate GetUpgradePrinterHandler ()
		{
			if (cb_upgradePrinter == null)
				cb_upgradePrinter = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_UpgradePrinter);
			return cb_upgradePrinter;
		}

		static void n_UpgradePrinter (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Xcheng.Printerservice.PrinterServiceDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UpgradePrinter ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.xcheng.printerservice']/class[@name='IPrinterService.Default']/method[@name='upgradePrinter' and count(parameter)=0]"
		[Register ("upgradePrinter", "()V", "GetUpgradePrinterHandler")]
		public virtual unsafe void UpgradePrinter ()
		{
			const string __id = "upgradePrinter.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}

	// Metadata.xml XPath class reference: path="/api/package[@name='com.xcheng.printerservice']/class[@name='IPrinterService.Stub']"
	[global::Android.Runtime.Register ("com/xcheng/printerservice/IPrinterService$Stub", DoNotGenerateAcw=true)]
	public abstract partial class PrinterServiceStub : global::Android.OS.Binder, global::Com.Xcheng.Printerservice.IPrinterService {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/xcheng/printerservice/IPrinterService$Stub", typeof (PrinterServiceStub));

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

		protected PrinterServiceStub (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.xcheng.printerservice']/class[@name='IPrinterService.Stub']/constructor[@name='IPrinterService.Stub' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe PrinterServiceStub () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		public static unsafe global::Com.Xcheng.Printerservice.IPrinterService DefaultImpl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.xcheng.printerservice']/class[@name='IPrinterService.Stub']/method[@name='getDefaultImpl' and count(parameter)=0]"
			[Register ("getDefaultImpl", "()Lcom/xcheng/printerservice/IPrinterService;", "")]
			get {
				const string __id = "getDefaultImpl.()Lcom/xcheng/printerservice/IPrinterService;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Com.Xcheng.Printerservice.IPrinterService> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Xcheng.Printerservice.PrinterServiceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.xcheng.printerservice']/class[@name='IPrinterService.Stub']/method[@name='asBinder' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.xcheng.printerservice']/class[@name='IPrinterService.Stub']/method[@name='asInterface' and count(parameter)=1 and parameter[1][@type='android.os.IBinder']]"
		[Register ("asInterface", "(Landroid/os/IBinder;)Lcom/xcheng/printerservice/IPrinterService;", "")]
		public static unsafe global::Com.Xcheng.Printerservice.IPrinterService AsInterface (global::Android.OS.IBinder obj)
		{
			const string __id = "asInterface.(Landroid/os/IBinder;)Lcom/xcheng/printerservice/IPrinterService;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Xcheng.Printerservice.IPrinterService> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Xcheng.Printerservice.PrinterServiceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var data = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_data, JniHandleOwnership.DoNotTransfer);
			var reply = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_reply, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnTransact (code, data, reply, flags);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.xcheng.printerservice']/class[@name='IPrinterService.Stub']/method[@name='onTransact' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='android.os.Parcel'] and parameter[3][@type='android.os.Parcel'] and parameter[4][@type='int']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.xcheng.printerservice']/class[@name='IPrinterService.Stub']/method[@name='setDefaultImpl' and count(parameter)=1 and parameter[1][@type='com.xcheng.printerservice.IPrinterService']]"
		[Register ("setDefaultImpl", "(Lcom/xcheng/printerservice/IPrinterService;)Z", "")]
		public static unsafe bool SetDefaultImpl (global::Com.Xcheng.Printerservice.IPrinterService impl)
		{
			const string __id = "setDefaultImpl.(Lcom/xcheng/printerservice/IPrinterService;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((impl == null) ? IntPtr.Zero : ((global::Java.Lang.Object) impl).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (impl);
			}
		}

		static Delegate cb_printBarCode_Ljava_lang_String_IIIZLcom_xcheng_printerservice_IPrinterCallback_;
#pragma warning disable 0169
		static Delegate GetPrintBarCode_Ljava_lang_String_IIIZLcom_xcheng_printerservice_IPrinterCallback_Handler ()
		{
			if (cb_printBarCode_Ljava_lang_String_IIIZLcom_xcheng_printerservice_IPrinterCallback_ == null)
				cb_printBarCode_Ljava_lang_String_IIIZLcom_xcheng_printerservice_IPrinterCallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLIIIZL_V) n_PrintBarCode_Ljava_lang_String_IIIZLcom_xcheng_printerservice_IPrinterCallback_);
			return cb_printBarCode_Ljava_lang_String_IIIZLcom_xcheng_printerservice_IPrinterCallback_;
		}

		static void n_PrintBarCode_Ljava_lang_String_IIIZLcom_xcheng_printerservice_IPrinterCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2, int p3, bool p4, IntPtr native_p5)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Xcheng.Printerservice.PrinterServiceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p5 = (global::Com.Xcheng.Printerservice.IPrinterCallback)global::Java.Lang.Object.GetObject<global::Com.Xcheng.Printerservice.IPrinterCallback> (native_p5, JniHandleOwnership.DoNotTransfer);
			__this.PrintBarCode (p0, p1, p2, p3, p4, p5);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.xcheng.printerservice']/interface[@name='IPrinterService']/method[@name='printBarCode' and count(parameter)=6 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='boolean'] and parameter[6][@type='com.xcheng.printerservice.IPrinterCallback']]"
		[Register ("printBarCode", "(Ljava/lang/String;IIIZLcom/xcheng/printerservice/IPrinterCallback;)V", "GetPrintBarCode_Ljava_lang_String_IIIZLcom_xcheng_printerservice_IPrinterCallback_Handler")]
		public abstract void PrintBarCode (string p0, int p1, int p2, int p3, bool p4, global::Com.Xcheng.Printerservice.IPrinterCallback p5);

		static Delegate cb_printBitmap_Landroid_graphics_Bitmap_Lcom_xcheng_printerservice_IPrinterCallback_;
#pragma warning disable 0169
		static Delegate GetPrintBitmap_Landroid_graphics_Bitmap_Lcom_xcheng_printerservice_IPrinterCallback_Handler ()
		{
			if (cb_printBitmap_Landroid_graphics_Bitmap_Lcom_xcheng_printerservice_IPrinterCallback_ == null)
				cb_printBitmap_Landroid_graphics_Bitmap_Lcom_xcheng_printerservice_IPrinterCallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_PrintBitmap_Landroid_graphics_Bitmap_Lcom_xcheng_printerservice_IPrinterCallback_);
			return cb_printBitmap_Landroid_graphics_Bitmap_Lcom_xcheng_printerservice_IPrinterCallback_;
		}

		static void n_PrintBitmap_Landroid_graphics_Bitmap_Lcom_xcheng_printerservice_IPrinterCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Xcheng.Printerservice.PrinterServiceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Com.Xcheng.Printerservice.IPrinterCallback)global::Java.Lang.Object.GetObject<global::Com.Xcheng.Printerservice.IPrinterCallback> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.PrintBitmap (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.xcheng.printerservice']/interface[@name='IPrinterService']/method[@name='printBitmap' and count(parameter)=2 and parameter[1][@type='android.graphics.Bitmap'] and parameter[2][@type='com.xcheng.printerservice.IPrinterCallback']]"
		[Register ("printBitmap", "(Landroid/graphics/Bitmap;Lcom/xcheng/printerservice/IPrinterCallback;)V", "GetPrintBitmap_Landroid_graphics_Bitmap_Lcom_xcheng_printerservice_IPrinterCallback_Handler")]
		public abstract void PrintBitmap (global::Android.Graphics.Bitmap p0, global::Com.Xcheng.Printerservice.IPrinterCallback p1);

		static Delegate cb_printBitmapWithAttributes_Landroid_graphics_Bitmap_Ljava_util_Map_Lcom_xcheng_printerservice_IPrinterCallback_;
#pragma warning disable 0169
		static Delegate GetPrintBitmapWithAttributes_Landroid_graphics_Bitmap_Ljava_util_Map_Lcom_xcheng_printerservice_IPrinterCallback_Handler ()
		{
			if (cb_printBitmapWithAttributes_Landroid_graphics_Bitmap_Ljava_util_Map_Lcom_xcheng_printerservice_IPrinterCallback_ == null)
				cb_printBitmapWithAttributes_Landroid_graphics_Bitmap_Ljava_util_Map_Lcom_xcheng_printerservice_IPrinterCallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_PrintBitmapWithAttributes_Landroid_graphics_Bitmap_Ljava_util_Map_Lcom_xcheng_printerservice_IPrinterCallback_);
			return cb_printBitmapWithAttributes_Landroid_graphics_Bitmap_Ljava_util_Map_Lcom_xcheng_printerservice_IPrinterCallback_;
		}

		static void n_PrintBitmapWithAttributes_Landroid_graphics_Bitmap_Ljava_util_Map_Lcom_xcheng_printerservice_IPrinterCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Xcheng.Printerservice.PrinterServiceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Android.Runtime.JavaDictionary.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = (global::Com.Xcheng.Printerservice.IPrinterCallback)global::Java.Lang.Object.GetObject<global::Com.Xcheng.Printerservice.IPrinterCallback> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.PrintBitmapWithAttributes (p0, p1, p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.xcheng.printerservice']/interface[@name='IPrinterService']/method[@name='printBitmapWithAttributes' and count(parameter)=3 and parameter[1][@type='android.graphics.Bitmap'] and parameter[2][@type='java.util.Map'] and parameter[3][@type='com.xcheng.printerservice.IPrinterCallback']]"
		[Register ("printBitmapWithAttributes", "(Landroid/graphics/Bitmap;Ljava/util/Map;Lcom/xcheng/printerservice/IPrinterCallback;)V", "GetPrintBitmapWithAttributes_Landroid_graphics_Bitmap_Ljava_util_Map_Lcom_xcheng_printerservice_IPrinterCallback_Handler")]
		public abstract void PrintBitmapWithAttributes (global::Android.Graphics.Bitmap p0, global::System.Collections.IDictionary p1, global::Com.Xcheng.Printerservice.IPrinterCallback p2);

		static Delegate cb_printColumnsTextWithAttributes_arrayLjava_lang_String_Ljava_util_List_Lcom_xcheng_printerservice_IPrinterCallback_;
#pragma warning disable 0169
		static Delegate GetPrintColumnsTextWithAttributes_arrayLjava_lang_String_Ljava_util_List_Lcom_xcheng_printerservice_IPrinterCallback_Handler ()
		{
			if (cb_printColumnsTextWithAttributes_arrayLjava_lang_String_Ljava_util_List_Lcom_xcheng_printerservice_IPrinterCallback_ == null)
				cb_printColumnsTextWithAttributes_arrayLjava_lang_String_Ljava_util_List_Lcom_xcheng_printerservice_IPrinterCallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_PrintColumnsTextWithAttributes_arrayLjava_lang_String_Ljava_util_List_Lcom_xcheng_printerservice_IPrinterCallback_);
			return cb_printColumnsTextWithAttributes_arrayLjava_lang_String_Ljava_util_List_Lcom_xcheng_printerservice_IPrinterCallback_;
		}

		static void n_PrintColumnsTextWithAttributes_arrayLjava_lang_String_Ljava_util_List_Lcom_xcheng_printerservice_IPrinterCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Xcheng.Printerservice.PrinterServiceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (string[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (string));
			var p1 = global::Android.Runtime.JavaList.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = (global::Com.Xcheng.Printerservice.IPrinterCallback)global::Java.Lang.Object.GetObject<global::Com.Xcheng.Printerservice.IPrinterCallback> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.PrintColumnsTextWithAttributes (p0, p1, p2);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.xcheng.printerservice']/interface[@name='IPrinterService']/method[@name='printColumnsTextWithAttributes' and count(parameter)=3 and parameter[1][@type='java.lang.String[]'] and parameter[2][@type='java.util.List'] and parameter[3][@type='com.xcheng.printerservice.IPrinterCallback']]"
		[Register ("printColumnsTextWithAttributes", "([Ljava/lang/String;Ljava/util/List;Lcom/xcheng/printerservice/IPrinterCallback;)V", "GetPrintColumnsTextWithAttributes_arrayLjava_lang_String_Ljava_util_List_Lcom_xcheng_printerservice_IPrinterCallback_Handler")]
		public abstract void PrintColumnsTextWithAttributes (string[] p0, global::System.Collections.IList p1, global::Com.Xcheng.Printerservice.IPrinterCallback p2);

		static Delegate cb_printQRCode_Ljava_lang_String_IILcom_xcheng_printerservice_IPrinterCallback_;
#pragma warning disable 0169
		static Delegate GetPrintQRCode_Ljava_lang_String_IILcom_xcheng_printerservice_IPrinterCallback_Handler ()
		{
			if (cb_printQRCode_Ljava_lang_String_IILcom_xcheng_printerservice_IPrinterCallback_ == null)
				cb_printQRCode_Ljava_lang_String_IILcom_xcheng_printerservice_IPrinterCallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLIIL_V) n_PrintQRCode_Ljava_lang_String_IILcom_xcheng_printerservice_IPrinterCallback_);
			return cb_printQRCode_Ljava_lang_String_IILcom_xcheng_printerservice_IPrinterCallback_;
		}

		static void n_PrintQRCode_Ljava_lang_String_IILcom_xcheng_printerservice_IPrinterCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2, IntPtr native_p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Xcheng.Printerservice.PrinterServiceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p3 = (global::Com.Xcheng.Printerservice.IPrinterCallback)global::Java.Lang.Object.GetObject<global::Com.Xcheng.Printerservice.IPrinterCallback> (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.PrintQRCode (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.xcheng.printerservice']/interface[@name='IPrinterService']/method[@name='printQRCode' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='com.xcheng.printerservice.IPrinterCallback']]"
		[Register ("printQRCode", "(Ljava/lang/String;IILcom/xcheng/printerservice/IPrinterCallback;)V", "GetPrintQRCode_Ljava_lang_String_IILcom_xcheng_printerservice_IPrinterCallback_Handler")]
		public abstract void PrintQRCode (string p0, int p1, int p2, global::Com.Xcheng.Printerservice.IPrinterCallback p3);

		static Delegate cb_printText_Ljava_lang_String_Lcom_xcheng_printerservice_IPrinterCallback_;
#pragma warning disable 0169
		static Delegate GetPrintText_Ljava_lang_String_Lcom_xcheng_printerservice_IPrinterCallback_Handler ()
		{
			if (cb_printText_Ljava_lang_String_Lcom_xcheng_printerservice_IPrinterCallback_ == null)
				cb_printText_Ljava_lang_String_Lcom_xcheng_printerservice_IPrinterCallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_PrintText_Ljava_lang_String_Lcom_xcheng_printerservice_IPrinterCallback_);
			return cb_printText_Ljava_lang_String_Lcom_xcheng_printerservice_IPrinterCallback_;
		}

		static void n_PrintText_Ljava_lang_String_Lcom_xcheng_printerservice_IPrinterCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Xcheng.Printerservice.PrinterServiceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Com.Xcheng.Printerservice.IPrinterCallback)global::Java.Lang.Object.GetObject<global::Com.Xcheng.Printerservice.IPrinterCallback> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.PrintText (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.xcheng.printerservice']/interface[@name='IPrinterService']/method[@name='printText' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.xcheng.printerservice.IPrinterCallback']]"
		[Register ("printText", "(Ljava/lang/String;Lcom/xcheng/printerservice/IPrinterCallback;)V", "GetPrintText_Ljava_lang_String_Lcom_xcheng_printerservice_IPrinterCallback_Handler")]
		public abstract void PrintText (string p0, global::Com.Xcheng.Printerservice.IPrinterCallback p1);

		static Delegate cb_printTextWithAttributes_Ljava_lang_String_Ljava_util_Map_Lcom_xcheng_printerservice_IPrinterCallback_;
#pragma warning disable 0169
		static Delegate GetPrintTextWithAttributes_Ljava_lang_String_Ljava_util_Map_Lcom_xcheng_printerservice_IPrinterCallback_Handler ()
		{
			if (cb_printTextWithAttributes_Ljava_lang_String_Ljava_util_Map_Lcom_xcheng_printerservice_IPrinterCallback_ == null)
				cb_printTextWithAttributes_Ljava_lang_String_Ljava_util_Map_Lcom_xcheng_printerservice_IPrinterCallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_PrintTextWithAttributes_Ljava_lang_String_Ljava_util_Map_Lcom_xcheng_printerservice_IPrinterCallback_);
			return cb_printTextWithAttributes_Ljava_lang_String_Ljava_util_Map_Lcom_xcheng_printerservice_IPrinterCallback_;
		}

		static void n_PrintTextWithAttributes_Ljava_lang_String_Ljava_util_Map_Lcom_xcheng_printerservice_IPrinterCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Xcheng.Printerservice.PrinterServiceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Android.Runtime.JavaDictionary.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = (global::Com.Xcheng.Printerservice.IPrinterCallback)global::Java.Lang.Object.GetObject<global::Com.Xcheng.Printerservice.IPrinterCallback> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.PrintTextWithAttributes (p0, p1, p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.xcheng.printerservice']/interface[@name='IPrinterService']/method[@name='printTextWithAttributes' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.Map'] and parameter[3][@type='com.xcheng.printerservice.IPrinterCallback']]"
		[Register ("printTextWithAttributes", "(Ljava/lang/String;Ljava/util/Map;Lcom/xcheng/printerservice/IPrinterCallback;)V", "GetPrintTextWithAttributes_Ljava_lang_String_Ljava_util_Map_Lcom_xcheng_printerservice_IPrinterCallback_Handler")]
		public abstract void PrintTextWithAttributes (string p0, global::System.Collections.IDictionary p1, global::Com.Xcheng.Printerservice.IPrinterCallback p2);

		static Delegate cb_printWrapPaper_ILcom_xcheng_printerservice_IPrinterCallback_;
#pragma warning disable 0169
		static Delegate GetPrintWrapPaper_ILcom_xcheng_printerservice_IPrinterCallback_Handler ()
		{
			if (cb_printWrapPaper_ILcom_xcheng_printerservice_IPrinterCallback_ == null)
				cb_printWrapPaper_ILcom_xcheng_printerservice_IPrinterCallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIL_V) n_PrintWrapPaper_ILcom_xcheng_printerservice_IPrinterCallback_);
			return cb_printWrapPaper_ILcom_xcheng_printerservice_IPrinterCallback_;
		}

		static void n_PrintWrapPaper_ILcom_xcheng_printerservice_IPrinterCallback_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Xcheng.Printerservice.PrinterServiceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Com.Xcheng.Printerservice.IPrinterCallback)global::Java.Lang.Object.GetObject<global::Com.Xcheng.Printerservice.IPrinterCallback> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.PrintWrapPaper (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.xcheng.printerservice']/interface[@name='IPrinterService']/method[@name='printWrapPaper' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.xcheng.printerservice.IPrinterCallback']]"
		[Register ("printWrapPaper", "(ILcom/xcheng/printerservice/IPrinterCallback;)V", "GetPrintWrapPaper_ILcom_xcheng_printerservice_IPrinterCallback_Handler")]
		public abstract void PrintWrapPaper (int p0, global::Com.Xcheng.Printerservice.IPrinterCallback p1);

		static Delegate cb_printerInit_Lcom_xcheng_printerservice_IPrinterCallback_;
#pragma warning disable 0169
		static Delegate GetPrinterInit_Lcom_xcheng_printerservice_IPrinterCallback_Handler ()
		{
			if (cb_printerInit_Lcom_xcheng_printerservice_IPrinterCallback_ == null)
				cb_printerInit_Lcom_xcheng_printerservice_IPrinterCallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_PrinterInit_Lcom_xcheng_printerservice_IPrinterCallback_);
			return cb_printerInit_Lcom_xcheng_printerservice_IPrinterCallback_;
		}

		static void n_PrinterInit_Lcom_xcheng_printerservice_IPrinterCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Xcheng.Printerservice.PrinterServiceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Xcheng.Printerservice.IPrinterCallback)global::Java.Lang.Object.GetObject<global::Com.Xcheng.Printerservice.IPrinterCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PrinterInit (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.xcheng.printerservice']/interface[@name='IPrinterService']/method[@name='printerInit' and count(parameter)=1 and parameter[1][@type='com.xcheng.printerservice.IPrinterCallback']]"
		[Register ("printerInit", "(Lcom/xcheng/printerservice/IPrinterCallback;)V", "GetPrinterInit_Lcom_xcheng_printerservice_IPrinterCallback_Handler")]
		public abstract void PrinterInit (global::Com.Xcheng.Printerservice.IPrinterCallback p0);

		static Delegate cb_printerPaper_Lcom_xcheng_printerservice_IPrinterCallback_;
#pragma warning disable 0169
		static Delegate GetPrinterPaper_Lcom_xcheng_printerservice_IPrinterCallback_Handler ()
		{
			if (cb_printerPaper_Lcom_xcheng_printerservice_IPrinterCallback_ == null)
				cb_printerPaper_Lcom_xcheng_printerservice_IPrinterCallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_PrinterPaper_Lcom_xcheng_printerservice_IPrinterCallback_);
			return cb_printerPaper_Lcom_xcheng_printerservice_IPrinterCallback_;
		}

		static bool n_PrinterPaper_Lcom_xcheng_printerservice_IPrinterCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Xcheng.Printerservice.PrinterServiceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Xcheng.Printerservice.IPrinterCallback)global::Java.Lang.Object.GetObject<global::Com.Xcheng.Printerservice.IPrinterCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.PrinterPaper (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.xcheng.printerservice']/interface[@name='IPrinterService']/method[@name='printerPaper' and count(parameter)=1 and parameter[1][@type='com.xcheng.printerservice.IPrinterCallback']]"
		[Register ("printerPaper", "(Lcom/xcheng/printerservice/IPrinterCallback;)Z", "GetPrinterPaper_Lcom_xcheng_printerservice_IPrinterCallback_Handler")]
		public abstract bool PrinterPaper (global::Com.Xcheng.Printerservice.IPrinterCallback p0);

		static Delegate cb_printerReset_Lcom_xcheng_printerservice_IPrinterCallback_;
#pragma warning disable 0169
		static Delegate GetPrinterReset_Lcom_xcheng_printerservice_IPrinterCallback_Handler ()
		{
			if (cb_printerReset_Lcom_xcheng_printerservice_IPrinterCallback_ == null)
				cb_printerReset_Lcom_xcheng_printerservice_IPrinterCallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_PrinterReset_Lcom_xcheng_printerservice_IPrinterCallback_);
			return cb_printerReset_Lcom_xcheng_printerservice_IPrinterCallback_;
		}

		static void n_PrinterReset_Lcom_xcheng_printerservice_IPrinterCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Xcheng.Printerservice.PrinterServiceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Xcheng.Printerservice.IPrinterCallback)global::Java.Lang.Object.GetObject<global::Com.Xcheng.Printerservice.IPrinterCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PrinterReset (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.xcheng.printerservice']/interface[@name='IPrinterService']/method[@name='printerReset' and count(parameter)=1 and parameter[1][@type='com.xcheng.printerservice.IPrinterCallback']]"
		[Register ("printerReset", "(Lcom/xcheng/printerservice/IPrinterCallback;)V", "GetPrinterReset_Lcom_xcheng_printerservice_IPrinterCallback_Handler")]
		public abstract void PrinterReset (global::Com.Xcheng.Printerservice.IPrinterCallback p0);

		static Delegate cb_printerTemperature_Lcom_xcheng_printerservice_IPrinterCallback_;
#pragma warning disable 0169
		static Delegate GetPrinterTemperature_Lcom_xcheng_printerservice_IPrinterCallback_Handler ()
		{
			if (cb_printerTemperature_Lcom_xcheng_printerservice_IPrinterCallback_ == null)
				cb_printerTemperature_Lcom_xcheng_printerservice_IPrinterCallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_I) n_PrinterTemperature_Lcom_xcheng_printerservice_IPrinterCallback_);
			return cb_printerTemperature_Lcom_xcheng_printerservice_IPrinterCallback_;
		}

		static int n_PrinterTemperature_Lcom_xcheng_printerservice_IPrinterCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Xcheng.Printerservice.PrinterServiceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Xcheng.Printerservice.IPrinterCallback)global::Java.Lang.Object.GetObject<global::Com.Xcheng.Printerservice.IPrinterCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.PrinterTemperature (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.xcheng.printerservice']/interface[@name='IPrinterService']/method[@name='printerTemperature' and count(parameter)=1 and parameter[1][@type='com.xcheng.printerservice.IPrinterCallback']]"
		[Register ("printerTemperature", "(Lcom/xcheng/printerservice/IPrinterCallback;)I", "GetPrinterTemperature_Lcom_xcheng_printerservice_IPrinterCallback_Handler")]
		public abstract int PrinterTemperature (global::Com.Xcheng.Printerservice.IPrinterCallback p0);

		static Delegate cb_sendRAWData_arrayBLcom_xcheng_printerservice_IPrinterCallback_;
#pragma warning disable 0169
		static Delegate GetSendRAWData_arrayBLcom_xcheng_printerservice_IPrinterCallback_Handler ()
		{
			if (cb_sendRAWData_arrayBLcom_xcheng_printerservice_IPrinterCallback_ == null)
				cb_sendRAWData_arrayBLcom_xcheng_printerservice_IPrinterCallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_SendRAWData_arrayBLcom_xcheng_printerservice_IPrinterCallback_);
			return cb_sendRAWData_arrayBLcom_xcheng_printerservice_IPrinterCallback_;
		}

		static void n_SendRAWData_arrayBLcom_xcheng_printerservice_IPrinterCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Xcheng.Printerservice.PrinterServiceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p1 = (global::Com.Xcheng.Printerservice.IPrinterCallback)global::Java.Lang.Object.GetObject<global::Com.Xcheng.Printerservice.IPrinterCallback> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SendRAWData (p0, p1);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.xcheng.printerservice']/interface[@name='IPrinterService']/method[@name='sendRAWData' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='com.xcheng.printerservice.IPrinterCallback']]"
		[Register ("sendRAWData", "([BLcom/xcheng/printerservice/IPrinterCallback;)V", "GetSendRAWData_arrayBLcom_xcheng_printerservice_IPrinterCallback_Handler")]
		public abstract void SendRAWData (byte[] p0, global::Com.Xcheng.Printerservice.IPrinterCallback p1);

		static Delegate cb_setPrinterSpeed_ILcom_xcheng_printerservice_IPrinterCallback_;
#pragma warning disable 0169
		static Delegate GetSetPrinterSpeed_ILcom_xcheng_printerservice_IPrinterCallback_Handler ()
		{
			if (cb_setPrinterSpeed_ILcom_xcheng_printerservice_IPrinterCallback_ == null)
				cb_setPrinterSpeed_ILcom_xcheng_printerservice_IPrinterCallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIL_V) n_SetPrinterSpeed_ILcom_xcheng_printerservice_IPrinterCallback_);
			return cb_setPrinterSpeed_ILcom_xcheng_printerservice_IPrinterCallback_;
		}

		static void n_SetPrinterSpeed_ILcom_xcheng_printerservice_IPrinterCallback_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Xcheng.Printerservice.PrinterServiceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Com.Xcheng.Printerservice.IPrinterCallback)global::Java.Lang.Object.GetObject<global::Com.Xcheng.Printerservice.IPrinterCallback> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetPrinterSpeed (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.xcheng.printerservice']/interface[@name='IPrinterService']/method[@name='setPrinterSpeed' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.xcheng.printerservice.IPrinterCallback']]"
		[Register ("setPrinterSpeed", "(ILcom/xcheng/printerservice/IPrinterCallback;)V", "GetSetPrinterSpeed_ILcom_xcheng_printerservice_IPrinterCallback_Handler")]
		public abstract void SetPrinterSpeed (int p0, global::Com.Xcheng.Printerservice.IPrinterCallback p1);

		static Delegate cb_upgradePrinter;
#pragma warning disable 0169
		static Delegate GetUpgradePrinterHandler ()
		{
			if (cb_upgradePrinter == null)
				cb_upgradePrinter = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_UpgradePrinter);
			return cb_upgradePrinter;
		}

		static void n_UpgradePrinter (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Xcheng.Printerservice.PrinterServiceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UpgradePrinter ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.xcheng.printerservice']/interface[@name='IPrinterService']/method[@name='upgradePrinter' and count(parameter)=0]"
		[Register ("upgradePrinter", "()V", "GetUpgradePrinterHandler")]
		public abstract void UpgradePrinter ();

		static Delegate cb_getBootloaderVersion;
#pragma warning disable 0169
		static Delegate GetGetBootloaderVersionHandler ()
		{
			if (cb_getBootloaderVersion == null)
				cb_getBootloaderVersion = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetBootloaderVersion);
			return cb_getBootloaderVersion;
		}

		static IntPtr n_GetBootloaderVersion (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Xcheng.Printerservice.PrinterServiceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.BootloaderVersion);
		}
#pragma warning restore 0169

		public abstract string BootloaderVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.xcheng.printerservice']/class[@name='IPrinterService.Stub']/method[@name='getBootloaderVersion' and count(parameter)=0]"
			[Register ("getBootloaderVersion", "()Ljava/lang/String;", "GetGetBootloaderVersionHandler")]
			get; 
		}

		static Delegate cb_getFirmwareVersion;
#pragma warning disable 0169
		static Delegate GetGetFirmwareVersionHandler ()
		{
			if (cb_getFirmwareVersion == null)
				cb_getFirmwareVersion = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetFirmwareVersion);
			return cb_getFirmwareVersion;
		}

		static IntPtr n_GetFirmwareVersion (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Xcheng.Printerservice.PrinterServiceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.FirmwareVersion);
		}
#pragma warning restore 0169

		public abstract string FirmwareVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.xcheng.printerservice']/class[@name='IPrinterService.Stub']/method[@name='getFirmwareVersion' and count(parameter)=0]"
			[Register ("getFirmwareVersion", "()Ljava/lang/String;", "GetGetFirmwareVersionHandler")]
			get; 
		}

	}

	[global::Android.Runtime.Register ("com/xcheng/printerservice/IPrinterService$Stub", DoNotGenerateAcw=true)]
	internal partial class PrinterServiceStubInvoker : PrinterServiceStub {
		public PrinterServiceStubInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/xcheng/printerservice/IPrinterService$Stub", typeof (PrinterServiceStubInvoker));

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

		public override unsafe string BootloaderVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.xcheng.printerservice']/class[@name='IPrinterService.Stub']/method[@name='getBootloaderVersion' and count(parameter)=0]"
			[Register ("getBootloaderVersion", "()Ljava/lang/String;", "GetGetBootloaderVersionHandler")]
			get {
				const string __id = "getBootloaderVersion.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public override unsafe string FirmwareVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.xcheng.printerservice']/class[@name='IPrinterService.Stub']/method[@name='getFirmwareVersion' and count(parameter)=0]"
			[Register ("getFirmwareVersion", "()Ljava/lang/String;", "GetGetFirmwareVersionHandler")]
			get {
				const string __id = "getFirmwareVersion.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.xcheng.printerservice']/interface[@name='IPrinterService']/method[@name='printBarCode' and count(parameter)=6 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='boolean'] and parameter[6][@type='com.xcheng.printerservice.IPrinterCallback']]"
		[Register ("printBarCode", "(Ljava/lang/String;IIIZLcom/xcheng/printerservice/IPrinterCallback;)V", "GetPrintBarCode_Ljava_lang_String_IIIZLcom_xcheng_printerservice_IPrinterCallback_Handler")]
		public override unsafe void PrintBarCode (string p0, int p1, int p2, int p3, bool p4, global::Com.Xcheng.Printerservice.IPrinterCallback p5)
		{
			const string __id = "printBarCode.(Ljava/lang/String;IIIZLcom/xcheng/printerservice/IPrinterCallback;)V";
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.xcheng.printerservice']/interface[@name='IPrinterService']/method[@name='printBitmap' and count(parameter)=2 and parameter[1][@type='android.graphics.Bitmap'] and parameter[2][@type='com.xcheng.printerservice.IPrinterCallback']]"
		[Register ("printBitmap", "(Landroid/graphics/Bitmap;Lcom/xcheng/printerservice/IPrinterCallback;)V", "GetPrintBitmap_Landroid_graphics_Bitmap_Lcom_xcheng_printerservice_IPrinterCallback_Handler")]
		public override unsafe void PrintBitmap (global::Android.Graphics.Bitmap p0, global::Com.Xcheng.Printerservice.IPrinterCallback p1)
		{
			const string __id = "printBitmap.(Landroid/graphics/Bitmap;Lcom/xcheng/printerservice/IPrinterCallback;)V";
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.xcheng.printerservice']/interface[@name='IPrinterService']/method[@name='printBitmapWithAttributes' and count(parameter)=3 and parameter[1][@type='android.graphics.Bitmap'] and parameter[2][@type='java.util.Map'] and parameter[3][@type='com.xcheng.printerservice.IPrinterCallback']]"
		[Register ("printBitmapWithAttributes", "(Landroid/graphics/Bitmap;Ljava/util/Map;Lcom/xcheng/printerservice/IPrinterCallback;)V", "GetPrintBitmapWithAttributes_Landroid_graphics_Bitmap_Ljava_util_Map_Lcom_xcheng_printerservice_IPrinterCallback_Handler")]
		public override unsafe void PrintBitmapWithAttributes (global::Android.Graphics.Bitmap p0, global::System.Collections.IDictionary p1, global::Com.Xcheng.Printerservice.IPrinterCallback p2)
		{
			const string __id = "printBitmapWithAttributes.(Landroid/graphics/Bitmap;Ljava/util/Map;Lcom/xcheng/printerservice/IPrinterCallback;)V";
			IntPtr native_p1 = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
				global::System.GC.KeepAlive (p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.xcheng.printerservice']/interface[@name='IPrinterService']/method[@name='printColumnsTextWithAttributes' and count(parameter)=3 and parameter[1][@type='java.lang.String[]'] and parameter[2][@type='java.util.List'] and parameter[3][@type='com.xcheng.printerservice.IPrinterCallback']]"
		[Register ("printColumnsTextWithAttributes", "([Ljava/lang/String;Ljava/util/List;Lcom/xcheng/printerservice/IPrinterCallback;)V", "GetPrintColumnsTextWithAttributes_arrayLjava_lang_String_Ljava_util_List_Lcom_xcheng_printerservice_IPrinterCallback_Handler")]
		public override unsafe void PrintColumnsTextWithAttributes (string[] p0, global::System.Collections.IList p1, global::Com.Xcheng.Printerservice.IPrinterCallback p2)
		{
			const string __id = "printColumnsTextWithAttributes.([Ljava/lang/String;Ljava/util/List;Lcom/xcheng/printerservice/IPrinterCallback;)V";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaList.ToLocalJniHandle (p1);
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
				JNIEnv.DeleteLocalRef (native_p1);
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
				global::System.GC.KeepAlive (p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.xcheng.printerservice']/interface[@name='IPrinterService']/method[@name='printQRCode' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='com.xcheng.printerservice.IPrinterCallback']]"
		[Register ("printQRCode", "(Ljava/lang/String;IILcom/xcheng/printerservice/IPrinterCallback;)V", "GetPrintQRCode_Ljava_lang_String_IILcom_xcheng_printerservice_IPrinterCallback_Handler")]
		public override unsafe void PrintQRCode (string p0, int p1, int p2, global::Com.Xcheng.Printerservice.IPrinterCallback p3)
		{
			const string __id = "printQRCode.(Ljava/lang/String;IILcom/xcheng/printerservice/IPrinterCallback;)V";
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.xcheng.printerservice']/interface[@name='IPrinterService']/method[@name='printText' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.xcheng.printerservice.IPrinterCallback']]"
		[Register ("printText", "(Ljava/lang/String;Lcom/xcheng/printerservice/IPrinterCallback;)V", "GetPrintText_Ljava_lang_String_Lcom_xcheng_printerservice_IPrinterCallback_Handler")]
		public override unsafe void PrintText (string p0, global::Com.Xcheng.Printerservice.IPrinterCallback p1)
		{
			const string __id = "printText.(Ljava/lang/String;Lcom/xcheng/printerservice/IPrinterCallback;)V";
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.xcheng.printerservice']/interface[@name='IPrinterService']/method[@name='printTextWithAttributes' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.Map'] and parameter[3][@type='com.xcheng.printerservice.IPrinterCallback']]"
		[Register ("printTextWithAttributes", "(Ljava/lang/String;Ljava/util/Map;Lcom/xcheng/printerservice/IPrinterCallback;)V", "GetPrintTextWithAttributes_Ljava_lang_String_Ljava_util_Map_Lcom_xcheng_printerservice_IPrinterCallback_Handler")]
		public override unsafe void PrintTextWithAttributes (string p0, global::System.Collections.IDictionary p1, global::Com.Xcheng.Printerservice.IPrinterCallback p2)
		{
			const string __id = "printTextWithAttributes.(Ljava/lang/String;Ljava/util/Map;Lcom/xcheng/printerservice/IPrinterCallback;)V";
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			IntPtr native_p1 = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				global::System.GC.KeepAlive (p1);
				global::System.GC.KeepAlive (p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.xcheng.printerservice']/interface[@name='IPrinterService']/method[@name='printWrapPaper' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.xcheng.printerservice.IPrinterCallback']]"
		[Register ("printWrapPaper", "(ILcom/xcheng/printerservice/IPrinterCallback;)V", "GetPrintWrapPaper_ILcom_xcheng_printerservice_IPrinterCallback_Handler")]
		public override unsafe void PrintWrapPaper (int p0, global::Com.Xcheng.Printerservice.IPrinterCallback p1)
		{
			const string __id = "printWrapPaper.(ILcom/xcheng/printerservice/IPrinterCallback;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.xcheng.printerservice']/interface[@name='IPrinterService']/method[@name='printerInit' and count(parameter)=1 and parameter[1][@type='com.xcheng.printerservice.IPrinterCallback']]"
		[Register ("printerInit", "(Lcom/xcheng/printerservice/IPrinterCallback;)V", "GetPrinterInit_Lcom_xcheng_printerservice_IPrinterCallback_Handler")]
		public override unsafe void PrinterInit (global::Com.Xcheng.Printerservice.IPrinterCallback p0)
		{
			const string __id = "printerInit.(Lcom/xcheng/printerservice/IPrinterCallback;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.xcheng.printerservice']/interface[@name='IPrinterService']/method[@name='printerPaper' and count(parameter)=1 and parameter[1][@type='com.xcheng.printerservice.IPrinterCallback']]"
		[Register ("printerPaper", "(Lcom/xcheng/printerservice/IPrinterCallback;)Z", "GetPrinterPaper_Lcom_xcheng_printerservice_IPrinterCallback_Handler")]
		public override unsafe bool PrinterPaper (global::Com.Xcheng.Printerservice.IPrinterCallback p0)
		{
			const string __id = "printerPaper.(Lcom/xcheng/printerservice/IPrinterCallback;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.xcheng.printerservice']/interface[@name='IPrinterService']/method[@name='printerReset' and count(parameter)=1 and parameter[1][@type='com.xcheng.printerservice.IPrinterCallback']]"
		[Register ("printerReset", "(Lcom/xcheng/printerservice/IPrinterCallback;)V", "GetPrinterReset_Lcom_xcheng_printerservice_IPrinterCallback_Handler")]
		public override unsafe void PrinterReset (global::Com.Xcheng.Printerservice.IPrinterCallback p0)
		{
			const string __id = "printerReset.(Lcom/xcheng/printerservice/IPrinterCallback;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.xcheng.printerservice']/interface[@name='IPrinterService']/method[@name='printerTemperature' and count(parameter)=1 and parameter[1][@type='com.xcheng.printerservice.IPrinterCallback']]"
		[Register ("printerTemperature", "(Lcom/xcheng/printerservice/IPrinterCallback;)I", "GetPrinterTemperature_Lcom_xcheng_printerservice_IPrinterCallback_Handler")]
		public override unsafe int PrinterTemperature (global::Com.Xcheng.Printerservice.IPrinterCallback p0)
		{
			const string __id = "printerTemperature.(Lcom/xcheng/printerservice/IPrinterCallback;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.xcheng.printerservice']/interface[@name='IPrinterService']/method[@name='sendRAWData' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='com.xcheng.printerservice.IPrinterCallback']]"
		[Register ("sendRAWData", "([BLcom/xcheng/printerservice/IPrinterCallback;)V", "GetSendRAWData_arrayBLcom_xcheng_printerservice_IPrinterCallback_Handler")]
		public override unsafe void SendRAWData (byte[] p0, global::Com.Xcheng.Printerservice.IPrinterCallback p1)
		{
			const string __id = "sendRAWData.([BLcom/xcheng/printerservice/IPrinterCallback;)V";
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.xcheng.printerservice']/interface[@name='IPrinterService']/method[@name='setPrinterSpeed' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.xcheng.printerservice.IPrinterCallback']]"
		[Register ("setPrinterSpeed", "(ILcom/xcheng/printerservice/IPrinterCallback;)V", "GetSetPrinterSpeed_ILcom_xcheng_printerservice_IPrinterCallback_Handler")]
		public override unsafe void SetPrinterSpeed (int p0, global::Com.Xcheng.Printerservice.IPrinterCallback p1)
		{
			const string __id = "setPrinterSpeed.(ILcom/xcheng/printerservice/IPrinterCallback;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.xcheng.printerservice']/interface[@name='IPrinterService']/method[@name='upgradePrinter' and count(parameter)=0]"
		[Register ("upgradePrinter", "()V", "GetUpgradePrinterHandler")]
		public override unsafe void UpgradePrinter ()
		{
			const string __id = "upgradePrinter.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.xcheng.printerservice']/interface[@name='IPrinterService']"
	[Register ("com/xcheng/printerservice/IPrinterService", "", "Com.Xcheng.Printerservice.IPrinterServiceInvoker")]
	public partial interface IPrinterService : global::Android.OS.IInterface {
		string BootloaderVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.xcheng.printerservice']/interface[@name='IPrinterService']/method[@name='getBootloaderVersion' and count(parameter)=0]"
			[Register ("getBootloaderVersion", "()Ljava/lang/String;", "GetGetBootloaderVersionHandler:Com.Xcheng.Printerservice.IPrinterServiceInvoker, Binding")]
			get; 
		}

		string FirmwareVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.xcheng.printerservice']/interface[@name='IPrinterService']/method[@name='getFirmwareVersion' and count(parameter)=0]"
			[Register ("getFirmwareVersion", "()Ljava/lang/String;", "GetGetFirmwareVersionHandler:Com.Xcheng.Printerservice.IPrinterServiceInvoker, Binding")]
			get; 
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.xcheng.printerservice']/interface[@name='IPrinterService']/method[@name='printBarCode' and count(parameter)=6 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='boolean'] and parameter[6][@type='com.xcheng.printerservice.IPrinterCallback']]"
		[Register ("printBarCode", "(Ljava/lang/String;IIIZLcom/xcheng/printerservice/IPrinterCallback;)V", "GetPrintBarCode_Ljava_lang_String_IIIZLcom_xcheng_printerservice_IPrinterCallback_Handler:Com.Xcheng.Printerservice.IPrinterServiceInvoker, Binding")]
		void PrintBarCode (string p0, int p1, int p2, int p3, bool p4, global::Com.Xcheng.Printerservice.IPrinterCallback p5);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.xcheng.printerservice']/interface[@name='IPrinterService']/method[@name='printBitmap' and count(parameter)=2 and parameter[1][@type='android.graphics.Bitmap'] and parameter[2][@type='com.xcheng.printerservice.IPrinterCallback']]"
		[Register ("printBitmap", "(Landroid/graphics/Bitmap;Lcom/xcheng/printerservice/IPrinterCallback;)V", "GetPrintBitmap_Landroid_graphics_Bitmap_Lcom_xcheng_printerservice_IPrinterCallback_Handler:Com.Xcheng.Printerservice.IPrinterServiceInvoker, Binding")]
		void PrintBitmap (global::Android.Graphics.Bitmap p0, global::Com.Xcheng.Printerservice.IPrinterCallback p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.xcheng.printerservice']/interface[@name='IPrinterService']/method[@name='printBitmapWithAttributes' and count(parameter)=3 and parameter[1][@type='android.graphics.Bitmap'] and parameter[2][@type='java.util.Map'] and parameter[3][@type='com.xcheng.printerservice.IPrinterCallback']]"
		[Register ("printBitmapWithAttributes", "(Landroid/graphics/Bitmap;Ljava/util/Map;Lcom/xcheng/printerservice/IPrinterCallback;)V", "GetPrintBitmapWithAttributes_Landroid_graphics_Bitmap_Ljava_util_Map_Lcom_xcheng_printerservice_IPrinterCallback_Handler:Com.Xcheng.Printerservice.IPrinterServiceInvoker, Binding")]
		void PrintBitmapWithAttributes (global::Android.Graphics.Bitmap p0, global::System.Collections.IDictionary p1, global::Com.Xcheng.Printerservice.IPrinterCallback p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.xcheng.printerservice']/interface[@name='IPrinterService']/method[@name='printColumnsTextWithAttributes' and count(parameter)=3 and parameter[1][@type='java.lang.String[]'] and parameter[2][@type='java.util.List'] and parameter[3][@type='com.xcheng.printerservice.IPrinterCallback']]"
		[Register ("printColumnsTextWithAttributes", "([Ljava/lang/String;Ljava/util/List;Lcom/xcheng/printerservice/IPrinterCallback;)V", "GetPrintColumnsTextWithAttributes_arrayLjava_lang_String_Ljava_util_List_Lcom_xcheng_printerservice_IPrinterCallback_Handler:Com.Xcheng.Printerservice.IPrinterServiceInvoker, Binding")]
		void PrintColumnsTextWithAttributes (string[] p0, global::System.Collections.IList p1, global::Com.Xcheng.Printerservice.IPrinterCallback p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.xcheng.printerservice']/interface[@name='IPrinterService']/method[@name='printQRCode' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='com.xcheng.printerservice.IPrinterCallback']]"
		[Register ("printQRCode", "(Ljava/lang/String;IILcom/xcheng/printerservice/IPrinterCallback;)V", "GetPrintQRCode_Ljava_lang_String_IILcom_xcheng_printerservice_IPrinterCallback_Handler:Com.Xcheng.Printerservice.IPrinterServiceInvoker, Binding")]
		void PrintQRCode (string p0, int p1, int p2, global::Com.Xcheng.Printerservice.IPrinterCallback p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.xcheng.printerservice']/interface[@name='IPrinterService']/method[@name='printText' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.xcheng.printerservice.IPrinterCallback']]"
		[Register ("printText", "(Ljava/lang/String;Lcom/xcheng/printerservice/IPrinterCallback;)V", "GetPrintText_Ljava_lang_String_Lcom_xcheng_printerservice_IPrinterCallback_Handler:Com.Xcheng.Printerservice.IPrinterServiceInvoker, Binding")]
		void PrintText (string p0, global::Com.Xcheng.Printerservice.IPrinterCallback p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.xcheng.printerservice']/interface[@name='IPrinterService']/method[@name='printTextWithAttributes' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.Map'] and parameter[3][@type='com.xcheng.printerservice.IPrinterCallback']]"
		[Register ("printTextWithAttributes", "(Ljava/lang/String;Ljava/util/Map;Lcom/xcheng/printerservice/IPrinterCallback;)V", "GetPrintTextWithAttributes_Ljava_lang_String_Ljava_util_Map_Lcom_xcheng_printerservice_IPrinterCallback_Handler:Com.Xcheng.Printerservice.IPrinterServiceInvoker, Binding")]
		void PrintTextWithAttributes (string p0, global::System.Collections.IDictionary p1, global::Com.Xcheng.Printerservice.IPrinterCallback p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.xcheng.printerservice']/interface[@name='IPrinterService']/method[@name='printWrapPaper' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.xcheng.printerservice.IPrinterCallback']]"
		[Register ("printWrapPaper", "(ILcom/xcheng/printerservice/IPrinterCallback;)V", "GetPrintWrapPaper_ILcom_xcheng_printerservice_IPrinterCallback_Handler:Com.Xcheng.Printerservice.IPrinterServiceInvoker, Binding")]
		void PrintWrapPaper (int p0, global::Com.Xcheng.Printerservice.IPrinterCallback p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.xcheng.printerservice']/interface[@name='IPrinterService']/method[@name='printerInit' and count(parameter)=1 and parameter[1][@type='com.xcheng.printerservice.IPrinterCallback']]"
		[Register ("printerInit", "(Lcom/xcheng/printerservice/IPrinterCallback;)V", "GetPrinterInit_Lcom_xcheng_printerservice_IPrinterCallback_Handler:Com.Xcheng.Printerservice.IPrinterServiceInvoker, Binding")]
		void PrinterInit (global::Com.Xcheng.Printerservice.IPrinterCallback p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.xcheng.printerservice']/interface[@name='IPrinterService']/method[@name='printerPaper' and count(parameter)=1 and parameter[1][@type='com.xcheng.printerservice.IPrinterCallback']]"
		[Register ("printerPaper", "(Lcom/xcheng/printerservice/IPrinterCallback;)Z", "GetPrinterPaper_Lcom_xcheng_printerservice_IPrinterCallback_Handler:Com.Xcheng.Printerservice.IPrinterServiceInvoker, Binding")]
		bool PrinterPaper (global::Com.Xcheng.Printerservice.IPrinterCallback p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.xcheng.printerservice']/interface[@name='IPrinterService']/method[@name='printerReset' and count(parameter)=1 and parameter[1][@type='com.xcheng.printerservice.IPrinterCallback']]"
		[Register ("printerReset", "(Lcom/xcheng/printerservice/IPrinterCallback;)V", "GetPrinterReset_Lcom_xcheng_printerservice_IPrinterCallback_Handler:Com.Xcheng.Printerservice.IPrinterServiceInvoker, Binding")]
		void PrinterReset (global::Com.Xcheng.Printerservice.IPrinterCallback p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.xcheng.printerservice']/interface[@name='IPrinterService']/method[@name='printerTemperature' and count(parameter)=1 and parameter[1][@type='com.xcheng.printerservice.IPrinterCallback']]"
		[Register ("printerTemperature", "(Lcom/xcheng/printerservice/IPrinterCallback;)I", "GetPrinterTemperature_Lcom_xcheng_printerservice_IPrinterCallback_Handler:Com.Xcheng.Printerservice.IPrinterServiceInvoker, Binding")]
		int PrinterTemperature (global::Com.Xcheng.Printerservice.IPrinterCallback p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.xcheng.printerservice']/interface[@name='IPrinterService']/method[@name='sendRAWData' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='com.xcheng.printerservice.IPrinterCallback']]"
		[Register ("sendRAWData", "([BLcom/xcheng/printerservice/IPrinterCallback;)V", "GetSendRAWData_arrayBLcom_xcheng_printerservice_IPrinterCallback_Handler:Com.Xcheng.Printerservice.IPrinterServiceInvoker, Binding")]
		void SendRAWData (byte[] p0, global::Com.Xcheng.Printerservice.IPrinterCallback p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.xcheng.printerservice']/interface[@name='IPrinterService']/method[@name='setPrinterSpeed' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.xcheng.printerservice.IPrinterCallback']]"
		[Register ("setPrinterSpeed", "(ILcom/xcheng/printerservice/IPrinterCallback;)V", "GetSetPrinterSpeed_ILcom_xcheng_printerservice_IPrinterCallback_Handler:Com.Xcheng.Printerservice.IPrinterServiceInvoker, Binding")]
		void SetPrinterSpeed (int p0, global::Com.Xcheng.Printerservice.IPrinterCallback p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.xcheng.printerservice']/interface[@name='IPrinterService']/method[@name='upgradePrinter' and count(parameter)=0]"
		[Register ("upgradePrinter", "()V", "GetUpgradePrinterHandler:Com.Xcheng.Printerservice.IPrinterServiceInvoker, Binding")]
		void UpgradePrinter ();

	}

	[global::Android.Runtime.Register ("com/xcheng/printerservice/IPrinterService", DoNotGenerateAcw=true)]
	internal partial class IPrinterServiceInvoker : global::Java.Lang.Object, IPrinterService {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/xcheng/printerservice/IPrinterService", typeof (IPrinterServiceInvoker));

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

		public static IPrinterService GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IPrinterService> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.xcheng.printerservice.IPrinterService'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IPrinterServiceInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getBootloaderVersion;
#pragma warning disable 0169
		static Delegate GetGetBootloaderVersionHandler ()
		{
			if (cb_getBootloaderVersion == null)
				cb_getBootloaderVersion = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetBootloaderVersion);
			return cb_getBootloaderVersion;
		}

		static IntPtr n_GetBootloaderVersion (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Xcheng.Printerservice.IPrinterService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.BootloaderVersion);
		}
#pragma warning restore 0169

		IntPtr id_getBootloaderVersion;
		public unsafe string BootloaderVersion {
			get {
				if (id_getBootloaderVersion == IntPtr.Zero)
					id_getBootloaderVersion = JNIEnv.GetMethodID (class_ref, "getBootloaderVersion", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBootloaderVersion), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getFirmwareVersion;
#pragma warning disable 0169
		static Delegate GetGetFirmwareVersionHandler ()
		{
			if (cb_getFirmwareVersion == null)
				cb_getFirmwareVersion = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetFirmwareVersion);
			return cb_getFirmwareVersion;
		}

		static IntPtr n_GetFirmwareVersion (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Xcheng.Printerservice.IPrinterService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.FirmwareVersion);
		}
#pragma warning restore 0169

		IntPtr id_getFirmwareVersion;
		public unsafe string FirmwareVersion {
			get {
				if (id_getFirmwareVersion == IntPtr.Zero)
					id_getFirmwareVersion = JNIEnv.GetMethodID (class_ref, "getFirmwareVersion", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFirmwareVersion), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_printBarCode_Ljava_lang_String_IIIZLcom_xcheng_printerservice_IPrinterCallback_;
#pragma warning disable 0169
		static Delegate GetPrintBarCode_Ljava_lang_String_IIIZLcom_xcheng_printerservice_IPrinterCallback_Handler ()
		{
			if (cb_printBarCode_Ljava_lang_String_IIIZLcom_xcheng_printerservice_IPrinterCallback_ == null)
				cb_printBarCode_Ljava_lang_String_IIIZLcom_xcheng_printerservice_IPrinterCallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLIIIZL_V) n_PrintBarCode_Ljava_lang_String_IIIZLcom_xcheng_printerservice_IPrinterCallback_);
			return cb_printBarCode_Ljava_lang_String_IIIZLcom_xcheng_printerservice_IPrinterCallback_;
		}

		static void n_PrintBarCode_Ljava_lang_String_IIIZLcom_xcheng_printerservice_IPrinterCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2, int p3, bool p4, IntPtr native_p5)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Xcheng.Printerservice.IPrinterService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p5 = (global::Com.Xcheng.Printerservice.IPrinterCallback)global::Java.Lang.Object.GetObject<global::Com.Xcheng.Printerservice.IPrinterCallback> (native_p5, JniHandleOwnership.DoNotTransfer);
			__this.PrintBarCode (p0, p1, p2, p3, p4, p5);
		}
#pragma warning restore 0169

		IntPtr id_printBarCode_Ljava_lang_String_IIIZLcom_xcheng_printerservice_IPrinterCallback_;
		public unsafe void PrintBarCode (string p0, int p1, int p2, int p3, bool p4, global::Com.Xcheng.Printerservice.IPrinterCallback p5)
		{
			if (id_printBarCode_Ljava_lang_String_IIIZLcom_xcheng_printerservice_IPrinterCallback_ == IntPtr.Zero)
				id_printBarCode_Ljava_lang_String_IIIZLcom_xcheng_printerservice_IPrinterCallback_ = JNIEnv.GetMethodID (class_ref, "printBarCode", "(Ljava/lang/String;IIIZLcom/xcheng/printerservice/IPrinterCallback;)V");
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			JValue* __args = stackalloc JValue [6];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (p3);
			__args [4] = new JValue (p4);
			__args [5] = new JValue ((p5 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p5).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_printBarCode_Ljava_lang_String_IIIZLcom_xcheng_printerservice_IPrinterCallback_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_printBitmap_Landroid_graphics_Bitmap_Lcom_xcheng_printerservice_IPrinterCallback_;
#pragma warning disable 0169
		static Delegate GetPrintBitmap_Landroid_graphics_Bitmap_Lcom_xcheng_printerservice_IPrinterCallback_Handler ()
		{
			if (cb_printBitmap_Landroid_graphics_Bitmap_Lcom_xcheng_printerservice_IPrinterCallback_ == null)
				cb_printBitmap_Landroid_graphics_Bitmap_Lcom_xcheng_printerservice_IPrinterCallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_PrintBitmap_Landroid_graphics_Bitmap_Lcom_xcheng_printerservice_IPrinterCallback_);
			return cb_printBitmap_Landroid_graphics_Bitmap_Lcom_xcheng_printerservice_IPrinterCallback_;
		}

		static void n_PrintBitmap_Landroid_graphics_Bitmap_Lcom_xcheng_printerservice_IPrinterCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Xcheng.Printerservice.IPrinterService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Com.Xcheng.Printerservice.IPrinterCallback)global::Java.Lang.Object.GetObject<global::Com.Xcheng.Printerservice.IPrinterCallback> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.PrintBitmap (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_printBitmap_Landroid_graphics_Bitmap_Lcom_xcheng_printerservice_IPrinterCallback_;
		public unsafe void PrintBitmap (global::Android.Graphics.Bitmap p0, global::Com.Xcheng.Printerservice.IPrinterCallback p1)
		{
			if (id_printBitmap_Landroid_graphics_Bitmap_Lcom_xcheng_printerservice_IPrinterCallback_ == IntPtr.Zero)
				id_printBitmap_Landroid_graphics_Bitmap_Lcom_xcheng_printerservice_IPrinterCallback_ = JNIEnv.GetMethodID (class_ref, "printBitmap", "(Landroid/graphics/Bitmap;Lcom/xcheng/printerservice/IPrinterCallback;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_printBitmap_Landroid_graphics_Bitmap_Lcom_xcheng_printerservice_IPrinterCallback_, __args);
		}

		static Delegate cb_printBitmapWithAttributes_Landroid_graphics_Bitmap_Ljava_util_Map_Lcom_xcheng_printerservice_IPrinterCallback_;
#pragma warning disable 0169
		static Delegate GetPrintBitmapWithAttributes_Landroid_graphics_Bitmap_Ljava_util_Map_Lcom_xcheng_printerservice_IPrinterCallback_Handler ()
		{
			if (cb_printBitmapWithAttributes_Landroid_graphics_Bitmap_Ljava_util_Map_Lcom_xcheng_printerservice_IPrinterCallback_ == null)
				cb_printBitmapWithAttributes_Landroid_graphics_Bitmap_Ljava_util_Map_Lcom_xcheng_printerservice_IPrinterCallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_PrintBitmapWithAttributes_Landroid_graphics_Bitmap_Ljava_util_Map_Lcom_xcheng_printerservice_IPrinterCallback_);
			return cb_printBitmapWithAttributes_Landroid_graphics_Bitmap_Ljava_util_Map_Lcom_xcheng_printerservice_IPrinterCallback_;
		}

		static void n_PrintBitmapWithAttributes_Landroid_graphics_Bitmap_Ljava_util_Map_Lcom_xcheng_printerservice_IPrinterCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Xcheng.Printerservice.IPrinterService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Android.Runtime.JavaDictionary.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = (global::Com.Xcheng.Printerservice.IPrinterCallback)global::Java.Lang.Object.GetObject<global::Com.Xcheng.Printerservice.IPrinterCallback> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.PrintBitmapWithAttributes (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_printBitmapWithAttributes_Landroid_graphics_Bitmap_Ljava_util_Map_Lcom_xcheng_printerservice_IPrinterCallback_;
		public unsafe void PrintBitmapWithAttributes (global::Android.Graphics.Bitmap p0, global::System.Collections.IDictionary p1, global::Com.Xcheng.Printerservice.IPrinterCallback p2)
		{
			if (id_printBitmapWithAttributes_Landroid_graphics_Bitmap_Ljava_util_Map_Lcom_xcheng_printerservice_IPrinterCallback_ == IntPtr.Zero)
				id_printBitmapWithAttributes_Landroid_graphics_Bitmap_Ljava_util_Map_Lcom_xcheng_printerservice_IPrinterCallback_ = JNIEnv.GetMethodID (class_ref, "printBitmapWithAttributes", "(Landroid/graphics/Bitmap;Ljava/util/Map;Lcom/xcheng/printerservice/IPrinterCallback;)V");
			IntPtr native_p1 = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (p1);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_printBitmapWithAttributes_Landroid_graphics_Bitmap_Ljava_util_Map_Lcom_xcheng_printerservice_IPrinterCallback_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_printColumnsTextWithAttributes_arrayLjava_lang_String_Ljava_util_List_Lcom_xcheng_printerservice_IPrinterCallback_;
#pragma warning disable 0169
		static Delegate GetPrintColumnsTextWithAttributes_arrayLjava_lang_String_Ljava_util_List_Lcom_xcheng_printerservice_IPrinterCallback_Handler ()
		{
			if (cb_printColumnsTextWithAttributes_arrayLjava_lang_String_Ljava_util_List_Lcom_xcheng_printerservice_IPrinterCallback_ == null)
				cb_printColumnsTextWithAttributes_arrayLjava_lang_String_Ljava_util_List_Lcom_xcheng_printerservice_IPrinterCallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_PrintColumnsTextWithAttributes_arrayLjava_lang_String_Ljava_util_List_Lcom_xcheng_printerservice_IPrinterCallback_);
			return cb_printColumnsTextWithAttributes_arrayLjava_lang_String_Ljava_util_List_Lcom_xcheng_printerservice_IPrinterCallback_;
		}

		static void n_PrintColumnsTextWithAttributes_arrayLjava_lang_String_Ljava_util_List_Lcom_xcheng_printerservice_IPrinterCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Xcheng.Printerservice.IPrinterService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (string[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (string));
			var p1 = global::Android.Runtime.JavaList.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = (global::Com.Xcheng.Printerservice.IPrinterCallback)global::Java.Lang.Object.GetObject<global::Com.Xcheng.Printerservice.IPrinterCallback> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.PrintColumnsTextWithAttributes (p0, p1, p2);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		IntPtr id_printColumnsTextWithAttributes_arrayLjava_lang_String_Ljava_util_List_Lcom_xcheng_printerservice_IPrinterCallback_;
		public unsafe void PrintColumnsTextWithAttributes (string[] p0, global::System.Collections.IList p1, global::Com.Xcheng.Printerservice.IPrinterCallback p2)
		{
			if (id_printColumnsTextWithAttributes_arrayLjava_lang_String_Ljava_util_List_Lcom_xcheng_printerservice_IPrinterCallback_ == IntPtr.Zero)
				id_printColumnsTextWithAttributes_arrayLjava_lang_String_Ljava_util_List_Lcom_xcheng_printerservice_IPrinterCallback_ = JNIEnv.GetMethodID (class_ref, "printColumnsTextWithAttributes", "([Ljava/lang/String;Ljava/util/List;Lcom/xcheng/printerservice/IPrinterCallback;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaList.ToLocalJniHandle (p1);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_printColumnsTextWithAttributes_arrayLjava_lang_String_Ljava_util_List_Lcom_xcheng_printerservice_IPrinterCallback_, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_printQRCode_Ljava_lang_String_IILcom_xcheng_printerservice_IPrinterCallback_;
#pragma warning disable 0169
		static Delegate GetPrintQRCode_Ljava_lang_String_IILcom_xcheng_printerservice_IPrinterCallback_Handler ()
		{
			if (cb_printQRCode_Ljava_lang_String_IILcom_xcheng_printerservice_IPrinterCallback_ == null)
				cb_printQRCode_Ljava_lang_String_IILcom_xcheng_printerservice_IPrinterCallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLIIL_V) n_PrintQRCode_Ljava_lang_String_IILcom_xcheng_printerservice_IPrinterCallback_);
			return cb_printQRCode_Ljava_lang_String_IILcom_xcheng_printerservice_IPrinterCallback_;
		}

		static void n_PrintQRCode_Ljava_lang_String_IILcom_xcheng_printerservice_IPrinterCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2, IntPtr native_p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Xcheng.Printerservice.IPrinterService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p3 = (global::Com.Xcheng.Printerservice.IPrinterCallback)global::Java.Lang.Object.GetObject<global::Com.Xcheng.Printerservice.IPrinterCallback> (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.PrintQRCode (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		IntPtr id_printQRCode_Ljava_lang_String_IILcom_xcheng_printerservice_IPrinterCallback_;
		public unsafe void PrintQRCode (string p0, int p1, int p2, global::Com.Xcheng.Printerservice.IPrinterCallback p3)
		{
			if (id_printQRCode_Ljava_lang_String_IILcom_xcheng_printerservice_IPrinterCallback_ == IntPtr.Zero)
				id_printQRCode_Ljava_lang_String_IILcom_xcheng_printerservice_IPrinterCallback_ = JNIEnv.GetMethodID (class_ref, "printQRCode", "(Ljava/lang/String;IILcom/xcheng/printerservice/IPrinterCallback;)V");
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_printQRCode_Ljava_lang_String_IILcom_xcheng_printerservice_IPrinterCallback_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_printText_Ljava_lang_String_Lcom_xcheng_printerservice_IPrinterCallback_;
#pragma warning disable 0169
		static Delegate GetPrintText_Ljava_lang_String_Lcom_xcheng_printerservice_IPrinterCallback_Handler ()
		{
			if (cb_printText_Ljava_lang_String_Lcom_xcheng_printerservice_IPrinterCallback_ == null)
				cb_printText_Ljava_lang_String_Lcom_xcheng_printerservice_IPrinterCallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_PrintText_Ljava_lang_String_Lcom_xcheng_printerservice_IPrinterCallback_);
			return cb_printText_Ljava_lang_String_Lcom_xcheng_printerservice_IPrinterCallback_;
		}

		static void n_PrintText_Ljava_lang_String_Lcom_xcheng_printerservice_IPrinterCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Xcheng.Printerservice.IPrinterService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Com.Xcheng.Printerservice.IPrinterCallback)global::Java.Lang.Object.GetObject<global::Com.Xcheng.Printerservice.IPrinterCallback> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.PrintText (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_printText_Ljava_lang_String_Lcom_xcheng_printerservice_IPrinterCallback_;
		public unsafe void PrintText (string p0, global::Com.Xcheng.Printerservice.IPrinterCallback p1)
		{
			if (id_printText_Ljava_lang_String_Lcom_xcheng_printerservice_IPrinterCallback_ == IntPtr.Zero)
				id_printText_Ljava_lang_String_Lcom_xcheng_printerservice_IPrinterCallback_ = JNIEnv.GetMethodID (class_ref, "printText", "(Ljava/lang/String;Lcom/xcheng/printerservice/IPrinterCallback;)V");
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_printText_Ljava_lang_String_Lcom_xcheng_printerservice_IPrinterCallback_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_printTextWithAttributes_Ljava_lang_String_Ljava_util_Map_Lcom_xcheng_printerservice_IPrinterCallback_;
#pragma warning disable 0169
		static Delegate GetPrintTextWithAttributes_Ljava_lang_String_Ljava_util_Map_Lcom_xcheng_printerservice_IPrinterCallback_Handler ()
		{
			if (cb_printTextWithAttributes_Ljava_lang_String_Ljava_util_Map_Lcom_xcheng_printerservice_IPrinterCallback_ == null)
				cb_printTextWithAttributes_Ljava_lang_String_Ljava_util_Map_Lcom_xcheng_printerservice_IPrinterCallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_PrintTextWithAttributes_Ljava_lang_String_Ljava_util_Map_Lcom_xcheng_printerservice_IPrinterCallback_);
			return cb_printTextWithAttributes_Ljava_lang_String_Ljava_util_Map_Lcom_xcheng_printerservice_IPrinterCallback_;
		}

		static void n_PrintTextWithAttributes_Ljava_lang_String_Ljava_util_Map_Lcom_xcheng_printerservice_IPrinterCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Xcheng.Printerservice.IPrinterService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Android.Runtime.JavaDictionary.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = (global::Com.Xcheng.Printerservice.IPrinterCallback)global::Java.Lang.Object.GetObject<global::Com.Xcheng.Printerservice.IPrinterCallback> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.PrintTextWithAttributes (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_printTextWithAttributes_Ljava_lang_String_Ljava_util_Map_Lcom_xcheng_printerservice_IPrinterCallback_;
		public unsafe void PrintTextWithAttributes (string p0, global::System.Collections.IDictionary p1, global::Com.Xcheng.Printerservice.IPrinterCallback p2)
		{
			if (id_printTextWithAttributes_Ljava_lang_String_Ljava_util_Map_Lcom_xcheng_printerservice_IPrinterCallback_ == IntPtr.Zero)
				id_printTextWithAttributes_Ljava_lang_String_Ljava_util_Map_Lcom_xcheng_printerservice_IPrinterCallback_ = JNIEnv.GetMethodID (class_ref, "printTextWithAttributes", "(Ljava/lang/String;Ljava/util/Map;Lcom/xcheng/printerservice/IPrinterCallback;)V");
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			IntPtr native_p1 = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (p1);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_printTextWithAttributes_Ljava_lang_String_Ljava_util_Map_Lcom_xcheng_printerservice_IPrinterCallback_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_printWrapPaper_ILcom_xcheng_printerservice_IPrinterCallback_;
#pragma warning disable 0169
		static Delegate GetPrintWrapPaper_ILcom_xcheng_printerservice_IPrinterCallback_Handler ()
		{
			if (cb_printWrapPaper_ILcom_xcheng_printerservice_IPrinterCallback_ == null)
				cb_printWrapPaper_ILcom_xcheng_printerservice_IPrinterCallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIL_V) n_PrintWrapPaper_ILcom_xcheng_printerservice_IPrinterCallback_);
			return cb_printWrapPaper_ILcom_xcheng_printerservice_IPrinterCallback_;
		}

		static void n_PrintWrapPaper_ILcom_xcheng_printerservice_IPrinterCallback_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Xcheng.Printerservice.IPrinterService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Com.Xcheng.Printerservice.IPrinterCallback)global::Java.Lang.Object.GetObject<global::Com.Xcheng.Printerservice.IPrinterCallback> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.PrintWrapPaper (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_printWrapPaper_ILcom_xcheng_printerservice_IPrinterCallback_;
		public unsafe void PrintWrapPaper (int p0, global::Com.Xcheng.Printerservice.IPrinterCallback p1)
		{
			if (id_printWrapPaper_ILcom_xcheng_printerservice_IPrinterCallback_ == IntPtr.Zero)
				id_printWrapPaper_ILcom_xcheng_printerservice_IPrinterCallback_ = JNIEnv.GetMethodID (class_ref, "printWrapPaper", "(ILcom/xcheng/printerservice/IPrinterCallback;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_printWrapPaper_ILcom_xcheng_printerservice_IPrinterCallback_, __args);
		}

		static Delegate cb_printerInit_Lcom_xcheng_printerservice_IPrinterCallback_;
#pragma warning disable 0169
		static Delegate GetPrinterInit_Lcom_xcheng_printerservice_IPrinterCallback_Handler ()
		{
			if (cb_printerInit_Lcom_xcheng_printerservice_IPrinterCallback_ == null)
				cb_printerInit_Lcom_xcheng_printerservice_IPrinterCallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_PrinterInit_Lcom_xcheng_printerservice_IPrinterCallback_);
			return cb_printerInit_Lcom_xcheng_printerservice_IPrinterCallback_;
		}

		static void n_PrinterInit_Lcom_xcheng_printerservice_IPrinterCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Xcheng.Printerservice.IPrinterService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Xcheng.Printerservice.IPrinterCallback)global::Java.Lang.Object.GetObject<global::Com.Xcheng.Printerservice.IPrinterCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PrinterInit (p0);
		}
#pragma warning restore 0169

		IntPtr id_printerInit_Lcom_xcheng_printerservice_IPrinterCallback_;
		public unsafe void PrinterInit (global::Com.Xcheng.Printerservice.IPrinterCallback p0)
		{
			if (id_printerInit_Lcom_xcheng_printerservice_IPrinterCallback_ == IntPtr.Zero)
				id_printerInit_Lcom_xcheng_printerservice_IPrinterCallback_ = JNIEnv.GetMethodID (class_ref, "printerInit", "(Lcom/xcheng/printerservice/IPrinterCallback;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_printerInit_Lcom_xcheng_printerservice_IPrinterCallback_, __args);
		}

		static Delegate cb_printerPaper_Lcom_xcheng_printerservice_IPrinterCallback_;
#pragma warning disable 0169
		static Delegate GetPrinterPaper_Lcom_xcheng_printerservice_IPrinterCallback_Handler ()
		{
			if (cb_printerPaper_Lcom_xcheng_printerservice_IPrinterCallback_ == null)
				cb_printerPaper_Lcom_xcheng_printerservice_IPrinterCallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_PrinterPaper_Lcom_xcheng_printerservice_IPrinterCallback_);
			return cb_printerPaper_Lcom_xcheng_printerservice_IPrinterCallback_;
		}

		static bool n_PrinterPaper_Lcom_xcheng_printerservice_IPrinterCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Xcheng.Printerservice.IPrinterService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Xcheng.Printerservice.IPrinterCallback)global::Java.Lang.Object.GetObject<global::Com.Xcheng.Printerservice.IPrinterCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.PrinterPaper (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_printerPaper_Lcom_xcheng_printerservice_IPrinterCallback_;
		public unsafe bool PrinterPaper (global::Com.Xcheng.Printerservice.IPrinterCallback p0)
		{
			if (id_printerPaper_Lcom_xcheng_printerservice_IPrinterCallback_ == IntPtr.Zero)
				id_printerPaper_Lcom_xcheng_printerservice_IPrinterCallback_ = JNIEnv.GetMethodID (class_ref, "printerPaper", "(Lcom/xcheng/printerservice/IPrinterCallback;)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			var __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_printerPaper_Lcom_xcheng_printerservice_IPrinterCallback_, __args);
			return __ret;
		}

		static Delegate cb_printerReset_Lcom_xcheng_printerservice_IPrinterCallback_;
#pragma warning disable 0169
		static Delegate GetPrinterReset_Lcom_xcheng_printerservice_IPrinterCallback_Handler ()
		{
			if (cb_printerReset_Lcom_xcheng_printerservice_IPrinterCallback_ == null)
				cb_printerReset_Lcom_xcheng_printerservice_IPrinterCallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_PrinterReset_Lcom_xcheng_printerservice_IPrinterCallback_);
			return cb_printerReset_Lcom_xcheng_printerservice_IPrinterCallback_;
		}

		static void n_PrinterReset_Lcom_xcheng_printerservice_IPrinterCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Xcheng.Printerservice.IPrinterService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Xcheng.Printerservice.IPrinterCallback)global::Java.Lang.Object.GetObject<global::Com.Xcheng.Printerservice.IPrinterCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PrinterReset (p0);
		}
#pragma warning restore 0169

		IntPtr id_printerReset_Lcom_xcheng_printerservice_IPrinterCallback_;
		public unsafe void PrinterReset (global::Com.Xcheng.Printerservice.IPrinterCallback p0)
		{
			if (id_printerReset_Lcom_xcheng_printerservice_IPrinterCallback_ == IntPtr.Zero)
				id_printerReset_Lcom_xcheng_printerservice_IPrinterCallback_ = JNIEnv.GetMethodID (class_ref, "printerReset", "(Lcom/xcheng/printerservice/IPrinterCallback;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_printerReset_Lcom_xcheng_printerservice_IPrinterCallback_, __args);
		}

		static Delegate cb_printerTemperature_Lcom_xcheng_printerservice_IPrinterCallback_;
#pragma warning disable 0169
		static Delegate GetPrinterTemperature_Lcom_xcheng_printerservice_IPrinterCallback_Handler ()
		{
			if (cb_printerTemperature_Lcom_xcheng_printerservice_IPrinterCallback_ == null)
				cb_printerTemperature_Lcom_xcheng_printerservice_IPrinterCallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_I) n_PrinterTemperature_Lcom_xcheng_printerservice_IPrinterCallback_);
			return cb_printerTemperature_Lcom_xcheng_printerservice_IPrinterCallback_;
		}

		static int n_PrinterTemperature_Lcom_xcheng_printerservice_IPrinterCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Xcheng.Printerservice.IPrinterService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Xcheng.Printerservice.IPrinterCallback)global::Java.Lang.Object.GetObject<global::Com.Xcheng.Printerservice.IPrinterCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.PrinterTemperature (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_printerTemperature_Lcom_xcheng_printerservice_IPrinterCallback_;
		public unsafe int PrinterTemperature (global::Com.Xcheng.Printerservice.IPrinterCallback p0)
		{
			if (id_printerTemperature_Lcom_xcheng_printerservice_IPrinterCallback_ == IntPtr.Zero)
				id_printerTemperature_Lcom_xcheng_printerservice_IPrinterCallback_ = JNIEnv.GetMethodID (class_ref, "printerTemperature", "(Lcom/xcheng/printerservice/IPrinterCallback;)I");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_printerTemperature_Lcom_xcheng_printerservice_IPrinterCallback_, __args);
			return __ret;
		}

		static Delegate cb_sendRAWData_arrayBLcom_xcheng_printerservice_IPrinterCallback_;
#pragma warning disable 0169
		static Delegate GetSendRAWData_arrayBLcom_xcheng_printerservice_IPrinterCallback_Handler ()
		{
			if (cb_sendRAWData_arrayBLcom_xcheng_printerservice_IPrinterCallback_ == null)
				cb_sendRAWData_arrayBLcom_xcheng_printerservice_IPrinterCallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_SendRAWData_arrayBLcom_xcheng_printerservice_IPrinterCallback_);
			return cb_sendRAWData_arrayBLcom_xcheng_printerservice_IPrinterCallback_;
		}

		static void n_SendRAWData_arrayBLcom_xcheng_printerservice_IPrinterCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Xcheng.Printerservice.IPrinterService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p1 = (global::Com.Xcheng.Printerservice.IPrinterCallback)global::Java.Lang.Object.GetObject<global::Com.Xcheng.Printerservice.IPrinterCallback> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SendRAWData (p0, p1);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		IntPtr id_sendRAWData_arrayBLcom_xcheng_printerservice_IPrinterCallback_;
		public unsafe void SendRAWData (byte[] p0, global::Com.Xcheng.Printerservice.IPrinterCallback p1)
		{
			if (id_sendRAWData_arrayBLcom_xcheng_printerservice_IPrinterCallback_ == IntPtr.Zero)
				id_sendRAWData_arrayBLcom_xcheng_printerservice_IPrinterCallback_ = JNIEnv.GetMethodID (class_ref, "sendRAWData", "([BLcom/xcheng/printerservice/IPrinterCallback;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendRAWData_arrayBLcom_xcheng_printerservice_IPrinterCallback_, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setPrinterSpeed_ILcom_xcheng_printerservice_IPrinterCallback_;
#pragma warning disable 0169
		static Delegate GetSetPrinterSpeed_ILcom_xcheng_printerservice_IPrinterCallback_Handler ()
		{
			if (cb_setPrinterSpeed_ILcom_xcheng_printerservice_IPrinterCallback_ == null)
				cb_setPrinterSpeed_ILcom_xcheng_printerservice_IPrinterCallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIL_V) n_SetPrinterSpeed_ILcom_xcheng_printerservice_IPrinterCallback_);
			return cb_setPrinterSpeed_ILcom_xcheng_printerservice_IPrinterCallback_;
		}

		static void n_SetPrinterSpeed_ILcom_xcheng_printerservice_IPrinterCallback_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Xcheng.Printerservice.IPrinterService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Com.Xcheng.Printerservice.IPrinterCallback)global::Java.Lang.Object.GetObject<global::Com.Xcheng.Printerservice.IPrinterCallback> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetPrinterSpeed (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_setPrinterSpeed_ILcom_xcheng_printerservice_IPrinterCallback_;
		public unsafe void SetPrinterSpeed (int p0, global::Com.Xcheng.Printerservice.IPrinterCallback p1)
		{
			if (id_setPrinterSpeed_ILcom_xcheng_printerservice_IPrinterCallback_ == IntPtr.Zero)
				id_setPrinterSpeed_ILcom_xcheng_printerservice_IPrinterCallback_ = JNIEnv.GetMethodID (class_ref, "setPrinterSpeed", "(ILcom/xcheng/printerservice/IPrinterCallback;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPrinterSpeed_ILcom_xcheng_printerservice_IPrinterCallback_, __args);
		}

		static Delegate cb_upgradePrinter;
#pragma warning disable 0169
		static Delegate GetUpgradePrinterHandler ()
		{
			if (cb_upgradePrinter == null)
				cb_upgradePrinter = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_UpgradePrinter);
			return cb_upgradePrinter;
		}

		static void n_UpgradePrinter (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Xcheng.Printerservice.IPrinterService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UpgradePrinter ();
		}
#pragma warning restore 0169

		IntPtr id_upgradePrinter;
		public unsafe void UpgradePrinter ()
		{
			if (id_upgradePrinter == IntPtr.Zero)
				id_upgradePrinter = JNIEnv.GetMethodID (class_ref, "upgradePrinter", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_upgradePrinter);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Xcheng.Printerservice.IPrinterService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
