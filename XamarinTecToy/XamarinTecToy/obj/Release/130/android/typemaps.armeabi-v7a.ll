; ModuleID = 'obj\Release\130\android\typemaps.armeabi-v7a.ll'
source_filename = "obj\Release\130\android\typemaps.armeabi-v7a.ll"
target datalayout = "e-m:e-p:32:32-Fi8-i64:64-v128:64:128-a:0:32-n32-S64"
target triple = "armv7-unknown-linux-android"


%struct.MonoImage = type opaque

%struct.TypeMapJava = type {
	i32,; uint32_t module_index
	i32,; uint32_t type_token_id
	i32; uint32_t java_name_index
}

%struct.TypeMapModule = type {
	[16 x i8],; uint8_t module_uuid[16]
	i32,; uint32_t entry_count
	i32,; uint32_t duplicate_count
	%struct.TypeMapModuleEntry*,; TypeMapModuleEntry* map
	%struct.TypeMapModuleEntry*,; TypeMapModuleEntry* duplicate_map
	i8*,; char* assembly_name
	%struct.MonoImage*,; MonoImage* image
	i32,; uint32_t java_name_width
	i8*; uint8_t* java_map
}

%struct.TypeMapModuleEntry = type {
	i32,; uint32_t type_token_id
	i32; uint32_t java_map_index
}

@map_module_count = local_unnamed_addr constant i32 16, align 4

@java_type_count = local_unnamed_addr constant i32 743, align 4

; Map modules data

; module0_managed_to_java
@module0_managed_to_java = internal constant [3 x %struct.TypeMapModuleEntry] [
	; 0
	%struct.TypeMapModuleEntry {
		i32 33554454, ; type_token_id
		i32 187; java_map_index
	}, 
	; 1
	%struct.TypeMapModuleEntry {
		i32 33554455, ; type_token_id
		i32 648; java_map_index
	}, 
	; 2
	%struct.TypeMapModuleEntry {
		i32 33554461, ; type_token_id
		i32 551; java_map_index
	}
], align 4; end of 'module0_managed_to_java' array


; module0_managed_to_java_duplicates
@module0_managed_to_java_duplicates = internal constant [1 x %struct.TypeMapModuleEntry] [
	; 0
	%struct.TypeMapModuleEntry {
		i32 33554456, ; type_token_id
		i32 648; java_map_index
	}
], align 4; end of 'module0_managed_to_java_duplicates' array


; module1_managed_to_java
@module1_managed_to_java = internal constant [4 x %struct.TypeMapModuleEntry] [
	; 0
	%struct.TypeMapModuleEntry {
		i32 33554436, ; type_token_id
		i32 393; java_map_index
	}, 
	; 1
	%struct.TypeMapModuleEntry {
		i32 33554437, ; type_token_id
		i32 395; java_map_index
	}, 
	; 2
	%struct.TypeMapModuleEntry {
		i32 33554438, ; type_token_id
		i32 713; java_map_index
	}, 
	; 3
	%struct.TypeMapModuleEntry {
		i32 33554440, ; type_token_id
		i32 56; java_map_index
	}
], align 4; end of 'module1_managed_to_java' array


; module1_managed_to_java_duplicates
@module1_managed_to_java_duplicates = internal constant [3 x %struct.TypeMapModuleEntry] [
	; 0
	%struct.TypeMapModuleEntry {
		i32 33554439, ; type_token_id
		i32 713; java_map_index
	}, 
	; 1
	%struct.TypeMapModuleEntry {
		i32 33554441, ; type_token_id
		i32 56; java_map_index
	}, 
	; 2
	%struct.TypeMapModuleEntry {
		i32 33554442, ; type_token_id
		i32 393; java_map_index
	}
], align 4; end of 'module1_managed_to_java_duplicates' array


; module2_managed_to_java
@module2_managed_to_java = internal constant [25 x %struct.TypeMapModuleEntry] [
	; 0
	%struct.TypeMapModuleEntry {
		i32 33554465, ; type_token_id
		i32 501; java_map_index
	}, 
	; 1
	%struct.TypeMapModuleEntry {
		i32 33554466, ; type_token_id
		i32 397; java_map_index
	}, 
	; 2
	%struct.TypeMapModuleEntry {
		i32 33554469, ; type_token_id
		i32 243; java_map_index
	}, 
	; 3
	%struct.TypeMapModuleEntry {
		i32 33554470, ; type_token_id
		i32 321; java_map_index
	}, 
	; 4
	%struct.TypeMapModuleEntry {
		i32 33554473, ; type_token_id
		i32 137; java_map_index
	}, 
	; 5
	%struct.TypeMapModuleEntry {
		i32 33554479, ; type_token_id
		i32 694; java_map_index
	}, 
	; 6
	%struct.TypeMapModuleEntry {
		i32 33554480, ; type_token_id
		i32 188; java_map_index
	}, 
	; 7
	%struct.TypeMapModuleEntry {
		i32 33554482, ; type_token_id
		i32 603; java_map_index
	}, 
	; 8
	%struct.TypeMapModuleEntry {
		i32 33554484, ; type_token_id
		i32 279; java_map_index
	}, 
	; 9
	%struct.TypeMapModuleEntry {
		i32 33554485, ; type_token_id
		i32 133; java_map_index
	}, 
	; 10
	%struct.TypeMapModuleEntry {
		i32 33554487, ; type_token_id
		i32 142; java_map_index
	}, 
	; 11
	%struct.TypeMapModuleEntry {
		i32 33554488, ; type_token_id
		i32 426; java_map_index
	}, 
	; 12
	%struct.TypeMapModuleEntry {
		i32 33554490, ; type_token_id
		i32 125; java_map_index
	}, 
	; 13
	%struct.TypeMapModuleEntry {
		i32 33554492, ; type_token_id
		i32 155; java_map_index
	}, 
	; 14
	%struct.TypeMapModuleEntry {
		i32 33554493, ; type_token_id
		i32 582; java_map_index
	}, 
	; 15
	%struct.TypeMapModuleEntry {
		i32 33554494, ; type_token_id
		i32 265; java_map_index
	}, 
	; 16
	%struct.TypeMapModuleEntry {
		i32 33554495, ; type_token_id
		i32 586; java_map_index
	}, 
	; 17
	%struct.TypeMapModuleEntry {
		i32 33554497, ; type_token_id
		i32 139; java_map_index
	}, 
	; 18
	%struct.TypeMapModuleEntry {
		i32 33554499, ; type_token_id
		i32 734; java_map_index
	}, 
	; 19
	%struct.TypeMapModuleEntry {
		i32 33554501, ; type_token_id
		i32 719; java_map_index
	}, 
	; 20
	%struct.TypeMapModuleEntry {
		i32 33554502, ; type_token_id
		i32 459; java_map_index
	}, 
	; 21
	%struct.TypeMapModuleEntry {
		i32 33554503, ; type_token_id
		i32 669; java_map_index
	}, 
	; 22
	%struct.TypeMapModuleEntry {
		i32 33554504, ; type_token_id
		i32 106; java_map_index
	}, 
	; 23
	%struct.TypeMapModuleEntry {
		i32 33554507, ; type_token_id
		i32 210; java_map_index
	}, 
	; 24
	%struct.TypeMapModuleEntry {
		i32 33554508, ; type_token_id
		i32 487; java_map_index
	}
], align 4; end of 'module2_managed_to_java' array


; module2_managed_to_java_duplicates
@module2_managed_to_java_duplicates = internal constant [14 x %struct.TypeMapModuleEntry] [
	; 0
	%struct.TypeMapModuleEntry {
		i32 33554467, ; type_token_id
		i32 397; java_map_index
	}, 
	; 1
	%struct.TypeMapModuleEntry {
		i32 33554471, ; type_token_id
		i32 321; java_map_index
	}, 
	; 2
	%struct.TypeMapModuleEntry {
		i32 33554478, ; type_token_id
		i32 501; java_map_index
	}, 
	; 3
	%struct.TypeMapModuleEntry {
		i32 33554481, ; type_token_id
		i32 188; java_map_index
	}, 
	; 4
	%struct.TypeMapModuleEntry {
		i32 33554483, ; type_token_id
		i32 603; java_map_index
	}, 
	; 5
	%struct.TypeMapModuleEntry {
		i32 33554486, ; type_token_id
		i32 133; java_map_index
	}, 
	; 6
	%struct.TypeMapModuleEntry {
		i32 33554489, ; type_token_id
		i32 426; java_map_index
	}, 
	; 7
	%struct.TypeMapModuleEntry {
		i32 33554491, ; type_token_id
		i32 125; java_map_index
	}, 
	; 8
	%struct.TypeMapModuleEntry {
		i32 33554496, ; type_token_id
		i32 586; java_map_index
	}, 
	; 9
	%struct.TypeMapModuleEntry {
		i32 33554498, ; type_token_id
		i32 139; java_map_index
	}, 
	; 10
	%struct.TypeMapModuleEntry {
		i32 33554500, ; type_token_id
		i32 734; java_map_index
	}, 
	; 11
	%struct.TypeMapModuleEntry {
		i32 33554505, ; type_token_id
		i32 106; java_map_index
	}, 
	; 12
	%struct.TypeMapModuleEntry {
		i32 33554506, ; type_token_id
		i32 669; java_map_index
	}, 
	; 13
	%struct.TypeMapModuleEntry {
		i32 33554509, ; type_token_id
		i32 487; java_map_index
	}
], align 4; end of 'module2_managed_to_java_duplicates' array


; module3_managed_to_java
@module3_managed_to_java = internal constant [3 x %struct.TypeMapModuleEntry] [
	; 0
	%struct.TypeMapModuleEntry {
		i32 33554435, ; type_token_id
		i32 147; java_map_index
	}, 
	; 1
	%struct.TypeMapModuleEntry {
		i32 33554437, ; type_token_id
		i32 42; java_map_index
	}, 
	; 2
	%struct.TypeMapModuleEntry {
		i32 33554438, ; type_token_id
		i32 529; java_map_index
	}
], align 4; end of 'module3_managed_to_java' array


; module3_managed_to_java_duplicates
@module3_managed_to_java_duplicates = internal constant [2 x %struct.TypeMapModuleEntry] [
	; 0
	%struct.TypeMapModuleEntry {
		i32 33554436, ; type_token_id
		i32 147; java_map_index
	}, 
	; 1
	%struct.TypeMapModuleEntry {
		i32 33554439, ; type_token_id
		i32 529; java_map_index
	}
], align 4; end of 'module3_managed_to_java_duplicates' array


; module4_managed_to_java
@module4_managed_to_java = internal constant [10 x %struct.TypeMapModuleEntry] [
	; 0
	%struct.TypeMapModuleEntry {
		i32 33554467, ; type_token_id
		i32 340; java_map_index
	}, 
	; 1
	%struct.TypeMapModuleEntry {
		i32 33554468, ; type_token_id
		i32 3; java_map_index
	}, 
	; 2
	%struct.TypeMapModuleEntry {
		i32 33554469, ; type_token_id
		i32 675; java_map_index
	}, 
	; 3
	%struct.TypeMapModuleEntry {
		i32 33554470, ; type_token_id
		i32 66; java_map_index
	}, 
	; 4
	%struct.TypeMapModuleEntry {
		i32 33554471, ; type_token_id
		i32 355; java_map_index
	}, 
	; 5
	%struct.TypeMapModuleEntry {
		i32 33554472, ; type_token_id
		i32 381; java_map_index
	}, 
	; 6
	%struct.TypeMapModuleEntry {
		i32 33554474, ; type_token_id
		i32 736; java_map_index
	}, 
	; 7
	%struct.TypeMapModuleEntry {
		i32 33554476, ; type_token_id
		i32 409; java_map_index
	}, 
	; 8
	%struct.TypeMapModuleEntry {
		i32 33554478, ; type_token_id
		i32 21; java_map_index
	}, 
	; 9
	%struct.TypeMapModuleEntry {
		i32 33554482, ; type_token_id
		i32 105; java_map_index
	}
], align 4; end of 'module4_managed_to_java' array


; module4_managed_to_java_duplicates
@module4_managed_to_java_duplicates = internal constant [5 x %struct.TypeMapModuleEntry] [
	; 0
	%struct.TypeMapModuleEntry {
		i32 33554473, ; type_token_id
		i32 381; java_map_index
	}, 
	; 1
	%struct.TypeMapModuleEntry {
		i32 33554475, ; type_token_id
		i32 736; java_map_index
	}, 
	; 2
	%struct.TypeMapModuleEntry {
		i32 33554477, ; type_token_id
		i32 409; java_map_index
	}, 
	; 3
	%struct.TypeMapModuleEntry {
		i32 33554481, ; type_token_id
		i32 355; java_map_index
	}, 
	; 4
	%struct.TypeMapModuleEntry {
		i32 33554483, ; type_token_id
		i32 105; java_map_index
	}
], align 4; end of 'module4_managed_to_java_duplicates' array


; module5_managed_to_java
@module5_managed_to_java = internal constant [1 x %struct.TypeMapModuleEntry] [
	; 0
	%struct.TypeMapModuleEntry {
		i32 33554448, ; type_token_id
		i32 145; java_map_index
	}
], align 4; end of 'module5_managed_to_java' array


; module6_managed_to_java
@module6_managed_to_java = internal constant [5 x %struct.TypeMapModuleEntry] [
	; 0
	%struct.TypeMapModuleEntry {
		i32 33554447, ; type_token_id
		i32 103; java_map_index
	}, 
	; 1
	%struct.TypeMapModuleEntry {
		i32 33554448, ; type_token_id
		i32 711; java_map_index
	}, 
	; 2
	%struct.TypeMapModuleEntry {
		i32 33554450, ; type_token_id
		i32 41; java_map_index
	}, 
	; 3
	%struct.TypeMapModuleEntry {
		i32 33554452, ; type_token_id
		i32 386; java_map_index
	}, 
	; 4
	%struct.TypeMapModuleEntry {
		i32 33554453, ; type_token_id
		i32 717; java_map_index
	}
], align 4; end of 'module6_managed_to_java' array


; module6_managed_to_java_duplicates
@module6_managed_to_java_duplicates = internal constant [4 x %struct.TypeMapModuleEntry] [
	; 0
	%struct.TypeMapModuleEntry {
		i32 33554449, ; type_token_id
		i32 711; java_map_index
	}, 
	; 1
	%struct.TypeMapModuleEntry {
		i32 33554451, ; type_token_id
		i32 41; java_map_index
	}, 
	; 2
	%struct.TypeMapModuleEntry {
		i32 33554454, ; type_token_id
		i32 717; java_map_index
	}, 
	; 3
	%struct.TypeMapModuleEntry {
		i32 33554455, ; type_token_id
		i32 386; java_map_index
	}
], align 4; end of 'module6_managed_to_java_duplicates' array


; module7_managed_to_java
@module7_managed_to_java = internal constant [282 x %struct.TypeMapModuleEntry] [
	; 0
	%struct.TypeMapModuleEntry {
		i32 33554561, ; type_token_id
		i32 589; java_map_index
	}, 
	; 1
	%struct.TypeMapModuleEntry {
		i32 33554562, ; type_token_id
		i32 204; java_map_index
	}, 
	; 2
	%struct.TypeMapModuleEntry {
		i32 33554564, ; type_token_id
		i32 36; java_map_index
	}, 
	; 3
	%struct.TypeMapModuleEntry {
		i32 33554566, ; type_token_id
		i32 268; java_map_index
	}, 
	; 4
	%struct.TypeMapModuleEntry {
		i32 33554567, ; type_token_id
		i32 637; java_map_index
	}, 
	; 5
	%struct.TypeMapModuleEntry {
		i32 33554569, ; type_token_id
		i32 585; java_map_index
	}, 
	; 6
	%struct.TypeMapModuleEntry {
		i32 33554571, ; type_token_id
		i32 464; java_map_index
	}, 
	; 7
	%struct.TypeMapModuleEntry {
		i32 33554573, ; type_token_id
		i32 235; java_map_index
	}, 
	; 8
	%struct.TypeMapModuleEntry {
		i32 33554575, ; type_token_id
		i32 571; java_map_index
	}, 
	; 9
	%struct.TypeMapModuleEntry {
		i32 33554577, ; type_token_id
		i32 17; java_map_index
	}, 
	; 10
	%struct.TypeMapModuleEntry {
		i32 33554579, ; type_token_id
		i32 134; java_map_index
	}, 
	; 11
	%struct.TypeMapModuleEntry {
		i32 33554581, ; type_token_id
		i32 661; java_map_index
	}, 
	; 12
	%struct.TypeMapModuleEntry {
		i32 33554583, ; type_token_id
		i32 184; java_map_index
	}, 
	; 13
	%struct.TypeMapModuleEntry {
		i32 33554584, ; type_token_id
		i32 222; java_map_index
	}, 
	; 14
	%struct.TypeMapModuleEntry {
		i32 33554585, ; type_token_id
		i32 684; java_map_index
	}, 
	; 15
	%struct.TypeMapModuleEntry {
		i32 33554587, ; type_token_id
		i32 720; java_map_index
	}, 
	; 16
	%struct.TypeMapModuleEntry {
		i32 33554597, ; type_token_id
		i32 25; java_map_index
	}, 
	; 17
	%struct.TypeMapModuleEntry {
		i32 33554599, ; type_token_id
		i32 432; java_map_index
	}, 
	; 18
	%struct.TypeMapModuleEntry {
		i32 33554601, ; type_token_id
		i32 366; java_map_index
	}, 
	; 19
	%struct.TypeMapModuleEntry {
		i32 33554602, ; type_token_id
		i32 349; java_map_index
	}, 
	; 20
	%struct.TypeMapModuleEntry {
		i32 33554605, ; type_token_id
		i32 275; java_map_index
	}, 
	; 21
	%struct.TypeMapModuleEntry {
		i32 33554606, ; type_token_id
		i32 164; java_map_index
	}, 
	; 22
	%struct.TypeMapModuleEntry {
		i32 33554607, ; type_token_id
		i32 316; java_map_index
	}, 
	; 23
	%struct.TypeMapModuleEntry {
		i32 33554608, ; type_token_id
		i32 153; java_map_index
	}, 
	; 24
	%struct.TypeMapModuleEntry {
		i32 33554609, ; type_token_id
		i32 467; java_map_index
	}, 
	; 25
	%struct.TypeMapModuleEntry {
		i32 33554611, ; type_token_id
		i32 373; java_map_index
	}, 
	; 26
	%struct.TypeMapModuleEntry {
		i32 33554613, ; type_token_id
		i32 470; java_map_index
	}, 
	; 27
	%struct.TypeMapModuleEntry {
		i32 33554614, ; type_token_id
		i32 680; java_map_index
	}, 
	; 28
	%struct.TypeMapModuleEntry {
		i32 33554616, ; type_token_id
		i32 502; java_map_index
	}, 
	; 29
	%struct.TypeMapModuleEntry {
		i32 33554617, ; type_token_id
		i32 555; java_map_index
	}, 
	; 30
	%struct.TypeMapModuleEntry {
		i32 33554620, ; type_token_id
		i32 630; java_map_index
	}, 
	; 31
	%struct.TypeMapModuleEntry {
		i32 33554622, ; type_token_id
		i32 365; java_map_index
	}, 
	; 32
	%struct.TypeMapModuleEntry {
		i32 33554623, ; type_token_id
		i32 289; java_map_index
	}, 
	; 33
	%struct.TypeMapModuleEntry {
		i32 33554624, ; type_token_id
		i32 493; java_map_index
	}, 
	; 34
	%struct.TypeMapModuleEntry {
		i32 33554625, ; type_token_id
		i32 440; java_map_index
	}, 
	; 35
	%struct.TypeMapModuleEntry {
		i32 33554627, ; type_token_id
		i32 674; java_map_index
	}, 
	; 36
	%struct.TypeMapModuleEntry {
		i32 33554629, ; type_token_id
		i32 733; java_map_index
	}, 
	; 37
	%struct.TypeMapModuleEntry {
		i32 33554631, ; type_token_id
		i32 43; java_map_index
	}, 
	; 38
	%struct.TypeMapModuleEntry {
		i32 33554633, ; type_token_id
		i32 731; java_map_index
	}, 
	; 39
	%struct.TypeMapModuleEntry {
		i32 33554635, ; type_token_id
		i32 565; java_map_index
	}, 
	; 40
	%struct.TypeMapModuleEntry {
		i32 33554637, ; type_token_id
		i32 514; java_map_index
	}, 
	; 41
	%struct.TypeMapModuleEntry {
		i32 33554639, ; type_token_id
		i32 196; java_map_index
	}, 
	; 42
	%struct.TypeMapModuleEntry {
		i32 33554641, ; type_token_id
		i32 714; java_map_index
	}, 
	; 43
	%struct.TypeMapModuleEntry {
		i32 33554643, ; type_token_id
		i32 509; java_map_index
	}, 
	; 44
	%struct.TypeMapModuleEntry {
		i32 33554645, ; type_token_id
		i32 255; java_map_index
	}, 
	; 45
	%struct.TypeMapModuleEntry {
		i32 33554647, ; type_token_id
		i32 81; java_map_index
	}, 
	; 46
	%struct.TypeMapModuleEntry {
		i32 33554649, ; type_token_id
		i32 284; java_map_index
	}, 
	; 47
	%struct.TypeMapModuleEntry {
		i32 33554650, ; type_token_id
		i32 559; java_map_index
	}, 
	; 48
	%struct.TypeMapModuleEntry {
		i32 33554652, ; type_token_id
		i32 557; java_map_index
	}, 
	; 49
	%struct.TypeMapModuleEntry {
		i32 33554653, ; type_token_id
		i32 18; java_map_index
	}, 
	; 50
	%struct.TypeMapModuleEntry {
		i32 33554654, ; type_token_id
		i32 156; java_map_index
	}, 
	; 51
	%struct.TypeMapModuleEntry {
		i32 33554656, ; type_token_id
		i32 622; java_map_index
	}, 
	; 52
	%struct.TypeMapModuleEntry {
		i32 33554657, ; type_token_id
		i32 79; java_map_index
	}, 
	; 53
	%struct.TypeMapModuleEntry {
		i32 33554659, ; type_token_id
		i32 668; java_map_index
	}, 
	; 54
	%struct.TypeMapModuleEntry {
		i32 33554662, ; type_token_id
		i32 313; java_map_index
	}, 
	; 55
	%struct.TypeMapModuleEntry {
		i32 33554663, ; type_token_id
		i32 468; java_map_index
	}, 
	; 56
	%struct.TypeMapModuleEntry {
		i32 33554664, ; type_token_id
		i32 336; java_map_index
	}, 
	; 57
	%struct.TypeMapModuleEntry {
		i32 33554665, ; type_token_id
		i32 531; java_map_index
	}, 
	; 58
	%struct.TypeMapModuleEntry {
		i32 33554666, ; type_token_id
		i32 296; java_map_index
	}, 
	; 59
	%struct.TypeMapModuleEntry {
		i32 33554667, ; type_token_id
		i32 330; java_map_index
	}, 
	; 60
	%struct.TypeMapModuleEntry {
		i32 33554669, ; type_token_id
		i32 707; java_map_index
	}, 
	; 61
	%struct.TypeMapModuleEntry {
		i32 33554670, ; type_token_id
		i32 150; java_map_index
	}, 
	; 62
	%struct.TypeMapModuleEntry {
		i32 33554675, ; type_token_id
		i32 8; java_map_index
	}, 
	; 63
	%struct.TypeMapModuleEntry {
		i32 33554676, ; type_token_id
		i32 49; java_map_index
	}, 
	; 64
	%struct.TypeMapModuleEntry {
		i32 33554677, ; type_token_id
		i32 78; java_map_index
	}, 
	; 65
	%struct.TypeMapModuleEntry {
		i32 33554679, ; type_token_id
		i32 570; java_map_index
	}, 
	; 66
	%struct.TypeMapModuleEntry {
		i32 33554680, ; type_token_id
		i32 95; java_map_index
	}, 
	; 67
	%struct.TypeMapModuleEntry {
		i32 33554681, ; type_token_id
		i32 634; java_map_index
	}, 
	; 68
	%struct.TypeMapModuleEntry {
		i32 33554683, ; type_token_id
		i32 649; java_map_index
	}, 
	; 69
	%struct.TypeMapModuleEntry {
		i32 33554684, ; type_token_id
		i32 213; java_map_index
	}, 
	; 70
	%struct.TypeMapModuleEntry {
		i32 33554687, ; type_token_id
		i32 166; java_map_index
	}, 
	; 71
	%struct.TypeMapModuleEntry {
		i32 33554699, ; type_token_id
		i32 372; java_map_index
	}, 
	; 72
	%struct.TypeMapModuleEntry {
		i32 33554701, ; type_token_id
		i32 696; java_map_index
	}, 
	; 73
	%struct.TypeMapModuleEntry {
		i32 33554703, ; type_token_id
		i32 626; java_map_index
	}, 
	; 74
	%struct.TypeMapModuleEntry {
		i32 33554704, ; type_token_id
		i32 363; java_map_index
	}, 
	; 75
	%struct.TypeMapModuleEntry {
		i32 33554705, ; type_token_id
		i32 35; java_map_index
	}, 
	; 76
	%struct.TypeMapModuleEntry {
		i32 33554710, ; type_token_id
		i32 427; java_map_index
	}, 
	; 77
	%struct.TypeMapModuleEntry {
		i32 33554711, ; type_token_id
		i32 14; java_map_index
	}, 
	; 78
	%struct.TypeMapModuleEntry {
		i32 33554712, ; type_token_id
		i32 515; java_map_index
	}, 
	; 79
	%struct.TypeMapModuleEntry {
		i32 33554714, ; type_token_id
		i32 704; java_map_index
	}, 
	; 80
	%struct.TypeMapModuleEntry {
		i32 33554715, ; type_token_id
		i32 544; java_map_index
	}, 
	; 81
	%struct.TypeMapModuleEntry {
		i32 33554716, ; type_token_id
		i32 497; java_map_index
	}, 
	; 82
	%struct.TypeMapModuleEntry {
		i32 33554718, ; type_token_id
		i32 322; java_map_index
	}, 
	; 83
	%struct.TypeMapModuleEntry {
		i32 33554719, ; type_token_id
		i32 489; java_map_index
	}, 
	; 84
	%struct.TypeMapModuleEntry {
		i32 33554720, ; type_token_id
		i32 635; java_map_index
	}, 
	; 85
	%struct.TypeMapModuleEntry {
		i32 33554721, ; type_token_id
		i32 96; java_map_index
	}, 
	; 86
	%struct.TypeMapModuleEntry {
		i32 33554722, ; type_token_id
		i32 290; java_map_index
	}, 
	; 87
	%struct.TypeMapModuleEntry {
		i32 33554723, ; type_token_id
		i32 121; java_map_index
	}, 
	; 88
	%struct.TypeMapModuleEntry {
		i32 33554725, ; type_token_id
		i32 553; java_map_index
	}, 
	; 89
	%struct.TypeMapModuleEntry {
		i32 33554727, ; type_token_id
		i32 317; java_map_index
	}, 
	; 90
	%struct.TypeMapModuleEntry {
		i32 33554729, ; type_token_id
		i32 368; java_map_index
	}, 
	; 91
	%struct.TypeMapModuleEntry {
		i32 33554731, ; type_token_id
		i32 730; java_map_index
	}, 
	; 92
	%struct.TypeMapModuleEntry {
		i32 33554733, ; type_token_id
		i32 715; java_map_index
	}, 
	; 93
	%struct.TypeMapModuleEntry {
		i32 33554734, ; type_token_id
		i32 82; java_map_index
	}, 
	; 94
	%struct.TypeMapModuleEntry {
		i32 33554735, ; type_token_id
		i32 314; java_map_index
	}, 
	; 95
	%struct.TypeMapModuleEntry {
		i32 33554739, ; type_token_id
		i32 149; java_map_index
	}, 
	; 96
	%struct.TypeMapModuleEntry {
		i32 33554740, ; type_token_id
		i32 657; java_map_index
	}, 
	; 97
	%struct.TypeMapModuleEntry {
		i32 33554742, ; type_token_id
		i32 298; java_map_index
	}, 
	; 98
	%struct.TypeMapModuleEntry {
		i32 33554743, ; type_token_id
		i32 449; java_map_index
	}, 
	; 99
	%struct.TypeMapModuleEntry {
		i32 33554745, ; type_token_id
		i32 389; java_map_index
	}, 
	; 100
	%struct.TypeMapModuleEntry {
		i32 33554746, ; type_token_id
		i32 356; java_map_index
	}, 
	; 101
	%struct.TypeMapModuleEntry {
		i32 33554747, ; type_token_id
		i32 463; java_map_index
	}, 
	; 102
	%struct.TypeMapModuleEntry {
		i32 33554748, ; type_token_id
		i32 523; java_map_index
	}, 
	; 103
	%struct.TypeMapModuleEntry {
		i32 33554749, ; type_token_id
		i32 505; java_map_index
	}, 
	; 104
	%struct.TypeMapModuleEntry {
		i32 33554750, ; type_token_id
		i32 647; java_map_index
	}, 
	; 105
	%struct.TypeMapModuleEntry {
		i32 33554751, ; type_token_id
		i32 511; java_map_index
	}, 
	; 106
	%struct.TypeMapModuleEntry {
		i32 33554752, ; type_token_id
		i32 691; java_map_index
	}, 
	; 107
	%struct.TypeMapModuleEntry {
		i32 33554753, ; type_token_id
		i32 665; java_map_index
	}, 
	; 108
	%struct.TypeMapModuleEntry {
		i32 33554754, ; type_token_id
		i32 295; java_map_index
	}, 
	; 109
	%struct.TypeMapModuleEntry {
		i32 33554755, ; type_token_id
		i32 225; java_map_index
	}, 
	; 110
	%struct.TypeMapModuleEntry {
		i32 33554756, ; type_token_id
		i32 325; java_map_index
	}, 
	; 111
	%struct.TypeMapModuleEntry {
		i32 33554757, ; type_token_id
		i32 737; java_map_index
	}, 
	; 112
	%struct.TypeMapModuleEntry {
		i32 33554758, ; type_token_id
		i32 234; java_map_index
	}, 
	; 113
	%struct.TypeMapModuleEntry {
		i32 33554759, ; type_token_id
		i32 677; java_map_index
	}, 
	; 114
	%struct.TypeMapModuleEntry {
		i32 33554760, ; type_token_id
		i32 252; java_map_index
	}, 
	; 115
	%struct.TypeMapModuleEntry {
		i32 33554763, ; type_token_id
		i32 472; java_map_index
	}, 
	; 116
	%struct.TypeMapModuleEntry {
		i32 33554764, ; type_token_id
		i32 645; java_map_index
	}, 
	; 117
	%struct.TypeMapModuleEntry {
		i32 33554767, ; type_token_id
		i32 169; java_map_index
	}, 
	; 118
	%struct.TypeMapModuleEntry {
		i32 33554769, ; type_token_id
		i32 44; java_map_index
	}, 
	; 119
	%struct.TypeMapModuleEntry {
		i32 33554770, ; type_token_id
		i32 0; java_map_index
	}, 
	; 120
	%struct.TypeMapModuleEntry {
		i32 33554772, ; type_token_id
		i32 129; java_map_index
	}, 
	; 121
	%struct.TypeMapModuleEntry {
		i32 33554775, ; type_token_id
		i32 387; java_map_index
	}, 
	; 122
	%struct.TypeMapModuleEntry {
		i32 33554777, ; type_token_id
		i32 57; java_map_index
	}, 
	; 123
	%struct.TypeMapModuleEntry {
		i32 33554780, ; type_token_id
		i32 358; java_map_index
	}, 
	; 124
	%struct.TypeMapModuleEntry {
		i32 33554781, ; type_token_id
		i32 407; java_map_index
	}, 
	; 125
	%struct.TypeMapModuleEntry {
		i32 33554782, ; type_token_id
		i32 318; java_map_index
	}, 
	; 126
	%struct.TypeMapModuleEntry {
		i32 33554784, ; type_token_id
		i32 695; java_map_index
	}, 
	; 127
	%struct.TypeMapModuleEntry {
		i32 33554785, ; type_token_id
		i32 423; java_map_index
	}, 
	; 128
	%struct.TypeMapModuleEntry {
		i32 33554790, ; type_token_id
		i32 354; java_map_index
	}, 
	; 129
	%struct.TypeMapModuleEntry {
		i32 33554792, ; type_token_id
		i32 240; java_map_index
	}, 
	; 130
	%struct.TypeMapModuleEntry {
		i32 33554793, ; type_token_id
		i32 702; java_map_index
	}, 
	; 131
	%struct.TypeMapModuleEntry {
		i32 33554795, ; type_token_id
		i32 689; java_map_index
	}, 
	; 132
	%struct.TypeMapModuleEntry {
		i32 33554796, ; type_token_id
		i32 430; java_map_index
	}, 
	; 133
	%struct.TypeMapModuleEntry {
		i32 33554798, ; type_token_id
		i32 699; java_map_index
	}, 
	; 134
	%struct.TypeMapModuleEntry {
		i32 33554800, ; type_token_id
		i32 454; java_map_index
	}, 
	; 135
	%struct.TypeMapModuleEntry {
		i32 33554802, ; type_token_id
		i32 510; java_map_index
	}, 
	; 136
	%struct.TypeMapModuleEntry {
		i32 33554804, ; type_token_id
		i32 367; java_map_index
	}, 
	; 137
	%struct.TypeMapModuleEntry {
		i32 33554806, ; type_token_id
		i32 362; java_map_index
	}, 
	; 138
	%struct.TypeMapModuleEntry {
		i32 33554807, ; type_token_id
		i32 377; java_map_index
	}, 
	; 139
	%struct.TypeMapModuleEntry {
		i32 33554808, ; type_token_id
		i32 507; java_map_index
	}, 
	; 140
	%struct.TypeMapModuleEntry {
		i32 33554810, ; type_token_id
		i32 37; java_map_index
	}, 
	; 141
	%struct.TypeMapModuleEntry {
		i32 33554812, ; type_token_id
		i32 438; java_map_index
	}, 
	; 142
	%struct.TypeMapModuleEntry {
		i32 33554814, ; type_token_id
		i32 590; java_map_index
	}, 
	; 143
	%struct.TypeMapModuleEntry {
		i32 33554818, ; type_token_id
		i32 326; java_map_index
	}, 
	; 144
	%struct.TypeMapModuleEntry {
		i32 33554819, ; type_token_id
		i32 384; java_map_index
	}, 
	; 145
	%struct.TypeMapModuleEntry {
		i32 33554820, ; type_token_id
		i32 170; java_map_index
	}, 
	; 146
	%struct.TypeMapModuleEntry {
		i32 33554821, ; type_token_id
		i32 504; java_map_index
	}, 
	; 147
	%struct.TypeMapModuleEntry {
		i32 33554822, ; type_token_id
		i32 457; java_map_index
	}, 
	; 148
	%struct.TypeMapModuleEntry {
		i32 33554847, ; type_token_id
		i32 681; java_map_index
	}, 
	; 149
	%struct.TypeMapModuleEntry {
		i32 33554850, ; type_token_id
		i32 526; java_map_index
	}, 
	; 150
	%struct.TypeMapModuleEntry {
		i32 33554852, ; type_token_id
		i32 224; java_map_index
	}, 
	; 151
	%struct.TypeMapModuleEntry {
		i32 33554854, ; type_token_id
		i32 267; java_map_index
	}, 
	; 152
	%struct.TypeMapModuleEntry {
		i32 33554863, ; type_token_id
		i32 109; java_map_index
	}, 
	; 153
	%struct.TypeMapModuleEntry {
		i32 33554865, ; type_token_id
		i32 629; java_map_index
	}, 
	; 154
	%struct.TypeMapModuleEntry {
		i32 33554867, ; type_token_id
		i32 606; java_map_index
	}, 
	; 155
	%struct.TypeMapModuleEntry {
		i32 33554868, ; type_token_id
		i32 728; java_map_index
	}, 
	; 156
	%struct.TypeMapModuleEntry {
		i32 33554884, ; type_token_id
		i32 85; java_map_index
	}, 
	; 157
	%struct.TypeMapModuleEntry {
		i32 33554894, ; type_token_id
		i32 168; java_map_index
	}, 
	; 158
	%struct.TypeMapModuleEntry {
		i32 33554896, ; type_token_id
		i32 581; java_map_index
	}, 
	; 159
	%struct.TypeMapModuleEntry {
		i32 33554898, ; type_token_id
		i32 650; java_map_index
	}, 
	; 160
	%struct.TypeMapModuleEntry {
		i32 33554899, ; type_token_id
		i32 450; java_map_index
	}, 
	; 161
	%struct.TypeMapModuleEntry {
		i32 33554900, ; type_token_id
		i32 112; java_map_index
	}, 
	; 162
	%struct.TypeMapModuleEntry {
		i32 33554904, ; type_token_id
		i32 286; java_map_index
	}, 
	; 163
	%struct.TypeMapModuleEntry {
		i32 33554906, ; type_token_id
		i32 190; java_map_index
	}, 
	; 164
	%struct.TypeMapModuleEntry {
		i32 33554908, ; type_token_id
		i32 61; java_map_index
	}, 
	; 165
	%struct.TypeMapModuleEntry {
		i32 33554910, ; type_token_id
		i32 554; java_map_index
	}, 
	; 166
	%struct.TypeMapModuleEntry {
		i32 33554912, ; type_token_id
		i32 499; java_map_index
	}, 
	; 167
	%struct.TypeMapModuleEntry {
		i32 33554914, ; type_token_id
		i32 320; java_map_index
	}, 
	; 168
	%struct.TypeMapModuleEntry {
		i32 33554916, ; type_token_id
		i32 181; java_map_index
	}, 
	; 169
	%struct.TypeMapModuleEntry {
		i32 33554917, ; type_token_id
		i32 608; java_map_index
	}, 
	; 170
	%struct.TypeMapModuleEntry {
		i32 33554919, ; type_token_id
		i32 400; java_map_index
	}, 
	; 171
	%struct.TypeMapModuleEntry {
		i32 33554920, ; type_token_id
		i32 180; java_map_index
	}, 
	; 172
	%struct.TypeMapModuleEntry {
		i32 33554922, ; type_token_id
		i32 38; java_map_index
	}, 
	; 173
	%struct.TypeMapModuleEntry {
		i32 33554924, ; type_token_id
		i32 498; java_map_index
	}, 
	; 174
	%struct.TypeMapModuleEntry {
		i32 33554926, ; type_token_id
		i32 261; java_map_index
	}, 
	; 175
	%struct.TypeMapModuleEntry {
		i32 33554928, ; type_token_id
		i32 735; java_map_index
	}, 
	; 176
	%struct.TypeMapModuleEntry {
		i32 33554930, ; type_token_id
		i32 615; java_map_index
	}, 
	; 177
	%struct.TypeMapModuleEntry {
		i32 33554932, ; type_token_id
		i32 369; java_map_index
	}, 
	; 178
	%struct.TypeMapModuleEntry {
		i32 33554934, ; type_token_id
		i32 273; java_map_index
	}, 
	; 179
	%struct.TypeMapModuleEntry {
		i32 33554936, ; type_token_id
		i32 538; java_map_index
	}, 
	; 180
	%struct.TypeMapModuleEntry {
		i32 33554938, ; type_token_id
		i32 676; java_map_index
	}, 
	; 181
	%struct.TypeMapModuleEntry {
		i32 33554940, ; type_token_id
		i32 75; java_map_index
	}, 
	; 182
	%struct.TypeMapModuleEntry {
		i32 33554941, ; type_token_id
		i32 294; java_map_index
	}, 
	; 183
	%struct.TypeMapModuleEntry {
		i32 33554943, ; type_token_id
		i32 672; java_map_index
	}, 
	; 184
	%struct.TypeMapModuleEntry {
		i32 33554944, ; type_token_id
		i32 58; java_map_index
	}, 
	; 185
	%struct.TypeMapModuleEntry {
		i32 33554946, ; type_token_id
		i32 176; java_map_index
	}, 
	; 186
	%struct.TypeMapModuleEntry {
		i32 33554948, ; type_token_id
		i32 378; java_map_index
	}, 
	; 187
	%struct.TypeMapModuleEntry {
		i32 33554949, ; type_token_id
		i32 6; java_map_index
	}, 
	; 188
	%struct.TypeMapModuleEntry {
		i32 33554951, ; type_token_id
		i32 333; java_map_index
	}, 
	; 189
	%struct.TypeMapModuleEntry {
		i32 33554952, ; type_token_id
		i32 371; java_map_index
	}, 
	; 190
	%struct.TypeMapModuleEntry {
		i32 33554954, ; type_token_id
		i32 443; java_map_index
	}, 
	; 191
	%struct.TypeMapModuleEntry {
		i32 33554956, ; type_token_id
		i32 706; java_map_index
	}, 
	; 192
	%struct.TypeMapModuleEntry {
		i32 33554958, ; type_token_id
		i32 140; java_map_index
	}, 
	; 193
	%struct.TypeMapModuleEntry {
		i32 33554960, ; type_token_id
		i32 342; java_map_index
	}, 
	; 194
	%struct.TypeMapModuleEntry {
		i32 33554962, ; type_token_id
		i32 547; java_map_index
	}, 
	; 195
	%struct.TypeMapModuleEntry {
		i32 33554964, ; type_token_id
		i32 92; java_map_index
	}, 
	; 196
	%struct.TypeMapModuleEntry {
		i32 33554966, ; type_token_id
		i32 292; java_map_index
	}, 
	; 197
	%struct.TypeMapModuleEntry {
		i32 33554968, ; type_token_id
		i32 26; java_map_index
	}, 
	; 198
	%struct.TypeMapModuleEntry {
		i32 33554970, ; type_token_id
		i32 161; java_map_index
	}, 
	; 199
	%struct.TypeMapModuleEntry {
		i32 33554972, ; type_token_id
		i32 338; java_map_index
	}, 
	; 200
	%struct.TypeMapModuleEntry {
		i32 33554974, ; type_token_id
		i32 436; java_map_index
	}, 
	; 201
	%struct.TypeMapModuleEntry {
		i32 33554976, ; type_token_id
		i32 293; java_map_index
	}, 
	; 202
	%struct.TypeMapModuleEntry {
		i32 33554978, ; type_token_id
		i32 15; java_map_index
	}, 
	; 203
	%struct.TypeMapModuleEntry {
		i32 33554980, ; type_token_id
		i32 28; java_map_index
	}, 
	; 204
	%struct.TypeMapModuleEntry {
		i32 33554982, ; type_token_id
		i32 270; java_map_index
	}, 
	; 205
	%struct.TypeMapModuleEntry {
		i32 33554984, ; type_token_id
		i32 62; java_map_index
	}, 
	; 206
	%struct.TypeMapModuleEntry {
		i32 33554985, ; type_token_id
		i32 251; java_map_index
	}, 
	; 207
	%struct.TypeMapModuleEntry {
		i32 33554987, ; type_token_id
		i32 624; java_map_index
	}, 
	; 208
	%struct.TypeMapModuleEntry {
		i32 33554988, ; type_token_id
		i32 639; java_map_index
	}, 
	; 209
	%struct.TypeMapModuleEntry {
		i32 33554989, ; type_token_id
		i32 573; java_map_index
	}, 
	; 210
	%struct.TypeMapModuleEntry {
		i32 33554990, ; type_token_id
		i32 403; java_map_index
	}, 
	; 211
	%struct.TypeMapModuleEntry {
		i32 33554991, ; type_token_id
		i32 476; java_map_index
	}, 
	; 212
	%struct.TypeMapModuleEntry {
		i32 33554993, ; type_token_id
		i32 167; java_map_index
	}, 
	; 213
	%struct.TypeMapModuleEntry {
		i32 33554995, ; type_token_id
		i32 428; java_map_index
	}, 
	; 214
	%struct.TypeMapModuleEntry {
		i32 33554996, ; type_token_id
		i32 214; java_map_index
	}, 
	; 215
	%struct.TypeMapModuleEntry {
		i32 33554997, ; type_token_id
		i32 402; java_map_index
	}, 
	; 216
	%struct.TypeMapModuleEntry {
		i32 33554998, ; type_token_id
		i32 48; java_map_index
	}, 
	; 217
	%struct.TypeMapModuleEntry {
		i32 33554999, ; type_token_id
		i32 100; java_map_index
	}, 
	; 218
	%struct.TypeMapModuleEntry {
		i32 33555000, ; type_token_id
		i32 599; java_map_index
	}, 
	; 219
	%struct.TypeMapModuleEntry {
		i32 33555003, ; type_token_id
		i32 469; java_map_index
	}, 
	; 220
	%struct.TypeMapModuleEntry {
		i32 33555006, ; type_token_id
		i32 359; java_map_index
	}, 
	; 221
	%struct.TypeMapModuleEntry {
		i32 33555007, ; type_token_id
		i32 303; java_map_index
	}, 
	; 222
	%struct.TypeMapModuleEntry {
		i32 33555008, ; type_token_id
		i32 312; java_map_index
	}, 
	; 223
	%struct.TypeMapModuleEntry {
		i32 33555009, ; type_token_id
		i32 666; java_map_index
	}, 
	; 224
	%struct.TypeMapModuleEntry {
		i32 33555010, ; type_token_id
		i32 232; java_map_index
	}, 
	; 225
	%struct.TypeMapModuleEntry {
		i32 33555011, ; type_token_id
		i32 63; java_map_index
	}, 
	; 226
	%struct.TypeMapModuleEntry {
		i32 33555013, ; type_token_id
		i32 195; java_map_index
	}, 
	; 227
	%struct.TypeMapModuleEntry {
		i32 33555014, ; type_token_id
		i32 633; java_map_index
	}, 
	; 228
	%struct.TypeMapModuleEntry {
		i32 33555015, ; type_token_id
		i32 422; java_map_index
	}, 
	; 229
	%struct.TypeMapModuleEntry {
		i32 33555017, ; type_token_id
		i32 693; java_map_index
	}, 
	; 230
	%struct.TypeMapModuleEntry {
		i32 33555018, ; type_token_id
		i32 517; java_map_index
	}, 
	; 231
	%struct.TypeMapModuleEntry {
		i32 33555019, ; type_token_id
		i32 478; java_map_index
	}, 
	; 232
	%struct.TypeMapModuleEntry {
		i32 33555020, ; type_token_id
		i32 199; java_map_index
	}, 
	; 233
	%struct.TypeMapModuleEntry {
		i32 33555022, ; type_token_id
		i32 117; java_map_index
	}, 
	; 234
	%struct.TypeMapModuleEntry {
		i32 33555025, ; type_token_id
		i32 192; java_map_index
	}, 
	; 235
	%struct.TypeMapModuleEntry {
		i32 33555027, ; type_token_id
		i32 241; java_map_index
	}, 
	; 236
	%struct.TypeMapModuleEntry {
		i32 33555029, ; type_token_id
		i32 415; java_map_index
	}, 
	; 237
	%struct.TypeMapModuleEntry {
		i32 33555031, ; type_token_id
		i32 24; java_map_index
	}, 
	; 238
	%struct.TypeMapModuleEntry {
		i32 33555032, ; type_token_id
		i32 93; java_map_index
	}, 
	; 239
	%struct.TypeMapModuleEntry {
		i32 33555033, ; type_token_id
		i32 299; java_map_index
	}, 
	; 240
	%struct.TypeMapModuleEntry {
		i32 33555034, ; type_token_id
		i32 119; java_map_index
	}, 
	; 241
	%struct.TypeMapModuleEntry {
		i32 33555035, ; type_token_id
		i32 335; java_map_index
	}, 
	; 242
	%struct.TypeMapModuleEntry {
		i32 33555037, ; type_token_id
		i32 68; java_map_index
	}, 
	; 243
	%struct.TypeMapModuleEntry {
		i32 33555038, ; type_token_id
		i32 59; java_map_index
	}, 
	; 244
	%struct.TypeMapModuleEntry {
		i32 33555039, ; type_token_id
		i32 703; java_map_index
	}, 
	; 245
	%struct.TypeMapModuleEntry {
		i32 33555040, ; type_token_id
		i32 128; java_map_index
	}, 
	; 246
	%struct.TypeMapModuleEntry {
		i32 33555041, ; type_token_id
		i32 588; java_map_index
	}, 
	; 247
	%struct.TypeMapModuleEntry {
		i32 33555043, ; type_token_id
		i32 1; java_map_index
	}, 
	; 248
	%struct.TypeMapModuleEntry {
		i32 33555044, ; type_token_id
		i32 34; java_map_index
	}, 
	; 249
	%struct.TypeMapModuleEntry {
		i32 33555045, ; type_token_id
		i32 297; java_map_index
	}, 
	; 250
	%struct.TypeMapModuleEntry {
		i32 33555046, ; type_token_id
		i32 250; java_map_index
	}, 
	; 251
	%struct.TypeMapModuleEntry {
		i32 33555047, ; type_token_id
		i32 136; java_map_index
	}, 
	; 252
	%struct.TypeMapModuleEntry {
		i32 33555048, ; type_token_id
		i32 623; java_map_index
	}, 
	; 253
	%struct.TypeMapModuleEntry {
		i32 33555050, ; type_token_id
		i32 327; java_map_index
	}, 
	; 254
	%struct.TypeMapModuleEntry {
		i32 33555052, ; type_token_id
		i32 709; java_map_index
	}, 
	; 255
	%struct.TypeMapModuleEntry {
		i32 33555054, ; type_token_id
		i32 122; java_map_index
	}, 
	; 256
	%struct.TypeMapModuleEntry {
		i32 33555055, ; type_token_id
		i32 54; java_map_index
	}, 
	; 257
	%struct.TypeMapModuleEntry {
		i32 33555056, ; type_token_id
		i32 218; java_map_index
	}, 
	; 258
	%struct.TypeMapModuleEntry {
		i32 33555057, ; type_token_id
		i32 425; java_map_index
	}, 
	; 259
	%struct.TypeMapModuleEntry {
		i32 33555058, ; type_token_id
		i32 722; java_map_index
	}, 
	; 260
	%struct.TypeMapModuleEntry {
		i32 33555059, ; type_token_id
		i32 74; java_map_index
	}, 
	; 261
	%struct.TypeMapModuleEntry {
		i32 33555061, ; type_token_id
		i32 2; java_map_index
	}, 
	; 262
	%struct.TypeMapModuleEntry {
		i32 33555063, ; type_token_id
		i32 412; java_map_index
	}, 
	; 263
	%struct.TypeMapModuleEntry {
		i32 33555065, ; type_token_id
		i32 20; java_map_index
	}, 
	; 264
	%struct.TypeMapModuleEntry {
		i32 33555067, ; type_token_id
		i32 179; java_map_index
	}, 
	; 265
	%struct.TypeMapModuleEntry {
		i32 33555069, ; type_token_id
		i32 380; java_map_index
	}, 
	; 266
	%struct.TypeMapModuleEntry {
		i32 33555070, ; type_token_id
		i32 283; java_map_index
	}, 
	; 267
	%struct.TypeMapModuleEntry {
		i32 33555071, ; type_token_id
		i32 159; java_map_index
	}, 
	; 268
	%struct.TypeMapModuleEntry {
		i32 33555072, ; type_token_id
		i32 442; java_map_index
	}, 
	; 269
	%struct.TypeMapModuleEntry {
		i32 33555073, ; type_token_id
		i32 545; java_map_index
	}, 
	; 270
	%struct.TypeMapModuleEntry {
		i32 33555074, ; type_token_id
		i32 740; java_map_index
	}, 
	; 271
	%struct.TypeMapModuleEntry {
		i32 33555076, ; type_token_id
		i32 576; java_map_index
	}, 
	; 272
	%struct.TypeMapModuleEntry {
		i32 33555078, ; type_token_id
		i32 564; java_map_index
	}, 
	; 273
	%struct.TypeMapModuleEntry {
		i32 33555080, ; type_token_id
		i32 670; java_map_index
	}, 
	; 274
	%struct.TypeMapModuleEntry {
		i32 33555082, ; type_token_id
		i32 462; java_map_index
	}, 
	; 275
	%struct.TypeMapModuleEntry {
		i32 33555083, ; type_token_id
		i32 721; java_map_index
	}, 
	; 276
	%struct.TypeMapModuleEntry {
		i32 33555084, ; type_token_id
		i32 98; java_map_index
	}, 
	; 277
	%struct.TypeMapModuleEntry {
		i32 33555086, ; type_token_id
		i32 351; java_map_index
	}, 
	; 278
	%struct.TypeMapModuleEntry {
		i32 33555088, ; type_token_id
		i32 118; java_map_index
	}, 
	; 279
	%struct.TypeMapModuleEntry {
		i32 33555089, ; type_token_id
		i32 535; java_map_index
	}, 
	; 280
	%struct.TypeMapModuleEntry {
		i32 33555090, ; type_token_id
		i32 708; java_map_index
	}, 
	; 281
	%struct.TypeMapModuleEntry {
		i32 33555115, ; type_token_id
		i32 528; java_map_index
	}
], align 4; end of 'module7_managed_to_java' array


; module7_managed_to_java_duplicates
@module7_managed_to_java_duplicates = internal constant [147 x %struct.TypeMapModuleEntry] [
	; 0
	%struct.TypeMapModuleEntry {
		i32 33554563, ; type_token_id
		i32 204; java_map_index
	}, 
	; 1
	%struct.TypeMapModuleEntry {
		i32 33554565, ; type_token_id
		i32 36; java_map_index
	}, 
	; 2
	%struct.TypeMapModuleEntry {
		i32 33554568, ; type_token_id
		i32 637; java_map_index
	}, 
	; 3
	%struct.TypeMapModuleEntry {
		i32 33554570, ; type_token_id
		i32 585; java_map_index
	}, 
	; 4
	%struct.TypeMapModuleEntry {
		i32 33554572, ; type_token_id
		i32 464; java_map_index
	}, 
	; 5
	%struct.TypeMapModuleEntry {
		i32 33554574, ; type_token_id
		i32 235; java_map_index
	}, 
	; 6
	%struct.TypeMapModuleEntry {
		i32 33554576, ; type_token_id
		i32 571; java_map_index
	}, 
	; 7
	%struct.TypeMapModuleEntry {
		i32 33554578, ; type_token_id
		i32 17; java_map_index
	}, 
	; 8
	%struct.TypeMapModuleEntry {
		i32 33554580, ; type_token_id
		i32 134; java_map_index
	}, 
	; 9
	%struct.TypeMapModuleEntry {
		i32 33554582, ; type_token_id
		i32 661; java_map_index
	}, 
	; 10
	%struct.TypeMapModuleEntry {
		i32 33554586, ; type_token_id
		i32 684; java_map_index
	}, 
	; 11
	%struct.TypeMapModuleEntry {
		i32 33554598, ; type_token_id
		i32 25; java_map_index
	}, 
	; 12
	%struct.TypeMapModuleEntry {
		i32 33554600, ; type_token_id
		i32 432; java_map_index
	}, 
	; 13
	%struct.TypeMapModuleEntry {
		i32 33554603, ; type_token_id
		i32 349; java_map_index
	}, 
	; 14
	%struct.TypeMapModuleEntry {
		i32 33554604, ; type_token_id
		i32 366; java_map_index
	}, 
	; 15
	%struct.TypeMapModuleEntry {
		i32 33554610, ; type_token_id
		i32 467; java_map_index
	}, 
	; 16
	%struct.TypeMapModuleEntry {
		i32 33554612, ; type_token_id
		i32 373; java_map_index
	}, 
	; 17
	%struct.TypeMapModuleEntry {
		i32 33554618, ; type_token_id
		i32 555; java_map_index
	}, 
	; 18
	%struct.TypeMapModuleEntry {
		i32 33554619, ; type_token_id
		i32 502; java_map_index
	}, 
	; 19
	%struct.TypeMapModuleEntry {
		i32 33554621, ; type_token_id
		i32 630; java_map_index
	}, 
	; 20
	%struct.TypeMapModuleEntry {
		i32 33554626, ; type_token_id
		i32 440; java_map_index
	}, 
	; 21
	%struct.TypeMapModuleEntry {
		i32 33554628, ; type_token_id
		i32 674; java_map_index
	}, 
	; 22
	%struct.TypeMapModuleEntry {
		i32 33554630, ; type_token_id
		i32 733; java_map_index
	}, 
	; 23
	%struct.TypeMapModuleEntry {
		i32 33554632, ; type_token_id
		i32 43; java_map_index
	}, 
	; 24
	%struct.TypeMapModuleEntry {
		i32 33554634, ; type_token_id
		i32 731; java_map_index
	}, 
	; 25
	%struct.TypeMapModuleEntry {
		i32 33554636, ; type_token_id
		i32 565; java_map_index
	}, 
	; 26
	%struct.TypeMapModuleEntry {
		i32 33554638, ; type_token_id
		i32 514; java_map_index
	}, 
	; 27
	%struct.TypeMapModuleEntry {
		i32 33554640, ; type_token_id
		i32 196; java_map_index
	}, 
	; 28
	%struct.TypeMapModuleEntry {
		i32 33554642, ; type_token_id
		i32 714; java_map_index
	}, 
	; 29
	%struct.TypeMapModuleEntry {
		i32 33554644, ; type_token_id
		i32 509; java_map_index
	}, 
	; 30
	%struct.TypeMapModuleEntry {
		i32 33554646, ; type_token_id
		i32 255; java_map_index
	}, 
	; 31
	%struct.TypeMapModuleEntry {
		i32 33554648, ; type_token_id
		i32 81; java_map_index
	}, 
	; 32
	%struct.TypeMapModuleEntry {
		i32 33554651, ; type_token_id
		i32 559; java_map_index
	}, 
	; 33
	%struct.TypeMapModuleEntry {
		i32 33554655, ; type_token_id
		i32 156; java_map_index
	}, 
	; 34
	%struct.TypeMapModuleEntry {
		i32 33554658, ; type_token_id
		i32 79; java_map_index
	}, 
	; 35
	%struct.TypeMapModuleEntry {
		i32 33554660, ; type_token_id
		i32 668; java_map_index
	}, 
	; 36
	%struct.TypeMapModuleEntry {
		i32 33554661, ; type_token_id
		i32 622; java_map_index
	}, 
	; 37
	%struct.TypeMapModuleEntry {
		i32 33554668, ; type_token_id
		i32 330; java_map_index
	}, 
	; 38
	%struct.TypeMapModuleEntry {
		i32 33554671, ; type_token_id
		i32 150; java_map_index
	}, 
	; 39
	%struct.TypeMapModuleEntry {
		i32 33554678, ; type_token_id
		i32 8; java_map_index
	}, 
	; 40
	%struct.TypeMapModuleEntry {
		i32 33554682, ; type_token_id
		i32 634; java_map_index
	}, 
	; 41
	%struct.TypeMapModuleEntry {
		i32 33554685, ; type_token_id
		i32 213; java_map_index
	}, 
	; 42
	%struct.TypeMapModuleEntry {
		i32 33554686, ; type_token_id
		i32 649; java_map_index
	}, 
	; 43
	%struct.TypeMapModuleEntry {
		i32 33554700, ; type_token_id
		i32 372; java_map_index
	}, 
	; 44
	%struct.TypeMapModuleEntry {
		i32 33554702, ; type_token_id
		i32 696; java_map_index
	}, 
	; 45
	%struct.TypeMapModuleEntry {
		i32 33554706, ; type_token_id
		i32 35; java_map_index
	}, 
	; 46
	%struct.TypeMapModuleEntry {
		i32 33554713, ; type_token_id
		i32 515; java_map_index
	}, 
	; 47
	%struct.TypeMapModuleEntry {
		i32 33554717, ; type_token_id
		i32 497; java_map_index
	}, 
	; 48
	%struct.TypeMapModuleEntry {
		i32 33554724, ; type_token_id
		i32 121; java_map_index
	}, 
	; 49
	%struct.TypeMapModuleEntry {
		i32 33554726, ; type_token_id
		i32 553; java_map_index
	}, 
	; 50
	%struct.TypeMapModuleEntry {
		i32 33554728, ; type_token_id
		i32 317; java_map_index
	}, 
	; 51
	%struct.TypeMapModuleEntry {
		i32 33554730, ; type_token_id
		i32 368; java_map_index
	}, 
	; 52
	%struct.TypeMapModuleEntry {
		i32 33554732, ; type_token_id
		i32 730; java_map_index
	}, 
	; 53
	%struct.TypeMapModuleEntry {
		i32 33554741, ; type_token_id
		i32 657; java_map_index
	}, 
	; 54
	%struct.TypeMapModuleEntry {
		i32 33554744, ; type_token_id
		i32 449; java_map_index
	}, 
	; 55
	%struct.TypeMapModuleEntry {
		i32 33554765, ; type_token_id
		i32 645; java_map_index
	}, 
	; 56
	%struct.TypeMapModuleEntry {
		i32 33554766, ; type_token_id
		i32 472; java_map_index
	}, 
	; 57
	%struct.TypeMapModuleEntry {
		i32 33554768, ; type_token_id
		i32 169; java_map_index
	}, 
	; 58
	%struct.TypeMapModuleEntry {
		i32 33554771, ; type_token_id
		i32 0; java_map_index
	}, 
	; 59
	%struct.TypeMapModuleEntry {
		i32 33554773, ; type_token_id
		i32 129; java_map_index
	}, 
	; 60
	%struct.TypeMapModuleEntry {
		i32 33554774, ; type_token_id
		i32 44; java_map_index
	}, 
	; 61
	%struct.TypeMapModuleEntry {
		i32 33554776, ; type_token_id
		i32 387; java_map_index
	}, 
	; 62
	%struct.TypeMapModuleEntry {
		i32 33554778, ; type_token_id
		i32 57; java_map_index
	}, 
	; 63
	%struct.TypeMapModuleEntry {
		i32 33554783, ; type_token_id
		i32 318; java_map_index
	}, 
	; 64
	%struct.TypeMapModuleEntry {
		i32 33554791, ; type_token_id
		i32 354; java_map_index
	}, 
	; 65
	%struct.TypeMapModuleEntry {
		i32 33554794, ; type_token_id
		i32 702; java_map_index
	}, 
	; 66
	%struct.TypeMapModuleEntry {
		i32 33554797, ; type_token_id
		i32 430; java_map_index
	}, 
	; 67
	%struct.TypeMapModuleEntry {
		i32 33554799, ; type_token_id
		i32 699; java_map_index
	}, 
	; 68
	%struct.TypeMapModuleEntry {
		i32 33554801, ; type_token_id
		i32 454; java_map_index
	}, 
	; 69
	%struct.TypeMapModuleEntry {
		i32 33554803, ; type_token_id
		i32 510; java_map_index
	}, 
	; 70
	%struct.TypeMapModuleEntry {
		i32 33554805, ; type_token_id
		i32 367; java_map_index
	}, 
	; 71
	%struct.TypeMapModuleEntry {
		i32 33554809, ; type_token_id
		i32 507; java_map_index
	}, 
	; 72
	%struct.TypeMapModuleEntry {
		i32 33554811, ; type_token_id
		i32 37; java_map_index
	}, 
	; 73
	%struct.TypeMapModuleEntry {
		i32 33554813, ; type_token_id
		i32 438; java_map_index
	}, 
	; 74
	%struct.TypeMapModuleEntry {
		i32 33554815, ; type_token_id
		i32 590; java_map_index
	}, 
	; 75
	%struct.TypeMapModuleEntry {
		i32 33554823, ; type_token_id
		i32 457; java_map_index
	}, 
	; 76
	%struct.TypeMapModuleEntry {
		i32 33554853, ; type_token_id
		i32 224; java_map_index
	}, 
	; 77
	%struct.TypeMapModuleEntry {
		i32 33554859, ; type_token_id
		i32 267; java_map_index
	}, 
	; 78
	%struct.TypeMapModuleEntry {
		i32 33554864, ; type_token_id
		i32 109; java_map_index
	}, 
	; 79
	%struct.TypeMapModuleEntry {
		i32 33554869, ; type_token_id
		i32 728; java_map_index
	}, 
	; 80
	%struct.TypeMapModuleEntry {
		i32 33554895, ; type_token_id
		i32 168; java_map_index
	}, 
	; 81
	%struct.TypeMapModuleEntry {
		i32 33554897, ; type_token_id
		i32 581; java_map_index
	}, 
	; 82
	%struct.TypeMapModuleEntry {
		i32 33554901, ; type_token_id
		i32 112; java_map_index
	}, 
	; 83
	%struct.TypeMapModuleEntry {
		i32 33554902, ; type_token_id
		i32 224; java_map_index
	}, 
	; 84
	%struct.TypeMapModuleEntry {
		i32 33554903, ; type_token_id
		i32 224; java_map_index
	}, 
	; 85
	%struct.TypeMapModuleEntry {
		i32 33554905, ; type_token_id
		i32 286; java_map_index
	}, 
	; 86
	%struct.TypeMapModuleEntry {
		i32 33554907, ; type_token_id
		i32 190; java_map_index
	}, 
	; 87
	%struct.TypeMapModuleEntry {
		i32 33554909, ; type_token_id
		i32 61; java_map_index
	}, 
	; 88
	%struct.TypeMapModuleEntry {
		i32 33554911, ; type_token_id
		i32 554; java_map_index
	}, 
	; 89
	%struct.TypeMapModuleEntry {
		i32 33554913, ; type_token_id
		i32 499; java_map_index
	}, 
	; 90
	%struct.TypeMapModuleEntry {
		i32 33554918, ; type_token_id
		i32 608; java_map_index
	}, 
	; 91
	%struct.TypeMapModuleEntry {
		i32 33554921, ; type_token_id
		i32 180; java_map_index
	}, 
	; 92
	%struct.TypeMapModuleEntry {
		i32 33554923, ; type_token_id
		i32 38; java_map_index
	}, 
	; 93
	%struct.TypeMapModuleEntry {
		i32 33554925, ; type_token_id
		i32 498; java_map_index
	}, 
	; 94
	%struct.TypeMapModuleEntry {
		i32 33554927, ; type_token_id
		i32 261; java_map_index
	}, 
	; 95
	%struct.TypeMapModuleEntry {
		i32 33554929, ; type_token_id
		i32 735; java_map_index
	}, 
	; 96
	%struct.TypeMapModuleEntry {
		i32 33554931, ; type_token_id
		i32 615; java_map_index
	}, 
	; 97
	%struct.TypeMapModuleEntry {
		i32 33554933, ; type_token_id
		i32 369; java_map_index
	}, 
	; 98
	%struct.TypeMapModuleEntry {
		i32 33554935, ; type_token_id
		i32 273; java_map_index
	}, 
	; 99
	%struct.TypeMapModuleEntry {
		i32 33554937, ; type_token_id
		i32 538; java_map_index
	}, 
	; 100
	%struct.TypeMapModuleEntry {
		i32 33554939, ; type_token_id
		i32 676; java_map_index
	}, 
	; 101
	%struct.TypeMapModuleEntry {
		i32 33554942, ; type_token_id
		i32 294; java_map_index
	}, 
	; 102
	%struct.TypeMapModuleEntry {
		i32 33554945, ; type_token_id
		i32 58; java_map_index
	}, 
	; 103
	%struct.TypeMapModuleEntry {
		i32 33554947, ; type_token_id
		i32 176; java_map_index
	}, 
	; 104
	%struct.TypeMapModuleEntry {
		i32 33554950, ; type_token_id
		i32 6; java_map_index
	}, 
	; 105
	%struct.TypeMapModuleEntry {
		i32 33554953, ; type_token_id
		i32 371; java_map_index
	}, 
	; 106
	%struct.TypeMapModuleEntry {
		i32 33554955, ; type_token_id
		i32 443; java_map_index
	}, 
	; 107
	%struct.TypeMapModuleEntry {
		i32 33554957, ; type_token_id
		i32 706; java_map_index
	}, 
	; 108
	%struct.TypeMapModuleEntry {
		i32 33554959, ; type_token_id
		i32 140; java_map_index
	}, 
	; 109
	%struct.TypeMapModuleEntry {
		i32 33554961, ; type_token_id
		i32 342; java_map_index
	}, 
	; 110
	%struct.TypeMapModuleEntry {
		i32 33554963, ; type_token_id
		i32 547; java_map_index
	}, 
	; 111
	%struct.TypeMapModuleEntry {
		i32 33554965, ; type_token_id
		i32 92; java_map_index
	}, 
	; 112
	%struct.TypeMapModuleEntry {
		i32 33554967, ; type_token_id
		i32 292; java_map_index
	}, 
	; 113
	%struct.TypeMapModuleEntry {
		i32 33554969, ; type_token_id
		i32 26; java_map_index
	}, 
	; 114
	%struct.TypeMapModuleEntry {
		i32 33554971, ; type_token_id
		i32 161; java_map_index
	}, 
	; 115
	%struct.TypeMapModuleEntry {
		i32 33554973, ; type_token_id
		i32 338; java_map_index
	}, 
	; 116
	%struct.TypeMapModuleEntry {
		i32 33554975, ; type_token_id
		i32 436; java_map_index
	}, 
	; 117
	%struct.TypeMapModuleEntry {
		i32 33554977, ; type_token_id
		i32 293; java_map_index
	}, 
	; 118
	%struct.TypeMapModuleEntry {
		i32 33554979, ; type_token_id
		i32 15; java_map_index
	}, 
	; 119
	%struct.TypeMapModuleEntry {
		i32 33554981, ; type_token_id
		i32 28; java_map_index
	}, 
	; 120
	%struct.TypeMapModuleEntry {
		i32 33554983, ; type_token_id
		i32 270; java_map_index
	}, 
	; 121
	%struct.TypeMapModuleEntry {
		i32 33554986, ; type_token_id
		i32 251; java_map_index
	}, 
	; 122
	%struct.TypeMapModuleEntry {
		i32 33554992, ; type_token_id
		i32 476; java_map_index
	}, 
	; 123
	%struct.TypeMapModuleEntry {
		i32 33554994, ; type_token_id
		i32 167; java_map_index
	}, 
	; 124
	%struct.TypeMapModuleEntry {
		i32 33555001, ; type_token_id
		i32 599; java_map_index
	}, 
	; 125
	%struct.TypeMapModuleEntry {
		i32 33555005, ; type_token_id
		i32 469; java_map_index
	}, 
	; 126
	%struct.TypeMapModuleEntry {
		i32 33555012, ; type_token_id
		i32 63; java_map_index
	}, 
	; 127
	%struct.TypeMapModuleEntry {
		i32 33555016, ; type_token_id
		i32 422; java_map_index
	}, 
	; 128
	%struct.TypeMapModuleEntry {
		i32 33555021, ; type_token_id
		i32 199; java_map_index
	}, 
	; 129
	%struct.TypeMapModuleEntry {
		i32 33555023, ; type_token_id
		i32 117; java_map_index
	}, 
	; 130
	%struct.TypeMapModuleEntry {
		i32 33555026, ; type_token_id
		i32 192; java_map_index
	}, 
	; 131
	%struct.TypeMapModuleEntry {
		i32 33555028, ; type_token_id
		i32 241; java_map_index
	}, 
	; 132
	%struct.TypeMapModuleEntry {
		i32 33555030, ; type_token_id
		i32 415; java_map_index
	}, 
	; 133
	%struct.TypeMapModuleEntry {
		i32 33555036, ; type_token_id
		i32 335; java_map_index
	}, 
	; 134
	%struct.TypeMapModuleEntry {
		i32 33555042, ; type_token_id
		i32 588; java_map_index
	}, 
	; 135
	%struct.TypeMapModuleEntry {
		i32 33555060, ; type_token_id
		i32 74; java_map_index
	}, 
	; 136
	%struct.TypeMapModuleEntry {
		i32 33555062, ; type_token_id
		i32 2; java_map_index
	}, 
	; 137
	%struct.TypeMapModuleEntry {
		i32 33555064, ; type_token_id
		i32 412; java_map_index
	}, 
	; 138
	%struct.TypeMapModuleEntry {
		i32 33555066, ; type_token_id
		i32 20; java_map_index
	}, 
	; 139
	%struct.TypeMapModuleEntry {
		i32 33555068, ; type_token_id
		i32 179; java_map_index
	}, 
	; 140
	%struct.TypeMapModuleEntry {
		i32 33555075, ; type_token_id
		i32 740; java_map_index
	}, 
	; 141
	%struct.TypeMapModuleEntry {
		i32 33555077, ; type_token_id
		i32 576; java_map_index
	}, 
	; 142
	%struct.TypeMapModuleEntry {
		i32 33555079, ; type_token_id
		i32 564; java_map_index
	}, 
	; 143
	%struct.TypeMapModuleEntry {
		i32 33555081, ; type_token_id
		i32 670; java_map_index
	}, 
	; 144
	%struct.TypeMapModuleEntry {
		i32 33555085, ; type_token_id
		i32 98; java_map_index
	}, 
	; 145
	%struct.TypeMapModuleEntry {
		i32 33555087, ; type_token_id
		i32 351; java_map_index
	}, 
	; 146
	%struct.TypeMapModuleEntry {
		i32 33555091, ; type_token_id
		i32 708; java_map_index
	}
], align 4; end of 'module7_managed_to_java_duplicates' array


; module8_managed_to_java
@module8_managed_to_java = internal constant [1 x %struct.TypeMapModuleEntry] [
	; 0
	%struct.TypeMapModuleEntry {
		i32 33554434, ; type_token_id
		i32 94; java_map_index
	}
], align 4; end of 'module8_managed_to_java' array


; module9_managed_to_java
@module9_managed_to_java = internal constant [1 x %struct.TypeMapModuleEntry] [
	; 0
	%struct.TypeMapModuleEntry {
		i32 33554434, ; type_token_id
		i32 107; java_map_index
	}
], align 4; end of 'module9_managed_to_java' array


; module10_managed_to_java
@module10_managed_to_java = internal constant [2 x %struct.TypeMapModuleEntry] [
	; 0
	%struct.TypeMapModuleEntry {
		i32 33554439, ; type_token_id
		i32 160; java_map_index
	}, 
	; 1
	%struct.TypeMapModuleEntry {
		i32 33554441, ; type_token_id
		i32 154; java_map_index
	}
], align 4; end of 'module10_managed_to_java' array


; module10_managed_to_java_duplicates
@module10_managed_to_java_duplicates = internal constant [2 x %struct.TypeMapModuleEntry] [
	; 0
	%struct.TypeMapModuleEntry {
		i32 33554440, ; type_token_id
		i32 160; java_map_index
	}, 
	; 1
	%struct.TypeMapModuleEntry {
		i32 33554442, ; type_token_id
		i32 154; java_map_index
	}
], align 4; end of 'module10_managed_to_java_duplicates' array


; module11_managed_to_java
@module11_managed_to_java = internal constant [1 x %struct.TypeMapModuleEntry] [
	; 0
	%struct.TypeMapModuleEntry {
		i32 33554436, ; type_token_id
		i32 651; java_map_index
	}
], align 4; end of 'module11_managed_to_java' array


; module11_managed_to_java_duplicates
@module11_managed_to_java_duplicates = internal constant [1 x %struct.TypeMapModuleEntry] [
	; 0
	%struct.TypeMapModuleEntry {
		i32 33554437, ; type_token_id
		i32 651; java_map_index
	}
], align 4; end of 'module11_managed_to_java_duplicates' array


; module12_managed_to_java
@module12_managed_to_java = internal constant [30 x %struct.TypeMapModuleEntry] [
	; 0
	%struct.TypeMapModuleEntry {
		i32 33554473, ; type_token_id
		i32 126; java_map_index
	}, 
	; 1
	%struct.TypeMapModuleEntry {
		i32 33554474, ; type_token_id
		i32 521; java_map_index
	}, 
	; 2
	%struct.TypeMapModuleEntry {
		i32 33554475, ; type_token_id
		i32 530; java_map_index
	}, 
	; 3
	%struct.TypeMapModuleEntry {
		i32 33554476, ; type_token_id
		i32 185; java_map_index
	}, 
	; 4
	%struct.TypeMapModuleEntry {
		i32 33554479, ; type_token_id
		i32 592; java_map_index
	}, 
	; 5
	%struct.TypeMapModuleEntry {
		i32 33554480, ; type_token_id
		i32 99; java_map_index
	}, 
	; 6
	%struct.TypeMapModuleEntry {
		i32 33554482, ; type_token_id
		i32 613; java_map_index
	}, 
	; 7
	%struct.TypeMapModuleEntry {
		i32 33554484, ; type_token_id
		i32 616; java_map_index
	}, 
	; 8
	%struct.TypeMapModuleEntry {
		i32 33554489, ; type_token_id
		i32 543; java_map_index
	}, 
	; 9
	%struct.TypeMapModuleEntry {
		i32 33554490, ; type_token_id
		i32 152; java_map_index
	}, 
	; 10
	%struct.TypeMapModuleEntry {
		i32 33554492, ; type_token_id
		i32 396; java_map_index
	}, 
	; 11
	%struct.TypeMapModuleEntry {
		i32 33554494, ; type_token_id
		i32 102; java_map_index
	}, 
	; 12
	%struct.TypeMapModuleEntry {
		i32 33554495, ; type_token_id
		i32 458; java_map_index
	}, 
	; 13
	%struct.TypeMapModuleEntry {
		i32 33554497, ; type_token_id
		i32 220; java_map_index
	}, 
	; 14
	%struct.TypeMapModuleEntry {
		i32 33554499, ; type_token_id
		i32 108; java_map_index
	}, 
	; 15
	%struct.TypeMapModuleEntry {
		i32 33554500, ; type_token_id
		i32 339; java_map_index
	}, 
	; 16
	%struct.TypeMapModuleEntry {
		i32 33554502, ; type_token_id
		i32 556; java_map_index
	}, 
	; 17
	%struct.TypeMapModuleEntry {
		i32 33554505, ; type_token_id
		i32 288; java_map_index
	}, 
	; 18
	%struct.TypeMapModuleEntry {
		i32 33554508, ; type_token_id
		i32 12; java_map_index
	}, 
	; 19
	%struct.TypeMapModuleEntry {
		i32 33554510, ; type_token_id
		i32 398; java_map_index
	}, 
	; 20
	%struct.TypeMapModuleEntry {
		i32 33554511, ; type_token_id
		i32 67; java_map_index
	}, 
	; 21
	%struct.TypeMapModuleEntry {
		i32 33554512, ; type_token_id
		i32 663; java_map_index
	}, 
	; 22
	%struct.TypeMapModuleEntry {
		i32 33554513, ; type_token_id
		i32 211; java_map_index
	}, 
	; 23
	%struct.TypeMapModuleEntry {
		i32 33554516, ; type_token_id
		i32 605; java_map_index
	}, 
	; 24
	%struct.TypeMapModuleEntry {
		i32 33554517, ; type_token_id
		i32 549; java_map_index
	}, 
	; 25
	%struct.TypeMapModuleEntry {
		i32 33554519, ; type_token_id
		i32 274; java_map_index
	}, 
	; 26
	%struct.TypeMapModuleEntry {
		i32 33554521, ; type_token_id
		i32 228; java_map_index
	}, 
	; 27
	%struct.TypeMapModuleEntry {
		i32 33554523, ; type_token_id
		i32 259; java_map_index
	}, 
	; 28
	%struct.TypeMapModuleEntry {
		i32 33554525, ; type_token_id
		i32 548; java_map_index
	}, 
	; 29
	%struct.TypeMapModuleEntry {
		i32 33554526, ; type_token_id
		i32 332; java_map_index
	}
], align 4; end of 'module12_managed_to_java' array


; module12_managed_to_java_duplicates
@module12_managed_to_java_duplicates = internal constant [17 x %struct.TypeMapModuleEntry] [
	; 0
	%struct.TypeMapModuleEntry {
		i32 33554477, ; type_token_id
		i32 185; java_map_index
	}, 
	; 1
	%struct.TypeMapModuleEntry {
		i32 33554481, ; type_token_id
		i32 99; java_map_index
	}, 
	; 2
	%struct.TypeMapModuleEntry {
		i32 33554483, ; type_token_id
		i32 613; java_map_index
	}, 
	; 3
	%struct.TypeMapModuleEntry {
		i32 33554485, ; type_token_id
		i32 616; java_map_index
	}, 
	; 4
	%struct.TypeMapModuleEntry {
		i32 33554488, ; type_token_id
		i32 521; java_map_index
	}, 
	; 5
	%struct.TypeMapModuleEntry {
		i32 33554491, ; type_token_id
		i32 152; java_map_index
	}, 
	; 6
	%struct.TypeMapModuleEntry {
		i32 33554493, ; type_token_id
		i32 396; java_map_index
	}, 
	; 7
	%struct.TypeMapModuleEntry {
		i32 33554496, ; type_token_id
		i32 458; java_map_index
	}, 
	; 8
	%struct.TypeMapModuleEntry {
		i32 33554498, ; type_token_id
		i32 220; java_map_index
	}, 
	; 9
	%struct.TypeMapModuleEntry {
		i32 33554503, ; type_token_id
		i32 556; java_map_index
	}, 
	; 10
	%struct.TypeMapModuleEntry {
		i32 33554509, ; type_token_id
		i32 12; java_map_index
	}, 
	; 11
	%struct.TypeMapModuleEntry {
		i32 33554514, ; type_token_id
		i32 211; java_map_index
	}, 
	; 12
	%struct.TypeMapModuleEntry {
		i32 33554515, ; type_token_id
		i32 663; java_map_index
	}, 
	; 13
	%struct.TypeMapModuleEntry {
		i32 33554518, ; type_token_id
		i32 549; java_map_index
	}, 
	; 14
	%struct.TypeMapModuleEntry {
		i32 33554520, ; type_token_id
		i32 274; java_map_index
	}, 
	; 15
	%struct.TypeMapModuleEntry {
		i32 33554522, ; type_token_id
		i32 228; java_map_index
	}, 
	; 16
	%struct.TypeMapModuleEntry {
		i32 33554524, ; type_token_id
		i32 259; java_map_index
	}
], align 4; end of 'module12_managed_to_java_duplicates' array


; module13_managed_to_java
@module13_managed_to_java = internal constant [369 x %struct.TypeMapModuleEntry] [
	; 0
	%struct.TypeMapModuleEntry {
		i32 33554555, ; type_token_id
		i32 562; java_map_index
	}, 
	; 1
	%struct.TypeMapModuleEntry {
		i32 33554556, ; type_token_id
		i32 307; java_map_index
	}, 
	; 2
	%struct.TypeMapModuleEntry {
		i32 33554558, ; type_token_id
		i32 532; java_map_index
	}, 
	; 3
	%struct.TypeMapModuleEntry {
		i32 33554559, ; type_token_id
		i32 47; java_map_index
	}, 
	; 4
	%struct.TypeMapModuleEntry {
		i32 33554560, ; type_token_id
		i32 130; java_map_index
	}, 
	; 5
	%struct.TypeMapModuleEntry {
		i32 33554561, ; type_token_id
		i32 111; java_map_index
	}, 
	; 6
	%struct.TypeMapModuleEntry {
		i32 33554565, ; type_token_id
		i32 203; java_map_index
	}, 
	; 7
	%struct.TypeMapModuleEntry {
		i32 33554566, ; type_token_id
		i32 578; java_map_index
	}, 
	; 8
	%struct.TypeMapModuleEntry {
		i32 33554567, ; type_token_id
		i32 301; java_map_index
	}, 
	; 9
	%struct.TypeMapModuleEntry {
		i32 33554568, ; type_token_id
		i32 23; java_map_index
	}, 
	; 10
	%struct.TypeMapModuleEntry {
		i32 33554569, ; type_token_id
		i32 223; java_map_index
	}, 
	; 11
	%struct.TypeMapModuleEntry {
		i32 33554572, ; type_token_id
		i32 323; java_map_index
	}, 
	; 12
	%struct.TypeMapModuleEntry {
		i32 33554573, ; type_token_id
		i32 266; java_map_index
	}, 
	; 13
	%struct.TypeMapModuleEntry {
		i32 33554575, ; type_token_id
		i32 233; java_map_index
	}, 
	; 14
	%struct.TypeMapModuleEntry {
		i32 33554579, ; type_token_id
		i32 87; java_map_index
	}, 
	; 15
	%struct.TypeMapModuleEntry {
		i32 33554580, ; type_token_id
		i32 575; java_map_index
	}, 
	; 16
	%struct.TypeMapModuleEntry {
		i32 33554581, ; type_token_id
		i32 446; java_map_index
	}, 
	; 17
	%struct.TypeMapModuleEntry {
		i32 33554583, ; type_token_id
		i32 636; java_map_index
	}, 
	; 18
	%struct.TypeMapModuleEntry {
		i32 33554584, ; type_token_id
		i32 116; java_map_index
	}, 
	; 19
	%struct.TypeMapModuleEntry {
		i32 33554585, ; type_token_id
		i32 718; java_map_index
	}, 
	; 20
	%struct.TypeMapModuleEntry {
		i32 33554586, ; type_token_id
		i32 194; java_map_index
	}, 
	; 21
	%struct.TypeMapModuleEntry {
		i32 33554587, ; type_token_id
		i32 45; java_map_index
	}, 
	; 22
	%struct.TypeMapModuleEntry {
		i32 33554588, ; type_token_id
		i32 686; java_map_index
	}, 
	; 23
	%struct.TypeMapModuleEntry {
		i32 33554589, ; type_token_id
		i32 741; java_map_index
	}, 
	; 24
	%struct.TypeMapModuleEntry {
		i32 33554590, ; type_token_id
		i32 404; java_map_index
	}, 
	; 25
	%struct.TypeMapModuleEntry {
		i32 33554591, ; type_token_id
		i32 682; java_map_index
	}, 
	; 26
	%struct.TypeMapModuleEntry {
		i32 33554593, ; type_token_id
		i32 399; java_map_index
	}, 
	; 27
	%struct.TypeMapModuleEntry {
		i32 33554594, ; type_token_id
		i32 138; java_map_index
	}, 
	; 28
	%struct.TypeMapModuleEntry {
		i32 33554595, ; type_token_id
		i32 27; java_map_index
	}, 
	; 29
	%struct.TypeMapModuleEntry {
		i32 33554597, ; type_token_id
		i32 177; java_map_index
	}, 
	; 30
	%struct.TypeMapModuleEntry {
		i32 33554598, ; type_token_id
		i32 253; java_map_index
	}, 
	; 31
	%struct.TypeMapModuleEntry {
		i32 33554599, ; type_token_id
		i32 310; java_map_index
	}, 
	; 32
	%struct.TypeMapModuleEntry {
		i32 33554600, ; type_token_id
		i32 64; java_map_index
	}, 
	; 33
	%struct.TypeMapModuleEntry {
		i32 33554601, ; type_token_id
		i32 687; java_map_index
	}, 
	; 34
	%struct.TypeMapModuleEntry {
		i32 33554602, ; type_token_id
		i32 88; java_map_index
	}, 
	; 35
	%struct.TypeMapModuleEntry {
		i32 33554603, ; type_token_id
		i32 417; java_map_index
	}, 
	; 36
	%struct.TypeMapModuleEntry {
		i32 33554604, ; type_token_id
		i32 238; java_map_index
	}, 
	; 37
	%struct.TypeMapModuleEntry {
		i32 33554605, ; type_token_id
		i32 390; java_map_index
	}, 
	; 38
	%struct.TypeMapModuleEntry {
		i32 33554606, ; type_token_id
		i32 460; java_map_index
	}, 
	; 39
	%struct.TypeMapModuleEntry {
		i32 33554607, ; type_token_id
		i32 439; java_map_index
	}, 
	; 40
	%struct.TypeMapModuleEntry {
		i32 33554608, ; type_token_id
		i32 249; java_map_index
	}, 
	; 41
	%struct.TypeMapModuleEntry {
		i32 33554609, ; type_token_id
		i32 444; java_map_index
	}, 
	; 42
	%struct.TypeMapModuleEntry {
		i32 33554610, ; type_token_id
		i32 566; java_map_index
	}, 
	; 43
	%struct.TypeMapModuleEntry {
		i32 33554611, ; type_token_id
		i32 306; java_map_index
	}, 
	; 44
	%struct.TypeMapModuleEntry {
		i32 33554612, ; type_token_id
		i32 712; java_map_index
	}, 
	; 45
	%struct.TypeMapModuleEntry {
		i32 33554613, ; type_token_id
		i32 13; java_map_index
	}, 
	; 46
	%struct.TypeMapModuleEntry {
		i32 33554614, ; type_token_id
		i32 609; java_map_index
	}, 
	; 47
	%struct.TypeMapModuleEntry {
		i32 33554615, ; type_token_id
		i32 640; java_map_index
	}, 
	; 48
	%struct.TypeMapModuleEntry {
		i32 33554616, ; type_token_id
		i32 132; java_map_index
	}, 
	; 49
	%struct.TypeMapModuleEntry {
		i32 33554617, ; type_token_id
		i32 324; java_map_index
	}, 
	; 50
	%struct.TypeMapModuleEntry {
		i32 33554618, ; type_token_id
		i32 276; java_map_index
	}, 
	; 51
	%struct.TypeMapModuleEntry {
		i32 33554619, ; type_token_id
		i32 690; java_map_index
	}, 
	; 52
	%struct.TypeMapModuleEntry {
		i32 33554620, ; type_token_id
		i32 10; java_map_index
	}, 
	; 53
	%struct.TypeMapModuleEntry {
		i32 33554621, ; type_token_id
		i32 664; java_map_index
	}, 
	; 54
	%struct.TypeMapModuleEntry {
		i32 33554623, ; type_token_id
		i32 598; java_map_index
	}, 
	; 55
	%struct.TypeMapModuleEntry {
		i32 33554624, ; type_token_id
		i32 141; java_map_index
	}, 
	; 56
	%struct.TypeMapModuleEntry {
		i32 33554626, ; type_token_id
		i32 512; java_map_index
	}, 
	; 57
	%struct.TypeMapModuleEntry {
		i32 33554627, ; type_token_id
		i32 201; java_map_index
	}, 
	; 58
	%struct.TypeMapModuleEntry {
		i32 33554628, ; type_token_id
		i32 620; java_map_index
	}, 
	; 59
	%struct.TypeMapModuleEntry {
		i32 33554629, ; type_token_id
		i32 40; java_map_index
	}, 
	; 60
	%struct.TypeMapModuleEntry {
		i32 33554630, ; type_token_id
		i32 461; java_map_index
	}, 
	; 61
	%struct.TypeMapModuleEntry {
		i32 33554631, ; type_token_id
		i32 697; java_map_index
	}, 
	; 62
	%struct.TypeMapModuleEntry {
		i32 33554632, ; type_token_id
		i32 518; java_map_index
	}, 
	; 63
	%struct.TypeMapModuleEntry {
		i32 33554633, ; type_token_id
		i32 80; java_map_index
	}, 
	; 64
	%struct.TypeMapModuleEntry {
		i32 33554634, ; type_token_id
		i32 406; java_map_index
	}, 
	; 65
	%struct.TypeMapModuleEntry {
		i32 33554635, ; type_token_id
		i32 300; java_map_index
	}, 
	; 66
	%struct.TypeMapModuleEntry {
		i32 33554636, ; type_token_id
		i32 182; java_map_index
	}, 
	; 67
	%struct.TypeMapModuleEntry {
		i32 33554637, ; type_token_id
		i32 226; java_map_index
	}, 
	; 68
	%struct.TypeMapModuleEntry {
		i32 33554638, ; type_token_id
		i32 519; java_map_index
	}, 
	; 69
	%struct.TypeMapModuleEntry {
		i32 33554639, ; type_token_id
		i32 89; java_map_index
	}, 
	; 70
	%struct.TypeMapModuleEntry {
		i32 33554640, ; type_token_id
		i32 488; java_map_index
	}, 
	; 71
	%struct.TypeMapModuleEntry {
		i32 33554641, ; type_token_id
		i32 602; java_map_index
	}, 
	; 72
	%struct.TypeMapModuleEntry {
		i32 33554642, ; type_token_id
		i32 416; java_map_index
	}, 
	; 73
	%struct.TypeMapModuleEntry {
		i32 33554643, ; type_token_id
		i32 120; java_map_index
	}, 
	; 74
	%struct.TypeMapModuleEntry {
		i32 33554644, ; type_token_id
		i32 127; java_map_index
	}, 
	; 75
	%struct.TypeMapModuleEntry {
		i32 33554645, ; type_token_id
		i32 421; java_map_index
	}, 
	; 76
	%struct.TypeMapModuleEntry {
		i32 33554648, ; type_token_id
		i32 465; java_map_index
	}, 
	; 77
	%struct.TypeMapModuleEntry {
		i32 33554651, ; type_token_id
		i32 383; java_map_index
	}, 
	; 78
	%struct.TypeMapModuleEntry {
		i32 33554652, ; type_token_id
		i32 628; java_map_index
	}, 
	; 79
	%struct.TypeMapModuleEntry {
		i32 33554653, ; type_token_id
		i32 32; java_map_index
	}, 
	; 80
	%struct.TypeMapModuleEntry {
		i32 33554654, ; type_token_id
		i32 271; java_map_index
	}, 
	; 81
	%struct.TypeMapModuleEntry {
		i32 33554655, ; type_token_id
		i32 692; java_map_index
	}, 
	; 82
	%struct.TypeMapModuleEntry {
		i32 33554656, ; type_token_id
		i32 437; java_map_index
	}, 
	; 83
	%struct.TypeMapModuleEntry {
		i32 33554657, ; type_token_id
		i32 29; java_map_index
	}, 
	; 84
	%struct.TypeMapModuleEntry {
		i32 33554658, ; type_token_id
		i32 631; java_map_index
	}, 
	; 85
	%struct.TypeMapModuleEntry {
		i32 33554659, ; type_token_id
		i32 172; java_map_index
	}, 
	; 86
	%struct.TypeMapModuleEntry {
		i32 33554660, ; type_token_id
		i32 304; java_map_index
	}, 
	; 87
	%struct.TypeMapModuleEntry {
		i32 33554665, ; type_token_id
		i32 491; java_map_index
	}, 
	; 88
	%struct.TypeMapModuleEntry {
		i32 33554666, ; type_token_id
		i32 471; java_map_index
	}, 
	; 89
	%struct.TypeMapModuleEntry {
		i32 33554667, ; type_token_id
		i32 391; java_map_index
	}, 
	; 90
	%struct.TypeMapModuleEntry {
		i32 33554672, ; type_token_id
		i32 144; java_map_index
	}, 
	; 91
	%struct.TypeMapModuleEntry {
		i32 33554673, ; type_token_id
		i32 263; java_map_index
	}, 
	; 92
	%struct.TypeMapModuleEntry {
		i32 33554674, ; type_token_id
		i32 561; java_map_index
	}, 
	; 93
	%struct.TypeMapModuleEntry {
		i32 33554675, ; type_token_id
		i32 617; java_map_index
	}, 
	; 94
	%struct.TypeMapModuleEntry {
		i32 33554676, ; type_token_id
		i32 688; java_map_index
	}, 
	; 95
	%struct.TypeMapModuleEntry {
		i32 33554680, ; type_token_id
		i32 146; java_map_index
	}, 
	; 96
	%struct.TypeMapModuleEntry {
		i32 33554681, ; type_token_id
		i32 513; java_map_index
	}, 
	; 97
	%struct.TypeMapModuleEntry {
		i32 33554682, ; type_token_id
		i32 710; java_map_index
	}, 
	; 98
	%struct.TypeMapModuleEntry {
		i32 33554683, ; type_token_id
		i32 86; java_map_index
	}, 
	; 99
	%struct.TypeMapModuleEntry {
		i32 33554684, ; type_token_id
		i32 593; java_map_index
	}, 
	; 100
	%struct.TypeMapModuleEntry {
		i32 33554685, ; type_token_id
		i32 726; java_map_index
	}, 
	; 101
	%struct.TypeMapModuleEntry {
		i32 33554686, ; type_token_id
		i32 202; java_map_index
	}, 
	; 102
	%struct.TypeMapModuleEntry {
		i32 33554689, ; type_token_id
		i32 264; java_map_index
	}, 
	; 103
	%struct.TypeMapModuleEntry {
		i32 33554690, ; type_token_id
		i32 215; java_map_index
	}, 
	; 104
	%struct.TypeMapModuleEntry {
		i32 33554691, ; type_token_id
		i32 113; java_map_index
	}, 
	; 105
	%struct.TypeMapModuleEntry {
		i32 33554692, ; type_token_id
		i32 601; java_map_index
	}, 
	; 106
	%struct.TypeMapModuleEntry {
		i32 33554693, ; type_token_id
		i32 643; java_map_index
	}, 
	; 107
	%struct.TypeMapModuleEntry {
		i32 33554695, ; type_token_id
		i32 701; java_map_index
	}, 
	; 108
	%struct.TypeMapModuleEntry {
		i32 33554696, ; type_token_id
		i32 612; java_map_index
	}, 
	; 109
	%struct.TypeMapModuleEntry {
		i32 33554700, ; type_token_id
		i32 587; java_map_index
	}, 
	; 110
	%struct.TypeMapModuleEntry {
		i32 33554701, ; type_token_id
		i32 435; java_map_index
	}, 
	; 111
	%struct.TypeMapModuleEntry {
		i32 33554702, ; type_token_id
		i32 237; java_map_index
	}, 
	; 112
	%struct.TypeMapModuleEntry {
		i32 33554703, ; type_token_id
		i32 579; java_map_index
	}, 
	; 113
	%struct.TypeMapModuleEntry {
		i32 33554704, ; type_token_id
		i32 716; java_map_index
	}, 
	; 114
	%struct.TypeMapModuleEntry {
		i32 33554705, ; type_token_id
		i32 209; java_map_index
	}, 
	; 115
	%struct.TypeMapModuleEntry {
		i32 33554706, ; type_token_id
		i32 678; java_map_index
	}, 
	; 116
	%struct.TypeMapModuleEntry {
		i32 33554707, ; type_token_id
		i32 30; java_map_index
	}, 
	; 117
	%struct.TypeMapModuleEntry {
		i32 33554708, ; type_token_id
		i32 217; java_map_index
	}, 
	; 118
	%struct.TypeMapModuleEntry {
		i32 33554710, ; type_token_id
		i32 494; java_map_index
	}, 
	; 119
	%struct.TypeMapModuleEntry {
		i32 33554712, ; type_token_id
		i32 277; java_map_index
	}, 
	; 120
	%struct.TypeMapModuleEntry {
		i32 33554714, ; type_token_id
		i32 4; java_map_index
	}, 
	; 121
	%struct.TypeMapModuleEntry {
		i32 33554716, ; type_token_id
		i32 364; java_map_index
	}, 
	; 122
	%struct.TypeMapModuleEntry {
		i32 33554718, ; type_token_id
		i32 22; java_map_index
	}, 
	; 123
	%struct.TypeMapModuleEntry {
		i32 33554719, ; type_token_id
		i32 379; java_map_index
	}, 
	; 124
	%struct.TypeMapModuleEntry {
		i32 33554720, ; type_token_id
		i32 97; java_map_index
	}, 
	; 125
	%struct.TypeMapModuleEntry {
		i32 33554721, ; type_token_id
		i32 375; java_map_index
	}, 
	; 126
	%struct.TypeMapModuleEntry {
		i32 33554722, ; type_token_id
		i32 456; java_map_index
	}, 
	; 127
	%struct.TypeMapModuleEntry {
		i32 33554724, ; type_token_id
		i32 604; java_map_index
	}, 
	; 128
	%struct.TypeMapModuleEntry {
		i32 33554726, ; type_token_id
		i32 212; java_map_index
	}, 
	; 129
	%struct.TypeMapModuleEntry {
		i32 33554727, ; type_token_id
		i32 158; java_map_index
	}, 
	; 130
	%struct.TypeMapModuleEntry {
		i32 33554728, ; type_token_id
		i32 473; java_map_index
	}, 
	; 131
	%struct.TypeMapModuleEntry {
		i32 33554729, ; type_token_id
		i32 329; java_map_index
	}, 
	; 132
	%struct.TypeMapModuleEntry {
		i32 33554730, ; type_token_id
		i32 683; java_map_index
	}, 
	; 133
	%struct.TypeMapModuleEntry {
		i32 33554731, ; type_token_id
		i32 508; java_map_index
	}, 
	; 134
	%struct.TypeMapModuleEntry {
		i32 33554733, ; type_token_id
		i32 414; java_map_index
	}, 
	; 135
	%struct.TypeMapModuleEntry {
		i32 33554734, ; type_token_id
		i32 205; java_map_index
	}, 
	; 136
	%struct.TypeMapModuleEntry {
		i32 33554735, ; type_token_id
		i32 337; java_map_index
	}, 
	; 137
	%struct.TypeMapModuleEntry {
		i32 33554737, ; type_token_id
		i32 567; java_map_index
	}, 
	; 138
	%struct.TypeMapModuleEntry {
		i32 33554738, ; type_token_id
		i32 319; java_map_index
	}, 
	; 139
	%struct.TypeMapModuleEntry {
		i32 33554739, ; type_token_id
		i32 596; java_map_index
	}, 
	; 140
	%struct.TypeMapModuleEntry {
		i32 33554740, ; type_token_id
		i32 542; java_map_index
	}, 
	; 141
	%struct.TypeMapModuleEntry {
		i32 33554741, ; type_token_id
		i32 520; java_map_index
	}, 
	; 142
	%struct.TypeMapModuleEntry {
		i32 33554742, ; type_token_id
		i32 189; java_map_index
	}, 
	; 143
	%struct.TypeMapModuleEntry {
		i32 33554743, ; type_token_id
		i32 83; java_map_index
	}, 
	; 144
	%struct.TypeMapModuleEntry {
		i32 33554744, ; type_token_id
		i32 594; java_map_index
	}, 
	; 145
	%struct.TypeMapModuleEntry {
		i32 33554745, ; type_token_id
		i32 563; java_map_index
	}, 
	; 146
	%struct.TypeMapModuleEntry {
		i32 33554746, ; type_token_id
		i32 174; java_map_index
	}, 
	; 147
	%struct.TypeMapModuleEntry {
		i32 33554747, ; type_token_id
		i32 193; java_map_index
	}, 
	; 148
	%struct.TypeMapModuleEntry {
		i32 33554748, ; type_token_id
		i32 506; java_map_index
	}, 
	; 149
	%struct.TypeMapModuleEntry {
		i32 33554750, ; type_token_id
		i32 560; java_map_index
	}, 
	; 150
	%struct.TypeMapModuleEntry {
		i32 33554752, ; type_token_id
		i32 171; java_map_index
	}, 
	; 151
	%struct.TypeMapModuleEntry {
		i32 33554753, ; type_token_id
		i32 135; java_map_index
	}, 
	; 152
	%struct.TypeMapModuleEntry {
		i32 33554754, ; type_token_id
		i32 374; java_map_index
	}, 
	; 153
	%struct.TypeMapModuleEntry {
		i32 33554755, ; type_token_id
		i32 242; java_map_index
	}, 
	; 154
	%struct.TypeMapModuleEntry {
		i32 33554756, ; type_token_id
		i32 516; java_map_index
	}, 
	; 155
	%struct.TypeMapModuleEntry {
		i32 33554757, ; type_token_id
		i32 434; java_map_index
	}, 
	; 156
	%struct.TypeMapModuleEntry {
		i32 33554758, ; type_token_id
		i32 534; java_map_index
	}, 
	; 157
	%struct.TypeMapModuleEntry {
		i32 33554759, ; type_token_id
		i32 475; java_map_index
	}, 
	; 158
	%struct.TypeMapModuleEntry {
		i32 33554760, ; type_token_id
		i32 269; java_map_index
	}, 
	; 159
	%struct.TypeMapModuleEntry {
		i32 33554761, ; type_token_id
		i32 239; java_map_index
	}, 
	; 160
	%struct.TypeMapModuleEntry {
		i32 33554762, ; type_token_id
		i32 115; java_map_index
	}, 
	; 161
	%struct.TypeMapModuleEntry {
		i32 33554763, ; type_token_id
		i32 360; java_map_index
	}, 
	; 162
	%struct.TypeMapModuleEntry {
		i32 33554764, ; type_token_id
		i32 388; java_map_index
	}, 
	; 163
	%struct.TypeMapModuleEntry {
		i32 33554765, ; type_token_id
		i32 69; java_map_index
	}, 
	; 164
	%struct.TypeMapModuleEntry {
		i32 33554766, ; type_token_id
		i32 376; java_map_index
	}, 
	; 165
	%struct.TypeMapModuleEntry {
		i32 33554767, ; type_token_id
		i32 452; java_map_index
	}, 
	; 166
	%struct.TypeMapModuleEntry {
		i32 33554768, ; type_token_id
		i32 652; java_map_index
	}, 
	; 167
	%struct.TypeMapModuleEntry {
		i32 33554769, ; type_token_id
		i32 260; java_map_index
	}, 
	; 168
	%struct.TypeMapModuleEntry {
		i32 33554770, ; type_token_id
		i32 394; java_map_index
	}, 
	; 169
	%struct.TypeMapModuleEntry {
		i32 33554771, ; type_token_id
		i32 348; java_map_index
	}, 
	; 170
	%struct.TypeMapModuleEntry {
		i32 33554772, ; type_token_id
		i32 246; java_map_index
	}, 
	; 171
	%struct.TypeMapModuleEntry {
		i32 33554773, ; type_token_id
		i32 287; java_map_index
	}, 
	; 172
	%struct.TypeMapModuleEntry {
		i32 33554774, ; type_token_id
		i32 110; java_map_index
	}, 
	; 173
	%struct.TypeMapModuleEntry {
		i32 33554775, ; type_token_id
		i32 262; java_map_index
	}, 
	; 174
	%struct.TypeMapModuleEntry {
		i32 33554776, ; type_token_id
		i32 431; java_map_index
	}, 
	; 175
	%struct.TypeMapModuleEntry {
		i32 33554777, ; type_token_id
		i32 659; java_map_index
	}, 
	; 176
	%struct.TypeMapModuleEntry {
		i32 33554778, ; type_token_id
		i32 537; java_map_index
	}, 
	; 177
	%struct.TypeMapModuleEntry {
		i32 33554779, ; type_token_id
		i32 477; java_map_index
	}, 
	; 178
	%struct.TypeMapModuleEntry {
		i32 33554780, ; type_token_id
		i32 50; java_map_index
	}, 
	; 179
	%struct.TypeMapModuleEntry {
		i32 33554781, ; type_token_id
		i32 485; java_map_index
	}, 
	; 180
	%struct.TypeMapModuleEntry {
		i32 33554782, ; type_token_id
		i32 448; java_map_index
	}, 
	; 181
	%struct.TypeMapModuleEntry {
		i32 33554783, ; type_token_id
		i32 654; java_map_index
	}, 
	; 182
	%struct.TypeMapModuleEntry {
		i32 33554784, ; type_token_id
		i32 257; java_map_index
	}, 
	; 183
	%struct.TypeMapModuleEntry {
		i32 33554785, ; type_token_id
		i32 346; java_map_index
	}, 
	; 184
	%struct.TypeMapModuleEntry {
		i32 33554786, ; type_token_id
		i32 451; java_map_index
	}, 
	; 185
	%struct.TypeMapModuleEntry {
		i32 33554787, ; type_token_id
		i32 486; java_map_index
	}, 
	; 186
	%struct.TypeMapModuleEntry {
		i32 33554788, ; type_token_id
		i32 280; java_map_index
	}, 
	; 187
	%struct.TypeMapModuleEntry {
		i32 33554789, ; type_token_id
		i32 405; java_map_index
	}, 
	; 188
	%struct.TypeMapModuleEntry {
		i32 33554790, ; type_token_id
		i32 433; java_map_index
	}, 
	; 189
	%struct.TypeMapModuleEntry {
		i32 33554791, ; type_token_id
		i32 482; java_map_index
	}, 
	; 190
	%struct.TypeMapModuleEntry {
		i32 33554792, ; type_token_id
		i32 352; java_map_index
	}, 
	; 191
	%struct.TypeMapModuleEntry {
		i32 33554793, ; type_token_id
		i32 496; java_map_index
	}, 
	; 192
	%struct.TypeMapModuleEntry {
		i32 33554794, ; type_token_id
		i32 625; java_map_index
	}, 
	; 193
	%struct.TypeMapModuleEntry {
		i32 33554795, ; type_token_id
		i32 527; java_map_index
	}, 
	; 194
	%struct.TypeMapModuleEntry {
		i32 33554796, ; type_token_id
		i32 183; java_map_index
	}, 
	; 195
	%struct.TypeMapModuleEntry {
		i32 33554801, ; type_token_id
		i32 247; java_map_index
	}, 
	; 196
	%struct.TypeMapModuleEntry {
		i32 33554805, ; type_token_id
		i32 441; java_map_index
	}, 
	; 197
	%struct.TypeMapModuleEntry {
		i32 33554809, ; type_token_id
		i32 382; java_map_index
	}, 
	; 198
	%struct.TypeMapModuleEntry {
		i32 33554810, ; type_token_id
		i32 642; java_map_index
	}, 
	; 199
	%struct.TypeMapModuleEntry {
		i32 33554811, ; type_token_id
		i32 272; java_map_index
	}, 
	; 200
	%struct.TypeMapModuleEntry {
		i32 33554812, ; type_token_id
		i32 216; java_map_index
	}, 
	; 201
	%struct.TypeMapModuleEntry {
		i32 33554814, ; type_token_id
		i32 186; java_map_index
	}, 
	; 202
	%struct.TypeMapModuleEntry {
		i32 33554815, ; type_token_id
		i32 533; java_map_index
	}, 
	; 203
	%struct.TypeMapModuleEntry {
		i32 33554817, ; type_token_id
		i32 627; java_map_index
	}, 
	; 204
	%struct.TypeMapModuleEntry {
		i32 33554819, ; type_token_id
		i32 278; java_map_index
	}, 
	; 205
	%struct.TypeMapModuleEntry {
		i32 33554820, ; type_token_id
		i32 546; java_map_index
	}, 
	; 206
	%struct.TypeMapModuleEntry {
		i32 33554821, ; type_token_id
		i32 479; java_map_index
	}, 
	; 207
	%struct.TypeMapModuleEntry {
		i32 33554822, ; type_token_id
		i32 60; java_map_index
	}, 
	; 208
	%struct.TypeMapModuleEntry {
		i32 33554823, ; type_token_id
		i32 653; java_map_index
	}, 
	; 209
	%struct.TypeMapModuleEntry {
		i32 33554825, ; type_token_id
		i32 408; java_map_index
	}, 
	; 210
	%struct.TypeMapModuleEntry {
		i32 33554826, ; type_token_id
		i32 495; java_map_index
	}, 
	; 211
	%struct.TypeMapModuleEntry {
		i32 33554827, ; type_token_id
		i32 70; java_map_index
	}, 
	; 212
	%struct.TypeMapModuleEntry {
		i32 33554828, ; type_token_id
		i32 285; java_map_index
	}, 
	; 213
	%struct.TypeMapModuleEntry {
		i32 33554829, ; type_token_id
		i32 646; java_map_index
	}, 
	; 214
	%struct.TypeMapModuleEntry {
		i32 33554830, ; type_token_id
		i32 524; java_map_index
	}, 
	; 215
	%struct.TypeMapModuleEntry {
		i32 33554831, ; type_token_id
		i32 227; java_map_index
	}, 
	; 216
	%struct.TypeMapModuleEntry {
		i32 33554832, ; type_token_id
		i32 698; java_map_index
	}, 
	; 217
	%struct.TypeMapModuleEntry {
		i32 33554833, ; type_token_id
		i32 569; java_map_index
	}, 
	; 218
	%struct.TypeMapModuleEntry {
		i32 33554834, ; type_token_id
		i32 490; java_map_index
	}, 
	; 219
	%struct.TypeMapModuleEntry {
		i32 33554835, ; type_token_id
		i32 729; java_map_index
	}, 
	; 220
	%struct.TypeMapModuleEntry {
		i32 33554836, ; type_token_id
		i32 51; java_map_index
	}, 
	; 221
	%struct.TypeMapModuleEntry {
		i32 33554837, ; type_token_id
		i32 597; java_map_index
	}, 
	; 222
	%struct.TypeMapModuleEntry {
		i32 33554838, ; type_token_id
		i32 572; java_map_index
	}, 
	; 223
	%struct.TypeMapModuleEntry {
		i32 33554839, ; type_token_id
		i32 157; java_map_index
	}, 
	; 224
	%struct.TypeMapModuleEntry {
		i32 33554840, ; type_token_id
		i32 334; java_map_index
	}, 
	; 225
	%struct.TypeMapModuleEntry {
		i32 33554841, ; type_token_id
		i32 207; java_map_index
	}, 
	; 226
	%struct.TypeMapModuleEntry {
		i32 33554842, ; type_token_id
		i32 411; java_map_index
	}, 
	; 227
	%struct.TypeMapModuleEntry {
		i32 33554843, ; type_token_id
		i32 641; java_map_index
	}, 
	; 228
	%struct.TypeMapModuleEntry {
		i32 33554844, ; type_token_id
		i32 685; java_map_index
	}, 
	; 229
	%struct.TypeMapModuleEntry {
		i32 33554845, ; type_token_id
		i32 258; java_map_index
	}, 
	; 230
	%struct.TypeMapModuleEntry {
		i32 33554846, ; type_token_id
		i32 104; java_map_index
	}, 
	; 231
	%struct.TypeMapModuleEntry {
		i32 33554847, ; type_token_id
		i32 302; java_map_index
	}, 
	; 232
	%struct.TypeMapModuleEntry {
		i32 33554848, ; type_token_id
		i32 148; java_map_index
	}, 
	; 233
	%struct.TypeMapModuleEntry {
		i32 33554849, ; type_token_id
		i32 91; java_map_index
	}, 
	; 234
	%struct.TypeMapModuleEntry {
		i32 33554850, ; type_token_id
		i32 667; java_map_index
	}, 
	; 235
	%struct.TypeMapModuleEntry {
		i32 33554851, ; type_token_id
		i32 124; java_map_index
	}, 
	; 236
	%struct.TypeMapModuleEntry {
		i32 33554852, ; type_token_id
		i32 638; java_map_index
	}, 
	; 237
	%struct.TypeMapModuleEntry {
		i32 33554853, ; type_token_id
		i32 31; java_map_index
	}, 
	; 238
	%struct.TypeMapModuleEntry {
		i32 33554854, ; type_token_id
		i32 291; java_map_index
	}, 
	; 239
	%struct.TypeMapModuleEntry {
		i32 33554855, ; type_token_id
		i32 236; java_map_index
	}, 
	; 240
	%struct.TypeMapModuleEntry {
		i32 33554856, ; type_token_id
		i32 742; java_map_index
	}, 
	; 241
	%struct.TypeMapModuleEntry {
		i32 33554857, ; type_token_id
		i32 483; java_map_index
	}, 
	; 242
	%struct.TypeMapModuleEntry {
		i32 33554858, ; type_token_id
		i32 700; java_map_index
	}, 
	; 243
	%struct.TypeMapModuleEntry {
		i32 33554859, ; type_token_id
		i32 732; java_map_index
	}, 
	; 244
	%struct.TypeMapModuleEntry {
		i32 33554860, ; type_token_id
		i32 739; java_map_index
	}, 
	; 245
	%struct.TypeMapModuleEntry {
		i32 33554861, ; type_token_id
		i32 632; java_map_index
	}, 
	; 246
	%struct.TypeMapModuleEntry {
		i32 33554862, ; type_token_id
		i32 84; java_map_index
	}, 
	; 247
	%struct.TypeMapModuleEntry {
		i32 33554863, ; type_token_id
		i32 574; java_map_index
	}, 
	; 248
	%struct.TypeMapModuleEntry {
		i32 33554864, ; type_token_id
		i32 245; java_map_index
	}, 
	; 249
	%struct.TypeMapModuleEntry {
		i32 33554865, ; type_token_id
		i32 568; java_map_index
	}, 
	; 250
	%struct.TypeMapModuleEntry {
		i32 33554866, ; type_token_id
		i32 353; java_map_index
	}, 
	; 251
	%struct.TypeMapModuleEntry {
		i32 33554867, ; type_token_id
		i32 9; java_map_index
	}, 
	; 252
	%struct.TypeMapModuleEntry {
		i32 33554868, ; type_token_id
		i32 90; java_map_index
	}, 
	; 253
	%struct.TypeMapModuleEntry {
		i32 33554869, ; type_token_id
		i32 618; java_map_index
	}, 
	; 254
	%struct.TypeMapModuleEntry {
		i32 33554870, ; type_token_id
		i32 244; java_map_index
	}, 
	; 255
	%struct.TypeMapModuleEntry {
		i32 33554871, ; type_token_id
		i32 55; java_map_index
	}, 
	; 256
	%struct.TypeMapModuleEntry {
		i32 33554872, ; type_token_id
		i32 46; java_map_index
	}, 
	; 257
	%struct.TypeMapModuleEntry {
		i32 33554873, ; type_token_id
		i32 600; java_map_index
	}, 
	; 258
	%struct.TypeMapModuleEntry {
		i32 33554874, ; type_token_id
		i32 331; java_map_index
	}, 
	; 259
	%struct.TypeMapModuleEntry {
		i32 33554875, ; type_token_id
		i32 229; java_map_index
	}, 
	; 260
	%struct.TypeMapModuleEntry {
		i32 33554876, ; type_token_id
		i32 410; java_map_index
	}, 
	; 261
	%struct.TypeMapModuleEntry {
		i32 33554877, ; type_token_id
		i32 65; java_map_index
	}, 
	; 262
	%struct.TypeMapModuleEntry {
		i32 33554878, ; type_token_id
		i32 550; java_map_index
	}, 
	; 263
	%struct.TypeMapModuleEntry {
		i32 33554879, ; type_token_id
		i32 621; java_map_index
	}, 
	; 264
	%struct.TypeMapModuleEntry {
		i32 33554880, ; type_token_id
		i32 328; java_map_index
	}, 
	; 265
	%struct.TypeMapModuleEntry {
		i32 33554881, ; type_token_id
		i32 11; java_map_index
	}, 
	; 266
	%struct.TypeMapModuleEntry {
		i32 33554882, ; type_token_id
		i32 5; java_map_index
	}, 
	; 267
	%struct.TypeMapModuleEntry {
		i32 33554883, ; type_token_id
		i32 539; java_map_index
	}, 
	; 268
	%struct.TypeMapModuleEntry {
		i32 33554884, ; type_token_id
		i32 644; java_map_index
	}, 
	; 269
	%struct.TypeMapModuleEntry {
		i32 33554885, ; type_token_id
		i32 281; java_map_index
	}, 
	; 270
	%struct.TypeMapModuleEntry {
		i32 33554886, ; type_token_id
		i32 466; java_map_index
	}, 
	; 271
	%struct.TypeMapModuleEntry {
		i32 33554887, ; type_token_id
		i32 208; java_map_index
	}, 
	; 272
	%struct.TypeMapModuleEntry {
		i32 33554888, ; type_token_id
		i32 492; java_map_index
	}, 
	; 273
	%struct.TypeMapModuleEntry {
		i32 33554889, ; type_token_id
		i32 541; java_map_index
	}, 
	; 274
	%struct.TypeMapModuleEntry {
		i32 33554890, ; type_token_id
		i32 424; java_map_index
	}, 
	; 275
	%struct.TypeMapModuleEntry {
		i32 33554891, ; type_token_id
		i32 200; java_map_index
	}, 
	; 276
	%struct.TypeMapModuleEntry {
		i32 33554892, ; type_token_id
		i32 552; java_map_index
	}, 
	; 277
	%struct.TypeMapModuleEntry {
		i32 33554893, ; type_token_id
		i32 248; java_map_index
	}, 
	; 278
	%struct.TypeMapModuleEntry {
		i32 33554894, ; type_token_id
		i32 418; java_map_index
	}, 
	; 279
	%struct.TypeMapModuleEntry {
		i32 33554895, ; type_token_id
		i32 723; java_map_index
	}, 
	; 280
	%struct.TypeMapModuleEntry {
		i32 33554896, ; type_token_id
		i32 671; java_map_index
	}, 
	; 281
	%struct.TypeMapModuleEntry {
		i32 33554897, ; type_token_id
		i32 53; java_map_index
	}, 
	; 282
	%struct.TypeMapModuleEntry {
		i32 33554898, ; type_token_id
		i32 282; java_map_index
	}, 
	; 283
	%struct.TypeMapModuleEntry {
		i32 33554899, ; type_token_id
		i32 679; java_map_index
	}, 
	; 284
	%struct.TypeMapModuleEntry {
		i32 33554900, ; type_token_id
		i32 77; java_map_index
	}, 
	; 285
	%struct.TypeMapModuleEntry {
		i32 33554901, ; type_token_id
		i32 662; java_map_index
	}, 
	; 286
	%struct.TypeMapModuleEntry {
		i32 33554902, ; type_token_id
		i32 655; java_map_index
	}, 
	; 287
	%struct.TypeMapModuleEntry {
		i32 33554903, ; type_token_id
		i32 191; java_map_index
	}, 
	; 288
	%struct.TypeMapModuleEntry {
		i32 33554904, ; type_token_id
		i32 39; java_map_index
	}, 
	; 289
	%struct.TypeMapModuleEntry {
		i32 33554905, ; type_token_id
		i32 500; java_map_index
	}, 
	; 290
	%struct.TypeMapModuleEntry {
		i32 33554906, ; type_token_id
		i32 658; java_map_index
	}, 
	; 291
	%struct.TypeMapModuleEntry {
		i32 33554907, ; type_token_id
		i32 361; java_map_index
	}, 
	; 292
	%struct.TypeMapModuleEntry {
		i32 33554908, ; type_token_id
		i32 401; java_map_index
	}, 
	; 293
	%struct.TypeMapModuleEntry {
		i32 33554909, ; type_token_id
		i32 419; java_map_index
	}, 
	; 294
	%struct.TypeMapModuleEntry {
		i32 33554910, ; type_token_id
		i32 308; java_map_index
	}, 
	; 295
	%struct.TypeMapModuleEntry {
		i32 33554911, ; type_token_id
		i32 131; java_map_index
	}, 
	; 296
	%struct.TypeMapModuleEntry {
		i32 33554912, ; type_token_id
		i32 198; java_map_index
	}, 
	; 297
	%struct.TypeMapModuleEntry {
		i32 33554913, ; type_token_id
		i32 345; java_map_index
	}, 
	; 298
	%struct.TypeMapModuleEntry {
		i32 33554914, ; type_token_id
		i32 370; java_map_index
	}, 
	; 299
	%struct.TypeMapModuleEntry {
		i32 33554915, ; type_token_id
		i32 7; java_map_index
	}, 
	; 300
	%struct.TypeMapModuleEntry {
		i32 33554916, ; type_token_id
		i32 536; java_map_index
	}, 
	; 301
	%struct.TypeMapModuleEntry {
		i32 33554917, ; type_token_id
		i32 474; java_map_index
	}, 
	; 302
	%struct.TypeMapModuleEntry {
		i32 33554918, ; type_token_id
		i32 350; java_map_index
	}, 
	; 303
	%struct.TypeMapModuleEntry {
		i32 33554919, ; type_token_id
		i32 76; java_map_index
	}, 
	; 304
	%struct.TypeMapModuleEntry {
		i32 33554920, ; type_token_id
		i32 577; java_map_index
	}, 
	; 305
	%struct.TypeMapModuleEntry {
		i32 33554921, ; type_token_id
		i32 660; java_map_index
	}, 
	; 306
	%struct.TypeMapModuleEntry {
		i32 33554922, ; type_token_id
		i32 178; java_map_index
	}, 
	; 307
	%struct.TypeMapModuleEntry {
		i32 33554923, ; type_token_id
		i32 392; java_map_index
	}, 
	; 308
	%struct.TypeMapModuleEntry {
		i32 33554924, ; type_token_id
		i32 72; java_map_index
	}, 
	; 309
	%struct.TypeMapModuleEntry {
		i32 33554925, ; type_token_id
		i32 480; java_map_index
	}, 
	; 310
	%struct.TypeMapModuleEntry {
		i32 33554926, ; type_token_id
		i32 206; java_map_index
	}, 
	; 311
	%struct.TypeMapModuleEntry {
		i32 33554927, ; type_token_id
		i32 614; java_map_index
	}, 
	; 312
	%struct.TypeMapModuleEntry {
		i32 33554928, ; type_token_id
		i32 347; java_map_index
	}, 
	; 313
	%struct.TypeMapModuleEntry {
		i32 33554929, ; type_token_id
		i32 522; java_map_index
	}, 
	; 314
	%struct.TypeMapModuleEntry {
		i32 33554930, ; type_token_id
		i32 175; java_map_index
	}, 
	; 315
	%struct.TypeMapModuleEntry {
		i32 33554931, ; type_token_id
		i32 311; java_map_index
	}, 
	; 316
	%struct.TypeMapModuleEntry {
		i32 33554932, ; type_token_id
		i32 254; java_map_index
	}, 
	; 317
	%struct.TypeMapModuleEntry {
		i32 33554933, ; type_token_id
		i32 611; java_map_index
	}, 
	; 318
	%struct.TypeMapModuleEntry {
		i32 33554934, ; type_token_id
		i32 595; java_map_index
	}, 
	; 319
	%struct.TypeMapModuleEntry {
		i32 33554935, ; type_token_id
		i32 727; java_map_index
	}, 
	; 320
	%struct.TypeMapModuleEntry {
		i32 33554936, ; type_token_id
		i32 143; java_map_index
	}, 
	; 321
	%struct.TypeMapModuleEntry {
		i32 33554937, ; type_token_id
		i32 525; java_map_index
	}, 
	; 322
	%struct.TypeMapModuleEntry {
		i32 33554938, ; type_token_id
		i32 305; java_map_index
	}, 
	; 323
	%struct.TypeMapModuleEntry {
		i32 33554939, ; type_token_id
		i32 344; java_map_index
	}, 
	; 324
	%struct.TypeMapModuleEntry {
		i32 33554941, ; type_token_id
		i32 583; java_map_index
	}, 
	; 325
	%struct.TypeMapModuleEntry {
		i32 33554942, ; type_token_id
		i32 484; java_map_index
	}, 
	; 326
	%struct.TypeMapModuleEntry {
		i32 33554943, ; type_token_id
		i32 256; java_map_index
	}, 
	; 327
	%struct.TypeMapModuleEntry {
		i32 33554944, ; type_token_id
		i32 453; java_map_index
	}, 
	; 328
	%struct.TypeMapModuleEntry {
		i32 33554945, ; type_token_id
		i32 151; java_map_index
	}, 
	; 329
	%struct.TypeMapModuleEntry {
		i32 33554946, ; type_token_id
		i32 607; java_map_index
	}, 
	; 330
	%struct.TypeMapModuleEntry {
		i32 33554947, ; type_token_id
		i32 420; java_map_index
	}, 
	; 331
	%struct.TypeMapModuleEntry {
		i32 33554948, ; type_token_id
		i32 71; java_map_index
	}, 
	; 332
	%struct.TypeMapModuleEntry {
		i32 33554949, ; type_token_id
		i32 73; java_map_index
	}, 
	; 333
	%struct.TypeMapModuleEntry {
		i32 33554950, ; type_token_id
		i32 656; java_map_index
	}, 
	; 334
	%struct.TypeMapModuleEntry {
		i32 33554951, ; type_token_id
		i32 221; java_map_index
	}, 
	; 335
	%struct.TypeMapModuleEntry {
		i32 33554952, ; type_token_id
		i32 580; java_map_index
	}, 
	; 336
	%struct.TypeMapModuleEntry {
		i32 33554953, ; type_token_id
		i32 673; java_map_index
	}, 
	; 337
	%struct.TypeMapModuleEntry {
		i32 33554954, ; type_token_id
		i32 447; java_map_index
	}, 
	; 338
	%struct.TypeMapModuleEntry {
		i32 33554955, ; type_token_id
		i32 123; java_map_index
	}, 
	; 339
	%struct.TypeMapModuleEntry {
		i32 33554956, ; type_token_id
		i32 52; java_map_index
	}, 
	; 340
	%struct.TypeMapModuleEntry {
		i32 33554958, ; type_token_id
		i32 503; java_map_index
	}, 
	; 341
	%struct.TypeMapModuleEntry {
		i32 33554960, ; type_token_id
		i32 591; java_map_index
	}, 
	; 342
	%struct.TypeMapModuleEntry {
		i32 33554961, ; type_token_id
		i32 309; java_map_index
	}, 
	; 343
	%struct.TypeMapModuleEntry {
		i32 33554962, ; type_token_id
		i32 197; java_map_index
	}, 
	; 344
	%struct.TypeMapModuleEntry {
		i32 33554963, ; type_token_id
		i32 724; java_map_index
	}, 
	; 345
	%struct.TypeMapModuleEntry {
		i32 33554964, ; type_token_id
		i32 173; java_map_index
	}, 
	; 346
	%struct.TypeMapModuleEntry {
		i32 33554965, ; type_token_id
		i32 725; java_map_index
	}, 
	; 347
	%struct.TypeMapModuleEntry {
		i32 33554966, ; type_token_id
		i32 341; java_map_index
	}, 
	; 348
	%struct.TypeMapModuleEntry {
		i32 33554967, ; type_token_id
		i32 163; java_map_index
	}, 
	; 349
	%struct.TypeMapModuleEntry {
		i32 33554968, ; type_token_id
		i32 584; java_map_index
	}, 
	; 350
	%struct.TypeMapModuleEntry {
		i32 33554969, ; type_token_id
		i32 114; java_map_index
	}, 
	; 351
	%struct.TypeMapModuleEntry {
		i32 33554970, ; type_token_id
		i32 231; java_map_index
	}, 
	; 352
	%struct.TypeMapModuleEntry {
		i32 33554971, ; type_token_id
		i32 429; java_map_index
	}, 
	; 353
	%struct.TypeMapModuleEntry {
		i32 33554972, ; type_token_id
		i32 219; java_map_index
	}, 
	; 354
	%struct.TypeMapModuleEntry {
		i32 33554973, ; type_token_id
		i32 19; java_map_index
	}, 
	; 355
	%struct.TypeMapModuleEntry {
		i32 33554974, ; type_token_id
		i32 558; java_map_index
	}, 
	; 356
	%struct.TypeMapModuleEntry {
		i32 33554975, ; type_token_id
		i32 619; java_map_index
	}, 
	; 357
	%struct.TypeMapModuleEntry {
		i32 33554976, ; type_token_id
		i32 165; java_map_index
	}, 
	; 358
	%struct.TypeMapModuleEntry {
		i32 33554977, ; type_token_id
		i32 16; java_map_index
	}, 
	; 359
	%struct.TypeMapModuleEntry {
		i32 33554978, ; type_token_id
		i32 455; java_map_index
	}, 
	; 360
	%struct.TypeMapModuleEntry {
		i32 33554979, ; type_token_id
		i32 101; java_map_index
	}, 
	; 361
	%struct.TypeMapModuleEntry {
		i32 33554980, ; type_token_id
		i32 481; java_map_index
	}, 
	; 362
	%struct.TypeMapModuleEntry {
		i32 33554981, ; type_token_id
		i32 445; java_map_index
	}, 
	; 363
	%struct.TypeMapModuleEntry {
		i32 33554982, ; type_token_id
		i32 357; java_map_index
	}, 
	; 364
	%struct.TypeMapModuleEntry {
		i32 33554983, ; type_token_id
		i32 162; java_map_index
	}, 
	; 365
	%struct.TypeMapModuleEntry {
		i32 33554985, ; type_token_id
		i32 33; java_map_index
	}, 
	; 366
	%struct.TypeMapModuleEntry {
		i32 33554986, ; type_token_id
		i32 385; java_map_index
	}, 
	; 367
	%struct.TypeMapModuleEntry {
		i32 33554987, ; type_token_id
		i32 230; java_map_index
	}, 
	; 368
	%struct.TypeMapModuleEntry {
		i32 33554988, ; type_token_id
		i32 540; java_map_index
	}
], align 4; end of 'module13_managed_to_java' array


; module13_managed_to_java_duplicates
@module13_managed_to_java_duplicates = internal constant [46 x %struct.TypeMapModuleEntry] [
	; 0
	%struct.TypeMapModuleEntry {
		i32 33554557, ; type_token_id
		i32 307; java_map_index
	}, 
	; 1
	%struct.TypeMapModuleEntry {
		i32 33554562, ; type_token_id
		i32 111; java_map_index
	}, 
	; 2
	%struct.TypeMapModuleEntry {
		i32 33554563, ; type_token_id
		i32 111; java_map_index
	}, 
	; 3
	%struct.TypeMapModuleEntry {
		i32 33554564, ; type_token_id
		i32 111; java_map_index
	}, 
	; 4
	%struct.TypeMapModuleEntry {
		i32 33554571, ; type_token_id
		i32 223; java_map_index
	}, 
	; 5
	%struct.TypeMapModuleEntry {
		i32 33554574, ; type_token_id
		i32 266; java_map_index
	}, 
	; 6
	%struct.TypeMapModuleEntry {
		i32 33554576, ; type_token_id
		i32 233; java_map_index
	}, 
	; 7
	%struct.TypeMapModuleEntry {
		i32 33554577, ; type_token_id
		i32 233; java_map_index
	}, 
	; 8
	%struct.TypeMapModuleEntry {
		i32 33554578, ; type_token_id
		i32 233; java_map_index
	}, 
	; 9
	%struct.TypeMapModuleEntry {
		i32 33554582, ; type_token_id
		i32 446; java_map_index
	}, 
	; 10
	%struct.TypeMapModuleEntry {
		i32 33554592, ; type_token_id
		i32 682; java_map_index
	}, 
	; 11
	%struct.TypeMapModuleEntry {
		i32 33554596, ; type_token_id
		i32 27; java_map_index
	}, 
	; 12
	%struct.TypeMapModuleEntry {
		i32 33554622, ; type_token_id
		i32 664; java_map_index
	}, 
	; 13
	%struct.TypeMapModuleEntry {
		i32 33554625, ; type_token_id
		i32 141; java_map_index
	}, 
	; 14
	%struct.TypeMapModuleEntry {
		i32 33554646, ; type_token_id
		i32 421; java_map_index
	}, 
	; 15
	%struct.TypeMapModuleEntry {
		i32 33554661, ; type_token_id
		i32 304; java_map_index
	}, 
	; 16
	%struct.TypeMapModuleEntry {
		i32 33554668, ; type_token_id
		i32 391; java_map_index
	}, 
	; 17
	%struct.TypeMapModuleEntry {
		i32 33554677, ; type_token_id
		i32 688; java_map_index
	}, 
	; 18
	%struct.TypeMapModuleEntry {
		i32 33554688, ; type_token_id
		i32 202; java_map_index
	}, 
	; 19
	%struct.TypeMapModuleEntry {
		i32 33554694, ; type_token_id
		i32 643; java_map_index
	}, 
	; 20
	%struct.TypeMapModuleEntry {
		i32 33554697, ; type_token_id
		i32 612; java_map_index
	}, 
	; 21
	%struct.TypeMapModuleEntry {
		i32 33554698, ; type_token_id
		i32 612; java_map_index
	}, 
	; 22
	%struct.TypeMapModuleEntry {
		i32 33554699, ; type_token_id
		i32 612; java_map_index
	}, 
	; 23
	%struct.TypeMapModuleEntry {
		i32 33554709, ; type_token_id
		i32 217; java_map_index
	}, 
	; 24
	%struct.TypeMapModuleEntry {
		i32 33554711, ; type_token_id
		i32 494; java_map_index
	}, 
	; 25
	%struct.TypeMapModuleEntry {
		i32 33554713, ; type_token_id
		i32 277; java_map_index
	}, 
	; 26
	%struct.TypeMapModuleEntry {
		i32 33554715, ; type_token_id
		i32 4; java_map_index
	}, 
	; 27
	%struct.TypeMapModuleEntry {
		i32 33554717, ; type_token_id
		i32 364; java_map_index
	}, 
	; 28
	%struct.TypeMapModuleEntry {
		i32 33554723, ; type_token_id
		i32 456; java_map_index
	}, 
	; 29
	%struct.TypeMapModuleEntry {
		i32 33554725, ; type_token_id
		i32 604; java_map_index
	}, 
	; 30
	%struct.TypeMapModuleEntry {
		i32 33554732, ; type_token_id
		i32 508; java_map_index
	}, 
	; 31
	%struct.TypeMapModuleEntry {
		i32 33554736, ; type_token_id
		i32 337; java_map_index
	}, 
	; 32
	%struct.TypeMapModuleEntry {
		i32 33554749, ; type_token_id
		i32 506; java_map_index
	}, 
	; 33
	%struct.TypeMapModuleEntry {
		i32 33554751, ; type_token_id
		i32 560; java_map_index
	}, 
	; 34
	%struct.TypeMapModuleEntry {
		i32 33554802, ; type_token_id
		i32 247; java_map_index
	}, 
	; 35
	%struct.TypeMapModuleEntry {
		i32 33554803, ; type_token_id
		i32 247; java_map_index
	}, 
	; 36
	%struct.TypeMapModuleEntry {
		i32 33554804, ; type_token_id
		i32 247; java_map_index
	}, 
	; 37
	%struct.TypeMapModuleEntry {
		i32 33554806, ; type_token_id
		i32 441; java_map_index
	}, 
	; 38
	%struct.TypeMapModuleEntry {
		i32 33554813, ; type_token_id
		i32 216; java_map_index
	}, 
	; 39
	%struct.TypeMapModuleEntry {
		i32 33554816, ; type_token_id
		i32 533; java_map_index
	}, 
	; 40
	%struct.TypeMapModuleEntry {
		i32 33554818, ; type_token_id
		i32 627; java_map_index
	}, 
	; 41
	%struct.TypeMapModuleEntry {
		i32 33554824, ; type_token_id
		i32 653; java_map_index
	}, 
	; 42
	%struct.TypeMapModuleEntry {
		i32 33554940, ; type_token_id
		i32 344; java_map_index
	}, 
	; 43
	%struct.TypeMapModuleEntry {
		i32 33554957, ; type_token_id
		i32 52; java_map_index
	}, 
	; 44
	%struct.TypeMapModuleEntry {
		i32 33554959, ; type_token_id
		i32 503; java_map_index
	}, 
	; 45
	%struct.TypeMapModuleEntry {
		i32 33554984, ; type_token_id
		i32 162; java_map_index
	}
], align 4; end of 'module13_managed_to_java_duplicates' array


; module14_managed_to_java
@module14_managed_to_java = internal constant [1 x %struct.TypeMapModuleEntry] [
	; 0
	%struct.TypeMapModuleEntry {
		i32 33554435, ; type_token_id
		i32 610; java_map_index
	}
], align 4; end of 'module14_managed_to_java' array


; module14_managed_to_java_duplicates
@module14_managed_to_java_duplicates = internal constant [1 x %struct.TypeMapModuleEntry] [
	; 0
	%struct.TypeMapModuleEntry {
		i32 33554436, ; type_token_id
		i32 610; java_map_index
	}
], align 4; end of 'module14_managed_to_java_duplicates' array


; module15_managed_to_java
@module15_managed_to_java = internal constant [5 x %struct.TypeMapModuleEntry] [
	; 0
	%struct.TypeMapModuleEntry {
		i32 33554437, ; type_token_id
		i32 705; java_map_index
	}, 
	; 1
	%struct.TypeMapModuleEntry {
		i32 33554439, ; type_token_id
		i32 413; java_map_index
	}, 
	; 2
	%struct.TypeMapModuleEntry {
		i32 33554441, ; type_token_id
		i32 343; java_map_index
	}, 
	; 3
	%struct.TypeMapModuleEntry {
		i32 33554442, ; type_token_id
		i32 738; java_map_index
	}, 
	; 4
	%struct.TypeMapModuleEntry {
		i32 33554444, ; type_token_id
		i32 315; java_map_index
	}
], align 4; end of 'module15_managed_to_java' array


; module15_managed_to_java_duplicates
@module15_managed_to_java_duplicates = internal constant [3 x %struct.TypeMapModuleEntry] [
	; 0
	%struct.TypeMapModuleEntry {
		i32 33554438, ; type_token_id
		i32 705; java_map_index
	}, 
	; 1
	%struct.TypeMapModuleEntry {
		i32 33554440, ; type_token_id
		i32 413; java_map_index
	}, 
	; 2
	%struct.TypeMapModuleEntry {
		i32 33554443, ; type_token_id
		i32 738; java_map_index
	}
], align 4; end of 'module15_managed_to_java_duplicates' array

; Map modules
@__TypeMapModule_assembly_name.0 = internal constant [30 x i8] c"Xamarin.AndroidX.DrawerLayout\00", align 1
@__TypeMapModule_assembly_name.1 = internal constant [34 x i8] c"Xamarin.AndroidX.Lifecycle.Common\00", align 1
@__TypeMapModule_assembly_name.2 = internal constant [22 x i8] c"Xamarin.AndroidX.Core\00", align 1
@__TypeMapModule_assembly_name.3 = internal constant [28 x i8] c"Xamarin.AndroidX.SavedState\00", align 1
@__TypeMapModule_assembly_name.4 = internal constant [26 x i8] c"Xamarin.AndroidX.Fragment\00", align 1
@__TypeMapModule_assembly_name.5 = internal constant [19 x i8] c"Xamarin.Essentials\00", align 1
@__TypeMapModule_assembly_name.6 = internal constant [24 x i8] c"Xamarin.AndroidX.Loader\00", align 1
@__TypeMapModule_assembly_name.7 = internal constant [13 x i8] c"Mono.Android\00", align 1
@__TypeMapModule_assembly_name.8 = internal constant [26 x i8] c"Xamarin.AndroidX.Activity\00", align 1
@__TypeMapModule_assembly_name.9 = internal constant [14 x i8] c"XamarinTecToy\00", align 1
@__TypeMapModule_assembly_name.10 = internal constant [41 x i8] c"Xamarin.AndroidX.Lifecycle.LiveData.Core\00", align 1
@__TypeMapModule_assembly_name.11 = internal constant [28 x i8] c"Xamarin.AndroidX.CustomView\00", align 1
@__TypeMapModule_assembly_name.12 = internal constant [27 x i8] c"Xamarin.AndroidX.AppCompat\00", align 1
@__TypeMapModule_assembly_name.13 = internal constant [8 x i8] c"Binding\00", align 1
@__TypeMapModule_assembly_name.14 = internal constant [38 x i8] c"Xamarin.Google.Guava.ListenableFuture\00", align 1
@__TypeMapModule_assembly_name.15 = internal constant [37 x i8] c"Xamarin.AndroidX.Lifecycle.ViewModel\00", align 1

; map_modules
@map_modules = global [16 x %struct.TypeMapModule] [
	; 0
	%struct.TypeMapModule {
		[16 x i8] c"\03\D5\81\8C\08\BA\9EN\95[\8E?F\E6%\9D", ; module_uuid: 8c81d503-ba08-4e9e-955b-8e3f46e6259d
		i32 3, ; entry_count
		i32 1, ; duplicate_count
		%struct.TypeMapModuleEntry* getelementptr inbounds ([3 x %struct.TypeMapModuleEntry], [3 x %struct.TypeMapModuleEntry]* @module0_managed_to_java, i32 0, i32 0), ; map
		%struct.TypeMapModuleEntry* getelementptr inbounds ([1 x %struct.TypeMapModuleEntry], [1 x %struct.TypeMapModuleEntry]* @module0_managed_to_java_duplicates, i32 0, i32 0), ; duplicate_map
		i8* getelementptr inbounds ([30 x i8], [30 x i8]* @__TypeMapModule_assembly_name.0, i32 0, i32 0), ; assembly_name: Xamarin.AndroidX.DrawerLayout
		%struct.MonoImage* null, ; image
		i32 0, ; java_name_width
		i8* null; java_map
	}, 
	; 1
	%struct.TypeMapModule {
		[16 x i8] c"\063\97\1D\0CP\BCE\A7\D7\F8fH\AA\18\D4", ; module_uuid: 1d973306-500c-45bc-a7d7-f86648aa18d4
		i32 4, ; entry_count
		i32 3, ; duplicate_count
		%struct.TypeMapModuleEntry* getelementptr inbounds ([4 x %struct.TypeMapModuleEntry], [4 x %struct.TypeMapModuleEntry]* @module1_managed_to_java, i32 0, i32 0), ; map
		%struct.TypeMapModuleEntry* getelementptr inbounds ([3 x %struct.TypeMapModuleEntry], [3 x %struct.TypeMapModuleEntry]* @module1_managed_to_java_duplicates, i32 0, i32 0), ; duplicate_map
		i8* getelementptr inbounds ([34 x i8], [34 x i8]* @__TypeMapModule_assembly_name.1, i32 0, i32 0), ; assembly_name: Xamarin.AndroidX.Lifecycle.Common
		%struct.MonoImage* null, ; image
		i32 0, ; java_name_width
		i8* null; java_map
	}, 
	; 2
	%struct.TypeMapModule {
		[16 x i8] c"\11\EA\A3Hp\DCAD\BA\FD\A0G\DF6\08R", ; module_uuid: 48a3ea11-dc70-4441-bafd-a047df360852
		i32 25, ; entry_count
		i32 14, ; duplicate_count
		%struct.TypeMapModuleEntry* getelementptr inbounds ([25 x %struct.TypeMapModuleEntry], [25 x %struct.TypeMapModuleEntry]* @module2_managed_to_java, i32 0, i32 0), ; map
		%struct.TypeMapModuleEntry* getelementptr inbounds ([14 x %struct.TypeMapModuleEntry], [14 x %struct.TypeMapModuleEntry]* @module2_managed_to_java_duplicates, i32 0, i32 0), ; duplicate_map
		i8* getelementptr inbounds ([22 x i8], [22 x i8]* @__TypeMapModule_assembly_name.2, i32 0, i32 0), ; assembly_name: Xamarin.AndroidX.Core
		%struct.MonoImage* null, ; image
		i32 0, ; java_name_width
		i8* null; java_map
	}, 
	; 3
	%struct.TypeMapModule {
		[16 x i8] c"\1B\F1o\C78q\BBJ\8CA\F6\CE\0B,\9Fh", ; module_uuid: c76ff11b-7138-4abb-8c41-f6ce0b2c9f68
		i32 3, ; entry_count
		i32 2, ; duplicate_count
		%struct.TypeMapModuleEntry* getelementptr inbounds ([3 x %struct.TypeMapModuleEntry], [3 x %struct.TypeMapModuleEntry]* @module3_managed_to_java, i32 0, i32 0), ; map
		%struct.TypeMapModuleEntry* getelementptr inbounds ([2 x %struct.TypeMapModuleEntry], [2 x %struct.TypeMapModuleEntry]* @module3_managed_to_java_duplicates, i32 0, i32 0), ; duplicate_map
		i8* getelementptr inbounds ([28 x i8], [28 x i8]* @__TypeMapModule_assembly_name.3, i32 0, i32 0), ; assembly_name: Xamarin.AndroidX.SavedState
		%struct.MonoImage* null, ; image
		i32 0, ; java_name_width
		i8* null; java_map
	}, 
	; 4
	%struct.TypeMapModule {
		[16 x i8] c"Y\16\F6j%P\B3I\94\22V\A1\181R\01", ; module_uuid: 6af61659-5025-49b3-9422-56a118315201
		i32 10, ; entry_count
		i32 5, ; duplicate_count
		%struct.TypeMapModuleEntry* getelementptr inbounds ([10 x %struct.TypeMapModuleEntry], [10 x %struct.TypeMapModuleEntry]* @module4_managed_to_java, i32 0, i32 0), ; map
		%struct.TypeMapModuleEntry* getelementptr inbounds ([5 x %struct.TypeMapModuleEntry], [5 x %struct.TypeMapModuleEntry]* @module4_managed_to_java_duplicates, i32 0, i32 0), ; duplicate_map
		i8* getelementptr inbounds ([26 x i8], [26 x i8]* @__TypeMapModule_assembly_name.4, i32 0, i32 0), ; assembly_name: Xamarin.AndroidX.Fragment
		%struct.MonoImage* null, ; image
		i32 0, ; java_name_width
		i8* null; java_map
	}, 
	; 5
	%struct.TypeMapModule {
		[16 x i8] c"Z\1D\B0\D2\1D\B8bO\80\E2\C3b\D8\1D\9C\D9", ; module_uuid: d2b01d5a-b81d-4f62-80e2-c362d81d9cd9
		i32 1, ; entry_count
		i32 0, ; duplicate_count
		%struct.TypeMapModuleEntry* getelementptr inbounds ([1 x %struct.TypeMapModuleEntry], [1 x %struct.TypeMapModuleEntry]* @module5_managed_to_java, i32 0, i32 0), ; map
		%struct.TypeMapModuleEntry* null, ; duplicate_map
		i8* getelementptr inbounds ([19 x i8], [19 x i8]* @__TypeMapModule_assembly_name.5, i32 0, i32 0), ; assembly_name: Xamarin.Essentials
		%struct.MonoImage* null, ; image
		i32 0, ; java_name_width
		i8* null; java_map
	}, 
	; 6
	%struct.TypeMapModule {
		[16 x i8] c"vEG9$\10\19C\88\15\86(.)q\D8", ; module_uuid: 39474576-1024-4319-8815-86282e2971d8
		i32 5, ; entry_count
		i32 4, ; duplicate_count
		%struct.TypeMapModuleEntry* getelementptr inbounds ([5 x %struct.TypeMapModuleEntry], [5 x %struct.TypeMapModuleEntry]* @module6_managed_to_java, i32 0, i32 0), ; map
		%struct.TypeMapModuleEntry* getelementptr inbounds ([4 x %struct.TypeMapModuleEntry], [4 x %struct.TypeMapModuleEntry]* @module6_managed_to_java_duplicates, i32 0, i32 0), ; duplicate_map
		i8* getelementptr inbounds ([24 x i8], [24 x i8]* @__TypeMapModule_assembly_name.6, i32 0, i32 0), ; assembly_name: Xamarin.AndroidX.Loader
		%struct.MonoImage* null, ; image
		i32 0, ; java_name_width
		i8* null; java_map
	}, 
	; 7
	%struct.TypeMapModule {
		[16 x i8] c"y{o\13\EBC\E0E\92\0D\EF\0Ae\CE\CD\03", ; module_uuid: 136f7b79-43eb-45e0-920d-ef0a65cecd03
		i32 282, ; entry_count
		i32 147, ; duplicate_count
		%struct.TypeMapModuleEntry* getelementptr inbounds ([282 x %struct.TypeMapModuleEntry], [282 x %struct.TypeMapModuleEntry]* @module7_managed_to_java, i32 0, i32 0), ; map
		%struct.TypeMapModuleEntry* getelementptr inbounds ([147 x %struct.TypeMapModuleEntry], [147 x %struct.TypeMapModuleEntry]* @module7_managed_to_java_duplicates, i32 0, i32 0), ; duplicate_map
		i8* getelementptr inbounds ([13 x i8], [13 x i8]* @__TypeMapModule_assembly_name.7, i32 0, i32 0), ; assembly_name: Mono.Android
		%struct.MonoImage* null, ; image
		i32 0, ; java_name_width
		i8* null; java_map
	}, 
	; 8
	%struct.TypeMapModule {
		[16 x i8] c"\80\FA4\B0\BD)YE\83T&\A7C\F7BS", ; module_uuid: b034fa80-29bd-4559-8354-26a743f74253
		i32 1, ; entry_count
		i32 0, ; duplicate_count
		%struct.TypeMapModuleEntry* getelementptr inbounds ([1 x %struct.TypeMapModuleEntry], [1 x %struct.TypeMapModuleEntry]* @module8_managed_to_java, i32 0, i32 0), ; map
		%struct.TypeMapModuleEntry* null, ; duplicate_map
		i8* getelementptr inbounds ([26 x i8], [26 x i8]* @__TypeMapModule_assembly_name.8, i32 0, i32 0), ; assembly_name: Xamarin.AndroidX.Activity
		%struct.MonoImage* null, ; image
		i32 0, ; java_name_width
		i8* null; java_map
	}, 
	; 9
	%struct.TypeMapModule {
		[16 x i8] c"\86\FDEa\9E\07\A1D\A3\B6\D1\B4\CCC\D3r", ; module_uuid: 6145fd86-079e-44a1-a3b6-d1b4cc43d372
		i32 1, ; entry_count
		i32 0, ; duplicate_count
		%struct.TypeMapModuleEntry* getelementptr inbounds ([1 x %struct.TypeMapModuleEntry], [1 x %struct.TypeMapModuleEntry]* @module9_managed_to_java, i32 0, i32 0), ; map
		%struct.TypeMapModuleEntry* null, ; duplicate_map
		i8* getelementptr inbounds ([14 x i8], [14 x i8]* @__TypeMapModule_assembly_name.9, i32 0, i32 0), ; assembly_name: XamarinTecToy
		%struct.MonoImage* null, ; image
		i32 0, ; java_name_width
		i8* null; java_map
	}, 
	; 10
	%struct.TypeMapModule {
		[16 x i8] c"\9A\08\C1\9A\F9\EE\98K\B1\8E\EC\BB\DF\85|\EE", ; module_uuid: 9ac1089a-eef9-4b98-b18e-ecbbdf857cee
		i32 2, ; entry_count
		i32 2, ; duplicate_count
		%struct.TypeMapModuleEntry* getelementptr inbounds ([2 x %struct.TypeMapModuleEntry], [2 x %struct.TypeMapModuleEntry]* @module10_managed_to_java, i32 0, i32 0), ; map
		%struct.TypeMapModuleEntry* getelementptr inbounds ([2 x %struct.TypeMapModuleEntry], [2 x %struct.TypeMapModuleEntry]* @module10_managed_to_java_duplicates, i32 0, i32 0), ; duplicate_map
		i8* getelementptr inbounds ([41 x i8], [41 x i8]* @__TypeMapModule_assembly_name.10, i32 0, i32 0), ; assembly_name: Xamarin.AndroidX.Lifecycle.LiveData.Core
		%struct.MonoImage* null, ; image
		i32 0, ; java_name_width
		i8* null; java_map
	}, 
	; 11
	%struct.TypeMapModule {
		[16 x i8] c"\A3\C2q]\DDT\90H\8B\03\08t\D6U\1E\FF", ; module_uuid: 5d71c2a3-54dd-4890-8b03-0874d6551eff
		i32 1, ; entry_count
		i32 1, ; duplicate_count
		%struct.TypeMapModuleEntry* getelementptr inbounds ([1 x %struct.TypeMapModuleEntry], [1 x %struct.TypeMapModuleEntry]* @module11_managed_to_java, i32 0, i32 0), ; map
		%struct.TypeMapModuleEntry* getelementptr inbounds ([1 x %struct.TypeMapModuleEntry], [1 x %struct.TypeMapModuleEntry]* @module11_managed_to_java_duplicates, i32 0, i32 0), ; duplicate_map
		i8* getelementptr inbounds ([28 x i8], [28 x i8]* @__TypeMapModule_assembly_name.11, i32 0, i32 0), ; assembly_name: Xamarin.AndroidX.CustomView
		%struct.MonoImage* null, ; image
		i32 0, ; java_name_width
		i8* null; java_map
	}, 
	; 12
	%struct.TypeMapModule {
		[16 x i8] c"\C4w\9D7\8A\CFED\86\0Bh\AF4S\EBN", ; module_uuid: 379d77c4-cf8a-4445-860b-68af3453eb4e
		i32 30, ; entry_count
		i32 17, ; duplicate_count
		%struct.TypeMapModuleEntry* getelementptr inbounds ([30 x %struct.TypeMapModuleEntry], [30 x %struct.TypeMapModuleEntry]* @module12_managed_to_java, i32 0, i32 0), ; map
		%struct.TypeMapModuleEntry* getelementptr inbounds ([17 x %struct.TypeMapModuleEntry], [17 x %struct.TypeMapModuleEntry]* @module12_managed_to_java_duplicates, i32 0, i32 0), ; duplicate_map
		i8* getelementptr inbounds ([27 x i8], [27 x i8]* @__TypeMapModule_assembly_name.12, i32 0, i32 0), ; assembly_name: Xamarin.AndroidX.AppCompat
		%struct.MonoImage* null, ; image
		i32 0, ; java_name_width
		i8* null; java_map
	}, 
	; 13
	%struct.TypeMapModule {
		[16 x i8] c"\CD\18\EAj\1D\ED\A4O\95\0C\C9q1\DB\A6\F2", ; module_uuid: 6aea18cd-ed1d-4fa4-950c-c97131dba6f2
		i32 369, ; entry_count
		i32 46, ; duplicate_count
		%struct.TypeMapModuleEntry* getelementptr inbounds ([369 x %struct.TypeMapModuleEntry], [369 x %struct.TypeMapModuleEntry]* @module13_managed_to_java, i32 0, i32 0), ; map
		%struct.TypeMapModuleEntry* getelementptr inbounds ([46 x %struct.TypeMapModuleEntry], [46 x %struct.TypeMapModuleEntry]* @module13_managed_to_java_duplicates, i32 0, i32 0), ; duplicate_map
		i8* getelementptr inbounds ([8 x i8], [8 x i8]* @__TypeMapModule_assembly_name.13, i32 0, i32 0), ; assembly_name: Binding
		%struct.MonoImage* null, ; image
		i32 0, ; java_name_width
		i8* null; java_map
	}, 
	; 14
	%struct.TypeMapModule {
		[16 x i8] c"\D9\85\AB\22\0C\C49G\B6\FE\C7\ACl\FD\02.", ; module_uuid: 22ab85d9-c40c-4739-b6fe-c7ac6cfd022e
		i32 1, ; entry_count
		i32 1, ; duplicate_count
		%struct.TypeMapModuleEntry* getelementptr inbounds ([1 x %struct.TypeMapModuleEntry], [1 x %struct.TypeMapModuleEntry]* @module14_managed_to_java, i32 0, i32 0), ; map
		%struct.TypeMapModuleEntry* getelementptr inbounds ([1 x %struct.TypeMapModuleEntry], [1 x %struct.TypeMapModuleEntry]* @module14_managed_to_java_duplicates, i32 0, i32 0), ; duplicate_map
		i8* getelementptr inbounds ([38 x i8], [38 x i8]* @__TypeMapModule_assembly_name.14, i32 0, i32 0), ; assembly_name: Xamarin.Google.Guava.ListenableFuture
		%struct.MonoImage* null, ; image
		i32 0, ; java_name_width
		i8* null; java_map
	}, 
	; 15
	%struct.TypeMapModule {
		[16 x i8] c"\E5\E4^\96\E4\B5\C6O\95\99\A1\09\85\F8!\F3", ; module_uuid: 965ee4e5-b5e4-4fc6-9599-a10985f821f3
		i32 5, ; entry_count
		i32 3, ; duplicate_count
		%struct.TypeMapModuleEntry* getelementptr inbounds ([5 x %struct.TypeMapModuleEntry], [5 x %struct.TypeMapModuleEntry]* @module15_managed_to_java, i32 0, i32 0), ; map
		%struct.TypeMapModuleEntry* getelementptr inbounds ([3 x %struct.TypeMapModuleEntry], [3 x %struct.TypeMapModuleEntry]* @module15_managed_to_java_duplicates, i32 0, i32 0), ; duplicate_map
		i8* getelementptr inbounds ([37 x i8], [37 x i8]* @__TypeMapModule_assembly_name.15, i32 0, i32 0), ; assembly_name: Xamarin.AndroidX.Lifecycle.ViewModel
		%struct.MonoImage* null, ; image
		i32 0, ; java_name_width
		i8* null; java_map
	}
], align 4; end of 'map_modules' array


; Java to managed map

; map_java
@map_java = local_unnamed_addr constant [743 x %struct.TypeMapJava] [
	; 0
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 170; java_name_index
	}, 
	; 1
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33555043, ; type_token_id
		i32 298; java_name_index
	}, 
	; 2
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 312; java_name_index
	}, 
	; 3
	%struct.TypeMapJava {
		i32 4, ; module_index
		i32 33554468, ; type_token_id
		i32 36; java_name_index
	}, 
	; 4
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 0, ; type_token_id
		i32 488; java_name_index
	}, 
	; 5
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554882, ; type_token_id
		i32 634; java_name_index
	}, 
	; 6
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554949, ; type_token_id
		i32 238; java_name_index
	}, 
	; 7
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554915, ; type_token_id
		i32 667; java_name_index
	}, 
	; 8
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554675, ; type_token_id
		i32 113; java_name_index
	}, 
	; 9
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554867, ; type_token_id
		i32 619; java_name_index
	}, 
	; 10
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554620, ; type_token_id
		i32 420; java_name_index
	}, 
	; 11
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554881, ; type_token_id
		i32 633; java_name_index
	}, 
	; 12
	%struct.TypeMapJava {
		i32 12, ; module_index
		i32 0, ; type_token_id
		i32 356; java_name_index
	}, 
	; 13
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554613, ; type_token_id
		i32 413; java_name_index
	}, 
	; 14
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554711, ; type_token_id
		i32 128; java_name_index
	}, 
	; 15
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 253; java_name_index
	}, 
	; 16
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554977, ; type_token_id
		i32 726; java_name_index
	}, 
	; 17
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 60; java_name_index
	}, 
	; 18
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554653, ; type_token_id
		i32 100; java_name_index
	}, 
	; 19
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554973, ; type_token_id
		i32 722; java_name_index
	}, 
	; 20
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 314; java_name_index
	}, 
	; 21
	%struct.TypeMapJava {
		i32 4, ; module_index
		i32 33554478, ; type_token_id
		i32 43; java_name_index
	}, 
	; 22
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554718, ; type_token_id
		i32 490; java_name_index
	}, 
	; 23
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554568, ; type_token_id
		i32 377; java_name_index
	}, 
	; 24
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33555031, ; type_token_id
		i32 288; java_name_index
	}, 
	; 25
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 67; java_name_index
	}, 
	; 26
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 248; java_name_index
	}, 
	; 27
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 0, ; type_token_id
		i32 396; java_name_index
	}, 
	; 28
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 254; java_name_index
	}, 
	; 29
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554657, ; type_token_id
		i32 451; java_name_index
	}, 
	; 30
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554707, ; type_token_id
		i32 484; java_name_index
	}, 
	; 31
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554853, ; type_token_id
		i32 605; java_name_index
	}, 
	; 32
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554653, ; type_token_id
		i32 447; java_name_index
	}, 
	; 33
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554985, ; type_token_id
		i32 733; java_name_index
	}, 
	; 34
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33555044, ; type_token_id
		i32 299; java_name_index
	}, 
	; 35
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 126; java_name_index
	}, 
	; 36
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554564, ; type_token_id
		i32 53; java_name_index
	}, 
	; 37
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 191; java_name_index
	}, 
	; 38
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 223; java_name_index
	}, 
	; 39
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554904, ; type_token_id
		i32 656; java_name_index
	}, 
	; 40
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554629, ; type_token_id
		i32 427; java_name_index
	}, 
	; 41
	%struct.TypeMapJava {
		i32 6, ; module_index
		i32 0, ; type_token_id
		i32 48; java_name_index
	}, 
	; 42
	%struct.TypeMapJava {
		i32 3, ; module_index
		i32 33554437, ; type_token_id
		i32 33; java_name_index
	}, 
	; 43
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 88; java_name_index
	}, 
	; 44
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554769, ; type_token_id
		i32 169; java_name_index
	}, 
	; 45
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554587, ; type_token_id
		i32 389; java_name_index
	}, 
	; 46
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554872, ; type_token_id
		i32 624; java_name_index
	}, 
	; 47
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554559, ; type_token_id
		i32 371; java_name_index
	}, 
	; 48
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554998, ; type_token_id
		i32 267; java_name_index
	}, 
	; 49
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554676, ; type_token_id
		i32 114; java_name_index
	}, 
	; 50
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554780, ; type_token_id
		i32 546; java_name_index
	}, 
	; 51
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554836, ; type_token_id
		i32 588; java_name_index
	}, 
	; 52
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 0, ; type_token_id
		i32 707; java_name_index
	}, 
	; 53
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554897, ; type_token_id
		i32 649; java_name_index
	}, 
	; 54
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33555055, ; type_token_id
		i32 307; java_name_index
	}, 
	; 55
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554871, ; type_token_id
		i32 623; java_name_index
	}, 
	; 56
	%struct.TypeMapJava {
		i32 1, ; module_index
		i32 0, ; type_token_id
		i32 6; java_name_index
	}, 
	; 57
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 173; java_name_index
	}, 
	; 58
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 235; java_name_index
	}, 
	; 59
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33555038, ; type_token_id
		i32 294; java_name_index
	}, 
	; 60
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554822, ; type_token_id
		i32 575; java_name_index
	}, 
	; 61
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 215; java_name_index
	}, 
	; 62
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554984, ; type_token_id
		i32 256; java_name_index
	}, 
	; 63
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33555011, ; type_token_id
		i32 276; java_name_index
	}, 
	; 64
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554600, ; type_token_id
		i32 400; java_name_index
	}, 
	; 65
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554877, ; type_token_id
		i32 629; java_name_index
	}, 
	; 66
	%struct.TypeMapJava {
		i32 4, ; module_index
		i32 33554470, ; type_token_id
		i32 38; java_name_index
	}, 
	; 67
	%struct.TypeMapJava {
		i32 12, ; module_index
		i32 33554511, ; type_token_id
		i32 358; java_name_index
	}, 
	; 68
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33555037, ; type_token_id
		i32 293; java_name_index
	}, 
	; 69
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554765, ; type_token_id
		i32 531; java_name_index
	}, 
	; 70
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554827, ; type_token_id
		i32 579; java_name_index
	}, 
	; 71
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554948, ; type_token_id
		i32 699; java_name_index
	}, 
	; 72
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554924, ; type_token_id
		i32 676; java_name_index
	}, 
	; 73
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554949, ; type_token_id
		i32 700; java_name_index
	}, 
	; 74
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 311; java_name_index
	}, 
	; 75
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554940, ; type_token_id
		i32 232; java_name_index
	}, 
	; 76
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554919, ; type_token_id
		i32 671; java_name_index
	}, 
	; 77
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554900, ; type_token_id
		i32 652; java_name_index
	}, 
	; 78
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554677, ; type_token_id
		i32 115; java_name_index
	}, 
	; 79
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 103; java_name_index
	}, 
	; 80
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554633, ; type_token_id
		i32 431; java_name_index
	}, 
	; 81
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 96; java_name_index
	}, 
	; 82
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554734, ; type_token_id
		i32 144; java_name_index
	}, 
	; 83
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554743, ; type_token_id
		i32 511; java_name_index
	}, 
	; 84
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554862, ; type_token_id
		i32 614; java_name_index
	}, 
	; 85
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554884, ; type_token_id
		i32 207; java_name_index
	}, 
	; 86
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554683, ; type_token_id
		i32 466; java_name_index
	}, 
	; 87
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554579, ; type_token_id
		i32 382; java_name_index
	}, 
	; 88
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554602, ; type_token_id
		i32 402; java_name_index
	}, 
	; 89
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554639, ; type_token_id
		i32 437; java_name_index
	}, 
	; 90
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554868, ; type_token_id
		i32 620; java_name_index
	}, 
	; 91
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554849, ; type_token_id
		i32 601; java_name_index
	}, 
	; 92
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554964, ; type_token_id
		i32 246; java_name_index
	}, 
	; 93
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33555032, ; type_token_id
		i32 289; java_name_index
	}, 
	; 94
	%struct.TypeMapJava {
		i32 8, ; module_index
		i32 33554434, ; type_token_id
		i32 333; java_name_index
	}, 
	; 95
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554680, ; type_token_id
		i32 117; java_name_index
	}, 
	; 96
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554721, ; type_token_id
		i32 136; java_name_index
	}, 
	; 97
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554720, ; type_token_id
		i32 492; java_name_index
	}, 
	; 98
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 327; java_name_index
	}, 
	; 99
	%struct.TypeMapJava {
		i32 12, ; module_index
		i32 0, ; type_token_id
		i32 343; java_name_index
	}, 
	; 100
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554999, ; type_token_id
		i32 268; java_name_index
	}, 
	; 101
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554979, ; type_token_id
		i32 728; java_name_index
	}, 
	; 102
	%struct.TypeMapJava {
		i32 12, ; module_index
		i32 33554494, ; type_token_id
		i32 349; java_name_index
	}, 
	; 103
	%struct.TypeMapJava {
		i32 6, ; module_index
		i32 33554447, ; type_token_id
		i32 46; java_name_index
	}, 
	; 104
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554846, ; type_token_id
		i32 598; java_name_index
	}, 
	; 105
	%struct.TypeMapJava {
		i32 4, ; module_index
		i32 33554482, ; type_token_id
		i32 44; java_name_index
	}, 
	; 106
	%struct.TypeMapJava {
		i32 2, ; module_index
		i32 0, ; type_token_id
		i32 29; java_name_index
	}, 
	; 107
	%struct.TypeMapJava {
		i32 9, ; module_index
		i32 33554434, ; type_token_id
		i32 334; java_name_index
	}, 
	; 108
	%struct.TypeMapJava {
		i32 12, ; module_index
		i32 33554499, ; type_token_id
		i32 352; java_name_index
	}, 
	; 109
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554863, ; type_token_id
		i32 203; java_name_index
	}, 
	; 110
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554774, ; type_token_id
		i32 540; java_name_index
	}, 
	; 111
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554561, ; type_token_id
		i32 373; java_name_index
	}, 
	; 112
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554900, ; type_token_id
		i32 212; java_name_index
	}, 
	; 113
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554691, ; type_token_id
		i32 472; java_name_index
	}, 
	; 114
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554969, ; type_token_id
		i32 718; java_name_index
	}, 
	; 115
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554762, ; type_token_id
		i32 528; java_name_index
	}, 
	; 116
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554584, ; type_token_id
		i32 386; java_name_index
	}, 
	; 117
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 284; java_name_index
	}, 
	; 118
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33555088, ; type_token_id
		i32 329; java_name_index
	}, 
	; 119
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33555034, ; type_token_id
		i32 291; java_name_index
	}, 
	; 120
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554643, ; type_token_id
		i32 441; java_name_index
	}, 
	; 121
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 138; java_name_index
	}, 
	; 122
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33555054, ; type_token_id
		i32 306; java_name_index
	}, 
	; 123
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554955, ; type_token_id
		i32 706; java_name_index
	}, 
	; 124
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554851, ; type_token_id
		i32 603; java_name_index
	}, 
	; 125
	%struct.TypeMapJava {
		i32 2, ; module_index
		i32 0, ; type_token_id
		i32 19; java_name_index
	}, 
	; 126
	%struct.TypeMapJava {
		i32 12, ; module_index
		i32 33554473, ; type_token_id
		i32 338; java_name_index
	}, 
	; 127
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554644, ; type_token_id
		i32 442; java_name_index
	}, 
	; 128
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33555040, ; type_token_id
		i32 296; java_name_index
	}, 
	; 129
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 171; java_name_index
	}, 
	; 130
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554560, ; type_token_id
		i32 372; java_name_index
	}, 
	; 131
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554911, ; type_token_id
		i32 663; java_name_index
	}, 
	; 132
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554616, ; type_token_id
		i32 416; java_name_index
	}, 
	; 133
	%struct.TypeMapJava {
		i32 2, ; module_index
		i32 0, ; type_token_id
		i32 16; java_name_index
	}, 
	; 134
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 61; java_name_index
	}, 
	; 135
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554753, ; type_token_id
		i32 519; java_name_index
	}, 
	; 136
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33555047, ; type_token_id
		i32 302; java_name_index
	}, 
	; 137
	%struct.TypeMapJava {
		i32 2, ; module_index
		i32 33554473, ; type_token_id
		i32 11; java_name_index
	}, 
	; 138
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554594, ; type_token_id
		i32 395; java_name_index
	}, 
	; 139
	%struct.TypeMapJava {
		i32 2, ; module_index
		i32 0, ; type_token_id
		i32 24; java_name_index
	}, 
	; 140
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554958, ; type_token_id
		i32 243; java_name_index
	}, 
	; 141
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554624, ; type_token_id
		i32 423; java_name_index
	}, 
	; 142
	%struct.TypeMapJava {
		i32 2, ; module_index
		i32 33554487, ; type_token_id
		i32 17; java_name_index
	}, 
	; 143
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554936, ; type_token_id
		i32 688; java_name_index
	}, 
	; 144
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554672, ; type_token_id
		i32 458; java_name_index
	}, 
	; 145
	%struct.TypeMapJava {
		i32 5, ; module_index
		i32 33554448, ; type_token_id
		i32 45; java_name_index
	}, 
	; 146
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554680, ; type_token_id
		i32 463; java_name_index
	}, 
	; 147
	%struct.TypeMapJava {
		i32 3, ; module_index
		i32 0, ; type_token_id
		i32 32; java_name_index
	}, 
	; 148
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554848, ; type_token_id
		i32 600; java_name_index
	}, 
	; 149
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554739, ; type_token_id
		i32 146; java_name_index
	}, 
	; 150
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 112; java_name_index
	}, 
	; 151
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554945, ; type_token_id
		i32 696; java_name_index
	}, 
	; 152
	%struct.TypeMapJava {
		i32 12, ; module_index
		i32 0, ; type_token_id
		i32 347; java_name_index
	}, 
	; 153
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554608, ; type_token_id
		i32 74; java_name_index
	}, 
	; 154
	%struct.TypeMapJava {
		i32 10, ; module_index
		i32 33554441, ; type_token_id
		i32 336; java_name_index
	}, 
	; 155
	%struct.TypeMapJava {
		i32 2, ; module_index
		i32 33554492, ; type_token_id
		i32 20; java_name_index
	}, 
	; 156
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 101; java_name_index
	}, 
	; 157
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554839, ; type_token_id
		i32 591; java_name_index
	}, 
	; 158
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554727, ; type_token_id
		i32 497; java_name_index
	}, 
	; 159
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33555071, ; type_token_id
		i32 318; java_name_index
	}, 
	; 160
	%struct.TypeMapJava {
		i32 10, ; module_index
		i32 0, ; type_token_id
		i32 335; java_name_index
	}, 
	; 161
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 249; java_name_index
	}, 
	; 162
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 0, ; type_token_id
		i32 732; java_name_index
	}, 
	; 163
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554967, ; type_token_id
		i32 716; java_name_index
	}, 
	; 164
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554606, ; type_token_id
		i32 72; java_name_index
	}, 
	; 165
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554976, ; type_token_id
		i32 725; java_name_index
	}, 
	; 166
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554687, ; type_token_id
		i32 121; java_name_index
	}, 
	; 167
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554993, ; type_token_id
		i32 263; java_name_index
	}, 
	; 168
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554894, ; type_token_id
		i32 208; java_name_index
	}, 
	; 169
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554767, ; type_token_id
		i32 168; java_name_index
	}, 
	; 170
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554820, ; type_token_id
		i32 196; java_name_index
	}, 
	; 171
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554752, ; type_token_id
		i32 518; java_name_index
	}, 
	; 172
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554659, ; type_token_id
		i32 453; java_name_index
	}, 
	; 173
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554964, ; type_token_id
		i32 713; java_name_index
	}, 
	; 174
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554746, ; type_token_id
		i32 514; java_name_index
	}, 
	; 175
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554930, ; type_token_id
		i32 682; java_name_index
	}, 
	; 176
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 236; java_name_index
	}, 
	; 177
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554597, ; type_token_id
		i32 397; java_name_index
	}, 
	; 178
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554922, ; type_token_id
		i32 674; java_name_index
	}, 
	; 179
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 315; java_name_index
	}, 
	; 180
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 222; java_name_index
	}, 
	; 181
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554916, ; type_token_id
		i32 219; java_name_index
	}, 
	; 182
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554636, ; type_token_id
		i32 434; java_name_index
	}, 
	; 183
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554796, ; type_token_id
		i32 562; java_name_index
	}, 
	; 184
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554583, ; type_token_id
		i32 63; java_name_index
	}, 
	; 185
	%struct.TypeMapJava {
		i32 12, ; module_index
		i32 0, ; type_token_id
		i32 341; java_name_index
	}, 
	; 186
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554814, ; type_token_id
		i32 569; java_name_index
	}, 
	; 187
	%struct.TypeMapJava {
		i32 0, ; module_index
		i32 33554454, ; type_token_id
		i32 0; java_name_index
	}, 
	; 188
	%struct.TypeMapJava {
		i32 2, ; module_index
		i32 0, ; type_token_id
		i32 13; java_name_index
	}, 
	; 189
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554742, ; type_token_id
		i32 510; java_name_index
	}, 
	; 190
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 214; java_name_index
	}, 
	; 191
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554903, ; type_token_id
		i32 655; java_name_index
	}, 
	; 192
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 285; java_name_index
	}, 
	; 193
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554747, ; type_token_id
		i32 515; java_name_index
	}, 
	; 194
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554586, ; type_token_id
		i32 388; java_name_index
	}, 
	; 195
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33555013, ; type_token_id
		i32 277; java_name_index
	}, 
	; 196
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 92; java_name_index
	}, 
	; 197
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554962, ; type_token_id
		i32 711; java_name_index
	}, 
	; 198
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554912, ; type_token_id
		i32 664; java_name_index
	}, 
	; 199
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 283; java_name_index
	}, 
	; 200
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554891, ; type_token_id
		i32 643; java_name_index
	}, 
	; 201
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554627, ; type_token_id
		i32 425; java_name_index
	}, 
	; 202
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554686, ; type_token_id
		i32 469; java_name_index
	}, 
	; 203
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554565, ; type_token_id
		i32 374; java_name_index
	}, 
	; 204
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554562, ; type_token_id
		i32 52; java_name_index
	}, 
	; 205
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554734, ; type_token_id
		i32 503; java_name_index
	}, 
	; 206
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554926, ; type_token_id
		i32 678; java_name_index
	}, 
	; 207
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554841, ; type_token_id
		i32 593; java_name_index
	}, 
	; 208
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554887, ; type_token_id
		i32 639; java_name_index
	}, 
	; 209
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554705, ; type_token_id
		i32 482; java_name_index
	}, 
	; 210
	%struct.TypeMapJava {
		i32 2, ; module_index
		i32 33554507, ; type_token_id
		i32 30; java_name_index
	}, 
	; 211
	%struct.TypeMapJava {
		i32 12, ; module_index
		i32 0, ; type_token_id
		i32 360; java_name_index
	}, 
	; 212
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554726, ; type_token_id
		i32 496; java_name_index
	}, 
	; 213
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 120; java_name_index
	}, 
	; 214
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554996, ; type_token_id
		i32 265; java_name_index
	}, 
	; 215
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554690, ; type_token_id
		i32 471; java_name_index
	}, 
	; 216
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554812, ; type_token_id
		i32 568; java_name_index
	}, 
	; 217
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 0, ; type_token_id
		i32 485; java_name_index
	}, 
	; 218
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33555056, ; type_token_id
		i32 308; java_name_index
	}, 
	; 219
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554972, ; type_token_id
		i32 721; java_name_index
	}, 
	; 220
	%struct.TypeMapJava {
		i32 12, ; module_index
		i32 0, ; type_token_id
		i32 351; java_name_index
	}, 
	; 221
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554951, ; type_token_id
		i32 702; java_name_index
	}, 
	; 222
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554584, ; type_token_id
		i32 64; java_name_index
	}, 
	; 223
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554569, ; type_token_id
		i32 378; java_name_index
	}, 
	; 224
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554852, ; type_token_id
		i32 201; java_name_index
	}, 
	; 225
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554755, ; type_token_id
		i32 160; java_name_index
	}, 
	; 226
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554637, ; type_token_id
		i32 435; java_name_index
	}, 
	; 227
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554831, ; type_token_id
		i32 583; java_name_index
	}, 
	; 228
	%struct.TypeMapJava {
		i32 12, ; module_index
		i32 0, ; type_token_id
		i32 364; java_name_index
	}, 
	; 229
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554875, ; type_token_id
		i32 627; java_name_index
	}, 
	; 230
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554987, ; type_token_id
		i32 735; java_name_index
	}, 
	; 231
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554970, ; type_token_id
		i32 719; java_name_index
	}, 
	; 232
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33555010, ; type_token_id
		i32 275; java_name_index
	}, 
	; 233
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554575, ; type_token_id
		i32 381; java_name_index
	}, 
	; 234
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554758, ; type_token_id
		i32 163; java_name_index
	}, 
	; 235
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 58; java_name_index
	}, 
	; 236
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554855, ; type_token_id
		i32 607; java_name_index
	}, 
	; 237
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554702, ; type_token_id
		i32 479; java_name_index
	}, 
	; 238
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554604, ; type_token_id
		i32 404; java_name_index
	}, 
	; 239
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554761, ; type_token_id
		i32 527; java_name_index
	}, 
	; 240
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554792, ; type_token_id
		i32 180; java_name_index
	}, 
	; 241
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 286; java_name_index
	}, 
	; 242
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554755, ; type_token_id
		i32 521; java_name_index
	}, 
	; 243
	%struct.TypeMapJava {
		i32 2, ; module_index
		i32 33554469, ; type_token_id
		i32 9; java_name_index
	}, 
	; 244
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554870, ; type_token_id
		i32 622; java_name_index
	}, 
	; 245
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554864, ; type_token_id
		i32 616; java_name_index
	}, 
	; 246
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554772, ; type_token_id
		i32 538; java_name_index
	}, 
	; 247
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554801, ; type_token_id
		i32 563; java_name_index
	}, 
	; 248
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554893, ; type_token_id
		i32 645; java_name_index
	}, 
	; 249
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554608, ; type_token_id
		i32 408; java_name_index
	}, 
	; 250
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33555046, ; type_token_id
		i32 301; java_name_index
	}, 
	; 251
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554985, ; type_token_id
		i32 257; java_name_index
	}, 
	; 252
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554760, ; type_token_id
		i32 165; java_name_index
	}, 
	; 253
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554598, ; type_token_id
		i32 398; java_name_index
	}, 
	; 254
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554932, ; type_token_id
		i32 684; java_name_index
	}, 
	; 255
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 95; java_name_index
	}, 
	; 256
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554943, ; type_token_id
		i32 694; java_name_index
	}, 
	; 257
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554784, ; type_token_id
		i32 550; java_name_index
	}, 
	; 258
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554845, ; type_token_id
		i32 597; java_name_index
	}, 
	; 259
	%struct.TypeMapJava {
		i32 12, ; module_index
		i32 0, ; type_token_id
		i32 365; java_name_index
	}, 
	; 260
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554769, ; type_token_id
		i32 535; java_name_index
	}, 
	; 261
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 225; java_name_index
	}, 
	; 262
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554775, ; type_token_id
		i32 541; java_name_index
	}, 
	; 263
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554673, ; type_token_id
		i32 459; java_name_index
	}, 
	; 264
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554689, ; type_token_id
		i32 470; java_name_index
	}, 
	; 265
	%struct.TypeMapJava {
		i32 2, ; module_index
		i32 33554494, ; type_token_id
		i32 22; java_name_index
	}, 
	; 266
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 0, ; type_token_id
		i32 380; java_name_index
	}, 
	; 267
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554854, ; type_token_id
		i32 202; java_name_index
	}, 
	; 268
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554566, ; type_token_id
		i32 54; java_name_index
	}, 
	; 269
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554760, ; type_token_id
		i32 526; java_name_index
	}, 
	; 270
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554982, ; type_token_id
		i32 255; java_name_index
	}, 
	; 271
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554654, ; type_token_id
		i32 448; java_name_index
	}, 
	; 272
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554811, ; type_token_id
		i32 567; java_name_index
	}, 
	; 273
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 229; java_name_index
	}, 
	; 274
	%struct.TypeMapJava {
		i32 12, ; module_index
		i32 0, ; type_token_id
		i32 363; java_name_index
	}, 
	; 275
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554605, ; type_token_id
		i32 71; java_name_index
	}, 
	; 276
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554618, ; type_token_id
		i32 418; java_name_index
	}, 
	; 277
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 0, ; type_token_id
		i32 487; java_name_index
	}, 
	; 278
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554819, ; type_token_id
		i32 572; java_name_index
	}, 
	; 279
	%struct.TypeMapJava {
		i32 2, ; module_index
		i32 33554484, ; type_token_id
		i32 15; java_name_index
	}, 
	; 280
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554788, ; type_token_id
		i32 554; java_name_index
	}, 
	; 281
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554885, ; type_token_id
		i32 637; java_name_index
	}, 
	; 282
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554898, ; type_token_id
		i32 650; java_name_index
	}, 
	; 283
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33555070, ; type_token_id
		i32 317; java_name_index
	}, 
	; 284
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554649, ; type_token_id
		i32 97; java_name_index
	}, 
	; 285
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554828, ; type_token_id
		i32 580; java_name_index
	}, 
	; 286
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 213; java_name_index
	}, 
	; 287
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554773, ; type_token_id
		i32 539; java_name_index
	}, 
	; 288
	%struct.TypeMapJava {
		i32 12, ; module_index
		i32 33554505, ; type_token_id
		i32 355; java_name_index
	}, 
	; 289
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554623, ; type_token_id
		i32 83; java_name_index
	}, 
	; 290
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554722, ; type_token_id
		i32 137; java_name_index
	}, 
	; 291
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554854, ; type_token_id
		i32 606; java_name_index
	}, 
	; 292
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 247; java_name_index
	}, 
	; 293
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 252; java_name_index
	}, 
	; 294
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 233; java_name_index
	}, 
	; 295
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554754, ; type_token_id
		i32 159; java_name_index
	}, 
	; 296
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554666, ; type_token_id
		i32 109; java_name_index
	}, 
	; 297
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33555045, ; type_token_id
		i32 300; java_name_index
	}, 
	; 298
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554742, ; type_token_id
		i32 148; java_name_index
	}, 
	; 299
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33555033, ; type_token_id
		i32 290; java_name_index
	}, 
	; 300
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554635, ; type_token_id
		i32 433; java_name_index
	}, 
	; 301
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554567, ; type_token_id
		i32 376; java_name_index
	}, 
	; 302
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554847, ; type_token_id
		i32 599; java_name_index
	}, 
	; 303
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33555007, ; type_token_id
		i32 272; java_name_index
	}, 
	; 304
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 0, ; type_token_id
		i32 454; java_name_index
	}, 
	; 305
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554938, ; type_token_id
		i32 690; java_name_index
	}, 
	; 306
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554611, ; type_token_id
		i32 411; java_name_index
	}, 
	; 307
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554556, ; type_token_id
		i32 369; java_name_index
	}, 
	; 308
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554910, ; type_token_id
		i32 662; java_name_index
	}, 
	; 309
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554961, ; type_token_id
		i32 710; java_name_index
	}, 
	; 310
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554599, ; type_token_id
		i32 399; java_name_index
	}, 
	; 311
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554931, ; type_token_id
		i32 683; java_name_index
	}, 
	; 312
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33555008, ; type_token_id
		i32 273; java_name_index
	}, 
	; 313
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554662, ; type_token_id
		i32 105; java_name_index
	}, 
	; 314
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554735, ; type_token_id
		i32 145; java_name_index
	}, 
	; 315
	%struct.TypeMapJava {
		i32 15, ; module_index
		i32 33554444, ; type_token_id
		i32 742; java_name_index
	}, 
	; 316
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554607, ; type_token_id
		i32 73; java_name_index
	}, 
	; 317
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 140; java_name_index
	}, 
	; 318
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 176; java_name_index
	}, 
	; 319
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554738, ; type_token_id
		i32 506; java_name_index
	}, 
	; 320
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554914, ; type_token_id
		i32 218; java_name_index
	}, 
	; 321
	%struct.TypeMapJava {
		i32 2, ; module_index
		i32 0, ; type_token_id
		i32 10; java_name_index
	}, 
	; 322
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554718, ; type_token_id
		i32 133; java_name_index
	}, 
	; 323
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554572, ; type_token_id
		i32 379; java_name_index
	}, 
	; 324
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554617, ; type_token_id
		i32 417; java_name_index
	}, 
	; 325
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554756, ; type_token_id
		i32 161; java_name_index
	}, 
	; 326
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554818, ; type_token_id
		i32 194; java_name_index
	}, 
	; 327
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33555050, ; type_token_id
		i32 304; java_name_index
	}, 
	; 328
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554880, ; type_token_id
		i32 632; java_name_index
	}, 
	; 329
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554729, ; type_token_id
		i32 499; java_name_index
	}, 
	; 330
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 110; java_name_index
	}, 
	; 331
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554874, ; type_token_id
		i32 626; java_name_index
	}, 
	; 332
	%struct.TypeMapJava {
		i32 12, ; module_index
		i32 33554526, ; type_token_id
		i32 367; java_name_index
	}, 
	; 333
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554951, ; type_token_id
		i32 239; java_name_index
	}, 
	; 334
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554840, ; type_token_id
		i32 592; java_name_index
	}, 
	; 335
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 292; java_name_index
	}, 
	; 336
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554664, ; type_token_id
		i32 107; java_name_index
	}, 
	; 337
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 0, ; type_token_id
		i32 504; java_name_index
	}, 
	; 338
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 250; java_name_index
	}, 
	; 339
	%struct.TypeMapJava {
		i32 12, ; module_index
		i32 33554500, ; type_token_id
		i32 353; java_name_index
	}, 
	; 340
	%struct.TypeMapJava {
		i32 4, ; module_index
		i32 33554467, ; type_token_id
		i32 35; java_name_index
	}, 
	; 341
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554966, ; type_token_id
		i32 715; java_name_index
	}, 
	; 342
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554960, ; type_token_id
		i32 244; java_name_index
	}, 
	; 343
	%struct.TypeMapJava {
		i32 15, ; module_index
		i32 33554441, ; type_token_id
		i32 740; java_name_index
	}, 
	; 344
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554939, ; type_token_id
		i32 691; java_name_index
	}, 
	; 345
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554913, ; type_token_id
		i32 665; java_name_index
	}, 
	; 346
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554785, ; type_token_id
		i32 551; java_name_index
	}, 
	; 347
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554928, ; type_token_id
		i32 680; java_name_index
	}, 
	; 348
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554771, ; type_token_id
		i32 537; java_name_index
	}, 
	; 349
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 70; java_name_index
	}, 
	; 350
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554918, ; type_token_id
		i32 670; java_name_index
	}, 
	; 351
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33555086, ; type_token_id
		i32 328; java_name_index
	}, 
	; 352
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554792, ; type_token_id
		i32 558; java_name_index
	}, 
	; 353
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554866, ; type_token_id
		i32 618; java_name_index
	}, 
	; 354
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554790, ; type_token_id
		i32 179; java_name_index
	}, 
	; 355
	%struct.TypeMapJava {
		i32 4, ; module_index
		i32 33554471, ; type_token_id
		i32 39; java_name_index
	}, 
	; 356
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554746, ; type_token_id
		i32 151; java_name_index
	}, 
	; 357
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554982, ; type_token_id
		i32 731; java_name_index
	}, 
	; 358
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554780, ; type_token_id
		i32 174; java_name_index
	}, 
	; 359
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33555006, ; type_token_id
		i32 271; java_name_index
	}, 
	; 360
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554763, ; type_token_id
		i32 529; java_name_index
	}, 
	; 361
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554907, ; type_token_id
		i32 659; java_name_index
	}, 
	; 362
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554806, ; type_token_id
		i32 188; java_name_index
	}, 
	; 363
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554704, ; type_token_id
		i32 125; java_name_index
	}, 
	; 364
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 0, ; type_token_id
		i32 489; java_name_index
	}, 
	; 365
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554622, ; type_token_id
		i32 82; java_name_index
	}, 
	; 366
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554601, ; type_token_id
		i32 69; java_name_index
	}, 
	; 367
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 187; java_name_index
	}, 
	; 368
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 141; java_name_index
	}, 
	; 369
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 228; java_name_index
	}, 
	; 370
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554914, ; type_token_id
		i32 666; java_name_index
	}, 
	; 371
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 240; java_name_index
	}, 
	; 372
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554699, ; type_token_id
		i32 122; java_name_index
	}, 
	; 373
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 76; java_name_index
	}, 
	; 374
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554754, ; type_token_id
		i32 520; java_name_index
	}, 
	; 375
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554721, ; type_token_id
		i32 493; java_name_index
	}, 
	; 376
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554766, ; type_token_id
		i32 532; java_name_index
	}, 
	; 377
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554807, ; type_token_id
		i32 189; java_name_index
	}, 
	; 378
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554948, ; type_token_id
		i32 237; java_name_index
	}, 
	; 379
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554719, ; type_token_id
		i32 491; java_name_index
	}, 
	; 380
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33555069, ; type_token_id
		i32 316; java_name_index
	}, 
	; 381
	%struct.TypeMapJava {
		i32 4, ; module_index
		i32 0, ; type_token_id
		i32 40; java_name_index
	}, 
	; 382
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554809, ; type_token_id
		i32 565; java_name_index
	}, 
	; 383
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554651, ; type_token_id
		i32 445; java_name_index
	}, 
	; 384
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554819, ; type_token_id
		i32 195; java_name_index
	}, 
	; 385
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554986, ; type_token_id
		i32 734; java_name_index
	}, 
	; 386
	%struct.TypeMapJava {
		i32 6, ; module_index
		i32 33554452, ; type_token_id
		i32 49; java_name_index
	}, 
	; 387
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554775, ; type_token_id
		i32 172; java_name_index
	}, 
	; 388
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554764, ; type_token_id
		i32 530; java_name_index
	}, 
	; 389
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554745, ; type_token_id
		i32 150; java_name_index
	}, 
	; 390
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554605, ; type_token_id
		i32 405; java_name_index
	}, 
	; 391
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 0, ; type_token_id
		i32 457; java_name_index
	}, 
	; 392
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554923, ; type_token_id
		i32 675; java_name_index
	}, 
	; 393
	%struct.TypeMapJava {
		i32 1, ; module_index
		i32 33554436, ; type_token_id
		i32 3; java_name_index
	}, 
	; 394
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554770, ; type_token_id
		i32 536; java_name_index
	}, 
	; 395
	%struct.TypeMapJava {
		i32 1, ; module_index
		i32 33554437, ; type_token_id
		i32 4; java_name_index
	}, 
	; 396
	%struct.TypeMapJava {
		i32 12, ; module_index
		i32 0, ; type_token_id
		i32 348; java_name_index
	}, 
	; 397
	%struct.TypeMapJava {
		i32 2, ; module_index
		i32 0, ; type_token_id
		i32 8; java_name_index
	}, 
	; 398
	%struct.TypeMapJava {
		i32 12, ; module_index
		i32 33554510, ; type_token_id
		i32 357; java_name_index
	}, 
	; 399
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554593, ; type_token_id
		i32 394; java_name_index
	}, 
	; 400
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554919, ; type_token_id
		i32 221; java_name_index
	}, 
	; 401
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554908, ; type_token_id
		i32 660; java_name_index
	}, 
	; 402
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554997, ; type_token_id
		i32 266; java_name_index
	}, 
	; 403
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554990, ; type_token_id
		i32 261; java_name_index
	}, 
	; 404
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554590, ; type_token_id
		i32 392; java_name_index
	}, 
	; 405
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554789, ; type_token_id
		i32 555; java_name_index
	}, 
	; 406
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554634, ; type_token_id
		i32 432; java_name_index
	}, 
	; 407
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554781, ; type_token_id
		i32 175; java_name_index
	}, 
	; 408
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554825, ; type_token_id
		i32 577; java_name_index
	}, 
	; 409
	%struct.TypeMapJava {
		i32 4, ; module_index
		i32 0, ; type_token_id
		i32 42; java_name_index
	}, 
	; 410
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554876, ; type_token_id
		i32 628; java_name_index
	}, 
	; 411
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554842, ; type_token_id
		i32 594; java_name_index
	}, 
	; 412
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 313; java_name_index
	}, 
	; 413
	%struct.TypeMapJava {
		i32 15, ; module_index
		i32 0, ; type_token_id
		i32 739; java_name_index
	}, 
	; 414
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554733, ; type_token_id
		i32 502; java_name_index
	}, 
	; 415
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 287; java_name_index
	}, 
	; 416
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554642, ; type_token_id
		i32 440; java_name_index
	}, 
	; 417
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554603, ; type_token_id
		i32 403; java_name_index
	}, 
	; 418
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554894, ; type_token_id
		i32 646; java_name_index
	}, 
	; 419
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554909, ; type_token_id
		i32 661; java_name_index
	}, 
	; 420
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554947, ; type_token_id
		i32 698; java_name_index
	}, 
	; 421
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 0, ; type_token_id
		i32 443; java_name_index
	}, 
	; 422
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33555015, ; type_token_id
		i32 279; java_name_index
	}, 
	; 423
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554785, ; type_token_id
		i32 178; java_name_index
	}, 
	; 424
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554890, ; type_token_id
		i32 642; java_name_index
	}, 
	; 425
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33555057, ; type_token_id
		i32 309; java_name_index
	}, 
	; 426
	%struct.TypeMapJava {
		i32 2, ; module_index
		i32 0, ; type_token_id
		i32 18; java_name_index
	}, 
	; 427
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554710, ; type_token_id
		i32 127; java_name_index
	}, 
	; 428
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554995, ; type_token_id
		i32 264; java_name_index
	}, 
	; 429
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554971, ; type_token_id
		i32 720; java_name_index
	}, 
	; 430
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 183; java_name_index
	}, 
	; 431
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554776, ; type_token_id
		i32 542; java_name_index
	}, 
	; 432
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 68; java_name_index
	}, 
	; 433
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554790, ; type_token_id
		i32 556; java_name_index
	}, 
	; 434
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554757, ; type_token_id
		i32 523; java_name_index
	}, 
	; 435
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554701, ; type_token_id
		i32 478; java_name_index
	}, 
	; 436
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 251; java_name_index
	}, 
	; 437
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554656, ; type_token_id
		i32 450; java_name_index
	}, 
	; 438
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 192; java_name_index
	}, 
	; 439
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554607, ; type_token_id
		i32 407; java_name_index
	}, 
	; 440
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 85; java_name_index
	}, 
	; 441
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 0, ; type_token_id
		i32 564; java_name_index
	}, 
	; 442
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33555072, ; type_token_id
		i32 319; java_name_index
	}, 
	; 443
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554954, ; type_token_id
		i32 241; java_name_index
	}, 
	; 444
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554609, ; type_token_id
		i32 409; java_name_index
	}, 
	; 445
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554981, ; type_token_id
		i32 730; java_name_index
	}, 
	; 446
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 0, ; type_token_id
		i32 384; java_name_index
	}, 
	; 447
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554954, ; type_token_id
		i32 705; java_name_index
	}, 
	; 448
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554782, ; type_token_id
		i32 548; java_name_index
	}, 
	; 449
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 149; java_name_index
	}, 
	; 450
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554899, ; type_token_id
		i32 211; java_name_index
	}, 
	; 451
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554786, ; type_token_id
		i32 552; java_name_index
	}, 
	; 452
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554767, ; type_token_id
		i32 533; java_name_index
	}, 
	; 453
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554944, ; type_token_id
		i32 695; java_name_index
	}, 
	; 454
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 185; java_name_index
	}, 
	; 455
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554978, ; type_token_id
		i32 727; java_name_index
	}, 
	; 456
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 0, ; type_token_id
		i32 494; java_name_index
	}, 
	; 457
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554822, ; type_token_id
		i32 198; java_name_index
	}, 
	; 458
	%struct.TypeMapJava {
		i32 12, ; module_index
		i32 33554495, ; type_token_id
		i32 350; java_name_index
	}, 
	; 459
	%struct.TypeMapJava {
		i32 2, ; module_index
		i32 33554502, ; type_token_id
		i32 27; java_name_index
	}, 
	; 460
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554606, ; type_token_id
		i32 406; java_name_index
	}, 
	; 461
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554630, ; type_token_id
		i32 428; java_name_index
	}, 
	; 462
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33555082, ; type_token_id
		i32 325; java_name_index
	}, 
	; 463
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554747, ; type_token_id
		i32 152; java_name_index
	}, 
	; 464
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 57; java_name_index
	}, 
	; 465
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554648, ; type_token_id
		i32 444; java_name_index
	}, 
	; 466
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554886, ; type_token_id
		i32 638; java_name_index
	}, 
	; 467
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 75; java_name_index
	}, 
	; 468
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554663, ; type_token_id
		i32 106; java_name_index
	}, 
	; 469
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33555003, ; type_token_id
		i32 270; java_name_index
	}, 
	; 470
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554613, ; type_token_id
		i32 77; java_name_index
	}, 
	; 471
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554666, ; type_token_id
		i32 456; java_name_index
	}, 
	; 472
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554763, ; type_token_id
		i32 166; java_name_index
	}, 
	; 473
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554728, ; type_token_id
		i32 498; java_name_index
	}, 
	; 474
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554917, ; type_token_id
		i32 669; java_name_index
	}, 
	; 475
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554759, ; type_token_id
		i32 525; java_name_index
	}, 
	; 476
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554991, ; type_token_id
		i32 262; java_name_index
	}, 
	; 477
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554779, ; type_token_id
		i32 545; java_name_index
	}, 
	; 478
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33555019, ; type_token_id
		i32 282; java_name_index
	}, 
	; 479
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554821, ; type_token_id
		i32 574; java_name_index
	}, 
	; 480
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554925, ; type_token_id
		i32 677; java_name_index
	}, 
	; 481
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554980, ; type_token_id
		i32 729; java_name_index
	}, 
	; 482
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554791, ; type_token_id
		i32 557; java_name_index
	}, 
	; 483
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554857, ; type_token_id
		i32 609; java_name_index
	}, 
	; 484
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554942, ; type_token_id
		i32 693; java_name_index
	}, 
	; 485
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554781, ; type_token_id
		i32 547; java_name_index
	}, 
	; 486
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554787, ; type_token_id
		i32 553; java_name_index
	}, 
	; 487
	%struct.TypeMapJava {
		i32 2, ; module_index
		i32 0, ; type_token_id
		i32 31; java_name_index
	}, 
	; 488
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554640, ; type_token_id
		i32 438; java_name_index
	}, 
	; 489
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554719, ; type_token_id
		i32 134; java_name_index
	}, 
	; 490
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554834, ; type_token_id
		i32 586; java_name_index
	}, 
	; 491
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554665, ; type_token_id
		i32 455; java_name_index
	}, 
	; 492
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554888, ; type_token_id
		i32 640; java_name_index
	}, 
	; 493
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554624, ; type_token_id
		i32 84; java_name_index
	}, 
	; 494
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 0, ; type_token_id
		i32 486; java_name_index
	}, 
	; 495
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554826, ; type_token_id
		i32 578; java_name_index
	}, 
	; 496
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554793, ; type_token_id
		i32 559; java_name_index
	}, 
	; 497
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554716, ; type_token_id
		i32 132; java_name_index
	}, 
	; 498
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 224; java_name_index
	}, 
	; 499
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 217; java_name_index
	}, 
	; 500
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554905, ; type_token_id
		i32 657; java_name_index
	}, 
	; 501
	%struct.TypeMapJava {
		i32 2, ; module_index
		i32 33554465, ; type_token_id
		i32 7; java_name_index
	}, 
	; 502
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554616, ; type_token_id
		i32 79; java_name_index
	}, 
	; 503
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554958, ; type_token_id
		i32 708; java_name_index
	}, 
	; 504
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554821, ; type_token_id
		i32 197; java_name_index
	}, 
	; 505
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554749, ; type_token_id
		i32 154; java_name_index
	}, 
	; 506
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 0, ; type_token_id
		i32 516; java_name_index
	}, 
	; 507
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 190; java_name_index
	}, 
	; 508
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 0, ; type_token_id
		i32 501; java_name_index
	}, 
	; 509
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 94; java_name_index
	}, 
	; 510
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 186; java_name_index
	}, 
	; 511
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554751, ; type_token_id
		i32 156; java_name_index
	}, 
	; 512
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554626, ; type_token_id
		i32 424; java_name_index
	}, 
	; 513
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554681, ; type_token_id
		i32 464; java_name_index
	}, 
	; 514
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554637, ; type_token_id
		i32 91; java_name_index
	}, 
	; 515
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 129; java_name_index
	}, 
	; 516
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554756, ; type_token_id
		i32 522; java_name_index
	}, 
	; 517
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33555018, ; type_token_id
		i32 281; java_name_index
	}, 
	; 518
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554632, ; type_token_id
		i32 430; java_name_index
	}, 
	; 519
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554638, ; type_token_id
		i32 436; java_name_index
	}, 
	; 520
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554741, ; type_token_id
		i32 509; java_name_index
	}, 
	; 521
	%struct.TypeMapJava {
		i32 12, ; module_index
		i32 33554474, ; type_token_id
		i32 339; java_name_index
	}, 
	; 522
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554929, ; type_token_id
		i32 681; java_name_index
	}, 
	; 523
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554748, ; type_token_id
		i32 153; java_name_index
	}, 
	; 524
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554830, ; type_token_id
		i32 582; java_name_index
	}, 
	; 525
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554937, ; type_token_id
		i32 689; java_name_index
	}, 
	; 526
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 200; java_name_index
	}, 
	; 527
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554795, ; type_token_id
		i32 561; java_name_index
	}, 
	; 528
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33555115, ; type_token_id
		i32 332; java_name_index
	}, 
	; 529
	%struct.TypeMapJava {
		i32 3, ; module_index
		i32 0, ; type_token_id
		i32 34; java_name_index
	}, 
	; 530
	%struct.TypeMapJava {
		i32 12, ; module_index
		i32 33554475, ; type_token_id
		i32 340; java_name_index
	}, 
	; 531
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554665, ; type_token_id
		i32 108; java_name_index
	}, 
	; 532
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554558, ; type_token_id
		i32 370; java_name_index
	}, 
	; 533
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554815, ; type_token_id
		i32 570; java_name_index
	}, 
	; 534
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554758, ; type_token_id
		i32 524; java_name_index
	}, 
	; 535
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33555089, ; type_token_id
		i32 330; java_name_index
	}, 
	; 536
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554916, ; type_token_id
		i32 668; java_name_index
	}, 
	; 537
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554778, ; type_token_id
		i32 544; java_name_index
	}, 
	; 538
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 230; java_name_index
	}, 
	; 539
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554883, ; type_token_id
		i32 635; java_name_index
	}, 
	; 540
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554988, ; type_token_id
		i32 736; java_name_index
	}, 
	; 541
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554889, ; type_token_id
		i32 641; java_name_index
	}, 
	; 542
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554740, ; type_token_id
		i32 508; java_name_index
	}, 
	; 543
	%struct.TypeMapJava {
		i32 12, ; module_index
		i32 33554489, ; type_token_id
		i32 346; java_name_index
	}, 
	; 544
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554715, ; type_token_id
		i32 131; java_name_index
	}, 
	; 545
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33555073, ; type_token_id
		i32 320; java_name_index
	}, 
	; 546
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554820, ; type_token_id
		i32 573; java_name_index
	}, 
	; 547
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554962, ; type_token_id
		i32 245; java_name_index
	}, 
	; 548
	%struct.TypeMapJava {
		i32 12, ; module_index
		i32 33554525, ; type_token_id
		i32 366; java_name_index
	}, 
	; 549
	%struct.TypeMapJava {
		i32 12, ; module_index
		i32 0, ; type_token_id
		i32 362; java_name_index
	}, 
	; 550
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554878, ; type_token_id
		i32 630; java_name_index
	}, 
	; 551
	%struct.TypeMapJava {
		i32 0, ; module_index
		i32 33554461, ; type_token_id
		i32 2; java_name_index
	}, 
	; 552
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554892, ; type_token_id
		i32 644; java_name_index
	}, 
	; 553
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 139; java_name_index
	}, 
	; 554
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 216; java_name_index
	}, 
	; 555
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 80; java_name_index
	}, 
	; 556
	%struct.TypeMapJava {
		i32 12, ; module_index
		i32 0, ; type_token_id
		i32 354; java_name_index
	}, 
	; 557
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554652, ; type_token_id
		i32 99; java_name_index
	}, 
	; 558
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554974, ; type_token_id
		i32 723; java_name_index
	}, 
	; 559
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 98; java_name_index
	}, 
	; 560
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 0, ; type_token_id
		i32 517; java_name_index
	}, 
	; 561
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554674, ; type_token_id
		i32 460; java_name_index
	}, 
	; 562
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554555, ; type_token_id
		i32 368; java_name_index
	}, 
	; 563
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554745, ; type_token_id
		i32 513; java_name_index
	}, 
	; 564
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 323; java_name_index
	}, 
	; 565
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 90; java_name_index
	}, 
	; 566
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554610, ; type_token_id
		i32 410; java_name_index
	}, 
	; 567
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554737, ; type_token_id
		i32 505; java_name_index
	}, 
	; 568
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554865, ; type_token_id
		i32 617; java_name_index
	}, 
	; 569
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554833, ; type_token_id
		i32 585; java_name_index
	}, 
	; 570
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554679, ; type_token_id
		i32 116; java_name_index
	}, 
	; 571
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 59; java_name_index
	}, 
	; 572
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554838, ; type_token_id
		i32 590; java_name_index
	}, 
	; 573
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554989, ; type_token_id
		i32 260; java_name_index
	}, 
	; 574
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554863, ; type_token_id
		i32 615; java_name_index
	}, 
	; 575
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554580, ; type_token_id
		i32 383; java_name_index
	}, 
	; 576
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 322; java_name_index
	}, 
	; 577
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554920, ; type_token_id
		i32 672; java_name_index
	}, 
	; 578
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554566, ; type_token_id
		i32 375; java_name_index
	}, 
	; 579
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554703, ; type_token_id
		i32 480; java_name_index
	}, 
	; 580
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554952, ; type_token_id
		i32 703; java_name_index
	}, 
	; 581
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554896, ; type_token_id
		i32 209; java_name_index
	}, 
	; 582
	%struct.TypeMapJava {
		i32 2, ; module_index
		i32 33554493, ; type_token_id
		i32 21; java_name_index
	}, 
	; 583
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554941, ; type_token_id
		i32 692; java_name_index
	}, 
	; 584
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554968, ; type_token_id
		i32 717; java_name_index
	}, 
	; 585
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554569, ; type_token_id
		i32 56; java_name_index
	}, 
	; 586
	%struct.TypeMapJava {
		i32 2, ; module_index
		i32 0, ; type_token_id
		i32 23; java_name_index
	}, 
	; 587
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554700, ; type_token_id
		i32 477; java_name_index
	}, 
	; 588
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33555041, ; type_token_id
		i32 297; java_name_index
	}, 
	; 589
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554561, ; type_token_id
		i32 51; java_name_index
	}, 
	; 590
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 193; java_name_index
	}, 
	; 591
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554960, ; type_token_id
		i32 709; java_name_index
	}, 
	; 592
	%struct.TypeMapJava {
		i32 12, ; module_index
		i32 33554479, ; type_token_id
		i32 342; java_name_index
	}, 
	; 593
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554684, ; type_token_id
		i32 467; java_name_index
	}, 
	; 594
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554744, ; type_token_id
		i32 512; java_name_index
	}, 
	; 595
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554934, ; type_token_id
		i32 686; java_name_index
	}, 
	; 596
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554739, ; type_token_id
		i32 507; java_name_index
	}, 
	; 597
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554837, ; type_token_id
		i32 589; java_name_index
	}, 
	; 598
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554623, ; type_token_id
		i32 422; java_name_index
	}, 
	; 599
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33555000, ; type_token_id
		i32 269; java_name_index
	}, 
	; 600
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554873, ; type_token_id
		i32 625; java_name_index
	}, 
	; 601
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554692, ; type_token_id
		i32 473; java_name_index
	}, 
	; 602
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554641, ; type_token_id
		i32 439; java_name_index
	}, 
	; 603
	%struct.TypeMapJava {
		i32 2, ; module_index
		i32 0, ; type_token_id
		i32 14; java_name_index
	}, 
	; 604
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 0, ; type_token_id
		i32 495; java_name_index
	}, 
	; 605
	%struct.TypeMapJava {
		i32 12, ; module_index
		i32 33554516, ; type_token_id
		i32 361; java_name_index
	}, 
	; 606
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554867, ; type_token_id
		i32 205; java_name_index
	}, 
	; 607
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554946, ; type_token_id
		i32 697; java_name_index
	}, 
	; 608
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554917, ; type_token_id
		i32 220; java_name_index
	}, 
	; 609
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554614, ; type_token_id
		i32 414; java_name_index
	}, 
	; 610
	%struct.TypeMapJava {
		i32 14, ; module_index
		i32 0, ; type_token_id
		i32 737; java_name_index
	}, 
	; 611
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554933, ; type_token_id
		i32 685; java_name_index
	}, 
	; 612
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554696, ; type_token_id
		i32 476; java_name_index
	}, 
	; 613
	%struct.TypeMapJava {
		i32 12, ; module_index
		i32 33554482, ; type_token_id
		i32 344; java_name_index
	}, 
	; 614
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554927, ; type_token_id
		i32 679; java_name_index
	}, 
	; 615
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 227; java_name_index
	}, 
	; 616
	%struct.TypeMapJava {
		i32 12, ; module_index
		i32 0, ; type_token_id
		i32 345; java_name_index
	}, 
	; 617
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554675, ; type_token_id
		i32 461; java_name_index
	}, 
	; 618
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554869, ; type_token_id
		i32 621; java_name_index
	}, 
	; 619
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554975, ; type_token_id
		i32 724; java_name_index
	}, 
	; 620
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554628, ; type_token_id
		i32 426; java_name_index
	}, 
	; 621
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554879, ; type_token_id
		i32 631; java_name_index
	}, 
	; 622
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554656, ; type_token_id
		i32 102; java_name_index
	}, 
	; 623
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33555048, ; type_token_id
		i32 303; java_name_index
	}, 
	; 624
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554987, ; type_token_id
		i32 258; java_name_index
	}, 
	; 625
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554794, ; type_token_id
		i32 560; java_name_index
	}, 
	; 626
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554703, ; type_token_id
		i32 124; java_name_index
	}, 
	; 627
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554817, ; type_token_id
		i32 571; java_name_index
	}, 
	; 628
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554652, ; type_token_id
		i32 446; java_name_index
	}, 
	; 629
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554865, ; type_token_id
		i32 204; java_name_index
	}, 
	; 630
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554620, ; type_token_id
		i32 81; java_name_index
	}, 
	; 631
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554658, ; type_token_id
		i32 452; java_name_index
	}, 
	; 632
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554861, ; type_token_id
		i32 613; java_name_index
	}, 
	; 633
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33555014, ; type_token_id
		i32 278; java_name_index
	}, 
	; 634
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 118; java_name_index
	}, 
	; 635
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554720, ; type_token_id
		i32 135; java_name_index
	}, 
	; 636
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554583, ; type_token_id
		i32 385; java_name_index
	}, 
	; 637
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554567, ; type_token_id
		i32 55; java_name_index
	}, 
	; 638
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554852, ; type_token_id
		i32 604; java_name_index
	}, 
	; 639
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554988, ; type_token_id
		i32 259; java_name_index
	}, 
	; 640
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554615, ; type_token_id
		i32 415; java_name_index
	}, 
	; 641
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554843, ; type_token_id
		i32 595; java_name_index
	}, 
	; 642
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554810, ; type_token_id
		i32 566; java_name_index
	}, 
	; 643
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 0, ; type_token_id
		i32 474; java_name_index
	}, 
	; 644
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554884, ; type_token_id
		i32 636; java_name_index
	}, 
	; 645
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 167; java_name_index
	}, 
	; 646
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554829, ; type_token_id
		i32 581; java_name_index
	}, 
	; 647
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554750, ; type_token_id
		i32 155; java_name_index
	}, 
	; 648
	%struct.TypeMapJava {
		i32 0, ; module_index
		i32 0, ; type_token_id
		i32 1; java_name_index
	}, 
	; 649
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554683, ; type_token_id
		i32 119; java_name_index
	}, 
	; 650
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554898, ; type_token_id
		i32 210; java_name_index
	}, 
	; 651
	%struct.TypeMapJava {
		i32 11, ; module_index
		i32 0, ; type_token_id
		i32 337; java_name_index
	}, 
	; 652
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554768, ; type_token_id
		i32 534; java_name_index
	}, 
	; 653
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554823, ; type_token_id
		i32 576; java_name_index
	}, 
	; 654
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554783, ; type_token_id
		i32 549; java_name_index
	}, 
	; 655
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554902, ; type_token_id
		i32 654; java_name_index
	}, 
	; 656
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554950, ; type_token_id
		i32 701; java_name_index
	}, 
	; 657
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554740, ; type_token_id
		i32 147; java_name_index
	}, 
	; 658
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554906, ; type_token_id
		i32 658; java_name_index
	}, 
	; 659
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554777, ; type_token_id
		i32 543; java_name_index
	}, 
	; 660
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554921, ; type_token_id
		i32 673; java_name_index
	}, 
	; 661
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 62; java_name_index
	}, 
	; 662
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554901, ; type_token_id
		i32 653; java_name_index
	}, 
	; 663
	%struct.TypeMapJava {
		i32 12, ; module_index
		i32 33554512, ; type_token_id
		i32 359; java_name_index
	}, 
	; 664
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554621, ; type_token_id
		i32 421; java_name_index
	}, 
	; 665
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554753, ; type_token_id
		i32 158; java_name_index
	}, 
	; 666
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33555009, ; type_token_id
		i32 274; java_name_index
	}, 
	; 667
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554850, ; type_token_id
		i32 602; java_name_index
	}, 
	; 668
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 104; java_name_index
	}, 
	; 669
	%struct.TypeMapJava {
		i32 2, ; module_index
		i32 33554503, ; type_token_id
		i32 28; java_name_index
	}, 
	; 670
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33555080, ; type_token_id
		i32 324; java_name_index
	}, 
	; 671
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554896, ; type_token_id
		i32 648; java_name_index
	}, 
	; 672
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554943, ; type_token_id
		i32 234; java_name_index
	}, 
	; 673
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554953, ; type_token_id
		i32 704; java_name_index
	}, 
	; 674
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 86; java_name_index
	}, 
	; 675
	%struct.TypeMapJava {
		i32 4, ; module_index
		i32 33554469, ; type_token_id
		i32 37; java_name_index
	}, 
	; 676
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 231; java_name_index
	}, 
	; 677
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554759, ; type_token_id
		i32 164; java_name_index
	}, 
	; 678
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554706, ; type_token_id
		i32 483; java_name_index
	}, 
	; 679
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554899, ; type_token_id
		i32 651; java_name_index
	}, 
	; 680
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554614, ; type_token_id
		i32 78; java_name_index
	}, 
	; 681
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554847, ; type_token_id
		i32 199; java_name_index
	}, 
	; 682
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 0, ; type_token_id
		i32 393; java_name_index
	}, 
	; 683
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554730, ; type_token_id
		i32 500; java_name_index
	}, 
	; 684
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554585, ; type_token_id
		i32 65; java_name_index
	}, 
	; 685
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554844, ; type_token_id
		i32 596; java_name_index
	}, 
	; 686
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554588, ; type_token_id
		i32 390; java_name_index
	}, 
	; 687
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554601, ; type_token_id
		i32 401; java_name_index
	}, 
	; 688
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 0, ; type_token_id
		i32 462; java_name_index
	}, 
	; 689
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554795, ; type_token_id
		i32 182; java_name_index
	}, 
	; 690
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554619, ; type_token_id
		i32 419; java_name_index
	}, 
	; 691
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554752, ; type_token_id
		i32 157; java_name_index
	}, 
	; 692
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554655, ; type_token_id
		i32 449; java_name_index
	}, 
	; 693
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33555017, ; type_token_id
		i32 280; java_name_index
	}, 
	; 694
	%struct.TypeMapJava {
		i32 2, ; module_index
		i32 33554479, ; type_token_id
		i32 12; java_name_index
	}, 
	; 695
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554784, ; type_token_id
		i32 177; java_name_index
	}, 
	; 696
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 123; java_name_index
	}, 
	; 697
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554631, ; type_token_id
		i32 429; java_name_index
	}, 
	; 698
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554832, ; type_token_id
		i32 584; java_name_index
	}, 
	; 699
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 184; java_name_index
	}, 
	; 700
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554858, ; type_token_id
		i32 610; java_name_index
	}, 
	; 701
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554695, ; type_token_id
		i32 475; java_name_index
	}, 
	; 702
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554793, ; type_token_id
		i32 181; java_name_index
	}, 
	; 703
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33555039, ; type_token_id
		i32 295; java_name_index
	}, 
	; 704
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554714, ; type_token_id
		i32 130; java_name_index
	}, 
	; 705
	%struct.TypeMapJava {
		i32 15, ; module_index
		i32 0, ; type_token_id
		i32 738; java_name_index
	}, 
	; 706
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554956, ; type_token_id
		i32 242; java_name_index
	}, 
	; 707
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554669, ; type_token_id
		i32 111; java_name_index
	}, 
	; 708
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33555090, ; type_token_id
		i32 331; java_name_index
	}, 
	; 709
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33555052, ; type_token_id
		i32 305; java_name_index
	}, 
	; 710
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554682, ; type_token_id
		i32 465; java_name_index
	}, 
	; 711
	%struct.TypeMapJava {
		i32 6, ; module_index
		i32 0, ; type_token_id
		i32 47; java_name_index
	}, 
	; 712
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554612, ; type_token_id
		i32 412; java_name_index
	}, 
	; 713
	%struct.TypeMapJava {
		i32 1, ; module_index
		i32 0, ; type_token_id
		i32 5; java_name_index
	}, 
	; 714
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 93; java_name_index
	}, 
	; 715
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554733, ; type_token_id
		i32 143; java_name_index
	}, 
	; 716
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554704, ; type_token_id
		i32 481; java_name_index
	}, 
	; 717
	%struct.TypeMapJava {
		i32 6, ; module_index
		i32 0, ; type_token_id
		i32 50; java_name_index
	}, 
	; 718
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554585, ; type_token_id
		i32 387; java_name_index
	}, 
	; 719
	%struct.TypeMapJava {
		i32 2, ; module_index
		i32 33554501, ; type_token_id
		i32 26; java_name_index
	}, 
	; 720
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554587, ; type_token_id
		i32 66; java_name_index
	}, 
	; 721
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33555083, ; type_token_id
		i32 326; java_name_index
	}, 
	; 722
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33555058, ; type_token_id
		i32 310; java_name_index
	}, 
	; 723
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554895, ; type_token_id
		i32 647; java_name_index
	}, 
	; 724
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554963, ; type_token_id
		i32 712; java_name_index
	}, 
	; 725
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554965, ; type_token_id
		i32 714; java_name_index
	}, 
	; 726
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554685, ; type_token_id
		i32 468; java_name_index
	}, 
	; 727
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554935, ; type_token_id
		i32 687; java_name_index
	}, 
	; 728
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554868, ; type_token_id
		i32 206; java_name_index
	}, 
	; 729
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554835, ; type_token_id
		i32 587; java_name_index
	}, 
	; 730
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 142; java_name_index
	}, 
	; 731
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 89; java_name_index
	}, 
	; 732
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554859, ; type_token_id
		i32 611; java_name_index
	}, 
	; 733
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 87; java_name_index
	}, 
	; 734
	%struct.TypeMapJava {
		i32 2, ; module_index
		i32 0, ; type_token_id
		i32 25; java_name_index
	}, 
	; 735
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 226; java_name_index
	}, 
	; 736
	%struct.TypeMapJava {
		i32 4, ; module_index
		i32 33554474, ; type_token_id
		i32 41; java_name_index
	}, 
	; 737
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554757, ; type_token_id
		i32 162; java_name_index
	}, 
	; 738
	%struct.TypeMapJava {
		i32 15, ; module_index
		i32 0, ; type_token_id
		i32 741; java_name_index
	}, 
	; 739
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554860, ; type_token_id
		i32 612; java_name_index
	}, 
	; 740
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 321; java_name_index
	}, 
	; 741
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554589, ; type_token_id
		i32 391; java_name_index
	}, 
	; 742
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554856, ; type_token_id
		i32 608; java_name_index
	}
], align 4; end of 'map_java' array

@map_java_hashes = local_unnamed_addr constant [743 x i32] [
	i32 4689355, ; 0: 0x478dcb => android/animation/Animator$AnimatorListener
	i32 12341354, ; 1: 0xbc506a => java/lang/Object
	i32 13389226, ; 2: 0xcc4daa => java/lang/reflect/GenericDeclaration
	i32 17702982, ; 3: 0x10e2046 => androidx/fragment/app/Fragment
	i32 22566843, ; 4: 0x15857bb => br/com/itfast/tectoy/TecToyReconhecimentoFacialCallback
	i32 25586197, ; 5: 0x1866a15 => br/com/daruma/framework/mobile/gne/nfce/xml/classes/Icms51Auxiliar
	i32 32078366, ; 6: 0x1e97a1e => java/security/cert/Certificate
	i32 43790167, ; 7: 0x29c2f57 => br/com/daruma/framework/mobile/gne/nfce/xml/classes/PROCREF
	i32 74282880, ; 8: 0x46d7780 => android/view/ViewGroup
	i32 88538713, ; 9: 0x546fe59 => br/com/daruma/framework/mobile/gne/nfce/xml/classes/DF
	i32 93713301, ; 10: 0x595f395 => com/orbbec/astra/HandPoseInfo
	i32 93794063, ; 11: 0x5972f0f => br/com/daruma/framework/mobile/gne/nfce/xml/classes/Icms40Auxiliar
	i32 102292193, ; 12: 0x618dae1 => androidx/appcompat/widget/DecorToolbar
	i32 115434628, ; 13: 0x6e16484 => com/orbbec/astra/CoordinateMapper
	i32 118977103, ; 14: 0x717724f => android/util/DisplayMetrics
	i32 133154022, ; 15: 0x7efc4e6 => java/nio/channels/SeekableByteChannel
	i32 133807792, ; 16: 0x7f9beb0 => br/com/daruma/framework/mobile/camera/dependencies/FinishListener
	i32 138171443, ; 17: 0x83c5433 => javax/net/ssl/SSLSessionContext
	i32 139280357, ; 18: 0x84d3fe5 => android/view/KeyEvent
	i32 143630783, ; 19: 0x88fa1bf => br/com/daruma/framework/mobile/camera/dependencies/DecodeAsyncTask
	i32 151062962, ; 20: 0x90109b2 => java/lang/reflect/TypeVariable
	i32 158254429, ; 21: 0x96ec55d => mono/androidx/fragment/app/FragmentManager_OnBackStackChangedListenerImplementor
	i32 163388176, ; 22: 0x9bd1b10 => br/com/itfast/tectoy/StatusImpressora
	i32 172105249, ; 23: 0xa421e21 => com/phi/gertec/sat/serial/CdcAcmSerialDriver$CdcAcmSerialPort
	i32 176697843, ; 24: 0xa8831f3 => java/lang/IllegalArgumentException
	i32 178346187, ; 25: 0xaa158cb => android/window/OnBackInvokedCallback
	i32 182338948, ; 26: 0xade4584 => java/nio/channels/Channel
	i32 228925694, ; 27: 0xda520fe => com/phi/gertec/sat/satger/SatGerLib$OnDataReceived
	i32 229694295, ; 28: 0xdb0db57 => java/nio/channels/WritableByteChannel
	i32 230888512, ; 29: 0xdc31440 => com/orbbec/astra/android/AstraAndroidContext
	i32 249587326, ; 30: 0xee0667e => br/com/itfast/tectoy/Dispositivo
	i32 253900201, ; 31: 0xf2235a9 => br/com/daruma/framework/mobile/gne/nfce/xml/classes/AL
	i32 254335391, ; 32: 0xf28d99f => com/orbbec/astra/UsbDeviceInfo
	i32 254972370, ; 33: 0xf3291d2 => br/com/daruma/framework/mobile/camera/dependencies/ViewfinderView
	i32 257094054, ; 34: 0xf52f1a6 => java/lang/ReflectiveOperationException
	i32 268673672, ; 35: 0x1003a288 => android/view/accessibility/AccessibilityEventSource
	i32 269199815, ; 36: 0x100ba9c7 => javax/security/cert/X509Certificate
	i32 279693177, ; 37: 0x10abc779 => android/content/SharedPreferences$Editor
	i32 281127175, ; 38: 0x10c1a907 => java/util/function/Function
	i32 282942581, ; 39: 0x10dd5c75 => br/com/daruma/framework/mobile/gne/nfce/xml/classes/PA
	i32 285670019, ; 40: 0x1106fa83 => com/orbbec/astra/Joint
	i32 292930755, ; 41: 0x1175c4c3 => androidx/loader/content/Loader$OnLoadCompleteListener
	i32 299354407, ; 42: 0x11d7c927 => androidx/savedstate/SavedStateRegistry
	i32 307048059, ; 43: 0x124d2e7b => android/view/MenuItem$OnActionExpandListener
	i32 317135051, ; 44: 0x12e718cb => android/animation/Animator
	i32 344269398, ; 45: 0x14852256 => com/phi/gertec/sat/satger/BuildConfig
	i32 346567174, ; 46: 0x14a83206 => br/com/daruma/framework/mobile/gne/nfce/xml/classes/Email
	i32 352910809, ; 47: 0x1508fdd9 => com/sunmi/peripheral/printer/InnerPrinterManager
	i32 362231028, ; 48: 0x159734f4 => java/net/URI
	i32 366534601, ; 49: 0x15d8dfc9 => android/view/ViewGroup$LayoutParams
	i32 374066447, ; 50: 0x164bcd0f => br/com/daruma/framework/mobile/sat/impostos/Pisqtde
	i32 377193079, ; 51: 0x167b8277 => br/com/daruma/framework/mobile/gne/nfse/xml/Objetos
	i32 382428297, ; 52: 0x16cb6489 => br/com/daruma/framework/mobile/constantes/IConstantesComunicacao
	i32 385900712, ; 53: 0x170060a8 => br/com/daruma/framework/mobile/gne/nfce/xml/classes/MA
	i32 393371378, ; 54: 0x17725ef2 => mono/java/lang/RunnableImplementor
	i32 394430605, ; 55: 0x1782888d => br/com/daruma/framework/mobile/gne/nfce/xml/classes/ElementosXMlInutilizacao
	i32 396570040, ; 56: 0x17a32db8 => androidx/lifecycle/LifecycleOwner
	i32 399364059, ; 57: 0x17cdcfdb => android/animation/TimeInterpolator
	i32 412395228, ; 58: 0x1894a6dc => java/security/KeyStore$LoadStoreParameter
	i32 412771173, ; 59: 0x189a6365 => java/lang/Long
	i32 419137735, ; 60: 0x18fb88c7 => br/com/daruma/framework/mobile/gne/sat/EPSON
	i32 419359493, ; 61: 0x18feeb05 => java/util/Iterator
	i32 420482824, ; 62: 0x19100f08 => java/net/ConnectException
	i32 424391913, ; 63: 0x194bb4e9 => java/lang/ClassLoader
	i32 426128113, ; 64: 0x196632f1 => com/orbbec/astra/Body
	i32 438182643, ; 65: 0x1a1e22f3 => br/com/daruma/framework/mobile/gne/nfce/xml/classes/Icms00Auxiliar
	i32 441688866, ; 66: 0x1a53a322 => androidx/fragment/app/FragmentFactory
	i32 441749763, ; 67: 0x1a549103 => androidx/appcompat/widget/ScrollingTabContainerView$VisibilityAnimListener
	i32 443233435, ; 68: 0x1a6b349b => java/lang/LinkageError
	i32 444461149, ; 69: 0x1a7df05d => br/com/daruma/framework/mobile/sat/impostos/Cofinsnt
	i32 444630889, ; 70: 0x1a808769 => br/com/daruma/framework/mobile/gne/sat/Sat
	i32 454762680, ; 71: 0x1b1b20b8 => br/com/daruma/framework/mobile/exception/DarumaECFException
	i32 462081542, ; 72: 0x1b8ace06 => br/com/daruma/framework/mobile/gne/nfce/xml/classes/SP
	i32 463824038, ; 73: 0x1ba564a6 => br/com/daruma/framework/mobile/exception/DarumaException
	i32 466997013, ; 74: 0x1bd5cf15 => java/lang/reflect/AnnotatedElement
	i32 490619983, ; 75: 0x1d3e444f => java/util/concurrent/TimeUnit
	i32 495226637, ; 76: 0x1d848f0d => br/com/daruma/framework/mobile/gne/nfce/xml/classes/RO
	i32 496795288, ; 77: 0x1d9c7e98 => br/com/daruma/framework/mobile/gne/nfce/xml/classes/MS
	i32 501733478, ; 78: 0x1de7d866 => android/view/ViewGroup$MarginLayoutParams
	i32 509491678, ; 79: 0x1e5e39de => android/view/LayoutInflater$Factory
	i32 515743647, ; 80: 0x1ebd9f9f => com/orbbec/astra/MaskedColorStream
	i32 517025718, ; 81: 0x1ed12fb6 => android/view/ViewParent
	i32 517668398, ; 82: 0x1edafe2e => android/os/Parcel
	i32 528618783, ; 83: 0x1f82151f => br/com/daruma/framework/mobile/webservice/TrustedManagerManipulator
	i32 528635415, ; 84: 0x1f825617 => br/com/daruma/framework/mobile/gne/nfce/xml/classes/CofinsQtdeAuxiliar
	i32 531198748, ; 85: 0x1fa9731c => mono/android/runtime/OutputStreamAdapter
	i32 540032024, ; 86: 0x20303c18 => com/hoho/android/usbserial/driver/CdcAcmSerialDriver$CdcAcmSerialPort
	i32 548149059, ; 87: 0x20ac1743 => com/phi/gertec/sat/serial/ProbeTable
	i32 557419239, ; 88: 0x21398ae7 => com/orbbec/astra/BodyFrameInfo
	i32 566351313, ; 89: 0x21c1d5d1 => com/orbbec/astra/PointStream
	i32 567541104, ; 90: 0x21d3fd70 => br/com/daruma/framework/mobile/gne/nfce/xml/classes/ElementosXmlAuxiliar
	i32 570671605, ; 91: 0x2203c1f5 => br/com/daruma/framework/mobile/gne/nfce/xml/Op_XmlInutilizacao
	i32 581097368, ; 92: 0x22a2d798 => java/nio/channels/FileChannel
	i32 584231583, ; 93: 0x22d2aa9f => java/lang/IllegalStateException
	i32 587182450, ; 94: 0x22ffb172 => androidx/activity/ComponentActivity
	i32 590702782, ; 95: 0x233568be => android/view/ViewTreeObserver
	i32 591810476, ; 96: 0x23464fac => android/os/Bundle
	i32 600508611, ; 97: 0x23cb08c3 => br/com/itfast/tectoy/TecToyException
	i32 606085292, ; 98: 0x242020ac => java/io/Serializable
	i32 617948154, ; 99: 0x24d523fa => androidx/appcompat/app/ActionBar$OnNavigationListener
	i32 619060219, ; 100: 0x24e61bfb => java/net/URL
	i32 624538224, ; 101: 0x2539b270 => br/com/daruma/framework/mobile/camera/dependencies/InactivityTimer$DaemonThreadFactory
	i32 625843168, ; 102: 0x254d9be0 => androidx/appcompat/app/AppCompatActivity
	i32 645227752, ; 103: 0x267564e8 => androidx/loader/content/Loader
	i32 651387831, ; 104: 0x26d363b7 => br/com/daruma/framework/mobile/gne/nfce/xml/Op_XmlCanc
	i32 655837073, ; 105: 0x27174791 => androidx/fragment/app/FragmentTransaction
	i32 657696663, ; 106: 0x2733a797 => androidx/core/app/SharedElementCallback$OnSharedElementsReadyListener
	i32 677994361, ; 107: 0x28695f79 => crc642a20111c1f951464/MainActivity
	i32 689512911, ; 108: 0x291921cf => androidx/appcompat/widget/Toolbar
	i32 692920175, ; 109: 0x294d1f6f => java/util/ArrayList
	i32 701408974, ; 110: 0x29cea6ce => br/com/daruma/framework/mobile/sat/impostos/Icmssn900
	i32 731668521, ; 111: 0x2b9c6029 => com/sunmi/peripheral/printer/WoyouConsts
	i32 739968939, ; 112: 0x2c1b07ab => java/util/EnumSet
	i32 741613001, ; 113: 0x2c341dc9 => com/hoho/android/usbserial/driver/FtdiSerialDriver
	i32 761226248, ; 114: 0x2d5f6408 => br/com/daruma/framework/mobile/camera/DarumaConfigScanner
	i32 763569404, ; 115: 0x2d8324fc => br/com/daruma/framework/mobile/sat/xmlConfiguracao/SAT_Framework_XML
	i32 779359060, ; 116: 0x2e741354 => com/phi/gertec/sat/serial/UsbId
	i32 780408360, ; 117: 0x2e841628 => java/lang/CharSequence
	i32 780987551, ; 118: 0x2e8cec9f => java/io/PrintWriter
	i32 793918146, ; 119: 0x2f523ac2 => java/lang/Integer
	i32 797125079, ; 120: 0x2f8329d7 => com/orbbec/astra/StreamDescription
	i32 805498755, ; 121: 0x3002ef83 => android/os/IBinder$DeathRecipient
	i32 806800039, ; 122: 0x3016caa7 => java/lang/Thread
	i32 810966755, ; 123: 0x30565ee3 => br/com/daruma/framework/mobile/constantes/ConstantesSocket
	i32 814476471, ; 124: 0x308becb7 => br/com/daruma/framework/mobile/gne/nfce/xml/Xml_ElementosEnvioNFCe
	i32 815012768, ; 125: 0x30941ba0 => androidx/core/internal/view/SupportMenuItem
	i32 823991243, ; 126: 0x311d1bcb => androidx/appcompat/graphics/drawable/DrawerArrowDrawable
	i32 833917550, ; 127: 0x31b4926e => com/orbbec/astra/StreamReader
	i32 838682992, ; 128: 0x31fd4970 => java/lang/NullPointerException
	i32 843201759, ; 129: 0x32423cdf => android/animation/Animator$AnimatorPauseListener
	i32 849281952, ; 130: 0x329f03a0 => com/sunmi/peripheral/printer/InnerPrinterManager$SingletonContainer
	i32 859309487, ; 131: 0x333805af => br/com/daruma/framework/mobile/gne/nfce/xml/classes/PisQtdeAuxiliar
	i32 863244094, ; 132: 0x33740f3e => com/orbbec/astra/DeviceController
	i32 876545377, ; 133: 0x343f0561 => androidx/core/view/KeyEventDispatcher$Component
	i32 876646173, ; 134: 0x34408f1d => javax/net/ssl/TrustManager
	i32 884540619, ; 135: 0x34b904cb => br/com/daruma/framework/mobile/tef/TipoAmbiente
	i32 893363610, ; 136: 0x353fa59a => java/lang/Short
	i32 899551522, ; 137: 0x359e1122 => mono/androidx/core/view/ActionProvider_VisibilityListenerImplementor
	i32 923158728, ; 138: 0x370648c8 => com/phi/gertec/sat/satger/SatGerLib
	i32 924972967, ; 139: 0x3721f7a7 => androidx/core/app/ActivityCompat$PermissionCompatDelegate
	i32 925357775, ; 140: 0x3727d6cf => java/nio/ByteBuffer
	i32 934002294, ; 141: 0x37abbe76 => com/orbbec/astra/ImageStream
	i32 937831689, ; 142: 0x37e62d09 => androidx/core/view/ViewPropertyAnimatorCompat
	i32 949874984, ; 143: 0x389df128 => br/com/daruma/framework/mobile/gne/imp/Datec_250
	i32 952757950, ; 144: 0x38c9eebe => mono/com/orbbec/astra/android/UsbDeviceAccessBroker_UsbDeviceAccessEventListenerImplementor
	i32 954160213, ; 145: 0x38df5455 => crc64a0e0a82d0db9a07d/ActivityLifecycleContextListener
	i32 955992438, ; 146: 0x38fb4976 => mono/com/hoho/android/usbserial/util/SerialInputOutputManager_ListenerImplementor
	i32 956212665, ; 147: 0x38fea5b9 => androidx/savedstate/SavedStateRegistryOwner
	i32 961863169, ; 148: 0x3954de01 => br/com/daruma/framework/mobile/gne/nfce/xml/Op_XmlContingencia
	i32 967391827, ; 149: 0x39a93a53 => android/nfc/NfcAdapter
	i32 968142514, ; 150: 0x39b4aeb2 => android/view/View$OnCreateContextMenuListener
	i32 972061517, ; 151: 0x39f07b4d => br/com/daruma/framework/mobile/gne/imp/TECTOY_380
	i32 977860950, ; 152: 0x3a48f956 => androidx/appcompat/app/ActionBarDrawerToggle$Delegate
	i32 982326989, ; 153: 0x3a8d1ecd => android/widget/HorizontalScrollView
	i32 982631821, ; 154: 0x3a91c58d => androidx/lifecycle/LiveData
	i32 986059584, ; 155: 0x3ac61340 => androidx/core/content/ContextCompat
	i32 988336100, ; 156: 0x3ae8cfe4 => android/view/KeyEvent$Callback
	i32 990742398, ; 157: 0x3b0d877e => br/com/daruma/framework/mobile/gne/nfse/xml/Op_XmlRetorno
	i32 992151122, ; 158: 0x3b230652 => br/com/itfast/tectoy/service/TecToyService
	i32 996699600, ; 159: 0x3b686dd0 => java/io/FileDescriptor
	i32 996847286, ; 160: 0x3b6aaeb6 => androidx/lifecycle/Observer
	i32 998009430, ; 161: 0x3b7c6a56 => java/nio/channels/GatheringByteChannel
	i32 1014544123, ; 162: 0x3c78b6fb => br/com/daruma/framework/mobile/camera/dependencies/ISendHandler
	i32 1016174845, ; 163: 0x3c9198fd => br/com/daruma/framework/mobile/comunicacao/exception/DarumaECFException
	i32 1018791985, ; 164: 0x3cb98831 => android/widget/EditText
	i32 1025540963, ; 165: 0x3d208363 => br/com/daruma/framework/mobile/camera/dependencies/DecodeThread
	i32 1026417919, ; 166: 0x3d2de4ff => android/view/WindowMetrics
	i32 1026507328, ; 167: 0x3d2f4240 => java/net/SocketAddress
	i32 1027401838, ; 168: 0x3d3ce86e => java/util/AbstractCollection
	i32 1030707578, ; 169: 0x3d6f597a => android/database/DataSetObserver
	i32 1035992969, ; 170: 0x3dbfff89 => android/content/res/Resources
	i32 1043698290, ; 171: 0x3e359272 => br/com/daruma/framework/mobile/tef/TefIT4R
	i32 1044459054, ; 172: 0x3e412e2e => com/orbbec/astra/android/AstraDeviceMonitorActivity
	i32 1046659663, ; 173: 0x3e62c24f => br/com/daruma/framework/mobile/comunicacao/impl/SocketDaruma
	i32 1049054327, ; 174: 0x3e874c77 => br/com/daruma/framework/mobile/webservice/modelo/DadosInutilizacaoNFCeELGIN
	i32 1054145369, ; 175: 0x3ed4fb59 => br/com/daruma/framework/mobile/gne/nfce/xml/auxiliar/Aux_XmlTransp
	i32 1062235695, ; 176: 0x3f506e2f => java/security/KeyStore$ProtectionParameter
	i32 1063592265, ; 177: 0x3f652149 => com/phi/gertec/sat/satger/SatGerProtocolParser
	i32 1070510572, ; 178: 0x3fceb1ec => br/com/daruma/framework/mobile/gne/nfce/xml/classes/SC
	i32 1073016658, ; 179: 0x3ff4ef52 => java/lang/annotation/Annotation
	i32 1077629184, ; 180: 0x403b5100 => java/util/function/Consumer
	i32 1077642205, ; 181: 0x403b83dd => java/util/logging/FileHandler
	i32 1087027260, ; 182: 0x40cab83c => com/orbbec/astra/PixelFormat
	i32 1087516602, ; 183: 0x40d22fba => br/com/daruma/framework/mobile/log/DarumaLogger$LoggerDispatcherTrace
	i32 1090939588, ; 184: 0x41066ac4 => javax/net/ssl/KeyManagerFactory
	i32 1107181286, ; 185: 0x41fe3ee6 => androidx/appcompat/app/ActionBar$OnMenuVisibilityListener
	i32 1107198049, ; 186: 0x41fe8061 => br/com/daruma/framework/mobile/gne/PersistenciaAuxiliar
	i32 1117343714, ; 187: 0x42994fe2 => androidx/drawerlayout/widget/DrawerLayout
	i32 1134314180, ; 188: 0x439c42c4 => androidx/core/view/ViewPropertyAnimatorListener
	i32 1139613004, ; 189: 0x43ed1d4c => br/com/daruma/framework/mobile/webservice/MultipartUtility
	i32 1142011573, ; 190: 0x4411b6b5 => java/util/Enumeration
	i32 1143568166, ; 191: 0x44297726 => br/com/daruma/framework/mobile/gne/nfce/xml/classes/NT
	i32 1149267780, ; 192: 0x44806f44 => java/lang/Cloneable
	i32 1152320495, ; 193: 0x44af03ef => br/com/daruma/framework/mobile/webservice/modelo/InfoEmissao
	i32 1157210024, ; 194: 0x44f99fa8 => com/phi/gertec/sat/serial/UsbSerialRuntimeException
	i32 1175636112, ; 195: 0x4612c890 => java/lang/ClassNotFoundException
	i32 1185273701, ; 196: 0x46a5d765 => android/view/SubMenu
	i32 1191901684, ; 197: 0x470af9f4 => br/com/daruma/framework/mobile/comunicacao/impl/ComunicacaoNaoImpl
	i32 1195050995, ; 198: 0x473b07f3 => br/com/daruma/framework/mobile/gne/nfce/xml/classes/PisSnAuxiliar
	i32 1196063310, ; 199: 0x474a7a4e => java/lang/Appendable
	i32 1203054524, ; 200: 0x47b527bc => br/com/daruma/framework/mobile/gne/nfce/xml/classes/IcmsSn500Auxiliar
	i32 1207398041, ; 201: 0x47f76e99 => com/orbbec/astra/InfraredFrame
	i32 1223831009, ; 202: 0x48f22de1 => com/hoho/android/usbserial/driver/CommonUsbSerialPort
	i32 1224166061, ; 203: 0x48f74aad => com/sunmi/peripheral/printer/SystemPropertyUtil
	i32 1227075600, ; 204: 0x4923b010 => javax/security/cert/Certificate
	i32 1238989451, ; 205: 0x49d97a8b => br/com/daruma/framework/mobile/PrinterManager
	i32 1240668031, ; 206: 0x49f3177f => br/com/daruma/framework/mobile/gne/nfce/xml/auxiliar/Aux_XmlAvisoServ
	i32 1246523448, ; 207: 0x4a4c7038 => br/com/daruma/framework/mobile/gne/nfce/Layout
	i32 1247123998, ; 208: 0x4a559a1e => br/com/daruma/framework/mobile/gne/nfce/xml/classes/IcmsSn101Auxiliar
	i32 1249284767, ; 209: 0x4a76929f => br/com/sweda/satserial/DLLSATSERIAL
	i32 1253784686, ; 210: 0x4abb3c6e => androidx/core/app/TaskStackBuilder
	i32 1258478866, ; 211: 0x4b02dd12 => androidx/appcompat/view/ActionMode$Callback
	i32 1258687552, ; 212: 0x4b060c40 => br/com/itfast/tectoy/service/TecToyDepthCam
	i32 1270186925, ; 213: 0x4bb583ad => android/view/Window$Callback
	i32 1270561450, ; 214: 0x4bbb3aaa => java/net/SocketTimeoutException
	i32 1273221213, ; 215: 0x4be3d05d => com/hoho/android/usbserial/driver/Cp21xxSerialDriver$Cp21xxSerialPort
	i32 1276142550, ; 216: 0x4c1063d6 => br/com/daruma/framework/mobile/gne/Persistencia
	i32 1283971378, ; 217: 0x4c87d932 => br/com/itfast/tectoy/TectoyBalancaCallback
	i32 1298454265, ; 218: 0x4d64d6f9 => java/lang/Throwable
	i32 1306496538, ; 219: 0x4ddf8e1a => br/com/daruma/framework/mobile/camera/dependencies/BeepManager
	i32 1314998831, ; 220: 0x4e614a2f => androidx/appcompat/app/AppCompatCallback
	i32 1320507001, ; 221: 0x4eb55679 => br/com/daruma/framework/mobile/exception/DarumaScanException
	i32 1323697755, ; 222: 0x4ee6065b => javax/net/ssl/SSLContext
	i32 1329167318, ; 223: 0x4f397bd6 => com/phi/gertec/sat/serial/CommonUsbSerialPort
	i32 1335098580, ; 224: 0x4f93fcd4 => java/util/Collection
	i32 1340347874, ; 225: 0x4fe415e2 => android/graphics/Paint
	i32 1347868763, ; 226: 0x5056d85b => com/orbbec/astra/Plane
	i32 1351915824, ; 227: 0x50949930 => br/com/daruma/framework/mobile/gne/sat/xml/Op_XmlRetorno
	i32 1352385505, ; 228: 0x509bc3e1 => androidx/appcompat/view/menu/MenuPresenter
	i32 1359921595, ; 229: 0x510ec1bb => br/com/daruma/framework/mobile/gne/nfce/xml/classes/ES
	i32 1361202766, ; 230: 0x51224e4e => br/com/daruma/framework/mobile/camera/dependencies/config/ZXingLibConfig
	i32 1363358864, ; 231: 0x51433490 => br/com/daruma/framework/mobile/camera/DarumaScanner
	i32 1368421702, ; 232: 0x51907546 => java/lang/ClassCastException
	i32 1369959181, ; 233: 0x51a7eb0d => com/phi/gertec/sat/serial/UsbSerialPort
	i32 1370891736, ; 234: 0x51b625d8 => android/graphics/PorterDuff$Mode
	i32 1373631042, ; 235: 0x51dff242 => javax/net/ssl/KeyManager
	i32 1379141914, ; 236: 0x5234091a => br/com/daruma/framework/mobile/gne/nfce/xml/classes/AP
	i32 1382831941, ; 237: 0x526c5745 => com/hoho/android/usbserial/driver/ProlificSerialDriver$ProlificSerialPort
	i32 1383873500, ; 238: 0x527c3bdc => com/orbbec/astra/BodyOrientation
	i32 1386297057, ; 239: 0x52a136e1 => br/com/daruma/framework/mobile/sat/xmlConfiguracao/Imposto
	i32 1386757446, ; 240: 0x52a83d46 => android/content/ComponentName
	i32 1388906712, ; 241: 0x52c908d8 => java/lang/Comparable
	i32 1391153081, ; 242: 0x52eb4fb9 => br/com/daruma/framework/mobile/tef/providers/destaxa/RetornoTefDestaxa
	i32 1396578145, ; 243: 0x533e1761 => mono/androidx/core/view/ActionProvider_SubUiVisibilityListenerImplementor
	i32 1403362096, ; 244: 0x53a59b30 => br/com/daruma/framework/mobile/gne/nfce/xml/classes/ElementosXMLContingencia
	i32 1406070842, ; 245: 0x53cef03a => br/com/daruma/framework/mobile/gne/nfce/xml/classes/CofinsStAuxiliar
	i32 1411520922, ; 246: 0x5422199a => br/com/daruma/framework/mobile/sat/impostos/Icms40
	i32 1413942416, ; 247: 0x54470c90 => br/com/daruma/framework/mobile/log/DarumaLoggerConst
	i32 1421200343, ; 248: 0x54b5cbd7 => br/com/daruma/framework/mobile/gne/nfce/xml/classes/IcmsStAuxiliar
	i32 1424303000, ; 249: 0x54e52398 => com/orbbec/astra/BodyTrackingFeatureFlags
	i32 1425790689, ; 250: 0x54fbd6e1 => java/lang/SecurityException
	i32 1428048664, ; 251: 0x551e4b18 => java/net/HttpURLConnection
	i32 1429796945, ; 252: 0x5538f851 => android/graphics/RectF
	i32 1430900885, ; 253: 0x5549d095 => com/orbbec/astra/ApiStatus
	i32 1432256000, ; 254: 0x555e7e00 => br/com/daruma/framework/mobile/gne/imp/Daruma_2100
	i32 1433059198, ; 255: 0x556abf7e => android/view/ViewManager
	i32 1434371632, ; 256: 0x557ec630 => br/com/daruma/framework/mobile/gne/imp/Q4
	i32 1438058291, ; 257: 0x55b70733 => br/com/daruma/framework/mobile/sat/elementosCFe/Dest
	i32 1438097868, ; 258: 0x55b7a1cc => br/com/daruma/framework/mobile/gne/nfce/xml/Op_XmlAuxiliar
	i32 1438182722, ; 259: 0x55b8ed42 => androidx/appcompat/view/menu/MenuView
	i32 1440727755, ; 260: 0x55dfc2cb => br/com/daruma/framework/mobile/sat/impostos/Cofinsst
	i32 1442348706, ; 261: 0x55f87ea2 => java/util/function/Predicate
	i32 1445855391, ; 262: 0x562e009f => br/com/daruma/framework/mobile/sat/impostos/Issqn
	i32 1453250821, ; 263: 0x569ed905 => com/orbbec/astra/android/UsbDeviceInfo
	i32 1464550585, ; 264: 0x574b44b9 => com/hoho/android/usbserial/driver/Cp21xxSerialDriver
	i32 1472468295, ; 265: 0x57c41547 => androidx/core/app/ActivityCompat
	i32 1473390714, ; 266: 0x57d2287a => com/phi/gertec/sat/serial/UsbSerialDriver
	i32 1475682991, ; 267: 0x57f522af => java/util/HashMap
	i32 1476293262, ; 268: 0x57fe728e => javax/security/auth/Subject
	i32 1482971916, ; 269: 0x58645b0c => br/com/daruma/framework/mobile/sat/SatNativo
	i32 1489594546, ; 270: 0x58c968b2 => java/nio/channels/spi/AbstractInterruptibleChannel
	i32 1492122694, ; 271: 0x58effc46 => com/orbbec/astra/Vector2D
	i32 1492295802, ; 272: 0x58f2a07a => br/com/daruma/framework/mobile/gne/Op_XmlConsulta
	i32 1492815417, ; 273: 0x58fa8e39 => java/util/concurrent/Executor
	i32 1493086679, ; 274: 0x58feb1d7 => androidx/appcompat/view/menu/MenuPresenter$Callback
	i32 1506774891, ; 275: 0x59cf8f6b => android/widget/Button
	i32 1512914934, ; 276: 0x5a2d3ff6 => com/orbbec/astra/FloorMask
	i32 1520335032, ; 277: 0x5a9e78b8 => br/com/itfast/tectoy/TecToyNfcCallback
	i32 1525461064, ; 278: 0x5aecb048 => br/com/daruma/framework/mobile/gne/Utils
	i32 1528970602, ; 279: 0x5b223d6a => androidx/core/view/KeyEventDispatcher
	i32 1539455380, ; 280: 0x5bc23994 => br/com/daruma/framework/mobile/sat/elementosCFe/Ide
	i32 1541885126, ; 281: 0x5be74cc6 => br/com/daruma/framework/mobile/gne/nfce/xml/classes/Icms90Auxiliar
	i32 1543824974, ; 282: 0x5c04e64e => br/com/daruma/framework/mobile/gne/nfce/xml/classes/MedAuxiliar
	i32 1544613420, ; 283: 0x5c10ee2c => java/io/File
	i32 1548306256, ; 284: 0x5c494750 => android/view/WindowManager$LayoutParams
	i32 1556110481, ; 285: 0x5cc05c91 => br/com/daruma/framework/mobile/gne/sat/Urano
	i32 1566083953, ; 286: 0x5d588b71 => java/util/Comparator
	i32 1581666596, ; 287: 0x5e465124 => br/com/daruma/framework/mobile/sat/impostos/Icmssn102
	i32 1581882681, ; 288: 0x5e499d39 => mono/androidx/appcompat/widget/Toolbar_OnMenuItemClickListenerImplementor
	i32 1584672329, ; 289: 0x5e742e49 => android/view/Display
	i32 1586851388, ; 290: 0x5e956e3c => android/os/Handler
	i32 1593078963, ; 291: 0x5ef474b3 => br/com/daruma/framework/mobile/gne/nfce/xml/classes/AM
	i32 1595725058, ; 292: 0x5f1cd502 => java/nio/channels/ByteChannel
	i32 1605789814, ; 293: 0x5fb66876 => java/nio/channels/ScatteringByteChannel
	i32 1637959351, ; 294: 0x61a146b7 => java/security/Principal
	i32 1644876130, ; 295: 0x620ad162 => android/graphics/Matrix
	i32 1646348278, ; 296: 0x622147f6 => android/view/View
	i32 1649695927, ; 297: 0x62545cb7 => java/lang/RuntimeException
	i32 1650608735, ; 298: 0x62624a5f => android/hardware/Camera
	i32 1657134862, ; 299: 0x62c5df0e => java/lang/IndexOutOfBoundsException
	i32 1659498634, ; 300: 0x62e9f08a => com/orbbec/astra/OrbbecCameraParams
	i32 1662973381, ; 301: 0x631ef5c5 => com/phi/gertec/sat/serial/CdcAcmSerialDriver
	i32 1663152246, ; 302: 0x6321b076 => br/com/daruma/framework/mobile/gne/nfce/xml/Op_XmlConsulta
	i32 1680835779, ; 303: 0x642f84c3 => java/lang/Byte
	i32 1684908723, ; 304: 0x646daab3 => com/orbbec/astra/android/AstraDeviceManagerListener
	i32 1695045539, ; 305: 0x650857a3 => br/com/daruma/framework/mobile/gne/imp/EPSON
	i32 1700075591, ; 306: 0x65551847 => com/orbbec/astra/ColorizedBodyStream
	i32 1705670457, ; 307: 0x65aa7739 => com/sunmi/peripheral/printer/InnerPrinterCallback
	i32 1708153699, ; 308: 0x65d05b63 => br/com/daruma/framework/mobile/gne/nfce/xml/classes/PisOutrAuxiliar
	i32 1708969308, ; 309: 0x65dccd5c => br/com/daruma/framework/mobile/comunicacao/impl/BluetoothDaruma$ReadTask
	i32 1712037813, ; 310: 0x660b9fb5 => com/orbbec/astra/Astra
	i32 1717655342, ; 311: 0x6661572e => br/com/daruma/framework/mobile/gne/imp/Daruma
	i32 1718265030, ; 312: 0x666aa4c6 => java/lang/Character
	i32 1729659134, ; 313: 0x671880fe => android/view/MenuInflater
	i32 1734262932, ; 314: 0x675ec094 => android/os/RemoteException
	i32 1738779209, ; 315: 0x67a3aa49 => androidx/lifecycle/ViewModelStore
	i32 1740814247, ; 316: 0x67c2b7a7 => android/widget/FrameLayout
	i32 1740929322, ; 317: 0x67c4792a => android/os/IInterface
	i32 1746572858, ; 318: 0x681a963a => android/app/Application$ActivityLifecycleCallbacks
	i32 1750218271, ; 319: 0x6852361f => br/com/daruma/framework/mobile/ThreadPoolManager
	i32 1755285137, ; 320: 0x689f8691 => java/util/Random
	i32 1756541799, ; 321: 0x68b2b367 => androidx/core/view/ActionProvider$VisibilityListener
	i32 1758490869, ; 322: 0x68d070f5 => android/os/BaseBundle
	i32 1766203486, ; 323: 0x6946205e => com/phi/gertec/sat/serial/HexDump
	i32 1771764967, ; 324: 0x699afce7 => com/orbbec/astra/FloorInfo
	i32 1772705556, ; 325: 0x69a95714 => android/graphics/Point
	i32 1775355160, ; 326: 0x69d1c518 => android/content/res/ColorStateList
	i32 1777528851, ; 327: 0x69f2f013 => java/lang/StringBuffer
	i32 1792294482, ; 328: 0x6ad43e52 => br/com/daruma/framework/mobile/gne/nfce/xml/classes/Icms30Auxiliar
	i32 1795101970, ; 329: 0x6aff1512 => br/com/daruma/framework/mobile/DarumaMobile
	i32 1807220671, ; 330: 0x6bb7ffbf => android/view/View$OnClickListener
	i32 1811622411, ; 331: 0x6bfb2a0b => br/com/daruma/framework/mobile/gne/nfce/xml/classes/EnderEmitAuxiliar
	i32 1826061187, ; 332: 0x6cd77b83 => androidx/appcompat/view/menu/SubMenuBuilder
	i32 1828773851, ; 333: 0x6d00dfdb => java/security/cert/CertificateFactory
	i32 1847780799, ; 334: 0x6e22e5bf => br/com/daruma/framework/mobile/gne/nfse/xml/Xml_ElementosEnvioNFSe
	i32 1851730788, ; 335: 0x6e5f2b64 => java/lang/Runnable
	i32 1866304377, ; 336: 0x6f3d8b79 => android/view/SearchEvent
	i32 1882699757, ; 337: 0x7037b7ed => br/com/daruma/framework/mobile/PrinterManager$PrinterManagerListener
	i32 1889248750, ; 338: 0x709ba5ee => java/nio/channels/InterruptibleChannel
	i32 1890166105, ; 339: 0x70a9a559 => androidx/appcompat/widget/Toolbar_NavigationOnClickEventDispatcher
	i32 1893605975, ; 340: 0x70de2257 => androidx/fragment/app/FragmentActivity
	i32 1897359118, ; 341: 0x7117670e => br/com/daruma/framework/mobile/comunicacao/exception/DarumaComunicacaoException
	i32 1898500913, ; 342: 0x7128d331 => java/nio/FloatBuffer
	i32 1905107734, ; 343: 0x718da316 => androidx/lifecycle/ViewModelProvider
	i32 1910758980, ; 344: 0x71e3de44 => br/com/daruma/framework/mobile/gne/imp/Formatacao
	i32 1926842476, ; 345: 0x72d9486c => br/com/daruma/framework/mobile/gne/nfce/xml/classes/PisStAuxiliar
	i32 1933507968, ; 346: 0x733efd80 => br/com/daruma/framework/mobile/sat/elementosCFe/Det
	i32 1936135065, ; 347: 0x73671399 => br/com/daruma/framework/mobile/gne/nfce/xml/auxiliar/Aux_XmlInfIntermed
	i32 1943196655, ; 348: 0x73d2d3ef => br/com/daruma/framework/mobile/sat/impostos/Icms00
	i32 1943778051, ; 349: 0x73dbb303 => android/widget/AdapterView$OnItemSelectedListener
	i32 1943829718, ; 350: 0x73dc7cd6 => br/com/daruma/framework/mobile/gne/nfce/xml/classes/RN
	i32 1944129628, ; 351: 0x73e1105c => java/io/OutputStream
	i32 1959476214, ; 352: 0x74cb3bf6 => br/com/daruma/framework/mobile/sat/elementosCFe/Pgto
	i32 1960663438, ; 353: 0x74dd598e => br/com/daruma/framework/mobile/gne/nfce/xml/classes/ConfiguracaoAuxiliar
	i32 1962126435, ; 354: 0x74f3ac63 => android/content/BroadcastReceiver
	i32 1965949473, ; 355: 0x752e0221 => androidx/fragment/app/FragmentManager
	i32 1970025673, ; 356: 0x756c34c9 => android/hardware/usb/UsbDeviceConnection
	i32 1975566647, ; 357: 0x75c0c137 => br/com/daruma/framework/mobile/camera/dependencies/Intents$Scan
	i32 1985929388, ; 358: 0x765ee0ac => android/app/Activity
	i32 1987841337, ; 359: 0x767c0d39 => java/lang/Boolean
	i32 1993217923, ; 360: 0x76ce1783 => br/com/daruma/framework/mobile/sat/impostos/Cofins
	i32 1993218009, ; 361: 0x76ce17d9 => br/com/daruma/framework/mobile/gne/nfce/xml/classes/PI
	i32 2008064836, ; 362: 0x77b0a344 => android/content/Intent
	i32 2014726135, ; 363: 0x781647f7 => android/view/accessibility/AccessibilityRecord
	i32 2022911814, ; 364: 0x78932f46 => br/com/itfast/tectoy/TecToyScannerCallback
	i32 2027782872, ; 365: 0x78dd82d8 => android/view/ContextThemeWrapper
	i32 2031450615, ; 366: 0x791579f7 => android/widget/AdapterView
	i32 2036556174, ; 367: 0x7963618e => android/content/DialogInterface
	i32 2043030513, ; 368: 0x79c62bf1 => android/os/Parcelable$Creator
	i32 2050960997, ; 369: 0x7a3f2e65 => java/util/function/ToLongFunction
	i32 2051396266, ; 370: 0x7a45d2aa => br/com/daruma/framework/mobile/gne/nfce/xml/classes/PR
	i32 2057114326, ; 371: 0x7a9d12d6 => java/security/cert/X509Extension
	i32 2063985753, ; 372: 0x7b05ec59 => android/view/animation/Animation
	i32 2064723667, ; 373: 0x7b112ed3 => android/widget/SpinnerAdapter
	i32 2065519402, ; 374: 0x7b1d532a => br/com/daruma/framework/mobile/tef/TipoFinanciamento
	i32 2068181446, ; 375: 0x7b45f1c6 => br/com/itfast/tectoy/service/BytesUtil
	i32 2069635236, ; 376: 0x7b5c20a4 => br/com/daruma/framework/mobile/sat/impostos/Cofinsoutr
	i32 2079753938, ; 377: 0x7bf686d2 => android/content/IntentSender
	i32 2080685156, ; 378: 0x7c04bc64 => java/security/SecureRandom
	i32 2081851726, ; 379: 0x7c16894e => br/com/itfast/tectoy/TecToy
	i32 2085522684, ; 380: 0x7c4e8cfc => java/io/DataInputStream
	i32 2091052166, ; 381: 0x7ca2ec86 => androidx/fragment/app/FragmentManager$BackStackEntry
	i32 2104844089, ; 382: 0x7d755f39 => mono/br/com/daruma/framework/mobile/log/listeners/ITraceListenerImplementor
	i32 2111431913, ; 383: 0x7dd9e4e9 => com/orbbec/astra/StreamSet
	i32 2114237978, ; 384: 0x7e04b61a => android/content/res/Configuration
	i32 2125218328, ; 385: 0x7eac4218 => br/com/daruma/framework/mobile/camera/dependencies/integrator/IVariaveisScaner
	i32 2128294650, ; 386: 0x7edb32fa => androidx/loader/app/LoaderManager
	i32 2131480051, ; 387: 0x7f0bcdf3 => android/animation/AnimatorListenerAdapter
	i32 2137519204, ; 388: 0x7f67f464 => br/com/daruma/framework/mobile/sat/impostos/Cofinsaliq
	i32 2161054107, ; 389: 0x80cf119b => android/hardware/usb/UsbDevice
	i32 2165143564, ; 390: 0x810d780c => com/orbbec/astra/BodyStatus
	i32 2167498311, ; 391: 0x81316647 => com/orbbec/astra/android/UsbDeviceAccessBroker$UsbDeviceAccessEventListener
	i32 2176254842, ; 392: 0x81b7037a => br/com/daruma/framework/mobile/gne/nfce/xml/classes/SE
	i32 2177045276, ; 393: 0x81c3131c => androidx/lifecycle/Lifecycle
	i32 2181570568, ; 394: 0x82082008 => br/com/daruma/framework/mobile/sat/impostos/Icms
	i32 2191855147, ; 395: 0x82a50e2b => androidx/lifecycle/Lifecycle$State
	i32 2223437513, ; 396: 0x8486f6c9 => androidx/appcompat/app/ActionBarDrawerToggle$DelegateProvider
	i32 2235908794, ; 397: 0x854542ba => androidx/core/view/ActionProvider$SubUiVisibilityListener
	i32 2241879133, ; 398: 0x85a05c5d => androidx/appcompat/widget/ScrollingTabContainerView
	i32 2244976592, ; 399: 0x85cf9fd0 => mono/com/phi/gertec/sat/satger/SatGerConnectionManager_ListenerImplementor
	i32 2259249736, ; 400: 0x86a96a48 => java/util/logging/StreamHandler
	i32 2266962535, ; 401: 0x871f1a67 => br/com/daruma/framework/mobile/gne/nfce/xml/classes/PisAliqAuxiliar
	i32 2269094561, ; 402: 0x873fa2a1 => java/net/UnknownServiceException
	i32 2270923754, ; 403: 0x875b8bea => java/net/Proxy$Type
	i32 2273877757, ; 404: 0x87889efd => com/phi/gertec/sat/satger/SatGerConnectionManager$ConnectionFailedException
	i32 2280653926, ; 405: 0x87f00466 => br/com/daruma/framework/mobile/sat/elementosCFe/InfAdic
	i32 2283575740, ; 406: 0x881c99bc => com/orbbec/astra/Matrix3
	i32 2284656609, ; 407: 0x882d17e1 => android/app/Application
	i32 2285090255, ; 408: 0x8833b5cf => br/com/daruma/framework/mobile/gne/sat/Layout
	i32 2295274318, ; 409: 0x88cf1b4e => androidx/fragment/app/FragmentManager$OnBackStackChangedListener
	i32 2306496481, ; 410: 0x897a57e1 => br/com/daruma/framework/mobile/gne/nfce/xml/classes/GO
	i32 2309870551, ; 411: 0x89add3d7 => br/com/daruma/framework/mobile/gne/nfce/NFCe
	i32 2316381801, ; 412: 0x8a112e69 => java/lang/reflect/Type
	i32 2316440185, ; 413: 0x8a121279 => androidx/lifecycle/ViewModelStoreOwner
	i32 2323726789, ; 414: 0x8a8141c5 => br/com/daruma/framework/mobile/ModeloImpressora
	i32 2325674508, ; 415: 0x8a9efa0c => java/lang/Iterable
	i32 2327024877, ; 416: 0x8ab394ed => com/orbbec/astra/SkeletonProfile
	i32 2341706484, ; 417: 0x8b939af4 => com/orbbec/astra/BodyMask
	i32 2342921718, ; 418: 0x8ba625f6 => br/com/daruma/framework/mobile/gne/nfce/xml/classes/InfRespTecAuxiliar
	i32 2349971395, ; 419: 0x8c11b7c3 => br/com/daruma/framework/mobile/gne/nfce/xml/classes/PisNtAuxiliar
	i32 2353161129, ; 420: 0x8c4263a9 => br/com/daruma/framework/mobile/exception/DarumaComunicacaoException
	i32 2362034053, ; 421: 0x8cc9c785 => com/orbbec/astra/StreamReader$FrameListener
	i32 2363729366, ; 422: 0x8ce3a5d6 => java/lang/Enum
	i32 2404057846, ; 423: 0x8f4b02f6 => android/app/PendingIntent
	i32 2404985825, ; 424: 0x8f592be1 => br/com/daruma/framework/mobile/gne/nfce/xml/classes/IcmsSn202Auxiliar
	i32 2411404453, ; 425: 0x8fbb1ca5 => java/lang/UnsupportedOperationException
	i32 2440988475, ; 426: 0x917e873b => androidx/core/internal/view/SupportMenu
	i32 2442189280, ; 427: 0x9190d9e0 => android/util/AndroidException
	i32 2443438835, ; 428: 0x91a3eaf3 => java/net/SocketException
	i32 2454652182, ; 429: 0x924f0516 => br/com/daruma/framework/mobile/camera/DarumaScanResult
	i32 2462006028, ; 430: 0x92bf3b0c => android/content/ComponentCallbacks
	i32 2465559753, ; 431: 0x92f574c9 => br/com/daruma/framework/mobile/sat/impostos/Pis
	i32 2467524923, ; 432: 0x9313713b => android/window/OnBackInvokedDispatcher
	i32 2496195039, ; 433: 0x94c8e9df => br/com/daruma/framework/mobile/sat/elementosCFe/InfCFe
	i32 2498896349, ; 434: 0x94f221dd => br/com/daruma/framework/mobile/tef/elgin/TefElgin
	i32 2502331409, ; 435: 0x95268c11 => com/hoho/android/usbserial/driver/ProlificSerialDriver
	i32 2520212266, ; 436: 0x9637632a => java/nio/channels/ReadableByteChannel
	i32 2522595888, ; 437: 0x965bc230 => com/orbbec/astra/android/AndroidCamera
	i32 2532846927, ; 438: 0x96f82d4f => android/content/SharedPreferences$OnSharedPreferenceChangeListener
	i32 2541051321, ; 439: 0x97755db9 => com/orbbec/astra/BodyTracking
	i32 2541780716, ; 440: 0x97807eec => android/view/ContextMenu$ContextMenuInfo
	i32 2551723209, ; 441: 0x981834c9 => br/com/daruma/framework/mobile/log/listeners/ITraceListener
	i32 2558143838, ; 442: 0x987a2d5e => java/io/FileInputStream
	i32 2561967928, ; 443: 0x98b48738 => java/security/cert/X509Certificate
	i32 2564315559, ; 444: 0x98d859a7 => com/orbbec/astra/ColorFrame
	i32 2568274266, ; 445: 0x9914c15a => br/com/daruma/framework/mobile/camera/dependencies/Intents
	i32 2580449747, ; 446: 0x99ce89d3 => com/phi/gertec/sat/serial/SerialInputOutputManager$Listener
	i32 2583867865, ; 447: 0x9a02b1d9 => br/com/daruma/framework/mobile/constantes/ConstantesGenerico
	i32 2592470390, ; 448: 0x9a85f576 => br/com/daruma/framework/mobile/sat/impostos/Pisst
	i32 2594014749, ; 449: 0x9a9d861d => android/hardware/Camera$PreviewCallback
	i32 2598778621, ; 450: 0x9ae636fd => java/util/Date
	i32 2602565136, ; 451: 0x9b1ffe10 => br/com/daruma/framework/mobile/sat/elementosCFe/Emit
	i32 2608813556, ; 452: 0x9b7f55f4 => br/com/daruma/framework/mobile/sat/impostos/Cofinsqtde
	i32 2623809744, ; 453: 0x9c6428d0 => br/com/daruma/framework/mobile/gne/imp/TECTOY_250
	i32 2628279754, ; 454: 0x9ca85dca => android/content/DialogInterface$OnCancelListener
	i32 2633762887, ; 455: 0x9cfc0847 => br/com/daruma/framework/mobile/camera/dependencies/InactivityTimer
	i32 2636833542, ; 456: 0x9d2ae306 => br/com/itfast/tectoy/service/ICommunicationDevice
	i32 2637159311, ; 457: 0x9d2fdb8f => android/content/pm/PackageManager
	i32 2638483996, ; 458: 0x9d44121c => androidx/appcompat/app/AppCompatDelegate
	i32 2645137969, ; 459: 0x9da99a31 => androidx/core/app/ComponentActivity$ExtraData
	i32 2648065070, ; 460: 0x9dd6442e => com/orbbec/astra/BodyStream
	i32 2654452940, ; 461: 0x9e37bccc => com/orbbec/astra/JointStatus
	i32 2654672461, ; 462: 0x9e3b164d => java/io/InterruptedIOException
	i32 2657151640, ; 463: 0x9e60ea98 => android/hardware/usb/UsbEndpoint
	i32 2664928003, ; 464: 0x9ed79303 => javax/net/ssl/HostnameVerifier
	i32 2665317634, ; 465: 0x9edd8502 => mono/com/orbbec/astra/StreamReader_FrameListenerImplementor
	i32 2678176273, ; 466: 0x9fa1ba11 => br/com/daruma/framework/mobile/gne/nfce/xml/classes/IcmsPartAuxiliar
	i32 2681209703, ; 467: 0x9fd00367 => android/widget/Adapter
	i32 2681988174, ; 468: 0x9fdbe44e => android/view/MotionEvent
	i32 2682990455, ; 469: 0x9feb2f77 => java/lang/AbstractStringBuilder
	i32 2687778660, ; 470: 0xa0343f64 => android/widget/TextView
	i32 2718858453, ; 471: 0xa20e7cd5 => com/orbbec/astra/android/UsbDeviceAccessBroker
	i32 2721599187, ; 472: 0xa2384ed3 => android/graphics/drawable/Drawable
	i32 2729136413, ; 473: 0xa2ab511d => br/com/itfast/tectoy/service/UsbControl
	i32 2729864429, ; 474: 0xa2b66ced => br/com/daruma/framework/mobile/gne/nfce/xml/classes/RJ
	i32 2735226023, ; 475: 0xa3083ca7 => br/com/daruma/framework/mobile/sat/PersistenciaXML
	i32 2741050037, ; 476: 0xa3611ab5 => java/net/ProxySelector
	i32 2747989409, ; 477: 0xa3cafda1 => br/com/daruma/framework/mobile/sat/impostos/Pisoutr
	i32 2762684487, ; 478: 0xa4ab3847 => java/lang/Float
	i32 2768695372, ; 479: 0xa506f04c => br/com/daruma/framework/mobile/gne/sat/Dimep
	i32 2774376954, ; 480: 0xa55da1fa => br/com/daruma/framework/mobile/gne/nfce/xml/classes/TO
	i32 2776109730, ; 481: 0xa57812a2 => br/com/daruma/framework/mobile/camera/dependencies/InactivityTimer$PowerStatusReceiver
	i32 2780961506, ; 482: 0xa5c21ae2 => br/com/daruma/framework/mobile/sat/elementosCFe/MeioDePagamento
	i32 2781390044, ; 483: 0xa5c8a4dc => br/com/daruma/framework/mobile/gne/nfce/xml/classes/CE
	i32 2782192450, ; 484: 0xa5d4e342 => br/com/daruma/framework/mobile/gne/imp/Nonus
	i32 2784705756, ; 485: 0xa5fb3cdc => br/com/daruma/framework/mobile/sat/impostos/Pissn
	i32 2788676667, ; 486: 0xa637d43b => br/com/daruma/framework/mobile/sat/elementosCFe/Entrega
	i32 2798656705, ; 487: 0xa6d01cc1 => androidx/core/app/TaskStackBuilder$SupportParentable
	i32 2810574337, ; 488: 0xa785f601 => com/orbbec/astra/ReaderFrame
	i32 2815615939, ; 489: 0xa7d2e3c3 => android/os/Build
	i32 2819722766, ; 490: 0xa8118e0e => br/com/daruma/framework/mobile/gne/nfse/NFSe
	i32 2828725766, ; 491: 0xa89aee06 => mono/com/orbbec/astra/android/AstraDeviceManagerListenerImplementor
	i32 2829333052, ; 492: 0xa8a4323c => br/com/daruma/framework/mobile/gne/nfce/xml/classes/IcmsSn102Auxiliar
	i32 2837435745, ; 493: 0xa91fd561 => android/view/DragEvent
	i32 2838673940, ; 494: 0xa932ba14 => br/com/itfast/tectoy/TecToyCameraProfundidadeCallback
	i32 2840929051, ; 495: 0xa955231b => br/com/daruma/framework/mobile/gne/sat/ParseNFCe_2_SAT
	i32 2841516747, ; 496: 0xa95e1acb => br/com/daruma/framework/mobile/sat/elementosCFe/Prod
	i32 2850072994, ; 497: 0xa9e0a9a2 => android/os/AsyncTask
	i32 2850153954, ; 498: 0xa9e1e5e2 => java/util/function/IntFunction
	i32 2859552638, ; 499: 0xaa714f7e => java/util/Spliterator
	i32 2859909183, ; 500: 0xaa76c03f => br/com/daruma/framework/mobile/gne/nfce/xml/classes/PB
	i32 2862889935, ; 501: 0xaaa43bcf => androidx/core/view/ActionProvider
	i32 2866910344, ; 502: 0xaae19488 => android/view/ActionMode
	i32 2867378511, ; 503: 0xaae8b94f => br/com/daruma/framework/mobile/comunicacao/AComunicacao
	i32 2873107855, ; 504: 0xab40258f => android/content/pm/PackageInfo
	i32 2875562852, ; 505: 0xab659b64 => android/hardware/usb/UsbRequest
	i32 2882658340, ; 506: 0xabd1e024 => br/com/daruma/framework/mobile/tef/ITefIT4R
	i32 2895048388, ; 507: 0xac8eeec4 => android/content/ServiceConnection
	i32 2906574570, ; 508: 0xad3eceea => br/com/daruma/framework/mobile/SatCallback
	i32 2917163057, ; 509: 0xade06031 => android/view/SurfaceHolder
	i32 2918613155, ; 510: 0xadf680a3 => android/content/DialogInterface$OnClickListener
	i32 2922690929, ; 511: 0xae34b971 => android/graphics/BlendMode
	i32 2922727622, ; 512: 0xae3548c6 => com/orbbec/astra/ImageStreamMode
	i32 2928765424, ; 513: 0xae9169f0 => com/hoho/android/usbserial/util/SerialInputOutputManager$State
	i32 2932874700, ; 514: 0xaed01dcc => android/view/InputEvent
	i32 2933762856, ; 515: 0xaeddab28 => android/util/AttributeSet
	i32 2936958840, ; 516: 0xaf0e6f78 => br/com/daruma/framework/mobile/tef/providers/destaxa/TefDefinesDestaxa
	i32 2942792700, ; 517: 0xaf6773fc => java/lang/Exception
	i32 2944663794, ; 518: 0xaf8400f2 => com/orbbec/astra/MaskedColorFrame
	i32 2946234077, ; 519: 0xaf9bf6dd => com/orbbec/astra/PointFrame
	i32 2953987098, ; 520: 0xb012441a => br/com/daruma/framework/mobile/webservice/ITServiceWs
	i32 2954825236, ; 521: 0xb01f0e14 => androidx/appcompat/app/ActionBar
	i32 2966893945, ; 522: 0xb0d73579 => br/com/daruma/framework/mobile/gne/nfce/xml/auxiliar/Aux_XmlNfce
	i32 2967039790, ; 523: 0xb0d96f2e => android/hardware/usb/UsbManager
	i32 2969770101, ; 524: 0xb1031875 => br/com/daruma/framework/mobile/gne/sat/xml/Op_XmlAuxiliar
	i32 2979401980, ; 525: 0xb19610fc => br/com/daruma/framework/mobile/gne/imp/Datec_350
	i32 2980510762, ; 526: 0xb1a6fc2a => mono/android/runtime/JavaArray
	i32 2983550349, ; 527: 0xb1d55d8d => br/com/daruma/framework/mobile/log/DarumaLogger
	i32 2983720033, ; 528: 0xb1d7f461 => mono/android/TypeManager
	i32 3009639411, ; 529: 0xb36373f3 => androidx/savedstate/SavedStateRegistry$SavedStateProvider
	i32 3011148753, ; 530: 0xb37a7bd1 => androidx/appcompat/app/ActionBar$LayoutParams
	i32 3011322120, ; 531: 0xb37d2108 => android/view/Surface
	i32 3014533265, ; 532: 0xb3ae2091 => com/sunmi/peripheral/printer/InnerPrinterException
	i32 3016508010, ; 533: 0xb3cc426a => br/com/daruma/framework/mobile/gne/Processos
	i32 3019469179, ; 534: 0xb3f9717b => br/com/daruma/framework/mobile/sat/PersistenciaJSON
	i32 3032808825, ; 535: 0xb4c4fd79 => java/io/StringWriter
	i32 3043602452, ; 536: 0xb569b014 => br/com/daruma/framework/mobile/gne/nfce/xml/classes/ProdAuxiliar
	i32 3044366471, ; 537: 0xb5755887 => br/com/daruma/framework/mobile/sat/impostos/Pisnt
	i32 3072461607, ; 538: 0xb7220b27 => java/util/concurrent/Future
	i32 3075124192, ; 539: 0xb74aabe0 => br/com/daruma/framework/mobile/gne/nfce/xml/classes/Icms60Auxiliar
	i32 3077500808, ; 540: 0xb76eef88 => br/com/daruma/framework/mobile/camera/dependencies/camera/CameraManager
	i32 3081419553, ; 541: 0xb7aabb21 => br/com/daruma/framework/mobile/gne/nfce/xml/classes/IcmsSn201Auxiliar
	i32 3086082443, ; 542: 0xb7f1e18b => br/com/daruma/framework/mobile/webservice/ElginNFCeServiceWs
	i32 3086955035, ; 543: 0xb7ff321b => androidx/appcompat/app/ActionBarDrawerToggle
	i32 3087255038, ; 544: 0xb803c5fe => android/preference/PreferenceManager
	i32 3093129022, ; 545: 0xb85d673e => java/io/FilterInputStream
	i32 3105065934, ; 546: 0xb9138bce => br/com/daruma/framework/mobile/gne/sat/Daruma
	i32 3131366176, ; 547: 0xbaa4db20 => java/nio/ShortBuffer
	i32 3151655458, ; 548: 0xbbda7222 => androidx/appcompat/view/menu/MenuItemImpl
	i32 3154115283, ; 549: 0xbbfffad3 => androidx/appcompat/view/menu/MenuBuilder$Callback
	i32 3154934679, ; 550: 0xbc0c7b97 => br/com/daruma/framework/mobile/gne/nfce/xml/classes/Icms10Auxiliar
	i32 3164525707, ; 551: 0xbc9ed48b => mono/androidx/drawerlayout/widget/DrawerLayout_DrawerListenerImplementor
	i32 3166301882, ; 552: 0xbcb9eeba => br/com/daruma/framework/mobile/gne/nfce/xml/classes/IcmsSn900Auxiliar
	i32 3173395525, ; 553: 0xbd262c45 => android/os/IBinder
	i32 3180780677, ; 554: 0xbd96dc85 => java/util/Set
	i32 3183271055, ; 555: 0xbdbcdc8f => android/view/ActionMode$Callback
	i32 3189649675, ; 556: 0xbe1e310b => androidx/appcompat/widget/Toolbar$OnMenuItemClickListener
	i32 3203363508, ; 557: 0xbeef72b4 => android/view/KeyboardShortcutGroup
	i32 3214484493, ; 558: 0xbf99240d => br/com/daruma/framework/mobile/camera/dependencies/DecodeFormatManager
	i32 3214744068, ; 559: 0xbf9d1a04 => android/view/WindowManager
	i32 3246245191, ; 560: 0xc17dc547 => br/com/daruma/framework/mobile/tef/TefIT4RCallback
	i32 3248589923, ; 561: 0xc1a18c63 => com/hoho/android/usbserial/BuildConfig
	i32 3251039036, ; 562: 0xc1c6eb3c => com/sunmi/peripheral/printer/ExceptionConst
	i32 3254012729, ; 563: 0xc1f44b39 => br/com/daruma/framework/mobile/webservice/modelo/DadosConsulta
	i32 3264154243, ; 564: 0xc28f0a83 => java/io/Flushable
	i32 3281925794, ; 565: 0xc39e36a2 => android/view/MenuItem
	i32 3282624268, ; 566: 0xc3a8df0c => com/orbbec/astra/ColorizedBodyFrame
	i32 3286863659, ; 567: 0xc3e98f2b => mono/br/com/daruma/framework/mobile/PrinterManager_PrinterManagerListenerImplementor
	i32 3289760976, ; 568: 0xc415c4d0 => br/com/daruma/framework/mobile/gne/nfce/xml/classes/CombAuxiliar
	i32 3289805256, ; 569: 0xc41671c8 => br/com/daruma/framework/mobile/gne/nfse/Layout
	i32 3290291610, ; 570: 0xc41ddd9a => android/view/ViewPropertyAnimator
	i32 3300906352, ; 571: 0xc4bfd570 => javax/net/ssl/SSLSession
	i32 3302525720, ; 572: 0xc4d88b18 => br/com/daruma/framework/mobile/gne/nfse/xml/Op_XmlConsulta
	i32 3319735188, ; 573: 0xc5df2394 => java/net/Proxy
	i32 3320131054, ; 574: 0xc5e52dee => br/com/daruma/framework/mobile/gne/nfce/xml/classes/CofinsSnAuxiliar
	i32 3322996185, ; 575: 0xc610e5d9 => com/phi/gertec/sat/serial/SerialInputOutputManager
	i32 3352646982, ; 576: 0xc7d55546 => java/io/DataInput
	i32 3356980490, ; 577: 0xc817750a => br/com/daruma/framework/mobile/gne/nfce/xml/classes/RR
	i32 3368362641, ; 578: 0xc8c52291 => com/sunmi/peripheral/printer/TransBean
	i32 3371390260, ; 579: 0xc8f35534 => com/hoho/android/usbserial/driver/UsbId
	i32 3377350755, ; 580: 0xc94e4863 => br/com/daruma/framework/mobile/exception/DarumaWebServiceException
	i32 3378651213, ; 581: 0xc962204d => java/util/AbstractSet
	i32 3386853318, ; 582: 0xc9df47c6 => androidx/core/content/pm/PackageInfoCompat
	i32 3396716945, ; 583: 0xca75c991 => br/com/daruma/framework/mobile/gne/imp/M10
	i32 3397888567, ; 584: 0xca87aa37 => br/com/daruma/framework/mobile/comunicacao/exception/DarumaException
	i32 3409419575, ; 585: 0xcb379d37 => javax/net/ssl/HttpsURLConnection
	i32 3413745521, ; 586: 0xcb799f71 => androidx/core/app/ActivityCompat$OnRequestPermissionsResultCallback
	i32 3419331212, ; 587: 0xcbceda8c => com/hoho/android/usbserial/driver/ProbeTable
	i32 3423467887, ; 588: 0xcc0df96f => java/lang/Number
	i32 3427035968, ; 589: 0xcc446b40 => xamarin/android/net/OldAndroidSSLSocketFactory
	i32 3430868172, ; 590: 0xcc7ee4cc => android/content/SharedPreferences
	i32 3431842082, ; 591: 0xcc8dc122 => br/com/daruma/framework/mobile/comunicacao/impl/BluetoothDaruma
	i32 3443033301, ; 592: 0xcd3884d5 => mono/androidx/appcompat/app/ActionBar_OnMenuVisibilityListenerImplementor
	i32 3453690827, ; 593: 0xcddb23cb => com/hoho/android/usbserial/driver/Ch34xSerialDriver
	i32 3464015330, ; 594: 0xce78ade2 => br/com/daruma/framework/mobile/webservice/modelo/DadosCancelamentoNFCeELGIN
	i32 3475097433, ; 595: 0xcf21c759 => br/com/daruma/framework/mobile/gne/imp/Daruma_350
	i32 3492512308, ; 596: 0xd02b8234 => br/com/daruma/framework/mobile/webservice/ComunicacaoWS
	i32 3516832034, ; 597: 0xd19e9922 => br/com/daruma/framework/mobile/gne/nfse/xml/Op_XmlAuxiliar
	i32 3519608359, ; 598: 0xd1c8f627 => com/orbbec/astra/ImageMetadata
	i32 3519931621, ; 599: 0xd1cde4e5 => java/net/URLConnection
	i32 3521191962, ; 600: 0xd1e1201a => br/com/daruma/framework/mobile/gne/nfce/xml/classes/EmitAuxiliar
	i32 3554050167, ; 601: 0xd3d68077 => com/hoho/android/usbserial/driver/FtdiSerialDriver$FtdiSerialPort
	i32 3558916517, ; 602: 0xd420c1a5 => com/orbbec/astra/SkeletonOptimization
	i32 3560870582, ; 603: 0xd43e92b6 => androidx/core/view/ViewPropertyAnimatorUpdateListener
	i32 3563029833, ; 604: 0xd45f8549 => br/com/itfast/tectoy/service/TecToyServices
	i32 3571274152, ; 605: 0xd4dd51a8 => androidx/appcompat/view/menu/MenuBuilder
	i32 3576242387, ; 606: 0xd52920d3 => android/runtime/JavaProxyThrowable
	i32 3585962591, ; 607: 0xd5bd725f => br/com/daruma/framework/mobile/exception/DarumaCheckedException
	i32 3590203014, ; 608: 0xd5fe2686 => java/util/logging/Handler
	i32 3590758762, ; 609: 0xd606a16a => com/orbbec/astra/DepthFrame
	i32 3590909812, ; 610: 0xd608ef74 => com/google/common/util/concurrent/ListenableFuture
	i32 3593750343, ; 611: 0xd6344747 => br/com/daruma/framework/mobile/gne/imp/Daruma_250
	i32 3599047402, ; 612: 0xd6851aea => com/hoho/android/usbserial/driver/UsbSerialPort
	i32 3614244735, ; 613: 0xd76cff7f => androidx/appcompat/app/ActionBar$Tab
	i32 3615446033, ; 614: 0xd77f5411 => br/com/daruma/framework/mobile/gne/nfce/xml/auxiliar/Aux_XmlIde
	i32 3620077265, ; 615: 0xd7c5fed1 => java/util/function/ToIntFunction
	i32 3620937142, ; 616: 0xd7d31db6 => androidx/appcompat/app/ActionBar$TabListener
	i32 3624703159, ; 617: 0xd80c94b7 => com/hoho/android/usbserial/util/SerialInputOutputManager
	i32 3635570964, ; 618: 0xd8b26914 => br/com/daruma/framework/mobile/gne/nfce/xml/classes/ElementosXmlCancelamento
	i32 3639087833, ; 619: 0xd8e812d9 => br/com/daruma/framework/mobile/camera/dependencies/DecodeHandler
	i32 3652518911, ; 620: 0xd9b503ff => com/orbbec/astra/InfraredStream
	i32 3653866785, ; 621: 0xd9c99521 => br/com/daruma/framework/mobile/gne/nfce/xml/classes/Icms20Auxiliar
	i32 3665774669, ; 622: 0xda7f484d => android/view/LayoutInflater
	i32 3666243682, ; 623: 0xda867062 => java/lang/String
	i32 3669061717, ; 624: 0xdab17055 => java/net/InetSocketAddress
	i32 3670428669, ; 625: 0xdac64bfd => br/com/daruma/framework/mobile/sat/elementosCFe/Total
	i32 3673444347, ; 626: 0xdaf44ffb => android/view/accessibility/AccessibilityEvent
	i32 3674210384, ; 627: 0xdb000050 => br/com/daruma/framework/mobile/gne/Tags
	i32 3676300590, ; 628: 0xdb1fe52e => com/orbbec/astra/StreamType
	i32 3683323802, ; 629: 0xdb8b0f9a => mono/android/runtime/JavaObject
	i32 3684070586, ; 630: 0xdb9674ba => android/view/ActionProvider
	i32 3689124180, ; 631: 0xdbe39154 => com/orbbec/astra/android/AstraDeviceManager
	i32 3689703186, ; 632: 0xdbec6712 => br/com/daruma/framework/mobile/gne/nfce/xml/classes/CofinsOutrAuxiliar
	i32 3702230909, ; 633: 0xdcab8f7d => java/lang/Double
	i32 3702422870, ; 634: 0xdcae7d56 => android/view/ViewTreeObserver$OnPreDrawListener
	i32 3715861037, ; 635: 0xdd7b8a2d => android/os/Build$VERSION
	i32 3716059097, ; 636: 0xdd7e8fd9 => com/phi/gertec/sat/serial/SerialInputOutputManager$State
	i32 3722843854, ; 637: 0xdde616ce => javax/net/SocketFactory
	i32 3725608191, ; 638: 0xde1044ff => br/com/daruma/framework/mobile/gne/nfce/xml/classes/AC
	i32 3726680736, ; 639: 0xde20a2a0 => java/net/ProtocolException
	i32 3727859322, ; 640: 0xde329e7a => com/orbbec/astra/DepthStream
	i32 3730566816, ; 641: 0xde5beea0 => br/com/daruma/framework/mobile/gne/nfce/TiposNFCe
	i32 3734859187, ; 642: 0xde9d6db3 => br/com/daruma/framework/mobile/gne/BMP
	i32 3744992307, ; 643: 0xdf380c33 => com/hoho/android/usbserial/driver/UsbSerialDriver
	i32 3745952483, ; 644: 0xdf46b2e3 => br/com/daruma/framework/mobile/gne/nfce/xml/classes/Icms70Auxiliar
	i32 3746020715, ; 645: 0xdf47bd6b => android/graphics/drawable/Drawable$Callback
	i32 3748075343, ; 646: 0xdf67174f => br/com/daruma/framework/mobile/gne/sat/xml/Objetos
	i32 3759929762, ; 647: 0xe01bf9a2 => android/graphics/Bitmap
	i32 3760420180, ; 648: 0xe0237554 => androidx/drawerlayout/widget/DrawerLayout$DrawerListener
	i32 3763853270, ; 649: 0xe057d7d6 => android/view/Window
	i32 3776101439, ; 650: 0xe112bc3f => java/util/BitSet
	i32 3784926020, ; 651: 0xe1996344 => androidx/customview/widget/Openable
	i32 3789851467, ; 652: 0xe1e48b4b => br/com/daruma/framework/mobile/sat/impostos/Cofinssn
	i32 3798910603, ; 653: 0xe26ec68b => br/com/daruma/framework/mobile/gne/sat/Interface_Sat
	i32 3799865100, ; 654: 0xe27d570c => br/com/daruma/framework/mobile/sat/elementosCFe/DescAcrEntr
	i32 3806784318, ; 655: 0xe2e6eb3e => br/com/daruma/framework/mobile/gne/nfce/xml/classes/MT
	i32 3810453788, ; 656: 0xe31ee91c => br/com/daruma/framework/mobile/exception/DarumaSatException
	i32 3823421666, ; 657: 0xe3e4c8e2 => android/net/Uri
	i32 3830684959, ; 658: 0xe4539d1f => br/com/daruma/framework/mobile/gne/nfce/xml/classes/PE
	i32 3839590796, ; 659: 0xe4db818c => br/com/daruma/framework/mobile/sat/impostos/Pisaliq
	i32 3841860247, ; 660: 0xe4fe2297 => br/com/daruma/framework/mobile/gne/nfce/xml/classes/RS
	i32 3846932217, ; 661: 0xe54b86f9 => javax/net/ssl/X509TrustManager
	i32 3847723405, ; 662: 0xe557998d => br/com/daruma/framework/mobile/gne/nfce/xml/classes/MsgPromocional
	i32 3855323559, ; 663: 0xe5cb91a7 => androidx/appcompat/view/ActionMode
	i32 3864585532, ; 664: 0xe658e53c => com/orbbec/astra/ImageFrame
	i32 3872825215, ; 665: 0xe6d69f7f => android/graphics/ColorFilter
	i32 3882570516, ; 666: 0xe76b5314 => java/lang/Class
	i32 3891885667, ; 667: 0xe7f97663 => br/com/daruma/framework/mobile/gne/nfce/xml/Op_XmlRetorno
	i32 3893629743, ; 668: 0xe814132f => android/view/LayoutInflater$Factory2
	i32 3895425567, ; 669: 0xe82f7a1f => androidx/core/app/SharedElementCallback
	i32 3900581163, ; 670: 0xe87e252b => java/io/InputStream
	i32 3912335754, ; 671: 0xe931818a => br/com/daruma/framework/mobile/gne/nfce/xml/classes/LeiImposto
	i32 3912451735, ; 672: 0xe9334697 => java/security/KeyStore
	i32 3917557164, ; 673: 0xe9812dac => br/com/daruma/framework/mobile/constantes/ConstantesFramework
	i32 3919758710, ; 674: 0xe9a2c576 => android/view/ContextMenu
	i32 3922373341, ; 675: 0xe9caaadd => androidx/fragment/app/Fragment$SavedState
	i32 3926455570, ; 676: 0xea08f512 => java/util/concurrent/ThreadFactory
	i32 3933245259, ; 677: 0xea708f4b => android/graphics/Rect
	i32 3934980768, ; 678: 0xea8b0aa0 => br/com/itfast/tectoy/CorLed
	i32 3950059934, ; 679: 0xeb71219e => br/com/daruma/framework/mobile/gne/nfce/xml/classes/MG
	i32 3960999444, ; 680: 0xec180e14 => android/widget/Toast
	i32 3969984744, ; 681: 0xeca128e8 => mono/android/runtime/InputStreamAdapter
	i32 3970882405, ; 682: 0xecaedb65 => com/phi/gertec/sat/satger/SatGerConnectionManager$Listener
	i32 3974587337, ; 683: 0xece763c9 => br/com/daruma/framework/mobile/DarumaMobile$LogMemoria
	i32 3975001277, ; 684: 0xecedb4bd => javax/net/ssl/SSLSocketFactory
	i32 3979055144, ; 685: 0xed2b9028 => br/com/daruma/framework/mobile/gne/nfce/xml/Objetos
	i32 3980860674, ; 686: 0xed471d02 => com/phi/gertec/sat/satger/Logger
	i32 3982845693, ; 687: 0xed6566fd => com/orbbec/astra/BodyFrame
	i32 3988578359, ; 688: 0xedbce037 => com/hoho/android/usbserial/util/SerialInputOutputManager$Listener
	i32 3993327007, ; 689: 0xee05559f => android/content/ContextWrapper
	i32 3994597123, ; 690: 0xee18b703 => com/orbbec/astra/HandPose
	i32 3995406185, ; 691: 0xee250f69 => android/graphics/Canvas
	i32 4003621010, ; 692: 0xeea26892 => com/orbbec/astra/Vector3D
	i32 4020308495, ; 693: 0xefa10a0f => java/lang/Error
	i32 4026153166, ; 694: 0xeffa38ce => androidx/core/view/DragAndDropPermissionsCompat
	i32 4030673356, ; 695: 0xf03f31cc => android/app/Dialog
	i32 4030975555, ; 696: 0xf043ce43 => android/view/animation/Interpolator
	i32 4032394179, ; 697: 0xf05973c3 => com/orbbec/astra/JointType
	i32 4041126081, ; 698: 0xf0deb0c1 => br/com/daruma/framework/mobile/gne/sat/xml/Xml_ElementosAux
	i32 4044525863, ; 699: 0xf1129127 => android/content/ComponentCallbacks2
	i32 4045246391, ; 700: 0xf11d8fb7 => br/com/daruma/framework/mobile/gne/nfce/xml/classes/CideAuxiliar
	i32 4047225593, ; 701: 0xf13bc2f9 => com/hoho/android/usbserial/driver/UsbSerialPort$ControlLine
	i32 4051772911, ; 702: 0xf18125ef => android/content/Context
	i32 4056674536, ; 703: 0xf1cbf0e8 => java/lang/NoClassDefFoundError
	i32 4066255456, ; 704: 0xf25e2260 => android/util/SparseArray
	i32 4067083651, ; 705: 0xf26ac583 => androidx/lifecycle/HasDefaultViewModelProviderFactory
	i32 4089459037, ; 706: 0xf3c0315d => java/nio/Buffer
	i32 4098107575, ; 707: 0xf44428b7 => mono/android/view/View_OnClickListenerImplementor
	i32 4101363546, ; 708: 0xf475d75a => java/io/Writer
	i32 4104513221, ; 709: 0xf4a5e6c5 => java/lang/StringBuilder
	i32 4108031826, ; 710: 0xf4db9752 => com/hoho/android/usbserial/driver/CdcAcmSerialDriver
	i32 4112982215, ; 711: 0xf52720c7 => androidx/loader/content/Loader$OnLoadCanceledListener
	i32 4114199587, ; 712: 0xf539b423 => com/orbbec/astra/ColorStream
	i32 4116628111, ; 713: 0xf55ec28f => androidx/lifecycle/LifecycleObserver
	i32 4117799665, ; 714: 0xf570a2f1 => android/view/SurfaceHolder$Callback
	i32 4118878202, ; 715: 0xf58117fa => android/os/Looper
	i32 4129352943, ; 716: 0xf620ecef => com/hoho/android/usbserial/driver/UsbSerialProber
	i32 4138958204, ; 717: 0xf6b37d7c => androidx/loader/app/LoaderManager$LoaderCallbacks
	i32 4145843537, ; 718: 0xf71c8d51 => com/phi/gertec/sat/serial/UsbSerialProber
	i32 4148577720, ; 719: 0xf74645b8 => androidx/core/app/ComponentActivity
	i32 4148593869, ; 720: 0xf74684cd => javax/net/ssl/TrustManagerFactory
	i32 4157808693, ; 721: 0xf7d32035 => java/io/IOException
	i32 4161224010, ; 722: 0xf8073d4a => java/lang/Void
	i32 4175071140, ; 723: 0xf8da87a4 => br/com/daruma/framework/mobile/gne/nfce/xml/classes/IssQnAuxiliar
	i32 4186434240, ; 724: 0xf987eac0 => br/com/daruma/framework/mobile/comunicacao/impl/SerialDaruma
	i32 4197997279, ; 725: 0xfa385adf => br/com/daruma/framework/mobile/comunicacao/impl/UsbDaruma
	i32 4209069772, ; 726: 0xfae14ecc => com/hoho/android/usbserial/driver/Ch34xSerialDriver$Ch340SerialPort
	i32 4217169749, ; 727: 0xfb5ce755 => br/com/daruma/framework/mobile/gne/imp/Dascom
	i32 4232707919, ; 728: 0xfc49ff4f => java/util/HashSet
	i32 4234479029, ; 729: 0xfc6505b5 => br/com/daruma/framework/mobile/gne/nfse/TiposNFSe
	i32 4236724582, ; 730: 0xfc874966 => android/os/Parcelable
	i32 4237386260, ; 731: 0xfc916214 => android/view/MenuItem$OnMenuItemClickListener
	i32 4246095188, ; 732: 0xfd164554 => br/com/daruma/framework/mobile/gne/nfce/xml/classes/CofinsAliqAuxiliar
	i32 4248811056, ; 733: 0xfd3fb630 => android/view/Menu
	i32 4259789120, ; 734: 0xfde73940 => androidx/core/app/ActivityCompat$RequestPermissionsRequestCodeValidator
	i32 4260947221, ; 735: 0xfdf8e515 => java/util/function/ToDoubleFunction
	i32 4268216374, ; 736: 0xfe67d036 => androidx/fragment/app/FragmentManager$FragmentLifecycleCallbacks
	i32 4271127433, ; 737: 0xfe943b89 => android/graphics/PorterDuff
	i32 4272821305, ; 738: 0xfeae1439 => androidx/lifecycle/ViewModelProvider$Factory
	i32 4277202854, ; 739: 0xfef0efa6 => br/com/daruma/framework/mobile/gne/nfce/xml/classes/CofinsNtAuxiliar
	i32 4277523103, ; 740: 0xfef5d29f => java/io/Closeable
	i32 4280821415, ; 741: 0xff2826a7 => com/phi/gertec/sat/satger/SatGerConnectionManager
	i32 4287134663 ; 742: 0xff887bc7 => br/com/daruma/framework/mobile/gne/nfce/xml/classes/BA
], align 4

; java_type_names
@__java_type_names.0 = internal constant [42 x i8] c"androidx/drawerlayout/widget/DrawerLayout\00", align 1
@__java_type_names.1 = internal constant [57 x i8] c"androidx/drawerlayout/widget/DrawerLayout$DrawerListener\00", align 1
@__java_type_names.2 = internal constant [73 x i8] c"mono/androidx/drawerlayout/widget/DrawerLayout_DrawerListenerImplementor\00", align 1
@__java_type_names.3 = internal constant [29 x i8] c"androidx/lifecycle/Lifecycle\00", align 1
@__java_type_names.4 = internal constant [35 x i8] c"androidx/lifecycle/Lifecycle$State\00", align 1
@__java_type_names.5 = internal constant [37 x i8] c"androidx/lifecycle/LifecycleObserver\00", align 1
@__java_type_names.6 = internal constant [34 x i8] c"androidx/lifecycle/LifecycleOwner\00", align 1
@__java_type_names.7 = internal constant [34 x i8] c"androidx/core/view/ActionProvider\00", align 1
@__java_type_names.8 = internal constant [58 x i8] c"androidx/core/view/ActionProvider$SubUiVisibilityListener\00", align 1
@__java_type_names.9 = internal constant [74 x i8] c"mono/androidx/core/view/ActionProvider_SubUiVisibilityListenerImplementor\00", align 1
@__java_type_names.10 = internal constant [53 x i8] c"androidx/core/view/ActionProvider$VisibilityListener\00", align 1
@__java_type_names.11 = internal constant [69 x i8] c"mono/androidx/core/view/ActionProvider_VisibilityListenerImplementor\00", align 1
@__java_type_names.12 = internal constant [48 x i8] c"androidx/core/view/DragAndDropPermissionsCompat\00", align 1
@__java_type_names.13 = internal constant [48 x i8] c"androidx/core/view/ViewPropertyAnimatorListener\00", align 1
@__java_type_names.14 = internal constant [54 x i8] c"androidx/core/view/ViewPropertyAnimatorUpdateListener\00", align 1
@__java_type_names.15 = internal constant [38 x i8] c"androidx/core/view/KeyEventDispatcher\00", align 1
@__java_type_names.16 = internal constant [48 x i8] c"androidx/core/view/KeyEventDispatcher$Component\00", align 1
@__java_type_names.17 = internal constant [46 x i8] c"androidx/core/view/ViewPropertyAnimatorCompat\00", align 1
@__java_type_names.18 = internal constant [40 x i8] c"androidx/core/internal/view/SupportMenu\00", align 1
@__java_type_names.19 = internal constant [44 x i8] c"androidx/core/internal/view/SupportMenuItem\00", align 1
@__java_type_names.20 = internal constant [36 x i8] c"androidx/core/content/ContextCompat\00", align 1
@__java_type_names.21 = internal constant [43 x i8] c"androidx/core/content/pm/PackageInfoCompat\00", align 1
@__java_type_names.22 = internal constant [33 x i8] c"androidx/core/app/ActivityCompat\00", align 1
@__java_type_names.23 = internal constant [68 x i8] c"androidx/core/app/ActivityCompat$OnRequestPermissionsResultCallback\00", align 1
@__java_type_names.24 = internal constant [58 x i8] c"androidx/core/app/ActivityCompat$PermissionCompatDelegate\00", align 1
@__java_type_names.25 = internal constant [72 x i8] c"androidx/core/app/ActivityCompat$RequestPermissionsRequestCodeValidator\00", align 1
@__java_type_names.26 = internal constant [36 x i8] c"androidx/core/app/ComponentActivity\00", align 1
@__java_type_names.27 = internal constant [46 x i8] c"androidx/core/app/ComponentActivity$ExtraData\00", align 1
@__java_type_names.28 = internal constant [40 x i8] c"androidx/core/app/SharedElementCallback\00", align 1
@__java_type_names.29 = internal constant [70 x i8] c"androidx/core/app/SharedElementCallback$OnSharedElementsReadyListener\00", align 1
@__java_type_names.30 = internal constant [35 x i8] c"androidx/core/app/TaskStackBuilder\00", align 1
@__java_type_names.31 = internal constant [53 x i8] c"androidx/core/app/TaskStackBuilder$SupportParentable\00", align 1
@__java_type_names.32 = internal constant [44 x i8] c"androidx/savedstate/SavedStateRegistryOwner\00", align 1
@__java_type_names.33 = internal constant [39 x i8] c"androidx/savedstate/SavedStateRegistry\00", align 1
@__java_type_names.34 = internal constant [58 x i8] c"androidx/savedstate/SavedStateRegistry$SavedStateProvider\00", align 1
@__java_type_names.35 = internal constant [39 x i8] c"androidx/fragment/app/FragmentActivity\00", align 1
@__java_type_names.36 = internal constant [31 x i8] c"androidx/fragment/app/Fragment\00", align 1
@__java_type_names.37 = internal constant [42 x i8] c"androidx/fragment/app/Fragment$SavedState\00", align 1
@__java_type_names.38 = internal constant [38 x i8] c"androidx/fragment/app/FragmentFactory\00", align 1
@__java_type_names.39 = internal constant [38 x i8] c"androidx/fragment/app/FragmentManager\00", align 1
@__java_type_names.40 = internal constant [53 x i8] c"androidx/fragment/app/FragmentManager$BackStackEntry\00", align 1
@__java_type_names.41 = internal constant [65 x i8] c"androidx/fragment/app/FragmentManager$FragmentLifecycleCallbacks\00", align 1
@__java_type_names.42 = internal constant [65 x i8] c"androidx/fragment/app/FragmentManager$OnBackStackChangedListener\00", align 1
@__java_type_names.43 = internal constant [81 x i8] c"mono/androidx/fragment/app/FragmentManager_OnBackStackChangedListenerImplementor\00", align 1
@__java_type_names.44 = internal constant [42 x i8] c"androidx/fragment/app/FragmentTransaction\00", align 1
@__java_type_names.45 = internal constant [55 x i8] c"crc64a0e0a82d0db9a07d/ActivityLifecycleContextListener\00", align 1
@__java_type_names.46 = internal constant [31 x i8] c"androidx/loader/content/Loader\00", align 1
@__java_type_names.47 = internal constant [54 x i8] c"androidx/loader/content/Loader$OnLoadCanceledListener\00", align 1
@__java_type_names.48 = internal constant [54 x i8] c"androidx/loader/content/Loader$OnLoadCompleteListener\00", align 1
@__java_type_names.49 = internal constant [34 x i8] c"androidx/loader/app/LoaderManager\00", align 1
@__java_type_names.50 = internal constant [50 x i8] c"androidx/loader/app/LoaderManager$LoaderCallbacks\00", align 1
@__java_type_names.51 = internal constant [47 x i8] c"xamarin/android/net/OldAndroidSSLSocketFactory\00", align 1
@__java_type_names.52 = internal constant [32 x i8] c"javax/security/cert/Certificate\00", align 1
@__java_type_names.53 = internal constant [36 x i8] c"javax/security/cert/X509Certificate\00", align 1
@__java_type_names.54 = internal constant [28 x i8] c"javax/security/auth/Subject\00", align 1
@__java_type_names.55 = internal constant [24 x i8] c"javax/net/SocketFactory\00", align 1
@__java_type_names.56 = internal constant [33 x i8] c"javax/net/ssl/HttpsURLConnection\00", align 1
@__java_type_names.57 = internal constant [31 x i8] c"javax/net/ssl/HostnameVerifier\00", align 1
@__java_type_names.58 = internal constant [25 x i8] c"javax/net/ssl/KeyManager\00", align 1
@__java_type_names.59 = internal constant [25 x i8] c"javax/net/ssl/SSLSession\00", align 1
@__java_type_names.60 = internal constant [32 x i8] c"javax/net/ssl/SSLSessionContext\00", align 1
@__java_type_names.61 = internal constant [27 x i8] c"javax/net/ssl/TrustManager\00", align 1
@__java_type_names.62 = internal constant [31 x i8] c"javax/net/ssl/X509TrustManager\00", align 1
@__java_type_names.63 = internal constant [32 x i8] c"javax/net/ssl/KeyManagerFactory\00", align 1
@__java_type_names.64 = internal constant [25 x i8] c"javax/net/ssl/SSLContext\00", align 1
@__java_type_names.65 = internal constant [31 x i8] c"javax/net/ssl/SSLSocketFactory\00", align 1
@__java_type_names.66 = internal constant [34 x i8] c"javax/net/ssl/TrustManagerFactory\00", align 1
@__java_type_names.67 = internal constant [37 x i8] c"android/window/OnBackInvokedCallback\00", align 1
@__java_type_names.68 = internal constant [39 x i8] c"android/window/OnBackInvokedDispatcher\00", align 1
@__java_type_names.69 = internal constant [27 x i8] c"android/widget/AdapterView\00", align 1
@__java_type_names.70 = internal constant [50 x i8] c"android/widget/AdapterView$OnItemSelectedListener\00", align 1
@__java_type_names.71 = internal constant [22 x i8] c"android/widget/Button\00", align 1
@__java_type_names.72 = internal constant [24 x i8] c"android/widget/EditText\00", align 1
@__java_type_names.73 = internal constant [27 x i8] c"android/widget/FrameLayout\00", align 1
@__java_type_names.74 = internal constant [36 x i8] c"android/widget/HorizontalScrollView\00", align 1
@__java_type_names.75 = internal constant [23 x i8] c"android/widget/Adapter\00", align 1
@__java_type_names.76 = internal constant [30 x i8] c"android/widget/SpinnerAdapter\00", align 1
@__java_type_names.77 = internal constant [24 x i8] c"android/widget/TextView\00", align 1
@__java_type_names.78 = internal constant [21 x i8] c"android/widget/Toast\00", align 1
@__java_type_names.79 = internal constant [24 x i8] c"android/view/ActionMode\00", align 1
@__java_type_names.80 = internal constant [33 x i8] c"android/view/ActionMode$Callback\00", align 1
@__java_type_names.81 = internal constant [28 x i8] c"android/view/ActionProvider\00", align 1
@__java_type_names.82 = internal constant [33 x i8] c"android/view/ContextThemeWrapper\00", align 1
@__java_type_names.83 = internal constant [21 x i8] c"android/view/Display\00", align 1
@__java_type_names.84 = internal constant [23 x i8] c"android/view/DragEvent\00", align 1
@__java_type_names.85 = internal constant [41 x i8] c"android/view/ContextMenu$ContextMenuInfo\00", align 1
@__java_type_names.86 = internal constant [25 x i8] c"android/view/ContextMenu\00", align 1
@__java_type_names.87 = internal constant [18 x i8] c"android/view/Menu\00", align 1
@__java_type_names.88 = internal constant [45 x i8] c"android/view/MenuItem$OnActionExpandListener\00", align 1
@__java_type_names.89 = internal constant [46 x i8] c"android/view/MenuItem$OnMenuItemClickListener\00", align 1
@__java_type_names.90 = internal constant [22 x i8] c"android/view/MenuItem\00", align 1
@__java_type_names.91 = internal constant [24 x i8] c"android/view/InputEvent\00", align 1
@__java_type_names.92 = internal constant [21 x i8] c"android/view/SubMenu\00", align 1
@__java_type_names.93 = internal constant [36 x i8] c"android/view/SurfaceHolder$Callback\00", align 1
@__java_type_names.94 = internal constant [27 x i8] c"android/view/SurfaceHolder\00", align 1
@__java_type_names.95 = internal constant [25 x i8] c"android/view/ViewManager\00", align 1
@__java_type_names.96 = internal constant [24 x i8] c"android/view/ViewParent\00", align 1
@__java_type_names.97 = internal constant [40 x i8] c"android/view/WindowManager$LayoutParams\00", align 1
@__java_type_names.98 = internal constant [27 x i8] c"android/view/WindowManager\00", align 1
@__java_type_names.99 = internal constant [35 x i8] c"android/view/KeyboardShortcutGroup\00", align 1
@__java_type_names.100 = internal constant [22 x i8] c"android/view/KeyEvent\00", align 1
@__java_type_names.101 = internal constant [31 x i8] c"android/view/KeyEvent$Callback\00", align 1
@__java_type_names.102 = internal constant [28 x i8] c"android/view/LayoutInflater\00", align 1
@__java_type_names.103 = internal constant [36 x i8] c"android/view/LayoutInflater$Factory\00", align 1
@__java_type_names.104 = internal constant [37 x i8] c"android/view/LayoutInflater$Factory2\00", align 1
@__java_type_names.105 = internal constant [26 x i8] c"android/view/MenuInflater\00", align 1
@__java_type_names.106 = internal constant [25 x i8] c"android/view/MotionEvent\00", align 1
@__java_type_names.107 = internal constant [25 x i8] c"android/view/SearchEvent\00", align 1
@__java_type_names.108 = internal constant [21 x i8] c"android/view/Surface\00", align 1
@__java_type_names.109 = internal constant [18 x i8] c"android/view/View\00", align 1
@__java_type_names.110 = internal constant [34 x i8] c"android/view/View$OnClickListener\00", align 1
@__java_type_names.111 = internal constant [50 x i8] c"mono/android/view/View_OnClickListenerImplementor\00", align 1
@__java_type_names.112 = internal constant [46 x i8] c"android/view/View$OnCreateContextMenuListener\00", align 1
@__java_type_names.113 = internal constant [23 x i8] c"android/view/ViewGroup\00", align 1
@__java_type_names.114 = internal constant [36 x i8] c"android/view/ViewGroup$LayoutParams\00", align 1
@__java_type_names.115 = internal constant [42 x i8] c"android/view/ViewGroup$MarginLayoutParams\00", align 1
@__java_type_names.116 = internal constant [34 x i8] c"android/view/ViewPropertyAnimator\00", align 1
@__java_type_names.117 = internal constant [30 x i8] c"android/view/ViewTreeObserver\00", align 1
@__java_type_names.118 = internal constant [48 x i8] c"android/view/ViewTreeObserver$OnPreDrawListener\00", align 1
@__java_type_names.119 = internal constant [20 x i8] c"android/view/Window\00", align 1
@__java_type_names.120 = internal constant [29 x i8] c"android/view/Window$Callback\00", align 1
@__java_type_names.121 = internal constant [27 x i8] c"android/view/WindowMetrics\00", align 1
@__java_type_names.122 = internal constant [33 x i8] c"android/view/animation/Animation\00", align 1
@__java_type_names.123 = internal constant [36 x i8] c"android/view/animation/Interpolator\00", align 1
@__java_type_names.124 = internal constant [46 x i8] c"android/view/accessibility/AccessibilityEvent\00", align 1
@__java_type_names.125 = internal constant [47 x i8] c"android/view/accessibility/AccessibilityRecord\00", align 1
@__java_type_names.126 = internal constant [52 x i8] c"android/view/accessibility/AccessibilityEventSource\00", align 1
@__java_type_names.127 = internal constant [30 x i8] c"android/util/AndroidException\00", align 1
@__java_type_names.128 = internal constant [28 x i8] c"android/util/DisplayMetrics\00", align 1
@__java_type_names.129 = internal constant [26 x i8] c"android/util/AttributeSet\00", align 1
@__java_type_names.130 = internal constant [25 x i8] c"android/util/SparseArray\00", align 1
@__java_type_names.131 = internal constant [37 x i8] c"android/preference/PreferenceManager\00", align 1
@__java_type_names.132 = internal constant [21 x i8] c"android/os/AsyncTask\00", align 1
@__java_type_names.133 = internal constant [22 x i8] c"android/os/BaseBundle\00", align 1
@__java_type_names.134 = internal constant [17 x i8] c"android/os/Build\00", align 1
@__java_type_names.135 = internal constant [25 x i8] c"android/os/Build$VERSION\00", align 1
@__java_type_names.136 = internal constant [18 x i8] c"android/os/Bundle\00", align 1
@__java_type_names.137 = internal constant [19 x i8] c"android/os/Handler\00", align 1
@__java_type_names.138 = internal constant [34 x i8] c"android/os/IBinder$DeathRecipient\00", align 1
@__java_type_names.139 = internal constant [19 x i8] c"android/os/IBinder\00", align 1
@__java_type_names.140 = internal constant [22 x i8] c"android/os/IInterface\00", align 1
@__java_type_names.141 = internal constant [30 x i8] c"android/os/Parcelable$Creator\00", align 1
@__java_type_names.142 = internal constant [22 x i8] c"android/os/Parcelable\00", align 1
@__java_type_names.143 = internal constant [18 x i8] c"android/os/Looper\00", align 1
@__java_type_names.144 = internal constant [18 x i8] c"android/os/Parcel\00", align 1
@__java_type_names.145 = internal constant [27 x i8] c"android/os/RemoteException\00", align 1
@__java_type_names.146 = internal constant [23 x i8] c"android/nfc/NfcAdapter\00", align 1
@__java_type_names.147 = internal constant [16 x i8] c"android/net/Uri\00", align 1
@__java_type_names.148 = internal constant [24 x i8] c"android/hardware/Camera\00", align 1
@__java_type_names.149 = internal constant [40 x i8] c"android/hardware/Camera$PreviewCallback\00", align 1
@__java_type_names.150 = internal constant [31 x i8] c"android/hardware/usb/UsbDevice\00", align 1
@__java_type_names.151 = internal constant [41 x i8] c"android/hardware/usb/UsbDeviceConnection\00", align 1
@__java_type_names.152 = internal constant [33 x i8] c"android/hardware/usb/UsbEndpoint\00", align 1
@__java_type_names.153 = internal constant [32 x i8] c"android/hardware/usb/UsbManager\00", align 1
@__java_type_names.154 = internal constant [32 x i8] c"android/hardware/usb/UsbRequest\00", align 1
@__java_type_names.155 = internal constant [24 x i8] c"android/graphics/Bitmap\00", align 1
@__java_type_names.156 = internal constant [27 x i8] c"android/graphics/BlendMode\00", align 1
@__java_type_names.157 = internal constant [24 x i8] c"android/graphics/Canvas\00", align 1
@__java_type_names.158 = internal constant [29 x i8] c"android/graphics/ColorFilter\00", align 1
@__java_type_names.159 = internal constant [24 x i8] c"android/graphics/Matrix\00", align 1
@__java_type_names.160 = internal constant [23 x i8] c"android/graphics/Paint\00", align 1
@__java_type_names.161 = internal constant [23 x i8] c"android/graphics/Point\00", align 1
@__java_type_names.162 = internal constant [28 x i8] c"android/graphics/PorterDuff\00", align 1
@__java_type_names.163 = internal constant [33 x i8] c"android/graphics/PorterDuff$Mode\00", align 1
@__java_type_names.164 = internal constant [22 x i8] c"android/graphics/Rect\00", align 1
@__java_type_names.165 = internal constant [23 x i8] c"android/graphics/RectF\00", align 1
@__java_type_names.166 = internal constant [35 x i8] c"android/graphics/drawable/Drawable\00", align 1
@__java_type_names.167 = internal constant [44 x i8] c"android/graphics/drawable/Drawable$Callback\00", align 1
@__java_type_names.168 = internal constant [33 x i8] c"android/database/DataSetObserver\00", align 1
@__java_type_names.169 = internal constant [27 x i8] c"android/animation/Animator\00", align 1
@__java_type_names.170 = internal constant [44 x i8] c"android/animation/Animator$AnimatorListener\00", align 1
@__java_type_names.171 = internal constant [49 x i8] c"android/animation/Animator$AnimatorPauseListener\00", align 1
@__java_type_names.172 = internal constant [42 x i8] c"android/animation/AnimatorListenerAdapter\00", align 1
@__java_type_names.173 = internal constant [35 x i8] c"android/animation/TimeInterpolator\00", align 1
@__java_type_names.174 = internal constant [21 x i8] c"android/app/Activity\00", align 1
@__java_type_names.175 = internal constant [24 x i8] c"android/app/Application\00", align 1
@__java_type_names.176 = internal constant [51 x i8] c"android/app/Application$ActivityLifecycleCallbacks\00", align 1
@__java_type_names.177 = internal constant [19 x i8] c"android/app/Dialog\00", align 1
@__java_type_names.178 = internal constant [26 x i8] c"android/app/PendingIntent\00", align 1
@__java_type_names.179 = internal constant [34 x i8] c"android/content/BroadcastReceiver\00", align 1
@__java_type_names.180 = internal constant [30 x i8] c"android/content/ComponentName\00", align 1
@__java_type_names.181 = internal constant [24 x i8] c"android/content/Context\00", align 1
@__java_type_names.182 = internal constant [31 x i8] c"android/content/ContextWrapper\00", align 1
@__java_type_names.183 = internal constant [35 x i8] c"android/content/ComponentCallbacks\00", align 1
@__java_type_names.184 = internal constant [36 x i8] c"android/content/ComponentCallbacks2\00", align 1
@__java_type_names.185 = internal constant [49 x i8] c"android/content/DialogInterface$OnCancelListener\00", align 1
@__java_type_names.186 = internal constant [48 x i8] c"android/content/DialogInterface$OnClickListener\00", align 1
@__java_type_names.187 = internal constant [32 x i8] c"android/content/DialogInterface\00", align 1
@__java_type_names.188 = internal constant [23 x i8] c"android/content/Intent\00", align 1
@__java_type_names.189 = internal constant [29 x i8] c"android/content/IntentSender\00", align 1
@__java_type_names.190 = internal constant [34 x i8] c"android/content/ServiceConnection\00", align 1
@__java_type_names.191 = internal constant [41 x i8] c"android/content/SharedPreferences$Editor\00", align 1
@__java_type_names.192 = internal constant [67 x i8] c"android/content/SharedPreferences$OnSharedPreferenceChangeListener\00", align 1
@__java_type_names.193 = internal constant [34 x i8] c"android/content/SharedPreferences\00", align 1
@__java_type_names.194 = internal constant [35 x i8] c"android/content/res/ColorStateList\00", align 1
@__java_type_names.195 = internal constant [34 x i8] c"android/content/res/Configuration\00", align 1
@__java_type_names.196 = internal constant [30 x i8] c"android/content/res/Resources\00", align 1
@__java_type_names.197 = internal constant [31 x i8] c"android/content/pm/PackageInfo\00", align 1
@__java_type_names.198 = internal constant [34 x i8] c"android/content/pm/PackageManager\00", align 1
@__java_type_names.199 = internal constant [40 x i8] c"mono/android/runtime/InputStreamAdapter\00", align 1
@__java_type_names.200 = internal constant [31 x i8] c"mono/android/runtime/JavaArray\00", align 1
@__java_type_names.201 = internal constant [21 x i8] c"java/util/Collection\00", align 1
@__java_type_names.202 = internal constant [18 x i8] c"java/util/HashMap\00", align 1
@__java_type_names.203 = internal constant [20 x i8] c"java/util/ArrayList\00", align 1
@__java_type_names.204 = internal constant [32 x i8] c"mono/android/runtime/JavaObject\00", align 1
@__java_type_names.205 = internal constant [35 x i8] c"android/runtime/JavaProxyThrowable\00", align 1
@__java_type_names.206 = internal constant [18 x i8] c"java/util/HashSet\00", align 1
@__java_type_names.207 = internal constant [41 x i8] c"mono/android/runtime/OutputStreamAdapter\00", align 1
@__java_type_names.208 = internal constant [29 x i8] c"java/util/AbstractCollection\00", align 1
@__java_type_names.209 = internal constant [22 x i8] c"java/util/AbstractSet\00", align 1
@__java_type_names.210 = internal constant [17 x i8] c"java/util/BitSet\00", align 1
@__java_type_names.211 = internal constant [15 x i8] c"java/util/Date\00", align 1
@__java_type_names.212 = internal constant [18 x i8] c"java/util/EnumSet\00", align 1
@__java_type_names.213 = internal constant [21 x i8] c"java/util/Comparator\00", align 1
@__java_type_names.214 = internal constant [22 x i8] c"java/util/Enumeration\00", align 1
@__java_type_names.215 = internal constant [19 x i8] c"java/util/Iterator\00", align 1
@__java_type_names.216 = internal constant [14 x i8] c"java/util/Set\00", align 1
@__java_type_names.217 = internal constant [22 x i8] c"java/util/Spliterator\00", align 1
@__java_type_names.218 = internal constant [17 x i8] c"java/util/Random\00", align 1
@__java_type_names.219 = internal constant [30 x i8] c"java/util/logging/FileHandler\00", align 1
@__java_type_names.220 = internal constant [26 x i8] c"java/util/logging/Handler\00", align 1
@__java_type_names.221 = internal constant [32 x i8] c"java/util/logging/StreamHandler\00", align 1
@__java_type_names.222 = internal constant [28 x i8] c"java/util/function/Consumer\00", align 1
@__java_type_names.223 = internal constant [28 x i8] c"java/util/function/Function\00", align 1
@__java_type_names.224 = internal constant [31 x i8] c"java/util/function/IntFunction\00", align 1
@__java_type_names.225 = internal constant [29 x i8] c"java/util/function/Predicate\00", align 1
@__java_type_names.226 = internal constant [36 x i8] c"java/util/function/ToDoubleFunction\00", align 1
@__java_type_names.227 = internal constant [33 x i8] c"java/util/function/ToIntFunction\00", align 1
@__java_type_names.228 = internal constant [34 x i8] c"java/util/function/ToLongFunction\00", align 1
@__java_type_names.229 = internal constant [30 x i8] c"java/util/concurrent/Executor\00", align 1
@__java_type_names.230 = internal constant [28 x i8] c"java/util/concurrent/Future\00", align 1
@__java_type_names.231 = internal constant [35 x i8] c"java/util/concurrent/ThreadFactory\00", align 1
@__java_type_names.232 = internal constant [30 x i8] c"java/util/concurrent/TimeUnit\00", align 1
@__java_type_names.233 = internal constant [24 x i8] c"java/security/Principal\00", align 1
@__java_type_names.234 = internal constant [23 x i8] c"java/security/KeyStore\00", align 1
@__java_type_names.235 = internal constant [42 x i8] c"java/security/KeyStore$LoadStoreParameter\00", align 1
@__java_type_names.236 = internal constant [43 x i8] c"java/security/KeyStore$ProtectionParameter\00", align 1
@__java_type_names.237 = internal constant [27 x i8] c"java/security/SecureRandom\00", align 1
@__java_type_names.238 = internal constant [31 x i8] c"java/security/cert/Certificate\00", align 1
@__java_type_names.239 = internal constant [38 x i8] c"java/security/cert/CertificateFactory\00", align 1
@__java_type_names.240 = internal constant [33 x i8] c"java/security/cert/X509Extension\00", align 1
@__java_type_names.241 = internal constant [35 x i8] c"java/security/cert/X509Certificate\00", align 1
@__java_type_names.242 = internal constant [16 x i8] c"java/nio/Buffer\00", align 1
@__java_type_names.243 = internal constant [20 x i8] c"java/nio/ByteBuffer\00", align 1
@__java_type_names.244 = internal constant [21 x i8] c"java/nio/FloatBuffer\00", align 1
@__java_type_names.245 = internal constant [21 x i8] c"java/nio/ShortBuffer\00", align 1
@__java_type_names.246 = internal constant [30 x i8] c"java/nio/channels/FileChannel\00", align 1
@__java_type_names.247 = internal constant [30 x i8] c"java/nio/channels/ByteChannel\00", align 1
@__java_type_names.248 = internal constant [26 x i8] c"java/nio/channels/Channel\00", align 1
@__java_type_names.249 = internal constant [39 x i8] c"java/nio/channels/GatheringByteChannel\00", align 1
@__java_type_names.250 = internal constant [39 x i8] c"java/nio/channels/InterruptibleChannel\00", align 1
@__java_type_names.251 = internal constant [38 x i8] c"java/nio/channels/ReadableByteChannel\00", align 1
@__java_type_names.252 = internal constant [40 x i8] c"java/nio/channels/ScatteringByteChannel\00", align 1
@__java_type_names.253 = internal constant [38 x i8] c"java/nio/channels/SeekableByteChannel\00", align 1
@__java_type_names.254 = internal constant [38 x i8] c"java/nio/channels/WritableByteChannel\00", align 1
@__java_type_names.255 = internal constant [51 x i8] c"java/nio/channels/spi/AbstractInterruptibleChannel\00", align 1
@__java_type_names.256 = internal constant [26 x i8] c"java/net/ConnectException\00", align 1
@__java_type_names.257 = internal constant [27 x i8] c"java/net/HttpURLConnection\00", align 1
@__java_type_names.258 = internal constant [27 x i8] c"java/net/InetSocketAddress\00", align 1
@__java_type_names.259 = internal constant [27 x i8] c"java/net/ProtocolException\00", align 1
@__java_type_names.260 = internal constant [15 x i8] c"java/net/Proxy\00", align 1
@__java_type_names.261 = internal constant [20 x i8] c"java/net/Proxy$Type\00", align 1
@__java_type_names.262 = internal constant [23 x i8] c"java/net/ProxySelector\00", align 1
@__java_type_names.263 = internal constant [23 x i8] c"java/net/SocketAddress\00", align 1
@__java_type_names.264 = internal constant [25 x i8] c"java/net/SocketException\00", align 1
@__java_type_names.265 = internal constant [32 x i8] c"java/net/SocketTimeoutException\00", align 1
@__java_type_names.266 = internal constant [33 x i8] c"java/net/UnknownServiceException\00", align 1
@__java_type_names.267 = internal constant [13 x i8] c"java/net/URI\00", align 1
@__java_type_names.268 = internal constant [13 x i8] c"java/net/URL\00", align 1
@__java_type_names.269 = internal constant [23 x i8] c"java/net/URLConnection\00", align 1
@__java_type_names.270 = internal constant [32 x i8] c"java/lang/AbstractStringBuilder\00", align 1
@__java_type_names.271 = internal constant [18 x i8] c"java/lang/Boolean\00", align 1
@__java_type_names.272 = internal constant [15 x i8] c"java/lang/Byte\00", align 1
@__java_type_names.273 = internal constant [20 x i8] c"java/lang/Character\00", align 1
@__java_type_names.274 = internal constant [16 x i8] c"java/lang/Class\00", align 1
@__java_type_names.275 = internal constant [29 x i8] c"java/lang/ClassCastException\00", align 1
@__java_type_names.276 = internal constant [22 x i8] c"java/lang/ClassLoader\00", align 1
@__java_type_names.277 = internal constant [33 x i8] c"java/lang/ClassNotFoundException\00", align 1
@__java_type_names.278 = internal constant [17 x i8] c"java/lang/Double\00", align 1
@__java_type_names.279 = internal constant [15 x i8] c"java/lang/Enum\00", align 1
@__java_type_names.280 = internal constant [16 x i8] c"java/lang/Error\00", align 1
@__java_type_names.281 = internal constant [20 x i8] c"java/lang/Exception\00", align 1
@__java_type_names.282 = internal constant [16 x i8] c"java/lang/Float\00", align 1
@__java_type_names.283 = internal constant [21 x i8] c"java/lang/Appendable\00", align 1
@__java_type_names.284 = internal constant [23 x i8] c"java/lang/CharSequence\00", align 1
@__java_type_names.285 = internal constant [20 x i8] c"java/lang/Cloneable\00", align 1
@__java_type_names.286 = internal constant [21 x i8] c"java/lang/Comparable\00", align 1
@__java_type_names.287 = internal constant [19 x i8] c"java/lang/Iterable\00", align 1
@__java_type_names.288 = internal constant [35 x i8] c"java/lang/IllegalArgumentException\00", align 1
@__java_type_names.289 = internal constant [32 x i8] c"java/lang/IllegalStateException\00", align 1
@__java_type_names.290 = internal constant [36 x i8] c"java/lang/IndexOutOfBoundsException\00", align 1
@__java_type_names.291 = internal constant [18 x i8] c"java/lang/Integer\00", align 1
@__java_type_names.292 = internal constant [19 x i8] c"java/lang/Runnable\00", align 1
@__java_type_names.293 = internal constant [23 x i8] c"java/lang/LinkageError\00", align 1
@__java_type_names.294 = internal constant [15 x i8] c"java/lang/Long\00", align 1
@__java_type_names.295 = internal constant [31 x i8] c"java/lang/NoClassDefFoundError\00", align 1
@__java_type_names.296 = internal constant [31 x i8] c"java/lang/NullPointerException\00", align 1
@__java_type_names.297 = internal constant [17 x i8] c"java/lang/Number\00", align 1
@__java_type_names.298 = internal constant [17 x i8] c"java/lang/Object\00", align 1
@__java_type_names.299 = internal constant [39 x i8] c"java/lang/ReflectiveOperationException\00", align 1
@__java_type_names.300 = internal constant [27 x i8] c"java/lang/RuntimeException\00", align 1
@__java_type_names.301 = internal constant [28 x i8] c"java/lang/SecurityException\00", align 1
@__java_type_names.302 = internal constant [16 x i8] c"java/lang/Short\00", align 1
@__java_type_names.303 = internal constant [17 x i8] c"java/lang/String\00", align 1
@__java_type_names.304 = internal constant [23 x i8] c"java/lang/StringBuffer\00", align 1
@__java_type_names.305 = internal constant [24 x i8] c"java/lang/StringBuilder\00", align 1
@__java_type_names.306 = internal constant [17 x i8] c"java/lang/Thread\00", align 1
@__java_type_names.307 = internal constant [35 x i8] c"mono/java/lang/RunnableImplementor\00", align 1
@__java_type_names.308 = internal constant [20 x i8] c"java/lang/Throwable\00", align 1
@__java_type_names.309 = internal constant [40 x i8] c"java/lang/UnsupportedOperationException\00", align 1
@__java_type_names.310 = internal constant [15 x i8] c"java/lang/Void\00", align 1
@__java_type_names.311 = internal constant [35 x i8] c"java/lang/reflect/AnnotatedElement\00", align 1
@__java_type_names.312 = internal constant [37 x i8] c"java/lang/reflect/GenericDeclaration\00", align 1
@__java_type_names.313 = internal constant [23 x i8] c"java/lang/reflect/Type\00", align 1
@__java_type_names.314 = internal constant [31 x i8] c"java/lang/reflect/TypeVariable\00", align 1
@__java_type_names.315 = internal constant [32 x i8] c"java/lang/annotation/Annotation\00", align 1
@__java_type_names.316 = internal constant [24 x i8] c"java/io/DataInputStream\00", align 1
@__java_type_names.317 = internal constant [13 x i8] c"java/io/File\00", align 1
@__java_type_names.318 = internal constant [23 x i8] c"java/io/FileDescriptor\00", align 1
@__java_type_names.319 = internal constant [24 x i8] c"java/io/FileInputStream\00", align 1
@__java_type_names.320 = internal constant [26 x i8] c"java/io/FilterInputStream\00", align 1
@__java_type_names.321 = internal constant [18 x i8] c"java/io/Closeable\00", align 1
@__java_type_names.322 = internal constant [18 x i8] c"java/io/DataInput\00", align 1
@__java_type_names.323 = internal constant [18 x i8] c"java/io/Flushable\00", align 1
@__java_type_names.324 = internal constant [20 x i8] c"java/io/InputStream\00", align 1
@__java_type_names.325 = internal constant [31 x i8] c"java/io/InterruptedIOException\00", align 1
@__java_type_names.326 = internal constant [20 x i8] c"java/io/IOException\00", align 1
@__java_type_names.327 = internal constant [21 x i8] c"java/io/Serializable\00", align 1
@__java_type_names.328 = internal constant [21 x i8] c"java/io/OutputStream\00", align 1
@__java_type_names.329 = internal constant [20 x i8] c"java/io/PrintWriter\00", align 1
@__java_type_names.330 = internal constant [21 x i8] c"java/io/StringWriter\00", align 1
@__java_type_names.331 = internal constant [15 x i8] c"java/io/Writer\00", align 1
@__java_type_names.332 = internal constant [25 x i8] c"mono/android/TypeManager\00", align 1
@__java_type_names.333 = internal constant [36 x i8] c"androidx/activity/ComponentActivity\00", align 1
@__java_type_names.334 = internal constant [35 x i8] c"crc642a20111c1f951464/MainActivity\00", align 1
@__java_type_names.335 = internal constant [28 x i8] c"androidx/lifecycle/Observer\00", align 1
@__java_type_names.336 = internal constant [28 x i8] c"androidx/lifecycle/LiveData\00", align 1
@__java_type_names.337 = internal constant [36 x i8] c"androidx/customview/widget/Openable\00", align 1
@__java_type_names.338 = internal constant [57 x i8] c"androidx/appcompat/graphics/drawable/DrawerArrowDrawable\00", align 1
@__java_type_names.339 = internal constant [33 x i8] c"androidx/appcompat/app/ActionBar\00", align 1
@__java_type_names.340 = internal constant [46 x i8] c"androidx/appcompat/app/ActionBar$LayoutParams\00", align 1
@__java_type_names.341 = internal constant [58 x i8] c"androidx/appcompat/app/ActionBar$OnMenuVisibilityListener\00", align 1
@__java_type_names.342 = internal constant [74 x i8] c"mono/androidx/appcompat/app/ActionBar_OnMenuVisibilityListenerImplementor\00", align 1
@__java_type_names.343 = internal constant [54 x i8] c"androidx/appcompat/app/ActionBar$OnNavigationListener\00", align 1
@__java_type_names.344 = internal constant [37 x i8] c"androidx/appcompat/app/ActionBar$Tab\00", align 1
@__java_type_names.345 = internal constant [45 x i8] c"androidx/appcompat/app/ActionBar$TabListener\00", align 1
@__java_type_names.346 = internal constant [45 x i8] c"androidx/appcompat/app/ActionBarDrawerToggle\00", align 1
@__java_type_names.347 = internal constant [54 x i8] c"androidx/appcompat/app/ActionBarDrawerToggle$Delegate\00", align 1
@__java_type_names.348 = internal constant [62 x i8] c"androidx/appcompat/app/ActionBarDrawerToggle$DelegateProvider\00", align 1
@__java_type_names.349 = internal constant [41 x i8] c"androidx/appcompat/app/AppCompatActivity\00", align 1
@__java_type_names.350 = internal constant [41 x i8] c"androidx/appcompat/app/AppCompatDelegate\00", align 1
@__java_type_names.351 = internal constant [41 x i8] c"androidx/appcompat/app/AppCompatCallback\00", align 1
@__java_type_names.352 = internal constant [34 x i8] c"androidx/appcompat/widget/Toolbar\00", align 1
@__java_type_names.353 = internal constant [67 x i8] c"androidx/appcompat/widget/Toolbar_NavigationOnClickEventDispatcher\00", align 1
@__java_type_names.354 = internal constant [58 x i8] c"androidx/appcompat/widget/Toolbar$OnMenuItemClickListener\00", align 1
@__java_type_names.355 = internal constant [74 x i8] c"mono/androidx/appcompat/widget/Toolbar_OnMenuItemClickListenerImplementor\00", align 1
@__java_type_names.356 = internal constant [39 x i8] c"androidx/appcompat/widget/DecorToolbar\00", align 1
@__java_type_names.357 = internal constant [52 x i8] c"androidx/appcompat/widget/ScrollingTabContainerView\00", align 1
@__java_type_names.358 = internal constant [75 x i8] c"androidx/appcompat/widget/ScrollingTabContainerView$VisibilityAnimListener\00", align 1
@__java_type_names.359 = internal constant [35 x i8] c"androidx/appcompat/view/ActionMode\00", align 1
@__java_type_names.360 = internal constant [44 x i8] c"androidx/appcompat/view/ActionMode$Callback\00", align 1
@__java_type_names.361 = internal constant [41 x i8] c"androidx/appcompat/view/menu/MenuBuilder\00", align 1
@__java_type_names.362 = internal constant [50 x i8] c"androidx/appcompat/view/menu/MenuBuilder$Callback\00", align 1
@__java_type_names.363 = internal constant [52 x i8] c"androidx/appcompat/view/menu/MenuPresenter$Callback\00", align 1
@__java_type_names.364 = internal constant [43 x i8] c"androidx/appcompat/view/menu/MenuPresenter\00", align 1
@__java_type_names.365 = internal constant [38 x i8] c"androidx/appcompat/view/menu/MenuView\00", align 1
@__java_type_names.366 = internal constant [42 x i8] c"androidx/appcompat/view/menu/MenuItemImpl\00", align 1
@__java_type_names.367 = internal constant [44 x i8] c"androidx/appcompat/view/menu/SubMenuBuilder\00", align 1
@__java_type_names.368 = internal constant [44 x i8] c"com/sunmi/peripheral/printer/ExceptionConst\00", align 1
@__java_type_names.369 = internal constant [50 x i8] c"com/sunmi/peripheral/printer/InnerPrinterCallback\00", align 1
@__java_type_names.370 = internal constant [51 x i8] c"com/sunmi/peripheral/printer/InnerPrinterException\00", align 1
@__java_type_names.371 = internal constant [49 x i8] c"com/sunmi/peripheral/printer/InnerPrinterManager\00", align 1
@__java_type_names.372 = internal constant [68 x i8] c"com/sunmi/peripheral/printer/InnerPrinterManager$SingletonContainer\00", align 1
@__java_type_names.373 = internal constant [41 x i8] c"com/sunmi/peripheral/printer/WoyouConsts\00", align 1
@__java_type_names.374 = internal constant [48 x i8] c"com/sunmi/peripheral/printer/SystemPropertyUtil\00", align 1
@__java_type_names.375 = internal constant [39 x i8] c"com/sunmi/peripheral/printer/TransBean\00", align 1
@__java_type_names.376 = internal constant [45 x i8] c"com/phi/gertec/sat/serial/CdcAcmSerialDriver\00", align 1
@__java_type_names.377 = internal constant [62 x i8] c"com/phi/gertec/sat/serial/CdcAcmSerialDriver$CdcAcmSerialPort\00", align 1
@__java_type_names.378 = internal constant [46 x i8] c"com/phi/gertec/sat/serial/CommonUsbSerialPort\00", align 1
@__java_type_names.379 = internal constant [34 x i8] c"com/phi/gertec/sat/serial/HexDump\00", align 1
@__java_type_names.380 = internal constant [42 x i8] c"com/phi/gertec/sat/serial/UsbSerialDriver\00", align 1
@__java_type_names.381 = internal constant [40 x i8] c"com/phi/gertec/sat/serial/UsbSerialPort\00", align 1
@__java_type_names.382 = internal constant [37 x i8] c"com/phi/gertec/sat/serial/ProbeTable\00", align 1
@__java_type_names.383 = internal constant [51 x i8] c"com/phi/gertec/sat/serial/SerialInputOutputManager\00", align 1
@__java_type_names.384 = internal constant [60 x i8] c"com/phi/gertec/sat/serial/SerialInputOutputManager$Listener\00", align 1
@__java_type_names.385 = internal constant [57 x i8] c"com/phi/gertec/sat/serial/SerialInputOutputManager$State\00", align 1
@__java_type_names.386 = internal constant [32 x i8] c"com/phi/gertec/sat/serial/UsbId\00", align 1
@__java_type_names.387 = internal constant [42 x i8] c"com/phi/gertec/sat/serial/UsbSerialProber\00", align 1
@__java_type_names.388 = internal constant [52 x i8] c"com/phi/gertec/sat/serial/UsbSerialRuntimeException\00", align 1
@__java_type_names.389 = internal constant [38 x i8] c"com/phi/gertec/sat/satger/BuildConfig\00", align 1
@__java_type_names.390 = internal constant [33 x i8] c"com/phi/gertec/sat/satger/Logger\00", align 1
@__java_type_names.391 = internal constant [50 x i8] c"com/phi/gertec/sat/satger/SatGerConnectionManager\00", align 1
@__java_type_names.392 = internal constant [76 x i8] c"com/phi/gertec/sat/satger/SatGerConnectionManager$ConnectionFailedException\00", align 1
@__java_type_names.393 = internal constant [59 x i8] c"com/phi/gertec/sat/satger/SatGerConnectionManager$Listener\00", align 1
@__java_type_names.394 = internal constant [75 x i8] c"mono/com/phi/gertec/sat/satger/SatGerConnectionManager_ListenerImplementor\00", align 1
@__java_type_names.395 = internal constant [36 x i8] c"com/phi/gertec/sat/satger/SatGerLib\00", align 1
@__java_type_names.396 = internal constant [51 x i8] c"com/phi/gertec/sat/satger/SatGerLib$OnDataReceived\00", align 1
@__java_type_names.397 = internal constant [47 x i8] c"com/phi/gertec/sat/satger/SatGerProtocolParser\00", align 1
@__java_type_names.398 = internal constant [27 x i8] c"com/orbbec/astra/ApiStatus\00", align 1
@__java_type_names.399 = internal constant [23 x i8] c"com/orbbec/astra/Astra\00", align 1
@__java_type_names.400 = internal constant [22 x i8] c"com/orbbec/astra/Body\00", align 1
@__java_type_names.401 = internal constant [27 x i8] c"com/orbbec/astra/BodyFrame\00", align 1
@__java_type_names.402 = internal constant [31 x i8] c"com/orbbec/astra/BodyFrameInfo\00", align 1
@__java_type_names.403 = internal constant [26 x i8] c"com/orbbec/astra/BodyMask\00", align 1
@__java_type_names.404 = internal constant [33 x i8] c"com/orbbec/astra/BodyOrientation\00", align 1
@__java_type_names.405 = internal constant [28 x i8] c"com/orbbec/astra/BodyStatus\00", align 1
@__java_type_names.406 = internal constant [28 x i8] c"com/orbbec/astra/BodyStream\00", align 1
@__java_type_names.407 = internal constant [30 x i8] c"com/orbbec/astra/BodyTracking\00", align 1
@__java_type_names.408 = internal constant [42 x i8] c"com/orbbec/astra/BodyTrackingFeatureFlags\00", align 1
@__java_type_names.409 = internal constant [28 x i8] c"com/orbbec/astra/ColorFrame\00", align 1
@__java_type_names.410 = internal constant [36 x i8] c"com/orbbec/astra/ColorizedBodyFrame\00", align 1
@__java_type_names.411 = internal constant [37 x i8] c"com/orbbec/astra/ColorizedBodyStream\00", align 1
@__java_type_names.412 = internal constant [29 x i8] c"com/orbbec/astra/ColorStream\00", align 1
@__java_type_names.413 = internal constant [34 x i8] c"com/orbbec/astra/CoordinateMapper\00", align 1
@__java_type_names.414 = internal constant [28 x i8] c"com/orbbec/astra/DepthFrame\00", align 1
@__java_type_names.415 = internal constant [29 x i8] c"com/orbbec/astra/DepthStream\00", align 1
@__java_type_names.416 = internal constant [34 x i8] c"com/orbbec/astra/DeviceController\00", align 1
@__java_type_names.417 = internal constant [27 x i8] c"com/orbbec/astra/FloorInfo\00", align 1
@__java_type_names.418 = internal constant [27 x i8] c"com/orbbec/astra/FloorMask\00", align 1
@__java_type_names.419 = internal constant [26 x i8] c"com/orbbec/astra/HandPose\00", align 1
@__java_type_names.420 = internal constant [30 x i8] c"com/orbbec/astra/HandPoseInfo\00", align 1
@__java_type_names.421 = internal constant [28 x i8] c"com/orbbec/astra/ImageFrame\00", align 1
@__java_type_names.422 = internal constant [31 x i8] c"com/orbbec/astra/ImageMetadata\00", align 1
@__java_type_names.423 = internal constant [29 x i8] c"com/orbbec/astra/ImageStream\00", align 1
@__java_type_names.424 = internal constant [33 x i8] c"com/orbbec/astra/ImageStreamMode\00", align 1
@__java_type_names.425 = internal constant [31 x i8] c"com/orbbec/astra/InfraredFrame\00", align 1
@__java_type_names.426 = internal constant [32 x i8] c"com/orbbec/astra/InfraredStream\00", align 1
@__java_type_names.427 = internal constant [23 x i8] c"com/orbbec/astra/Joint\00", align 1
@__java_type_names.428 = internal constant [29 x i8] c"com/orbbec/astra/JointStatus\00", align 1
@__java_type_names.429 = internal constant [27 x i8] c"com/orbbec/astra/JointType\00", align 1
@__java_type_names.430 = internal constant [34 x i8] c"com/orbbec/astra/MaskedColorFrame\00", align 1
@__java_type_names.431 = internal constant [35 x i8] c"com/orbbec/astra/MaskedColorStream\00", align 1
@__java_type_names.432 = internal constant [25 x i8] c"com/orbbec/astra/Matrix3\00", align 1
@__java_type_names.433 = internal constant [36 x i8] c"com/orbbec/astra/OrbbecCameraParams\00", align 1
@__java_type_names.434 = internal constant [29 x i8] c"com/orbbec/astra/PixelFormat\00", align 1
@__java_type_names.435 = internal constant [23 x i8] c"com/orbbec/astra/Plane\00", align 1
@__java_type_names.436 = internal constant [28 x i8] c"com/orbbec/astra/PointFrame\00", align 1
@__java_type_names.437 = internal constant [29 x i8] c"com/orbbec/astra/PointStream\00", align 1
@__java_type_names.438 = internal constant [29 x i8] c"com/orbbec/astra/ReaderFrame\00", align 1
@__java_type_names.439 = internal constant [38 x i8] c"com/orbbec/astra/SkeletonOptimization\00", align 1
@__java_type_names.440 = internal constant [33 x i8] c"com/orbbec/astra/SkeletonProfile\00", align 1
@__java_type_names.441 = internal constant [35 x i8] c"com/orbbec/astra/StreamDescription\00", align 1
@__java_type_names.442 = internal constant [30 x i8] c"com/orbbec/astra/StreamReader\00", align 1
@__java_type_names.443 = internal constant [44 x i8] c"com/orbbec/astra/StreamReader$FrameListener\00", align 1
@__java_type_names.444 = internal constant [60 x i8] c"mono/com/orbbec/astra/StreamReader_FrameListenerImplementor\00", align 1
@__java_type_names.445 = internal constant [27 x i8] c"com/orbbec/astra/StreamSet\00", align 1
@__java_type_names.446 = internal constant [28 x i8] c"com/orbbec/astra/StreamType\00", align 1
@__java_type_names.447 = internal constant [31 x i8] c"com/orbbec/astra/UsbDeviceInfo\00", align 1
@__java_type_names.448 = internal constant [26 x i8] c"com/orbbec/astra/Vector2D\00", align 1
@__java_type_names.449 = internal constant [26 x i8] c"com/orbbec/astra/Vector3D\00", align 1
@__java_type_names.450 = internal constant [39 x i8] c"com/orbbec/astra/android/AndroidCamera\00", align 1
@__java_type_names.451 = internal constant [45 x i8] c"com/orbbec/astra/android/AstraAndroidContext\00", align 1
@__java_type_names.452 = internal constant [44 x i8] c"com/orbbec/astra/android/AstraDeviceManager\00", align 1
@__java_type_names.453 = internal constant [52 x i8] c"com/orbbec/astra/android/AstraDeviceMonitorActivity\00", align 1
@__java_type_names.454 = internal constant [52 x i8] c"com/orbbec/astra/android/AstraDeviceManagerListener\00", align 1
@__java_type_names.455 = internal constant [68 x i8] c"mono/com/orbbec/astra/android/AstraDeviceManagerListenerImplementor\00", align 1
@__java_type_names.456 = internal constant [47 x i8] c"com/orbbec/astra/android/UsbDeviceAccessBroker\00", align 1
@__java_type_names.457 = internal constant [76 x i8] c"com/orbbec/astra/android/UsbDeviceAccessBroker$UsbDeviceAccessEventListener\00", align 1
@__java_type_names.458 = internal constant [92 x i8] c"mono/com/orbbec/astra/android/UsbDeviceAccessBroker_UsbDeviceAccessEventListenerImplementor\00", align 1
@__java_type_names.459 = internal constant [39 x i8] c"com/orbbec/astra/android/UsbDeviceInfo\00", align 1
@__java_type_names.460 = internal constant [39 x i8] c"com/hoho/android/usbserial/BuildConfig\00", align 1
@__java_type_names.461 = internal constant [57 x i8] c"com/hoho/android/usbserial/util/SerialInputOutputManager\00", align 1
@__java_type_names.462 = internal constant [66 x i8] c"com/hoho/android/usbserial/util/SerialInputOutputManager$Listener\00", align 1
@__java_type_names.463 = internal constant [82 x i8] c"mono/com/hoho/android/usbserial/util/SerialInputOutputManager_ListenerImplementor\00", align 1
@__java_type_names.464 = internal constant [63 x i8] c"com/hoho/android/usbserial/util/SerialInputOutputManager$State\00", align 1
@__java_type_names.465 = internal constant [53 x i8] c"com/hoho/android/usbserial/driver/CdcAcmSerialDriver\00", align 1
@__java_type_names.466 = internal constant [70 x i8] c"com/hoho/android/usbserial/driver/CdcAcmSerialDriver$CdcAcmSerialPort\00", align 1
@__java_type_names.467 = internal constant [52 x i8] c"com/hoho/android/usbserial/driver/Ch34xSerialDriver\00", align 1
@__java_type_names.468 = internal constant [68 x i8] c"com/hoho/android/usbserial/driver/Ch34xSerialDriver$Ch340SerialPort\00", align 1
@__java_type_names.469 = internal constant [54 x i8] c"com/hoho/android/usbserial/driver/CommonUsbSerialPort\00", align 1
@__java_type_names.470 = internal constant [53 x i8] c"com/hoho/android/usbserial/driver/Cp21xxSerialDriver\00", align 1
@__java_type_names.471 = internal constant [70 x i8] c"com/hoho/android/usbserial/driver/Cp21xxSerialDriver$Cp21xxSerialPort\00", align 1
@__java_type_names.472 = internal constant [51 x i8] c"com/hoho/android/usbserial/driver/FtdiSerialDriver\00", align 1
@__java_type_names.473 = internal constant [66 x i8] c"com/hoho/android/usbserial/driver/FtdiSerialDriver$FtdiSerialPort\00", align 1
@__java_type_names.474 = internal constant [50 x i8] c"com/hoho/android/usbserial/driver/UsbSerialDriver\00", align 1
@__java_type_names.475 = internal constant [60 x i8] c"com/hoho/android/usbserial/driver/UsbSerialPort$ControlLine\00", align 1
@__java_type_names.476 = internal constant [48 x i8] c"com/hoho/android/usbserial/driver/UsbSerialPort\00", align 1
@__java_type_names.477 = internal constant [45 x i8] c"com/hoho/android/usbserial/driver/ProbeTable\00", align 1
@__java_type_names.478 = internal constant [55 x i8] c"com/hoho/android/usbserial/driver/ProlificSerialDriver\00", align 1
@__java_type_names.479 = internal constant [74 x i8] c"com/hoho/android/usbserial/driver/ProlificSerialDriver$ProlificSerialPort\00", align 1
@__java_type_names.480 = internal constant [40 x i8] c"com/hoho/android/usbserial/driver/UsbId\00", align 1
@__java_type_names.481 = internal constant [50 x i8] c"com/hoho/android/usbserial/driver/UsbSerialProber\00", align 1
@__java_type_names.482 = internal constant [36 x i8] c"br/com/sweda/satserial/DLLSATSERIAL\00", align 1
@__java_type_names.483 = internal constant [28 x i8] c"br/com/itfast/tectoy/CorLed\00", align 1
@__java_type_names.484 = internal constant [33 x i8] c"br/com/itfast/tectoy/Dispositivo\00", align 1
@__java_type_names.485 = internal constant [43 x i8] c"br/com/itfast/tectoy/TectoyBalancaCallback\00", align 1
@__java_type_names.486 = internal constant [54 x i8] c"br/com/itfast/tectoy/TecToyCameraProfundidadeCallback\00", align 1
@__java_type_names.487 = internal constant [39 x i8] c"br/com/itfast/tectoy/TecToyNfcCallback\00", align 1
@__java_type_names.488 = internal constant [56 x i8] c"br/com/itfast/tectoy/TecToyReconhecimentoFacialCallback\00", align 1
@__java_type_names.489 = internal constant [43 x i8] c"br/com/itfast/tectoy/TecToyScannerCallback\00", align 1
@__java_type_names.490 = internal constant [38 x i8] c"br/com/itfast/tectoy/StatusImpressora\00", align 1
@__java_type_names.491 = internal constant [28 x i8] c"br/com/itfast/tectoy/TecToy\00", align 1
@__java_type_names.492 = internal constant [37 x i8] c"br/com/itfast/tectoy/TecToyException\00", align 1
@__java_type_names.493 = internal constant [39 x i8] c"br/com/itfast/tectoy/service/BytesUtil\00", align 1
@__java_type_names.494 = internal constant [50 x i8] c"br/com/itfast/tectoy/service/ICommunicationDevice\00", align 1
@__java_type_names.495 = internal constant [44 x i8] c"br/com/itfast/tectoy/service/TecToyServices\00", align 1
@__java_type_names.496 = internal constant [44 x i8] c"br/com/itfast/tectoy/service/TecToyDepthCam\00", align 1
@__java_type_names.497 = internal constant [43 x i8] c"br/com/itfast/tectoy/service/TecToyService\00", align 1
@__java_type_names.498 = internal constant [40 x i8] c"br/com/itfast/tectoy/service/UsbControl\00", align 1
@__java_type_names.499 = internal constant [44 x i8] c"br/com/daruma/framework/mobile/DarumaMobile\00", align 1
@__java_type_names.500 = internal constant [55 x i8] c"br/com/daruma/framework/mobile/DarumaMobile$LogMemoria\00", align 1
@__java_type_names.501 = internal constant [43 x i8] c"br/com/daruma/framework/mobile/SatCallback\00", align 1
@__java_type_names.502 = internal constant [48 x i8] c"br/com/daruma/framework/mobile/ModeloImpressora\00", align 1
@__java_type_names.503 = internal constant [46 x i8] c"br/com/daruma/framework/mobile/PrinterManager\00", align 1
@__java_type_names.504 = internal constant [69 x i8] c"br/com/daruma/framework/mobile/PrinterManager$PrinterManagerListener\00", align 1
@__java_type_names.505 = internal constant [85 x i8] c"mono/br/com/daruma/framework/mobile/PrinterManager_PrinterManagerListenerImplementor\00", align 1
@__java_type_names.506 = internal constant [49 x i8] c"br/com/daruma/framework/mobile/ThreadPoolManager\00", align 1
@__java_type_names.507 = internal constant [56 x i8] c"br/com/daruma/framework/mobile/webservice/ComunicacaoWS\00", align 1
@__java_type_names.508 = internal constant [61 x i8] c"br/com/daruma/framework/mobile/webservice/ElginNFCeServiceWs\00", align 1
@__java_type_names.509 = internal constant [54 x i8] c"br/com/daruma/framework/mobile/webservice/ITServiceWs\00", align 1
@__java_type_names.510 = internal constant [59 x i8] c"br/com/daruma/framework/mobile/webservice/MultipartUtility\00", align 1
@__java_type_names.511 = internal constant [68 x i8] c"br/com/daruma/framework/mobile/webservice/TrustedManagerManipulator\00", align 1
@__java_type_names.512 = internal constant [76 x i8] c"br/com/daruma/framework/mobile/webservice/modelo/DadosCancelamentoNFCeELGIN\00", align 1
@__java_type_names.513 = internal constant [63 x i8] c"br/com/daruma/framework/mobile/webservice/modelo/DadosConsulta\00", align 1
@__java_type_names.514 = internal constant [76 x i8] c"br/com/daruma/framework/mobile/webservice/modelo/DadosInutilizacaoNFCeELGIN\00", align 1
@__java_type_names.515 = internal constant [61 x i8] c"br/com/daruma/framework/mobile/webservice/modelo/InfoEmissao\00", align 1
@__java_type_names.516 = internal constant [44 x i8] c"br/com/daruma/framework/mobile/tef/ITefIT4R\00", align 1
@__java_type_names.517 = internal constant [51 x i8] c"br/com/daruma/framework/mobile/tef/TefIT4RCallback\00", align 1
@__java_type_names.518 = internal constant [43 x i8] c"br/com/daruma/framework/mobile/tef/TefIT4R\00", align 1
@__java_type_names.519 = internal constant [48 x i8] c"br/com/daruma/framework/mobile/tef/TipoAmbiente\00", align 1
@__java_type_names.520 = internal constant [53 x i8] c"br/com/daruma/framework/mobile/tef/TipoFinanciamento\00", align 1
@__java_type_names.521 = internal constant [71 x i8] c"br/com/daruma/framework/mobile/tef/providers/destaxa/RetornoTefDestaxa\00", align 1
@__java_type_names.522 = internal constant [71 x i8] c"br/com/daruma/framework/mobile/tef/providers/destaxa/TefDefinesDestaxa\00", align 1
@__java_type_names.523 = internal constant [50 x i8] c"br/com/daruma/framework/mobile/tef/elgin/TefElgin\00", align 1
@__java_type_names.524 = internal constant [52 x i8] c"br/com/daruma/framework/mobile/sat/PersistenciaJSON\00", align 1
@__java_type_names.525 = internal constant [51 x i8] c"br/com/daruma/framework/mobile/sat/PersistenciaXML\00", align 1
@__java_type_names.526 = internal constant [45 x i8] c"br/com/daruma/framework/mobile/sat/SatNativo\00", align 1
@__java_type_names.527 = internal constant [59 x i8] c"br/com/daruma/framework/mobile/sat/xmlConfiguracao/Imposto\00", align 1
@__java_type_names.528 = internal constant [69 x i8] c"br/com/daruma/framework/mobile/sat/xmlConfiguracao/SAT_Framework_XML\00", align 1
@__java_type_names.529 = internal constant [51 x i8] c"br/com/daruma/framework/mobile/sat/impostos/Cofins\00", align 1
@__java_type_names.530 = internal constant [55 x i8] c"br/com/daruma/framework/mobile/sat/impostos/Cofinsaliq\00", align 1
@__java_type_names.531 = internal constant [53 x i8] c"br/com/daruma/framework/mobile/sat/impostos/Cofinsnt\00", align 1
@__java_type_names.532 = internal constant [55 x i8] c"br/com/daruma/framework/mobile/sat/impostos/Cofinsoutr\00", align 1
@__java_type_names.533 = internal constant [55 x i8] c"br/com/daruma/framework/mobile/sat/impostos/Cofinsqtde\00", align 1
@__java_type_names.534 = internal constant [53 x i8] c"br/com/daruma/framework/mobile/sat/impostos/Cofinssn\00", align 1
@__java_type_names.535 = internal constant [53 x i8] c"br/com/daruma/framework/mobile/sat/impostos/Cofinsst\00", align 1
@__java_type_names.536 = internal constant [49 x i8] c"br/com/daruma/framework/mobile/sat/impostos/Icms\00", align 1
@__java_type_names.537 = internal constant [51 x i8] c"br/com/daruma/framework/mobile/sat/impostos/Icms00\00", align 1
@__java_type_names.538 = internal constant [51 x i8] c"br/com/daruma/framework/mobile/sat/impostos/Icms40\00", align 1
@__java_type_names.539 = internal constant [54 x i8] c"br/com/daruma/framework/mobile/sat/impostos/Icmssn102\00", align 1
@__java_type_names.540 = internal constant [54 x i8] c"br/com/daruma/framework/mobile/sat/impostos/Icmssn900\00", align 1
@__java_type_names.541 = internal constant [50 x i8] c"br/com/daruma/framework/mobile/sat/impostos/Issqn\00", align 1
@__java_type_names.542 = internal constant [48 x i8] c"br/com/daruma/framework/mobile/sat/impostos/Pis\00", align 1
@__java_type_names.543 = internal constant [52 x i8] c"br/com/daruma/framework/mobile/sat/impostos/Pisaliq\00", align 1
@__java_type_names.544 = internal constant [50 x i8] c"br/com/daruma/framework/mobile/sat/impostos/Pisnt\00", align 1
@__java_type_names.545 = internal constant [52 x i8] c"br/com/daruma/framework/mobile/sat/impostos/Pisoutr\00", align 1
@__java_type_names.546 = internal constant [52 x i8] c"br/com/daruma/framework/mobile/sat/impostos/Pisqtde\00", align 1
@__java_type_names.547 = internal constant [50 x i8] c"br/com/daruma/framework/mobile/sat/impostos/Pissn\00", align 1
@__java_type_names.548 = internal constant [50 x i8] c"br/com/daruma/framework/mobile/sat/impostos/Pisst\00", align 1
@__java_type_names.549 = internal constant [60 x i8] c"br/com/daruma/framework/mobile/sat/elementosCFe/DescAcrEntr\00", align 1
@__java_type_names.550 = internal constant [53 x i8] c"br/com/daruma/framework/mobile/sat/elementosCFe/Dest\00", align 1
@__java_type_names.551 = internal constant [52 x i8] c"br/com/daruma/framework/mobile/sat/elementosCFe/Det\00", align 1
@__java_type_names.552 = internal constant [53 x i8] c"br/com/daruma/framework/mobile/sat/elementosCFe/Emit\00", align 1
@__java_type_names.553 = internal constant [56 x i8] c"br/com/daruma/framework/mobile/sat/elementosCFe/Entrega\00", align 1
@__java_type_names.554 = internal constant [52 x i8] c"br/com/daruma/framework/mobile/sat/elementosCFe/Ide\00", align 1
@__java_type_names.555 = internal constant [56 x i8] c"br/com/daruma/framework/mobile/sat/elementosCFe/InfAdic\00", align 1
@__java_type_names.556 = internal constant [55 x i8] c"br/com/daruma/framework/mobile/sat/elementosCFe/InfCFe\00", align 1
@__java_type_names.557 = internal constant [64 x i8] c"br/com/daruma/framework/mobile/sat/elementosCFe/MeioDePagamento\00", align 1
@__java_type_names.558 = internal constant [53 x i8] c"br/com/daruma/framework/mobile/sat/elementosCFe/Pgto\00", align 1
@__java_type_names.559 = internal constant [53 x i8] c"br/com/daruma/framework/mobile/sat/elementosCFe/Prod\00", align 1
@__java_type_names.560 = internal constant [54 x i8] c"br/com/daruma/framework/mobile/sat/elementosCFe/Total\00", align 1
@__java_type_names.561 = internal constant [48 x i8] c"br/com/daruma/framework/mobile/log/DarumaLogger\00", align 1
@__java_type_names.562 = internal constant [70 x i8] c"br/com/daruma/framework/mobile/log/DarumaLogger$LoggerDispatcherTrace\00", align 1
@__java_type_names.563 = internal constant [53 x i8] c"br/com/daruma/framework/mobile/log/DarumaLoggerConst\00", align 1
@__java_type_names.564 = internal constant [60 x i8] c"br/com/daruma/framework/mobile/log/listeners/ITraceListener\00", align 1
@__java_type_names.565 = internal constant [76 x i8] c"mono/br/com/daruma/framework/mobile/log/listeners/ITraceListenerImplementor\00", align 1
@__java_type_names.566 = internal constant [39 x i8] c"br/com/daruma/framework/mobile/gne/BMP\00", align 1
@__java_type_names.567 = internal constant [50 x i8] c"br/com/daruma/framework/mobile/gne/Op_XmlConsulta\00", align 1
@__java_type_names.568 = internal constant [48 x i8] c"br/com/daruma/framework/mobile/gne/Persistencia\00", align 1
@__java_type_names.569 = internal constant [56 x i8] c"br/com/daruma/framework/mobile/gne/PersistenciaAuxiliar\00", align 1
@__java_type_names.570 = internal constant [45 x i8] c"br/com/daruma/framework/mobile/gne/Processos\00", align 1
@__java_type_names.571 = internal constant [40 x i8] c"br/com/daruma/framework/mobile/gne/Tags\00", align 1
@__java_type_names.572 = internal constant [41 x i8] c"br/com/daruma/framework/mobile/gne/Utils\00", align 1
@__java_type_names.573 = internal constant [46 x i8] c"br/com/daruma/framework/mobile/gne/sat/Daruma\00", align 1
@__java_type_names.574 = internal constant [45 x i8] c"br/com/daruma/framework/mobile/gne/sat/Dimep\00", align 1
@__java_type_names.575 = internal constant [45 x i8] c"br/com/daruma/framework/mobile/gne/sat/EPSON\00", align 1
@__java_type_names.576 = internal constant [53 x i8] c"br/com/daruma/framework/mobile/gne/sat/Interface_Sat\00", align 1
@__java_type_names.577 = internal constant [46 x i8] c"br/com/daruma/framework/mobile/gne/sat/Layout\00", align 1
@__java_type_names.578 = internal constant [55 x i8] c"br/com/daruma/framework/mobile/gne/sat/ParseNFCe_2_SAT\00", align 1
@__java_type_names.579 = internal constant [43 x i8] c"br/com/daruma/framework/mobile/gne/sat/Sat\00", align 1
@__java_type_names.580 = internal constant [45 x i8] c"br/com/daruma/framework/mobile/gne/sat/Urano\00", align 1
@__java_type_names.581 = internal constant [51 x i8] c"br/com/daruma/framework/mobile/gne/sat/xml/Objetos\00", align 1
@__java_type_names.582 = internal constant [58 x i8] c"br/com/daruma/framework/mobile/gne/sat/xml/Op_XmlAuxiliar\00", align 1
@__java_type_names.583 = internal constant [57 x i8] c"br/com/daruma/framework/mobile/gne/sat/xml/Op_XmlRetorno\00", align 1
@__java_type_names.584 = internal constant [60 x i8] c"br/com/daruma/framework/mobile/gne/sat/xml/Xml_ElementosAux\00", align 1
@__java_type_names.585 = internal constant [47 x i8] c"br/com/daruma/framework/mobile/gne/nfse/Layout\00", align 1
@__java_type_names.586 = internal constant [45 x i8] c"br/com/daruma/framework/mobile/gne/nfse/NFSe\00", align 1
@__java_type_names.587 = internal constant [50 x i8] c"br/com/daruma/framework/mobile/gne/nfse/TiposNFSe\00", align 1
@__java_type_names.588 = internal constant [52 x i8] c"br/com/daruma/framework/mobile/gne/nfse/xml/Objetos\00", align 1
@__java_type_names.589 = internal constant [59 x i8] c"br/com/daruma/framework/mobile/gne/nfse/xml/Op_XmlAuxiliar\00", align 1
@__java_type_names.590 = internal constant [59 x i8] c"br/com/daruma/framework/mobile/gne/nfse/xml/Op_XmlConsulta\00", align 1
@__java_type_names.591 = internal constant [58 x i8] c"br/com/daruma/framework/mobile/gne/nfse/xml/Op_XmlRetorno\00", align 1
@__java_type_names.592 = internal constant [67 x i8] c"br/com/daruma/framework/mobile/gne/nfse/xml/Xml_ElementosEnvioNFSe\00", align 1
@__java_type_names.593 = internal constant [47 x i8] c"br/com/daruma/framework/mobile/gne/nfce/Layout\00", align 1
@__java_type_names.594 = internal constant [45 x i8] c"br/com/daruma/framework/mobile/gne/nfce/NFCe\00", align 1
@__java_type_names.595 = internal constant [50 x i8] c"br/com/daruma/framework/mobile/gne/nfce/TiposNFCe\00", align 1
@__java_type_names.596 = internal constant [52 x i8] c"br/com/daruma/framework/mobile/gne/nfce/xml/Objetos\00", align 1
@__java_type_names.597 = internal constant [59 x i8] c"br/com/daruma/framework/mobile/gne/nfce/xml/Op_XmlAuxiliar\00", align 1
@__java_type_names.598 = internal constant [55 x i8] c"br/com/daruma/framework/mobile/gne/nfce/xml/Op_XmlCanc\00", align 1
@__java_type_names.599 = internal constant [59 x i8] c"br/com/daruma/framework/mobile/gne/nfce/xml/Op_XmlConsulta\00", align 1
@__java_type_names.600 = internal constant [63 x i8] c"br/com/daruma/framework/mobile/gne/nfce/xml/Op_XmlContingencia\00", align 1
@__java_type_names.601 = internal constant [63 x i8] c"br/com/daruma/framework/mobile/gne/nfce/xml/Op_XmlInutilizacao\00", align 1
@__java_type_names.602 = internal constant [58 x i8] c"br/com/daruma/framework/mobile/gne/nfce/xml/Op_XmlRetorno\00", align 1
@__java_type_names.603 = internal constant [67 x i8] c"br/com/daruma/framework/mobile/gne/nfce/xml/Xml_ElementosEnvioNFCe\00", align 1
@__java_type_names.604 = internal constant [55 x i8] c"br/com/daruma/framework/mobile/gne/nfce/xml/classes/AC\00", align 1
@__java_type_names.605 = internal constant [55 x i8] c"br/com/daruma/framework/mobile/gne/nfce/xml/classes/AL\00", align 1
@__java_type_names.606 = internal constant [55 x i8] c"br/com/daruma/framework/mobile/gne/nfce/xml/classes/AM\00", align 1
@__java_type_names.607 = internal constant [55 x i8] c"br/com/daruma/framework/mobile/gne/nfce/xml/classes/AP\00", align 1
@__java_type_names.608 = internal constant [55 x i8] c"br/com/daruma/framework/mobile/gne/nfce/xml/classes/BA\00", align 1
@__java_type_names.609 = internal constant [55 x i8] c"br/com/daruma/framework/mobile/gne/nfce/xml/classes/CE\00", align 1
@__java_type_names.610 = internal constant [65 x i8] c"br/com/daruma/framework/mobile/gne/nfce/xml/classes/CideAuxiliar\00", align 1
@__java_type_names.611 = internal constant [71 x i8] c"br/com/daruma/framework/mobile/gne/nfce/xml/classes/CofinsAliqAuxiliar\00", align 1
@__java_type_names.612 = internal constant [69 x i8] c"br/com/daruma/framework/mobile/gne/nfce/xml/classes/CofinsNtAuxiliar\00", align 1
@__java_type_names.613 = internal constant [71 x i8] c"br/com/daruma/framework/mobile/gne/nfce/xml/classes/CofinsOutrAuxiliar\00", align 1
@__java_type_names.614 = internal constant [71 x i8] c"br/com/daruma/framework/mobile/gne/nfce/xml/classes/CofinsQtdeAuxiliar\00", align 1
@__java_type_names.615 = internal constant [69 x i8] c"br/com/daruma/framework/mobile/gne/nfce/xml/classes/CofinsSnAuxiliar\00", align 1
@__java_type_names.616 = internal constant [69 x i8] c"br/com/daruma/framework/mobile/gne/nfce/xml/classes/CofinsStAuxiliar\00", align 1
@__java_type_names.617 = internal constant [65 x i8] c"br/com/daruma/framework/mobile/gne/nfce/xml/classes/CombAuxiliar\00", align 1
@__java_type_names.618 = internal constant [73 x i8] c"br/com/daruma/framework/mobile/gne/nfce/xml/classes/ConfiguracaoAuxiliar\00", align 1
@__java_type_names.619 = internal constant [55 x i8] c"br/com/daruma/framework/mobile/gne/nfce/xml/classes/DF\00", align 1
@__java_type_names.620 = internal constant [73 x i8] c"br/com/daruma/framework/mobile/gne/nfce/xml/classes/ElementosXmlAuxiliar\00", align 1
@__java_type_names.621 = internal constant [77 x i8] c"br/com/daruma/framework/mobile/gne/nfce/xml/classes/ElementosXmlCancelamento\00", align 1
@__java_type_names.622 = internal constant [77 x i8] c"br/com/daruma/framework/mobile/gne/nfce/xml/classes/ElementosXMLContingencia\00", align 1
@__java_type_names.623 = internal constant [77 x i8] c"br/com/daruma/framework/mobile/gne/nfce/xml/classes/ElementosXMlInutilizacao\00", align 1
@__java_type_names.624 = internal constant [58 x i8] c"br/com/daruma/framework/mobile/gne/nfce/xml/classes/Email\00", align 1
@__java_type_names.625 = internal constant [65 x i8] c"br/com/daruma/framework/mobile/gne/nfce/xml/classes/EmitAuxiliar\00", align 1
@__java_type_names.626 = internal constant [70 x i8] c"br/com/daruma/framework/mobile/gne/nfce/xml/classes/EnderEmitAuxiliar\00", align 1
@__java_type_names.627 = internal constant [55 x i8] c"br/com/daruma/framework/mobile/gne/nfce/xml/classes/ES\00", align 1
@__java_type_names.628 = internal constant [55 x i8] c"br/com/daruma/framework/mobile/gne/nfce/xml/classes/GO\00", align 1
@__java_type_names.629 = internal constant [67 x i8] c"br/com/daruma/framework/mobile/gne/nfce/xml/classes/Icms00Auxiliar\00", align 1
@__java_type_names.630 = internal constant [67 x i8] c"br/com/daruma/framework/mobile/gne/nfce/xml/classes/Icms10Auxiliar\00", align 1
@__java_type_names.631 = internal constant [67 x i8] c"br/com/daruma/framework/mobile/gne/nfce/xml/classes/Icms20Auxiliar\00", align 1
@__java_type_names.632 = internal constant [67 x i8] c"br/com/daruma/framework/mobile/gne/nfce/xml/classes/Icms30Auxiliar\00", align 1
@__java_type_names.633 = internal constant [67 x i8] c"br/com/daruma/framework/mobile/gne/nfce/xml/classes/Icms40Auxiliar\00", align 1
@__java_type_names.634 = internal constant [67 x i8] c"br/com/daruma/framework/mobile/gne/nfce/xml/classes/Icms51Auxiliar\00", align 1
@__java_type_names.635 = internal constant [67 x i8] c"br/com/daruma/framework/mobile/gne/nfce/xml/classes/Icms60Auxiliar\00", align 1
@__java_type_names.636 = internal constant [67 x i8] c"br/com/daruma/framework/mobile/gne/nfce/xml/classes/Icms70Auxiliar\00", align 1
@__java_type_names.637 = internal constant [67 x i8] c"br/com/daruma/framework/mobile/gne/nfce/xml/classes/Icms90Auxiliar\00", align 1
@__java_type_names.638 = internal constant [69 x i8] c"br/com/daruma/framework/mobile/gne/nfce/xml/classes/IcmsPartAuxiliar\00", align 1
@__java_type_names.639 = internal constant [70 x i8] c"br/com/daruma/framework/mobile/gne/nfce/xml/classes/IcmsSn101Auxiliar\00", align 1
@__java_type_names.640 = internal constant [70 x i8] c"br/com/daruma/framework/mobile/gne/nfce/xml/classes/IcmsSn102Auxiliar\00", align 1
@__java_type_names.641 = internal constant [70 x i8] c"br/com/daruma/framework/mobile/gne/nfce/xml/classes/IcmsSn201Auxiliar\00", align 1
@__java_type_names.642 = internal constant [70 x i8] c"br/com/daruma/framework/mobile/gne/nfce/xml/classes/IcmsSn202Auxiliar\00", align 1
@__java_type_names.643 = internal constant [70 x i8] c"br/com/daruma/framework/mobile/gne/nfce/xml/classes/IcmsSn500Auxiliar\00", align 1
@__java_type_names.644 = internal constant [70 x i8] c"br/com/daruma/framework/mobile/gne/nfce/xml/classes/IcmsSn900Auxiliar\00", align 1
@__java_type_names.645 = internal constant [67 x i8] c"br/com/daruma/framework/mobile/gne/nfce/xml/classes/IcmsStAuxiliar\00", align 1
@__java_type_names.646 = internal constant [71 x i8] c"br/com/daruma/framework/mobile/gne/nfce/xml/classes/InfRespTecAuxiliar\00", align 1
@__java_type_names.647 = internal constant [66 x i8] c"br/com/daruma/framework/mobile/gne/nfce/xml/classes/IssQnAuxiliar\00", align 1
@__java_type_names.648 = internal constant [63 x i8] c"br/com/daruma/framework/mobile/gne/nfce/xml/classes/LeiImposto\00", align 1
@__java_type_names.649 = internal constant [55 x i8] c"br/com/daruma/framework/mobile/gne/nfce/xml/classes/MA\00", align 1
@__java_type_names.650 = internal constant [64 x i8] c"br/com/daruma/framework/mobile/gne/nfce/xml/classes/MedAuxiliar\00", align 1
@__java_type_names.651 = internal constant [55 x i8] c"br/com/daruma/framework/mobile/gne/nfce/xml/classes/MG\00", align 1
@__java_type_names.652 = internal constant [55 x i8] c"br/com/daruma/framework/mobile/gne/nfce/xml/classes/MS\00", align 1
@__java_type_names.653 = internal constant [67 x i8] c"br/com/daruma/framework/mobile/gne/nfce/xml/classes/MsgPromocional\00", align 1
@__java_type_names.654 = internal constant [55 x i8] c"br/com/daruma/framework/mobile/gne/nfce/xml/classes/MT\00", align 1
@__java_type_names.655 = internal constant [55 x i8] c"br/com/daruma/framework/mobile/gne/nfce/xml/classes/NT\00", align 1
@__java_type_names.656 = internal constant [55 x i8] c"br/com/daruma/framework/mobile/gne/nfce/xml/classes/PA\00", align 1
@__java_type_names.657 = internal constant [55 x i8] c"br/com/daruma/framework/mobile/gne/nfce/xml/classes/PB\00", align 1
@__java_type_names.658 = internal constant [55 x i8] c"br/com/daruma/framework/mobile/gne/nfce/xml/classes/PE\00", align 1
@__java_type_names.659 = internal constant [55 x i8] c"br/com/daruma/framework/mobile/gne/nfce/xml/classes/PI\00", align 1
@__java_type_names.660 = internal constant [68 x i8] c"br/com/daruma/framework/mobile/gne/nfce/xml/classes/PisAliqAuxiliar\00", align 1
@__java_type_names.661 = internal constant [66 x i8] c"br/com/daruma/framework/mobile/gne/nfce/xml/classes/PisNtAuxiliar\00", align 1
@__java_type_names.662 = internal constant [68 x i8] c"br/com/daruma/framework/mobile/gne/nfce/xml/classes/PisOutrAuxiliar\00", align 1
@__java_type_names.663 = internal constant [68 x i8] c"br/com/daruma/framework/mobile/gne/nfce/xml/classes/PisQtdeAuxiliar\00", align 1
@__java_type_names.664 = internal constant [66 x i8] c"br/com/daruma/framework/mobile/gne/nfce/xml/classes/PisSnAuxiliar\00", align 1
@__java_type_names.665 = internal constant [66 x i8] c"br/com/daruma/framework/mobile/gne/nfce/xml/classes/PisStAuxiliar\00", align 1
@__java_type_names.666 = internal constant [55 x i8] c"br/com/daruma/framework/mobile/gne/nfce/xml/classes/PR\00", align 1
@__java_type_names.667 = internal constant [60 x i8] c"br/com/daruma/framework/mobile/gne/nfce/xml/classes/PROCREF\00", align 1
@__java_type_names.668 = internal constant [65 x i8] c"br/com/daruma/framework/mobile/gne/nfce/xml/classes/ProdAuxiliar\00", align 1
@__java_type_names.669 = internal constant [55 x i8] c"br/com/daruma/framework/mobile/gne/nfce/xml/classes/RJ\00", align 1
@__java_type_names.670 = internal constant [55 x i8] c"br/com/daruma/framework/mobile/gne/nfce/xml/classes/RN\00", align 1
@__java_type_names.671 = internal constant [55 x i8] c"br/com/daruma/framework/mobile/gne/nfce/xml/classes/RO\00", align 1
@__java_type_names.672 = internal constant [55 x i8] c"br/com/daruma/framework/mobile/gne/nfce/xml/classes/RR\00", align 1
@__java_type_names.673 = internal constant [55 x i8] c"br/com/daruma/framework/mobile/gne/nfce/xml/classes/RS\00", align 1
@__java_type_names.674 = internal constant [55 x i8] c"br/com/daruma/framework/mobile/gne/nfce/xml/classes/SC\00", align 1
@__java_type_names.675 = internal constant [55 x i8] c"br/com/daruma/framework/mobile/gne/nfce/xml/classes/SE\00", align 1
@__java_type_names.676 = internal constant [55 x i8] c"br/com/daruma/framework/mobile/gne/nfce/xml/classes/SP\00", align 1
@__java_type_names.677 = internal constant [55 x i8] c"br/com/daruma/framework/mobile/gne/nfce/xml/classes/TO\00", align 1
@__java_type_names.678 = internal constant [70 x i8] c"br/com/daruma/framework/mobile/gne/nfce/xml/auxiliar/Aux_XmlAvisoServ\00", align 1
@__java_type_names.679 = internal constant [64 x i8] c"br/com/daruma/framework/mobile/gne/nfce/xml/auxiliar/Aux_XmlIde\00", align 1
@__java_type_names.680 = internal constant [72 x i8] c"br/com/daruma/framework/mobile/gne/nfce/xml/auxiliar/Aux_XmlInfIntermed\00", align 1
@__java_type_names.681 = internal constant [65 x i8] c"br/com/daruma/framework/mobile/gne/nfce/xml/auxiliar/Aux_XmlNfce\00", align 1
@__java_type_names.682 = internal constant [67 x i8] c"br/com/daruma/framework/mobile/gne/nfce/xml/auxiliar/Aux_XmlTransp\00", align 1
@__java_type_names.683 = internal constant [46 x i8] c"br/com/daruma/framework/mobile/gne/imp/Daruma\00", align 1
@__java_type_names.684 = internal constant [51 x i8] c"br/com/daruma/framework/mobile/gne/imp/Daruma_2100\00", align 1
@__java_type_names.685 = internal constant [50 x i8] c"br/com/daruma/framework/mobile/gne/imp/Daruma_250\00", align 1
@__java_type_names.686 = internal constant [50 x i8] c"br/com/daruma/framework/mobile/gne/imp/Daruma_350\00", align 1
@__java_type_names.687 = internal constant [46 x i8] c"br/com/daruma/framework/mobile/gne/imp/Dascom\00", align 1
@__java_type_names.688 = internal constant [49 x i8] c"br/com/daruma/framework/mobile/gne/imp/Datec_250\00", align 1
@__java_type_names.689 = internal constant [49 x i8] c"br/com/daruma/framework/mobile/gne/imp/Datec_350\00", align 1
@__java_type_names.690 = internal constant [45 x i8] c"br/com/daruma/framework/mobile/gne/imp/EPSON\00", align 1
@__java_type_names.691 = internal constant [50 x i8] c"br/com/daruma/framework/mobile/gne/imp/Formatacao\00", align 1
@__java_type_names.692 = internal constant [43 x i8] c"br/com/daruma/framework/mobile/gne/imp/M10\00", align 1
@__java_type_names.693 = internal constant [45 x i8] c"br/com/daruma/framework/mobile/gne/imp/Nonus\00", align 1
@__java_type_names.694 = internal constant [42 x i8] c"br/com/daruma/framework/mobile/gne/imp/Q4\00", align 1
@__java_type_names.695 = internal constant [50 x i8] c"br/com/daruma/framework/mobile/gne/imp/TECTOY_250\00", align 1
@__java_type_names.696 = internal constant [50 x i8] c"br/com/daruma/framework/mobile/gne/imp/TECTOY_380\00", align 1
@__java_type_names.697 = internal constant [64 x i8] c"br/com/daruma/framework/mobile/exception/DarumaCheckedException\00", align 1
@__java_type_names.698 = internal constant [68 x i8] c"br/com/daruma/framework/mobile/exception/DarumaComunicacaoException\00", align 1
@__java_type_names.699 = internal constant [60 x i8] c"br/com/daruma/framework/mobile/exception/DarumaECFException\00", align 1
@__java_type_names.700 = internal constant [57 x i8] c"br/com/daruma/framework/mobile/exception/DarumaException\00", align 1
@__java_type_names.701 = internal constant [60 x i8] c"br/com/daruma/framework/mobile/exception/DarumaSatException\00", align 1
@__java_type_names.702 = internal constant [61 x i8] c"br/com/daruma/framework/mobile/exception/DarumaScanException\00", align 1
@__java_type_names.703 = internal constant [67 x i8] c"br/com/daruma/framework/mobile/exception/DarumaWebServiceException\00", align 1
@__java_type_names.704 = internal constant [62 x i8] c"br/com/daruma/framework/mobile/constantes/ConstantesFramework\00", align 1
@__java_type_names.705 = internal constant [61 x i8] c"br/com/daruma/framework/mobile/constantes/ConstantesGenerico\00", align 1
@__java_type_names.706 = internal constant [59 x i8] c"br/com/daruma/framework/mobile/constantes/ConstantesSocket\00", align 1
@__java_type_names.707 = internal constant [65 x i8] c"br/com/daruma/framework/mobile/constantes/IConstantesComunicacao\00", align 1
@__java_type_names.708 = internal constant [56 x i8] c"br/com/daruma/framework/mobile/comunicacao/AComunicacao\00", align 1
@__java_type_names.709 = internal constant [64 x i8] c"br/com/daruma/framework/mobile/comunicacao/impl/BluetoothDaruma\00", align 1
@__java_type_names.710 = internal constant [73 x i8] c"br/com/daruma/framework/mobile/comunicacao/impl/BluetoothDaruma$ReadTask\00", align 1
@__java_type_names.711 = internal constant [67 x i8] c"br/com/daruma/framework/mobile/comunicacao/impl/ComunicacaoNaoImpl\00", align 1
@__java_type_names.712 = internal constant [61 x i8] c"br/com/daruma/framework/mobile/comunicacao/impl/SerialDaruma\00", align 1
@__java_type_names.713 = internal constant [61 x i8] c"br/com/daruma/framework/mobile/comunicacao/impl/SocketDaruma\00", align 1
@__java_type_names.714 = internal constant [58 x i8] c"br/com/daruma/framework/mobile/comunicacao/impl/UsbDaruma\00", align 1
@__java_type_names.715 = internal constant [80 x i8] c"br/com/daruma/framework/mobile/comunicacao/exception/DarumaComunicacaoException\00", align 1
@__java_type_names.716 = internal constant [72 x i8] c"br/com/daruma/framework/mobile/comunicacao/exception/DarumaECFException\00", align 1
@__java_type_names.717 = internal constant [69 x i8] c"br/com/daruma/framework/mobile/comunicacao/exception/DarumaException\00", align 1
@__java_type_names.718 = internal constant [58 x i8] c"br/com/daruma/framework/mobile/camera/DarumaConfigScanner\00", align 1
@__java_type_names.719 = internal constant [52 x i8] c"br/com/daruma/framework/mobile/camera/DarumaScanner\00", align 1
@__java_type_names.720 = internal constant [55 x i8] c"br/com/daruma/framework/mobile/camera/DarumaScanResult\00", align 1
@__java_type_names.721 = internal constant [63 x i8] c"br/com/daruma/framework/mobile/camera/dependencies/BeepManager\00", align 1
@__java_type_names.722 = internal constant [67 x i8] c"br/com/daruma/framework/mobile/camera/dependencies/DecodeAsyncTask\00", align 1
@__java_type_names.723 = internal constant [71 x i8] c"br/com/daruma/framework/mobile/camera/dependencies/DecodeFormatManager\00", align 1
@__java_type_names.724 = internal constant [65 x i8] c"br/com/daruma/framework/mobile/camera/dependencies/DecodeHandler\00", align 1
@__java_type_names.725 = internal constant [64 x i8] c"br/com/daruma/framework/mobile/camera/dependencies/DecodeThread\00", align 1
@__java_type_names.726 = internal constant [66 x i8] c"br/com/daruma/framework/mobile/camera/dependencies/FinishListener\00", align 1
@__java_type_names.727 = internal constant [67 x i8] c"br/com/daruma/framework/mobile/camera/dependencies/InactivityTimer\00", align 1
@__java_type_names.728 = internal constant [87 x i8] c"br/com/daruma/framework/mobile/camera/dependencies/InactivityTimer$DaemonThreadFactory\00", align 1
@__java_type_names.729 = internal constant [87 x i8] c"br/com/daruma/framework/mobile/camera/dependencies/InactivityTimer$PowerStatusReceiver\00", align 1
@__java_type_names.730 = internal constant [59 x i8] c"br/com/daruma/framework/mobile/camera/dependencies/Intents\00", align 1
@__java_type_names.731 = internal constant [64 x i8] c"br/com/daruma/framework/mobile/camera/dependencies/Intents$Scan\00", align 1
@__java_type_names.732 = internal constant [64 x i8] c"br/com/daruma/framework/mobile/camera/dependencies/ISendHandler\00", align 1
@__java_type_names.733 = internal constant [66 x i8] c"br/com/daruma/framework/mobile/camera/dependencies/ViewfinderView\00", align 1
@__java_type_names.734 = internal constant [79 x i8] c"br/com/daruma/framework/mobile/camera/dependencies/integrator/IVariaveisScaner\00", align 1
@__java_type_names.735 = internal constant [73 x i8] c"br/com/daruma/framework/mobile/camera/dependencies/config/ZXingLibConfig\00", align 1
@__java_type_names.736 = internal constant [72 x i8] c"br/com/daruma/framework/mobile/camera/dependencies/camera/CameraManager\00", align 1
@__java_type_names.737 = internal constant [51 x i8] c"com/google/common/util/concurrent/ListenableFuture\00", align 1
@__java_type_names.738 = internal constant [54 x i8] c"androidx/lifecycle/HasDefaultViewModelProviderFactory\00", align 1
@__java_type_names.739 = internal constant [39 x i8] c"androidx/lifecycle/ViewModelStoreOwner\00", align 1
@__java_type_names.740 = internal constant [37 x i8] c"androidx/lifecycle/ViewModelProvider\00", align 1
@__java_type_names.741 = internal constant [45 x i8] c"androidx/lifecycle/ViewModelProvider$Factory\00", align 1
@__java_type_names.742 = internal constant [34 x i8] c"androidx/lifecycle/ViewModelStore\00", align 1

@java_type_names = local_unnamed_addr constant [743 x i8*] [
	i8* getelementptr inbounds ([42 x i8], [42 x i8]* @__java_type_names.0, i32 0, i32 0),
	i8* getelementptr inbounds ([57 x i8], [57 x i8]* @__java_type_names.1, i32 0, i32 0),
	i8* getelementptr inbounds ([73 x i8], [73 x i8]* @__java_type_names.2, i32 0, i32 0),
	i8* getelementptr inbounds ([29 x i8], [29 x i8]* @__java_type_names.3, i32 0, i32 0),
	i8* getelementptr inbounds ([35 x i8], [35 x i8]* @__java_type_names.4, i32 0, i32 0),
	i8* getelementptr inbounds ([37 x i8], [37 x i8]* @__java_type_names.5, i32 0, i32 0),
	i8* getelementptr inbounds ([34 x i8], [34 x i8]* @__java_type_names.6, i32 0, i32 0),
	i8* getelementptr inbounds ([34 x i8], [34 x i8]* @__java_type_names.7, i32 0, i32 0),
	i8* getelementptr inbounds ([58 x i8], [58 x i8]* @__java_type_names.8, i32 0, i32 0),
	i8* getelementptr inbounds ([74 x i8], [74 x i8]* @__java_type_names.9, i32 0, i32 0),
	i8* getelementptr inbounds ([53 x i8], [53 x i8]* @__java_type_names.10, i32 0, i32 0),
	i8* getelementptr inbounds ([69 x i8], [69 x i8]* @__java_type_names.11, i32 0, i32 0),
	i8* getelementptr inbounds ([48 x i8], [48 x i8]* @__java_type_names.12, i32 0, i32 0),
	i8* getelementptr inbounds ([48 x i8], [48 x i8]* @__java_type_names.13, i32 0, i32 0),
	i8* getelementptr inbounds ([54 x i8], [54 x i8]* @__java_type_names.14, i32 0, i32 0),
	i8* getelementptr inbounds ([38 x i8], [38 x i8]* @__java_type_names.15, i32 0, i32 0),
	i8* getelementptr inbounds ([48 x i8], [48 x i8]* @__java_type_names.16, i32 0, i32 0),
	i8* getelementptr inbounds ([46 x i8], [46 x i8]* @__java_type_names.17, i32 0, i32 0),
	i8* getelementptr inbounds ([40 x i8], [40 x i8]* @__java_type_names.18, i32 0, i32 0),
	i8* getelementptr inbounds ([44 x i8], [44 x i8]* @__java_type_names.19, i32 0, i32 0),
	i8* getelementptr inbounds ([36 x i8], [36 x i8]* @__java_type_names.20, i32 0, i32 0),
	i8* getelementptr inbounds ([43 x i8], [43 x i8]* @__java_type_names.21, i32 0, i32 0),
	i8* getelementptr inbounds ([33 x i8], [33 x i8]* @__java_type_names.22, i32 0, i32 0),
	i8* getelementptr inbounds ([68 x i8], [68 x i8]* @__java_type_names.23, i32 0, i32 0),
	i8* getelementptr inbounds ([58 x i8], [58 x i8]* @__java_type_names.24, i32 0, i32 0),
	i8* getelementptr inbounds ([72 x i8], [72 x i8]* @__java_type_names.25, i32 0, i32 0),
	i8* getelementptr inbounds ([36 x i8], [36 x i8]* @__java_type_names.26, i32 0, i32 0),
	i8* getelementptr inbounds ([46 x i8], [46 x i8]* @__java_type_names.27, i32 0, i32 0),
	i8* getelementptr inbounds ([40 x i8], [40 x i8]* @__java_type_names.28, i32 0, i32 0),
	i8* getelementptr inbounds ([70 x i8], [70 x i8]* @__java_type_names.29, i32 0, i32 0),
	i8* getelementptr inbounds ([35 x i8], [35 x i8]* @__java_type_names.30, i32 0, i32 0),
	i8* getelementptr inbounds ([53 x i8], [53 x i8]* @__java_type_names.31, i32 0, i32 0),
	i8* getelementptr inbounds ([44 x i8], [44 x i8]* @__java_type_names.32, i32 0, i32 0),
	i8* getelementptr inbounds ([39 x i8], [39 x i8]* @__java_type_names.33, i32 0, i32 0),
	i8* getelementptr inbounds ([58 x i8], [58 x i8]* @__java_type_names.34, i32 0, i32 0),
	i8* getelementptr inbounds ([39 x i8], [39 x i8]* @__java_type_names.35, i32 0, i32 0),
	i8* getelementptr inbounds ([31 x i8], [31 x i8]* @__java_type_names.36, i32 0, i32 0),
	i8* getelementptr inbounds ([42 x i8], [42 x i8]* @__java_type_names.37, i32 0, i32 0),
	i8* getelementptr inbounds ([38 x i8], [38 x i8]* @__java_type_names.38, i32 0, i32 0),
	i8* getelementptr inbounds ([38 x i8], [38 x i8]* @__java_type_names.39, i32 0, i32 0),
	i8* getelementptr inbounds ([53 x i8], [53 x i8]* @__java_type_names.40, i32 0, i32 0),
	i8* getelementptr inbounds ([65 x i8], [65 x i8]* @__java_type_names.41, i32 0, i32 0),
	i8* getelementptr inbounds ([65 x i8], [65 x i8]* @__java_type_names.42, i32 0, i32 0),
	i8* getelementptr inbounds ([81 x i8], [81 x i8]* @__java_type_names.43, i32 0, i32 0),
	i8* getelementptr inbounds ([42 x i8], [42 x i8]* @__java_type_names.44, i32 0, i32 0),
	i8* getelementptr inbounds ([55 x i8], [55 x i8]* @__java_type_names.45, i32 0, i32 0),
	i8* getelementptr inbounds ([31 x i8], [31 x i8]* @__java_type_names.46, i32 0, i32 0),
	i8* getelementptr inbounds ([54 x i8], [54 x i8]* @__java_type_names.47, i32 0, i32 0),
	i8* getelementptr inbounds ([54 x i8], [54 x i8]* @__java_type_names.48, i32 0, i32 0),
	i8* getelementptr inbounds ([34 x i8], [34 x i8]* @__java_type_names.49, i32 0, i32 0),
	i8* getelementptr inbounds ([50 x i8], [50 x i8]* @__java_type_names.50, i32 0, i32 0),
	i8* getelementptr inbounds ([47 x i8], [47 x i8]* @__java_type_names.51, i32 0, i32 0),
	i8* getelementptr inbounds ([32 x i8], [32 x i8]* @__java_type_names.52, i32 0, i32 0),
	i8* getelementptr inbounds ([36 x i8], [36 x i8]* @__java_type_names.53, i32 0, i32 0),
	i8* getelementptr inbounds ([28 x i8], [28 x i8]* @__java_type_names.54, i32 0, i32 0),
	i8* getelementptr inbounds ([24 x i8], [24 x i8]* @__java_type_names.55, i32 0, i32 0),
	i8* getelementptr inbounds ([33 x i8], [33 x i8]* @__java_type_names.56, i32 0, i32 0),
	i8* getelementptr inbounds ([31 x i8], [31 x i8]* @__java_type_names.57, i32 0, i32 0),
	i8* getelementptr inbounds ([25 x i8], [25 x i8]* @__java_type_names.58, i32 0, i32 0),
	i8* getelementptr inbounds ([25 x i8], [25 x i8]* @__java_type_names.59, i32 0, i32 0),
	i8* getelementptr inbounds ([32 x i8], [32 x i8]* @__java_type_names.60, i32 0, i32 0),
	i8* getelementptr inbounds ([27 x i8], [27 x i8]* @__java_type_names.61, i32 0, i32 0),
	i8* getelementptr inbounds ([31 x i8], [31 x i8]* @__java_type_names.62, i32 0, i32 0),
	i8* getelementptr inbounds ([32 x i8], [32 x i8]* @__java_type_names.63, i32 0, i32 0),
	i8* getelementptr inbounds ([25 x i8], [25 x i8]* @__java_type_names.64, i32 0, i32 0),
	i8* getelementptr inbounds ([31 x i8], [31 x i8]* @__java_type_names.65, i32 0, i32 0),
	i8* getelementptr inbounds ([34 x i8], [34 x i8]* @__java_type_names.66, i32 0, i32 0),
	i8* getelementptr inbounds ([37 x i8], [37 x i8]* @__java_type_names.67, i32 0, i32 0),
	i8* getelementptr inbounds ([39 x i8], [39 x i8]* @__java_type_names.68, i32 0, i32 0),
	i8* getelementptr inbounds ([27 x i8], [27 x i8]* @__java_type_names.69, i32 0, i32 0),
	i8* getelementptr inbounds ([50 x i8], [50 x i8]* @__java_type_names.70, i32 0, i32 0),
	i8* getelementptr inbounds ([22 x i8], [22 x i8]* @__java_type_names.71, i32 0, i32 0),
	i8* getelementptr inbounds ([24 x i8], [24 x i8]* @__java_type_names.72, i32 0, i32 0),
	i8* getelementptr inbounds ([27 x i8], [27 x i8]* @__java_type_names.73, i32 0, i32 0),
	i8* getelementptr inbounds ([36 x i8], [36 x i8]* @__java_type_names.74, i32 0, i32 0),
	i8* getelementptr inbounds ([23 x i8], [23 x i8]* @__java_type_names.75, i32 0, i32 0),
	i8* getelementptr inbounds ([30 x i8], [30 x i8]* @__java_type_names.76, i32 0, i32 0),
	i8* getelementptr inbounds ([24 x i8], [24 x i8]* @__java_type_names.77, i32 0, i32 0),
	i8* getelementptr inbounds ([21 x i8], [21 x i8]* @__java_type_names.78, i32 0, i32 0),
	i8* getelementptr inbounds ([24 x i8], [24 x i8]* @__java_type_names.79, i32 0, i32 0),
	i8* getelementptr inbounds ([33 x i8], [33 x i8]* @__java_type_names.80, i32 0, i32 0),
	i8* getelementptr inbounds ([28 x i8], [28 x i8]* @__java_type_names.81, i32 0, i32 0),
	i8* getelementptr inbounds ([33 x i8], [33 x i8]* @__java_type_names.82, i32 0, i32 0),
	i8* getelementptr inbounds ([21 x i8], [21 x i8]* @__java_type_names.83, i32 0, i32 0),
	i8* getelementptr inbounds ([23 x i8], [23 x i8]* @__java_type_names.84, i32 0, i32 0),
	i8* getelementptr inbounds ([41 x i8], [41 x i8]* @__java_type_names.85, i32 0, i32 0),
	i8* getelementptr inbounds ([25 x i8], [25 x i8]* @__java_type_names.86, i32 0, i32 0),
	i8* getelementptr inbounds ([18 x i8], [18 x i8]* @__java_type_names.87, i32 0, i32 0),
	i8* getelementptr inbounds ([45 x i8], [45 x i8]* @__java_type_names.88, i32 0, i32 0),
	i8* getelementptr inbounds ([46 x i8], [46 x i8]* @__java_type_names.89, i32 0, i32 0),
	i8* getelementptr inbounds ([22 x i8], [22 x i8]* @__java_type_names.90, i32 0, i32 0),
	i8* getelementptr inbounds ([24 x i8], [24 x i8]* @__java_type_names.91, i32 0, i32 0),
	i8* getelementptr inbounds ([21 x i8], [21 x i8]* @__java_type_names.92, i32 0, i32 0),
	i8* getelementptr inbounds ([36 x i8], [36 x i8]* @__java_type_names.93, i32 0, i32 0),
	i8* getelementptr inbounds ([27 x i8], [27 x i8]* @__java_type_names.94, i32 0, i32 0),
	i8* getelementptr inbounds ([25 x i8], [25 x i8]* @__java_type_names.95, i32 0, i32 0),
	i8* getelementptr inbounds ([24 x i8], [24 x i8]* @__java_type_names.96, i32 0, i32 0),
	i8* getelementptr inbounds ([40 x i8], [40 x i8]* @__java_type_names.97, i32 0, i32 0),
	i8* getelementptr inbounds ([27 x i8], [27 x i8]* @__java_type_names.98, i32 0, i32 0),
	i8* getelementptr inbounds ([35 x i8], [35 x i8]* @__java_type_names.99, i32 0, i32 0),
	i8* getelementptr inbounds ([22 x i8], [22 x i8]* @__java_type_names.100, i32 0, i32 0),
	i8* getelementptr inbounds ([31 x i8], [31 x i8]* @__java_type_names.101, i32 0, i32 0),
	i8* getelementptr inbounds ([28 x i8], [28 x i8]* @__java_type_names.102, i32 0, i32 0),
	i8* getelementptr inbounds ([36 x i8], [36 x i8]* @__java_type_names.103, i32 0, i32 0),
	i8* getelementptr inbounds ([37 x i8], [37 x i8]* @__java_type_names.104, i32 0, i32 0),
	i8* getelementptr inbounds ([26 x i8], [26 x i8]* @__java_type_names.105, i32 0, i32 0),
	i8* getelementptr inbounds ([25 x i8], [25 x i8]* @__java_type_names.106, i32 0, i32 0),
	i8* getelementptr inbounds ([25 x i8], [25 x i8]* @__java_type_names.107, i32 0, i32 0),
	i8* getelementptr inbounds ([21 x i8], [21 x i8]* @__java_type_names.108, i32 0, i32 0),
	i8* getelementptr inbounds ([18 x i8], [18 x i8]* @__java_type_names.109, i32 0, i32 0),
	i8* getelementptr inbounds ([34 x i8], [34 x i8]* @__java_type_names.110, i32 0, i32 0),
	i8* getelementptr inbounds ([50 x i8], [50 x i8]* @__java_type_names.111, i32 0, i32 0),
	i8* getelementptr inbounds ([46 x i8], [46 x i8]* @__java_type_names.112, i32 0, i32 0),
	i8* getelementptr inbounds ([23 x i8], [23 x i8]* @__java_type_names.113, i32 0, i32 0),
	i8* getelementptr inbounds ([36 x i8], [36 x i8]* @__java_type_names.114, i32 0, i32 0),
	i8* getelementptr inbounds ([42 x i8], [42 x i8]* @__java_type_names.115, i32 0, i32 0),
	i8* getelementptr inbounds ([34 x i8], [34 x i8]* @__java_type_names.116, i32 0, i32 0),
	i8* getelementptr inbounds ([30 x i8], [30 x i8]* @__java_type_names.117, i32 0, i32 0),
	i8* getelementptr inbounds ([48 x i8], [48 x i8]* @__java_type_names.118, i32 0, i32 0),
	i8* getelementptr inbounds ([20 x i8], [20 x i8]* @__java_type_names.119, i32 0, i32 0),
	i8* getelementptr inbounds ([29 x i8], [29 x i8]* @__java_type_names.120, i32 0, i32 0),
	i8* getelementptr inbounds ([27 x i8], [27 x i8]* @__java_type_names.121, i32 0, i32 0),
	i8* getelementptr inbounds ([33 x i8], [33 x i8]* @__java_type_names.122, i32 0, i32 0),
	i8* getelementptr inbounds ([36 x i8], [36 x i8]* @__java_type_names.123, i32 0, i32 0),
	i8* getelementptr inbounds ([46 x i8], [46 x i8]* @__java_type_names.124, i32 0, i32 0),
	i8* getelementptr inbounds ([47 x i8], [47 x i8]* @__java_type_names.125, i32 0, i32 0),
	i8* getelementptr inbounds ([52 x i8], [52 x i8]* @__java_type_names.126, i32 0, i32 0),
	i8* getelementptr inbounds ([30 x i8], [30 x i8]* @__java_type_names.127, i32 0, i32 0),
	i8* getelementptr inbounds ([28 x i8], [28 x i8]* @__java_type_names.128, i32 0, i32 0),
	i8* getelementptr inbounds ([26 x i8], [26 x i8]* @__java_type_names.129, i32 0, i32 0),
	i8* getelementptr inbounds ([25 x i8], [25 x i8]* @__java_type_names.130, i32 0, i32 0),
	i8* getelementptr inbounds ([37 x i8], [37 x i8]* @__java_type_names.131, i32 0, i32 0),
	i8* getelementptr inbounds ([21 x i8], [21 x i8]* @__java_type_names.132, i32 0, i32 0),
	i8* getelementptr inbounds ([22 x i8], [22 x i8]* @__java_type_names.133, i32 0, i32 0),
	i8* getelementptr inbounds ([17 x i8], [17 x i8]* @__java_type_names.134, i32 0, i32 0),
	i8* getelementptr inbounds ([25 x i8], [25 x i8]* @__java_type_names.135, i32 0, i32 0),
	i8* getelementptr inbounds ([18 x i8], [18 x i8]* @__java_type_names.136, i32 0, i32 0),
	i8* getelementptr inbounds ([19 x i8], [19 x i8]* @__java_type_names.137, i32 0, i32 0),
	i8* getelementptr inbounds ([34 x i8], [34 x i8]* @__java_type_names.138, i32 0, i32 0),
	i8* getelementptr inbounds ([19 x i8], [19 x i8]* @__java_type_names.139, i32 0, i32 0),
	i8* getelementptr inbounds ([22 x i8], [22 x i8]* @__java_type_names.140, i32 0, i32 0),
	i8* getelementptr inbounds ([30 x i8], [30 x i8]* @__java_type_names.141, i32 0, i32 0),
	i8* getelementptr inbounds ([22 x i8], [22 x i8]* @__java_type_names.142, i32 0, i32 0),
	i8* getelementptr inbounds ([18 x i8], [18 x i8]* @__java_type_names.143, i32 0, i32 0),
	i8* getelementptr inbounds ([18 x i8], [18 x i8]* @__java_type_names.144, i32 0, i32 0),
	i8* getelementptr inbounds ([27 x i8], [27 x i8]* @__java_type_names.145, i32 0, i32 0),
	i8* getelementptr inbounds ([23 x i8], [23 x i8]* @__java_type_names.146, i32 0, i32 0),
	i8* getelementptr inbounds ([16 x i8], [16 x i8]* @__java_type_names.147, i32 0, i32 0),
	i8* getelementptr inbounds ([24 x i8], [24 x i8]* @__java_type_names.148, i32 0, i32 0),
	i8* getelementptr inbounds ([40 x i8], [40 x i8]* @__java_type_names.149, i32 0, i32 0),
	i8* getelementptr inbounds ([31 x i8], [31 x i8]* @__java_type_names.150, i32 0, i32 0),
	i8* getelementptr inbounds ([41 x i8], [41 x i8]* @__java_type_names.151, i32 0, i32 0),
	i8* getelementptr inbounds ([33 x i8], [33 x i8]* @__java_type_names.152, i32 0, i32 0),
	i8* getelementptr inbounds ([32 x i8], [32 x i8]* @__java_type_names.153, i32 0, i32 0),
	i8* getelementptr inbounds ([32 x i8], [32 x i8]* @__java_type_names.154, i32 0, i32 0),
	i8* getelementptr inbounds ([24 x i8], [24 x i8]* @__java_type_names.155, i32 0, i32 0),
	i8* getelementptr inbounds ([27 x i8], [27 x i8]* @__java_type_names.156, i32 0, i32 0),
	i8* getelementptr inbounds ([24 x i8], [24 x i8]* @__java_type_names.157, i32 0, i32 0),
	i8* getelementptr inbounds ([29 x i8], [29 x i8]* @__java_type_names.158, i32 0, i32 0),
	i8* getelementptr inbounds ([24 x i8], [24 x i8]* @__java_type_names.159, i32 0, i32 0),
	i8* getelementptr inbounds ([23 x i8], [23 x i8]* @__java_type_names.160, i32 0, i32 0),
	i8* getelementptr inbounds ([23 x i8], [23 x i8]* @__java_type_names.161, i32 0, i32 0),
	i8* getelementptr inbounds ([28 x i8], [28 x i8]* @__java_type_names.162, i32 0, i32 0),
	i8* getelementptr inbounds ([33 x i8], [33 x i8]* @__java_type_names.163, i32 0, i32 0),
	i8* getelementptr inbounds ([22 x i8], [22 x i8]* @__java_type_names.164, i32 0, i32 0),
	i8* getelementptr inbounds ([23 x i8], [23 x i8]* @__java_type_names.165, i32 0, i32 0),
	i8* getelementptr inbounds ([35 x i8], [35 x i8]* @__java_type_names.166, i32 0, i32 0),
	i8* getelementptr inbounds ([44 x i8], [44 x i8]* @__java_type_names.167, i32 0, i32 0),
	i8* getelementptr inbounds ([33 x i8], [33 x i8]* @__java_type_names.168, i32 0, i32 0),
	i8* getelementptr inbounds ([27 x i8], [27 x i8]* @__java_type_names.169, i32 0, i32 0),
	i8* getelementptr inbounds ([44 x i8], [44 x i8]* @__java_type_names.170, i32 0, i32 0),
	i8* getelementptr inbounds ([49 x i8], [49 x i8]* @__java_type_names.171, i32 0, i32 0),
	i8* getelementptr inbounds ([42 x i8], [42 x i8]* @__java_type_names.172, i32 0, i32 0),
	i8* getelementptr inbounds ([35 x i8], [35 x i8]* @__java_type_names.173, i32 0, i32 0),
	i8* getelementptr inbounds ([21 x i8], [21 x i8]* @__java_type_names.174, i32 0, i32 0),
	i8* getelementptr inbounds ([24 x i8], [24 x i8]* @__java_type_names.175, i32 0, i32 0),
	i8* getelementptr inbounds ([51 x i8], [51 x i8]* @__java_type_names.176, i32 0, i32 0),
	i8* getelementptr inbounds ([19 x i8], [19 x i8]* @__java_type_names.177, i32 0, i32 0),
	i8* getelementptr inbounds ([26 x i8], [26 x i8]* @__java_type_names.178, i32 0, i32 0),
	i8* getelementptr inbounds ([34 x i8], [34 x i8]* @__java_type_names.179, i32 0, i32 0),
	i8* getelementptr inbounds ([30 x i8], [30 x i8]* @__java_type_names.180, i32 0, i32 0),
	i8* getelementptr inbounds ([24 x i8], [24 x i8]* @__java_type_names.181, i32 0, i32 0),
	i8* getelementptr inbounds ([31 x i8], [31 x i8]* @__java_type_names.182, i32 0, i32 0),
	i8* getelementptr inbounds ([35 x i8], [35 x i8]* @__java_type_names.183, i32 0, i32 0),
	i8* getelementptr inbounds ([36 x i8], [36 x i8]* @__java_type_names.184, i32 0, i32 0),
	i8* getelementptr inbounds ([49 x i8], [49 x i8]* @__java_type_names.185, i32 0, i32 0),
	i8* getelementptr inbounds ([48 x i8], [48 x i8]* @__java_type_names.186, i32 0, i32 0),
	i8* getelementptr inbounds ([32 x i8], [32 x i8]* @__java_type_names.187, i32 0, i32 0),
	i8* getelementptr inbounds ([23 x i8], [23 x i8]* @__java_type_names.188, i32 0, i32 0),
	i8* getelementptr inbounds ([29 x i8], [29 x i8]* @__java_type_names.189, i32 0, i32 0),
	i8* getelementptr inbounds ([34 x i8], [34 x i8]* @__java_type_names.190, i32 0, i32 0),
	i8* getelementptr inbounds ([41 x i8], [41 x i8]* @__java_type_names.191, i32 0, i32 0),
	i8* getelementptr inbounds ([67 x i8], [67 x i8]* @__java_type_names.192, i32 0, i32 0),
	i8* getelementptr inbounds ([34 x i8], [34 x i8]* @__java_type_names.193, i32 0, i32 0),
	i8* getelementptr inbounds ([35 x i8], [35 x i8]* @__java_type_names.194, i32 0, i32 0),
	i8* getelementptr inbounds ([34 x i8], [34 x i8]* @__java_type_names.195, i32 0, i32 0),
	i8* getelementptr inbounds ([30 x i8], [30 x i8]* @__java_type_names.196, i32 0, i32 0),
	i8* getelementptr inbounds ([31 x i8], [31 x i8]* @__java_type_names.197, i32 0, i32 0),
	i8* getelementptr inbounds ([34 x i8], [34 x i8]* @__java_type_names.198, i32 0, i32 0),
	i8* getelementptr inbounds ([40 x i8], [40 x i8]* @__java_type_names.199, i32 0, i32 0),
	i8* getelementptr inbounds ([31 x i8], [31 x i8]* @__java_type_names.200, i32 0, i32 0),
	i8* getelementptr inbounds ([21 x i8], [21 x i8]* @__java_type_names.201, i32 0, i32 0),
	i8* getelementptr inbounds ([18 x i8], [18 x i8]* @__java_type_names.202, i32 0, i32 0),
	i8* getelementptr inbounds ([20 x i8], [20 x i8]* @__java_type_names.203, i32 0, i32 0),
	i8* getelementptr inbounds ([32 x i8], [32 x i8]* @__java_type_names.204, i32 0, i32 0),
	i8* getelementptr inbounds ([35 x i8], [35 x i8]* @__java_type_names.205, i32 0, i32 0),
	i8* getelementptr inbounds ([18 x i8], [18 x i8]* @__java_type_names.206, i32 0, i32 0),
	i8* getelementptr inbounds ([41 x i8], [41 x i8]* @__java_type_names.207, i32 0, i32 0),
	i8* getelementptr inbounds ([29 x i8], [29 x i8]* @__java_type_names.208, i32 0, i32 0),
	i8* getelementptr inbounds ([22 x i8], [22 x i8]* @__java_type_names.209, i32 0, i32 0),
	i8* getelementptr inbounds ([17 x i8], [17 x i8]* @__java_type_names.210, i32 0, i32 0),
	i8* getelementptr inbounds ([15 x i8], [15 x i8]* @__java_type_names.211, i32 0, i32 0),
	i8* getelementptr inbounds ([18 x i8], [18 x i8]* @__java_type_names.212, i32 0, i32 0),
	i8* getelementptr inbounds ([21 x i8], [21 x i8]* @__java_type_names.213, i32 0, i32 0),
	i8* getelementptr inbounds ([22 x i8], [22 x i8]* @__java_type_names.214, i32 0, i32 0),
	i8* getelementptr inbounds ([19 x i8], [19 x i8]* @__java_type_names.215, i32 0, i32 0),
	i8* getelementptr inbounds ([14 x i8], [14 x i8]* @__java_type_names.216, i32 0, i32 0),
	i8* getelementptr inbounds ([22 x i8], [22 x i8]* @__java_type_names.217, i32 0, i32 0),
	i8* getelementptr inbounds ([17 x i8], [17 x i8]* @__java_type_names.218, i32 0, i32 0),
	i8* getelementptr inbounds ([30 x i8], [30 x i8]* @__java_type_names.219, i32 0, i32 0),
	i8* getelementptr inbounds ([26 x i8], [26 x i8]* @__java_type_names.220, i32 0, i32 0),
	i8* getelementptr inbounds ([32 x i8], [32 x i8]* @__java_type_names.221, i32 0, i32 0),
	i8* getelementptr inbounds ([28 x i8], [28 x i8]* @__java_type_names.222, i32 0, i32 0),
	i8* getelementptr inbounds ([28 x i8], [28 x i8]* @__java_type_names.223, i32 0, i32 0),
	i8* getelementptr inbounds ([31 x i8], [31 x i8]* @__java_type_names.224, i32 0, i32 0),
	i8* getelementptr inbounds ([29 x i8], [29 x i8]* @__java_type_names.225, i32 0, i32 0),
	i8* getelementptr inbounds ([36 x i8], [36 x i8]* @__java_type_names.226, i32 0, i32 0),
	i8* getelementptr inbounds ([33 x i8], [33 x i8]* @__java_type_names.227, i32 0, i32 0),
	i8* getelementptr inbounds ([34 x i8], [34 x i8]* @__java_type_names.228, i32 0, i32 0),
	i8* getelementptr inbounds ([30 x i8], [30 x i8]* @__java_type_names.229, i32 0, i32 0),
	i8* getelementptr inbounds ([28 x i8], [28 x i8]* @__java_type_names.230, i32 0, i32 0),
	i8* getelementptr inbounds ([35 x i8], [35 x i8]* @__java_type_names.231, i32 0, i32 0),
	i8* getelementptr inbounds ([30 x i8], [30 x i8]* @__java_type_names.232, i32 0, i32 0),
	i8* getelementptr inbounds ([24 x i8], [24 x i8]* @__java_type_names.233, i32 0, i32 0),
	i8* getelementptr inbounds ([23 x i8], [23 x i8]* @__java_type_names.234, i32 0, i32 0),
	i8* getelementptr inbounds ([42 x i8], [42 x i8]* @__java_type_names.235, i32 0, i32 0),
	i8* getelementptr inbounds ([43 x i8], [43 x i8]* @__java_type_names.236, i32 0, i32 0),
	i8* getelementptr inbounds ([27 x i8], [27 x i8]* @__java_type_names.237, i32 0, i32 0),
	i8* getelementptr inbounds ([31 x i8], [31 x i8]* @__java_type_names.238, i32 0, i32 0),
	i8* getelementptr inbounds ([38 x i8], [38 x i8]* @__java_type_names.239, i32 0, i32 0),
	i8* getelementptr inbounds ([33 x i8], [33 x i8]* @__java_type_names.240, i32 0, i32 0),
	i8* getelementptr inbounds ([35 x i8], [35 x i8]* @__java_type_names.241, i32 0, i32 0),
	i8* getelementptr inbounds ([16 x i8], [16 x i8]* @__java_type_names.242, i32 0, i32 0),
	i8* getelementptr inbounds ([20 x i8], [20 x i8]* @__java_type_names.243, i32 0, i32 0),
	i8* getelementptr inbounds ([21 x i8], [21 x i8]* @__java_type_names.244, i32 0, i32 0),
	i8* getelementptr inbounds ([21 x i8], [21 x i8]* @__java_type_names.245, i32 0, i32 0),
	i8* getelementptr inbounds ([30 x i8], [30 x i8]* @__java_type_names.246, i32 0, i32 0),
	i8* getelementptr inbounds ([30 x i8], [30 x i8]* @__java_type_names.247, i32 0, i32 0),
	i8* getelementptr inbounds ([26 x i8], [26 x i8]* @__java_type_names.248, i32 0, i32 0),
	i8* getelementptr inbounds ([39 x i8], [39 x i8]* @__java_type_names.249, i32 0, i32 0),
	i8* getelementptr inbounds ([39 x i8], [39 x i8]* @__java_type_names.250, i32 0, i32 0),
	i8* getelementptr inbounds ([38 x i8], [38 x i8]* @__java_type_names.251, i32 0, i32 0),
	i8* getelementptr inbounds ([40 x i8], [40 x i8]* @__java_type_names.252, i32 0, i32 0),
	i8* getelementptr inbounds ([38 x i8], [38 x i8]* @__java_type_names.253, i32 0, i32 0),
	i8* getelementptr inbounds ([38 x i8], [38 x i8]* @__java_type_names.254, i32 0, i32 0),
	i8* getelementptr inbounds ([51 x i8], [51 x i8]* @__java_type_names.255, i32 0, i32 0),
	i8* getelementptr inbounds ([26 x i8], [26 x i8]* @__java_type_names.256, i32 0, i32 0),
	i8* getelementptr inbounds ([27 x i8], [27 x i8]* @__java_type_names.257, i32 0, i32 0),
	i8* getelementptr inbounds ([27 x i8], [27 x i8]* @__java_type_names.258, i32 0, i32 0),
	i8* getelementptr inbounds ([27 x i8], [27 x i8]* @__java_type_names.259, i32 0, i32 0),
	i8* getelementptr inbounds ([15 x i8], [15 x i8]* @__java_type_names.260, i32 0, i32 0),
	i8* getelementptr inbounds ([20 x i8], [20 x i8]* @__java_type_names.261, i32 0, i32 0),
	i8* getelementptr inbounds ([23 x i8], [23 x i8]* @__java_type_names.262, i32 0, i32 0),
	i8* getelementptr inbounds ([23 x i8], [23 x i8]* @__java_type_names.263, i32 0, i32 0),
	i8* getelementptr inbounds ([25 x i8], [25 x i8]* @__java_type_names.264, i32 0, i32 0),
	i8* getelementptr inbounds ([32 x i8], [32 x i8]* @__java_type_names.265, i32 0, i32 0),
	i8* getelementptr inbounds ([33 x i8], [33 x i8]* @__java_type_names.266, i32 0, i32 0),
	i8* getelementptr inbounds ([13 x i8], [13 x i8]* @__java_type_names.267, i32 0, i32 0),
	i8* getelementptr inbounds ([13 x i8], [13 x i8]* @__java_type_names.268, i32 0, i32 0),
	i8* getelementptr inbounds ([23 x i8], [23 x i8]* @__java_type_names.269, i32 0, i32 0),
	i8* getelementptr inbounds ([32 x i8], [32 x i8]* @__java_type_names.270, i32 0, i32 0),
	i8* getelementptr inbounds ([18 x i8], [18 x i8]* @__java_type_names.271, i32 0, i32 0),
	i8* getelementptr inbounds ([15 x i8], [15 x i8]* @__java_type_names.272, i32 0, i32 0),
	i8* getelementptr inbounds ([20 x i8], [20 x i8]* @__java_type_names.273, i32 0, i32 0),
	i8* getelementptr inbounds ([16 x i8], [16 x i8]* @__java_type_names.274, i32 0, i32 0),
	i8* getelementptr inbounds ([29 x i8], [29 x i8]* @__java_type_names.275, i32 0, i32 0),
	i8* getelementptr inbounds ([22 x i8], [22 x i8]* @__java_type_names.276, i32 0, i32 0),
	i8* getelementptr inbounds ([33 x i8], [33 x i8]* @__java_type_names.277, i32 0, i32 0),
	i8* getelementptr inbounds ([17 x i8], [17 x i8]* @__java_type_names.278, i32 0, i32 0),
	i8* getelementptr inbounds ([15 x i8], [15 x i8]* @__java_type_names.279, i32 0, i32 0),
	i8* getelementptr inbounds ([16 x i8], [16 x i8]* @__java_type_names.280, i32 0, i32 0),
	i8* getelementptr inbounds ([20 x i8], [20 x i8]* @__java_type_names.281, i32 0, i32 0),
	i8* getelementptr inbounds ([16 x i8], [16 x i8]* @__java_type_names.282, i32 0, i32 0),
	i8* getelementptr inbounds ([21 x i8], [21 x i8]* @__java_type_names.283, i32 0, i32 0),
	i8* getelementptr inbounds ([23 x i8], [23 x i8]* @__java_type_names.284, i32 0, i32 0),
	i8* getelementptr inbounds ([20 x i8], [20 x i8]* @__java_type_names.285, i32 0, i32 0),
	i8* getelementptr inbounds ([21 x i8], [21 x i8]* @__java_type_names.286, i32 0, i32 0),
	i8* getelementptr inbounds ([19 x i8], [19 x i8]* @__java_type_names.287, i32 0, i32 0),
	i8* getelementptr inbounds ([35 x i8], [35 x i8]* @__java_type_names.288, i32 0, i32 0),
	i8* getelementptr inbounds ([32 x i8], [32 x i8]* @__java_type_names.289, i32 0, i32 0),
	i8* getelementptr inbounds ([36 x i8], [36 x i8]* @__java_type_names.290, i32 0, i32 0),
	i8* getelementptr inbounds ([18 x i8], [18 x i8]* @__java_type_names.291, i32 0, i32 0),
	i8* getelementptr inbounds ([19 x i8], [19 x i8]* @__java_type_names.292, i32 0, i32 0),
	i8* getelementptr inbounds ([23 x i8], [23 x i8]* @__java_type_names.293, i32 0, i32 0),
	i8* getelementptr inbounds ([15 x i8], [15 x i8]* @__java_type_names.294, i32 0, i32 0),
	i8* getelementptr inbounds ([31 x i8], [31 x i8]* @__java_type_names.295, i32 0, i32 0),
	i8* getelementptr inbounds ([31 x i8], [31 x i8]* @__java_type_names.296, i32 0, i32 0),
	i8* getelementptr inbounds ([17 x i8], [17 x i8]* @__java_type_names.297, i32 0, i32 0),
	i8* getelementptr inbounds ([17 x i8], [17 x i8]* @__java_type_names.298, i32 0, i32 0),
	i8* getelementptr inbounds ([39 x i8], [39 x i8]* @__java_type_names.299, i32 0, i32 0),
	i8* getelementptr inbounds ([27 x i8], [27 x i8]* @__java_type_names.300, i32 0, i32 0),
	i8* getelementptr inbounds ([28 x i8], [28 x i8]* @__java_type_names.301, i32 0, i32 0),
	i8* getelementptr inbounds ([16 x i8], [16 x i8]* @__java_type_names.302, i32 0, i32 0),
	i8* getelementptr inbounds ([17 x i8], [17 x i8]* @__java_type_names.303, i32 0, i32 0),
	i8* getelementptr inbounds ([23 x i8], [23 x i8]* @__java_type_names.304, i32 0, i32 0),
	i8* getelementptr inbounds ([24 x i8], [24 x i8]* @__java_type_names.305, i32 0, i32 0),
	i8* getelementptr inbounds ([17 x i8], [17 x i8]* @__java_type_names.306, i32 0, i32 0),
	i8* getelementptr inbounds ([35 x i8], [35 x i8]* @__java_type_names.307, i32 0, i32 0),
	i8* getelementptr inbounds ([20 x i8], [20 x i8]* @__java_type_names.308, i32 0, i32 0),
	i8* getelementptr inbounds ([40 x i8], [40 x i8]* @__java_type_names.309, i32 0, i32 0),
	i8* getelementptr inbounds ([15 x i8], [15 x i8]* @__java_type_names.310, i32 0, i32 0),
	i8* getelementptr inbounds ([35 x i8], [35 x i8]* @__java_type_names.311, i32 0, i32 0),
	i8* getelementptr inbounds ([37 x i8], [37 x i8]* @__java_type_names.312, i32 0, i32 0),
	i8* getelementptr inbounds ([23 x i8], [23 x i8]* @__java_type_names.313, i32 0, i32 0),
	i8* getelementptr inbounds ([31 x i8], [31 x i8]* @__java_type_names.314, i32 0, i32 0),
	i8* getelementptr inbounds ([32 x i8], [32 x i8]* @__java_type_names.315, i32 0, i32 0),
	i8* getelementptr inbounds ([24 x i8], [24 x i8]* @__java_type_names.316, i32 0, i32 0),
	i8* getelementptr inbounds ([13 x i8], [13 x i8]* @__java_type_names.317, i32 0, i32 0),
	i8* getelementptr inbounds ([23 x i8], [23 x i8]* @__java_type_names.318, i32 0, i32 0),
	i8* getelementptr inbounds ([24 x i8], [24 x i8]* @__java_type_names.319, i32 0, i32 0),
	i8* getelementptr inbounds ([26 x i8], [26 x i8]* @__java_type_names.320, i32 0, i32 0),
	i8* getelementptr inbounds ([18 x i8], [18 x i8]* @__java_type_names.321, i32 0, i32 0),
	i8* getelementptr inbounds ([18 x i8], [18 x i8]* @__java_type_names.322, i32 0, i32 0),
	i8* getelementptr inbounds ([18 x i8], [18 x i8]* @__java_type_names.323, i32 0, i32 0),
	i8* getelementptr inbounds ([20 x i8], [20 x i8]* @__java_type_names.324, i32 0, i32 0),
	i8* getelementptr inbounds ([31 x i8], [31 x i8]* @__java_type_names.325, i32 0, i32 0),
	i8* getelementptr inbounds ([20 x i8], [20 x i8]* @__java_type_names.326, i32 0, i32 0),
	i8* getelementptr inbounds ([21 x i8], [21 x i8]* @__java_type_names.327, i32 0, i32 0),
	i8* getelementptr inbounds ([21 x i8], [21 x i8]* @__java_type_names.328, i32 0, i32 0),
	i8* getelementptr inbounds ([20 x i8], [20 x i8]* @__java_type_names.329, i32 0, i32 0),
	i8* getelementptr inbounds ([21 x i8], [21 x i8]* @__java_type_names.330, i32 0, i32 0),
	i8* getelementptr inbounds ([15 x i8], [15 x i8]* @__java_type_names.331, i32 0, i32 0),
	i8* getelementptr inbounds ([25 x i8], [25 x i8]* @__java_type_names.332, i32 0, i32 0),
	i8* getelementptr inbounds ([36 x i8], [36 x i8]* @__java_type_names.333, i32 0, i32 0),
	i8* getelementptr inbounds ([35 x i8], [35 x i8]* @__java_type_names.334, i32 0, i32 0),
	i8* getelementptr inbounds ([28 x i8], [28 x i8]* @__java_type_names.335, i32 0, i32 0),
	i8* getelementptr inbounds ([28 x i8], [28 x i8]* @__java_type_names.336, i32 0, i32 0),
	i8* getelementptr inbounds ([36 x i8], [36 x i8]* @__java_type_names.337, i32 0, i32 0),
	i8* getelementptr inbounds ([57 x i8], [57 x i8]* @__java_type_names.338, i32 0, i32 0),
	i8* getelementptr inbounds ([33 x i8], [33 x i8]* @__java_type_names.339, i32 0, i32 0),
	i8* getelementptr inbounds ([46 x i8], [46 x i8]* @__java_type_names.340, i32 0, i32 0),
	i8* getelementptr inbounds ([58 x i8], [58 x i8]* @__java_type_names.341, i32 0, i32 0),
	i8* getelementptr inbounds ([74 x i8], [74 x i8]* @__java_type_names.342, i32 0, i32 0),
	i8* getelementptr inbounds ([54 x i8], [54 x i8]* @__java_type_names.343, i32 0, i32 0),
	i8* getelementptr inbounds ([37 x i8], [37 x i8]* @__java_type_names.344, i32 0, i32 0),
	i8* getelementptr inbounds ([45 x i8], [45 x i8]* @__java_type_names.345, i32 0, i32 0),
	i8* getelementptr inbounds ([45 x i8], [45 x i8]* @__java_type_names.346, i32 0, i32 0),
	i8* getelementptr inbounds ([54 x i8], [54 x i8]* @__java_type_names.347, i32 0, i32 0),
	i8* getelementptr inbounds ([62 x i8], [62 x i8]* @__java_type_names.348, i32 0, i32 0),
	i8* getelementptr inbounds ([41 x i8], [41 x i8]* @__java_type_names.349, i32 0, i32 0),
	i8* getelementptr inbounds ([41 x i8], [41 x i8]* @__java_type_names.350, i32 0, i32 0),
	i8* getelementptr inbounds ([41 x i8], [41 x i8]* @__java_type_names.351, i32 0, i32 0),
	i8* getelementptr inbounds ([34 x i8], [34 x i8]* @__java_type_names.352, i32 0, i32 0),
	i8* getelementptr inbounds ([67 x i8], [67 x i8]* @__java_type_names.353, i32 0, i32 0),
	i8* getelementptr inbounds ([58 x i8], [58 x i8]* @__java_type_names.354, i32 0, i32 0),
	i8* getelementptr inbounds ([74 x i8], [74 x i8]* @__java_type_names.355, i32 0, i32 0),
	i8* getelementptr inbounds ([39 x i8], [39 x i8]* @__java_type_names.356, i32 0, i32 0),
	i8* getelementptr inbounds ([52 x i8], [52 x i8]* @__java_type_names.357, i32 0, i32 0),
	i8* getelementptr inbounds ([75 x i8], [75 x i8]* @__java_type_names.358, i32 0, i32 0),
	i8* getelementptr inbounds ([35 x i8], [35 x i8]* @__java_type_names.359, i32 0, i32 0),
	i8* getelementptr inbounds ([44 x i8], [44 x i8]* @__java_type_names.360, i32 0, i32 0),
	i8* getelementptr inbounds ([41 x i8], [41 x i8]* @__java_type_names.361, i32 0, i32 0),
	i8* getelementptr inbounds ([50 x i8], [50 x i8]* @__java_type_names.362, i32 0, i32 0),
	i8* getelementptr inbounds ([52 x i8], [52 x i8]* @__java_type_names.363, i32 0, i32 0),
	i8* getelementptr inbounds ([43 x i8], [43 x i8]* @__java_type_names.364, i32 0, i32 0),
	i8* getelementptr inbounds ([38 x i8], [38 x i8]* @__java_type_names.365, i32 0, i32 0),
	i8* getelementptr inbounds ([42 x i8], [42 x i8]* @__java_type_names.366, i32 0, i32 0),
	i8* getelementptr inbounds ([44 x i8], [44 x i8]* @__java_type_names.367, i32 0, i32 0),
	i8* getelementptr inbounds ([44 x i8], [44 x i8]* @__java_type_names.368, i32 0, i32 0),
	i8* getelementptr inbounds ([50 x i8], [50 x i8]* @__java_type_names.369, i32 0, i32 0),
	i8* getelementptr inbounds ([51 x i8], [51 x i8]* @__java_type_names.370, i32 0, i32 0),
	i8* getelementptr inbounds ([49 x i8], [49 x i8]* @__java_type_names.371, i32 0, i32 0),
	i8* getelementptr inbounds ([68 x i8], [68 x i8]* @__java_type_names.372, i32 0, i32 0),
	i8* getelementptr inbounds ([41 x i8], [41 x i8]* @__java_type_names.373, i32 0, i32 0),
	i8* getelementptr inbounds ([48 x i8], [48 x i8]* @__java_type_names.374, i32 0, i32 0),
	i8* getelementptr inbounds ([39 x i8], [39 x i8]* @__java_type_names.375, i32 0, i32 0),
	i8* getelementptr inbounds ([45 x i8], [45 x i8]* @__java_type_names.376, i32 0, i32 0),
	i8* getelementptr inbounds ([62 x i8], [62 x i8]* @__java_type_names.377, i32 0, i32 0),
	i8* getelementptr inbounds ([46 x i8], [46 x i8]* @__java_type_names.378, i32 0, i32 0),
	i8* getelementptr inbounds ([34 x i8], [34 x i8]* @__java_type_names.379, i32 0, i32 0),
	i8* getelementptr inbounds ([42 x i8], [42 x i8]* @__java_type_names.380, i32 0, i32 0),
	i8* getelementptr inbounds ([40 x i8], [40 x i8]* @__java_type_names.381, i32 0, i32 0),
	i8* getelementptr inbounds ([37 x i8], [37 x i8]* @__java_type_names.382, i32 0, i32 0),
	i8* getelementptr inbounds ([51 x i8], [51 x i8]* @__java_type_names.383, i32 0, i32 0),
	i8* getelementptr inbounds ([60 x i8], [60 x i8]* @__java_type_names.384, i32 0, i32 0),
	i8* getelementptr inbounds ([57 x i8], [57 x i8]* @__java_type_names.385, i32 0, i32 0),
	i8* getelementptr inbounds ([32 x i8], [32 x i8]* @__java_type_names.386, i32 0, i32 0),
	i8* getelementptr inbounds ([42 x i8], [42 x i8]* @__java_type_names.387, i32 0, i32 0),
	i8* getelementptr inbounds ([52 x i8], [52 x i8]* @__java_type_names.388, i32 0, i32 0),
	i8* getelementptr inbounds ([38 x i8], [38 x i8]* @__java_type_names.389, i32 0, i32 0),
	i8* getelementptr inbounds ([33 x i8], [33 x i8]* @__java_type_names.390, i32 0, i32 0),
	i8* getelementptr inbounds ([50 x i8], [50 x i8]* @__java_type_names.391, i32 0, i32 0),
	i8* getelementptr inbounds ([76 x i8], [76 x i8]* @__java_type_names.392, i32 0, i32 0),
	i8* getelementptr inbounds ([59 x i8], [59 x i8]* @__java_type_names.393, i32 0, i32 0),
	i8* getelementptr inbounds ([75 x i8], [75 x i8]* @__java_type_names.394, i32 0, i32 0),
	i8* getelementptr inbounds ([36 x i8], [36 x i8]* @__java_type_names.395, i32 0, i32 0),
	i8* getelementptr inbounds ([51 x i8], [51 x i8]* @__java_type_names.396, i32 0, i32 0),
	i8* getelementptr inbounds ([47 x i8], [47 x i8]* @__java_type_names.397, i32 0, i32 0),
	i8* getelementptr inbounds ([27 x i8], [27 x i8]* @__java_type_names.398, i32 0, i32 0),
	i8* getelementptr inbounds ([23 x i8], [23 x i8]* @__java_type_names.399, i32 0, i32 0),
	i8* getelementptr inbounds ([22 x i8], [22 x i8]* @__java_type_names.400, i32 0, i32 0),
	i8* getelementptr inbounds ([27 x i8], [27 x i8]* @__java_type_names.401, i32 0, i32 0),
	i8* getelementptr inbounds ([31 x i8], [31 x i8]* @__java_type_names.402, i32 0, i32 0),
	i8* getelementptr inbounds ([26 x i8], [26 x i8]* @__java_type_names.403, i32 0, i32 0),
	i8* getelementptr inbounds ([33 x i8], [33 x i8]* @__java_type_names.404, i32 0, i32 0),
	i8* getelementptr inbounds ([28 x i8], [28 x i8]* @__java_type_names.405, i32 0, i32 0),
	i8* getelementptr inbounds ([28 x i8], [28 x i8]* @__java_type_names.406, i32 0, i32 0),
	i8* getelementptr inbounds ([30 x i8], [30 x i8]* @__java_type_names.407, i32 0, i32 0),
	i8* getelementptr inbounds ([42 x i8], [42 x i8]* @__java_type_names.408, i32 0, i32 0),
	i8* getelementptr inbounds ([28 x i8], [28 x i8]* @__java_type_names.409, i32 0, i32 0),
	i8* getelementptr inbounds ([36 x i8], [36 x i8]* @__java_type_names.410, i32 0, i32 0),
	i8* getelementptr inbounds ([37 x i8], [37 x i8]* @__java_type_names.411, i32 0, i32 0),
	i8* getelementptr inbounds ([29 x i8], [29 x i8]* @__java_type_names.412, i32 0, i32 0),
	i8* getelementptr inbounds ([34 x i8], [34 x i8]* @__java_type_names.413, i32 0, i32 0),
	i8* getelementptr inbounds ([28 x i8], [28 x i8]* @__java_type_names.414, i32 0, i32 0),
	i8* getelementptr inbounds ([29 x i8], [29 x i8]* @__java_type_names.415, i32 0, i32 0),
	i8* getelementptr inbounds ([34 x i8], [34 x i8]* @__java_type_names.416, i32 0, i32 0),
	i8* getelementptr inbounds ([27 x i8], [27 x i8]* @__java_type_names.417, i32 0, i32 0),
	i8* getelementptr inbounds ([27 x i8], [27 x i8]* @__java_type_names.418, i32 0, i32 0),
	i8* getelementptr inbounds ([26 x i8], [26 x i8]* @__java_type_names.419, i32 0, i32 0),
	i8* getelementptr inbounds ([30 x i8], [30 x i8]* @__java_type_names.420, i32 0, i32 0),
	i8* getelementptr inbounds ([28 x i8], [28 x i8]* @__java_type_names.421, i32 0, i32 0),
	i8* getelementptr inbounds ([31 x i8], [31 x i8]* @__java_type_names.422, i32 0, i32 0),
	i8* getelementptr inbounds ([29 x i8], [29 x i8]* @__java_type_names.423, i32 0, i32 0),
	i8* getelementptr inbounds ([33 x i8], [33 x i8]* @__java_type_names.424, i32 0, i32 0),
	i8* getelementptr inbounds ([31 x i8], [31 x i8]* @__java_type_names.425, i32 0, i32 0),
	i8* getelementptr inbounds ([32 x i8], [32 x i8]* @__java_type_names.426, i32 0, i32 0),
	i8* getelementptr inbounds ([23 x i8], [23 x i8]* @__java_type_names.427, i32 0, i32 0),
	i8* getelementptr inbounds ([29 x i8], [29 x i8]* @__java_type_names.428, i32 0, i32 0),
	i8* getelementptr inbounds ([27 x i8], [27 x i8]* @__java_type_names.429, i32 0, i32 0),
	i8* getelementptr inbounds ([34 x i8], [34 x i8]* @__java_type_names.430, i32 0, i32 0),
	i8* getelementptr inbounds ([35 x i8], [35 x i8]* @__java_type_names.431, i32 0, i32 0),
	i8* getelementptr inbounds ([25 x i8], [25 x i8]* @__java_type_names.432, i32 0, i32 0),
	i8* getelementptr inbounds ([36 x i8], [36 x i8]* @__java_type_names.433, i32 0, i32 0),
	i8* getelementptr inbounds ([29 x i8], [29 x i8]* @__java_type_names.434, i32 0, i32 0),
	i8* getelementptr inbounds ([23 x i8], [23 x i8]* @__java_type_names.435, i32 0, i32 0),
	i8* getelementptr inbounds ([28 x i8], [28 x i8]* @__java_type_names.436, i32 0, i32 0),
	i8* getelementptr inbounds ([29 x i8], [29 x i8]* @__java_type_names.437, i32 0, i32 0),
	i8* getelementptr inbounds ([29 x i8], [29 x i8]* @__java_type_names.438, i32 0, i32 0),
	i8* getelementptr inbounds ([38 x i8], [38 x i8]* @__java_type_names.439, i32 0, i32 0),
	i8* getelementptr inbounds ([33 x i8], [33 x i8]* @__java_type_names.440, i32 0, i32 0),
	i8* getelementptr inbounds ([35 x i8], [35 x i8]* @__java_type_names.441, i32 0, i32 0),
	i8* getelementptr inbounds ([30 x i8], [30 x i8]* @__java_type_names.442, i32 0, i32 0),
	i8* getelementptr inbounds ([44 x i8], [44 x i8]* @__java_type_names.443, i32 0, i32 0),
	i8* getelementptr inbounds ([60 x i8], [60 x i8]* @__java_type_names.444, i32 0, i32 0),
	i8* getelementptr inbounds ([27 x i8], [27 x i8]* @__java_type_names.445, i32 0, i32 0),
	i8* getelementptr inbounds ([28 x i8], [28 x i8]* @__java_type_names.446, i32 0, i32 0),
	i8* getelementptr inbounds ([31 x i8], [31 x i8]* @__java_type_names.447, i32 0, i32 0),
	i8* getelementptr inbounds ([26 x i8], [26 x i8]* @__java_type_names.448, i32 0, i32 0),
	i8* getelementptr inbounds ([26 x i8], [26 x i8]* @__java_type_names.449, i32 0, i32 0),
	i8* getelementptr inbounds ([39 x i8], [39 x i8]* @__java_type_names.450, i32 0, i32 0),
	i8* getelementptr inbounds ([45 x i8], [45 x i8]* @__java_type_names.451, i32 0, i32 0),
	i8* getelementptr inbounds ([44 x i8], [44 x i8]* @__java_type_names.452, i32 0, i32 0),
	i8* getelementptr inbounds ([52 x i8], [52 x i8]* @__java_type_names.453, i32 0, i32 0),
	i8* getelementptr inbounds ([52 x i8], [52 x i8]* @__java_type_names.454, i32 0, i32 0),
	i8* getelementptr inbounds ([68 x i8], [68 x i8]* @__java_type_names.455, i32 0, i32 0),
	i8* getelementptr inbounds ([47 x i8], [47 x i8]* @__java_type_names.456, i32 0, i32 0),
	i8* getelementptr inbounds ([76 x i8], [76 x i8]* @__java_type_names.457, i32 0, i32 0),
	i8* getelementptr inbounds ([92 x i8], [92 x i8]* @__java_type_names.458, i32 0, i32 0),
	i8* getelementptr inbounds ([39 x i8], [39 x i8]* @__java_type_names.459, i32 0, i32 0),
	i8* getelementptr inbounds ([39 x i8], [39 x i8]* @__java_type_names.460, i32 0, i32 0),
	i8* getelementptr inbounds ([57 x i8], [57 x i8]* @__java_type_names.461, i32 0, i32 0),
	i8* getelementptr inbounds ([66 x i8], [66 x i8]* @__java_type_names.462, i32 0, i32 0),
	i8* getelementptr inbounds ([82 x i8], [82 x i8]* @__java_type_names.463, i32 0, i32 0),
	i8* getelementptr inbounds ([63 x i8], [63 x i8]* @__java_type_names.464, i32 0, i32 0),
	i8* getelementptr inbounds ([53 x i8], [53 x i8]* @__java_type_names.465, i32 0, i32 0),
	i8* getelementptr inbounds ([70 x i8], [70 x i8]* @__java_type_names.466, i32 0, i32 0),
	i8* getelementptr inbounds ([52 x i8], [52 x i8]* @__java_type_names.467, i32 0, i32 0),
	i8* getelementptr inbounds ([68 x i8], [68 x i8]* @__java_type_names.468, i32 0, i32 0),
	i8* getelementptr inbounds ([54 x i8], [54 x i8]* @__java_type_names.469, i32 0, i32 0),
	i8* getelementptr inbounds ([53 x i8], [53 x i8]* @__java_type_names.470, i32 0, i32 0),
	i8* getelementptr inbounds ([70 x i8], [70 x i8]* @__java_type_names.471, i32 0, i32 0),
	i8* getelementptr inbounds ([51 x i8], [51 x i8]* @__java_type_names.472, i32 0, i32 0),
	i8* getelementptr inbounds ([66 x i8], [66 x i8]* @__java_type_names.473, i32 0, i32 0),
	i8* getelementptr inbounds ([50 x i8], [50 x i8]* @__java_type_names.474, i32 0, i32 0),
	i8* getelementptr inbounds ([60 x i8], [60 x i8]* @__java_type_names.475, i32 0, i32 0),
	i8* getelementptr inbounds ([48 x i8], [48 x i8]* @__java_type_names.476, i32 0, i32 0),
	i8* getelementptr inbounds ([45 x i8], [45 x i8]* @__java_type_names.477, i32 0, i32 0),
	i8* getelementptr inbounds ([55 x i8], [55 x i8]* @__java_type_names.478, i32 0, i32 0),
	i8* getelementptr inbounds ([74 x i8], [74 x i8]* @__java_type_names.479, i32 0, i32 0),
	i8* getelementptr inbounds ([40 x i8], [40 x i8]* @__java_type_names.480, i32 0, i32 0),
	i8* getelementptr inbounds ([50 x i8], [50 x i8]* @__java_type_names.481, i32 0, i32 0),
	i8* getelementptr inbounds ([36 x i8], [36 x i8]* @__java_type_names.482, i32 0, i32 0),
	i8* getelementptr inbounds ([28 x i8], [28 x i8]* @__java_type_names.483, i32 0, i32 0),
	i8* getelementptr inbounds ([33 x i8], [33 x i8]* @__java_type_names.484, i32 0, i32 0),
	i8* getelementptr inbounds ([43 x i8], [43 x i8]* @__java_type_names.485, i32 0, i32 0),
	i8* getelementptr inbounds ([54 x i8], [54 x i8]* @__java_type_names.486, i32 0, i32 0),
	i8* getelementptr inbounds ([39 x i8], [39 x i8]* @__java_type_names.487, i32 0, i32 0),
	i8* getelementptr inbounds ([56 x i8], [56 x i8]* @__java_type_names.488, i32 0, i32 0),
	i8* getelementptr inbounds ([43 x i8], [43 x i8]* @__java_type_names.489, i32 0, i32 0),
	i8* getelementptr inbounds ([38 x i8], [38 x i8]* @__java_type_names.490, i32 0, i32 0),
	i8* getelementptr inbounds ([28 x i8], [28 x i8]* @__java_type_names.491, i32 0, i32 0),
	i8* getelementptr inbounds ([37 x i8], [37 x i8]* @__java_type_names.492, i32 0, i32 0),
	i8* getelementptr inbounds ([39 x i8], [39 x i8]* @__java_type_names.493, i32 0, i32 0),
	i8* getelementptr inbounds ([50 x i8], [50 x i8]* @__java_type_names.494, i32 0, i32 0),
	i8* getelementptr inbounds ([44 x i8], [44 x i8]* @__java_type_names.495, i32 0, i32 0),
	i8* getelementptr inbounds ([44 x i8], [44 x i8]* @__java_type_names.496, i32 0, i32 0),
	i8* getelementptr inbounds ([43 x i8], [43 x i8]* @__java_type_names.497, i32 0, i32 0),
	i8* getelementptr inbounds ([40 x i8], [40 x i8]* @__java_type_names.498, i32 0, i32 0),
	i8* getelementptr inbounds ([44 x i8], [44 x i8]* @__java_type_names.499, i32 0, i32 0),
	i8* getelementptr inbounds ([55 x i8], [55 x i8]* @__java_type_names.500, i32 0, i32 0),
	i8* getelementptr inbounds ([43 x i8], [43 x i8]* @__java_type_names.501, i32 0, i32 0),
	i8* getelementptr inbounds ([48 x i8], [48 x i8]* @__java_type_names.502, i32 0, i32 0),
	i8* getelementptr inbounds ([46 x i8], [46 x i8]* @__java_type_names.503, i32 0, i32 0),
	i8* getelementptr inbounds ([69 x i8], [69 x i8]* @__java_type_names.504, i32 0, i32 0),
	i8* getelementptr inbounds ([85 x i8], [85 x i8]* @__java_type_names.505, i32 0, i32 0),
	i8* getelementptr inbounds ([49 x i8], [49 x i8]* @__java_type_names.506, i32 0, i32 0),
	i8* getelementptr inbounds ([56 x i8], [56 x i8]* @__java_type_names.507, i32 0, i32 0),
	i8* getelementptr inbounds ([61 x i8], [61 x i8]* @__java_type_names.508, i32 0, i32 0),
	i8* getelementptr inbounds ([54 x i8], [54 x i8]* @__java_type_names.509, i32 0, i32 0),
	i8* getelementptr inbounds ([59 x i8], [59 x i8]* @__java_type_names.510, i32 0, i32 0),
	i8* getelementptr inbounds ([68 x i8], [68 x i8]* @__java_type_names.511, i32 0, i32 0),
	i8* getelementptr inbounds ([76 x i8], [76 x i8]* @__java_type_names.512, i32 0, i32 0),
	i8* getelementptr inbounds ([63 x i8], [63 x i8]* @__java_type_names.513, i32 0, i32 0),
	i8* getelementptr inbounds ([76 x i8], [76 x i8]* @__java_type_names.514, i32 0, i32 0),
	i8* getelementptr inbounds ([61 x i8], [61 x i8]* @__java_type_names.515, i32 0, i32 0),
	i8* getelementptr inbounds ([44 x i8], [44 x i8]* @__java_type_names.516, i32 0, i32 0),
	i8* getelementptr inbounds ([51 x i8], [51 x i8]* @__java_type_names.517, i32 0, i32 0),
	i8* getelementptr inbounds ([43 x i8], [43 x i8]* @__java_type_names.518, i32 0, i32 0),
	i8* getelementptr inbounds ([48 x i8], [48 x i8]* @__java_type_names.519, i32 0, i32 0),
	i8* getelementptr inbounds ([53 x i8], [53 x i8]* @__java_type_names.520, i32 0, i32 0),
	i8* getelementptr inbounds ([71 x i8], [71 x i8]* @__java_type_names.521, i32 0, i32 0),
	i8* getelementptr inbounds ([71 x i8], [71 x i8]* @__java_type_names.522, i32 0, i32 0),
	i8* getelementptr inbounds ([50 x i8], [50 x i8]* @__java_type_names.523, i32 0, i32 0),
	i8* getelementptr inbounds ([52 x i8], [52 x i8]* @__java_type_names.524, i32 0, i32 0),
	i8* getelementptr inbounds ([51 x i8], [51 x i8]* @__java_type_names.525, i32 0, i32 0),
	i8* getelementptr inbounds ([45 x i8], [45 x i8]* @__java_type_names.526, i32 0, i32 0),
	i8* getelementptr inbounds ([59 x i8], [59 x i8]* @__java_type_names.527, i32 0, i32 0),
	i8* getelementptr inbounds ([69 x i8], [69 x i8]* @__java_type_names.528, i32 0, i32 0),
	i8* getelementptr inbounds ([51 x i8], [51 x i8]* @__java_type_names.529, i32 0, i32 0),
	i8* getelementptr inbounds ([55 x i8], [55 x i8]* @__java_type_names.530, i32 0, i32 0),
	i8* getelementptr inbounds ([53 x i8], [53 x i8]* @__java_type_names.531, i32 0, i32 0),
	i8* getelementptr inbounds ([55 x i8], [55 x i8]* @__java_type_names.532, i32 0, i32 0),
	i8* getelementptr inbounds ([55 x i8], [55 x i8]* @__java_type_names.533, i32 0, i32 0),
	i8* getelementptr inbounds ([53 x i8], [53 x i8]* @__java_type_names.534, i32 0, i32 0),
	i8* getelementptr inbounds ([53 x i8], [53 x i8]* @__java_type_names.535, i32 0, i32 0),
	i8* getelementptr inbounds ([49 x i8], [49 x i8]* @__java_type_names.536, i32 0, i32 0),
	i8* getelementptr inbounds ([51 x i8], [51 x i8]* @__java_type_names.537, i32 0, i32 0),
	i8* getelementptr inbounds ([51 x i8], [51 x i8]* @__java_type_names.538, i32 0, i32 0),
	i8* getelementptr inbounds ([54 x i8], [54 x i8]* @__java_type_names.539, i32 0, i32 0),
	i8* getelementptr inbounds ([54 x i8], [54 x i8]* @__java_type_names.540, i32 0, i32 0),
	i8* getelementptr inbounds ([50 x i8], [50 x i8]* @__java_type_names.541, i32 0, i32 0),
	i8* getelementptr inbounds ([48 x i8], [48 x i8]* @__java_type_names.542, i32 0, i32 0),
	i8* getelementptr inbounds ([52 x i8], [52 x i8]* @__java_type_names.543, i32 0, i32 0),
	i8* getelementptr inbounds ([50 x i8], [50 x i8]* @__java_type_names.544, i32 0, i32 0),
	i8* getelementptr inbounds ([52 x i8], [52 x i8]* @__java_type_names.545, i32 0, i32 0),
	i8* getelementptr inbounds ([52 x i8], [52 x i8]* @__java_type_names.546, i32 0, i32 0),
	i8* getelementptr inbounds ([50 x i8], [50 x i8]* @__java_type_names.547, i32 0, i32 0),
	i8* getelementptr inbounds ([50 x i8], [50 x i8]* @__java_type_names.548, i32 0, i32 0),
	i8* getelementptr inbounds ([60 x i8], [60 x i8]* @__java_type_names.549, i32 0, i32 0),
	i8* getelementptr inbounds ([53 x i8], [53 x i8]* @__java_type_names.550, i32 0, i32 0),
	i8* getelementptr inbounds ([52 x i8], [52 x i8]* @__java_type_names.551, i32 0, i32 0),
	i8* getelementptr inbounds ([53 x i8], [53 x i8]* @__java_type_names.552, i32 0, i32 0),
	i8* getelementptr inbounds ([56 x i8], [56 x i8]* @__java_type_names.553, i32 0, i32 0),
	i8* getelementptr inbounds ([52 x i8], [52 x i8]* @__java_type_names.554, i32 0, i32 0),
	i8* getelementptr inbounds ([56 x i8], [56 x i8]* @__java_type_names.555, i32 0, i32 0),
	i8* getelementptr inbounds ([55 x i8], [55 x i8]* @__java_type_names.556, i32 0, i32 0),
	i8* getelementptr inbounds ([64 x i8], [64 x i8]* @__java_type_names.557, i32 0, i32 0),
	i8* getelementptr inbounds ([53 x i8], [53 x i8]* @__java_type_names.558, i32 0, i32 0),
	i8* getelementptr inbounds ([53 x i8], [53 x i8]* @__java_type_names.559, i32 0, i32 0),
	i8* getelementptr inbounds ([54 x i8], [54 x i8]* @__java_type_names.560, i32 0, i32 0),
	i8* getelementptr inbounds ([48 x i8], [48 x i8]* @__java_type_names.561, i32 0, i32 0),
	i8* getelementptr inbounds ([70 x i8], [70 x i8]* @__java_type_names.562, i32 0, i32 0),
	i8* getelementptr inbounds ([53 x i8], [53 x i8]* @__java_type_names.563, i32 0, i32 0),
	i8* getelementptr inbounds ([60 x i8], [60 x i8]* @__java_type_names.564, i32 0, i32 0),
	i8* getelementptr inbounds ([76 x i8], [76 x i8]* @__java_type_names.565, i32 0, i32 0),
	i8* getelementptr inbounds ([39 x i8], [39 x i8]* @__java_type_names.566, i32 0, i32 0),
	i8* getelementptr inbounds ([50 x i8], [50 x i8]* @__java_type_names.567, i32 0, i32 0),
	i8* getelementptr inbounds ([48 x i8], [48 x i8]* @__java_type_names.568, i32 0, i32 0),
	i8* getelementptr inbounds ([56 x i8], [56 x i8]* @__java_type_names.569, i32 0, i32 0),
	i8* getelementptr inbounds ([45 x i8], [45 x i8]* @__java_type_names.570, i32 0, i32 0),
	i8* getelementptr inbounds ([40 x i8], [40 x i8]* @__java_type_names.571, i32 0, i32 0),
	i8* getelementptr inbounds ([41 x i8], [41 x i8]* @__java_type_names.572, i32 0, i32 0),
	i8* getelementptr inbounds ([46 x i8], [46 x i8]* @__java_type_names.573, i32 0, i32 0),
	i8* getelementptr inbounds ([45 x i8], [45 x i8]* @__java_type_names.574, i32 0, i32 0),
	i8* getelementptr inbounds ([45 x i8], [45 x i8]* @__java_type_names.575, i32 0, i32 0),
	i8* getelementptr inbounds ([53 x i8], [53 x i8]* @__java_type_names.576, i32 0, i32 0),
	i8* getelementptr inbounds ([46 x i8], [46 x i8]* @__java_type_names.577, i32 0, i32 0),
	i8* getelementptr inbounds ([55 x i8], [55 x i8]* @__java_type_names.578, i32 0, i32 0),
	i8* getelementptr inbounds ([43 x i8], [43 x i8]* @__java_type_names.579, i32 0, i32 0),
	i8* getelementptr inbounds ([45 x i8], [45 x i8]* @__java_type_names.580, i32 0, i32 0),
	i8* getelementptr inbounds ([51 x i8], [51 x i8]* @__java_type_names.581, i32 0, i32 0),
	i8* getelementptr inbounds ([58 x i8], [58 x i8]* @__java_type_names.582, i32 0, i32 0),
	i8* getelementptr inbounds ([57 x i8], [57 x i8]* @__java_type_names.583, i32 0, i32 0),
	i8* getelementptr inbounds ([60 x i8], [60 x i8]* @__java_type_names.584, i32 0, i32 0),
	i8* getelementptr inbounds ([47 x i8], [47 x i8]* @__java_type_names.585, i32 0, i32 0),
	i8* getelementptr inbounds ([45 x i8], [45 x i8]* @__java_type_names.586, i32 0, i32 0),
	i8* getelementptr inbounds ([50 x i8], [50 x i8]* @__java_type_names.587, i32 0, i32 0),
	i8* getelementptr inbounds ([52 x i8], [52 x i8]* @__java_type_names.588, i32 0, i32 0),
	i8* getelementptr inbounds ([59 x i8], [59 x i8]* @__java_type_names.589, i32 0, i32 0),
	i8* getelementptr inbounds ([59 x i8], [59 x i8]* @__java_type_names.590, i32 0, i32 0),
	i8* getelementptr inbounds ([58 x i8], [58 x i8]* @__java_type_names.591, i32 0, i32 0),
	i8* getelementptr inbounds ([67 x i8], [67 x i8]* @__java_type_names.592, i32 0, i32 0),
	i8* getelementptr inbounds ([47 x i8], [47 x i8]* @__java_type_names.593, i32 0, i32 0),
	i8* getelementptr inbounds ([45 x i8], [45 x i8]* @__java_type_names.594, i32 0, i32 0),
	i8* getelementptr inbounds ([50 x i8], [50 x i8]* @__java_type_names.595, i32 0, i32 0),
	i8* getelementptr inbounds ([52 x i8], [52 x i8]* @__java_type_names.596, i32 0, i32 0),
	i8* getelementptr inbounds ([59 x i8], [59 x i8]* @__java_type_names.597, i32 0, i32 0),
	i8* getelementptr inbounds ([55 x i8], [55 x i8]* @__java_type_names.598, i32 0, i32 0),
	i8* getelementptr inbounds ([59 x i8], [59 x i8]* @__java_type_names.599, i32 0, i32 0),
	i8* getelementptr inbounds ([63 x i8], [63 x i8]* @__java_type_names.600, i32 0, i32 0),
	i8* getelementptr inbounds ([63 x i8], [63 x i8]* @__java_type_names.601, i32 0, i32 0),
	i8* getelementptr inbounds ([58 x i8], [58 x i8]* @__java_type_names.602, i32 0, i32 0),
	i8* getelementptr inbounds ([67 x i8], [67 x i8]* @__java_type_names.603, i32 0, i32 0),
	i8* getelementptr inbounds ([55 x i8], [55 x i8]* @__java_type_names.604, i32 0, i32 0),
	i8* getelementptr inbounds ([55 x i8], [55 x i8]* @__java_type_names.605, i32 0, i32 0),
	i8* getelementptr inbounds ([55 x i8], [55 x i8]* @__java_type_names.606, i32 0, i32 0),
	i8* getelementptr inbounds ([55 x i8], [55 x i8]* @__java_type_names.607, i32 0, i32 0),
	i8* getelementptr inbounds ([55 x i8], [55 x i8]* @__java_type_names.608, i32 0, i32 0),
	i8* getelementptr inbounds ([55 x i8], [55 x i8]* @__java_type_names.609, i32 0, i32 0),
	i8* getelementptr inbounds ([65 x i8], [65 x i8]* @__java_type_names.610, i32 0, i32 0),
	i8* getelementptr inbounds ([71 x i8], [71 x i8]* @__java_type_names.611, i32 0, i32 0),
	i8* getelementptr inbounds ([69 x i8], [69 x i8]* @__java_type_names.612, i32 0, i32 0),
	i8* getelementptr inbounds ([71 x i8], [71 x i8]* @__java_type_names.613, i32 0, i32 0),
	i8* getelementptr inbounds ([71 x i8], [71 x i8]* @__java_type_names.614, i32 0, i32 0),
	i8* getelementptr inbounds ([69 x i8], [69 x i8]* @__java_type_names.615, i32 0, i32 0),
	i8* getelementptr inbounds ([69 x i8], [69 x i8]* @__java_type_names.616, i32 0, i32 0),
	i8* getelementptr inbounds ([65 x i8], [65 x i8]* @__java_type_names.617, i32 0, i32 0),
	i8* getelementptr inbounds ([73 x i8], [73 x i8]* @__java_type_names.618, i32 0, i32 0),
	i8* getelementptr inbounds ([55 x i8], [55 x i8]* @__java_type_names.619, i32 0, i32 0),
	i8* getelementptr inbounds ([73 x i8], [73 x i8]* @__java_type_names.620, i32 0, i32 0),
	i8* getelementptr inbounds ([77 x i8], [77 x i8]* @__java_type_names.621, i32 0, i32 0),
	i8* getelementptr inbounds ([77 x i8], [77 x i8]* @__java_type_names.622, i32 0, i32 0),
	i8* getelementptr inbounds ([77 x i8], [77 x i8]* @__java_type_names.623, i32 0, i32 0),
	i8* getelementptr inbounds ([58 x i8], [58 x i8]* @__java_type_names.624, i32 0, i32 0),
	i8* getelementptr inbounds ([65 x i8], [65 x i8]* @__java_type_names.625, i32 0, i32 0),
	i8* getelementptr inbounds ([70 x i8], [70 x i8]* @__java_type_names.626, i32 0, i32 0),
	i8* getelementptr inbounds ([55 x i8], [55 x i8]* @__java_type_names.627, i32 0, i32 0),
	i8* getelementptr inbounds ([55 x i8], [55 x i8]* @__java_type_names.628, i32 0, i32 0),
	i8* getelementptr inbounds ([67 x i8], [67 x i8]* @__java_type_names.629, i32 0, i32 0),
	i8* getelementptr inbounds ([67 x i8], [67 x i8]* @__java_type_names.630, i32 0, i32 0),
	i8* getelementptr inbounds ([67 x i8], [67 x i8]* @__java_type_names.631, i32 0, i32 0),
	i8* getelementptr inbounds ([67 x i8], [67 x i8]* @__java_type_names.632, i32 0, i32 0),
	i8* getelementptr inbounds ([67 x i8], [67 x i8]* @__java_type_names.633, i32 0, i32 0),
	i8* getelementptr inbounds ([67 x i8], [67 x i8]* @__java_type_names.634, i32 0, i32 0),
	i8* getelementptr inbounds ([67 x i8], [67 x i8]* @__java_type_names.635, i32 0, i32 0),
	i8* getelementptr inbounds ([67 x i8], [67 x i8]* @__java_type_names.636, i32 0, i32 0),
	i8* getelementptr inbounds ([67 x i8], [67 x i8]* @__java_type_names.637, i32 0, i32 0),
	i8* getelementptr inbounds ([69 x i8], [69 x i8]* @__java_type_names.638, i32 0, i32 0),
	i8* getelementptr inbounds ([70 x i8], [70 x i8]* @__java_type_names.639, i32 0, i32 0),
	i8* getelementptr inbounds ([70 x i8], [70 x i8]* @__java_type_names.640, i32 0, i32 0),
	i8* getelementptr inbounds ([70 x i8], [70 x i8]* @__java_type_names.641, i32 0, i32 0),
	i8* getelementptr inbounds ([70 x i8], [70 x i8]* @__java_type_names.642, i32 0, i32 0),
	i8* getelementptr inbounds ([70 x i8], [70 x i8]* @__java_type_names.643, i32 0, i32 0),
	i8* getelementptr inbounds ([70 x i8], [70 x i8]* @__java_type_names.644, i32 0, i32 0),
	i8* getelementptr inbounds ([67 x i8], [67 x i8]* @__java_type_names.645, i32 0, i32 0),
	i8* getelementptr inbounds ([71 x i8], [71 x i8]* @__java_type_names.646, i32 0, i32 0),
	i8* getelementptr inbounds ([66 x i8], [66 x i8]* @__java_type_names.647, i32 0, i32 0),
	i8* getelementptr inbounds ([63 x i8], [63 x i8]* @__java_type_names.648, i32 0, i32 0),
	i8* getelementptr inbounds ([55 x i8], [55 x i8]* @__java_type_names.649, i32 0, i32 0),
	i8* getelementptr inbounds ([64 x i8], [64 x i8]* @__java_type_names.650, i32 0, i32 0),
	i8* getelementptr inbounds ([55 x i8], [55 x i8]* @__java_type_names.651, i32 0, i32 0),
	i8* getelementptr inbounds ([55 x i8], [55 x i8]* @__java_type_names.652, i32 0, i32 0),
	i8* getelementptr inbounds ([67 x i8], [67 x i8]* @__java_type_names.653, i32 0, i32 0),
	i8* getelementptr inbounds ([55 x i8], [55 x i8]* @__java_type_names.654, i32 0, i32 0),
	i8* getelementptr inbounds ([55 x i8], [55 x i8]* @__java_type_names.655, i32 0, i32 0),
	i8* getelementptr inbounds ([55 x i8], [55 x i8]* @__java_type_names.656, i32 0, i32 0),
	i8* getelementptr inbounds ([55 x i8], [55 x i8]* @__java_type_names.657, i32 0, i32 0),
	i8* getelementptr inbounds ([55 x i8], [55 x i8]* @__java_type_names.658, i32 0, i32 0),
	i8* getelementptr inbounds ([55 x i8], [55 x i8]* @__java_type_names.659, i32 0, i32 0),
	i8* getelementptr inbounds ([68 x i8], [68 x i8]* @__java_type_names.660, i32 0, i32 0),
	i8* getelementptr inbounds ([66 x i8], [66 x i8]* @__java_type_names.661, i32 0, i32 0),
	i8* getelementptr inbounds ([68 x i8], [68 x i8]* @__java_type_names.662, i32 0, i32 0),
	i8* getelementptr inbounds ([68 x i8], [68 x i8]* @__java_type_names.663, i32 0, i32 0),
	i8* getelementptr inbounds ([66 x i8], [66 x i8]* @__java_type_names.664, i32 0, i32 0),
	i8* getelementptr inbounds ([66 x i8], [66 x i8]* @__java_type_names.665, i32 0, i32 0),
	i8* getelementptr inbounds ([55 x i8], [55 x i8]* @__java_type_names.666, i32 0, i32 0),
	i8* getelementptr inbounds ([60 x i8], [60 x i8]* @__java_type_names.667, i32 0, i32 0),
	i8* getelementptr inbounds ([65 x i8], [65 x i8]* @__java_type_names.668, i32 0, i32 0),
	i8* getelementptr inbounds ([55 x i8], [55 x i8]* @__java_type_names.669, i32 0, i32 0),
	i8* getelementptr inbounds ([55 x i8], [55 x i8]* @__java_type_names.670, i32 0, i32 0),
	i8* getelementptr inbounds ([55 x i8], [55 x i8]* @__java_type_names.671, i32 0, i32 0),
	i8* getelementptr inbounds ([55 x i8], [55 x i8]* @__java_type_names.672, i32 0, i32 0),
	i8* getelementptr inbounds ([55 x i8], [55 x i8]* @__java_type_names.673, i32 0, i32 0),
	i8* getelementptr inbounds ([55 x i8], [55 x i8]* @__java_type_names.674, i32 0, i32 0),
	i8* getelementptr inbounds ([55 x i8], [55 x i8]* @__java_type_names.675, i32 0, i32 0),
	i8* getelementptr inbounds ([55 x i8], [55 x i8]* @__java_type_names.676, i32 0, i32 0),
	i8* getelementptr inbounds ([55 x i8], [55 x i8]* @__java_type_names.677, i32 0, i32 0),
	i8* getelementptr inbounds ([70 x i8], [70 x i8]* @__java_type_names.678, i32 0, i32 0),
	i8* getelementptr inbounds ([64 x i8], [64 x i8]* @__java_type_names.679, i32 0, i32 0),
	i8* getelementptr inbounds ([72 x i8], [72 x i8]* @__java_type_names.680, i32 0, i32 0),
	i8* getelementptr inbounds ([65 x i8], [65 x i8]* @__java_type_names.681, i32 0, i32 0),
	i8* getelementptr inbounds ([67 x i8], [67 x i8]* @__java_type_names.682, i32 0, i32 0),
	i8* getelementptr inbounds ([46 x i8], [46 x i8]* @__java_type_names.683, i32 0, i32 0),
	i8* getelementptr inbounds ([51 x i8], [51 x i8]* @__java_type_names.684, i32 0, i32 0),
	i8* getelementptr inbounds ([50 x i8], [50 x i8]* @__java_type_names.685, i32 0, i32 0),
	i8* getelementptr inbounds ([50 x i8], [50 x i8]* @__java_type_names.686, i32 0, i32 0),
	i8* getelementptr inbounds ([46 x i8], [46 x i8]* @__java_type_names.687, i32 0, i32 0),
	i8* getelementptr inbounds ([49 x i8], [49 x i8]* @__java_type_names.688, i32 0, i32 0),
	i8* getelementptr inbounds ([49 x i8], [49 x i8]* @__java_type_names.689, i32 0, i32 0),
	i8* getelementptr inbounds ([45 x i8], [45 x i8]* @__java_type_names.690, i32 0, i32 0),
	i8* getelementptr inbounds ([50 x i8], [50 x i8]* @__java_type_names.691, i32 0, i32 0),
	i8* getelementptr inbounds ([43 x i8], [43 x i8]* @__java_type_names.692, i32 0, i32 0),
	i8* getelementptr inbounds ([45 x i8], [45 x i8]* @__java_type_names.693, i32 0, i32 0),
	i8* getelementptr inbounds ([42 x i8], [42 x i8]* @__java_type_names.694, i32 0, i32 0),
	i8* getelementptr inbounds ([50 x i8], [50 x i8]* @__java_type_names.695, i32 0, i32 0),
	i8* getelementptr inbounds ([50 x i8], [50 x i8]* @__java_type_names.696, i32 0, i32 0),
	i8* getelementptr inbounds ([64 x i8], [64 x i8]* @__java_type_names.697, i32 0, i32 0),
	i8* getelementptr inbounds ([68 x i8], [68 x i8]* @__java_type_names.698, i32 0, i32 0),
	i8* getelementptr inbounds ([60 x i8], [60 x i8]* @__java_type_names.699, i32 0, i32 0),
	i8* getelementptr inbounds ([57 x i8], [57 x i8]* @__java_type_names.700, i32 0, i32 0),
	i8* getelementptr inbounds ([60 x i8], [60 x i8]* @__java_type_names.701, i32 0, i32 0),
	i8* getelementptr inbounds ([61 x i8], [61 x i8]* @__java_type_names.702, i32 0, i32 0),
	i8* getelementptr inbounds ([67 x i8], [67 x i8]* @__java_type_names.703, i32 0, i32 0),
	i8* getelementptr inbounds ([62 x i8], [62 x i8]* @__java_type_names.704, i32 0, i32 0),
	i8* getelementptr inbounds ([61 x i8], [61 x i8]* @__java_type_names.705, i32 0, i32 0),
	i8* getelementptr inbounds ([59 x i8], [59 x i8]* @__java_type_names.706, i32 0, i32 0),
	i8* getelementptr inbounds ([65 x i8], [65 x i8]* @__java_type_names.707, i32 0, i32 0),
	i8* getelementptr inbounds ([56 x i8], [56 x i8]* @__java_type_names.708, i32 0, i32 0),
	i8* getelementptr inbounds ([64 x i8], [64 x i8]* @__java_type_names.709, i32 0, i32 0),
	i8* getelementptr inbounds ([73 x i8], [73 x i8]* @__java_type_names.710, i32 0, i32 0),
	i8* getelementptr inbounds ([67 x i8], [67 x i8]* @__java_type_names.711, i32 0, i32 0),
	i8* getelementptr inbounds ([61 x i8], [61 x i8]* @__java_type_names.712, i32 0, i32 0),
	i8* getelementptr inbounds ([61 x i8], [61 x i8]* @__java_type_names.713, i32 0, i32 0),
	i8* getelementptr inbounds ([58 x i8], [58 x i8]* @__java_type_names.714, i32 0, i32 0),
	i8* getelementptr inbounds ([80 x i8], [80 x i8]* @__java_type_names.715, i32 0, i32 0),
	i8* getelementptr inbounds ([72 x i8], [72 x i8]* @__java_type_names.716, i32 0, i32 0),
	i8* getelementptr inbounds ([69 x i8], [69 x i8]* @__java_type_names.717, i32 0, i32 0),
	i8* getelementptr inbounds ([58 x i8], [58 x i8]* @__java_type_names.718, i32 0, i32 0),
	i8* getelementptr inbounds ([52 x i8], [52 x i8]* @__java_type_names.719, i32 0, i32 0),
	i8* getelementptr inbounds ([55 x i8], [55 x i8]* @__java_type_names.720, i32 0, i32 0),
	i8* getelementptr inbounds ([63 x i8], [63 x i8]* @__java_type_names.721, i32 0, i32 0),
	i8* getelementptr inbounds ([67 x i8], [67 x i8]* @__java_type_names.722, i32 0, i32 0),
	i8* getelementptr inbounds ([71 x i8], [71 x i8]* @__java_type_names.723, i32 0, i32 0),
	i8* getelementptr inbounds ([65 x i8], [65 x i8]* @__java_type_names.724, i32 0, i32 0),
	i8* getelementptr inbounds ([64 x i8], [64 x i8]* @__java_type_names.725, i32 0, i32 0),
	i8* getelementptr inbounds ([66 x i8], [66 x i8]* @__java_type_names.726, i32 0, i32 0),
	i8* getelementptr inbounds ([67 x i8], [67 x i8]* @__java_type_names.727, i32 0, i32 0),
	i8* getelementptr inbounds ([87 x i8], [87 x i8]* @__java_type_names.728, i32 0, i32 0),
	i8* getelementptr inbounds ([87 x i8], [87 x i8]* @__java_type_names.729, i32 0, i32 0),
	i8* getelementptr inbounds ([59 x i8], [59 x i8]* @__java_type_names.730, i32 0, i32 0),
	i8* getelementptr inbounds ([64 x i8], [64 x i8]* @__java_type_names.731, i32 0, i32 0),
	i8* getelementptr inbounds ([64 x i8], [64 x i8]* @__java_type_names.732, i32 0, i32 0),
	i8* getelementptr inbounds ([66 x i8], [66 x i8]* @__java_type_names.733, i32 0, i32 0),
	i8* getelementptr inbounds ([79 x i8], [79 x i8]* @__java_type_names.734, i32 0, i32 0),
	i8* getelementptr inbounds ([73 x i8], [73 x i8]* @__java_type_names.735, i32 0, i32 0),
	i8* getelementptr inbounds ([72 x i8], [72 x i8]* @__java_type_names.736, i32 0, i32 0),
	i8* getelementptr inbounds ([51 x i8], [51 x i8]* @__java_type_names.737, i32 0, i32 0),
	i8* getelementptr inbounds ([54 x i8], [54 x i8]* @__java_type_names.738, i32 0, i32 0),
	i8* getelementptr inbounds ([39 x i8], [39 x i8]* @__java_type_names.739, i32 0, i32 0),
	i8* getelementptr inbounds ([37 x i8], [37 x i8]* @__java_type_names.740, i32 0, i32 0),
	i8* getelementptr inbounds ([45 x i8], [45 x i8]* @__java_type_names.741, i32 0, i32 0),
	i8* getelementptr inbounds ([34 x i8], [34 x i8]* @__java_type_names.742, i32 0, i32 0)
], align 4

!llvm.module.flags = !{!0, !1, !2}
!llvm.ident = !{!3}
!0 = !{i32 1, !"wchar_size", i32 4}
!1 = !{i32 7, !"PIC Level", i32 2}
!2 = !{i32 1, !"min_enum_size", i32 4}
!3 = !{!"Xamarin.Android remotes/origin/d17-5 @ a200af12c1e846626b8caebd926ac14c185f71ec"}
