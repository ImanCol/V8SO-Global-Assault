#include "pch-c.h"
#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif


#include "codegen/il2cpp-codegen-metadata.h"





// 0x00000001 System.Int32 OggVorbis.NativeBridge::WriteAllPcmDataToFile(System.String,System.Single[],System.Int32,System.Int16,System.Int32,System.Single,System.Int32)
extern void NativeBridge_WriteAllPcmDataToFile_m57CDC7449AB58FDFBE7B7051088DC31DF5ACDF24 (void);
// 0x00000002 System.Int32 OggVorbis.NativeBridge::WriteAllPcmDataToMemory(System.IntPtr&,System.Int32&,System.Single[],System.Int32,System.Int16,System.Int32,System.Single,System.Int32)
extern void NativeBridge_WriteAllPcmDataToMemory_m41A9D7AFDAA3C9D5314DC6C6B99AF9BBFE75CEA5 (void);
// 0x00000003 System.Int32 OggVorbis.NativeBridge::FreeMemoryArrayForWriteAllPcmData(System.IntPtr)
extern void NativeBridge_FreeMemoryArrayForWriteAllPcmData_mF3B5D3742C2337A5BF481F680BDE016D2863D83C (void);
// 0x00000004 System.Int32 OggVorbis.NativeBridge::ReadAllPcmDataFromFile(System.String,System.IntPtr&,System.Int32&,System.Int16&,System.Int32&,System.Int32)
extern void NativeBridge_ReadAllPcmDataFromFile_mABB41A16CEBCD8271B1CECB12D32129E462CCF70 (void);
// 0x00000005 System.Int32 OggVorbis.NativeBridge::ReadAllPcmDataFromMemory(System.Byte[],System.Int32,System.IntPtr&,System.Int32&,System.Int16&,System.Int32&,System.Int32)
extern void NativeBridge_ReadAllPcmDataFromMemory_m66057BDE962045BC3071BC818A1968A9047E52CF (void);
// 0x00000006 System.Int32 OggVorbis.NativeBridge::FreeSamplesArrayNativeMemory(System.IntPtr&)
extern void NativeBridge_FreeSamplesArrayNativeMemory_m2930C84E7DCE5C3870CE9DC59B762B4383D1F709 (void);
// 0x00000007 System.IntPtr OggVorbis.NativeBridge::OpenReadFileStream(System.String,System.Int16&,System.Int32&)
extern void NativeBridge_OpenReadFileStream_m1341F837F1FD71314087330DDBD9178251A42866 (void);
// 0x00000008 System.Int32 OggVorbis.NativeBridge::ReadFromFileStream(System.IntPtr,System.Single[],System.Int32)
extern void NativeBridge_ReadFromFileStream_mA6908C37202712A4F13614033B51A9A170FC730A (void);
// 0x00000009 System.Int32 OggVorbis.NativeBridge::CloseFileStream(System.IntPtr)
extern void NativeBridge_CloseFileStream_m4C09F54F18ABE86D40D8F00AF3A014F185659212 (void);
// 0x0000000A OggVorbis.NativeErrorCode OggVorbis.NativeErrorException::get_NativeErrorCode()
extern void NativeErrorException_get_NativeErrorCode_mF23EA61585E779C9C2DFF0BBD066054FA35645AF (void);
// 0x0000000B System.Void OggVorbis.NativeErrorException::.ctor(OggVorbis.NativeErrorCode)
extern void NativeErrorException__ctor_mBF293DF7B617DFB22F653D607D9974666B6FDF34 (void);
// 0x0000000C System.String OggVorbis.NativeErrorException::ToString()
extern void NativeErrorException_ToString_mD837429EA0B17A6BAA633D8083FCEBCE9185CB20 (void);
// 0x0000000D System.Void OggVorbis.NativeErrorException::ThrowExceptionIfNecessary(System.Int32)
extern void NativeErrorException_ThrowExceptionIfNecessary_m723FC223E459605189BC7C6E596D2483DD2FFE34 (void);
// 0x0000000E System.Void OggVorbis.VorbisPlugin::Save(System.String,UnityEngine.AudioClip,System.Single,System.Int32)
extern void VorbisPlugin_Save_m8C2B5700CF0FC25E7E9A58419CFF77558E610F09 (void);
// 0x0000000F System.Byte[] OggVorbis.VorbisPlugin::GetOggVorbis(UnityEngine.AudioClip,System.Single,System.Int32)
extern void VorbisPlugin_GetOggVorbis_m3B878CA04A90674E8CFFECE6D17B353C77A1FDBC (void);
// 0x00000010 UnityEngine.AudioClip OggVorbis.VorbisPlugin::Load(System.String,System.Int32)
extern void VorbisPlugin_Load_m9E33486AAAA1266E16FF08CD0F7DFE8C2523E46D (void);
// 0x00000011 UnityEngine.AudioClip OggVorbis.VorbisPlugin::ToAudioClip(System.Byte[],System.String,System.Int32)
extern void VorbisPlugin_ToAudioClip_mBBC4FA100870DBB31BC274B12C45E883A855EF7B (void);
static Il2CppMethodPointer s_methodPointers[17] = 
{
	NativeBridge_WriteAllPcmDataToFile_m57CDC7449AB58FDFBE7B7051088DC31DF5ACDF24,
	NativeBridge_WriteAllPcmDataToMemory_m41A9D7AFDAA3C9D5314DC6C6B99AF9BBFE75CEA5,
	NativeBridge_FreeMemoryArrayForWriteAllPcmData_mF3B5D3742C2337A5BF481F680BDE016D2863D83C,
	NativeBridge_ReadAllPcmDataFromFile_mABB41A16CEBCD8271B1CECB12D32129E462CCF70,
	NativeBridge_ReadAllPcmDataFromMemory_m66057BDE962045BC3071BC818A1968A9047E52CF,
	NativeBridge_FreeSamplesArrayNativeMemory_m2930C84E7DCE5C3870CE9DC59B762B4383D1F709,
	NativeBridge_OpenReadFileStream_m1341F837F1FD71314087330DDBD9178251A42866,
	NativeBridge_ReadFromFileStream_mA6908C37202712A4F13614033B51A9A170FC730A,
	NativeBridge_CloseFileStream_m4C09F54F18ABE86D40D8F00AF3A014F185659212,
	NativeErrorException_get_NativeErrorCode_mF23EA61585E779C9C2DFF0BBD066054FA35645AF,
	NativeErrorException__ctor_mBF293DF7B617DFB22F653D607D9974666B6FDF34,
	NativeErrorException_ToString_mD837429EA0B17A6BAA633D8083FCEBCE9185CB20,
	NativeErrorException_ThrowExceptionIfNecessary_m723FC223E459605189BC7C6E596D2483DD2FFE34,
	VorbisPlugin_Save_m8C2B5700CF0FC25E7E9A58419CFF77558E610F09,
	VorbisPlugin_GetOggVorbis_m3B878CA04A90674E8CFFECE6D17B353C77A1FDBC,
	VorbisPlugin_Load_m9E33486AAAA1266E16FF08CD0F7DFE8C2523E46D,
	VorbisPlugin_ToAudioClip_mBBC4FA100870DBB31BC274B12C45E883A855EF7B,
};
static const int32_t s_InvokerIndices[17] = 
{
	9044,
	8969,
	12742,
	9123,
	9042,
	12729,
	10563,
	10493,
	12742,
	8483,
	6931,
	8518,
	13181,
	10287,
	10645,
	11385,
	10634,
};
IL2CPP_EXTERN_C const Il2CppCodeGenModule g_VorbisPluginImpl_CodeGenModule;
const Il2CppCodeGenModule g_VorbisPluginImpl_CodeGenModule = 
{
	"VorbisPluginImpl.dll",
	17,
	s_methodPointers,
	0,
	NULL,
	s_InvokerIndices,
	0,
	NULL,
	0,
	NULL,
	0,
	NULL,
	NULL,
	NULL, // module initializer,
	NULL,
	NULL,
	NULL,
};
