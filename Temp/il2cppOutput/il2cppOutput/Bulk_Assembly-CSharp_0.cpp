#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <cstring>
#include <string.h>
#include <stdio.h>
#include <cmath>
#include <limits>
#include <assert.h>

// CameraController
struct CameraController_t3473169601;
// MenuManager
struct MenuManager_t3994435886;
// System.String
struct String_t;
// Movement
struct Movement_t4255933647;

#include "class-internals.h"
#include "codegen/il2cpp-codegen.h"
#include "mscorlib_System_Array1146569071.h"
#include "AssemblyU2DCSharp_U3CModuleU3E86524790.h"
#include "AssemblyU2DCSharp_U3CModuleU3E86524790MethodDeclarations.h"
#include "AssemblyU2DCSharp_CameraController3473169601.h"
#include "AssemblyU2DCSharp_CameraController3473169601MethodDeclarations.h"
#include "mscorlib_System_Void2863195528.h"
#include "UnityEngine_UnityEngine_MonoBehaviour667441552MethodDeclarations.h"
#include "UnityEngine_UnityEngine_Component3501516275MethodDeclarations.h"
#include "UnityEngine_UnityEngine_Transform1659122786MethodDeclarations.h"
#include "UnityEngine_UnityEngine_GameObject3674682005MethodDeclarations.h"
#include "UnityEngine_UnityEngine_Vector34282066566MethodDeclarations.h"
#include "UnityEngine_UnityEngine_Transform1659122786.h"
#include "UnityEngine_UnityEngine_Vector34282066566.h"
#include "UnityEngine_UnityEngine_GameObject3674682005.h"
#include "AssemblyU2DCSharp_MenuManager3994435886.h"
#include "AssemblyU2DCSharp_MenuManager3994435886MethodDeclarations.h"
#include "mscorlib_System_String7231557.h"
#include "UnityEngine_UnityEngine_Application2856536070MethodDeclarations.h"
#include "AssemblyU2DCSharp_Movement4255933647.h"
#include "AssemblyU2DCSharp_Movement4255933647MethodDeclarations.h"
#include "mscorlib_System_Single4291918972.h"
#include "mscorlib_System_Boolean476798718.h"
#include "UnityEngine_UnityEngine_Input4200062272MethodDeclarations.h"
#include "UnityEngine_UnityEngine_Time4241968337MethodDeclarations.h"
#include "UnityEngine_UnityEngine_KeyCode3128317986.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void CameraController::.ctor()
extern "C"  void CameraController__ctor_m1305907962 (CameraController_t3473169601 * __this, const MethodInfo* method)
{
	{
		MonoBehaviour__ctor_m2022291967(__this, /*hidden argument*/NULL);
		return;
	}
}
// System.Void CameraController::Start()
extern "C"  void CameraController_Start_m253045754 (CameraController_t3473169601 * __this, const MethodInfo* method)
{
	{
		Transform_t1659122786 * L_0 = Component_get_transform_m4257140443(__this, /*hidden argument*/NULL);
		NullCheck(L_0);
		Vector3_t4282066566  L_1 = Transform_get_position_m2211398607(L_0, /*hidden argument*/NULL);
		GameObject_t3674682005 * L_2 = __this->get_player_2();
		NullCheck(L_2);
		Transform_t1659122786 * L_3 = GameObject_get_transform_m1278640159(L_2, /*hidden argument*/NULL);
		NullCheck(L_3);
		Vector3_t4282066566  L_4 = Transform_get_position_m2211398607(L_3, /*hidden argument*/NULL);
		Vector3_t4282066566  L_5 = Vector3_op_Subtraction_m2842958165(NULL /*static, unused*/, L_1, L_4, /*hidden argument*/NULL);
		__this->set_offset_3(L_5);
		return;
	}
}
// System.Void CameraController::LateUpdate()
extern "C"  void CameraController_LateUpdate_m786793369 (CameraController_t3473169601 * __this, const MethodInfo* method)
{
	{
		Transform_t1659122786 * L_0 = Component_get_transform_m4257140443(__this, /*hidden argument*/NULL);
		GameObject_t3674682005 * L_1 = __this->get_player_2();
		NullCheck(L_1);
		Transform_t1659122786 * L_2 = GameObject_get_transform_m1278640159(L_1, /*hidden argument*/NULL);
		NullCheck(L_2);
		Vector3_t4282066566  L_3 = Transform_get_position_m2211398607(L_2, /*hidden argument*/NULL);
		Vector3_t4282066566  L_4 = __this->get_offset_3();
		Vector3_t4282066566  L_5 = Vector3_op_Addition_m695438225(NULL /*static, unused*/, L_3, L_4, /*hidden argument*/NULL);
		NullCheck(L_0);
		Transform_set_position_m3111394108(L_0, L_5, /*hidden argument*/NULL);
		return;
	}
}
// System.Void MenuManager::.ctor()
extern "C"  void MenuManager__ctor_m1757457917 (MenuManager_t3994435886 * __this, const MethodInfo* method)
{
	{
		MonoBehaviour__ctor_m2022291967(__this, /*hidden argument*/NULL);
		return;
	}
}
// System.Void MenuManager::ChangeScene(System.String)
extern "C"  void MenuManager_ChangeScene_m1777420555 (MenuManager_t3994435886 * __this, String_t* ___sceneName0, const MethodInfo* method)
{
	{
		String_t* L_0 = ___sceneName0;
		Application_LoadLevel_m2722573885(NULL /*static, unused*/, L_0, /*hidden argument*/NULL);
		return;
	}
}
// System.Void MenuManager::QuitGame()
extern "C"  void MenuManager_QuitGame_m1290205000 (MenuManager_t3994435886 * __this, const MethodInfo* method)
{
	{
		Application_Quit_m1187862186(NULL /*static, unused*/, /*hidden argument*/NULL);
		return;
	}
}
// System.Void Movement::.ctor()
extern "C"  void Movement__ctor_m3823588012 (Movement_t4255933647 * __this, const MethodInfo* method)
{
	{
		MonoBehaviour__ctor_m2022291967(__this, /*hidden argument*/NULL);
		return;
	}
}
// System.Void Movement::Start()
extern "C"  void Movement_Start_m2770725804 (Movement_t4255933647 * __this, const MethodInfo* method)
{
	{
		__this->set_speed_2((1.0f));
		__this->set_isFlipped_3((bool)0);
		return;
	}
}
// System.Void Movement::Update()
extern Il2CppClass* Input_t4200062272_il2cpp_TypeInfo_var;
extern const uint32_t Movement_Update_m4293973473_MetadataUsageId;
extern "C"  void Movement_Update_m4293973473 (Movement_t4255933647 * __this, const MethodInfo* method)
{
	static bool s_Il2CppMethodIntialized;
	if (!s_Il2CppMethodIntialized)
	{
		il2cpp_codegen_initialize_method (Movement_Update_m4293973473_MetadataUsageId);
		s_Il2CppMethodIntialized = true;
	}
	{
		IL2CPP_RUNTIME_CLASS_INIT(Input_t4200062272_il2cpp_TypeInfo_var);
		bool L_0 = Input_GetKey_m1349175653(NULL /*static, unused*/, ((int32_t)119), /*hidden argument*/NULL);
		if (!L_0)
		{
			goto IL_003c;
		}
	}
	{
		Transform_t1659122786 * L_1 = Component_get_transform_m4257140443(__this, /*hidden argument*/NULL);
		Transform_t1659122786 * L_2 = L_1;
		NullCheck(L_2);
		Vector3_t4282066566  L_3 = Transform_get_position_m2211398607(L_2, /*hidden argument*/NULL);
		Vector3_t4282066566  L_4 = Vector3_get_up_m4046647141(NULL /*static, unused*/, /*hidden argument*/NULL);
		float L_5 = __this->get_speed_2();
		Vector3_t4282066566  L_6 = Vector3_op_Multiply_m973638459(NULL /*static, unused*/, L_4, L_5, /*hidden argument*/NULL);
		float L_7 = Time_get_deltaTime_m2741110510(NULL /*static, unused*/, /*hidden argument*/NULL);
		Vector3_t4282066566  L_8 = Vector3_op_Multiply_m973638459(NULL /*static, unused*/, L_6, L_7, /*hidden argument*/NULL);
		Vector3_t4282066566  L_9 = Vector3_op_Addition_m695438225(NULL /*static, unused*/, L_3, L_8, /*hidden argument*/NULL);
		NullCheck(L_2);
		Transform_set_position_m3111394108(L_2, L_9, /*hidden argument*/NULL);
	}

IL_003c:
	{
		IL2CPP_RUNTIME_CLASS_INIT(Input_t4200062272_il2cpp_TypeInfo_var);
		bool L_10 = Input_GetKey_m1349175653(NULL /*static, unused*/, ((int32_t)97), /*hidden argument*/NULL);
		if (!L_10)
		{
			goto IL_0090;
		}
	}
	{
		bool L_11 = __this->get_isFlipped_3();
		if (L_11)
		{
			goto IL_0060;
		}
	}
	{
		Movement_Flip_m2480991813(__this, /*hidden argument*/NULL);
		__this->set_isFlipped_3((bool)1);
	}

IL_0060:
	{
		Transform_t1659122786 * L_12 = Component_get_transform_m4257140443(__this, /*hidden argument*/NULL);
		Transform_t1659122786 * L_13 = L_12;
		NullCheck(L_13);
		Vector3_t4282066566  L_14 = Transform_get_position_m2211398607(L_13, /*hidden argument*/NULL);
		Vector3_t4282066566  L_15 = Vector3_get_left_m1616598929(NULL /*static, unused*/, /*hidden argument*/NULL);
		float L_16 = __this->get_speed_2();
		Vector3_t4282066566  L_17 = Vector3_op_Multiply_m973638459(NULL /*static, unused*/, L_15, L_16, /*hidden argument*/NULL);
		float L_18 = Time_get_deltaTime_m2741110510(NULL /*static, unused*/, /*hidden argument*/NULL);
		Vector3_t4282066566  L_19 = Vector3_op_Multiply_m973638459(NULL /*static, unused*/, L_17, L_18, /*hidden argument*/NULL);
		Vector3_t4282066566  L_20 = Vector3_op_Addition_m695438225(NULL /*static, unused*/, L_14, L_19, /*hidden argument*/NULL);
		NullCheck(L_13);
		Transform_set_position_m3111394108(L_13, L_20, /*hidden argument*/NULL);
	}

IL_0090:
	{
		IL2CPP_RUNTIME_CLASS_INIT(Input_t4200062272_il2cpp_TypeInfo_var);
		bool L_21 = Input_GetKey_m1349175653(NULL /*static, unused*/, ((int32_t)115), /*hidden argument*/NULL);
		if (!L_21)
		{
			goto IL_00cc;
		}
	}
	{
		Transform_t1659122786 * L_22 = Component_get_transform_m4257140443(__this, /*hidden argument*/NULL);
		Transform_t1659122786 * L_23 = L_22;
		NullCheck(L_23);
		Vector3_t4282066566  L_24 = Transform_get_position_m2211398607(L_23, /*hidden argument*/NULL);
		Vector3_t4282066566  L_25 = Vector3_get_down_m1397301612(NULL /*static, unused*/, /*hidden argument*/NULL);
		float L_26 = __this->get_speed_2();
		Vector3_t4282066566  L_27 = Vector3_op_Multiply_m973638459(NULL /*static, unused*/, L_25, L_26, /*hidden argument*/NULL);
		float L_28 = Time_get_deltaTime_m2741110510(NULL /*static, unused*/, /*hidden argument*/NULL);
		Vector3_t4282066566  L_29 = Vector3_op_Multiply_m973638459(NULL /*static, unused*/, L_27, L_28, /*hidden argument*/NULL);
		Vector3_t4282066566  L_30 = Vector3_op_Addition_m695438225(NULL /*static, unused*/, L_24, L_29, /*hidden argument*/NULL);
		NullCheck(L_23);
		Transform_set_position_m3111394108(L_23, L_30, /*hidden argument*/NULL);
	}

IL_00cc:
	{
		IL2CPP_RUNTIME_CLASS_INIT(Input_t4200062272_il2cpp_TypeInfo_var);
		bool L_31 = Input_GetKey_m1349175653(NULL /*static, unused*/, ((int32_t)100), /*hidden argument*/NULL);
		if (!L_31)
		{
			goto IL_0120;
		}
	}
	{
		bool L_32 = __this->get_isFlipped_3();
		if (!L_32)
		{
			goto IL_00f0;
		}
	}
	{
		Movement_Flip_m2480991813(__this, /*hidden argument*/NULL);
		__this->set_isFlipped_3((bool)0);
	}

IL_00f0:
	{
		Transform_t1659122786 * L_33 = Component_get_transform_m4257140443(__this, /*hidden argument*/NULL);
		Transform_t1659122786 * L_34 = L_33;
		NullCheck(L_34);
		Vector3_t4282066566  L_35 = Transform_get_position_m2211398607(L_34, /*hidden argument*/NULL);
		Vector3_t4282066566  L_36 = Vector3_get_right_m4015137012(NULL /*static, unused*/, /*hidden argument*/NULL);
		float L_37 = __this->get_speed_2();
		Vector3_t4282066566  L_38 = Vector3_op_Multiply_m973638459(NULL /*static, unused*/, L_36, L_37, /*hidden argument*/NULL);
		float L_39 = Time_get_deltaTime_m2741110510(NULL /*static, unused*/, /*hidden argument*/NULL);
		Vector3_t4282066566  L_40 = Vector3_op_Multiply_m973638459(NULL /*static, unused*/, L_38, L_39, /*hidden argument*/NULL);
		Vector3_t4282066566  L_41 = Vector3_op_Addition_m695438225(NULL /*static, unused*/, L_35, L_40, /*hidden argument*/NULL);
		NullCheck(L_34);
		Transform_set_position_m3111394108(L_34, L_41, /*hidden argument*/NULL);
	}

IL_0120:
	{
		return;
	}
}
// System.Void Movement::Flip()
extern "C"  void Movement_Flip_m2480991813 (Movement_t4255933647 * __this, const MethodInfo* method)
{
	Vector3_t4282066566  V_0;
	memset(&V_0, 0, sizeof(V_0));
	{
		Transform_t1659122786 * L_0 = Component_get_transform_m4257140443(__this, /*hidden argument*/NULL);
		NullCheck(L_0);
		Vector3_t4282066566  L_1 = Transform_get_localScale_m3886572677(L_0, /*hidden argument*/NULL);
		V_0 = L_1;
		Vector3_t4282066566 * L_2 = (&V_0);
		float L_3 = L_2->get_x_1();
		L_2->set_x_1(((float)((float)L_3*(float)(-1.0f))));
		Transform_t1659122786 * L_4 = Component_get_transform_m4257140443(__this, /*hidden argument*/NULL);
		Vector3_t4282066566  L_5 = V_0;
		NullCheck(L_4);
		Transform_set_localScale_m310756934(L_4, L_5, /*hidden argument*/NULL);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
