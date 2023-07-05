; ModuleID = 'obj\Release\130\android\typemaps.arm64-v8a.ll'
source_filename = "obj\Release\130\android\typemaps.arm64-v8a.ll"
target datalayout = "e-m:e-i8:8:32-i16:16:32-i64:64-i128:128-n32:64-S128"
target triple = "aarch64-unknown-linux-android"


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
		i32 525; java_map_index
	}, 
	; 1
	%struct.TypeMapModuleEntry {
		i32 33554455, ; type_token_id
		i32 222; java_map_index
	}, 
	; 2
	%struct.TypeMapModuleEntry {
		i32 33554461, ; type_token_id
		i32 269; java_map_index
	}
], align 4; end of 'module0_managed_to_java' array


; module0_managed_to_java_duplicates
@module0_managed_to_java_duplicates = internal constant [1 x %struct.TypeMapModuleEntry] [
	; 0
	%struct.TypeMapModuleEntry {
		i32 33554456, ; type_token_id
		i32 222; java_map_index
	}
], align 4; end of 'module0_managed_to_java_duplicates' array


; module1_managed_to_java
@module1_managed_to_java = internal constant [4 x %struct.TypeMapModuleEntry] [
	; 0
	%struct.TypeMapModuleEntry {
		i32 33554436, ; type_token_id
		i32 96; java_map_index
	}, 
	; 1
	%struct.TypeMapModuleEntry {
		i32 33554437, ; type_token_id
		i32 511; java_map_index
	}, 
	; 2
	%struct.TypeMapModuleEntry {
		i32 33554438, ; type_token_id
		i32 416; java_map_index
	}, 
	; 3
	%struct.TypeMapModuleEntry {
		i32 33554440, ; type_token_id
		i32 632; java_map_index
	}
], align 4; end of 'module1_managed_to_java' array


; module1_managed_to_java_duplicates
@module1_managed_to_java_duplicates = internal constant [3 x %struct.TypeMapModuleEntry] [
	; 0
	%struct.TypeMapModuleEntry {
		i32 33554439, ; type_token_id
		i32 416; java_map_index
	}, 
	; 1
	%struct.TypeMapModuleEntry {
		i32 33554441, ; type_token_id
		i32 632; java_map_index
	}, 
	; 2
	%struct.TypeMapModuleEntry {
		i32 33554442, ; type_token_id
		i32 96; java_map_index
	}
], align 4; end of 'module1_managed_to_java_duplicates' array


; module2_managed_to_java
@module2_managed_to_java = internal constant [25 x %struct.TypeMapModuleEntry] [
	; 0
	%struct.TypeMapModuleEntry {
		i32 33554465, ; type_token_id
		i32 355; java_map_index
	}, 
	; 1
	%struct.TypeMapModuleEntry {
		i32 33554466, ; type_token_id
		i32 340; java_map_index
	}, 
	; 2
	%struct.TypeMapModuleEntry {
		i32 33554469, ; type_token_id
		i32 335; java_map_index
	}, 
	; 3
	%struct.TypeMapModuleEntry {
		i32 33554470, ; type_token_id
		i32 378; java_map_index
	}, 
	; 4
	%struct.TypeMapModuleEntry {
		i32 33554473, ; type_token_id
		i32 258; java_map_index
	}, 
	; 5
	%struct.TypeMapModuleEntry {
		i32 33554479, ; type_token_id
		i32 622; java_map_index
	}, 
	; 6
	%struct.TypeMapModuleEntry {
		i32 33554480, ; type_token_id
		i32 494; java_map_index
	}, 
	; 7
	%struct.TypeMapModuleEntry {
		i32 33554482, ; type_token_id
		i32 404; java_map_index
	}, 
	; 8
	%struct.TypeMapModuleEntry {
		i32 33554484, ; type_token_id
		i32 110; java_map_index
	}, 
	; 9
	%struct.TypeMapModuleEntry {
		i32 33554485, ; type_token_id
		i32 722; java_map_index
	}, 
	; 10
	%struct.TypeMapModuleEntry {
		i32 33554487, ; type_token_id
		i32 513; java_map_index
	}, 
	; 11
	%struct.TypeMapModuleEntry {
		i32 33554488, ; type_token_id
		i32 729; java_map_index
	}, 
	; 12
	%struct.TypeMapModuleEntry {
		i32 33554490, ; type_token_id
		i32 397; java_map_index
	}, 
	; 13
	%struct.TypeMapModuleEntry {
		i32 33554492, ; type_token_id
		i32 137; java_map_index
	}, 
	; 14
	%struct.TypeMapModuleEntry {
		i32 33554493, ; type_token_id
		i32 512; java_map_index
	}, 
	; 15
	%struct.TypeMapModuleEntry {
		i32 33554494, ; type_token_id
		i32 599; java_map_index
	}, 
	; 16
	%struct.TypeMapModuleEntry {
		i32 33554495, ; type_token_id
		i32 80; java_map_index
	}, 
	; 17
	%struct.TypeMapModuleEntry {
		i32 33554497, ; type_token_id
		i32 605; java_map_index
	}, 
	; 18
	%struct.TypeMapModuleEntry {
		i32 33554499, ; type_token_id
		i32 161; java_map_index
	}, 
	; 19
	%struct.TypeMapModuleEntry {
		i32 33554501, ; type_token_id
		i32 6; java_map_index
	}, 
	; 20
	%struct.TypeMapModuleEntry {
		i32 33554502, ; type_token_id
		i32 247; java_map_index
	}, 
	; 21
	%struct.TypeMapModuleEntry {
		i32 33554503, ; type_token_id
		i32 66; java_map_index
	}, 
	; 22
	%struct.TypeMapModuleEntry {
		i32 33554504, ; type_token_id
		i32 60; java_map_index
	}, 
	; 23
	%struct.TypeMapModuleEntry {
		i32 33554507, ; type_token_id
		i32 425; java_map_index
	}, 
	; 24
	%struct.TypeMapModuleEntry {
		i32 33554508, ; type_token_id
		i32 19; java_map_index
	}
], align 4; end of 'module2_managed_to_java' array


; module2_managed_to_java_duplicates
@module2_managed_to_java_duplicates = internal constant [14 x %struct.TypeMapModuleEntry] [
	; 0
	%struct.TypeMapModuleEntry {
		i32 33554467, ; type_token_id
		i32 340; java_map_index
	}, 
	; 1
	%struct.TypeMapModuleEntry {
		i32 33554471, ; type_token_id
		i32 378; java_map_index
	}, 
	; 2
	%struct.TypeMapModuleEntry {
		i32 33554478, ; type_token_id
		i32 355; java_map_index
	}, 
	; 3
	%struct.TypeMapModuleEntry {
		i32 33554481, ; type_token_id
		i32 494; java_map_index
	}, 
	; 4
	%struct.TypeMapModuleEntry {
		i32 33554483, ; type_token_id
		i32 404; java_map_index
	}, 
	; 5
	%struct.TypeMapModuleEntry {
		i32 33554486, ; type_token_id
		i32 722; java_map_index
	}, 
	; 6
	%struct.TypeMapModuleEntry {
		i32 33554489, ; type_token_id
		i32 729; java_map_index
	}, 
	; 7
	%struct.TypeMapModuleEntry {
		i32 33554491, ; type_token_id
		i32 397; java_map_index
	}, 
	; 8
	%struct.TypeMapModuleEntry {
		i32 33554496, ; type_token_id
		i32 80; java_map_index
	}, 
	; 9
	%struct.TypeMapModuleEntry {
		i32 33554498, ; type_token_id
		i32 605; java_map_index
	}, 
	; 10
	%struct.TypeMapModuleEntry {
		i32 33554500, ; type_token_id
		i32 161; java_map_index
	}, 
	; 11
	%struct.TypeMapModuleEntry {
		i32 33554505, ; type_token_id
		i32 60; java_map_index
	}, 
	; 12
	%struct.TypeMapModuleEntry {
		i32 33554506, ; type_token_id
		i32 66; java_map_index
	}, 
	; 13
	%struct.TypeMapModuleEntry {
		i32 33554509, ; type_token_id
		i32 19; java_map_index
	}
], align 4; end of 'module2_managed_to_java_duplicates' array


; module3_managed_to_java
@module3_managed_to_java = internal constant [3 x %struct.TypeMapModuleEntry] [
	; 0
	%struct.TypeMapModuleEntry {
		i32 33554435, ; type_token_id
		i32 379; java_map_index
	}, 
	; 1
	%struct.TypeMapModuleEntry {
		i32 33554437, ; type_token_id
		i32 581; java_map_index
	}, 
	; 2
	%struct.TypeMapModuleEntry {
		i32 33554438, ; type_token_id
		i32 564; java_map_index
	}
], align 4; end of 'module3_managed_to_java' array


; module3_managed_to_java_duplicates
@module3_managed_to_java_duplicates = internal constant [2 x %struct.TypeMapModuleEntry] [
	; 0
	%struct.TypeMapModuleEntry {
		i32 33554436, ; type_token_id
		i32 379; java_map_index
	}, 
	; 1
	%struct.TypeMapModuleEntry {
		i32 33554439, ; type_token_id
		i32 564; java_map_index
	}
], align 4; end of 'module3_managed_to_java_duplicates' array


; module4_managed_to_java
@module4_managed_to_java = internal constant [10 x %struct.TypeMapModuleEntry] [
	; 0
	%struct.TypeMapModuleEntry {
		i32 33554467, ; type_token_id
		i32 590; java_map_index
	}, 
	; 1
	%struct.TypeMapModuleEntry {
		i32 33554468, ; type_token_id
		i32 406; java_map_index
	}, 
	; 2
	%struct.TypeMapModuleEntry {
		i32 33554469, ; type_token_id
		i32 430; java_map_index
	}, 
	; 3
	%struct.TypeMapModuleEntry {
		i32 33554470, ; type_token_id
		i32 268; java_map_index
	}, 
	; 4
	%struct.TypeMapModuleEntry {
		i32 33554471, ; type_token_id
		i32 94; java_map_index
	}, 
	; 5
	%struct.TypeMapModuleEntry {
		i32 33554472, ; type_token_id
		i32 116; java_map_index
	}, 
	; 6
	%struct.TypeMapModuleEntry {
		i32 33554474, ; type_token_id
		i32 678; java_map_index
	}, 
	; 7
	%struct.TypeMapModuleEntry {
		i32 33554476, ; type_token_id
		i32 67; java_map_index
	}, 
	; 8
	%struct.TypeMapModuleEntry {
		i32 33554478, ; type_token_id
		i32 386; java_map_index
	}, 
	; 9
	%struct.TypeMapModuleEntry {
		i32 33554482, ; type_token_id
		i32 713; java_map_index
	}
], align 4; end of 'module4_managed_to_java' array


; module4_managed_to_java_duplicates
@module4_managed_to_java_duplicates = internal constant [5 x %struct.TypeMapModuleEntry] [
	; 0
	%struct.TypeMapModuleEntry {
		i32 33554473, ; type_token_id
		i32 116; java_map_index
	}, 
	; 1
	%struct.TypeMapModuleEntry {
		i32 33554475, ; type_token_id
		i32 678; java_map_index
	}, 
	; 2
	%struct.TypeMapModuleEntry {
		i32 33554477, ; type_token_id
		i32 67; java_map_index
	}, 
	; 3
	%struct.TypeMapModuleEntry {
		i32 33554481, ; type_token_id
		i32 94; java_map_index
	}, 
	; 4
	%struct.TypeMapModuleEntry {
		i32 33554483, ; type_token_id
		i32 713; java_map_index
	}
], align 4; end of 'module4_managed_to_java_duplicates' array


; module5_managed_to_java
@module5_managed_to_java = internal constant [1 x %struct.TypeMapModuleEntry] [
	; 0
	%struct.TypeMapModuleEntry {
		i32 33554448, ; type_token_id
		i32 443; java_map_index
	}
], align 4; end of 'module5_managed_to_java' array


; module6_managed_to_java
@module6_managed_to_java = internal constant [5 x %struct.TypeMapModuleEntry] [
	; 0
	%struct.TypeMapModuleEntry {
		i32 33554447, ; type_token_id
		i32 85; java_map_index
	}, 
	; 1
	%struct.TypeMapModuleEntry {
		i32 33554448, ; type_token_id
		i32 697; java_map_index
	}, 
	; 2
	%struct.TypeMapModuleEntry {
		i32 33554450, ; type_token_id
		i32 255; java_map_index
	}, 
	; 3
	%struct.TypeMapModuleEntry {
		i32 33554452, ; type_token_id
		i32 542; java_map_index
	}, 
	; 4
	%struct.TypeMapModuleEntry {
		i32 33554453, ; type_token_id
		i32 664; java_map_index
	}
], align 4; end of 'module6_managed_to_java' array


; module6_managed_to_java_duplicates
@module6_managed_to_java_duplicates = internal constant [4 x %struct.TypeMapModuleEntry] [
	; 0
	%struct.TypeMapModuleEntry {
		i32 33554449, ; type_token_id
		i32 697; java_map_index
	}, 
	; 1
	%struct.TypeMapModuleEntry {
		i32 33554451, ; type_token_id
		i32 255; java_map_index
	}, 
	; 2
	%struct.TypeMapModuleEntry {
		i32 33554454, ; type_token_id
		i32 664; java_map_index
	}, 
	; 3
	%struct.TypeMapModuleEntry {
		i32 33554455, ; type_token_id
		i32 542; java_map_index
	}
], align 4; end of 'module6_managed_to_java_duplicates' array


; module7_managed_to_java
@module7_managed_to_java = internal constant [282 x %struct.TypeMapModuleEntry] [
	; 0
	%struct.TypeMapModuleEntry {
		i32 33554561, ; type_token_id
		i32 437; java_map_index
	}, 
	; 1
	%struct.TypeMapModuleEntry {
		i32 33554562, ; type_token_id
		i32 166; java_map_index
	}, 
	; 2
	%struct.TypeMapModuleEntry {
		i32 33554564, ; type_token_id
		i32 239; java_map_index
	}, 
	; 3
	%struct.TypeMapModuleEntry {
		i32 33554566, ; type_token_id
		i32 545; java_map_index
	}, 
	; 4
	%struct.TypeMapModuleEntry {
		i32 33554567, ; type_token_id
		i32 194; java_map_index
	}, 
	; 5
	%struct.TypeMapModuleEntry {
		i32 33554569, ; type_token_id
		i32 24; java_map_index
	}, 
	; 6
	%struct.TypeMapModuleEntry {
		i32 33554571, ; type_token_id
		i32 618; java_map_index
	}, 
	; 7
	%struct.TypeMapModuleEntry {
		i32 33554573, ; type_token_id
		i32 364; java_map_index
	}, 
	; 8
	%struct.TypeMapModuleEntry {
		i32 33554575, ; type_token_id
		i32 271; java_map_index
	}, 
	; 9
	%struct.TypeMapModuleEntry {
		i32 33554577, ; type_token_id
		i32 640; java_map_index
	}, 
	; 10
	%struct.TypeMapModuleEntry {
		i32 33554579, ; type_token_id
		i32 647; java_map_index
	}, 
	; 11
	%struct.TypeMapModuleEntry {
		i32 33554581, ; type_token_id
		i32 421; java_map_index
	}, 
	; 12
	%struct.TypeMapModuleEntry {
		i32 33554583, ; type_token_id
		i32 580; java_map_index
	}, 
	; 13
	%struct.TypeMapModuleEntry {
		i32 33554584, ; type_token_id
		i32 454; java_map_index
	}, 
	; 14
	%struct.TypeMapModuleEntry {
		i32 33554585, ; type_token_id
		i32 732; java_map_index
	}, 
	; 15
	%struct.TypeMapModuleEntry {
		i32 33554587, ; type_token_id
		i32 188; java_map_index
	}, 
	; 16
	%struct.TypeMapModuleEntry {
		i32 33554597, ; type_token_id
		i32 186; java_map_index
	}, 
	; 17
	%struct.TypeMapModuleEntry {
		i32 33554599, ; type_token_id
		i32 431; java_map_index
	}, 
	; 18
	%struct.TypeMapModuleEntry {
		i32 33554601, ; type_token_id
		i32 135; java_map_index
	}, 
	; 19
	%struct.TypeMapModuleEntry {
		i32 33554602, ; type_token_id
		i32 621; java_map_index
	}, 
	; 20
	%struct.TypeMapModuleEntry {
		i32 33554605, ; type_token_id
		i32 12; java_map_index
	}, 
	; 21
	%struct.TypeMapModuleEntry {
		i32 33554606, ; type_token_id
		i32 484; java_map_index
	}, 
	; 22
	%struct.TypeMapModuleEntry {
		i32 33554607, ; type_token_id
		i32 233; java_map_index
	}, 
	; 23
	%struct.TypeMapModuleEntry {
		i32 33554608, ; type_token_id
		i32 532; java_map_index
	}, 
	; 24
	%struct.TypeMapModuleEntry {
		i32 33554609, ; type_token_id
		i32 237; java_map_index
	}, 
	; 25
	%struct.TypeMapModuleEntry {
		i32 33554611, ; type_token_id
		i32 162; java_map_index
	}, 
	; 26
	%struct.TypeMapModuleEntry {
		i32 33554613, ; type_token_id
		i32 15; java_map_index
	}, 
	; 27
	%struct.TypeMapModuleEntry {
		i32 33554614, ; type_token_id
		i32 377; java_map_index
	}, 
	; 28
	%struct.TypeMapModuleEntry {
		i32 33554616, ; type_token_id
		i32 248; java_map_index
	}, 
	; 29
	%struct.TypeMapModuleEntry {
		i32 33554617, ; type_token_id
		i32 189; java_map_index
	}, 
	; 30
	%struct.TypeMapModuleEntry {
		i32 33554620, ; type_token_id
		i32 21; java_map_index
	}, 
	; 31
	%struct.TypeMapModuleEntry {
		i32 33554622, ; type_token_id
		i32 659; java_map_index
	}, 
	; 32
	%struct.TypeMapModuleEntry {
		i32 33554623, ; type_token_id
		i32 704; java_map_index
	}, 
	; 33
	%struct.TypeMapModuleEntry {
		i32 33554624, ; type_token_id
		i32 261; java_map_index
	}, 
	; 34
	%struct.TypeMapModuleEntry {
		i32 33554625, ; type_token_id
		i32 315; java_map_index
	}, 
	; 35
	%struct.TypeMapModuleEntry {
		i32 33554627, ; type_token_id
		i32 198; java_map_index
	}, 
	; 36
	%struct.TypeMapModuleEntry {
		i32 33554629, ; type_token_id
		i32 192; java_map_index
	}, 
	; 37
	%struct.TypeMapModuleEntry {
		i32 33554631, ; type_token_id
		i32 342; java_map_index
	}, 
	; 38
	%struct.TypeMapModuleEntry {
		i32 33554633, ; type_token_id
		i32 149; java_map_index
	}, 
	; 39
	%struct.TypeMapModuleEntry {
		i32 33554635, ; type_token_id
		i32 124; java_map_index
	}, 
	; 40
	%struct.TypeMapModuleEntry {
		i32 33554637, ; type_token_id
		i32 95; java_map_index
	}, 
	; 41
	%struct.TypeMapModuleEntry {
		i32 33554639, ; type_token_id
		i32 108; java_map_index
	}, 
	; 42
	%struct.TypeMapModuleEntry {
		i32 33554641, ; type_token_id
		i32 160; java_map_index
	}, 
	; 43
	%struct.TypeMapModuleEntry {
		i32 33554643, ; type_token_id
		i32 104; java_map_index
	}, 
	; 44
	%struct.TypeMapModuleEntry {
		i32 33554645, ; type_token_id
		i32 536; java_map_index
	}, 
	; 45
	%struct.TypeMapModuleEntry {
		i32 33554647, ; type_token_id
		i32 593; java_map_index
	}, 
	; 46
	%struct.TypeMapModuleEntry {
		i32 33554649, ; type_token_id
		i32 300; java_map_index
	}, 
	; 47
	%struct.TypeMapModuleEntry {
		i32 33554650, ; type_token_id
		i32 422; java_map_index
	}, 
	; 48
	%struct.TypeMapModuleEntry {
		i32 33554652, ; type_token_id
		i32 257; java_map_index
	}, 
	; 49
	%struct.TypeMapModuleEntry {
		i32 33554653, ; type_token_id
		i32 695; java_map_index
	}, 
	; 50
	%struct.TypeMapModuleEntry {
		i32 33554654, ; type_token_id
		i32 520; java_map_index
	}, 
	; 51
	%struct.TypeMapModuleEntry {
		i32 33554656, ; type_token_id
		i32 354; java_map_index
	}, 
	; 52
	%struct.TypeMapModuleEntry {
		i32 33554657, ; type_token_id
		i32 190; java_map_index
	}, 
	; 53
	%struct.TypeMapModuleEntry {
		i32 33554659, ; type_token_id
		i32 348; java_map_index
	}, 
	; 54
	%struct.TypeMapModuleEntry {
		i32 33554662, ; type_token_id
		i32 92; java_map_index
	}, 
	; 55
	%struct.TypeMapModuleEntry {
		i32 33554663, ; type_token_id
		i32 25; java_map_index
	}, 
	; 56
	%struct.TypeMapModuleEntry {
		i32 33554664, ; type_token_id
		i32 663; java_map_index
	}, 
	; 57
	%struct.TypeMapModuleEntry {
		i32 33554665, ; type_token_id
		i32 276; java_map_index
	}, 
	; 58
	%struct.TypeMapModuleEntry {
		i32 33554666, ; type_token_id
		i32 481; java_map_index
	}, 
	; 59
	%struct.TypeMapModuleEntry {
		i32 33554667, ; type_token_id
		i32 568; java_map_index
	}, 
	; 60
	%struct.TypeMapModuleEntry {
		i32 33554669, ; type_token_id
		i32 607; java_map_index
	}, 
	; 61
	%struct.TypeMapModuleEntry {
		i32 33554670, ; type_token_id
		i32 343; java_map_index
	}, 
	; 62
	%struct.TypeMapModuleEntry {
		i32 33554675, ; type_token_id
		i32 675; java_map_index
	}, 
	; 63
	%struct.TypeMapModuleEntry {
		i32 33554676, ; type_token_id
		i32 420; java_map_index
	}, 
	; 64
	%struct.TypeMapModuleEntry {
		i32 33554677, ; type_token_id
		i32 365; java_map_index
	}, 
	; 65
	%struct.TypeMapModuleEntry {
		i32 33554679, ; type_token_id
		i32 390; java_map_index
	}, 
	; 66
	%struct.TypeMapModuleEntry {
		i32 33554680, ; type_token_id
		i32 657; java_map_index
	}, 
	; 67
	%struct.TypeMapModuleEntry {
		i32 33554681, ; type_token_id
		i32 51; java_map_index
	}, 
	; 68
	%struct.TypeMapModuleEntry {
		i32 33554683, ; type_token_id
		i32 115; java_map_index
	}, 
	; 69
	%struct.TypeMapModuleEntry {
		i32 33554684, ; type_token_id
		i32 273; java_map_index
	}, 
	; 70
	%struct.TypeMapModuleEntry {
		i32 33554687, ; type_token_id
		i32 635; java_map_index
	}, 
	; 71
	%struct.TypeMapModuleEntry {
		i32 33554699, ; type_token_id
		i32 451; java_map_index
	}, 
	; 72
	%struct.TypeMapModuleEntry {
		i32 33554701, ; type_token_id
		i32 169; java_map_index
	}, 
	; 73
	%struct.TypeMapModuleEntry {
		i32 33554703, ; type_token_id
		i32 383; java_map_index
	}, 
	; 74
	%struct.TypeMapModuleEntry {
		i32 33554704, ; type_token_id
		i32 235; java_map_index
	}, 
	; 75
	%struct.TypeMapModuleEntry {
		i32 33554705, ; type_token_id
		i32 515; java_map_index
	}, 
	; 76
	%struct.TypeMapModuleEntry {
		i32 33554710, ; type_token_id
		i32 578; java_map_index
	}, 
	; 77
	%struct.TypeMapModuleEntry {
		i32 33554711, ; type_token_id
		i32 547; java_map_index
	}, 
	; 78
	%struct.TypeMapModuleEntry {
		i32 33554712, ; type_token_id
		i32 563; java_map_index
	}, 
	; 79
	%struct.TypeMapModuleEntry {
		i32 33554714, ; type_token_id
		i32 720; java_map_index
	}, 
	; 80
	%struct.TypeMapModuleEntry {
		i32 33554715, ; type_token_id
		i32 171; java_map_index
	}, 
	; 81
	%struct.TypeMapModuleEntry {
		i32 33554716, ; type_token_id
		i32 48; java_map_index
	}, 
	; 82
	%struct.TypeMapModuleEntry {
		i32 33554718, ; type_token_id
		i32 73; java_map_index
	}, 
	; 83
	%struct.TypeMapModuleEntry {
		i32 33554719, ; type_token_id
		i32 122; java_map_index
	}, 
	; 84
	%struct.TypeMapModuleEntry {
		i32 33554720, ; type_token_id
		i32 287; java_map_index
	}, 
	; 85
	%struct.TypeMapModuleEntry {
		i32 33554721, ; type_token_id
		i32 14; java_map_index
	}, 
	; 86
	%struct.TypeMapModuleEntry {
		i32 33554722, ; type_token_id
		i32 445; java_map_index
	}, 
	; 87
	%struct.TypeMapModuleEntry {
		i32 33554723, ; type_token_id
		i32 373; java_map_index
	}, 
	; 88
	%struct.TypeMapModuleEntry {
		i32 33554725, ; type_token_id
		i32 329; java_map_index
	}, 
	; 89
	%struct.TypeMapModuleEntry {
		i32 33554727, ; type_token_id
		i32 175; java_map_index
	}, 
	; 90
	%struct.TypeMapModuleEntry {
		i32 33554729, ; type_token_id
		i32 139; java_map_index
	}, 
	; 91
	%struct.TypeMapModuleEntry {
		i32 33554731, ; type_token_id
		i32 286; java_map_index
	}, 
	; 92
	%struct.TypeMapModuleEntry {
		i32 33554733, ; type_token_id
		i32 500; java_map_index
	}, 
	; 93
	%struct.TypeMapModuleEntry {
		i32 33554734, ; type_token_id
		i32 595; java_map_index
	}, 
	; 94
	%struct.TypeMapModuleEntry {
		i32 33554735, ; type_token_id
		i32 256; java_map_index
	}, 
	; 95
	%struct.TypeMapModuleEntry {
		i32 33554739, ; type_token_id
		i32 163; java_map_index
	}, 
	; 96
	%struct.TypeMapModuleEntry {
		i32 33554740, ; type_token_id
		i32 179; java_map_index
	}, 
	; 97
	%struct.TypeMapModuleEntry {
		i32 33554742, ; type_token_id
		i32 31; java_map_index
	}, 
	; 98
	%struct.TypeMapModuleEntry {
		i32 33554743, ; type_token_id
		i32 28; java_map_index
	}, 
	; 99
	%struct.TypeMapModuleEntry {
		i32 33554745, ; type_token_id
		i32 737; java_map_index
	}, 
	; 100
	%struct.TypeMapModuleEntry {
		i32 33554746, ; type_token_id
		i32 716; java_map_index
	}, 
	; 101
	%struct.TypeMapModuleEntry {
		i32 33554747, ; type_token_id
		i32 662; java_map_index
	}, 
	; 102
	%struct.TypeMapModuleEntry {
		i32 33554748, ; type_token_id
		i32 374; java_map_index
	}, 
	; 103
	%struct.TypeMapModuleEntry {
		i32 33554749, ; type_token_id
		i32 551; java_map_index
	}, 
	; 104
	%struct.TypeMapModuleEntry {
		i32 33554750, ; type_token_id
		i32 652; java_map_index
	}, 
	; 105
	%struct.TypeMapModuleEntry {
		i32 33554751, ; type_token_id
		i32 152; java_map_index
	}, 
	; 106
	%struct.TypeMapModuleEntry {
		i32 33554752, ; type_token_id
		i32 165; java_map_index
	}, 
	; 107
	%struct.TypeMapModuleEntry {
		i32 33554753, ; type_token_id
		i32 576; java_map_index
	}, 
	; 108
	%struct.TypeMapModuleEntry {
		i32 33554754, ; type_token_id
		i32 689; java_map_index
	}, 
	; 109
	%struct.TypeMapModuleEntry {
		i32 33554755, ; type_token_id
		i32 361; java_map_index
	}, 
	; 110
	%struct.TypeMapModuleEntry {
		i32 33554756, ; type_token_id
		i32 533; java_map_index
	}, 
	; 111
	%struct.TypeMapModuleEntry {
		i32 33554757, ; type_token_id
		i32 246; java_map_index
	}, 
	; 112
	%struct.TypeMapModuleEntry {
		i32 33554758, ; type_token_id
		i32 671; java_map_index
	}, 
	; 113
	%struct.TypeMapModuleEntry {
		i32 33554759, ; type_token_id
		i32 541; java_map_index
	}, 
	; 114
	%struct.TypeMapModuleEntry {
		i32 33554760, ; type_token_id
		i32 447; java_map_index
	}, 
	; 115
	%struct.TypeMapModuleEntry {
		i32 33554763, ; type_token_id
		i32 372; java_map_index
	}, 
	; 116
	%struct.TypeMapModuleEntry {
		i32 33554764, ; type_token_id
		i32 613; java_map_index
	}, 
	; 117
	%struct.TypeMapModuleEntry {
		i32 33554767, ; type_token_id
		i32 432; java_map_index
	}, 
	; 118
	%struct.TypeMapModuleEntry {
		i32 33554769, ; type_token_id
		i32 486; java_map_index
	}, 
	; 119
	%struct.TypeMapModuleEntry {
		i32 33554770, ; type_token_id
		i32 218; java_map_index
	}, 
	; 120
	%struct.TypeMapModuleEntry {
		i32 33554772, ; type_token_id
		i32 90; java_map_index
	}, 
	; 121
	%struct.TypeMapModuleEntry {
		i32 33554775, ; type_token_id
		i32 56; java_map_index
	}, 
	; 122
	%struct.TypeMapModuleEntry {
		i32 33554777, ; type_token_id
		i32 29; java_map_index
	}, 
	; 123
	%struct.TypeMapModuleEntry {
		i32 33554780, ; type_token_id
		i32 396; java_map_index
	}, 
	; 124
	%struct.TypeMapModuleEntry {
		i32 33554781, ; type_token_id
		i32 665; java_map_index
	}, 
	; 125
	%struct.TypeMapModuleEntry {
		i32 33554782, ; type_token_id
		i32 249; java_map_index
	}, 
	; 126
	%struct.TypeMapModuleEntry {
		i32 33554784, ; type_token_id
		i32 127; java_map_index
	}, 
	; 127
	%struct.TypeMapModuleEntry {
		i32 33554785, ; type_token_id
		i32 344; java_map_index
	}, 
	; 128
	%struct.TypeMapModuleEntry {
		i32 33554790, ; type_token_id
		i32 181; java_map_index
	}, 
	; 129
	%struct.TypeMapModuleEntry {
		i32 33554792, ; type_token_id
		i32 531; java_map_index
	}, 
	; 130
	%struct.TypeMapModuleEntry {
		i32 33554793, ; type_token_id
		i32 487; java_map_index
	}, 
	; 131
	%struct.TypeMapModuleEntry {
		i32 33554795, ; type_token_id
		i32 331; java_map_index
	}, 
	; 132
	%struct.TypeMapModuleEntry {
		i32 33554796, ; type_token_id
		i32 493; java_map_index
	}, 
	; 133
	%struct.TypeMapModuleEntry {
		i32 33554798, ; type_token_id
		i32 65; java_map_index
	}, 
	; 134
	%struct.TypeMapModuleEntry {
		i32 33554800, ; type_token_id
		i32 554; java_map_index
	}, 
	; 135
	%struct.TypeMapModuleEntry {
		i32 33554802, ; type_token_id
		i32 661; java_map_index
	}, 
	; 136
	%struct.TypeMapModuleEntry {
		i32 33554804, ; type_token_id
		i32 136; java_map_index
	}, 
	; 137
	%struct.TypeMapModuleEntry {
		i32 33554806, ; type_token_id
		i32 120; java_map_index
	}, 
	; 138
	%struct.TypeMapModuleEntry {
		i32 33554807, ; type_token_id
		i32 544; java_map_index
	}, 
	; 139
	%struct.TypeMapModuleEntry {
		i32 33554808, ; type_token_id
		i32 658; java_map_index
	}, 
	; 140
	%struct.TypeMapModuleEntry {
		i32 33554810, ; type_token_id
		i32 677; java_map_index
	}, 
	; 141
	%struct.TypeMapModuleEntry {
		i32 33554812, ; type_token_id
		i32 731; java_map_index
	}, 
	; 142
	%struct.TypeMapModuleEntry {
		i32 33554814, ; type_token_id
		i32 591; java_map_index
	}, 
	; 143
	%struct.TypeMapModuleEntry {
		i32 33554818, ; type_token_id
		i32 426; java_map_index
	}, 
	; 144
	%struct.TypeMapModuleEntry {
		i32 33554819, ; type_token_id
		i32 347; java_map_index
	}, 
	; 145
	%struct.TypeMapModuleEntry {
		i32 33554820, ; type_token_id
		i32 498; java_map_index
	}, 
	; 146
	%struct.TypeMapModuleEntry {
		i32 33554821, ; type_token_id
		i32 232; java_map_index
	}, 
	; 147
	%struct.TypeMapModuleEntry {
		i32 33554822, ; type_token_id
		i32 146; java_map_index
	}, 
	; 148
	%struct.TypeMapModuleEntry {
		i32 33554847, ; type_token_id
		i32 670; java_map_index
	}, 
	; 149
	%struct.TypeMapModuleEntry {
		i32 33554850, ; type_token_id
		i32 462; java_map_index
	}, 
	; 150
	%struct.TypeMapModuleEntry {
		i32 33554852, ; type_token_id
		i32 740; java_map_index
	}, 
	; 151
	%struct.TypeMapModuleEntry {
		i32 33554854, ; type_token_id
		i32 311; java_map_index
	}, 
	; 152
	%struct.TypeMapModuleEntry {
		i32 33554863, ; type_token_id
		i32 469; java_map_index
	}, 
	; 153
	%struct.TypeMapModuleEntry {
		i32 33554865, ; type_token_id
		i32 668; java_map_index
	}, 
	; 154
	%struct.TypeMapModuleEntry {
		i32 33554867, ; type_token_id
		i32 58; java_map_index
	}, 
	; 155
	%struct.TypeMapModuleEntry {
		i32 33554868, ; type_token_id
		i32 50; java_map_index
	}, 
	; 156
	%struct.TypeMapModuleEntry {
		i32 33554884, ; type_token_id
		i32 586; java_map_index
	}, 
	; 157
	%struct.TypeMapModuleEntry {
		i32 33554894, ; type_token_id
		i32 653; java_map_index
	}, 
	; 158
	%struct.TypeMapModuleEntry {
		i32 33554896, ; type_token_id
		i32 715; java_map_index
	}, 
	; 159
	%struct.TypeMapModuleEntry {
		i32 33554898, ; type_token_id
		i32 118; java_map_index
	}, 
	; 160
	%struct.TypeMapModuleEntry {
		i32 33554899, ; type_token_id
		i32 363; java_map_index
	}, 
	; 161
	%struct.TypeMapModuleEntry {
		i32 33554900, ; type_token_id
		i32 439; java_map_index
	}, 
	; 162
	%struct.TypeMapModuleEntry {
		i32 33554904, ; type_token_id
		i32 452; java_map_index
	}, 
	; 163
	%struct.TypeMapModuleEntry {
		i32 33554906, ; type_token_id
		i32 700; java_map_index
	}, 
	; 164
	%struct.TypeMapModuleEntry {
		i32 33554908, ; type_token_id
		i32 61; java_map_index
	}, 
	; 165
	%struct.TypeMapModuleEntry {
		i32 33554910, ; type_token_id
		i32 741; java_map_index
	}, 
	; 166
	%struct.TypeMapModuleEntry {
		i32 33554912, ; type_token_id
		i32 598; java_map_index
	}, 
	; 167
	%struct.TypeMapModuleEntry {
		i32 33554914, ; type_token_id
		i32 438; java_map_index
	}, 
	; 168
	%struct.TypeMapModuleEntry {
		i32 33554916, ; type_token_id
		i32 736; java_map_index
	}, 
	; 169
	%struct.TypeMapModuleEntry {
		i32 33554917, ; type_token_id
		i32 231; java_map_index
	}, 
	; 170
	%struct.TypeMapModuleEntry {
		i32 33554919, ; type_token_id
		i32 504; java_map_index
	}, 
	; 171
	%struct.TypeMapModuleEntry {
		i32 33554920, ; type_token_id
		i32 47; java_map_index
	}, 
	; 172
	%struct.TypeMapModuleEntry {
		i32 33554922, ; type_token_id
		i32 321; java_map_index
	}, 
	; 173
	%struct.TypeMapModuleEntry {
		i32 33554924, ; type_token_id
		i32 456; java_map_index
	}, 
	; 174
	%struct.TypeMapModuleEntry {
		i32 33554926, ; type_token_id
		i32 669; java_map_index
	}, 
	; 175
	%struct.TypeMapModuleEntry {
		i32 33554928, ; type_token_id
		i32 567; java_map_index
	}, 
	; 176
	%struct.TypeMapModuleEntry {
		i32 33554930, ; type_token_id
		i32 628; java_map_index
	}, 
	; 177
	%struct.TypeMapModuleEntry {
		i32 33554932, ; type_token_id
		i32 522; java_map_index
	}, 
	; 178
	%struct.TypeMapModuleEntry {
		i32 33554934, ; type_token_id
		i32 5; java_map_index
	}, 
	; 179
	%struct.TypeMapModuleEntry {
		i32 33554936, ; type_token_id
		i32 475; java_map_index
	}, 
	; 180
	%struct.TypeMapModuleEntry {
		i32 33554938, ; type_token_id
		i32 381; java_map_index
	}, 
	; 181
	%struct.TypeMapModuleEntry {
		i32 33554940, ; type_token_id
		i32 476; java_map_index
	}, 
	; 182
	%struct.TypeMapModuleEntry {
		i32 33554941, ; type_token_id
		i32 368; java_map_index
	}, 
	; 183
	%struct.TypeMapModuleEntry {
		i32 33554943, ; type_token_id
		i32 703; java_map_index
	}, 
	; 184
	%struct.TypeMapModuleEntry {
		i32 33554944, ; type_token_id
		i32 641; java_map_index
	}, 
	; 185
	%struct.TypeMapModuleEntry {
		i32 33554946, ; type_token_id
		i32 180; java_map_index
	}, 
	; 186
	%struct.TypeMapModuleEntry {
		i32 33554948, ; type_token_id
		i32 106; java_map_index
	}, 
	; 187
	%struct.TypeMapModuleEntry {
		i32 33554949, ; type_token_id
		i32 471; java_map_index
	}, 
	; 188
	%struct.TypeMapModuleEntry {
		i32 33554951, ; type_token_id
		i32 230; java_map_index
	}, 
	; 189
	%struct.TypeMapModuleEntry {
		i32 33554952, ; type_token_id
		i32 506; java_map_index
	}, 
	; 190
	%struct.TypeMapModuleEntry {
		i32 33554954, ; type_token_id
		i32 543; java_map_index
	}, 
	; 191
	%struct.TypeMapModuleEntry {
		i32 33554956, ; type_token_id
		i32 711; java_map_index
	}, 
	; 192
	%struct.TypeMapModuleEntry {
		i32 33554958, ; type_token_id
		i32 660; java_map_index
	}, 
	; 193
	%struct.TypeMapModuleEntry {
		i32 33554960, ; type_token_id
		i32 211; java_map_index
	}, 
	; 194
	%struct.TypeMapModuleEntry {
		i32 33554962, ; type_token_id
		i32 616; java_map_index
	}, 
	; 195
	%struct.TypeMapModuleEntry {
		i32 33554964, ; type_token_id
		i32 574; java_map_index
	}, 
	; 196
	%struct.TypeMapModuleEntry {
		i32 33554966, ; type_token_id
		i32 650; java_map_index
	}, 
	; 197
	%struct.TypeMapModuleEntry {
		i32 33554968, ; type_token_id
		i32 125; java_map_index
	}, 
	; 198
	%struct.TypeMapModuleEntry {
		i32 33554970, ; type_token_id
		i32 79; java_map_index
	}, 
	; 199
	%struct.TypeMapModuleEntry {
		i32 33554972, ; type_token_id
		i32 588; java_map_index
	}, 
	; 200
	%struct.TypeMapModuleEntry {
		i32 33554974, ; type_token_id
		i32 405; java_map_index
	}, 
	; 201
	%struct.TypeMapModuleEntry {
		i32 33554976, ; type_token_id
		i32 34; java_map_index
	}, 
	; 202
	%struct.TypeMapModuleEntry {
		i32 33554978, ; type_token_id
		i32 472; java_map_index
	}, 
	; 203
	%struct.TypeMapModuleEntry {
		i32 33554980, ; type_token_id
		i32 446; java_map_index
	}, 
	; 204
	%struct.TypeMapModuleEntry {
		i32 33554982, ; type_token_id
		i32 318; java_map_index
	}, 
	; 205
	%struct.TypeMapModuleEntry {
		i32 33554984, ; type_token_id
		i32 53; java_map_index
	}, 
	; 206
	%struct.TypeMapModuleEntry {
		i32 33554985, ; type_token_id
		i32 103; java_map_index
	}, 
	; 207
	%struct.TypeMapModuleEntry {
		i32 33554987, ; type_token_id
		i32 147; java_map_index
	}, 
	; 208
	%struct.TypeMapModuleEntry {
		i32 33554988, ; type_token_id
		i32 63; java_map_index
	}, 
	; 209
	%struct.TypeMapModuleEntry {
		i32 33554989, ; type_token_id
		i32 81; java_map_index
	}, 
	; 210
	%struct.TypeMapModuleEntry {
		i32 33554990, ; type_token_id
		i32 710; java_map_index
	}, 
	; 211
	%struct.TypeMapModuleEntry {
		i32 33554991, ; type_token_id
		i32 184; java_map_index
	}, 
	; 212
	%struct.TypeMapModuleEntry {
		i32 33554993, ; type_token_id
		i32 164; java_map_index
	}, 
	; 213
	%struct.TypeMapModuleEntry {
		i32 33554995, ; type_token_id
		i32 648; java_map_index
	}, 
	; 214
	%struct.TypeMapModuleEntry {
		i32 33554996, ; type_token_id
		i32 517; java_map_index
	}, 
	; 215
	%struct.TypeMapModuleEntry {
		i32 33554997, ; type_token_id
		i32 569; java_map_index
	}, 
	; 216
	%struct.TypeMapModuleEntry {
		i32 33554998, ; type_token_id
		i32 8; java_map_index
	}, 
	; 217
	%struct.TypeMapModuleEntry {
		i32 33554999, ; type_token_id
		i32 389; java_map_index
	}, 
	; 218
	%struct.TypeMapModuleEntry {
		i32 33555000, ; type_token_id
		i32 225; java_map_index
	}, 
	; 219
	%struct.TypeMapModuleEntry {
		i32 33555003, ; type_token_id
		i32 441; java_map_index
	}, 
	; 220
	%struct.TypeMapModuleEntry {
		i32 33555006, ; type_token_id
		i32 353; java_map_index
	}, 
	; 221
	%struct.TypeMapModuleEntry {
		i32 33555007, ; type_token_id
		i32 601; java_map_index
	}, 
	; 222
	%struct.TypeMapModuleEntry {
		i32 33555008, ; type_token_id
		i32 306; java_map_index
	}, 
	; 223
	%struct.TypeMapModuleEntry {
		i32 33555009, ; type_token_id
		i32 178; java_map_index
	}, 
	; 224
	%struct.TypeMapModuleEntry {
		i32 33555010, ; type_token_id
		i32 583; java_map_index
	}, 
	; 225
	%struct.TypeMapModuleEntry {
		i32 33555011, ; type_token_id
		i32 380; java_map_index
	}, 
	; 226
	%struct.TypeMapModuleEntry {
		i32 33555013, ; type_token_id
		i32 488; java_map_index
	}, 
	; 227
	%struct.TypeMapModuleEntry {
		i32 33555014, ; type_token_id
		i32 701; java_map_index
	}, 
	; 228
	%struct.TypeMapModuleEntry {
		i32 33555015, ; type_token_id
		i32 240; java_map_index
	}, 
	; 229
	%struct.TypeMapModuleEntry {
		i32 33555017, ; type_token_id
		i32 210; java_map_index
	}, 
	; 230
	%struct.TypeMapModuleEntry {
		i32 33555018, ; type_token_id
		i32 39; java_map_index
	}, 
	; 231
	%struct.TypeMapModuleEntry {
		i32 33555019, ; type_token_id
		i32 739; java_map_index
	}, 
	; 232
	%struct.TypeMapModuleEntry {
		i32 33555020, ; type_token_id
		i32 631; java_map_index
	}, 
	; 233
	%struct.TypeMapModuleEntry {
		i32 33555022, ; type_token_id
		i32 608; java_map_index
	}, 
	; 234
	%struct.TypeMapModuleEntry {
		i32 33555025, ; type_token_id
		i32 603; java_map_index
	}, 
	; 235
	%struct.TypeMapModuleEntry {
		i32 33555027, ; type_token_id
		i32 436; java_map_index
	}, 
	; 236
	%struct.TypeMapModuleEntry {
		i32 33555029, ; type_token_id
		i32 458; java_map_index
	}, 
	; 237
	%struct.TypeMapModuleEntry {
		i32 33555031, ; type_token_id
		i32 326; java_map_index
	}, 
	; 238
	%struct.TypeMapModuleEntry {
		i32 33555032, ; type_token_id
		i32 502; java_map_index
	}, 
	; 239
	%struct.TypeMapModuleEntry {
		i32 33555033, ; type_token_id
		i32 497; java_map_index
	}, 
	; 240
	%struct.TypeMapModuleEntry {
		i32 33555034, ; type_token_id
		i32 514; java_map_index
	}, 
	; 241
	%struct.TypeMapModuleEntry {
		i32 33555035, ; type_token_id
		i32 338; java_map_index
	}, 
	; 242
	%struct.TypeMapModuleEntry {
		i32 33555037, ; type_token_id
		i32 399; java_map_index
	}, 
	; 243
	%struct.TypeMapModuleEntry {
		i32 33555038, ; type_token_id
		i32 413; java_map_index
	}, 
	; 244
	%struct.TypeMapModuleEntry {
		i32 33555039, ; type_token_id
		i32 394; java_map_index
	}, 
	; 245
	%struct.TypeMapModuleEntry {
		i32 33555040, ; type_token_id
		i32 401; java_map_index
	}, 
	; 246
	%struct.TypeMapModuleEntry {
		i32 33555041, ; type_token_id
		i32 505; java_map_index
	}, 
	; 247
	%struct.TypeMapModuleEntry {
		i32 33555043, ; type_token_id
		i32 582; java_map_index
	}, 
	; 248
	%struct.TypeMapModuleEntry {
		i32 33555044, ; type_token_id
		i32 702; java_map_index
	}, 
	; 249
	%struct.TypeMapModuleEntry {
		i32 33555045, ; type_token_id
		i32 561; java_map_index
	}, 
	; 250
	%struct.TypeMapModuleEntry {
		i32 33555046, ; type_token_id
		i32 395; java_map_index
	}, 
	; 251
	%struct.TypeMapModuleEntry {
		i32 33555047, ; type_token_id
		i32 428; java_map_index
	}, 
	; 252
	%struct.TypeMapModuleEntry {
		i32 33555048, ; type_token_id
		i32 3; java_map_index
	}, 
	; 253
	%struct.TypeMapModuleEntry {
		i32 33555050, ; type_token_id
		i32 693; java_map_index
	}, 
	; 254
	%struct.TypeMapModuleEntry {
		i32 33555052, ; type_token_id
		i32 193; java_map_index
	}, 
	; 255
	%struct.TypeMapModuleEntry {
		i32 33555054, ; type_token_id
		i32 384; java_map_index
	}, 
	; 256
	%struct.TypeMapModuleEntry {
		i32 33555055, ; type_token_id
		i32 461; java_map_index
	}, 
	; 257
	%struct.TypeMapModuleEntry {
		i32 33555056, ; type_token_id
		i32 612; java_map_index
	}, 
	; 258
	%struct.TypeMapModuleEntry {
		i32 33555057, ; type_token_id
		i32 424; java_map_index
	}, 
	; 259
	%struct.TypeMapModuleEntry {
		i32 33555058, ; type_token_id
		i32 54; java_map_index
	}, 
	; 260
	%struct.TypeMapModuleEntry {
		i32 33555059, ; type_token_id
		i32 572; java_map_index
	}, 
	; 261
	%struct.TypeMapModuleEntry {
		i32 33555061, ; type_token_id
		i32 292; java_map_index
	}, 
	; 262
	%struct.TypeMapModuleEntry {
		i32 33555063, ; type_token_id
		i32 30; java_map_index
	}, 
	; 263
	%struct.TypeMapModuleEntry {
		i32 33555065, ; type_token_id
		i32 666; java_map_index
	}, 
	; 264
	%struct.TypeMapModuleEntry {
		i32 33555067, ; type_token_id
		i32 209; java_map_index
	}, 
	; 265
	%struct.TypeMapModuleEntry {
		i32 33555069, ; type_token_id
		i32 742; java_map_index
	}, 
	; 266
	%struct.TypeMapModuleEntry {
		i32 33555070, ; type_token_id
		i32 109; java_map_index
	}, 
	; 267
	%struct.TypeMapModuleEntry {
		i32 33555071, ; type_token_id
		i32 294; java_map_index
	}, 
	; 268
	%struct.TypeMapModuleEntry {
		i32 33555072, ; type_token_id
		i32 57; java_map_index
	}, 
	; 269
	%struct.TypeMapModuleEntry {
		i32 33555073, ; type_token_id
		i32 33; java_map_index
	}, 
	; 270
	%struct.TypeMapModuleEntry {
		i32 33555074, ; type_token_id
		i32 712; java_map_index
	}, 
	; 271
	%struct.TypeMapModuleEntry {
		i32 33555076, ; type_token_id
		i32 509; java_map_index
	}, 
	; 272
	%struct.TypeMapModuleEntry {
		i32 33555078, ; type_token_id
		i32 289; java_map_index
	}, 
	; 273
	%struct.TypeMapModuleEntry {
		i32 33555080, ; type_token_id
		i32 97; java_map_index
	}, 
	; 274
	%struct.TypeMapModuleEntry {
		i32 33555082, ; type_token_id
		i32 304; java_map_index
	}, 
	; 275
	%struct.TypeMapModuleEntry {
		i32 33555083, ; type_token_id
		i32 78; java_map_index
	}, 
	; 276
	%struct.TypeMapModuleEntry {
		i32 33555084, ; type_token_id
		i32 398; java_map_index
	}, 
	; 277
	%struct.TypeMapModuleEntry {
		i32 33555086, ; type_token_id
		i32 686; java_map_index
	}, 
	; 278
	%struct.TypeMapModuleEntry {
		i32 33555088, ; type_token_id
		i32 133; java_map_index
	}, 
	; 279
	%struct.TypeMapModuleEntry {
		i32 33555089, ; type_token_id
		i32 559; java_map_index
	}, 
	; 280
	%struct.TypeMapModuleEntry {
		i32 33555090, ; type_token_id
		i32 629; java_map_index
	}, 
	; 281
	%struct.TypeMapModuleEntry {
		i32 33555115, ; type_token_id
		i32 537; java_map_index
	}
], align 4; end of 'module7_managed_to_java' array


; module7_managed_to_java_duplicates
@module7_managed_to_java_duplicates = internal constant [147 x %struct.TypeMapModuleEntry] [
	; 0
	%struct.TypeMapModuleEntry {
		i32 33554563, ; type_token_id
		i32 166; java_map_index
	}, 
	; 1
	%struct.TypeMapModuleEntry {
		i32 33554565, ; type_token_id
		i32 239; java_map_index
	}, 
	; 2
	%struct.TypeMapModuleEntry {
		i32 33554568, ; type_token_id
		i32 194; java_map_index
	}, 
	; 3
	%struct.TypeMapModuleEntry {
		i32 33554570, ; type_token_id
		i32 24; java_map_index
	}, 
	; 4
	%struct.TypeMapModuleEntry {
		i32 33554572, ; type_token_id
		i32 618; java_map_index
	}, 
	; 5
	%struct.TypeMapModuleEntry {
		i32 33554574, ; type_token_id
		i32 364; java_map_index
	}, 
	; 6
	%struct.TypeMapModuleEntry {
		i32 33554576, ; type_token_id
		i32 271; java_map_index
	}, 
	; 7
	%struct.TypeMapModuleEntry {
		i32 33554578, ; type_token_id
		i32 640; java_map_index
	}, 
	; 8
	%struct.TypeMapModuleEntry {
		i32 33554580, ; type_token_id
		i32 647; java_map_index
	}, 
	; 9
	%struct.TypeMapModuleEntry {
		i32 33554582, ; type_token_id
		i32 421; java_map_index
	}, 
	; 10
	%struct.TypeMapModuleEntry {
		i32 33554586, ; type_token_id
		i32 732; java_map_index
	}, 
	; 11
	%struct.TypeMapModuleEntry {
		i32 33554598, ; type_token_id
		i32 186; java_map_index
	}, 
	; 12
	%struct.TypeMapModuleEntry {
		i32 33554600, ; type_token_id
		i32 431; java_map_index
	}, 
	; 13
	%struct.TypeMapModuleEntry {
		i32 33554603, ; type_token_id
		i32 621; java_map_index
	}, 
	; 14
	%struct.TypeMapModuleEntry {
		i32 33554604, ; type_token_id
		i32 135; java_map_index
	}, 
	; 15
	%struct.TypeMapModuleEntry {
		i32 33554610, ; type_token_id
		i32 237; java_map_index
	}, 
	; 16
	%struct.TypeMapModuleEntry {
		i32 33554612, ; type_token_id
		i32 162; java_map_index
	}, 
	; 17
	%struct.TypeMapModuleEntry {
		i32 33554618, ; type_token_id
		i32 189; java_map_index
	}, 
	; 18
	%struct.TypeMapModuleEntry {
		i32 33554619, ; type_token_id
		i32 248; java_map_index
	}, 
	; 19
	%struct.TypeMapModuleEntry {
		i32 33554621, ; type_token_id
		i32 21; java_map_index
	}, 
	; 20
	%struct.TypeMapModuleEntry {
		i32 33554626, ; type_token_id
		i32 315; java_map_index
	}, 
	; 21
	%struct.TypeMapModuleEntry {
		i32 33554628, ; type_token_id
		i32 198; java_map_index
	}, 
	; 22
	%struct.TypeMapModuleEntry {
		i32 33554630, ; type_token_id
		i32 192; java_map_index
	}, 
	; 23
	%struct.TypeMapModuleEntry {
		i32 33554632, ; type_token_id
		i32 342; java_map_index
	}, 
	; 24
	%struct.TypeMapModuleEntry {
		i32 33554634, ; type_token_id
		i32 149; java_map_index
	}, 
	; 25
	%struct.TypeMapModuleEntry {
		i32 33554636, ; type_token_id
		i32 124; java_map_index
	}, 
	; 26
	%struct.TypeMapModuleEntry {
		i32 33554638, ; type_token_id
		i32 95; java_map_index
	}, 
	; 27
	%struct.TypeMapModuleEntry {
		i32 33554640, ; type_token_id
		i32 108; java_map_index
	}, 
	; 28
	%struct.TypeMapModuleEntry {
		i32 33554642, ; type_token_id
		i32 160; java_map_index
	}, 
	; 29
	%struct.TypeMapModuleEntry {
		i32 33554644, ; type_token_id
		i32 104; java_map_index
	}, 
	; 30
	%struct.TypeMapModuleEntry {
		i32 33554646, ; type_token_id
		i32 536; java_map_index
	}, 
	; 31
	%struct.TypeMapModuleEntry {
		i32 33554648, ; type_token_id
		i32 593; java_map_index
	}, 
	; 32
	%struct.TypeMapModuleEntry {
		i32 33554651, ; type_token_id
		i32 422; java_map_index
	}, 
	; 33
	%struct.TypeMapModuleEntry {
		i32 33554655, ; type_token_id
		i32 520; java_map_index
	}, 
	; 34
	%struct.TypeMapModuleEntry {
		i32 33554658, ; type_token_id
		i32 190; java_map_index
	}, 
	; 35
	%struct.TypeMapModuleEntry {
		i32 33554660, ; type_token_id
		i32 348; java_map_index
	}, 
	; 36
	%struct.TypeMapModuleEntry {
		i32 33554661, ; type_token_id
		i32 354; java_map_index
	}, 
	; 37
	%struct.TypeMapModuleEntry {
		i32 33554668, ; type_token_id
		i32 568; java_map_index
	}, 
	; 38
	%struct.TypeMapModuleEntry {
		i32 33554671, ; type_token_id
		i32 343; java_map_index
	}, 
	; 39
	%struct.TypeMapModuleEntry {
		i32 33554678, ; type_token_id
		i32 675; java_map_index
	}, 
	; 40
	%struct.TypeMapModuleEntry {
		i32 33554682, ; type_token_id
		i32 51; java_map_index
	}, 
	; 41
	%struct.TypeMapModuleEntry {
		i32 33554685, ; type_token_id
		i32 273; java_map_index
	}, 
	; 42
	%struct.TypeMapModuleEntry {
		i32 33554686, ; type_token_id
		i32 115; java_map_index
	}, 
	; 43
	%struct.TypeMapModuleEntry {
		i32 33554700, ; type_token_id
		i32 451; java_map_index
	}, 
	; 44
	%struct.TypeMapModuleEntry {
		i32 33554702, ; type_token_id
		i32 169; java_map_index
	}, 
	; 45
	%struct.TypeMapModuleEntry {
		i32 33554706, ; type_token_id
		i32 515; java_map_index
	}, 
	; 46
	%struct.TypeMapModuleEntry {
		i32 33554713, ; type_token_id
		i32 563; java_map_index
	}, 
	; 47
	%struct.TypeMapModuleEntry {
		i32 33554717, ; type_token_id
		i32 48; java_map_index
	}, 
	; 48
	%struct.TypeMapModuleEntry {
		i32 33554724, ; type_token_id
		i32 373; java_map_index
	}, 
	; 49
	%struct.TypeMapModuleEntry {
		i32 33554726, ; type_token_id
		i32 329; java_map_index
	}, 
	; 50
	%struct.TypeMapModuleEntry {
		i32 33554728, ; type_token_id
		i32 175; java_map_index
	}, 
	; 51
	%struct.TypeMapModuleEntry {
		i32 33554730, ; type_token_id
		i32 139; java_map_index
	}, 
	; 52
	%struct.TypeMapModuleEntry {
		i32 33554732, ; type_token_id
		i32 286; java_map_index
	}, 
	; 53
	%struct.TypeMapModuleEntry {
		i32 33554741, ; type_token_id
		i32 179; java_map_index
	}, 
	; 54
	%struct.TypeMapModuleEntry {
		i32 33554744, ; type_token_id
		i32 28; java_map_index
	}, 
	; 55
	%struct.TypeMapModuleEntry {
		i32 33554765, ; type_token_id
		i32 613; java_map_index
	}, 
	; 56
	%struct.TypeMapModuleEntry {
		i32 33554766, ; type_token_id
		i32 372; java_map_index
	}, 
	; 57
	%struct.TypeMapModuleEntry {
		i32 33554768, ; type_token_id
		i32 432; java_map_index
	}, 
	; 58
	%struct.TypeMapModuleEntry {
		i32 33554771, ; type_token_id
		i32 218; java_map_index
	}, 
	; 59
	%struct.TypeMapModuleEntry {
		i32 33554773, ; type_token_id
		i32 90; java_map_index
	}, 
	; 60
	%struct.TypeMapModuleEntry {
		i32 33554774, ; type_token_id
		i32 486; java_map_index
	}, 
	; 61
	%struct.TypeMapModuleEntry {
		i32 33554776, ; type_token_id
		i32 56; java_map_index
	}, 
	; 62
	%struct.TypeMapModuleEntry {
		i32 33554778, ; type_token_id
		i32 29; java_map_index
	}, 
	; 63
	%struct.TypeMapModuleEntry {
		i32 33554783, ; type_token_id
		i32 249; java_map_index
	}, 
	; 64
	%struct.TypeMapModuleEntry {
		i32 33554791, ; type_token_id
		i32 181; java_map_index
	}, 
	; 65
	%struct.TypeMapModuleEntry {
		i32 33554794, ; type_token_id
		i32 487; java_map_index
	}, 
	; 66
	%struct.TypeMapModuleEntry {
		i32 33554797, ; type_token_id
		i32 493; java_map_index
	}, 
	; 67
	%struct.TypeMapModuleEntry {
		i32 33554799, ; type_token_id
		i32 65; java_map_index
	}, 
	; 68
	%struct.TypeMapModuleEntry {
		i32 33554801, ; type_token_id
		i32 554; java_map_index
	}, 
	; 69
	%struct.TypeMapModuleEntry {
		i32 33554803, ; type_token_id
		i32 661; java_map_index
	}, 
	; 70
	%struct.TypeMapModuleEntry {
		i32 33554805, ; type_token_id
		i32 136; java_map_index
	}, 
	; 71
	%struct.TypeMapModuleEntry {
		i32 33554809, ; type_token_id
		i32 658; java_map_index
	}, 
	; 72
	%struct.TypeMapModuleEntry {
		i32 33554811, ; type_token_id
		i32 677; java_map_index
	}, 
	; 73
	%struct.TypeMapModuleEntry {
		i32 33554813, ; type_token_id
		i32 731; java_map_index
	}, 
	; 74
	%struct.TypeMapModuleEntry {
		i32 33554815, ; type_token_id
		i32 591; java_map_index
	}, 
	; 75
	%struct.TypeMapModuleEntry {
		i32 33554823, ; type_token_id
		i32 146; java_map_index
	}, 
	; 76
	%struct.TypeMapModuleEntry {
		i32 33554853, ; type_token_id
		i32 740; java_map_index
	}, 
	; 77
	%struct.TypeMapModuleEntry {
		i32 33554859, ; type_token_id
		i32 311; java_map_index
	}, 
	; 78
	%struct.TypeMapModuleEntry {
		i32 33554864, ; type_token_id
		i32 469; java_map_index
	}, 
	; 79
	%struct.TypeMapModuleEntry {
		i32 33554869, ; type_token_id
		i32 50; java_map_index
	}, 
	; 80
	%struct.TypeMapModuleEntry {
		i32 33554895, ; type_token_id
		i32 653; java_map_index
	}, 
	; 81
	%struct.TypeMapModuleEntry {
		i32 33554897, ; type_token_id
		i32 715; java_map_index
	}, 
	; 82
	%struct.TypeMapModuleEntry {
		i32 33554901, ; type_token_id
		i32 439; java_map_index
	}, 
	; 83
	%struct.TypeMapModuleEntry {
		i32 33554902, ; type_token_id
		i32 740; java_map_index
	}, 
	; 84
	%struct.TypeMapModuleEntry {
		i32 33554903, ; type_token_id
		i32 740; java_map_index
	}, 
	; 85
	%struct.TypeMapModuleEntry {
		i32 33554905, ; type_token_id
		i32 452; java_map_index
	}, 
	; 86
	%struct.TypeMapModuleEntry {
		i32 33554907, ; type_token_id
		i32 700; java_map_index
	}, 
	; 87
	%struct.TypeMapModuleEntry {
		i32 33554909, ; type_token_id
		i32 61; java_map_index
	}, 
	; 88
	%struct.TypeMapModuleEntry {
		i32 33554911, ; type_token_id
		i32 741; java_map_index
	}, 
	; 89
	%struct.TypeMapModuleEntry {
		i32 33554913, ; type_token_id
		i32 598; java_map_index
	}, 
	; 90
	%struct.TypeMapModuleEntry {
		i32 33554918, ; type_token_id
		i32 231; java_map_index
	}, 
	; 91
	%struct.TypeMapModuleEntry {
		i32 33554921, ; type_token_id
		i32 47; java_map_index
	}, 
	; 92
	%struct.TypeMapModuleEntry {
		i32 33554923, ; type_token_id
		i32 321; java_map_index
	}, 
	; 93
	%struct.TypeMapModuleEntry {
		i32 33554925, ; type_token_id
		i32 456; java_map_index
	}, 
	; 94
	%struct.TypeMapModuleEntry {
		i32 33554927, ; type_token_id
		i32 669; java_map_index
	}, 
	; 95
	%struct.TypeMapModuleEntry {
		i32 33554929, ; type_token_id
		i32 567; java_map_index
	}, 
	; 96
	%struct.TypeMapModuleEntry {
		i32 33554931, ; type_token_id
		i32 628; java_map_index
	}, 
	; 97
	%struct.TypeMapModuleEntry {
		i32 33554933, ; type_token_id
		i32 522; java_map_index
	}, 
	; 98
	%struct.TypeMapModuleEntry {
		i32 33554935, ; type_token_id
		i32 5; java_map_index
	}, 
	; 99
	%struct.TypeMapModuleEntry {
		i32 33554937, ; type_token_id
		i32 475; java_map_index
	}, 
	; 100
	%struct.TypeMapModuleEntry {
		i32 33554939, ; type_token_id
		i32 381; java_map_index
	}, 
	; 101
	%struct.TypeMapModuleEntry {
		i32 33554942, ; type_token_id
		i32 368; java_map_index
	}, 
	; 102
	%struct.TypeMapModuleEntry {
		i32 33554945, ; type_token_id
		i32 641; java_map_index
	}, 
	; 103
	%struct.TypeMapModuleEntry {
		i32 33554947, ; type_token_id
		i32 180; java_map_index
	}, 
	; 104
	%struct.TypeMapModuleEntry {
		i32 33554950, ; type_token_id
		i32 471; java_map_index
	}, 
	; 105
	%struct.TypeMapModuleEntry {
		i32 33554953, ; type_token_id
		i32 506; java_map_index
	}, 
	; 106
	%struct.TypeMapModuleEntry {
		i32 33554955, ; type_token_id
		i32 543; java_map_index
	}, 
	; 107
	%struct.TypeMapModuleEntry {
		i32 33554957, ; type_token_id
		i32 711; java_map_index
	}, 
	; 108
	%struct.TypeMapModuleEntry {
		i32 33554959, ; type_token_id
		i32 660; java_map_index
	}, 
	; 109
	%struct.TypeMapModuleEntry {
		i32 33554961, ; type_token_id
		i32 211; java_map_index
	}, 
	; 110
	%struct.TypeMapModuleEntry {
		i32 33554963, ; type_token_id
		i32 616; java_map_index
	}, 
	; 111
	%struct.TypeMapModuleEntry {
		i32 33554965, ; type_token_id
		i32 574; java_map_index
	}, 
	; 112
	%struct.TypeMapModuleEntry {
		i32 33554967, ; type_token_id
		i32 650; java_map_index
	}, 
	; 113
	%struct.TypeMapModuleEntry {
		i32 33554969, ; type_token_id
		i32 125; java_map_index
	}, 
	; 114
	%struct.TypeMapModuleEntry {
		i32 33554971, ; type_token_id
		i32 79; java_map_index
	}, 
	; 115
	%struct.TypeMapModuleEntry {
		i32 33554973, ; type_token_id
		i32 588; java_map_index
	}, 
	; 116
	%struct.TypeMapModuleEntry {
		i32 33554975, ; type_token_id
		i32 405; java_map_index
	}, 
	; 117
	%struct.TypeMapModuleEntry {
		i32 33554977, ; type_token_id
		i32 34; java_map_index
	}, 
	; 118
	%struct.TypeMapModuleEntry {
		i32 33554979, ; type_token_id
		i32 472; java_map_index
	}, 
	; 119
	%struct.TypeMapModuleEntry {
		i32 33554981, ; type_token_id
		i32 446; java_map_index
	}, 
	; 120
	%struct.TypeMapModuleEntry {
		i32 33554983, ; type_token_id
		i32 318; java_map_index
	}, 
	; 121
	%struct.TypeMapModuleEntry {
		i32 33554986, ; type_token_id
		i32 103; java_map_index
	}, 
	; 122
	%struct.TypeMapModuleEntry {
		i32 33554992, ; type_token_id
		i32 184; java_map_index
	}, 
	; 123
	%struct.TypeMapModuleEntry {
		i32 33554994, ; type_token_id
		i32 164; java_map_index
	}, 
	; 124
	%struct.TypeMapModuleEntry {
		i32 33555001, ; type_token_id
		i32 225; java_map_index
	}, 
	; 125
	%struct.TypeMapModuleEntry {
		i32 33555005, ; type_token_id
		i32 441; java_map_index
	}, 
	; 126
	%struct.TypeMapModuleEntry {
		i32 33555012, ; type_token_id
		i32 380; java_map_index
	}, 
	; 127
	%struct.TypeMapModuleEntry {
		i32 33555016, ; type_token_id
		i32 240; java_map_index
	}, 
	; 128
	%struct.TypeMapModuleEntry {
		i32 33555021, ; type_token_id
		i32 631; java_map_index
	}, 
	; 129
	%struct.TypeMapModuleEntry {
		i32 33555023, ; type_token_id
		i32 608; java_map_index
	}, 
	; 130
	%struct.TypeMapModuleEntry {
		i32 33555026, ; type_token_id
		i32 603; java_map_index
	}, 
	; 131
	%struct.TypeMapModuleEntry {
		i32 33555028, ; type_token_id
		i32 436; java_map_index
	}, 
	; 132
	%struct.TypeMapModuleEntry {
		i32 33555030, ; type_token_id
		i32 458; java_map_index
	}, 
	; 133
	%struct.TypeMapModuleEntry {
		i32 33555036, ; type_token_id
		i32 338; java_map_index
	}, 
	; 134
	%struct.TypeMapModuleEntry {
		i32 33555042, ; type_token_id
		i32 505; java_map_index
	}, 
	; 135
	%struct.TypeMapModuleEntry {
		i32 33555060, ; type_token_id
		i32 572; java_map_index
	}, 
	; 136
	%struct.TypeMapModuleEntry {
		i32 33555062, ; type_token_id
		i32 292; java_map_index
	}, 
	; 137
	%struct.TypeMapModuleEntry {
		i32 33555064, ; type_token_id
		i32 30; java_map_index
	}, 
	; 138
	%struct.TypeMapModuleEntry {
		i32 33555066, ; type_token_id
		i32 666; java_map_index
	}, 
	; 139
	%struct.TypeMapModuleEntry {
		i32 33555068, ; type_token_id
		i32 209; java_map_index
	}, 
	; 140
	%struct.TypeMapModuleEntry {
		i32 33555075, ; type_token_id
		i32 712; java_map_index
	}, 
	; 141
	%struct.TypeMapModuleEntry {
		i32 33555077, ; type_token_id
		i32 509; java_map_index
	}, 
	; 142
	%struct.TypeMapModuleEntry {
		i32 33555079, ; type_token_id
		i32 289; java_map_index
	}, 
	; 143
	%struct.TypeMapModuleEntry {
		i32 33555081, ; type_token_id
		i32 97; java_map_index
	}, 
	; 144
	%struct.TypeMapModuleEntry {
		i32 33555085, ; type_token_id
		i32 398; java_map_index
	}, 
	; 145
	%struct.TypeMapModuleEntry {
		i32 33555087, ; type_token_id
		i32 686; java_map_index
	}, 
	; 146
	%struct.TypeMapModuleEntry {
		i32 33555091, ; type_token_id
		i32 629; java_map_index
	}
], align 4; end of 'module7_managed_to_java_duplicates' array


; module8_managed_to_java
@module8_managed_to_java = internal constant [1 x %struct.TypeMapModuleEntry] [
	; 0
	%struct.TypeMapModuleEntry {
		i32 33554434, ; type_token_id
		i32 483; java_map_index
	}
], align 4; end of 'module8_managed_to_java' array


; module9_managed_to_java
@module9_managed_to_java = internal constant [1 x %struct.TypeMapModuleEntry] [
	; 0
	%struct.TypeMapModuleEntry {
		i32 33554434, ; type_token_id
		i32 655; java_map_index
	}
], align 4; end of 'module9_managed_to_java' array


; module10_managed_to_java
@module10_managed_to_java = internal constant [2 x %struct.TypeMapModuleEntry] [
	; 0
	%struct.TypeMapModuleEntry {
		i32 33554439, ; type_token_id
		i32 684; java_map_index
	}, 
	; 1
	%struct.TypeMapModuleEntry {
		i32 33554441, ; type_token_id
		i32 131; java_map_index
	}
], align 4; end of 'module10_managed_to_java' array


; module10_managed_to_java_duplicates
@module10_managed_to_java_duplicates = internal constant [2 x %struct.TypeMapModuleEntry] [
	; 0
	%struct.TypeMapModuleEntry {
		i32 33554440, ; type_token_id
		i32 684; java_map_index
	}, 
	; 1
	%struct.TypeMapModuleEntry {
		i32 33554442, ; type_token_id
		i32 131; java_map_index
	}
], align 4; end of 'module10_managed_to_java_duplicates' array


; module11_managed_to_java
@module11_managed_to_java = internal constant [1 x %struct.TypeMapModuleEntry] [
	; 0
	%struct.TypeMapModuleEntry {
		i32 33554436, ; type_token_id
		i32 596; java_map_index
	}
], align 4; end of 'module11_managed_to_java' array


; module11_managed_to_java_duplicates
@module11_managed_to_java_duplicates = internal constant [1 x %struct.TypeMapModuleEntry] [
	; 0
	%struct.TypeMapModuleEntry {
		i32 33554437, ; type_token_id
		i32 596; java_map_index
	}
], align 4; end of 'module11_managed_to_java_duplicates' array


; module12_managed_to_java
@module12_managed_to_java = internal constant [30 x %struct.TypeMapModuleEntry] [
	; 0
	%struct.TypeMapModuleEntry {
		i32 33554473, ; type_token_id
		i32 714; java_map_index
	}, 
	; 1
	%struct.TypeMapModuleEntry {
		i32 33554474, ; type_token_id
		i32 142; java_map_index
	}, 
	; 2
	%struct.TypeMapModuleEntry {
		i32 33554475, ; type_token_id
		i32 201; java_map_index
	}, 
	; 3
	%struct.TypeMapModuleEntry {
		i32 33554476, ; type_token_id
		i32 448; java_map_index
	}, 
	; 4
	%struct.TypeMapModuleEntry {
		i32 33554479, ; type_token_id
		i32 463; java_map_index
	}, 
	; 5
	%struct.TypeMapModuleEntry {
		i32 33554480, ; type_token_id
		i32 465; java_map_index
	}, 
	; 6
	%struct.TypeMapModuleEntry {
		i32 33554482, ; type_token_id
		i32 575; java_map_index
	}, 
	; 7
	%struct.TypeMapModuleEntry {
		i32 33554484, ; type_token_id
		i32 77; java_map_index
	}, 
	; 8
	%struct.TypeMapModuleEntry {
		i32 33554489, ; type_token_id
		i32 369; java_map_index
	}, 
	; 9
	%struct.TypeMapModuleEntry {
		i32 33554490, ; type_token_id
		i32 429; java_map_index
	}, 
	; 10
	%struct.TypeMapModuleEntry {
		i32 33554492, ; type_token_id
		i32 172; java_map_index
	}, 
	; 11
	%struct.TypeMapModuleEntry {
		i32 33554494, ; type_token_id
		i32 279; java_map_index
	}, 
	; 12
	%struct.TypeMapModuleEntry {
		i32 33554495, ; type_token_id
		i32 516; java_map_index
	}, 
	; 13
	%struct.TypeMapModuleEntry {
		i32 33554497, ; type_token_id
		i32 553; java_map_index
	}, 
	; 14
	%struct.TypeMapModuleEntry {
		i32 33554499, ; type_token_id
		i32 132; java_map_index
	}, 
	; 15
	%struct.TypeMapModuleEntry {
		i32 33554500, ; type_token_id
		i32 474; java_map_index
	}, 
	; 16
	%struct.TypeMapModuleEntry {
		i32 33554502, ; type_token_id
		i32 485; java_map_index
	}, 
	; 17
	%struct.TypeMapModuleEntry {
		i32 33554505, ; type_token_id
		i32 477; java_map_index
	}, 
	; 18
	%struct.TypeMapModuleEntry {
		i32 33554508, ; type_token_id
		i32 150; java_map_index
	}, 
	; 19
	%struct.TypeMapModuleEntry {
		i32 33554510, ; type_token_id
		i32 634; java_map_index
	}, 
	; 20
	%struct.TypeMapModuleEntry {
		i32 33554511, ; type_token_id
		i32 314; java_map_index
	}, 
	; 21
	%struct.TypeMapModuleEntry {
		i32 33554512, ; type_token_id
		i32 196; java_map_index
	}, 
	; 22
	%struct.TypeMapModuleEntry {
		i32 33554513, ; type_token_id
		i32 266; java_map_index
	}, 
	; 23
	%struct.TypeMapModuleEntry {
		i32 33554516, ; type_token_id
		i32 317; java_map_index
	}, 
	; 24
	%struct.TypeMapModuleEntry {
		i32 33554517, ; type_token_id
		i32 10; java_map_index
	}, 
	; 25
	%struct.TypeMapModuleEntry {
		i32 33554519, ; type_token_id
		i32 213; java_map_index
	}, 
	; 26
	%struct.TypeMapModuleEntry {
		i32 33554521, ; type_token_id
		i32 539; java_map_index
	}, 
	; 27
	%struct.TypeMapModuleEntry {
		i32 33554523, ; type_token_id
		i32 59; java_map_index
	}, 
	; 28
	%struct.TypeMapModuleEntry {
		i32 33554525, ; type_token_id
		i32 350; java_map_index
	}, 
	; 29
	%struct.TypeMapModuleEntry {
		i32 33554526, ; type_token_id
		i32 134; java_map_index
	}
], align 4; end of 'module12_managed_to_java' array


; module12_managed_to_java_duplicates
@module12_managed_to_java_duplicates = internal constant [17 x %struct.TypeMapModuleEntry] [
	; 0
	%struct.TypeMapModuleEntry {
		i32 33554477, ; type_token_id
		i32 448; java_map_index
	}, 
	; 1
	%struct.TypeMapModuleEntry {
		i32 33554481, ; type_token_id
		i32 465; java_map_index
	}, 
	; 2
	%struct.TypeMapModuleEntry {
		i32 33554483, ; type_token_id
		i32 575; java_map_index
	}, 
	; 3
	%struct.TypeMapModuleEntry {
		i32 33554485, ; type_token_id
		i32 77; java_map_index
	}, 
	; 4
	%struct.TypeMapModuleEntry {
		i32 33554488, ; type_token_id
		i32 142; java_map_index
	}, 
	; 5
	%struct.TypeMapModuleEntry {
		i32 33554491, ; type_token_id
		i32 429; java_map_index
	}, 
	; 6
	%struct.TypeMapModuleEntry {
		i32 33554493, ; type_token_id
		i32 172; java_map_index
	}, 
	; 7
	%struct.TypeMapModuleEntry {
		i32 33554496, ; type_token_id
		i32 516; java_map_index
	}, 
	; 8
	%struct.TypeMapModuleEntry {
		i32 33554498, ; type_token_id
		i32 553; java_map_index
	}, 
	; 9
	%struct.TypeMapModuleEntry {
		i32 33554503, ; type_token_id
		i32 485; java_map_index
	}, 
	; 10
	%struct.TypeMapModuleEntry {
		i32 33554509, ; type_token_id
		i32 150; java_map_index
	}, 
	; 11
	%struct.TypeMapModuleEntry {
		i32 33554514, ; type_token_id
		i32 266; java_map_index
	}, 
	; 12
	%struct.TypeMapModuleEntry {
		i32 33554515, ; type_token_id
		i32 196; java_map_index
	}, 
	; 13
	%struct.TypeMapModuleEntry {
		i32 33554518, ; type_token_id
		i32 10; java_map_index
	}, 
	; 14
	%struct.TypeMapModuleEntry {
		i32 33554520, ; type_token_id
		i32 213; java_map_index
	}, 
	; 15
	%struct.TypeMapModuleEntry {
		i32 33554522, ; type_token_id
		i32 539; java_map_index
	}, 
	; 16
	%struct.TypeMapModuleEntry {
		i32 33554524, ; type_token_id
		i32 59; java_map_index
	}
], align 4; end of 'module12_managed_to_java_duplicates' array


; module13_managed_to_java
@module13_managed_to_java = internal constant [369 x %struct.TypeMapModuleEntry] [
	; 0
	%struct.TypeMapModuleEntry {
		i32 33554555, ; type_token_id
		i32 35; java_map_index
	}, 
	; 1
	%struct.TypeMapModuleEntry {
		i32 33554556, ; type_token_id
		i32 415; java_map_index
	}, 
	; 2
	%struct.TypeMapModuleEntry {
		i32 33554558, ; type_token_id
		i32 391; java_map_index
	}, 
	; 3
	%struct.TypeMapModuleEntry {
		i32 33554559, ; type_token_id
		i32 18; java_map_index
	}, 
	; 4
	%struct.TypeMapModuleEntry {
		i32 33554560, ; type_token_id
		i32 508; java_map_index
	}, 
	; 5
	%struct.TypeMapModuleEntry {
		i32 33554561, ; type_token_id
		i32 334; java_map_index
	}, 
	; 6
	%struct.TypeMapModuleEntry {
		i32 33554565, ; type_token_id
		i32 645; java_map_index
	}, 
	; 7
	%struct.TypeMapModuleEntry {
		i32 33554566, ; type_token_id
		i32 627; java_map_index
	}, 
	; 8
	%struct.TypeMapModuleEntry {
		i32 33554567, ; type_token_id
		i32 158; java_map_index
	}, 
	; 9
	%struct.TypeMapModuleEntry {
		i32 33554568, ; type_token_id
		i32 272; java_map_index
	}, 
	; 10
	%struct.TypeMapModuleEntry {
		i32 33554569, ; type_token_id
		i32 129; java_map_index
	}, 
	; 11
	%struct.TypeMapModuleEntry {
		i32 33554572, ; type_token_id
		i32 320; java_map_index
	}, 
	; 12
	%struct.TypeMapModuleEntry {
		i32 33554573, ; type_token_id
		i32 535; java_map_index
	}, 
	; 13
	%struct.TypeMapModuleEntry {
		i32 33554575, ; type_token_id
		i32 359; java_map_index
	}, 
	; 14
	%struct.TypeMapModuleEntry {
		i32 33554579, ; type_token_id
		i32 113; java_map_index
	}, 
	; 15
	%struct.TypeMapModuleEntry {
		i32 33554580, ; type_token_id
		i32 491; java_map_index
	}, 
	; 16
	%struct.TypeMapModuleEntry {
		i32 33554581, ; type_token_id
		i32 435; java_map_index
	}, 
	; 17
	%struct.TypeMapModuleEntry {
		i32 33554583, ; type_token_id
		i32 644; java_map_index
	}, 
	; 18
	%struct.TypeMapModuleEntry {
		i32 33554584, ; type_token_id
		i32 490; java_map_index
	}, 
	; 19
	%struct.TypeMapModuleEntry {
		i32 33554585, ; type_token_id
		i32 107; java_map_index
	}, 
	; 20
	%struct.TypeMapModuleEntry {
		i32 33554586, ; type_token_id
		i32 123; java_map_index
	}, 
	; 21
	%struct.TypeMapModuleEntry {
		i32 33554587, ; type_token_id
		i32 277; java_map_index
	}, 
	; 22
	%struct.TypeMapModuleEntry {
		i32 33554588, ; type_token_id
		i32 241; java_map_index
	}, 
	; 23
	%struct.TypeMapModuleEntry {
		i32 33554589, ; type_token_id
		i32 4; java_map_index
	}, 
	; 24
	%struct.TypeMapModuleEntry {
		i32 33554590, ; type_token_id
		i32 1; java_map_index
	}, 
	; 25
	%struct.TypeMapModuleEntry {
		i32 33554591, ; type_token_id
		i32 376; java_map_index
	}, 
	; 26
	%struct.TypeMapModuleEntry {
		i32 33554593, ; type_token_id
		i32 683; java_map_index
	}, 
	; 27
	%struct.TypeMapModuleEntry {
		i32 33554594, ; type_token_id
		i32 410; java_map_index
	}, 
	; 28
	%struct.TypeMapModuleEntry {
		i32 33554595, ; type_token_id
		i32 625; java_map_index
	}, 
	; 29
	%struct.TypeMapModuleEntry {
		i32 33554597, ; type_token_id
		i32 316; java_map_index
	}, 
	; 30
	%struct.TypeMapModuleEntry {
		i32 33554598, ; type_token_id
		i32 734; java_map_index
	}, 
	; 31
	%struct.TypeMapModuleEntry {
		i32 33554599, ; type_token_id
		i32 224; java_map_index
	}, 
	; 32
	%struct.TypeMapModuleEntry {
		i32 33554600, ; type_token_id
		i32 492; java_map_index
	}, 
	; 33
	%struct.TypeMapModuleEntry {
		i32 33554601, ; type_token_id
		i32 614; java_map_index
	}, 
	; 34
	%struct.TypeMapModuleEntry {
		i32 33554602, ; type_token_id
		i32 460; java_map_index
	}, 
	; 35
	%struct.TypeMapModuleEntry {
		i32 33554603, ; type_token_id
		i32 307; java_map_index
	}, 
	; 36
	%struct.TypeMapModuleEntry {
		i32 33554604, ; type_token_id
		i32 562; java_map_index
	}, 
	; 37
	%struct.TypeMapModuleEntry {
		i32 33554605, ; type_token_id
		i32 236; java_map_index
	}, 
	; 38
	%struct.TypeMapModuleEntry {
		i32 33554606, ; type_token_id
		i32 526; java_map_index
	}, 
	; 39
	%struct.TypeMapModuleEntry {
		i32 33554607, ; type_token_id
		i32 46; java_map_index
	}, 
	; 40
	%struct.TypeMapModuleEntry {
		i32 33554608, ; type_token_id
		i32 154; java_map_index
	}, 
	; 41
	%struct.TypeMapModuleEntry {
		i32 33554609, ; type_token_id
		i32 102; java_map_index
	}, 
	; 42
	%struct.TypeMapModuleEntry {
		i32 33554610, ; type_token_id
		i32 611; java_map_index
	}, 
	; 43
	%struct.TypeMapModuleEntry {
		i32 33554611, ; type_token_id
		i32 217; java_map_index
	}, 
	; 44
	%struct.TypeMapModuleEntry {
		i32 33554612, ; type_token_id
		i32 229; java_map_index
	}, 
	; 45
	%struct.TypeMapModuleEntry {
		i32 33554613, ; type_token_id
		i32 453; java_map_index
	}, 
	; 46
	%struct.TypeMapModuleEntry {
		i32 33554614, ; type_token_id
		i32 606; java_map_index
	}, 
	; 47
	%struct.TypeMapModuleEntry {
		i32 33554615, ; type_token_id
		i32 330; java_map_index
	}, 
	; 48
	%struct.TypeMapModuleEntry {
		i32 33554616, ; type_token_id
		i32 26; java_map_index
	}, 
	; 49
	%struct.TypeMapModuleEntry {
		i32 33554617, ; type_token_id
		i32 352; java_map_index
	}, 
	; 50
	%struct.TypeMapModuleEntry {
		i32 33554618, ; type_token_id
		i32 592; java_map_index
	}, 
	; 51
	%struct.TypeMapModuleEntry {
		i32 33554619, ; type_token_id
		i32 260; java_map_index
	}, 
	; 52
	%struct.TypeMapModuleEntry {
		i32 33554620, ; type_token_id
		i32 112; java_map_index
	}, 
	; 53
	%struct.TypeMapModuleEntry {
		i32 33554621, ; type_token_id
		i32 724; java_map_index
	}, 
	; 54
	%struct.TypeMapModuleEntry {
		i32 33554623, ; type_token_id
		i32 71; java_map_index
	}, 
	; 55
	%struct.TypeMapModuleEntry {
		i32 33554624, ; type_token_id
		i32 214; java_map_index
	}, 
	; 56
	%struct.TypeMapModuleEntry {
		i32 33554626, ; type_token_id
		i32 23; java_map_index
	}, 
	; 57
	%struct.TypeMapModuleEntry {
		i32 33554627, ; type_token_id
		i32 55; java_map_index
	}, 
	; 58
	%struct.TypeMapModuleEntry {
		i32 33554628, ; type_token_id
		i32 423; java_map_index
	}, 
	; 59
	%struct.TypeMapModuleEntry {
		i32 33554629, ; type_token_id
		i32 600; java_map_index
	}, 
	; 60
	%struct.TypeMapModuleEntry {
		i32 33554630, ; type_token_id
		i32 176; java_map_index
	}, 
	; 61
	%struct.TypeMapModuleEntry {
		i32 33554631, ; type_token_id
		i32 43; java_map_index
	}, 
	; 62
	%struct.TypeMapModuleEntry {
		i32 33554632, ; type_token_id
		i32 44; java_map_index
	}, 
	; 63
	%struct.TypeMapModuleEntry {
		i32 33554633, ; type_token_id
		i32 138; java_map_index
	}, 
	; 64
	%struct.TypeMapModuleEntry {
		i32 33554634, ; type_token_id
		i32 20; java_map_index
	}, 
	; 65
	%struct.TypeMapModuleEntry {
		i32 33554635, ; type_token_id
		i32 449; java_map_index
	}, 
	; 66
	%struct.TypeMapModuleEntry {
		i32 33554636, ; type_token_id
		i32 49; java_map_index
	}, 
	; 67
	%struct.TypeMapModuleEntry {
		i32 33554637, ; type_token_id
		i32 688; java_map_index
	}, 
	; 68
	%struct.TypeMapModuleEntry {
		i32 33554638, ; type_token_id
		i32 305; java_map_index
	}, 
	; 69
	%struct.TypeMapModuleEntry {
		i32 33554639, ; type_token_id
		i32 495; java_map_index
	}, 
	; 70
	%struct.TypeMapModuleEntry {
		i32 33554640, ; type_token_id
		i32 546; java_map_index
	}, 
	; 71
	%struct.TypeMapModuleEntry {
		i32 33554641, ; type_token_id
		i32 351; java_map_index
	}, 
	; 72
	%struct.TypeMapModuleEntry {
		i32 33554642, ; type_token_id
		i32 226; java_map_index
	}, 
	; 73
	%struct.TypeMapModuleEntry {
		i32 33554643, ; type_token_id
		i32 11; java_map_index
	}, 
	; 74
	%struct.TypeMapModuleEntry {
		i32 33554644, ; type_token_id
		i32 41; java_map_index
	}, 
	; 75
	%struct.TypeMapModuleEntry {
		i32 33554645, ; type_token_id
		i32 298; java_map_index
	}, 
	; 76
	%struct.TypeMapModuleEntry {
		i32 33554648, ; type_token_id
		i32 263; java_map_index
	}, 
	; 77
	%struct.TypeMapModuleEntry {
		i32 33554651, ; type_token_id
		i32 251; java_map_index
	}, 
	; 78
	%struct.TypeMapModuleEntry {
		i32 33554652, ; type_token_id
		i32 16; java_map_index
	}, 
	; 79
	%struct.TypeMapModuleEntry {
		i32 33554653, ; type_token_id
		i32 602; java_map_index
	}, 
	; 80
	%struct.TypeMapModuleEntry {
		i32 33554654, ; type_token_id
		i32 694; java_map_index
	}, 
	; 81
	%struct.TypeMapModuleEntry {
		i32 33554655, ; type_token_id
		i32 518; java_map_index
	}, 
	; 82
	%struct.TypeMapModuleEntry {
		i32 33554656, ; type_token_id
		i32 45; java_map_index
	}, 
	; 83
	%struct.TypeMapModuleEntry {
		i32 33554657, ; type_token_id
		i32 174; java_map_index
	}, 
	; 84
	%struct.TypeMapModuleEntry {
		i32 33554658, ; type_token_id
		i32 293; java_map_index
	}, 
	; 85
	%struct.TypeMapModuleEntry {
		i32 33554659, ; type_token_id
		i32 382; java_map_index
	}, 
	; 86
	%struct.TypeMapModuleEntry {
		i32 33554660, ; type_token_id
		i32 579; java_map_index
	}, 
	; 87
	%struct.TypeMapModuleEntry {
		i32 33554665, ; type_token_id
		i32 357; java_map_index
	}, 
	; 88
	%struct.TypeMapModuleEntry {
		i32 33554666, ; type_token_id
		i32 682; java_map_index
	}, 
	; 89
	%struct.TypeMapModuleEntry {
		i32 33554667, ; type_token_id
		i32 727; java_map_index
	}, 
	; 90
	%struct.TypeMapModuleEntry {
		i32 33554672, ; type_token_id
		i32 288; java_map_index
	}, 
	; 91
	%struct.TypeMapModuleEntry {
		i32 33554673, ; type_token_id
		i32 540; java_map_index
	}, 
	; 92
	%struct.TypeMapModuleEntry {
		i32 33554674, ; type_token_id
		i32 409; java_map_index
	}, 
	; 93
	%struct.TypeMapModuleEntry {
		i32 33554675, ; type_token_id
		i32 418; java_map_index
	}, 
	; 94
	%struct.TypeMapModuleEntry {
		i32 33554676, ; type_token_id
		i32 191; java_map_index
	}, 
	; 95
	%struct.TypeMapModuleEntry {
		i32 33554680, ; type_token_id
		i32 69; java_map_index
	}, 
	; 96
	%struct.TypeMapModuleEntry {
		i32 33554681, ; type_token_id
		i32 290; java_map_index
	}, 
	; 97
	%struct.TypeMapModuleEntry {
		i32 33554682, ; type_token_id
		i32 637; java_map_index
	}, 
	; 98
	%struct.TypeMapModuleEntry {
		i32 33554683, ; type_token_id
		i32 243; java_map_index
	}, 
	; 99
	%struct.TypeMapModuleEntry {
		i32 33554684, ; type_token_id
		i32 696; java_map_index
	}, 
	; 100
	%struct.TypeMapModuleEntry {
		i32 33554685, ; type_token_id
		i32 556; java_map_index
	}, 
	; 101
	%struct.TypeMapModuleEntry {
		i32 33554686, ; type_token_id
		i32 721; java_map_index
	}, 
	; 102
	%struct.TypeMapModuleEntry {
		i32 33554689, ; type_token_id
		i32 705; java_map_index
	}, 
	; 103
	%struct.TypeMapModuleEntry {
		i32 33554690, ; type_token_id
		i32 234; java_map_index
	}, 
	; 104
	%struct.TypeMapModuleEntry {
		i32 33554691, ; type_token_id
		i32 690; java_map_index
	}, 
	; 105
	%struct.TypeMapModuleEntry {
		i32 33554692, ; type_token_id
		i32 521; java_map_index
	}, 
	; 106
	%struct.TypeMapModuleEntry {
		i32 33554693, ; type_token_id
		i32 265; java_map_index
	}, 
	; 107
	%struct.TypeMapModuleEntry {
		i32 33554695, ; type_token_id
		i32 285; java_map_index
	}, 
	; 108
	%struct.TypeMapModuleEntry {
		i32 33554696, ; type_token_id
		i32 687; java_map_index
	}, 
	; 109
	%struct.TypeMapModuleEntry {
		i32 33554700, ; type_token_id
		i32 656; java_map_index
	}, 
	; 110
	%struct.TypeMapModuleEntry {
		i32 33554701, ; type_token_id
		i32 527; java_map_index
	}, 
	; 111
	%struct.TypeMapModuleEntry {
		i32 33554702, ; type_token_id
		i32 228; java_map_index
	}, 
	; 112
	%struct.TypeMapModuleEntry {
		i32 33554703, ; type_token_id
		i32 62; java_map_index
	}, 
	; 113
	%struct.TypeMapModuleEntry {
		i32 33554704, ; type_token_id
		i32 646; java_map_index
	}, 
	; 114
	%struct.TypeMapModuleEntry {
		i32 33554705, ; type_token_id
		i32 324; java_map_index
	}, 
	; 115
	%struct.TypeMapModuleEntry {
		i32 33554706, ; type_token_id
		i32 585; java_map_index
	}, 
	; 116
	%struct.TypeMapModuleEntry {
		i32 33554707, ; type_token_id
		i32 738; java_map_index
	}, 
	; 117
	%struct.TypeMapModuleEntry {
		i32 33554708, ; type_token_id
		i32 619; java_map_index
	}, 
	; 118
	%struct.TypeMapModuleEntry {
		i32 33554710, ; type_token_id
		i32 337; java_map_index
	}, 
	; 119
	%struct.TypeMapModuleEntry {
		i32 33554712, ; type_token_id
		i32 206; java_map_index
	}, 
	; 120
	%struct.TypeMapModuleEntry {
		i32 33554714, ; type_token_id
		i32 87; java_map_index
	}, 
	; 121
	%struct.TypeMapModuleEntry {
		i32 33554716, ; type_token_id
		i32 371; java_map_index
	}, 
	; 122
	%struct.TypeMapModuleEntry {
		i32 33554718, ; type_token_id
		i32 442; java_map_index
	}, 
	; 123
	%struct.TypeMapModuleEntry {
		i32 33554719, ; type_token_id
		i32 84; java_map_index
	}, 
	; 124
	%struct.TypeMapModuleEntry {
		i32 33554720, ; type_token_id
		i32 643; java_map_index
	}, 
	; 125
	%struct.TypeMapModuleEntry {
		i32 33554721, ; type_token_id
		i32 64; java_map_index
	}, 
	; 126
	%struct.TypeMapModuleEntry {
		i32 33554722, ; type_token_id
		i32 584; java_map_index
	}, 
	; 127
	%struct.TypeMapModuleEntry {
		i32 33554724, ; type_token_id
		i32 177; java_map_index
	}, 
	; 128
	%struct.TypeMapModuleEntry {
		i32 33554726, ; type_token_id
		i32 88; java_map_index
	}, 
	; 129
	%struct.TypeMapModuleEntry {
		i32 33554727, ; type_token_id
		i32 680; java_map_index
	}, 
	; 130
	%struct.TypeMapModuleEntry {
		i32 33554728, ; type_token_id
		i32 730; java_map_index
	}, 
	; 131
	%struct.TypeMapModuleEntry {
		i32 33554729, ; type_token_id
		i32 83; java_map_index
	}, 
	; 132
	%struct.TypeMapModuleEntry {
		i32 33554730, ; type_token_id
		i32 499; java_map_index
	}, 
	; 133
	%struct.TypeMapModuleEntry {
		i32 33554731, ; type_token_id
		i32 466; java_map_index
	}, 
	; 134
	%struct.TypeMapModuleEntry {
		i32 33554733, ; type_token_id
		i32 283; java_map_index
	}, 
	; 135
	%struct.TypeMapModuleEntry {
		i32 33554734, ; type_token_id
		i32 22; java_map_index
	}, 
	; 136
	%struct.TypeMapModuleEntry {
		i32 33554735, ; type_token_id
		i32 297; java_map_index
	}, 
	; 137
	%struct.TypeMapModuleEntry {
		i32 33554737, ; type_token_id
		i32 275; java_map_index
	}, 
	; 138
	%struct.TypeMapModuleEntry {
		i32 33554738, ; type_token_id
		i32 624; java_map_index
	}, 
	; 139
	%struct.TypeMapModuleEntry {
		i32 33554739, ; type_token_id
		i32 610; java_map_index
	}, 
	; 140
	%struct.TypeMapModuleEntry {
		i32 33554740, ; type_token_id
		i32 507; java_map_index
	}, 
	; 141
	%struct.TypeMapModuleEntry {
		i32 33554741, ; type_token_id
		i32 718; java_map_index
	}, 
	; 142
	%struct.TypeMapModuleEntry {
		i32 33554742, ; type_token_id
		i32 642; java_map_index
	}, 
	; 143
	%struct.TypeMapModuleEntry {
		i32 33554743, ; type_token_id
		i32 633; java_map_index
	}, 
	; 144
	%struct.TypeMapModuleEntry {
		i32 33554744, ; type_token_id
		i32 620; java_map_index
	}, 
	; 145
	%struct.TypeMapModuleEntry {
		i32 33554745, ; type_token_id
		i32 403; java_map_index
	}, 
	; 146
	%struct.TypeMapModuleEntry {
		i32 33554746, ; type_token_id
		i32 173; java_map_index
	}, 
	; 147
	%struct.TypeMapModuleEntry {
		i32 33554747, ; type_token_id
		i32 630; java_map_index
	}, 
	; 148
	%struct.TypeMapModuleEntry {
		i32 33554748, ; type_token_id
		i32 301; java_map_index
	}, 
	; 149
	%struct.TypeMapModuleEntry {
		i32 33554750, ; type_token_id
		i32 385; java_map_index
	}, 
	; 150
	%struct.TypeMapModuleEntry {
		i32 33554752, ; type_token_id
		i32 414; java_map_index
	}, 
	; 151
	%struct.TypeMapModuleEntry {
		i32 33554753, ; type_token_id
		i32 299; java_map_index
	}, 
	; 152
	%struct.TypeMapModuleEntry {
		i32 33554754, ; type_token_id
		i32 99; java_map_index
	}, 
	; 153
	%struct.TypeMapModuleEntry {
		i32 33554755, ; type_token_id
		i32 733; java_map_index
	}, 
	; 154
	%struct.TypeMapModuleEntry {
		i32 33554756, ; type_token_id
		i32 639; java_map_index
	}, 
	; 155
	%struct.TypeMapModuleEntry {
		i32 33554757, ; type_token_id
		i32 170; java_map_index
	}, 
	; 156
	%struct.TypeMapModuleEntry {
		i32 33554758, ; type_token_id
		i32 496; java_map_index
	}, 
	; 157
	%struct.TypeMapModuleEntry {
		i32 33554759, ; type_token_id
		i32 673; java_map_index
	}, 
	; 158
	%struct.TypeMapModuleEntry {
		i32 33554760, ; type_token_id
		i32 197; java_map_index
	}, 
	; 159
	%struct.TypeMapModuleEntry {
		i32 33554761, ; type_token_id
		i32 444; java_map_index
	}, 
	; 160
	%struct.TypeMapModuleEntry {
		i32 33554762, ; type_token_id
		i32 478; java_map_index
	}, 
	; 161
	%struct.TypeMapModuleEntry {
		i32 33554763, ; type_token_id
		i32 245; java_map_index
	}, 
	; 162
	%struct.TypeMapModuleEntry {
		i32 33554764, ; type_token_id
		i32 310; java_map_index
	}, 
	; 163
	%struct.TypeMapModuleEntry {
		i32 33554765, ; type_token_id
		i32 332; java_map_index
	}, 
	; 164
	%struct.TypeMapModuleEntry {
		i32 33554766, ; type_token_id
		i32 571; java_map_index
	}, 
	; 165
	%struct.TypeMapModuleEntry {
		i32 33554767, ; type_token_id
		i32 282; java_map_index
	}, 
	; 166
	%struct.TypeMapModuleEntry {
		i32 33554768, ; type_token_id
		i32 455; java_map_index
	}, 
	; 167
	%struct.TypeMapModuleEntry {
		i32 33554769, ; type_token_id
		i32 242; java_map_index
	}, 
	; 168
	%struct.TypeMapModuleEntry {
		i32 33554770, ; type_token_id
		i32 86; java_map_index
	}, 
	; 169
	%struct.TypeMapModuleEntry {
		i32 33554771, ; type_token_id
		i32 649; java_map_index
	}, 
	; 170
	%struct.TypeMapModuleEntry {
		i32 33554772, ; type_token_id
		i32 674; java_map_index
	}, 
	; 171
	%struct.TypeMapModuleEntry {
		i32 33554773, ; type_token_id
		i32 36; java_map_index
	}, 
	; 172
	%struct.TypeMapModuleEntry {
		i32 33554774, ; type_token_id
		i32 322; java_map_index
	}, 
	; 173
	%struct.TypeMapModuleEntry {
		i32 33554775, ; type_token_id
		i32 609; java_map_index
	}, 
	; 174
	%struct.TypeMapModuleEntry {
		i32 33554776, ; type_token_id
		i32 473; java_map_index
	}, 
	; 175
	%struct.TypeMapModuleEntry {
		i32 33554777, ; type_token_id
		i32 168; java_map_index
	}, 
	; 176
	%struct.TypeMapModuleEntry {
		i32 33554778, ; type_token_id
		i32 594; java_map_index
	}, 
	; 177
	%struct.TypeMapModuleEntry {
		i32 33554779, ; type_token_id
		i32 219; java_map_index
	}, 
	; 178
	%struct.TypeMapModuleEntry {
		i32 33554780, ; type_token_id
		i32 604; java_map_index
	}, 
	; 179
	%struct.TypeMapModuleEntry {
		i32 33554781, ; type_token_id
		i32 68; java_map_index
	}, 
	; 180
	%struct.TypeMapModuleEntry {
		i32 33554782, ; type_token_id
		i32 284; java_map_index
	}, 
	; 181
	%struct.TypeMapModuleEntry {
		i32 33554783, ; type_token_id
		i32 400; java_map_index
	}, 
	; 182
	%struct.TypeMapModuleEntry {
		i32 33554784, ; type_token_id
		i32 182; java_map_index
	}, 
	; 183
	%struct.TypeMapModuleEntry {
		i32 33554785, ; type_token_id
		i32 42; java_map_index
	}, 
	; 184
	%struct.TypeMapModuleEntry {
		i32 33554786, ; type_token_id
		i32 393; java_map_index
	}, 
	; 185
	%struct.TypeMapModuleEntry {
		i32 33554787, ; type_token_id
		i32 76; java_map_index
	}, 
	; 186
	%struct.TypeMapModuleEntry {
		i32 33554788, ; type_token_id
		i32 195; java_map_index
	}, 
	; 187
	%struct.TypeMapModuleEntry {
		i32 33554789, ; type_token_id
		i32 37; java_map_index
	}, 
	; 188
	%struct.TypeMapModuleEntry {
		i32 33554790, ; type_token_id
		i32 250; java_map_index
	}, 
	; 189
	%struct.TypeMapModuleEntry {
		i32 33554791, ; type_token_id
		i32 457; java_map_index
	}, 
	; 190
	%struct.TypeMapModuleEntry {
		i32 33554792, ; type_token_id
		i32 679; java_map_index
	}, 
	; 191
	%struct.TypeMapModuleEntry {
		i32 33554793, ; type_token_id
		i32 725; java_map_index
	}, 
	; 192
	%struct.TypeMapModuleEntry {
		i32 33554794, ; type_token_id
		i32 717; java_map_index
	}, 
	; 193
	%struct.TypeMapModuleEntry {
		i32 33554795, ; type_token_id
		i32 654; java_map_index
	}, 
	; 194
	%struct.TypeMapModuleEntry {
		i32 33554796, ; type_token_id
		i32 450; java_map_index
	}, 
	; 195
	%struct.TypeMapModuleEntry {
		i32 33554801, ; type_token_id
		i32 223; java_map_index
	}, 
	; 196
	%struct.TypeMapModuleEntry {
		i32 33554805, ; type_token_id
		i32 319; java_map_index
	}, 
	; 197
	%struct.TypeMapModuleEntry {
		i32 33554809, ; type_token_id
		i32 667; java_map_index
	}, 
	; 198
	%struct.TypeMapModuleEntry {
		i32 33554810, ; type_token_id
		i32 227; java_map_index
	}, 
	; 199
	%struct.TypeMapModuleEntry {
		i32 33554811, ; type_token_id
		i32 470; java_map_index
	}, 
	; 200
	%struct.TypeMapModuleEntry {
		i32 33554812, ; type_token_id
		i32 529; java_map_index
	}, 
	; 201
	%struct.TypeMapModuleEntry {
		i32 33554814, ; type_token_id
		i32 313; java_map_index
	}, 
	; 202
	%struct.TypeMapModuleEntry {
		i32 33554815, ; type_token_id
		i32 220; java_map_index
	}, 
	; 203
	%struct.TypeMapModuleEntry {
		i32 33554817, ; type_token_id
		i32 308; java_map_index
	}, 
	; 204
	%struct.TypeMapModuleEntry {
		i32 33554819, ; type_token_id
		i32 597; java_map_index
	}, 
	; 205
	%struct.TypeMapModuleEntry {
		i32 33554820, ; type_token_id
		i32 75; java_map_index
	}, 
	; 206
	%struct.TypeMapModuleEntry {
		i32 33554821, ; type_token_id
		i32 706; java_map_index
	}, 
	; 207
	%struct.TypeMapModuleEntry {
		i32 33554822, ; type_token_id
		i32 719; java_map_index
	}, 
	; 208
	%struct.TypeMapModuleEntry {
		i32 33554823, ; type_token_id
		i32 296; java_map_index
	}, 
	; 209
	%struct.TypeMapModuleEntry {
		i32 33554825, ; type_token_id
		i32 685; java_map_index
	}, 
	; 210
	%struct.TypeMapModuleEntry {
		i32 33554826, ; type_token_id
		i32 548; java_map_index
	}, 
	; 211
	%struct.TypeMapModuleEntry {
		i32 33554827, ; type_token_id
		i32 370; java_map_index
	}, 
	; 212
	%struct.TypeMapModuleEntry {
		i32 33554828, ; type_token_id
		i32 617; java_map_index
	}, 
	; 213
	%struct.TypeMapModuleEntry {
		i32 33554829, ; type_token_id
		i32 202; java_map_index
	}, 
	; 214
	%struct.TypeMapModuleEntry {
		i32 33554830, ; type_token_id
		i32 145; java_map_index
	}, 
	; 215
	%struct.TypeMapModuleEntry {
		i32 33554831, ; type_token_id
		i32 2; java_map_index
	}, 
	; 216
	%struct.TypeMapModuleEntry {
		i32 33554832, ; type_token_id
		i32 52; java_map_index
	}, 
	; 217
	%struct.TypeMapModuleEntry {
		i32 33554833, ; type_token_id
		i32 105; java_map_index
	}, 
	; 218
	%struct.TypeMapModuleEntry {
		i32 33554834, ; type_token_id
		i32 221; java_map_index
	}, 
	; 219
	%struct.TypeMapModuleEntry {
		i32 33554835, ; type_token_id
		i32 40; java_map_index
	}, 
	; 220
	%struct.TypeMapModuleEntry {
		i32 33554836, ; type_token_id
		i32 291; java_map_index
	}, 
	; 221
	%struct.TypeMapModuleEntry {
		i32 33554837, ; type_token_id
		i32 91; java_map_index
	}, 
	; 222
	%struct.TypeMapModuleEntry {
		i32 33554838, ; type_token_id
		i32 267; java_map_index
	}, 
	; 223
	%struct.TypeMapModuleEntry {
		i32 33554839, ; type_token_id
		i32 130; java_map_index
	}, 
	; 224
	%struct.TypeMapModuleEntry {
		i32 33554840, ; type_token_id
		i32 708; java_map_index
	}, 
	; 225
	%struct.TypeMapModuleEntry {
		i32 33554841, ; type_token_id
		i32 141; java_map_index
	}, 
	; 226
	%struct.TypeMapModuleEntry {
		i32 33554842, ; type_token_id
		i32 151; java_map_index
	}, 
	; 227
	%struct.TypeMapModuleEntry {
		i32 33554843, ; type_token_id
		i32 215; java_map_index
	}, 
	; 228
	%struct.TypeMapModuleEntry {
		i32 33554844, ; type_token_id
		i32 699; java_map_index
	}, 
	; 229
	%struct.TypeMapModuleEntry {
		i32 33554845, ; type_token_id
		i32 503; java_map_index
	}, 
	; 230
	%struct.TypeMapModuleEntry {
		i32 33554846, ; type_token_id
		i32 278; java_map_index
	}, 
	; 231
	%struct.TypeMapModuleEntry {
		i32 33554847, ; type_token_id
		i32 523; java_map_index
	}, 
	; 232
	%struct.TypeMapModuleEntry {
		i32 33554848, ; type_token_id
		i32 212; java_map_index
	}, 
	; 233
	%struct.TypeMapModuleEntry {
		i32 33554849, ; type_token_id
		i32 208; java_map_index
	}, 
	; 234
	%struct.TypeMapModuleEntry {
		i32 33554850, ; type_token_id
		i32 336; java_map_index
	}, 
	; 235
	%struct.TypeMapModuleEntry {
		i32 33554851, ; type_token_id
		i32 252; java_map_index
	}, 
	; 236
	%struct.TypeMapModuleEntry {
		i32 33554852, ; type_token_id
		i32 587; java_map_index
	}, 
	; 237
	%struct.TypeMapModuleEntry {
		i32 33554853, ; type_token_id
		i32 126; java_map_index
	}, 
	; 238
	%struct.TypeMapModuleEntry {
		i32 33554854, ; type_token_id
		i32 207; java_map_index
	}, 
	; 239
	%struct.TypeMapModuleEntry {
		i32 33554855, ; type_token_id
		i32 143; java_map_index
	}, 
	; 240
	%struct.TypeMapModuleEntry {
		i32 33554856, ; type_token_id
		i32 565; java_map_index
	}, 
	; 241
	%struct.TypeMapModuleEntry {
		i32 33554857, ; type_token_id
		i32 434; java_map_index
	}, 
	; 242
	%struct.TypeMapModuleEntry {
		i32 33554858, ; type_token_id
		i32 726; java_map_index
	}, 
	; 243
	%struct.TypeMapModuleEntry {
		i32 33554859, ; type_token_id
		i32 524; java_map_index
	}, 
	; 244
	%struct.TypeMapModuleEntry {
		i32 33554860, ; type_token_id
		i32 121; java_map_index
	}, 
	; 245
	%struct.TypeMapModuleEntry {
		i32 33554861, ; type_token_id
		i32 144; java_map_index
	}, 
	; 246
	%struct.TypeMapModuleEntry {
		i32 33554862, ; type_token_id
		i32 341; java_map_index
	}, 
	; 247
	%struct.TypeMapModuleEntry {
		i32 33554863, ; type_token_id
		i32 560; java_map_index
	}, 
	; 248
	%struct.TypeMapModuleEntry {
		i32 33554864, ; type_token_id
		i32 100; java_map_index
	}, 
	; 249
	%struct.TypeMapModuleEntry {
		i32 33554865, ; type_token_id
		i32 367; java_map_index
	}, 
	; 250
	%struct.TypeMapModuleEntry {
		i32 33554866, ; type_token_id
		i32 427; java_map_index
	}, 
	; 251
	%struct.TypeMapModuleEntry {
		i32 33554867, ; type_token_id
		i32 723; java_map_index
	}, 
	; 252
	%struct.TypeMapModuleEntry {
		i32 33554868, ; type_token_id
		i32 358; java_map_index
	}, 
	; 253
	%struct.TypeMapModuleEntry {
		i32 33554869, ; type_token_id
		i32 552; java_map_index
	}, 
	; 254
	%struct.TypeMapModuleEntry {
		i32 33554870, ; type_token_id
		i32 333; java_map_index
	}, 
	; 255
	%struct.TypeMapModuleEntry {
		i32 33554871, ; type_token_id
		i32 345; java_map_index
	}, 
	; 256
	%struct.TypeMapModuleEntry {
		i32 33554872, ; type_token_id
		i32 9; java_map_index
	}, 
	; 257
	%struct.TypeMapModuleEntry {
		i32 33554873, ; type_token_id
		i32 615; java_map_index
	}, 
	; 258
	%struct.TypeMapModuleEntry {
		i32 33554874, ; type_token_id
		i32 728; java_map_index
	}, 
	; 259
	%struct.TypeMapModuleEntry {
		i32 33554875, ; type_token_id
		i32 528; java_map_index
	}, 
	; 260
	%struct.TypeMapModuleEntry {
		i32 33554876, ; type_token_id
		i32 480; java_map_index
	}, 
	; 261
	%struct.TypeMapModuleEntry {
		i32 33554877, ; type_token_id
		i32 672; java_map_index
	}, 
	; 262
	%struct.TypeMapModuleEntry {
		i32 33554878, ; type_token_id
		i32 309; java_map_index
	}, 
	; 263
	%struct.TypeMapModuleEntry {
		i32 33554879, ; type_token_id
		i32 312; java_map_index
	}, 
	; 264
	%struct.TypeMapModuleEntry {
		i32 33554880, ; type_token_id
		i32 638; java_map_index
	}, 
	; 265
	%struct.TypeMapModuleEntry {
		i32 33554881, ; type_token_id
		i32 203; java_map_index
	}, 
	; 266
	%struct.TypeMapModuleEntry {
		i32 33554882, ; type_token_id
		i32 698; java_map_index
	}, 
	; 267
	%struct.TypeMapModuleEntry {
		i32 33554883, ; type_token_id
		i32 387; java_map_index
	}, 
	; 268
	%struct.TypeMapModuleEntry {
		i32 33554884, ; type_token_id
		i32 13; java_map_index
	}, 
	; 269
	%struct.TypeMapModuleEntry {
		i32 33554885, ; type_token_id
		i32 32; java_map_index
	}, 
	; 270
	%struct.TypeMapModuleEntry {
		i32 33554886, ; type_token_id
		i32 117; java_map_index
	}, 
	; 271
	%struct.TypeMapModuleEntry {
		i32 33554887, ; type_token_id
		i32 280; java_map_index
	}, 
	; 272
	%struct.TypeMapModuleEntry {
		i32 33554888, ; type_token_id
		i32 128; java_map_index
	}, 
	; 273
	%struct.TypeMapModuleEntry {
		i32 33554889, ; type_token_id
		i32 467; java_map_index
	}, 
	; 274
	%struct.TypeMapModuleEntry {
		i32 33554890, ; type_token_id
		i32 392; java_map_index
	}, 
	; 275
	%struct.TypeMapModuleEntry {
		i32 33554891, ; type_token_id
		i32 159; java_map_index
	}, 
	; 276
	%struct.TypeMapModuleEntry {
		i32 33554892, ; type_token_id
		i32 433; java_map_index
	}, 
	; 277
	%struct.TypeMapModuleEntry {
		i32 33554893, ; type_token_id
		i32 262; java_map_index
	}, 
	; 278
	%struct.TypeMapModuleEntry {
		i32 33554894, ; type_token_id
		i32 577; java_map_index
	}, 
	; 279
	%struct.TypeMapModuleEntry {
		i32 33554895, ; type_token_id
		i32 274; java_map_index
	}, 
	; 280
	%struct.TypeMapModuleEntry {
		i32 33554896, ; type_token_id
		i32 302; java_map_index
	}, 
	; 281
	%struct.TypeMapModuleEntry {
		i32 33554897, ; type_token_id
		i32 530; java_map_index
	}, 
	; 282
	%struct.TypeMapModuleEntry {
		i32 33554898, ; type_token_id
		i32 156; java_map_index
	}, 
	; 283
	%struct.TypeMapModuleEntry {
		i32 33554899, ; type_token_id
		i32 238; java_map_index
	}, 
	; 284
	%struct.TypeMapModuleEntry {
		i32 33554900, ; type_token_id
		i32 187; java_map_index
	}, 
	; 285
	%struct.TypeMapModuleEntry {
		i32 33554901, ; type_token_id
		i32 98; java_map_index
	}, 
	; 286
	%struct.TypeMapModuleEntry {
		i32 33554902, ; type_token_id
		i32 692; java_map_index
	}, 
	; 287
	%struct.TypeMapModuleEntry {
		i32 33554903, ; type_token_id
		i32 101; java_map_index
	}, 
	; 288
	%struct.TypeMapModuleEntry {
		i32 33554904, ; type_token_id
		i32 148; java_map_index
	}, 
	; 289
	%struct.TypeMapModuleEntry {
		i32 33554905, ; type_token_id
		i32 323; java_map_index
	}, 
	; 290
	%struct.TypeMapModuleEntry {
		i32 33554906, ; type_token_id
		i32 185; java_map_index
	}, 
	; 291
	%struct.TypeMapModuleEntry {
		i32 33554907, ; type_token_id
		i32 676; java_map_index
	}, 
	; 292
	%struct.TypeMapModuleEntry {
		i32 33554908, ; type_token_id
		i32 407; java_map_index
	}, 
	; 293
	%struct.TypeMapModuleEntry {
		i32 33554909, ; type_token_id
		i32 216; java_map_index
	}, 
	; 294
	%struct.TypeMapModuleEntry {
		i32 33554910, ; type_token_id
		i32 349; java_map_index
	}, 
	; 295
	%struct.TypeMapModuleEntry {
		i32 33554911, ; type_token_id
		i32 479; java_map_index
	}, 
	; 296
	%struct.TypeMapModuleEntry {
		i32 33554912, ; type_token_id
		i32 482; java_map_index
	}, 
	; 297
	%struct.TypeMapModuleEntry {
		i32 33554913, ; type_token_id
		i32 626; java_map_index
	}, 
	; 298
	%struct.TypeMapModuleEntry {
		i32 33554914, ; type_token_id
		i32 707; java_map_index
	}, 
	; 299
	%struct.TypeMapModuleEntry {
		i32 33554915, ; type_token_id
		i32 264; java_map_index
	}, 
	; 300
	%struct.TypeMapModuleEntry {
		i32 33554916, ; type_token_id
		i32 360; java_map_index
	}, 
	; 301
	%struct.TypeMapModuleEntry {
		i32 33554917, ; type_token_id
		i32 501; java_map_index
	}, 
	; 302
	%struct.TypeMapModuleEntry {
		i32 33554918, ; type_token_id
		i32 254; java_map_index
	}, 
	; 303
	%struct.TypeMapModuleEntry {
		i32 33554919, ; type_token_id
		i32 328; java_map_index
	}, 
	; 304
	%struct.TypeMapModuleEntry {
		i32 33554920, ; type_token_id
		i32 119; java_map_index
	}, 
	; 305
	%struct.TypeMapModuleEntry {
		i32 33554921, ; type_token_id
		i32 549; java_map_index
	}, 
	; 306
	%struct.TypeMapModuleEntry {
		i32 33554922, ; type_token_id
		i32 17; java_map_index
	}, 
	; 307
	%struct.TypeMapModuleEntry {
		i32 33554923, ; type_token_id
		i32 325; java_map_index
	}, 
	; 308
	%struct.TypeMapModuleEntry {
		i32 33554924, ; type_token_id
		i32 157; java_map_index
	}, 
	; 309
	%struct.TypeMapModuleEntry {
		i32 33554925, ; type_token_id
		i32 538; java_map_index
	}, 
	; 310
	%struct.TypeMapModuleEntry {
		i32 33554926, ; type_token_id
		i32 489; java_map_index
	}, 
	; 311
	%struct.TypeMapModuleEntry {
		i32 33554927, ; type_token_id
		i32 417; java_map_index
	}, 
	; 312
	%struct.TypeMapModuleEntry {
		i32 33554928, ; type_token_id
		i32 346; java_map_index
	}, 
	; 313
	%struct.TypeMapModuleEntry {
		i32 33554929, ; type_token_id
		i32 155; java_map_index
	}, 
	; 314
	%struct.TypeMapModuleEntry {
		i32 33554930, ; type_token_id
		i32 459; java_map_index
	}, 
	; 315
	%struct.TypeMapModuleEntry {
		i32 33554931, ; type_token_id
		i32 259; java_map_index
	}, 
	; 316
	%struct.TypeMapModuleEntry {
		i32 33554932, ; type_token_id
		i32 709; java_map_index
	}, 
	; 317
	%struct.TypeMapModuleEntry {
		i32 33554933, ; type_token_id
		i32 555; java_map_index
	}, 
	; 318
	%struct.TypeMapModuleEntry {
		i32 33554934, ; type_token_id
		i32 362; java_map_index
	}, 
	; 319
	%struct.TypeMapModuleEntry {
		i32 33554935, ; type_token_id
		i32 303; java_map_index
	}, 
	; 320
	%struct.TypeMapModuleEntry {
		i32 33554936, ; type_token_id
		i32 7; java_map_index
	}, 
	; 321
	%struct.TypeMapModuleEntry {
		i32 33554937, ; type_token_id
		i32 681; java_map_index
	}, 
	; 322
	%struct.TypeMapModuleEntry {
		i32 33554938, ; type_token_id
		i32 270; java_map_index
	}, 
	; 323
	%struct.TypeMapModuleEntry {
		i32 33554939, ; type_token_id
		i32 510; java_map_index
	}, 
	; 324
	%struct.TypeMapModuleEntry {
		i32 33554941, ; type_token_id
		i32 72; java_map_index
	}, 
	; 325
	%struct.TypeMapModuleEntry {
		i32 33554942, ; type_token_id
		i32 89; java_map_index
	}, 
	; 326
	%struct.TypeMapModuleEntry {
		i32 33554943, ; type_token_id
		i32 366; java_map_index
	}, 
	; 327
	%struct.TypeMapModuleEntry {
		i32 33554944, ; type_token_id
		i32 199; java_map_index
	}, 
	; 328
	%struct.TypeMapModuleEntry {
		i32 33554945, ; type_token_id
		i32 0; java_map_index
	}, 
	; 329
	%struct.TypeMapModuleEntry {
		i32 33554946, ; type_token_id
		i32 570; java_map_index
	}, 
	; 330
	%struct.TypeMapModuleEntry {
		i32 33554947, ; type_token_id
		i32 244; java_map_index
	}, 
	; 331
	%struct.TypeMapModuleEntry {
		i32 33554948, ; type_token_id
		i32 623; java_map_index
	}, 
	; 332
	%struct.TypeMapModuleEntry {
		i32 33554949, ; type_token_id
		i32 27; java_map_index
	}, 
	; 333
	%struct.TypeMapModuleEntry {
		i32 33554950, ; type_token_id
		i32 735; java_map_index
	}, 
	; 334
	%struct.TypeMapModuleEntry {
		i32 33554951, ; type_token_id
		i32 74; java_map_index
	}, 
	; 335
	%struct.TypeMapModuleEntry {
		i32 33554952, ; type_token_id
		i32 140; java_map_index
	}, 
	; 336
	%struct.TypeMapModuleEntry {
		i32 33554953, ; type_token_id
		i32 573; java_map_index
	}, 
	; 337
	%struct.TypeMapModuleEntry {
		i32 33554954, ; type_token_id
		i32 339; java_map_index
	}, 
	; 338
	%struct.TypeMapModuleEntry {
		i32 33554955, ; type_token_id
		i32 566; java_map_index
	}, 
	; 339
	%struct.TypeMapModuleEntry {
		i32 33554956, ; type_token_id
		i32 200; java_map_index
	}, 
	; 340
	%struct.TypeMapModuleEntry {
		i32 33554958, ; type_token_id
		i32 183; java_map_index
	}, 
	; 341
	%struct.TypeMapModuleEntry {
		i32 33554960, ; type_token_id
		i32 375; java_map_index
	}, 
	; 342
	%struct.TypeMapModuleEntry {
		i32 33554961, ; type_token_id
		i32 550; java_map_index
	}, 
	; 343
	%struct.TypeMapModuleEntry {
		i32 33554962, ; type_token_id
		i32 388; java_map_index
	}, 
	; 344
	%struct.TypeMapModuleEntry {
		i32 33554963, ; type_token_id
		i32 205; java_map_index
	}, 
	; 345
	%struct.TypeMapModuleEntry {
		i32 33554964, ; type_token_id
		i32 327; java_map_index
	}, 
	; 346
	%struct.TypeMapModuleEntry {
		i32 33554965, ; type_token_id
		i32 281; java_map_index
	}, 
	; 347
	%struct.TypeMapModuleEntry {
		i32 33554966, ; type_token_id
		i32 402; java_map_index
	}, 
	; 348
	%struct.TypeMapModuleEntry {
		i32 33554967, ; type_token_id
		i32 519; java_map_index
	}, 
	; 349
	%struct.TypeMapModuleEntry {
		i32 33554968, ; type_token_id
		i32 557; java_map_index
	}, 
	; 350
	%struct.TypeMapModuleEntry {
		i32 33554969, ; type_token_id
		i32 558; java_map_index
	}, 
	; 351
	%struct.TypeMapModuleEntry {
		i32 33554970, ; type_token_id
		i32 464; java_map_index
	}, 
	; 352
	%struct.TypeMapModuleEntry {
		i32 33554971, ; type_token_id
		i32 93; java_map_index
	}, 
	; 353
	%struct.TypeMapModuleEntry {
		i32 33554972, ; type_token_id
		i32 253; java_map_index
	}, 
	; 354
	%struct.TypeMapModuleEntry {
		i32 33554973, ; type_token_id
		i32 408; java_map_index
	}, 
	; 355
	%struct.TypeMapModuleEntry {
		i32 33554974, ; type_token_id
		i32 468; java_map_index
	}, 
	; 356
	%struct.TypeMapModuleEntry {
		i32 33554975, ; type_token_id
		i32 412; java_map_index
	}, 
	; 357
	%struct.TypeMapModuleEntry {
		i32 33554976, ; type_token_id
		i32 114; java_map_index
	}, 
	; 358
	%struct.TypeMapModuleEntry {
		i32 33554977, ; type_token_id
		i32 636; java_map_index
	}, 
	; 359
	%struct.TypeMapModuleEntry {
		i32 33554978, ; type_token_id
		i32 70; java_map_index
	}, 
	; 360
	%struct.TypeMapModuleEntry {
		i32 33554979, ; type_token_id
		i32 691; java_map_index
	}, 
	; 361
	%struct.TypeMapModuleEntry {
		i32 33554980, ; type_token_id
		i32 356; java_map_index
	}, 
	; 362
	%struct.TypeMapModuleEntry {
		i32 33554981, ; type_token_id
		i32 153; java_map_index
	}, 
	; 363
	%struct.TypeMapModuleEntry {
		i32 33554982, ; type_token_id
		i32 651; java_map_index
	}, 
	; 364
	%struct.TypeMapModuleEntry {
		i32 33554983, ; type_token_id
		i32 38; java_map_index
	}, 
	; 365
	%struct.TypeMapModuleEntry {
		i32 33554985, ; type_token_id
		i32 440; java_map_index
	}, 
	; 366
	%struct.TypeMapModuleEntry {
		i32 33554986, ; type_token_id
		i32 589; java_map_index
	}, 
	; 367
	%struct.TypeMapModuleEntry {
		i32 33554987, ; type_token_id
		i32 419; java_map_index
	}, 
	; 368
	%struct.TypeMapModuleEntry {
		i32 33554988, ; type_token_id
		i32 295; java_map_index
	}
], align 4; end of 'module13_managed_to_java' array


; module13_managed_to_java_duplicates
@module13_managed_to_java_duplicates = internal constant [46 x %struct.TypeMapModuleEntry] [
	; 0
	%struct.TypeMapModuleEntry {
		i32 33554557, ; type_token_id
		i32 415; java_map_index
	}, 
	; 1
	%struct.TypeMapModuleEntry {
		i32 33554562, ; type_token_id
		i32 334; java_map_index
	}, 
	; 2
	%struct.TypeMapModuleEntry {
		i32 33554563, ; type_token_id
		i32 334; java_map_index
	}, 
	; 3
	%struct.TypeMapModuleEntry {
		i32 33554564, ; type_token_id
		i32 334; java_map_index
	}, 
	; 4
	%struct.TypeMapModuleEntry {
		i32 33554571, ; type_token_id
		i32 129; java_map_index
	}, 
	; 5
	%struct.TypeMapModuleEntry {
		i32 33554574, ; type_token_id
		i32 535; java_map_index
	}, 
	; 6
	%struct.TypeMapModuleEntry {
		i32 33554576, ; type_token_id
		i32 359; java_map_index
	}, 
	; 7
	%struct.TypeMapModuleEntry {
		i32 33554577, ; type_token_id
		i32 359; java_map_index
	}, 
	; 8
	%struct.TypeMapModuleEntry {
		i32 33554578, ; type_token_id
		i32 359; java_map_index
	}, 
	; 9
	%struct.TypeMapModuleEntry {
		i32 33554582, ; type_token_id
		i32 435; java_map_index
	}, 
	; 10
	%struct.TypeMapModuleEntry {
		i32 33554592, ; type_token_id
		i32 376; java_map_index
	}, 
	; 11
	%struct.TypeMapModuleEntry {
		i32 33554596, ; type_token_id
		i32 625; java_map_index
	}, 
	; 12
	%struct.TypeMapModuleEntry {
		i32 33554622, ; type_token_id
		i32 724; java_map_index
	}, 
	; 13
	%struct.TypeMapModuleEntry {
		i32 33554625, ; type_token_id
		i32 214; java_map_index
	}, 
	; 14
	%struct.TypeMapModuleEntry {
		i32 33554646, ; type_token_id
		i32 298; java_map_index
	}, 
	; 15
	%struct.TypeMapModuleEntry {
		i32 33554661, ; type_token_id
		i32 579; java_map_index
	}, 
	; 16
	%struct.TypeMapModuleEntry {
		i32 33554668, ; type_token_id
		i32 727; java_map_index
	}, 
	; 17
	%struct.TypeMapModuleEntry {
		i32 33554677, ; type_token_id
		i32 191; java_map_index
	}, 
	; 18
	%struct.TypeMapModuleEntry {
		i32 33554688, ; type_token_id
		i32 721; java_map_index
	}, 
	; 19
	%struct.TypeMapModuleEntry {
		i32 33554694, ; type_token_id
		i32 265; java_map_index
	}, 
	; 20
	%struct.TypeMapModuleEntry {
		i32 33554697, ; type_token_id
		i32 687; java_map_index
	}, 
	; 21
	%struct.TypeMapModuleEntry {
		i32 33554698, ; type_token_id
		i32 687; java_map_index
	}, 
	; 22
	%struct.TypeMapModuleEntry {
		i32 33554699, ; type_token_id
		i32 687; java_map_index
	}, 
	; 23
	%struct.TypeMapModuleEntry {
		i32 33554709, ; type_token_id
		i32 619; java_map_index
	}, 
	; 24
	%struct.TypeMapModuleEntry {
		i32 33554711, ; type_token_id
		i32 337; java_map_index
	}, 
	; 25
	%struct.TypeMapModuleEntry {
		i32 33554713, ; type_token_id
		i32 206; java_map_index
	}, 
	; 26
	%struct.TypeMapModuleEntry {
		i32 33554715, ; type_token_id
		i32 87; java_map_index
	}, 
	; 27
	%struct.TypeMapModuleEntry {
		i32 33554717, ; type_token_id
		i32 371; java_map_index
	}, 
	; 28
	%struct.TypeMapModuleEntry {
		i32 33554723, ; type_token_id
		i32 584; java_map_index
	}, 
	; 29
	%struct.TypeMapModuleEntry {
		i32 33554725, ; type_token_id
		i32 177; java_map_index
	}, 
	; 30
	%struct.TypeMapModuleEntry {
		i32 33554732, ; type_token_id
		i32 466; java_map_index
	}, 
	; 31
	%struct.TypeMapModuleEntry {
		i32 33554736, ; type_token_id
		i32 297; java_map_index
	}, 
	; 32
	%struct.TypeMapModuleEntry {
		i32 33554749, ; type_token_id
		i32 301; java_map_index
	}, 
	; 33
	%struct.TypeMapModuleEntry {
		i32 33554751, ; type_token_id
		i32 385; java_map_index
	}, 
	; 34
	%struct.TypeMapModuleEntry {
		i32 33554802, ; type_token_id
		i32 223; java_map_index
	}, 
	; 35
	%struct.TypeMapModuleEntry {
		i32 33554803, ; type_token_id
		i32 223; java_map_index
	}, 
	; 36
	%struct.TypeMapModuleEntry {
		i32 33554804, ; type_token_id
		i32 223; java_map_index
	}, 
	; 37
	%struct.TypeMapModuleEntry {
		i32 33554806, ; type_token_id
		i32 319; java_map_index
	}, 
	; 38
	%struct.TypeMapModuleEntry {
		i32 33554813, ; type_token_id
		i32 529; java_map_index
	}, 
	; 39
	%struct.TypeMapModuleEntry {
		i32 33554816, ; type_token_id
		i32 220; java_map_index
	}, 
	; 40
	%struct.TypeMapModuleEntry {
		i32 33554818, ; type_token_id
		i32 308; java_map_index
	}, 
	; 41
	%struct.TypeMapModuleEntry {
		i32 33554824, ; type_token_id
		i32 296; java_map_index
	}, 
	; 42
	%struct.TypeMapModuleEntry {
		i32 33554940, ; type_token_id
		i32 510; java_map_index
	}, 
	; 43
	%struct.TypeMapModuleEntry {
		i32 33554957, ; type_token_id
		i32 200; java_map_index
	}, 
	; 44
	%struct.TypeMapModuleEntry {
		i32 33554959, ; type_token_id
		i32 183; java_map_index
	}, 
	; 45
	%struct.TypeMapModuleEntry {
		i32 33554984, ; type_token_id
		i32 38; java_map_index
	}
], align 4; end of 'module13_managed_to_java_duplicates' array


; module14_managed_to_java
@module14_managed_to_java = internal constant [1 x %struct.TypeMapModuleEntry] [
	; 0
	%struct.TypeMapModuleEntry {
		i32 33554435, ; type_token_id
		i32 534; java_map_index
	}
], align 4; end of 'module14_managed_to_java' array


; module14_managed_to_java_duplicates
@module14_managed_to_java_duplicates = internal constant [1 x %struct.TypeMapModuleEntry] [
	; 0
	%struct.TypeMapModuleEntry {
		i32 33554436, ; type_token_id
		i32 534; java_map_index
	}
], align 4; end of 'module14_managed_to_java_duplicates' array


; module15_managed_to_java
@module15_managed_to_java = internal constant [5 x %struct.TypeMapModuleEntry] [
	; 0
	%struct.TypeMapModuleEntry {
		i32 33554437, ; type_token_id
		i32 111; java_map_index
	}, 
	; 1
	%struct.TypeMapModuleEntry {
		i32 33554439, ; type_token_id
		i32 411; java_map_index
	}, 
	; 2
	%struct.TypeMapModuleEntry {
		i32 33554441, ; type_token_id
		i32 204; java_map_index
	}, 
	; 3
	%struct.TypeMapModuleEntry {
		i32 33554442, ; type_token_id
		i32 167; java_map_index
	}, 
	; 4
	%struct.TypeMapModuleEntry {
		i32 33554444, ; type_token_id
		i32 82; java_map_index
	}
], align 4; end of 'module15_managed_to_java' array


; module15_managed_to_java_duplicates
@module15_managed_to_java_duplicates = internal constant [3 x %struct.TypeMapModuleEntry] [
	; 0
	%struct.TypeMapModuleEntry {
		i32 33554438, ; type_token_id
		i32 111; java_map_index
	}, 
	; 1
	%struct.TypeMapModuleEntry {
		i32 33554440, ; type_token_id
		i32 411; java_map_index
	}, 
	; 2
	%struct.TypeMapModuleEntry {
		i32 33554443, ; type_token_id
		i32 167; java_map_index
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
], align 8; end of 'map_modules' array


; Java to managed map

; map_java
@map_java = local_unnamed_addr constant [743 x %struct.TypeMapJava] [
	; 0
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554945, ; type_token_id
		i32 696; java_name_index
	}, 
	; 1
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554590, ; type_token_id
		i32 392; java_name_index
	}, 
	; 2
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554831, ; type_token_id
		i32 583; java_name_index
	}, 
	; 3
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33555048, ; type_token_id
		i32 303; java_name_index
	}, 
	; 4
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554589, ; type_token_id
		i32 391; java_name_index
	}, 
	; 5
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 229; java_name_index
	}, 
	; 6
	%struct.TypeMapJava {
		i32 2, ; module_index
		i32 33554501, ; type_token_id
		i32 26; java_name_index
	}, 
	; 7
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554936, ; type_token_id
		i32 688; java_name_index
	}, 
	; 8
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554998, ; type_token_id
		i32 267; java_name_index
	}, 
	; 9
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554872, ; type_token_id
		i32 624; java_name_index
	}, 
	; 10
	%struct.TypeMapJava {
		i32 12, ; module_index
		i32 0, ; type_token_id
		i32 362; java_name_index
	}, 
	; 11
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554643, ; type_token_id
		i32 441; java_name_index
	}, 
	; 12
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554605, ; type_token_id
		i32 71; java_name_index
	}, 
	; 13
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554884, ; type_token_id
		i32 636; java_name_index
	}, 
	; 14
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554721, ; type_token_id
		i32 136; java_name_index
	}, 
	; 15
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554613, ; type_token_id
		i32 77; java_name_index
	}, 
	; 16
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554652, ; type_token_id
		i32 446; java_name_index
	}, 
	; 17
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554922, ; type_token_id
		i32 674; java_name_index
	}, 
	; 18
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554559, ; type_token_id
		i32 371; java_name_index
	}, 
	; 19
	%struct.TypeMapJava {
		i32 2, ; module_index
		i32 0, ; type_token_id
		i32 31; java_name_index
	}, 
	; 20
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554634, ; type_token_id
		i32 432; java_name_index
	}, 
	; 21
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554620, ; type_token_id
		i32 81; java_name_index
	}, 
	; 22
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554734, ; type_token_id
		i32 503; java_name_index
	}, 
	; 23
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554626, ; type_token_id
		i32 424; java_name_index
	}, 
	; 24
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554569, ; type_token_id
		i32 56; java_name_index
	}, 
	; 25
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554663, ; type_token_id
		i32 106; java_name_index
	}, 
	; 26
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554616, ; type_token_id
		i32 416; java_name_index
	}, 
	; 27
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554949, ; type_token_id
		i32 700; java_name_index
	}, 
	; 28
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 149; java_name_index
	}, 
	; 29
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 173; java_name_index
	}, 
	; 30
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 313; java_name_index
	}, 
	; 31
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554742, ; type_token_id
		i32 148; java_name_index
	}, 
	; 32
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554885, ; type_token_id
		i32 637; java_name_index
	}, 
	; 33
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33555073, ; type_token_id
		i32 320; java_name_index
	}, 
	; 34
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 252; java_name_index
	}, 
	; 35
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554555, ; type_token_id
		i32 368; java_name_index
	}, 
	; 36
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554773, ; type_token_id
		i32 539; java_name_index
	}, 
	; 37
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554789, ; type_token_id
		i32 555; java_name_index
	}, 
	; 38
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 0, ; type_token_id
		i32 732; java_name_index
	}, 
	; 39
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33555018, ; type_token_id
		i32 281; java_name_index
	}, 
	; 40
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554835, ; type_token_id
		i32 587; java_name_index
	}, 
	; 41
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554644, ; type_token_id
		i32 442; java_name_index
	}, 
	; 42
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554785, ; type_token_id
		i32 551; java_name_index
	}, 
	; 43
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554631, ; type_token_id
		i32 429; java_name_index
	}, 
	; 44
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554632, ; type_token_id
		i32 430; java_name_index
	}, 
	; 45
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554656, ; type_token_id
		i32 450; java_name_index
	}, 
	; 46
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554607, ; type_token_id
		i32 407; java_name_index
	}, 
	; 47
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 222; java_name_index
	}, 
	; 48
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554716, ; type_token_id
		i32 132; java_name_index
	}, 
	; 49
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554636, ; type_token_id
		i32 434; java_name_index
	}, 
	; 50
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554868, ; type_token_id
		i32 206; java_name_index
	}, 
	; 51
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 118; java_name_index
	}, 
	; 52
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554832, ; type_token_id
		i32 584; java_name_index
	}, 
	; 53
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554984, ; type_token_id
		i32 256; java_name_index
	}, 
	; 54
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33555058, ; type_token_id
		i32 310; java_name_index
	}, 
	; 55
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554627, ; type_token_id
		i32 425; java_name_index
	}, 
	; 56
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554775, ; type_token_id
		i32 172; java_name_index
	}, 
	; 57
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33555072, ; type_token_id
		i32 319; java_name_index
	}, 
	; 58
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554867, ; type_token_id
		i32 205; java_name_index
	}, 
	; 59
	%struct.TypeMapJava {
		i32 12, ; module_index
		i32 0, ; type_token_id
		i32 365; java_name_index
	}, 
	; 60
	%struct.TypeMapJava {
		i32 2, ; module_index
		i32 0, ; type_token_id
		i32 29; java_name_index
	}, 
	; 61
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 215; java_name_index
	}, 
	; 62
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554703, ; type_token_id
		i32 480; java_name_index
	}, 
	; 63
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554988, ; type_token_id
		i32 259; java_name_index
	}, 
	; 64
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554721, ; type_token_id
		i32 493; java_name_index
	}, 
	; 65
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 184; java_name_index
	}, 
	; 66
	%struct.TypeMapJava {
		i32 2, ; module_index
		i32 33554503, ; type_token_id
		i32 28; java_name_index
	}, 
	; 67
	%struct.TypeMapJava {
		i32 4, ; module_index
		i32 0, ; type_token_id
		i32 42; java_name_index
	}, 
	; 68
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554781, ; type_token_id
		i32 547; java_name_index
	}, 
	; 69
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554680, ; type_token_id
		i32 463; java_name_index
	}, 
	; 70
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554978, ; type_token_id
		i32 727; java_name_index
	}, 
	; 71
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554623, ; type_token_id
		i32 422; java_name_index
	}, 
	; 72
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554941, ; type_token_id
		i32 692; java_name_index
	}, 
	; 73
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554718, ; type_token_id
		i32 133; java_name_index
	}, 
	; 74
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554951, ; type_token_id
		i32 702; java_name_index
	}, 
	; 75
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554820, ; type_token_id
		i32 573; java_name_index
	}, 
	; 76
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554787, ; type_token_id
		i32 553; java_name_index
	}, 
	; 77
	%struct.TypeMapJava {
		i32 12, ; module_index
		i32 0, ; type_token_id
		i32 345; java_name_index
	}, 
	; 78
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33555083, ; type_token_id
		i32 326; java_name_index
	}, 
	; 79
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 249; java_name_index
	}, 
	; 80
	%struct.TypeMapJava {
		i32 2, ; module_index
		i32 0, ; type_token_id
		i32 23; java_name_index
	}, 
	; 81
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554989, ; type_token_id
		i32 260; java_name_index
	}, 
	; 82
	%struct.TypeMapJava {
		i32 15, ; module_index
		i32 33554444, ; type_token_id
		i32 742; java_name_index
	}, 
	; 83
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554729, ; type_token_id
		i32 499; java_name_index
	}, 
	; 84
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554719, ; type_token_id
		i32 491; java_name_index
	}, 
	; 85
	%struct.TypeMapJava {
		i32 6, ; module_index
		i32 33554447, ; type_token_id
		i32 46; java_name_index
	}, 
	; 86
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554770, ; type_token_id
		i32 536; java_name_index
	}, 
	; 87
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 0, ; type_token_id
		i32 488; java_name_index
	}, 
	; 88
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554726, ; type_token_id
		i32 496; java_name_index
	}, 
	; 89
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554942, ; type_token_id
		i32 693; java_name_index
	}, 
	; 90
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 171; java_name_index
	}, 
	; 91
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554837, ; type_token_id
		i32 589; java_name_index
	}, 
	; 92
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554662, ; type_token_id
		i32 105; java_name_index
	}, 
	; 93
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554971, ; type_token_id
		i32 720; java_name_index
	}, 
	; 94
	%struct.TypeMapJava {
		i32 4, ; module_index
		i32 33554471, ; type_token_id
		i32 39; java_name_index
	}, 
	; 95
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554637, ; type_token_id
		i32 91; java_name_index
	}, 
	; 96
	%struct.TypeMapJava {
		i32 1, ; module_index
		i32 33554436, ; type_token_id
		i32 3; java_name_index
	}, 
	; 97
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33555080, ; type_token_id
		i32 324; java_name_index
	}, 
	; 98
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554901, ; type_token_id
		i32 653; java_name_index
	}, 
	; 99
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554754, ; type_token_id
		i32 520; java_name_index
	}, 
	; 100
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554864, ; type_token_id
		i32 616; java_name_index
	}, 
	; 101
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554903, ; type_token_id
		i32 655; java_name_index
	}, 
	; 102
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554609, ; type_token_id
		i32 409; java_name_index
	}, 
	; 103
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554985, ; type_token_id
		i32 257; java_name_index
	}, 
	; 104
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 94; java_name_index
	}, 
	; 105
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554833, ; type_token_id
		i32 585; java_name_index
	}, 
	; 106
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554948, ; type_token_id
		i32 237; java_name_index
	}, 
	; 107
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554585, ; type_token_id
		i32 387; java_name_index
	}, 
	; 108
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 92; java_name_index
	}, 
	; 109
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33555070, ; type_token_id
		i32 317; java_name_index
	}, 
	; 110
	%struct.TypeMapJava {
		i32 2, ; module_index
		i32 33554484, ; type_token_id
		i32 15; java_name_index
	}, 
	; 111
	%struct.TypeMapJava {
		i32 15, ; module_index
		i32 0, ; type_token_id
		i32 738; java_name_index
	}, 
	; 112
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554620, ; type_token_id
		i32 420; java_name_index
	}, 
	; 113
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554579, ; type_token_id
		i32 382; java_name_index
	}, 
	; 114
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554976, ; type_token_id
		i32 725; java_name_index
	}, 
	; 115
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554683, ; type_token_id
		i32 119; java_name_index
	}, 
	; 116
	%struct.TypeMapJava {
		i32 4, ; module_index
		i32 0, ; type_token_id
		i32 40; java_name_index
	}, 
	; 117
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554886, ; type_token_id
		i32 638; java_name_index
	}, 
	; 118
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554898, ; type_token_id
		i32 210; java_name_index
	}, 
	; 119
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554920, ; type_token_id
		i32 672; java_name_index
	}, 
	; 120
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554806, ; type_token_id
		i32 188; java_name_index
	}, 
	; 121
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554860, ; type_token_id
		i32 612; java_name_index
	}, 
	; 122
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554719, ; type_token_id
		i32 134; java_name_index
	}, 
	; 123
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554586, ; type_token_id
		i32 388; java_name_index
	}, 
	; 124
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 90; java_name_index
	}, 
	; 125
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 248; java_name_index
	}, 
	; 126
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554853, ; type_token_id
		i32 605; java_name_index
	}, 
	; 127
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554784, ; type_token_id
		i32 177; java_name_index
	}, 
	; 128
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554888, ; type_token_id
		i32 640; java_name_index
	}, 
	; 129
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554569, ; type_token_id
		i32 378; java_name_index
	}, 
	; 130
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554839, ; type_token_id
		i32 591; java_name_index
	}, 
	; 131
	%struct.TypeMapJava {
		i32 10, ; module_index
		i32 33554441, ; type_token_id
		i32 336; java_name_index
	}, 
	; 132
	%struct.TypeMapJava {
		i32 12, ; module_index
		i32 33554499, ; type_token_id
		i32 352; java_name_index
	}, 
	; 133
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33555088, ; type_token_id
		i32 329; java_name_index
	}, 
	; 134
	%struct.TypeMapJava {
		i32 12, ; module_index
		i32 33554526, ; type_token_id
		i32 367; java_name_index
	}, 
	; 135
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554601, ; type_token_id
		i32 69; java_name_index
	}, 
	; 136
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 187; java_name_index
	}, 
	; 137
	%struct.TypeMapJava {
		i32 2, ; module_index
		i32 33554492, ; type_token_id
		i32 20; java_name_index
	}, 
	; 138
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554633, ; type_token_id
		i32 431; java_name_index
	}, 
	; 139
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 141; java_name_index
	}, 
	; 140
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554952, ; type_token_id
		i32 703; java_name_index
	}, 
	; 141
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554841, ; type_token_id
		i32 593; java_name_index
	}, 
	; 142
	%struct.TypeMapJava {
		i32 12, ; module_index
		i32 33554474, ; type_token_id
		i32 339; java_name_index
	}, 
	; 143
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554855, ; type_token_id
		i32 607; java_name_index
	}, 
	; 144
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554861, ; type_token_id
		i32 613; java_name_index
	}, 
	; 145
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554830, ; type_token_id
		i32 582; java_name_index
	}, 
	; 146
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554822, ; type_token_id
		i32 198; java_name_index
	}, 
	; 147
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554987, ; type_token_id
		i32 258; java_name_index
	}, 
	; 148
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554904, ; type_token_id
		i32 656; java_name_index
	}, 
	; 149
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 89; java_name_index
	}, 
	; 150
	%struct.TypeMapJava {
		i32 12, ; module_index
		i32 0, ; type_token_id
		i32 356; java_name_index
	}, 
	; 151
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554842, ; type_token_id
		i32 594; java_name_index
	}, 
	; 152
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554751, ; type_token_id
		i32 156; java_name_index
	}, 
	; 153
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554981, ; type_token_id
		i32 730; java_name_index
	}, 
	; 154
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554608, ; type_token_id
		i32 408; java_name_index
	}, 
	; 155
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554929, ; type_token_id
		i32 681; java_name_index
	}, 
	; 156
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554898, ; type_token_id
		i32 650; java_name_index
	}, 
	; 157
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554924, ; type_token_id
		i32 676; java_name_index
	}, 
	; 158
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554567, ; type_token_id
		i32 376; java_name_index
	}, 
	; 159
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554891, ; type_token_id
		i32 643; java_name_index
	}, 
	; 160
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 93; java_name_index
	}, 
	; 161
	%struct.TypeMapJava {
		i32 2, ; module_index
		i32 0, ; type_token_id
		i32 25; java_name_index
	}, 
	; 162
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 76; java_name_index
	}, 
	; 163
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554739, ; type_token_id
		i32 146; java_name_index
	}, 
	; 164
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554993, ; type_token_id
		i32 263; java_name_index
	}, 
	; 165
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554752, ; type_token_id
		i32 157; java_name_index
	}, 
	; 166
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554562, ; type_token_id
		i32 52; java_name_index
	}, 
	; 167
	%struct.TypeMapJava {
		i32 15, ; module_index
		i32 0, ; type_token_id
		i32 741; java_name_index
	}, 
	; 168
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554777, ; type_token_id
		i32 543; java_name_index
	}, 
	; 169
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 123; java_name_index
	}, 
	; 170
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554757, ; type_token_id
		i32 523; java_name_index
	}, 
	; 171
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554715, ; type_token_id
		i32 131; java_name_index
	}, 
	; 172
	%struct.TypeMapJava {
		i32 12, ; module_index
		i32 0, ; type_token_id
		i32 348; java_name_index
	}, 
	; 173
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554746, ; type_token_id
		i32 514; java_name_index
	}, 
	; 174
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554657, ; type_token_id
		i32 451; java_name_index
	}, 
	; 175
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 140; java_name_index
	}, 
	; 176
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554630, ; type_token_id
		i32 428; java_name_index
	}, 
	; 177
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 0, ; type_token_id
		i32 495; java_name_index
	}, 
	; 178
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33555009, ; type_token_id
		i32 274; java_name_index
	}, 
	; 179
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554740, ; type_token_id
		i32 147; java_name_index
	}, 
	; 180
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 236; java_name_index
	}, 
	; 181
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554790, ; type_token_id
		i32 179; java_name_index
	}, 
	; 182
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554784, ; type_token_id
		i32 550; java_name_index
	}, 
	; 183
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554958, ; type_token_id
		i32 708; java_name_index
	}, 
	; 184
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554991, ; type_token_id
		i32 262; java_name_index
	}, 
	; 185
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554906, ; type_token_id
		i32 658; java_name_index
	}, 
	; 186
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 67; java_name_index
	}, 
	; 187
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554900, ; type_token_id
		i32 652; java_name_index
	}, 
	; 188
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554587, ; type_token_id
		i32 66; java_name_index
	}, 
	; 189
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 80; java_name_index
	}, 
	; 190
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 103; java_name_index
	}, 
	; 191
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 0, ; type_token_id
		i32 462; java_name_index
	}, 
	; 192
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 87; java_name_index
	}, 
	; 193
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33555052, ; type_token_id
		i32 305; java_name_index
	}, 
	; 194
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554567, ; type_token_id
		i32 55; java_name_index
	}, 
	; 195
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554788, ; type_token_id
		i32 554; java_name_index
	}, 
	; 196
	%struct.TypeMapJava {
		i32 12, ; module_index
		i32 33554512, ; type_token_id
		i32 359; java_name_index
	}, 
	; 197
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554760, ; type_token_id
		i32 526; java_name_index
	}, 
	; 198
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 86; java_name_index
	}, 
	; 199
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554944, ; type_token_id
		i32 695; java_name_index
	}, 
	; 200
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 0, ; type_token_id
		i32 707; java_name_index
	}, 
	; 201
	%struct.TypeMapJava {
		i32 12, ; module_index
		i32 33554475, ; type_token_id
		i32 340; java_name_index
	}, 
	; 202
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554829, ; type_token_id
		i32 581; java_name_index
	}, 
	; 203
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554881, ; type_token_id
		i32 633; java_name_index
	}, 
	; 204
	%struct.TypeMapJava {
		i32 15, ; module_index
		i32 33554441, ; type_token_id
		i32 740; java_name_index
	}, 
	; 205
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554963, ; type_token_id
		i32 712; java_name_index
	}, 
	; 206
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 0, ; type_token_id
		i32 487; java_name_index
	}, 
	; 207
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554854, ; type_token_id
		i32 606; java_name_index
	}, 
	; 208
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554849, ; type_token_id
		i32 601; java_name_index
	}, 
	; 209
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 315; java_name_index
	}, 
	; 210
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33555017, ; type_token_id
		i32 280; java_name_index
	}, 
	; 211
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554960, ; type_token_id
		i32 244; java_name_index
	}, 
	; 212
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554848, ; type_token_id
		i32 600; java_name_index
	}, 
	; 213
	%struct.TypeMapJava {
		i32 12, ; module_index
		i32 0, ; type_token_id
		i32 363; java_name_index
	}, 
	; 214
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554624, ; type_token_id
		i32 423; java_name_index
	}, 
	; 215
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554843, ; type_token_id
		i32 595; java_name_index
	}, 
	; 216
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554909, ; type_token_id
		i32 661; java_name_index
	}, 
	; 217
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554611, ; type_token_id
		i32 411; java_name_index
	}, 
	; 218
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 170; java_name_index
	}, 
	; 219
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554779, ; type_token_id
		i32 545; java_name_index
	}, 
	; 220
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554815, ; type_token_id
		i32 570; java_name_index
	}, 
	; 221
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554834, ; type_token_id
		i32 586; java_name_index
	}, 
	; 222
	%struct.TypeMapJava {
		i32 0, ; module_index
		i32 0, ; type_token_id
		i32 1; java_name_index
	}, 
	; 223
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554801, ; type_token_id
		i32 563; java_name_index
	}, 
	; 224
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554599, ; type_token_id
		i32 399; java_name_index
	}, 
	; 225
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33555000, ; type_token_id
		i32 269; java_name_index
	}, 
	; 226
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554642, ; type_token_id
		i32 440; java_name_index
	}, 
	; 227
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554810, ; type_token_id
		i32 566; java_name_index
	}, 
	; 228
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554702, ; type_token_id
		i32 479; java_name_index
	}, 
	; 229
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554612, ; type_token_id
		i32 412; java_name_index
	}, 
	; 230
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554951, ; type_token_id
		i32 239; java_name_index
	}, 
	; 231
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554917, ; type_token_id
		i32 220; java_name_index
	}, 
	; 232
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554821, ; type_token_id
		i32 197; java_name_index
	}, 
	; 233
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554607, ; type_token_id
		i32 73; java_name_index
	}, 
	; 234
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554690, ; type_token_id
		i32 471; java_name_index
	}, 
	; 235
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554704, ; type_token_id
		i32 125; java_name_index
	}, 
	; 236
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554605, ; type_token_id
		i32 405; java_name_index
	}, 
	; 237
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 75; java_name_index
	}, 
	; 238
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554899, ; type_token_id
		i32 651; java_name_index
	}, 
	; 239
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554564, ; type_token_id
		i32 53; java_name_index
	}, 
	; 240
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33555015, ; type_token_id
		i32 279; java_name_index
	}, 
	; 241
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554588, ; type_token_id
		i32 390; java_name_index
	}, 
	; 242
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554769, ; type_token_id
		i32 535; java_name_index
	}, 
	; 243
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554683, ; type_token_id
		i32 466; java_name_index
	}, 
	; 244
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554947, ; type_token_id
		i32 698; java_name_index
	}, 
	; 245
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554763, ; type_token_id
		i32 529; java_name_index
	}, 
	; 246
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554757, ; type_token_id
		i32 162; java_name_index
	}, 
	; 247
	%struct.TypeMapJava {
		i32 2, ; module_index
		i32 33554502, ; type_token_id
		i32 27; java_name_index
	}, 
	; 248
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554616, ; type_token_id
		i32 79; java_name_index
	}, 
	; 249
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 176; java_name_index
	}, 
	; 250
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554790, ; type_token_id
		i32 556; java_name_index
	}, 
	; 251
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554651, ; type_token_id
		i32 445; java_name_index
	}, 
	; 252
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554851, ; type_token_id
		i32 603; java_name_index
	}, 
	; 253
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554972, ; type_token_id
		i32 721; java_name_index
	}, 
	; 254
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554918, ; type_token_id
		i32 670; java_name_index
	}, 
	; 255
	%struct.TypeMapJava {
		i32 6, ; module_index
		i32 0, ; type_token_id
		i32 48; java_name_index
	}, 
	; 256
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554735, ; type_token_id
		i32 145; java_name_index
	}, 
	; 257
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554652, ; type_token_id
		i32 99; java_name_index
	}, 
	; 258
	%struct.TypeMapJava {
		i32 2, ; module_index
		i32 33554473, ; type_token_id
		i32 11; java_name_index
	}, 
	; 259
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554931, ; type_token_id
		i32 683; java_name_index
	}, 
	; 260
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554619, ; type_token_id
		i32 419; java_name_index
	}, 
	; 261
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554624, ; type_token_id
		i32 84; java_name_index
	}, 
	; 262
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554893, ; type_token_id
		i32 645; java_name_index
	}, 
	; 263
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554648, ; type_token_id
		i32 444; java_name_index
	}, 
	; 264
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554915, ; type_token_id
		i32 667; java_name_index
	}, 
	; 265
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 0, ; type_token_id
		i32 474; java_name_index
	}, 
	; 266
	%struct.TypeMapJava {
		i32 12, ; module_index
		i32 0, ; type_token_id
		i32 360; java_name_index
	}, 
	; 267
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554838, ; type_token_id
		i32 590; java_name_index
	}, 
	; 268
	%struct.TypeMapJava {
		i32 4, ; module_index
		i32 33554470, ; type_token_id
		i32 38; java_name_index
	}, 
	; 269
	%struct.TypeMapJava {
		i32 0, ; module_index
		i32 33554461, ; type_token_id
		i32 2; java_name_index
	}, 
	; 270
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554938, ; type_token_id
		i32 690; java_name_index
	}, 
	; 271
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 59; java_name_index
	}, 
	; 272
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554568, ; type_token_id
		i32 377; java_name_index
	}, 
	; 273
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 120; java_name_index
	}, 
	; 274
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554895, ; type_token_id
		i32 647; java_name_index
	}, 
	; 275
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554737, ; type_token_id
		i32 505; java_name_index
	}, 
	; 276
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554665, ; type_token_id
		i32 108; java_name_index
	}, 
	; 277
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554587, ; type_token_id
		i32 389; java_name_index
	}, 
	; 278
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554846, ; type_token_id
		i32 598; java_name_index
	}, 
	; 279
	%struct.TypeMapJava {
		i32 12, ; module_index
		i32 33554494, ; type_token_id
		i32 349; java_name_index
	}, 
	; 280
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554887, ; type_token_id
		i32 639; java_name_index
	}, 
	; 281
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554965, ; type_token_id
		i32 714; java_name_index
	}, 
	; 282
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554767, ; type_token_id
		i32 533; java_name_index
	}, 
	; 283
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554733, ; type_token_id
		i32 502; java_name_index
	}, 
	; 284
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554782, ; type_token_id
		i32 548; java_name_index
	}, 
	; 285
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554695, ; type_token_id
		i32 475; java_name_index
	}, 
	; 286
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 142; java_name_index
	}, 
	; 287
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554720, ; type_token_id
		i32 135; java_name_index
	}, 
	; 288
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554672, ; type_token_id
		i32 458; java_name_index
	}, 
	; 289
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 323; java_name_index
	}, 
	; 290
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554681, ; type_token_id
		i32 464; java_name_index
	}, 
	; 291
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554836, ; type_token_id
		i32 588; java_name_index
	}, 
	; 292
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 312; java_name_index
	}, 
	; 293
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554658, ; type_token_id
		i32 452; java_name_index
	}, 
	; 294
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33555071, ; type_token_id
		i32 318; java_name_index
	}, 
	; 295
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554988, ; type_token_id
		i32 736; java_name_index
	}, 
	; 296
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554823, ; type_token_id
		i32 576; java_name_index
	}, 
	; 297
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 0, ; type_token_id
		i32 504; java_name_index
	}, 
	; 298
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 0, ; type_token_id
		i32 443; java_name_index
	}, 
	; 299
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554753, ; type_token_id
		i32 519; java_name_index
	}, 
	; 300
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554649, ; type_token_id
		i32 97; java_name_index
	}, 
	; 301
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 0, ; type_token_id
		i32 516; java_name_index
	}, 
	; 302
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554896, ; type_token_id
		i32 648; java_name_index
	}, 
	; 303
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554935, ; type_token_id
		i32 687; java_name_index
	}, 
	; 304
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33555082, ; type_token_id
		i32 325; java_name_index
	}, 
	; 305
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554638, ; type_token_id
		i32 436; java_name_index
	}, 
	; 306
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33555008, ; type_token_id
		i32 273; java_name_index
	}, 
	; 307
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554603, ; type_token_id
		i32 403; java_name_index
	}, 
	; 308
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554817, ; type_token_id
		i32 571; java_name_index
	}, 
	; 309
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554878, ; type_token_id
		i32 630; java_name_index
	}, 
	; 310
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554764, ; type_token_id
		i32 530; java_name_index
	}, 
	; 311
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554854, ; type_token_id
		i32 202; java_name_index
	}, 
	; 312
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554879, ; type_token_id
		i32 631; java_name_index
	}, 
	; 313
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554814, ; type_token_id
		i32 569; java_name_index
	}, 
	; 314
	%struct.TypeMapJava {
		i32 12, ; module_index
		i32 33554511, ; type_token_id
		i32 358; java_name_index
	}, 
	; 315
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 85; java_name_index
	}, 
	; 316
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554597, ; type_token_id
		i32 397; java_name_index
	}, 
	; 317
	%struct.TypeMapJava {
		i32 12, ; module_index
		i32 33554516, ; type_token_id
		i32 361; java_name_index
	}, 
	; 318
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554982, ; type_token_id
		i32 255; java_name_index
	}, 
	; 319
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 0, ; type_token_id
		i32 564; java_name_index
	}, 
	; 320
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554572, ; type_token_id
		i32 379; java_name_index
	}, 
	; 321
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 223; java_name_index
	}, 
	; 322
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554774, ; type_token_id
		i32 540; java_name_index
	}, 
	; 323
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554905, ; type_token_id
		i32 657; java_name_index
	}, 
	; 324
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554705, ; type_token_id
		i32 482; java_name_index
	}, 
	; 325
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554923, ; type_token_id
		i32 675; java_name_index
	}, 
	; 326
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33555031, ; type_token_id
		i32 288; java_name_index
	}, 
	; 327
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554964, ; type_token_id
		i32 713; java_name_index
	}, 
	; 328
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554919, ; type_token_id
		i32 671; java_name_index
	}, 
	; 329
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 139; java_name_index
	}, 
	; 330
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554615, ; type_token_id
		i32 415; java_name_index
	}, 
	; 331
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554795, ; type_token_id
		i32 182; java_name_index
	}, 
	; 332
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554765, ; type_token_id
		i32 531; java_name_index
	}, 
	; 333
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554870, ; type_token_id
		i32 622; java_name_index
	}, 
	; 334
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554561, ; type_token_id
		i32 373; java_name_index
	}, 
	; 335
	%struct.TypeMapJava {
		i32 2, ; module_index
		i32 33554469, ; type_token_id
		i32 9; java_name_index
	}, 
	; 336
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554850, ; type_token_id
		i32 602; java_name_index
	}, 
	; 337
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 0, ; type_token_id
		i32 486; java_name_index
	}, 
	; 338
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 292; java_name_index
	}, 
	; 339
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554954, ; type_token_id
		i32 705; java_name_index
	}, 
	; 340
	%struct.TypeMapJava {
		i32 2, ; module_index
		i32 0, ; type_token_id
		i32 8; java_name_index
	}, 
	; 341
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554862, ; type_token_id
		i32 614; java_name_index
	}, 
	; 342
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 88; java_name_index
	}, 
	; 343
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 112; java_name_index
	}, 
	; 344
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554785, ; type_token_id
		i32 178; java_name_index
	}, 
	; 345
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554871, ; type_token_id
		i32 623; java_name_index
	}, 
	; 346
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554928, ; type_token_id
		i32 680; java_name_index
	}, 
	; 347
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554819, ; type_token_id
		i32 195; java_name_index
	}, 
	; 348
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 104; java_name_index
	}, 
	; 349
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554910, ; type_token_id
		i32 662; java_name_index
	}, 
	; 350
	%struct.TypeMapJava {
		i32 12, ; module_index
		i32 33554525, ; type_token_id
		i32 366; java_name_index
	}, 
	; 351
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554641, ; type_token_id
		i32 439; java_name_index
	}, 
	; 352
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554617, ; type_token_id
		i32 417; java_name_index
	}, 
	; 353
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33555006, ; type_token_id
		i32 271; java_name_index
	}, 
	; 354
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554656, ; type_token_id
		i32 102; java_name_index
	}, 
	; 355
	%struct.TypeMapJava {
		i32 2, ; module_index
		i32 33554465, ; type_token_id
		i32 7; java_name_index
	}, 
	; 356
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554980, ; type_token_id
		i32 729; java_name_index
	}, 
	; 357
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554665, ; type_token_id
		i32 455; java_name_index
	}, 
	; 358
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554868, ; type_token_id
		i32 620; java_name_index
	}, 
	; 359
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554575, ; type_token_id
		i32 381; java_name_index
	}, 
	; 360
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554916, ; type_token_id
		i32 668; java_name_index
	}, 
	; 361
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554755, ; type_token_id
		i32 160; java_name_index
	}, 
	; 362
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554934, ; type_token_id
		i32 686; java_name_index
	}, 
	; 363
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554899, ; type_token_id
		i32 211; java_name_index
	}, 
	; 364
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 58; java_name_index
	}, 
	; 365
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554677, ; type_token_id
		i32 115; java_name_index
	}, 
	; 366
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554943, ; type_token_id
		i32 694; java_name_index
	}, 
	; 367
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554865, ; type_token_id
		i32 617; java_name_index
	}, 
	; 368
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 233; java_name_index
	}, 
	; 369
	%struct.TypeMapJava {
		i32 12, ; module_index
		i32 33554489, ; type_token_id
		i32 346; java_name_index
	}, 
	; 370
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554827, ; type_token_id
		i32 579; java_name_index
	}, 
	; 371
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 0, ; type_token_id
		i32 489; java_name_index
	}, 
	; 372
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554763, ; type_token_id
		i32 166; java_name_index
	}, 
	; 373
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 138; java_name_index
	}, 
	; 374
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554748, ; type_token_id
		i32 153; java_name_index
	}, 
	; 375
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554960, ; type_token_id
		i32 709; java_name_index
	}, 
	; 376
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 0, ; type_token_id
		i32 393; java_name_index
	}, 
	; 377
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554614, ; type_token_id
		i32 78; java_name_index
	}, 
	; 378
	%struct.TypeMapJava {
		i32 2, ; module_index
		i32 0, ; type_token_id
		i32 10; java_name_index
	}, 
	; 379
	%struct.TypeMapJava {
		i32 3, ; module_index
		i32 0, ; type_token_id
		i32 32; java_name_index
	}, 
	; 380
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33555011, ; type_token_id
		i32 276; java_name_index
	}, 
	; 381
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 231; java_name_index
	}, 
	; 382
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554659, ; type_token_id
		i32 453; java_name_index
	}, 
	; 383
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554703, ; type_token_id
		i32 124; java_name_index
	}, 
	; 384
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33555054, ; type_token_id
		i32 306; java_name_index
	}, 
	; 385
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 0, ; type_token_id
		i32 517; java_name_index
	}, 
	; 386
	%struct.TypeMapJava {
		i32 4, ; module_index
		i32 33554478, ; type_token_id
		i32 43; java_name_index
	}, 
	; 387
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554883, ; type_token_id
		i32 635; java_name_index
	}, 
	; 388
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554962, ; type_token_id
		i32 711; java_name_index
	}, 
	; 389
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554999, ; type_token_id
		i32 268; java_name_index
	}, 
	; 390
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554679, ; type_token_id
		i32 116; java_name_index
	}, 
	; 391
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554558, ; type_token_id
		i32 370; java_name_index
	}, 
	; 392
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554890, ; type_token_id
		i32 642; java_name_index
	}, 
	; 393
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554786, ; type_token_id
		i32 552; java_name_index
	}, 
	; 394
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33555039, ; type_token_id
		i32 295; java_name_index
	}, 
	; 395
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33555046, ; type_token_id
		i32 301; java_name_index
	}, 
	; 396
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554780, ; type_token_id
		i32 174; java_name_index
	}, 
	; 397
	%struct.TypeMapJava {
		i32 2, ; module_index
		i32 0, ; type_token_id
		i32 19; java_name_index
	}, 
	; 398
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 327; java_name_index
	}, 
	; 399
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33555037, ; type_token_id
		i32 293; java_name_index
	}, 
	; 400
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554783, ; type_token_id
		i32 549; java_name_index
	}, 
	; 401
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33555040, ; type_token_id
		i32 296; java_name_index
	}, 
	; 402
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554966, ; type_token_id
		i32 715; java_name_index
	}, 
	; 403
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554745, ; type_token_id
		i32 513; java_name_index
	}, 
	; 404
	%struct.TypeMapJava {
		i32 2, ; module_index
		i32 0, ; type_token_id
		i32 14; java_name_index
	}, 
	; 405
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 251; java_name_index
	}, 
	; 406
	%struct.TypeMapJava {
		i32 4, ; module_index
		i32 33554468, ; type_token_id
		i32 36; java_name_index
	}, 
	; 407
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554908, ; type_token_id
		i32 660; java_name_index
	}, 
	; 408
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554973, ; type_token_id
		i32 722; java_name_index
	}, 
	; 409
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554674, ; type_token_id
		i32 460; java_name_index
	}, 
	; 410
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554594, ; type_token_id
		i32 395; java_name_index
	}, 
	; 411
	%struct.TypeMapJava {
		i32 15, ; module_index
		i32 0, ; type_token_id
		i32 739; java_name_index
	}, 
	; 412
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554975, ; type_token_id
		i32 724; java_name_index
	}, 
	; 413
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33555038, ; type_token_id
		i32 294; java_name_index
	}, 
	; 414
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554752, ; type_token_id
		i32 518; java_name_index
	}, 
	; 415
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554556, ; type_token_id
		i32 369; java_name_index
	}, 
	; 416
	%struct.TypeMapJava {
		i32 1, ; module_index
		i32 0, ; type_token_id
		i32 5; java_name_index
	}, 
	; 417
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554927, ; type_token_id
		i32 679; java_name_index
	}, 
	; 418
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554675, ; type_token_id
		i32 461; java_name_index
	}, 
	; 419
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554987, ; type_token_id
		i32 735; java_name_index
	}, 
	; 420
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554676, ; type_token_id
		i32 114; java_name_index
	}, 
	; 421
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 62; java_name_index
	}, 
	; 422
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 98; java_name_index
	}, 
	; 423
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554628, ; type_token_id
		i32 426; java_name_index
	}, 
	; 424
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33555057, ; type_token_id
		i32 309; java_name_index
	}, 
	; 425
	%struct.TypeMapJava {
		i32 2, ; module_index
		i32 33554507, ; type_token_id
		i32 30; java_name_index
	}, 
	; 426
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554818, ; type_token_id
		i32 194; java_name_index
	}, 
	; 427
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554866, ; type_token_id
		i32 618; java_name_index
	}, 
	; 428
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33555047, ; type_token_id
		i32 302; java_name_index
	}, 
	; 429
	%struct.TypeMapJava {
		i32 12, ; module_index
		i32 0, ; type_token_id
		i32 347; java_name_index
	}, 
	; 430
	%struct.TypeMapJava {
		i32 4, ; module_index
		i32 33554469, ; type_token_id
		i32 37; java_name_index
	}, 
	; 431
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 68; java_name_index
	}, 
	; 432
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554767, ; type_token_id
		i32 168; java_name_index
	}, 
	; 433
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554892, ; type_token_id
		i32 644; java_name_index
	}, 
	; 434
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554857, ; type_token_id
		i32 609; java_name_index
	}, 
	; 435
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 0, ; type_token_id
		i32 384; java_name_index
	}, 
	; 436
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 286; java_name_index
	}, 
	; 437
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554561, ; type_token_id
		i32 51; java_name_index
	}, 
	; 438
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554914, ; type_token_id
		i32 218; java_name_index
	}, 
	; 439
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554900, ; type_token_id
		i32 212; java_name_index
	}, 
	; 440
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554985, ; type_token_id
		i32 733; java_name_index
	}, 
	; 441
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33555003, ; type_token_id
		i32 270; java_name_index
	}, 
	; 442
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554718, ; type_token_id
		i32 490; java_name_index
	}, 
	; 443
	%struct.TypeMapJava {
		i32 5, ; module_index
		i32 33554448, ; type_token_id
		i32 45; java_name_index
	}, 
	; 444
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554761, ; type_token_id
		i32 527; java_name_index
	}, 
	; 445
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554722, ; type_token_id
		i32 137; java_name_index
	}, 
	; 446
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 254; java_name_index
	}, 
	; 447
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554760, ; type_token_id
		i32 165; java_name_index
	}, 
	; 448
	%struct.TypeMapJava {
		i32 12, ; module_index
		i32 0, ; type_token_id
		i32 341; java_name_index
	}, 
	; 449
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554635, ; type_token_id
		i32 433; java_name_index
	}, 
	; 450
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554796, ; type_token_id
		i32 562; java_name_index
	}, 
	; 451
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554699, ; type_token_id
		i32 122; java_name_index
	}, 
	; 452
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 213; java_name_index
	}, 
	; 453
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554613, ; type_token_id
		i32 413; java_name_index
	}, 
	; 454
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554584, ; type_token_id
		i32 64; java_name_index
	}, 
	; 455
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554768, ; type_token_id
		i32 534; java_name_index
	}, 
	; 456
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 224; java_name_index
	}, 
	; 457
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554791, ; type_token_id
		i32 557; java_name_index
	}, 
	; 458
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 287; java_name_index
	}, 
	; 459
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554930, ; type_token_id
		i32 682; java_name_index
	}, 
	; 460
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554602, ; type_token_id
		i32 402; java_name_index
	}, 
	; 461
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33555055, ; type_token_id
		i32 307; java_name_index
	}, 
	; 462
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 200; java_name_index
	}, 
	; 463
	%struct.TypeMapJava {
		i32 12, ; module_index
		i32 33554479, ; type_token_id
		i32 342; java_name_index
	}, 
	; 464
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554970, ; type_token_id
		i32 719; java_name_index
	}, 
	; 465
	%struct.TypeMapJava {
		i32 12, ; module_index
		i32 0, ; type_token_id
		i32 343; java_name_index
	}, 
	; 466
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 0, ; type_token_id
		i32 501; java_name_index
	}, 
	; 467
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554889, ; type_token_id
		i32 641; java_name_index
	}, 
	; 468
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554974, ; type_token_id
		i32 723; java_name_index
	}, 
	; 469
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554863, ; type_token_id
		i32 203; java_name_index
	}, 
	; 470
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554811, ; type_token_id
		i32 567; java_name_index
	}, 
	; 471
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554949, ; type_token_id
		i32 238; java_name_index
	}, 
	; 472
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 253; java_name_index
	}, 
	; 473
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554776, ; type_token_id
		i32 542; java_name_index
	}, 
	; 474
	%struct.TypeMapJava {
		i32 12, ; module_index
		i32 33554500, ; type_token_id
		i32 353; java_name_index
	}, 
	; 475
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 230; java_name_index
	}, 
	; 476
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554940, ; type_token_id
		i32 232; java_name_index
	}, 
	; 477
	%struct.TypeMapJava {
		i32 12, ; module_index
		i32 33554505, ; type_token_id
		i32 355; java_name_index
	}, 
	; 478
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554762, ; type_token_id
		i32 528; java_name_index
	}, 
	; 479
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554911, ; type_token_id
		i32 663; java_name_index
	}, 
	; 480
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554876, ; type_token_id
		i32 628; java_name_index
	}, 
	; 481
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554666, ; type_token_id
		i32 109; java_name_index
	}, 
	; 482
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554912, ; type_token_id
		i32 664; java_name_index
	}, 
	; 483
	%struct.TypeMapJava {
		i32 8, ; module_index
		i32 33554434, ; type_token_id
		i32 333; java_name_index
	}, 
	; 484
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554606, ; type_token_id
		i32 72; java_name_index
	}, 
	; 485
	%struct.TypeMapJava {
		i32 12, ; module_index
		i32 0, ; type_token_id
		i32 354; java_name_index
	}, 
	; 486
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554769, ; type_token_id
		i32 169; java_name_index
	}, 
	; 487
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554793, ; type_token_id
		i32 181; java_name_index
	}, 
	; 488
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33555013, ; type_token_id
		i32 277; java_name_index
	}, 
	; 489
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554926, ; type_token_id
		i32 678; java_name_index
	}, 
	; 490
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554584, ; type_token_id
		i32 386; java_name_index
	}, 
	; 491
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554580, ; type_token_id
		i32 383; java_name_index
	}, 
	; 492
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554600, ; type_token_id
		i32 400; java_name_index
	}, 
	; 493
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 183; java_name_index
	}, 
	; 494
	%struct.TypeMapJava {
		i32 2, ; module_index
		i32 0, ; type_token_id
		i32 13; java_name_index
	}, 
	; 495
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554639, ; type_token_id
		i32 437; java_name_index
	}, 
	; 496
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554758, ; type_token_id
		i32 524; java_name_index
	}, 
	; 497
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33555033, ; type_token_id
		i32 290; java_name_index
	}, 
	; 498
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554820, ; type_token_id
		i32 196; java_name_index
	}, 
	; 499
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554730, ; type_token_id
		i32 500; java_name_index
	}, 
	; 500
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554733, ; type_token_id
		i32 143; java_name_index
	}, 
	; 501
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554917, ; type_token_id
		i32 669; java_name_index
	}, 
	; 502
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33555032, ; type_token_id
		i32 289; java_name_index
	}, 
	; 503
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554845, ; type_token_id
		i32 597; java_name_index
	}, 
	; 504
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554919, ; type_token_id
		i32 221; java_name_index
	}, 
	; 505
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33555041, ; type_token_id
		i32 297; java_name_index
	}, 
	; 506
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 240; java_name_index
	}, 
	; 507
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554740, ; type_token_id
		i32 508; java_name_index
	}, 
	; 508
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554560, ; type_token_id
		i32 372; java_name_index
	}, 
	; 509
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 322; java_name_index
	}, 
	; 510
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554939, ; type_token_id
		i32 691; java_name_index
	}, 
	; 511
	%struct.TypeMapJava {
		i32 1, ; module_index
		i32 33554437, ; type_token_id
		i32 4; java_name_index
	}, 
	; 512
	%struct.TypeMapJava {
		i32 2, ; module_index
		i32 33554493, ; type_token_id
		i32 21; java_name_index
	}, 
	; 513
	%struct.TypeMapJava {
		i32 2, ; module_index
		i32 33554487, ; type_token_id
		i32 17; java_name_index
	}, 
	; 514
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33555034, ; type_token_id
		i32 291; java_name_index
	}, 
	; 515
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 126; java_name_index
	}, 
	; 516
	%struct.TypeMapJava {
		i32 12, ; module_index
		i32 33554495, ; type_token_id
		i32 350; java_name_index
	}, 
	; 517
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554996, ; type_token_id
		i32 265; java_name_index
	}, 
	; 518
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554655, ; type_token_id
		i32 449; java_name_index
	}, 
	; 519
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554967, ; type_token_id
		i32 716; java_name_index
	}, 
	; 520
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 101; java_name_index
	}, 
	; 521
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554692, ; type_token_id
		i32 473; java_name_index
	}, 
	; 522
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 228; java_name_index
	}, 
	; 523
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554847, ; type_token_id
		i32 599; java_name_index
	}, 
	; 524
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554859, ; type_token_id
		i32 611; java_name_index
	}, 
	; 525
	%struct.TypeMapJava {
		i32 0, ; module_index
		i32 33554454, ; type_token_id
		i32 0; java_name_index
	}, 
	; 526
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554606, ; type_token_id
		i32 406; java_name_index
	}, 
	; 527
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554701, ; type_token_id
		i32 478; java_name_index
	}, 
	; 528
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554875, ; type_token_id
		i32 627; java_name_index
	}, 
	; 529
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554812, ; type_token_id
		i32 568; java_name_index
	}, 
	; 530
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554897, ; type_token_id
		i32 649; java_name_index
	}, 
	; 531
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554792, ; type_token_id
		i32 180; java_name_index
	}, 
	; 532
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554608, ; type_token_id
		i32 74; java_name_index
	}, 
	; 533
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554756, ; type_token_id
		i32 161; java_name_index
	}, 
	; 534
	%struct.TypeMapJava {
		i32 14, ; module_index
		i32 0, ; type_token_id
		i32 737; java_name_index
	}, 
	; 535
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 0, ; type_token_id
		i32 380; java_name_index
	}, 
	; 536
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 95; java_name_index
	}, 
	; 537
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33555115, ; type_token_id
		i32 332; java_name_index
	}, 
	; 538
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554925, ; type_token_id
		i32 677; java_name_index
	}, 
	; 539
	%struct.TypeMapJava {
		i32 12, ; module_index
		i32 0, ; type_token_id
		i32 364; java_name_index
	}, 
	; 540
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554673, ; type_token_id
		i32 459; java_name_index
	}, 
	; 541
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554759, ; type_token_id
		i32 164; java_name_index
	}, 
	; 542
	%struct.TypeMapJava {
		i32 6, ; module_index
		i32 33554452, ; type_token_id
		i32 49; java_name_index
	}, 
	; 543
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554954, ; type_token_id
		i32 241; java_name_index
	}, 
	; 544
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554807, ; type_token_id
		i32 189; java_name_index
	}, 
	; 545
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554566, ; type_token_id
		i32 54; java_name_index
	}, 
	; 546
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554640, ; type_token_id
		i32 438; java_name_index
	}, 
	; 547
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554711, ; type_token_id
		i32 128; java_name_index
	}, 
	; 548
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554826, ; type_token_id
		i32 578; java_name_index
	}, 
	; 549
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554921, ; type_token_id
		i32 673; java_name_index
	}, 
	; 550
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554961, ; type_token_id
		i32 710; java_name_index
	}, 
	; 551
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554749, ; type_token_id
		i32 154; java_name_index
	}, 
	; 552
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554869, ; type_token_id
		i32 621; java_name_index
	}, 
	; 553
	%struct.TypeMapJava {
		i32 12, ; module_index
		i32 0, ; type_token_id
		i32 351; java_name_index
	}, 
	; 554
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 185; java_name_index
	}, 
	; 555
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554933, ; type_token_id
		i32 685; java_name_index
	}, 
	; 556
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554685, ; type_token_id
		i32 468; java_name_index
	}, 
	; 557
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554968, ; type_token_id
		i32 717; java_name_index
	}, 
	; 558
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554969, ; type_token_id
		i32 718; java_name_index
	}, 
	; 559
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33555089, ; type_token_id
		i32 330; java_name_index
	}, 
	; 560
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554863, ; type_token_id
		i32 615; java_name_index
	}, 
	; 561
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33555045, ; type_token_id
		i32 300; java_name_index
	}, 
	; 562
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554604, ; type_token_id
		i32 404; java_name_index
	}, 
	; 563
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 129; java_name_index
	}, 
	; 564
	%struct.TypeMapJava {
		i32 3, ; module_index
		i32 0, ; type_token_id
		i32 34; java_name_index
	}, 
	; 565
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554856, ; type_token_id
		i32 608; java_name_index
	}, 
	; 566
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554955, ; type_token_id
		i32 706; java_name_index
	}, 
	; 567
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 226; java_name_index
	}, 
	; 568
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 110; java_name_index
	}, 
	; 569
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554997, ; type_token_id
		i32 266; java_name_index
	}, 
	; 570
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554946, ; type_token_id
		i32 697; java_name_index
	}, 
	; 571
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554766, ; type_token_id
		i32 532; java_name_index
	}, 
	; 572
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 311; java_name_index
	}, 
	; 573
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554953, ; type_token_id
		i32 704; java_name_index
	}, 
	; 574
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554964, ; type_token_id
		i32 246; java_name_index
	}, 
	; 575
	%struct.TypeMapJava {
		i32 12, ; module_index
		i32 33554482, ; type_token_id
		i32 344; java_name_index
	}, 
	; 576
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554753, ; type_token_id
		i32 158; java_name_index
	}, 
	; 577
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554894, ; type_token_id
		i32 646; java_name_index
	}, 
	; 578
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554710, ; type_token_id
		i32 127; java_name_index
	}, 
	; 579
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 0, ; type_token_id
		i32 454; java_name_index
	}, 
	; 580
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554583, ; type_token_id
		i32 63; java_name_index
	}, 
	; 581
	%struct.TypeMapJava {
		i32 3, ; module_index
		i32 33554437, ; type_token_id
		i32 33; java_name_index
	}, 
	; 582
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33555043, ; type_token_id
		i32 298; java_name_index
	}, 
	; 583
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33555010, ; type_token_id
		i32 275; java_name_index
	}, 
	; 584
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 0, ; type_token_id
		i32 494; java_name_index
	}, 
	; 585
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554706, ; type_token_id
		i32 483; java_name_index
	}, 
	; 586
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554884, ; type_token_id
		i32 207; java_name_index
	}, 
	; 587
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554852, ; type_token_id
		i32 604; java_name_index
	}, 
	; 588
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 250; java_name_index
	}, 
	; 589
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554986, ; type_token_id
		i32 734; java_name_index
	}, 
	; 590
	%struct.TypeMapJava {
		i32 4, ; module_index
		i32 33554467, ; type_token_id
		i32 35; java_name_index
	}, 
	; 591
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 193; java_name_index
	}, 
	; 592
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554618, ; type_token_id
		i32 418; java_name_index
	}, 
	; 593
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 96; java_name_index
	}, 
	; 594
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554778, ; type_token_id
		i32 544; java_name_index
	}, 
	; 595
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554734, ; type_token_id
		i32 144; java_name_index
	}, 
	; 596
	%struct.TypeMapJava {
		i32 11, ; module_index
		i32 0, ; type_token_id
		i32 337; java_name_index
	}, 
	; 597
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554819, ; type_token_id
		i32 572; java_name_index
	}, 
	; 598
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 217; java_name_index
	}, 
	; 599
	%struct.TypeMapJava {
		i32 2, ; module_index
		i32 33554494, ; type_token_id
		i32 22; java_name_index
	}, 
	; 600
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554629, ; type_token_id
		i32 427; java_name_index
	}, 
	; 601
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33555007, ; type_token_id
		i32 272; java_name_index
	}, 
	; 602
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554653, ; type_token_id
		i32 447; java_name_index
	}, 
	; 603
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 285; java_name_index
	}, 
	; 604
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554780, ; type_token_id
		i32 546; java_name_index
	}, 
	; 605
	%struct.TypeMapJava {
		i32 2, ; module_index
		i32 0, ; type_token_id
		i32 24; java_name_index
	}, 
	; 606
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554614, ; type_token_id
		i32 414; java_name_index
	}, 
	; 607
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554669, ; type_token_id
		i32 111; java_name_index
	}, 
	; 608
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 284; java_name_index
	}, 
	; 609
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554775, ; type_token_id
		i32 541; java_name_index
	}, 
	; 610
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554739, ; type_token_id
		i32 507; java_name_index
	}, 
	; 611
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554610, ; type_token_id
		i32 410; java_name_index
	}, 
	; 612
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33555056, ; type_token_id
		i32 308; java_name_index
	}, 
	; 613
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 167; java_name_index
	}, 
	; 614
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554601, ; type_token_id
		i32 401; java_name_index
	}, 
	; 615
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554873, ; type_token_id
		i32 625; java_name_index
	}, 
	; 616
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554962, ; type_token_id
		i32 245; java_name_index
	}, 
	; 617
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554828, ; type_token_id
		i32 580; java_name_index
	}, 
	; 618
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 57; java_name_index
	}, 
	; 619
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 0, ; type_token_id
		i32 485; java_name_index
	}, 
	; 620
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554744, ; type_token_id
		i32 512; java_name_index
	}, 
	; 621
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 70; java_name_index
	}, 
	; 622
	%struct.TypeMapJava {
		i32 2, ; module_index
		i32 33554479, ; type_token_id
		i32 12; java_name_index
	}, 
	; 623
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554948, ; type_token_id
		i32 699; java_name_index
	}, 
	; 624
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554738, ; type_token_id
		i32 506; java_name_index
	}, 
	; 625
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 0, ; type_token_id
		i32 396; java_name_index
	}, 
	; 626
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554913, ; type_token_id
		i32 665; java_name_index
	}, 
	; 627
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554566, ; type_token_id
		i32 375; java_name_index
	}, 
	; 628
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 227; java_name_index
	}, 
	; 629
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33555090, ; type_token_id
		i32 331; java_name_index
	}, 
	; 630
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554747, ; type_token_id
		i32 515; java_name_index
	}, 
	; 631
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 283; java_name_index
	}, 
	; 632
	%struct.TypeMapJava {
		i32 1, ; module_index
		i32 0, ; type_token_id
		i32 6; java_name_index
	}, 
	; 633
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554743, ; type_token_id
		i32 511; java_name_index
	}, 
	; 634
	%struct.TypeMapJava {
		i32 12, ; module_index
		i32 33554510, ; type_token_id
		i32 357; java_name_index
	}, 
	; 635
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554687, ; type_token_id
		i32 121; java_name_index
	}, 
	; 636
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554977, ; type_token_id
		i32 726; java_name_index
	}, 
	; 637
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554682, ; type_token_id
		i32 465; java_name_index
	}, 
	; 638
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554880, ; type_token_id
		i32 632; java_name_index
	}, 
	; 639
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554756, ; type_token_id
		i32 522; java_name_index
	}, 
	; 640
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 60; java_name_index
	}, 
	; 641
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 235; java_name_index
	}, 
	; 642
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554742, ; type_token_id
		i32 510; java_name_index
	}, 
	; 643
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554720, ; type_token_id
		i32 492; java_name_index
	}, 
	; 644
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554583, ; type_token_id
		i32 385; java_name_index
	}, 
	; 645
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554565, ; type_token_id
		i32 374; java_name_index
	}, 
	; 646
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554704, ; type_token_id
		i32 481; java_name_index
	}, 
	; 647
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 61; java_name_index
	}, 
	; 648
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554995, ; type_token_id
		i32 264; java_name_index
	}, 
	; 649
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554771, ; type_token_id
		i32 537; java_name_index
	}, 
	; 650
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 247; java_name_index
	}, 
	; 651
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554982, ; type_token_id
		i32 731; java_name_index
	}, 
	; 652
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554750, ; type_token_id
		i32 155; java_name_index
	}, 
	; 653
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554894, ; type_token_id
		i32 208; java_name_index
	}, 
	; 654
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554795, ; type_token_id
		i32 561; java_name_index
	}, 
	; 655
	%struct.TypeMapJava {
		i32 9, ; module_index
		i32 33554434, ; type_token_id
		i32 334; java_name_index
	}, 
	; 656
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554700, ; type_token_id
		i32 477; java_name_index
	}, 
	; 657
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554680, ; type_token_id
		i32 117; java_name_index
	}, 
	; 658
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 190; java_name_index
	}, 
	; 659
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554622, ; type_token_id
		i32 82; java_name_index
	}, 
	; 660
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554958, ; type_token_id
		i32 243; java_name_index
	}, 
	; 661
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 186; java_name_index
	}, 
	; 662
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554747, ; type_token_id
		i32 152; java_name_index
	}, 
	; 663
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554664, ; type_token_id
		i32 107; java_name_index
	}, 
	; 664
	%struct.TypeMapJava {
		i32 6, ; module_index
		i32 0, ; type_token_id
		i32 50; java_name_index
	}, 
	; 665
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554781, ; type_token_id
		i32 175; java_name_index
	}, 
	; 666
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 314; java_name_index
	}, 
	; 667
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554809, ; type_token_id
		i32 565; java_name_index
	}, 
	; 668
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554865, ; type_token_id
		i32 204; java_name_index
	}, 
	; 669
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 225; java_name_index
	}, 
	; 670
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554847, ; type_token_id
		i32 199; java_name_index
	}, 
	; 671
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554758, ; type_token_id
		i32 163; java_name_index
	}, 
	; 672
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554877, ; type_token_id
		i32 629; java_name_index
	}, 
	; 673
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554759, ; type_token_id
		i32 525; java_name_index
	}, 
	; 674
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554772, ; type_token_id
		i32 538; java_name_index
	}, 
	; 675
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554675, ; type_token_id
		i32 113; java_name_index
	}, 
	; 676
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554907, ; type_token_id
		i32 659; java_name_index
	}, 
	; 677
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 191; java_name_index
	}, 
	; 678
	%struct.TypeMapJava {
		i32 4, ; module_index
		i32 33554474, ; type_token_id
		i32 41; java_name_index
	}, 
	; 679
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554792, ; type_token_id
		i32 558; java_name_index
	}, 
	; 680
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554727, ; type_token_id
		i32 497; java_name_index
	}, 
	; 681
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554937, ; type_token_id
		i32 689; java_name_index
	}, 
	; 682
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554666, ; type_token_id
		i32 456; java_name_index
	}, 
	; 683
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554593, ; type_token_id
		i32 394; java_name_index
	}, 
	; 684
	%struct.TypeMapJava {
		i32 10, ; module_index
		i32 0, ; type_token_id
		i32 335; java_name_index
	}, 
	; 685
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554825, ; type_token_id
		i32 577; java_name_index
	}, 
	; 686
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33555086, ; type_token_id
		i32 328; java_name_index
	}, 
	; 687
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554696, ; type_token_id
		i32 476; java_name_index
	}, 
	; 688
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554637, ; type_token_id
		i32 435; java_name_index
	}, 
	; 689
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554754, ; type_token_id
		i32 159; java_name_index
	}, 
	; 690
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554691, ; type_token_id
		i32 472; java_name_index
	}, 
	; 691
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554979, ; type_token_id
		i32 728; java_name_index
	}, 
	; 692
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554902, ; type_token_id
		i32 654; java_name_index
	}, 
	; 693
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33555050, ; type_token_id
		i32 304; java_name_index
	}, 
	; 694
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554654, ; type_token_id
		i32 448; java_name_index
	}, 
	; 695
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554653, ; type_token_id
		i32 100; java_name_index
	}, 
	; 696
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554684, ; type_token_id
		i32 467; java_name_index
	}, 
	; 697
	%struct.TypeMapJava {
		i32 6, ; module_index
		i32 0, ; type_token_id
		i32 47; java_name_index
	}, 
	; 698
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554882, ; type_token_id
		i32 634; java_name_index
	}, 
	; 699
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554844, ; type_token_id
		i32 596; java_name_index
	}, 
	; 700
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 214; java_name_index
	}, 
	; 701
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33555014, ; type_token_id
		i32 278; java_name_index
	}, 
	; 702
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33555044, ; type_token_id
		i32 299; java_name_index
	}, 
	; 703
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554943, ; type_token_id
		i32 234; java_name_index
	}, 
	; 704
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554623, ; type_token_id
		i32 83; java_name_index
	}, 
	; 705
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554689, ; type_token_id
		i32 470; java_name_index
	}, 
	; 706
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554821, ; type_token_id
		i32 574; java_name_index
	}, 
	; 707
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554914, ; type_token_id
		i32 666; java_name_index
	}, 
	; 708
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554840, ; type_token_id
		i32 592; java_name_index
	}, 
	; 709
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554932, ; type_token_id
		i32 684; java_name_index
	}, 
	; 710
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554990, ; type_token_id
		i32 261; java_name_index
	}, 
	; 711
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554956, ; type_token_id
		i32 242; java_name_index
	}, 
	; 712
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 321; java_name_index
	}, 
	; 713
	%struct.TypeMapJava {
		i32 4, ; module_index
		i32 33554482, ; type_token_id
		i32 44; java_name_index
	}, 
	; 714
	%struct.TypeMapJava {
		i32 12, ; module_index
		i32 33554473, ; type_token_id
		i32 338; java_name_index
	}, 
	; 715
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554896, ; type_token_id
		i32 209; java_name_index
	}, 
	; 716
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554746, ; type_token_id
		i32 151; java_name_index
	}, 
	; 717
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554794, ; type_token_id
		i32 560; java_name_index
	}, 
	; 718
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554741, ; type_token_id
		i32 509; java_name_index
	}, 
	; 719
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554822, ; type_token_id
		i32 575; java_name_index
	}, 
	; 720
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554714, ; type_token_id
		i32 130; java_name_index
	}, 
	; 721
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554686, ; type_token_id
		i32 469; java_name_index
	}, 
	; 722
	%struct.TypeMapJava {
		i32 2, ; module_index
		i32 0, ; type_token_id
		i32 16; java_name_index
	}, 
	; 723
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554867, ; type_token_id
		i32 619; java_name_index
	}, 
	; 724
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554621, ; type_token_id
		i32 421; java_name_index
	}, 
	; 725
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554793, ; type_token_id
		i32 559; java_name_index
	}, 
	; 726
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554858, ; type_token_id
		i32 610; java_name_index
	}, 
	; 727
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 0, ; type_token_id
		i32 457; java_name_index
	}, 
	; 728
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554874, ; type_token_id
		i32 626; java_name_index
	}, 
	; 729
	%struct.TypeMapJava {
		i32 2, ; module_index
		i32 0, ; type_token_id
		i32 18; java_name_index
	}, 
	; 730
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554728, ; type_token_id
		i32 498; java_name_index
	}, 
	; 731
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 192; java_name_index
	}, 
	; 732
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554585, ; type_token_id
		i32 65; java_name_index
	}, 
	; 733
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554755, ; type_token_id
		i32 521; java_name_index
	}, 
	; 734
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554598, ; type_token_id
		i32 398; java_name_index
	}, 
	; 735
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554950, ; type_token_id
		i32 701; java_name_index
	}, 
	; 736
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554916, ; type_token_id
		i32 219; java_name_index
	}, 
	; 737
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554745, ; type_token_id
		i32 150; java_name_index
	}, 
	; 738
	%struct.TypeMapJava {
		i32 13, ; module_index
		i32 33554707, ; type_token_id
		i32 484; java_name_index
	}, 
	; 739
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33555019, ; type_token_id
		i32 282; java_name_index
	}, 
	; 740
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33554852, ; type_token_id
		i32 201; java_name_index
	}, 
	; 741
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 0, ; type_token_id
		i32 216; java_name_index
	}, 
	; 742
	%struct.TypeMapJava {
		i32 7, ; module_index
		i32 33555069, ; type_token_id
		i32 316; java_name_index
	}
], align 4; end of 'map_java' array

@map_java_hashes = local_unnamed_addr constant [743 x i64] [
	i64 5693981294008028, ; 0: 0x143aa5546316dc => br/com/daruma/framework/mobile/gne/imp/TECTOY_380
	i64 26208664256108705, ; 1: 0x5d1ca42b05d8a1 => com/phi/gertec/sat/satger/SatGerConnectionManager$ConnectionFailedException
	i64 77433633862869290, ; 2: 0x113197ad010612a => br/com/daruma/framework/mobile/gne/sat/xml/Op_XmlRetorno
	i64 128182020419974451, ; 3: 0x1c764de51b97533 => java/lang/String
	i64 136778142509822619, ; 4: 0x1e5eefef555f29b => com/phi/gertec/sat/satger/SatGerConnectionManager
	i64 146042335049966109, ; 5: 0x206d8baded2621d => java/util/concurrent/Executor
	i64 179924752871835988, ; 6: 0x27f389c0539c954 => androidx/core/app/ComponentActivity
	i64 192101599588141989, ; 7: 0x2aa7b63143c4ba5 => br/com/daruma/framework/mobile/gne/imp/Datec_250
	i64 229629845183097875, ; 8: 0x32fcf20a7f76c13 => java/net/URI
	i64 271149839873679031, ; 9: 0x3c35157be931eb7 => br/com/daruma/framework/mobile/gne/nfce/xml/classes/Email
	i64 276050983113093313, ; 10: 0x3d4bae8145a70c1 => androidx/appcompat/view/menu/MenuBuilder$Callback
	i64 277757734956660343, ; 11: 0x3dacb3035b57677 => com/orbbec/astra/StreamDescription
	i64 318564728890166633, ; 12: 0x46bc4eedf778d69 => android/widget/Button
	i64 335076348929787677, ; 13: 0x4a66e29fe98471d => br/com/daruma/framework/mobile/gne/nfce/xml/classes/Icms70Auxiliar
	i64 361870449891484378, ; 14: 0x5059f41c47e22da => android/os/Bundle
	i64 363417747702605178, ; 15: 0x50b1e841ce2e57a => android/widget/TextView
	i64 399057251532331671, ; 16: 0x589bc74baa0da97 => com/orbbec/astra/StreamType
	i64 414466411929636695, ; 17: 0x5c07b0176658f57 => br/com/daruma/framework/mobile/gne/nfce/xml/classes/SC
	i64 485313773175302990, ; 18: 0x6bc2e4e2eb7eb4e => com/sunmi/peripheral/printer/InnerPrinterManager
	i64 544341759601875992, ; 19: 0x78de3f2417b1c18 => androidx/core/app/TaskStackBuilder$SupportParentable
	i64 564650663000755151, ; 20: 0x7d60ac94e594bcf => com/orbbec/astra/Matrix3
	i64 582128946798849863, ; 21: 0x81423315f6aef47 => android/view/ActionProvider
	i64 662641651479168327, ; 22: 0x9322d1239cb4547 => br/com/daruma/framework/mobile/PrinterManager
	i64 680944938067709588, ; 23: 0x97333d039204e94 => com/orbbec/astra/ImageStreamMode
	i64 698692053645229055, ; 24: 0x9b240b890e97bff => javax/net/ssl/HttpsURLConnection
	i64 705175846315662030, ; 25: 0x9c949b22fd49ace => android/view/MotionEvent
	i64 705440803665400256, ; 26: 0x9ca3aac608ad1c0 => com/orbbec/astra/DeviceController
	i64 742021729756506831, ; 27: 0xa4c30d4f1c1eacf => br/com/daruma/framework/mobile/exception/DarumaException
	i64 742196324940029299, ; 28: 0xa4ccfa00da69d73 => android/hardware/Camera$PreviewCallback
	i64 753213119692529150, ; 29: 0xa73f357776fddfe => android/animation/TimeInterpolator
	i64 753844298871422754, ; 30: 0xa763165522f3f22 => java/lang/reflect/Type
	i64 782647305593757341, ; 31: 0xadc8593ea551e9d => android/hardware/Camera
	i64 793967885829452291, ; 32: 0xb04bd95e5eeb203 => br/com/daruma/framework/mobile/gne/nfce/xml/classes/Icms90Auxiliar
	i64 804996528922187268, ; 33: 0xb2bec13f7d45604 => java/io/FilterInputStream
	i64 809480176342503793, ; 34: 0xb3bd9ee7b9d9171 => java/nio/channels/ScatteringByteChannel
	i64 833690705637569321, ; 35: 0xb91dd479a127329 => com/sunmi/peripheral/printer/ExceptionConst
	i64 842996187739117614, ; 36: 0xbb2ec90fd32d82e => br/com/daruma/framework/mobile/sat/impostos/Icmssn102
	i64 852047385197835535, ; 37: 0xbd314951e84750f => br/com/daruma/framework/mobile/sat/elementosCFe/InfAdic
	i64 863350936099456906, ; 38: 0xbfb3d1a26b5878a => br/com/daruma/framework/mobile/camera/dependencies/ISendHandler
	i64 870874870088288028, ; 39: 0xc15f8148b6d471c => java/lang/Exception
	i64 899555611328888199, ; 40: 0xc7bdd0ffcf7bd87 => br/com/daruma/framework/mobile/gne/nfse/TiposNFSe
	i64 907042104079805809, ; 41: 0xc9675fce9ffed71 => com/orbbec/astra/StreamReader
	i64 910490196646988595, ; 42: 0xca2b602869e8b33 => br/com/daruma/framework/mobile/sat/elementosCFe/Det
	i64 915047814879209649, ; 43: 0xcb2e723b65f68b1 => com/orbbec/astra/JointType
	i64 993581534657089375, ; 44: 0xdc9e9243c9f8f5f => com/orbbec/astra/MaskedColorFrame
	i64 1012031524318181223, ; 45: 0xe0b754f347b7767 => com/orbbec/astra/android/AndroidCamera
	i64 1057981771194895504, ; 46: 0xeaeb4d0c2e90c90 => com/orbbec/astra/BodyTracking
	i64 1079586186822872943, ; 47: 0xefb75eac1feef6f => java/util/function/Consumer
	i64 1128225039705543915, ; 48: 0xfa842b22e5994eb => android/os/AsyncTask
	i64 1183651664451731645, ; 49: 0x106d2ceae57200bd => com/orbbec/astra/PixelFormat
	i64 1217044833273073796, ; 50: 0x10e3cfd3e2f75084 => java/util/HashSet
	i64 1247566983430333137, ; 51: 0x11503f8fc0dee2d1 => android/view/ViewTreeObserver$OnPreDrawListener
	i64 1258329035281635159, ; 52: 0x11767b9736859757 => br/com/daruma/framework/mobile/gne/sat/xml/Xml_ElementosAux
	i64 1283121375857603354, ; 53: 0x11ce9017d3b3f31a => java/net/ConnectException
	i64 1283995014073051212, ; 54: 0x11d1aaa99332684c => java/lang/Void
	i64 1298049470458043414, ; 55: 0x1203991db3891c16 => com/orbbec/astra/InfraredFrame
	i64 1309713578889228674, ; 56: 0x122d098f9332b182 => android/animation/AnimatorListenerAdapter
	i64 1317579852464953526, ; 57: 0x1248fbe51d6298b6 => java/io/FileInputStream
	i64 1320822650197077237, ; 58: 0x12548133cc496cf5 => android/runtime/JavaProxyThrowable
	i64 1351596142494714808, ; 59: 0x12c1d587d12f8bb8 => androidx/appcompat/view/menu/MenuView
	i64 1356236609822008698, ; 60: 0x12d25202cfd2257a => androidx/core/app/SharedElementCallback$OnSharedElementsReadyListener
	i64 1362770524300979611, ; 61: 0x12e9889253552d9b => java/util/Iterator
	i64 1516939617339020112, ; 62: 0x150d408b7d359350 => com/hoho/android/usbserial/driver/UsbId
	i64 1550860884384862055, ; 63: 0x1585c3c1edcecf67 => java/net/ProtocolException
	i64 1598950685346246630, ; 64: 0x16309d2d3d6e2fe6 => br/com/itfast/tectoy/service/BytesUtil
	i64 1608247358826116468, ; 65: 0x1651a473b5ca7574 => android/content/ComponentCallbacks2
	i64 1610464427476120569, ; 66: 0x165984dd3b1df3f9 => androidx/core/app/SharedElementCallback
	i64 1614800872838357676, ; 67: 0x1668ecd6988562ac => androidx/fragment/app/FragmentManager$OnBackStackChangedListener
	i64 1628407814205389105, ; 68: 0x16994447832eb931 => br/com/daruma/framework/mobile/sat/impostos/Pissn
	i64 1633947008124031827, ; 69: 0x16acf225990b9353 => mono/com/hoho/android/usbserial/util/SerialInputOutputManager_ListenerImplementor
	i64 1635565025320217622, ; 70: 0x16b2b1b99543ac16 => br/com/daruma/framework/mobile/camera/dependencies/InactivityTimer
	i64 1722417751405242925, ; 71: 0x17e741d1b3562a2d => com/orbbec/astra/ImageMetadata
	i64 1734333831628082052, ; 72: 0x1811976e54224b84 => br/com/daruma/framework/mobile/gne/imp/M10
	i64 1747499027921055994, ; 73: 0x18405d1b749330fa => android/os/BaseBundle
	i64 1748363357336150867, ; 74: 0x18436f35d454a353 => br/com/daruma/framework/mobile/exception/DarumaScanException
	i64 1762304723471389757, ; 75: 0x1874f6cf1481543d => br/com/daruma/framework/mobile/gne/sat/Daruma
	i64 1765132150131350709, ; 76: 0x187f0256a6335cb5 => br/com/daruma/framework/mobile/sat/elementosCFe/Entrega
	i64 1818439532979151601, ; 77: 0x193c651ee8bfe2f1 => androidx/appcompat/app/ActionBar$TabListener
	i64 1831728799718484971, ; 78: 0x196b9ba37012abeb => java/io/IOException
	i64 1850333256545206711, ; 79: 0x19adb44b187801b7 => java/nio/channels/GatheringByteChannel
	i64 1869823426082872383, ; 80: 0x19f2f27fd05f9c3f => androidx/core/app/ActivityCompat$OnRequestPermissionsResultCallback
	i64 1877272793125324469, ; 81: 0x1a0d69a8bcbd86b5 => java/net/Proxy
	i64 1878806388185091404, ; 82: 0x1a12dc74a981cd4c => androidx/lifecycle/ViewModelStore
	i64 1895769197702450065, ; 83: 0x1a4f200a852e8b91 => br/com/daruma/framework/mobile/DarumaMobile
	i64 1904837331401847887, ; 84: 0x1a6f5775ed1c344f => br/com/itfast/tectoy/TecToy
	i64 1920667697910321371, ; 85: 0x1aa79518598310db => androidx/loader/content/Loader
	i64 1945958153844008808, ; 86: 0x1b016ea17ba5a768 => br/com/daruma/framework/mobile/sat/impostos/Icms
	i64 1970163408406378126, ; 87: 0x1b576d2e7b88f68e => br/com/itfast/tectoy/TecToyReconhecimentoFacialCallback
	i64 2025708888910512223, ; 88: 0x1c1cc38075dcc05f => br/com/itfast/tectoy/service/TecToyDepthCam
	i64 2069523561060038291, ; 89: 0x1cb86cb6c748f693 => br/com/daruma/framework/mobile/gne/imp/Nonus
	i64 2071261092404328256, ; 90: 0x1cbe98fd51d8f740 => android/animation/Animator$AnimatorPauseListener
	i64 2072969438447022286, ; 91: 0x1cc4aab8a0e030ce => br/com/daruma/framework/mobile/gne/nfse/xml/Op_XmlAuxiliar
	i64 2091945087796016600, ; 92: 0x1d0814f947b475d8 => android/view/MenuInflater
	i64 2099598825663598140, ; 93: 0x1d234601fe818e3c => br/com/daruma/framework/mobile/camera/DarumaScanResult
	i64 2103360364221246790, ; 94: 0x1d30a31b700b2d46 => androidx/fragment/app/FragmentManager
	i64 2111352555338672611, ; 95: 0x1d4d07f6709329e3 => android/view/InputEvent
	i64 2156356945290632642, ; 96: 0x1deceb3784fe9dc2 => androidx/lifecycle/Lifecycle
	i64 2164140653916027403, ; 97: 0x1e08927568a57a0b => java/io/InputStream
	i64 2194469792124946404, ; 98: 0x1e7452a62deec7e4 => br/com/daruma/framework/mobile/gne/nfce/xml/classes/MsgPromocional
	i64 2207588992478108389, ; 99: 0x1ea2ee7e0ab85ae5 => br/com/daruma/framework/mobile/tef/TipoFinanciamento
	i64 2224142602210817227, ; 100: 0x1eddbde9a696b4cb => br/com/daruma/framework/mobile/gne/nfce/xml/classes/CofinsStAuxiliar
	i64 2233948107064091340, ; 101: 0x1f0093f7a83622cc => br/com/daruma/framework/mobile/gne/nfce/xml/classes/NT
	i64 2239802659049655981, ; 102: 0x1f1560a6c3a14ead => com/orbbec/astra/ColorFrame
	i64 2266689907793747123, ; 103: 0x1f74e67632025cb3 => java/net/HttpURLConnection
	i64 2270205244544766606, ; 104: 0x1f8163a45051d28e => android/view/SurfaceHolder
	i64 2302047454137667512, ; 105: 0x1ff283f677f7cfb8 => br/com/daruma/framework/mobile/gne/nfse/Layout
	i64 2319268360137032813, ; 106: 0x202fb24918c5446d => java/security/SecureRandom
	i64 2341488085514843120, ; 107: 0x207ea3020eebf3f0 => com/phi/gertec/sat/serial/UsbSerialProber
	i64 2349580542494205303, ; 108: 0x209b630e06896577 => android/view/SubMenu
	i64 2357387754135176159, ; 109: 0x20b71fac231543df => java/io/File
	i64 2473328328309609835, ; 110: 0x22530702a5ce156b => androidx/core/view/KeyEventDispatcher
	i64 2492252205301218751, ; 111: 0x2296422d1ba9bdbf => androidx/lifecycle/HasDefaultViewModelProviderFactory
	i64 2492760515569195276, ; 112: 0x2298107b509f190c => com/orbbec/astra/HandPoseInfo
	i64 2497549017722244999, ; 113: 0x22a913995a75cf87 => com/phi/gertec/sat/serial/ProbeTable
	i64 2505247272498257419, ; 114: 0x22c46d1ef7c65e0b => br/com/daruma/framework/mobile/camera/dependencies/DecodeThread
	i64 2542726837267699812, ; 115: 0x2349949628319864 => android/view/Window
	i64 2617258777567259524, ; 116: 0x24525efdca2b6b84 => androidx/fragment/app/FragmentManager$BackStackEntry
	i64 2837244367146931341, ; 117: 0x275feab834c5548d => br/com/daruma/framework/mobile/gne/nfce/xml/classes/IcmsPartAuxiliar
	i64 2877039072675313461, ; 118: 0x27ed4bcb1bbb3735 => java/util/BitSet
	i64 2917386084437251309, ; 119: 0x287ca32fd38cd4ed => br/com/daruma/framework/mobile/gne/nfce/xml/classes/RR
	i64 2972252214977986258, ; 120: 0x293f8fa450a17ed2 => android/content/Intent
	i64 3067195758449717473, ; 121: 0x2a90de4aa6faf0e1 => br/com/daruma/framework/mobile/gne/nfce/xml/classes/CofinsNtAuxiliar
	i64 3071747017624329461, ; 122: 0x2aa109a3415d1cf5 => android/os/Build
	i64 3138923265956128402, ; 123: 0x2b8fb21464862692 => com/phi/gertec/sat/serial/UsbSerialRuntimeException
	i64 3171452383522110633, ; 124: 0x2c034323c5e6bca9 => android/view/MenuItem
	i64 3277568047959927566, ; 125: 0x2d7c42c639d26b0e => java/nio/channels/Channel
	i64 3279984915977670302, ; 126: 0x2d84d8e7297d0e9e => br/com/daruma/framework/mobile/gne/nfce/xml/classes/AL
	i64 3312753486604898190, ; 127: 0x2df943be8d858f8e => android/app/Dialog
	i64 3331583274504199801, ; 128: 0x2e3c295630749e79 => br/com/daruma/framework/mobile/gne/nfce/xml/classes/IcmsSn102Auxiliar
	i64 3358799580986158031, ; 129: 0x2e9cda6c58692bcf => com/phi/gertec/sat/serial/CommonUsbSerialPort
	i64 3401515202187041557, ; 130: 0x2f349c0dec731b15 => br/com/daruma/framework/mobile/gne/nfse/xml/Op_XmlRetorno
	i64 3409776279075562360, ; 131: 0x2f51f575c5da2378 => androidx/lifecycle/LiveData
	i64 3463222012655579408, ; 132: 0x300fd61252a63110 => androidx/appcompat/widget/Toolbar
	i64 3476617847597562063, ; 133: 0x303f6d8331d5f8cf => java/io/PrintWriter
	i64 3487642848378226015, ; 134: 0x306698b13904055f => androidx/appcompat/view/menu/SubMenuBuilder
	i64 3492966660860961054, ; 135: 0x307982abe8e6611e => android/widget/AdapterView
	i64 3530631042196079534, ; 136: 0x30ff523a0f1083ae => android/content/DialogInterface
	i64 3531967851957559493, ; 137: 0x3104120c5607a0c5 => androidx/core/content/ContextCompat
	i64 3534449200435782527, ; 138: 0x310ce2d24ca3637f => com/orbbec/astra/MaskedColorStream
	i64 3560635333444528101, ; 139: 0x3169eaf880aa67e5 => android/os/Parcelable$Creator
	i64 3569859766566838941, ; 140: 0x318ab08b342ce29d => br/com/daruma/framework/mobile/exception/DarumaWebServiceException
	i64 3574159261788737168, ; 141: 0x3199f6e971970e90 => br/com/daruma/framework/mobile/gne/nfce/Layout
	i64 3606789160940313841, ; 142: 0x320de3a1dd939cf1 => androidx/appcompat/app/ActionBar
	i64 3612077564782777989, ; 143: 0x3220ad6856091685 => br/com/daruma/framework/mobile/gne/nfce/xml/classes/AP
	i64 3623892568767582919, ; 144: 0x324aa7175191d2c7 => br/com/daruma/framework/mobile/gne/nfce/xml/classes/CofinsOutrAuxiliar
	i64 3634333529405745071, ; 145: 0x326fbf16e78567af => br/com/daruma/framework/mobile/gne/sat/xml/Op_XmlAuxiliar
	i64 3648679180818523925, ; 146: 0x32a2b662280d2715 => android/content/pm/PackageManager
	i64 3656396631051491790, ; 147: 0x32be215d0fc259ce => java/net/InetSocketAddress
	i64 3657809157447270990, ; 148: 0x32c3260c7dd0c24e => br/com/daruma/framework/mobile/gne/nfce/xml/classes/PA
	i64 3668991680153232620, ; 149: 0x32eae07e7365a4ec => android/view/MenuItem$OnMenuItemClickListener
	i64 3689136595673991541, ; 150: 0x33327230190ac975 => androidx/appcompat/widget/DecorToolbar
	i64 3712135616916902375, ; 151: 0x338427ad046851e7 => br/com/daruma/framework/mobile/gne/nfce/NFCe
	i64 3715390174298437201, ; 152: 0x338fb7adb508f651 => android/graphics/BlendMode
	i64 3723779481450396928, ; 153: 0x33ad85b57dbd3d00 => br/com/daruma/framework/mobile/camera/dependencies/Intents
	i64 3725282368473607506, ; 154: 0x33b2dc93a4e52d52 => com/orbbec/astra/BodyTrackingFeatureFlags
	i64 3760521074912573460, ; 155: 0x34300dfe5888b814 => br/com/daruma/framework/mobile/gne/nfce/xml/auxiliar/Aux_XmlNfce
	i64 3788997725350955691, ; 156: 0x3495395b324e8aab => br/com/daruma/framework/mobile/gne/nfce/xml/classes/MedAuxiliar
	i64 3791069382993876808, ; 157: 0x349c958494359748 => br/com/daruma/framework/mobile/gne/nfce/xml/classes/SP
	i64 3816756963024748935, ; 158: 0x34f7d83c5f16c187 => com/phi/gertec/sat/serial/CdcAcmSerialDriver
	i64 3817078620765368979, ; 159: 0x34f8fcc826753293 => br/com/daruma/framework/mobile/gne/nfce/xml/classes/IcmsSn500Auxiliar
	i64 3852049679258842853, ; 160: 0x35753ac6356176e5 => android/view/SurfaceHolder$Callback
	i64 3876418889233244321, ; 161: 0x35cbce710d5ca0a1 => androidx/core/app/ActivityCompat$RequestPermissionsRequestCodeValidator
	i64 3880992763041431256, ; 162: 0x35dc0e5b08f23ed8 => android/widget/SpinnerAdapter
	i64 3883924338885178996, ; 163: 0x35e6789bb9beb674 => android/nfc/NfcAdapter
	i64 3936478700004404583, ; 164: 0x36a12e8573a76d67 => java/net/SocketAddress
	i64 3940353796168302121, ; 165: 0x36aef2e695f93e29 => android/graphics/Canvas
	i64 3957166361670620563, ; 166: 0x36eaadd708809593 => javax/security/cert/Certificate
	i64 4033429712169049384, ; 167: 0x37f99ef404579d28 => androidx/lifecycle/ViewModelProvider$Factory
	i64 4072229985407981875, ; 168: 0x388377989befd933 => br/com/daruma/framework/mobile/sat/impostos/Pisaliq
	i64 4074005787519580853, ; 169: 0x3889c6adc1fd7ab5 => android/view/animation/Interpolator
	i64 4075072188670065744, ; 170: 0x388d90909fc0bc50 => br/com/daruma/framework/mobile/tef/elgin/TefElgin
	i64 4104154920565321793, ; 171: 0x38f4e327cf77b041 => android/preference/PreferenceManager
	i64 4127921345514375111, ; 172: 0x39495297d42307c7 => androidx/appcompat/app/ActionBarDrawerToggle$DelegateProvider
	i64 4146769768040937458, ; 173: 0x398c49222d68b7f2 => br/com/daruma/framework/mobile/webservice/modelo/DadosInutilizacaoNFCeELGIN
	i64 4164052927580378129, ; 174: 0x39c9b013565a9411 => com/orbbec/astra/android/AstraAndroidContext
	i64 4216519898928517408, ; 175: 0x3a8416820c001120 => android/os/IInterface
	i64 4264678889446565412, ; 176: 0x3b2f2edace91e624 => com/orbbec/astra/JointStatus
	i64 4279462141547973674, ; 177: 0x3b63b424e8b30c2a => br/com/itfast/tectoy/service/TecToyServices
	i64 4305371449952891808, ; 178: 0x3bbfc085dc8cf3a0 => java/lang/Class
	i64 4328468547648071486, ; 179: 0x3c11cf35fc03a73e => android/net/Uri
	i64 4346110607894790856, ; 180: 0x3c507c923a2042c8 => java/security/KeyStore$ProtectionParameter
	i64 4406641945990788791, ; 181: 0x3d278980a31df6b7 => android/content/BroadcastReceiver
	i64 4451756581813098600, ; 182: 0x3dc7d106557a1868 => br/com/daruma/framework/mobile/sat/elementosCFe/Dest
	i64 4461755475581819131, ; 183: 0x3deb56f734b558fb => br/com/daruma/framework/mobile/comunicacao/AComunicacao
	i64 4480257524133297879, ; 184: 0x3e2d127b143c7ed7 => java/net/ProxySelector
	i64 4481325590171284639, ; 185: 0x3e30dde19506f49f => br/com/daruma/framework/mobile/gne/nfce/xml/classes/PE
	i64 4504302345287347834, ; 186: 0x3e827f1e43cfae7a => android/window/OnBackInvokedCallback
	i64 4517392625532069144, ; 187: 0x3eb100a8a3cee518 => br/com/daruma/framework/mobile/gne/nfce/xml/classes/MS
	i64 4590799101254748484, ; 188: 0x3fb5cb75a178c944 => javax/net/ssl/TrustManagerFactory
	i64 4657718675205956216, ; 189: 0x40a38a751b5aa278 => android/view/ActionMode$Callback
	i64 4668430364331232817, ; 190: 0x40c998ae949c4e31 => android/view/LayoutInflater$Factory
	i64 4701399445380430987, ; 191: 0x413eb9e2f11e7c8b => com/hoho/android/usbserial/util/SerialInputOutputManager$Listener
	i64 4721440782757463965, ; 192: 0x4185ed606c4d079d => android/view/Menu
	i64 4749987913495145238, ; 193: 0x41eb58d73f46eb16 => java/lang/StringBuilder
	i64 4756101769800025001, ; 194: 0x4201115c588983a9 => javax/net/SocketFactory
	i64 4799009522111754503, ; 195: 0x429981bbef303107 => br/com/daruma/framework/mobile/sat/elementosCFe/Ide
	i64 4837197082485161987, ; 196: 0x43212d1e32158003 => androidx/appcompat/view/ActionMode
	i64 4861530364933863294, ; 197: 0x4377a01c02a8777e => br/com/daruma/framework/mobile/sat/SatNativo
	i64 4919249705507088493, ; 198: 0x4444af8b3a31e86d => android/view/ContextMenu
	i64 4959024609639915752, ; 199: 0x44d1fe9bc201e0e8 => br/com/daruma/framework/mobile/gne/imp/TECTOY_250
	i64 4959617159471468641, ; 200: 0x44d41987843a9061 => br/com/daruma/framework/mobile/constantes/IConstantesComunicacao
	i64 4959838116221829671, ; 201: 0x44d4e27d04d84227 => androidx/appcompat/app/ActionBar$LayoutParams
	i64 5000363436447424866, ; 202: 0x4564dc0d694ce162 => br/com/daruma/framework/mobile/gne/sat/xml/Objetos
	i64 5036290526779563177, ; 203: 0x45e47f8cfa5c5ca9 => br/com/daruma/framework/mobile/gne/nfce/xml/classes/Icms40Auxiliar
	i64 5067355848399572953, ; 204: 0x4652dd4bce5acfd9 => androidx/lifecycle/ViewModelProvider
	i64 5067570179579875368, ; 205: 0x4653a03aac389028 => br/com/daruma/framework/mobile/comunicacao/impl/SerialDaruma
	i64 5076314719165903902, ; 206: 0x4672b15773f8741e => br/com/itfast/tectoy/TecToyNfcCallback
	i64 5112337295286163337, ; 207: 0x46f2abaf09835789 => br/com/daruma/framework/mobile/gne/nfce/xml/classes/AM
	i64 5169226020677077731, ; 208: 0x47bcc7ad9629cae3 => br/com/daruma/framework/mobile/gne/nfce/xml/Op_XmlInutilizacao
	i64 5207893280228753221, ; 209: 0x48462758842dbf45 => java/lang/annotation/Annotation
	i64 5214467817578676657, ; 210: 0x485d82da477bc1b1 => java/lang/Error
	i64 5351646808883735257, ; 211: 0x4a44de6b1ede2ad9 => java/nio/FloatBuffer
	i64 5389206914647869113, ; 212: 0x4aca4f22b8aa46b9 => br/com/daruma/framework/mobile/gne/nfce/xml/Op_XmlContingencia
	i64 5466832252367671256, ; 213: 0x4bde16f811060fd8 => androidx/appcompat/view/menu/MenuPresenter$Callback
	i64 5502422634282254720, ; 214: 0x4c5c883b98768180 => com/orbbec/astra/ImageStream
	i64 5527392316046439045, ; 215: 0x4cb53e06ac2bf285 => br/com/daruma/framework/mobile/gne/nfce/TiposNFCe
	i64 5551582977171357019, ; 216: 0x4d0b2f4ddf677d5b => br/com/daruma/framework/mobile/gne/nfce/xml/classes/PisNtAuxiliar
	i64 5612102159035307354, ; 217: 0x4de2312df080955a => com/orbbec/astra/ColorizedBodyStream
	i64 5619483153547007314, ; 218: 0x4dfc6a27a4761552 => android/animation/Animator$AnimatorListener
	i64 5671353016144479152, ; 219: 0x4eb4b1852321c3b0 => br/com/daruma/framework/mobile/sat/impostos/Pisoutr
	i64 5682298842372581792, ; 220: 0x4edb94b0e73b29a0 => br/com/daruma/framework/mobile/gne/Processos
	i64 5704131098060337373, ; 221: 0x4f2925030c2530dd => br/com/daruma/framework/mobile/gne/nfse/NFSe
	i64 5711826783282435557, ; 222: 0x4f447c32641c95e5 => androidx/drawerlayout/widget/DrawerLayout$DrawerListener
	i64 5754446697456903987, ; 223: 0x4fdbe6c870d6a733 => br/com/daruma/framework/mobile/log/DarumaLoggerConst
	i64 5770324540185590768, ; 224: 0x50144f98c87b3bf0 => com/orbbec/astra/Astra
	i64 5793982059409158284, ; 225: 0x50685bfc3611b08c => java/net/URLConnection
	i64 5815445246371722463, ; 226: 0x50b49ca3d8b874df => com/orbbec/astra/SkeletonProfile
	i64 5817112515982286179, ; 227: 0x50ba89034d9a5d63 => br/com/daruma/framework/mobile/gne/BMP
	i64 5844432916693622301, ; 228: 0x511b98c5c91f9e1d => com/hoho/android/usbserial/driver/ProlificSerialDriver$ProlificSerialPort
	i64 5852374101378795333, ; 229: 0x5137cf3ced610745 => com/orbbec/astra/ColorStream
	i64 5854524328054243249, ; 230: 0x513f72db968e3fb1 => java/security/cert/CertificateFactory
	i64 5872994924106118854, ; 231: 0x518111c45b0476c6 => java/util/logging/Handler
	i64 5880236631793339455, ; 232: 0x519acc0fd1480c3f => android/content/pm/PackageInfo
	i64 5890385405214755341, ; 233: 0x51beda5143f88a0d => android/widget/FrameLayout
	i64 5893945953984292608, ; 234: 0x51cb809e2095a700 => com/hoho/android/usbserial/driver/Cp21xxSerialDriver$Cp21xxSerialPort
	i64 5902220174995442397, ; 235: 0x51e8e5fa54bf4add => android/view/accessibility/AccessibilityRecord
	i64 5903004540266237290, ; 236: 0x51ebaf5a9a164d6a => com/orbbec/astra/BodyStatus
	i64 5928119462157283979, ; 237: 0x5244e93e07f6f28b => android/widget/Adapter
	i64 5988565990844375774, ; 238: 0x531ba90a3643a2de => br/com/daruma/framework/mobile/gne/nfce/xml/classes/MG
	i64 5991054489085362647, ; 239: 0x53248050dbf141d7 => javax/security/cert/X509Certificate
	i64 6000768439507874839, ; 240: 0x5347031a303df417 => java/lang/Enum
	i64 6013579853840780837, ; 241: 0x5374870408a00e25 => com/phi/gertec/sat/satger/Logger
	i64 6032785071439448590, ; 242: 0x53b8c20f356d8a0e => br/com/daruma/framework/mobile/sat/impostos/Cofinsst
	i64 6121643400988086535, ; 243: 0x54f4723d45825107 => com/hoho/android/usbserial/driver/CdcAcmSerialDriver$CdcAcmSerialPort
	i64 6122235686809110305, ; 244: 0x54f68ceb8f7a0721 => br/com/daruma/framework/mobile/exception/DarumaComunicacaoException
	i64 6155704393338165730, ; 245: 0x556d74880b3b99e2 => br/com/daruma/framework/mobile/sat/impostos/Cofins
	i64 6160296053631453721, ; 246: 0x557dc49f43f18a19 => android/graphics/PorterDuff
	i64 6190038067490173605, ; 247: 0x55e76ed37ee5b2a5 => androidx/core/app/ComponentActivity$ExtraData
	i64 6193589699106797389, ; 248: 0x55f40d042bc7774d => android/view/ActionMode
	i64 6204908697973250647, ; 249: 0x561c4395f66d5a57 => android/app/Application$ActivityLifecycleCallbacks
	i64 6210809350944268094, ; 250: 0x56313a32cab51f3e => br/com/daruma/framework/mobile/sat/elementosCFe/InfCFe
	i64 6230013063308868968, ; 251: 0x567573df80917d68 => com/orbbec/astra/StreamSet
	i64 6277407739393914449, ; 252: 0x571dd51470dcb651 => br/com/daruma/framework/mobile/gne/nfce/xml/Xml_ElementosEnvioNFCe
	i64 6279471373373477235, ; 253: 0x572529f1ab291173 => br/com/daruma/framework/mobile/camera/dependencies/BeepManager
	i64 6288996129283455045, ; 254: 0x574700a8b7bf3845 => br/com/daruma/framework/mobile/gne/nfce/xml/classes/RN
	i64 6296800472137223880, ; 255: 0x5762baaae3404ec8 => androidx/loader/content/Loader$OnLoadCompleteListener
	i64 6325051803365548829, ; 256: 0x57c7191a858c231d => android/os/RemoteException
	i64 6364569032989959824, ; 257: 0x58537dd087d16690 => android/view/KeyboardShortcutGroup
	i64 6373415978121019041, ; 258: 0x5872ec1075b3bea1 => mono/androidx/core/view/ActionProvider_VisibilityListenerImplementor
	i64 6379218476423426477, ; 259: 0x58878967dfd3b1ad => br/com/daruma/framework/mobile/gne/imp/Daruma
	i64 6467889699277173556, ; 260: 0x59c28f69c3d2f334 => com/orbbec/astra/HandPose
	i64 6485460119900587756, ; 261: 0x5a00fb9e1ba306ec => android/view/DragEvent
	i64 6488849806635508340, ; 262: 0x5a0d06850d5f2274 => br/com/daruma/framework/mobile/gne/nfce/xml/classes/IcmsStAuxiliar
	i64 6531496292272581922, ; 263: 0x5aa48945c0b02d22 => mono/com/orbbec/astra/StreamReader_FrameListenerImplementor
	i64 6556735597160731167, ; 264: 0x5afe34495aec921f => br/com/daruma/framework/mobile/gne/nfce/xml/classes/PROCREF
	i64 6562423643777923607, ; 265: 0x5b126988e901fa17 => com/hoho/android/usbserial/driver/UsbSerialDriver
	i64 6577678479794931002, ; 266: 0x5b489bba32e8853a => androidx/appcompat/view/ActionMode$Callback
	i64 6681919904529580354, ; 267: 0x5cbaf2c037190142 => br/com/daruma/framework/mobile/gne/nfse/xml/Op_XmlConsulta
	i64 6686699664156607880, ; 268: 0x5ccbedeab9c74588 => androidx/fragment/app/FragmentFactory
	i64 6687740929511417890, ; 269: 0x5ccfa0f1355e6822 => mono/androidx/drawerlayout/widget/DrawerLayout_DrawerListenerImplementor
	i64 6700602733473978717, ; 270: 0x5cfd52af4dba595d => br/com/daruma/framework/mobile/gne/imp/EPSON
	i64 6740334783866200195, ; 271: 0x5d8a7ac62b8de083 => javax/net/ssl/SSLSession
	i64 6749908104625633273, ; 272: 0x5dac7da89abdb7f9 => com/phi/gertec/sat/serial/CdcAcmSerialDriver$CdcAcmSerialPort
	i64 6804602249961354267, ; 273: 0x5e6ecdb1aac5341b => android/view/Window$Callback
	i64 6828118483582387622, ; 274: 0x5ec259957a3505a6 => br/com/daruma/framework/mobile/gne/nfce/xml/classes/IssQnAuxiliar
	i64 6840857047262153202, ; 275: 0x5eef9b3d7549c9f2 => mono/br/com/daruma/framework/mobile/PrinterManager_PrinterManagerListenerImplementor
	i64 6887549445287282166, ; 276: 0x5f957dba8b4985f6 => android/view/Surface
	i64 6980177601275293979, ; 277: 0x60de928bb926f11b => com/phi/gertec/sat/satger/BuildConfig
	i64 7002287618420371583, ; 278: 0x612d1f7d3f0ff07f => br/com/daruma/framework/mobile/gne/nfce/xml/Op_XmlCanc
	i64 7017970021919054493, ; 279: 0x6164d68d58d35a9d => androidx/appcompat/app/AppCompatActivity
	i64 7019587775477401238, ; 280: 0x616a95e3f3014696 => br/com/daruma/framework/mobile/gne/nfce/xml/classes/IcmsSn101Auxiliar
	i64 7133065132721438775, ; 281: 0x62fdbcf213960037 => br/com/daruma/framework/mobile/comunicacao/impl/UsbDaruma
	i64 7218510223037532169, ; 282: 0x642d4ccd73ad8809 => br/com/daruma/framework/mobile/sat/impostos/Cofinsqtde
	i64 7233572560183350455, ; 283: 0x6462cfeb1abdd4b7 => br/com/daruma/framework/mobile/ModeloImpressora
	i64 7249393543207660216, ; 284: 0x649b0504c3e72ab8 => br/com/daruma/framework/mobile/sat/impostos/Pisst
	i64 7262392375486455453, ; 285: 0x64c9336340601e9d => com/hoho/android/usbserial/driver/UsbSerialPort$ControlLine
	i64 7282188369651690282, ; 286: 0x650f87bd5091eb2a => android/os/Parcelable
	i64 7291810569935423650, ; 287: 0x6531b714667088a2 => android/os/Build$VERSION
	i64 7316711887949817006, ; 288: 0x658a2eb24d2064ae => mono/com/orbbec/astra/android/UsbDeviceAccessBroker_UsbDeviceAccessEventListenerImplementor
	i64 7349164247998023060, ; 289: 0x65fd79f22dec4594 => java/io/Flushable
	i64 7354512833339701341, ; 290: 0x66107a74bf43b85d => com/hoho/android/usbserial/util/SerialInputOutputManager$State
	i64 7374743780504419852, ; 291: 0x66585a65327cbe0c => br/com/daruma/framework/mobile/gne/nfse/xml/Objetos
	i64 7394638939512291408, ; 292: 0x669f08efdfe6c050 => java/lang/reflect/GenericDeclaration
	i64 7433449956961068711, ; 293: 0x6728eb5a0c4ea6a7 => com/orbbec/astra/android/AstraDeviceManager
	i64 7437796681088239247, ; 294: 0x67385cac9fd8068f => java/io/FileDescriptor
	i64 7441733137755305687, ; 295: 0x674658dc5d2876d7 => br/com/daruma/framework/mobile/camera/dependencies/camera/CameraManager
	i64 7458096314417699308, ; 296: 0x67807b15518459ec => br/com/daruma/framework/mobile/gne/sat/Interface_Sat
	i64 7458606015771688109, ; 297: 0x67824aa769a9bcad => br/com/daruma/framework/mobile/PrinterManager$PrinterManagerListener
	i64 7481536320666505196, ; 298: 0x67d3c1a50f828fec => com/orbbec/astra/StreamReader$FrameListener
	i64 7533333765218165071, ; 299: 0x688bc7256a48e14f => br/com/daruma/framework/mobile/tef/TipoAmbiente
	i64 7538647566659605431, ; 300: 0x689ea805399bd3b7 => android/view/WindowManager$LayoutParams
	i64 7546426464182706823, ; 301: 0x68ba4ae2f137a287 => br/com/daruma/framework/mobile/tef/ITefIT4R
	i64 7580661352511403004, ; 302: 0x6933eb5606f973fc => br/com/daruma/framework/mobile/gne/nfce/xml/classes/LeiImposto
	i64 7615684371178820534, ; 303: 0x69b05896019b93b6 => br/com/daruma/framework/mobile/gne/imp/Dascom
	i64 7620119821450638162, ; 304: 0x69c01a9abf7a7352 => java/io/InterruptedIOException
	i64 7635295193788269466, ; 305: 0x69f6048674ff439a => com/orbbec/astra/PointFrame
	i64 7658195837123306865, ; 306: 0x6a476089fc1c2571 => java/lang/Character
	i64 7708522167121227376, ; 307: 0x6afa2c11ca7c2e70 => com/orbbec/astra/BodyMask
	i64 7728673124162497183, ; 308: 0x6b41c34216d06a9f => br/com/daruma/framework/mobile/gne/Tags
	i64 7748522860572928295, ; 309: 0x6b88487cfe716927 => br/com/daruma/framework/mobile/gne/nfce/xml/classes/Icms10Auxiliar
	i64 7932025412685280103, ; 310: 0x6e143716507a3367 => br/com/daruma/framework/mobile/sat/impostos/Cofinsaliq
	i64 7933543037734065265, ; 311: 0x6e199b5bee699471 => java/util/HashMap
	i64 7973312834999084471, ; 312: 0x6ea6e5c76d2ee5b7 => br/com/daruma/framework/mobile/gne/nfce/xml/classes/Icms20Auxiliar
	i64 8002756050537727359, ; 313: 0x6f0f803a4068c57f => br/com/daruma/framework/mobile/gne/PersistenciaAuxiliar
	i64 8045985209002586618, ; 314: 0x6fa914eb0aa571fa => androidx/appcompat/widget/ScrollingTabContainerView$VisibilityAnimListener
	i64 8058145963905469793, ; 315: 0x6fd4490f6ed54d61 => android/view/ContextMenu$ContextMenuInfo
	i64 8089483684911413727, ; 316: 0x70439e8d2f7679df => com/phi/gertec/sat/satger/SatGerProtocolParser
	i64 8188592205440608210, ; 317: 0x71a3b939cfd1e7d2 => androidx/appcompat/view/menu/MenuBuilder
	i64 8190305621607579207, ; 318: 0x71a9cf9199cdfe47 => java/nio/channels/spi/AbstractInterruptibleChannel
	i64 8192977714622360521, ; 319: 0x71b34dd2bcc1ebc9 => br/com/daruma/framework/mobile/log/listeners/ITraceListener
	i64 8208726067846163889, ; 320: 0x71eb40ddf475adb1 => com/phi/gertec/sat/serial/HexDump
	i64 8209608963639478488, ; 321: 0x71ee63db269808d8 => java/util/function/Function
	i64 8250115549193645823, ; 322: 0x727e4c61899d2eff => br/com/daruma/framework/mobile/sat/impostos/Icmssn900
	i64 8284726305140087744, ; 323: 0x72f942ae1f359bc0 => br/com/daruma/framework/mobile/gne/nfce/xml/classes/PB
	i64 8286532683176143191, ; 324: 0x72ffad924860e957 => br/com/sweda/satserial/DLLSATSERIAL
	i64 8365619105871342763, ; 325: 0x7418a640fbaeacab => br/com/daruma/framework/mobile/gne/nfce/xml/classes/SE
	i64 8416619862292774857, ; 326: 0x74cdd72bed753fc9 => java/lang/IllegalArgumentException
	i64 8433208572075272287, ; 327: 0x7508c683e753685f => br/com/daruma/framework/mobile/comunicacao/impl/SocketDaruma
	i64 8460177313871708814, ; 328: 0x756896716a24428e => br/com/daruma/framework/mobile/gne/nfce/xml/classes/RO
	i64 8462361838522003613, ; 329: 0x75705941b1ecf09d => android/os/IBinder
	i64 8481836763666299609, ; 330: 0x75b589990d2dbad9 => com/orbbec/astra/DepthStream
	i64 8487642170263250902, ; 331: 0x75ca29959b2aa7d6 => android/content/ContextWrapper
	i64 8526987873064351321, ; 332: 0x7655f24aea107659 => br/com/daruma/framework/mobile/sat/impostos/Cofinsnt
	i64 8537798880122960302, ; 333: 0x767c5ad8a574f9ae => br/com/daruma/framework/mobile/gne/nfce/xml/classes/ElementosXMLContingencia
	i64 8548641027165061155, ; 334: 0x76a2dfb8b8810023 => com/sunmi/peripheral/printer/WoyouConsts
	i64 8549089476185573369, ; 335: 0x76a47795651247f9 => mono/androidx/core/view/ActionProvider_SubUiVisibilityListenerImplementor
	i64 8571964507406472053, ; 336: 0x76f5bc4da3381375 => br/com/daruma/framework/mobile/gne/nfce/xml/Op_XmlRetorno
	i64 8578492171925291620, ; 337: 0x770ced2df8138264 => br/com/itfast/tectoy/TecToyCameraProfundidadeCallback
	i64 8587172038193766563, ; 338: 0x772bc378d1b4e0a3 => java/lang/Runnable
	i64 8593528535341325677, ; 339: 0x774258ac2433dd6d => br/com/daruma/framework/mobile/constantes/ConstantesGenerico
	i64 8655205006257707444, ; 340: 0x781d7718902c59b4 => androidx/core/view/ActionProvider$SubUiVisibilityListener
	i64 8657193640255745156, ; 341: 0x782487bf7f36ec84 => br/com/daruma/framework/mobile/gne/nfce/xml/classes/CofinsQtdeAuxiliar
	i64 8712284566595978930, ; 342: 0x78e840a7561246b2 => android/view/MenuItem$OnActionExpandListener
	i64 8717832878576044787, ; 343: 0x78fbf6d062bf0af3 => android/view/View$OnCreateContextMenuListener
	i64 8722435519081898203, ; 344: 0x790c50e4232060db => android/app/PendingIntent
	i64 8765863748787324385, ; 345: 0x79a69aa2cff145e1 => br/com/daruma/framework/mobile/gne/nfce/xml/classes/ElementosXMlInutilizacao
	i64 8772086762051306916, ; 346: 0x79bcb66efef985a4 => br/com/daruma/framework/mobile/gne/nfce/xml/auxiliar/Aux_XmlInfIntermed
	i64 8784751650103882924, ; 347: 0x79e9b5150877f4ac => android/content/res/Configuration
	i64 8785370249272798009, ; 348: 0x79ebe7b1e030ab39 => android/view/LayoutInflater$Factory2
	i64 8803705055097595950, ; 349: 0x7a2d0b1a8467282e => br/com/daruma/framework/mobile/gne/nfce/xml/classes/PisOutrAuxiliar
	i64 8844400343224702393, ; 350: 0x7abd9f40a54055b9 => androidx/appcompat/view/menu/MenuItemImpl
	i64 8875558113820118724, ; 351: 0x7b2c51146d958ec4 => com/orbbec/astra/SkeletonOptimization
	i64 8880556030461998429, ; 352: 0x7b3e12a893a3f55d => com/orbbec/astra/FloorInfo
	i64 8950391188589719199, ; 353: 0x7c362d5d64ad2e9f => java/lang/Boolean
	i64 8972627133644507939, ; 354: 0x7c852cd6cae98b23 => android/view/LayoutInflater
	i64 8979848056199665951, ; 355: 0x7c9ed43ad6c3591f => androidx/core/view/ActionProvider
	i64 8984501557066872207, ; 356: 0x7caf5c9070ea358f => br/com/daruma/framework/mobile/camera/dependencies/InactivityTimer$PowerStatusReceiver
	i64 9011829581423529263, ; 357: 0x7d107341f11b4d2f => mono/com/orbbec/astra/android/AstraDeviceManagerListenerImplementor
	i64 9015159948710114546, ; 358: 0x7d1c48358031f4f2 => br/com/daruma/framework/mobile/gne/nfce/xml/classes/ElementosXmlAuxiliar
	i64 9027693577914103969, ; 359: 0x7d48cf7a74a538a1 => com/phi/gertec/sat/serial/UsbSerialPort
	i64 9048644966735698440, ; 360: 0x7d933ea7cce85a08 => br/com/daruma/framework/mobile/gne/nfce/xml/classes/ProdAuxiliar
	i64 9052904945156302472, ; 361: 0x7da26115516b2688 => android/graphics/Paint
	i64 9068280744002910123, ; 362: 0x7dd9014a75cef7ab => br/com/daruma/framework/mobile/gne/imp/Daruma_350
	i64 9146179778865887055, ; 363: 0x7eedc20ce329774f => java/util/Date
	i64 9154019302997878316, ; 364: 0x7f099c0e5641e62c => javax/net/ssl/KeyManager
	i64 9187009981601112352, ; 365: 0x7f7ed0e7454d6120 => android/view/ViewGroup$MarginLayoutParams
	i64 9187025260984722656, ; 366: 0x7f7edeccc788e4e0 => br/com/daruma/framework/mobile/gne/imp/Q4
	i64 9212752804436643396, ; 367: 0x7fda45dd47ee0e44 => br/com/daruma/framework/mobile/gne/nfce/xml/classes/CombAuxiliar
	i64 9217569019755338609, ; 368: 0x7feb622fcb299b71 => java/security/Principal
	i64 9223813467167136034, ; 369: 0x8001917a80f61922 => androidx/appcompat/app/ActionBarDrawerToggle
	i64 9261091031563339153, ; 370: 0x80860139d0e38591 => br/com/daruma/framework/mobile/gne/sat/Sat
	i64 9272192007016719655, ; 371: 0x80ad71811372a527 => br/com/itfast/tectoy/TecToyScannerCallback
	i64 9355021183435591253, ; 372: 0x81d3b63388eece55 => android/graphics/drawable/Drawable
	i64 9374080444557732201, ; 373: 0x82176c7f91cca969 => android/os/IBinder$DeathRecipient
	i64 9378304446612232423, ; 374: 0x82266e34afc9d8e7 => android/hardware/usb/UsbManager
	i64 9408093265937972109, ; 375: 0x829042faa9fa3b8d => br/com/daruma/framework/mobile/comunicacao/impl/BluetoothDaruma
	i64 9457130741408361638, ; 376: 0x833e7a4da4126ca6 => com/phi/gertec/sat/satger/SatGerConnectionManager$Listener
	i64 9478593896738967145, ; 377: 0x838abaede94fce69 => android/widget/Toast
	i64 9490804761146227161, ; 378: 0x83b61ca554b4f9d9 => androidx/core/view/ActionProvider$VisibilityListener
	i64 9492130556121779516, ; 379: 0x83bad27307450d3c => androidx/savedstate/SavedStateRegistryOwner
	i64 9508416549184848137, ; 380: 0x83f4ae79469bc109 => java/lang/ClassLoader
	i64 9536061033751087102, ; 381: 0x8456e4fc692d87fe => java/util/concurrent/ThreadFactory
	i64 9569507957401028544, ; 382: 0x84cdb8c92c2987c0 => com/orbbec/astra/android/AstraDeviceMonitorActivity
	i64 9653796168998115956, ; 383: 0x85f92c77bb28da74 => android/view/accessibility/AccessibilityEvent
	i64 9667515047141612341, ; 384: 0x8629e9b6f59e9b35 => java/lang/Thread
	i64 9685204666800587841, ; 385: 0x8668c2547d9ac441 => br/com/daruma/framework/mobile/tef/TefIT4RCallback
	i64 9712620497184332666, ; 386: 0x86ca28e1ecd99b7a => mono/androidx/fragment/app/FragmentManager_OnBackStackChangedListenerImplementor
	i64 9723529273891475889, ; 387: 0x86f0ea5b6d69d1b1 => br/com/daruma/framework/mobile/gne/nfce/xml/classes/Icms60Auxiliar
	i64 9753027553088392091, ; 388: 0x8759b6e2c26e4b9b => br/com/daruma/framework/mobile/comunicacao/impl/ComunicacaoNaoImpl
	i64 9785570804745343508, ; 389: 0x87cd54ccfd479214 => java/net/URL
	i64 9800253854282402593, ; 390: 0x88017ef4dd27cb21 => android/view/ViewPropertyAnimator
	i64 9829260629995485765, ; 391: 0x88688c771f9cfa45 => com/sunmi/peripheral/printer/InnerPrinterException
	i64 9843454809251975586, ; 392: 0x889af9ff041311a2 => br/com/daruma/framework/mobile/gne/nfce/xml/classes/IcmsSn202Auxiliar
	i64 9850288051855712659, ; 393: 0x88b340cb4a226193 => br/com/daruma/framework/mobile/sat/elementosCFe/Emit
	i64 9854108034008202699, ; 394: 0x88c0d30c3161bdcb => java/lang/NoClassDefFoundError
	i64 9866983915955550238, ; 395: 0x88ee91981305f81e => java/lang/SecurityException
	i64 9869939015140501507, ; 396: 0x88f9113db837e803 => android/app/Activity
	i64 9891313474396361641, ; 397: 0x89450132d36e13a9 => androidx/core/internal/view/SupportMenuItem
	i64 9903613304640537389, ; 398: 0x8970b3d437ee832d => java/io/Serializable
	i64 9942049212981248440, ; 399: 0x89f941157f3301b8 => java/lang/LinkageError
	i64 9954935121849917296, ; 400: 0x8a2708bff3ec9f70 => br/com/daruma/framework/mobile/sat/elementosCFe/DescAcrEntr
	i64 9977296435420958008, ; 401: 0x8a767a3efc098d38 => java/lang/NullPointerException
	i64 10006414874003997943, ; 402: 0x8added4fc83184f7 => br/com/daruma/framework/mobile/comunicacao/exception/DarumaComunicacaoException
	i64 10056143723556440047, ; 403: 0x8b8e996fd4db07ef => br/com/daruma/framework/mobile/webservice/modelo/DadosConsulta
	i64 10091524575743969799, ; 404: 0x8c0c4c226b580a07 => androidx/core/view/ViewPropertyAnimatorUpdateListener
	i64 10092484235993399888, ; 405: 0x8c0fb4f0bb9dc250 => java/nio/channels/ReadableByteChannel
	i64 10095829318087436361, ; 406: 0x8c1b974659936849 => androidx/fragment/app/Fragment
	i64 10102521394318811798, ; 407: 0x8c335daec4282296 => br/com/daruma/framework/mobile/gne/nfce/xml/classes/PisAliqAuxiliar
	i64 10122970658497869854, ; 408: 0x8c7c042e1b77b81e => br/com/daruma/framework/mobile/camera/dependencies/DecodeAsyncTask
	i64 10189345294220309548, ; 409: 0x8d67d38f43ccb42c => com/hoho/android/usbserial/BuildConfig
	i64 10226370707452597307, ; 410: 0x8deb5dfa0f2c143b => com/phi/gertec/sat/satger/SatGerLib
	i64 10230811296040817611, ; 411: 0x8dfb24ab289113cb => androidx/lifecycle/ViewModelStoreOwner
	i64 10264458910007407239, ; 412: 0x8e72aefec695b287 => br/com/daruma/framework/mobile/camera/dependencies/DecodeHandler
	i64 10266059374509936169, ; 413: 0x8e785e9bf4bbce29 => java/lang/Long
	i64 10267341373231028507, ; 414: 0x8e7cec948b1b591b => br/com/daruma/framework/mobile/tef/TefIT4R
	i64 10378179339983338536, ; 415: 0x9006b31faf013c28 => com/sunmi/peripheral/printer/InnerPrinterCallback
	i64 10396963593911974655, ; 416: 0x90496f4d9dcabaff => androidx/lifecycle/LifecycleObserver
	i64 10399832576821434910, ; 417: 0x9053a0a0c0fa1a1e => br/com/daruma/framework/mobile/gne/nfce/xml/auxiliar/Aux_XmlIde
	i64 10496388717074977229, ; 418: 0x91aaa9ed09ac11cd => com/hoho/android/usbserial/util/SerialInputOutputManager
	i64 10497246395716008444, ; 419: 0x91adb5fae866f9fc => br/com/daruma/framework/mobile/camera/dependencies/config/ZXingLibConfig
	i64 10499957734077086001, ; 420: 0x91b757ed9047b931 => android/view/ViewGroup$LayoutParams
	i64 10541139640792710788, ; 421: 0x9249a6a7693cfe84 => javax/net/ssl/X509TrustManager
	i64 10556732314164660806, ; 422: 0x92810c1b96ac0a46 => android/view/WindowManager
	i64 10571633769201409705, ; 423: 0x92b5fce6f4c61ea9 => com/orbbec/astra/InfraredStream
	i64 10589642565195629679, ; 424: 0x92f5f7ce84d7846f => java/lang/UnsupportedOperationException
	i64 10596685970650905969, ; 425: 0x930efdbf25033d71 => androidx/core/app/TaskStackBuilder
	i64 10655658609895831411, ; 426: 0x93e0810cb2ac7773 => android/content/res/ColorStateList
	i64 10673347372876498127, ; 427: 0x941f58e2c4a704cf => br/com/daruma/framework/mobile/gne/nfce/xml/classes/ConfiguracaoAuxiliar
	i64 10722894652849872693, ; 428: 0x94cf5fdfdb0d5f35 => java/lang/Short
	i64 10783898034563810276, ; 429: 0x95a81a207c3583e4 => androidx/appcompat/app/ActionBarDrawerToggle$Delegate
	i64 10804287674762873921, ; 430: 0x95f08a65895f4c41 => androidx/fragment/app/Fragment$SavedState
	i64 10807464319380525259, ; 431: 0x95fbd389bf6290cb => android/window/OnBackInvokedDispatcher
	i64 10808978037618020601, ; 432: 0x96013441bd3890f9 => android/database/DataSetObserver
	i64 10845997478987558309, ; 433: 0x9684b93e19d5eda5 => br/com/daruma/framework/mobile/gne/nfce/xml/classes/IcmsSn900Auxiliar
	i64 10858888630645138738, ; 434: 0x96b285ad3d21a532 => br/com/daruma/framework/mobile/gne/nfce/xml/classes/CE
	i64 10873380054669903089, ; 435: 0x96e6018cd26ac4f1 => com/phi/gertec/sat/serial/SerialInputOutputManager$Listener
	i64 10876136888617769900, ; 436: 0x96efcce03e959bac => java/lang/Comparable
	i64 10945866865468146969, ; 437: 0x97e787eba2f28519 => xamarin/android/net/OldAndroidSSLSocketFactory
	i64 11005920483369566278, ; 438: 0x98bce25e25704046 => java/util/Random
	i64 11019443421594719173, ; 439: 0x98eced688eab13c5 => java/util/EnumSet
	i64 11059563082871999591, ; 440: 0x997b76071d9c0c67 => br/com/daruma/framework/mobile/camera/dependencies/ViewfinderView
	i64 11061399591045682740, ; 441: 0x9981fc527eedd634 => java/lang/AbstractStringBuilder
	i64 11075180664152529107, ; 442: 0x99b2f2229e1618d3 => br/com/itfast/tectoy/StatusImpressora
	i64 11083086269215938900, ; 443: 0x99cf083dbba01954 => crc64a0e0a82d0db9a07d/ActivityLifecycleContextListener
	i64 11084705475191425869, ; 444: 0x99d4c8e6809ccb4d => br/com/daruma/framework/mobile/sat/xmlConfiguracao/Imposto
	i64 11112718717483603117, ; 445: 0x9a384ecbbc71d4ad => android/os/Handler
	i64 11172923279375061947, ; 446: 0x9b0e3286a1d7d3bb => java/nio/channels/WritableByteChannel
	i64 11240308327273157113, ; 447: 0x9bfd98deb4fb51f9 => android/graphics/RectF
	i64 11303092492513440383, ; 448: 0x9cdca6bc4fa5f27f => androidx/appcompat/app/ActionBar$OnMenuVisibilityListener
	i64 11334826334319199435, ; 449: 0x9d4d647f1fd6c4cb => com/orbbec/astra/OrbbecCameraParams
	i64 11337882892979575196, ; 450: 0x9d58406ba506999c => br/com/daruma/framework/mobile/log/DarumaLogger$LoggerDispatcherTrace
	i64 11348321151605279956, ; 451: 0x9d7d55f61e7c0cd4 => android/view/animation/Animation
	i64 11351869846565280406, ; 452: 0x9d89f17b0cfdda96 => java/util/Comparator
	i64 11369367150313185102, ; 453: 0x9dc81b2f8b699f4e => com/orbbec/astra/CoordinateMapper
	i64 11393831178655295976, ; 454: 0x9e1f05170284e9e8 => javax/net/ssl/SSLContext
	i64 11406332934929296779, ; 455: 0x9e4b6f5ef84cad8b => br/com/daruma/framework/mobile/sat/impostos/Cofinssn
	i64 11418789088580397297, ; 456: 0x9e77b02d3df0e8f1 => java/util/function/IntFunction
	i64 11423830448757932785, ; 457: 0x9e899944608202f1 => br/com/daruma/framework/mobile/sat/elementosCFe/MeioDePagamento
	i64 11453358337200194823, ; 458: 0x9ef280b9a6138507 => java/lang/Iterable
	i64 11525974496200619066, ; 459: 0x9ff47cbcb03ff43a => br/com/daruma/framework/mobile/gne/nfce/xml/auxiliar/Aux_XmlTransp
	i64 11527677195894268833, ; 460: 0x9ffa89555aa623a1 => com/orbbec/astra/BodyFrameInfo
	i64 11573301743732151818, ; 461: 0xa09ca09e3190560a => mono/java/lang/RunnableImplementor
	i64 11585998938245262039, ; 462: 0xa0c9bca62a296ad7 => mono/android/runtime/JavaArray
	i64 11598024117237361233, ; 463: 0xa0f4757c5458aa51 => mono/androidx/appcompat/app/ActionBar_OnMenuVisibilityListenerImplementor
	i64 11636962083825740950, ; 464: 0xa17ecb5c271f6c96 => br/com/daruma/framework/mobile/camera/DarumaScanner
	i64 11652834085301598403, ; 465: 0xa1b72edc78f738c3 => androidx/appcompat/app/ActionBar$OnNavigationListener
	i64 11675457138304186062, ; 466: 0xa2078e6876eb76ce => br/com/daruma/framework/mobile/SatCallback
	i64 11689571647369121843, ; 467: 0xa239b37ab1ea1033 => br/com/daruma/framework/mobile/gne/nfce/xml/classes/IcmsSn201Auxiliar
	i64 11697163568341195271, ; 468: 0xa254ac4a8a9e1a07 => br/com/daruma/framework/mobile/camera/dependencies/DecodeFormatManager
	i64 11712899692065226922, ; 469: 0xa28c94365b5480aa => java/util/ArrayList
	i64 11724771665984549703, ; 470: 0xa2b6c1b5af92f347 => br/com/daruma/framework/mobile/gne/Op_XmlConsulta
	i64 11763058807128842702, ; 471: 0xa33ec7a966f1e1ce => java/security/cert/Certificate
	i64 11805384242711821632, ; 472: 0xa3d5266bcfd4fd40 => java/nio/channels/SeekableByteChannel
	i64 11839064000803593921, ; 473: 0xa44ccdfb91035ec1 => br/com/daruma/framework/mobile/sat/impostos/Pis
	i64 11852070525194104598, ; 474: 0xa47b035903126f16 => androidx/appcompat/widget/Toolbar_NavigationOnClickEventDispatcher
	i64 11893890523420890567, ; 475: 0xa50f966a1de315c7 => java/util/concurrent/Future
	i64 11895525870086415889, ; 476: 0xa51565c0eef86611 => java/util/concurrent/TimeUnit
	i64 11904910774208243445, ; 477: 0xa536bd46336726f5 => mono/androidx/appcompat/widget/Toolbar_OnMenuItemClickListenerImplementor
	i64 11938306805323822292, ; 478: 0xa5ad62c99ef474d4 => br/com/daruma/framework/mobile/sat/xmlConfiguracao/SAT_Framework_XML
	i64 11941816200895182289, ; 479: 0xa5b9da90735cb5d1 => br/com/daruma/framework/mobile/gne/nfce/xml/classes/PisQtdeAuxiliar
	i64 11944627645147170904, ; 480: 0xa5c3d78ed34ec858 => br/com/daruma/framework/mobile/gne/nfce/xml/classes/GO
	i64 11954228872253987625, ; 481: 0xa5e5f3d2b66adb29 => android/view/View
	i64 11997229509331139732, ; 482: 0xa67eb8acb8843c94 => br/com/daruma/framework/mobile/gne/nfce/xml/classes/PisSnAuxiliar
	i64 11999052403845373657, ; 483: 0xa68532966c801ed9 => androidx/activity/ComponentActivity
	i64 12016049636675011370, ; 484: 0xa6c1957b1579c32a => android/widget/EditText
	i64 12058030931184860355, ; 485: 0xa756bb3ee7f23cc3 => androidx/appcompat/widget/Toolbar$OnMenuItemClickListener
	i64 12204817298245236931, ; 486: 0xa96038ab3a7338c3 => android/animation/Animator
	i64 12228984007958404582, ; 487: 0xa9b61429ce4b1de6 => android/content/Context
	i64 12246361600639158634, ; 488: 0xa9f3d0fde514c96a => java/lang/ClassNotFoundException
	i64 12258342820273120460, ; 489: 0xaa1e61d8f956e4cc => br/com/daruma/framework/mobile/gne/nfce/xml/auxiliar/Aux_XmlAvisoServ
	i64 12270553348368640270, ; 490: 0xaa49c34216fe290e => com/phi/gertec/sat/serial/UsbId
	i64 12283959833529829589, ; 491: 0xaa796462a8b648d5 => com/phi/gertec/sat/serial/SerialInputOutputManager
	i64 12314737053939700725, ; 492: 0xaae6bc1ab26a93f5 => com/orbbec/astra/Body
	i64 12319111449616420196, ; 493: 0xaaf646980ed58d64 => android/content/ComponentCallbacks
	i64 12394252047178846529, ; 494: 0xac013a91c0c0d141 => androidx/core/view/ViewPropertyAnimatorListener
	i64 12404929968055364556, ; 495: 0xac272a14f189abcc => com/orbbec/astra/PointStream
	i64 12410414449560340260, ; 496: 0xac3aa6304d6b4724 => br/com/daruma/framework/mobile/sat/PersistenciaJSON
	i64 12426529965699990912, ; 497: 0xac73e72a4c4b8580 => java/lang/IndexOutOfBoundsException
	i64 12458575303368155603, ; 498: 0xace5c03ae4b6a1d3 => android/content/res/Resources
	i64 12476043031609966242, ; 499: 0xad23cf094d997ea2 => br/com/daruma/framework/mobile/DarumaMobile$LogMemoria
	i64 12476375190645835422, ; 500: 0xad24fd221af1069e => android/os/Looper
	i64 12481494251046402521, ; 501: 0xad372ce43bb379d9 => br/com/daruma/framework/mobile/gne/nfce/xml/classes/RJ
	i64 12488842103917764438, ; 502: 0xad5147b98bf5df56 => java/lang/IllegalStateException
	i64 12517914357725307075, ; 503: 0xadb890c91cfaa0c3 => br/com/daruma/framework/mobile/gne/nfce/xml/Op_XmlAuxiliar
	i64 12525985337305860228, ; 504: 0xadd53d4c7bde0884 => java/util/logging/StreamHandler
	i64 12532121860257401396, ; 505: 0xadeb0a6f128cca34 => java/lang/Number
	i64 12562071772572039222, ; 506: 0xae5571b86f1e3836 => java/security/cert/X509Extension
	i64 12568966203227865039, ; 507: 0xae6df02b29497fcf => br/com/daruma/framework/mobile/webservice/ElginNFCeServiceWs
	i64 12607088951491807612, ; 508: 0xaef5609b2d6bc97c => com/sunmi/peripheral/printer/InnerPrinterManager$SingletonContainer
	i64 12638779442604842957, ; 509: 0xaf65f6f09ef89fcd => java/io/DataInput
	i64 12691977065033957661, ; 510: 0xb022f5e54ac1011d => br/com/daruma/framework/mobile/gne/imp/Formatacao
	i64 12743457539483353118, ; 511: 0xb0d9db1d4b2dc01e => androidx/lifecycle/Lifecycle$State
	i64 12774266387958735952, ; 512: 0xb1474f99507e2450 => androidx/core/content/pm/PackageInfoCompat
	i64 12792955789176512524, ; 513: 0xb189b582a124a00c => androidx/core/view/ViewPropertyAnimatorCompat
	i64 12806567541869262104, ; 514: 0xb1ba1153c52a3518 => java/lang/Integer
	i64 12807185847019254324, ; 515: 0xb1bc43ac27fe3234 => android/view/accessibility/AccessibilityEventSource
	i64 12829421241662982594, ; 516: 0xb20b42a5672c49c2 => androidx/appcompat/app/AppCompatDelegate
	i64 12882710959019299141, ; 517: 0xb2c8955c98609145 => java/net/SocketTimeoutException
	i64 13012525784412709002, ; 518: 0xb495c741f287e08a => com/orbbec/astra/Vector3D
	i64 13014244565042872337, ; 519: 0xb49be27abf704011 => br/com/daruma/framework/mobile/comunicacao/exception/DarumaECFException
	i64 13069688267367477916, ; 520: 0xb560dc3ba587729c => android/view/KeyEvent$Callback
	i64 13093549244838852775, ; 521: 0xb5b5a1aa63b438a7 => com/hoho/android/usbserial/driver/FtdiSerialDriver$FtdiSerialPort
	i64 13096039480881423512, ; 522: 0xb5be7a85a66da498 => java/util/function/ToLongFunction
	i64 13107173387598024429, ; 523: 0xb5e608c0513bceed => br/com/daruma/framework/mobile/gne/nfce/xml/Op_XmlConsulta
	i64 13145368424131460687, ; 524: 0xb66dbaef41fdfe4f => br/com/daruma/framework/mobile/gne/nfce/xml/classes/CofinsAliqAuxiliar
	i64 13147524012913224524, ; 525: 0xb675636e619c6b4c => androidx/drawerlayout/widget/DrawerLayout
	i64 13162928982112025532, ; 526: 0xb6ac1e2b467b3bbc => com/orbbec/astra/BodyStream
	i64 13187037730343377895, ; 527: 0xb701c4f2a4ca5be7 => com/hoho/android/usbserial/driver/ProlificSerialDriver
	i64 13204558616772284210, ; 528: 0xb7400419e8890f32 => br/com/daruma/framework/mobile/gne/nfce/xml/classes/ES
	i64 13256340836091068469, ; 529: 0xb7f7fbc15cb68035 => br/com/daruma/framework/mobile/gne/Persistencia
	i64 13263622698022041748, ; 530: 0xb811da91f6697894 => br/com/daruma/framework/mobile/gne/nfce/xml/classes/MA
	i64 13291089739636035741, ; 531: 0xb8736fb2f0d8509d => android/content/ComponentName
	i64 13311117679692485447, ; 532: 0xb8ba97011d7e1347 => android/widget/HorizontalScrollView
	i64 13335777145830317192, ; 533: 0xb91232a87cfd1c88 => android/graphics/Point
	i64 13365541990128069638, ; 534: 0xb97bf1a05826ac06 => com/google/common/util/concurrent/ListenableFuture
	i64 13394001217639187863, ; 535: 0xb9e10d249a888597 => com/phi/gertec/sat/serial/UsbSerialDriver
	i64 13402681668680117407, ; 536: 0xb9ffe3f79b516c9f => android/view/ViewManager
	i64 13402779434266666368, ; 537: 0xba003ce26e602580 => mono/android/TypeManager
	i64 13403478332295758982, ; 538: 0xba02b8874f224486 => br/com/daruma/framework/mobile/gne/nfce/xml/classes/TO
	i64 13428863503685738205, ; 539: 0xba5ce8351a655edd => androidx/appcompat/view/menu/MenuPresenter
	i64 13487195765423477968, ; 540: 0xbb2c2517263814d0 => com/orbbec/astra/android/UsbDeviceInfo
	i64 13493236796125990997, ; 541: 0xbb419b603751d055 => android/graphics/Rect
	i64 13496056631819609460, ; 542: 0xbb4ba0006029a574 => androidx/loader/app/LoaderManager
	i64 13499562364224885079, ; 543: 0xbb5814724edb5157 => java/security/cert/X509Certificate
	i64 13501119006686247638, ; 544: 0xbb5d9c345fcefad6 => android/content/IntentSender
	i64 13502560151794130917, ; 545: 0xbb62baeb1e089fe5 => javax/security/auth/Subject
	i64 13526327963541069213, ; 546: 0xbbb72b9e064c5d9d => com/orbbec/astra/ReaderFrame
	i64 13556576098032765635, ; 547: 0xbc22a222a5cb4ac3 => android/util/DisplayMetrics
	i64 13558611776447993761, ; 548: 0xbc29dd92f69c57a1 => br/com/daruma/framework/mobile/gne/sat/ParseNFCe_2_SAT
	i64 13564572361315467704, ; 549: 0xbc3f0ab1c64a41b8 => br/com/daruma/framework/mobile/gne/nfce/xml/classes/RS
	i64 13592004075218692075, ; 550: 0xbca07fb1611267eb => br/com/daruma/framework/mobile/comunicacao/impl/BluetoothDaruma$ReadTask
	i64 13640357280074617382, ; 551: 0xbd4c48ad3042d226 => android/hardware/usb/UsbRequest
	i64 13655403264731570048, ; 552: 0xbd81bceb7b08df80 => br/com/daruma/framework/mobile/gne/nfce/xml/classes/ElementosXmlCancelamento
	i64 13664354974869333647, ; 553: 0xbda18a73e9eda68f => androidx/appcompat/app/AppCompatCallback
	i64 13667817128403725814, ; 554: 0xbdadd7435980edf6 => android/content/DialogInterface$OnCancelListener
	i64 13677629059935831470, ; 555: 0xbdd0b329af0905ae => br/com/daruma/framework/mobile/gne/imp/Daruma_250
	i64 13721466274111402870, ; 556: 0xbe6c70e079e9b376 => com/hoho/android/usbserial/driver/Ch34xSerialDriver$Ch340SerialPort
	i64 13748166835891797694, ; 557: 0xbecb4ce57622febe => br/com/daruma/framework/mobile/comunicacao/exception/DarumaException
	i64 13759236746725606002, ; 558: 0xbef2a0ebed14c272 => br/com/daruma/framework/mobile/camera/DarumaConfigScanner
	i64 13770727111868296170, ; 559: 0xbf1b735909c02bea => java/io/StringWriter
	i64 13780119963020852536, ; 560: 0xbf3cd2189e207d38 => br/com/daruma/framework/mobile/gne/nfce/xml/classes/CofinsSnAuxiliar
	i64 13789203013919682202, ; 561: 0xbf5d1715346dae9a => java/lang/RuntimeException
	i64 13801285942353113463, ; 562: 0xbf880471358cb177 => com/orbbec/astra/BodyOrientation
	i64 13805562342397192842, ; 563: 0xbf9735ce2f182a8a => android/util/AttributeSet
	i64 13814726415558267663, ; 564: 0xbfb7c47b3c8e530f => androidx/savedstate/SavedStateRegistry$SavedStateProvider
	i64 13815510152931314722, ; 565: 0xbfba8d4950460c22 => br/com/daruma/framework/mobile/gne/nfce/xml/classes/BA
	i64 13856918887848684738, ; 566: 0xc04daa4fb79f2cc2 => br/com/daruma/framework/mobile/constantes/ConstantesSocket
	i64 13864679446917576892, ; 567: 0xc0693c7fae2e78bc => java/util/function/ToDoubleFunction
	i64 13877554026709814142, ; 568: 0xc096f9dc61548b7e => android/view/View$OnClickListener
	i64 13959986462581077347, ; 569: 0xc1bbd5b97b683563 => java/net/UnknownServiceException
	i64 13977870362627987906, ; 570: 0xc1fb5f0970e6d9c2 => br/com/daruma/framework/mobile/exception/DarumaCheckedException
	i64 13979543885265201405, ; 571: 0xc2015118cb3768fd => br/com/daruma/framework/mobile/sat/impostos/Cofinsoutr
	i64 14006488896635186732, ; 572: 0xc2610b712264ae2c => java/lang/reflect/AnnotatedElement
	i64 14031621302622503532, ; 573: 0xc2ba553b659e426c => br/com/daruma/framework/mobile/constantes/ConstantesFramework
	i64 14031640676547298208, ; 574: 0xc2ba66da3d8603a0 => java/nio/channels/FileChannel
	i64 14043684570532002328, ; 575: 0xc2e530b5d431ba18 => androidx/appcompat/app/ActionBar$Tab
	i64 14048987852729596032, ; 576: 0xc2f808046fb9b880 => android/graphics/ColorFilter
	i64 14052343951305981396, ; 577: 0xc303f45f0733bdd4 => br/com/daruma/framework/mobile/gne/nfce/xml/classes/InfRespTecAuxiliar
	i64 14122621771724408359, ; 578: 0xc3fda1ad30d4c627 => android/util/AndroidException
	i64 14157033667978558907, ; 579: 0xc477e31d251b7dbb => com/orbbec/astra/android/AstraDeviceManagerListener
	i64 14160925941038085484, ; 580: 0xc485b71d9630756c => javax/net/ssl/KeyManagerFactory
	i64 14166708697631601657, ; 581: 0xc49a428086c4b3f9 => androidx/savedstate/SavedStateRegistry
	i64 14167891754637755728, ; 582: 0xc49e767c735e8550 => java/lang/Object
	i64 14180814796703042768, ; 583: 0xc4cc5feca7168cd0 => java/lang/ClassCastException
	i64 14185373652645236501, ; 584: 0xc4dc922e041acf15 => br/com/itfast/tectoy/service/ICommunicationDevice
	i64 14188752962951114159, ; 585: 0xc4e893a50278edaf => br/com/itfast/tectoy/CorLed
	i64 14206023932851353817, ; 586: 0xc525ef800c4d78d9 => mono/android/runtime/OutputStreamAdapter
	i64 14256148018842984092, ; 587: 0xc5d8031740865e9c => br/com/daruma/framework/mobile/gne/nfce/xml/classes/AC
	i64 14257601591339809660, ; 588: 0xc5dd2d1b78da7b7c => java/nio/channels/InterruptibleChannel
	i64 14259646775829072801, ; 589: 0xc5e4713117d60ba1 => br/com/daruma/framework/mobile/camera/dependencies/integrator/IVariaveisScaner
	i64 14284032202517437988, ; 590: 0xc63b139baf4ade24 => androidx/fragment/app/FragmentActivity
	i64 14296237994325564878, ; 591: 0xc66670b60c37ddce => android/content/SharedPreferences
	i64 14313349137706526315, ; 592: 0xc6a33b349324266b => com/orbbec/astra/FloorMask
	i64 14328901088261815086, ; 593: 0xc6da7b9f3b8dbb2e => android/view/ViewParent
	i64 14338396089814848354, ; 594: 0xc6fc37468e439362 => br/com/daruma/framework/mobile/sat/impostos/Pisnt
	i64 14361620789319229198, ; 595: 0xc74eba044a3cdf0e => android/os/Parcel
	i64 14409679416056247518, ; 596: 0xc7f97715494a74de => androidx/customview/widget/Openable
	i64 14410419102281080544, ; 597: 0xc7fc17d2e7f79ee0 => br/com/daruma/framework/mobile/gne/Utils
	i64 14428829850836958935, ; 598: 0xc83d804d57b07ed7 => java/util/Spliterator
	i64 14480243895569103343, ; 599: 0xc8f4291a786a39ef => androidx/core/app/ActivityCompat
	i64 14484782906499475319, ; 600: 0xc904494f4e8d2777 => com/orbbec/astra/Joint
	i64 14501341618205132561, ; 601: 0xc93f1d5ecfb48711 => java/lang/Byte
	i64 14516101098477894292, ; 602: 0xc9738d0a1a6eba94 => com/orbbec/astra/UsbDeviceInfo
	i64 14517395435871339070, ; 603: 0xc978263b82fd023e => java/lang/Cloneable
	i64 14560033073656604691, ; 604: 0xca0fa0f0293da813 => br/com/daruma/framework/mobile/sat/impostos/Pisqtde
	i64 14569564621816213537, ; 605: 0xca317dd4a7743021 => androidx/core/app/ActivityCompat$PermissionCompatDelegate
	i64 14583459274135292353, ; 606: 0xca62daf17f35c9c1 => com/orbbec/astra/DepthFrame
	i64 14649586819325063784, ; 607: 0xcb4dc998681d7268 => mono/android/view/View_OnClickListenerImplementor
	i64 14684559126920293129, ; 608: 0xcbca08b94b4deb09 => java/lang/CharSequence
	i64 14840613060004890788, ; 609: 0xcdf472f2fa9d48a4 => br/com/daruma/framework/mobile/sat/impostos/Issqn
	i64 14865939396539116181, ; 610: 0xce4e6d1e3732ea95 => br/com/daruma/framework/mobile/webservice/ComunicacaoWS
	i64 14906767039264889381, ; 611: 0xcedf79a48ce29a25 => com/orbbec/astra/ColorizedBodyFrame
	i64 14940408132235664607, ; 612: 0xcf56fe09e1439cdf => java/lang/Throwable
	i64 14959579543312699232, ; 613: 0xcf9b1a55dc5a8f60 => android/graphics/drawable/Drawable$Callback
	i64 15086269230050837681, ; 614: 0xd15d31ef2b1604b1 => com/orbbec/astra/BodyFrame
	i64 15119431645399191114, ; 615: 0xd1d302f9add18e4a => br/com/daruma/framework/mobile/gne/nfce/xml/classes/EmitAuxiliar
	i64 15133408421007071873, ; 616: 0xd204aac757081a81 => java/nio/ShortBuffer
	i64 15175495246593880443, ; 617: 0xd29a308607db717b => br/com/daruma/framework/mobile/gne/sat/Urano
	i64 15178898666151156562, ; 618: 0xd2a647ea65971b52 => javax/net/ssl/HostnameVerifier
	i64 15231150403161103691, ; 619: 0xd35fea97f4f71d4b => br/com/itfast/tectoy/TectoyBalancaCallback
	i64 15268226294866308941, ; 620: 0xd3e3a2ebafc8ef4d => br/com/daruma/framework/mobile/webservice/modelo/DadosCancelamentoNFCeELGIN
	i64 15295416057057826855, ; 621: 0xd4443bdd84bcd827 => android/widget/AdapterView$OnItemSelectedListener
	i64 15298816789066891989, ; 622: 0xd45050d0241d42d5 => androidx/core/view/DragAndDropPermissionsCompat
	i64 15361413234169674061, ; 623: 0xd52eb3f2beaaf94d => br/com/daruma/framework/mobile/exception/DarumaECFException
	i64 15396021266544291687, ; 624: 0xd5a9a7c532bb6f67 => br/com/daruma/framework/mobile/ThreadPoolManager
	i64 15439497467922964116, ; 625: 0xd6441d2526175e94 => com/phi/gertec/sat/satger/SatGerLib$OnDataReceived
	i64 15472041765317763138, ; 626: 0xd6b7bc02dbc5e042 => br/com/daruma/framework/mobile/gne/nfce/xml/classes/PisStAuxiliar
	i64 15475315259198183566, ; 627: 0xd6c35d3c8bb0988e => com/sunmi/peripheral/printer/TransBean
	i64 15489276530192123430, ; 628: 0xd6f4f6f041e58626 => java/util/function/ToIntFunction
	i64 15633873768898914415, ; 629: 0xd8f6ad5c6a84686f => java/io/Writer
	i64 15645096101532566031, ; 630: 0xd91e8c0358b2820f => br/com/daruma/framework/mobile/webservice/modelo/InfoEmissao
	i64 15645438581444444576, ; 631: 0xd91fc37f2a3001a0 => java/lang/Appendable
	i64 15655567004052913371, ; 632: 0xd943bf3e51e67cdb => androidx/lifecycle/LifecycleOwner
	i64 15676132810482715688, ; 633: 0xd98ccfbc44ab0c28 => br/com/daruma/framework/mobile/webservice/TrustedManagerManipulator
	i64 15696148966177826650, ; 634: 0xd9d3ec52aea4e75a => androidx/appcompat/widget/ScrollingTabContainerView
	i64 15699556301161391558, ; 635: 0xd9e00746adf865c6 => android/view/WindowMetrics
	i64 15704316203868987619, ; 636: 0xd9f0f061e405a0e3 => br/com/daruma/framework/mobile/camera/dependencies/FinishListener
	i64 15713262164506246993, ; 637: 0xda10b8afa9faff51 => com/hoho/android/usbserial/driver/CdcAcmSerialDriver
	i64 15718149239621889224, ; 638: 0xda221574823d2cc8 => br/com/daruma/framework/mobile/gne/nfce/xml/classes/Icms30Auxiliar
	i64 15746953487275388316, ; 639: 0xda886ac407a5ed9c => br/com/daruma/framework/mobile/tef/providers/destaxa/TefDefinesDestaxa
	i64 15767615218119146656, ; 640: 0xdad1d2801f08fca0 => javax/net/ssl/SSLSessionContext
	i64 15773716038598610423, ; 641: 0xdae77f2a148d4df7 => java/security/KeyStore$LoadStoreParameter
	i64 15775437104588773371, ; 642: 0xdaed9c76fb87d7fb => br/com/daruma/framework/mobile/webservice/MultipartUtility
	i64 15822548195610384481, ; 643: 0xdb94fbc0a0dad861 => br/com/itfast/tectoy/TecToyException
	i64 15840041216994670032, ; 644: 0xdbd321900e8375d0 => com/phi/gertec/sat/serial/SerialInputOutputManager$State
	i64 15843991622164778716, ; 645: 0xdbe12a6f6f658edc => com/sunmi/peripheral/printer/SystemPropertyUtil
	i64 15849413346686472626, ; 646: 0xdbf46d770b9511b2 => com/hoho/android/usbserial/driver/UsbSerialProber
	i64 15888603495552893685, ; 647: 0xdc7fa8b2a175c2f5 => javax/net/ssl/TrustManager
	i64 15896143924811176167, ; 648: 0xdc9a72ada0da98e7 => java/net/SocketException
	i64 15903381088602683559, ; 649: 0xdcb428d721d3f8a7 => br/com/daruma/framework/mobile/sat/impostos/Icms00
	i64 15949051304247903982, ; 650: 0xdd5669a8d62d46ee => java/nio/channels/ByteChannel
	i64 15991599324720671407, ; 651: 0xdded92dbd45a2aaf => br/com/daruma/framework/mobile/camera/dependencies/Intents$Scan
	i64 16003229482241506982, ; 652: 0xde16e46ce4103ea6 => android/graphics/Bitmap
	i64 16027117714948520207, ; 653: 0xde6bc2a57ce0790f => java/util/AbstractCollection
	i64 16050197778822779286, ; 654: 0xdebdc1d79d7ed196 => br/com/daruma/framework/mobile/log/DarumaLogger
	i64 16146455692085722758, ; 655: 0xe013bbe7845a7e86 => crc642a20111c1f951464/MainActivity
	i64 16168692235137199071, ; 656: 0xe062bbec25f82bdf => com/hoho/android/usbserial/driver/ProbeTable
	i64 16170603982710859185, ; 657: 0xe06986a590ff65b1 => android/view/ViewTreeObserver
	i64 16190485749137921007, ; 658: 0xe0b029020a63d3ef => android/content/ServiceConnection
	i64 16314168557433322311, ; 659: 0xe26791dde7a8fb47 => android/view/ContextThemeWrapper
	i64 16395504991077438774, ; 660: 0xe38888ec1a509536 => java/nio/ByteBuffer
	i64 16413651262945443612, ; 661: 0xe3c900dc43013f1c => android/content/DialogInterface$OnClickListener
	i64 16471595371099925085, ; 662: 0xe496dcb842612a5d => android/hardware/usb/UsbEndpoint
	i64 16480206070542885578, ; 663: 0xe4b5741af3f1e2ca => android/view/SearchEvent
	i64 16530905335535283041, ; 664: 0xe56992d17430ab61 => androidx/loader/app/LoaderManager$LoaderCallbacks
	i64 16542847110558016359, ; 665: 0xe593ffcc9e686367 => android/app/Application
	i64 16543572318389959461, ; 666: 0xe596935f399e7b25 => java/lang/reflect/TypeVariable
	i64 16552932381508269184, ; 667: 0xe5b7d44cbedc7480 => mono/br/com/daruma/framework/mobile/log/listeners/ITraceListenerImplementor
	i64 16603717322881265010, ; 668: 0xe66c40ef55566d72 => mono/android/runtime/JavaObject
	i64 16645540958114363132, ; 669: 0xe700d74f3e9f36fc => java/util/function/Predicate
	i64 16723123314454325679, ; 670: 0xe814780d351a69af => mono/android/runtime/InputStreamAdapter
	i64 16732048506261937943, ; 671: 0xe8342d775c591f17 => android/graphics/PorterDuff$Mode
	i64 16765726315628336714, ; 672: 0xe8abd3416472164a => br/com/daruma/framework/mobile/gne/nfce/xml/classes/Icms00Auxiliar
	i64 16790214823577746386, ; 673: 0xe902d36c75d97bd2 => br/com/daruma/framework/mobile/sat/PersistenciaXML
	i64 16820626401270516320, ; 674: 0xe96ede97ab494a60 => br/com/daruma/framework/mobile/sat/impostos/Icms40
	i64 16832017439803262409, ; 675: 0xe99756ae80a745c9 => android/view/ViewGroup
	i64 16837342776755300531, ; 676: 0xe9aa420c21fd28b3 => br/com/daruma/framework/mobile/gne/nfce/xml/classes/PI
	i64 16878061737430998064, ; 677: 0xea3aebb9f4afdc30 => android/content/SharedPreferences$Editor
	i64 16916694887332905051, ; 678: 0xeac42c5f1d25005b => androidx/fragment/app/FragmentManager$FragmentLifecycleCallbacks
	i64 16943686363877129330, ; 679: 0xeb2410f9f886bc72 => br/com/daruma/framework/mobile/sat/elementosCFe/Pgto
	i64 16945863039838877624, ; 680: 0xeb2bcca6d60477b8 => br/com/itfast/tectoy/service/TecToyService
	i64 16949037757986326757, ; 681: 0xeb37140a817548e5 => br/com/daruma/framework/mobile/gne/imp/Datec_350
	i64 16980384157135303443, ; 682: 0xeba6716ccbb87313 => com/orbbec/astra/android/UsbDeviceAccessBroker
	i64 17036525530678597317, ; 683: 0xec6de5b4eef896c5 => mono/com/phi/gertec/sat/satger/SatGerConnectionManager_ListenerImplementor
	i64 17053113564791162236, ; 684: 0xeca8d46f97c5c57c => androidx/lifecycle/Observer
	i64 17074618793512191257, ; 685: 0xecf53b53d680c519 => br/com/daruma/framework/mobile/gne/sat/Layout
	i64 17125416866214736517, ; 686: 0xeda9b3e7cd367285 => java/io/OutputStream
	i64 17138867359847802672, ; 687: 0xedd97d0ee443e730 => com/hoho/android/usbserial/driver/UsbSerialPort
	i64 17141453864487655192, ; 688: 0xede2ad786e889718 => com/orbbec/astra/Plane
	i64 17163176023095185573, ; 689: 0xee2fd9a89a1710a5 => android/graphics/Matrix
	i64 17163286946476697887, ; 690: 0xee303e8af6d7a91f => com/hoho/android/usbserial/driver/FtdiSerialDriver
	i64 17163671098606208407, ; 691: 0xee319bed5a0fc597 => br/com/daruma/framework/mobile/camera/dependencies/InactivityTimer$DaemonThreadFactory
	i64 17169091267875271145, ; 692: 0xee44dd8ad9f771e9 => br/com/daruma/framework/mobile/gne/nfce/xml/classes/MT
	i64 17293793662859938548, ; 693: 0xefffe5b5bdab0af4 => java/lang/StringBuffer
	i64 17297982798613653460, ; 694: 0xf00ec7b4ea2f27d4 => com/orbbec/astra/Vector2D
	i64 17312589003384955623, ; 695: 0xf042abf8f91822e7 => android/view/KeyEvent
	i64 17337917124356380403, ; 696: 0xf09ca7c3ae6c96f3 => com/hoho/android/usbserial/driver/Ch34xSerialDriver
	i64 17405205501308712532, ; 697: 0xf18bb62fcc2e3654 => androidx/loader/content/Loader$OnLoadCanceledListener
	i64 17453567047854375054, ; 698: 0xf23786c1ced2c08e => br/com/daruma/framework/mobile/gne/nfce/xml/classes/Icms51Auxiliar
	i64 17460122322948329767, ; 699: 0xf24ed0beba341127 => br/com/daruma/framework/mobile/gne/nfce/xml/Objetos
	i64 17490083481060646178, ; 700: 0xf2b94242748c1d22 => java/util/Enumeration
	i64 17498018958444438720, ; 701: 0xf2d57388c321a4c0 => java/lang/Double
	i64 17499752140262191063, ; 702: 0xf2db9bda99b5afd7 => java/lang/ReflectiveOperationException
	i64 17519581955836770800, ; 703: 0xf3220ef752fe79f0 => java/security/KeyStore
	i64 17542023464739623563, ; 704: 0xf371c966495f528b => android/view/Display
	i64 17547627503543204281, ; 705: 0xf385b23e3f9139b9 => com/hoho/android/usbserial/driver/Cp21xxSerialDriver
	i64 17565026281182206278, ; 706: 0xf3c38256d8441946 => br/com/daruma/framework/mobile/gne/sat/Dimep
	i64 17568151666794960649, ; 707: 0xf3ce9cdc63801709 => br/com/daruma/framework/mobile/gne/nfce/xml/classes/PR
	i64 17577192642853218030, ; 708: 0xf3eebb94a9e026ee => br/com/daruma/framework/mobile/gne/nfse/xml/Xml_ElementosEnvioNFSe
	i64 17580647119575126492, ; 709: 0xf3fb0168b3c511dc => br/com/daruma/framework/mobile/gne/imp/Daruma_2100
	i64 17605619666541934257, ; 710: 0xf453b9cee2dcf6b1 => java/net/Proxy$Type
	i64 17608877981747935975, ; 711: 0xf45f4d3a83487ae7 => java/nio/Buffer
	i64 17645817129531856090, ; 712: 0xf4e28930113fd4da => java/io/Closeable
	i64 17671382671565006709, ; 713: 0xf53d5ce9aca02775 => androidx/fragment/app/FragmentTransaction
	i64 17672504001507146299, ; 714: 0xf54158c1a580ba3b => androidx/appcompat/graphics/drawable/DrawerArrowDrawable
	i64 17682986026741916978, ; 715: 0xf566961a5425e532 => java/util/AbstractSet
	i64 17697604627412404492, ; 716: 0xf59a85a48839c90c => android/hardware/usb/UsbDeviceConnection
	i64 17701458390097140928, ; 717: 0xf5a8369e94191cc0 => br/com/daruma/framework/mobile/sat/elementosCFe/Total
	i64 17709631020093890093, ; 718: 0xf5c53f9547ef5e2d => br/com/daruma/framework/mobile/webservice/ITServiceWs
	i64 17760015225186829027, ; 719: 0xf6783fc02eca42e3 => br/com/daruma/framework/mobile/gne/sat/EPSON
	i64 17800186900405514025, ; 720: 0xf706f7ad2e3b6f29 => android/util/SparseArray
	i64 17812995004950615793, ; 721: 0xf734789467e396f1 => com/hoho/android/usbserial/driver/CommonUsbSerialPort
	i64 17956533498635850486, ; 722: 0xf9326c14479792f6 => androidx/core/view/KeyEventDispatcher$Component
	i64 17996807661669935528, ; 723: 0xf9c1813794dd69a8 => br/com/daruma/framework/mobile/gne/nfce/xml/classes/DF
	i64 18049202079075236650, ; 724: 0xfa7ba5a982857b2a => com/orbbec/astra/ImageFrame
	i64 18085077564113847923, ; 725: 0xfafb1a39c8648673 => br/com/daruma/framework/mobile/sat/elementosCFe/Prod
	i64 18142146133774289576, ; 726: 0xfbc5d9c996d7caa8 => br/com/daruma/framework/mobile/gne/nfce/xml/classes/CideAuxiliar
	i64 18156570996608615392, ; 727: 0xfbf9191fb00443e0 => com/orbbec/astra/android/UsbDeviceAccessBroker$UsbDeviceAccessEventListener
	i64 18164517981324324772, ; 728: 0xfc1554dd41082fa4 => br/com/daruma/framework/mobile/gne/nfce/xml/classes/EnderEmitAuxiliar
	i64 18168729229555601518, ; 729: 0xfc244af8e3eb106e => androidx/core/internal/view/SupportMenu
	i64 18186210341675709013, ; 730: 0xfc6265f37a1db255 => br/com/itfast/tectoy/service/UsbControl
	i64 18213852175163534091, ; 731: 0xfcc49a0d5c192b0b => android/content/SharedPreferences$OnSharedPreferenceChangeListener
	i64 18216578448169670053, ; 732: 0xfcce4995423095a5 => javax/net/ssl/SSLSocketFactory
	i64 18300996817999718501, ; 733: 0xfdfa33a4a46d6865 => br/com/daruma/framework/mobile/tef/providers/destaxa/RetornoTefDestaxa
	i64 18305072677744240575, ; 734: 0xfe08ae9db0a767bf => com/orbbec/astra/ApiStatus
	i64 18324467920910074174, ; 735: 0xfe4d967ca3e2c13e => br/com/daruma/framework/mobile/exception/DarumaSatException
	i64 18361981661270223945, ; 736: 0xfed2dd08f43fac49 => java/util/logging/FileHandler
	i64 18376227498216060055, ; 737: 0xff05798c56eef497 => android/hardware/usb/UsbDevice
	i64 18377678852537561597, ; 738: 0xff0aa18c19b5b1fd => br/com/itfast/tectoy/Dispositivo
	i64 18401512074820890716, ; 739: 0xff5f4dbc95c2b05c => java/lang/Float
	i64 18401692079723824300, ; 740: 0xff5ff1733e0ec4ac => java/util/Collection
	i64 18415663111390474355, ; 741: 0xff91940789b1b073 => java/util/Set
	i64 18425195701544362018 ; 742: 0xffb371dea39b2022 => java/io/DataInputStream
], align 8

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
], align 8

!llvm.module.flags = !{!0, !1, !2, !3, !4, !5}
!llvm.ident = !{!6}
!0 = !{i32 1, !"wchar_size", i32 4}
!1 = !{i32 7, !"PIC Level", i32 2}
!2 = !{i32 1, !"branch-target-enforcement", i32 0}
!3 = !{i32 1, !"sign-return-address", i32 0}
!4 = !{i32 1, !"sign-return-address-all", i32 0}
!5 = !{i32 1, !"sign-return-address-with-bkey", i32 0}
!6 = !{!"Xamarin.Android remotes/origin/d17-5 @ a200af12c1e846626b8caebd926ac14c185f71ec"}
