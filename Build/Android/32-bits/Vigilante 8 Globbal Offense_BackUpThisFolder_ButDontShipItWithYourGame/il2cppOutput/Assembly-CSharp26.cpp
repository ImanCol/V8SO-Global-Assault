#include "pch-cpp.hpp"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif


#include <limits>
#include <stdint.h>


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
template <typename R, typename T1, typename T2, typename T3>
struct VirtualFuncInvoker3
{
	typedef R (*Func)(void*, T1, T2, T3, const RuntimeMethod*);

	static inline R Invoke (Il2CppMethodSlot slot, RuntimeObject* obj, T1 p1, T2 p2, T3 p3)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_virtual_invoke_data(slot, obj);
		return ((Func)invokeData.methodPtr)(obj, p1, p2, p3, invokeData.method);
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

// System.Action`1<System.Object>
struct Action_1_t6F9EB113EB3F16226AEF811A2744F4111C116C87;
// System.Action`1<System.String>
struct Action_1_t3CB5D1A819C3ED3F99E9E39F890F18633253949A;
// System.Collections.Generic.Dictionary`2<System.Int32,System.Globalization.CultureInfo>
struct Dictionary_2_t9FA6D82CAFC18769F7515BB51D1C56DAE09381C3;
// System.Collections.Generic.Dictionary`2<System.Object,System.Int32>
struct Dictionary_2_t5C96F4B6841710A9013966F76224BAE01FB4B4D1;
// System.Collections.Generic.Dictionary`2<System.Object,System.Object>
struct Dictionary_2_t14FE4A752A83D53771C584E4C8D14E01F2AFD7BA;
// System.Collections.Generic.Dictionary`2<System.String,System.Collections.Generic.List`1<System.Int32>>
struct Dictionary_2_t6FFAD029BB474A5257D9A441504B633831AF5341;
// System.Collections.Generic.Dictionary`2<System.String,System.Globalization.CultureInfo>
struct Dictionary_2_tE1603CE612C16451D1E56FF4D4859D4FE4087C28;
// System.Collections.Generic.Dictionary`2<System.String,UnityEngine.Material>
struct Dictionary_2_t5B255487AF84FB5AB3382296BC4C30734ADE141F;
// System.Collections.Generic.Dictionary`2<System.String,Dummiesman.OBJObjectBuilder>
struct Dictionary_2_tC5A5AFCB8FF4726846814FB45FC66F49C9B0F82A;
// System.Collections.Generic.Dictionary`2<Dummiesman.OBJObjectBuilder/ObjLoopHash,System.Int32>
struct Dictionary_2_tEAE7D7DBCEF056EB634E23611F29B7D56A4614FE;
// System.Collections.Generic.IEnumerable`1<System.Int32>
struct IEnumerable_1_tCE758D940790D6D0D56B457E522C195F8C413AF2;
// System.Collections.Generic.IEqualityComparer`1<System.String>
struct IEqualityComparer_1_tAE94C8F24AD5B94D4EE85CA9FC59E3409D41CAF7;
// System.Collections.Generic.IEqualityComparer`1<Dummiesman.OBJObjectBuilder/ObjLoopHash>
struct IEqualityComparer_1_tFEB69696FE5D70DC653F9947660718FE286B7AE1;
// System.Collections.Generic.Dictionary`2/KeyCollection<System.String,System.Collections.Generic.List`1<System.Int32>>
struct KeyCollection_t629C3287529AAA77FEC53928EC6815E52427C6AA;
// System.Collections.Generic.Dictionary`2/KeyCollection<System.String,UnityEngine.Material>
struct KeyCollection_t4274B17E1CBE308BB3118F5BC78805BBDEDCDD90;
// System.Collections.Generic.Dictionary`2/KeyCollection<System.String,Dummiesman.OBJObjectBuilder>
struct KeyCollection_tA09E6FE7D375848C1EA850948B80C6B561FDBA1A;
// System.Collections.Generic.Dictionary`2/KeyCollection<Dummiesman.OBJObjectBuilder/ObjLoopHash,System.Int32>
struct KeyCollection_t7CF5CF2CD9AD831D6E5D831951C8AD279C5624B9;
// System.Collections.Generic.List`1<UnityEngine.Color32>
struct List_1_t3517D52AE25CA3B19051E691E9C06ED03A3AB9B8;
// System.Collections.Generic.List`1<System.Int32>
struct List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73;
// System.Collections.Generic.List`1<System.String>
struct List_1_tF470A3BE5C1B5B68E1325EF3F109D172E60BD7CD;
// System.Collections.Generic.List`1<UnityEngine.Vector2>
struct List_1_t8F3790B7F8C471B3A1336522C7415FB0AC36D47B;
// System.Collections.Generic.List`1<UnityEngine.Vector3>
struct List_1_t77B94703E05C519A9010DD0614F757F974E1CD8B;
// System.Threading.Tasks.Task`1<System.Int32>
struct Task_1_t4C228DE57804012969575431CFF12D57C875552D;
// System.Collections.Generic.Dictionary`2/ValueCollection<System.String,System.Collections.Generic.List`1<System.Int32>>
struct ValueCollection_t90997F6D607B207C2931F0BF1F0BE405C13469E9;
// System.Collections.Generic.Dictionary`2/ValueCollection<System.String,UnityEngine.Material>
struct ValueCollection_tA531AC920AAE21ED6FFB807739782DC2D244BDED;
// System.Collections.Generic.Dictionary`2/ValueCollection<System.String,Dummiesman.OBJObjectBuilder>
struct ValueCollection_t06E5110E55D6905247636B19DC797A18BEBAA8AE;
// System.Collections.Generic.Dictionary`2/ValueCollection<Dummiesman.OBJObjectBuilder/ObjLoopHash,System.Int32>
struct ValueCollection_t08AE6C93D04FA96ABF96A00F2B68A71AA363CE28;
// System.Collections.Generic.Dictionary`2/Entry<System.String,System.Collections.Generic.List`1<System.Int32>>[]
struct EntryU5BU5D_t24A2F35412A08669A461D7DAFE5CD6B21A015330;
// System.Collections.Generic.Dictionary`2/Entry<System.String,UnityEngine.Material>[]
struct EntryU5BU5D_t24D6A872CEE9B0677216214F6F3270C5897CDE5A;
// System.Collections.Generic.Dictionary`2/Entry<System.String,Dummiesman.OBJObjectBuilder>[]
struct EntryU5BU5D_t92783849F53162A82F922E243B03D8BA20FBF3B5;
// System.Collections.Generic.Dictionary`2/Entry<Dummiesman.OBJObjectBuilder/ObjLoopHash,System.Int32>[]
struct EntryU5BU5D_t67B82ACB871FB6B1CA719961C8250E72AD7FFE8A;
// System.Byte[]
struct ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031;
// System.Char[]
struct CharU5BU5D_t799905CF001DD5F13F7DBB310181FC4D8B7D0AAB;
// UnityEngine.Color[]
struct ColorU5BU5D_t612261CF293F6FFC3D80AB52259FF0DC2B2CC389;
// UnityEngine.Color32[]
struct Color32U5BU5D_t38116C3E91765C4C5726CE12C77FAD7F9F737259;
// System.Delegate[]
struct DelegateU5BU5D_tC5AB7E8F745616680F337909D3A8E6C722CDF771;
// System.Int32[]
struct Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C;
// System.IntPtr[]
struct IntPtrU5BU5D_tFD177F8C806A6921AD7150264CCC62FA00CAD832;
// UnityEngine.Material[]
struct MaterialU5BU5D_t2B1D11C42DB07A4400C0535F92DBB87A2E346D3D;
// System.Diagnostics.StackTrace[]
struct StackTraceU5BU5D_t32FBCB20930EAF5BAE3F450FF75228E5450DA0DF;
// System.String[]
struct StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248;
// UnityEngine.Vector2[]
struct Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA;
// UnityEngine.Vector3[]
struct Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C;
// B83.Image.BMP.BMPImage
struct BMPImage_tA6E059574F192A9BB574E7B260012D990055F05C;
// B83.Image.BMP.BMPLoader
struct BMPLoader_t8C88A751EA549C5D60C3E41F58F456A97D8B5C83;
// System.IO.BinaryReader
struct BinaryReader_t9A6D85F0FE9AE4EBB5E8D66997DFD1D84939E158;
// System.Globalization.Calendar
struct Calendar_t0A117CC7532A54C17188C2EFEA1F79DB20DF3A3B;
// Dummiesman.CharWordReader
struct CharWordReader_t975B8D03A4A3A2152789D6E1D57A51915D45B037;
// System.Globalization.CompareInfo
struct CompareInfo_t1B1A6AC3486B570C76ABA52149C9BD4CD82F9E57;
// System.Globalization.CultureData
struct CultureData_tEEFDCF4ECA1BBF6C0C8C94EB3541657245598F9D;
// System.Globalization.CultureInfo
struct CultureInfo_t9BA817D41AD55AC8BD07480DD8AC22F8FFA378E0;
// System.Globalization.DateTimeFormatInfo
struct DateTimeFormatInfo_t0457520F9FA7B5C8EAAEB3AD50413B6AEEB7458A;
// System.Text.Decoder
struct Decoder_tE16E789E38B25DD304004FC630EA8B21000ECBBC;
// System.DelegateData
struct DelegateData_t9B286B493293CD2D23A5B2B5EF0E5B1324C2B77E;
// System.IO.DirectoryInfo
struct DirectoryInfo_tEAEEC018EB49B4A71907FFEAFE935FAA8F9C1FE2;
// System.Text.Encoding
struct Encoding_t65CDEF28CF20A7B8C92E85A4E808920C2465F095;
// System.Exception
struct Exception_t;
// System.IO.FileInfo
struct FileInfo_t62782BBAFA832A78724E4CF2EE96548B8466AB1C;
// System.IO.FileStream
struct FileStream_t07C7222EE10B75F352B89B76E60820160FF10AD8;
// UnityEngine.GameObject
struct GameObject_t76FEDD663AB33C991A9C9A23129337651094216F;
// System.Collections.IDictionary
struct IDictionary_t6D03155AF1FA9083817AA5B6AD7DEEACC26AB220;
// System.IFormatProvider
struct IFormatProvider_tC202922D43BFF3525109ABF3FB79625F5646AB52;
// Dummiesman.ImageLoader
struct ImageLoader_t8A370851A05DC8FBFA9EF3A8348BC2D76445BD82;
// Dummiesman.ImageLoaderHelper
struct ImageLoaderHelper_t8603BF10D0193AFD974D45CB504409448995359B;
// MTLLoader
struct MTLLoader_t3B14F27942873DFDE45A9E33A2AD08A49EF1ABBA;
// UnityEngine.Material
struct Material_t18053F08F347D0DCA5E1140EC7EC4533DD8A14E3;
// System.IO.MemoryStream
struct MemoryStream_tAAED1B42172E3390584E4194308AB878E786AAC2;
// UnityEngine.Mesh
struct Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4;
// UnityEngine.MeshFilter
struct MeshFilter_t6D1CE2473A1E45AC73013400585A1163BF66B2F5;
// UnityEngine.MeshRenderer
struct MeshRenderer_t4B7747212F0B88244BB7790C61AE124BFC15BAAE;
// System.Reflection.MethodInfo
struct MethodInfo_t;
// System.Globalization.NumberFormatInfo
struct NumberFormatInfo_t8E26808B202927FEBF9064FCFEEA4D6E076E6472;
// Dummiesman.OBJLoader
struct OBJLoader_tB5927F8DB92B05302380425D21E9BCE654FD66BF;
// Dummiesman.OBJObjectBuilder
struct OBJObjectBuilder_t0FF6F614A40C0709678B6A0F9111F43397565F13;
// UnityEngine.Object
struct Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C;
// UnityEngine.Renderer
struct Renderer_t320575F223BCB177A982E5DDB5DB19FAA89E7FBF;
// Microsoft.Win32.SafeHandles.SafeFileHandle
struct SafeFileHandle_t033FA6AAAC65F4BB25F4CBA9A242A58C95CD406E;
// System.Runtime.Serialization.SafeSerializationManager
struct SafeSerializationManager_tCBB85B95DFD1634237140CD892E82D06ECB3F5E6;
// System.Threading.SemaphoreSlim
struct SemaphoreSlim_t0D5CB5685D9BFA5BF95CEC6E7395490F933E8DB2;
// UnityEngine.Shader
struct Shader_tADC867D36B7876EE22427FAA2CE485105F4EE692;
// System.IO.Stream
struct Stream_tF844051B786E8F7F4244DBD218D74E8617B9A2DE;
// System.IO.StreamReader
struct StreamReader_t81027449065C1B0C339DB46241D8001A6F61130B;
// System.String
struct String_t;
// Dummiesman.TGALoader
struct TGALoader_tBF4AA5DFA40A991239260EF4CD506E8F5F59B1E2;
// System.Threading.Tasks.Task
struct Task_t751C4CC3ECD055BABA8A0B6A5DFBB4283DCA8572;
// System.Globalization.TextInfo
struct TextInfo_tD3BAFCFD77418851E7D5CB8D2588F47019E414B4;
// UnityEngine.Texture
struct Texture_t791CBB51219779964E0E8A2ED7C1AA5F92A4A700;
// UnityEngine.Texture2D
struct Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4;
// UnityEngine.Transform
struct Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1;
// System.Void
struct Void_t4861ACF8F4594C3437BB48B6E56783494B843915;
// Dummiesman.OBJLoader/<>c__DisplayClass7_0
struct U3CU3Ec__DisplayClass7_0_tB2FCD3BDD4423D7E34A7A4B5547E642A93881A72;
// Dummiesman.OBJObjectBuilder/ObjLoopHash
struct ObjLoopHash_t0314B9758A262019FC1EFB5432DE4F2D2139B20B;
// System.IO.Stream/ReadWriteTask
struct ReadWriteTask_t0821BF49EE38596C7734E86E1A6A39D769BE2C05;

IL2CPP_EXTERN_C RuntimeClass* Action_1_t3CB5D1A819C3ED3F99E9E39F890F18633253949A_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* BMPLoader_t8C88A751EA549C5D60C3E41F58F456A97D8B5C83_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* BinaryReader_t9A6D85F0FE9AE4EBB5E8D66997DFD1D84939E158_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* BitConverter_t6E99605185963BC12B3D369E13F2B88997E64A27_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Byte_t94D9231AC217BE4D2E004C4CD32DF6D099EA41A3_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* CharWordReader_t975B8D03A4A3A2152789D6E1D57A51915D45B037_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Color32U5BU5D_t38116C3E91765C4C5726CE12C77FAD7F9F737259_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* CultureInfo_t9BA817D41AD55AC8BD07480DD8AC22F8FFA378E0_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Debug_t8394C7EEAECA3689C2C9B9DE9C7166D73596276F_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Dictionary_2_t6FFAD029BB474A5257D9A441504B633831AF5341_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Dictionary_2_tC5A5AFCB8FF4726846814FB45FC66F49C9B0F82A_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Dictionary_2_tEAE7D7DBCEF056EB634E23611F29B7D56A4614FE_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Exception_t_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* FileInfo_t62782BBAFA832A78724E4CF2EE96548B8466AB1C_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* FileStream_t07C7222EE10B75F352B89B76E60820160FF10AD8_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* GameObject_t76FEDD663AB33C991A9C9A23129337651094216F_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* IDisposable_t030E0496B4E0E4E4F086825007979AF51F7248C5_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* List_1_t77B94703E05C519A9010DD0614F757F974E1CD8B_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* List_1_t8F3790B7F8C471B3A1336522C7415FB0AC36D47B_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* MTLLoader_t3B14F27942873DFDE45A9E33A2AD08A49EF1ABBA_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* MaterialU5BU5D_t2B1D11C42DB07A4400C0535F92DBB87A2E346D3D_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Material_t18053F08F347D0DCA5E1140EC7EC4533DD8A14E3_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* MemoryStream_tAAED1B42172E3390584E4194308AB878E786AAC2_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* OBJObjectBuilder_t0FF6F614A40C0709678B6A0F9111F43397565F13_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* ObjLoopHash_t0314B9758A262019FC1EFB5432DE4F2D2139B20B_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Path_t8A38A801D0219E8209C1B1D90D82D4D755D998BC_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* StreamReader_t81027449065C1B0C339DB46241D8001A6F61130B_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* U3CU3Ec__DisplayClass7_0_tB2FCD3BDD4423D7E34A7A4B5547E642A93881A72_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C String_t* _stringLiteral0B0FEB3147CE20EB2C90076367F895C59BCD14B3;
IL2CPP_EXTERN_C String_t* _stringLiteral0FFABE86E9532C726C3E9C7D10AFE388437A380D;
IL2CPP_EXTERN_C String_t* _stringLiteral10682F3387EA548C626C08591967BD5D821B3ACA;
IL2CPP_EXTERN_C String_t* _stringLiteral1A3E4D14FCCE4BCFFF56E01EE25543AD3912FB19;
IL2CPP_EXTERN_C String_t* _stringLiteral2386E77CF610F786B06A91AF2C1B3FD2282D2745;
IL2CPP_EXTERN_C String_t* _stringLiteral23DF9991B71463C240582D176E347E7E47AEFF5A;
IL2CPP_EXTERN_C String_t* _stringLiteral24A67F22FEE896ED79449BFCF3EC311FB14605C6;
IL2CPP_EXTERN_C String_t* _stringLiteral267226911D4A958D79875B1057280198F25BE5F6;
IL2CPP_EXTERN_C String_t* _stringLiteral2B9B6C84CC15492CCB290C4B79418FA6D7DD24C1;
IL2CPP_EXTERN_C String_t* _stringLiteral2C945D246C2B7897F000E1C591A686EB9EF010F0;
IL2CPP_EXTERN_C String_t* _stringLiteral3201B86FACEA09A6EC2396E7556112CD64565211;
IL2CPP_EXTERN_C String_t* _stringLiteral36282FAC116D9FD6B37CC425310E1A8510F08A53;
IL2CPP_EXTERN_C String_t* _stringLiteral3708CDBCC9F390AB99D52FE7DEE4724401B69B9F;
IL2CPP_EXTERN_C String_t* _stringLiteral4B752498CA45AB14E5BD67D359EAE6F257213868;
IL2CPP_EXTERN_C String_t* _stringLiteral4B9B40AAD718882F5C0B95FE844E4AA92BD49C42;
IL2CPP_EXTERN_C String_t* _stringLiteral52CBE4A5A42509939BB9DB58A4B9A2C9BBA81C1C;
IL2CPP_EXTERN_C String_t* _stringLiteral579A50C67ADB00AC3925859C23590322B2D0BE9D;
IL2CPP_EXTERN_C String_t* _stringLiteral61304A4D1A7F7C3C856F975F251F1F79885933C8;
IL2CPP_EXTERN_C String_t* _stringLiteral6F5EC7239B41C242FCB23B64D91DA0070FC1C044;
IL2CPP_EXTERN_C String_t* _stringLiteral73B13DE9817379145386BC6ECC87E983FC8ED41A;
IL2CPP_EXTERN_C String_t* _stringLiteral7D61FA9D9BE7581D7E2EE28C775ABE0D4B8C3D69;
IL2CPP_EXTERN_C String_t* _stringLiteral832717F6DAEDB69A0AB5F44CBE008C33CE5DD496;
IL2CPP_EXTERN_C String_t* _stringLiteral8A8EFDA91C6C257127F8C8D526FAD7E7552766AA;
IL2CPP_EXTERN_C String_t* _stringLiteral911FC00FE8A864A9D1B8F87A75E4EE5041ACF43B;
IL2CPP_EXTERN_C String_t* _stringLiteral91BA0BFEE39A878ED243A61DE051D5D17B6388A0;
IL2CPP_EXTERN_C String_t* _stringLiteral985B72B30ECE05DD4EF5FE142CEE0FB8BF53A98C;
IL2CPP_EXTERN_C String_t* _stringLiteral9DFFC3267C5F999585E61B45BA9C8DF18D4B02CA;
IL2CPP_EXTERN_C String_t* _stringLiteral9FB5B88DDC4C14C62E4014842DEC88E8353401A0;
IL2CPP_EXTERN_C String_t* _stringLiteralA067DCF7E189AC44F89249565422DE596AC9C3D6;
IL2CPP_EXTERN_C String_t* _stringLiteralA15C898F015A9B0BC3268E8883CD03008A56DE26;
IL2CPP_EXTERN_C String_t* _stringLiteralA2B5208CBD672BD56D417E00B07619D4FDBBD0C2;
IL2CPP_EXTERN_C String_t* _stringLiteralB25CF1C6B74339FBFCE846454A70688CE58C094C;
IL2CPP_EXTERN_C String_t* _stringLiteralB93D5DFE334D74396F45A6431764B0B46F089032;
IL2CPP_EXTERN_C String_t* _stringLiteralBEFAFB5DB9B504BEEF8A79E3E990D713103F15A0;
IL2CPP_EXTERN_C String_t* _stringLiteralC00413A65EA4BBDF5F981E7DC7F68313AA28D95F;
IL2CPP_EXTERN_C String_t* _stringLiteralCACB21833BB4CA1A557B18751B7691C087DC04A2;
IL2CPP_EXTERN_C String_t* _stringLiteralCBCD3D866AF896F9B010A0FEE7F961DBC91A08C5;
IL2CPP_EXTERN_C String_t* _stringLiteralCCC77F6BEC01F19B25AEAE1DA587DC5A6486B284;
IL2CPP_EXTERN_C String_t* _stringLiteralDDA7CFEAD2959669C703813D83A33F35133DB619;
IL2CPP_EXTERN_C String_t* _stringLiteralFCFD8B76B9829DED087D9E535D4DCC22884C582B;
IL2CPP_EXTERN_C const RuntimeMethod* Action_1_Invoke_m690438AAE38F9762172E3AE0A33D0B42ACD35790_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Action_1__ctor_m9DC2953C55C4D7D4B7BEFE03D84DA1F9362D652C_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* DDSLoader_Load_m11E28E4EA6EDE7B53BB990A398F4281D2BDA56AF_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* DDSLoader_Load_mF25129AE55E29A32883B8334AB2D5855DCDFAC2C_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Dictionary_2_Add_m45B16A0848D5AA8855A51C20C2AA2B90A6516877_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Dictionary_2_GetEnumerator_m2E9E4B0E50E5FBA0C7E62ACEAD7A0327267C4C2E_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Dictionary_2_GetEnumerator_m30A75F41A2E01FBA254EA9D604F77CA1E9EBBCA5_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Dictionary_2_TryGetValue_m0058521363E7F49C437C430A754DB0F1B5379289_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Dictionary_2_TryGetValue_m0C13BB2CCCC84DFF397E1F1708A35D6B855E83D3_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Dictionary_2_TryGetValue_m56F2C16A68E7E1B774D8B14B3DF74FA825C5CC9C_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Dictionary_2_TryGetValue_mFD7867D61B454D815AFE71D04D27540FAFBFF091_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Dictionary_2__ctor_m63CFEDABA0B46AEB5DB36FFBCDDAD873A37C82FE_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Dictionary_2__ctor_m82637A3A6031C43DB9CC910DBD6DCC66D9459C8F_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Dictionary_2__ctor_mB2E3E483638E602FE00B68DB9132FA5D5704D11F_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Dictionary_2_get_Count_m831221DAC53C65F38539F4A37520985E8DC557AF_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Dictionary_2_set_Item_m2712E92CF36B85D20B01493D39F2BD4504C0BE7B_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Dictionary_2_set_Item_m529105CC1CF8E638D570A195BF4D8BA4984EB3E8_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Dictionary_2_set_Item_m829F1D3D238D6C188AE5440AC46680D7F3B66304_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Enumerator_Dispose_m1ED4783F9B383A3AAA727AA5F6241652CEDF91FF_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Enumerator_Dispose_m20C3A9898BD2C0D50D588257FE9C176D0F748C62_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Enumerator_MoveNext_m6F709DC1AED45A132D5B2CE5C6912F4FB3BA6872_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Enumerator_MoveNext_mA034A5AAF361AFA6ADC0AB189A2408443B767A1D_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Enumerator_get_Current_m0979A8E7E158B0EF6E0CD0B8377E30390074D0FA_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Enumerator_get_Current_mAD3C13EC90677751AE02D5DF4E981C2831DD1C1C_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* GameObject_AddComponent_TisMeshFilter_t6D1CE2473A1E45AC73013400585A1163BF66B2F5_mEAB8177A64DF1A50BB7996ACEEEADCD65358AC94_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* GameObject_AddComponent_TisMeshRenderer_t4B7747212F0B88244BB7790C61AE124BFC15BAAE_mCDD3E77673305199F52C772AE8C7952F3864740D_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* ImageLoader_LoadTexture_m18E6BD5678745378336D315F849BF352A8D4B099_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* KeyValuePair_2_get_Key_mFF379184A888CEA6C7DD77DD5DD36E5819C98D99_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* KeyValuePair_2_get_Value_mD180D6D30ED20CC169164BC3EABC7B8455ED0516_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* KeyValuePair_2_get_Value_mD43CA99389807F2DF5FE76DBEC3D4174C787BE98_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* List_1_AddRange_m1A10E697703D67F6551D47C603FFE78E16CE4204_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* List_1_Add_m0248A96C5334E9A93E6994B7780478BCD994EA3D_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* List_1_Add_m79E50C4F592B1703F4B76A8BE7B4855515460CA1_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* List_1_Add_mB5FDF069171C4CB1778BFAC3B9015A22EA7DFBCD_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* List_1_Clear_mF6795DE5F49C1D0B91D6A0955F448B22970D67A9_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* List_1__ctor_m17F501B5A5C289ECE1B4F3D6EBF05DFA421433F8_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* List_1__ctor_m88C4BD8AC607DB3585552068F4DC437406358D5F_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* List_1__ctor_mC54E2BCBE43279A96FC082F5CDE2D76388BD8F9C_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* List_1_get_Count_m46EEFFA770BE665EA0CB3A5332E941DA4B3C1D37_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* List_1_get_Count_mF1C0C56457C655BDFFC6EE5B46FAD8BAEC1F588B_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* List_1_get_Count_mF590592E32D421DE2C6E2F0D5C2F62FB14CCEFDF_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* List_1_get_Item_m1F8E226CAD72B83C5E75BB66B43025247806B543_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* List_1_get_Item_m8F2E15FC96DA75186C51228128A0660709E4E810_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* List_1_get_Item_mD99081BEFA1AB3526715F489192B0F7F596C183D_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* TGALoader_Load_mB5CF838E183A7538AF925552AC81CA3B6C9AFC0D_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* U3CU3Ec__DisplayClass7_0_U3CLoadU3Eb__0_mB7A2836C48583F685E7276DD780FA5A7F2EFBCF7_RuntimeMethod_var;
struct CultureData_tEEFDCF4ECA1BBF6C0C8C94EB3541657245598F9D_marshaled_com;
struct CultureData_tEEFDCF4ECA1BBF6C0C8C94EB3541657245598F9D_marshaled_pinvoke;
struct CultureInfo_t9BA817D41AD55AC8BD07480DD8AC22F8FFA378E0_marshaled_com;
struct CultureInfo_t9BA817D41AD55AC8BD07480DD8AC22F8FFA378E0_marshaled_pinvoke;
struct Delegate_t_marshaled_com;
struct Delegate_t_marshaled_pinvoke;
struct Exception_t_marshaled_com;
struct Exception_t_marshaled_pinvoke;

struct ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031;
struct ColorU5BU5D_t612261CF293F6FFC3D80AB52259FF0DC2B2CC389;
struct Color32U5BU5D_t38116C3E91765C4C5726CE12C77FAD7F9F737259;
struct Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C;
struct MaterialU5BU5D_t2B1D11C42DB07A4400C0535F92DBB87A2E346D3D;
struct StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248;
struct Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA;
struct Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C;

IL2CPP_EXTERN_C_BEGIN
IL2CPP_EXTERN_C_END

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Collections.Generic.Dictionary`2<System.String,System.Collections.Generic.List`1<System.Int32>>
struct Dictionary_2_t6FFAD029BB474A5257D9A441504B633831AF5341  : public RuntimeObject
{
	// System.Int32[] System.Collections.Generic.Dictionary`2::_buckets
	Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* ____buckets_0;
	// System.Collections.Generic.Dictionary`2/Entry<TKey,TValue>[] System.Collections.Generic.Dictionary`2::_entries
	EntryU5BU5D_t24A2F35412A08669A461D7DAFE5CD6B21A015330* ____entries_1;
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
	KeyCollection_t629C3287529AAA77FEC53928EC6815E52427C6AA* ____keys_7;
	// System.Collections.Generic.Dictionary`2/ValueCollection<TKey,TValue> System.Collections.Generic.Dictionary`2::_values
	ValueCollection_t90997F6D607B207C2931F0BF1F0BE405C13469E9* ____values_8;
	// System.Object System.Collections.Generic.Dictionary`2::_syncRoot
	RuntimeObject* ____syncRoot_9;
};

// System.Collections.Generic.Dictionary`2<System.String,UnityEngine.Material>
struct Dictionary_2_t5B255487AF84FB5AB3382296BC4C30734ADE141F  : public RuntimeObject
{
	// System.Int32[] System.Collections.Generic.Dictionary`2::_buckets
	Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* ____buckets_0;
	// System.Collections.Generic.Dictionary`2/Entry<TKey,TValue>[] System.Collections.Generic.Dictionary`2::_entries
	EntryU5BU5D_t24D6A872CEE9B0677216214F6F3270C5897CDE5A* ____entries_1;
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
	KeyCollection_t4274B17E1CBE308BB3118F5BC78805BBDEDCDD90* ____keys_7;
	// System.Collections.Generic.Dictionary`2/ValueCollection<TKey,TValue> System.Collections.Generic.Dictionary`2::_values
	ValueCollection_tA531AC920AAE21ED6FFB807739782DC2D244BDED* ____values_8;
	// System.Object System.Collections.Generic.Dictionary`2::_syncRoot
	RuntimeObject* ____syncRoot_9;
};

// System.Collections.Generic.Dictionary`2<System.String,Dummiesman.OBJObjectBuilder>
struct Dictionary_2_tC5A5AFCB8FF4726846814FB45FC66F49C9B0F82A  : public RuntimeObject
{
	// System.Int32[] System.Collections.Generic.Dictionary`2::_buckets
	Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* ____buckets_0;
	// System.Collections.Generic.Dictionary`2/Entry<TKey,TValue>[] System.Collections.Generic.Dictionary`2::_entries
	EntryU5BU5D_t92783849F53162A82F922E243B03D8BA20FBF3B5* ____entries_1;
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
	KeyCollection_tA09E6FE7D375848C1EA850948B80C6B561FDBA1A* ____keys_7;
	// System.Collections.Generic.Dictionary`2/ValueCollection<TKey,TValue> System.Collections.Generic.Dictionary`2::_values
	ValueCollection_t06E5110E55D6905247636B19DC797A18BEBAA8AE* ____values_8;
	// System.Object System.Collections.Generic.Dictionary`2::_syncRoot
	RuntimeObject* ____syncRoot_9;
};

// System.Collections.Generic.Dictionary`2<Dummiesman.OBJObjectBuilder/ObjLoopHash,System.Int32>
struct Dictionary_2_tEAE7D7DBCEF056EB634E23611F29B7D56A4614FE  : public RuntimeObject
{
	// System.Int32[] System.Collections.Generic.Dictionary`2::_buckets
	Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* ____buckets_0;
	// System.Collections.Generic.Dictionary`2/Entry<TKey,TValue>[] System.Collections.Generic.Dictionary`2::_entries
	EntryU5BU5D_t67B82ACB871FB6B1CA719961C8250E72AD7FFE8A* ____entries_1;
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
	KeyCollection_t7CF5CF2CD9AD831D6E5D831951C8AD279C5624B9* ____keys_7;
	// System.Collections.Generic.Dictionary`2/ValueCollection<TKey,TValue> System.Collections.Generic.Dictionary`2::_values
	ValueCollection_t08AE6C93D04FA96ABF96A00F2B68A71AA363CE28* ____values_8;
	// System.Object System.Collections.Generic.Dictionary`2::_syncRoot
	RuntimeObject* ____syncRoot_9;
};

// System.Collections.Generic.List`1<System.Int32>
struct List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73  : public RuntimeObject
{
	// T[] System.Collections.Generic.List`1::_items
	Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* ____items_1;
	// System.Int32 System.Collections.Generic.List`1::_size
	int32_t ____size_2;
	// System.Int32 System.Collections.Generic.List`1::_version
	int32_t ____version_3;
	// System.Object System.Collections.Generic.List`1::_syncRoot
	RuntimeObject* ____syncRoot_4;
};

struct List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73_StaticFields
{
	// T[] System.Collections.Generic.List`1::s_emptyArray
	Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* ___s_emptyArray_5;
};

// System.Collections.Generic.List`1<UnityEngine.Vector2>
struct List_1_t8F3790B7F8C471B3A1336522C7415FB0AC36D47B  : public RuntimeObject
{
	// T[] System.Collections.Generic.List`1::_items
	Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* ____items_1;
	// System.Int32 System.Collections.Generic.List`1::_size
	int32_t ____size_2;
	// System.Int32 System.Collections.Generic.List`1::_version
	int32_t ____version_3;
	// System.Object System.Collections.Generic.List`1::_syncRoot
	RuntimeObject* ____syncRoot_4;
};

struct List_1_t8F3790B7F8C471B3A1336522C7415FB0AC36D47B_StaticFields
{
	// T[] System.Collections.Generic.List`1::s_emptyArray
	Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* ___s_emptyArray_5;
};

// System.Collections.Generic.List`1<UnityEngine.Vector3>
struct List_1_t77B94703E05C519A9010DD0614F757F974E1CD8B  : public RuntimeObject
{
	// T[] System.Collections.Generic.List`1::_items
	Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* ____items_1;
	// System.Int32 System.Collections.Generic.List`1::_size
	int32_t ____size_2;
	// System.Int32 System.Collections.Generic.List`1::_version
	int32_t ____version_3;
	// System.Object System.Collections.Generic.List`1::_syncRoot
	RuntimeObject* ____syncRoot_4;
};

struct List_1_t77B94703E05C519A9010DD0614F757F974E1CD8B_StaticFields
{
	// T[] System.Collections.Generic.List`1::s_emptyArray
	Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* ___s_emptyArray_5;
};
struct Il2CppArrayBounds;

// B83.Image.BMP.BMPLoader
struct BMPLoader_t8C88A751EA549C5D60C3E41F58F456A97D8B5C83  : public RuntimeObject
{
	// System.Boolean B83.Image.BMP.BMPLoader::ReadPaletteAlpha
	bool ___ReadPaletteAlpha_1;
	// System.Boolean B83.Image.BMP.BMPLoader::ForceAlphaReadWhenPossible
	bool ___ForceAlphaReadWhenPossible_2;
};

// Dummiesman.BinaryExtensions
struct BinaryExtensions_t4C91DF61D47494D389E27ECFFB2B72C26F7BBE35  : public RuntimeObject
{
};

// System.IO.BinaryReader
struct BinaryReader_t9A6D85F0FE9AE4EBB5E8D66997DFD1D84939E158  : public RuntimeObject
{
	// System.IO.Stream System.IO.BinaryReader::m_stream
	Stream_tF844051B786E8F7F4244DBD218D74E8617B9A2DE* ___m_stream_0;
	// System.Byte[] System.IO.BinaryReader::m_buffer
	ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* ___m_buffer_1;
	// System.Text.Decoder System.IO.BinaryReader::m_decoder
	Decoder_tE16E789E38B25DD304004FC630EA8B21000ECBBC* ___m_decoder_2;
	// System.Byte[] System.IO.BinaryReader::m_charBytes
	ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* ___m_charBytes_3;
	// System.Char[] System.IO.BinaryReader::m_singleChar
	CharU5BU5D_t799905CF001DD5F13F7DBB310181FC4D8B7D0AAB* ___m_singleChar_4;
	// System.Char[] System.IO.BinaryReader::m_charBuffer
	CharU5BU5D_t799905CF001DD5F13F7DBB310181FC4D8B7D0AAB* ___m_charBuffer_5;
	// System.Int32 System.IO.BinaryReader::m_maxCharsSize
	int32_t ___m_maxCharsSize_6;
	// System.Boolean System.IO.BinaryReader::m_2BytesPerChar
	bool ___m_2BytesPerChar_7;
	// System.Boolean System.IO.BinaryReader::m_isMemoryStream
	bool ___m_isMemoryStream_8;
	// System.Boolean System.IO.BinaryReader::m_leaveOpen
	bool ___m_leaveOpen_9;
};

// Dummiesman.CharWordReader
struct CharWordReader_t975B8D03A4A3A2152789D6E1D57A51915D45B037  : public RuntimeObject
{
	// System.Char[] Dummiesman.CharWordReader::word
	CharU5BU5D_t799905CF001DD5F13F7DBB310181FC4D8B7D0AAB* ___word_0;
	// System.Int32 Dummiesman.CharWordReader::wordSize
	int32_t ___wordSize_1;
	// System.Boolean Dummiesman.CharWordReader::endReached
	bool ___endReached_2;
	// System.IO.StreamReader Dummiesman.CharWordReader::reader
	StreamReader_t81027449065C1B0C339DB46241D8001A6F61130B* ___reader_3;
	// System.Int32 Dummiesman.CharWordReader::bufferSize
	int32_t ___bufferSize_4;
	// System.Char[] Dummiesman.CharWordReader::buffer
	CharU5BU5D_t799905CF001DD5F13F7DBB310181FC4D8B7D0AAB* ___buffer_5;
	// System.Char Dummiesman.CharWordReader::currentChar
	Il2CppChar ___currentChar_6;
	// System.Int32 Dummiesman.CharWordReader::currentPosition
	int32_t ___currentPosition_7;
	// System.Int32 Dummiesman.CharWordReader::maxPosition
	int32_t ___maxPosition_8;
};

// Dummiesman.Extensions.ColorExtensions
struct ColorExtensions_t11CBE6A7B40152B1727BFC9693F700A13BC26A57  : public RuntimeObject
{
};

// System.Globalization.CultureInfo
struct CultureInfo_t9BA817D41AD55AC8BD07480DD8AC22F8FFA378E0  : public RuntimeObject
{
	// System.Boolean System.Globalization.CultureInfo::m_isReadOnly
	bool ___m_isReadOnly_3;
	// System.Int32 System.Globalization.CultureInfo::cultureID
	int32_t ___cultureID_4;
	// System.Int32 System.Globalization.CultureInfo::parent_lcid
	int32_t ___parent_lcid_5;
	// System.Int32 System.Globalization.CultureInfo::datetime_index
	int32_t ___datetime_index_6;
	// System.Int32 System.Globalization.CultureInfo::number_index
	int32_t ___number_index_7;
	// System.Int32 System.Globalization.CultureInfo::default_calendar_type
	int32_t ___default_calendar_type_8;
	// System.Boolean System.Globalization.CultureInfo::m_useUserOverride
	bool ___m_useUserOverride_9;
	// System.Globalization.NumberFormatInfo modreq(System.Runtime.CompilerServices.IsVolatile) System.Globalization.CultureInfo::numInfo
	NumberFormatInfo_t8E26808B202927FEBF9064FCFEEA4D6E076E6472* ___numInfo_10;
	// System.Globalization.DateTimeFormatInfo modreq(System.Runtime.CompilerServices.IsVolatile) System.Globalization.CultureInfo::dateTimeInfo
	DateTimeFormatInfo_t0457520F9FA7B5C8EAAEB3AD50413B6AEEB7458A* ___dateTimeInfo_11;
	// System.Globalization.TextInfo modreq(System.Runtime.CompilerServices.IsVolatile) System.Globalization.CultureInfo::textInfo
	TextInfo_tD3BAFCFD77418851E7D5CB8D2588F47019E414B4* ___textInfo_12;
	// System.String System.Globalization.CultureInfo::m_name
	String_t* ___m_name_13;
	// System.String System.Globalization.CultureInfo::englishname
	String_t* ___englishname_14;
	// System.String System.Globalization.CultureInfo::nativename
	String_t* ___nativename_15;
	// System.String System.Globalization.CultureInfo::iso3lang
	String_t* ___iso3lang_16;
	// System.String System.Globalization.CultureInfo::iso2lang
	String_t* ___iso2lang_17;
	// System.String System.Globalization.CultureInfo::win3lang
	String_t* ___win3lang_18;
	// System.String System.Globalization.CultureInfo::territory
	String_t* ___territory_19;
	// System.String[] System.Globalization.CultureInfo::native_calendar_names
	StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248* ___native_calendar_names_20;
	// System.Globalization.CompareInfo modreq(System.Runtime.CompilerServices.IsVolatile) System.Globalization.CultureInfo::compareInfo
	CompareInfo_t1B1A6AC3486B570C76ABA52149C9BD4CD82F9E57* ___compareInfo_21;
	// System.Void* System.Globalization.CultureInfo::textinfo_data
	void* ___textinfo_data_22;
	// System.Int32 System.Globalization.CultureInfo::m_dataItem
	int32_t ___m_dataItem_23;
	// System.Globalization.Calendar System.Globalization.CultureInfo::calendar
	Calendar_t0A117CC7532A54C17188C2EFEA1F79DB20DF3A3B* ___calendar_24;
	// System.Globalization.CultureInfo System.Globalization.CultureInfo::parent_culture
	CultureInfo_t9BA817D41AD55AC8BD07480DD8AC22F8FFA378E0* ___parent_culture_25;
	// System.Boolean System.Globalization.CultureInfo::constructed
	bool ___constructed_26;
	// System.Byte[] System.Globalization.CultureInfo::cached_serialized_form
	ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* ___cached_serialized_form_27;
	// System.Globalization.CultureData System.Globalization.CultureInfo::m_cultureData
	CultureData_tEEFDCF4ECA1BBF6C0C8C94EB3541657245598F9D* ___m_cultureData_28;
	// System.Boolean System.Globalization.CultureInfo::m_isInherited
	bool ___m_isInherited_29;
};

struct CultureInfo_t9BA817D41AD55AC8BD07480DD8AC22F8FFA378E0_StaticFields
{
	// System.Globalization.CultureInfo modreq(System.Runtime.CompilerServices.IsVolatile) System.Globalization.CultureInfo::invariant_culture_info
	CultureInfo_t9BA817D41AD55AC8BD07480DD8AC22F8FFA378E0* ___invariant_culture_info_0;
	// System.Object System.Globalization.CultureInfo::shared_table_lock
	RuntimeObject* ___shared_table_lock_1;
	// System.Globalization.CultureInfo System.Globalization.CultureInfo::default_current_culture
	CultureInfo_t9BA817D41AD55AC8BD07480DD8AC22F8FFA378E0* ___default_current_culture_2;
	// System.Globalization.CultureInfo modreq(System.Runtime.CompilerServices.IsVolatile) System.Globalization.CultureInfo::s_DefaultThreadCurrentUICulture
	CultureInfo_t9BA817D41AD55AC8BD07480DD8AC22F8FFA378E0* ___s_DefaultThreadCurrentUICulture_34;
	// System.Globalization.CultureInfo modreq(System.Runtime.CompilerServices.IsVolatile) System.Globalization.CultureInfo::s_DefaultThreadCurrentCulture
	CultureInfo_t9BA817D41AD55AC8BD07480DD8AC22F8FFA378E0* ___s_DefaultThreadCurrentCulture_35;
	// System.Collections.Generic.Dictionary`2<System.Int32,System.Globalization.CultureInfo> System.Globalization.CultureInfo::shared_by_number
	Dictionary_2_t9FA6D82CAFC18769F7515BB51D1C56DAE09381C3* ___shared_by_number_36;
	// System.Collections.Generic.Dictionary`2<System.String,System.Globalization.CultureInfo> System.Globalization.CultureInfo::shared_by_name
	Dictionary_2_tE1603CE612C16451D1E56FF4D4859D4FE4087C28* ___shared_by_name_37;
	// System.Boolean System.Globalization.CultureInfo::IsTaiwanSku
	bool ___IsTaiwanSku_38;
};
// Native definition for P/Invoke marshalling of System.Globalization.CultureInfo
struct CultureInfo_t9BA817D41AD55AC8BD07480DD8AC22F8FFA378E0_marshaled_pinvoke
{
	int32_t ___m_isReadOnly_3;
	int32_t ___cultureID_4;
	int32_t ___parent_lcid_5;
	int32_t ___datetime_index_6;
	int32_t ___number_index_7;
	int32_t ___default_calendar_type_8;
	int32_t ___m_useUserOverride_9;
	NumberFormatInfo_t8E26808B202927FEBF9064FCFEEA4D6E076E6472* ___numInfo_10;
	DateTimeFormatInfo_t0457520F9FA7B5C8EAAEB3AD50413B6AEEB7458A* ___dateTimeInfo_11;
	TextInfo_tD3BAFCFD77418851E7D5CB8D2588F47019E414B4* ___textInfo_12;
	char* ___m_name_13;
	char* ___englishname_14;
	char* ___nativename_15;
	char* ___iso3lang_16;
	char* ___iso2lang_17;
	char* ___win3lang_18;
	char* ___territory_19;
	char** ___native_calendar_names_20;
	CompareInfo_t1B1A6AC3486B570C76ABA52149C9BD4CD82F9E57* ___compareInfo_21;
	void* ___textinfo_data_22;
	int32_t ___m_dataItem_23;
	Calendar_t0A117CC7532A54C17188C2EFEA1F79DB20DF3A3B* ___calendar_24;
	CultureInfo_t9BA817D41AD55AC8BD07480DD8AC22F8FFA378E0_marshaled_pinvoke* ___parent_culture_25;
	int32_t ___constructed_26;
	Il2CppSafeArray/*NONE*/* ___cached_serialized_form_27;
	CultureData_tEEFDCF4ECA1BBF6C0C8C94EB3541657245598F9D_marshaled_pinvoke* ___m_cultureData_28;
	int32_t ___m_isInherited_29;
};
// Native definition for COM marshalling of System.Globalization.CultureInfo
struct CultureInfo_t9BA817D41AD55AC8BD07480DD8AC22F8FFA378E0_marshaled_com
{
	int32_t ___m_isReadOnly_3;
	int32_t ___cultureID_4;
	int32_t ___parent_lcid_5;
	int32_t ___datetime_index_6;
	int32_t ___number_index_7;
	int32_t ___default_calendar_type_8;
	int32_t ___m_useUserOverride_9;
	NumberFormatInfo_t8E26808B202927FEBF9064FCFEEA4D6E076E6472* ___numInfo_10;
	DateTimeFormatInfo_t0457520F9FA7B5C8EAAEB3AD50413B6AEEB7458A* ___dateTimeInfo_11;
	TextInfo_tD3BAFCFD77418851E7D5CB8D2588F47019E414B4* ___textInfo_12;
	Il2CppChar* ___m_name_13;
	Il2CppChar* ___englishname_14;
	Il2CppChar* ___nativename_15;
	Il2CppChar* ___iso3lang_16;
	Il2CppChar* ___iso2lang_17;
	Il2CppChar* ___win3lang_18;
	Il2CppChar* ___territory_19;
	Il2CppChar** ___native_calendar_names_20;
	CompareInfo_t1B1A6AC3486B570C76ABA52149C9BD4CD82F9E57* ___compareInfo_21;
	void* ___textinfo_data_22;
	int32_t ___m_dataItem_23;
	Calendar_t0A117CC7532A54C17188C2EFEA1F79DB20DF3A3B* ___calendar_24;
	CultureInfo_t9BA817D41AD55AC8BD07480DD8AC22F8FFA378E0_marshaled_com* ___parent_culture_25;
	int32_t ___constructed_26;
	Il2CppSafeArray/*NONE*/* ___cached_serialized_form_27;
	CultureData_tEEFDCF4ECA1BBF6C0C8C94EB3541657245598F9D_marshaled_com* ___m_cultureData_28;
	int32_t ___m_isInherited_29;
};

// Dummiesman.DDSLoader
struct DDSLoader_t1BCAC2E37F4DD03E4D5E7C504C8383A32A0DC40F  : public RuntimeObject
{
};

// Dummiesman.ImageLoader
struct ImageLoader_t8A370851A05DC8FBFA9EF3A8348BC2D76445BD82  : public RuntimeObject
{
};

// Dummiesman.ImageLoaderHelper
struct ImageLoaderHelper_t8603BF10D0193AFD974D45CB504409448995359B  : public RuntimeObject
{
};

// Dummiesman.ImageUtils
struct ImageUtils_t181A75EDA6EC524F53330496B4E116B38CE65744  : public RuntimeObject
{
};

// MTLLoader
struct MTLLoader_t3B14F27942873DFDE45A9E33A2AD08A49EF1ABBA  : public RuntimeObject
{
	// System.Collections.Generic.List`1<System.String> MTLLoader::SearchPaths
	List_1_tF470A3BE5C1B5B68E1325EF3F109D172E60BD7CD* ___SearchPaths_0;
	// System.IO.FileInfo MTLLoader::_objFileInfo
	FileInfo_t62782BBAFA832A78724E4CF2EE96548B8466AB1C* ____objFileInfo_1;
};

// System.MarshalByRefObject
struct MarshalByRefObject_t8C2F4C5854177FD60439EB1FCCFC1B3CFAFE8DCE  : public RuntimeObject
{
	// System.Object System.MarshalByRefObject::_identity
	RuntimeObject* ____identity_0;
};
// Native definition for P/Invoke marshalling of System.MarshalByRefObject
struct MarshalByRefObject_t8C2F4C5854177FD60439EB1FCCFC1B3CFAFE8DCE_marshaled_pinvoke
{
	Il2CppIUnknown* ____identity_0;
};
// Native definition for COM marshalling of System.MarshalByRefObject
struct MarshalByRefObject_t8C2F4C5854177FD60439EB1FCCFC1B3CFAFE8DCE_marshaled_com
{
	Il2CppIUnknown* ____identity_0;
};

// Dummiesman.OBJLoaderHelper
struct OBJLoaderHelper_tBB2F071274F30E8A69777A153438463B014602FD  : public RuntimeObject
{
};

// Dummiesman.OBJObjectBuilder
struct OBJObjectBuilder_t0FF6F614A40C0709678B6A0F9111F43397565F13  : public RuntimeObject
{
	// System.Int32 Dummiesman.OBJObjectBuilder::<PushedFaceCount>k__BackingField
	int32_t ___U3CPushedFaceCountU3Ek__BackingField_0;
	// Dummiesman.OBJLoader Dummiesman.OBJObjectBuilder::_loader
	OBJLoader_tB5927F8DB92B05302380425D21E9BCE654FD66BF* ____loader_1;
	// System.String Dummiesman.OBJObjectBuilder::_name
	String_t* ____name_2;
	// System.Collections.Generic.Dictionary`2<Dummiesman.OBJObjectBuilder/ObjLoopHash,System.Int32> Dummiesman.OBJObjectBuilder::_globalIndexRemap
	Dictionary_2_tEAE7D7DBCEF056EB634E23611F29B7D56A4614FE* ____globalIndexRemap_3;
	// System.Collections.Generic.Dictionary`2<System.String,System.Collections.Generic.List`1<System.Int32>> Dummiesman.OBJObjectBuilder::_materialIndices
	Dictionary_2_t6FFAD029BB474A5257D9A441504B633831AF5341* ____materialIndices_4;
	// System.Collections.Generic.List`1<System.Int32> Dummiesman.OBJObjectBuilder::_currentIndexList
	List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73* ____currentIndexList_5;
	// System.String Dummiesman.OBJObjectBuilder::_lastMaterial
	String_t* ____lastMaterial_6;
	// System.Collections.Generic.List`1<UnityEngine.Vector3> Dummiesman.OBJObjectBuilder::_vertices
	List_1_t77B94703E05C519A9010DD0614F757F974E1CD8B* ____vertices_7;
	// System.Collections.Generic.List`1<UnityEngine.Vector3> Dummiesman.OBJObjectBuilder::_normals
	List_1_t77B94703E05C519A9010DD0614F757F974E1CD8B* ____normals_8;
	// System.Collections.Generic.List`1<UnityEngine.Vector2> Dummiesman.OBJObjectBuilder::_uvs
	List_1_t8F3790B7F8C471B3A1336522C7415FB0AC36D47B* ____uvs_9;
	// System.Boolean Dummiesman.OBJObjectBuilder::recalculateNormals
	bool ___recalculateNormals_10;
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

// Dummiesman.StringExtensions
struct StringExtensions_t26118E44D1EAD5B4516920FF322A52B81934C186  : public RuntimeObject
{
};

// Dummiesman.TGALoader
struct TGALoader_tBF4AA5DFA40A991239260EF4CD506E8F5F59B1E2  : public RuntimeObject
{
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

// Dummiesman.OBJLoader/<>c__DisplayClass7_0
struct U3CU3Ec__DisplayClass7_0_tB2FCD3BDD4423D7E34A7A4B5547E642A93881A72  : public RuntimeObject
{
	// System.Collections.Generic.Dictionary`2<System.String,Dummiesman.OBJObjectBuilder> Dummiesman.OBJLoader/<>c__DisplayClass7_0::builderDict
	Dictionary_2_tC5A5AFCB8FF4726846814FB45FC66F49C9B0F82A* ___builderDict_0;
	// Dummiesman.OBJObjectBuilder Dummiesman.OBJLoader/<>c__DisplayClass7_0::currentBuilder
	OBJObjectBuilder_t0FF6F614A40C0709678B6A0F9111F43397565F13* ___currentBuilder_1;
	// Dummiesman.OBJLoader Dummiesman.OBJLoader/<>c__DisplayClass7_0::<>4__this
	OBJLoader_tB5927F8DB92B05302380425D21E9BCE654FD66BF* ___U3CU3E4__this_2;
};

// Dummiesman.OBJObjectBuilder/ObjLoopHash
struct ObjLoopHash_t0314B9758A262019FC1EFB5432DE4F2D2139B20B  : public RuntimeObject
{
	// System.Int32 Dummiesman.OBJObjectBuilder/ObjLoopHash::vertexIndex
	int32_t ___vertexIndex_0;
	// System.Int32 Dummiesman.OBJObjectBuilder/ObjLoopHash::normalIndex
	int32_t ___normalIndex_1;
	// System.Int32 Dummiesman.OBJObjectBuilder/ObjLoopHash::uvIndex
	int32_t ___uvIndex_2;
};

// System.Collections.Generic.KeyValuePair`2<System.Object,System.Object>
struct KeyValuePair_2_tFC32D2507216293851350D29B64D79F950B55230 
{
	// TKey System.Collections.Generic.KeyValuePair`2::key
	RuntimeObject* ___key_0;
	// TValue System.Collections.Generic.KeyValuePair`2::value
	RuntimeObject* ___value_1;
};

// System.Collections.Generic.KeyValuePair`2<System.String,System.Collections.Generic.List`1<System.Int32>>
struct KeyValuePair_2_tAB3B085BB59FEFAE0C5C3A1A32259012890DC6B0 
{
	// TKey System.Collections.Generic.KeyValuePair`2::key
	String_t* ___key_0;
	// TValue System.Collections.Generic.KeyValuePair`2::value
	List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73* ___value_1;
};

// System.Collections.Generic.KeyValuePair`2<System.String,Dummiesman.OBJObjectBuilder>
struct KeyValuePair_2_tD060C533C995F5D1C9F62591EE692E11381464AF 
{
	// TKey System.Collections.Generic.KeyValuePair`2::key
	String_t* ___key_0;
	// TValue System.Collections.Generic.KeyValuePair`2::value
	OBJObjectBuilder_t0FF6F614A40C0709678B6A0F9111F43397565F13* ___value_1;
};

// B83.Image.BMP.BMPFileHeader
struct BMPFileHeader_t8BB1B4DE759798D79066DF23BBBDE48E1051D50C 
{
	// System.UInt16 B83.Image.BMP.BMPFileHeader::magic
	uint16_t ___magic_0;
	// System.UInt32 B83.Image.BMP.BMPFileHeader::filesize
	uint32_t ___filesize_1;
	// System.UInt32 B83.Image.BMP.BMPFileHeader::reserved
	uint32_t ___reserved_2;
	// System.UInt32 B83.Image.BMP.BMPFileHeader::offset
	uint32_t ___offset_3;
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

// UnityEngine.Color
struct Color_tD001788D726C3A7F1379BEED0260B9591F440C1F 
{
	// System.Single UnityEngine.Color::r
	float ___r_0;
	// System.Single UnityEngine.Color::g
	float ___g_1;
	// System.Single UnityEngine.Color::b
	float ___b_2;
	// System.Single UnityEngine.Color::a
	float ___a_3;
};

// UnityEngine.Color32
struct Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B 
{
	union
	{
		#pragma pack(push, tp, 1)
		struct
		{
			// System.Int32 UnityEngine.Color32::rgba
			int32_t ___rgba_0;
		};
		#pragma pack(pop, tp)
		struct
		{
			int32_t ___rgba_0_forAlignmentOnly;
		};
		#pragma pack(push, tp, 1)
		struct
		{
			// System.Byte UnityEngine.Color32::r
			uint8_t ___r_1;
		};
		#pragma pack(pop, tp)
		struct
		{
			uint8_t ___r_1_forAlignmentOnly;
		};
		#pragma pack(push, tp, 1)
		struct
		{
			char ___g_2_OffsetPadding[1];
			// System.Byte UnityEngine.Color32::g
			uint8_t ___g_2;
		};
		#pragma pack(pop, tp)
		struct
		{
			char ___g_2_OffsetPadding_forAlignmentOnly[1];
			uint8_t ___g_2_forAlignmentOnly;
		};
		#pragma pack(push, tp, 1)
		struct
		{
			char ___b_3_OffsetPadding[2];
			// System.Byte UnityEngine.Color32::b
			uint8_t ___b_3;
		};
		#pragma pack(pop, tp)
		struct
		{
			char ___b_3_OffsetPadding_forAlignmentOnly[2];
			uint8_t ___b_3_forAlignmentOnly;
		};
		#pragma pack(push, tp, 1)
		struct
		{
			char ___a_4_OffsetPadding[3];
			// System.Byte UnityEngine.Color32::a
			uint8_t ___a_4;
		};
		#pragma pack(pop, tp)
		struct
		{
			char ___a_4_OffsetPadding_forAlignmentOnly[3];
			uint8_t ___a_4_forAlignmentOnly;
		};
	};
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

// System.Single
struct Single_t4530F2FF86FCB0DC29F35385CA1BD21BE294761C 
{
	// System.Single System.Single::m_value
	float ___m_value_0;
};

// System.IO.Stream
struct Stream_tF844051B786E8F7F4244DBD218D74E8617B9A2DE  : public MarshalByRefObject_t8C2F4C5854177FD60439EB1FCCFC1B3CFAFE8DCE
{
	// System.IO.Stream/ReadWriteTask System.IO.Stream::_activeReadWriteTask
	ReadWriteTask_t0821BF49EE38596C7734E86E1A6A39D769BE2C05* ____activeReadWriteTask_3;
	// System.Threading.SemaphoreSlim System.IO.Stream::_asyncActiveSemaphore
	SemaphoreSlim_t0D5CB5685D9BFA5BF95CEC6E7395490F933E8DB2* ____asyncActiveSemaphore_4;
};

struct Stream_tF844051B786E8F7F4244DBD218D74E8617B9A2DE_StaticFields
{
	// System.IO.Stream System.IO.Stream::Null
	Stream_tF844051B786E8F7F4244DBD218D74E8617B9A2DE* ___Null_1;
};

// System.IO.TextReader
struct TextReader_tB8D43017CB6BE1633E5A86D64E7757366507C1F7  : public MarshalByRefObject_t8C2F4C5854177FD60439EB1FCCFC1B3CFAFE8DCE
{
};

struct TextReader_tB8D43017CB6BE1633E5A86D64E7757366507C1F7_StaticFields
{
	// System.IO.TextReader System.IO.TextReader::Null
	TextReader_tB8D43017CB6BE1633E5A86D64E7757366507C1F7* ___Null_1;
};

// System.UInt16
struct UInt16_tF4C148C876015C212FD72652D0B6ED8CC247A455 
{
	// System.UInt16 System.UInt16::m_value
	uint16_t ___m_value_0;
};

// System.UInt32
struct UInt32_t1833D51FFA667B18A5AA4B8D34DE284F8495D29B 
{
	// System.UInt32 System.UInt32::m_value
	uint32_t ___m_value_0;
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

// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=10
struct __StaticArrayInitTypeSizeU3D10_tC38CF142534A070C2B94C80666D4D49680A1F92A 
{
	union
	{
		struct
		{
			union
			{
			};
		};
		uint8_t __StaticArrayInitTypeSizeU3D10_tC38CF142534A070C2B94C80666D4D49680A1F92A__padding[10];
	};
};

// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=12
struct __StaticArrayInitTypeSizeU3D12_t1BDD2193C3F925556BCD5FF35C0AC52DDB0CAB8F 
{
	union
	{
		struct
		{
			union
			{
			};
		};
		uint8_t __StaticArrayInitTypeSizeU3D12_t1BDD2193C3F925556BCD5FF35C0AC52DDB0CAB8F__padding[12];
	};
};

// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=120
struct __StaticArrayInitTypeSizeU3D120_tCE5F35B252DE449EDE2BA38EFA855ABFBF94EF89 
{
	union
	{
		struct
		{
			union
			{
			};
		};
		uint8_t __StaticArrayInitTypeSizeU3D120_tCE5F35B252DE449EDE2BA38EFA855ABFBF94EF89__padding[120];
	};
};

// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=128
struct __StaticArrayInitTypeSizeU3D128_tF4DC60A802E7EAF26084A16B33B2CDCC817796AB 
{
	union
	{
		struct
		{
			union
			{
			};
		};
		uint8_t __StaticArrayInitTypeSizeU3D128_tF4DC60A802E7EAF26084A16B33B2CDCC817796AB__padding[128];
	};
};

// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=14
struct __StaticArrayInitTypeSizeU3D14_t30159EAE60219F77407D6232992236950162008F 
{
	union
	{
		struct
		{
			union
			{
			};
		};
		uint8_t __StaticArrayInitTypeSizeU3D14_t30159EAE60219F77407D6232992236950162008F__padding[14];
	};
};

// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=16
struct __StaticArrayInitTypeSizeU3D16_tFB2D94E174C3DFBC336BBEE6AD92E07462831A23 
{
	union
	{
		struct
		{
			union
			{
			};
		};
		uint8_t __StaticArrayInitTypeSizeU3D16_tFB2D94E174C3DFBC336BBEE6AD92E07462831A23__padding[16];
	};
};

// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=16384
struct __StaticArrayInitTypeSizeU3D16384_t3CBE045B60B9A3E7FCAAFAAD7A579CE1EFA08152 
{
	union
	{
		struct
		{
			union
			{
			};
		};
		uint8_t __StaticArrayInitTypeSizeU3D16384_t3CBE045B60B9A3E7FCAAFAAD7A579CE1EFA08152__padding[16384];
	};
};

// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=2050
struct __StaticArrayInitTypeSizeU3D2050_t5C2606237362DCFBB0E0A62C67E1C5D0867AFF07 
{
	union
	{
		struct
		{
			union
			{
			};
		};
		uint8_t __StaticArrayInitTypeSizeU3D2050_t5C2606237362DCFBB0E0A62C67E1C5D0867AFF07__padding[2050];
	};
};

// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=214
struct __StaticArrayInitTypeSizeU3D214_tA0BC45EEBF354853CFEFD4472302A369830B9720 
{
	union
	{
		struct
		{
			union
			{
			};
		};
		uint8_t __StaticArrayInitTypeSizeU3D214_tA0BC45EEBF354853CFEFD4472302A369830B9720__padding[214];
	};
};

// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=24
struct __StaticArrayInitTypeSizeU3D24_t3464DA68B6CCAB9A0A43F94B3DB9AA7E7FDDB19A 
{
	union
	{
		struct
		{
			union
			{
			};
		};
		uint8_t __StaticArrayInitTypeSizeU3D24_t3464DA68B6CCAB9A0A43F94B3DB9AA7E7FDDB19A__padding[24];
	};
};

// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=256
struct __StaticArrayInitTypeSizeU3D256_tD03A67F7FF737E6BC9D67A9F479BD26FCEAD3898 
{
	union
	{
		struct
		{
			union
			{
			};
		};
		uint8_t __StaticArrayInitTypeSizeU3D256_tD03A67F7FF737E6BC9D67A9F479BD26FCEAD3898__padding[256];
	};
};

// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=257
struct __StaticArrayInitTypeSizeU3D257_tAF5BECF4D73BF6717CEB281F32CE475A5F445779 
{
	union
	{
		struct
		{
			union
			{
			};
		};
		uint8_t __StaticArrayInitTypeSizeU3D257_tAF5BECF4D73BF6717CEB281F32CE475A5F445779__padding[257];
	};
};

// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=32
struct __StaticArrayInitTypeSizeU3D32_tC3894D25C1E879699FE1C9BAB1BBF2787B405069 
{
	union
	{
		struct
		{
			union
			{
			};
		};
		uint8_t __StaticArrayInitTypeSizeU3D32_tC3894D25C1E879699FE1C9BAB1BBF2787B405069__padding[32];
	};
};

// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=36
struct __StaticArrayInitTypeSizeU3D36_tE3135E025C70F21BBD65107243EE57F8AA699792 
{
	union
	{
		struct
		{
			union
			{
			};
		};
		uint8_t __StaticArrayInitTypeSizeU3D36_tE3135E025C70F21BBD65107243EE57F8AA699792__padding[36];
	};
};

// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=384
struct __StaticArrayInitTypeSizeU3D384_t94536A2B71065D5F9943A339559B84C091F88329 
{
	union
	{
		struct
		{
			union
			{
			};
		};
		uint8_t __StaticArrayInitTypeSizeU3D384_t94536A2B71065D5F9943A339559B84C091F88329__padding[384];
	};
};

// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=40
struct __StaticArrayInitTypeSizeU3D40_t68A41E1D2BAA1C55857C26F7E0C26D1CFDB100B3 
{
	union
	{
		struct
		{
			union
			{
			};
		};
		uint8_t __StaticArrayInitTypeSizeU3D40_t68A41E1D2BAA1C55857C26F7E0C26D1CFDB100B3__padding[40];
	};
};

// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=48
struct __StaticArrayInitTypeSizeU3D48_tB184AFC7E0116F4B6DAFA18B66C9B248A3A9F2FE 
{
	union
	{
		struct
		{
			union
			{
			};
		};
		uint8_t __StaticArrayInitTypeSizeU3D48_tB184AFC7E0116F4B6DAFA18B66C9B248A3A9F2FE__padding[48];
	};
};

// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=64
struct __StaticArrayInitTypeSizeU3D64_tC5DCC92F71FF4937EDBB6F52C59AD832172ABE88 
{
	union
	{
		struct
		{
			union
			{
			};
		};
		uint8_t __StaticArrayInitTypeSizeU3D64_tC5DCC92F71FF4937EDBB6F52C59AD832172ABE88__padding[64];
	};
};

// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=74
struct __StaticArrayInitTypeSizeU3D74_tEDCCC24B8F7A9A15B3EFE9A218CE90D39EA38FE5 
{
	union
	{
		struct
		{
			union
			{
			};
		};
		uint8_t __StaticArrayInitTypeSizeU3D74_tEDCCC24B8F7A9A15B3EFE9A218CE90D39EA38FE5__padding[74];
	};
};

// System.Collections.Generic.Dictionary`2/Enumerator<System.Object,System.Object>
struct Enumerator_tEA93FE2B778D098F590CA168BEFC4CD85D73A6B9 
{
	// System.Collections.Generic.Dictionary`2<TKey,TValue> System.Collections.Generic.Dictionary`2/Enumerator::_dictionary
	Dictionary_2_t14FE4A752A83D53771C584E4C8D14E01F2AFD7BA* ____dictionary_0;
	// System.Int32 System.Collections.Generic.Dictionary`2/Enumerator::_version
	int32_t ____version_1;
	// System.Int32 System.Collections.Generic.Dictionary`2/Enumerator::_index
	int32_t ____index_2;
	// System.Collections.Generic.KeyValuePair`2<TKey,TValue> System.Collections.Generic.Dictionary`2/Enumerator::_current
	KeyValuePair_2_tFC32D2507216293851350D29B64D79F950B55230 ____current_3;
	// System.Int32 System.Collections.Generic.Dictionary`2/Enumerator::_getEnumeratorRetType
	int32_t ____getEnumeratorRetType_4;
};

// System.Collections.Generic.Dictionary`2/Enumerator<System.String,System.Collections.Generic.List`1<System.Int32>>
struct Enumerator_t2B62C6EA9375CE714A32E123DFDDDC13C21DDDB2 
{
	// System.Collections.Generic.Dictionary`2<TKey,TValue> System.Collections.Generic.Dictionary`2/Enumerator::_dictionary
	Dictionary_2_t6FFAD029BB474A5257D9A441504B633831AF5341* ____dictionary_0;
	// System.Int32 System.Collections.Generic.Dictionary`2/Enumerator::_version
	int32_t ____version_1;
	// System.Int32 System.Collections.Generic.Dictionary`2/Enumerator::_index
	int32_t ____index_2;
	// System.Collections.Generic.KeyValuePair`2<TKey,TValue> System.Collections.Generic.Dictionary`2/Enumerator::_current
	KeyValuePair_2_tAB3B085BB59FEFAE0C5C3A1A32259012890DC6B0 ____current_3;
	// System.Int32 System.Collections.Generic.Dictionary`2/Enumerator::_getEnumeratorRetType
	int32_t ____getEnumeratorRetType_4;
};

// System.Collections.Generic.Dictionary`2/Enumerator<System.String,Dummiesman.OBJObjectBuilder>
struct Enumerator_t0AE679B39DC9D7D9CE2CF6CCA330D549A945687A 
{
	// System.Collections.Generic.Dictionary`2<TKey,TValue> System.Collections.Generic.Dictionary`2/Enumerator::_dictionary
	Dictionary_2_tC5A5AFCB8FF4726846814FB45FC66F49C9B0F82A* ____dictionary_0;
	// System.Int32 System.Collections.Generic.Dictionary`2/Enumerator::_version
	int32_t ____version_1;
	// System.Int32 System.Collections.Generic.Dictionary`2/Enumerator::_index
	int32_t ____index_2;
	// System.Collections.Generic.KeyValuePair`2<TKey,TValue> System.Collections.Generic.Dictionary`2/Enumerator::_current
	KeyValuePair_2_tD060C533C995F5D1C9F62591EE692E11381464AF ____current_3;
	// System.Int32 System.Collections.Generic.Dictionary`2/Enumerator::_getEnumeratorRetType
	int32_t ____getEnumeratorRetType_4;
};

// <PrivateImplementationDetails>
struct U3CPrivateImplementationDetailsU3E_t0F5473E849A5A5185A9F4C5246F0C32816C49FCA  : public RuntimeObject
{
};

struct U3CPrivateImplementationDetailsU3E_t0F5473E849A5A5185A9F4C5246F0C32816C49FCA_StaticFields
{
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=40 <PrivateImplementationDetails>::03CF7905FDEE4C11CA2A90A3C39B120DD93DEF58D1205FD0F07B2BD91B2DFBBF
	__StaticArrayInitTypeSizeU3D40_t68A41E1D2BAA1C55857C26F7E0C26D1CFDB100B3 ___03CF7905FDEE4C11CA2A90A3C39B120DD93DEF58D1205FD0F07B2BD91B2DFBBF_0;
	// System.Int32 <PrivateImplementationDetails>::054EDEC1D0211F624FED0CBCA9D4F9400B0E491C43742AF2C5B0ABEBF0C990D8
	int32_t ___054EDEC1D0211F624FED0CBCA9D4F9400B0E491C43742AF2C5B0ABEBF0C990D8_1;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=32 <PrivateImplementationDetails>::095A9D450315002DE7AAFD28044328804C6DAC5840FE059F18861D1176174F61
	__StaticArrayInitTypeSizeU3D32_tC3894D25C1E879699FE1C9BAB1BBF2787B405069 ___095A9D450315002DE7AAFD28044328804C6DAC5840FE059F18861D1176174F61_2;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=128 <PrivateImplementationDetails>::09CD1578BB59E1ED3968B2043278174F0EB74ECAAB3B400EA048CBDAB9A80328
	__StaticArrayInitTypeSizeU3D128_tF4DC60A802E7EAF26084A16B33B2CDCC817796AB ___09CD1578BB59E1ED3968B2043278174F0EB74ECAAB3B400EA048CBDAB9A80328_3;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=12 <PrivateImplementationDetails>::09F8F19AE4F6686695B52208BC1D7689570500139032729087DF7C19C1276882
	__StaticArrayInitTypeSizeU3D12_t1BDD2193C3F925556BCD5FF35C0AC52DDB0CAB8F ___09F8F19AE4F6686695B52208BC1D7689570500139032729087DF7C19C1276882_4;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=36 <PrivateImplementationDetails>::0A7F6BE226E45BC057E859A463C0493C45165DB38DE6D5829AD523F4032EF4AC
	__StaticArrayInitTypeSizeU3D36_tE3135E025C70F21BBD65107243EE57F8AA699792 ___0A7F6BE226E45BC057E859A463C0493C45165DB38DE6D5829AD523F4032EF4AC_5;
	// System.Int32 <PrivateImplementationDetails>::0C7A4B86F63AAA39591ECDE5920606C2842EC3E2D5E46E5C6ADD06B39970E1B0
	int32_t ___0C7A4B86F63AAA39591ECDE5920606C2842EC3E2D5E46E5C6ADD06B39970E1B0_6;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=16 <PrivateImplementationDetails>::10BF4C8838CECF8714FA05478B46E57FA966E25F17FE8631BAE9B1B811184C92
	__StaticArrayInitTypeSizeU3D16_tFB2D94E174C3DFBC336BBEE6AD92E07462831A23 ___10BF4C8838CECF8714FA05478B46E57FA966E25F17FE8631BAE9B1B811184C92_7;
	// System.Int32 <PrivateImplementationDetails>::129E4EF86EBBA27AC5B76601133C4BE0CDE532004F87EAC8A675B5A3C78A3F86
	int32_t ___129E4EF86EBBA27AC5B76601133C4BE0CDE532004F87EAC8A675B5A3C78A3F86_8;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=256 <PrivateImplementationDetails>::14A5D850C255623F9472E3C650ABCE0C78D32F0276B315B3A276A0462D97A1AC
	__StaticArrayInitTypeSizeU3D256_tD03A67F7FF737E6BC9D67A9F479BD26FCEAD3898 ___14A5D850C255623F9472E3C650ABCE0C78D32F0276B315B3A276A0462D97A1AC_9;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=36 <PrivateImplementationDetails>::18935745A0E5C808241985DCB7B12A1539E5272178763AAB75796D5907530E8A
	__StaticArrayInitTypeSizeU3D36_tE3135E025C70F21BBD65107243EE57F8AA699792 ___18935745A0E5C808241985DCB7B12A1539E5272178763AAB75796D5907530E8A_10;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=32 <PrivateImplementationDetails>::1A3B988F817C07EB8F85B6485591C5572DAF0E52EAEDBBE5209C25DD545A0042
	__StaticArrayInitTypeSizeU3D32_tC3894D25C1E879699FE1C9BAB1BBF2787B405069 ___1A3B988F817C07EB8F85B6485591C5572DAF0E52EAEDBBE5209C25DD545A0042_11;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=120 <PrivateImplementationDetails>::20EA78DB5FDC2182FBD7539924FA8FF898A4ACC90091A2B35D7ED86F06D1775E
	__StaticArrayInitTypeSizeU3D120_tCE5F35B252DE449EDE2BA38EFA855ABFBF94EF89 ___20EA78DB5FDC2182FBD7539924FA8FF898A4ACC90091A2B35D7ED86F06D1775E_12;
	// System.Int32 <PrivateImplementationDetails>::2889A26B55B9C65A5414326CCD926847368D3452473D58C419330E6E7C60426B
	int32_t ___2889A26B55B9C65A5414326CCD926847368D3452473D58C419330E6E7C60426B_13;
	// System.Int32 <PrivateImplementationDetails>::2A90B38C10DB78F2B9DB53A50FBC1CB76E7017C0A3D62D6B73A85634E4C1F763
	int32_t ___2A90B38C10DB78F2B9DB53A50FBC1CB76E7017C0A3D62D6B73A85634E4C1F763_14;
	// System.Int64 <PrivateImplementationDetails>::2E45BBA1F4F067232A152D3BF3A2B0A5DCCF02B692920012F562D6F181EAB3C2
	int64_t ___2E45BBA1F4F067232A152D3BF3A2B0A5DCCF02B692920012F562D6F181EAB3C2_15;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=12 <PrivateImplementationDetails>::2F843C85A507A47D89C54183B1CF0565B30CA692AECF9C542911CAFF22ADD3FE
	__StaticArrayInitTypeSizeU3D12_t1BDD2193C3F925556BCD5FF35C0AC52DDB0CAB8F ___2F843C85A507A47D89C54183B1CF0565B30CA692AECF9C542911CAFF22ADD3FE_16;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=12 <PrivateImplementationDetails>::30EF3CC6972F22E6E25A1CB588B0775D59B0B59034FD0994ACB761E68FF1314C
	__StaticArrayInitTypeSizeU3D12_t1BDD2193C3F925556BCD5FF35C0AC52DDB0CAB8F ___30EF3CC6972F22E6E25A1CB588B0775D59B0B59034FD0994ACB761E68FF1314C_17;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=12 <PrivateImplementationDetails>::3A1F5039FE4FE7AA320EB289E3454BAC09E9E65A2F8F02F9A540D67426B7B712
	__StaticArrayInitTypeSizeU3D12_t1BDD2193C3F925556BCD5FF35C0AC52DDB0CAB8F ___3A1F5039FE4FE7AA320EB289E3454BAC09E9E65A2F8F02F9A540D67426B7B712_18;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=12 <PrivateImplementationDetails>::3B27BD6D8A39DE11C04FE84D4E0780A156CA12D0C483EA9B26E4A21E779ECC3F
	__StaticArrayInitTypeSizeU3D12_t1BDD2193C3F925556BCD5FF35C0AC52DDB0CAB8F ___3B27BD6D8A39DE11C04FE84D4E0780A156CA12D0C483EA9B26E4A21E779ECC3F_19;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=32 <PrivateImplementationDetails>::3D65DD412986BD40A45848D54B45A1A55A2A45CEEB292CE6050347EB4A9D8DCF
	__StaticArrayInitTypeSizeU3D32_tC3894D25C1E879699FE1C9BAB1BBF2787B405069 ___3D65DD412986BD40A45848D54B45A1A55A2A45CEEB292CE6050347EB4A9D8DCF_20;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=384 <PrivateImplementationDetails>::45CA1B7B619B33961C03C82243B8BAF59FC50C49B4D7EEFC94B76EDBD417A5C8
	__StaticArrayInitTypeSizeU3D384_t94536A2B71065D5F9943A339559B84C091F88329 ___45CA1B7B619B33961C03C82243B8BAF59FC50C49B4D7EEFC94B76EDBD417A5C8_21;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=64 <PrivateImplementationDetails>::472CDA75BD2E1FD566C08BA902BA68FA2CA421A7F54FA9F268AF85ABDA5C739E
	__StaticArrayInitTypeSizeU3D64_tC5DCC92F71FF4937EDBB6F52C59AD832172ABE88 ___472CDA75BD2E1FD566C08BA902BA68FA2CA421A7F54FA9F268AF85ABDA5C739E_22;
	// System.Int32 <PrivateImplementationDetails>::49D8ECD062F20E786B4C73E459BDC26B638FD11DC280178E45529230C696F2C7
	int32_t ___49D8ECD062F20E786B4C73E459BDC26B638FD11DC280178E45529230C696F2C7_23;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=14 <PrivateImplementationDetails>::4B1A2854E01983483E1F90EEC9DEAA81010509BCADE93A26ED2E0E559BA71D9C
	__StaticArrayInitTypeSizeU3D14_t30159EAE60219F77407D6232992236950162008F ___4B1A2854E01983483E1F90EEC9DEAA81010509BCADE93A26ED2E0E559BA71D9C_24;
	// System.Int32 <PrivateImplementationDetails>::51CE9465D1AE0E1B95AE9A5B99F454F11051B298734AC67F5C146F65CC814F69
	int32_t ___51CE9465D1AE0E1B95AE9A5B99F454F11051B298734AC67F5C146F65CC814F69_25;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=64 <PrivateImplementationDetails>::532A0DCC2BD0E0C874ED7B05AEE0FE7D27F52B130FE1B0A8EEF85EBBC446DED8
	__StaticArrayInitTypeSizeU3D64_tC5DCC92F71FF4937EDBB6F52C59AD832172ABE88 ___532A0DCC2BD0E0C874ED7B05AEE0FE7D27F52B130FE1B0A8EEF85EBBC446DED8_26;
	// System.Int32 <PrivateImplementationDetails>::597D0F603637224716AD03F1CEAF44EAF81929FB1D67D1C1C632CADA98769A6E
	int32_t ___597D0F603637224716AD03F1CEAF44EAF81929FB1D67D1C1C632CADA98769A6E_27;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=48 <PrivateImplementationDetails>::5AC2B6BC7879F1446D8F76E4AAAED53829BFDBF0E967AA94C67EDFC83930C736
	__StaticArrayInitTypeSizeU3D48_tB184AFC7E0116F4B6DAFA18B66C9B248A3A9F2FE ___5AC2B6BC7879F1446D8F76E4AAAED53829BFDBF0E967AA94C67EDFC83930C736_28;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=24 <PrivateImplementationDetails>::5C3B004B00D6EA48FF44F1396FCFC1C4DDC24091171D3D81116AFF6B5551FC2C
	__StaticArrayInitTypeSizeU3D24_t3464DA68B6CCAB9A0A43F94B3DB9AA7E7FDDB19A ___5C3B004B00D6EA48FF44F1396FCFC1C4DDC24091171D3D81116AFF6B5551FC2C_29;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=12 <PrivateImplementationDetails>::61EDD21418DC115314E4DB5AE449374D1214EDE2DD3A77AD48210A82B4F03B58
	__StaticArrayInitTypeSizeU3D12_t1BDD2193C3F925556BCD5FF35C0AC52DDB0CAB8F ___61EDD21418DC115314E4DB5AE449374D1214EDE2DD3A77AD48210A82B4F03B58_30;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=12 <PrivateImplementationDetails>::62AA93C1087C9B4792B1F2E98CACB22731E7827E06FF82A64F2FA5E5D35112C7
	__StaticArrayInitTypeSizeU3D12_t1BDD2193C3F925556BCD5FF35C0AC52DDB0CAB8F ___62AA93C1087C9B4792B1F2E98CACB22731E7827E06FF82A64F2FA5E5D35112C7_31;
	// System.Int32 <PrivateImplementationDetails>::6CA4156D6B41EED4C48CE454BE33F3B89418995F34FDFBEB8658A977B7467C24
	int32_t ___6CA4156D6B41EED4C48CE454BE33F3B89418995F34FDFBEB8658A977B7467C24_32;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=12 <PrivateImplementationDetails>::6F727F206C445CE5061B703EE0C9C37316B0A269965C5ED83E1006BC65D5E996
	__StaticArrayInitTypeSizeU3D12_t1BDD2193C3F925556BCD5FF35C0AC52DDB0CAB8F ___6F727F206C445CE5061B703EE0C9C37316B0A269965C5ED83E1006BC65D5E996_33;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=16 <PrivateImplementationDetails>::6F7DE6FFEF22D7177D64B3460EB6AE3D3A483C4FF2A9C0B52FB8C33C430445FA
	__StaticArrayInitTypeSizeU3D16_tFB2D94E174C3DFBC336BBEE6AD92E07462831A23 ___6F7DE6FFEF22D7177D64B3460EB6AE3D3A483C4FF2A9C0B52FB8C33C430445FA_34;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=257 <PrivateImplementationDetails>::749321F5C391C354CEAE093365B71196DEBA24F60D6C46F682CCFE14073D78D7
	__StaticArrayInitTypeSizeU3D257_tAF5BECF4D73BF6717CEB281F32CE475A5F445779 ___749321F5C391C354CEAE093365B71196DEBA24F60D6C46F682CCFE14073D78D7_35;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=120 <PrivateImplementationDetails>::75EA28057661C660B31B759102C9F9B760A5B22C91B4E7CC2F1CD68D0B7B3EF3
	__StaticArrayInitTypeSizeU3D120_tCE5F35B252DE449EDE2BA38EFA855ABFBF94EF89 ___75EA28057661C660B31B759102C9F9B760A5B22C91B4E7CC2F1CD68D0B7B3EF3_36;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=12 <PrivateImplementationDetails>::80966C822BAB62E92372AAD590FF6B54543E8FDB9FF0DF3D45023D036B5BD8E0
	__StaticArrayInitTypeSizeU3D12_t1BDD2193C3F925556BCD5FF35C0AC52DDB0CAB8F ___80966C822BAB62E92372AAD590FF6B54543E8FDB9FF0DF3D45023D036B5BD8E0_37;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=32 <PrivateImplementationDetails>::812D129F84529E26BF6401CC6DDE7EB6CA970D966B832A31E06C3E549C839778
	__StaticArrayInitTypeSizeU3D32_tC3894D25C1E879699FE1C9BAB1BBF2787B405069 ___812D129F84529E26BF6401CC6DDE7EB6CA970D966B832A31E06C3E549C839778_38;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=14 <PrivateImplementationDetails>::852D8EBBC6D39167E72A0A86CD303077FB2D83B42999B4B4B4601EF3ECC50D7D
	__StaticArrayInitTypeSizeU3D14_t30159EAE60219F77407D6232992236950162008F ___852D8EBBC6D39167E72A0A86CD303077FB2D83B42999B4B4B4601EF3ECC50D7D_39;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=16 <PrivateImplementationDetails>::8620657F173D4EAD1B992C99083824AC6ECB22875961C3FE4F521E06BB4A53A9
	__StaticArrayInitTypeSizeU3D16_tFB2D94E174C3DFBC336BBEE6AD92E07462831A23 ___8620657F173D4EAD1B992C99083824AC6ECB22875961C3FE4F521E06BB4A53A9_40;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=24 <PrivateImplementationDetails>::872350FF614C0A738468827E3DBE64BCBA8623B7414014CCFF659CDF0DB091B9
	__StaticArrayInitTypeSizeU3D24_t3464DA68B6CCAB9A0A43F94B3DB9AA7E7FDDB19A ___872350FF614C0A738468827E3DBE64BCBA8623B7414014CCFF659CDF0DB091B9_41;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=14 <PrivateImplementationDetails>::8756DCCCC92D254F0BFE2690A34E57CBB9EAE9486EB2B87CDEE7977988D61B9E
	__StaticArrayInitTypeSizeU3D14_t30159EAE60219F77407D6232992236950162008F ___8756DCCCC92D254F0BFE2690A34E57CBB9EAE9486EB2B87CDEE7977988D61B9E_42;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=64 <PrivateImplementationDetails>::89DE86688FED01A790E7AB97F63B3EF84DEC14CC5339CC51EF680BECDB013C66
	__StaticArrayInitTypeSizeU3D64_tC5DCC92F71FF4937EDBB6F52C59AD832172ABE88 ___89DE86688FED01A790E7AB97F63B3EF84DEC14CC5339CC51EF680BECDB013C66_43;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=256 <PrivateImplementationDetails>::8A50D74416A40D05C215F74A491BAA8F5FC8F8FCE8EAFAD99742A85AF6A2488F
	__StaticArrayInitTypeSizeU3D256_tD03A67F7FF737E6BC9D67A9F479BD26FCEAD3898 ___8A50D74416A40D05C215F74A491BAA8F5FC8F8FCE8EAFAD99742A85AF6A2488F_44;
	// System.Int32 <PrivateImplementationDetails>::8BBFAA93EF8678E6BC74D03E52F8BB303116D22985927FB12C103684A80E5A72
	int32_t ___8BBFAA93EF8678E6BC74D03E52F8BB303116D22985927FB12C103684A80E5A72_45;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=12 <PrivateImplementationDetails>::901308A0BD9AC3E446AAC4E8F012552A1372B9EC9B13A774270BECB05E09F9A2
	__StaticArrayInitTypeSizeU3D12_t1BDD2193C3F925556BCD5FF35C0AC52DDB0CAB8F ___901308A0BD9AC3E446AAC4E8F012552A1372B9EC9B13A774270BECB05E09F9A2_46;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=74 <PrivateImplementationDetails>::92B97479A2EE0E7003A9FD8CB02F3CC1ED47200ED6A34B5E3EDB65A67BBA636A
	__StaticArrayInitTypeSizeU3D74_tEDCCC24B8F7A9A15B3EFE9A218CE90D39EA38FE5 ___92B97479A2EE0E7003A9FD8CB02F3CC1ED47200ED6A34B5E3EDB65A67BBA636A_47;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=12 <PrivateImplementationDetails>::92E56D720BB3B289074A8152C7795E32EF5F6C5046049DA9A8974CBE29B3D566
	__StaticArrayInitTypeSizeU3D12_t1BDD2193C3F925556BCD5FF35C0AC52DDB0CAB8F ___92E56D720BB3B289074A8152C7795E32EF5F6C5046049DA9A8974CBE29B3D566_48;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=384 <PrivateImplementationDetails>::98417C6F4C8EE55F2586EAD71B0C67586F64BA0B3018FD8EE69E5861AC8C07CA
	__StaticArrayInitTypeSizeU3D384_t94536A2B71065D5F9943A339559B84C091F88329 ___98417C6F4C8EE55F2586EAD71B0C67586F64BA0B3018FD8EE69E5861AC8C07CA_49;
	// System.Int32 <PrivateImplementationDetails>::9BA205084F02B702FEB494F1CC86A57CAE797846EDEE9C7E6555C3E9CF5A2EC0
	int32_t ___9BA205084F02B702FEB494F1CC86A57CAE797846EDEE9C7E6555C3E9CF5A2EC0_50;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=12 <PrivateImplementationDetails>::A2530DAF622F87DE2D42F119110D20DC454CBA63BC80F2B5E811D497CD947C95
	__StaticArrayInitTypeSizeU3D12_t1BDD2193C3F925556BCD5FF35C0AC52DDB0CAB8F ___A2530DAF622F87DE2D42F119110D20DC454CBA63BC80F2B5E811D497CD947C95_51;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=16 <PrivateImplementationDetails>::A288454E60C2209481C9FD7643E41C4F5EFD63947FA5EBE5DFD47BC2C80D4775
	__StaticArrayInitTypeSizeU3D16_tFB2D94E174C3DFBC336BBEE6AD92E07462831A23 ___A288454E60C2209481C9FD7643E41C4F5EFD63947FA5EBE5DFD47BC2C80D4775_52;
	// System.Int32 <PrivateImplementationDetails>::A34F4880D6C80B3C37D8BAD428E4FA2CA15383C987AFA665D7B9FC985D47E4FE
	int32_t ___A34F4880D6C80B3C37D8BAD428E4FA2CA15383C987AFA665D7B9FC985D47E4FE_53;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=36 <PrivateImplementationDetails>::AF454758626603CF5CDA2E48A96D967CA4FB4E9A8A5D83E2BBA168DDAC9896CE
	__StaticArrayInitTypeSizeU3D36_tE3135E025C70F21BBD65107243EE57F8AA699792 ___AF454758626603CF5CDA2E48A96D967CA4FB4E9A8A5D83E2BBA168DDAC9896CE_54;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=128 <PrivateImplementationDetails>::B128878A4FAF48A10681B904435430150BC932B420B87A5B4CF42AE2DA5A0E63
	__StaticArrayInitTypeSizeU3D128_tF4DC60A802E7EAF26084A16B33B2CDCC817796AB ___B128878A4FAF48A10681B904435430150BC932B420B87A5B4CF42AE2DA5A0E63_55;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=40 <PrivateImplementationDetails>::B1ACFDB968C71D0EA3949F9FF636E61061C58EA117D471DDD014B14D48775E42
	__StaticArrayInitTypeSizeU3D40_t68A41E1D2BAA1C55857C26F7E0C26D1CFDB100B3 ___B1ACFDB968C71D0EA3949F9FF636E61061C58EA117D471DDD014B14D48775E42_56;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=16384 <PrivateImplementationDetails>::B40C47B014CA8650C539760FD4C519CABCE6F091628566CA0DD22318BB2C5B7A
	__StaticArrayInitTypeSizeU3D16384_t3CBE045B60B9A3E7FCAAFAAD7A579CE1EFA08152 ___B40C47B014CA8650C539760FD4C519CABCE6F091628566CA0DD22318BB2C5B7A_57;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=14 <PrivateImplementationDetails>::B4FA15405BA78D775EFDF91924221EED63A679C312C0C6F41D44D14D026C7617
	__StaticArrayInitTypeSizeU3D14_t30159EAE60219F77407D6232992236950162008F ___B4FA15405BA78D775EFDF91924221EED63A679C312C0C6F41D44D14D026C7617_58;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=2050 <PrivateImplementationDetails>::B95A5540F30E1F0F40975157595D078BB07D3242D2C856A1C679E533E2F26233
	__StaticArrayInitTypeSizeU3D2050_t5C2606237362DCFBB0E0A62C67E1C5D0867AFF07 ___B95A5540F30E1F0F40975157595D078BB07D3242D2C856A1C679E533E2F26233_59;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=12 <PrivateImplementationDetails>::BFB77DF404144AA48C11658EFAA15C9D8D685B104AAE1B3946B4981977DFEC35
	__StaticArrayInitTypeSizeU3D12_t1BDD2193C3F925556BCD5FF35C0AC52DDB0CAB8F ___BFB77DF404144AA48C11658EFAA15C9D8D685B104AAE1B3946B4981977DFEC35_60;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=16 <PrivateImplementationDetails>::C34767842609A436E3764557AD4700BEA4F38EC7AA441F063FDF359BB970DE26
	__StaticArrayInitTypeSizeU3D16_tFB2D94E174C3DFBC336BBEE6AD92E07462831A23 ___C34767842609A436E3764557AD4700BEA4F38EC7AA441F063FDF359BB970DE26_61;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=32 <PrivateImplementationDetails>::C5023AA02EA3EA77A20CA705C152C51E4A224664DB082A4DA559F16300990AE1
	__StaticArrayInitTypeSizeU3D32_tC3894D25C1E879699FE1C9BAB1BBF2787B405069 ___C5023AA02EA3EA77A20CA705C152C51E4A224664DB082A4DA559F16300990AE1_62;
	// System.Int32 <PrivateImplementationDetails>::C6283261C2EC4CFF43504533FFCBDF109223B703231B6F21F00EFBCCF34F3BDC
	int32_t ___C6283261C2EC4CFF43504533FFCBDF109223B703231B6F21F00EFBCCF34F3BDC_63;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=14 <PrivateImplementationDetails>::C9562BD4E6F50B3B87B513FAE757AA9422B4EE8EF8BBDDA53912334B5CBEDD8A
	__StaticArrayInitTypeSizeU3D14_t30159EAE60219F77407D6232992236950162008F ___C9562BD4E6F50B3B87B513FAE757AA9422B4EE8EF8BBDDA53912334B5CBEDD8A_64;
	// System.Int32 <PrivateImplementationDetails>::CFC1EB6EA0A7E4174084656F7CB67C49E077C5AD166AB143482C40A38D2FAA8C
	int32_t ___CFC1EB6EA0A7E4174084656F7CB67C49E077C5AD166AB143482C40A38D2FAA8C_65;
	// System.Int32 <PrivateImplementationDetails>::D063A6B90B21B1C04DBD6FE6DF662B7480699EA03570C01202286FD54ECD6EC7
	int32_t ___D063A6B90B21B1C04DBD6FE6DF662B7480699EA03570C01202286FD54ECD6EC7_66;
	// System.Int32 <PrivateImplementationDetails>::D2402049D7A0ECE89A7C0615473BE40870ECBFE7455FABEA539F7BC4B4546630
	int32_t ___D2402049D7A0ECE89A7C0615473BE40870ECBFE7455FABEA539F7BC4B4546630_67;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=12 <PrivateImplementationDetails>::D46DE47222F09831C8963DDB0D5B4F9B776CBF08A5FDA2665F97F96D58B5D42F
	__StaticArrayInitTypeSizeU3D12_t1BDD2193C3F925556BCD5FF35C0AC52DDB0CAB8F ___D46DE47222F09831C8963DDB0D5B4F9B776CBF08A5FDA2665F97F96D58B5D42F_68;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=214 <PrivateImplementationDetails>::D4F6FD9D6FE2D229A3F142BD40731C6E2A2829321D4D1A6E83FA267FF0C93871
	__StaticArrayInitTypeSizeU3D214_tA0BC45EEBF354853CFEFD4472302A369830B9720 ___D4F6FD9D6FE2D229A3F142BD40731C6E2A2829321D4D1A6E83FA267FF0C93871_69;
	// System.Int32 <PrivateImplementationDetails>::D5C0C73AC6810346BEBD9DEED631FF70636D7AAD35ECC5EA1ABA96F74AE74438
	int32_t ___D5C0C73AC6810346BEBD9DEED631FF70636D7AAD35ECC5EA1ABA96F74AE74438_70;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=16 <PrivateImplementationDetails>::D62BDDD8F4552AC1CB5D438ECFF4BDAFE692BD6CA3A6F22C2A0B31E3317E21BF
	__StaticArrayInitTypeSizeU3D16_tFB2D94E174C3DFBC336BBEE6AD92E07462831A23 ___D62BDDD8F4552AC1CB5D438ECFF4BDAFE692BD6CA3A6F22C2A0B31E3317E21BF_71;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=12 <PrivateImplementationDetails>::DCB3AE8B4E240899FD78AFDF6953114D9C41F0DEF383CE66FD5F08D780BF49AC
	__StaticArrayInitTypeSizeU3D12_t1BDD2193C3F925556BCD5FF35C0AC52DDB0CAB8F ___DCB3AE8B4E240899FD78AFDF6953114D9C41F0DEF383CE66FD5F08D780BF49AC_72;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=36 <PrivateImplementationDetails>::DE8D535657084891A80274FEA9215644D368507399919C540B8F8DBB446D5C13
	__StaticArrayInitTypeSizeU3D36_tE3135E025C70F21BBD65107243EE57F8AA699792 ___DE8D535657084891A80274FEA9215644D368507399919C540B8F8DBB446D5C13_73;
	// System.Int64 <PrivateImplementationDetails>::E03B4F45A73476DBCB7DE3C87FB32686A9734C7927512C6D28CADFBC43FB7CB1
	int64_t ___E03B4F45A73476DBCB7DE3C87FB32686A9734C7927512C6D28CADFBC43FB7CB1_74;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=12 <PrivateImplementationDetails>::E231A6C33BC86B31C888CA206BB63857BDB36B514FD1ACEC191FF16B3A767686
	__StaticArrayInitTypeSizeU3D12_t1BDD2193C3F925556BCD5FF35C0AC52DDB0CAB8F ___E231A6C33BC86B31C888CA206BB63857BDB36B514FD1ACEC191FF16B3A767686_75;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=32 <PrivateImplementationDetails>::E330F08827A23FD75F944E80FC79BB3105376EF000EDD7661F130AFCA78E40EB
	__StaticArrayInitTypeSizeU3D32_tC3894D25C1E879699FE1C9BAB1BBF2787B405069 ___E330F08827A23FD75F944E80FC79BB3105376EF000EDD7661F130AFCA78E40EB_76;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=12 <PrivateImplementationDetails>::E4D1E7C1289DDEA0065A384F89D81A8367F2F0F6B074F33473054DDE66EDE64F
	__StaticArrayInitTypeSizeU3D12_t1BDD2193C3F925556BCD5FF35C0AC52DDB0CAB8F ___E4D1E7C1289DDEA0065A384F89D81A8367F2F0F6B074F33473054DDE66EDE64F_77;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=12 <PrivateImplementationDetails>::E95F4B18528AC1E65C74E7AF6F2E8A0AE623B6060C345514CE1A61E136A3171B
	__StaticArrayInitTypeSizeU3D12_t1BDD2193C3F925556BCD5FF35C0AC52DDB0CAB8F ___E95F4B18528AC1E65C74E7AF6F2E8A0AE623B6060C345514CE1A61E136A3171B_78;
	// System.Int32 <PrivateImplementationDetails>::ED33180EC1C44E70A18B1DFC8590E02AE11EC7A1F7138D9B85895D98F3013053
	int32_t ___ED33180EC1C44E70A18B1DFC8590E02AE11EC7A1F7138D9B85895D98F3013053_79;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=32 <PrivateImplementationDetails>::ED4C8A838138367C567856147DE8041567C5AB553B53ABE4B1DBB8C55EDED3A4
	__StaticArrayInitTypeSizeU3D32_tC3894D25C1E879699FE1C9BAB1BBF2787B405069 ___ED4C8A838138367C567856147DE8041567C5AB553B53ABE4B1DBB8C55EDED3A4_80;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=48 <PrivateImplementationDetails>::EDDC8A28063FE39642CFC776F53B3E679850725058A1EFA3F62218A484EC44FC
	__StaticArrayInitTypeSizeU3D48_tB184AFC7E0116F4B6DAFA18B66C9B248A3A9F2FE ___EDDC8A28063FE39642CFC776F53B3E679850725058A1EFA3F62218A484EC44FC_81;
	// System.Int32 <PrivateImplementationDetails>::F3FAB17097A37AE7D5030890DD5ACF8672BB74546B27CE77472B1932463EA494
	int32_t ___F3FAB17097A37AE7D5030890DD5ACF8672BB74546B27CE77472B1932463EA494_82;
	// System.Int32 <PrivateImplementationDetails>::F5423D8E7661BCB3AB31A7531BCDA8C596DBDB690D7FB72B796295E32E354FA0
	int32_t ___F5423D8E7661BCB3AB31A7531BCDA8C596DBDB690D7FB72B796295E32E354FA0_83;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=48 <PrivateImplementationDetails>::F54D339673DB584EE7E7A51ED59EEBE8C554C4FD97FE9B3DA60E362585BB5397
	__StaticArrayInitTypeSizeU3D48_tB184AFC7E0116F4B6DAFA18B66C9B248A3A9F2FE ___F54D339673DB584EE7E7A51ED59EEBE8C554C4FD97FE9B3DA60E362585BB5397_84;
	// System.Int32 <PrivateImplementationDetails>::F896C3A5F9841B6E1F0A22BD35A6A1BC5EFB28AAA23B66301EC8098CE57CF99A
	int32_t ___F896C3A5F9841B6E1F0A22BD35A6A1BC5EFB28AAA23B66301EC8098CE57CF99A_85;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=10 <PrivateImplementationDetails>::F99BF1AC26ADEC05E2595B21DE4B4AFF77D9B9F172CDAC89EE68F3748716A843
	__StaticArrayInitTypeSizeU3D10_tC38CF142534A070C2B94C80666D4D49680A1F92A ___F99BF1AC26ADEC05E2595B21DE4B4AFF77D9B9F172CDAC89EE68F3748716A843_86;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=14 <PrivateImplementationDetails>::FA062C282A3CC394427966BD4E0534F48B4061C789B9C270B07218813C5A83F0
	__StaticArrayInitTypeSizeU3D14_t30159EAE60219F77407D6232992236950162008F ___FA062C282A3CC394427966BD4E0534F48B4061C789B9C270B07218813C5A83F0_87;
	// System.Int32 <PrivateImplementationDetails>::FAC3E42E8E929A470D80D35FD9EF74C830CD2065D1D277A328F960955025E615
	int32_t ___FAC3E42E8E929A470D80D35FD9EF74C830CD2065D1D277A328F960955025E615_88;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=12 <PrivateImplementationDetails>::FD6708B133D262C90E7929F523F4E4DFA2FD656F387FFE8DA01ED15C2DC79F1B
	__StaticArrayInitTypeSizeU3D12_t1BDD2193C3F925556BCD5FF35C0AC52DDB0CAB8F ___FD6708B133D262C90E7929F523F4E4DFA2FD656F387FFE8DA01ED15C2DC79F1B_89;
};

// B83.Image.BMP.BMPComressionMode
struct BMPComressionMode_t9E5045935338BAEB588113A1A26E979C7CDF7A7A 
{
	// System.Int32 B83.Image.BMP.BMPComressionMode::value__
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

// System.IO.FileAccess
struct FileAccess_t3992FF4CCC61971B804DD291F06F696C3CF33C30 
{
	// System.Int32 System.IO.FileAccess::value__
	int32_t ___value___2;
};

// System.IO.FileMode
struct FileMode_t111B48D5347628AEFCBF9A0EC2833827A302ECBA 
{
	// System.Int32 System.IO.FileMode::value__
	int32_t ___value___2;
};

// UnityEngine.Rendering.IndexFormat
struct IndexFormat_tE699D38323B3B0887DF054EAFF0CF035DF28E2BB 
{
	// System.Int32 UnityEngine.Rendering.IndexFormat::value__
	int32_t ___value___2;
};

// System.IO.MemoryStream
struct MemoryStream_tAAED1B42172E3390584E4194308AB878E786AAC2  : public Stream_tF844051B786E8F7F4244DBD218D74E8617B9A2DE
{
	// System.Byte[] System.IO.MemoryStream::_buffer
	ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* ____buffer_5;
	// System.Int32 System.IO.MemoryStream::_origin
	int32_t ____origin_6;
	// System.Int32 System.IO.MemoryStream::_position
	int32_t ____position_7;
	// System.Int32 System.IO.MemoryStream::_length
	int32_t ____length_8;
	// System.Int32 System.IO.MemoryStream::_capacity
	int32_t ____capacity_9;
	// System.Boolean System.IO.MemoryStream::_expandable
	bool ____expandable_10;
	// System.Boolean System.IO.MemoryStream::_writable
	bool ____writable_11;
	// System.Boolean System.IO.MemoryStream::_exposable
	bool ____exposable_12;
	// System.Boolean System.IO.MemoryStream::_isOpen
	bool ____isOpen_13;
	// System.Threading.Tasks.Task`1<System.Int32> System.IO.MemoryStream::_lastReadTask
	Task_1_t4C228DE57804012969575431CFF12D57C875552D* ____lastReadTask_14;
};

// UnityEngine.Object
struct Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C  : public RuntimeObject
{
	// System.IntPtr UnityEngine.Object::m_CachedPtr
	intptr_t ___m_CachedPtr_0;
};

struct Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_StaticFields
{
	// System.Int32 UnityEngine.Object::OffsetOfInstanceIDInCPlusPlusObject
	int32_t ___OffsetOfInstanceIDInCPlusPlusObject_1;
};
// Native definition for P/Invoke marshalling of UnityEngine.Object
struct Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_marshaled_pinvoke
{
	intptr_t ___m_CachedPtr_0;
};
// Native definition for COM marshalling of UnityEngine.Object
struct Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_marshaled_com
{
	intptr_t ___m_CachedPtr_0;
};

// System.IO.SeekOrigin
struct SeekOrigin_t7EB9AD0EDF26368A40F48FA2098F02160B1E8000 
{
	// System.Int32 System.IO.SeekOrigin::value__
	int32_t ___value___2;
};

// Dummiesman.SplitMode
struct SplitMode_t588CF0468031D41042F1374E894051D99CFB894D 
{
	// System.Int32 Dummiesman.SplitMode::value__
	int32_t ___value___2;
};

// System.IO.StreamReader
struct StreamReader_t81027449065C1B0C339DB46241D8001A6F61130B  : public TextReader_tB8D43017CB6BE1633E5A86D64E7757366507C1F7
{
	// System.IO.Stream System.IO.StreamReader::_stream
	Stream_tF844051B786E8F7F4244DBD218D74E8617B9A2DE* ____stream_3;
	// System.Text.Encoding System.IO.StreamReader::_encoding
	Encoding_t65CDEF28CF20A7B8C92E85A4E808920C2465F095* ____encoding_4;
	// System.Text.Decoder System.IO.StreamReader::_decoder
	Decoder_tE16E789E38B25DD304004FC630EA8B21000ECBBC* ____decoder_5;
	// System.Byte[] System.IO.StreamReader::_byteBuffer
	ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* ____byteBuffer_6;
	// System.Char[] System.IO.StreamReader::_charBuffer
	CharU5BU5D_t799905CF001DD5F13F7DBB310181FC4D8B7D0AAB* ____charBuffer_7;
	// System.Int32 System.IO.StreamReader::_charPos
	int32_t ____charPos_8;
	// System.Int32 System.IO.StreamReader::_charLen
	int32_t ____charLen_9;
	// System.Int32 System.IO.StreamReader::_byteLen
	int32_t ____byteLen_10;
	// System.Int32 System.IO.StreamReader::_bytePos
	int32_t ____bytePos_11;
	// System.Int32 System.IO.StreamReader::_maxCharsPerBuffer
	int32_t ____maxCharsPerBuffer_12;
	// System.Boolean System.IO.StreamReader::_detectEncoding
	bool ____detectEncoding_13;
	// System.Boolean System.IO.StreamReader::_checkPreamble
	bool ____checkPreamble_14;
	// System.Boolean System.IO.StreamReader::_isBlocked
	bool ____isBlocked_15;
	// System.Boolean System.IO.StreamReader::_closable
	bool ____closable_16;
	// System.Threading.Tasks.Task System.IO.StreamReader::_asyncReadTask
	Task_t751C4CC3ECD055BABA8A0B6A5DFBB4283DCA8572* ____asyncReadTask_17;
};

struct StreamReader_t81027449065C1B0C339DB46241D8001A6F61130B_StaticFields
{
	// System.IO.StreamReader System.IO.StreamReader::Null
	StreamReader_t81027449065C1B0C339DB46241D8001A6F61130B* ___Null_2;
};

// UnityEngine.TextureFormat
struct TextureFormat_t87A73E4A3850D3410DC211676FC14B94226C1C1D 
{
	// System.Int32 UnityEngine.TextureFormat::value__
	int32_t ___value___2;
};

// Dummiesman.ImageLoader/TextureFormat
struct TextureFormat_t3AC1244CD74D5D0F2DC3CADFF763F5F73689F114 
{
	// System.Int32 Dummiesman.ImageLoader/TextureFormat::value__
	int32_t ___value___2;
};

// Interop/Sys/FileStatusFlags
struct FileStatusFlags_tB53E2B9A54305CDCEA49884DEEDB8C62C8ACC9C9 
{
	// System.Int32 Interop/Sys/FileStatusFlags::value__
	int32_t ___value___2;
};

// B83.Image.BMP.BitmapInfoHeader
struct BitmapInfoHeader_tFB63C5954E9795BECDA9F843F451C426D1982C4E 
{
	// System.UInt32 B83.Image.BMP.BitmapInfoHeader::size
	uint32_t ___size_0;
	// System.Int32 B83.Image.BMP.BitmapInfoHeader::width
	int32_t ___width_1;
	// System.Int32 B83.Image.BMP.BitmapInfoHeader::height
	int32_t ___height_2;
	// System.UInt16 B83.Image.BMP.BitmapInfoHeader::nColorPlanes
	uint16_t ___nColorPlanes_3;
	// System.UInt16 B83.Image.BMP.BitmapInfoHeader::nBitsPerPixel
	uint16_t ___nBitsPerPixel_4;
	// B83.Image.BMP.BMPComressionMode B83.Image.BMP.BitmapInfoHeader::compressionMethod
	int32_t ___compressionMethod_5;
	// System.UInt32 B83.Image.BMP.BitmapInfoHeader::rawImageSize
	uint32_t ___rawImageSize_6;
	// System.Int32 B83.Image.BMP.BitmapInfoHeader::xPPM
	int32_t ___xPPM_7;
	// System.Int32 B83.Image.BMP.BitmapInfoHeader::yPPM
	int32_t ___yPPM_8;
	// System.UInt32 B83.Image.BMP.BitmapInfoHeader::nPaletteColors
	uint32_t ___nPaletteColors_9;
	// System.UInt32 B83.Image.BMP.BitmapInfoHeader::nImportantColors
	uint32_t ___nImportantColors_10;
};

// UnityEngine.Component
struct Component_t39FBE53E5EFCF4409111FB22C15FF73717632EC3  : public Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C
{
};

// System.IO.FileStream
struct FileStream_t07C7222EE10B75F352B89B76E60820160FF10AD8  : public Stream_tF844051B786E8F7F4244DBD218D74E8617B9A2DE
{
	// System.Byte[] System.IO.FileStream::buf
	ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* ___buf_7;
	// System.String System.IO.FileStream::name
	String_t* ___name_8;
	// Microsoft.Win32.SafeHandles.SafeFileHandle System.IO.FileStream::safeHandle
	SafeFileHandle_t033FA6AAAC65F4BB25F4CBA9A242A58C95CD406E* ___safeHandle_9;
	// System.Boolean System.IO.FileStream::isExposed
	bool ___isExposed_10;
	// System.Int64 System.IO.FileStream::append_startpos
	int64_t ___append_startpos_11;
	// System.IO.FileAccess System.IO.FileStream::access
	int32_t ___access_12;
	// System.Boolean System.IO.FileStream::owner
	bool ___owner_13;
	// System.Boolean System.IO.FileStream::async
	bool ___async_14;
	// System.Boolean System.IO.FileStream::canseek
	bool ___canseek_15;
	// System.Boolean System.IO.FileStream::anonymous
	bool ___anonymous_16;
	// System.Boolean System.IO.FileStream::buf_dirty
	bool ___buf_dirty_17;
	// System.Int32 System.IO.FileStream::buf_size
	int32_t ___buf_size_18;
	// System.Int32 System.IO.FileStream::buf_length
	int32_t ___buf_length_19;
	// System.Int32 System.IO.FileStream::buf_offset
	int32_t ___buf_offset_20;
	// System.Int64 System.IO.FileStream::buf_start
	int64_t ___buf_start_21;
};

struct FileStream_t07C7222EE10B75F352B89B76E60820160FF10AD8_StaticFields
{
	// System.Byte[] System.IO.FileStream::buf_recycle
	ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* ___buf_recycle_5;
	// System.Object System.IO.FileStream::buf_recycle_lock
	RuntimeObject* ___buf_recycle_lock_6;
};

// UnityEngine.GameObject
struct GameObject_t76FEDD663AB33C991A9C9A23129337651094216F  : public Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C
{
};

// UnityEngine.Material
struct Material_t18053F08F347D0DCA5E1140EC7EC4533DD8A14E3  : public Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C
{
};

// UnityEngine.Mesh
struct Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4  : public Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C
{
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

// Dummiesman.OBJLoader
struct OBJLoader_tB5927F8DB92B05302380425D21E9BCE654FD66BF  : public RuntimeObject
{
	// Dummiesman.SplitMode Dummiesman.OBJLoader::SplitMode
	int32_t ___SplitMode_0;
	// System.Collections.Generic.List`1<UnityEngine.Vector3> Dummiesman.OBJLoader::Vertices
	List_1_t77B94703E05C519A9010DD0614F757F974E1CD8B* ___Vertices_1;
	// System.Collections.Generic.List`1<UnityEngine.Vector3> Dummiesman.OBJLoader::Normals
	List_1_t77B94703E05C519A9010DD0614F757F974E1CD8B* ___Normals_2;
	// System.Collections.Generic.List`1<UnityEngine.Vector2> Dummiesman.OBJLoader::UVs
	List_1_t8F3790B7F8C471B3A1336522C7415FB0AC36D47B* ___UVs_3;
	// System.Collections.Generic.Dictionary`2<System.String,UnityEngine.Material> Dummiesman.OBJLoader::Materials
	Dictionary_2_t5B255487AF84FB5AB3382296BC4C30734ADE141F* ___Materials_4;
	// System.IO.FileInfo Dummiesman.OBJLoader::_objInfo
	FileInfo_t62782BBAFA832A78724E4CF2EE96548B8466AB1C* ____objInfo_5;
};

// UnityEngine.Shader
struct Shader_tADC867D36B7876EE22427FAA2CE485105F4EE692  : public Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C
{
};

// UnityEngine.Texture
struct Texture_t791CBB51219779964E0E8A2ED7C1AA5F92A4A700  : public Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C
{
};

struct Texture_t791CBB51219779964E0E8A2ED7C1AA5F92A4A700_StaticFields
{
	// System.Int32 UnityEngine.Texture::GenerateAllMips
	int32_t ___GenerateAllMips_4;
};

// Interop/Sys/FileStatus
struct FileStatus_tCB96EDE0D0F945F685B9BBED6DBF0731207458C2 
{
	// Interop/Sys/FileStatusFlags Interop/Sys/FileStatus::Flags
	int32_t ___Flags_0;
	// System.Int32 Interop/Sys/FileStatus::Mode
	int32_t ___Mode_1;
	// System.UInt32 Interop/Sys/FileStatus::Uid
	uint32_t ___Uid_2;
	// System.UInt32 Interop/Sys/FileStatus::Gid
	uint32_t ___Gid_3;
	// System.Int64 Interop/Sys/FileStatus::Size
	int64_t ___Size_4;
	// System.Int64 Interop/Sys/FileStatus::ATime
	int64_t ___ATime_5;
	// System.Int64 Interop/Sys/FileStatus::ATimeNsec
	int64_t ___ATimeNsec_6;
	// System.Int64 Interop/Sys/FileStatus::MTime
	int64_t ___MTime_7;
	// System.Int64 Interop/Sys/FileStatus::MTimeNsec
	int64_t ___MTimeNsec_8;
	// System.Int64 Interop/Sys/FileStatus::CTime
	int64_t ___CTime_9;
	// System.Int64 Interop/Sys/FileStatus::CTimeNsec
	int64_t ___CTimeNsec_10;
	// System.Int64 Interop/Sys/FileStatus::BirthTime
	int64_t ___BirthTime_11;
	// System.Int64 Interop/Sys/FileStatus::BirthTimeNsec
	int64_t ___BirthTimeNsec_12;
	// System.Int64 Interop/Sys/FileStatus::Dev
	int64_t ___Dev_13;
	// System.Int64 Interop/Sys/FileStatus::Ino
	int64_t ___Ino_14;
	// System.UInt32 Interop/Sys/FileStatus::UserFlags
	uint32_t ___UserFlags_15;
};

// System.Action`1<System.String>
struct Action_1_t3CB5D1A819C3ED3F99E9E39F890F18633253949A  : public MulticastDelegate_t
{
};

// B83.Image.BMP.BMPImage
struct BMPImage_tA6E059574F192A9BB574E7B260012D990055F05C  : public RuntimeObject
{
	// B83.Image.BMP.BMPFileHeader B83.Image.BMP.BMPImage::header
	BMPFileHeader_t8BB1B4DE759798D79066DF23BBBDE48E1051D50C ___header_0;
	// B83.Image.BMP.BitmapInfoHeader B83.Image.BMP.BMPImage::info
	BitmapInfoHeader_tFB63C5954E9795BECDA9F843F451C426D1982C4E ___info_1;
	// System.UInt32 B83.Image.BMP.BMPImage::rMask
	uint32_t ___rMask_2;
	// System.UInt32 B83.Image.BMP.BMPImage::gMask
	uint32_t ___gMask_3;
	// System.UInt32 B83.Image.BMP.BMPImage::bMask
	uint32_t ___bMask_4;
	// System.UInt32 B83.Image.BMP.BMPImage::aMask
	uint32_t ___aMask_5;
	// System.Collections.Generic.List`1<UnityEngine.Color32> B83.Image.BMP.BMPImage::palette
	List_1_t3517D52AE25CA3B19051E691E9C06ED03A3AB9B8* ___palette_6;
	// UnityEngine.Color32[] B83.Image.BMP.BMPImage::imageData
	Color32U5BU5D_t38116C3E91765C4C5726CE12C77FAD7F9F737259* ___imageData_7;
};

// System.IO.FileStatus
struct FileStatus_tABB5F252F1E597EC95E9041035DC424EF66712A5 
{
	// Interop/Sys/FileStatus System.IO.FileStatus::_fileStatus
	FileStatus_tCB96EDE0D0F945F685B9BBED6DBF0731207458C2 ____fileStatus_0;
	// System.Int32 System.IO.FileStatus::_fileStatusInitialized
	int32_t ____fileStatusInitialized_1;
	// System.Boolean System.IO.FileStatus::<InitiallyDirectory>k__BackingField
	bool ___U3CInitiallyDirectoryU3Ek__BackingField_2;
	// System.Boolean System.IO.FileStatus::_isDirectory
	bool ____isDirectory_3;
	// System.Boolean System.IO.FileStatus::_exists
	bool ____exists_4;
};
// Native definition for P/Invoke marshalling of System.IO.FileStatus
struct FileStatus_tABB5F252F1E597EC95E9041035DC424EF66712A5_marshaled_pinvoke
{
	FileStatus_tCB96EDE0D0F945F685B9BBED6DBF0731207458C2 ____fileStatus_0;
	int32_t ____fileStatusInitialized_1;
	int32_t ___U3CInitiallyDirectoryU3Ek__BackingField_2;
	int32_t ____isDirectory_3;
	int32_t ____exists_4;
};
// Native definition for COM marshalling of System.IO.FileStatus
struct FileStatus_tABB5F252F1E597EC95E9041035DC424EF66712A5_marshaled_com
{
	FileStatus_tCB96EDE0D0F945F685B9BBED6DBF0731207458C2 ____fileStatus_0;
	int32_t ____fileStatusInitialized_1;
	int32_t ___U3CInitiallyDirectoryU3Ek__BackingField_2;
	int32_t ____isDirectory_3;
	int32_t ____exists_4;
};

// UnityEngine.MeshFilter
struct MeshFilter_t6D1CE2473A1E45AC73013400585A1163BF66B2F5  : public Component_t39FBE53E5EFCF4409111FB22C15FF73717632EC3
{
};

// UnityEngine.Renderer
struct Renderer_t320575F223BCB177A982E5DDB5DB19FAA89E7FBF  : public Component_t39FBE53E5EFCF4409111FB22C15FF73717632EC3
{
};

// UnityEngine.Texture2D
struct Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4  : public Texture_t791CBB51219779964E0E8A2ED7C1AA5F92A4A700
{
};

// UnityEngine.Transform
struct Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1  : public Component_t39FBE53E5EFCF4409111FB22C15FF73717632EC3
{
};

// System.IO.FileSystemInfo
struct FileSystemInfo_tE3063B9229F46B05A5F6D018C8C4CA510104E8E9  : public MarshalByRefObject_t8C2F4C5854177FD60439EB1FCCFC1B3CFAFE8DCE
{
	// System.IO.FileStatus System.IO.FileSystemInfo::_fileStatus
	FileStatus_tABB5F252F1E597EC95E9041035DC424EF66712A5 ____fileStatus_1;
	// System.String System.IO.FileSystemInfo::FullPath
	String_t* ___FullPath_2;
	// System.String System.IO.FileSystemInfo::OriginalPath
	String_t* ___OriginalPath_3;
	// System.String System.IO.FileSystemInfo::_name
	String_t* ____name_4;
};

// UnityEngine.MeshRenderer
struct MeshRenderer_t4B7747212F0B88244BB7790C61AE124BFC15BAAE  : public Renderer_t320575F223BCB177A982E5DDB5DB19FAA89E7FBF
{
};

// System.IO.DirectoryInfo
struct DirectoryInfo_tEAEEC018EB49B4A71907FFEAFE935FAA8F9C1FE2  : public FileSystemInfo_tE3063B9229F46B05A5F6D018C8C4CA510104E8E9
{
};

// System.IO.FileInfo
struct FileInfo_t62782BBAFA832A78724E4CF2EE96548B8466AB1C  : public FileSystemInfo_tE3063B9229F46B05A5F6D018C8C4CA510104E8E9
{
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
// UnityEngine.Material[]
struct MaterialU5BU5D_t2B1D11C42DB07A4400C0535F92DBB87A2E346D3D  : public RuntimeArray
{
	ALIGN_FIELD (8) Material_t18053F08F347D0DCA5E1140EC7EC4533DD8A14E3* m_Items[1];

	inline Material_t18053F08F347D0DCA5E1140EC7EC4533DD8A14E3* GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline Material_t18053F08F347D0DCA5E1140EC7EC4533DD8A14E3** GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, Material_t18053F08F347D0DCA5E1140EC7EC4533DD8A14E3* value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
	inline Material_t18053F08F347D0DCA5E1140EC7EC4533DD8A14E3* GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline Material_t18053F08F347D0DCA5E1140EC7EC4533DD8A14E3** GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, Material_t18053F08F347D0DCA5E1140EC7EC4533DD8A14E3* value)
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
// UnityEngine.Color[]
struct ColorU5BU5D_t612261CF293F6FFC3D80AB52259FF0DC2B2CC389  : public RuntimeArray
{
	ALIGN_FIELD (8) Color_tD001788D726C3A7F1379BEED0260B9591F440C1F m_Items[1];

	inline Color_tD001788D726C3A7F1379BEED0260B9591F440C1F GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline Color_tD001788D726C3A7F1379BEED0260B9591F440C1F* GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, Color_tD001788D726C3A7F1379BEED0260B9591F440C1F value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
	}
	inline Color_tD001788D726C3A7F1379BEED0260B9591F440C1F GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline Color_tD001788D726C3A7F1379BEED0260B9591F440C1F* GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, Color_tD001788D726C3A7F1379BEED0260B9591F440C1F value)
	{
		m_Items[index] = value;
	}
};
// UnityEngine.Color32[]
struct Color32U5BU5D_t38116C3E91765C4C5726CE12C77FAD7F9F737259  : public RuntimeArray
{
	ALIGN_FIELD (8) Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B m_Items[1];

	inline Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B* GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
	}
	inline Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B* GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B value)
	{
		m_Items[index] = value;
	}
};
// UnityEngine.Vector3[]
struct Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C  : public RuntimeArray
{
	ALIGN_FIELD (8) Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 m_Items[1];

	inline Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2* GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
	}
	inline Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2* GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 value)
	{
		m_Items[index] = value;
	}
};
// UnityEngine.Vector2[]
struct Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA  : public RuntimeArray
{
	ALIGN_FIELD (8) Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 m_Items[1];

	inline Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7* GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
	}
	inline Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7* GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 value)
	{
		m_Items[index] = value;
	}
};


// System.Void System.Collections.Generic.Dictionary`2<System.Object,System.Object>::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Dictionary_2__ctor_m5B32FBC624618211EB461D59CFBB10E987FD1329_gshared (Dictionary_2_t14FE4A752A83D53771C584E4C8D14E01F2AFD7BA* __this, const RuntimeMethod* method) ;
// System.Void System.Collections.Generic.List`1<System.Int32>::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void List_1__ctor_m17F501B5A5C289ECE1B4F3D6EBF05DFA421433F8_gshared (List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73* __this, const RuntimeMethod* method) ;
// System.Void System.Action`1<System.Object>::.ctor(System.Object,System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Action_1__ctor_m2E1DFA67718FC1A0B6E5DFEB78831FFE9C059EB4_gshared (Action_1_t6F9EB113EB3F16226AEF811A2744F4111C116C87* __this, RuntimeObject* ___object0, intptr_t ___method1, const RuntimeMethod* method) ;
// System.Void System.Action`1<System.Object>::Invoke(T)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Action_1_Invoke_mF2422B2DD29F74CE66F791C3F68E288EC7C3DB9E_gshared (Action_1_t6F9EB113EB3F16226AEF811A2744F4111C116C87* __this, RuntimeObject* ___obj0, const RuntimeMethod* method) ;
// System.Void System.Collections.Generic.List`1<UnityEngine.Vector3>::Add(T)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void List_1_Add_m79E50C4F592B1703F4B76A8BE7B4855515460CA1_gshared_inline (List_1_t77B94703E05C519A9010DD0614F757F974E1CD8B* __this, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___item0, const RuntimeMethod* method) ;
// System.Void System.Collections.Generic.List`1<UnityEngine.Vector2>::Add(T)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void List_1_Add_mB5FDF069171C4CB1778BFAC3B9015A22EA7DFBCD_gshared_inline (List_1_t8F3790B7F8C471B3A1336522C7415FB0AC36D47B* __this, Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 ___item0, const RuntimeMethod* method) ;
// System.Int32 System.Collections.Generic.List`1<UnityEngine.Vector3>::get_Count()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR int32_t List_1_get_Count_m46EEFFA770BE665EA0CB3A5332E941DA4B3C1D37_gshared_inline (List_1_t77B94703E05C519A9010DD0614F757F974E1CD8B* __this, const RuntimeMethod* method) ;
// System.Int32 System.Collections.Generic.List`1<UnityEngine.Vector2>::get_Count()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR int32_t List_1_get_Count_mF1C0C56457C655BDFFC6EE5B46FAD8BAEC1F588B_gshared_inline (List_1_t8F3790B7F8C471B3A1336522C7415FB0AC36D47B* __this, const RuntimeMethod* method) ;
// System.Void System.Collections.Generic.List`1<System.Int32>::Add(T)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void List_1_Add_m0248A96C5334E9A93E6994B7780478BCD994EA3D_gshared_inline (List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73* __this, int32_t ___item0, const RuntimeMethod* method) ;
// System.Void System.Collections.Generic.List`1<System.Int32>::Clear()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void List_1_Clear_mF6795DE5F49C1D0B91D6A0955F448B22970D67A9_gshared_inline (List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73* __this, const RuntimeMethod* method) ;
// System.Collections.Generic.Dictionary`2/Enumerator<TKey,TValue> System.Collections.Generic.Dictionary`2<System.Object,System.Object>::GetEnumerator()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Enumerator_tEA93FE2B778D098F590CA168BEFC4CD85D73A6B9 Dictionary_2_GetEnumerator_m52AB12790B0B9B46B1DFB1F861C9DBEAB07C1FDA_gshared (Dictionary_2_t14FE4A752A83D53771C584E4C8D14E01F2AFD7BA* __this, const RuntimeMethod* method) ;
// System.Void System.Collections.Generic.Dictionary`2/Enumerator<System.Object,System.Object>::Dispose()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Enumerator_Dispose_mEA5E01B81EB943B7003D87CEC1B6040524F0402C_gshared (Enumerator_tEA93FE2B778D098F590CA168BEFC4CD85D73A6B9* __this, const RuntimeMethod* method) ;
// System.Collections.Generic.KeyValuePair`2<TKey,TValue> System.Collections.Generic.Dictionary`2/Enumerator<System.Object,System.Object>::get_Current()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR KeyValuePair_2_tFC32D2507216293851350D29B64D79F950B55230 Enumerator_get_Current_mE3475384B761E1C7971D3639BD09117FE8363422_gshared_inline (Enumerator_tEA93FE2B778D098F590CA168BEFC4CD85D73A6B9* __this, const RuntimeMethod* method) ;
// TValue System.Collections.Generic.KeyValuePair`2<System.Object,System.Object>::get_Value()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR RuntimeObject* KeyValuePair_2_get_Value_mC6BD8075F9C9DDEF7B4D731E5C38EC19103988E7_gshared_inline (KeyValuePair_2_tFC32D2507216293851350D29B64D79F950B55230* __this, const RuntimeMethod* method) ;
// System.Boolean System.Collections.Generic.Dictionary`2/Enumerator<System.Object,System.Object>::MoveNext()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Enumerator_MoveNext_mCD4950A75FFADD54AF354D48C6C0DB0B5A22A5F4_gshared (Enumerator_tEA93FE2B778D098F590CA168BEFC4CD85D73A6B9* __this, const RuntimeMethod* method) ;
// System.Void System.Collections.Generic.List`1<UnityEngine.Vector3>::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void List_1__ctor_mC54E2BCBE43279A96FC082F5CDE2D76388BD8F9C_gshared (List_1_t77B94703E05C519A9010DD0614F757F974E1CD8B* __this, const RuntimeMethod* method) ;
// System.Void System.Collections.Generic.List`1<UnityEngine.Vector2>::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void List_1__ctor_m88C4BD8AC607DB3585552068F4DC437406358D5F_gshared (List_1_t8F3790B7F8C471B3A1336522C7415FB0AC36D47B* __this, const RuntimeMethod* method) ;
// System.Boolean System.Collections.Generic.Dictionary`2<System.Object,System.Object>::TryGetValue(TKey,TValue&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Dictionary_2_TryGetValue_mD15380A4ED7CDEE99EA45881577D26BA9CE1B849_gshared (Dictionary_2_t14FE4A752A83D53771C584E4C8D14E01F2AFD7BA* __this, RuntimeObject* ___key0, RuntimeObject** ___value1, const RuntimeMethod* method) ;
// System.Void System.Collections.Generic.Dictionary`2<System.Object,System.Object>::set_Item(TKey,TValue)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Dictionary_2_set_Item_m1A840355E8EDAECEA9D0C6F5E51B248FAA449CBD_gshared (Dictionary_2_t14FE4A752A83D53771C584E4C8D14E01F2AFD7BA* __this, RuntimeObject* ___key0, RuntimeObject* ___value1, const RuntimeMethod* method) ;
// T UnityEngine.GameObject::AddComponent<System.Object>()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* GameObject_AddComponent_TisRuntimeObject_m69B93700FACCF372F5753371C6E8FB780800B824_gshared (GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* __this, const RuntimeMethod* method) ;
// System.Int32 System.Collections.Generic.Dictionary`2<System.Object,System.Object>::get_Count()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t Dictionary_2_get_Count_m4DDA9442C238A443489115E22B026AD366851549_gshared (Dictionary_2_t14FE4A752A83D53771C584E4C8D14E01F2AFD7BA* __this, const RuntimeMethod* method) ;
// TKey System.Collections.Generic.KeyValuePair`2<System.Object,System.Object>::get_Key()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR RuntimeObject* KeyValuePair_2_get_Key_mBD8EA7557C27E6956F2AF29DA3F7499B2F51A282_gshared_inline (KeyValuePair_2_tFC32D2507216293851350D29B64D79F950B55230* __this, const RuntimeMethod* method) ;
// System.Int32 System.Collections.Generic.List`1<System.Int32>::get_Count()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR int32_t List_1_get_Count_mF590592E32D421DE2C6E2F0D5C2F62FB14CCEFDF_gshared_inline (List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73* __this, const RuntimeMethod* method) ;
// T System.Collections.Generic.List`1<System.Int32>::get_Item(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t List_1_get_Item_mD99081BEFA1AB3526715F489192B0F7F596C183D_gshared (List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73* __this, int32_t ___index0, const RuntimeMethod* method) ;
// System.Boolean System.Collections.Generic.Dictionary`2<System.Object,System.Int32>::TryGetValue(TKey,TValue&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Dictionary_2_TryGetValue_m4B8EE45640C70BBFD6F3EFF1040983404C098342_gshared (Dictionary_2_t5C96F4B6841710A9013966F76224BAE01FB4B4D1* __this, RuntimeObject* ___key0, int32_t* ___value1, const RuntimeMethod* method) ;
// System.Void System.Collections.Generic.Dictionary`2<System.Object,System.Int32>::Add(TKey,TValue)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Dictionary_2_Add_m63897227AFA7035F1772315ABBBE7FD0A250E10C_gshared (Dictionary_2_t5C96F4B6841710A9013966F76224BAE01FB4B4D1* __this, RuntimeObject* ___key0, int32_t ___value1, const RuntimeMethod* method) ;
// T System.Collections.Generic.List`1<UnityEngine.Vector3>::get_Item(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 List_1_get_Item_m8F2E15FC96DA75186C51228128A0660709E4E810_gshared (List_1_t77B94703E05C519A9010DD0614F757F974E1CD8B* __this, int32_t ___index0, const RuntimeMethod* method) ;
// T System.Collections.Generic.List`1<UnityEngine.Vector2>::get_Item(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 List_1_get_Item_m1F8E226CAD72B83C5E75BB66B43025247806B543_gshared (List_1_t8F3790B7F8C471B3A1336522C7415FB0AC36D47B* __this, int32_t ___index0, const RuntimeMethod* method) ;
// System.Void System.Collections.Generic.List`1<System.Int32>::AddRange(System.Collections.Generic.IEnumerable`1<T>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void List_1_AddRange_m1A10E697703D67F6551D47C603FFE78E16CE4204_gshared (List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73* __this, RuntimeObject* ___collection0, const RuntimeMethod* method) ;
// System.Void System.Collections.Generic.Dictionary`2<System.Object,System.Int32>::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Dictionary_2__ctor_m517E7F9D104FEAE6646EABDDC9C852510E86077C_gshared (Dictionary_2_t5C96F4B6841710A9013966F76224BAE01FB4B4D1* __this, const RuntimeMethod* method) ;

// System.IO.DirectoryInfo System.IO.FileInfo::get_Directory()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR DirectoryInfo_tEAEEC018EB49B4A71907FFEAFE935FAA8F9C1FE2* FileInfo_get_Directory_m17FDB04561FFB59BF0EAF22E92A6A8BAD3572EE6 (FileInfo_t62782BBAFA832A78724E4CF2EE96548B8466AB1C* __this, const RuntimeMethod* method) ;
// System.String System.IO.Path::Combine(System.String,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* Path_Combine_m64754D4E08990CE1EBC41CDF197807EE4B115474 (String_t* ___path10, String_t* ___path21, const RuntimeMethod* method) ;
// System.Boolean System.IO.File::Exists(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool File_Exists_mD7E7A84A6B9E9A9BADBDA7C46AAE0624EF106D85 (String_t* ___path0, const RuntimeMethod* method) ;
// System.Void MTLLoader::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MTLLoader__ctor_m882454B2FF25BF9544AB016F3F922E549829465D (MTLLoader_t3B14F27942873DFDE45A9E33A2AD08A49EF1ABBA* __this, const RuntimeMethod* method) ;
// System.Collections.Generic.Dictionary`2<System.String,UnityEngine.Material> MTLLoader::Load(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Dictionary_2_t5B255487AF84FB5AB3382296BC4C30734ADE141F* MTLLoader_Load_m909F33EEC7F4D0C3891EC7F61B49B0C8ADD8E2E8 (MTLLoader_t3B14F27942873DFDE45A9E33A2AD08A49EF1ABBA* __this, String_t* ___path0, const RuntimeMethod* method) ;
// System.Void Dummiesman.OBJLoader/<>c__DisplayClass7_0::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CU3Ec__DisplayClass7_0__ctor_m8BCD1C1A2D807AAB9450E9565813690455C1B5D2 (U3CU3Ec__DisplayClass7_0_tB2FCD3BDD4423D7E34A7A4B5547E642A93881A72* __this, const RuntimeMethod* method) ;
// System.Void System.IO.StreamReader::.ctor(System.IO.Stream)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void StreamReader__ctor_mAFA827D6D825FEC2C29C73B65C2DD1AB9076DEC7 (StreamReader_t81027449065C1B0C339DB46241D8001A6F61130B* __this, Stream_tF844051B786E8F7F4244DBD218D74E8617B9A2DE* ___stream0, const RuntimeMethod* method) ;
// System.Void System.Collections.Generic.Dictionary`2<System.String,Dummiesman.OBJObjectBuilder>::.ctor()
inline void Dictionary_2__ctor_mB2E3E483638E602FE00B68DB9132FA5D5704D11F (Dictionary_2_tC5A5AFCB8FF4726846814FB45FC66F49C9B0F82A* __this, const RuntimeMethod* method)
{
	((  void (*) (Dictionary_2_tC5A5AFCB8FF4726846814FB45FC66F49C9B0F82A*, const RuntimeMethod*))Dictionary_2__ctor_m5B32FBC624618211EB461D59CFBB10E987FD1329_gshared)(__this, method);
}
// System.Void System.Collections.Generic.List`1<System.Int32>::.ctor()
inline void List_1__ctor_m17F501B5A5C289ECE1B4F3D6EBF05DFA421433F8 (List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73* __this, const RuntimeMethod* method)
{
	((  void (*) (List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73*, const RuntimeMethod*))List_1__ctor_m17F501B5A5C289ECE1B4F3D6EBF05DFA421433F8_gshared)(__this, method);
}
// System.Void System.Action`1<System.String>::.ctor(System.Object,System.IntPtr)
inline void Action_1__ctor_m9DC2953C55C4D7D4B7BEFE03D84DA1F9362D652C (Action_1_t3CB5D1A819C3ED3F99E9E39F890F18633253949A* __this, RuntimeObject* ___object0, intptr_t ___method1, const RuntimeMethod* method)
{
	((  void (*) (Action_1_t3CB5D1A819C3ED3F99E9E39F890F18633253949A*, RuntimeObject*, intptr_t, const RuntimeMethod*))Action_1__ctor_m2E1DFA67718FC1A0B6E5DFEB78831FFE9C059EB4_gshared)(__this, ___object0, ___method1, method);
}
// System.Void System.Action`1<System.String>::Invoke(T)
inline void Action_1_Invoke_m690438AAE38F9762172E3AE0A33D0B42ACD35790 (Action_1_t3CB5D1A819C3ED3F99E9E39F890F18633253949A* __this, String_t* ___obj0, const RuntimeMethod* method)
{
	((  void (*) (Action_1_t3CB5D1A819C3ED3F99E9E39F890F18633253949A*, String_t*, const RuntimeMethod*))Action_1_Invoke_mF2422B2DD29F74CE66F791C3F68E288EC7C3DB9E_gshared)(__this, ___obj0, method);
}
// System.Void Dummiesman.CharWordReader::.ctor(System.IO.StreamReader,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void CharWordReader__ctor_mC187F26A73B4C4C17AAE6E2CEC05C6BDABC46724 (CharWordReader_t975B8D03A4A3A2152789D6E1D57A51915D45B037* __this, StreamReader_t81027449065C1B0C339DB46241D8001A6F61130B* ___reader0, int32_t ___bufferSize1, const RuntimeMethod* method) ;
// System.Void Dummiesman.CharWordReader::SkipWhitespaces()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void CharWordReader_SkipWhitespaces_m756A369785A22720E078BC048AA7C17C70722FA9 (CharWordReader_t975B8D03A4A3A2152789D6E1D57A51915D45B037* __this, const RuntimeMethod* method) ;
// System.Void Dummiesman.CharWordReader::ReadUntilWhiteSpace()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void CharWordReader_ReadUntilWhiteSpace_m393DAE0E741589CB7A03D88179E6CBF333586C67 (CharWordReader_t975B8D03A4A3A2152789D6E1D57A51915D45B037* __this, const RuntimeMethod* method) ;
// System.Boolean Dummiesman.CharWordReader::Is(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool CharWordReader_Is_m3BECD455B5467165843C7AC55DC0C596515BE6DD (CharWordReader_t975B8D03A4A3A2152789D6E1D57A51915D45B037* __this, String_t* ___other0, const RuntimeMethod* method) ;
// System.Void Dummiesman.CharWordReader::SkipUntilNewLine()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void CharWordReader_SkipUntilNewLine_mC871D424BAF642A45B0CDB6A034CF09AC697A6DF (CharWordReader_t975B8D03A4A3A2152789D6E1D57A51915D45B037* __this, const RuntimeMethod* method) ;
// System.Void Dummiesman.CharWordReader::ReadUntilNewLine()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void CharWordReader_ReadUntilNewLine_mEDD63FA77CAB776D16A7C6E4FA10A7249790B07A (CharWordReader_t975B8D03A4A3A2152789D6E1D57A51915D45B037* __this, const RuntimeMethod* method) ;
// System.String Dummiesman.CharWordReader::GetString(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* CharWordReader_GetString_m3B839DB592A5992C2238FE41B683EB5EF02637C3 (CharWordReader_t975B8D03A4A3A2152789D6E1D57A51915D45B037* __this, int32_t ___startIndex0, const RuntimeMethod* method) ;
// System.Void Dummiesman.OBJLoader::LoadMaterialLibrary(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void OBJLoader_LoadMaterialLibrary_m8357F62C2EEFD070D141A171260A7247F60BE362 (OBJLoader_tB5927F8DB92B05302380425D21E9BCE654FD66BF* __this, String_t* ___mtlLibPath0, const RuntimeMethod* method) ;
// UnityEngine.Vector3 Dummiesman.CharWordReader::ReadVector()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 CharWordReader_ReadVector_m265198F266F731E96CE23C5C0D9037FE402273FF (CharWordReader_t975B8D03A4A3A2152789D6E1D57A51915D45B037* __this, const RuntimeMethod* method) ;
// System.Void System.Collections.Generic.List`1<UnityEngine.Vector3>::Add(T)
inline void List_1_Add_m79E50C4F592B1703F4B76A8BE7B4855515460CA1_inline (List_1_t77B94703E05C519A9010DD0614F757F974E1CD8B* __this, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___item0, const RuntimeMethod* method)
{
	((  void (*) (List_1_t77B94703E05C519A9010DD0614F757F974E1CD8B*, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2, const RuntimeMethod*))List_1_Add_m79E50C4F592B1703F4B76A8BE7B4855515460CA1_gshared_inline)(__this, ___item0, method);
}
// UnityEngine.Vector2 UnityEngine.Vector2::op_Implicit(UnityEngine.Vector3)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 Vector2_op_Implicit_m8F73B300CB4E6F9B4EB5FB6130363D76CEAA230B_inline (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___v0, const RuntimeMethod* method) ;
// System.Void System.Collections.Generic.List`1<UnityEngine.Vector2>::Add(T)
inline void List_1_Add_mB5FDF069171C4CB1778BFAC3B9015A22EA7DFBCD_inline (List_1_t8F3790B7F8C471B3A1336522C7415FB0AC36D47B* __this, Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 ___item0, const RuntimeMethod* method)
{
	((  void (*) (List_1_t8F3790B7F8C471B3A1336522C7415FB0AC36D47B*, Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7, const RuntimeMethod*))List_1_Add_mB5FDF069171C4CB1778BFAC3B9015A22EA7DFBCD_gshared_inline)(__this, ___item0, method);
}
// System.Void Dummiesman.CharWordReader::SkipWhitespaces(System.Boolean&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void CharWordReader_SkipWhitespaces_m55CA1F56FFFF49CE8E147CF45AA78D2B66920B5E (CharWordReader_t975B8D03A4A3A2152789D6E1D57A51915D45B037* __this, bool* ___newLinePassed0, const RuntimeMethod* method) ;
// System.Int32 Dummiesman.CharWordReader::ReadInt()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t CharWordReader_ReadInt_mCCB951F11A7FCB0C3522C67F4A74332DDE4DB1A0 (CharWordReader_t975B8D03A4A3A2152789D6E1D57A51915D45B037* __this, const RuntimeMethod* method) ;
// System.Void Dummiesman.CharWordReader::MoveNext()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void CharWordReader_MoveNext_m9E8BAD502F7F23337F0B4C3EC4E126C164539606 (CharWordReader_t975B8D03A4A3A2152789D6E1D57A51915D45B037* __this, const RuntimeMethod* method) ;
// System.Int32 System.Collections.Generic.List`1<UnityEngine.Vector3>::get_Count()
inline int32_t List_1_get_Count_m46EEFFA770BE665EA0CB3A5332E941DA4B3C1D37_inline (List_1_t77B94703E05C519A9010DD0614F757F974E1CD8B* __this, const RuntimeMethod* method)
{
	return ((  int32_t (*) (List_1_t77B94703E05C519A9010DD0614F757F974E1CD8B*, const RuntimeMethod*))List_1_get_Count_m46EEFFA770BE665EA0CB3A5332E941DA4B3C1D37_gshared_inline)(__this, method);
}
// System.Int32 System.Collections.Generic.List`1<UnityEngine.Vector2>::get_Count()
inline int32_t List_1_get_Count_mF1C0C56457C655BDFFC6EE5B46FAD8BAEC1F588B_inline (List_1_t8F3790B7F8C471B3A1336522C7415FB0AC36D47B* __this, const RuntimeMethod* method)
{
	return ((  int32_t (*) (List_1_t8F3790B7F8C471B3A1336522C7415FB0AC36D47B*, const RuntimeMethod*))List_1_get_Count_mF1C0C56457C655BDFFC6EE5B46FAD8BAEC1F588B_gshared_inline)(__this, method);
}
// System.Void System.Collections.Generic.List`1<System.Int32>::Add(T)
inline void List_1_Add_m0248A96C5334E9A93E6994B7780478BCD994EA3D_inline (List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73* __this, int32_t ___item0, const RuntimeMethod* method)
{
	((  void (*) (List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73*, int32_t, const RuntimeMethod*))List_1_Add_m0248A96C5334E9A93E6994B7780478BCD994EA3D_gshared_inline)(__this, ___item0, method);
}
// System.Void Dummiesman.OBJObjectBuilder::PushFace(System.String,System.Collections.Generic.List`1<System.Int32>,System.Collections.Generic.List`1<System.Int32>,System.Collections.Generic.List`1<System.Int32>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void OBJObjectBuilder_PushFace_mEB8693BC3E91FBC712492DD2570C540D89DD1213 (OBJObjectBuilder_t0FF6F614A40C0709678B6A0F9111F43397565F13* __this, String_t* ___material0, List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73* ___vertexIndices1, List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73* ___normalIndices2, List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73* ___uvIndices3, const RuntimeMethod* method) ;
// System.Void System.Collections.Generic.List`1<System.Int32>::Clear()
inline void List_1_Clear_mF6795DE5F49C1D0B91D6A0955F448B22970D67A9_inline (List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73* __this, const RuntimeMethod* method)
{
	((  void (*) (List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73*, const RuntimeMethod*))List_1_Clear_mF6795DE5F49C1D0B91D6A0955F448B22970D67A9_gshared_inline)(__this, method);
}
// System.String System.IO.Path::GetFileNameWithoutExtension(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* Path_GetFileNameWithoutExtension_mD24A7CA7C45FF7A265EF7F8D5E19D1F3C014D90F (String_t* ___path0, const RuntimeMethod* method) ;
// System.Void UnityEngine.GameObject::.ctor(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void GameObject__ctor_m37D512B05D292F954792225E6C6EEE95293A9B88 (GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* __this, String_t* ___name0, const RuntimeMethod* method) ;
// UnityEngine.Transform UnityEngine.GameObject::get_transform()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* GameObject_get_transform_m0BC10ADFA1632166AE5544BDF9038A2650C2AE56 (GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* __this, const RuntimeMethod* method) ;
// System.Void UnityEngine.Vector3::.ctor(System.Single,System.Single,System.Single)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void Vector3__ctor_m376936E6B999EF1ECBE57D990A386303E2283DE0_inline (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2* __this, float ___x0, float ___y1, float ___z2, const RuntimeMethod* method) ;
// System.Void UnityEngine.Transform::set_localScale(UnityEngine.Vector3)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Transform_set_localScale_mBA79E811BAF6C47B80FF76414C12B47B3CD03633 (Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* __this, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___value0, const RuntimeMethod* method) ;
// System.Collections.Generic.Dictionary`2/Enumerator<TKey,TValue> System.Collections.Generic.Dictionary`2<System.String,Dummiesman.OBJObjectBuilder>::GetEnumerator()
inline Enumerator_t0AE679B39DC9D7D9CE2CF6CCA330D549A945687A Dictionary_2_GetEnumerator_m30A75F41A2E01FBA254EA9D604F77CA1E9EBBCA5 (Dictionary_2_tC5A5AFCB8FF4726846814FB45FC66F49C9B0F82A* __this, const RuntimeMethod* method)
{
	return ((  Enumerator_t0AE679B39DC9D7D9CE2CF6CCA330D549A945687A (*) (Dictionary_2_tC5A5AFCB8FF4726846814FB45FC66F49C9B0F82A*, const RuntimeMethod*))Dictionary_2_GetEnumerator_m52AB12790B0B9B46B1DFB1F861C9DBEAB07C1FDA_gshared)(__this, method);
}
// System.Void System.Collections.Generic.Dictionary`2/Enumerator<System.String,Dummiesman.OBJObjectBuilder>::Dispose()
inline void Enumerator_Dispose_m20C3A9898BD2C0D50D588257FE9C176D0F748C62 (Enumerator_t0AE679B39DC9D7D9CE2CF6CCA330D549A945687A* __this, const RuntimeMethod* method)
{
	((  void (*) (Enumerator_t0AE679B39DC9D7D9CE2CF6CCA330D549A945687A*, const RuntimeMethod*))Enumerator_Dispose_mEA5E01B81EB943B7003D87CEC1B6040524F0402C_gshared)(__this, method);
}
// System.Collections.Generic.KeyValuePair`2<TKey,TValue> System.Collections.Generic.Dictionary`2/Enumerator<System.String,Dummiesman.OBJObjectBuilder>::get_Current()
inline KeyValuePair_2_tD060C533C995F5D1C9F62591EE692E11381464AF Enumerator_get_Current_m0979A8E7E158B0EF6E0CD0B8377E30390074D0FA_inline (Enumerator_t0AE679B39DC9D7D9CE2CF6CCA330D549A945687A* __this, const RuntimeMethod* method)
{
	return ((  KeyValuePair_2_tD060C533C995F5D1C9F62591EE692E11381464AF (*) (Enumerator_t0AE679B39DC9D7D9CE2CF6CCA330D549A945687A*, const RuntimeMethod*))Enumerator_get_Current_mE3475384B761E1C7971D3639BD09117FE8363422_gshared_inline)(__this, method);
}
// TValue System.Collections.Generic.KeyValuePair`2<System.String,Dummiesman.OBJObjectBuilder>::get_Value()
inline OBJObjectBuilder_t0FF6F614A40C0709678B6A0F9111F43397565F13* KeyValuePair_2_get_Value_mD180D6D30ED20CC169164BC3EABC7B8455ED0516_inline (KeyValuePair_2_tD060C533C995F5D1C9F62591EE692E11381464AF* __this, const RuntimeMethod* method)
{
	return ((  OBJObjectBuilder_t0FF6F614A40C0709678B6A0F9111F43397565F13* (*) (KeyValuePair_2_tD060C533C995F5D1C9F62591EE692E11381464AF*, const RuntimeMethod*))KeyValuePair_2_get_Value_mC6BD8075F9C9DDEF7B4D731E5C38EC19103988E7_gshared_inline)(__this, method);
}
// System.Int32 Dummiesman.OBJObjectBuilder::get_PushedFaceCount()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR int32_t OBJObjectBuilder_get_PushedFaceCount_m0800BDEDCCE5D0006D125DE33878F032D415366E_inline (OBJObjectBuilder_t0FF6F614A40C0709678B6A0F9111F43397565F13* __this, const RuntimeMethod* method) ;
// UnityEngine.GameObject Dummiesman.OBJObjectBuilder::Build()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* OBJObjectBuilder_Build_mA827E9316CA93D1CD7AAEBC13B9CED3FE362F556 (OBJObjectBuilder_t0FF6F614A40C0709678B6A0F9111F43397565F13* __this, const RuntimeMethod* method) ;
// System.Void UnityEngine.Transform::SetParent(UnityEngine.Transform,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Transform_SetParent_m9BDD7B7476714B2D7919B10BDC22CE75C0A0A195 (Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* __this, Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* ___parent0, bool ___worldPositionStays1, const RuntimeMethod* method) ;
// System.Boolean System.Collections.Generic.Dictionary`2/Enumerator<System.String,Dummiesman.OBJObjectBuilder>::MoveNext()
inline bool Enumerator_MoveNext_mA034A5AAF361AFA6ADC0AB189A2408443B767A1D (Enumerator_t0AE679B39DC9D7D9CE2CF6CCA330D549A945687A* __this, const RuntimeMethod* method)
{
	return ((  bool (*) (Enumerator_t0AE679B39DC9D7D9CE2CF6CCA330D549A945687A*, const RuntimeMethod*))Enumerator_MoveNext_mCD4950A75FFADD54AF354D48C6C0DB0B5A22A5F4_gshared)(__this, method);
}
// System.Collections.Generic.Dictionary`2<System.String,UnityEngine.Material> MTLLoader::Load(System.IO.Stream)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Dictionary_2_t5B255487AF84FB5AB3382296BC4C30734ADE141F* MTLLoader_Load_m1A0963CCA9C78D58FEBC2ABD4C75F56F0407BA6C (MTLLoader_t3B14F27942873DFDE45A9E33A2AD08A49EF1ABBA* __this, Stream_tF844051B786E8F7F4244DBD218D74E8617B9A2DE* ___input0, const RuntimeMethod* method) ;
// UnityEngine.GameObject Dummiesman.OBJLoader::Load(System.IO.Stream)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* OBJLoader_Load_m45AB8465EEB787782E7E71DFF92C10E0782BF4C8 (OBJLoader_tB5927F8DB92B05302380425D21E9BCE654FD66BF* __this, Stream_tF844051B786E8F7F4244DBD218D74E8617B9A2DE* ___input0, const RuntimeMethod* method) ;
// System.Void System.IO.FileInfo::.ctor(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void FileInfo__ctor_m0A602529DFCFC44BB4EF4C530E6FBA765C44143F (FileInfo_t62782BBAFA832A78724E4CF2EE96548B8466AB1C* __this, String_t* ___fileName0, const RuntimeMethod* method) ;
// System.Boolean System.String::IsNullOrEmpty(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool String_IsNullOrEmpty_m54CF0907E7C4F3AFB2E796A13DC751ECBB8DB64A (String_t* ___value0, const RuntimeMethod* method) ;
// System.Void System.IO.FileStream::.ctor(System.String,System.IO.FileMode)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void FileStream__ctor_m78499F9BE2BE31DA34F123B4399AA457716BD6E6 (FileStream_t07C7222EE10B75F352B89B76E60820160FF10AD8* __this, String_t* ___path0, int32_t ___mode1, const RuntimeMethod* method) ;
// UnityEngine.GameObject Dummiesman.OBJLoader::Load(System.String,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* OBJLoader_Load_mFA6018F459FF559B8877A9B3AE70E2D6BCF54DC0 (OBJLoader_tB5927F8DB92B05302380425D21E9BCE654FD66BF* __this, String_t* ___path0, String_t* ___mtlPath1, const RuntimeMethod* method) ;
// System.Void System.Collections.Generic.List`1<UnityEngine.Vector3>::.ctor()
inline void List_1__ctor_mC54E2BCBE43279A96FC082F5CDE2D76388BD8F9C (List_1_t77B94703E05C519A9010DD0614F757F974E1CD8B* __this, const RuntimeMethod* method)
{
	((  void (*) (List_1_t77B94703E05C519A9010DD0614F757F974E1CD8B*, const RuntimeMethod*))List_1__ctor_mC54E2BCBE43279A96FC082F5CDE2D76388BD8F9C_gshared)(__this, method);
}
// System.Void System.Collections.Generic.List`1<UnityEngine.Vector2>::.ctor()
inline void List_1__ctor_m88C4BD8AC607DB3585552068F4DC437406358D5F (List_1_t8F3790B7F8C471B3A1336522C7415FB0AC36D47B* __this, const RuntimeMethod* method)
{
	((  void (*) (List_1_t8F3790B7F8C471B3A1336522C7415FB0AC36D47B*, const RuntimeMethod*))List_1__ctor_m88C4BD8AC607DB3585552068F4DC437406358D5F_gshared)(__this, method);
}
// System.Void System.Object::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Object__ctor_mE837C6B9FA8C6D5D109F4B2EC885D79919AC0EA2 (RuntimeObject* __this, const RuntimeMethod* method) ;
// System.Boolean System.Collections.Generic.Dictionary`2<System.String,Dummiesman.OBJObjectBuilder>::TryGetValue(TKey,TValue&)
inline bool Dictionary_2_TryGetValue_m0C13BB2CCCC84DFF397E1F1708A35D6B855E83D3 (Dictionary_2_tC5A5AFCB8FF4726846814FB45FC66F49C9B0F82A* __this, String_t* ___key0, OBJObjectBuilder_t0FF6F614A40C0709678B6A0F9111F43397565F13** ___value1, const RuntimeMethod* method)
{
	return ((  bool (*) (Dictionary_2_tC5A5AFCB8FF4726846814FB45FC66F49C9B0F82A*, String_t*, OBJObjectBuilder_t0FF6F614A40C0709678B6A0F9111F43397565F13**, const RuntimeMethod*))Dictionary_2_TryGetValue_mD15380A4ED7CDEE99EA45881577D26BA9CE1B849_gshared)(__this, ___key0, ___value1, method);
}
// System.Void Dummiesman.OBJObjectBuilder::.ctor(System.String,Dummiesman.OBJLoader)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void OBJObjectBuilder__ctor_m559A7FFA399AEF65D8C9649F8122F554E3222ABB (OBJObjectBuilder_t0FF6F614A40C0709678B6A0F9111F43397565F13* __this, String_t* ___name0, OBJLoader_tB5927F8DB92B05302380425D21E9BCE654FD66BF* ___loader1, const RuntimeMethod* method) ;
// System.Void System.Collections.Generic.Dictionary`2<System.String,Dummiesman.OBJObjectBuilder>::set_Item(TKey,TValue)
inline void Dictionary_2_set_Item_m829F1D3D238D6C188AE5440AC46680D7F3B66304 (Dictionary_2_tC5A5AFCB8FF4726846814FB45FC66F49C9B0F82A* __this, String_t* ___key0, OBJObjectBuilder_t0FF6F614A40C0709678B6A0F9111F43397565F13* ___value1, const RuntimeMethod* method)
{
	((  void (*) (Dictionary_2_tC5A5AFCB8FF4726846814FB45FC66F49C9B0F82A*, String_t*, OBJObjectBuilder_t0FF6F614A40C0709678B6A0F9111F43397565F13*, const RuntimeMethod*))Dictionary_2_set_Item_m1A840355E8EDAECEA9D0C6F5E51B248FAA449CBD_gshared)(__this, ___key0, ___value1, method);
}
// System.Void UnityEngine.Material::SetFloat(System.String,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Material_SetFloat_m879CF81D740BAE6F23C9822400679F4D16365836 (Material_t18053F08F347D0DCA5E1140EC7EC4533DD8A14E3* __this, String_t* ___name0, float ___value1, const RuntimeMethod* method) ;
// System.Void UnityEngine.Material::SetInt(System.String,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Material_SetInt_m41DF5404A9942239265888105E1DC83F2FBF901A (Material_t18053F08F347D0DCA5E1140EC7EC4533DD8A14E3* __this, String_t* ___name0, int32_t ___value1, const RuntimeMethod* method) ;
// System.Void UnityEngine.Material::DisableKeyword(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Material_DisableKeyword_mC123927EBF2F2A19220A4456C8EA19F2BA416E8C (Material_t18053F08F347D0DCA5E1140EC7EC4533DD8A14E3* __this, String_t* ___keyword0, const RuntimeMethod* method) ;
// System.Void UnityEngine.Material::EnableKeyword(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Material_EnableKeyword_mE8523EF6CF694284DF976D47ADEDE9363A1174AC (Material_t18053F08F347D0DCA5E1140EC7EC4533DD8A14E3* __this, String_t* ___keyword0, const RuntimeMethod* method) ;
// System.Void UnityEngine.Material::set_renderQueue(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Material_set_renderQueue_mFBB72A781DCCF0D4B85670B597788EC2D02D1C14 (Material_t18053F08F347D0DCA5E1140EC7EC4533DD8A14E3* __this, int32_t ___value0, const RuntimeMethod* method) ;
// System.Boolean System.String::Contains(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool String_Contains_m6D77B121FADA7CA5F397C0FABB65DA62DF03B6C3 (String_t* __this, String_t* ___value0, const RuntimeMethod* method) ;
// System.Globalization.CultureInfo System.Globalization.CultureInfo::get_InvariantCulture()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR CultureInfo_t9BA817D41AD55AC8BD07480DD8AC22F8FFA378E0* CultureInfo_get_InvariantCulture_m78DAB8CBE8766445310782B6E61FB7A9983AD425 (const RuntimeMethod* method) ;
// System.Single System.Single::Parse(System.String,System.IFormatProvider)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float Single_Parse_m4CCF536F9DA447D8822618DF5C6F8F31494B2909 (String_t* ___s0, RuntimeObject* ___provider1, const RuntimeMethod* method) ;
// System.Int32 System.String::get_Length()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR int32_t String_get_Length_m42625D67623FA5CC7A44D47425CE86FB946542D2_inline (String_t* __this, const RuntimeMethod* method) ;
// System.Char System.String::get_Chars(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Il2CppChar String_get_Chars_mC49DF0CD2D3BE7BE97B3AD9C995BE3094F8E36D3 (String_t* __this, int32_t ___index0, const RuntimeMethod* method) ;
// UnityEngine.Shader UnityEngine.Shader::Find(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Shader_tADC867D36B7876EE22427FAA2CE485105F4EE692* Shader_Find_mFF2A8FC042B9CFAA9800679CA674D52859BF3A72 (String_t* ___name0, const RuntimeMethod* method) ;
// System.Void UnityEngine.Material::.ctor(UnityEngine.Shader)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Material__ctor_m7FDF47105D66D19591BE505A0C42B0F90D88C9BF (Material_t18053F08F347D0DCA5E1140EC7EC4533DD8A14E3* __this, Shader_tADC867D36B7876EE22427FAA2CE485105F4EE692* ___shader0, const RuntimeMethod* method) ;
// System.Single Dummiesman.OBJLoaderHelper::FastFloatParse(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float OBJLoaderHelper_FastFloatParse_mA831C3685B456D7493658947983B62E61AF86F99 (String_t* ___input0, const RuntimeMethod* method) ;
// System.Void UnityEngine.Vector2::.ctor(System.Single,System.Single)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void Vector2__ctor_m9525B79969AFFE3254B303A40997A56DEEB6F548_inline (Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7* __this, float ___x0, float ___y1, const RuntimeMethod* method) ;
// UnityEngine.Vector3 UnityEngine.Vector2::op_Implicit(UnityEngine.Vector2)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 Vector2_op_Implicit_mCD214B04BC52AED3C89C3BEF664B6247E5F8954A_inline (Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 ___v0, const RuntimeMethod* method) ;
// System.Void UnityEngine.Color::.ctor(System.Single,System.Single,System.Single)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void Color__ctor_mCD6889CDE39F18704CD6EA8E2EFBFA48BA3E13B0_inline (Color_tD001788D726C3A7F1379BEED0260B9591F440C1F* __this, float ___r0, float ___g1, float ___b2, const RuntimeMethod* method) ;
// T UnityEngine.GameObject::AddComponent<UnityEngine.MeshRenderer>()
inline MeshRenderer_t4B7747212F0B88244BB7790C61AE124BFC15BAAE* GameObject_AddComponent_TisMeshRenderer_t4B7747212F0B88244BB7790C61AE124BFC15BAAE_mCDD3E77673305199F52C772AE8C7952F3864740D (GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* __this, const RuntimeMethod* method)
{
	return ((  MeshRenderer_t4B7747212F0B88244BB7790C61AE124BFC15BAAE* (*) (GameObject_t76FEDD663AB33C991A9C9A23129337651094216F*, const RuntimeMethod*))GameObject_AddComponent_TisRuntimeObject_m69B93700FACCF372F5753371C6E8FB780800B824_gshared)(__this, method);
}
// System.Int32 System.Collections.Generic.Dictionary`2<System.String,System.Collections.Generic.List`1<System.Int32>>::get_Count()
inline int32_t Dictionary_2_get_Count_m831221DAC53C65F38539F4A37520985E8DC557AF (Dictionary_2_t6FFAD029BB474A5257D9A441504B633831AF5341* __this, const RuntimeMethod* method)
{
	return ((  int32_t (*) (Dictionary_2_t6FFAD029BB474A5257D9A441504B633831AF5341*, const RuntimeMethod*))Dictionary_2_get_Count_m4DDA9442C238A443489115E22B026AD366851549_gshared)(__this, method);
}
// System.Collections.Generic.Dictionary`2/Enumerator<TKey,TValue> System.Collections.Generic.Dictionary`2<System.String,System.Collections.Generic.List`1<System.Int32>>::GetEnumerator()
inline Enumerator_t2B62C6EA9375CE714A32E123DFDDDC13C21DDDB2 Dictionary_2_GetEnumerator_m2E9E4B0E50E5FBA0C7E62ACEAD7A0327267C4C2E (Dictionary_2_t6FFAD029BB474A5257D9A441504B633831AF5341* __this, const RuntimeMethod* method)
{
	return ((  Enumerator_t2B62C6EA9375CE714A32E123DFDDDC13C21DDDB2 (*) (Dictionary_2_t6FFAD029BB474A5257D9A441504B633831AF5341*, const RuntimeMethod*))Dictionary_2_GetEnumerator_m52AB12790B0B9B46B1DFB1F861C9DBEAB07C1FDA_gshared)(__this, method);
}
// System.Void System.Collections.Generic.Dictionary`2/Enumerator<System.String,System.Collections.Generic.List`1<System.Int32>>::Dispose()
inline void Enumerator_Dispose_m1ED4783F9B383A3AAA727AA5F6241652CEDF91FF (Enumerator_t2B62C6EA9375CE714A32E123DFDDDC13C21DDDB2* __this, const RuntimeMethod* method)
{
	((  void (*) (Enumerator_t2B62C6EA9375CE714A32E123DFDDDC13C21DDDB2*, const RuntimeMethod*))Enumerator_Dispose_mEA5E01B81EB943B7003D87CEC1B6040524F0402C_gshared)(__this, method);
}
// System.Collections.Generic.KeyValuePair`2<TKey,TValue> System.Collections.Generic.Dictionary`2/Enumerator<System.String,System.Collections.Generic.List`1<System.Int32>>::get_Current()
inline KeyValuePair_2_tAB3B085BB59FEFAE0C5C3A1A32259012890DC6B0 Enumerator_get_Current_mAD3C13EC90677751AE02D5DF4E981C2831DD1C1C_inline (Enumerator_t2B62C6EA9375CE714A32E123DFDDDC13C21DDDB2* __this, const RuntimeMethod* method)
{
	return ((  KeyValuePair_2_tAB3B085BB59FEFAE0C5C3A1A32259012890DC6B0 (*) (Enumerator_t2B62C6EA9375CE714A32E123DFDDDC13C21DDDB2*, const RuntimeMethod*))Enumerator_get_Current_mE3475384B761E1C7971D3639BD09117FE8363422_gshared_inline)(__this, method);
}
// UnityEngine.Material Dummiesman.OBJLoaderHelper::CreateNullMaterial()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Material_t18053F08F347D0DCA5E1140EC7EC4533DD8A14E3* OBJLoaderHelper_CreateNullMaterial_m08CCF4F5500BB7553CEF31A5F1444147F829170B (const RuntimeMethod* method) ;
// TKey System.Collections.Generic.KeyValuePair`2<System.String,System.Collections.Generic.List`1<System.Int32>>::get_Key()
inline String_t* KeyValuePair_2_get_Key_mFF379184A888CEA6C7DD77DD5DD36E5819C98D99_inline (KeyValuePair_2_tAB3B085BB59FEFAE0C5C3A1A32259012890DC6B0* __this, const RuntimeMethod* method)
{
	return ((  String_t* (*) (KeyValuePair_2_tAB3B085BB59FEFAE0C5C3A1A32259012890DC6B0*, const RuntimeMethod*))KeyValuePair_2_get_Key_mBD8EA7557C27E6956F2AF29DA3F7499B2F51A282_gshared_inline)(__this, method);
}
// System.Void UnityEngine.Object::set_name(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Object_set_name_mC79E6DC8FFD72479C90F0C4CC7F42A0FEAF5AE47 (Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C* __this, String_t* ___value0, const RuntimeMethod* method) ;
// System.Boolean System.Collections.Generic.Dictionary`2<System.String,UnityEngine.Material>::TryGetValue(TKey,TValue&)
inline bool Dictionary_2_TryGetValue_mFD7867D61B454D815AFE71D04D27540FAFBFF091 (Dictionary_2_t5B255487AF84FB5AB3382296BC4C30734ADE141F* __this, String_t* ___key0, Material_t18053F08F347D0DCA5E1140EC7EC4533DD8A14E3** ___value1, const RuntimeMethod* method)
{
	return ((  bool (*) (Dictionary_2_t5B255487AF84FB5AB3382296BC4C30734ADE141F*, String_t*, Material_t18053F08F347D0DCA5E1140EC7EC4533DD8A14E3**, const RuntimeMethod*))Dictionary_2_TryGetValue_mD15380A4ED7CDEE99EA45881577D26BA9CE1B849_gshared)(__this, ___key0, ___value1, method);
}
// System.Void System.Collections.Generic.Dictionary`2<System.String,UnityEngine.Material>::set_Item(TKey,TValue)
inline void Dictionary_2_set_Item_m2712E92CF36B85D20B01493D39F2BD4504C0BE7B (Dictionary_2_t5B255487AF84FB5AB3382296BC4C30734ADE141F* __this, String_t* ___key0, Material_t18053F08F347D0DCA5E1140EC7EC4533DD8A14E3* ___value1, const RuntimeMethod* method)
{
	((  void (*) (Dictionary_2_t5B255487AF84FB5AB3382296BC4C30734ADE141F*, String_t*, Material_t18053F08F347D0DCA5E1140EC7EC4533DD8A14E3*, const RuntimeMethod*))Dictionary_2_set_Item_m1A840355E8EDAECEA9D0C6F5E51B248FAA449CBD_gshared)(__this, ___key0, ___value1, method);
}
// System.Boolean System.Collections.Generic.Dictionary`2/Enumerator<System.String,System.Collections.Generic.List`1<System.Int32>>::MoveNext()
inline bool Enumerator_MoveNext_m6F709DC1AED45A132D5B2CE5C6912F4FB3BA6872 (Enumerator_t2B62C6EA9375CE714A32E123DFDDDC13C21DDDB2* __this, const RuntimeMethod* method)
{
	return ((  bool (*) (Enumerator_t2B62C6EA9375CE714A32E123DFDDDC13C21DDDB2*, const RuntimeMethod*))Enumerator_MoveNext_mCD4950A75FFADD54AF354D48C6C0DB0B5A22A5F4_gshared)(__this, method);
}
// System.Void UnityEngine.Renderer::set_sharedMaterials(UnityEngine.Material[])
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Renderer_set_sharedMaterials_m665ADE4190214CC2AC52490B4A7373D7EE75DEB2 (Renderer_t320575F223BCB177A982E5DDB5DB19FAA89E7FBF* __this, MaterialU5BU5D_t2B1D11C42DB07A4400C0535F92DBB87A2E346D3D* ___value0, const RuntimeMethod* method) ;
// T UnityEngine.GameObject::AddComponent<UnityEngine.MeshFilter>()
inline MeshFilter_t6D1CE2473A1E45AC73013400585A1163BF66B2F5* GameObject_AddComponent_TisMeshFilter_t6D1CE2473A1E45AC73013400585A1163BF66B2F5_mEAB8177A64DF1A50BB7996ACEEEADCD65358AC94 (GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* __this, const RuntimeMethod* method)
{
	return ((  MeshFilter_t6D1CE2473A1E45AC73013400585A1163BF66B2F5* (*) (GameObject_t76FEDD663AB33C991A9C9A23129337651094216F*, const RuntimeMethod*))GameObject_AddComponent_TisRuntimeObject_m69B93700FACCF372F5753371C6E8FB780800B824_gshared)(__this, method);
}
// System.Void UnityEngine.Mesh::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Mesh__ctor_m5A9AECEDDAFFD84811ED8928012BDE97A9CEBD00 (Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* __this, const RuntimeMethod* method) ;
// System.Void UnityEngine.Mesh::set_indexFormat(UnityEngine.Rendering.IndexFormat)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Mesh_set_indexFormat_mCCC7837A0916FA7A272159DA6AF984B0022488F4 (Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* __this, int32_t ___value0, const RuntimeMethod* method) ;
// System.Void UnityEngine.Mesh::set_subMeshCount(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Mesh_set_subMeshCount_m8E4DB392DB0621F7DFF8543FF3943A13072B8A28 (Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* __this, int32_t ___value0, const RuntimeMethod* method) ;
// System.Void UnityEngine.Mesh::SetVertices(System.Collections.Generic.List`1<UnityEngine.Vector3>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Mesh_SetVertices_mCE01139EEEC3D10B4A6CEA1749FD84DABC53599E (Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* __this, List_1_t77B94703E05C519A9010DD0614F757F974E1CD8B* ___inVertices0, const RuntimeMethod* method) ;
// System.Void UnityEngine.Mesh::SetNormals(System.Collections.Generic.List`1<UnityEngine.Vector3>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Mesh_SetNormals_mB4072A4D2600768FD62BC9CAAFF8C43955A4A365 (Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* __this, List_1_t77B94703E05C519A9010DD0614F757F974E1CD8B* ___inNormals0, const RuntimeMethod* method) ;
// System.Void UnityEngine.Mesh::SetUVs(System.Int32,System.Collections.Generic.List`1<UnityEngine.Vector2>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Mesh_SetUVs_m5A7A6EC14A621579B7138F2EF9BECA60E880A8D7 (Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* __this, int32_t ___channel0, List_1_t8F3790B7F8C471B3A1336522C7415FB0AC36D47B* ___uvs1, const RuntimeMethod* method) ;
// TValue System.Collections.Generic.KeyValuePair`2<System.String,System.Collections.Generic.List`1<System.Int32>>::get_Value()
inline List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73* KeyValuePair_2_get_Value_mD43CA99389807F2DF5FE76DBEC3D4174C787BE98_inline (KeyValuePair_2_tAB3B085BB59FEFAE0C5C3A1A32259012890DC6B0* __this, const RuntimeMethod* method)
{
	return ((  List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73* (*) (KeyValuePair_2_tAB3B085BB59FEFAE0C5C3A1A32259012890DC6B0*, const RuntimeMethod*))KeyValuePair_2_get_Value_mC6BD8075F9C9DDEF7B4D731E5C38EC19103988E7_gshared_inline)(__this, method);
}
// System.Void UnityEngine.Mesh::SetTriangles(System.Collections.Generic.List`1<System.Int32>,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Mesh_SetTriangles_mD495DA0B00DB0E60A2B7B500D644F4470C1D61DB (Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* __this, List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73* ___triangles0, int32_t ___submesh1, const RuntimeMethod* method) ;
// System.Void UnityEngine.Mesh::RecalculateNormals()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Mesh_RecalculateNormals_m3AA2788914611444E030CA310E03E3CFE683902B (Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* __this, const RuntimeMethod* method) ;
// System.Void UnityEngine.Mesh::RecalculateTangents()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Mesh_RecalculateTangents_m92AC413FAF889C5E811D86DCE0C25ED4625825EC (Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* __this, const RuntimeMethod* method) ;
// System.Void UnityEngine.Mesh::RecalculateBounds()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Mesh_RecalculateBounds_mA9B293F57C6CD298AE2D2DB19061FC23B05AB90B (Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* __this, const RuntimeMethod* method) ;
// System.Void UnityEngine.MeshFilter::set_sharedMesh(UnityEngine.Mesh)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MeshFilter_set_sharedMesh_m946F7E3F583761982642BDA4753784AF1DF6E16F (MeshFilter_t6D1CE2473A1E45AC73013400585A1163BF66B2F5* __this, Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* ___value0, const RuntimeMethod* method) ;
// System.Boolean System.Collections.Generic.Dictionary`2<System.String,System.Collections.Generic.List`1<System.Int32>>::TryGetValue(TKey,TValue&)
inline bool Dictionary_2_TryGetValue_m56F2C16A68E7E1B774D8B14B3DF74FA825C5CC9C (Dictionary_2_t6FFAD029BB474A5257D9A441504B633831AF5341* __this, String_t* ___key0, List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73** ___value1, const RuntimeMethod* method)
{
	return ((  bool (*) (Dictionary_2_t6FFAD029BB474A5257D9A441504B633831AF5341*, String_t*, List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73**, const RuntimeMethod*))Dictionary_2_TryGetValue_mD15380A4ED7CDEE99EA45881577D26BA9CE1B849_gshared)(__this, ___key0, ___value1, method);
}
// System.Void System.Collections.Generic.Dictionary`2<System.String,System.Collections.Generic.List`1<System.Int32>>::set_Item(TKey,TValue)
inline void Dictionary_2_set_Item_m529105CC1CF8E638D570A195BF4D8BA4984EB3E8 (Dictionary_2_t6FFAD029BB474A5257D9A441504B633831AF5341* __this, String_t* ___key0, List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73* ___value1, const RuntimeMethod* method)
{
	((  void (*) (Dictionary_2_t6FFAD029BB474A5257D9A441504B633831AF5341*, String_t*, List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73*, const RuntimeMethod*))Dictionary_2_set_Item_m1A840355E8EDAECEA9D0C6F5E51B248FAA449CBD_gshared)(__this, ___key0, ___value1, method);
}
// System.Int32 System.Collections.Generic.List`1<System.Int32>::get_Count()
inline int32_t List_1_get_Count_mF590592E32D421DE2C6E2F0D5C2F62FB14CCEFDF_inline (List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73* __this, const RuntimeMethod* method)
{
	return ((  int32_t (*) (List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73*, const RuntimeMethod*))List_1_get_Count_mF590592E32D421DE2C6E2F0D5C2F62FB14CCEFDF_gshared_inline)(__this, method);
}
// System.Boolean System.String::op_Inequality(System.String,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool String_op_Inequality_m0FBE5AC4931D312E5B347BAA603755676E6DA2FE (String_t* ___a0, String_t* ___b1, const RuntimeMethod* method) ;
// System.Void Dummiesman.OBJObjectBuilder::SetMaterial(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void OBJObjectBuilder_SetMaterial_m14E76B9F35E6D475F9CF64D81A431328AFF709D9 (OBJObjectBuilder_t0FF6F614A40C0709678B6A0F9111F43397565F13* __this, String_t* ___name0, const RuntimeMethod* method) ;
// T System.Collections.Generic.List`1<System.Int32>::get_Item(System.Int32)
inline int32_t List_1_get_Item_mD99081BEFA1AB3526715F489192B0F7F596C183D (List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73* __this, int32_t ___index0, const RuntimeMethod* method)
{
	return ((  int32_t (*) (List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73*, int32_t, const RuntimeMethod*))List_1_get_Item_mD99081BEFA1AB3526715F489192B0F7F596C183D_gshared)(__this, ___index0, method);
}
// System.Void Dummiesman.OBJObjectBuilder/ObjLoopHash::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ObjLoopHash__ctor_m47684E1CB5D8B5CCC4D682B98F165C87AF514445 (ObjLoopHash_t0314B9758A262019FC1EFB5432DE4F2D2139B20B* __this, const RuntimeMethod* method) ;
// System.Boolean System.Collections.Generic.Dictionary`2<Dummiesman.OBJObjectBuilder/ObjLoopHash,System.Int32>::TryGetValue(TKey,TValue&)
inline bool Dictionary_2_TryGetValue_m0058521363E7F49C437C430A754DB0F1B5379289 (Dictionary_2_tEAE7D7DBCEF056EB634E23611F29B7D56A4614FE* __this, ObjLoopHash_t0314B9758A262019FC1EFB5432DE4F2D2139B20B* ___key0, int32_t* ___value1, const RuntimeMethod* method)
{
	return ((  bool (*) (Dictionary_2_tEAE7D7DBCEF056EB634E23611F29B7D56A4614FE*, ObjLoopHash_t0314B9758A262019FC1EFB5432DE4F2D2139B20B*, int32_t*, const RuntimeMethod*))Dictionary_2_TryGetValue_m4B8EE45640C70BBFD6F3EFF1040983404C098342_gshared)(__this, ___key0, ___value1, method);
}
// System.Void System.Collections.Generic.Dictionary`2<Dummiesman.OBJObjectBuilder/ObjLoopHash,System.Int32>::Add(TKey,TValue)
inline void Dictionary_2_Add_m45B16A0848D5AA8855A51C20C2AA2B90A6516877 (Dictionary_2_tEAE7D7DBCEF056EB634E23611F29B7D56A4614FE* __this, ObjLoopHash_t0314B9758A262019FC1EFB5432DE4F2D2139B20B* ___key0, int32_t ___value1, const RuntimeMethod* method)
{
	((  void (*) (Dictionary_2_tEAE7D7DBCEF056EB634E23611F29B7D56A4614FE*, ObjLoopHash_t0314B9758A262019FC1EFB5432DE4F2D2139B20B*, int32_t, const RuntimeMethod*))Dictionary_2_Add_m63897227AFA7035F1772315ABBBE7FD0A250E10C_gshared)(__this, ___key0, ___value1, method);
}
// UnityEngine.Vector3 UnityEngine.Vector3::get_zero()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 Vector3_get_zero_m9D7F7B580B5A276411267E96AA3425736D9BDC83_inline (const RuntimeMethod* method) ;
// T System.Collections.Generic.List`1<UnityEngine.Vector3>::get_Item(System.Int32)
inline Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 List_1_get_Item_m8F2E15FC96DA75186C51228128A0660709E4E810 (List_1_t77B94703E05C519A9010DD0614F757F974E1CD8B* __this, int32_t ___index0, const RuntimeMethod* method)
{
	return ((  Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 (*) (List_1_t77B94703E05C519A9010DD0614F757F974E1CD8B*, int32_t, const RuntimeMethod*))List_1_get_Item_m8F2E15FC96DA75186C51228128A0660709E4E810_gshared)(__this, ___index0, method);
}
// UnityEngine.Vector2 UnityEngine.Vector2::get_zero()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 Vector2_get_zero_m009B92B5D35AB02BD1610C2E1ACCE7C9CF964A6E_inline (const RuntimeMethod* method) ;
// T System.Collections.Generic.List`1<UnityEngine.Vector2>::get_Item(System.Int32)
inline Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 List_1_get_Item_m1F8E226CAD72B83C5E75BB66B43025247806B543 (List_1_t8F3790B7F8C471B3A1336522C7415FB0AC36D47B* __this, int32_t ___index0, const RuntimeMethod* method)
{
	return ((  Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 (*) (List_1_t8F3790B7F8C471B3A1336522C7415FB0AC36D47B*, int32_t, const RuntimeMethod*))List_1_get_Item_m1F8E226CAD72B83C5E75BB66B43025247806B543_gshared)(__this, ___index0, method);
}
// System.Void System.Collections.Generic.List`1<System.Int32>::AddRange(System.Collections.Generic.IEnumerable`1<T>)
inline void List_1_AddRange_m1A10E697703D67F6551D47C603FFE78E16CE4204 (List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73* __this, RuntimeObject* ___collection0, const RuntimeMethod* method)
{
	((  void (*) (List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73*, RuntimeObject*, const RuntimeMethod*))List_1_AddRange_m1A10E697703D67F6551D47C603FFE78E16CE4204_gshared)(__this, ___collection0, method);
}
// System.Void Dummiesman.OBJObjectBuilder::set_PushedFaceCount(System.Int32)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void OBJObjectBuilder_set_PushedFaceCount_m59B64D90A70C329BAB9F7E36961ED9C4D23744D8_inline (OBJObjectBuilder_t0FF6F614A40C0709678B6A0F9111F43397565F13* __this, int32_t ___value0, const RuntimeMethod* method) ;
// System.Void System.Collections.Generic.Dictionary`2<Dummiesman.OBJObjectBuilder/ObjLoopHash,System.Int32>::.ctor()
inline void Dictionary_2__ctor_m63CFEDABA0B46AEB5DB36FFBCDDAD873A37C82FE (Dictionary_2_tEAE7D7DBCEF056EB634E23611F29B7D56A4614FE* __this, const RuntimeMethod* method)
{
	((  void (*) (Dictionary_2_tEAE7D7DBCEF056EB634E23611F29B7D56A4614FE*, const RuntimeMethod*))Dictionary_2__ctor_m517E7F9D104FEAE6646EABDDC9C852510E86077C_gshared)(__this, method);
}
// System.Void System.Collections.Generic.Dictionary`2<System.String,System.Collections.Generic.List`1<System.Int32>>::.ctor()
inline void Dictionary_2__ctor_m82637A3A6031C43DB9CC910DBD6DCC66D9459C8F (Dictionary_2_t6FFAD029BB474A5257D9A441504B633831AF5341* __this, const RuntimeMethod* method)
{
	((  void (*) (Dictionary_2_t6FFAD029BB474A5257D9A441504B633831AF5341*, const RuntimeMethod*))Dictionary_2__ctor_m5B32FBC624618211EB461D59CFBB10E987FD1329_gshared)(__this, method);
}
// System.String System.String::Replace(System.Char,System.Char)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* String_Replace_m86403DC5F422D8D5E1CFAAF255B103CB807EDAAF (String_t* __this, Il2CppChar ___oldChar0, Il2CppChar ___newChar1, const RuntimeMethod* method) ;
// System.String System.String::Replace(System.String,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* String_Replace_mABDB7003A1D0AEDCAE9FF85E3DFFFBA752D2A166 (String_t* __this, String_t* ___oldValue0, String_t* ___newValue1, const RuntimeMethod* method) ;
// System.String System.String::Trim()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* String_Trim_mCD6D8C6D4CFD15225D12DB7D3E0544CA80FB8DA5 (String_t* __this, const RuntimeMethod* method) ;
// System.Void UnityEngine.Color32::.ctor(System.Byte,System.Byte,System.Byte,System.Byte)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void Color32__ctor_mC9C6B443F0C7CA3F8B174158B2AF6F05E18EAC4E_inline (Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B* __this, uint8_t ___r0, uint8_t ___g1, uint8_t ___b2, uint8_t ___a3, const RuntimeMethod* method) ;
// UnityEngine.Texture2D Dummiesman.DDSLoader::Load(System.Byte[])
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* DDSLoader_Load_m11E28E4EA6EDE7B53BB990A398F4281D2BDA56AF (ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* ___ddsBytes0, const RuntimeMethod* method) ;
// System.Byte[] System.IO.File::ReadAllBytes(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* File_ReadAllBytes_mE0C2C5A0270CD40C496E85B1D8BA15C607E7011E (String_t* ___path0, const RuntimeMethod* method) ;
// System.Void System.Exception::.ctor(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Exception__ctor_m9B2BD92CD68916245A75109105D9071C9D430E7F (Exception_t* __this, String_t* ___message0, const RuntimeMethod* method) ;
// System.Void System.Buffer::BlockCopy(System.Array,System.Int32,System.Array,System.Int32,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Buffer_BlockCopy_mD8CF7EC96ADA7A542CCA3F3C73510624E10197A9 (RuntimeArray* ___src0, int32_t ___srcOffset1, RuntimeArray* ___dst2, int32_t ___dstOffset3, int32_t ___count4, const RuntimeMethod* method) ;
// System.Void UnityEngine.Texture2D::.ctor(System.Int32,System.Int32,UnityEngine.TextureFormat,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Texture2D__ctor_mECF60A9EC0638EC353C02C8E99B6B465D23BE917 (Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* __this, int32_t ___width0, int32_t ___height1, int32_t ___textureFormat2, bool ___mipChain3, const RuntimeMethod* method) ;
// System.Void UnityEngine.Texture2D::LoadRawTextureData(System.Byte[])
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Texture2D_LoadRawTextureData_mB8D1DEB5FF8715A871D8043D48C9054FCFF4ED1B (Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* __this, ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* ___data0, const RuntimeMethod* method) ;
// System.Void UnityEngine.Texture2D::Apply()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Texture2D_Apply_mA014182C9EE0BBF6EEE3B286854F29E50EB972DC (Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* __this, const RuntimeMethod* method) ;
// System.String System.String::Concat(System.String,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* String_Concat_mAF2CE02CC0CB7460753D0A1A91CCF2B1E9804C5D (String_t* ___str00, String_t* ___str11, const RuntimeMethod* method) ;
// UnityEngine.Color[] UnityEngine.Texture2D::GetPixels()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR ColorU5BU5D_t612261CF293F6FFC3D80AB52259FF0DC2B2CC389* Texture2D_GetPixels_m77A00D71DF5CDC7DAA0EE66FF2C90A24C7604039 (Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* __this, const RuntimeMethod* method) ;
// System.Void UnityEngine.Texture2D::SetPixels(UnityEngine.Color[])
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Texture2D_SetPixels_mAE0CDFA15FA96F840D7FFADC31405D8AF20D9073 (Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* __this, ColorU5BU5D_t612261CF293F6FFC3D80AB52259FF0DC2B2CC389* ___colors0, const RuntimeMethod* method) ;
// System.Void UnityEngine.Texture2D::Apply(System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Texture2D_Apply_mCC369BCAB2D3AD3EE50EE01DA67AF227865FA2B3 (Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* __this, bool ___updateMipmaps0, const RuntimeMethod* method) ;
// System.Void B83.Image.BMP.BMPLoader::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void BMPLoader__ctor_mE1F6B7D4F696A40E6932B4B64EB677F8E5303CFA (BMPLoader_t8C88A751EA549C5D60C3E41F58F456A97D8B5C83* __this, const RuntimeMethod* method) ;
// B83.Image.BMP.BMPImage B83.Image.BMP.BMPLoader::LoadBMP(System.IO.Stream)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR BMPImage_tA6E059574F192A9BB574E7B260012D990055F05C* BMPLoader_LoadBMP_m0131F513F34E1A490D639C0F46E8E18B9DFB25B7 (BMPLoader_t8C88A751EA549C5D60C3E41F58F456A97D8B5C83* __this, Stream_tF844051B786E8F7F4244DBD218D74E8617B9A2DE* ___aData0, const RuntimeMethod* method) ;
// UnityEngine.Texture2D B83.Image.BMP.BMPImage::ToTexture2D()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* BMPImage_ToTexture2D_m0E65B93ED38B9B8308E4314459DEFAB4D3277F32 (BMPImage_tA6E059574F192A9BB574E7B260012D990055F05C* __this, const RuntimeMethod* method) ;
// UnityEngine.Texture2D Dummiesman.DDSLoader::Load(System.IO.Stream)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* DDSLoader_Load_mF25129AE55E29A32883B8334AB2D5855DCDFAC2C (Stream_tF844051B786E8F7F4244DBD218D74E8617B9A2DE* ___ddsStream0, const RuntimeMethod* method) ;
// System.Void UnityEngine.Texture2D::.ctor(System.Int32,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Texture2D__ctor_m3BA82E87442B7F69E118477069AE11101B9DF796 (Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* __this, int32_t ___width0, int32_t ___height1, const RuntimeMethod* method) ;
// System.Boolean UnityEngine.ImageConversion::LoadImage(UnityEngine.Texture2D,System.Byte[])
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool ImageConversion_LoadImage_mBB2DFA1F5BDFF2B81DD0453356EFB092BC5180EC (Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* ___tex0, ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* ___data1, const RuntimeMethod* method) ;
// UnityEngine.Texture2D Dummiesman.TGALoader::Load(System.IO.Stream)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* TGALoader_Load_mB5CF838E183A7538AF925552AC81CA3B6C9AFC0D (Stream_tF844051B786E8F7F4244DBD218D74E8617B9A2DE* ___TGAStream0, const RuntimeMethod* method) ;
// System.String System.IO.Path::GetExtension(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* Path_GetExtension_m52A28295599B87FA550D0654E531B56354C540C7 (String_t* ___path0, const RuntimeMethod* method) ;
// System.String System.String::ToLower()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* String_ToLower_m6191ABA3DC514ED47C10BDA23FD0DDCEAE7ACFBD (String_t* __this, const RuntimeMethod* method) ;
// System.String System.IO.Path::GetFileName(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* Path_GetFileName_mEBC73E0C8D8C56214D1DA4BA8409C5B5F00457A5 (String_t* ___path0, const RuntimeMethod* method) ;
// System.UInt32 <PrivateImplementationDetails>::ComputeStringHash(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR uint32_t U3CPrivateImplementationDetailsU3E_ComputeStringHash_m9E43873DE0DF480D27EC1C2AA3C09E74EA77F75D (String_t* ___s0, const RuntimeMethod* method) ;
// System.Boolean System.String::op_Equality(System.String,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool String_op_Equality_m0D685A924E5CD78078F248ED1726DA5A9D7D6AC0 (String_t* ___a0, String_t* ___b1, const RuntimeMethod* method) ;
// UnityEngine.Texture2D Dummiesman.TGALoader::Load(System.Byte[])
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* TGALoader_Load_m90B1879FA09E6480B21C87F484AF0C3CC611DCAB (ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* ___bytes0, const RuntimeMethod* method) ;
// B83.Image.BMP.BMPImage B83.Image.BMP.BMPLoader::LoadBMP(System.Byte[])
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR BMPImage_tA6E059574F192A9BB574E7B260012D990055F05C* BMPLoader_LoadBMP_m6A621DEC5410845DE112A71843CEA2381C3DD4BD (BMPLoader_t8C88A751EA549C5D60C3E41F58F456A97D8B5C83* __this, ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* ___aData0, const RuntimeMethod* method) ;
// System.UInt16 System.BitConverter::ToUInt16(System.Byte[],System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR uint16_t BitConverter_ToUInt16_m133E286BF0B721DD973FD966F61CB171F70F3E32 (ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* ___value0, int32_t ___startIndex1, const RuntimeMethod* method) ;
// System.String System.Byte::ToString()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* Byte_ToString_mB80CE094B94215119578E4D796566E71D7277EE4 (uint8_t* __this, const RuntimeMethod* method) ;
// System.String System.String::Concat(System.String[])
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* String_Concat_m6B0734B65813C8EA093D78E5C2D16534EB6FE8C0 (StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248* ___values0, const RuntimeMethod* method) ;
// System.Void UnityEngine.Debug::LogError(System.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Debug_LogError_m059825802BB6AF7EA9693FEBEEB0D85F59A3E38E (RuntimeObject* ___message0, const RuntimeMethod* method) ;
// System.String System.String::Concat(System.String,System.String,System.String,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* String_Concat_mF8B69BE42B5C5ABCAD3C176FBBE3010E0815D65D (String_t* ___str00, String_t* ___str11, String_t* ___str22, String_t* ___str33, const RuntimeMethod* method) ;
// System.Boolean UnityEngine.Object::op_Inequality(UnityEngine.Object,UnityEngine.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Object_op_Inequality_m4D656395C27694A7F33F5AA8DE80A7AAF9E20BA7 (Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C* ___x0, Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C* ___y1, const RuntimeMethod* method) ;
// UnityEngine.Texture2D Dummiesman.ImageLoaderHelper::VerifyFormat(UnityEngine.Texture2D)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* ImageLoaderHelper_VerifyFormat_m2859E1A7AD80266E977B1EEC9FD1C256EECB3A0F (Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* ___tex0, const RuntimeMethod* method) ;
// UnityEngine.TextureFormat UnityEngine.Texture2D::get_format()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t Texture2D_get_format_mE39DD922F83CA1097383309278BB6F20636A7D9D (Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* __this, const RuntimeMethod* method) ;
// UnityEngine.Color32[] UnityEngine.Texture2D::GetPixels32()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Color32U5BU5D_t38116C3E91765C4C5726CE12C77FAD7F9F737259* Texture2D_GetPixels32_m48230192E7543765C1A517F251D1D9BFCFB58C3D (Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* __this, const RuntimeMethod* method) ;
// System.Int32 UnityEngine.Texture::get_mipmapCount()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t Texture_get_mipmapCount_m9E68435BC8E30B9821525BFC8121C34A53774023 (Texture_t791CBB51219779964E0E8A2ED7C1AA5F92A4A700* __this, const RuntimeMethod* method) ;
// System.Void UnityEngine.Texture2D::SetPixels32(UnityEngine.Color32[])
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Texture2D_SetPixels32_m169F9873A21FB8DECA24DC1B8F06FB23D13BEE2A (Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* __this, Color32U5BU5D_t38116C3E91765C4C5726CE12C77FAD7F9F737259* ___colors0, const RuntimeMethod* method) ;
// System.Void Dummiesman.ImageLoaderHelper::FillPixelArray(UnityEngine.Color32[],System.Byte[],System.Int32,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ImageLoaderHelper_FillPixelArray_m6BFB48A1F8EE716042BA26E2E8E49BCFB153B097 (Color32U5BU5D_t38116C3E91765C4C5726CE12C77FAD7F9F737259* ___fillArray0, ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* ___pixelData1, int32_t ___bytesPerPixel2, bool ___bgra3, const RuntimeMethod* method) ;
// System.Int32 Dummiesman.TGALoader::GetBits(System.Byte,System.Int32,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t TGALoader_GetBits_mA82EA5A7F1404D4A3B7C0D6B22DC3798BBCA9064 (uint8_t ___b0, int32_t ___offset1, int32_t ___count2, const RuntimeMethod* method) ;
// UnityEngine.Color32 Dummiesman.BinaryExtensions::ReadColor32RGB(System.IO.BinaryReader)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B BinaryExtensions_ReadColor32RGB_m25BA23FD7D871C11D22BF555A7044B96EE501DF9 (BinaryReader_t9A6D85F0FE9AE4EBB5E8D66997DFD1D84939E158* ___r0, const RuntimeMethod* method) ;
// UnityEngine.Color32 Dummiesman.Extensions.ColorExtensions::FlipRB(UnityEngine.Color32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B ColorExtensions_FlipRB_m6593081B4B3A605C5090092E736E12BF9E02B113 (Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B ___color0, const RuntimeMethod* method) ;
// UnityEngine.Color32 Dummiesman.BinaryExtensions::ReadColor32RGBA(System.IO.BinaryReader)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B BinaryExtensions_ReadColor32RGBA_mBD1FED9FE25413CA2E48363DC7B9FB3CF0E799D3 (BinaryReader_t9A6D85F0FE9AE4EBB5E8D66997DFD1D84939E158* ___r0, const RuntimeMethod* method) ;
// System.IO.FileStream System.IO.File::OpenRead(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR FileStream_t07C7222EE10B75F352B89B76E60820160FF10AD8* File_OpenRead_m32C8C37542B7A02A2F643E3B816D16ABE690FF50 (String_t* ___path0, const RuntimeMethod* method) ;
// System.Void System.IO.MemoryStream::.ctor(System.Byte[])
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MemoryStream__ctor_m662CA0D5A0004A2E3B475FE8DCD687B654870AA2 (MemoryStream_tAAED1B42172E3390584E4194308AB878E786AAC2* __this, ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* ___buffer0, const RuntimeMethod* method) ;
// System.Void System.IO.BinaryReader::.ctor(System.IO.Stream)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void BinaryReader__ctor_m898732FE0DBEDD480B24F6DE45A9AC696E44CC0F (BinaryReader_t9A6D85F0FE9AE4EBB5E8D66997DFD1D84939E158* __this, Stream_tF844051B786E8F7F4244DBD218D74E8617B9A2DE* ___input0, const RuntimeMethod* method) ;
// System.String System.String::Format(System.String,System.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* String_Format_m8C122B26BC5AA10E2550AECA16E57DAE10F07E30 (String_t* ___format0, RuntimeObject* ___arg01, const RuntimeMethod* method) ;
// UnityEngine.Color32[] Dummiesman.TGALoader::LoadRawTGAData(System.IO.BinaryReader,System.Int32,System.Int32,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Color32U5BU5D_t38116C3E91765C4C5726CE12C77FAD7F9F737259* TGALoader_LoadRawTGAData_m7A782568D655CD2E36DE9A618B583836EAADAA59 (BinaryReader_t9A6D85F0FE9AE4EBB5E8D66997DFD1D84939E158* ___r0, int32_t ___bitDepth1, int32_t ___width2, int32_t ___height3, const RuntimeMethod* method) ;
// UnityEngine.Color32[] Dummiesman.TGALoader::LoadRLETGAData(System.IO.BinaryReader,System.Int32,System.Int32,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Color32U5BU5D_t38116C3E91765C4C5726CE12C77FAD7F9F737259* TGALoader_LoadRLETGAData_m1E46DBADA3C2691A5543F569E66A6F52EEE2D605 (BinaryReader_t9A6D85F0FE9AE4EBB5E8D66997DFD1D84939E158* ___r0, int32_t ___bitDepth1, int32_t ___width2, int32_t ___height3, const RuntimeMethod* method) ;
// System.Void UnityEngine.Color::.ctor(System.Single,System.Single,System.Single,System.Single)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void Color__ctor_m3786F0D6E510D9CFA544523A955870BD2A514C8C_inline (Color_tD001788D726C3A7F1379BEED0260B9591F440C1F* __this, float ___r0, float ___g1, float ___b2, float ___a3, const RuntimeMethod* method) ;
// System.Void System.Array::Clear(System.Array,System.Int32,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Array_Clear_m48B57EC27CADC3463CA98A33373D557DA587FF1B (RuntimeArray* ___array0, int32_t ___index1, int32_t ___length2, const RuntimeMethod* method) ;
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void Dummiesman.OBJLoader::LoadMaterialLibrary(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void OBJLoader_LoadMaterialLibrary_m8357F62C2EEFD070D141A171260A7247F60BE362 (OBJLoader_tB5927F8DB92B05302380425D21E9BCE654FD66BF* __this, String_t* ___mtlLibPath0, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&MTLLoader_t3B14F27942873DFDE45A9E33A2AD08A49EF1ABBA_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Path_t8A38A801D0219E8209C1B1D90D82D4D755D998BC_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
{
		// if (_objInfo != null)
		FileInfo_t62782BBAFA832A78724E4CF2EE96548B8466AB1C* L_0 = __this->____objInfo_5;
		if (!L_0)
		{
			goto IL_004c;
		}
	}
	{
		// if (File.Exists(Path.Combine(_objInfo.Directory.FullName, mtlLibPath)))
		FileInfo_t62782BBAFA832A78724E4CF2EE96548B8466AB1C* L_1 = __this->____objInfo_5;
		NullCheck(L_1);
		DirectoryInfo_tEAEEC018EB49B4A71907FFEAFE935FAA8F9C1FE2* L_2;
		L_2 = FileInfo_get_Directory_m17FDB04561FFB59BF0EAF22E92A6A8BAD3572EE6(L_1, NULL);
		NullCheck(L_2);
		String_t* L_3;
		L_3 = VirtualFuncInvoker0< String_t* >::Invoke(8 /* System.String System.IO.FileSystemInfo::get_FullName() */, L_2);
		String_t* L_4 = ___mtlLibPath0;
		il2cpp_codegen_runtime_class_init_inline(Path_t8A38A801D0219E8209C1B1D90D82D4D755D998BC_il2cpp_TypeInfo_var);
		String_t* L_5;
		L_5 = Path_Combine_m64754D4E08990CE1EBC41CDF197807EE4B115474(L_3, L_4, NULL);
		bool L_6;
		L_6 = File_Exists_mD7E7A84A6B9E9A9BADBDA7C46AAE0624EF106D85(L_5, NULL);
		if (!L_6)
		{
			goto IL_004c;
		}
	}
	{
		// Materials = new MTLLoader().Load(Path.Combine(_objInfo.Directory.FullName, mtlLibPath));
		MTLLoader_t3B14F27942873DFDE45A9E33A2AD08A49EF1ABBA* L_7 = (MTLLoader_t3B14F27942873DFDE45A9E33A2AD08A49EF1ABBA*)il2cpp_codegen_object_new(MTLLoader_t3B14F27942873DFDE45A9E33A2AD08A49EF1ABBA_il2cpp_TypeInfo_var);
		MTLLoader__ctor_m882454B2FF25BF9544AB016F3F922E549829465D(L_7, /*hidden argument*/NULL);
		FileInfo_t62782BBAFA832A78724E4CF2EE96548B8466AB1C* L_8 = __this->____objInfo_5;
		NullCheck(L_8);
		DirectoryInfo_tEAEEC018EB49B4A71907FFEAFE935FAA8F9C1FE2* L_9;
		L_9 = FileInfo_get_Directory_m17FDB04561FFB59BF0EAF22E92A6A8BAD3572EE6(L_8, NULL);
		NullCheck(L_9);
		String_t* L_10;
		L_10 = VirtualFuncInvoker0< String_t* >::Invoke(8 /* System.String System.IO.FileSystemInfo::get_FullName() */, L_9);
		String_t* L_11 = ___mtlLibPath0;
		il2cpp_codegen_runtime_class_init_inline(Path_t8A38A801D0219E8209C1B1D90D82D4D755D998BC_il2cpp_TypeInfo_var);
		String_t* L_12;
		L_12 = Path_Combine_m64754D4E08990CE1EBC41CDF197807EE4B115474(L_10, L_11, NULL);
		NullCheck(L_7);
		Dictionary_2_t5B255487AF84FB5AB3382296BC4C30734ADE141F* L_13;
		L_13 = MTLLoader_Load_m909F33EEC7F4D0C3891EC7F61B49B0C8ADD8E2E8(L_7, L_12, NULL);
		__this->___Materials_4 = L_13;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___Materials_4), (void*)L_13);
		// return;
		return;
	}

IL_004c:
	{
		// if (File.Exists(mtlLibPath))
		String_t* L_14 = ___mtlLibPath0;
		bool L_15;
		L_15 = File_Exists_mD7E7A84A6B9E9A9BADBDA7C46AAE0624EF106D85(L_14, NULL);
		if (!L_15)
		{
			goto IL_0066;
		}
	}
	{
		// Materials = new MTLLoader().Load(mtlLibPath);
		MTLLoader_t3B14F27942873DFDE45A9E33A2AD08A49EF1ABBA* L_16 = (MTLLoader_t3B14F27942873DFDE45A9E33A2AD08A49EF1ABBA*)il2cpp_codegen_object_new(MTLLoader_t3B14F27942873DFDE45A9E33A2AD08A49EF1ABBA_il2cpp_TypeInfo_var);
		MTLLoader__ctor_m882454B2FF25BF9544AB016F3F922E549829465D(L_16, /*hidden argument*/NULL);
		String_t* L_17 = ___mtlLibPath0;
		NullCheck(L_16);
		Dictionary_2_t5B255487AF84FB5AB3382296BC4C30734ADE141F* L_18;
		L_18 = MTLLoader_Load_m909F33EEC7F4D0C3891EC7F61B49B0C8ADD8E2E8(L_16, L_17, NULL);
		__this->___Materials_4 = L_18;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___Materials_4), (void*)L_18);
		// return;
		return;
	}

IL_0066:
	{
		// }
		return;
	}
}
// UnityEngine.GameObject Dummiesman.OBJLoader::Load(System.IO.Stream)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* OBJLoader_Load_m45AB8465EEB787782E7E71DFF92C10E0782BF4C8 (OBJLoader_tB5927F8DB92B05302380425D21E9BCE654FD66BF* __this, Stream_tF844051B786E8F7F4244DBD218D74E8617B9A2DE* ___input0, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Action_1_Invoke_m690438AAE38F9762172E3AE0A33D0B42ACD35790_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Action_1__ctor_m9DC2953C55C4D7D4B7BEFE03D84DA1F9362D652C_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Action_1_t3CB5D1A819C3ED3F99E9E39F890F18633253949A_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&CharWordReader_t975B8D03A4A3A2152789D6E1D57A51915D45B037_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Dictionary_2_GetEnumerator_m30A75F41A2E01FBA254EA9D604F77CA1E9EBBCA5_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Dictionary_2__ctor_mB2E3E483638E602FE00B68DB9132FA5D5704D11F_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Dictionary_2_tC5A5AFCB8FF4726846814FB45FC66F49C9B0F82A_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Enumerator_Dispose_m20C3A9898BD2C0D50D588257FE9C176D0F748C62_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Enumerator_MoveNext_mA034A5AAF361AFA6ADC0AB189A2408443B767A1D_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Enumerator_get_Current_m0979A8E7E158B0EF6E0CD0B8377E30390074D0FA_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&GameObject_t76FEDD663AB33C991A9C9A23129337651094216F_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&KeyValuePair_2_get_Value_mD180D6D30ED20CC169164BC3EABC7B8455ED0516_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_Add_m0248A96C5334E9A93E6994B7780478BCD994EA3D_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_Add_m79E50C4F592B1703F4B76A8BE7B4855515460CA1_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_Add_mB5FDF069171C4CB1778BFAC3B9015A22EA7DFBCD_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_Clear_mF6795DE5F49C1D0B91D6A0955F448B22970D67A9_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1__ctor_m17F501B5A5C289ECE1B4F3D6EBF05DFA421433F8_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_get_Count_m46EEFFA770BE665EA0CB3A5332E941DA4B3C1D37_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_get_Count_mF1C0C56457C655BDFFC6EE5B46FAD8BAEC1F588B_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Path_t8A38A801D0219E8209C1B1D90D82D4D755D998BC_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&StreamReader_t81027449065C1B0C339DB46241D8001A6F61130B_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&U3CU3Ec__DisplayClass7_0_U3CLoadU3Eb__0_mB7A2836C48583F685E7276DD780FA5A7F2EFBCF7_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&U3CU3Ec__DisplayClass7_0_tB2FCD3BDD4423D7E34A7A4B5547E642A93881A72_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral0B0FEB3147CE20EB2C90076367F895C59BCD14B3);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral10682F3387EA548C626C08591967BD5D821B3ACA);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral2B9B6C84CC15492CCB290C4B79418FA6D7DD24C1);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral2C945D246C2B7897F000E1C591A686EB9EF010F0);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral4B752498CA45AB14E5BD67D359EAE6F257213868);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral6F5EC7239B41C242FCB23B64D91DA0070FC1C044);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral832717F6DAEDB69A0AB5F44CBE008C33CE5DD496);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral91BA0BFEE39A878ED243A61DE051D5D17B6388A0);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral9DFFC3267C5F999585E61B45BA9C8DF18D4B02CA);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralA067DCF7E189AC44F89249565422DE596AC9C3D6);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralFCFD8B76B9829DED087D9E535D4DCC22884C582B);
		s_Il2CppMethodInitialized = true;
	}
U3CU3Ec__DisplayClass7_0_tB2FCD3BDD4423D7E34A7A4B5547E642A93881A72* V_0 = NULL;
	StreamReader_t81027449065C1B0C339DB46241D8001A6F61130B* V_1 = NULL;
	String_t* V_2 = NULL;
	List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73* V_3 = NULL;
	List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73* V_4 = NULL;
	List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73* V_5 = NULL;
	Action_1_t3CB5D1A819C3ED3F99E9E39F890F18633253949A* V_6 = NULL;
	CharWordReader_t975B8D03A4A3A2152789D6E1D57A51915D45B037* V_7 = NULL;
	GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* V_8 = NULL;
	String_t* V_9 = NULL;
	String_t* V_10 = NULL;
	String_t* V_11 = NULL;
	bool V_12 = false;
	int32_t V_13 = 0;
	int32_t V_14 = 0;
	int32_t V_15 = 0;
	Enumerator_t0AE679B39DC9D7D9CE2CF6CCA330D549A945687A V_16;
	memset((&V_16), 0, sizeof(V_16));
	KeyValuePair_2_tD060C533C995F5D1C9F62591EE692E11381464AF V_17;
	memset((&V_17), 0, sizeof(V_17));
	String_t* G_B45_0 = NULL;
	{
		U3CU3Ec__DisplayClass7_0_tB2FCD3BDD4423D7E34A7A4B5547E642A93881A72* L_0 = (U3CU3Ec__DisplayClass7_0_tB2FCD3BDD4423D7E34A7A4B5547E642A93881A72*)il2cpp_codegen_object_new(U3CU3Ec__DisplayClass7_0_tB2FCD3BDD4423D7E34A7A4B5547E642A93881A72_il2cpp_TypeInfo_var);
		U3CU3Ec__DisplayClass7_0__ctor_m8BCD1C1A2D807AAB9450E9565813690455C1B5D2(L_0, /*hidden argument*/NULL);
		V_0 = L_0;
		U3CU3Ec__DisplayClass7_0_tB2FCD3BDD4423D7E34A7A4B5547E642A93881A72* L_1 = V_0;
		NullCheck(L_1);
		L_1->___U3CU3E4__this_2 = __this;
		Il2CppCodeGenWriteBarrier((void**)(&L_1->___U3CU3E4__this_2), (void*)__this);
		// var reader = new StreamReader(input);
		Stream_tF844051B786E8F7F4244DBD218D74E8617B9A2DE* L_2 = ___input0;
		StreamReader_t81027449065C1B0C339DB46241D8001A6F61130B* L_3 = (StreamReader_t81027449065C1B0C339DB46241D8001A6F61130B*)il2cpp_codegen_object_new(StreamReader_t81027449065C1B0C339DB46241D8001A6F61130B_il2cpp_TypeInfo_var);
		StreamReader__ctor_mAFA827D6D825FEC2C29C73B65C2DD1AB9076DEC7(L_3, L_2, /*hidden argument*/NULL);
		V_1 = L_3;
		// Dictionary<string, OBJObjectBuilder> builderDict = new Dictionary<string, OBJObjectBuilder>();
		U3CU3Ec__DisplayClass7_0_tB2FCD3BDD4423D7E34A7A4B5547E642A93881A72* L_4 = V_0;
		Dictionary_2_tC5A5AFCB8FF4726846814FB45FC66F49C9B0F82A* L_5 = (Dictionary_2_tC5A5AFCB8FF4726846814FB45FC66F49C9B0F82A*)il2cpp_codegen_object_new(Dictionary_2_tC5A5AFCB8FF4726846814FB45FC66F49C9B0F82A_il2cpp_TypeInfo_var);
		Dictionary_2__ctor_mB2E3E483638E602FE00B68DB9132FA5D5704D11F(L_5, /*hidden argument*/Dictionary_2__ctor_mB2E3E483638E602FE00B68DB9132FA5D5704D11F_RuntimeMethod_var);
		NullCheck(L_4);
		L_4->___builderDict_0 = L_5;
		Il2CppCodeGenWriteBarrier((void**)(&L_4->___builderDict_0), (void*)L_5);
		// OBJObjectBuilder currentBuilder = null;
		U3CU3Ec__DisplayClass7_0_tB2FCD3BDD4423D7E34A7A4B5547E642A93881A72* L_6 = V_0;
		NullCheck(L_6);
		L_6->___currentBuilder_1 = (OBJObjectBuilder_t0FF6F614A40C0709678B6A0F9111F43397565F13*)NULL;
		Il2CppCodeGenWriteBarrier((void**)(&L_6->___currentBuilder_1), (void*)(OBJObjectBuilder_t0FF6F614A40C0709678B6A0F9111F43397565F13*)NULL);
		// string currentMaterial = "default";
		V_2 = _stringLiteral6F5EC7239B41C242FCB23B64D91DA0070FC1C044;
		// List<int> vertexIndices = new List<int>();
		List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73* L_7 = (List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73*)il2cpp_codegen_object_new(List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73_il2cpp_TypeInfo_var);
		List_1__ctor_m17F501B5A5C289ECE1B4F3D6EBF05DFA421433F8(L_7, /*hidden argument*/List_1__ctor_m17F501B5A5C289ECE1B4F3D6EBF05DFA421433F8_RuntimeMethod_var);
		V_3 = L_7;
		// List<int> normalIndices = new List<int>();
		List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73* L_8 = (List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73*)il2cpp_codegen_object_new(List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73_il2cpp_TypeInfo_var);
		List_1__ctor_m17F501B5A5C289ECE1B4F3D6EBF05DFA421433F8(L_8, /*hidden argument*/List_1__ctor_m17F501B5A5C289ECE1B4F3D6EBF05DFA421433F8_RuntimeMethod_var);
		V_4 = L_8;
		// List<int> uvIndices = new List<int>();
		List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73* L_9 = (List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73*)il2cpp_codegen_object_new(List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73_il2cpp_TypeInfo_var);
		List_1__ctor_m17F501B5A5C289ECE1B4F3D6EBF05DFA421433F8(L_9, /*hidden argument*/List_1__ctor_m17F501B5A5C289ECE1B4F3D6EBF05DFA421433F8_RuntimeMethod_var);
		V_5 = L_9;
		// Action<string> setCurrentObjectFunc = (string objectName) =>
		// {
		//     if (!builderDict.TryGetValue(objectName, out currentBuilder))
		//     {
		//         currentBuilder = new OBJObjectBuilder(objectName, this);
		//         builderDict[objectName] = currentBuilder;
		//     }
		// };
		U3CU3Ec__DisplayClass7_0_tB2FCD3BDD4423D7E34A7A4B5547E642A93881A72* L_10 = V_0;
		Action_1_t3CB5D1A819C3ED3F99E9E39F890F18633253949A* L_11 = (Action_1_t3CB5D1A819C3ED3F99E9E39F890F18633253949A*)il2cpp_codegen_object_new(Action_1_t3CB5D1A819C3ED3F99E9E39F890F18633253949A_il2cpp_TypeInfo_var);
		Action_1__ctor_m9DC2953C55C4D7D4B7BEFE03D84DA1F9362D652C(L_11, L_10, (intptr_t)((void*)U3CU3Ec__DisplayClass7_0_U3CLoadU3Eb__0_mB7A2836C48583F685E7276DD780FA5A7F2EFBCF7_RuntimeMethod_var), /*hidden argument*/Action_1__ctor_m9DC2953C55C4D7D4B7BEFE03D84DA1F9362D652C_RuntimeMethod_var);
		V_6 = L_11;
		// setCurrentObjectFunc.Invoke("default");
		Action_1_t3CB5D1A819C3ED3F99E9E39F890F18633253949A* L_12 = V_6;
		NullCheck(L_12);
		Action_1_Invoke_m690438AAE38F9762172E3AE0A33D0B42ACD35790(L_12, _stringLiteral6F5EC7239B41C242FCB23B64D91DA0070FC1C044, Action_1_Invoke_m690438AAE38F9762172E3AE0A33D0B42ACD35790_RuntimeMethod_var);
		// var buffer = new CharWordReader(reader, 4 * 1024);
		StreamReader_t81027449065C1B0C339DB46241D8001A6F61130B* L_13 = V_1;
		CharWordReader_t975B8D03A4A3A2152789D6E1D57A51915D45B037* L_14 = (CharWordReader_t975B8D03A4A3A2152789D6E1D57A51915D45B037*)il2cpp_codegen_object_new(CharWordReader_t975B8D03A4A3A2152789D6E1D57A51915D45B037_il2cpp_TypeInfo_var);
		CharWordReader__ctor_mC187F26A73B4C4C17AAE6E2CEC05C6BDABC46724(L_14, L_13, ((int32_t)4096), /*hidden argument*/NULL);
		V_7 = L_14;
	}

IL_0067:
	{
		// buffer.SkipWhitespaces();
		CharWordReader_t975B8D03A4A3A2152789D6E1D57A51915D45B037* L_15 = V_7;
		NullCheck(L_15);
		CharWordReader_SkipWhitespaces_m756A369785A22720E078BC048AA7C17C70722FA9(L_15, NULL);
		// if (buffer.endReached == true) {
		CharWordReader_t975B8D03A4A3A2152789D6E1D57A51915D45B037* L_16 = V_7;
		NullCheck(L_16);
		bool L_17 = L_16->___endReached_2;
		if (L_17)
		{
			goto IL_030c;
		}
	}
	{
		// buffer.ReadUntilWhiteSpace();
		CharWordReader_t975B8D03A4A3A2152789D6E1D57A51915D45B037* L_18 = V_7;
		NullCheck(L_18);
		CharWordReader_ReadUntilWhiteSpace_m393DAE0E741589CB7A03D88179E6CBF333586C67(L_18, NULL);
		// if (buffer.Is("#"))
		CharWordReader_t975B8D03A4A3A2152789D6E1D57A51915D45B037* L_19 = V_7;
		NullCheck(L_19);
		bool L_20;
		L_20 = CharWordReader_Is_m3BECD455B5467165843C7AC55DC0C596515BE6DD(L_19, _stringLiteral0B0FEB3147CE20EB2C90076367F895C59BCD14B3, NULL);
		if (!L_20)
		{
			goto IL_0098;
		}
	}
	{
		// buffer.SkipUntilNewLine();
		CharWordReader_t975B8D03A4A3A2152789D6E1D57A51915D45B037* L_21 = V_7;
		NullCheck(L_21);
		CharWordReader_SkipUntilNewLine_mC871D424BAF642A45B0CDB6A034CF09AC697A6DF(L_21, NULL);
		// continue;
		goto IL_0067;
	}

IL_0098:
	{
		// if (Materials == null && buffer.Is("mtllib")) {
		Dictionary_2_t5B255487AF84FB5AB3382296BC4C30734ADE141F* L_22 = __this->___Materials_4;
		if (L_22)
		{
			goto IL_00d0;
		}
	}
	{
		CharWordReader_t975B8D03A4A3A2152789D6E1D57A51915D45B037* L_23 = V_7;
		NullCheck(L_23);
		bool L_24;
		L_24 = CharWordReader_Is_m3BECD455B5467165843C7AC55DC0C596515BE6DD(L_23, _stringLiteral91BA0BFEE39A878ED243A61DE051D5D17B6388A0, NULL);
		if (!L_24)
		{
			goto IL_00d0;
		}
	}
	{
		// buffer.SkipWhitespaces();
		CharWordReader_t975B8D03A4A3A2152789D6E1D57A51915D45B037* L_25 = V_7;
		NullCheck(L_25);
		CharWordReader_SkipWhitespaces_m756A369785A22720E078BC048AA7C17C70722FA9(L_25, NULL);
		// buffer.ReadUntilNewLine();
		CharWordReader_t975B8D03A4A3A2152789D6E1D57A51915D45B037* L_26 = V_7;
		NullCheck(L_26);
		CharWordReader_ReadUntilNewLine_mEDD63FA77CAB776D16A7C6E4FA10A7249790B07A(L_26, NULL);
		// string mtlLibPath = buffer.GetString();
		CharWordReader_t975B8D03A4A3A2152789D6E1D57A51915D45B037* L_27 = V_7;
		NullCheck(L_27);
		String_t* L_28;
		L_28 = CharWordReader_GetString_m3B839DB592A5992C2238FE41B683EB5EF02637C3(L_27, 0, NULL);
		V_9 = L_28;
		// LoadMaterialLibrary(mtlLibPath);
		String_t* L_29 = V_9;
		OBJLoader_LoadMaterialLibrary_m8357F62C2EEFD070D141A171260A7247F60BE362(__this, L_29, NULL);
		// continue;
		goto IL_0067;
	}

IL_00d0:
	{
		// if (buffer.Is("v")) {
		CharWordReader_t975B8D03A4A3A2152789D6E1D57A51915D45B037* L_30 = V_7;
		NullCheck(L_30);
		bool L_31;
		L_31 = CharWordReader_Is_m3BECD455B5467165843C7AC55DC0C596515BE6DD(L_30, _stringLiteral9DFFC3267C5F999585E61B45BA9C8DF18D4B02CA, NULL);
		if (!L_31)
		{
			goto IL_00f5;
		}
	}
	{
		// Vertices.Add(buffer.ReadVector());
		List_1_t77B94703E05C519A9010DD0614F757F974E1CD8B* L_32 = __this->___Vertices_1;
		CharWordReader_t975B8D03A4A3A2152789D6E1D57A51915D45B037* L_33 = V_7;
		NullCheck(L_33);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_34;
		L_34 = CharWordReader_ReadVector_m265198F266F731E96CE23C5C0D9037FE402273FF(L_33, NULL);
		NullCheck(L_32);
		List_1_Add_m79E50C4F592B1703F4B76A8BE7B4855515460CA1_inline(L_32, L_34, List_1_Add_m79E50C4F592B1703F4B76A8BE7B4855515460CA1_RuntimeMethod_var);
		// continue;
		goto IL_0067;
	}

IL_00f5:
	{
		// if (buffer.Is("vn")) {
		CharWordReader_t975B8D03A4A3A2152789D6E1D57A51915D45B037* L_35 = V_7;
		NullCheck(L_35);
		bool L_36;
		L_36 = CharWordReader_Is_m3BECD455B5467165843C7AC55DC0C596515BE6DD(L_35, _stringLiteralA067DCF7E189AC44F89249565422DE596AC9C3D6, NULL);
		if (!L_36)
		{
			goto IL_011a;
		}
	}
	{
		// Normals.Add(buffer.ReadVector());
		List_1_t77B94703E05C519A9010DD0614F757F974E1CD8B* L_37 = __this->___Normals_2;
		CharWordReader_t975B8D03A4A3A2152789D6E1D57A51915D45B037* L_38 = V_7;
		NullCheck(L_38);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_39;
		L_39 = CharWordReader_ReadVector_m265198F266F731E96CE23C5C0D9037FE402273FF(L_38, NULL);
		NullCheck(L_37);
		List_1_Add_m79E50C4F592B1703F4B76A8BE7B4855515460CA1_inline(L_37, L_39, List_1_Add_m79E50C4F592B1703F4B76A8BE7B4855515460CA1_RuntimeMethod_var);
		// continue;
		goto IL_0067;
	}

IL_011a:
	{
		// if (buffer.Is("vt")) {
		CharWordReader_t975B8D03A4A3A2152789D6E1D57A51915D45B037* L_40 = V_7;
		NullCheck(L_40);
		bool L_41;
		L_41 = CharWordReader_Is_m3BECD455B5467165843C7AC55DC0C596515BE6DD(L_40, _stringLiteral4B752498CA45AB14E5BD67D359EAE6F257213868, NULL);
		if (!L_41)
		{
			goto IL_0144;
		}
	}
	{
		// UVs.Add(buffer.ReadVector());
		List_1_t8F3790B7F8C471B3A1336522C7415FB0AC36D47B* L_42 = __this->___UVs_3;
		CharWordReader_t975B8D03A4A3A2152789D6E1D57A51915D45B037* L_43 = V_7;
		NullCheck(L_43);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_44;
		L_44 = CharWordReader_ReadVector_m265198F266F731E96CE23C5C0D9037FE402273FF(L_43, NULL);
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_45;
		L_45 = Vector2_op_Implicit_m8F73B300CB4E6F9B4EB5FB6130363D76CEAA230B_inline(L_44, NULL);
		NullCheck(L_42);
		List_1_Add_mB5FDF069171C4CB1778BFAC3B9015A22EA7DFBCD_inline(L_42, L_45, List_1_Add_mB5FDF069171C4CB1778BFAC3B9015A22EA7DFBCD_RuntimeMethod_var);
		// continue;
		goto IL_0067;
	}

IL_0144:
	{
		// if (buffer.Is("usemtl")) {
		CharWordReader_t975B8D03A4A3A2152789D6E1D57A51915D45B037* L_46 = V_7;
		NullCheck(L_46);
		bool L_47;
		L_47 = CharWordReader_Is_m3BECD455B5467165843C7AC55DC0C596515BE6DD(L_46, _stringLiteral832717F6DAEDB69A0AB5F44CBE008C33CE5DD496, NULL);
		if (!L_47)
		{
			goto IL_0187;
		}
	}
	{
		// buffer.SkipWhitespaces();
		CharWordReader_t975B8D03A4A3A2152789D6E1D57A51915D45B037* L_48 = V_7;
		NullCheck(L_48);
		CharWordReader_SkipWhitespaces_m756A369785A22720E078BC048AA7C17C70722FA9(L_48, NULL);
		// buffer.ReadUntilNewLine();
		CharWordReader_t975B8D03A4A3A2152789D6E1D57A51915D45B037* L_49 = V_7;
		NullCheck(L_49);
		CharWordReader_ReadUntilNewLine_mEDD63FA77CAB776D16A7C6E4FA10A7249790B07A(L_49, NULL);
		// string materialName = buffer.GetString();
		CharWordReader_t975B8D03A4A3A2152789D6E1D57A51915D45B037* L_50 = V_7;
		NullCheck(L_50);
		String_t* L_51;
		L_51 = CharWordReader_GetString_m3B839DB592A5992C2238FE41B683EB5EF02637C3(L_50, 0, NULL);
		V_10 = L_51;
		// currentMaterial = materialName;
		String_t* L_52 = V_10;
		V_2 = L_52;
		// if(SplitMode == SplitMode.Material)
		int32_t L_53 = __this->___SplitMode_0;
		if ((!(((uint32_t)L_53) == ((uint32_t)2))))
		{
			goto IL_0067;
		}
	}
	{
		// setCurrentObjectFunc.Invoke(materialName);
		Action_1_t3CB5D1A819C3ED3F99E9E39F890F18633253949A* L_54 = V_6;
		String_t* L_55 = V_10;
		NullCheck(L_54);
		Action_1_Invoke_m690438AAE38F9762172E3AE0A33D0B42ACD35790(L_54, L_55, Action_1_Invoke_m690438AAE38F9762172E3AE0A33D0B42ACD35790_RuntimeMethod_var);
		// continue;
		goto IL_0067;
	}

IL_0187:
	{
		// if ((buffer.Is("o") || buffer.Is("g")) && SplitMode == SplitMode.Object) {
		CharWordReader_t975B8D03A4A3A2152789D6E1D57A51915D45B037* L_56 = V_7;
		NullCheck(L_56);
		bool L_57;
		L_57 = CharWordReader_Is_m3BECD455B5467165843C7AC55DC0C596515BE6DD(L_56, _stringLiteral10682F3387EA548C626C08591967BD5D821B3ACA, NULL);
		if (L_57)
		{
			goto IL_01a3;
		}
	}
	{
		CharWordReader_t975B8D03A4A3A2152789D6E1D57A51915D45B037* L_58 = V_7;
		NullCheck(L_58);
		bool L_59;
		L_59 = CharWordReader_Is_m3BECD455B5467165843C7AC55DC0C596515BE6DD(L_58, _stringLiteral2B9B6C84CC15492CCB290C4B79418FA6D7DD24C1, NULL);
		if (!L_59)
		{
			goto IL_01cb;
		}
	}

IL_01a3:
	{
		int32_t L_60 = __this->___SplitMode_0;
		if ((!(((uint32_t)L_60) == ((uint32_t)1))))
		{
			goto IL_01cb;
		}
	}
	{
		// buffer.ReadUntilNewLine();
		CharWordReader_t975B8D03A4A3A2152789D6E1D57A51915D45B037* L_61 = V_7;
		NullCheck(L_61);
		CharWordReader_ReadUntilNewLine_mEDD63FA77CAB776D16A7C6E4FA10A7249790B07A(L_61, NULL);
		// string objectName = buffer.GetString(1);
		CharWordReader_t975B8D03A4A3A2152789D6E1D57A51915D45B037* L_62 = V_7;
		NullCheck(L_62);
		String_t* L_63;
		L_63 = CharWordReader_GetString_m3B839DB592A5992C2238FE41B683EB5EF02637C3(L_62, 1, NULL);
		V_11 = L_63;
		// setCurrentObjectFunc.Invoke(objectName);
		Action_1_t3CB5D1A819C3ED3F99E9E39F890F18633253949A* L_64 = V_6;
		String_t* L_65 = V_11;
		NullCheck(L_64);
		Action_1_Invoke_m690438AAE38F9762172E3AE0A33D0B42ACD35790(L_64, L_65, Action_1_Invoke_m690438AAE38F9762172E3AE0A33D0B42ACD35790_RuntimeMethod_var);
		// continue;
		goto IL_0067;
	}

IL_01cb:
	{
		// if (buffer.Is("f"))
		CharWordReader_t975B8D03A4A3A2152789D6E1D57A51915D45B037* L_66 = V_7;
		NullCheck(L_66);
		bool L_67;
		L_67 = CharWordReader_Is_m3BECD455B5467165843C7AC55DC0C596515BE6DD(L_66, _stringLiteral2C945D246C2B7897F000E1C591A686EB9EF010F0, NULL);
		if (!L_67)
		{
			goto IL_0300;
		}
	}

IL_01dc:
	{
		// buffer.SkipWhitespaces(out newLinePassed);
		CharWordReader_t975B8D03A4A3A2152789D6E1D57A51915D45B037* L_68 = V_7;
		NullCheck(L_68);
		CharWordReader_SkipWhitespaces_m55CA1F56FFFF49CE8E147CF45AA78D2B66920B5E(L_68, (&V_12), NULL);
		// if (newLinePassed == true) {
		bool L_69 = V_12;
		if (L_69)
		{
			goto IL_02d6;
		}
	}
	{
		// int vertexIndex = int.MinValue;
		V_13 = ((int32_t)-2147483648LL);
		// int normalIndex = int.MinValue;
		V_14 = ((int32_t)-2147483648LL);
		// int uvIndex = int.MinValue;
		V_15 = ((int32_t)-2147483648LL);
		// vertexIndex = buffer.ReadInt();
		CharWordReader_t975B8D03A4A3A2152789D6E1D57A51915D45B037* L_70 = V_7;
		NullCheck(L_70);
		int32_t L_71;
		L_71 = CharWordReader_ReadInt_mCCB951F11A7FCB0C3522C67F4A74332DDE4DB1A0(L_70, NULL);
		V_13 = L_71;
		// if (buffer.currentChar == '/') {
		CharWordReader_t975B8D03A4A3A2152789D6E1D57A51915D45B037* L_72 = V_7;
		NullCheck(L_72);
		Il2CppChar L_73 = L_72->___currentChar_6;
		if ((!(((uint32_t)L_73) == ((uint32_t)((int32_t)47)))))
		{
			goto IL_024b;
		}
	}
	{
		// buffer.MoveNext();
		CharWordReader_t975B8D03A4A3A2152789D6E1D57A51915D45B037* L_74 = V_7;
		NullCheck(L_74);
		CharWordReader_MoveNext_m9E8BAD502F7F23337F0B4C3EC4E126C164539606(L_74, NULL);
		// if (buffer.currentChar != '/') {
		CharWordReader_t975B8D03A4A3A2152789D6E1D57A51915D45B037* L_75 = V_7;
		NullCheck(L_75);
		Il2CppChar L_76 = L_75->___currentChar_6;
		if ((((int32_t)L_76) == ((int32_t)((int32_t)47))))
		{
			goto IL_0230;
		}
	}
	{
		// uvIndex = buffer.ReadInt();
		CharWordReader_t975B8D03A4A3A2152789D6E1D57A51915D45B037* L_77 = V_7;
		NullCheck(L_77);
		int32_t L_78;
		L_78 = CharWordReader_ReadInt_mCCB951F11A7FCB0C3522C67F4A74332DDE4DB1A0(L_77, NULL);
		V_15 = L_78;
	}

IL_0230:
	{
		// if (buffer.currentChar == '/') {
		CharWordReader_t975B8D03A4A3A2152789D6E1D57A51915D45B037* L_79 = V_7;
		NullCheck(L_79);
		Il2CppChar L_80 = L_79->___currentChar_6;
		if ((!(((uint32_t)L_80) == ((uint32_t)((int32_t)47)))))
		{
			goto IL_024b;
		}
	}
	{
		// buffer.MoveNext();
		CharWordReader_t975B8D03A4A3A2152789D6E1D57A51915D45B037* L_81 = V_7;
		NullCheck(L_81);
		CharWordReader_MoveNext_m9E8BAD502F7F23337F0B4C3EC4E126C164539606(L_81, NULL);
		// normalIndex = buffer.ReadInt();
		CharWordReader_t975B8D03A4A3A2152789D6E1D57A51915D45B037* L_82 = V_7;
		NullCheck(L_82);
		int32_t L_83;
		L_83 = CharWordReader_ReadInt_mCCB951F11A7FCB0C3522C67F4A74332DDE4DB1A0(L_82, NULL);
		V_14 = L_83;
	}

IL_024b:
	{
		// if (vertexIndex > int.MinValue)
		int32_t L_84 = V_13;
		if ((((int32_t)L_84) <= ((int32_t)((int32_t)-2147483648LL))))
		{
			goto IL_026f;
		}
	}
	{
		// if (vertexIndex < 0)
		int32_t L_85 = V_13;
		if ((((int32_t)L_85) >= ((int32_t)0)))
		{
			goto IL_0269;
		}
	}
	{
		// vertexIndex = Vertices.Count - vertexIndex;
		List_1_t77B94703E05C519A9010DD0614F757F974E1CD8B* L_86 = __this->___Vertices_1;
		NullCheck(L_86);
		int32_t L_87;
		L_87 = List_1_get_Count_m46EEFFA770BE665EA0CB3A5332E941DA4B3C1D37_inline(L_86, List_1_get_Count_m46EEFFA770BE665EA0CB3A5332E941DA4B3C1D37_RuntimeMethod_var);
		int32_t L_88 = V_13;
		V_13 = ((int32_t)il2cpp_codegen_subtract(L_87, L_88));
	}

IL_0269:
	{
		// vertexIndex--;
		int32_t L_89 = V_13;
		V_13 = ((int32_t)il2cpp_codegen_subtract(L_89, 1));
	}

IL_026f:
	{
		// if (normalIndex > int.MinValue)
		int32_t L_90 = V_14;
		if ((((int32_t)L_90) <= ((int32_t)((int32_t)-2147483648LL))))
		{
			goto IL_0293;
		}
	}
	{
		// if (normalIndex < 0)
		int32_t L_91 = V_14;
		if ((((int32_t)L_91) >= ((int32_t)0)))
		{
			goto IL_028d;
		}
	}
	{
		// normalIndex = Normals.Count - normalIndex;
		List_1_t77B94703E05C519A9010DD0614F757F974E1CD8B* L_92 = __this->___Normals_2;
		NullCheck(L_92);
		int32_t L_93;
		L_93 = List_1_get_Count_m46EEFFA770BE665EA0CB3A5332E941DA4B3C1D37_inline(L_92, List_1_get_Count_m46EEFFA770BE665EA0CB3A5332E941DA4B3C1D37_RuntimeMethod_var);
		int32_t L_94 = V_14;
		V_14 = ((int32_t)il2cpp_codegen_subtract(L_93, L_94));
	}

IL_028d:
	{
		// normalIndex--;
		int32_t L_95 = V_14;
		V_14 = ((int32_t)il2cpp_codegen_subtract(L_95, 1));
	}

IL_0293:
	{
		// if (uvIndex > int.MinValue)
		int32_t L_96 = V_15;
		if ((((int32_t)L_96) <= ((int32_t)((int32_t)-2147483648LL))))
		{
			goto IL_02b7;
		}
	}
	{
		// if (uvIndex < 0)
		int32_t L_97 = V_15;
		if ((((int32_t)L_97) >= ((int32_t)0)))
		{
			goto IL_02b1;
		}
	}
	{
		// uvIndex = UVs.Count - uvIndex;
		List_1_t8F3790B7F8C471B3A1336522C7415FB0AC36D47B* L_98 = __this->___UVs_3;
		NullCheck(L_98);
		int32_t L_99;
		L_99 = List_1_get_Count_mF1C0C56457C655BDFFC6EE5B46FAD8BAEC1F588B_inline(L_98, List_1_get_Count_mF1C0C56457C655BDFFC6EE5B46FAD8BAEC1F588B_RuntimeMethod_var);
		int32_t L_100 = V_15;
		V_15 = ((int32_t)il2cpp_codegen_subtract(L_99, L_100));
	}

IL_02b1:
	{
		// uvIndex--;
		int32_t L_101 = V_15;
		V_15 = ((int32_t)il2cpp_codegen_subtract(L_101, 1));
	}

IL_02b7:
	{
		// vertexIndices.Add(vertexIndex);
		List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73* L_102 = V_3;
		int32_t L_103 = V_13;
		NullCheck(L_102);
		List_1_Add_m0248A96C5334E9A93E6994B7780478BCD994EA3D_inline(L_102, L_103, List_1_Add_m0248A96C5334E9A93E6994B7780478BCD994EA3D_RuntimeMethod_var);
		// normalIndices.Add(normalIndex);
		List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73* L_104 = V_4;
		int32_t L_105 = V_14;
		NullCheck(L_104);
		List_1_Add_m0248A96C5334E9A93E6994B7780478BCD994EA3D_inline(L_104, L_105, List_1_Add_m0248A96C5334E9A93E6994B7780478BCD994EA3D_RuntimeMethod_var);
		// uvIndices.Add(uvIndex);
		List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73* L_106 = V_5;
		int32_t L_107 = V_15;
		NullCheck(L_106);
		List_1_Add_m0248A96C5334E9A93E6994B7780478BCD994EA3D_inline(L_106, L_107, List_1_Add_m0248A96C5334E9A93E6994B7780478BCD994EA3D_RuntimeMethod_var);
		// while (true)
		goto IL_01dc;
	}

IL_02d6:
	{
		// currentBuilder.PushFace(currentMaterial, vertexIndices, normalIndices, uvIndices);
		U3CU3Ec__DisplayClass7_0_tB2FCD3BDD4423D7E34A7A4B5547E642A93881A72* L_108 = V_0;
		NullCheck(L_108);
		OBJObjectBuilder_t0FF6F614A40C0709678B6A0F9111F43397565F13* L_109 = L_108->___currentBuilder_1;
		String_t* L_110 = V_2;
		List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73* L_111 = V_3;
		List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73* L_112 = V_4;
		List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73* L_113 = V_5;
		NullCheck(L_109);
		OBJObjectBuilder_PushFace_mEB8693BC3E91FBC712492DD2570C540D89DD1213(L_109, L_110, L_111, L_112, L_113, NULL);
		// vertexIndices.Clear();
		List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73* L_114 = V_3;
		NullCheck(L_114);
		List_1_Clear_mF6795DE5F49C1D0B91D6A0955F448B22970D67A9_inline(L_114, List_1_Clear_mF6795DE5F49C1D0B91D6A0955F448B22970D67A9_RuntimeMethod_var);
		// normalIndices.Clear();
		List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73* L_115 = V_4;
		NullCheck(L_115);
		List_1_Clear_mF6795DE5F49C1D0B91D6A0955F448B22970D67A9_inline(L_115, List_1_Clear_mF6795DE5F49C1D0B91D6A0955F448B22970D67A9_RuntimeMethod_var);
		// uvIndices.Clear();
		List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73* L_116 = V_5;
		NullCheck(L_116);
		List_1_Clear_mF6795DE5F49C1D0B91D6A0955F448B22970D67A9_inline(L_116, List_1_Clear_mF6795DE5F49C1D0B91D6A0955F448B22970D67A9_RuntimeMethod_var);
		// continue;
		goto IL_0067;
	}

IL_0300:
	{
		// buffer.SkipUntilNewLine();
		CharWordReader_t975B8D03A4A3A2152789D6E1D57A51915D45B037* L_117 = V_7;
		NullCheck(L_117);
		CharWordReader_SkipUntilNewLine_mC871D424BAF642A45B0CDB6A034CF09AC697A6DF(L_117, NULL);
		// while (true)
		goto IL_0067;
	}

IL_030c:
	{
		// GameObject obj = new GameObject(_objInfo != null ? Path.GetFileNameWithoutExtension(_objInfo.Name) : "WavefrontObject");
		FileInfo_t62782BBAFA832A78724E4CF2EE96548B8466AB1C* L_118 = __this->____objInfo_5;
		if (L_118)
		{
			goto IL_031b;
		}
	}
	{
		G_B45_0 = _stringLiteralFCFD8B76B9829DED087D9E535D4DCC22884C582B;
		goto IL_032b;
	}

IL_031b:
	{
		FileInfo_t62782BBAFA832A78724E4CF2EE96548B8466AB1C* L_119 = __this->____objInfo_5;
		NullCheck(L_119);
		String_t* L_120;
		L_120 = VirtualFuncInvoker0< String_t* >::Invoke(9 /* System.String System.IO.FileSystemInfo::get_Name() */, L_119);
		il2cpp_codegen_runtime_class_init_inline(Path_t8A38A801D0219E8209C1B1D90D82D4D755D998BC_il2cpp_TypeInfo_var);
		String_t* L_121;
		L_121 = Path_GetFileNameWithoutExtension_mD24A7CA7C45FF7A265EF7F8D5E19D1F3C014D90F(L_120, NULL);
		G_B45_0 = L_121;
	}

IL_032b:
	{
		GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* L_122 = (GameObject_t76FEDD663AB33C991A9C9A23129337651094216F*)il2cpp_codegen_object_new(GameObject_t76FEDD663AB33C991A9C9A23129337651094216F_il2cpp_TypeInfo_var);
		GameObject__ctor_m37D512B05D292F954792225E6C6EEE95293A9B88(L_122, G_B45_0, /*hidden argument*/NULL);
		V_8 = L_122;
		// obj.transform.localScale = new Vector3(-1f, 1f, 1f);
		GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* L_123 = V_8;
		NullCheck(L_123);
		Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* L_124;
		L_124 = GameObject_get_transform_m0BC10ADFA1632166AE5544BDF9038A2650C2AE56(L_123, NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_125;
		memset((&L_125), 0, sizeof(L_125));
		Vector3__ctor_m376936E6B999EF1ECBE57D990A386303E2283DE0_inline((&L_125), (-1.0f), (1.0f), (1.0f), /*hidden argument*/NULL);
		NullCheck(L_124);
		Transform_set_localScale_mBA79E811BAF6C47B80FF76414C12B47B3CD03633(L_124, L_125, NULL);
		// foreach (var builder in builderDict)
		U3CU3Ec__DisplayClass7_0_tB2FCD3BDD4423D7E34A7A4B5547E642A93881A72* L_126 = V_0;
		NullCheck(L_126);
		Dictionary_2_tC5A5AFCB8FF4726846814FB45FC66F49C9B0F82A* L_127 = L_126->___builderDict_0;
		NullCheck(L_127);
		Enumerator_t0AE679B39DC9D7D9CE2CF6CCA330D549A945687A L_128;
		L_128 = Dictionary_2_GetEnumerator_m30A75F41A2E01FBA254EA9D604F77CA1E9EBBCA5(L_127, Dictionary_2_GetEnumerator_m30A75F41A2E01FBA254EA9D604F77CA1E9EBBCA5_RuntimeMethod_var);
		V_16 = L_128;
	}

IL_035f:
	{
		auto __finallyBlock = il2cpp::utils::Finally([&]
		{

FINALLY_03a1:
			{// begin finally (depth: 1)
				Enumerator_Dispose_m20C3A9898BD2C0D50D588257FE9C176D0F748C62((&V_16), Enumerator_Dispose_m20C3A9898BD2C0D50D588257FE9C176D0F748C62_RuntimeMethod_var);
				return;
			}// end finally (depth: 1)
		});
		try
		{// begin try (depth: 1)
			{
				goto IL_0396;
			}

IL_0361:
			{
				// foreach (var builder in builderDict)
				KeyValuePair_2_tD060C533C995F5D1C9F62591EE692E11381464AF L_129;
				L_129 = Enumerator_get_Current_m0979A8E7E158B0EF6E0CD0B8377E30390074D0FA_inline((&V_16), Enumerator_get_Current_m0979A8E7E158B0EF6E0CD0B8377E30390074D0FA_RuntimeMethod_var);
				V_17 = L_129;
				// if (builder.Value.PushedFaceCount == 0)
				OBJObjectBuilder_t0FF6F614A40C0709678B6A0F9111F43397565F13* L_130;
				L_130 = KeyValuePair_2_get_Value_mD180D6D30ED20CC169164BC3EABC7B8455ED0516_inline((&V_17), KeyValuePair_2_get_Value_mD180D6D30ED20CC169164BC3EABC7B8455ED0516_RuntimeMethod_var);
				NullCheck(L_130);
				int32_t L_131;
				L_131 = OBJObjectBuilder_get_PushedFaceCount_m0800BDEDCCE5D0006D125DE33878F032D415366E_inline(L_130, NULL);
				if (!L_131)
				{
					goto IL_0396;
				}
			}

IL_0378:
			{
				// var builtObj = builder.Value.Build();
				OBJObjectBuilder_t0FF6F614A40C0709678B6A0F9111F43397565F13* L_132;
				L_132 = KeyValuePair_2_get_Value_mD180D6D30ED20CC169164BC3EABC7B8455ED0516_inline((&V_17), KeyValuePair_2_get_Value_mD180D6D30ED20CC169164BC3EABC7B8455ED0516_RuntimeMethod_var);
				NullCheck(L_132);
				GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* L_133;
				L_133 = OBJObjectBuilder_Build_mA827E9316CA93D1CD7AAEBC13B9CED3FE362F556(L_132, NULL);
				// builtObj.transform.SetParent(obj.transform, false);
				NullCheck(L_133);
				Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* L_134;
				L_134 = GameObject_get_transform_m0BC10ADFA1632166AE5544BDF9038A2650C2AE56(L_133, NULL);
				GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* L_135 = V_8;
				NullCheck(L_135);
				Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* L_136;
				L_136 = GameObject_get_transform_m0BC10ADFA1632166AE5544BDF9038A2650C2AE56(L_135, NULL);
				NullCheck(L_134);
				Transform_SetParent_m9BDD7B7476714B2D7919B10BDC22CE75C0A0A195(L_134, L_136, (bool)0, NULL);
			}

IL_0396:
			{
				// foreach (var builder in builderDict)
				bool L_137;
				L_137 = Enumerator_MoveNext_mA034A5AAF361AFA6ADC0AB189A2408443B767A1D((&V_16), Enumerator_MoveNext_mA034A5AAF361AFA6ADC0AB189A2408443B767A1D_RuntimeMethod_var);
				if (L_137)
				{
					goto IL_0361;
				}
			}

IL_039f:
			{
				goto IL_03af;
			}
		}// end try (depth: 1)
		catch(Il2CppExceptionWrapper& e)
		{
			__finallyBlock.StoreException(e.ex);
		}
	}

IL_03af:
	{
		// return obj;
		GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* L_138 = V_8;
		return L_138;
	}
}
// UnityEngine.GameObject Dummiesman.OBJLoader::Load(System.IO.Stream,System.IO.Stream)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* OBJLoader_Load_m1294CEA6C40701C66FCE4FA443ACD66C6AC1FC9E (OBJLoader_tB5927F8DB92B05302380425D21E9BCE654FD66BF* __this, Stream_tF844051B786E8F7F4244DBD218D74E8617B9A2DE* ___input0, Stream_tF844051B786E8F7F4244DBD218D74E8617B9A2DE* ___mtlInput1, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&MTLLoader_t3B14F27942873DFDE45A9E33A2AD08A49EF1ABBA_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
MTLLoader_t3B14F27942873DFDE45A9E33A2AD08A49EF1ABBA* V_0 = NULL;
	{
		// var mtlLoader = new MTLLoader();
		MTLLoader_t3B14F27942873DFDE45A9E33A2AD08A49EF1ABBA* L_0 = (MTLLoader_t3B14F27942873DFDE45A9E33A2AD08A49EF1ABBA*)il2cpp_codegen_object_new(MTLLoader_t3B14F27942873DFDE45A9E33A2AD08A49EF1ABBA_il2cpp_TypeInfo_var);
		MTLLoader__ctor_m882454B2FF25BF9544AB016F3F922E549829465D(L_0, /*hidden argument*/NULL);
		V_0 = L_0;
		// Materials = mtlLoader.Load(mtlInput);
		MTLLoader_t3B14F27942873DFDE45A9E33A2AD08A49EF1ABBA* L_1 = V_0;
		Stream_tF844051B786E8F7F4244DBD218D74E8617B9A2DE* L_2 = ___mtlInput1;
		NullCheck(L_1);
		Dictionary_2_t5B255487AF84FB5AB3382296BC4C30734ADE141F* L_3;
		L_3 = MTLLoader_Load_m1A0963CCA9C78D58FEBC2ABD4C75F56F0407BA6C(L_1, L_2, NULL);
		__this->___Materials_4 = L_3;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___Materials_4), (void*)L_3);
		// return Load(input);
		Stream_tF844051B786E8F7F4244DBD218D74E8617B9A2DE* L_4 = ___input0;
		GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* L_5;
		L_5 = OBJLoader_Load_m45AB8465EEB787782E7E71DFF92C10E0782BF4C8(__this, L_4, NULL);
		return L_5;
	}
}
// UnityEngine.GameObject Dummiesman.OBJLoader::Load(System.String,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* OBJLoader_Load_mFA6018F459FF559B8877A9B3AE70E2D6BCF54DC0 (OBJLoader_tB5927F8DB92B05302380425D21E9BCE654FD66BF* __this, String_t* ___path0, String_t* ___mtlPath1, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&FileInfo_t62782BBAFA832A78724E4CF2EE96548B8466AB1C_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&FileStream_t07C7222EE10B75F352B89B76E60820160FF10AD8_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IDisposable_t030E0496B4E0E4E4F086825007979AF51F7248C5_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&MTLLoader_t3B14F27942873DFDE45A9E33A2AD08A49EF1ABBA_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
MTLLoader_t3B14F27942873DFDE45A9E33A2AD08A49EF1ABBA* V_0 = NULL;
	FileStream_t07C7222EE10B75F352B89B76E60820160FF10AD8* V_1 = NULL;
	GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* V_2 = NULL;
	FileStream_t07C7222EE10B75F352B89B76E60820160FF10AD8* V_3 = NULL;
	{
		// _objInfo = new FileInfo(path);
		String_t* L_0 = ___path0;
		FileInfo_t62782BBAFA832A78724E4CF2EE96548B8466AB1C* L_1 = (FileInfo_t62782BBAFA832A78724E4CF2EE96548B8466AB1C*)il2cpp_codegen_object_new(FileInfo_t62782BBAFA832A78724E4CF2EE96548B8466AB1C_il2cpp_TypeInfo_var);
		FileInfo__ctor_m0A602529DFCFC44BB4EF4C530E6FBA765C44143F(L_1, L_0, /*hidden argument*/NULL);
		__this->____objInfo_5 = L_1;
		Il2CppCodeGenWriteBarrier((void**)(&__this->____objInfo_5), (void*)L_1);
		// if (!string.IsNullOrEmpty(mtlPath) && File.Exists(mtlPath))
		String_t* L_2 = ___mtlPath1;
		bool L_3;
		L_3 = String_IsNullOrEmpty_m54CF0907E7C4F3AFB2E796A13DC751ECBB8DB64A(L_2, NULL);
		if (L_3)
		{
			goto IL_004b;
		}
	}
	{
		String_t* L_4 = ___mtlPath1;
		bool L_5;
		L_5 = File_Exists_mD7E7A84A6B9E9A9BADBDA7C46AAE0624EF106D85(L_4, NULL);
		if (!L_5)
		{
			goto IL_004b;
		}
	}
	{
		// var mtlLoader = new MTLLoader();
		MTLLoader_t3B14F27942873DFDE45A9E33A2AD08A49EF1ABBA* L_6 = (MTLLoader_t3B14F27942873DFDE45A9E33A2AD08A49EF1ABBA*)il2cpp_codegen_object_new(MTLLoader_t3B14F27942873DFDE45A9E33A2AD08A49EF1ABBA_il2cpp_TypeInfo_var);
		MTLLoader__ctor_m882454B2FF25BF9544AB016F3F922E549829465D(L_6, /*hidden argument*/NULL);
		V_0 = L_6;
		// Materials = mtlLoader.Load(mtlPath);
		MTLLoader_t3B14F27942873DFDE45A9E33A2AD08A49EF1ABBA* L_7 = V_0;
		String_t* L_8 = ___mtlPath1;
		NullCheck(L_7);
		Dictionary_2_t5B255487AF84FB5AB3382296BC4C30734ADE141F* L_9;
		L_9 = MTLLoader_Load_m909F33EEC7F4D0C3891EC7F61B49B0C8ADD8E2E8(L_7, L_8, NULL);
		__this->___Materials_4 = L_9;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___Materials_4), (void*)L_9);
		// using (var fs = new FileStream(path, FileMode.Open))
		String_t* L_10 = ___path0;
		FileStream_t07C7222EE10B75F352B89B76E60820160FF10AD8* L_11 = (FileStream_t07C7222EE10B75F352B89B76E60820160FF10AD8*)il2cpp_codegen_object_new(FileStream_t07C7222EE10B75F352B89B76E60820160FF10AD8_il2cpp_TypeInfo_var);
		FileStream__ctor_m78499F9BE2BE31DA34F123B4399AA457716BD6E6(L_11, L_10, 3, /*hidden argument*/NULL);
		V_1 = L_11;
	}

IL_0037:
	{
		auto __finallyBlock = il2cpp::utils::Finally([&]
		{

FINALLY_0041:
			{// begin finally (depth: 1)
				{
					FileStream_t07C7222EE10B75F352B89B76E60820160FF10AD8* L_12 = V_1;
					if (!L_12)
					{
						goto IL_004a;
					}
				}

IL_0044:
				{
					FileStream_t07C7222EE10B75F352B89B76E60820160FF10AD8* L_13 = V_1;
					NullCheck(L_13);
					InterfaceActionInvoker0::Invoke(0 /* System.Void System.IDisposable::Dispose() */, IDisposable_t030E0496B4E0E4E4F086825007979AF51F7248C5_il2cpp_TypeInfo_var, L_13);
				}

IL_004a:
				{
					return;
				}
			}// end finally (depth: 1)
		});
		try
		{// begin try (depth: 1)
			// return Load(fs);
			FileStream_t07C7222EE10B75F352B89B76E60820160FF10AD8* L_14 = V_1;
			GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* L_15;
			L_15 = OBJLoader_Load_m45AB8465EEB787782E7E71DFF92C10E0782BF4C8(__this, L_14, NULL);
			V_2 = L_15;
			goto IL_0067;
		}// end try (depth: 1)
		catch(Il2CppExceptionWrapper& e)
		{
			__finallyBlock.StoreException(e.ex);
		}
	}

IL_004b:
	{
		// using (var fs = new FileStream(path, FileMode.Open))
		String_t* L_16 = ___path0;
		FileStream_t07C7222EE10B75F352B89B76E60820160FF10AD8* L_17 = (FileStream_t07C7222EE10B75F352B89B76E60820160FF10AD8*)il2cpp_codegen_object_new(FileStream_t07C7222EE10B75F352B89B76E60820160FF10AD8_il2cpp_TypeInfo_var);
		FileStream__ctor_m78499F9BE2BE31DA34F123B4399AA457716BD6E6(L_17, L_16, 3, /*hidden argument*/NULL);
		V_3 = L_17;
	}

IL_0053:
	{
		auto __finallyBlock = il2cpp::utils::Finally([&]
		{

FINALLY_005d:
			{// begin finally (depth: 1)
				{
					FileStream_t07C7222EE10B75F352B89B76E60820160FF10AD8* L_18 = V_3;
					if (!L_18)
					{
						goto IL_0066;
					}
				}

IL_0060:
				{
					FileStream_t07C7222EE10B75F352B89B76E60820160FF10AD8* L_19 = V_3;
					NullCheck(L_19);
					InterfaceActionInvoker0::Invoke(0 /* System.Void System.IDisposable::Dispose() */, IDisposable_t030E0496B4E0E4E4F086825007979AF51F7248C5_il2cpp_TypeInfo_var, L_19);
				}

IL_0066:
				{
					return;
				}
			}// end finally (depth: 1)
		});
		try
		{// begin try (depth: 1)
			// return Load(fs);
			FileStream_t07C7222EE10B75F352B89B76E60820160FF10AD8* L_20 = V_3;
			GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* L_21;
			L_21 = OBJLoader_Load_m45AB8465EEB787782E7E71DFF92C10E0782BF4C8(__this, L_20, NULL);
			V_2 = L_21;
			goto IL_0067;
		}// end try (depth: 1)
		catch(Il2CppExceptionWrapper& e)
		{
			__finallyBlock.StoreException(e.ex);
		}
	}

IL_0067:
	{
		// }
		GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* L_22 = V_2;
		return L_22;
	}
}
// UnityEngine.GameObject Dummiesman.OBJLoader::Load(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* OBJLoader_Load_m79EC26500388A2500CB43B28637DBCA6002736D5 (OBJLoader_tB5927F8DB92B05302380425D21E9BCE654FD66BF* __this, String_t* ___path0, const RuntimeMethod* method) 
{
{
		// return Load(path, null);
		String_t* L_0 = ___path0;
		GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* L_1;
		L_1 = OBJLoader_Load_mFA6018F459FF559B8877A9B3AE70E2D6BCF54DC0(__this, L_0, (String_t*)NULL, NULL);
		return L_1;
	}
}
// System.Void Dummiesman.OBJLoader::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void OBJLoader__ctor_mB59B4FA09B4E3BA7C410C7601390343EA356E684 (OBJLoader_tB5927F8DB92B05302380425D21E9BCE654FD66BF* __this, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1__ctor_m88C4BD8AC607DB3585552068F4DC437406358D5F_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1__ctor_mC54E2BCBE43279A96FC082F5CDE2D76388BD8F9C_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_t77B94703E05C519A9010DD0614F757F974E1CD8B_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_t8F3790B7F8C471B3A1336522C7415FB0AC36D47B_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
{
		// public SplitMode SplitMode = SplitMode.Object;
		__this->___SplitMode_0 = 1;
		// internal List<Vector3> Vertices = new List<Vector3>();
		List_1_t77B94703E05C519A9010DD0614F757F974E1CD8B* L_0 = (List_1_t77B94703E05C519A9010DD0614F757F974E1CD8B*)il2cpp_codegen_object_new(List_1_t77B94703E05C519A9010DD0614F757F974E1CD8B_il2cpp_TypeInfo_var);
		List_1__ctor_mC54E2BCBE43279A96FC082F5CDE2D76388BD8F9C(L_0, /*hidden argument*/List_1__ctor_mC54E2BCBE43279A96FC082F5CDE2D76388BD8F9C_RuntimeMethod_var);
		__this->___Vertices_1 = L_0;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___Vertices_1), (void*)L_0);
		// internal List<Vector3> Normals = new List<Vector3>();
		List_1_t77B94703E05C519A9010DD0614F757F974E1CD8B* L_1 = (List_1_t77B94703E05C519A9010DD0614F757F974E1CD8B*)il2cpp_codegen_object_new(List_1_t77B94703E05C519A9010DD0614F757F974E1CD8B_il2cpp_TypeInfo_var);
		List_1__ctor_mC54E2BCBE43279A96FC082F5CDE2D76388BD8F9C(L_1, /*hidden argument*/List_1__ctor_mC54E2BCBE43279A96FC082F5CDE2D76388BD8F9C_RuntimeMethod_var);
		__this->___Normals_2 = L_1;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___Normals_2), (void*)L_1);
		// internal List<Vector2> UVs = new List<Vector2>();
		List_1_t8F3790B7F8C471B3A1336522C7415FB0AC36D47B* L_2 = (List_1_t8F3790B7F8C471B3A1336522C7415FB0AC36D47B*)il2cpp_codegen_object_new(List_1_t8F3790B7F8C471B3A1336522C7415FB0AC36D47B_il2cpp_TypeInfo_var);
		List_1__ctor_m88C4BD8AC607DB3585552068F4DC437406358D5F(L_2, /*hidden argument*/List_1__ctor_m88C4BD8AC607DB3585552068F4DC437406358D5F_RuntimeMethod_var);
		__this->___UVs_3 = L_2;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___UVs_3), (void*)L_2);
		Object__ctor_mE837C6B9FA8C6D5D109F4B2EC885D79919AC0EA2(__this, NULL);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void Dummiesman.OBJLoader/<>c__DisplayClass7_0::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CU3Ec__DisplayClass7_0__ctor_m8BCD1C1A2D807AAB9450E9565813690455C1B5D2 (U3CU3Ec__DisplayClass7_0_tB2FCD3BDD4423D7E34A7A4B5547E642A93881A72* __this, const RuntimeMethod* method) 
{
{
		Object__ctor_mE837C6B9FA8C6D5D109F4B2EC885D79919AC0EA2(__this, NULL);
		return;
	}
}
// System.Void Dummiesman.OBJLoader/<>c__DisplayClass7_0::<Load>b__0(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CU3Ec__DisplayClass7_0_U3CLoadU3Eb__0_mB7A2836C48583F685E7276DD780FA5A7F2EFBCF7 (U3CU3Ec__DisplayClass7_0_tB2FCD3BDD4423D7E34A7A4B5547E642A93881A72* __this, String_t* ___objectName0, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Dictionary_2_TryGetValue_m0C13BB2CCCC84DFF397E1F1708A35D6B855E83D3_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Dictionary_2_set_Item_m829F1D3D238D6C188AE5440AC46680D7F3B66304_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&OBJObjectBuilder_t0FF6F614A40C0709678B6A0F9111F43397565F13_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
{
		// if (!builderDict.TryGetValue(objectName, out currentBuilder))
		Dictionary_2_tC5A5AFCB8FF4726846814FB45FC66F49C9B0F82A* L_0 = __this->___builderDict_0;
		String_t* L_1 = ___objectName0;
		OBJObjectBuilder_t0FF6F614A40C0709678B6A0F9111F43397565F13** L_2 = (&__this->___currentBuilder_1);
		NullCheck(L_0);
		bool L_3;
		L_3 = Dictionary_2_TryGetValue_m0C13BB2CCCC84DFF397E1F1708A35D6B855E83D3(L_0, L_1, L_2, Dictionary_2_TryGetValue_m0C13BB2CCCC84DFF397E1F1708A35D6B855E83D3_RuntimeMethod_var);
		if (L_3)
		{
			goto IL_0038;
		}
	}
	{
		// currentBuilder = new OBJObjectBuilder(objectName, this);
		String_t* L_4 = ___objectName0;
		OBJLoader_tB5927F8DB92B05302380425D21E9BCE654FD66BF* L_5 = __this->___U3CU3E4__this_2;
		OBJObjectBuilder_t0FF6F614A40C0709678B6A0F9111F43397565F13* L_6 = (OBJObjectBuilder_t0FF6F614A40C0709678B6A0F9111F43397565F13*)il2cpp_codegen_object_new(OBJObjectBuilder_t0FF6F614A40C0709678B6A0F9111F43397565F13_il2cpp_TypeInfo_var);
		OBJObjectBuilder__ctor_m559A7FFA399AEF65D8C9649F8122F554E3222ABB(L_6, L_4, L_5, /*hidden argument*/NULL);
		__this->___currentBuilder_1 = L_6;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___currentBuilder_1), (void*)L_6);
		// builderDict[objectName] = currentBuilder;
		Dictionary_2_tC5A5AFCB8FF4726846814FB45FC66F49C9B0F82A* L_7 = __this->___builderDict_0;
		String_t* L_8 = ___objectName0;
		OBJObjectBuilder_t0FF6F614A40C0709678B6A0F9111F43397565F13* L_9 = __this->___currentBuilder_1;
		NullCheck(L_7);
		Dictionary_2_set_Item_m829F1D3D238D6C188AE5440AC46680D7F3B66304(L_7, L_8, L_9, Dictionary_2_set_Item_m829F1D3D238D6C188AE5440AC46680D7F3B66304_RuntimeMethod_var);
	}

IL_0038:
	{
		// };
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void Dummiesman.OBJLoaderHelper::EnableMaterialTransparency(UnityEngine.Material)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void OBJLoaderHelper_EnableMaterialTransparency_m21886B2A525D549AF7EC1A151FCAD64CE4987FE0 (Material_t18053F08F347D0DCA5E1140EC7EC4533DD8A14E3* ___mtl0, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral3708CDBCC9F390AB99D52FE7DEE4724401B69B9F);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral52CBE4A5A42509939BB9DB58A4B9A2C9BBA81C1C);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral61304A4D1A7F7C3C856F975F251F1F79885933C8);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral73B13DE9817379145386BC6ECC87E983FC8ED41A);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral7D61FA9D9BE7581D7E2EE28C775ABE0D4B8C3D69);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralB25CF1C6B74339FBFCE846454A70688CE58C094C);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralCBCD3D866AF896F9B010A0FEE7F961DBC91A08C5);
		s_Il2CppMethodInitialized = true;
	}
{
		// mtl.SetFloat("_Mode", 3f);
		Material_t18053F08F347D0DCA5E1140EC7EC4533DD8A14E3* L_0 = ___mtl0;
		NullCheck(L_0);
		Material_SetFloat_m879CF81D740BAE6F23C9822400679F4D16365836(L_0, _stringLiteral7D61FA9D9BE7581D7E2EE28C775ABE0D4B8C3D69, (3.0f), NULL);
		// mtl.SetInt("_SrcBlend", (int)UnityEngine.Rendering.BlendMode.SrcAlpha);
		Material_t18053F08F347D0DCA5E1140EC7EC4533DD8A14E3* L_1 = ___mtl0;
		NullCheck(L_1);
		Material_SetInt_m41DF5404A9942239265888105E1DC83F2FBF901A(L_1, _stringLiteral3708CDBCC9F390AB99D52FE7DEE4724401B69B9F, 5, NULL);
		// mtl.SetInt("_DstBlend", (int)UnityEngine.Rendering.BlendMode.OneMinusSrcAlpha);
		Material_t18053F08F347D0DCA5E1140EC7EC4533DD8A14E3* L_2 = ___mtl0;
		NullCheck(L_2);
		Material_SetInt_m41DF5404A9942239265888105E1DC83F2FBF901A(L_2, _stringLiteral73B13DE9817379145386BC6ECC87E983FC8ED41A, ((int32_t)10), NULL);
		// mtl.SetInt("_ZWrite", 0);
		Material_t18053F08F347D0DCA5E1140EC7EC4533DD8A14E3* L_3 = ___mtl0;
		NullCheck(L_3);
		Material_SetInt_m41DF5404A9942239265888105E1DC83F2FBF901A(L_3, _stringLiteralB25CF1C6B74339FBFCE846454A70688CE58C094C, 0, NULL);
		// mtl.DisableKeyword("_ALPHATEST_ON");
		Material_t18053F08F347D0DCA5E1140EC7EC4533DD8A14E3* L_4 = ___mtl0;
		NullCheck(L_4);
		Material_DisableKeyword_mC123927EBF2F2A19220A4456C8EA19F2BA416E8C(L_4, _stringLiteralCBCD3D866AF896F9B010A0FEE7F961DBC91A08C5, NULL);
		// mtl.EnableKeyword("_ALPHABLEND_ON");
		Material_t18053F08F347D0DCA5E1140EC7EC4533DD8A14E3* L_5 = ___mtl0;
		NullCheck(L_5);
		Material_EnableKeyword_mE8523EF6CF694284DF976D47ADEDE9363A1174AC(L_5, _stringLiteral52CBE4A5A42509939BB9DB58A4B9A2C9BBA81C1C, NULL);
		// mtl.DisableKeyword("_ALPHAPREMULTIPLY_ON");
		Material_t18053F08F347D0DCA5E1140EC7EC4533DD8A14E3* L_6 = ___mtl0;
		NullCheck(L_6);
		Material_DisableKeyword_mC123927EBF2F2A19220A4456C8EA19F2BA416E8C(L_6, _stringLiteral61304A4D1A7F7C3C856F975F251F1F79885933C8, NULL);
		// mtl.renderQueue = 3000;
		Material_t18053F08F347D0DCA5E1140EC7EC4533DD8A14E3* L_7 = ___mtl0;
		NullCheck(L_7);
		Material_set_renderQueue_mFBB72A781DCCF0D4B85670B597788EC2D02D1C14(L_7, ((int32_t)3000), NULL);
		// }
		return;
	}
}
// System.Single Dummiesman.OBJLoaderHelper::FastFloatParse(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float OBJLoaderHelper_FastFloatParse_mA831C3685B456D7493658947983B62E61AF86F99 (String_t* ___input0, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&CultureInfo_t9BA817D41AD55AC8BD07480DD8AC22F8FFA378E0_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral36282FAC116D9FD6B37CC425310E1A8510F08A53);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral579A50C67ADB00AC3925859C23590322B2D0BE9D);
		s_Il2CppMethodInitialized = true;
	}
float V_0 = 0.0f;
	int32_t V_1 = 0;
	int32_t V_2 = 0;
	Il2CppChar V_3 = 0x0;
	float V_4 = 0.0f;
	float V_5 = 0.0f;
	{
		// if (input.Contains("e") || input.Contains("E"))
		String_t* L_0 = ___input0;
		NullCheck(L_0);
		bool L_1;
		L_1 = String_Contains_m6D77B121FADA7CA5F397C0FABB65DA62DF03B6C3(L_0, _stringLiteral36282FAC116D9FD6B37CC425310E1A8510F08A53, NULL);
		if (L_1)
		{
			goto IL_001a;
		}
	}
	{
		String_t* L_2 = ___input0;
		NullCheck(L_2);
		bool L_3;
		L_3 = String_Contains_m6D77B121FADA7CA5F397C0FABB65DA62DF03B6C3(L_2, _stringLiteral579A50C67ADB00AC3925859C23590322B2D0BE9D, NULL);
		if (!L_3)
		{
			goto IL_0026;
		}
	}

IL_001a:
	{
		// return float.Parse(input, CultureInfo.InvariantCulture);
		String_t* L_4 = ___input0;
		il2cpp_codegen_runtime_class_init_inline(CultureInfo_t9BA817D41AD55AC8BD07480DD8AC22F8FFA378E0_il2cpp_TypeInfo_var);
		CultureInfo_t9BA817D41AD55AC8BD07480DD8AC22F8FFA378E0* L_5;
		L_5 = CultureInfo_get_InvariantCulture_m78DAB8CBE8766445310782B6E61FB7A9983AD425(NULL);
		float L_6;
		L_6 = Single_Parse_m4CCF536F9DA447D8822618DF5C6F8F31494B2909(L_4, L_5, NULL);
		return L_6;
	}

IL_0026:
	{
		// float result = 0;
		V_0 = (0.0f);
		// int pos = 0;
		V_1 = 0;
		// int len = input.Length;
		String_t* L_7 = ___input0;
		NullCheck(L_7);
		int32_t L_8;
		L_8 = String_get_Length_m42625D67623FA5CC7A44D47425CE86FB946542D2_inline(L_7, NULL);
		V_2 = L_8;
		// if (len == 0) return float.NaN;
		int32_t L_9 = V_2;
		if (L_9)
		{
			goto IL_003e;
		}
	}
	{
		// if (len == 0) return float.NaN;
		return (std::numeric_limits<float>::quiet_NaN());
	}

IL_003e:
	{
		// char c = input[0];
		String_t* L_10 = ___input0;
		NullCheck(L_10);
		Il2CppChar L_11;
		L_11 = String_get_Chars_mC49DF0CD2D3BE7BE97B3AD9C995BE3094F8E36D3(L_10, 0, NULL);
		V_3 = L_11;
		// float sign = 1;
		V_4 = (1.0f);
		// if (c == '-')
		Il2CppChar L_12 = V_3;
		if ((!(((uint32_t)L_12) == ((uint32_t)((int32_t)45)))))
		{
			goto IL_0067;
		}
	}
	{
		// sign = -1;
		V_4 = (-1.0f);
		// ++pos;
		int32_t L_13 = V_1;
		V_1 = ((int32_t)il2cpp_codegen_add(L_13, 1));
		// if (pos >= len) return float.NaN;
		int32_t L_14 = V_1;
		int32_t L_15 = V_2;
		if ((((int32_t)L_14) < ((int32_t)L_15)))
		{
			goto IL_0067;
		}
	}
	{
		// if (pos >= len) return float.NaN;
		return (std::numeric_limits<float>::quiet_NaN());
	}

IL_0067:
	{
		// if (pos >= len) return sign * result;
		int32_t L_16 = V_1;
		int32_t L_17 = V_2;
		if ((((int32_t)L_16) < ((int32_t)L_17)))
		{
			goto IL_0070;
		}
	}
	{
		// if (pos >= len) return sign * result;
		float L_18 = V_4;
		float L_19 = V_0;
		return ((float)il2cpp_codegen_multiply(L_18, L_19));
	}

IL_0070:
	{
		// c = input[pos++];
		String_t* L_20 = ___input0;
		int32_t L_21 = V_1;
		int32_t L_22 = L_21;
		V_1 = ((int32_t)il2cpp_codegen_add(L_22, 1));
		NullCheck(L_20);
		Il2CppChar L_23;
		L_23 = String_get_Chars_mC49DF0CD2D3BE7BE97B3AD9C995BE3094F8E36D3(L_20, L_22, NULL);
		V_3 = L_23;
		// if (c < '0' || c > '9') break;
		Il2CppChar L_24 = V_3;
		if ((((int32_t)L_24) < ((int32_t)((int32_t)48))))
		{
			goto IL_0096;
		}
	}
	{
		Il2CppChar L_25 = V_3;
		if ((((int32_t)L_25) > ((int32_t)((int32_t)57))))
		{
			goto IL_0096;
		}
	}
	{
		// result = (result * 10.0f) + (c - '0');
		float L_26 = V_0;
		Il2CppChar L_27 = V_3;
		V_0 = ((float)il2cpp_codegen_add(((float)il2cpp_codegen_multiply(L_26, (10.0f))), ((float)((int32_t)il2cpp_codegen_subtract((int32_t)L_27, ((int32_t)48))))));
		// while (true) // breaks inside on pos >= len or non-digit character
		goto IL_0067;
	}

IL_0096:
	{
		// if (c != '.' && c != ',') return float.NaN;
		Il2CppChar L_28 = V_3;
		if ((((int32_t)L_28) == ((int32_t)((int32_t)46))))
		{
			goto IL_00a6;
		}
	}
	{
		Il2CppChar L_29 = V_3;
		if ((((int32_t)L_29) == ((int32_t)((int32_t)44))))
		{
			goto IL_00a6;
		}
	}
	{
		// if (c != '.' && c != ',') return float.NaN;
		return (std::numeric_limits<float>::quiet_NaN());
	}

IL_00a6:
	{
		// float exp = 0.1f;
		V_5 = (0.100000001f);
		goto IL_00e0;
	}

IL_00af:
	{
		// c = input[pos++];
		String_t* L_30 = ___input0;
		int32_t L_31 = V_1;
		int32_t L_32 = L_31;
		V_1 = ((int32_t)il2cpp_codegen_add(L_32, 1));
		NullCheck(L_30);
		Il2CppChar L_33;
		L_33 = String_get_Chars_mC49DF0CD2D3BE7BE97B3AD9C995BE3094F8E36D3(L_30, L_32, NULL);
		V_3 = L_33;
		// if (c < '0' || c > '9') return float.NaN;
		Il2CppChar L_34 = V_3;
		if ((((int32_t)L_34) < ((int32_t)((int32_t)48))))
		{
			goto IL_00c5;
		}
	}
	{
		Il2CppChar L_35 = V_3;
		if ((((int32_t)L_35) <= ((int32_t)((int32_t)57))))
		{
			goto IL_00cb;
		}
	}

IL_00c5:
	{
		// if (c < '0' || c > '9') return float.NaN;
		return (std::numeric_limits<float>::quiet_NaN());
	}

IL_00cb:
	{
		// result += (c - '0') * exp;
		float L_36 = V_0;
		Il2CppChar L_37 = V_3;
		float L_38 = V_5;
		V_0 = ((float)il2cpp_codegen_add(L_36, ((float)il2cpp_codegen_multiply(((float)((int32_t)il2cpp_codegen_subtract((int32_t)L_37, ((int32_t)48)))), L_38))));
		// exp *= 0.1f;
		float L_39 = V_5;
		V_5 = ((float)il2cpp_codegen_multiply(L_39, (0.100000001f)));
	}

IL_00e0:
	{
		// while (pos < len)
		int32_t L_40 = V_1;
		int32_t L_41 = V_2;
		if ((((int32_t)L_40) < ((int32_t)L_41)))
		{
			goto IL_00af;
		}
	}
	{
		// return sign * result;
		float L_42 = V_4;
		float L_43 = V_0;
		return ((float)il2cpp_codegen_multiply(L_42, L_43));
	}
}
// System.Int32 Dummiesman.OBJLoaderHelper::FastIntParse(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t OBJLoaderHelper_FastIntParse_m52F2F645A4917E5AF99BBDEF45C22741E1C972AA (String_t* ___input0, const RuntimeMethod* method) 
{
int32_t V_0 = 0;
	bool V_1 = false;
	int32_t V_2 = 0;
	int32_t G_B3_0 = 0;
	{
		// int result = 0;
		V_0 = 0;
		// bool isNegative = (input[0] == '-');
		String_t* L_0 = ___input0;
		NullCheck(L_0);
		Il2CppChar L_1;
		L_1 = String_get_Chars_mC49DF0CD2D3BE7BE97B3AD9C995BE3094F8E36D3(L_0, 0, NULL);
		V_1 = (bool)((((int32_t)L_1) == ((int32_t)((int32_t)45)))? 1 : 0);
		// for (int i = (isNegative) ? 1 : 0; i < input.Length; i++)
		bool L_2 = V_1;
		if (L_2)
		{
			goto IL_0014;
		}
	}
	{
		G_B3_0 = 0;
		goto IL_0015;
	}

IL_0014:
	{
		G_B3_0 = 1;
	}

IL_0015:
	{
		V_2 = G_B3_0;
		goto IL_002c;
	}

IL_0018:
	{
		// result = result * 10 + (input[i] - '0');
		int32_t L_3 = V_0;
		String_t* L_4 = ___input0;
		int32_t L_5 = V_2;
		NullCheck(L_4);
		Il2CppChar L_6;
		L_6 = String_get_Chars_mC49DF0CD2D3BE7BE97B3AD9C995BE3094F8E36D3(L_4, L_5, NULL);
		V_0 = ((int32_t)il2cpp_codegen_add(((int32_t)il2cpp_codegen_multiply(L_3, ((int32_t)10))), ((int32_t)il2cpp_codegen_subtract((int32_t)L_6, ((int32_t)48)))));
		// for (int i = (isNegative) ? 1 : 0; i < input.Length; i++)
		int32_t L_7 = V_2;
		V_2 = ((int32_t)il2cpp_codegen_add(L_7, 1));
	}

IL_002c:
	{
		// for (int i = (isNegative) ? 1 : 0; i < input.Length; i++)
		int32_t L_8 = V_2;
		String_t* L_9 = ___input0;
		NullCheck(L_9);
		int32_t L_10;
		L_10 = String_get_Length_m42625D67623FA5CC7A44D47425CE86FB946542D2_inline(L_9, NULL);
		if ((((int32_t)L_8) < ((int32_t)L_10)))
		{
			goto IL_0018;
		}
	}
	{
		// return (isNegative) ? -result : result;
		bool L_11 = V_1;
		if (L_11)
		{
			goto IL_003a;
		}
	}
	{
		int32_t L_12 = V_0;
		return L_12;
	}

IL_003a:
	{
		int32_t L_13 = V_0;
		return ((-L_13));
	}
}
// UnityEngine.Material Dummiesman.OBJLoaderHelper::CreateNullMaterial()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Material_t18053F08F347D0DCA5E1140EC7EC4533DD8A14E3* OBJLoaderHelper_CreateNullMaterial_m08CCF4F5500BB7553CEF31A5F1444147F829170B (const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Material_t18053F08F347D0DCA5E1140EC7EC4533DD8A14E3_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralA2B5208CBD672BD56D417E00B07619D4FDBBD0C2);
		s_Il2CppMethodInitialized = true;
	}
{
		// return new Material(Shader.Find("Standard (Specular setup)"));
		Shader_tADC867D36B7876EE22427FAA2CE485105F4EE692* L_0;
		L_0 = Shader_Find_mFF2A8FC042B9CFAA9800679CA674D52859BF3A72(_stringLiteralA2B5208CBD672BD56D417E00B07619D4FDBBD0C2, NULL);
		Material_t18053F08F347D0DCA5E1140EC7EC4533DD8A14E3* L_1 = (Material_t18053F08F347D0DCA5E1140EC7EC4533DD8A14E3*)il2cpp_codegen_object_new(Material_t18053F08F347D0DCA5E1140EC7EC4533DD8A14E3_il2cpp_TypeInfo_var);
		Material__ctor_m7FDF47105D66D19591BE505A0C42B0F90D88C9BF(L_1, L_0, /*hidden argument*/NULL);
		return L_1;
	}
}
// UnityEngine.Vector3 Dummiesman.OBJLoaderHelper::VectorFromStrArray(System.String[])
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 OBJLoaderHelper_VectorFromStrArray_mF65586922C88623CE29A428466CC4C9DF7F4FE95 (StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248* ___cmps0, const RuntimeMethod* method) 
{
float V_0 = 0.0f;
	float V_1 = 0.0f;
	float V_2 = 0.0f;
	{
		// float x = FastFloatParse(cmps[1]);
		StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248* L_0 = ___cmps0;
		NullCheck(L_0);
		int32_t L_1 = 1;
		String_t* L_2 = (L_0)->GetAt(static_cast<il2cpp_array_size_t>(L_1));
		float L_3;
		L_3 = OBJLoaderHelper_FastFloatParse_mA831C3685B456D7493658947983B62E61AF86F99(L_2, NULL);
		V_0 = L_3;
		// float y = FastFloatParse(cmps[2]);
		StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248* L_4 = ___cmps0;
		NullCheck(L_4);
		int32_t L_5 = 2;
		String_t* L_6 = (L_4)->GetAt(static_cast<il2cpp_array_size_t>(L_5));
		float L_7;
		L_7 = OBJLoaderHelper_FastFloatParse_mA831C3685B456D7493658947983B62E61AF86F99(L_6, NULL);
		V_1 = L_7;
		// if (cmps.Length == 4)
		StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248* L_8 = ___cmps0;
		NullCheck(L_8);
		if ((!(((uint32_t)((int32_t)(((RuntimeArray*)L_8)->max_length))) == ((uint32_t)4))))
		{
			goto IL_002a;
		}
	}
	{
		// float z = FastFloatParse(cmps[3]);
		StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248* L_9 = ___cmps0;
		NullCheck(L_9);
		int32_t L_10 = 3;
		String_t* L_11 = (L_9)->GetAt(static_cast<il2cpp_array_size_t>(L_10));
		float L_12;
		L_12 = OBJLoaderHelper_FastFloatParse_mA831C3685B456D7493658947983B62E61AF86F99(L_11, NULL);
		V_2 = L_12;
		// return new Vector3(x, y, z);
		float L_13 = V_0;
		float L_14 = V_1;
		float L_15 = V_2;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_16;
		memset((&L_16), 0, sizeof(L_16));
		Vector3__ctor_m376936E6B999EF1ECBE57D990A386303E2283DE0_inline((&L_16), L_13, L_14, L_15, /*hidden argument*/NULL);
		return L_16;
	}

IL_002a:
	{
		// return new Vector2(x, y);
		float L_17 = V_0;
		float L_18 = V_1;
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_19;
		memset((&L_19), 0, sizeof(L_19));
		Vector2__ctor_m9525B79969AFFE3254B303A40997A56DEEB6F548_inline((&L_19), L_17, L_18, /*hidden argument*/NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_20;
		L_20 = Vector2_op_Implicit_mCD214B04BC52AED3C89C3BEF664B6247E5F8954A_inline(L_19, NULL);
		return L_20;
	}
}
// UnityEngine.Color Dummiesman.OBJLoaderHelper::ColorFromStrArray(System.String[],System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Color_tD001788D726C3A7F1379BEED0260B9591F440C1F OBJLoaderHelper_ColorFromStrArray_m0F00862FEAD1F96B9C5F5DE7DBEFE596E4C07430 (StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248* ___cmps0, float ___scalar1, const RuntimeMethod* method) 
{
float V_0 = 0.0f;
	float V_1 = 0.0f;
	{
		// float Kr = FastFloatParse(cmps[1]) * scalar;
		StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248* L_0 = ___cmps0;
		NullCheck(L_0);
		int32_t L_1 = 1;
		String_t* L_2 = (L_0)->GetAt(static_cast<il2cpp_array_size_t>(L_1));
		float L_3;
		L_3 = OBJLoaderHelper_FastFloatParse_mA831C3685B456D7493658947983B62E61AF86F99(L_2, NULL);
		float L_4 = ___scalar1;
		// float Kg = FastFloatParse(cmps[2]) * scalar;
		StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248* L_5 = ___cmps0;
		NullCheck(L_5);
		int32_t L_6 = 2;
		String_t* L_7 = (L_5)->GetAt(static_cast<il2cpp_array_size_t>(L_6));
		float L_8;
		L_8 = OBJLoaderHelper_FastFloatParse_mA831C3685B456D7493658947983B62E61AF86F99(L_7, NULL);
		float L_9 = ___scalar1;
		V_0 = ((float)il2cpp_codegen_multiply(L_8, L_9));
		// float Kb = FastFloatParse(cmps[3]) * scalar;
		StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248* L_10 = ___cmps0;
		NullCheck(L_10);
		int32_t L_11 = 3;
		String_t* L_12 = (L_10)->GetAt(static_cast<il2cpp_array_size_t>(L_11));
		float L_13;
		L_13 = OBJLoaderHelper_FastFloatParse_mA831C3685B456D7493658947983B62E61AF86F99(L_12, NULL);
		float L_14 = ___scalar1;
		V_1 = ((float)il2cpp_codegen_multiply(L_13, L_14));
		// return new Color(Kr, Kg, Kb);
		float L_15 = V_0;
		float L_16 = V_1;
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_17;
		memset((&L_17), 0, sizeof(L_17));
		Color__ctor_mCD6889CDE39F18704CD6EA8E2EFBFA48BA3E13B0_inline((&L_17), ((float)il2cpp_codegen_multiply(L_3, L_4)), L_15, L_16, /*hidden argument*/NULL);
		return L_17;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Int32 Dummiesman.OBJObjectBuilder::get_PushedFaceCount()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t OBJObjectBuilder_get_PushedFaceCount_m0800BDEDCCE5D0006D125DE33878F032D415366E (OBJObjectBuilder_t0FF6F614A40C0709678B6A0F9111F43397565F13* __this, const RuntimeMethod* method) 
{
{
		// public int PushedFaceCount { get; private set; } = 0;
		int32_t L_0 = __this->___U3CPushedFaceCountU3Ek__BackingField_0;
		return L_0;
	}
}
// System.Void Dummiesman.OBJObjectBuilder::set_PushedFaceCount(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void OBJObjectBuilder_set_PushedFaceCount_m59B64D90A70C329BAB9F7E36961ED9C4D23744D8 (OBJObjectBuilder_t0FF6F614A40C0709678B6A0F9111F43397565F13* __this, int32_t ___value0, const RuntimeMethod* method) 
{
{
		// public int PushedFaceCount { get; private set; } = 0;
		int32_t L_0 = ___value0;
		__this->___U3CPushedFaceCountU3Ek__BackingField_0 = L_0;
		return;
	}
}
// UnityEngine.GameObject Dummiesman.OBJObjectBuilder::Build()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* OBJObjectBuilder_Build_mA827E9316CA93D1CD7AAEBC13B9CED3FE362F556 (OBJObjectBuilder_t0FF6F614A40C0709678B6A0F9111F43397565F13* __this, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Dictionary_2_GetEnumerator_m2E9E4B0E50E5FBA0C7E62ACEAD7A0327267C4C2E_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Dictionary_2_TryGetValue_mFD7867D61B454D815AFE71D04D27540FAFBFF091_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Dictionary_2_get_Count_m831221DAC53C65F38539F4A37520985E8DC557AF_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Dictionary_2_set_Item_m2712E92CF36B85D20B01493D39F2BD4504C0BE7B_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Enumerator_Dispose_m1ED4783F9B383A3AAA727AA5F6241652CEDF91FF_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Enumerator_MoveNext_m6F709DC1AED45A132D5B2CE5C6912F4FB3BA6872_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Enumerator_get_Current_mAD3C13EC90677751AE02D5DF4E981C2831DD1C1C_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&GameObject_AddComponent_TisMeshFilter_t6D1CE2473A1E45AC73013400585A1163BF66B2F5_mEAB8177A64DF1A50BB7996ACEEEADCD65358AC94_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&GameObject_AddComponent_TisMeshRenderer_t4B7747212F0B88244BB7790C61AE124BFC15BAAE_mCDD3E77673305199F52C772AE8C7952F3864740D_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&GameObject_t76FEDD663AB33C991A9C9A23129337651094216F_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&KeyValuePair_2_get_Key_mFF379184A888CEA6C7DD77DD5DD36E5819C98D99_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&KeyValuePair_2_get_Value_mD43CA99389807F2DF5FE76DBEC3D4174C787BE98_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_get_Count_m46EEFFA770BE665EA0CB3A5332E941DA4B3C1D37_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&MaterialU5BU5D_t2B1D11C42DB07A4400C0535F92DBB87A2E346D3D_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* V_0 = NULL;
	MeshRenderer_t4B7747212F0B88244BB7790C61AE124BFC15BAAE* V_1 = NULL;
	int32_t V_2 = 0;
	MaterialU5BU5D_t2B1D11C42DB07A4400C0535F92DBB87A2E346D3D* V_3 = NULL;
	MeshFilter_t6D1CE2473A1E45AC73013400585A1163BF66B2F5* V_4 = NULL;
	Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* V_5 = NULL;
	Enumerator_t2B62C6EA9375CE714A32E123DFDDDC13C21DDDB2 V_6;
	memset((&V_6), 0, sizeof(V_6));
	KeyValuePair_2_tAB3B085BB59FEFAE0C5C3A1A32259012890DC6B0 V_7;
	memset((&V_7), 0, sizeof(V_7));
	Material_t18053F08F347D0DCA5E1140EC7EC4533DD8A14E3* V_8 = NULL;
	KeyValuePair_2_tAB3B085BB59FEFAE0C5C3A1A32259012890DC6B0 V_9;
	memset((&V_9), 0, sizeof(V_9));
	Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* G_B12_0 = NULL;
	Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* G_B12_1 = NULL;
	Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* G_B11_0 = NULL;
	Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* G_B11_1 = NULL;
	int32_t G_B13_0 = 0;
	Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* G_B13_1 = NULL;
	Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* G_B13_2 = NULL;
	{
		// var go = new GameObject(_name);
		String_t* L_0 = __this->____name_2;
		GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* L_1 = (GameObject_t76FEDD663AB33C991A9C9A23129337651094216F*)il2cpp_codegen_object_new(GameObject_t76FEDD663AB33C991A9C9A23129337651094216F_il2cpp_TypeInfo_var);
		GameObject__ctor_m37D512B05D292F954792225E6C6EEE95293A9B88(L_1, L_0, /*hidden argument*/NULL);
		V_0 = L_1;
		// var mr = go.AddComponent<MeshRenderer>();
		GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* L_2 = V_0;
		NullCheck(L_2);
		MeshRenderer_t4B7747212F0B88244BB7790C61AE124BFC15BAAE* L_3;
		L_3 = GameObject_AddComponent_TisMeshRenderer_t4B7747212F0B88244BB7790C61AE124BFC15BAAE_mCDD3E77673305199F52C772AE8C7952F3864740D(L_2, GameObject_AddComponent_TisMeshRenderer_t4B7747212F0B88244BB7790C61AE124BFC15BAAE_mCDD3E77673305199F52C772AE8C7952F3864740D_RuntimeMethod_var);
		V_1 = L_3;
		// int submesh = 0;
		V_2 = 0;
		// Material[] materialArray = new Material[_materialIndices.Count];
		Dictionary_2_t6FFAD029BB474A5257D9A441504B633831AF5341* L_4 = __this->____materialIndices_4;
		NullCheck(L_4);
		int32_t L_5;
		L_5 = Dictionary_2_get_Count_m831221DAC53C65F38539F4A37520985E8DC557AF(L_4, Dictionary_2_get_Count_m831221DAC53C65F38539F4A37520985E8DC557AF_RuntimeMethod_var);
		MaterialU5BU5D_t2B1D11C42DB07A4400C0535F92DBB87A2E346D3D* L_6 = (MaterialU5BU5D_t2B1D11C42DB07A4400C0535F92DBB87A2E346D3D*)(MaterialU5BU5D_t2B1D11C42DB07A4400C0535F92DBB87A2E346D3D*)SZArrayNew(MaterialU5BU5D_t2B1D11C42DB07A4400C0535F92DBB87A2E346D3D_il2cpp_TypeInfo_var, (uint32_t)L_5);
		V_3 = L_6;
		// foreach (var kvp in _materialIndices) {
		Dictionary_2_t6FFAD029BB474A5257D9A441504B633831AF5341* L_7 = __this->____materialIndices_4;
		NullCheck(L_7);
		Enumerator_t2B62C6EA9375CE714A32E123DFDDDC13C21DDDB2 L_8;
		L_8 = Dictionary_2_GetEnumerator_m2E9E4B0E50E5FBA0C7E62ACEAD7A0327267C4C2E(L_7, Dictionary_2_GetEnumerator_m2E9E4B0E50E5FBA0C7E62ACEAD7A0327267C4C2E_RuntimeMethod_var);
		V_6 = L_8;
	}

IL_0033:
	{
		auto __finallyBlock = il2cpp::utils::Finally([&]
		{

FINALLY_00c8:
			{// begin finally (depth: 1)
				Enumerator_Dispose_m1ED4783F9B383A3AAA727AA5F6241652CEDF91FF((&V_6), Enumerator_Dispose_m1ED4783F9B383A3AAA727AA5F6241652CEDF91FF_RuntimeMethod_var);
				return;
			}// end finally (depth: 1)
		});
		try
		{// begin try (depth: 1)
			{
				goto IL_00ba;
			}

IL_0038:
			{
				// foreach (var kvp in _materialIndices) {
				KeyValuePair_2_tAB3B085BB59FEFAE0C5C3A1A32259012890DC6B0 L_9;
				L_9 = Enumerator_get_Current_mAD3C13EC90677751AE02D5DF4E981C2831DD1C1C_inline((&V_6), Enumerator_get_Current_mAD3C13EC90677751AE02D5DF4E981C2831DD1C1C_RuntimeMethod_var);
				V_7 = L_9;
				// Material material = null;
				V_8 = (Material_t18053F08F347D0DCA5E1140EC7EC4533DD8A14E3*)NULL;
				// if (_loader.Materials == null) {
				OBJLoader_tB5927F8DB92B05302380425D21E9BCE654FD66BF* L_10 = __this->____loader_1;
				NullCheck(L_10);
				Dictionary_2_t5B255487AF84FB5AB3382296BC4C30734ADE141F* L_11 = L_10->___Materials_4;
				if (L_11)
				{
					goto IL_0068;
				}
			}

IL_0051:
			{
				// material = OBJLoaderHelper.CreateNullMaterial();
				Material_t18053F08F347D0DCA5E1140EC7EC4533DD8A14E3* L_12;
				L_12 = OBJLoaderHelper_CreateNullMaterial_m08CCF4F5500BB7553CEF31A5F1444147F829170B(NULL);
				V_8 = L_12;
				// material.name = kvp.Key;
				Material_t18053F08F347D0DCA5E1140EC7EC4533DD8A14E3* L_13 = V_8;
				String_t* L_14;
				L_14 = KeyValuePair_2_get_Key_mFF379184A888CEA6C7DD77DD5DD36E5819C98D99_inline((&V_7), KeyValuePair_2_get_Key_mFF379184A888CEA6C7DD77DD5DD36E5819C98D99_RuntimeMethod_var);
				NullCheck(L_13);
				Object_set_name_mC79E6DC8FFD72479C90F0C4CC7F42A0FEAF5AE47(L_13, L_14, NULL);
				goto IL_00b1;
			}

IL_0068:
			{
				// if (!_loader.Materials.TryGetValue(kvp.Key, out material)) {
				OBJLoader_tB5927F8DB92B05302380425D21E9BCE654FD66BF* L_15 = __this->____loader_1;
				NullCheck(L_15);
				Dictionary_2_t5B255487AF84FB5AB3382296BC4C30734ADE141F* L_16 = L_15->___Materials_4;
				String_t* L_17;
				L_17 = KeyValuePair_2_get_Key_mFF379184A888CEA6C7DD77DD5DD36E5819C98D99_inline((&V_7), KeyValuePair_2_get_Key_mFF379184A888CEA6C7DD77DD5DD36E5819C98D99_RuntimeMethod_var);
				NullCheck(L_16);
				bool L_18;
				L_18 = Dictionary_2_TryGetValue_mFD7867D61B454D815AFE71D04D27540FAFBFF091(L_16, L_17, (&V_8), Dictionary_2_TryGetValue_mFD7867D61B454D815AFE71D04D27540FAFBFF091_RuntimeMethod_var);
				if (L_18)
				{
					goto IL_00b1;
				}
			}

IL_0083:
			{
				// material = OBJLoaderHelper.CreateNullMaterial();
				Material_t18053F08F347D0DCA5E1140EC7EC4533DD8A14E3* L_19;
				L_19 = OBJLoaderHelper_CreateNullMaterial_m08CCF4F5500BB7553CEF31A5F1444147F829170B(NULL);
				V_8 = L_19;
				// material.name = kvp.Key;
				Material_t18053F08F347D0DCA5E1140EC7EC4533DD8A14E3* L_20 = V_8;
				String_t* L_21;
				L_21 = KeyValuePair_2_get_Key_mFF379184A888CEA6C7DD77DD5DD36E5819C98D99_inline((&V_7), KeyValuePair_2_get_Key_mFF379184A888CEA6C7DD77DD5DD36E5819C98D99_RuntimeMethod_var);
				NullCheck(L_20);
				Object_set_name_mC79E6DC8FFD72479C90F0C4CC7F42A0FEAF5AE47(L_20, L_21, NULL);
				// _loader.Materials[kvp.Key] = material;
				OBJLoader_tB5927F8DB92B05302380425D21E9BCE654FD66BF* L_22 = __this->____loader_1;
				NullCheck(L_22);
				Dictionary_2_t5B255487AF84FB5AB3382296BC4C30734ADE141F* L_23 = L_22->___Materials_4;
				String_t* L_24;
				L_24 = KeyValuePair_2_get_Key_mFF379184A888CEA6C7DD77DD5DD36E5819C98D99_inline((&V_7), KeyValuePair_2_get_Key_mFF379184A888CEA6C7DD77DD5DD36E5819C98D99_RuntimeMethod_var);
				Material_t18053F08F347D0DCA5E1140EC7EC4533DD8A14E3* L_25 = V_8;
				NullCheck(L_23);
				Dictionary_2_set_Item_m2712E92CF36B85D20B01493D39F2BD4504C0BE7B(L_23, L_24, L_25, Dictionary_2_set_Item_m2712E92CF36B85D20B01493D39F2BD4504C0BE7B_RuntimeMethod_var);
			}

IL_00b1:
			{
				// materialArray[submesh] = material;
				MaterialU5BU5D_t2B1D11C42DB07A4400C0535F92DBB87A2E346D3D* L_26 = V_3;
				int32_t L_27 = V_2;
				Material_t18053F08F347D0DCA5E1140EC7EC4533DD8A14E3* L_28 = V_8;
				NullCheck(L_26);
				ArrayElementTypeCheck (L_26, L_28);
				(L_26)->SetAt(static_cast<il2cpp_array_size_t>(L_27), (Material_t18053F08F347D0DCA5E1140EC7EC4533DD8A14E3*)L_28);
				// submesh++;
				int32_t L_29 = V_2;
				V_2 = ((int32_t)il2cpp_codegen_add(L_29, 1));
			}

IL_00ba:
			{
				// foreach (var kvp in _materialIndices) {
				bool L_30;
				L_30 = Enumerator_MoveNext_m6F709DC1AED45A132D5B2CE5C6912F4FB3BA6872((&V_6), Enumerator_MoveNext_m6F709DC1AED45A132D5B2CE5C6912F4FB3BA6872_RuntimeMethod_var);
				if (L_30)
				{
					goto IL_0038;
				}
			}

IL_00c6:
			{
				goto IL_00d6;
			}
		}// end try (depth: 1)
		catch(Il2CppExceptionWrapper& e)
		{
			__finallyBlock.StoreException(e.ex);
		}
	}

IL_00d6:
	{
		// mr.sharedMaterials = materialArray;
		MeshRenderer_t4B7747212F0B88244BB7790C61AE124BFC15BAAE* L_31 = V_1;
		MaterialU5BU5D_t2B1D11C42DB07A4400C0535F92DBB87A2E346D3D* L_32 = V_3;
		NullCheck(L_31);
		Renderer_set_sharedMaterials_m665ADE4190214CC2AC52490B4A7373D7EE75DEB2(L_31, L_32, NULL);
		// var mf = go.AddComponent<MeshFilter>();
		GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* L_33 = V_0;
		NullCheck(L_33);
		MeshFilter_t6D1CE2473A1E45AC73013400585A1163BF66B2F5* L_34;
		L_34 = GameObject_AddComponent_TisMeshFilter_t6D1CE2473A1E45AC73013400585A1163BF66B2F5_mEAB8177A64DF1A50BB7996ACEEEADCD65358AC94(L_33, GameObject_AddComponent_TisMeshFilter_t6D1CE2473A1E45AC73013400585A1163BF66B2F5_mEAB8177A64DF1A50BB7996ACEEEADCD65358AC94_RuntimeMethod_var);
		V_4 = L_34;
		// submesh = 0;
		V_2 = 0;
		// var msh = new Mesh() {
		//     name = _name,
		//     indexFormat = (_vertices.Count > 65535) ? UnityEngine.Rendering.IndexFormat.UInt32 : UnityEngine.Rendering.IndexFormat.UInt16,
		//     subMeshCount = _materialIndices.Count
		// };
		Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* L_35 = (Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4*)il2cpp_codegen_object_new(Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4_il2cpp_TypeInfo_var);
		Mesh__ctor_m5A9AECEDDAFFD84811ED8928012BDE97A9CEBD00(L_35, /*hidden argument*/NULL);
		Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* L_36 = L_35;
		String_t* L_37 = __this->____name_2;
		NullCheck(L_36);
		Object_set_name_mC79E6DC8FFD72479C90F0C4CC7F42A0FEAF5AE47(L_36, L_37, NULL);
		Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* L_38 = L_36;
		List_1_t77B94703E05C519A9010DD0614F757F974E1CD8B* L_39 = __this->____vertices_7;
		NullCheck(L_39);
		int32_t L_40;
		L_40 = List_1_get_Count_m46EEFFA770BE665EA0CB3A5332E941DA4B3C1D37_inline(L_39, List_1_get_Count_m46EEFFA770BE665EA0CB3A5332E941DA4B3C1D37_RuntimeMethod_var);
		G_B11_0 = L_38;
		G_B11_1 = L_38;
		if ((((int32_t)L_40) > ((int32_t)((int32_t)65535))))
		{
			G_B12_0 = L_38;
			G_B12_1 = L_38;
			goto IL_010e;
		}
	}
	{
		G_B13_0 = 0;
		G_B13_1 = G_B11_0;
		G_B13_2 = G_B11_1;
		goto IL_010f;
	}

IL_010e:
	{
		G_B13_0 = 1;
		G_B13_1 = G_B12_0;
		G_B13_2 = G_B12_1;
	}

IL_010f:
	{
		NullCheck(G_B13_1);
		Mesh_set_indexFormat_mCCC7837A0916FA7A272159DA6AF984B0022488F4(G_B13_1, G_B13_0, NULL);
		Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* L_41 = G_B13_2;
		Dictionary_2_t6FFAD029BB474A5257D9A441504B633831AF5341* L_42 = __this->____materialIndices_4;
		NullCheck(L_42);
		int32_t L_43;
		L_43 = Dictionary_2_get_Count_m831221DAC53C65F38539F4A37520985E8DC557AF(L_42, Dictionary_2_get_Count_m831221DAC53C65F38539F4A37520985E8DC557AF_RuntimeMethod_var);
		NullCheck(L_41);
		Mesh_set_subMeshCount_m8E4DB392DB0621F7DFF8543FF3943A13072B8A28(L_41, L_43, NULL);
		V_5 = L_41;
		// msh.SetVertices(_vertices);
		Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* L_44 = V_5;
		List_1_t77B94703E05C519A9010DD0614F757F974E1CD8B* L_45 = __this->____vertices_7;
		NullCheck(L_44);
		Mesh_SetVertices_mCE01139EEEC3D10B4A6CEA1749FD84DABC53599E(L_44, L_45, NULL);
		// msh.SetNormals(_normals);
		Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* L_46 = V_5;
		List_1_t77B94703E05C519A9010DD0614F757F974E1CD8B* L_47 = __this->____normals_8;
		NullCheck(L_46);
		Mesh_SetNormals_mB4072A4D2600768FD62BC9CAAFF8C43955A4A365(L_46, L_47, NULL);
		// msh.SetUVs(0, _uvs);
		Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* L_48 = V_5;
		List_1_t8F3790B7F8C471B3A1336522C7415FB0AC36D47B* L_49 = __this->____uvs_9;
		NullCheck(L_48);
		Mesh_SetUVs_m5A7A6EC14A621579B7138F2EF9BECA60E880A8D7(L_48, 0, L_49, NULL);
		// foreach (var kvp in _materialIndices) {
		Dictionary_2_t6FFAD029BB474A5257D9A441504B633831AF5341* L_50 = __this->____materialIndices_4;
		NullCheck(L_50);
		Enumerator_t2B62C6EA9375CE714A32E123DFDDDC13C21DDDB2 L_51;
		L_51 = Dictionary_2_GetEnumerator_m2E9E4B0E50E5FBA0C7E62ACEAD7A0327267C4C2E(L_50, Dictionary_2_GetEnumerator_m2E9E4B0E50E5FBA0C7E62ACEAD7A0327267C4C2E_RuntimeMethod_var);
		V_6 = L_51;
	}

IL_015c:
	{
		auto __finallyBlock = il2cpp::utils::Finally([&]
		{

FINALLY_0185:
			{// begin finally (depth: 1)
				Enumerator_Dispose_m1ED4783F9B383A3AAA727AA5F6241652CEDF91FF((&V_6), Enumerator_Dispose_m1ED4783F9B383A3AAA727AA5F6241652CEDF91FF_RuntimeMethod_var);
				return;
			}// end finally (depth: 1)
		});
		try
		{// begin try (depth: 1)
			{
				goto IL_017a;
			}

IL_015e:
			{
				// foreach (var kvp in _materialIndices) {
				KeyValuePair_2_tAB3B085BB59FEFAE0C5C3A1A32259012890DC6B0 L_52;
				L_52 = Enumerator_get_Current_mAD3C13EC90677751AE02D5DF4E981C2831DD1C1C_inline((&V_6), Enumerator_get_Current_mAD3C13EC90677751AE02D5DF4E981C2831DD1C1C_RuntimeMethod_var);
				V_9 = L_52;
				// msh.SetTriangles(kvp.Value, submesh);
				Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* L_53 = V_5;
				List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73* L_54;
				L_54 = KeyValuePair_2_get_Value_mD43CA99389807F2DF5FE76DBEC3D4174C787BE98_inline((&V_9), KeyValuePair_2_get_Value_mD43CA99389807F2DF5FE76DBEC3D4174C787BE98_RuntimeMethod_var);
				int32_t L_55 = V_2;
				NullCheck(L_53);
				Mesh_SetTriangles_mD495DA0B00DB0E60A2B7B500D644F4470C1D61DB(L_53, L_54, L_55, NULL);
				// submesh++;
				int32_t L_56 = V_2;
				V_2 = ((int32_t)il2cpp_codegen_add(L_56, 1));
			}

IL_017a:
			{
				// foreach (var kvp in _materialIndices) {
				bool L_57;
				L_57 = Enumerator_MoveNext_m6F709DC1AED45A132D5B2CE5C6912F4FB3BA6872((&V_6), Enumerator_MoveNext_m6F709DC1AED45A132D5B2CE5C6912F4FB3BA6872_RuntimeMethod_var);
				if (L_57)
				{
					goto IL_015e;
				}
			}

IL_0183:
			{
				goto IL_0193;
			}
		}// end try (depth: 1)
		catch(Il2CppExceptionWrapper& e)
		{
			__finallyBlock.StoreException(e.ex);
		}
	}

IL_0193:
	{
		// if (recalculateNormals)
		bool L_58 = __this->___recalculateNormals_10;
		if (!L_58)
		{
			goto IL_01a2;
		}
	}
	{
		// msh.RecalculateNormals();
		Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* L_59 = V_5;
		NullCheck(L_59);
		Mesh_RecalculateNormals_m3AA2788914611444E030CA310E03E3CFE683902B(L_59, NULL);
	}

IL_01a2:
	{
		// msh.RecalculateTangents();
		Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* L_60 = V_5;
		NullCheck(L_60);
		Mesh_RecalculateTangents_m92AC413FAF889C5E811D86DCE0C25ED4625825EC(L_60, NULL);
		// msh.RecalculateBounds();
		Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* L_61 = V_5;
		NullCheck(L_61);
		Mesh_RecalculateBounds_mA9B293F57C6CD298AE2D2DB19061FC23B05AB90B(L_61, NULL);
		// mf.sharedMesh = msh;
		MeshFilter_t6D1CE2473A1E45AC73013400585A1163BF66B2F5* L_62 = V_4;
		Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* L_63 = V_5;
		NullCheck(L_62);
		MeshFilter_set_sharedMesh_m946F7E3F583761982642BDA4753784AF1DF6E16F(L_62, L_63, NULL);
		// return go;
		GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* L_64 = V_0;
		return L_64;
	}
}
// System.Void Dummiesman.OBJObjectBuilder::SetMaterial(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void OBJObjectBuilder_SetMaterial_m14E76B9F35E6D475F9CF64D81A431328AFF709D9 (OBJObjectBuilder_t0FF6F614A40C0709678B6A0F9111F43397565F13* __this, String_t* ___name0, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Dictionary_2_TryGetValue_m56F2C16A68E7E1B774D8B14B3DF74FA825C5CC9C_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Dictionary_2_set_Item_m529105CC1CF8E638D570A195BF4D8BA4984EB3E8_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1__ctor_m17F501B5A5C289ECE1B4F3D6EBF05DFA421433F8_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
{
		// if (!_materialIndices.TryGetValue(name, out _currentIndexList))
		Dictionary_2_t6FFAD029BB474A5257D9A441504B633831AF5341* L_0 = __this->____materialIndices_4;
		String_t* L_1 = ___name0;
		List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73** L_2 = (&__this->____currentIndexList_5);
		NullCheck(L_0);
		bool L_3;
		L_3 = Dictionary_2_TryGetValue_m56F2C16A68E7E1B774D8B14B3DF74FA825C5CC9C(L_0, L_1, L_2, Dictionary_2_TryGetValue_m56F2C16A68E7E1B774D8B14B3DF74FA825C5CC9C_RuntimeMethod_var);
		if (L_3)
		{
			goto IL_0031;
		}
	}
	{
		// _currentIndexList = new List<int>();
		List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73* L_4 = (List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73*)il2cpp_codegen_object_new(List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73_il2cpp_TypeInfo_var);
		List_1__ctor_m17F501B5A5C289ECE1B4F3D6EBF05DFA421433F8(L_4, /*hidden argument*/List_1__ctor_m17F501B5A5C289ECE1B4F3D6EBF05DFA421433F8_RuntimeMethod_var);
		__this->____currentIndexList_5 = L_4;
		Il2CppCodeGenWriteBarrier((void**)(&__this->____currentIndexList_5), (void*)L_4);
		// _materialIndices[name] = _currentIndexList;
		Dictionary_2_t6FFAD029BB474A5257D9A441504B633831AF5341* L_5 = __this->____materialIndices_4;
		String_t* L_6 = ___name0;
		List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73* L_7 = __this->____currentIndexList_5;
		NullCheck(L_5);
		Dictionary_2_set_Item_m529105CC1CF8E638D570A195BF4D8BA4984EB3E8(L_5, L_6, L_7, Dictionary_2_set_Item_m529105CC1CF8E638D570A195BF4D8BA4984EB3E8_RuntimeMethod_var);
	}

IL_0031:
	{
		// }
		return;
	}
}
// System.Void Dummiesman.OBJObjectBuilder::PushFace(System.String,System.Collections.Generic.List`1<System.Int32>,System.Collections.Generic.List`1<System.Int32>,System.Collections.Generic.List`1<System.Int32>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void OBJObjectBuilder_PushFace_mEB8693BC3E91FBC712492DD2570C540D89DD1213 (OBJObjectBuilder_t0FF6F614A40C0709678B6A0F9111F43397565F13* __this, String_t* ___material0, List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73* ___vertexIndices1, List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73* ___normalIndices2, List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73* ___uvIndices3, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Dictionary_2_Add_m45B16A0848D5AA8855A51C20C2AA2B90A6516877_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Dictionary_2_TryGetValue_m0058521363E7F49C437C430A754DB0F1B5379289_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_AddRange_m1A10E697703D67F6551D47C603FFE78E16CE4204_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_Add_m79E50C4F592B1703F4B76A8BE7B4855515460CA1_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_Add_mB5FDF069171C4CB1778BFAC3B9015A22EA7DFBCD_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_get_Count_m46EEFFA770BE665EA0CB3A5332E941DA4B3C1D37_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_get_Count_mF1C0C56457C655BDFFC6EE5B46FAD8BAEC1F588B_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_get_Count_mF590592E32D421DE2C6E2F0D5C2F62FB14CCEFDF_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_get_Item_m1F8E226CAD72B83C5E75BB66B43025247806B543_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_get_Item_m8F2E15FC96DA75186C51228128A0660709E4E810_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_get_Item_mD99081BEFA1AB3526715F489192B0F7F596C183D_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ObjLoopHash_t0314B9758A262019FC1EFB5432DE4F2D2139B20B_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* V_0 = NULL;
	int32_t V_1 = 0;
	int32_t V_2 = 0;
	int32_t V_3 = 0;
	int32_t V_4 = 0;
	ObjLoopHash_t0314B9758A262019FC1EFB5432DE4F2D2139B20B* V_5 = NULL;
	int32_t V_6 = 0;
	int32_t V_7 = 0;
	int32_t V_8 = 0;
	List_1_t77B94703E05C519A9010DD0614F757F974E1CD8B* G_B8_0 = NULL;
	List_1_t77B94703E05C519A9010DD0614F757F974E1CD8B* G_B7_0 = NULL;
	List_1_t77B94703E05C519A9010DD0614F757F974E1CD8B* G_B9_0 = NULL;
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 G_B10_0;
	memset((&G_B10_0), 0, sizeof(G_B10_0));
	List_1_t77B94703E05C519A9010DD0614F757F974E1CD8B* G_B10_1 = NULL;
	List_1_t77B94703E05C519A9010DD0614F757F974E1CD8B* G_B12_0 = NULL;
	List_1_t77B94703E05C519A9010DD0614F757F974E1CD8B* G_B11_0 = NULL;
	List_1_t77B94703E05C519A9010DD0614F757F974E1CD8B* G_B13_0 = NULL;
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 G_B14_0;
	memset((&G_B14_0), 0, sizeof(G_B14_0));
	List_1_t77B94703E05C519A9010DD0614F757F974E1CD8B* G_B14_1 = NULL;
	List_1_t8F3790B7F8C471B3A1336522C7415FB0AC36D47B* G_B16_0 = NULL;
	List_1_t8F3790B7F8C471B3A1336522C7415FB0AC36D47B* G_B15_0 = NULL;
	List_1_t8F3790B7F8C471B3A1336522C7415FB0AC36D47B* G_B17_0 = NULL;
	Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 G_B18_0;
	memset((&G_B18_0), 0, sizeof(G_B18_0));
	List_1_t8F3790B7F8C471B3A1336522C7415FB0AC36D47B* G_B18_1 = NULL;
	{
		// if (vertexIndices.Count < 3) {
		List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73* L_0 = ___vertexIndices1;
		NullCheck(L_0);
		int32_t L_1;
		L_1 = List_1_get_Count_mF590592E32D421DE2C6E2F0D5C2F62FB14CCEFDF_inline(L_0, List_1_get_Count_mF590592E32D421DE2C6E2F0D5C2F62FB14CCEFDF_RuntimeMethod_var);
		if ((((int32_t)L_1) >= ((int32_t)3)))
		{
			goto IL_000a;
		}
	}
	{
		// return;
		return;
	}

IL_000a:
	{
		// if (material != _lastMaterial) {
		String_t* L_2 = ___material0;
		String_t* L_3 = __this->____lastMaterial_6;
		bool L_4;
		L_4 = String_op_Inequality_m0FBE5AC4931D312E5B347BAA603755676E6DA2FE(L_2, L_3, NULL);
		if (!L_4)
		{
			goto IL_0026;
		}
	}
	{
		// SetMaterial(material);
		String_t* L_5 = ___material0;
		OBJObjectBuilder_SetMaterial_m14E76B9F35E6D475F9CF64D81A431328AFF709D9(__this, L_5, NULL);
		// _lastMaterial = material;
		String_t* L_6 = ___material0;
		__this->____lastMaterial_6 = L_6;
		Il2CppCodeGenWriteBarrier((void**)(&__this->____lastMaterial_6), (void*)L_6);
	}

IL_0026:
	{
		// int[] indexRemap = new int[vertexIndices.Count];
		List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73* L_7 = ___vertexIndices1;
		NullCheck(L_7);
		int32_t L_8;
		L_8 = List_1_get_Count_mF590592E32D421DE2C6E2F0D5C2F62FB14CCEFDF_inline(L_7, List_1_get_Count_mF590592E32D421DE2C6E2F0D5C2F62FB14CCEFDF_RuntimeMethod_var);
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_9 = (Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C*)(Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C*)SZArrayNew(Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C_il2cpp_TypeInfo_var, (uint32_t)L_8);
		V_0 = L_9;
		// for (int i = 0; i < vertexIndices.Count; i++) {
		V_1 = 0;
		goto IL_0171;
	}

IL_0039:
	{
		// int vertexIndex = vertexIndices[i];
		List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73* L_10 = ___vertexIndices1;
		int32_t L_11 = V_1;
		NullCheck(L_10);
		int32_t L_12;
		L_12 = List_1_get_Item_mD99081BEFA1AB3526715F489192B0F7F596C183D(L_10, L_11, List_1_get_Item_mD99081BEFA1AB3526715F489192B0F7F596C183D_RuntimeMethod_var);
		V_2 = L_12;
		// int normalIndex = normalIndices[i];
		List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73* L_13 = ___normalIndices2;
		int32_t L_14 = V_1;
		NullCheck(L_13);
		int32_t L_15;
		L_15 = List_1_get_Item_mD99081BEFA1AB3526715F489192B0F7F596C183D(L_13, L_14, List_1_get_Item_mD99081BEFA1AB3526715F489192B0F7F596C183D_RuntimeMethod_var);
		V_3 = L_15;
		// int uvIndex = uvIndices[i];
		List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73* L_16 = ___uvIndices3;
		int32_t L_17 = V_1;
		NullCheck(L_16);
		int32_t L_18;
		L_18 = List_1_get_Item_mD99081BEFA1AB3526715F489192B0F7F596C183D(L_16, L_17, List_1_get_Item_mD99081BEFA1AB3526715F489192B0F7F596C183D_RuntimeMethod_var);
		V_4 = L_18;
		// var hashObj = new ObjLoopHash() {
		//     vertexIndex = vertexIndex,
		//     normalIndex = normalIndex,
		//     uvIndex = uvIndex
		// };
		ObjLoopHash_t0314B9758A262019FC1EFB5432DE4F2D2139B20B* L_19 = (ObjLoopHash_t0314B9758A262019FC1EFB5432DE4F2D2139B20B*)il2cpp_codegen_object_new(ObjLoopHash_t0314B9758A262019FC1EFB5432DE4F2D2139B20B_il2cpp_TypeInfo_var);
		ObjLoopHash__ctor_m47684E1CB5D8B5CCC4D682B98F165C87AF514445(L_19, /*hidden argument*/NULL);
		ObjLoopHash_t0314B9758A262019FC1EFB5432DE4F2D2139B20B* L_20 = L_19;
		int32_t L_21 = V_2;
		NullCheck(L_20);
		L_20->___vertexIndex_0 = L_21;
		ObjLoopHash_t0314B9758A262019FC1EFB5432DE4F2D2139B20B* L_22 = L_20;
		int32_t L_23 = V_3;
		NullCheck(L_22);
		L_22->___normalIndex_1 = L_23;
		ObjLoopHash_t0314B9758A262019FC1EFB5432DE4F2D2139B20B* L_24 = L_22;
		int32_t L_25 = V_4;
		NullCheck(L_24);
		L_24->___uvIndex_2 = L_25;
		V_5 = L_24;
		// int remap = -1;
		V_6 = (-1);
		// if (!_globalIndexRemap.TryGetValue(hashObj, out remap)) {
		Dictionary_2_tEAE7D7DBCEF056EB634E23611F29B7D56A4614FE* L_26 = __this->____globalIndexRemap_3;
		ObjLoopHash_t0314B9758A262019FC1EFB5432DE4F2D2139B20B* L_27 = V_5;
		NullCheck(L_26);
		bool L_28;
		L_28 = Dictionary_2_TryGetValue_m0058521363E7F49C437C430A754DB0F1B5379289(L_26, L_27, (&V_6), Dictionary_2_TryGetValue_m0058521363E7F49C437C430A754DB0F1B5379289_RuntimeMethod_var);
		if (L_28)
		{
			goto IL_0168;
		}
	}
	{
		// _globalIndexRemap.Add(hashObj, _vertices.Count);
		Dictionary_2_tEAE7D7DBCEF056EB634E23611F29B7D56A4614FE* L_29 = __this->____globalIndexRemap_3;
		ObjLoopHash_t0314B9758A262019FC1EFB5432DE4F2D2139B20B* L_30 = V_5;
		List_1_t77B94703E05C519A9010DD0614F757F974E1CD8B* L_31 = __this->____vertices_7;
		NullCheck(L_31);
		int32_t L_32;
		L_32 = List_1_get_Count_m46EEFFA770BE665EA0CB3A5332E941DA4B3C1D37_inline(L_31, List_1_get_Count_m46EEFFA770BE665EA0CB3A5332E941DA4B3C1D37_RuntimeMethod_var);
		NullCheck(L_29);
		Dictionary_2_Add_m45B16A0848D5AA8855A51C20C2AA2B90A6516877(L_29, L_30, L_32, Dictionary_2_Add_m45B16A0848D5AA8855A51C20C2AA2B90A6516877_RuntimeMethod_var);
		// remap = _vertices.Count;
		List_1_t77B94703E05C519A9010DD0614F757F974E1CD8B* L_33 = __this->____vertices_7;
		NullCheck(L_33);
		int32_t L_34;
		L_34 = List_1_get_Count_m46EEFFA770BE665EA0CB3A5332E941DA4B3C1D37_inline(L_33, List_1_get_Count_m46EEFFA770BE665EA0CB3A5332E941DA4B3C1D37_RuntimeMethod_var);
		V_6 = L_34;
		// _vertices.Add((vertexIndex >= 0 && vertexIndex < _loader.Vertices.Count) ? _loader.Vertices[vertexIndex] : Vector3.zero);
		List_1_t77B94703E05C519A9010DD0614F757F974E1CD8B* L_35 = __this->____vertices_7;
		int32_t L_36 = V_2;
		G_B7_0 = L_35;
		if ((((int32_t)L_36) < ((int32_t)0)))
		{
			G_B8_0 = L_35;
			goto IL_00c9;
		}
	}
	{
		int32_t L_37 = V_2;
		OBJLoader_tB5927F8DB92B05302380425D21E9BCE654FD66BF* L_38 = __this->____loader_1;
		NullCheck(L_38);
		List_1_t77B94703E05C519A9010DD0614F757F974E1CD8B* L_39 = L_38->___Vertices_1;
		NullCheck(L_39);
		int32_t L_40;
		L_40 = List_1_get_Count_m46EEFFA770BE665EA0CB3A5332E941DA4B3C1D37_inline(L_39, List_1_get_Count_m46EEFFA770BE665EA0CB3A5332E941DA4B3C1D37_RuntimeMethod_var);
		G_B8_0 = G_B7_0;
		if ((((int32_t)L_37) < ((int32_t)L_40)))
		{
			G_B9_0 = G_B7_0;
			goto IL_00d0;
		}
	}

IL_00c9:
	{
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_41;
		L_41 = Vector3_get_zero_m9D7F7B580B5A276411267E96AA3425736D9BDC83_inline(NULL);
		G_B10_0 = L_41;
		G_B10_1 = G_B8_0;
		goto IL_00e1;
	}

IL_00d0:
	{
		OBJLoader_tB5927F8DB92B05302380425D21E9BCE654FD66BF* L_42 = __this->____loader_1;
		NullCheck(L_42);
		List_1_t77B94703E05C519A9010DD0614F757F974E1CD8B* L_43 = L_42->___Vertices_1;
		int32_t L_44 = V_2;
		NullCheck(L_43);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_45;
		L_45 = List_1_get_Item_m8F2E15FC96DA75186C51228128A0660709E4E810(L_43, L_44, List_1_get_Item_m8F2E15FC96DA75186C51228128A0660709E4E810_RuntimeMethod_var);
		G_B10_0 = L_45;
		G_B10_1 = G_B9_0;
	}

IL_00e1:
	{
		NullCheck(G_B10_1);
		List_1_Add_m79E50C4F592B1703F4B76A8BE7B4855515460CA1_inline(G_B10_1, G_B10_0, List_1_Add_m79E50C4F592B1703F4B76A8BE7B4855515460CA1_RuntimeMethod_var);
		// _normals.Add((normalIndex >= 0 && normalIndex < _loader.Normals.Count) ? _loader.Normals[normalIndex] : Vector3.zero);
		List_1_t77B94703E05C519A9010DD0614F757F974E1CD8B* L_46 = __this->____normals_8;
		int32_t L_47 = V_3;
		G_B11_0 = L_46;
		if ((((int32_t)L_47) < ((int32_t)0)))
		{
			G_B12_0 = L_46;
			goto IL_0103;
		}
	}
	{
		int32_t L_48 = V_3;
		OBJLoader_tB5927F8DB92B05302380425D21E9BCE654FD66BF* L_49 = __this->____loader_1;
		NullCheck(L_49);
		List_1_t77B94703E05C519A9010DD0614F757F974E1CD8B* L_50 = L_49->___Normals_2;
		NullCheck(L_50);
		int32_t L_51;
		L_51 = List_1_get_Count_m46EEFFA770BE665EA0CB3A5332E941DA4B3C1D37_inline(L_50, List_1_get_Count_m46EEFFA770BE665EA0CB3A5332E941DA4B3C1D37_RuntimeMethod_var);
		G_B12_0 = G_B11_0;
		if ((((int32_t)L_48) < ((int32_t)L_51)))
		{
			G_B13_0 = G_B11_0;
			goto IL_010a;
		}
	}

IL_0103:
	{
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_52;
		L_52 = Vector3_get_zero_m9D7F7B580B5A276411267E96AA3425736D9BDC83_inline(NULL);
		G_B14_0 = L_52;
		G_B14_1 = G_B12_0;
		goto IL_011b;
	}

IL_010a:
	{
		OBJLoader_tB5927F8DB92B05302380425D21E9BCE654FD66BF* L_53 = __this->____loader_1;
		NullCheck(L_53);
		List_1_t77B94703E05C519A9010DD0614F757F974E1CD8B* L_54 = L_53->___Normals_2;
		int32_t L_55 = V_3;
		NullCheck(L_54);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_56;
		L_56 = List_1_get_Item_m8F2E15FC96DA75186C51228128A0660709E4E810(L_54, L_55, List_1_get_Item_m8F2E15FC96DA75186C51228128A0660709E4E810_RuntimeMethod_var);
		G_B14_0 = L_56;
		G_B14_1 = G_B13_0;
	}

IL_011b:
	{
		NullCheck(G_B14_1);
		List_1_Add_m79E50C4F592B1703F4B76A8BE7B4855515460CA1_inline(G_B14_1, G_B14_0, List_1_Add_m79E50C4F592B1703F4B76A8BE7B4855515460CA1_RuntimeMethod_var);
		// _uvs.Add((uvIndex >= 0 && uvIndex < _loader.UVs.Count) ? _loader.UVs[uvIndex] : Vector2.zero);
		List_1_t8F3790B7F8C471B3A1336522C7415FB0AC36D47B* L_57 = __this->____uvs_9;
		int32_t L_58 = V_4;
		G_B15_0 = L_57;
		if ((((int32_t)L_58) < ((int32_t)0)))
		{
			G_B16_0 = L_57;
			goto IL_013f;
		}
	}
	{
		int32_t L_59 = V_4;
		OBJLoader_tB5927F8DB92B05302380425D21E9BCE654FD66BF* L_60 = __this->____loader_1;
		NullCheck(L_60);
		List_1_t8F3790B7F8C471B3A1336522C7415FB0AC36D47B* L_61 = L_60->___UVs_3;
		NullCheck(L_61);
		int32_t L_62;
		L_62 = List_1_get_Count_mF1C0C56457C655BDFFC6EE5B46FAD8BAEC1F588B_inline(L_61, List_1_get_Count_mF1C0C56457C655BDFFC6EE5B46FAD8BAEC1F588B_RuntimeMethod_var);
		G_B16_0 = G_B15_0;
		if ((((int32_t)L_59) < ((int32_t)L_62)))
		{
			G_B17_0 = G_B15_0;
			goto IL_0146;
		}
	}

IL_013f:
	{
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_63;
		L_63 = Vector2_get_zero_m009B92B5D35AB02BD1610C2E1ACCE7C9CF964A6E_inline(NULL);
		G_B18_0 = L_63;
		G_B18_1 = G_B16_0;
		goto IL_0158;
	}

IL_0146:
	{
		OBJLoader_tB5927F8DB92B05302380425D21E9BCE654FD66BF* L_64 = __this->____loader_1;
		NullCheck(L_64);
		List_1_t8F3790B7F8C471B3A1336522C7415FB0AC36D47B* L_65 = L_64->___UVs_3;
		int32_t L_66 = V_4;
		NullCheck(L_65);
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_67;
		L_67 = List_1_get_Item_m1F8E226CAD72B83C5E75BB66B43025247806B543(L_65, L_66, List_1_get_Item_m1F8E226CAD72B83C5E75BB66B43025247806B543_RuntimeMethod_var);
		G_B18_0 = L_67;
		G_B18_1 = G_B17_0;
	}

IL_0158:
	{
		NullCheck(G_B18_1);
		List_1_Add_mB5FDF069171C4CB1778BFAC3B9015A22EA7DFBCD_inline(G_B18_1, G_B18_0, List_1_Add_mB5FDF069171C4CB1778BFAC3B9015A22EA7DFBCD_RuntimeMethod_var);
		// if (normalIndex < 0)
		int32_t L_68 = V_3;
		if ((((int32_t)L_68) >= ((int32_t)0)))
		{
			goto IL_0168;
		}
	}
	{
		// recalculateNormals = true;
		__this->___recalculateNormals_10 = (bool)1;
	}

IL_0168:
	{
		// indexRemap[i] = remap;
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_69 = V_0;
		int32_t L_70 = V_1;
		int32_t L_71 = V_6;
		NullCheck(L_69);
		(L_69)->SetAt(static_cast<il2cpp_array_size_t>(L_70), (int32_t)L_71);
		// for (int i = 0; i < vertexIndices.Count; i++) {
		int32_t L_72 = V_1;
		V_1 = ((int32_t)il2cpp_codegen_add(L_72, 1));
	}

IL_0171:
	{
		// for (int i = 0; i < vertexIndices.Count; i++) {
		int32_t L_73 = V_1;
		List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73* L_74 = ___vertexIndices1;
		NullCheck(L_74);
		int32_t L_75;
		L_75 = List_1_get_Count_mF590592E32D421DE2C6E2F0D5C2F62FB14CCEFDF_inline(L_74, List_1_get_Count_mF590592E32D421DE2C6E2F0D5C2F62FB14CCEFDF_RuntimeMethod_var);
		if ((((int32_t)L_73) < ((int32_t)L_75)))
		{
			goto IL_0039;
		}
	}
	{
		// if (indexRemap.Length == 3) {
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_76 = V_0;
		NullCheck(L_76);
		if ((!(((uint32_t)((int32_t)(((RuntimeArray*)L_76)->max_length))) == ((uint32_t)3))))
		{
			goto IL_01ab;
		}
	}
	{
		// _currentIndexList.AddRange(new int[] { indexRemap[0], indexRemap[1], indexRemap[2] });
		List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73* L_77 = __this->____currentIndexList_5;
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_78 = (Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C*)(Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C*)SZArrayNew(Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C_il2cpp_TypeInfo_var, (uint32_t)3);
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_79 = L_78;
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_80 = V_0;
		NullCheck(L_80);
		int32_t L_81 = 0;
		int32_t L_82 = (L_80)->GetAt(static_cast<il2cpp_array_size_t>(L_81));
		NullCheck(L_79);
		(L_79)->SetAt(static_cast<il2cpp_array_size_t>(0), (int32_t)L_82);
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_83 = L_79;
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_84 = V_0;
		NullCheck(L_84);
		int32_t L_85 = 1;
		int32_t L_86 = (L_84)->GetAt(static_cast<il2cpp_array_size_t>(L_85));
		NullCheck(L_83);
		(L_83)->SetAt(static_cast<il2cpp_array_size_t>(1), (int32_t)L_86);
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_87 = L_83;
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_88 = V_0;
		NullCheck(L_88);
		int32_t L_89 = 2;
		int32_t L_90 = (L_88)->GetAt(static_cast<il2cpp_array_size_t>(L_89));
		NullCheck(L_87);
		(L_87)->SetAt(static_cast<il2cpp_array_size_t>(2), (int32_t)L_90);
		NullCheck(L_77);
		List_1_AddRange_m1A10E697703D67F6551D47C603FFE78E16CE4204(L_77, (RuntimeObject*)L_87, List_1_AddRange_m1A10E697703D67F6551D47C603FFE78E16CE4204_RuntimeMethod_var);
		goto IL_023a;
	}

IL_01ab:
	{
		// } else if (indexRemap.Length == 4) {
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_91 = V_0;
		NullCheck(L_91);
		if ((!(((uint32_t)((int32_t)(((RuntimeArray*)L_91)->max_length))) == ((uint32_t)4))))
		{
			goto IL_01f9;
		}
	}
	{
		// _currentIndexList.AddRange(new int[] { indexRemap[0], indexRemap[1], indexRemap[2] });
		List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73* L_92 = __this->____currentIndexList_5;
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_93 = (Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C*)(Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C*)SZArrayNew(Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C_il2cpp_TypeInfo_var, (uint32_t)3);
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_94 = L_93;
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_95 = V_0;
		NullCheck(L_95);
		int32_t L_96 = 0;
		int32_t L_97 = (L_95)->GetAt(static_cast<il2cpp_array_size_t>(L_96));
		NullCheck(L_94);
		(L_94)->SetAt(static_cast<il2cpp_array_size_t>(0), (int32_t)L_97);
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_98 = L_94;
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_99 = V_0;
		NullCheck(L_99);
		int32_t L_100 = 1;
		int32_t L_101 = (L_99)->GetAt(static_cast<il2cpp_array_size_t>(L_100));
		NullCheck(L_98);
		(L_98)->SetAt(static_cast<il2cpp_array_size_t>(1), (int32_t)L_101);
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_102 = L_98;
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_103 = V_0;
		NullCheck(L_103);
		int32_t L_104 = 2;
		int32_t L_105 = (L_103)->GetAt(static_cast<il2cpp_array_size_t>(L_104));
		NullCheck(L_102);
		(L_102)->SetAt(static_cast<il2cpp_array_size_t>(2), (int32_t)L_105);
		NullCheck(L_92);
		List_1_AddRange_m1A10E697703D67F6551D47C603FFE78E16CE4204(L_92, (RuntimeObject*)L_102, List_1_AddRange_m1A10E697703D67F6551D47C603FFE78E16CE4204_RuntimeMethod_var);
		// _currentIndexList.AddRange(new int[] { indexRemap[2], indexRemap[3], indexRemap[0] });
		List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73* L_106 = __this->____currentIndexList_5;
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_107 = (Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C*)(Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C*)SZArrayNew(Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C_il2cpp_TypeInfo_var, (uint32_t)3);
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_108 = L_107;
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_109 = V_0;
		NullCheck(L_109);
		int32_t L_110 = 2;
		int32_t L_111 = (L_109)->GetAt(static_cast<il2cpp_array_size_t>(L_110));
		NullCheck(L_108);
		(L_108)->SetAt(static_cast<il2cpp_array_size_t>(0), (int32_t)L_111);
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_112 = L_108;
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_113 = V_0;
		NullCheck(L_113);
		int32_t L_114 = 3;
		int32_t L_115 = (L_113)->GetAt(static_cast<il2cpp_array_size_t>(L_114));
		NullCheck(L_112);
		(L_112)->SetAt(static_cast<il2cpp_array_size_t>(1), (int32_t)L_115);
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_116 = L_112;
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_117 = V_0;
		NullCheck(L_117);
		int32_t L_118 = 0;
		int32_t L_119 = (L_117)->GetAt(static_cast<il2cpp_array_size_t>(L_118));
		NullCheck(L_116);
		(L_116)->SetAt(static_cast<il2cpp_array_size_t>(2), (int32_t)L_119);
		NullCheck(L_106);
		List_1_AddRange_m1A10E697703D67F6551D47C603FFE78E16CE4204(L_106, (RuntimeObject*)L_116, List_1_AddRange_m1A10E697703D67F6551D47C603FFE78E16CE4204_RuntimeMethod_var);
		goto IL_023a;
	}

IL_01f9:
	{
		// } else if (indexRemap.Length > 4) {
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_120 = V_0;
		NullCheck(L_120);
		if ((((int32_t)((int32_t)(((RuntimeArray*)L_120)->max_length))) <= ((int32_t)4)))
		{
			goto IL_023a;
		}
	}
	{
		// for (int i = indexRemap.Length - 1; i >= 2; i--) {
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_121 = V_0;
		NullCheck(L_121);
		V_7 = ((int32_t)il2cpp_codegen_subtract(((int32_t)(((RuntimeArray*)L_121)->max_length)), 1));
		goto IL_0235;
	}

IL_0208:
	{
		// _currentIndexList.AddRange(new int[] { indexRemap[0], indexRemap[i - 1], indexRemap[i] });
		List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73* L_122 = __this->____currentIndexList_5;
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_123 = (Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C*)(Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C*)SZArrayNew(Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C_il2cpp_TypeInfo_var, (uint32_t)3);
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_124 = L_123;
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_125 = V_0;
		NullCheck(L_125);
		int32_t L_126 = 0;
		int32_t L_127 = (L_125)->GetAt(static_cast<il2cpp_array_size_t>(L_126));
		NullCheck(L_124);
		(L_124)->SetAt(static_cast<il2cpp_array_size_t>(0), (int32_t)L_127);
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_128 = L_124;
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_129 = V_0;
		int32_t L_130 = V_7;
		NullCheck(L_129);
		int32_t L_131 = ((int32_t)il2cpp_codegen_subtract(L_130, 1));
		int32_t L_132 = (L_129)->GetAt(static_cast<il2cpp_array_size_t>(L_131));
		NullCheck(L_128);
		(L_128)->SetAt(static_cast<il2cpp_array_size_t>(1), (int32_t)L_132);
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_133 = L_128;
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_134 = V_0;
		int32_t L_135 = V_7;
		NullCheck(L_134);
		int32_t L_136 = L_135;
		int32_t L_137 = (L_134)->GetAt(static_cast<il2cpp_array_size_t>(L_136));
		NullCheck(L_133);
		(L_133)->SetAt(static_cast<il2cpp_array_size_t>(2), (int32_t)L_137);
		NullCheck(L_122);
		List_1_AddRange_m1A10E697703D67F6551D47C603FFE78E16CE4204(L_122, (RuntimeObject*)L_133, List_1_AddRange_m1A10E697703D67F6551D47C603FFE78E16CE4204_RuntimeMethod_var);
		// for (int i = indexRemap.Length - 1; i >= 2; i--) {
		int32_t L_138 = V_7;
		V_7 = ((int32_t)il2cpp_codegen_subtract(L_138, 1));
	}

IL_0235:
	{
		// for (int i = indexRemap.Length - 1; i >= 2; i--) {
		int32_t L_139 = V_7;
		if ((((int32_t)L_139) >= ((int32_t)2)))
		{
			goto IL_0208;
		}
	}

IL_023a:
	{
		// PushedFaceCount++;
		int32_t L_140;
		L_140 = OBJObjectBuilder_get_PushedFaceCount_m0800BDEDCCE5D0006D125DE33878F032D415366E_inline(__this, NULL);
		V_8 = L_140;
		int32_t L_141 = V_8;
		OBJObjectBuilder_set_PushedFaceCount_m59B64D90A70C329BAB9F7E36961ED9C4D23744D8_inline(__this, ((int32_t)il2cpp_codegen_add(L_141, 1)), NULL);
		// }
		return;
	}
}
// System.Void Dummiesman.OBJObjectBuilder::.ctor(System.String,Dummiesman.OBJLoader)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void OBJObjectBuilder__ctor_m559A7FFA399AEF65D8C9649F8122F554E3222ABB (OBJObjectBuilder_t0FF6F614A40C0709678B6A0F9111F43397565F13* __this, String_t* ___name0, OBJLoader_tB5927F8DB92B05302380425D21E9BCE654FD66BF* ___loader1, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Dictionary_2__ctor_m63CFEDABA0B46AEB5DB36FFBCDDAD873A37C82FE_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Dictionary_2__ctor_m82637A3A6031C43DB9CC910DBD6DCC66D9459C8F_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Dictionary_2_t6FFAD029BB474A5257D9A441504B633831AF5341_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Dictionary_2_tEAE7D7DBCEF056EB634E23611F29B7D56A4614FE_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1__ctor_m88C4BD8AC607DB3585552068F4DC437406358D5F_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1__ctor_mC54E2BCBE43279A96FC082F5CDE2D76388BD8F9C_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_t77B94703E05C519A9010DD0614F757F974E1CD8B_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_t8F3790B7F8C471B3A1336522C7415FB0AC36D47B_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
{
		// private Dictionary<ObjLoopHash, int> _globalIndexRemap = new Dictionary<ObjLoopHash, int>();
		Dictionary_2_tEAE7D7DBCEF056EB634E23611F29B7D56A4614FE* L_0 = (Dictionary_2_tEAE7D7DBCEF056EB634E23611F29B7D56A4614FE*)il2cpp_codegen_object_new(Dictionary_2_tEAE7D7DBCEF056EB634E23611F29B7D56A4614FE_il2cpp_TypeInfo_var);
		Dictionary_2__ctor_m63CFEDABA0B46AEB5DB36FFBCDDAD873A37C82FE(L_0, /*hidden argument*/Dictionary_2__ctor_m63CFEDABA0B46AEB5DB36FFBCDDAD873A37C82FE_RuntimeMethod_var);
		__this->____globalIndexRemap_3 = L_0;
		Il2CppCodeGenWriteBarrier((void**)(&__this->____globalIndexRemap_3), (void*)L_0);
		// private Dictionary<string, List<int>> _materialIndices = new Dictionary<string, List<int>>();
		Dictionary_2_t6FFAD029BB474A5257D9A441504B633831AF5341* L_1 = (Dictionary_2_t6FFAD029BB474A5257D9A441504B633831AF5341*)il2cpp_codegen_object_new(Dictionary_2_t6FFAD029BB474A5257D9A441504B633831AF5341_il2cpp_TypeInfo_var);
		Dictionary_2__ctor_m82637A3A6031C43DB9CC910DBD6DCC66D9459C8F(L_1, /*hidden argument*/Dictionary_2__ctor_m82637A3A6031C43DB9CC910DBD6DCC66D9459C8F_RuntimeMethod_var);
		__this->____materialIndices_4 = L_1;
		Il2CppCodeGenWriteBarrier((void**)(&__this->____materialIndices_4), (void*)L_1);
		// private List<Vector3> _vertices = new List<Vector3>();
		List_1_t77B94703E05C519A9010DD0614F757F974E1CD8B* L_2 = (List_1_t77B94703E05C519A9010DD0614F757F974E1CD8B*)il2cpp_codegen_object_new(List_1_t77B94703E05C519A9010DD0614F757F974E1CD8B_il2cpp_TypeInfo_var);
		List_1__ctor_mC54E2BCBE43279A96FC082F5CDE2D76388BD8F9C(L_2, /*hidden argument*/List_1__ctor_mC54E2BCBE43279A96FC082F5CDE2D76388BD8F9C_RuntimeMethod_var);
		__this->____vertices_7 = L_2;
		Il2CppCodeGenWriteBarrier((void**)(&__this->____vertices_7), (void*)L_2);
		// private List<Vector3> _normals = new List<Vector3>();
		List_1_t77B94703E05C519A9010DD0614F757F974E1CD8B* L_3 = (List_1_t77B94703E05C519A9010DD0614F757F974E1CD8B*)il2cpp_codegen_object_new(List_1_t77B94703E05C519A9010DD0614F757F974E1CD8B_il2cpp_TypeInfo_var);
		List_1__ctor_mC54E2BCBE43279A96FC082F5CDE2D76388BD8F9C(L_3, /*hidden argument*/List_1__ctor_mC54E2BCBE43279A96FC082F5CDE2D76388BD8F9C_RuntimeMethod_var);
		__this->____normals_8 = L_3;
		Il2CppCodeGenWriteBarrier((void**)(&__this->____normals_8), (void*)L_3);
		// private List<Vector2> _uvs = new List<Vector2>();
		List_1_t8F3790B7F8C471B3A1336522C7415FB0AC36D47B* L_4 = (List_1_t8F3790B7F8C471B3A1336522C7415FB0AC36D47B*)il2cpp_codegen_object_new(List_1_t8F3790B7F8C471B3A1336522C7415FB0AC36D47B_il2cpp_TypeInfo_var);
		List_1__ctor_m88C4BD8AC607DB3585552068F4DC437406358D5F(L_4, /*hidden argument*/List_1__ctor_m88C4BD8AC607DB3585552068F4DC437406358D5F_RuntimeMethod_var);
		__this->____uvs_9 = L_4;
		Il2CppCodeGenWriteBarrier((void**)(&__this->____uvs_9), (void*)L_4);
		// public OBJObjectBuilder(string name, OBJLoader loader) {
		Object__ctor_mE837C6B9FA8C6D5D109F4B2EC885D79919AC0EA2(__this, NULL);
		// _name = name;
		String_t* L_5 = ___name0;
		__this->____name_2 = L_5;
		Il2CppCodeGenWriteBarrier((void**)(&__this->____name_2), (void*)L_5);
		// _loader = loader;
		OBJLoader_tB5927F8DB92B05302380425D21E9BCE654FD66BF* L_6 = ___loader1;
		__this->____loader_1 = L_6;
		Il2CppCodeGenWriteBarrier((void**)(&__this->____loader_1), (void*)L_6);
		// }
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Boolean Dummiesman.OBJObjectBuilder/ObjLoopHash::Equals(System.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool ObjLoopHash_Equals_m4F9C4B4A8E87AF0AF1EC4362D40042EE1DD10A02 (ObjLoopHash_t0314B9758A262019FC1EFB5432DE4F2D2139B20B* __this, RuntimeObject* ___obj0, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ObjLoopHash_t0314B9758A262019FC1EFB5432DE4F2D2139B20B_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
ObjLoopHash_t0314B9758A262019FC1EFB5432DE4F2D2139B20B* V_0 = NULL;
	{
		// if (!(obj is ObjLoopHash))
		RuntimeObject* L_0 = ___obj0;
		if (((ObjLoopHash_t0314B9758A262019FC1EFB5432DE4F2D2139B20B*)IsInstClass((RuntimeObject*)L_0, ObjLoopHash_t0314B9758A262019FC1EFB5432DE4F2D2139B20B_il2cpp_TypeInfo_var)))
		{
			goto IL_000a;
		}
	}
	{
		// return false;
		return (bool)0;
	}

IL_000a:
	{
		// var hash = obj as ObjLoopHash;
		RuntimeObject* L_1 = ___obj0;
		V_0 = ((ObjLoopHash_t0314B9758A262019FC1EFB5432DE4F2D2139B20B*)IsInstClass((RuntimeObject*)L_1, ObjLoopHash_t0314B9758A262019FC1EFB5432DE4F2D2139B20B_il2cpp_TypeInfo_var));
		// return (hash.vertexIndex == vertexIndex) && (hash.uvIndex == uvIndex) && (hash.normalIndex == normalIndex);
		ObjLoopHash_t0314B9758A262019FC1EFB5432DE4F2D2139B20B* L_2 = V_0;
		NullCheck(L_2);
		int32_t L_3 = L_2->___vertexIndex_0;
		int32_t L_4 = __this->___vertexIndex_0;
		if ((!(((uint32_t)L_3) == ((uint32_t)L_4))))
		{
			goto IL_003c;
		}
	}
	{
		ObjLoopHash_t0314B9758A262019FC1EFB5432DE4F2D2139B20B* L_5 = V_0;
		NullCheck(L_5);
		int32_t L_6 = L_5->___uvIndex_2;
		int32_t L_7 = __this->___uvIndex_2;
		if ((!(((uint32_t)L_6) == ((uint32_t)L_7))))
		{
			goto IL_003c;
		}
	}
	{
		ObjLoopHash_t0314B9758A262019FC1EFB5432DE4F2D2139B20B* L_8 = V_0;
		NullCheck(L_8);
		int32_t L_9 = L_8->___normalIndex_1;
		int32_t L_10 = __this->___normalIndex_1;
		return (bool)((((int32_t)L_9) == ((int32_t)L_10))? 1 : 0);
	}

IL_003c:
	{
		return (bool)0;
	}
}
// System.Int32 Dummiesman.OBJObjectBuilder/ObjLoopHash::GetHashCode()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t ObjLoopHash_GetHashCode_m2701CFFA34CC705850631AF646BDCD02A09F3E64 (ObjLoopHash_t0314B9758A262019FC1EFB5432DE4F2D2139B20B* __this, const RuntimeMethod* method) 
{
{
		// int hc = 3;
		// hc = unchecked(hc * 314159 + vertexIndex);
		int32_t L_0 = __this->___vertexIndex_0;
		// hc = unchecked(hc * 314159 + normalIndex);
		int32_t L_1 = __this->___normalIndex_1;
		// hc = unchecked(hc * 314159 + uvIndex);
		int32_t L_2 = __this->___uvIndex_2;
		// return hc;
		return ((int32_t)il2cpp_codegen_add(((int32_t)il2cpp_codegen_multiply(((int32_t)il2cpp_codegen_add(((int32_t)il2cpp_codegen_multiply(((int32_t)il2cpp_codegen_add(((int32_t)il2cpp_codegen_multiply(3, ((int32_t)314159))), L_0)), ((int32_t)314159))), L_1)), ((int32_t)314159))), L_2));
	}
}
// System.Void Dummiesman.OBJObjectBuilder/ObjLoopHash::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ObjLoopHash__ctor_m47684E1CB5D8B5CCC4D682B98F165C87AF514445 (ObjLoopHash_t0314B9758A262019FC1EFB5432DE4F2D2139B20B* __this, const RuntimeMethod* method) 
{
{
		Object__ctor_mE837C6B9FA8C6D5D109F4B2EC885D79919AC0EA2(__this, NULL);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.String Dummiesman.StringExtensions::Clean(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* StringExtensions_Clean_m787E4113CB5990F1D44F337A4CB49084162A710B (String_t* ___str0, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral2386E77CF610F786B06A91AF2C1B3FD2282D2745);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral8A8EFDA91C6C257127F8C8D526FAD7E7552766AA);
		s_Il2CppMethodInitialized = true;
	}
String_t* V_0 = NULL;
	{
		// string rstr = str.Replace('\t', ' ');
		String_t* L_0 = ___str0;
		NullCheck(L_0);
		String_t* L_1;
		L_1 = String_Replace_m86403DC5F422D8D5E1CFAAF255B103CB807EDAAF(L_0, ((int32_t)9), ((int32_t)32), NULL);
		V_0 = L_1;
		goto IL_001e;
	}

IL_000d:
	{
		// rstr = rstr.Replace("  ", " ");
		String_t* L_2 = V_0;
		NullCheck(L_2);
		String_t* L_3;
		L_3 = String_Replace_mABDB7003A1D0AEDCAE9FF85E3DFFFBA752D2A166(L_2, _stringLiteral8A8EFDA91C6C257127F8C8D526FAD7E7552766AA, _stringLiteral2386E77CF610F786B06A91AF2C1B3FD2282D2745, NULL);
		V_0 = L_3;
	}

IL_001e:
	{
		// while (rstr.Contains("  "))
		String_t* L_4 = V_0;
		NullCheck(L_4);
		bool L_5;
		L_5 = String_Contains_m6D77B121FADA7CA5F397C0FABB65DA62DF03B6C3(L_4, _stringLiteral8A8EFDA91C6C257127F8C8D526FAD7E7552766AA, NULL);
		if (L_5)
		{
			goto IL_000d;
		}
	}
	{
		// return rstr.Trim();
		String_t* L_6 = V_0;
		NullCheck(L_6);
		String_t* L_7;
		L_7 = String_Trim_mCD6D8C6D4CFD15225D12DB7D3E0544CA80FB8DA5(L_6, NULL);
		return L_7;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// UnityEngine.Color32 Dummiesman.BinaryExtensions::ReadColor32RGBR(System.IO.BinaryReader)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B BinaryExtensions_ReadColor32RGBR_m219663265B33A21E2152789FF26580DB9F0AE33D (BinaryReader_t9A6D85F0FE9AE4EBB5E8D66997DFD1D84939E158* ___r0, const RuntimeMethod* method) 
{
ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* V_0 = NULL;
	{
		// var bytes = r.ReadBytes(4);
		BinaryReader_t9A6D85F0FE9AE4EBB5E8D66997DFD1D84939E158* L_0 = ___r0;
		NullCheck(L_0);
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_1;
		L_1 = VirtualFuncInvoker1< ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031*, int32_t >::Invoke(25 /* System.Byte[] System.IO.BinaryReader::ReadBytes(System.Int32) */, L_0, 4);
		V_0 = L_1;
		// return new Color32(bytes[0], bytes[1], bytes[2], 255);
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_2 = V_0;
		NullCheck(L_2);
		int32_t L_3 = 0;
		uint8_t L_4 = (L_2)->GetAt(static_cast<il2cpp_array_size_t>(L_3));
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_5 = V_0;
		NullCheck(L_5);
		int32_t L_6 = 1;
		uint8_t L_7 = (L_5)->GetAt(static_cast<il2cpp_array_size_t>(L_6));
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_8 = V_0;
		NullCheck(L_8);
		int32_t L_9 = 2;
		uint8_t L_10 = (L_8)->GetAt(static_cast<il2cpp_array_size_t>(L_9));
		Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B L_11;
		memset((&L_11), 0, sizeof(L_11));
		Color32__ctor_mC9C6B443F0C7CA3F8B174158B2AF6F05E18EAC4E_inline((&L_11), L_4, L_7, L_10, (uint8_t)((int32_t)255), /*hidden argument*/NULL);
		return L_11;
	}
}
// UnityEngine.Color32 Dummiesman.BinaryExtensions::ReadColor32RGBA(System.IO.BinaryReader)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B BinaryExtensions_ReadColor32RGBA_mBD1FED9FE25413CA2E48363DC7B9FB3CF0E799D3 (BinaryReader_t9A6D85F0FE9AE4EBB5E8D66997DFD1D84939E158* ___r0, const RuntimeMethod* method) 
{
ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* V_0 = NULL;
	{
		// var bytes = r.ReadBytes(4);
		BinaryReader_t9A6D85F0FE9AE4EBB5E8D66997DFD1D84939E158* L_0 = ___r0;
		NullCheck(L_0);
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_1;
		L_1 = VirtualFuncInvoker1< ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031*, int32_t >::Invoke(25 /* System.Byte[] System.IO.BinaryReader::ReadBytes(System.Int32) */, L_0, 4);
		V_0 = L_1;
		// return new Color32(bytes[0], bytes[1], bytes[2], bytes[3]);
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_2 = V_0;
		NullCheck(L_2);
		int32_t L_3 = 0;
		uint8_t L_4 = (L_2)->GetAt(static_cast<il2cpp_array_size_t>(L_3));
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_5 = V_0;
		NullCheck(L_5);
		int32_t L_6 = 1;
		uint8_t L_7 = (L_5)->GetAt(static_cast<il2cpp_array_size_t>(L_6));
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_8 = V_0;
		NullCheck(L_8);
		int32_t L_9 = 2;
		uint8_t L_10 = (L_8)->GetAt(static_cast<il2cpp_array_size_t>(L_9));
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_11 = V_0;
		NullCheck(L_11);
		int32_t L_12 = 3;
		uint8_t L_13 = (L_11)->GetAt(static_cast<il2cpp_array_size_t>(L_12));
		Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B L_14;
		memset((&L_14), 0, sizeof(L_14));
		Color32__ctor_mC9C6B443F0C7CA3F8B174158B2AF6F05E18EAC4E_inline((&L_14), L_4, L_7, L_10, L_13, /*hidden argument*/NULL);
		return L_14;
	}
}
// UnityEngine.Color32 Dummiesman.BinaryExtensions::ReadColor32RGB(System.IO.BinaryReader)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B BinaryExtensions_ReadColor32RGB_m25BA23FD7D871C11D22BF555A7044B96EE501DF9 (BinaryReader_t9A6D85F0FE9AE4EBB5E8D66997DFD1D84939E158* ___r0, const RuntimeMethod* method) 
{
ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* V_0 = NULL;
	{
		// var bytes = r.ReadBytes(3);
		BinaryReader_t9A6D85F0FE9AE4EBB5E8D66997DFD1D84939E158* L_0 = ___r0;
		NullCheck(L_0);
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_1;
		L_1 = VirtualFuncInvoker1< ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031*, int32_t >::Invoke(25 /* System.Byte[] System.IO.BinaryReader::ReadBytes(System.Int32) */, L_0, 3);
		V_0 = L_1;
		// return new Color32(bytes[0], bytes[1], bytes[2], 255);
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_2 = V_0;
		NullCheck(L_2);
		int32_t L_3 = 0;
		uint8_t L_4 = (L_2)->GetAt(static_cast<il2cpp_array_size_t>(L_3));
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_5 = V_0;
		NullCheck(L_5);
		int32_t L_6 = 1;
		uint8_t L_7 = (L_5)->GetAt(static_cast<il2cpp_array_size_t>(L_6));
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_8 = V_0;
		NullCheck(L_8);
		int32_t L_9 = 2;
		uint8_t L_10 = (L_8)->GetAt(static_cast<il2cpp_array_size_t>(L_9));
		Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B L_11;
		memset((&L_11), 0, sizeof(L_11));
		Color32__ctor_mC9C6B443F0C7CA3F8B174158B2AF6F05E18EAC4E_inline((&L_11), L_4, L_7, L_10, (uint8_t)((int32_t)255), /*hidden argument*/NULL);
		return L_11;
	}
}
// UnityEngine.Color32 Dummiesman.BinaryExtensions::ReadColor32BGR(System.IO.BinaryReader)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B BinaryExtensions_ReadColor32BGR_mB45A788B5BC1689536829C0CE56EC304A0865B6B (BinaryReader_t9A6D85F0FE9AE4EBB5E8D66997DFD1D84939E158* ___r0, const RuntimeMethod* method) 
{
ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* V_0 = NULL;
	{
		// var bytes = r.ReadBytes(3);
		BinaryReader_t9A6D85F0FE9AE4EBB5E8D66997DFD1D84939E158* L_0 = ___r0;
		NullCheck(L_0);
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_1;
		L_1 = VirtualFuncInvoker1< ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031*, int32_t >::Invoke(25 /* System.Byte[] System.IO.BinaryReader::ReadBytes(System.Int32) */, L_0, 3);
		V_0 = L_1;
		// return new Color32(bytes[2], bytes[1], bytes[0], 255);
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_2 = V_0;
		NullCheck(L_2);
		int32_t L_3 = 2;
		uint8_t L_4 = (L_2)->GetAt(static_cast<il2cpp_array_size_t>(L_3));
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_5 = V_0;
		NullCheck(L_5);
		int32_t L_6 = 1;
		uint8_t L_7 = (L_5)->GetAt(static_cast<il2cpp_array_size_t>(L_6));
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_8 = V_0;
		NullCheck(L_8);
		int32_t L_9 = 0;
		uint8_t L_10 = (L_8)->GetAt(static_cast<il2cpp_array_size_t>(L_9));
		Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B L_11;
		memset((&L_11), 0, sizeof(L_11));
		Color32__ctor_mC9C6B443F0C7CA3F8B174158B2AF6F05E18EAC4E_inline((&L_11), L_4, L_7, L_10, (uint8_t)((int32_t)255), /*hidden argument*/NULL);
		return L_11;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// UnityEngine.Texture2D Dummiesman.DDSLoader::Load(System.IO.Stream)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* DDSLoader_Load_mF25129AE55E29A32883B8334AB2D5855DCDFAC2C (Stream_tF844051B786E8F7F4244DBD218D74E8617B9A2DE* ___ddsStream0, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&DDSLoader_Load_mF25129AE55E29A32883B8334AB2D5855DCDFAC2C_RuntimeMethod_var);
		s_Il2CppMethodInitialized = true;
	}
ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* V_0 = NULL;
	{
		// byte[] buffer = new byte[ddsStream.Length];
		Stream_tF844051B786E8F7F4244DBD218D74E8617B9A2DE* L_0 = ___ddsStream0;
		NullCheck(L_0);
		int64_t L_1;
		L_1 = VirtualFuncInvoker0< int64_t >::Invoke(11 /* System.Int64 System.IO.Stream::get_Length() */, L_0);
		if ((int64_t)(L_1) > INTPTR_MAX) IL2CPP_RAISE_MANAGED_EXCEPTION(il2cpp_codegen_get_overflow_exception(), DDSLoader_Load_mF25129AE55E29A32883B8334AB2D5855DCDFAC2C_RuntimeMethod_var);
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_2 = (ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031*)(ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031*)SZArrayNew(ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031_il2cpp_TypeInfo_var, (uint32_t)((intptr_t)L_1));
		V_0 = L_2;
		// ddsStream.Read(buffer, 0, (int)ddsStream.Length);
		Stream_tF844051B786E8F7F4244DBD218D74E8617B9A2DE* L_3 = ___ddsStream0;
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_4 = V_0;
		Stream_tF844051B786E8F7F4244DBD218D74E8617B9A2DE* L_5 = ___ddsStream0;
		NullCheck(L_5);
		int64_t L_6;
		L_6 = VirtualFuncInvoker0< int64_t >::Invoke(11 /* System.Int64 System.IO.Stream::get_Length() */, L_5);
		NullCheck(L_3);
		int32_t L_7;
		L_7 = VirtualFuncInvoker3< int32_t, ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031*, int32_t, int32_t >::Invoke(32 /* System.Int32 System.IO.Stream::Read(System.Byte[],System.Int32,System.Int32) */, L_3, L_4, 0, ((int32_t)L_6));
		// return Load(buffer);
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_8 = V_0;
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_9;
		L_9 = DDSLoader_Load_m11E28E4EA6EDE7B53BB990A398F4281D2BDA56AF(L_8, NULL);
		return L_9;
	}
}
// UnityEngine.Texture2D Dummiesman.DDSLoader::Load(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* DDSLoader_Load_m3A84E5DB9424184C64A9F5488903BAF6068B68C9 (String_t* ___ddsPath0, const RuntimeMethod* method) 
{
{
		// return Load(File.ReadAllBytes(ddsPath));
		String_t* L_0 = ___ddsPath0;
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_1;
		L_1 = File_ReadAllBytes_mE0C2C5A0270CD40C496E85B1D8BA15C607E7011E(L_0, NULL);
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_2;
		L_2 = DDSLoader_Load_m11E28E4EA6EDE7B53BB990A398F4281D2BDA56AF(L_1, NULL);
		return L_2;
	}
}
// UnityEngine.Texture2D Dummiesman.DDSLoader::Load(System.Byte[])
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* DDSLoader_Load_m11E28E4EA6EDE7B53BB990A398F4281D2BDA56AF (ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* ___ddsBytes0, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
uint8_t V_0 = 0x0;
	int32_t V_1 = 0;
	bool V_2 = false;
	int32_t V_3 = 0;
	int32_t V_4 = 0;
	ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* V_5 = NULL;
	Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* V_6 = NULL;
	Exception_t* V_7 = NULL;
	il2cpp::utils::ExceptionSupportStack<RuntimeObject*, 1> __active_exceptions;
	int32_t G_B7_0 = 0;
	int32_t G_B6_0 = 0;
	int32_t G_B8_0 = 0;
	int32_t G_B8_1 = 0;

IL_0000:
	try
	{// begin try (depth: 1)
		{
			// byte ddsSizeCheck = ddsBytes[4];
			ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_0 = ___ddsBytes0;
			NullCheck(L_0);
			int32_t L_1 = 4;
			uint8_t L_2 = (L_0)->GetAt(static_cast<il2cpp_array_size_t>(L_1));
			// if (ddsSizeCheck != 124)
			if ((((int32_t)L_2) == ((int32_t)((int32_t)124))))
			{
				goto IL_0012;
			}
		}

IL_0007:
		{
			// throw new System.Exception("Invalid DDS header. Structure length is incrrrect."); //this header byte should be 124 for DDS image files
			Exception_t* L_3 = (Exception_t*)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&Exception_t_il2cpp_TypeInfo_var)));
			Exception__ctor_m9B2BD92CD68916245A75109105D9071C9D430E7F(L_3, ((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteralCACB21833BB4CA1A557B18751B7691C087DC04A2)), /*hidden argument*/NULL);
			IL2CPP_RAISE_MANAGED_EXCEPTION(L_3, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&DDSLoader_Load_m11E28E4EA6EDE7B53BB990A398F4281D2BDA56AF_RuntimeMethod_var)));
		}

IL_0012:
		{
			// byte DXTType = ddsBytes[87];
			ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_4 = ___ddsBytes0;
			NullCheck(L_4);
			int32_t L_5 = ((int32_t)87);
			uint8_t L_6 = (L_4)->GetAt(static_cast<il2cpp_array_size_t>(L_5));
			V_0 = L_6;
			// if (DXTType != 49 && DXTType != 53)
			uint8_t L_7 = V_0;
			if ((((int32_t)L_7) == ((int32_t)((int32_t)49))))
			{
				goto IL_002c;
			}
		}

IL_001c:
		{
			uint8_t L_8 = V_0;
			if ((((int32_t)L_8) == ((int32_t)((int32_t)53))))
			{
				goto IL_002c;
			}
		}

IL_0021:
		{
			// throw new System.Exception("Cannot load DDS due to an unsupported pixel format. Needs to be DXT1 or DXT5.");
			Exception_t* L_9 = (Exception_t*)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&Exception_t_il2cpp_TypeInfo_var)));
			Exception__ctor_m9B2BD92CD68916245A75109105D9071C9D430E7F(L_9, ((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteralDDA7CFEAD2959669C703813D83A33F35133DB619)), /*hidden argument*/NULL);
			IL2CPP_RAISE_MANAGED_EXCEPTION(L_9, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&DDSLoader_Load_m11E28E4EA6EDE7B53BB990A398F4281D2BDA56AF_RuntimeMethod_var)));
		}

IL_002c:
		{
			// int height = ddsBytes[13] * 256 + ddsBytes[12];
			ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_10 = ___ddsBytes0;
			NullCheck(L_10);
			int32_t L_11 = ((int32_t)13);
			uint8_t L_12 = (L_10)->GetAt(static_cast<il2cpp_array_size_t>(L_11));
			ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_13 = ___ddsBytes0;
			NullCheck(L_13);
			int32_t L_14 = ((int32_t)12);
			uint8_t L_15 = (L_13)->GetAt(static_cast<il2cpp_array_size_t>(L_14));
			V_1 = ((int32_t)il2cpp_codegen_add(((int32_t)il2cpp_codegen_multiply((int32_t)L_12, ((int32_t)256))), (int32_t)L_15));
			// int width = ddsBytes[17] * 256 + ddsBytes[16];
			ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_16 = ___ddsBytes0;
			NullCheck(L_16);
			int32_t L_17 = ((int32_t)17);
			uint8_t L_18 = (L_16)->GetAt(static_cast<il2cpp_array_size_t>(L_17));
			ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_19 = ___ddsBytes0;
			NullCheck(L_19);
			int32_t L_20 = ((int32_t)16);
			uint8_t L_21 = (L_19)->GetAt(static_cast<il2cpp_array_size_t>(L_20));
			// bool mipmaps = ddsBytes[28] > 0;
			ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_22 = ___ddsBytes0;
			NullCheck(L_22);
			int32_t L_23 = ((int32_t)28);
			uint8_t L_24 = (L_22)->GetAt(static_cast<il2cpp_array_size_t>(L_23));
			V_2 = (bool)((((int32_t)L_24) > ((int32_t)0))? 1 : 0);
			// TextureFormat textureFormat = DXTType == 49 ? TextureFormat.DXT1 : TextureFormat.DXT5;
			uint8_t L_25 = V_0;
			G_B6_0 = ((int32_t)il2cpp_codegen_add(((int32_t)il2cpp_codegen_multiply((int32_t)L_18, ((int32_t)256))), (int32_t)L_21));
			if ((((int32_t)L_25) == ((int32_t)((int32_t)49))))
			{
				G_B7_0 = ((int32_t)il2cpp_codegen_add(((int32_t)il2cpp_codegen_multiply((int32_t)L_18, ((int32_t)256))), (int32_t)L_21));
				goto IL_005c;
			}
		}

IL_0058:
		{
			G_B8_0 = ((int32_t)12);
			G_B8_1 = G_B6_0;
			goto IL_005e;
		}

IL_005c:
		{
			G_B8_0 = ((int32_t)10);
			G_B8_1 = G_B7_0;
		}

IL_005e:
		{
			V_3 = G_B8_0;
			// int DDS_HEADER_SIZE = 128;
			V_4 = ((int32_t)128);
			// byte[] dxtBytes = new byte[ddsBytes.Length - DDS_HEADER_SIZE];
			ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_26 = ___ddsBytes0;
			NullCheck(L_26);
			int32_t L_27 = V_4;
			ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_28 = (ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031*)(ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031*)SZArrayNew(ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031_il2cpp_TypeInfo_var, (uint32_t)((int32_t)il2cpp_codegen_subtract(((int32_t)(((RuntimeArray*)L_26)->max_length)), L_27)));
			V_5 = L_28;
			// Buffer.BlockCopy(ddsBytes, DDS_HEADER_SIZE, dxtBytes, 0, ddsBytes.Length - DDS_HEADER_SIZE);
			ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_29 = ___ddsBytes0;
			int32_t L_30 = V_4;
			ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_31 = V_5;
			ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_32 = ___ddsBytes0;
			NullCheck(L_32);
			int32_t L_33 = V_4;
			Buffer_BlockCopy_mD8CF7EC96ADA7A542CCA3F3C73510624E10197A9((RuntimeArray*)L_29, L_30, (RuntimeArray*)L_31, 0, ((int32_t)il2cpp_codegen_subtract(((int32_t)(((RuntimeArray*)L_32)->max_length)), L_33)), NULL);
			// Texture2D texture = new Texture2D(width, height, textureFormat, mipmaps);
			int32_t L_34 = V_1;
			int32_t L_35 = V_3;
			bool L_36 = V_2;
			Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_37 = (Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4*)il2cpp_codegen_object_new(Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4_il2cpp_TypeInfo_var);
			Texture2D__ctor_mECF60A9EC0638EC353C02C8E99B6B465D23BE917(L_37, G_B8_1, L_34, L_35, L_36, /*hidden argument*/NULL);
			// texture.LoadRawTextureData(dxtBytes);
			Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_38 = L_37;
			ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_39 = V_5;
			NullCheck(L_38);
			Texture2D_LoadRawTextureData_mB8D1DEB5FF8715A871D8043D48C9054FCFF4ED1B(L_38, L_39, NULL);
			// texture.Apply();
			Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_40 = L_38;
			NullCheck(L_40);
			Texture2D_Apply_mA014182C9EE0BBF6EEE3B286854F29E50EB972DC(L_40, NULL);
			// return texture;
			V_6 = L_40;
			goto IL_00b7;
		}
	}// end try (depth: 1)
	catch(Il2CppExceptionWrapper& e)
	{
		if(il2cpp_codegen_class_is_assignable_from (((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&Exception_t_il2cpp_TypeInfo_var)), il2cpp_codegen_object_class(e.ex)))
		{
			IL2CPP_PUSH_ACTIVE_EXCEPTION(e.ex);
			goto CATCH_009e;
		}
		throw e;
	}

CATCH_009e:
	{// begin catch(System.Exception)
		// catch (System.Exception ex)
		V_7 = ((Exception_t*)IL2CPP_GET_ACTIVE_EXCEPTION(Exception_t*));
		// throw new Exception("An error occured while loading DirectDraw Surface: " + ex.Message);
		Exception_t* L_41 = V_7;
		NullCheck(L_41);
		String_t* L_42;
		L_42 = VirtualFuncInvoker0< String_t* >::Invoke(5 /* System.String System.Exception::get_Message() */, L_41);
		String_t* L_43;
		L_43 = String_Concat_mAF2CE02CC0CB7460753D0A1A91CCF2B1E9804C5D(((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteral24A67F22FEE896ED79449BFCF3EC311FB14605C6)), L_42, NULL);
		Exception_t* L_44 = (Exception_t*)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&Exception_t_il2cpp_TypeInfo_var)));
		Exception__ctor_m9B2BD92CD68916245A75109105D9071C9D430E7F(L_44, L_43, /*hidden argument*/NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_44, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&DDSLoader_Load_m11E28E4EA6EDE7B53BB990A398F4281D2BDA56AF_RuntimeMethod_var)));
	}// end catch (depth: 1)

IL_00b7:
	{
		// }
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_45 = V_6;
		return L_45;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void Dummiesman.ImageLoader::SetNormalMap(UnityEngine.Texture2D&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ImageLoader_SetNormalMap_m9A763162D23F79EF2AB74C23A6B47CBC7547F889 (Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4** ___tex0, const RuntimeMethod* method) 
{
ColorU5BU5D_t612261CF293F6FFC3D80AB52259FF0DC2B2CC389* V_0 = NULL;
	int32_t V_1 = 0;
	Color_tD001788D726C3A7F1379BEED0260B9591F440C1F V_2;
	memset((&V_2), 0, sizeof(V_2));
	{
		// Color[] pixels = tex.GetPixels();
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4** L_0 = ___tex0;
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_1 = *((Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4**)L_0);
		NullCheck(L_1);
		ColorU5BU5D_t612261CF293F6FFC3D80AB52259FF0DC2B2CC389* L_2;
		L_2 = Texture2D_GetPixels_m77A00D71DF5CDC7DAA0EE66FF2C90A24C7604039(L_1, NULL);
		V_0 = L_2;
		// for (int i = 0; i < pixels.Length; i++)
		V_1 = 0;
		goto IL_0046;
	}

IL_000c:
	{
		// Color temp = pixels[i];
		ColorU5BU5D_t612261CF293F6FFC3D80AB52259FF0DC2B2CC389* L_3 = V_0;
		int32_t L_4 = V_1;
		NullCheck(L_3);
		int32_t L_5 = L_4;
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_6 = (L_3)->GetAt(static_cast<il2cpp_array_size_t>(L_5));
		V_2 = L_6;
		// temp.r = pixels[i].g;
		ColorU5BU5D_t612261CF293F6FFC3D80AB52259FF0DC2B2CC389* L_7 = V_0;
		int32_t L_8 = V_1;
		NullCheck(L_7);
		float L_9 = ((L_7)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_8)))->___g_1;
		(&V_2)->___r_0 = L_9;
		// temp.a = pixels[i].r;
		ColorU5BU5D_t612261CF293F6FFC3D80AB52259FF0DC2B2CC389* L_10 = V_0;
		int32_t L_11 = V_1;
		NullCheck(L_10);
		float L_12 = ((L_10)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_11)))->___r_0;
		(&V_2)->___a_3 = L_12;
		// pixels[i] = temp;
		ColorU5BU5D_t612261CF293F6FFC3D80AB52259FF0DC2B2CC389* L_13 = V_0;
		int32_t L_14 = V_1;
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_15 = V_2;
		NullCheck(L_13);
		(L_13)->SetAt(static_cast<il2cpp_array_size_t>(L_14), (Color_tD001788D726C3A7F1379BEED0260B9591F440C1F)L_15);
		// for (int i = 0; i < pixels.Length; i++)
		int32_t L_16 = V_1;
		V_1 = ((int32_t)il2cpp_codegen_add(L_16, 1));
	}

IL_0046:
	{
		// for (int i = 0; i < pixels.Length; i++)
		int32_t L_17 = V_1;
		ColorU5BU5D_t612261CF293F6FFC3D80AB52259FF0DC2B2CC389* L_18 = V_0;
		NullCheck(L_18);
		if ((((int32_t)L_17) < ((int32_t)((int32_t)(((RuntimeArray*)L_18)->max_length)))))
		{
			goto IL_000c;
		}
	}
	{
		// tex.SetPixels(pixels);
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4** L_19 = ___tex0;
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_20 = *((Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4**)L_19);
		ColorU5BU5D_t612261CF293F6FFC3D80AB52259FF0DC2B2CC389* L_21 = V_0;
		NullCheck(L_20);
		Texture2D_SetPixels_mAE0CDFA15FA96F840D7FFADC31405D8AF20D9073(L_20, L_21, NULL);
		// tex.Apply(true);
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4** L_22 = ___tex0;
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_23 = *((Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4**)L_22);
		NullCheck(L_23);
		Texture2D_Apply_mCC369BCAB2D3AD3EE50EE01DA67AF227865FA2B3(L_23, (bool)1, NULL);
		// }
		return;
	}
}
// UnityEngine.Texture2D Dummiesman.ImageLoader::LoadTexture(System.IO.Stream,Dummiesman.ImageLoader/TextureFormat)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* ImageLoader_LoadTexture_m18E6BD5678745378336D315F849BF352A8D4B099 (Stream_tF844051B786E8F7F4244DBD218D74E8617B9A2DE* ___stream0, int32_t ___format1, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&BMPLoader_t8C88A751EA549C5D60C3E41F58F456A97D8B5C83_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ImageLoader_LoadTexture_m18E6BD5678745378336D315F849BF352A8D4B099_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* V_0 = NULL;
	{
		// if (format == TextureFormat.BMP)
		int32_t L_0 = ___format1;
		if ((!(((uint32_t)L_0) == ((uint32_t)2))))
		{
			goto IL_0015;
		}
	}
	{
		// return new BMPLoader().LoadBMP(stream).ToTexture2D();
		BMPLoader_t8C88A751EA549C5D60C3E41F58F456A97D8B5C83* L_1 = (BMPLoader_t8C88A751EA549C5D60C3E41F58F456A97D8B5C83*)il2cpp_codegen_object_new(BMPLoader_t8C88A751EA549C5D60C3E41F58F456A97D8B5C83_il2cpp_TypeInfo_var);
		BMPLoader__ctor_mE1F6B7D4F696A40E6932B4B64EB677F8E5303CFA(L_1, /*hidden argument*/NULL);
		Stream_tF844051B786E8F7F4244DBD218D74E8617B9A2DE* L_2 = ___stream0;
		NullCheck(L_1);
		BMPImage_tA6E059574F192A9BB574E7B260012D990055F05C* L_3;
		L_3 = BMPLoader_LoadBMP_m0131F513F34E1A490D639C0F46E8E18B9DFB25B7(L_1, L_2, NULL);
		NullCheck(L_3);
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_4;
		L_4 = BMPImage_ToTexture2D_m0E65B93ED38B9B8308E4314459DEFAB4D3277F32(L_3, NULL);
		return L_4;
	}

IL_0015:
	{
		// else if (format == TextureFormat.DDS)
		int32_t L_5 = ___format1;
		if (L_5)
		{
			goto IL_001f;
		}
	}
	{
		// return DDSLoader.Load(stream);
		Stream_tF844051B786E8F7F4244DBD218D74E8617B9A2DE* L_6 = ___stream0;
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_7;
		L_7 = DDSLoader_Load_mF25129AE55E29A32883B8334AB2D5855DCDFAC2C(L_6, NULL);
		return L_7;
	}

IL_001f:
	{
		// else if (format == TextureFormat.JPG || format == TextureFormat.PNG)
		int32_t L_8 = ___format1;
		if ((((int32_t)L_8) == ((int32_t)4)))
		{
			goto IL_0027;
		}
	}
	{
		int32_t L_9 = ___format1;
		if ((!(((uint32_t)L_9) == ((uint32_t)3))))
		{
			goto IL_0054;
		}
	}

IL_0027:
	{
		// byte[] buffer = new byte[stream.Length];
		Stream_tF844051B786E8F7F4244DBD218D74E8617B9A2DE* L_10 = ___stream0;
		NullCheck(L_10);
		int64_t L_11;
		L_11 = VirtualFuncInvoker0< int64_t >::Invoke(11 /* System.Int64 System.IO.Stream::get_Length() */, L_10);
		if ((int64_t)(L_11) > INTPTR_MAX) IL2CPP_RAISE_MANAGED_EXCEPTION(il2cpp_codegen_get_overflow_exception(), ImageLoader_LoadTexture_m18E6BD5678745378336D315F849BF352A8D4B099_RuntimeMethod_var);
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_12 = (ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031*)(ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031*)SZArrayNew(ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031_il2cpp_TypeInfo_var, (uint32_t)((intptr_t)L_11));
		V_0 = L_12;
		// stream.Read(buffer, 0, (int)stream.Length);
		Stream_tF844051B786E8F7F4244DBD218D74E8617B9A2DE* L_13 = ___stream0;
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_14 = V_0;
		Stream_tF844051B786E8F7F4244DBD218D74E8617B9A2DE* L_15 = ___stream0;
		NullCheck(L_15);
		int64_t L_16;
		L_16 = VirtualFuncInvoker0< int64_t >::Invoke(11 /* System.Int64 System.IO.Stream::get_Length() */, L_15);
		NullCheck(L_13);
		int32_t L_17;
		L_17 = VirtualFuncInvoker3< int32_t, ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031*, int32_t, int32_t >::Invoke(32 /* System.Int32 System.IO.Stream::Read(System.Byte[],System.Int32,System.Int32) */, L_13, L_14, 0, ((int32_t)L_16));
		// Texture2D texture = new Texture2D(1, 1);
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_18 = (Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4*)il2cpp_codegen_object_new(Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4_il2cpp_TypeInfo_var);
		Texture2D__ctor_m3BA82E87442B7F69E118477069AE11101B9DF796(L_18, 1, 1, /*hidden argument*/NULL);
		// texture.LoadImage(buffer);
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_19 = L_18;
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_20 = V_0;
		bool L_21;
		L_21 = ImageConversion_LoadImage_mBB2DFA1F5BDFF2B81DD0453356EFB092BC5180EC(L_19, L_20, NULL);
		// return texture;
		return L_19;
	}

IL_0054:
	{
		// else if (format == TextureFormat.TGA)
		int32_t L_22 = ___format1;
		if ((!(((uint32_t)L_22) == ((uint32_t)1))))
		{
			goto IL_005f;
		}
	}
	{
		// return TGALoader.Load(stream);
		Stream_tF844051B786E8F7F4244DBD218D74E8617B9A2DE* L_23 = ___stream0;
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_24;
		L_24 = TGALoader_Load_mB5CF838E183A7538AF925552AC81CA3B6C9AFC0D(L_23, NULL);
		return L_24;
	}

IL_005f:
	{
		// return null;
		return (Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4*)NULL;
	}
}
// UnityEngine.Texture2D Dummiesman.ImageLoader::LoadTexture(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* ImageLoader_LoadTexture_m6E948D3CE3C6986EB42BD4CC456506B4F5DC60F5 (String_t* ___fn0, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&BMPLoader_t8C88A751EA549C5D60C3E41F58F456A97D8B5C83_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&BitConverter_t6E99605185963BC12B3D369E13F2B88997E64A27_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Debug_t8394C7EEAECA3689C2C9B9DE9C7166D73596276F_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Path_t8A38A801D0219E8209C1B1D90D82D4D755D998BC_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral0FFABE86E9532C726C3E9C7D10AFE388437A380D);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral1A3E4D14FCCE4BCFFF56E01EE25543AD3912FB19);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral23DF9991B71463C240582D176E347E7E47AEFF5A);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral4B9B40AAD718882F5C0B95FE844E4AA92BD49C42);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral911FC00FE8A864A9D1B8F87A75E4EE5041ACF43B);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral985B72B30ECE05DD4EF5FE142CEE0FB8BF53A98C);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral9FB5B88DDC4C14C62E4014842DEC88E8353401A0);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralA15C898F015A9B0BC3268E8883CD03008A56DE26);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralB93D5DFE334D74396F45A6431764B0B46F089032);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralBEFAFB5DB9B504BEEF8A79E3E990D713103F15A0);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralC00413A65EA4BBDF5F981E7DC7F68313AA28D95F);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralCCC77F6BEC01F19B25AEAE1DA587DC5A6486B284);
		s_Il2CppMethodInitialized = true;
	}
ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* V_0 = NULL;
	String_t* V_1 = NULL;
	String_t* V_2 = NULL;
	Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* V_3 = NULL;
	ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* V_4 = NULL;
	uint16_t V_5 = 0;
	uint16_t V_6 = 0;
	uint8_t V_7 = 0x0;
	int32_t V_8 = 0;
	uint32_t V_9 = 0;
	{
		// if (!File.Exists(fn))
		String_t* L_0 = ___fn0;
		bool L_1;
		L_1 = File_Exists_mD7E7A84A6B9E9A9BADBDA7C46AAE0624EF106D85(L_0, NULL);
		if (L_1)
		{
			goto IL_000a;
		}
	}
	{
		// return null;
		return (Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4*)NULL;
	}

IL_000a:
	{
		// var textureBytes = File.ReadAllBytes(fn);
		String_t* L_2 = ___fn0;
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_3;
		L_3 = File_ReadAllBytes_mE0C2C5A0270CD40C496E85B1D8BA15C607E7011E(L_2, NULL);
		V_0 = L_3;
		// string ext = Path.GetExtension(fn).ToLower();
		String_t* L_4 = ___fn0;
		il2cpp_codegen_runtime_class_init_inline(Path_t8A38A801D0219E8209C1B1D90D82D4D755D998BC_il2cpp_TypeInfo_var);
		String_t* L_5;
		L_5 = Path_GetExtension_m52A28295599B87FA550D0654E531B56354C540C7(L_4, NULL);
		NullCheck(L_5);
		String_t* L_6;
		L_6 = String_ToLower_m6191ABA3DC514ED47C10BDA23FD0DDCEAE7ACFBD(L_5, NULL);
		V_1 = L_6;
		// string name = Path.GetFileName(fn);
		String_t* L_7 = ___fn0;
		String_t* L_8;
		L_8 = Path_GetFileName_mEBC73E0C8D8C56214D1DA4BA8409C5B5F00457A5(L_7, NULL);
		V_2 = L_8;
		// Texture2D returnTex = null;
		V_3 = (Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4*)NULL;
		String_t* L_9 = V_1;
		uint32_t L_10;
		L_10 = U3CPrivateImplementationDetailsU3E_ComputeStringHash_m9E43873DE0DF480D27EC1C2AA3C09E74EA77F75D(L_9, NULL);
		V_9 = L_10;
		uint32_t L_11 = V_9;
		if ((!(((uint32_t)L_11) <= ((uint32_t)((int32_t)1388056268)))))
		{
			goto IL_005a;
		}
	}
	{
		uint32_t L_12 = V_9;
		if ((((int32_t)L_12) == ((int32_t)((int32_t)175576948))))
		{
			goto IL_00ee;
		}
	}
	{
		uint32_t L_13 = V_9;
		if ((((int32_t)L_13) == ((int32_t)((int32_t)1128223456))))
		{
			goto IL_0094;
		}
	}
	{
		uint32_t L_14 = V_9;
		if ((((int32_t)L_14) == ((int32_t)((int32_t)1388056268))))
		{
			goto IL_00a6;
		}
	}
	{
		goto IL_0219;
	}

IL_005a:
	{
		uint32_t L_15 = V_9;
		if ((!(((uint32_t)L_15) <= ((uint32_t)((int32_t)-786288218)))))
		{
			goto IL_007d;
		}
	}
	{
		uint32_t L_16 = V_9;
		if ((((int32_t)L_16) == ((int32_t)((int32_t)-2079391002))))
		{
			goto IL_0100;
		}
	}
	{
		uint32_t L_17 = V_9;
		if ((((int32_t)L_17) == ((int32_t)((int32_t)-786288218))))
		{
			goto IL_00ca;
		}
	}
	{
		goto IL_0219;
	}

IL_007d:
	{
		uint32_t L_18 = V_9;
		if ((((int32_t)L_18) == ((int32_t)((int32_t)-116413041))))
		{
			goto IL_00b8;
		}
	}
	{
		uint32_t L_19 = V_9;
		if ((((int32_t)L_19) == ((int32_t)((int32_t)-9225237))))
		{
			goto IL_00dc;
		}
	}
	{
		goto IL_0219;
	}

IL_0094:
	{
		String_t* L_20 = V_1;
		bool L_21;
		L_21 = String_op_Equality_m0D685A924E5CD78078F248ED1726DA5A9D7D6AC0(L_20, _stringLiteralA15C898F015A9B0BC3268E8883CD03008A56DE26, NULL);
		if (L_21)
		{
			goto IL_0112;
		}
	}
	{
		goto IL_0219;
	}

IL_00a6:
	{
		String_t* L_22 = V_1;
		bool L_23;
		L_23 = String_op_Equality_m0D685A924E5CD78078F248ED1726DA5A9D7D6AC0(L_22, _stringLiteral23DF9991B71463C240582D176E347E7E47AEFF5A, NULL);
		if (L_23)
		{
			goto IL_0112;
		}
	}
	{
		goto IL_0219;
	}

IL_00b8:
	{
		String_t* L_24 = V_1;
		bool L_25;
		L_25 = String_op_Equality_m0D685A924E5CD78078F248ED1726DA5A9D7D6AC0(L_24, _stringLiteral4B9B40AAD718882F5C0B95FE844E4AA92BD49C42, NULL);
		if (L_25)
		{
			goto IL_0112;
		}
	}
	{
		goto IL_0219;
	}

IL_00ca:
	{
		String_t* L_26 = V_1;
		bool L_27;
		L_27 = String_op_Equality_m0D685A924E5CD78078F248ED1726DA5A9D7D6AC0(L_26, _stringLiteralB93D5DFE334D74396F45A6431764B0B46F089032, NULL);
		if (L_27)
		{
			goto IL_0127;
		}
	}
	{
		goto IL_0219;
	}

IL_00dc:
	{
		String_t* L_28 = V_1;
		bool L_29;
		L_29 = String_op_Equality_m0D685A924E5CD78078F248ED1726DA5A9D7D6AC0(L_28, _stringLiteral0FFABE86E9532C726C3E9C7D10AFE388437A380D, NULL);
		if (L_29)
		{
			goto IL_0133;
		}
	}
	{
		goto IL_0219;
	}

IL_00ee:
	{
		String_t* L_30 = V_1;
		bool L_31;
		L_31 = String_op_Equality_m0D685A924E5CD78078F248ED1726DA5A9D7D6AC0(L_30, _stringLiteral985B72B30ECE05DD4EF5FE142CEE0FB8BF53A98C, NULL);
		if (L_31)
		{
			goto IL_013f;
		}
	}
	{
		goto IL_0219;
	}

IL_0100:
	{
		String_t* L_32 = V_1;
		bool L_33;
		L_33 = String_op_Equality_m0D685A924E5CD78078F248ED1726DA5A9D7D6AC0(L_32, _stringLiteralBEFAFB5DB9B504BEEF8A79E3E990D713103F15A0, NULL);
		if (L_33)
		{
			goto IL_0155;
		}
	}
	{
		goto IL_0219;
	}

IL_0112:
	{
		// returnTex = new Texture2D(1, 1);
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_34 = (Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4*)il2cpp_codegen_object_new(Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4_il2cpp_TypeInfo_var);
		Texture2D__ctor_m3BA82E87442B7F69E118477069AE11101B9DF796(L_34, 1, 1, /*hidden argument*/NULL);
		V_3 = L_34;
		// returnTex.LoadImage(textureBytes);
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_35 = V_3;
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_36 = V_0;
		bool L_37;
		L_37 = ImageConversion_LoadImage_mBB2DFA1F5BDFF2B81DD0453356EFB092BC5180EC(L_35, L_36, NULL);
		// break;
		goto IL_022f;
	}

IL_0127:
	{
		// returnTex = DDSLoader.Load(textureBytes);
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_38 = V_0;
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_39;
		L_39 = DDSLoader_Load_m11E28E4EA6EDE7B53BB990A398F4281D2BDA56AF(L_38, NULL);
		V_3 = L_39;
		// break;
		goto IL_022f;
	}

IL_0133:
	{
		// returnTex = TGALoader.Load(textureBytes);
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_40 = V_0;
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_41;
		L_41 = TGALoader_Load_m90B1879FA09E6480B21C87F484AF0C3CC611DCAB(L_40, NULL);
		V_3 = L_41;
		// break;
		goto IL_022f;
	}

IL_013f:
	{
		// returnTex = new BMPLoader().LoadBMP(textureBytes).ToTexture2D();
		BMPLoader_t8C88A751EA549C5D60C3E41F58F456A97D8B5C83* L_42 = (BMPLoader_t8C88A751EA549C5D60C3E41F58F456A97D8B5C83*)il2cpp_codegen_object_new(BMPLoader_t8C88A751EA549C5D60C3E41F58F456A97D8B5C83_il2cpp_TypeInfo_var);
		BMPLoader__ctor_mE1F6B7D4F696A40E6932B4B64EB677F8E5303CFA(L_42, /*hidden argument*/NULL);
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_43 = V_0;
		NullCheck(L_42);
		BMPImage_tA6E059574F192A9BB574E7B260012D990055F05C* L_44;
		L_44 = BMPLoader_LoadBMP_m6A621DEC5410845DE112A71843CEA2381C3DD4BD(L_42, L_43, NULL);
		NullCheck(L_44);
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_45;
		L_45 = BMPImage_ToTexture2D_m0E65B93ED38B9B8308E4314459DEFAB4D3277F32(L_44, NULL);
		V_3 = L_45;
		// break;
		goto IL_022f;
	}

IL_0155:
	{
		// byte[] crnBytes = textureBytes;
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_46 = V_0;
		V_4 = L_46;
		// ushort crnWidth = System.BitConverter.ToUInt16(new byte[2] { crnBytes[13], crnBytes[12] }, 0);
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_47 = (ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031*)(ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031*)SZArrayNew(ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031_il2cpp_TypeInfo_var, (uint32_t)2);
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_48 = L_47;
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_49 = V_4;
		NullCheck(L_49);
		int32_t L_50 = ((int32_t)13);
		uint8_t L_51 = (L_49)->GetAt(static_cast<il2cpp_array_size_t>(L_50));
		NullCheck(L_48);
		(L_48)->SetAt(static_cast<il2cpp_array_size_t>(0), (uint8_t)L_51);
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_52 = L_48;
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_53 = V_4;
		NullCheck(L_53);
		int32_t L_54 = ((int32_t)12);
		uint8_t L_55 = (L_53)->GetAt(static_cast<il2cpp_array_size_t>(L_54));
		NullCheck(L_52);
		(L_52)->SetAt(static_cast<il2cpp_array_size_t>(1), (uint8_t)L_55);
		il2cpp_codegen_runtime_class_init_inline(BitConverter_t6E99605185963BC12B3D369E13F2B88997E64A27_il2cpp_TypeInfo_var);
		uint16_t L_56;
		L_56 = BitConverter_ToUInt16_m133E286BF0B721DD973FD966F61CB171F70F3E32(L_52, 0, NULL);
		V_5 = L_56;
		// ushort crnHeight = System.BitConverter.ToUInt16(new byte[2] { crnBytes[15], crnBytes[14] }, 0);
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_57 = (ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031*)(ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031*)SZArrayNew(ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031_il2cpp_TypeInfo_var, (uint32_t)2);
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_58 = L_57;
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_59 = V_4;
		NullCheck(L_59);
		int32_t L_60 = ((int32_t)15);
		uint8_t L_61 = (L_59)->GetAt(static_cast<il2cpp_array_size_t>(L_60));
		NullCheck(L_58);
		(L_58)->SetAt(static_cast<il2cpp_array_size_t>(0), (uint8_t)L_61);
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_62 = L_58;
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_63 = V_4;
		NullCheck(L_63);
		int32_t L_64 = ((int32_t)14);
		uint8_t L_65 = (L_63)->GetAt(static_cast<il2cpp_array_size_t>(L_64));
		NullCheck(L_62);
		(L_62)->SetAt(static_cast<il2cpp_array_size_t>(1), (uint8_t)L_65);
		uint16_t L_66;
		L_66 = BitConverter_ToUInt16_m133E286BF0B721DD973FD966F61CB171F70F3E32(L_62, 0, NULL);
		V_6 = L_66;
		// byte crnFormatByte = crnBytes[18];
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_67 = V_4;
		NullCheck(L_67);
		int32_t L_68 = ((int32_t)18);
		uint8_t L_69 = (L_67)->GetAt(static_cast<il2cpp_array_size_t>(L_68));
		V_7 = L_69;
		// var crnTextureFormat = UnityEngine.TextureFormat.RGB24;
		V_8 = 3;
		// if (crnFormatByte == 0)
		uint8_t L_70 = V_7;
		if (L_70)
		{
			goto IL_01a8;
		}
	}
	{
		// crnTextureFormat = UnityEngine.TextureFormat.DXT1Crunched;
		V_8 = ((int32_t)28);
		goto IL_01fb;
	}

IL_01a8:
	{
		// }else if(crnFormatByte == 2)
		uint8_t L_71 = V_7;
		if ((!(((uint32_t)L_71) == ((uint32_t)2))))
		{
			goto IL_01b3;
		}
	}
	{
		// crnTextureFormat = UnityEngine.TextureFormat.DXT5Crunched;
		V_8 = ((int32_t)29);
		goto IL_01fb;
	}

IL_01b3:
	{
		// else if(crnFormatByte == 12)
		uint8_t L_72 = V_7;
		if ((!(((uint32_t)L_72) == ((uint32_t)((int32_t)12)))))
		{
			goto IL_01bf;
		}
	}
	{
		// crnTextureFormat = UnityEngine.TextureFormat.ETC2_RGBA8Crunched;
		V_8 = ((int32_t)65);
		goto IL_01fb;
	}

IL_01bf:
	{
		// Debug.LogError("Could not load crunched texture " + name + " because its format is not supported (" + crnFormatByte + "): " + fn);
		StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248* L_73 = (StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248*)(StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248*)SZArrayNew(StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248_il2cpp_TypeInfo_var, (uint32_t)6);
		StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248* L_74 = L_73;
		NullCheck(L_74);
		ArrayElementTypeCheck (L_74, _stringLiteralCCC77F6BEC01F19B25AEAE1DA587DC5A6486B284);
		(L_74)->SetAt(static_cast<il2cpp_array_size_t>(0), (String_t*)_stringLiteralCCC77F6BEC01F19B25AEAE1DA587DC5A6486B284);
		StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248* L_75 = L_74;
		String_t* L_76 = V_2;
		NullCheck(L_75);
		ArrayElementTypeCheck (L_75, L_76);
		(L_75)->SetAt(static_cast<il2cpp_array_size_t>(1), (String_t*)L_76);
		StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248* L_77 = L_75;
		NullCheck(L_77);
		ArrayElementTypeCheck (L_77, _stringLiteral1A3E4D14FCCE4BCFFF56E01EE25543AD3912FB19);
		(L_77)->SetAt(static_cast<il2cpp_array_size_t>(2), (String_t*)_stringLiteral1A3E4D14FCCE4BCFFF56E01EE25543AD3912FB19);
		StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248* L_78 = L_77;
		String_t* L_79;
		L_79 = Byte_ToString_mB80CE094B94215119578E4D796566E71D7277EE4((&V_7), NULL);
		NullCheck(L_78);
		ArrayElementTypeCheck (L_78, L_79);
		(L_78)->SetAt(static_cast<il2cpp_array_size_t>(3), (String_t*)L_79);
		StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248* L_80 = L_78;
		NullCheck(L_80);
		ArrayElementTypeCheck (L_80, _stringLiteral911FC00FE8A864A9D1B8F87A75E4EE5041ACF43B);
		(L_80)->SetAt(static_cast<il2cpp_array_size_t>(4), (String_t*)_stringLiteral911FC00FE8A864A9D1B8F87A75E4EE5041ACF43B);
		StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248* L_81 = L_80;
		String_t* L_82 = ___fn0;
		NullCheck(L_81);
		ArrayElementTypeCheck (L_81, L_82);
		(L_81)->SetAt(static_cast<il2cpp_array_size_t>(5), (String_t*)L_82);
		String_t* L_83;
		L_83 = String_Concat_m6B0734B65813C8EA093D78E5C2D16534EB6FE8C0(L_81, NULL);
		il2cpp_codegen_runtime_class_init_inline(Debug_t8394C7EEAECA3689C2C9B9DE9C7166D73596276F_il2cpp_TypeInfo_var);
		Debug_LogError_m059825802BB6AF7EA9693FEBEEB0D85F59A3E38E(L_83, NULL);
		// break;
		goto IL_022f;
	}

IL_01fb:
	{
		// returnTex = new Texture2D(crnWidth, crnHeight, crnTextureFormat, true);
		uint16_t L_84 = V_5;
		uint16_t L_85 = V_6;
		int32_t L_86 = V_8;
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_87 = (Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4*)il2cpp_codegen_object_new(Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4_il2cpp_TypeInfo_var);
		Texture2D__ctor_mECF60A9EC0638EC353C02C8E99B6B465D23BE917(L_87, L_84, L_85, L_86, (bool)1, /*hidden argument*/NULL);
		V_3 = L_87;
		// returnTex.LoadRawTextureData(crnBytes);
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_88 = V_3;
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_89 = V_4;
		NullCheck(L_88);
		Texture2D_LoadRawTextureData_mB8D1DEB5FF8715A871D8043D48C9054FCFF4ED1B(L_88, L_89, NULL);
		// returnTex.Apply(true);
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_90 = V_3;
		NullCheck(L_90);
		Texture2D_Apply_mCC369BCAB2D3AD3EE50EE01DA67AF227865FA2B3(L_90, (bool)1, NULL);
		// break;
		goto IL_022f;
	}

IL_0219:
	{
		// Debug.LogError("Could not load texture " + name + " because its format is not supported : " + fn);
		String_t* L_91 = V_2;
		String_t* L_92 = ___fn0;
		String_t* L_93;
		L_93 = String_Concat_mF8B69BE42B5C5ABCAD3C176FBBE3010E0815D65D(_stringLiteral9FB5B88DDC4C14C62E4014842DEC88E8353401A0, L_91, _stringLiteralC00413A65EA4BBDF5F981E7DC7F68313AA28D95F, L_92, NULL);
		il2cpp_codegen_runtime_class_init_inline(Debug_t8394C7EEAECA3689C2C9B9DE9C7166D73596276F_il2cpp_TypeInfo_var);
		Debug_LogError_m059825802BB6AF7EA9693FEBEEB0D85F59A3E38E(L_93, NULL);
	}

IL_022f:
	{
		// if (returnTex != null)
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_94 = V_3;
		il2cpp_codegen_runtime_class_init_inline(Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_il2cpp_TypeInfo_var);
		bool L_95;
		L_95 = Object_op_Inequality_m4D656395C27694A7F33F5AA8DE80A7AAF9E20BA7(L_94, (Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C*)NULL, NULL);
		if (!L_95)
		{
			goto IL_024b;
		}
	}
	{
		// returnTex = ImageLoaderHelper.VerifyFormat(returnTex);
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_96 = V_3;
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_97;
		L_97 = ImageLoaderHelper_VerifyFormat_m2859E1A7AD80266E977B1EEC9FD1C256EECB3A0F(L_96, NULL);
		V_3 = L_97;
		// returnTex.name = Path.GetFileNameWithoutExtension(fn);
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_98 = V_3;
		String_t* L_99 = ___fn0;
		il2cpp_codegen_runtime_class_init_inline(Path_t8A38A801D0219E8209C1B1D90D82D4D755D998BC_il2cpp_TypeInfo_var);
		String_t* L_100;
		L_100 = Path_GetFileNameWithoutExtension_mD24A7CA7C45FF7A265EF7F8D5E19D1F3C014D90F(L_99, NULL);
		NullCheck(L_98);
		Object_set_name_mC79E6DC8FFD72479C90F0C4CC7F42A0FEAF5AE47(L_98, L_100, NULL);
	}

IL_024b:
	{
		// return returnTex;
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_101 = V_3;
		return L_101;
	}
}
// System.Void Dummiesman.ImageLoader::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ImageLoader__ctor_mD218225CB03566D60257CB1717366A3E372F0D85 (ImageLoader_t8A370851A05DC8FBFA9EF3A8348BC2D76445BD82* __this, const RuntimeMethod* method) 
{
{
		Object__ctor_mE837C6B9FA8C6D5D109F4B2EC885D79919AC0EA2(__this, NULL);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// UnityEngine.Texture2D Dummiesman.ImageLoaderHelper::VerifyFormat(UnityEngine.Texture2D)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* ImageLoaderHelper_VerifyFormat_m2859E1A7AD80266E977B1EEC9FD1C256EECB3A0F (Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* ___tex0, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
Color32U5BU5D_t38116C3E91765C4C5726CE12C77FAD7F9F737259* V_0 = NULL;
	bool V_1 = false;
	Color32U5BU5D_t38116C3E91765C4C5726CE12C77FAD7F9F737259* V_2 = NULL;
	int32_t V_3 = 0;
	{
		// if (tex.format != UnityEngine.TextureFormat.ARGB32 && tex.format != UnityEngine.TextureFormat.RGBA32 && tex.format != UnityEngine.TextureFormat.DXT5)
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_0 = ___tex0;
		NullCheck(L_0);
		int32_t L_1;
		L_1 = Texture2D_get_format_mE39DD922F83CA1097383309278BB6F20636A7D9D(L_0, NULL);
		if ((((int32_t)L_1) == ((int32_t)5)))
		{
			goto IL_001e;
		}
	}
	{
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_2 = ___tex0;
		NullCheck(L_2);
		int32_t L_3;
		L_3 = Texture2D_get_format_mE39DD922F83CA1097383309278BB6F20636A7D9D(L_2, NULL);
		if ((((int32_t)L_3) == ((int32_t)4)))
		{
			goto IL_001e;
		}
	}
	{
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_4 = ___tex0;
		NullCheck(L_4);
		int32_t L_5;
		L_5 = Texture2D_get_format_mE39DD922F83CA1097383309278BB6F20636A7D9D(L_4, NULL);
		if ((((int32_t)L_5) == ((int32_t)((int32_t)12))))
		{
			goto IL_001e;
		}
	}
	{
		// return tex;
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_6 = ___tex0;
		return L_6;
	}

IL_001e:
	{
		// var pixels = tex.GetPixels32();
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_7 = ___tex0;
		NullCheck(L_7);
		Color32U5BU5D_t38116C3E91765C4C5726CE12C77FAD7F9F737259* L_8;
		L_8 = Texture2D_GetPixels32_m48230192E7543765C1A517F251D1D9BFCFB58C3D(L_7, NULL);
		V_0 = L_8;
		// bool validFormat = false;
		V_1 = (bool)0;
		// foreach(var px in pixels)
		Color32U5BU5D_t38116C3E91765C4C5726CE12C77FAD7F9F737259* L_9 = V_0;
		V_2 = L_9;
		V_3 = 0;
		goto IL_0048;
	}

IL_002d:
	{
		// foreach(var px in pixels)
		Color32U5BU5D_t38116C3E91765C4C5726CE12C77FAD7F9F737259* L_10 = V_2;
		int32_t L_11 = V_3;
		NullCheck(L_10);
		int32_t L_12 = L_11;
		Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B L_13 = (L_10)->GetAt(static_cast<il2cpp_array_size_t>(L_12));
		// if(px.a < 255)
		uint8_t L_14 = L_13.___a_4;
		if ((((int32_t)L_14) >= ((int32_t)((int32_t)255))))
		{
			goto IL_0044;
		}
	}
	{
		// validFormat = true;
		V_1 = (bool)1;
		// break;
		goto IL_004e;
	}

IL_0044:
	{
		int32_t L_15 = V_3;
		V_3 = ((int32_t)il2cpp_codegen_add(L_15, 1));
	}

IL_0048:
	{
		// foreach(var px in pixels)
		int32_t L_16 = V_3;
		Color32U5BU5D_t38116C3E91765C4C5726CE12C77FAD7F9F737259* L_17 = V_2;
		NullCheck(L_17);
		if ((((int32_t)L_16) < ((int32_t)((int32_t)(((RuntimeArray*)L_17)->max_length)))))
		{
			goto IL_002d;
		}
	}

IL_004e:
	{
		// if (!validFormat)
		bool L_18 = V_1;
		if (L_18)
		{
			goto IL_007b;
		}
	}
	{
		// var tex24 = new Texture2D(tex.width, tex.height, UnityEngine.TextureFormat.RGB24, tex.mipmapCount > 0);
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_19 = ___tex0;
		NullCheck(L_19);
		int32_t L_20;
		L_20 = VirtualFuncInvoker0< int32_t >::Invoke(5 /* System.Int32 UnityEngine.Texture::get_width() */, L_19);
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_21 = ___tex0;
		NullCheck(L_21);
		int32_t L_22;
		L_22 = VirtualFuncInvoker0< int32_t >::Invoke(7 /* System.Int32 UnityEngine.Texture::get_height() */, L_21);
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_23 = ___tex0;
		NullCheck(L_23);
		int32_t L_24;
		L_24 = Texture_get_mipmapCount_m9E68435BC8E30B9821525BFC8121C34A53774023(L_23, NULL);
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_25 = (Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4*)il2cpp_codegen_object_new(Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4_il2cpp_TypeInfo_var);
		Texture2D__ctor_mECF60A9EC0638EC353C02C8E99B6B465D23BE917(L_25, L_20, L_22, 3, (bool)((((int32_t)L_24) > ((int32_t)0))? 1 : 0), /*hidden argument*/NULL);
		// tex24.SetPixels32(pixels);
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_26 = L_25;
		Color32U5BU5D_t38116C3E91765C4C5726CE12C77FAD7F9F737259* L_27 = V_0;
		NullCheck(L_26);
		Texture2D_SetPixels32_m169F9873A21FB8DECA24DC1B8F06FB23D13BEE2A(L_26, L_27, NULL);
		// tex24.Apply(true);
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_28 = L_26;
		NullCheck(L_28);
		Texture2D_Apply_mCC369BCAB2D3AD3EE50EE01DA67AF227865FA2B3(L_28, (bool)1, NULL);
		// return tex24;
		return L_28;
	}

IL_007b:
	{
		// return tex;
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_29 = ___tex0;
		return L_29;
	}
}
// System.Void Dummiesman.ImageLoaderHelper::FillPixelArray(UnityEngine.Color32[],System.Byte[],System.Int32,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ImageLoaderHelper_FillPixelArray_m6BFB48A1F8EE716042BA26E2E8E49BCFB153B097 (Color32U5BU5D_t38116C3E91765C4C5726CE12C77FAD7F9F737259* ___fillArray0, ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* ___pixelData1, int32_t ___bytesPerPixel2, bool ___bgra3, const RuntimeMethod* method) 
{
int32_t V_0 = 0;
	int32_t V_1 = 0;
	int32_t V_2 = 0;
	int32_t V_3 = 0;
	int32_t V_4 = 0;
	int32_t V_5 = 0;
	{
		// if (bgra)
		bool L_0 = ___bgra3;
		if (!L_0)
		{
			goto IL_007e;
		}
	}
	{
		// if (bytesPerPixel == 4)
		int32_t L_1 = ___bytesPerPixel2;
		if ((!(((uint32_t)L_1) == ((uint32_t)4))))
		{
			goto IL_0038;
		}
	}
	{
		// for (int i = 0; i < fillArray.Length; i++)
		V_0 = 0;
		goto IL_0031;
	}

IL_000b:
	{
		// int bi = i * bytesPerPixel;
		int32_t L_2 = V_0;
		int32_t L_3 = ___bytesPerPixel2;
		V_1 = ((int32_t)il2cpp_codegen_multiply(L_2, L_3));
		// fillArray[i] = new Color32(pixelData[bi + 2], pixelData[bi + 1], pixelData[bi], pixelData[bi + 3]);
		Color32U5BU5D_t38116C3E91765C4C5726CE12C77FAD7F9F737259* L_4 = ___fillArray0;
		int32_t L_5 = V_0;
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_6 = ___pixelData1;
		int32_t L_7 = V_1;
		NullCheck(L_6);
		int32_t L_8 = ((int32_t)il2cpp_codegen_add(L_7, 2));
		uint8_t L_9 = (L_6)->GetAt(static_cast<il2cpp_array_size_t>(L_8));
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_10 = ___pixelData1;
		int32_t L_11 = V_1;
		NullCheck(L_10);
		int32_t L_12 = ((int32_t)il2cpp_codegen_add(L_11, 1));
		uint8_t L_13 = (L_10)->GetAt(static_cast<il2cpp_array_size_t>(L_12));
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_14 = ___pixelData1;
		int32_t L_15 = V_1;
		NullCheck(L_14);
		int32_t L_16 = L_15;
		uint8_t L_17 = (L_14)->GetAt(static_cast<il2cpp_array_size_t>(L_16));
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_18 = ___pixelData1;
		int32_t L_19 = V_1;
		NullCheck(L_18);
		int32_t L_20 = ((int32_t)il2cpp_codegen_add(L_19, 3));
		uint8_t L_21 = (L_18)->GetAt(static_cast<il2cpp_array_size_t>(L_20));
		Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B L_22;
		memset((&L_22), 0, sizeof(L_22));
		Color32__ctor_mC9C6B443F0C7CA3F8B174158B2AF6F05E18EAC4E_inline((&L_22), L_9, L_13, L_17, L_21, /*hidden argument*/NULL);
		NullCheck(L_4);
		(L_4)->SetAt(static_cast<il2cpp_array_size_t>(L_5), (Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B)L_22);
		// for (int i = 0; i < fillArray.Length; i++)
		int32_t L_23 = V_0;
		V_0 = ((int32_t)il2cpp_codegen_add(L_23, 1));
	}

IL_0031:
	{
		// for (int i = 0; i < fillArray.Length; i++)
		int32_t L_24 = V_0;
		Color32U5BU5D_t38116C3E91765C4C5726CE12C77FAD7F9F737259* L_25 = ___fillArray0;
		NullCheck(L_25);
		if ((((int32_t)L_24) < ((int32_t)((int32_t)(((RuntimeArray*)L_25)->max_length)))))
		{
			goto IL_000b;
		}
	}
	{
		return;
	}

IL_0038:
	{
		// for (int i = 0; i < fillArray.Length; i++)
		V_2 = 0;
		goto IL_0077;
	}

IL_003c:
	{
		// fillArray[i].r = pixelData[(i * 3) + 2];
		Color32U5BU5D_t38116C3E91765C4C5726CE12C77FAD7F9F737259* L_26 = ___fillArray0;
		int32_t L_27 = V_2;
		NullCheck(L_26);
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_28 = ___pixelData1;
		int32_t L_29 = V_2;
		NullCheck(L_28);
		int32_t L_30 = ((int32_t)il2cpp_codegen_add(((int32_t)il2cpp_codegen_multiply(L_29, 3)), 2));
		uint8_t L_31 = (L_28)->GetAt(static_cast<il2cpp_array_size_t>(L_30));
		((L_26)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_27)))->___r_1 = L_31;
		// fillArray[i].g = pixelData[(i * 3) + 1];
		Color32U5BU5D_t38116C3E91765C4C5726CE12C77FAD7F9F737259* L_32 = ___fillArray0;
		int32_t L_33 = V_2;
		NullCheck(L_32);
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_34 = ___pixelData1;
		int32_t L_35 = V_2;
		NullCheck(L_34);
		int32_t L_36 = ((int32_t)il2cpp_codegen_add(((int32_t)il2cpp_codegen_multiply(L_35, 3)), 1));
		uint8_t L_37 = (L_34)->GetAt(static_cast<il2cpp_array_size_t>(L_36));
		((L_32)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_33)))->___g_2 = L_37;
		// fillArray[i].b = pixelData[(i * 3) + 0];
		Color32U5BU5D_t38116C3E91765C4C5726CE12C77FAD7F9F737259* L_38 = ___fillArray0;
		int32_t L_39 = V_2;
		NullCheck(L_38);
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_40 = ___pixelData1;
		int32_t L_41 = V_2;
		NullCheck(L_40);
		int32_t L_42 = ((int32_t)il2cpp_codegen_multiply(L_41, 3));
		uint8_t L_43 = (L_40)->GetAt(static_cast<il2cpp_array_size_t>(L_42));
		((L_38)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_39)))->___b_3 = L_43;
		// for (int i = 0; i < fillArray.Length; i++)
		int32_t L_44 = V_2;
		V_2 = ((int32_t)il2cpp_codegen_add(L_44, 1));
	}

IL_0077:
	{
		// for (int i = 0; i < fillArray.Length; i++)
		int32_t L_45 = V_2;
		Color32U5BU5D_t38116C3E91765C4C5726CE12C77FAD7F9F737259* L_46 = ___fillArray0;
		NullCheck(L_46);
		if ((((int32_t)L_45) < ((int32_t)((int32_t)(((RuntimeArray*)L_46)->max_length)))))
		{
			goto IL_003c;
		}
	}
	{
		return;
	}

IL_007e:
	{
		// if (bytesPerPixel == 4)
		int32_t L_47 = ___bytesPerPixel2;
		if ((!(((uint32_t)L_47) == ((uint32_t)4))))
		{
			goto IL_00db;
		}
	}
	{
		// for (int i = 0; i < fillArray.Length; i++)
		V_3 = 0;
		goto IL_00d4;
	}

IL_0086:
	{
		// fillArray[i].r = pixelData[i * 4];
		Color32U5BU5D_t38116C3E91765C4C5726CE12C77FAD7F9F737259* L_48 = ___fillArray0;
		int32_t L_49 = V_3;
		NullCheck(L_48);
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_50 = ___pixelData1;
		int32_t L_51 = V_3;
		NullCheck(L_50);
		int32_t L_52 = ((int32_t)il2cpp_codegen_multiply(L_51, 4));
		uint8_t L_53 = (L_50)->GetAt(static_cast<il2cpp_array_size_t>(L_52));
		((L_48)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_49)))->___r_1 = L_53;
		// fillArray[i].g = pixelData[(i * 4) + 1];
		Color32U5BU5D_t38116C3E91765C4C5726CE12C77FAD7F9F737259* L_54 = ___fillArray0;
		int32_t L_55 = V_3;
		NullCheck(L_54);
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_56 = ___pixelData1;
		int32_t L_57 = V_3;
		NullCheck(L_56);
		int32_t L_58 = ((int32_t)il2cpp_codegen_add(((int32_t)il2cpp_codegen_multiply(L_57, 4)), 1));
		uint8_t L_59 = (L_56)->GetAt(static_cast<il2cpp_array_size_t>(L_58));
		((L_54)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_55)))->___g_2 = L_59;
		// fillArray[i].b = pixelData[(i * 4) + 2];
		Color32U5BU5D_t38116C3E91765C4C5726CE12C77FAD7F9F737259* L_60 = ___fillArray0;
		int32_t L_61 = V_3;
		NullCheck(L_60);
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_62 = ___pixelData1;
		int32_t L_63 = V_3;
		NullCheck(L_62);
		int32_t L_64 = ((int32_t)il2cpp_codegen_add(((int32_t)il2cpp_codegen_multiply(L_63, 4)), 2));
		uint8_t L_65 = (L_62)->GetAt(static_cast<il2cpp_array_size_t>(L_64));
		((L_60)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_61)))->___b_3 = L_65;
		// fillArray[i].a = pixelData[(i * 4) + 3];
		Color32U5BU5D_t38116C3E91765C4C5726CE12C77FAD7F9F737259* L_66 = ___fillArray0;
		int32_t L_67 = V_3;
		NullCheck(L_66);
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_68 = ___pixelData1;
		int32_t L_69 = V_3;
		NullCheck(L_68);
		int32_t L_70 = ((int32_t)il2cpp_codegen_add(((int32_t)il2cpp_codegen_multiply(L_69, 4)), 3));
		uint8_t L_71 = (L_68)->GetAt(static_cast<il2cpp_array_size_t>(L_70));
		((L_66)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_67)))->___a_4 = L_71;
		// for (int i = 0; i < fillArray.Length; i++)
		int32_t L_72 = V_3;
		V_3 = ((int32_t)il2cpp_codegen_add(L_72, 1));
	}

IL_00d4:
	{
		// for (int i = 0; i < fillArray.Length; i++)
		int32_t L_73 = V_3;
		Color32U5BU5D_t38116C3E91765C4C5726CE12C77FAD7F9F737259* L_74 = ___fillArray0;
		NullCheck(L_74);
		if ((((int32_t)L_73) < ((int32_t)((int32_t)(((RuntimeArray*)L_74)->max_length)))))
		{
			goto IL_0086;
		}
	}
	{
		return;
	}

IL_00db:
	{
		// int bi = 0;
		V_4 = 0;
		// for (int i = 0; i < fillArray.Length; i++)
		V_5 = 0;
		goto IL_013d;
	}

IL_00e3:
	{
		// fillArray[i].r = pixelData[bi++];
		Color32U5BU5D_t38116C3E91765C4C5726CE12C77FAD7F9F737259* L_75 = ___fillArray0;
		int32_t L_76 = V_5;
		NullCheck(L_75);
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_77 = ___pixelData1;
		int32_t L_78 = V_4;
		int32_t L_79 = L_78;
		V_4 = ((int32_t)il2cpp_codegen_add(L_79, 1));
		NullCheck(L_77);
		int32_t L_80 = L_79;
		uint8_t L_81 = (L_77)->GetAt(static_cast<il2cpp_array_size_t>(L_80));
		((L_75)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_76)))->___r_1 = L_81;
		// fillArray[i].g = pixelData[bi++];
		Color32U5BU5D_t38116C3E91765C4C5726CE12C77FAD7F9F737259* L_82 = ___fillArray0;
		int32_t L_83 = V_5;
		NullCheck(L_82);
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_84 = ___pixelData1;
		int32_t L_85 = V_4;
		int32_t L_86 = L_85;
		V_4 = ((int32_t)il2cpp_codegen_add(L_86, 1));
		NullCheck(L_84);
		int32_t L_87 = L_86;
		uint8_t L_88 = (L_84)->GetAt(static_cast<il2cpp_array_size_t>(L_87));
		((L_82)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_83)))->___g_2 = L_88;
		// fillArray[i].b = pixelData[bi++];
		Color32U5BU5D_t38116C3E91765C4C5726CE12C77FAD7F9F737259* L_89 = ___fillArray0;
		int32_t L_90 = V_5;
		NullCheck(L_89);
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_91 = ___pixelData1;
		int32_t L_92 = V_4;
		int32_t L_93 = L_92;
		V_4 = ((int32_t)il2cpp_codegen_add(L_93, 1));
		NullCheck(L_91);
		int32_t L_94 = L_93;
		uint8_t L_95 = (L_91)->GetAt(static_cast<il2cpp_array_size_t>(L_94));
		((L_89)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_90)))->___b_3 = L_95;
		// fillArray[i].a = 255;
		Color32U5BU5D_t38116C3E91765C4C5726CE12C77FAD7F9F737259* L_96 = ___fillArray0;
		int32_t L_97 = V_5;
		NullCheck(L_96);
		((L_96)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_97)))->___a_4 = (uint8_t)((int32_t)255);
		// for (int i = 0; i < fillArray.Length; i++)
		int32_t L_98 = V_5;
		V_5 = ((int32_t)il2cpp_codegen_add(L_98, 1));
	}

IL_013d:
	{
		// for (int i = 0; i < fillArray.Length; i++)
		int32_t L_99 = V_5;
		Color32U5BU5D_t38116C3E91765C4C5726CE12C77FAD7F9F737259* L_100 = ___fillArray0;
		NullCheck(L_100);
		if ((((int32_t)L_99) < ((int32_t)((int32_t)(((RuntimeArray*)L_100)->max_length)))))
		{
			goto IL_00e3;
		}
	}
	{
		// }
		return;
	}
}
// System.Void Dummiesman.ImageLoaderHelper::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ImageLoaderHelper__ctor_mADF1F5D3782898A04779AD45B573AA7580A8A3AF (ImageLoaderHelper_t8603BF10D0193AFD974D45CB504409448995359B* __this, const RuntimeMethod* method) 
{
{
		Object__ctor_mE837C6B9FA8C6D5D109F4B2EC885D79919AC0EA2(__this, NULL);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// UnityEngine.Texture2D Dummiesman.ImageUtils::ConvertToNormalMap(UnityEngine.Texture2D)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* ImageUtils_ConvertToNormalMap_m955A60BC21001281CA0166F0FE251F18DA89EB66 (Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* ___tex0, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* V_0 = NULL;
	ColorU5BU5D_t612261CF293F6FFC3D80AB52259FF0DC2B2CC389* V_1 = NULL;
	int32_t V_2 = 0;
	Color_tD001788D726C3A7F1379BEED0260B9591F440C1F V_3;
	memset((&V_3), 0, sizeof(V_3));
	{
		// Texture2D returnTex = tex;
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_0 = ___tex0;
		V_0 = L_0;
		// if(tex.format != TextureFormat.RGBA32 && tex.format != TextureFormat.ARGB32)
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_1 = ___tex0;
		NullCheck(L_1);
		int32_t L_2;
		L_2 = Texture2D_get_format_mE39DD922F83CA1097383309278BB6F20636A7D9D(L_1, NULL);
		if ((((int32_t)L_2) == ((int32_t)4)))
		{
			goto IL_0028;
		}
	}
	{
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_3 = ___tex0;
		NullCheck(L_3);
		int32_t L_4;
		L_4 = Texture2D_get_format_mE39DD922F83CA1097383309278BB6F20636A7D9D(L_3, NULL);
		if ((((int32_t)L_4) == ((int32_t)5)))
		{
			goto IL_0028;
		}
	}
	{
		// returnTex = new Texture2D(tex.width, tex.height, TextureFormat.RGBA32, true);
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_5 = ___tex0;
		NullCheck(L_5);
		int32_t L_6;
		L_6 = VirtualFuncInvoker0< int32_t >::Invoke(5 /* System.Int32 UnityEngine.Texture::get_width() */, L_5);
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_7 = ___tex0;
		NullCheck(L_7);
		int32_t L_8;
		L_8 = VirtualFuncInvoker0< int32_t >::Invoke(7 /* System.Int32 UnityEngine.Texture::get_height() */, L_7);
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_9 = (Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4*)il2cpp_codegen_object_new(Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4_il2cpp_TypeInfo_var);
		Texture2D__ctor_mECF60A9EC0638EC353C02C8E99B6B465D23BE917(L_9, L_6, L_8, 4, (bool)1, /*hidden argument*/NULL);
		V_0 = L_9;
	}

IL_0028:
	{
		// Color[] pixels = tex.GetPixels();
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_10 = ___tex0;
		NullCheck(L_10);
		ColorU5BU5D_t612261CF293F6FFC3D80AB52259FF0DC2B2CC389* L_11;
		L_11 = Texture2D_GetPixels_m77A00D71DF5CDC7DAA0EE66FF2C90A24C7604039(L_10, NULL);
		V_1 = L_11;
		// for (int i = 0; i < pixels.Length; i++)
		V_2 = 0;
		goto IL_0085;
	}

IL_0033:
	{
		// Color temp = pixels[i];
		ColorU5BU5D_t612261CF293F6FFC3D80AB52259FF0DC2B2CC389* L_12 = V_1;
		int32_t L_13 = V_2;
		NullCheck(L_12);
		int32_t L_14 = L_13;
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_15 = (L_12)->GetAt(static_cast<il2cpp_array_size_t>(L_14));
		V_3 = L_15;
		// temp.a = pixels[i].r;
		ColorU5BU5D_t612261CF293F6FFC3D80AB52259FF0DC2B2CC389* L_16 = V_1;
		int32_t L_17 = V_2;
		NullCheck(L_16);
		float L_18 = ((L_16)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_17)))->___r_0;
		(&V_3)->___a_3 = L_18;
		// temp.r = 0f;
		(&V_3)->___r_0 = (0.0f);
		// temp.g = pixels[i].g;
		ColorU5BU5D_t612261CF293F6FFC3D80AB52259FF0DC2B2CC389* L_19 = V_1;
		int32_t L_20 = V_2;
		NullCheck(L_19);
		float L_21 = ((L_19)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_20)))->___g_1;
		(&V_3)->___g_1 = L_21;
		// temp.b = 0f;
		(&V_3)->___b_2 = (0.0f);
		// pixels[i] = temp;
		ColorU5BU5D_t612261CF293F6FFC3D80AB52259FF0DC2B2CC389* L_22 = V_1;
		int32_t L_23 = V_2;
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_24 = V_3;
		NullCheck(L_22);
		(L_22)->SetAt(static_cast<il2cpp_array_size_t>(L_23), (Color_tD001788D726C3A7F1379BEED0260B9591F440C1F)L_24);
		// for (int i = 0; i < pixels.Length; i++)
		int32_t L_25 = V_2;
		V_2 = ((int32_t)il2cpp_codegen_add(L_25, 1));
	}

IL_0085:
	{
		// for (int i = 0; i < pixels.Length; i++)
		int32_t L_26 = V_2;
		ColorU5BU5D_t612261CF293F6FFC3D80AB52259FF0DC2B2CC389* L_27 = V_1;
		NullCheck(L_27);
		if ((((int32_t)L_26) < ((int32_t)((int32_t)(((RuntimeArray*)L_27)->max_length)))))
		{
			goto IL_0033;
		}
	}
	{
		// returnTex.SetPixels(pixels);
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_28 = V_0;
		ColorU5BU5D_t612261CF293F6FFC3D80AB52259FF0DC2B2CC389* L_29 = V_1;
		NullCheck(L_28);
		Texture2D_SetPixels_mAE0CDFA15FA96F840D7FFADC31405D8AF20D9073(L_28, L_29, NULL);
		// returnTex.Apply(true);
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_30 = V_0;
		NullCheck(L_30);
		Texture2D_Apply_mCC369BCAB2D3AD3EE50EE01DA67AF227865FA2B3(L_30, (bool)1, NULL);
		// return returnTex;
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_31 = V_0;
		return L_31;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Int32 Dummiesman.TGALoader::GetBits(System.Byte,System.Int32,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t TGALoader_GetBits_mA82EA5A7F1404D4A3B7C0D6B22DC3798BBCA9064 (uint8_t ___b0, int32_t ___offset1, int32_t ___count2, const RuntimeMethod* method) 
{
{
		// return (b >> offset) & ((1 << count) - 1);
		uint8_t L_0 = ___b0;
		int32_t L_1 = ___offset1;
		int32_t L_2 = ___count2;
		return ((int32_t)(((int32_t)((int32_t)L_0>>((int32_t)(L_1&((int32_t)31)))))&((int32_t)il2cpp_codegen_subtract(((int32_t)(1<<((int32_t)(L_2&((int32_t)31))))), 1))));
	}
}
// UnityEngine.Color32[] Dummiesman.TGALoader::LoadRawTGAData(System.IO.BinaryReader,System.Int32,System.Int32,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Color32U5BU5D_t38116C3E91765C4C5726CE12C77FAD7F9F737259* TGALoader_LoadRawTGAData_m7A782568D655CD2E36DE9A618B583836EAADAA59 (BinaryReader_t9A6D85F0FE9AE4EBB5E8D66997DFD1D84939E158* ___r0, int32_t ___bitDepth1, int32_t ___width2, int32_t ___height3, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Color32U5BU5D_t38116C3E91765C4C5726CE12C77FAD7F9F737259_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* V_0 = NULL;
	{
		// Color32[] pulledColors = new Color32[width * height];
		int32_t L_0 = ___width2;
		int32_t L_1 = ___height3;
		Color32U5BU5D_t38116C3E91765C4C5726CE12C77FAD7F9F737259* L_2 = (Color32U5BU5D_t38116C3E91765C4C5726CE12C77FAD7F9F737259*)(Color32U5BU5D_t38116C3E91765C4C5726CE12C77FAD7F9F737259*)SZArrayNew(Color32U5BU5D_t38116C3E91765C4C5726CE12C77FAD7F9F737259_il2cpp_TypeInfo_var, (uint32_t)((int32_t)il2cpp_codegen_multiply(L_0, L_1)));
		// byte[] colorData = r.ReadBytes(width * height * (bitDepth / 8));
		BinaryReader_t9A6D85F0FE9AE4EBB5E8D66997DFD1D84939E158* L_3 = ___r0;
		int32_t L_4 = ___width2;
		int32_t L_5 = ___height3;
		int32_t L_6 = ___bitDepth1;
		NullCheck(L_3);
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_7;
		L_7 = VirtualFuncInvoker1< ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031*, int32_t >::Invoke(25 /* System.Byte[] System.IO.BinaryReader::ReadBytes(System.Int32) */, L_3, ((int32_t)il2cpp_codegen_multiply(((int32_t)il2cpp_codegen_multiply(L_4, L_5)), ((int32_t)(L_6/8)))));
		V_0 = L_7;
		// ImageLoaderHelper.FillPixelArray(pulledColors, colorData, (bitDepth / 8), true);
		Color32U5BU5D_t38116C3E91765C4C5726CE12C77FAD7F9F737259* L_8 = L_2;
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_9 = V_0;
		int32_t L_10 = ___bitDepth1;
		ImageLoaderHelper_FillPixelArray_m6BFB48A1F8EE716042BA26E2E8E49BCFB153B097(L_8, L_9, ((int32_t)(L_10/8)), (bool)1, NULL);
		// return pulledColors;
		return L_8;
	}
}
// UnityEngine.Color32[] Dummiesman.TGALoader::LoadRLETGAData(System.IO.BinaryReader,System.Int32,System.Int32,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Color32U5BU5D_t38116C3E91765C4C5726CE12C77FAD7F9F737259* TGALoader_LoadRLETGAData_m1E46DBADA3C2691A5543F569E66A6F52EEE2D605 (BinaryReader_t9A6D85F0FE9AE4EBB5E8D66997DFD1D84939E158* ___r0, int32_t ___bitDepth1, int32_t ___width2, int32_t ___height3, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Color32U5BU5D_t38116C3E91765C4C5726CE12C77FAD7F9F737259_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
Color32U5BU5D_t38116C3E91765C4C5726CE12C77FAD7F9F737259* V_0 = NULL;
	int32_t V_1 = 0;
	int32_t V_2 = 0;
	int32_t V_3 = 0;
	int32_t V_4 = 0;
	Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B V_5;
	memset((&V_5), 0, sizeof(V_5));
	Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B V_6;
	memset((&V_6), 0, sizeof(V_6));
	int32_t V_7 = 0;
	Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B G_B6_0;
	memset((&G_B6_0), 0, sizeof(G_B6_0));
	Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B G_B12_0;
	memset((&G_B12_0), 0, sizeof(G_B12_0));
	{
		// Color32[] pulledColors = new Color32[width * height];
		int32_t L_0 = ___width2;
		int32_t L_1 = ___height3;
		Color32U5BU5D_t38116C3E91765C4C5726CE12C77FAD7F9F737259* L_2 = (Color32U5BU5D_t38116C3E91765C4C5726CE12C77FAD7F9F737259*)(Color32U5BU5D_t38116C3E91765C4C5726CE12C77FAD7F9F737259*)SZArrayNew(Color32U5BU5D_t38116C3E91765C4C5726CE12C77FAD7F9F737259_il2cpp_TypeInfo_var, (uint32_t)((int32_t)il2cpp_codegen_multiply(L_0, L_1)));
		V_0 = L_2;
		// int pulledColorCount = 0;
		V_1 = 0;
		goto IL_00a8;
	}

IL_0010:
	{
		// byte rlePacket = r.ReadByte();
		BinaryReader_t9A6D85F0FE9AE4EBB5E8D66997DFD1D84939E158* L_3 = ___r0;
		NullCheck(L_3);
		uint8_t L_4;
		L_4 = VirtualFuncInvoker0< uint8_t >::Invoke(10 /* System.Byte System.IO.BinaryReader::ReadByte() */, L_3);
		// int RLEPacketType = GetBits(rlePacket, 7, 1);
		uint8_t L_5 = L_4;
		int32_t L_6;
		L_6 = TGALoader_GetBits_mA82EA5A7F1404D4A3B7C0D6B22DC3798BBCA9064(L_5, 7, 1, NULL);
		V_2 = L_6;
		// int RLEPixelCount = GetBits(rlePacket, 0, 7) + 1;
		int32_t L_7;
		L_7 = TGALoader_GetBits_mA82EA5A7F1404D4A3B7C0D6B22DC3798BBCA9064(L_5, 0, 7, NULL);
		V_3 = ((int32_t)il2cpp_codegen_add(L_7, 1));
		// if (RLEPacketType == 0)
		int32_t L_8 = V_2;
		if (L_8)
		{
			goto IL_0069;
		}
	}
	{
		// for (int i = 0; i < RLEPixelCount; i++)
		V_4 = 0;
		goto IL_0062;
	}

IL_0031:
	{
		// var color = (bitDepth == 32) ? r.ReadColor32RGBA().FlipRB() : r.ReadColor32RGB().FlipRB();
		int32_t L_9 = ___bitDepth1;
		if ((((int32_t)L_9) == ((int32_t)((int32_t)32))))
		{
			goto IL_0043;
		}
	}
	{
		BinaryReader_t9A6D85F0FE9AE4EBB5E8D66997DFD1D84939E158* L_10 = ___r0;
		Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B L_11;
		L_11 = BinaryExtensions_ReadColor32RGB_m25BA23FD7D871C11D22BF555A7044B96EE501DF9(L_10, NULL);
		Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B L_12;
		L_12 = ColorExtensions_FlipRB_m6593081B4B3A605C5090092E736E12BF9E02B113(L_11, NULL);
		G_B6_0 = L_12;
		goto IL_004e;
	}

IL_0043:
	{
		BinaryReader_t9A6D85F0FE9AE4EBB5E8D66997DFD1D84939E158* L_13 = ___r0;
		Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B L_14;
		L_14 = BinaryExtensions_ReadColor32RGBA_mBD1FED9FE25413CA2E48363DC7B9FB3CF0E799D3(L_13, NULL);
		Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B L_15;
		L_15 = ColorExtensions_FlipRB_m6593081B4B3A605C5090092E736E12BF9E02B113(L_14, NULL);
		G_B6_0 = L_15;
	}

IL_004e:
	{
		V_5 = G_B6_0;
		// pulledColors[i + pulledColorCount] = color;
		Color32U5BU5D_t38116C3E91765C4C5726CE12C77FAD7F9F737259* L_16 = V_0;
		int32_t L_17 = V_4;
		int32_t L_18 = V_1;
		Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B L_19 = V_5;
		NullCheck(L_16);
		(L_16)->SetAt(static_cast<il2cpp_array_size_t>(((int32_t)il2cpp_codegen_add(L_17, L_18))), (Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B)L_19);
		// for (int i = 0; i < RLEPixelCount; i++)
		int32_t L_20 = V_4;
		V_4 = ((int32_t)il2cpp_codegen_add(L_20, 1));
	}

IL_0062:
	{
		// for (int i = 0; i < RLEPixelCount; i++)
		int32_t L_21 = V_4;
		int32_t L_22 = V_3;
		if ((((int32_t)L_21) < ((int32_t)L_22)))
		{
			goto IL_0031;
		}
	}
	{
		goto IL_00a4;
	}

IL_0069:
	{
		// var color = (bitDepth == 32) ? r.ReadColor32RGBA().FlipRB() : r.ReadColor32RGB().FlipRB();
		int32_t L_23 = ___bitDepth1;
		if ((((int32_t)L_23) == ((int32_t)((int32_t)32))))
		{
			goto IL_007b;
		}
	}
	{
		BinaryReader_t9A6D85F0FE9AE4EBB5E8D66997DFD1D84939E158* L_24 = ___r0;
		Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B L_25;
		L_25 = BinaryExtensions_ReadColor32RGB_m25BA23FD7D871C11D22BF555A7044B96EE501DF9(L_24, NULL);
		Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B L_26;
		L_26 = ColorExtensions_FlipRB_m6593081B4B3A605C5090092E736E12BF9E02B113(L_25, NULL);
		G_B12_0 = L_26;
		goto IL_0086;
	}

IL_007b:
	{
		BinaryReader_t9A6D85F0FE9AE4EBB5E8D66997DFD1D84939E158* L_27 = ___r0;
		Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B L_28;
		L_28 = BinaryExtensions_ReadColor32RGBA_mBD1FED9FE25413CA2E48363DC7B9FB3CF0E799D3(L_27, NULL);
		Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B L_29;
		L_29 = ColorExtensions_FlipRB_m6593081B4B3A605C5090092E736E12BF9E02B113(L_28, NULL);
		G_B12_0 = L_29;
	}

IL_0086:
	{
		V_6 = G_B12_0;
		// for (int i = 0; i < RLEPixelCount; i++)
		V_7 = 0;
		goto IL_009f;
	}

IL_008d:
	{
		// pulledColors[i + pulledColorCount] = color;
		Color32U5BU5D_t38116C3E91765C4C5726CE12C77FAD7F9F737259* L_30 = V_0;
		int32_t L_31 = V_7;
		int32_t L_32 = V_1;
		Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B L_33 = V_6;
		NullCheck(L_30);
		(L_30)->SetAt(static_cast<il2cpp_array_size_t>(((int32_t)il2cpp_codegen_add(L_31, L_32))), (Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B)L_33);
		// for (int i = 0; i < RLEPixelCount; i++)
		int32_t L_34 = V_7;
		V_7 = ((int32_t)il2cpp_codegen_add(L_34, 1));
	}

IL_009f:
	{
		// for (int i = 0; i < RLEPixelCount; i++)
		int32_t L_35 = V_7;
		int32_t L_36 = V_3;
		if ((((int32_t)L_35) < ((int32_t)L_36)))
		{
			goto IL_008d;
		}
	}

IL_00a4:
	{
		// pulledColorCount += RLEPixelCount;
		int32_t L_37 = V_1;
		int32_t L_38 = V_3;
		V_1 = ((int32_t)il2cpp_codegen_add(L_37, L_38));
	}

IL_00a8:
	{
		// while (pulledColorCount < pulledColors.Length)
		int32_t L_39 = V_1;
		Color32U5BU5D_t38116C3E91765C4C5726CE12C77FAD7F9F737259* L_40 = V_0;
		NullCheck(L_40);
		if ((((int32_t)L_39) < ((int32_t)((int32_t)(((RuntimeArray*)L_40)->max_length)))))
		{
			goto IL_0010;
		}
	}
	{
		// return pulledColors;
		Color32U5BU5D_t38116C3E91765C4C5726CE12C77FAD7F9F737259* L_41 = V_0;
		return L_41;
	}
}
// UnityEngine.Texture2D Dummiesman.TGALoader::Load(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* TGALoader_Load_m3CCA6123D7B87D9C946AA2360D09BF56194703CB (String_t* ___fileName0, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IDisposable_t030E0496B4E0E4E4F086825007979AF51F7248C5_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
FileStream_t07C7222EE10B75F352B89B76E60820160FF10AD8* V_0 = NULL;
	Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* V_1 = NULL;
	{
		// using (var imageFile = File.OpenRead(fileName))
		String_t* L_0 = ___fileName0;
		FileStream_t07C7222EE10B75F352B89B76E60820160FF10AD8* L_1;
		L_1 = File_OpenRead_m32C8C37542B7A02A2F643E3B816D16ABE690FF50(L_0, NULL);
		V_0 = L_1;
	}

IL_0007:
	{
		auto __finallyBlock = il2cpp::utils::Finally([&]
		{

FINALLY_0010:
			{// begin finally (depth: 1)
				{
					FileStream_t07C7222EE10B75F352B89B76E60820160FF10AD8* L_2 = V_0;
					if (!L_2)
					{
						goto IL_0019;
					}
				}

IL_0013:
				{
					FileStream_t07C7222EE10B75F352B89B76E60820160FF10AD8* L_3 = V_0;
					NullCheck(L_3);
					InterfaceActionInvoker0::Invoke(0 /* System.Void System.IDisposable::Dispose() */, IDisposable_t030E0496B4E0E4E4F086825007979AF51F7248C5_il2cpp_TypeInfo_var, L_3);
				}

IL_0019:
				{
					return;
				}
			}// end finally (depth: 1)
		});
		try
		{// begin try (depth: 1)
			// return Load(imageFile);
			FileStream_t07C7222EE10B75F352B89B76E60820160FF10AD8* L_4 = V_0;
			Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_5;
			L_5 = TGALoader_Load_mB5CF838E183A7538AF925552AC81CA3B6C9AFC0D(L_4, NULL);
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
		// }
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_6 = V_1;
		return L_6;
	}
}
// UnityEngine.Texture2D Dummiesman.TGALoader::Load(System.Byte[])
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* TGALoader_Load_m90B1879FA09E6480B21C87F484AF0C3CC611DCAB (ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* ___bytes0, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IDisposable_t030E0496B4E0E4E4F086825007979AF51F7248C5_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&MemoryStream_tAAED1B42172E3390584E4194308AB878E786AAC2_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
MemoryStream_tAAED1B42172E3390584E4194308AB878E786AAC2* V_0 = NULL;
	Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* V_1 = NULL;
	{
		// using (var ms = new MemoryStream(bytes))
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_0 = ___bytes0;
		MemoryStream_tAAED1B42172E3390584E4194308AB878E786AAC2* L_1 = (MemoryStream_tAAED1B42172E3390584E4194308AB878E786AAC2*)il2cpp_codegen_object_new(MemoryStream_tAAED1B42172E3390584E4194308AB878E786AAC2_il2cpp_TypeInfo_var);
		MemoryStream__ctor_m662CA0D5A0004A2E3B475FE8DCD687B654870AA2(L_1, L_0, /*hidden argument*/NULL);
		V_0 = L_1;
	}

IL_0007:
	{
		auto __finallyBlock = il2cpp::utils::Finally([&]
		{

FINALLY_0010:
			{// begin finally (depth: 1)
				{
					MemoryStream_tAAED1B42172E3390584E4194308AB878E786AAC2* L_2 = V_0;
					if (!L_2)
					{
						goto IL_0019;
					}
				}

IL_0013:
				{
					MemoryStream_tAAED1B42172E3390584E4194308AB878E786AAC2* L_3 = V_0;
					NullCheck(L_3);
					InterfaceActionInvoker0::Invoke(0 /* System.Void System.IDisposable::Dispose() */, IDisposable_t030E0496B4E0E4E4F086825007979AF51F7248C5_il2cpp_TypeInfo_var, L_3);
				}

IL_0019:
				{
					return;
				}
			}// end finally (depth: 1)
		});
		try
		{// begin try (depth: 1)
			// return Load(ms);
			MemoryStream_tAAED1B42172E3390584E4194308AB878E786AAC2* L_4 = V_0;
			Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_5;
			L_5 = TGALoader_Load_mB5CF838E183A7538AF925552AC81CA3B6C9AFC0D(L_4, NULL);
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
		// }
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_6 = V_1;
		return L_6;
	}
}
// UnityEngine.Texture2D Dummiesman.TGALoader::Load(System.IO.Stream)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* TGALoader_Load_mB5CF838E183A7538AF925552AC81CA3B6C9AFC0D (Stream_tF844051B786E8F7F4244DBD218D74E8617B9A2DE* ___TGAStream0, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&BinaryReader_t9A6D85F0FE9AE4EBB5E8D66997DFD1D84939E158_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Byte_t94D9231AC217BE4D2E004C4CD32DF6D099EA41A3_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Debug_t8394C7EEAECA3689C2C9B9DE9C7166D73596276F_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IDisposable_t030E0496B4E0E4E4F086825007979AF51F7248C5_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral267226911D4A958D79875B1057280198F25BE5F6);
		s_Il2CppMethodInitialized = true;
	}
BinaryReader_t9A6D85F0FE9AE4EBB5E8D66997DFD1D84939E158* V_0 = NULL;
	uint8_t V_1 = 0x0;
	int16_t V_2 = 0;
	int16_t V_3 = 0;
	int32_t V_4 = 0;
	Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* V_5 = NULL;
	Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* V_6 = NULL;
	int16_t G_B8_0 = 0;
	int16_t G_B8_1 = 0;
	int16_t G_B7_0 = 0;
	int16_t G_B7_1 = 0;
	int32_t G_B9_0 = 0;
	int16_t G_B9_1 = 0;
	int16_t G_B9_2 = 0;
	{
		// using (BinaryReader r = new BinaryReader(TGAStream))
		Stream_tF844051B786E8F7F4244DBD218D74E8617B9A2DE* L_0 = ___TGAStream0;
		BinaryReader_t9A6D85F0FE9AE4EBB5E8D66997DFD1D84939E158* L_1 = (BinaryReader_t9A6D85F0FE9AE4EBB5E8D66997DFD1D84939E158*)il2cpp_codegen_object_new(BinaryReader_t9A6D85F0FE9AE4EBB5E8D66997DFD1D84939E158_il2cpp_TypeInfo_var);
		BinaryReader__ctor_m898732FE0DBEDD480B24F6DE45A9AC696E44CC0F(L_1, L_0, /*hidden argument*/NULL);
		V_0 = L_1;
	}

IL_0007:
	{
		auto __finallyBlock = il2cpp::utils::Finally([&]
		{

FINALLY_00d2:
			{// begin finally (depth: 1)
				{
					BinaryReader_t9A6D85F0FE9AE4EBB5E8D66997DFD1D84939E158* L_2 = V_0;
					if (!L_2)
					{
						goto IL_00db;
					}
				}

IL_00d5:
				{
					BinaryReader_t9A6D85F0FE9AE4EBB5E8D66997DFD1D84939E158* L_3 = V_0;
					NullCheck(L_3);
					InterfaceActionInvoker0::Invoke(0 /* System.Void System.IDisposable::Dispose() */, IDisposable_t030E0496B4E0E4E4F086825007979AF51F7248C5_il2cpp_TypeInfo_var, L_3);
				}

IL_00db:
				{
					return;
				}
			}// end finally (depth: 1)
		});
		try
		{// begin try (depth: 1)
			{
				// r.BaseStream.Seek(2, SeekOrigin.Begin);
				BinaryReader_t9A6D85F0FE9AE4EBB5E8D66997DFD1D84939E158* L_4 = V_0;
				NullCheck(L_4);
				Stream_tF844051B786E8F7F4244DBD218D74E8617B9A2DE* L_5;
				L_5 = VirtualFuncInvoker0< Stream_tF844051B786E8F7F4244DBD218D74E8617B9A2DE* >::Invoke(5 /* System.IO.Stream System.IO.BinaryReader::get_BaseStream() */, L_4);
				NullCheck(L_5);
				int64_t L_6;
				L_6 = VirtualFuncInvoker2< int64_t, int64_t, int32_t >::Invoke(30 /* System.Int64 System.IO.Stream::Seek(System.Int64,System.IO.SeekOrigin) */, L_5, ((int64_t)2), 0);
				// byte imageType = r.ReadByte();
				BinaryReader_t9A6D85F0FE9AE4EBB5E8D66997DFD1D84939E158* L_7 = V_0;
				NullCheck(L_7);
				uint8_t L_8;
				L_8 = VirtualFuncInvoker0< uint8_t >::Invoke(10 /* System.Byte System.IO.BinaryReader::ReadByte() */, L_7);
				V_1 = L_8;
				// if (imageType != 10 && imageType != 2)
				uint8_t L_9 = V_1;
				if ((((int32_t)L_9) == ((int32_t)((int32_t)10))))
				{
					goto IL_0043;
				}
			}

IL_0022:
			{
				uint8_t L_10 = V_1;
				if ((((int32_t)L_10) == ((int32_t)2)))
				{
					goto IL_0043;
				}
			}

IL_0026:
			{
				// Debug.LogError($"Unsupported targa image type. ({imageType})");
				uint8_t L_11 = V_1;
				uint8_t L_12 = L_11;
				RuntimeObject* L_13 = Box(Byte_t94D9231AC217BE4D2E004C4CD32DF6D099EA41A3_il2cpp_TypeInfo_var, &L_12);
				String_t* L_14;
				L_14 = String_Format_m8C122B26BC5AA10E2550AECA16E57DAE10F07E30(_stringLiteral267226911D4A958D79875B1057280198F25BE5F6, L_13, NULL);
				il2cpp_codegen_runtime_class_init_inline(Debug_t8394C7EEAECA3689C2C9B9DE9C7166D73596276F_il2cpp_TypeInfo_var);
				Debug_LogError_m059825802BB6AF7EA9693FEBEEB0D85F59A3E38E(L_14, NULL);
				// return null;
				V_6 = (Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4*)NULL;
				goto IL_00dc;
			}

IL_0043:
			{
				// r.BaseStream.Seek(12, SeekOrigin.Begin);
				BinaryReader_t9A6D85F0FE9AE4EBB5E8D66997DFD1D84939E158* L_15 = V_0;
				NullCheck(L_15);
				Stream_tF844051B786E8F7F4244DBD218D74E8617B9A2DE* L_16;
				L_16 = VirtualFuncInvoker0< Stream_tF844051B786E8F7F4244DBD218D74E8617B9A2DE* >::Invoke(5 /* System.IO.Stream System.IO.BinaryReader::get_BaseStream() */, L_15);
				NullCheck(L_16);
				int64_t L_17;
				L_17 = VirtualFuncInvoker2< int64_t, int64_t, int32_t >::Invoke(30 /* System.Int64 System.IO.Stream::Seek(System.Int64,System.IO.SeekOrigin) */, L_16, ((int64_t)((int32_t)12)), 0);
				// short width = r.ReadInt16();
				BinaryReader_t9A6D85F0FE9AE4EBB5E8D66997DFD1D84939E158* L_18 = V_0;
				NullCheck(L_18);
				int16_t L_19;
				L_19 = VirtualFuncInvoker0< int16_t >::Invoke(13 /* System.Int16 System.IO.BinaryReader::ReadInt16() */, L_18);
				V_2 = L_19;
				// short height = r.ReadInt16();
				BinaryReader_t9A6D85F0FE9AE4EBB5E8D66997DFD1D84939E158* L_20 = V_0;
				NullCheck(L_20);
				int16_t L_21;
				L_21 = VirtualFuncInvoker0< int16_t >::Invoke(13 /* System.Int16 System.IO.BinaryReader::ReadInt16() */, L_20);
				V_3 = L_21;
				// int bitDepth = r.ReadByte();
				BinaryReader_t9A6D85F0FE9AE4EBB5E8D66997DFD1D84939E158* L_22 = V_0;
				NullCheck(L_22);
				uint8_t L_23;
				L_23 = VirtualFuncInvoker0< uint8_t >::Invoke(10 /* System.Byte System.IO.BinaryReader::ReadByte() */, L_22);
				V_4 = L_23;
				// if (bitDepth < 24)
				int32_t L_24 = V_4;
				if ((((int32_t)L_24) >= ((int32_t)((int32_t)24))))
				{
					goto IL_007a;
				}
			}

IL_006f:
			{
				// throw new Exception("Tried to load TGA with unsupported bit depth");
				Exception_t* L_25 = (Exception_t*)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&Exception_t_il2cpp_TypeInfo_var)));
				Exception__ctor_m9B2BD92CD68916245A75109105D9071C9D430E7F(L_25, ((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteral3201B86FACEA09A6EC2396E7556112CD64565211)), /*hidden argument*/NULL);
				IL2CPP_RAISE_MANAGED_EXCEPTION(L_25, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&TGALoader_Load_mB5CF838E183A7538AF925552AC81CA3B6C9AFC0D_RuntimeMethod_var)));
			}

IL_007a:
			{
				// r.BaseStream.Seek(1, SeekOrigin.Current);
				BinaryReader_t9A6D85F0FE9AE4EBB5E8D66997DFD1D84939E158* L_26 = V_0;
				NullCheck(L_26);
				Stream_tF844051B786E8F7F4244DBD218D74E8617B9A2DE* L_27;
				L_27 = VirtualFuncInvoker0< Stream_tF844051B786E8F7F4244DBD218D74E8617B9A2DE* >::Invoke(5 /* System.IO.Stream System.IO.BinaryReader::get_BaseStream() */, L_26);
				NullCheck(L_27);
				int64_t L_28;
				L_28 = VirtualFuncInvoker2< int64_t, int64_t, int32_t >::Invoke(30 /* System.Int64 System.IO.Stream::Seek(System.Int64,System.IO.SeekOrigin) */, L_27, ((int64_t)1), 1);
				// Texture2D tex = new Texture2D(width, height, (bitDepth == 24) ? TextureFormat.RGB24 :  TextureFormat.ARGB32, true);
				int16_t L_29 = V_2;
				int16_t L_30 = V_3;
				int32_t L_31 = V_4;
				G_B7_0 = L_30;
				G_B7_1 = L_29;
				if ((((int32_t)L_31) == ((int32_t)((int32_t)24))))
				{
					G_B8_0 = L_30;
					G_B8_1 = L_29;
					goto IL_0094;
				}
			}

IL_0091:
			{
				G_B9_0 = 5;
				G_B9_1 = G_B7_0;
				G_B9_2 = G_B7_1;
				goto IL_0095;
			}

IL_0094:
			{
				G_B9_0 = 3;
				G_B9_1 = G_B8_0;
				G_B9_2 = G_B8_1;
			}

IL_0095:
			{
				Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_32 = (Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4*)il2cpp_codegen_object_new(Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4_il2cpp_TypeInfo_var);
				Texture2D__ctor_mECF60A9EC0638EC353C02C8E99B6B465D23BE917(L_32, G_B9_2, G_B9_1, G_B9_0, (bool)1, /*hidden argument*/NULL);
				V_5 = L_32;
				// if (imageType == 2)
				uint8_t L_33 = V_1;
				if ((!(((uint32_t)L_33) == ((uint32_t)2))))
				{
					goto IL_00b4;
				}
			}

IL_00a1:
			{
				// tex.SetPixels32(LoadRawTGAData(r, bitDepth, width, height));
				Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_34 = V_5;
				BinaryReader_t9A6D85F0FE9AE4EBB5E8D66997DFD1D84939E158* L_35 = V_0;
				int32_t L_36 = V_4;
				int16_t L_37 = V_2;
				int16_t L_38 = V_3;
				Color32U5BU5D_t38116C3E91765C4C5726CE12C77FAD7F9F737259* L_39;
				L_39 = TGALoader_LoadRawTGAData_m7A782568D655CD2E36DE9A618B583836EAADAA59(L_35, L_36, L_37, L_38, NULL);
				NullCheck(L_34);
				Texture2D_SetPixels32_m169F9873A21FB8DECA24DC1B8F06FB23D13BEE2A(L_34, L_39, NULL);
				goto IL_00c5;
			}

IL_00b4:
			{
				// tex.SetPixels32(LoadRLETGAData(r, bitDepth, width, height));
				Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_40 = V_5;
				BinaryReader_t9A6D85F0FE9AE4EBB5E8D66997DFD1D84939E158* L_41 = V_0;
				int32_t L_42 = V_4;
				int16_t L_43 = V_2;
				int16_t L_44 = V_3;
				Color32U5BU5D_t38116C3E91765C4C5726CE12C77FAD7F9F737259* L_45;
				L_45 = TGALoader_LoadRLETGAData_m1E46DBADA3C2691A5543F569E66A6F52EEE2D605(L_41, L_42, L_43, L_44, NULL);
				NullCheck(L_40);
				Texture2D_SetPixels32_m169F9873A21FB8DECA24DC1B8F06FB23D13BEE2A(L_40, L_45, NULL);
			}

IL_00c5:
			{
				// tex.Apply();
				Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_46 = V_5;
				NullCheck(L_46);
				Texture2D_Apply_mA014182C9EE0BBF6EEE3B286854F29E50EB972DC(L_46, NULL);
				// return tex;
				Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_47 = V_5;
				V_6 = L_47;
				goto IL_00dc;
			}
		}// end try (depth: 1)
		catch(Il2CppExceptionWrapper& e)
		{
			__finallyBlock.StoreException(e.ex);
		}
	}

IL_00dc:
	{
		// }
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_48 = V_6;
		return L_48;
	}
}
// System.Void Dummiesman.TGALoader::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TGALoader__ctor_m3BD8839506BD5B26AA424AC8265DD4E71F24FA57 (TGALoader_tBF4AA5DFA40A991239260EF4CD506E8F5F59B1E2* __this, const RuntimeMethod* method) 
{
{
		Object__ctor_mE837C6B9FA8C6D5D109F4B2EC885D79919AC0EA2(__this, NULL);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// UnityEngine.Color Dummiesman.Extensions.ColorExtensions::FlipRB(UnityEngine.Color)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Color_tD001788D726C3A7F1379BEED0260B9591F440C1F ColorExtensions_FlipRB_mDA57A18B7D63876CB607FF263D75575606DDAE5A (Color_tD001788D726C3A7F1379BEED0260B9591F440C1F ___color0, const RuntimeMethod* method) 
{
{
		// return new Color(color.b, color.g, color.r, color.a);
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_0 = ___color0;
		float L_1 = L_0.___b_2;
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_2 = ___color0;
		float L_3 = L_2.___g_1;
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_4 = ___color0;
		float L_5 = L_4.___r_0;
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_6 = ___color0;
		float L_7 = L_6.___a_3;
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_8;
		memset((&L_8), 0, sizeof(L_8));
		Color__ctor_m3786F0D6E510D9CFA544523A955870BD2A514C8C_inline((&L_8), L_1, L_3, L_5, L_7, /*hidden argument*/NULL);
		return L_8;
	}
}
// UnityEngine.Color32 Dummiesman.Extensions.ColorExtensions::FlipRB(UnityEngine.Color32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B ColorExtensions_FlipRB_m6593081B4B3A605C5090092E736E12BF9E02B113 (Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B ___color0, const RuntimeMethod* method) 
{
{
		// return new Color32(color.b, color.g, color.r, color.a);
		Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B L_0 = ___color0;
		uint8_t L_1 = L_0.___b_3;
		Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B L_2 = ___color0;
		uint8_t L_3 = L_2.___g_2;
		Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B L_4 = ___color0;
		uint8_t L_5 = L_4.___r_1;
		Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B L_6 = ___color0;
		uint8_t L_7 = L_6.___a_4;
		Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B L_8;
		memset((&L_8), 0, sizeof(L_8));
		Color32__ctor_mC9C6B443F0C7CA3F8B174158B2AF6F05E18EAC4E_inline((&L_8), L_1, L_3, L_5, L_7, /*hidden argument*/NULL);
		return L_8;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.UInt32 <PrivateImplementationDetails>::ComputeStringHash(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR uint32_t U3CPrivateImplementationDetailsU3E_ComputeStringHash_m9E43873DE0DF480D27EC1C2AA3C09E74EA77F75D (String_t* ___s0, const RuntimeMethod* method) 
{
uint32_t V_0 = 0;
	int32_t V_1 = 0;
	{
		String_t* L_0 = ___s0;
		if (!L_0)
		{
			goto IL_002a;
		}
	}
	{
		V_0 = ((int32_t)-2128831035);
		V_1 = 0;
		goto IL_0021;
	}

IL_000d:
	{
		String_t* L_1 = ___s0;
		int32_t L_2 = V_1;
		NullCheck(L_1);
		Il2CppChar L_3;
		L_3 = String_get_Chars_mC49DF0CD2D3BE7BE97B3AD9C995BE3094F8E36D3(L_1, L_2, NULL);
		uint32_t L_4 = V_0;
		V_0 = ((int32_t)il2cpp_codegen_multiply(((int32_t)((int32_t)L_3^(int32_t)L_4)), ((int32_t)16777619)));
		int32_t L_5 = V_1;
		V_1 = ((int32_t)il2cpp_codegen_add(L_5, 1));
	}

IL_0021:
	{
		int32_t L_6 = V_1;
		String_t* L_7 = ___s0;
		NullCheck(L_7);
		int32_t L_8;
		L_8 = String_get_Length_m42625D67623FA5CC7A44D47425CE86FB946542D2_inline(L_7, NULL);
		if ((((int32_t)L_6) < ((int32_t)L_8)))
		{
			goto IL_000d;
		}
	}

IL_002a:
	{
		uint32_t L_9 = V_0;
		return L_9;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 Vector2_op_Implicit_m8F73B300CB4E6F9B4EB5FB6130363D76CEAA230B_inline (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___v0, const RuntimeMethod* method) 
{
Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_0 = ___v0;
		float L_1 = L_0.___x_2;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_2 = ___v0;
		float L_3 = L_2.___y_3;
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_4;
		memset((&L_4), 0, sizeof(L_4));
		Vector2__ctor_m9525B79969AFFE3254B303A40997A56DEEB6F548_inline((&L_4), L_1, L_3, /*hidden argument*/NULL);
		V_0 = L_4;
		goto IL_0015;
	}

IL_0015:
	{
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_5 = V_0;
		return L_5;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void Vector3__ctor_m376936E6B999EF1ECBE57D990A386303E2283DE0_inline (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2* __this, float ___x0, float ___y1, float ___z2, const RuntimeMethod* method) 
{
{
		float L_0 = ___x0;
		__this->___x_2 = L_0;
		float L_1 = ___y1;
		__this->___y_3 = L_1;
		float L_2 = ___z2;
		__this->___z_4 = L_2;
		return;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR int32_t OBJObjectBuilder_get_PushedFaceCount_m0800BDEDCCE5D0006D125DE33878F032D415366E_inline (OBJObjectBuilder_t0FF6F614A40C0709678B6A0F9111F43397565F13* __this, const RuntimeMethod* method) 
{
{
		// public int PushedFaceCount { get; private set; } = 0;
		int32_t L_0 = __this->___U3CPushedFaceCountU3Ek__BackingField_0;
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR int32_t String_get_Length_m42625D67623FA5CC7A44D47425CE86FB946542D2_inline (String_t* __this, const RuntimeMethod* method) 
{
{
		int32_t L_0 = __this->____stringLength_4;
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void Vector2__ctor_m9525B79969AFFE3254B303A40997A56DEEB6F548_inline (Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7* __this, float ___x0, float ___y1, const RuntimeMethod* method) 
{
{
		float L_0 = ___x0;
		__this->___x_0 = L_0;
		float L_1 = ___y1;
		__this->___y_1 = L_1;
		return;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 Vector2_op_Implicit_mCD214B04BC52AED3C89C3BEF664B6247E5F8954A_inline (Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 ___v0, const RuntimeMethod* method) 
{
Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_0 = ___v0;
		float L_1 = L_0.___x_0;
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_2 = ___v0;
		float L_3 = L_2.___y_1;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_4;
		memset((&L_4), 0, sizeof(L_4));
		Vector3__ctor_m376936E6B999EF1ECBE57D990A386303E2283DE0_inline((&L_4), L_1, L_3, (0.0f), /*hidden argument*/NULL);
		V_0 = L_4;
		goto IL_001a;
	}

IL_001a:
	{
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_5 = V_0;
		return L_5;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void Color__ctor_mCD6889CDE39F18704CD6EA8E2EFBFA48BA3E13B0_inline (Color_tD001788D726C3A7F1379BEED0260B9591F440C1F* __this, float ___r0, float ___g1, float ___b2, const RuntimeMethod* method) 
{
{
		float L_0 = ___r0;
		__this->___r_0 = L_0;
		float L_1 = ___g1;
		__this->___g_1 = L_1;
		float L_2 = ___b2;
		__this->___b_2 = L_2;
		__this->___a_3 = (1.0f);
		return;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 Vector3_get_zero_m9D7F7B580B5A276411267E96AA3425736D9BDC83_inline (const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_0 = ((Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2_StaticFields*)il2cpp_codegen_static_fields_for(Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2_il2cpp_TypeInfo_var))->___zeroVector_5;
		V_0 = L_0;
		goto IL_0009;
	}

IL_0009:
	{
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_1 = V_0;
		return L_1;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 Vector2_get_zero_m009B92B5D35AB02BD1610C2E1ACCE7C9CF964A6E_inline (const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_0 = ((Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7_StaticFields*)il2cpp_codegen_static_fields_for(Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7_il2cpp_TypeInfo_var))->___zeroVector_2;
		V_0 = L_0;
		goto IL_0009;
	}

IL_0009:
	{
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_1 = V_0;
		return L_1;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void OBJObjectBuilder_set_PushedFaceCount_m59B64D90A70C329BAB9F7E36961ED9C4D23744D8_inline (OBJObjectBuilder_t0FF6F614A40C0709678B6A0F9111F43397565F13* __this, int32_t ___value0, const RuntimeMethod* method) 
{
{
		// public int PushedFaceCount { get; private set; } = 0;
		int32_t L_0 = ___value0;
		__this->___U3CPushedFaceCountU3Ek__BackingField_0 = L_0;
		return;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void Color32__ctor_mC9C6B443F0C7CA3F8B174158B2AF6F05E18EAC4E_inline (Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B* __this, uint8_t ___r0, uint8_t ___g1, uint8_t ___b2, uint8_t ___a3, const RuntimeMethod* method) 
{
{
		__this->___rgba_0 = 0;
		uint8_t L_0 = ___r0;
		__this->___r_1 = L_0;
		uint8_t L_1 = ___g1;
		__this->___g_2 = L_1;
		uint8_t L_2 = ___b2;
		__this->___b_3 = L_2;
		uint8_t L_3 = ___a3;
		__this->___a_4 = L_3;
		return;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void Color__ctor_m3786F0D6E510D9CFA544523A955870BD2A514C8C_inline (Color_tD001788D726C3A7F1379BEED0260B9591F440C1F* __this, float ___r0, float ___g1, float ___b2, float ___a3, const RuntimeMethod* method) 
{
{
		float L_0 = ___r0;
		__this->___r_0 = L_0;
		float L_1 = ___g1;
		__this->___g_1 = L_1;
		float L_2 = ___b2;
		__this->___b_2 = L_2;
		float L_3 = ___a3;
		__this->___a_3 = L_3;
		return;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void List_1_Add_m79E50C4F592B1703F4B76A8BE7B4855515460CA1_gshared_inline (List_1_t77B94703E05C519A9010DD0614F757F974E1CD8B* __this, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___item0, const RuntimeMethod* method) 
{
Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* V_0 = NULL;
	int32_t V_1 = 0;
	{
		int32_t L_0 = (int32_t)__this->____version_3;
		__this->____version_3 = ((int32_t)il2cpp_codegen_add(L_0, 1));
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_1 = (Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C*)__this->____items_1;
		V_0 = L_1;
		int32_t L_2 = (int32_t)__this->____size_2;
		V_1 = L_2;
		int32_t L_3 = V_1;
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_4 = V_0;
		NullCheck(L_4);
		if ((!(((uint32_t)L_3) < ((uint32_t)((int32_t)(((RuntimeArray*)L_4)->max_length))))))
		{
			goto IL_0034;
		}
	}
	{
		int32_t L_5 = V_1;
		__this->____size_2 = ((int32_t)il2cpp_codegen_add(L_5, 1));
		Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* L_6 = V_0;
		int32_t L_7 = V_1;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_8 = ___item0;
		NullCheck(L_6);
		(L_6)->SetAt(static_cast<il2cpp_array_size_t>(L_7), (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2)L_8);
		return;
	}

IL_0034:
	{
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_9 = ___item0;
		((  void (*) (List_1_t77B94703E05C519A9010DD0614F757F974E1CD8B*, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2, const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 11)))(__this, L_9, il2cpp_rgctx_method(method->klass->rgctx_data, 11));
		return;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void List_1_Add_mB5FDF069171C4CB1778BFAC3B9015A22EA7DFBCD_gshared_inline (List_1_t8F3790B7F8C471B3A1336522C7415FB0AC36D47B* __this, Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 ___item0, const RuntimeMethod* method) 
{
Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* V_0 = NULL;
	int32_t V_1 = 0;
	{
		int32_t L_0 = (int32_t)__this->____version_3;
		__this->____version_3 = ((int32_t)il2cpp_codegen_add(L_0, 1));
		Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* L_1 = (Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA*)__this->____items_1;
		V_0 = L_1;
		int32_t L_2 = (int32_t)__this->____size_2;
		V_1 = L_2;
		int32_t L_3 = V_1;
		Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* L_4 = V_0;
		NullCheck(L_4);
		if ((!(((uint32_t)L_3) < ((uint32_t)((int32_t)(((RuntimeArray*)L_4)->max_length))))))
		{
			goto IL_0034;
		}
	}
	{
		int32_t L_5 = V_1;
		__this->____size_2 = ((int32_t)il2cpp_codegen_add(L_5, 1));
		Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* L_6 = V_0;
		int32_t L_7 = V_1;
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_8 = ___item0;
		NullCheck(L_6);
		(L_6)->SetAt(static_cast<il2cpp_array_size_t>(L_7), (Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7)L_8);
		return;
	}

IL_0034:
	{
		Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 L_9 = ___item0;
		((  void (*) (List_1_t8F3790B7F8C471B3A1336522C7415FB0AC36D47B*, Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7, const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 11)))(__this, L_9, il2cpp_rgctx_method(method->klass->rgctx_data, 11));
		return;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR int32_t List_1_get_Count_m46EEFFA770BE665EA0CB3A5332E941DA4B3C1D37_gshared_inline (List_1_t77B94703E05C519A9010DD0614F757F974E1CD8B* __this, const RuntimeMethod* method) 
{
{
		int32_t L_0 = (int32_t)__this->____size_2;
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR int32_t List_1_get_Count_mF1C0C56457C655BDFFC6EE5B46FAD8BAEC1F588B_gshared_inline (List_1_t8F3790B7F8C471B3A1336522C7415FB0AC36D47B* __this, const RuntimeMethod* method) 
{
{
		int32_t L_0 = (int32_t)__this->____size_2;
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void List_1_Add_m0248A96C5334E9A93E6994B7780478BCD994EA3D_gshared_inline (List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73* __this, int32_t ___item0, const RuntimeMethod* method) 
{
Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* V_0 = NULL;
	int32_t V_1 = 0;
	{
		int32_t L_0 = (int32_t)__this->____version_3;
		__this->____version_3 = ((int32_t)il2cpp_codegen_add(L_0, 1));
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_1 = (Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C*)__this->____items_1;
		V_0 = L_1;
		int32_t L_2 = (int32_t)__this->____size_2;
		V_1 = L_2;
		int32_t L_3 = V_1;
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_4 = V_0;
		NullCheck(L_4);
		if ((!(((uint32_t)L_3) < ((uint32_t)((int32_t)(((RuntimeArray*)L_4)->max_length))))))
		{
			goto IL_0034;
		}
	}
	{
		int32_t L_5 = V_1;
		__this->____size_2 = ((int32_t)il2cpp_codegen_add(L_5, 1));
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_6 = V_0;
		int32_t L_7 = V_1;
		int32_t L_8 = ___item0;
		NullCheck(L_6);
		(L_6)->SetAt(static_cast<il2cpp_array_size_t>(L_7), (int32_t)L_8);
		return;
	}

IL_0034:
	{
		int32_t L_9 = ___item0;
		((  void (*) (List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73*, int32_t, const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 11)))(__this, L_9, il2cpp_rgctx_method(method->klass->rgctx_data, 11));
		return;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void List_1_Clear_mF6795DE5F49C1D0B91D6A0955F448B22970D67A9_gshared_inline (List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73* __this, const RuntimeMethod* method) 
{
int32_t V_0 = 0;
	{
		int32_t L_0 = (int32_t)__this->____version_3;
		__this->____version_3 = ((int32_t)il2cpp_codegen_add(L_0, 1));
		if (!false)
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
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_3 = (Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C*)__this->____items_1;
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
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR KeyValuePair_2_tFC32D2507216293851350D29B64D79F950B55230 Enumerator_get_Current_mE3475384B761E1C7971D3639BD09117FE8363422_gshared_inline (Enumerator_tEA93FE2B778D098F590CA168BEFC4CD85D73A6B9* __this, const RuntimeMethod* method) 
{
{
		KeyValuePair_2_tFC32D2507216293851350D29B64D79F950B55230 L_0 = (KeyValuePair_2_tFC32D2507216293851350D29B64D79F950B55230)__this->____current_3;
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR RuntimeObject* KeyValuePair_2_get_Value_mC6BD8075F9C9DDEF7B4D731E5C38EC19103988E7_gshared_inline (KeyValuePair_2_tFC32D2507216293851350D29B64D79F950B55230* __this, const RuntimeMethod* method) 
{
{
		RuntimeObject* L_0 = (RuntimeObject*)__this->___value_1;
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR RuntimeObject* KeyValuePair_2_get_Key_mBD8EA7557C27E6956F2AF29DA3F7499B2F51A282_gshared_inline (KeyValuePair_2_tFC32D2507216293851350D29B64D79F950B55230* __this, const RuntimeMethod* method) 
{
{
		RuntimeObject* L_0 = (RuntimeObject*)__this->___key_0;
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR int32_t List_1_get_Count_mF590592E32D421DE2C6E2F0D5C2F62FB14CCEFDF_gshared_inline (List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73* __this, const RuntimeMethod* method) 
{
{
		int32_t L_0 = (int32_t)__this->____size_2;
		return L_0;
	}
}
