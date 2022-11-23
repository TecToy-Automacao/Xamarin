using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Java.Interop {

	partial class __TypeRegistrations {

		public static void RegisterPackages ()
		{
#if MONODROID_TIMING
			var start = DateTime.Now;
			Android.Util.Log.Info ("MonoDroid-Timing", "RegisterPackages start: " + (start - new DateTime (1970, 1, 1)).TotalMilliseconds);
#endif // def MONODROID_TIMING
			Java.Interop.TypeManager.RegisterPackages (
					new string[]{
						"com/sunmi/idcardservice",
						"com/sunmi/scanner",
						"com/xcheng/printerservice",
						"woyou/aidlservice/jiuiv5",
					},
					new Converter<string, Type>[]{
						lookup_com_sunmi_idcardservice_package,
						lookup_com_sunmi_scanner_package,
						lookup_com_xcheng_printerservice_package,
						lookup_woyou_aidlservice_jiuiv5_package,
					});
#if MONODROID_TIMING
			var end = DateTime.Now;
			Android.Util.Log.Info ("MonoDroid-Timing", "RegisterPackages time: " + (end - new DateTime (1970, 1, 1)).TotalMilliseconds + " [elapsed: " + (end - start).TotalMilliseconds + " ms]");
#endif // def MONODROID_TIMING
		}

#if NET5_0_OR_GREATER
		[System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage ("Trimming", "IL2057")]
#endif
		static Type Lookup (string[] mappings, string javaType)
		{
			var managedType = Java.Interop.TypeManager.LookupTypeMapping (mappings, javaType);
			if (managedType == null)
				return null;
			return Type.GetType (managedType);
		}

		static string[] package_com_sunmi_idcardservice_mappings;
		static Type lookup_com_sunmi_idcardservice_package (string klass)
		{
			if (package_com_sunmi_idcardservice_mappings == null) {
				package_com_sunmi_idcardservice_mappings = new string[]{
					"com/sunmi/idcardservice/CardCallback$Default:Com.Sunmi.Idcardservice.CardCallbackDefault",
					"com/sunmi/idcardservice/CardCallback$Stub:Com.Sunmi.Idcardservice.CardCallbackStub",
					"com/sunmi/idcardservice/IDCardServiceAidl$Default:Com.Sunmi.Idcardservice.DCardServiceAidlDefault",
					"com/sunmi/idcardservice/IDCardServiceAidl$Stub:Com.Sunmi.Idcardservice.DCardServiceAidlStub",
					"com/sunmi/idcardservice/MiFareCardAidl$Default:Com.Sunmi.Idcardservice.MiFareCardAidlDefault",
					"com/sunmi/idcardservice/MiFareCardAidl$Stub:Com.Sunmi.Idcardservice.MiFareCardAidlStub",
				};
			}

			return Lookup (package_com_sunmi_idcardservice_mappings, klass);
		}

		static string[] package_com_sunmi_scanner_mappings;
		static Type lookup_com_sunmi_scanner_package (string klass)
		{
			if (package_com_sunmi_scanner_mappings == null) {
				package_com_sunmi_scanner_mappings = new string[]{
					"com/sunmi/scanner/IScanInterface$Default:Com.Sunmi.Scanner.ScanInterfaceDefault",
					"com/sunmi/scanner/IScanInterface$Stub:Com.Sunmi.Scanner.ScanInterfaceStub",
				};
			}

			return Lookup (package_com_sunmi_scanner_mappings, klass);
		}

		static string[] package_com_xcheng_printerservice_mappings;
		static Type lookup_com_xcheng_printerservice_package (string klass)
		{
			if (package_com_xcheng_printerservice_mappings == null) {
				package_com_xcheng_printerservice_mappings = new string[]{
					"com/xcheng/printerservice/IPrinterCallback$Default:Com.Xcheng.Printerservice.PrinterCallbackDefault",
					"com/xcheng/printerservice/IPrinterCallback$Stub:Com.Xcheng.Printerservice.PrinterCallbackStub",
					"com/xcheng/printerservice/IPrinterService$Default:Com.Xcheng.Printerservice.PrinterServiceDefault",
					"com/xcheng/printerservice/IPrinterService$Stub:Com.Xcheng.Printerservice.PrinterServiceStub",
				};
			}

			return Lookup (package_com_xcheng_printerservice_mappings, klass);
		}

		static string[] package_woyou_aidlservice_jiuiv5_mappings;
		static Type lookup_woyou_aidlservice_jiuiv5_package (string klass)
		{
			if (package_woyou_aidlservice_jiuiv5_mappings == null) {
				package_woyou_aidlservice_jiuiv5_mappings = new string[]{
					"woyou/aidlservice/jiuiv5/ICallback$Default:Woyou.Aidlservice.Jiuiv5.CallbackDefault",
					"woyou/aidlservice/jiuiv5/ICallback$Stub:Woyou.Aidlservice.Jiuiv5.CallbackStub",
					"woyou/aidlservice/jiuiv5/ILcdCallback$Default:Woyou.Aidlservice.Jiuiv5.LcdCallbackDefault",
					"woyou/aidlservice/jiuiv5/ILcdCallback$Stub:Woyou.Aidlservice.Jiuiv5.LcdCallbackStub",
					"woyou/aidlservice/jiuiv5/ITax$Default:Woyou.Aidlservice.Jiuiv5.TaxDefault",
					"woyou/aidlservice/jiuiv5/ITax$Stub:Woyou.Aidlservice.Jiuiv5.TaxStub",
					"woyou/aidlservice/jiuiv5/IWoyouService$Default:Woyou.Aidlservice.Jiuiv5.WoyouServiceDefault",
					"woyou/aidlservice/jiuiv5/IWoyouService$Stub:Woyou.Aidlservice.Jiuiv5.WoyouServiceStub",
				};
			}

			return Lookup (package_woyou_aidlservice_jiuiv5_mappings, klass);
		}
	}
}
