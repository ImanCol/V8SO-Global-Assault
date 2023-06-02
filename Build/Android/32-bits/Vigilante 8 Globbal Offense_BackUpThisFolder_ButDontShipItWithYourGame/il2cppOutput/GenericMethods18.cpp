#include "pch-cpp.hpp"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif


#include <stdint.h>
#include <limits>


template <typename T1>
struct VirtualActionInvoker1
{
	typedef void (*Action)(void*, T1, const RuntimeMethod*);

	static inline void Invoke (Il2CppMethodSlot slot, RuntimeObject* obj, T1 p1)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_virtual_invoke_data(slot, obj);
		((Action)invokeData.methodPtr)(obj, p1, invokeData.method);
	}
};
template <typename T1, typename T2>
struct VirtualActionInvoker2
{
	typedef void (*Action)(void*, T1, T2, const RuntimeMethod*);

	static inline void Invoke (Il2CppMethodSlot slot, RuntimeObject* obj, T1 p1, T2 p2)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_virtual_invoke_data(slot, obj);
		((Action)invokeData.methodPtr)(obj, p1, p2, invokeData.method);
	}
};
template <typename R>
struct VirtualFuncInvoker0
{
	typedef R (*Func)(void*, const RuntimeMethod*);

	static inline R Invoke (Il2CppMethodSlot slot, RuntimeObject* obj)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_virtual_invoke_data(slot, obj);
		return ((Func)invokeData.methodPtr)(obj, invokeData.method);
	}
};
template <typename R, typename T1>
struct VirtualFuncInvoker1
{
	typedef R (*Func)(void*, T1, const RuntimeMethod*);

	static inline R Invoke (Il2CppMethodSlot slot, RuntimeObject* obj, T1 p1)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_virtual_invoke_data(slot, obj);
		return ((Func)invokeData.methodPtr)(obj, p1, invokeData.method);
	}
};
template <typename R, typename T1, typename T2>
struct VirtualFuncInvoker2
{
	typedef R (*Func)(void*, T1, T2, const RuntimeMethod*);

	static inline R Invoke (Il2CppMethodSlot slot, RuntimeObject* obj, T1 p1, T2 p2)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_virtual_invoke_data(slot, obj);
		return ((Func)invokeData.methodPtr)(obj, p1, p2, invokeData.method);
	}
};
template <typename R, typename T1, typename T2, typename T3, typename T4>
struct VirtualFuncInvoker4
{
	typedef R (*Func)(void*, T1, T2, T3, T4, const RuntimeMethod*);

	static inline R Invoke (Il2CppMethodSlot slot, RuntimeObject* obj, T1 p1, T2 p2, T3 p3, T4 p4)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_virtual_invoke_data(slot, obj);
		return ((Func)invokeData.methodPtr)(obj, p1, p2, p3, p4, invokeData.method);
	}
};
template <typename R>
struct GenericVirtualFuncInvoker0
{
	typedef R (*Func)(void*, const RuntimeMethod*);

	static inline R Invoke (const RuntimeMethod* method, RuntimeObject* obj)
	{
		VirtualInvokeData invokeData;
		il2cpp_codegen_get_generic_virtual_invoke_data(method, obj, &invokeData);
		return ((Func)invokeData.methodPtr)(obj, invokeData.method);
	}
};
struct InterfaceActionInvoker0
{
	typedef void (*Action)(void*, const RuntimeMethod*);

	static inline void Invoke (Il2CppMethodSlot slot, RuntimeClass* declaringInterface, RuntimeObject* obj)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_interface_invoke_data(slot, obj, declaringInterface);
		((Action)invokeData.methodPtr)(obj, invokeData.method);
	}
};
template <typename T1>
struct InterfaceActionInvoker1
{
	typedef void (*Action)(void*, T1, const RuntimeMethod*);

	static inline void Invoke (Il2CppMethodSlot slot, RuntimeClass* declaringInterface, RuntimeObject* obj, T1 p1)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_interface_invoke_data(slot, obj, declaringInterface);
		((Action)invokeData.methodPtr)(obj, p1, invokeData.method);
	}
};
template <typename T1, typename T2>
struct InterfaceActionInvoker2
{
	typedef void (*Action)(void*, T1, T2, const RuntimeMethod*);

	static inline void Invoke (Il2CppMethodSlot slot, RuntimeClass* declaringInterface, RuntimeObject* obj, T1 p1, T2 p2)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_interface_invoke_data(slot, obj, declaringInterface);
		((Action)invokeData.methodPtr)(obj, p1, p2, invokeData.method);
	}
};
template <typename R>
struct InterfaceFuncInvoker0
{
	typedef R (*Func)(void*, const RuntimeMethod*);

	static inline R Invoke (Il2CppMethodSlot slot, RuntimeClass* declaringInterface, RuntimeObject* obj)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_interface_invoke_data(slot, obj, declaringInterface);
		return ((Func)invokeData.methodPtr)(obj, invokeData.method);
	}
};
template <typename R, typename T1>
struct InterfaceFuncInvoker1
{
	typedef R (*Func)(void*, T1, const RuntimeMethod*);

	static inline R Invoke (Il2CppMethodSlot slot, RuntimeClass* declaringInterface, RuntimeObject* obj, T1 p1)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_interface_invoke_data(slot, obj, declaringInterface);
		return ((Func)invokeData.methodPtr)(obj, p1, invokeData.method);
	}
};
template <typename R>
struct GenericInterfaceFuncInvoker0
{
	typedef R (*Func)(void*, const RuntimeMethod*);

	static inline R Invoke (const RuntimeMethod* method, RuntimeObject* obj)
	{
		VirtualInvokeData invokeData;
		il2cpp_codegen_get_generic_interface_invoke_data(method, obj, &invokeData);
		return ((Func)invokeData.methodPtr)(obj, invokeData.method);
	}
};
template <typename R, typename T1, typename T2>
struct GenericInterfaceFuncInvoker2
{
	typedef R (*Func)(void*, T1, T2, const RuntimeMethod*);

	static inline R Invoke (const RuntimeMethod* method, RuntimeObject* obj, T1 p1, T2 p2)
	{
		VirtualInvokeData invokeData;
		il2cpp_codegen_get_generic_interface_invoke_data(method, obj, &invokeData);
		return ((Func)invokeData.methodPtr)(obj, p1, p2, invokeData.method);
	}
};
template <typename R, typename T1, typename T2, typename T3>
struct GenericInterfaceFuncInvoker3
{
	typedef R (*Func)(void*, T1, T2, T3, const RuntimeMethod*);

	static inline R Invoke (const RuntimeMethod* method, RuntimeObject* obj, T1 p1, T2 p2, T3 p3)
	{
		VirtualInvokeData invokeData;
		il2cpp_codegen_get_generic_interface_invoke_data(method, obj, &invokeData);
		return ((Func)invokeData.methodPtr)(obj, p1, p2, p3, invokeData.method);
	}
};

// Rewired.Utils.Classes.Data.ADictionary`2<System.Int32,TAqjagBhKGcWECRbpfkHPNKbpxLsA/rjYIYGThyzcIjjKJcsAtqiSHJmxp>
struct ADictionary_2_tE7D442DC62B8CFFF9D86A864353481277AAAE32F;
// Rewired.Utils.Classes.Data.ADictionary`2<System.Object,System.Object>
struct ADictionary_2_t95DEC58ADD1420C20E0CB2463868ED1353F2C657;
// Rewired.Utils.Classes.Data.ADictionary`2<System.Type,System.Collections.Generic.List`1<System.Object>>
struct ADictionary_2_tE212D15054E58919DA98BE219858633B9BBE9C90;
// Rewired.Utils.Classes.Data.AList`1<Rewired.ActionElementMap>
struct AList_1_t26BA8BE4BEB503507B02BE892DA37BBBAA585997;
// Rewired.Utils.Classes.Data.AList`1<Rewired.IControllerTemplate>
struct AList_1_t6F028F71F04E9F8A363286413FD2E2C6C409F5B5;
// Rewired.Utils.Classes.Data.AList`1<System.Object>
struct AList_1_t8AC95BE03ABEFD201943BE98AD0C21498B716AD0;
// Rewired.Utils.Classes.Data.AList`1<PjzdStrqNkNQSljwEZWJWYcQhjVQ/xcjUJvCGhYqGWwkvUdNHjHWxoqqC>
struct AList_1_t383F862B062A593BE3A73799E560A8F64BA62D5D;
// System.Action`1<System.Boolean>
struct Action_1_t10DCB0C07D0D3C565CEACADC80D1152B35A45F6C;
// System.Action`1<Rewired.ControllerStatusChangedEventArgs>
struct Action_1_tBAD7548A2A88259FFDD9D2AF491DA79E19CB5D95;
// System.Action`1<System.Exception>
struct Action_1_tAFBD759E01ADE1CCF9C2015D5EFB3E69A9F26F04;
// System.Action`1<UnityEngine.FullScreenMode>
struct Action_1_t329A050FC7346A8E8F6E91FE9C9D3F99F35609E6;
// System.Action`1<System.Object>
struct Action_1_t6F9EB113EB3F16226AEF811A2744F4111C116C87;
// System.Action`1<Rewired.UpdateLoopType>
struct Action_1_t60FB4C2B07126A34E8B4816D36F7A2065E957637;
// System.Action`1<UnityEngine.InputSystem.InputActionRebindingExtensions/RebindingOperation>
struct Action_1_tF6BB59F9C8D153E48DFC364061E5356934611FDD;
// System.Action`2<Rewired.ControllerType,System.Int32>
struct Action_2_t803BE0EB18DDC66CA042F1CCF405EFB2D468146D;
// System.Action`2<UnityEngine.InputSystem.LowLevel.InputEventPtr,UnityEngine.InputSystem.InputDevice>
struct Action_2_t4943DD8C32CAB983950535CEF3BABA85DF8C9AAA;
// System.Action`2<System.Int32,Rewired.ControllerDataUpdater>
struct Action_2_t13979AF1641790E4111291C572345E665DD175C4;
// System.Action`2<System.Object,System.Action`1<System.Object>>
struct Action_2_tB8342B1788FB8809F861F5EE2A321470B67D4BBA;
// System.Action`2<System.Object,UnityEngine.InputSystem.InputActionChange>
struct Action_2_t4D6C6A84A6B44BE6193A1F64753F6E48558FBE9D;
// System.Action`2<UnityEngine.InputSystem.InputActionRebindingExtensions/RebindingOperation,System.String>
struct Action_2_t464826F5F8CD9F38C1A734DDCFBF2AE3CC4DBF79;
// System.Action`3<System.Boolean,System.Int32,System.Int32>
struct Action_3_t142D1F73AF66CEBC85F52240EC1B6207B558A40B;
// System.Collections.Generic.Dictionary`2<UnityEngine.InputSystem.InputControl,System.Single>
struct Dictionary_2_t955741F14981C0BAF47FDE7823F2703758A8723C;
// System.Collections.Generic.Dictionary`2<System.Int32,Rewired.Data.Mapping.AxisCalibrationInfo>
struct Dictionary_2_t227394DF2A4E3D645CB4EB5444857BABBB943E6D;
// System.Collections.Generic.Dictionary`2<System.Int32,Rewired.Data.ConfigVars/cDbmxJFXWVduXCjwppwkvgZNqeHu>
struct Dictionary_2_tEA566EE4F7F044784DCA00DA5477CFA792068B8C;
// System.Collections.Generic.Dictionary`2<System.Int32,Rewired.Data.ConfigVars/dwkgBlGxqjjCFmiEzxmVruJOuxuP>
struct Dictionary_2_tF06E3E42A9CAE3A7EA4814D3F7EB70038D0F03EF;
// System.Collections.Generic.Dictionary`2<System.Int32Enum,System.Object>
struct Dictionary_2_t514396B90715EDD83BB0470C76C2F426F9381C71;
// System.Collections.Generic.Dictionary`2<UnityEngine.InputSystem.Utilities.InternedString,System.Func`1<UnityEngine.InputSystem.Layouts.InputControlLayout>>
struct Dictionary_2_tFF0F3921D8B2465193365C2463B7D6A977E874DA;
// System.Collections.Generic.Dictionary`2<UnityEngine.InputSystem.Utilities.InternedString,UnityEngine.InputSystem.Utilities.InternedString[]>
struct Dictionary_2_tA8E192E813E347FF19EC3868E2C565607445394C;
// System.Collections.Generic.Dictionary`2<UnityEngine.InputSystem.Utilities.InternedString,UnityEngine.InputSystem.Layouts.InputControlLayout>
struct Dictionary_2_t058B78C04CBFB0F1C72F95C9880AE09DA041219F;
// System.Collections.Generic.Dictionary`2<UnityEngine.InputSystem.Utilities.InternedString,UnityEngine.InputSystem.Utilities.InternedString>
struct Dictionary_2_t433D1FE2CDB69C9F583F79D5252A34112439D0AD;
// System.Collections.Generic.Dictionary`2<UnityEngine.InputSystem.Utilities.InternedString,System.String>
struct Dictionary_2_tEB3FF1660C6129E11F3B4771A549DE9F169B5103;
// System.Collections.Generic.Dictionary`2<UnityEngine.InputSystem.Utilities.InternedString,System.Type>
struct Dictionary_2_t1FFEE4C9AF6AF524CAD4FDCEA8F3AB34E585451D;
// System.Collections.Generic.Dictionary`2<UnityEngine.InputSystem.Utilities.InternedString,UnityEngine.InputSystem.Layouts.InputControlLayout/Collection/PrecompiledLayout>
struct Dictionary_2_tD68C40116E127FE79F9E7AF07820CFDDBF20A8C1;
// System.Collections.Generic.Dictionary`2<System.Object,System.Object>
struct Dictionary_2_t14FE4A752A83D53771C584E4C8D14E01F2AFD7BA;
// System.Collections.Generic.Dictionary`2<System.String,System.Object>
struct Dictionary_2_tA348003A3C1CEFB3096E9D2A0BC7F1AC8EC4F710;
// System.Collections.Generic.Dictionary`2<System.String,Rewired.Utils.SafeDelegate>
struct Dictionary_2_t340D9BC5CF0537B47A79183E8A310B59364118DF;
// System.Collections.Generic.Dictionary`2<Rewired.InputMapper/JdpDLqzkBAGmKbSgujDlWammLWSdA,Rewired.Utils.SafeDelegate>
struct Dictionary_2_t501DD8094A745126C4C4ED68F7198F76A46828B2;
// UnityEngine.Rendering.DynamicArray`1<UnityEngine.Experimental.Rendering.RenderGraphModule.IRenderGraphResource>
struct DynamicArray_1_t401F46C0081DE185BCAB1D30DE8D6B6DC9AA6AFB;
// UnityEngine.Rendering.DynamicArray`1<System.Object>
struct DynamicArray_1_t7C64F5A74B7BA6F6B3589A766CADE3F59C6C7BCA;
// System.EventHandler`1<System.EventArgs>
struct EventHandler_1_tF2D41B212D800E7E7D00F9BDEA817E57153988BF;
// System.Func`2<Rewired.Data.UserData/PMmfElSRTHipvrooOqnrsVzyuehD/cTlcZwgBmjmwQjxeEhJdCJOLqDjC`1<System.Object>,System.Object>
struct Func_2_t47FA43C06CA3B7E69EECC5B0C6D36F44AADCB758;
// System.Func`2<UnityEngine.InputSystem.InputControl,System.String>
struct Func_2_t6880601B06FFA50F13EB20F6845F85618318BA8A;
// System.Func`2<System.Int32,System.Boolean>
struct Func_2_t63A057E8762189D8C22BF71360D00C1047680DFA;
// System.Func`2<System.Int32,System.Int32>
struct Func_2_t2FDA873D8482C79555CFB05233D610E8F1C7C354;
// System.Func`2<System.Int32,System.Single>
struct Func_2_tBBFF35F4EA206696290D8B23ED36491D37219FAF;
// System.Func`2<Rewired.KeyboardKeyCode,System.Int32>
struct Func_2_t240970B8565E959C4ACC2E19699CC15D8EA61648;
// System.Func`2<System.Object,System.Int32>
struct Func_2_t9A0D493A82DCC47C9C819A3B045E02D9B5DDCE1B;
// System.Func`2<System.Object,System.String>
struct Func_2_t8A4E59735D50CEA34C30F6CD6B5804A38327CD0B;
// System.Func`3<Rewired.Controller,System.Guid,System.Boolean>
struct Func_3_tF4129F872BD8CCCF0D22456285DD4191EE3A59E2;
// System.Func`3<Rewired.Controller,System.Object,System.Boolean>
struct Func_3_tFE04544F8517BA81CF80AC748CE401211FE150B0;
// System.Func`3<Rewired.Controller,System.Type,System.Boolean>
struct Func_3_t25669F6E536690B24E25E22CBF39D17E60F1401A;
// System.Func`3<UnityEngine.InputSystem.InputControl,UnityEngine.InputSystem.LowLevel.InputEventPtr,System.Single>
struct Func_3_tD434E786A74561C49424384EF1C6D03B9B0498F4;
// System.Func`3<System.Object,System.Collections.Generic.IList`1<System.Object>,System.Int32>
struct Func_3_tA2EC68432F49E8DB1FC81E592EA4A30855D5EE0E;
// System.Collections.Generic.HashSet`1<UnityEngine.InputSystem.Utilities.InternedString>
struct HashSet_1_t87C47CF88B1B88398D4F9A1E51E92F834CF5160B;
// System.Collections.Generic.IEnumerable`1<Rewired.ElementAssignmentConflictInfo>
struct IEnumerable_1_t2F3A4DDE274CE61147DE565CD73B1EC320634667;
// System.Collections.Generic.IEnumerable`1<System.Object>
struct IEnumerable_1_tF95C9E01A913DD50575531C8305932628663D9E9;
// System.Collections.Generic.IEnumerator`1<Rewired.ElementAssignmentConflictInfo>
struct IEnumerator_1_t06C290A1F7BB577F910141C06750DE2A683E9AFE;
// System.Collections.Generic.IEqualityComparer`1<System.Collections.Generic.List`1<System.Object>>
struct IEqualityComparer_1_t65B7B3062BD74FA459F51FDEE83F4D89978B35E3;
// System.Collections.Generic.IEqualityComparer`1<Rewired.ActionElementMap>
struct IEqualityComparer_1_t45FC1A33001F7F94C2A6F2E265DA80914EB38C82;
// System.Collections.Generic.IEqualityComparer`1<Rewired.IControllerTemplate>
struct IEqualityComparer_1_t87996B9615F4B5F8A12E46B590FE4FC565DBDE81;
// System.Collections.Generic.IEqualityComparer`1<System.Object>
struct IEqualityComparer_1_t2CA7720C7ADCCDECD3B02E45878B4478619D5347;
// System.Collections.Generic.IEqualityComparer`1<System.String>
struct IEqualityComparer_1_tAE94C8F24AD5B94D4EE85CA9FC59E3409D41CAF7;
// System.Collections.Generic.IEqualityComparer`1<System.Type>
struct IEqualityComparer_1_t0C79004BFE79D9DBCE6C2250109D31D468A9A68E;
// System.Collections.Generic.IEqualityComparer`1<Rewired.InputMapper/JdpDLqzkBAGmKbSgujDlWammLWSdA>
struct IEqualityComparer_1_tF3976EF4907F3AAAF678547D16FD1D29618A08C6;
// System.Collections.Generic.IList`1<Rewired.ActionElementMap>
struct IList_1_tAC0A6E16265D2CF73C39873BAD39894E83B5119C;
// System.Collections.Generic.IList`1<Rewired.AxisCalibration>
struct IList_1_t66EFE3B432957D9B69D07AF4C7286702603F8790;
// System.Collections.Generic.IList`1<Rewired.ControllerMap>
struct IList_1_tE896830294079702FAF3FFFDC389B8B6DCA164E8;
// System.Collections.Generic.IList`1<Rewired.CustomController>
struct IList_1_t0E8029D42F0DEC35CD39DEC3272477AC5F817EF9;
// System.Collections.Generic.IList`1<Rewired.Joystick>
struct IList_1_t384DC26B697CDDF863348AB942D99FE38CFCECDB;
// System.Collections.Generic.IList`1<System.Object>
struct IList_1_t6EE90D273EFCF5E7E4C37FAB712E70BB6F1B4BFF;
// System.Collections.Generic.IList`1<Rewired.Controller/Axis>
struct IList_1_t78665A3C2B273BACE5E7589E9146A1E821FDCB13;
// System.Collections.Generic.IList`1<Rewired.Controller/CompoundElement>
struct IList_1_t73C58F137E7DFF14E7E9D82D08D5E8B0EFC2E310;
// System.Collections.Generic.IList`1<Rewired.Controller/Element>
struct IList_1_t2A0F8CC9ADAAA52DA77A468A9445282CF4646F9B;
// System.Collections.Generic.Dictionary`2/KeyCollection<System.String,Rewired.Utils.SafeDelegate>
struct KeyCollection_t515A8D63CC0D6B3E49474556B49934FD9401A8F3;
// Rewired.Utils.Classes.Data.ADictionary`2/KeyCollection<System.Type,System.Collections.Generic.List`1<System.Object>>
struct KeyCollection_t7D4171FCA647FC97B8FD8CB9CB6ADC57A5E43926;
// System.Collections.Generic.Dictionary`2/KeyCollection<Rewired.InputMapper/JdpDLqzkBAGmKbSgujDlWammLWSdA,Rewired.Utils.SafeDelegate>
struct KeyCollection_tF9F33848D92D17775FB3C4E0F8B8B1B6448F15A7;
// Rewired.Utils.Classes.Data.KeyedGetSetValueStore`1<System.String>
struct KeyedGetSetValueStore_1_t42FBB8435F6E1317064A12E5096EAC021DF80045;
// Rewired.Player/ControllerHelper/ConflictCheckingHelper/LaNNrUufXUaCsHwYSVeeItSJzfQrA`1<System.Object>
struct LaNNrUufXUaCsHwYSVeeItSJzfQrA_1_t90BE74457214F7F3801FB0D2DD805D4EAF4457DA;
// System.Collections.Generic.List`1<Rewired.Player/ControllerHelper/bvHtPvdVkbINqyMOEkvOVjYbgQSB`2/omlOoYqlQcXnMjOFbISaKckKLkeYA<System.Object,System.Object>>
struct List_1_tF5F4B8686D6D48B7DFE14C6BD921BC86DFACE7A9;
// System.Collections.Generic.List`1<Rewired.Utils.SafeDelegate`1/vipcXwCBbnoOEzCTVzWmvEUaMZdT<System.Action`1<System.Object>>>
struct List_1_t1EF3D12D770B73CCE7B65120BB0552C82B21D3DF;
// System.Collections.Generic.List`1<Rewired.ActionElementMap>
struct List_1_t61A2C1C85DEC6157A1333F351530E22E04BDF9A6;
// System.Collections.Generic.List`1<Rewired.Controller>
struct List_1_t31024461DB8266F9EFEB0E1FB30FD6EACAAA348E;
// System.Collections.Generic.List`1<Rewired.ControllerMap>
struct List_1_t2F083EFD818F84CF4216467CD6432E17EA0EAFB4;
// System.Collections.Generic.List`1<Rewired.ControllerPollingInfo>
struct List_1_tDF36E6B2DDE1A6EC1A847DAC438160065068F946;
// System.Collections.Generic.List`1<Rewired.ControllerTemplateElementTarget>
struct List_1_tB9A85F131783B7EEF32BCC88394DEF28B255F56A;
// System.Collections.Generic.List`1<Rewired.CustomController>
struct List_1_tB8E529F7236AFA0FD8A80663AB3DD1A80617C2E1;
// System.Collections.Generic.List`1<Rewired.InputActionSourceData>
struct List_1_t5A6AAC55B898C13EB8E8597B8AB3D06036D5A477;
// System.Collections.Generic.List`1<System.Int32>
struct List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73;
// System.Collections.Generic.List`1<System.Int32Enum>
struct List_1_tDA4D291C60B1EFA9EA50BBA3367C657CC9410576;
// System.Collections.Generic.List`1<Rewired.Joystick>
struct List_1_t2531299A66B4BDB8CF994888D67AA13DA020D3FE;
// System.Collections.Generic.List`1<System.Object>
struct List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D;
// System.Collections.Generic.List`1<Rewired.Player>
struct List_1_t56D0988F57591B7D9C811A2BFBFF5CEBC8DEAF48;
// System.Collections.Generic.List`1<System.String>
struct List_1_tF470A3BE5C1B5B68E1325EF3F109D172E60BD7CD;
// System.Collections.Generic.List`1<Rewired.PlayerController/Element>
struct List_1_t1327B0703B35EF48626AC42F0D0C487FCBD86CF5;
// System.Collections.Generic.List`1<UnityEngine.InputSystem.Layouts.InputControlLayout/Collection/LayoutMatcher>
struct List_1_t4E502B2E42676E48E6F9A8F0251ADB1DF4BD490E;
// System.Collections.Generic.List`1<Rewired.Data.UserData/PMmfElSRTHipvrooOqnrsVzyuehD/kzedFdEdISaCJppRVzkSmhYBfiDK>
struct List_1_t2371DBA2BC5BA5E401A3796013E23F6AA5DE82E7;
// Rewired.Player/ControllerHelper/ConflictCheckingHelper/NPPlAOzpsFiqWUuYJtTMLJfMbmYu`1<System.Object>
struct NPPlAOzpsFiqWUuYJtTMLJfMbmYu_1_tDD2E3885D14A7C4488825DE3B7C56DEA023BC185;
// System.Predicate`1<System.Object>
struct Predicate_1_t8342C85FF4E41CD1F7024AC0CDC3E5312A32CB12;
// System.Predicate`1<Rewired.Data.UserData/PMmfElSRTHipvrooOqnrsVzyuehD/kzedFdEdISaCJppRVzkSmhYBfiDK>
struct Predicate_1_t0AE34D834A58115AD4CD9532C7FEAF28A2A18674;
// System.Collections.ObjectModel.ReadOnlyCollection`1<Rewired.ActionElementMap>
struct ReadOnlyCollection_1_t4422A6B0A0A793D51A319B9A8A073733A2FACF05;
// System.Collections.ObjectModel.ReadOnlyCollection`1<Rewired.Controller>
struct ReadOnlyCollection_1_t5E285B024BFC4ECA3450993DB52CC4261597335C;
// System.Collections.ObjectModel.ReadOnlyCollection`1<Rewired.IControllerTemplate>
struct ReadOnlyCollection_1_t18497760E4F1439D0468B3BAC863283807D8A1CA;
// System.Collections.ObjectModel.ReadOnlyCollection`1<Rewired.InputActionSourceData>
struct ReadOnlyCollection_1_t2D1795D097BFAA9ADC0A5B83FC4B7DAB13360D6B;
// System.Collections.ObjectModel.ReadOnlyCollection`1<System.Int32>
struct ReadOnlyCollection_1_t6E714C47AF272D9524CD752F30ED6538C5780952;
// System.Collections.ObjectModel.ReadOnlyCollection`1<Rewired.JoystickType>
struct ReadOnlyCollection_1_t684D7E9748C38CB042B553714053F690BF574087;
// System.Collections.ObjectModel.ReadOnlyCollection`1<System.Object>
struct ReadOnlyCollection_1_t5397DF0DB61D1090E7BBC89395CECB8D020CED92;
// System.Collections.ObjectModel.ReadOnlyCollection`1<Rewired.Controller/Axis>
struct ReadOnlyCollection_1_tB5EF8E1B2FF9A9E725D5336E156B0198E37F279E;
// System.Collections.ObjectModel.ReadOnlyCollection`1<Rewired.Controller/Axis2D>
struct ReadOnlyCollection_1_t4BF02BD2DB828FB8E2D86BD177AE488D4A64FBF1;
// System.Collections.ObjectModel.ReadOnlyCollection`1<Rewired.Controller/Button>
struct ReadOnlyCollection_1_t6632538F4C35EC35B77D58F6C62A8C0D52AED202;
// System.Collections.ObjectModel.ReadOnlyCollection`1<Rewired.Controller/CompoundElement>
struct ReadOnlyCollection_1_tD98C9F15A7AA1561CBE4F44983375EEF67277B2C;
// System.Collections.ObjectModel.ReadOnlyCollection`1<Rewired.Controller/Element>
struct ReadOnlyCollection_1_tCB75F8E52C91C2CE68136F2CE66A099484F8D615;
// System.Collections.ObjectModel.ReadOnlyCollection`1<Rewired.Controller/Hat>
struct ReadOnlyCollection_1_t7397792A05B6580C63C5944D32B9BC6B8A7833D9;
// Rewired.Utils.SafeAction`1<Rewired.ControllerAssignmentChangedEventArgs>
struct SafeAction_1_t187B602724412D6E71212275DB504DB2CA537DC0;
// Rewired.Utils.SafeAction`1<Rewired.ControllerStatusChangedEventArgs>
struct SafeAction_1_t6295D5E01D7944A8AEE5D1336EA31C2C3721C004;
// TBSPGJPKaXrjsOpBQZPxJnrcfSfAA`1<System.Object>
struct TBSPGJPKaXrjsOpBQZPxJnrcfSfAA_1_t92F77A2C0897D802673079FA32163CACC9FD23DE;
// Rewired.Utils.TempListPool/TList`1<Rewired.ControllerTemplateElementTarget>
struct TList_1_t08828BE7F5A36A1F8E5542F3DE822A03B4E625D7;
// Rewired.Utils.TempListPool/TList`1<System.Int32Enum>
struct TList_1_t91EC4434C71F6E97F426C89A756A7E8D0F090069;
// Rewired.Utils.TempListPool/TList`1<System.Object>
struct TList_1_t5EEB5351D4D3485884B025F946B9EB1B39C163F7;
// System.Collections.Generic.Dictionary`2/ValueCollection<System.String,Rewired.Utils.SafeDelegate>
struct ValueCollection_t0B899EC38D1F37351DE52E1F4F15571485D90E24;
// Rewired.Utils.Classes.Data.ADictionary`2/ValueCollection<System.Type,System.Collections.Generic.List`1<System.Object>>
struct ValueCollection_t001A6551D863C7528911355B2D51046F93A23122;
// System.Collections.Generic.Dictionary`2/ValueCollection<Rewired.InputMapper/JdpDLqzkBAGmKbSgujDlWammLWSdA,Rewired.Utils.SafeDelegate>
struct ValueCollection_t3F60E4ECE8676EDD56C11BED98E5EFBE8ECDB760;
// Rewired.Player/ControllerHelper/MapHelper/XcujpkEuhtkMjJAdZtQvqOzWNWoy`1<System.Object>
struct XcujpkEuhtkMjJAdZtQvqOzWNWoy_1_t8DB30E00B0855C4A917D6B66CABCB5A4E19B64A2;
// Rewired.Data.UserData/PMmfElSRTHipvrooOqnrsVzyuehD/aKSDPjRJZQzZwYkmoXKHoOMDFOWe`1<System.Object>
struct aKSDPjRJZQzZwYkmoXKHoOMDFOWe_1_tBF7584EF632A787EC6F2057BA1C49894E7E22FCA;
// Rewired.Data.UserData/PMmfElSRTHipvrooOqnrsVzyuehD/cTlcZwgBmjmwQjxeEhJdCJOLqDjC`1<System.Object>
struct cTlcZwgBmjmwQjxeEhJdCJOLqDjC_1_t00DEF10DFB18F406646ED696288655ED53671B85;
// Rewired.Player/ControllerHelper/MapHelper/ecjdcwfzgyPMBWdzOraiwfCBcrRoA`1<System.Object>
struct ecjdcwfzgyPMBWdzOraiwfCBcrRoA_1_tCC80E04812F8A48B4DDE3B494ED31F6CC82A6A73;
// Rewired.Player/ControllerHelper/ConflictCheckingHelper/gPTTtyzOAxLCvPhgMtIrgUsCIpeH`1<System.Object>
struct gPTTtyzOAxLCvPhgMtIrgUsCIpeH_1_tA05B48EAD2AA2E510F8D380D32FC8F6D8331D7E3;
// inUVqCQsuvBJxHwomlAniLxWfZitA`1<Rewired.ActiveControllerChangedDelegate>
struct inUVqCQsuvBJxHwomlAniLxWfZitA_1_t67BD3968E2211A2E09B85A6376936EA713E90E04;
// inUVqCQsuvBJxHwomlAniLxWfZitA`1<Rewired.PlayerActiveControllerChangedDelegate>
struct inUVqCQsuvBJxHwomlAniLxWfZitA_1_tD7B16D6D1359CB7B06E2A472A7687A5F7B51DE44;
// Rewired.Player/ControllerHelper/MapHelper/ojuhOybXRUNKAWBYROlwkJhBlkPc`1<System.Object>
struct ojuhOybXRUNKAWBYROlwkJhBlkPc_1_t7B54C1CB431E7958F15D7F71C96CAF6E68E76D60;
// Rewired.Data.UserData/PMmfElSRTHipvrooOqnrsVzyuehD/sQEkcZUofLSdEALOSOuyKPdNiQEDA`1<System.Object>
struct sQEkcZUofLSdEALOSOuyKPdNiQEDA_1_t1B5CB90AB9525321551E427D7C2054C85C37AAC1;
// System.Action`1<System.Object>[]
struct Action_1U5BU5D_t9AF7A60AA589F7071315F3DA2F77CD32CB43FB5D;
// System.Action`2<System.Object,UnityEngine.InputSystem.InputActionChange>[]
struct Action_2U5BU5D_tE313524623BEAF7FD2ABCEDAD1C5A2C556630373;
// System.Collections.Generic.Dictionary`2/Entry<System.String,Rewired.Utils.SafeDelegate>[]
struct EntryU5BU5D_tBB20375F0C4F0B8E07B304ECB985A08BE1D17BA6;
// Rewired.Utils.Classes.Data.ADictionary`2/Entry<System.Type,System.Collections.Generic.List`1<System.Object>>[]
struct EntryU5BU5D_tBEF1CF86AE6644142868E42CBD5F40FAE6CC8502;
// System.Collections.Generic.Dictionary`2/Entry<Rewired.InputMapper/JdpDLqzkBAGmKbSgujDlWammLWSdA,Rewired.Utils.SafeDelegate>[]
struct EntryU5BU5D_tF33C6D41F20C2086FAB77C6BCE1A6845588AFF76;
// inUVqCQsuvBJxHwomlAniLxWfZitA`1<Rewired.PlayerActiveControllerChangedDelegate>[]
struct inUVqCQsuvBJxHwomlAniLxWfZitA_1U5BU5D_tA661DCC17BBBCCABDACE0F73A4D969A777E291EB;
// Rewired.ActionElementMap[]
struct ActionElementMapU5BU5D_t695D4AC334ED6665D93DB89FAFA472C4F2CAADAE;
// Rewired.AxisCalibration[]
struct AxisCalibrationU5BU5D_t5CE6CA59BC03BC961C6423B52B69520CDEF41078;
// System.Boolean[]
struct BooleanU5BU5D_tD317D27C31DB892BE79FAE3AEBC0B3FFB73DE9B4;
// System.Byte[]
struct ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031;
// System.Char[]
struct CharU5BU5D_t799905CF001DD5F13F7DBB310181FC4D8B7D0AAB;
// Rewired.ControllerTemplateElementTarget[]
struct ControllerTemplateElementTargetU5BU5D_t40239EE457C54F98C6E975C8E924AE4D95CFD2B9;
// Rewired.ControllerType[]
struct ControllerTypeU5BU5D_t24957BC60A9ED2806B85EDE1E8A60341D1871FD2;
// System.Delegate[]
struct DelegateU5BU5D_tC5AB7E8F745616680F337909D3A8E6C722CDF771;
// System.Double[]
struct DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE;
// System.Runtime.InteropServices.GCHandle[]
struct GCHandleU5BU5D_t7EA6F2FA83CDF86871001174CF7D30033AC4A785;
// Rewired.IControllerTemplate[]
struct IControllerTemplateU5BU5D_tAD319B5FD030C9F0A993A85F2EB5B7A47390C3DB;
// UnityEngine.InputSystem.IInputInteraction[]
struct IInputInteractionU5BU5D_t175AB10EB3221C36393F258F530F94D8DD01CB93;
// UnityEngine.Experimental.Rendering.RenderGraphModule.IRenderGraphResource[]
struct IRenderGraphResourceU5BU5D_tC72A5980774D8ACE9E681BE8A3FAB493A70BC2F3;
// UnityEngine.InputSystem.InputActionMap[]
struct InputActionMapU5BU5D_t4B352E8DA73976FEDA107E35E81FB5BE6838C045;
// UnityEngine.InputSystem.InputBindingComposite[]
struct InputBindingCompositeU5BU5D_tB9A645573A56F8DC9EC7AD84F1BE24C2B0F4319E;
// UnityEngine.InputSystem.InputControl[]
struct InputControlU5BU5D_t0B951FEF1504D6340387C4735F5D6F426F40FE17;
// UnityEngine.InputSystem.InputProcessor[]
struct InputProcessorU5BU5D_t79582BEBC3FAF824D9762566AA6E979F95E6EB64;
// System.Int16[]
struct Int16U5BU5D_t8175CE8DD9C9F9FB0CF4F58E45BC570575B43CFB;
// System.Int32[]
struct Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C;
// System.Int32Enum[]
struct Int32EnumU5BU5D_t87B7DB802810C38016332669039EF42C487A081F;
// System.Int64[]
struct Int64U5BU5D_tAEDFCBDB5414E2A140A6F34C0538BF97FCF67A1D;
// System.IntPtr[]
struct IntPtrU5BU5D_tFD177F8C806A6921AD7150264CCC62FA00CAD832;
// UnityEngine.InputSystem.Utilities.InternedString[]
struct InternedStringU5BU5D_t0B851758733FC0B118D84BE83AED10A0404C18D5;
// Rewired.JoystickType[]
struct JoystickTypeU5BU5D_t5D2FA180BDE2C05F0EAEF261D865F849DDE618F3;
// Rewired.KeyboardKeyCode[]
struct KeyboardKeyCodeU5BU5D_tD02BBA7D7118E8F929F05A8F12F5CFD6E4E2BD94;
// System.Object[]
struct ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918;
// System.SByte[]
struct SByteU5BU5D_t88116DA68378C3333DB73E7D36C1A06AFAA91913;
// System.Single[]
struct SingleU5BU5D_t89DEFE97BCEDB5857010E79ECE0F52CF6E93B87C;
// System.Diagnostics.StackTrace[]
struct StackTraceU5BU5D_t32FBCB20930EAF5BAE3F450FF75228E5450DA0DF;
// System.String[]
struct StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248;
// Rewired.Utils.Classes.Utility.TimerAbs[]
struct TimerAbsU5BU5D_t7B70F57AD43475723B6291E67F95C40BC81A05A7;
// System.Type[]
struct TypeU5BU5D_t97234E1129B564EB38B8D85CAC2AD8B5B9522FFB;
// Rewired.UnknownControllerHat[]
struct UnknownControllerHatU5BU5D_t28A26A414F3FB6A480708BC52C5DA8C9B0C72013;
// YBzrFNvcnwYplEAweaZfKoEYnJzM[]
struct YBzrFNvcnwYplEAweaZfKoEYnJzMU5BU5D_tFB4689A16323F9FDCBE75ACBD8F2CADD680D9256;
// aDAAzNrnaVtINRtzmmcxtyAYKWAn[]
struct aDAAzNrnaVtINRtzmmcxtyAYKWAnU5BU5D_tE28E46B8CE90563FB9114CF4CC5E249E1CE0860F;
// slnZXWsjHVMgmJPfXBYLuaghszns[]
struct slnZXWsjHVMgmJPfXBYLuaghsznsU5BU5D_tE4357525683913188793B16409204CE1841C9509;
// Rewired.Controller/Axis[]
struct AxisU5BU5D_t916A735FDE7F513AC969A292CC357867FF480130;
// Rewired.Controller/Axis2D[]
struct Axis2DU5BU5D_t9C78A228E204FB5FD3784D0A07C4A949D7D20275;
// Rewired.Controller/Button[]
struct ButtonU5BU5D_t72C5601523D894D77B2BDF77A056019A61C0AF62;
// Rewired.Controller/Hat[]
struct HatU5BU5D_t6CBFAC9CEFA700897CA5E4A7A11546019B04731A;
// UnityEngine.InputSystem.Layouts.InputControlLayout/ControlItem[]
struct ControlItemU5BU5D_t7798E8B7C7F58B8F6D13B567539CD82E962C7104;
// UnityEngine.InputSystem.InputControlScheme/DeviceRequirement[]
struct DeviceRequirementU5BU5D_t0496FAAB7554B7BFC270BA53BA6A5EFD5DE061CE;
// Rewired.PlayerController/Element[]
struct ElementU5BU5D_tC73650C0F545F4B732A2FB4ACA8D0BF30F9C1C4D;
// Rewired.Controller/CompoundElement/kfzfjnagLVVtsyAzdAlUhZdNuSIQA[]
struct kfzfjnagLVVtsyAzdAlUhZdNuSIQAU5BU5D_tEEB780C862E2161EBC7C54D3F94963F74723F9AB;
// Rewired.Player/ControllerHelper/ftuHLSCvHbrPYKqmDICMGujVuqLSA[]
struct ftuHLSCvHbrPYKqmDICMGujVuqLSAU5BU5D_t1A5828768AE703001918C5473AA9B00044C7C36E;
// Rewired.Data.UserData/PMmfElSRTHipvrooOqnrsVzyuehD/kzedFdEdISaCJppRVzkSmhYBfiDK[]
struct kzedFdEdISaCJppRVzkSmhYBfiDKU5BU5D_t33F6EB465ABC6573F2555141720A5BCD57EBC4C6;
// slnZXWsjHVMgmJPfXBYLuaghszns[,]
struct slnZXWsjHVMgmJPfXBYLuaghsznsU5BU2CU5D_t0E2C0BE01220BC53ADE9E80AF7EC0BE6D677C75F;
// System.Action
struct Action_tD00B0A84D7945E50C2DFFC28EFEE6ED44ED2AD07;
// Rewired.ActionElementMap
struct ActionElementMap_t0EBE3E5D3A5DF3BA6D35F8082ED2232404EFF8CF;
// UnityEngine.AndroidJavaObject
struct AndroidJavaObject_t8FFB930F335C1178405B82AC2BF512BB1EEF9EB0;
// UnityEngine.AnimationCurve
struct AnimationCurve_tCBFFAAD05CEBB35EF8D8631BD99914BE1A6BB354;
// System.ArgumentNullException
struct ArgumentNullException_t327031E412FAB2351B0022DD5DAD47E67E597129;
// Rewired.AxisCalibration
struct AxisCalibration_t8B238ADDBAA0316E9708699644DA1CFF6EDBE66C;
// System.Reflection.Binder
struct Binder_t91BFCE95A7057FADF4D8A1A342AFE52872246235;
// Rewired.CalibrationMap
struct CalibrationMap_tB57C4727A9D4F4ED745A6E5D7E4398452D7A499B;
// Rewired.Data.ConfigVars
struct ConfigVars_t4EC82ACF63376F1869FDC3D0E223EDCE149CF4A3;
// Rewired.Controller
struct Controller_t919A4A50FC7A0F25D7B31615C0F4E4D4A4D17911;
// Rewired.Data.ControllerDataFiles
struct ControllerDataFiles_t599A8EBC3214904D6DEEFD99921E121F8CA6C2A7;
// Rewired.ControllerDataUpdater
struct ControllerDataUpdater_tEA424134962ED8FCA977957E8CAE6B6521D67788;
// Rewired.ControllerMap
struct ControllerMap_tC01A582E577E38D21EB7D87A8C040AF5DA285FB3;
// Rewired.ControllerMapEnabler
struct ControllerMapEnabler_tA0F9E3CA8F655F79B94FE9343DC7D543CCC0DE9B;
// Rewired.ControllerMapLayoutManager
struct ControllerMapLayoutManager_t630460EA47983879378D747091ED5C63493C23B3;
// Rewired.ControllerMapWithAxes
struct ControllerMapWithAxes_tCC6B6F4AA454F60DB2D7F6660FDE33B9F683A036;
// Rewired.ControllerWithAxes
struct ControllerWithAxes_tF5DF4B1A98C0326D31E6AC481DEBC2D90E44BBF2;
// Rewired.CustomController
struct CustomController_t749B7DF2AA8AD20FEC4C2003C4FF5000FE9C6065;
// System.DelegateData
struct DelegateData_t9B286B493293CD2D23A5B2B5EF0E5B1324C2B77E;
// EYzeMRMINmbDPjgLMbiDXTDcHYNs
struct EYzeMRMINmbDPjgLMbiDXTDcHYNs_tCDC7C8E6E50F029693E0ACB75DA0000C6F87E379;
// System.Exception
struct Exception_t;
// FeaiSQbvxYDTMImoDmlvhGnyLumi
struct FeaiSQbvxYDTMImoDmlvhGnyLumi_tB82E59EB263DBCCD7452BF39256B26197DD5299C;
// UnityEngine.GlobalJavaObjectRef
struct GlobalJavaObjectRef_t20D8E5AAFC2EB2518FCABBF40465855E797FF0D8;
// Rewired.Data.Mapping.HardwareAxisInfo
struct HardwareAxisInfo_t263803B756A1948668029834C5B184A5590B0654;
// Rewired.HardwareControllerMap_Game
struct HardwareControllerMap_Game_t3C259C0FEB7E4318075A0A7CAECB7DF1D7AA950A;
// Rewired.Interfaces.IControllerAssigner
struct IControllerAssigner_tF97525A09D83868487800AB365691D873BACD69B;
// Rewired.Interfaces.IControllerExtensionSource
struct IControllerExtensionSource_tE2E4232EE8744F82AD322D907B3F947F50B86E38;
// Rewired.IControllerTemplate
struct IControllerTemplate_t6D8D8525A76D3394EB137B938A7A40D23888B273;
// System.Collections.IDictionary
struct IDictionary_t6D03155AF1FA9083817AA5B6AD7DEEACC26AB220;
// Rewired.Interfaces.IInputManagerJoystickPublic
struct IInputManagerJoystickPublic_tD28C6820CAC55E3757CDE2CD2AE6ABD9AB2D43D0;
// System.Collections.IList
struct IList_t1C522956D79B7DC92B5B01053DF1AC058C8B598D;
// UnityEngine.Experimental.Rendering.RenderGraphModule.IRenderGraphResource
struct IRenderGraphResource_tF24653A388C17849844C128C19C7A6599C7ADB7D;
// UnityEngine.Experimental.Rendering.RenderGraphModule.IRenderGraphResourcePool
struct IRenderGraphResourcePool_t8BF833F3C5D0BD8E45632CF923363EC782F4DDA8;
// Rewired.Interfaces.IUnifiedKeyboardSource
struct IUnifiedKeyboardSource_tB4B79B93FBB7041B4F6F0E7F61D691B45FD63A2D;
// Rewired.Interfaces.IUnifiedMouseSource
struct IUnifiedMouseSource_t9C0CC69D66CD23154666A536623BC4E1943A02BC;
// UnityEngine.InputSystem.InputAction
struct InputAction_t1B550AD2B55AF322AFB53CD28DA64081220D01CD;
// UnityEngine.InputSystem.InputActionAsset
struct InputActionAsset_tF217AC5223B4AAA46EBCB44B33E9259FB117417D;
// UnityEngine.InputSystem.InputActionMap
struct InputActionMap_tFCE82E0E014319D4DED9F8962B06655DD0420A09;
// UnityEngine.InputSystem.InputActionState
struct InputActionState_t780948EA293BAA800AD8699518B58B59FFB8A700;
// Rewired.InputBehavior
struct InputBehavior_tF024DE8CDBF799CDC3B9CE43E5E4667C1D054FD9;
// Rewired.InputCategory
struct InputCategory_t9C22614C15FBDA3F98B6F03EA3CEB547BF5F373C;
// Rewired.InputManager_Base
struct InputManager_Base_t1C60AC2E6C7F7EE7CC5B91EE4149AD5BE14058D0;
// Rewired.InputMapCategory
struct InputMapCategory_t309A7C800100DDCC67C5C6A69F960A1D71768111;
// Rewired.InputMapper
struct InputMapper_tAA873DF879B44D24979B822D811C13484C560F2D;
// System.Int32
struct Int32_t680FF22E76F6EFAD4375103CBBFFA0421349384C;
// System.InvalidOperationException
struct InvalidOperationException_t5DDE4D49B7405FAAB1E4576F4715A42A3FAD4BAB;
// JfVkiPqxuvjpxOenWaPbtdnpqNrC
struct JfVkiPqxuvjpxOenWaPbtdnpqNrC_tAD3EC599BD987C8364327BCCAE0346D20C00C8F9;
// Rewired.Joystick
struct Joystick_tEC65D4846A553E83F365E7D8D263DC644C75FC11;
// Rewired.Keyboard
struct Keyboard_t3FD52938480ACCD23FDB0DAEC857F9A9D29CC6C3;
// LooruOaGNVHUKdanwexEFBSWHmmS
struct LooruOaGNVHUKdanwexEFBSWHmmS_t150CC9A4459E2B4863607C6B1E001DD89FB64CAC;
// System.Reflection.MemberFilter
struct MemberFilter_tF644F1AE82F611B677CE1964D5A3277DDA21D553;
// System.Reflection.MethodInfo
struct MethodInfo_t;
// Rewired.Mouse
struct Mouse_t5C8D9CB89A5C0F4EE87A70501CAF2A68E36DC019;
// System.NotImplementedException
struct NotImplementedException_t6366FE4DCF15094C51F4833B91A2AE68D4DA90E8;
// System.NotSupportedException
struct NotSupportedException_t1429765983D409BD2986508963C98D214E4EBF4A;
// PjzdStrqNkNQSljwEZWJWYcQhjVQ
struct PjzdStrqNkNQSljwEZWJWYcQhjVQ_tA22AE52C8C2CD0639BCE85B3BE860B096AFBC1EA;
// Rewired.PlatformInputManager
struct PlatformInputManager_t0589A7C9789B19DE7D2560BDE9C72EA3214B3786;
// Rewired.Player
struct Player_t71A64CE695A2F96B144F3050755AB2799DA7C01B;
// Rewired.PlayerController
struct PlayerController_t5C57BA5C122B079D29B773FDCB7DE6C13E7B8ED2;
// Rewired.Utils.SafeAction
struct SafeAction_t32EA46BB214634A37414BF52941F55B8ABC9BD31;
// Rewired.Utils.SafeDelegate
struct SafeDelegate_t3A5CBC88139112F30FC47A9C9FEE81140913D328;
// System.Runtime.Serialization.SafeSerializationManager
struct SafeSerializationManager_tCBB85B95DFD1634237140CD892E82D06ECB3F5E6;
// System.Single
struct Single_t4530F2FF86FCB0DC29F35385CA1BD21BE294761C;
// SreStMNJSUKnhiFeYdCnZvaTqzgO
struct SreStMNJSUKnhiFeYdCnZvaTqzgO_tCAADFAF41D7399BA1A417D5051C817A325FB955C;
// System.String
struct String_t;
// System.Text.StringBuilder
struct StringBuilder_t;
// TAqjagBhKGcWECRbpfkHPNKbpxLsA
struct TAqjagBhKGcWECRbpfkHPNKbpxLsA_t5B25C84F87417D98CA0E8452EAD0DB3A23D7833A;
// Rewired.Utils.Classes.Utility.TimerAbs
struct TimerAbs_t49C1588F0A9377F7A54285F7C44A6591FBA42E36;
// System.Type
struct Type_t;
// System.UInt16
struct UInt16_tF4C148C876015C212FD72652D0B6ED8CC247A455;
// Rewired.Data.UserData
struct UserData_tA3822AFC104037490B294D0A972ABFAF6DF9C154;
// Rewired.Data.UserDataStore
struct UserDataStore_t7FFC8F030F5FF0B24856473F6CDBD9CC62CBBEF2;
// System.Void
struct Void_t4861ACF8F4594C3437BB48B6E56783494B843915;
// YBzrFNvcnwYplEAweaZfKoEYnJzM
struct YBzrFNvcnwYplEAweaZfKoEYnJzM_t30C83160D593E4B3D56437AB7AE3D2507C9AC52E;
// aDAAzNrnaVtINRtzmmcxtyAYKWAn
struct aDAAzNrnaVtINRtzmmcxtyAYKWAn_tC58E06992354490D8D1C79A66F44308E6C271B26;
// gPqZAArEBWUnolRtZlCKNFZvRLqr
struct gPqZAArEBWUnolRtZlCKNFZvRLqr_tF91080EAD5330A023C3CBFFB01A8F1A45A0BDC0A;
// gRfTGJhxieuOzGUxjqzzxNNmLUuF
struct gRfTGJhxieuOzGUxjqzzxNNmLUuF_t7BBB41BAB66EDE0363D72C224F9B9ABD3F60154A;
// hDTwQOONkmiSaaPHwqpfFkmXMCAbb
struct hDTwQOONkmiSaaPHwqpfFkmXMCAbb_tE1CD926FAF554AEBC6AFFC839A4294D64BE76AC3;
// mFLEqKpnGpgOhoDYUApNBKpxUruFA
struct mFLEqKpnGpgOhoDYUApNBKpxUruFA_t3D2572948CEB7B57C2F37B59039EC83B1CB32408;
// oRzHnFZUZWhymZfQjayJtJujzGt
struct oRzHnFZUZWhymZfQjayJtJujzGt_t387519A4B76739FFC49C8E3D119FA67A0FA7CBC0;
// rlfXkJTrHZdpPrmFzvJfeOpwdxFF
struct rlfXkJTrHZdpPrmFzvJfeOpwdxFF_t92D577FF2385AF1C7F87003759294BE9754F3ABD;
// uIgcjVTcicmixvMVQWmSpAQpgkZA
struct uIgcjVTcicmixvMVQWmSpAQpgkZA_t2A5D5D5A468C3C56CF5EC9F05C0C0218FC002CE6;
// Rewired.Data.ConfigVars/EditorVars
struct EditorVars_t5AE2ADF7F0F42E42D3D477925DB1FE133ADAD682;
// Rewired.Data.ConfigVars/PlatformVars
struct PlatformVars_tF737B3A64AA3FC58BCFC8EE59301811595B60D87;
// Rewired.Data.ConfigVars/PlatformVars_GameCoreScarlett
struct PlatformVars_GameCoreScarlett_tAB9E09C9718FF0AA9DEA705CEDD000FE72593B7F;
// Rewired.Data.ConfigVars/PlatformVars_GameCoreXboxOne
struct PlatformVars_GameCoreXboxOne_tCF651D8D1CCC76DFF542B0B5104C52697A459640;
// Rewired.Data.ConfigVars/PlatformVars_OSXStandalone
struct PlatformVars_OSXStandalone_t4A4F8397B2B479DA2FF2C79CF7971FD29FC61B04;
// Rewired.Data.ConfigVars/PlatformVars_PS5
struct PlatformVars_PS5_t610DDC3CB70D06A2423ADB4F9E5D2664E0D7AADF;
// Rewired.Data.ConfigVars/PlatformVars_Stadia
struct PlatformVars_Stadia_t266E646AE50B1DB8A9B9208BDA8CFFE68E7D2ED2;
// Rewired.Data.ConfigVars/PlatformVars_WindowsStandalone
struct PlatformVars_WindowsStandalone_t8800F0E9900A23B8CDDD65BC291F3A7955FFEA3A;
// Rewired.Data.ConfigVars/PlatformVars_WindowsUWP
struct PlatformVars_WindowsUWP_tCB23AF028BD504F84F9FBDDD4E6EDF89C942BD34;
// Rewired.Controller/CompoundElement
struct CompoundElement_t13DDF83F927A6EF07A34A4A70E3C7DF93F726576;
// Rewired.Controller/Element
struct Element_t58CB6D4FDC2FDD69AC192D19F0F9531FE3F01F76;
// Rewired.Controller/Extension
struct Extension_t65CC6FDD7104DC3F9E55C8238302E9F8870162F9;
// Rewired.Data.Mapping.HardwareJoystickTemplateMap/SpecialElementEntry
struct SpecialElementEntry_tC2A8F6C0EE9400318EA49260467DD0826D93AE8A;
// UnityEngine.InputSystem.InputActionRebindingExtensions/RebindingOperation
struct RebindingOperation_tF7D9BCBB6E69668FA3A5C211104FF8637F9F3470;
// UnityEngine.InputSystem.InputActionState/ActionMapIndices
struct ActionMapIndices_t013BEFD76B7FE52E413C5DBF5C7CDA4194800CBD;
// UnityEngine.InputSystem.InputActionState/BindingState
struct BindingState_t69D9579E13933436EAF3A3886EAED220DFD696EA;
// UnityEngine.InputSystem.InputActionState/InteractionState
struct InteractionState_t057CEDBCC55120B30A48DAD0A4111EF8FF62D3AE;
// UnityEngine.InputSystem.InputActionState/TriggerState
struct TriggerState_t99B6AEA05EECEE1FEE7B60C2ABA73FA03685F38D;
// UnityEngine.InputSystem.Layouts.InputControlLayout/Builder
struct Builder_t83F17A26F53DA7EA6D8C35E5C65C5DF0147E7821;
// Rewired.InputMapper/Options
struct Options_t2CAC7BDE548C606E2D6149513164D5EF301AEF7A;
// Rewired.InputMapper/ukhpurvRuIKYVFmbrHGZXcVzGwlw
struct ukhpurvRuIKYVFmbrHGZXcVzGwlw_tCB0702700C158E9D3CD5837A11109AFF50466BDE;
// PjzdStrqNkNQSljwEZWJWYcQhjVQ/xcjUJvCGhYqGWwkvUdNHjHWxoqqC
struct xcjUJvCGhYqGWwkvUdNHjHWxoqqC_t543EB71E658F90965142EBA611491F052277C6B0;
// Rewired.Player/ControllerHelper
struct ControllerHelper_tCE72EA23053BD0C6ECB4D75A69F8CD1B3AC28FF6;
// Rewired.PlayerController/CompoundElement
struct CompoundElement_t89F22D17450D47C1307CC80AFA332B78C00CEB87;
// Rewired.PlayerController/Element
struct Element_t26F7003E01AAF28091E75E0A3552C2C3EEA38F06;
// Rewired.ReInput/ConfigHelper
struct ConfigHelper_t04A7167E7755E054F63F8B27CB10FE618D85F8BD;
// Rewired.ReInput/ControllerHelper
struct ControllerHelper_t470828F1E9094A484F8FE12DB16199890DF23F5E;
// Rewired.ReInput/MappingHelper
struct MappingHelper_t18AE344473D49AF2E7133108678DD4D963699662;
// Rewired.ReInput/PlayerHelper
struct PlayerHelper_t96BC8DE1C94717C98B253F25C7B9C82639E4BF5C;
// Rewired.ReInput/TimeHelper
struct TimeHelper_t69098AFC84A038B0FE6C972CB520EA302C841355;
// Rewired.ReInput/UnityTouch
struct UnityTouch_t2075B37418F4CC7F686589B5EA9722FE1E0606FF;
// Rewired.ReInput/VGGFRlKCiDzJEBFzELCBbDLbrdNsb
struct VGGFRlKCiDzJEBFzELCBbDLbrdNsb_t5447C7DA708D817444C5DB41FA444E0A819CEB0F;
// Rewired.ReInput/yRMIEBZWdRbQqWIebbpueNjshnqb
struct yRMIEBZWdRbQqWIebbpueNjshnqb_tA22AE88E0F0DE7D24F950F81D54AA2EEA22B039B;
// UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphResourceRegistry/RenderGraphResourcesData
struct RenderGraphResourcesData_tB2FF97B16A3E1DE700283778679C5CC0C39F4CFE;
// UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphResourceRegistry/ResourceCallback
struct ResourceCallback_t45358BA8AC82EF742271B868C50331854DD58EEC;
// Rewired.UnknownControllerHat/HatButtons
struct HatButtons_tCE5F7476A54D0F5DF7FA0EB11FF2C753B51DDE03;
// slnZXWsjHVMgmJPfXBYLuaghszns/QGeOicrujSfMZepRhdYgYLzOkaHe
struct QGeOicrujSfMZepRhdYgYLzOkaHe_t1DB6528F1807C441E39C5EF370EF29E2B2A4E679;
// slnZXWsjHVMgmJPfXBYLuaghszns/sSljjuRryjcEuBqQKnCeXUUffipq
struct sSljjuRryjcEuBqQKnCeXUUffipq_t20FE2A6122AD378214EFA255ED30B8368CD2E511;
// Rewired.Controller/CompoundElement/kfzfjnagLVVtsyAzdAlUhZdNuSIQA
struct kfzfjnagLVVtsyAzdAlUhZdNuSIQA_tCE87DA4E243A151D523511BE81757930A8E88FBE;
// Rewired.Controller/Element/bjRAYyJTFiksIdlhLZuKXBUXHTrC
struct bjRAYyJTFiksIdlhLZuKXBUXHTrC_t49F8AEB871E69D140E18244C3C88BDD4D47609EB;
// Rewired.InputMapper/ukhpurvRuIKYVFmbrHGZXcVzGwlw/OsEuVNimtVPEekMdxjomYkWOLMog
struct OsEuVNimtVPEekMdxjomYkWOLMog_t2C3FF65EA8C3DB3B107A940C4B805F155D3279D5;
// Rewired.Player/ControllerHelper/ConflictCheckingHelper
struct ConflictCheckingHelper_t8D707CEC57F056B87A4C68F98F780D34E893A8DB;
// Rewired.Player/ControllerHelper/MapHelper
struct MapHelper_t214BA4F045E5EB4B312E4E6AEB6697813117A7C2;
// Rewired.Player/ControllerHelper/PollingHelper
struct PollingHelper_tB0445EF1EE1230F3EE703F3A0F09DEE0A64D8B97;
// Rewired.Player/ControllerHelper/eSDNQUnYcyDvQHrqJricxoWzTLr
struct eSDNQUnYcyDvQHrqJricxoWzTLr_t52BD0C4EC6573AD81BF763D7FADDE36ECEB3DA34;
// Rewired.Player/ControllerHelper/ftuHLSCvHbrPYKqmDICMGujVuqLSA
struct ftuHLSCvHbrPYKqmDICMGujVuqLSA_tD67CC6A3A416E57262B63617FA5896CF7BF4F187;
// Rewired.Player/ControllerHelper/vpfVMfLDNQCKabtrXuyMMndafvvoA
struct vpfVMfLDNQCKabtrXuyMMndafvvoA_t24DAE63535EED93A1490AC97901F2551704D116D;
// Rewired.ReInput/ControllerHelper/ConflictCheckingHelper
struct ConflictCheckingHelper_tD50E0E01A2183F0F5290D4704CB790D45A7626C4;
// Rewired.ReInput/ControllerHelper/PollingHelper
struct PollingHelper_tDC5975DF531D46693230837C215974F5B59AECAB;
// Rewired.Data.UserData/PMmfElSRTHipvrooOqnrsVzyuehD/kzedFdEdISaCJppRVzkSmhYBfiDK
struct kzedFdEdISaCJppRVzkSmhYBfiDK_t96C908773E13D2FD31BFC3C0BC59CD2D7B31233D;

IL2CPP_EXTERN_C RuntimeClass* AndroidJavaObjectU5BU5D_tBCEB142050F282B940177011644246618E002001_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* AndroidJavaObject_t8FFB930F335C1178405B82AC2BF512BB1EEF9EB0_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* AndroidReflection_tD59014B286F902906DBB75DA3473897D35684908_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* ArgumentNullException_t327031E412FAB2351B0022DD5DAD47E67E597129_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Debug_t8394C7EEAECA3689C2C9B9DE9C7166D73596276F_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Exception_t_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* ICollection_1_t1F9263A55160633882F2ABCE6527778C728159D5_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* IDisposable_t030E0496B4E0E4E4F086825007979AF51F7248C5_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* IList_1_t0E8029D42F0DEC35CD39DEC3272477AC5F817EF9_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* IList_1_t384DC26B697CDDF863348AB942D99FE38CFCECDB_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* IList_1_t66EFE3B432957D9B69D07AF4C7286702603F8790_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* IList_1_t78665A3C2B273BACE5E7589E9146A1E821FDCB13_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* IList_1_tAC0A6E16265D2CF73C39873BAD39894E83B5119C_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* IList_t1C522956D79B7DC92B5B01053DF1AC058C8B598D_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* InputControlLayout_t46A40BE4C976BE33E85F61E63EB34323FED9831D_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* InputProcessor_t71DA6677A0295DC87736E1D8D208FEA75D860457_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* IntPtr_t_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* InvalidOperationException_t5DDE4D49B7405FAAB1E4576F4715A42A3FAD4BAB_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* JsonParser_t018B55D46F9F32673FE60644DC3AF9562EB538D8_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Marshal_tD976A56A90263C3CE2B780D4B1CADADE2E70B4A7_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* NotImplementedException_t6366FE4DCF15094C51F4833B91A2AE68D4DA90E8_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* NotSupportedException_t1429765983D409BD2986508963C98D214E4EBF4A_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Predicate_1_t0AE34D834A58115AD4CD9532C7FEAF28A2A18674_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* StringBuilder_t_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Type_t_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* ccKIYWnZwPjlGgvjpHVACPHqZTWG_t7AB72F4748B9EC6B1975F90F35E5838740AD2011_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* ftuHLSCvHbrPYKqmDICMGujVuqLSA_tD67CC6A3A416E57262B63617FA5896CF7BF4F187_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* gPqZAArEBWUnolRtZlCKNFZvRLqr_tF91080EAD5330A023C3CBFFB01A8F1A45A0BDC0A_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* hDTwQOONkmiSaaPHwqpfFkmXMCAbb_tE1CD926FAF554AEBC6AFFC839A4294D64BE76AC3_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* jQwkwLndXmHLkjaQEggMxbWuzWBN_t16BA183769603E5AC3E1A5CD0B747D26A4A7934F_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* kzedFdEdISaCJppRVzkSmhYBfiDK_t96C908773E13D2FD31BFC3C0BC59CD2D7B31233D_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* slnZXWsjHVMgmJPfXBYLuaghszns_t24FEA9E317E149AF896730414F2B3089559DCEC1_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C String_t* _stringLiteral18671CD5DECD4AF4B7DF2AA0F1A0C1E4DE25F8AB;
IL2CPP_EXTERN_C String_t* _stringLiteral22B1478CDF9C226208AE289896781AF22519D6CB;
IL2CPP_EXTERN_C String_t* _stringLiteral2386E77CF610F786B06A91AF2C1B3FD2282D2745;
IL2CPP_EXTERN_C String_t* _stringLiteral24CC8D396132365E532646F936DFC8579E2299B2;
IL2CPP_EXTERN_C String_t* _stringLiteral3A38F099E8455AB689BE3047D74FAFF31510DF90;
IL2CPP_EXTERN_C String_t* _stringLiteral42646B33B50B6AA15E22733C8900716F0FE19E1D;
IL2CPP_EXTERN_C String_t* _stringLiteral51253131B895C2F8066BCC47E62D44F18F43446C;
IL2CPP_EXTERN_C String_t* _stringLiteral5AC64F41AC098111BD52F434F0C2E60A4F2DE3BC;
IL2CPP_EXTERN_C String_t* _stringLiteral725B1CAFF9B49E1231FDA15B85166BBEFAA36A11;
IL2CPP_EXTERN_C String_t* _stringLiteral9AB16B3999460DDC981865934D979087351A14F2;
IL2CPP_EXTERN_C String_t* _stringLiteralAFCE96C2E9CB5FEF65576BADEA096873577F2BF6;
IL2CPP_EXTERN_C String_t* _stringLiteralC62C64F00567C5368CAE37F4E64E1E82FF785677;
IL2CPP_EXTERN_C String_t* _stringLiteralDA39A3EE5E6B4B0D3255BFEF95601890AFD80709;
IL2CPP_EXTERN_C String_t* _stringLiteralEF8AE9E6CBCFDABA932FBEB4C85964F450F724F5;
IL2CPP_EXTERN_C String_t* _stringLiteralF3E84B722399601AD7E281754E917478AA9AD48D;
IL2CPP_EXTERN_C const RuntimeMethod* ADictionary_2_Add_m0B52951B53E7F35DD40A3E9D2435F6A9921FEAD6_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* ADictionary_2_ContainsKey_mC5ADB925423D250073B9A2A62A2534AB23B21A0F_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* ADictionary_2_TryGetValue_mF116A47D7285E8974FA1C99B2650B697DFD56A55_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* ADictionary_2_get_Item_m16DA44C3730BB63327BFAF65D10C028CA7CD13E3_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Action_3_Invoke_m8897575606FCC23249B541980E86A2D83737853B_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* BindingSyntax_WithInteraction_TisRuntimeObject_mA9CD41BB913C678CE5891E3C51871CBFCFB13254_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* BindingSyntax_WithProcessor_TisRuntimeObject_m88180835A3724BF9C98DC39A8CB6146B2B3BC1DE_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* ControllerHelper_AddController_TisRuntimeObject_m127297199EA05D1E046A2CFBC919A78CE371C507_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* ControllerHelper_ClearControllersOfType_TisRuntimeObject_m3A464E94EEE7C002084282F8CB053F8871CB1015_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* ControllerHelper_ContainsController_TisRuntimeObject_m119A6EFFE075F0F6633FB32AA289DA9C7244CC8F_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* ControllerHelper_GetController_TisRuntimeObject_mB7D90A999A30B36C1F7501C7B3A296CE358A8D0C_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* ControllerHelper_RemoveController_TisRuntimeObject_m7AFE1635F269A0DC03154E31D68E2BE5777FFC52_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* ControllerHelper_uUCnSLiwzDzEwSKQHkRazBtyJViG_TisGuid_t_mE94249602C6C53F92791234E6FC7927D4A7C5BA8_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* ControllerHelper_uUCnSLiwzDzEwSKQHkRazBtyJViG_TisRuntimeObject_m21AA9E2C96964EF0D8F8CE5F967724B3300D72D7_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Dictionary_2_TryGetValue_m6EC43AE2C5DA7C0B6304C7615BB114120F4C7C1C_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Dictionary_2_get_Item_mE1AB1E72BF64ADB727FBCFC32FD083FE40112818_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* DynamicArray_1_Resize_mEEEB907EAEFD4C22DB449FF052CF6AC967A27AD1_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* DynamicArray_1_get_Item_m5FC9383C3A815B0DF7AAD4C2A5CDFB1A25586ECE_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* DynamicArray_1_get_size_m56D2768863B15299FA4F2F14E271686207A8C2E4_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* ListTools_AddIfUnique_TisRuntimeObject_m1FC233E73FB0BCD08B759B78473378745A884A81_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* List_1_Add_mEBA4A42D074F0BFA59336506E8E0639669B309DD_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* List_1_Clear_m2036CFD23AB93618EE6F473B3864A226AB3B519E_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* List_1_Find_m412DFD00E7077EF26A7689218DBB67CFEBBAA57D_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* List_1_RemoveAt_m54F62297ADEE4D4FDA697F49ED807BF901201B54_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* List_1__ctor_m76CBBC3E2F0583F5AD30CE592CEA1225C06A0428_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* List_1_get_Count_m4360FE38E465AC825248281834873BEC2CA1DE0A_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* List_1_get_Count_m4407E4C389F22B8CEC282C15D56516658746C383_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* List_1_get_Count_mB63183A9151F4345A9DD444A7CBE0D6E03F77C7C_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* List_1_get_Item_m21AEC50E791371101DC22ABCF96A2E46800811F8_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* List_1_get_Item_m33561245D64798C2AB07584C0EC4F240E4839A38_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* List_1_get_Item_mF23E84EFE39E9A88D8A6A9D2061A0B3B3A0FEAF4_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* MapHelper_GetAllMapsInCategory_TisRuntimeObject_mDDC9515B6EDC86309D3538EC6D3337E30244542F_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* MapHelper_GetAllMaps_TisRuntimeObject_m55A3C44AC237AE83A83C4653F89DA90562BB92D5_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* MapHelper_GetMapsInCategory_TisRuntimeObject_mD3FCC7B7E3E92BD67FBD312A75A0B08B972A7427_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Predicate_1__ctor_mC7ED0FD7569E0ACBA4AA0C7D8592AADCFA28A8EA_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* TpeBEFhFAWNAsvKKQTVtIrdFUsQw_OlLACmpwoMamrxMTFzLaRnppBEGFA_TisControllerTemplateElementTarget_tDB0CB7A22A83FD188DBBB27A7D75DD3459D5542C_m73B7B7D8BE540D2410F77E3C5456F5C2F945B484_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* TpeBEFhFAWNAsvKKQTVtIrdFUsQw_OlLACmpwoMamrxMTFzLaRnppBEGFA_TisInt32Enum_tCBAC8BA2BFF3A845FA599F303093BBBA374B6F0C_m367FAB5997343ECE6DE4E93FF624C27132D42877_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* TpeBEFhFAWNAsvKKQTVtIrdFUsQw_OlLACmpwoMamrxMTFzLaRnppBEGFA_TisRuntimeObject_mC8479E090ED307F17BAE844DE2C29FE904E56C5B_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* _AndroidJNIHelper_ConvertFromJNIArray_TisRuntimeObject_m5D8B7D428A5F63BF226AE0F4F532986BA7991ADC_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* _AndroidJNIHelper_ConvertFromJNIArray_TisSByte_tFEFFEF5D2FEBF5207950AE6FAC150FC53B668DB5_mA0B7EDEC4FB783CA5C528BD35AC09FE99A737138_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* _AndroidJNIHelper_ConvertFromJNIArray_TisSingle_t4530F2FF86FCB0DC29F35385CA1BD21BE294761C_m570EA7BE13782F59FC9603040D1937DC0577BADB_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeType* AndroidJavaObject_t8FFB930F335C1178405B82AC2BF512BB1EEF9EB0_0_0_0_var;
IL2CPP_EXTERN_C const RuntimeType* Boolean_t09A6377A54BE2F9E6985A8149F19234FD7DDFE22_0_0_0_var;
IL2CPP_EXTERN_C const RuntimeType* Byte_t94D9231AC217BE4D2E004C4CD32DF6D099EA41A3_0_0_0_var;
IL2CPP_EXTERN_C const RuntimeType* Char_t521A6F19B456D956AF452D926C32709DC03D6B17_0_0_0_var;
IL2CPP_EXTERN_C const RuntimeType* Controller_t919A4A50FC7A0F25D7B31615C0F4E4D4A4D17911_0_0_0_var;
IL2CPP_EXTERN_C const RuntimeType* CustomController_t749B7DF2AA8AD20FEC4C2003C4FF5000FE9C6065_0_0_0_var;
IL2CPP_EXTERN_C const RuntimeType* Double_tE150EF3D1D43DEE85D533810AB4C742307EEDE5F_0_0_0_var;
IL2CPP_EXTERN_C const RuntimeType* Int16_tB8EF286A9C33492FA6E6D6E67320BE93E794A175_0_0_0_var;
IL2CPP_EXTERN_C const RuntimeType* Int32_t680FF22E76F6EFAD4375103CBBFFA0421349384C_0_0_0_var;
IL2CPP_EXTERN_C const RuntimeType* Int64_t092CFB123BE63C28ACDAF65C68F21A526050DBA3_0_0_0_var;
IL2CPP_EXTERN_C const RuntimeType* Joystick_tEC65D4846A553E83F365E7D8D263DC644C75FC11_0_0_0_var;
IL2CPP_EXTERN_C const RuntimeType* Keyboard_t3FD52938480ACCD23FDB0DAEC857F9A9D29CC6C3_0_0_0_var;
IL2CPP_EXTERN_C const RuntimeType* Mouse_t5C8D9CB89A5C0F4EE87A70501CAF2A68E36DC019_0_0_0_var;
IL2CPP_EXTERN_C const RuntimeType* SByte_tFEFFEF5D2FEBF5207950AE6FAC150FC53B668DB5_0_0_0_var;
IL2CPP_EXTERN_C const RuntimeType* Single_t4530F2FF86FCB0DC29F35385CA1BD21BE294761C_0_0_0_var;
IL2CPP_EXTERN_C const RuntimeType* String_t_0_0_0_var;
IL2CPP_EXTERN_C const RuntimeType* gRfTGJhxieuOzGUxjqzzxNNmLUuF_t7BBB41BAB66EDE0363D72C224F9B9ABD3F60154A_0_0_0_var;
struct Delegate_t_marshaled_com;
struct Delegate_t_marshaled_pinvoke;
struct DeviceRequirement_t80E71C44DF1923C15D3AA025242B7348EBF8B056_marshaled_com;
struct DeviceRequirement_t80E71C44DF1923C15D3AA025242B7348EBF8B056_marshaled_pinvoke;
struct Exception_t_marshaled_com;
struct Exception_t_marshaled_pinvoke;

struct ActionElementMapU5BU5D_t695D4AC334ED6665D93DB89FAFA472C4F2CAADAE;
struct AndroidJavaObjectU5BU5D_tBCEB142050F282B940177011644246618E002001;
struct BooleanU5BU5D_tD317D27C31DB892BE79FAE3AEBC0B3FFB73DE9B4;
struct ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031;
struct CharU5BU5D_t799905CF001DD5F13F7DBB310181FC4D8B7D0AAB;
struct DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE;
struct IControllerTemplateU5BU5D_tAD319B5FD030C9F0A993A85F2EB5B7A47390C3DB;
struct Int16U5BU5D_t8175CE8DD9C9F9FB0CF4F58E45BC570575B43CFB;
struct Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C;
struct Int64U5BU5D_tAEDFCBDB5414E2A140A6F34C0538BF97FCF67A1D;
struct ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918;
struct SByteU5BU5D_t88116DA68378C3333DB73E7D36C1A06AFAA91913;
struct SingleU5BU5D_t89DEFE97BCEDB5857010E79ECE0F52CF6E93B87C;
struct StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248;
struct kfzfjnagLVVtsyAzdAlUhZdNuSIQAU5BU5D_tEEB780C862E2161EBC7C54D3F94963F74723F9AB;

IL2CPP_EXTERN_C_BEGIN
IL2CPP_EXTERN_C_END

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// Rewired.Utils.Classes.Data.ADictionary`2<System.Type,System.Collections.Generic.List`1<System.Object>>
struct ADictionary_2_tE212D15054E58919DA98BE219858633B9BBE9C90  : public RuntimeObject
{
	// System.Int32[] Rewired.Utils.Classes.Data.ADictionary`2::hBHnKjOKNyqOdsCnDDkvqkMDRLqO
	Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* ___hBHnKjOKNyqOdsCnDDkvqkMDRLqO_0;
	// Rewired.Utils.Classes.Data.ADictionary`2/Entry<TKey,TValue>[] Rewired.Utils.Classes.Data.ADictionary`2::_entries
	EntryU5BU5D_tBEF1CF86AE6644142868E42CBD5F40FAE6CC8502* ____entries_1;
	// System.Int32 Rewired.Utils.Classes.Data.ADictionary`2::_count
	int32_t ____count_2;
	// System.Int32 Rewired.Utils.Classes.Data.ADictionary`2::dDxvGzobXziVUJaHlaTpJsagIDXoA
	int32_t ___dDxvGzobXziVUJaHlaTpJsagIDXoA_3;
	// System.Int32 Rewired.Utils.Classes.Data.ADictionary`2::zQEnKkguAdJfEMbGmoKLtHFKpVmR
	int32_t ___zQEnKkguAdJfEMbGmoKLtHFKpVmR_4;
	// System.Int32 Rewired.Utils.Classes.Data.ADictionary`2::UwobTgBwsvhLyhvnLZRObzcCKouh
	int32_t ___UwobTgBwsvhLyhvnLZRObzcCKouh_5;
	// System.Int32 Rewired.Utils.Classes.Data.ADictionary`2::SZpArvgmtQsrColXZFMVispJeoLnA
	int32_t ___SZpArvgmtQsrColXZFMVispJeoLnA_6;
	// System.Collections.Generic.IEqualityComparer`1<TKey> Rewired.Utils.Classes.Data.ADictionary`2::VdYpdEZnSGVoyveNkTLTyGLNSpDu
	RuntimeObject* ___VdYpdEZnSGVoyveNkTLTyGLNSpDu_7;
	// System.Collections.Generic.IEqualityComparer`1<TValue> Rewired.Utils.Classes.Data.ADictionary`2::xILbHelkXEsoZTQWtsQKxMSseTvX
	RuntimeObject* ___xILbHelkXEsoZTQWtsQKxMSseTvX_8;
	// Rewired.Utils.Classes.Data.ADictionary`2/KeyCollection<TKey,TValue> Rewired.Utils.Classes.Data.ADictionary`2::YcKVNwmPgSHNlPIJFDeWgnMukprH
	KeyCollection_t7D4171FCA647FC97B8FD8CB9CB6ADC57A5E43926* ___YcKVNwmPgSHNlPIJFDeWgnMukprH_9;
	// Rewired.Utils.Classes.Data.ADictionary`2/ValueCollection<TKey,TValue> Rewired.Utils.Classes.Data.ADictionary`2::bNImUmJdzhwSQuMfxhmsgpssPPzj
	ValueCollection_t001A6551D863C7528911355B2D51046F93A23122* ___bNImUmJdzhwSQuMfxhmsgpssPPzj_10;
	// System.Object Rewired.Utils.Classes.Data.ADictionary`2::uXQCPPeDdkgzHLqUogIHISHifuKw
	RuntimeObject* ___uXQCPPeDdkgzHLqUogIHISHifuKw_11;
};

struct ADictionary_2_tE212D15054E58919DA98BE219858633B9BBE9C90_StaticFields
{
	// System.Boolean Rewired.Utils.Classes.Data.ADictionary`2::HiPAjnVrrxHuzfXeSZrxRKlrmSgE
	bool ___HiPAjnVrrxHuzfXeSZrxRKlrmSgE_12;
	// System.Boolean Rewired.Utils.Classes.Data.ADictionary`2::pDnjvaPOJnzZuPYdkVBOftVOcNOq
	bool ___pDnjvaPOJnzZuPYdkVBOftVOcNOq_13;
};

// Rewired.Utils.Classes.Data.AList`1<Rewired.ActionElementMap>
struct AList_1_t26BA8BE4BEB503507B02BE892DA37BBBAA585997  : public RuntimeObject
{
	// System.Collections.Generic.IEqualityComparer`1<T> Rewired.Utils.Classes.Data.AList`1::OEECEzMCywMiQmwWsJnNGReviPMq
	RuntimeObject* ___OEECEzMCywMiQmwWsJnNGReviPMq_2;
	// T[] Rewired.Utils.Classes.Data.AList`1::_items
	ActionElementMapU5BU5D_t695D4AC334ED6665D93DB89FAFA472C4F2CAADAE* ____items_3;
	// System.Int32 Rewired.Utils.Classes.Data.AList`1::AlGFqXRmWkWGxdtaUpXrDtnfGrbK
	int32_t ___AlGFqXRmWkWGxdtaUpXrDtnfGrbK_4;
	// System.Int32 Rewired.Utils.Classes.Data.AList`1::_count
	int32_t ____count_5;
	// System.Int32 Rewired.Utils.Classes.Data.AList`1::QrwXvbYJSAUvOMQLnqaDsDTTtvov
	int32_t ___QrwXvbYJSAUvOMQLnqaDsDTTtvov_6;
	// System.Boolean Rewired.Utils.Classes.Data.AList`1::TAFjkpDaaDJoHAaPXEBxowOVneOVA
	bool ___TAFjkpDaaDJoHAaPXEBxowOVneOVA_7;
	// System.Int32 Rewired.Utils.Classes.Data.AList`1::DgwZlsqOOxObfrKApIpofkDwPULmA
	int32_t ___DgwZlsqOOxObfrKApIpofkDwPULmA_8;
	// System.Boolean Rewired.Utils.Classes.Data.AList`1::bJwPdMKsDMuQUwBuPKIdAtxaeMnw
	bool ___bJwPdMKsDMuQUwBuPKIdAtxaeMnw_9;
	// System.Int32 Rewired.Utils.Classes.Data.AList`1::dDxvGzobXziVUJaHlaTpJsagIDXoA
	int32_t ___dDxvGzobXziVUJaHlaTpJsagIDXoA_10;
	// System.Object Rewired.Utils.Classes.Data.AList`1::uXQCPPeDdkgzHLqUogIHISHifuKw
	RuntimeObject* ___uXQCPPeDdkgzHLqUogIHISHifuKw_11;
};

struct AList_1_t26BA8BE4BEB503507B02BE892DA37BBBAA585997_StaticFields
{
	// T[] Rewired.Utils.Classes.Data.AList`1::TyAFzPeuZgmWUgfIuPwdzoWaQriN
	ActionElementMapU5BU5D_t695D4AC334ED6665D93DB89FAFA472C4F2CAADAE* ___TyAFzPeuZgmWUgfIuPwdzoWaQriN_1;
};

// Rewired.Utils.Classes.Data.AList`1<Rewired.IControllerTemplate>
struct AList_1_t6F028F71F04E9F8A363286413FD2E2C6C409F5B5  : public RuntimeObject
{
	// System.Collections.Generic.IEqualityComparer`1<T> Rewired.Utils.Classes.Data.AList`1::OEECEzMCywMiQmwWsJnNGReviPMq
	RuntimeObject* ___OEECEzMCywMiQmwWsJnNGReviPMq_2;
	// T[] Rewired.Utils.Classes.Data.AList`1::_items
	IControllerTemplateU5BU5D_tAD319B5FD030C9F0A993A85F2EB5B7A47390C3DB* ____items_3;
	// System.Int32 Rewired.Utils.Classes.Data.AList`1::AlGFqXRmWkWGxdtaUpXrDtnfGrbK
	int32_t ___AlGFqXRmWkWGxdtaUpXrDtnfGrbK_4;
	// System.Int32 Rewired.Utils.Classes.Data.AList`1::_count
	int32_t ____count_5;
	// System.Int32 Rewired.Utils.Classes.Data.AList`1::QrwXvbYJSAUvOMQLnqaDsDTTtvov
	int32_t ___QrwXvbYJSAUvOMQLnqaDsDTTtvov_6;
	// System.Boolean Rewired.Utils.Classes.Data.AList`1::TAFjkpDaaDJoHAaPXEBxowOVneOVA
	bool ___TAFjkpDaaDJoHAaPXEBxowOVneOVA_7;
	// System.Int32 Rewired.Utils.Classes.Data.AList`1::DgwZlsqOOxObfrKApIpofkDwPULmA
	int32_t ___DgwZlsqOOxObfrKApIpofkDwPULmA_8;
	// System.Boolean Rewired.Utils.Classes.Data.AList`1::bJwPdMKsDMuQUwBuPKIdAtxaeMnw
	bool ___bJwPdMKsDMuQUwBuPKIdAtxaeMnw_9;
	// System.Int32 Rewired.Utils.Classes.Data.AList`1::dDxvGzobXziVUJaHlaTpJsagIDXoA
	int32_t ___dDxvGzobXziVUJaHlaTpJsagIDXoA_10;
	// System.Object Rewired.Utils.Classes.Data.AList`1::uXQCPPeDdkgzHLqUogIHISHifuKw
	RuntimeObject* ___uXQCPPeDdkgzHLqUogIHISHifuKw_11;
};

struct AList_1_t6F028F71F04E9F8A363286413FD2E2C6C409F5B5_StaticFields
{
	// T[] Rewired.Utils.Classes.Data.AList`1::TyAFzPeuZgmWUgfIuPwdzoWaQriN
	IControllerTemplateU5BU5D_tAD319B5FD030C9F0A993A85F2EB5B7A47390C3DB* ___TyAFzPeuZgmWUgfIuPwdzoWaQriN_1;
};

// Rewired.Utils.Classes.Data.AList`1<System.Object>
struct AList_1_t8AC95BE03ABEFD201943BE98AD0C21498B716AD0  : public RuntimeObject
{
	// System.Collections.Generic.IEqualityComparer`1<T> Rewired.Utils.Classes.Data.AList`1::OEECEzMCywMiQmwWsJnNGReviPMq
	RuntimeObject* ___OEECEzMCywMiQmwWsJnNGReviPMq_2;
	// T[] Rewired.Utils.Classes.Data.AList`1::_items
	ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* ____items_3;
	// System.Int32 Rewired.Utils.Classes.Data.AList`1::AlGFqXRmWkWGxdtaUpXrDtnfGrbK
	int32_t ___AlGFqXRmWkWGxdtaUpXrDtnfGrbK_4;
	// System.Int32 Rewired.Utils.Classes.Data.AList`1::_count
	int32_t ____count_5;
	// System.Int32 Rewired.Utils.Classes.Data.AList`1::QrwXvbYJSAUvOMQLnqaDsDTTtvov
	int32_t ___QrwXvbYJSAUvOMQLnqaDsDTTtvov_6;
	// System.Boolean Rewired.Utils.Classes.Data.AList`1::TAFjkpDaaDJoHAaPXEBxowOVneOVA
	bool ___TAFjkpDaaDJoHAaPXEBxowOVneOVA_7;
	// System.Int32 Rewired.Utils.Classes.Data.AList`1::DgwZlsqOOxObfrKApIpofkDwPULmA
	int32_t ___DgwZlsqOOxObfrKApIpofkDwPULmA_8;
	// System.Boolean Rewired.Utils.Classes.Data.AList`1::bJwPdMKsDMuQUwBuPKIdAtxaeMnw
	bool ___bJwPdMKsDMuQUwBuPKIdAtxaeMnw_9;
	// System.Int32 Rewired.Utils.Classes.Data.AList`1::dDxvGzobXziVUJaHlaTpJsagIDXoA
	int32_t ___dDxvGzobXziVUJaHlaTpJsagIDXoA_10;
	// System.Object Rewired.Utils.Classes.Data.AList`1::uXQCPPeDdkgzHLqUogIHISHifuKw
	RuntimeObject* ___uXQCPPeDdkgzHLqUogIHISHifuKw_11;
};

struct AList_1_t8AC95BE03ABEFD201943BE98AD0C21498B716AD0_StaticFields
{
	// T[] Rewired.Utils.Classes.Data.AList`1::TyAFzPeuZgmWUgfIuPwdzoWaQriN
	ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* ___TyAFzPeuZgmWUgfIuPwdzoWaQriN_1;
};

// System.Collections.Generic.Dictionary`2<System.String,Rewired.Utils.SafeDelegate>
struct Dictionary_2_t340D9BC5CF0537B47A79183E8A310B59364118DF  : public RuntimeObject
{
	// System.Int32[] System.Collections.Generic.Dictionary`2::_buckets
	Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* ____buckets_0;
	// System.Collections.Generic.Dictionary`2/Entry<TKey,TValue>[] System.Collections.Generic.Dictionary`2::_entries
	EntryU5BU5D_tBB20375F0C4F0B8E07B304ECB985A08BE1D17BA6* ____entries_1;
	// System.Int32 System.Collections.Generic.Dictionary`2::_count
	int32_t ____count_2;
	// System.Int32 System.Collections.Generic.Dictionary`2::_freeList
	int32_t ____freeList_3;
	// System.Int32 System.Collections.Generic.Dictionary`2::_freeCount
	int32_t ____freeCount_4;
	// System.Int32 System.Collections.Generic.Dictionary`2::_version
	int32_t ____version_5;
	// System.Collections.Generic.IEqualityComparer`1<TKey> System.Collections.Generic.Dictionary`2::_comparer
	RuntimeObject* ____comparer_6;
	// System.Collections.Generic.Dictionary`2/KeyCollection<TKey,TValue> System.Collections.Generic.Dictionary`2::_keys
	KeyCollection_t515A8D63CC0D6B3E49474556B49934FD9401A8F3* ____keys_7;
	// System.Collections.Generic.Dictionary`2/ValueCollection<TKey,TValue> System.Collections.Generic.Dictionary`2::_values
	ValueCollection_t0B899EC38D1F37351DE52E1F4F15571485D90E24* ____values_8;
	// System.Object System.Collections.Generic.Dictionary`2::_syncRoot
	RuntimeObject* ____syncRoot_9;
};

// System.Collections.Generic.Dictionary`2<Rewired.InputMapper/JdpDLqzkBAGmKbSgujDlWammLWSdA,Rewired.Utils.SafeDelegate>
struct Dictionary_2_t501DD8094A745126C4C4ED68F7198F76A46828B2  : public RuntimeObject
{
	// System.Int32[] System.Collections.Generic.Dictionary`2::_buckets
	Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* ____buckets_0;
	// System.Collections.Generic.Dictionary`2/Entry<TKey,TValue>[] System.Collections.Generic.Dictionary`2::_entries
	EntryU5BU5D_tF33C6D41F20C2086FAB77C6BCE1A6845588AFF76* ____entries_1;
	// System.Int32 System.Collections.Generic.Dictionary`2::_count
	int32_t ____count_2;
	// System.Int32 System.Collections.Generic.Dictionary`2::_freeList
	int32_t ____freeList_3;
	// System.Int32 System.Collections.Generic.Dictionary`2::_freeCount
	int32_t ____freeCount_4;
	// System.Int32 System.Collections.Generic.Dictionary`2::_version
	int32_t ____version_5;
	// System.Collections.Generic.IEqualityComparer`1<TKey> System.Collections.Generic.Dictionary`2::_comparer
	RuntimeObject* ____comparer_6;
	// System.Collections.Generic.Dictionary`2/KeyCollection<TKey,TValue> System.Collections.Generic.Dictionary`2::_keys
	KeyCollection_tF9F33848D92D17775FB3C4E0F8B8B1B6448F15A7* ____keys_7;
	// System.Collections.Generic.Dictionary`2/ValueCollection<TKey,TValue> System.Collections.Generic.Dictionary`2::_values
	ValueCollection_t3F60E4ECE8676EDD56C11BED98E5EFBE8ECDB760* ____values_8;
	// System.Object System.Collections.Generic.Dictionary`2::_syncRoot
	RuntimeObject* ____syncRoot_9;
};

// UnityEngine.Rendering.DynamicArray`1<UnityEngine.Experimental.Rendering.RenderGraphModule.IRenderGraphResource>
struct DynamicArray_1_t401F46C0081DE185BCAB1D30DE8D6B6DC9AA6AFB  : public RuntimeObject
{
	// T[] UnityEngine.Rendering.DynamicArray`1::m_Array
	IRenderGraphResourceU5BU5D_tC72A5980774D8ACE9E681BE8A3FAB493A70BC2F3* ___m_Array_0;
	// System.Int32 UnityEngine.Rendering.DynamicArray`1::<size>k__BackingField
	int32_t ___U3CsizeU3Ek__BackingField_1;
};

// UnityEngine.Rendering.DynamicArray`1<System.Object>
struct DynamicArray_1_t7C64F5A74B7BA6F6B3589A766CADE3F59C6C7BCA  : public RuntimeObject
{
	// T[] UnityEngine.Rendering.DynamicArray`1::m_Array
	ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* ___m_Array_0;
	// System.Int32 UnityEngine.Rendering.DynamicArray`1::<size>k__BackingField
	int32_t ___U3CsizeU3Ek__BackingField_1;
};

// System.Collections.Generic.List`1<Rewired.ActionElementMap>
struct List_1_t61A2C1C85DEC6157A1333F351530E22E04BDF9A6  : public RuntimeObject
{
	// T[] System.Collections.Generic.List`1::_items
	ActionElementMapU5BU5D_t695D4AC334ED6665D93DB89FAFA472C4F2CAADAE* ____items_1;
	// System.Int32 System.Collections.Generic.List`1::_size
	int32_t ____size_2;
	// System.Int32 System.Collections.Generic.List`1::_version
	int32_t ____version_3;
	// System.Object System.Collections.Generic.List`1::_syncRoot
	RuntimeObject* ____syncRoot_4;
};

struct List_1_t61A2C1C85DEC6157A1333F351530E22E04BDF9A6_StaticFields
{
	// T[] System.Collections.Generic.List`1::s_emptyArray
	ActionElementMapU5BU5D_t695D4AC334ED6665D93DB89FAFA472C4F2CAADAE* ___s_emptyArray_5;
};

// System.Collections.Generic.List`1<Rewired.ControllerTemplateElementTarget>
struct List_1_tB9A85F131783B7EEF32BCC88394DEF28B255F56A  : public RuntimeObject
{
	// T[] System.Collections.Generic.List`1::_items
	ControllerTemplateElementTargetU5BU5D_t40239EE457C54F98C6E975C8E924AE4D95CFD2B9* ____items_1;
	// System.Int32 System.Collections.Generic.List`1::_size
	int32_t ____size_2;
	// System.Int32 System.Collections.Generic.List`1::_version
	int32_t ____version_3;
	// System.Object System.Collections.Generic.List`1::_syncRoot
	RuntimeObject* ____syncRoot_4;
};

struct List_1_tB9A85F131783B7EEF32BCC88394DEF28B255F56A_StaticFields
{
	// T[] System.Collections.Generic.List`1::s_emptyArray
	ControllerTemplateElementTargetU5BU5D_t40239EE457C54F98C6E975C8E924AE4D95CFD2B9* ___s_emptyArray_5;
};

// System.Collections.Generic.List`1<System.Int32Enum>
struct List_1_tDA4D291C60B1EFA9EA50BBA3367C657CC9410576  : public RuntimeObject
{
	// T[] System.Collections.Generic.List`1::_items
	Int32EnumU5BU5D_t87B7DB802810C38016332669039EF42C487A081F* ____items_1;
	// System.Int32 System.Collections.Generic.List`1::_size
	int32_t ____size_2;
	// System.Int32 System.Collections.Generic.List`1::_version
	int32_t ____version_3;
	// System.Object System.Collections.Generic.List`1::_syncRoot
	RuntimeObject* ____syncRoot_4;
};

struct List_1_tDA4D291C60B1EFA9EA50BBA3367C657CC9410576_StaticFields
{
	// T[] System.Collections.Generic.List`1::s_emptyArray
	Int32EnumU5BU5D_t87B7DB802810C38016332669039EF42C487A081F* ___s_emptyArray_5;
};

// System.Collections.Generic.List`1<System.Object>
struct List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D  : public RuntimeObject
{
	// T[] System.Collections.Generic.List`1::_items
	ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* ____items_1;
	// System.Int32 System.Collections.Generic.List`1::_size
	int32_t ____size_2;
	// System.Int32 System.Collections.Generic.List`1::_version
	int32_t ____version_3;
	// System.Object System.Collections.Generic.List`1::_syncRoot
	RuntimeObject* ____syncRoot_4;
};

struct List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D_StaticFields
{
	// T[] System.Collections.Generic.List`1::s_emptyArray
	ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* ___s_emptyArray_5;
};

// System.Collections.Generic.List`1<System.String>
struct List_1_tF470A3BE5C1B5B68E1325EF3F109D172E60BD7CD  : public RuntimeObject
{
	// T[] System.Collections.Generic.List`1::_items
	StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248* ____items_1;
	// System.Int32 System.Collections.Generic.List`1::_size
	int32_t ____size_2;
	// System.Int32 System.Collections.Generic.List`1::_version
	int32_t ____version_3;
	// System.Object System.Collections.Generic.List`1::_syncRoot
	RuntimeObject* ____syncRoot_4;
};

struct List_1_tF470A3BE5C1B5B68E1325EF3F109D172E60BD7CD_StaticFields
{
	// T[] System.Collections.Generic.List`1::s_emptyArray
	StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248* ___s_emptyArray_5;
};

// System.Collections.Generic.List`1<Rewired.PlayerController/Element>
struct List_1_t1327B0703B35EF48626AC42F0D0C487FCBD86CF5  : public RuntimeObject
{
	// T[] System.Collections.Generic.List`1::_items
	ElementU5BU5D_tC73650C0F545F4B732A2FB4ACA8D0BF30F9C1C4D* ____items_1;
	// System.Int32 System.Collections.Generic.List`1::_size
	int32_t ____size_2;
	// System.Int32 System.Collections.Generic.List`1::_version
	int32_t ____version_3;
	// System.Object System.Collections.Generic.List`1::_syncRoot
	RuntimeObject* ____syncRoot_4;
};

struct List_1_t1327B0703B35EF48626AC42F0D0C487FCBD86CF5_StaticFields
{
	// T[] System.Collections.Generic.List`1::s_emptyArray
	ElementU5BU5D_tC73650C0F545F4B732A2FB4ACA8D0BF30F9C1C4D* ___s_emptyArray_5;
};

// System.Collections.Generic.List`1<Rewired.Data.UserData/PMmfElSRTHipvrooOqnrsVzyuehD/kzedFdEdISaCJppRVzkSmhYBfiDK>
struct List_1_t2371DBA2BC5BA5E401A3796013E23F6AA5DE82E7  : public RuntimeObject
{
	// T[] System.Collections.Generic.List`1::_items
	kzedFdEdISaCJppRVzkSmhYBfiDKU5BU5D_t33F6EB465ABC6573F2555141720A5BCD57EBC4C6* ____items_1;
	// System.Int32 System.Collections.Generic.List`1::_size
	int32_t ____size_2;
	// System.Int32 System.Collections.Generic.List`1::_version
	int32_t ____version_3;
	// System.Object System.Collections.Generic.List`1::_syncRoot
	RuntimeObject* ____syncRoot_4;
};

struct List_1_t2371DBA2BC5BA5E401A3796013E23F6AA5DE82E7_StaticFields
{
	// T[] System.Collections.Generic.List`1::s_emptyArray
	kzedFdEdISaCJppRVzkSmhYBfiDKU5BU5D_t33F6EB465ABC6573F2555141720A5BCD57EBC4C6* ___s_emptyArray_5;
};

// System.Collections.ObjectModel.ReadOnlyCollection`1<System.Object>
struct ReadOnlyCollection_1_t5397DF0DB61D1090E7BBC89395CECB8D020CED92  : public RuntimeObject
{
	// System.Collections.Generic.IList`1<T> System.Collections.ObjectModel.ReadOnlyCollection`1::list
	RuntimeObject* ___list_0;
	// System.Object System.Collections.ObjectModel.ReadOnlyCollection`1::_syncRoot
	RuntimeObject* ____syncRoot_1;
};

// Rewired.Utils.TempListPool/TList`1<Rewired.ControllerTemplateElementTarget>
struct TList_1_t08828BE7F5A36A1F8E5542F3DE822A03B4E625D7  : public RuntimeObject
{
	// System.Collections.Generic.List`1<T> Rewired.Utils.TempListPool/TList`1::VNRjhxdkwzCQsQLRYBpUhOzPIPLcA
	List_1_tB9A85F131783B7EEF32BCC88394DEF28B255F56A* ___VNRjhxdkwzCQsQLRYBpUhOzPIPLcA_0;
	// System.Boolean Rewired.Utils.TempListPool/TList`1::smLxyjQFlClJKIZlhLSifPFFImqe
	bool ___smLxyjQFlClJKIZlhLSifPFFImqe_1;
};

// Rewired.Utils.TempListPool/TList`1<System.Int32Enum>
struct TList_1_t91EC4434C71F6E97F426C89A756A7E8D0F090069  : public RuntimeObject
{
	// System.Collections.Generic.List`1<T> Rewired.Utils.TempListPool/TList`1::VNRjhxdkwzCQsQLRYBpUhOzPIPLcA
	List_1_tDA4D291C60B1EFA9EA50BBA3367C657CC9410576* ___VNRjhxdkwzCQsQLRYBpUhOzPIPLcA_0;
	// System.Boolean Rewired.Utils.TempListPool/TList`1::smLxyjQFlClJKIZlhLSifPFFImqe
	bool ___smLxyjQFlClJKIZlhLSifPFFImqe_1;
};

// Rewired.Utils.TempListPool/TList`1<System.Object>
struct TList_1_t5EEB5351D4D3485884B025F946B9EB1B39C163F7  : public RuntimeObject
{
	// System.Collections.Generic.List`1<T> Rewired.Utils.TempListPool/TList`1::VNRjhxdkwzCQsQLRYBpUhOzPIPLcA
	List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D* ___VNRjhxdkwzCQsQLRYBpUhOzPIPLcA_0;
	// System.Boolean Rewired.Utils.TempListPool/TList`1::smLxyjQFlClJKIZlhLSifPFFImqe
	bool ___smLxyjQFlClJKIZlhLSifPFFImqe_1;
};

// Rewired.Player/ControllerHelper/MapHelper/XcujpkEuhtkMjJAdZtQvqOzWNWoy`1<System.Object>
struct XcujpkEuhtkMjJAdZtQvqOzWNWoy_1_t8DB30E00B0855C4A917D6B66CABCB5A4E19B64A2  : public RuntimeObject
{
	// System.Int32 Rewired.Player/ControllerHelper/MapHelper/XcujpkEuhtkMjJAdZtQvqOzWNWoy`1::lhJjXYwkSAdydFfoeAtjBqWdritd
	int32_t ___lhJjXYwkSAdydFfoeAtjBqWdritd_0;
	// ? Rewired.Player/ControllerHelper/MapHelper/XcujpkEuhtkMjJAdZtQvqOzWNWoy`1::vCTBKloGAsThLIlfLnSUZmMAGBkDA
	RuntimeObject* ___vCTBKloGAsThLIlfLnSUZmMAGBkDA_1;
	// System.Int32 Rewired.Player/ControllerHelper/MapHelper/XcujpkEuhtkMjJAdZtQvqOzWNWoy`1::IZEjyMBhYsNpKQOWFbNUXKoJwbAw
	int32_t ___IZEjyMBhYsNpKQOWFbNUXKoJwbAw_2;
	// Rewired.Player/ControllerHelper/MapHelper Rewired.Player/ControllerHelper/MapHelper/XcujpkEuhtkMjJAdZtQvqOzWNWoy`1::hJlvyFukKfMzsWcSVLwLCnIUdlMn
	MapHelper_t214BA4F045E5EB4B312E4E6AEB6697813117A7C2* ___hJlvyFukKfMzsWcSVLwLCnIUdlMn_3;
	// Rewired.Player/ControllerHelper/ftuHLSCvHbrPYKqmDICMGujVuqLSA Rewired.Player/ControllerHelper/MapHelper/XcujpkEuhtkMjJAdZtQvqOzWNWoy`1::RhoklXMlDeARBfOObjVUKakOXgdeA
	RuntimeObject* ___RhoklXMlDeARBfOObjVUKakOXgdeA_4;
	// System.Int32 Rewired.Player/ControllerHelper/MapHelper/XcujpkEuhtkMjJAdZtQvqOzWNWoy`1::HOOpigeeRuyReWfgMQJxfXYvUNwH
	int32_t ___HOOpigeeRuyReWfgMQJxfXYvUNwH_5;
	// System.Int32 Rewired.Player/ControllerHelper/MapHelper/XcujpkEuhtkMjJAdZtQvqOzWNWoy`1::fTTaoeLLVFUEgMJwbZIHjVZVmjnK
	int32_t ___fTTaoeLLVFUEgMJwbZIHjVZVmjnK_6;
	// hDTwQOONkmiSaaPHwqpfFkmXMCAbb Rewired.Player/ControllerHelper/MapHelper/XcujpkEuhtkMjJAdZtQvqOzWNWoy`1::JsBfchTjctnPGyvjpuogNYRZHTKU
	RuntimeObject* ___JsBfchTjctnPGyvjpuogNYRZHTKU_7;
	// System.Int32 Rewired.Player/ControllerHelper/MapHelper/XcujpkEuhtkMjJAdZtQvqOzWNWoy`1::ojgEuUdjMsfvxJQiTPipdnqsjqok
	int32_t ___ojgEuUdjMsfvxJQiTPipdnqsjqok_8;
	// System.Int32 Rewired.Player/ControllerHelper/MapHelper/XcujpkEuhtkMjJAdZtQvqOzWNWoy`1::pmsBuwFKIVUOBshhcpLYItWMxXXFA
	int32_t ___pmsBuwFKIVUOBshhcpLYItWMxXXFA_9;
	// System.Int32 Rewired.Player/ControllerHelper/MapHelper/XcujpkEuhtkMjJAdZtQvqOzWNWoy`1::oYMqbhFUOAaXPWHbZOuQUzxPRMHS
	int32_t ___oYMqbhFUOAaXPWHbZOuQUzxPRMHS_10;
	// System.Int32 Rewired.Player/ControllerHelper/MapHelper/XcujpkEuhtkMjJAdZtQvqOzWNWoy`1::wINccAGXbAcQxOvtiHsbbrlaykhzb
	int32_t ___wINccAGXbAcQxOvtiHsbbrlaykhzb_11;
};

// Rewired.Data.UserData/PMmfElSRTHipvrooOqnrsVzyuehD/aKSDPjRJZQzZwYkmoXKHoOMDFOWe`1<System.Object>
struct aKSDPjRJZQzZwYkmoXKHoOMDFOWe_1_tBF7584EF632A787EC6F2057BA1C49894E7E22FCA  : public RuntimeObject
{
	// System.Func`2<?,System.Int32> Rewired.Data.UserData/PMmfElSRTHipvrooOqnrsVzyuehD/aKSDPjRJZQzZwYkmoXKHoOMDFOWe`1::FkKDhjApMORrhuHhObhaCvDMkiLpA
	Func_2_t9A0D493A82DCC47C9C819A3B045E02D9B5DDCE1B* ___FkKDhjApMORrhuHhObhaCvDMkiLpA_0;
};

// Rewired.Player/ControllerHelper/MapHelper/ecjdcwfzgyPMBWdzOraiwfCBcrRoA`1<System.Object>
struct ecjdcwfzgyPMBWdzOraiwfCBcrRoA_1_tCC80E04812F8A48B4DDE3B494ED31F6CC82A6A73  : public RuntimeObject
{
	// System.Int32 Rewired.Player/ControllerHelper/MapHelper/ecjdcwfzgyPMBWdzOraiwfCBcrRoA`1::lhJjXYwkSAdydFfoeAtjBqWdritd
	int32_t ___lhJjXYwkSAdydFfoeAtjBqWdritd_0;
	// ? Rewired.Player/ControllerHelper/MapHelper/ecjdcwfzgyPMBWdzOraiwfCBcrRoA`1::vCTBKloGAsThLIlfLnSUZmMAGBkDA
	RuntimeObject* ___vCTBKloGAsThLIlfLnSUZmMAGBkDA_1;
	// System.Int32 Rewired.Player/ControllerHelper/MapHelper/ecjdcwfzgyPMBWdzOraiwfCBcrRoA`1::IZEjyMBhYsNpKQOWFbNUXKoJwbAw
	int32_t ___IZEjyMBhYsNpKQOWFbNUXKoJwbAw_2;
	// Rewired.Player/ControllerHelper/MapHelper Rewired.Player/ControllerHelper/MapHelper/ecjdcwfzgyPMBWdzOraiwfCBcrRoA`1::hJlvyFukKfMzsWcSVLwLCnIUdlMn
	MapHelper_t214BA4F045E5EB4B312E4E6AEB6697813117A7C2* ___hJlvyFukKfMzsWcSVLwLCnIUdlMn_3;
	// System.Int32 Rewired.Player/ControllerHelper/MapHelper/ecjdcwfzgyPMBWdzOraiwfCBcrRoA`1::NgYvqnovMkSRHVNEWEYzgQedwFde
	int32_t ___NgYvqnovMkSRHVNEWEYzgQedwFde_4;
	// System.Int32 Rewired.Player/ControllerHelper/MapHelper/ecjdcwfzgyPMBWdzOraiwfCBcrRoA`1::SgebiqeFPgLJkOQfmwCTESQqHVje
	int32_t ___SgebiqeFPgLJkOQfmwCTESQqHVje_5;
	// System.Int32 Rewired.Player/ControllerHelper/MapHelper/ecjdcwfzgyPMBWdzOraiwfCBcrRoA`1::aJKEDagrPrZtQBPOWwEggrXpXqKRA
	int32_t ___aJKEDagrPrZtQBPOWwEggrXpXqKRA_6;
	// System.Int32 Rewired.Player/ControllerHelper/MapHelper/ecjdcwfzgyPMBWdzOraiwfCBcrRoA`1::HyLMjUIcjSOZGGOJZWHdhVkIwYLO
	int32_t ___HyLMjUIcjSOZGGOJZWHdhVkIwYLO_7;
	// System.Collections.Generic.IList`1<?> Rewired.Player/ControllerHelper/MapHelper/ecjdcwfzgyPMBWdzOraiwfCBcrRoA`1::cQiOFStxurrmPiHEdHNikfiBDsmp
	RuntimeObject* ___cQiOFStxurrmPiHEdHNikfiBDsmp_8;
	// System.Int32 Rewired.Player/ControllerHelper/MapHelper/ecjdcwfzgyPMBWdzOraiwfCBcrRoA`1::XRXvHMDaUbnUKSmMJEaxfPHXxbMm
	int32_t ___XRXvHMDaUbnUKSmMJEaxfPHXxbMm_9;
};

// Rewired.Player/ControllerHelper/MapHelper/ojuhOybXRUNKAWBYROlwkJhBlkPc`1<System.Object>
struct ojuhOybXRUNKAWBYROlwkJhBlkPc_1_t7B54C1CB431E7958F15D7F71C96CAF6E68E76D60  : public RuntimeObject
{
	// System.Int32 Rewired.Player/ControllerHelper/MapHelper/ojuhOybXRUNKAWBYROlwkJhBlkPc`1::lhJjXYwkSAdydFfoeAtjBqWdritd
	int32_t ___lhJjXYwkSAdydFfoeAtjBqWdritd_0;
	// ? Rewired.Player/ControllerHelper/MapHelper/ojuhOybXRUNKAWBYROlwkJhBlkPc`1::vCTBKloGAsThLIlfLnSUZmMAGBkDA
	RuntimeObject* ___vCTBKloGAsThLIlfLnSUZmMAGBkDA_1;
	// System.Int32 Rewired.Player/ControllerHelper/MapHelper/ojuhOybXRUNKAWBYROlwkJhBlkPc`1::IZEjyMBhYsNpKQOWFbNUXKoJwbAw
	int32_t ___IZEjyMBhYsNpKQOWFbNUXKoJwbAw_2;
	// Rewired.Player/ControllerHelper/MapHelper Rewired.Player/ControllerHelper/MapHelper/ojuhOybXRUNKAWBYROlwkJhBlkPc`1::hJlvyFukKfMzsWcSVLwLCnIUdlMn
	MapHelper_t214BA4F045E5EB4B312E4E6AEB6697813117A7C2* ___hJlvyFukKfMzsWcSVLwLCnIUdlMn_3;
	// System.Int32 Rewired.Player/ControllerHelper/MapHelper/ojuhOybXRUNKAWBYROlwkJhBlkPc`1::aJKEDagrPrZtQBPOWwEggrXpXqKRA
	int32_t ___aJKEDagrPrZtQBPOWwEggrXpXqKRA_4;
	// System.Int32 Rewired.Player/ControllerHelper/MapHelper/ojuhOybXRUNKAWBYROlwkJhBlkPc`1::HyLMjUIcjSOZGGOJZWHdhVkIwYLO
	int32_t ___HyLMjUIcjSOZGGOJZWHdhVkIwYLO_5;
	// Rewired.Player/ControllerHelper/ftuHLSCvHbrPYKqmDICMGujVuqLSA Rewired.Player/ControllerHelper/MapHelper/ojuhOybXRUNKAWBYROlwkJhBlkPc`1::RhoklXMlDeARBfOObjVUKakOXgdeA
	RuntimeObject* ___RhoklXMlDeARBfOObjVUKakOXgdeA_6;
	// System.Int32 Rewired.Player/ControllerHelper/MapHelper/ojuhOybXRUNKAWBYROlwkJhBlkPc`1::HOOpigeeRuyReWfgMQJxfXYvUNwH
	int32_t ___HOOpigeeRuyReWfgMQJxfXYvUNwH_7;
	// System.Int32 Rewired.Player/ControllerHelper/MapHelper/ojuhOybXRUNKAWBYROlwkJhBlkPc`1::RjiKTGRGCjXCRtPlIdejjrEnGTVX
	int32_t ___RjiKTGRGCjXCRtPlIdejjrEnGTVX_8;
	// hDTwQOONkmiSaaPHwqpfFkmXMCAbb Rewired.Player/ControllerHelper/MapHelper/ojuhOybXRUNKAWBYROlwkJhBlkPc`1::JsBfchTjctnPGyvjpuogNYRZHTKU
	RuntimeObject* ___JsBfchTjctnPGyvjpuogNYRZHTKU_9;
	// System.Int32 Rewired.Player/ControllerHelper/MapHelper/ojuhOybXRUNKAWBYROlwkJhBlkPc`1::ojgEuUdjMsfvxJQiTPipdnqsjqok
	int32_t ___ojgEuUdjMsfvxJQiTPipdnqsjqok_10;
	// System.Int32 Rewired.Player/ControllerHelper/MapHelper/ojuhOybXRUNKAWBYROlwkJhBlkPc`1::sJwAwqqBIUATnKeVHlBGaVmezkwF
	int32_t ___sJwAwqqBIUATnKeVHlBGaVmezkwF_11;
	// System.Int32 Rewired.Player/ControllerHelper/MapHelper/ojuhOybXRUNKAWBYROlwkJhBlkPc`1::oYMqbhFUOAaXPWHbZOuQUzxPRMHS
	int32_t ___oYMqbhFUOAaXPWHbZOuQUzxPRMHS_12;
	// System.Int32 Rewired.Player/ControllerHelper/MapHelper/ojuhOybXRUNKAWBYROlwkJhBlkPc`1::wINccAGXbAcQxOvtiHsbbrlaykhzb
	int32_t ___wINccAGXbAcQxOvtiHsbbrlaykhzb_13;
};

// Rewired.Player/ControllerHelper/bvHtPvdVkbINqyMOEkvOVjYbgQSB`2/omlOoYqlQcXnMjOFbISaKckKLkeYA<System.Object,System.Object>
struct omlOoYqlQcXnMjOFbISaKckKLkeYA_t31AF08D5218EBDFD5BF5572E096D762097D11AF0  : public RuntimeObject
{
	// ? Rewired.Player/ControllerHelper/bvHtPvdVkbINqyMOEkvOVjYbgQSB`2/omlOoYqlQcXnMjOFbISaKckKLkeYA::qqrQldxbErvVtpNyQAtEGvvTTIMe
	RuntimeObject* ___qqrQldxbErvVtpNyQAtEGvvTTIMe_0;
	// TBSPGJPKaXrjsOpBQZPxJnrcfSfAA`1<?> Rewired.Player/ControllerHelper/bvHtPvdVkbINqyMOEkvOVjYbgQSB`2/omlOoYqlQcXnMjOFbISaKckKLkeYA::kfHAOgauRJPvjKmCDapJwwhskNfUA
	TBSPGJPKaXrjsOpBQZPxJnrcfSfAA_1_t92F77A2C0897D802673079FA32163CACC9FD23DE* ___kfHAOgauRJPvjKmCDapJwwhskNfUA_1;
	// System.Double Rewired.Player/ControllerHelper/bvHtPvdVkbINqyMOEkvOVjYbgQSB`2/omlOoYqlQcXnMjOFbISaKckKLkeYA::ZKEjiiavxcSCZBaUErEBRrEjCVcc
	double ___ZKEjiiavxcSCZBaUErEBRrEjCVcc_2;
};

// Rewired.Data.UserData/PMmfElSRTHipvrooOqnrsVzyuehD/sQEkcZUofLSdEALOSOuyKPdNiQEDA`1<System.Object>
struct sQEkcZUofLSdEALOSOuyKPdNiQEDA_1_t1B5CB90AB9525321551E427D7C2054C85C37AAC1  : public RuntimeObject
{
	// ? Rewired.Data.UserData/PMmfElSRTHipvrooOqnrsVzyuehD/sQEkcZUofLSdEALOSOuyKPdNiQEDA`1::GiVZGuLQxvUOqeIVnTCviBpqPbb
	RuntimeObject* ___GiVZGuLQxvUOqeIVnTCviBpqPbb_0;
	// Rewired.Data.UserData/PMmfElSRTHipvrooOqnrsVzyuehD/aKSDPjRJZQzZwYkmoXKHoOMDFOWe`1<?> Rewired.Data.UserData/PMmfElSRTHipvrooOqnrsVzyuehD/sQEkcZUofLSdEALOSOuyKPdNiQEDA`1::GzKJJorOLWrdrMiTQiKLkIMQBqcb
	aKSDPjRJZQzZwYkmoXKHoOMDFOWe_1_tBF7584EF632A787EC6F2057BA1C49894E7E22FCA* ___GzKJJorOLWrdrMiTQiKLkIMQBqcb_1;
};

// UnityEngine.AndroidJavaObject
struct AndroidJavaObject_t8FFB930F335C1178405B82AC2BF512BB1EEF9EB0  : public RuntimeObject
{
	// UnityEngine.GlobalJavaObjectRef UnityEngine.AndroidJavaObject::m_jobject
	GlobalJavaObjectRef_t20D8E5AAFC2EB2518FCABBF40465855E797FF0D8* ___m_jobject_1;
	// UnityEngine.GlobalJavaObjectRef UnityEngine.AndroidJavaObject::m_jclass
	GlobalJavaObjectRef_t20D8E5AAFC2EB2518FCABBF40465855E797FF0D8* ___m_jclass_2;
};

struct AndroidJavaObject_t8FFB930F335C1178405B82AC2BF512BB1EEF9EB0_StaticFields
{
	// System.Boolean UnityEngine.AndroidJavaObject::enableDebugPrints
	bool ___enableDebugPrints_0;
};
struct Il2CppArrayBounds;

// Rewired.CalibrationMap
struct CalibrationMap_tB57C4727A9D4F4ED745A6E5D7E4398452D7A499B  : public RuntimeObject
{
	// Rewired.AxisCalibration[] Rewired.CalibrationMap::McmslNDLbMOdcVzrjNRENYEIkQeS
	AxisCalibrationU5BU5D_t5CE6CA59BC03BC961C6423B52B69520CDEF41078* ___McmslNDLbMOdcVzrjNRENYEIkQeS_0;
	// System.Collections.Generic.IList`1<Rewired.AxisCalibration> Rewired.CalibrationMap::sEIuIxFuhzTlUrJrUHnKqipeDsaw
	RuntimeObject* ___sEIuIxFuhzTlUrJrUHnKqipeDsaw_1;
	// System.Int32 Rewired.CalibrationMap::eNyGUiEiMyquCTKLRhFvpeyOvzMm
	int32_t ___eNyGUiEiMyquCTKLRhFvpeyOvzMm_2;
};

// Rewired.Utils.Classes.CodeHelper
struct CodeHelper_t3C7A463B1ACD337842945793AAAA8641F9832291  : public RuntimeObject
{
};

// UnityEngine.Experimental.Rendering.RenderGraphModule.IRenderGraphResource
struct IRenderGraphResource_tF24653A388C17849844C128C19C7A6599C7ADB7D  : public RuntimeObject
{
	// System.Boolean UnityEngine.Experimental.Rendering.RenderGraphModule.IRenderGraphResource::imported
	bool ___imported_0;
	// System.Boolean UnityEngine.Experimental.Rendering.RenderGraphModule.IRenderGraphResource::shared
	bool ___shared_1;
	// System.Boolean UnityEngine.Experimental.Rendering.RenderGraphModule.IRenderGraphResource::sharedExplicitRelease
	bool ___sharedExplicitRelease_2;
	// System.Boolean UnityEngine.Experimental.Rendering.RenderGraphModule.IRenderGraphResource::requestFallBack
	bool ___requestFallBack_3;
	// System.UInt32 UnityEngine.Experimental.Rendering.RenderGraphModule.IRenderGraphResource::writeCount
	uint32_t ___writeCount_4;
	// System.Int32 UnityEngine.Experimental.Rendering.RenderGraphModule.IRenderGraphResource::cachedHash
	int32_t ___cachedHash_5;
	// System.Int32 UnityEngine.Experimental.Rendering.RenderGraphModule.IRenderGraphResource::transientPassIndex
	int32_t ___transientPassIndex_6;
	// System.Int32 UnityEngine.Experimental.Rendering.RenderGraphModule.IRenderGraphResource::sharedResourceLastFrameUsed
	int32_t ___sharedResourceLastFrameUsed_7;
	// UnityEngine.Experimental.Rendering.RenderGraphModule.IRenderGraphResourcePool UnityEngine.Experimental.Rendering.RenderGraphModule.IRenderGraphResource::m_Pool
	IRenderGraphResourcePool_t8BF833F3C5D0BD8E45632CF923363EC782F4DDA8* ___m_Pool_8;
};

// UnityEngine.Experimental.Rendering.RenderGraphModule.IRenderGraphResourcePool
struct IRenderGraphResourcePool_t8BF833F3C5D0BD8E45632CF923363EC782F4DDA8  : public RuntimeObject
{
};

// Rewired.InputCategory
struct InputCategory_t9C22614C15FBDA3F98B6F03EA3CEB547BF5F373C  : public RuntimeObject
{
	// System.String Rewired.InputCategory::_name
	String_t* ____name_0;
	// System.String Rewired.InputCategory::_descriptiveName
	String_t* ____descriptiveName_1;
	// System.String Rewired.InputCategory::_tag
	String_t* ____tag_2;
	// System.Int32 Rewired.InputCategory::_id
	int32_t ____id_3;
	// System.Boolean Rewired.InputCategory::_userAssignable
	bool ____userAssignable_4;
};

// System.Reflection.MemberInfo
struct MemberInfo_t  : public RuntimeObject
{
};

// PjzdStrqNkNQSljwEZWJWYcQhjVQ
struct PjzdStrqNkNQSljwEZWJWYcQhjVQ_tA22AE52C8C2CD0639BCE85B3BE860B096AFBC1EA  : public RuntimeObject
{
	// Rewired.Utils.Classes.Data.AList`1<PjzdStrqNkNQSljwEZWJWYcQhjVQ/xcjUJvCGhYqGWwkvUdNHjHWxoqqC> PjzdStrqNkNQSljwEZWJWYcQhjVQ::COuyjsbFPUhFeclIbSWYbEYHvaeb
	AList_1_t383F862B062A593BE3A73799E560A8F64BA62D5D* ___COuyjsbFPUhFeclIbSWYbEYHvaeb_0;
	// System.Type[] PjzdStrqNkNQSljwEZWJWYcQhjVQ::bdjJIbYsPweNFOTzfMtaBmkyrWld
	TypeU5BU5D_t97234E1129B564EB38B8D85CAC2AD8B5B9522FFB* ___bdjJIbYsPweNFOTzfMtaBmkyrWld_1;
	// System.Type[] PjzdStrqNkNQSljwEZWJWYcQhjVQ::VhYVMbFXWtOOauVeJhXCkdxjaItG
	TypeU5BU5D_t97234E1129B564EB38B8D85CAC2AD8B5B9522FFB* ___VhYVMbFXWtOOauVeJhXCkdxjaItG_2;
	// System.Int32 PjzdStrqNkNQSljwEZWJWYcQhjVQ::rdLcmyGtIxnWMKVaSfsrOwFtFzjKA
	int32_t ___rdLcmyGtIxnWMKVaSfsrOwFtFzjKA_3;
};

// Rewired.Player
struct Player_t71A64CE695A2F96B144F3050755AB2799DA7C01B  : public RuntimeObject
{
	// TAqjagBhKGcWECRbpfkHPNKbpxLsA Rewired.Player::XBgnbkVKnfYNQCzukXyWfyzLvhPD
	TAqjagBhKGcWECRbpfkHPNKbpxLsA_t5B25C84F87417D98CA0E8452EAD0DB3A23D7833A* ___XBgnbkVKnfYNQCzukXyWfyzLvhPD_0;
	// System.Boolean Rewired.Player::xFAmFibjlPPtIetuKtQyyVEnZrzL
	bool ___xFAmFibjlPPtIetuKtQyyVEnZrzL_1;
	// System.Int32 Rewired.Player::uiBcvtaHTXDhDgTmVOTVLzAJdhvt
	int32_t ___uiBcvtaHTXDhDgTmVOTVLzAJdhvt_2;
	// System.String Rewired.Player::DwCxMCYkknMiaGQSTcpyYZtCOarV
	String_t* ___DwCxMCYkknMiaGQSTcpyYZtCOarV_3;
	// System.String Rewired.Player::ohwwxNPtAPIbMAPCQDTpbtvIdDVJA
	String_t* ___ohwwxNPtAPIbMAPCQDTpbtvIdDVJA_4;
	// System.Boolean Rewired.Player::OTBhvOBAvfjjLnHVYHNnRwRHPaGY
	bool ___OTBhvOBAvfjjLnHVYHNnRwRHPaGY_5;
	// System.Int32 Rewired.Player::eNyGUiEiMyquCTKLRhFvpeyOvzMm
	int32_t ___eNyGUiEiMyquCTKLRhFvpeyOvzMm_6;
	// Rewired.Player/ControllerHelper Rewired.Player::controllers
	ControllerHelper_tCE72EA23053BD0C6ECB4D75A69F8CD1B3AC28FF6* ___controllers_7;
};

// Rewired.Utils.SafeDelegate
struct SafeDelegate_t3A5CBC88139112F30FC47A9C9FEE81140913D328  : public RuntimeObject
{
};

struct SafeDelegate_t3A5CBC88139112F30FC47A9C9FEE81140913D328_StaticFields
{
	// System.Action`1<System.Exception> Rewired.Utils.SafeDelegate::JWAOfzcUPXpgdFWCpUudMhPyncab
	Action_1_tAFBD759E01ADE1CCF9C2015D5EFB3E69A9F26F04* ___JWAOfzcUPXpgdFWCpUudMhPyncab_0;
};

// System.String
struct String_t  : public RuntimeObject
{
	// System.Int32 System.String::_stringLength
	int32_t ____stringLength_4;
	// System.Char System.String::_firstChar
	Il2CppChar ____firstChar_5;
};

struct String_t_StaticFields
{
	// System.String System.String::Empty
	String_t* ___Empty_6;
};

// System.Text.StringBuilder
struct StringBuilder_t  : public RuntimeObject
{
	// System.Char[] System.Text.StringBuilder::m_ChunkChars
	CharU5BU5D_t799905CF001DD5F13F7DBB310181FC4D8B7D0AAB* ___m_ChunkChars_0;
	// System.Text.StringBuilder System.Text.StringBuilder::m_ChunkPrevious
	StringBuilder_t* ___m_ChunkPrevious_1;
	// System.Int32 System.Text.StringBuilder::m_ChunkLength
	int32_t ___m_ChunkLength_2;
	// System.Int32 System.Text.StringBuilder::m_ChunkOffset
	int32_t ___m_ChunkOffset_3;
	// System.Int32 System.Text.StringBuilder::m_MaxCapacity
	int32_t ___m_MaxCapacity_4;
};

// TAqjagBhKGcWECRbpfkHPNKbpxLsA
struct TAqjagBhKGcWECRbpfkHPNKbpxLsA_t5B25C84F87417D98CA0E8452EAD0DB3A23D7833A  : public RuntimeObject
{
	// System.Collections.Generic.List`1<Rewired.Joystick> TAqjagBhKGcWECRbpfkHPNKbpxLsA::qqfzpygyXcziWGCnMBWiDWbDfbjs
	List_1_t2531299A66B4BDB8CF994888D67AA13DA020D3FE* ___qqfzpygyXcziWGCnMBWiDWbDfbjs_0;
	// System.Collections.Generic.List`1<Rewired.Joystick> TAqjagBhKGcWECRbpfkHPNKbpxLsA::DjBvWLqAQEGGTyHDrPbxYhzUzucw
	List_1_t2531299A66B4BDB8CF994888D67AA13DA020D3FE* ___DjBvWLqAQEGGTyHDrPbxYhzUzucw_1;
	// System.Collections.Generic.List`1<Rewired.CustomController> TAqjagBhKGcWECRbpfkHPNKbpxLsA::LEEoyPfEWhMwPdeJbgkNcgtrkmIR
	List_1_tB8E529F7236AFA0FD8A80663AB3DD1A80617C2E1* ___LEEoyPfEWhMwPdeJbgkNcgtrkmIR_2;
	// System.Collections.Generic.List`1<Rewired.Controller> TAqjagBhKGcWECRbpfkHPNKbpxLsA::BThrGngvTsuQnMZbNMmizeDGSEMG
	List_1_t31024461DB8266F9EFEB0E1FB30FD6EACAAA348E* ___BThrGngvTsuQnMZbNMmizeDGSEMG_3;
	// System.Collections.ObjectModel.ReadOnlyCollection`1<Rewired.Controller> TAqjagBhKGcWECRbpfkHPNKbpxLsA::TLdjCyIaZGcguEERdSJGdFioRhbs
	ReadOnlyCollection_1_t5E285B024BFC4ECA3450993DB52CC4261597335C* ___TLdjCyIaZGcguEERdSJGdFioRhbs_4;
	// Rewired.Keyboard TAqjagBhKGcWECRbpfkHPNKbpxLsA::oCxdsWEkBdyfOWvttlOGoBEqVJhVA
	Keyboard_t3FD52938480ACCD23FDB0DAEC857F9A9D29CC6C3* ___oCxdsWEkBdyfOWvttlOGoBEqVJhVA_5;
	// Rewired.Mouse TAqjagBhKGcWECRbpfkHPNKbpxLsA::XozsQUktyqHZxmlRpydAHghEBLTv
	Mouse_t5C8D9CB89A5C0F4EE87A70501CAF2A68E36DC019* ___XozsQUktyqHZxmlRpydAHghEBLTv_6;
	// Rewired.Data.ConfigVars TAqjagBhKGcWECRbpfkHPNKbpxLsA::DydgGEtSDbDnUIdhpxLLNVJYuyYG
	ConfigVars_t4EC82ACF63376F1869FDC3D0E223EDCE149CF4A3* ___DydgGEtSDbDnUIdhpxLLNVJYuyYG_7;
	// slnZXWsjHVMgmJPfXBYLuaghszns[] TAqjagBhKGcWECRbpfkHPNKbpxLsA::YLPtzoRFStuEYusRAbMZYBSfiXSj
	slnZXWsjHVMgmJPfXBYLuaghsznsU5BU5D_tE4357525683913188793B16409204CE1841C9509* ___YLPtzoRFStuEYusRAbMZYBSfiXSj_8;
	// slnZXWsjHVMgmJPfXBYLuaghszns[] TAqjagBhKGcWECRbpfkHPNKbpxLsA::BURYjhhlAsEOrKtuMOueQZsrOkMA
	slnZXWsjHVMgmJPfXBYLuaghsznsU5BU5D_tE4357525683913188793B16409204CE1841C9509* ___BURYjhhlAsEOrKtuMOueQZsrOkMA_9;
	// slnZXWsjHVMgmJPfXBYLuaghszns[,] TAqjagBhKGcWECRbpfkHPNKbpxLsA::yMVcYkSmwYxIDbnLBPDHnoyoEqfDA
	slnZXWsjHVMgmJPfXBYLuaghsznsU5BU2CU5D_t0E2C0BE01220BC53ADE9E80AF7EC0BE6D677C75F* ___yMVcYkSmwYxIDbnLBPDHnoyoEqfDA_10;
	// mFLEqKpnGpgOhoDYUApNBKpxUruFA TAqjagBhKGcWECRbpfkHPNKbpxLsA::PvFXuNMjLGxoojOWFnDiLmGHfCjaA
	mFLEqKpnGpgOhoDYUApNBKpxUruFA_t3D2572948CEB7B57C2F37B59039EC83B1CB32408* ___PvFXuNMjLGxoojOWFnDiLmGHfCjaA_11;
	// YBzrFNvcnwYplEAweaZfKoEYnJzM TAqjagBhKGcWECRbpfkHPNKbpxLsA::oYFrXCFyNvlEVFeVWGPlBYGJJQJUA
	YBzrFNvcnwYplEAweaZfKoEYnJzM_t30C83160D593E4B3D56437AB7AE3D2507C9AC52E* ___oYFrXCFyNvlEVFeVWGPlBYGJJQJUA_12;
	// YBzrFNvcnwYplEAweaZfKoEYnJzM[] TAqjagBhKGcWECRbpfkHPNKbpxLsA::bRLCbTxpuwcIXisuuGfDXGIBKEOpA
	YBzrFNvcnwYplEAweaZfKoEYnJzMU5BU5D_tFB4689A16323F9FDCBE75ACBD8F2CADD680D9256* ___bRLCbTxpuwcIXisuuGfDXGIBKEOpA_13;
	// inUVqCQsuvBJxHwomlAniLxWfZitA`1<Rewired.ActiveControllerChangedDelegate> TAqjagBhKGcWECRbpfkHPNKbpxLsA::XgSBlEiCxinzSMBCAbctflSvuyyC
	inUVqCQsuvBJxHwomlAniLxWfZitA_1_t67BD3968E2211A2E09B85A6376936EA713E90E04* ___XgSBlEiCxinzSMBCAbctflSvuyyC_14;
	// inUVqCQsuvBJxHwomlAniLxWfZitA`1<Rewired.PlayerActiveControllerChangedDelegate> TAqjagBhKGcWECRbpfkHPNKbpxLsA::PZpUuTNIzyjsFUzwOMTmNKvYieYL
	inUVqCQsuvBJxHwomlAniLxWfZitA_1_tD7B16D6D1359CB7B06E2A472A7687A5F7B51DE44* ___PZpUuTNIzyjsFUzwOMTmNKvYieYL_15;
	// inUVqCQsuvBJxHwomlAniLxWfZitA`1<Rewired.PlayerActiveControllerChangedDelegate>[] TAqjagBhKGcWECRbpfkHPNKbpxLsA::BwLIsvbRTdbatTumKRnLlIWPMROU
	inUVqCQsuvBJxHwomlAniLxWfZitA_1U5BU5D_tA661DCC17BBBCCABDACE0F73A4D969A777E291EB* ___BwLIsvbRTdbatTumKRnLlIWPMROU_16;
	// Rewired.Utils.Classes.Data.ADictionary`2<System.Int32,TAqjagBhKGcWECRbpfkHPNKbpxLsA/rjYIYGThyzcIjjKJcsAtqiSHJmxp> TAqjagBhKGcWECRbpfkHPNKbpxLsA::ZdrIflEMNwQABYDEMjZlBRcLDVbb
	ADictionary_2_tE7D442DC62B8CFFF9D86A864353481277AAAE32F* ___ZdrIflEMNwQABYDEMjZlBRcLDVbb_17;
	// PjzdStrqNkNQSljwEZWJWYcQhjVQ TAqjagBhKGcWECRbpfkHPNKbpxLsA::WejqIIyLtJZYzZEyxGBqHOkJzsOl
	PjzdStrqNkNQSljwEZWJWYcQhjVQ_tA22AE52C8C2CD0639BCE85B3BE860B096AFBC1EA* ___WejqIIyLtJZYzZEyxGBqHOkJzsOl_18;
	// System.Collections.Generic.IList`1<Rewired.Joystick> TAqjagBhKGcWECRbpfkHPNKbpxLsA::qonPrzzlQyCfQZjPadYQeZcFFpcdb
	RuntimeObject* ___qonPrzzlQyCfQZjPadYQeZcFFpcdb_19;
	// System.Collections.Generic.IList`1<Rewired.CustomController> TAqjagBhKGcWECRbpfkHPNKbpxLsA::ozrwhehVkuTKkRNLqEdddoCxNMUA
	RuntimeObject* ___ozrwhehVkuTKkRNLqEdddoCxNMUA_20;
	// System.Int32 TAqjagBhKGcWECRbpfkHPNKbpxLsA::JJxqZRLuIOYMOCvSqtKjmlipBZG
	int32_t ___JJxqZRLuIOYMOCvSqtKjmlipBZG_21;
	// System.Boolean TAqjagBhKGcWECRbpfkHPNKbpxLsA::QIMbUjJuNimHQcUsfEpTQyHCgvpj
	bool ___QIMbUjJuNimHQcUsfEpTQyHCgvpj_22;
	// System.Boolean TAqjagBhKGcWECRbpfkHPNKbpxLsA::NdysVuEdWQOiFxbhpptWfUiFhFrr
	bool ___NdysVuEdWQOiFxbhpptWfUiFhFrr_23;
	// System.Boolean TAqjagBhKGcWECRbpfkHPNKbpxLsA::RfchLPcQpuACPERHbVpKmqvQbJMFc
	bool ___RfchLPcQpuACPERHbVpKmqvQbJMFc_24;
	// Rewired.Interfaces.IUnifiedKeyboardSource TAqjagBhKGcWECRbpfkHPNKbpxLsA::NGcfyiSARdAtydVWxwKMqywJrUQgA
	RuntimeObject* ___NGcfyiSARdAtydVWxwKMqywJrUQgA_25;
	// Rewired.Interfaces.IUnifiedMouseSource TAqjagBhKGcWECRbpfkHPNKbpxLsA::yMFwNKJAcxFswEbtqielmoztQPuj
	RuntimeObject* ___yMFwNKJAcxFswEbtqielmoztQPuj_26;
	// System.Int32 TAqjagBhKGcWECRbpfkHPNKbpxLsA::gjdKUqvyEFuFPgBvHvnHncERRqYG
	int32_t ___gjdKUqvyEFuFPgBvHvnHncERRqYG_27;
	// JfVkiPqxuvjpxOenWaPbtdnpqNrC TAqjagBhKGcWECRbpfkHPNKbpxLsA::ksfehWcJeyrOvFtcfltlJWjYBpUz
	JfVkiPqxuvjpxOenWaPbtdnpqNrC_tAD3EC599BD987C8364327BCCAE0346D20C00C8F9* ___ksfehWcJeyrOvFtcfltlJWjYBpUz_28;
	// rlfXkJTrHZdpPrmFzvJfeOpwdxFF TAqjagBhKGcWECRbpfkHPNKbpxLsA::RzBxphZmIoCHLXRoGvldiqxCEgwD
	rlfXkJTrHZdpPrmFzvJfeOpwdxFF_t92D577FF2385AF1C7F87003759294BE9754F3ABD* ___RzBxphZmIoCHLXRoGvldiqxCEgwD_29;
	// System.Int32 TAqjagBhKGcWECRbpfkHPNKbpxLsA::kfNkXwBPjzNbdZoVdVblYDAfNwDM
	int32_t ___kfNkXwBPjzNbdZoVdVblYDAfNwDM_30;
	// System.Int32 TAqjagBhKGcWECRbpfkHPNKbpxLsA::ODQiuEhoXylGZrTvnPdXExxhVXCr
	int32_t ___ODQiuEhoXylGZrTvnPdXExxhVXCr_31;
	// System.Action`2<System.Int32,Rewired.ControllerDataUpdater> TAqjagBhKGcWECRbpfkHPNKbpxLsA::TOZZfnPOyHUABuClbaMHZMspAdZt
	Action_2_t13979AF1641790E4111291C572345E665DD175C4* ___TOZZfnPOyHUABuClbaMHZMspAdZt_32;
	// System.Action`3<System.Boolean,System.Int32,System.Int32> TAqjagBhKGcWECRbpfkHPNKbpxLsA::PLZcozGwIYTsVcDDbsYfohEICBuxA
	Action_3_t142D1F73AF66CEBC85F52240EC1B6207B558A40B* ___PLZcozGwIYTsVcDDbsYfohEICBuxA_33;
	// System.Action`1<Rewired.ControllerStatusChangedEventArgs> TAqjagBhKGcWECRbpfkHPNKbpxLsA::IXMtFFcrfEIDzdudanjuhjPDjfuAB
	Action_1_tBAD7548A2A88259FFDD9D2AF491DA79E19CB5D95* ___IXMtFFcrfEIDzdudanjuhjPDjfuAB_34;
	// System.Action`2<Rewired.ControllerType,System.Int32> TAqjagBhKGcWECRbpfkHPNKbpxLsA::JUgvSEmmHKeWXSBgsgJjuCpArCTi
	Action_2_t803BE0EB18DDC66CA042F1CCF405EFB2D468146D* ___JUgvSEmmHKeWXSBgsgJjuCpArCTi_35;
	// System.Boolean TAqjagBhKGcWECRbpfkHPNKbpxLsA::smLxyjQFlClJKIZlhLSifPFFImqe
	bool ___smLxyjQFlClJKIZlhLSifPFFImqe_36;
};

// System.ValueType
struct ValueType_t6D9B272BD21782F0A9A14F2E41F85A50E97A986F  : public RuntimeObject
{
};
// Native definition for P/Invoke marshalling of System.ValueType
struct ValueType_t6D9B272BD21782F0A9A14F2E41F85A50E97A986F_marshaled_pinvoke
{
};
// Native definition for COM marshalling of System.ValueType
struct ValueType_t6D9B272BD21782F0A9A14F2E41F85A50E97A986F_marshaled_com
{
};

// UnityEngine._AndroidJNIHelper
struct _AndroidJNIHelper_tA796944DDB1B1459DF68C9FFA518F452C81364F3  : public RuntimeObject
{
};

// gRfTGJhxieuOzGUxjqzzxNNmLUuF
struct gRfTGJhxieuOzGUxjqzzxNNmLUuF_t7BBB41BAB66EDE0363D72C224F9B9ABD3F60154A  : public RuntimeObject
{
	// System.Int32 gRfTGJhxieuOzGUxjqzzxNNmLUuF::IbDAAQayZlvTFeAWaKRWpsHubZQo
	int32_t ___IbDAAQayZlvTFeAWaKRWpsHubZQo_0;
	// System.Byte[] gRfTGJhxieuOzGUxjqzzxNNmLUuF::VmWtSTvLARmhSSbKAWvXCQEJhSPE
	ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* ___VmWtSTvLARmhSSbKAWvXCQEJhSPE_1;
};

// mHznkohyUIHlEQXbyTCVDNERgIMS
struct mHznkohyUIHlEQXbyTCVDNERgIMS_t668F235E2813D409F7B224884E65242B8EF4C466  : public RuntimeObject
{
	// System.EventHandler`1<System.EventArgs> mHznkohyUIHlEQXbyTCVDNERgIMS::uLQYDQGRgZMwpxpZdszHrghfSrOH
	EventHandler_1_tF2D41B212D800E7E7D00F9BDEA817E57153988BF* ___uLQYDQGRgZMwpxpZdszHrghfSrOH_0;
	// System.EventHandler`1<System.EventArgs> mHznkohyUIHlEQXbyTCVDNERgIMS::LsiCjIzxcoUWVLLcbqUXijbxKvkH
	EventHandler_1_tF2D41B212D800E7E7D00F9BDEA817E57153988BF* ___LsiCjIzxcoUWVLLcbqUXijbxKvkH_1;
	// System.Boolean mHznkohyUIHlEQXbyTCVDNERgIMS::YqniazdmQvFMLfZmGCtADkednJgZA
	bool ___YqniazdmQvFMLfZmGCtADkednJgZA_2;
};

// uhuWHhUlIbNFBnRrnehXuaQSuHHd
struct uhuWHhUlIbNFBnRrnehXuaQSuHHd_t4AB1460AEA454ED4395C40922F48B6E79D4307F0  : public RuntimeObject
{
};

// Rewired.Controller/Extension
struct Extension_t65CC6FDD7104DC3F9E55C8238302E9F8870162F9  : public RuntimeObject
{
	// Rewired.Controller Rewired.Controller/Extension::ANMamGTTJSCnGKAQdqGuVYErIycq
	Controller_t919A4A50FC7A0F25D7B31615C0F4E4D4A4D17911* ___ANMamGTTJSCnGKAQdqGuVYErIycq_0;
	// Rewired.Interfaces.IControllerExtensionSource Rewired.Controller/Extension::SlnFGwrpDzXmNqPJLRibJOYdFyFCA
	RuntimeObject* ___SlnFGwrpDzXmNqPJLRibJOYdFyFCA_1;
	// System.Int32 Rewired.Controller/Extension::_reInputId
	int32_t ____reInputId_2;
};

// Rewired.Data.Mapping.HardwareJoystickTemplateMap/SpecialElementEntry
struct SpecialElementEntry_tC2A8F6C0EE9400318EA49260467DD0826D93AE8A  : public RuntimeObject
{
	// System.Int32 Rewired.Data.Mapping.HardwareJoystickTemplateMap/SpecialElementEntry::elementIdentifierId
	int32_t ___elementIdentifierId_0;
	// System.String Rewired.Data.Mapping.HardwareJoystickTemplateMap/SpecialElementEntry::data
	String_t* ___data_1;
};

// PjzdStrqNkNQSljwEZWJWYcQhjVQ/xcjUJvCGhYqGWwkvUdNHjHWxoqqC
struct xcjUJvCGhYqGWwkvUdNHjHWxoqqC_t543EB71E658F90965142EBA611491F052277C6B0  : public RuntimeObject
{
	// Rewired.Utils.Classes.Data.AList`1<Rewired.IControllerTemplate> PjzdStrqNkNQSljwEZWJWYcQhjVQ/xcjUJvCGhYqGWwkvUdNHjHWxoqqC::VNRjhxdkwzCQsQLRYBpUhOzPIPLcA
	AList_1_t6F028F71F04E9F8A363286413FD2E2C6C409F5B5* ___VNRjhxdkwzCQsQLRYBpUhOzPIPLcA_0;
	// System.Collections.IList PjzdStrqNkNQSljwEZWJWYcQhjVQ/xcjUJvCGhYqGWwkvUdNHjHWxoqqC::tHZEPnFmTQxkjsGpSgVDknUtcVHe
	RuntimeObject* ___tHZEPnFmTQxkjsGpSgVDknUtcVHe_1;
	// System.Collections.IList PjzdStrqNkNQSljwEZWJWYcQhjVQ/xcjUJvCGhYqGWwkvUdNHjHWxoqqC::OvLFleCEdoySEQcjTcyPRQmtFORLA
	RuntimeObject* ___OvLFleCEdoySEQcjTcyPRQmtFORLA_2;
	// System.Type PjzdStrqNkNQSljwEZWJWYcQhjVQ/xcjUJvCGhYqGWwkvUdNHjHWxoqqC::YBBiFPVEundStWYFZfcbQzhQlFi
	Type_t* ___YBBiFPVEundStWYFZfcbQzhQlFi_3;
};

// Rewired.Player/ControllerHelper
struct ControllerHelper_tCE72EA23053BD0C6ECB4D75A69F8CD1B3AC28FF6  : public RuntimeObject
{
	// Rewired.Player/ControllerHelper/vpfVMfLDNQCKabtrXuyMMndafvvoA Rewired.Player/ControllerHelper::rGIwSbUPDgDDJByCitUBBGoZDlmc
	vpfVMfLDNQCKabtrXuyMMndafvvoA_t24DAE63535EED93A1490AC97901F2551704D116D* ___rGIwSbUPDgDDJByCitUBBGoZDlmc_0;
	// System.Boolean Rewired.Player/ControllerHelper::AGJkYNtGyvZWiyWIaEfTgcpraKBu
	bool ___AGJkYNtGyvZWiyWIaEfTgcpraKBu_1;
	// System.Boolean Rewired.Player/ControllerHelper::dBLcgVfbQAfhgyHLKVtzegFukmFdb
	bool ___dBLcgVfbQAfhgyHLKVtzegFukmFdb_2;
	// System.Boolean Rewired.Player/ControllerHelper::SmMsiOyklhhkMunjfUeDHALkJxFH
	bool ___SmMsiOyklhhkMunjfUeDHALkJxFH_3;
	// System.Double Rewired.Player/ControllerHelper::ogITdZRpeUFIHfycNToWBHNVRMBNA
	double ___ogITdZRpeUFIHfycNToWBHNVRMBNA_4;
	// System.Double Rewired.Player/ControllerHelper::keifNvKNuhLdvhEdIgfcfYKcLHrn
	double ___keifNvKNuhLdvhEdIgfcfYKcLHrn_5;
	// Rewired.Utils.SafeAction`1<Rewired.ControllerAssignmentChangedEventArgs> Rewired.Player/ControllerHelper::sqNsZAxhlgJVOZsPerBubEQPQpZk
	SafeAction_1_t187B602724412D6E71212275DB504DB2CA537DC0* ___sqNsZAxhlgJVOZsPerBubEQPQpZk_6;
	// Rewired.Utils.SafeAction`1<Rewired.ControllerAssignmentChangedEventArgs> Rewired.Player/ControllerHelper::jhdhfFJWcGqnhlNODKtzbmDJktuBc
	SafeAction_1_t187B602724412D6E71212275DB504DB2CA537DC0* ___jhdhfFJWcGqnhlNODKtzbmDJktuBc_7;
	// Rewired.Player/ControllerHelper/eSDNQUnYcyDvQHrqJricxoWzTLr Rewired.Player/ControllerHelper::AeznZlVnkMKpUcCjeVGMsPEvETFp
	eSDNQUnYcyDvQHrqJricxoWzTLr_t52BD0C4EC6573AD81BF763D7FADDE36ECEB3DA34* ___AeznZlVnkMKpUcCjeVGMsPEvETFp_8;
	// Rewired.Player Rewired.Player/ControllerHelper::vLioXoePkQiNEWuOkALOfFKNbaiU
	Player_t71A64CE695A2F96B144F3050755AB2799DA7C01B* ___vLioXoePkQiNEWuOkALOfFKNbaiU_9;
	// PjzdStrqNkNQSljwEZWJWYcQhjVQ Rewired.Player/ControllerHelper::WejqIIyLtJZYzZEyxGBqHOkJzsOl
	PjzdStrqNkNQSljwEZWJWYcQhjVQ_tA22AE52C8C2CD0639BCE85B3BE860B096AFBC1EA* ___WejqIIyLtJZYzZEyxGBqHOkJzsOl_10;
	// System.Int32 Rewired.Player/ControllerHelper::eNyGUiEiMyquCTKLRhFvpeyOvzMm
	int32_t ___eNyGUiEiMyquCTKLRhFvpeyOvzMm_11;
	// Rewired.Player/ControllerHelper/MapHelper Rewired.Player/ControllerHelper::maps
	MapHelper_t214BA4F045E5EB4B312E4E6AEB6697813117A7C2* ___maps_12;
	// Rewired.Player/ControllerHelper/ConflictCheckingHelper Rewired.Player/ControllerHelper::conflictChecking
	ConflictCheckingHelper_t8D707CEC57F056B87A4C68F98F780D34E893A8DB* ___conflictChecking_13;
	// Rewired.Player/ControllerHelper/PollingHelper Rewired.Player/ControllerHelper::polling
	PollingHelper_tB0445EF1EE1230F3EE703F3A0F09DEE0A64D8B97* ___polling_14;
};

// Rewired.PlayerController/Element
struct Element_t26F7003E01AAF28091E75E0A3552C2C3EEA38F06  : public RuntimeObject
{
	// Rewired.PlayerController Rewired.PlayerController/Element::QRBDQxcwDPURDgAFQEKzoUwAfmRw
	PlayerController_t5C57BA5C122B079D29B773FDCB7DE6C13E7B8ED2* ___QRBDQxcwDPURDgAFQEKzoUwAfmRw_1;
	// System.Boolean Rewired.PlayerController/Element::hhYflMFVAbCGZEPgduJefwSerZirC
	bool ___hhYflMFVAbCGZEPgduJefwSerZirC_2;
	// System.Boolean Rewired.PlayerController/Element::ITUIszRiaNrsImOTfgAHSPwPTOLe
	bool ___ITUIszRiaNrsImOTfgAHSPwPTOLe_3;
	// System.String Rewired.PlayerController/Element::DwCxMCYkknMiaGQSTcpyYZtCOarV
	String_t* ___DwCxMCYkknMiaGQSTcpyYZtCOarV_4;
};

struct Element_t26F7003E01AAF28091E75E0A3552C2C3EEA38F06_StaticFields
{
	// System.Int32[] Rewired.PlayerController/Element::EvkiyzpPoBmvAljCTksuUBVNdidz
	Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* ___EvkiyzpPoBmvAljCTksuUBVNdidz_5;
	// System.Int32[] Rewired.PlayerController/Element::KAqIDCAxKUfNlpGYgVkeeeSvwpWq
	Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* ___KAqIDCAxKUfNlpGYgVkeeeSvwpWq_6;
};

// UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphResourceRegistry/RenderGraphResourcesData
struct RenderGraphResourcesData_tB2FF97B16A3E1DE700283778679C5CC0C39F4CFE  : public RuntimeObject
{
	// UnityEngine.Rendering.DynamicArray`1<UnityEngine.Experimental.Rendering.RenderGraphModule.IRenderGraphResource> UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphResourceRegistry/RenderGraphResourcesData::resourceArray
	DynamicArray_1_t401F46C0081DE185BCAB1D30DE8D6B6DC9AA6AFB* ___resourceArray_0;
	// System.Int32 UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphResourceRegistry/RenderGraphResourcesData::sharedResourcesCount
	int32_t ___sharedResourcesCount_1;
	// UnityEngine.Experimental.Rendering.RenderGraphModule.IRenderGraphResourcePool UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphResourceRegistry/RenderGraphResourcesData::pool
	IRenderGraphResourcePool_t8BF833F3C5D0BD8E45632CF923363EC782F4DDA8* ___pool_2;
	// UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphResourceRegistry/ResourceCallback UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphResourceRegistry/RenderGraphResourcesData::createResourceCallback
	ResourceCallback_t45358BA8AC82EF742271B868C50331854DD58EEC* ___createResourceCallback_3;
	// UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphResourceRegistry/ResourceCallback UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphResourceRegistry/RenderGraphResourcesData::releaseResourceCallback
	ResourceCallback_t45358BA8AC82EF742271B868C50331854DD58EEC* ___releaseResourceCallback_4;
};

// Rewired.Utils.TempListPool/TpeBEFhFAWNAsvKKQTVtIrdFUsQw
struct TpeBEFhFAWNAsvKKQTVtIrdFUsQw_t5D5197E218132B1DD4BC8E742573E7D86100D91D  : public RuntimeObject
{
};

struct TpeBEFhFAWNAsvKKQTVtIrdFUsQw_t5D5197E218132B1DD4BC8E742573E7D86100D91D_StaticFields
{
	// Rewired.Utils.Classes.Data.ADictionary`2<System.Type,System.Collections.Generic.List`1<System.Object>> Rewired.Utils.TempListPool/TpeBEFhFAWNAsvKKQTVtIrdFUsQw::PEWuzoCeZDwOZQKsEAnWARJjQZog
	ADictionary_2_tE212D15054E58919DA98BE219858633B9BBE9C90* ___PEWuzoCeZDwOZQKsEAnWARJjQZog_0;
};

// Rewired.UnknownControllerHat/HatButtons
struct HatButtons_tCE5F7476A54D0F5DF7FA0EB11FF2C753B51DDE03  : public RuntimeObject
{
	// System.Int32[] Rewired.UnknownControllerHat/HatButtons::BafFoZhnxVpChaocfBnHutnFhZEhb
	Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* ___BafFoZhnxVpChaocfBnHutnFhZEhb_0;
};

// Rewired.Data.UserData/PMmfElSRTHipvrooOqnrsVzyuehD
struct PMmfElSRTHipvrooOqnrsVzyuehD_t8D1CC18A34C4BA6516D092C1F3A22C72108C3572  : public RuntimeObject
{
};

// Rewired.Controller/CompoundElement/kfzfjnagLVVtsyAzdAlUhZdNuSIQA
struct kfzfjnagLVVtsyAzdAlUhZdNuSIQA_tCE87DA4E243A151D523511BE81757930A8E88FBE  : public RuntimeObject
{
	// Rewired.Controller/Element Rewired.Controller/CompoundElement/kfzfjnagLVVtsyAzdAlUhZdNuSIQA::yKCXOltRimSKhLFgTEKGJTpBiWpb
	Element_t58CB6D4FDC2FDD69AC192D19F0F9531FE3F01F76* ___yKCXOltRimSKhLFgTEKGJTpBiWpb_0;
	// System.Int32 Rewired.Controller/CompoundElement/kfzfjnagLVVtsyAzdAlUhZdNuSIQA::PfGQtAPPZODaxbJRsuZqkEEwnCcW
	int32_t ___PfGQtAPPZODaxbJRsuZqkEEwnCcW_1;
};

// Rewired.Player/ControllerHelper/vpfVMfLDNQCKabtrXuyMMndafvvoA
struct vpfVMfLDNQCKabtrXuyMMndafvvoA_t24DAE63535EED93A1490AC97901F2551704D116D  : public RuntimeObject
{
	// System.Int32 Rewired.Player/ControllerHelper/vpfVMfLDNQCKabtrXuyMMndafvvoA::TIKqvTvXeujXUEcFBSnvvfWjpzmS
	int32_t ___TIKqvTvXeujXUEcFBSnvvfWjpzmS_0;
	// Rewired.ControllerType[] Rewired.Player/ControllerHelper/vpfVMfLDNQCKabtrXuyMMndafvvoA::hyffvgHsrKHoGLqtewSlwLJnerIhA
	ControllerTypeU5BU5D_t24957BC60A9ED2806B85EDE1E8A60341D1871FD2* ___hyffvgHsrKHoGLqtewSlwLJnerIhA_1;
	// Rewired.Player/ControllerHelper/ftuHLSCvHbrPYKqmDICMGujVuqLSA[] Rewired.Player/ControllerHelper/vpfVMfLDNQCKabtrXuyMMndafvvoA::WEmxnsiwKrpkpHxSSWWBddalKCmP
	ftuHLSCvHbrPYKqmDICMGujVuqLSAU5BU5D_t1A5828768AE703001918C5473AA9B00044C7C36E* ___WEmxnsiwKrpkpHxSSWWBddalKCmP_2;
};

// Rewired.Data.UserData/PMmfElSRTHipvrooOqnrsVzyuehD/kzedFdEdISaCJppRVzkSmhYBfiDK
struct kzedFdEdISaCJppRVzkSmhYBfiDK_t96C908773E13D2FD31BFC3C0BC59CD2D7B31233D  : public RuntimeObject
{
	// System.Int32 Rewired.Data.UserData/PMmfElSRTHipvrooOqnrsVzyuehD/kzedFdEdISaCJppRVzkSmhYBfiDK::AcClZBPdNNZKrqgRPVbnRKTztFVA
	int32_t ___AcClZBPdNNZKrqgRPVbnRKTztFVA_0;
	// System.Int32 Rewired.Data.UserData/PMmfElSRTHipvrooOqnrsVzyuehD/kzedFdEdISaCJppRVzkSmhYBfiDK::CCzhRDaUDvMVJJyCTKXgJlMZxTznA
	int32_t ___CCzhRDaUDvMVJJyCTKXgJlMZxTznA_1;
	// System.Int32 Rewired.Data.UserData/PMmfElSRTHipvrooOqnrsVzyuehD/kzedFdEdISaCJppRVzkSmhYBfiDK::nUqCRtBiQRTUXOfhCEaNuUGaHEsB
	int32_t ___nUqCRtBiQRTUXOfhCEaNuUGaHEsB_2;
};

// UnityEngine.InputSystem.Utilities.InlinedArray`1<System.Action`1<System.Object>>
struct InlinedArray_1_t90D679876AE3A52129F69F403ECC9AD16D60AD9F 
{
	// System.Int32 UnityEngine.InputSystem.Utilities.InlinedArray`1::length
	int32_t ___length_0;
	// TValue UnityEngine.InputSystem.Utilities.InlinedArray`1::firstValue
	Action_1_t6F9EB113EB3F16226AEF811A2744F4111C116C87* ___firstValue_1;
	// TValue[] UnityEngine.InputSystem.Utilities.InlinedArray`1::additionalValues
	Action_1U5BU5D_t9AF7A60AA589F7071315F3DA2F77CD32CB43FB5D* ___additionalValues_2;
};

// UnityEngine.InputSystem.Utilities.InlinedArray`1<System.Action`2<System.Object,UnityEngine.InputSystem.InputActionChange>>
struct InlinedArray_1_tF80F63393E0BF97AFE20E770FC71798135300300 
{
	// System.Int32 UnityEngine.InputSystem.Utilities.InlinedArray`1::length
	int32_t ___length_0;
	// TValue UnityEngine.InputSystem.Utilities.InlinedArray`1::firstValue
	Action_2_t4D6C6A84A6B44BE6193A1F64753F6E48558FBE9D* ___firstValue_1;
	// TValue[] UnityEngine.InputSystem.Utilities.InlinedArray`1::additionalValues
	Action_2U5BU5D_tE313524623BEAF7FD2ABCEDAD1C5A2C556630373* ___additionalValues_2;
};

// System.Nullable`1<System.Boolean>
struct Nullable_1_t78F453FADB4A9F50F267A4E349019C34410D1A01 
{
	// System.Boolean System.Nullable`1::hasValue
	bool ___hasValue_0;
	// T System.Nullable`1::value
	bool ___value_1;
};

// Rewired.Utils.SafeDelegate`1<System.Action`1<System.Object>>
struct SafeDelegate_1_t28BA538478CD717887608073323B0FC410BAC20F  : public SafeDelegate_t3A5CBC88139112F30FC47A9C9FEE81140913D328
{
	// System.Action`1<System.Exception> Rewired.Utils.SafeDelegate`1::sFaPErGwpFCvnlFjeEdmwUtVVnFl
	Action_1_tAFBD759E01ADE1CCF9C2015D5EFB3E69A9F26F04* ___sFaPErGwpFCvnlFjeEdmwUtVVnFl_1;
	// System.Collections.Generic.List`1<Rewired.Utils.SafeDelegate`1/vipcXwCBbnoOEzCTVzWmvEUaMZdT<T>> Rewired.Utils.SafeDelegate`1::OPmkvHeVExLsgVEjFuLBLBUTIxdJ
	List_1_t1EF3D12D770B73CCE7B65120BB0552C82B21D3DF* ___OPmkvHeVExLsgVEjFuLBLBUTIxdJ_2;
	// System.Collections.Generic.List`1<Rewired.Utils.SafeDelegate`1/vipcXwCBbnoOEzCTVzWmvEUaMZdT<T>> Rewired.Utils.SafeDelegate`1::DFhFtniQcYWgbkaAjQexjnZIxBlZ
	List_1_t1EF3D12D770B73CCE7B65120BB0552C82B21D3DF* ___DFhFtniQcYWgbkaAjQexjnZIxBlZ_3;
};

// System.Boolean
struct Boolean_t09A6377A54BE2F9E6985A8149F19234FD7DDFE22 
{
	// System.Boolean System.Boolean::m_value
	bool ___m_value_0;
};

struct Boolean_t09A6377A54BE2F9E6985A8149F19234FD7DDFE22_StaticFields
{
	// System.String System.Boolean::TrueString
	String_t* ___TrueString_5;
	// System.String System.Boolean::FalseString
	String_t* ___FalseString_6;
};

// System.Byte
struct Byte_t94D9231AC217BE4D2E004C4CD32DF6D099EA41A3 
{
	// System.Byte System.Byte::m_value
	uint8_t ___m_value_0;
};

// System.Char
struct Char_t521A6F19B456D956AF452D926C32709DC03D6B17 
{
	// System.Char System.Char::m_value
	Il2CppChar ___m_value_0;
};

struct Char_t521A6F19B456D956AF452D926C32709DC03D6B17_StaticFields
{
	// System.Byte[] System.Char::s_categoryForLatin1
	ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* ___s_categoryForLatin1_3;
};

// System.Double
struct Double_tE150EF3D1D43DEE85D533810AB4C742307EEDE5F 
{
	// System.Double System.Double::m_value
	double ___m_value_0;
};

// System.Enum
struct Enum_t2A1A94B24E3B776EEF4E5E485E290BB9D4D072E2  : public ValueType_t6D9B272BD21782F0A9A14F2E41F85A50E97A986F
{
};

struct Enum_t2A1A94B24E3B776EEF4E5E485E290BB9D4D072E2_StaticFields
{
	// System.Char[] System.Enum::enumSeperatorCharArray
	CharU5BU5D_t799905CF001DD5F13F7DBB310181FC4D8B7D0AAB* ___enumSeperatorCharArray_0;
};
// Native definition for P/Invoke marshalling of System.Enum
struct Enum_t2A1A94B24E3B776EEF4E5E485E290BB9D4D072E2_marshaled_pinvoke
{
};
// Native definition for COM marshalling of System.Enum
struct Enum_t2A1A94B24E3B776EEF4E5E485E290BB9D4D072E2_marshaled_com
{
};

// UnityEngine.InputSystem.Utilities.FourCC
struct FourCC_tA6CAA4015BC25A7F1053B6C512202D57A9C994ED 
{
	// System.Int32 UnityEngine.InputSystem.Utilities.FourCC::m_Code
	int32_t ___m_Code_0;
};

// System.Guid
struct Guid_t 
{
	// System.Int32 System.Guid::_a
	int32_t ____a_1;
	// System.Int16 System.Guid::_b
	int16_t ____b_2;
	// System.Int16 System.Guid::_c
	int16_t ____c_3;
	// System.Byte System.Guid::_d
	uint8_t ____d_4;
	// System.Byte System.Guid::_e
	uint8_t ____e_5;
	// System.Byte System.Guid::_f
	uint8_t ____f_6;
	// System.Byte System.Guid::_g
	uint8_t ____g_7;
	// System.Byte System.Guid::_h
	uint8_t ____h_8;
	// System.Byte System.Guid::_i
	uint8_t ____i_9;
	// System.Byte System.Guid::_j
	uint8_t ____j_10;
	// System.Byte System.Guid::_k
	uint8_t ____k_11;
};

struct Guid_t_StaticFields
{
	// System.Guid System.Guid::Empty
	Guid_t ___Empty_0;
};

// UnityEngine.InputSystem.InputControlScheme
struct InputControlScheme_tB60FB32F414727140B32E1A0447679DC7ABC8434 
{
	// System.String UnityEngine.InputSystem.InputControlScheme::m_Name
	String_t* ___m_Name_0;
	// System.String UnityEngine.InputSystem.InputControlScheme::m_BindingGroup
	String_t* ___m_BindingGroup_1;
	// UnityEngine.InputSystem.InputControlScheme/DeviceRequirement[] UnityEngine.InputSystem.InputControlScheme::m_DeviceRequirements
	DeviceRequirementU5BU5D_t0496FAAB7554B7BFC270BA53BA6A5EFD5DE061CE* ___m_DeviceRequirements_2;
};
// Native definition for P/Invoke marshalling of UnityEngine.InputSystem.InputControlScheme
struct InputControlScheme_tB60FB32F414727140B32E1A0447679DC7ABC8434_marshaled_pinvoke
{
	char* ___m_Name_0;
	char* ___m_BindingGroup_1;
	DeviceRequirement_t80E71C44DF1923C15D3AA025242B7348EBF8B056_marshaled_pinvoke* ___m_DeviceRequirements_2;
};
// Native definition for COM marshalling of UnityEngine.InputSystem.InputControlScheme
struct InputControlScheme_tB60FB32F414727140B32E1A0447679DC7ABC8434_marshaled_com
{
	Il2CppChar* ___m_Name_0;
	Il2CppChar* ___m_BindingGroup_1;
	DeviceRequirement_t80E71C44DF1923C15D3AA025242B7348EBF8B056_marshaled_com* ___m_DeviceRequirements_2;
};

// Rewired.InputMapCategory
struct InputMapCategory_t309A7C800100DDCC67C5C6A69F960A1D71768111  : public InputCategory_t9C22614C15FBDA3F98B6F03EA3CEB547BF5F373C
{
	// System.Boolean Rewired.InputMapCategory::_checkConflictsWithAllCategories
	bool ____checkConflictsWithAllCategories_5;
	// System.Collections.Generic.List`1<System.Int32> Rewired.InputMapCategory::_checkConflictsCategoryIds
	List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73* ____checkConflictsCategoryIds_6;
	// System.Collections.ObjectModel.ReadOnlyCollection`1<System.Int32> Rewired.InputMapCategory::_checkConflictsCategoryIds_readOnly
	ReadOnlyCollection_1_t6E714C47AF272D9524CD752F30ED6538C5780952* ____checkConflictsCategoryIds_readOnly_7;
};

// System.Int16
struct Int16_tB8EF286A9C33492FA6E6D6E67320BE93E794A175 
{
	// System.Int16 System.Int16::m_value
	int16_t ___m_value_0;
};

// System.Int32
struct Int32_t680FF22E76F6EFAD4375103CBBFFA0421349384C 
{
	// System.Int32 System.Int32::m_value
	int32_t ___m_value_0;
};

// System.Int64
struct Int64_t092CFB123BE63C28ACDAF65C68F21A526050DBA3 
{
	// System.Int64 System.Int64::m_value
	int64_t ___m_value_0;
};

// System.IntPtr
struct IntPtr_t 
{
	// System.Void* System.IntPtr::m_value
	void* ___m_value_0;
};

struct IntPtr_t_StaticFields
{
	// System.IntPtr System.IntPtr::Zero
	intptr_t ___Zero_1;
};

// UnityEngine.InputSystem.Utilities.InternedString
struct InternedString_t8D62A48CB7D85AAE9CFCCCFB0A77AC2844905735 
{
	// System.String UnityEngine.InputSystem.Utilities.InternedString::m_StringOriginalCase
	String_t* ___m_StringOriginalCase_0;
	// System.String UnityEngine.InputSystem.Utilities.InternedString::m_StringLowerCase
	String_t* ___m_StringLowerCase_1;
};
// Native definition for P/Invoke marshalling of UnityEngine.InputSystem.Utilities.InternedString
struct InternedString_t8D62A48CB7D85AAE9CFCCCFB0A77AC2844905735_marshaled_pinvoke
{
	char* ___m_StringOriginalCase_0;
	char* ___m_StringLowerCase_1;
};
// Native definition for COM marshalling of UnityEngine.InputSystem.Utilities.InternedString
struct InternedString_t8D62A48CB7D85AAE9CFCCCFB0A77AC2844905735_marshaled_com
{
	Il2CppChar* ___m_StringOriginalCase_0;
	Il2CppChar* ___m_StringLowerCase_1;
};

// UnityEngine.Quaternion
struct Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 
{
	// System.Single UnityEngine.Quaternion::x
	float ___x_0;
	// System.Single UnityEngine.Quaternion::y
	float ___y_1;
	// System.Single UnityEngine.Quaternion::z
	float ___z_2;
	// System.Single UnityEngine.Quaternion::w
	float ___w_3;
};

struct Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974_StaticFields
{
	// UnityEngine.Quaternion UnityEngine.Quaternion::identityQuaternion
	Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 ___identityQuaternion_4;
};

// System.SByte
struct SByte_tFEFFEF5D2FEBF5207950AE6FAC150FC53B668DB5 
{
	// System.SByte System.SByte::m_value
	int8_t ___m_value_0;
};

// System.Single
struct Single_t4530F2FF86FCB0DC29F35385CA1BD21BE294761C 
{
	// System.Single System.Single::m_value
	float ___m_value_0;
};

// SreStMNJSUKnhiFeYdCnZvaTqzgO
struct SreStMNJSUKnhiFeYdCnZvaTqzgO_tCAADFAF41D7399BA1A417D5051C817A325FB955C  : public mHznkohyUIHlEQXbyTCVDNERgIMS_t668F235E2813D409F7B224884E65242B8EF4C466
{
	// System.Void* SreStMNJSUKnhiFeYdCnZvaTqzgO::qgarXQxZBFvYBCFHwYxNasfJgtJH
	void* ___qgarXQxZBFvYBCFHwYxNasfJgtJH_3;
	// System.Object SreStMNJSUKnhiFeYdCnZvaTqzgO::eJzWYFASKRtIPtEQeUJbRcwaBCsq
	RuntimeObject* ___eJzWYFASKRtIPtEQeUJbRcwaBCsq_4;
};

// UnityEngine.InputSystem.Utilities.TypeTable
struct TypeTable_tEAC1ECAD849469DEA65DA2FC65B19C2D4739B67E 
{
	// System.Collections.Generic.Dictionary`2<UnityEngine.InputSystem.Utilities.InternedString,System.Type> UnityEngine.InputSystem.Utilities.TypeTable::table
	Dictionary_2_t1FFEE4C9AF6AF524CAD4FDCEA8F3AB34E585451D* ___table_0;
};
// Native definition for P/Invoke marshalling of UnityEngine.InputSystem.Utilities.TypeTable
struct TypeTable_tEAC1ECAD849469DEA65DA2FC65B19C2D4739B67E_marshaled_pinvoke
{
	Dictionary_2_t1FFEE4C9AF6AF524CAD4FDCEA8F3AB34E585451D* ___table_0;
};
// Native definition for COM marshalling of UnityEngine.InputSystem.Utilities.TypeTable
struct TypeTable_tEAC1ECAD849469DEA65DA2FC65B19C2D4739B67E_marshaled_com
{
	Dictionary_2_t1FFEE4C9AF6AF524CAD4FDCEA8F3AB34E585451D* ___table_0;
};

// UnityEngine.Vector2
struct Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 
{
	// System.Single UnityEngine.Vector2::x
	float ___x_0;
	// System.Single UnityEngine.Vector2::y
	float ___y_1;
};

struct Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7_StaticFields
{
	// UnityEngine.Vector2 UnityEngine.Vector2::zeroVector
	Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 ___zeroVector_2;
	// UnityEngine.Vector2 UnityEngine.Vector2::oneVector
	Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 ___oneVector_3;
	// UnityEngine.Vector2 UnityEngine.Vector2::upVector
	Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 ___upVector_4;
	// UnityEngine.Vector2 UnityEngine.Vector2::downVector
	Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 ___downVector_5;
	// UnityEngine.Vector2 UnityEngine.Vector2::leftVector
	Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 ___leftVector_6;
	// UnityEngine.Vector2 UnityEngine.Vector2::rightVector
	Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 ___rightVector_7;
	// UnityEngine.Vector2 UnityEngine.Vector2::positiveInfinityVector
	Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 ___positiveInfinityVector_8;
	// UnityEngine.Vector2 UnityEngine.Vector2::negativeInfinityVector
	Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 ___negativeInfinityVector_9;
};

// UnityEngine.Vector3
struct Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 
{
	// System.Single UnityEngine.Vector3::x
	float ___x_2;
	// System.Single UnityEngine.Vector3::y
	float ___y_3;
	// System.Single UnityEngine.Vector3::z
	float ___z_4;
};

struct Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2_StaticFields
{
	// UnityEngine.Vector3 UnityEngine.Vector3::zeroVector
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___zeroVector_5;
	// UnityEngine.Vector3 UnityEngine.Vector3::oneVector
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___oneVector_6;
	// UnityEngine.Vector3 UnityEngine.Vector3::upVector
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___upVector_7;
	// UnityEngine.Vector3 UnityEngine.Vector3::downVector
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___downVector_8;
	// UnityEngine.Vector3 UnityEngine.Vector3::leftVector
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___leftVector_9;
	// UnityEngine.Vector3 UnityEngine.Vector3::rightVector
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___rightVector_10;
	// UnityEngine.Vector3 UnityEngine.Vector3::forwardVector
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___forwardVector_11;
	// UnityEngine.Vector3 UnityEngine.Vector3::backVector
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___backVector_12;
	// UnityEngine.Vector3 UnityEngine.Vector3::positiveInfinityVector
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___positiveInfinityVector_13;
	// UnityEngine.Vector3 UnityEngine.Vector3::negativeInfinityVector
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___negativeInfinityVector_14;
};

// System.Void
struct Void_t4861ACF8F4594C3437BB48B6E56783494B843915 
{
	union
	{
		struct
		{
		};
		uint8_t Void_t4861ACF8F4594C3437BB48B6E56783494B843915__padding[1];
	};
};

// jQwkwLndXmHLkjaQEggMxbWuzWBN
struct jQwkwLndXmHLkjaQEggMxbWuzWBN_t16BA183769603E5AC3E1A5CD0B747D26A4A7934F 
{
	// System.Int32 jQwkwLndXmHLkjaQEggMxbWuzWBN::xsDXrAhDPOFZBcIRuRdqNTwhdAvB
	int32_t ___xsDXrAhDPOFZBcIRuRdqNTwhdAvB_0;
};

struct jQwkwLndXmHLkjaQEggMxbWuzWBN_t16BA183769603E5AC3E1A5CD0B747D26A4A7934F_StaticFields
{
	// jQwkwLndXmHLkjaQEggMxbWuzWBN jQwkwLndXmHLkjaQEggMxbWuzWBN::GRytADFdTegQaaQNyFTWCFFIpDNIc
	jQwkwLndXmHLkjaQEggMxbWuzWBN_t16BA183769603E5AC3E1A5CD0B747D26A4A7934F ___GRytADFdTegQaaQNyFTWCFFIpDNIc_1;
	// jQwkwLndXmHLkjaQEggMxbWuzWBN jQwkwLndXmHLkjaQEggMxbWuzWBN::MKTaadfqVLzwxAUOznkWMgdyKPzLA
	jQwkwLndXmHLkjaQEggMxbWuzWBN_t16BA183769603E5AC3E1A5CD0B747D26A4A7934F ___MKTaadfqVLzwxAUOznkWMgdyKPzLA_2;
	// uIgcjVTcicmixvMVQWmSpAQpgkZA jQwkwLndXmHLkjaQEggMxbWuzWBN::foCTBioMEoQEcyeWxZEqtGYDNgTK
	uIgcjVTcicmixvMVQWmSpAQpgkZA_t2A5D5D5A468C3C56CF5EC9F05C0C0218FC002CE6* ___foCTBioMEoQEcyeWxZEqtGYDNgTK_3;
	// uIgcjVTcicmixvMVQWmSpAQpgkZA jQwkwLndXmHLkjaQEggMxbWuzWBN::wqxYjNvCizEhBQcYPXHrfqNIIwiQ
	uIgcjVTcicmixvMVQWmSpAQpgkZA_t2A5D5D5A468C3C56CF5EC9F05C0C0218FC002CE6* ___wqxYjNvCizEhBQcYPXHrfqNIIwiQ_4;
	// uIgcjVTcicmixvMVQWmSpAQpgkZA jQwkwLndXmHLkjaQEggMxbWuzWBN::gVYehObOthqkQdsWDphnFrEuzcSk
	uIgcjVTcicmixvMVQWmSpAQpgkZA_t2A5D5D5A468C3C56CF5EC9F05C0C0218FC002CE6* ___gVYehObOthqkQdsWDphnFrEuzcSk_5;
	// uIgcjVTcicmixvMVQWmSpAQpgkZA jQwkwLndXmHLkjaQEggMxbWuzWBN::GFSRywoMAovETKmwaTzBcYgnLfJo
	uIgcjVTcicmixvMVQWmSpAQpgkZA_t2A5D5D5A468C3C56CF5EC9F05C0C0218FC002CE6* ___GFSRywoMAovETKmwaTzBcYgnLfJo_6;
	// uIgcjVTcicmixvMVQWmSpAQpgkZA jQwkwLndXmHLkjaQEggMxbWuzWBN::qMBGSPlASRsRjqEZdaHyGUuMFnf
	uIgcjVTcicmixvMVQWmSpAQpgkZA_t2A5D5D5A468C3C56CF5EC9F05C0C0218FC002CE6* ___qMBGSPlASRsRjqEZdaHyGUuMFnf_7;
	// uIgcjVTcicmixvMVQWmSpAQpgkZA jQwkwLndXmHLkjaQEggMxbWuzWBN::gCzruRmKgvrchsfKRNOlYDWVQpKQ
	uIgcjVTcicmixvMVQWmSpAQpgkZA_t2A5D5D5A468C3C56CF5EC9F05C0C0218FC002CE6* ___gCzruRmKgvrchsfKRNOlYDWVQpKQ_8;
	// uIgcjVTcicmixvMVQWmSpAQpgkZA jQwkwLndXmHLkjaQEggMxbWuzWBN::bxhBLgYhqZpKprlyMdMAhnVqMKwe
	uIgcjVTcicmixvMVQWmSpAQpgkZA_t2A5D5D5A468C3C56CF5EC9F05C0C0218FC002CE6* ___bxhBLgYhqZpKprlyMdMAhnVqMKwe_9;
	// uIgcjVTcicmixvMVQWmSpAQpgkZA jQwkwLndXmHLkjaQEggMxbWuzWBN::tpEQIyxiJyCXktFdVSuXhMVRaCSS
	uIgcjVTcicmixvMVQWmSpAQpgkZA_t2A5D5D5A468C3C56CF5EC9F05C0C0218FC002CE6* ___tpEQIyxiJyCXktFdVSuXhMVRaCSS_10;
	// uIgcjVTcicmixvMVQWmSpAQpgkZA jQwkwLndXmHLkjaQEggMxbWuzWBN::nGvfKfjRiLvnRHRVPJNBDXAmTfan
	uIgcjVTcicmixvMVQWmSpAQpgkZA_t2A5D5D5A468C3C56CF5EC9F05C0C0218FC002CE6* ___nGvfKfjRiLvnRHRVPJNBDXAmTfan_11;
	// uIgcjVTcicmixvMVQWmSpAQpgkZA jQwkwLndXmHLkjaQEggMxbWuzWBN::coyhbmpdgLxssaWzLDSyvIWYgUEU
	uIgcjVTcicmixvMVQWmSpAQpgkZA_t2A5D5D5A468C3C56CF5EC9F05C0C0218FC002CE6* ___coyhbmpdgLxssaWzLDSyvIWYgUEU_12;
	// uIgcjVTcicmixvMVQWmSpAQpgkZA jQwkwLndXmHLkjaQEggMxbWuzWBN::UHeBzmHpyLldJvUlUGpEVJRDBJxhA
	uIgcjVTcicmixvMVQWmSpAQpgkZA_t2A5D5D5A468C3C56CF5EC9F05C0C0218FC002CE6* ___UHeBzmHpyLldJvUlUGpEVJRDBJxhA_13;
	// uIgcjVTcicmixvMVQWmSpAQpgkZA jQwkwLndXmHLkjaQEggMxbWuzWBN::FpEZoDoGfwIKiySQdvHlwkecJPYs
	uIgcjVTcicmixvMVQWmSpAQpgkZA_t2A5D5D5A468C3C56CF5EC9F05C0C0218FC002CE6* ___FpEZoDoGfwIKiySQdvHlwkecJPYs_14;
};

// UnityEngine.InputSystem.InputAction/CallbackContext
struct CallbackContext_tB251EE41F509C6E8A6B05EC97C029A45DF4F5FA8 
{
	// UnityEngine.InputSystem.InputActionState UnityEngine.InputSystem.InputAction/CallbackContext::m_State
	InputActionState_t780948EA293BAA800AD8699518B58B59FFB8A700* ___m_State_0;
	// System.Int32 UnityEngine.InputSystem.InputAction/CallbackContext::m_ActionIndex
	int32_t ___m_ActionIndex_1;
};
// Native definition for P/Invoke marshalling of UnityEngine.InputSystem.InputAction/CallbackContext
struct CallbackContext_tB251EE41F509C6E8A6B05EC97C029A45DF4F5FA8_marshaled_pinvoke
{
	InputActionState_t780948EA293BAA800AD8699518B58B59FFB8A700* ___m_State_0;
	int32_t ___m_ActionIndex_1;
};
// Native definition for COM marshalling of UnityEngine.InputSystem.InputAction/CallbackContext
struct CallbackContext_tB251EE41F509C6E8A6B05EC97C029A45DF4F5FA8_marshaled_com
{
	InputActionState_t780948EA293BAA800AD8699518B58B59FFB8A700* ___m_State_0;
	int32_t ___m_ActionIndex_1;
};

// UnityEngine.InputSystem.InputActionSetupExtensions/BindingSyntax
struct BindingSyntax_t5FB93D8F3518B4640E42E067ECB15541CD123317 
{
	// UnityEngine.InputSystem.InputActionMap UnityEngine.InputSystem.InputActionSetupExtensions/BindingSyntax::m_ActionMap
	InputActionMap_tFCE82E0E014319D4DED9F8962B06655DD0420A09* ___m_ActionMap_0;
	// UnityEngine.InputSystem.InputAction UnityEngine.InputSystem.InputActionSetupExtensions/BindingSyntax::m_Action
	InputAction_t1B550AD2B55AF322AFB53CD28DA64081220D01CD* ___m_Action_1;
	// System.Int32 UnityEngine.InputSystem.InputActionSetupExtensions/BindingSyntax::m_BindingIndexInMap
	int32_t ___m_BindingIndexInMap_2;
};
// Native definition for P/Invoke marshalling of UnityEngine.InputSystem.InputActionSetupExtensions/BindingSyntax
struct BindingSyntax_t5FB93D8F3518B4640E42E067ECB15541CD123317_marshaled_pinvoke
{
	InputActionMap_tFCE82E0E014319D4DED9F8962B06655DD0420A09* ___m_ActionMap_0;
	InputAction_t1B550AD2B55AF322AFB53CD28DA64081220D01CD* ___m_Action_1;
	int32_t ___m_BindingIndexInMap_2;
};
// Native definition for COM marshalling of UnityEngine.InputSystem.InputActionSetupExtensions/BindingSyntax
struct BindingSyntax_t5FB93D8F3518B4640E42E067ECB15541CD123317_marshaled_com
{
	InputActionMap_tFCE82E0E014319D4DED9F8962B06655DD0420A09* ___m_ActionMap_0;
	InputAction_t1B550AD2B55AF322AFB53CD28DA64081220D01CD* ___m_Action_1;
	int32_t ___m_BindingIndexInMap_2;
};

// UnityEngine.InputSystem.InputActionState/UnmanagedMemory
struct UnmanagedMemory_t862EBE5224929ED0E2F989D790EB6B8633E612A2 
{
	// System.Void* UnityEngine.InputSystem.InputActionState/UnmanagedMemory::basePtr
	void* ___basePtr_0;
	// System.Int32 UnityEngine.InputSystem.InputActionState/UnmanagedMemory::mapCount
	int32_t ___mapCount_1;
	// System.Int32 UnityEngine.InputSystem.InputActionState/UnmanagedMemory::actionCount
	int32_t ___actionCount_2;
	// System.Int32 UnityEngine.InputSystem.InputActionState/UnmanagedMemory::interactionCount
	int32_t ___interactionCount_3;
	// System.Int32 UnityEngine.InputSystem.InputActionState/UnmanagedMemory::bindingCount
	int32_t ___bindingCount_4;
	// System.Int32 UnityEngine.InputSystem.InputActionState/UnmanagedMemory::controlCount
	int32_t ___controlCount_5;
	// System.Int32 UnityEngine.InputSystem.InputActionState/UnmanagedMemory::compositeCount
	int32_t ___compositeCount_6;
	// UnityEngine.InputSystem.InputActionState/TriggerState* UnityEngine.InputSystem.InputActionState/UnmanagedMemory::actionStates
	TriggerState_t99B6AEA05EECEE1FEE7B60C2ABA73FA03685F38D* ___actionStates_7;
	// UnityEngine.InputSystem.InputActionState/BindingState* UnityEngine.InputSystem.InputActionState/UnmanagedMemory::bindingStates
	BindingState_t69D9579E13933436EAF3A3886EAED220DFD696EA* ___bindingStates_8;
	// UnityEngine.InputSystem.InputActionState/InteractionState* UnityEngine.InputSystem.InputActionState/UnmanagedMemory::interactionStates
	InteractionState_t057CEDBCC55120B30A48DAD0A4111EF8FF62D3AE* ___interactionStates_9;
	// System.Single* UnityEngine.InputSystem.InputActionState/UnmanagedMemory::controlMagnitudes
	float* ___controlMagnitudes_10;
	// System.Single* UnityEngine.InputSystem.InputActionState/UnmanagedMemory::compositeMagnitudes
	float* ___compositeMagnitudes_11;
	// System.Int32* UnityEngine.InputSystem.InputActionState/UnmanagedMemory::enabledControls
	int32_t* ___enabledControls_12;
	// System.UInt16* UnityEngine.InputSystem.InputActionState/UnmanagedMemory::actionBindingIndicesAndCounts
	uint16_t* ___actionBindingIndicesAndCounts_13;
	// System.UInt16* UnityEngine.InputSystem.InputActionState/UnmanagedMemory::actionBindingIndices
	uint16_t* ___actionBindingIndices_14;
	// System.Int32* UnityEngine.InputSystem.InputActionState/UnmanagedMemory::controlIndexToBindingIndex
	int32_t* ___controlIndexToBindingIndex_15;
	// UnityEngine.InputSystem.InputActionState/ActionMapIndices* UnityEngine.InputSystem.InputActionState/UnmanagedMemory::mapIndices
	ActionMapIndices_t013BEFD76B7FE52E413C5DBF5C7CDA4194800CBD* ___mapIndices_16;
};

// UnityEngine.InputSystem.Layouts.InputControlLayout/Cache
struct Cache_tB837109647F577DCE3795AEE2E9E0E3F61F543AB 
{
	// System.Collections.Generic.Dictionary`2<UnityEngine.InputSystem.Utilities.InternedString,UnityEngine.InputSystem.Layouts.InputControlLayout> UnityEngine.InputSystem.Layouts.InputControlLayout/Cache::table
	Dictionary_2_t058B78C04CBFB0F1C72F95C9880AE09DA041219F* ___table_0;
};
// Native definition for P/Invoke marshalling of UnityEngine.InputSystem.Layouts.InputControlLayout/Cache
struct Cache_tB837109647F577DCE3795AEE2E9E0E3F61F543AB_marshaled_pinvoke
{
	Dictionary_2_t058B78C04CBFB0F1C72F95C9880AE09DA041219F* ___table_0;
};
// Native definition for COM marshalling of UnityEngine.InputSystem.Layouts.InputControlLayout/Cache
struct Cache_tB837109647F577DCE3795AEE2E9E0E3F61F543AB_marshaled_com
{
	Dictionary_2_t058B78C04CBFB0F1C72F95C9880AE09DA041219F* ___table_0;
};

// UnityEngine.InputSystem.Layouts.InputControlLayout/Collection
struct Collection_t6E9F85AD439CF26269683541C4DC58BA3B6756C5 
{
	// System.Collections.Generic.Dictionary`2<UnityEngine.InputSystem.Utilities.InternedString,System.Type> UnityEngine.InputSystem.Layouts.InputControlLayout/Collection::layoutTypes
	Dictionary_2_t1FFEE4C9AF6AF524CAD4FDCEA8F3AB34E585451D* ___layoutTypes_1;
	// System.Collections.Generic.Dictionary`2<UnityEngine.InputSystem.Utilities.InternedString,System.String> UnityEngine.InputSystem.Layouts.InputControlLayout/Collection::layoutStrings
	Dictionary_2_tEB3FF1660C6129E11F3B4771A549DE9F169B5103* ___layoutStrings_2;
	// System.Collections.Generic.Dictionary`2<UnityEngine.InputSystem.Utilities.InternedString,System.Func`1<UnityEngine.InputSystem.Layouts.InputControlLayout>> UnityEngine.InputSystem.Layouts.InputControlLayout/Collection::layoutBuilders
	Dictionary_2_tFF0F3921D8B2465193365C2463B7D6A977E874DA* ___layoutBuilders_3;
	// System.Collections.Generic.Dictionary`2<UnityEngine.InputSystem.Utilities.InternedString,UnityEngine.InputSystem.Utilities.InternedString> UnityEngine.InputSystem.Layouts.InputControlLayout/Collection::baseLayoutTable
	Dictionary_2_t433D1FE2CDB69C9F583F79D5252A34112439D0AD* ___baseLayoutTable_4;
	// System.Collections.Generic.Dictionary`2<UnityEngine.InputSystem.Utilities.InternedString,UnityEngine.InputSystem.Utilities.InternedString[]> UnityEngine.InputSystem.Layouts.InputControlLayout/Collection::layoutOverrides
	Dictionary_2_tA8E192E813E347FF19EC3868E2C565607445394C* ___layoutOverrides_5;
	// System.Collections.Generic.HashSet`1<UnityEngine.InputSystem.Utilities.InternedString> UnityEngine.InputSystem.Layouts.InputControlLayout/Collection::layoutOverrideNames
	HashSet_1_t87C47CF88B1B88398D4F9A1E51E92F834CF5160B* ___layoutOverrideNames_6;
	// System.Collections.Generic.Dictionary`2<UnityEngine.InputSystem.Utilities.InternedString,UnityEngine.InputSystem.Layouts.InputControlLayout/Collection/PrecompiledLayout> UnityEngine.InputSystem.Layouts.InputControlLayout/Collection::precompiledLayouts
	Dictionary_2_tD68C40116E127FE79F9E7AF07820CFDDBF20A8C1* ___precompiledLayouts_7;
	// System.Collections.Generic.List`1<UnityEngine.InputSystem.Layouts.InputControlLayout/Collection/LayoutMatcher> UnityEngine.InputSystem.Layouts.InputControlLayout/Collection::layoutMatchers
	List_1_t4E502B2E42676E48E6F9A8F0251ADB1DF4BD490E* ___layoutMatchers_8;
};
// Native definition for P/Invoke marshalling of UnityEngine.InputSystem.Layouts.InputControlLayout/Collection
struct Collection_t6E9F85AD439CF26269683541C4DC58BA3B6756C5_marshaled_pinvoke
{
	Dictionary_2_t1FFEE4C9AF6AF524CAD4FDCEA8F3AB34E585451D* ___layoutTypes_1;
	Dictionary_2_tEB3FF1660C6129E11F3B4771A549DE9F169B5103* ___layoutStrings_2;
	Dictionary_2_tFF0F3921D8B2465193365C2463B7D6A977E874DA* ___layoutBuilders_3;
	Dictionary_2_t433D1FE2CDB69C9F583F79D5252A34112439D0AD* ___baseLayoutTable_4;
	Dictionary_2_tA8E192E813E347FF19EC3868E2C565607445394C* ___layoutOverrides_5;
	HashSet_1_t87C47CF88B1B88398D4F9A1E51E92F834CF5160B* ___layoutOverrideNames_6;
	Dictionary_2_tD68C40116E127FE79F9E7AF07820CFDDBF20A8C1* ___precompiledLayouts_7;
	List_1_t4E502B2E42676E48E6F9A8F0251ADB1DF4BD490E* ___layoutMatchers_8;
};
// Native definition for COM marshalling of UnityEngine.InputSystem.Layouts.InputControlLayout/Collection
struct Collection_t6E9F85AD439CF26269683541C4DC58BA3B6756C5_marshaled_com
{
	Dictionary_2_t1FFEE4C9AF6AF524CAD4FDCEA8F3AB34E585451D* ___layoutTypes_1;
	Dictionary_2_tEB3FF1660C6129E11F3B4771A549DE9F169B5103* ___layoutStrings_2;
	Dictionary_2_tFF0F3921D8B2465193365C2463B7D6A977E874DA* ___layoutBuilders_3;
	Dictionary_2_t433D1FE2CDB69C9F583F79D5252A34112439D0AD* ___baseLayoutTable_4;
	Dictionary_2_tA8E192E813E347FF19EC3868E2C565607445394C* ___layoutOverrides_5;
	HashSet_1_t87C47CF88B1B88398D4F9A1E51E92F834CF5160B* ___layoutOverrideNames_6;
	Dictionary_2_tD68C40116E127FE79F9E7AF07820CFDDBF20A8C1* ___precompiledLayouts_7;
	List_1_t4E502B2E42676E48E6F9A8F0251ADB1DF4BD490E* ___layoutMatchers_8;
};

// Rewired.PlayerController/CompoundElement
struct CompoundElement_t89F22D17450D47C1307CC80AFA332B78C00CEB87  : public Element_t26F7003E01AAF28091E75E0A3552C2C3EEA38F06
{
	// System.Collections.Generic.List`1<Rewired.PlayerController/Element> Rewired.PlayerController/CompoundElement::FZydGRarJpccYCkKlMkeaFhsIdKT
	List_1_t1327B0703B35EF48626AC42F0D0C487FCBD86CF5* ___FZydGRarJpccYCkKlMkeaFhsIdKT_7;
};

// Rewired.ReInput/ControllerHelper
struct ControllerHelper_t470828F1E9094A484F8FE12DB16199890DF23F5E  : public CodeHelper_t3C7A463B1ACD337842945793AAAA8641F9832291
{
	// Rewired.ReInput/ControllerHelper/PollingHelper Rewired.ReInput/ControllerHelper::polling
	PollingHelper_tDC5975DF531D46693230837C215974F5B59AECAB* ___polling_1;
	// Rewired.ReInput/ControllerHelper/ConflictCheckingHelper Rewired.ReInput/ControllerHelper::conflictChecking
	ConflictCheckingHelper_tD50E0E01A2183F0F5290D4704CB790D45A7626C4* ___conflictChecking_2;
};

struct ControllerHelper_t470828F1E9094A484F8FE12DB16199890DF23F5E_StaticFields
{
	// Rewired.ReInput/ControllerHelper Rewired.ReInput/ControllerHelper::tusTZiBoCPVQrGuQgVUEuHxykifk
	ControllerHelper_t470828F1E9094A484F8FE12DB16199890DF23F5E* ___tusTZiBoCPVQrGuQgVUEuHxykifk_0;
};

// Rewired.ReInput/MappingHelper
struct MappingHelper_t18AE344473D49AF2E7133108678DD4D963699662  : public CodeHelper_t3C7A463B1ACD337842945793AAAA8641F9832291
{
};

struct MappingHelper_t18AE344473D49AF2E7133108678DD4D963699662_StaticFields
{
	// Rewired.ReInput/MappingHelper Rewired.ReInput/MappingHelper::tusTZiBoCPVQrGuQgVUEuHxykifk
	MappingHelper_t18AE344473D49AF2E7133108678DD4D963699662* ___tusTZiBoCPVQrGuQgVUEuHxykifk_0;
};

// Rewired.ReInput/PlayerHelper
struct PlayerHelper_t96BC8DE1C94717C98B253F25C7B9C82639E4BF5C  : public CodeHelper_t3C7A463B1ACD337842945793AAAA8641F9832291
{
};

struct PlayerHelper_t96BC8DE1C94717C98B253F25C7B9C82639E4BF5C_StaticFields
{
	// Rewired.ReInput/PlayerHelper Rewired.ReInput/PlayerHelper::tusTZiBoCPVQrGuQgVUEuHxykifk
	PlayerHelper_t96BC8DE1C94717C98B253F25C7B9C82639E4BF5C* ___tusTZiBoCPVQrGuQgVUEuHxykifk_0;
};

// Rewired.Player/ControllerHelper/ConflictCheckingHelper
struct ConflictCheckingHelper_t8D707CEC57F056B87A4C68F98F780D34E893A8DB  : public CodeHelper_t3C7A463B1ACD337842945793AAAA8641F9832291
{
	// Rewired.Player Rewired.Player/ControllerHelper/ConflictCheckingHelper::vLioXoePkQiNEWuOkALOfFKNbaiU
	Player_t71A64CE695A2F96B144F3050755AB2799DA7C01B* ___vLioXoePkQiNEWuOkALOfFKNbaiU_0;
	// Rewired.Player/ControllerHelper Rewired.Player/ControllerHelper/ConflictCheckingHelper::JOhXpftGzsqKykxdovItahCXjNZ
	ControllerHelper_tCE72EA23053BD0C6ECB4D75A69F8CD1B3AC28FF6* ___JOhXpftGzsqKykxdovItahCXjNZ_1;
	// System.Int32 Rewired.Player/ControllerHelper/ConflictCheckingHelper::eNyGUiEiMyquCTKLRhFvpeyOvzMm
	int32_t ___eNyGUiEiMyquCTKLRhFvpeyOvzMm_2;
};

// Rewired.Player/ControllerHelper/MapHelper
struct MapHelper_t214BA4F045E5EB4B312E4E6AEB6697813117A7C2  : public CodeHelper_t3C7A463B1ACD337842945793AAAA8641F9832291
{
	// EYzeMRMINmbDPjgLMbiDXTDcHYNs Rewired.Player/ControllerHelper/MapHelper::jPiIwoojBEMPokBDPrKAFdfiDpydA
	EYzeMRMINmbDPjgLMbiDXTDcHYNs_tCDC7C8E6E50F029693E0ACB75DA0000C6F87E379* ___jPiIwoojBEMPokBDPrKAFdfiDpydA_0;
	// Rewired.Player Rewired.Player/ControllerHelper/MapHelper::vLioXoePkQiNEWuOkALOfFKNbaiU
	Player_t71A64CE695A2F96B144F3050755AB2799DA7C01B* ___vLioXoePkQiNEWuOkALOfFKNbaiU_1;
	// Rewired.Player/ControllerHelper Rewired.Player/ControllerHelper/MapHelper::JOhXpftGzsqKykxdovItahCXjNZ
	ControllerHelper_tCE72EA23053BD0C6ECB4D75A69F8CD1B3AC28FF6* ___JOhXpftGzsqKykxdovItahCXjNZ_2;
	// Rewired.ControllerMapEnabler Rewired.Player/ControllerHelper/MapHelper::dohPxJNTmKSehHjFxABvGTvnYGnw
	ControllerMapEnabler_tA0F9E3CA8F655F79B94FE9343DC7D543CCC0DE9B* ___dohPxJNTmKSehHjFxABvGTvnYGnw_3;
	// Rewired.ControllerMapLayoutManager Rewired.Player/ControllerHelper/MapHelper::DLygvCesBtqGZiRYmwoQkFsPQSgs
	ControllerMapLayoutManager_t630460EA47983879378D747091ED5C63493C23B3* ___DLygvCesBtqGZiRYmwoQkFsPQSgs_4;
	// System.Int32 Rewired.Player/ControllerHelper/MapHelper::eNyGUiEiMyquCTKLRhFvpeyOvzMm
	int32_t ___eNyGUiEiMyquCTKLRhFvpeyOvzMm_5;
};

// UnityEngine.InputSystem.Utilities.CallbackArray`1<System.Action`1<System.Object>>
struct CallbackArray_1_tB6F9AD05405749A2888C89224C8F5ECF4E1C0411 
{
	// System.Boolean UnityEngine.InputSystem.Utilities.CallbackArray`1::m_CannotMutateCallbacksArray
	bool ___m_CannotMutateCallbacksArray_0;
	// UnityEngine.InputSystem.Utilities.InlinedArray`1<TDelegate> UnityEngine.InputSystem.Utilities.CallbackArray`1::m_Callbacks
	InlinedArray_1_t90D679876AE3A52129F69F403ECC9AD16D60AD9F ___m_Callbacks_1;
	// UnityEngine.InputSystem.Utilities.InlinedArray`1<TDelegate> UnityEngine.InputSystem.Utilities.CallbackArray`1::m_CallbacksToAdd
	InlinedArray_1_t90D679876AE3A52129F69F403ECC9AD16D60AD9F ___m_CallbacksToAdd_2;
	// UnityEngine.InputSystem.Utilities.InlinedArray`1<TDelegate> UnityEngine.InputSystem.Utilities.CallbackArray`1::m_CallbacksToRemove
	InlinedArray_1_t90D679876AE3A52129F69F403ECC9AD16D60AD9F ___m_CallbacksToRemove_3;
};

// UnityEngine.InputSystem.Utilities.CallbackArray`1<System.Action`2<System.Object,UnityEngine.InputSystem.InputActionChange>>
struct CallbackArray_1_tC72D651E25D95D1B5D837A010859EDE49AD131FA 
{
	// System.Boolean UnityEngine.InputSystem.Utilities.CallbackArray`1::m_CannotMutateCallbacksArray
	bool ___m_CannotMutateCallbacksArray_0;
	// UnityEngine.InputSystem.Utilities.InlinedArray`1<TDelegate> UnityEngine.InputSystem.Utilities.CallbackArray`1::m_Callbacks
	InlinedArray_1_tF80F63393E0BF97AFE20E770FC71798135300300 ___m_Callbacks_1;
	// UnityEngine.InputSystem.Utilities.InlinedArray`1<TDelegate> UnityEngine.InputSystem.Utilities.CallbackArray`1::m_CallbacksToAdd
	InlinedArray_1_tF80F63393E0BF97AFE20E770FC71798135300300 ___m_CallbacksToAdd_2;
	// UnityEngine.InputSystem.Utilities.InlinedArray`1<TDelegate> UnityEngine.InputSystem.Utilities.CallbackArray`1::m_CallbacksToRemove
	InlinedArray_1_tF80F63393E0BF97AFE20E770FC71798135300300 ___m_CallbacksToRemove_3;
};

// UnityEngine.InputSystem.Utilities.InlinedArray`1<UnityEngine.InputSystem.Utilities.InternedString>
struct InlinedArray_1_tAFDFE0972A71B9760077CFA9D4A1DBD7BE435800 
{
	// System.Int32 UnityEngine.InputSystem.Utilities.InlinedArray`1::length
	int32_t ___length_0;
	// TValue UnityEngine.InputSystem.Utilities.InlinedArray`1::firstValue
	InternedString_t8D62A48CB7D85AAE9CFCCCFB0A77AC2844905735 ___firstValue_1;
	// TValue[] UnityEngine.InputSystem.Utilities.InlinedArray`1::additionalValues
	InternedStringU5BU5D_t0B851758733FC0B118D84BE83AED10A0404C18D5* ___additionalValues_2;
};

// Rewired.Utils.SafeAction`1<System.Object>
struct SafeAction_1_t6487A885AFD7F4B1D15116DF8B20C492918A637F  : public SafeDelegate_1_t28BA538478CD717887608073323B0FC410BAC20F
{
	// T Rewired.Utils.SafeAction`1::YKtCaBLZQYIgXLHXmAhcaNRJpQOv
	RuntimeObject* ___YKtCaBLZQYIgXLHXmAhcaNRJpQOv_4;
};

struct SafeAction_1_t6487A885AFD7F4B1D15116DF8B20C492918A637F_StaticFields
{
	// System.Action`2<System.Object,System.Action`1<T>> Rewired.Utils.SafeAction`1::WqZwbUCoUKgMptnKPbcigSGjHeUv
	Action_2_tB8342B1788FB8809F861F5EE2A321470B67D4BBA* ___WqZwbUCoUKgMptnKPbcigSGjHeUv_5;
};

// Unity.Collections.Allocator
struct Allocator_t996642592271AAD9EE688F142741D512C07B5824 
{
	// System.Int32 Unity.Collections.Allocator::value__
	int32_t ___value___2;
};

// Rewired.Data.Mapping.AlternateAxisCalibrationType
struct AlternateAxisCalibrationType_t9D27B90D70553E85A56D9BB25A18DEEC7BEC5C9A 
{
	// System.Int32 Rewired.Data.Mapping.AlternateAxisCalibrationType::value__
	int32_t ___value___2;
};

// Rewired.AxisCoordinateMode
struct AxisCoordinateMode_tCFA79752E45238E2AD79095B47A8D1A7A95FE22F 
{
	// System.Int32 Rewired.AxisCoordinateMode::value__
	int32_t ___value___2;
};

// Rewired.AxisRange
struct AxisRange_tAB921FDCAA3CC6E6128FDC93A6536152A2268E75 
{
	// System.Int32 Rewired.AxisRange::value__
	int32_t ___value___2;
};

// Rewired.AxisSensitivity2DType
struct AxisSensitivity2DType_t84BDEFCDD1F0B24B189ACA4D759E6AD3937051DC 
{
	// System.Int32 Rewired.AxisSensitivity2DType::value__
	int32_t ___value___2;
};

// Rewired.AxisSensitivityType
struct AxisSensitivityType_t79FA6719569C2723AB13073F29ED729184BF47A1 
{
	// System.Int32 Rewired.AxisSensitivityType::value__
	int32_t ___value___2;
};

// System.Reflection.BindingFlags
struct BindingFlags_t5DC2835E4AE9C1862B3AD172EF35B6A5F4F1812C 
{
	// System.Int32 System.Reflection.BindingFlags::value__
	int32_t ___value___2;
};

// Rewired.BoolOption
struct BoolOption_tE7945CF0C089A73DB9DD94B04EE58F0FE57737ED 
{
	// System.Int32 Rewired.BoolOption::value__
	int32_t ___value___2;
};

// Rewired.ButtonStateFlags
struct ButtonStateFlags_tC782DAB7CAE291479F8CCBEC0943033668D77F83 
{
	// System.Int32 Rewired.ButtonStateFlags::value__
	int32_t ___value___2;
};

// Rewired.CompoundControllerElementType
struct CompoundControllerElementType_t2B35B229782BC373431543EFC02B42ED0BCB72C6 
{
	// System.Int32 Rewired.CompoundControllerElementType::value__
	int32_t ___value___2;
};

// Rewired.ControllerElementType
struct ControllerElementType_t69E1FA1BEB508AFD38B2593EAB7E90F56998A370 
{
	// System.Int32 Rewired.ControllerElementType::value__
	int32_t ___value___2;
};

// Rewired.ControllerType
struct ControllerType_t41401D57750E3991DC372B9DFF320913295F3839 
{
	// System.Int32 Rewired.ControllerType::value__
	int32_t ___value___2;
};

// Rewired.DeadZone2DType
struct DeadZone2DType_tDE420FD9519C42B331FFE95EC0DE142ACA92B803 
{
	// System.Int32 Rewired.DeadZone2DType::value__
	int32_t ___value___2;
};

// System.Delegate
struct Delegate_t  : public RuntimeObject
{
	// System.IntPtr System.Delegate::method_ptr
	Il2CppMethodPointer ___method_ptr_0;
	// System.IntPtr System.Delegate::invoke_impl
	intptr_t ___invoke_impl_1;
	// System.Object System.Delegate::m_target
	RuntimeObject* ___m_target_2;
	// System.IntPtr System.Delegate::method
	intptr_t ___method_3;
	// System.IntPtr System.Delegate::delegate_trampoline
	intptr_t ___delegate_trampoline_4;
	// System.IntPtr System.Delegate::extra_arg
	intptr_t ___extra_arg_5;
	// System.IntPtr System.Delegate::method_code
	intptr_t ___method_code_6;
	// System.IntPtr System.Delegate::interp_method
	intptr_t ___interp_method_7;
	// System.IntPtr System.Delegate::interp_invoke_impl
	intptr_t ___interp_invoke_impl_8;
	// System.Reflection.MethodInfo System.Delegate::method_info
	MethodInfo_t* ___method_info_9;
	// System.Reflection.MethodInfo System.Delegate::original_method_info
	MethodInfo_t* ___original_method_info_10;
	// System.DelegateData System.Delegate::data
	DelegateData_t9B286B493293CD2D23A5B2B5EF0E5B1324C2B77E* ___data_11;
	// System.Boolean System.Delegate::method_is_virtual
	bool ___method_is_virtual_12;
};
// Native definition for P/Invoke marshalling of System.Delegate
struct Delegate_t_marshaled_pinvoke
{
	intptr_t ___method_ptr_0;
	intptr_t ___invoke_impl_1;
	Il2CppIUnknown* ___m_target_2;
	intptr_t ___method_3;
	intptr_t ___delegate_trampoline_4;
	intptr_t ___extra_arg_5;
	intptr_t ___method_code_6;
	intptr_t ___interp_method_7;
	intptr_t ___interp_invoke_impl_8;
	MethodInfo_t* ___method_info_9;
	MethodInfo_t* ___original_method_info_10;
	DelegateData_t9B286B493293CD2D23A5B2B5EF0E5B1324C2B77E* ___data_11;
	int32_t ___method_is_virtual_12;
};
// Native definition for COM marshalling of System.Delegate
struct Delegate_t_marshaled_com
{
	intptr_t ___method_ptr_0;
	intptr_t ___invoke_impl_1;
	Il2CppIUnknown* ___m_target_2;
	intptr_t ___method_3;
	intptr_t ___delegate_trampoline_4;
	intptr_t ___extra_arg_5;
	intptr_t ___method_code_6;
	intptr_t ___interp_method_7;
	intptr_t ___interp_invoke_impl_8;
	MethodInfo_t* ___method_info_9;
	MethodInfo_t* ___original_method_info_10;
	DelegateData_t9B286B493293CD2D23A5B2B5EF0E5B1324C2B77E* ___data_11;
	int32_t ___method_is_virtual_12;
};

// Rewired.Platforms.EditorPlatform
struct EditorPlatform_t33D187BE0BD636E5EF23116C33501D22BA6F407F 
{
	// System.Int32 Rewired.Platforms.EditorPlatform::value__
	int32_t ___value___2;
};

// Rewired.ElementAssignmentType
struct ElementAssignmentType_tC4EA16FFA08E9B000C12C326CB5C0020B77AAF30 
{
	// System.Int32 Rewired.ElementAssignmentType::value__
	int32_t ___value___2;
};

// System.Exception
struct Exception_t  : public RuntimeObject
{
	// System.String System.Exception::_className
	String_t* ____className_1;
	// System.String System.Exception::_message
	String_t* ____message_2;
	// System.Collections.IDictionary System.Exception::_data
	RuntimeObject* ____data_3;
	// System.Exception System.Exception::_innerException
	Exception_t* ____innerException_4;
	// System.String System.Exception::_helpURL
	String_t* ____helpURL_5;
	// System.Object System.Exception::_stackTrace
	RuntimeObject* ____stackTrace_6;
	// System.String System.Exception::_stackTraceString
	String_t* ____stackTraceString_7;
	// System.String System.Exception::_remoteStackTraceString
	String_t* ____remoteStackTraceString_8;
	// System.Int32 System.Exception::_remoteStackIndex
	int32_t ____remoteStackIndex_9;
	// System.Object System.Exception::_dynamicMethods
	RuntimeObject* ____dynamicMethods_10;
	// System.Int32 System.Exception::_HResult
	int32_t ____HResult_11;
	// System.String System.Exception::_source
	String_t* ____source_12;
	// System.Runtime.Serialization.SafeSerializationManager System.Exception::_safeSerializationManager
	SafeSerializationManager_tCBB85B95DFD1634237140CD892E82D06ECB3F5E6* ____safeSerializationManager_13;
	// System.Diagnostics.StackTrace[] System.Exception::captured_traces
	StackTraceU5BU5D_t32FBCB20930EAF5BAE3F450FF75228E5450DA0DF* ___captured_traces_14;
	// System.IntPtr[] System.Exception::native_trace_ips
	IntPtrU5BU5D_tFD177F8C806A6921AD7150264CCC62FA00CAD832* ___native_trace_ips_15;
	// System.Int32 System.Exception::caught_in_unmanaged
	int32_t ___caught_in_unmanaged_16;
};

struct Exception_t_StaticFields
{
	// System.Object System.Exception::s_EDILock
	RuntimeObject* ___s_EDILock_0;
};
// Native definition for P/Invoke marshalling of System.Exception
struct Exception_t_marshaled_pinvoke
{
	char* ____className_1;
	char* ____message_2;
	RuntimeObject* ____data_3;
	Exception_t_marshaled_pinvoke* ____innerException_4;
	char* ____helpURL_5;
	Il2CppIUnknown* ____stackTrace_6;
	char* ____stackTraceString_7;
	char* ____remoteStackTraceString_8;
	int32_t ____remoteStackIndex_9;
	Il2CppIUnknown* ____dynamicMethods_10;
	int32_t ____HResult_11;
	char* ____source_12;
	SafeSerializationManager_tCBB85B95DFD1634237140CD892E82D06ECB3F5E6* ____safeSerializationManager_13;
	StackTraceU5BU5D_t32FBCB20930EAF5BAE3F450FF75228E5450DA0DF* ___captured_traces_14;
	Il2CppSafeArray/*NONE*/* ___native_trace_ips_15;
	int32_t ___caught_in_unmanaged_16;
};
// Native definition for COM marshalling of System.Exception
struct Exception_t_marshaled_com
{
	Il2CppChar* ____className_1;
	Il2CppChar* ____message_2;
	RuntimeObject* ____data_3;
	Exception_t_marshaled_com* ____innerException_4;
	Il2CppChar* ____helpURL_5;
	Il2CppIUnknown* ____stackTrace_6;
	Il2CppChar* ____stackTraceString_7;
	Il2CppChar* ____remoteStackTraceString_8;
	int32_t ____remoteStackIndex_9;
	Il2CppIUnknown* ____dynamicMethods_10;
	int32_t ____HResult_11;
	Il2CppChar* ____source_12;
	SafeSerializationManager_tCBB85B95DFD1634237140CD892E82D06ECB3F5E6* ____safeSerializationManager_13;
	StackTraceU5BU5D_t32FBCB20930EAF5BAE3F450FF75228E5450DA0DF* ___captured_traces_14;
	Il2CppSafeArray/*NONE*/* ___native_trace_ips_15;
	int32_t ___caught_in_unmanaged_16;
};

// System.Runtime.InteropServices.GCHandle
struct GCHandle_tC44F6F72EE68BD4CFABA24309DA7A179D41127DC 
{
	// System.IntPtr System.Runtime.InteropServices.GCHandle::handle
	intptr_t ___handle_0;
};

// Rewired.Platforms.GameCoreScarlettPrimaryInputSource
struct GameCoreScarlettPrimaryInputSource_tE0834CB2342BEEB48AE323B88DEAB8B64AF2B3AE 
{
	// System.Int32 Rewired.Platforms.GameCoreScarlettPrimaryInputSource::value__
	int32_t ___value___2;
};

// Rewired.Platforms.GameCoreXboxOnePrimaryInputSource
struct GameCoreXboxOnePrimaryInputSource_t340092C768B833F9D5F159BC9969106907382303 
{
	// System.Int32 Rewired.Platforms.GameCoreXboxOnePrimaryInputSource::value__
	int32_t ___value___2;
};

// UnityEngine.InputSystem.InputActionPhase
struct InputActionPhase_t79D9374C1940AA7248377075A0E83122540334C6 
{
	// System.Int32 UnityEngine.InputSystem.InputActionPhase::value__
	int32_t ___value___2;
};

// UnityEngine.InputSystem.InputProcessor
struct InputProcessor_t71DA6677A0295DC87736E1D8D208FEA75D860457  : public RuntimeObject
{
};

struct InputProcessor_t71DA6677A0295DC87736E1D8D208FEA75D860457_StaticFields
{
	// UnityEngine.InputSystem.Utilities.TypeTable UnityEngine.InputSystem.InputProcessor::s_Processors
	TypeTable_tEAC1ECAD849469DEA65DA2FC65B19C2D4739B67E ___s_Processors_0;
};

// Rewired.InputSource
struct InputSource_t7E04F49CA0BC82466AE697DC6675F1FBEC328B2A 
{
	// System.Int32 Rewired.InputSource::value__
	int32_t ___value___2;
};

// System.Int32Enum
struct Int32Enum_tCBAC8BA2BFF3A845FA599F303093BBBA374B6F0C 
{
	// System.Int32 System.Int32Enum::value__
	int32_t ___value___2;
};

// UnityEngine.KeyCode
struct KeyCode_t75B9ECCC26D858F55040DDFF9523681E996D17E9 
{
	// System.Int32 UnityEngine.KeyCode::value__
	int32_t ___value___2;
};

// Rewired.KeyboardKeyCode
struct KeyboardKeyCode_t545B6C6B6503684368C97EF375ECEC08B68993A0 
{
	// System.Int32 Rewired.KeyboardKeyCode::value__
	int32_t ___value___2;
};

// Rewired.Platforms.LinuxStandalonePrimaryInputSource
struct LinuxStandalonePrimaryInputSource_tC7DD22229B3C0CA4B3E44A50B0F6A50FC6670E2E 
{
	// System.Int32 Rewired.Platforms.LinuxStandalonePrimaryInputSource::value__
	int32_t ___value___2;
};

// Rewired.Config.LogLevelFlags
struct LogLevelFlags_t38350E1D196D37CF9B7599733EB41488D04EA6B5 
{
	// System.Int32 Rewired.Config.LogLevelFlags::value__
	int32_t ___value___2;
};

// Rewired.ModifierKey
struct ModifierKey_tCF1AD63897E47EB308093D5C9ECFD9335A084AE7 
{
	// System.Int32 Rewired.ModifierKey::value__
	int32_t ___value___2;
};

// Rewired.ModifierKeyFlags
struct ModifierKeyFlags_t43720ED61DD68C8412826524EE2D8A13A9108D61 
{
	// System.Int32 Rewired.ModifierKeyFlags::value__
	int32_t ___value___2;
};

// Rewired.Platforms.OSXStandalonePrimaryInputSource
struct OSXStandalonePrimaryInputSource_t07F71B7DAE41135B3A2B5BC6D162689EDAD47D39 
{
	// System.Int32 Rewired.Platforms.OSXStandalonePrimaryInputSource::value__
	int32_t ___value___2;
};

// Rewired.Platforms.PS4PrimaryInputSource
struct PS4PrimaryInputSource_t139990C73F83DF5110B7B7825CE3BB762C56E991 
{
	// System.Int32 Rewired.Platforms.PS4PrimaryInputSource::value__
	int32_t ___value___2;
};

// Rewired.Platforms.PS5PrimaryInputSource
struct PS5PrimaryInputSource_t8AB79773EA5B656EBD1EF4D4BE6D6C683B66E658 
{
	// System.Int32 Rewired.Platforms.PS5PrimaryInputSource::value__
	int32_t ___value___2;
};

// Rewired.Platforms.Platform
struct Platform_tE434287D5FAAE49534374FB4EE07A9A7EEC84B60 
{
	// System.Int32 Rewired.Platforms.Platform::value__
	int32_t ___value___2;
};

// Rewired.Pole
struct Pole_t753850F5C5B37E6A1F14AC631159E2359BC0F90D 
{
	// System.Int32 Rewired.Pole::value__
	int32_t ___value___2;
};

// System.RuntimeTypeHandle
struct RuntimeTypeHandle_t332A452B8B6179E4469B69525D0FE82A88030F7B 
{
	// System.IntPtr System.RuntimeTypeHandle::value
	intptr_t ___value_0;
};

// Rewired.Data.Mapping.SpecialAxisType
struct SpecialAxisType_t9C9F3B80DC0EDDDA13E45FA1942AB5ECA568CD8C 
{
	// System.Int32 Rewired.Data.Mapping.SpecialAxisType::value__
	int32_t ___value___2;
};

// Rewired.Platforms.StadiaPrimaryInputSource
struct StadiaPrimaryInputSource_t17B16F3D121111B85DEC048D260A79BF69D5D48A 
{
	// System.Int32 Rewired.Platforms.StadiaPrimaryInputSource::value__
	int32_t ___value___2;
};

// Rewired.Config.ThrottleCalibrationMode
struct ThrottleCalibrationMode_tD6E17F9D5067F268C81435F6CB1F6AA205CB4DAF 
{
	// System.Int32 Rewired.Config.ThrottleCalibrationMode::value__
	int32_t ___value___2;
};

// Rewired.Config.UpdateLoopSetting
struct UpdateLoopSetting_tA69EEF3F43D9CED577AF7DD8D7C7D0FE81268B28 
{
	// System.Int32 Rewired.Config.UpdateLoopSetting::value__
	int32_t ___value___2;
};

// Rewired.UpdateLoopType
struct UpdateLoopType_t54D15B6C8AD3EE8D49B68462CDC608A42F0359FB 
{
	// System.Int32 Rewired.UpdateLoopType::value__
	int32_t ___value___2;
};

// Rewired.Platforms.WebGLPrimaryInputSource
struct WebGLPrimaryInputSource_tFD9020E22F4DE8234FAB77030D52FA6741BE6BE0 
{
	// System.Int32 Rewired.Platforms.WebGLPrimaryInputSource::value__
	int32_t ___value___2;
};

// Rewired.Platforms.WebplayerPlatform
struct WebplayerPlatform_t4B3EEFC074B54E11E5F2D8034768A84C9B1192F3 
{
	// System.Int32 Rewired.Platforms.WebplayerPlatform::value__
	int32_t ___value___2;
};

// Rewired.Platforms.WindowsStandalonePrimaryInputSource
struct WindowsStandalonePrimaryInputSource_t0DD0C817417905511F803B64C9890462C6E6E561 
{
	// System.Int32 Rewired.Platforms.WindowsStandalonePrimaryInputSource::value__
	int32_t ___value___2;
};

// Rewired.Platforms.WindowsUWPPrimaryInputSource
struct WindowsUWPPrimaryInputSource_t61EF0956F532C6672A3D673CADAF4850B187B0AD 
{
	// System.Int32 Rewired.Platforms.WindowsUWPPrimaryInputSource::value__
	int32_t ___value___2;
};

// Rewired.Platforms.XboxOnePrimaryInputSource
struct XboxOnePrimaryInputSource_tF668A2B698F621DBBB2BA9D66DEDFA1C87CDC5AD 
{
	// System.Int32 Rewired.Platforms.XboxOnePrimaryInputSource::value__
	int32_t ___value___2;
};

// gPqZAArEBWUnolRtZlCKNFZvRLqr
struct gPqZAArEBWUnolRtZlCKNFZvRLqr_tF91080EAD5330A023C3CBFFB01A8F1A45A0BDC0A  : public SreStMNJSUKnhiFeYdCnZvaTqzgO_tCAADFAF41D7399BA1A417D5051C817A325FB955C
{
};

// lLgbcxLBAtuIApfgJDnOczdnMIEtA
struct lLgbcxLBAtuIApfgJDnOczdnMIEtA_tF4DA09D92CCBB0AE374311456418454DB8246747  : public SreStMNJSUKnhiFeYdCnZvaTqzgO_tCAADFAF41D7399BA1A417D5051C817A325FB955C
{
	// LooruOaGNVHUKdanwexEFBSWHmmS lLgbcxLBAtuIApfgJDnOczdnMIEtA::RUQHSdFIGfCbDRaPZcUStsJOVenb
	RuntimeObject* ___RUQHSdFIGfCbDRaPZcUStsJOVenb_5;
};

// UnityEngine.InputSystem.InputActionSetupExtensions/ControlSchemeSyntax
struct ControlSchemeSyntax_t4C14E0745C729675BFFADA8275391ACBAD73227D 
{
	// UnityEngine.InputSystem.InputActionAsset UnityEngine.InputSystem.InputActionSetupExtensions/ControlSchemeSyntax::m_Asset
	InputActionAsset_tF217AC5223B4AAA46EBCB44B33E9259FB117417D* ___m_Asset_0;
	// System.Int32 UnityEngine.InputSystem.InputActionSetupExtensions/ControlSchemeSyntax::m_ControlSchemeIndex
	int32_t ___m_ControlSchemeIndex_1;
	// UnityEngine.InputSystem.InputControlScheme UnityEngine.InputSystem.InputActionSetupExtensions/ControlSchemeSyntax::m_ControlScheme
	InputControlScheme_tB60FB32F414727140B32E1A0447679DC7ABC8434 ___m_ControlScheme_2;
};
// Native definition for P/Invoke marshalling of UnityEngine.InputSystem.InputActionSetupExtensions/ControlSchemeSyntax
struct ControlSchemeSyntax_t4C14E0745C729675BFFADA8275391ACBAD73227D_marshaled_pinvoke
{
	InputActionAsset_tF217AC5223B4AAA46EBCB44B33E9259FB117417D* ___m_Asset_0;
	int32_t ___m_ControlSchemeIndex_1;
	InputControlScheme_tB60FB32F414727140B32E1A0447679DC7ABC8434_marshaled_pinvoke ___m_ControlScheme_2;
};
// Native definition for COM marshalling of UnityEngine.InputSystem.InputActionSetupExtensions/ControlSchemeSyntax
struct ControlSchemeSyntax_t4C14E0745C729675BFFADA8275391ACBAD73227D_marshaled_com
{
	InputActionAsset_tF217AC5223B4AAA46EBCB44B33E9259FB117417D* ___m_Asset_0;
	int32_t ___m_ControlSchemeIndex_1;
	InputControlScheme_tB60FB32F414727140B32E1A0447679DC7ABC8434_marshaled_com ___m_ControlScheme_2;
};

// UnityEngine.InputSystem.InputBinding/Flags
struct Flags_t2ED4EFE461994B03533B3B524C8C2EA71315AAE6 
{
	// System.Int32 UnityEngine.InputSystem.InputBinding/Flags::value__
	int32_t ___value___2;
};

// UnityEngine.InputSystem.Layouts.InputControlLayout/Builder
struct Builder_t83F17A26F53DA7EA6D8C35E5C65C5DF0147E7821  : public RuntimeObject
{
	// System.String UnityEngine.InputSystem.Layouts.InputControlLayout/Builder::<name>k__BackingField
	String_t* ___U3CnameU3Ek__BackingField_0;
	// System.String UnityEngine.InputSystem.Layouts.InputControlLayout/Builder::<displayName>k__BackingField
	String_t* ___U3CdisplayNameU3Ek__BackingField_1;
	// System.Type UnityEngine.InputSystem.Layouts.InputControlLayout/Builder::<type>k__BackingField
	Type_t* ___U3CtypeU3Ek__BackingField_2;
	// UnityEngine.InputSystem.Utilities.FourCC UnityEngine.InputSystem.Layouts.InputControlLayout/Builder::<stateFormat>k__BackingField
	FourCC_tA6CAA4015BC25A7F1053B6C512202D57A9C994ED ___U3CstateFormatU3Ek__BackingField_3;
	// System.Int32 UnityEngine.InputSystem.Layouts.InputControlLayout/Builder::<stateSizeInBytes>k__BackingField
	int32_t ___U3CstateSizeInBytesU3Ek__BackingField_4;
	// System.String UnityEngine.InputSystem.Layouts.InputControlLayout/Builder::m_ExtendsLayout
	String_t* ___m_ExtendsLayout_5;
	// System.Nullable`1<System.Boolean> UnityEngine.InputSystem.Layouts.InputControlLayout/Builder::<updateBeforeRender>k__BackingField
	Nullable_1_t78F453FADB4A9F50F267A4E349019C34410D1A01 ___U3CupdateBeforeRenderU3Ek__BackingField_6;
	// System.Int32 UnityEngine.InputSystem.Layouts.InputControlLayout/Builder::m_ControlCount
	int32_t ___m_ControlCount_7;
	// UnityEngine.InputSystem.Layouts.InputControlLayout/ControlItem[] UnityEngine.InputSystem.Layouts.InputControlLayout/Builder::m_Controls
	ControlItemU5BU5D_t7798E8B7C7F58B8F6D13B567539CD82E962C7104* ___m_Controls_8;
};

// UnityEngine.InputSystem.Layouts.InputControlLayout/Flags
struct Flags_t193C2E9B0D9701ACB7ABD982BA8B3B2DB2F74230 
{
	// System.Int32 UnityEngine.InputSystem.Layouts.InputControlLayout/Flags::value__
	int32_t ___value___2;
};

// Rewired.InputMapper/ConflictResponse
struct ConflictResponse_tDA3CAF4051A6B9EE0B5B56491BEFE41982C90C5F 
{
	// System.Int32 Rewired.InputMapper/ConflictResponse::value__
	int32_t ___value___2;
};

// Rewired.InputMapper/JdpDLqzkBAGmKbSgujDlWammLWSdA
struct JdpDLqzkBAGmKbSgujDlWammLWSdA_t86A2F73B30F2AE967D7E754708734E6B37CEC905 
{
	// System.Int32 Rewired.InputMapper/JdpDLqzkBAGmKbSgujDlWammLWSdA::value__
	int32_t ___value___2;
};

// Rewired.InputMapper/Status
struct Status_t3A246E837E6A6123F5B82DB92D91EFA1A3055EBC 
{
	// System.Int32 Rewired.InputMapper/Status::value__
	int32_t ___value___2;
};

// slnZXWsjHVMgmJPfXBYLuaghszns/TpglccibZfOgeiyYDHnGNLANOPBl
struct TpglccibZfOgeiyYDHnGNLANOPBl_t16BCC66A98F4BBF6DC6806FC4D4AA679AD2B5245 
{
	// System.Int32 slnZXWsjHVMgmJPfXBYLuaghszns/TpglccibZfOgeiyYDHnGNLANOPBl::value__
	int32_t ___value___2;
};

// UnityEngine.InputSystem.InputActionRebindingExtensions/RebindingOperation/Flags
struct Flags_t1CB5B94A697E6B27C5E564B9BE5421010A992B3F 
{
	// System.Int32 UnityEngine.InputSystem.InputActionRebindingExtensions/RebindingOperation/Flags::value__
	int32_t ___value___2;
};

// Rewired.InputMapper/ukhpurvRuIKYVFmbrHGZXcVzGwlw/ZAvitiMprvVwWCIMvGocPBQgZtpb
struct ZAvitiMprvVwWCIMvGocPBQgZtpb_tF1DF68C194B192039034890FC4FDA7A5BC7E810C 
{
	// System.Int32 Rewired.InputMapper/ukhpurvRuIKYVFmbrHGZXcVzGwlw/ZAvitiMprvVwWCIMvGocPBQgZtpb::value__
	int32_t ___value___2;
};

// Rewired.Data.UserData/PMmfElSRTHipvrooOqnrsVzyuehD/kzedFdEdISaCJppRVzkSmhYBfiDK/CONyoCVDDnZOISeLTzDqTryyCphV
struct CONyoCVDDnZOISeLTzDqTryyCphV_t502BED7EB442D23A7F862E844D8169E7286BF7C2 
{
	// System.Int32 Rewired.Data.UserData/PMmfElSRTHipvrooOqnrsVzyuehD/kzedFdEdISaCJppRVzkSmhYBfiDK/CONyoCVDDnZOISeLTzDqTryyCphV::value__
	int32_t ___value___2;
};

// UnityEngine.InputSystem.Utilities.InlinedArray`1<System.Runtime.InteropServices.GCHandle>
struct InlinedArray_1_tD165225A32CD54B946FB419909F21C082C70A5B2 
{
	// System.Int32 UnityEngine.InputSystem.Utilities.InlinedArray`1::length
	int32_t ___length_0;
	// TValue UnityEngine.InputSystem.Utilities.InlinedArray`1::firstValue
	GCHandle_tC44F6F72EE68BD4CFABA24309DA7A179D41127DC ___firstValue_1;
	// TValue[] UnityEngine.InputSystem.Utilities.InlinedArray`1::additionalValues
	GCHandleU5BU5D_t7EA6F2FA83CDF86871001174CF7D30033AC4A785* ___additionalValues_2;
};

// Unity.Collections.NativeArray`1<System.UInt64>
struct NativeArray_1_t07975297AD7F7512193094A7C0703BA872EF7A7B 
{
	// System.Void* Unity.Collections.NativeArray`1::m_Buffer
	void* ___m_Buffer_0;
	// System.Int32 Unity.Collections.NativeArray`1::m_Length
	int32_t ___m_Length_1;
	// Unity.Collections.Allocator Unity.Collections.NativeArray`1::m_AllocatorLabel
	int32_t ___m_AllocatorLabel_2;
};

// TBSPGJPKaXrjsOpBQZPxJnrcfSfAA`1<System.Object>
struct TBSPGJPKaXrjsOpBQZPxJnrcfSfAA_1_t92F77A2C0897D802673079FA32163CACC9FD23DE  : public RuntimeObject
{
	// System.Collections.Generic.List`1<Rewired.ControllerMap> TBSPGJPKaXrjsOpBQZPxJnrcfSfAA`1::pNzKOGRtvmQWwYdVRwoTKHZVxBoe
	List_1_t2F083EFD818F84CF4216467CD6432E17EA0EAFB4* ___pNzKOGRtvmQWwYdVRwoTKHZVxBoe_0;
	// System.Collections.Generic.IList`1<Rewired.ControllerMap> TBSPGJPKaXrjsOpBQZPxJnrcfSfAA`1::NwiqNBnqHWKGjNKSdRAyEiLChIzd
	RuntimeObject* ___NwiqNBnqHWKGjNKSdRAyEiLChIzd_1;
	// Rewired.ControllerType TBSPGJPKaXrjsOpBQZPxJnrcfSfAA`1::FlMTEQmWOHVNzmnTpwqezeosKTre
	int32_t ___FlMTEQmWOHVNzmnTpwqezeosKTre_2;
	// System.Int32 TBSPGJPKaXrjsOpBQZPxJnrcfSfAA`1::NgYvqnovMkSRHVNEWEYzgQedwFde
	int32_t ___NgYvqnovMkSRHVNEWEYzgQedwFde_3;
	// System.Collections.Generic.List`1<?> TBSPGJPKaXrjsOpBQZPxJnrcfSfAA`1::xZknXaibuBjUlaKGkavRZlYzYvOv
	List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D* ___xZknXaibuBjUlaKGkavRZlYzYvOv_4;
	// System.Collections.Generic.IList`1<?> TBSPGJPKaXrjsOpBQZPxJnrcfSfAA`1::xfaoXdgWvusGEvpDOGftkKmRAFNVA
	RuntimeObject* ___xfaoXdgWvusGEvpDOGftkKmRAFNVA_5;
};

// Rewired.Player/ControllerHelper/bvHtPvdVkbINqyMOEkvOVjYbgQSB`2<System.Object,System.Object>
struct bvHtPvdVkbINqyMOEkvOVjYbgQSB_2_t60A1A6FC724CFAE71F8A6AFF7A7F6AC9F128037F  : public RuntimeObject
{
	// System.Collections.Generic.List`1<Rewired.Player/ControllerHelper/bvHtPvdVkbINqyMOEkvOVjYbgQSB`2/omlOoYqlQcXnMjOFbISaKckKLkeYA<?,?>> Rewired.Player/ControllerHelper/bvHtPvdVkbINqyMOEkvOVjYbgQSB`2::IvMWItGTIMgpzxlakIFhxQRLuqob
	List_1_tF5F4B8686D6D48B7DFE14C6BD921BC86DFACE7A9* ___IvMWItGTIMgpzxlakIFhxQRLuqob_0;
	// System.Collections.Generic.List`1<?> Rewired.Player/ControllerHelper/bvHtPvdVkbINqyMOEkvOVjYbgQSB`2::tYaSZwkKVLpMeAjYZSKFqfWLaiJC
	List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D* ___tYaSZwkKVLpMeAjYZSKFqfWLaiJC_1;
	// System.Collections.ObjectModel.ReadOnlyCollection`1<?> Rewired.Player/ControllerHelper/bvHtPvdVkbINqyMOEkvOVjYbgQSB`2::AzdykppksVcGhxxcVbJEiaQVeRiCA
	ReadOnlyCollection_1_t5397DF0DB61D1090E7BBC89395CECB8D020CED92* ___AzdykppksVcGhxxcVbJEiaQVeRiCA_2;
	// Rewired.ControllerType Rewired.Player/ControllerHelper/bvHtPvdVkbINqyMOEkvOVjYbgQSB`2::uXdofgxOYrPYUxRwFbcOtLnrtwQM
	int32_t ___uXdofgxOYrPYUxRwFbcOtLnrtwQM_3;
};

// Rewired.Data.UserData/PMmfElSRTHipvrooOqnrsVzyuehD/cTlcZwgBmjmwQjxeEhJdCJOLqDjC`1<System.Object>
struct cTlcZwgBmjmwQjxeEhJdCJOLqDjC_1_t00DEF10DFB18F406646ED696288655ED53671B85  : public RuntimeObject
{
	// ? Rewired.Data.UserData/PMmfElSRTHipvrooOqnrsVzyuehD/cTlcZwgBmjmwQjxeEhJdCJOLqDjC`1::ycylfGZkQYZLsmkzSDPTgBSCfYpR
	RuntimeObject* ___ycylfGZkQYZLsmkzSDPTgBSCfYpR_0;
	// ? Rewired.Data.UserData/PMmfElSRTHipvrooOqnrsVzyuehD/cTlcZwgBmjmwQjxeEhJdCJOLqDjC`1::jibeRAPVQsjIXkavALBbxCpQPlHP
	RuntimeObject* ___jibeRAPVQsjIXkavALBbxCpQPlHP_1;
	// Rewired.Data.UserData/PMmfElSRTHipvrooOqnrsVzyuehD/kzedFdEdISaCJppRVzkSmhYBfiDK/CONyoCVDDnZOISeLTzDqTryyCphV Rewired.Data.UserData/PMmfElSRTHipvrooOqnrsVzyuehD/cTlcZwgBmjmwQjxeEhJdCJOLqDjC`1::qapDwcBmHkNHjyhnhgUIXzBaVSSP
	int32_t ___qapDwcBmHkNHjyhnhgUIXzBaVSSP_2;
	// System.Collections.Generic.IList`1<?> Rewired.Data.UserData/PMmfElSRTHipvrooOqnrsVzyuehD/cTlcZwgBmjmwQjxeEhJdCJOLqDjC`1::PZmJBrkPtqspvDEXuRQFiLTDOmrB
	RuntimeObject* ___PZmJBrkPtqspvDEXuRQFiLTDOmrB_3;
	// System.Boolean Rewired.Data.UserData/PMmfElSRTHipvrooOqnrsVzyuehD/cTlcZwgBmjmwQjxeEhJdCJOLqDjC`1::MSFNDejRRUAmvrHnnMhlecjglmpU
	bool ___MSFNDejRRUAmvrHnnMhlecjglmpU_4;
};

// Rewired.ActionElementMap
struct ActionElementMap_t0EBE3E5D3A5DF3BA6D35F8082ED2232404EFF8CF  : public RuntimeObject
{
	// System.Int32 Rewired.ActionElementMap::_actionCategoryId
	int32_t ____actionCategoryId_0;
	// System.Int32 Rewired.ActionElementMap::_actionId
	int32_t ____actionId_1;
	// Rewired.ControllerElementType Rewired.ActionElementMap::_elementType
	int32_t ____elementType_2;
	// System.Int32 Rewired.ActionElementMap::_elementIdentifierId
	int32_t ____elementIdentifierId_3;
	// Rewired.AxisRange Rewired.ActionElementMap::_axisRange
	int32_t ____axisRange_4;
	// System.Boolean Rewired.ActionElementMap::_invert
	bool ____invert_5;
	// Rewired.Pole Rewired.ActionElementMap::_axisContribution
	int32_t ____axisContribution_6;
	// Rewired.KeyboardKeyCode Rewired.ActionElementMap::_keyboardKeyCode
	int32_t ____keyboardKeyCode_7;
	// Rewired.ModifierKey Rewired.ActionElementMap::_modifierKey1
	int32_t ____modifierKey1_8;
	// Rewired.ModifierKey Rewired.ActionElementMap::_modifierKey2
	int32_t ____modifierKey2_9;
	// Rewired.ModifierKey Rewired.ActionElementMap::_modifierKey3
	int32_t ____modifierKey3_10;
	// Rewired.ControllerMap Rewired.ActionElementMap::KcVwECPfnIdZspTPSjsPTIKVzXhj
	ControllerMap_tC01A582E577E38D21EB7D87A8C040AF5DA285FB3* ___KcVwECPfnIdZspTPSjsPTIKVzXhj_11;
	// System.Boolean Rewired.ActionElementMap::ITUIszRiaNrsImOTfgAHSPwPTOLe
	bool ___ITUIszRiaNrsImOTfgAHSPwPTOLe_12;
	// System.String Rewired.ActionElementMap::jbwTRqfqiqACQUTruPwbYnksYmwC
	String_t* ___jbwTRqfqiqACQUTruPwbYnksYmwC_13;
	// System.String Rewired.ActionElementMap::sUFbxreXOxfeGTyhVDXSewHmICtNA
	String_t* ___sUFbxreXOxfeGTyhVDXSewHmICtNA_14;
	// System.Int32 Rewired.ActionElementMap::zmFhEQUDPjAWQEDVHHgiGnzAJkVq
	int32_t ___zmFhEQUDPjAWQEDVHHgiGnzAJkVq_15;
	// System.Int32 Rewired.ActionElementMap::uiBcvtaHTXDhDgTmVOTVLzAJdhvt
	int32_t ___uiBcvtaHTXDhDgTmVOTVLzAJdhvt_16;
	// System.String Rewired.ActionElementMap::JmrfDGCSPNnNIHnRnJJUuzAyYnSqA
	String_t* ___JmrfDGCSPNnNIHnRnJJUuzAyYnSqA_17;
	// Rewired.ModifierKeyFlags Rewired.ActionElementMap::JxxYtkxxuhAOizovwtWBKsTRdbGA
	int32_t ___JxxYtkxxuhAOizovwtWBKsTRdbGA_18;
};

struct ActionElementMap_t0EBE3E5D3A5DF3BA6D35F8082ED2232404EFF8CF_StaticFields
{
	// System.Int32 Rewired.ActionElementMap::uidCounter
	int32_t ___uidCounter_19;
	// System.Text.StringBuilder Rewired.ActionElementMap::s_toStringSB
	StringBuilder_t* ___s_toStringSB_20;
};

// Rewired.AxisCalibration
struct AxisCalibration_t8B238ADDBAA0316E9708699644DA1CFF6EDBE66C  : public RuntimeObject
{
	// Rewired.Data.Mapping.AlternateAxisCalibrationType Rewired.AxisCalibration::_calibrationMode
	int32_t ____calibrationMode_0;
	// System.Collections.Generic.Dictionary`2<System.Int32,Rewired.Data.Mapping.AxisCalibrationInfo> Rewired.AxisCalibration::_hardwareCalibrations
	Dictionary_2_t227394DF2A4E3D645CB4EB5444857BABBB943E6D* ____hardwareCalibrations_1;
	// System.Boolean Rewired.AxisCalibration::_enabled
	bool ____enabled_2;
	// System.Single Rewired.AxisCalibration::_deadZone
	float ____deadZone_3;
	// System.Single Rewired.AxisCalibration::_calibratedZero
	float ____calibratedZero_4;
	// System.Single Rewired.AxisCalibration::_calibratedMin
	float ____calibratedMin_5;
	// System.Single Rewired.AxisCalibration::_calibratedMax
	float ____calibratedMax_6;
	// System.Boolean Rewired.AxisCalibration::_invert
	bool ____invert_7;
	// Rewired.AxisSensitivityType Rewired.AxisCalibration::_sensitivityType
	int32_t ____sensitivityType_8;
	// System.Single Rewired.AxisCalibration::_sensitivity
	float ____sensitivity_9;
	// UnityEngine.AnimationCurve Rewired.AxisCalibration::_sensitivityCurve
	AnimationCurve_tCBFFAAD05CEBB35EF8D8631BD99914BE1A6BB354* ____sensitivityCurve_10;
	// System.Boolean Rewired.AxisCalibration::_applyRangeCalibration
	bool ____applyRangeCalibration_11;
};

// Rewired.Data.ConfigVars
struct ConfigVars_t4EC82ACF63376F1869FDC3D0E223EDCE149CF4A3  : public RuntimeObject
{
	// Rewired.Config.UpdateLoopSetting Rewired.Data.ConfigVars::updateLoop
	int32_t ___updateLoop_0;
	// System.Boolean Rewired.Data.ConfigVars::alwaysUseUnityInput
	bool ___alwaysUseUnityInput_1;
	// Rewired.Platforms.WindowsStandalonePrimaryInputSource Rewired.Data.ConfigVars::windowsStandalonePrimaryInputSource
	int32_t ___windowsStandalonePrimaryInputSource_2;
	// Rewired.Platforms.OSXStandalonePrimaryInputSource Rewired.Data.ConfigVars::osx_primaryInputSource
	int32_t ___osx_primaryInputSource_3;
	// Rewired.Platforms.LinuxStandalonePrimaryInputSource Rewired.Data.ConfigVars::linux_primaryInputSource
	int32_t ___linux_primaryInputSource_4;
	// Rewired.Platforms.WindowsUWPPrimaryInputSource Rewired.Data.ConfigVars::windowsUWP_primaryInputSource
	int32_t ___windowsUWP_primaryInputSource_5;
	// Rewired.Platforms.XboxOnePrimaryInputSource Rewired.Data.ConfigVars::xboxOne_primaryInputSource
	int32_t ___xboxOne_primaryInputSource_6;
	// Rewired.Platforms.GameCoreXboxOnePrimaryInputSource Rewired.Data.ConfigVars::gameCoreXboxOne_primaryInputSource
	int32_t ___gameCoreXboxOne_primaryInputSource_7;
	// Rewired.Platforms.GameCoreScarlettPrimaryInputSource Rewired.Data.ConfigVars::gameCoreScarlett_primaryInputSource
	int32_t ___gameCoreScarlett_primaryInputSource_8;
	// Rewired.Platforms.PS4PrimaryInputSource Rewired.Data.ConfigVars::ps4_primaryInputSource
	int32_t ___ps4_primaryInputSource_9;
	// Rewired.Platforms.PS5PrimaryInputSource Rewired.Data.ConfigVars::ps5_primaryInputSource
	int32_t ___ps5_primaryInputSource_10;
	// Rewired.Platforms.WebGLPrimaryInputSource Rewired.Data.ConfigVars::webGL_primaryInputSource
	int32_t ___webGL_primaryInputSource_11;
	// Rewired.Platforms.StadiaPrimaryInputSource Rewired.Data.ConfigVars::stadia_primaryInputSource
	int32_t ___stadia_primaryInputSource_12;
	// System.Boolean Rewired.Data.ConfigVars::useXInput
	bool ___useXInput_13;
	// System.Boolean Rewired.Data.ConfigVars::useNativeMouse
	bool ___useNativeMouse_14;
	// System.Boolean Rewired.Data.ConfigVars::useEnhancedDeviceSupport
	bool ___useEnhancedDeviceSupport_15;
	// System.Boolean Rewired.Data.ConfigVars::windowsStandalone_useSteamRawInputControllerWorkaround
	bool ___windowsStandalone_useSteamRawInputControllerWorkaround_16;
	// System.Boolean Rewired.Data.ConfigVars::osxStandalone_useEnhancedDeviceSupport
	bool ___osxStandalone_useEnhancedDeviceSupport_17;
	// System.Boolean Rewired.Data.ConfigVars::android_supportUnknownGamepads
	bool ___android_supportUnknownGamepads_18;
	// System.Boolean Rewired.Data.ConfigVars::ps4_assignJoysticksByPS4JoyId
	bool ___ps4_assignJoysticksByPS4JoyId_19;
	// System.Boolean Rewired.Data.ConfigVars::useSteamControllerSupport
	bool ___useSteamControllerSupport_20;
	// System.Boolean Rewired.Data.ConfigVars::logToScreen
	bool ___logToScreen_21;
	// System.Boolean Rewired.Data.ConfigVars::runInEditMode
	bool ___runInEditMode_22;
	// System.Boolean Rewired.Data.ConfigVars::allowInputInEditorSceneView
	bool ___allowInputInEditorSceneView_23;
	// Rewired.Data.ConfigVars/PlatformVars_WindowsStandalone Rewired.Data.ConfigVars::platformVars_windowsStandalone
	PlatformVars_WindowsStandalone_t8800F0E9900A23B8CDDD65BC291F3A7955FFEA3A* ___platformVars_windowsStandalone_24;
	// Rewired.Data.ConfigVars/PlatformVars Rewired.Data.ConfigVars::platformVars_linuxStandalone
	PlatformVars_tF737B3A64AA3FC58BCFC8EE59301811595B60D87* ___platformVars_linuxStandalone_25;
	// Rewired.Data.ConfigVars/PlatformVars_OSXStandalone Rewired.Data.ConfigVars::platformVars_osxStandalone
	PlatformVars_OSXStandalone_t4A4F8397B2B479DA2FF2C79CF7971FD29FC61B04* ___platformVars_osxStandalone_26;
	// Rewired.Data.ConfigVars/PlatformVars_WindowsUWP Rewired.Data.ConfigVars::platformVars_windowsUWP
	PlatformVars_WindowsUWP_tCB23AF028BD504F84F9FBDDD4E6EDF89C942BD34* ___platformVars_windowsUWP_27;
	// Rewired.Data.ConfigVars/PlatformVars Rewired.Data.ConfigVars::platformVars_iOS
	PlatformVars_tF737B3A64AA3FC58BCFC8EE59301811595B60D87* ___platformVars_iOS_28;
	// Rewired.Data.ConfigVars/PlatformVars Rewired.Data.ConfigVars::platformVars_tvOS
	PlatformVars_tF737B3A64AA3FC58BCFC8EE59301811595B60D87* ___platformVars_tvOS_29;
	// Rewired.Data.ConfigVars/PlatformVars Rewired.Data.ConfigVars::platformVars_android
	PlatformVars_tF737B3A64AA3FC58BCFC8EE59301811595B60D87* ___platformVars_android_30;
	// Rewired.Data.ConfigVars/PlatformVars Rewired.Data.ConfigVars::platformVars_ps4
	PlatformVars_tF737B3A64AA3FC58BCFC8EE59301811595B60D87* ___platformVars_ps4_31;
	// Rewired.Data.ConfigVars/PlatformVars_PS5 Rewired.Data.ConfigVars::platformVars_ps5
	PlatformVars_PS5_t610DDC3CB70D06A2423ADB4F9E5D2664E0D7AADF* ___platformVars_ps5_32;
	// Rewired.Data.ConfigVars/PlatformVars Rewired.Data.ConfigVars::platformVars_psVita
	PlatformVars_tF737B3A64AA3FC58BCFC8EE59301811595B60D87* ___platformVars_psVita_33;
	// Rewired.Data.ConfigVars/PlatformVars Rewired.Data.ConfigVars::platformVars_xboxOne
	PlatformVars_tF737B3A64AA3FC58BCFC8EE59301811595B60D87* ___platformVars_xboxOne_34;
	// Rewired.Data.ConfigVars/PlatformVars_GameCoreXboxOne Rewired.Data.ConfigVars::platformVars_gameCoreXboxOne
	PlatformVars_GameCoreXboxOne_tCF651D8D1CCC76DFF542B0B5104C52697A459640* ___platformVars_gameCoreXboxOne_35;
	// Rewired.Data.ConfigVars/PlatformVars_GameCoreScarlett Rewired.Data.ConfigVars::platformVars_gameCoreScarlett
	PlatformVars_GameCoreScarlett_tAB9E09C9718FF0AA9DEA705CEDD000FE72593B7F* ___platformVars_gameCoreScarlett_36;
	// Rewired.Data.ConfigVars/PlatformVars Rewired.Data.ConfigVars::platformVars_switch
	PlatformVars_tF737B3A64AA3FC58BCFC8EE59301811595B60D87* ___platformVars_switch_37;
	// Rewired.Data.ConfigVars/PlatformVars Rewired.Data.ConfigVars::platformVars_webGL
	PlatformVars_tF737B3A64AA3FC58BCFC8EE59301811595B60D87* ___platformVars_webGL_38;
	// Rewired.Data.ConfigVars/PlatformVars_Stadia Rewired.Data.ConfigVars::platformVars_stadia
	PlatformVars_Stadia_t266E646AE50B1DB8A9B9208BDA8CFFE68E7D2ED2* ___platformVars_stadia_39;
	// Rewired.Data.ConfigVars/PlatformVars Rewired.Data.ConfigVars::platformVars_unknown
	PlatformVars_tF737B3A64AA3FC58BCFC8EE59301811595B60D87* ___platformVars_unknown_40;
	// System.Int32 Rewired.Data.ConfigVars::maxJoysticksPerPlayer
	int32_t ___maxJoysticksPerPlayer_41;
	// System.Boolean Rewired.Data.ConfigVars::autoAssignJoysticks
	bool ___autoAssignJoysticks_42;
	// System.Boolean Rewired.Data.ConfigVars::assignJoysticksToPlayingPlayersOnly
	bool ___assignJoysticksToPlayingPlayersOnly_43;
	// System.Boolean Rewired.Data.ConfigVars::distributeJoysticksEvenly
	bool ___distributeJoysticksEvenly_44;
	// System.Boolean Rewired.Data.ConfigVars::reassignJoystickToPreviousOwnerOnReconnect
	bool ___reassignJoystickToPreviousOwnerOnReconnect_45;
	// Rewired.DeadZone2DType Rewired.Data.ConfigVars::defaultJoystickAxis2DDeadZoneType
	int32_t ___defaultJoystickAxis2DDeadZoneType_46;
	// Rewired.AxisSensitivity2DType Rewired.Data.ConfigVars::defaultJoystickAxis2DSensitivityType
	int32_t ___defaultJoystickAxis2DSensitivityType_47;
	// Rewired.AxisSensitivityType Rewired.Data.ConfigVars::defaultAxisSensitivityType
	int32_t ___defaultAxisSensitivityType_48;
	// System.Boolean Rewired.Data.ConfigVars::force4WayHats
	bool ___force4WayHats_49;
	// Rewired.Config.ThrottleCalibrationMode Rewired.Data.ConfigVars::throttleCalibrationMode
	int32_t ___throttleCalibrationMode_50;
	// System.Boolean Rewired.Data.ConfigVars::activateActionButtonsOnNegativeValue
	bool ___activateActionButtonsOnNegativeValue_51;
	// System.Boolean Rewired.Data.ConfigVars::deferControllerConnectedEventsOnStart
	bool ___deferControllerConnectedEventsOnStart_52;
	// Rewired.Config.LogLevelFlags Rewired.Data.ConfigVars::logLevel
	int32_t ___logLevel_53;
	// Rewired.Data.ConfigVars/EditorVars Rewired.Data.ConfigVars::editorSettings
	EditorVars_t5AE2ADF7F0F42E42D3D477925DB1FE133ADAD682* ___editorSettings_54;
	// System.Collections.Generic.Dictionary`2<System.Int32,Rewired.Data.ConfigVars/cDbmxJFXWVduXCjwppwkvgZNqeHu> Rewired.Data.ConfigVars::__platformVarsDict
	Dictionary_2_tEA566EE4F7F044784DCA00DA5477CFA792068B8C* _____platformVarsDict_55;
	// System.Collections.Generic.Dictionary`2<System.Int32,Rewired.Data.ConfigVars/dwkgBlGxqjjCFmiEzxmVruJOuxuP> Rewired.Data.ConfigVars::__getSetPlatformVariableDict
	Dictionary_2_tF06E3E42A9CAE3A7EA4814D3F7EB70038D0F03EF* _____getSetPlatformVariableDict_56;
	// Rewired.Utils.Classes.Data.KeyedGetSetValueStore`1<System.String> Rewired.Data.ConfigVars::__configVarsValues
	KeyedGetSetValueStore_1_t42FBB8435F6E1317064A12E5096EAC021DF80045* _____configVarsValues_57;
	// System.Collections.Generic.Dictionary`2<System.String,System.Object> Rewired.Data.ConfigVars::__valueDelegates
	Dictionary_2_tA348003A3C1CEFB3096E9D2A0BC7F1AC8EC4F710* _____valueDelegates_58;
};

// Rewired.ControllerDataUpdater
struct ControllerDataUpdater_tEA424134962ED8FCA977957E8CAE6B6521D67788  : public RuntimeObject
{
	// Rewired.InputSource Rewired.ControllerDataUpdater::source
	int32_t ___source_0;
	// System.Int32 Rewired.ControllerDataUpdater::axisCount
	int32_t ___axisCount_1;
	// System.Int32 Rewired.ControllerDataUpdater::buttonCount
	int32_t ___buttonCount_2;
	// System.Single[] Rewired.ControllerDataUpdater::axisValues
	SingleU5BU5D_t89DEFE97BCEDB5857010E79ECE0F52CF6E93B87C* ___axisValues_3;
	// System.Boolean[] Rewired.ControllerDataUpdater::buttonValues
	BooleanU5BU5D_tD317D27C31DB892BE79FAE3AEBC0B3FFB73DE9B4* ___buttonValues_4;
	// System.Single[] Rewired.ControllerDataUpdater::buttonPressureValues
	SingleU5BU5D_t89DEFE97BCEDB5857010E79ECE0F52CF6E93B87C* ___buttonPressureValues_5;
	// System.Boolean[] Rewired.ControllerDataUpdater::axisHasBeenPressedOSXLinux
	BooleanU5BU5D_tD317D27C31DB892BE79FAE3AEBC0B3FFB73DE9B4* ___axisHasBeenPressedOSXLinux_6;
	// Rewired.UnknownControllerHat[] Rewired.ControllerDataUpdater::RzrJDIMNenxWAjHRAenlasVVPilE
	UnknownControllerHatU5BU5D_t28A26A414F3FB6A480708BC52C5DA8C9B0C72013* ___RzrJDIMNenxWAjHRAenlasVVPilE_7;
	// System.Boolean Rewired.ControllerDataUpdater::hasReceivedInput
	bool ___hasReceivedInput_8;
};

// Rewired.ControllerIdentifier
struct ControllerIdentifier_tB97D39E368F2473E38D5C32B427C7E929C905592 
{
	// System.Int32 Rewired.ControllerIdentifier::wovqMdREgMHEHAKFWnDLDuYilFZN
	int32_t ___wovqMdREgMHEHAKFWnDLDuYilFZN_0;
	// Rewired.ControllerType Rewired.ControllerIdentifier::uXdofgxOYrPYUxRwFbcOtLnrtwQM
	int32_t ___uXdofgxOYrPYUxRwFbcOtLnrtwQM_1;
	// System.Guid Rewired.ControllerIdentifier::VucGuTnWrLUexICHrMfuLpMDiPwB
	Guid_t ___VucGuTnWrLUexICHrMfuLpMDiPwB_2;
	// System.String Rewired.ControllerIdentifier::VOoFuFHNxirGIZyqlczoBmVHJBpH
	String_t* ___VOoFuFHNxirGIZyqlczoBmVHJBpH_3;
	// System.Guid Rewired.ControllerIdentifier::AdVWPVeeWREAKYnPcptASCNIkCUG
	Guid_t ___AdVWPVeeWREAKYnPcptASCNIkCUG_4;
};
// Native definition for P/Invoke marshalling of Rewired.ControllerIdentifier
struct ControllerIdentifier_tB97D39E368F2473E38D5C32B427C7E929C905592_marshaled_pinvoke
{
	int32_t ___wovqMdREgMHEHAKFWnDLDuYilFZN_0;
	int32_t ___uXdofgxOYrPYUxRwFbcOtLnrtwQM_1;
	Guid_t ___VucGuTnWrLUexICHrMfuLpMDiPwB_2;
	char* ___VOoFuFHNxirGIZyqlczoBmVHJBpH_3;
	Guid_t ___AdVWPVeeWREAKYnPcptASCNIkCUG_4;
};
// Native definition for COM marshalling of Rewired.ControllerIdentifier
struct ControllerIdentifier_tB97D39E368F2473E38D5C32B427C7E929C905592_marshaled_com
{
	int32_t ___wovqMdREgMHEHAKFWnDLDuYilFZN_0;
	int32_t ___uXdofgxOYrPYUxRwFbcOtLnrtwQM_1;
	Guid_t ___VucGuTnWrLUexICHrMfuLpMDiPwB_2;
	Il2CppChar* ___VOoFuFHNxirGIZyqlczoBmVHJBpH_3;
	Guid_t ___AdVWPVeeWREAKYnPcptASCNIkCUG_4;
};

// Rewired.ControllerMap
struct ControllerMap_tC01A582E577E38D21EB7D87A8C040AF5DA285FB3  : public RuntimeObject
{
	// System.Int32 Rewired.ControllerMap::_id
	int32_t ____id_0;
	// System.Int32 Rewired.ControllerMap::_sourceMapId
	int32_t ____sourceMapId_1;
	// System.Int32 Rewired.ControllerMap::_categoryId
	int32_t ____categoryId_2;
	// System.Int32 Rewired.ControllerMap::_layoutId
	int32_t ____layoutId_3;
	// System.String Rewired.ControllerMap::_name
	String_t* ____name_4;
	// System.Guid Rewired.ControllerMap::_hardwareGuid
	Guid_t ____hardwareGuid_5;
	// System.Boolean Rewired.ControllerMap::_enabled
	bool ____enabled_6;
	// System.Int32 Rewired.ControllerMap::eNyGUiEiMyquCTKLRhFvpeyOvzMm
	int32_t ___eNyGUiEiMyquCTKLRhFvpeyOvzMm_7;
	// Rewired.Utils.Classes.Data.AList`1<Rewired.ActionElementMap> Rewired.ControllerMap::tvTaSlZaJJsaHhTxcEdxOMRqgyDi
	AList_1_t26BA8BE4BEB503507B02BE892DA37BBBAA585997* ___tvTaSlZaJJsaHhTxcEdxOMRqgyDi_8;
	// System.Collections.ObjectModel.ReadOnlyCollection`1<Rewired.ActionElementMap> Rewired.ControllerMap::zPkhYeKAKTJBuzbXscEEzBRVCPcR
	ReadOnlyCollection_1_t4422A6B0A0A793D51A319B9A8A073733A2FACF05* ___zPkhYeKAKTJBuzbXscEEzBRVCPcR_9;
	// Rewired.Utils.Classes.Data.AList`1<Rewired.ActionElementMap> Rewired.ControllerMap::CGHcOmRSipXfGMFnwEHKevuNmNLUA
	AList_1_t26BA8BE4BEB503507B02BE892DA37BBBAA585997* ___CGHcOmRSipXfGMFnwEHKevuNmNLUA_10;
	// System.Collections.ObjectModel.ReadOnlyCollection`1<Rewired.ActionElementMap> Rewired.ControllerMap::IEBQoCgKRmtszWwQLyQNFcxpYgxg
	ReadOnlyCollection_1_t4422A6B0A0A793D51A319B9A8A073733A2FACF05* ___IEBQoCgKRmtszWwQLyQNFcxpYgxg_11;
	// System.Int32 Rewired.ControllerMap::_playerId
	int32_t ____playerId_12;
	// System.Int32 Rewired.ControllerMap::_controllerId
	int32_t ____controllerId_13;
	// Rewired.ControllerType Rewired.ControllerMap::_controllerType
	int32_t ____controllerType_14;
};

struct ControllerMap_tC01A582E577E38D21EB7D87A8C040AF5DA285FB3_StaticFields
{
	// System.Int32 Rewired.ControllerMap::dfkdFWaJIiiVPRSutzcNifMbAaHZA
	int32_t ___dfkdFWaJIiiVPRSutzcNifMbAaHZA_15;
};

// Rewired.ElementAssignment
struct ElementAssignment_t45CE7B6338F007990CB6929D43BCBCB4C84D8657 
{
	// Rewired.ElementAssignmentType Rewired.ElementAssignment::type
	int32_t ___type_0;
	// System.Int32 Rewired.ElementAssignment::elementMapId
	int32_t ___elementMapId_1;
	// System.Int32 Rewired.ElementAssignment::elementIdentifierId
	int32_t ___elementIdentifierId_2;
	// Rewired.AxisRange Rewired.ElementAssignment::axisRange
	int32_t ___axisRange_3;
	// UnityEngine.KeyCode Rewired.ElementAssignment::keyboardKey
	int32_t ___keyboardKey_4;
	// Rewired.ModifierKeyFlags Rewired.ElementAssignment::modifierKeyFlags
	int32_t ___modifierKeyFlags_5;
	// System.Int32 Rewired.ElementAssignment::actionId
	int32_t ___actionId_6;
	// Rewired.Pole Rewired.ElementAssignment::axisContribution
	int32_t ___axisContribution_7;
	// System.Boolean Rewired.ElementAssignment::invert
	bool ___invert_8;
};
// Native definition for P/Invoke marshalling of Rewired.ElementAssignment
struct ElementAssignment_t45CE7B6338F007990CB6929D43BCBCB4C84D8657_marshaled_pinvoke
{
	int32_t ___type_0;
	int32_t ___elementMapId_1;
	int32_t ___elementIdentifierId_2;
	int32_t ___axisRange_3;
	int32_t ___keyboardKey_4;
	int32_t ___modifierKeyFlags_5;
	int32_t ___actionId_6;
	int32_t ___axisContribution_7;
	int32_t ___invert_8;
};
// Native definition for COM marshalling of Rewired.ElementAssignment
struct ElementAssignment_t45CE7B6338F007990CB6929D43BCBCB4C84D8657_marshaled_com
{
	int32_t ___type_0;
	int32_t ___elementMapId_1;
	int32_t ___elementIdentifierId_2;
	int32_t ___axisRange_3;
	int32_t ___keyboardKey_4;
	int32_t ___modifierKeyFlags_5;
	int32_t ___actionId_6;
	int32_t ___axisContribution_7;
	int32_t ___invert_8;
};

// Rewired.ElementAssignmentConflictCheck
struct ElementAssignmentConflictCheck_tC22925257E88D3999FDD06C7ABF3B6CE6C09847E 
{
	// Rewired.ElementAssignmentType Rewired.ElementAssignmentConflictCheck::hZpvNjLicRabqamqNseMJpYCCNbIA
	int32_t ___hZpvNjLicRabqamqNseMJpYCCNbIA_0;
	// System.Int32 Rewired.ElementAssignmentConflictCheck::poRIGCSEughNfRYXWSqdxofgERiiA
	int32_t ___poRIGCSEughNfRYXWSqdxofgERiiA_1;
	// Rewired.ControllerType Rewired.ElementAssignmentConflictCheck::uXdofgxOYrPYUxRwFbcOtLnrtwQM
	int32_t ___uXdofgxOYrPYUxRwFbcOtLnrtwQM_2;
	// System.Int32 Rewired.ElementAssignmentConflictCheck::wovqMdREgMHEHAKFWnDLDuYilFZN
	int32_t ___wovqMdREgMHEHAKFWnDLDuYilFZN_3;
	// System.Int32 Rewired.ElementAssignmentConflictCheck::IuSWTyCEwxTphLVNpdlvWrKjDFGj
	int32_t ___IuSWTyCEwxTphLVNpdlvWrKjDFGj_4;
	// System.Int32 Rewired.ElementAssignmentConflictCheck::BVLEAOpnlCWLTSJLJiBFhzJTNjut
	int32_t ___BVLEAOpnlCWLTSJLJiBFhzJTNjut_5;
	// System.Int32 Rewired.ElementAssignmentConflictCheck::lZXeDRuUVgdzlcvHRyqDASfetfiq
	int32_t ___lZXeDRuUVgdzlcvHRyqDASfetfiq_6;
	// System.Int32 Rewired.ElementAssignmentConflictCheck::dDfetvBNteDTeczVYgZnpTDFdyZTA
	int32_t ___dDfetvBNteDTeczVYgZnpTDFdyZTA_7;
	// Rewired.AxisRange Rewired.ElementAssignmentConflictCheck::TUfMfJCvQwRlWQWmvQtAlTTmqfbC
	int32_t ___TUfMfJCvQwRlWQWmvQtAlTTmqfbC_8;
	// UnityEngine.KeyCode Rewired.ElementAssignmentConflictCheck::wphhsjozmzuKXddOdTEOdqtVXqjF
	int32_t ___wphhsjozmzuKXddOdTEOdqtVXqjF_9;
	// Rewired.ModifierKeyFlags Rewired.ElementAssignmentConflictCheck::VTgiPzuQKpZVCFqLcPPZPchaatQr
	int32_t ___VTgiPzuQKpZVCFqLcPPZPchaatQr_10;
	// System.Int32 Rewired.ElementAssignmentConflictCheck::jKZLhONJVjxMGJoFxnLBvfHJROqX
	int32_t ___jKZLhONJVjxMGJoFxnLBvfHJROqX_11;
	// Rewired.Pole Rewired.ElementAssignmentConflictCheck::SWbeDMcfuMiUORBksMkMeooXMTDcA
	int32_t ___SWbeDMcfuMiUORBksMkMeooXMTDcA_12;
	// System.Boolean Rewired.ElementAssignmentConflictCheck::wjumzoTfqqyyGTaozhcPHbRpEMeN
	bool ___wjumzoTfqqyyGTaozhcPHbRpEMeN_13;
};
// Native definition for P/Invoke marshalling of Rewired.ElementAssignmentConflictCheck
struct ElementAssignmentConflictCheck_tC22925257E88D3999FDD06C7ABF3B6CE6C09847E_marshaled_pinvoke
{
	int32_t ___hZpvNjLicRabqamqNseMJpYCCNbIA_0;
	int32_t ___poRIGCSEughNfRYXWSqdxofgERiiA_1;
	int32_t ___uXdofgxOYrPYUxRwFbcOtLnrtwQM_2;
	int32_t ___wovqMdREgMHEHAKFWnDLDuYilFZN_3;
	int32_t ___IuSWTyCEwxTphLVNpdlvWrKjDFGj_4;
	int32_t ___BVLEAOpnlCWLTSJLJiBFhzJTNjut_5;
	int32_t ___lZXeDRuUVgdzlcvHRyqDASfetfiq_6;
	int32_t ___dDfetvBNteDTeczVYgZnpTDFdyZTA_7;
	int32_t ___TUfMfJCvQwRlWQWmvQtAlTTmqfbC_8;
	int32_t ___wphhsjozmzuKXddOdTEOdqtVXqjF_9;
	int32_t ___VTgiPzuQKpZVCFqLcPPZPchaatQr_10;
	int32_t ___jKZLhONJVjxMGJoFxnLBvfHJROqX_11;
	int32_t ___SWbeDMcfuMiUORBksMkMeooXMTDcA_12;
	int32_t ___wjumzoTfqqyyGTaozhcPHbRpEMeN_13;
};
// Native definition for COM marshalling of Rewired.ElementAssignmentConflictCheck
struct ElementAssignmentConflictCheck_tC22925257E88D3999FDD06C7ABF3B6CE6C09847E_marshaled_com
{
	int32_t ___hZpvNjLicRabqamqNseMJpYCCNbIA_0;
	int32_t ___poRIGCSEughNfRYXWSqdxofgERiiA_1;
	int32_t ___uXdofgxOYrPYUxRwFbcOtLnrtwQM_2;
	int32_t ___wovqMdREgMHEHAKFWnDLDuYilFZN_3;
	int32_t ___IuSWTyCEwxTphLVNpdlvWrKjDFGj_4;
	int32_t ___BVLEAOpnlCWLTSJLJiBFhzJTNjut_5;
	int32_t ___lZXeDRuUVgdzlcvHRyqDASfetfiq_6;
	int32_t ___dDfetvBNteDTeczVYgZnpTDFdyZTA_7;
	int32_t ___TUfMfJCvQwRlWQWmvQtAlTTmqfbC_8;
	int32_t ___wphhsjozmzuKXddOdTEOdqtVXqjF_9;
	int32_t ___VTgiPzuQKpZVCFqLcPPZPchaatQr_10;
	int32_t ___jKZLhONJVjxMGJoFxnLBvfHJROqX_11;
	int32_t ___SWbeDMcfuMiUORBksMkMeooXMTDcA_12;
	int32_t ___wjumzoTfqqyyGTaozhcPHbRpEMeN_13;
};

// Rewired.ElementAssignmentConflictInfo
struct ElementAssignmentConflictInfo_t5BEF1917CC1F4A9E47FD362786C2F9A13BEDDEC2 
{
	// System.Boolean Rewired.ElementAssignmentConflictInfo::VEZJCjmasiBxwhmxHhAcQSLHGUUM
	bool ___VEZJCjmasiBxwhmxHhAcQSLHGUUM_0;
	// System.Boolean Rewired.ElementAssignmentConflictInfo::ADrhzjCddZwvoAyLfFOUeCguarFLA
	bool ___ADrhzjCddZwvoAyLfFOUeCguarFLA_1;
	// System.Int32 Rewired.ElementAssignmentConflictInfo::poRIGCSEughNfRYXWSqdxofgERiiA
	int32_t ___poRIGCSEughNfRYXWSqdxofgERiiA_2;
	// Rewired.ControllerType Rewired.ElementAssignmentConflictInfo::uXdofgxOYrPYUxRwFbcOtLnrtwQM
	int32_t ___uXdofgxOYrPYUxRwFbcOtLnrtwQM_3;
	// System.Int32 Rewired.ElementAssignmentConflictInfo::wovqMdREgMHEHAKFWnDLDuYilFZN
	int32_t ___wovqMdREgMHEHAKFWnDLDuYilFZN_4;
	// System.Int32 Rewired.ElementAssignmentConflictInfo::IuSWTyCEwxTphLVNpdlvWrKjDFGj
	int32_t ___IuSWTyCEwxTphLVNpdlvWrKjDFGj_5;
	// System.Int32 Rewired.ElementAssignmentConflictInfo::lZXeDRuUVgdzlcvHRyqDASfetfiq
	int32_t ___lZXeDRuUVgdzlcvHRyqDASfetfiq_6;
	// Rewired.ControllerElementType Rewired.ElementAssignmentConflictInfo::fdfPHrqgMMAtUtSYPWbnQLVzypzg
	int32_t ___fdfPHrqgMMAtUtSYPWbnQLVzypzg_7;
	// System.Int32 Rewired.ElementAssignmentConflictInfo::dDfetvBNteDTeczVYgZnpTDFdyZTA
	int32_t ___dDfetvBNteDTeczVYgZnpTDFdyZTA_8;
	// UnityEngine.KeyCode Rewired.ElementAssignmentConflictInfo::sgekfAUEmxQmUePkTQHBKvMJUHOm
	int32_t ___sgekfAUEmxQmUePkTQHBKvMJUHOm_9;
	// Rewired.ModifierKeyFlags Rewired.ElementAssignmentConflictInfo::VTgiPzuQKpZVCFqLcPPZPchaatQr
	int32_t ___VTgiPzuQKpZVCFqLcPPZPchaatQr_10;
	// System.Int32 Rewired.ElementAssignmentConflictInfo::jKZLhONJVjxMGJoFxnLBvfHJROqX
	int32_t ___jKZLhONJVjxMGJoFxnLBvfHJROqX_11;
};
// Native definition for P/Invoke marshalling of Rewired.ElementAssignmentConflictInfo
struct ElementAssignmentConflictInfo_t5BEF1917CC1F4A9E47FD362786C2F9A13BEDDEC2_marshaled_pinvoke
{
	int32_t ___VEZJCjmasiBxwhmxHhAcQSLHGUUM_0;
	int32_t ___ADrhzjCddZwvoAyLfFOUeCguarFLA_1;
	int32_t ___poRIGCSEughNfRYXWSqdxofgERiiA_2;
	int32_t ___uXdofgxOYrPYUxRwFbcOtLnrtwQM_3;
	int32_t ___wovqMdREgMHEHAKFWnDLDuYilFZN_4;
	int32_t ___IuSWTyCEwxTphLVNpdlvWrKjDFGj_5;
	int32_t ___lZXeDRuUVgdzlcvHRyqDASfetfiq_6;
	int32_t ___fdfPHrqgMMAtUtSYPWbnQLVzypzg_7;
	int32_t ___dDfetvBNteDTeczVYgZnpTDFdyZTA_8;
	int32_t ___sgekfAUEmxQmUePkTQHBKvMJUHOm_9;
	int32_t ___VTgiPzuQKpZVCFqLcPPZPchaatQr_10;
	int32_t ___jKZLhONJVjxMGJoFxnLBvfHJROqX_11;
};
// Native definition for COM marshalling of Rewired.ElementAssignmentConflictInfo
struct ElementAssignmentConflictInfo_t5BEF1917CC1F4A9E47FD362786C2F9A13BEDDEC2_marshaled_com
{
	int32_t ___VEZJCjmasiBxwhmxHhAcQSLHGUUM_0;
	int32_t ___ADrhzjCddZwvoAyLfFOUeCguarFLA_1;
	int32_t ___poRIGCSEughNfRYXWSqdxofgERiiA_2;
	int32_t ___uXdofgxOYrPYUxRwFbcOtLnrtwQM_3;
	int32_t ___wovqMdREgMHEHAKFWnDLDuYilFZN_4;
	int32_t ___IuSWTyCEwxTphLVNpdlvWrKjDFGj_5;
	int32_t ___lZXeDRuUVgdzlcvHRyqDASfetfiq_6;
	int32_t ___fdfPHrqgMMAtUtSYPWbnQLVzypzg_7;
	int32_t ___dDfetvBNteDTeczVYgZnpTDFdyZTA_8;
	int32_t ___sgekfAUEmxQmUePkTQHBKvMJUHOm_9;
	int32_t ___VTgiPzuQKpZVCFqLcPPZPchaatQr_10;
	int32_t ___jKZLhONJVjxMGJoFxnLBvfHJROqX_11;
};

// FeaiSQbvxYDTMImoDmlvhGnyLumi
struct FeaiSQbvxYDTMImoDmlvhGnyLumi_tB82E59EB263DBCCD7452BF39256B26197DD5299C  : public RuntimeObject
{
	// System.Single FeaiSQbvxYDTMImoDmlvhGnyLumi::SHVspNkbPzieDmSaNsxoePExLrRC
	float ___SHVspNkbPzieDmSaNsxoePExLrRC_0;
	// Rewired.ButtonStateFlags FeaiSQbvxYDTMImoDmlvhGnyLumi::svWjsaKEZlowJodIYNTRlQxLKvYi
	int32_t ___svWjsaKEZlowJodIYNTRlQxLKvYi_1;
	// Rewired.ControllerElementType FeaiSQbvxYDTMImoDmlvhGnyLumi::uLwgdeVFkwbalOghhEhuZfZRPruR
	int32_t ___uLwgdeVFkwbalOghhEhuZfZRPruR_2;
	// Rewired.ControllerType FeaiSQbvxYDTMImoDmlvhGnyLumi::FlMTEQmWOHVNzmnTpwqezeosKTre
	int32_t ___FlMTEQmWOHVNzmnTpwqezeosKTre_3;
	// Rewired.Controller FeaiSQbvxYDTMImoDmlvhGnyLumi::qqrQldxbErvVtpNyQAtEGvvTTIMe
	Controller_t919A4A50FC7A0F25D7B31615C0F4E4D4A4D17911* ___qqrQldxbErvVtpNyQAtEGvvTTIMe_4;
	// Rewired.ControllerMap FeaiSQbvxYDTMImoDmlvhGnyLumi::GrAwOHyDGcOocdkygeijDogwNaVr
	ControllerMap_tC01A582E577E38D21EB7D87A8C040AF5DA285FB3* ___GrAwOHyDGcOocdkygeijDogwNaVr_5;
	// Rewired.ActionElementMap FeaiSQbvxYDTMImoDmlvhGnyLumi::qghidDgYDpANqWKwkwCriPSDATeV
	ActionElementMap_t0EBE3E5D3A5DF3BA6D35F8082ED2232404EFF8CF* ___qghidDgYDpANqWKwkwCriPSDATeV_6;
	// System.Int32 FeaiSQbvxYDTMImoDmlvhGnyLumi::MwXqYcbZROplDbIqxGjWJZluHnKT
	int32_t ___MwXqYcbZROplDbIqxGjWJZluHnKT_7;
	// System.Boolean FeaiSQbvxYDTMImoDmlvhGnyLumi::zKxBPwIJEgjAeutYdHkdyITSCKGQA
	bool ___zKxBPwIJEgjAeutYdHkdyITSCKGQA_8;
	// System.Boolean FeaiSQbvxYDTMImoDmlvhGnyLumi::WdhPBPdalRyBsdzTuacSOPnDtysh
	bool ___WdhPBPdalRyBsdzTuacSOPnDtysh_9;
	// Rewired.AxisCoordinateMode FeaiSQbvxYDTMImoDmlvhGnyLumi::cYrMjjgdqZyGFkCpgBgkIoPtJzDfb
	int32_t ___cYrMjjgdqZyGFkCpgBgkIoPtJzDfb_10;
};

// Rewired.Data.Mapping.HardwareAxisInfo
struct HardwareAxisInfo_t263803B756A1948668029834C5B184A5590B0654  : public RuntimeObject
{
	// Rewired.AxisCoordinateMode Rewired.Data.Mapping.HardwareAxisInfo::_dataFormat
	int32_t ____dataFormat_0;
	// System.Boolean Rewired.Data.Mapping.HardwareAxisInfo::_excludeFromPolling
	bool ____excludeFromPolling_1;
	// Rewired.Data.Mapping.SpecialAxisType Rewired.Data.Mapping.HardwareAxisInfo::_specialAxisType
	int32_t ____specialAxisType_2;
	// System.Single Rewired.Data.Mapping.HardwareAxisInfo::_pollingDeadZone
	float ____pollingDeadZone_3;
};

// UnityEngine.InputSystem.InputBinding
struct InputBinding_t0D75BD1538CF81D29450D568D5C938E111633EC5 
{
	// System.String UnityEngine.InputSystem.InputBinding::m_Name
	String_t* ___m_Name_2;
	// System.String UnityEngine.InputSystem.InputBinding::m_Id
	String_t* ___m_Id_3;
	// System.String UnityEngine.InputSystem.InputBinding::m_Path
	String_t* ___m_Path_4;
	// System.String UnityEngine.InputSystem.InputBinding::m_Interactions
	String_t* ___m_Interactions_5;
	// System.String UnityEngine.InputSystem.InputBinding::m_Processors
	String_t* ___m_Processors_6;
	// System.String UnityEngine.InputSystem.InputBinding::m_Groups
	String_t* ___m_Groups_7;
	// System.String UnityEngine.InputSystem.InputBinding::m_Action
	String_t* ___m_Action_8;
	// UnityEngine.InputSystem.InputBinding/Flags UnityEngine.InputSystem.InputBinding::m_Flags
	int32_t ___m_Flags_9;
	// System.String UnityEngine.InputSystem.InputBinding::m_OverridePath
	String_t* ___m_OverridePath_10;
	// System.String UnityEngine.InputSystem.InputBinding::m_OverrideInteractions
	String_t* ___m_OverrideInteractions_11;
	// System.String UnityEngine.InputSystem.InputBinding::m_OverrideProcessors
	String_t* ___m_OverrideProcessors_12;
};
// Native definition for P/Invoke marshalling of UnityEngine.InputSystem.InputBinding
struct InputBinding_t0D75BD1538CF81D29450D568D5C938E111633EC5_marshaled_pinvoke
{
	char* ___m_Name_2;
	char* ___m_Id_3;
	char* ___m_Path_4;
	char* ___m_Interactions_5;
	char* ___m_Processors_6;
	char* ___m_Groups_7;
	char* ___m_Action_8;
	int32_t ___m_Flags_9;
	char* ___m_OverridePath_10;
	char* ___m_OverrideInteractions_11;
	char* ___m_OverrideProcessors_12;
};
// Native definition for COM marshalling of UnityEngine.InputSystem.InputBinding
struct InputBinding_t0D75BD1538CF81D29450D568D5C938E111633EC5_marshaled_com
{
	Il2CppChar* ___m_Name_2;
	Il2CppChar* ___m_Id_3;
	Il2CppChar* ___m_Path_4;
	Il2CppChar* ___m_Interactions_5;
	Il2CppChar* ___m_Processors_6;
	Il2CppChar* ___m_Groups_7;
	Il2CppChar* ___m_Action_8;
	int32_t ___m_Flags_9;
	Il2CppChar* ___m_OverridePath_10;
	Il2CppChar* ___m_OverrideInteractions_11;
	Il2CppChar* ___m_OverrideProcessors_12;
};

// UnityEngine.InputSystem.Layouts.InputControlLayout
struct InputControlLayout_t46A40BE4C976BE33E85F61E63EB34323FED9831D  : public RuntimeObject
{
	// UnityEngine.InputSystem.Utilities.InternedString UnityEngine.InputSystem.Layouts.InputControlLayout::m_Name
	InternedString_t8D62A48CB7D85AAE9CFCCCFB0A77AC2844905735 ___m_Name_2;
	// System.Type UnityEngine.InputSystem.Layouts.InputControlLayout::m_Type
	Type_t* ___m_Type_3;
	// UnityEngine.InputSystem.Utilities.InternedString UnityEngine.InputSystem.Layouts.InputControlLayout::m_Variants
	InternedString_t8D62A48CB7D85AAE9CFCCCFB0A77AC2844905735 ___m_Variants_4;
	// UnityEngine.InputSystem.Utilities.FourCC UnityEngine.InputSystem.Layouts.InputControlLayout::m_StateFormat
	FourCC_tA6CAA4015BC25A7F1053B6C512202D57A9C994ED ___m_StateFormat_5;
	// System.Int32 UnityEngine.InputSystem.Layouts.InputControlLayout::m_StateSizeInBytes
	int32_t ___m_StateSizeInBytes_6;
	// System.Nullable`1<System.Boolean> UnityEngine.InputSystem.Layouts.InputControlLayout::m_UpdateBeforeRender
	Nullable_1_t78F453FADB4A9F50F267A4E349019C34410D1A01 ___m_UpdateBeforeRender_7;
	// UnityEngine.InputSystem.Utilities.InlinedArray`1<UnityEngine.InputSystem.Utilities.InternedString> UnityEngine.InputSystem.Layouts.InputControlLayout::m_BaseLayouts
	InlinedArray_1_tAFDFE0972A71B9760077CFA9D4A1DBD7BE435800 ___m_BaseLayouts_8;
	// UnityEngine.InputSystem.Utilities.InlinedArray`1<UnityEngine.InputSystem.Utilities.InternedString> UnityEngine.InputSystem.Layouts.InputControlLayout::m_AppliedOverrides
	InlinedArray_1_tAFDFE0972A71B9760077CFA9D4A1DBD7BE435800 ___m_AppliedOverrides_9;
	// UnityEngine.InputSystem.Utilities.InternedString[] UnityEngine.InputSystem.Layouts.InputControlLayout::m_CommonUsages
	InternedStringU5BU5D_t0B851758733FC0B118D84BE83AED10A0404C18D5* ___m_CommonUsages_10;
	// UnityEngine.InputSystem.Layouts.InputControlLayout/ControlItem[] UnityEngine.InputSystem.Layouts.InputControlLayout::m_Controls
	ControlItemU5BU5D_t7798E8B7C7F58B8F6D13B567539CD82E962C7104* ___m_Controls_11;
	// System.String UnityEngine.InputSystem.Layouts.InputControlLayout::m_DisplayName
	String_t* ___m_DisplayName_12;
	// System.String UnityEngine.InputSystem.Layouts.InputControlLayout::m_Description
	String_t* ___m_Description_13;
	// UnityEngine.InputSystem.Layouts.InputControlLayout/Flags UnityEngine.InputSystem.Layouts.InputControlLayout::m_Flags
	int32_t ___m_Flags_14;
};

struct InputControlLayout_t46A40BE4C976BE33E85F61E63EB34323FED9831D_StaticFields
{
	// UnityEngine.InputSystem.Utilities.InternedString UnityEngine.InputSystem.Layouts.InputControlLayout::s_DefaultVariant
	InternedString_t8D62A48CB7D85AAE9CFCCCFB0A77AC2844905735 ___s_DefaultVariant_0;
	// UnityEngine.InputSystem.Layouts.InputControlLayout/Collection UnityEngine.InputSystem.Layouts.InputControlLayout::s_Layouts
	Collection_t6E9F85AD439CF26269683541C4DC58BA3B6756C5 ___s_Layouts_15;
	// UnityEngine.InputSystem.Layouts.InputControlLayout/Cache UnityEngine.InputSystem.Layouts.InputControlLayout::s_CacheInstance
	Cache_tB837109647F577DCE3795AEE2E9E0E3F61F543AB ___s_CacheInstance_16;
	// System.Int32 UnityEngine.InputSystem.Layouts.InputControlLayout::s_CacheInstanceRef
	int32_t ___s_CacheInstanceRef_17;
};

// System.MulticastDelegate
struct MulticastDelegate_t  : public Delegate_t
{
	// System.Delegate[] System.MulticastDelegate::delegates
	DelegateU5BU5D_tC5AB7E8F745616680F337909D3A8E6C722CDF771* ___delegates_13;
};
// Native definition for P/Invoke marshalling of System.MulticastDelegate
struct MulticastDelegate_t_marshaled_pinvoke : public Delegate_t_marshaled_pinvoke
{
	Delegate_t_marshaled_pinvoke** ___delegates_13;
};
// Native definition for COM marshalling of System.MulticastDelegate
struct MulticastDelegate_t_marshaled_com : public Delegate_t_marshaled_com
{
	Delegate_t_marshaled_com** ___delegates_13;
};

// Rewired.ReInput
struct ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0  : public RuntimeObject
{
};

struct ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_StaticFields
{
	// Rewired.InputManager_Base Rewired.ReInput::jkoozXBewKZItYIwtQBriJXCWaDO
	InputManager_Base_t1C60AC2E6C7F7EE7CC5B91EE4149AD5BE14058D0* ___jkoozXBewKZItYIwtQBriJXCWaDO_7;
	// Rewired.PlatformInputManager Rewired.ReInput::kcuOIpNKBatckwJBgGRCgwSbHyPi
	PlatformInputManager_t0589A7C9789B19DE7D2560BDE9C72EA3214B3786* ___kcuOIpNKBatckwJBgGRCgwSbHyPi_8;
	// JfVkiPqxuvjpxOenWaPbtdnpqNrC Rewired.ReInput::ksfehWcJeyrOvFtcfltlJWjYBpUz
	JfVkiPqxuvjpxOenWaPbtdnpqNrC_tAD3EC599BD987C8364327BCCAE0346D20C00C8F9* ___ksfehWcJeyrOvFtcfltlJWjYBpUz_9;
	// TAqjagBhKGcWECRbpfkHPNKbpxLsA Rewired.ReInput::pufaEMRhTHuKQfVnvkQxbbFTmmTc
	TAqjagBhKGcWECRbpfkHPNKbpxLsA_t5B25C84F87417D98CA0E8452EAD0DB3A23D7833A* ___pufaEMRhTHuKQfVnvkQxbbFTmmTc_10;
	// rlfXkJTrHZdpPrmFzvJfeOpwdxFF Rewired.ReInput::RzBxphZmIoCHLXRoGvldiqxCEgwD
	rlfXkJTrHZdpPrmFzvJfeOpwdxFF_t92D577FF2385AF1C7F87003759294BE9754F3ABD* ___RzBxphZmIoCHLXRoGvldiqxCEgwD_11;
	// Rewired.Data.ControllerDataFiles Rewired.ReInput::LLqsRflfadBeGbIkqRikKTjJofTjA
	ControllerDataFiles_t599A8EBC3214904D6DEEFD99921E121F8CA6C2A7* ___LLqsRflfadBeGbIkqRikKTjJofTjA_12;
	// Rewired.Data.UserData Rewired.ReInput::APxYupdeVaIOAsHOzvIIrNRoEHuk
	UserData_tA3822AFC104037490B294D0A972ABFAF6DF9C154* ___APxYupdeVaIOAsHOzvIIrNRoEHuk_13;
	// System.Boolean Rewired.ReInput::YkkXuoObeMHDnWDVivioeeRcGUPj
	bool ___YkkXuoObeMHDnWDVivioeeRcGUPj_14;
	// Rewired.Data.ConfigVars Rewired.ReInput::yKydsvixPcQdBIlgvxotXrJTbkcL
	ConfigVars_t4EC82ACF63376F1869FDC3D0E223EDCE149CF4A3* ___yKydsvixPcQdBIlgvxotXrJTbkcL_15;
	// Rewired.UpdateLoopType Rewired.ReInput::xLTAJyILitkXslAgOitHunIDBnsW
	int32_t ___xLTAJyILitkXslAgOitHunIDBnsW_16;
	// System.Boolean Rewired.ReInput::CPhHdGgouqFOShSRDZGWuqKXSAqcA
	bool ___CPhHdGgouqFOShSRDZGWuqKXSAqcA_17;
	// Rewired.Platforms.Platform Rewired.ReInput::CVmvJnFuxaglaEewBpcLpPIdHKGy
	int32_t ___CVmvJnFuxaglaEewBpcLpPIdHKGy_18;
	// Rewired.Platforms.WebplayerPlatform Rewired.ReInput::yfEeWNJEztkeSZLCedwYCIRUPgke
	int32_t ___yfEeWNJEztkeSZLCedwYCIRUPgke_19;
	// Rewired.Platforms.EditorPlatform Rewired.ReInput::EVRidQxdPrqOUltXSWFOQjCysaDc
	int32_t ___EVRidQxdPrqOUltXSWFOQjCysaDc_20;
	// System.Boolean Rewired.ReInput::AEdYNkqqTPEJRVDTimESRSMaOAbu
	bool ___AEdYNkqqTPEJRVDTimESRSMaOAbu_21;
	// Rewired.Utils.Classes.Utility.TimerAbs Rewired.ReInput::xVCLbFdTdLnVAbcGMXQAuRqgnmvi
	TimerAbs_t49C1588F0A9377F7A54285F7C44A6591FBA42E36* ___xVCLbFdTdLnVAbcGMXQAuRqgnmvi_22;
	// Rewired.ReInput/VGGFRlKCiDzJEBFzELCBbDLbrdNsb Rewired.ReInput::uQSKATTlkhPlVVKUIrtiTKmgJZXf
	VGGFRlKCiDzJEBFzELCBbDLbrdNsb_t5447C7DA708D817444C5DB41FA444E0A819CEB0F* ___uQSKATTlkhPlVVKUIrtiTKmgJZXf_23;
	// System.String Rewired.ReInput::ILDTdDYauZvhnQGLfXaeBqiEBJWbA
	String_t* ___ILDTdDYauZvhnQGLfXaeBqiEBJWbA_24;
	// System.Boolean Rewired.ReInput::VRbNLBhrJoMQXRoZDdNPGzoXYiUeA
	bool ___VRbNLBhrJoMQXRoZDdNPGzoXYiUeA_25;
	// System.Boolean Rewired.ReInput::oXnIjAacIaZfDDOuKficztONZJcU
	bool ___oXnIjAacIaZfDDOuKficztONZJcU_26;
	// System.Boolean Rewired.ReInput::KTzCNAMDVwddYjayrUIynSMAJXkU
	bool ___KTzCNAMDVwddYjayrUIynSMAJXkU_27;
	// System.Int32 Rewired.ReInput::gVSYLUDKgeyZgUFQITtxlwqocTGL
	int32_t ___gVSYLUDKgeyZgUFQITtxlwqocTGL_28;
	// System.Int32 Rewired.ReInput::_id
	int32_t ____id_29;
	// System.Int32 Rewired.ReInput::YPAejysmgoHSqqdlXexSNcdonGQF
	int32_t ___YPAejysmgoHSqqdlXexSNcdonGQF_30;
	// System.Int32 Rewired.ReInput::uRQjOtWBefPkoUHCLLkbMBMWFeucA
	int32_t ___uRQjOtWBefPkoUHCLLkbMBMWFeucA_31;
	// System.Boolean Rewired.ReInput::tOkZXKHYttsFNppBtdSKgRNmExzhA
	bool ___tOkZXKHYttsFNppBtdSKgRNmExzhA_32;
	// Rewired.ReInput/UnityTouch Rewired.ReInput::EBWCAQeGjBsUAJCdlwimiQBBaLQiA
	UnityTouch_t2075B37418F4CC7F686589B5EA9722FE1E0606FF* ___EBWCAQeGjBsUAJCdlwimiQBBaLQiA_33;
	// Rewired.ReInput/PlayerHelper Rewired.ReInput::sTrVDmgqeoKTZKLQWAnJfzMZHxzZ
	PlayerHelper_t96BC8DE1C94717C98B253F25C7B9C82639E4BF5C* ___sTrVDmgqeoKTZKLQWAnJfzMZHxzZ_34;
	// Rewired.ReInput/ControllerHelper Rewired.ReInput::eCiGKRaLTZZPnGLXtQIuxlbTsIZW
	ControllerHelper_t470828F1E9094A484F8FE12DB16199890DF23F5E* ___eCiGKRaLTZZPnGLXtQIuxlbTsIZW_35;
	// Rewired.ReInput/MappingHelper Rewired.ReInput::AyeOHdSQapsGSyJUECHqHIJRgfVCA
	MappingHelper_t18AE344473D49AF2E7133108678DD4D963699662* ___AyeOHdSQapsGSyJUECHqHIJRgfVCA_36;
	// Rewired.ReInput/TimeHelper Rewired.ReInput::QTiWWnfoMljUSnmdGURNCSBlTtJl
	TimeHelper_t69098AFC84A038B0FE6C972CB520EA302C841355* ___QTiWWnfoMljUSnmdGURNCSBlTtJl_37;
	// Rewired.ReInput/ConfigHelper Rewired.ReInput::LUsLdalNampMTBgXenCrwdGwXRlw
	ConfigHelper_t04A7167E7755E054F63F8B27CB10FE618D85F8BD* ___LUsLdalNampMTBgXenCrwdGwXRlw_38;
	// oRzHnFZUZWhymZfQjayJtJujzGt Rewired.ReInput::SfXUYqoHcOdUgBrXkdpJfBNaTtNX
	oRzHnFZUZWhymZfQjayJtJujzGt_t387519A4B76739FFC49C8E3D119FA67A0FA7CBC0* ___SfXUYqoHcOdUgBrXkdpJfBNaTtNX_39;
	// Rewired.Data.UserDataStore Rewired.ReInput::hhayUvnqBsGXoWBUjCLliCLLPOajA
	UserDataStore_t7FFC8F030F5FF0B24856473F6CDBD9CC62CBBEF2* ___hhayUvnqBsGXoWBUjCLliCLLPOajA_40;
	// Rewired.Interfaces.IControllerAssigner Rewired.ReInput::ksthrVMePXNiGlIeRykuUGDOSCrU
	RuntimeObject* ___ksthrVMePXNiGlIeRykuUGDOSCrU_41;
	// Rewired.ReInput/yRMIEBZWdRbQqWIebbpueNjshnqb Rewired.ReInput::yNkbbgMbnbErnmCxlazUCYQkOwANA
	yRMIEBZWdRbQqWIebbpueNjshnqb_tA22AE88E0F0DE7D24F950F81D54AA2EEA22B039B* ___yNkbbgMbnbErnmCxlazUCYQkOwANA_42;
	// Rewired.Utils.SafeAction`1<Rewired.ControllerStatusChangedEventArgs> Rewired.ReInput::SPBWBREKCtHGdzoCNOpcvEqGAzAt
	SafeAction_1_t6295D5E01D7944A8AEE5D1336EA31C2C3721C004* ___SPBWBREKCtHGdzoCNOpcvEqGAzAt_43;
	// Rewired.Utils.SafeAction`1<Rewired.ControllerStatusChangedEventArgs> Rewired.ReInput::ffNDXtGVGSllVFwxOsKpILMvCGoj
	SafeAction_1_t6295D5E01D7944A8AEE5D1336EA31C2C3721C004* ___ffNDXtGVGSllVFwxOsKpILMvCGoj_44;
	// Rewired.Utils.SafeAction`1<Rewired.ControllerStatusChangedEventArgs> Rewired.ReInput::njEZXXdNqKTBaHjxRDBMJvJYJguw
	SafeAction_1_t6295D5E01D7944A8AEE5D1336EA31C2C3721C004* ___njEZXXdNqKTBaHjxRDBMJvJYJguw_45;
	// Rewired.Utils.SafeAction Rewired.ReInput::bTDaHvESdACEkdrUbjjZPXftulevb
	SafeAction_t32EA46BB214634A37414BF52941F55B8ABC9BD31* ___bTDaHvESdACEkdrUbjjZPXftulevb_46;
	// Rewired.Utils.SafeAction Rewired.ReInput::nbJgBkvEgnHdxjvTbiYQrkfmDHgFb
	SafeAction_t32EA46BB214634A37414BF52941F55B8ABC9BD31* ___nbJgBkvEgnHdxjvTbiYQrkfmDHgFb_47;
	// Rewired.Utils.SafeAction Rewired.ReInput::pGQsFuQGaGXFPOaycAwCOQIXSZg
	SafeAction_t32EA46BB214634A37414BF52941F55B8ABC9BD31* ___pGQsFuQGaGXFPOaycAwCOQIXSZg_48;
	// Rewired.Utils.SafeAction Rewired.ReInput::dKhxPhYhCBTmzciUOzePGyFbWyQB
	SafeAction_t32EA46BB214634A37414BF52941F55B8ABC9BD31* ___dKhxPhYhCBTmzciUOzePGyFbWyQB_49;
	// Rewired.Utils.SafeAction Rewired.ReInput::RbHPdAbxtniltkzTKarLSCOUOSHx
	SafeAction_t32EA46BB214634A37414BF52941F55B8ABC9BD31* ___RbHPdAbxtniltkzTKarLSCOUOSHx_50;
	// System.Action`1<System.Boolean> Rewired.ReInput::_ApplicationFocusChangedEvent
	Action_1_t10DCB0C07D0D3C565CEACADC80D1152B35A45F6C* ____ApplicationFocusChangedEvent_51;
	// System.Action Rewired.ReInput::aHGGizmAhSWZsuPsdohsJNLsmVkf
	Action_tD00B0A84D7945E50C2DFFC28EFEE6ED44ED2AD07* ___aHGGizmAhSWZsuPsdohsJNLsmVkf_52;
	// System.Action`1<Rewired.UpdateLoopType> Rewired.ReInput::pFTLpyxkkcLiZGKFZfHscWcjIljgA
	Action_1_t60FB4C2B07126A34E8B4816D36F7A2065E957637* ___pFTLpyxkkcLiZGKFZfHscWcjIljgA_53;
	// System.Action`1<Rewired.UpdateLoopType> Rewired.ReInput::psBWhCEjFnHkQDUmvnUbZRXCbOCH
	Action_1_t60FB4C2B07126A34E8B4816D36F7A2065E957637* ___psBWhCEjFnHkQDUmvnUbZRXCbOCH_54;
	// System.Action`1<Rewired.UpdateLoopType> Rewired.ReInput::xfZnkBJCaDbBVzlPFemHRiTCHUcF
	Action_1_t60FB4C2B07126A34E8B4816D36F7A2065E957637* ___xfZnkBJCaDbBVzlPFemHRiTCHUcF_55;
	// System.Action Rewired.ReInput::BrreqkghsSGwPIOcIQALsyJJIdSP
	Action_tD00B0A84D7945E50C2DFFC28EFEE6ED44ED2AD07* ___BrreqkghsSGwPIOcIQALsyJJIdSP_56;
	// System.Action`1<System.Boolean> Rewired.ReInput::YfmZatXiThjlAuDnqWNaiiDdEDQiA
	Action_1_t10DCB0C07D0D3C565CEACADC80D1152B35A45F6C* ___YfmZatXiThjlAuDnqWNaiiDdEDQiA_57;
	// System.Action`1<System.Boolean> Rewired.ReInput::npMGOUtUKoWmuINMNBlWBOcRlARFb
	Action_1_t10DCB0C07D0D3C565CEACADC80D1152B35A45F6C* ___npMGOUtUKoWmuINMNBlWBOcRlARFb_58;
	// System.Action`1<System.Boolean> Rewired.ReInput::oYMeHhKFZEmkroacrLNvLkIJDVLMA
	Action_1_t10DCB0C07D0D3C565CEACADC80D1152B35A45F6C* ___oYMeHhKFZEmkroacrLNvLkIJDVLMA_59;
	// System.Action`1<UnityEngine.FullScreenMode> Rewired.ReInput::mhAwjjwnxuWqgFdGFKRTvqYcbdhaA
	Action_1_t329A050FC7346A8E8F6E91FE9C9D3F99F35609E6* ___mhAwjjwnxuWqgFdGFKRTvqYcbdhaA_60;
	// System.Action Rewired.ReInput::CjUSWpkmKHhAaRuniwTTsVABOJSJ
	Action_tD00B0A84D7945E50C2DFFC28EFEE6ED44ED2AD07* ___CjUSWpkmKHhAaRuniwTTsVABOJSJ_61;
	// System.Action`1<System.Boolean> Rewired.ReInput::btuusiuwHCPEGntwcrePVuCJaAfk
	Action_1_t10DCB0C07D0D3C565CEACADC80D1152B35A45F6C* ___btuusiuwHCPEGntwcrePVuCJaAfk_62;
	// System.Double Rewired.ReInput::unscaledDeltaTime
	double ___unscaledDeltaTime_63;
	// System.Double Rewired.ReInput::unscaledTime
	double ___unscaledTime_64;
	// System.Double Rewired.ReInput::unscaledTimePrev
	double ___unscaledTimePrev_65;
	// System.UInt32 Rewired.ReInput::currentFrame
	uint32_t ___currentFrame_66;
	// System.UInt32 Rewired.ReInput::previousFrame
	uint32_t ___previousFrame_67;
	// System.UInt32 Rewired.ReInput::absFrame
	uint32_t ___absFrame_68;
};

// System.SystemException
struct SystemException_tCC48D868298F4C0705279823E34B00F4FBDB7295  : public Exception_t
{
};

// System.Type
struct Type_t  : public MemberInfo_t
{
	// System.RuntimeTypeHandle System.Type::_impl
	RuntimeTypeHandle_t332A452B8B6179E4469B69525D0FE82A88030F7B ____impl_8;
};

struct Type_t_StaticFields
{
	// System.Reflection.Binder modreq(System.Runtime.CompilerServices.IsVolatile) System.Type::s_defaultBinder
	Binder_t91BFCE95A7057FADF4D8A1A342AFE52872246235* ___s_defaultBinder_0;
	// System.Char System.Type::Delimiter
	Il2CppChar ___Delimiter_1;
	// System.Type[] System.Type::EmptyTypes
	TypeU5BU5D_t97234E1129B564EB38B8D85CAC2AD8B5B9522FFB* ___EmptyTypes_2;
	// System.Object System.Type::Missing
	RuntimeObject* ___Missing_3;
	// System.Reflection.MemberFilter System.Type::FilterAttribute
	MemberFilter_tF644F1AE82F611B677CE1964D5A3277DDA21D553* ___FilterAttribute_4;
	// System.Reflection.MemberFilter System.Type::FilterName
	MemberFilter_tF644F1AE82F611B677CE1964D5A3277DDA21D553* ___FilterName_5;
	// System.Reflection.MemberFilter System.Type::FilterNameIgnoreCase
	MemberFilter_tF644F1AE82F611B677CE1964D5A3277DDA21D553* ___FilterNameIgnoreCase_6;
};

// slnZXWsjHVMgmJPfXBYLuaghszns
struct slnZXWsjHVMgmJPfXBYLuaghszns_t24FEA9E317E149AF896730414F2B3089559DCEC1  : public RuntimeObject
{
	// System.String slnZXWsjHVMgmJPfXBYLuaghszns::DwCxMCYkknMiaGQSTcpyYZtCOarV
	String_t* ___DwCxMCYkknMiaGQSTcpyYZtCOarV_0;
	// System.Int32 slnZXWsjHVMgmJPfXBYLuaghszns::jKZLhONJVjxMGJoFxnLBvfHJROqX
	int32_t ___jKZLhONJVjxMGJoFxnLBvfHJROqX_1;
	// System.Int32 slnZXWsjHVMgmJPfXBYLuaghszns::poRIGCSEughNfRYXWSqdxofgERiiA
	int32_t ___poRIGCSEughNfRYXWSqdxofgERiiA_2;
	// System.Int32 slnZXWsjHVMgmJPfXBYLuaghszns::eNyGUiEiMyquCTKLRhFvpeyOvzMm
	int32_t ___eNyGUiEiMyquCTKLRhFvpeyOvzMm_3;
	// Rewired.InputBehavior slnZXWsjHVMgmJPfXBYLuaghszns::CBMELSeacjFNMrnojbCzUsfujiay
	InputBehavior_tF024DE8CDBF799CDC3B9CE43E5E4667C1D054FD9* ___CBMELSeacjFNMrnojbCzUsfujiay_4;
	// slnZXWsjHVMgmJPfXBYLuaghszns/sSljjuRryjcEuBqQKnCeXUUffipq slnZXWsjHVMgmJPfXBYLuaghszns::xeMfAOAMJnfDRxJnYWTseONWqyKkA
	sSljjuRryjcEuBqQKnCeXUUffipq_t20FE2A6122AD378214EFA255ED30B8368CD2E511* ___xeMfAOAMJnfDRxJnYWTseONWqyKkA_5;
	// System.Single slnZXWsjHVMgmJPfXBYLuaghszns::WZgiIcnUyEguECosouyeMRsGtlEh
	float ___WZgiIcnUyEguECosouyeMRsGtlEh_12;
	// System.Single slnZXWsjHVMgmJPfXBYLuaghszns::obFCQpFrkdTuvhvLyAHbHrQjEdfWb
	float ___obFCQpFrkdTuvhvLyAHbHrQjEdfWb_13;
	// System.Single slnZXWsjHVMgmJPfXBYLuaghszns::GwfvENtAGEhBdBGTyBHldyWBuTAQc
	float ___GwfvENtAGEhBdBGTyBHldyWBuTAQc_14;
	// System.Single slnZXWsjHVMgmJPfXBYLuaghszns::BwYvxgTRXdCbVcMHdIKyJYApTvbeA
	float ___BwYvxgTRXdCbVcMHdIKyJYApTvbeA_15;
	// Rewired.ButtonStateFlags slnZXWsjHVMgmJPfXBYLuaghszns::xoNilhkzLNKEpBWpcFUfacvzgRUE
	int32_t ___xoNilhkzLNKEpBWpcFUfacvzgRUE_16;
	// Rewired.ButtonStateFlags slnZXWsjHVMgmJPfXBYLuaghszns::YxyEDDNovYVCXWwFsRXVtaZXQItc
	int32_t ___YxyEDDNovYVCXWwFsRXVtaZXQItc_17;
	// System.Single slnZXWsjHVMgmJPfXBYLuaghszns::gbgEGYdJoEQEFeWbxZmLrlKtAxuFb
	float ___gbgEGYdJoEQEFeWbxZmLrlKtAxuFb_18;
	// System.Boolean slnZXWsjHVMgmJPfXBYLuaghszns::plPllfMetaSSyLNlvzVPbWDQWnoS
	bool ___plPllfMetaSSyLNlvzVPbWDQWnoS_19;
	// Rewired.AxisCoordinateMode slnZXWsjHVMgmJPfXBYLuaghszns::LqXeyWEdWfQGPaKKKKfWNzrdDMxhA
	int32_t ___LqXeyWEdWfQGPaKKKKfWNzrdDMxhA_20;
	// Rewired.AxisCoordinateMode slnZXWsjHVMgmJPfXBYLuaghszns::NwecWInPgzPLrxGmwGaJKbZArKAY
	int32_t ___NwecWInPgzPLrxGmwGaJKbZArKAY_21;
	// aDAAzNrnaVtINRtzmmcxtyAYKWAn slnZXWsjHVMgmJPfXBYLuaghszns::zUUTyGFfNRaspafyZpzQiJKTDAXHb
	aDAAzNrnaVtINRtzmmcxtyAYKWAn_tC58E06992354490D8D1C79A66F44308E6C271B26* ___zUUTyGFfNRaspafyZpzQiJKTDAXHb_22;
	// System.UInt32 slnZXWsjHVMgmJPfXBYLuaghszns::wLbwgQwpCtLjkwANkwOnBbnPccip
	uint32_t ___wLbwgQwpCtLjkwANkwOnBbnPccip_23;
	// System.UInt32 slnZXWsjHVMgmJPfXBYLuaghszns::MHKdDhJHADtzvpBrUvBaqcpQBucM
	uint32_t ___MHKdDhJHADtzvpBrUvBaqcpQBucM_24;
	// System.Boolean slnZXWsjHVMgmJPfXBYLuaghszns::YTaDHEJtbYiTVMylNbDSESZHjBkUA
	bool ___YTaDHEJtbYiTVMylNbDSESZHjBkUA_25;
	// slnZXWsjHVMgmJPfXBYLuaghszns/TpglccibZfOgeiyYDHnGNLANOPBl slnZXWsjHVMgmJPfXBYLuaghszns::dBEhZNLfahiSBDVlVxYEfOscesWbA
	int32_t ___dBEhZNLfahiSBDVlVxYEfOscesWbA_26;
	// System.Int32 slnZXWsjHVMgmJPfXBYLuaghszns::HqFWqUXytJRUUevivAkRcSItbOLl
	int32_t ___HqFWqUXytJRUUevivAkRcSItbOLl_28;
	// aDAAzNrnaVtINRtzmmcxtyAYKWAn[] slnZXWsjHVMgmJPfXBYLuaghszns::uUoctzTgMVpOriOyrKMgREbpOWwg
	aDAAzNrnaVtINRtzmmcxtyAYKWAnU5BU5D_tE28E46B8CE90563FB9114CF4CC5E249E1CE0860F* ___uUoctzTgMVpOriOyrKMgREbpOWwg_29;
	// System.Collections.Generic.List`1<Rewired.InputActionSourceData> slnZXWsjHVMgmJPfXBYLuaghszns::DmDcVLvQEgaEGLsoSzTyoZXektjy
	List_1_t5A6AAC55B898C13EB8E8597B8AB3D06036D5A477* ___DmDcVLvQEgaEGLsoSzTyoZXektjy_30;
	// System.Collections.ObjectModel.ReadOnlyCollection`1<Rewired.InputActionSourceData> slnZXWsjHVMgmJPfXBYLuaghszns::yIPfWJDvKhbePYMpqdFlnEBatRUp
	ReadOnlyCollection_1_t2D1795D097BFAA9ADC0A5B83FC4B7DAB13360D6B* ___yIPfWJDvKhbePYMpqdFlnEBatRUp_31;
	// System.Boolean slnZXWsjHVMgmJPfXBYLuaghszns::ksNGwIoELcsdmUpOAPzDPdheENLAA
	bool ___ksNGwIoELcsdmUpOAPzDPdheENLAA_32;
	// System.Boolean slnZXWsjHVMgmJPfXBYLuaghszns::fgRLXKejnTDpcRiFzkoIDMAuRSRV
	bool ___fgRLXKejnTDpcRiFzkoIDMAuRSRV_33;
	// slnZXWsjHVMgmJPfXBYLuaghszns/TpglccibZfOgeiyYDHnGNLANOPBl slnZXWsjHVMgmJPfXBYLuaghszns::EYANgMiBdAmYbNpUaXlrPtAzdRpC
	int32_t ___EYANgMiBdAmYbNpUaXlrPtAzdRpC_34;
};

struct slnZXWsjHVMgmJPfXBYLuaghszns_t24FEA9E317E149AF896730414F2B3089559DCEC1_StaticFields
{
	// Rewired.Data.ConfigVars slnZXWsjHVMgmJPfXBYLuaghszns::yKydsvixPcQdBIlgvxotXrJTbkcL
	ConfigVars_t4EC82ACF63376F1869FDC3D0E223EDCE149CF4A3* ___yKydsvixPcQdBIlgvxotXrJTbkcL_6;
	// slnZXWsjHVMgmJPfXBYLuaghszns/QGeOicrujSfMZepRhdYgYLzOkaHe slnZXWsjHVMgmJPfXBYLuaghszns::iAwJirFPkoHLSgBLVSPpSHSLYWZbA
	QGeOicrujSfMZepRhdYgYLzOkaHe_t1DB6528F1807C441E39C5EF370EF29E2B2A4E679* ___iAwJirFPkoHLSgBLVSPpSHSLYWZbA_7;
	// Rewired.UpdateLoopType slnZXWsjHVMgmJPfXBYLuaghszns::EDDiNjsidIeXAFNsRZpKSaKrTrJp
	int32_t ___EDDiNjsidIeXAFNsRZpKSaKrTrJp_8;
	// System.Double slnZXWsjHVMgmJPfXBYLuaghszns::nULgHOCosHxRDIZIekybjkGEaMnLA
	double ___nULgHOCosHxRDIZIekybjkGEaMnLA_9;
	// System.Single slnZXWsjHVMgmJPfXBYLuaghszns::GsCAAbeWpqsbKDLOpHweOrbPhBbdb
	float ___GsCAAbeWpqsbKDLOpHweOrbPhBbdb_10;
	// System.UInt32 slnZXWsjHVMgmJPfXBYLuaghszns::qXneboxjMHBaKTuydPVbupNeixlH
	uint32_t ___qXneboxjMHBaKTuydPVbupNeixlH_11;
	// FeaiSQbvxYDTMImoDmlvhGnyLumi slnZXWsjHVMgmJPfXBYLuaghszns::bbIgXLaOfnvjdbkLSdSnMkwscgPFA
	FeaiSQbvxYDTMImoDmlvhGnyLumi_tB82E59EB263DBCCD7452BF39256B26197DD5299C* ___bbIgXLaOfnvjdbkLSdSnMkwscgPFA_35;
};

// Rewired.Controller/CompoundElement
struct CompoundElement_t13DDF83F927A6EF07A34A4A70E3C7DF93F726576  : public RuntimeObject
{
	// System.Int32 Rewired.Controller/CompoundElement::dDfetvBNteDTeczVYgZnpTDFdyZTA
	int32_t ___dDfetvBNteDTeczVYgZnpTDFdyZTA_0;
	// System.String Rewired.Controller/CompoundElement::DwCxMCYkknMiaGQSTcpyYZtCOarV
	String_t* ___DwCxMCYkknMiaGQSTcpyYZtCOarV_1;
	// Rewired.CompoundControllerElementType Rewired.Controller/CompoundElement::dtwTwQpAPYRVYwbkzfvQqvKGLOOC
	int32_t ___dtwTwQpAPYRVYwbkzfvQqvKGLOOC_2;
	// System.Int32 Rewired.Controller/CompoundElement::BgQuNAWNFxILxzPlJiIjAABAVtGc
	int32_t ___BgQuNAWNFxILxzPlJiIjAABAVtGc_3;
	// Rewired.Controller/CompoundElement/kfzfjnagLVVtsyAzdAlUhZdNuSIQA[] Rewired.Controller/CompoundElement::IvMWItGTIMgpzxlakIFhxQRLuqob
	kfzfjnagLVVtsyAzdAlUhZdNuSIQAU5BU5D_tEEB780C862E2161EBC7C54D3F94963F74723F9AB* ___IvMWItGTIMgpzxlakIFhxQRLuqob_4;
	// Rewired.Controller Rewired.Controller/CompoundElement::ANMamGTTJSCnGKAQdqGuVYErIycq
	Controller_t919A4A50FC7A0F25D7B31615C0F4E4D4A4D17911* ___ANMamGTTJSCnGKAQdqGuVYErIycq_5;
	// System.Int32 Rewired.Controller/CompoundElement::eNyGUiEiMyquCTKLRhFvpeyOvzMm
	int32_t ___eNyGUiEiMyquCTKLRhFvpeyOvzMm_6;
};

// Rewired.Controller/Element
struct Element_t58CB6D4FDC2FDD69AC192D19F0F9531FE3F01F76  : public RuntimeObject
{
	// System.Int32 Rewired.Controller/Element::id
	int32_t ___id_0;
	// System.String Rewired.Controller/Element::name
	String_t* ___name_1;
	// Rewired.ControllerElementType Rewired.Controller/Element::type
	int32_t ___type_2;
	// Rewired.Controller/Element/bjRAYyJTFiksIdlhLZuKXBUXHTrC Rewired.Controller/Element::KTbIfnWUXpbWhyPYlqPcszTaUjlG
	bjRAYyJTFiksIdlhLZuKXBUXHTrC_t49F8AEB871E69D140E18244C3C88BDD4D47609EB* ___KTbIfnWUXpbWhyPYlqPcszTaUjlG_3;
	// System.Int32 Rewired.Controller/Element::dwwjkfbiMSwSvQGnMCRJbflkirgz
	int32_t ___dwwjkfbiMSwSvQGnMCRJbflkirgz_4;
	// Rewired.Controller Rewired.Controller/Element::ANMamGTTJSCnGKAQdqGuVYErIycq
	Controller_t919A4A50FC7A0F25D7B31615C0F4E4D4A4D17911* ___ANMamGTTJSCnGKAQdqGuVYErIycq_5;
	// System.Int32 Rewired.Controller/Element::eNyGUiEiMyquCTKLRhFvpeyOvzMm
	int32_t ___eNyGUiEiMyquCTKLRhFvpeyOvzMm_6;
	// Rewired.Controller/CompoundElement Rewired.Controller/Element::VqsmYILjlINhvasFVbUEJvSxhFzs
	CompoundElement_t13DDF83F927A6EF07A34A4A70E3C7DF93F726576* ___VqsmYILjlINhvasFVbUEJvSxhFzs_7;
};

// Rewired.InputMapper/Options
struct Options_t2CAC7BDE548C606E2D6149513164D5EF301AEF7A  : public RuntimeObject
{
	// System.Boolean Rewired.InputMapper/Options::esMLoiMmOibRwbpqiNHCpImhHaMhA
	bool ___esMLoiMmOibRwbpqiNHCpImhHaMhA_0;
	// System.Boolean Rewired.InputMapper/Options::ojNtybXpyoJOxKJRMTfZLGTnBHzX
	bool ___ojNtybXpyoJOxKJRMTfZLGTnBHzX_1;
	// System.Boolean Rewired.InputMapper/Options::sNQhoQAUptZXDafWRewkVcTexlYE
	bool ___sNQhoQAUptZXDafWRewkVcTexlYE_2;
	// System.Single Rewired.InputMapper/Options::RZMbdPmlnJsPFvmSHexBfoQTTUVe
	float ___RZMbdPmlnJsPFvmSHexBfoQTTUVe_3;
	// System.Boolean Rewired.InputMapper/Options::cwxHiwpcrTeGVKkWZBOooIENkgSi
	bool ___cwxHiwpcrTeGVKkWZBOooIENkgSi_4;
	// System.Boolean Rewired.InputMapper/Options::UINCuvFXCUMtzNKeqIoBiUCpMKdhA
	bool ___UINCuvFXCUMtzNKeqIoBiUCpMKdhA_5;
	// System.Boolean Rewired.InputMapper/Options::KzLKqYZnTJCoegsNmBOABswtKReR
	bool ___KzLKqYZnTJCoegsNmBOABswtKReR_6;
	// System.Boolean Rewired.InputMapper/Options::EcPWqALJpvTNgaRMlGuCbmFVKCXd
	bool ___EcPWqALJpvTNgaRMlGuCbmFVKCXd_7;
	// System.Int32[] Rewired.InputMapper/Options::EvTKamMzPHSgkcnHIodWzSbIZbJk
	Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* ___EvTKamMzPHSgkcnHIodWzSbIZbJk_8;
	// Rewired.InputMapper/ConflictResponse Rewired.InputMapper/Options::iOXcraaXWrCFKgnIEzIinCLuBUFqB
	int32_t ___iOXcraaXWrCFKgnIEzIinCLuBUFqB_9;
	// System.Boolean Rewired.InputMapper/Options::hMxAUvkmVTLjoudbtmKoEzsiLIXR
	bool ___hMxAUvkmVTLjoudbtmKoEzsiLIXR_10;
	// System.Boolean Rewired.InputMapper/Options::XrdoRBZkYSppZftcxFsiGMTHjySb
	bool ___XrdoRBZkYSppZftcxFsiGMTHjySb_11;
	// System.Boolean Rewired.InputMapper/Options::ByHqJquVTwWppOdptXLTsFpukZBn
	bool ___ByHqJquVTwWppOdptXLTsFpukZBn_12;
	// System.Boolean Rewired.InputMapper/Options::IudJtnTAlOlboFcTKreckWJbIxfG
	bool ___IudJtnTAlOlboFcTKreckWJbIxfG_13;
	// System.Single Rewired.InputMapper/Options::jlACeSqgqnVQiGbxhDRlKgOwNiPhb
	float ___jlACeSqgqnVQiGbxhDRlKgOwNiPhb_14;
	// System.Collections.Generic.Dictionary`2<System.String,Rewired.Utils.SafeDelegate> Rewired.InputMapper/Options::kQEDpbIrGvgbinAZYRcxGnGhuOMwA
	Dictionary_2_t340D9BC5CF0537B47A79183E8A310B59364118DF* ___kQEDpbIrGvgbinAZYRcxGnGhuOMwA_16;
};

// System.Action`3<System.Boolean,System.Int32,System.Int32>
struct Action_3_t142D1F73AF66CEBC85F52240EC1B6207B558A40B  : public MulticastDelegate_t
{
};

// System.Func`2<Rewired.Data.UserData/PMmfElSRTHipvrooOqnrsVzyuehD/cTlcZwgBmjmwQjxeEhJdCJOLqDjC`1<System.Object>,System.Object>
struct Func_2_t47FA43C06CA3B7E69EECC5B0C6D36F44AADCB758  : public MulticastDelegate_t
{
};

// System.Func`2<System.Object,System.Int32>
struct Func_2_t9A0D493A82DCC47C9C819A3B045E02D9B5DDCE1B  : public MulticastDelegate_t
{
};

// System.Func`2<System.Object,System.String>
struct Func_2_t8A4E59735D50CEA34C30F6CD6B5804A38327CD0B  : public MulticastDelegate_t
{
};

// System.Func`3<Rewired.Controller,System.Guid,System.Boolean>
struct Func_3_tF4129F872BD8CCCF0D22456285DD4191EE3A59E2  : public MulticastDelegate_t
{
};

// System.Func`3<Rewired.Controller,System.Object,System.Boolean>
struct Func_3_tFE04544F8517BA81CF80AC748CE401211FE150B0  : public MulticastDelegate_t
{
};

// System.Func`3<System.Object,System.Collections.Generic.IList`1<System.Object>,System.Int32>
struct Func_3_tA2EC68432F49E8DB1FC81E592EA4A30855D5EE0E  : public MulticastDelegate_t
{
};

// UnityEngine.InputSystem.InputControlList`1<UnityEngine.InputSystem.InputControl>
struct InputControlList_1_tDCD1283F428BB911908D4A86066022F6FEF337BA 
{
	// System.Int32 UnityEngine.InputSystem.InputControlList`1::m_Count
	int32_t ___m_Count_0;
	// Unity.Collections.NativeArray`1<System.UInt64> UnityEngine.InputSystem.InputControlList`1::m_Indices
	NativeArray_1_t07975297AD7F7512193094A7C0703BA872EF7A7B ___m_Indices_1;
	// Unity.Collections.Allocator UnityEngine.InputSystem.InputControlList`1::m_Allocator
	int32_t ___m_Allocator_2;
};

// Rewired.Player/ControllerHelper/ConflictCheckingHelper/LaNNrUufXUaCsHwYSVeeItSJzfQrA`1<System.Object>
struct LaNNrUufXUaCsHwYSVeeItSJzfQrA_1_t90BE74457214F7F3801FB0D2DD805D4EAF4457DA  : public RuntimeObject
{
	// System.Int32 Rewired.Player/ControllerHelper/ConflictCheckingHelper/LaNNrUufXUaCsHwYSVeeItSJzfQrA`1::lhJjXYwkSAdydFfoeAtjBqWdritd
	int32_t ___lhJjXYwkSAdydFfoeAtjBqWdritd_0;
	// Rewired.ElementAssignmentConflictInfo Rewired.Player/ControllerHelper/ConflictCheckingHelper/LaNNrUufXUaCsHwYSVeeItSJzfQrA`1::vCTBKloGAsThLIlfLnSUZmMAGBkDA
	ElementAssignmentConflictInfo_t5BEF1917CC1F4A9E47FD362786C2F9A13BEDDEC2 ___vCTBKloGAsThLIlfLnSUZmMAGBkDA_1;
	// System.Int32 Rewired.Player/ControllerHelper/ConflictCheckingHelper/LaNNrUufXUaCsHwYSVeeItSJzfQrA`1::IZEjyMBhYsNpKQOWFbNUXKoJwbAw
	int32_t ___IZEjyMBhYsNpKQOWFbNUXKoJwbAw_2;
	// TBSPGJPKaXrjsOpBQZPxJnrcfSfAA`1<?> Rewired.Player/ControllerHelper/ConflictCheckingHelper/LaNNrUufXUaCsHwYSVeeItSJzfQrA`1::BONcEOgaKIwNBDEogpxutUxJqMiOA
	TBSPGJPKaXrjsOpBQZPxJnrcfSfAA_1_t92F77A2C0897D802673079FA32163CACC9FD23DE* ___BONcEOgaKIwNBDEogpxutUxJqMiOA_3;
	// TBSPGJPKaXrjsOpBQZPxJnrcfSfAA`1<?> Rewired.Player/ControllerHelper/ConflictCheckingHelper/LaNNrUufXUaCsHwYSVeeItSJzfQrA`1::GvAHqXQEeCaNOUVGVeofgeJOkljZ
	TBSPGJPKaXrjsOpBQZPxJnrcfSfAA_1_t92F77A2C0897D802673079FA32163CACC9FD23DE* ___GvAHqXQEeCaNOUVGVeofgeJOkljZ_4;
	// Rewired.ElementAssignmentConflictCheck Rewired.Player/ControllerHelper/ConflictCheckingHelper/LaNNrUufXUaCsHwYSVeeItSJzfQrA`1::xujaweHMNjJktkOttbibNvvlcTSP
	ElementAssignmentConflictCheck_tC22925257E88D3999FDD06C7ABF3B6CE6C09847E ___xujaweHMNjJktkOttbibNvvlcTSP_5;
	// Rewired.ElementAssignmentConflictCheck Rewired.Player/ControllerHelper/ConflictCheckingHelper/LaNNrUufXUaCsHwYSVeeItSJzfQrA`1::wmyDcCHWYMasogZlrqkbzlzgyAQe
	ElementAssignmentConflictCheck_tC22925257E88D3999FDD06C7ABF3B6CE6C09847E ___wmyDcCHWYMasogZlrqkbzlzgyAQe_6;
	// System.Boolean Rewired.Player/ControllerHelper/ConflictCheckingHelper/LaNNrUufXUaCsHwYSVeeItSJzfQrA`1::nVhagDMkmFWoYFdZMrVvmtWxoqkX
	bool ___nVhagDMkmFWoYFdZMrVvmtWxoqkX_7;
	// System.Boolean Rewired.Player/ControllerHelper/ConflictCheckingHelper/LaNNrUufXUaCsHwYSVeeItSJzfQrA`1::wbJTSksJrdbiJvScZEcbgDdFVdPiA
	bool ___wbJTSksJrdbiJvScZEcbgDdFVdPiA_8;
	// System.Boolean Rewired.Player/ControllerHelper/ConflictCheckingHelper/LaNNrUufXUaCsHwYSVeeItSJzfQrA`1::BOdYrjfnCvMbcLNuzrsEUeilyZEp
	bool ___BOdYrjfnCvMbcLNuzrsEUeilyZEp_9;
	// System.Boolean Rewired.Player/ControllerHelper/ConflictCheckingHelper/LaNNrUufXUaCsHwYSVeeItSJzfQrA`1::mzPyLJUgHmLqXxITGVUETFfKmubS
	bool ___mzPyLJUgHmLqXxITGVUETFfKmubS_10;
	// Rewired.Player/ControllerHelper/ConflictCheckingHelper Rewired.Player/ControllerHelper/ConflictCheckingHelper/LaNNrUufXUaCsHwYSVeeItSJzfQrA`1::hJlvyFukKfMzsWcSVLwLCnIUdlMn
	ConflictCheckingHelper_t8D707CEC57F056B87A4C68F98F780D34E893A8DB* ___hJlvyFukKfMzsWcSVLwLCnIUdlMn_11;
	// Rewired.InputMapCategory Rewired.Player/ControllerHelper/ConflictCheckingHelper/LaNNrUufXUaCsHwYSVeeItSJzfQrA`1::kksVYTgjEVFZyqFYvtwJgAosNvDn
	InputMapCategory_t309A7C800100DDCC67C5C6A69F960A1D71768111* ___kksVYTgjEVFZyqFYvtwJgAosNvDn_12;
	// System.Int32 Rewired.Player/ControllerHelper/ConflictCheckingHelper/LaNNrUufXUaCsHwYSVeeItSJzfQrA`1::XRXvHMDaUbnUKSmMJEaxfPHXxbMm
	int32_t ___XRXvHMDaUbnUKSmMJEaxfPHXxbMm_13;
	// System.Collections.Generic.IEnumerator`1<Rewired.ElementAssignmentConflictInfo> Rewired.Player/ControllerHelper/ConflictCheckingHelper/LaNNrUufXUaCsHwYSVeeItSJzfQrA`1::HpXSjfddGZNESZUwdNcsLgcceUhy
	RuntimeObject* ___HpXSjfddGZNESZUwdNcsLgcceUhy_14;
};

// Rewired.Player/ControllerHelper/ConflictCheckingHelper/NPPlAOzpsFiqWUuYJtTMLJfMbmYu`1<System.Object>
struct NPPlAOzpsFiqWUuYJtTMLJfMbmYu_1_tDD2E3885D14A7C4488825DE3B7C56DEA023BC185  : public RuntimeObject
{
	// System.Int32 Rewired.Player/ControllerHelper/ConflictCheckingHelper/NPPlAOzpsFiqWUuYJtTMLJfMbmYu`1::lhJjXYwkSAdydFfoeAtjBqWdritd
	int32_t ___lhJjXYwkSAdydFfoeAtjBqWdritd_0;
	// Rewired.ElementAssignmentConflictInfo Rewired.Player/ControllerHelper/ConflictCheckingHelper/NPPlAOzpsFiqWUuYJtTMLJfMbmYu`1::vCTBKloGAsThLIlfLnSUZmMAGBkDA
	ElementAssignmentConflictInfo_t5BEF1917CC1F4A9E47FD362786C2F9A13BEDDEC2 ___vCTBKloGAsThLIlfLnSUZmMAGBkDA_1;
	// System.Int32 Rewired.Player/ControllerHelper/ConflictCheckingHelper/NPPlAOzpsFiqWUuYJtTMLJfMbmYu`1::IZEjyMBhYsNpKQOWFbNUXKoJwbAw
	int32_t ___IZEjyMBhYsNpKQOWFbNUXKoJwbAw_2;
	// TBSPGJPKaXrjsOpBQZPxJnrcfSfAA`1<?> Rewired.Player/ControllerHelper/ConflictCheckingHelper/NPPlAOzpsFiqWUuYJtTMLJfMbmYu`1::BONcEOgaKIwNBDEogpxutUxJqMiOA
	TBSPGJPKaXrjsOpBQZPxJnrcfSfAA_1_t92F77A2C0897D802673079FA32163CACC9FD23DE* ___BONcEOgaKIwNBDEogpxutUxJqMiOA_3;
	// TBSPGJPKaXrjsOpBQZPxJnrcfSfAA`1<?> Rewired.Player/ControllerHelper/ConflictCheckingHelper/NPPlAOzpsFiqWUuYJtTMLJfMbmYu`1::GvAHqXQEeCaNOUVGVeofgeJOkljZ
	TBSPGJPKaXrjsOpBQZPxJnrcfSfAA_1_t92F77A2C0897D802673079FA32163CACC9FD23DE* ___GvAHqXQEeCaNOUVGVeofgeJOkljZ_4;
	// ? Rewired.Player/ControllerHelper/ConflictCheckingHelper/NPPlAOzpsFiqWUuYJtTMLJfMbmYu`1::hdeEYBGDrHGibivVOHuxbnneRxiy
	RuntimeObject* ___hdeEYBGDrHGibivVOHuxbnneRxiy_5;
	// ? Rewired.Player/ControllerHelper/ConflictCheckingHelper/NPPlAOzpsFiqWUuYJtTMLJfMbmYu`1::yFsxPduJsRRbcQBkjQYDCjtPsnZC
	RuntimeObject* ___yFsxPduJsRRbcQBkjQYDCjtPsnZC_6;
	// System.Boolean Rewired.Player/ControllerHelper/ConflictCheckingHelper/NPPlAOzpsFiqWUuYJtTMLJfMbmYu`1::nVhagDMkmFWoYFdZMrVvmtWxoqkX
	bool ___nVhagDMkmFWoYFdZMrVvmtWxoqkX_7;
	// System.Boolean Rewired.Player/ControllerHelper/ConflictCheckingHelper/NPPlAOzpsFiqWUuYJtTMLJfMbmYu`1::wbJTSksJrdbiJvScZEcbgDdFVdPiA
	bool ___wbJTSksJrdbiJvScZEcbgDdFVdPiA_8;
	// System.Boolean Rewired.Player/ControllerHelper/ConflictCheckingHelper/NPPlAOzpsFiqWUuYJtTMLJfMbmYu`1::BOdYrjfnCvMbcLNuzrsEUeilyZEp
	bool ___BOdYrjfnCvMbcLNuzrsEUeilyZEp_9;
	// System.Boolean Rewired.Player/ControllerHelper/ConflictCheckingHelper/NPPlAOzpsFiqWUuYJtTMLJfMbmYu`1::mzPyLJUgHmLqXxITGVUETFfKmubS
	bool ___mzPyLJUgHmLqXxITGVUETFfKmubS_10;
	// Rewired.Player/ControllerHelper/ConflictCheckingHelper Rewired.Player/ControllerHelper/ConflictCheckingHelper/NPPlAOzpsFiqWUuYJtTMLJfMbmYu`1::hJlvyFukKfMzsWcSVLwLCnIUdlMn
	ConflictCheckingHelper_t8D707CEC57F056B87A4C68F98F780D34E893A8DB* ___hJlvyFukKfMzsWcSVLwLCnIUdlMn_11;
	// Rewired.ControllerType Rewired.Player/ControllerHelper/ConflictCheckingHelper/NPPlAOzpsFiqWUuYJtTMLJfMbmYu`1::NxodZbWOUvIlUIjuymsXRiZHjbjC
	int32_t ___NxodZbWOUvIlUIjuymsXRiZHjbjC_12;
	// Rewired.ControllerType Rewired.Player/ControllerHelper/ConflictCheckingHelper/NPPlAOzpsFiqWUuYJtTMLJfMbmYu`1::GIZHpBfTSGgXJDtcKfJhtDcTARMY
	int32_t ___GIZHpBfTSGgXJDtcKfJhtDcTARMY_13;
	// System.Int32 Rewired.Player/ControllerHelper/ConflictCheckingHelper/NPPlAOzpsFiqWUuYJtTMLJfMbmYu`1::ITgIwrSYaNPfsNHEMkJvPipaoLXv
	int32_t ___ITgIwrSYaNPfsNHEMkJvPipaoLXv_14;
	// System.Int32 Rewired.Player/ControllerHelper/ConflictCheckingHelper/NPPlAOzpsFiqWUuYJtTMLJfMbmYu`1::XuDYOktzvzuJLzqUPQedqdspGDhC
	int32_t ___XuDYOktzvzuJLzqUPQedqdspGDhC_15;
	// Rewired.InputMapCategory Rewired.Player/ControllerHelper/ConflictCheckingHelper/NPPlAOzpsFiqWUuYJtTMLJfMbmYu`1::kksVYTgjEVFZyqFYvtwJgAosNvDn
	InputMapCategory_t309A7C800100DDCC67C5C6A69F960A1D71768111* ___kksVYTgjEVFZyqFYvtwJgAosNvDn_16;
	// System.Int32 Rewired.Player/ControllerHelper/ConflictCheckingHelper/NPPlAOzpsFiqWUuYJtTMLJfMbmYu`1::XRXvHMDaUbnUKSmMJEaxfPHXxbMm
	int32_t ___XRXvHMDaUbnUKSmMJEaxfPHXxbMm_17;
	// System.Collections.Generic.IEnumerator`1<Rewired.ElementAssignmentConflictInfo> Rewired.Player/ControllerHelper/ConflictCheckingHelper/NPPlAOzpsFiqWUuYJtTMLJfMbmYu`1::HpXSjfddGZNESZUwdNcsLgcceUhy
	RuntimeObject* ___HpXSjfddGZNESZUwdNcsLgcceUhy_18;
};

// System.Nullable`1<UnityEngine.InputSystem.InputBinding>
struct Nullable_1_t11786EE914FE65E70B9671129B0DFC4D0DE80C44 
{
	// System.Boolean System.Nullable`1::hasValue
	bool ___hasValue_0;
	// T System.Nullable`1::value
	InputBinding_t0D75BD1538CF81D29450D568D5C938E111633EC5 ___value_1;
};

// System.Predicate`1<Rewired.Data.UserData/PMmfElSRTHipvrooOqnrsVzyuehD/kzedFdEdISaCJppRVzkSmhYBfiDK>
struct Predicate_1_t0AE34D834A58115AD4CD9532C7FEAF28A2A18674  : public MulticastDelegate_t
{
};

// Rewired.Player/ControllerHelper/ConflictCheckingHelper/gPTTtyzOAxLCvPhgMtIrgUsCIpeH`1<System.Object>
struct gPTTtyzOAxLCvPhgMtIrgUsCIpeH_1_tA05B48EAD2AA2E510F8D380D32FC8F6D8331D7E3  : public RuntimeObject
{
	// System.Int32 Rewired.Player/ControllerHelper/ConflictCheckingHelper/gPTTtyzOAxLCvPhgMtIrgUsCIpeH`1::lhJjXYwkSAdydFfoeAtjBqWdritd
	int32_t ___lhJjXYwkSAdydFfoeAtjBqWdritd_0;
	// Rewired.ElementAssignmentConflictInfo Rewired.Player/ControllerHelper/ConflictCheckingHelper/gPTTtyzOAxLCvPhgMtIrgUsCIpeH`1::vCTBKloGAsThLIlfLnSUZmMAGBkDA
	ElementAssignmentConflictInfo_t5BEF1917CC1F4A9E47FD362786C2F9A13BEDDEC2 ___vCTBKloGAsThLIlfLnSUZmMAGBkDA_1;
	// System.Int32 Rewired.Player/ControllerHelper/ConflictCheckingHelper/gPTTtyzOAxLCvPhgMtIrgUsCIpeH`1::IZEjyMBhYsNpKQOWFbNUXKoJwbAw
	int32_t ___IZEjyMBhYsNpKQOWFbNUXKoJwbAw_2;
	// TBSPGJPKaXrjsOpBQZPxJnrcfSfAA`1<?> Rewired.Player/ControllerHelper/ConflictCheckingHelper/gPTTtyzOAxLCvPhgMtIrgUsCIpeH`1::BONcEOgaKIwNBDEogpxutUxJqMiOA
	TBSPGJPKaXrjsOpBQZPxJnrcfSfAA_1_t92F77A2C0897D802673079FA32163CACC9FD23DE* ___BONcEOgaKIwNBDEogpxutUxJqMiOA_3;
	// TBSPGJPKaXrjsOpBQZPxJnrcfSfAA`1<?> Rewired.Player/ControllerHelper/ConflictCheckingHelper/gPTTtyzOAxLCvPhgMtIrgUsCIpeH`1::GvAHqXQEeCaNOUVGVeofgeJOkljZ
	TBSPGJPKaXrjsOpBQZPxJnrcfSfAA_1_t92F77A2C0897D802673079FA32163CACC9FD23DE* ___GvAHqXQEeCaNOUVGVeofgeJOkljZ_4;
	// Rewired.ActionElementMap Rewired.Player/ControllerHelper/ConflictCheckingHelper/gPTTtyzOAxLCvPhgMtIrgUsCIpeH`1::enhfJSxEcPayvXmpsPbcdIzfGAnbA
	ActionElementMap_t0EBE3E5D3A5DF3BA6D35F8082ED2232404EFF8CF* ___enhfJSxEcPayvXmpsPbcdIzfGAnbA_5;
	// Rewired.ActionElementMap Rewired.Player/ControllerHelper/ConflictCheckingHelper/gPTTtyzOAxLCvPhgMtIrgUsCIpeH`1::CjJHlxWDwYLXIQWEDyYWzjqIDWLF
	ActionElementMap_t0EBE3E5D3A5DF3BA6D35F8082ED2232404EFF8CF* ___CjJHlxWDwYLXIQWEDyYWzjqIDWLF_6;
	// ? Rewired.Player/ControllerHelper/ConflictCheckingHelper/gPTTtyzOAxLCvPhgMtIrgUsCIpeH`1::hdeEYBGDrHGibivVOHuxbnneRxiy
	RuntimeObject* ___hdeEYBGDrHGibivVOHuxbnneRxiy_7;
	// ? Rewired.Player/ControllerHelper/ConflictCheckingHelper/gPTTtyzOAxLCvPhgMtIrgUsCIpeH`1::yFsxPduJsRRbcQBkjQYDCjtPsnZC
	RuntimeObject* ___yFsxPduJsRRbcQBkjQYDCjtPsnZC_8;
	// System.Boolean Rewired.Player/ControllerHelper/ConflictCheckingHelper/gPTTtyzOAxLCvPhgMtIrgUsCIpeH`1::nVhagDMkmFWoYFdZMrVvmtWxoqkX
	bool ___nVhagDMkmFWoYFdZMrVvmtWxoqkX_9;
	// System.Boolean Rewired.Player/ControllerHelper/ConflictCheckingHelper/gPTTtyzOAxLCvPhgMtIrgUsCIpeH`1::wbJTSksJrdbiJvScZEcbgDdFVdPiA
	bool ___wbJTSksJrdbiJvScZEcbgDdFVdPiA_10;
	// System.Boolean Rewired.Player/ControllerHelper/ConflictCheckingHelper/gPTTtyzOAxLCvPhgMtIrgUsCIpeH`1::BOdYrjfnCvMbcLNuzrsEUeilyZEp
	bool ___BOdYrjfnCvMbcLNuzrsEUeilyZEp_11;
	// System.Boolean Rewired.Player/ControllerHelper/ConflictCheckingHelper/gPTTtyzOAxLCvPhgMtIrgUsCIpeH`1::mzPyLJUgHmLqXxITGVUETFfKmubS
	bool ___mzPyLJUgHmLqXxITGVUETFfKmubS_12;
	// Rewired.Player/ControllerHelper/ConflictCheckingHelper Rewired.Player/ControllerHelper/ConflictCheckingHelper/gPTTtyzOAxLCvPhgMtIrgUsCIpeH`1::hJlvyFukKfMzsWcSVLwLCnIUdlMn
	ConflictCheckingHelper_t8D707CEC57F056B87A4C68F98F780D34E893A8DB* ___hJlvyFukKfMzsWcSVLwLCnIUdlMn_13;
	// Rewired.ControllerType Rewired.Player/ControllerHelper/ConflictCheckingHelper/gPTTtyzOAxLCvPhgMtIrgUsCIpeH`1::NxodZbWOUvIlUIjuymsXRiZHjbjC
	int32_t ___NxodZbWOUvIlUIjuymsXRiZHjbjC_14;
	// Rewired.ControllerType Rewired.Player/ControllerHelper/ConflictCheckingHelper/gPTTtyzOAxLCvPhgMtIrgUsCIpeH`1::GIZHpBfTSGgXJDtcKfJhtDcTARMY
	int32_t ___GIZHpBfTSGgXJDtcKfJhtDcTARMY_15;
	// System.Int32 Rewired.Player/ControllerHelper/ConflictCheckingHelper/gPTTtyzOAxLCvPhgMtIrgUsCIpeH`1::ITgIwrSYaNPfsNHEMkJvPipaoLXv
	int32_t ___ITgIwrSYaNPfsNHEMkJvPipaoLXv_16;
	// System.Int32 Rewired.Player/ControllerHelper/ConflictCheckingHelper/gPTTtyzOAxLCvPhgMtIrgUsCIpeH`1::XuDYOktzvzuJLzqUPQedqdspGDhC
	int32_t ___XuDYOktzvzuJLzqUPQedqdspGDhC_17;
	// Rewired.InputMapCategory Rewired.Player/ControllerHelper/ConflictCheckingHelper/gPTTtyzOAxLCvPhgMtIrgUsCIpeH`1::kksVYTgjEVFZyqFYvtwJgAosNvDn
	InputMapCategory_t309A7C800100DDCC67C5C6A69F960A1D71768111* ___kksVYTgjEVFZyqFYvtwJgAosNvDn_18;
	// System.Int32 Rewired.Player/ControllerHelper/ConflictCheckingHelper/gPTTtyzOAxLCvPhgMtIrgUsCIpeH`1::XRXvHMDaUbnUKSmMJEaxfPHXxbMm
	int32_t ___XRXvHMDaUbnUKSmMJEaxfPHXxbMm_19;
	// System.Collections.Generic.IEnumerator`1<Rewired.ElementAssignmentConflictInfo> Rewired.Player/ControllerHelper/ConflictCheckingHelper/gPTTtyzOAxLCvPhgMtIrgUsCIpeH`1::HpXSjfddGZNESZUwdNcsLgcceUhy
	RuntimeObject* ___HpXSjfddGZNESZUwdNcsLgcceUhy_20;
};

// System.ArgumentException
struct ArgumentException_tAD90411542A20A9C72D5CDA3A84181D8B947A263  : public SystemException_tCC48D868298F4C0705279823E34B00F4FBDB7295
{
	// System.String System.ArgumentException::_paramName
	String_t* ____paramName_18;
};

// Rewired.Controller
struct Controller_t919A4A50FC7A0F25D7B31615C0F4E4D4A4D17911  : public RuntimeObject
{
	// System.Int32 Rewired.Controller::id
	int32_t ___id_0;
	// System.String Rewired.Controller::_tag
	String_t* ____tag_1;
	// System.String Rewired.Controller::_name
	String_t* ____name_2;
	// System.String Rewired.Controller::_hardwareName
	String_t* ____hardwareName_3;
	// Rewired.ControllerType Rewired.Controller::_type
	int32_t ____type_4;
	// System.Guid Rewired.Controller::VucGuTnWrLUexICHrMfuLpMDiPwB
	Guid_t ___VucGuTnWrLUexICHrMfuLpMDiPwB_5;
	// System.String Rewired.Controller::_hardwareIdentifier
	String_t* ____hardwareIdentifier_6;
	// System.Boolean Rewired.Controller::_isConnected
	bool ____isConnected_7;
	// Rewired.Controller/Extension Rewired.Controller::ASWjdRHfSQEduELqJgMwaGOflbbJc
	Extension_t65CC6FDD7104DC3F9E55C8238302E9F8870162F9* ___ASWjdRHfSQEduELqJgMwaGOflbbJc_8;
	// System.Boolean Rewired.Controller::ITUIszRiaNrsImOTfgAHSPwPTOLe
	bool ___ITUIszRiaNrsImOTfgAHSPwPTOLe_9;
	// Rewired.ControllerIdentifier Rewired.Controller::tJNfNbYLySwKRswjmUWkHYDZmjpy
	ControllerIdentifier_tB97D39E368F2473E38D5C32B427C7E929C905592 ___tJNfNbYLySwKRswjmUWkHYDZmjpy_10;
	// System.Int32 Rewired.Controller::eNyGUiEiMyquCTKLRhFvpeyOvzMm
	int32_t ___eNyGUiEiMyquCTKLRhFvpeyOvzMm_11;
	// System.Int32 Rewired.Controller::_buttonCount
	int32_t ____buttonCount_12;
	// Rewired.Controller/Button[] Rewired.Controller::buttons
	ButtonU5BU5D_t72C5601523D894D77B2BDF77A056019A61C0AF62* ___buttons_13;
	// System.Collections.ObjectModel.ReadOnlyCollection`1<Rewired.Controller/Button> Rewired.Controller::buttons_readOnly
	ReadOnlyCollection_1_t6632538F4C35EC35B77D58F6C62A8C0D52AED202* ___buttons_readOnly_14;
	// System.Collections.Generic.IList`1<Rewired.Controller/Element> Rewired.Controller::FZydGRarJpccYCkKlMkeaFhsIdKT
	RuntimeObject* ___FZydGRarJpccYCkKlMkeaFhsIdKT_15;
	// System.Collections.ObjectModel.ReadOnlyCollection`1<Rewired.Controller/Element> Rewired.Controller::nSbiqQXKVSDSaiJKwBgVawveFWfo
	ReadOnlyCollection_1_tCB75F8E52C91C2CE68136F2CE66A099484F8D615* ___nSbiqQXKVSDSaiJKwBgVawveFWfo_16;
	// System.Collections.Generic.IList`1<Rewired.Controller/CompoundElement> Rewired.Controller::adewKstltyDoFATGkHdgJNMfaboeb
	RuntimeObject* ___adewKstltyDoFATGkHdgJNMfaboeb_17;
	// System.Collections.ObjectModel.ReadOnlyCollection`1<Rewired.Controller/CompoundElement> Rewired.Controller::MkZGTdvWwFCmEcJGZDpznCicochf
	ReadOnlyCollection_1_tD98C9F15A7AA1561CBE4F44983375EEF67277B2C* ___MkZGTdvWwFCmEcJGZDpznCicochf_18;
	// Rewired.InputSource Rewired.Controller::inputSource
	int32_t ___inputSource_19;
	// Rewired.ControllerDataUpdater Rewired.Controller::luXPZItLRMwFxNAWMfXihrwEgVTc
	ControllerDataUpdater_tEA424134962ED8FCA977957E8CAE6B6521D67788* ___luXPZItLRMwFxNAWMfXihrwEgVTc_20;
	// Rewired.HardwareControllerMap_Game Rewired.Controller::EigeWkagcWzRPQmiYOxpLjFTpqseb
	HardwareControllerMap_Game_t3C259C0FEB7E4318075A0A7CAECB7DF1D7AA950A* ___EigeWkagcWzRPQmiYOxpLjFTpqseb_21;
	// System.UInt32 Rewired.Controller::IJiyUmKnjSNPKvEiqQLXnuKpOCsg
	uint32_t ___IJiyUmKnjSNPKvEiqQLXnuKpOCsg_22;
	// System.UInt32 Rewired.Controller::UvuBCPUuHHYtnkIhVxnAOcaTtIcw
	uint32_t ___UvuBCPUuHHYtnkIhVxnAOcaTtIcw_23;
	// System.UInt32 Rewired.Controller::RjewqXqKptDRYmQeaAqwzeLIPikX
	uint32_t ___RjewqXqKptDRYmQeaAqwzeLIPikX_24;
	// System.Action`1<System.Boolean> Rewired.Controller::AErBYrGXWgrwJAqLrNeIFeEEzRynb
	Action_1_t10DCB0C07D0D3C565CEACADC80D1152B35A45F6C* ___AErBYrGXWgrwJAqLrNeIFeEEzRynb_25;
	// Rewired.IControllerTemplate[] Rewired.Controller::tEWJZJTzhuyUFZhjqTlPRfVEydnJ
	IControllerTemplateU5BU5D_tAD319B5FD030C9F0A993A85F2EB5B7A47390C3DB* ___tEWJZJTzhuyUFZhjqTlPRfVEydnJ_26;
	// System.Collections.ObjectModel.ReadOnlyCollection`1<Rewired.IControllerTemplate> Rewired.Controller::zsQnMsRrxAfNPzSctkaVViXeNqUE
	ReadOnlyCollection_1_t18497760E4F1439D0468B3BAC863283807D8A1CA* ___zsQnMsRrxAfNPzSctkaVViXeNqUE_27;
};

struct Controller_t919A4A50FC7A0F25D7B31615C0F4E4D4A4D17911_StaticFields
{
	// System.Func`3<Rewired.Controller,System.Guid,System.Boolean> Rewired.Controller::UAvWYMZpuVTFLFVJDbDZgwlJpKdI
	Func_3_tF4129F872BD8CCCF0D22456285DD4191EE3A59E2* ___UAvWYMZpuVTFLFVJDbDZgwlJpKdI_28;
	// System.Func`3<Rewired.Controller,System.Type,System.Boolean> Rewired.Controller::NhTrfvOUfeTHrvPDlAwBzzTPVKIl
	Func_3_t25669F6E536690B24E25E22CBF39D17E60F1401A* ___NhTrfvOUfeTHrvPDlAwBzzTPVKIl_29;
};

// Rewired.ControllerMapWithAxes
struct ControllerMapWithAxes_tCC6B6F4AA454F60DB2D7F6660FDE33B9F683A036  : public ControllerMap_tC01A582E577E38D21EB7D87A8C040AF5DA285FB3
{
	// System.Collections.Generic.IList`1<Rewired.ActionElementMap> Rewired.ControllerMapWithAxes::xqQatlGNnpDMdyYOrXYgsrbRwfuj
	RuntimeObject* ___xqQatlGNnpDMdyYOrXYgsrbRwfuj_16;
	// System.Collections.ObjectModel.ReadOnlyCollection`1<Rewired.ActionElementMap> Rewired.ControllerMapWithAxes::GFXumgySIugzYYthXnIDqJBrpCZw
	ReadOnlyCollection_1_t4422A6B0A0A793D51A319B9A8A073733A2FACF05* ___GFXumgySIugzYYthXnIDqJBrpCZw_17;
};

// System.InvalidOperationException
struct InvalidOperationException_t5DDE4D49B7405FAAB1E4576F4715A42A3FAD4BAB  : public SystemException_tCC48D868298F4C0705279823E34B00F4FBDB7295
{
};

// System.NotImplementedException
struct NotImplementedException_t6366FE4DCF15094C51F4833B91A2AE68D4DA90E8  : public SystemException_tCC48D868298F4C0705279823E34B00F4FBDB7295
{
};

// System.NotSupportedException
struct NotSupportedException_t1429765983D409BD2986508963C98D214E4EBF4A  : public SystemException_tCC48D868298F4C0705279823E34B00F4FBDB7295
{
};

// Rewired.Controller/Axis
struct Axis_t40E49C8915EBF41DCB550E7E5BE41D5873870A21  : public Element_t58CB6D4FDC2FDD69AC192D19F0F9531FE3F01F76
{
	// Rewired.AxisRange Rewired.Controller/Axis::NzYviSYLfyEbSdOLAVeAHodaVtEz
	int32_t ___NzYviSYLfyEbSdOLAVeAHodaVtEz_8;
	// Rewired.Data.Mapping.HardwareAxisInfo Rewired.Controller/Axis::sYQHkuLOotjVsFrWJzlEaGRmGJQcb
	HardwareAxisInfo_t263803B756A1948668029834C5B184A5590B0654* ___sYQHkuLOotjVsFrWJzlEaGRmGJQcb_9;
};

// UnityEngine.InputSystem.InputActionState/GlobalState
struct GlobalState_tC6D38701EF2670B99D214B9A482C428DFEA8408A 
{
	// UnityEngine.InputSystem.Utilities.InlinedArray`1<System.Runtime.InteropServices.GCHandle> UnityEngine.InputSystem.InputActionState/GlobalState::globalList
	InlinedArray_1_tD165225A32CD54B946FB419909F21C082C70A5B2 ___globalList_0;
	// UnityEngine.InputSystem.Utilities.CallbackArray`1<System.Action`2<System.Object,UnityEngine.InputSystem.InputActionChange>> UnityEngine.InputSystem.InputActionState/GlobalState::onActionChange
	CallbackArray_1_tC72D651E25D95D1B5D837A010859EDE49AD131FA ___onActionChange_1;
	// UnityEngine.InputSystem.Utilities.CallbackArray`1<System.Action`1<System.Object>> UnityEngine.InputSystem.InputActionState/GlobalState::onActionControlsChanged
	CallbackArray_1_tB6F9AD05405749A2888C89224C8F5ECF4E1C0411 ___onActionControlsChanged_2;
};
// Native definition for P/Invoke marshalling of UnityEngine.InputSystem.InputActionState/GlobalState
struct GlobalState_tC6D38701EF2670B99D214B9A482C428DFEA8408A_marshaled_pinvoke
{
	InlinedArray_1_tD165225A32CD54B946FB419909F21C082C70A5B2 ___globalList_0;
	CallbackArray_1_tC72D651E25D95D1B5D837A010859EDE49AD131FA ___onActionChange_1;
	CallbackArray_1_tB6F9AD05405749A2888C89224C8F5ECF4E1C0411 ___onActionControlsChanged_2;
};
// Native definition for COM marshalling of UnityEngine.InputSystem.InputActionState/GlobalState
struct GlobalState_tC6D38701EF2670B99D214B9A482C428DFEA8408A_marshaled_com
{
	InlinedArray_1_tD165225A32CD54B946FB419909F21C082C70A5B2 ___globalList_0;
	CallbackArray_1_tC72D651E25D95D1B5D837A010859EDE49AD131FA ___onActionChange_1;
	CallbackArray_1_tB6F9AD05405749A2888C89224C8F5ECF4E1C0411 ___onActionControlsChanged_2;
};

// Rewired.InputMapper/ukhpurvRuIKYVFmbrHGZXcVzGwlw
struct ukhpurvRuIKYVFmbrHGZXcVzGwlw_tCB0702700C158E9D3CD5837A11109AFF50466BDE  : public RuntimeObject
{
	// Rewired.InputMapper Rewired.InputMapper/ukhpurvRuIKYVFmbrHGZXcVzGwlw::QRBDQxcwDPURDgAFQEKzoUwAfmRw
	InputMapper_tAA873DF879B44D24979B822D811C13484C560F2D* ___QRBDQxcwDPURDgAFQEKzoUwAfmRw_0;
	// Rewired.InputMapper/Options Rewired.InputMapper/ukhpurvRuIKYVFmbrHGZXcVzGwlw::RglqpcthnmYkUQgmnzfLtFbQQGyT
	Options_t2CAC7BDE548C606E2D6149513164D5EF301AEF7A* ___RglqpcthnmYkUQgmnzfLtFbQQGyT_1;
	// Rewired.InputMapper/ukhpurvRuIKYVFmbrHGZXcVzGwlw/OsEuVNimtVPEekMdxjomYkWOLMog Rewired.InputMapper/ukhpurvRuIKYVFmbrHGZXcVzGwlw::zPikTJdwjxnYhhpHqvoyyJbNEUXBA
	OsEuVNimtVPEekMdxjomYkWOLMog_t2C3FF65EA8C3DB3B107A940C4B805F155D3279D5* ___zPikTJdwjxnYhhpHqvoyyJbNEUXBA_2;
	// System.Collections.Generic.Dictionary`2<Rewired.InputMapper/JdpDLqzkBAGmKbSgujDlWammLWSdA,Rewired.Utils.SafeDelegate> Rewired.InputMapper/ukhpurvRuIKYVFmbrHGZXcVzGwlw::ggxGRWdIrRGzvgMJdsLISbkNBGNYA
	Dictionary_2_t501DD8094A745126C4C4ED68F7198F76A46828B2* ___ggxGRWdIrRGzvgMJdsLISbkNBGNYA_3;
	// System.Collections.Generic.Dictionary`2<System.String,Rewired.Utils.SafeDelegate> Rewired.InputMapper/ukhpurvRuIKYVFmbrHGZXcVzGwlw::kQEDpbIrGvgbinAZYRcxGnGhuOMwA
	Dictionary_2_t340D9BC5CF0537B47A79183E8A310B59364118DF* ___kQEDpbIrGvgbinAZYRcxGnGhuOMwA_4;
	// Rewired.InputMapper/Status Rewired.InputMapper/ukhpurvRuIKYVFmbrHGZXcVzGwlw::jorwINXtqLPmxkarLsmjRIMRaIBk
	int32_t ___jorwINXtqLPmxkarLsmjRIMRaIBk_5;
	// Rewired.InputMapper/ukhpurvRuIKYVFmbrHGZXcVzGwlw/ZAvitiMprvVwWCIMvGocPBQgZtpb Rewired.InputMapper/ukhpurvRuIKYVFmbrHGZXcVzGwlw::UuRwyowPjVKoWwalOXWIbCVZaUMz
	int32_t ___UuRwyowPjVKoWwalOXWIbCVZaUMz_6;
	// System.Double Rewired.InputMapper/ukhpurvRuIKYVFmbrHGZXcVzGwlw::uLbOCbEIXDpbhGxBXSDHhdRpBkefA
	double ___uLbOCbEIXDpbhGxBXSDHhdRpBkefA_7;
	// System.Boolean Rewired.InputMapper/ukhpurvRuIKYVFmbrHGZXcVzGwlw::McqhqgiXImPtTvIETNNyJxBrmsCc
	bool ___McqhqgiXImPtTvIETNNyJxBrmsCc_8;
	// System.Collections.Generic.List`1<Rewired.Player> Rewired.InputMapper/ukhpurvRuIKYVFmbrHGZXcVzGwlw::IrYqthwDufLdZUWoioHpXaarjpLx
	List_1_t56D0988F57591B7D9C811A2BFBFF5CEBC8DEAF48* ___IrYqthwDufLdZUWoioHpXaarjpLx_9;
	// System.Collections.Generic.List`1<Rewired.ControllerPollingInfo> Rewired.InputMapper/ukhpurvRuIKYVFmbrHGZXcVzGwlw::rWBaJzeafWfqlGAbzxRxSvEckxygb
	List_1_tDF36E6B2DDE1A6EC1A847DAC438160065068F946* ___rWBaJzeafWfqlGAbzxRxSvEckxygb_10;
	// Rewired.ElementAssignment Rewired.InputMapper/ukhpurvRuIKYVFmbrHGZXcVzGwlw::GOAQtObMkWQBCkOXkHVvLldcMags
	ElementAssignment_t45CE7B6338F007990CB6929D43BCBCB4C84D8657 ___GOAQtObMkWQBCkOXkHVvLldcMags_11;
};

// System.ArgumentNullException
struct ArgumentNullException_t327031E412FAB2351B0022DD5DAD47E67E597129  : public ArgumentException_tAD90411542A20A9C72D5CDA3A84181D8B947A263
{
};

// Rewired.ControllerWithMap
struct ControllerWithMap_tDA93D51D7AC196DF607F4B71C9362BC7A8082CA0  : public Controller_t919A4A50FC7A0F25D7B31615C0F4E4D4A4D17911
{
};

// UnityEngine.InputSystem.InputActionState
struct InputActionState_t780948EA293BAA800AD8699518B58B59FFB8A700  : public RuntimeObject
{
	// UnityEngine.InputSystem.InputActionMap[] UnityEngine.InputSystem.InputActionState::maps
	InputActionMapU5BU5D_t4B352E8DA73976FEDA107E35E81FB5BE6838C045* ___maps_1;
	// UnityEngine.InputSystem.InputControl[] UnityEngine.InputSystem.InputActionState::controls
	InputControlU5BU5D_t0B951FEF1504D6340387C4735F5D6F426F40FE17* ___controls_2;
	// UnityEngine.InputSystem.IInputInteraction[] UnityEngine.InputSystem.InputActionState::interactions
	IInputInteractionU5BU5D_t175AB10EB3221C36393F258F530F94D8DD01CB93* ___interactions_3;
	// UnityEngine.InputSystem.InputProcessor[] UnityEngine.InputSystem.InputActionState::processors
	InputProcessorU5BU5D_t79582BEBC3FAF824D9762566AA6E979F95E6EB64* ___processors_4;
	// UnityEngine.InputSystem.InputBindingComposite[] UnityEngine.InputSystem.InputActionState::composites
	InputBindingCompositeU5BU5D_tB9A645573A56F8DC9EC7AD84F1BE24C2B0F4319E* ___composites_5;
	// System.Int32 UnityEngine.InputSystem.InputActionState::totalProcessorCount
	int32_t ___totalProcessorCount_6;
	// UnityEngine.InputSystem.InputActionState/UnmanagedMemory UnityEngine.InputSystem.InputActionState::memory
	UnmanagedMemory_t862EBE5224929ED0E2F989D790EB6B8633E612A2 ___memory_7;
	// System.Boolean UnityEngine.InputSystem.InputActionState::m_OnBeforeUpdateHooked
	bool ___m_OnBeforeUpdateHooked_8;
	// System.Boolean UnityEngine.InputSystem.InputActionState::m_OnAfterUpdateHooked
	bool ___m_OnAfterUpdateHooked_9;
	// System.Boolean UnityEngine.InputSystem.InputActionState::m_InProcessControlStateChange
	bool ___m_InProcessControlStateChange_10;
	// System.Action UnityEngine.InputSystem.InputActionState::m_OnBeforeUpdateDelegate
	Action_tD00B0A84D7945E50C2DFFC28EFEE6ED44ED2AD07* ___m_OnBeforeUpdateDelegate_11;
	// System.Action UnityEngine.InputSystem.InputActionState::m_OnAfterUpdateDelegate
	Action_tD00B0A84D7945E50C2DFFC28EFEE6ED44ED2AD07* ___m_OnAfterUpdateDelegate_12;
};

struct InputActionState_t780948EA293BAA800AD8699518B58B59FFB8A700_StaticFields
{
	// UnityEngine.InputSystem.InputActionState/GlobalState UnityEngine.InputSystem.InputActionState::s_GlobalState
	GlobalState_tC6D38701EF2670B99D214B9A482C428DFEA8408A ___s_GlobalState_13;
};

// UnityEngine.InputSystem.InputActionRebindingExtensions/RebindingOperation
struct RebindingOperation_tF7D9BCBB6E69668FA3A5C211104FF8637F9F3470  : public RuntimeObject
{
	// UnityEngine.InputSystem.InputAction UnityEngine.InputSystem.InputActionRebindingExtensions/RebindingOperation::m_ActionToRebind
	InputAction_t1B550AD2B55AF322AFB53CD28DA64081220D01CD* ___m_ActionToRebind_1;
	// System.Nullable`1<UnityEngine.InputSystem.InputBinding> UnityEngine.InputSystem.InputActionRebindingExtensions/RebindingOperation::m_BindingMask
	Nullable_1_t11786EE914FE65E70B9671129B0DFC4D0DE80C44 ___m_BindingMask_2;
	// System.Type UnityEngine.InputSystem.InputActionRebindingExtensions/RebindingOperation::m_ControlType
	Type_t* ___m_ControlType_3;
	// UnityEngine.InputSystem.Utilities.InternedString UnityEngine.InputSystem.InputActionRebindingExtensions/RebindingOperation::m_ExpectedLayout
	InternedString_t8D62A48CB7D85AAE9CFCCCFB0A77AC2844905735 ___m_ExpectedLayout_4;
	// System.Int32 UnityEngine.InputSystem.InputActionRebindingExtensions/RebindingOperation::m_IncludePathCount
	int32_t ___m_IncludePathCount_5;
	// System.String[] UnityEngine.InputSystem.InputActionRebindingExtensions/RebindingOperation::m_IncludePaths
	StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248* ___m_IncludePaths_6;
	// System.Int32 UnityEngine.InputSystem.InputActionRebindingExtensions/RebindingOperation::m_ExcludePathCount
	int32_t ___m_ExcludePathCount_7;
	// System.String[] UnityEngine.InputSystem.InputActionRebindingExtensions/RebindingOperation::m_ExcludePaths
	StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248* ___m_ExcludePaths_8;
	// System.Int32 UnityEngine.InputSystem.InputActionRebindingExtensions/RebindingOperation::m_TargetBindingIndex
	int32_t ___m_TargetBindingIndex_9;
	// System.String UnityEngine.InputSystem.InputActionRebindingExtensions/RebindingOperation::m_BindingGroupForNewBinding
	String_t* ___m_BindingGroupForNewBinding_10;
	// System.String UnityEngine.InputSystem.InputActionRebindingExtensions/RebindingOperation::m_CancelBinding
	String_t* ___m_CancelBinding_11;
	// System.Single UnityEngine.InputSystem.InputActionRebindingExtensions/RebindingOperation::m_MagnitudeThreshold
	float ___m_MagnitudeThreshold_12;
	// System.Single[] UnityEngine.InputSystem.InputActionRebindingExtensions/RebindingOperation::m_Scores
	SingleU5BU5D_t89DEFE97BCEDB5857010E79ECE0F52CF6E93B87C* ___m_Scores_13;
	// System.Single[] UnityEngine.InputSystem.InputActionRebindingExtensions/RebindingOperation::m_Magnitudes
	SingleU5BU5D_t89DEFE97BCEDB5857010E79ECE0F52CF6E93B87C* ___m_Magnitudes_14;
	// System.Double UnityEngine.InputSystem.InputActionRebindingExtensions/RebindingOperation::m_LastMatchTime
	double ___m_LastMatchTime_15;
	// System.Double UnityEngine.InputSystem.InputActionRebindingExtensions/RebindingOperation::m_StartTime
	double ___m_StartTime_16;
	// System.Single UnityEngine.InputSystem.InputActionRebindingExtensions/RebindingOperation::m_Timeout
	float ___m_Timeout_17;
	// System.Single UnityEngine.InputSystem.InputActionRebindingExtensions/RebindingOperation::m_WaitSecondsAfterMatch
	float ___m_WaitSecondsAfterMatch_18;
	// UnityEngine.InputSystem.InputControlList`1<UnityEngine.InputSystem.InputControl> UnityEngine.InputSystem.InputActionRebindingExtensions/RebindingOperation::m_Candidates
	InputControlList_1_tDCD1283F428BB911908D4A86066022F6FEF337BA ___m_Candidates_19;
	// System.Action`1<UnityEngine.InputSystem.InputActionRebindingExtensions/RebindingOperation> UnityEngine.InputSystem.InputActionRebindingExtensions/RebindingOperation::m_OnComplete
	Action_1_tF6BB59F9C8D153E48DFC364061E5356934611FDD* ___m_OnComplete_20;
	// System.Action`1<UnityEngine.InputSystem.InputActionRebindingExtensions/RebindingOperation> UnityEngine.InputSystem.InputActionRebindingExtensions/RebindingOperation::m_OnCancel
	Action_1_tF6BB59F9C8D153E48DFC364061E5356934611FDD* ___m_OnCancel_21;
	// System.Action`1<UnityEngine.InputSystem.InputActionRebindingExtensions/RebindingOperation> UnityEngine.InputSystem.InputActionRebindingExtensions/RebindingOperation::m_OnPotentialMatch
	Action_1_tF6BB59F9C8D153E48DFC364061E5356934611FDD* ___m_OnPotentialMatch_22;
	// System.Func`2<UnityEngine.InputSystem.InputControl,System.String> UnityEngine.InputSystem.InputActionRebindingExtensions/RebindingOperation::m_OnGeneratePath
	Func_2_t6880601B06FFA50F13EB20F6845F85618318BA8A* ___m_OnGeneratePath_23;
	// System.Func`3<UnityEngine.InputSystem.InputControl,UnityEngine.InputSystem.LowLevel.InputEventPtr,System.Single> UnityEngine.InputSystem.InputActionRebindingExtensions/RebindingOperation::m_OnComputeScore
	Func_3_tD434E786A74561C49424384EF1C6D03B9B0498F4* ___m_OnComputeScore_24;
	// System.Action`2<UnityEngine.InputSystem.InputActionRebindingExtensions/RebindingOperation,System.String> UnityEngine.InputSystem.InputActionRebindingExtensions/RebindingOperation::m_OnApplyBinding
	Action_2_t464826F5F8CD9F38C1A734DDCFBF2AE3CC4DBF79* ___m_OnApplyBinding_25;
	// System.Action`2<UnityEngine.InputSystem.LowLevel.InputEventPtr,UnityEngine.InputSystem.InputDevice> UnityEngine.InputSystem.InputActionRebindingExtensions/RebindingOperation::m_OnEventDelegate
	Action_2_t4943DD8C32CAB983950535CEF3BABA85DF8C9AAA* ___m_OnEventDelegate_26;
	// System.Action UnityEngine.InputSystem.InputActionRebindingExtensions/RebindingOperation::m_OnAfterUpdateDelegate
	Action_tD00B0A84D7945E50C2DFFC28EFEE6ED44ED2AD07* ___m_OnAfterUpdateDelegate_27;
	// UnityEngine.InputSystem.Layouts.InputControlLayout/Cache UnityEngine.InputSystem.InputActionRebindingExtensions/RebindingOperation::m_LayoutCache
	Cache_tB837109647F577DCE3795AEE2E9E0E3F61F543AB ___m_LayoutCache_28;
	// System.Text.StringBuilder UnityEngine.InputSystem.InputActionRebindingExtensions/RebindingOperation::m_PathBuilder
	StringBuilder_t* ___m_PathBuilder_29;
	// UnityEngine.InputSystem.InputActionRebindingExtensions/RebindingOperation/Flags UnityEngine.InputSystem.InputActionRebindingExtensions/RebindingOperation::m_Flags
	int32_t ___m_Flags_30;
	// System.Collections.Generic.Dictionary`2<UnityEngine.InputSystem.InputControl,System.Single> UnityEngine.InputSystem.InputActionRebindingExtensions/RebindingOperation::m_StartingActuations
	Dictionary_2_t955741F14981C0BAF47FDE7823F2703758A8723C* ___m_StartingActuations_31;
};

// Rewired.ControllerWithAxes
struct ControllerWithAxes_tF5DF4B1A98C0326D31E6AC481DEBC2D90E44BBF2  : public ControllerWithMap_tDA93D51D7AC196DF607F4B71C9362BC7A8082CA0
{
	// System.Int32 Rewired.ControllerWithAxes::_axisCount
	int32_t ____axisCount_30;
	// System.Int32 Rewired.ControllerWithAxes::_axis2DCount
	int32_t ____axis2DCount_31;
	// Rewired.Controller/Axis[] Rewired.ControllerWithAxes::axes
	AxisU5BU5D_t916A735FDE7F513AC969A292CC357867FF480130* ___axes_32;
	// System.Collections.ObjectModel.ReadOnlyCollection`1<Rewired.Controller/Axis> Rewired.ControllerWithAxes::axes_readOnly
	ReadOnlyCollection_1_tB5EF8E1B2FF9A9E725D5336E156B0198E37F279E* ___axes_readOnly_33;
	// Rewired.Controller/Axis2D[] Rewired.ControllerWithAxes::axes2D
	Axis2DU5BU5D_t9C78A228E204FB5FD3784D0A07C4A949D7D20275* ___axes2D_34;
	// System.Collections.ObjectModel.ReadOnlyCollection`1<Rewired.Controller/Axis2D> Rewired.ControllerWithAxes::axes2D_readOnly
	ReadOnlyCollection_1_t4BF02BD2DB828FB8E2D86BD177AE488D4A64FBF1* ___axes2D_readOnly_35;
	// Rewired.CalibrationMap Rewired.ControllerWithAxes::_calibrationMap
	CalibrationMap_tB57C4727A9D4F4ED745A6E5D7E4398452D7A499B* ____calibrationMap_36;
	// System.Single[] Rewired.ControllerWithAxes::vPwoHNAaYOokkvIDqBSOrHyuAjIB
	SingleU5BU5D_t89DEFE97BCEDB5857010E79ECE0F52CF6E93B87C* ___vPwoHNAaYOokkvIDqBSOrHyuAjIB_37;
	// System.UInt32 Rewired.ControllerWithAxes::ACOROWhCMucURKgwzqlCBhUwLudF
	uint32_t ___ACOROWhCMucURKgwzqlCBhUwLudF_38;
	// System.Func`2<System.Int32,System.Int32> Rewired.ControllerWithAxes::NkbfxqnjJyGKJGxxNqmjOLIAIAA
	Func_2_t2FDA873D8482C79555CFB05233D610E8F1C7C354* ___NkbfxqnjJyGKJGxxNqmjOLIAIAA_39;
};

// Rewired.Keyboard
struct Keyboard_t3FD52938480ACCD23FDB0DAEC857F9A9D29CC6C3  : public ControllerWithMap_tDA93D51D7AC196DF607F4B71C9362BC7A8082CA0
{
	// Rewired.Interfaces.IUnifiedKeyboardSource Rewired.Keyboard::SlnFGwrpDzXmNqPJLRibJOYdFyFCA
	RuntimeObject* ___SlnFGwrpDzXmNqPJLRibJOYdFyFCA_31;
	// Rewired.ModifierKeyFlags Rewired.Keyboard::VDERYFObdHfJkBqHAgKUuumeJbDGA
	int32_t ___VDERYFObdHfJkBqHAgKUuumeJbDGA_32;
	// Rewired.ModifierKeyFlags Rewired.Keyboard::fGnEpiJhfnxloJJkYmBhVlljKOceA
	int32_t ___fGnEpiJhfnxloJJkYmBhVlljKOceA_33;
	// System.Func`2<Rewired.KeyboardKeyCode,System.Int32> Rewired.Keyboard::GyocimIOilSYeQMlWskPHfLpCVERA
	Func_2_t240970B8565E959C4ACC2E19699CC15D8EA61648* ___GyocimIOilSYeQMlWskPHfLpCVERA_34;
	// System.Int32[] Rewired.Keyboard::MpdajWVLvJvhPOMIRaCNmppAEDAX
	Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* ___MpdajWVLvJvhPOMIRaCNmppAEDAX_35;
	// System.Int32 Rewired.Keyboard::YAWfPJoVuInBpZOTcVMrLJxPymoP
	int32_t ___YAWfPJoVuInBpZOTcVMrLJxPymoP_37;
};

struct Keyboard_t3FD52938480ACCD23FDB0DAEC857F9A9D29CC6C3_StaticFields
{
	// Rewired.Keyboard Rewired.Keyboard::nsqNtMPcDaxgXTbTEqQncAPmjTIP
	Keyboard_t3FD52938480ACCD23FDB0DAEC857F9A9D29CC6C3* ___nsqNtMPcDaxgXTbTEqQncAPmjTIP_30;
	// Rewired.KeyboardKeyCode[] Rewired.Keyboard::XhxHFCLDAtXlnigZkcpYFAaFmZTq
	KeyboardKeyCodeU5BU5D_tD02BBA7D7118E8F929F05A8F12F5CFD6E4E2BD94* ___XhxHFCLDAtXlnigZkcpYFAaFmZTq_36;
	// System.Guid Rewired.Keyboard::VjMbjzdaepIRDUwqqBKAcXQFLsnOB
	Guid_t ___VjMbjzdaepIRDUwqqBKAcXQFLsnOB_38;
};

// Rewired.CustomController
struct CustomController_t749B7DF2AA8AD20FEC4C2003C4FF5000FE9C6065  : public ControllerWithAxes_tF5DF4B1A98C0326D31E6AC481DEBC2D90E44BBF2
{
	// System.Int32 Rewired.CustomController::YOyngfCLgSHzkgxRVDBgbvRhczNXA
	int32_t ___YOyngfCLgSHzkgxRVDBgbvRhczNXA_40;
	// System.Func`2<System.Int32,System.Single> Rewired.CustomController::fDmeMXWIPKDYsYXreVtwEiELEgau
	Func_2_tBBFF35F4EA206696290D8B23ED36491D37219FAF* ___fDmeMXWIPKDYsYXreVtwEiELEgau_41;
	// System.Func`2<System.Int32,System.Boolean> Rewired.CustomController::RFEChGfboZXJLuMwpTqSulZODZzWA
	Func_2_t63A057E8762189D8C22BF71360D00C1047680DFA* ___RFEChGfboZXJLuMwpTqSulZODZzWA_42;
	// System.Boolean Rewired.CustomController::UKraxsomWTghrzGRgjUPWwGNreWQ
	bool ___UKraxsomWTghrzGRgjUPWwGNreWQ_43;
	// System.Guid Rewired.CustomController::AdVWPVeeWREAKYnPcptASCNIkCUG
	Guid_t ___AdVWPVeeWREAKYnPcptASCNIkCUG_44;
};

// Rewired.Joystick
struct Joystick_tEC65D4846A553E83F365E7D8D263DC644C75FC11  : public ControllerWithAxes_tF5DF4B1A98C0326D31E6AC481DEBC2D90E44BBF2
{
	// Rewired.Interfaces.IInputManagerJoystickPublic Rewired.Joystick::aLcbaOBhLZPOiVweHcWNvImZHrBu
	RuntimeObject* ___aLcbaOBhLZPOiVweHcWNvImZHrBu_42;
	// Rewired.JoystickType[] Rewired.Joystick::deIyAcImqRDLCzAFnRIvLjJixOCp
	JoystickTypeU5BU5D_t5D2FA180BDE2C05F0EAEF261D865F849DDE618F3* ___deIyAcImqRDLCzAFnRIvLjJixOCp_43;
	// System.Collections.ObjectModel.ReadOnlyCollection`1<Rewired.JoystickType> Rewired.Joystick::WMRlVopTdXrxsEncMJodsbPOnsPu
	ReadOnlyCollection_1_t684D7E9748C38CB042B553714053F690BF574087* ___WMRlVopTdXrxsEncMJodsbPOnsPu_44;
	// System.Boolean Rewired.Joystick::mviKlBEhbNgnvmWIAsThalKuaabK
	bool ___mviKlBEhbNgnvmWIAsThalKuaabK_45;
	// System.Boolean Rewired.Joystick::SldLdCycsmDrcEefUpUOmjbunKicb
	bool ___SldLdCycsmDrcEefUpUOmjbunKicb_46;
	// System.Boolean Rewired.Joystick::ZWNjFFlzwnQgrILaIsixigLAdqAdA
	bool ___ZWNjFFlzwnQgrILaIsixigLAdqAdA_47;
	// System.Int32 Rewired.Joystick::pAnqdIqoJxQmEKvhlpzMALPYnJZK
	int32_t ___pAnqdIqoJxQmEKvhlpzMALPYnJZK_48;
	// System.Single[] Rewired.Joystick::IWBLyjZUgsBYDIKLNcAMpnQGfTwDA
	SingleU5BU5D_t89DEFE97BCEDB5857010E79ECE0F52CF6E93B87C* ___IWBLyjZUgsBYDIKLNcAMpnQGfTwDA_49;
	// Rewired.Utils.Classes.Utility.TimerAbs[] Rewired.Joystick::EMEsCioSizWoIyrdsGtiTybcfNPc
	TimerAbsU5BU5D_t7B70F57AD43475723B6291E67F95C40BC81A05A7* ___EMEsCioSizWoIyrdsGtiTybcfNPc_50;
	// System.Int32 Rewired.Joystick::JpyskdUDXpBXQKbIGKaaIbuKnLeB
	int32_t ___JpyskdUDXpBXQKbIGKaaIbuKnLeB_51;
	// Rewired.Controller/Hat[] Rewired.Joystick::XcFAfVCQEfKqVGvWMItzAHkwcUWbA
	HatU5BU5D_t6CBFAC9CEFA700897CA5E4A7A11546019B04731A* ___XcFAfVCQEfKqVGvWMItzAHkwcUWbA_52;
	// System.Collections.ObjectModel.ReadOnlyCollection`1<Rewired.Controller/Hat> Rewired.Joystick::bQSukWsZsXrGgujxMJMcYPkyFkQM
	ReadOnlyCollection_1_t7397792A05B6580C63C5944D32B9BC6B8A7833D9* ___bQSukWsZsXrGgujxMJMcYPkyFkQM_53;
};

// Rewired.Mouse
struct Mouse_t5C8D9CB89A5C0F4EE87A70501CAF2A68E36DC019  : public ControllerWithAxes_tF5DF4B1A98C0326D31E6AC481DEBC2D90E44BBF2
{
	// Rewired.Utils.Classes.Utility.TimerAbs Rewired.Mouse::PYTFbIGqKRqUeUWxOQwSiqwOrwLS
	TimerAbs_t49C1588F0A9377F7A54285F7C44A6591FBA42E36* ___PYTFbIGqKRqUeUWxOQwSiqwOrwLS_40;
	// System.Single[] Rewired.Mouse::lfsPkYNhkampamJMsDtVEQZWqqQuA
	SingleU5BU5D_t89DEFE97BCEDB5857010E79ECE0F52CF6E93B87C* ___lfsPkYNhkampamJMsDtVEQZWqqQuA_41;
	// UnityEngine.Vector2 Rewired.Mouse::jzmaLSeejyVFcBDJhNdXskWmvldiA
	Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 ___jzmaLSeejyVFcBDJhNdXskWmvldiA_42;
	// UnityEngine.Vector2 Rewired.Mouse::bepWGKslGaqPZbBOSvAaCpgAEuOP
	Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 ___bepWGKslGaqPZbBOSvAaCpgAEuOP_43;
	// System.Int32 Rewired.Mouse::JKKIGvNrketwVZFscEdlqOeUazEv
	int32_t ___JKKIGvNrketwVZFscEdlqOeUazEv_44;
	// Rewired.Interfaces.IUnifiedMouseSource Rewired.Mouse::SlnFGwrpDzXmNqPJLRibJOYdFyFCA
	RuntimeObject* ___SlnFGwrpDzXmNqPJLRibJOYdFyFCA_45;
};

struct Mouse_t5C8D9CB89A5C0F4EE87A70501CAF2A68E36DC019_StaticFields
{
	// System.Guid Rewired.Mouse::VjMbjzdaepIRDUwqqBKAcXQFLsnOB
	Guid_t ___VjMbjzdaepIRDUwqqBKAcXQFLsnOB_46;
};
#ifdef __clang__
#pragma clang diagnostic pop
#endif
// System.String[]
struct StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248  : public RuntimeArray
{
	ALIGN_FIELD (8) String_t* m_Items[1];

	inline String_t* GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline String_t** GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, String_t* value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
	inline String_t* GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline String_t** GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, String_t* value)
	{
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
};
// UnityEngine.AndroidJavaObject[]
struct AndroidJavaObjectU5BU5D_tBCEB142050F282B940177011644246618E002001  : public RuntimeArray
{
	ALIGN_FIELD (8) AndroidJavaObject_t8FFB930F335C1178405B82AC2BF512BB1EEF9EB0* m_Items[1];

	inline AndroidJavaObject_t8FFB930F335C1178405B82AC2BF512BB1EEF9EB0* GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline AndroidJavaObject_t8FFB930F335C1178405B82AC2BF512BB1EEF9EB0** GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, AndroidJavaObject_t8FFB930F335C1178405B82AC2BF512BB1EEF9EB0* value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
	inline AndroidJavaObject_t8FFB930F335C1178405B82AC2BF512BB1EEF9EB0* GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline AndroidJavaObject_t8FFB930F335C1178405B82AC2BF512BB1EEF9EB0** GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, AndroidJavaObject_t8FFB930F335C1178405B82AC2BF512BB1EEF9EB0* value)
	{
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
};
// System.Int32[]
struct Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C  : public RuntimeArray
{
	ALIGN_FIELD (8) int32_t m_Items[1];

	inline int32_t GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline int32_t* GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, int32_t value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
	}
	inline int32_t GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline int32_t* GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, int32_t value)
	{
		m_Items[index] = value;
	}
};
// System.Boolean[]
struct BooleanU5BU5D_tD317D27C31DB892BE79FAE3AEBC0B3FFB73DE9B4  : public RuntimeArray
{
	ALIGN_FIELD (8) bool m_Items[1];

	inline bool GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline bool* GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, bool value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
	}
	inline bool GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline bool* GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, bool value)
	{
		m_Items[index] = value;
	}
};
// System.Byte[]
struct ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031  : public RuntimeArray
{
	ALIGN_FIELD (8) uint8_t m_Items[1];

	inline uint8_t GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline uint8_t* GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, uint8_t value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
	}
	inline uint8_t GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline uint8_t* GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, uint8_t value)
	{
		m_Items[index] = value;
	}
};
// System.SByte[]
struct SByteU5BU5D_t88116DA68378C3333DB73E7D36C1A06AFAA91913  : public RuntimeArray
{
	ALIGN_FIELD (8) int8_t m_Items[1];

	inline int8_t GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline int8_t* GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, int8_t value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
	}
	inline int8_t GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline int8_t* GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, int8_t value)
	{
		m_Items[index] = value;
	}
};
// System.Int16[]
struct Int16U5BU5D_t8175CE8DD9C9F9FB0CF4F58E45BC570575B43CFB  : public RuntimeArray
{
	ALIGN_FIELD (8) int16_t m_Items[1];

	inline int16_t GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline int16_t* GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, int16_t value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
	}
	inline int16_t GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline int16_t* GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, int16_t value)
	{
		m_Items[index] = value;
	}
};
// System.Int64[]
struct Int64U5BU5D_tAEDFCBDB5414E2A140A6F34C0538BF97FCF67A1D  : public RuntimeArray
{
	ALIGN_FIELD (8) int64_t m_Items[1];

	inline int64_t GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline int64_t* GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, int64_t value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
	}
	inline int64_t GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline int64_t* GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, int64_t value)
	{
		m_Items[index] = value;
	}
};
// System.Single[]
struct SingleU5BU5D_t89DEFE97BCEDB5857010E79ECE0F52CF6E93B87C  : public RuntimeArray
{
	ALIGN_FIELD (8) float m_Items[1];

	inline float GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline float* GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, float value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
	}
	inline float GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline float* GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, float value)
	{
		m_Items[index] = value;
	}
};
// System.Double[]
struct DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE  : public RuntimeArray
{
	ALIGN_FIELD (8) double m_Items[1];

	inline double GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline double* GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, double value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
	}
	inline double GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline double* GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, double value)
	{
		m_Items[index] = value;
	}
};
// System.Char[]
struct CharU5BU5D_t799905CF001DD5F13F7DBB310181FC4D8B7D0AAB  : public RuntimeArray
{
	ALIGN_FIELD (8) Il2CppChar m_Items[1];

	inline Il2CppChar GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline Il2CppChar* GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, Il2CppChar value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
	}
	inline Il2CppChar GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline Il2CppChar* GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, Il2CppChar value)
	{
		m_Items[index] = value;
	}
};
// System.Object[]
struct ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918  : public RuntimeArray
{
	ALIGN_FIELD (8) RuntimeObject* m_Items[1];

	inline RuntimeObject* GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline RuntimeObject** GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, RuntimeObject* value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
	inline RuntimeObject* GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline RuntimeObject** GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, RuntimeObject* value)
	{
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
};
// Rewired.Controller/CompoundElement/kfzfjnagLVVtsyAzdAlUhZdNuSIQA[]
struct kfzfjnagLVVtsyAzdAlUhZdNuSIQAU5BU5D_tEEB780C862E2161EBC7C54D3F94963F74723F9AB  : public RuntimeArray
{
	ALIGN_FIELD (8) kfzfjnagLVVtsyAzdAlUhZdNuSIQA_tCE87DA4E243A151D523511BE81757930A8E88FBE* m_Items[1];

	inline kfzfjnagLVVtsyAzdAlUhZdNuSIQA_tCE87DA4E243A151D523511BE81757930A8E88FBE* GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline kfzfjnagLVVtsyAzdAlUhZdNuSIQA_tCE87DA4E243A151D523511BE81757930A8E88FBE** GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, kfzfjnagLVVtsyAzdAlUhZdNuSIQA_tCE87DA4E243A151D523511BE81757930A8E88FBE* value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
	inline kfzfjnagLVVtsyAzdAlUhZdNuSIQA_tCE87DA4E243A151D523511BE81757930A8E88FBE* GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline kfzfjnagLVVtsyAzdAlUhZdNuSIQA_tCE87DA4E243A151D523511BE81757930A8E88FBE** GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, kfzfjnagLVVtsyAzdAlUhZdNuSIQA_tCE87DA4E243A151D523511BE81757930A8E88FBE* value)
	{
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
};
// Rewired.IControllerTemplate[]
struct IControllerTemplateU5BU5D_tAD319B5FD030C9F0A993A85F2EB5B7A47390C3DB  : public RuntimeArray
{
	ALIGN_FIELD (8) RuntimeObject* m_Items[1];

	inline RuntimeObject* GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline RuntimeObject** GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, RuntimeObject* value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
	inline RuntimeObject* GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline RuntimeObject** GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, RuntimeObject* value)
	{
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
};
// Rewired.ActionElementMap[]
struct ActionElementMapU5BU5D_t695D4AC334ED6665D93DB89FAFA472C4F2CAADAE  : public RuntimeArray
{
	ALIGN_FIELD (8) ActionElementMap_t0EBE3E5D3A5DF3BA6D35F8082ED2232404EFF8CF* m_Items[1];

	inline ActionElementMap_t0EBE3E5D3A5DF3BA6D35F8082ED2232404EFF8CF* GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline ActionElementMap_t0EBE3E5D3A5DF3BA6D35F8082ED2232404EFF8CF** GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, ActionElementMap_t0EBE3E5D3A5DF3BA6D35F8082ED2232404EFF8CF* value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
	inline ActionElementMap_t0EBE3E5D3A5DF3BA6D35F8082ED2232404EFF8CF* GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline ActionElementMap_t0EBE3E5D3A5DF3BA6D35F8082ED2232404EFF8CF** GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, ActionElementMap_t0EBE3E5D3A5DF3BA6D35F8082ED2232404EFF8CF* value)
	{
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
};


// TValue UnityEngine.InputSystem.InputAction/CallbackContext::ReadValue<UnityEngine.Quaternion>()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 CallbackContext_ReadValue_TisQuaternion_tDA59F214EF07D7700B26E40E562F267AF7306974_m020AD5873BB6CE85B752DF8D11920FA5FB46214E_gshared (CallbackContext_tB251EE41F509C6E8A6B05EC97C029A45DF4F5FA8* __this, const RuntimeMethod* method) ;
// TValue UnityEngine.InputSystem.InputAction/CallbackContext::ReadValue<System.Single>()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float CallbackContext_ReadValue_TisSingle_t4530F2FF86FCB0DC29F35385CA1BD21BE294761C_m7EBC8C123F0601CE5B340BA966923AEC449A8ACF_gshared (CallbackContext_tB251EE41F509C6E8A6B05EC97C029A45DF4F5FA8* __this, const RuntimeMethod* method) ;
// TValue UnityEngine.InputSystem.InputAction/CallbackContext::ReadValue<UnityEngine.Vector2>()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 CallbackContext_ReadValue_TisVector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7_m454ADEAE74A5A469E011CF78D6303A1034659830_gshared (CallbackContext_tB251EE41F509C6E8A6B05EC97C029A45DF4F5FA8* __this, const RuntimeMethod* method) ;
// TValue UnityEngine.InputSystem.InputAction/CallbackContext::ReadValue<UnityEngine.Vector3>()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 CallbackContext_ReadValue_TisVector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2_mC5704121342A8A761FA496E4922FDA7B37C20EDD_gshared (CallbackContext_tB251EE41F509C6E8A6B05EC97C029A45DF4F5FA8* __this, const RuntimeMethod* method) ;
// UnityEngine.InputSystem.InputActionSetupExtensions/BindingSyntax UnityEngine.InputSystem.InputActionSetupExtensions/BindingSyntax::WithInteraction<System.Object>()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR BindingSyntax_t5FB93D8F3518B4640E42E067ECB15541CD123317 BindingSyntax_WithInteraction_TisRuntimeObject_mA9CD41BB913C678CE5891E3C51871CBFCFB13254_gshared (BindingSyntax_t5FB93D8F3518B4640E42E067ECB15541CD123317* __this, const RuntimeMethod* method) ;
// UnityEngine.InputSystem.InputActionSetupExtensions/BindingSyntax UnityEngine.InputSystem.InputActionSetupExtensions/BindingSyntax::WithProcessor<System.Object>()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR BindingSyntax_t5FB93D8F3518B4640E42E067ECB15541CD123317 BindingSyntax_WithProcessor_TisRuntimeObject_m88180835A3724BF9C98DC39A8CB6146B2B3BC1DE_gshared (BindingSyntax_t5FB93D8F3518B4640E42E067ECB15541CD123317* __this, const RuntimeMethod* method) ;
// System.String UnityEngine.InputSystem.InputActionSetupExtensions/ControlSchemeSyntax::DeviceTypeToControlPath<System.Object>()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* ControlSchemeSyntax_DeviceTypeToControlPath_TisRuntimeObject_mF63A1990BA907932D19EC7FA27A34BC1A855D21A_gshared (ControlSchemeSyntax_t4C14E0745C729675BFFADA8275391ACBAD73227D* __this, const RuntimeMethod* method) ;
// UnityEngine.InputSystem.InputActionSetupExtensions/ControlSchemeSyntax UnityEngine.InputSystem.InputActionSetupExtensions/ControlSchemeSyntax::OrWithOptionalDevice<System.Object>()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR ControlSchemeSyntax_t4C14E0745C729675BFFADA8275391ACBAD73227D ControlSchemeSyntax_OrWithOptionalDevice_TisRuntimeObject_mF382F898E47985498314A5A60EF2542B5607DF53_gshared (ControlSchemeSyntax_t4C14E0745C729675BFFADA8275391ACBAD73227D* __this, const RuntimeMethod* method) ;
// UnityEngine.InputSystem.InputActionSetupExtensions/ControlSchemeSyntax UnityEngine.InputSystem.InputActionSetupExtensions/ControlSchemeSyntax::OrWithRequiredDevice<System.Object>()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR ControlSchemeSyntax_t4C14E0745C729675BFFADA8275391ACBAD73227D ControlSchemeSyntax_OrWithRequiredDevice_TisRuntimeObject_m82C53906C0350BE78EBA1C410BC169C64E555CDE_gshared (ControlSchemeSyntax_t4C14E0745C729675BFFADA8275391ACBAD73227D* __this, const RuntimeMethod* method) ;
// UnityEngine.InputSystem.InputActionSetupExtensions/ControlSchemeSyntax UnityEngine.InputSystem.InputActionSetupExtensions/ControlSchemeSyntax::WithOptionalDevice<System.Object>()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR ControlSchemeSyntax_t4C14E0745C729675BFFADA8275391ACBAD73227D ControlSchemeSyntax_WithOptionalDevice_TisRuntimeObject_m44DA2464CBBE7A51A89945D7B96BB4114B0CDFEA_gshared (ControlSchemeSyntax_t4C14E0745C729675BFFADA8275391ACBAD73227D* __this, const RuntimeMethod* method) ;
// UnityEngine.InputSystem.InputActionSetupExtensions/ControlSchemeSyntax UnityEngine.InputSystem.InputActionSetupExtensions/ControlSchemeSyntax::WithRequiredDevice<System.Object>()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR ControlSchemeSyntax_t4C14E0745C729675BFFADA8275391ACBAD73227D ControlSchemeSyntax_WithRequiredDevice_TisRuntimeObject_mBEFB5EF49817C78C1BA4145393A1F2642E6ABD9D_gshared (ControlSchemeSyntax_t4C14E0745C729675BFFADA8275391ACBAD73227D* __this, const RuntimeMethod* method) ;
// System.Boolean System.Collections.Generic.Dictionary`2<System.Object,System.Object>::TryGetValue(TKey,TValue&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Dictionary_2_TryGetValue_mD15380A4ED7CDEE99EA45881577D26BA9CE1B849_gshared (Dictionary_2_t14FE4A752A83D53771C584E4C8D14E01F2AFD7BA* __this, RuntimeObject* ___key0, RuntimeObject** ___value1, const RuntimeMethod* method) ;
// TValue System.Collections.Generic.Dictionary`2<System.Int32Enum,System.Object>::get_Item(TKey)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* Dictionary_2_get_Item_m9C4302CCAE3C1BF70D02091D0E0CED7663F18211_gshared (Dictionary_2_t514396B90715EDD83BB0470C76C2F426F9381C71* __this, int32_t ___key0, const RuntimeMethod* method) ;
// System.Void Rewired.Utils.Classes.Data.AList`1<System.Object>::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AList_1__ctor_m795F1FC5309FE7B90118108D3C1D5C004D926D66_gshared (AList_1_t8AC95BE03ABEFD201943BE98AD0C21498B716AD0* __this, const RuntimeMethod* method) ;
// System.Void System.Collections.ObjectModel.ReadOnlyCollection`1<System.Object>::.ctor(System.Collections.Generic.IList`1<T>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ReadOnlyCollection_1__ctor_mF2D2ACE0752C3B97343B72328D49200F45C14B65_gshared (ReadOnlyCollection_1_t5397DF0DB61D1090E7BBC89395CECB8D020CED92* __this, RuntimeObject* ___list0, const RuntimeMethod* method) ;
// System.Void System.Action`3<System.Boolean,System.Int32,System.Int32>::Invoke(T1,T2,T3)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Action_3_Invoke_m8897575606FCC23249B541980E86A2D83737853B_gshared (Action_3_t142D1F73AF66CEBC85F52240EC1B6207B558A40B* __this, bool ___arg10, int32_t ___arg21, int32_t ___arg32, const RuntimeMethod* method) ;
// System.Int32 System.Collections.Generic.List`1<System.Object>::get_Count()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR int32_t List_1_get_Count_m4407E4C389F22B8CEC282C15D56516658746C383_gshared_inline (List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D* __this, const RuntimeMethod* method) ;
// T System.Collections.Generic.List`1<System.Object>::get_Item(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* List_1_get_Item_m33561245D64798C2AB07584C0EC4F240E4839A38_gshared (List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D* __this, int32_t ___index0, const RuntimeMethod* method) ;
// System.Int32 UnityEngine.Rendering.DynamicArray`1<System.Object>::get_size()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR int32_t DynamicArray_1_get_size_m1B00C20A8CC4D62269585D16A58425D3F258836F_gshared_inline (DynamicArray_1_t7C64F5A74B7BA6F6B3589A766CADE3F59C6C7BCA* __this, const RuntimeMethod* method) ;
// System.Void UnityEngine.Rendering.DynamicArray`1<System.Object>::Resize(System.Int32,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void DynamicArray_1_Resize_m3E24EB8A4A036B423BA304E8C3C94EBD0222822E_gshared (DynamicArray_1_t7C64F5A74B7BA6F6B3589A766CADE3F59C6C7BCA* __this, int32_t ___newSize0, bool ___keepContent1, const RuntimeMethod* method) ;
// T& UnityEngine.Rendering.DynamicArray`1<System.Object>::get_Item(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject** DynamicArray_1_get_Item_m7DDF1E462D1484149A4D812CAD717F816205FD44_gshared (DynamicArray_1_t7C64F5A74B7BA6F6B3589A766CADE3F59C6C7BCA* __this, int32_t ___index0, const RuntimeMethod* method) ;
// System.Boolean Rewired.Utils.Classes.Data.ADictionary`2<System.Object,System.Object>::ContainsKey(TKey)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool ADictionary_2_ContainsKey_mF7EDB2872C4A7F23E8C686FC27B7362894661938_gshared (ADictionary_2_t95DEC58ADD1420C20E0CB2463868ED1353F2C657* __this, RuntimeObject* ___key0, const RuntimeMethod* method) ;
// System.Void System.Collections.Generic.List`1<System.Object>::.ctor(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void List_1__ctor_m76CBBC3E2F0583F5AD30CE592CEA1225C06A0428_gshared (List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D* __this, int32_t ___capacity0, const RuntimeMethod* method) ;
// System.Void Rewired.Utils.Classes.Data.ADictionary`2<System.Object,System.Object>::Add(TKey,TValue)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ADictionary_2_Add_mDEC20CAEDBCBB889CE37AC97BDDEBDB45990E0E2_gshared (ADictionary_2_t95DEC58ADD1420C20E0CB2463868ED1353F2C657* __this, RuntimeObject* ___key0, RuntimeObject* ___value1, const RuntimeMethod* method) ;
// TValue Rewired.Utils.Classes.Data.ADictionary`2<System.Object,System.Object>::get_Item(TKey)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* ADictionary_2_get_Item_m24FFDB07E02919DD00AC0F6130FEA41E0C0782F2_gshared (ADictionary_2_t95DEC58ADD1420C20E0CB2463868ED1353F2C657* __this, RuntimeObject* ___key0, const RuntimeMethod* method) ;
// System.Void System.Collections.Generic.List`1<System.Object>::RemoveAt(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void List_1_RemoveAt_m54F62297ADEE4D4FDA697F49ED807BF901201B54_gshared (List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D* __this, int32_t ___index0, const RuntimeMethod* method) ;
// System.Boolean Rewired.Utils.Classes.Data.ADictionary`2<System.Object,System.Object>::TryGetValue(TKey,TValue&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool ADictionary_2_TryGetValue_m9D92E1E12F8D2EF4C1F2F8104621B4707CAC8716_gshared (ADictionary_2_t95DEC58ADD1420C20E0CB2463868ED1353F2C657* __this, RuntimeObject* ___key0, RuntimeObject** ___value1, const RuntimeMethod* method) ;
// System.Boolean Rewired.Utils.ListTools::AddIfUnique<System.Object>(System.Collections.Generic.IList`1<T>,T)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool ListTools_AddIfUnique_TisRuntimeObject_m1FC233E73FB0BCD08B759B78473378745A884A81_gshared (RuntimeObject* ___list0, RuntimeObject* ___item1, const RuntimeMethod* method) ;
// System.Void Rewired.Data.UserData/PMmfElSRTHipvrooOqnrsVzyuehD/aKSDPjRJZQzZwYkmoXKHoOMDFOWe`1<System.Object>::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void aKSDPjRJZQzZwYkmoXKHoOMDFOWe_1__ctor_m85F258D1E7D7A4BE9D3B8F13453BC940F7D38D16_gshared (aKSDPjRJZQzZwYkmoXKHoOMDFOWe_1_tBF7584EF632A787EC6F2057BA1C49894E7E22FCA* __this, const RuntimeMethod* method) ;
// System.Void System.Collections.Generic.List`1<System.Object>::Add(T)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void List_1_Add_mEBCF994CC3814631017F46A387B1A192ED6C85C7_gshared_inline (List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D* __this, RuntimeObject* ___item0, const RuntimeMethod* method) ;
// System.Void Rewired.Data.UserData/PMmfElSRTHipvrooOqnrsVzyuehD/cTlcZwgBmjmwQjxeEhJdCJOLqDjC`1<System.Object>::.ctor(?,?,Rewired.Data.UserData/PMmfElSRTHipvrooOqnrsVzyuehD/kzedFdEdISaCJppRVzkSmhYBfiDK/CONyoCVDDnZOISeLTzDqTryyCphV,System.Collections.Generic.IList`1<?>,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void cTlcZwgBmjmwQjxeEhJdCJOLqDjC_1__ctor_m2660924875158C34CA727FFC10FA37C6C7C14D90_gshared (cTlcZwgBmjmwQjxeEhJdCJOLqDjC_1_t00DEF10DFB18F406646ED696288655ED53671B85* __this, RuntimeObject* p0, RuntimeObject* p1, int32_t p2, RuntimeObject* p3, bool p4, const RuntimeMethod* method) ;
// System.Void Rewired.Data.UserData/PMmfElSRTHipvrooOqnrsVzyuehD/sQEkcZUofLSdEALOSOuyKPdNiQEDA`1<System.Object>::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void sQEkcZUofLSdEALOSOuyKPdNiQEDA_1__ctor_m22DB3A340E2C132D9FC9F965583E016FD9F40992_gshared (sQEkcZUofLSdEALOSOuyKPdNiQEDA_1_t1B5CB90AB9525321551E427D7C2054C85C37AAC1* __this, const RuntimeMethod* method) ;
// System.Void System.Predicate`1<System.Object>::.ctor(System.Object,System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Predicate_1__ctor_m3E007299121A15DF80F4A210FF8C20E5DF688F20_gshared (Predicate_1_t8342C85FF4E41CD1F7024AC0CDC3E5312A32CB12* __this, RuntimeObject* ___object0, intptr_t ___method1, const RuntimeMethod* method) ;
// T System.Collections.Generic.List`1<System.Object>::Find(System.Predicate`1<T>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* List_1_Find_m5E78A210541B0D844FE27B94F509313623BE33D3_gshared (List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D* __this, Predicate_1_t8342C85FF4E41CD1F7024AC0CDC3E5312A32CB12* ___match0, const RuntimeMethod* method) ;
// System.Void Rewired.Player/ControllerHelper/ConflictCheckingHelper/LaNNrUufXUaCsHwYSVeeItSJzfQrA`1<System.Object>::.ctor(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void LaNNrUufXUaCsHwYSVeeItSJzfQrA_1__ctor_m4CB206044F75D42101528E3DE9EDB4BE49E09B23_gshared (LaNNrUufXUaCsHwYSVeeItSJzfQrA_1_t90BE74457214F7F3801FB0D2DD805D4EAF4457DA* __this, int32_t p0, const RuntimeMethod* method) ;
// System.Void Rewired.Player/ControllerHelper/ConflictCheckingHelper/NPPlAOzpsFiqWUuYJtTMLJfMbmYu`1<System.Object>::.ctor(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void NPPlAOzpsFiqWUuYJtTMLJfMbmYu_1__ctor_m471D4BF3F60DB5E5C8E988C205C6217CA5E5C74D_gshared (NPPlAOzpsFiqWUuYJtTMLJfMbmYu_1_tDD2E3885D14A7C4488825DE3B7C56DEA023BC185* __this, int32_t p0, const RuntimeMethod* method) ;
// System.Void Rewired.Player/ControllerHelper/ConflictCheckingHelper/gPTTtyzOAxLCvPhgMtIrgUsCIpeH`1<System.Object>::.ctor(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void gPTTtyzOAxLCvPhgMtIrgUsCIpeH_1__ctor_mAAA860EA13BFD81E13FB29502A14D28E72DD2762_gshared (gPTTtyzOAxLCvPhgMtIrgUsCIpeH_1_tA05B48EAD2AA2E510F8D380D32FC8F6D8331D7E3* __this, int32_t p0, const RuntimeMethod* method) ;
// System.Void System.Collections.Generic.List`1<System.Object>::Clear()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void List_1_Clear_m16C1F2C61FED5955F10EB36BC1CB2DF34B128994_gshared_inline (List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D* __this, const RuntimeMethod* method) ;
// System.Void System.Collections.Generic.List`1<System.Object>::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void List_1__ctor_m7F078BB342729BDF11327FD89D7872265328F690_gshared (List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D* __this, const RuntimeMethod* method) ;
// System.Void Rewired.Player/ControllerHelper/MapHelper/XcujpkEuhtkMjJAdZtQvqOzWNWoy`1<System.Object>::.ctor(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void XcujpkEuhtkMjJAdZtQvqOzWNWoy_1__ctor_m8793AFB1079D0A7CA7D1C71689E0C8BA63138080_gshared (XcujpkEuhtkMjJAdZtQvqOzWNWoy_1_t8DB30E00B0855C4A917D6B66CABCB5A4E19B64A2* __this, int32_t p0, const RuntimeMethod* method) ;
// System.Void Rewired.Player/ControllerHelper/MapHelper/ojuhOybXRUNKAWBYROlwkJhBlkPc`1<System.Object>::.ctor(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ojuhOybXRUNKAWBYROlwkJhBlkPc_1__ctor_m48EF0C0BCF7EB4E23415C4B13C967B63A9589F32_gshared (ojuhOybXRUNKAWBYROlwkJhBlkPc_1_t7B54C1CB431E7958F15D7F71C96CAF6E68E76D60* __this, int32_t p0, const RuntimeMethod* method) ;
// System.Void Rewired.Player/ControllerHelper/MapHelper/ecjdcwfzgyPMBWdzOraiwfCBcrRoA`1<System.Object>::.ctor(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ecjdcwfzgyPMBWdzOraiwfCBcrRoA_1__ctor_m34A74F392D550360F7C8349AB6963AEEEE9CC11B_gshared (ecjdcwfzgyPMBWdzOraiwfCBcrRoA_1_tCC80E04812F8A48B4DDE3B494ED31F6CC82A6A73* __this, int32_t p0, const RuntimeMethod* method) ;

// System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Type_t* Type_GetTypeFromHandle_m2570A2A5B32A5E9D9F0F38B37459DA18736C823E (RuntimeTypeHandle_t332A452B8B6179E4469B69525D0FE82A88030F7B ___handle0, const RuntimeMethod* method) ;
// System.Boolean UnityEngine.AndroidReflection::IsPrimitive(System.Type)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AndroidReflection_IsPrimitive_m48ED73958206D552B937EEC7560184C6C4228F3D (Type_t* ___t0, const RuntimeMethod* method) ;
// System.Int32[] UnityEngine.AndroidJNISafe::FromIntArray(System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* AndroidJNISafe_FromIntArray_m899EDC375E4983DCF33B5B72E2131DC06AA4B5F0 (intptr_t ___array0, const RuntimeMethod* method) ;
// System.Boolean[] UnityEngine.AndroidJNISafe::FromBooleanArray(System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR BooleanU5BU5D_tD317D27C31DB892BE79FAE3AEBC0B3FFB73DE9B4* AndroidJNISafe_FromBooleanArray_m3F57F10FDDBA3DC358BEF7296F58D819C9EC3BDE (intptr_t ___array0, const RuntimeMethod* method) ;
// System.Void UnityEngine.Debug::LogWarning(System.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Debug_LogWarning_mEF15C6B17CE4E1FA7E379CDB82CE40FCD89A3F28 (RuntimeObject* ___message0, const RuntimeMethod* method) ;
// System.Byte[] UnityEngine.AndroidJNISafe::FromByteArray(System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* AndroidJNISafe_FromByteArray_mAED5B8EEF34E268BB146A277842089C7FD8A06BB (intptr_t ___array0, const RuntimeMethod* method) ;
// System.SByte[] UnityEngine.AndroidJNISafe::FromSByteArray(System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR SByteU5BU5D_t88116DA68378C3333DB73E7D36C1A06AFAA91913* AndroidJNISafe_FromSByteArray_m5825C71BA6941CDF25627AD77CDBE648CB322476 (intptr_t ___array0, const RuntimeMethod* method) ;
// System.Int16[] UnityEngine.AndroidJNISafe::FromShortArray(System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Int16U5BU5D_t8175CE8DD9C9F9FB0CF4F58E45BC570575B43CFB* AndroidJNISafe_FromShortArray_m227116D8E01EE3568936FB93C97CAEE9062A0A35 (intptr_t ___array0, const RuntimeMethod* method) ;
// System.Int64[] UnityEngine.AndroidJNISafe::FromLongArray(System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Int64U5BU5D_tAEDFCBDB5414E2A140A6F34C0538BF97FCF67A1D* AndroidJNISafe_FromLongArray_m687FC548BFA4DC440379619E5C7CB56354E30D59 (intptr_t ___array0, const RuntimeMethod* method) ;
// System.Single[] UnityEngine.AndroidJNISafe::FromFloatArray(System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR SingleU5BU5D_t89DEFE97BCEDB5857010E79ECE0F52CF6E93B87C* AndroidJNISafe_FromFloatArray_m97B7BC8546EC3F9CF0784D434D4AA41FBB409892 (intptr_t ___array0, const RuntimeMethod* method) ;
// System.Double[] UnityEngine.AndroidJNISafe::FromDoubleArray(System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE* AndroidJNISafe_FromDoubleArray_mB752FB522CD25191E5C6AF8CEFA4553593F784A7 (intptr_t ___array0, const RuntimeMethod* method) ;
// System.Char[] UnityEngine.AndroidJNISafe::FromCharArray(System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR CharU5BU5D_t799905CF001DD5F13F7DBB310181FC4D8B7D0AAB* AndroidJNISafe_FromCharArray_mC1C728B67330FD610542B4C2D6B9759F78B2BD17 (intptr_t ___array0, const RuntimeMethod* method) ;
// System.Int32 UnityEngine.AndroidJNISafe::GetArrayLength(System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t AndroidJNISafe_GetArrayLength_mB5F7260E652BE95FE9237A47C1E1597306B462C3 (intptr_t ___array0, const RuntimeMethod* method) ;
// System.IntPtr UnityEngine.AndroidJNI::GetObjectArrayElement(System.IntPtr,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR intptr_t AndroidJNI_GetObjectArrayElement_mDD7F2DC202FA14B8E5889755FB02B401C1127AD0 (intptr_t ___array0, int32_t ___index1, const RuntimeMethod* method) ;
// System.String UnityEngine.AndroidJNISafe::GetStringChars(System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* AndroidJNISafe_GetStringChars_m21A07825755C0A9AF91F8248A1C98F861E26928F (intptr_t ___str0, const RuntimeMethod* method) ;
// System.Void UnityEngine.AndroidJNISafe::DeleteLocalRef(System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AndroidJNISafe_DeleteLocalRef_m80503AA6C85CE46E8CE72C62215E1BE62964424D (intptr_t ___localref0, const RuntimeMethod* method) ;
// System.Void UnityEngine.AndroidJavaObject::.ctor(System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AndroidJavaObject__ctor_m0CEE7D570807333CE2C193A82AB3AB8D4F873A6B (AndroidJavaObject_t8FFB930F335C1178405B82AC2BF512BB1EEF9EB0* __this, intptr_t ___jobject0, const RuntimeMethod* method) ;
// System.String System.String::Concat(System.String,System.String,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* String_Concat_m9B13B47FCB3DF61144D9647DDA05F527377251B0 (String_t* ___str00, String_t* ___str11, String_t* ___str22, const RuntimeMethod* method) ;
// System.Void System.Exception::.ctor(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Exception__ctor_m9B2BD92CD68916245A75109105D9071C9D430E7F (Exception_t* __this, String_t* ___message0, const RuntimeMethod* method) ;
// System.String UnityEngine._AndroidJNIHelper::GetSignature(System.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* _AndroidJNIHelper_GetSignature_m1F94418EAEB87AF74E495191DC2AA5293136175B (RuntimeObject* ___obj0, const RuntimeMethod* method) ;
// System.IntPtr UnityEngine.AndroidJNIHelper::GetFieldID(System.IntPtr,System.String,System.String,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR intptr_t AndroidJNIHelper_GetFieldID_mC795891C3B70C0E8F98D9E8AD2A85103761A0C75 (intptr_t ___javaClass0, String_t* ___fieldName1, String_t* ___signature2, bool ___isStatic3, const RuntimeMethod* method) ;
// System.IntPtr UnityEngine.AndroidJNIHelper::GetMethodID(System.IntPtr,System.String,System.String,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR intptr_t AndroidJNIHelper_GetMethodID_m5F33E127418D5DA40590E4AE3814D7ACF7810F6E (intptr_t ___javaClass0, String_t* ___methodName1, String_t* ___signature2, bool ___isStatic3, const RuntimeMethod* method) ;
// System.Void System.Text.StringBuilder::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void StringBuilder__ctor_m1D99713357DE05DAFA296633639DB55F8C30587D (StringBuilder_t* __this, const RuntimeMethod* method) ;
// System.Text.StringBuilder System.Text.StringBuilder::Append(System.Char)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR StringBuilder_t* StringBuilder_Append_m71228B30F05724CD2CD96D9611DCD61BFB96A6E1 (StringBuilder_t* __this, Il2CppChar ___value0, const RuntimeMethod* method) ;
// System.Text.StringBuilder System.Text.StringBuilder::Append(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR StringBuilder_t* StringBuilder_Append_m08904D74E0C78E5F36DCD9C9303BDD07886D9F7D (StringBuilder_t* __this, String_t* ___value0, const RuntimeMethod* method) ;
// System.Void gPqZAArEBWUnolRtZlCKNFZvRLqr::.ctor(System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void gPqZAArEBWUnolRtZlCKNFZvRLqr__ctor_mA7CAA7F0171ED7E041E6DCE615ACDEFC63FA6432 (gPqZAArEBWUnolRtZlCKNFZvRLqr_tF91080EAD5330A023C3CBFFB01A8F1A45A0BDC0A* __this, intptr_t p0, const RuntimeMethod* method) ;
// System.Boolean System.Object::Equals(System.Object,System.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Object_Equals_mF52C7AEB4AA9F136C3EA31AE3C1FD200B831B3D1 (RuntimeObject* ___objA0, RuntimeObject* ___objB1, const RuntimeMethod* method) ;
// System.IntPtr SreStMNJSUKnhiFeYdCnZvaTqzgO::RvQYOisGQgIvOvSNNcOyLAzxJwjg()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR intptr_t SreStMNJSUKnhiFeYdCnZvaTqzgO_RvQYOisGQgIvOvSNNcOyLAzxJwjg_m5F546A28798410BFAA6391AF7BDAA858B6015EDF (SreStMNJSUKnhiFeYdCnZvaTqzgO_tCAADFAF41D7399BA1A417D5051C817A325FB955C* __this, const RuntimeMethod* method) ;
// System.Boolean System.IntPtr::op_Equality(System.IntPtr,System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool IntPtr_op_Equality_m73759B51FE326460AC87A0E386480226EF2FABED (intptr_t ___value10, intptr_t ___value21, const RuntimeMethod* method) ;
// System.Guid SNtVQFAVepBYrsfSLlQlIciPNQPo::kkPaojCcdHqsRGgreFJXfDnuxeQhB(System.Type)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Guid_t SNtVQFAVepBYrsfSLlQlIciPNQPo_kkPaojCcdHqsRGgreFJXfDnuxeQhB_m397E610FE4478212D5BC87EFEB4B503C872F4D1F (Type_t* p0, const RuntimeMethod* method) ;
// System.Int32 System.Runtime.InteropServices.Marshal::QueryInterface(System.IntPtr,System.Guid&,System.IntPtr&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t Marshal_QueryInterface_m12604B22FC92D98F167C3E4F3A9200CBD40F9496 (intptr_t ___pUnk0, Guid_t* ___iid1, intptr_t* ___ppv2, const RuntimeMethod* method) ;
// jQwkwLndXmHLkjaQEggMxbWuzWBN jQwkwLndXmHLkjaQEggMxbWuzWBN::TmcbGdEgTCEdxnYFXmldUVLQqBQBA(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR jQwkwLndXmHLkjaQEggMxbWuzWBN_t16BA183769603E5AC3E1A5CD0B747D26A4A7934F jQwkwLndXmHLkjaQEggMxbWuzWBN_TmcbGdEgTCEdxnYFXmldUVLQqBQBA_m35ED599133445CF4D0FFA156696B50F15B13F1DC (int32_t p0, const RuntimeMethod* method) ;
// System.Boolean jQwkwLndXmHLkjaQEggMxbWuzWBN::HcELlOfrApWyyMtVwDHKKfTDlulQ()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool jQwkwLndXmHLkjaQEggMxbWuzWBN_HcELlOfrApWyyMtVwDHKKfTDlulQ_m6FE4EFBA67EB670A236EAA5D7E5D4ADB680DE8C0 (jQwkwLndXmHLkjaQEggMxbWuzWBN_t16BA183769603E5AC3E1A5CD0B747D26A4A7934F* __this, const RuntimeMethod* method) ;
// System.Type System.Object::GetType()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Type_t* Object_GetType_mE10A8FC1E57F3DF29972CCBC026C2DC3942263B3 (RuntimeObject* __this, const RuntimeMethod* method) ;
// System.Void SreStMNJSUKnhiFeYdCnZvaTqzgO::ZjlSOCsDECEgYbDhWggTIVTxxSgAb(System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SreStMNJSUKnhiFeYdCnZvaTqzgO_ZjlSOCsDECEgYbDhWggTIVTxxSgAb_m886E670065256506479F17121D58EF8503FCC1E4 (SreStMNJSUKnhiFeYdCnZvaTqzgO_tCAADFAF41D7399BA1A417D5051C817A325FB955C* __this, intptr_t p0, const RuntimeMethod* method) ;
// System.IntPtr System.IntPtr::op_Explicit(System.Void*)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR intptr_t IntPtr_op_Explicit_m04BEF6277775C13DD8A986812AAA3FCEC32DCCBE (void* ___value0, const RuntimeMethod* method) ;
// System.Void* System.IntPtr::op_Explicit(System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void* IntPtr_op_Explicit_m693F2F9E685EE117D4AC080342B8959DAF684294 (intptr_t ___value0, const RuntimeMethod* method) ;
// System.Runtime.InteropServices.GCHandle System.Runtime.InteropServices.GCHandle::FromIntPtr(System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR GCHandle_tC44F6F72EE68BD4CFABA24309DA7A179D41127DC GCHandle_FromIntPtr_mB3E9C10177B3A0986B72C44D7E123F60125824DF (intptr_t ___value0, const RuntimeMethod* method) ;
// System.Object System.Runtime.InteropServices.GCHandle::get_Target()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* GCHandle_get_Target_m481F9508DA5E384D33CD1F4450060DC56BBD4CD5 (GCHandle_tC44F6F72EE68BD4CFABA24309DA7A179D41127DC* __this, const RuntimeMethod* method) ;
// Rewired.ControllerType uhuWHhUlIbNFBnRrnehXuaQSuHHd::DTDMBUYQupnORvMjRfLUcfFYMkdXA(System.Type)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t uhuWHhUlIbNFBnRrnehXuaQSuHHd_DTDMBUYQupnORvMjRfLUcfFYMkdXA_mD6AA70FD03DCB38F2C0C0DE32468293A8B0BE0F8 (Type_t* p0, const RuntimeMethod* method) ;
// System.Type uhuWHhUlIbNFBnRrnehXuaQSuHHd::JchCXXCUQHhByASRcEKTQGZvqYmGb(System.Type)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Type_t* uhuWHhUlIbNFBnRrnehXuaQSuHHd_JchCXXCUQHhByASRcEKTQGZvqYmGb_m9BAFCF72BACC6271D08DC383F4CB3D542075428B (Type_t* p0, const RuntimeMethod* method) ;
// System.Boolean uhuWHhUlIbNFBnRrnehXuaQSuHHd::TTQrDbVkNAShZUgQnZkcLsiPAwAp(System.Type,Rewired.ControllerType&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool uhuWHhUlIbNFBnRrnehXuaQSuHHd_TTQrDbVkNAShZUgQnZkcLsiPAwAp_m2EA98EFD549BF2117BF460D6DD9F247975A17C69 (Type_t* p0, int32_t* p1, const RuntimeMethod* method) ;
// Rewired.ControllerType uhuWHhUlIbNFBnRrnehXuaQSuHHd::ZHWqunaUMMiRUtHUuOTisgVjhUuA(System.Type)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t uhuWHhUlIbNFBnRrnehXuaQSuHHd_ZHWqunaUMMiRUtHUuOTisgVjhUuA_m38C1885F31B935E67983411F30CCA5B0464BBBEB (Type_t* p0, const RuntimeMethod* method) ;
// Rewired.ControllerType uhuWHhUlIbNFBnRrnehXuaQSuHHd::tuzEObbxQcmGBxissXpBnVmdqsiP(System.Type)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t uhuWHhUlIbNFBnRrnehXuaQSuHHd_tuzEObbxQcmGBxissXpBnVmdqsiP_m96402B3C0ECF97BB5CB3FD4B15CA301CFB9461CC (Type_t* p0, const RuntimeMethod* method) ;
// UnityEngine.InputSystem.InputActionPhase UnityEngine.InputSystem.InputAction/CallbackContext::get_phase()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t CallbackContext_get_phase_mBF36959BEB4B081303626F616535A84137580702 (CallbackContext_tB251EE41F509C6E8A6B05EC97C029A45DF4F5FA8* __this, const RuntimeMethod* method) ;
// System.Boolean UnityEngine.InputSystem.InputExtensions::IsInProgress(UnityEngine.InputSystem.InputActionPhase)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool InputExtensions_IsInProgress_m37300A7A5E1CB6A168453B66EE234EA43530544F (int32_t ___phase0, const RuntimeMethod* method) ;
// System.Int32 UnityEngine.InputSystem.InputAction/CallbackContext::get_bindingIndex()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t CallbackContext_get_bindingIndex_mBC8952C9915010C5D8DB5FD69D089FFC49542FB1 (CallbackContext_tB251EE41F509C6E8A6B05EC97C029A45DF4F5FA8* __this, const RuntimeMethod* method) ;
// System.Int32 UnityEngine.InputSystem.InputAction/CallbackContext::get_controlIndex()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t CallbackContext_get_controlIndex_m25E107BD1CD3C1CBAA7FAA2ED2D11EA88491A04B (CallbackContext_tB251EE41F509C6E8A6B05EC97C029A45DF4F5FA8* __this, const RuntimeMethod* method) ;
// TValue UnityEngine.InputSystem.InputAction/CallbackContext::ReadValue<UnityEngine.Quaternion>()
inline Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 CallbackContext_ReadValue_TisQuaternion_tDA59F214EF07D7700B26E40E562F267AF7306974_m020AD5873BB6CE85B752DF8D11920FA5FB46214E (CallbackContext_tB251EE41F509C6E8A6B05EC97C029A45DF4F5FA8* __this, const RuntimeMethod* method)
{
	return ((  Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 (*) (CallbackContext_tB251EE41F509C6E8A6B05EC97C029A45DF4F5FA8*, const RuntimeMethod*))CallbackContext_ReadValue_TisQuaternion_tDA59F214EF07D7700B26E40E562F267AF7306974_m020AD5873BB6CE85B752DF8D11920FA5FB46214E_gshared)(__this, method);
}
// TValue UnityEngine.InputSystem.InputAction/CallbackContext::ReadValue<System.Single>()
inline float CallbackContext_ReadValue_TisSingle_t4530F2FF86FCB0DC29F35385CA1BD21BE294761C_m7EBC8C123F0601CE5B340BA966923AEC449A8ACF (CallbackContext_tB251EE41F509C6E8A6B05EC97C029A45DF4F5FA8* __this, const RuntimeMethod* method)
{
	return ((  float (*) (CallbackContext_tB251EE41F509C6E8A6B05EC97C029A45DF4F5FA8*, const RuntimeMethod*))CallbackContext_ReadValue_TisSingle_t4530F2FF86FCB0DC29F35385CA1BD21BE294761C_m7EBC8C123F0601CE5B340BA966923AEC449A8ACF_gshared)(__this, method);
}
// TValue UnityEngine.InputSystem.InputAction/CallbackContext::ReadValue<UnityEngine.Vector2>()
inline Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 CallbackContext_ReadValue_TisVector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7_m454ADEAE74A5A469E011CF78D6303A1034659830 (CallbackContext_tB251EE41F509C6E8A6B05EC97C029A45DF4F5FA8* __this, const RuntimeMethod* method)
{
	return ((  Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 (*) (CallbackContext_tB251EE41F509C6E8A6B05EC97C029A45DF4F5FA8*, const RuntimeMethod*))CallbackContext_ReadValue_TisVector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7_m454ADEAE74A5A469E011CF78D6303A1034659830_gshared)(__this, method);
}
// TValue UnityEngine.InputSystem.InputAction/CallbackContext::ReadValue<UnityEngine.Vector3>()
inline Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 CallbackContext_ReadValue_TisVector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2_mC5704121342A8A761FA496E4922FDA7B37C20EDD (CallbackContext_tB251EE41F509C6E8A6B05EC97C029A45DF4F5FA8* __this, const RuntimeMethod* method)
{
	return ((  Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 (*) (CallbackContext_tB251EE41F509C6E8A6B05EC97C029A45DF4F5FA8*, const RuntimeMethod*))CallbackContext_ReadValue_TisVector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2_mC5704121342A8A761FA496E4922FDA7B37C20EDD_gshared)(__this, method);
}
// System.Void UnityEngine.InputSystem.InputActionRebindingExtensions/RebindingOperation::ThrowIfRebindInProgress()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void RebindingOperation_ThrowIfRebindInProgress_m02318B6E459C495517FF62AEAD4603BF683EED9C (RebindingOperation_tF7D9BCBB6E69668FA3A5C211104FF8637F9F3470* __this, const RuntimeMethod* method) ;
// UnityEngine.InputSystem.InputActionRebindingExtensions/RebindingOperation UnityEngine.InputSystem.InputActionRebindingExtensions/RebindingOperation::WithExpectedControlType(System.Type)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RebindingOperation_tF7D9BCBB6E69668FA3A5C211104FF8637F9F3470* RebindingOperation_WithExpectedControlType_m7C6765DE8A1B747F1E83EB324CCED84F509622AB (RebindingOperation_tF7D9BCBB6E69668FA3A5C211104FF8637F9F3470* __this, Type_t* ___type0, const RuntimeMethod* method) ;
// System.Boolean UnityEngine.InputSystem.InputActionSetupExtensions/BindingSyntax::get_valid()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool BindingSyntax_get_valid_m233A0DBDBE0B5AAB4B078F8FD39B1C60EFB6040C (BindingSyntax_t5FB93D8F3518B4640E42E067ECB15541CD123317* __this, const RuntimeMethod* method) ;
// System.Void System.InvalidOperationException::.ctor(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void InvalidOperationException__ctor_mE4CB6F4712AB6D99A2358FBAE2E052B3EE976162 (InvalidOperationException_t5DDE4D49B7405FAAB1E4576F4715A42A3FAD4BAB* __this, String_t* ___message0, const RuntimeMethod* method) ;
// UnityEngine.InputSystem.Utilities.InternedString UnityEngine.InputSystem.Utilities.TypeTable::FindNameForType(System.Type)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR InternedString_t8D62A48CB7D85AAE9CFCCCFB0A77AC2844905735 TypeTable_FindNameForType_m5974594EAAEB68C4488B8C9CFABF931B7666FB00 (TypeTable_tEAC1ECAD849469DEA65DA2FC65B19C2D4739B67E* __this, Type_t* ___type0, const RuntimeMethod* method) ;
// System.Boolean UnityEngine.InputSystem.Utilities.InternedString::IsEmpty()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool InternedString_IsEmpty_mA88FAF2562BF41C57C00E68F5A4111B22CFF173B (InternedString_t8D62A48CB7D85AAE9CFCCCFB0A77AC2844905735* __this, const RuntimeMethod* method) ;
// System.String System.String::Format(System.String,System.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* String_Format_m8C122B26BC5AA10E2550AECA16E57DAE10F07E30 (String_t* ___format0, RuntimeObject* ___arg01, const RuntimeMethod* method) ;
// System.Void System.NotSupportedException::.ctor(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void NotSupportedException__ctor_mE174750CF0247BBB47544FFD71D66BB89630945B (NotSupportedException_t1429765983D409BD2986508963C98D214E4EBF4A* __this, String_t* ___message0, const RuntimeMethod* method) ;
// System.String UnityEngine.InputSystem.Utilities.InternedString::op_Implicit(UnityEngine.InputSystem.Utilities.InternedString)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* InternedString_op_Implicit_mF8E1F7DA818367AEB1330013321063D7BDF30526 (InternedString_t8D62A48CB7D85AAE9CFCCCFB0A77AC2844905735 ___str0, const RuntimeMethod* method) ;
// UnityEngine.InputSystem.InputActionSetupExtensions/BindingSyntax UnityEngine.InputSystem.InputActionSetupExtensions/BindingSyntax::WithInteraction(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR BindingSyntax_t5FB93D8F3518B4640E42E067ECB15541CD123317 BindingSyntax_WithInteraction_mCE7E9DC5A2927956F4A89F55FE5D0A083936042B (BindingSyntax_t5FB93D8F3518B4640E42E067ECB15541CD123317* __this, String_t* ___interaction0, const RuntimeMethod* method) ;
// UnityEngine.InputSystem.InputActionSetupExtensions/BindingSyntax UnityEngine.InputSystem.InputActionSetupExtensions/BindingSyntax::WithInteraction<System.Object>()
inline BindingSyntax_t5FB93D8F3518B4640E42E067ECB15541CD123317 BindingSyntax_WithInteraction_TisRuntimeObject_mA9CD41BB913C678CE5891E3C51871CBFCFB13254 (BindingSyntax_t5FB93D8F3518B4640E42E067ECB15541CD123317* __this, const RuntimeMethod* method)
{
	return ((  BindingSyntax_t5FB93D8F3518B4640E42E067ECB15541CD123317 (*) (BindingSyntax_t5FB93D8F3518B4640E42E067ECB15541CD123317*, const RuntimeMethod*))BindingSyntax_WithInteraction_TisRuntimeObject_mA9CD41BB913C678CE5891E3C51871CBFCFB13254_gshared)(__this, method);
}
// UnityEngine.InputSystem.InputActionSetupExtensions/BindingSyntax UnityEngine.InputSystem.InputActionSetupExtensions/BindingSyntax::WithProcessor(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR BindingSyntax_t5FB93D8F3518B4640E42E067ECB15541CD123317 BindingSyntax_WithProcessor_m2FD9C1A3B16647C578EF8723249ABF6B45E7F9AC (BindingSyntax_t5FB93D8F3518B4640E42E067ECB15541CD123317* __this, String_t* ___processor0, const RuntimeMethod* method) ;
// UnityEngine.InputSystem.InputActionSetupExtensions/BindingSyntax UnityEngine.InputSystem.InputActionSetupExtensions/BindingSyntax::WithProcessor<System.Object>()
inline BindingSyntax_t5FB93D8F3518B4640E42E067ECB15541CD123317 BindingSyntax_WithProcessor_TisRuntimeObject_m88180835A3724BF9C98DC39A8CB6146B2B3BC1DE (BindingSyntax_t5FB93D8F3518B4640E42E067ECB15541CD123317* __this, const RuntimeMethod* method)
{
	return ((  BindingSyntax_t5FB93D8F3518B4640E42E067ECB15541CD123317 (*) (BindingSyntax_t5FB93D8F3518B4640E42E067ECB15541CD123317*, const RuntimeMethod*))BindingSyntax_WithProcessor_TisRuntimeObject_m88180835A3724BF9C98DC39A8CB6146B2B3BC1DE_gshared)(__this, method);
}
// UnityEngine.InputSystem.Utilities.InternedString UnityEngine.InputSystem.Layouts.InputControlLayout/Collection::TryFindLayoutForType(System.Type)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR InternedString_t8D62A48CB7D85AAE9CFCCCFB0A77AC2844905735 Collection_TryFindLayoutForType_m63B3C00D6ED29C6DD98A6B735E5C4C84A3B20868 (Collection_t6E9F85AD439CF26269683541C4DC58BA3B6756C5* __this, Type_t* ___layoutType0, const RuntimeMethod* method) ;
// System.String UnityEngine.InputSystem.Utilities.InternedString::ToString()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* InternedString_ToString_mED327D67EF001C5EDFF284336F13C3E3F025993A (InternedString_t8D62A48CB7D85AAE9CFCCCFB0A77AC2844905735* __this, const RuntimeMethod* method) ;
// System.Boolean System.String::IsNullOrEmpty(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool String_IsNullOrEmpty_m54CF0907E7C4F3AFB2E796A13DC751ECBB8DB64A (String_t* ___value0, const RuntimeMethod* method) ;
// System.String UnityEngine.InputSystem.InputActionSetupExtensions/ControlSchemeSyntax::DeviceTypeToControlPath<System.Object>()
inline String_t* ControlSchemeSyntax_DeviceTypeToControlPath_TisRuntimeObject_mF63A1990BA907932D19EC7FA27A34BC1A855D21A (ControlSchemeSyntax_t4C14E0745C729675BFFADA8275391ACBAD73227D* __this, const RuntimeMethod* method)
{
	return ((  String_t* (*) (ControlSchemeSyntax_t4C14E0745C729675BFFADA8275391ACBAD73227D*, const RuntimeMethod*))ControlSchemeSyntax_DeviceTypeToControlPath_TisRuntimeObject_mF63A1990BA907932D19EC7FA27A34BC1A855D21A_gshared)(__this, method);
}
// UnityEngine.InputSystem.InputActionSetupExtensions/ControlSchemeSyntax UnityEngine.InputSystem.InputActionSetupExtensions/ControlSchemeSyntax::WithOptionalDevice(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR ControlSchemeSyntax_t4C14E0745C729675BFFADA8275391ACBAD73227D ControlSchemeSyntax_WithOptionalDevice_mB17551E2EB7F96585BD6E01573D9494664E9EED7 (ControlSchemeSyntax_t4C14E0745C729675BFFADA8275391ACBAD73227D* __this, String_t* ___controlPath0, const RuntimeMethod* method) ;
// UnityEngine.InputSystem.InputActionSetupExtensions/ControlSchemeSyntax UnityEngine.InputSystem.InputActionSetupExtensions/ControlSchemeSyntax::OrWithOptionalDevice<System.Object>()
inline ControlSchemeSyntax_t4C14E0745C729675BFFADA8275391ACBAD73227D ControlSchemeSyntax_OrWithOptionalDevice_TisRuntimeObject_mF382F898E47985498314A5A60EF2542B5607DF53 (ControlSchemeSyntax_t4C14E0745C729675BFFADA8275391ACBAD73227D* __this, const RuntimeMethod* method)
{
	return ((  ControlSchemeSyntax_t4C14E0745C729675BFFADA8275391ACBAD73227D (*) (ControlSchemeSyntax_t4C14E0745C729675BFFADA8275391ACBAD73227D*, const RuntimeMethod*))ControlSchemeSyntax_OrWithOptionalDevice_TisRuntimeObject_mF382F898E47985498314A5A60EF2542B5607DF53_gshared)(__this, method);
}
// UnityEngine.InputSystem.InputActionSetupExtensions/ControlSchemeSyntax UnityEngine.InputSystem.InputActionSetupExtensions/ControlSchemeSyntax::WithRequiredDevice(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR ControlSchemeSyntax_t4C14E0745C729675BFFADA8275391ACBAD73227D ControlSchemeSyntax_WithRequiredDevice_mAFC72E5BFF4F4724E208AB15CC379ABD786EFFCE (ControlSchemeSyntax_t4C14E0745C729675BFFADA8275391ACBAD73227D* __this, String_t* ___controlPath0, const RuntimeMethod* method) ;
// UnityEngine.InputSystem.InputActionSetupExtensions/ControlSchemeSyntax UnityEngine.InputSystem.InputActionSetupExtensions/ControlSchemeSyntax::OrWithRequiredDevice<System.Object>()
inline ControlSchemeSyntax_t4C14E0745C729675BFFADA8275391ACBAD73227D ControlSchemeSyntax_OrWithRequiredDevice_TisRuntimeObject_m82C53906C0350BE78EBA1C410BC169C64E555CDE (ControlSchemeSyntax_t4C14E0745C729675BFFADA8275391ACBAD73227D* __this, const RuntimeMethod* method)
{
	return ((  ControlSchemeSyntax_t4C14E0745C729675BFFADA8275391ACBAD73227D (*) (ControlSchemeSyntax_t4C14E0745C729675BFFADA8275391ACBAD73227D*, const RuntimeMethod*))ControlSchemeSyntax_OrWithRequiredDevice_TisRuntimeObject_m82C53906C0350BE78EBA1C410BC169C64E555CDE_gshared)(__this, method);
}
// UnityEngine.InputSystem.InputActionSetupExtensions/ControlSchemeSyntax UnityEngine.InputSystem.InputActionSetupExtensions/ControlSchemeSyntax::WithOptionalDevice<System.Object>()
inline ControlSchemeSyntax_t4C14E0745C729675BFFADA8275391ACBAD73227D ControlSchemeSyntax_WithOptionalDevice_TisRuntimeObject_m44DA2464CBBE7A51A89945D7B96BB4114B0CDFEA (ControlSchemeSyntax_t4C14E0745C729675BFFADA8275391ACBAD73227D* __this, const RuntimeMethod* method)
{
	return ((  ControlSchemeSyntax_t4C14E0745C729675BFFADA8275391ACBAD73227D (*) (ControlSchemeSyntax_t4C14E0745C729675BFFADA8275391ACBAD73227D*, const RuntimeMethod*))ControlSchemeSyntax_WithOptionalDevice_TisRuntimeObject_m44DA2464CBBE7A51A89945D7B96BB4114B0CDFEA_gshared)(__this, method);
}
// UnityEngine.InputSystem.InputActionSetupExtensions/ControlSchemeSyntax UnityEngine.InputSystem.InputActionSetupExtensions/ControlSchemeSyntax::WithRequiredDevice<System.Object>()
inline ControlSchemeSyntax_t4C14E0745C729675BFFADA8275391ACBAD73227D ControlSchemeSyntax_WithRequiredDevice_TisRuntimeObject_mBEFB5EF49817C78C1BA4145393A1F2642E6ABD9D (ControlSchemeSyntax_t4C14E0745C729675BFFADA8275391ACBAD73227D* __this, const RuntimeMethod* method)
{
	return ((  ControlSchemeSyntax_t4C14E0745C729675BFFADA8275391ACBAD73227D (*) (ControlSchemeSyntax_t4C14E0745C729675BFFADA8275391ACBAD73227D*, const RuntimeMethod*))ControlSchemeSyntax_WithRequiredDevice_TisRuntimeObject_mBEFB5EF49817C78C1BA4145393A1F2642E6ABD9D_gshared)(__this, method);
}
// System.Void UnityEngine.InputSystem.Layouts.InputControlLayout/Builder::set_type(System.Type)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void Builder_set_type_m9052A0AB147182E89AAA4F020F6A0BE797AB49CC_inline (Builder_t83F17A26F53DA7EA6D8C35E5C65C5DF0147E7821* __this, Type_t* ___value0, const RuntimeMethod* method) ;
// System.Boolean System.Collections.Generic.Dictionary`2<System.String,Rewired.Utils.SafeDelegate>::TryGetValue(TKey,TValue&)
inline bool Dictionary_2_TryGetValue_m6EC43AE2C5DA7C0B6304C7615BB114120F4C7C1C (Dictionary_2_t340D9BC5CF0537B47A79183E8A310B59364118DF* __this, String_t* ___key0, SafeDelegate_t3A5CBC88139112F30FC47A9C9FEE81140913D328** ___value1, const RuntimeMethod* method)
{
	return ((  bool (*) (Dictionary_2_t340D9BC5CF0537B47A79183E8A310B59364118DF*, String_t*, SafeDelegate_t3A5CBC88139112F30FC47A9C9FEE81140913D328**, const RuntimeMethod*))Dictionary_2_TryGetValue_mD15380A4ED7CDEE99EA45881577D26BA9CE1B849_gshared)(__this, ___key0, ___value1, method);
}
// TValue System.Collections.Generic.Dictionary`2<Rewired.InputMapper/JdpDLqzkBAGmKbSgujDlWammLWSdA,Rewired.Utils.SafeDelegate>::get_Item(TKey)
inline SafeDelegate_t3A5CBC88139112F30FC47A9C9FEE81140913D328* Dictionary_2_get_Item_mE1AB1E72BF64ADB727FBCFC32FD083FE40112818 (Dictionary_2_t501DD8094A745126C4C4ED68F7198F76A46828B2* __this, int32_t ___key0, const RuntimeMethod* method)
{
	return ((  SafeDelegate_t3A5CBC88139112F30FC47A9C9FEE81140913D328* (*) (Dictionary_2_t501DD8094A745126C4C4ED68F7198F76A46828B2*, int32_t, const RuntimeMethod*))Dictionary_2_get_Item_m9C4302CCAE3C1BF70D02091D0E0CED7663F18211_gshared)(__this, ___key0, method);
}
// System.Void Rewired.Utils.Classes.Data.AList`1<System.Object>::.ctor()
inline void AList_1__ctor_m795F1FC5309FE7B90118108D3C1D5C004D926D66 (AList_1_t8AC95BE03ABEFD201943BE98AD0C21498B716AD0* __this, const RuntimeMethod* method)
{
	((  void (*) (AList_1_t8AC95BE03ABEFD201943BE98AD0C21498B716AD0*, const RuntimeMethod*))AList_1__ctor_m795F1FC5309FE7B90118108D3C1D5C004D926D66_gshared)(__this, method);
}
// System.Void System.Collections.ObjectModel.ReadOnlyCollection`1<System.Object>::.ctor(System.Collections.Generic.IList`1<T>)
inline void ReadOnlyCollection_1__ctor_mF2D2ACE0752C3B97343B72328D49200F45C14B65 (ReadOnlyCollection_1_t5397DF0DB61D1090E7BBC89395CECB8D020CED92* __this, RuntimeObject* ___list0, const RuntimeMethod* method)
{
	((  void (*) (ReadOnlyCollection_1_t5397DF0DB61D1090E7BBC89395CECB8D020CED92*, RuntimeObject*, const RuntimeMethod*))ReadOnlyCollection_1__ctor_mF2D2ACE0752C3B97343B72328D49200F45C14B65_gshared)(__this, ___list0, method);
}
// System.Boolean Rewired.ReInput::CheckInitialized(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool ReInput_CheckInitialized_mAAC593CB03C886BDB7B72864FBB1A59B2B0530AF (int32_t ___reInputId0, const RuntimeMethod* method) ;
// System.Boolean Rewired.Utils.ReflectionTools::DoesTypeImplement(System.Type,System.Type)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool ReflectionTools_DoesTypeImplement_m76A5EBA9D9AF0CCCD6DE916990142B42729852D0 (Type_t* ___type0, Type_t* ___baseOrInterfaceType1, const RuntimeMethod* method) ;
// System.Void Rewired.Player/ControllerHelper::QQxKOnTwNPCHMwOnZEnsIEZFcRycA(System.Int32,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ControllerHelper_QQxKOnTwNPCHMwOnZEnsIEZFcRycA_m864DD40C38F6DAFF3A56E30B0A35A3E3027962D8 (ControllerHelper_tCE72EA23053BD0C6ECB4D75A69F8CD1B3AC28FF6* __this, int32_t p0, bool p1, const RuntimeMethod* method) ;
// System.Void Rewired.Player/ControllerHelper::AddController(Rewired.ControllerType,System.Int32,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ControllerHelper_AddController_mC1EEC062B0F2C52570564EF3F6614E0E9ED35FF8 (ControllerHelper_tCE72EA23053BD0C6ECB4D75A69F8CD1B3AC28FF6* __this, int32_t ___controllerType0, int32_t ___controllerId1, bool ___removeFromOtherPlayers2, const RuntimeMethod* method) ;
// System.Void Rewired.Player/ControllerHelper::YKvaIRRSdroNuwpByVOUiaQDdvgY(System.Int32,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ControllerHelper_YKvaIRRSdroNuwpByVOUiaQDdvgY_mCC95CD1BA10F565882329CF12F4D19FDD7C535F5 (ControllerHelper_tCE72EA23053BD0C6ECB4D75A69F8CD1B3AC28FF6* __this, int32_t p0, bool p1, const RuntimeMethod* method) ;
// System.Void System.NotImplementedException::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void NotImplementedException__ctor_mDAB47BC6BD0E342E8F2171E5CABE3E67EA049F1C (NotImplementedException_t6366FE4DCF15094C51F4833B91A2AE68D4DA90E8* __this, const RuntimeMethod* method) ;
// System.Void Rewired.Player/ControllerHelper::GvCjhtmZKTjoCfDmlBakKLlNmytw()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ControllerHelper_GvCjhtmZKTjoCfDmlBakKLlNmytw_m9DC734593CC123774A27BDC3884BD4680C935AD5 (ControllerHelper_tCE72EA23053BD0C6ECB4D75A69F8CD1B3AC28FF6* __this, const RuntimeMethod* method) ;
// System.Void Rewired.Player/ControllerHelper::set_hasKeyboard(System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ControllerHelper_set_hasKeyboard_m4CBEA22EB6AF7DC13CE067FAC0B5845FF05052E3 (ControllerHelper_tCE72EA23053BD0C6ECB4D75A69F8CD1B3AC28FF6* __this, bool ___value0, const RuntimeMethod* method) ;
// System.Void Rewired.Player/ControllerHelper::set_hasMouse(System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ControllerHelper_set_hasMouse_m94C0658F438252E89380DFCDDCF8553D4A44E4A2 (ControllerHelper_tCE72EA23053BD0C6ECB4D75A69F8CD1B3AC28FF6* __this, bool ___value0, const RuntimeMethod* method) ;
// System.Void Rewired.Player/ControllerHelper::jEJlbBlAfPAlWHhdiSXmnzeRQZnH()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ControllerHelper_jEJlbBlAfPAlWHhdiSXmnzeRQZnH_m4B85C77E77C949D3451279EF99220673C34F9C63 (ControllerHelper_tCE72EA23053BD0C6ECB4D75A69F8CD1B3AC28FF6* __this, const RuntimeMethod* method) ;
// System.Void Rewired.Player/ControllerHelper::ClearAllControllers()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ControllerHelper_ClearAllControllers_m7B7DF7080B87AFADA23298101E1D4DFD231D23AF (ControllerHelper_tCE72EA23053BD0C6ECB4D75A69F8CD1B3AC28FF6* __this, const RuntimeMethod* method) ;
// System.Boolean Rewired.Player/ControllerHelper::ContainsController(Rewired.ControllerType,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool ControllerHelper_ContainsController_m35DD14B54E4F337A0CCBA7CA5CEB1B57705B8BBE (ControllerHelper_tCE72EA23053BD0C6ECB4D75A69F8CD1B3AC28FF6* __this, int32_t ___controllerType0, int32_t ___controllerId1, const RuntimeMethod* method) ;
// Rewired.Player/ControllerHelper/ftuHLSCvHbrPYKqmDICMGujVuqLSA Rewired.Player/ControllerHelper/vpfVMfLDNQCKabtrXuyMMndafvvoA::OlLACmpwoMamrxMTFzLaRnppBEGFA(Rewired.ControllerType)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* vpfVMfLDNQCKabtrXuyMMndafvvoA_OlLACmpwoMamrxMTFzLaRnppBEGFA_m7D256F4AAE84410B2D3EC0217ADB4B49A6AE0B9F (vpfVMfLDNQCKabtrXuyMMndafvvoA_t24DAE63535EED93A1490AC97901F2551704D116D* __this, int32_t p0, const RuntimeMethod* method) ;
// Rewired.Controller Rewired.Player/ControllerHelper::GetFirstControllerWithTemplate(System.Type)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Controller_t919A4A50FC7A0F25D7B31615C0F4E4D4A4D17911* ControllerHelper_GetFirstControllerWithTemplate_m810A5039CAC0C0F95065EB302E7CA142034ADBCF (ControllerHelper_tCE72EA23053BD0C6ECB4D75A69F8CD1B3AC28FF6* __this, Type_t* ___templateType0, const RuntimeMethod* method) ;
// Rewired.Controller Rewired.Player/ControllerHelper::GetLastActiveController(Rewired.ControllerType)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Controller_t919A4A50FC7A0F25D7B31615C0F4E4D4A4D17911* ControllerHelper_GetLastActiveController_m12A09469960F0059850D2A5B8002C6298235F92E (ControllerHelper_tCE72EA23053BD0C6ECB4D75A69F8CD1B3AC28FF6* __this, int32_t ___controllerType0, const RuntimeMethod* method) ;
// System.Void Rewired.Player/ControllerHelper::sEwRxcjRcvYLfZwkgSvIBxUPgqwA(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ControllerHelper_sEwRxcjRcvYLfZwkgSvIBxUPgqwA_m73C76BF07A11F3015469DF102EEEE5BB60C04148 (ControllerHelper_tCE72EA23053BD0C6ECB4D75A69F8CD1B3AC28FF6* __this, int32_t p0, const RuntimeMethod* method) ;
// System.Void Rewired.Player/ControllerHelper::RemoveController(Rewired.ControllerType,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ControllerHelper_RemoveController_m94BAB4F8423E1D4FCA1C5D17314192E359E65D29 (ControllerHelper_tCE72EA23053BD0C6ECB4D75A69F8CD1B3AC28FF6* __this, int32_t ___controllerType0, int32_t ___controllerId1, const RuntimeMethod* method) ;
// System.Void Rewired.Player/ControllerHelper::YIlmnpncuhGTKbGYeWwxpJbXbqGIA(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ControllerHelper_YIlmnpncuhGTKbGYeWwxpJbXbqGIA_m1154A7311E6E34EF891BD65EE9CEAB2C3783D67E (ControllerHelper_tCE72EA23053BD0C6ECB4D75A69F8CD1B3AC28FF6* __this, int32_t p0, const RuntimeMethod* method) ;
// Rewired.Data.ConfigVars Rewired.ReInput::get_configVars()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR ConfigVars_t4EC82ACF63376F1869FDC3D0E223EDCE149CF4A3* ReInput_get_configVars_m62E24BBE60949886F36F909C895B98208BCCC8ED_inline (const RuntimeMethod* method) ;
// System.Boolean Rewired.ControllerDataUpdater::IsUnknownHatCardinal(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool ControllerDataUpdater_IsUnknownHatCardinal_m0CA7BB22756F8BD2E6B4EAC4A920BEA4ADB0677E (ControllerDataUpdater_tEA424134962ED8FCA977957E8CAE6B6521D67788* __this, int32_t ___buttonIndex0, const RuntimeMethod* method) ;
// Rewired.UnknownControllerHat/HatButtons Rewired.ControllerDataUpdater::GetUnknownHatButtons(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR HatButtons_tCE5F7476A54D0F5DF7FA0EB11FF2C753B51DDE03* ControllerDataUpdater_GetUnknownHatButtons_m366B42FB92F75DC462492F999B5B9B7F264D60AB (ControllerDataUpdater_tEA424134962ED8FCA977957E8CAE6B6521D67788* __this, int32_t ___buttonIndex0, const RuntimeMethod* method) ;
// System.Void Rewired.UnknownControllerHat/HatButtons::GetNeighbors(System.Int32,System.Int32&,System.Int32&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void HatButtons_GetNeighbors_mE9F5E990C5B8EA4FD98CB2BC381DEF41BCF923DB (HatButtons_tCE5F7476A54D0F5DF7FA0EB11FF2C753B51DDE03* __this, int32_t ___button0, int32_t* ___neighbor11, int32_t* ___neighbor22, const RuntimeMethod* method) ;
// System.Boolean Rewired.Controller::cpEczqMFPCBfKdwpHaSAfaDMNEJPA(Rewired.ActionElementMap,System.Int32,System.Boolean,System.Single&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Controller_cpEczqMFPCBfKdwpHaSAfaDMNEJPA_m495DD9BAF787828FB89D8511D1439DF15869E993 (Controller_t919A4A50FC7A0F25D7B31615C0F4E4D4A4D17911* __this, ActionElementMap_t0EBE3E5D3A5DF3BA6D35F8082ED2232404EFF8CF* p0, int32_t p1, bool p2, float* p3, const RuntimeMethod* method) ;
// System.Collections.Generic.IList`1<Rewired.ActionElementMap> Rewired.ControllerMap::get_ButtonMaps()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* ControllerMap_get_ButtonMaps_m14CE9E0C32878178C5D785B64110FA0E8E7A3549 (ControllerMap_tC01A582E577E38D21EB7D87A8C040AF5DA285FB3* __this, const RuntimeMethod* method) ;
// System.Boolean Rewired.UnknownControllerHat/HatButtons::IsCorner(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool HatButtons_IsCorner_m3496C9D81EAACED6B4E98A984A04BF85363CC16D (HatButtons_tCE5F7476A54D0F5DF7FA0EB11FF2C753B51DDE03* __this, int32_t ___button0, const RuntimeMethod* method) ;
// System.Boolean Rewired.Controller::get_enabled()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Controller_get_enabled_m10693155C7424F34211AF208074D23F84CC26B75 (Controller_t919A4A50FC7A0F25D7B31615C0F4E4D4A4D17911* __this, const RuntimeMethod* method) ;
// System.Boolean Rewired.ControllerMap::get_enabled()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool ControllerMap_get_enabled_mA47FDF987F7A3D02B760A0F6923993074A810915 (ControllerMap_tC01A582E577E38D21EB7D87A8C040AF5DA285FB3* __this, const RuntimeMethod* method) ;
// Rewired.Utils.Classes.Data.AList`1<Rewired.ActionElementMap> Rewired.ControllerMapWithAxes::iNoVnkKULkVWRMCBPrVYaoavRfNM()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR AList_1_t26BA8BE4BEB503507B02BE892DA37BBBAA585997* ControllerMapWithAxes_iNoVnkKULkVWRMCBPrVYaoavRfNM_m991DEFB43A6DDAF9D1951950DC058DCCCDB08CF0 (ControllerMapWithAxes_tCC6B6F4AA454F60DB2D7F6660FDE33B9F683A036* __this, const RuntimeMethod* method) ;
// System.Boolean Rewired.ControllerWithAxes::EOOnKXthHffjzkcNHrZpffyFmiKcA(Rewired.ActionElementMap,System.Int32,System.Boolean,System.Boolean,System.Single&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool ControllerWithAxes_EOOnKXthHffjzkcNHrZpffyFmiKcA_m10692BFABBC0DB91E8433A9853953F6C8D977892 (ControllerWithAxes_tF5DF4B1A98C0326D31E6AC481DEBC2D90E44BBF2* __this, ActionElementMap_t0EBE3E5D3A5DF3BA6D35F8082ED2232404EFF8CF* p0, int32_t p1, bool p2, bool p3, float* p4, const RuntimeMethod* method) ;
// System.Void System.Action`3<System.Boolean,System.Int32,System.Int32>::Invoke(T1,T2,T3)
inline void Action_3_Invoke_m8897575606FCC23249B541980E86A2D83737853B (Action_3_t142D1F73AF66CEBC85F52240EC1B6207B558A40B* __this, bool ___arg10, int32_t ___arg21, int32_t ___arg32, const RuntimeMethod* method)
{
	((  void (*) (Action_3_t142D1F73AF66CEBC85F52240EC1B6207B558A40B*, bool, int32_t, int32_t, const RuntimeMethod*))Action_3_Invoke_m8897575606FCC23249B541980E86A2D83737853B_gshared)(__this, ___arg10, ___arg21, ___arg32, method);
}
// Rewired.CalibrationMap Rewired.ControllerWithAxes::get_calibrationMap()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR CalibrationMap_tB57C4727A9D4F4ED745A6E5D7E4398452D7A499B* ControllerWithAxes_get_calibrationMap_mC3190BF4AA50F8BAFE4C7E6B9A93227D3A0DC646 (ControllerWithAxes_tF5DF4B1A98C0326D31E6AC481DEBC2D90E44BBF2* __this, const RuntimeMethod* method) ;
// System.Collections.Generic.IList`1<Rewired.AxisCalibration> Rewired.CalibrationMap::get_Axes()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR RuntimeObject* CalibrationMap_get_Axes_m54E04E0A9797B0B8C965699A2B749DAF7B7158D7_inline (CalibrationMap_tB57C4727A9D4F4ED745A6E5D7E4398452D7A499B* __this, const RuntimeMethod* method) ;
// System.Boolean Rewired.AxisCalibration::get_applyRangeCalibration()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR bool AxisCalibration_get_applyRangeCalibration_m438A9FE9F6BAE9D2E046F3B44DBBAD83F0BBAD05_inline (AxisCalibration_t8B238ADDBAA0316E9708699644DA1CFF6EDBE66C* __this, const RuntimeMethod* method) ;
// System.Collections.Generic.IList`1<Rewired.Controller/Axis> Rewired.ControllerWithAxes::get_Axes()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* ControllerWithAxes_get_Axes_m7FA5003F0800898EA9833E7706A936B4E71A7DEB (ControllerWithAxes_tF5DF4B1A98C0326D31E6AC481DEBC2D90E44BBF2* __this, const RuntimeMethod* method) ;
// System.Int32 Rewired.ActionElementMap::get_elementIndex()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR int32_t ActionElementMap_get_elementIndex_m3FA57481AF8EAE6B39F59CCDD2051406ECA35726_inline (ActionElementMap_t0EBE3E5D3A5DF3BA6D35F8082ED2232404EFF8CF* __this, const RuntimeMethod* method) ;
// Rewired.Utils.Classes.Data.AList`1<Rewired.ActionElementMap> Rewired.ControllerMap::wXccLrJfOtzUxejkEKAtaWhpDtMyA()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR AList_1_t26BA8BE4BEB503507B02BE892DA37BBBAA585997* ControllerMap_wXccLrJfOtzUxejkEKAtaWhpDtMyA_m59AF76DBA5CF3521EF33E62ABEC7652CA79D4109_inline (ControllerMap_tC01A582E577E38D21EB7D87A8C040AF5DA285FB3* __this, const RuntimeMethod* method) ;
// System.Boolean Rewired.Controller::cpEczqMFPCBfKdwpHaSAfaDMNEJPA(Rewired.ActionElementMap,System.Int32,System.Single&,System.Boolean&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Controller_cpEczqMFPCBfKdwpHaSAfaDMNEJPA_mB2048BE4C3B1A9C4DAB6BE076089A9E00A0EA15D (Controller_t919A4A50FC7A0F25D7B31615C0F4E4D4A4D17911* __this, ActionElementMap_t0EBE3E5D3A5DF3BA6D35F8082ED2232404EFF8CF* p0, int32_t p1, float* p2, bool* p3, const RuntimeMethod* method) ;
// System.Int32 Rewired.Player/ControllerHelper::get_joystickCount()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t ControllerHelper_get_joystickCount_mC406E90F7590A70398B87179D8A54A6CA863BB7A (ControllerHelper_tCE72EA23053BD0C6ECB4D75A69F8CD1B3AC28FF6* __this, const RuntimeMethod* method) ;
// System.Collections.Generic.IList`1<Rewired.Joystick> Rewired.Player/ControllerHelper::get_Joysticks()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* ControllerHelper_get_Joysticks_m3D773A47247A4AC9F2D767782F68325CE2418CD6 (ControllerHelper_tCE72EA23053BD0C6ECB4D75A69F8CD1B3AC28FF6* __this, const RuntimeMethod* method) ;
// Rewired.Keyboard Rewired.Player/ControllerHelper::get_Keyboard()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Keyboard_t3FD52938480ACCD23FDB0DAEC857F9A9D29CC6C3* ControllerHelper_get_Keyboard_mDF3B56D2215293B50DA234D8379075C219576C90 (ControllerHelper_tCE72EA23053BD0C6ECB4D75A69F8CD1B3AC28FF6* __this, const RuntimeMethod* method) ;
// Rewired.Mouse Rewired.Player/ControllerHelper::get_Mouse()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Mouse_t5C8D9CB89A5C0F4EE87A70501CAF2A68E36DC019* ControllerHelper_get_Mouse_m8F587BDFB0DDB529D1E1D2B605406D8CACAA70A6 (ControllerHelper_tCE72EA23053BD0C6ECB4D75A69F8CD1B3AC28FF6* __this, const RuntimeMethod* method) ;
// System.Int32 Rewired.Player/ControllerHelper::get_customControllerCount()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t ControllerHelper_get_customControllerCount_m52F4B4EE672420770B0ECCB55882909AD3C3A0DD (ControllerHelper_tCE72EA23053BD0C6ECB4D75A69F8CD1B3AC28FF6* __this, const RuntimeMethod* method) ;
// System.Collections.Generic.IList`1<Rewired.CustomController> Rewired.Player/ControllerHelper::get_CustomControllers()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* ControllerHelper_get_CustomControllers_mE7A063106EFC07E69E315C3ECA08A11E11B073D3 (ControllerHelper_tCE72EA23053BD0C6ECB4D75A69F8CD1B3AC28FF6* __this, const RuntimeMethod* method) ;
// System.Int32 System.Collections.Generic.List`1<Rewired.PlayerController/Element>::get_Count()
inline int32_t List_1_get_Count_m4360FE38E465AC825248281834873BEC2CA1DE0A_inline (List_1_t1327B0703B35EF48626AC42F0D0C487FCBD86CF5* __this, const RuntimeMethod* method)
{
	return ((  int32_t (*) (List_1_t1327B0703B35EF48626AC42F0D0C487FCBD86CF5*, const RuntimeMethod*))List_1_get_Count_m4407E4C389F22B8CEC282C15D56516658746C383_gshared_inline)(__this, method);
}
// T System.Collections.Generic.List`1<Rewired.PlayerController/Element>::get_Item(System.Int32)
inline Element_t26F7003E01AAF28091E75E0A3552C2C3EEA38F06* List_1_get_Item_mF23E84EFE39E9A88D8A6A9D2061A0B3B3A0FEAF4 (List_1_t1327B0703B35EF48626AC42F0D0C487FCBD86CF5* __this, int32_t ___index0, const RuntimeMethod* method)
{
	return ((  Element_t26F7003E01AAF28091E75E0A3552C2C3EEA38F06* (*) (List_1_t1327B0703B35EF48626AC42F0D0C487FCBD86CF5*, int32_t, const RuntimeMethod*))List_1_get_Item_m33561245D64798C2AB07584C0EC4F240E4839A38_gshared)(__this, ___index0, method);
}
// System.Boolean Rewired.ReInput::CheckInitialized()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool ReInput_CheckInitialized_m77ED29D92874786A88A3FA315343991DA7A5B95B (const RuntimeMethod* method) ;
// Rewired.Joystick Rewired.ReInput/ControllerHelper::GetJoystick(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Joystick_tEC65D4846A553E83F365E7D8D263DC644C75FC11* ControllerHelper_GetJoystick_mC1549CA46BA18439089ED2562EB2EFF65C249F4A (ControllerHelper_t470828F1E9094A484F8FE12DB16199890DF23F5E* __this, int32_t ___joystickId0, const RuntimeMethod* method) ;
// Rewired.Keyboard TAqjagBhKGcWECRbpfkHPNKbpxLsA::YdrUiKuiWrCsfuIZfuOolsqFcFEd()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Keyboard_t3FD52938480ACCD23FDB0DAEC857F9A9D29CC6C3* TAqjagBhKGcWECRbpfkHPNKbpxLsA_YdrUiKuiWrCsfuIZfuOolsqFcFEd_m2F1D148A44E13C083F209FF609EDF416976764B4_inline (TAqjagBhKGcWECRbpfkHPNKbpxLsA_t5B25C84F87417D98CA0E8452EAD0DB3A23D7833A* __this, const RuntimeMethod* method) ;
// Rewired.CustomController Rewired.ReInput/ControllerHelper::GetCustomController(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR CustomController_t749B7DF2AA8AD20FEC4C2003C4FF5000FE9C6065* ControllerHelper_GetCustomController_m31319248887899487DD819B1C9A51224D0786753 (ControllerHelper_t470828F1E9094A484F8FE12DB16199890DF23F5E* __this, int32_t ___customControllerId0, const RuntimeMethod* method) ;
// Rewired.Mouse TAqjagBhKGcWECRbpfkHPNKbpxLsA::mQpaOTHDcjELSAhFNvChgQfDcoqub()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Mouse_t5C8D9CB89A5C0F4EE87A70501CAF2A68E36DC019* TAqjagBhKGcWECRbpfkHPNKbpxLsA_mQpaOTHDcjELSAhFNvChgQfDcoqub_mF11D81D13BFD78BC6E168C0996206A1CA946FC09_inline (TAqjagBhKGcWECRbpfkHPNKbpxLsA_t5B25C84F87417D98CA0E8452EAD0DB3A23D7833A* __this, const RuntimeMethod* method) ;
// System.Int32 UnityEngine.Rendering.DynamicArray`1<UnityEngine.Experimental.Rendering.RenderGraphModule.IRenderGraphResource>::get_size()
inline int32_t DynamicArray_1_get_size_m56D2768863B15299FA4F2F14E271686207A8C2E4_inline (DynamicArray_1_t401F46C0081DE185BCAB1D30DE8D6B6DC9AA6AFB* __this, const RuntimeMethod* method)
{
	return ((  int32_t (*) (DynamicArray_1_t401F46C0081DE185BCAB1D30DE8D6B6DC9AA6AFB*, const RuntimeMethod*))DynamicArray_1_get_size_m1B00C20A8CC4D62269585D16A58425D3F258836F_gshared_inline)(__this, method);
}
// System.Void UnityEngine.Rendering.DynamicArray`1<UnityEngine.Experimental.Rendering.RenderGraphModule.IRenderGraphResource>::Resize(System.Int32,System.Boolean)
inline void DynamicArray_1_Resize_mEEEB907EAEFD4C22DB449FF052CF6AC967A27AD1 (DynamicArray_1_t401F46C0081DE185BCAB1D30DE8D6B6DC9AA6AFB* __this, int32_t ___newSize0, bool ___keepContent1, const RuntimeMethod* method)
{
	((  void (*) (DynamicArray_1_t401F46C0081DE185BCAB1D30DE8D6B6DC9AA6AFB*, int32_t, bool, const RuntimeMethod*))DynamicArray_1_Resize_m3E24EB8A4A036B423BA304E8C3C94EBD0222822E_gshared)(__this, ___newSize0, ___keepContent1, method);
}
// T& UnityEngine.Rendering.DynamicArray`1<UnityEngine.Experimental.Rendering.RenderGraphModule.IRenderGraphResource>::get_Item(System.Int32)
inline IRenderGraphResource_tF24653A388C17849844C128C19C7A6599C7ADB7D** DynamicArray_1_get_Item_m5FC9383C3A815B0DF7AAD4C2A5CDFB1A25586ECE (DynamicArray_1_t401F46C0081DE185BCAB1D30DE8D6B6DC9AA6AFB* __this, int32_t ___index0, const RuntimeMethod* method)
{
	return ((  IRenderGraphResource_tF24653A388C17849844C128C19C7A6599C7ADB7D** (*) (DynamicArray_1_t401F46C0081DE185BCAB1D30DE8D6B6DC9AA6AFB*, int32_t, const RuntimeMethod*))DynamicArray_1_get_Item_m7DDF1E462D1484149A4D812CAD717F816205FD44_gshared)(__this, ___index0, method);
}
// System.Void System.ArgumentNullException::.ctor(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ArgumentNullException__ctor_m444AE141157E333844FC1A9500224C2F9FD24F4B (ArgumentNullException_t327031E412FAB2351B0022DD5DAD47E67E597129* __this, String_t* ___paramName0, const RuntimeMethod* method) ;
// Rewired.Utils.Classes.Data.ADictionary`2<System.Type,System.Collections.Generic.List`1<System.Object>> Rewired.Utils.TempListPool/TpeBEFhFAWNAsvKKQTVtIrdFUsQw::HPGleOOgRvXHtYsMXGTEsiryvtWs()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR ADictionary_2_tE212D15054E58919DA98BE219858633B9BBE9C90* TpeBEFhFAWNAsvKKQTVtIrdFUsQw_HPGleOOgRvXHtYsMXGTEsiryvtWs_m957491260AFBA8FB32FBC5DE4209106675FFB34C (const RuntimeMethod* method) ;
// System.Boolean Rewired.Utils.Classes.Data.ADictionary`2<System.Type,System.Collections.Generic.List`1<System.Object>>::ContainsKey(TKey)
inline bool ADictionary_2_ContainsKey_mC5ADB925423D250073B9A2A62A2534AB23B21A0F (ADictionary_2_tE212D15054E58919DA98BE219858633B9BBE9C90* __this, Type_t* ___key0, const RuntimeMethod* method)
{
	return ((  bool (*) (ADictionary_2_tE212D15054E58919DA98BE219858633B9BBE9C90*, Type_t*, const RuntimeMethod*))ADictionary_2_ContainsKey_mF7EDB2872C4A7F23E8C686FC27B7362894661938_gshared)(__this, ___key0, method);
}
// System.Void System.Collections.Generic.List`1<System.Object>::.ctor(System.Int32)
inline void List_1__ctor_m76CBBC3E2F0583F5AD30CE592CEA1225C06A0428 (List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D* __this, int32_t ___capacity0, const RuntimeMethod* method)
{
	((  void (*) (List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D*, int32_t, const RuntimeMethod*))List_1__ctor_m76CBBC3E2F0583F5AD30CE592CEA1225C06A0428_gshared)(__this, ___capacity0, method);
}
// System.Void Rewired.Utils.Classes.Data.ADictionary`2<System.Type,System.Collections.Generic.List`1<System.Object>>::Add(TKey,TValue)
inline void ADictionary_2_Add_m0B52951B53E7F35DD40A3E9D2435F6A9921FEAD6 (ADictionary_2_tE212D15054E58919DA98BE219858633B9BBE9C90* __this, Type_t* ___key0, List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D* ___value1, const RuntimeMethod* method)
{
	((  void (*) (ADictionary_2_tE212D15054E58919DA98BE219858633B9BBE9C90*, Type_t*, List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D*, const RuntimeMethod*))ADictionary_2_Add_mDEC20CAEDBCBB889CE37AC97BDDEBDB45990E0E2_gshared)(__this, ___key0, ___value1, method);
}
// TValue Rewired.Utils.Classes.Data.ADictionary`2<System.Type,System.Collections.Generic.List`1<System.Object>>::get_Item(TKey)
inline List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D* ADictionary_2_get_Item_m16DA44C3730BB63327BFAF65D10C028CA7CD13E3 (ADictionary_2_tE212D15054E58919DA98BE219858633B9BBE9C90* __this, Type_t* ___key0, const RuntimeMethod* method)
{
	return ((  List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D* (*) (ADictionary_2_tE212D15054E58919DA98BE219858633B9BBE9C90*, Type_t*, const RuntimeMethod*))ADictionary_2_get_Item_m24FFDB07E02919DD00AC0F6130FEA41E0C0782F2_gshared)(__this, ___key0, method);
}
// System.Int32 System.Collections.Generic.List`1<System.Object>::get_Count()
inline int32_t List_1_get_Count_m4407E4C389F22B8CEC282C15D56516658746C383_inline (List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D* __this, const RuntimeMethod* method)
{
	return ((  int32_t (*) (List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D*, const RuntimeMethod*))List_1_get_Count_m4407E4C389F22B8CEC282C15D56516658746C383_gshared_inline)(__this, method);
}
// T System.Collections.Generic.List`1<System.Object>::get_Item(System.Int32)
inline RuntimeObject* List_1_get_Item_m33561245D64798C2AB07584C0EC4F240E4839A38 (List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D* __this, int32_t ___index0, const RuntimeMethod* method)
{
	return ((  RuntimeObject* (*) (List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D*, int32_t, const RuntimeMethod*))List_1_get_Item_m33561245D64798C2AB07584C0EC4F240E4839A38_gshared)(__this, ___index0, method);
}
// System.Void System.Collections.Generic.List`1<System.Object>::RemoveAt(System.Int32)
inline void List_1_RemoveAt_m54F62297ADEE4D4FDA697F49ED807BF901201B54 (List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D* __this, int32_t ___index0, const RuntimeMethod* method)
{
	((  void (*) (List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D*, int32_t, const RuntimeMethod*))List_1_RemoveAt_m54F62297ADEE4D4FDA697F49ED807BF901201B54_gshared)(__this, ___index0, method);
}
// System.Boolean Rewired.Utils.Classes.Data.ADictionary`2<System.Type,System.Collections.Generic.List`1<System.Object>>::TryGetValue(TKey,TValue&)
inline bool ADictionary_2_TryGetValue_mF116A47D7285E8974FA1C99B2650B697DFD56A55 (ADictionary_2_tE212D15054E58919DA98BE219858633B9BBE9C90* __this, Type_t* ___key0, List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D** ___value1, const RuntimeMethod* method)
{
	return ((  bool (*) (ADictionary_2_tE212D15054E58919DA98BE219858633B9BBE9C90*, Type_t*, List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D**, const RuntimeMethod*))ADictionary_2_TryGetValue_m9D92E1E12F8D2EF4C1F2F8104621B4707CAC8716_gshared)(__this, ___key0, ___value1, method);
}
// System.Boolean Rewired.Utils.ListTools::AddIfUnique<System.Object>(System.Collections.Generic.IList`1<T>,T)
inline bool ListTools_AddIfUnique_TisRuntimeObject_m1FC233E73FB0BCD08B759B78473378745A884A81 (RuntimeObject* ___list0, RuntimeObject* ___item1, const RuntimeMethod* method)
{
	return ((  bool (*) (RuntimeObject*, RuntimeObject*, const RuntimeMethod*))ListTools_AddIfUnique_TisRuntimeObject_m1FC233E73FB0BCD08B759B78473378745A884A81_gshared)(___list0, ___item1, method);
}
// System.Void Rewired.Data.UserData/PMmfElSRTHipvrooOqnrsVzyuehD/aKSDPjRJZQzZwYkmoXKHoOMDFOWe`1<System.Object>::.ctor()
inline void aKSDPjRJZQzZwYkmoXKHoOMDFOWe_1__ctor_m85F258D1E7D7A4BE9D3B8F13453BC940F7D38D16 (aKSDPjRJZQzZwYkmoXKHoOMDFOWe_1_tBF7584EF632A787EC6F2057BA1C49894E7E22FCA* __this, const RuntimeMethod* method)
{
	((  void (*) (aKSDPjRJZQzZwYkmoXKHoOMDFOWe_1_tBF7584EF632A787EC6F2057BA1C49894E7E22FCA*, const RuntimeMethod*))aKSDPjRJZQzZwYkmoXKHoOMDFOWe_1__ctor_m85F258D1E7D7A4BE9D3B8F13453BC940F7D38D16_gshared)(__this, method);
}
// System.Void Rewired.Data.UserData/PMmfElSRTHipvrooOqnrsVzyuehD/kzedFdEdISaCJppRVzkSmhYBfiDK::.ctor(System.Int32,System.Int32,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void kzedFdEdISaCJppRVzkSmhYBfiDK__ctor_mCECC0F8AC7218CE1ED3AB6E85EC8C0FC5BCA8564 (kzedFdEdISaCJppRVzkSmhYBfiDK_t96C908773E13D2FD31BFC3C0BC59CD2D7B31233D* __this, int32_t p0, int32_t p1, int32_t p2, const RuntimeMethod* method) ;
// System.Void System.Collections.Generic.List`1<Rewired.Data.UserData/PMmfElSRTHipvrooOqnrsVzyuehD/kzedFdEdISaCJppRVzkSmhYBfiDK>::Add(T)
inline void List_1_Add_mEBA4A42D074F0BFA59336506E8E0639669B309DD_inline (List_1_t2371DBA2BC5BA5E401A3796013E23F6AA5DE82E7* __this, kzedFdEdISaCJppRVzkSmhYBfiDK_t96C908773E13D2FD31BFC3C0BC59CD2D7B31233D* ___item0, const RuntimeMethod* method)
{
	((  void (*) (List_1_t2371DBA2BC5BA5E401A3796013E23F6AA5DE82E7*, kzedFdEdISaCJppRVzkSmhYBfiDK_t96C908773E13D2FD31BFC3C0BC59CD2D7B31233D*, const RuntimeMethod*))List_1_Add_mEBCF994CC3814631017F46A387B1A192ED6C85C7_gshared_inline)(__this, ___item0, method);
}
// System.Void Rewired.Data.UserData/PMmfElSRTHipvrooOqnrsVzyuehD/cTlcZwgBmjmwQjxeEhJdCJOLqDjC`1<System.Object>::.ctor(?,?,Rewired.Data.UserData/PMmfElSRTHipvrooOqnrsVzyuehD/kzedFdEdISaCJppRVzkSmhYBfiDK/CONyoCVDDnZOISeLTzDqTryyCphV,System.Collections.Generic.IList`1<?>,System.Boolean)
inline void cTlcZwgBmjmwQjxeEhJdCJOLqDjC_1__ctor_m2660924875158C34CA727FFC10FA37C6C7C14D90 (cTlcZwgBmjmwQjxeEhJdCJOLqDjC_1_t00DEF10DFB18F406646ED696288655ED53671B85* __this, RuntimeObject* p0, RuntimeObject* p1, int32_t p2, RuntimeObject* p3, bool p4, const RuntimeMethod* method)
{
	((  void (*) (cTlcZwgBmjmwQjxeEhJdCJOLqDjC_1_t00DEF10DFB18F406646ED696288655ED53671B85*, RuntimeObject*, RuntimeObject*, int32_t, RuntimeObject*, bool, const RuntimeMethod*))cTlcZwgBmjmwQjxeEhJdCJOLqDjC_1__ctor_m2660924875158C34CA727FFC10FA37C6C7C14D90_gshared)(__this, p0, p1, p2, p3, p4, method);
}
// System.Void Rewired.Data.UserData/PMmfElSRTHipvrooOqnrsVzyuehD/sQEkcZUofLSdEALOSOuyKPdNiQEDA`1<System.Object>::.ctor()
inline void sQEkcZUofLSdEALOSOuyKPdNiQEDA_1__ctor_m22DB3A340E2C132D9FC9F965583E016FD9F40992 (sQEkcZUofLSdEALOSOuyKPdNiQEDA_1_t1B5CB90AB9525321551E427D7C2054C85C37AAC1* __this, const RuntimeMethod* method)
{
	((  void (*) (sQEkcZUofLSdEALOSOuyKPdNiQEDA_1_t1B5CB90AB9525321551E427D7C2054C85C37AAC1*, const RuntimeMethod*))sQEkcZUofLSdEALOSOuyKPdNiQEDA_1__ctor_m22DB3A340E2C132D9FC9F965583E016FD9F40992_gshared)(__this, method);
}
// System.Void System.Predicate`1<Rewired.Data.UserData/PMmfElSRTHipvrooOqnrsVzyuehD/kzedFdEdISaCJppRVzkSmhYBfiDK>::.ctor(System.Object,System.IntPtr)
inline void Predicate_1__ctor_mC7ED0FD7569E0ACBA4AA0C7D8592AADCFA28A8EA (Predicate_1_t0AE34D834A58115AD4CD9532C7FEAF28A2A18674* __this, RuntimeObject* ___object0, intptr_t ___method1, const RuntimeMethod* method)
{
	((  void (*) (Predicate_1_t0AE34D834A58115AD4CD9532C7FEAF28A2A18674*, RuntimeObject*, intptr_t, const RuntimeMethod*))Predicate_1__ctor_m3E007299121A15DF80F4A210FF8C20E5DF688F20_gshared)(__this, ___object0, ___method1, method);
}
// T System.Collections.Generic.List`1<Rewired.Data.UserData/PMmfElSRTHipvrooOqnrsVzyuehD/kzedFdEdISaCJppRVzkSmhYBfiDK>::Find(System.Predicate`1<T>)
inline kzedFdEdISaCJppRVzkSmhYBfiDK_t96C908773E13D2FD31BFC3C0BC59CD2D7B31233D* List_1_Find_m412DFD00E7077EF26A7689218DBB67CFEBBAA57D (List_1_t2371DBA2BC5BA5E401A3796013E23F6AA5DE82E7* __this, Predicate_1_t0AE34D834A58115AD4CD9532C7FEAF28A2A18674* ___match0, const RuntimeMethod* method)
{
	return ((  kzedFdEdISaCJppRVzkSmhYBfiDK_t96C908773E13D2FD31BFC3C0BC59CD2D7B31233D* (*) (List_1_t2371DBA2BC5BA5E401A3796013E23F6AA5DE82E7*, Predicate_1_t0AE34D834A58115AD4CD9532C7FEAF28A2A18674*, const RuntimeMethod*))List_1_Find_m5E78A210541B0D844FE27B94F509313623BE33D3_gshared)(__this, ___match0, method);
}
// System.String System.String::Concat(System.String,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* String_Concat_mAF2CE02CC0CB7460753D0A1A91CCF2B1E9804C5D (String_t* ___str00, String_t* ___str11, const RuntimeMethod* method) ;
// System.Void Rewired.Logger::Log(System.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Logger_Log_m7AFB3DE7CB55B1AF479DD909EB1A71CEEC54672D (RuntimeObject* ___msg0, const RuntimeMethod* method) ;
// System.String System.String::Concat(System.String,System.String,System.String,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* String_Concat_mF8B69BE42B5C5ABCAD3C176FBBE3010E0815D65D (String_t* ___str00, String_t* ___str11, String_t* ___str22, String_t* ___str33, const RuntimeMethod* method) ;
// System.Void Rewired.Player/ControllerHelper/ConflictCheckingHelper/LaNNrUufXUaCsHwYSVeeItSJzfQrA`1<System.Object>::.ctor(System.Int32)
inline void LaNNrUufXUaCsHwYSVeeItSJzfQrA_1__ctor_m4CB206044F75D42101528E3DE9EDB4BE49E09B23 (LaNNrUufXUaCsHwYSVeeItSJzfQrA_1_t90BE74457214F7F3801FB0D2DD805D4EAF4457DA* __this, int32_t p0, const RuntimeMethod* method)
{
	((  void (*) (LaNNrUufXUaCsHwYSVeeItSJzfQrA_1_t90BE74457214F7F3801FB0D2DD805D4EAF4457DA*, int32_t, const RuntimeMethod*))LaNNrUufXUaCsHwYSVeeItSJzfQrA_1__ctor_m4CB206044F75D42101528E3DE9EDB4BE49E09B23_gshared)(__this, p0, method);
}
// System.Void Rewired.Player/ControllerHelper/ConflictCheckingHelper/NPPlAOzpsFiqWUuYJtTMLJfMbmYu`1<System.Object>::.ctor(System.Int32)
inline void NPPlAOzpsFiqWUuYJtTMLJfMbmYu_1__ctor_m471D4BF3F60DB5E5C8E988C205C6217CA5E5C74D (NPPlAOzpsFiqWUuYJtTMLJfMbmYu_1_tDD2E3885D14A7C4488825DE3B7C56DEA023BC185* __this, int32_t p0, const RuntimeMethod* method)
{
	((  void (*) (NPPlAOzpsFiqWUuYJtTMLJfMbmYu_1_tDD2E3885D14A7C4488825DE3B7C56DEA023BC185*, int32_t, const RuntimeMethod*))NPPlAOzpsFiqWUuYJtTMLJfMbmYu_1__ctor_m471D4BF3F60DB5E5C8E988C205C6217CA5E5C74D_gshared)(__this, p0, method);
}
// System.Void Rewired.Player/ControllerHelper/ConflictCheckingHelper/gPTTtyzOAxLCvPhgMtIrgUsCIpeH`1<System.Object>::.ctor(System.Int32)
inline void gPTTtyzOAxLCvPhgMtIrgUsCIpeH_1__ctor_mAAA860EA13BFD81E13FB29502A14D28E72DD2762 (gPTTtyzOAxLCvPhgMtIrgUsCIpeH_1_tA05B48EAD2AA2E510F8D380D32FC8F6D8331D7E3* __this, int32_t p0, const RuntimeMethod* method)
{
	((  void (*) (gPTTtyzOAxLCvPhgMtIrgUsCIpeH_1_tA05B48EAD2AA2E510F8D380D32FC8F6D8331D7E3*, int32_t, const RuntimeMethod*))gPTTtyzOAxLCvPhgMtIrgUsCIpeH_1__ctor_mAAA860EA13BFD81E13FB29502A14D28E72DD2762_gshared)(__this, p0, method);
}
// Rewired.ReInput/PlayerHelper Rewired.ReInput::get_players()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR PlayerHelper_t96BC8DE1C94717C98B253F25C7B9C82639E4BF5C* ReInput_get_players_m3DDA5505CC1DB7580B0C41F1D781A284D3EACD27 (const RuntimeMethod* method) ;
// System.Int32 Rewired.ElementAssignmentConflictCheck::get_playerId()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR int32_t ElementAssignmentConflictCheck_get_playerId_m13D1C2C48B4AF7E87153014EE4B16491202256C5_inline (ElementAssignmentConflictCheck_tC22925257E88D3999FDD06C7ABF3B6CE6C09847E* __this, const RuntimeMethod* method) ;
// Rewired.Player Rewired.ReInput/PlayerHelper::GetPlayer(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Player_t71A64CE695A2F96B144F3050755AB2799DA7C01B* PlayerHelper_GetPlayer_m42CD1C5AC3CC96C9E36A74D680F0CEC9F5EB5FDC (PlayerHelper_t96BC8DE1C94717C98B253F25C7B9C82639E4BF5C* __this, int32_t ___playerId0, const RuntimeMethod* method) ;
// Rewired.ControllerType Rewired.ElementAssignmentConflictCheck::get_controllerType()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR int32_t ElementAssignmentConflictCheck_get_controllerType_mB10ABC66916B5C14CA467D3289A606AEE947FE72_inline (ElementAssignmentConflictCheck_tC22925257E88D3999FDD06C7ABF3B6CE6C09847E* __this, const RuntimeMethod* method) ;
// System.Int32 Rewired.ElementAssignmentConflictCheck::get_controllerId()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR int32_t ElementAssignmentConflictCheck_get_controllerId_m5C57BA2FE3D405B624E86F7DD88454ED9711954A_inline (ElementAssignmentConflictCheck_tC22925257E88D3999FDD06C7ABF3B6CE6C09847E* __this, const RuntimeMethod* method) ;
// System.Int32 Rewired.ElementAssignmentConflictCheck::get_controllerMapId()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR int32_t ElementAssignmentConflictCheck_get_controllerMapId_m4C899DB8B80BBF22D0B0CAA98E0F5330AECF1800_inline (ElementAssignmentConflictCheck_tC22925257E88D3999FDD06C7ABF3B6CE6C09847E* __this, const RuntimeMethod* method) ;
// Rewired.ControllerMap Rewired.Player/ControllerHelper/MapHelper::GetMap(Rewired.ControllerType,System.Int32,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR ControllerMap_tC01A582E577E38D21EB7D87A8C040AF5DA285FB3* MapHelper_GetMap_m7447D54D0BABDE292B5BC1AAA6F5576F29B016BE (MapHelper_t214BA4F045E5EB4B312E4E6AEB6697813117A7C2* __this, int32_t ___controllerType0, int32_t ___controllerId1, int32_t ___mapId2, const RuntimeMethod* method) ;
// Rewired.ReInput/MappingHelper Rewired.ReInput::get_mapping()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR MappingHelper_t18AE344473D49AF2E7133108678DD4D963699662* ReInput_get_mapping_mDE6BD708754EB86C540ACCB26BFD21D1F8054554 (const RuntimeMethod* method) ;
// System.Int32 Rewired.ElementAssignmentConflictCheck::get_controllerMapCategoryId()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR int32_t ElementAssignmentConflictCheck_get_controllerMapCategoryId_m0A29A78618798D54C96B3EE602E3576B899DBB99_inline (ElementAssignmentConflictCheck_tC22925257E88D3999FDD06C7ABF3B6CE6C09847E* __this, const RuntimeMethod* method) ;
// Rewired.InputMapCategory Rewired.ReInput/MappingHelper::GetMapCategory(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR InputMapCategory_t309A7C800100DDCC67C5C6A69F960A1D71768111* MappingHelper_GetMapCategory_m6B8082A9D9CAAB69B2EC97F6B2FCAF94C5C88DBD (MappingHelper_t18AE344473D49AF2E7133108678DD4D963699662* __this, int32_t ___mapCategoryId0, const RuntimeMethod* method) ;
// System.Int32 Rewired.ControllerMap::get_categoryId()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t ControllerMap_get_categoryId_m4D2BD4A8373EE16C75E13CB9B5ED8941A26D2B33 (ControllerMap_tC01A582E577E38D21EB7D87A8C040AF5DA285FB3* __this, const RuntimeMethod* method) ;
// System.Boolean Rewired.Player/ControllerHelper/ConflictCheckingHelper::HSvNYjKwjqmkkXAMHhkOgaGsivnQA(Rewired.InputMapCategory,Rewired.ControllerMap)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool ConflictCheckingHelper_HSvNYjKwjqmkkXAMHhkOgaGsivnQA_m95133A1C4C565019762E4A5EACF95189E3ECC306 (ConflictCheckingHelper_t8D707CEC57F056B87A4C68F98F780D34E893A8DB* __this, InputMapCategory_t309A7C800100DDCC67C5C6A69F960A1D71768111* p0, ControllerMap_tC01A582E577E38D21EB7D87A8C040AF5DA285FB3* p1, const RuntimeMethod* method) ;
// System.Void System.Collections.Generic.List`1<Rewired.ActionElementMap>::Clear()
inline void List_1_Clear_m2036CFD23AB93618EE6F473B3864A226AB3B519E_inline (List_1_t61A2C1C85DEC6157A1333F351530E22E04BDF9A6* __this, const RuntimeMethod* method)
{
	((  void (*) (List_1_t61A2C1C85DEC6157A1333F351530E22E04BDF9A6*, const RuntimeMethod*))List_1_Clear_m16C1F2C61FED5955F10EB36BC1CB2DF34B128994_gshared_inline)(__this, method);
}
// System.Void Rewired.Player/ControllerHelper/MapHelper::JumOMOwvXGOuPuOcxsTpVHdKrpWy(Rewired.ControllerType,System.Int32,System.Int32,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MapHelper_JumOMOwvXGOuPuOcxsTpVHdKrpWy_m1025513A8D96A8FDC1ED03E1DEAB4657987276C6 (MapHelper_t214BA4F045E5EB4B312E4E6AEB6697813117A7C2* __this, int32_t p0, int32_t p1, int32_t p2, int32_t p3, const RuntimeMethod* method) ;
// System.Void Rewired.Player/ControllerHelper/MapHelper::JumOMOwvXGOuPuOcxsTpVHdKrpWy(Rewired.ControllerType,System.Int32,System.String,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MapHelper_JumOMOwvXGOuPuOcxsTpVHdKrpWy_mED039BB84BB04F5E54C2B60E867E3C20C2AD8564 (MapHelper_t214BA4F045E5EB4B312E4E6AEB6697813117A7C2* __this, int32_t p0, int32_t p1, String_t* p2, String_t* p3, const RuntimeMethod* method) ;
// System.Void Rewired.Player/ControllerHelper/MapHelper::eARszvxUDfRQEHAaHAQfkQChFPGDb(Rewired.ControllerType,System.Int32,Rewired.ControllerMap,Rewired.BoolOption)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MapHelper_eARszvxUDfRQEHAaHAQfkQChFPGDb_m2F43D7FDFDEE1F636EDEC7226B9953E64C57F7E0 (MapHelper_t214BA4F045E5EB4B312E4E6AEB6697813117A7C2* __this, int32_t p0, int32_t p1, ControllerMap_tC01A582E577E38D21EB7D87A8C040AF5DA285FB3* p2, int32_t p3, const RuntimeMethod* method) ;
// System.Boolean Rewired.Player/ControllerHelper/MapHelper::ogIOwmXsniAMouscEmnvbvCsvknx(Rewired.ControllerType,System.Int32,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool MapHelper_ogIOwmXsniAMouscEmnvbvCsvknx_m5CF220DABA9A843745BB5108753BD9DBE734F696 (MapHelper_t214BA4F045E5EB4B312E4E6AEB6697813117A7C2* __this, int32_t p0, int32_t p1, String_t* p2, const RuntimeMethod* method) ;
// System.Boolean Rewired.Player/ControllerHelper/MapHelper::vsoXxjlyQkRgSJiWizMXuCTWvcQQ(Rewired.ControllerType,System.Int32,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool MapHelper_vsoXxjlyQkRgSJiWizMXuCTWvcQQ_m6A031FB42A3792160FDB353B488EA5710A8CDC40 (MapHelper_t214BA4F045E5EB4B312E4E6AEB6697813117A7C2* __this, int32_t p0, int32_t p1, String_t* p2, const RuntimeMethod* method) ;
// T System.Collections.Generic.List`1<System.String>::get_Item(System.Int32)
inline String_t* List_1_get_Item_m21AEC50E791371101DC22ABCF96A2E46800811F8 (List_1_tF470A3BE5C1B5B68E1325EF3F109D172E60BD7CD* __this, int32_t ___index0, const RuntimeMethod* method)
{
	return ((  String_t* (*) (List_1_tF470A3BE5C1B5B68E1325EF3F109D172E60BD7CD*, int32_t, const RuntimeMethod*))List_1_get_Item_m33561245D64798C2AB07584C0EC4F240E4839A38_gshared)(__this, ___index0, method);
}
// System.Int32 System.Collections.Generic.List`1<System.String>::get_Count()
inline int32_t List_1_get_Count_mB63183A9151F4345A9DD444A7CBE0D6E03F77C7C_inline (List_1_tF470A3BE5C1B5B68E1325EF3F109D172E60BD7CD* __this, const RuntimeMethod* method)
{
	return ((  int32_t (*) (List_1_tF470A3BE5C1B5B68E1325EF3F109D172E60BD7CD*, const RuntimeMethod*))List_1_get_Count_m4407E4C389F22B8CEC282C15D56516658746C383_gshared_inline)(__this, method);
}
// System.Void System.Collections.Generic.List`1<System.Object>::.ctor()
inline void List_1__ctor_m7F078BB342729BDF11327FD89D7872265328F690 (List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D* __this, const RuntimeMethod* method)
{
	((  void (*) (List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D*, const RuntimeMethod*))List_1__ctor_m7F078BB342729BDF11327FD89D7872265328F690_gshared)(__this, method);
}
// System.Boolean Rewired.InputCategory::get_userAssignable()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR bool InputCategory_get_userAssignable_mBD58AC35EE83AAE55914DC85584314585326C703_inline (InputCategory_t9C22614C15FBDA3F98B6F03EA3CEB547BF5F373C* __this, const RuntimeMethod* method) ;
// System.Void Rewired.Player/ControllerHelper/MapHelper::ClearMaps(Rewired.ControllerType,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MapHelper_ClearMaps_mE9839E66C615927C4E053CF3A89BF6C85E98614C (MapHelper_t214BA4F045E5EB4B312E4E6AEB6697813117A7C2* __this, int32_t ___controllerType0, bool ___userAssignableOnly1, const RuntimeMethod* method) ;
// System.Void Rewired.Player/ControllerHelper/MapHelper::ClearMapsForController(Rewired.ControllerType,System.Int32,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MapHelper_ClearMapsForController_m0AF8A2D1031EA3A7299F1384656833D0E0996200 (MapHelper_t214BA4F045E5EB4B312E4E6AEB6697813117A7C2* __this, int32_t ___controllerType0, int32_t ___controllerId1, bool ___userAssignableOnly2, const RuntimeMethod* method) ;
// System.Void Rewired.Player/ControllerHelper/MapHelper::ClearMapsForController(Rewired.ControllerType,System.Int32,System.Int32,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MapHelper_ClearMapsForController_mC11D4A3C112748E4A510469C5FB6AC10950EF667 (MapHelper_t214BA4F045E5EB4B312E4E6AEB6697813117A7C2* __this, int32_t ___controllerType0, int32_t ___controllerId1, int32_t ___categoryId2, bool ___userAssignableOnly3, const RuntimeMethod* method) ;
// System.Int32 Rewired.ReInput/MappingHelper::GetMapCategoryId(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t MappingHelper_GetMapCategoryId_mFC02A9FF6A6BFF6C38668558CB3DC6EB598077FB (MappingHelper_t18AE344473D49AF2E7133108678DD4D963699662* __this, String_t* ___name0, const RuntimeMethod* method) ;
// System.Void Rewired.Player/ControllerHelper/MapHelper::ClearMapsForControllerInLayout(Rewired.ControllerType,System.Int32,System.Int32,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MapHelper_ClearMapsForControllerInLayout_m2012A7C928B519693B0F57C5D13E84DBDBBEDE50 (MapHelper_t214BA4F045E5EB4B312E4E6AEB6697813117A7C2* __this, int32_t ___controllerType0, int32_t ___controllerId1, int32_t ___layoutId2, bool ___userAssignableOnly3, const RuntimeMethod* method) ;
// System.Int32 Rewired.ReInput/MappingHelper::GetLayoutId(Rewired.ControllerType,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t MappingHelper_GetLayoutId_m3C47818192FB2D4E2E46CB5F7E7585C302DE6ED7 (MappingHelper_t18AE344473D49AF2E7133108678DD4D963699662* __this, int32_t ___controllerType0, String_t* ___name1, const RuntimeMethod* method) ;
// System.Void Rewired.Player/ControllerHelper/MapHelper::ClearMapsInCategory(Rewired.ControllerType,System.Int32,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MapHelper_ClearMapsInCategory_m75DD455E3093205B83DBB0C3CD22842B7820F570 (MapHelper_t214BA4F045E5EB4B312E4E6AEB6697813117A7C2* __this, int32_t ___controllerType0, int32_t ___categoryId1, bool ___userAssignableOnly2, const RuntimeMethod* method) ;
// System.Void Rewired.Player/ControllerHelper/MapHelper::ClearMapsInCategory(Rewired.ControllerType,System.Int32,System.Int32,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MapHelper_ClearMapsInCategory_m7A84D03ED5B7E2058C03C75F2AFC4416A58149F4 (MapHelper_t214BA4F045E5EB4B312E4E6AEB6697813117A7C2* __this, int32_t ___controllerType0, int32_t ___categoryId1, int32_t ___layoutId2, bool ___userAssignableOnly3, const RuntimeMethod* method) ;
// System.Void Rewired.Player/ControllerHelper/MapHelper::ClearMapsInLayout(Rewired.ControllerType,System.Int32,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MapHelper_ClearMapsInLayout_m93FF033059DFAB7D685235CEDEA7A42D28A1E042 (MapHelper_t214BA4F045E5EB4B312E4E6AEB6697813117A7C2* __this, int32_t ___controllerType0, int32_t ___layoutId1, bool ___userAssignableOnly2, const RuntimeMethod* method) ;
// System.Void Rewired.Player/ControllerHelper/MapHelper/XcujpkEuhtkMjJAdZtQvqOzWNWoy`1<System.Object>::.ctor(System.Int32)
inline void XcujpkEuhtkMjJAdZtQvqOzWNWoy_1__ctor_m8793AFB1079D0A7CA7D1C71689E0C8BA63138080 (XcujpkEuhtkMjJAdZtQvqOzWNWoy_1_t8DB30E00B0855C4A917D6B66CABCB5A4E19B64A2* __this, int32_t p0, const RuntimeMethod* method)
{
	((  void (*) (XcujpkEuhtkMjJAdZtQvqOzWNWoy_1_t8DB30E00B0855C4A917D6B66CABCB5A4E19B64A2*, int32_t, const RuntimeMethod*))XcujpkEuhtkMjJAdZtQvqOzWNWoy_1__ctor_m8793AFB1079D0A7CA7D1C71689E0C8BA63138080_gshared)(__this, p0, method);
}
// Rewired.Player/ControllerHelper/ftuHLSCvHbrPYKqmDICMGujVuqLSA Rewired.Player/ControllerHelper/vpfVMfLDNQCKabtrXuyMMndafvvoA::WnvLUDAsClwKBCDbOHhIRBMdKTgv(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* vpfVMfLDNQCKabtrXuyMMndafvvoA_WnvLUDAsClwKBCDbOHhIRBMdKTgv_mFB15C8D1E61FDBCCAB87F4892BB7481AF3BBEE6F (vpfVMfLDNQCKabtrXuyMMndafvvoA_t24DAE63535EED93A1490AC97901F2551704D116D* __this, int32_t p0, const RuntimeMethod* method) ;
// System.Void Rewired.Player/ControllerHelper/MapHelper/ojuhOybXRUNKAWBYROlwkJhBlkPc`1<System.Object>::.ctor(System.Int32)
inline void ojuhOybXRUNKAWBYROlwkJhBlkPc_1__ctor_m48EF0C0BCF7EB4E23415C4B13C967B63A9589F32 (ojuhOybXRUNKAWBYROlwkJhBlkPc_1_t7B54C1CB431E7958F15D7F71C96CAF6E68E76D60* __this, int32_t p0, const RuntimeMethod* method)
{
	((  void (*) (ojuhOybXRUNKAWBYROlwkJhBlkPc_1_t7B54C1CB431E7958F15D7F71C96CAF6E68E76D60*, int32_t, const RuntimeMethod*))ojuhOybXRUNKAWBYROlwkJhBlkPc_1__ctor_m48EF0C0BCF7EB4E23415C4B13C967B63A9589F32_gshared)(__this, p0, method);
}
// Rewired.ControllerMap Rewired.Player/ControllerHelper/MapHelper::tXTzuxnKeaFcJkTzJwQUsSwUoCsRA(Rewired.ControllerType,System.Int32,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR ControllerMap_tC01A582E577E38D21EB7D87A8C040AF5DA285FB3* MapHelper_tXTzuxnKeaFcJkTzJwQUsSwUoCsRA_mF1BB015F2E3CACA5BBF1FD7BB5FDE74068F7D365 (MapHelper_t214BA4F045E5EB4B312E4E6AEB6697813117A7C2* __this, int32_t p0, int32_t p1, int32_t p2, const RuntimeMethod* method) ;
// Rewired.ControllerMap Rewired.Player/ControllerHelper/MapHelper::qYqBIOFxqlADXLihiBsFcAqNepub(Rewired.ControllerType,System.Int32,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR ControllerMap_tC01A582E577E38D21EB7D87A8C040AF5DA285FB3* MapHelper_qYqBIOFxqlADXLihiBsFcAqNepub_mF5BC6DA17BCBE2D8833A183352C5F877C7CD6F2B (MapHelper_t214BA4F045E5EB4B312E4E6AEB6697813117A7C2* __this, int32_t p0, int32_t p1, int32_t p2, const RuntimeMethod* method) ;
// Rewired.ControllerMap Rewired.Player/ControllerHelper/MapHelper::qYqBIOFxqlADXLihiBsFcAqNepub(Rewired.ControllerType,System.Int32,System.Int32,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR ControllerMap_tC01A582E577E38D21EB7D87A8C040AF5DA285FB3* MapHelper_qYqBIOFxqlADXLihiBsFcAqNepub_mA72BABB67A8FEDFC05D5020E5F5B09570B71F927 (MapHelper_t214BA4F045E5EB4B312E4E6AEB6697813117A7C2* __this, int32_t p0, int32_t p1, int32_t p2, int32_t p3, const RuntimeMethod* method) ;
// Rewired.ControllerMap Rewired.Player/ControllerHelper/MapHelper::qYqBIOFxqlADXLihiBsFcAqNepub(Rewired.ControllerType,System.Int32,System.String,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR ControllerMap_tC01A582E577E38D21EB7D87A8C040AF5DA285FB3* MapHelper_qYqBIOFxqlADXLihiBsFcAqNepub_mB544FDCDF4762ABA843DC4D4395B51F558E2913A (MapHelper_t214BA4F045E5EB4B312E4E6AEB6697813117A7C2* __this, int32_t p0, int32_t p1, String_t* p2, String_t* p3, const RuntimeMethod* method) ;
// System.Void Rewired.Player/ControllerHelper/MapHelper/ecjdcwfzgyPMBWdzOraiwfCBcrRoA`1<System.Object>::.ctor(System.Int32)
inline void ecjdcwfzgyPMBWdzOraiwfCBcrRoA_1__ctor_m34A74F392D550360F7C8349AB6963AEEEE9CC11B (ecjdcwfzgyPMBWdzOraiwfCBcrRoA_1_tCC80E04812F8A48B4DDE3B494ED31F6CC82A6A73* __this, int32_t p0, const RuntimeMethod* method)
{
	((  void (*) (ecjdcwfzgyPMBWdzOraiwfCBcrRoA_1_tCC80E04812F8A48B4DDE3B494ED31F6CC82A6A73*, int32_t, const RuntimeMethod*))ecjdcwfzgyPMBWdzOraiwfCBcrRoA_1__ctor_m34A74F392D550360F7C8349AB6963AEEEE9CC11B_gshared)(__this, p0, method);
}
// System.Void Rewired.Player/ControllerHelper/MapHelper::lphhQOcxOMSOPhjlSDCZLLXGLsWm(Rewired.ControllerType,System.Int32,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MapHelper_lphhQOcxOMSOPhjlSDCZLLXGLsWm_mCA8C06E4464C92F56AC93F431310898E3D3CFDD4 (MapHelper_t214BA4F045E5EB4B312E4E6AEB6697813117A7C2* __this, int32_t p0, int32_t p1, int32_t p2, const RuntimeMethod* method) ;
// System.Void Rewired.Player/ControllerHelper/MapHelper::lphhQOcxOMSOPhjlSDCZLLXGLsWm(Rewired.ControllerType,System.Int32,System.Int32,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MapHelper_lphhQOcxOMSOPhjlSDCZLLXGLsWm_m3194478C4255DC656B551522E1AB9F7FB067346C (MapHelper_t214BA4F045E5EB4B312E4E6AEB6697813117A7C2* __this, int32_t p0, int32_t p1, int32_t p2, int32_t p3, const RuntimeMethod* method) ;
// System.Void Rewired.Player/ControllerHelper/MapHelper::lphhQOcxOMSOPhjlSDCZLLXGLsWm(Rewired.ControllerType,System.Int32,System.String,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MapHelper_lphhQOcxOMSOPhjlSDCZLLXGLsWm_m3B7D645A45FA19D76F0FFA6B0DC5704477A80FFC (MapHelper_t214BA4F045E5EB4B312E4E6AEB6697813117A7C2* __this, int32_t p0, int32_t p1, String_t* p2, String_t* p3, const RuntimeMethod* method) ;
// System.Void Rewired.Player/ControllerHelper/MapHelper::xUxtwYDqEBAoBQJfMbKEZonwyhmq(Rewired.ControllerType,System.Int32,System.Int32,System.Int32,Rewired.BoolOption)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MapHelper_xUxtwYDqEBAoBQJfMbKEZonwyhmq_m27EEE026ABE014B51797CA00F9EECB40B0365F33 (MapHelper_t214BA4F045E5EB4B312E4E6AEB6697813117A7C2* __this, int32_t p0, int32_t p1, int32_t p2, int32_t p3, int32_t p4, const RuntimeMethod* method) ;
// System.Void Rewired.Player/ControllerHelper/MapHelper::xUxtwYDqEBAoBQJfMbKEZonwyhmq(Rewired.ControllerType,System.Int32,System.String,System.String,Rewired.BoolOption)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MapHelper_xUxtwYDqEBAoBQJfMbKEZonwyhmq_mB64759EE9B99E28074BDA8EA24384C48A867BC1C (MapHelper_t214BA4F045E5EB4B312E4E6AEB6697813117A7C2* __this, int32_t p0, int32_t p1, String_t* p2, String_t* p3, int32_t p4, const RuntimeMethod* method) ;
// System.Void System.Array::Clear(System.Array,System.Int32,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Array_Clear_m48B57EC27CADC3463CA98A33373D557DA587FF1B (RuntimeArray* ___array0, int32_t ___index1, int32_t ___length2, const RuntimeMethod* method) ;
// ArrayType UnityEngine._AndroidJNIHelper::ConvertFromJNIArray<System.Object>(System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* _AndroidJNIHelper_ConvertFromJNIArray_TisRuntimeObject_m5D8B7D428A5F63BF226AE0F4F532986BA7991ADC_gshared (intptr_t ___array0, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AndroidJavaObjectU5BU5D_tBCEB142050F282B940177011644246618E002001_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AndroidJavaObject_t8FFB930F335C1178405B82AC2BF512BB1EEF9EB0_0_0_0_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AndroidJavaObject_t8FFB930F335C1178405B82AC2BF512BB1EEF9EB0_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AndroidReflection_tD59014B286F902906DBB75DA3473897D35684908_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Boolean_t09A6377A54BE2F9E6985A8149F19234FD7DDFE22_0_0_0_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Byte_t94D9231AC217BE4D2E004C4CD32DF6D099EA41A3_0_0_0_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Char_t521A6F19B456D956AF452D926C32709DC03D6B17_0_0_0_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Debug_t8394C7EEAECA3689C2C9B9DE9C7166D73596276F_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Double_tE150EF3D1D43DEE85D533810AB4C742307EEDE5F_0_0_0_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Int16_tB8EF286A9C33492FA6E6D6E67320BE93E794A175_0_0_0_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Int32_t680FF22E76F6EFAD4375103CBBFFA0421349384C_0_0_0_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Int64_t092CFB123BE63C28ACDAF65C68F21A526050DBA3_0_0_0_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&SByte_tFEFFEF5D2FEBF5207950AE6FAC150FC53B668DB5_0_0_0_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Single_t4530F2FF86FCB0DC29F35385CA1BD21BE294761C_0_0_0_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&String_t_0_0_0_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Type_t_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral24CC8D396132365E532646F936DFC8579E2299B2);
		s_Il2CppMethodInitialized = true;
	}
Type_t* V_0 = NULL;
	bool V_1 = false;
	bool V_2 = false;
	RuntimeObject* V_3 = NULL;
	bool V_4 = false;
	bool V_5 = false;
	bool V_6 = false;
	bool V_7 = false;
	bool V_8 = false;
	bool V_9 = false;
	bool V_10 = false;
	bool V_11 = false;
	bool V_12 = false;
	int32_t V_13 = 0;
	StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248* V_14 = NULL;
	int32_t V_15 = 0;
	intptr_t V_16;
	memset((&V_16), 0, sizeof(V_16));
	bool V_17 = false;
	bool V_18 = false;
	int32_t V_19 = 0;
	AndroidJavaObjectU5BU5D_tBCEB142050F282B940177011644246618E002001* V_20 = NULL;
	int32_t V_21 = 0;
	intptr_t V_22;
	memset((&V_22), 0, sizeof(V_22));
	bool V_23 = false;
	RuntimeObject* V_24 = NULL;
	Type_t* G_B32_0 = NULL;
	String_t* G_B32_1 = NULL;
	Type_t* G_B31_0 = NULL;
	String_t* G_B31_1 = NULL;
	String_t* G_B33_0 = NULL;
	String_t* G_B33_1 = NULL;
	{
		RuntimeTypeHandle_t332A452B8B6179E4469B69525D0FE82A88030F7B L_0 = { reinterpret_cast<intptr_t> (il2cpp_rgctx_type(method->rgctx_data, 0)) };
		il2cpp_codegen_runtime_class_init_inline(Type_t_il2cpp_TypeInfo_var);
		Type_t* L_1;
		L_1 = Type_GetTypeFromHandle_m2570A2A5B32A5E9D9F0F38B37459DA18736C823E(L_0, NULL);
		NullCheck(L_1);
		Type_t* L_2;
		L_2 = VirtualFuncInvoker0< Type_t* >::Invoke(46 /* System.Type System.Type::GetElementType() */, L_1);
		V_0 = L_2;
		Type_t* L_3 = V_0;
		il2cpp_codegen_runtime_class_init_inline(AndroidReflection_tD59014B286F902906DBB75DA3473897D35684908_il2cpp_TypeInfo_var);
		bool L_4;
		L_4 = AndroidReflection_IsPrimitive_m48ED73958206D552B937EEC7560184C6C4228F3D(L_3, NULL);
		V_1 = L_4;
		bool L_5 = V_1;
		if (!L_5)
		{
			goto IL_0173;
		}
	}
	{
		Type_t* L_6 = V_0;
		RuntimeTypeHandle_t332A452B8B6179E4469B69525D0FE82A88030F7B L_7 = { reinterpret_cast<intptr_t> (Int32_t680FF22E76F6EFAD4375103CBBFFA0421349384C_0_0_0_var) };
		il2cpp_codegen_runtime_class_init_inline(Type_t_il2cpp_TypeInfo_var);
		Type_t* L_8;
		L_8 = Type_GetTypeFromHandle_m2570A2A5B32A5E9D9F0F38B37459DA18736C823E(L_7, NULL);
		V_2 = (bool)((((RuntimeObject*)(Type_t*)L_6) == ((RuntimeObject*)(Type_t*)L_8))? 1 : 0);
		bool L_9 = V_2;
		if (!L_9)
		{
			goto IL_0041;
		}
	}
	{
		intptr_t L_10 = ___array0;
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_11;
		L_11 = AndroidJNISafe_FromIntArray_m899EDC375E4983DCF33B5B72E2131DC06AA4B5F0(L_10, NULL);
		V_3 = ((RuntimeObject*)Castclass((RuntimeObject*)L_11, il2cpp_rgctx_data(method->rgctx_data, 1)));
		goto IL_0272;
	}

IL_0041:
	{
		Type_t* L_12 = V_0;
		RuntimeTypeHandle_t332A452B8B6179E4469B69525D0FE82A88030F7B L_13 = { reinterpret_cast<intptr_t> (Boolean_t09A6377A54BE2F9E6985A8149F19234FD7DDFE22_0_0_0_var) };
		il2cpp_codegen_runtime_class_init_inline(Type_t_il2cpp_TypeInfo_var);
		Type_t* L_14;
		L_14 = Type_GetTypeFromHandle_m2570A2A5B32A5E9D9F0F38B37459DA18736C823E(L_13, NULL);
		V_4 = (bool)((((RuntimeObject*)(Type_t*)L_12) == ((RuntimeObject*)(Type_t*)L_14))? 1 : 0);
		bool L_15 = V_4;
		if (!L_15)
		{
			goto IL_0065;
		}
	}
	{
		intptr_t L_16 = ___array0;
		BooleanU5BU5D_tD317D27C31DB892BE79FAE3AEBC0B3FFB73DE9B4* L_17;
		L_17 = AndroidJNISafe_FromBooleanArray_m3F57F10FDDBA3DC358BEF7296F58D819C9EC3BDE(L_16, NULL);
		V_3 = ((RuntimeObject*)Castclass((RuntimeObject*)L_17, il2cpp_rgctx_data(method->rgctx_data, 1)));
		goto IL_0272;
	}

IL_0065:
	{
		Type_t* L_18 = V_0;
		RuntimeTypeHandle_t332A452B8B6179E4469B69525D0FE82A88030F7B L_19 = { reinterpret_cast<intptr_t> (Byte_t94D9231AC217BE4D2E004C4CD32DF6D099EA41A3_0_0_0_var) };
		il2cpp_codegen_runtime_class_init_inline(Type_t_il2cpp_TypeInfo_var);
		Type_t* L_20;
		L_20 = Type_GetTypeFromHandle_m2570A2A5B32A5E9D9F0F38B37459DA18736C823E(L_19, NULL);
		V_5 = (bool)((((RuntimeObject*)(Type_t*)L_18) == ((RuntimeObject*)(Type_t*)L_20))? 1 : 0);
		bool L_21 = V_5;
		if (!L_21)
		{
			goto IL_0095;
		}
	}
	{
		il2cpp_codegen_runtime_class_init_inline(Debug_t8394C7EEAECA3689C2C9B9DE9C7166D73596276F_il2cpp_TypeInfo_var);
		Debug_LogWarning_mEF15C6B17CE4E1FA7E379CDB82CE40FCD89A3F28((RuntimeObject*)_stringLiteral24CC8D396132365E532646F936DFC8579E2299B2, NULL);
		intptr_t L_22 = ___array0;
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_23;
		L_23 = AndroidJNISafe_FromByteArray_mAED5B8EEF34E268BB146A277842089C7FD8A06BB(L_22, NULL);
		V_3 = ((RuntimeObject*)Castclass((RuntimeObject*)L_23, il2cpp_rgctx_data(method->rgctx_data, 1)));
		goto IL_0272;
	}

IL_0095:
	{
		Type_t* L_24 = V_0;
		RuntimeTypeHandle_t332A452B8B6179E4469B69525D0FE82A88030F7B L_25 = { reinterpret_cast<intptr_t> (SByte_tFEFFEF5D2FEBF5207950AE6FAC150FC53B668DB5_0_0_0_var) };
		il2cpp_codegen_runtime_class_init_inline(Type_t_il2cpp_TypeInfo_var);
		Type_t* L_26;
		L_26 = Type_GetTypeFromHandle_m2570A2A5B32A5E9D9F0F38B37459DA18736C823E(L_25, NULL);
		V_6 = (bool)((((RuntimeObject*)(Type_t*)L_24) == ((RuntimeObject*)(Type_t*)L_26))? 1 : 0);
		bool L_27 = V_6;
		if (!L_27)
		{
			goto IL_00b9;
		}
	}
	{
		intptr_t L_28 = ___array0;
		SByteU5BU5D_t88116DA68378C3333DB73E7D36C1A06AFAA91913* L_29;
		L_29 = AndroidJNISafe_FromSByteArray_m5825C71BA6941CDF25627AD77CDBE648CB322476(L_28, NULL);
		V_3 = ((RuntimeObject*)Castclass((RuntimeObject*)L_29, il2cpp_rgctx_data(method->rgctx_data, 1)));
		goto IL_0272;
	}

IL_00b9:
	{
		Type_t* L_30 = V_0;
		RuntimeTypeHandle_t332A452B8B6179E4469B69525D0FE82A88030F7B L_31 = { reinterpret_cast<intptr_t> (Int16_tB8EF286A9C33492FA6E6D6E67320BE93E794A175_0_0_0_var) };
		il2cpp_codegen_runtime_class_init_inline(Type_t_il2cpp_TypeInfo_var);
		Type_t* L_32;
		L_32 = Type_GetTypeFromHandle_m2570A2A5B32A5E9D9F0F38B37459DA18736C823E(L_31, NULL);
		V_7 = (bool)((((RuntimeObject*)(Type_t*)L_30) == ((RuntimeObject*)(Type_t*)L_32))? 1 : 0);
		bool L_33 = V_7;
		if (!L_33)
		{
			goto IL_00dd;
		}
	}
	{
		intptr_t L_34 = ___array0;
		Int16U5BU5D_t8175CE8DD9C9F9FB0CF4F58E45BC570575B43CFB* L_35;
		L_35 = AndroidJNISafe_FromShortArray_m227116D8E01EE3568936FB93C97CAEE9062A0A35(L_34, NULL);
		V_3 = ((RuntimeObject*)Castclass((RuntimeObject*)L_35, il2cpp_rgctx_data(method->rgctx_data, 1)));
		goto IL_0272;
	}

IL_00dd:
	{
		Type_t* L_36 = V_0;
		RuntimeTypeHandle_t332A452B8B6179E4469B69525D0FE82A88030F7B L_37 = { reinterpret_cast<intptr_t> (Int64_t092CFB123BE63C28ACDAF65C68F21A526050DBA3_0_0_0_var) };
		il2cpp_codegen_runtime_class_init_inline(Type_t_il2cpp_TypeInfo_var);
		Type_t* L_38;
		L_38 = Type_GetTypeFromHandle_m2570A2A5B32A5E9D9F0F38B37459DA18736C823E(L_37, NULL);
		V_8 = (bool)((((RuntimeObject*)(Type_t*)L_36) == ((RuntimeObject*)(Type_t*)L_38))? 1 : 0);
		bool L_39 = V_8;
		if (!L_39)
		{
			goto IL_0101;
		}
	}
	{
		intptr_t L_40 = ___array0;
		Int64U5BU5D_tAEDFCBDB5414E2A140A6F34C0538BF97FCF67A1D* L_41;
		L_41 = AndroidJNISafe_FromLongArray_m687FC548BFA4DC440379619E5C7CB56354E30D59(L_40, NULL);
		V_3 = ((RuntimeObject*)Castclass((RuntimeObject*)L_41, il2cpp_rgctx_data(method->rgctx_data, 1)));
		goto IL_0272;
	}

IL_0101:
	{
		Type_t* L_42 = V_0;
		RuntimeTypeHandle_t332A452B8B6179E4469B69525D0FE82A88030F7B L_43 = { reinterpret_cast<intptr_t> (Single_t4530F2FF86FCB0DC29F35385CA1BD21BE294761C_0_0_0_var) };
		il2cpp_codegen_runtime_class_init_inline(Type_t_il2cpp_TypeInfo_var);
		Type_t* L_44;
		L_44 = Type_GetTypeFromHandle_m2570A2A5B32A5E9D9F0F38B37459DA18736C823E(L_43, NULL);
		V_9 = (bool)((((RuntimeObject*)(Type_t*)L_42) == ((RuntimeObject*)(Type_t*)L_44))? 1 : 0);
		bool L_45 = V_9;
		if (!L_45)
		{
			goto IL_0125;
		}
	}
	{
		intptr_t L_46 = ___array0;
		SingleU5BU5D_t89DEFE97BCEDB5857010E79ECE0F52CF6E93B87C* L_47;
		L_47 = AndroidJNISafe_FromFloatArray_m97B7BC8546EC3F9CF0784D434D4AA41FBB409892(L_46, NULL);
		V_3 = ((RuntimeObject*)Castclass((RuntimeObject*)L_47, il2cpp_rgctx_data(method->rgctx_data, 1)));
		goto IL_0272;
	}

IL_0125:
	{
		Type_t* L_48 = V_0;
		RuntimeTypeHandle_t332A452B8B6179E4469B69525D0FE82A88030F7B L_49 = { reinterpret_cast<intptr_t> (Double_tE150EF3D1D43DEE85D533810AB4C742307EEDE5F_0_0_0_var) };
		il2cpp_codegen_runtime_class_init_inline(Type_t_il2cpp_TypeInfo_var);
		Type_t* L_50;
		L_50 = Type_GetTypeFromHandle_m2570A2A5B32A5E9D9F0F38B37459DA18736C823E(L_49, NULL);
		V_10 = (bool)((((RuntimeObject*)(Type_t*)L_48) == ((RuntimeObject*)(Type_t*)L_50))? 1 : 0);
		bool L_51 = V_10;
		if (!L_51)
		{
			goto IL_0149;
		}
	}
	{
		intptr_t L_52 = ___array0;
		DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE* L_53;
		L_53 = AndroidJNISafe_FromDoubleArray_mB752FB522CD25191E5C6AF8CEFA4553593F784A7(L_52, NULL);
		V_3 = ((RuntimeObject*)Castclass((RuntimeObject*)L_53, il2cpp_rgctx_data(method->rgctx_data, 1)));
		goto IL_0272;
	}

IL_0149:
	{
		Type_t* L_54 = V_0;
		RuntimeTypeHandle_t332A452B8B6179E4469B69525D0FE82A88030F7B L_55 = { reinterpret_cast<intptr_t> (Char_t521A6F19B456D956AF452D926C32709DC03D6B17_0_0_0_var) };
		il2cpp_codegen_runtime_class_init_inline(Type_t_il2cpp_TypeInfo_var);
		Type_t* L_56;
		L_56 = Type_GetTypeFromHandle_m2570A2A5B32A5E9D9F0F38B37459DA18736C823E(L_55, NULL);
		V_11 = (bool)((((RuntimeObject*)(Type_t*)L_54) == ((RuntimeObject*)(Type_t*)L_56))? 1 : 0);
		bool L_57 = V_11;
		if (!L_57)
		{
			goto IL_016d;
		}
	}
	{
		intptr_t L_58 = ___array0;
		CharU5BU5D_t799905CF001DD5F13F7DBB310181FC4D8B7D0AAB* L_59;
		L_59 = AndroidJNISafe_FromCharArray_mC1C728B67330FD610542B4C2D6B9759F78B2BD17(L_58, NULL);
		V_3 = ((RuntimeObject*)Castclass((RuntimeObject*)L_59, il2cpp_rgctx_data(method->rgctx_data, 1)));
		goto IL_0272;
	}

IL_016d:
	{
		goto IL_0265;
	}

IL_0173:
	{
		Type_t* L_60 = V_0;
		RuntimeTypeHandle_t332A452B8B6179E4469B69525D0FE82A88030F7B L_61 = { reinterpret_cast<intptr_t> (String_t_0_0_0_var) };
		il2cpp_codegen_runtime_class_init_inline(Type_t_il2cpp_TypeInfo_var);
		Type_t* L_62;
		L_62 = Type_GetTypeFromHandle_m2570A2A5B32A5E9D9F0F38B37459DA18736C823E(L_61, NULL);
		V_12 = (bool)((((RuntimeObject*)(Type_t*)L_60) == ((RuntimeObject*)(Type_t*)L_62))? 1 : 0);
		bool L_63 = V_12;
		if (!L_63)
		{
			goto IL_01dc;
		}
	}
	{
		intptr_t L_64 = ___array0;
		int32_t L_65;
		L_65 = AndroidJNISafe_GetArrayLength_mB5F7260E652BE95FE9237A47C1E1597306B462C3(L_64, NULL);
		V_13 = L_65;
		int32_t L_66 = V_13;
		StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248* L_67 = (StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248*)(StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248*)SZArrayNew(StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248_il2cpp_TypeInfo_var, (uint32_t)L_66);
		V_14 = L_67;
		V_15 = 0;
		goto IL_01c3;
	}

IL_019d:
	{
		intptr_t L_68 = ___array0;
		int32_t L_69 = V_15;
		intptr_t L_70;
		L_70 = AndroidJNI_GetObjectArrayElement_mDD7F2DC202FA14B8E5889755FB02B401C1127AD0(L_68, L_69, NULL);
		V_16 = L_70;
		StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248* L_71 = V_14;
		int32_t L_72 = V_15;
		intptr_t L_73 = V_16;
		String_t* L_74;
		L_74 = AndroidJNISafe_GetStringChars_m21A07825755C0A9AF91F8248A1C98F861E26928F(L_73, NULL);
		NullCheck(L_71);
		ArrayElementTypeCheck (L_71, L_74);
		(L_71)->SetAt(static_cast<il2cpp_array_size_t>(L_72), (String_t*)L_74);
		intptr_t L_75 = V_16;
		AndroidJNISafe_DeleteLocalRef_m80503AA6C85CE46E8CE72C62215E1BE62964424D(L_75, NULL);
		int32_t L_76 = V_15;
		V_15 = ((int32_t)il2cpp_codegen_add(L_76, 1));
	}

IL_01c3:
	{
		int32_t L_77 = V_15;
		int32_t L_78 = V_13;
		V_17 = (bool)((((int32_t)L_77) < ((int32_t)L_78))? 1 : 0);
		bool L_79 = V_17;
		if (L_79)
		{
			goto IL_019d;
		}
	}
	{
		StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248* L_80 = V_14;
		V_3 = ((RuntimeObject*)Castclass((RuntimeObject*)L_80, il2cpp_rgctx_data(method->rgctx_data, 1)));
		goto IL_0272;
	}

IL_01dc:
	{
		Type_t* L_81 = V_0;
		RuntimeTypeHandle_t332A452B8B6179E4469B69525D0FE82A88030F7B L_82 = { reinterpret_cast<intptr_t> (AndroidJavaObject_t8FFB930F335C1178405B82AC2BF512BB1EEF9EB0_0_0_0_var) };
		il2cpp_codegen_runtime_class_init_inline(Type_t_il2cpp_TypeInfo_var);
		Type_t* L_83;
		L_83 = Type_GetTypeFromHandle_m2570A2A5B32A5E9D9F0F38B37459DA18736C823E(L_82, NULL);
		V_18 = (bool)((((RuntimeObject*)(Type_t*)L_81) == ((RuntimeObject*)(Type_t*)L_83))? 1 : 0);
		bool L_84 = V_18;
		if (!L_84)
		{
			goto IL_0242;
		}
	}
	{
		intptr_t L_85 = ___array0;
		int32_t L_86;
		L_86 = AndroidJNISafe_GetArrayLength_mB5F7260E652BE95FE9237A47C1E1597306B462C3(L_85, NULL);
		V_19 = L_86;
		int32_t L_87 = V_19;
		AndroidJavaObjectU5BU5D_tBCEB142050F282B940177011644246618E002001* L_88 = (AndroidJavaObjectU5BU5D_tBCEB142050F282B940177011644246618E002001*)(AndroidJavaObjectU5BU5D_tBCEB142050F282B940177011644246618E002001*)SZArrayNew(AndroidJavaObjectU5BU5D_tBCEB142050F282B940177011644246618E002001_il2cpp_TypeInfo_var, (uint32_t)L_87);
		V_20 = L_88;
		V_21 = 0;
		goto IL_022c;
	}

IL_0206:
	{
		intptr_t L_89 = ___array0;
		int32_t L_90 = V_21;
		intptr_t L_91;
		L_91 = AndroidJNI_GetObjectArrayElement_mDD7F2DC202FA14B8E5889755FB02B401C1127AD0(L_89, L_90, NULL);
		V_22 = L_91;
		AndroidJavaObjectU5BU5D_tBCEB142050F282B940177011644246618E002001* L_92 = V_20;
		int32_t L_93 = V_21;
		intptr_t L_94 = V_22;
		AndroidJavaObject_t8FFB930F335C1178405B82AC2BF512BB1EEF9EB0* L_95 = (AndroidJavaObject_t8FFB930F335C1178405B82AC2BF512BB1EEF9EB0*)il2cpp_codegen_object_new(AndroidJavaObject_t8FFB930F335C1178405B82AC2BF512BB1EEF9EB0_il2cpp_TypeInfo_var);
		AndroidJavaObject__ctor_m0CEE7D570807333CE2C193A82AB3AB8D4F873A6B(L_95, L_94, /*hidden argument*/NULL);
		NullCheck(L_92);
		ArrayElementTypeCheck (L_92, L_95);
		(L_92)->SetAt(static_cast<il2cpp_array_size_t>(L_93), (AndroidJavaObject_t8FFB930F335C1178405B82AC2BF512BB1EEF9EB0*)L_95);
		intptr_t L_96 = V_22;
		AndroidJNISafe_DeleteLocalRef_m80503AA6C85CE46E8CE72C62215E1BE62964424D(L_96, NULL);
		int32_t L_97 = V_21;
		V_21 = ((int32_t)il2cpp_codegen_add(L_97, 1));
	}

IL_022c:
	{
		int32_t L_98 = V_21;
		int32_t L_99 = V_19;
		V_23 = (bool)((((int32_t)L_98) < ((int32_t)L_99))? 1 : 0);
		bool L_100 = V_23;
		if (L_100)
		{
			goto IL_0206;
		}
	}
	{
		AndroidJavaObjectU5BU5D_tBCEB142050F282B940177011644246618E002001* L_101 = V_20;
		V_3 = ((RuntimeObject*)Castclass((RuntimeObject*)L_101, il2cpp_rgctx_data(method->rgctx_data, 1)));
		goto IL_0272;
	}

IL_0242:
	{
		Type_t* L_102 = V_0;
		Type_t* L_103 = L_102;
		G_B31_0 = L_103;
		G_B31_1 = ((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteral51253131B895C2F8066BCC47E62D44F18F43446C));
		if (L_103)
		{
			G_B32_0 = L_103;
			G_B32_1 = ((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteral51253131B895C2F8066BCC47E62D44F18F43446C));
			goto IL_0250;
		}
	}
	{
		G_B33_0 = ((String_t*)(NULL));
		G_B33_1 = G_B31_1;
		goto IL_0255;
	}

IL_0250:
	{
		NullCheck((RuntimeObject*)G_B32_0);
		String_t* L_104;
		L_104 = VirtualFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, (RuntimeObject*)G_B32_0);
		G_B33_0 = L_104;
		G_B33_1 = G_B32_1;
	}

IL_0255:
	{
		String_t* L_105;
		L_105 = String_Concat_m9B13B47FCB3DF61144D9647DDA05F527377251B0(G_B33_1, G_B33_0, ((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteral42646B33B50B6AA15E22733C8900716F0FE19E1D)), NULL);
		Exception_t* L_106 = (Exception_t*)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&Exception_t_il2cpp_TypeInfo_var)));
		Exception__ctor_m9B2BD92CD68916245A75109105D9071C9D430E7F(L_106, L_105, /*hidden argument*/NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_106, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_AndroidJNIHelper_ConvertFromJNIArray_TisRuntimeObject_m5D8B7D428A5F63BF226AE0F4F532986BA7991ADC_RuntimeMethod_var)));
	}

IL_0265:
	{
		il2cpp_codegen_initobj((&V_24), sizeof(RuntimeObject*));
		RuntimeObject* L_107 = V_24;
		V_3 = L_107;
		goto IL_0272;
	}

IL_0272:
	{
		RuntimeObject* L_108 = V_3;
		return L_108;
	}
}
// ArrayType UnityEngine._AndroidJNIHelper::ConvertFromJNIArray<System.SByte>(System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int8_t _AndroidJNIHelper_ConvertFromJNIArray_TisSByte_tFEFFEF5D2FEBF5207950AE6FAC150FC53B668DB5_mA0B7EDEC4FB783CA5C528BD35AC09FE99A737138_gshared (intptr_t ___array0, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AndroidJavaObjectU5BU5D_tBCEB142050F282B940177011644246618E002001_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AndroidJavaObject_t8FFB930F335C1178405B82AC2BF512BB1EEF9EB0_0_0_0_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AndroidJavaObject_t8FFB930F335C1178405B82AC2BF512BB1EEF9EB0_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AndroidReflection_tD59014B286F902906DBB75DA3473897D35684908_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Boolean_t09A6377A54BE2F9E6985A8149F19234FD7DDFE22_0_0_0_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Byte_t94D9231AC217BE4D2E004C4CD32DF6D099EA41A3_0_0_0_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Char_t521A6F19B456D956AF452D926C32709DC03D6B17_0_0_0_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Debug_t8394C7EEAECA3689C2C9B9DE9C7166D73596276F_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Double_tE150EF3D1D43DEE85D533810AB4C742307EEDE5F_0_0_0_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Int16_tB8EF286A9C33492FA6E6D6E67320BE93E794A175_0_0_0_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Int32_t680FF22E76F6EFAD4375103CBBFFA0421349384C_0_0_0_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Int64_t092CFB123BE63C28ACDAF65C68F21A526050DBA3_0_0_0_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&SByte_tFEFFEF5D2FEBF5207950AE6FAC150FC53B668DB5_0_0_0_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Single_t4530F2FF86FCB0DC29F35385CA1BD21BE294761C_0_0_0_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&String_t_0_0_0_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Type_t_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral24CC8D396132365E532646F936DFC8579E2299B2);
		s_Il2CppMethodInitialized = true;
	}
Type_t* V_0 = NULL;
	bool V_1 = false;
	bool V_2 = false;
	int8_t V_3 = 0x0;
	bool V_4 = false;
	bool V_5 = false;
	bool V_6 = false;
	bool V_7 = false;
	bool V_8 = false;
	bool V_9 = false;
	bool V_10 = false;
	bool V_11 = false;
	bool V_12 = false;
	int32_t V_13 = 0;
	StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248* V_14 = NULL;
	int32_t V_15 = 0;
	intptr_t V_16;
	memset((&V_16), 0, sizeof(V_16));
	bool V_17 = false;
	bool V_18 = false;
	int32_t V_19 = 0;
	AndroidJavaObjectU5BU5D_tBCEB142050F282B940177011644246618E002001* V_20 = NULL;
	int32_t V_21 = 0;
	intptr_t V_22;
	memset((&V_22), 0, sizeof(V_22));
	bool V_23 = false;
	int8_t V_24 = 0x0;
	Type_t* G_B32_0 = NULL;
	String_t* G_B32_1 = NULL;
	Type_t* G_B31_0 = NULL;
	String_t* G_B31_1 = NULL;
	String_t* G_B33_0 = NULL;
	String_t* G_B33_1 = NULL;
	{
		RuntimeTypeHandle_t332A452B8B6179E4469B69525D0FE82A88030F7B L_0 = { reinterpret_cast<intptr_t> (il2cpp_rgctx_type(method->rgctx_data, 0)) };
		il2cpp_codegen_runtime_class_init_inline(Type_t_il2cpp_TypeInfo_var);
		Type_t* L_1;
		L_1 = Type_GetTypeFromHandle_m2570A2A5B32A5E9D9F0F38B37459DA18736C823E(L_0, NULL);
		NullCheck(L_1);
		Type_t* L_2;
		L_2 = VirtualFuncInvoker0< Type_t* >::Invoke(46 /* System.Type System.Type::GetElementType() */, L_1);
		V_0 = L_2;
		Type_t* L_3 = V_0;
		il2cpp_codegen_runtime_class_init_inline(AndroidReflection_tD59014B286F902906DBB75DA3473897D35684908_il2cpp_TypeInfo_var);
		bool L_4;
		L_4 = AndroidReflection_IsPrimitive_m48ED73958206D552B937EEC7560184C6C4228F3D(L_3, NULL);
		V_1 = L_4;
		bool L_5 = V_1;
		if (!L_5)
		{
			goto IL_0173;
		}
	}
	{
		Type_t* L_6 = V_0;
		RuntimeTypeHandle_t332A452B8B6179E4469B69525D0FE82A88030F7B L_7 = { reinterpret_cast<intptr_t> (Int32_t680FF22E76F6EFAD4375103CBBFFA0421349384C_0_0_0_var) };
		il2cpp_codegen_runtime_class_init_inline(Type_t_il2cpp_TypeInfo_var);
		Type_t* L_8;
		L_8 = Type_GetTypeFromHandle_m2570A2A5B32A5E9D9F0F38B37459DA18736C823E(L_7, NULL);
		V_2 = (bool)((((RuntimeObject*)(Type_t*)L_6) == ((RuntimeObject*)(Type_t*)L_8))? 1 : 0);
		bool L_9 = V_2;
		if (!L_9)
		{
			goto IL_0041;
		}
	}
	{
		intptr_t L_10 = ___array0;
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_11;
		L_11 = AndroidJNISafe_FromIntArray_m899EDC375E4983DCF33B5B72E2131DC06AA4B5F0(L_10, NULL);
		V_3 = ((*(int8_t*)((int8_t*)(int8_t*)UnBox((RuntimeObject*)L_11, il2cpp_rgctx_data(method->rgctx_data, 1)))));
		goto IL_0272;
	}

IL_0041:
	{
		Type_t* L_12 = V_0;
		RuntimeTypeHandle_t332A452B8B6179E4469B69525D0FE82A88030F7B L_13 = { reinterpret_cast<intptr_t> (Boolean_t09A6377A54BE2F9E6985A8149F19234FD7DDFE22_0_0_0_var) };
		il2cpp_codegen_runtime_class_init_inline(Type_t_il2cpp_TypeInfo_var);
		Type_t* L_14;
		L_14 = Type_GetTypeFromHandle_m2570A2A5B32A5E9D9F0F38B37459DA18736C823E(L_13, NULL);
		V_4 = (bool)((((RuntimeObject*)(Type_t*)L_12) == ((RuntimeObject*)(Type_t*)L_14))? 1 : 0);
		bool L_15 = V_4;
		if (!L_15)
		{
			goto IL_0065;
		}
	}
	{
		intptr_t L_16 = ___array0;
		BooleanU5BU5D_tD317D27C31DB892BE79FAE3AEBC0B3FFB73DE9B4* L_17;
		L_17 = AndroidJNISafe_FromBooleanArray_m3F57F10FDDBA3DC358BEF7296F58D819C9EC3BDE(L_16, NULL);
		V_3 = ((*(int8_t*)((int8_t*)(int8_t*)UnBox((RuntimeObject*)L_17, il2cpp_rgctx_data(method->rgctx_data, 1)))));
		goto IL_0272;
	}

IL_0065:
	{
		Type_t* L_18 = V_0;
		RuntimeTypeHandle_t332A452B8B6179E4469B69525D0FE82A88030F7B L_19 = { reinterpret_cast<intptr_t> (Byte_t94D9231AC217BE4D2E004C4CD32DF6D099EA41A3_0_0_0_var) };
		il2cpp_codegen_runtime_class_init_inline(Type_t_il2cpp_TypeInfo_var);
		Type_t* L_20;
		L_20 = Type_GetTypeFromHandle_m2570A2A5B32A5E9D9F0F38B37459DA18736C823E(L_19, NULL);
		V_5 = (bool)((((RuntimeObject*)(Type_t*)L_18) == ((RuntimeObject*)(Type_t*)L_20))? 1 : 0);
		bool L_21 = V_5;
		if (!L_21)
		{
			goto IL_0095;
		}
	}
	{
		il2cpp_codegen_runtime_class_init_inline(Debug_t8394C7EEAECA3689C2C9B9DE9C7166D73596276F_il2cpp_TypeInfo_var);
		Debug_LogWarning_mEF15C6B17CE4E1FA7E379CDB82CE40FCD89A3F28((RuntimeObject*)_stringLiteral24CC8D396132365E532646F936DFC8579E2299B2, NULL);
		intptr_t L_22 = ___array0;
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_23;
		L_23 = AndroidJNISafe_FromByteArray_mAED5B8EEF34E268BB146A277842089C7FD8A06BB(L_22, NULL);
		V_3 = ((*(int8_t*)((int8_t*)(int8_t*)UnBox((RuntimeObject*)L_23, il2cpp_rgctx_data(method->rgctx_data, 1)))));
		goto IL_0272;
	}

IL_0095:
	{
		Type_t* L_24 = V_0;
		RuntimeTypeHandle_t332A452B8B6179E4469B69525D0FE82A88030F7B L_25 = { reinterpret_cast<intptr_t> (SByte_tFEFFEF5D2FEBF5207950AE6FAC150FC53B668DB5_0_0_0_var) };
		il2cpp_codegen_runtime_class_init_inline(Type_t_il2cpp_TypeInfo_var);
		Type_t* L_26;
		L_26 = Type_GetTypeFromHandle_m2570A2A5B32A5E9D9F0F38B37459DA18736C823E(L_25, NULL);
		V_6 = (bool)((((RuntimeObject*)(Type_t*)L_24) == ((RuntimeObject*)(Type_t*)L_26))? 1 : 0);
		bool L_27 = V_6;
		if (!L_27)
		{
			goto IL_00b9;
		}
	}
	{
		intptr_t L_28 = ___array0;
		SByteU5BU5D_t88116DA68378C3333DB73E7D36C1A06AFAA91913* L_29;
		L_29 = AndroidJNISafe_FromSByteArray_m5825C71BA6941CDF25627AD77CDBE648CB322476(L_28, NULL);
		V_3 = ((*(int8_t*)((int8_t*)(int8_t*)UnBox((RuntimeObject*)L_29, il2cpp_rgctx_data(method->rgctx_data, 1)))));
		goto IL_0272;
	}

IL_00b9:
	{
		Type_t* L_30 = V_0;
		RuntimeTypeHandle_t332A452B8B6179E4469B69525D0FE82A88030F7B L_31 = { reinterpret_cast<intptr_t> (Int16_tB8EF286A9C33492FA6E6D6E67320BE93E794A175_0_0_0_var) };
		il2cpp_codegen_runtime_class_init_inline(Type_t_il2cpp_TypeInfo_var);
		Type_t* L_32;
		L_32 = Type_GetTypeFromHandle_m2570A2A5B32A5E9D9F0F38B37459DA18736C823E(L_31, NULL);
		V_7 = (bool)((((RuntimeObject*)(Type_t*)L_30) == ((RuntimeObject*)(Type_t*)L_32))? 1 : 0);
		bool L_33 = V_7;
		if (!L_33)
		{
			goto IL_00dd;
		}
	}
	{
		intptr_t L_34 = ___array0;
		Int16U5BU5D_t8175CE8DD9C9F9FB0CF4F58E45BC570575B43CFB* L_35;
		L_35 = AndroidJNISafe_FromShortArray_m227116D8E01EE3568936FB93C97CAEE9062A0A35(L_34, NULL);
		V_3 = ((*(int8_t*)((int8_t*)(int8_t*)UnBox((RuntimeObject*)L_35, il2cpp_rgctx_data(method->rgctx_data, 1)))));
		goto IL_0272;
	}

IL_00dd:
	{
		Type_t* L_36 = V_0;
		RuntimeTypeHandle_t332A452B8B6179E4469B69525D0FE82A88030F7B L_37 = { reinterpret_cast<intptr_t> (Int64_t092CFB123BE63C28ACDAF65C68F21A526050DBA3_0_0_0_var) };
		il2cpp_codegen_runtime_class_init_inline(Type_t_il2cpp_TypeInfo_var);
		Type_t* L_38;
		L_38 = Type_GetTypeFromHandle_m2570A2A5B32A5E9D9F0F38B37459DA18736C823E(L_37, NULL);
		V_8 = (bool)((((RuntimeObject*)(Type_t*)L_36) == ((RuntimeObject*)(Type_t*)L_38))? 1 : 0);
		bool L_39 = V_8;
		if (!L_39)
		{
			goto IL_0101;
		}
	}
	{
		intptr_t L_40 = ___array0;
		Int64U5BU5D_tAEDFCBDB5414E2A140A6F34C0538BF97FCF67A1D* L_41;
		L_41 = AndroidJNISafe_FromLongArray_m687FC548BFA4DC440379619E5C7CB56354E30D59(L_40, NULL);
		V_3 = ((*(int8_t*)((int8_t*)(int8_t*)UnBox((RuntimeObject*)L_41, il2cpp_rgctx_data(method->rgctx_data, 1)))));
		goto IL_0272;
	}

IL_0101:
	{
		Type_t* L_42 = V_0;
		RuntimeTypeHandle_t332A452B8B6179E4469B69525D0FE82A88030F7B L_43 = { reinterpret_cast<intptr_t> (Single_t4530F2FF86FCB0DC29F35385CA1BD21BE294761C_0_0_0_var) };
		il2cpp_codegen_runtime_class_init_inline(Type_t_il2cpp_TypeInfo_var);
		Type_t* L_44;
		L_44 = Type_GetTypeFromHandle_m2570A2A5B32A5E9D9F0F38B37459DA18736C823E(L_43, NULL);
		V_9 = (bool)((((RuntimeObject*)(Type_t*)L_42) == ((RuntimeObject*)(Type_t*)L_44))? 1 : 0);
		bool L_45 = V_9;
		if (!L_45)
		{
			goto IL_0125;
		}
	}
	{
		intptr_t L_46 = ___array0;
		SingleU5BU5D_t89DEFE97BCEDB5857010E79ECE0F52CF6E93B87C* L_47;
		L_47 = AndroidJNISafe_FromFloatArray_m97B7BC8546EC3F9CF0784D434D4AA41FBB409892(L_46, NULL);
		V_3 = ((*(int8_t*)((int8_t*)(int8_t*)UnBox((RuntimeObject*)L_47, il2cpp_rgctx_data(method->rgctx_data, 1)))));
		goto IL_0272;
	}

IL_0125:
	{
		Type_t* L_48 = V_0;
		RuntimeTypeHandle_t332A452B8B6179E4469B69525D0FE82A88030F7B L_49 = { reinterpret_cast<intptr_t> (Double_tE150EF3D1D43DEE85D533810AB4C742307EEDE5F_0_0_0_var) };
		il2cpp_codegen_runtime_class_init_inline(Type_t_il2cpp_TypeInfo_var);
		Type_t* L_50;
		L_50 = Type_GetTypeFromHandle_m2570A2A5B32A5E9D9F0F38B37459DA18736C823E(L_49, NULL);
		V_10 = (bool)((((RuntimeObject*)(Type_t*)L_48) == ((RuntimeObject*)(Type_t*)L_50))? 1 : 0);
		bool L_51 = V_10;
		if (!L_51)
		{
			goto IL_0149;
		}
	}
	{
		intptr_t L_52 = ___array0;
		DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE* L_53;
		L_53 = AndroidJNISafe_FromDoubleArray_mB752FB522CD25191E5C6AF8CEFA4553593F784A7(L_52, NULL);
		V_3 = ((*(int8_t*)((int8_t*)(int8_t*)UnBox((RuntimeObject*)L_53, il2cpp_rgctx_data(method->rgctx_data, 1)))));
		goto IL_0272;
	}

IL_0149:
	{
		Type_t* L_54 = V_0;
		RuntimeTypeHandle_t332A452B8B6179E4469B69525D0FE82A88030F7B L_55 = { reinterpret_cast<intptr_t> (Char_t521A6F19B456D956AF452D926C32709DC03D6B17_0_0_0_var) };
		il2cpp_codegen_runtime_class_init_inline(Type_t_il2cpp_TypeInfo_var);
		Type_t* L_56;
		L_56 = Type_GetTypeFromHandle_m2570A2A5B32A5E9D9F0F38B37459DA18736C823E(L_55, NULL);
		V_11 = (bool)((((RuntimeObject*)(Type_t*)L_54) == ((RuntimeObject*)(Type_t*)L_56))? 1 : 0);
		bool L_57 = V_11;
		if (!L_57)
		{
			goto IL_016d;
		}
	}
	{
		intptr_t L_58 = ___array0;
		CharU5BU5D_t799905CF001DD5F13F7DBB310181FC4D8B7D0AAB* L_59;
		L_59 = AndroidJNISafe_FromCharArray_mC1C728B67330FD610542B4C2D6B9759F78B2BD17(L_58, NULL);
		V_3 = ((*(int8_t*)((int8_t*)(int8_t*)UnBox((RuntimeObject*)L_59, il2cpp_rgctx_data(method->rgctx_data, 1)))));
		goto IL_0272;
	}

IL_016d:
	{
		goto IL_0265;
	}

IL_0173:
	{
		Type_t* L_60 = V_0;
		RuntimeTypeHandle_t332A452B8B6179E4469B69525D0FE82A88030F7B L_61 = { reinterpret_cast<intptr_t> (String_t_0_0_0_var) };
		il2cpp_codegen_runtime_class_init_inline(Type_t_il2cpp_TypeInfo_var);
		Type_t* L_62;
		L_62 = Type_GetTypeFromHandle_m2570A2A5B32A5E9D9F0F38B37459DA18736C823E(L_61, NULL);
		V_12 = (bool)((((RuntimeObject*)(Type_t*)L_60) == ((RuntimeObject*)(Type_t*)L_62))? 1 : 0);
		bool L_63 = V_12;
		if (!L_63)
		{
			goto IL_01dc;
		}
	}
	{
		intptr_t L_64 = ___array0;
		int32_t L_65;
		L_65 = AndroidJNISafe_GetArrayLength_mB5F7260E652BE95FE9237A47C1E1597306B462C3(L_64, NULL);
		V_13 = L_65;
		int32_t L_66 = V_13;
		StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248* L_67 = (StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248*)(StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248*)SZArrayNew(StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248_il2cpp_TypeInfo_var, (uint32_t)L_66);
		V_14 = L_67;
		V_15 = 0;
		goto IL_01c3;
	}

IL_019d:
	{
		intptr_t L_68 = ___array0;
		int32_t L_69 = V_15;
		intptr_t L_70;
		L_70 = AndroidJNI_GetObjectArrayElement_mDD7F2DC202FA14B8E5889755FB02B401C1127AD0(L_68, L_69, NULL);
		V_16 = L_70;
		StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248* L_71 = V_14;
		int32_t L_72 = V_15;
		intptr_t L_73 = V_16;
		String_t* L_74;
		L_74 = AndroidJNISafe_GetStringChars_m21A07825755C0A9AF91F8248A1C98F861E26928F(L_73, NULL);
		NullCheck(L_71);
		ArrayElementTypeCheck (L_71, L_74);
		(L_71)->SetAt(static_cast<il2cpp_array_size_t>(L_72), (String_t*)L_74);
		intptr_t L_75 = V_16;
		AndroidJNISafe_DeleteLocalRef_m80503AA6C85CE46E8CE72C62215E1BE62964424D(L_75, NULL);
		int32_t L_76 = V_15;
		V_15 = ((int32_t)il2cpp_codegen_add(L_76, 1));
	}

IL_01c3:
	{
		int32_t L_77 = V_15;
		int32_t L_78 = V_13;
		V_17 = (bool)((((int32_t)L_77) < ((int32_t)L_78))? 1 : 0);
		bool L_79 = V_17;
		if (L_79)
		{
			goto IL_019d;
		}
	}
	{
		StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248* L_80 = V_14;
		V_3 = ((*(int8_t*)((int8_t*)(int8_t*)UnBox((RuntimeObject*)L_80, il2cpp_rgctx_data(method->rgctx_data, 1)))));
		goto IL_0272;
	}

IL_01dc:
	{
		Type_t* L_81 = V_0;
		RuntimeTypeHandle_t332A452B8B6179E4469B69525D0FE82A88030F7B L_82 = { reinterpret_cast<intptr_t> (AndroidJavaObject_t8FFB930F335C1178405B82AC2BF512BB1EEF9EB0_0_0_0_var) };
		il2cpp_codegen_runtime_class_init_inline(Type_t_il2cpp_TypeInfo_var);
		Type_t* L_83;
		L_83 = Type_GetTypeFromHandle_m2570A2A5B32A5E9D9F0F38B37459DA18736C823E(L_82, NULL);
		V_18 = (bool)((((RuntimeObject*)(Type_t*)L_81) == ((RuntimeObject*)(Type_t*)L_83))? 1 : 0);
		bool L_84 = V_18;
		if (!L_84)
		{
			goto IL_0242;
		}
	}
	{
		intptr_t L_85 = ___array0;
		int32_t L_86;
		L_86 = AndroidJNISafe_GetArrayLength_mB5F7260E652BE95FE9237A47C1E1597306B462C3(L_85, NULL);
		V_19 = L_86;
		int32_t L_87 = V_19;
		AndroidJavaObjectU5BU5D_tBCEB142050F282B940177011644246618E002001* L_88 = (AndroidJavaObjectU5BU5D_tBCEB142050F282B940177011644246618E002001*)(AndroidJavaObjectU5BU5D_tBCEB142050F282B940177011644246618E002001*)SZArrayNew(AndroidJavaObjectU5BU5D_tBCEB142050F282B940177011644246618E002001_il2cpp_TypeInfo_var, (uint32_t)L_87);
		V_20 = L_88;
		V_21 = 0;
		goto IL_022c;
	}

IL_0206:
	{
		intptr_t L_89 = ___array0;
		int32_t L_90 = V_21;
		intptr_t L_91;
		L_91 = AndroidJNI_GetObjectArrayElement_mDD7F2DC202FA14B8E5889755FB02B401C1127AD0(L_89, L_90, NULL);
		V_22 = L_91;
		AndroidJavaObjectU5BU5D_tBCEB142050F282B940177011644246618E002001* L_92 = V_20;
		int32_t L_93 = V_21;
		intptr_t L_94 = V_22;
		AndroidJavaObject_t8FFB930F335C1178405B82AC2BF512BB1EEF9EB0* L_95 = (AndroidJavaObject_t8FFB930F335C1178405B82AC2BF512BB1EEF9EB0*)il2cpp_codegen_object_new(AndroidJavaObject_t8FFB930F335C1178405B82AC2BF512BB1EEF9EB0_il2cpp_TypeInfo_var);
		AndroidJavaObject__ctor_m0CEE7D570807333CE2C193A82AB3AB8D4F873A6B(L_95, L_94, /*hidden argument*/NULL);
		NullCheck(L_92);
		ArrayElementTypeCheck (L_92, L_95);
		(L_92)->SetAt(static_cast<il2cpp_array_size_t>(L_93), (AndroidJavaObject_t8FFB930F335C1178405B82AC2BF512BB1EEF9EB0*)L_95);
		intptr_t L_96 = V_22;
		AndroidJNISafe_DeleteLocalRef_m80503AA6C85CE46E8CE72C62215E1BE62964424D(L_96, NULL);
		int32_t L_97 = V_21;
		V_21 = ((int32_t)il2cpp_codegen_add(L_97, 1));
	}

IL_022c:
	{
		int32_t L_98 = V_21;
		int32_t L_99 = V_19;
		V_23 = (bool)((((int32_t)L_98) < ((int32_t)L_99))? 1 : 0);
		bool L_100 = V_23;
		if (L_100)
		{
			goto IL_0206;
		}
	}
	{
		AndroidJavaObjectU5BU5D_tBCEB142050F282B940177011644246618E002001* L_101 = V_20;
		V_3 = ((*(int8_t*)((int8_t*)(int8_t*)UnBox((RuntimeObject*)L_101, il2cpp_rgctx_data(method->rgctx_data, 1)))));
		goto IL_0272;
	}

IL_0242:
	{
		Type_t* L_102 = V_0;
		Type_t* L_103 = L_102;
		G_B31_0 = L_103;
		G_B31_1 = ((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteral51253131B895C2F8066BCC47E62D44F18F43446C));
		if (L_103)
		{
			G_B32_0 = L_103;
			G_B32_1 = ((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteral51253131B895C2F8066BCC47E62D44F18F43446C));
			goto IL_0250;
		}
	}
	{
		G_B33_0 = ((String_t*)(NULL));
		G_B33_1 = G_B31_1;
		goto IL_0255;
	}

IL_0250:
	{
		NullCheck((RuntimeObject*)G_B32_0);
		String_t* L_104;
		L_104 = VirtualFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, (RuntimeObject*)G_B32_0);
		G_B33_0 = L_104;
		G_B33_1 = G_B32_1;
	}

IL_0255:
	{
		String_t* L_105;
		L_105 = String_Concat_m9B13B47FCB3DF61144D9647DDA05F527377251B0(G_B33_1, G_B33_0, ((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteral42646B33B50B6AA15E22733C8900716F0FE19E1D)), NULL);
		Exception_t* L_106 = (Exception_t*)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&Exception_t_il2cpp_TypeInfo_var)));
		Exception__ctor_m9B2BD92CD68916245A75109105D9071C9D430E7F(L_106, L_105, /*hidden argument*/NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_106, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_AndroidJNIHelper_ConvertFromJNIArray_TisSByte_tFEFFEF5D2FEBF5207950AE6FAC150FC53B668DB5_mA0B7EDEC4FB783CA5C528BD35AC09FE99A737138_RuntimeMethod_var)));
	}

IL_0265:
	{
		il2cpp_codegen_initobj((&V_24), sizeof(int8_t));
		int8_t L_107 = V_24;
		V_3 = L_107;
		goto IL_0272;
	}

IL_0272:
	{
		int8_t L_108 = V_3;
		return L_108;
	}
}
// ArrayType UnityEngine._AndroidJNIHelper::ConvertFromJNIArray<System.Single>(System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float _AndroidJNIHelper_ConvertFromJNIArray_TisSingle_t4530F2FF86FCB0DC29F35385CA1BD21BE294761C_m570EA7BE13782F59FC9603040D1937DC0577BADB_gshared (intptr_t ___array0, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AndroidJavaObjectU5BU5D_tBCEB142050F282B940177011644246618E002001_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AndroidJavaObject_t8FFB930F335C1178405B82AC2BF512BB1EEF9EB0_0_0_0_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AndroidJavaObject_t8FFB930F335C1178405B82AC2BF512BB1EEF9EB0_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AndroidReflection_tD59014B286F902906DBB75DA3473897D35684908_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Boolean_t09A6377A54BE2F9E6985A8149F19234FD7DDFE22_0_0_0_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Byte_t94D9231AC217BE4D2E004C4CD32DF6D099EA41A3_0_0_0_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Char_t521A6F19B456D956AF452D926C32709DC03D6B17_0_0_0_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Debug_t8394C7EEAECA3689C2C9B9DE9C7166D73596276F_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Double_tE150EF3D1D43DEE85D533810AB4C742307EEDE5F_0_0_0_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Int16_tB8EF286A9C33492FA6E6D6E67320BE93E794A175_0_0_0_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Int32_t680FF22E76F6EFAD4375103CBBFFA0421349384C_0_0_0_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Int64_t092CFB123BE63C28ACDAF65C68F21A526050DBA3_0_0_0_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&SByte_tFEFFEF5D2FEBF5207950AE6FAC150FC53B668DB5_0_0_0_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Single_t4530F2FF86FCB0DC29F35385CA1BD21BE294761C_0_0_0_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&String_t_0_0_0_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Type_t_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral24CC8D396132365E532646F936DFC8579E2299B2);
		s_Il2CppMethodInitialized = true;
	}
Type_t* V_0 = NULL;
	bool V_1 = false;
	bool V_2 = false;
	float V_3 = 0.0f;
	bool V_4 = false;
	bool V_5 = false;
	bool V_6 = false;
	bool V_7 = false;
	bool V_8 = false;
	bool V_9 = false;
	bool V_10 = false;
	bool V_11 = false;
	bool V_12 = false;
	int32_t V_13 = 0;
	StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248* V_14 = NULL;
	int32_t V_15 = 0;
	intptr_t V_16;
	memset((&V_16), 0, sizeof(V_16));
	bool V_17 = false;
	bool V_18 = false;
	int32_t V_19 = 0;
	AndroidJavaObjectU5BU5D_tBCEB142050F282B940177011644246618E002001* V_20 = NULL;
	int32_t V_21 = 0;
	intptr_t V_22;
	memset((&V_22), 0, sizeof(V_22));
	bool V_23 = false;
	float V_24 = 0.0f;
	Type_t* G_B32_0 = NULL;
	String_t* G_B32_1 = NULL;
	Type_t* G_B31_0 = NULL;
	String_t* G_B31_1 = NULL;
	String_t* G_B33_0 = NULL;
	String_t* G_B33_1 = NULL;
	{
		RuntimeTypeHandle_t332A452B8B6179E4469B69525D0FE82A88030F7B L_0 = { reinterpret_cast<intptr_t> (il2cpp_rgctx_type(method->rgctx_data, 0)) };
		il2cpp_codegen_runtime_class_init_inline(Type_t_il2cpp_TypeInfo_var);
		Type_t* L_1;
		L_1 = Type_GetTypeFromHandle_m2570A2A5B32A5E9D9F0F38B37459DA18736C823E(L_0, NULL);
		NullCheck(L_1);
		Type_t* L_2;
		L_2 = VirtualFuncInvoker0< Type_t* >::Invoke(46 /* System.Type System.Type::GetElementType() */, L_1);
		V_0 = L_2;
		Type_t* L_3 = V_0;
		il2cpp_codegen_runtime_class_init_inline(AndroidReflection_tD59014B286F902906DBB75DA3473897D35684908_il2cpp_TypeInfo_var);
		bool L_4;
		L_4 = AndroidReflection_IsPrimitive_m48ED73958206D552B937EEC7560184C6C4228F3D(L_3, NULL);
		V_1 = L_4;
		bool L_5 = V_1;
		if (!L_5)
		{
			goto IL_0173;
		}
	}
	{
		Type_t* L_6 = V_0;
		RuntimeTypeHandle_t332A452B8B6179E4469B69525D0FE82A88030F7B L_7 = { reinterpret_cast<intptr_t> (Int32_t680FF22E76F6EFAD4375103CBBFFA0421349384C_0_0_0_var) };
		il2cpp_codegen_runtime_class_init_inline(Type_t_il2cpp_TypeInfo_var);
		Type_t* L_8;
		L_8 = Type_GetTypeFromHandle_m2570A2A5B32A5E9D9F0F38B37459DA18736C823E(L_7, NULL);
		V_2 = (bool)((((RuntimeObject*)(Type_t*)L_6) == ((RuntimeObject*)(Type_t*)L_8))? 1 : 0);
		bool L_9 = V_2;
		if (!L_9)
		{
			goto IL_0041;
		}
	}
	{
		intptr_t L_10 = ___array0;
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_11;
		L_11 = AndroidJNISafe_FromIntArray_m899EDC375E4983DCF33B5B72E2131DC06AA4B5F0(L_10, NULL);
		V_3 = ((*(float*)((float*)(float*)UnBox((RuntimeObject*)L_11, il2cpp_rgctx_data(method->rgctx_data, 1)))));
		goto IL_0272;
	}

IL_0041:
	{
		Type_t* L_12 = V_0;
		RuntimeTypeHandle_t332A452B8B6179E4469B69525D0FE82A88030F7B L_13 = { reinterpret_cast<intptr_t> (Boolean_t09A6377A54BE2F9E6985A8149F19234FD7DDFE22_0_0_0_var) };
		il2cpp_codegen_runtime_class_init_inline(Type_t_il2cpp_TypeInfo_var);
		Type_t* L_14;
		L_14 = Type_GetTypeFromHandle_m2570A2A5B32A5E9D9F0F38B37459DA18736C823E(L_13, NULL);
		V_4 = (bool)((((RuntimeObject*)(Type_t*)L_12) == ((RuntimeObject*)(Type_t*)L_14))? 1 : 0);
		bool L_15 = V_4;
		if (!L_15)
		{
			goto IL_0065;
		}
	}
	{
		intptr_t L_16 = ___array0;
		BooleanU5BU5D_tD317D27C31DB892BE79FAE3AEBC0B3FFB73DE9B4* L_17;
		L_17 = AndroidJNISafe_FromBooleanArray_m3F57F10FDDBA3DC358BEF7296F58D819C9EC3BDE(L_16, NULL);
		V_3 = ((*(float*)((float*)(float*)UnBox((RuntimeObject*)L_17, il2cpp_rgctx_data(method->rgctx_data, 1)))));
		goto IL_0272;
	}

IL_0065:
	{
		Type_t* L_18 = V_0;
		RuntimeTypeHandle_t332A452B8B6179E4469B69525D0FE82A88030F7B L_19 = { reinterpret_cast<intptr_t> (Byte_t94D9231AC217BE4D2E004C4CD32DF6D099EA41A3_0_0_0_var) };
		il2cpp_codegen_runtime_class_init_inline(Type_t_il2cpp_TypeInfo_var);
		Type_t* L_20;
		L_20 = Type_GetTypeFromHandle_m2570A2A5B32A5E9D9F0F38B37459DA18736C823E(L_19, NULL);
		V_5 = (bool)((((RuntimeObject*)(Type_t*)L_18) == ((RuntimeObject*)(Type_t*)L_20))? 1 : 0);
		bool L_21 = V_5;
		if (!L_21)
		{
			goto IL_0095;
		}
	}
	{
		il2cpp_codegen_runtime_class_init_inline(Debug_t8394C7EEAECA3689C2C9B9DE9C7166D73596276F_il2cpp_TypeInfo_var);
		Debug_LogWarning_mEF15C6B17CE4E1FA7E379CDB82CE40FCD89A3F28((RuntimeObject*)_stringLiteral24CC8D396132365E532646F936DFC8579E2299B2, NULL);
		intptr_t L_22 = ___array0;
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_23;
		L_23 = AndroidJNISafe_FromByteArray_mAED5B8EEF34E268BB146A277842089C7FD8A06BB(L_22, NULL);
		V_3 = ((*(float*)((float*)(float*)UnBox((RuntimeObject*)L_23, il2cpp_rgctx_data(method->rgctx_data, 1)))));
		goto IL_0272;
	}

IL_0095:
	{
		Type_t* L_24 = V_0;
		RuntimeTypeHandle_t332A452B8B6179E4469B69525D0FE82A88030F7B L_25 = { reinterpret_cast<intptr_t> (SByte_tFEFFEF5D2FEBF5207950AE6FAC150FC53B668DB5_0_0_0_var) };
		il2cpp_codegen_runtime_class_init_inline(Type_t_il2cpp_TypeInfo_var);
		Type_t* L_26;
		L_26 = Type_GetTypeFromHandle_m2570A2A5B32A5E9D9F0F38B37459DA18736C823E(L_25, NULL);
		V_6 = (bool)((((RuntimeObject*)(Type_t*)L_24) == ((RuntimeObject*)(Type_t*)L_26))? 1 : 0);
		bool L_27 = V_6;
		if (!L_27)
		{
			goto IL_00b9;
		}
	}
	{
		intptr_t L_28 = ___array0;
		SByteU5BU5D_t88116DA68378C3333DB73E7D36C1A06AFAA91913* L_29;
		L_29 = AndroidJNISafe_FromSByteArray_m5825C71BA6941CDF25627AD77CDBE648CB322476(L_28, NULL);
		V_3 = ((*(float*)((float*)(float*)UnBox((RuntimeObject*)L_29, il2cpp_rgctx_data(method->rgctx_data, 1)))));
		goto IL_0272;
	}

IL_00b9:
	{
		Type_t* L_30 = V_0;
		RuntimeTypeHandle_t332A452B8B6179E4469B69525D0FE82A88030F7B L_31 = { reinterpret_cast<intptr_t> (Int16_tB8EF286A9C33492FA6E6D6E67320BE93E794A175_0_0_0_var) };
		il2cpp_codegen_runtime_class_init_inline(Type_t_il2cpp_TypeInfo_var);
		Type_t* L_32;
		L_32 = Type_GetTypeFromHandle_m2570A2A5B32A5E9D9F0F38B37459DA18736C823E(L_31, NULL);
		V_7 = (bool)((((RuntimeObject*)(Type_t*)L_30) == ((RuntimeObject*)(Type_t*)L_32))? 1 : 0);
		bool L_33 = V_7;
		if (!L_33)
		{
			goto IL_00dd;
		}
	}
	{
		intptr_t L_34 = ___array0;
		Int16U5BU5D_t8175CE8DD9C9F9FB0CF4F58E45BC570575B43CFB* L_35;
		L_35 = AndroidJNISafe_FromShortArray_m227116D8E01EE3568936FB93C97CAEE9062A0A35(L_34, NULL);
		V_3 = ((*(float*)((float*)(float*)UnBox((RuntimeObject*)L_35, il2cpp_rgctx_data(method->rgctx_data, 1)))));
		goto IL_0272;
	}

IL_00dd:
	{
		Type_t* L_36 = V_0;
		RuntimeTypeHandle_t332A452B8B6179E4469B69525D0FE82A88030F7B L_37 = { reinterpret_cast<intptr_t> (Int64_t092CFB123BE63C28ACDAF65C68F21A526050DBA3_0_0_0_var) };
		il2cpp_codegen_runtime_class_init_inline(Type_t_il2cpp_TypeInfo_var);
		Type_t* L_38;
		L_38 = Type_GetTypeFromHandle_m2570A2A5B32A5E9D9F0F38B37459DA18736C823E(L_37, NULL);
		V_8 = (bool)((((RuntimeObject*)(Type_t*)L_36) == ((RuntimeObject*)(Type_t*)L_38))? 1 : 0);
		bool L_39 = V_8;
		if (!L_39)
		{
			goto IL_0101;
		}
	}
	{
		intptr_t L_40 = ___array0;
		Int64U5BU5D_tAEDFCBDB5414E2A140A6F34C0538BF97FCF67A1D* L_41;
		L_41 = AndroidJNISafe_FromLongArray_m687FC548BFA4DC440379619E5C7CB56354E30D59(L_40, NULL);
		V_3 = ((*(float*)((float*)(float*)UnBox((RuntimeObject*)L_41, il2cpp_rgctx_data(method->rgctx_data, 1)))));
		goto IL_0272;
	}

IL_0101:
	{
		Type_t* L_42 = V_0;
		RuntimeTypeHandle_t332A452B8B6179E4469B69525D0FE82A88030F7B L_43 = { reinterpret_cast<intptr_t> (Single_t4530F2FF86FCB0DC29F35385CA1BD21BE294761C_0_0_0_var) };
		il2cpp_codegen_runtime_class_init_inline(Type_t_il2cpp_TypeInfo_var);
		Type_t* L_44;
		L_44 = Type_GetTypeFromHandle_m2570A2A5B32A5E9D9F0F38B37459DA18736C823E(L_43, NULL);
		V_9 = (bool)((((RuntimeObject*)(Type_t*)L_42) == ((RuntimeObject*)(Type_t*)L_44))? 1 : 0);
		bool L_45 = V_9;
		if (!L_45)
		{
			goto IL_0125;
		}
	}
	{
		intptr_t L_46 = ___array0;
		SingleU5BU5D_t89DEFE97BCEDB5857010E79ECE0F52CF6E93B87C* L_47;
		L_47 = AndroidJNISafe_FromFloatArray_m97B7BC8546EC3F9CF0784D434D4AA41FBB409892(L_46, NULL);
		V_3 = ((*(float*)((float*)(float*)UnBox((RuntimeObject*)L_47, il2cpp_rgctx_data(method->rgctx_data, 1)))));
		goto IL_0272;
	}

IL_0125:
	{
		Type_t* L_48 = V_0;
		RuntimeTypeHandle_t332A452B8B6179E4469B69525D0FE82A88030F7B L_49 = { reinterpret_cast<intptr_t> (Double_tE150EF3D1D43DEE85D533810AB4C742307EEDE5F_0_0_0_var) };
		il2cpp_codegen_runtime_class_init_inline(Type_t_il2cpp_TypeInfo_var);
		Type_t* L_50;
		L_50 = Type_GetTypeFromHandle_m2570A2A5B32A5E9D9F0F38B37459DA18736C823E(L_49, NULL);
		V_10 = (bool)((((RuntimeObject*)(Type_t*)L_48) == ((RuntimeObject*)(Type_t*)L_50))? 1 : 0);
		bool L_51 = V_10;
		if (!L_51)
		{
			goto IL_0149;
		}
	}
	{
		intptr_t L_52 = ___array0;
		DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE* L_53;
		L_53 = AndroidJNISafe_FromDoubleArray_mB752FB522CD25191E5C6AF8CEFA4553593F784A7(L_52, NULL);
		V_3 = ((*(float*)((float*)(float*)UnBox((RuntimeObject*)L_53, il2cpp_rgctx_data(method->rgctx_data, 1)))));
		goto IL_0272;
	}

IL_0149:
	{
		Type_t* L_54 = V_0;
		RuntimeTypeHandle_t332A452B8B6179E4469B69525D0FE82A88030F7B L_55 = { reinterpret_cast<intptr_t> (Char_t521A6F19B456D956AF452D926C32709DC03D6B17_0_0_0_var) };
		il2cpp_codegen_runtime_class_init_inline(Type_t_il2cpp_TypeInfo_var);
		Type_t* L_56;
		L_56 = Type_GetTypeFromHandle_m2570A2A5B32A5E9D9F0F38B37459DA18736C823E(L_55, NULL);
		V_11 = (bool)((((RuntimeObject*)(Type_t*)L_54) == ((RuntimeObject*)(Type_t*)L_56))? 1 : 0);
		bool L_57 = V_11;
		if (!L_57)
		{
			goto IL_016d;
		}
	}
	{
		intptr_t L_58 = ___array0;
		CharU5BU5D_t799905CF001DD5F13F7DBB310181FC4D8B7D0AAB* L_59;
		L_59 = AndroidJNISafe_FromCharArray_mC1C728B67330FD610542B4C2D6B9759F78B2BD17(L_58, NULL);
		V_3 = ((*(float*)((float*)(float*)UnBox((RuntimeObject*)L_59, il2cpp_rgctx_data(method->rgctx_data, 1)))));
		goto IL_0272;
	}

IL_016d:
	{
		goto IL_0265;
	}

IL_0173:
	{
		Type_t* L_60 = V_0;
		RuntimeTypeHandle_t332A452B8B6179E4469B69525D0FE82A88030F7B L_61 = { reinterpret_cast<intptr_t> (String_t_0_0_0_var) };
		il2cpp_codegen_runtime_class_init_inline(Type_t_il2cpp_TypeInfo_var);
		Type_t* L_62;
		L_62 = Type_GetTypeFromHandle_m2570A2A5B32A5E9D9F0F38B37459DA18736C823E(L_61, NULL);
		V_12 = (bool)((((RuntimeObject*)(Type_t*)L_60) == ((RuntimeObject*)(Type_t*)L_62))? 1 : 0);
		bool L_63 = V_12;
		if (!L_63)
		{
			goto IL_01dc;
		}
	}
	{
		intptr_t L_64 = ___array0;
		int32_t L_65;
		L_65 = AndroidJNISafe_GetArrayLength_mB5F7260E652BE95FE9237A47C1E1597306B462C3(L_64, NULL);
		V_13 = L_65;
		int32_t L_66 = V_13;
		StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248* L_67 = (StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248*)(StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248*)SZArrayNew(StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248_il2cpp_TypeInfo_var, (uint32_t)L_66);
		V_14 = L_67;
		V_15 = 0;
		goto IL_01c3;
	}

IL_019d:
	{
		intptr_t L_68 = ___array0;
		int32_t L_69 = V_15;
		intptr_t L_70;
		L_70 = AndroidJNI_GetObjectArrayElement_mDD7F2DC202FA14B8E5889755FB02B401C1127AD0(L_68, L_69, NULL);
		V_16 = L_70;
		StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248* L_71 = V_14;
		int32_t L_72 = V_15;
		intptr_t L_73 = V_16;
		String_t* L_74;
		L_74 = AndroidJNISafe_GetStringChars_m21A07825755C0A9AF91F8248A1C98F861E26928F(L_73, NULL);
		NullCheck(L_71);
		ArrayElementTypeCheck (L_71, L_74);
		(L_71)->SetAt(static_cast<il2cpp_array_size_t>(L_72), (String_t*)L_74);
		intptr_t L_75 = V_16;
		AndroidJNISafe_DeleteLocalRef_m80503AA6C85CE46E8CE72C62215E1BE62964424D(L_75, NULL);
		int32_t L_76 = V_15;
		V_15 = ((int32_t)il2cpp_codegen_add(L_76, 1));
	}

IL_01c3:
	{
		int32_t L_77 = V_15;
		int32_t L_78 = V_13;
		V_17 = (bool)((((int32_t)L_77) < ((int32_t)L_78))? 1 : 0);
		bool L_79 = V_17;
		if (L_79)
		{
			goto IL_019d;
		}
	}
	{
		StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248* L_80 = V_14;
		V_3 = ((*(float*)((float*)(float*)UnBox((RuntimeObject*)L_80, il2cpp_rgctx_data(method->rgctx_data, 1)))));
		goto IL_0272;
	}

IL_01dc:
	{
		Type_t* L_81 = V_0;
		RuntimeTypeHandle_t332A452B8B6179E4469B69525D0FE82A88030F7B L_82 = { reinterpret_cast<intptr_t> (AndroidJavaObject_t8FFB930F335C1178405B82AC2BF512BB1EEF9EB0_0_0_0_var) };
		il2cpp_codegen_runtime_class_init_inline(Type_t_il2cpp_TypeInfo_var);
		Type_t* L_83;
		L_83 = Type_GetTypeFromHandle_m2570A2A5B32A5E9D9F0F38B37459DA18736C823E(L_82, NULL);
		V_18 = (bool)((((RuntimeObject*)(Type_t*)L_81) == ((RuntimeObject*)(Type_t*)L_83))? 1 : 0);
		bool L_84 = V_18;
		if (!L_84)
		{
			goto IL_0242;
		}
	}
	{
		intptr_t L_85 = ___array0;
		int32_t L_86;
		L_86 = AndroidJNISafe_GetArrayLength_mB5F7260E652BE95FE9237A47C1E1597306B462C3(L_85, NULL);
		V_19 = L_86;
		int32_t L_87 = V_19;
		AndroidJavaObjectU5BU5D_tBCEB142050F282B940177011644246618E002001* L_88 = (AndroidJavaObjectU5BU5D_tBCEB142050F282B940177011644246618E002001*)(AndroidJavaObjectU5BU5D_tBCEB142050F282B940177011644246618E002001*)SZArrayNew(AndroidJavaObjectU5BU5D_tBCEB142050F282B940177011644246618E002001_il2cpp_TypeInfo_var, (uint32_t)L_87);
		V_20 = L_88;
		V_21 = 0;
		goto IL_022c;
	}

IL_0206:
	{
		intptr_t L_89 = ___array0;
		int32_t L_90 = V_21;
		intptr_t L_91;
		L_91 = AndroidJNI_GetObjectArrayElement_mDD7F2DC202FA14B8E5889755FB02B401C1127AD0(L_89, L_90, NULL);
		V_22 = L_91;
		AndroidJavaObjectU5BU5D_tBCEB142050F282B940177011644246618E002001* L_92 = V_20;
		int32_t L_93 = V_21;
		intptr_t L_94 = V_22;
		AndroidJavaObject_t8FFB930F335C1178405B82AC2BF512BB1EEF9EB0* L_95 = (AndroidJavaObject_t8FFB930F335C1178405B82AC2BF512BB1EEF9EB0*)il2cpp_codegen_object_new(AndroidJavaObject_t8FFB930F335C1178405B82AC2BF512BB1EEF9EB0_il2cpp_TypeInfo_var);
		AndroidJavaObject__ctor_m0CEE7D570807333CE2C193A82AB3AB8D4F873A6B(L_95, L_94, /*hidden argument*/NULL);
		NullCheck(L_92);
		ArrayElementTypeCheck (L_92, L_95);
		(L_92)->SetAt(static_cast<il2cpp_array_size_t>(L_93), (AndroidJavaObject_t8FFB930F335C1178405B82AC2BF512BB1EEF9EB0*)L_95);
		intptr_t L_96 = V_22;
		AndroidJNISafe_DeleteLocalRef_m80503AA6C85CE46E8CE72C62215E1BE62964424D(L_96, NULL);
		int32_t L_97 = V_21;
		V_21 = ((int32_t)il2cpp_codegen_add(L_97, 1));
	}

IL_022c:
	{
		int32_t L_98 = V_21;
		int32_t L_99 = V_19;
		V_23 = (bool)((((int32_t)L_98) < ((int32_t)L_99))? 1 : 0);
		bool L_100 = V_23;
		if (L_100)
		{
			goto IL_0206;
		}
	}
	{
		AndroidJavaObjectU5BU5D_tBCEB142050F282B940177011644246618E002001* L_101 = V_20;
		V_3 = ((*(float*)((float*)(float*)UnBox((RuntimeObject*)L_101, il2cpp_rgctx_data(method->rgctx_data, 1)))));
		goto IL_0272;
	}

IL_0242:
	{
		Type_t* L_102 = V_0;
		Type_t* L_103 = L_102;
		G_B31_0 = L_103;
		G_B31_1 = ((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteral51253131B895C2F8066BCC47E62D44F18F43446C));
		if (L_103)
		{
			G_B32_0 = L_103;
			G_B32_1 = ((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteral51253131B895C2F8066BCC47E62D44F18F43446C));
			goto IL_0250;
		}
	}
	{
		G_B33_0 = ((String_t*)(NULL));
		G_B33_1 = G_B31_1;
		goto IL_0255;
	}

IL_0250:
	{
		NullCheck((RuntimeObject*)G_B32_0);
		String_t* L_104;
		L_104 = VirtualFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, (RuntimeObject*)G_B32_0);
		G_B33_0 = L_104;
		G_B33_1 = G_B32_1;
	}

IL_0255:
	{
		String_t* L_105;
		L_105 = String_Concat_m9B13B47FCB3DF61144D9647DDA05F527377251B0(G_B33_1, G_B33_0, ((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteral42646B33B50B6AA15E22733C8900716F0FE19E1D)), NULL);
		Exception_t* L_106 = (Exception_t*)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&Exception_t_il2cpp_TypeInfo_var)));
		Exception__ctor_m9B2BD92CD68916245A75109105D9071C9D430E7F(L_106, L_105, /*hidden argument*/NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_106, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_AndroidJNIHelper_ConvertFromJNIArray_TisSingle_t4530F2FF86FCB0DC29F35385CA1BD21BE294761C_m570EA7BE13782F59FC9603040D1937DC0577BADB_RuntimeMethod_var)));
	}

IL_0265:
	{
		il2cpp_codegen_initobj((&V_24), sizeof(float));
		float L_107 = V_24;
		V_3 = L_107;
		goto IL_0272;
	}

IL_0272:
	{
		float L_108 = V_3;
		return L_108;
	}
}
// System.IntPtr UnityEngine._AndroidJNIHelper::GetFieldID<System.Object>(System.IntPtr,System.String,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR intptr_t _AndroidJNIHelper_GetFieldID_TisRuntimeObject_mE82633A88CD2EA1C974716F0E9D7DD1ED0E05B64_gshared (intptr_t ___jclass0, String_t* ___fieldName1, bool ___isStatic2, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Type_t_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
intptr_t V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		intptr_t L_0 = ___jclass0;
		String_t* L_1 = ___fieldName1;
		RuntimeTypeHandle_t332A452B8B6179E4469B69525D0FE82A88030F7B L_2 = { reinterpret_cast<intptr_t> (il2cpp_rgctx_type(method->rgctx_data, 0)) };
		il2cpp_codegen_runtime_class_init_inline(Type_t_il2cpp_TypeInfo_var);
		Type_t* L_3;
		L_3 = Type_GetTypeFromHandle_m2570A2A5B32A5E9D9F0F38B37459DA18736C823E(L_2, NULL);
		String_t* L_4;
		L_4 = _AndroidJNIHelper_GetSignature_m1F94418EAEB87AF74E495191DC2AA5293136175B((RuntimeObject*)L_3, NULL);
		bool L_5 = ___isStatic2;
		intptr_t L_6;
		L_6 = AndroidJNIHelper_GetFieldID_mC795891C3B70C0E8F98D9E8AD2A85103761A0C75(L_0, L_1, L_4, L_5, NULL);
		V_0 = L_6;
		goto IL_001b;
	}

IL_001b:
	{
		intptr_t L_7 = V_0;
		return L_7;
	}
}
// System.IntPtr UnityEngine._AndroidJNIHelper::GetMethodID<System.Boolean>(System.IntPtr,System.String,System.Object[],System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR intptr_t _AndroidJNIHelper_GetMethodID_TisBoolean_t09A6377A54BE2F9E6985A8149F19234FD7DDFE22_mC1F60B2CD35EBE3AF6EB1A0CBE8720BDBB0FD46F_gshared (intptr_t ___jclass0, String_t* ___methodName1, ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* ___args2, bool ___isStatic3, const RuntimeMethod* method) 
{
intptr_t V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		intptr_t L_0 = ___jclass0;
		String_t* L_1 = ___methodName1;
		ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* L_2 = ___args2;
		String_t* L_3;
		L_3 = ((  String_t* (*) (ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918*, const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->rgctx_data, 0)))(L_2, il2cpp_rgctx_method(method->rgctx_data, 0));
		bool L_4 = ___isStatic3;
		intptr_t L_5;
		L_5 = AndroidJNIHelper_GetMethodID_m5F33E127418D5DA40590E4AE3814D7ACF7810F6E(L_0, L_1, L_3, L_4, NULL);
		V_0 = L_5;
		goto IL_0012;
	}

IL_0012:
	{
		intptr_t L_6 = V_0;
		return L_6;
	}
}
// System.IntPtr UnityEngine._AndroidJNIHelper::GetMethodID<System.Char>(System.IntPtr,System.String,System.Object[],System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR intptr_t _AndroidJNIHelper_GetMethodID_TisChar_t521A6F19B456D956AF452D926C32709DC03D6B17_m009869836C4E4FF7DBA29495581E621CAFB3EC28_gshared (intptr_t ___jclass0, String_t* ___methodName1, ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* ___args2, bool ___isStatic3, const RuntimeMethod* method) 
{
intptr_t V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		intptr_t L_0 = ___jclass0;
		String_t* L_1 = ___methodName1;
		ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* L_2 = ___args2;
		String_t* L_3;
		L_3 = ((  String_t* (*) (ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918*, const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->rgctx_data, 0)))(L_2, il2cpp_rgctx_method(method->rgctx_data, 0));
		bool L_4 = ___isStatic3;
		intptr_t L_5;
		L_5 = AndroidJNIHelper_GetMethodID_m5F33E127418D5DA40590E4AE3814D7ACF7810F6E(L_0, L_1, L_3, L_4, NULL);
		V_0 = L_5;
		goto IL_0012;
	}

IL_0012:
	{
		intptr_t L_6 = V_0;
		return L_6;
	}
}
// System.IntPtr UnityEngine._AndroidJNIHelper::GetMethodID<System.Double>(System.IntPtr,System.String,System.Object[],System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR intptr_t _AndroidJNIHelper_GetMethodID_TisDouble_tE150EF3D1D43DEE85D533810AB4C742307EEDE5F_m12163ADC3C81694EE6164EB1CE4CF319BF912FC0_gshared (intptr_t ___jclass0, String_t* ___methodName1, ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* ___args2, bool ___isStatic3, const RuntimeMethod* method) 
{
intptr_t V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		intptr_t L_0 = ___jclass0;
		String_t* L_1 = ___methodName1;
		ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* L_2 = ___args2;
		String_t* L_3;
		L_3 = ((  String_t* (*) (ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918*, const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->rgctx_data, 0)))(L_2, il2cpp_rgctx_method(method->rgctx_data, 0));
		bool L_4 = ___isStatic3;
		intptr_t L_5;
		L_5 = AndroidJNIHelper_GetMethodID_m5F33E127418D5DA40590E4AE3814D7ACF7810F6E(L_0, L_1, L_3, L_4, NULL);
		V_0 = L_5;
		goto IL_0012;
	}

IL_0012:
	{
		intptr_t L_6 = V_0;
		return L_6;
	}
}
// System.IntPtr UnityEngine._AndroidJNIHelper::GetMethodID<System.Int16>(System.IntPtr,System.String,System.Object[],System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR intptr_t _AndroidJNIHelper_GetMethodID_TisInt16_tB8EF286A9C33492FA6E6D6E67320BE93E794A175_m0F150B2F03CF09DC548030312EC870B49FD42856_gshared (intptr_t ___jclass0, String_t* ___methodName1, ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* ___args2, bool ___isStatic3, const RuntimeMethod* method) 
{
intptr_t V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		intptr_t L_0 = ___jclass0;
		String_t* L_1 = ___methodName1;
		ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* L_2 = ___args2;
		String_t* L_3;
		L_3 = ((  String_t* (*) (ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918*, const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->rgctx_data, 0)))(L_2, il2cpp_rgctx_method(method->rgctx_data, 0));
		bool L_4 = ___isStatic3;
		intptr_t L_5;
		L_5 = AndroidJNIHelper_GetMethodID_m5F33E127418D5DA40590E4AE3814D7ACF7810F6E(L_0, L_1, L_3, L_4, NULL);
		V_0 = L_5;
		goto IL_0012;
	}

IL_0012:
	{
		intptr_t L_6 = V_0;
		return L_6;
	}
}
// System.IntPtr UnityEngine._AndroidJNIHelper::GetMethodID<System.Int32>(System.IntPtr,System.String,System.Object[],System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR intptr_t _AndroidJNIHelper_GetMethodID_TisInt32_t680FF22E76F6EFAD4375103CBBFFA0421349384C_m8912F671519185E49C39BB5AC46FE2EC5940B11F_gshared (intptr_t ___jclass0, String_t* ___methodName1, ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* ___args2, bool ___isStatic3, const RuntimeMethod* method) 
{
intptr_t V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		intptr_t L_0 = ___jclass0;
		String_t* L_1 = ___methodName1;
		ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* L_2 = ___args2;
		String_t* L_3;
		L_3 = ((  String_t* (*) (ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918*, const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->rgctx_data, 0)))(L_2, il2cpp_rgctx_method(method->rgctx_data, 0));
		bool L_4 = ___isStatic3;
		intptr_t L_5;
		L_5 = AndroidJNIHelper_GetMethodID_m5F33E127418D5DA40590E4AE3814D7ACF7810F6E(L_0, L_1, L_3, L_4, NULL);
		V_0 = L_5;
		goto IL_0012;
	}

IL_0012:
	{
		intptr_t L_6 = V_0;
		return L_6;
	}
}
// System.IntPtr UnityEngine._AndroidJNIHelper::GetMethodID<System.Int64>(System.IntPtr,System.String,System.Object[],System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR intptr_t _AndroidJNIHelper_GetMethodID_TisInt64_t092CFB123BE63C28ACDAF65C68F21A526050DBA3_mE520BC825E42E6148130E64994ECB5BDEAEE8AE6_gshared (intptr_t ___jclass0, String_t* ___methodName1, ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* ___args2, bool ___isStatic3, const RuntimeMethod* method) 
{
intptr_t V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		intptr_t L_0 = ___jclass0;
		String_t* L_1 = ___methodName1;
		ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* L_2 = ___args2;
		String_t* L_3;
		L_3 = ((  String_t* (*) (ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918*, const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->rgctx_data, 0)))(L_2, il2cpp_rgctx_method(method->rgctx_data, 0));
		bool L_4 = ___isStatic3;
		intptr_t L_5;
		L_5 = AndroidJNIHelper_GetMethodID_m5F33E127418D5DA40590E4AE3814D7ACF7810F6E(L_0, L_1, L_3, L_4, NULL);
		V_0 = L_5;
		goto IL_0012;
	}

IL_0012:
	{
		intptr_t L_6 = V_0;
		return L_6;
	}
}
// System.IntPtr UnityEngine._AndroidJNIHelper::GetMethodID<System.Object>(System.IntPtr,System.String,System.Object[],System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR intptr_t _AndroidJNIHelper_GetMethodID_TisRuntimeObject_m6555020711F611E466B92953403F09E0014C5C0A_gshared (intptr_t ___jclass0, String_t* ___methodName1, ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* ___args2, bool ___isStatic3, const RuntimeMethod* method) 
{
intptr_t V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		intptr_t L_0 = ___jclass0;
		String_t* L_1 = ___methodName1;
		ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* L_2 = ___args2;
		String_t* L_3;
		L_3 = ((  String_t* (*) (ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918*, const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->rgctx_data, 0)))(L_2, il2cpp_rgctx_method(method->rgctx_data, 0));
		bool L_4 = ___isStatic3;
		intptr_t L_5;
		L_5 = AndroidJNIHelper_GetMethodID_m5F33E127418D5DA40590E4AE3814D7ACF7810F6E(L_0, L_1, L_3, L_4, NULL);
		V_0 = L_5;
		goto IL_0012;
	}

IL_0012:
	{
		intptr_t L_6 = V_0;
		return L_6;
	}
}
// System.IntPtr UnityEngine._AndroidJNIHelper::GetMethodID<System.SByte>(System.IntPtr,System.String,System.Object[],System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR intptr_t _AndroidJNIHelper_GetMethodID_TisSByte_tFEFFEF5D2FEBF5207950AE6FAC150FC53B668DB5_mAD96CCC9D368A9EF49DF86C4767402B588D1057A_gshared (intptr_t ___jclass0, String_t* ___methodName1, ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* ___args2, bool ___isStatic3, const RuntimeMethod* method) 
{
intptr_t V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		intptr_t L_0 = ___jclass0;
		String_t* L_1 = ___methodName1;
		ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* L_2 = ___args2;
		String_t* L_3;
		L_3 = ((  String_t* (*) (ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918*, const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->rgctx_data, 0)))(L_2, il2cpp_rgctx_method(method->rgctx_data, 0));
		bool L_4 = ___isStatic3;
		intptr_t L_5;
		L_5 = AndroidJNIHelper_GetMethodID_m5F33E127418D5DA40590E4AE3814D7ACF7810F6E(L_0, L_1, L_3, L_4, NULL);
		V_0 = L_5;
		goto IL_0012;
	}

IL_0012:
	{
		intptr_t L_6 = V_0;
		return L_6;
	}
}
// System.IntPtr UnityEngine._AndroidJNIHelper::GetMethodID<System.Single>(System.IntPtr,System.String,System.Object[],System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR intptr_t _AndroidJNIHelper_GetMethodID_TisSingle_t4530F2FF86FCB0DC29F35385CA1BD21BE294761C_m57664D04766C1E0F7096ECD49549E6A4291D0347_gshared (intptr_t ___jclass0, String_t* ___methodName1, ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* ___args2, bool ___isStatic3, const RuntimeMethod* method) 
{
intptr_t V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		intptr_t L_0 = ___jclass0;
		String_t* L_1 = ___methodName1;
		ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* L_2 = ___args2;
		String_t* L_3;
		L_3 = ((  String_t* (*) (ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918*, const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->rgctx_data, 0)))(L_2, il2cpp_rgctx_method(method->rgctx_data, 0));
		bool L_4 = ___isStatic3;
		intptr_t L_5;
		L_5 = AndroidJNIHelper_GetMethodID_m5F33E127418D5DA40590E4AE3814D7ACF7810F6E(L_0, L_1, L_3, L_4, NULL);
		V_0 = L_5;
		goto IL_0012;
	}

IL_0012:
	{
		intptr_t L_6 = V_0;
		return L_6;
	}
}
// System.String UnityEngine._AndroidJNIHelper::GetSignature<System.Boolean>(System.Object[])
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* _AndroidJNIHelper_GetSignature_TisBoolean_t09A6377A54BE2F9E6985A8149F19234FD7DDFE22_mF65B0E8242ED723FC5C233B6113C489F861D6C75_gshared (ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* ___args0, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&StringBuilder_t_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Type_t_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
StringBuilder_t* V_0 = NULL;
	ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* V_1 = NULL;
	int32_t V_2 = 0;
	RuntimeObject* V_3 = NULL;
	String_t* V_4 = NULL;
	{
		StringBuilder_t* L_0 = (StringBuilder_t*)il2cpp_codegen_object_new(StringBuilder_t_il2cpp_TypeInfo_var);
		StringBuilder__ctor_m1D99713357DE05DAFA296633639DB55F8C30587D(L_0, /*hidden argument*/NULL);
		V_0 = L_0;
		StringBuilder_t* L_1 = V_0;
		NullCheck(L_1);
		StringBuilder_t* L_2;
		L_2 = StringBuilder_Append_m71228B30F05724CD2CD96D9611DCD61BFB96A6E1(L_1, (Il2CppChar)((int32_t)40), NULL);
		ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* L_3 = ___args0;
		V_1 = L_3;
		V_2 = 0;
		goto IL_002e;
	}

IL_0017:
	{
		ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* L_4 = V_1;
		int32_t L_5 = V_2;
		NullCheck(L_4);
		int32_t L_6 = L_5;
		RuntimeObject* L_7 = (L_4)->GetAt(static_cast<il2cpp_array_size_t>(L_6));
		V_3 = L_7;
		StringBuilder_t* L_8 = V_0;
		RuntimeObject* L_9 = V_3;
		String_t* L_10;
		L_10 = _AndroidJNIHelper_GetSignature_m1F94418EAEB87AF74E495191DC2AA5293136175B(L_9, NULL);
		NullCheck(L_8);
		StringBuilder_t* L_11;
		L_11 = StringBuilder_Append_m08904D74E0C78E5F36DCD9C9303BDD07886D9F7D(L_8, L_10, NULL);
		int32_t L_12 = V_2;
		V_2 = ((int32_t)il2cpp_codegen_add(L_12, 1));
	}

IL_002e:
	{
		int32_t L_13 = V_2;
		ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* L_14 = V_1;
		NullCheck(L_14);
		if ((((int32_t)L_13) < ((int32_t)((int32_t)(((RuntimeArray*)L_14)->max_length)))))
		{
			goto IL_0017;
		}
	}
	{
		StringBuilder_t* L_15 = V_0;
		NullCheck(L_15);
		StringBuilder_t* L_16;
		L_16 = StringBuilder_Append_m71228B30F05724CD2CD96D9611DCD61BFB96A6E1(L_15, (Il2CppChar)((int32_t)41), NULL);
		StringBuilder_t* L_17 = V_0;
		RuntimeTypeHandle_t332A452B8B6179E4469B69525D0FE82A88030F7B L_18 = { reinterpret_cast<intptr_t> (il2cpp_rgctx_type(method->rgctx_data, 0)) };
		il2cpp_codegen_runtime_class_init_inline(Type_t_il2cpp_TypeInfo_var);
		Type_t* L_19;
		L_19 = Type_GetTypeFromHandle_m2570A2A5B32A5E9D9F0F38B37459DA18736C823E(L_18, NULL);
		String_t* L_20;
		L_20 = _AndroidJNIHelper_GetSignature_m1F94418EAEB87AF74E495191DC2AA5293136175B((RuntimeObject*)L_19, NULL);
		NullCheck(L_17);
		StringBuilder_t* L_21;
		L_21 = StringBuilder_Append_m08904D74E0C78E5F36DCD9C9303BDD07886D9F7D(L_17, L_20, NULL);
		StringBuilder_t* L_22 = V_0;
		NullCheck((RuntimeObject*)L_22);
		String_t* L_23;
		L_23 = VirtualFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, (RuntimeObject*)L_22);
		V_4 = L_23;
		goto IL_005d;
	}

IL_005d:
	{
		String_t* L_24 = V_4;
		return L_24;
	}
}
// System.String UnityEngine._AndroidJNIHelper::GetSignature<System.Char>(System.Object[])
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* _AndroidJNIHelper_GetSignature_TisChar_t521A6F19B456D956AF452D926C32709DC03D6B17_m749A4CD33AC4CF1D3F2723EBA4D1EEE590DCCD85_gshared (ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* ___args0, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&StringBuilder_t_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Type_t_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
StringBuilder_t* V_0 = NULL;
	ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* V_1 = NULL;
	int32_t V_2 = 0;
	RuntimeObject* V_3 = NULL;
	String_t* V_4 = NULL;
	{
		StringBuilder_t* L_0 = (StringBuilder_t*)il2cpp_codegen_object_new(StringBuilder_t_il2cpp_TypeInfo_var);
		StringBuilder__ctor_m1D99713357DE05DAFA296633639DB55F8C30587D(L_0, /*hidden argument*/NULL);
		V_0 = L_0;
		StringBuilder_t* L_1 = V_0;
		NullCheck(L_1);
		StringBuilder_t* L_2;
		L_2 = StringBuilder_Append_m71228B30F05724CD2CD96D9611DCD61BFB96A6E1(L_1, (Il2CppChar)((int32_t)40), NULL);
		ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* L_3 = ___args0;
		V_1 = L_3;
		V_2 = 0;
		goto IL_002e;
	}

IL_0017:
	{
		ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* L_4 = V_1;
		int32_t L_5 = V_2;
		NullCheck(L_4);
		int32_t L_6 = L_5;
		RuntimeObject* L_7 = (L_4)->GetAt(static_cast<il2cpp_array_size_t>(L_6));
		V_3 = L_7;
		StringBuilder_t* L_8 = V_0;
		RuntimeObject* L_9 = V_3;
		String_t* L_10;
		L_10 = _AndroidJNIHelper_GetSignature_m1F94418EAEB87AF74E495191DC2AA5293136175B(L_9, NULL);
		NullCheck(L_8);
		StringBuilder_t* L_11;
		L_11 = StringBuilder_Append_m08904D74E0C78E5F36DCD9C9303BDD07886D9F7D(L_8, L_10, NULL);
		int32_t L_12 = V_2;
		V_2 = ((int32_t)il2cpp_codegen_add(L_12, 1));
	}

IL_002e:
	{
		int32_t L_13 = V_2;
		ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* L_14 = V_1;
		NullCheck(L_14);
		if ((((int32_t)L_13) < ((int32_t)((int32_t)(((RuntimeArray*)L_14)->max_length)))))
		{
			goto IL_0017;
		}
	}
	{
		StringBuilder_t* L_15 = V_0;
		NullCheck(L_15);
		StringBuilder_t* L_16;
		L_16 = StringBuilder_Append_m71228B30F05724CD2CD96D9611DCD61BFB96A6E1(L_15, (Il2CppChar)((int32_t)41), NULL);
		StringBuilder_t* L_17 = V_0;
		RuntimeTypeHandle_t332A452B8B6179E4469B69525D0FE82A88030F7B L_18 = { reinterpret_cast<intptr_t> (il2cpp_rgctx_type(method->rgctx_data, 0)) };
		il2cpp_codegen_runtime_class_init_inline(Type_t_il2cpp_TypeInfo_var);
		Type_t* L_19;
		L_19 = Type_GetTypeFromHandle_m2570A2A5B32A5E9D9F0F38B37459DA18736C823E(L_18, NULL);
		String_t* L_20;
		L_20 = _AndroidJNIHelper_GetSignature_m1F94418EAEB87AF74E495191DC2AA5293136175B((RuntimeObject*)L_19, NULL);
		NullCheck(L_17);
		StringBuilder_t* L_21;
		L_21 = StringBuilder_Append_m08904D74E0C78E5F36DCD9C9303BDD07886D9F7D(L_17, L_20, NULL);
		StringBuilder_t* L_22 = V_0;
		NullCheck((RuntimeObject*)L_22);
		String_t* L_23;
		L_23 = VirtualFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, (RuntimeObject*)L_22);
		V_4 = L_23;
		goto IL_005d;
	}

IL_005d:
	{
		String_t* L_24 = V_4;
		return L_24;
	}
}
// System.String UnityEngine._AndroidJNIHelper::GetSignature<System.Double>(System.Object[])
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* _AndroidJNIHelper_GetSignature_TisDouble_tE150EF3D1D43DEE85D533810AB4C742307EEDE5F_m3A5FB0773626670CFB4AAC59E1485231C8EFD649_gshared (ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* ___args0, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&StringBuilder_t_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Type_t_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
StringBuilder_t* V_0 = NULL;
	ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* V_1 = NULL;
	int32_t V_2 = 0;
	RuntimeObject* V_3 = NULL;
	String_t* V_4 = NULL;
	{
		StringBuilder_t* L_0 = (StringBuilder_t*)il2cpp_codegen_object_new(StringBuilder_t_il2cpp_TypeInfo_var);
		StringBuilder__ctor_m1D99713357DE05DAFA296633639DB55F8C30587D(L_0, /*hidden argument*/NULL);
		V_0 = L_0;
		StringBuilder_t* L_1 = V_0;
		NullCheck(L_1);
		StringBuilder_t* L_2;
		L_2 = StringBuilder_Append_m71228B30F05724CD2CD96D9611DCD61BFB96A6E1(L_1, (Il2CppChar)((int32_t)40), NULL);
		ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* L_3 = ___args0;
		V_1 = L_3;
		V_2 = 0;
		goto IL_002e;
	}

IL_0017:
	{
		ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* L_4 = V_1;
		int32_t L_5 = V_2;
		NullCheck(L_4);
		int32_t L_6 = L_5;
		RuntimeObject* L_7 = (L_4)->GetAt(static_cast<il2cpp_array_size_t>(L_6));
		V_3 = L_7;
		StringBuilder_t* L_8 = V_0;
		RuntimeObject* L_9 = V_3;
		String_t* L_10;
		L_10 = _AndroidJNIHelper_GetSignature_m1F94418EAEB87AF74E495191DC2AA5293136175B(L_9, NULL);
		NullCheck(L_8);
		StringBuilder_t* L_11;
		L_11 = StringBuilder_Append_m08904D74E0C78E5F36DCD9C9303BDD07886D9F7D(L_8, L_10, NULL);
		int32_t L_12 = V_2;
		V_2 = ((int32_t)il2cpp_codegen_add(L_12, 1));
	}

IL_002e:
	{
		int32_t L_13 = V_2;
		ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* L_14 = V_1;
		NullCheck(L_14);
		if ((((int32_t)L_13) < ((int32_t)((int32_t)(((RuntimeArray*)L_14)->max_length)))))
		{
			goto IL_0017;
		}
	}
	{
		StringBuilder_t* L_15 = V_0;
		NullCheck(L_15);
		StringBuilder_t* L_16;
		L_16 = StringBuilder_Append_m71228B30F05724CD2CD96D9611DCD61BFB96A6E1(L_15, (Il2CppChar)((int32_t)41), NULL);
		StringBuilder_t* L_17 = V_0;
		RuntimeTypeHandle_t332A452B8B6179E4469B69525D0FE82A88030F7B L_18 = { reinterpret_cast<intptr_t> (il2cpp_rgctx_type(method->rgctx_data, 0)) };
		il2cpp_codegen_runtime_class_init_inline(Type_t_il2cpp_TypeInfo_var);
		Type_t* L_19;
		L_19 = Type_GetTypeFromHandle_m2570A2A5B32A5E9D9F0F38B37459DA18736C823E(L_18, NULL);
		String_t* L_20;
		L_20 = _AndroidJNIHelper_GetSignature_m1F94418EAEB87AF74E495191DC2AA5293136175B((RuntimeObject*)L_19, NULL);
		NullCheck(L_17);
		StringBuilder_t* L_21;
		L_21 = StringBuilder_Append_m08904D74E0C78E5F36DCD9C9303BDD07886D9F7D(L_17, L_20, NULL);
		StringBuilder_t* L_22 = V_0;
		NullCheck((RuntimeObject*)L_22);
		String_t* L_23;
		L_23 = VirtualFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, (RuntimeObject*)L_22);
		V_4 = L_23;
		goto IL_005d;
	}

IL_005d:
	{
		String_t* L_24 = V_4;
		return L_24;
	}
}
// System.String UnityEngine._AndroidJNIHelper::GetSignature<System.Int16>(System.Object[])
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* _AndroidJNIHelper_GetSignature_TisInt16_tB8EF286A9C33492FA6E6D6E67320BE93E794A175_m258931EB2BDEDE3D2CED632F6B207CA93F46CAC1_gshared (ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* ___args0, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&StringBuilder_t_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Type_t_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
StringBuilder_t* V_0 = NULL;
	ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* V_1 = NULL;
	int32_t V_2 = 0;
	RuntimeObject* V_3 = NULL;
	String_t* V_4 = NULL;
	{
		StringBuilder_t* L_0 = (StringBuilder_t*)il2cpp_codegen_object_new(StringBuilder_t_il2cpp_TypeInfo_var);
		StringBuilder__ctor_m1D99713357DE05DAFA296633639DB55F8C30587D(L_0, /*hidden argument*/NULL);
		V_0 = L_0;
		StringBuilder_t* L_1 = V_0;
		NullCheck(L_1);
		StringBuilder_t* L_2;
		L_2 = StringBuilder_Append_m71228B30F05724CD2CD96D9611DCD61BFB96A6E1(L_1, (Il2CppChar)((int32_t)40), NULL);
		ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* L_3 = ___args0;
		V_1 = L_3;
		V_2 = 0;
		goto IL_002e;
	}

IL_0017:
	{
		ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* L_4 = V_1;
		int32_t L_5 = V_2;
		NullCheck(L_4);
		int32_t L_6 = L_5;
		RuntimeObject* L_7 = (L_4)->GetAt(static_cast<il2cpp_array_size_t>(L_6));
		V_3 = L_7;
		StringBuilder_t* L_8 = V_0;
		RuntimeObject* L_9 = V_3;
		String_t* L_10;
		L_10 = _AndroidJNIHelper_GetSignature_m1F94418EAEB87AF74E495191DC2AA5293136175B(L_9, NULL);
		NullCheck(L_8);
		StringBuilder_t* L_11;
		L_11 = StringBuilder_Append_m08904D74E0C78E5F36DCD9C9303BDD07886D9F7D(L_8, L_10, NULL);
		int32_t L_12 = V_2;
		V_2 = ((int32_t)il2cpp_codegen_add(L_12, 1));
	}

IL_002e:
	{
		int32_t L_13 = V_2;
		ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* L_14 = V_1;
		NullCheck(L_14);
		if ((((int32_t)L_13) < ((int32_t)((int32_t)(((RuntimeArray*)L_14)->max_length)))))
		{
			goto IL_0017;
		}
	}
	{
		StringBuilder_t* L_15 = V_0;
		NullCheck(L_15);
		StringBuilder_t* L_16;
		L_16 = StringBuilder_Append_m71228B30F05724CD2CD96D9611DCD61BFB96A6E1(L_15, (Il2CppChar)((int32_t)41), NULL);
		StringBuilder_t* L_17 = V_0;
		RuntimeTypeHandle_t332A452B8B6179E4469B69525D0FE82A88030F7B L_18 = { reinterpret_cast<intptr_t> (il2cpp_rgctx_type(method->rgctx_data, 0)) };
		il2cpp_codegen_runtime_class_init_inline(Type_t_il2cpp_TypeInfo_var);
		Type_t* L_19;
		L_19 = Type_GetTypeFromHandle_m2570A2A5B32A5E9D9F0F38B37459DA18736C823E(L_18, NULL);
		String_t* L_20;
		L_20 = _AndroidJNIHelper_GetSignature_m1F94418EAEB87AF74E495191DC2AA5293136175B((RuntimeObject*)L_19, NULL);
		NullCheck(L_17);
		StringBuilder_t* L_21;
		L_21 = StringBuilder_Append_m08904D74E0C78E5F36DCD9C9303BDD07886D9F7D(L_17, L_20, NULL);
		StringBuilder_t* L_22 = V_0;
		NullCheck((RuntimeObject*)L_22);
		String_t* L_23;
		L_23 = VirtualFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, (RuntimeObject*)L_22);
		V_4 = L_23;
		goto IL_005d;
	}

IL_005d:
	{
		String_t* L_24 = V_4;
		return L_24;
	}
}
// System.String UnityEngine._AndroidJNIHelper::GetSignature<System.Int32>(System.Object[])
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* _AndroidJNIHelper_GetSignature_TisInt32_t680FF22E76F6EFAD4375103CBBFFA0421349384C_mB5511DCA764C7BB77877C9028AB026AD9EEBD6B8_gshared (ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* ___args0, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&StringBuilder_t_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Type_t_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
StringBuilder_t* V_0 = NULL;
	ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* V_1 = NULL;
	int32_t V_2 = 0;
	RuntimeObject* V_3 = NULL;
	String_t* V_4 = NULL;
	{
		StringBuilder_t* L_0 = (StringBuilder_t*)il2cpp_codegen_object_new(StringBuilder_t_il2cpp_TypeInfo_var);
		StringBuilder__ctor_m1D99713357DE05DAFA296633639DB55F8C30587D(L_0, /*hidden argument*/NULL);
		V_0 = L_0;
		StringBuilder_t* L_1 = V_0;
		NullCheck(L_1);
		StringBuilder_t* L_2;
		L_2 = StringBuilder_Append_m71228B30F05724CD2CD96D9611DCD61BFB96A6E1(L_1, (Il2CppChar)((int32_t)40), NULL);
		ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* L_3 = ___args0;
		V_1 = L_3;
		V_2 = 0;
		goto IL_002e;
	}

IL_0017:
	{
		ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* L_4 = V_1;
		int32_t L_5 = V_2;
		NullCheck(L_4);
		int32_t L_6 = L_5;
		RuntimeObject* L_7 = (L_4)->GetAt(static_cast<il2cpp_array_size_t>(L_6));
		V_3 = L_7;
		StringBuilder_t* L_8 = V_0;
		RuntimeObject* L_9 = V_3;
		String_t* L_10;
		L_10 = _AndroidJNIHelper_GetSignature_m1F94418EAEB87AF74E495191DC2AA5293136175B(L_9, NULL);
		NullCheck(L_8);
		StringBuilder_t* L_11;
		L_11 = StringBuilder_Append_m08904D74E0C78E5F36DCD9C9303BDD07886D9F7D(L_8, L_10, NULL);
		int32_t L_12 = V_2;
		V_2 = ((int32_t)il2cpp_codegen_add(L_12, 1));
	}

IL_002e:
	{
		int32_t L_13 = V_2;
		ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* L_14 = V_1;
		NullCheck(L_14);
		if ((((int32_t)L_13) < ((int32_t)((int32_t)(((RuntimeArray*)L_14)->max_length)))))
		{
			goto IL_0017;
		}
	}
	{
		StringBuilder_t* L_15 = V_0;
		NullCheck(L_15);
		StringBuilder_t* L_16;
		L_16 = StringBuilder_Append_m71228B30F05724CD2CD96D9611DCD61BFB96A6E1(L_15, (Il2CppChar)((int32_t)41), NULL);
		StringBuilder_t* L_17 = V_0;
		RuntimeTypeHandle_t332A452B8B6179E4469B69525D0FE82A88030F7B L_18 = { reinterpret_cast<intptr_t> (il2cpp_rgctx_type(method->rgctx_data, 0)) };
		il2cpp_codegen_runtime_class_init_inline(Type_t_il2cpp_TypeInfo_var);
		Type_t* L_19;
		L_19 = Type_GetTypeFromHandle_m2570A2A5B32A5E9D9F0F38B37459DA18736C823E(L_18, NULL);
		String_t* L_20;
		L_20 = _AndroidJNIHelper_GetSignature_m1F94418EAEB87AF74E495191DC2AA5293136175B((RuntimeObject*)L_19, NULL);
		NullCheck(L_17);
		StringBuilder_t* L_21;
		L_21 = StringBuilder_Append_m08904D74E0C78E5F36DCD9C9303BDD07886D9F7D(L_17, L_20, NULL);
		StringBuilder_t* L_22 = V_0;
		NullCheck((RuntimeObject*)L_22);
		String_t* L_23;
		L_23 = VirtualFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, (RuntimeObject*)L_22);
		V_4 = L_23;
		goto IL_005d;
	}

IL_005d:
	{
		String_t* L_24 = V_4;
		return L_24;
	}
}
// System.String UnityEngine._AndroidJNIHelper::GetSignature<System.Int64>(System.Object[])
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* _AndroidJNIHelper_GetSignature_TisInt64_t092CFB123BE63C28ACDAF65C68F21A526050DBA3_m5BC7606ACC6309C3070972F60C8A552BA1D4DA71_gshared (ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* ___args0, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&StringBuilder_t_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Type_t_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
StringBuilder_t* V_0 = NULL;
	ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* V_1 = NULL;
	int32_t V_2 = 0;
	RuntimeObject* V_3 = NULL;
	String_t* V_4 = NULL;
	{
		StringBuilder_t* L_0 = (StringBuilder_t*)il2cpp_codegen_object_new(StringBuilder_t_il2cpp_TypeInfo_var);
		StringBuilder__ctor_m1D99713357DE05DAFA296633639DB55F8C30587D(L_0, /*hidden argument*/NULL);
		V_0 = L_0;
		StringBuilder_t* L_1 = V_0;
		NullCheck(L_1);
		StringBuilder_t* L_2;
		L_2 = StringBuilder_Append_m71228B30F05724CD2CD96D9611DCD61BFB96A6E1(L_1, (Il2CppChar)((int32_t)40), NULL);
		ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* L_3 = ___args0;
		V_1 = L_3;
		V_2 = 0;
		goto IL_002e;
	}

IL_0017:
	{
		ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* L_4 = V_1;
		int32_t L_5 = V_2;
		NullCheck(L_4);
		int32_t L_6 = L_5;
		RuntimeObject* L_7 = (L_4)->GetAt(static_cast<il2cpp_array_size_t>(L_6));
		V_3 = L_7;
		StringBuilder_t* L_8 = V_0;
		RuntimeObject* L_9 = V_3;
		String_t* L_10;
		L_10 = _AndroidJNIHelper_GetSignature_m1F94418EAEB87AF74E495191DC2AA5293136175B(L_9, NULL);
		NullCheck(L_8);
		StringBuilder_t* L_11;
		L_11 = StringBuilder_Append_m08904D74E0C78E5F36DCD9C9303BDD07886D9F7D(L_8, L_10, NULL);
		int32_t L_12 = V_2;
		V_2 = ((int32_t)il2cpp_codegen_add(L_12, 1));
	}

IL_002e:
	{
		int32_t L_13 = V_2;
		ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* L_14 = V_1;
		NullCheck(L_14);
		if ((((int32_t)L_13) < ((int32_t)((int32_t)(((RuntimeArray*)L_14)->max_length)))))
		{
			goto IL_0017;
		}
	}
	{
		StringBuilder_t* L_15 = V_0;
		NullCheck(L_15);
		StringBuilder_t* L_16;
		L_16 = StringBuilder_Append_m71228B30F05724CD2CD96D9611DCD61BFB96A6E1(L_15, (Il2CppChar)((int32_t)41), NULL);
		StringBuilder_t* L_17 = V_0;
		RuntimeTypeHandle_t332A452B8B6179E4469B69525D0FE82A88030F7B L_18 = { reinterpret_cast<intptr_t> (il2cpp_rgctx_type(method->rgctx_data, 0)) };
		il2cpp_codegen_runtime_class_init_inline(Type_t_il2cpp_TypeInfo_var);
		Type_t* L_19;
		L_19 = Type_GetTypeFromHandle_m2570A2A5B32A5E9D9F0F38B37459DA18736C823E(L_18, NULL);
		String_t* L_20;
		L_20 = _AndroidJNIHelper_GetSignature_m1F94418EAEB87AF74E495191DC2AA5293136175B((RuntimeObject*)L_19, NULL);
		NullCheck(L_17);
		StringBuilder_t* L_21;
		L_21 = StringBuilder_Append_m08904D74E0C78E5F36DCD9C9303BDD07886D9F7D(L_17, L_20, NULL);
		StringBuilder_t* L_22 = V_0;
		NullCheck((RuntimeObject*)L_22);
		String_t* L_23;
		L_23 = VirtualFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, (RuntimeObject*)L_22);
		V_4 = L_23;
		goto IL_005d;
	}

IL_005d:
	{
		String_t* L_24 = V_4;
		return L_24;
	}
}
// System.String UnityEngine._AndroidJNIHelper::GetSignature<System.Object>(System.Object[])
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* _AndroidJNIHelper_GetSignature_TisRuntimeObject_m8D1061D8E0079806BBE251CE5ACAF4262C15EE8E_gshared (ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* ___args0, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&StringBuilder_t_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Type_t_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
StringBuilder_t* V_0 = NULL;
	ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* V_1 = NULL;
	int32_t V_2 = 0;
	RuntimeObject* V_3 = NULL;
	String_t* V_4 = NULL;
	{
		StringBuilder_t* L_0 = (StringBuilder_t*)il2cpp_codegen_object_new(StringBuilder_t_il2cpp_TypeInfo_var);
		StringBuilder__ctor_m1D99713357DE05DAFA296633639DB55F8C30587D(L_0, /*hidden argument*/NULL);
		V_0 = L_0;
		StringBuilder_t* L_1 = V_0;
		NullCheck(L_1);
		StringBuilder_t* L_2;
		L_2 = StringBuilder_Append_m71228B30F05724CD2CD96D9611DCD61BFB96A6E1(L_1, (Il2CppChar)((int32_t)40), NULL);
		ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* L_3 = ___args0;
		V_1 = L_3;
		V_2 = 0;
		goto IL_002e;
	}

IL_0017:
	{
		ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* L_4 = V_1;
		int32_t L_5 = V_2;
		NullCheck(L_4);
		int32_t L_6 = L_5;
		RuntimeObject* L_7 = (L_4)->GetAt(static_cast<il2cpp_array_size_t>(L_6));
		V_3 = L_7;
		StringBuilder_t* L_8 = V_0;
		RuntimeObject* L_9 = V_3;
		String_t* L_10;
		L_10 = _AndroidJNIHelper_GetSignature_m1F94418EAEB87AF74E495191DC2AA5293136175B(L_9, NULL);
		NullCheck(L_8);
		StringBuilder_t* L_11;
		L_11 = StringBuilder_Append_m08904D74E0C78E5F36DCD9C9303BDD07886D9F7D(L_8, L_10, NULL);
		int32_t L_12 = V_2;
		V_2 = ((int32_t)il2cpp_codegen_add(L_12, 1));
	}

IL_002e:
	{
		int32_t L_13 = V_2;
		ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* L_14 = V_1;
		NullCheck(L_14);
		if ((((int32_t)L_13) < ((int32_t)((int32_t)(((RuntimeArray*)L_14)->max_length)))))
		{
			goto IL_0017;
		}
	}
	{
		StringBuilder_t* L_15 = V_0;
		NullCheck(L_15);
		StringBuilder_t* L_16;
		L_16 = StringBuilder_Append_m71228B30F05724CD2CD96D9611DCD61BFB96A6E1(L_15, (Il2CppChar)((int32_t)41), NULL);
		StringBuilder_t* L_17 = V_0;
		RuntimeTypeHandle_t332A452B8B6179E4469B69525D0FE82A88030F7B L_18 = { reinterpret_cast<intptr_t> (il2cpp_rgctx_type(method->rgctx_data, 0)) };
		il2cpp_codegen_runtime_class_init_inline(Type_t_il2cpp_TypeInfo_var);
		Type_t* L_19;
		L_19 = Type_GetTypeFromHandle_m2570A2A5B32A5E9D9F0F38B37459DA18736C823E(L_18, NULL);
		String_t* L_20;
		L_20 = _AndroidJNIHelper_GetSignature_m1F94418EAEB87AF74E495191DC2AA5293136175B((RuntimeObject*)L_19, NULL);
		NullCheck(L_17);
		StringBuilder_t* L_21;
		L_21 = StringBuilder_Append_m08904D74E0C78E5F36DCD9C9303BDD07886D9F7D(L_17, L_20, NULL);
		StringBuilder_t* L_22 = V_0;
		NullCheck((RuntimeObject*)L_22);
		String_t* L_23;
		L_23 = VirtualFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, (RuntimeObject*)L_22);
		V_4 = L_23;
		goto IL_005d;
	}

IL_005d:
	{
		String_t* L_24 = V_4;
		return L_24;
	}
}
// System.String UnityEngine._AndroidJNIHelper::GetSignature<System.SByte>(System.Object[])
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* _AndroidJNIHelper_GetSignature_TisSByte_tFEFFEF5D2FEBF5207950AE6FAC150FC53B668DB5_mEF017EFBD89137395458CD85A01B48B45892FCE9_gshared (ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* ___args0, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&StringBuilder_t_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Type_t_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
StringBuilder_t* V_0 = NULL;
	ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* V_1 = NULL;
	int32_t V_2 = 0;
	RuntimeObject* V_3 = NULL;
	String_t* V_4 = NULL;
	{
		StringBuilder_t* L_0 = (StringBuilder_t*)il2cpp_codegen_object_new(StringBuilder_t_il2cpp_TypeInfo_var);
		StringBuilder__ctor_m1D99713357DE05DAFA296633639DB55F8C30587D(L_0, /*hidden argument*/NULL);
		V_0 = L_0;
		StringBuilder_t* L_1 = V_0;
		NullCheck(L_1);
		StringBuilder_t* L_2;
		L_2 = StringBuilder_Append_m71228B30F05724CD2CD96D9611DCD61BFB96A6E1(L_1, (Il2CppChar)((int32_t)40), NULL);
		ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* L_3 = ___args0;
		V_1 = L_3;
		V_2 = 0;
		goto IL_002e;
	}

IL_0017:
	{
		ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* L_4 = V_1;
		int32_t L_5 = V_2;
		NullCheck(L_4);
		int32_t L_6 = L_5;
		RuntimeObject* L_7 = (L_4)->GetAt(static_cast<il2cpp_array_size_t>(L_6));
		V_3 = L_7;
		StringBuilder_t* L_8 = V_0;
		RuntimeObject* L_9 = V_3;
		String_t* L_10;
		L_10 = _AndroidJNIHelper_GetSignature_m1F94418EAEB87AF74E495191DC2AA5293136175B(L_9, NULL);
		NullCheck(L_8);
		StringBuilder_t* L_11;
		L_11 = StringBuilder_Append_m08904D74E0C78E5F36DCD9C9303BDD07886D9F7D(L_8, L_10, NULL);
		int32_t L_12 = V_2;
		V_2 = ((int32_t)il2cpp_codegen_add(L_12, 1));
	}

IL_002e:
	{
		int32_t L_13 = V_2;
		ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* L_14 = V_1;
		NullCheck(L_14);
		if ((((int32_t)L_13) < ((int32_t)((int32_t)(((RuntimeArray*)L_14)->max_length)))))
		{
			goto IL_0017;
		}
	}
	{
		StringBuilder_t* L_15 = V_0;
		NullCheck(L_15);
		StringBuilder_t* L_16;
		L_16 = StringBuilder_Append_m71228B30F05724CD2CD96D9611DCD61BFB96A6E1(L_15, (Il2CppChar)((int32_t)41), NULL);
		StringBuilder_t* L_17 = V_0;
		RuntimeTypeHandle_t332A452B8B6179E4469B69525D0FE82A88030F7B L_18 = { reinterpret_cast<intptr_t> (il2cpp_rgctx_type(method->rgctx_data, 0)) };
		il2cpp_codegen_runtime_class_init_inline(Type_t_il2cpp_TypeInfo_var);
		Type_t* L_19;
		L_19 = Type_GetTypeFromHandle_m2570A2A5B32A5E9D9F0F38B37459DA18736C823E(L_18, NULL);
		String_t* L_20;
		L_20 = _AndroidJNIHelper_GetSignature_m1F94418EAEB87AF74E495191DC2AA5293136175B((RuntimeObject*)L_19, NULL);
		NullCheck(L_17);
		StringBuilder_t* L_21;
		L_21 = StringBuilder_Append_m08904D74E0C78E5F36DCD9C9303BDD07886D9F7D(L_17, L_20, NULL);
		StringBuilder_t* L_22 = V_0;
		NullCheck((RuntimeObject*)L_22);
		String_t* L_23;
		L_23 = VirtualFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, (RuntimeObject*)L_22);
		V_4 = L_23;
		goto IL_005d;
	}

IL_005d:
	{
		String_t* L_24 = V_4;
		return L_24;
	}
}
// System.String UnityEngine._AndroidJNIHelper::GetSignature<System.Single>(System.Object[])
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* _AndroidJNIHelper_GetSignature_TisSingle_t4530F2FF86FCB0DC29F35385CA1BD21BE294761C_mCF75982D40162C5B91D40E003FC6388445B8A9B7_gshared (ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* ___args0, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&StringBuilder_t_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Type_t_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
StringBuilder_t* V_0 = NULL;
	ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* V_1 = NULL;
	int32_t V_2 = 0;
	RuntimeObject* V_3 = NULL;
	String_t* V_4 = NULL;
	{
		StringBuilder_t* L_0 = (StringBuilder_t*)il2cpp_codegen_object_new(StringBuilder_t_il2cpp_TypeInfo_var);
		StringBuilder__ctor_m1D99713357DE05DAFA296633639DB55F8C30587D(L_0, /*hidden argument*/NULL);
		V_0 = L_0;
		StringBuilder_t* L_1 = V_0;
		NullCheck(L_1);
		StringBuilder_t* L_2;
		L_2 = StringBuilder_Append_m71228B30F05724CD2CD96D9611DCD61BFB96A6E1(L_1, (Il2CppChar)((int32_t)40), NULL);
		ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* L_3 = ___args0;
		V_1 = L_3;
		V_2 = 0;
		goto IL_002e;
	}

IL_0017:
	{
		ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* L_4 = V_1;
		int32_t L_5 = V_2;
		NullCheck(L_4);
		int32_t L_6 = L_5;
		RuntimeObject* L_7 = (L_4)->GetAt(static_cast<il2cpp_array_size_t>(L_6));
		V_3 = L_7;
		StringBuilder_t* L_8 = V_0;
		RuntimeObject* L_9 = V_3;
		String_t* L_10;
		L_10 = _AndroidJNIHelper_GetSignature_m1F94418EAEB87AF74E495191DC2AA5293136175B(L_9, NULL);
		NullCheck(L_8);
		StringBuilder_t* L_11;
		L_11 = StringBuilder_Append_m08904D74E0C78E5F36DCD9C9303BDD07886D9F7D(L_8, L_10, NULL);
		int32_t L_12 = V_2;
		V_2 = ((int32_t)il2cpp_codegen_add(L_12, 1));
	}

IL_002e:
	{
		int32_t L_13 = V_2;
		ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* L_14 = V_1;
		NullCheck(L_14);
		if ((((int32_t)L_13) < ((int32_t)((int32_t)(((RuntimeArray*)L_14)->max_length)))))
		{
			goto IL_0017;
		}
	}
	{
		StringBuilder_t* L_15 = V_0;
		NullCheck(L_15);
		StringBuilder_t* L_16;
		L_16 = StringBuilder_Append_m71228B30F05724CD2CD96D9611DCD61BFB96A6E1(L_15, (Il2CppChar)((int32_t)41), NULL);
		StringBuilder_t* L_17 = V_0;
		RuntimeTypeHandle_t332A452B8B6179E4469B69525D0FE82A88030F7B L_18 = { reinterpret_cast<intptr_t> (il2cpp_rgctx_type(method->rgctx_data, 0)) };
		il2cpp_codegen_runtime_class_init_inline(Type_t_il2cpp_TypeInfo_var);
		Type_t* L_19;
		L_19 = Type_GetTypeFromHandle_m2570A2A5B32A5E9D9F0F38B37459DA18736C823E(L_18, NULL);
		String_t* L_20;
		L_20 = _AndroidJNIHelper_GetSignature_m1F94418EAEB87AF74E495191DC2AA5293136175B((RuntimeObject*)L_19, NULL);
		NullCheck(L_17);
		StringBuilder_t* L_21;
		L_21 = StringBuilder_Append_m08904D74E0C78E5F36DCD9C9303BDD07886D9F7D(L_17, L_20, NULL);
		StringBuilder_t* L_22 = V_0;
		NullCheck((RuntimeObject*)L_22);
		String_t* L_23;
		L_23 = VirtualFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, (RuntimeObject*)L_22);
		V_4 = L_23;
		goto IL_005d;
	}

IL_005d:
	{
		String_t* L_24 = V_4;
		return L_24;
	}
}
// ? gPqZAArEBWUnolRtZlCKNFZvRLqr::EbfdinkoZokdjHZQAzRBHIhcWPWy<System.Object>(System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* gPqZAArEBWUnolRtZlCKNFZvRLqr_EbfdinkoZokdjHZQAzRBHIhcWPWy_TisRuntimeObject_m50F9063D59B8715883B3C799562081D21827F5CC_gshared (intptr_t p0, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IDisposable_t030E0496B4E0E4E4F086825007979AF51F7248C5_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&gPqZAArEBWUnolRtZlCKNFZvRLqr_tF91080EAD5330A023C3CBFFB01A8F1A45A0BDC0A_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
gPqZAArEBWUnolRtZlCKNFZvRLqr_tF91080EAD5330A023C3CBFFB01A8F1A45A0BDC0A* V_0 = NULL;
	RuntimeObject* V_1 = NULL;
	{
		intptr_t L_0 = p0;
		gPqZAArEBWUnolRtZlCKNFZvRLqr_tF91080EAD5330A023C3CBFFB01A8F1A45A0BDC0A* L_1 = (gPqZAArEBWUnolRtZlCKNFZvRLqr_tF91080EAD5330A023C3CBFFB01A8F1A45A0BDC0A*)il2cpp_codegen_object_new(gPqZAArEBWUnolRtZlCKNFZvRLqr_tF91080EAD5330A023C3CBFFB01A8F1A45A0BDC0A_il2cpp_TypeInfo_var);
		gPqZAArEBWUnolRtZlCKNFZvRLqr__ctor_mA7CAA7F0171ED7E041E6DCE615ACDEFC63FA6432(L_1, L_0, /*hidden argument*/NULL);
		V_0 = L_1;
	}

IL_0007:
	{
		auto __finallyBlock = il2cpp::utils::Finally([&]
		{

FINALLY_0010:
			{// begin finally (depth: 1)
				{
					gPqZAArEBWUnolRtZlCKNFZvRLqr_tF91080EAD5330A023C3CBFFB01A8F1A45A0BDC0A* L_2 = V_0;
					if (!L_2)
					{
						goto IL_0019;
					}
				}

IL_0013:
				{
					gPqZAArEBWUnolRtZlCKNFZvRLqr_tF91080EAD5330A023C3CBFFB01A8F1A45A0BDC0A* L_3 = V_0;
					NullCheck((RuntimeObject*)L_3);
					InterfaceActionInvoker0::Invoke(0 /* System.Void System.IDisposable::Dispose() */, IDisposable_t030E0496B4E0E4E4F086825007979AF51F7248C5_il2cpp_TypeInfo_var, (RuntimeObject*)L_3);
				}

IL_0019:
				{
					return;
				}
			}// end finally (depth: 1)
		});
		try
		{// begin try (depth: 1)
			gPqZAArEBWUnolRtZlCKNFZvRLqr_tF91080EAD5330A023C3CBFFB01A8F1A45A0BDC0A* L_4 = V_0;
			NullCheck(L_4);
			RuntimeObject* L_5;
			L_5 = GenericVirtualFuncInvoker0< RuntimeObject* >::Invoke(il2cpp_rgctx_method(method->rgctx_data, 0), L_4);
			V_1 = L_5;
			goto IL_001a;
		}// end try (depth: 1)
		catch(Il2CppExceptionWrapper& e)
		{
			__finallyBlock.StoreException(e.ex);
		}
	}

IL_001a:
	{
		RuntimeObject* L_6 = V_1;
		return L_6;
	}
}
// ? gPqZAArEBWUnolRtZlCKNFZvRLqr::EbfdinkoZokdjHZQAzRBHIhcWPWy<System.Object>(System.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* gPqZAArEBWUnolRtZlCKNFZvRLqr_EbfdinkoZokdjHZQAzRBHIhcWPWy_TisRuntimeObject_mB0201D0F3226FA622DF66F0B834BB8938E4770CD_gshared (RuntimeObject* p0, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IDisposable_t030E0496B4E0E4E4F086825007979AF51F7248C5_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Marshal_tD976A56A90263C3CE2B780D4B1CADADE2E70B4A7_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&gPqZAArEBWUnolRtZlCKNFZvRLqr_tF91080EAD5330A023C3CBFFB01A8F1A45A0BDC0A_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
gPqZAArEBWUnolRtZlCKNFZvRLqr_tF91080EAD5330A023C3CBFFB01A8F1A45A0BDC0A* V_0 = NULL;
	RuntimeObject* V_1 = NULL;
	{
		RuntimeObject* L_0 = p0;
		il2cpp_codegen_runtime_class_init_inline(Marshal_tD976A56A90263C3CE2B780D4B1CADADE2E70B4A7_il2cpp_TypeInfo_var);
		intptr_t L_1;
		L_1 = il2cpp_codegen_com_get_iunknown_for_object(L_0);
		gPqZAArEBWUnolRtZlCKNFZvRLqr_tF91080EAD5330A023C3CBFFB01A8F1A45A0BDC0A* L_2 = (gPqZAArEBWUnolRtZlCKNFZvRLqr_tF91080EAD5330A023C3CBFFB01A8F1A45A0BDC0A*)il2cpp_codegen_object_new(gPqZAArEBWUnolRtZlCKNFZvRLqr_tF91080EAD5330A023C3CBFFB01A8F1A45A0BDC0A_il2cpp_TypeInfo_var);
		gPqZAArEBWUnolRtZlCKNFZvRLqr__ctor_mA7CAA7F0171ED7E041E6DCE615ACDEFC63FA6432(L_2, L_1, /*hidden argument*/NULL);
		V_0 = L_2;
	}

IL_000c:
	{
		auto __finallyBlock = il2cpp::utils::Finally([&]
		{

FINALLY_0015:
			{// begin finally (depth: 1)
				{
					gPqZAArEBWUnolRtZlCKNFZvRLqr_tF91080EAD5330A023C3CBFFB01A8F1A45A0BDC0A* L_3 = V_0;
					if (!L_3)
					{
						goto IL_001e;
					}
				}

IL_0018:
				{
					gPqZAArEBWUnolRtZlCKNFZvRLqr_tF91080EAD5330A023C3CBFFB01A8F1A45A0BDC0A* L_4 = V_0;
					NullCheck((RuntimeObject*)L_4);
					InterfaceActionInvoker0::Invoke(0 /* System.Void System.IDisposable::Dispose() */, IDisposable_t030E0496B4E0E4E4F086825007979AF51F7248C5_il2cpp_TypeInfo_var, (RuntimeObject*)L_4);
				}

IL_001e:
				{
					return;
				}
			}// end finally (depth: 1)
		});
		try
		{// begin try (depth: 1)
			gPqZAArEBWUnolRtZlCKNFZvRLqr_tF91080EAD5330A023C3CBFFB01A8F1A45A0BDC0A* L_5 = V_0;
			NullCheck(L_5);
			RuntimeObject* L_6;
			L_6 = GenericVirtualFuncInvoker0< RuntimeObject* >::Invoke(il2cpp_rgctx_method(method->rgctx_data, 0), L_5);
			V_1 = L_6;
			goto IL_001f;
		}// end try (depth: 1)
		catch(Il2CppExceptionWrapper& e)
		{
			__finallyBlock.StoreException(e.ex);
		}
	}

IL_001f:
	{
		RuntimeObject* L_7 = V_1;
		return L_7;
	}
}
// ? gPqZAArEBWUnolRtZlCKNFZvRLqr::INHqKiTZLbfEbjNGIdzLLYeqOUJj<System.Object>(System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* gPqZAArEBWUnolRtZlCKNFZvRLqr_INHqKiTZLbfEbjNGIdzLLYeqOUJj_TisRuntimeObject_m8866CA9A75122E39BC3266FF3D5C6E8F8DDC1DC3_gshared (intptr_t p0, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IDisposable_t030E0496B4E0E4E4F086825007979AF51F7248C5_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&gPqZAArEBWUnolRtZlCKNFZvRLqr_tF91080EAD5330A023C3CBFFB01A8F1A45A0BDC0A_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
gPqZAArEBWUnolRtZlCKNFZvRLqr_tF91080EAD5330A023C3CBFFB01A8F1A45A0BDC0A* V_0 = NULL;
	RuntimeObject* V_1 = NULL;
	{
		intptr_t L_0 = p0;
		gPqZAArEBWUnolRtZlCKNFZvRLqr_tF91080EAD5330A023C3CBFFB01A8F1A45A0BDC0A* L_1 = (gPqZAArEBWUnolRtZlCKNFZvRLqr_tF91080EAD5330A023C3CBFFB01A8F1A45A0BDC0A*)il2cpp_codegen_object_new(gPqZAArEBWUnolRtZlCKNFZvRLqr_tF91080EAD5330A023C3CBFFB01A8F1A45A0BDC0A_il2cpp_TypeInfo_var);
		gPqZAArEBWUnolRtZlCKNFZvRLqr__ctor_mA7CAA7F0171ED7E041E6DCE615ACDEFC63FA6432(L_1, L_0, /*hidden argument*/NULL);
		V_0 = L_1;
	}

IL_0007:
	{
		auto __finallyBlock = il2cpp::utils::Finally([&]
		{

FINALLY_0010:
			{// begin finally (depth: 1)
				{
					gPqZAArEBWUnolRtZlCKNFZvRLqr_tF91080EAD5330A023C3CBFFB01A8F1A45A0BDC0A* L_2 = V_0;
					if (!L_2)
					{
						goto IL_0019;
					}
				}

IL_0013:
				{
					gPqZAArEBWUnolRtZlCKNFZvRLqr_tF91080EAD5330A023C3CBFFB01A8F1A45A0BDC0A* L_3 = V_0;
					NullCheck((RuntimeObject*)L_3);
					InterfaceActionInvoker0::Invoke(0 /* System.Void System.IDisposable::Dispose() */, IDisposable_t030E0496B4E0E4E4F086825007979AF51F7248C5_il2cpp_TypeInfo_var, (RuntimeObject*)L_3);
				}

IL_0019:
				{
					return;
				}
			}// end finally (depth: 1)
		});
		try
		{// begin try (depth: 1)
			gPqZAArEBWUnolRtZlCKNFZvRLqr_tF91080EAD5330A023C3CBFFB01A8F1A45A0BDC0A* L_4 = V_0;
			NullCheck(L_4);
			RuntimeObject* L_5;
			L_5 = GenericVirtualFuncInvoker0< RuntimeObject* >::Invoke(il2cpp_rgctx_method(method->rgctx_data, 0), L_4);
			V_1 = L_5;
			goto IL_001a;
		}// end try (depth: 1)
		catch(Il2CppExceptionWrapper& e)
		{
			__finallyBlock.StoreException(e.ex);
		}
	}

IL_001a:
	{
		RuntimeObject* L_6 = V_1;
		return L_6;
	}
}
// System.Boolean gPqZAArEBWUnolRtZlCKNFZvRLqr::hKUKVeOasFwXNzYsjSLDWiBlHegi<System.Object>(?,?)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool gPqZAArEBWUnolRtZlCKNFZvRLqr_hKUKVeOasFwXNzYsjSLDWiBlHegi_TisRuntimeObject_mCA42703B2562AC7489E02DDC51ABF318E99C274E_gshared (RuntimeObject* p0, RuntimeObject* p1, const RuntimeMethod* method) 
{
{
		RuntimeObject* L_0 = p0;
		RuntimeObject* L_1 = p1;
		bool L_2;
		L_2 = Object_Equals_mF52C7AEB4AA9F136C3EA31AE3C1FD200B831B3D1(L_0, L_1, NULL);
		if (!L_2)
		{
			goto IL_0015;
		}
	}
	{
		return (bool)1;
	}

IL_0015:
	{
		RuntimeObject* L_3 = p0;
		if (!L_3)
		{
			goto IL_0025;
		}
	}
	{
		RuntimeObject* L_4 = p1;
		if (L_4)
		{
			goto IL_0027;
		}
	}

IL_0025:
	{
		return (bool)0;
	}

IL_0027:
	{
		RuntimeObject* L_5 = p0;
		NullCheck((SreStMNJSUKnhiFeYdCnZvaTqzgO_tCAADFAF41D7399BA1A417D5051C817A325FB955C*)L_5);
		intptr_t L_6;
		L_6 = SreStMNJSUKnhiFeYdCnZvaTqzgO_RvQYOisGQgIvOvSNNcOyLAzxJwjg_m5F546A28798410BFAA6391AF7BDAA858B6015EDF((SreStMNJSUKnhiFeYdCnZvaTqzgO_tCAADFAF41D7399BA1A417D5051C817A325FB955C*)L_5, NULL);
		RuntimeObject* L_7 = p1;
		NullCheck((SreStMNJSUKnhiFeYdCnZvaTqzgO_tCAADFAF41D7399BA1A417D5051C817A325FB955C*)L_7);
		intptr_t L_8;
		L_8 = SreStMNJSUKnhiFeYdCnZvaTqzgO_RvQYOisGQgIvOvSNNcOyLAzxJwjg_m5F546A28798410BFAA6391AF7BDAA858B6015EDF((SreStMNJSUKnhiFeYdCnZvaTqzgO_tCAADFAF41D7399BA1A417D5051C817A325FB955C*)L_7, NULL);
		bool L_9;
		L_9 = IntPtr_op_Equality_m73759B51FE326460AC87A0E386480226EF2FABED(L_6, L_8, NULL);
		return L_9;
	}
}
// ? gPqZAArEBWUnolRtZlCKNFZvRLqr::hqxaqnfjyXPVfaFGFMfgnDklRtik<System.Object>()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* gPqZAArEBWUnolRtZlCKNFZvRLqr_hqxaqnfjyXPVfaFGFMfgnDklRtik_TisRuntimeObject_m4D5B26ED4697CD45D846ECFBBCE269C902F11FA5_gshared (gPqZAArEBWUnolRtZlCKNFZvRLqr_tF91080EAD5330A023C3CBFFB01A8F1A45A0BDC0A* __this, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Type_t_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
{
		RuntimeTypeHandle_t332A452B8B6179E4469B69525D0FE82A88030F7B L_0 = { reinterpret_cast<intptr_t> (il2cpp_rgctx_type(method->rgctx_data, 0)) };
		il2cpp_codegen_runtime_class_init_inline(Type_t_il2cpp_TypeInfo_var);
		Type_t* L_1;
		L_1 = Type_GetTypeFromHandle_m2570A2A5B32A5E9D9F0F38B37459DA18736C823E(L_0, NULL);
		Guid_t L_2;
		L_2 = SNtVQFAVepBYrsfSLlQlIciPNQPo_kkPaojCcdHqsRGgreFJXfDnuxeQhB_m397E610FE4478212D5BC87EFEB4B503C872F4D1F(L_1, NULL);
		intptr_t L_3;
		L_3 = VirtualFuncInvoker1< intptr_t, Guid_t >::Invoke(13 /* System.IntPtr gPqZAArEBWUnolRtZlCKNFZvRLqr::hqxaqnfjyXPVfaFGFMfgnDklRtik(System.Guid) */, __this, L_2);
		RuntimeObject* L_4;
		L_4 = ((  RuntimeObject* (*) (intptr_t, const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->rgctx_data, 1)))(L_3, il2cpp_rgctx_method(method->rgctx_data, 1));
		return L_4;
	}
}
// ? gPqZAArEBWUnolRtZlCKNFZvRLqr::hqxaqnfjyXPVfaFGFMfgnDklRtik<System.Object>(System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* gPqZAArEBWUnolRtZlCKNFZvRLqr_hqxaqnfjyXPVfaFGFMfgnDklRtik_TisRuntimeObject_m96563962668702B444F77E2204C23A2C1B6412E1_gshared (intptr_t p0, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IntPtr_t_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Marshal_tD976A56A90263C3CE2B780D4B1CADADE2E70B4A7_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Type_t_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&jQwkwLndXmHLkjaQEggMxbWuzWBN_t16BA183769603E5AC3E1A5CD0B747D26A4A7934F_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
Guid_t V_0;
	memset((&V_0), 0, sizeof(V_0));
	intptr_t V_1;
	memset((&V_1), 0, sizeof(V_1));
	jQwkwLndXmHLkjaQEggMxbWuzWBN_t16BA183769603E5AC3E1A5CD0B747D26A4A7934F V_2;
	memset((&V_2), 0, sizeof(V_2));
	RuntimeObject* V_3 = NULL;
	{
		intptr_t L_0 = p0;
		bool L_1;
		L_1 = IntPtr_op_Equality_m73759B51FE326460AC87A0E386480226EF2FABED(L_0, (0), NULL);
		if (!L_1)
		{
			goto IL_0017;
		}
	}
	{
		il2cpp_codegen_initobj((&V_3), sizeof(RuntimeObject*));
		RuntimeObject* L_2 = V_3;
		return L_2;
	}

IL_0017:
	{
		RuntimeTypeHandle_t332A452B8B6179E4469B69525D0FE82A88030F7B L_3 = { reinterpret_cast<intptr_t> (il2cpp_rgctx_type(method->rgctx_data, 0)) };
		il2cpp_codegen_runtime_class_init_inline(Type_t_il2cpp_TypeInfo_var);
		Type_t* L_4;
		L_4 = Type_GetTypeFromHandle_m2570A2A5B32A5E9D9F0F38B37459DA18736C823E(L_3, NULL);
		Guid_t L_5;
		L_5 = SNtVQFAVepBYrsfSLlQlIciPNQPo_kkPaojCcdHqsRGgreFJXfDnuxeQhB_m397E610FE4478212D5BC87EFEB4B503C872F4D1F(L_4, NULL);
		V_0 = L_5;
		intptr_t L_6 = p0;
		il2cpp_codegen_runtime_class_init_inline(Marshal_tD976A56A90263C3CE2B780D4B1CADADE2E70B4A7_il2cpp_TypeInfo_var);
		int32_t L_7;
		L_7 = Marshal_QueryInterface_m12604B22FC92D98F167C3E4F3A9200CBD40F9496(L_6, (&V_0), (&V_1), NULL);
		il2cpp_codegen_runtime_class_init_inline(jQwkwLndXmHLkjaQEggMxbWuzWBN_t16BA183769603E5AC3E1A5CD0B747D26A4A7934F_il2cpp_TypeInfo_var);
		jQwkwLndXmHLkjaQEggMxbWuzWBN_t16BA183769603E5AC3E1A5CD0B747D26A4A7934F L_8;
		L_8 = jQwkwLndXmHLkjaQEggMxbWuzWBN_TmcbGdEgTCEdxnYFXmldUVLQqBQBA_m35ED599133445CF4D0FFA156696B50F15B13F1DC(L_7, NULL);
		V_2 = L_8;
		bool L_9;
		L_9 = jQwkwLndXmHLkjaQEggMxbWuzWBN_HcELlOfrApWyyMtVwDHKKfTDlulQ_m6FE4EFBA67EB670A236EAA5D7E5D4ADB680DE8C0((&V_2), NULL);
		if (L_9)
		{
			goto IL_0047;
		}
	}
	{
		intptr_t L_10 = V_1;
		RuntimeObject* L_11;
		L_11 = ((  RuntimeObject* (*) (intptr_t, const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->rgctx_data, 1)))(L_10, il2cpp_rgctx_method(method->rgctx_data, 1));
		return L_11;
	}

IL_0047:
	{
		il2cpp_codegen_initobj((&V_3), sizeof(RuntimeObject*));
		RuntimeObject* L_12 = V_3;
		return L_12;
	}
}
// ? gPqZAArEBWUnolRtZlCKNFZvRLqr::sDakqjynGbkKPNRXxJKarKGFCeShA<System.Object>()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* gPqZAArEBWUnolRtZlCKNFZvRLqr_sDakqjynGbkKPNRXxJKarKGFCeShA_TisRuntimeObject_m0714520AEE636167FA92E7115A62EE88D5E48727_gshared (gPqZAArEBWUnolRtZlCKNFZvRLqr_tF91080EAD5330A023C3CBFFB01A8F1A45A0BDC0A* __this, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Type_t_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
intptr_t V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		RuntimeTypeHandle_t332A452B8B6179E4469B69525D0FE82A88030F7B L_0 = { reinterpret_cast<intptr_t> (il2cpp_rgctx_type(method->rgctx_data, 0)) };
		il2cpp_codegen_runtime_class_init_inline(Type_t_il2cpp_TypeInfo_var);
		Type_t* L_1;
		L_1 = Type_GetTypeFromHandle_m2570A2A5B32A5E9D9F0F38B37459DA18736C823E(L_0, NULL);
		Guid_t L_2;
		L_2 = SNtVQFAVepBYrsfSLlQlIciPNQPo_kkPaojCcdHqsRGgreFJXfDnuxeQhB_m397E610FE4478212D5BC87EFEB4B503C872F4D1F(L_1, NULL);
		VirtualActionInvoker2< Guid_t, intptr_t* >::Invoke(12 /* System.Void gPqZAArEBWUnolRtZlCKNFZvRLqr::sDakqjynGbkKPNRXxJKarKGFCeShA(System.Guid,System.IntPtr&) */, __this, L_2, (&V_0));
		intptr_t L_3 = V_0;
		RuntimeObject* L_4;
		L_4 = ((  RuntimeObject* (*) (intptr_t, const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->rgctx_data, 1)))(L_3, il2cpp_rgctx_method(method->rgctx_data, 1));
		return L_4;
	}
}
// ? gPqZAArEBWUnolRtZlCKNFZvRLqr::sDakqjynGbkKPNRXxJKarKGFCeShA<System.Object>(System.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* gPqZAArEBWUnolRtZlCKNFZvRLqr_sDakqjynGbkKPNRXxJKarKGFCeShA_TisRuntimeObject_m1A4B4813D718C3C8EE3C8C79923C9A015576034C_gshared (RuntimeObject* p0, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IDisposable_t030E0496B4E0E4E4F086825007979AF51F7248C5_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Marshal_tD976A56A90263C3CE2B780D4B1CADADE2E70B4A7_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&gPqZAArEBWUnolRtZlCKNFZvRLqr_tF91080EAD5330A023C3CBFFB01A8F1A45A0BDC0A_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
gPqZAArEBWUnolRtZlCKNFZvRLqr_tF91080EAD5330A023C3CBFFB01A8F1A45A0BDC0A* V_0 = NULL;
	RuntimeObject* V_1 = NULL;
	{
		RuntimeObject* L_0 = p0;
		il2cpp_codegen_runtime_class_init_inline(Marshal_tD976A56A90263C3CE2B780D4B1CADADE2E70B4A7_il2cpp_TypeInfo_var);
		intptr_t L_1;
		L_1 = il2cpp_codegen_com_get_iunknown_for_object(L_0);
		gPqZAArEBWUnolRtZlCKNFZvRLqr_tF91080EAD5330A023C3CBFFB01A8F1A45A0BDC0A* L_2 = (gPqZAArEBWUnolRtZlCKNFZvRLqr_tF91080EAD5330A023C3CBFFB01A8F1A45A0BDC0A*)il2cpp_codegen_object_new(gPqZAArEBWUnolRtZlCKNFZvRLqr_tF91080EAD5330A023C3CBFFB01A8F1A45A0BDC0A_il2cpp_TypeInfo_var);
		gPqZAArEBWUnolRtZlCKNFZvRLqr__ctor_mA7CAA7F0171ED7E041E6DCE615ACDEFC63FA6432(L_2, L_1, /*hidden argument*/NULL);
		V_0 = L_2;
	}

IL_000c:
	{
		auto __finallyBlock = il2cpp::utils::Finally([&]
		{

FINALLY_0015:
			{// begin finally (depth: 1)
				{
					gPqZAArEBWUnolRtZlCKNFZvRLqr_tF91080EAD5330A023C3CBFFB01A8F1A45A0BDC0A* L_3 = V_0;
					if (!L_3)
					{
						goto IL_001e;
					}
				}

IL_0018:
				{
					gPqZAArEBWUnolRtZlCKNFZvRLqr_tF91080EAD5330A023C3CBFFB01A8F1A45A0BDC0A* L_4 = V_0;
					NullCheck((RuntimeObject*)L_4);
					InterfaceActionInvoker0::Invoke(0 /* System.Void System.IDisposable::Dispose() */, IDisposable_t030E0496B4E0E4E4F086825007979AF51F7248C5_il2cpp_TypeInfo_var, (RuntimeObject*)L_4);
				}

IL_001e:
				{
					return;
				}
			}// end finally (depth: 1)
		});
		try
		{// begin try (depth: 1)
			gPqZAArEBWUnolRtZlCKNFZvRLqr_tF91080EAD5330A023C3CBFFB01A8F1A45A0BDC0A* L_5 = V_0;
			NullCheck(L_5);
			RuntimeObject* L_6;
			L_6 = GenericVirtualFuncInvoker0< RuntimeObject* >::Invoke(il2cpp_rgctx_method(method->rgctx_data, 0), L_5);
			V_1 = L_6;
			goto IL_001f;
		}// end try (depth: 1)
		catch(Il2CppExceptionWrapper& e)
		{
			__finallyBlock.StoreException(e.ex);
		}
	}

IL_001f:
	{
		RuntimeObject* L_7 = V_1;
		return L_7;
	}
}
// System.Void gPqZAArEBWUnolRtZlCKNFZvRLqr::soZfKWHyECtkfpEMElfGlqXjnmSE<System.Object>(?)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void gPqZAArEBWUnolRtZlCKNFZvRLqr_soZfKWHyECtkfpEMElfGlqXjnmSE_TisRuntimeObject_mF4D41D8FCBEE5B3DA28F6BF56EC17A2A58D77531_gshared (gPqZAArEBWUnolRtZlCKNFZvRLqr_tF91080EAD5330A023C3CBFFB01A8F1A45A0BDC0A* __this, RuntimeObject* p0, const RuntimeMethod* method) 
{
intptr_t V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		RuntimeObject* L_0 = p0;
		NullCheck((RuntimeObject*)__this);
		Type_t* L_1;
		L_1 = Object_GetType_mE10A8FC1E57F3DF29972CCBC026C2DC3942263B3((RuntimeObject*)__this, NULL);
		Guid_t L_2;
		L_2 = SNtVQFAVepBYrsfSLlQlIciPNQPo_kkPaojCcdHqsRGgreFJXfDnuxeQhB_m397E610FE4478212D5BC87EFEB4B503C872F4D1F(L_1, NULL);
		NullCheck((gPqZAArEBWUnolRtZlCKNFZvRLqr_tF91080EAD5330A023C3CBFFB01A8F1A45A0BDC0A*)L_0);
		VirtualActionInvoker2< Guid_t, intptr_t* >::Invoke(12 /* System.Void gPqZAArEBWUnolRtZlCKNFZvRLqr::sDakqjynGbkKPNRXxJKarKGFCeShA(System.Guid,System.IntPtr&) */, (gPqZAArEBWUnolRtZlCKNFZvRLqr_tF91080EAD5330A023C3CBFFB01A8F1A45A0BDC0A*)L_0, L_2, (&V_0));
		intptr_t L_3 = V_0;
		NullCheck((SreStMNJSUKnhiFeYdCnZvaTqzgO_tCAADFAF41D7399BA1A417D5051C817A325FB955C*)__this);
		SreStMNJSUKnhiFeYdCnZvaTqzgO_ZjlSOCsDECEgYbDhWggTIVTxxSgAb_m886E670065256506479F17121D58EF8503FCC1E4((SreStMNJSUKnhiFeYdCnZvaTqzgO_tCAADFAF41D7399BA1A417D5051C817A325FB955C*)__this, L_3, NULL);
		return;
	}
}
// ? gPqZAArEBWUnolRtZlCKNFZvRLqr::zLJKQmKgtAjiowOHEjHuJWQvuQgx<System.Object>()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* gPqZAArEBWUnolRtZlCKNFZvRLqr_zLJKQmKgtAjiowOHEjHuJWQvuQgx_TisRuntimeObject_m6CCF84E808AD28408914429D06AE6551AF1F41D3_gshared (gPqZAArEBWUnolRtZlCKNFZvRLqr_tF91080EAD5330A023C3CBFFB01A8F1A45A0BDC0A* __this, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Type_t_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
intptr_t V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		RuntimeTypeHandle_t332A452B8B6179E4469B69525D0FE82A88030F7B L_0 = { reinterpret_cast<intptr_t> (il2cpp_rgctx_type(method->rgctx_data, 0)) };
		il2cpp_codegen_runtime_class_init_inline(Type_t_il2cpp_TypeInfo_var);
		Type_t* L_1;
		L_1 = Type_GetTypeFromHandle_m2570A2A5B32A5E9D9F0F38B37459DA18736C823E(L_0, NULL);
		Guid_t L_2;
		L_2 = SNtVQFAVepBYrsfSLlQlIciPNQPo_kkPaojCcdHqsRGgreFJXfDnuxeQhB_m397E610FE4478212D5BC87EFEB4B503C872F4D1F(L_1, NULL);
		VirtualActionInvoker2< Guid_t, intptr_t* >::Invoke(12 /* System.Void gPqZAArEBWUnolRtZlCKNFZvRLqr::sDakqjynGbkKPNRXxJKarKGFCeShA(System.Guid,System.IntPtr&) */, __this, L_2, (&V_0));
		intptr_t L_3 = V_0;
		RuntimeObject* L_4;
		L_4 = ((  RuntimeObject* (*) (intptr_t, const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->rgctx_data, 1)))(L_3, il2cpp_rgctx_method(method->rgctx_data, 1));
		return L_4;
	}
}
// ? gRfTGJhxieuOzGUxjqzzxNNmLUuF::EbfdinkoZokdjHZQAzRBHIhcWPWy<System.Object>()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* gRfTGJhxieuOzGUxjqzzxNNmLUuF_EbfdinkoZokdjHZQAzRBHIhcWPWy_TisRuntimeObject_m502A631717711613CA30CE0CA9783799D8C2D8D5_gshared (gRfTGJhxieuOzGUxjqzzxNNmLUuF_t7BBB41BAB66EDE0363D72C224F9B9ABD3F60154A* __this, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Type_t_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&gRfTGJhxieuOzGUxjqzzxNNmLUuF_t7BBB41BAB66EDE0363D72C224F9B9ABD3F60154A_0_0_0_var);
		s_Il2CppMethodInitialized = true;
	}
void* V_0 = NULL;
	ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* V_1 = NULL;
	RuntimeObject* V_2 = NULL;
	{
		NullCheck((RuntimeObject*)__this);
		Type_t* L_0;
		L_0 = Object_GetType_mE10A8FC1E57F3DF29972CCBC026C2DC3942263B3((RuntimeObject*)__this, NULL);
		RuntimeTypeHandle_t332A452B8B6179E4469B69525D0FE82A88030F7B L_1 = { reinterpret_cast<intptr_t> (il2cpp_rgctx_type(method->rgctx_data, 0)) };
		il2cpp_codegen_runtime_class_init_inline(Type_t_il2cpp_TypeInfo_var);
		Type_t* L_2;
		L_2 = Type_GetTypeFromHandle_m2570A2A5B32A5E9D9F0F38B37459DA18736C823E(L_1, NULL);
		if ((!(((RuntimeObject*)(Type_t*)L_0) == ((RuntimeObject*)(Type_t*)L_2))))
		{
			goto IL_0019;
		}
	}
	{
		return ((RuntimeObject*)Castclass((RuntimeObject*)__this, il2cpp_rgctx_data(method->rgctx_data, 1)));
	}

IL_0019:
	{
		NullCheck((RuntimeObject*)__this);
		Type_t* L_3;
		L_3 = Object_GetType_mE10A8FC1E57F3DF29972CCBC026C2DC3942263B3((RuntimeObject*)__this, NULL);
		RuntimeTypeHandle_t332A452B8B6179E4469B69525D0FE82A88030F7B L_4 = { reinterpret_cast<intptr_t> (gRfTGJhxieuOzGUxjqzzxNNmLUuF_t7BBB41BAB66EDE0363D72C224F9B9ABD3F60154A_0_0_0_var) };
		il2cpp_codegen_runtime_class_init_inline(Type_t_il2cpp_TypeInfo_var);
		Type_t* L_5;
		L_5 = Type_GetTypeFromHandle_m2570A2A5B32A5E9D9F0F38B37459DA18736C823E(L_4, NULL);
		if ((!(((RuntimeObject*)(Type_t*)L_3) == ((RuntimeObject*)(Type_t*)L_5))))
		{
			goto IL_0069;
		}
	}
	{
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_6 = (ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031*)__this->___VmWtSTvLARmhSSbKAWvXCQEJhSPE_1;
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_7 = L_6;
		V_1 = L_7;
		if (!L_7)
		{
			goto IL_003a;
		}
	}
	{
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_8 = V_1;
		NullCheck(L_8);
		if (((int32_t)(((RuntimeArray*)L_8)->max_length)))
		{
			goto IL_003f;
		}
	}

IL_003a:
	{
		V_0 = (void*)((uintptr_t)0);
		goto IL_0048;
	}

IL_003f:
	{
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_9 = V_1;
		NullCheck(L_9);
		V_0 = (void*)((uintptr_t)((L_9)->GetAddressAt(static_cast<il2cpp_array_size_t>(0))));
	}

IL_0048:
	{
		RuntimeObject* L_10;
		L_10 = ((  RuntimeObject* (*) (const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->rgctx_data, 2)))(il2cpp_rgctx_method(method->rgctx_data, 2));
		int32_t L_11 = (int32_t)__this->___IbDAAQayZlvTFeAWaKRWpsHubZQo_0;
		void* L_12 = V_0;
		intptr_t L_13;
		L_13 = IntPtr_op_Explicit_m04BEF6277775C13DD8A986812AAA3FCEC32DCCBE(L_12, NULL);
		NullCheck((gRfTGJhxieuOzGUxjqzzxNNmLUuF_t7BBB41BAB66EDE0363D72C224F9B9ABD3F60154A*)L_10);
		gRfTGJhxieuOzGUxjqzzxNNmLUuF_t7BBB41BAB66EDE0363D72C224F9B9ABD3F60154A* L_14;
		L_14 = VirtualFuncInvoker2< gRfTGJhxieuOzGUxjqzzxNNmLUuF_t7BBB41BAB66EDE0363D72C224F9B9ABD3F60154A*, int32_t, intptr_t >::Invoke(4 /* gRfTGJhxieuOzGUxjqzzxNNmLUuF gRfTGJhxieuOzGUxjqzzxNNmLUuF::jxJiMmvyOFKmhGbCiaCAeprHnJUMA(System.Int32,System.IntPtr) */, (gRfTGJhxieuOzGUxjqzzxNNmLUuF_t7BBB41BAB66EDE0363D72C224F9B9ABD3F60154A*)L_10, L_11, L_13);
		return ((RuntimeObject*)Castclass((RuntimeObject*)L_14, il2cpp_rgctx_data(method->rgctx_data, 1)));
	}

IL_0069:
	{
		il2cpp_codegen_initobj((&V_2), sizeof(RuntimeObject*));
		RuntimeObject* L_15 = V_2;
		return L_15;
	}
}
// ? lLgbcxLBAtuIApfgJDnOczdnMIEtA::sKqdORiyViYnRiAizQbEnAiCVBiuA<System.Object>(System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* lLgbcxLBAtuIApfgJDnOczdnMIEtA_sKqdORiyViYnRiAizQbEnAiCVBiuA_TisRuntimeObject_mDFADEECE492B37A9921B7B5D065023BB951CAE14_gshared (intptr_t p0, const RuntimeMethod* method) 
{
GCHandle_tC44F6F72EE68BD4CFABA24309DA7A179D41127DC V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		intptr_t L_0 = p0;
		void* L_1;
		L_1 = IntPtr_op_Explicit_m693F2F9E685EE117D4AC080342B8959DAF684294(L_0, NULL);
		uint32_t L_2 = sizeof(intptr_t);
		GCHandle_tC44F6F72EE68BD4CFABA24309DA7A179D41127DC L_3;
		L_3 = GCHandle_FromIntPtr_mB3E9C10177B3A0986B72C44D7E123F60125824DF((*((intptr_t*)((void*)il2cpp_codegen_add((intptr_t)L_1, (int32_t)L_2)))), NULL);
		V_0 = L_3;
		RuntimeObject* L_4;
		L_4 = GCHandle_get_Target_m481F9508DA5E384D33CD1F4450060DC56BBD4CD5((&V_0), NULL);
		return ((RuntimeObject*)Castclass((RuntimeObject*)L_4, il2cpp_rgctx_data(method->rgctx_data, 0)));
	}
}
// Rewired.ControllerType uhuWHhUlIbNFBnRrnehXuaQSuHHd::DTDMBUYQupnORvMjRfLUcfFYMkdXA<System.Object>()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t uhuWHhUlIbNFBnRrnehXuaQSuHHd_DTDMBUYQupnORvMjRfLUcfFYMkdXA_TisRuntimeObject_m4456CFD44DE27ADA0BBE0ED257D13F71A61AD53B_gshared (const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Type_t_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
{
		RuntimeTypeHandle_t332A452B8B6179E4469B69525D0FE82A88030F7B L_0 = { reinterpret_cast<intptr_t> (il2cpp_rgctx_type(method->rgctx_data, 0)) };
		il2cpp_codegen_runtime_class_init_inline(Type_t_il2cpp_TypeInfo_var);
		Type_t* L_1;
		L_1 = Type_GetTypeFromHandle_m2570A2A5B32A5E9D9F0F38B37459DA18736C823E(L_0, NULL);
		int32_t L_2;
		L_2 = uhuWHhUlIbNFBnRrnehXuaQSuHHd_DTDMBUYQupnORvMjRfLUcfFYMkdXA_mD6AA70FD03DCB38F2C0C0DE32468293A8B0BE0F8(L_1, NULL);
		return L_2;
	}
}
// System.Type uhuWHhUlIbNFBnRrnehXuaQSuHHd::JchCXXCUQHhByASRcEKTQGZvqYmGb<System.Object>()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Type_t* uhuWHhUlIbNFBnRrnehXuaQSuHHd_JchCXXCUQHhByASRcEKTQGZvqYmGb_TisRuntimeObject_mCC9FEC55AC3E1C1ECBBBEEF314622543090F9A62_gshared (const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Type_t_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
{
		RuntimeTypeHandle_t332A452B8B6179E4469B69525D0FE82A88030F7B L_0 = { reinterpret_cast<intptr_t> (il2cpp_rgctx_type(method->rgctx_data, 0)) };
		il2cpp_codegen_runtime_class_init_inline(Type_t_il2cpp_TypeInfo_var);
		Type_t* L_1;
		L_1 = Type_GetTypeFromHandle_m2570A2A5B32A5E9D9F0F38B37459DA18736C823E(L_0, NULL);
		Type_t* L_2;
		L_2 = uhuWHhUlIbNFBnRrnehXuaQSuHHd_JchCXXCUQHhByASRcEKTQGZvqYmGb_m9BAFCF72BACC6271D08DC383F4CB3D542075428B(L_1, NULL);
		return L_2;
	}
}
// System.Boolean uhuWHhUlIbNFBnRrnehXuaQSuHHd::TTQrDbVkNAShZUgQnZkcLsiPAwAp<System.Object>(Rewired.ControllerType&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool uhuWHhUlIbNFBnRrnehXuaQSuHHd_TTQrDbVkNAShZUgQnZkcLsiPAwAp_TisRuntimeObject_mB4A620B5B28EEBD33911991F070DD58D6731FAC4_gshared (int32_t* p0, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Type_t_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
{
		RuntimeTypeHandle_t332A452B8B6179E4469B69525D0FE82A88030F7B L_0 = { reinterpret_cast<intptr_t> (il2cpp_rgctx_type(method->rgctx_data, 0)) };
		il2cpp_codegen_runtime_class_init_inline(Type_t_il2cpp_TypeInfo_var);
		Type_t* L_1;
		L_1 = Type_GetTypeFromHandle_m2570A2A5B32A5E9D9F0F38B37459DA18736C823E(L_0, NULL);
		int32_t* L_2 = p0;
		bool L_3;
		L_3 = uhuWHhUlIbNFBnRrnehXuaQSuHHd_TTQrDbVkNAShZUgQnZkcLsiPAwAp_m2EA98EFD549BF2117BF460D6DD9F247975A17C69(L_1, L_2, NULL);
		return L_3;
	}
}
// Rewired.ControllerType uhuWHhUlIbNFBnRrnehXuaQSuHHd::ZHWqunaUMMiRUtHUuOTisgVjhUuA<System.Object>()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t uhuWHhUlIbNFBnRrnehXuaQSuHHd_ZHWqunaUMMiRUtHUuOTisgVjhUuA_TisRuntimeObject_mD49442984DB48559E452443BA6FA36CA754E0CB1_gshared (const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Type_t_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
{
		RuntimeTypeHandle_t332A452B8B6179E4469B69525D0FE82A88030F7B L_0 = { reinterpret_cast<intptr_t> (il2cpp_rgctx_type(method->rgctx_data, 0)) };
		il2cpp_codegen_runtime_class_init_inline(Type_t_il2cpp_TypeInfo_var);
		Type_t* L_1;
		L_1 = Type_GetTypeFromHandle_m2570A2A5B32A5E9D9F0F38B37459DA18736C823E(L_0, NULL);
		int32_t L_2;
		L_2 = uhuWHhUlIbNFBnRrnehXuaQSuHHd_ZHWqunaUMMiRUtHUuOTisgVjhUuA_m38C1885F31B935E67983411F30CCA5B0464BBBEB(L_1, NULL);
		return L_2;
	}
}
// Rewired.ControllerType uhuWHhUlIbNFBnRrnehXuaQSuHHd::tuzEObbxQcmGBxissXpBnVmdqsiP<System.Object>()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t uhuWHhUlIbNFBnRrnehXuaQSuHHd_tuzEObbxQcmGBxissXpBnVmdqsiP_TisRuntimeObject_mC07A262540F0402BEEDF6963932588F4EAF08584_gshared (const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Type_t_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
{
		RuntimeTypeHandle_t332A452B8B6179E4469B69525D0FE82A88030F7B L_0 = { reinterpret_cast<intptr_t> (il2cpp_rgctx_type(method->rgctx_data, 0)) };
		il2cpp_codegen_runtime_class_init_inline(Type_t_il2cpp_TypeInfo_var);
		Type_t* L_1;
		L_1 = Type_GetTypeFromHandle_m2570A2A5B32A5E9D9F0F38B37459DA18736C823E(L_0, NULL);
		int32_t L_2;
		L_2 = uhuWHhUlIbNFBnRrnehXuaQSuHHd_tuzEObbxQcmGBxissXpBnVmdqsiP_m96402B3C0ECF97BB5CB3FD4B15CA301CFB9461CC(L_1, NULL);
		return L_2;
	}
}
// ? Rewired.Controller/CompoundElement::PpZZMAbmwQeYtHeNayVCJiOBVHdL<System.Object>(System.Int32,System.Int32&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* CompoundElement_PpZZMAbmwQeYtHeNayVCJiOBVHdL_TisRuntimeObject_mE71EAF9CE3FAF1ED51DDE946446224CFB6421CE1_gshared (CompoundElement_t13DDF83F927A6EF07A34A4A70E3C7DF93F726576* __this, int32_t p0, int32_t* p1, const RuntimeMethod* method) 
{
RuntimeObject* V_0 = NULL;
	{
		int32_t* L_0 = p1;
		*((int32_t*)L_0) = (int32_t)(-1);
		int32_t L_1 = p0;
		if ((((int32_t)L_1) < ((int32_t)0)))
		{
			goto IL_0012;
		}
	}
	{
		int32_t L_2 = p0;
		kfzfjnagLVVtsyAzdAlUhZdNuSIQAU5BU5D_tEEB780C862E2161EBC7C54D3F94963F74723F9AB* L_3 = (kfzfjnagLVVtsyAzdAlUhZdNuSIQAU5BU5D_tEEB780C862E2161EBC7C54D3F94963F74723F9AB*)__this->___IvMWItGTIMgpzxlakIFhxQRLuqob_4;
		NullCheck(L_3);
		if ((((int32_t)L_2) < ((int32_t)((int32_t)(((RuntimeArray*)L_3)->max_length)))))
		{
			goto IL_001c;
		}
	}

IL_0012:
	{
		il2cpp_codegen_initobj((&V_0), sizeof(RuntimeObject*));
		RuntimeObject* L_4 = V_0;
		return L_4;
	}

IL_001c:
	{
		kfzfjnagLVVtsyAzdAlUhZdNuSIQAU5BU5D_tEEB780C862E2161EBC7C54D3F94963F74723F9AB* L_5 = (kfzfjnagLVVtsyAzdAlUhZdNuSIQAU5BU5D_tEEB780C862E2161EBC7C54D3F94963F74723F9AB*)__this->___IvMWItGTIMgpzxlakIFhxQRLuqob_4;
		int32_t L_6 = p0;
		NullCheck(L_5);
		int32_t L_7 = L_6;
		kfzfjnagLVVtsyAzdAlUhZdNuSIQA_tCE87DA4E243A151D523511BE81757930A8E88FBE* L_8 = (L_5)->GetAt(static_cast<il2cpp_array_size_t>(L_7));
		if (L_8)
		{
			goto IL_0030;
		}
	}
	{
		il2cpp_codegen_initobj((&V_0), sizeof(RuntimeObject*));
		RuntimeObject* L_9 = V_0;
		return L_9;
	}

IL_0030:
	{
		int32_t* L_10 = p1;
		kfzfjnagLVVtsyAzdAlUhZdNuSIQAU5BU5D_tEEB780C862E2161EBC7C54D3F94963F74723F9AB* L_11 = (kfzfjnagLVVtsyAzdAlUhZdNuSIQAU5BU5D_tEEB780C862E2161EBC7C54D3F94963F74723F9AB*)__this->___IvMWItGTIMgpzxlakIFhxQRLuqob_4;
		int32_t L_12 = p0;
		NullCheck(L_11);
		int32_t L_13 = L_12;
		kfzfjnagLVVtsyAzdAlUhZdNuSIQA_tCE87DA4E243A151D523511BE81757930A8E88FBE* L_14 = (L_11)->GetAt(static_cast<il2cpp_array_size_t>(L_13));
		NullCheck(L_14);
		int32_t L_15 = (int32_t)L_14->___PfGQtAPPZODaxbJRsuZqkEEwnCcW_1;
		*((int32_t*)L_10) = (int32_t)L_15;
		kfzfjnagLVVtsyAzdAlUhZdNuSIQAU5BU5D_tEEB780C862E2161EBC7C54D3F94963F74723F9AB* L_16 = (kfzfjnagLVVtsyAzdAlUhZdNuSIQAU5BU5D_tEEB780C862E2161EBC7C54D3F94963F74723F9AB*)__this->___IvMWItGTIMgpzxlakIFhxQRLuqob_4;
		int32_t L_17 = p0;
		NullCheck(L_16);
		int32_t L_18 = L_17;
		kfzfjnagLVVtsyAzdAlUhZdNuSIQA_tCE87DA4E243A151D523511BE81757930A8E88FBE* L_19 = (L_16)->GetAt(static_cast<il2cpp_array_size_t>(L_18));
		NullCheck(L_19);
		Element_t58CB6D4FDC2FDD69AC192D19F0F9531FE3F01F76* L_20 = (Element_t58CB6D4FDC2FDD69AC192D19F0F9531FE3F01F76*)L_19->___yKCXOltRimSKhLFgTEKGJTpBiWpb_0;
		return ((RuntimeObject*)Castclass((RuntimeObject*)((RuntimeObject*)IsInst((RuntimeObject*)L_20, il2cpp_rgctx_data(method->rgctx_data, 0))), il2cpp_rgctx_data(method->rgctx_data, 0)));
	}
}
// ? Rewired.Controller/CompoundElement::XjPzCjeHEKrmnInBxcqjiOQOEIgL<System.Object>(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* CompoundElement_XjPzCjeHEKrmnInBxcqjiOQOEIgL_TisRuntimeObject_m0FE7805E31A05B69B0CA54510769F2A8A8AF78CC_gshared (CompoundElement_t13DDF83F927A6EF07A34A4A70E3C7DF93F726576* __this, int32_t p0, const RuntimeMethod* method) 
{
RuntimeObject* V_0 = NULL;
	{
		int32_t L_0 = p0;
		if ((((int32_t)L_0) < ((int32_t)0)))
		{
			goto IL_000f;
		}
	}
	{
		int32_t L_1 = p0;
		kfzfjnagLVVtsyAzdAlUhZdNuSIQAU5BU5D_tEEB780C862E2161EBC7C54D3F94963F74723F9AB* L_2 = (kfzfjnagLVVtsyAzdAlUhZdNuSIQAU5BU5D_tEEB780C862E2161EBC7C54D3F94963F74723F9AB*)__this->___IvMWItGTIMgpzxlakIFhxQRLuqob_4;
		NullCheck(L_2);
		if ((((int32_t)L_1) < ((int32_t)((int32_t)(((RuntimeArray*)L_2)->max_length)))))
		{
			goto IL_0019;
		}
	}

IL_000f:
	{
		il2cpp_codegen_initobj((&V_0), sizeof(RuntimeObject*));
		RuntimeObject* L_3 = V_0;
		return L_3;
	}

IL_0019:
	{
		kfzfjnagLVVtsyAzdAlUhZdNuSIQAU5BU5D_tEEB780C862E2161EBC7C54D3F94963F74723F9AB* L_4 = (kfzfjnagLVVtsyAzdAlUhZdNuSIQAU5BU5D_tEEB780C862E2161EBC7C54D3F94963F74723F9AB*)__this->___IvMWItGTIMgpzxlakIFhxQRLuqob_4;
		int32_t L_5 = p0;
		NullCheck(L_4);
		int32_t L_6 = L_5;
		kfzfjnagLVVtsyAzdAlUhZdNuSIQA_tCE87DA4E243A151D523511BE81757930A8E88FBE* L_7 = (L_4)->GetAt(static_cast<il2cpp_array_size_t>(L_6));
		if (L_7)
		{
			goto IL_002d;
		}
	}
	{
		il2cpp_codegen_initobj((&V_0), sizeof(RuntimeObject*));
		RuntimeObject* L_8 = V_0;
		return L_8;
	}

IL_002d:
	{
		kfzfjnagLVVtsyAzdAlUhZdNuSIQAU5BU5D_tEEB780C862E2161EBC7C54D3F94963F74723F9AB* L_9 = (kfzfjnagLVVtsyAzdAlUhZdNuSIQAU5BU5D_tEEB780C862E2161EBC7C54D3F94963F74723F9AB*)__this->___IvMWItGTIMgpzxlakIFhxQRLuqob_4;
		int32_t L_10 = p0;
		NullCheck(L_9);
		int32_t L_11 = L_10;
		kfzfjnagLVVtsyAzdAlUhZdNuSIQA_tCE87DA4E243A151D523511BE81757930A8E88FBE* L_12 = (L_9)->GetAt(static_cast<il2cpp_array_size_t>(L_11));
		NullCheck(L_12);
		Element_t58CB6D4FDC2FDD69AC192D19F0F9531FE3F01F76* L_13 = (Element_t58CB6D4FDC2FDD69AC192D19F0F9531FE3F01F76*)L_12->___yKCXOltRimSKhLFgTEKGJTpBiWpb_0;
		return ((RuntimeObject*)Castclass((RuntimeObject*)((RuntimeObject*)IsInst((RuntimeObject*)L_13, il2cpp_rgctx_data(method->rgctx_data, 0))), il2cpp_rgctx_data(method->rgctx_data, 0)));
	}
}
// T Rewired.Controller/Extension::GetController<System.Object>()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* Extension_GetController_TisRuntimeObject_mB52B3A459EED0ECFDD4117623A5750F8A268238C_gshared (Extension_t65CC6FDD7104DC3F9E55C8238302E9F8870162F9* __this, const RuntimeMethod* method) 
{
RuntimeObject* V_0 = NULL;
	{
		Controller_t919A4A50FC7A0F25D7B31615C0F4E4D4A4D17911* L_0 = (Controller_t919A4A50FC7A0F25D7B31615C0F4E4D4A4D17911*)__this->___ANMamGTTJSCnGKAQdqGuVYErIycq_0;
		if (L_0)
		{
			goto IL_0012;
		}
	}
	{
		il2cpp_codegen_initobj((&V_0), sizeof(RuntimeObject*));
		RuntimeObject* L_1 = V_0;
		return L_1;
	}

IL_0012:
	{
		Controller_t919A4A50FC7A0F25D7B31615C0F4E4D4A4D17911* L_2 = (Controller_t919A4A50FC7A0F25D7B31615C0F4E4D4A4D17911*)__this->___ANMamGTTJSCnGKAQdqGuVYErIycq_0;
		return ((RuntimeObject*)Castclass((RuntimeObject*)((RuntimeObject*)IsInst((RuntimeObject*)L_2, il2cpp_rgctx_data(method->rgctx_data, 0))), il2cpp_rgctx_data(method->rgctx_data, 0)));
	}
}
// T Rewired.Data.Mapping.HardwareJoystickTemplateMap/SpecialElementEntry::Rewired.Data.Mapping.IControllerTemplateMapSpecialElement_Internal.GetMapping<System.Object>()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* SpecialElementEntry_Rewired_Data_Mapping_IControllerTemplateMapSpecialElement_Internal_GetMapping_TisRuntimeObject_m2699007DDFE4457022229D1424E30ACB80CF74DA_gshared (SpecialElementEntry_tC2A8F6C0EE9400318EA49260467DD0826D93AE8A* __this, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&JsonParser_t018B55D46F9F32673FE60644DC3AF9562EB538D8_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
RuntimeObject* V_0 = NULL;
	{
		String_t* L_0 = (String_t*)__this->___data_1;
		il2cpp_codegen_runtime_class_init_inline(JsonParser_t018B55D46F9F32673FE60644DC3AF9562EB538D8_il2cpp_TypeInfo_var);
		bool L_1;
		L_1 = ((  bool (*) (String_t*, RuntimeObject**, const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->rgctx_data, 0)))(L_0, (&V_0), il2cpp_rgctx_method(method->rgctx_data, 0));
		RuntimeObject* L_2 = V_0;
		return L_2;
	}
}
// TValue UnityEngine.InputSystem.InputAction/CallbackContext::ReadValue<UnityEngine.Quaternion>()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 CallbackContext_ReadValue_TisQuaternion_tDA59F214EF07D7700B26E40E562F267AF7306974_m020AD5873BB6CE85B752DF8D11920FA5FB46214E_gshared (CallbackContext_tB251EE41F509C6E8A6B05EC97C029A45DF4F5FA8* __this, const RuntimeMethod* method) 
{
Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		// var value = default(TValue);
		il2cpp_codegen_initobj((&V_0), sizeof(Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974));
		// if (m_State != null && phase.IsInProgress())
		InputActionState_t780948EA293BAA800AD8699518B58B59FFB8A700* L_0 = (InputActionState_t780948EA293BAA800AD8699518B58B59FFB8A700*)__this->___m_State_0;
		if (!L_0)
		{
			goto IL_0036;
		}
	}
	{
		int32_t L_1;
		L_1 = CallbackContext_get_phase_mBF36959BEB4B081303626F616535A84137580702(__this, NULL);
		bool L_2;
		L_2 = InputExtensions_IsInProgress_m37300A7A5E1CB6A168453B66EE234EA43530544F(L_1, NULL);
		if (!L_2)
		{
			goto IL_0036;
		}
	}
	{
		// value = m_State.ReadValue<TValue>(bindingIndex, controlIndex);
		InputActionState_t780948EA293BAA800AD8699518B58B59FFB8A700* L_3 = (InputActionState_t780948EA293BAA800AD8699518B58B59FFB8A700*)__this->___m_State_0;
		int32_t L_4;
		L_4 = CallbackContext_get_bindingIndex_mBC8952C9915010C5D8DB5FD69D089FFC49542FB1(__this, NULL);
		int32_t L_5;
		L_5 = CallbackContext_get_controlIndex_m25E107BD1CD3C1CBAA7FAA2ED2D11EA88491A04B(__this, NULL);
		NullCheck(L_3);
		Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 L_6;
		L_6 = ((  Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 (*) (InputActionState_t780948EA293BAA800AD8699518B58B59FFB8A700*, int32_t, int32_t, bool, const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->rgctx_data, 0)))(L_3, L_4, L_5, (bool)0, il2cpp_rgctx_method(method->rgctx_data, 0));
		V_0 = L_6;
	}

IL_0036:
	{
		// return value;
		Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 L_7 = V_0;
		return L_7;
	}
}
IL2CPP_EXTERN_C  Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 CallbackContext_ReadValue_TisQuaternion_tDA59F214EF07D7700B26E40E562F267AF7306974_m020AD5873BB6CE85B752DF8D11920FA5FB46214E_AdjustorThunk (RuntimeObject* __this, const RuntimeMethod* method)
{
CallbackContext_tB251EE41F509C6E8A6B05EC97C029A45DF4F5FA8* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<CallbackContext_tB251EE41F509C6E8A6B05EC97C029A45DF4F5FA8*>(__this + _offset);
	Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 _returnValue;
	_returnValue = CallbackContext_ReadValue_TisQuaternion_tDA59F214EF07D7700B26E40E562F267AF7306974_m020AD5873BB6CE85B752DF8D11920FA5FB46214E(_thisAdjusted, method);
	return _returnValue;
}
// TValue UnityEngine.InputSystem.InputAction/CallbackContext::ReadValue<System.Single>()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float CallbackContext_ReadValue_TisSingle_t4530F2FF86FCB0DC29F35385CA1BD21BE294761C_m7EBC8C123F0601CE5B340BA966923AEC449A8ACF_gshared (CallbackContext_tB251EE41F509C6E8A6B05EC97C029A45DF4F5FA8* __this, const RuntimeMethod* method) 
{
float V_0 = 0.0f;
	{
		// var value = default(TValue);
		il2cpp_codegen_initobj((&V_0), sizeof(float));
		// if (m_State != null && phase.IsInProgress())
		InputActionState_t780948EA293BAA800AD8699518B58B59FFB8A700* L_0 = (InputActionState_t780948EA293BAA800AD8699518B58B59FFB8A700*)__this->___m_State_0;
		if (!L_0)
		{
			goto IL_0036;
		}
	}
	{
		int32_t L_1;
		L_1 = CallbackContext_get_phase_mBF36959BEB4B081303626F616535A84137580702(__this, NULL);
		bool L_2;
		L_2 = InputExtensions_IsInProgress_m37300A7A5E1CB6A168453B66EE234EA43530544F(L_1, NULL);
		if (!L_2)
		{
			goto IL_0036;
		}
	}
	{
		// value = m_State.ReadValue<TValue>(bindingIndex, controlIndex);
		InputActionState_t780948EA293BAA800AD8699518B58B59FFB8A700* L_3 = (InputActionState_t780948EA293BAA800AD8699518B58B59FFB8A700*)__this->___m_State_0;
		int32_t L_4;
		L_4 = CallbackContext_get_bindingIndex_mBC8952C9915010C5D8DB5FD69D089FFC49542FB1(__this, NULL);
		int32_t L_5;
		L_5 = CallbackContext_get_controlIndex_m25E107BD1CD3C1CBAA7FAA2ED2D11EA88491A04B(__this, NULL);
		NullCheck(L_3);
		float L_6;
		L_6 = ((  float (*) (InputActionState_t780948EA293BAA800AD8699518B58B59FFB8A700*, int32_t, int32_t, bool, const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->rgctx_data, 0)))(L_3, L_4, L_5, (bool)0, il2cpp_rgctx_method(method->rgctx_data, 0));
		V_0 = L_6;
	}

IL_0036:
	{
		// return value;
		float L_7 = V_0;
		return L_7;
	}
}
IL2CPP_EXTERN_C  float CallbackContext_ReadValue_TisSingle_t4530F2FF86FCB0DC29F35385CA1BD21BE294761C_m7EBC8C123F0601CE5B340BA966923AEC449A8ACF_AdjustorThunk (RuntimeObject* __this, const RuntimeMethod* method)
{
CallbackContext_tB251EE41F509C6E8A6B05EC97C029A45DF4F5FA8* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<CallbackContext_tB251EE41F509C6E8A6B05EC97C029A45DF4F5FA8*>(__this + _offset);
	float _returnValue;
	_returnValue = CallbackContext_ReadValue_TisSingle_t4530F2FF86FCB0DC29F35385CA1BD21BE294761C_m7EBC8C123F0601CE5B340BA966923AEC449A8ACF(_thisAdjusted, method);
	return _returnValue;
}
// TValue UnityEngine.InputSystem.InputAction/CallbackContext::ReadValue<UnityEngine.Vector2>()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 CallbackContext_ReadValue_TisVector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7_m454ADEAE74A5A469E011CF78D6303A1034659830_gshared (CallbackContext_tB251EE41F509C6E8A6B05EC97C029A45DF4F5FA8* __this, const RuntimeMethod* method) 
{
Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		// var value = default(TValue);
		il2cpp_codegen_initobj((&V_0), sizeof(Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7));
		// if (m_State != null && phase.IsInProgress())
		InputActionState_t780948EA293BAA800AD8699518B58B59FFB8A700* L_0 = (InputActionState_t780948EA293BAA800AD8699518B58B59FFB8A700*)__this->___m_State_0;
		if (!L_0)
		{
			goto IL_0036;
		}
	}
	{
		int32_t L_1;
		L_1 = CallbackContext_get_phase_mBF36959BEB4B081303626F616535A84137580702(__this, NULL);
		bool L_2;
		L_2 = InputExtensions_IsInProgress_m37300A7A5E1CB6A168453B66EE234EA43530544F(L_1, NULL);
		if (!L_2)
		{
			goto IL_0036;
		}
	}
	{
		// value = m_State.ReadValue<TValue>(bindingIndex, controlIndex);
		InputActionState_t780948EA293BAA800AD8699518B58B59FFB8A700* L_3 = (InputActionState_t780948EA293BAA800AD8699518B58B59FFB8A700*)__this->___m_State_0;
		int32_t L_4;
		L_4 = CallbackContext_get_bindingIndex_mBC8952C9915010C5D8DB5FD69D089FFC49542FB1(__this, NULL);
		int32_t L_5;
		L_5 = CallbackContext_get_controlIndex_m25E107BD1CD3C1CBAA7FAA2ED2D11EA88491A04B(__this, NULL);
		NullCheck(L_3);
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_6;
		L_6 = ((  Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 (*) (InputActionState_t780948EA293BAA800AD8699518B58B59FFB8A700*, int32_t, int32_t, bool, const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->rgctx_data, 0)))(L_3, L_4, L_5, (bool)0, il2cpp_rgctx_method(method->rgctx_data, 0));
		V_0 = L_6;
	}

IL_0036:
	{
		// return value;
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_7 = V_0;
		return L_7;
	}
}
IL2CPP_EXTERN_C  Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 CallbackContext_ReadValue_TisVector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7_m454ADEAE74A5A469E011CF78D6303A1034659830_AdjustorThunk (RuntimeObject* __this, const RuntimeMethod* method)
{
CallbackContext_tB251EE41F509C6E8A6B05EC97C029A45DF4F5FA8* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<CallbackContext_tB251EE41F509C6E8A6B05EC97C029A45DF4F5FA8*>(__this + _offset);
	Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 _returnValue;
	_returnValue = CallbackContext_ReadValue_TisVector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7_m454ADEAE74A5A469E011CF78D6303A1034659830(_thisAdjusted, method);
	return _returnValue;
}
// TValue UnityEngine.InputSystem.InputAction/CallbackContext::ReadValue<UnityEngine.Vector3>()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 CallbackContext_ReadValue_TisVector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2_mC5704121342A8A761FA496E4922FDA7B37C20EDD_gshared (CallbackContext_tB251EE41F509C6E8A6B05EC97C029A45DF4F5FA8* __this, const RuntimeMethod* method) 
{
Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		// var value = default(TValue);
		il2cpp_codegen_initobj((&V_0), sizeof(Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2));
		// if (m_State != null && phase.IsInProgress())
		InputActionState_t780948EA293BAA800AD8699518B58B59FFB8A700* L_0 = (InputActionState_t780948EA293BAA800AD8699518B58B59FFB8A700*)__this->___m_State_0;
		if (!L_0)
		{
			goto IL_0036;
		}
	}
	{
		int32_t L_1;
		L_1 = CallbackContext_get_phase_mBF36959BEB4B081303626F616535A84137580702(__this, NULL);
		bool L_2;
		L_2 = InputExtensions_IsInProgress_m37300A7A5E1CB6A168453B66EE234EA43530544F(L_1, NULL);
		if (!L_2)
		{
			goto IL_0036;
		}
	}
	{
		// value = m_State.ReadValue<TValue>(bindingIndex, controlIndex);
		InputActionState_t780948EA293BAA800AD8699518B58B59FFB8A700* L_3 = (InputActionState_t780948EA293BAA800AD8699518B58B59FFB8A700*)__this->___m_State_0;
		int32_t L_4;
		L_4 = CallbackContext_get_bindingIndex_mBC8952C9915010C5D8DB5FD69D089FFC49542FB1(__this, NULL);
		int32_t L_5;
		L_5 = CallbackContext_get_controlIndex_m25E107BD1CD3C1CBAA7FAA2ED2D11EA88491A04B(__this, NULL);
		NullCheck(L_3);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_6;
		L_6 = ((  Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 (*) (InputActionState_t780948EA293BAA800AD8699518B58B59FFB8A700*, int32_t, int32_t, bool, const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->rgctx_data, 0)))(L_3, L_4, L_5, (bool)0, il2cpp_rgctx_method(method->rgctx_data, 0));
		V_0 = L_6;
	}

IL_0036:
	{
		// return value;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_7 = V_0;
		return L_7;
	}
}
IL2CPP_EXTERN_C  Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 CallbackContext_ReadValue_TisVector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2_mC5704121342A8A761FA496E4922FDA7B37C20EDD_AdjustorThunk (RuntimeObject* __this, const RuntimeMethod* method)
{
CallbackContext_tB251EE41F509C6E8A6B05EC97C029A45DF4F5FA8* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<CallbackContext_tB251EE41F509C6E8A6B05EC97C029A45DF4F5FA8*>(__this + _offset);
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 _returnValue;
	_returnValue = CallbackContext_ReadValue_TisVector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2_mC5704121342A8A761FA496E4922FDA7B37C20EDD(_thisAdjusted, method);
	return _returnValue;
}
// UnityEngine.InputSystem.InputActionRebindingExtensions/RebindingOperation UnityEngine.InputSystem.InputActionRebindingExtensions/RebindingOperation::WithExpectedControlType<System.Object>()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RebindingOperation_tF7D9BCBB6E69668FA3A5C211104FF8637F9F3470* RebindingOperation_WithExpectedControlType_TisRuntimeObject_mD0F2FB39194CC7EAC8E22DFFCD9C9116BAFC7B5E_gshared (RebindingOperation_tF7D9BCBB6E69668FA3A5C211104FF8637F9F3470* __this, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Type_t_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
{
		// ThrowIfRebindInProgress();
		RebindingOperation_ThrowIfRebindInProgress_m02318B6E459C495517FF62AEAD4603BF683EED9C(__this, NULL);
		// return WithExpectedControlType(typeof(TControl));
		RuntimeTypeHandle_t332A452B8B6179E4469B69525D0FE82A88030F7B L_0 = { reinterpret_cast<intptr_t> (il2cpp_rgctx_type(method->rgctx_data, 0)) };
		il2cpp_codegen_runtime_class_init_inline(Type_t_il2cpp_TypeInfo_var);
		Type_t* L_1;
		L_1 = Type_GetTypeFromHandle_m2570A2A5B32A5E9D9F0F38B37459DA18736C823E(L_0, NULL);
		RebindingOperation_tF7D9BCBB6E69668FA3A5C211104FF8637F9F3470* L_2;
		L_2 = RebindingOperation_WithExpectedControlType_m7C6765DE8A1B747F1E83EB324CCED84F509622AB(__this, L_1, NULL);
		return L_2;
	}
}
// UnityEngine.InputSystem.InputActionSetupExtensions/BindingSyntax UnityEngine.InputSystem.InputActionSetupExtensions/BindingSyntax::WithInteraction<System.Object>()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR BindingSyntax_t5FB93D8F3518B4640E42E067ECB15541CD123317 BindingSyntax_WithInteraction_TisRuntimeObject_mA9CD41BB913C678CE5891E3C51871CBFCFB13254_gshared (BindingSyntax_t5FB93D8F3518B4640E42E067ECB15541CD123317* __this, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&InputProcessor_t71DA6677A0295DC87736E1D8D208FEA75D860457_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Type_t_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
InternedString_t8D62A48CB7D85AAE9CFCCCFB0A77AC2844905735 V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		// if (!valid)
		bool L_0;
		L_0 = BindingSyntax_get_valid_m233A0DBDBE0B5AAB4B078F8FD39B1C60EFB6040C(__this, NULL);
		if (L_0)
		{
			goto IL_0013;
		}
	}
	{
		// throw new InvalidOperationException("Accessor is not valid");
		InvalidOperationException_t5DDE4D49B7405FAAB1E4576F4715A42A3FAD4BAB* L_1 = (InvalidOperationException_t5DDE4D49B7405FAAB1E4576F4715A42A3FAD4BAB*)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&InvalidOperationException_t5DDE4D49B7405FAAB1E4576F4715A42A3FAD4BAB_il2cpp_TypeInfo_var)));
		InvalidOperationException__ctor_mE4CB6F4712AB6D99A2358FBAE2E052B3EE976162(L_1, ((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteral3A38F099E8455AB689BE3047D74FAFF31510DF90)), /*hidden argument*/NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_1, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&BindingSyntax_WithInteraction_TisRuntimeObject_mA9CD41BB913C678CE5891E3C51871CBFCFB13254_RuntimeMethod_var)));
	}

IL_0013:
	{
		// var interactionName = InputProcessor.s_Processors.FindNameForType(typeof(TInteraction));
		RuntimeTypeHandle_t332A452B8B6179E4469B69525D0FE82A88030F7B L_2 = { reinterpret_cast<intptr_t> (il2cpp_rgctx_type(method->rgctx_data, 0)) };
		il2cpp_codegen_runtime_class_init_inline(Type_t_il2cpp_TypeInfo_var);
		Type_t* L_3;
		L_3 = Type_GetTypeFromHandle_m2570A2A5B32A5E9D9F0F38B37459DA18736C823E(L_2, NULL);
		InternedString_t8D62A48CB7D85AAE9CFCCCFB0A77AC2844905735 L_4;
		L_4 = TypeTable_FindNameForType_m5974594EAAEB68C4488B8C9CFABF931B7666FB00((&((InputProcessor_t71DA6677A0295DC87736E1D8D208FEA75D860457_StaticFields*)il2cpp_codegen_static_fields_for(InputProcessor_t71DA6677A0295DC87736E1D8D208FEA75D860457_il2cpp_TypeInfo_var))->___s_Processors_0), L_3, NULL);
		V_0 = L_4;
		// if (interactionName.IsEmpty())
		bool L_5;
		L_5 = InternedString_IsEmpty_mA88FAF2562BF41C57C00E68F5A4111B22CFF173B((&V_0), NULL);
		if (!L_5)
		{
			goto IL_004b;
		}
	}
	{
		// throw new NotSupportedException($"Type '{typeof(TInteraction)}' has not been registered as a processor");
		RuntimeTypeHandle_t332A452B8B6179E4469B69525D0FE82A88030F7B L_6 = { reinterpret_cast<intptr_t> (il2cpp_rgctx_type(method->rgctx_data, 0)) };
		il2cpp_codegen_runtime_class_init_inline(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&Type_t_il2cpp_TypeInfo_var)));
		Type_t* L_7;
		L_7 = Type_GetTypeFromHandle_m2570A2A5B32A5E9D9F0F38B37459DA18736C823E(L_6, NULL);
		String_t* L_8;
		L_8 = String_Format_m8C122B26BC5AA10E2550AECA16E57DAE10F07E30(((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteralAFCE96C2E9CB5FEF65576BADEA096873577F2BF6)), (RuntimeObject*)L_7, NULL);
		NotSupportedException_t1429765983D409BD2986508963C98D214E4EBF4A* L_9 = (NotSupportedException_t1429765983D409BD2986508963C98D214E4EBF4A*)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&NotSupportedException_t1429765983D409BD2986508963C98D214E4EBF4A_il2cpp_TypeInfo_var)));
		NotSupportedException__ctor_mE174750CF0247BBB47544FFD71D66BB89630945B(L_9, L_8, /*hidden argument*/NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_9, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&BindingSyntax_WithInteraction_TisRuntimeObject_mA9CD41BB913C678CE5891E3C51871CBFCFB13254_RuntimeMethod_var)));
	}

IL_004b:
	{
		// return WithInteraction(interactionName);
		InternedString_t8D62A48CB7D85AAE9CFCCCFB0A77AC2844905735 L_10 = V_0;
		String_t* L_11;
		L_11 = InternedString_op_Implicit_mF8E1F7DA818367AEB1330013321063D7BDF30526(L_10, NULL);
		BindingSyntax_t5FB93D8F3518B4640E42E067ECB15541CD123317 L_12;
		L_12 = BindingSyntax_WithInteraction_mCE7E9DC5A2927956F4A89F55FE5D0A083936042B(__this, L_11, NULL);
		return L_12;
	}
}
IL2CPP_EXTERN_C  BindingSyntax_t5FB93D8F3518B4640E42E067ECB15541CD123317 BindingSyntax_WithInteraction_TisRuntimeObject_mA9CD41BB913C678CE5891E3C51871CBFCFB13254_AdjustorThunk (RuntimeObject* __this, const RuntimeMethod* method)
{
BindingSyntax_t5FB93D8F3518B4640E42E067ECB15541CD123317* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<BindingSyntax_t5FB93D8F3518B4640E42E067ECB15541CD123317*>(__this + _offset);
	BindingSyntax_t5FB93D8F3518B4640E42E067ECB15541CD123317 _returnValue;
	_returnValue = BindingSyntax_WithInteraction_TisRuntimeObject_mA9CD41BB913C678CE5891E3C51871CBFCFB13254(_thisAdjusted, method);
	return _returnValue;
}
// UnityEngine.InputSystem.InputActionSetupExtensions/BindingSyntax UnityEngine.InputSystem.InputActionSetupExtensions/BindingSyntax::WithProcessor<System.Object>()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR BindingSyntax_t5FB93D8F3518B4640E42E067ECB15541CD123317 BindingSyntax_WithProcessor_TisRuntimeObject_m88180835A3724BF9C98DC39A8CB6146B2B3BC1DE_gshared (BindingSyntax_t5FB93D8F3518B4640E42E067ECB15541CD123317* __this, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&InputProcessor_t71DA6677A0295DC87736E1D8D208FEA75D860457_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Type_t_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
InternedString_t8D62A48CB7D85AAE9CFCCCFB0A77AC2844905735 V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		// if (!valid)
		bool L_0;
		L_0 = BindingSyntax_get_valid_m233A0DBDBE0B5AAB4B078F8FD39B1C60EFB6040C(__this, NULL);
		if (L_0)
		{
			goto IL_0013;
		}
	}
	{
		// throw new InvalidOperationException("Accessor is not valid");
		InvalidOperationException_t5DDE4D49B7405FAAB1E4576F4715A42A3FAD4BAB* L_1 = (InvalidOperationException_t5DDE4D49B7405FAAB1E4576F4715A42A3FAD4BAB*)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&InvalidOperationException_t5DDE4D49B7405FAAB1E4576F4715A42A3FAD4BAB_il2cpp_TypeInfo_var)));
		InvalidOperationException__ctor_mE4CB6F4712AB6D99A2358FBAE2E052B3EE976162(L_1, ((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteral3A38F099E8455AB689BE3047D74FAFF31510DF90)), /*hidden argument*/NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_1, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&BindingSyntax_WithProcessor_TisRuntimeObject_m88180835A3724BF9C98DC39A8CB6146B2B3BC1DE_RuntimeMethod_var)));
	}

IL_0013:
	{
		// var processorName = InputProcessor.s_Processors.FindNameForType(typeof(TProcessor));
		RuntimeTypeHandle_t332A452B8B6179E4469B69525D0FE82A88030F7B L_2 = { reinterpret_cast<intptr_t> (il2cpp_rgctx_type(method->rgctx_data, 0)) };
		il2cpp_codegen_runtime_class_init_inline(Type_t_il2cpp_TypeInfo_var);
		Type_t* L_3;
		L_3 = Type_GetTypeFromHandle_m2570A2A5B32A5E9D9F0F38B37459DA18736C823E(L_2, NULL);
		InternedString_t8D62A48CB7D85AAE9CFCCCFB0A77AC2844905735 L_4;
		L_4 = TypeTable_FindNameForType_m5974594EAAEB68C4488B8C9CFABF931B7666FB00((&((InputProcessor_t71DA6677A0295DC87736E1D8D208FEA75D860457_StaticFields*)il2cpp_codegen_static_fields_for(InputProcessor_t71DA6677A0295DC87736E1D8D208FEA75D860457_il2cpp_TypeInfo_var))->___s_Processors_0), L_3, NULL);
		V_0 = L_4;
		// if (processorName.IsEmpty())
		bool L_5;
		L_5 = InternedString_IsEmpty_mA88FAF2562BF41C57C00E68F5A4111B22CFF173B((&V_0), NULL);
		if (!L_5)
		{
			goto IL_004b;
		}
	}
	{
		// throw new NotSupportedException($"Type '{typeof(TProcessor)}' has not been registered as a processor");
		RuntimeTypeHandle_t332A452B8B6179E4469B69525D0FE82A88030F7B L_6 = { reinterpret_cast<intptr_t> (il2cpp_rgctx_type(method->rgctx_data, 0)) };
		il2cpp_codegen_runtime_class_init_inline(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&Type_t_il2cpp_TypeInfo_var)));
		Type_t* L_7;
		L_7 = Type_GetTypeFromHandle_m2570A2A5B32A5E9D9F0F38B37459DA18736C823E(L_6, NULL);
		String_t* L_8;
		L_8 = String_Format_m8C122B26BC5AA10E2550AECA16E57DAE10F07E30(((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteralAFCE96C2E9CB5FEF65576BADEA096873577F2BF6)), (RuntimeObject*)L_7, NULL);
		NotSupportedException_t1429765983D409BD2986508963C98D214E4EBF4A* L_9 = (NotSupportedException_t1429765983D409BD2986508963C98D214E4EBF4A*)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&NotSupportedException_t1429765983D409BD2986508963C98D214E4EBF4A_il2cpp_TypeInfo_var)));
		NotSupportedException__ctor_mE174750CF0247BBB47544FFD71D66BB89630945B(L_9, L_8, /*hidden argument*/NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_9, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&BindingSyntax_WithProcessor_TisRuntimeObject_m88180835A3724BF9C98DC39A8CB6146B2B3BC1DE_RuntimeMethod_var)));
	}

IL_004b:
	{
		// return WithProcessor(processorName);
		InternedString_t8D62A48CB7D85AAE9CFCCCFB0A77AC2844905735 L_10 = V_0;
		String_t* L_11;
		L_11 = InternedString_op_Implicit_mF8E1F7DA818367AEB1330013321063D7BDF30526(L_10, NULL);
		BindingSyntax_t5FB93D8F3518B4640E42E067ECB15541CD123317 L_12;
		L_12 = BindingSyntax_WithProcessor_m2FD9C1A3B16647C578EF8723249ABF6B45E7F9AC(__this, L_11, NULL);
		return L_12;
	}
}
IL2CPP_EXTERN_C  BindingSyntax_t5FB93D8F3518B4640E42E067ECB15541CD123317 BindingSyntax_WithProcessor_TisRuntimeObject_m88180835A3724BF9C98DC39A8CB6146B2B3BC1DE_AdjustorThunk (RuntimeObject* __this, const RuntimeMethod* method)
{
BindingSyntax_t5FB93D8F3518B4640E42E067ECB15541CD123317* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<BindingSyntax_t5FB93D8F3518B4640E42E067ECB15541CD123317*>(__this + _offset);
	BindingSyntax_t5FB93D8F3518B4640E42E067ECB15541CD123317 _returnValue;
	_returnValue = BindingSyntax_WithProcessor_TisRuntimeObject_m88180835A3724BF9C98DC39A8CB6146B2B3BC1DE(_thisAdjusted, method);
	return _returnValue;
}
// System.String UnityEngine.InputSystem.InputActionSetupExtensions/ControlSchemeSyntax::DeviceTypeToControlPath<System.Object>()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* ControlSchemeSyntax_DeviceTypeToControlPath_TisRuntimeObject_mF63A1990BA907932D19EC7FA27A34BC1A855D21A_gshared (ControlSchemeSyntax_t4C14E0745C729675BFFADA8275391ACBAD73227D* __this, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&InputControlLayout_t46A40BE4C976BE33E85F61E63EB34323FED9831D_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Type_t_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral725B1CAFF9B49E1231FDA15B85166BBEFAA36A11);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralEF8AE9E6CBCFDABA932FBEB4C85964F450F724F5);
		s_Il2CppMethodInitialized = true;
	}
String_t* V_0 = NULL;
	InternedString_t8D62A48CB7D85AAE9CFCCCFB0A77AC2844905735 V_1;
	memset((&V_1), 0, sizeof(V_1));
	{
		// var layoutName = InputControlLayout.s_Layouts.TryFindLayoutForType(typeof(TDevice)).ToString();
		il2cpp_codegen_runtime_class_init_inline(InputControlLayout_t46A40BE4C976BE33E85F61E63EB34323FED9831D_il2cpp_TypeInfo_var);
		RuntimeTypeHandle_t332A452B8B6179E4469B69525D0FE82A88030F7B L_0 = { reinterpret_cast<intptr_t> (il2cpp_rgctx_type(method->rgctx_data, 0)) };
		il2cpp_codegen_runtime_class_init_inline(Type_t_il2cpp_TypeInfo_var);
		Type_t* L_1;
		L_1 = Type_GetTypeFromHandle_m2570A2A5B32A5E9D9F0F38B37459DA18736C823E(L_0, NULL);
		InternedString_t8D62A48CB7D85AAE9CFCCCFB0A77AC2844905735 L_2;
		L_2 = Collection_TryFindLayoutForType_m63B3C00D6ED29C6DD98A6B735E5C4C84A3B20868((&((InputControlLayout_t46A40BE4C976BE33E85F61E63EB34323FED9831D_StaticFields*)il2cpp_codegen_static_fields_for(InputControlLayout_t46A40BE4C976BE33E85F61E63EB34323FED9831D_il2cpp_TypeInfo_var))->___s_Layouts_15), L_1, NULL);
		V_1 = L_2;
		String_t* L_3;
		L_3 = InternedString_ToString_mED327D67EF001C5EDFF284336F13C3E3F025993A((&V_1), NULL);
		V_0 = L_3;
		// if (string.IsNullOrEmpty(layoutName))
		String_t* L_4 = V_0;
		bool L_5;
		L_5 = String_IsNullOrEmpty_m54CF0907E7C4F3AFB2E796A13DC751ECBB8DB64A(L_4, NULL);
		if (!L_5)
		{
			goto IL_003b;
		}
	}
	{
		// layoutName = typeof(TDevice).Name;
		RuntimeTypeHandle_t332A452B8B6179E4469B69525D0FE82A88030F7B L_6 = { reinterpret_cast<intptr_t> (il2cpp_rgctx_type(method->rgctx_data, 0)) };
		il2cpp_codegen_runtime_class_init_inline(Type_t_il2cpp_TypeInfo_var);
		Type_t* L_7;
		L_7 = Type_GetTypeFromHandle_m2570A2A5B32A5E9D9F0F38B37459DA18736C823E(L_6, NULL);
		NullCheck((MemberInfo_t*)L_7);
		String_t* L_8;
		L_8 = VirtualFuncInvoker0< String_t* >::Invoke(8 /* System.String System.Reflection.MemberInfo::get_Name() */, (MemberInfo_t*)L_7);
		V_0 = L_8;
	}

IL_003b:
	{
		// return $"<{layoutName}>";
		String_t* L_9 = V_0;
		String_t* L_10;
		L_10 = String_Concat_m9B13B47FCB3DF61144D9647DDA05F527377251B0(_stringLiteral725B1CAFF9B49E1231FDA15B85166BBEFAA36A11, L_9, _stringLiteralEF8AE9E6CBCFDABA932FBEB4C85964F450F724F5, NULL);
		return L_10;
	}
}
IL2CPP_EXTERN_C  String_t* ControlSchemeSyntax_DeviceTypeToControlPath_TisRuntimeObject_mF63A1990BA907932D19EC7FA27A34BC1A855D21A_AdjustorThunk (RuntimeObject* __this, const RuntimeMethod* method)
{
ControlSchemeSyntax_t4C14E0745C729675BFFADA8275391ACBAD73227D* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<ControlSchemeSyntax_t4C14E0745C729675BFFADA8275391ACBAD73227D*>(__this + _offset);
	String_t* _returnValue;
	_returnValue = ControlSchemeSyntax_DeviceTypeToControlPath_TisRuntimeObject_mF63A1990BA907932D19EC7FA27A34BC1A855D21A(_thisAdjusted, method);
	return _returnValue;
}
// UnityEngine.InputSystem.InputActionSetupExtensions/ControlSchemeSyntax UnityEngine.InputSystem.InputActionSetupExtensions/ControlSchemeSyntax::OrWithOptionalDevice<System.Object>()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR ControlSchemeSyntax_t4C14E0745C729675BFFADA8275391ACBAD73227D ControlSchemeSyntax_OrWithOptionalDevice_TisRuntimeObject_mF382F898E47985498314A5A60EF2542B5607DF53_gshared (ControlSchemeSyntax_t4C14E0745C729675BFFADA8275391ACBAD73227D* __this, const RuntimeMethod* method) 
{
{
		// return WithOptionalDevice(DeviceTypeToControlPath<TDevice>());
		String_t* L_0;
		L_0 = ControlSchemeSyntax_DeviceTypeToControlPath_TisRuntimeObject_mF63A1990BA907932D19EC7FA27A34BC1A855D21A(__this, il2cpp_rgctx_method(method->rgctx_data, 0));
		ControlSchemeSyntax_t4C14E0745C729675BFFADA8275391ACBAD73227D L_1;
		L_1 = ControlSchemeSyntax_WithOptionalDevice_mB17551E2EB7F96585BD6E01573D9494664E9EED7(__this, L_0, NULL);
		return L_1;
	}
}
IL2CPP_EXTERN_C  ControlSchemeSyntax_t4C14E0745C729675BFFADA8275391ACBAD73227D ControlSchemeSyntax_OrWithOptionalDevice_TisRuntimeObject_mF382F898E47985498314A5A60EF2542B5607DF53_AdjustorThunk (RuntimeObject* __this, const RuntimeMethod* method)
{
ControlSchemeSyntax_t4C14E0745C729675BFFADA8275391ACBAD73227D* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<ControlSchemeSyntax_t4C14E0745C729675BFFADA8275391ACBAD73227D*>(__this + _offset);
	ControlSchemeSyntax_t4C14E0745C729675BFFADA8275391ACBAD73227D _returnValue;
	_returnValue = ControlSchemeSyntax_OrWithOptionalDevice_TisRuntimeObject_mF382F898E47985498314A5A60EF2542B5607DF53(_thisAdjusted, method);
	return _returnValue;
}
// UnityEngine.InputSystem.InputActionSetupExtensions/ControlSchemeSyntax UnityEngine.InputSystem.InputActionSetupExtensions/ControlSchemeSyntax::OrWithRequiredDevice<System.Object>()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR ControlSchemeSyntax_t4C14E0745C729675BFFADA8275391ACBAD73227D ControlSchemeSyntax_OrWithRequiredDevice_TisRuntimeObject_m82C53906C0350BE78EBA1C410BC169C64E555CDE_gshared (ControlSchemeSyntax_t4C14E0745C729675BFFADA8275391ACBAD73227D* __this, const RuntimeMethod* method) 
{
{
		// return WithRequiredDevice(DeviceTypeToControlPath<TDevice>());
		String_t* L_0;
		L_0 = ControlSchemeSyntax_DeviceTypeToControlPath_TisRuntimeObject_mF63A1990BA907932D19EC7FA27A34BC1A855D21A(__this, il2cpp_rgctx_method(method->rgctx_data, 0));
		ControlSchemeSyntax_t4C14E0745C729675BFFADA8275391ACBAD73227D L_1;
		L_1 = ControlSchemeSyntax_WithRequiredDevice_mAFC72E5BFF4F4724E208AB15CC379ABD786EFFCE(__this, L_0, NULL);
		return L_1;
	}
}
IL2CPP_EXTERN_C  ControlSchemeSyntax_t4C14E0745C729675BFFADA8275391ACBAD73227D ControlSchemeSyntax_OrWithRequiredDevice_TisRuntimeObject_m82C53906C0350BE78EBA1C410BC169C64E555CDE_AdjustorThunk (RuntimeObject* __this, const RuntimeMethod* method)
{
ControlSchemeSyntax_t4C14E0745C729675BFFADA8275391ACBAD73227D* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<ControlSchemeSyntax_t4C14E0745C729675BFFADA8275391ACBAD73227D*>(__this + _offset);
	ControlSchemeSyntax_t4C14E0745C729675BFFADA8275391ACBAD73227D _returnValue;
	_returnValue = ControlSchemeSyntax_OrWithRequiredDevice_TisRuntimeObject_m82C53906C0350BE78EBA1C410BC169C64E555CDE(_thisAdjusted, method);
	return _returnValue;
}
// UnityEngine.InputSystem.InputActionSetupExtensions/ControlSchemeSyntax UnityEngine.InputSystem.InputActionSetupExtensions/ControlSchemeSyntax::WithOptionalDevice<System.Object>()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR ControlSchemeSyntax_t4C14E0745C729675BFFADA8275391ACBAD73227D ControlSchemeSyntax_WithOptionalDevice_TisRuntimeObject_m44DA2464CBBE7A51A89945D7B96BB4114B0CDFEA_gshared (ControlSchemeSyntax_t4C14E0745C729675BFFADA8275391ACBAD73227D* __this, const RuntimeMethod* method) 
{
{
		// return WithOptionalDevice(DeviceTypeToControlPath<TDevice>());
		String_t* L_0;
		L_0 = ControlSchemeSyntax_DeviceTypeToControlPath_TisRuntimeObject_mF63A1990BA907932D19EC7FA27A34BC1A855D21A(__this, il2cpp_rgctx_method(method->rgctx_data, 0));
		ControlSchemeSyntax_t4C14E0745C729675BFFADA8275391ACBAD73227D L_1;
		L_1 = ControlSchemeSyntax_WithOptionalDevice_mB17551E2EB7F96585BD6E01573D9494664E9EED7(__this, L_0, NULL);
		return L_1;
	}
}
IL2CPP_EXTERN_C  ControlSchemeSyntax_t4C14E0745C729675BFFADA8275391ACBAD73227D ControlSchemeSyntax_WithOptionalDevice_TisRuntimeObject_m44DA2464CBBE7A51A89945D7B96BB4114B0CDFEA_AdjustorThunk (RuntimeObject* __this, const RuntimeMethod* method)
{
ControlSchemeSyntax_t4C14E0745C729675BFFADA8275391ACBAD73227D* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<ControlSchemeSyntax_t4C14E0745C729675BFFADA8275391ACBAD73227D*>(__this + _offset);
	ControlSchemeSyntax_t4C14E0745C729675BFFADA8275391ACBAD73227D _returnValue;
	_returnValue = ControlSchemeSyntax_WithOptionalDevice_TisRuntimeObject_m44DA2464CBBE7A51A89945D7B96BB4114B0CDFEA(_thisAdjusted, method);
	return _returnValue;
}
// UnityEngine.InputSystem.InputActionSetupExtensions/ControlSchemeSyntax UnityEngine.InputSystem.InputActionSetupExtensions/ControlSchemeSyntax::WithRequiredDevice<System.Object>()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR ControlSchemeSyntax_t4C14E0745C729675BFFADA8275391ACBAD73227D ControlSchemeSyntax_WithRequiredDevice_TisRuntimeObject_mBEFB5EF49817C78C1BA4145393A1F2642E6ABD9D_gshared (ControlSchemeSyntax_t4C14E0745C729675BFFADA8275391ACBAD73227D* __this, const RuntimeMethod* method) 
{
{
		// return WithRequiredDevice(DeviceTypeToControlPath<TDevice>());
		String_t* L_0;
		L_0 = ControlSchemeSyntax_DeviceTypeToControlPath_TisRuntimeObject_mF63A1990BA907932D19EC7FA27A34BC1A855D21A(__this, il2cpp_rgctx_method(method->rgctx_data, 0));
		ControlSchemeSyntax_t4C14E0745C729675BFFADA8275391ACBAD73227D L_1;
		L_1 = ControlSchemeSyntax_WithRequiredDevice_mAFC72E5BFF4F4724E208AB15CC379ABD786EFFCE(__this, L_0, NULL);
		return L_1;
	}
}
IL2CPP_EXTERN_C  ControlSchemeSyntax_t4C14E0745C729675BFFADA8275391ACBAD73227D ControlSchemeSyntax_WithRequiredDevice_TisRuntimeObject_mBEFB5EF49817C78C1BA4145393A1F2642E6ABD9D_AdjustorThunk (RuntimeObject* __this, const RuntimeMethod* method)
{
ControlSchemeSyntax_t4C14E0745C729675BFFADA8275391ACBAD73227D* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<ControlSchemeSyntax_t4C14E0745C729675BFFADA8275391ACBAD73227D*>(__this + _offset);
	ControlSchemeSyntax_t4C14E0745C729675BFFADA8275391ACBAD73227D _returnValue;
	_returnValue = ControlSchemeSyntax_WithRequiredDevice_TisRuntimeObject_mBEFB5EF49817C78C1BA4145393A1F2642E6ABD9D(_thisAdjusted, method);
	return _returnValue;
}
// UnityEngine.InputSystem.Layouts.InputControlLayout/Builder UnityEngine.InputSystem.Layouts.InputControlLayout/Builder::WithType<System.Object>()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Builder_t83F17A26F53DA7EA6D8C35E5C65C5DF0147E7821* Builder_WithType_TisRuntimeObject_m78AB1B3E3CC78CC83E7A66415AD992EF33CF8A7F_gshared (Builder_t83F17A26F53DA7EA6D8C35E5C65C5DF0147E7821* __this, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Type_t_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
{
		// type = typeof(T);
		RuntimeTypeHandle_t332A452B8B6179E4469B69525D0FE82A88030F7B L_0 = { reinterpret_cast<intptr_t> (il2cpp_rgctx_type(method->rgctx_data, 0)) };
		il2cpp_codegen_runtime_class_init_inline(Type_t_il2cpp_TypeInfo_var);
		Type_t* L_1;
		L_1 = Type_GetTypeFromHandle_m2570A2A5B32A5E9D9F0F38B37459DA18736C823E(L_0, NULL);
		Builder_set_type_m9052A0AB147182E89AAA4F020F6A0BE797AB49CC_inline(__this, L_1, NULL);
		// return this;
		return __this;
	}
}
// ? Rewired.InputMapper/Options::cCOWeIxJLTqVNCHkVqmoDogaKdxw<System.Object>(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* Options_cCOWeIxJLTqVNCHkVqmoDogaKdxw_TisRuntimeObject_mD8C411D04312A776595EAFF196D5C49DA3DBB027_gshared (Options_t2CAC7BDE548C606E2D6149513164D5EF301AEF7A* __this, String_t* p0, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Dictionary_2_TryGetValue_m6EC43AE2C5DA7C0B6304C7615BB114120F4C7C1C_RuntimeMethod_var);
		s_Il2CppMethodInitialized = true;
	}
SafeDelegate_t3A5CBC88139112F30FC47A9C9FEE81140913D328* V_0 = NULL;
	RuntimeObject* V_1 = NULL;
	{
		Dictionary_2_t340D9BC5CF0537B47A79183E8A310B59364118DF* L_0 = (Dictionary_2_t340D9BC5CF0537B47A79183E8A310B59364118DF*)__this->___kQEDpbIrGvgbinAZYRcxGnGhuOMwA_16;
		String_t* L_1 = p0;
		NullCheck(L_0);
		bool L_2;
		L_2 = Dictionary_2_TryGetValue_m6EC43AE2C5DA7C0B6304C7615BB114120F4C7C1C(L_0, L_1, (&V_0), Dictionary_2_TryGetValue_m6EC43AE2C5DA7C0B6304C7615BB114120F4C7C1C_RuntimeMethod_var);
		if (L_2)
		{
			goto IL_001a;
		}
	}
	{
		il2cpp_codegen_initobj((&V_1), sizeof(RuntimeObject*));
		RuntimeObject* L_3 = V_1;
		return L_3;
	}

IL_001a:
	{
		SafeDelegate_t3A5CBC88139112F30FC47A9C9FEE81140913D328* L_4 = V_0;
		return ((RuntimeObject*)Castclass((RuntimeObject*)((RuntimeObject*)IsInst((RuntimeObject*)L_4, il2cpp_rgctx_data(method->rgctx_data, 0))), il2cpp_rgctx_data(method->rgctx_data, 0)));
	}
}
// System.Void Rewired.InputMapper/ukhpurvRuIKYVFmbrHGZXcVzGwlw::jFigJslsykuAxrBWWKVcmHkOxqEy<System.Object>(Rewired.InputMapper/JdpDLqzkBAGmKbSgujDlWammLWSdA,?)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ukhpurvRuIKYVFmbrHGZXcVzGwlw_jFigJslsykuAxrBWWKVcmHkOxqEy_TisRuntimeObject_mFA2541353004F3568EF8CBBBF3E24F18755DCF32_gshared (ukhpurvRuIKYVFmbrHGZXcVzGwlw_tCB0702700C158E9D3CD5837A11109AFF50466BDE* __this, int32_t p0, RuntimeObject* p1, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Dictionary_2_get_Item_mE1AB1E72BF64ADB727FBCFC32FD083FE40112818_RuntimeMethod_var);
		s_Il2CppMethodInitialized = true;
	}
SafeAction_1_t6487A885AFD7F4B1D15116DF8B20C492918A637F* V_0 = NULL;
	{
		Dictionary_2_t501DD8094A745126C4C4ED68F7198F76A46828B2* L_0 = (Dictionary_2_t501DD8094A745126C4C4ED68F7198F76A46828B2*)__this->___ggxGRWdIrRGzvgMJdsLISbkNBGNYA_3;
		int32_t L_1 = p0;
		NullCheck(L_0);
		SafeDelegate_t3A5CBC88139112F30FC47A9C9FEE81140913D328* L_2;
		L_2 = Dictionary_2_get_Item_mE1AB1E72BF64ADB727FBCFC32FD083FE40112818(L_0, L_1, Dictionary_2_get_Item_mE1AB1E72BF64ADB727FBCFC32FD083FE40112818_RuntimeMethod_var);
		V_0 = ((SafeAction_1_t6487A885AFD7F4B1D15116DF8B20C492918A637F*)CastclassSealed((RuntimeObject*)L_2, il2cpp_rgctx_data(method->rgctx_data, 0)));
		SafeAction_1_t6487A885AFD7F4B1D15116DF8B20C492918A637F* L_3 = V_0;
		NullCheck((SafeDelegate_t3A5CBC88139112F30FC47A9C9FEE81140913D328*)L_3);
		int32_t L_4;
		L_4 = VirtualFuncInvoker0< int32_t >::Invoke(5 /* System.Int32 Rewired.Utils.SafeDelegate::get_Count() */, (SafeDelegate_t3A5CBC88139112F30FC47A9C9FEE81140913D328*)L_3);
		if (L_4)
		{
			goto IL_001b;
		}
	}
	{
		return;
	}

IL_001b:
	{
		SafeAction_1_t6487A885AFD7F4B1D15116DF8B20C492918A637F* L_5 = V_0;
		RuntimeObject* L_6 = p1;
		NullCheck(L_5);
		((  void (*) (SafeAction_1_t6487A885AFD7F4B1D15116DF8B20C492918A637F*, RuntimeObject*, const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->rgctx_data, 1)))(L_5, L_6, il2cpp_rgctx_method(method->rgctx_data, 1));
		return;
	}
}
// System.Collections.Generic.IList`1<?> PjzdStrqNkNQSljwEZWJWYcQhjVQ/xcjUJvCGhYqGWwkvUdNHjHWxoqqC::EiNsNTBcYSknCCngMwnIJTPRkXRk<System.Object>()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* xcjUJvCGhYqGWwkvUdNHjHWxoqqC_EiNsNTBcYSknCCngMwnIJTPRkXRk_TisRuntimeObject_mB294A6D2BCE836A021DA69B71CAD0D4432795992_gshared (xcjUJvCGhYqGWwkvUdNHjHWxoqqC_t543EB71E658F90965142EBA611491F052277C6B0* __this, const RuntimeMethod* method) 
{
{
		RuntimeObject* L_0 = (RuntimeObject*)__this->___tHZEPnFmTQxkjsGpSgVDknUtcVHe_1;
		if (L_0)
		{
			goto IL_000e;
		}
	}
	{
		((  void (*) (xcjUJvCGhYqGWwkvUdNHjHWxoqqC_t543EB71E658F90965142EBA611491F052277C6B0*, const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->rgctx_data, 0)))(__this, il2cpp_rgctx_method(method->rgctx_data, 0));
	}

IL_000e:
	{
		RuntimeObject* L_1 = (RuntimeObject*)__this->___OvLFleCEdoySEQcjTcyPRQmtFORLA_2;
		return ((RuntimeObject*)IsInst((RuntimeObject*)L_1, il2cpp_rgctx_data(method->rgctx_data, 1)));
	}
}
// System.Void PjzdStrqNkNQSljwEZWJWYcQhjVQ/xcjUJvCGhYqGWwkvUdNHjHWxoqqC::PVvgczeeLWLtFudaFffrxXdSMPcKA<System.Object>()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void xcjUJvCGhYqGWwkvUdNHjHWxoqqC_PVvgczeeLWLtFudaFffrxXdSMPcKA_TisRuntimeObject_m3931C57D7889C1B2CC5B42B94B7D97557CE267AA_gshared (xcjUJvCGhYqGWwkvUdNHjHWxoqqC_t543EB71E658F90965142EBA611491F052277C6B0* __this, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IList_t1C522956D79B7DC92B5B01053DF1AC058C8B598D_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
int32_t V_0 = 0;
	{
		AList_1_t8AC95BE03ABEFD201943BE98AD0C21498B716AD0* L_0 = (AList_1_t8AC95BE03ABEFD201943BE98AD0C21498B716AD0*)il2cpp_codegen_object_new(il2cpp_rgctx_data(method->rgctx_data, 0));
		AList_1__ctor_m795F1FC5309FE7B90118108D3C1D5C004D926D66(L_0, /*hidden argument*/il2cpp_rgctx_method(method->rgctx_data, 1));
		__this->___tHZEPnFmTQxkjsGpSgVDknUtcVHe_1 = (RuntimeObject*)L_0;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___tHZEPnFmTQxkjsGpSgVDknUtcVHe_1), (void*)(RuntimeObject*)L_0);
		RuntimeObject* L_1 = (RuntimeObject*)__this->___tHZEPnFmTQxkjsGpSgVDknUtcVHe_1;
		ReadOnlyCollection_1_t5397DF0DB61D1090E7BBC89395CECB8D020CED92* L_2 = (ReadOnlyCollection_1_t5397DF0DB61D1090E7BBC89395CECB8D020CED92*)il2cpp_codegen_object_new(il2cpp_rgctx_data(method->rgctx_data, 2));
		ReadOnlyCollection_1__ctor_mF2D2ACE0752C3B97343B72328D49200F45C14B65(L_2, (RuntimeObject*)((AList_1_t8AC95BE03ABEFD201943BE98AD0C21498B716AD0*)CastclassClass((RuntimeObject*)L_1, il2cpp_rgctx_data(method->rgctx_data, 0))), /*hidden argument*/il2cpp_rgctx_method(method->rgctx_data, 3));
		__this->___OvLFleCEdoySEQcjTcyPRQmtFORLA_2 = (RuntimeObject*)L_2;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___OvLFleCEdoySEQcjTcyPRQmtFORLA_2), (void*)(RuntimeObject*)L_2);
		V_0 = 0;
		goto IL_0042;
	}

IL_0025:
	{
		RuntimeObject* L_3 = (RuntimeObject*)__this->___tHZEPnFmTQxkjsGpSgVDknUtcVHe_1;
		AList_1_t6F028F71F04E9F8A363286413FD2E2C6C409F5B5* L_4 = (AList_1_t6F028F71F04E9F8A363286413FD2E2C6C409F5B5*)__this->___VNRjhxdkwzCQsQLRYBpUhOzPIPLcA_0;
		NullCheck(L_4);
		IControllerTemplateU5BU5D_tAD319B5FD030C9F0A993A85F2EB5B7A47390C3DB* L_5 = (IControllerTemplateU5BU5D_tAD319B5FD030C9F0A993A85F2EB5B7A47390C3DB*)L_4->____items_3;
		int32_t L_6 = V_0;
		NullCheck(L_5);
		int32_t L_7 = L_6;
		RuntimeObject* L_8 = (L_5)->GetAt(static_cast<il2cpp_array_size_t>(L_7));
		NullCheck(L_3);
		int32_t L_9;
		L_9 = InterfaceFuncInvoker1< int32_t, RuntimeObject* >::Invoke(2 /* System.Int32 System.Collections.IList::Add(System.Object) */, IList_t1C522956D79B7DC92B5B01053DF1AC058C8B598D_il2cpp_TypeInfo_var, L_3, (RuntimeObject*)L_8);
		int32_t L_10 = V_0;
		V_0 = ((int32_t)il2cpp_codegen_add(L_10, 1));
	}

IL_0042:
	{
		int32_t L_11 = V_0;
		AList_1_t6F028F71F04E9F8A363286413FD2E2C6C409F5B5* L_12 = (AList_1_t6F028F71F04E9F8A363286413FD2E2C6C409F5B5*)__this->___VNRjhxdkwzCQsQLRYBpUhOzPIPLcA_0;
		NullCheck(L_12);
		int32_t L_13 = (int32_t)L_12->____count_5;
		if ((((int32_t)L_11) < ((int32_t)L_13)))
		{
			goto IL_0025;
		}
	}
	{
		return;
	}
}
// System.Void Rewired.Player/ControllerHelper::AddController<System.Object>(System.Int32,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ControllerHelper_AddController_TisRuntimeObject_m127297199EA05D1E046A2CFBC919A78CE371C507_gshared (ControllerHelper_tCE72EA23053BD0C6ECB4D75A69F8CD1B3AC28FF6* __this, int32_t ___controllerId0, bool ___removeFromOtherPlayers1, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&CustomController_t749B7DF2AA8AD20FEC4C2003C4FF5000FE9C6065_0_0_0_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Joystick_tEC65D4846A553E83F365E7D8D263DC644C75FC11_0_0_0_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Keyboard_t3FD52938480ACCD23FDB0DAEC857F9A9D29CC6C3_0_0_0_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Mouse_t5C8D9CB89A5C0F4EE87A70501CAF2A68E36DC019_0_0_0_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Type_t_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
Type_t* V_0 = NULL;
	{
		il2cpp_codegen_runtime_class_init_inline(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		int32_t L_0 = ((ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_StaticFields*)il2cpp_codegen_static_fields_for(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var))->____id_29;
		int32_t L_1 = (int32_t)__this->___eNyGUiEiMyquCTKLRhFvpeyOvzMm_11;
		if ((((int32_t)L_0) == ((int32_t)L_1)))
		{
			goto IL_001a;
		}
	}
	{
		int32_t L_2 = (int32_t)__this->___eNyGUiEiMyquCTKLRhFvpeyOvzMm_11;
		il2cpp_codegen_runtime_class_init_inline(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		bool L_3;
		L_3 = ReInput_CheckInitialized_mAAC593CB03C886BDB7B72864FBB1A59B2B0530AF(L_2, NULL);
		return;
	}

IL_001a:
	{
		RuntimeTypeHandle_t332A452B8B6179E4469B69525D0FE82A88030F7B L_4 = { reinterpret_cast<intptr_t> (il2cpp_rgctx_type(method->rgctx_data, 0)) };
		il2cpp_codegen_runtime_class_init_inline(Type_t_il2cpp_TypeInfo_var);
		Type_t* L_5;
		L_5 = Type_GetTypeFromHandle_m2570A2A5B32A5E9D9F0F38B37459DA18736C823E(L_4, NULL);
		V_0 = L_5;
		Type_t* L_6 = V_0;
		RuntimeTypeHandle_t332A452B8B6179E4469B69525D0FE82A88030F7B L_7 = { reinterpret_cast<intptr_t> (Joystick_tEC65D4846A553E83F365E7D8D263DC644C75FC11_0_0_0_var) };
		Type_t* L_8;
		L_8 = Type_GetTypeFromHandle_m2570A2A5B32A5E9D9F0F38B37459DA18736C823E(L_7, NULL);
		bool L_9;
		L_9 = ReflectionTools_DoesTypeImplement_m76A5EBA9D9AF0CCCD6DE916990142B42729852D0(L_6, L_8, NULL);
		if (!L_9)
		{
			goto IL_0040;
		}
	}
	{
		int32_t L_10 = ___controllerId0;
		bool L_11 = ___removeFromOtherPlayers1;
		ControllerHelper_QQxKOnTwNPCHMwOnZEnsIEZFcRycA_m864DD40C38F6DAFF3A56E30B0A35A3E3027962D8(__this, L_10, L_11, NULL);
		return;
	}

IL_0040:
	{
		Type_t* L_12 = V_0;
		RuntimeTypeHandle_t332A452B8B6179E4469B69525D0FE82A88030F7B L_13 = { reinterpret_cast<intptr_t> (Keyboard_t3FD52938480ACCD23FDB0DAEC857F9A9D29CC6C3_0_0_0_var) };
		il2cpp_codegen_runtime_class_init_inline(Type_t_il2cpp_TypeInfo_var);
		Type_t* L_14;
		L_14 = Type_GetTypeFromHandle_m2570A2A5B32A5E9D9F0F38B37459DA18736C823E(L_13, NULL);
		bool L_15;
		L_15 = ReflectionTools_DoesTypeImplement_m76A5EBA9D9AF0CCCD6DE916990142B42729852D0(L_12, L_14, NULL);
		if (!L_15)
		{
			goto IL_005c;
		}
	}
	{
		int32_t L_16 = ___controllerId0;
		bool L_17 = ___removeFromOtherPlayers1;
		ControllerHelper_AddController_mC1EEC062B0F2C52570564EF3F6614E0E9ED35FF8(__this, (int32_t)0, L_16, L_17, NULL);
		return;
	}

IL_005c:
	{
		Type_t* L_18 = V_0;
		RuntimeTypeHandle_t332A452B8B6179E4469B69525D0FE82A88030F7B L_19 = { reinterpret_cast<intptr_t> (Mouse_t5C8D9CB89A5C0F4EE87A70501CAF2A68E36DC019_0_0_0_var) };
		il2cpp_codegen_runtime_class_init_inline(Type_t_il2cpp_TypeInfo_var);
		Type_t* L_20;
		L_20 = Type_GetTypeFromHandle_m2570A2A5B32A5E9D9F0F38B37459DA18736C823E(L_19, NULL);
		bool L_21;
		L_21 = ReflectionTools_DoesTypeImplement_m76A5EBA9D9AF0CCCD6DE916990142B42729852D0(L_18, L_20, NULL);
		if (!L_21)
		{
			goto IL_0078;
		}
	}
	{
		int32_t L_22 = ___controllerId0;
		bool L_23 = ___removeFromOtherPlayers1;
		ControllerHelper_AddController_mC1EEC062B0F2C52570564EF3F6614E0E9ED35FF8(__this, (int32_t)1, L_22, L_23, NULL);
		return;
	}

IL_0078:
	{
		Type_t* L_24 = V_0;
		RuntimeTypeHandle_t332A452B8B6179E4469B69525D0FE82A88030F7B L_25 = { reinterpret_cast<intptr_t> (CustomController_t749B7DF2AA8AD20FEC4C2003C4FF5000FE9C6065_0_0_0_var) };
		il2cpp_codegen_runtime_class_init_inline(Type_t_il2cpp_TypeInfo_var);
		Type_t* L_26;
		L_26 = Type_GetTypeFromHandle_m2570A2A5B32A5E9D9F0F38B37459DA18736C823E(L_25, NULL);
		bool L_27;
		L_27 = ReflectionTools_DoesTypeImplement_m76A5EBA9D9AF0CCCD6DE916990142B42729852D0(L_24, L_26, NULL);
		if (!L_27)
		{
			goto IL_0093;
		}
	}
	{
		int32_t L_28 = ___controllerId0;
		bool L_29 = ___removeFromOtherPlayers1;
		ControllerHelper_YKvaIRRSdroNuwpByVOUiaQDdvgY_mCC95CD1BA10F565882329CF12F4D19FDD7C535F5(__this, L_28, L_29, NULL);
		return;
	}

IL_0093:
	{
		NotImplementedException_t6366FE4DCF15094C51F4833B91A2AE68D4DA90E8* L_30 = (NotImplementedException_t6366FE4DCF15094C51F4833B91A2AE68D4DA90E8*)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&NotImplementedException_t6366FE4DCF15094C51F4833B91A2AE68D4DA90E8_il2cpp_TypeInfo_var)));
		NotImplementedException__ctor_mDAB47BC6BD0E342E8F2171E5CABE3E67EA049F1C(L_30, /*hidden argument*/NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_30, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&ControllerHelper_AddController_TisRuntimeObject_m127297199EA05D1E046A2CFBC919A78CE371C507_RuntimeMethod_var)));
	}
}
// System.Void Rewired.Player/ControllerHelper::ClearControllersOfType<System.Object>()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ControllerHelper_ClearControllersOfType_TisRuntimeObject_m3A464E94EEE7C002084282F8CB053F8871CB1015_gshared (ControllerHelper_tCE72EA23053BD0C6ECB4D75A69F8CD1B3AC28FF6* __this, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Controller_t919A4A50FC7A0F25D7B31615C0F4E4D4A4D17911_0_0_0_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&CustomController_t749B7DF2AA8AD20FEC4C2003C4FF5000FE9C6065_0_0_0_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Joystick_tEC65D4846A553E83F365E7D8D263DC644C75FC11_0_0_0_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Keyboard_t3FD52938480ACCD23FDB0DAEC857F9A9D29CC6C3_0_0_0_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Mouse_t5C8D9CB89A5C0F4EE87A70501CAF2A68E36DC019_0_0_0_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Type_t_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
Type_t* V_0 = NULL;
	{
		il2cpp_codegen_runtime_class_init_inline(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		int32_t L_0 = ((ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_StaticFields*)il2cpp_codegen_static_fields_for(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var))->____id_29;
		int32_t L_1 = (int32_t)__this->___eNyGUiEiMyquCTKLRhFvpeyOvzMm_11;
		if ((((int32_t)L_0) == ((int32_t)L_1)))
		{
			goto IL_001a;
		}
	}
	{
		int32_t L_2 = (int32_t)__this->___eNyGUiEiMyquCTKLRhFvpeyOvzMm_11;
		il2cpp_codegen_runtime_class_init_inline(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		bool L_3;
		L_3 = ReInput_CheckInitialized_mAAC593CB03C886BDB7B72864FBB1A59B2B0530AF(L_2, NULL);
		return;
	}

IL_001a:
	{
		RuntimeTypeHandle_t332A452B8B6179E4469B69525D0FE82A88030F7B L_4 = { reinterpret_cast<intptr_t> (il2cpp_rgctx_type(method->rgctx_data, 0)) };
		il2cpp_codegen_runtime_class_init_inline(Type_t_il2cpp_TypeInfo_var);
		Type_t* L_5;
		L_5 = Type_GetTypeFromHandle_m2570A2A5B32A5E9D9F0F38B37459DA18736C823E(L_4, NULL);
		V_0 = L_5;
		Type_t* L_6 = V_0;
		RuntimeTypeHandle_t332A452B8B6179E4469B69525D0FE82A88030F7B L_7 = { reinterpret_cast<intptr_t> (Joystick_tEC65D4846A553E83F365E7D8D263DC644C75FC11_0_0_0_var) };
		Type_t* L_8;
		L_8 = Type_GetTypeFromHandle_m2570A2A5B32A5E9D9F0F38B37459DA18736C823E(L_7, NULL);
		bool L_9;
		L_9 = ReflectionTools_DoesTypeImplement_m76A5EBA9D9AF0CCCD6DE916990142B42729852D0(L_6, L_8, NULL);
		if (!L_9)
		{
			goto IL_003e;
		}
	}
	{
		ControllerHelper_GvCjhtmZKTjoCfDmlBakKLlNmytw_m9DC734593CC123774A27BDC3884BD4680C935AD5(__this, NULL);
		return;
	}

IL_003e:
	{
		Type_t* L_10 = V_0;
		RuntimeTypeHandle_t332A452B8B6179E4469B69525D0FE82A88030F7B L_11 = { reinterpret_cast<intptr_t> (Keyboard_t3FD52938480ACCD23FDB0DAEC857F9A9D29CC6C3_0_0_0_var) };
		il2cpp_codegen_runtime_class_init_inline(Type_t_il2cpp_TypeInfo_var);
		Type_t* L_12;
		L_12 = Type_GetTypeFromHandle_m2570A2A5B32A5E9D9F0F38B37459DA18736C823E(L_11, NULL);
		bool L_13;
		L_13 = ReflectionTools_DoesTypeImplement_m76A5EBA9D9AF0CCCD6DE916990142B42729852D0(L_10, L_12, NULL);
		if (!L_13)
		{
			goto IL_0058;
		}
	}
	{
		ControllerHelper_set_hasKeyboard_m4CBEA22EB6AF7DC13CE067FAC0B5845FF05052E3(__this, (bool)0, NULL);
		return;
	}

IL_0058:
	{
		Type_t* L_14 = V_0;
		RuntimeTypeHandle_t332A452B8B6179E4469B69525D0FE82A88030F7B L_15 = { reinterpret_cast<intptr_t> (Mouse_t5C8D9CB89A5C0F4EE87A70501CAF2A68E36DC019_0_0_0_var) };
		il2cpp_codegen_runtime_class_init_inline(Type_t_il2cpp_TypeInfo_var);
		Type_t* L_16;
		L_16 = Type_GetTypeFromHandle_m2570A2A5B32A5E9D9F0F38B37459DA18736C823E(L_15, NULL);
		bool L_17;
		L_17 = ReflectionTools_DoesTypeImplement_m76A5EBA9D9AF0CCCD6DE916990142B42729852D0(L_14, L_16, NULL);
		if (!L_17)
		{
			goto IL_0072;
		}
	}
	{
		ControllerHelper_set_hasMouse_m94C0658F438252E89380DFCDDCF8553D4A44E4A2(__this, (bool)0, NULL);
		return;
	}

IL_0072:
	{
		Type_t* L_18 = V_0;
		RuntimeTypeHandle_t332A452B8B6179E4469B69525D0FE82A88030F7B L_19 = { reinterpret_cast<intptr_t> (CustomController_t749B7DF2AA8AD20FEC4C2003C4FF5000FE9C6065_0_0_0_var) };
		il2cpp_codegen_runtime_class_init_inline(Type_t_il2cpp_TypeInfo_var);
		Type_t* L_20;
		L_20 = Type_GetTypeFromHandle_m2570A2A5B32A5E9D9F0F38B37459DA18736C823E(L_19, NULL);
		bool L_21;
		L_21 = ReflectionTools_DoesTypeImplement_m76A5EBA9D9AF0CCCD6DE916990142B42729852D0(L_18, L_20, NULL);
		if (!L_21)
		{
			goto IL_008b;
		}
	}
	{
		ControllerHelper_jEJlbBlAfPAlWHhdiSXmnzeRQZnH_m4B85C77E77C949D3451279EF99220673C34F9C63(__this, NULL);
		return;
	}

IL_008b:
	{
		Type_t* L_22 = V_0;
		RuntimeTypeHandle_t332A452B8B6179E4469B69525D0FE82A88030F7B L_23 = { reinterpret_cast<intptr_t> (Controller_t919A4A50FC7A0F25D7B31615C0F4E4D4A4D17911_0_0_0_var) };
		il2cpp_codegen_runtime_class_init_inline(Type_t_il2cpp_TypeInfo_var);
		Type_t* L_24;
		L_24 = Type_GetTypeFromHandle_m2570A2A5B32A5E9D9F0F38B37459DA18736C823E(L_23, NULL);
		if ((!(((RuntimeObject*)(Type_t*)L_22) == ((RuntimeObject*)(Type_t*)L_24))))
		{
			goto IL_009f;
		}
	}
	{
		ControllerHelper_ClearAllControllers_m7B7DF7080B87AFADA23298101E1D4DFD231D23AF(__this, NULL);
		return;
	}

IL_009f:
	{
		NotImplementedException_t6366FE4DCF15094C51F4833B91A2AE68D4DA90E8* L_25 = (NotImplementedException_t6366FE4DCF15094C51F4833B91A2AE68D4DA90E8*)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&NotImplementedException_t6366FE4DCF15094C51F4833B91A2AE68D4DA90E8_il2cpp_TypeInfo_var)));
		NotImplementedException__ctor_mDAB47BC6BD0E342E8F2171E5CABE3E67EA049F1C(L_25, /*hidden argument*/NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_25, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&ControllerHelper_ClearControllersOfType_TisRuntimeObject_m3A464E94EEE7C002084282F8CB053F8871CB1015_RuntimeMethod_var)));
	}
}
// System.Boolean Rewired.Player/ControllerHelper::ContainsController<System.Object>(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool ControllerHelper_ContainsController_TisRuntimeObject_m119A6EFFE075F0F6633FB32AA289DA9C7244CC8F_gshared (ControllerHelper_tCE72EA23053BD0C6ECB4D75A69F8CD1B3AC28FF6* __this, int32_t ___controllerId0, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&CustomController_t749B7DF2AA8AD20FEC4C2003C4FF5000FE9C6065_0_0_0_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Joystick_tEC65D4846A553E83F365E7D8D263DC644C75FC11_0_0_0_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Keyboard_t3FD52938480ACCD23FDB0DAEC857F9A9D29CC6C3_0_0_0_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Mouse_t5C8D9CB89A5C0F4EE87A70501CAF2A68E36DC019_0_0_0_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Type_t_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
Type_t* V_0 = NULL;
	{
		il2cpp_codegen_runtime_class_init_inline(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		int32_t L_0 = ((ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_StaticFields*)il2cpp_codegen_static_fields_for(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var))->____id_29;
		int32_t L_1 = (int32_t)__this->___eNyGUiEiMyquCTKLRhFvpeyOvzMm_11;
		if ((((int32_t)L_0) == ((int32_t)L_1)))
		{
			goto IL_001b;
		}
	}
	{
		int32_t L_2 = (int32_t)__this->___eNyGUiEiMyquCTKLRhFvpeyOvzMm_11;
		il2cpp_codegen_runtime_class_init_inline(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		bool L_3;
		L_3 = ReInput_CheckInitialized_mAAC593CB03C886BDB7B72864FBB1A59B2B0530AF(L_2, NULL);
		return (bool)0;
	}

IL_001b:
	{
		RuntimeTypeHandle_t332A452B8B6179E4469B69525D0FE82A88030F7B L_4 = { reinterpret_cast<intptr_t> (il2cpp_rgctx_type(method->rgctx_data, 0)) };
		il2cpp_codegen_runtime_class_init_inline(Type_t_il2cpp_TypeInfo_var);
		Type_t* L_5;
		L_5 = Type_GetTypeFromHandle_m2570A2A5B32A5E9D9F0F38B37459DA18736C823E(L_4, NULL);
		V_0 = L_5;
		Type_t* L_6 = V_0;
		RuntimeTypeHandle_t332A452B8B6179E4469B69525D0FE82A88030F7B L_7 = { reinterpret_cast<intptr_t> (Joystick_tEC65D4846A553E83F365E7D8D263DC644C75FC11_0_0_0_var) };
		Type_t* L_8;
		L_8 = Type_GetTypeFromHandle_m2570A2A5B32A5E9D9F0F38B37459DA18736C823E(L_7, NULL);
		bool L_9;
		L_9 = ReflectionTools_DoesTypeImplement_m76A5EBA9D9AF0CCCD6DE916990142B42729852D0(L_6, L_8, NULL);
		if (!L_9)
		{
			goto IL_0041;
		}
	}
	{
		int32_t L_10 = ___controllerId0;
		bool L_11;
		L_11 = ControllerHelper_ContainsController_m35DD14B54E4F337A0CCBA7CA5CEB1B57705B8BBE(__this, (int32_t)2, L_10, NULL);
		return L_11;
	}

IL_0041:
	{
		Type_t* L_12 = V_0;
		RuntimeTypeHandle_t332A452B8B6179E4469B69525D0FE82A88030F7B L_13 = { reinterpret_cast<intptr_t> (Keyboard_t3FD52938480ACCD23FDB0DAEC857F9A9D29CC6C3_0_0_0_var) };
		il2cpp_codegen_runtime_class_init_inline(Type_t_il2cpp_TypeInfo_var);
		Type_t* L_14;
		L_14 = Type_GetTypeFromHandle_m2570A2A5B32A5E9D9F0F38B37459DA18736C823E(L_13, NULL);
		bool L_15;
		L_15 = ReflectionTools_DoesTypeImplement_m76A5EBA9D9AF0CCCD6DE916990142B42729852D0(L_12, L_14, NULL);
		if (!L_15)
		{
			goto IL_005a;
		}
	}
	{
		bool L_16 = (bool)__this->___dBLcgVfbQAfhgyHLKVtzegFukmFdb_2;
		return L_16;
	}

IL_005a:
	{
		Type_t* L_17 = V_0;
		RuntimeTypeHandle_t332A452B8B6179E4469B69525D0FE82A88030F7B L_18 = { reinterpret_cast<intptr_t> (Mouse_t5C8D9CB89A5C0F4EE87A70501CAF2A68E36DC019_0_0_0_var) };
		il2cpp_codegen_runtime_class_init_inline(Type_t_il2cpp_TypeInfo_var);
		Type_t* L_19;
		L_19 = Type_GetTypeFromHandle_m2570A2A5B32A5E9D9F0F38B37459DA18736C823E(L_18, NULL);
		bool L_20;
		L_20 = ReflectionTools_DoesTypeImplement_m76A5EBA9D9AF0CCCD6DE916990142B42729852D0(L_17, L_19, NULL);
		if (!L_20)
		{
			goto IL_0073;
		}
	}
	{
		bool L_21 = (bool)__this->___AGJkYNtGyvZWiyWIaEfTgcpraKBu_1;
		return L_21;
	}

IL_0073:
	{
		Type_t* L_22 = V_0;
		RuntimeTypeHandle_t332A452B8B6179E4469B69525D0FE82A88030F7B L_23 = { reinterpret_cast<intptr_t> (CustomController_t749B7DF2AA8AD20FEC4C2003C4FF5000FE9C6065_0_0_0_var) };
		il2cpp_codegen_runtime_class_init_inline(Type_t_il2cpp_TypeInfo_var);
		Type_t* L_24;
		L_24 = Type_GetTypeFromHandle_m2570A2A5B32A5E9D9F0F38B37459DA18736C823E(L_23, NULL);
		bool L_25;
		L_25 = ReflectionTools_DoesTypeImplement_m76A5EBA9D9AF0CCCD6DE916990142B42729852D0(L_22, L_24, NULL);
		if (!L_25)
		{
			goto IL_008f;
		}
	}
	{
		int32_t L_26 = ___controllerId0;
		bool L_27;
		L_27 = ControllerHelper_ContainsController_m35DD14B54E4F337A0CCBA7CA5CEB1B57705B8BBE(__this, (int32_t)((int32_t)20), L_26, NULL);
		return L_27;
	}

IL_008f:
	{
		NotImplementedException_t6366FE4DCF15094C51F4833B91A2AE68D4DA90E8* L_28 = (NotImplementedException_t6366FE4DCF15094C51F4833B91A2AE68D4DA90E8*)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&NotImplementedException_t6366FE4DCF15094C51F4833B91A2AE68D4DA90E8_il2cpp_TypeInfo_var)));
		NotImplementedException__ctor_mDAB47BC6BD0E342E8F2171E5CABE3E67EA049F1C(L_28, /*hidden argument*/NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_28, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&ControllerHelper_ContainsController_TisRuntimeObject_m119A6EFFE075F0F6633FB32AA289DA9C7244CC8F_RuntimeMethod_var)));
	}
}
// T Rewired.Player/ControllerHelper::GetController<System.Object>(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* ControllerHelper_GetController_TisRuntimeObject_mF277F0BD77B2A753B23F44ADC88FFE74249637FA_gshared (ControllerHelper_tCE72EA23053BD0C6ECB4D75A69F8CD1B3AC28FF6* __this, int32_t ___controllerId0, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ftuHLSCvHbrPYKqmDICMGujVuqLSA_tD67CC6A3A416E57262B63617FA5896CF7BF4F187_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
RuntimeObject* V_0 = NULL;
	{
		il2cpp_codegen_runtime_class_init_inline(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		int32_t L_0 = ((ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_StaticFields*)il2cpp_codegen_static_fields_for(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var))->____id_29;
		int32_t L_1 = (int32_t)__this->___eNyGUiEiMyquCTKLRhFvpeyOvzMm_11;
		if ((((int32_t)L_0) == ((int32_t)L_1)))
		{
			goto IL_0023;
		}
	}
	{
		int32_t L_2 = (int32_t)__this->___eNyGUiEiMyquCTKLRhFvpeyOvzMm_11;
		il2cpp_codegen_runtime_class_init_inline(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		bool L_3;
		L_3 = ReInput_CheckInitialized_mAAC593CB03C886BDB7B72864FBB1A59B2B0530AF(L_2, NULL);
		il2cpp_codegen_initobj((&V_0), sizeof(RuntimeObject*));
		RuntimeObject* L_4 = V_0;
		return L_4;
	}

IL_0023:
	{
		vpfVMfLDNQCKabtrXuyMMndafvvoA_t24DAE63535EED93A1490AC97901F2551704D116D* L_5 = (vpfVMfLDNQCKabtrXuyMMndafvvoA_t24DAE63535EED93A1490AC97901F2551704D116D*)__this->___rGIwSbUPDgDDJByCitUBBGoZDlmc_0;
		int32_t L_6;
		L_6 = ((  int32_t (*) (const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->rgctx_data, 0)))(il2cpp_rgctx_method(method->rgctx_data, 0));
		NullCheck(L_5);
		RuntimeObject* L_7;
		L_7 = vpfVMfLDNQCKabtrXuyMMndafvvoA_OlLACmpwoMamrxMTFzLaRnppBEGFA_m7D256F4AAE84410B2D3EC0217ADB4B49A6AE0B9F(L_5, L_6, NULL);
		int32_t L_8 = ___controllerId0;
		NullCheck(L_7);
		Controller_t919A4A50FC7A0F25D7B31615C0F4E4D4A4D17911* L_9;
		L_9 = InterfaceFuncInvoker1< Controller_t919A4A50FC7A0F25D7B31615C0F4E4D4A4D17911*, int32_t >::Invoke(8 /* Rewired.Controller Rewired.Player/ControllerHelper/ftuHLSCvHbrPYKqmDICMGujVuqLSA::iHjWKUjxjIbfxJGMlQawYEzuOyWc(System.Int32) */, ftuHLSCvHbrPYKqmDICMGujVuqLSA_tD67CC6A3A416E57262B63617FA5896CF7BF4F187_il2cpp_TypeInfo_var, L_7, L_8);
		return ((RuntimeObject*)Castclass((RuntimeObject*)L_9, il2cpp_rgctx_data(method->rgctx_data, 1)));
	}
}
// System.Collections.Generic.IList`1<TInterface> Rewired.Player/ControllerHelper::GetControllerTemplates<System.Object>()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* ControllerHelper_GetControllerTemplates_TisRuntimeObject_m976297409F461C3A8492B54E24C41CEDE716637D_gshared (ControllerHelper_tCE72EA23053BD0C6ECB4D75A69F8CD1B3AC28FF6* __this, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
{
		il2cpp_codegen_runtime_class_init_inline(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		int32_t L_0 = ((ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_StaticFields*)il2cpp_codegen_static_fields_for(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var))->____id_29;
		int32_t L_1 = (int32_t)__this->___eNyGUiEiMyquCTKLRhFvpeyOvzMm_11;
		if ((((int32_t)L_0) == ((int32_t)L_1)))
		{
			goto IL_001f;
		}
	}
	{
		int32_t L_2 = (int32_t)__this->___eNyGUiEiMyquCTKLRhFvpeyOvzMm_11;
		il2cpp_codegen_runtime_class_init_inline(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		bool L_3;
		L_3 = ReInput_CheckInitialized_mAAC593CB03C886BDB7B72864FBB1A59B2B0530AF(L_2, NULL);
		RuntimeObject* L_4;
		L_4 = ((  RuntimeObject* (*) (const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->rgctx_data, 0)))(il2cpp_rgctx_method(method->rgctx_data, 0));
		return L_4;
	}

IL_001f:
	{
		PjzdStrqNkNQSljwEZWJWYcQhjVQ_tA22AE52C8C2CD0639BCE85B3BE860B096AFBC1EA* L_5 = (PjzdStrqNkNQSljwEZWJWYcQhjVQ_tA22AE52C8C2CD0639BCE85B3BE860B096AFBC1EA*)__this->___WejqIIyLtJZYzZEyxGBqHOkJzsOl_10;
		NullCheck(L_5);
		RuntimeObject* L_6;
		L_6 = ((  RuntimeObject* (*) (PjzdStrqNkNQSljwEZWJWYcQhjVQ_tA22AE52C8C2CD0639BCE85B3BE860B096AFBC1EA*, const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->rgctx_data, 2)))(L_5, il2cpp_rgctx_method(method->rgctx_data, 2));
		return L_6;
	}
}
// T Rewired.Player/ControllerHelper::GetControllerWithTag<System.Object>(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* ControllerHelper_GetControllerWithTag_TisRuntimeObject_mA4E62042AFD6920A14E97EC5158C9D0669426CCE_gshared (ControllerHelper_tCE72EA23053BD0C6ECB4D75A69F8CD1B3AC28FF6* __this, String_t* ___tag0, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ftuHLSCvHbrPYKqmDICMGujVuqLSA_tD67CC6A3A416E57262B63617FA5896CF7BF4F187_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
RuntimeObject* V_0 = NULL;
	{
		il2cpp_codegen_runtime_class_init_inline(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		int32_t L_0 = ((ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_StaticFields*)il2cpp_codegen_static_fields_for(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var))->____id_29;
		int32_t L_1 = (int32_t)__this->___eNyGUiEiMyquCTKLRhFvpeyOvzMm_11;
		if ((((int32_t)L_0) == ((int32_t)L_1)))
		{
			goto IL_0023;
		}
	}
	{
		int32_t L_2 = (int32_t)__this->___eNyGUiEiMyquCTKLRhFvpeyOvzMm_11;
		il2cpp_codegen_runtime_class_init_inline(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		bool L_3;
		L_3 = ReInput_CheckInitialized_mAAC593CB03C886BDB7B72864FBB1A59B2B0530AF(L_2, NULL);
		il2cpp_codegen_initobj((&V_0), sizeof(RuntimeObject*));
		RuntimeObject* L_4 = V_0;
		return L_4;
	}

IL_0023:
	{
		vpfVMfLDNQCKabtrXuyMMndafvvoA_t24DAE63535EED93A1490AC97901F2551704D116D* L_5 = (vpfVMfLDNQCKabtrXuyMMndafvvoA_t24DAE63535EED93A1490AC97901F2551704D116D*)__this->___rGIwSbUPDgDDJByCitUBBGoZDlmc_0;
		int32_t L_6;
		L_6 = ((  int32_t (*) (const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->rgctx_data, 0)))(il2cpp_rgctx_method(method->rgctx_data, 0));
		NullCheck(L_5);
		RuntimeObject* L_7;
		L_7 = vpfVMfLDNQCKabtrXuyMMndafvvoA_OlLACmpwoMamrxMTFzLaRnppBEGFA_m7D256F4AAE84410B2D3EC0217ADB4B49A6AE0B9F(L_5, L_6, NULL);
		String_t* L_8 = ___tag0;
		NullCheck(L_7);
		Controller_t919A4A50FC7A0F25D7B31615C0F4E4D4A4D17911* L_9;
		L_9 = InterfaceFuncInvoker1< Controller_t919A4A50FC7A0F25D7B31615C0F4E4D4A4D17911*, String_t* >::Invoke(9 /* Rewired.Controller Rewired.Player/ControllerHelper/ftuHLSCvHbrPYKqmDICMGujVuqLSA::MEIqyUjixjtdzISDyAuzubqlNtrj(System.String) */, ftuHLSCvHbrPYKqmDICMGujVuqLSA_tD67CC6A3A416E57262B63617FA5896CF7BF4F187_il2cpp_TypeInfo_var, L_7, L_8);
		return ((RuntimeObject*)Castclass((RuntimeObject*)L_9, il2cpp_rgctx_data(method->rgctx_data, 1)));
	}
}
// Rewired.Controller Rewired.Player/ControllerHelper::GetFirstControllerWithTemplate<System.Object>()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Controller_t919A4A50FC7A0F25D7B31615C0F4E4D4A4D17911* ControllerHelper_GetFirstControllerWithTemplate_TisRuntimeObject_mB9854032DDBB21BAF7F3E766629AA9E2803C79E3_gshared (ControllerHelper_tCE72EA23053BD0C6ECB4D75A69F8CD1B3AC28FF6* __this, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Type_t_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
{
		RuntimeTypeHandle_t332A452B8B6179E4469B69525D0FE82A88030F7B L_0 = { reinterpret_cast<intptr_t> (il2cpp_rgctx_type(method->rgctx_data, 0)) };
		il2cpp_codegen_runtime_class_init_inline(Type_t_il2cpp_TypeInfo_var);
		Type_t* L_1;
		L_1 = Type_GetTypeFromHandle_m2570A2A5B32A5E9D9F0F38B37459DA18736C823E(L_0, NULL);
		Controller_t919A4A50FC7A0F25D7B31615C0F4E4D4A4D17911* L_2;
		L_2 = ControllerHelper_GetFirstControllerWithTemplate_m810A5039CAC0C0F95065EB302E7CA142034ADBCF(__this, L_1, NULL);
		return L_2;
	}
}
// Rewired.Controller Rewired.Player/ControllerHelper::GetLastActiveController<System.Object>()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Controller_t919A4A50FC7A0F25D7B31615C0F4E4D4A4D17911* ControllerHelper_GetLastActiveController_TisRuntimeObject_m8A195C8116B2674AE002B347E34A1D97893108A5_gshared (ControllerHelper_tCE72EA23053BD0C6ECB4D75A69F8CD1B3AC28FF6* __this, const RuntimeMethod* method) 
{
{
		int32_t L_0;
		L_0 = ((  int32_t (*) (const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->rgctx_data, 0)))(il2cpp_rgctx_method(method->rgctx_data, 0));
		Controller_t919A4A50FC7A0F25D7B31615C0F4E4D4A4D17911* L_1;
		L_1 = ControllerHelper_GetLastActiveController_m12A09469960F0059850D2A5B8002C6298235F92E(__this, L_0, NULL);
		return L_1;
	}
}
// System.Void Rewired.Player/ControllerHelper::RemoveController<System.Object>(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ControllerHelper_RemoveController_TisRuntimeObject_m7AFE1635F269A0DC03154E31D68E2BE5777FFC52_gshared (ControllerHelper_tCE72EA23053BD0C6ECB4D75A69F8CD1B3AC28FF6* __this, int32_t ___controllerId0, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&CustomController_t749B7DF2AA8AD20FEC4C2003C4FF5000FE9C6065_0_0_0_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Joystick_tEC65D4846A553E83F365E7D8D263DC644C75FC11_0_0_0_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Keyboard_t3FD52938480ACCD23FDB0DAEC857F9A9D29CC6C3_0_0_0_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Mouse_t5C8D9CB89A5C0F4EE87A70501CAF2A68E36DC019_0_0_0_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Type_t_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
Type_t* V_0 = NULL;
	{
		il2cpp_codegen_runtime_class_init_inline(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		int32_t L_0 = ((ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_StaticFields*)il2cpp_codegen_static_fields_for(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var))->____id_29;
		int32_t L_1 = (int32_t)__this->___eNyGUiEiMyquCTKLRhFvpeyOvzMm_11;
		if ((((int32_t)L_0) == ((int32_t)L_1)))
		{
			goto IL_001a;
		}
	}
	{
		int32_t L_2 = (int32_t)__this->___eNyGUiEiMyquCTKLRhFvpeyOvzMm_11;
		il2cpp_codegen_runtime_class_init_inline(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		bool L_3;
		L_3 = ReInput_CheckInitialized_mAAC593CB03C886BDB7B72864FBB1A59B2B0530AF(L_2, NULL);
		return;
	}

IL_001a:
	{
		RuntimeTypeHandle_t332A452B8B6179E4469B69525D0FE82A88030F7B L_4 = { reinterpret_cast<intptr_t> (il2cpp_rgctx_type(method->rgctx_data, 0)) };
		il2cpp_codegen_runtime_class_init_inline(Type_t_il2cpp_TypeInfo_var);
		Type_t* L_5;
		L_5 = Type_GetTypeFromHandle_m2570A2A5B32A5E9D9F0F38B37459DA18736C823E(L_4, NULL);
		V_0 = L_5;
		Type_t* L_6 = V_0;
		RuntimeTypeHandle_t332A452B8B6179E4469B69525D0FE82A88030F7B L_7 = { reinterpret_cast<intptr_t> (Joystick_tEC65D4846A553E83F365E7D8D263DC644C75FC11_0_0_0_var) };
		Type_t* L_8;
		L_8 = Type_GetTypeFromHandle_m2570A2A5B32A5E9D9F0F38B37459DA18736C823E(L_7, NULL);
		bool L_9;
		L_9 = ReflectionTools_DoesTypeImplement_m76A5EBA9D9AF0CCCD6DE916990142B42729852D0(L_6, L_8, NULL);
		if (!L_9)
		{
			goto IL_003f;
		}
	}
	{
		int32_t L_10 = ___controllerId0;
		ControllerHelper_sEwRxcjRcvYLfZwkgSvIBxUPgqwA_m73C76BF07A11F3015469DF102EEEE5BB60C04148(__this, L_10, NULL);
		return;
	}

IL_003f:
	{
		Type_t* L_11 = V_0;
		RuntimeTypeHandle_t332A452B8B6179E4469B69525D0FE82A88030F7B L_12 = { reinterpret_cast<intptr_t> (Keyboard_t3FD52938480ACCD23FDB0DAEC857F9A9D29CC6C3_0_0_0_var) };
		il2cpp_codegen_runtime_class_init_inline(Type_t_il2cpp_TypeInfo_var);
		Type_t* L_13;
		L_13 = Type_GetTypeFromHandle_m2570A2A5B32A5E9D9F0F38B37459DA18736C823E(L_12, NULL);
		bool L_14;
		L_14 = ReflectionTools_DoesTypeImplement_m76A5EBA9D9AF0CCCD6DE916990142B42729852D0(L_11, L_13, NULL);
		if (!L_14)
		{
			goto IL_005a;
		}
	}
	{
		ControllerHelper_RemoveController_m94BAB4F8423E1D4FCA1C5D17314192E359E65D29(__this, (int32_t)0, 0, NULL);
		return;
	}

IL_005a:
	{
		Type_t* L_15 = V_0;
		RuntimeTypeHandle_t332A452B8B6179E4469B69525D0FE82A88030F7B L_16 = { reinterpret_cast<intptr_t> (Mouse_t5C8D9CB89A5C0F4EE87A70501CAF2A68E36DC019_0_0_0_var) };
		il2cpp_codegen_runtime_class_init_inline(Type_t_il2cpp_TypeInfo_var);
		Type_t* L_17;
		L_17 = Type_GetTypeFromHandle_m2570A2A5B32A5E9D9F0F38B37459DA18736C823E(L_16, NULL);
		bool L_18;
		L_18 = ReflectionTools_DoesTypeImplement_m76A5EBA9D9AF0CCCD6DE916990142B42729852D0(L_15, L_17, NULL);
		if (!L_18)
		{
			goto IL_0075;
		}
	}
	{
		ControllerHelper_RemoveController_m94BAB4F8423E1D4FCA1C5D17314192E359E65D29(__this, (int32_t)1, 0, NULL);
		return;
	}

IL_0075:
	{
		Type_t* L_19 = V_0;
		RuntimeTypeHandle_t332A452B8B6179E4469B69525D0FE82A88030F7B L_20 = { reinterpret_cast<intptr_t> (CustomController_t749B7DF2AA8AD20FEC4C2003C4FF5000FE9C6065_0_0_0_var) };
		il2cpp_codegen_runtime_class_init_inline(Type_t_il2cpp_TypeInfo_var);
		Type_t* L_21;
		L_21 = Type_GetTypeFromHandle_m2570A2A5B32A5E9D9F0F38B37459DA18736C823E(L_20, NULL);
		bool L_22;
		L_22 = ReflectionTools_DoesTypeImplement_m76A5EBA9D9AF0CCCD6DE916990142B42729852D0(L_19, L_21, NULL);
		if (!L_22)
		{
			goto IL_008f;
		}
	}
	{
		int32_t L_23 = ___controllerId0;
		ControllerHelper_YIlmnpncuhGTKbGYeWwxpJbXbqGIA_m1154A7311E6E34EF891BD65EE9CEAB2C3783D67E(__this, L_23, NULL);
		return;
	}

IL_008f:
	{
		NotImplementedException_t6366FE4DCF15094C51F4833B91A2AE68D4DA90E8* L_24 = (NotImplementedException_t6366FE4DCF15094C51F4833B91A2AE68D4DA90E8*)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&NotImplementedException_t6366FE4DCF15094C51F4833B91A2AE68D4DA90E8_il2cpp_TypeInfo_var)));
		NotImplementedException__ctor_mDAB47BC6BD0E342E8F2171E5CABE3E67EA049F1C(L_24, /*hidden argument*/NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_24, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&ControllerHelper_RemoveController_TisRuntimeObject_m7AFE1635F269A0DC03154E31D68E2BE5777FFC52_RuntimeMethod_var)));
	}
}
// System.Boolean Rewired.Player/ControllerHelper::SNzRlFbQEpVhwiLVFuaYfUHVXaWi<System.Object>(Rewired.UnknownControllerHat/HatButtons,System.Int32,TBSPGJPKaXrjsOpBQZPxJnrcfSfAA`1<?>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool ControllerHelper_SNzRlFbQEpVhwiLVFuaYfUHVXaWi_TisRuntimeObject_m388B1C3D01E9412E2C80B268828ACCA5EFF773D4_gshared (ControllerHelper_tCE72EA23053BD0C6ECB4D75A69F8CD1B3AC28FF6* __this, HatButtons_tCE5F7476A54D0F5DF7FA0EB11FF2C753B51DDE03* p0, int32_t p1, TBSPGJPKaXrjsOpBQZPxJnrcfSfAA_1_t92F77A2C0897D802673079FA32163CACC9FD23DE* p2, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
{
		HatButtons_tCE5F7476A54D0F5DF7FA0EB11FF2C753B51DDE03* L_0 = p0;
		if (L_0)
		{
			goto IL_0005;
		}
	}
	{
		return (bool)0;
	}

IL_0005:
	{
		il2cpp_codegen_runtime_class_init_inline(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		ConfigVars_t4EC82ACF63376F1869FDC3D0E223EDCE149CF4A3* L_1;
		L_1 = ReInput_get_configVars_m62E24BBE60949886F36F909C895B98208BCCC8ED_inline(NULL);
		NullCheck(L_1);
		bool L_2 = (bool)L_1->___force4WayHats_49;
		if (!L_2)
		{
			goto IL_0013;
		}
	}
	{
		return (bool)1;
	}

IL_0013:
	{
		HatButtons_tCE5F7476A54D0F5DF7FA0EB11FF2C753B51DDE03* L_3 = p0;
		int32_t L_4 = p1;
		TBSPGJPKaXrjsOpBQZPxJnrcfSfAA_1_t92F77A2C0897D802673079FA32163CACC9FD23DE* L_5 = p2;
		bool L_6;
		L_6 = ((  bool (*) (ControllerHelper_tCE72EA23053BD0C6ECB4D75A69F8CD1B3AC28FF6*, HatButtons_tCE5F7476A54D0F5DF7FA0EB11FF2C753B51DDE03*, int32_t, TBSPGJPKaXrjsOpBQZPxJnrcfSfAA_1_t92F77A2C0897D802673079FA32163CACC9FD23DE*, const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->rgctx_data, 0)))(__this, L_3, L_4, L_5, il2cpp_rgctx_method(method->rgctx_data, 0));
		if (!L_6)
		{
			goto IL_0020;
		}
	}
	{
		return (bool)0;
	}

IL_0020:
	{
		return (bool)1;
	}
}
// System.Boolean Rewired.Player/ControllerHelper::UbTQMieaIDWgOEgZRXzBrBRzUDQi<System.Object>(Rewired.ControllerWithAxes,System.Int32,System.Int32,Rewired.ActionElementMap,TBSPGJPKaXrjsOpBQZPxJnrcfSfAA`1<?>,System.Int32,System.Single&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool ControllerHelper_UbTQMieaIDWgOEgZRXzBrBRzUDQi_TisRuntimeObject_m4A339BD7232C19046D83999ED9BA50DB15C418FB_gshared (ControllerHelper_tCE72EA23053BD0C6ECB4D75A69F8CD1B3AC28FF6* __this, ControllerWithAxes_tF5DF4B1A98C0326D31E6AC481DEBC2D90E44BBF2* p0, int32_t p1, int32_t p2, ActionElementMap_t0EBE3E5D3A5DF3BA6D35F8082ED2232404EFF8CF* p3, TBSPGJPKaXrjsOpBQZPxJnrcfSfAA_1_t92F77A2C0897D802673079FA32163CACC9FD23DE* p4, int32_t p5, float* p6, const RuntimeMethod* method) 
{
HatButtons_tCE5F7476A54D0F5DF7FA0EB11FF2C753B51DDE03* V_0 = NULL;
	int32_t V_1 = 0;
	int32_t V_2 = 0;
	{
		ControllerWithAxes_tF5DF4B1A98C0326D31E6AC481DEBC2D90E44BBF2* L_0 = p0;
		NullCheck(L_0);
		ControllerDataUpdater_tEA424134962ED8FCA977957E8CAE6B6521D67788* L_1 = (ControllerDataUpdater_tEA424134962ED8FCA977957E8CAE6B6521D67788*)((Controller_t919A4A50FC7A0F25D7B31615C0F4E4D4A4D17911*)L_0)->___luXPZItLRMwFxNAWMfXihrwEgVTc_20;
		int32_t L_2 = p2;
		NullCheck(L_1);
		bool L_3;
		L_3 = ControllerDataUpdater_IsUnknownHatCardinal_m0CA7BB22756F8BD2E6B4EAC4A920BEA4ADB0677E(L_1, L_2, NULL);
		if (L_3)
		{
			goto IL_0010;
		}
	}
	{
		return (bool)0;
	}

IL_0010:
	{
		ControllerWithAxes_tF5DF4B1A98C0326D31E6AC481DEBC2D90E44BBF2* L_4 = p0;
		NullCheck(L_4);
		ControllerDataUpdater_tEA424134962ED8FCA977957E8CAE6B6521D67788* L_5 = (ControllerDataUpdater_tEA424134962ED8FCA977957E8CAE6B6521D67788*)((Controller_t919A4A50FC7A0F25D7B31615C0F4E4D4A4D17911*)L_4)->___luXPZItLRMwFxNAWMfXihrwEgVTc_20;
		int32_t L_6 = p2;
		NullCheck(L_5);
		HatButtons_tCE5F7476A54D0F5DF7FA0EB11FF2C753B51DDE03* L_7;
		L_7 = ControllerDataUpdater_GetUnknownHatButtons_m366B42FB92F75DC462492F999B5B9B7F264D60AB(L_5, L_6, NULL);
		V_0 = L_7;
		HatButtons_tCE5F7476A54D0F5DF7FA0EB11FF2C753B51DDE03* L_8 = V_0;
		int32_t L_9 = p1;
		TBSPGJPKaXrjsOpBQZPxJnrcfSfAA_1_t92F77A2C0897D802673079FA32163CACC9FD23DE* L_10 = p4;
		bool L_11;
		L_11 = ((  bool (*) (ControllerHelper_tCE72EA23053BD0C6ECB4D75A69F8CD1B3AC28FF6*, HatButtons_tCE5F7476A54D0F5DF7FA0EB11FF2C753B51DDE03*, int32_t, TBSPGJPKaXrjsOpBQZPxJnrcfSfAA_1_t92F77A2C0897D802673079FA32163CACC9FD23DE*, const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->rgctx_data, 0)))(__this, L_8, L_9, L_10, il2cpp_rgctx_method(method->rgctx_data, 0));
		if (!L_11)
		{
			goto IL_0059;
		}
	}
	{
		HatButtons_tCE5F7476A54D0F5DF7FA0EB11FF2C753B51DDE03* L_12 = V_0;
		int32_t L_13 = p2;
		NullCheck(L_12);
		HatButtons_GetNeighbors_mE9F5E990C5B8EA4FD98CB2BC381DEF41BCF923DB(L_12, L_13, (&V_1), (&V_2), NULL);
		ControllerWithAxes_tF5DF4B1A98C0326D31E6AC481DEBC2D90E44BBF2* L_14 = p0;
		int32_t L_15 = V_1;
		NullCheck((Controller_t919A4A50FC7A0F25D7B31615C0F4E4D4A4D17911*)L_14);
		bool L_16;
		L_16 = VirtualFuncInvoker1< bool, int32_t >::Invoke(8 /* System.Boolean Rewired.Controller::GetButton(System.Int32) */, (Controller_t919A4A50FC7A0F25D7B31615C0F4E4D4A4D17911*)L_14, L_15);
		if (L_16)
		{
			goto IL_0046;
		}
	}
	{
		ControllerWithAxes_tF5DF4B1A98C0326D31E6AC481DEBC2D90E44BBF2* L_17 = p0;
		int32_t L_18 = V_2;
		NullCheck((Controller_t919A4A50FC7A0F25D7B31615C0F4E4D4A4D17911*)L_17);
		bool L_19;
		L_19 = VirtualFuncInvoker1< bool, int32_t >::Invoke(8 /* System.Boolean Rewired.Controller::GetButton(System.Int32) */, (Controller_t919A4A50FC7A0F25D7B31615C0F4E4D4A4D17911*)L_17, L_18);
		if (!L_19)
		{
			goto IL_0059;
		}
	}

IL_0046:
	{
		ControllerWithAxes_tF5DF4B1A98C0326D31E6AC481DEBC2D90E44BBF2* L_20 = p0;
		ActionElementMap_t0EBE3E5D3A5DF3BA6D35F8082ED2232404EFF8CF* L_21 = p3;
		int32_t L_22 = p5;
		float* L_23 = p6;
		NullCheck((Controller_t919A4A50FC7A0F25D7B31615C0F4E4D4A4D17911*)L_20);
		bool L_24;
		L_24 = Controller_cpEczqMFPCBfKdwpHaSAfaDMNEJPA_m495DD9BAF787828FB89D8511D1439DF15869E993((Controller_t919A4A50FC7A0F25D7B31615C0F4E4D4A4D17911*)L_20, L_21, L_22, (bool)1, L_23, NULL);
		if (L_24)
		{
			goto IL_0057;
		}
	}
	{
		return (bool)0;
	}

IL_0057:
	{
		return (bool)1;
	}

IL_0059:
	{
		return (bool)0;
	}
}
// System.Boolean Rewired.Player/ControllerHelper::UilHbxGPUgUwwschnVvYYamXHzUl<System.Object>(Rewired.UnknownControllerHat/HatButtons,System.Int32,TBSPGJPKaXrjsOpBQZPxJnrcfSfAA`1<?>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool ControllerHelper_UilHbxGPUgUwwschnVvYYamXHzUl_TisRuntimeObject_mC8A0E347891CC46F2C0A5907E69542D30C1CC5CD_gshared (ControllerHelper_tCE72EA23053BD0C6ECB4D75A69F8CD1B3AC28FF6* __this, HatButtons_tCE5F7476A54D0F5DF7FA0EB11FF2C753B51DDE03* p0, int32_t p1, TBSPGJPKaXrjsOpBQZPxJnrcfSfAA_1_t92F77A2C0897D802673079FA32163CACC9FD23DE* p2, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ICollection_1_t1F9263A55160633882F2ABCE6527778C728159D5_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IList_1_tAC0A6E16265D2CF73C39873BAD39894E83B5119C_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
int32_t V_0 = 0;
	int32_t V_1 = 0;
	RuntimeObject* V_2 = NULL;
	int32_t V_3 = 0;
	int32_t V_4 = 0;
	int32_t V_5 = 0;
	{
		TBSPGJPKaXrjsOpBQZPxJnrcfSfAA_1_t92F77A2C0897D802673079FA32163CACC9FD23DE* L_0 = p2;
		if (L_0)
		{
			goto IL_0005;
		}
	}
	{
		return (bool)0;
	}

IL_0005:
	{
		TBSPGJPKaXrjsOpBQZPxJnrcfSfAA_1_t92F77A2C0897D802673079FA32163CACC9FD23DE* L_1 = p2;
		NullCheck(L_1);
		int32_t L_2;
		L_2 = ((  int32_t (*) (TBSPGJPKaXrjsOpBQZPxJnrcfSfAA_1_t92F77A2C0897D802673079FA32163CACC9FD23DE*, const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->rgctx_data, 1)))(L_1, il2cpp_rgctx_method(method->rgctx_data, 1));
		V_0 = L_2;
		V_1 = 0;
		goto IL_006b;
	}

IL_0010:
	{
		TBSPGJPKaXrjsOpBQZPxJnrcfSfAA_1_t92F77A2C0897D802673079FA32163CACC9FD23DE* L_3 = p2;
		int32_t L_4 = V_1;
		NullCheck(L_3);
		RuntimeObject* L_5;
		L_5 = ((  RuntimeObject* (*) (TBSPGJPKaXrjsOpBQZPxJnrcfSfAA_1_t92F77A2C0897D802673079FA32163CACC9FD23DE*, int32_t, const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->rgctx_data, 2)))(L_3, L_4, il2cpp_rgctx_method(method->rgctx_data, 2));
		NullCheck((ControllerMap_tC01A582E577E38D21EB7D87A8C040AF5DA285FB3*)L_5);
		RuntimeObject* L_6;
		L_6 = ControllerMap_get_ButtonMaps_m14CE9E0C32878178C5D785B64110FA0E8E7A3549((ControllerMap_tC01A582E577E38D21EB7D87A8C040AF5DA285FB3*)L_5, NULL);
		V_2 = L_6;
		RuntimeObject* L_7 = V_2;
		if (!L_7)
		{
			goto IL_0067;
		}
	}
	{
		RuntimeObject* L_8 = V_2;
		NullCheck((RuntimeObject*)L_8);
		int32_t L_9;
		L_9 = InterfaceFuncInvoker0< int32_t >::Invoke(0 /* System.Int32 System.Collections.Generic.ICollection`1<Rewired.ActionElementMap>::get_Count() */, ICollection_1_t1F9263A55160633882F2ABCE6527778C728159D5_il2cpp_TypeInfo_var, (RuntimeObject*)L_8);
		V_3 = L_9;
		V_4 = 0;
		goto IL_0062;
	}

IL_0031:
	{
		RuntimeObject* L_10 = V_2;
		int32_t L_11 = V_4;
		NullCheck(L_10);
		ActionElementMap_t0EBE3E5D3A5DF3BA6D35F8082ED2232404EFF8CF* L_12;
		L_12 = InterfaceFuncInvoker1< ActionElementMap_t0EBE3E5D3A5DF3BA6D35F8082ED2232404EFF8CF*, int32_t >::Invoke(0 /* T System.Collections.Generic.IList`1<Rewired.ActionElementMap>::get_Item(System.Int32) */, IList_1_tAC0A6E16265D2CF73C39873BAD39894E83B5119C_il2cpp_TypeInfo_var, L_10, L_11);
		NullCheck(L_12);
		int32_t L_13 = (int32_t)L_12->___zmFhEQUDPjAWQEDVHHgiGnzAJkVq_15;
		V_5 = L_13;
		RuntimeObject* L_14 = V_2;
		int32_t L_15 = V_4;
		NullCheck(L_14);
		ActionElementMap_t0EBE3E5D3A5DF3BA6D35F8082ED2232404EFF8CF* L_16;
		L_16 = InterfaceFuncInvoker1< ActionElementMap_t0EBE3E5D3A5DF3BA6D35F8082ED2232404EFF8CF*, int32_t >::Invoke(0 /* T System.Collections.Generic.IList`1<Rewired.ActionElementMap>::get_Item(System.Int32) */, IList_1_tAC0A6E16265D2CF73C39873BAD39894E83B5119C_il2cpp_TypeInfo_var, L_14, L_15);
		NullCheck(L_16);
		int32_t L_17 = (int32_t)L_16->____actionId_1;
		if ((((int32_t)L_17) < ((int32_t)0)))
		{
			goto IL_005c;
		}
	}
	{
		HatButtons_tCE5F7476A54D0F5DF7FA0EB11FF2C753B51DDE03* L_18 = p0;
		int32_t L_19 = V_5;
		NullCheck(L_18);
		bool L_20;
		L_20 = HatButtons_IsCorner_m3496C9D81EAACED6B4E98A984A04BF85363CC16D(L_18, L_19, NULL);
		if (!L_20)
		{
			goto IL_005c;
		}
	}
	{
		return (bool)1;
	}

IL_005c:
	{
		int32_t L_21 = V_4;
		V_4 = ((int32_t)il2cpp_codegen_add(L_21, 1));
	}

IL_0062:
	{
		int32_t L_22 = V_4;
		int32_t L_23 = V_3;
		if ((((int32_t)L_22) < ((int32_t)L_23)))
		{
			goto IL_0031;
		}
	}

IL_0067:
	{
		int32_t L_24 = V_1;
		V_1 = ((int32_t)il2cpp_codegen_add(L_24, 1));
	}

IL_006b:
	{
		int32_t L_25 = V_1;
		int32_t L_26 = V_0;
		if ((((int32_t)L_25) < ((int32_t)L_26)))
		{
			goto IL_0010;
		}
	}
	{
		return (bool)0;
	}
}
// System.Void Rewired.Player/ControllerHelper::jlNyVVjomhNSoUyIaBMcRhwUcvNF<System.Object,System.Object>(Rewired.ControllerType,System.Action`3<System.Boolean,System.Int32,System.Int32>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ControllerHelper_jlNyVVjomhNSoUyIaBMcRhwUcvNF_TisRuntimeObject_TisRuntimeObject_m3F5D4F4CF483C86EDFBFDE7AC5A9FD7ABB866EF0_gshared (ControllerHelper_tCE72EA23053BD0C6ECB4D75A69F8CD1B3AC28FF6* __this, int32_t p0, Action_3_t142D1F73AF66CEBC85F52240EC1B6207B558A40B* p1, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Action_3_Invoke_m8897575606FCC23249B541980E86A2D83737853B_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IList_1_t66EFE3B432957D9B69D07AF4C7286702603F8790_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IList_1_t78665A3C2B273BACE5E7589E9146A1E821FDCB13_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&slnZXWsjHVMgmJPfXBYLuaghszns_t24FEA9E317E149AF896730414F2B3089559DCEC1_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
bvHtPvdVkbINqyMOEkvOVjYbgQSB_2_t60A1A6FC724CFAE71F8A6AFF7A7F6AC9F128037F* V_0 = NULL;
	FeaiSQbvxYDTMImoDmlvhGnyLumi_tB82E59EB263DBCCD7452BF39256B26197DD5299C* V_1 = NULL;
	int32_t V_2 = 0;
	int32_t V_3 = 0;
	omlOoYqlQcXnMjOFbISaKckKLkeYA_t31AF08D5218EBDFD5BF5572E096D762097D11AF0* V_4 = NULL;
	RuntimeObject* V_5 = NULL;
	TBSPGJPKaXrjsOpBQZPxJnrcfSfAA_1_t92F77A2C0897D802673079FA32163CACC9FD23DE* V_6 = NULL;
	bool V_7 = false;
	int32_t V_8 = 0;
	int32_t V_9 = 0;
	RuntimeObject* V_10 = NULL;
	AList_1_t26BA8BE4BEB503507B02BE892DA37BBBAA585997* V_11 = NULL;
	AList_1_t26BA8BE4BEB503507B02BE892DA37BBBAA585997* V_12 = NULL;
	int32_t V_13 = 0;
	int32_t V_14 = 0;
	ActionElementMap_t0EBE3E5D3A5DF3BA6D35F8082ED2232404EFF8CF* V_15 = NULL;
	int32_t V_16 = 0;
	float V_17 = 0.0f;
	HardwareAxisInfo_t263803B756A1948668029834C5B184A5590B0654* V_18 = NULL;
	float V_19 = 0.0f;
	int32_t V_20 = 0;
	int32_t V_21 = 0;
	ActionElementMap_t0EBE3E5D3A5DF3BA6D35F8082ED2232404EFF8CF* V_22 = NULL;
	int32_t V_23 = 0;
	float V_24 = 0.0f;
	int32_t V_25 = 0;
	int32_t V_26 = 0;
	FeaiSQbvxYDTMImoDmlvhGnyLumi_tB82E59EB263DBCCD7452BF39256B26197DD5299C* G_B14_0 = NULL;
	FeaiSQbvxYDTMImoDmlvhGnyLumi_tB82E59EB263DBCCD7452BF39256B26197DD5299C* G_B13_0 = NULL;
	int32_t G_B15_0 = 0;
	FeaiSQbvxYDTMImoDmlvhGnyLumi_tB82E59EB263DBCCD7452BF39256B26197DD5299C* G_B15_1 = NULL;
	{
		vpfVMfLDNQCKabtrXuyMMndafvvoA_t24DAE63535EED93A1490AC97901F2551704D116D* L_0 = (vpfVMfLDNQCKabtrXuyMMndafvvoA_t24DAE63535EED93A1490AC97901F2551704D116D*)__this->___rGIwSbUPDgDDJByCitUBBGoZDlmc_0;
		int32_t L_1 = p0;
		NullCheck(L_0);
		RuntimeObject* L_2;
		L_2 = vpfVMfLDNQCKabtrXuyMMndafvvoA_OlLACmpwoMamrxMTFzLaRnppBEGFA_m7D256F4AAE84410B2D3EC0217ADB4B49A6AE0B9F(L_0, L_1, NULL);
		V_0 = ((bvHtPvdVkbINqyMOEkvOVjYbgQSB_2_t60A1A6FC724CFAE71F8A6AFF7A7F6AC9F128037F*)CastclassSealed((RuntimeObject*)L_2, il2cpp_rgctx_data(method->rgctx_data, 0)));
		il2cpp_codegen_runtime_class_init_inline(slnZXWsjHVMgmJPfXBYLuaghszns_t24FEA9E317E149AF896730414F2B3089559DCEC1_il2cpp_TypeInfo_var);
		FeaiSQbvxYDTMImoDmlvhGnyLumi_tB82E59EB263DBCCD7452BF39256B26197DD5299C* L_3 = ((slnZXWsjHVMgmJPfXBYLuaghszns_t24FEA9E317E149AF896730414F2B3089559DCEC1_StaticFields*)il2cpp_codegen_static_fields_for(slnZXWsjHVMgmJPfXBYLuaghszns_t24FEA9E317E149AF896730414F2B3089559DCEC1_il2cpp_TypeInfo_var))->___bbIgXLaOfnvjdbkLSdSnMkwscgPFA_35;
		V_1 = L_3;
		bvHtPvdVkbINqyMOEkvOVjYbgQSB_2_t60A1A6FC724CFAE71F8A6AFF7A7F6AC9F128037F* L_4 = V_0;
		NullCheck(L_4);
		int32_t L_5;
		L_5 = ((  int32_t (*) (bvHtPvdVkbINqyMOEkvOVjYbgQSB_2_t60A1A6FC724CFAE71F8A6AFF7A7F6AC9F128037F*, const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->rgctx_data, 1)))(L_4, il2cpp_rgctx_method(method->rgctx_data, 1));
		V_2 = L_5;
		V_3 = 0;
		goto IL_0344;
	}

IL_0026:
	{
		bvHtPvdVkbINqyMOEkvOVjYbgQSB_2_t60A1A6FC724CFAE71F8A6AFF7A7F6AC9F128037F* L_6 = V_0;
		int32_t L_7 = V_3;
		NullCheck(L_6);
		omlOoYqlQcXnMjOFbISaKckKLkeYA_t31AF08D5218EBDFD5BF5572E096D762097D11AF0* L_8;
		L_8 = ((  omlOoYqlQcXnMjOFbISaKckKLkeYA_t31AF08D5218EBDFD5BF5572E096D762097D11AF0* (*) (bvHtPvdVkbINqyMOEkvOVjYbgQSB_2_t60A1A6FC724CFAE71F8A6AFF7A7F6AC9F128037F*, int32_t, const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->rgctx_data, 2)))(L_6, L_7, il2cpp_rgctx_method(method->rgctx_data, 2));
		V_4 = L_8;
		omlOoYqlQcXnMjOFbISaKckKLkeYA_t31AF08D5218EBDFD5BF5572E096D762097D11AF0* L_9 = V_4;
		NullCheck(L_9);
		RuntimeObject* L_10 = (RuntimeObject*)L_9->___qqrQldxbErvVtpNyQAtEGvvTTIMe_0;
		V_5 = L_10;
		RuntimeObject* L_11 = V_5;
		NullCheck((Controller_t919A4A50FC7A0F25D7B31615C0F4E4D4A4D17911*)L_11);
		bool L_12;
		L_12 = Controller_get_enabled_m10693155C7424F34211AF208074D23F84CC26B75((Controller_t919A4A50FC7A0F25D7B31615C0F4E4D4A4D17911*)L_11, NULL);
		if (!L_12)
		{
			goto IL_0340;
		}
	}
	{
		omlOoYqlQcXnMjOFbISaKckKLkeYA_t31AF08D5218EBDFD5BF5572E096D762097D11AF0* L_13 = V_4;
		NullCheck(L_13);
		TBSPGJPKaXrjsOpBQZPxJnrcfSfAA_1_t92F77A2C0897D802673079FA32163CACC9FD23DE* L_14 = (TBSPGJPKaXrjsOpBQZPxJnrcfSfAA_1_t92F77A2C0897D802673079FA32163CACC9FD23DE*)L_13->___kfHAOgauRJPvjKmCDapJwwhskNfUA_1;
		V_6 = L_14;
		V_7 = (bool)0;
		TBSPGJPKaXrjsOpBQZPxJnrcfSfAA_1_t92F77A2C0897D802673079FA32163CACC9FD23DE* L_15 = V_6;
		NullCheck(L_15);
		int32_t L_16;
		L_16 = ((  int32_t (*) (TBSPGJPKaXrjsOpBQZPxJnrcfSfAA_1_t92F77A2C0897D802673079FA32163CACC9FD23DE*, const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->rgctx_data, 5)))(L_15, il2cpp_rgctx_method(method->rgctx_data, 5));
		V_8 = L_16;
		V_9 = 0;
		goto IL_0337;
	}

IL_0066:
	{
		TBSPGJPKaXrjsOpBQZPxJnrcfSfAA_1_t92F77A2C0897D802673079FA32163CACC9FD23DE* L_17 = V_6;
		int32_t L_18 = V_9;
		NullCheck(L_17);
		RuntimeObject* L_19;
		L_19 = ((  RuntimeObject* (*) (TBSPGJPKaXrjsOpBQZPxJnrcfSfAA_1_t92F77A2C0897D802673079FA32163CACC9FD23DE*, int32_t, const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->rgctx_data, 6)))(L_17, L_18, il2cpp_rgctx_method(method->rgctx_data, 6));
		V_10 = L_19;
		RuntimeObject* L_20 = V_10;
		NullCheck((ControllerMap_tC01A582E577E38D21EB7D87A8C040AF5DA285FB3*)L_20);
		bool L_21;
		L_21 = ControllerMap_get_enabled_mA47FDF987F7A3D02B760A0F6923993074A810915((ControllerMap_tC01A582E577E38D21EB7D87A8C040AF5DA285FB3*)L_20, NULL);
		if (!L_21)
		{
			goto IL_0331;
		}
	}
	{
		RuntimeObject* L_22 = V_10;
		NullCheck((ControllerMapWithAxes_tCC6B6F4AA454F60DB2D7F6660FDE33B9F683A036*)L_22);
		AList_1_t26BA8BE4BEB503507B02BE892DA37BBBAA585997* L_23;
		L_23 = ControllerMapWithAxes_iNoVnkKULkVWRMCBPrVYaoavRfNM_m991DEFB43A6DDAF9D1951950DC058DCCCDB08CF0((ControllerMapWithAxes_tCC6B6F4AA454F60DB2D7F6660FDE33B9F683A036*)L_22, NULL);
		V_11 = L_23;
		AList_1_t26BA8BE4BEB503507B02BE892DA37BBBAA585997* L_24 = V_11;
		if (!L_24)
		{
			goto IL_01e7;
		}
	}
	{
		AList_1_t26BA8BE4BEB503507B02BE892DA37BBBAA585997* L_25 = V_11;
		NullCheck(L_25);
		int32_t L_26 = (int32_t)L_25->____count_5;
		V_13 = L_26;
		V_14 = 0;
		goto IL_01de;
	}

IL_00a8:
	{
		AList_1_t26BA8BE4BEB503507B02BE892DA37BBBAA585997* L_27 = V_11;
		NullCheck(L_27);
		ActionElementMapU5BU5D_t695D4AC334ED6665D93DB89FAFA472C4F2CAADAE* L_28 = (ActionElementMapU5BU5D_t695D4AC334ED6665D93DB89FAFA472C4F2CAADAE*)L_27->____items_3;
		int32_t L_29 = V_14;
		NullCheck(L_28);
		int32_t L_30 = L_29;
		ActionElementMap_t0EBE3E5D3A5DF3BA6D35F8082ED2232404EFF8CF* L_31 = (L_28)->GetAt(static_cast<il2cpp_array_size_t>(L_30));
		V_15 = L_31;
		ActionElementMap_t0EBE3E5D3A5DF3BA6D35F8082ED2232404EFF8CF* L_32 = V_15;
		NullCheck(L_32);
		bool L_33 = (bool)L_32->___ITUIszRiaNrsImOTfgAHSPwPTOLe_12;
		if (!L_33)
		{
			goto IL_01d8;
		}
	}
	{
		ActionElementMap_t0EBE3E5D3A5DF3BA6D35F8082ED2232404EFF8CF* L_34 = V_15;
		NullCheck(L_34);
		int32_t L_35 = (int32_t)L_34->____elementType_2;
		if (L_35)
		{
			goto IL_01d8;
		}
	}
	{
		ActionElementMap_t0EBE3E5D3A5DF3BA6D35F8082ED2232404EFF8CF* L_36 = V_15;
		NullCheck(L_36);
		int32_t L_37 = (int32_t)L_36->____actionId_1;
		V_16 = L_37;
		RuntimeObject* L_38 = V_5;
		ActionElementMap_t0EBE3E5D3A5DF3BA6D35F8082ED2232404EFF8CF* L_39 = V_15;
		int32_t L_40 = V_16;
		NullCheck((ControllerWithAxes_tF5DF4B1A98C0326D31E6AC481DEBC2D90E44BBF2*)L_38);
		bool L_41;
		L_41 = ControllerWithAxes_EOOnKXthHffjzkcNHrZpffyFmiKcA_m10692BFABBC0DB91E8433A9853953F6C8D977892((ControllerWithAxes_tF5DF4B1A98C0326D31E6AC481DEBC2D90E44BBF2*)L_38, L_39, L_40, (bool)0, (bool)0, (&V_17), NULL);
		if (!L_41)
		{
			goto IL_01d8;
		}
	}
	{
		float L_42 = V_17;
		if ((!(((float)L_42) == ((float)(0.0f)))))
		{
			goto IL_012e;
		}
	}
	{
		RuntimeObject* L_43 = V_5;
		ActionElementMap_t0EBE3E5D3A5DF3BA6D35F8082ED2232404EFF8CF* L_44 = V_15;
		int32_t L_45 = V_16;
		NullCheck((ControllerWithAxes_tF5DF4B1A98C0326D31E6AC481DEBC2D90E44BBF2*)L_43);
		bool L_46;
		L_46 = ControllerWithAxes_EOOnKXthHffjzkcNHrZpffyFmiKcA_m10692BFABBC0DB91E8433A9853953F6C8D977892((ControllerWithAxes_tF5DF4B1A98C0326D31E6AC481DEBC2D90E44BBF2*)L_43, L_44, L_45, (bool)0, (bool)1, (&V_19), NULL);
		float L_47 = V_19;
		if ((!(((float)L_47) == ((float)(0.0f)))))
		{
			goto IL_012e;
		}
	}
	{
		Action_3_t142D1F73AF66CEBC85F52240EC1B6207B558A40B* L_48 = p1;
		Player_t71A64CE695A2F96B144F3050755AB2799DA7C01B* L_49 = (Player_t71A64CE695A2F96B144F3050755AB2799DA7C01B*)__this->___vLioXoePkQiNEWuOkALOfFKNbaiU_9;
		NullCheck(L_49);
		int32_t L_50 = (int32_t)L_49->___uiBcvtaHTXDhDgTmVOTVLzAJdhvt_2;
		int32_t L_51 = V_16;
		NullCheck(L_48);
		Action_3_Invoke_m8897575606FCC23249B541980E86A2D83737853B(L_48, (bool)0, L_50, L_51, Action_3_Invoke_m8897575606FCC23249B541980E86A2D83737853B_RuntimeMethod_var);
		goto IL_01d8;
	}

IL_012e:
	{
		FeaiSQbvxYDTMImoDmlvhGnyLumi_tB82E59EB263DBCCD7452BF39256B26197DD5299C* L_52 = V_1;
		float L_53 = V_17;
		NullCheck(L_52);
		L_52->___SHVspNkbPzieDmSaNsxoePExLrRC_0 = L_53;
		FeaiSQbvxYDTMImoDmlvhGnyLumi_tB82E59EB263DBCCD7452BF39256B26197DD5299C* L_54 = V_1;
		RuntimeObject* L_55 = V_5;
		NullCheck(L_54);
		L_54->___qqrQldxbErvVtpNyQAtEGvvTTIMe_4 = (Controller_t919A4A50FC7A0F25D7B31615C0F4E4D4A4D17911*)L_55;
		Il2CppCodeGenWriteBarrier((void**)(&L_54->___qqrQldxbErvVtpNyQAtEGvvTTIMe_4), (void*)(Controller_t919A4A50FC7A0F25D7B31615C0F4E4D4A4D17911*)L_55);
		FeaiSQbvxYDTMImoDmlvhGnyLumi_tB82E59EB263DBCCD7452BF39256B26197DD5299C* L_56 = V_1;
		int32_t L_57 = p0;
		NullCheck(L_56);
		L_56->___FlMTEQmWOHVNzmnTpwqezeosKTre_3 = L_57;
		FeaiSQbvxYDTMImoDmlvhGnyLumi_tB82E59EB263DBCCD7452BF39256B26197DD5299C* L_58 = V_1;
		NullCheck(L_58);
		L_58->___uLwgdeVFkwbalOghhEhuZfZRPruR_2 = (int32_t)0;
		FeaiSQbvxYDTMImoDmlvhGnyLumi_tB82E59EB263DBCCD7452BF39256B26197DD5299C* L_59 = V_1;
		ActionElementMap_t0EBE3E5D3A5DF3BA6D35F8082ED2232404EFF8CF* L_60 = V_15;
		NullCheck(L_59);
		L_59->___qghidDgYDpANqWKwkwCriPSDATeV_6 = L_60;
		Il2CppCodeGenWriteBarrier((void**)(&L_59->___qghidDgYDpANqWKwkwCriPSDATeV_6), (void*)L_60);
		FeaiSQbvxYDTMImoDmlvhGnyLumi_tB82E59EB263DBCCD7452BF39256B26197DD5299C* L_61 = V_1;
		RuntimeObject* L_62 = V_10;
		NullCheck(L_61);
		L_61->___GrAwOHyDGcOocdkygeijDogwNaVr_5 = (ControllerMap_tC01A582E577E38D21EB7D87A8C040AF5DA285FB3*)L_62;
		Il2CppCodeGenWriteBarrier((void**)(&L_61->___GrAwOHyDGcOocdkygeijDogwNaVr_5), (void*)(ControllerMap_tC01A582E577E38D21EB7D87A8C040AF5DA285FB3*)L_62);
		FeaiSQbvxYDTMImoDmlvhGnyLumi_tB82E59EB263DBCCD7452BF39256B26197DD5299C* L_63 = V_1;
		RuntimeObject* L_64 = V_5;
		NullCheck((ControllerWithAxes_tF5DF4B1A98C0326D31E6AC481DEBC2D90E44BBF2*)L_64);
		CalibrationMap_tB57C4727A9D4F4ED745A6E5D7E4398452D7A499B* L_65;
		L_65 = ControllerWithAxes_get_calibrationMap_mC3190BF4AA50F8BAFE4C7E6B9A93227D3A0DC646((ControllerWithAxes_tF5DF4B1A98C0326D31E6AC481DEBC2D90E44BBF2*)L_64, NULL);
		NullCheck(L_65);
		RuntimeObject* L_66;
		L_66 = CalibrationMap_get_Axes_m54E04E0A9797B0B8C965699A2B749DAF7B7158D7_inline(L_65, NULL);
		ActionElementMap_t0EBE3E5D3A5DF3BA6D35F8082ED2232404EFF8CF* L_67 = V_15;
		NullCheck(L_67);
		int32_t L_68 = (int32_t)L_67->___zmFhEQUDPjAWQEDVHHgiGnzAJkVq_15;
		NullCheck(L_66);
		AxisCalibration_t8B238ADDBAA0316E9708699644DA1CFF6EDBE66C* L_69;
		L_69 = InterfaceFuncInvoker1< AxisCalibration_t8B238ADDBAA0316E9708699644DA1CFF6EDBE66C*, int32_t >::Invoke(0 /* T System.Collections.Generic.IList`1<Rewired.AxisCalibration>::get_Item(System.Int32) */, IList_1_t66EFE3B432957D9B69D07AF4C7286702603F8790_il2cpp_TypeInfo_var, L_66, L_68);
		NullCheck(L_69);
		bool L_70;
		L_70 = AxisCalibration_get_applyRangeCalibration_m438A9FE9F6BAE9D2E046F3B44DBBAD83F0BBAD05_inline(L_69, NULL);
		NullCheck(L_63);
		L_63->___WdhPBPdalRyBsdzTuacSOPnDtysh_9 = L_70;
		RuntimeObject* L_71 = V_5;
		NullCheck((ControllerWithAxes_tF5DF4B1A98C0326D31E6AC481DEBC2D90E44BBF2*)L_71);
		RuntimeObject* L_72;
		L_72 = ControllerWithAxes_get_Axes_m7FA5003F0800898EA9833E7706A936B4E71A7DEB((ControllerWithAxes_tF5DF4B1A98C0326D31E6AC481DEBC2D90E44BBF2*)L_71, NULL);
		ActionElementMap_t0EBE3E5D3A5DF3BA6D35F8082ED2232404EFF8CF* L_73 = V_15;
		NullCheck(L_73);
		int32_t L_74;
		L_74 = ActionElementMap_get_elementIndex_m3FA57481AF8EAE6B39F59CCDD2051406ECA35726_inline(L_73, NULL);
		NullCheck(L_72);
		Axis_t40E49C8915EBF41DCB550E7E5BE41D5873870A21* L_75;
		L_75 = InterfaceFuncInvoker1< Axis_t40E49C8915EBF41DCB550E7E5BE41D5873870A21*, int32_t >::Invoke(0 /* T System.Collections.Generic.IList`1<Rewired.Controller/Axis>::get_Item(System.Int32) */, IList_1_t78665A3C2B273BACE5E7589E9146A1E821FDCB13_il2cpp_TypeInfo_var, L_72, L_74);
		NullCheck(L_75);
		HardwareAxisInfo_t263803B756A1948668029834C5B184A5590B0654* L_76 = (HardwareAxisInfo_t263803B756A1948668029834C5B184A5590B0654*)L_75->___sYQHkuLOotjVsFrWJzlEaGRmGJQcb_9;
		V_18 = L_76;
		FeaiSQbvxYDTMImoDmlvhGnyLumi_tB82E59EB263DBCCD7452BF39256B26197DD5299C* L_77 = V_1;
		HardwareAxisInfo_t263803B756A1948668029834C5B184A5590B0654* L_78 = V_18;
		G_B13_0 = L_77;
		if (L_78)
		{
			G_B14_0 = L_77;
			goto IL_01b5;
		}
	}
	{
		G_B15_0 = 0;
		G_B15_1 = G_B13_0;
		goto IL_01bc;
	}

IL_01b5:
	{
		HardwareAxisInfo_t263803B756A1948668029834C5B184A5590B0654* L_79 = V_18;
		NullCheck(L_79);
		int32_t L_80 = (int32_t)L_79->____dataFormat_0;
		G_B15_0 = ((int32_t)(L_80));
		G_B15_1 = G_B14_0;
	}

IL_01bc:
	{
		NullCheck(G_B15_1);
		G_B15_1->___cYrMjjgdqZyGFkCpgBgkIoPtJzDfb_10 = (int32_t)G_B15_0;
		Action_3_t142D1F73AF66CEBC85F52240EC1B6207B558A40B* L_81 = p1;
		Player_t71A64CE695A2F96B144F3050755AB2799DA7C01B* L_82 = (Player_t71A64CE695A2F96B144F3050755AB2799DA7C01B*)__this->___vLioXoePkQiNEWuOkALOfFKNbaiU_9;
		NullCheck(L_82);
		int32_t L_83 = (int32_t)L_82->___uiBcvtaHTXDhDgTmVOTVLzAJdhvt_2;
		int32_t L_84 = V_16;
		NullCheck(L_81);
		Action_3_Invoke_m8897575606FCC23249B541980E86A2D83737853B(L_81, (bool)1, L_83, L_84, Action_3_Invoke_m8897575606FCC23249B541980E86A2D83737853B_RuntimeMethod_var);
		V_7 = (bool)1;
	}

IL_01d8:
	{
		int32_t L_85 = V_14;
		V_14 = ((int32_t)il2cpp_codegen_add(L_85, 1));
	}

IL_01de:
	{
		int32_t L_86 = V_14;
		int32_t L_87 = V_13;
		if ((((int32_t)L_86) < ((int32_t)L_87)))
		{
			goto IL_00a8;
		}
	}

IL_01e7:
	{
		RuntimeObject* L_88 = V_10;
		NullCheck((ControllerMap_tC01A582E577E38D21EB7D87A8C040AF5DA285FB3*)L_88);
		AList_1_t26BA8BE4BEB503507B02BE892DA37BBBAA585997* L_89;
		L_89 = ControllerMap_wXccLrJfOtzUxejkEKAtaWhpDtMyA_m59AF76DBA5CF3521EF33E62ABEC7652CA79D4109_inline((ControllerMap_tC01A582E577E38D21EB7D87A8C040AF5DA285FB3*)L_88, NULL);
		V_12 = L_89;
		AList_1_t26BA8BE4BEB503507B02BE892DA37BBBAA585997* L_90 = V_12;
		if (!L_90)
		{
			goto IL_0326;
		}
	}
	{
		AList_1_t26BA8BE4BEB503507B02BE892DA37BBBAA585997* L_91 = V_12;
		NullCheck(L_91);
		int32_t L_92 = (int32_t)L_91->____count_5;
		V_20 = L_92;
		V_21 = 0;
		goto IL_031d;
	}

IL_020d:
	{
		AList_1_t26BA8BE4BEB503507B02BE892DA37BBBAA585997* L_93 = V_12;
		NullCheck(L_93);
		ActionElementMapU5BU5D_t695D4AC334ED6665D93DB89FAFA472C4F2CAADAE* L_94 = (ActionElementMapU5BU5D_t695D4AC334ED6665D93DB89FAFA472C4F2CAADAE*)L_93->____items_3;
		int32_t L_95 = V_21;
		NullCheck(L_94);
		int32_t L_96 = L_95;
		ActionElementMap_t0EBE3E5D3A5DF3BA6D35F8082ED2232404EFF8CF* L_97 = (L_94)->GetAt(static_cast<il2cpp_array_size_t>(L_96));
		V_22 = L_97;
		ActionElementMap_t0EBE3E5D3A5DF3BA6D35F8082ED2232404EFF8CF* L_98 = V_22;
		NullCheck(L_98);
		bool L_99 = (bool)L_98->___ITUIszRiaNrsImOTfgAHSPwPTOLe_12;
		if (!L_99)
		{
			goto IL_0317;
		}
	}
	{
		ActionElementMap_t0EBE3E5D3A5DF3BA6D35F8082ED2232404EFF8CF* L_100 = V_22;
		NullCheck(L_100);
		int32_t L_101 = (int32_t)L_100->____elementType_2;
		if ((!(((uint32_t)L_101) == ((uint32_t)1))))
		{
			goto IL_0317;
		}
	}
	{
		ActionElementMap_t0EBE3E5D3A5DF3BA6D35F8082ED2232404EFF8CF* L_102 = V_22;
		NullCheck(L_102);
		int32_t L_103 = (int32_t)L_102->____actionId_1;
		V_23 = L_103;
		V_24 = (0.0f);
		ActionElementMap_t0EBE3E5D3A5DF3BA6D35F8082ED2232404EFF8CF* L_104 = V_22;
		NullCheck(L_104);
		int32_t L_105 = (int32_t)L_104->___zmFhEQUDPjAWQEDVHHgiGnzAJkVq_15;
		V_25 = L_105;
		RuntimeObject* L_106 = V_5;
		int32_t L_107 = V_3;
		int32_t L_108 = V_25;
		ActionElementMap_t0EBE3E5D3A5DF3BA6D35F8082ED2232404EFF8CF* L_109 = V_22;
		TBSPGJPKaXrjsOpBQZPxJnrcfSfAA_1_t92F77A2C0897D802673079FA32163CACC9FD23DE* L_110 = V_6;
		int32_t L_111 = V_23;
		bool L_112;
		L_112 = ((  bool (*) (ControllerHelper_tCE72EA23053BD0C6ECB4D75A69F8CD1B3AC28FF6*, ControllerWithAxes_tF5DF4B1A98C0326D31E6AC481DEBC2D90E44BBF2*, int32_t, int32_t, ActionElementMap_t0EBE3E5D3A5DF3BA6D35F8082ED2232404EFF8CF*, TBSPGJPKaXrjsOpBQZPxJnrcfSfAA_1_t92F77A2C0897D802673079FA32163CACC9FD23DE*, int32_t, float*, const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->rgctx_data, 8)))(__this, (ControllerWithAxes_tF5DF4B1A98C0326D31E6AC481DEBC2D90E44BBF2*)L_106, L_107, L_108, L_109, L_110, L_111, (&V_24), il2cpp_rgctx_method(method->rgctx_data, 8));
		if (L_112)
		{
			goto IL_0282;
		}
	}
	{
		RuntimeObject* L_113 = V_5;
		ActionElementMap_t0EBE3E5D3A5DF3BA6D35F8082ED2232404EFF8CF* L_114 = V_22;
		int32_t L_115 = V_23;
		FeaiSQbvxYDTMImoDmlvhGnyLumi_tB82E59EB263DBCCD7452BF39256B26197DD5299C* L_116 = V_1;
		NullCheck(L_116);
		bool* L_117 = (bool*)(&L_116->___zKxBPwIJEgjAeutYdHkdyITSCKGQA_8);
		NullCheck((Controller_t919A4A50FC7A0F25D7B31615C0F4E4D4A4D17911*)L_113);
		bool L_118;
		L_118 = Controller_cpEczqMFPCBfKdwpHaSAfaDMNEJPA_mB2048BE4C3B1A9C4DAB6BE076089A9E00A0EA15D((Controller_t919A4A50FC7A0F25D7B31615C0F4E4D4A4D17911*)L_113, L_114, L_115, (&V_24), L_117, NULL);
		if (!L_118)
		{
			goto IL_0317;
		}
	}

IL_0282:
	{
		RuntimeObject* L_119 = V_5;
		ActionElementMap_t0EBE3E5D3A5DF3BA6D35F8082ED2232404EFF8CF* L_120 = V_22;
		NullCheck(L_120);
		int32_t L_121 = (int32_t)L_120->___zmFhEQUDPjAWQEDVHHgiGnzAJkVq_15;
		NullCheck((Controller_t919A4A50FC7A0F25D7B31615C0F4E4D4A4D17911*)L_119);
		int32_t L_122;
		L_122 = VirtualFuncInvoker1< int32_t, int32_t >::Invoke(51 /* Rewired.ButtonStateFlags Rewired.Controller::xdrFEzzguzmckUPJsOGCFcEZPATf(System.Int32) */, (Controller_t919A4A50FC7A0F25D7B31615C0F4E4D4A4D17911*)L_119, L_121);
		V_26 = L_122;
		int32_t L_123 = V_26;
		if (L_123)
		{
			goto IL_02b1;
		}
	}
	{
		Action_3_t142D1F73AF66CEBC85F52240EC1B6207B558A40B* L_124 = p1;
		Player_t71A64CE695A2F96B144F3050755AB2799DA7C01B* L_125 = (Player_t71A64CE695A2F96B144F3050755AB2799DA7C01B*)__this->___vLioXoePkQiNEWuOkALOfFKNbaiU_9;
		NullCheck(L_125);
		int32_t L_126 = (int32_t)L_125->___uiBcvtaHTXDhDgTmVOTVLzAJdhvt_2;
		int32_t L_127 = V_23;
		NullCheck(L_124);
		Action_3_Invoke_m8897575606FCC23249B541980E86A2D83737853B(L_124, (bool)0, L_126, L_127, Action_3_Invoke_m8897575606FCC23249B541980E86A2D83737853B_RuntimeMethod_var);
		goto IL_0317;
	}

IL_02b1:
	{
		FeaiSQbvxYDTMImoDmlvhGnyLumi_tB82E59EB263DBCCD7452BF39256B26197DD5299C* L_128 = V_1;
		float L_129 = V_24;
		NullCheck(L_128);
		L_128->___SHVspNkbPzieDmSaNsxoePExLrRC_0 = L_129;
		FeaiSQbvxYDTMImoDmlvhGnyLumi_tB82E59EB263DBCCD7452BF39256B26197DD5299C* L_130 = V_1;
		int32_t L_131 = V_26;
		NullCheck(L_130);
		L_130->___svWjsaKEZlowJodIYNTRlQxLKvYi_1 = L_131;
		FeaiSQbvxYDTMImoDmlvhGnyLumi_tB82E59EB263DBCCD7452BF39256B26197DD5299C* L_132 = V_1;
		RuntimeObject* L_133 = V_5;
		NullCheck(L_132);
		L_132->___qqrQldxbErvVtpNyQAtEGvvTTIMe_4 = (Controller_t919A4A50FC7A0F25D7B31615C0F4E4D4A4D17911*)L_133;
		Il2CppCodeGenWriteBarrier((void**)(&L_132->___qqrQldxbErvVtpNyQAtEGvvTTIMe_4), (void*)(Controller_t919A4A50FC7A0F25D7B31615C0F4E4D4A4D17911*)L_133);
		FeaiSQbvxYDTMImoDmlvhGnyLumi_tB82E59EB263DBCCD7452BF39256B26197DD5299C* L_134 = V_1;
		int32_t L_135 = p0;
		NullCheck(L_134);
		L_134->___FlMTEQmWOHVNzmnTpwqezeosKTre_3 = L_135;
		FeaiSQbvxYDTMImoDmlvhGnyLumi_tB82E59EB263DBCCD7452BF39256B26197DD5299C* L_136 = V_1;
		NullCheck(L_136);
		L_136->___uLwgdeVFkwbalOghhEhuZfZRPruR_2 = (int32_t)1;
		FeaiSQbvxYDTMImoDmlvhGnyLumi_tB82E59EB263DBCCD7452BF39256B26197DD5299C* L_137 = V_1;
		ActionElementMap_t0EBE3E5D3A5DF3BA6D35F8082ED2232404EFF8CF* L_138 = V_22;
		NullCheck(L_137);
		L_137->___qghidDgYDpANqWKwkwCriPSDATeV_6 = L_138;
		Il2CppCodeGenWriteBarrier((void**)(&L_137->___qghidDgYDpANqWKwkwCriPSDATeV_6), (void*)L_138);
		FeaiSQbvxYDTMImoDmlvhGnyLumi_tB82E59EB263DBCCD7452BF39256B26197DD5299C* L_139 = V_1;
		RuntimeObject* L_140 = V_10;
		NullCheck(L_139);
		L_139->___GrAwOHyDGcOocdkygeijDogwNaVr_5 = (ControllerMap_tC01A582E577E38D21EB7D87A8C040AF5DA285FB3*)L_140;
		Il2CppCodeGenWriteBarrier((void**)(&L_139->___GrAwOHyDGcOocdkygeijDogwNaVr_5), (void*)(ControllerMap_tC01A582E577E38D21EB7D87A8C040AF5DA285FB3*)L_140);
		FeaiSQbvxYDTMImoDmlvhGnyLumi_tB82E59EB263DBCCD7452BF39256B26197DD5299C* L_141 = V_1;
		NullCheck(L_141);
		bool L_142 = (bool)L_141->___WdhPBPdalRyBsdzTuacSOPnDtysh_9;
		if (!L_142)
		{
			goto IL_0300;
		}
	}
	{
		FeaiSQbvxYDTMImoDmlvhGnyLumi_tB82E59EB263DBCCD7452BF39256B26197DD5299C* L_143 = V_1;
		NullCheck(L_143);
		L_143->___WdhPBPdalRyBsdzTuacSOPnDtysh_9 = (bool)0;
	}

IL_0300:
	{
		Action_3_t142D1F73AF66CEBC85F52240EC1B6207B558A40B* L_144 = p1;
		Player_t71A64CE695A2F96B144F3050755AB2799DA7C01B* L_145 = (Player_t71A64CE695A2F96B144F3050755AB2799DA7C01B*)__this->___vLioXoePkQiNEWuOkALOfFKNbaiU_9;
		NullCheck(L_145);
		int32_t L_146 = (int32_t)L_145->___uiBcvtaHTXDhDgTmVOTVLzAJdhvt_2;
		int32_t L_147 = V_23;
		NullCheck(L_144);
		Action_3_Invoke_m8897575606FCC23249B541980E86A2D83737853B(L_144, (bool)1, L_146, L_147, Action_3_Invoke_m8897575606FCC23249B541980E86A2D83737853B_RuntimeMethod_var);
		V_7 = (bool)1;
	}

IL_0317:
	{
		int32_t L_148 = V_21;
		V_21 = ((int32_t)il2cpp_codegen_add(L_148, 1));
	}

IL_031d:
	{
		int32_t L_149 = V_21;
		int32_t L_150 = V_20;
		if ((((int32_t)L_149) < ((int32_t)L_150)))
		{
			goto IL_020d;
		}
	}

IL_0326:
	{
		bool L_151 = V_7;
		if (!L_151)
		{
			goto IL_0331;
		}
	}
	{
		omlOoYqlQcXnMjOFbISaKckKLkeYA_t31AF08D5218EBDFD5BF5572E096D762097D11AF0* L_152 = V_4;
		NullCheck(L_152);
		((  void (*) (omlOoYqlQcXnMjOFbISaKckKLkeYA_t31AF08D5218EBDFD5BF5572E096D762097D11AF0*, const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->rgctx_data, 10)))(L_152, il2cpp_rgctx_method(method->rgctx_data, 10));
	}

IL_0331:
	{
		int32_t L_153 = V_9;
		V_9 = ((int32_t)il2cpp_codegen_add(L_153, 1));
	}

IL_0337:
	{
		int32_t L_154 = V_9;
		int32_t L_155 = V_8;
		if ((((int32_t)L_154) < ((int32_t)L_155)))
		{
			goto IL_0066;
		}
	}

IL_0340:
	{
		int32_t L_156 = V_3;
		V_3 = ((int32_t)il2cpp_codegen_add(L_156, 1));
	}

IL_0344:
	{
		int32_t L_157 = V_3;
		int32_t L_158 = V_2;
		if ((((int32_t)L_157) < ((int32_t)L_158)))
		{
			goto IL_0026;
		}
	}
	{
		return;
	}
}
// Rewired.Controller Rewired.Player/ControllerHelper::uUCnSLiwzDzEwSKQHkRazBtyJViG<System.Guid>(Rewired.ControllerType,System.Func`3<Rewired.Controller,?,System.Boolean>,?)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Controller_t919A4A50FC7A0F25D7B31615C0F4E4D4A4D17911* ControllerHelper_uUCnSLiwzDzEwSKQHkRazBtyJViG_TisGuid_t_mE94249602C6C53F92791234E6FC7927D4A7C5BA8_gshared (ControllerHelper_tCE72EA23053BD0C6ECB4D75A69F8CD1B3AC28FF6* __this, int32_t p0, Func_3_tF4129F872BD8CCCF0D22456285DD4191EE3A59E2* p1, Guid_t p2, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IList_1_t0E8029D42F0DEC35CD39DEC3272477AC5F817EF9_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IList_1_t384DC26B697CDDF863348AB942D99FE38CFCECDB_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
int32_t V_0 = 0;
	RuntimeObject* V_1 = NULL;
	int32_t V_2 = 0;
	int32_t V_3 = 0;
	RuntimeObject* V_4 = NULL;
	int32_t V_5 = 0;
	{
		int32_t L_0 = p0;
		switch (L_0)
		{
			case 0:
			{
				goto IL_0050;
			}
			case 1:
			{
				goto IL_0070;
			}
			case 2:
			{
				goto IL_001c;
			}
		}
	}
	{
		int32_t L_1 = p0;
		if ((((int32_t)L_1) == ((int32_t)((int32_t)20))))
		{
			goto IL_0090;
		}
	}
	{
		goto IL_00cd;
	}

IL_001c:
	{
		int32_t L_2;
		L_2 = ControllerHelper_get_joystickCount_mC406E90F7590A70398B87179D8A54A6CA863BB7A(__this, NULL);
		V_0 = L_2;
		RuntimeObject* L_3;
		L_3 = ControllerHelper_get_Joysticks_m3D773A47247A4AC9F2D767782F68325CE2418CD6(__this, NULL);
		V_1 = L_3;
		V_2 = 0;
		goto IL_004a;
	}

IL_002e:
	{
		Func_3_tF4129F872BD8CCCF0D22456285DD4191EE3A59E2* L_4 = p1;
		RuntimeObject* L_5 = V_1;
		int32_t L_6 = V_2;
		NullCheck(L_5);
		Joystick_tEC65D4846A553E83F365E7D8D263DC644C75FC11* L_7;
		L_7 = InterfaceFuncInvoker1< Joystick_tEC65D4846A553E83F365E7D8D263DC644C75FC11*, int32_t >::Invoke(0 /* T System.Collections.Generic.IList`1<Rewired.Joystick>::get_Item(System.Int32) */, IList_1_t384DC26B697CDDF863348AB942D99FE38CFCECDB_il2cpp_TypeInfo_var, L_5, L_6);
		Guid_t L_8 = p2;
		NullCheck(L_4);
		bool L_9;
		L_9 = ((  bool (*) (Func_3_tF4129F872BD8CCCF0D22456285DD4191EE3A59E2*, Controller_t919A4A50FC7A0F25D7B31615C0F4E4D4A4D17911*, Guid_t, const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->rgctx_data, 1)))(L_4, (Controller_t919A4A50FC7A0F25D7B31615C0F4E4D4A4D17911*)L_7, L_8, il2cpp_rgctx_method(method->rgctx_data, 1));
		if (!L_9)
		{
			goto IL_0046;
		}
	}
	{
		RuntimeObject* L_10 = V_1;
		int32_t L_11 = V_2;
		NullCheck(L_10);
		Joystick_tEC65D4846A553E83F365E7D8D263DC644C75FC11* L_12;
		L_12 = InterfaceFuncInvoker1< Joystick_tEC65D4846A553E83F365E7D8D263DC644C75FC11*, int32_t >::Invoke(0 /* T System.Collections.Generic.IList`1<Rewired.Joystick>::get_Item(System.Int32) */, IList_1_t384DC26B697CDDF863348AB942D99FE38CFCECDB_il2cpp_TypeInfo_var, L_10, L_11);
		return (Controller_t919A4A50FC7A0F25D7B31615C0F4E4D4A4D17911*)L_12;
	}

IL_0046:
	{
		int32_t L_13 = V_2;
		V_2 = ((int32_t)il2cpp_codegen_add(L_13, 1));
	}

IL_004a:
	{
		int32_t L_14 = V_2;
		int32_t L_15 = V_0;
		if ((((int32_t)L_14) < ((int32_t)L_15)))
		{
			goto IL_002e;
		}
	}
	{
		return (Controller_t919A4A50FC7A0F25D7B31615C0F4E4D4A4D17911*)NULL;
	}

IL_0050:
	{
		bool L_16 = (bool)__this->___dBLcgVfbQAfhgyHLKVtzegFukmFdb_2;
		if (!L_16)
		{
			goto IL_006e;
		}
	}
	{
		Func_3_tF4129F872BD8CCCF0D22456285DD4191EE3A59E2* L_17 = p1;
		Keyboard_t3FD52938480ACCD23FDB0DAEC857F9A9D29CC6C3* L_18;
		L_18 = ControllerHelper_get_Keyboard_mDF3B56D2215293B50DA234D8379075C219576C90(__this, NULL);
		Guid_t L_19 = p2;
		NullCheck(L_17);
		bool L_20;
		L_20 = ((  bool (*) (Func_3_tF4129F872BD8CCCF0D22456285DD4191EE3A59E2*, Controller_t919A4A50FC7A0F25D7B31615C0F4E4D4A4D17911*, Guid_t, const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->rgctx_data, 1)))(L_17, (Controller_t919A4A50FC7A0F25D7B31615C0F4E4D4A4D17911*)L_18, L_19, il2cpp_rgctx_method(method->rgctx_data, 1));
		if (!L_20)
		{
			goto IL_006e;
		}
	}
	{
		Keyboard_t3FD52938480ACCD23FDB0DAEC857F9A9D29CC6C3* L_21;
		L_21 = ControllerHelper_get_Keyboard_mDF3B56D2215293B50DA234D8379075C219576C90(__this, NULL);
		return (Controller_t919A4A50FC7A0F25D7B31615C0F4E4D4A4D17911*)L_21;
	}

IL_006e:
	{
		return (Controller_t919A4A50FC7A0F25D7B31615C0F4E4D4A4D17911*)NULL;
	}

IL_0070:
	{
		bool L_22 = (bool)__this->___AGJkYNtGyvZWiyWIaEfTgcpraKBu_1;
		if (!L_22)
		{
			goto IL_008e;
		}
	}
	{
		Func_3_tF4129F872BD8CCCF0D22456285DD4191EE3A59E2* L_23 = p1;
		Mouse_t5C8D9CB89A5C0F4EE87A70501CAF2A68E36DC019* L_24;
		L_24 = ControllerHelper_get_Mouse_m8F587BDFB0DDB529D1E1D2B605406D8CACAA70A6(__this, NULL);
		Guid_t L_25 = p2;
		NullCheck(L_23);
		bool L_26;
		L_26 = ((  bool (*) (Func_3_tF4129F872BD8CCCF0D22456285DD4191EE3A59E2*, Controller_t919A4A50FC7A0F25D7B31615C0F4E4D4A4D17911*, Guid_t, const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->rgctx_data, 1)))(L_23, (Controller_t919A4A50FC7A0F25D7B31615C0F4E4D4A4D17911*)L_24, L_25, il2cpp_rgctx_method(method->rgctx_data, 1));
		if (!L_26)
		{
			goto IL_008e;
		}
	}
	{
		Mouse_t5C8D9CB89A5C0F4EE87A70501CAF2A68E36DC019* L_27;
		L_27 = ControllerHelper_get_Mouse_m8F587BDFB0DDB529D1E1D2B605406D8CACAA70A6(__this, NULL);
		return (Controller_t919A4A50FC7A0F25D7B31615C0F4E4D4A4D17911*)L_27;
	}

IL_008e:
	{
		return (Controller_t919A4A50FC7A0F25D7B31615C0F4E4D4A4D17911*)NULL;
	}

IL_0090:
	{
		int32_t L_28;
		L_28 = ControllerHelper_get_customControllerCount_m52F4B4EE672420770B0ECCB55882909AD3C3A0DD(__this, NULL);
		V_3 = L_28;
		RuntimeObject* L_29;
		L_29 = ControllerHelper_get_CustomControllers_mE7A063106EFC07E69E315C3ECA08A11E11B073D3(__this, NULL);
		V_4 = L_29;
		V_5 = 0;
		goto IL_00c6;
	}

IL_00a4:
	{
		Func_3_tF4129F872BD8CCCF0D22456285DD4191EE3A59E2* L_30 = p1;
		RuntimeObject* L_31 = V_4;
		int32_t L_32 = V_5;
		NullCheck(L_31);
		CustomController_t749B7DF2AA8AD20FEC4C2003C4FF5000FE9C6065* L_33;
		L_33 = InterfaceFuncInvoker1< CustomController_t749B7DF2AA8AD20FEC4C2003C4FF5000FE9C6065*, int32_t >::Invoke(0 /* T System.Collections.Generic.IList`1<Rewired.CustomController>::get_Item(System.Int32) */, IList_1_t0E8029D42F0DEC35CD39DEC3272477AC5F817EF9_il2cpp_TypeInfo_var, L_31, L_32);
		Guid_t L_34 = p2;
		NullCheck(L_30);
		bool L_35;
		L_35 = ((  bool (*) (Func_3_tF4129F872BD8CCCF0D22456285DD4191EE3A59E2*, Controller_t919A4A50FC7A0F25D7B31615C0F4E4D4A4D17911*, Guid_t, const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->rgctx_data, 1)))(L_30, (Controller_t919A4A50FC7A0F25D7B31615C0F4E4D4A4D17911*)L_33, L_34, il2cpp_rgctx_method(method->rgctx_data, 1));
		if (!L_35)
		{
			goto IL_00c0;
		}
	}
	{
		RuntimeObject* L_36 = V_4;
		int32_t L_37 = V_5;
		NullCheck(L_36);
		CustomController_t749B7DF2AA8AD20FEC4C2003C4FF5000FE9C6065* L_38;
		L_38 = InterfaceFuncInvoker1< CustomController_t749B7DF2AA8AD20FEC4C2003C4FF5000FE9C6065*, int32_t >::Invoke(0 /* T System.Collections.Generic.IList`1<Rewired.CustomController>::get_Item(System.Int32) */, IList_1_t0E8029D42F0DEC35CD39DEC3272477AC5F817EF9_il2cpp_TypeInfo_var, L_36, L_37);
		return (Controller_t919A4A50FC7A0F25D7B31615C0F4E4D4A4D17911*)L_38;
	}

IL_00c0:
	{
		int32_t L_39 = V_5;
		V_5 = ((int32_t)il2cpp_codegen_add(L_39, 1));
	}

IL_00c6:
	{
		int32_t L_40 = V_5;
		int32_t L_41 = V_3;
		if ((((int32_t)L_40) < ((int32_t)L_41)))
		{
			goto IL_00a4;
		}
	}
	{
		return (Controller_t919A4A50FC7A0F25D7B31615C0F4E4D4A4D17911*)NULL;
	}

IL_00cd:
	{
		NotImplementedException_t6366FE4DCF15094C51F4833B91A2AE68D4DA90E8* L_42 = (NotImplementedException_t6366FE4DCF15094C51F4833B91A2AE68D4DA90E8*)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&NotImplementedException_t6366FE4DCF15094C51F4833B91A2AE68D4DA90E8_il2cpp_TypeInfo_var)));
		NotImplementedException__ctor_mDAB47BC6BD0E342E8F2171E5CABE3E67EA049F1C(L_42, /*hidden argument*/NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_42, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&ControllerHelper_uUCnSLiwzDzEwSKQHkRazBtyJViG_TisGuid_t_mE94249602C6C53F92791234E6FC7927D4A7C5BA8_RuntimeMethod_var)));
	}
}
// Rewired.Controller Rewired.Player/ControllerHelper::uUCnSLiwzDzEwSKQHkRazBtyJViG<System.Object>(Rewired.ControllerType,System.Func`3<Rewired.Controller,?,System.Boolean>,?)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Controller_t919A4A50FC7A0F25D7B31615C0F4E4D4A4D17911* ControllerHelper_uUCnSLiwzDzEwSKQHkRazBtyJViG_TisRuntimeObject_m21AA9E2C96964EF0D8F8CE5F967724B3300D72D7_gshared (ControllerHelper_tCE72EA23053BD0C6ECB4D75A69F8CD1B3AC28FF6* __this, int32_t p0, Func_3_tFE04544F8517BA81CF80AC748CE401211FE150B0* p1, RuntimeObject* p2, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IList_1_t0E8029D42F0DEC35CD39DEC3272477AC5F817EF9_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IList_1_t384DC26B697CDDF863348AB942D99FE38CFCECDB_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
int32_t V_0 = 0;
	RuntimeObject* V_1 = NULL;
	int32_t V_2 = 0;
	int32_t V_3 = 0;
	RuntimeObject* V_4 = NULL;
	int32_t V_5 = 0;
	{
		int32_t L_0 = p0;
		switch (L_0)
		{
			case 0:
			{
				goto IL_0050;
			}
			case 1:
			{
				goto IL_0070;
			}
			case 2:
			{
				goto IL_001c;
			}
		}
	}
	{
		int32_t L_1 = p0;
		if ((((int32_t)L_1) == ((int32_t)((int32_t)20))))
		{
			goto IL_0090;
		}
	}
	{
		goto IL_00cd;
	}

IL_001c:
	{
		int32_t L_2;
		L_2 = ControllerHelper_get_joystickCount_mC406E90F7590A70398B87179D8A54A6CA863BB7A(__this, NULL);
		V_0 = L_2;
		RuntimeObject* L_3;
		L_3 = ControllerHelper_get_Joysticks_m3D773A47247A4AC9F2D767782F68325CE2418CD6(__this, NULL);
		V_1 = L_3;
		V_2 = 0;
		goto IL_004a;
	}

IL_002e:
	{
		Func_3_tFE04544F8517BA81CF80AC748CE401211FE150B0* L_4 = p1;
		RuntimeObject* L_5 = V_1;
		int32_t L_6 = V_2;
		NullCheck(L_5);
		Joystick_tEC65D4846A553E83F365E7D8D263DC644C75FC11* L_7;
		L_7 = InterfaceFuncInvoker1< Joystick_tEC65D4846A553E83F365E7D8D263DC644C75FC11*, int32_t >::Invoke(0 /* T System.Collections.Generic.IList`1<Rewired.Joystick>::get_Item(System.Int32) */, IList_1_t384DC26B697CDDF863348AB942D99FE38CFCECDB_il2cpp_TypeInfo_var, L_5, L_6);
		RuntimeObject* L_8 = p2;
		NullCheck(L_4);
		bool L_9;
		L_9 = ((  bool (*) (Func_3_tFE04544F8517BA81CF80AC748CE401211FE150B0*, Controller_t919A4A50FC7A0F25D7B31615C0F4E4D4A4D17911*, RuntimeObject*, const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->rgctx_data, 1)))(L_4, (Controller_t919A4A50FC7A0F25D7B31615C0F4E4D4A4D17911*)L_7, L_8, il2cpp_rgctx_method(method->rgctx_data, 1));
		if (!L_9)
		{
			goto IL_0046;
		}
	}
	{
		RuntimeObject* L_10 = V_1;
		int32_t L_11 = V_2;
		NullCheck(L_10);
		Joystick_tEC65D4846A553E83F365E7D8D263DC644C75FC11* L_12;
		L_12 = InterfaceFuncInvoker1< Joystick_tEC65D4846A553E83F365E7D8D263DC644C75FC11*, int32_t >::Invoke(0 /* T System.Collections.Generic.IList`1<Rewired.Joystick>::get_Item(System.Int32) */, IList_1_t384DC26B697CDDF863348AB942D99FE38CFCECDB_il2cpp_TypeInfo_var, L_10, L_11);
		return (Controller_t919A4A50FC7A0F25D7B31615C0F4E4D4A4D17911*)L_12;
	}

IL_0046:
	{
		int32_t L_13 = V_2;
		V_2 = ((int32_t)il2cpp_codegen_add(L_13, 1));
	}

IL_004a:
	{
		int32_t L_14 = V_2;
		int32_t L_15 = V_0;
		if ((((int32_t)L_14) < ((int32_t)L_15)))
		{
			goto IL_002e;
		}
	}
	{
		return (Controller_t919A4A50FC7A0F25D7B31615C0F4E4D4A4D17911*)NULL;
	}

IL_0050:
	{
		bool L_16 = (bool)__this->___dBLcgVfbQAfhgyHLKVtzegFukmFdb_2;
		if (!L_16)
		{
			goto IL_006e;
		}
	}
	{
		Func_3_tFE04544F8517BA81CF80AC748CE401211FE150B0* L_17 = p1;
		Keyboard_t3FD52938480ACCD23FDB0DAEC857F9A9D29CC6C3* L_18;
		L_18 = ControllerHelper_get_Keyboard_mDF3B56D2215293B50DA234D8379075C219576C90(__this, NULL);
		RuntimeObject* L_19 = p2;
		NullCheck(L_17);
		bool L_20;
		L_20 = ((  bool (*) (Func_3_tFE04544F8517BA81CF80AC748CE401211FE150B0*, Controller_t919A4A50FC7A0F25D7B31615C0F4E4D4A4D17911*, RuntimeObject*, const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->rgctx_data, 1)))(L_17, (Controller_t919A4A50FC7A0F25D7B31615C0F4E4D4A4D17911*)L_18, L_19, il2cpp_rgctx_method(method->rgctx_data, 1));
		if (!L_20)
		{
			goto IL_006e;
		}
	}
	{
		Keyboard_t3FD52938480ACCD23FDB0DAEC857F9A9D29CC6C3* L_21;
		L_21 = ControllerHelper_get_Keyboard_mDF3B56D2215293B50DA234D8379075C219576C90(__this, NULL);
		return (Controller_t919A4A50FC7A0F25D7B31615C0F4E4D4A4D17911*)L_21;
	}

IL_006e:
	{
		return (Controller_t919A4A50FC7A0F25D7B31615C0F4E4D4A4D17911*)NULL;
	}

IL_0070:
	{
		bool L_22 = (bool)__this->___AGJkYNtGyvZWiyWIaEfTgcpraKBu_1;
		if (!L_22)
		{
			goto IL_008e;
		}
	}
	{
		Func_3_tFE04544F8517BA81CF80AC748CE401211FE150B0* L_23 = p1;
		Mouse_t5C8D9CB89A5C0F4EE87A70501CAF2A68E36DC019* L_24;
		L_24 = ControllerHelper_get_Mouse_m8F587BDFB0DDB529D1E1D2B605406D8CACAA70A6(__this, NULL);
		RuntimeObject* L_25 = p2;
		NullCheck(L_23);
		bool L_26;
		L_26 = ((  bool (*) (Func_3_tFE04544F8517BA81CF80AC748CE401211FE150B0*, Controller_t919A4A50FC7A0F25D7B31615C0F4E4D4A4D17911*, RuntimeObject*, const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->rgctx_data, 1)))(L_23, (Controller_t919A4A50FC7A0F25D7B31615C0F4E4D4A4D17911*)L_24, L_25, il2cpp_rgctx_method(method->rgctx_data, 1));
		if (!L_26)
		{
			goto IL_008e;
		}
	}
	{
		Mouse_t5C8D9CB89A5C0F4EE87A70501CAF2A68E36DC019* L_27;
		L_27 = ControllerHelper_get_Mouse_m8F587BDFB0DDB529D1E1D2B605406D8CACAA70A6(__this, NULL);
		return (Controller_t919A4A50FC7A0F25D7B31615C0F4E4D4A4D17911*)L_27;
	}

IL_008e:
	{
		return (Controller_t919A4A50FC7A0F25D7B31615C0F4E4D4A4D17911*)NULL;
	}

IL_0090:
	{
		int32_t L_28;
		L_28 = ControllerHelper_get_customControllerCount_m52F4B4EE672420770B0ECCB55882909AD3C3A0DD(__this, NULL);
		V_3 = L_28;
		RuntimeObject* L_29;
		L_29 = ControllerHelper_get_CustomControllers_mE7A063106EFC07E69E315C3ECA08A11E11B073D3(__this, NULL);
		V_4 = L_29;
		V_5 = 0;
		goto IL_00c6;
	}

IL_00a4:
	{
		Func_3_tFE04544F8517BA81CF80AC748CE401211FE150B0* L_30 = p1;
		RuntimeObject* L_31 = V_4;
		int32_t L_32 = V_5;
		NullCheck(L_31);
		CustomController_t749B7DF2AA8AD20FEC4C2003C4FF5000FE9C6065* L_33;
		L_33 = InterfaceFuncInvoker1< CustomController_t749B7DF2AA8AD20FEC4C2003C4FF5000FE9C6065*, int32_t >::Invoke(0 /* T System.Collections.Generic.IList`1<Rewired.CustomController>::get_Item(System.Int32) */, IList_1_t0E8029D42F0DEC35CD39DEC3272477AC5F817EF9_il2cpp_TypeInfo_var, L_31, L_32);
		RuntimeObject* L_34 = p2;
		NullCheck(L_30);
		bool L_35;
		L_35 = ((  bool (*) (Func_3_tFE04544F8517BA81CF80AC748CE401211FE150B0*, Controller_t919A4A50FC7A0F25D7B31615C0F4E4D4A4D17911*, RuntimeObject*, const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->rgctx_data, 1)))(L_30, (Controller_t919A4A50FC7A0F25D7B31615C0F4E4D4A4D17911*)L_33, L_34, il2cpp_rgctx_method(method->rgctx_data, 1));
		if (!L_35)
		{
			goto IL_00c0;
		}
	}
	{
		RuntimeObject* L_36 = V_4;
		int32_t L_37 = V_5;
		NullCheck(L_36);
		CustomController_t749B7DF2AA8AD20FEC4C2003C4FF5000FE9C6065* L_38;
		L_38 = InterfaceFuncInvoker1< CustomController_t749B7DF2AA8AD20FEC4C2003C4FF5000FE9C6065*, int32_t >::Invoke(0 /* T System.Collections.Generic.IList`1<Rewired.CustomController>::get_Item(System.Int32) */, IList_1_t0E8029D42F0DEC35CD39DEC3272477AC5F817EF9_il2cpp_TypeInfo_var, L_36, L_37);
		return (Controller_t919A4A50FC7A0F25D7B31615C0F4E4D4A4D17911*)L_38;
	}

IL_00c0:
	{
		int32_t L_39 = V_5;
		V_5 = ((int32_t)il2cpp_codegen_add(L_39, 1));
	}

IL_00c6:
	{
		int32_t L_40 = V_5;
		int32_t L_41 = V_3;
		if ((((int32_t)L_40) < ((int32_t)L_41)))
		{
			goto IL_00a4;
		}
	}
	{
		return (Controller_t919A4A50FC7A0F25D7B31615C0F4E4D4A4D17911*)NULL;
	}

IL_00cd:
	{
		NotImplementedException_t6366FE4DCF15094C51F4833B91A2AE68D4DA90E8* L_42 = (NotImplementedException_t6366FE4DCF15094C51F4833B91A2AE68D4DA90E8*)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&NotImplementedException_t6366FE4DCF15094C51F4833B91A2AE68D4DA90E8_il2cpp_TypeInfo_var)));
		NotImplementedException__ctor_mDAB47BC6BD0E342E8F2171E5CABE3E67EA049F1C(L_42, /*hidden argument*/NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_42, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&ControllerHelper_uUCnSLiwzDzEwSKQHkRazBtyJViG_TisRuntimeObject_m21AA9E2C96964EF0D8F8CE5F967724B3300D72D7_RuntimeMethod_var)));
	}
}
// ? Rewired.PlayerController/CompoundElement::XjPzCjeHEKrmnInBxcqjiOQOEIgL<System.Object>(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* CompoundElement_XjPzCjeHEKrmnInBxcqjiOQOEIgL_TisRuntimeObject_m03DF76C5D578AA42AF7DECAE27C272C0213FF093_gshared (CompoundElement_t89F22D17450D47C1307CC80AFA332B78C00CEB87* __this, int32_t p0, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_get_Count_m4360FE38E465AC825248281834873BEC2CA1DE0A_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_get_Item_mF23E84EFE39E9A88D8A6A9D2061A0B3B3A0FEAF4_RuntimeMethod_var);
		s_Il2CppMethodInitialized = true;
	}
RuntimeObject* V_0 = NULL;
	{
		int32_t L_0 = p0;
		List_1_t1327B0703B35EF48626AC42F0D0C487FCBD86CF5* L_1 = (List_1_t1327B0703B35EF48626AC42F0D0C487FCBD86CF5*)__this->___FZydGRarJpccYCkKlMkeaFhsIdKT_7;
		NullCheck(L_1);
		int32_t L_2;
		L_2 = List_1_get_Count_m4360FE38E465AC825248281834873BEC2CA1DE0A_inline(L_1, List_1_get_Count_m4360FE38E465AC825248281834873BEC2CA1DE0A_RuntimeMethod_var);
		if ((!(((uint32_t)L_0) >= ((uint32_t)L_2))))
		{
			goto IL_0018;
		}
	}
	{
		il2cpp_codegen_initobj((&V_0), sizeof(RuntimeObject*));
		RuntimeObject* L_3 = V_0;
		return L_3;
	}

IL_0018:
	{
		List_1_t1327B0703B35EF48626AC42F0D0C487FCBD86CF5* L_4 = (List_1_t1327B0703B35EF48626AC42F0D0C487FCBD86CF5*)__this->___FZydGRarJpccYCkKlMkeaFhsIdKT_7;
		int32_t L_5 = p0;
		NullCheck(L_4);
		Element_t26F7003E01AAF28091E75E0A3552C2C3EEA38F06* L_6;
		L_6 = List_1_get_Item_mF23E84EFE39E9A88D8A6A9D2061A0B3B3A0FEAF4(L_4, L_5, List_1_get_Item_mF23E84EFE39E9A88D8A6A9D2061A0B3B3A0FEAF4_RuntimeMethod_var);
		return ((RuntimeObject*)Castclass((RuntimeObject*)((RuntimeObject*)IsInst((RuntimeObject*)L_6, il2cpp_rgctx_data(method->rgctx_data, 0))), il2cpp_rgctx_data(method->rgctx_data, 0)));
	}
}
// T Rewired.ReInput/ControllerHelper::GetController<System.Object>(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* ControllerHelper_GetController_TisRuntimeObject_mB7D90A999A30B36C1F7501C7B3A296CE358A8D0C_gshared (ControllerHelper_t470828F1E9094A484F8FE12DB16199890DF23F5E* __this, int32_t ___controllerId0, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&CustomController_t749B7DF2AA8AD20FEC4C2003C4FF5000FE9C6065_0_0_0_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Joystick_tEC65D4846A553E83F365E7D8D263DC644C75FC11_0_0_0_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Keyboard_t3FD52938480ACCD23FDB0DAEC857F9A9D29CC6C3_0_0_0_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Mouse_t5C8D9CB89A5C0F4EE87A70501CAF2A68E36DC019_0_0_0_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Type_t_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
Type_t* V_0 = NULL;
	RuntimeObject* V_1 = NULL;
	{
		il2cpp_codegen_runtime_class_init_inline(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		bool L_0;
		L_0 = ReInput_CheckInitialized_m77ED29D92874786A88A3FA315343991DA7A5B95B(NULL);
		if (L_0)
		{
			goto IL_0011;
		}
	}
	{
		il2cpp_codegen_initobj((&V_1), sizeof(RuntimeObject*));
		RuntimeObject* L_1 = V_1;
		return L_1;
	}

IL_0011:
	{
		int32_t L_2 = ___controllerId0;
		if ((((int32_t)L_2) >= ((int32_t)0)))
		{
			goto IL_001f;
		}
	}
	{
		il2cpp_codegen_initobj((&V_1), sizeof(RuntimeObject*));
		RuntimeObject* L_3 = V_1;
		return L_3;
	}

IL_001f:
	{
		RuntimeTypeHandle_t332A452B8B6179E4469B69525D0FE82A88030F7B L_4 = { reinterpret_cast<intptr_t> (il2cpp_rgctx_type(method->rgctx_data, 0)) };
		il2cpp_codegen_runtime_class_init_inline(Type_t_il2cpp_TypeInfo_var);
		Type_t* L_5;
		L_5 = Type_GetTypeFromHandle_m2570A2A5B32A5E9D9F0F38B37459DA18736C823E(L_4, NULL);
		V_0 = L_5;
		Type_t* L_6 = V_0;
		RuntimeTypeHandle_t332A452B8B6179E4469B69525D0FE82A88030F7B L_7 = { reinterpret_cast<intptr_t> (Joystick_tEC65D4846A553E83F365E7D8D263DC644C75FC11_0_0_0_var) };
		Type_t* L_8;
		L_8 = Type_GetTypeFromHandle_m2570A2A5B32A5E9D9F0F38B37459DA18736C823E(L_7, NULL);
		bool L_9;
		L_9 = ReflectionTools_DoesTypeImplement_m76A5EBA9D9AF0CCCD6DE916990142B42729852D0(L_6, L_8, NULL);
		if (!L_9)
		{
			goto IL_004e;
		}
	}
	{
		int32_t L_10 = ___controllerId0;
		Joystick_tEC65D4846A553E83F365E7D8D263DC644C75FC11* L_11;
		L_11 = ControllerHelper_GetJoystick_mC1549CA46BA18439089ED2562EB2EFF65C249F4A(__this, L_10, NULL);
		return ((RuntimeObject*)Castclass((RuntimeObject*)((RuntimeObject*)IsInst((RuntimeObject*)L_11, il2cpp_rgctx_data(method->rgctx_data, 1))), il2cpp_rgctx_data(method->rgctx_data, 1)));
	}

IL_004e:
	{
		Type_t* L_12 = V_0;
		RuntimeTypeHandle_t332A452B8B6179E4469B69525D0FE82A88030F7B L_13 = { reinterpret_cast<intptr_t> (Keyboard_t3FD52938480ACCD23FDB0DAEC857F9A9D29CC6C3_0_0_0_var) };
		il2cpp_codegen_runtime_class_init_inline(Type_t_il2cpp_TypeInfo_var);
		Type_t* L_14;
		L_14 = Type_GetTypeFromHandle_m2570A2A5B32A5E9D9F0F38B37459DA18736C823E(L_13, NULL);
		bool L_15;
		L_15 = ReflectionTools_DoesTypeImplement_m76A5EBA9D9AF0CCCD6DE916990142B42729852D0(L_12, L_14, NULL);
		if (!L_15)
		{
			goto IL_0075;
		}
	}
	{
		il2cpp_codegen_runtime_class_init_inline(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		TAqjagBhKGcWECRbpfkHPNKbpxLsA_t5B25C84F87417D98CA0E8452EAD0DB3A23D7833A* L_16 = ((ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_StaticFields*)il2cpp_codegen_static_fields_for(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var))->___pufaEMRhTHuKQfVnvkQxbbFTmmTc_10;
		NullCheck(L_16);
		Keyboard_t3FD52938480ACCD23FDB0DAEC857F9A9D29CC6C3* L_17;
		L_17 = TAqjagBhKGcWECRbpfkHPNKbpxLsA_YdrUiKuiWrCsfuIZfuOolsqFcFEd_m2F1D148A44E13C083F209FF609EDF416976764B4_inline(L_16, NULL);
		return ((RuntimeObject*)Castclass((RuntimeObject*)((RuntimeObject*)IsInst((RuntimeObject*)L_17, il2cpp_rgctx_data(method->rgctx_data, 1))), il2cpp_rgctx_data(method->rgctx_data, 1)));
	}

IL_0075:
	{
		Type_t* L_18 = V_0;
		RuntimeTypeHandle_t332A452B8B6179E4469B69525D0FE82A88030F7B L_19 = { reinterpret_cast<intptr_t> (CustomController_t749B7DF2AA8AD20FEC4C2003C4FF5000FE9C6065_0_0_0_var) };
		il2cpp_codegen_runtime_class_init_inline(Type_t_il2cpp_TypeInfo_var);
		Type_t* L_20;
		L_20 = Type_GetTypeFromHandle_m2570A2A5B32A5E9D9F0F38B37459DA18736C823E(L_19, NULL);
		bool L_21;
		L_21 = ReflectionTools_DoesTypeImplement_m76A5EBA9D9AF0CCCD6DE916990142B42729852D0(L_18, L_20, NULL);
		if (!L_21)
		{
			goto IL_0099;
		}
	}
	{
		int32_t L_22 = ___controllerId0;
		CustomController_t749B7DF2AA8AD20FEC4C2003C4FF5000FE9C6065* L_23;
		L_23 = ControllerHelper_GetCustomController_m31319248887899487DD819B1C9A51224D0786753(__this, L_22, NULL);
		return ((RuntimeObject*)Castclass((RuntimeObject*)((RuntimeObject*)IsInst((RuntimeObject*)L_23, il2cpp_rgctx_data(method->rgctx_data, 1))), il2cpp_rgctx_data(method->rgctx_data, 1)));
	}

IL_0099:
	{
		Type_t* L_24 = V_0;
		RuntimeTypeHandle_t332A452B8B6179E4469B69525D0FE82A88030F7B L_25 = { reinterpret_cast<intptr_t> (Mouse_t5C8D9CB89A5C0F4EE87A70501CAF2A68E36DC019_0_0_0_var) };
		il2cpp_codegen_runtime_class_init_inline(Type_t_il2cpp_TypeInfo_var);
		Type_t* L_26;
		L_26 = Type_GetTypeFromHandle_m2570A2A5B32A5E9D9F0F38B37459DA18736C823E(L_25, NULL);
		bool L_27;
		L_27 = ReflectionTools_DoesTypeImplement_m76A5EBA9D9AF0CCCD6DE916990142B42729852D0(L_24, L_26, NULL);
		if (!L_27)
		{
			goto IL_00c0;
		}
	}
	{
		il2cpp_codegen_runtime_class_init_inline(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		TAqjagBhKGcWECRbpfkHPNKbpxLsA_t5B25C84F87417D98CA0E8452EAD0DB3A23D7833A* L_28 = ((ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_StaticFields*)il2cpp_codegen_static_fields_for(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var))->___pufaEMRhTHuKQfVnvkQxbbFTmmTc_10;
		NullCheck(L_28);
		Mouse_t5C8D9CB89A5C0F4EE87A70501CAF2A68E36DC019* L_29;
		L_29 = TAqjagBhKGcWECRbpfkHPNKbpxLsA_mQpaOTHDcjELSAhFNvChgQfDcoqub_mF11D81D13BFD78BC6E168C0996206A1CA946FC09_inline(L_28, NULL);
		return ((RuntimeObject*)Castclass((RuntimeObject*)((RuntimeObject*)IsInst((RuntimeObject*)L_29, il2cpp_rgctx_data(method->rgctx_data, 1))), il2cpp_rgctx_data(method->rgctx_data, 1)));
	}

IL_00c0:
	{
		NotImplementedException_t6366FE4DCF15094C51F4833B91A2AE68D4DA90E8* L_30 = (NotImplementedException_t6366FE4DCF15094C51F4833B91A2AE68D4DA90E8*)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&NotImplementedException_t6366FE4DCF15094C51F4833B91A2AE68D4DA90E8_il2cpp_TypeInfo_var)));
		NotImplementedException__ctor_mDAB47BC6BD0E342E8F2171E5CABE3E67EA049F1C(L_30, /*hidden argument*/NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_30, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&ControllerHelper_GetController_TisRuntimeObject_mB7D90A999A30B36C1F7501C7B3A296CE358A8D0C_RuntimeMethod_var)));
	}
}
// System.Collections.Generic.IList`1<TInterface> Rewired.ReInput/ControllerHelper::GetControllerTemplates<System.Object>()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* ControllerHelper_GetControllerTemplates_TisRuntimeObject_m5755D3181FB0F4BA4DDB4D2DEE6FF0E995B4F7B3_gshared (ControllerHelper_t470828F1E9094A484F8FE12DB16199890DF23F5E* __this, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
{
		il2cpp_codegen_runtime_class_init_inline(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		bool L_0;
		L_0 = ReInput_CheckInitialized_m77ED29D92874786A88A3FA315343991DA7A5B95B(NULL);
		if (L_0)
		{
			goto IL_000d;
		}
	}
	{
		RuntimeObject* L_1;
		L_1 = ((  RuntimeObject* (*) (const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->rgctx_data, 0)))(il2cpp_rgctx_method(method->rgctx_data, 0));
		return L_1;
	}

IL_000d:
	{
		il2cpp_codegen_runtime_class_init_inline(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		TAqjagBhKGcWECRbpfkHPNKbpxLsA_t5B25C84F87417D98CA0E8452EAD0DB3A23D7833A* L_2 = ((ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_StaticFields*)il2cpp_codegen_static_fields_for(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var))->___pufaEMRhTHuKQfVnvkQxbbFTmmTc_10;
		NullCheck(L_2);
		RuntimeObject* L_3;
		L_3 = ((  RuntimeObject* (*) (TAqjagBhKGcWECRbpfkHPNKbpxLsA_t5B25C84F87417D98CA0E8452EAD0DB3A23D7833A*, const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->rgctx_data, 2)))(L_2, il2cpp_rgctx_method(method->rgctx_data, 2));
		return L_3;
	}
}
// T Rewired.ReInput/ControllerHelper::GetLastActiveController<System.Object>()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* ControllerHelper_GetLastActiveController_TisRuntimeObject_m401CE23BE38BA123D7467FC439D2403C8CEAE7D9_gshared (ControllerHelper_t470828F1E9094A484F8FE12DB16199890DF23F5E* __this, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
RuntimeObject* V_0 = NULL;
	{
		il2cpp_codegen_runtime_class_init_inline(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		bool L_0;
		L_0 = ReInput_CheckInitialized_m77ED29D92874786A88A3FA315343991DA7A5B95B(NULL);
		if (L_0)
		{
			goto IL_0011;
		}
	}
	{
		il2cpp_codegen_initobj((&V_0), sizeof(RuntimeObject*));
		RuntimeObject* L_1 = V_0;
		return L_1;
	}

IL_0011:
	{
		il2cpp_codegen_runtime_class_init_inline(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		TAqjagBhKGcWECRbpfkHPNKbpxLsA_t5B25C84F87417D98CA0E8452EAD0DB3A23D7833A* L_2 = ((ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_StaticFields*)il2cpp_codegen_static_fields_for(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var))->___pufaEMRhTHuKQfVnvkQxbbFTmmTc_10;
		NullCheck(L_2);
		RuntimeObject* L_3;
		L_3 = ((  RuntimeObject* (*) (TAqjagBhKGcWECRbpfkHPNKbpxLsA_t5B25C84F87417D98CA0E8452EAD0DB3A23D7833A*, const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->rgctx_data, 0)))(L_2, il2cpp_rgctx_method(method->rgctx_data, 0));
		return L_3;
	}
}
// System.Int32 UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphResourceRegistry/RenderGraphResourcesData::AddNewRenderGraphResource<System.Object>(ResType&,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t RenderGraphResourcesData_AddNewRenderGraphResource_TisRuntimeObject_mB9040DF97633813729CADB454AAEAF31E23C7E91_gshared (RenderGraphResourcesData_tB2FF97B16A3E1DE700283778679C5CC0C39F4CFE* __this, RuntimeObject** ___outRes0, bool ___pooledResource1, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&DynamicArray_1_Resize_mEEEB907EAEFD4C22DB449FF052CF6AC967A27AD1_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&DynamicArray_1_get_Item_m5FC9383C3A815B0DF7AAD4C2A5CDFB1A25586ECE_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&DynamicArray_1_get_size_m56D2768863B15299FA4F2F14E271686207A8C2E4_RuntimeMethod_var);
		s_Il2CppMethodInitialized = true;
	}
int32_t V_0 = 0;
	RuntimeObject** G_B4_0 = NULL;
	RuntimeObject** G_B3_0 = NULL;
	IRenderGraphResourcePool_t8BF833F3C5D0BD8E45632CF923363EC782F4DDA8* G_B5_0 = NULL;
	RuntimeObject** G_B5_1 = NULL;
	{
		// int result = resourceArray.size;
		DynamicArray_1_t401F46C0081DE185BCAB1D30DE8D6B6DC9AA6AFB* L_0 = (DynamicArray_1_t401F46C0081DE185BCAB1D30DE8D6B6DC9AA6AFB*)__this->___resourceArray_0;
		NullCheck(L_0);
		int32_t L_1;
		L_1 = DynamicArray_1_get_size_m56D2768863B15299FA4F2F14E271686207A8C2E4_inline(L_0, DynamicArray_1_get_size_m56D2768863B15299FA4F2F14E271686207A8C2E4_RuntimeMethod_var);
		V_0 = L_1;
		// resourceArray.Resize(resourceArray.size + 1, true);
		DynamicArray_1_t401F46C0081DE185BCAB1D30DE8D6B6DC9AA6AFB* L_2 = (DynamicArray_1_t401F46C0081DE185BCAB1D30DE8D6B6DC9AA6AFB*)__this->___resourceArray_0;
		DynamicArray_1_t401F46C0081DE185BCAB1D30DE8D6B6DC9AA6AFB* L_3 = (DynamicArray_1_t401F46C0081DE185BCAB1D30DE8D6B6DC9AA6AFB*)__this->___resourceArray_0;
		NullCheck(L_3);
		int32_t L_4;
		L_4 = DynamicArray_1_get_size_m56D2768863B15299FA4F2F14E271686207A8C2E4_inline(L_3, DynamicArray_1_get_size_m56D2768863B15299FA4F2F14E271686207A8C2E4_RuntimeMethod_var);
		NullCheck(L_2);
		DynamicArray_1_Resize_mEEEB907EAEFD4C22DB449FF052CF6AC967A27AD1(L_2, ((int32_t)il2cpp_codegen_add(L_4, 1)), (bool)1, DynamicArray_1_Resize_mEEEB907EAEFD4C22DB449FF052CF6AC967A27AD1_RuntimeMethod_var);
		// if (resourceArray[result] == null)
		DynamicArray_1_t401F46C0081DE185BCAB1D30DE8D6B6DC9AA6AFB* L_5 = (DynamicArray_1_t401F46C0081DE185BCAB1D30DE8D6B6DC9AA6AFB*)__this->___resourceArray_0;
		int32_t L_6 = V_0;
		NullCheck(L_5);
		IRenderGraphResource_tF24653A388C17849844C128C19C7A6599C7ADB7D** L_7;
		L_7 = DynamicArray_1_get_Item_m5FC9383C3A815B0DF7AAD4C2A5CDFB1A25586ECE(L_5, L_6, DynamicArray_1_get_Item_m5FC9383C3A815B0DF7AAD4C2A5CDFB1A25586ECE_RuntimeMethod_var);
		IRenderGraphResource_tF24653A388C17849844C128C19C7A6599C7ADB7D* L_8 = *((IRenderGraphResource_tF24653A388C17849844C128C19C7A6599C7ADB7D**)L_7);
		if (L_8)
		{
			goto IL_004b;
		}
	}
	{
		// resourceArray[result] = new ResType();
		DynamicArray_1_t401F46C0081DE185BCAB1D30DE8D6B6DC9AA6AFB* L_9 = (DynamicArray_1_t401F46C0081DE185BCAB1D30DE8D6B6DC9AA6AFB*)__this->___resourceArray_0;
		int32_t L_10 = V_0;
		NullCheck(L_9);
		IRenderGraphResource_tF24653A388C17849844C128C19C7A6599C7ADB7D** L_11;
		L_11 = DynamicArray_1_get_Item_m5FC9383C3A815B0DF7AAD4C2A5CDFB1A25586ECE(L_9, L_10, DynamicArray_1_get_Item_m5FC9383C3A815B0DF7AAD4C2A5CDFB1A25586ECE_RuntimeMethod_var);
		RuntimeObject* L_12;
		L_12 = ((  RuntimeObject* (*) (const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->rgctx_data, 0)))(il2cpp_rgctx_method(method->rgctx_data, 0));
		*((RuntimeObject**)L_11) = (RuntimeObject*)L_12;
		Il2CppCodeGenWriteBarrier((void**)(RuntimeObject**)L_11, (void*)(RuntimeObject*)L_12);
	}

IL_004b:
	{
		// outRes = resourceArray[result] as ResType;
		RuntimeObject** L_13 = ___outRes0;
		DynamicArray_1_t401F46C0081DE185BCAB1D30DE8D6B6DC9AA6AFB* L_14 = (DynamicArray_1_t401F46C0081DE185BCAB1D30DE8D6B6DC9AA6AFB*)__this->___resourceArray_0;
		int32_t L_15 = V_0;
		NullCheck(L_14);
		IRenderGraphResource_tF24653A388C17849844C128C19C7A6599C7ADB7D** L_16;
		L_16 = DynamicArray_1_get_Item_m5FC9383C3A815B0DF7AAD4C2A5CDFB1A25586ECE(L_14, L_15, DynamicArray_1_get_Item_m5FC9383C3A815B0DF7AAD4C2A5CDFB1A25586ECE_RuntimeMethod_var);
		IRenderGraphResource_tF24653A388C17849844C128C19C7A6599C7ADB7D* L_17 = *((IRenderGraphResource_tF24653A388C17849844C128C19C7A6599C7ADB7D**)L_16);
		*(RuntimeObject**)L_13 = ((RuntimeObject*)Castclass((RuntimeObject*)((RuntimeObject*)IsInst((RuntimeObject*)L_17, il2cpp_rgctx_data(method->rgctx_data, 1))), il2cpp_rgctx_data(method->rgctx_data, 1)));
		Il2CppCodeGenWriteBarrier((void**)(RuntimeObject**)L_13, (void*)((RuntimeObject*)Castclass((RuntimeObject*)((RuntimeObject*)IsInst((RuntimeObject*)L_17, il2cpp_rgctx_data(method->rgctx_data, 1))), il2cpp_rgctx_data(method->rgctx_data, 1))));
		// outRes.Reset(pooledResource ? pool : null);
		RuntimeObject** L_18 = ___outRes0;
		bool L_19 = ___pooledResource1;
		G_B3_0 = L_18;
		if (L_19)
		{
			G_B4_0 = L_18;
			goto IL_006f;
		}
	}
	{
		G_B5_0 = ((IRenderGraphResourcePool_t8BF833F3C5D0BD8E45632CF923363EC782F4DDA8*)(NULL));
		G_B5_1 = G_B3_0;
		goto IL_0075;
	}

IL_006f:
	{
		IRenderGraphResourcePool_t8BF833F3C5D0BD8E45632CF923363EC782F4DDA8* L_20 = (IRenderGraphResourcePool_t8BF833F3C5D0BD8E45632CF923363EC782F4DDA8*)__this->___pool_2;
		G_B5_0 = L_20;
		G_B5_1 = G_B4_0;
	}

IL_0075:
	{
		NullCheck((IRenderGraphResource_tF24653A388C17849844C128C19C7A6599C7ADB7D*)(*G_B5_1));
		VirtualActionInvoker1< IRenderGraphResourcePool_t8BF833F3C5D0BD8E45632CF923363EC782F4DDA8* >::Invoke(4 /* System.Void UnityEngine.Experimental.Rendering.RenderGraphModule.IRenderGraphResource::Reset(UnityEngine.Experimental.Rendering.RenderGraphModule.IRenderGraphResourcePool) */, (IRenderGraphResource_tF24653A388C17849844C128C19C7A6599C7ADB7D*)(*G_B5_1), G_B5_0);
		// return result;
		int32_t L_21 = V_0;
		return L_21;
	}
}
// Rewired.Utils.TempListPool/TList`1<?> Rewired.Utils.TempListPool/TpeBEFhFAWNAsvKKQTVtIrdFUsQw::OlLACmpwoMamrxMTFzLaRnppBEGFA<Rewired.ControllerTemplateElementTarget>(System.Collections.Generic.List`1<?>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR TList_1_t08828BE7F5A36A1F8E5542F3DE822A03B4E625D7* TpeBEFhFAWNAsvKKQTVtIrdFUsQw_OlLACmpwoMamrxMTFzLaRnppBEGFA_TisControllerTemplateElementTarget_tDB0CB7A22A83FD188DBBB27A7D75DD3459D5542C_m73B7B7D8BE540D2410F77E3C5456F5C2F945B484_gshared (List_1_tB9A85F131783B7EEF32BCC88394DEF28B255F56A* p0, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ADictionary_2_Add_m0B52951B53E7F35DD40A3E9D2435F6A9921FEAD6_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ADictionary_2_ContainsKey_mC5ADB925423D250073B9A2A62A2534AB23B21A0F_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ADictionary_2_get_Item_m16DA44C3730BB63327BFAF65D10C028CA7CD13E3_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_RemoveAt_m54F62297ADEE4D4FDA697F49ED807BF901201B54_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1__ctor_m76CBBC3E2F0583F5AD30CE592CEA1225C06A0428_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_get_Count_m4407E4C389F22B8CEC282C15D56516658746C383_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_get_Item_m33561245D64798C2AB07584C0EC4F240E4839A38_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Type_t_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D* V_0 = NULL;
	int32_t V_1 = 0;
	{
		List_1_tB9A85F131783B7EEF32BCC88394DEF28B255F56A* L_0 = p0;
		if (L_0)
		{
			goto IL_000e;
		}
	}
	{
		ArgumentNullException_t327031E412FAB2351B0022DD5DAD47E67E597129* L_1 = (ArgumentNullException_t327031E412FAB2351B0022DD5DAD47E67E597129*)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&ArgumentNullException_t327031E412FAB2351B0022DD5DAD47E67E597129_il2cpp_TypeInfo_var)));
		ArgumentNullException__ctor_m444AE141157E333844FC1A9500224C2F9FD24F4B(L_1, ((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteral5AC64F41AC098111BD52F434F0C2E60A4F2DE3BC)), /*hidden argument*/NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_1, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&TpeBEFhFAWNAsvKKQTVtIrdFUsQw_OlLACmpwoMamrxMTFzLaRnppBEGFA_TisControllerTemplateElementTarget_tDB0CB7A22A83FD188DBBB27A7D75DD3459D5542C_m73B7B7D8BE540D2410F77E3C5456F5C2F945B484_RuntimeMethod_var)));
	}

IL_000e:
	{
		ADictionary_2_tE212D15054E58919DA98BE219858633B9BBE9C90* L_2;
		L_2 = TpeBEFhFAWNAsvKKQTVtIrdFUsQw_HPGleOOgRvXHtYsMXGTEsiryvtWs_m957491260AFBA8FB32FBC5DE4209106675FFB34C(NULL);
		RuntimeTypeHandle_t332A452B8B6179E4469B69525D0FE82A88030F7B L_3 = { reinterpret_cast<intptr_t> (il2cpp_rgctx_type(method->rgctx_data, 0)) };
		il2cpp_codegen_runtime_class_init_inline(Type_t_il2cpp_TypeInfo_var);
		Type_t* L_4;
		L_4 = Type_GetTypeFromHandle_m2570A2A5B32A5E9D9F0F38B37459DA18736C823E(L_3, NULL);
		NullCheck(L_2);
		bool L_5;
		L_5 = ADictionary_2_ContainsKey_mC5ADB925423D250073B9A2A62A2534AB23B21A0F(L_2, L_4, ADictionary_2_ContainsKey_mC5ADB925423D250073B9A2A62A2534AB23B21A0F_RuntimeMethod_var);
		if (L_5)
		{
			goto IL_003e;
		}
	}
	{
		ADictionary_2_tE212D15054E58919DA98BE219858633B9BBE9C90* L_6;
		L_6 = TpeBEFhFAWNAsvKKQTVtIrdFUsQw_HPGleOOgRvXHtYsMXGTEsiryvtWs_m957491260AFBA8FB32FBC5DE4209106675FFB34C(NULL);
		RuntimeTypeHandle_t332A452B8B6179E4469B69525D0FE82A88030F7B L_7 = { reinterpret_cast<intptr_t> (il2cpp_rgctx_type(method->rgctx_data, 0)) };
		il2cpp_codegen_runtime_class_init_inline(Type_t_il2cpp_TypeInfo_var);
		Type_t* L_8;
		L_8 = Type_GetTypeFromHandle_m2570A2A5B32A5E9D9F0F38B37459DA18736C823E(L_7, NULL);
		List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D* L_9 = (List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D*)il2cpp_codegen_object_new(List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D_il2cpp_TypeInfo_var);
		List_1__ctor_m76CBBC3E2F0583F5AD30CE592CEA1225C06A0428(L_9, 3, /*hidden argument*/List_1__ctor_m76CBBC3E2F0583F5AD30CE592CEA1225C06A0428_RuntimeMethod_var);
		NullCheck(L_6);
		ADictionary_2_Add_m0B52951B53E7F35DD40A3E9D2435F6A9921FEAD6(L_6, L_8, L_9, ADictionary_2_Add_m0B52951B53E7F35DD40A3E9D2435F6A9921FEAD6_RuntimeMethod_var);
	}

IL_003e:
	{
		ADictionary_2_tE212D15054E58919DA98BE219858633B9BBE9C90* L_10;
		L_10 = TpeBEFhFAWNAsvKKQTVtIrdFUsQw_HPGleOOgRvXHtYsMXGTEsiryvtWs_m957491260AFBA8FB32FBC5DE4209106675FFB34C(NULL);
		RuntimeTypeHandle_t332A452B8B6179E4469B69525D0FE82A88030F7B L_11 = { reinterpret_cast<intptr_t> (il2cpp_rgctx_type(method->rgctx_data, 0)) };
		il2cpp_codegen_runtime_class_init_inline(Type_t_il2cpp_TypeInfo_var);
		Type_t* L_12;
		L_12 = Type_GetTypeFromHandle_m2570A2A5B32A5E9D9F0F38B37459DA18736C823E(L_11, NULL);
		NullCheck(L_10);
		List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D* L_13;
		L_13 = ADictionary_2_get_Item_m16DA44C3730BB63327BFAF65D10C028CA7CD13E3(L_10, L_12, ADictionary_2_get_Item_m16DA44C3730BB63327BFAF65D10C028CA7CD13E3_RuntimeMethod_var);
		V_0 = L_13;
		List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D* L_14 = V_0;
		NullCheck(L_14);
		int32_t L_15;
		L_15 = List_1_get_Count_m4407E4C389F22B8CEC282C15D56516658746C383_inline(L_14, List_1_get_Count_m4407E4C389F22B8CEC282C15D56516658746C383_RuntimeMethod_var);
		if (L_15)
		{
			goto IL_0068;
		}
	}
	{
		TList_1_t08828BE7F5A36A1F8E5542F3DE822A03B4E625D7* L_16;
		L_16 = ((  TList_1_t08828BE7F5A36A1F8E5542F3DE822A03B4E625D7* (*) (const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->rgctx_data, 1)))(il2cpp_rgctx_method(method->rgctx_data, 1));
		TList_1_t08828BE7F5A36A1F8E5542F3DE822A03B4E625D7* L_17 = L_16;
		List_1_tB9A85F131783B7EEF32BCC88394DEF28B255F56A* L_18 = p0;
		NullCheck((RuntimeObject*)L_17);
		InterfaceActionInvoker1< List_1_tB9A85F131783B7EEF32BCC88394DEF28B255F56A* >::Invoke(0 /* System.Void Rewired.Utils.TempListPool/ITListSetter`1<Rewired.ControllerTemplateElementTarget>::SetList(System.Collections.Generic.List`1<T>) */, il2cpp_rgctx_data(method->rgctx_data, 3), (RuntimeObject*)L_17, L_18);
		return L_17;
	}

IL_0068:
	{
		List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D* L_19 = V_0;
		NullCheck(L_19);
		int32_t L_20;
		L_20 = List_1_get_Count_m4407E4C389F22B8CEC282C15D56516658746C383_inline(L_19, List_1_get_Count_m4407E4C389F22B8CEC282C15D56516658746C383_RuntimeMethod_var);
		V_1 = ((int32_t)il2cpp_codegen_subtract(L_20, 1));
		List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D* L_21 = V_0;
		int32_t L_22 = V_1;
		NullCheck(L_21);
		RuntimeObject* L_23;
		L_23 = List_1_get_Item_m33561245D64798C2AB07584C0EC4F240E4839A38(L_21, L_22, List_1_get_Item_m33561245D64798C2AB07584C0EC4F240E4839A38_RuntimeMethod_var);
		List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D* L_24 = V_0;
		int32_t L_25 = V_1;
		NullCheck(L_24);
		List_1_RemoveAt_m54F62297ADEE4D4FDA697F49ED807BF901201B54(L_24, L_25, List_1_RemoveAt_m54F62297ADEE4D4FDA697F49ED807BF901201B54_RuntimeMethod_var);
		TList_1_t08828BE7F5A36A1F8E5542F3DE822A03B4E625D7* L_26 = ((TList_1_t08828BE7F5A36A1F8E5542F3DE822A03B4E625D7*)IsInstSealed((RuntimeObject*)L_23, il2cpp_rgctx_data(method->rgctx_data, 5)));
		List_1_tB9A85F131783B7EEF32BCC88394DEF28B255F56A* L_27 = p0;
		NullCheck((RuntimeObject*)L_26);
		InterfaceActionInvoker1< List_1_tB9A85F131783B7EEF32BCC88394DEF28B255F56A* >::Invoke(0 /* System.Void Rewired.Utils.TempListPool/ITListSetter`1<Rewired.ControllerTemplateElementTarget>::SetList(System.Collections.Generic.List`1<T>) */, il2cpp_rgctx_data(method->rgctx_data, 3), (RuntimeObject*)L_26, L_27);
		return L_26;
	}
}
// Rewired.Utils.TempListPool/TList`1<?> Rewired.Utils.TempListPool/TpeBEFhFAWNAsvKKQTVtIrdFUsQw::OlLACmpwoMamrxMTFzLaRnppBEGFA<System.Int32Enum>(System.Collections.Generic.List`1<?>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR TList_1_t91EC4434C71F6E97F426C89A756A7E8D0F090069* TpeBEFhFAWNAsvKKQTVtIrdFUsQw_OlLACmpwoMamrxMTFzLaRnppBEGFA_TisInt32Enum_tCBAC8BA2BFF3A845FA599F303093BBBA374B6F0C_m367FAB5997343ECE6DE4E93FF624C27132D42877_gshared (List_1_tDA4D291C60B1EFA9EA50BBA3367C657CC9410576* p0, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ADictionary_2_Add_m0B52951B53E7F35DD40A3E9D2435F6A9921FEAD6_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ADictionary_2_ContainsKey_mC5ADB925423D250073B9A2A62A2534AB23B21A0F_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ADictionary_2_get_Item_m16DA44C3730BB63327BFAF65D10C028CA7CD13E3_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_RemoveAt_m54F62297ADEE4D4FDA697F49ED807BF901201B54_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1__ctor_m76CBBC3E2F0583F5AD30CE592CEA1225C06A0428_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_get_Count_m4407E4C389F22B8CEC282C15D56516658746C383_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_get_Item_m33561245D64798C2AB07584C0EC4F240E4839A38_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Type_t_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D* V_0 = NULL;
	int32_t V_1 = 0;
	{
		List_1_tDA4D291C60B1EFA9EA50BBA3367C657CC9410576* L_0 = p0;
		if (L_0)
		{
			goto IL_000e;
		}
	}
	{
		ArgumentNullException_t327031E412FAB2351B0022DD5DAD47E67E597129* L_1 = (ArgumentNullException_t327031E412FAB2351B0022DD5DAD47E67E597129*)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&ArgumentNullException_t327031E412FAB2351B0022DD5DAD47E67E597129_il2cpp_TypeInfo_var)));
		ArgumentNullException__ctor_m444AE141157E333844FC1A9500224C2F9FD24F4B(L_1, ((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteral5AC64F41AC098111BD52F434F0C2E60A4F2DE3BC)), /*hidden argument*/NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_1, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&TpeBEFhFAWNAsvKKQTVtIrdFUsQw_OlLACmpwoMamrxMTFzLaRnppBEGFA_TisInt32Enum_tCBAC8BA2BFF3A845FA599F303093BBBA374B6F0C_m367FAB5997343ECE6DE4E93FF624C27132D42877_RuntimeMethod_var)));
	}

IL_000e:
	{
		ADictionary_2_tE212D15054E58919DA98BE219858633B9BBE9C90* L_2;
		L_2 = TpeBEFhFAWNAsvKKQTVtIrdFUsQw_HPGleOOgRvXHtYsMXGTEsiryvtWs_m957491260AFBA8FB32FBC5DE4209106675FFB34C(NULL);
		RuntimeTypeHandle_t332A452B8B6179E4469B69525D0FE82A88030F7B L_3 = { reinterpret_cast<intptr_t> (il2cpp_rgctx_type(method->rgctx_data, 0)) };
		il2cpp_codegen_runtime_class_init_inline(Type_t_il2cpp_TypeInfo_var);
		Type_t* L_4;
		L_4 = Type_GetTypeFromHandle_m2570A2A5B32A5E9D9F0F38B37459DA18736C823E(L_3, NULL);
		NullCheck(L_2);
		bool L_5;
		L_5 = ADictionary_2_ContainsKey_mC5ADB925423D250073B9A2A62A2534AB23B21A0F(L_2, L_4, ADictionary_2_ContainsKey_mC5ADB925423D250073B9A2A62A2534AB23B21A0F_RuntimeMethod_var);
		if (L_5)
		{
			goto IL_003e;
		}
	}
	{
		ADictionary_2_tE212D15054E58919DA98BE219858633B9BBE9C90* L_6;
		L_6 = TpeBEFhFAWNAsvKKQTVtIrdFUsQw_HPGleOOgRvXHtYsMXGTEsiryvtWs_m957491260AFBA8FB32FBC5DE4209106675FFB34C(NULL);
		RuntimeTypeHandle_t332A452B8B6179E4469B69525D0FE82A88030F7B L_7 = { reinterpret_cast<intptr_t> (il2cpp_rgctx_type(method->rgctx_data, 0)) };
		il2cpp_codegen_runtime_class_init_inline(Type_t_il2cpp_TypeInfo_var);
		Type_t* L_8;
		L_8 = Type_GetTypeFromHandle_m2570A2A5B32A5E9D9F0F38B37459DA18736C823E(L_7, NULL);
		List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D* L_9 = (List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D*)il2cpp_codegen_object_new(List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D_il2cpp_TypeInfo_var);
		List_1__ctor_m76CBBC3E2F0583F5AD30CE592CEA1225C06A0428(L_9, 3, /*hidden argument*/List_1__ctor_m76CBBC3E2F0583F5AD30CE592CEA1225C06A0428_RuntimeMethod_var);
		NullCheck(L_6);
		ADictionary_2_Add_m0B52951B53E7F35DD40A3E9D2435F6A9921FEAD6(L_6, L_8, L_9, ADictionary_2_Add_m0B52951B53E7F35DD40A3E9D2435F6A9921FEAD6_RuntimeMethod_var);
	}

IL_003e:
	{
		ADictionary_2_tE212D15054E58919DA98BE219858633B9BBE9C90* L_10;
		L_10 = TpeBEFhFAWNAsvKKQTVtIrdFUsQw_HPGleOOgRvXHtYsMXGTEsiryvtWs_m957491260AFBA8FB32FBC5DE4209106675FFB34C(NULL);
		RuntimeTypeHandle_t332A452B8B6179E4469B69525D0FE82A88030F7B L_11 = { reinterpret_cast<intptr_t> (il2cpp_rgctx_type(method->rgctx_data, 0)) };
		il2cpp_codegen_runtime_class_init_inline(Type_t_il2cpp_TypeInfo_var);
		Type_t* L_12;
		L_12 = Type_GetTypeFromHandle_m2570A2A5B32A5E9D9F0F38B37459DA18736C823E(L_11, NULL);
		NullCheck(L_10);
		List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D* L_13;
		L_13 = ADictionary_2_get_Item_m16DA44C3730BB63327BFAF65D10C028CA7CD13E3(L_10, L_12, ADictionary_2_get_Item_m16DA44C3730BB63327BFAF65D10C028CA7CD13E3_RuntimeMethod_var);
		V_0 = L_13;
		List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D* L_14 = V_0;
		NullCheck(L_14);
		int32_t L_15;
		L_15 = List_1_get_Count_m4407E4C389F22B8CEC282C15D56516658746C383_inline(L_14, List_1_get_Count_m4407E4C389F22B8CEC282C15D56516658746C383_RuntimeMethod_var);
		if (L_15)
		{
			goto IL_0068;
		}
	}
	{
		TList_1_t91EC4434C71F6E97F426C89A756A7E8D0F090069* L_16;
		L_16 = ((  TList_1_t91EC4434C71F6E97F426C89A756A7E8D0F090069* (*) (const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->rgctx_data, 1)))(il2cpp_rgctx_method(method->rgctx_data, 1));
		TList_1_t91EC4434C71F6E97F426C89A756A7E8D0F090069* L_17 = L_16;
		List_1_tDA4D291C60B1EFA9EA50BBA3367C657CC9410576* L_18 = p0;
		NullCheck((RuntimeObject*)L_17);
		InterfaceActionInvoker1< List_1_tDA4D291C60B1EFA9EA50BBA3367C657CC9410576* >::Invoke(0 /* System.Void Rewired.Utils.TempListPool/ITListSetter`1<System.Int32Enum>::SetList(System.Collections.Generic.List`1<T>) */, il2cpp_rgctx_data(method->rgctx_data, 3), (RuntimeObject*)L_17, L_18);
		return L_17;
	}

IL_0068:
	{
		List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D* L_19 = V_0;
		NullCheck(L_19);
		int32_t L_20;
		L_20 = List_1_get_Count_m4407E4C389F22B8CEC282C15D56516658746C383_inline(L_19, List_1_get_Count_m4407E4C389F22B8CEC282C15D56516658746C383_RuntimeMethod_var);
		V_1 = ((int32_t)il2cpp_codegen_subtract(L_20, 1));
		List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D* L_21 = V_0;
		int32_t L_22 = V_1;
		NullCheck(L_21);
		RuntimeObject* L_23;
		L_23 = List_1_get_Item_m33561245D64798C2AB07584C0EC4F240E4839A38(L_21, L_22, List_1_get_Item_m33561245D64798C2AB07584C0EC4F240E4839A38_RuntimeMethod_var);
		List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D* L_24 = V_0;
		int32_t L_25 = V_1;
		NullCheck(L_24);
		List_1_RemoveAt_m54F62297ADEE4D4FDA697F49ED807BF901201B54(L_24, L_25, List_1_RemoveAt_m54F62297ADEE4D4FDA697F49ED807BF901201B54_RuntimeMethod_var);
		TList_1_t91EC4434C71F6E97F426C89A756A7E8D0F090069* L_26 = ((TList_1_t91EC4434C71F6E97F426C89A756A7E8D0F090069*)IsInstSealed((RuntimeObject*)L_23, il2cpp_rgctx_data(method->rgctx_data, 5)));
		List_1_tDA4D291C60B1EFA9EA50BBA3367C657CC9410576* L_27 = p0;
		NullCheck((RuntimeObject*)L_26);
		InterfaceActionInvoker1< List_1_tDA4D291C60B1EFA9EA50BBA3367C657CC9410576* >::Invoke(0 /* System.Void Rewired.Utils.TempListPool/ITListSetter`1<System.Int32Enum>::SetList(System.Collections.Generic.List`1<T>) */, il2cpp_rgctx_data(method->rgctx_data, 3), (RuntimeObject*)L_26, L_27);
		return L_26;
	}
}
// Rewired.Utils.TempListPool/TList`1<?> Rewired.Utils.TempListPool/TpeBEFhFAWNAsvKKQTVtIrdFUsQw::OlLACmpwoMamrxMTFzLaRnppBEGFA<System.Object>(System.Collections.Generic.List`1<?>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR TList_1_t5EEB5351D4D3485884B025F946B9EB1B39C163F7* TpeBEFhFAWNAsvKKQTVtIrdFUsQw_OlLACmpwoMamrxMTFzLaRnppBEGFA_TisRuntimeObject_mC8479E090ED307F17BAE844DE2C29FE904E56C5B_gshared (List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D* p0, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ADictionary_2_Add_m0B52951B53E7F35DD40A3E9D2435F6A9921FEAD6_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ADictionary_2_ContainsKey_mC5ADB925423D250073B9A2A62A2534AB23B21A0F_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ADictionary_2_get_Item_m16DA44C3730BB63327BFAF65D10C028CA7CD13E3_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_RemoveAt_m54F62297ADEE4D4FDA697F49ED807BF901201B54_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1__ctor_m76CBBC3E2F0583F5AD30CE592CEA1225C06A0428_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_get_Count_m4407E4C389F22B8CEC282C15D56516658746C383_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_get_Item_m33561245D64798C2AB07584C0EC4F240E4839A38_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Type_t_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D* V_0 = NULL;
	int32_t V_1 = 0;
	{
		List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D* L_0 = p0;
		if (L_0)
		{
			goto IL_000e;
		}
	}
	{
		ArgumentNullException_t327031E412FAB2351B0022DD5DAD47E67E597129* L_1 = (ArgumentNullException_t327031E412FAB2351B0022DD5DAD47E67E597129*)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&ArgumentNullException_t327031E412FAB2351B0022DD5DAD47E67E597129_il2cpp_TypeInfo_var)));
		ArgumentNullException__ctor_m444AE141157E333844FC1A9500224C2F9FD24F4B(L_1, ((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteral5AC64F41AC098111BD52F434F0C2E60A4F2DE3BC)), /*hidden argument*/NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_1, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&TpeBEFhFAWNAsvKKQTVtIrdFUsQw_OlLACmpwoMamrxMTFzLaRnppBEGFA_TisRuntimeObject_mC8479E090ED307F17BAE844DE2C29FE904E56C5B_RuntimeMethod_var)));
	}

IL_000e:
	{
		ADictionary_2_tE212D15054E58919DA98BE219858633B9BBE9C90* L_2;
		L_2 = TpeBEFhFAWNAsvKKQTVtIrdFUsQw_HPGleOOgRvXHtYsMXGTEsiryvtWs_m957491260AFBA8FB32FBC5DE4209106675FFB34C(NULL);
		RuntimeTypeHandle_t332A452B8B6179E4469B69525D0FE82A88030F7B L_3 = { reinterpret_cast<intptr_t> (il2cpp_rgctx_type(method->rgctx_data, 0)) };
		il2cpp_codegen_runtime_class_init_inline(Type_t_il2cpp_TypeInfo_var);
		Type_t* L_4;
		L_4 = Type_GetTypeFromHandle_m2570A2A5B32A5E9D9F0F38B37459DA18736C823E(L_3, NULL);
		NullCheck(L_2);
		bool L_5;
		L_5 = ADictionary_2_ContainsKey_mC5ADB925423D250073B9A2A62A2534AB23B21A0F(L_2, L_4, ADictionary_2_ContainsKey_mC5ADB925423D250073B9A2A62A2534AB23B21A0F_RuntimeMethod_var);
		if (L_5)
		{
			goto IL_003e;
		}
	}
	{
		ADictionary_2_tE212D15054E58919DA98BE219858633B9BBE9C90* L_6;
		L_6 = TpeBEFhFAWNAsvKKQTVtIrdFUsQw_HPGleOOgRvXHtYsMXGTEsiryvtWs_m957491260AFBA8FB32FBC5DE4209106675FFB34C(NULL);
		RuntimeTypeHandle_t332A452B8B6179E4469B69525D0FE82A88030F7B L_7 = { reinterpret_cast<intptr_t> (il2cpp_rgctx_type(method->rgctx_data, 0)) };
		il2cpp_codegen_runtime_class_init_inline(Type_t_il2cpp_TypeInfo_var);
		Type_t* L_8;
		L_8 = Type_GetTypeFromHandle_m2570A2A5B32A5E9D9F0F38B37459DA18736C823E(L_7, NULL);
		List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D* L_9 = (List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D*)il2cpp_codegen_object_new(List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D_il2cpp_TypeInfo_var);
		List_1__ctor_m76CBBC3E2F0583F5AD30CE592CEA1225C06A0428(L_9, 3, /*hidden argument*/List_1__ctor_m76CBBC3E2F0583F5AD30CE592CEA1225C06A0428_RuntimeMethod_var);
		NullCheck(L_6);
		ADictionary_2_Add_m0B52951B53E7F35DD40A3E9D2435F6A9921FEAD6(L_6, L_8, L_9, ADictionary_2_Add_m0B52951B53E7F35DD40A3E9D2435F6A9921FEAD6_RuntimeMethod_var);
	}

IL_003e:
	{
		ADictionary_2_tE212D15054E58919DA98BE219858633B9BBE9C90* L_10;
		L_10 = TpeBEFhFAWNAsvKKQTVtIrdFUsQw_HPGleOOgRvXHtYsMXGTEsiryvtWs_m957491260AFBA8FB32FBC5DE4209106675FFB34C(NULL);
		RuntimeTypeHandle_t332A452B8B6179E4469B69525D0FE82A88030F7B L_11 = { reinterpret_cast<intptr_t> (il2cpp_rgctx_type(method->rgctx_data, 0)) };
		il2cpp_codegen_runtime_class_init_inline(Type_t_il2cpp_TypeInfo_var);
		Type_t* L_12;
		L_12 = Type_GetTypeFromHandle_m2570A2A5B32A5E9D9F0F38B37459DA18736C823E(L_11, NULL);
		NullCheck(L_10);
		List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D* L_13;
		L_13 = ADictionary_2_get_Item_m16DA44C3730BB63327BFAF65D10C028CA7CD13E3(L_10, L_12, ADictionary_2_get_Item_m16DA44C3730BB63327BFAF65D10C028CA7CD13E3_RuntimeMethod_var);
		V_0 = L_13;
		List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D* L_14 = V_0;
		NullCheck(L_14);
		int32_t L_15;
		L_15 = List_1_get_Count_m4407E4C389F22B8CEC282C15D56516658746C383_inline(L_14, List_1_get_Count_m4407E4C389F22B8CEC282C15D56516658746C383_RuntimeMethod_var);
		if (L_15)
		{
			goto IL_0068;
		}
	}
	{
		TList_1_t5EEB5351D4D3485884B025F946B9EB1B39C163F7* L_16;
		L_16 = ((  TList_1_t5EEB5351D4D3485884B025F946B9EB1B39C163F7* (*) (const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->rgctx_data, 1)))(il2cpp_rgctx_method(method->rgctx_data, 1));
		TList_1_t5EEB5351D4D3485884B025F946B9EB1B39C163F7* L_17 = L_16;
		List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D* L_18 = p0;
		NullCheck((RuntimeObject*)L_17);
		InterfaceActionInvoker1< List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D* >::Invoke(0 /* System.Void Rewired.Utils.TempListPool/ITListSetter`1<System.Object>::SetList(System.Collections.Generic.List`1<T>) */, il2cpp_rgctx_data(method->rgctx_data, 3), (RuntimeObject*)L_17, L_18);
		return L_17;
	}

IL_0068:
	{
		List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D* L_19 = V_0;
		NullCheck(L_19);
		int32_t L_20;
		L_20 = List_1_get_Count_m4407E4C389F22B8CEC282C15D56516658746C383_inline(L_19, List_1_get_Count_m4407E4C389F22B8CEC282C15D56516658746C383_RuntimeMethod_var);
		V_1 = ((int32_t)il2cpp_codegen_subtract(L_20, 1));
		List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D* L_21 = V_0;
		int32_t L_22 = V_1;
		NullCheck(L_21);
		RuntimeObject* L_23;
		L_23 = List_1_get_Item_m33561245D64798C2AB07584C0EC4F240E4839A38(L_21, L_22, List_1_get_Item_m33561245D64798C2AB07584C0EC4F240E4839A38_RuntimeMethod_var);
		List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D* L_24 = V_0;
		int32_t L_25 = V_1;
		NullCheck(L_24);
		List_1_RemoveAt_m54F62297ADEE4D4FDA697F49ED807BF901201B54(L_24, L_25, List_1_RemoveAt_m54F62297ADEE4D4FDA697F49ED807BF901201B54_RuntimeMethod_var);
		TList_1_t5EEB5351D4D3485884B025F946B9EB1B39C163F7* L_26 = ((TList_1_t5EEB5351D4D3485884B025F946B9EB1B39C163F7*)IsInstSealed((RuntimeObject*)L_23, il2cpp_rgctx_data(method->rgctx_data, 5)));
		List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D* L_27 = p0;
		NullCheck((RuntimeObject*)L_26);
		InterfaceActionInvoker1< List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D* >::Invoke(0 /* System.Void Rewired.Utils.TempListPool/ITListSetter`1<System.Object>::SetList(System.Collections.Generic.List`1<T>) */, il2cpp_rgctx_data(method->rgctx_data, 3), (RuntimeObject*)L_26, L_27);
		return L_26;
	}
}
// System.Void Rewired.Utils.TempListPool/TpeBEFhFAWNAsvKKQTVtIrdFUsQw::hFfgKgidBhpsyheEnoFheSvsHLRGA<Rewired.ControllerTemplateElementTarget>(Rewired.Utils.TempListPool/TList`1<?>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TpeBEFhFAWNAsvKKQTVtIrdFUsQw_hFfgKgidBhpsyheEnoFheSvsHLRGA_TisControllerTemplateElementTarget_tDB0CB7A22A83FD188DBBB27A7D75DD3459D5542C_m803B93CA19C24BF6852BFD78C75A0EFCA23B440E_gshared (TList_1_t08828BE7F5A36A1F8E5542F3DE822A03B4E625D7* p0, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ADictionary_2_Add_m0B52951B53E7F35DD40A3E9D2435F6A9921FEAD6_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ADictionary_2_TryGetValue_mF116A47D7285E8974FA1C99B2650B697DFD56A55_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ListTools_AddIfUnique_TisRuntimeObject_m1FC233E73FB0BCD08B759B78473378745A884A81_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1__ctor_m76CBBC3E2F0583F5AD30CE592CEA1225C06A0428_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_get_Count_m4407E4C389F22B8CEC282C15D56516658746C383_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Type_t_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D* V_0 = NULL;
	{
		TList_1_t08828BE7F5A36A1F8E5542F3DE822A03B4E625D7* L_0 = p0;
		if (L_0)
		{
			goto IL_0004;
		}
	}
	{
		return;
	}

IL_0004:
	{
		ADictionary_2_tE212D15054E58919DA98BE219858633B9BBE9C90* L_1;
		L_1 = TpeBEFhFAWNAsvKKQTVtIrdFUsQw_HPGleOOgRvXHtYsMXGTEsiryvtWs_m957491260AFBA8FB32FBC5DE4209106675FFB34C(NULL);
		RuntimeTypeHandle_t332A452B8B6179E4469B69525D0FE82A88030F7B L_2 = { reinterpret_cast<intptr_t> (il2cpp_rgctx_type(method->rgctx_data, 0)) };
		il2cpp_codegen_runtime_class_init_inline(Type_t_il2cpp_TypeInfo_var);
		Type_t* L_3;
		L_3 = Type_GetTypeFromHandle_m2570A2A5B32A5E9D9F0F38B37459DA18736C823E(L_2, NULL);
		NullCheck(L_1);
		bool L_4;
		L_4 = ADictionary_2_TryGetValue_mF116A47D7285E8974FA1C99B2650B697DFD56A55(L_1, L_3, (&V_0), ADictionary_2_TryGetValue_mF116A47D7285E8974FA1C99B2650B697DFD56A55_RuntimeMethod_var);
		if (L_4)
		{
			goto IL_0038;
		}
	}
	{
		List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D* L_5 = (List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D*)il2cpp_codegen_object_new(List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D_il2cpp_TypeInfo_var);
		List_1__ctor_m76CBBC3E2F0583F5AD30CE592CEA1225C06A0428(L_5, 3, /*hidden argument*/List_1__ctor_m76CBBC3E2F0583F5AD30CE592CEA1225C06A0428_RuntimeMethod_var);
		V_0 = L_5;
		ADictionary_2_tE212D15054E58919DA98BE219858633B9BBE9C90* L_6;
		L_6 = TpeBEFhFAWNAsvKKQTVtIrdFUsQw_HPGleOOgRvXHtYsMXGTEsiryvtWs_m957491260AFBA8FB32FBC5DE4209106675FFB34C(NULL);
		RuntimeTypeHandle_t332A452B8B6179E4469B69525D0FE82A88030F7B L_7 = { reinterpret_cast<intptr_t> (il2cpp_rgctx_type(method->rgctx_data, 0)) };
		il2cpp_codegen_runtime_class_init_inline(Type_t_il2cpp_TypeInfo_var);
		Type_t* L_8;
		L_8 = Type_GetTypeFromHandle_m2570A2A5B32A5E9D9F0F38B37459DA18736C823E(L_7, NULL);
		List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D* L_9 = V_0;
		NullCheck(L_6);
		ADictionary_2_Add_m0B52951B53E7F35DD40A3E9D2435F6A9921FEAD6(L_6, L_8, L_9, ADictionary_2_Add_m0B52951B53E7F35DD40A3E9D2435F6A9921FEAD6_RuntimeMethod_var);
	}

IL_0038:
	{
		List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D* L_10 = V_0;
		NullCheck(L_10);
		int32_t L_11;
		L_11 = List_1_get_Count_m4407E4C389F22B8CEC282C15D56516658746C383_inline(L_10, List_1_get_Count_m4407E4C389F22B8CEC282C15D56516658746C383_RuntimeMethod_var);
		if ((((int32_t)L_11) < ((int32_t)3)))
		{
			goto IL_0042;
		}
	}
	{
		return;
	}

IL_0042:
	{
		List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D* L_12 = V_0;
		TList_1_t08828BE7F5A36A1F8E5542F3DE822A03B4E625D7* L_13 = p0;
		bool L_14;
		L_14 = ListTools_AddIfUnique_TisRuntimeObject_m1FC233E73FB0BCD08B759B78473378745A884A81((RuntimeObject*)L_12, (RuntimeObject*)L_13, ListTools_AddIfUnique_TisRuntimeObject_m1FC233E73FB0BCD08B759B78473378745A884A81_RuntimeMethod_var);
		return;
	}
}
// System.Void Rewired.Utils.TempListPool/TpeBEFhFAWNAsvKKQTVtIrdFUsQw::hFfgKgidBhpsyheEnoFheSvsHLRGA<System.Int32Enum>(Rewired.Utils.TempListPool/TList`1<?>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TpeBEFhFAWNAsvKKQTVtIrdFUsQw_hFfgKgidBhpsyheEnoFheSvsHLRGA_TisInt32Enum_tCBAC8BA2BFF3A845FA599F303093BBBA374B6F0C_mBE9C3683EEEDC7754565FAD3D8BF02887DE8958F_gshared (TList_1_t91EC4434C71F6E97F426C89A756A7E8D0F090069* p0, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ADictionary_2_Add_m0B52951B53E7F35DD40A3E9D2435F6A9921FEAD6_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ADictionary_2_TryGetValue_mF116A47D7285E8974FA1C99B2650B697DFD56A55_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ListTools_AddIfUnique_TisRuntimeObject_m1FC233E73FB0BCD08B759B78473378745A884A81_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1__ctor_m76CBBC3E2F0583F5AD30CE592CEA1225C06A0428_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_get_Count_m4407E4C389F22B8CEC282C15D56516658746C383_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Type_t_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D* V_0 = NULL;
	{
		TList_1_t91EC4434C71F6E97F426C89A756A7E8D0F090069* L_0 = p0;
		if (L_0)
		{
			goto IL_0004;
		}
	}
	{
		return;
	}

IL_0004:
	{
		ADictionary_2_tE212D15054E58919DA98BE219858633B9BBE9C90* L_1;
		L_1 = TpeBEFhFAWNAsvKKQTVtIrdFUsQw_HPGleOOgRvXHtYsMXGTEsiryvtWs_m957491260AFBA8FB32FBC5DE4209106675FFB34C(NULL);
		RuntimeTypeHandle_t332A452B8B6179E4469B69525D0FE82A88030F7B L_2 = { reinterpret_cast<intptr_t> (il2cpp_rgctx_type(method->rgctx_data, 0)) };
		il2cpp_codegen_runtime_class_init_inline(Type_t_il2cpp_TypeInfo_var);
		Type_t* L_3;
		L_3 = Type_GetTypeFromHandle_m2570A2A5B32A5E9D9F0F38B37459DA18736C823E(L_2, NULL);
		NullCheck(L_1);
		bool L_4;
		L_4 = ADictionary_2_TryGetValue_mF116A47D7285E8974FA1C99B2650B697DFD56A55(L_1, L_3, (&V_0), ADictionary_2_TryGetValue_mF116A47D7285E8974FA1C99B2650B697DFD56A55_RuntimeMethod_var);
		if (L_4)
		{
			goto IL_0038;
		}
	}
	{
		List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D* L_5 = (List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D*)il2cpp_codegen_object_new(List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D_il2cpp_TypeInfo_var);
		List_1__ctor_m76CBBC3E2F0583F5AD30CE592CEA1225C06A0428(L_5, 3, /*hidden argument*/List_1__ctor_m76CBBC3E2F0583F5AD30CE592CEA1225C06A0428_RuntimeMethod_var);
		V_0 = L_5;
		ADictionary_2_tE212D15054E58919DA98BE219858633B9BBE9C90* L_6;
		L_6 = TpeBEFhFAWNAsvKKQTVtIrdFUsQw_HPGleOOgRvXHtYsMXGTEsiryvtWs_m957491260AFBA8FB32FBC5DE4209106675FFB34C(NULL);
		RuntimeTypeHandle_t332A452B8B6179E4469B69525D0FE82A88030F7B L_7 = { reinterpret_cast<intptr_t> (il2cpp_rgctx_type(method->rgctx_data, 0)) };
		il2cpp_codegen_runtime_class_init_inline(Type_t_il2cpp_TypeInfo_var);
		Type_t* L_8;
		L_8 = Type_GetTypeFromHandle_m2570A2A5B32A5E9D9F0F38B37459DA18736C823E(L_7, NULL);
		List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D* L_9 = V_0;
		NullCheck(L_6);
		ADictionary_2_Add_m0B52951B53E7F35DD40A3E9D2435F6A9921FEAD6(L_6, L_8, L_9, ADictionary_2_Add_m0B52951B53E7F35DD40A3E9D2435F6A9921FEAD6_RuntimeMethod_var);
	}

IL_0038:
	{
		List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D* L_10 = V_0;
		NullCheck(L_10);
		int32_t L_11;
		L_11 = List_1_get_Count_m4407E4C389F22B8CEC282C15D56516658746C383_inline(L_10, List_1_get_Count_m4407E4C389F22B8CEC282C15D56516658746C383_RuntimeMethod_var);
		if ((((int32_t)L_11) < ((int32_t)3)))
		{
			goto IL_0042;
		}
	}
	{
		return;
	}

IL_0042:
	{
		List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D* L_12 = V_0;
		TList_1_t91EC4434C71F6E97F426C89A756A7E8D0F090069* L_13 = p0;
		bool L_14;
		L_14 = ListTools_AddIfUnique_TisRuntimeObject_m1FC233E73FB0BCD08B759B78473378745A884A81((RuntimeObject*)L_12, (RuntimeObject*)L_13, ListTools_AddIfUnique_TisRuntimeObject_m1FC233E73FB0BCD08B759B78473378745A884A81_RuntimeMethod_var);
		return;
	}
}
// System.Void Rewired.Utils.TempListPool/TpeBEFhFAWNAsvKKQTVtIrdFUsQw::hFfgKgidBhpsyheEnoFheSvsHLRGA<System.Object>(Rewired.Utils.TempListPool/TList`1<?>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TpeBEFhFAWNAsvKKQTVtIrdFUsQw_hFfgKgidBhpsyheEnoFheSvsHLRGA_TisRuntimeObject_m3ABAD753F2250411C71B86BC67D2358B58F79D54_gshared (TList_1_t5EEB5351D4D3485884B025F946B9EB1B39C163F7* p0, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ADictionary_2_Add_m0B52951B53E7F35DD40A3E9D2435F6A9921FEAD6_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ADictionary_2_TryGetValue_mF116A47D7285E8974FA1C99B2650B697DFD56A55_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ListTools_AddIfUnique_TisRuntimeObject_m1FC233E73FB0BCD08B759B78473378745A884A81_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1__ctor_m76CBBC3E2F0583F5AD30CE592CEA1225C06A0428_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_get_Count_m4407E4C389F22B8CEC282C15D56516658746C383_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Type_t_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D* V_0 = NULL;
	{
		TList_1_t5EEB5351D4D3485884B025F946B9EB1B39C163F7* L_0 = p0;
		if (L_0)
		{
			goto IL_0004;
		}
	}
	{
		return;
	}

IL_0004:
	{
		ADictionary_2_tE212D15054E58919DA98BE219858633B9BBE9C90* L_1;
		L_1 = TpeBEFhFAWNAsvKKQTVtIrdFUsQw_HPGleOOgRvXHtYsMXGTEsiryvtWs_m957491260AFBA8FB32FBC5DE4209106675FFB34C(NULL);
		RuntimeTypeHandle_t332A452B8B6179E4469B69525D0FE82A88030F7B L_2 = { reinterpret_cast<intptr_t> (il2cpp_rgctx_type(method->rgctx_data, 0)) };
		il2cpp_codegen_runtime_class_init_inline(Type_t_il2cpp_TypeInfo_var);
		Type_t* L_3;
		L_3 = Type_GetTypeFromHandle_m2570A2A5B32A5E9D9F0F38B37459DA18736C823E(L_2, NULL);
		NullCheck(L_1);
		bool L_4;
		L_4 = ADictionary_2_TryGetValue_mF116A47D7285E8974FA1C99B2650B697DFD56A55(L_1, L_3, (&V_0), ADictionary_2_TryGetValue_mF116A47D7285E8974FA1C99B2650B697DFD56A55_RuntimeMethod_var);
		if (L_4)
		{
			goto IL_0038;
		}
	}
	{
		List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D* L_5 = (List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D*)il2cpp_codegen_object_new(List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D_il2cpp_TypeInfo_var);
		List_1__ctor_m76CBBC3E2F0583F5AD30CE592CEA1225C06A0428(L_5, 3, /*hidden argument*/List_1__ctor_m76CBBC3E2F0583F5AD30CE592CEA1225C06A0428_RuntimeMethod_var);
		V_0 = L_5;
		ADictionary_2_tE212D15054E58919DA98BE219858633B9BBE9C90* L_6;
		L_6 = TpeBEFhFAWNAsvKKQTVtIrdFUsQw_HPGleOOgRvXHtYsMXGTEsiryvtWs_m957491260AFBA8FB32FBC5DE4209106675FFB34C(NULL);
		RuntimeTypeHandle_t332A452B8B6179E4469B69525D0FE82A88030F7B L_7 = { reinterpret_cast<intptr_t> (il2cpp_rgctx_type(method->rgctx_data, 0)) };
		il2cpp_codegen_runtime_class_init_inline(Type_t_il2cpp_TypeInfo_var);
		Type_t* L_8;
		L_8 = Type_GetTypeFromHandle_m2570A2A5B32A5E9D9F0F38B37459DA18736C823E(L_7, NULL);
		List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D* L_9 = V_0;
		NullCheck(L_6);
		ADictionary_2_Add_m0B52951B53E7F35DD40A3E9D2435F6A9921FEAD6(L_6, L_8, L_9, ADictionary_2_Add_m0B52951B53E7F35DD40A3E9D2435F6A9921FEAD6_RuntimeMethod_var);
	}

IL_0038:
	{
		List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D* L_10 = V_0;
		NullCheck(L_10);
		int32_t L_11;
		L_11 = List_1_get_Count_m4407E4C389F22B8CEC282C15D56516658746C383_inline(L_10, List_1_get_Count_m4407E4C389F22B8CEC282C15D56516658746C383_RuntimeMethod_var);
		if ((((int32_t)L_11) < ((int32_t)3)))
		{
			goto IL_0042;
		}
	}
	{
		return;
	}

IL_0042:
	{
		List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D* L_12 = V_0;
		TList_1_t5EEB5351D4D3485884B025F946B9EB1B39C163F7* L_13 = p0;
		bool L_14;
		L_14 = ListTools_AddIfUnique_TisRuntimeObject_m1FC233E73FB0BCD08B759B78473378745A884A81((RuntimeObject*)L_12, (RuntimeObject*)L_13, ListTools_AddIfUnique_TisRuntimeObject_m1FC233E73FB0BCD08B759B78473378745A884A81_RuntimeMethod_var);
		return;
	}
}
// System.Void Rewired.Data.UserData/PMmfElSRTHipvrooOqnrsVzyuehD::PlGykcohZgSWLRBrICBpjzSbvblvA<System.Object>(System.String,System.Collections.Generic.IList`1<?>,System.Collections.Generic.IList`1<?>,System.Collections.Generic.IList`1<?>,System.Boolean,System.Collections.Generic.List`1<Rewired.Data.UserData/PMmfElSRTHipvrooOqnrsVzyuehD/kzedFdEdISaCJppRVzkSmhYBfiDK>,System.Func`2<?,System.Int32>,System.Func`2<?,System.String>,System.Func`3<?,System.Collections.Generic.IList`1<?>,System.Int32>,System.Func`2<Rewired.Data.UserData/PMmfElSRTHipvrooOqnrsVzyuehD/cTlcZwgBmjmwQjxeEhJdCJOLqDjC`1<?>,?>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void PMmfElSRTHipvrooOqnrsVzyuehD_PlGykcohZgSWLRBrICBpjzSbvblvA_TisRuntimeObject_mDA24E72ED2DA5CB19EB022461C0DD7EFBB22A9B4_gshared (String_t* p0, RuntimeObject* p1, RuntimeObject* p2, RuntimeObject* p3, bool p4, List_1_t2371DBA2BC5BA5E401A3796013E23F6AA5DE82E7* p5, Func_2_t9A0D493A82DCC47C9C819A3B045E02D9B5DDCE1B* p6, Func_2_t8A4E59735D50CEA34C30F6CD6B5804A38327CD0B* p7, Func_3_tA2EC68432F49E8DB1FC81E592EA4A30855D5EE0E* p8, Func_2_t47FA43C06CA3B7E69EECC5B0C6D36F44AADCB758* p9, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_Add_mEBA4A42D074F0BFA59336506E8E0639669B309DD_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_Find_m412DFD00E7077EF26A7689218DBB67CFEBBAA57D_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Predicate_1__ctor_mC7ED0FD7569E0ACBA4AA0C7D8592AADCFA28A8EA_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Predicate_1_t0AE34D834A58115AD4CD9532C7FEAF28A2A18674_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral18671CD5DECD4AF4B7DF2AA0F1A0C1E4DE25F8AB);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral22B1478CDF9C226208AE289896781AF22519D6CB);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral2386E77CF610F786B06A91AF2C1B3FD2282D2745);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralC62C64F00567C5368CAE37F4E64E1E82FF785677);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralDA39A3EE5E6B4B0D3255BFEF95601890AFD80709);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralF3E84B722399601AD7E281754E917478AA9AD48D);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&kzedFdEdISaCJppRVzkSmhYBfiDK_t96C908773E13D2FD31BFC3C0BC59CD2D7B31233D_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
aKSDPjRJZQzZwYkmoXKHoOMDFOWe_1_tBF7584EF632A787EC6F2057BA1C49894E7E22FCA* V_0 = NULL;
	int32_t V_1 = 0;
	RuntimeObject* V_2 = NULL;
	RuntimeObject* V_3 = NULL;
	RuntimeObject* V_4 = NULL;
	int32_t V_5 = 0;
	RuntimeObject* V_6 = NULL;
	int32_t V_7 = 0;
	sQEkcZUofLSdEALOSOuyKPdNiQEDA_1_t1B5CB90AB9525321551E427D7C2054C85C37AAC1* V_8 = NULL;
	RuntimeObject* V_9 = NULL;
	String_t* V_10 = NULL;
	RuntimeObject* V_11 = NULL;
	String_t* V_12 = NULL;
	String_t* G_B12_0 = NULL;
	String_t* G_B14_0 = NULL;
	String_t* G_B13_0 = NULL;
	String_t* G_B15_0 = NULL;
	String_t* G_B15_1 = NULL;
	String_t* G_B19_0 = NULL;
	String_t* G_B21_0 = NULL;
	String_t* G_B21_1 = NULL;
	String_t* G_B20_0 = NULL;
	String_t* G_B20_1 = NULL;
	String_t* G_B22_0 = NULL;
	String_t* G_B22_1 = NULL;
	String_t* G_B22_2 = NULL;
	{
		aKSDPjRJZQzZwYkmoXKHoOMDFOWe_1_tBF7584EF632A787EC6F2057BA1C49894E7E22FCA* L_0 = (aKSDPjRJZQzZwYkmoXKHoOMDFOWe_1_tBF7584EF632A787EC6F2057BA1C49894E7E22FCA*)il2cpp_codegen_object_new(il2cpp_rgctx_data(method->rgctx_data, 0));
		aKSDPjRJZQzZwYkmoXKHoOMDFOWe_1__ctor_m85F258D1E7D7A4BE9D3B8F13453BC940F7D38D16(L_0, /*hidden argument*/il2cpp_rgctx_method(method->rgctx_data, 1));
		V_0 = L_0;
		aKSDPjRJZQzZwYkmoXKHoOMDFOWe_1_tBF7584EF632A787EC6F2057BA1C49894E7E22FCA* L_1 = V_0;
		Func_2_t9A0D493A82DCC47C9C819A3B045E02D9B5DDCE1B* L_2 = p6;
		NullCheck(L_1);
		L_1->___FkKDhjApMORrhuHhObhaCvDMkiLpA_0 = L_2;
		Il2CppCodeGenWriteBarrier((void**)(&L_1->___FkKDhjApMORrhuHhObhaCvDMkiLpA_0), (void*)L_2);
		V_1 = 0;
		goto IL_0089;
	}

IL_0012:
	{
		RuntimeObject* L_3 = p1;
		int32_t L_4 = V_1;
		NullCheck(L_3);
		RuntimeObject* L_5;
		L_5 = InterfaceFuncInvoker1< RuntimeObject*, int32_t >::Invoke(0 /* T System.Collections.Generic.IList`1<System.Object>::get_Item(System.Int32) */, il2cpp_rgctx_data(method->rgctx_data, 2), L_3, L_4);
		V_2 = L_5;
		bool L_6 = p4;
		if (!L_6)
		{
			goto IL_0045;
		}
	}
	{
		List_1_t2371DBA2BC5BA5E401A3796013E23F6AA5DE82E7* L_7 = p5;
		aKSDPjRJZQzZwYkmoXKHoOMDFOWe_1_tBF7584EF632A787EC6F2057BA1C49894E7E22FCA* L_8 = V_0;
		NullCheck(L_8);
		Func_2_t9A0D493A82DCC47C9C819A3B045E02D9B5DDCE1B* L_9 = (Func_2_t9A0D493A82DCC47C9C819A3B045E02D9B5DDCE1B*)L_8->___FkKDhjApMORrhuHhObhaCvDMkiLpA_0;
		RuntimeObject* L_10 = V_2;
		NullCheck(L_9);
		int32_t L_11;
		L_11 = ((  int32_t (*) (Func_2_t9A0D493A82DCC47C9C819A3B045E02D9B5DDCE1B*, RuntimeObject*, const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->rgctx_data, 5)))(L_9, L_10, il2cpp_rgctx_method(method->rgctx_data, 5));
		aKSDPjRJZQzZwYkmoXKHoOMDFOWe_1_tBF7584EF632A787EC6F2057BA1C49894E7E22FCA* L_12 = V_0;
		NullCheck(L_12);
		Func_2_t9A0D493A82DCC47C9C819A3B045E02D9B5DDCE1B* L_13 = (Func_2_t9A0D493A82DCC47C9C819A3B045E02D9B5DDCE1B*)L_12->___FkKDhjApMORrhuHhObhaCvDMkiLpA_0;
		RuntimeObject* L_14 = V_2;
		NullCheck(L_13);
		int32_t L_15;
		L_15 = ((  int32_t (*) (Func_2_t9A0D493A82DCC47C9C819A3B045E02D9B5DDCE1B*, RuntimeObject*, const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->rgctx_data, 5)))(L_13, L_14, il2cpp_rgctx_method(method->rgctx_data, 5));
		kzedFdEdISaCJppRVzkSmhYBfiDK_t96C908773E13D2FD31BFC3C0BC59CD2D7B31233D* L_16 = (kzedFdEdISaCJppRVzkSmhYBfiDK_t96C908773E13D2FD31BFC3C0BC59CD2D7B31233D*)il2cpp_codegen_object_new(kzedFdEdISaCJppRVzkSmhYBfiDK_t96C908773E13D2FD31BFC3C0BC59CD2D7B31233D_il2cpp_TypeInfo_var);
		kzedFdEdISaCJppRVzkSmhYBfiDK__ctor_mCECC0F8AC7218CE1ED3AB6E85EC8C0FC5BCA8564(L_16, L_11, (-1), L_15, /*hidden argument*/NULL);
		NullCheck(L_7);
		List_1_Add_mEBA4A42D074F0BFA59336506E8E0639669B309DD_inline(L_7, L_16, List_1_Add_mEBA4A42D074F0BFA59336506E8E0639669B309DD_RuntimeMethod_var);
		goto IL_0085;
	}

IL_0045:
	{
		Func_2_t47FA43C06CA3B7E69EECC5B0C6D36F44AADCB758* L_17 = p9;
		RuntimeObject* L_18 = V_2;
		il2cpp_codegen_initobj((&V_4), sizeof(RuntimeObject*));
		RuntimeObject* L_19 = V_4;
		RuntimeObject* L_20 = p3;
		cTlcZwgBmjmwQjxeEhJdCJOLqDjC_1_t00DEF10DFB18F406646ED696288655ED53671B85* L_21 = (cTlcZwgBmjmwQjxeEhJdCJOLqDjC_1_t00DEF10DFB18F406646ED696288655ED53671B85*)il2cpp_codegen_object_new(il2cpp_rgctx_data(method->rgctx_data, 6));
		cTlcZwgBmjmwQjxeEhJdCJOLqDjC_1__ctor_m2660924875158C34CA727FFC10FA37C6C7C14D90(L_21, L_18, L_19, (int32_t)0, L_20, (bool)0, /*hidden argument*/il2cpp_rgctx_method(method->rgctx_data, 7));
		NullCheck(L_17);
		RuntimeObject* L_22;
		L_22 = ((  RuntimeObject* (*) (Func_2_t47FA43C06CA3B7E69EECC5B0C6D36F44AADCB758*, cTlcZwgBmjmwQjxeEhJdCJOLqDjC_1_t00DEF10DFB18F406646ED696288655ED53671B85*, const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->rgctx_data, 9)))(L_17, L_21, il2cpp_rgctx_method(method->rgctx_data, 9));
		V_3 = L_22;
		List_1_t2371DBA2BC5BA5E401A3796013E23F6AA5DE82E7* L_23 = p5;
		aKSDPjRJZQzZwYkmoXKHoOMDFOWe_1_tBF7584EF632A787EC6F2057BA1C49894E7E22FCA* L_24 = V_0;
		NullCheck(L_24);
		Func_2_t9A0D493A82DCC47C9C819A3B045E02D9B5DDCE1B* L_25 = (Func_2_t9A0D493A82DCC47C9C819A3B045E02D9B5DDCE1B*)L_24->___FkKDhjApMORrhuHhObhaCvDMkiLpA_0;
		RuntimeObject* L_26 = V_2;
		NullCheck(L_25);
		int32_t L_27;
		L_27 = ((  int32_t (*) (Func_2_t9A0D493A82DCC47C9C819A3B045E02D9B5DDCE1B*, RuntimeObject*, const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->rgctx_data, 5)))(L_25, L_26, il2cpp_rgctx_method(method->rgctx_data, 5));
		aKSDPjRJZQzZwYkmoXKHoOMDFOWe_1_tBF7584EF632A787EC6F2057BA1C49894E7E22FCA* L_28 = V_0;
		NullCheck(L_28);
		Func_2_t9A0D493A82DCC47C9C819A3B045E02D9B5DDCE1B* L_29 = (Func_2_t9A0D493A82DCC47C9C819A3B045E02D9B5DDCE1B*)L_28->___FkKDhjApMORrhuHhObhaCvDMkiLpA_0;
		RuntimeObject* L_30 = V_3;
		NullCheck(L_29);
		int32_t L_31;
		L_31 = ((  int32_t (*) (Func_2_t9A0D493A82DCC47C9C819A3B045E02D9B5DDCE1B*, RuntimeObject*, const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->rgctx_data, 5)))(L_29, L_30, il2cpp_rgctx_method(method->rgctx_data, 5));
		kzedFdEdISaCJppRVzkSmhYBfiDK_t96C908773E13D2FD31BFC3C0BC59CD2D7B31233D* L_32 = (kzedFdEdISaCJppRVzkSmhYBfiDK_t96C908773E13D2FD31BFC3C0BC59CD2D7B31233D*)il2cpp_codegen_object_new(kzedFdEdISaCJppRVzkSmhYBfiDK_t96C908773E13D2FD31BFC3C0BC59CD2D7B31233D_il2cpp_TypeInfo_var);
		kzedFdEdISaCJppRVzkSmhYBfiDK__ctor_mCECC0F8AC7218CE1ED3AB6E85EC8C0FC5BCA8564(L_32, L_27, (-1), L_31, /*hidden argument*/NULL);
		NullCheck(L_23);
		List_1_Add_mEBA4A42D074F0BFA59336506E8E0639669B309DD_inline(L_23, L_32, List_1_Add_mEBA4A42D074F0BFA59336506E8E0639669B309DD_RuntimeMethod_var);
	}

IL_0085:
	{
		int32_t L_33 = V_1;
		V_1 = ((int32_t)il2cpp_codegen_add(L_33, 1));
	}

IL_0089:
	{
		int32_t L_34 = V_1;
		RuntimeObject* L_35 = p1;
		NullCheck((RuntimeObject*)L_35);
		int32_t L_36;
		L_36 = InterfaceFuncInvoker0< int32_t >::Invoke(0 /* System.Int32 System.Collections.Generic.ICollection`1<System.Object>::get_Count() */, il2cpp_rgctx_data(method->rgctx_data, 10), (RuntimeObject*)L_35);
		if ((((int32_t)L_34) < ((int32_t)L_36)))
		{
			goto IL_0012;
		}
	}
	{
		RuntimeObject* L_37 = p2;
		if (!L_37)
		{
			goto IL_0238;
		}
	}
	{
		V_5 = 0;
		goto IL_022b;
	}

IL_00a0:
	{
		RuntimeObject* L_38 = p2;
		int32_t L_39 = V_5;
		NullCheck(L_38);
		RuntimeObject* L_40;
		L_40 = InterfaceFuncInvoker1< RuntimeObject*, int32_t >::Invoke(0 /* T System.Collections.Generic.IList`1<System.Object>::get_Item(System.Int32) */, il2cpp_rgctx_data(method->rgctx_data, 2), L_38, L_39);
		V_6 = L_40;
		Func_3_tA2EC68432F49E8DB1FC81E592EA4A30855D5EE0E* L_41 = p8;
		RuntimeObject* L_42 = V_6;
		RuntimeObject* L_43 = p3;
		NullCheck(L_41);
		int32_t L_44;
		L_44 = ((  int32_t (*) (Func_3_tA2EC68432F49E8DB1FC81E592EA4A30855D5EE0E*, RuntimeObject*, RuntimeObject*, const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->rgctx_data, 13)))(L_41, L_42, L_43, il2cpp_rgctx_method(method->rgctx_data, 13));
		V_7 = L_44;
		int32_t L_45 = V_7;
		if ((((int32_t)L_45) < ((int32_t)0)))
		{
			goto IL_017f;
		}
	}
	{
		sQEkcZUofLSdEALOSOuyKPdNiQEDA_1_t1B5CB90AB9525321551E427D7C2054C85C37AAC1* L_46 = (sQEkcZUofLSdEALOSOuyKPdNiQEDA_1_t1B5CB90AB9525321551E427D7C2054C85C37AAC1*)il2cpp_codegen_object_new(il2cpp_rgctx_data(method->rgctx_data, 14));
		sQEkcZUofLSdEALOSOuyKPdNiQEDA_1__ctor_m22DB3A340E2C132D9FC9F965583E016FD9F40992(L_46, /*hidden argument*/il2cpp_rgctx_method(method->rgctx_data, 15));
		V_8 = L_46;
		sQEkcZUofLSdEALOSOuyKPdNiQEDA_1_t1B5CB90AB9525321551E427D7C2054C85C37AAC1* L_47 = V_8;
		aKSDPjRJZQzZwYkmoXKHoOMDFOWe_1_tBF7584EF632A787EC6F2057BA1C49894E7E22FCA* L_48 = V_0;
		NullCheck(L_47);
		L_47->___GzKJJorOLWrdrMiTQiKLkIMQBqcb_1 = L_48;
		Il2CppCodeGenWriteBarrier((void**)(&L_47->___GzKJJorOLWrdrMiTQiKLkIMQBqcb_1), (void*)L_48);
		RuntimeObject* L_49 = p3;
		int32_t L_50 = V_7;
		NullCheck(L_49);
		RuntimeObject* L_51;
		L_51 = InterfaceFuncInvoker1< RuntimeObject*, int32_t >::Invoke(0 /* T System.Collections.Generic.IList`1<System.Object>::get_Item(System.Int32) */, il2cpp_rgctx_data(method->rgctx_data, 2), L_49, L_50);
		V_9 = L_51;
		sQEkcZUofLSdEALOSOuyKPdNiQEDA_1_t1B5CB90AB9525321551E427D7C2054C85C37AAC1* L_52 = V_8;
		Func_2_t47FA43C06CA3B7E69EECC5B0C6D36F44AADCB758* L_53 = p9;
		RuntimeObject* L_54 = V_6;
		RuntimeObject* L_55 = V_9;
		RuntimeObject* L_56 = p3;
		cTlcZwgBmjmwQjxeEhJdCJOLqDjC_1_t00DEF10DFB18F406646ED696288655ED53671B85* L_57 = (cTlcZwgBmjmwQjxeEhJdCJOLqDjC_1_t00DEF10DFB18F406646ED696288655ED53671B85*)il2cpp_codegen_object_new(il2cpp_rgctx_data(method->rgctx_data, 6));
		cTlcZwgBmjmwQjxeEhJdCJOLqDjC_1__ctor_m2660924875158C34CA727FFC10FA37C6C7C14D90(L_57, L_54, L_55, (int32_t)1, L_56, (bool)1, /*hidden argument*/il2cpp_rgctx_method(method->rgctx_data, 7));
		NullCheck(L_53);
		RuntimeObject* L_58;
		L_58 = ((  RuntimeObject* (*) (Func_2_t47FA43C06CA3B7E69EECC5B0C6D36F44AADCB758*, cTlcZwgBmjmwQjxeEhJdCJOLqDjC_1_t00DEF10DFB18F406646ED696288655ED53671B85*, const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->rgctx_data, 9)))(L_53, L_57, il2cpp_rgctx_method(method->rgctx_data, 9));
		NullCheck(L_52);
		L_52->___GiVZGuLQxvUOqeIVnTCviBpqPbb_0 = L_58;
		Il2CppCodeGenWriteBarrier((void**)(&L_52->___GiVZGuLQxvUOqeIVnTCviBpqPbb_0), (void*)L_58);
		List_1_t2371DBA2BC5BA5E401A3796013E23F6AA5DE82E7* L_59 = p5;
		sQEkcZUofLSdEALOSOuyKPdNiQEDA_1_t1B5CB90AB9525321551E427D7C2054C85C37AAC1* L_60 = V_8;
		Predicate_1_t0AE34D834A58115AD4CD9532C7FEAF28A2A18674* L_61 = (Predicate_1_t0AE34D834A58115AD4CD9532C7FEAF28A2A18674*)il2cpp_codegen_object_new(Predicate_1_t0AE34D834A58115AD4CD9532C7FEAF28A2A18674_il2cpp_TypeInfo_var);
		Predicate_1__ctor_mC7ED0FD7569E0ACBA4AA0C7D8592AADCFA28A8EA(L_61, (RuntimeObject*)L_60, (intptr_t)((void*)il2cpp_rgctx_method(method->rgctx_data, 16)), /*hidden argument*/Predicate_1__ctor_mC7ED0FD7569E0ACBA4AA0C7D8592AADCFA28A8EA_RuntimeMethod_var);
		NullCheck(L_59);
		kzedFdEdISaCJppRVzkSmhYBfiDK_t96C908773E13D2FD31BFC3C0BC59CD2D7B31233D* L_62;
		L_62 = List_1_Find_m412DFD00E7077EF26A7689218DBB67CFEBBAA57D(L_59, L_61, List_1_Find_m412DFD00E7077EF26A7689218DBB67CFEBBAA57D_RuntimeMethod_var);
		sQEkcZUofLSdEALOSOuyKPdNiQEDA_1_t1B5CB90AB9525321551E427D7C2054C85C37AAC1* L_63 = V_8;
		NullCheck(L_63);
		aKSDPjRJZQzZwYkmoXKHoOMDFOWe_1_tBF7584EF632A787EC6F2057BA1C49894E7E22FCA* L_64 = (aKSDPjRJZQzZwYkmoXKHoOMDFOWe_1_tBF7584EF632A787EC6F2057BA1C49894E7E22FCA*)L_63->___GzKJJorOLWrdrMiTQiKLkIMQBqcb_1;
		NullCheck(L_64);
		Func_2_t9A0D493A82DCC47C9C819A3B045E02D9B5DDCE1B* L_65 = (Func_2_t9A0D493A82DCC47C9C819A3B045E02D9B5DDCE1B*)L_64->___FkKDhjApMORrhuHhObhaCvDMkiLpA_0;
		RuntimeObject* L_66 = V_6;
		NullCheck(L_65);
		int32_t L_67;
		L_67 = ((  int32_t (*) (Func_2_t9A0D493A82DCC47C9C819A3B045E02D9B5DDCE1B*, RuntimeObject*, const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->rgctx_data, 5)))(L_65, L_66, il2cpp_rgctx_method(method->rgctx_data, 5));
		NullCheck(L_62);
		L_62->___CCzhRDaUDvMVJJyCTKXgJlMZxTznA_1 = L_67;
		Func_2_t8A4E59735D50CEA34C30F6CD6B5804A38327CD0B* L_68 = p7;
		RuntimeObject* L_69 = V_6;
		NullCheck(L_68);
		String_t* L_70;
		L_70 = ((  String_t* (*) (Func_2_t8A4E59735D50CEA34C30F6CD6B5804A38327CD0B*, RuntimeObject*, const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->rgctx_data, 18)))(L_68, L_69, il2cpp_rgctx_method(method->rgctx_data, 18));
		bool L_71;
		L_71 = String_IsNullOrEmpty_m54CF0907E7C4F3AFB2E796A13DC751ECBB8DB64A(L_70, NULL);
		if (!L_71)
		{
			goto IL_0134;
		}
	}
	{
		G_B12_0 = _stringLiteralDA39A3EE5E6B4B0D3255BFEF95601890AFD80709;
		goto IL_014c;
	}

IL_0134:
	{
		Func_2_t8A4E59735D50CEA34C30F6CD6B5804A38327CD0B* L_72 = p7;
		RuntimeObject* L_73 = V_6;
		NullCheck(L_72);
		String_t* L_74;
		L_74 = ((  String_t* (*) (Func_2_t8A4E59735D50CEA34C30F6CD6B5804A38327CD0B*, RuntimeObject*, const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->rgctx_data, 18)))(L_72, L_73, il2cpp_rgctx_method(method->rgctx_data, 18));
		String_t* L_75;
		L_75 = String_Concat_m9B13B47FCB3DF61144D9647DDA05F527377251B0(_stringLiteralC62C64F00567C5368CAE37F4E64E1E82FF785677, L_74, _stringLiteralC62C64F00567C5368CAE37F4E64E1E82FF785677, NULL);
		G_B12_0 = L_75;
	}

IL_014c:
	{
		V_10 = G_B12_0;
		String_t* L_76 = p0;
		String_t* L_77 = V_10;
		bool L_78;
		L_78 = String_IsNullOrEmpty_m54CF0907E7C4F3AFB2E796A13DC751ECBB8DB64A(L_77, NULL);
		G_B13_0 = L_76;
		if (!L_78)
		{
			G_B14_0 = L_76;
			goto IL_015f;
		}
	}
	{
		G_B15_0 = _stringLiteralDA39A3EE5E6B4B0D3255BFEF95601890AFD80709;
		G_B15_1 = G_B13_0;
		goto IL_016b;
	}

IL_015f:
	{
		String_t* L_79 = V_10;
		String_t* L_80;
		L_80 = String_Concat_mAF2CE02CC0CB7460753D0A1A91CCF2B1E9804C5D(_stringLiteral2386E77CF610F786B06A91AF2C1B3FD2282D2745, L_79, NULL);
		G_B15_0 = L_80;
		G_B15_1 = G_B14_0;
	}

IL_016b:
	{
		String_t* L_81;
		L_81 = String_Concat_m9B13B47FCB3DF61144D9647DDA05F527377251B0(G_B15_1, G_B15_0, _stringLiteral22B1478CDF9C226208AE289896781AF22519D6CB, NULL);
		Logger_Log_m7AFB3DE7CB55B1AF479DD909EB1A71CEEC54672D((RuntimeObject*)L_81, NULL);
		goto IL_0225;
	}

IL_017f:
	{
		Func_2_t47FA43C06CA3B7E69EECC5B0C6D36F44AADCB758* L_82 = p9;
		RuntimeObject* L_83 = V_6;
		il2cpp_codegen_initobj((&V_4), sizeof(RuntimeObject*));
		RuntimeObject* L_84 = V_4;
		RuntimeObject* L_85 = p3;
		cTlcZwgBmjmwQjxeEhJdCJOLqDjC_1_t00DEF10DFB18F406646ED696288655ED53671B85* L_86 = (cTlcZwgBmjmwQjxeEhJdCJOLqDjC_1_t00DEF10DFB18F406646ED696288655ED53671B85*)il2cpp_codegen_object_new(il2cpp_rgctx_data(method->rgctx_data, 6));
		cTlcZwgBmjmwQjxeEhJdCJOLqDjC_1__ctor_m2660924875158C34CA727FFC10FA37C6C7C14D90(L_86, L_83, L_84, (int32_t)1, L_85, (bool)0, /*hidden argument*/il2cpp_rgctx_method(method->rgctx_data, 7));
		NullCheck(L_82);
		RuntimeObject* L_87;
		L_87 = ((  RuntimeObject* (*) (Func_2_t47FA43C06CA3B7E69EECC5B0C6D36F44AADCB758*, cTlcZwgBmjmwQjxeEhJdCJOLqDjC_1_t00DEF10DFB18F406646ED696288655ED53671B85*, const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->rgctx_data, 9)))(L_82, L_86, il2cpp_rgctx_method(method->rgctx_data, 9));
		V_11 = L_87;
		List_1_t2371DBA2BC5BA5E401A3796013E23F6AA5DE82E7* L_88 = p5;
		aKSDPjRJZQzZwYkmoXKHoOMDFOWe_1_tBF7584EF632A787EC6F2057BA1C49894E7E22FCA* L_89 = V_0;
		NullCheck(L_89);
		Func_2_t9A0D493A82DCC47C9C819A3B045E02D9B5DDCE1B* L_90 = (Func_2_t9A0D493A82DCC47C9C819A3B045E02D9B5DDCE1B*)L_89->___FkKDhjApMORrhuHhObhaCvDMkiLpA_0;
		RuntimeObject* L_91 = V_6;
		NullCheck(L_90);
		int32_t L_92;
		L_92 = ((  int32_t (*) (Func_2_t9A0D493A82DCC47C9C819A3B045E02D9B5DDCE1B*, RuntimeObject*, const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->rgctx_data, 5)))(L_90, L_91, il2cpp_rgctx_method(method->rgctx_data, 5));
		aKSDPjRJZQzZwYkmoXKHoOMDFOWe_1_tBF7584EF632A787EC6F2057BA1C49894E7E22FCA* L_93 = V_0;
		NullCheck(L_93);
		Func_2_t9A0D493A82DCC47C9C819A3B045E02D9B5DDCE1B* L_94 = (Func_2_t9A0D493A82DCC47C9C819A3B045E02D9B5DDCE1B*)L_93->___FkKDhjApMORrhuHhObhaCvDMkiLpA_0;
		RuntimeObject* L_95 = V_11;
		NullCheck(L_94);
		int32_t L_96;
		L_96 = ((  int32_t (*) (Func_2_t9A0D493A82DCC47C9C819A3B045E02D9B5DDCE1B*, RuntimeObject*, const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->rgctx_data, 5)))(L_94, L_95, il2cpp_rgctx_method(method->rgctx_data, 5));
		kzedFdEdISaCJppRVzkSmhYBfiDK_t96C908773E13D2FD31BFC3C0BC59CD2D7B31233D* L_97 = (kzedFdEdISaCJppRVzkSmhYBfiDK_t96C908773E13D2FD31BFC3C0BC59CD2D7B31233D*)il2cpp_codegen_object_new(kzedFdEdISaCJppRVzkSmhYBfiDK_t96C908773E13D2FD31BFC3C0BC59CD2D7B31233D_il2cpp_TypeInfo_var);
		kzedFdEdISaCJppRVzkSmhYBfiDK__ctor_mCECC0F8AC7218CE1ED3AB6E85EC8C0FC5BCA8564(L_97, (-1), L_92, L_96, /*hidden argument*/NULL);
		NullCheck(L_88);
		List_1_Add_mEBA4A42D074F0BFA59336506E8E0639669B309DD_inline(L_88, L_97, List_1_Add_mEBA4A42D074F0BFA59336506E8E0639669B309DD_RuntimeMethod_var);
		Func_2_t8A4E59735D50CEA34C30F6CD6B5804A38327CD0B* L_98 = p7;
		RuntimeObject* L_99 = V_6;
		NullCheck(L_98);
		String_t* L_100;
		L_100 = ((  String_t* (*) (Func_2_t8A4E59735D50CEA34C30F6CD6B5804A38327CD0B*, RuntimeObject*, const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->rgctx_data, 18)))(L_98, L_99, il2cpp_rgctx_method(method->rgctx_data, 18));
		bool L_101;
		L_101 = String_IsNullOrEmpty_m54CF0907E7C4F3AFB2E796A13DC751ECBB8DB64A(L_100, NULL);
		if (!L_101)
		{
			goto IL_01da;
		}
	}
	{
		G_B19_0 = _stringLiteralDA39A3EE5E6B4B0D3255BFEF95601890AFD80709;
		goto IL_01f2;
	}

IL_01da:
	{
		Func_2_t8A4E59735D50CEA34C30F6CD6B5804A38327CD0B* L_102 = p7;
		RuntimeObject* L_103 = V_6;
		NullCheck(L_102);
		String_t* L_104;
		L_104 = ((  String_t* (*) (Func_2_t8A4E59735D50CEA34C30F6CD6B5804A38327CD0B*, RuntimeObject*, const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->rgctx_data, 18)))(L_102, L_103, il2cpp_rgctx_method(method->rgctx_data, 18));
		String_t* L_105;
		L_105 = String_Concat_m9B13B47FCB3DF61144D9647DDA05F527377251B0(_stringLiteralC62C64F00567C5368CAE37F4E64E1E82FF785677, L_104, _stringLiteralC62C64F00567C5368CAE37F4E64E1E82FF785677, NULL);
		G_B19_0 = L_105;
	}

IL_01f2:
	{
		V_12 = G_B19_0;
		String_t* L_106 = p0;
		String_t* L_107 = V_12;
		bool L_108;
		L_108 = String_IsNullOrEmpty_m54CF0907E7C4F3AFB2E796A13DC751ECBB8DB64A(L_107, NULL);
		G_B20_0 = L_106;
		G_B20_1 = _stringLiteral18671CD5DECD4AF4B7DF2AA0F1A0C1E4DE25F8AB;
		if (!L_108)
		{
			G_B21_0 = L_106;
			G_B21_1 = _stringLiteral18671CD5DECD4AF4B7DF2AA0F1A0C1E4DE25F8AB;
			goto IL_020a;
		}
	}
	{
		G_B22_0 = _stringLiteralDA39A3EE5E6B4B0D3255BFEF95601890AFD80709;
		G_B22_1 = G_B20_0;
		G_B22_2 = G_B20_1;
		goto IL_0216;
	}

IL_020a:
	{
		String_t* L_109 = V_12;
		String_t* L_110;
		L_110 = String_Concat_mAF2CE02CC0CB7460753D0A1A91CCF2B1E9804C5D(_stringLiteral2386E77CF610F786B06A91AF2C1B3FD2282D2745, L_109, NULL);
		G_B22_0 = L_110;
		G_B22_1 = G_B21_0;
		G_B22_2 = G_B21_1;
	}

IL_0216:
	{
		String_t* L_111;
		L_111 = String_Concat_mF8B69BE42B5C5ABCAD3C176FBBE3010E0815D65D(G_B22_2, G_B22_1, G_B22_0, _stringLiteralF3E84B722399601AD7E281754E917478AA9AD48D, NULL);
		Logger_Log_m7AFB3DE7CB55B1AF479DD909EB1A71CEEC54672D((RuntimeObject*)L_111, NULL);
	}

IL_0225:
	{
		int32_t L_112 = V_5;
		V_5 = ((int32_t)il2cpp_codegen_add(L_112, 1));
	}

IL_022b:
	{
		int32_t L_113 = V_5;
		RuntimeObject* L_114 = p2;
		NullCheck((RuntimeObject*)L_114);
		int32_t L_115;
		L_115 = InterfaceFuncInvoker0< int32_t >::Invoke(0 /* System.Int32 System.Collections.Generic.ICollection`1<System.Object>::get_Count() */, il2cpp_rgctx_data(method->rgctx_data, 10), (RuntimeObject*)L_114);
		if ((((int32_t)L_113) < ((int32_t)L_115)))
		{
			goto IL_00a0;
		}
	}

IL_0238:
	{
		return;
	}
}
// System.Void Rewired.Data.UserData/PMmfElSRTHipvrooOqnrsVzyuehD::wAJHKXCfuDHpydIwGUKdtfiKfwOlB<System.Object>(System.Collections.Generic.IList`1<?>,System.Collections.Generic.IList`1<?>,System.Collections.Generic.IList`1<?>,System.Func`3<?,System.Collections.Generic.IList`1<?>,System.Int32>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void PMmfElSRTHipvrooOqnrsVzyuehD_wAJHKXCfuDHpydIwGUKdtfiKfwOlB_TisRuntimeObject_m22A6F50F306C5EFDBEF1155C1AC0CF015C89845D_gshared (RuntimeObject* p0, RuntimeObject* p1, RuntimeObject* p2, Func_3_tA2EC68432F49E8DB1FC81E592EA4A30855D5EE0E* p3, const RuntimeMethod* method) 
{
int32_t V_0 = 0;
	int32_t V_1 = 0;
	RuntimeObject* V_2 = NULL;
	int32_t V_3 = 0;
	{
		V_0 = 0;
		goto IL_0015;
	}

IL_0004:
	{
		RuntimeObject* L_0 = p2;
		RuntimeObject* L_1 = p0;
		int32_t L_2 = V_0;
		NullCheck(L_1);
		RuntimeObject* L_3;
		L_3 = InterfaceFuncInvoker1< RuntimeObject*, int32_t >::Invoke(0 /* T System.Collections.Generic.IList`1<System.Object>::get_Item(System.Int32) */, il2cpp_rgctx_data(method->rgctx_data, 0), L_1, L_2);
		NullCheck((RuntimeObject*)L_0);
		InterfaceActionInvoker1< RuntimeObject* >::Invoke(2 /* System.Void System.Collections.Generic.ICollection`1<System.Object>::Add(T) */, il2cpp_rgctx_data(method->rgctx_data, 2), (RuntimeObject*)L_0, L_3);
		int32_t L_4 = V_0;
		V_0 = ((int32_t)il2cpp_codegen_add(L_4, 1));
	}

IL_0015:
	{
		int32_t L_5 = V_0;
		RuntimeObject* L_6 = p0;
		NullCheck((RuntimeObject*)L_6);
		int32_t L_7;
		L_7 = InterfaceFuncInvoker0< int32_t >::Invoke(0 /* System.Int32 System.Collections.Generic.ICollection`1<System.Object>::get_Count() */, il2cpp_rgctx_data(method->rgctx_data, 2), (RuntimeObject*)L_6);
		if ((((int32_t)L_5) < ((int32_t)L_7)))
		{
			goto IL_0004;
		}
	}
	{
		RuntimeObject* L_8 = p1;
		if (!L_8)
		{
			goto IL_0058;
		}
	}
	{
		V_1 = 0;
		goto IL_004f;
	}

IL_0025:
	{
		RuntimeObject* L_9 = p1;
		int32_t L_10 = V_1;
		NullCheck(L_9);
		RuntimeObject* L_11;
		L_11 = InterfaceFuncInvoker1< RuntimeObject*, int32_t >::Invoke(0 /* T System.Collections.Generic.IList`1<System.Object>::get_Item(System.Int32) */, il2cpp_rgctx_data(method->rgctx_data, 0), L_9, L_10);
		V_2 = L_11;
		Func_3_tA2EC68432F49E8DB1FC81E592EA4A30855D5EE0E* L_12 = p3;
		RuntimeObject* L_13 = V_2;
		RuntimeObject* L_14 = p2;
		NullCheck(L_12);
		int32_t L_15;
		L_15 = ((  int32_t (*) (Func_3_tA2EC68432F49E8DB1FC81E592EA4A30855D5EE0E*, RuntimeObject*, RuntimeObject*, const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->rgctx_data, 6)))(L_12, L_13, L_14, il2cpp_rgctx_method(method->rgctx_data, 6));
		V_3 = L_15;
		int32_t L_16 = V_3;
		if ((((int32_t)L_16) < ((int32_t)0)))
		{
			goto IL_0044;
		}
	}
	{
		RuntimeObject* L_17 = p2;
		int32_t L_18 = V_3;
		RuntimeObject* L_19 = V_2;
		NullCheck(L_17);
		InterfaceActionInvoker2< int32_t, RuntimeObject* >::Invoke(1 /* System.Void System.Collections.Generic.IList`1<System.Object>::set_Item(System.Int32,T) */, il2cpp_rgctx_data(method->rgctx_data, 0), L_17, L_18, L_19);
		goto IL_004b;
	}

IL_0044:
	{
		RuntimeObject* L_20 = p2;
		RuntimeObject* L_21 = V_2;
		NullCheck((RuntimeObject*)L_20);
		InterfaceActionInvoker1< RuntimeObject* >::Invoke(2 /* System.Void System.Collections.Generic.ICollection`1<System.Object>::Add(T) */, il2cpp_rgctx_data(method->rgctx_data, 2), (RuntimeObject*)L_20, L_21);
	}

IL_004b:
	{
		int32_t L_22 = V_1;
		V_1 = ((int32_t)il2cpp_codegen_add(L_22, 1));
	}

IL_004f:
	{
		int32_t L_23 = V_1;
		RuntimeObject* L_24 = p1;
		NullCheck((RuntimeObject*)L_24);
		int32_t L_25;
		L_25 = InterfaceFuncInvoker0< int32_t >::Invoke(0 /* System.Int32 System.Collections.Generic.ICollection`1<System.Object>::get_Count() */, il2cpp_rgctx_data(method->rgctx_data, 2), (RuntimeObject*)L_24);
		if ((((int32_t)L_23) < ((int32_t)L_25)))
		{
			goto IL_0025;
		}
	}

IL_0058:
	{
		return;
	}
}
// System.Collections.Generic.IEnumerable`1<Rewired.ElementAssignmentConflictInfo> Rewired.Player/ControllerHelper/ConflictCheckingHelper::IOcxdCLgugooqaADqWvPIyWRSwwG<System.Object>(Rewired.ElementAssignmentConflictCheck,System.Boolean,System.Boolean,TBSPGJPKaXrjsOpBQZPxJnrcfSfAA`1<?>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* ConflictCheckingHelper_IOcxdCLgugooqaADqWvPIyWRSwwG_TisRuntimeObject_mE52046BB02FF894FFB3B98B180EABD8DFF91ACB9_gshared (ConflictCheckingHelper_t8D707CEC57F056B87A4C68F98F780D34E893A8DB* __this, ElementAssignmentConflictCheck_tC22925257E88D3999FDD06C7ABF3B6CE6C09847E p0, bool p1, bool p2, TBSPGJPKaXrjsOpBQZPxJnrcfSfAA_1_t92F77A2C0897D802673079FA32163CACC9FD23DE* p3, const RuntimeMethod* method) 
{
{
		LaNNrUufXUaCsHwYSVeeItSJzfQrA_1_t90BE74457214F7F3801FB0D2DD805D4EAF4457DA* L_0 = (LaNNrUufXUaCsHwYSVeeItSJzfQrA_1_t90BE74457214F7F3801FB0D2DD805D4EAF4457DA*)il2cpp_codegen_object_new(il2cpp_rgctx_data(method->rgctx_data, 0));
		LaNNrUufXUaCsHwYSVeeItSJzfQrA_1__ctor_m4CB206044F75D42101528E3DE9EDB4BE49E09B23(L_0, ((int32_t)-2), /*hidden argument*/il2cpp_rgctx_method(method->rgctx_data, 1));
		LaNNrUufXUaCsHwYSVeeItSJzfQrA_1_t90BE74457214F7F3801FB0D2DD805D4EAF4457DA* L_1 = L_0;
		NullCheck(L_1);
		L_1->___hJlvyFukKfMzsWcSVLwLCnIUdlMn_11 = __this;
		Il2CppCodeGenWriteBarrier((void**)(&L_1->___hJlvyFukKfMzsWcSVLwLCnIUdlMn_11), (void*)__this);
		LaNNrUufXUaCsHwYSVeeItSJzfQrA_1_t90BE74457214F7F3801FB0D2DD805D4EAF4457DA* L_2 = L_1;
		ElementAssignmentConflictCheck_tC22925257E88D3999FDD06C7ABF3B6CE6C09847E L_3 = p0;
		NullCheck(L_2);
		L_2->___wmyDcCHWYMasogZlrqkbzlzgyAQe_6 = L_3;
		LaNNrUufXUaCsHwYSVeeItSJzfQrA_1_t90BE74457214F7F3801FB0D2DD805D4EAF4457DA* L_4 = L_2;
		bool L_5 = p1;
		NullCheck(L_4);
		L_4->___wbJTSksJrdbiJvScZEcbgDdFVdPiA_8 = L_5;
		LaNNrUufXUaCsHwYSVeeItSJzfQrA_1_t90BE74457214F7F3801FB0D2DD805D4EAF4457DA* L_6 = L_4;
		bool L_7 = p2;
		NullCheck(L_6);
		L_6->___mzPyLJUgHmLqXxITGVUETFfKmubS_10 = L_7;
		LaNNrUufXUaCsHwYSVeeItSJzfQrA_1_t90BE74457214F7F3801FB0D2DD805D4EAF4457DA* L_8 = L_6;
		TBSPGJPKaXrjsOpBQZPxJnrcfSfAA_1_t92F77A2C0897D802673079FA32163CACC9FD23DE* L_9 = p3;
		NullCheck(L_8);
		L_8->___GvAHqXQEeCaNOUVGVeofgeJOkljZ_4 = L_9;
		Il2CppCodeGenWriteBarrier((void**)(&L_8->___GvAHqXQEeCaNOUVGVeofgeJOkljZ_4), (void*)L_9);
		return (RuntimeObject*)L_8;
	}
}
// System.Collections.Generic.IEnumerable`1<Rewired.ElementAssignmentConflictInfo> Rewired.Player/ControllerHelper/ConflictCheckingHelper::IOcxdCLgugooqaADqWvPIyWRSwwG<System.Object>(Rewired.ControllerType,System.Int32,?,System.Boolean,System.Boolean,TBSPGJPKaXrjsOpBQZPxJnrcfSfAA`1<?>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* ConflictCheckingHelper_IOcxdCLgugooqaADqWvPIyWRSwwG_TisRuntimeObject_m07F0DEDCCBE0EBB24C53F61CFE7E4F3C5E50E7E6_gshared (ConflictCheckingHelper_t8D707CEC57F056B87A4C68F98F780D34E893A8DB* __this, int32_t p0, int32_t p1, RuntimeObject* p2, bool p3, bool p4, TBSPGJPKaXrjsOpBQZPxJnrcfSfAA_1_t92F77A2C0897D802673079FA32163CACC9FD23DE* p5, const RuntimeMethod* method) 
{
{
		NPPlAOzpsFiqWUuYJtTMLJfMbmYu_1_tDD2E3885D14A7C4488825DE3B7C56DEA023BC185* L_0 = (NPPlAOzpsFiqWUuYJtTMLJfMbmYu_1_tDD2E3885D14A7C4488825DE3B7C56DEA023BC185*)il2cpp_codegen_object_new(il2cpp_rgctx_data(method->rgctx_data, 0));
		NPPlAOzpsFiqWUuYJtTMLJfMbmYu_1__ctor_m471D4BF3F60DB5E5C8E988C205C6217CA5E5C74D(L_0, ((int32_t)-2), /*hidden argument*/il2cpp_rgctx_method(method->rgctx_data, 1));
		NPPlAOzpsFiqWUuYJtTMLJfMbmYu_1_tDD2E3885D14A7C4488825DE3B7C56DEA023BC185* L_1 = L_0;
		NullCheck(L_1);
		L_1->___hJlvyFukKfMzsWcSVLwLCnIUdlMn_11 = __this;
		Il2CppCodeGenWriteBarrier((void**)(&L_1->___hJlvyFukKfMzsWcSVLwLCnIUdlMn_11), (void*)__this);
		NPPlAOzpsFiqWUuYJtTMLJfMbmYu_1_tDD2E3885D14A7C4488825DE3B7C56DEA023BC185* L_2 = L_1;
		int32_t L_3 = p0;
		NullCheck(L_2);
		L_2->___GIZHpBfTSGgXJDtcKfJhtDcTARMY_13 = L_3;
		NPPlAOzpsFiqWUuYJtTMLJfMbmYu_1_tDD2E3885D14A7C4488825DE3B7C56DEA023BC185* L_4 = L_2;
		int32_t L_5 = p1;
		NullCheck(L_4);
		L_4->___XuDYOktzvzuJLzqUPQedqdspGDhC_15 = L_5;
		NPPlAOzpsFiqWUuYJtTMLJfMbmYu_1_tDD2E3885D14A7C4488825DE3B7C56DEA023BC185* L_6 = L_4;
		RuntimeObject* L_7 = p2;
		NullCheck(L_6);
		L_6->___yFsxPduJsRRbcQBkjQYDCjtPsnZC_6 = L_7;
		Il2CppCodeGenWriteBarrier((void**)(&L_6->___yFsxPduJsRRbcQBkjQYDCjtPsnZC_6), (void*)L_7);
		NPPlAOzpsFiqWUuYJtTMLJfMbmYu_1_tDD2E3885D14A7C4488825DE3B7C56DEA023BC185* L_8 = L_6;
		bool L_9 = p3;
		NullCheck(L_8);
		L_8->___wbJTSksJrdbiJvScZEcbgDdFVdPiA_8 = L_9;
		NPPlAOzpsFiqWUuYJtTMLJfMbmYu_1_tDD2E3885D14A7C4488825DE3B7C56DEA023BC185* L_10 = L_8;
		bool L_11 = p4;
		NullCheck(L_10);
		L_10->___mzPyLJUgHmLqXxITGVUETFfKmubS_10 = L_11;
		NPPlAOzpsFiqWUuYJtTMLJfMbmYu_1_tDD2E3885D14A7C4488825DE3B7C56DEA023BC185* L_12 = L_10;
		TBSPGJPKaXrjsOpBQZPxJnrcfSfAA_1_t92F77A2C0897D802673079FA32163CACC9FD23DE* L_13 = p5;
		NullCheck(L_12);
		L_12->___GvAHqXQEeCaNOUVGVeofgeJOkljZ_4 = L_13;
		Il2CppCodeGenWriteBarrier((void**)(&L_12->___GvAHqXQEeCaNOUVGVeofgeJOkljZ_4), (void*)L_13);
		return (RuntimeObject*)L_12;
	}
}
// System.Collections.Generic.IEnumerable`1<Rewired.ElementAssignmentConflictInfo> Rewired.Player/ControllerHelper/ConflictCheckingHelper::IOcxdCLgugooqaADqWvPIyWRSwwG<System.Object>(Rewired.ControllerType,System.Int32,?,Rewired.ActionElementMap,System.Boolean,System.Boolean,TBSPGJPKaXrjsOpBQZPxJnrcfSfAA`1<?>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* ConflictCheckingHelper_IOcxdCLgugooqaADqWvPIyWRSwwG_TisRuntimeObject_m4A17F643DF9D8442AFECD026C62EC60B33B86DF8_gshared (ConflictCheckingHelper_t8D707CEC57F056B87A4C68F98F780D34E893A8DB* __this, int32_t p0, int32_t p1, RuntimeObject* p2, ActionElementMap_t0EBE3E5D3A5DF3BA6D35F8082ED2232404EFF8CF* p3, bool p4, bool p5, TBSPGJPKaXrjsOpBQZPxJnrcfSfAA_1_t92F77A2C0897D802673079FA32163CACC9FD23DE* p6, const RuntimeMethod* method) 
{
{
		gPTTtyzOAxLCvPhgMtIrgUsCIpeH_1_tA05B48EAD2AA2E510F8D380D32FC8F6D8331D7E3* L_0 = (gPTTtyzOAxLCvPhgMtIrgUsCIpeH_1_tA05B48EAD2AA2E510F8D380D32FC8F6D8331D7E3*)il2cpp_codegen_object_new(il2cpp_rgctx_data(method->rgctx_data, 0));
		gPTTtyzOAxLCvPhgMtIrgUsCIpeH_1__ctor_mAAA860EA13BFD81E13FB29502A14D28E72DD2762(L_0, ((int32_t)-2), /*hidden argument*/il2cpp_rgctx_method(method->rgctx_data, 1));
		gPTTtyzOAxLCvPhgMtIrgUsCIpeH_1_tA05B48EAD2AA2E510F8D380D32FC8F6D8331D7E3* L_1 = L_0;
		NullCheck(L_1);
		L_1->___hJlvyFukKfMzsWcSVLwLCnIUdlMn_13 = __this;
		Il2CppCodeGenWriteBarrier((void**)(&L_1->___hJlvyFukKfMzsWcSVLwLCnIUdlMn_13), (void*)__this);
		gPTTtyzOAxLCvPhgMtIrgUsCIpeH_1_tA05B48EAD2AA2E510F8D380D32FC8F6D8331D7E3* L_2 = L_1;
		int32_t L_3 = p0;
		NullCheck(L_2);
		L_2->___GIZHpBfTSGgXJDtcKfJhtDcTARMY_15 = L_3;
		gPTTtyzOAxLCvPhgMtIrgUsCIpeH_1_tA05B48EAD2AA2E510F8D380D32FC8F6D8331D7E3* L_4 = L_2;
		int32_t L_5 = p1;
		NullCheck(L_4);
		L_4->___XuDYOktzvzuJLzqUPQedqdspGDhC_17 = L_5;
		gPTTtyzOAxLCvPhgMtIrgUsCIpeH_1_tA05B48EAD2AA2E510F8D380D32FC8F6D8331D7E3* L_6 = L_4;
		RuntimeObject* L_7 = p2;
		NullCheck(L_6);
		L_6->___yFsxPduJsRRbcQBkjQYDCjtPsnZC_8 = L_7;
		Il2CppCodeGenWriteBarrier((void**)(&L_6->___yFsxPduJsRRbcQBkjQYDCjtPsnZC_8), (void*)L_7);
		gPTTtyzOAxLCvPhgMtIrgUsCIpeH_1_tA05B48EAD2AA2E510F8D380D32FC8F6D8331D7E3* L_8 = L_6;
		ActionElementMap_t0EBE3E5D3A5DF3BA6D35F8082ED2232404EFF8CF* L_9 = p3;
		NullCheck(L_8);
		L_8->___CjJHlxWDwYLXIQWEDyYWzjqIDWLF_6 = L_9;
		Il2CppCodeGenWriteBarrier((void**)(&L_8->___CjJHlxWDwYLXIQWEDyYWzjqIDWLF_6), (void*)L_9);
		gPTTtyzOAxLCvPhgMtIrgUsCIpeH_1_tA05B48EAD2AA2E510F8D380D32FC8F6D8331D7E3* L_10 = L_8;
		bool L_11 = p4;
		NullCheck(L_10);
		L_10->___wbJTSksJrdbiJvScZEcbgDdFVdPiA_10 = L_11;
		gPTTtyzOAxLCvPhgMtIrgUsCIpeH_1_tA05B48EAD2AA2E510F8D380D32FC8F6D8331D7E3* L_12 = L_10;
		bool L_13 = p5;
		NullCheck(L_12);
		L_12->___mzPyLJUgHmLqXxITGVUETFfKmubS_12 = L_13;
		gPTTtyzOAxLCvPhgMtIrgUsCIpeH_1_tA05B48EAD2AA2E510F8D380D32FC8F6D8331D7E3* L_14 = L_12;
		TBSPGJPKaXrjsOpBQZPxJnrcfSfAA_1_t92F77A2C0897D802673079FA32163CACC9FD23DE* L_15 = p6;
		NullCheck(L_14);
		L_14->___GvAHqXQEeCaNOUVGVeofgeJOkljZ_4 = L_15;
		Il2CppCodeGenWriteBarrier((void**)(&L_14->___GvAHqXQEeCaNOUVGVeofgeJOkljZ_4), (void*)L_15);
		return (RuntimeObject*)L_14;
	}
}
// System.Int32 Rewired.Player/ControllerHelper/ConflictCheckingHelper::LjomBUWEwGFWAlAdQCyHCghfTkQvA<System.Object>(Rewired.ElementAssignmentConflictCheck,System.Boolean,System.Boolean,TBSPGJPKaXrjsOpBQZPxJnrcfSfAA`1<?>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t ConflictCheckingHelper_LjomBUWEwGFWAlAdQCyHCghfTkQvA_TisRuntimeObject_m3CFB80FA72BED709C47A864F8A153F18BEB293EB_gshared (ConflictCheckingHelper_t8D707CEC57F056B87A4C68F98F780D34E893A8DB* __this, ElementAssignmentConflictCheck_tC22925257E88D3999FDD06C7ABF3B6CE6C09847E p0, bool p1, bool p2, TBSPGJPKaXrjsOpBQZPxJnrcfSfAA_1_t92F77A2C0897D802673079FA32163CACC9FD23DE* p3, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
Player_t71A64CE695A2F96B144F3050755AB2799DA7C01B* V_0 = NULL;
	ControllerMap_tC01A582E577E38D21EB7D87A8C040AF5DA285FB3* V_1 = NULL;
	InputMapCategory_t309A7C800100DDCC67C5C6A69F960A1D71768111* V_2 = NULL;
	int32_t V_3 = 0;
	int32_t V_4 = 0;
	ControllerMap_tC01A582E577E38D21EB7D87A8C040AF5DA285FB3* V_5 = NULL;
	InputMapCategory_t309A7C800100DDCC67C5C6A69F960A1D71768111* G_B7_0 = NULL;
	{
		TBSPGJPKaXrjsOpBQZPxJnrcfSfAA_1_t92F77A2C0897D802673079FA32163CACC9FD23DE* L_0 = p3;
		if (L_0)
		{
			goto IL_0006;
		}
	}
	{
		return 0;
	}

IL_0006:
	{
		il2cpp_codegen_runtime_class_init_inline(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		PlayerHelper_t96BC8DE1C94717C98B253F25C7B9C82639E4BF5C* L_1;
		L_1 = ReInput_get_players_m3DDA5505CC1DB7580B0C41F1D781A284D3EACD27(NULL);
		int32_t L_2;
		L_2 = ElementAssignmentConflictCheck_get_playerId_m13D1C2C48B4AF7E87153014EE4B16491202256C5_inline((&p0), NULL);
		NullCheck(L_1);
		Player_t71A64CE695A2F96B144F3050755AB2799DA7C01B* L_3;
		L_3 = PlayerHelper_GetPlayer_m42CD1C5AC3CC96C9E36A74D680F0CEC9F5EB5FDC(L_1, L_2, NULL);
		V_0 = L_3;
		Player_t71A64CE695A2F96B144F3050755AB2799DA7C01B* L_4 = V_0;
		if (L_4)
		{
			goto IL_001d;
		}
	}
	{
		return 0;
	}

IL_001d:
	{
		Player_t71A64CE695A2F96B144F3050755AB2799DA7C01B* L_5 = V_0;
		NullCheck(L_5);
		ControllerHelper_tCE72EA23053BD0C6ECB4D75A69F8CD1B3AC28FF6* L_6 = (ControllerHelper_tCE72EA23053BD0C6ECB4D75A69F8CD1B3AC28FF6*)L_5->___controllers_7;
		NullCheck(L_6);
		MapHelper_t214BA4F045E5EB4B312E4E6AEB6697813117A7C2* L_7 = (MapHelper_t214BA4F045E5EB4B312E4E6AEB6697813117A7C2*)L_6->___maps_12;
		int32_t L_8;
		L_8 = ElementAssignmentConflictCheck_get_controllerType_mB10ABC66916B5C14CA467D3289A606AEE947FE72_inline((&p0), NULL);
		int32_t L_9;
		L_9 = ElementAssignmentConflictCheck_get_controllerId_m5C57BA2FE3D405B624E86F7DD88454ED9711954A_inline((&p0), NULL);
		int32_t L_10;
		L_10 = ElementAssignmentConflictCheck_get_controllerMapId_m4C899DB8B80BBF22D0B0CAA98E0F5330AECF1800_inline((&p0), NULL);
		NullCheck(L_7);
		ControllerMap_tC01A582E577E38D21EB7D87A8C040AF5DA285FB3* L_11;
		L_11 = MapHelper_GetMap_m7447D54D0BABDE292B5BC1AAA6F5576F29B016BE(L_7, L_8, L_9, L_10, NULL);
		V_1 = L_11;
		ControllerMap_tC01A582E577E38D21EB7D87A8C040AF5DA285FB3* L_12 = V_1;
		if (L_12)
		{
			goto IL_0059;
		}
	}
	{
		il2cpp_codegen_runtime_class_init_inline(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		MappingHelper_t18AE344473D49AF2E7133108678DD4D963699662* L_13;
		L_13 = ReInput_get_mapping_mDE6BD708754EB86C540ACCB26BFD21D1F8054554(NULL);
		int32_t L_14;
		L_14 = ElementAssignmentConflictCheck_get_controllerMapCategoryId_m0A29A78618798D54C96B3EE602E3576B899DBB99_inline((&p0), NULL);
		NullCheck(L_13);
		InputMapCategory_t309A7C800100DDCC67C5C6A69F960A1D71768111* L_15;
		L_15 = MappingHelper_GetMapCategory_m6B8082A9D9CAAB69B2EC97F6B2FCAF94C5C88DBD(L_13, L_14, NULL);
		G_B7_0 = L_15;
		goto IL_0069;
	}

IL_0059:
	{
		il2cpp_codegen_runtime_class_init_inline(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		MappingHelper_t18AE344473D49AF2E7133108678DD4D963699662* L_16;
		L_16 = ReInput_get_mapping_mDE6BD708754EB86C540ACCB26BFD21D1F8054554(NULL);
		ControllerMap_tC01A582E577E38D21EB7D87A8C040AF5DA285FB3* L_17 = V_1;
		NullCheck(L_17);
		int32_t L_18;
		L_18 = ControllerMap_get_categoryId_m4D2BD4A8373EE16C75E13CB9B5ED8941A26D2B33(L_17, NULL);
		NullCheck(L_16);
		InputMapCategory_t309A7C800100DDCC67C5C6A69F960A1D71768111* L_19;
		L_19 = MappingHelper_GetMapCategory_m6B8082A9D9CAAB69B2EC97F6B2FCAF94C5C88DBD(L_16, L_18, NULL);
		G_B7_0 = L_19;
	}

IL_0069:
	{
		V_2 = G_B7_0;
		InputMapCategory_t309A7C800100DDCC67C5C6A69F960A1D71768111* L_20 = V_2;
		if (L_20)
		{
			goto IL_006f;
		}
	}
	{
		return 0;
	}

IL_006f:
	{
		V_3 = 0;
		V_4 = 0;
		goto IL_00b2;
	}

IL_0076:
	{
		TBSPGJPKaXrjsOpBQZPxJnrcfSfAA_1_t92F77A2C0897D802673079FA32163CACC9FD23DE* L_21 = p3;
		int32_t L_22 = V_4;
		NullCheck(L_21);
		RuntimeObject* L_23;
		L_23 = ((  RuntimeObject* (*) (TBSPGJPKaXrjsOpBQZPxJnrcfSfAA_1_t92F77A2C0897D802673079FA32163CACC9FD23DE*, int32_t, const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->rgctx_data, 1)))(L_21, L_22, il2cpp_rgctx_method(method->rgctx_data, 1));
		V_5 = (ControllerMap_tC01A582E577E38D21EB7D87A8C040AF5DA285FB3*)L_23;
		bool L_24 = p1;
		if (!L_24)
		{
			goto IL_0092;
		}
	}
	{
		ControllerMap_tC01A582E577E38D21EB7D87A8C040AF5DA285FB3* L_25 = V_5;
		NullCheck(L_25);
		bool L_26;
		L_26 = ControllerMap_get_enabled_mA47FDF987F7A3D02B760A0F6923993074A810915(L_25, NULL);
		if (!L_26)
		{
			goto IL_00ac;
		}
	}

IL_0092:
	{
		bool L_27 = p2;
		if (L_27)
		{
			goto IL_00a0;
		}
	}
	{
		InputMapCategory_t309A7C800100DDCC67C5C6A69F960A1D71768111* L_28 = V_2;
		ControllerMap_tC01A582E577E38D21EB7D87A8C040AF5DA285FB3* L_29 = V_5;
		bool L_30;
		L_30 = ConflictCheckingHelper_HSvNYjKwjqmkkXAMHhkOgaGsivnQA_m95133A1C4C565019762E4A5EACF95189E3ECC306(__this, L_28, L_29, NULL);
		if (L_30)
		{
			goto IL_00ac;
		}
	}

IL_00a0:
	{
		int32_t L_31 = V_3;
		ControllerMap_tC01A582E577E38D21EB7D87A8C040AF5DA285FB3* L_32 = V_5;
		ElementAssignmentConflictCheck_tC22925257E88D3999FDD06C7ABF3B6CE6C09847E L_33 = p0;
		bool L_34 = p1;
		NullCheck(L_32);
		int32_t L_35;
		L_35 = VirtualFuncInvoker2< int32_t, ElementAssignmentConflictCheck_tC22925257E88D3999FDD06C7ABF3B6CE6C09847E, bool >::Invoke(25 /* System.Int32 Rewired.ControllerMap::RemoveElementAssignmentConflicts(Rewired.ElementAssignmentConflictCheck,System.Boolean) */, L_32, L_33, L_34);
		V_3 = ((int32_t)il2cpp_codegen_add(L_31, L_35));
	}

IL_00ac:
	{
		int32_t L_36 = V_4;
		V_4 = ((int32_t)il2cpp_codegen_add(L_36, 1));
	}

IL_00b2:
	{
		int32_t L_37 = V_4;
		TBSPGJPKaXrjsOpBQZPxJnrcfSfAA_1_t92F77A2C0897D802673079FA32163CACC9FD23DE* L_38 = p3;
		NullCheck(L_38);
		int32_t L_39;
		L_39 = ((  int32_t (*) (TBSPGJPKaXrjsOpBQZPxJnrcfSfAA_1_t92F77A2C0897D802673079FA32163CACC9FD23DE*, const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->rgctx_data, 3)))(L_38, il2cpp_rgctx_method(method->rgctx_data, 3));
		if ((((int32_t)L_37) < ((int32_t)L_39)))
		{
			goto IL_0076;
		}
	}
	{
		int32_t L_40 = V_3;
		return L_40;
	}
}
// System.Int32 Rewired.Player/ControllerHelper/ConflictCheckingHelper::LjomBUWEwGFWAlAdQCyHCghfTkQvA<System.Object>(Rewired.ControllerType,System.Int32,?,System.Boolean,System.Boolean,TBSPGJPKaXrjsOpBQZPxJnrcfSfAA`1<?>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t ConflictCheckingHelper_LjomBUWEwGFWAlAdQCyHCghfTkQvA_TisRuntimeObject_mDD292C3B25730CB4186E127000BEE94F11E722B0_gshared (ConflictCheckingHelper_t8D707CEC57F056B87A4C68F98F780D34E893A8DB* __this, int32_t p0, int32_t p1, RuntimeObject* p2, bool p3, bool p4, TBSPGJPKaXrjsOpBQZPxJnrcfSfAA_1_t92F77A2C0897D802673079FA32163CACC9FD23DE* p5, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
InputMapCategory_t309A7C800100DDCC67C5C6A69F960A1D71768111* V_0 = NULL;
	int32_t V_1 = 0;
	int32_t V_2 = 0;
	ControllerMap_tC01A582E577E38D21EB7D87A8C040AF5DA285FB3* V_3 = NULL;
	{
		TBSPGJPKaXrjsOpBQZPxJnrcfSfAA_1_t92F77A2C0897D802673079FA32163CACC9FD23DE* L_0 = p5;
		if (!L_0)
		{
			goto IL_000c;
		}
	}
	{
		RuntimeObject* L_1 = p2;
		if (L_1)
		{
			goto IL_000e;
		}
	}

IL_000c:
	{
		return 0;
	}

IL_000e:
	{
		il2cpp_codegen_runtime_class_init_inline(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		MappingHelper_t18AE344473D49AF2E7133108678DD4D963699662* L_2;
		L_2 = ReInput_get_mapping_mDE6BD708754EB86C540ACCB26BFD21D1F8054554(NULL);
		RuntimeObject* L_3 = p2;
		NullCheck((ControllerMap_tC01A582E577E38D21EB7D87A8C040AF5DA285FB3*)L_3);
		int32_t L_4;
		L_4 = ControllerMap_get_categoryId_m4D2BD4A8373EE16C75E13CB9B5ED8941A26D2B33((ControllerMap_tC01A582E577E38D21EB7D87A8C040AF5DA285FB3*)L_3, NULL);
		NullCheck(L_2);
		InputMapCategory_t309A7C800100DDCC67C5C6A69F960A1D71768111* L_5;
		L_5 = MappingHelper_GetMapCategory_m6B8082A9D9CAAB69B2EC97F6B2FCAF94C5C88DBD(L_2, L_4, NULL);
		V_0 = L_5;
		InputMapCategory_t309A7C800100DDCC67C5C6A69F960A1D71768111* L_6 = V_0;
		if (L_6)
		{
			goto IL_0029;
		}
	}
	{
		return 0;
	}

IL_0029:
	{
		V_1 = 0;
		V_2 = 0;
		goto IL_006c;
	}

IL_002f:
	{
		TBSPGJPKaXrjsOpBQZPxJnrcfSfAA_1_t92F77A2C0897D802673079FA32163CACC9FD23DE* L_7 = p5;
		int32_t L_8 = V_2;
		NullCheck(L_7);
		RuntimeObject* L_9;
		L_9 = ((  RuntimeObject* (*) (TBSPGJPKaXrjsOpBQZPxJnrcfSfAA_1_t92F77A2C0897D802673079FA32163CACC9FD23DE*, int32_t, const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->rgctx_data, 2)))(L_7, L_8, il2cpp_rgctx_method(method->rgctx_data, 2));
		V_3 = (ControllerMap_tC01A582E577E38D21EB7D87A8C040AF5DA285FB3*)L_9;
		bool L_10 = p3;
		if (!L_10)
		{
			goto IL_0049;
		}
	}
	{
		ControllerMap_tC01A582E577E38D21EB7D87A8C040AF5DA285FB3* L_11 = V_3;
		NullCheck(L_11);
		bool L_12;
		L_12 = ControllerMap_get_enabled_mA47FDF987F7A3D02B760A0F6923993074A810915(L_11, NULL);
		if (!L_12)
		{
			goto IL_0068;
		}
	}

IL_0049:
	{
		bool L_13 = p4;
		if (L_13)
		{
			goto IL_0057;
		}
	}
	{
		InputMapCategory_t309A7C800100DDCC67C5C6A69F960A1D71768111* L_14 = V_0;
		ControllerMap_tC01A582E577E38D21EB7D87A8C040AF5DA285FB3* L_15 = V_3;
		bool L_16;
		L_16 = ConflictCheckingHelper_HSvNYjKwjqmkkXAMHhkOgaGsivnQA_m95133A1C4C565019762E4A5EACF95189E3ECC306(__this, L_14, L_15, NULL);
		if (L_16)
		{
			goto IL_0068;
		}
	}

IL_0057:
	{
		int32_t L_17 = V_1;
		ControllerMap_tC01A582E577E38D21EB7D87A8C040AF5DA285FB3* L_18 = V_3;
		RuntimeObject* L_19 = p2;
		bool L_20 = p3;
		NullCheck(L_18);
		int32_t L_21;
		L_21 = VirtualFuncInvoker2< int32_t, ControllerMap_tC01A582E577E38D21EB7D87A8C040AF5DA285FB3*, bool >::Invoke(23 /* System.Int32 Rewired.ControllerMap::RemoveElementAssignmentConflicts(Rewired.ControllerMap,System.Boolean) */, L_18, (ControllerMap_tC01A582E577E38D21EB7D87A8C040AF5DA285FB3*)L_19, L_20);
		V_1 = ((int32_t)il2cpp_codegen_add(L_17, L_21));
	}

IL_0068:
	{
		int32_t L_22 = V_2;
		V_2 = ((int32_t)il2cpp_codegen_add(L_22, 1));
	}

IL_006c:
	{
		int32_t L_23 = V_2;
		TBSPGJPKaXrjsOpBQZPxJnrcfSfAA_1_t92F77A2C0897D802673079FA32163CACC9FD23DE* L_24 = p5;
		NullCheck(L_24);
		int32_t L_25;
		L_25 = ((  int32_t (*) (TBSPGJPKaXrjsOpBQZPxJnrcfSfAA_1_t92F77A2C0897D802673079FA32163CACC9FD23DE*, const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->rgctx_data, 3)))(L_24, il2cpp_rgctx_method(method->rgctx_data, 3));
		if ((((int32_t)L_23) < ((int32_t)L_25)))
		{
			goto IL_002f;
		}
	}
	{
		int32_t L_26 = V_1;
		return L_26;
	}
}
// System.Int32 Rewired.Player/ControllerHelper/ConflictCheckingHelper::LjomBUWEwGFWAlAdQCyHCghfTkQvA<System.Object>(Rewired.ControllerType,System.Int32,?,Rewired.ActionElementMap,System.Boolean,System.Boolean,TBSPGJPKaXrjsOpBQZPxJnrcfSfAA`1<?>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t ConflictCheckingHelper_LjomBUWEwGFWAlAdQCyHCghfTkQvA_TisRuntimeObject_m281AD5E79B0C2D0230F04587EC6C86CEAF7021EE_gshared (ConflictCheckingHelper_t8D707CEC57F056B87A4C68F98F780D34E893A8DB* __this, int32_t p0, int32_t p1, RuntimeObject* p2, ActionElementMap_t0EBE3E5D3A5DF3BA6D35F8082ED2232404EFF8CF* p3, bool p4, bool p5, TBSPGJPKaXrjsOpBQZPxJnrcfSfAA_1_t92F77A2C0897D802673079FA32163CACC9FD23DE* p6, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
InputMapCategory_t309A7C800100DDCC67C5C6A69F960A1D71768111* V_0 = NULL;
	int32_t V_1 = 0;
	int32_t V_2 = 0;
	ControllerMap_tC01A582E577E38D21EB7D87A8C040AF5DA285FB3* V_3 = NULL;
	InputMapCategory_t309A7C800100DDCC67C5C6A69F960A1D71768111* G_B6_0 = NULL;
	{
		TBSPGJPKaXrjsOpBQZPxJnrcfSfAA_1_t92F77A2C0897D802673079FA32163CACC9FD23DE* L_0 = p6;
		if (!L_0)
		{
			goto IL_0008;
		}
	}
	{
		ActionElementMap_t0EBE3E5D3A5DF3BA6D35F8082ED2232404EFF8CF* L_1 = p3;
		if (L_1)
		{
			goto IL_000a;
		}
	}

IL_0008:
	{
		return 0;
	}

IL_000a:
	{
		RuntimeObject* L_2 = p2;
		if (L_2)
		{
			goto IL_0015;
		}
	}
	{
		G_B6_0 = ((InputMapCategory_t309A7C800100DDCC67C5C6A69F960A1D71768111*)(NULL));
		goto IL_002a;
	}

IL_0015:
	{
		il2cpp_codegen_runtime_class_init_inline(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		MappingHelper_t18AE344473D49AF2E7133108678DD4D963699662* L_3;
		L_3 = ReInput_get_mapping_mDE6BD708754EB86C540ACCB26BFD21D1F8054554(NULL);
		RuntimeObject* L_4 = p2;
		NullCheck((ControllerMap_tC01A582E577E38D21EB7D87A8C040AF5DA285FB3*)L_4);
		int32_t L_5;
		L_5 = ControllerMap_get_categoryId_m4D2BD4A8373EE16C75E13CB9B5ED8941A26D2B33((ControllerMap_tC01A582E577E38D21EB7D87A8C040AF5DA285FB3*)L_4, NULL);
		NullCheck(L_3);
		InputMapCategory_t309A7C800100DDCC67C5C6A69F960A1D71768111* L_6;
		L_6 = MappingHelper_GetMapCategory_m6B8082A9D9CAAB69B2EC97F6B2FCAF94C5C88DBD(L_3, L_5, NULL);
		G_B6_0 = L_6;
	}

IL_002a:
	{
		V_0 = G_B6_0;
		V_1 = 0;
		V_2 = 0;
		goto IL_006a;
	}

IL_0031:
	{
		TBSPGJPKaXrjsOpBQZPxJnrcfSfAA_1_t92F77A2C0897D802673079FA32163CACC9FD23DE* L_7 = p6;
		int32_t L_8 = V_2;
		NullCheck(L_7);
		RuntimeObject* L_9;
		L_9 = ((  RuntimeObject* (*) (TBSPGJPKaXrjsOpBQZPxJnrcfSfAA_1_t92F77A2C0897D802673079FA32163CACC9FD23DE*, int32_t, const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->rgctx_data, 2)))(L_7, L_8, il2cpp_rgctx_method(method->rgctx_data, 2));
		V_3 = (ControllerMap_tC01A582E577E38D21EB7D87A8C040AF5DA285FB3*)L_9;
		bool L_10 = p4;
		if (!L_10)
		{
			goto IL_004b;
		}
	}
	{
		ControllerMap_tC01A582E577E38D21EB7D87A8C040AF5DA285FB3* L_11 = V_3;
		NullCheck(L_11);
		bool L_12;
		L_12 = ControllerMap_get_enabled_mA47FDF987F7A3D02B760A0F6923993074A810915(L_11, NULL);
		if (!L_12)
		{
			goto IL_0066;
		}
	}

IL_004b:
	{
		bool L_13 = p5;
		if (L_13)
		{
			goto IL_0059;
		}
	}
	{
		InputMapCategory_t309A7C800100DDCC67C5C6A69F960A1D71768111* L_14 = V_0;
		ControllerMap_tC01A582E577E38D21EB7D87A8C040AF5DA285FB3* L_15 = V_3;
		bool L_16;
		L_16 = ConflictCheckingHelper_HSvNYjKwjqmkkXAMHhkOgaGsivnQA_m95133A1C4C565019762E4A5EACF95189E3ECC306(__this, L_14, L_15, NULL);
		if (L_16)
		{
			goto IL_0066;
		}
	}

IL_0059:
	{
		int32_t L_17 = V_1;
		ControllerMap_tC01A582E577E38D21EB7D87A8C040AF5DA285FB3* L_18 = V_3;
		ActionElementMap_t0EBE3E5D3A5DF3BA6D35F8082ED2232404EFF8CF* L_19 = p3;
		bool L_20 = p4;
		NullCheck(L_18);
		int32_t L_21;
		L_21 = VirtualFuncInvoker2< int32_t, ActionElementMap_t0EBE3E5D3A5DF3BA6D35F8082ED2232404EFF8CF*, bool >::Invoke(24 /* System.Int32 Rewired.ControllerMap::RemoveElementAssignmentConflicts(Rewired.ActionElementMap,System.Boolean) */, L_18, L_19, L_20);
		V_1 = ((int32_t)il2cpp_codegen_add(L_17, L_21));
	}

IL_0066:
	{
		int32_t L_22 = V_2;
		V_2 = ((int32_t)il2cpp_codegen_add(L_22, 1));
	}

IL_006a:
	{
		int32_t L_23 = V_2;
		TBSPGJPKaXrjsOpBQZPxJnrcfSfAA_1_t92F77A2C0897D802673079FA32163CACC9FD23DE* L_24 = p6;
		NullCheck(L_24);
		int32_t L_25;
		L_25 = ((  int32_t (*) (TBSPGJPKaXrjsOpBQZPxJnrcfSfAA_1_t92F77A2C0897D802673079FA32163CACC9FD23DE*, const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->rgctx_data, 3)))(L_24, il2cpp_rgctx_method(method->rgctx_data, 3));
		if ((((int32_t)L_23) < ((int32_t)L_25)))
		{
			goto IL_0031;
		}
	}
	{
		int32_t L_26 = V_1;
		return L_26;
	}
}
// System.Int32 Rewired.Player/ControllerHelper/ConflictCheckingHelper::VaGOdHqZoxozsaVvNJDBbKLKdiWj<System.Object>(Rewired.ElementAssignmentConflictCheck,System.Boolean,System.Boolean,TBSPGJPKaXrjsOpBQZPxJnrcfSfAA`1<?>,System.Collections.Generic.List`1<Rewired.ActionElementMap>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t ConflictCheckingHelper_VaGOdHqZoxozsaVvNJDBbKLKdiWj_TisRuntimeObject_mB5EA31C720642DE95294563BDE80DB27B943DC8F_gshared (ConflictCheckingHelper_t8D707CEC57F056B87A4C68F98F780D34E893A8DB* __this, ElementAssignmentConflictCheck_tC22925257E88D3999FDD06C7ABF3B6CE6C09847E p0, bool p1, bool p2, TBSPGJPKaXrjsOpBQZPxJnrcfSfAA_1_t92F77A2C0897D802673079FA32163CACC9FD23DE* p3, List_1_t61A2C1C85DEC6157A1333F351530E22E04BDF9A6* p4, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_Clear_m2036CFD23AB93618EE6F473B3864A226AB3B519E_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
Player_t71A64CE695A2F96B144F3050755AB2799DA7C01B* V_0 = NULL;
	ControllerMap_tC01A582E577E38D21EB7D87A8C040AF5DA285FB3* V_1 = NULL;
	InputMapCategory_t309A7C800100DDCC67C5C6A69F960A1D71768111* V_2 = NULL;
	int32_t V_3 = 0;
	int32_t V_4 = 0;
	ControllerMap_tC01A582E577E38D21EB7D87A8C040AF5DA285FB3* V_5 = NULL;
	InputMapCategory_t309A7C800100DDCC67C5C6A69F960A1D71768111* G_B9_0 = NULL;
	{
		List_1_t61A2C1C85DEC6157A1333F351530E22E04BDF9A6* L_0 = p4;
		if (!L_0)
		{
			goto IL_000b;
		}
	}
	{
		List_1_t61A2C1C85DEC6157A1333F351530E22E04BDF9A6* L_1 = p4;
		NullCheck(L_1);
		List_1_Clear_m2036CFD23AB93618EE6F473B3864A226AB3B519E_inline(L_1, List_1_Clear_m2036CFD23AB93618EE6F473B3864A226AB3B519E_RuntimeMethod_var);
	}

IL_000b:
	{
		TBSPGJPKaXrjsOpBQZPxJnrcfSfAA_1_t92F77A2C0897D802673079FA32163CACC9FD23DE* L_2 = p3;
		if (L_2)
		{
			goto IL_0011;
		}
	}
	{
		return 0;
	}

IL_0011:
	{
		il2cpp_codegen_runtime_class_init_inline(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		PlayerHelper_t96BC8DE1C94717C98B253F25C7B9C82639E4BF5C* L_3;
		L_3 = ReInput_get_players_m3DDA5505CC1DB7580B0C41F1D781A284D3EACD27(NULL);
		int32_t L_4;
		L_4 = ElementAssignmentConflictCheck_get_playerId_m13D1C2C48B4AF7E87153014EE4B16491202256C5_inline((&p0), NULL);
		NullCheck(L_3);
		Player_t71A64CE695A2F96B144F3050755AB2799DA7C01B* L_5;
		L_5 = PlayerHelper_GetPlayer_m42CD1C5AC3CC96C9E36A74D680F0CEC9F5EB5FDC(L_3, L_4, NULL);
		V_0 = L_5;
		Player_t71A64CE695A2F96B144F3050755AB2799DA7C01B* L_6 = V_0;
		if (L_6)
		{
			goto IL_0028;
		}
	}
	{
		return 0;
	}

IL_0028:
	{
		Player_t71A64CE695A2F96B144F3050755AB2799DA7C01B* L_7 = V_0;
		NullCheck(L_7);
		ControllerHelper_tCE72EA23053BD0C6ECB4D75A69F8CD1B3AC28FF6* L_8 = (ControllerHelper_tCE72EA23053BD0C6ECB4D75A69F8CD1B3AC28FF6*)L_7->___controllers_7;
		NullCheck(L_8);
		MapHelper_t214BA4F045E5EB4B312E4E6AEB6697813117A7C2* L_9 = (MapHelper_t214BA4F045E5EB4B312E4E6AEB6697813117A7C2*)L_8->___maps_12;
		int32_t L_10;
		L_10 = ElementAssignmentConflictCheck_get_controllerType_mB10ABC66916B5C14CA467D3289A606AEE947FE72_inline((&p0), NULL);
		int32_t L_11;
		L_11 = ElementAssignmentConflictCheck_get_controllerId_m5C57BA2FE3D405B624E86F7DD88454ED9711954A_inline((&p0), NULL);
		int32_t L_12;
		L_12 = ElementAssignmentConflictCheck_get_controllerMapId_m4C899DB8B80BBF22D0B0CAA98E0F5330AECF1800_inline((&p0), NULL);
		NullCheck(L_9);
		ControllerMap_tC01A582E577E38D21EB7D87A8C040AF5DA285FB3* L_13;
		L_13 = MapHelper_GetMap_m7447D54D0BABDE292B5BC1AAA6F5576F29B016BE(L_9, L_10, L_11, L_12, NULL);
		V_1 = L_13;
		ControllerMap_tC01A582E577E38D21EB7D87A8C040AF5DA285FB3* L_14 = V_1;
		if (L_14)
		{
			goto IL_0064;
		}
	}
	{
		il2cpp_codegen_runtime_class_init_inline(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		MappingHelper_t18AE344473D49AF2E7133108678DD4D963699662* L_15;
		L_15 = ReInput_get_mapping_mDE6BD708754EB86C540ACCB26BFD21D1F8054554(NULL);
		int32_t L_16;
		L_16 = ElementAssignmentConflictCheck_get_controllerMapCategoryId_m0A29A78618798D54C96B3EE602E3576B899DBB99_inline((&p0), NULL);
		NullCheck(L_15);
		InputMapCategory_t309A7C800100DDCC67C5C6A69F960A1D71768111* L_17;
		L_17 = MappingHelper_GetMapCategory_m6B8082A9D9CAAB69B2EC97F6B2FCAF94C5C88DBD(L_15, L_16, NULL);
		G_B9_0 = L_17;
		goto IL_0074;
	}

IL_0064:
	{
		il2cpp_codegen_runtime_class_init_inline(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		MappingHelper_t18AE344473D49AF2E7133108678DD4D963699662* L_18;
		L_18 = ReInput_get_mapping_mDE6BD708754EB86C540ACCB26BFD21D1F8054554(NULL);
		ControllerMap_tC01A582E577E38D21EB7D87A8C040AF5DA285FB3* L_19 = V_1;
		NullCheck(L_19);
		int32_t L_20;
		L_20 = ControllerMap_get_categoryId_m4D2BD4A8373EE16C75E13CB9B5ED8941A26D2B33(L_19, NULL);
		NullCheck(L_18);
		InputMapCategory_t309A7C800100DDCC67C5C6A69F960A1D71768111* L_21;
		L_21 = MappingHelper_GetMapCategory_m6B8082A9D9CAAB69B2EC97F6B2FCAF94C5C88DBD(L_18, L_20, NULL);
		G_B9_0 = L_21;
	}

IL_0074:
	{
		V_2 = G_B9_0;
		InputMapCategory_t309A7C800100DDCC67C5C6A69F960A1D71768111* L_22 = V_2;
		if (L_22)
		{
			goto IL_007a;
		}
	}
	{
		return 0;
	}

IL_007a:
	{
		V_3 = 0;
		V_4 = 0;
		goto IL_00c0;
	}

IL_0081:
	{
		TBSPGJPKaXrjsOpBQZPxJnrcfSfAA_1_t92F77A2C0897D802673079FA32163CACC9FD23DE* L_23 = p3;
		int32_t L_24 = V_4;
		NullCheck(L_23);
		RuntimeObject* L_25;
		L_25 = ((  RuntimeObject* (*) (TBSPGJPKaXrjsOpBQZPxJnrcfSfAA_1_t92F77A2C0897D802673079FA32163CACC9FD23DE*, int32_t, const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->rgctx_data, 1)))(L_23, L_24, il2cpp_rgctx_method(method->rgctx_data, 1));
		V_5 = (ControllerMap_tC01A582E577E38D21EB7D87A8C040AF5DA285FB3*)L_25;
		bool L_26 = p1;
		if (!L_26)
		{
			goto IL_009d;
		}
	}
	{
		ControllerMap_tC01A582E577E38D21EB7D87A8C040AF5DA285FB3* L_27 = V_5;
		NullCheck(L_27);
		bool L_28;
		L_28 = ControllerMap_get_enabled_mA47FDF987F7A3D02B760A0F6923993074A810915(L_27, NULL);
		if (!L_28)
		{
			goto IL_00ba;
		}
	}

IL_009d:
	{
		bool L_29 = p2;
		if (L_29)
		{
			goto IL_00ab;
		}
	}
	{
		InputMapCategory_t309A7C800100DDCC67C5C6A69F960A1D71768111* L_30 = V_2;
		ControllerMap_tC01A582E577E38D21EB7D87A8C040AF5DA285FB3* L_31 = V_5;
		bool L_32;
		L_32 = ConflictCheckingHelper_HSvNYjKwjqmkkXAMHhkOgaGsivnQA_m95133A1C4C565019762E4A5EACF95189E3ECC306(__this, L_30, L_31, NULL);
		if (L_32)
		{
			goto IL_00ba;
		}
	}

IL_00ab:
	{
		int32_t L_33 = V_3;
		ControllerMap_tC01A582E577E38D21EB7D87A8C040AF5DA285FB3* L_34 = V_5;
		ElementAssignmentConflictCheck_tC22925257E88D3999FDD06C7ABF3B6CE6C09847E L_35 = p0;
		bool L_36 = p1;
		List_1_t61A2C1C85DEC6157A1333F351530E22E04BDF9A6* L_37 = p4;
		NullCheck(L_34);
		int32_t L_38;
		L_38 = VirtualFuncInvoker4< int32_t, ElementAssignmentConflictCheck_tC22925257E88D3999FDD06C7ABF3B6CE6C09847E, bool, List_1_t61A2C1C85DEC6157A1333F351530E22E04BDF9A6*, bool >::Invoke(28 /* System.Int32 Rewired.ControllerMap::VaGOdHqZoxozsaVvNJDBbKLKdiWj(Rewired.ElementAssignmentConflictCheck,System.Boolean,System.Collections.Generic.List`1<Rewired.ActionElementMap>,System.Boolean) */, L_34, L_35, L_36, L_37, (bool)1);
		V_3 = ((int32_t)il2cpp_codegen_add(L_33, L_38));
	}

IL_00ba:
	{
		int32_t L_39 = V_4;
		V_4 = ((int32_t)il2cpp_codegen_add(L_39, 1));
	}

IL_00c0:
	{
		int32_t L_40 = V_4;
		TBSPGJPKaXrjsOpBQZPxJnrcfSfAA_1_t92F77A2C0897D802673079FA32163CACC9FD23DE* L_41 = p3;
		NullCheck(L_41);
		int32_t L_42;
		L_42 = ((  int32_t (*) (TBSPGJPKaXrjsOpBQZPxJnrcfSfAA_1_t92F77A2C0897D802673079FA32163CACC9FD23DE*, const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->rgctx_data, 3)))(L_41, il2cpp_rgctx_method(method->rgctx_data, 3));
		if ((((int32_t)L_40) < ((int32_t)L_42)))
		{
			goto IL_0081;
		}
	}
	{
		int32_t L_43 = V_3;
		return L_43;
	}
}
// System.Int32 Rewired.Player/ControllerHelper/ConflictCheckingHelper::VaGOdHqZoxozsaVvNJDBbKLKdiWj<System.Object>(Rewired.ControllerType,System.Int32,?,System.Boolean,System.Boolean,TBSPGJPKaXrjsOpBQZPxJnrcfSfAA`1<?>,System.Collections.Generic.List`1<Rewired.ActionElementMap>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t ConflictCheckingHelper_VaGOdHqZoxozsaVvNJDBbKLKdiWj_TisRuntimeObject_m7E464955AD8F849C79953F1F8D10C4D34FE3DB04_gshared (ConflictCheckingHelper_t8D707CEC57F056B87A4C68F98F780D34E893A8DB* __this, int32_t p0, int32_t p1, RuntimeObject* p2, bool p3, bool p4, TBSPGJPKaXrjsOpBQZPxJnrcfSfAA_1_t92F77A2C0897D802673079FA32163CACC9FD23DE* p5, List_1_t61A2C1C85DEC6157A1333F351530E22E04BDF9A6* p6, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_Clear_m2036CFD23AB93618EE6F473B3864A226AB3B519E_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
InputMapCategory_t309A7C800100DDCC67C5C6A69F960A1D71768111* V_0 = NULL;
	int32_t V_1 = 0;
	int32_t V_2 = 0;
	ControllerMap_tC01A582E577E38D21EB7D87A8C040AF5DA285FB3* V_3 = NULL;
	{
		List_1_t61A2C1C85DEC6157A1333F351530E22E04BDF9A6* L_0 = p6;
		if (!L_0)
		{
			goto IL_000b;
		}
	}
	{
		List_1_t61A2C1C85DEC6157A1333F351530E22E04BDF9A6* L_1 = p6;
		NullCheck(L_1);
		List_1_Clear_m2036CFD23AB93618EE6F473B3864A226AB3B519E_inline(L_1, List_1_Clear_m2036CFD23AB93618EE6F473B3864A226AB3B519E_RuntimeMethod_var);
	}

IL_000b:
	{
		TBSPGJPKaXrjsOpBQZPxJnrcfSfAA_1_t92F77A2C0897D802673079FA32163CACC9FD23DE* L_2 = p5;
		if (!L_2)
		{
			goto IL_0017;
		}
	}
	{
		RuntimeObject* L_3 = p2;
		if (L_3)
		{
			goto IL_0019;
		}
	}

IL_0017:
	{
		return 0;
	}

IL_0019:
	{
		il2cpp_codegen_runtime_class_init_inline(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		MappingHelper_t18AE344473D49AF2E7133108678DD4D963699662* L_4;
		L_4 = ReInput_get_mapping_mDE6BD708754EB86C540ACCB26BFD21D1F8054554(NULL);
		RuntimeObject* L_5 = p2;
		NullCheck((ControllerMap_tC01A582E577E38D21EB7D87A8C040AF5DA285FB3*)L_5);
		int32_t L_6;
		L_6 = ControllerMap_get_categoryId_m4D2BD4A8373EE16C75E13CB9B5ED8941A26D2B33((ControllerMap_tC01A582E577E38D21EB7D87A8C040AF5DA285FB3*)L_5, NULL);
		NullCheck(L_4);
		InputMapCategory_t309A7C800100DDCC67C5C6A69F960A1D71768111* L_7;
		L_7 = MappingHelper_GetMapCategory_m6B8082A9D9CAAB69B2EC97F6B2FCAF94C5C88DBD(L_4, L_6, NULL);
		V_0 = L_7;
		InputMapCategory_t309A7C800100DDCC67C5C6A69F960A1D71768111* L_8 = V_0;
		if (L_8)
		{
			goto IL_0034;
		}
	}
	{
		return 0;
	}

IL_0034:
	{
		V_1 = 0;
		V_2 = 0;
		goto IL_007a;
	}

IL_003a:
	{
		TBSPGJPKaXrjsOpBQZPxJnrcfSfAA_1_t92F77A2C0897D802673079FA32163CACC9FD23DE* L_9 = p5;
		int32_t L_10 = V_2;
		NullCheck(L_9);
		RuntimeObject* L_11;
		L_11 = ((  RuntimeObject* (*) (TBSPGJPKaXrjsOpBQZPxJnrcfSfAA_1_t92F77A2C0897D802673079FA32163CACC9FD23DE*, int32_t, const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->rgctx_data, 2)))(L_9, L_10, il2cpp_rgctx_method(method->rgctx_data, 2));
		V_3 = (ControllerMap_tC01A582E577E38D21EB7D87A8C040AF5DA285FB3*)L_11;
		bool L_12 = p3;
		if (!L_12)
		{
			goto IL_0054;
		}
	}
	{
		ControllerMap_tC01A582E577E38D21EB7D87A8C040AF5DA285FB3* L_13 = V_3;
		NullCheck(L_13);
		bool L_14;
		L_14 = ControllerMap_get_enabled_mA47FDF987F7A3D02B760A0F6923993074A810915(L_13, NULL);
		if (!L_14)
		{
			goto IL_0076;
		}
	}

IL_0054:
	{
		bool L_15 = p4;
		if (L_15)
		{
			goto IL_0062;
		}
	}
	{
		InputMapCategory_t309A7C800100DDCC67C5C6A69F960A1D71768111* L_16 = V_0;
		ControllerMap_tC01A582E577E38D21EB7D87A8C040AF5DA285FB3* L_17 = V_3;
		bool L_18;
		L_18 = ConflictCheckingHelper_HSvNYjKwjqmkkXAMHhkOgaGsivnQA_m95133A1C4C565019762E4A5EACF95189E3ECC306(__this, L_16, L_17, NULL);
		if (L_18)
		{
			goto IL_0076;
		}
	}

IL_0062:
	{
		int32_t L_19 = V_1;
		ControllerMap_tC01A582E577E38D21EB7D87A8C040AF5DA285FB3* L_20 = V_3;
		RuntimeObject* L_21 = p2;
		bool L_22 = p3;
		List_1_t61A2C1C85DEC6157A1333F351530E22E04BDF9A6* L_23 = p6;
		NullCheck(L_20);
		int32_t L_24;
		L_24 = VirtualFuncInvoker4< int32_t, ControllerMap_tC01A582E577E38D21EB7D87A8C040AF5DA285FB3*, bool, List_1_t61A2C1C85DEC6157A1333F351530E22E04BDF9A6*, bool >::Invoke(26 /* System.Int32 Rewired.ControllerMap::VaGOdHqZoxozsaVvNJDBbKLKdiWj(Rewired.ControllerMap,System.Boolean,System.Collections.Generic.List`1<Rewired.ActionElementMap>,System.Boolean) */, L_20, (ControllerMap_tC01A582E577E38D21EB7D87A8C040AF5DA285FB3*)L_21, L_22, L_23, (bool)1);
		V_1 = ((int32_t)il2cpp_codegen_add(L_19, L_24));
	}

IL_0076:
	{
		int32_t L_25 = V_2;
		V_2 = ((int32_t)il2cpp_codegen_add(L_25, 1));
	}

IL_007a:
	{
		int32_t L_26 = V_2;
		TBSPGJPKaXrjsOpBQZPxJnrcfSfAA_1_t92F77A2C0897D802673079FA32163CACC9FD23DE* L_27 = p5;
		NullCheck(L_27);
		int32_t L_28;
		L_28 = ((  int32_t (*) (TBSPGJPKaXrjsOpBQZPxJnrcfSfAA_1_t92F77A2C0897D802673079FA32163CACC9FD23DE*, const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->rgctx_data, 3)))(L_27, il2cpp_rgctx_method(method->rgctx_data, 3));
		if ((((int32_t)L_26) < ((int32_t)L_28)))
		{
			goto IL_003a;
		}
	}
	{
		int32_t L_29 = V_1;
		return L_29;
	}
}
// System.Int32 Rewired.Player/ControllerHelper/ConflictCheckingHelper::VaGOdHqZoxozsaVvNJDBbKLKdiWj<System.Object>(Rewired.ControllerType,System.Int32,?,Rewired.ActionElementMap,System.Boolean,System.Boolean,TBSPGJPKaXrjsOpBQZPxJnrcfSfAA`1<?>,System.Collections.Generic.List`1<Rewired.ActionElementMap>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t ConflictCheckingHelper_VaGOdHqZoxozsaVvNJDBbKLKdiWj_TisRuntimeObject_m84E2218AE5336359635ACB3AC7DF2A12CC895FCE_gshared (ConflictCheckingHelper_t8D707CEC57F056B87A4C68F98F780D34E893A8DB* __this, int32_t p0, int32_t p1, RuntimeObject* p2, ActionElementMap_t0EBE3E5D3A5DF3BA6D35F8082ED2232404EFF8CF* p3, bool p4, bool p5, TBSPGJPKaXrjsOpBQZPxJnrcfSfAA_1_t92F77A2C0897D802673079FA32163CACC9FD23DE* p6, List_1_t61A2C1C85DEC6157A1333F351530E22E04BDF9A6* p7, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_Clear_m2036CFD23AB93618EE6F473B3864A226AB3B519E_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
InputMapCategory_t309A7C800100DDCC67C5C6A69F960A1D71768111* V_0 = NULL;
	int32_t V_1 = 0;
	int32_t V_2 = 0;
	ControllerMap_tC01A582E577E38D21EB7D87A8C040AF5DA285FB3* V_3 = NULL;
	InputMapCategory_t309A7C800100DDCC67C5C6A69F960A1D71768111* G_B8_0 = NULL;
	{
		List_1_t61A2C1C85DEC6157A1333F351530E22E04BDF9A6* L_0 = p7;
		if (!L_0)
		{
			goto IL_000b;
		}
	}
	{
		List_1_t61A2C1C85DEC6157A1333F351530E22E04BDF9A6* L_1 = p7;
		NullCheck(L_1);
		List_1_Clear_m2036CFD23AB93618EE6F473B3864A226AB3B519E_inline(L_1, List_1_Clear_m2036CFD23AB93618EE6F473B3864A226AB3B519E_RuntimeMethod_var);
	}

IL_000b:
	{
		TBSPGJPKaXrjsOpBQZPxJnrcfSfAA_1_t92F77A2C0897D802673079FA32163CACC9FD23DE* L_2 = p6;
		if (!L_2)
		{
			goto IL_0013;
		}
	}
	{
		ActionElementMap_t0EBE3E5D3A5DF3BA6D35F8082ED2232404EFF8CF* L_3 = p3;
		if (L_3)
		{
			goto IL_0015;
		}
	}

IL_0013:
	{
		return 0;
	}

IL_0015:
	{
		RuntimeObject* L_4 = p2;
		if (L_4)
		{
			goto IL_0020;
		}
	}
	{
		G_B8_0 = ((InputMapCategory_t309A7C800100DDCC67C5C6A69F960A1D71768111*)(NULL));
		goto IL_0035;
	}

IL_0020:
	{
		il2cpp_codegen_runtime_class_init_inline(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		MappingHelper_t18AE344473D49AF2E7133108678DD4D963699662* L_5;
		L_5 = ReInput_get_mapping_mDE6BD708754EB86C540ACCB26BFD21D1F8054554(NULL);
		RuntimeObject* L_6 = p2;
		NullCheck((ControllerMap_tC01A582E577E38D21EB7D87A8C040AF5DA285FB3*)L_6);
		int32_t L_7;
		L_7 = ControllerMap_get_categoryId_m4D2BD4A8373EE16C75E13CB9B5ED8941A26D2B33((ControllerMap_tC01A582E577E38D21EB7D87A8C040AF5DA285FB3*)L_6, NULL);
		NullCheck(L_5);
		InputMapCategory_t309A7C800100DDCC67C5C6A69F960A1D71768111* L_8;
		L_8 = MappingHelper_GetMapCategory_m6B8082A9D9CAAB69B2EC97F6B2FCAF94C5C88DBD(L_5, L_7, NULL);
		G_B8_0 = L_8;
	}

IL_0035:
	{
		V_0 = G_B8_0;
		V_1 = 0;
		V_2 = 0;
		goto IL_0078;
	}

IL_003c:
	{
		TBSPGJPKaXrjsOpBQZPxJnrcfSfAA_1_t92F77A2C0897D802673079FA32163CACC9FD23DE* L_9 = p6;
		int32_t L_10 = V_2;
		NullCheck(L_9);
		RuntimeObject* L_11;
		L_11 = ((  RuntimeObject* (*) (TBSPGJPKaXrjsOpBQZPxJnrcfSfAA_1_t92F77A2C0897D802673079FA32163CACC9FD23DE*, int32_t, const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->rgctx_data, 2)))(L_9, L_10, il2cpp_rgctx_method(method->rgctx_data, 2));
		V_3 = (ControllerMap_tC01A582E577E38D21EB7D87A8C040AF5DA285FB3*)L_11;
		bool L_12 = p4;
		if (!L_12)
		{
			goto IL_0056;
		}
	}
	{
		ControllerMap_tC01A582E577E38D21EB7D87A8C040AF5DA285FB3* L_13 = V_3;
		NullCheck(L_13);
		bool L_14;
		L_14 = ControllerMap_get_enabled_mA47FDF987F7A3D02B760A0F6923993074A810915(L_13, NULL);
		if (!L_14)
		{
			goto IL_0074;
		}
	}

IL_0056:
	{
		bool L_15 = p5;
		if (L_15)
		{
			goto IL_0064;
		}
	}
	{
		InputMapCategory_t309A7C800100DDCC67C5C6A69F960A1D71768111* L_16 = V_0;
		ControllerMap_tC01A582E577E38D21EB7D87A8C040AF5DA285FB3* L_17 = V_3;
		bool L_18;
		L_18 = ConflictCheckingHelper_HSvNYjKwjqmkkXAMHhkOgaGsivnQA_m95133A1C4C565019762E4A5EACF95189E3ECC306(__this, L_16, L_17, NULL);
		if (L_18)
		{
			goto IL_0074;
		}
	}

IL_0064:
	{
		int32_t L_19 = V_1;
		ControllerMap_tC01A582E577E38D21EB7D87A8C040AF5DA285FB3* L_20 = V_3;
		ActionElementMap_t0EBE3E5D3A5DF3BA6D35F8082ED2232404EFF8CF* L_21 = p3;
		bool L_22 = p4;
		List_1_t61A2C1C85DEC6157A1333F351530E22E04BDF9A6* L_23 = p7;
		NullCheck(L_20);
		int32_t L_24;
		L_24 = VirtualFuncInvoker4< int32_t, ActionElementMap_t0EBE3E5D3A5DF3BA6D35F8082ED2232404EFF8CF*, bool, List_1_t61A2C1C85DEC6157A1333F351530E22E04BDF9A6*, bool >::Invoke(27 /* System.Int32 Rewired.ControllerMap::VaGOdHqZoxozsaVvNJDBbKLKdiWj(Rewired.ActionElementMap,System.Boolean,System.Collections.Generic.List`1<Rewired.ActionElementMap>,System.Boolean) */, L_20, L_21, L_22, L_23, (bool)1);
		V_1 = ((int32_t)il2cpp_codegen_add(L_19, L_24));
	}

IL_0074:
	{
		int32_t L_25 = V_2;
		V_2 = ((int32_t)il2cpp_codegen_add(L_25, 1));
	}

IL_0078:
	{
		int32_t L_26 = V_2;
		TBSPGJPKaXrjsOpBQZPxJnrcfSfAA_1_t92F77A2C0897D802673079FA32163CACC9FD23DE* L_27 = p6;
		NullCheck(L_27);
		int32_t L_28;
		L_28 = ((  int32_t (*) (TBSPGJPKaXrjsOpBQZPxJnrcfSfAA_1_t92F77A2C0897D802673079FA32163CACC9FD23DE*, const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->rgctx_data, 3)))(L_27, il2cpp_rgctx_method(method->rgctx_data, 3));
		if ((((int32_t)L_26) < ((int32_t)L_28)))
		{
			goto IL_003c;
		}
	}
	{
		int32_t L_29 = V_1;
		return L_29;
	}
}
// System.Boolean Rewired.Player/ControllerHelper/ConflictCheckingHelper::kpgnYZBVBPyHNKSlsFcMpEhPPIHB<System.Object>(Rewired.ElementAssignmentConflictCheck,System.Boolean,System.Boolean,TBSPGJPKaXrjsOpBQZPxJnrcfSfAA`1<?>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool ConflictCheckingHelper_kpgnYZBVBPyHNKSlsFcMpEhPPIHB_TisRuntimeObject_mCAAB629B6BD2A233BE0DBB06E7DF2A5AF6B1C1A0_gshared (ConflictCheckingHelper_t8D707CEC57F056B87A4C68F98F780D34E893A8DB* __this, ElementAssignmentConflictCheck_tC22925257E88D3999FDD06C7ABF3B6CE6C09847E p0, bool p1, bool p2, TBSPGJPKaXrjsOpBQZPxJnrcfSfAA_1_t92F77A2C0897D802673079FA32163CACC9FD23DE* p3, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
Player_t71A64CE695A2F96B144F3050755AB2799DA7C01B* V_0 = NULL;
	ControllerMap_tC01A582E577E38D21EB7D87A8C040AF5DA285FB3* V_1 = NULL;
	InputMapCategory_t309A7C800100DDCC67C5C6A69F960A1D71768111* V_2 = NULL;
	int32_t V_3 = 0;
	ControllerMap_tC01A582E577E38D21EB7D87A8C040AF5DA285FB3* V_4 = NULL;
	InputMapCategory_t309A7C800100DDCC67C5C6A69F960A1D71768111* G_B7_0 = NULL;
	{
		TBSPGJPKaXrjsOpBQZPxJnrcfSfAA_1_t92F77A2C0897D802673079FA32163CACC9FD23DE* L_0 = p3;
		if (L_0)
		{
			goto IL_0006;
		}
	}
	{
		return (bool)0;
	}

IL_0006:
	{
		il2cpp_codegen_runtime_class_init_inline(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		PlayerHelper_t96BC8DE1C94717C98B253F25C7B9C82639E4BF5C* L_1;
		L_1 = ReInput_get_players_m3DDA5505CC1DB7580B0C41F1D781A284D3EACD27(NULL);
		int32_t L_2;
		L_2 = ElementAssignmentConflictCheck_get_playerId_m13D1C2C48B4AF7E87153014EE4B16491202256C5_inline((&p0), NULL);
		NullCheck(L_1);
		Player_t71A64CE695A2F96B144F3050755AB2799DA7C01B* L_3;
		L_3 = PlayerHelper_GetPlayer_m42CD1C5AC3CC96C9E36A74D680F0CEC9F5EB5FDC(L_1, L_2, NULL);
		V_0 = L_3;
		Player_t71A64CE695A2F96B144F3050755AB2799DA7C01B* L_4 = V_0;
		if (L_4)
		{
			goto IL_001d;
		}
	}
	{
		return (bool)0;
	}

IL_001d:
	{
		Player_t71A64CE695A2F96B144F3050755AB2799DA7C01B* L_5 = V_0;
		NullCheck(L_5);
		ControllerHelper_tCE72EA23053BD0C6ECB4D75A69F8CD1B3AC28FF6* L_6 = (ControllerHelper_tCE72EA23053BD0C6ECB4D75A69F8CD1B3AC28FF6*)L_5->___controllers_7;
		NullCheck(L_6);
		MapHelper_t214BA4F045E5EB4B312E4E6AEB6697813117A7C2* L_7 = (MapHelper_t214BA4F045E5EB4B312E4E6AEB6697813117A7C2*)L_6->___maps_12;
		int32_t L_8;
		L_8 = ElementAssignmentConflictCheck_get_controllerType_mB10ABC66916B5C14CA467D3289A606AEE947FE72_inline((&p0), NULL);
		int32_t L_9;
		L_9 = ElementAssignmentConflictCheck_get_controllerId_m5C57BA2FE3D405B624E86F7DD88454ED9711954A_inline((&p0), NULL);
		int32_t L_10;
		L_10 = ElementAssignmentConflictCheck_get_controllerMapId_m4C899DB8B80BBF22D0B0CAA98E0F5330AECF1800_inline((&p0), NULL);
		NullCheck(L_7);
		ControllerMap_tC01A582E577E38D21EB7D87A8C040AF5DA285FB3* L_11;
		L_11 = MapHelper_GetMap_m7447D54D0BABDE292B5BC1AAA6F5576F29B016BE(L_7, L_8, L_9, L_10, NULL);
		V_1 = L_11;
		ControllerMap_tC01A582E577E38D21EB7D87A8C040AF5DA285FB3* L_12 = V_1;
		if (L_12)
		{
			goto IL_0059;
		}
	}
	{
		il2cpp_codegen_runtime_class_init_inline(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		MappingHelper_t18AE344473D49AF2E7133108678DD4D963699662* L_13;
		L_13 = ReInput_get_mapping_mDE6BD708754EB86C540ACCB26BFD21D1F8054554(NULL);
		int32_t L_14;
		L_14 = ElementAssignmentConflictCheck_get_controllerMapCategoryId_m0A29A78618798D54C96B3EE602E3576B899DBB99_inline((&p0), NULL);
		NullCheck(L_13);
		InputMapCategory_t309A7C800100DDCC67C5C6A69F960A1D71768111* L_15;
		L_15 = MappingHelper_GetMapCategory_m6B8082A9D9CAAB69B2EC97F6B2FCAF94C5C88DBD(L_13, L_14, NULL);
		G_B7_0 = L_15;
		goto IL_0069;
	}

IL_0059:
	{
		il2cpp_codegen_runtime_class_init_inline(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		MappingHelper_t18AE344473D49AF2E7133108678DD4D963699662* L_16;
		L_16 = ReInput_get_mapping_mDE6BD708754EB86C540ACCB26BFD21D1F8054554(NULL);
		ControllerMap_tC01A582E577E38D21EB7D87A8C040AF5DA285FB3* L_17 = V_1;
		NullCheck(L_17);
		int32_t L_18;
		L_18 = ControllerMap_get_categoryId_m4D2BD4A8373EE16C75E13CB9B5ED8941A26D2B33(L_17, NULL);
		NullCheck(L_16);
		InputMapCategory_t309A7C800100DDCC67C5C6A69F960A1D71768111* L_19;
		L_19 = MappingHelper_GetMapCategory_m6B8082A9D9CAAB69B2EC97F6B2FCAF94C5C88DBD(L_16, L_18, NULL);
		G_B7_0 = L_19;
	}

IL_0069:
	{
		V_2 = G_B7_0;
		InputMapCategory_t309A7C800100DDCC67C5C6A69F960A1D71768111* L_20 = V_2;
		if (L_20)
		{
			goto IL_006f;
		}
	}
	{
		return (bool)0;
	}

IL_006f:
	{
		V_3 = 0;
		goto IL_00ad;
	}

IL_0073:
	{
		TBSPGJPKaXrjsOpBQZPxJnrcfSfAA_1_t92F77A2C0897D802673079FA32163CACC9FD23DE* L_21 = p3;
		int32_t L_22 = V_3;
		NullCheck(L_21);
		RuntimeObject* L_23;
		L_23 = ((  RuntimeObject* (*) (TBSPGJPKaXrjsOpBQZPxJnrcfSfAA_1_t92F77A2C0897D802673079FA32163CACC9FD23DE*, int32_t, const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->rgctx_data, 1)))(L_21, L_22, il2cpp_rgctx_method(method->rgctx_data, 1));
		V_4 = (ControllerMap_tC01A582E577E38D21EB7D87A8C040AF5DA285FB3*)L_23;
		bool L_24 = p1;
		if (!L_24)
		{
			goto IL_008e;
		}
	}
	{
		ControllerMap_tC01A582E577E38D21EB7D87A8C040AF5DA285FB3* L_25 = V_4;
		NullCheck(L_25);
		bool L_26;
		L_26 = ControllerMap_get_enabled_mA47FDF987F7A3D02B760A0F6923993074A810915(L_25, NULL);
		if (!L_26)
		{
			goto IL_00a9;
		}
	}

IL_008e:
	{
		bool L_27 = p2;
		if (L_27)
		{
			goto IL_009c;
		}
	}
	{
		InputMapCategory_t309A7C800100DDCC67C5C6A69F960A1D71768111* L_28 = V_2;
		ControllerMap_tC01A582E577E38D21EB7D87A8C040AF5DA285FB3* L_29 = V_4;
		bool L_30;
		L_30 = ConflictCheckingHelper_HSvNYjKwjqmkkXAMHhkOgaGsivnQA_m95133A1C4C565019762E4A5EACF95189E3ECC306(__this, L_28, L_29, NULL);
		if (L_30)
		{
			goto IL_00a9;
		}
	}

IL_009c:
	{
		ControllerMap_tC01A582E577E38D21EB7D87A8C040AF5DA285FB3* L_31 = V_4;
		ElementAssignmentConflictCheck_tC22925257E88D3999FDD06C7ABF3B6CE6C09847E L_32 = p0;
		bool L_33 = p1;
		NullCheck(L_31);
		bool L_34;
		L_34 = VirtualFuncInvoker2< bool, ElementAssignmentConflictCheck_tC22925257E88D3999FDD06C7ABF3B6CE6C09847E, bool >::Invoke(19 /* System.Boolean Rewired.ControllerMap::DoesElementAssignmentConflict(Rewired.ElementAssignmentConflictCheck,System.Boolean) */, L_31, L_32, L_33);
		if (!L_34)
		{
			goto IL_00a9;
		}
	}
	{
		return (bool)1;
	}

IL_00a9:
	{
		int32_t L_35 = V_3;
		V_3 = ((int32_t)il2cpp_codegen_add(L_35, 1));
	}

IL_00ad:
	{
		int32_t L_36 = V_3;
		TBSPGJPKaXrjsOpBQZPxJnrcfSfAA_1_t92F77A2C0897D802673079FA32163CACC9FD23DE* L_37 = p3;
		NullCheck(L_37);
		int32_t L_38;
		L_38 = ((  int32_t (*) (TBSPGJPKaXrjsOpBQZPxJnrcfSfAA_1_t92F77A2C0897D802673079FA32163CACC9FD23DE*, const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->rgctx_data, 3)))(L_37, il2cpp_rgctx_method(method->rgctx_data, 3));
		if ((((int32_t)L_36) < ((int32_t)L_38)))
		{
			goto IL_0073;
		}
	}
	{
		return (bool)0;
	}
}
// System.Boolean Rewired.Player/ControllerHelper/ConflictCheckingHelper::kpgnYZBVBPyHNKSlsFcMpEhPPIHB<System.Object>(Rewired.ControllerType,System.Int32,?,System.Boolean,System.Boolean,TBSPGJPKaXrjsOpBQZPxJnrcfSfAA`1<?>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool ConflictCheckingHelper_kpgnYZBVBPyHNKSlsFcMpEhPPIHB_TisRuntimeObject_m7B05810FFCA50BA654990036AE1FE5313AE34D04_gshared (ConflictCheckingHelper_t8D707CEC57F056B87A4C68F98F780D34E893A8DB* __this, int32_t p0, int32_t p1, RuntimeObject* p2, bool p3, bool p4, TBSPGJPKaXrjsOpBQZPxJnrcfSfAA_1_t92F77A2C0897D802673079FA32163CACC9FD23DE* p5, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
InputMapCategory_t309A7C800100DDCC67C5C6A69F960A1D71768111* V_0 = NULL;
	int32_t V_1 = 0;
	ControllerMap_tC01A582E577E38D21EB7D87A8C040AF5DA285FB3* V_2 = NULL;
	{
		TBSPGJPKaXrjsOpBQZPxJnrcfSfAA_1_t92F77A2C0897D802673079FA32163CACC9FD23DE* L_0 = p5;
		if (!L_0)
		{
			goto IL_000c;
		}
	}
	{
		RuntimeObject* L_1 = p2;
		if (L_1)
		{
			goto IL_000e;
		}
	}

IL_000c:
	{
		return (bool)0;
	}

IL_000e:
	{
		il2cpp_codegen_runtime_class_init_inline(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		MappingHelper_t18AE344473D49AF2E7133108678DD4D963699662* L_2;
		L_2 = ReInput_get_mapping_mDE6BD708754EB86C540ACCB26BFD21D1F8054554(NULL);
		RuntimeObject* L_3 = p2;
		NullCheck((ControllerMap_tC01A582E577E38D21EB7D87A8C040AF5DA285FB3*)L_3);
		int32_t L_4;
		L_4 = ControllerMap_get_categoryId_m4D2BD4A8373EE16C75E13CB9B5ED8941A26D2B33((ControllerMap_tC01A582E577E38D21EB7D87A8C040AF5DA285FB3*)L_3, NULL);
		NullCheck(L_2);
		InputMapCategory_t309A7C800100DDCC67C5C6A69F960A1D71768111* L_5;
		L_5 = MappingHelper_GetMapCategory_m6B8082A9D9CAAB69B2EC97F6B2FCAF94C5C88DBD(L_2, L_4, NULL);
		V_0 = L_5;
		InputMapCategory_t309A7C800100DDCC67C5C6A69F960A1D71768111* L_6 = V_0;
		if (L_6)
		{
			goto IL_0029;
		}
	}
	{
		return (bool)0;
	}

IL_0029:
	{
		V_1 = 0;
		goto IL_006b;
	}

IL_002d:
	{
		TBSPGJPKaXrjsOpBQZPxJnrcfSfAA_1_t92F77A2C0897D802673079FA32163CACC9FD23DE* L_7 = p5;
		int32_t L_8 = V_1;
		NullCheck(L_7);
		RuntimeObject* L_9;
		L_9 = ((  RuntimeObject* (*) (TBSPGJPKaXrjsOpBQZPxJnrcfSfAA_1_t92F77A2C0897D802673079FA32163CACC9FD23DE*, int32_t, const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->rgctx_data, 2)))(L_7, L_8, il2cpp_rgctx_method(method->rgctx_data, 2));
		V_2 = (ControllerMap_tC01A582E577E38D21EB7D87A8C040AF5DA285FB3*)L_9;
		bool L_10 = p3;
		if (!L_10)
		{
			goto IL_0047;
		}
	}
	{
		ControllerMap_tC01A582E577E38D21EB7D87A8C040AF5DA285FB3* L_11 = V_2;
		NullCheck(L_11);
		bool L_12;
		L_12 = ControllerMap_get_enabled_mA47FDF987F7A3D02B760A0F6923993074A810915(L_11, NULL);
		if (!L_12)
		{
			goto IL_0067;
		}
	}

IL_0047:
	{
		bool L_13 = p4;
		if (L_13)
		{
			goto IL_0055;
		}
	}
	{
		InputMapCategory_t309A7C800100DDCC67C5C6A69F960A1D71768111* L_14 = V_0;
		ControllerMap_tC01A582E577E38D21EB7D87A8C040AF5DA285FB3* L_15 = V_2;
		bool L_16;
		L_16 = ConflictCheckingHelper_HSvNYjKwjqmkkXAMHhkOgaGsivnQA_m95133A1C4C565019762E4A5EACF95189E3ECC306(__this, L_14, L_15, NULL);
		if (L_16)
		{
			goto IL_0067;
		}
	}

IL_0055:
	{
		ControllerMap_tC01A582E577E38D21EB7D87A8C040AF5DA285FB3* L_17 = V_2;
		RuntimeObject* L_18 = p2;
		bool L_19 = p3;
		NullCheck(L_17);
		bool L_20;
		L_20 = VirtualFuncInvoker2< bool, ControllerMap_tC01A582E577E38D21EB7D87A8C040AF5DA285FB3*, bool >::Invoke(17 /* System.Boolean Rewired.ControllerMap::DoesElementAssignmentConflict(Rewired.ControllerMap,System.Boolean) */, L_17, (ControllerMap_tC01A582E577E38D21EB7D87A8C040AF5DA285FB3*)L_18, L_19);
		if (!L_20)
		{
			goto IL_0067;
		}
	}
	{
		return (bool)1;
	}

IL_0067:
	{
		int32_t L_21 = V_1;
		V_1 = ((int32_t)il2cpp_codegen_add(L_21, 1));
	}

IL_006b:
	{
		int32_t L_22 = V_1;
		TBSPGJPKaXrjsOpBQZPxJnrcfSfAA_1_t92F77A2C0897D802673079FA32163CACC9FD23DE* L_23 = p5;
		NullCheck(L_23);
		int32_t L_24;
		L_24 = ((  int32_t (*) (TBSPGJPKaXrjsOpBQZPxJnrcfSfAA_1_t92F77A2C0897D802673079FA32163CACC9FD23DE*, const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->rgctx_data, 3)))(L_23, il2cpp_rgctx_method(method->rgctx_data, 3));
		if ((((int32_t)L_22) < ((int32_t)L_24)))
		{
			goto IL_002d;
		}
	}
	{
		return (bool)0;
	}
}
// System.Boolean Rewired.Player/ControllerHelper/ConflictCheckingHelper::kpgnYZBVBPyHNKSlsFcMpEhPPIHB<System.Object>(Rewired.ControllerType,System.Int32,?,Rewired.ActionElementMap,System.Boolean,System.Boolean,TBSPGJPKaXrjsOpBQZPxJnrcfSfAA`1<?>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool ConflictCheckingHelper_kpgnYZBVBPyHNKSlsFcMpEhPPIHB_TisRuntimeObject_mC2BE4CED45B361FC87CF82F2FF78D988AA13D116_gshared (ConflictCheckingHelper_t8D707CEC57F056B87A4C68F98F780D34E893A8DB* __this, int32_t p0, int32_t p1, RuntimeObject* p2, ActionElementMap_t0EBE3E5D3A5DF3BA6D35F8082ED2232404EFF8CF* p3, bool p4, bool p5, TBSPGJPKaXrjsOpBQZPxJnrcfSfAA_1_t92F77A2C0897D802673079FA32163CACC9FD23DE* p6, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
InputMapCategory_t309A7C800100DDCC67C5C6A69F960A1D71768111* V_0 = NULL;
	int32_t V_1 = 0;
	ControllerMap_tC01A582E577E38D21EB7D87A8C040AF5DA285FB3* V_2 = NULL;
	InputMapCategory_t309A7C800100DDCC67C5C6A69F960A1D71768111* G_B6_0 = NULL;
	{
		TBSPGJPKaXrjsOpBQZPxJnrcfSfAA_1_t92F77A2C0897D802673079FA32163CACC9FD23DE* L_0 = p6;
		if (!L_0)
		{
			goto IL_0008;
		}
	}
	{
		ActionElementMap_t0EBE3E5D3A5DF3BA6D35F8082ED2232404EFF8CF* L_1 = p3;
		if (L_1)
		{
			goto IL_000a;
		}
	}

IL_0008:
	{
		return (bool)0;
	}

IL_000a:
	{
		RuntimeObject* L_2 = p2;
		if (L_2)
		{
			goto IL_0015;
		}
	}
	{
		G_B6_0 = ((InputMapCategory_t309A7C800100DDCC67C5C6A69F960A1D71768111*)(NULL));
		goto IL_002a;
	}

IL_0015:
	{
		il2cpp_codegen_runtime_class_init_inline(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		MappingHelper_t18AE344473D49AF2E7133108678DD4D963699662* L_3;
		L_3 = ReInput_get_mapping_mDE6BD708754EB86C540ACCB26BFD21D1F8054554(NULL);
		RuntimeObject* L_4 = p2;
		NullCheck((ControllerMap_tC01A582E577E38D21EB7D87A8C040AF5DA285FB3*)L_4);
		int32_t L_5;
		L_5 = ControllerMap_get_categoryId_m4D2BD4A8373EE16C75E13CB9B5ED8941A26D2B33((ControllerMap_tC01A582E577E38D21EB7D87A8C040AF5DA285FB3*)L_4, NULL);
		NullCheck(L_3);
		InputMapCategory_t309A7C800100DDCC67C5C6A69F960A1D71768111* L_6;
		L_6 = MappingHelper_GetMapCategory_m6B8082A9D9CAAB69B2EC97F6B2FCAF94C5C88DBD(L_3, L_5, NULL);
		G_B6_0 = L_6;
	}

IL_002a:
	{
		V_0 = G_B6_0;
		V_1 = 0;
		goto IL_0069;
	}

IL_002f:
	{
		TBSPGJPKaXrjsOpBQZPxJnrcfSfAA_1_t92F77A2C0897D802673079FA32163CACC9FD23DE* L_7 = p6;
		int32_t L_8 = V_1;
		NullCheck(L_7);
		RuntimeObject* L_9;
		L_9 = ((  RuntimeObject* (*) (TBSPGJPKaXrjsOpBQZPxJnrcfSfAA_1_t92F77A2C0897D802673079FA32163CACC9FD23DE*, int32_t, const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->rgctx_data, 2)))(L_7, L_8, il2cpp_rgctx_method(method->rgctx_data, 2));
		V_2 = (ControllerMap_tC01A582E577E38D21EB7D87A8C040AF5DA285FB3*)L_9;
		bool L_10 = p4;
		if (!L_10)
		{
			goto IL_0049;
		}
	}
	{
		ControllerMap_tC01A582E577E38D21EB7D87A8C040AF5DA285FB3* L_11 = V_2;
		NullCheck(L_11);
		bool L_12;
		L_12 = ControllerMap_get_enabled_mA47FDF987F7A3D02B760A0F6923993074A810915(L_11, NULL);
		if (!L_12)
		{
			goto IL_0065;
		}
	}

IL_0049:
	{
		bool L_13 = p5;
		if (L_13)
		{
			goto IL_0057;
		}
	}
	{
		InputMapCategory_t309A7C800100DDCC67C5C6A69F960A1D71768111* L_14 = V_0;
		ControllerMap_tC01A582E577E38D21EB7D87A8C040AF5DA285FB3* L_15 = V_2;
		bool L_16;
		L_16 = ConflictCheckingHelper_HSvNYjKwjqmkkXAMHhkOgaGsivnQA_m95133A1C4C565019762E4A5EACF95189E3ECC306(__this, L_14, L_15, NULL);
		if (L_16)
		{
			goto IL_0065;
		}
	}

IL_0057:
	{
		ControllerMap_tC01A582E577E38D21EB7D87A8C040AF5DA285FB3* L_17 = V_2;
		ActionElementMap_t0EBE3E5D3A5DF3BA6D35F8082ED2232404EFF8CF* L_18 = p3;
		bool L_19 = p4;
		NullCheck(L_17);
		bool L_20;
		L_20 = VirtualFuncInvoker2< bool, ActionElementMap_t0EBE3E5D3A5DF3BA6D35F8082ED2232404EFF8CF*, bool >::Invoke(18 /* System.Boolean Rewired.ControllerMap::DoesElementAssignmentConflict(Rewired.ActionElementMap,System.Boolean) */, L_17, L_18, L_19);
		if (!L_20)
		{
			goto IL_0065;
		}
	}
	{
		return (bool)1;
	}

IL_0065:
	{
		int32_t L_21 = V_1;
		V_1 = ((int32_t)il2cpp_codegen_add(L_21, 1));
	}

IL_0069:
	{
		int32_t L_22 = V_1;
		TBSPGJPKaXrjsOpBQZPxJnrcfSfAA_1_t92F77A2C0897D802673079FA32163CACC9FD23DE* L_23 = p6;
		NullCheck(L_23);
		int32_t L_24;
		L_24 = ((  int32_t (*) (TBSPGJPKaXrjsOpBQZPxJnrcfSfAA_1_t92F77A2C0897D802673079FA32163CACC9FD23DE*, const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->rgctx_data, 3)))(L_23, il2cpp_rgctx_method(method->rgctx_data, 3));
		if ((((int32_t)L_22) < ((int32_t)L_24)))
		{
			goto IL_002f;
		}
	}
	{
		return (bool)0;
	}
}
// System.Void Rewired.Player/ControllerHelper/MapHelper::AddEmptyMap<System.Object>(System.Int32,System.Int32,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MapHelper_AddEmptyMap_TisRuntimeObject_mEAC94A50F2F91679D2B013DC324379952A206BC0_gshared (MapHelper_t214BA4F045E5EB4B312E4E6AEB6697813117A7C2* __this, int32_t ___controllerId0, int32_t ___categoryId1, int32_t ___layoutId2, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
{
		il2cpp_codegen_runtime_class_init_inline(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		int32_t L_0 = ((ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_StaticFields*)il2cpp_codegen_static_fields_for(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var))->____id_29;
		int32_t L_1 = (int32_t)__this->___eNyGUiEiMyquCTKLRhFvpeyOvzMm_5;
		if ((((int32_t)L_0) == ((int32_t)L_1)))
		{
			goto IL_001a;
		}
	}
	{
		int32_t L_2 = (int32_t)__this->___eNyGUiEiMyquCTKLRhFvpeyOvzMm_5;
		il2cpp_codegen_runtime_class_init_inline(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		bool L_3;
		L_3 = ReInput_CheckInitialized_mAAC593CB03C886BDB7B72864FBB1A59B2B0530AF(L_2, NULL);
		return;
	}

IL_001a:
	{
		int32_t L_4;
		L_4 = ((  int32_t (*) (const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->rgctx_data, 0)))(il2cpp_rgctx_method(method->rgctx_data, 0));
		int32_t L_5 = ___controllerId0;
		int32_t L_6 = ___categoryId1;
		int32_t L_7 = ___layoutId2;
		MapHelper_JumOMOwvXGOuPuOcxsTpVHdKrpWy_m1025513A8D96A8FDC1ED03E1DEAB4657987276C6(__this, L_4, L_5, L_6, L_7, NULL);
		return;
	}
}
// System.Void Rewired.Player/ControllerHelper/MapHelper::AddEmptyMap<System.Object>(System.Int32,System.String,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MapHelper_AddEmptyMap_TisRuntimeObject_m8CCF5FF7CDFD2CF14142E438AFDBC50FE6A32385_gshared (MapHelper_t214BA4F045E5EB4B312E4E6AEB6697813117A7C2* __this, int32_t ___controllerId0, String_t* ___categoryName1, String_t* ___layoutName2, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
{
		il2cpp_codegen_runtime_class_init_inline(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		int32_t L_0 = ((ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_StaticFields*)il2cpp_codegen_static_fields_for(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var))->____id_29;
		int32_t L_1 = (int32_t)__this->___eNyGUiEiMyquCTKLRhFvpeyOvzMm_5;
		if ((((int32_t)L_0) == ((int32_t)L_1)))
		{
			goto IL_001a;
		}
	}
	{
		int32_t L_2 = (int32_t)__this->___eNyGUiEiMyquCTKLRhFvpeyOvzMm_5;
		il2cpp_codegen_runtime_class_init_inline(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		bool L_3;
		L_3 = ReInput_CheckInitialized_mAAC593CB03C886BDB7B72864FBB1A59B2B0530AF(L_2, NULL);
		return;
	}

IL_001a:
	{
		int32_t L_4;
		L_4 = ((  int32_t (*) (const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->rgctx_data, 0)))(il2cpp_rgctx_method(method->rgctx_data, 0));
		int32_t L_5 = ___controllerId0;
		String_t* L_6 = ___categoryName1;
		String_t* L_7 = ___layoutName2;
		MapHelper_JumOMOwvXGOuPuOcxsTpVHdKrpWy_mED039BB84BB04F5E54C2B60E867E3C20C2AD8564(__this, L_4, L_5, L_6, L_7, NULL);
		return;
	}
}
// System.Void Rewired.Player/ControllerHelper/MapHelper::AddMap<System.Object>(System.Int32,Rewired.ControllerMap)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MapHelper_AddMap_TisRuntimeObject_mEA9313BE765503413DC3D1F1888FBF34EA3A210F_gshared (MapHelper_t214BA4F045E5EB4B312E4E6AEB6697813117A7C2* __this, int32_t ___controllerId0, ControllerMap_tC01A582E577E38D21EB7D87A8C040AF5DA285FB3* ___map1, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
{
		il2cpp_codegen_runtime_class_init_inline(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		int32_t L_0 = ((ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_StaticFields*)il2cpp_codegen_static_fields_for(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var))->____id_29;
		int32_t L_1 = (int32_t)__this->___eNyGUiEiMyquCTKLRhFvpeyOvzMm_5;
		if ((((int32_t)L_0) == ((int32_t)L_1)))
		{
			goto IL_001a;
		}
	}
	{
		int32_t L_2 = (int32_t)__this->___eNyGUiEiMyquCTKLRhFvpeyOvzMm_5;
		il2cpp_codegen_runtime_class_init_inline(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		bool L_3;
		L_3 = ReInput_CheckInitialized_mAAC593CB03C886BDB7B72864FBB1A59B2B0530AF(L_2, NULL);
		return;
	}

IL_001a:
	{
		int32_t L_4;
		L_4 = ((  int32_t (*) (const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->rgctx_data, 0)))(il2cpp_rgctx_method(method->rgctx_data, 0));
		int32_t L_5 = ___controllerId0;
		ControllerMap_tC01A582E577E38D21EB7D87A8C040AF5DA285FB3* L_6 = ___map1;
		MapHelper_eARszvxUDfRQEHAaHAQfkQChFPGDb_m2F43D7FDFDEE1F636EDEC7226B9953E64C57F7E0(__this, L_4, L_5, L_6, (int32_t)0, NULL);
		return;
	}
}
// System.Void Rewired.Player/ControllerHelper/MapHelper::AddMap<System.Object>(System.Int32,Rewired.ControllerMap,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MapHelper_AddMap_TisRuntimeObject_m1D71D752AEB5D9BD0165ABC1AA55E0FD25FE4FEF_gshared (MapHelper_t214BA4F045E5EB4B312E4E6AEB6697813117A7C2* __this, int32_t ___controllerId0, ControllerMap_tC01A582E577E38D21EB7D87A8C040AF5DA285FB3* ___map1, bool ___startEnabled2, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
ControllerMap_tC01A582E577E38D21EB7D87A8C040AF5DA285FB3* G_B4_0 = NULL;
	int32_t G_B4_1 = 0;
	int32_t G_B4_2 = 0;
	MapHelper_t214BA4F045E5EB4B312E4E6AEB6697813117A7C2* G_B4_3 = NULL;
	ControllerMap_tC01A582E577E38D21EB7D87A8C040AF5DA285FB3* G_B3_0 = NULL;
	int32_t G_B3_1 = 0;
	int32_t G_B3_2 = 0;
	MapHelper_t214BA4F045E5EB4B312E4E6AEB6697813117A7C2* G_B3_3 = NULL;
	int32_t G_B5_0 = 0;
	ControllerMap_tC01A582E577E38D21EB7D87A8C040AF5DA285FB3* G_B5_1 = NULL;
	int32_t G_B5_2 = 0;
	int32_t G_B5_3 = 0;
	MapHelper_t214BA4F045E5EB4B312E4E6AEB6697813117A7C2* G_B5_4 = NULL;
	{
		il2cpp_codegen_runtime_class_init_inline(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		int32_t L_0 = ((ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_StaticFields*)il2cpp_codegen_static_fields_for(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var))->____id_29;
		int32_t L_1 = (int32_t)__this->___eNyGUiEiMyquCTKLRhFvpeyOvzMm_5;
		if ((((int32_t)L_0) == ((int32_t)L_1)))
		{
			goto IL_001a;
		}
	}
	{
		int32_t L_2 = (int32_t)__this->___eNyGUiEiMyquCTKLRhFvpeyOvzMm_5;
		il2cpp_codegen_runtime_class_init_inline(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		bool L_3;
		L_3 = ReInput_CheckInitialized_mAAC593CB03C886BDB7B72864FBB1A59B2B0530AF(L_2, NULL);
		return;
	}

IL_001a:
	{
		int32_t L_4;
		L_4 = ((  int32_t (*) (const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->rgctx_data, 0)))(il2cpp_rgctx_method(method->rgctx_data, 0));
		int32_t L_5 = ___controllerId0;
		ControllerMap_tC01A582E577E38D21EB7D87A8C040AF5DA285FB3* L_6 = ___map1;
		bool L_7 = ___startEnabled2;
		G_B3_0 = L_6;
		G_B3_1 = L_5;
		G_B3_2 = L_4;
		G_B3_3 = __this;
		if (L_7)
		{
			G_B4_0 = L_6;
			G_B4_1 = L_5;
			G_B4_2 = L_4;
			G_B4_3 = __this;
			goto IL_0028;
		}
	}
	{
		G_B5_0 = 2;
		G_B5_1 = G_B3_0;
		G_B5_2 = G_B3_1;
		G_B5_3 = G_B3_2;
		G_B5_4 = G_B3_3;
		goto IL_0029;
	}

IL_0028:
	{
		G_B5_0 = 1;
		G_B5_1 = G_B4_0;
		G_B5_2 = G_B4_1;
		G_B5_3 = G_B4_2;
		G_B5_4 = G_B4_3;
	}

IL_0029:
	{
		NullCheck(G_B5_4);
		MapHelper_eARszvxUDfRQEHAaHAQfkQChFPGDb_m2F43D7FDFDEE1F636EDEC7226B9953E64C57F7E0(G_B5_4, G_B5_3, G_B5_2, G_B5_1, (int32_t)G_B5_0, NULL);
		return;
	}
}
// System.Boolean Rewired.Player/ControllerHelper/MapHelper::AddMapFromJson<System.Object>(System.Int32,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool MapHelper_AddMapFromJson_TisRuntimeObject_m198AC6D0033F40F4794599C0B8471EA84A71199D_gshared (MapHelper_t214BA4F045E5EB4B312E4E6AEB6697813117A7C2* __this, int32_t ___controllerId0, String_t* ___jsonString1, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
{
		il2cpp_codegen_runtime_class_init_inline(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		int32_t L_0 = ((ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_StaticFields*)il2cpp_codegen_static_fields_for(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var))->____id_29;
		int32_t L_1 = (int32_t)__this->___eNyGUiEiMyquCTKLRhFvpeyOvzMm_5;
		if ((((int32_t)L_0) == ((int32_t)L_1)))
		{
			goto IL_001b;
		}
	}
	{
		int32_t L_2 = (int32_t)__this->___eNyGUiEiMyquCTKLRhFvpeyOvzMm_5;
		il2cpp_codegen_runtime_class_init_inline(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		bool L_3;
		L_3 = ReInput_CheckInitialized_mAAC593CB03C886BDB7B72864FBB1A59B2B0530AF(L_2, NULL);
		return (bool)0;
	}

IL_001b:
	{
		int32_t L_4;
		L_4 = ((  int32_t (*) (const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->rgctx_data, 0)))(il2cpp_rgctx_method(method->rgctx_data, 0));
		int32_t L_5 = ___controllerId0;
		String_t* L_6 = ___jsonString1;
		bool L_7;
		L_7 = MapHelper_ogIOwmXsniAMouscEmnvbvCsvknx_m5CF220DABA9A843745BB5108753BD9DBE734F696(__this, L_4, L_5, L_6, NULL);
		return L_7;
	}
}
// System.Boolean Rewired.Player/ControllerHelper/MapHelper::AddMapFromXml<System.Object>(System.Int32,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool MapHelper_AddMapFromXml_TisRuntimeObject_m58C70D09D3DFBC0D6D26AB633C40F7C0F278B721_gshared (MapHelper_t214BA4F045E5EB4B312E4E6AEB6697813117A7C2* __this, int32_t ___controllerId0, String_t* ___xmlString1, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
{
		il2cpp_codegen_runtime_class_init_inline(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		int32_t L_0 = ((ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_StaticFields*)il2cpp_codegen_static_fields_for(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var))->____id_29;
		int32_t L_1 = (int32_t)__this->___eNyGUiEiMyquCTKLRhFvpeyOvzMm_5;
		if ((((int32_t)L_0) == ((int32_t)L_1)))
		{
			goto IL_001b;
		}
	}
	{
		int32_t L_2 = (int32_t)__this->___eNyGUiEiMyquCTKLRhFvpeyOvzMm_5;
		il2cpp_codegen_runtime_class_init_inline(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		bool L_3;
		L_3 = ReInput_CheckInitialized_mAAC593CB03C886BDB7B72864FBB1A59B2B0530AF(L_2, NULL);
		return (bool)0;
	}

IL_001b:
	{
		int32_t L_4;
		L_4 = ((  int32_t (*) (const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->rgctx_data, 0)))(il2cpp_rgctx_method(method->rgctx_data, 0));
		int32_t L_5 = ___controllerId0;
		String_t* L_6 = ___xmlString1;
		bool L_7;
		L_7 = MapHelper_vsoXxjlyQkRgSJiWizMXuCTWvcQQ_m6A031FB42A3792160FDB353B488EA5710A8CDC40(__this, L_4, L_5, L_6, NULL);
		return L_7;
	}
}
// System.Int32 Rewired.Player/ControllerHelper/MapHelper::AddMapsFromJson<System.Object>(System.Int32,System.Collections.Generic.List`1<System.String>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t MapHelper_AddMapsFromJson_TisRuntimeObject_m5844BCC05930030C0C6D2DF3808C9355B5E6F11E_gshared (MapHelper_t214BA4F045E5EB4B312E4E6AEB6697813117A7C2* __this, int32_t ___controllerId0, List_1_tF470A3BE5C1B5B68E1325EF3F109D172E60BD7CD* ___jsonStrings1, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_get_Count_mB63183A9151F4345A9DD444A7CBE0D6E03F77C7C_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_get_Item_m21AEC50E791371101DC22ABCF96A2E46800811F8_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
int32_t V_0 = 0;
	int32_t V_1 = 0;
	{
		il2cpp_codegen_runtime_class_init_inline(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		int32_t L_0 = ((ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_StaticFields*)il2cpp_codegen_static_fields_for(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var))->____id_29;
		int32_t L_1 = (int32_t)__this->___eNyGUiEiMyquCTKLRhFvpeyOvzMm_5;
		if ((((int32_t)L_0) == ((int32_t)L_1)))
		{
			goto IL_001b;
		}
	}
	{
		int32_t L_2 = (int32_t)__this->___eNyGUiEiMyquCTKLRhFvpeyOvzMm_5;
		il2cpp_codegen_runtime_class_init_inline(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		bool L_3;
		L_3 = ReInput_CheckInitialized_mAAC593CB03C886BDB7B72864FBB1A59B2B0530AF(L_2, NULL);
		return 0;
	}

IL_001b:
	{
		List_1_tF470A3BE5C1B5B68E1325EF3F109D172E60BD7CD* L_4 = ___jsonStrings1;
		if (L_4)
		{
			goto IL_0020;
		}
	}
	{
		return 0;
	}

IL_0020:
	{
		V_0 = 0;
		V_1 = 0;
		goto IL_003e;
	}

IL_0026:
	{
		int32_t L_5 = ___controllerId0;
		List_1_tF470A3BE5C1B5B68E1325EF3F109D172E60BD7CD* L_6 = ___jsonStrings1;
		int32_t L_7 = V_1;
		NullCheck(L_6);
		String_t* L_8;
		L_8 = List_1_get_Item_m21AEC50E791371101DC22ABCF96A2E46800811F8(L_6, L_7, List_1_get_Item_m21AEC50E791371101DC22ABCF96A2E46800811F8_RuntimeMethod_var);
		bool L_9;
		L_9 = ((  bool (*) (MapHelper_t214BA4F045E5EB4B312E4E6AEB6697813117A7C2*, int32_t, String_t*, const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->rgctx_data, 0)))(__this, L_5, L_8, il2cpp_rgctx_method(method->rgctx_data, 0));
		if (!L_9)
		{
			goto IL_003a;
		}
	}
	{
		int32_t L_10 = V_0;
		V_0 = ((int32_t)il2cpp_codegen_add(L_10, 1));
	}

IL_003a:
	{
		int32_t L_11 = V_1;
		V_1 = ((int32_t)il2cpp_codegen_add(L_11, 1));
	}

IL_003e:
	{
		int32_t L_12 = V_1;
		List_1_tF470A3BE5C1B5B68E1325EF3F109D172E60BD7CD* L_13 = ___jsonStrings1;
		NullCheck(L_13);
		int32_t L_14;
		L_14 = List_1_get_Count_mB63183A9151F4345A9DD444A7CBE0D6E03F77C7C_inline(L_13, List_1_get_Count_mB63183A9151F4345A9DD444A7CBE0D6E03F77C7C_RuntimeMethod_var);
		if ((((int32_t)L_12) < ((int32_t)L_14)))
		{
			goto IL_0026;
		}
	}
	{
		int32_t L_15 = V_0;
		return L_15;
	}
}
// System.Int32 Rewired.Player/ControllerHelper/MapHelper::AddMapsFromXml<System.Object>(System.Int32,System.Collections.Generic.List`1<System.String>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t MapHelper_AddMapsFromXml_TisRuntimeObject_m41EA4B5B9FB7A26DFF6EA7CF5219B882D605E2D4_gshared (MapHelper_t214BA4F045E5EB4B312E4E6AEB6697813117A7C2* __this, int32_t ___controllerId0, List_1_tF470A3BE5C1B5B68E1325EF3F109D172E60BD7CD* ___xmlStrings1, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_get_Count_mB63183A9151F4345A9DD444A7CBE0D6E03F77C7C_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_get_Item_m21AEC50E791371101DC22ABCF96A2E46800811F8_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
int32_t V_0 = 0;
	int32_t V_1 = 0;
	{
		il2cpp_codegen_runtime_class_init_inline(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		int32_t L_0 = ((ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_StaticFields*)il2cpp_codegen_static_fields_for(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var))->____id_29;
		int32_t L_1 = (int32_t)__this->___eNyGUiEiMyquCTKLRhFvpeyOvzMm_5;
		if ((((int32_t)L_0) == ((int32_t)L_1)))
		{
			goto IL_001b;
		}
	}
	{
		int32_t L_2 = (int32_t)__this->___eNyGUiEiMyquCTKLRhFvpeyOvzMm_5;
		il2cpp_codegen_runtime_class_init_inline(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		bool L_3;
		L_3 = ReInput_CheckInitialized_mAAC593CB03C886BDB7B72864FBB1A59B2B0530AF(L_2, NULL);
		return 0;
	}

IL_001b:
	{
		List_1_tF470A3BE5C1B5B68E1325EF3F109D172E60BD7CD* L_4 = ___xmlStrings1;
		if (L_4)
		{
			goto IL_0020;
		}
	}
	{
		return 0;
	}

IL_0020:
	{
		V_0 = 0;
		V_1 = 0;
		goto IL_003e;
	}

IL_0026:
	{
		int32_t L_5 = ___controllerId0;
		List_1_tF470A3BE5C1B5B68E1325EF3F109D172E60BD7CD* L_6 = ___xmlStrings1;
		int32_t L_7 = V_1;
		NullCheck(L_6);
		String_t* L_8;
		L_8 = List_1_get_Item_m21AEC50E791371101DC22ABCF96A2E46800811F8(L_6, L_7, List_1_get_Item_m21AEC50E791371101DC22ABCF96A2E46800811F8_RuntimeMethod_var);
		bool L_9;
		L_9 = ((  bool (*) (MapHelper_t214BA4F045E5EB4B312E4E6AEB6697813117A7C2*, int32_t, String_t*, const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->rgctx_data, 0)))(__this, L_5, L_8, il2cpp_rgctx_method(method->rgctx_data, 0));
		if (!L_9)
		{
			goto IL_003a;
		}
	}
	{
		int32_t L_10 = V_0;
		V_0 = ((int32_t)il2cpp_codegen_add(L_10, 1));
	}

IL_003a:
	{
		int32_t L_11 = V_1;
		V_1 = ((int32_t)il2cpp_codegen_add(L_11, 1));
	}

IL_003e:
	{
		int32_t L_12 = V_1;
		List_1_tF470A3BE5C1B5B68E1325EF3F109D172E60BD7CD* L_13 = ___xmlStrings1;
		NullCheck(L_13);
		int32_t L_14;
		L_14 = List_1_get_Count_mB63183A9151F4345A9DD444A7CBE0D6E03F77C7C_inline(L_13, List_1_get_Count_mB63183A9151F4345A9DD444A7CBE0D6E03F77C7C_RuntimeMethod_var);
		if ((((int32_t)L_12) < ((int32_t)L_14)))
		{
			goto IL_0026;
		}
	}
	{
		int32_t L_15 = V_0;
		return L_15;
	}
}
// ?[] Rewired.Player/ControllerHelper/MapHelper::BxVrdQsklySKzvdpWIubABxzIpfdA<System.Object>(System.Int32,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* MapHelper_BxVrdQsklySKzvdpWIubABxzIpfdA_TisRuntimeObject_m88E469DFBA4D5C25E29638A863B1592917CFD73C_gshared (MapHelper_t214BA4F045E5EB4B312E4E6AEB6697813117A7C2* __this, int32_t p0, bool p1, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ccKIYWnZwPjlGgvjpHVACPHqZTWG_t7AB72F4748B9EC6B1975F90F35E5838740AD2011_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ftuHLSCvHbrPYKqmDICMGujVuqLSA_tD67CC6A3A416E57262B63617FA5896CF7BF4F187_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&hDTwQOONkmiSaaPHwqpfFkmXMCAbb_tE1CD926FAF554AEBC6AFFC839A4294D64BE76AC3_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
int32_t V_0 = 0;
	RuntimeObject* V_1 = NULL;
	int32_t V_2 = 0;
	List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D* V_3 = NULL;
	RuntimeObject* V_4 = NULL;
	int32_t V_5 = 0;
	ControllerMap_tC01A582E577E38D21EB7D87A8C040AF5DA285FB3* V_6 = NULL;
	Controller_t919A4A50FC7A0F25D7B31615C0F4E4D4A4D17911* V_7 = NULL;
	InputMapCategory_t309A7C800100DDCC67C5C6A69F960A1D71768111* V_8 = NULL;
	{
		int32_t L_0;
		L_0 = ((  int32_t (*) (const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->rgctx_data, 0)))(il2cpp_rgctx_method(method->rgctx_data, 0));
		V_0 = L_0;
		ControllerHelper_tCE72EA23053BD0C6ECB4D75A69F8CD1B3AC28FF6* L_1 = (ControllerHelper_tCE72EA23053BD0C6ECB4D75A69F8CD1B3AC28FF6*)__this->___JOhXpftGzsqKykxdovItahCXjNZ_2;
		NullCheck(L_1);
		vpfVMfLDNQCKabtrXuyMMndafvvoA_t24DAE63535EED93A1490AC97901F2551704D116D* L_2 = (vpfVMfLDNQCKabtrXuyMMndafvvoA_t24DAE63535EED93A1490AC97901F2551704D116D*)L_1->___rGIwSbUPDgDDJByCitUBBGoZDlmc_0;
		int32_t L_3 = V_0;
		NullCheck(L_2);
		RuntimeObject* L_4;
		L_4 = vpfVMfLDNQCKabtrXuyMMndafvvoA_OlLACmpwoMamrxMTFzLaRnppBEGFA_m7D256F4AAE84410B2D3EC0217ADB4B49A6AE0B9F(L_2, L_3, NULL);
		V_1 = L_4;
		RuntimeObject* L_5 = V_1;
		int32_t L_6 = p0;
		NullCheck(L_5);
		int32_t L_7;
		L_7 = InterfaceFuncInvoker1< int32_t, int32_t >::Invoke(11 /* System.Int32 Rewired.Player/ControllerHelper/ftuHLSCvHbrPYKqmDICMGujVuqLSA::LFBHpqbppIulyYiNTvRYfiNwKOGN(System.Int32) */, ftuHLSCvHbrPYKqmDICMGujVuqLSA_tD67CC6A3A416E57262B63617FA5896CF7BF4F187_il2cpp_TypeInfo_var, L_5, L_6);
		V_2 = L_7;
		int32_t L_8 = V_2;
		if ((((int32_t)L_8) >= ((int32_t)0)))
		{
			goto IL_0026;
		}
	}
	{
		return (ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918*)NULL;
	}

IL_0026:
	{
		List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D* L_9 = (List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D*)il2cpp_codegen_object_new(il2cpp_rgctx_data(method->rgctx_data, 1));
		List_1__ctor_m7F078BB342729BDF11327FD89D7872265328F690(L_9, /*hidden argument*/il2cpp_rgctx_method(method->rgctx_data, 2));
		V_3 = L_9;
		RuntimeObject* L_10 = V_1;
		int32_t L_11 = V_2;
		NullCheck(L_10);
		RuntimeObject* L_12;
		L_12 = InterfaceFuncInvoker1< RuntimeObject*, int32_t >::Invoke(0 /* Rewired.Player/ControllerHelper/ccKIYWnZwPjlGgvjpHVACPHqZTWG Rewired.Player/ControllerHelper/ftuHLSCvHbrPYKqmDICMGujVuqLSA::ZfIXNjSNQNQjmCdAUEIsaOrcLoPs(System.Int32) */, ftuHLSCvHbrPYKqmDICMGujVuqLSA_tD67CC6A3A416E57262B63617FA5896CF7BF4F187_il2cpp_TypeInfo_var, L_10, L_11);
		NullCheck(L_12);
		RuntimeObject* L_13;
		L_13 = InterfaceFuncInvoker0< RuntimeObject* >::Invoke(0 /* hDTwQOONkmiSaaPHwqpfFkmXMCAbb Rewired.Player/ControllerHelper/ccKIYWnZwPjlGgvjpHVACPHqZTWG::DJykFGUxbFlHMIneTwfokcsefclu() */, ccKIYWnZwPjlGgvjpHVACPHqZTWG_t7AB72F4748B9EC6B1975F90F35E5838740AD2011_il2cpp_TypeInfo_var, L_12);
		V_4 = L_13;
		V_5 = 0;
		goto IL_0090;
	}

IL_003f:
	{
		RuntimeObject* L_14 = V_4;
		int32_t L_15 = V_5;
		NullCheck(L_14);
		ControllerMap_tC01A582E577E38D21EB7D87A8C040AF5DA285FB3* L_16;
		L_16 = InterfaceFuncInvoker1< ControllerMap_tC01A582E577E38D21EB7D87A8C040AF5DA285FB3*, int32_t >::Invoke(0 /* Rewired.ControllerMap hDTwQOONkmiSaaPHwqpfFkmXMCAbb::ZfIXNjSNQNQjmCdAUEIsaOrcLoPs(System.Int32) */, hDTwQOONkmiSaaPHwqpfFkmXMCAbb_tE1CD926FAF554AEBC6AFFC839A4294D64BE76AC3_il2cpp_TypeInfo_var, L_14, L_15);
		V_6 = L_16;
		bool L_17 = p1;
		if (!L_17)
		{
			goto IL_006d;
		}
	}
	{
		il2cpp_codegen_runtime_class_init_inline(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		MappingHelper_t18AE344473D49AF2E7133108678DD4D963699662* L_18;
		L_18 = ReInput_get_mapping_mDE6BD708754EB86C540ACCB26BFD21D1F8054554(NULL);
		ControllerMap_tC01A582E577E38D21EB7D87A8C040AF5DA285FB3* L_19 = V_6;
		NullCheck(L_19);
		int32_t L_20;
		L_20 = ControllerMap_get_categoryId_m4D2BD4A8373EE16C75E13CB9B5ED8941A26D2B33(L_19, NULL);
		NullCheck(L_18);
		InputMapCategory_t309A7C800100DDCC67C5C6A69F960A1D71768111* L_21;
		L_21 = MappingHelper_GetMapCategory_m6B8082A9D9CAAB69B2EC97F6B2FCAF94C5C88DBD(L_18, L_20, NULL);
		V_8 = L_21;
		InputMapCategory_t309A7C800100DDCC67C5C6A69F960A1D71768111* L_22 = V_8;
		if (!L_22)
		{
			goto IL_006d;
		}
	}
	{
		InputMapCategory_t309A7C800100DDCC67C5C6A69F960A1D71768111* L_23 = V_8;
		NullCheck((InputCategory_t9C22614C15FBDA3F98B6F03EA3CEB547BF5F373C*)L_23);
		bool L_24;
		L_24 = InputCategory_get_userAssignable_mBD58AC35EE83AAE55914DC85584314585326C703_inline((InputCategory_t9C22614C15FBDA3F98B6F03EA3CEB547BF5F373C*)L_23, NULL);
		if (!L_24)
		{
			goto IL_008a;
		}
	}

IL_006d:
	{
		RuntimeObject* L_25 = V_1;
		int32_t L_26 = V_2;
		NullCheck(L_25);
		RuntimeObject* L_27;
		L_27 = InterfaceFuncInvoker1< RuntimeObject*, int32_t >::Invoke(0 /* Rewired.Player/ControllerHelper/ccKIYWnZwPjlGgvjpHVACPHqZTWG Rewired.Player/ControllerHelper/ftuHLSCvHbrPYKqmDICMGujVuqLSA::ZfIXNjSNQNQjmCdAUEIsaOrcLoPs(System.Int32) */, ftuHLSCvHbrPYKqmDICMGujVuqLSA_tD67CC6A3A416E57262B63617FA5896CF7BF4F187_il2cpp_TypeInfo_var, L_25, L_26);
		NullCheck(L_27);
		Controller_t919A4A50FC7A0F25D7B31615C0F4E4D4A4D17911* L_28;
		L_28 = InterfaceFuncInvoker0< Controller_t919A4A50FC7A0F25D7B31615C0F4E4D4A4D17911* >::Invoke(1 /* Rewired.Controller Rewired.Player/ControllerHelper/ccKIYWnZwPjlGgvjpHVACPHqZTWG::ozNcfmyISWkqVPVfvPOfROcWRfsf() */, ccKIYWnZwPjlGgvjpHVACPHqZTWG_t7AB72F4748B9EC6B1975F90F35E5838740AD2011_il2cpp_TypeInfo_var, L_27);
		V_7 = L_28;
		List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D* L_29 = V_3;
		Controller_t919A4A50FC7A0F25D7B31615C0F4E4D4A4D17911* L_30 = V_7;
		ControllerMap_tC01A582E577E38D21EB7D87A8C040AF5DA285FB3* L_31 = V_6;
		RuntimeObject* L_32;
		L_32 = ((  RuntimeObject* (*) (Controller_t919A4A50FC7A0F25D7B31615C0F4E4D4A4D17911*, ControllerMap_tC01A582E577E38D21EB7D87A8C040AF5DA285FB3*, const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->rgctx_data, 3)))(L_30, L_31, il2cpp_rgctx_method(method->rgctx_data, 3));
		NullCheck(L_29);
		((  void (*) (List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D*, RuntimeObject*, const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->rgctx_data, 4)))(L_29, L_32, il2cpp_rgctx_method(method->rgctx_data, 4));
	}

IL_008a:
	{
		int32_t L_33 = V_5;
		V_5 = ((int32_t)il2cpp_codegen_add(L_33, 1));
	}

IL_0090:
	{
		int32_t L_34 = V_5;
		RuntimeObject* L_35 = V_4;
		NullCheck(L_35);
		int32_t L_36;
		L_36 = InterfaceFuncInvoker0< int32_t >::Invoke(1 /* System.Int32 hDTwQOONkmiSaaPHwqpfFkmXMCAbb::NEFjFYSXjpJmKUMrQuBCmBemjvSFA() */, hDTwQOONkmiSaaPHwqpfFkmXMCAbb_tE1CD926FAF554AEBC6AFFC839A4294D64BE76AC3_il2cpp_TypeInfo_var, L_35);
		if ((((int32_t)L_34) < ((int32_t)L_36)))
		{
			goto IL_003f;
		}
	}
	{
		List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D* L_37 = V_3;
		NullCheck(L_37);
		ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* L_38;
		L_38 = ((  ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* (*) (List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D*, const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->rgctx_data, 5)))(L_37, il2cpp_rgctx_method(method->rgctx_data, 5));
		return L_38;
	}
}
// System.Void Rewired.Player/ControllerHelper/MapHelper::ClearMaps<System.Object>(System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MapHelper_ClearMaps_TisRuntimeObject_mFE0F2F27E7E5E506026446A6EBDFEFE72B5E3B2D_gshared (MapHelper_t214BA4F045E5EB4B312E4E6AEB6697813117A7C2* __this, bool ___userAssignableOnly0, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
{
		il2cpp_codegen_runtime_class_init_inline(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		int32_t L_0 = ((ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_StaticFields*)il2cpp_codegen_static_fields_for(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var))->____id_29;
		int32_t L_1 = (int32_t)__this->___eNyGUiEiMyquCTKLRhFvpeyOvzMm_5;
		if ((((int32_t)L_0) == ((int32_t)L_1)))
		{
			goto IL_001a;
		}
	}
	{
		int32_t L_2 = (int32_t)__this->___eNyGUiEiMyquCTKLRhFvpeyOvzMm_5;
		il2cpp_codegen_runtime_class_init_inline(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		bool L_3;
		L_3 = ReInput_CheckInitialized_mAAC593CB03C886BDB7B72864FBB1A59B2B0530AF(L_2, NULL);
		return;
	}

IL_001a:
	{
		int32_t L_4;
		L_4 = ((  int32_t (*) (const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->rgctx_data, 0)))(il2cpp_rgctx_method(method->rgctx_data, 0));
		bool L_5 = ___userAssignableOnly0;
		MapHelper_ClearMaps_mE9839E66C615927C4E053CF3A89BF6C85E98614C(__this, L_4, L_5, NULL);
		return;
	}
}
// System.Void Rewired.Player/ControllerHelper/MapHelper::ClearMapsForController<System.Object>(System.Int32,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MapHelper_ClearMapsForController_TisRuntimeObject_m7B52119079028DB2A11BF8805E6083011301576E_gshared (MapHelper_t214BA4F045E5EB4B312E4E6AEB6697813117A7C2* __this, int32_t ___controllerId0, bool ___userAssignableOnly1, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
{
		il2cpp_codegen_runtime_class_init_inline(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		int32_t L_0 = ((ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_StaticFields*)il2cpp_codegen_static_fields_for(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var))->____id_29;
		int32_t L_1 = (int32_t)__this->___eNyGUiEiMyquCTKLRhFvpeyOvzMm_5;
		if ((((int32_t)L_0) == ((int32_t)L_1)))
		{
			goto IL_001a;
		}
	}
	{
		int32_t L_2 = (int32_t)__this->___eNyGUiEiMyquCTKLRhFvpeyOvzMm_5;
		il2cpp_codegen_runtime_class_init_inline(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		bool L_3;
		L_3 = ReInput_CheckInitialized_mAAC593CB03C886BDB7B72864FBB1A59B2B0530AF(L_2, NULL);
		return;
	}

IL_001a:
	{
		int32_t L_4;
		L_4 = ((  int32_t (*) (const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->rgctx_data, 0)))(il2cpp_rgctx_method(method->rgctx_data, 0));
		int32_t L_5 = ___controllerId0;
		bool L_6 = ___userAssignableOnly1;
		MapHelper_ClearMapsForController_m0AF8A2D1031EA3A7299F1384656833D0E0996200(__this, L_4, L_5, L_6, NULL);
		return;
	}
}
// System.Void Rewired.Player/ControllerHelper/MapHelper::ClearMapsForController<System.Object>(System.Int32,System.Int32,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MapHelper_ClearMapsForController_TisRuntimeObject_m9E9FF700CA6E02C3C40CF6E4E9423E38CB3FA85C_gshared (MapHelper_t214BA4F045E5EB4B312E4E6AEB6697813117A7C2* __this, int32_t ___controllerId0, int32_t ___categoryId1, bool ___userAssignableOnly2, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
{
		il2cpp_codegen_runtime_class_init_inline(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		int32_t L_0 = ((ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_StaticFields*)il2cpp_codegen_static_fields_for(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var))->____id_29;
		int32_t L_1 = (int32_t)__this->___eNyGUiEiMyquCTKLRhFvpeyOvzMm_5;
		if ((((int32_t)L_0) == ((int32_t)L_1)))
		{
			goto IL_001a;
		}
	}
	{
		int32_t L_2 = (int32_t)__this->___eNyGUiEiMyquCTKLRhFvpeyOvzMm_5;
		il2cpp_codegen_runtime_class_init_inline(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		bool L_3;
		L_3 = ReInput_CheckInitialized_mAAC593CB03C886BDB7B72864FBB1A59B2B0530AF(L_2, NULL);
		return;
	}

IL_001a:
	{
		int32_t L_4;
		L_4 = ((  int32_t (*) (const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->rgctx_data, 0)))(il2cpp_rgctx_method(method->rgctx_data, 0));
		int32_t L_5 = ___controllerId0;
		int32_t L_6 = ___categoryId1;
		bool L_7 = ___userAssignableOnly2;
		MapHelper_ClearMapsForController_mC11D4A3C112748E4A510469C5FB6AC10950EF667(__this, L_4, L_5, L_6, L_7, NULL);
		return;
	}
}
// System.Void Rewired.Player/ControllerHelper/MapHelper::ClearMapsForController<System.Object>(System.Int32,System.String,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MapHelper_ClearMapsForController_TisRuntimeObject_m23566A46B28A3EABC254F1448A78BF61594DF3DF_gshared (MapHelper_t214BA4F045E5EB4B312E4E6AEB6697813117A7C2* __this, int32_t ___controllerId0, String_t* ___categoryName1, bool ___userAssignableOnly2, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
int32_t V_0 = 0;
	{
		il2cpp_codegen_runtime_class_init_inline(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		int32_t L_0 = ((ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_StaticFields*)il2cpp_codegen_static_fields_for(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var))->____id_29;
		int32_t L_1 = (int32_t)__this->___eNyGUiEiMyquCTKLRhFvpeyOvzMm_5;
		if ((((int32_t)L_0) == ((int32_t)L_1)))
		{
			goto IL_001a;
		}
	}
	{
		int32_t L_2 = (int32_t)__this->___eNyGUiEiMyquCTKLRhFvpeyOvzMm_5;
		il2cpp_codegen_runtime_class_init_inline(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		bool L_3;
		L_3 = ReInput_CheckInitialized_mAAC593CB03C886BDB7B72864FBB1A59B2B0530AF(L_2, NULL);
		return;
	}

IL_001a:
	{
		il2cpp_codegen_runtime_class_init_inline(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		MappingHelper_t18AE344473D49AF2E7133108678DD4D963699662* L_4;
		L_4 = ReInput_get_mapping_mDE6BD708754EB86C540ACCB26BFD21D1F8054554(NULL);
		String_t* L_5 = ___categoryName1;
		NullCheck(L_4);
		int32_t L_6;
		L_6 = MappingHelper_GetMapCategoryId_mFC02A9FF6A6BFF6C38668558CB3DC6EB598077FB(L_4, L_5, NULL);
		V_0 = L_6;
		int32_t L_7 = V_0;
		if ((((int32_t)L_7) >= ((int32_t)0)))
		{
			goto IL_002b;
		}
	}
	{
		return;
	}

IL_002b:
	{
		int32_t L_8 = ___controllerId0;
		int32_t L_9 = V_0;
		bool L_10 = ___userAssignableOnly2;
		((  void (*) (MapHelper_t214BA4F045E5EB4B312E4E6AEB6697813117A7C2*, int32_t, int32_t, bool, const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->rgctx_data, 0)))(__this, L_8, L_9, L_10, il2cpp_rgctx_method(method->rgctx_data, 0));
		return;
	}
}
// System.Void Rewired.Player/ControllerHelper/MapHelper::ClearMapsForControllerInLayout<System.Object>(System.Int32,System.Int32,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MapHelper_ClearMapsForControllerInLayout_TisRuntimeObject_mC55B53675C35FA75DD8C833854D16867A3E590E7_gshared (MapHelper_t214BA4F045E5EB4B312E4E6AEB6697813117A7C2* __this, int32_t ___controllerId0, int32_t ___layoutId1, bool ___userAssignableOnly2, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
{
		il2cpp_codegen_runtime_class_init_inline(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		int32_t L_0 = ((ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_StaticFields*)il2cpp_codegen_static_fields_for(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var))->____id_29;
		int32_t L_1 = (int32_t)__this->___eNyGUiEiMyquCTKLRhFvpeyOvzMm_5;
		if ((((int32_t)L_0) == ((int32_t)L_1)))
		{
			goto IL_001a;
		}
	}
	{
		int32_t L_2 = (int32_t)__this->___eNyGUiEiMyquCTKLRhFvpeyOvzMm_5;
		il2cpp_codegen_runtime_class_init_inline(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		bool L_3;
		L_3 = ReInput_CheckInitialized_mAAC593CB03C886BDB7B72864FBB1A59B2B0530AF(L_2, NULL);
		return;
	}

IL_001a:
	{
		int32_t L_4;
		L_4 = ((  int32_t (*) (const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->rgctx_data, 0)))(il2cpp_rgctx_method(method->rgctx_data, 0));
		int32_t L_5 = ___controllerId0;
		int32_t L_6 = ___layoutId1;
		bool L_7 = ___userAssignableOnly2;
		MapHelper_ClearMapsForControllerInLayout_m2012A7C928B519693B0F57C5D13E84DBDBBEDE50(__this, L_4, L_5, L_6, L_7, NULL);
		return;
	}
}
// System.Void Rewired.Player/ControllerHelper/MapHelper::ClearMapsForControllerInLayout<System.Object>(System.Int32,System.String,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MapHelper_ClearMapsForControllerInLayout_TisRuntimeObject_m4BE3E287843B1E127ED49D569910845B746EE356_gshared (MapHelper_t214BA4F045E5EB4B312E4E6AEB6697813117A7C2* __this, int32_t ___controllerId0, String_t* ___layoutName1, bool ___userAssignableOnly2, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
int32_t V_0 = 0;
	{
		il2cpp_codegen_runtime_class_init_inline(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		int32_t L_0 = ((ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_StaticFields*)il2cpp_codegen_static_fields_for(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var))->____id_29;
		int32_t L_1 = (int32_t)__this->___eNyGUiEiMyquCTKLRhFvpeyOvzMm_5;
		if ((((int32_t)L_0) == ((int32_t)L_1)))
		{
			goto IL_001a;
		}
	}
	{
		int32_t L_2 = (int32_t)__this->___eNyGUiEiMyquCTKLRhFvpeyOvzMm_5;
		il2cpp_codegen_runtime_class_init_inline(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		bool L_3;
		L_3 = ReInput_CheckInitialized_mAAC593CB03C886BDB7B72864FBB1A59B2B0530AF(L_2, NULL);
		return;
	}

IL_001a:
	{
		il2cpp_codegen_runtime_class_init_inline(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		MappingHelper_t18AE344473D49AF2E7133108678DD4D963699662* L_4;
		L_4 = ReInput_get_mapping_mDE6BD708754EB86C540ACCB26BFD21D1F8054554(NULL);
		int32_t L_5;
		L_5 = ((  int32_t (*) (const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->rgctx_data, 0)))(il2cpp_rgctx_method(method->rgctx_data, 0));
		String_t* L_6 = ___layoutName1;
		NullCheck(L_4);
		int32_t L_7;
		L_7 = MappingHelper_GetLayoutId_m3C47818192FB2D4E2E46CB5F7E7585C302DE6ED7(L_4, L_5, L_6, NULL);
		V_0 = L_7;
		int32_t L_8 = V_0;
		if ((((int32_t)L_8) >= ((int32_t)0)))
		{
			goto IL_0030;
		}
	}
	{
		return;
	}

IL_0030:
	{
		int32_t L_9 = ___controllerId0;
		int32_t L_10 = V_0;
		bool L_11 = ___userAssignableOnly2;
		((  void (*) (MapHelper_t214BA4F045E5EB4B312E4E6AEB6697813117A7C2*, int32_t, int32_t, bool, const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->rgctx_data, 1)))(__this, L_9, L_10, L_11, il2cpp_rgctx_method(method->rgctx_data, 1));
		return;
	}
}
// System.Void Rewired.Player/ControllerHelper/MapHelper::ClearMapsInCategory<System.Object>(System.Int32,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MapHelper_ClearMapsInCategory_TisRuntimeObject_m4E4554DA0304D40319E4BCB52599FD36EE8E3412_gshared (MapHelper_t214BA4F045E5EB4B312E4E6AEB6697813117A7C2* __this, int32_t ___categoryId0, bool ___userAssignableOnly1, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
{
		il2cpp_codegen_runtime_class_init_inline(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		int32_t L_0 = ((ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_StaticFields*)il2cpp_codegen_static_fields_for(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var))->____id_29;
		int32_t L_1 = (int32_t)__this->___eNyGUiEiMyquCTKLRhFvpeyOvzMm_5;
		if ((((int32_t)L_0) == ((int32_t)L_1)))
		{
			goto IL_001a;
		}
	}
	{
		int32_t L_2 = (int32_t)__this->___eNyGUiEiMyquCTKLRhFvpeyOvzMm_5;
		il2cpp_codegen_runtime_class_init_inline(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		bool L_3;
		L_3 = ReInput_CheckInitialized_mAAC593CB03C886BDB7B72864FBB1A59B2B0530AF(L_2, NULL);
		return;
	}

IL_001a:
	{
		int32_t L_4;
		L_4 = ((  int32_t (*) (const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->rgctx_data, 0)))(il2cpp_rgctx_method(method->rgctx_data, 0));
		int32_t L_5 = ___categoryId0;
		bool L_6 = ___userAssignableOnly1;
		MapHelper_ClearMapsInCategory_m75DD455E3093205B83DBB0C3CD22842B7820F570(__this, L_4, L_5, L_6, NULL);
		return;
	}
}
// System.Void Rewired.Player/ControllerHelper/MapHelper::ClearMapsInCategory<System.Object>(System.String,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MapHelper_ClearMapsInCategory_TisRuntimeObject_m8BDBA3E727F1587A213939CD43C13A7C9993A616_gshared (MapHelper_t214BA4F045E5EB4B312E4E6AEB6697813117A7C2* __this, String_t* ___categoryName0, bool ___userAssignableOnly1, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
int32_t V_0 = 0;
	{
		il2cpp_codegen_runtime_class_init_inline(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		int32_t L_0 = ((ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_StaticFields*)il2cpp_codegen_static_fields_for(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var))->____id_29;
		int32_t L_1 = (int32_t)__this->___eNyGUiEiMyquCTKLRhFvpeyOvzMm_5;
		if ((((int32_t)L_0) == ((int32_t)L_1)))
		{
			goto IL_001a;
		}
	}
	{
		int32_t L_2 = (int32_t)__this->___eNyGUiEiMyquCTKLRhFvpeyOvzMm_5;
		il2cpp_codegen_runtime_class_init_inline(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		bool L_3;
		L_3 = ReInput_CheckInitialized_mAAC593CB03C886BDB7B72864FBB1A59B2B0530AF(L_2, NULL);
		return;
	}

IL_001a:
	{
		il2cpp_codegen_runtime_class_init_inline(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		MappingHelper_t18AE344473D49AF2E7133108678DD4D963699662* L_4;
		L_4 = ReInput_get_mapping_mDE6BD708754EB86C540ACCB26BFD21D1F8054554(NULL);
		String_t* L_5 = ___categoryName0;
		NullCheck(L_4);
		int32_t L_6;
		L_6 = MappingHelper_GetMapCategoryId_mFC02A9FF6A6BFF6C38668558CB3DC6EB598077FB(L_4, L_5, NULL);
		V_0 = L_6;
		int32_t L_7 = V_0;
		if ((((int32_t)L_7) >= ((int32_t)0)))
		{
			goto IL_002b;
		}
	}
	{
		return;
	}

IL_002b:
	{
		int32_t L_8 = V_0;
		bool L_9 = ___userAssignableOnly1;
		((  void (*) (MapHelper_t214BA4F045E5EB4B312E4E6AEB6697813117A7C2*, int32_t, bool, const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->rgctx_data, 0)))(__this, L_8, L_9, il2cpp_rgctx_method(method->rgctx_data, 0));
		return;
	}
}
// System.Void Rewired.Player/ControllerHelper/MapHelper::ClearMapsInCategory<System.Object>(System.Int32,System.Int32,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MapHelper_ClearMapsInCategory_TisRuntimeObject_mB9E53ED1DA2EA0A6FC71D32CD3C3D4954DBE4FE6_gshared (MapHelper_t214BA4F045E5EB4B312E4E6AEB6697813117A7C2* __this, int32_t ___categoryId0, int32_t ___layoutId1, bool ___userAssignableOnly2, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
{
		il2cpp_codegen_runtime_class_init_inline(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		int32_t L_0 = ((ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_StaticFields*)il2cpp_codegen_static_fields_for(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var))->____id_29;
		int32_t L_1 = (int32_t)__this->___eNyGUiEiMyquCTKLRhFvpeyOvzMm_5;
		if ((((int32_t)L_0) == ((int32_t)L_1)))
		{
			goto IL_001a;
		}
	}
	{
		int32_t L_2 = (int32_t)__this->___eNyGUiEiMyquCTKLRhFvpeyOvzMm_5;
		il2cpp_codegen_runtime_class_init_inline(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		bool L_3;
		L_3 = ReInput_CheckInitialized_mAAC593CB03C886BDB7B72864FBB1A59B2B0530AF(L_2, NULL);
		return;
	}

IL_001a:
	{
		int32_t L_4;
		L_4 = ((  int32_t (*) (const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->rgctx_data, 0)))(il2cpp_rgctx_method(method->rgctx_data, 0));
		int32_t L_5 = ___categoryId0;
		int32_t L_6 = ___layoutId1;
		bool L_7 = ___userAssignableOnly2;
		MapHelper_ClearMapsInCategory_m7A84D03ED5B7E2058C03C75F2AFC4416A58149F4(__this, L_4, L_5, L_6, L_7, NULL);
		return;
	}
}
// System.Void Rewired.Player/ControllerHelper/MapHelper::ClearMapsInCategory<System.Object>(System.String,System.String,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MapHelper_ClearMapsInCategory_TisRuntimeObject_mB227F7F2038B64CDD422B55FDDFBF3C16BEF1414_gshared (MapHelper_t214BA4F045E5EB4B312E4E6AEB6697813117A7C2* __this, String_t* ___categoryName0, String_t* ___layoutName1, bool ___userAssignableOnly2, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
int32_t V_0 = 0;
	int32_t V_1 = 0;
	{
		il2cpp_codegen_runtime_class_init_inline(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		int32_t L_0 = ((ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_StaticFields*)il2cpp_codegen_static_fields_for(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var))->____id_29;
		int32_t L_1 = (int32_t)__this->___eNyGUiEiMyquCTKLRhFvpeyOvzMm_5;
		if ((((int32_t)L_0) == ((int32_t)L_1)))
		{
			goto IL_001a;
		}
	}
	{
		int32_t L_2 = (int32_t)__this->___eNyGUiEiMyquCTKLRhFvpeyOvzMm_5;
		il2cpp_codegen_runtime_class_init_inline(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		bool L_3;
		L_3 = ReInput_CheckInitialized_mAAC593CB03C886BDB7B72864FBB1A59B2B0530AF(L_2, NULL);
		return;
	}

IL_001a:
	{
		il2cpp_codegen_runtime_class_init_inline(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		MappingHelper_t18AE344473D49AF2E7133108678DD4D963699662* L_4;
		L_4 = ReInput_get_mapping_mDE6BD708754EB86C540ACCB26BFD21D1F8054554(NULL);
		String_t* L_5 = ___categoryName0;
		NullCheck(L_4);
		int32_t L_6;
		L_6 = MappingHelper_GetMapCategoryId_mFC02A9FF6A6BFF6C38668558CB3DC6EB598077FB(L_4, L_5, NULL);
		V_0 = L_6;
		int32_t L_7 = V_0;
		if ((((int32_t)L_7) >= ((int32_t)0)))
		{
			goto IL_002b;
		}
	}
	{
		return;
	}

IL_002b:
	{
		il2cpp_codegen_runtime_class_init_inline(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		MappingHelper_t18AE344473D49AF2E7133108678DD4D963699662* L_8;
		L_8 = ReInput_get_mapping_mDE6BD708754EB86C540ACCB26BFD21D1F8054554(NULL);
		int32_t L_9;
		L_9 = ((  int32_t (*) (const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->rgctx_data, 0)))(il2cpp_rgctx_method(method->rgctx_data, 0));
		String_t* L_10 = ___layoutName1;
		NullCheck(L_8);
		int32_t L_11;
		L_11 = MappingHelper_GetLayoutId_m3C47818192FB2D4E2E46CB5F7E7585C302DE6ED7(L_8, L_9, L_10, NULL);
		V_1 = L_11;
		int32_t L_12 = V_1;
		if ((((int32_t)L_12) >= ((int32_t)0)))
		{
			goto IL_0041;
		}
	}
	{
		return;
	}

IL_0041:
	{
		int32_t L_13 = V_0;
		int32_t L_14 = V_1;
		bool L_15 = ___userAssignableOnly2;
		((  void (*) (MapHelper_t214BA4F045E5EB4B312E4E6AEB6697813117A7C2*, int32_t, int32_t, bool, const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->rgctx_data, 1)))(__this, L_13, L_14, L_15, il2cpp_rgctx_method(method->rgctx_data, 1));
		return;
	}
}
// System.Void Rewired.Player/ControllerHelper/MapHelper::ClearMapsInLayout<System.Object>(System.Int32,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MapHelper_ClearMapsInLayout_TisRuntimeObject_mE171A6904265C0C4726A07AF2EEFC31AE2A121B5_gshared (MapHelper_t214BA4F045E5EB4B312E4E6AEB6697813117A7C2* __this, int32_t ___layoutId0, bool ___userAssignableOnly1, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
{
		il2cpp_codegen_runtime_class_init_inline(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		int32_t L_0 = ((ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_StaticFields*)il2cpp_codegen_static_fields_for(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var))->____id_29;
		int32_t L_1 = (int32_t)__this->___eNyGUiEiMyquCTKLRhFvpeyOvzMm_5;
		if ((((int32_t)L_0) == ((int32_t)L_1)))
		{
			goto IL_001a;
		}
	}
	{
		int32_t L_2 = (int32_t)__this->___eNyGUiEiMyquCTKLRhFvpeyOvzMm_5;
		il2cpp_codegen_runtime_class_init_inline(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		bool L_3;
		L_3 = ReInput_CheckInitialized_mAAC593CB03C886BDB7B72864FBB1A59B2B0530AF(L_2, NULL);
		return;
	}

IL_001a:
	{
		int32_t L_4;
		L_4 = ((  int32_t (*) (const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->rgctx_data, 0)))(il2cpp_rgctx_method(method->rgctx_data, 0));
		int32_t L_5 = ___layoutId0;
		bool L_6 = ___userAssignableOnly1;
		MapHelper_ClearMapsInLayout_m93FF033059DFAB7D685235CEDEA7A42D28A1E042(__this, L_4, L_5, L_6, NULL);
		return;
	}
}
// System.Void Rewired.Player/ControllerHelper/MapHelper::ClearMapsInLayout<System.Object>(System.String,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MapHelper_ClearMapsInLayout_TisRuntimeObject_mEC3EB50298E3B5F8D70F0276EF8F7170D0B8896A_gshared (MapHelper_t214BA4F045E5EB4B312E4E6AEB6697813117A7C2* __this, String_t* ___layoutName0, bool ___userAssignableOnly1, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
int32_t V_0 = 0;
	{
		il2cpp_codegen_runtime_class_init_inline(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		int32_t L_0 = ((ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_StaticFields*)il2cpp_codegen_static_fields_for(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var))->____id_29;
		int32_t L_1 = (int32_t)__this->___eNyGUiEiMyquCTKLRhFvpeyOvzMm_5;
		if ((((int32_t)L_0) == ((int32_t)L_1)))
		{
			goto IL_001a;
		}
	}
	{
		int32_t L_2 = (int32_t)__this->___eNyGUiEiMyquCTKLRhFvpeyOvzMm_5;
		il2cpp_codegen_runtime_class_init_inline(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		bool L_3;
		L_3 = ReInput_CheckInitialized_mAAC593CB03C886BDB7B72864FBB1A59B2B0530AF(L_2, NULL);
		return;
	}

IL_001a:
	{
		il2cpp_codegen_runtime_class_init_inline(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		MappingHelper_t18AE344473D49AF2E7133108678DD4D963699662* L_4;
		L_4 = ReInput_get_mapping_mDE6BD708754EB86C540ACCB26BFD21D1F8054554(NULL);
		int32_t L_5;
		L_5 = ((  int32_t (*) (const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->rgctx_data, 0)))(il2cpp_rgctx_method(method->rgctx_data, 0));
		String_t* L_6 = ___layoutName0;
		NullCheck(L_4);
		int32_t L_7;
		L_7 = MappingHelper_GetLayoutId_m3C47818192FB2D4E2E46CB5F7E7585C302DE6ED7(L_4, L_5, L_6, NULL);
		V_0 = L_7;
		int32_t L_8 = V_0;
		if ((((int32_t)L_8) >= ((int32_t)0)))
		{
			goto IL_0030;
		}
	}
	{
		return;
	}

IL_0030:
	{
		int32_t L_9 = V_0;
		bool L_10 = ___userAssignableOnly1;
		((  void (*) (MapHelper_t214BA4F045E5EB4B312E4E6AEB6697813117A7C2*, int32_t, bool, const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->rgctx_data, 1)))(__this, L_9, L_10, il2cpp_rgctx_method(method->rgctx_data, 1));
		return;
	}
}
// T[] Rewired.Player/ControllerHelper/MapHelper::GetAllMapSaveData<System.Object>(System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* MapHelper_GetAllMapSaveData_TisRuntimeObject_m5F9E150D9C601E61F7CB347C3E488356C9EB6EEB_gshared (MapHelper_t214BA4F045E5EB4B312E4E6AEB6697813117A7C2* __this, bool ___userAssignableMapsOnly0, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
{
		il2cpp_codegen_runtime_class_init_inline(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		int32_t L_0 = ((ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_StaticFields*)il2cpp_codegen_static_fields_for(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var))->____id_29;
		int32_t L_1 = (int32_t)__this->___eNyGUiEiMyquCTKLRhFvpeyOvzMm_5;
		if ((((int32_t)L_0) == ((int32_t)L_1)))
		{
			goto IL_001f;
		}
	}
	{
		int32_t L_2 = (int32_t)__this->___eNyGUiEiMyquCTKLRhFvpeyOvzMm_5;
		il2cpp_codegen_runtime_class_init_inline(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		bool L_3;
		L_3 = ReInput_CheckInitialized_mAAC593CB03C886BDB7B72864FBB1A59B2B0530AF(L_2, NULL);
		ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* L_4;
		L_4 = ((  ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* (*) (const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->rgctx_data, 0)))(il2cpp_rgctx_method(method->rgctx_data, 0));
		return L_4;
	}

IL_001f:
	{
		bool L_5 = ___userAssignableMapsOnly0;
		ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* L_6;
		L_6 = ((  ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* (*) (MapHelper_t214BA4F045E5EB4B312E4E6AEB6697813117A7C2*, bool, const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->rgctx_data, 2)))(__this, L_5, il2cpp_rgctx_method(method->rgctx_data, 2));
		return L_6;
	}
}
// System.Collections.Generic.IEnumerable`1<T> Rewired.Player/ControllerHelper/MapHelper::GetAllMaps<System.Object>()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* MapHelper_GetAllMaps_TisRuntimeObject_m1C7B7EB1521FEBB8F41CE1D85A548D1CFC5948BE_gshared (MapHelper_t214BA4F045E5EB4B312E4E6AEB6697813117A7C2* __this, const RuntimeMethod* method) 
{
{
		XcujpkEuhtkMjJAdZtQvqOzWNWoy_1_t8DB30E00B0855C4A917D6B66CABCB5A4E19B64A2* L_0 = (XcujpkEuhtkMjJAdZtQvqOzWNWoy_1_t8DB30E00B0855C4A917D6B66CABCB5A4E19B64A2*)il2cpp_codegen_object_new(il2cpp_rgctx_data(method->rgctx_data, 0));
		XcujpkEuhtkMjJAdZtQvqOzWNWoy_1__ctor_m8793AFB1079D0A7CA7D1C71689E0C8BA63138080(L_0, ((int32_t)-2), /*hidden argument*/il2cpp_rgctx_method(method->rgctx_data, 1));
		XcujpkEuhtkMjJAdZtQvqOzWNWoy_1_t8DB30E00B0855C4A917D6B66CABCB5A4E19B64A2* L_1 = L_0;
		NullCheck(L_1);
		L_1->___hJlvyFukKfMzsWcSVLwLCnIUdlMn_3 = __this;
		Il2CppCodeGenWriteBarrier((void**)(&L_1->___hJlvyFukKfMzsWcSVLwLCnIUdlMn_3), (void*)__this);
		return (RuntimeObject*)L_1;
	}
}
// System.Int32 Rewired.Player/ControllerHelper/MapHelper::GetAllMaps<System.Object>(System.Collections.Generic.List`1<T>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t MapHelper_GetAllMaps_TisRuntimeObject_m55A3C44AC237AE83A83C4653F89DA90562BB92D5_gshared (MapHelper_t214BA4F045E5EB4B312E4E6AEB6697813117A7C2* __this, List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D* ___results0, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ccKIYWnZwPjlGgvjpHVACPHqZTWG_t7AB72F4748B9EC6B1975F90F35E5838740AD2011_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ftuHLSCvHbrPYKqmDICMGujVuqLSA_tD67CC6A3A416E57262B63617FA5896CF7BF4F187_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
int32_t V_0 = 0;
	RuntimeObject* V_1 = NULL;
	int32_t V_2 = 0;
	int32_t V_3 = 0;
	int32_t V_4 = 0;
	int32_t V_5 = 0;
	RuntimeObject* V_6 = NULL;
	int32_t V_7 = 0;
	int32_t V_8 = 0;
	{
		il2cpp_codegen_runtime_class_init_inline(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		int32_t L_0 = ((ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_StaticFields*)il2cpp_codegen_static_fields_for(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var))->____id_29;
		int32_t L_1 = (int32_t)__this->___eNyGUiEiMyquCTKLRhFvpeyOvzMm_5;
		if ((((int32_t)L_0) == ((int32_t)L_1)))
		{
			goto IL_001b;
		}
	}
	{
		int32_t L_2 = (int32_t)__this->___eNyGUiEiMyquCTKLRhFvpeyOvzMm_5;
		il2cpp_codegen_runtime_class_init_inline(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		bool L_3;
		L_3 = ReInput_CheckInitialized_mAAC593CB03C886BDB7B72864FBB1A59B2B0530AF(L_2, NULL);
		return 0;
	}

IL_001b:
	{
		List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D* L_4 = ___results0;
		if (L_4)
		{
			goto IL_0029;
		}
	}
	{
		ArgumentNullException_t327031E412FAB2351B0022DD5DAD47E67E597129* L_5 = (ArgumentNullException_t327031E412FAB2351B0022DD5DAD47E67E597129*)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&ArgumentNullException_t327031E412FAB2351B0022DD5DAD47E67E597129_il2cpp_TypeInfo_var)));
		ArgumentNullException__ctor_m444AE141157E333844FC1A9500224C2F9FD24F4B(L_5, ((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteral9AB16B3999460DDC981865934D979087351A14F2)), /*hidden argument*/NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_5, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&MapHelper_GetAllMaps_TisRuntimeObject_m55A3C44AC237AE83A83C4653F89DA90562BB92D5_RuntimeMethod_var)));
	}

IL_0029:
	{
		List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D* L_6 = ___results0;
		NullCheck(L_6);
		((  void (*) (List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D*, const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->rgctx_data, 1)))(L_6, il2cpp_rgctx_method(method->rgctx_data, 1));
		bool L_7;
		L_7 = ((  bool (*) (int32_t*, const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->rgctx_data, 2)))((&V_0), il2cpp_rgctx_method(method->rgctx_data, 2));
		if (!L_7)
		{
			goto IL_0073;
		}
	}
	{
		ControllerHelper_tCE72EA23053BD0C6ECB4D75A69F8CD1B3AC28FF6* L_8 = (ControllerHelper_tCE72EA23053BD0C6ECB4D75A69F8CD1B3AC28FF6*)__this->___JOhXpftGzsqKykxdovItahCXjNZ_2;
		NullCheck(L_8);
		vpfVMfLDNQCKabtrXuyMMndafvvoA_t24DAE63535EED93A1490AC97901F2551704D116D* L_9 = (vpfVMfLDNQCKabtrXuyMMndafvvoA_t24DAE63535EED93A1490AC97901F2551704D116D*)L_8->___rGIwSbUPDgDDJByCitUBBGoZDlmc_0;
		int32_t L_10 = V_0;
		NullCheck(L_9);
		RuntimeObject* L_11;
		L_11 = vpfVMfLDNQCKabtrXuyMMndafvvoA_OlLACmpwoMamrxMTFzLaRnppBEGFA_m7D256F4AAE84410B2D3EC0217ADB4B49A6AE0B9F(L_9, L_10, NULL);
		V_1 = L_11;
		RuntimeObject* L_12 = V_1;
		NullCheck(L_12);
		int32_t L_13;
		L_13 = InterfaceFuncInvoker0< int32_t >::Invoke(2 /* System.Int32 Rewired.Player/ControllerHelper/ftuHLSCvHbrPYKqmDICMGujVuqLSA::NEFjFYSXjpJmKUMrQuBCmBemjvSFA() */, ftuHLSCvHbrPYKqmDICMGujVuqLSA_tD67CC6A3A416E57262B63617FA5896CF7BF4F187_il2cpp_TypeInfo_var, L_12);
		V_2 = L_13;
		V_3 = 0;
		goto IL_006d;
	}

IL_0055:
	{
		RuntimeObject* L_14 = V_1;
		int32_t L_15 = V_3;
		NullCheck(L_14);
		RuntimeObject* L_16;
		L_16 = InterfaceFuncInvoker1< RuntimeObject*, int32_t >::Invoke(0 /* Rewired.Player/ControllerHelper/ccKIYWnZwPjlGgvjpHVACPHqZTWG Rewired.Player/ControllerHelper/ftuHLSCvHbrPYKqmDICMGujVuqLSA::ZfIXNjSNQNQjmCdAUEIsaOrcLoPs(System.Int32) */, ftuHLSCvHbrPYKqmDICMGujVuqLSA_tD67CC6A3A416E57262B63617FA5896CF7BF4F187_il2cpp_TypeInfo_var, L_14, L_15);
		NullCheck(L_16);
		RuntimeObject* L_17;
		L_17 = InterfaceFuncInvoker0< RuntimeObject* >::Invoke(0 /* hDTwQOONkmiSaaPHwqpfFkmXMCAbb Rewired.Player/ControllerHelper/ccKIYWnZwPjlGgvjpHVACPHqZTWG::DJykFGUxbFlHMIneTwfokcsefclu() */, ccKIYWnZwPjlGgvjpHVACPHqZTWG_t7AB72F4748B9EC6B1975F90F35E5838740AD2011_il2cpp_TypeInfo_var, L_16);
		List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D* L_18 = ___results0;
		NullCheck(L_17);
		int32_t L_19;
		L_19 = GenericInterfaceFuncInvoker2< int32_t, List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D*, bool >::Invoke(il2cpp_rgctx_method(method->rgctx_data, 3), L_17, L_18, (bool)1);
		int32_t L_20 = V_3;
		V_3 = ((int32_t)il2cpp_codegen_add(L_20, 1));
	}

IL_006d:
	{
		int32_t L_21 = V_3;
		int32_t L_22 = V_2;
		if ((((int32_t)L_21) < ((int32_t)L_22)))
		{
			goto IL_0055;
		}
	}
	{
		goto IL_00da;
	}

IL_0073:
	{
		ControllerHelper_tCE72EA23053BD0C6ECB4D75A69F8CD1B3AC28FF6* L_23 = (ControllerHelper_tCE72EA23053BD0C6ECB4D75A69F8CD1B3AC28FF6*)__this->___JOhXpftGzsqKykxdovItahCXjNZ_2;
		NullCheck(L_23);
		vpfVMfLDNQCKabtrXuyMMndafvvoA_t24DAE63535EED93A1490AC97901F2551704D116D* L_24 = (vpfVMfLDNQCKabtrXuyMMndafvvoA_t24DAE63535EED93A1490AC97901F2551704D116D*)L_23->___rGIwSbUPDgDDJByCitUBBGoZDlmc_0;
		NullCheck(L_24);
		int32_t L_25 = (int32_t)L_24->___TIKqvTvXeujXUEcFBSnvvfWjpzmS_0;
		V_4 = L_25;
		V_5 = 0;
		goto IL_00d4;
	}

IL_008a:
	{
		ControllerHelper_tCE72EA23053BD0C6ECB4D75A69F8CD1B3AC28FF6* L_26 = (ControllerHelper_tCE72EA23053BD0C6ECB4D75A69F8CD1B3AC28FF6*)__this->___JOhXpftGzsqKykxdovItahCXjNZ_2;
		NullCheck(L_26);
		vpfVMfLDNQCKabtrXuyMMndafvvoA_t24DAE63535EED93A1490AC97901F2551704D116D* L_27 = (vpfVMfLDNQCKabtrXuyMMndafvvoA_t24DAE63535EED93A1490AC97901F2551704D116D*)L_26->___rGIwSbUPDgDDJByCitUBBGoZDlmc_0;
		int32_t L_28 = V_5;
		NullCheck(L_27);
		RuntimeObject* L_29;
		L_29 = vpfVMfLDNQCKabtrXuyMMndafvvoA_WnvLUDAsClwKBCDbOHhIRBMdKTgv_mFB15C8D1E61FDBCCAB87F4892BB7481AF3BBEE6F(L_27, L_28, NULL);
		V_6 = L_29;
		RuntimeObject* L_30 = V_6;
		NullCheck(L_30);
		int32_t L_31;
		L_31 = InterfaceFuncInvoker0< int32_t >::Invoke(2 /* System.Int32 Rewired.Player/ControllerHelper/ftuHLSCvHbrPYKqmDICMGujVuqLSA::NEFjFYSXjpJmKUMrQuBCmBemjvSFA() */, ftuHLSCvHbrPYKqmDICMGujVuqLSA_tD67CC6A3A416E57262B63617FA5896CF7BF4F187_il2cpp_TypeInfo_var, L_30);
		V_7 = L_31;
		V_8 = 0;
		goto IL_00c8;
	}

IL_00ac:
	{
		RuntimeObject* L_32 = V_6;
		int32_t L_33 = V_8;
		NullCheck(L_32);
		RuntimeObject* L_34;
		L_34 = InterfaceFuncInvoker1< RuntimeObject*, int32_t >::Invoke(0 /* Rewired.Player/ControllerHelper/ccKIYWnZwPjlGgvjpHVACPHqZTWG Rewired.Player/ControllerHelper/ftuHLSCvHbrPYKqmDICMGujVuqLSA::ZfIXNjSNQNQjmCdAUEIsaOrcLoPs(System.Int32) */, ftuHLSCvHbrPYKqmDICMGujVuqLSA_tD67CC6A3A416E57262B63617FA5896CF7BF4F187_il2cpp_TypeInfo_var, L_32, L_33);
		NullCheck(L_34);
		RuntimeObject* L_35;
		L_35 = InterfaceFuncInvoker0< RuntimeObject* >::Invoke(0 /* hDTwQOONkmiSaaPHwqpfFkmXMCAbb Rewired.Player/ControllerHelper/ccKIYWnZwPjlGgvjpHVACPHqZTWG::DJykFGUxbFlHMIneTwfokcsefclu() */, ccKIYWnZwPjlGgvjpHVACPHqZTWG_t7AB72F4748B9EC6B1975F90F35E5838740AD2011_il2cpp_TypeInfo_var, L_34);
		List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D* L_36 = ___results0;
		NullCheck(L_35);
		int32_t L_37;
		L_37 = GenericInterfaceFuncInvoker2< int32_t, List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D*, bool >::Invoke(il2cpp_rgctx_method(method->rgctx_data, 3), L_35, L_36, (bool)1);
		int32_t L_38 = V_8;
		V_8 = ((int32_t)il2cpp_codegen_add(L_38, 1));
	}

IL_00c8:
	{
		int32_t L_39 = V_8;
		int32_t L_40 = V_7;
		if ((((int32_t)L_39) < ((int32_t)L_40)))
		{
			goto IL_00ac;
		}
	}
	{
		int32_t L_41 = V_5;
		V_5 = ((int32_t)il2cpp_codegen_add(L_41, 1));
	}

IL_00d4:
	{
		int32_t L_42 = V_5;
		int32_t L_43 = V_4;
		if ((((int32_t)L_42) < ((int32_t)L_43)))
		{
			goto IL_008a;
		}
	}

IL_00da:
	{
		List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D* L_44 = ___results0;
		NullCheck(L_44);
		int32_t L_45;
		L_45 = ((  int32_t (*) (List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D*, const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->rgctx_data, 4)))(L_44, il2cpp_rgctx_method(method->rgctx_data, 4));
		return L_45;
	}
}
// System.Collections.Generic.IEnumerable`1<T> Rewired.Player/ControllerHelper/MapHelper::GetAllMapsInCategory<System.Object>(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* MapHelper_GetAllMapsInCategory_TisRuntimeObject_m4BBEDF0B5F20B262FF788C09F6D861D00208927B_gshared (MapHelper_t214BA4F045E5EB4B312E4E6AEB6697813117A7C2* __this, int32_t ___categoryId0, const RuntimeMethod* method) 
{
{
		ojuhOybXRUNKAWBYROlwkJhBlkPc_1_t7B54C1CB431E7958F15D7F71C96CAF6E68E76D60* L_0 = (ojuhOybXRUNKAWBYROlwkJhBlkPc_1_t7B54C1CB431E7958F15D7F71C96CAF6E68E76D60*)il2cpp_codegen_object_new(il2cpp_rgctx_data(method->rgctx_data, 0));
		ojuhOybXRUNKAWBYROlwkJhBlkPc_1__ctor_m48EF0C0BCF7EB4E23415C4B13C967B63A9589F32(L_0, ((int32_t)-2), /*hidden argument*/il2cpp_rgctx_method(method->rgctx_data, 1));
		ojuhOybXRUNKAWBYROlwkJhBlkPc_1_t7B54C1CB431E7958F15D7F71C96CAF6E68E76D60* L_1 = L_0;
		NullCheck(L_1);
		L_1->___hJlvyFukKfMzsWcSVLwLCnIUdlMn_3 = __this;
		Il2CppCodeGenWriteBarrier((void**)(&L_1->___hJlvyFukKfMzsWcSVLwLCnIUdlMn_3), (void*)__this);
		ojuhOybXRUNKAWBYROlwkJhBlkPc_1_t7B54C1CB431E7958F15D7F71C96CAF6E68E76D60* L_2 = L_1;
		int32_t L_3 = ___categoryId0;
		NullCheck(L_2);
		L_2->___HyLMjUIcjSOZGGOJZWHdhVkIwYLO_5 = L_3;
		return (RuntimeObject*)L_2;
	}
}
// System.Collections.Generic.IEnumerable`1<T> Rewired.Player/ControllerHelper/MapHelper::GetAllMapsInCategory<System.Object>(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* MapHelper_GetAllMapsInCategory_TisRuntimeObject_m3F1991966E90B0521BFD5702F3F0A5FCE2344604_gshared (MapHelper_t214BA4F045E5EB4B312E4E6AEB6697813117A7C2* __this, String_t* ___categoryName0, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
int32_t V_0 = 0;
	{
		il2cpp_codegen_runtime_class_init_inline(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		int32_t L_0 = ((ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_StaticFields*)il2cpp_codegen_static_fields_for(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var))->____id_29;
		int32_t L_1 = (int32_t)__this->___eNyGUiEiMyquCTKLRhFvpeyOvzMm_5;
		if ((((int32_t)L_0) == ((int32_t)L_1)))
		{
			goto IL_001f;
		}
	}
	{
		int32_t L_2 = (int32_t)__this->___eNyGUiEiMyquCTKLRhFvpeyOvzMm_5;
		il2cpp_codegen_runtime_class_init_inline(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		bool L_3;
		L_3 = ReInput_CheckInitialized_mAAC593CB03C886BDB7B72864FBB1A59B2B0530AF(L_2, NULL);
		RuntimeObject* L_4;
		L_4 = ((  RuntimeObject* (*) (const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->rgctx_data, 0)))(il2cpp_rgctx_method(method->rgctx_data, 0));
		return (RuntimeObject*)L_4;
	}

IL_001f:
	{
		il2cpp_codegen_runtime_class_init_inline(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		MappingHelper_t18AE344473D49AF2E7133108678DD4D963699662* L_5;
		L_5 = ReInput_get_mapping_mDE6BD708754EB86C540ACCB26BFD21D1F8054554(NULL);
		String_t* L_6 = ___categoryName0;
		NullCheck(L_5);
		int32_t L_7;
		L_7 = MappingHelper_GetMapCategoryId_mFC02A9FF6A6BFF6C38668558CB3DC6EB598077FB(L_5, L_6, NULL);
		V_0 = L_7;
		int32_t L_8 = V_0;
		if ((((int32_t)L_8) >= ((int32_t)0)))
		{
			goto IL_0035;
		}
	}
	{
		RuntimeObject* L_9;
		L_9 = ((  RuntimeObject* (*) (const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->rgctx_data, 0)))(il2cpp_rgctx_method(method->rgctx_data, 0));
		return (RuntimeObject*)L_9;
	}

IL_0035:
	{
		int32_t L_10 = V_0;
		RuntimeObject* L_11;
		L_11 = ((  RuntimeObject* (*) (MapHelper_t214BA4F045E5EB4B312E4E6AEB6697813117A7C2*, int32_t, const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->rgctx_data, 2)))(__this, L_10, il2cpp_rgctx_method(method->rgctx_data, 2));
		return L_11;
	}
}
// System.Int32 Rewired.Player/ControllerHelper/MapHelper::GetAllMapsInCategory<System.Object>(System.Int32,System.Collections.Generic.List`1<T>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t MapHelper_GetAllMapsInCategory_TisRuntimeObject_mDDC9515B6EDC86309D3538EC6D3337E30244542F_gshared (MapHelper_t214BA4F045E5EB4B312E4E6AEB6697813117A7C2* __this, int32_t ___categoryId0, List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D* ___results1, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ccKIYWnZwPjlGgvjpHVACPHqZTWG_t7AB72F4748B9EC6B1975F90F35E5838740AD2011_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ftuHLSCvHbrPYKqmDICMGujVuqLSA_tD67CC6A3A416E57262B63617FA5896CF7BF4F187_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
int32_t V_0 = 0;
	RuntimeObject* V_1 = NULL;
	int32_t V_2 = 0;
	int32_t V_3 = 0;
	int32_t V_4 = 0;
	int32_t V_5 = 0;
	RuntimeObject* V_6 = NULL;
	int32_t V_7 = 0;
	int32_t V_8 = 0;
	{
		il2cpp_codegen_runtime_class_init_inline(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		int32_t L_0 = ((ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_StaticFields*)il2cpp_codegen_static_fields_for(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var))->____id_29;
		int32_t L_1 = (int32_t)__this->___eNyGUiEiMyquCTKLRhFvpeyOvzMm_5;
		if ((((int32_t)L_0) == ((int32_t)L_1)))
		{
			goto IL_001b;
		}
	}
	{
		int32_t L_2 = (int32_t)__this->___eNyGUiEiMyquCTKLRhFvpeyOvzMm_5;
		il2cpp_codegen_runtime_class_init_inline(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		bool L_3;
		L_3 = ReInput_CheckInitialized_mAAC593CB03C886BDB7B72864FBB1A59B2B0530AF(L_2, NULL);
		return 0;
	}

IL_001b:
	{
		List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D* L_4 = ___results1;
		if (L_4)
		{
			goto IL_0029;
		}
	}
	{
		ArgumentNullException_t327031E412FAB2351B0022DD5DAD47E67E597129* L_5 = (ArgumentNullException_t327031E412FAB2351B0022DD5DAD47E67E597129*)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&ArgumentNullException_t327031E412FAB2351B0022DD5DAD47E67E597129_il2cpp_TypeInfo_var)));
		ArgumentNullException__ctor_m444AE141157E333844FC1A9500224C2F9FD24F4B(L_5, ((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteral9AB16B3999460DDC981865934D979087351A14F2)), /*hidden argument*/NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_5, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&MapHelper_GetAllMapsInCategory_TisRuntimeObject_mDDC9515B6EDC86309D3538EC6D3337E30244542F_RuntimeMethod_var)));
	}

IL_0029:
	{
		List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D* L_6 = ___results1;
		NullCheck(L_6);
		((  void (*) (List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D*, const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->rgctx_data, 1)))(L_6, il2cpp_rgctx_method(method->rgctx_data, 1));
		il2cpp_codegen_runtime_class_init_inline(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		MappingHelper_t18AE344473D49AF2E7133108678DD4D963699662* L_7;
		L_7 = ReInput_get_mapping_mDE6BD708754EB86C540ACCB26BFD21D1F8054554(NULL);
		int32_t L_8 = ___categoryId0;
		NullCheck(L_7);
		InputMapCategory_t309A7C800100DDCC67C5C6A69F960A1D71768111* L_9;
		L_9 = MappingHelper_GetMapCategory_m6B8082A9D9CAAB69B2EC97F6B2FCAF94C5C88DBD(L_7, L_8, NULL);
		if (L_9)
		{
			goto IL_003e;
		}
	}
	{
		return 0;
	}

IL_003e:
	{
		bool L_10;
		L_10 = ((  bool (*) (int32_t*, const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->rgctx_data, 2)))((&V_0), il2cpp_rgctx_method(method->rgctx_data, 2));
		if (!L_10)
		{
			goto IL_0083;
		}
	}
	{
		ControllerHelper_tCE72EA23053BD0C6ECB4D75A69F8CD1B3AC28FF6* L_11 = (ControllerHelper_tCE72EA23053BD0C6ECB4D75A69F8CD1B3AC28FF6*)__this->___JOhXpftGzsqKykxdovItahCXjNZ_2;
		NullCheck(L_11);
		vpfVMfLDNQCKabtrXuyMMndafvvoA_t24DAE63535EED93A1490AC97901F2551704D116D* L_12 = (vpfVMfLDNQCKabtrXuyMMndafvvoA_t24DAE63535EED93A1490AC97901F2551704D116D*)L_11->___rGIwSbUPDgDDJByCitUBBGoZDlmc_0;
		int32_t L_13 = V_0;
		NullCheck(L_12);
		RuntimeObject* L_14;
		L_14 = vpfVMfLDNQCKabtrXuyMMndafvvoA_OlLACmpwoMamrxMTFzLaRnppBEGFA_m7D256F4AAE84410B2D3EC0217ADB4B49A6AE0B9F(L_12, L_13, NULL);
		V_1 = L_14;
		RuntimeObject* L_15 = V_1;
		NullCheck(L_15);
		int32_t L_16;
		L_16 = InterfaceFuncInvoker0< int32_t >::Invoke(2 /* System.Int32 Rewired.Player/ControllerHelper/ftuHLSCvHbrPYKqmDICMGujVuqLSA::NEFjFYSXjpJmKUMrQuBCmBemjvSFA() */, ftuHLSCvHbrPYKqmDICMGujVuqLSA_tD67CC6A3A416E57262B63617FA5896CF7BF4F187_il2cpp_TypeInfo_var, L_15);
		V_2 = L_16;
		V_3 = 0;
		goto IL_007d;
	}

IL_0064:
	{
		RuntimeObject* L_17 = V_1;
		int32_t L_18 = V_3;
		NullCheck(L_17);
		RuntimeObject* L_19;
		L_19 = InterfaceFuncInvoker1< RuntimeObject*, int32_t >::Invoke(0 /* Rewired.Player/ControllerHelper/ccKIYWnZwPjlGgvjpHVACPHqZTWG Rewired.Player/ControllerHelper/ftuHLSCvHbrPYKqmDICMGujVuqLSA::ZfIXNjSNQNQjmCdAUEIsaOrcLoPs(System.Int32) */, ftuHLSCvHbrPYKqmDICMGujVuqLSA_tD67CC6A3A416E57262B63617FA5896CF7BF4F187_il2cpp_TypeInfo_var, L_17, L_18);
		NullCheck(L_19);
		RuntimeObject* L_20;
		L_20 = InterfaceFuncInvoker0< RuntimeObject* >::Invoke(0 /* hDTwQOONkmiSaaPHwqpfFkmXMCAbb Rewired.Player/ControllerHelper/ccKIYWnZwPjlGgvjpHVACPHqZTWG::DJykFGUxbFlHMIneTwfokcsefclu() */, ccKIYWnZwPjlGgvjpHVACPHqZTWG_t7AB72F4748B9EC6B1975F90F35E5838740AD2011_il2cpp_TypeInfo_var, L_19);
		int32_t L_21 = ___categoryId0;
		List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D* L_22 = ___results1;
		NullCheck(L_20);
		int32_t L_23;
		L_23 = GenericInterfaceFuncInvoker3< int32_t, int32_t, List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D*, bool >::Invoke(il2cpp_rgctx_method(method->rgctx_data, 3), L_20, L_21, L_22, (bool)1);
		int32_t L_24 = V_3;
		V_3 = ((int32_t)il2cpp_codegen_add(L_24, 1));
	}

IL_007d:
	{
		int32_t L_25 = V_3;
		int32_t L_26 = V_2;
		if ((((int32_t)L_25) < ((int32_t)L_26)))
		{
			goto IL_0064;
		}
	}
	{
		goto IL_00eb;
	}

IL_0083:
	{
		ControllerHelper_tCE72EA23053BD0C6ECB4D75A69F8CD1B3AC28FF6* L_27 = (ControllerHelper_tCE72EA23053BD0C6ECB4D75A69F8CD1B3AC28FF6*)__this->___JOhXpftGzsqKykxdovItahCXjNZ_2;
		NullCheck(L_27);
		vpfVMfLDNQCKabtrXuyMMndafvvoA_t24DAE63535EED93A1490AC97901F2551704D116D* L_28 = (vpfVMfLDNQCKabtrXuyMMndafvvoA_t24DAE63535EED93A1490AC97901F2551704D116D*)L_27->___rGIwSbUPDgDDJByCitUBBGoZDlmc_0;
		NullCheck(L_28);
		int32_t L_29 = (int32_t)L_28->___TIKqvTvXeujXUEcFBSnvvfWjpzmS_0;
		V_4 = L_29;
		V_5 = 0;
		goto IL_00e5;
	}

IL_009a:
	{
		ControllerHelper_tCE72EA23053BD0C6ECB4D75A69F8CD1B3AC28FF6* L_30 = (ControllerHelper_tCE72EA23053BD0C6ECB4D75A69F8CD1B3AC28FF6*)__this->___JOhXpftGzsqKykxdovItahCXjNZ_2;
		NullCheck(L_30);
		vpfVMfLDNQCKabtrXuyMMndafvvoA_t24DAE63535EED93A1490AC97901F2551704D116D* L_31 = (vpfVMfLDNQCKabtrXuyMMndafvvoA_t24DAE63535EED93A1490AC97901F2551704D116D*)L_30->___rGIwSbUPDgDDJByCitUBBGoZDlmc_0;
		int32_t L_32 = V_5;
		NullCheck(L_31);
		RuntimeObject* L_33;
		L_33 = vpfVMfLDNQCKabtrXuyMMndafvvoA_WnvLUDAsClwKBCDbOHhIRBMdKTgv_mFB15C8D1E61FDBCCAB87F4892BB7481AF3BBEE6F(L_31, L_32, NULL);
		V_6 = L_33;
		RuntimeObject* L_34 = V_6;
		NullCheck(L_34);
		int32_t L_35;
		L_35 = InterfaceFuncInvoker0< int32_t >::Invoke(2 /* System.Int32 Rewired.Player/ControllerHelper/ftuHLSCvHbrPYKqmDICMGujVuqLSA::NEFjFYSXjpJmKUMrQuBCmBemjvSFA() */, ftuHLSCvHbrPYKqmDICMGujVuqLSA_tD67CC6A3A416E57262B63617FA5896CF7BF4F187_il2cpp_TypeInfo_var, L_34);
		V_7 = L_35;
		V_8 = 0;
		goto IL_00d9;
	}

IL_00bc:
	{
		RuntimeObject* L_36 = V_6;
		int32_t L_37 = V_8;
		NullCheck(L_36);
		RuntimeObject* L_38;
		L_38 = InterfaceFuncInvoker1< RuntimeObject*, int32_t >::Invoke(0 /* Rewired.Player/ControllerHelper/ccKIYWnZwPjlGgvjpHVACPHqZTWG Rewired.Player/ControllerHelper/ftuHLSCvHbrPYKqmDICMGujVuqLSA::ZfIXNjSNQNQjmCdAUEIsaOrcLoPs(System.Int32) */, ftuHLSCvHbrPYKqmDICMGujVuqLSA_tD67CC6A3A416E57262B63617FA5896CF7BF4F187_il2cpp_TypeInfo_var, L_36, L_37);
		NullCheck(L_38);
		RuntimeObject* L_39;
		L_39 = InterfaceFuncInvoker0< RuntimeObject* >::Invoke(0 /* hDTwQOONkmiSaaPHwqpfFkmXMCAbb Rewired.Player/ControllerHelper/ccKIYWnZwPjlGgvjpHVACPHqZTWG::DJykFGUxbFlHMIneTwfokcsefclu() */, ccKIYWnZwPjlGgvjpHVACPHqZTWG_t7AB72F4748B9EC6B1975F90F35E5838740AD2011_il2cpp_TypeInfo_var, L_38);
		int32_t L_40 = ___categoryId0;
		List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D* L_41 = ___results1;
		NullCheck(L_39);
		int32_t L_42;
		L_42 = GenericInterfaceFuncInvoker3< int32_t, int32_t, List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D*, bool >::Invoke(il2cpp_rgctx_method(method->rgctx_data, 3), L_39, L_40, L_41, (bool)1);
		int32_t L_43 = V_8;
		V_8 = ((int32_t)il2cpp_codegen_add(L_43, 1));
	}

IL_00d9:
	{
		int32_t L_44 = V_8;
		int32_t L_45 = V_7;
		if ((((int32_t)L_44) < ((int32_t)L_45)))
		{
			goto IL_00bc;
		}
	}
	{
		int32_t L_46 = V_5;
		V_5 = ((int32_t)il2cpp_codegen_add(L_46, 1));
	}

IL_00e5:
	{
		int32_t L_47 = V_5;
		int32_t L_48 = V_4;
		if ((((int32_t)L_47) < ((int32_t)L_48)))
		{
			goto IL_009a;
		}
	}

IL_00eb:
	{
		List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D* L_49 = ___results1;
		NullCheck(L_49);
		int32_t L_50;
		L_50 = ((  int32_t (*) (List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D*, const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->rgctx_data, 4)))(L_49, il2cpp_rgctx_method(method->rgctx_data, 4));
		return L_50;
	}
}
// System.Int32 Rewired.Player/ControllerHelper/MapHelper::GetAllMapsInCategory<System.Object>(System.String,System.Collections.Generic.List`1<T>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t MapHelper_GetAllMapsInCategory_TisRuntimeObject_m2FF48FC70CADFFE41CEE4DBCCF11796B67BF2F33_gshared (MapHelper_t214BA4F045E5EB4B312E4E6AEB6697813117A7C2* __this, String_t* ___categoryName0, List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D* ___results1, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
int32_t V_0 = 0;
	{
		il2cpp_codegen_runtime_class_init_inline(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		int32_t L_0 = ((ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_StaticFields*)il2cpp_codegen_static_fields_for(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var))->____id_29;
		int32_t L_1 = (int32_t)__this->___eNyGUiEiMyquCTKLRhFvpeyOvzMm_5;
		if ((((int32_t)L_0) == ((int32_t)L_1)))
		{
			goto IL_001b;
		}
	}
	{
		int32_t L_2 = (int32_t)__this->___eNyGUiEiMyquCTKLRhFvpeyOvzMm_5;
		il2cpp_codegen_runtime_class_init_inline(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		bool L_3;
		L_3 = ReInput_CheckInitialized_mAAC593CB03C886BDB7B72864FBB1A59B2B0530AF(L_2, NULL);
		return 0;
	}

IL_001b:
	{
		il2cpp_codegen_runtime_class_init_inline(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		MappingHelper_t18AE344473D49AF2E7133108678DD4D963699662* L_4;
		L_4 = ReInput_get_mapping_mDE6BD708754EB86C540ACCB26BFD21D1F8054554(NULL);
		String_t* L_5 = ___categoryName0;
		NullCheck(L_4);
		int32_t L_6;
		L_6 = MappingHelper_GetMapCategoryId_mFC02A9FF6A6BFF6C38668558CB3DC6EB598077FB(L_4, L_5, NULL);
		V_0 = L_6;
		int32_t L_7 = V_0;
		if ((((int32_t)L_7) >= ((int32_t)0)))
		{
			goto IL_002d;
		}
	}
	{
		return 0;
	}

IL_002d:
	{
		int32_t L_8 = V_0;
		List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D* L_9 = ___results1;
		int32_t L_10;
		L_10 = ((  int32_t (*) (MapHelper_t214BA4F045E5EB4B312E4E6AEB6697813117A7C2*, int32_t, List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D*, const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->rgctx_data, 0)))(__this, L_8, L_9, il2cpp_rgctx_method(method->rgctx_data, 0));
		return L_10;
	}
}
// T Rewired.Player/ControllerHelper/MapHelper::GetFirstMapInCategory<System.Object>(System.Int32,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* MapHelper_GetFirstMapInCategory_TisRuntimeObject_mD4E90C2675ABC375303448AA24E8B2DF314C6FF5_gshared (MapHelper_t214BA4F045E5EB4B312E4E6AEB6697813117A7C2* __this, int32_t ___controllerId0, int32_t ___categoryId1, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
RuntimeObject* V_0 = NULL;
	{
		il2cpp_codegen_runtime_class_init_inline(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		int32_t L_0 = ((ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_StaticFields*)il2cpp_codegen_static_fields_for(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var))->____id_29;
		int32_t L_1 = (int32_t)__this->___eNyGUiEiMyquCTKLRhFvpeyOvzMm_5;
		if ((((int32_t)L_0) == ((int32_t)L_1)))
		{
			goto IL_0023;
		}
	}
	{
		int32_t L_2 = (int32_t)__this->___eNyGUiEiMyquCTKLRhFvpeyOvzMm_5;
		il2cpp_codegen_runtime_class_init_inline(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		bool L_3;
		L_3 = ReInput_CheckInitialized_mAAC593CB03C886BDB7B72864FBB1A59B2B0530AF(L_2, NULL);
		il2cpp_codegen_initobj((&V_0), sizeof(RuntimeObject*));
		RuntimeObject* L_4 = V_0;
		return L_4;
	}

IL_0023:
	{
		int32_t L_5 = ___categoryId1;
		if ((((int32_t)L_5) >= ((int32_t)0)))
		{
			goto IL_0031;
		}
	}
	{
		il2cpp_codegen_initobj((&V_0), sizeof(RuntimeObject*));
		RuntimeObject* L_6 = V_0;
		return L_6;
	}

IL_0031:
	{
		int32_t L_7;
		L_7 = ((  int32_t (*) (const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->rgctx_data, 0)))(il2cpp_rgctx_method(method->rgctx_data, 0));
		int32_t L_8 = ___controllerId0;
		int32_t L_9 = ___categoryId1;
		ControllerMap_tC01A582E577E38D21EB7D87A8C040AF5DA285FB3* L_10;
		L_10 = MapHelper_tXTzuxnKeaFcJkTzJwQUsSwUoCsRA_mF1BB015F2E3CACA5BBF1FD7BB5FDE74068F7D365(__this, L_7, L_8, L_9, NULL);
		return ((RuntimeObject*)Castclass((RuntimeObject*)L_10, il2cpp_rgctx_data(method->rgctx_data, 1)));
	}
}
// T Rewired.Player/ControllerHelper/MapHelper::GetFirstMapInCategory<System.Object>(System.Int32,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* MapHelper_GetFirstMapInCategory_TisRuntimeObject_mB395AB93505B347BDEC591C38ABE6FFB5A15737E_gshared (MapHelper_t214BA4F045E5EB4B312E4E6AEB6697813117A7C2* __this, int32_t ___controllerId0, String_t* ___categoryName1, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
int32_t V_0 = 0;
	RuntimeObject* V_1 = NULL;
	{
		il2cpp_codegen_runtime_class_init_inline(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		int32_t L_0 = ((ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_StaticFields*)il2cpp_codegen_static_fields_for(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var))->____id_29;
		int32_t L_1 = (int32_t)__this->___eNyGUiEiMyquCTKLRhFvpeyOvzMm_5;
		if ((((int32_t)L_0) == ((int32_t)L_1)))
		{
			goto IL_0023;
		}
	}
	{
		int32_t L_2 = (int32_t)__this->___eNyGUiEiMyquCTKLRhFvpeyOvzMm_5;
		il2cpp_codegen_runtime_class_init_inline(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		bool L_3;
		L_3 = ReInput_CheckInitialized_mAAC593CB03C886BDB7B72864FBB1A59B2B0530AF(L_2, NULL);
		il2cpp_codegen_initobj((&V_1), sizeof(RuntimeObject*));
		RuntimeObject* L_4 = V_1;
		return L_4;
	}

IL_0023:
	{
		il2cpp_codegen_runtime_class_init_inline(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		MappingHelper_t18AE344473D49AF2E7133108678DD4D963699662* L_5;
		L_5 = ReInput_get_mapping_mDE6BD708754EB86C540ACCB26BFD21D1F8054554(NULL);
		String_t* L_6 = ___categoryName1;
		NullCheck(L_5);
		int32_t L_7;
		L_7 = MappingHelper_GetMapCategoryId_mFC02A9FF6A6BFF6C38668558CB3DC6EB598077FB(L_5, L_6, NULL);
		V_0 = L_7;
		int32_t L_8 = V_0;
		if ((((int32_t)L_8) >= ((int32_t)0)))
		{
			goto IL_003d;
		}
	}
	{
		il2cpp_codegen_initobj((&V_1), sizeof(RuntimeObject*));
		RuntimeObject* L_9 = V_1;
		return L_9;
	}

IL_003d:
	{
		int32_t L_10 = ___controllerId0;
		int32_t L_11 = V_0;
		RuntimeObject* L_12;
		L_12 = ((  RuntimeObject* (*) (MapHelper_t214BA4F045E5EB4B312E4E6AEB6697813117A7C2*, int32_t, int32_t, const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->rgctx_data, 0)))(__this, L_10, L_11, il2cpp_rgctx_method(method->rgctx_data, 0));
		return L_12;
	}
}
// T Rewired.Player/ControllerHelper/MapHelper::GetMap<System.Object>(System.Int32,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* MapHelper_GetMap_TisRuntimeObject_mD8AA613CF01C9AE281CF2CAB94FAE83215FEBF48_gshared (MapHelper_t214BA4F045E5EB4B312E4E6AEB6697813117A7C2* __this, int32_t ___controllerId0, int32_t ___mapId1, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
RuntimeObject* V_0 = NULL;
	{
		il2cpp_codegen_runtime_class_init_inline(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		int32_t L_0 = ((ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_StaticFields*)il2cpp_codegen_static_fields_for(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var))->____id_29;
		int32_t L_1 = (int32_t)__this->___eNyGUiEiMyquCTKLRhFvpeyOvzMm_5;
		if ((((int32_t)L_0) == ((int32_t)L_1)))
		{
			goto IL_0023;
		}
	}
	{
		int32_t L_2 = (int32_t)__this->___eNyGUiEiMyquCTKLRhFvpeyOvzMm_5;
		il2cpp_codegen_runtime_class_init_inline(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		bool L_3;
		L_3 = ReInput_CheckInitialized_mAAC593CB03C886BDB7B72864FBB1A59B2B0530AF(L_2, NULL);
		il2cpp_codegen_initobj((&V_0), sizeof(RuntimeObject*));
		RuntimeObject* L_4 = V_0;
		return L_4;
	}

IL_0023:
	{
		int32_t L_5 = ___mapId1;
		if ((((int32_t)L_5) >= ((int32_t)0)))
		{
			goto IL_0031;
		}
	}
	{
		il2cpp_codegen_initobj((&V_0), sizeof(RuntimeObject*));
		RuntimeObject* L_6 = V_0;
		return L_6;
	}

IL_0031:
	{
		int32_t L_7;
		L_7 = ((  int32_t (*) (const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->rgctx_data, 0)))(il2cpp_rgctx_method(method->rgctx_data, 0));
		int32_t L_8 = ___controllerId0;
		int32_t L_9 = ___mapId1;
		ControllerMap_tC01A582E577E38D21EB7D87A8C040AF5DA285FB3* L_10;
		L_10 = MapHelper_qYqBIOFxqlADXLihiBsFcAqNepub_mF5BC6DA17BCBE2D8833A183352C5F877C7CD6F2B(__this, L_7, L_8, L_9, NULL);
		return ((RuntimeObject*)Castclass((RuntimeObject*)L_10, il2cpp_rgctx_data(method->rgctx_data, 1)));
	}
}
// T Rewired.Player/ControllerHelper/MapHelper::GetMap<System.Object>(System.Int32,System.Int32,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* MapHelper_GetMap_TisRuntimeObject_mFA274DDC1671882E5BFCA3311F3CF0496E6260AA_gshared (MapHelper_t214BA4F045E5EB4B312E4E6AEB6697813117A7C2* __this, int32_t ___controllerId0, int32_t ___categoryId1, int32_t ___layoutId2, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
RuntimeObject* V_0 = NULL;
	{
		il2cpp_codegen_runtime_class_init_inline(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		int32_t L_0 = ((ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_StaticFields*)il2cpp_codegen_static_fields_for(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var))->____id_29;
		int32_t L_1 = (int32_t)__this->___eNyGUiEiMyquCTKLRhFvpeyOvzMm_5;
		if ((((int32_t)L_0) == ((int32_t)L_1)))
		{
			goto IL_0023;
		}
	}
	{
		int32_t L_2 = (int32_t)__this->___eNyGUiEiMyquCTKLRhFvpeyOvzMm_5;
		il2cpp_codegen_runtime_class_init_inline(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		bool L_3;
		L_3 = ReInput_CheckInitialized_mAAC593CB03C886BDB7B72864FBB1A59B2B0530AF(L_2, NULL);
		il2cpp_codegen_initobj((&V_0), sizeof(RuntimeObject*));
		RuntimeObject* L_4 = V_0;
		return L_4;
	}

IL_0023:
	{
		int32_t L_5 = ___categoryId1;
		if ((((int32_t)L_5) < ((int32_t)0)))
		{
			goto IL_002b;
		}
	}
	{
		int32_t L_6 = ___layoutId2;
		if ((((int32_t)L_6) >= ((int32_t)0)))
		{
			goto IL_0035;
		}
	}

IL_002b:
	{
		il2cpp_codegen_initobj((&V_0), sizeof(RuntimeObject*));
		RuntimeObject* L_7 = V_0;
		return L_7;
	}

IL_0035:
	{
		int32_t L_8;
		L_8 = ((  int32_t (*) (const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->rgctx_data, 0)))(il2cpp_rgctx_method(method->rgctx_data, 0));
		int32_t L_9 = ___controllerId0;
		int32_t L_10 = ___categoryId1;
		int32_t L_11 = ___layoutId2;
		ControllerMap_tC01A582E577E38D21EB7D87A8C040AF5DA285FB3* L_12;
		L_12 = MapHelper_qYqBIOFxqlADXLihiBsFcAqNepub_mA72BABB67A8FEDFC05D5020E5F5B09570B71F927(__this, L_8, L_9, L_10, L_11, NULL);
		return ((RuntimeObject*)Castclass((RuntimeObject*)L_12, il2cpp_rgctx_data(method->rgctx_data, 1)));
	}
}
// T Rewired.Player/ControllerHelper/MapHelper::GetMap<System.Object>(System.Int32,System.String,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* MapHelper_GetMap_TisRuntimeObject_m2BA5295B6A3B934D9EF8A3AB8FCB85C457B6BE55_gshared (MapHelper_t214BA4F045E5EB4B312E4E6AEB6697813117A7C2* __this, int32_t ___controllerId0, String_t* ___categoryName1, String_t* ___layoutName2, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
RuntimeObject* V_0 = NULL;
	{
		il2cpp_codegen_runtime_class_init_inline(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		int32_t L_0 = ((ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_StaticFields*)il2cpp_codegen_static_fields_for(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var))->____id_29;
		int32_t L_1 = (int32_t)__this->___eNyGUiEiMyquCTKLRhFvpeyOvzMm_5;
		if ((((int32_t)L_0) == ((int32_t)L_1)))
		{
			goto IL_0023;
		}
	}
	{
		int32_t L_2 = (int32_t)__this->___eNyGUiEiMyquCTKLRhFvpeyOvzMm_5;
		il2cpp_codegen_runtime_class_init_inline(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		bool L_3;
		L_3 = ReInput_CheckInitialized_mAAC593CB03C886BDB7B72864FBB1A59B2B0530AF(L_2, NULL);
		il2cpp_codegen_initobj((&V_0), sizeof(RuntimeObject*));
		RuntimeObject* L_4 = V_0;
		return L_4;
	}

IL_0023:
	{
		int32_t L_5;
		L_5 = ((  int32_t (*) (const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->rgctx_data, 0)))(il2cpp_rgctx_method(method->rgctx_data, 0));
		int32_t L_6 = ___controllerId0;
		String_t* L_7 = ___categoryName1;
		String_t* L_8 = ___layoutName2;
		ControllerMap_tC01A582E577E38D21EB7D87A8C040AF5DA285FB3* L_9;
		L_9 = MapHelper_qYqBIOFxqlADXLihiBsFcAqNepub_mB544FDCDF4762ABA843DC4D4395B51F558E2913A(__this, L_5, L_6, L_7, L_8, NULL);
		return ((RuntimeObject*)Castclass((RuntimeObject*)L_9, il2cpp_rgctx_data(method->rgctx_data, 1)));
	}
}
// T[] Rewired.Player/ControllerHelper/MapHelper::GetMapSaveData<System.Object>(System.Int32,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* MapHelper_GetMapSaveData_TisRuntimeObject_mE87F41817A9DD31A9ABB341F2D45C8003154AECE_gshared (MapHelper_t214BA4F045E5EB4B312E4E6AEB6697813117A7C2* __this, int32_t ___controllerId0, bool ___userAssignableMapsOnly1, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
{
		il2cpp_codegen_runtime_class_init_inline(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		int32_t L_0 = ((ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_StaticFields*)il2cpp_codegen_static_fields_for(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var))->____id_29;
		int32_t L_1 = (int32_t)__this->___eNyGUiEiMyquCTKLRhFvpeyOvzMm_5;
		if ((((int32_t)L_0) == ((int32_t)L_1)))
		{
			goto IL_001f;
		}
	}
	{
		int32_t L_2 = (int32_t)__this->___eNyGUiEiMyquCTKLRhFvpeyOvzMm_5;
		il2cpp_codegen_runtime_class_init_inline(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		bool L_3;
		L_3 = ReInput_CheckInitialized_mAAC593CB03C886BDB7B72864FBB1A59B2B0530AF(L_2, NULL);
		ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* L_4;
		L_4 = ((  ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* (*) (const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->rgctx_data, 0)))(il2cpp_rgctx_method(method->rgctx_data, 0));
		return L_4;
	}

IL_001f:
	{
		int32_t L_5 = ___controllerId0;
		bool L_6 = ___userAssignableMapsOnly1;
		ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* L_7;
		L_7 = ((  ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* (*) (MapHelper_t214BA4F045E5EB4B312E4E6AEB6697813117A7C2*, int32_t, bool, const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->rgctx_data, 2)))(__this, L_5, L_6, il2cpp_rgctx_method(method->rgctx_data, 2));
		return L_7;
	}
}
// System.Collections.Generic.IList`1<T> Rewired.Player/ControllerHelper/MapHelper::GetMaps<System.Object>(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* MapHelper_GetMaps_TisRuntimeObject_m56D26C2BE639F0E8706430376972E43A361AD2CA_gshared (MapHelper_t214BA4F045E5EB4B312E4E6AEB6697813117A7C2* __this, int32_t ___controllerId0, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
{
		il2cpp_codegen_runtime_class_init_inline(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		int32_t L_0 = ((ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_StaticFields*)il2cpp_codegen_static_fields_for(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var))->____id_29;
		int32_t L_1 = (int32_t)__this->___eNyGUiEiMyquCTKLRhFvpeyOvzMm_5;
		if ((((int32_t)L_0) == ((int32_t)L_1)))
		{
			goto IL_001f;
		}
	}
	{
		int32_t L_2 = (int32_t)__this->___eNyGUiEiMyquCTKLRhFvpeyOvzMm_5;
		il2cpp_codegen_runtime_class_init_inline(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		bool L_3;
		L_3 = ReInput_CheckInitialized_mAAC593CB03C886BDB7B72864FBB1A59B2B0530AF(L_2, NULL);
		RuntimeObject* L_4;
		L_4 = ((  RuntimeObject* (*) (const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->rgctx_data, 0)))(il2cpp_rgctx_method(method->rgctx_data, 0));
		return L_4;
	}

IL_001f:
	{
		int32_t L_5 = ___controllerId0;
		RuntimeObject* L_6;
		L_6 = ((  RuntimeObject* (*) (MapHelper_t214BA4F045E5EB4B312E4E6AEB6697813117A7C2*, int32_t, const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->rgctx_data, 2)))(__this, L_5, il2cpp_rgctx_method(method->rgctx_data, 2));
		return L_6;
	}
}
// System.Collections.Generic.IEnumerable`1<T> Rewired.Player/ControllerHelper/MapHelper::GetMapsInCategory<System.Object>(System.Int32,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* MapHelper_GetMapsInCategory_TisRuntimeObject_mDF27D549D9D0CE05AEDEE7CCCBC48978DEF8AD9F_gshared (MapHelper_t214BA4F045E5EB4B312E4E6AEB6697813117A7C2* __this, int32_t ___controllerId0, int32_t ___categoryId1, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
{
		il2cpp_codegen_runtime_class_init_inline(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		int32_t L_0 = ((ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_StaticFields*)il2cpp_codegen_static_fields_for(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var))->____id_29;
		int32_t L_1 = (int32_t)__this->___eNyGUiEiMyquCTKLRhFvpeyOvzMm_5;
		if ((((int32_t)L_0) == ((int32_t)L_1)))
		{
			goto IL_001f;
		}
	}
	{
		int32_t L_2 = (int32_t)__this->___eNyGUiEiMyquCTKLRhFvpeyOvzMm_5;
		il2cpp_codegen_runtime_class_init_inline(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		bool L_3;
		L_3 = ReInput_CheckInitialized_mAAC593CB03C886BDB7B72864FBB1A59B2B0530AF(L_2, NULL);
		RuntimeObject* L_4;
		L_4 = ((  RuntimeObject* (*) (const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->rgctx_data, 0)))(il2cpp_rgctx_method(method->rgctx_data, 0));
		return (RuntimeObject*)L_4;
	}

IL_001f:
	{
		int32_t L_5 = ___controllerId0;
		int32_t L_6 = ___categoryId1;
		RuntimeObject* L_7;
		L_7 = ((  RuntimeObject* (*) (MapHelper_t214BA4F045E5EB4B312E4E6AEB6697813117A7C2*, int32_t, int32_t, const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->rgctx_data, 2)))(__this, L_5, L_6, il2cpp_rgctx_method(method->rgctx_data, 2));
		return L_7;
	}
}
// System.Collections.Generic.IEnumerable`1<T> Rewired.Player/ControllerHelper/MapHelper::GetMapsInCategory<System.Object>(System.Int32,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* MapHelper_GetMapsInCategory_TisRuntimeObject_m698FD4BF5F0A7F63533FC15984C3C3A7E6119722_gshared (MapHelper_t214BA4F045E5EB4B312E4E6AEB6697813117A7C2* __this, int32_t ___controllerId0, String_t* ___categoryName1, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
int32_t V_0 = 0;
	{
		il2cpp_codegen_runtime_class_init_inline(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		int32_t L_0 = ((ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_StaticFields*)il2cpp_codegen_static_fields_for(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var))->____id_29;
		int32_t L_1 = (int32_t)__this->___eNyGUiEiMyquCTKLRhFvpeyOvzMm_5;
		if ((((int32_t)L_0) == ((int32_t)L_1)))
		{
			goto IL_001f;
		}
	}
	{
		int32_t L_2 = (int32_t)__this->___eNyGUiEiMyquCTKLRhFvpeyOvzMm_5;
		il2cpp_codegen_runtime_class_init_inline(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		bool L_3;
		L_3 = ReInput_CheckInitialized_mAAC593CB03C886BDB7B72864FBB1A59B2B0530AF(L_2, NULL);
		RuntimeObject* L_4;
		L_4 = ((  RuntimeObject* (*) (const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->rgctx_data, 0)))(il2cpp_rgctx_method(method->rgctx_data, 0));
		return (RuntimeObject*)L_4;
	}

IL_001f:
	{
		il2cpp_codegen_runtime_class_init_inline(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		MappingHelper_t18AE344473D49AF2E7133108678DD4D963699662* L_5;
		L_5 = ReInput_get_mapping_mDE6BD708754EB86C540ACCB26BFD21D1F8054554(NULL);
		String_t* L_6 = ___categoryName1;
		NullCheck(L_5);
		int32_t L_7;
		L_7 = MappingHelper_GetMapCategoryId_mFC02A9FF6A6BFF6C38668558CB3DC6EB598077FB(L_5, L_6, NULL);
		V_0 = L_7;
		int32_t L_8 = V_0;
		if ((((int32_t)L_8) >= ((int32_t)0)))
		{
			goto IL_0035;
		}
	}
	{
		RuntimeObject* L_9;
		L_9 = ((  RuntimeObject* (*) (const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->rgctx_data, 0)))(il2cpp_rgctx_method(method->rgctx_data, 0));
		return (RuntimeObject*)L_9;
	}

IL_0035:
	{
		int32_t L_10 = ___controllerId0;
		int32_t L_11 = V_0;
		RuntimeObject* L_12;
		L_12 = ((  RuntimeObject* (*) (MapHelper_t214BA4F045E5EB4B312E4E6AEB6697813117A7C2*, int32_t, int32_t, const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->rgctx_data, 2)))(__this, L_10, L_11, il2cpp_rgctx_method(method->rgctx_data, 2));
		return L_12;
	}
}
// System.Int32 Rewired.Player/ControllerHelper/MapHelper::GetMapsInCategory<System.Object>(System.Int32,System.Int32,System.Collections.Generic.List`1<T>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t MapHelper_GetMapsInCategory_TisRuntimeObject_mD3FCC7B7E3E92BD67FBD312A75A0B08B972A7427_gshared (MapHelper_t214BA4F045E5EB4B312E4E6AEB6697813117A7C2* __this, int32_t ___controllerId0, int32_t ___categoryId1, List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D* ___results2, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ccKIYWnZwPjlGgvjpHVACPHqZTWG_t7AB72F4748B9EC6B1975F90F35E5838740AD2011_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ftuHLSCvHbrPYKqmDICMGujVuqLSA_tD67CC6A3A416E57262B63617FA5896CF7BF4F187_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
RuntimeObject* V_0 = NULL;
	{
		il2cpp_codegen_runtime_class_init_inline(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		int32_t L_0 = ((ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_StaticFields*)il2cpp_codegen_static_fields_for(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var))->____id_29;
		int32_t L_1 = (int32_t)__this->___eNyGUiEiMyquCTKLRhFvpeyOvzMm_5;
		if ((((int32_t)L_0) == ((int32_t)L_1)))
		{
			goto IL_001b;
		}
	}
	{
		int32_t L_2 = (int32_t)__this->___eNyGUiEiMyquCTKLRhFvpeyOvzMm_5;
		il2cpp_codegen_runtime_class_init_inline(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		bool L_3;
		L_3 = ReInput_CheckInitialized_mAAC593CB03C886BDB7B72864FBB1A59B2B0530AF(L_2, NULL);
		return 0;
	}

IL_001b:
	{
		List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D* L_4 = ___results2;
		if (L_4)
		{
			goto IL_0029;
		}
	}
	{
		ArgumentNullException_t327031E412FAB2351B0022DD5DAD47E67E597129* L_5 = (ArgumentNullException_t327031E412FAB2351B0022DD5DAD47E67E597129*)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&ArgumentNullException_t327031E412FAB2351B0022DD5DAD47E67E597129_il2cpp_TypeInfo_var)));
		ArgumentNullException__ctor_m444AE141157E333844FC1A9500224C2F9FD24F4B(L_5, ((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteral9AB16B3999460DDC981865934D979087351A14F2)), /*hidden argument*/NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_5, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&MapHelper_GetMapsInCategory_TisRuntimeObject_mD3FCC7B7E3E92BD67FBD312A75A0B08B972A7427_RuntimeMethod_var)));
	}

IL_0029:
	{
		List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D* L_6 = ___results2;
		NullCheck(L_6);
		((  void (*) (List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D*, const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->rgctx_data, 1)))(L_6, il2cpp_rgctx_method(method->rgctx_data, 1));
		il2cpp_codegen_runtime_class_init_inline(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		MappingHelper_t18AE344473D49AF2E7133108678DD4D963699662* L_7;
		L_7 = ReInput_get_mapping_mDE6BD708754EB86C540ACCB26BFD21D1F8054554(NULL);
		int32_t L_8 = ___categoryId1;
		NullCheck(L_7);
		InputMapCategory_t309A7C800100DDCC67C5C6A69F960A1D71768111* L_9;
		L_9 = MappingHelper_GetMapCategory_m6B8082A9D9CAAB69B2EC97F6B2FCAF94C5C88DBD(L_7, L_8, NULL);
		if (L_9)
		{
			goto IL_003e;
		}
	}
	{
		return 0;
	}

IL_003e:
	{
		RuntimeObject* L_10;
		L_10 = ((  RuntimeObject* (*) (MapHelper_t214BA4F045E5EB4B312E4E6AEB6697813117A7C2*, const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->rgctx_data, 2)))(__this, il2cpp_rgctx_method(method->rgctx_data, 2));
		int32_t L_11 = ___controllerId0;
		NullCheck(L_10);
		RuntimeObject* L_12;
		L_12 = InterfaceFuncInvoker1< RuntimeObject*, int32_t >::Invoke(14 /* Rewired.Player/ControllerHelper/ccKIYWnZwPjlGgvjpHVACPHqZTWG Rewired.Player/ControllerHelper/ftuHLSCvHbrPYKqmDICMGujVuqLSA::howjPBfRJshDbKOTcPHxFqZjkrDUB(System.Int32) */, ftuHLSCvHbrPYKqmDICMGujVuqLSA_tD67CC6A3A416E57262B63617FA5896CF7BF4F187_il2cpp_TypeInfo_var, L_10, L_11);
		V_0 = L_12;
		RuntimeObject* L_13 = V_0;
		if (L_13)
		{
			goto IL_0050;
		}
	}
	{
		return 0;
	}

IL_0050:
	{
		RuntimeObject* L_14 = V_0;
		NullCheck(L_14);
		RuntimeObject* L_15;
		L_15 = InterfaceFuncInvoker0< RuntimeObject* >::Invoke(0 /* hDTwQOONkmiSaaPHwqpfFkmXMCAbb Rewired.Player/ControllerHelper/ccKIYWnZwPjlGgvjpHVACPHqZTWG::DJykFGUxbFlHMIneTwfokcsefclu() */, ccKIYWnZwPjlGgvjpHVACPHqZTWG_t7AB72F4748B9EC6B1975F90F35E5838740AD2011_il2cpp_TypeInfo_var, L_14);
		int32_t L_16 = ___categoryId1;
		List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D* L_17 = ___results2;
		NullCheck(L_15);
		int32_t L_18;
		L_18 = GenericInterfaceFuncInvoker3< int32_t, int32_t, List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D*, bool >::Invoke(il2cpp_rgctx_method(method->rgctx_data, 3), L_15, L_16, L_17, (bool)1);
		List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D* L_19 = ___results2;
		NullCheck(L_19);
		int32_t L_20;
		L_20 = ((  int32_t (*) (List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D*, const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->rgctx_data, 4)))(L_19, il2cpp_rgctx_method(method->rgctx_data, 4));
		return L_20;
	}
}
// System.Int32 Rewired.Player/ControllerHelper/MapHelper::GetMapsInCategory<System.Object>(System.Int32,System.String,System.Collections.Generic.List`1<T>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t MapHelper_GetMapsInCategory_TisRuntimeObject_m50028FF3E8391ADD501F975C0AB5708419A9DC4C_gshared (MapHelper_t214BA4F045E5EB4B312E4E6AEB6697813117A7C2* __this, int32_t ___controllerId0, String_t* ___categoryName1, List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D* ___results2, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
int32_t V_0 = 0;
	{
		il2cpp_codegen_runtime_class_init_inline(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		int32_t L_0 = ((ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_StaticFields*)il2cpp_codegen_static_fields_for(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var))->____id_29;
		int32_t L_1 = (int32_t)__this->___eNyGUiEiMyquCTKLRhFvpeyOvzMm_5;
		if ((((int32_t)L_0) == ((int32_t)L_1)))
		{
			goto IL_001b;
		}
	}
	{
		int32_t L_2 = (int32_t)__this->___eNyGUiEiMyquCTKLRhFvpeyOvzMm_5;
		il2cpp_codegen_runtime_class_init_inline(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		bool L_3;
		L_3 = ReInput_CheckInitialized_mAAC593CB03C886BDB7B72864FBB1A59B2B0530AF(L_2, NULL);
		return 0;
	}

IL_001b:
	{
		List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D* L_4 = ___results2;
		((  void (*) (RuntimeObject*, const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->rgctx_data, 0)))((RuntimeObject*)L_4, il2cpp_rgctx_method(method->rgctx_data, 0));
		il2cpp_codegen_runtime_class_init_inline(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		MappingHelper_t18AE344473D49AF2E7133108678DD4D963699662* L_5;
		L_5 = ReInput_get_mapping_mDE6BD708754EB86C540ACCB26BFD21D1F8054554(NULL);
		String_t* L_6 = ___categoryName1;
		NullCheck(L_5);
		int32_t L_7;
		L_7 = MappingHelper_GetMapCategoryId_mFC02A9FF6A6BFF6C38668558CB3DC6EB598077FB(L_5, L_6, NULL);
		V_0 = L_7;
		int32_t L_8 = V_0;
		if ((((int32_t)L_8) >= ((int32_t)0)))
		{
			goto IL_0033;
		}
	}
	{
		return 0;
	}

IL_0033:
	{
		int32_t L_9 = ___controllerId0;
		int32_t L_10 = V_0;
		List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D* L_11 = ___results2;
		int32_t L_12;
		L_12 = ((  int32_t (*) (MapHelper_t214BA4F045E5EB4B312E4E6AEB6697813117A7C2*, int32_t, int32_t, List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D*, const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->rgctx_data, 1)))(__this, L_9, L_10, L_11, il2cpp_rgctx_method(method->rgctx_data, 1));
		return L_12;
	}
}
// System.Collections.Generic.IEnumerable`1<?> Rewired.Player/ControllerHelper/MapHelper::HhEjHGfUFpDhUEzhIsTLLSlcjgTt<System.Object>(System.Int32,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* MapHelper_HhEjHGfUFpDhUEzhIsTLLSlcjgTt_TisRuntimeObject_m7E3F520EB3E0E24140563995CE47D9998656EA6E_gshared (MapHelper_t214BA4F045E5EB4B312E4E6AEB6697813117A7C2* __this, int32_t p0, int32_t p1, const RuntimeMethod* method) 
{
{
		ecjdcwfzgyPMBWdzOraiwfCBcrRoA_1_tCC80E04812F8A48B4DDE3B494ED31F6CC82A6A73* L_0 = (ecjdcwfzgyPMBWdzOraiwfCBcrRoA_1_tCC80E04812F8A48B4DDE3B494ED31F6CC82A6A73*)il2cpp_codegen_object_new(il2cpp_rgctx_data(method->rgctx_data, 0));
		ecjdcwfzgyPMBWdzOraiwfCBcrRoA_1__ctor_m34A74F392D550360F7C8349AB6963AEEEE9CC11B(L_0, ((int32_t)-2), /*hidden argument*/il2cpp_rgctx_method(method->rgctx_data, 1));
		ecjdcwfzgyPMBWdzOraiwfCBcrRoA_1_tCC80E04812F8A48B4DDE3B494ED31F6CC82A6A73* L_1 = L_0;
		NullCheck(L_1);
		L_1->___hJlvyFukKfMzsWcSVLwLCnIUdlMn_3 = __this;
		Il2CppCodeGenWriteBarrier((void**)(&L_1->___hJlvyFukKfMzsWcSVLwLCnIUdlMn_3), (void*)__this);
		ecjdcwfzgyPMBWdzOraiwfCBcrRoA_1_tCC80E04812F8A48B4DDE3B494ED31F6CC82A6A73* L_2 = L_1;
		int32_t L_3 = p0;
		NullCheck(L_2);
		L_2->___SgebiqeFPgLJkOQfmwCTESQqHVje_5 = L_3;
		ecjdcwfzgyPMBWdzOraiwfCBcrRoA_1_tCC80E04812F8A48B4DDE3B494ED31F6CC82A6A73* L_4 = L_2;
		int32_t L_5 = p1;
		NullCheck(L_4);
		L_4->___HyLMjUIcjSOZGGOJZWHdhVkIwYLO_7 = L_5;
		return (RuntimeObject*)L_4;
	}
}
// ?[] Rewired.Player/ControllerHelper/MapHelper::JQFZWOtCliAnOBrDkwQiJbYBgJKm<System.Object>(System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* MapHelper_JQFZWOtCliAnOBrDkwQiJbYBgJKm_TisRuntimeObject_m479FD02D7F64949C6F29C1A4091FE910F1E70F53_gshared (MapHelper_t214BA4F045E5EB4B312E4E6AEB6697813117A7C2* __this, bool p0, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ccKIYWnZwPjlGgvjpHVACPHqZTWG_t7AB72F4748B9EC6B1975F90F35E5838740AD2011_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ftuHLSCvHbrPYKqmDICMGujVuqLSA_tD67CC6A3A416E57262B63617FA5896CF7BF4F187_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&hDTwQOONkmiSaaPHwqpfFkmXMCAbb_tE1CD926FAF554AEBC6AFFC839A4294D64BE76AC3_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
int32_t V_0 = 0;
	RuntimeObject* V_1 = NULL;
	List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D* V_2 = NULL;
	int32_t V_3 = 0;
	RuntimeObject* V_4 = NULL;
	int32_t V_5 = 0;
	ControllerMap_tC01A582E577E38D21EB7D87A8C040AF5DA285FB3* V_6 = NULL;
	Controller_t919A4A50FC7A0F25D7B31615C0F4E4D4A4D17911* V_7 = NULL;
	InputMapCategory_t309A7C800100DDCC67C5C6A69F960A1D71768111* V_8 = NULL;
	{
		int32_t L_0;
		L_0 = ((  int32_t (*) (const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->rgctx_data, 0)))(il2cpp_rgctx_method(method->rgctx_data, 0));
		V_0 = L_0;
		ControllerHelper_tCE72EA23053BD0C6ECB4D75A69F8CD1B3AC28FF6* L_1 = (ControllerHelper_tCE72EA23053BD0C6ECB4D75A69F8CD1B3AC28FF6*)__this->___JOhXpftGzsqKykxdovItahCXjNZ_2;
		NullCheck(L_1);
		vpfVMfLDNQCKabtrXuyMMndafvvoA_t24DAE63535EED93A1490AC97901F2551704D116D* L_2 = (vpfVMfLDNQCKabtrXuyMMndafvvoA_t24DAE63535EED93A1490AC97901F2551704D116D*)L_1->___rGIwSbUPDgDDJByCitUBBGoZDlmc_0;
		int32_t L_3 = V_0;
		NullCheck(L_2);
		RuntimeObject* L_4;
		L_4 = vpfVMfLDNQCKabtrXuyMMndafvvoA_OlLACmpwoMamrxMTFzLaRnppBEGFA_m7D256F4AAE84410B2D3EC0217ADB4B49A6AE0B9F(L_2, L_3, NULL);
		V_1 = L_4;
		List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D* L_5 = (List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D*)il2cpp_codegen_object_new(il2cpp_rgctx_data(method->rgctx_data, 1));
		List_1__ctor_m7F078BB342729BDF11327FD89D7872265328F690(L_5, /*hidden argument*/il2cpp_rgctx_method(method->rgctx_data, 2));
		V_2 = L_5;
		V_3 = 0;
		goto IL_0095;
	}

IL_0022:
	{
		RuntimeObject* L_6 = V_1;
		int32_t L_7 = V_3;
		NullCheck(L_6);
		RuntimeObject* L_8;
		L_8 = InterfaceFuncInvoker1< RuntimeObject*, int32_t >::Invoke(0 /* Rewired.Player/ControllerHelper/ccKIYWnZwPjlGgvjpHVACPHqZTWG Rewired.Player/ControllerHelper/ftuHLSCvHbrPYKqmDICMGujVuqLSA::ZfIXNjSNQNQjmCdAUEIsaOrcLoPs(System.Int32) */, ftuHLSCvHbrPYKqmDICMGujVuqLSA_tD67CC6A3A416E57262B63617FA5896CF7BF4F187_il2cpp_TypeInfo_var, L_6, L_7);
		NullCheck(L_8);
		RuntimeObject* L_9;
		L_9 = InterfaceFuncInvoker0< RuntimeObject* >::Invoke(0 /* hDTwQOONkmiSaaPHwqpfFkmXMCAbb Rewired.Player/ControllerHelper/ccKIYWnZwPjlGgvjpHVACPHqZTWG::DJykFGUxbFlHMIneTwfokcsefclu() */, ccKIYWnZwPjlGgvjpHVACPHqZTWG_t7AB72F4748B9EC6B1975F90F35E5838740AD2011_il2cpp_TypeInfo_var, L_8);
		V_4 = L_9;
		V_5 = 0;
		goto IL_0086;
	}

IL_0035:
	{
		RuntimeObject* L_10 = V_4;
		int32_t L_11 = V_5;
		NullCheck(L_10);
		ControllerMap_tC01A582E577E38D21EB7D87A8C040AF5DA285FB3* L_12;
		L_12 = InterfaceFuncInvoker1< ControllerMap_tC01A582E577E38D21EB7D87A8C040AF5DA285FB3*, int32_t >::Invoke(0 /* Rewired.ControllerMap hDTwQOONkmiSaaPHwqpfFkmXMCAbb::ZfIXNjSNQNQjmCdAUEIsaOrcLoPs(System.Int32) */, hDTwQOONkmiSaaPHwqpfFkmXMCAbb_tE1CD926FAF554AEBC6AFFC839A4294D64BE76AC3_il2cpp_TypeInfo_var, L_10, L_11);
		V_6 = L_12;
		bool L_13 = p0;
		if (!L_13)
		{
			goto IL_0063;
		}
	}
	{
		il2cpp_codegen_runtime_class_init_inline(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		MappingHelper_t18AE344473D49AF2E7133108678DD4D963699662* L_14;
		L_14 = ReInput_get_mapping_mDE6BD708754EB86C540ACCB26BFD21D1F8054554(NULL);
		ControllerMap_tC01A582E577E38D21EB7D87A8C040AF5DA285FB3* L_15 = V_6;
		NullCheck(L_15);
		int32_t L_16;
		L_16 = ControllerMap_get_categoryId_m4D2BD4A8373EE16C75E13CB9B5ED8941A26D2B33(L_15, NULL);
		NullCheck(L_14);
		InputMapCategory_t309A7C800100DDCC67C5C6A69F960A1D71768111* L_17;
		L_17 = MappingHelper_GetMapCategory_m6B8082A9D9CAAB69B2EC97F6B2FCAF94C5C88DBD(L_14, L_16, NULL);
		V_8 = L_17;
		InputMapCategory_t309A7C800100DDCC67C5C6A69F960A1D71768111* L_18 = V_8;
		if (!L_18)
		{
			goto IL_0063;
		}
	}
	{
		InputMapCategory_t309A7C800100DDCC67C5C6A69F960A1D71768111* L_19 = V_8;
		NullCheck((InputCategory_t9C22614C15FBDA3F98B6F03EA3CEB547BF5F373C*)L_19);
		bool L_20;
		L_20 = InputCategory_get_userAssignable_mBD58AC35EE83AAE55914DC85584314585326C703_inline((InputCategory_t9C22614C15FBDA3F98B6F03EA3CEB547BF5F373C*)L_19, NULL);
		if (!L_20)
		{
			goto IL_0080;
		}
	}

IL_0063:
	{
		RuntimeObject* L_21 = V_1;
		int32_t L_22 = V_3;
		NullCheck(L_21);
		RuntimeObject* L_23;
		L_23 = InterfaceFuncInvoker1< RuntimeObject*, int32_t >::Invoke(0 /* Rewired.Player/ControllerHelper/ccKIYWnZwPjlGgvjpHVACPHqZTWG Rewired.Player/ControllerHelper/ftuHLSCvHbrPYKqmDICMGujVuqLSA::ZfIXNjSNQNQjmCdAUEIsaOrcLoPs(System.Int32) */, ftuHLSCvHbrPYKqmDICMGujVuqLSA_tD67CC6A3A416E57262B63617FA5896CF7BF4F187_il2cpp_TypeInfo_var, L_21, L_22);
		NullCheck(L_23);
		Controller_t919A4A50FC7A0F25D7B31615C0F4E4D4A4D17911* L_24;
		L_24 = InterfaceFuncInvoker0< Controller_t919A4A50FC7A0F25D7B31615C0F4E4D4A4D17911* >::Invoke(1 /* Rewired.Controller Rewired.Player/ControllerHelper/ccKIYWnZwPjlGgvjpHVACPHqZTWG::ozNcfmyISWkqVPVfvPOfROcWRfsf() */, ccKIYWnZwPjlGgvjpHVACPHqZTWG_t7AB72F4748B9EC6B1975F90F35E5838740AD2011_il2cpp_TypeInfo_var, L_23);
		V_7 = L_24;
		List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D* L_25 = V_2;
		Controller_t919A4A50FC7A0F25D7B31615C0F4E4D4A4D17911* L_26 = V_7;
		ControllerMap_tC01A582E577E38D21EB7D87A8C040AF5DA285FB3* L_27 = V_6;
		RuntimeObject* L_28;
		L_28 = ((  RuntimeObject* (*) (Controller_t919A4A50FC7A0F25D7B31615C0F4E4D4A4D17911*, ControllerMap_tC01A582E577E38D21EB7D87A8C040AF5DA285FB3*, const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->rgctx_data, 3)))(L_26, L_27, il2cpp_rgctx_method(method->rgctx_data, 3));
		NullCheck(L_25);
		((  void (*) (List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D*, RuntimeObject*, const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->rgctx_data, 4)))(L_25, L_28, il2cpp_rgctx_method(method->rgctx_data, 4));
	}

IL_0080:
	{
		int32_t L_29 = V_5;
		V_5 = ((int32_t)il2cpp_codegen_add(L_29, 1));
	}

IL_0086:
	{
		int32_t L_30 = V_5;
		RuntimeObject* L_31 = V_4;
		NullCheck(L_31);
		int32_t L_32;
		L_32 = InterfaceFuncInvoker0< int32_t >::Invoke(1 /* System.Int32 hDTwQOONkmiSaaPHwqpfFkmXMCAbb::NEFjFYSXjpJmKUMrQuBCmBemjvSFA() */, hDTwQOONkmiSaaPHwqpfFkmXMCAbb_tE1CD926FAF554AEBC6AFFC839A4294D64BE76AC3_il2cpp_TypeInfo_var, L_31);
		if ((((int32_t)L_30) < ((int32_t)L_32)))
		{
			goto IL_0035;
		}
	}
	{
		int32_t L_33 = V_3;
		V_3 = ((int32_t)il2cpp_codegen_add(L_33, 1));
	}

IL_0095:
	{
		int32_t L_34 = V_3;
		RuntimeObject* L_35 = V_1;
		NullCheck(L_35);
		int32_t L_36;
		L_36 = InterfaceFuncInvoker0< int32_t >::Invoke(2 /* System.Int32 Rewired.Player/ControllerHelper/ftuHLSCvHbrPYKqmDICMGujVuqLSA::NEFjFYSXjpJmKUMrQuBCmBemjvSFA() */, ftuHLSCvHbrPYKqmDICMGujVuqLSA_tD67CC6A3A416E57262B63617FA5896CF7BF4F187_il2cpp_TypeInfo_var, L_35);
		if ((((int32_t)L_34) < ((int32_t)L_36)))
		{
			goto IL_0022;
		}
	}
	{
		List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D* L_37 = V_2;
		NullCheck(L_37);
		ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* L_38;
		L_38 = ((  ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* (*) (List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D*, const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->rgctx_data, 5)))(L_37, il2cpp_rgctx_method(method->rgctx_data, 5));
		return L_38;
	}
}
// System.Void Rewired.Player/ControllerHelper/MapHelper::LoadMap<System.Object>(System.Int32,System.Int32,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MapHelper_LoadMap_TisRuntimeObject_m97D0900090F03EF7FDEFA2ED3AFD30820AF2CD32_gshared (MapHelper_t214BA4F045E5EB4B312E4E6AEB6697813117A7C2* __this, int32_t ___controllerId0, int32_t ___categoryId1, int32_t ___layoutId2, const RuntimeMethod* method) 
{
{
		int32_t L_0 = ___controllerId0;
		int32_t L_1 = ___categoryId1;
		int32_t L_2 = ___layoutId2;
		((  void (*) (MapHelper_t214BA4F045E5EB4B312E4E6AEB6697813117A7C2*, int32_t, int32_t, int32_t, int32_t, const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->rgctx_data, 0)))(__this, L_0, L_1, L_2, (int32_t)0, il2cpp_rgctx_method(method->rgctx_data, 0));
		return;
	}
}
// System.Void Rewired.Player/ControllerHelper/MapHelper::LoadMap<System.Object>(System.Int32,System.String,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MapHelper_LoadMap_TisRuntimeObject_mE8413943008177B96F95F40FFC25CB6E54E53B01_gshared (MapHelper_t214BA4F045E5EB4B312E4E6AEB6697813117A7C2* __this, int32_t ___controllerId0, String_t* ___categoryName1, String_t* ___layoutName2, const RuntimeMethod* method) 
{
{
		int32_t L_0 = ___controllerId0;
		String_t* L_1 = ___categoryName1;
		String_t* L_2 = ___layoutName2;
		((  void (*) (MapHelper_t214BA4F045E5EB4B312E4E6AEB6697813117A7C2*, int32_t, String_t*, String_t*, int32_t, const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->rgctx_data, 0)))(__this, L_0, L_1, L_2, (int32_t)0, il2cpp_rgctx_method(method->rgctx_data, 0));
		return;
	}
}
// System.Void Rewired.Player/ControllerHelper/MapHelper::LoadMap<System.Object>(System.Int32,System.Int32,System.Int32,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MapHelper_LoadMap_TisRuntimeObject_m4910A86EC6FF25BD2446BA8FB3826BBC57898C99_gshared (MapHelper_t214BA4F045E5EB4B312E4E6AEB6697813117A7C2* __this, int32_t ___controllerId0, int32_t ___categoryId1, int32_t ___layoutId2, bool ___startEnabled3, const RuntimeMethod* method) 
{
int32_t G_B2_0 = 0;
	int32_t G_B2_1 = 0;
	int32_t G_B2_2 = 0;
	MapHelper_t214BA4F045E5EB4B312E4E6AEB6697813117A7C2* G_B2_3 = NULL;
	int32_t G_B1_0 = 0;
	int32_t G_B1_1 = 0;
	int32_t G_B1_2 = 0;
	MapHelper_t214BA4F045E5EB4B312E4E6AEB6697813117A7C2* G_B1_3 = NULL;
	int32_t G_B3_0 = 0;
	int32_t G_B3_1 = 0;
	int32_t G_B3_2 = 0;
	int32_t G_B3_3 = 0;
	MapHelper_t214BA4F045E5EB4B312E4E6AEB6697813117A7C2* G_B3_4 = NULL;
	{
		int32_t L_0 = ___controllerId0;
		int32_t L_1 = ___categoryId1;
		int32_t L_2 = ___layoutId2;
		bool L_3 = ___startEnabled3;
		G_B1_0 = L_2;
		G_B1_1 = L_1;
		G_B1_2 = L_0;
		G_B1_3 = __this;
		if (L_3)
		{
			G_B2_0 = L_2;
			G_B2_1 = L_1;
			G_B2_2 = L_0;
			G_B2_3 = __this;
			goto IL_000b;
		}
	}
	{
		G_B3_0 = 2;
		G_B3_1 = G_B1_0;
		G_B3_2 = G_B1_1;
		G_B3_3 = G_B1_2;
		G_B3_4 = G_B1_3;
		goto IL_000c;
	}

IL_000b:
	{
		G_B3_0 = 1;
		G_B3_1 = G_B2_0;
		G_B3_2 = G_B2_1;
		G_B3_3 = G_B2_2;
		G_B3_4 = G_B2_3;
	}

IL_000c:
	{
		NullCheck(G_B3_4);
		((  void (*) (MapHelper_t214BA4F045E5EB4B312E4E6AEB6697813117A7C2*, int32_t, int32_t, int32_t, int32_t, const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->rgctx_data, 0)))(G_B3_4, G_B3_3, G_B3_2, G_B3_1, (int32_t)G_B3_0, il2cpp_rgctx_method(method->rgctx_data, 0));
		return;
	}
}
// System.Void Rewired.Player/ControllerHelper/MapHelper::LoadMap<System.Object>(System.Int32,System.String,System.String,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MapHelper_LoadMap_TisRuntimeObject_m77E7A51DB69AA135826F8BCE89D8E8D9132F7A2B_gshared (MapHelper_t214BA4F045E5EB4B312E4E6AEB6697813117A7C2* __this, int32_t ___controllerId0, String_t* ___categoryName1, String_t* ___layoutName2, bool ___startEnabled3, const RuntimeMethod* method) 
{
String_t* G_B2_0 = NULL;
	String_t* G_B2_1 = NULL;
	int32_t G_B2_2 = 0;
	MapHelper_t214BA4F045E5EB4B312E4E6AEB6697813117A7C2* G_B2_3 = NULL;
	String_t* G_B1_0 = NULL;
	String_t* G_B1_1 = NULL;
	int32_t G_B1_2 = 0;
	MapHelper_t214BA4F045E5EB4B312E4E6AEB6697813117A7C2* G_B1_3 = NULL;
	int32_t G_B3_0 = 0;
	String_t* G_B3_1 = NULL;
	String_t* G_B3_2 = NULL;
	int32_t G_B3_3 = 0;
	MapHelper_t214BA4F045E5EB4B312E4E6AEB6697813117A7C2* G_B3_4 = NULL;
	{
		int32_t L_0 = ___controllerId0;
		String_t* L_1 = ___categoryName1;
		String_t* L_2 = ___layoutName2;
		bool L_3 = ___startEnabled3;
		G_B1_0 = L_2;
		G_B1_1 = L_1;
		G_B1_2 = L_0;
		G_B1_3 = __this;
		if (L_3)
		{
			G_B2_0 = L_2;
			G_B2_1 = L_1;
			G_B2_2 = L_0;
			G_B2_3 = __this;
			goto IL_000b;
		}
	}
	{
		G_B3_0 = 2;
		G_B3_1 = G_B1_0;
		G_B3_2 = G_B1_1;
		G_B3_3 = G_B1_2;
		G_B3_4 = G_B1_3;
		goto IL_000c;
	}

IL_000b:
	{
		G_B3_0 = 1;
		G_B3_1 = G_B2_0;
		G_B3_2 = G_B2_1;
		G_B3_3 = G_B2_2;
		G_B3_4 = G_B2_3;
	}

IL_000c:
	{
		NullCheck(G_B3_4);
		((  void (*) (MapHelper_t214BA4F045E5EB4B312E4E6AEB6697813117A7C2*, int32_t, String_t*, String_t*, int32_t, const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->rgctx_data, 0)))(G_B3_4, G_B3_3, G_B3_2, G_B3_1, (int32_t)G_B3_0, il2cpp_rgctx_method(method->rgctx_data, 0));
		return;
	}
}
// System.Void Rewired.Player/ControllerHelper/MapHelper::RemoveMap<System.Object>(System.Int32,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MapHelper_RemoveMap_TisRuntimeObject_m91AB904D57FF2BE50DD75E48954461F8C77AC1E7_gshared (MapHelper_t214BA4F045E5EB4B312E4E6AEB6697813117A7C2* __this, int32_t ___controllerId0, int32_t ___mapId1, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
{
		il2cpp_codegen_runtime_class_init_inline(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		int32_t L_0 = ((ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_StaticFields*)il2cpp_codegen_static_fields_for(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var))->____id_29;
		int32_t L_1 = (int32_t)__this->___eNyGUiEiMyquCTKLRhFvpeyOvzMm_5;
		if ((((int32_t)L_0) == ((int32_t)L_1)))
		{
			goto IL_001a;
		}
	}
	{
		int32_t L_2 = (int32_t)__this->___eNyGUiEiMyquCTKLRhFvpeyOvzMm_5;
		il2cpp_codegen_runtime_class_init_inline(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		bool L_3;
		L_3 = ReInput_CheckInitialized_mAAC593CB03C886BDB7B72864FBB1A59B2B0530AF(L_2, NULL);
		return;
	}

IL_001a:
	{
		int32_t L_4 = ___mapId1;
		if ((((int32_t)L_4) >= ((int32_t)0)))
		{
			goto IL_001f;
		}
	}
	{
		return;
	}

IL_001f:
	{
		int32_t L_5;
		L_5 = ((  int32_t (*) (const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->rgctx_data, 0)))(il2cpp_rgctx_method(method->rgctx_data, 0));
		int32_t L_6 = ___controllerId0;
		int32_t L_7 = ___mapId1;
		MapHelper_lphhQOcxOMSOPhjlSDCZLLXGLsWm_mCA8C06E4464C92F56AC93F431310898E3D3CFDD4(__this, L_5, L_6, L_7, NULL);
		return;
	}
}
// System.Void Rewired.Player/ControllerHelper/MapHelper::RemoveMap<System.Object>(System.Int32,System.Int32,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MapHelper_RemoveMap_TisRuntimeObject_m483E5B2F35E539EEAD64D8C88A989E7DD8B0334A_gshared (MapHelper_t214BA4F045E5EB4B312E4E6AEB6697813117A7C2* __this, int32_t ___controllerId0, int32_t ___categoryId1, int32_t ___layoutId2, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
{
		il2cpp_codegen_runtime_class_init_inline(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		int32_t L_0 = ((ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_StaticFields*)il2cpp_codegen_static_fields_for(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var))->____id_29;
		int32_t L_1 = (int32_t)__this->___eNyGUiEiMyquCTKLRhFvpeyOvzMm_5;
		if ((((int32_t)L_0) == ((int32_t)L_1)))
		{
			goto IL_001a;
		}
	}
	{
		int32_t L_2 = (int32_t)__this->___eNyGUiEiMyquCTKLRhFvpeyOvzMm_5;
		il2cpp_codegen_runtime_class_init_inline(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		bool L_3;
		L_3 = ReInput_CheckInitialized_mAAC593CB03C886BDB7B72864FBB1A59B2B0530AF(L_2, NULL);
		return;
	}

IL_001a:
	{
		int32_t L_4 = ___categoryId1;
		if ((((int32_t)L_4) < ((int32_t)0)))
		{
			goto IL_0022;
		}
	}
	{
		int32_t L_5 = ___layoutId2;
		if ((((int32_t)L_5) >= ((int32_t)0)))
		{
			goto IL_0023;
		}
	}

IL_0022:
	{
		return;
	}

IL_0023:
	{
		int32_t L_6;
		L_6 = ((  int32_t (*) (const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->rgctx_data, 0)))(il2cpp_rgctx_method(method->rgctx_data, 0));
		int32_t L_7 = ___controllerId0;
		int32_t L_8 = ___categoryId1;
		int32_t L_9 = ___layoutId2;
		MapHelper_lphhQOcxOMSOPhjlSDCZLLXGLsWm_m3194478C4255DC656B551522E1AB9F7FB067346C(__this, L_6, L_7, L_8, L_9, NULL);
		return;
	}
}
// System.Void Rewired.Player/ControllerHelper/MapHelper::RemoveMap<System.Object>(System.Int32,System.String,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MapHelper_RemoveMap_TisRuntimeObject_m610AF20FA991BE0B025B883EAB51245FAA090F5F_gshared (MapHelper_t214BA4F045E5EB4B312E4E6AEB6697813117A7C2* __this, int32_t ___controllerId0, String_t* ___categoryName1, String_t* ___layoutName2, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
{
		il2cpp_codegen_runtime_class_init_inline(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		int32_t L_0 = ((ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_StaticFields*)il2cpp_codegen_static_fields_for(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var))->____id_29;
		int32_t L_1 = (int32_t)__this->___eNyGUiEiMyquCTKLRhFvpeyOvzMm_5;
		if ((((int32_t)L_0) == ((int32_t)L_1)))
		{
			goto IL_001a;
		}
	}
	{
		int32_t L_2 = (int32_t)__this->___eNyGUiEiMyquCTKLRhFvpeyOvzMm_5;
		il2cpp_codegen_runtime_class_init_inline(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		bool L_3;
		L_3 = ReInput_CheckInitialized_mAAC593CB03C886BDB7B72864FBB1A59B2B0530AF(L_2, NULL);
		return;
	}

IL_001a:
	{
		int32_t L_4;
		L_4 = ((  int32_t (*) (const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->rgctx_data, 0)))(il2cpp_rgctx_method(method->rgctx_data, 0));
		int32_t L_5 = ___controllerId0;
		String_t* L_6 = ___categoryName1;
		String_t* L_7 = ___layoutName2;
		MapHelper_lphhQOcxOMSOPhjlSDCZLLXGLsWm_m3B7D645A45FA19D76F0FFA6B0DC5704477A80FFC(__this, L_4, L_5, L_6, L_7, NULL);
		return;
	}
}
// System.Void Rewired.Player/ControllerHelper/MapHelper::iYjfAKkNRBiCebDRjLujsuzhhUUyb<System.Object>(System.Int32,System.Int32,System.Int32,Rewired.BoolOption)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MapHelper_iYjfAKkNRBiCebDRjLujsuzhhUUyb_TisRuntimeObject_mBCFE68B6CDBA018C24F47C0A5CC7CDCF3B4250C4_gshared (MapHelper_t214BA4F045E5EB4B312E4E6AEB6697813117A7C2* __this, int32_t p0, int32_t p1, int32_t p2, int32_t p3, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
{
		il2cpp_codegen_runtime_class_init_inline(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		int32_t L_0 = ((ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_StaticFields*)il2cpp_codegen_static_fields_for(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var))->____id_29;
		int32_t L_1 = (int32_t)__this->___eNyGUiEiMyquCTKLRhFvpeyOvzMm_5;
		if ((((int32_t)L_0) == ((int32_t)L_1)))
		{
			goto IL_001a;
		}
	}
	{
		int32_t L_2 = (int32_t)__this->___eNyGUiEiMyquCTKLRhFvpeyOvzMm_5;
		il2cpp_codegen_runtime_class_init_inline(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		bool L_3;
		L_3 = ReInput_CheckInitialized_mAAC593CB03C886BDB7B72864FBB1A59B2B0530AF(L_2, NULL);
		return;
	}

IL_001a:
	{
		int32_t L_4;
		L_4 = ((  int32_t (*) (const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->rgctx_data, 0)))(il2cpp_rgctx_method(method->rgctx_data, 0));
		int32_t L_5 = p0;
		int32_t L_6 = p1;
		int32_t L_7 = p2;
		int32_t L_8 = p3;
		MapHelper_xUxtwYDqEBAoBQJfMbKEZonwyhmq_m27EEE026ABE014B51797CA00F9EECB40B0365F33(__this, L_4, L_5, L_6, L_7, L_8, NULL);
		return;
	}
}
// System.Void Rewired.Player/ControllerHelper/MapHelper::iYjfAKkNRBiCebDRjLujsuzhhUUyb<System.Object>(System.Int32,System.String,System.String,Rewired.BoolOption)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MapHelper_iYjfAKkNRBiCebDRjLujsuzhhUUyb_TisRuntimeObject_m6D0D77CAC2D56AE02698724DBBED6E3D2D7D7A94_gshared (MapHelper_t214BA4F045E5EB4B312E4E6AEB6697813117A7C2* __this, int32_t p0, String_t* p1, String_t* p2, int32_t p3, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
{
		il2cpp_codegen_runtime_class_init_inline(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		int32_t L_0 = ((ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_StaticFields*)il2cpp_codegen_static_fields_for(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var))->____id_29;
		int32_t L_1 = (int32_t)__this->___eNyGUiEiMyquCTKLRhFvpeyOvzMm_5;
		if ((((int32_t)L_0) == ((int32_t)L_1)))
		{
			goto IL_001a;
		}
	}
	{
		int32_t L_2 = (int32_t)__this->___eNyGUiEiMyquCTKLRhFvpeyOvzMm_5;
		il2cpp_codegen_runtime_class_init_inline(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		bool L_3;
		L_3 = ReInput_CheckInitialized_mAAC593CB03C886BDB7B72864FBB1A59B2B0530AF(L_2, NULL);
		return;
	}

IL_001a:
	{
		int32_t L_4;
		L_4 = ((  int32_t (*) (const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->rgctx_data, 0)))(il2cpp_rgctx_method(method->rgctx_data, 0));
		int32_t L_5 = p0;
		String_t* L_6 = p1;
		String_t* L_7 = p2;
		int32_t L_8 = p3;
		MapHelper_xUxtwYDqEBAoBQJfMbKEZonwyhmq_mB64759EE9B99E28074BDA8EA24384C48A867BC1C(__this, L_4, L_5, L_6, L_7, L_8, NULL);
		return;
	}
}
// System.Collections.Generic.IList`1<?> Rewired.Player/ControllerHelper/MapHelper::tvzSUyFQMZzmsFFoXUNxDESRBotM<System.Object>(Rewired.Controller)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* MapHelper_tvzSUyFQMZzmsFFoXUNxDESRBotM_TisRuntimeObject_m3A1DD0225875EA12899FB3DBB161AB2C794DDCE9_gshared (MapHelper_t214BA4F045E5EB4B312E4E6AEB6697813117A7C2* __this, Controller_t919A4A50FC7A0F25D7B31615C0F4E4D4A4D17911* p0, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ccKIYWnZwPjlGgvjpHVACPHqZTWG_t7AB72F4748B9EC6B1975F90F35E5838740AD2011_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ftuHLSCvHbrPYKqmDICMGujVuqLSA_tD67CC6A3A416E57262B63617FA5896CF7BF4F187_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
RuntimeObject* V_0 = NULL;
	{
		RuntimeObject* L_0;
		L_0 = ((  RuntimeObject* (*) (MapHelper_t214BA4F045E5EB4B312E4E6AEB6697813117A7C2*, const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->rgctx_data, 0)))(__this, il2cpp_rgctx_method(method->rgctx_data, 0));
		Controller_t919A4A50FC7A0F25D7B31615C0F4E4D4A4D17911* L_1 = p0;
		NullCheck(L_0);
		RuntimeObject* L_2;
		L_2 = InterfaceFuncInvoker1< RuntimeObject*, Controller_t919A4A50FC7A0F25D7B31615C0F4E4D4A4D17911* >::Invoke(15 /* Rewired.Player/ControllerHelper/ccKIYWnZwPjlGgvjpHVACPHqZTWG Rewired.Player/ControllerHelper/ftuHLSCvHbrPYKqmDICMGujVuqLSA::howjPBfRJshDbKOTcPHxFqZjkrDUB(Rewired.Controller) */, ftuHLSCvHbrPYKqmDICMGujVuqLSA_tD67CC6A3A416E57262B63617FA5896CF7BF4F187_il2cpp_TypeInfo_var, L_0, L_1);
		V_0 = L_2;
		RuntimeObject* L_3 = V_0;
		if (L_3)
		{
			goto IL_0012;
		}
	}
	{
		return (RuntimeObject*)NULL;
	}

IL_0012:
	{
		RuntimeObject* L_4 = V_0;
		NullCheck(L_4);
		RuntimeObject* L_5;
		L_5 = InterfaceFuncInvoker0< RuntimeObject* >::Invoke(0 /* hDTwQOONkmiSaaPHwqpfFkmXMCAbb Rewired.Player/ControllerHelper/ccKIYWnZwPjlGgvjpHVACPHqZTWG::DJykFGUxbFlHMIneTwfokcsefclu() */, ccKIYWnZwPjlGgvjpHVACPHqZTWG_t7AB72F4748B9EC6B1975F90F35E5838740AD2011_il2cpp_TypeInfo_var, L_4);
		NullCheck(L_5);
		RuntimeObject* L_6;
		L_6 = GenericInterfaceFuncInvoker0< RuntimeObject* >::Invoke(il2cpp_rgctx_method(method->rgctx_data, 1), L_5);
		return L_6;
	}
}
// System.Collections.Generic.IList`1<?> Rewired.Player/ControllerHelper/MapHelper::tvzSUyFQMZzmsFFoXUNxDESRBotM<System.Object>(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* MapHelper_tvzSUyFQMZzmsFFoXUNxDESRBotM_TisRuntimeObject_mCBC8A03F5DB58F2D30FBC1404374DF61D541FD4B_gshared (MapHelper_t214BA4F045E5EB4B312E4E6AEB6697813117A7C2* __this, int32_t p0, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ccKIYWnZwPjlGgvjpHVACPHqZTWG_t7AB72F4748B9EC6B1975F90F35E5838740AD2011_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ftuHLSCvHbrPYKqmDICMGujVuqLSA_tD67CC6A3A416E57262B63617FA5896CF7BF4F187_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
RuntimeObject* V_0 = NULL;
	int32_t V_1 = 0;
	{
		RuntimeObject* L_0;
		L_0 = ((  RuntimeObject* (*) (MapHelper_t214BA4F045E5EB4B312E4E6AEB6697813117A7C2*, const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->rgctx_data, 0)))(__this, il2cpp_rgctx_method(method->rgctx_data, 0));
		V_0 = L_0;
		RuntimeObject* L_1 = V_0;
		int32_t L_2 = p0;
		NullCheck(L_1);
		int32_t L_3;
		L_3 = InterfaceFuncInvoker1< int32_t, int32_t >::Invoke(11 /* System.Int32 Rewired.Player/ControllerHelper/ftuHLSCvHbrPYKqmDICMGujVuqLSA::LFBHpqbppIulyYiNTvRYfiNwKOGN(System.Int32) */, ftuHLSCvHbrPYKqmDICMGujVuqLSA_tD67CC6A3A416E57262B63617FA5896CF7BF4F187_il2cpp_TypeInfo_var, L_1, L_2);
		V_1 = L_3;
		int32_t L_4 = V_1;
		if ((((int32_t)L_4) >= ((int32_t)0)))
		{
			goto IL_0019;
		}
	}
	{
		RuntimeObject* L_5;
		L_5 = ((  RuntimeObject* (*) (const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->rgctx_data, 1)))(il2cpp_rgctx_method(method->rgctx_data, 1));
		return L_5;
	}

IL_0019:
	{
		RuntimeObject* L_6 = V_0;
		int32_t L_7 = V_1;
		NullCheck(L_6);
		RuntimeObject* L_8;
		L_8 = InterfaceFuncInvoker1< RuntimeObject*, int32_t >::Invoke(0 /* Rewired.Player/ControllerHelper/ccKIYWnZwPjlGgvjpHVACPHqZTWG Rewired.Player/ControllerHelper/ftuHLSCvHbrPYKqmDICMGujVuqLSA::ZfIXNjSNQNQjmCdAUEIsaOrcLoPs(System.Int32) */, ftuHLSCvHbrPYKqmDICMGujVuqLSA_tD67CC6A3A416E57262B63617FA5896CF7BF4F187_il2cpp_TypeInfo_var, L_6, L_7);
		NullCheck(L_8);
		RuntimeObject* L_9;
		L_9 = InterfaceFuncInvoker0< RuntimeObject* >::Invoke(0 /* hDTwQOONkmiSaaPHwqpfFkmXMCAbb Rewired.Player/ControllerHelper/ccKIYWnZwPjlGgvjpHVACPHqZTWG::DJykFGUxbFlHMIneTwfokcsefclu() */, ccKIYWnZwPjlGgvjpHVACPHqZTWG_t7AB72F4748B9EC6B1975F90F35E5838740AD2011_il2cpp_TypeInfo_var, L_8);
		NullCheck(L_9);
		RuntimeObject* L_10;
		L_10 = GenericInterfaceFuncInvoker0< RuntimeObject* >::Invoke(il2cpp_rgctx_method(method->rgctx_data, 3), L_9);
		return L_10;
	}
}
// Rewired.Player/ControllerHelper/ftuHLSCvHbrPYKqmDICMGujVuqLSA Rewired.Player/ControllerHelper/MapHelper::uUgxrqQkdpQhPYYUpxCfhZRqzfWH<System.Object>()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* MapHelper_uUgxrqQkdpQhPYYUpxCfhZRqzfWH_TisRuntimeObject_m5389B149C77B13756EACC4F22E5C6DE17152A598_gshared (MapHelper_t214BA4F045E5EB4B312E4E6AEB6697813117A7C2* __this, const RuntimeMethod* method) 
{
{
		ControllerHelper_tCE72EA23053BD0C6ECB4D75A69F8CD1B3AC28FF6* L_0 = (ControllerHelper_tCE72EA23053BD0C6ECB4D75A69F8CD1B3AC28FF6*)__this->___JOhXpftGzsqKykxdovItahCXjNZ_2;
		NullCheck(L_0);
		vpfVMfLDNQCKabtrXuyMMndafvvoA_t24DAE63535EED93A1490AC97901F2551704D116D* L_1 = (vpfVMfLDNQCKabtrXuyMMndafvvoA_t24DAE63535EED93A1490AC97901F2551704D116D*)L_0->___rGIwSbUPDgDDJByCitUBBGoZDlmc_0;
		int32_t L_2;
		L_2 = ((  int32_t (*) (const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->rgctx_data, 0)))(il2cpp_rgctx_method(method->rgctx_data, 0));
		NullCheck(L_1);
		RuntimeObject* L_3;
		L_3 = vpfVMfLDNQCKabtrXuyMMndafvvoA_OlLACmpwoMamrxMTFzLaRnppBEGFA_m7D256F4AAE84410B2D3EC0217ADB4B49A6AE0B9F(L_1, L_2, NULL);
		return L_3;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void Builder_set_type_m9052A0AB147182E89AAA4F020F6A0BE797AB49CC_inline (Builder_t83F17A26F53DA7EA6D8C35E5C65C5DF0147E7821* __this, Type_t* ___value0, const RuntimeMethod* method) 
{
{
		// public Type type { get; set; }
		Type_t* L_0 = ___value0;
		__this->___U3CtypeU3Ek__BackingField_2 = L_0;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___U3CtypeU3Ek__BackingField_2), (void*)L_0);
		return;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR ConfigVars_t4EC82ACF63376F1869FDC3D0E223EDCE149CF4A3* ReInput_get_configVars_m62E24BBE60949886F36F909C895B98208BCCC8ED_inline (const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
{
		il2cpp_codegen_runtime_class_init_inline(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var);
		ConfigVars_t4EC82ACF63376F1869FDC3D0E223EDCE149CF4A3* L_0 = ((ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_StaticFields*)il2cpp_codegen_static_fields_for(ReInput_t4304E64B566AAB8EF94F002DEA29F31680226BB0_il2cpp_TypeInfo_var))->___yKydsvixPcQdBIlgvxotXrJTbkcL_15;
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR RuntimeObject* CalibrationMap_get_Axes_m54E04E0A9797B0B8C965699A2B749DAF7B7158D7_inline (CalibrationMap_tB57C4727A9D4F4ED745A6E5D7E4398452D7A499B* __this, const RuntimeMethod* method) 
{
{
		RuntimeObject* L_0 = __this->___sEIuIxFuhzTlUrJrUHnKqipeDsaw_1;
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR bool AxisCalibration_get_applyRangeCalibration_m438A9FE9F6BAE9D2E046F3B44DBBAD83F0BBAD05_inline (AxisCalibration_t8B238ADDBAA0316E9708699644DA1CFF6EDBE66C* __this, const RuntimeMethod* method) 
{
{
		bool L_0 = __this->____applyRangeCalibration_11;
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR int32_t ActionElementMap_get_elementIndex_m3FA57481AF8EAE6B39F59CCDD2051406ECA35726_inline (ActionElementMap_t0EBE3E5D3A5DF3BA6D35F8082ED2232404EFF8CF* __this, const RuntimeMethod* method) 
{
{
		int32_t L_0 = __this->___zmFhEQUDPjAWQEDVHHgiGnzAJkVq_15;
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR AList_1_t26BA8BE4BEB503507B02BE892DA37BBBAA585997* ControllerMap_wXccLrJfOtzUxejkEKAtaWhpDtMyA_m59AF76DBA5CF3521EF33E62ABEC7652CA79D4109_inline (ControllerMap_tC01A582E577E38D21EB7D87A8C040AF5DA285FB3* __this, const RuntimeMethod* method) 
{
{
		AList_1_t26BA8BE4BEB503507B02BE892DA37BBBAA585997* L_0 = __this->___tvTaSlZaJJsaHhTxcEdxOMRqgyDi_8;
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Keyboard_t3FD52938480ACCD23FDB0DAEC857F9A9D29CC6C3* TAqjagBhKGcWECRbpfkHPNKbpxLsA_YdrUiKuiWrCsfuIZfuOolsqFcFEd_m2F1D148A44E13C083F209FF609EDF416976764B4_inline (TAqjagBhKGcWECRbpfkHPNKbpxLsA_t5B25C84F87417D98CA0E8452EAD0DB3A23D7833A* __this, const RuntimeMethod* method) 
{
{
		Keyboard_t3FD52938480ACCD23FDB0DAEC857F9A9D29CC6C3* L_0 = __this->___oCxdsWEkBdyfOWvttlOGoBEqVJhVA_5;
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Mouse_t5C8D9CB89A5C0F4EE87A70501CAF2A68E36DC019* TAqjagBhKGcWECRbpfkHPNKbpxLsA_mQpaOTHDcjELSAhFNvChgQfDcoqub_mF11D81D13BFD78BC6E168C0996206A1CA946FC09_inline (TAqjagBhKGcWECRbpfkHPNKbpxLsA_t5B25C84F87417D98CA0E8452EAD0DB3A23D7833A* __this, const RuntimeMethod* method) 
{
{
		Mouse_t5C8D9CB89A5C0F4EE87A70501CAF2A68E36DC019* L_0 = __this->___XozsQUktyqHZxmlRpydAHghEBLTv_6;
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR int32_t ElementAssignmentConflictCheck_get_playerId_m13D1C2C48B4AF7E87153014EE4B16491202256C5_inline (ElementAssignmentConflictCheck_tC22925257E88D3999FDD06C7ABF3B6CE6C09847E* __this, const RuntimeMethod* method) 
{
{
		int32_t L_0 = __this->___poRIGCSEughNfRYXWSqdxofgERiiA_1;
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR int32_t ElementAssignmentConflictCheck_get_controllerType_mB10ABC66916B5C14CA467D3289A606AEE947FE72_inline (ElementAssignmentConflictCheck_tC22925257E88D3999FDD06C7ABF3B6CE6C09847E* __this, const RuntimeMethod* method) 
{
{
		int32_t L_0 = __this->___uXdofgxOYrPYUxRwFbcOtLnrtwQM_2;
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR int32_t ElementAssignmentConflictCheck_get_controllerId_m5C57BA2FE3D405B624E86F7DD88454ED9711954A_inline (ElementAssignmentConflictCheck_tC22925257E88D3999FDD06C7ABF3B6CE6C09847E* __this, const RuntimeMethod* method) 
{
{
		int32_t L_0 = __this->___wovqMdREgMHEHAKFWnDLDuYilFZN_3;
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR int32_t ElementAssignmentConflictCheck_get_controllerMapId_m4C899DB8B80BBF22D0B0CAA98E0F5330AECF1800_inline (ElementAssignmentConflictCheck_tC22925257E88D3999FDD06C7ABF3B6CE6C09847E* __this, const RuntimeMethod* method) 
{
{
		int32_t L_0 = __this->___IuSWTyCEwxTphLVNpdlvWrKjDFGj_4;
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR int32_t ElementAssignmentConflictCheck_get_controllerMapCategoryId_m0A29A78618798D54C96B3EE602E3576B899DBB99_inline (ElementAssignmentConflictCheck_tC22925257E88D3999FDD06C7ABF3B6CE6C09847E* __this, const RuntimeMethod* method) 
{
{
		int32_t L_0 = __this->___BVLEAOpnlCWLTSJLJiBFhzJTNjut_5;
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR bool InputCategory_get_userAssignable_mBD58AC35EE83AAE55914DC85584314585326C703_inline (InputCategory_t9C22614C15FBDA3F98B6F03EA3CEB547BF5F373C* __this, const RuntimeMethod* method) 
{
{
		bool L_0 = __this->____userAssignable_4;
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR int32_t List_1_get_Count_m4407E4C389F22B8CEC282C15D56516658746C383_gshared_inline (List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D* __this, const RuntimeMethod* method) 
{
{
		int32_t L_0 = (int32_t)__this->____size_2;
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR int32_t DynamicArray_1_get_size_m1B00C20A8CC4D62269585D16A58425D3F258836F_gshared_inline (DynamicArray_1_t7C64F5A74B7BA6F6B3589A766CADE3F59C6C7BCA* __this, const RuntimeMethod* method) 
{
{
		// public int size { get; private set; }
		int32_t L_0 = (int32_t)__this->___U3CsizeU3Ek__BackingField_1;
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void List_1_Add_mEBCF994CC3814631017F46A387B1A192ED6C85C7_gshared_inline (List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D* __this, RuntimeObject* ___item0, const RuntimeMethod* method) 
{
ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* V_0 = NULL;
	int32_t V_1 = 0;
	{
		int32_t L_0 = (int32_t)__this->____version_3;
		__this->____version_3 = ((int32_t)il2cpp_codegen_add(L_0, 1));
		ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* L_1 = (ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918*)__this->____items_1;
		V_0 = L_1;
		int32_t L_2 = (int32_t)__this->____size_2;
		V_1 = L_2;
		int32_t L_3 = V_1;
		ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* L_4 = V_0;
		NullCheck(L_4);
		if ((!(((uint32_t)L_3) < ((uint32_t)((int32_t)(((RuntimeArray*)L_4)->max_length))))))
		{
			goto IL_0034;
		}
	}
	{
		int32_t L_5 = V_1;
		__this->____size_2 = ((int32_t)il2cpp_codegen_add(L_5, 1));
		ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* L_6 = V_0;
		int32_t L_7 = V_1;
		RuntimeObject* L_8 = ___item0;
		NullCheck(L_6);
		(L_6)->SetAt(static_cast<il2cpp_array_size_t>(L_7), (RuntimeObject*)L_8);
		return;
	}

IL_0034:
	{
		RuntimeObject* L_9 = ___item0;
		((  void (*) (List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D*, RuntimeObject*, const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 11)))(__this, L_9, il2cpp_rgctx_method(method->klass->rgctx_data, 11));
		return;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void List_1_Clear_m16C1F2C61FED5955F10EB36BC1CB2DF34B128994_gshared_inline (List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D* __this, const RuntimeMethod* method) 
{
int32_t V_0 = 0;
	{
		int32_t L_0 = (int32_t)__this->____version_3;
		__this->____version_3 = ((int32_t)il2cpp_codegen_add(L_0, 1));
		if (!true)
		{
			goto IL_0035;
		}
	}
	{
		int32_t L_1 = (int32_t)__this->____size_2;
		V_0 = L_1;
		__this->____size_2 = 0;
		int32_t L_2 = V_0;
		if ((((int32_t)L_2) <= ((int32_t)0)))
		{
			goto IL_003c;
		}
	}
	{
		ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* L_3 = (ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918*)__this->____items_1;
		int32_t L_4 = V_0;
		Array_Clear_m48B57EC27CADC3463CA98A33373D557DA587FF1B((RuntimeArray*)L_3, 0, L_4, NULL);
		return;
	}

IL_0035:
	{
		__this->____size_2 = 0;
	}

IL_003c:
	{
		return;
	}
}
