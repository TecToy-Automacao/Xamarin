; ModuleID = 'obj\Release\130\android\marshal_methods.armeabi-v7a.ll'
source_filename = "obj\Release\130\android\marshal_methods.armeabi-v7a.ll"
target datalayout = "e-m:e-p:32:32-Fi8-i64:64-v128:64:128-a:0:32-n32-S64"
target triple = "armv7-unknown-linux-android"


%struct.MonoImage = type opaque

%struct.MonoClass = type opaque

%struct.MarshalMethodsManagedClass = type {
	i32,; uint32_t token
	%struct.MonoClass*; MonoClass* klass
}

%struct.MarshalMethodName = type {
	i64,; uint64_t id
	i8*; char* name
}

%class._JNIEnv = type opaque

%class._jobject = type {
	i8; uint8_t b
}

%class._jclass = type {
	i8; uint8_t b
}

%class._jstring = type {
	i8; uint8_t b
}

%class._jthrowable = type {
	i8; uint8_t b
}

%class._jarray = type {
	i8; uint8_t b
}

%class._jobjectArray = type {
	i8; uint8_t b
}

%class._jbooleanArray = type {
	i8; uint8_t b
}

%class._jbyteArray = type {
	i8; uint8_t b
}

%class._jcharArray = type {
	i8; uint8_t b
}

%class._jshortArray = type {
	i8; uint8_t b
}

%class._jintArray = type {
	i8; uint8_t b
}

%class._jlongArray = type {
	i8; uint8_t b
}

%class._jfloatArray = type {
	i8; uint8_t b
}

%class._jdoubleArray = type {
	i8; uint8_t b
}

; assembly_image_cache
@assembly_image_cache = local_unnamed_addr global [0 x %struct.MonoImage*] zeroinitializer, align 4
; Each entry maps hash of an assembly name to an index into the `assembly_image_cache` array
@assembly_image_cache_hashes = local_unnamed_addr constant [46 x i32] [
	i32 34715100, ; 0: Xamarin.Google.Guava.ListenableFuture.dll => 0x211b5dc => 22
	i32 318968648, ; 1: Xamarin.AndroidX.Activity.dll => 0x13031348 => 19
	i32 321597661, ; 2: System.Numerics => 0x132b30dd => 5
	i32 342366114, ; 3: Xamarin.AndroidX.Lifecycle.Common => 0x146817a2 => 11
	i32 442521989, ; 4: Xamarin.Essentials => 0x1a605985 => 21
	i32 450948140, ; 5: Xamarin.AndroidX.Fragment.dll => 0x1ae0ec2c => 10
	i32 465846621, ; 6: mscorlib => 0x1bc4415d => 2
	i32 469710990, ; 7: System.dll => 0x1bff388e => 4
	i32 577399686, ; 8: XamarinTecToy.dll => 0x226a6b86 => 17
	i32 627609679, ; 9: Xamarin.AndroidX.CustomView => 0x2568904f => 8
	i32 928116545, ; 10: Xamarin.Google.Guava.ListenableFuture => 0x3751ef41 => 22
	i32 967690846, ; 11: Xamarin.AndroidX.Lifecycle.Common.dll => 0x39adca5e => 11
	i32 1012816738, ; 12: Xamarin.AndroidX.SavedState.dll => 0x3c5e5b62 => 20
	i32 1035644815, ; 13: Xamarin.AndroidX.AppCompat => 0x3dbaaf8f => 6
	i32 1052210849, ; 14: Xamarin.AndroidX.Lifecycle.ViewModel.dll => 0x3eb776a1 => 13
	i32 1098259244, ; 15: System => 0x41761b2c => 4
	i32 1293217323, ; 16: Xamarin.AndroidX.DrawerLayout.dll => 0x4d14ee2b => 9
	i32 1376866003, ; 17: Xamarin.AndroidX.SavedState => 0x52114ed3 => 20
	i32 1587654038, ; 18: Binding => 0x5ea1ad96 => 18
	i32 1622152042, ; 19: Xamarin.AndroidX.Loader.dll => 0x60b0136a => 14
	i32 1639515021, ; 20: System.Net.Http.dll => 0x61b9038d => 15
	i32 1776026572, ; 21: System.Core.dll => 0x69dc03cc => 3
	i32 1788241197, ; 22: Xamarin.AndroidX.Fragment => 0x6a96652d => 10
	i32 1808609942, ; 23: Xamarin.AndroidX.Loader => 0x6bcd3296 => 14
	i32 1867746548, ; 24: Xamarin.Essentials.dll => 0x6f538cf4 => 21
	i32 2019465201, ; 25: Xamarin.AndroidX.Lifecycle.ViewModel => 0x785e97f1 => 13
	i32 2055257422, ; 26: Xamarin.AndroidX.Lifecycle.LiveData.Core.dll => 0x7a80bd4e => 12
	i32 2201231467, ; 27: System.Net.Http => 0x8334206b => 15
	i32 2475788418, ; 28: Java.Interop.dll => 0x93918882 => 0
	i32 2732626843, ; 29: Xamarin.AndroidX.Activity => 0xa2e0939b => 19
	i32 2905242038, ; 30: mscorlib.dll => 0xad2a79b6 => 2
	i32 2978675010, ; 31: Xamarin.AndroidX.DrawerLayout => 0xb18af942 => 9
	i32 3076185654, ; 32: XamarinTecToy => 0xb75ade36 => 17
	i32 3247949154, ; 33: Mono.Security => 0xc197c562 => 16
	i32 3317135071, ; 34: Xamarin.AndroidX.CustomView.dll => 0xc5b776df => 8
	i32 3362522851, ; 35: Xamarin.AndroidX.Core => 0xc86c06e3 => 7
	i32 3366347497, ; 36: Java.Interop => 0xc8a662e9 => 0
	i32 3476120550, ; 37: Mono.Android => 0xcf3163e6 => 1
	i32 3641597786, ; 38: Xamarin.AndroidX.Lifecycle.LiveData.Core => 0xd90e5f5a => 12
	i32 3672681054, ; 39: Mono.Android.dll => 0xdae8aa5e => 1
	i32 3829621856, ; 40: System.Numerics.dll => 0xe4436460 => 5
	i32 3896760992, ; 41: Xamarin.AndroidX.Core.dll => 0xe843daa0 => 7
	i32 3955647286, ; 42: Xamarin.AndroidX.AppCompat.dll => 0xebc66336 => 6
	i32 4105002889, ; 43: Mono.Security.dll => 0xf4ad5f89 => 16
	i32 4151237749, ; 44: System.Core => 0xf76edc75 => 3
	i32 4282304318 ; 45: Binding.dll => 0xff3ec73e => 18
], align 4
@assembly_image_cache_indices = local_unnamed_addr constant [46 x i32] [
	i32 22, i32 19, i32 5, i32 11, i32 21, i32 10, i32 2, i32 4, ; 0..7
	i32 17, i32 8, i32 22, i32 11, i32 20, i32 6, i32 13, i32 4, ; 8..15
	i32 9, i32 20, i32 18, i32 14, i32 15, i32 3, i32 10, i32 14, ; 16..23
	i32 21, i32 13, i32 12, i32 15, i32 0, i32 19, i32 2, i32 9, ; 24..31
	i32 17, i32 16, i32 8, i32 7, i32 0, i32 1, i32 12, i32 1, ; 32..39
	i32 5, i32 7, i32 6, i32 16, i32 3, i32 18 ; 40..45
], align 4

@marshal_methods_number_of_classes = local_unnamed_addr constant i32 0, align 4

; marshal_methods_class_cache
@marshal_methods_class_cache = global [0 x %struct.MarshalMethodsManagedClass] [
], align 4; end of 'marshal_methods_class_cache' array


@get_function_pointer = internal unnamed_addr global void (i32, i32, i32, i8**)* null, align 4

; Function attributes: "frame-pointer"="all" "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" "target-cpu"="generic" "target-features"="+armv7-a,+d32,+dsp,+fp64,+neon,+thumb-mode,+vfp2,+vfp2sp,+vfp3,+vfp3d16,+vfp3d16sp,+vfp3sp,-aes,-fp-armv8,-fp-armv8d16,-fp-armv8d16sp,-fp-armv8sp,-fp16,-fp16fml,-fullfp16,-sha2,-vfp4,-vfp4d16,-vfp4d16sp,-vfp4sp" uwtable willreturn writeonly
define void @xamarin_app_init (void (i32, i32, i32, i8**)* %fn) local_unnamed_addr #0
{
	store void (i32, i32, i32, i8**)* %fn, void (i32, i32, i32, i8**)** @get_function_pointer, align 4
	ret void
}

; Names of classes in which marshal methods reside
@mm_class_names = local_unnamed_addr constant [0 x i8*] zeroinitializer, align 4
@__MarshalMethodName_name.0 = internal constant [1 x i8] c"\00", align 1

; mm_method_names
@mm_method_names = local_unnamed_addr constant [1 x %struct.MarshalMethodName] [
	; 0
	%struct.MarshalMethodName {
		i64 0, ; id 0x0; name: 
		i8* getelementptr inbounds ([1 x i8], [1 x i8]* @__MarshalMethodName_name.0, i32 0, i32 0); name
	}
], align 8; end of 'mm_method_names' array


attributes #0 = { "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" uwtable willreturn writeonly "frame-pointer"="all" "target-cpu"="generic" "target-features"="+armv7-a,+d32,+dsp,+fp64,+neon,+thumb-mode,+vfp2,+vfp2sp,+vfp3,+vfp3d16,+vfp3d16sp,+vfp3sp,-aes,-fp-armv8,-fp-armv8d16,-fp-armv8d16sp,-fp-armv8sp,-fp16,-fp16fml,-fullfp16,-sha2,-vfp4,-vfp4d16,-vfp4d16sp,-vfp4sp" }
attributes #1 = { "min-legal-vector-width"="0" mustprogress "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" uwtable "frame-pointer"="all" "target-cpu"="generic" "target-features"="+armv7-a,+d32,+dsp,+fp64,+neon,+thumb-mode,+vfp2,+vfp2sp,+vfp3,+vfp3d16,+vfp3d16sp,+vfp3sp,-aes,-fp-armv8,-fp-armv8d16,-fp-armv8d16sp,-fp-armv8sp,-fp16,-fp16fml,-fullfp16,-sha2,-vfp4,-vfp4d16,-vfp4d16sp,-vfp4sp" }
attributes #2 = { nounwind }

!llvm.module.flags = !{!0, !1, !2}
!llvm.ident = !{!3}
!0 = !{i32 1, !"wchar_size", i32 4}
!1 = !{i32 7, !"PIC Level", i32 2}
!2 = !{i32 1, !"min_enum_size", i32 4}
!3 = !{!"Xamarin.Android remotes/origin/d17-5 @ a200af12c1e846626b8caebd926ac14c185f71ec"}
!llvm.linker.options = !{}
