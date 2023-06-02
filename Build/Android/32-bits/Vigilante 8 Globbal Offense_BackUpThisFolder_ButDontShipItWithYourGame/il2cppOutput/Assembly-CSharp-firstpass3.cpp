#include "pch-cpp.hpp"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif


#include <limits>
#include <stdint.h>


struct VirtualActionInvoker0
{
	typedef void (*Action)(void*, const RuntimeMethod*);

	static inline void Invoke (Il2CppMethodSlot slot, RuntimeObject* obj)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_virtual_invoke_data(slot, obj);
		((Action)invokeData.methodPtr)(obj, invokeData.method);
	}
};
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
template <typename T1, typename T2, typename T3>
struct VirtualActionInvoker3
{
	typedef void (*Action)(void*, T1, T2, T3, const RuntimeMethod*);

	static inline void Invoke (Il2CppMethodSlot slot, RuntimeObject* obj, T1 p1, T2 p2, T3 p3)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_virtual_invoke_data(slot, obj);
		((Action)invokeData.methodPtr)(obj, p1, p2, p3, invokeData.method);
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
struct GenericVirtualActionInvoker0
{
	typedef void (*Action)(void*, const RuntimeMethod*);

	static inline void Invoke (const RuntimeMethod* method, RuntimeObject* obj)
	{
		VirtualInvokeData invokeData;
		il2cpp_codegen_get_generic_virtual_invoke_data(method, obj, &invokeData);
		((Action)invokeData.methodPtr)(obj, invokeData.method);
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
struct GenericInterfaceActionInvoker0
{
	typedef void (*Action)(void*, const RuntimeMethod*);

	static inline void Invoke (const RuntimeMethod* method, RuntimeObject* obj)
	{
		VirtualInvokeData invokeData;
		il2cpp_codegen_get_generic_interface_invoke_data(method, obj, &invokeData);
		((Action)invokeData.methodPtr)(obj, invokeData.method);
	}
};

// System.Collections.ObjectModel.Collection`1<System.Net.NetworkInformation.UnicastIPAddressInformation>
struct Collection_1_tFCFDED5321BE15CA8D30D61CF04DDE693BB0CB5B;
// System.Collections.Generic.Dictionary`2<System.Net.IPEndPoint,Lidgren.Network.NetConnection>
struct Dictionary_2_t3E2D78B3C0E00110EEC4A719EE470D02E9E504CA;
// System.Collections.Generic.Dictionary`2<System.Int32,System.Globalization.CultureInfo>
struct Dictionary_2_t9FA6D82CAFC18769F7515BB51D1C56DAE09381C3;
// System.Collections.Generic.Dictionary`2<System.Int32,System.Text.Encoding>
struct Dictionary_2_t87EDE08B2E48F793A22DE50D6B3CC2E7EBB2DB54;
// System.Collections.Generic.Dictionary`2<Lidgren.Network.NetConnection,System.Collections.Generic.Dictionary`2<System.Int32,Lidgren.Network.ReceivedFragmentGroup>>
struct Dictionary_2_t5E8A7D75F9D9116626AABF0EF1EA79C312B5CA35;
// System.Collections.Generic.Dictionary`2<System.String,System.Globalization.CultureInfo>
struct Dictionary_2_tE1603CE612C16451D1E56FF4D4859D4FE4087C28;
// System.Collections.Generic.Dictionary`2<System.String,System.Int32>
struct Dictionary_2_t5C8F46F5D57502270DD9E1DA8303B23C7FE85588;
// System.Collections.Generic.Dictionary`2<System.Type,System.Reflection.MethodInfo>
struct Dictionary_2_tB7188876A70AC81C939F78F9171156E43ED476CB;
// System.EventHandler`1<System.Net.Sockets.SocketAsyncEventArgs>
struct EventHandler_1_t5D3FC4609BD8133ED1226D6D49A1D8076B16A9ED;
// System.Collections.Generic.IList`1<Lidgren.Network.NetConnection>
struct IList_1_tA5A0E58AEC6B7246C2FB3780A75A8B8DC0A2454E;
// System.Collections.Generic.List`1<Lidgren.Network.NetTuple`2<System.Threading.SynchronizationContext,System.Threading.SendOrPostCallback>>
struct List_1_t2BEDA54616503C14F5307C4B792488DCAD745BF6;
// System.Collections.Generic.List`1<System.Byte[]>
struct List_1_tBFF9DD9FFA06F20E74F9D7AD36610BD754D353A4;
// System.Collections.Generic.List`1<Lidgren.Network.NetConnection>
struct List_1_tCB8A580EE26829F92BEF512FF7897CF3EF16121F;
// System.Collections.Generic.List`1<System.Object>
struct List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D;
// Lidgren.Network.NetQueue`1<Lidgren.Network.NetTuple`2<System.Net.IPEndPoint,Lidgren.Network.NetOutgoingMessage>>
struct NetQueue_1_tC9331D27AD040BE0CB3D518C96119F53610EE52F;
// Lidgren.Network.NetQueue`1<Lidgren.Network.NetTuple`2<Lidgren.Network.NetMessageType,System.Int32>>
struct NetQueue_1_tE71A99ADAE20AA707FCA1270C3C77F428EB3EE0A;
// Lidgren.Network.NetQueue`1<Lidgren.Network.NetIncomingMessage>
struct NetQueue_1_tA448F4D600FE68F21F1D458D14F14C383E6E7A86;
// Lidgren.Network.NetQueue`1<Lidgren.Network.NetOutgoingMessage>
struct NetQueue_1_tE04A2248A2948BB1FCEAAF0A1151D27B56B71EA3;
// Lidgren.Network.NetQueue`1<System.Object>
struct NetQueue_1_tAC0CAA8AA1377F47E01B1B5969BCBC397B5F339A;
// System.Net.Sockets.Socket/TaskSocketAsyncEventArgs`1<System.Net.Sockets.Socket>
struct TaskSocketAsyncEventArgs_1_tEB937620E5B15D91E5BFEFFA707CF800930F8401;
// System.Threading.Tasks.Task`1<System.Int32>
struct Task_1_t4C228DE57804012969575431CFF12D57C875552D;
// System.Byte[][]
struct ByteU5BU5DU5BU5D_t19A0C6D66F22DF673E9CDB37DEF566FE0EC947FA;
// System.Byte[]
struct ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031;
// System.Char[]
struct CharU5BU5D_t799905CF001DD5F13F7DBB310181FC4D8B7D0AAB;
// System.Delegate[]
struct DelegateU5BU5D_tC5AB7E8F745616680F337909D3A8E6C722CDF771;
// System.Net.IPAddress[]
struct IPAddressU5BU5D_t3AEDF3B94746C9023A4549F878AA47F702C9CD0D;
// System.Int32[]
struct Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C;
// System.IntPtr[]
struct IntPtrU5BU5D_tFD177F8C806A6921AD7150264CCC62FA00CAD832;
// System.Reflection.MemberInfo[]
struct MemberInfoU5BU5D_t4CB6970BB166E8E1CFB06152B2A2284971873053;
// Lidgren.Network.NetConnection[]
struct NetConnectionU5BU5D_t314469DA3AE889697B6399280EEF1EE8ADC5F0D4;
// Lidgren.Network.NetIncomingMessage[]
struct NetIncomingMessageU5BU5D_tE6182F91F2C9B34755AB3E8A13305818DD434AFA;
// Lidgren.Network.NetOutgoingMessage[]
struct NetOutgoingMessageU5BU5D_t1F13884C9D4BD2E3C43A02C5654C1F925693E00F;
// Lidgren.Network.NetReceiverChannelBase[]
struct NetReceiverChannelBaseU5BU5D_t15A339AD4C01B1010E09FE9AFC380A0595F8FFE0;
// Lidgren.Network.NetSenderChannelBase[]
struct NetSenderChannelBaseU5BU5D_tAC45A45D8CFFEB8743D1E83FBE893091945D523D;
// Lidgren.Network.NetStoredReliableMessage[]
struct NetStoredReliableMessageU5BU5D_t23591445FC2D24CA762300B550255D630D65C634;
// System.Net.NetworkInformation.NetworkInterface[]
struct NetworkInterfaceU5BU5D_t62783E27F1C4A989B118CDBBE2FCBE65EE5CA080;
// System.Object[]
struct ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918;
// System.SByte[]
struct SByteU5BU5D_t88116DA68378C3333DB73E7D36C1A06AFAA91913;
// System.Diagnostics.StackTrace[]
struct StackTraceU5BU5D_t32FBCB20930EAF5BAE3F450FF75228E5450DA0DF;
// System.String[]
struct StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248;
// System.Type[]
struct TypeU5BU5D_t97234E1129B564EB38B8D85CAC2AD8B5B9522FFB;
// System.UInt16[]
struct UInt16U5BU5D_tEB7C42D811D999D2AA815BADC3FCCDD9C67B3F83;
// System.UInt32[]
struct UInt32U5BU5D_t02FBD658AD156A17574ECE6106CF1FBFCC9807FA;
// System.Net.WebHeaderCollection/RfcChar[]
struct RfcCharU5BU5D_t8D79A380C46398F9D1F442FDEE0A27F77B7D1B4C;
// System.Xml.XmlNamespaceManager/NamespaceDeclaration[]
struct NamespaceDeclarationU5BU5D_t4DF48D3A2EB82C491A60E8748DE4BAFAA95A0F60;
// System.ArgumentException
struct ArgumentException_tAD90411542A20A9C72D5CDA3A84181D8B947A263;
// System.Collections.ArrayList
struct ArrayList_t7A8E5AF0C4378015B5731ABE2BED8F2782FEEF8A;
// System.AsyncCallback
struct AsyncCallback_t7FEF460CBDCFB9C5FA2EF776984778B9A4145F4C;
// System.Threading.AutoResetEvent
struct AutoResetEvent_t7F792F3F7AD11BEF7B411E771D98E5266A8CE7C0;
// System.Reflection.Binder
struct Binder_t91BFCE95A7057FADF4D8A1A342AFE52872246235;
// System.Globalization.Calendar
struct Calendar_t0A117CC7532A54C17188C2EFEA1F79DB20DF3A3B;
// System.Globalization.CodePageDataItem
struct CodePageDataItem_t52460FA30AE37F4F26ACB81055E58002262F19F2;
// System.Globalization.CompareInfo
struct CompareInfo_t1B1A6AC3486B570C76ABA52149C9BD4CD82F9E57;
// Lidgren.Network.CryptoRandom
struct CryptoRandom_t8B21DF8737471EFF3D15D1ACB0AF83ABA4A600B8;
// System.Globalization.CultureData
struct CultureData_tEEFDCF4ECA1BBF6C0C8C94EB3541657245598F9D;
// System.Globalization.CultureInfo
struct CultureInfo_t9BA817D41AD55AC8BD07480DD8AC22F8FFA378E0;
// System.Globalization.DateTimeFormatInfo
struct DateTimeFormatInfo_t0457520F9FA7B5C8EAAEB3AD50413B6AEEB7458A;
// System.Text.DecoderFallback
struct DecoderFallback_t7324102215E4ED41EC065C02EB501CB0BC23CD90;
// System.Delegate
struct Delegate_t;
// System.DelegateData
struct DelegateData_t9B286B493293CD2D23A5B2B5EF0E5B1324C2B77E;
// System.Xml.DomNameTable
struct DomNameTable_tE4318EC10C55A46FD00324E740BFA7D9CEE2AF45;
// System.Xml.EmptyEnumerator
struct EmptyEnumerator_t84EC9187C8460EE98E675ED9258AE4DF2A6776DA;
// System.Text.EncoderFallback
struct EncoderFallback_tD2C40CE114AA9D8E1F7196608B2D088548015293;
// System.Text.Encoding
struct Encoding_t65CDEF28CF20A7B8C92E85A4E808920C2465F095;
// System.Net.EndPoint
struct EndPoint_t6233F4E2EB9F0F2D36E187F12BE050E6D8B73564;
// System.Enum
struct Enum_t2A1A94B24E3B776EEF4E5E485E290BB9D4D072E2;
// System.Threading.EventWaitHandle
struct EventWaitHandle_t18F2EB0161747B0646A9A406015A61A214A1EB7E;
// System.Security.Cryptography.HashAlgorithm
struct HashAlgorithm_t299ECE61BBF4582B1F75734D43A96DDEC9B2004D;
// System.Collections.Hashtable
struct Hashtable_tEFC3B6496E6747787D8BB761B51F2AE3A8CFFE2D;
// System.Net.HeaderInfoTable
struct HeaderInfoTable_tD651971044220ED52EACB30E89A49178FA32D91F;
// System.IAsyncResult
struct IAsyncResult_t7B9B5A0ECB35DCEC31B8A8122C37D687369253B5;
// System.Collections.IDictionary
struct IDictionary_t6D03155AF1FA9083817AA5B6AD7DEEACC26AB220;
// System.Collections.IEqualityComparer
struct IEqualityComparer_tEF8F1EC76B9C8E76695BE848D41E6B147928D1C1;
// System.IOAsyncCallback
struct IOAsyncCallback_tDBBA8BBDA6B203613680E77BD4AD6320A1268388;
// System.Net.IPAddress
struct IPAddress_t2F4486449B0D73FF2D3B36A9FE5E9C3F63116484;
// System.Net.IPEndPoint
struct IPEndPoint_t2F09CBA7A808B67724B4E2954EEDC46D910F4ECB;
// System.Net.NetworkInformation.IPGlobalProperties
struct IPGlobalProperties_tA6F98E3AAD35DD4C6BF821152D3D7B092C80C26D;
// System.Net.IPHostEntry
struct IPHostEntry_tAAAEB0F40DB9F28BE601B5FE7DA1D76191C94490;
// System.Net.IWebProxy
struct IWebProxy_t3ECD2C773539B48B18734D61E87B685A9C93076D;
// System.Xml.Schema.IXmlSchemaInfo
struct IXmlSchemaInfo_tF7DB6310A471259B33C4081B30E73925164204DB;
// Lidgren.Network.MWCRandom
struct MWCRandom_t2EE86D33187F701E26B088DA14D02651D83FAD76;
// System.Threading.ManualResetEvent
struct ManualResetEvent_t63959486AA41A113A4353D0BF4A68E77EBA0A158;
// System.Reflection.MemberFilter
struct MemberFilter_tF644F1AE82F611B677CE1964D5A3277DDA21D553;
// System.Reflection.MemberInfo
struct MemberInfo_t;
// Lidgren.Network.MersenneTwisterRandom
struct MersenneTwisterRandom_tF01E9C0FB95208029F72ED8DC92F000E172E71CA;
// System.Reflection.MethodInfo
struct MethodInfo_t;
// System.Collections.Specialized.NameValueCollection
struct NameValueCollection_t52D1E38AB1D4ADD497A17DA305D663BB77B31DF7;
// Lidgren.Network.NetBigInteger
struct NetBigInteger_t06C831F115CE5B02A3EB70F99F2C5ABA75E0FF76;
// Lidgren.Network.NetBitVector
struct NetBitVector_tF8CA8B405111502BD2A21BADB51D903E2E21FF67;
// Lidgren.Network.NetBuffer
struct NetBuffer_t540408A0C414C4D84C990C31D9E73CC671677BDC;
// Lidgren.Network.NetConnection
struct NetConnection_tBC8B4699CF2D1614FF259EE7E3031D8D25E31F9D;
// Lidgren.Network.NetConnectionStatistics
struct NetConnectionStatistics_tF5BA1B2E0C5BAB9BF01D6D815A9F3CCCA624CBAD;
// Lidgren.Network.NetIncomingMessage
struct NetIncomingMessage_t5E80A584865BF84B3148130AE0CE9A0794DD0A71;
// Lidgren.Network.NetOutgoingMessage
struct NetOutgoingMessage_t2C00CEEAEF52CDD51F8F991F2F8AFA314FEAAECB;
// Lidgren.Network.NetPeer
struct NetPeer_tDCD3AC5FB42BE47DEE7AEEA74F327C1E0D883542;
// Lidgren.Network.NetPeerConfiguration
struct NetPeerConfiguration_t7BA55B2118BE6EC975E65EEE156B05E72A3339DD;
// Lidgren.Network.NetPeerStatistics
struct NetPeerStatistics_t88AAAF8E56D8CB028A6D4C2E745330471A4FCD32;
// Lidgren.Network.NetRandom
struct NetRandom_t5390B683E78A49E7984152B9490E6350D1D16AFB;
// Lidgren.Network.NetReceiverChannelBase
struct NetReceiverChannelBase_t56118523C994D57E27F048D445AFF933D49CCA3C;
// Lidgren.Network.NetReliableOrderedReceiver
struct NetReliableOrderedReceiver_t8AF4B8E9088E083F64FEB029207E68FD0BF5F01C;
// Lidgren.Network.NetReliableSenderChannel
struct NetReliableSenderChannel_tA9749EC67EDA9FBCCB0D40CB31EB8320C89B42C2;
// Lidgren.Network.NetReliableSequencedReceiver
struct NetReliableSequencedReceiver_tD29A0B141AC897E64B68250EDAEA8BD32B4FE85E;
// Lidgren.Network.NetReliableUnorderedReceiver
struct NetReliableUnorderedReceiver_t220A30799285402D92F29CB2DCF8175041C817E7;
// Lidgren.Network.NetSenderChannelBase
struct NetSenderChannelBase_t60E3BDE4FA746EE6C8453DD201764C0B7D6948A2;
// Lidgren.Network.NetServer
struct NetServer_tD42376D31E46BCB7E7502576EE48D3DEFCDBD342;
// Lidgren.Network.NetUPnP
struct NetUPnP_tBDA843B6A55F8DBED04BF614EEAEDB1F256D86E8;
// Lidgren.Network.NetUnreliableSenderChannel
struct NetUnreliableSenderChannel_tA3223FD53136DB0B7FE5725D243F2513393E55B5;
// Lidgren.Network.NetUnreliableSequencedReceiver
struct NetUnreliableSequencedReceiver_t57B31E1EC305B1BF46565AEA3DB94CD7DCE328B7;
// Lidgren.Network.NetUnreliableUnorderedReceiver
struct NetUnreliableUnorderedReceiver_t0E05BC9C7DF55EA30AF87AFC80106005C57A5131;
// Lidgren.Network.NetXtea
struct NetXtea_t550919425A4D12A3C995681D55B1719AB2FBD2F0;
// System.Net.NetworkInformation.NetworkInterface
struct NetworkInterface_t3E7DDFADB8912D0F9D001D1195EBD0FB08B7F47A;
// System.NotImplementedException
struct NotImplementedException_t6366FE4DCF15094C51F4833B91A2AE68D4DA90E8;
// System.Globalization.NumberFormatInfo
struct NumberFormatInfo_t8E26808B202927FEBF9064FCFEEA4D6E076E6472;
// System.Net.NetworkInformation.PhysicalAddress
struct PhysicalAddress_tBD58CB2A171D8DEFF0C882DE988D2D446EF40DEB;
// System.Security.Cryptography.RNGCryptoServiceProvider
struct RNGCryptoServiceProvider_tAD9D75EFF3D2ED0929EEE27A53BE82AB83D78170;
// System.Random
struct Random_t79716069EDE67D1D7734F60AE402D0CA3FB6B4C8;
// System.Security.Cryptography.RandomNumberGenerator
struct RandomNumberGenerator_t4E862666A2F7D55324960670C7A1B4C2D40222F3;
// System.Threading.ReaderWriterLockSlim
struct ReaderWriterLockSlim_t3BF29C18C9FC0EE07209EDD54D938EA473FB3906;
// System.Net.Cache.RequestCacheBinding
struct RequestCacheBinding_t18F3F4FF8D0F77E86C2C666CEE7FD48A80C042EE;
// System.Net.Cache.RequestCachePolicy
struct RequestCachePolicy_tF15C94C5E458478914D5EB17753294BD488B0550;
// System.Net.Cache.RequestCacheProtocol
struct RequestCacheProtocol_t43C1AC170194874A0C0B0D3B8BE9EABFB613DF85;
// System.Security.Cryptography.SHA256
struct SHA256_t6FEDD761EE6301127DAAF13320E8FD63296837F9;
// System.Runtime.Serialization.SafeSerializationManager
struct SafeSerializationManager_tCBB85B95DFD1634237140CD892E82D06ECB3F5E6;
// System.Net.Sockets.SafeSocketHandle
struct SafeSocketHandle_t5A597D30D951E736B750ED09D5B3AB72F98407EE;
// Microsoft.Win32.SafeHandles.SafeWaitHandle
struct SafeWaitHandle_t58F5662CD56F6462A687198A64987F8980804449;
// System.Xml.Schema.SchemaInfo
struct SchemaInfo_t42F4B1099B63BCF2D3BBF7F35A79AF6B90B0927E;
// System.Threading.SemaphoreSlim
struct SemaphoreSlim_t0D5CB5685D9BFA5BF95CEC6E7395490F933E8DB2;
// System.Runtime.Serialization.SerializationInfo
struct SerializationInfo_t3C47F63E24BEB9FCE2DC6309E027F238DC5C5E37;
// System.Net.Sockets.Socket
struct Socket_t1F49472CDA22B581C29A258225ABF3ADA9DED67E;
// System.Net.Sockets.SocketException
struct SocketException_t6D10102A62EA871BD31748E026A372DB6804083B;
// System.String
struct String_t;
// System.Text.StringBuilder
struct StringBuilder_t;
// System.StringComparer
struct StringComparer_t6268F19CA34879176651429C0D8A3D0002BB8E06;
// System.Globalization.TextInfo
struct TextInfo_tD3BAFCFD77418851E7D5CB8D2588F47019E414B4;
// System.Threading.Thread
struct Thread_t0A773B9DE873D2DCAA7D229EAB36757B500E207F;
// System.Type
struct Type_t;
// System.Void
struct Void_t4861ACF8F4594C3437BB48B6E56783494B843915;
// System.Net.WebRequest
struct WebRequest_t89050438AE9A5AA9221ECAE223584127F7C1294B;
// System.Xml.XmlAttribute
struct XmlAttribute_t4B6CC461196FBF5CC9F777E74CC82C98E0CA9D18;
// System.Xml.XmlDocument
struct XmlDocument_t4DE82998E642C5C21A4A620A5278237C70D3E42B;
// System.Xml.XmlImplementation
struct XmlImplementation_t4B3F467B76BD95C919C40424196C55B38EEC0F4D;
// System.Xml.XmlLinkedNode
struct XmlLinkedNode_t640BF5D3FDAF0606665C3BAE565988A5014F1B9C;
// System.Xml.XmlNameTable
struct XmlNameTable_tBDBAACFF3DB40A8E6AF3BDC11F0FF166CF11ABB8;
// System.Xml.XmlNamedNodeMap
struct XmlNamedNodeMap_t13203D1B3861C62568AFFA1D644C04ABCBFC130C;
// System.Xml.XmlNamespaceManager
struct XmlNamespaceManager_t95431ADE7A94108629DFF894819FB1A9709D810F;
// System.Xml.XmlNode
struct XmlNode_t3180B9B3D5C36CD58F5327D9F13458E3B3F030AF;
// System.Xml.XmlNodeChangedEventHandler
struct XmlNodeChangedEventHandler_t907F6E9CB8DE238635028EC468AD41CAB0BA269B;
// System.Xml.XmlResolver
struct XmlResolver_tE25A33DFCB87A939D11BC8543970F6857AEC3DCF;
// System.Xml.Schema.XmlSchemaSet
struct XmlSchemaSet_t048A12CE7D00EF330EF32A388B69A240899F88D1;
// Lidgren.Network.XorShiftRandom
struct XorShiftRandom_t31C7255ACBCD4E96B483B540560EE527FA28B908;
// System.Collections.Specialized.NameObjectCollectionBase/NameObjectEntry
struct NameObjectEntry_t58A8B38FC7A6ABE5C83153B6C3F2696F88E7A9A2;
// Lidgren.Network.NetUtility/<>c__DisplayClass3_0
struct U3CU3Ec__DisplayClass3_0_t8A9B82FCFB20DB8AF0DEB4BFF84B5BF342D6D362;
// Lidgren.Network.NetUtility/<>c__DisplayClass7_0
struct U3CU3Ec__DisplayClass7_0_tB883D8785D0FF482B1D10D9C5244FE77BF69353A;
// Lidgren.Network.NetUtility/ResolveAddressCallback
struct ResolveAddressCallback_t025BC6260F915039CDB17B31BCDE78B9ED8CC3CF;
// Lidgren.Network.NetUtility/ResolveEndPointCallback
struct ResolveEndPointCallback_t5A60EB6B6BDAEA33BFEB134C8EFED8B43385049B;
// System.Net.Sockets.Socket/CachedEventArgs
struct CachedEventArgs_tF0692E89962FD1A045B17BC985F838C11FB6822C;
// System.Net.Sockets.Socket/Int32TaskSocketAsyncEventArgs
struct Int32TaskSocketAsyncEventArgs_t36C5FC82499ED9DAFE7F05C38EF92D77A0B248E9;
// System.IO.Stream/ReadWriteTask
struct ReadWriteTask_t0821BF49EE38596C7734E86E1A6A39D769BE2C05;
// System.Net.TimerThread/Queue
struct Queue_t644DC21212BC432819522EDA395EB4562BE2CC47;
// System.Net.WebRequest/DesignerWebRequestCreate
struct DesignerWebRequestCreate_t75F62E4DEBF416E21EAF6FBB62E43ADB83A0753E;

IL2CPP_EXTERN_C RuntimeClass* ArgumentException_tAD90411542A20A9C72D5CDA3A84181D8B947A263_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* AsyncCallback_t7FEF460CBDCFB9C5FA2EF776984778B9A4145F4C_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* BitConverter_t6E99605185963BC12B3D369E13F2B88997E64A27_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* CharU5BU5D_t799905CF001DD5F13F7DBB310181FC4D8B7D0AAB_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Convert_t7097FF336D592F7C06D88A98349A44646F91EFFC_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* CryptoRandom_t8B21DF8737471EFF3D15D1ACB0AF83ABA4A600B8_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* CultureInfo_t9BA817D41AD55AC8BD07480DD8AC22F8FFA378E0_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Exception_t_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* IDisposable_t030E0496B4E0E4E4F086825007979AF51F7248C5_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* IEnumerator_1_tA218C3658C89562941B7435E73E48E2EDC26D9BD_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* IEnumerator_t7B609C2FFA6EB5167D9C62A0C32A21DE2F666DAA_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* IPAddress_t2F4486449B0D73FF2D3B36A9FE5E9C3F63116484_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* IPEndPoint_t2F09CBA7A808B67724B4E2954EEDC46D910F4ECB_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* List_1_tCB8A580EE26829F92BEF512FF7897CF3EF16121F_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* MWCRandom_t2EE86D33187F701E26B088DA14D02651D83FAD76_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* ManualResetEvent_t63959486AA41A113A4353D0BF4A68E77EBA0A158_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Math_tEB65DE7CA8B083C412C969C92981C030865486CE_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* MersenneTwisterRandom_tF01E9C0FB95208029F72ED8DC92F000E172E71CA_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* NetBigInteger_t06C831F115CE5B02A3EB70F99F2C5ABA75E0FF76_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* NetBitVector_tF8CA8B405111502BD2A21BADB51D903E2E21FF67_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* NetIncomingMessageU5BU5D_tE6182F91F2C9B34755AB3E8A13305818DD434AFA_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* NetQueue_1_tE04A2248A2948BB1FCEAAF0A1151D27B56B71EA3_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* NetRandomSeed_t78C4CD0A1F9754C7FC65DBE87A58F24C76419A8E_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* NetRandom_t5390B683E78A49E7984152B9490E6350D1D16AFB_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* NetSRP_tCB8425B4A061CEF6A1C0914A06C41D2745DBD951_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* NetStoredReliableMessageU5BU5D_t23591445FC2D24CA762300B550255D630D65C634_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* NetTime_tF7D62D28C9302513C9535DE2F9B41553B2548DE7_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* NetUtility_t0B01E9514810CE3FC3B5E83D8427CBA1C5689EFD_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* NetXtea_t550919425A4D12A3C995681D55B1719AB2FBD2F0_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* NotImplementedException_t6366FE4DCF15094C51F4833B91A2AE68D4DA90E8_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* ProtocolType_t104D087F8C40460E0FE8D38659949AEA910CD20A_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* RNGCryptoServiceProvider_tAD9D75EFF3D2ED0929EEE27A53BE82AB83D78170_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Random_t79716069EDE67D1D7734F60AE402D0CA3FB6B4C8_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* ResolveAddressCallback_t025BC6260F915039CDB17B31BCDE78B9ED8CC3CF_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* RuntimeObject_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* SocketException_t6D10102A62EA871BD31748E026A372DB6804083B_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Stopwatch_tA188A210449E22C07053A7D3014DD182C7369043_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* StringBuilder_t_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* TimeSpan_t8195C5B013A2C532FEBDF0B64B6911982E750F5A_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Type_t_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* U3CU3Ec__DisplayClass3_0_t8A9B82FCFB20DB8AF0DEB4BFF84B5BF342D6D362_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* U3CU3Ec__DisplayClass7_0_tB883D8785D0FF482B1D10D9C5244FE77BF69353A_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* UInt32U5BU5D_t02FBD658AD156A17574ECE6106CF1FBFCC9807FA_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* WebRequest_t89050438AE9A5AA9221ECAE223584127F7C1294B_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* XmlDocument_t4DE82998E642C5C21A4A620A5278237C70D3E42B_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* XmlNamespaceManager_t95431ADE7A94108629DFF894819FB1A9709D810F_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* XorShiftRandom_t31C7255ACBCD4E96B483B540560EE527FA28B908_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C String_t* _stringLiteral08A267223F99ED7C786E1899CC41C2D0CAEE5774;
IL2CPP_EXTERN_C String_t* _stringLiteral08D30F14509C8365E327175A5D6557EFD61BA45C;
IL2CPP_EXTERN_C String_t* _stringLiteral0AF744421B52F4BED7B731DBE013E5B22C656BBC;
IL2CPP_EXTERN_C String_t* _stringLiteral0DBE744A44DDF9503B87CCBF0390BB7C764CB0ED;
IL2CPP_EXTERN_C String_t* _stringLiteral11CE4C29D0C7FA2347C524512600FEAB96B84D10;
IL2CPP_EXTERN_C String_t* _stringLiteral14E338D17C42E552FA7AF42CDAE40CA1F0E8A04D;
IL2CPP_EXTERN_C String_t* _stringLiteral1AD0CE271AA2DFAD431E2FC69D0587B6C1CAFA18;
IL2CPP_EXTERN_C String_t* _stringLiteral1B22BF18C56863E5B7EB7520B9741A85F61B6BC6;
IL2CPP_EXTERN_C String_t* _stringLiteral293FD0A62157C0798F2DBF19E2A112B2F32964A6;
IL2CPP_EXTERN_C String_t* _stringLiteral2A04459105AE2163347709664ECD535E3E105DF5;
IL2CPP_EXTERN_C String_t* _stringLiteral2C6D55A7C7BB624D69C05CC09678AAF3F3D49A19;
IL2CPP_EXTERN_C String_t* _stringLiteral2EA39FD1A6510BEA527E847A17EE16B182F1A174;
IL2CPP_EXTERN_C String_t* _stringLiteral3366F334BA687B5F09C809786A02BFA24ADA8FE4;
IL2CPP_EXTERN_C String_t* _stringLiteral3489643EFE94266F20613DEAA99FFCC76C044707;
IL2CPP_EXTERN_C String_t* _stringLiteral36A681C495A31FB315D7D4FE550319B4413084C2;
IL2CPP_EXTERN_C String_t* _stringLiteral3930A1937087B284E8C5AADF61F618FF4786362A;
IL2CPP_EXTERN_C String_t* _stringLiteral3AE148F4539A6130C80EF45C5441F068ADBF8C8C;
IL2CPP_EXTERN_C String_t* _stringLiteral3AFB31AEFC546297555B36EF940F37C1ADCCC7CA;
IL2CPP_EXTERN_C String_t* _stringLiteral3B9252E0782022A05A1A5DC8E569F6054E24A2BD;
IL2CPP_EXTERN_C String_t* _stringLiteral3D0EA11AB4A233A3D304D0CF23569AB865DDE70F;
IL2CPP_EXTERN_C String_t* _stringLiteral40695C7AB1EB25BBB42D193B8DD12787571410BC;
IL2CPP_EXTERN_C String_t* _stringLiteral409FAF38FC25C13F705C019133CD49F11F11878B;
IL2CPP_EXTERN_C String_t* _stringLiteral4586384AE33FFDAB4C9542726BF7EC462C46F8D1;
IL2CPP_EXTERN_C String_t* _stringLiteral48BEAF85DA57187170C6471DAC10BD67D02A40BB;
IL2CPP_EXTERN_C String_t* _stringLiteral4D868A34BF4C64BE357F03A0502F8780A1947FAD;
IL2CPP_EXTERN_C String_t* _stringLiteral52EBA66B2A9CA363162F4B34A1E22C620301D799;
IL2CPP_EXTERN_C String_t* _stringLiteral5A83027BA58C6703A855737A110D0A1018143201;
IL2CPP_EXTERN_C String_t* _stringLiteral5E4C76669D301F0CED3F6E8F0856461B786D1082;
IL2CPP_EXTERN_C String_t* _stringLiteral6A9C16890A6DC07573195A8A76F9E8CFF701C48B;
IL2CPP_EXTERN_C String_t* _stringLiteral78F7AFA5D1330C70AD3BBBEB7F8766F2C4D9E603;
IL2CPP_EXTERN_C String_t* _stringLiteral7AA4F9D664F2002ACD9C3606A0D4AE7CC3807D6E;
IL2CPP_EXTERN_C String_t* _stringLiteral849E189D85B0C93D90F5CD6EC2B6FB59CDBDA9E5;
IL2CPP_EXTERN_C String_t* _stringLiteral86BBAACC00198DBB3046818AD3FC2AA10AE48DE1;
IL2CPP_EXTERN_C String_t* _stringLiteral876C4B39B6E4D0187090400768899C71D99DE90D;
IL2CPP_EXTERN_C String_t* _stringLiteral8CB509FEC517C5EC041C9CEAB337EA4C0B0E596A;
IL2CPP_EXTERN_C String_t* _stringLiteral8F5312EFB7BCEA437BD477CADD56369CE463213B;
IL2CPP_EXTERN_C String_t* _stringLiteral92CB236B774CCCCF0E79BFC374F88CD76084EE69;
IL2CPP_EXTERN_C String_t* _stringLiteral9874DEA2D36B50B6344F39E1E4852E1B8D35BC08;
IL2CPP_EXTERN_C String_t* _stringLiteral9AB7AE2A6D393ADACFEBBBF239951E42C5ACA0E8;
IL2CPP_EXTERN_C String_t* _stringLiteral9B16626643AD985A74711905C5E491E882840AC2;
IL2CPP_EXTERN_C String_t* _stringLiteral9F954BE9FD9E999DA1677DADC6D2CAB27412A282;
IL2CPP_EXTERN_C String_t* _stringLiteralA18A4AE569C5BE88A9C406093C040EFEBFF78C5E;
IL2CPP_EXTERN_C String_t* _stringLiteralACDB66C1A5ADC16347A6D0A2A0870CACE5E78073;
IL2CPP_EXTERN_C String_t* _stringLiteralB1037556B1B0A0647BA76414559E0C28B2D7DD16;
IL2CPP_EXTERN_C String_t* _stringLiteralB15D8BB6ED8882FE2991E7CFC731A0E16DD9C8D4;
IL2CPP_EXTERN_C String_t* _stringLiteralB6820E3EE92F6889A3D523074454DC3D1830FF96;
IL2CPP_EXTERN_C String_t* _stringLiteralBB90FA8EAC2B192B0155029DA99BED2806431413;
IL2CPP_EXTERN_C String_t* _stringLiteralBCE589EF40970A3617C61809C44D0ACCD7EFDCDA;
IL2CPP_EXTERN_C String_t* _stringLiteralC4922A689E4721D8F955FD6F8DFFA68DBDF04CA7;
IL2CPP_EXTERN_C String_t* _stringLiteralC5953BAEAE1C4C9506A8190E5A75FB0FBD272ED1;
IL2CPP_EXTERN_C String_t* _stringLiteralC62C64F00567C5368CAE37F4E64E1E82FF785677;
IL2CPP_EXTERN_C String_t* _stringLiteralCEC24757C254A874F3A0F3564E4D6967511B49A0;
IL2CPP_EXTERN_C String_t* _stringLiteralD780C0360D4AE4D11F08385D4437D757F04827FA;
IL2CPP_EXTERN_C String_t* _stringLiteralD8BEF597D4648B03343F2A7F25B08E6FCC313671;
IL2CPP_EXTERN_C String_t* _stringLiteralDA39A3EE5E6B4B0D3255BFEF95601890AFD80709;
IL2CPP_EXTERN_C String_t* _stringLiteralDBEC827409AB5C91169A1D96A32D42A9529653C7;
IL2CPP_EXTERN_C String_t* _stringLiteralDE4E77B5141B532F175AF1BD80D5F19B0F6A6C24;
IL2CPP_EXTERN_C String_t* _stringLiteralE03DC21A0CCF764B6DC5FB0D23ADB632409A427E;
IL2CPP_EXTERN_C String_t* _stringLiteralE876EC859F6B9C3D005838181FBD73930F2D8F22;
IL2CPP_EXTERN_C String_t* _stringLiteralE935C3A9AABA7F6F869D63A22759322AA75593AD;
IL2CPP_EXTERN_C String_t* _stringLiteralF0FEDFF01B5EC752DBD3BE0CD53AD377827EAB7F;
IL2CPP_EXTERN_C String_t* _stringLiteralF3E84B722399601AD7E281754E917478AA9AD48D;
IL2CPP_EXTERN_C String_t* _stringLiteralF822C1F6D3A5E12491A8E4E81D846C56CEC9DA65;
IL2CPP_EXTERN_C String_t* _stringLiteralFF7805784057B58BBD0371A720C775271F690CA2;
IL2CPP_EXTERN_C const RuntimeMethod* Enumerator_Dispose_m07181BB10C1BA5DC601AE525BD8135BC4EB56FBD_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Enumerator_MoveNext_m85D3F022A9B8C14AF8EAECDBC6AD2758243E2267_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Enumerator_get_Current_m6E66C77AF2421CC882C1A0DD5B0BFF34A4BE4214_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* List_1_Add_m8CE33AF029F57595E3FF186EE02E159E0EBB6DE3_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* List_1_GetEnumerator_mA1703FADFF65E89C664E1AC2C224E137EDCE0FAA_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* List_1__ctor_mD729DF400FADFA39FCECE0669139C521DD2D110C_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* List_1_get_Count_m2718A4E7883478B0124E79583E511312C71D8CC8_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* NetQueue_1_Clear_m2D3A4A1665A1449F169FAD863EC1025C6A471FDB_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* NetQueue_1_Enqueue_m29381A69FDF40552A8ABA5B1385D72E71F1EB435_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* NetQueue_1_TryDequeue_m64BE224E287C91F5A80BC1F74C4777A5BD3BB97C_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* NetQueue_1__ctor_m66DF6F6C6BA14E66C85046A8D415C5E75508640F_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* NetQueue_1_get_Count_m9D0B8118A5875517A26773BBA576C2006810DE22_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* NetRandom_Initialize_mAF5A07C896F3A9330E898D3921F87C7AE8964FF5_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* NetRandom_NextUInt32_m154D8DBA6A332C58AC66EBC33CEE5869C5756C6F_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* NetUtility_GetBroadcastAddress_m69CC4AFCA51DE14371F00A5A25170739B1496935_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* NetUtility_ResolveAsync_m361784C8A1E4D583AFD6B9C6D2502EFB1BAAF22C_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* NetUtility_Resolve_m8DB1E743A221537111D97A7E975E46D59F4EF1BB_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* NetUtility__cctor_m1710CB911C1F69AA57110BA75A0A48D9AF7F7813_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Type_GetType_m80C621C4D91A89DDEE6D3DDF343925B30F99BC45_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* U3CU3Ec__DisplayClass3_0_U3CResolveAsyncU3Eb__0_m062212D8E00D13552A2546A577F790E095E6373D_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* U3CU3Ec__DisplayClass7_0_U3CResolveAsyncU3Eb__0_mF089B3B4BCAE0306728BCD87C51A27A1FF559ED9_RuntimeMethod_var;
struct CultureData_tEEFDCF4ECA1BBF6C0C8C94EB3541657245598F9D_marshaled_com;
struct CultureData_tEEFDCF4ECA1BBF6C0C8C94EB3541657245598F9D_marshaled_pinvoke;
struct CultureInfo_t9BA817D41AD55AC8BD07480DD8AC22F8FFA378E0_marshaled_com;
struct CultureInfo_t9BA817D41AD55AC8BD07480DD8AC22F8FFA378E0_marshaled_pinvoke;
struct Delegate_t_marshaled_com;
struct Delegate_t_marshaled_pinvoke;
struct Exception_t_marshaled_com;
struct Exception_t_marshaled_pinvoke;

struct ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031;
struct CharU5BU5D_t799905CF001DD5F13F7DBB310181FC4D8B7D0AAB;
struct DelegateU5BU5D_tC5AB7E8F745616680F337909D3A8E6C722CDF771;
struct IPAddressU5BU5D_t3AEDF3B94746C9023A4549F878AA47F702C9CD0D;
struct MemberInfoU5BU5D_t4CB6970BB166E8E1CFB06152B2A2284971873053;
struct NetIncomingMessageU5BU5D_tE6182F91F2C9B34755AB3E8A13305818DD434AFA;
struct NetStoredReliableMessageU5BU5D_t23591445FC2D24CA762300B550255D630D65C634;
struct NetworkInterfaceU5BU5D_t62783E27F1C4A989B118CDBBE2FCBE65EE5CA080;
struct ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918;
struct StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248;
struct UInt32U5BU5D_t02FBD658AD156A17574ECE6106CF1FBFCC9807FA;

IL2CPP_EXTERN_C_BEGIN
IL2CPP_EXTERN_C_END

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Collections.Generic.List`1<System.Byte[]>
struct List_1_tBFF9DD9FFA06F20E74F9D7AD36610BD754D353A4  : public RuntimeObject
{
	// T[] System.Collections.Generic.List`1::_items
	ByteU5BU5DU5BU5D_t19A0C6D66F22DF673E9CDB37DEF566FE0EC947FA* ____items_1;
	// System.Int32 System.Collections.Generic.List`1::_size
	int32_t ____size_2;
	// System.Int32 System.Collections.Generic.List`1::_version
	int32_t ____version_3;
	// System.Object System.Collections.Generic.List`1::_syncRoot
	RuntimeObject* ____syncRoot_4;
};

struct List_1_tBFF9DD9FFA06F20E74F9D7AD36610BD754D353A4_StaticFields
{
	// T[] System.Collections.Generic.List`1::s_emptyArray
	ByteU5BU5DU5BU5D_t19A0C6D66F22DF673E9CDB37DEF566FE0EC947FA* ___s_emptyArray_5;
};

// System.Collections.Generic.List`1<Lidgren.Network.NetConnection>
struct List_1_tCB8A580EE26829F92BEF512FF7897CF3EF16121F  : public RuntimeObject
{
	// T[] System.Collections.Generic.List`1::_items
	NetConnectionU5BU5D_t314469DA3AE889697B6399280EEF1EE8ADC5F0D4* ____items_1;
	// System.Int32 System.Collections.Generic.List`1::_size
	int32_t ____size_2;
	// System.Int32 System.Collections.Generic.List`1::_version
	int32_t ____version_3;
	// System.Object System.Collections.Generic.List`1::_syncRoot
	RuntimeObject* ____syncRoot_4;
};

struct List_1_tCB8A580EE26829F92BEF512FF7897CF3EF16121F_StaticFields
{
	// T[] System.Collections.Generic.List`1::s_emptyArray
	NetConnectionU5BU5D_t314469DA3AE889697B6399280EEF1EE8ADC5F0D4* ___s_emptyArray_5;
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

// Lidgren.Network.NetQueue`1<Lidgren.Network.NetOutgoingMessage>
struct NetQueue_1_tE04A2248A2948BB1FCEAAF0A1151D27B56B71EA3  : public RuntimeObject
{
	// T[] Lidgren.Network.NetQueue`1::m_items
	NetOutgoingMessageU5BU5D_t1F13884C9D4BD2E3C43A02C5654C1F925693E00F* ___m_items_0;
	// System.Threading.ReaderWriterLockSlim Lidgren.Network.NetQueue`1::m_lock
	ReaderWriterLockSlim_t3BF29C18C9FC0EE07209EDD54D938EA473FB3906* ___m_lock_1;
	// System.Int32 Lidgren.Network.NetQueue`1::m_size
	int32_t ___m_size_2;
	// System.Int32 Lidgren.Network.NetQueue`1::m_head
	int32_t ___m_head_3;
};
struct Il2CppArrayBounds;

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

// System.Text.Encoding
struct Encoding_t65CDEF28CF20A7B8C92E85A4E808920C2465F095  : public RuntimeObject
{
	// System.Int32 System.Text.Encoding::m_codePage
	int32_t ___m_codePage_9;
	// System.Globalization.CodePageDataItem System.Text.Encoding::dataItem
	CodePageDataItem_t52460FA30AE37F4F26ACB81055E58002262F19F2* ___dataItem_10;
	// System.Boolean System.Text.Encoding::m_deserializedFromEverett
	bool ___m_deserializedFromEverett_11;
	// System.Boolean System.Text.Encoding::m_isReadOnly
	bool ___m_isReadOnly_12;
	// System.Text.EncoderFallback System.Text.Encoding::encoderFallback
	EncoderFallback_tD2C40CE114AA9D8E1F7196608B2D088548015293* ___encoderFallback_13;
	// System.Text.DecoderFallback System.Text.Encoding::decoderFallback
	DecoderFallback_t7324102215E4ED41EC065C02EB501CB0BC23CD90* ___decoderFallback_14;
};

struct Encoding_t65CDEF28CF20A7B8C92E85A4E808920C2465F095_StaticFields
{
	// System.Text.Encoding modreq(System.Runtime.CompilerServices.IsVolatile) System.Text.Encoding::defaultEncoding
	Encoding_t65CDEF28CF20A7B8C92E85A4E808920C2465F095* ___defaultEncoding_0;
	// System.Text.Encoding modreq(System.Runtime.CompilerServices.IsVolatile) System.Text.Encoding::unicodeEncoding
	Encoding_t65CDEF28CF20A7B8C92E85A4E808920C2465F095* ___unicodeEncoding_1;
	// System.Text.Encoding modreq(System.Runtime.CompilerServices.IsVolatile) System.Text.Encoding::bigEndianUnicode
	Encoding_t65CDEF28CF20A7B8C92E85A4E808920C2465F095* ___bigEndianUnicode_2;
	// System.Text.Encoding modreq(System.Runtime.CompilerServices.IsVolatile) System.Text.Encoding::utf7Encoding
	Encoding_t65CDEF28CF20A7B8C92E85A4E808920C2465F095* ___utf7Encoding_3;
	// System.Text.Encoding modreq(System.Runtime.CompilerServices.IsVolatile) System.Text.Encoding::utf8Encoding
	Encoding_t65CDEF28CF20A7B8C92E85A4E808920C2465F095* ___utf8Encoding_4;
	// System.Text.Encoding modreq(System.Runtime.CompilerServices.IsVolatile) System.Text.Encoding::utf32Encoding
	Encoding_t65CDEF28CF20A7B8C92E85A4E808920C2465F095* ___utf32Encoding_5;
	// System.Text.Encoding modreq(System.Runtime.CompilerServices.IsVolatile) System.Text.Encoding::asciiEncoding
	Encoding_t65CDEF28CF20A7B8C92E85A4E808920C2465F095* ___asciiEncoding_6;
	// System.Text.Encoding modreq(System.Runtime.CompilerServices.IsVolatile) System.Text.Encoding::latin1Encoding
	Encoding_t65CDEF28CF20A7B8C92E85A4E808920C2465F095* ___latin1Encoding_7;
	// System.Collections.Generic.Dictionary`2<System.Int32,System.Text.Encoding> modreq(System.Runtime.CompilerServices.IsVolatile) System.Text.Encoding::encodings
	Dictionary_2_t87EDE08B2E48F793A22DE50D6B3CC2E7EBB2DB54* ___encodings_8;
	// System.Object System.Text.Encoding::s_InternalSyncObject
	RuntimeObject* ___s_InternalSyncObject_15;
};

// System.Net.EndPoint
struct EndPoint_t6233F4E2EB9F0F2D36E187F12BE050E6D8B73564  : public RuntimeObject
{
};

// System.Security.Cryptography.HashAlgorithm
struct HashAlgorithm_t299ECE61BBF4582B1F75734D43A96DDEC9B2004D  : public RuntimeObject
{
	// System.Boolean System.Security.Cryptography.HashAlgorithm::_disposed
	bool ____disposed_0;
	// System.Int32 System.Security.Cryptography.HashAlgorithm::HashSizeValue
	int32_t ___HashSizeValue_1;
	// System.Byte[] System.Security.Cryptography.HashAlgorithm::HashValue
	ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* ___HashValue_2;
	// System.Int32 System.Security.Cryptography.HashAlgorithm::State
	int32_t ___State_3;
};

// System.Net.IPAddress
struct IPAddress_t2F4486449B0D73FF2D3B36A9FE5E9C3F63116484  : public RuntimeObject
{
	// System.UInt32 System.Net.IPAddress::_addressOrScopeId
	uint32_t ____addressOrScopeId_8;
	// System.UInt16[] System.Net.IPAddress::_numbers
	UInt16U5BU5D_tEB7C42D811D999D2AA815BADC3FCCDD9C67B3F83* ____numbers_9;
	// System.String System.Net.IPAddress::_toString
	String_t* ____toString_10;
	// System.Int32 System.Net.IPAddress::_hashCode
	int32_t ____hashCode_11;
};

struct IPAddress_t2F4486449B0D73FF2D3B36A9FE5E9C3F63116484_StaticFields
{
	// System.Net.IPAddress System.Net.IPAddress::Any
	IPAddress_t2F4486449B0D73FF2D3B36A9FE5E9C3F63116484* ___Any_0;
	// System.Net.IPAddress System.Net.IPAddress::Loopback
	IPAddress_t2F4486449B0D73FF2D3B36A9FE5E9C3F63116484* ___Loopback_1;
	// System.Net.IPAddress System.Net.IPAddress::Broadcast
	IPAddress_t2F4486449B0D73FF2D3B36A9FE5E9C3F63116484* ___Broadcast_2;
	// System.Net.IPAddress System.Net.IPAddress::None
	IPAddress_t2F4486449B0D73FF2D3B36A9FE5E9C3F63116484* ___None_3;
	// System.Net.IPAddress System.Net.IPAddress::IPv6Any
	IPAddress_t2F4486449B0D73FF2D3B36A9FE5E9C3F63116484* ___IPv6Any_5;
	// System.Net.IPAddress System.Net.IPAddress::IPv6Loopback
	IPAddress_t2F4486449B0D73FF2D3B36A9FE5E9C3F63116484* ___IPv6Loopback_6;
	// System.Net.IPAddress System.Net.IPAddress::IPv6None
	IPAddress_t2F4486449B0D73FF2D3B36A9FE5E9C3F63116484* ___IPv6None_7;
};

// System.Net.NetworkInformation.IPAddressInformation
struct IPAddressInformation_t88AEE176C5711B91C890536A43B17C95690A07A7  : public RuntimeObject
{
};

// System.Net.NetworkInformation.IPGlobalProperties
struct IPGlobalProperties_tA6F98E3AAD35DD4C6BF821152D3D7B092C80C26D  : public RuntimeObject
{
};

// System.Net.IPHostEntry
struct IPHostEntry_tAAAEB0F40DB9F28BE601B5FE7DA1D76191C94490  : public RuntimeObject
{
	// System.String System.Net.IPHostEntry::hostName
	String_t* ___hostName_0;
	// System.String[] System.Net.IPHostEntry::aliases
	StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248* ___aliases_1;
	// System.Net.IPAddress[] System.Net.IPHostEntry::addressList
	IPAddressU5BU5D_t3AEDF3B94746C9023A4549F878AA47F702C9CD0D* ___addressList_2;
	// System.Boolean System.Net.IPHostEntry::isTrustedHost
	bool ___isTrustedHost_3;
};

// System.Net.NetworkInformation.IPInterfaceProperties
struct IPInterfaceProperties_t60A00D504E4F72CAFE4C0AE4DA6A062B44D1512F  : public RuntimeObject
{
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

// System.Reflection.MemberInfo
struct MemberInfo_t  : public RuntimeObject
{
};

// System.Collections.Specialized.NameObjectCollectionBase
struct NameObjectCollectionBase_tB6400DF2FA3B64660D79586B79016B4A0BA645FC  : public RuntimeObject
{
	// System.Boolean System.Collections.Specialized.NameObjectCollectionBase::_readOnly
	bool ____readOnly_0;
	// System.Collections.ArrayList System.Collections.Specialized.NameObjectCollectionBase::_entriesArray
	ArrayList_t7A8E5AF0C4378015B5731ABE2BED8F2782FEEF8A* ____entriesArray_1;
	// System.Collections.IEqualityComparer System.Collections.Specialized.NameObjectCollectionBase::_keyComparer
	RuntimeObject* ____keyComparer_2;
	// System.Collections.Hashtable modreq(System.Runtime.CompilerServices.IsVolatile) System.Collections.Specialized.NameObjectCollectionBase::_entriesTable
	Hashtable_tEFC3B6496E6747787D8BB761B51F2AE3A8CFFE2D* ____entriesTable_3;
	// System.Collections.Specialized.NameObjectCollectionBase/NameObjectEntry modreq(System.Runtime.CompilerServices.IsVolatile) System.Collections.Specialized.NameObjectCollectionBase::_nullKeyEntry
	NameObjectEntry_t58A8B38FC7A6ABE5C83153B6C3F2696F88E7A9A2* ____nullKeyEntry_4;
	// System.Runtime.Serialization.SerializationInfo System.Collections.Specialized.NameObjectCollectionBase::_serializationInfo
	SerializationInfo_t3C47F63E24BEB9FCE2DC6309E027F238DC5C5E37* ____serializationInfo_5;
	// System.Int32 System.Collections.Specialized.NameObjectCollectionBase::_version
	int32_t ____version_6;
	// System.Object System.Collections.Specialized.NameObjectCollectionBase::_syncRoot
	RuntimeObject* ____syncRoot_7;
};

struct NameObjectCollectionBase_tB6400DF2FA3B64660D79586B79016B4A0BA645FC_StaticFields
{
	// System.StringComparer System.Collections.Specialized.NameObjectCollectionBase::defaultComparer
	StringComparer_t6268F19CA34879176651429C0D8A3D0002BB8E06* ___defaultComparer_8;
};

// Lidgren.Network.NetBigInteger
struct NetBigInteger_t06C831F115CE5B02A3EB70F99F2C5ABA75E0FF76  : public RuntimeObject
{
	// System.Int32 Lidgren.Network.NetBigInteger::m_sign
	int32_t ___m_sign_21;
	// System.Int32[] Lidgren.Network.NetBigInteger::m_magnitude
	Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* ___m_magnitude_22;
	// System.Int32 Lidgren.Network.NetBigInteger::m_numBits
	int32_t ___m_numBits_23;
	// System.Int32 Lidgren.Network.NetBigInteger::m_numBitLength
	int32_t ___m_numBitLength_24;
	// System.Int64 Lidgren.Network.NetBigInteger::m_quote
	int64_t ___m_quote_25;
};

struct NetBigInteger_t06C831F115CE5B02A3EB70F99F2C5ABA75E0FF76_StaticFields
{
	// System.Int32[] Lidgren.Network.NetBigInteger::ZeroMagnitude
	Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* ___ZeroMagnitude_2;
	// System.Byte[] Lidgren.Network.NetBigInteger::ZeroEncoding
	ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* ___ZeroEncoding_3;
	// Lidgren.Network.NetBigInteger Lidgren.Network.NetBigInteger::Zero
	NetBigInteger_t06C831F115CE5B02A3EB70F99F2C5ABA75E0FF76* ___Zero_4;
	// Lidgren.Network.NetBigInteger Lidgren.Network.NetBigInteger::One
	NetBigInteger_t06C831F115CE5B02A3EB70F99F2C5ABA75E0FF76* ___One_5;
	// Lidgren.Network.NetBigInteger Lidgren.Network.NetBigInteger::Two
	NetBigInteger_t06C831F115CE5B02A3EB70F99F2C5ABA75E0FF76* ___Two_6;
	// Lidgren.Network.NetBigInteger Lidgren.Network.NetBigInteger::Three
	NetBigInteger_t06C831F115CE5B02A3EB70F99F2C5ABA75E0FF76* ___Three_7;
	// Lidgren.Network.NetBigInteger Lidgren.Network.NetBigInteger::Ten
	NetBigInteger_t06C831F115CE5B02A3EB70F99F2C5ABA75E0FF76* ___Ten_8;
	// Lidgren.Network.NetBigInteger Lidgren.Network.NetBigInteger::radix2
	NetBigInteger_t06C831F115CE5B02A3EB70F99F2C5ABA75E0FF76* ___radix2_10;
	// Lidgren.Network.NetBigInteger Lidgren.Network.NetBigInteger::radix2E
	NetBigInteger_t06C831F115CE5B02A3EB70F99F2C5ABA75E0FF76* ___radix2E_11;
	// Lidgren.Network.NetBigInteger Lidgren.Network.NetBigInteger::radix10
	NetBigInteger_t06C831F115CE5B02A3EB70F99F2C5ABA75E0FF76* ___radix10_13;
	// Lidgren.Network.NetBigInteger Lidgren.Network.NetBigInteger::radix10E
	NetBigInteger_t06C831F115CE5B02A3EB70F99F2C5ABA75E0FF76* ___radix10E_14;
	// Lidgren.Network.NetBigInteger Lidgren.Network.NetBigInteger::radix16
	NetBigInteger_t06C831F115CE5B02A3EB70F99F2C5ABA75E0FF76* ___radix16_16;
	// Lidgren.Network.NetBigInteger Lidgren.Network.NetBigInteger::radix16E
	NetBigInteger_t06C831F115CE5B02A3EB70F99F2C5ABA75E0FF76* ___radix16E_17;
};

// Lidgren.Network.NetBitVector
struct NetBitVector_tF8CA8B405111502BD2A21BADB51D903E2E21FF67  : public RuntimeObject
{
	// System.Int32 Lidgren.Network.NetBitVector::m_capacity
	int32_t ___m_capacity_0;
	// System.Int32[] Lidgren.Network.NetBitVector::m_data
	Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* ___m_data_1;
	// System.Int32 Lidgren.Network.NetBitVector::m_numBitsSet
	int32_t ___m_numBitsSet_2;
};

// Lidgren.Network.NetBuffer
struct NetBuffer_t540408A0C414C4D84C990C31D9E73CC671677BDC  : public RuntimeObject
{
	// System.Byte[] Lidgren.Network.NetBuffer::m_data
	ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* ___m_data_3;
	// System.Int32 Lidgren.Network.NetBuffer::m_bitLength
	int32_t ___m_bitLength_4;
	// System.Int32 Lidgren.Network.NetBuffer::m_readPosition
	int32_t ___m_readPosition_5;
};

struct NetBuffer_t540408A0C414C4D84C990C31D9E73CC671677BDC_StaticFields
{
	// System.Collections.Generic.Dictionary`2<System.Type,System.Reflection.MethodInfo> Lidgren.Network.NetBuffer::s_readMethods
	Dictionary_2_tB7188876A70AC81C939F78F9171156E43ED476CB* ___s_readMethods_1;
	// System.Collections.Generic.Dictionary`2<System.Type,System.Reflection.MethodInfo> Lidgren.Network.NetBuffer::s_writeMethods
	Dictionary_2_tB7188876A70AC81C939F78F9171156E43ED476CB* ___s_writeMethods_2;
	// System.Object Lidgren.Network.NetBuffer::s_buffer
	RuntimeObject* ___s_buffer_8;
};

// Lidgren.Network.NetEncryption
struct NetEncryption_tEC39EE735AC6898BDF8C0249DD0B51CF5E6BDB41  : public RuntimeObject
{
	// Lidgren.Network.NetPeer Lidgren.Network.NetEncryption::m_peer
	NetPeer_tDCD3AC5FB42BE47DEE7AEEA74F327C1E0D883542* ___m_peer_0;
};

// Lidgren.Network.NetPeerStatistics
struct NetPeerStatistics_t88AAAF8E56D8CB028A6D4C2E745330471A4FCD32  : public RuntimeObject
{
	// Lidgren.Network.NetPeer Lidgren.Network.NetPeerStatistics::m_peer
	NetPeer_tDCD3AC5FB42BE47DEE7AEEA74F327C1E0D883542* ___m_peer_0;
	// System.Int32 Lidgren.Network.NetPeerStatistics::m_sentPackets
	int32_t ___m_sentPackets_1;
	// System.Int32 Lidgren.Network.NetPeerStatistics::m_receivedPackets
	int32_t ___m_receivedPackets_2;
	// System.Int32 Lidgren.Network.NetPeerStatistics::m_sentMessages
	int32_t ___m_sentMessages_3;
	// System.Int32 Lidgren.Network.NetPeerStatistics::m_receivedMessages
	int32_t ___m_receivedMessages_4;
	// System.Int32 Lidgren.Network.NetPeerStatistics::m_receivedFragments
	int32_t ___m_receivedFragments_5;
	// System.Int32 Lidgren.Network.NetPeerStatistics::m_sentBytes
	int32_t ___m_sentBytes_6;
	// System.Int32 Lidgren.Network.NetPeerStatistics::m_receivedBytes
	int32_t ___m_receivedBytes_7;
	// System.Int64 Lidgren.Network.NetPeerStatistics::m_bytesAllocated
	int64_t ___m_bytesAllocated_8;
};

// Lidgren.Network.NetRandomSeed
struct NetRandomSeed_t78C4CD0A1F9754C7FC65DBE87A58F24C76419A8E  : public RuntimeObject
{
};

struct NetRandomSeed_t78C4CD0A1F9754C7FC65DBE87A58F24C76419A8E_StaticFields
{
	// System.Int32 Lidgren.Network.NetRandomSeed::m_seedIncrement
	int32_t ___m_seedIncrement_0;
};

// Lidgren.Network.NetReceiverChannelBase
struct NetReceiverChannelBase_t56118523C994D57E27F048D445AFF933D49CCA3C  : public RuntimeObject
{
	// Lidgren.Network.NetPeer Lidgren.Network.NetReceiverChannelBase::m_peer
	NetPeer_tDCD3AC5FB42BE47DEE7AEEA74F327C1E0D883542* ___m_peer_0;
	// Lidgren.Network.NetConnection Lidgren.Network.NetReceiverChannelBase::m_connection
	NetConnection_tBC8B4699CF2D1614FF259EE7E3031D8D25E31F9D* ___m_connection_1;
};

// Lidgren.Network.NetSRP
struct NetSRP_tCB8425B4A061CEF6A1C0914A06C41D2745DBD951  : public RuntimeObject
{
};

struct NetSRP_tCB8425B4A061CEF6A1C0914A06C41D2745DBD951_StaticFields
{
	// Lidgren.Network.NetBigInteger Lidgren.Network.NetSRP::N
	NetBigInteger_t06C831F115CE5B02A3EB70F99F2C5ABA75E0FF76* ___N_0;
	// Lidgren.Network.NetBigInteger Lidgren.Network.NetSRP::g
	NetBigInteger_t06C831F115CE5B02A3EB70F99F2C5ABA75E0FF76* ___g_1;
	// Lidgren.Network.NetBigInteger Lidgren.Network.NetSRP::k
	NetBigInteger_t06C831F115CE5B02A3EB70F99F2C5ABA75E0FF76* ___k_2;
};

// Lidgren.Network.NetSenderChannelBase
struct NetSenderChannelBase_t60E3BDE4FA746EE6C8453DD201764C0B7D6948A2  : public RuntimeObject
{
	// Lidgren.Network.NetQueue`1<Lidgren.Network.NetOutgoingMessage> Lidgren.Network.NetSenderChannelBase::m_queuedSends
	NetQueue_1_tE04A2248A2948BB1FCEAAF0A1151D27B56B71EA3* ___m_queuedSends_0;
};

// Lidgren.Network.NetTime
struct NetTime_tF7D62D28C9302513C9535DE2F9B41553B2548DE7  : public RuntimeObject
{
};

struct NetTime_tF7D62D28C9302513C9535DE2F9B41553B2548DE7_StaticFields
{
	// System.Int64 Lidgren.Network.NetTime::s_timeInitialized
	int64_t ___s_timeInitialized_0;
	// System.Double Lidgren.Network.NetTime::s_dInvFreq
	double ___s_dInvFreq_1;
};

// Lidgren.Network.NetUtility
struct NetUtility_t0B01E9514810CE3FC3B5E83D8427CBA1C5689EFD  : public RuntimeObject
{
};

struct NetUtility_t0B01E9514810CE3FC3B5E83D8427CBA1C5689EFD_StaticFields
{
	// System.Boolean Lidgren.Network.NetUtility::IsMono
	bool ___IsMono_0;
	// System.Net.IPAddress Lidgren.Network.NetUtility::s_broadcastAddress
	IPAddress_t2F4486449B0D73FF2D3B36A9FE5E9C3F63116484* ___s_broadcastAddress_1;
	// System.Int64 Lidgren.Network.NetUtility::s_timeInitialized
	int64_t ___s_timeInitialized_2;
	// System.Double Lidgren.Network.NetUtility::s_dInvFreq
	double ___s_dInvFreq_3;
	// System.Security.Cryptography.SHA256 Lidgren.Network.NetUtility::s_sha
	SHA256_t6FEDD761EE6301127DAAF13320E8FD63296837F9* ___s_sha_4;
};

// System.Net.NetworkInformation.NetworkInterface
struct NetworkInterface_t3E7DDFADB8912D0F9D001D1195EBD0FB08B7F47A  : public RuntimeObject
{
};

// System.Net.NetworkInformation.PhysicalAddress
struct PhysicalAddress_tBD58CB2A171D8DEFF0C882DE988D2D446EF40DEB  : public RuntimeObject
{
	// System.Byte[] System.Net.NetworkInformation.PhysicalAddress::address
	ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* ___address_0;
	// System.Boolean System.Net.NetworkInformation.PhysicalAddress::changed
	bool ___changed_1;
	// System.Int32 System.Net.NetworkInformation.PhysicalAddress::hash
	int32_t ___hash_2;
};

struct PhysicalAddress_tBD58CB2A171D8DEFF0C882DE988D2D446EF40DEB_StaticFields
{
	// System.Net.NetworkInformation.PhysicalAddress System.Net.NetworkInformation.PhysicalAddress::None
	PhysicalAddress_tBD58CB2A171D8DEFF0C882DE988D2D446EF40DEB* ___None_3;
};

// System.Random
struct Random_t79716069EDE67D1D7734F60AE402D0CA3FB6B4C8  : public RuntimeObject
{
	// System.Int32 System.Random::_inext
	int32_t ____inext_3;
	// System.Int32 System.Random::_inextp
	int32_t ____inextp_4;
	// System.Int32[] System.Random::_seedArray
	Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* ____seedArray_5;
};

struct Random_t79716069EDE67D1D7734F60AE402D0CA3FB6B4C8_StaticFields
{
	// System.Random System.Random::s_globalRandom
	Random_t79716069EDE67D1D7734F60AE402D0CA3FB6B4C8* ___s_globalRandom_7;
};

struct Random_t79716069EDE67D1D7734F60AE402D0CA3FB6B4C8_ThreadStaticFields
{
	// System.Random System.Random::t_threadRandom
	Random_t79716069EDE67D1D7734F60AE402D0CA3FB6B4C8* ___t_threadRandom_6;
};

// System.Security.Cryptography.RandomNumberGenerator
struct RandomNumberGenerator_t4E862666A2F7D55324960670C7A1B4C2D40222F3  : public RuntimeObject
{
};

// System.Diagnostics.Stopwatch
struct Stopwatch_tA188A210449E22C07053A7D3014DD182C7369043  : public RuntimeObject
{
	// System.Int64 System.Diagnostics.Stopwatch::elapsed
	int64_t ___elapsed_2;
	// System.Int64 System.Diagnostics.Stopwatch::started
	int64_t ___started_3;
	// System.Boolean System.Diagnostics.Stopwatch::is_running
	bool ___is_running_4;
};

struct Stopwatch_tA188A210449E22C07053A7D3014DD182C7369043_StaticFields
{
	// System.Int64 System.Diagnostics.Stopwatch::Frequency
	int64_t ___Frequency_0;
	// System.Boolean System.Diagnostics.Stopwatch::IsHighResolution
	bool ___IsHighResolution_1;
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

// System.Net.NetworkInformation.UnicastIPAddressInformationCollection
struct UnicastIPAddressInformationCollection_tB4D61C9127DFB4168CA3855020CCEB59B75C6EDA  : public RuntimeObject
{
	// System.Collections.ObjectModel.Collection`1<System.Net.NetworkInformation.UnicastIPAddressInformation> System.Net.NetworkInformation.UnicastIPAddressInformationCollection::addresses
	Collection_1_tFCFDED5321BE15CA8D30D61CF04DDE693BB0CB5B* ___addresses_0;
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

// System.Xml.XmlNameTable
struct XmlNameTable_tBDBAACFF3DB40A8E6AF3BDC11F0FF166CF11ABB8  : public RuntimeObject
{
};

// System.Xml.XmlNamespaceManager
struct XmlNamespaceManager_t95431ADE7A94108629DFF894819FB1A9709D810F  : public RuntimeObject
{
	// System.Xml.XmlNamespaceManager/NamespaceDeclaration[] System.Xml.XmlNamespaceManager::nsdecls
	NamespaceDeclarationU5BU5D_t4DF48D3A2EB82C491A60E8748DE4BAFAA95A0F60* ___nsdecls_0;
	// System.Int32 System.Xml.XmlNamespaceManager::lastDecl
	int32_t ___lastDecl_1;
	// System.Xml.XmlNameTable System.Xml.XmlNamespaceManager::nameTable
	XmlNameTable_tBDBAACFF3DB40A8E6AF3BDC11F0FF166CF11ABB8* ___nameTable_2;
	// System.Int32 System.Xml.XmlNamespaceManager::scopeId
	int32_t ___scopeId_3;
	// System.Collections.Generic.Dictionary`2<System.String,System.Int32> System.Xml.XmlNamespaceManager::hashTable
	Dictionary_2_t5C8F46F5D57502270DD9E1DA8303B23C7FE85588* ___hashTable_4;
	// System.Boolean System.Xml.XmlNamespaceManager::useHashtable
	bool ___useHashtable_5;
	// System.String System.Xml.XmlNamespaceManager::xml
	String_t* ___xml_6;
	// System.String System.Xml.XmlNamespaceManager::xmlNs
	String_t* ___xmlNs_7;
};

// System.Xml.XmlNode
struct XmlNode_t3180B9B3D5C36CD58F5327D9F13458E3B3F030AF  : public RuntimeObject
{
	// System.Xml.XmlNode System.Xml.XmlNode::parentNode
	XmlNode_t3180B9B3D5C36CD58F5327D9F13458E3B3F030AF* ___parentNode_0;
};

// Lidgren.Network.NetUtility/<>c__DisplayClass3_0
struct U3CU3Ec__DisplayClass3_0_t8A9B82FCFB20DB8AF0DEB4BFF84B5BF342D6D362  : public RuntimeObject
{
	// Lidgren.Network.NetUtility/ResolveEndPointCallback Lidgren.Network.NetUtility/<>c__DisplayClass3_0::callback
	ResolveEndPointCallback_t5A60EB6B6BDAEA33BFEB134C8EFED8B43385049B* ___callback_0;
	// System.Int32 Lidgren.Network.NetUtility/<>c__DisplayClass3_0::port
	int32_t ___port_1;
};

// Lidgren.Network.NetUtility/<>c__DisplayClass7_0
struct U3CU3Ec__DisplayClass7_0_tB883D8785D0FF482B1D10D9C5244FE77BF69353A  : public RuntimeObject
{
	// System.Net.IPHostEntry Lidgren.Network.NetUtility/<>c__DisplayClass7_0::entry
	IPHostEntry_tAAAEB0F40DB9F28BE601B5FE7DA1D76191C94490* ___entry_0;
	// Lidgren.Network.NetUtility/ResolveAddressCallback Lidgren.Network.NetUtility/<>c__DisplayClass7_0::callback
	ResolveAddressCallback_t025BC6260F915039CDB17B31BCDE78B9ED8CC3CF* ___callback_1;
};

// System.Collections.Generic.List`1/Enumerator<Lidgren.Network.NetConnection>
struct Enumerator_t544F92AE49BEB4DE05D485E77C4AB2E71862B6A4 
{
	// System.Collections.Generic.List`1<T> System.Collections.Generic.List`1/Enumerator::_list
	List_1_tCB8A580EE26829F92BEF512FF7897CF3EF16121F* ____list_0;
	// System.Int32 System.Collections.Generic.List`1/Enumerator::_index
	int32_t ____index_1;
	// System.Int32 System.Collections.Generic.List`1/Enumerator::_version
	int32_t ____version_2;
	// T System.Collections.Generic.List`1/Enumerator::_current
	NetConnection_tBC8B4699CF2D1614FF259EE7E3031D8D25E31F9D* ____current_3;
};

// System.Collections.Generic.List`1/Enumerator<System.Object>
struct Enumerator_t9473BAB568A27E2339D48C1F91319E0F6D244D7A 
{
	// System.Collections.Generic.List`1<T> System.Collections.Generic.List`1/Enumerator::_list
	List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D* ____list_0;
	// System.Int32 System.Collections.Generic.List`1/Enumerator::_index
	int32_t ____index_1;
	// System.Int32 System.Collections.Generic.List`1/Enumerator::_version
	int32_t ____version_2;
	// T System.Collections.Generic.List`1/Enumerator::_current
	RuntimeObject* ____current_3;
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

// System.Net.IPEndPoint
struct IPEndPoint_t2F09CBA7A808B67724B4E2954EEDC46D910F4ECB  : public EndPoint_t6233F4E2EB9F0F2D36E187F12BE050E6D8B73564
{
	// System.Net.IPAddress System.Net.IPEndPoint::_address
	IPAddress_t2F4486449B0D73FF2D3B36A9FE5E9C3F63116484* ____address_2;
	// System.Int32 System.Net.IPEndPoint::_port
	int32_t ____port_3;
};

struct IPEndPoint_t2F09CBA7A808B67724B4E2954EEDC46D910F4ECB_StaticFields
{
	// System.Net.IPEndPoint System.Net.IPEndPoint::Any
	IPEndPoint_t2F09CBA7A808B67724B4E2954EEDC46D910F4ECB* ___Any_5;
	// System.Net.IPEndPoint System.Net.IPEndPoint::IPv6Any
	IPEndPoint_t2F09CBA7A808B67724B4E2954EEDC46D910F4ECB* ___IPv6Any_6;
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

// System.Collections.Specialized.NameValueCollection
struct NameValueCollection_t52D1E38AB1D4ADD497A17DA305D663BB77B31DF7  : public NameObjectCollectionBase_tB6400DF2FA3B64660D79586B79016B4A0BA645FC
{
	// System.String[] System.Collections.Specialized.NameValueCollection::_all
	StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248* ____all_9;
	// System.String[] System.Collections.Specialized.NameValueCollection::_allKeys
	StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248* ____allKeys_10;
};

// Lidgren.Network.NetBlockEncryptionBase
struct NetBlockEncryptionBase_tBEAFBC5632349E060916AD6039311FBB5AFF3F13  : public NetEncryption_tEC39EE735AC6898BDF8C0249DD0B51CF5E6BDB41
{
	// System.Byte[] Lidgren.Network.NetBlockEncryptionBase::m_tmp
	ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* ___m_tmp_1;
};

// Lidgren.Network.NetRandom
struct NetRandom_t5390B683E78A49E7984152B9490E6350D1D16AFB  : public Random_t79716069EDE67D1D7734F60AE402D0CA3FB6B4C8
{
	// System.UInt32 Lidgren.Network.NetRandom::m_boolValues
	uint32_t ___m_boolValues_10;
	// System.Int32 Lidgren.Network.NetRandom::m_nextBoolIndex
	int32_t ___m_nextBoolIndex_11;
};

struct NetRandom_t5390B683E78A49E7984152B9490E6350D1D16AFB_StaticFields
{
	// Lidgren.Network.NetRandom Lidgren.Network.NetRandom::Instance
	NetRandom_t5390B683E78A49E7984152B9490E6350D1D16AFB* ___Instance_8;
};

// Lidgren.Network.NetReliableOrderedReceiver
struct NetReliableOrderedReceiver_t8AF4B8E9088E083F64FEB029207E68FD0BF5F01C  : public NetReceiverChannelBase_t56118523C994D57E27F048D445AFF933D49CCA3C
{
	// System.Int32 Lidgren.Network.NetReliableOrderedReceiver::m_windowStart
	int32_t ___m_windowStart_2;
	// System.Int32 Lidgren.Network.NetReliableOrderedReceiver::m_windowSize
	int32_t ___m_windowSize_3;
	// Lidgren.Network.NetBitVector Lidgren.Network.NetReliableOrderedReceiver::m_earlyReceived
	NetBitVector_tF8CA8B405111502BD2A21BADB51D903E2E21FF67* ___m_earlyReceived_4;
	// Lidgren.Network.NetIncomingMessage[] Lidgren.Network.NetReliableOrderedReceiver::m_withheldMessages
	NetIncomingMessageU5BU5D_tE6182F91F2C9B34755AB3E8A13305818DD434AFA* ___m_withheldMessages_5;
};

// Lidgren.Network.NetReliableSenderChannel
struct NetReliableSenderChannel_tA9749EC67EDA9FBCCB0D40CB31EB8320C89B42C2  : public NetSenderChannelBase_t60E3BDE4FA746EE6C8453DD201764C0B7D6948A2
{
	// Lidgren.Network.NetConnection Lidgren.Network.NetReliableSenderChannel::m_connection
	NetConnection_tBC8B4699CF2D1614FF259EE7E3031D8D25E31F9D* ___m_connection_1;
	// System.Int32 Lidgren.Network.NetReliableSenderChannel::m_windowStart
	int32_t ___m_windowStart_2;
	// System.Int32 Lidgren.Network.NetReliableSenderChannel::m_windowSize
	int32_t ___m_windowSize_3;
	// System.Int32 Lidgren.Network.NetReliableSenderChannel::m_sendStart
	int32_t ___m_sendStart_4;
	// System.Boolean Lidgren.Network.NetReliableSenderChannel::m_anyStoredResends
	bool ___m_anyStoredResends_5;
	// Lidgren.Network.NetBitVector Lidgren.Network.NetReliableSenderChannel::m_receivedAcks
	NetBitVector_tF8CA8B405111502BD2A21BADB51D903E2E21FF67* ___m_receivedAcks_6;
	// Lidgren.Network.NetStoredReliableMessage[] Lidgren.Network.NetReliableSenderChannel::m_storedMessages
	NetStoredReliableMessageU5BU5D_t23591445FC2D24CA762300B550255D630D65C634* ___m_storedMessages_7;
	// System.Double Lidgren.Network.NetReliableSenderChannel::m_resendDelay
	double ___m_resendDelay_8;
};

// Lidgren.Network.NetReliableSequencedReceiver
struct NetReliableSequencedReceiver_tD29A0B141AC897E64B68250EDAEA8BD32B4FE85E  : public NetReceiverChannelBase_t56118523C994D57E27F048D445AFF933D49CCA3C
{
	// System.Int32 Lidgren.Network.NetReliableSequencedReceiver::m_windowStart
	int32_t ___m_windowStart_2;
	// System.Int32 Lidgren.Network.NetReliableSequencedReceiver::m_windowSize
	int32_t ___m_windowSize_3;
};

// Lidgren.Network.NetReliableUnorderedReceiver
struct NetReliableUnorderedReceiver_t220A30799285402D92F29CB2DCF8175041C817E7  : public NetReceiverChannelBase_t56118523C994D57E27F048D445AFF933D49CCA3C
{
	// System.Int32 Lidgren.Network.NetReliableUnorderedReceiver::m_windowStart
	int32_t ___m_windowStart_2;
	// System.Int32 Lidgren.Network.NetReliableUnorderedReceiver::m_windowSize
	int32_t ___m_windowSize_3;
	// Lidgren.Network.NetBitVector Lidgren.Network.NetReliableUnorderedReceiver::m_earlyReceived
	NetBitVector_tF8CA8B405111502BD2A21BADB51D903E2E21FF67* ___m_earlyReceived_4;
};

// Lidgren.Network.NetStoredReliableMessage
struct NetStoredReliableMessage_t32B73B76F26B4659411CEBFF7647E6D567487D39 
{
	// System.Int32 Lidgren.Network.NetStoredReliableMessage::NumSent
	int32_t ___NumSent_0;
	// System.Double Lidgren.Network.NetStoredReliableMessage::LastSent
	double ___LastSent_1;
	// Lidgren.Network.NetOutgoingMessage Lidgren.Network.NetStoredReliableMessage::Message
	NetOutgoingMessage_t2C00CEEAEF52CDD51F8F991F2F8AFA314FEAAECB* ___Message_2;
	// System.Int32 Lidgren.Network.NetStoredReliableMessage::SequenceNumber
	int32_t ___SequenceNumber_3;
};
// Native definition for P/Invoke marshalling of Lidgren.Network.NetStoredReliableMessage
struct NetStoredReliableMessage_t32B73B76F26B4659411CEBFF7647E6D567487D39_marshaled_pinvoke
{
	int32_t ___NumSent_0;
	double ___LastSent_1;
	NetOutgoingMessage_t2C00CEEAEF52CDD51F8F991F2F8AFA314FEAAECB* ___Message_2;
	int32_t ___SequenceNumber_3;
};
// Native definition for COM marshalling of Lidgren.Network.NetStoredReliableMessage
struct NetStoredReliableMessage_t32B73B76F26B4659411CEBFF7647E6D567487D39_marshaled_com
{
	int32_t ___NumSent_0;
	double ___LastSent_1;
	NetOutgoingMessage_t2C00CEEAEF52CDD51F8F991F2F8AFA314FEAAECB* ___Message_2;
	int32_t ___SequenceNumber_3;
};

// Lidgren.Network.NetUnreliableSenderChannel
struct NetUnreliableSenderChannel_tA3223FD53136DB0B7FE5725D243F2513393E55B5  : public NetSenderChannelBase_t60E3BDE4FA746EE6C8453DD201764C0B7D6948A2
{
	// Lidgren.Network.NetConnection Lidgren.Network.NetUnreliableSenderChannel::m_connection
	NetConnection_tBC8B4699CF2D1614FF259EE7E3031D8D25E31F9D* ___m_connection_1;
	// System.Int32 Lidgren.Network.NetUnreliableSenderChannel::m_windowStart
	int32_t ___m_windowStart_2;
	// System.Int32 Lidgren.Network.NetUnreliableSenderChannel::m_windowSize
	int32_t ___m_windowSize_3;
	// System.Int32 Lidgren.Network.NetUnreliableSenderChannel::m_sendStart
	int32_t ___m_sendStart_4;
	// System.Boolean Lidgren.Network.NetUnreliableSenderChannel::m_doFlowControl
	bool ___m_doFlowControl_5;
	// Lidgren.Network.NetBitVector Lidgren.Network.NetUnreliableSenderChannel::m_receivedAcks
	NetBitVector_tF8CA8B405111502BD2A21BADB51D903E2E21FF67* ___m_receivedAcks_6;
};

// Lidgren.Network.NetUnreliableSequencedReceiver
struct NetUnreliableSequencedReceiver_t57B31E1EC305B1BF46565AEA3DB94CD7DCE328B7  : public NetReceiverChannelBase_t56118523C994D57E27F048D445AFF933D49CCA3C
{
	// System.Int32 Lidgren.Network.NetUnreliableSequencedReceiver::m_lastReceivedSequenceNumber
	int32_t ___m_lastReceivedSequenceNumber_2;
};

// Lidgren.Network.NetUnreliableUnorderedReceiver
struct NetUnreliableUnorderedReceiver_t0E05BC9C7DF55EA30AF87AFC80106005C57A5131  : public NetReceiverChannelBase_t56118523C994D57E27F048D445AFF933D49CCA3C
{
	// System.Boolean Lidgren.Network.NetUnreliableUnorderedReceiver::m_doFlowControl
	bool ___m_doFlowControl_2;
};

// System.Security.Cryptography.SHA256
struct SHA256_t6FEDD761EE6301127DAAF13320E8FD63296837F9  : public HashAlgorithm_t299ECE61BBF4582B1F75734D43A96DDEC9B2004D
{
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

// System.TimeSpan
struct TimeSpan_t8195C5B013A2C532FEBDF0B64B6911982E750F5A 
{
	// System.Int64 System.TimeSpan::_ticks
	int64_t ____ticks_22;
};

struct TimeSpan_t8195C5B013A2C532FEBDF0B64B6911982E750F5A_StaticFields
{
	// System.TimeSpan System.TimeSpan::Zero
	TimeSpan_t8195C5B013A2C532FEBDF0B64B6911982E750F5A ___Zero_19;
	// System.TimeSpan System.TimeSpan::MaxValue
	TimeSpan_t8195C5B013A2C532FEBDF0B64B6911982E750F5A ___MaxValue_20;
	// System.TimeSpan System.TimeSpan::MinValue
	TimeSpan_t8195C5B013A2C532FEBDF0B64B6911982E750F5A ___MinValue_21;
};

// System.UInt32
struct UInt32_t1833D51FFA667B18A5AA4B8D34DE284F8495D29B 
{
	// System.UInt32 System.UInt32::m_value
	uint32_t ___m_value_0;
};

// System.UInt64
struct UInt64_t8F12534CC8FC4B5860F2A2CD1EE79D322E7A41AF 
{
	// System.UInt64 System.UInt64::m_value
	uint64_t ___m_value_0;
};

// System.Net.NetworkInformation.UnicastIPAddressInformation
struct UnicastIPAddressInformation_t4ACCADE9FBC1F8243A602439C94301E2C30295F3  : public IPAddressInformation_t88AEE176C5711B91C890536A43B17C95690A07A7
{
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

// System.Net.WebResponse
struct WebResponse_t7CDE1F20895C8D5AD392425F9AD4BE8E8696B682  : public MarshalByRefObject_t8C2F4C5854177FD60439EB1FCCFC1B3CFAFE8DCE
{
	// System.Boolean System.Net.WebResponse::m_IsFromCache
	bool ___m_IsFromCache_1;
};

// System.Xml.XmlDocument
struct XmlDocument_t4DE82998E642C5C21A4A620A5278237C70D3E42B  : public XmlNode_t3180B9B3D5C36CD58F5327D9F13458E3B3F030AF
{
	// System.Xml.XmlImplementation System.Xml.XmlDocument::implementation
	XmlImplementation_t4B3F467B76BD95C919C40424196C55B38EEC0F4D* ___implementation_1;
	// System.Xml.DomNameTable System.Xml.XmlDocument::domNameTable
	DomNameTable_tE4318EC10C55A46FD00324E740BFA7D9CEE2AF45* ___domNameTable_2;
	// System.Xml.XmlLinkedNode System.Xml.XmlDocument::lastChild
	XmlLinkedNode_t640BF5D3FDAF0606665C3BAE565988A5014F1B9C* ___lastChild_3;
	// System.Xml.XmlNamedNodeMap System.Xml.XmlDocument::entities
	XmlNamedNodeMap_t13203D1B3861C62568AFFA1D644C04ABCBFC130C* ___entities_4;
	// System.Collections.Hashtable System.Xml.XmlDocument::htElementIdMap
	Hashtable_tEFC3B6496E6747787D8BB761B51F2AE3A8CFFE2D* ___htElementIdMap_5;
	// System.Collections.Hashtable System.Xml.XmlDocument::htElementIDAttrDecl
	Hashtable_tEFC3B6496E6747787D8BB761B51F2AE3A8CFFE2D* ___htElementIDAttrDecl_6;
	// System.Xml.Schema.SchemaInfo System.Xml.XmlDocument::schemaInfo
	SchemaInfo_t42F4B1099B63BCF2D3BBF7F35A79AF6B90B0927E* ___schemaInfo_7;
	// System.Xml.Schema.XmlSchemaSet System.Xml.XmlDocument::schemas
	XmlSchemaSet_t048A12CE7D00EF330EF32A388B69A240899F88D1* ___schemas_8;
	// System.Boolean System.Xml.XmlDocument::reportValidity
	bool ___reportValidity_9;
	// System.Boolean System.Xml.XmlDocument::actualLoadingStatus
	bool ___actualLoadingStatus_10;
	// System.Xml.XmlNodeChangedEventHandler System.Xml.XmlDocument::onNodeInsertingDelegate
	XmlNodeChangedEventHandler_t907F6E9CB8DE238635028EC468AD41CAB0BA269B* ___onNodeInsertingDelegate_11;
	// System.Xml.XmlNodeChangedEventHandler System.Xml.XmlDocument::onNodeInsertedDelegate
	XmlNodeChangedEventHandler_t907F6E9CB8DE238635028EC468AD41CAB0BA269B* ___onNodeInsertedDelegate_12;
	// System.Xml.XmlNodeChangedEventHandler System.Xml.XmlDocument::onNodeRemovingDelegate
	XmlNodeChangedEventHandler_t907F6E9CB8DE238635028EC468AD41CAB0BA269B* ___onNodeRemovingDelegate_13;
	// System.Xml.XmlNodeChangedEventHandler System.Xml.XmlDocument::onNodeRemovedDelegate
	XmlNodeChangedEventHandler_t907F6E9CB8DE238635028EC468AD41CAB0BA269B* ___onNodeRemovedDelegate_14;
	// System.Xml.XmlNodeChangedEventHandler System.Xml.XmlDocument::onNodeChangingDelegate
	XmlNodeChangedEventHandler_t907F6E9CB8DE238635028EC468AD41CAB0BA269B* ___onNodeChangingDelegate_15;
	// System.Xml.XmlNodeChangedEventHandler System.Xml.XmlDocument::onNodeChangedDelegate
	XmlNodeChangedEventHandler_t907F6E9CB8DE238635028EC468AD41CAB0BA269B* ___onNodeChangedDelegate_16;
	// System.Boolean System.Xml.XmlDocument::fEntRefNodesPresent
	bool ___fEntRefNodesPresent_17;
	// System.Boolean System.Xml.XmlDocument::fCDataNodesPresent
	bool ___fCDataNodesPresent_18;
	// System.Boolean System.Xml.XmlDocument::preserveWhitespace
	bool ___preserveWhitespace_19;
	// System.Boolean System.Xml.XmlDocument::isLoading
	bool ___isLoading_20;
	// System.String System.Xml.XmlDocument::strDocumentName
	String_t* ___strDocumentName_21;
	// System.String System.Xml.XmlDocument::strDocumentFragmentName
	String_t* ___strDocumentFragmentName_22;
	// System.String System.Xml.XmlDocument::strCommentName
	String_t* ___strCommentName_23;
	// System.String System.Xml.XmlDocument::strTextName
	String_t* ___strTextName_24;
	// System.String System.Xml.XmlDocument::strCDataSectionName
	String_t* ___strCDataSectionName_25;
	// System.String System.Xml.XmlDocument::strEntityName
	String_t* ___strEntityName_26;
	// System.String System.Xml.XmlDocument::strID
	String_t* ___strID_27;
	// System.String System.Xml.XmlDocument::strXmlns
	String_t* ___strXmlns_28;
	// System.String System.Xml.XmlDocument::strXml
	String_t* ___strXml_29;
	// System.String System.Xml.XmlDocument::strSpace
	String_t* ___strSpace_30;
	// System.String System.Xml.XmlDocument::strLang
	String_t* ___strLang_31;
	// System.String System.Xml.XmlDocument::strEmpty
	String_t* ___strEmpty_32;
	// System.String System.Xml.XmlDocument::strNonSignificantWhitespaceName
	String_t* ___strNonSignificantWhitespaceName_33;
	// System.String System.Xml.XmlDocument::strSignificantWhitespaceName
	String_t* ___strSignificantWhitespaceName_34;
	// System.String System.Xml.XmlDocument::strReservedXmlns
	String_t* ___strReservedXmlns_35;
	// System.String System.Xml.XmlDocument::strReservedXml
	String_t* ___strReservedXml_36;
	// System.String System.Xml.XmlDocument::baseURI
	String_t* ___baseURI_37;
	// System.Xml.XmlResolver System.Xml.XmlDocument::resolver
	XmlResolver_tE25A33DFCB87A939D11BC8543970F6857AEC3DCF* ___resolver_38;
	// System.Boolean System.Xml.XmlDocument::bSetResolver
	bool ___bSetResolver_39;
	// System.Object System.Xml.XmlDocument::objLock
	RuntimeObject* ___objLock_40;
	// System.Xml.XmlAttribute System.Xml.XmlDocument::namespaceXml
	XmlAttribute_t4B6CC461196FBF5CC9F777E74CC82C98E0CA9D18* ___namespaceXml_41;
};

struct XmlDocument_t4DE82998E642C5C21A4A620A5278237C70D3E42B_StaticFields
{
	// System.Xml.EmptyEnumerator System.Xml.XmlDocument::EmptyEnumerator
	EmptyEnumerator_t84EC9187C8460EE98E675ED9258AE4DF2A6776DA* ___EmptyEnumerator_42;
	// System.Xml.Schema.IXmlSchemaInfo System.Xml.XmlDocument::NotKnownSchemaInfo
	RuntimeObject* ___NotKnownSchemaInfo_43;
	// System.Xml.Schema.IXmlSchemaInfo System.Xml.XmlDocument::ValidSchemaInfo
	RuntimeObject* ___ValidSchemaInfo_44;
	// System.Xml.Schema.IXmlSchemaInfo System.Xml.XmlDocument::InvalidSchemaInfo
	RuntimeObject* ___InvalidSchemaInfo_45;
};

// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=1024
struct __StaticArrayInitTypeSizeU3D1024_t71FC17070122C916AAE400ED509F33781850B4A1 
{
	union
	{
		struct
		{
			union
			{
			};
		};
		uint8_t __StaticArrayInitTypeSizeU3D1024_t71FC17070122C916AAE400ED509F33781850B4A1__padding[1024];
	};
};

// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=11
struct __StaticArrayInitTypeSizeU3D11_t5523B79506B5C22ED2AACFFEB1167F473F371A27 
{
	union
	{
		struct
		{
			union
			{
			};
		};
		uint8_t __StaticArrayInitTypeSizeU3D11_t5523B79506B5C22ED2AACFFEB1167F473F371A27__padding[11];
	};
};

// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=16
struct __StaticArrayInitTypeSizeU3D16_t68EE8386E456CD4C7C65DA7A48BD79DB18F6A764 
{
	union
	{
		struct
		{
			union
			{
			};
		};
		uint8_t __StaticArrayInitTypeSizeU3D16_t68EE8386E456CD4C7C65DA7A48BD79DB18F6A764__padding[16];
	};
};

// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=7
struct __StaticArrayInitTypeSizeU3D7_t22CEBE1F0522D2B3063573B09483FD675D46D985 
{
	union
	{
		struct
		{
			union
			{
			};
		};
		uint8_t __StaticArrayInitTypeSizeU3D7_t22CEBE1F0522D2B3063573B09483FD675D46D985__padding[7];
	};
};

// <PrivateImplementationDetails>
struct U3CPrivateImplementationDetailsU3E_tDF76FE2002958A97429065AC028E0A0C70442121  : public RuntimeObject
{
};

struct U3CPrivateImplementationDetailsU3E_tDF76FE2002958A97429065AC028E0A0C70442121_StaticFields
{
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=16 <PrivateImplementationDetails>::37576D70DEED89FCADBBFF48862087F0E65EA38AD3FEAA0522D47AE83DFA6C9D
	__StaticArrayInitTypeSizeU3D16_t68EE8386E456CD4C7C65DA7A48BD79DB18F6A764 ___37576D70DEED89FCADBBFF48862087F0E65EA38AD3FEAA0522D47AE83DFA6C9D_0;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=1024 <PrivateImplementationDetails>::3D48051A5D8E88104EBE447E328147EBBFFA53E8B8E907878B77739AC5DC4B7D
	__StaticArrayInitTypeSizeU3D1024_t71FC17070122C916AAE400ED509F33781850B4A1 ___3D48051A5D8E88104EBE447E328147EBBFFA53E8B8E907878B77739AC5DC4B7D_1;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=7 <PrivateImplementationDetails>::4F80F8B8AA44D384A85D278983C9A494E17F4A960C329EDC914A1B3C37FBBC9D
	__StaticArrayInitTypeSizeU3D7_t22CEBE1F0522D2B3063573B09483FD675D46D985 ___4F80F8B8AA44D384A85D278983C9A494E17F4A960C329EDC914A1B3C37FBBC9D_2;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=16 <PrivateImplementationDetails>::740DE0D06F8B44A7C0F77CEE2A840F1AC0565ECBECF4B607A1B1400F267D3FDE
	__StaticArrayInitTypeSizeU3D16_t68EE8386E456CD4C7C65DA7A48BD79DB18F6A764 ___740DE0D06F8B44A7C0F77CEE2A840F1AC0565ECBECF4B607A1B1400F267D3FDE_3;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=11 <PrivateImplementationDetails>::92CF6E3817826F635A1947C58599570BAA9C38B4A8A353C41A480783A67297D1
	__StaticArrayInitTypeSizeU3D11_t5523B79506B5C22ED2AACFFEB1167F473F371A27 ___92CF6E3817826F635A1947C58599570BAA9C38B4A8A353C41A480783A67297D1_4;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=7 <PrivateImplementationDetails>::D3D8BA9697E86D2DEE2F382DE89F681306100FF9C8D79A1C1851DDE79A6B6788
	__StaticArrayInitTypeSizeU3D7_t22CEBE1F0522D2B3063573B09483FD675D46D985 ___D3D8BA9697E86D2DEE2F382DE89F681306100FF9C8D79A1C1851DDE79A6B6788_5;
};

// System.Net.Sockets.AddressFamily
struct AddressFamily_t01AA8C9FD15E4727B241F1F453D88444337C7524 
{
	// System.Int32 System.Net.Sockets.AddressFamily::value__
	int32_t ___value___2;
};

// System.Net.Security.AuthenticationLevel
struct AuthenticationLevel_tD91F6CE700057352B4F45FC290E35B9E936DECAF 
{
	// System.Int32 System.Net.Security.AuthenticationLevel::value__
	int32_t ___value___2;
};

// System.Reflection.BindingFlags
struct BindingFlags_t5DC2835E4AE9C1862B3AD172EF35B6A5F4F1812C 
{
	// System.Int32 System.Reflection.BindingFlags::value__
	int32_t ___value___2;
};

// Lidgren.Network.CryptoRandom
struct CryptoRandom_t8B21DF8737471EFF3D15D1ACB0AF83ABA4A600B8  : public NetRandom_t5390B683E78A49E7984152B9490E6350D1D16AFB
{
	// System.Security.Cryptography.RandomNumberGenerator Lidgren.Network.CryptoRandom::m_rnd
	RandomNumberGenerator_t4E862666A2F7D55324960670C7A1B4C2D40222F3* ___m_rnd_13;
};

struct CryptoRandom_t8B21DF8737471EFF3D15D1ACB0AF83ABA4A600B8_StaticFields
{
	// Lidgren.Network.CryptoRandom Lidgren.Network.CryptoRandom::Instance
	CryptoRandom_t8B21DF8737471EFF3D15D1ACB0AF83ABA4A600B8* ___Instance_12;
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

// Lidgren.Network.MWCRandom
struct MWCRandom_t2EE86D33187F701E26B088DA14D02651D83FAD76  : public NetRandom_t5390B683E78A49E7984152B9490E6350D1D16AFB
{
	// System.UInt32 Lidgren.Network.MWCRandom::m_w
	uint32_t ___m_w_13;
	// System.UInt32 Lidgren.Network.MWCRandom::m_z
	uint32_t ___m_z_14;
};

struct MWCRandom_t2EE86D33187F701E26B088DA14D02651D83FAD76_StaticFields
{
	// Lidgren.Network.MWCRandom Lidgren.Network.MWCRandom::Instance
	MWCRandom_t2EE86D33187F701E26B088DA14D02651D83FAD76* ___Instance_12;
};

// Lidgren.Network.MersenneTwisterRandom
struct MersenneTwisterRandom_tF01E9C0FB95208029F72ED8DC92F000E172E71CA  : public NetRandom_t5390B683E78A49E7984152B9490E6350D1D16AFB
{
	// System.UInt32[] Lidgren.Network.MersenneTwisterRandom::mt
	UInt32U5BU5D_t02FBD658AD156A17574ECE6106CF1FBFCC9807FA* ___mt_24;
	// System.Int32 Lidgren.Network.MersenneTwisterRandom::mti
	int32_t ___mti_25;
	// System.UInt32[] Lidgren.Network.MersenneTwisterRandom::mag01
	UInt32U5BU5D_t02FBD658AD156A17574ECE6106CF1FBFCC9807FA* ___mag01_26;
};

struct MersenneTwisterRandom_tF01E9C0FB95208029F72ED8DC92F000E172E71CA_StaticFields
{
	// Lidgren.Network.MersenneTwisterRandom Lidgren.Network.MersenneTwisterRandom::Instance
	MersenneTwisterRandom_tF01E9C0FB95208029F72ED8DC92F000E172E71CA* ___Instance_12;
};

// System.MidpointRounding
struct MidpointRounding_tD36CC4DADEF14C2D917E671961CEF65DB159DC30 
{
	// System.Int32 System.MidpointRounding::value__
	int32_t ___value___2;
};

// Lidgren.Network.NetConnectionStatus
struct NetConnectionStatus_tB86CEC5556E3629F91999EFAEA3A07C004271BDD 
{
	// System.Int32 Lidgren.Network.NetConnectionStatus::value__
	int32_t ___value___2;
};

// Lidgren.Network.NetDeliveryMethod
struct NetDeliveryMethod_tE361A191C23C2B941DE3773556E0B148CBA2437E 
{
	// System.Byte Lidgren.Network.NetDeliveryMethod::value__
	uint8_t ___value___2;
};

// Lidgren.Network.NetIncomingMessageType
struct NetIncomingMessageType_tA5B154A8D907FE4F47F00DEC7BF5D904E4E770FE 
{
	// System.Int32 Lidgren.Network.NetIncomingMessageType::value__
	int32_t ___value___2;
};

// Lidgren.Network.NetMessageType
struct NetMessageType_tDA8CEA7E4BFBD4AA8B025CA93AA634FD6EBE2503 
{
	// System.Byte Lidgren.Network.NetMessageType::value__
	uint8_t ___value___2;
};

// Lidgren.Network.NetPeerStatus
struct NetPeerStatus_tF039EC99DE5A3B8C65EC49F6C1975860D257ECDA 
{
	// System.Int32 Lidgren.Network.NetPeerStatus::value__
	int32_t ___value___2;
};

// Lidgren.Network.NetSendResult
struct NetSendResult_t72A315236814E8D6B3CECB88D787F62F7C6FD2B6 
{
	// System.Int32 Lidgren.Network.NetSendResult::value__
	int32_t ___value___2;
};

// Lidgren.Network.NetUnreliableSizeBehaviour
struct NetUnreliableSizeBehaviour_t63508F69E7BFB8386D96D4622213E1B15685C677 
{
	// System.Int32 Lidgren.Network.NetUnreliableSizeBehaviour::value__
	int32_t ___value___2;
};

// Lidgren.Network.NetXtea
struct NetXtea_t550919425A4D12A3C995681D55B1719AB2FBD2F0  : public NetBlockEncryptionBase_tBEAFBC5632349E060916AD6039311FBB5AFF3F13
{
	// System.Int32 Lidgren.Network.NetXtea::m_numRounds
	int32_t ___m_numRounds_5;
	// System.UInt32[] Lidgren.Network.NetXtea::m_sum0
	UInt32U5BU5D_t02FBD658AD156A17574ECE6106CF1FBFCC9807FA* ___m_sum0_6;
	// System.UInt32[] Lidgren.Network.NetXtea::m_sum1
	UInt32U5BU5D_t02FBD658AD156A17574ECE6106CF1FBFCC9807FA* ___m_sum1_7;
};

// System.Net.NetworkInformation.NetworkInterfaceComponent
struct NetworkInterfaceComponent_t615F1634402F47557C5E87E80993A87E44B54749 
{
	// System.Int32 System.Net.NetworkInformation.NetworkInterfaceComponent::value__
	int32_t ___value___2;
};

// System.Net.NetworkInformation.NetworkInterfaceType
struct NetworkInterfaceType_tCE82F24FD42FD5F37905C59DAC97962B0C22FE9C 
{
	// System.Int32 System.Net.NetworkInformation.NetworkInterfaceType::value__
	int32_t ___value___2;
};

// System.Net.NetworkInformation.OperationalStatus
struct OperationalStatus_tD393EFADD75A8833E43924170660096F38862E47 
{
	// System.Int32 System.Net.NetworkInformation.OperationalStatus::value__
	int32_t ___value___2;
};

// System.Net.Sockets.ProtocolType
struct ProtocolType_t104D087F8C40460E0FE8D38659949AEA910CD20A 
{
	// System.Int32 System.Net.Sockets.ProtocolType::value__
	int32_t ___value___2;
};

// System.Security.Cryptography.RNGCryptoServiceProvider
struct RNGCryptoServiceProvider_tAD9D75EFF3D2ED0929EEE27A53BE82AB83D78170  : public RandomNumberGenerator_t4E862666A2F7D55324960670C7A1B4C2D40222F3
{
	// System.IntPtr System.Security.Cryptography.RNGCryptoServiceProvider::_handle
	intptr_t ____handle_1;
};

struct RNGCryptoServiceProvider_tAD9D75EFF3D2ED0929EEE27A53BE82AB83D78170_StaticFields
{
	// System.Object System.Security.Cryptography.RNGCryptoServiceProvider::_lock
	RuntimeObject* ____lock_0;
};

// System.RuntimeTypeHandle
struct RuntimeTypeHandle_t332A452B8B6179E4469B69525D0FE82A88030F7B 
{
	// System.IntPtr System.RuntimeTypeHandle::value
	intptr_t ___value_0;
};

// System.Net.Sockets.SocketError
struct SocketError_t4AD3BECF393E3FD8C5238C4AE47B768B3ABC07B8 
{
	// System.Int32 System.Net.Sockets.SocketError::value__
	int32_t ___value___2;
};

// System.Net.Sockets.SocketOptionLevel
struct SocketOptionLevel_t2B232DDE7F90010547798E56A15F7303B6A663A7 
{
	// System.Int32 System.Net.Sockets.SocketOptionLevel::value__
	int32_t ___value___2;
};

// System.Net.Sockets.SocketOptionName
struct SocketOptionName_t064FACD89D727E52DDE3E939D14912D3057FA45B 
{
	// System.Int32 System.Net.Sockets.SocketOptionName::value__
	int32_t ___value___2;
};

// System.Net.Sockets.SocketType
struct SocketType_tEFAA48791CC7B43043CE5B1DE7A54F15DCFE3C52 
{
	// System.Int32 System.Net.Sockets.SocketType::value__
	int32_t ___value___2;
};

// System.StringComparison
struct StringComparison_tE14A55CCFA001A5AC85D754179BF2888F45CC94D 
{
	// System.Int32 System.StringComparison::value__
	int32_t ___value___2;
};

// System.Security.Principal.TokenImpersonationLevel
struct TokenImpersonationLevel_t2DEE263354E7DBC241ED96A71C632A3FAB92013D 
{
	// System.Int32 System.Security.Principal.TokenImpersonationLevel::value__
	int32_t ___value___2;
};

// Lidgren.Network.UPnPStatus
struct UPnPStatus_t5F74D8B2B1DF66B9432FCC9FB87CC35AB7E92EE4 
{
	// System.Int32 Lidgren.Network.UPnPStatus::value__
	int32_t ___value___2;
};

// System.Threading.WaitHandle
struct WaitHandle_t08F8DB54593B241FE32E0DD0BD3D82785D3AE3D8  : public MarshalByRefObject_t8C2F4C5854177FD60439EB1FCCFC1B3CFAFE8DCE
{
	// System.IntPtr System.Threading.WaitHandle::waitHandle
	intptr_t ___waitHandle_3;
	// Microsoft.Win32.SafeHandles.SafeWaitHandle modreq(System.Runtime.CompilerServices.IsVolatile) System.Threading.WaitHandle::safeWaitHandle
	SafeWaitHandle_t58F5662CD56F6462A687198A64987F8980804449* ___safeWaitHandle_4;
	// System.Boolean System.Threading.WaitHandle::hasThreadAffinity
	bool ___hasThreadAffinity_5;
};

struct WaitHandle_t08F8DB54593B241FE32E0DD0BD3D82785D3AE3D8_StaticFields
{
	// System.IntPtr System.Threading.WaitHandle::InvalidHandle
	intptr_t ___InvalidHandle_11;
};
// Native definition for P/Invoke marshalling of System.Threading.WaitHandle
struct WaitHandle_t08F8DB54593B241FE32E0DD0BD3D82785D3AE3D8_marshaled_pinvoke : public MarshalByRefObject_t8C2F4C5854177FD60439EB1FCCFC1B3CFAFE8DCE_marshaled_pinvoke
{
	intptr_t ___waitHandle_3;
	void* ___safeWaitHandle_4;
	int32_t ___hasThreadAffinity_5;
};
// Native definition for COM marshalling of System.Threading.WaitHandle
struct WaitHandle_t08F8DB54593B241FE32E0DD0BD3D82785D3AE3D8_marshaled_com : public MarshalByRefObject_t8C2F4C5854177FD60439EB1FCCFC1B3CFAFE8DCE_marshaled_com
{
	intptr_t ___waitHandle_3;
	void* ___safeWaitHandle_4;
	int32_t ___hasThreadAffinity_5;
};

// System.Net.WebHeaderCollectionType
struct WebHeaderCollectionType_tC1655E670BE2631562B873B63682846CB798A692 
{
	// System.UInt16 System.Net.WebHeaderCollectionType::value__
	uint16_t ___value___2;
};

// Lidgren.Network.XorShiftRandom
struct XorShiftRandom_t31C7255ACBCD4E96B483B540560EE527FA28B908  : public NetRandom_t5390B683E78A49E7984152B9490E6350D1D16AFB
{
	// System.UInt32 Lidgren.Network.XorShiftRandom::m_x
	uint32_t ___m_x_17;
	// System.UInt32 Lidgren.Network.XorShiftRandom::m_y
	uint32_t ___m_y_18;
	// System.UInt32 Lidgren.Network.XorShiftRandom::m_z
	uint32_t ___m_z_19;
	// System.UInt32 Lidgren.Network.XorShiftRandom::m_w
	uint32_t ___m_w_20;
};

struct XorShiftRandom_t31C7255ACBCD4E96B483B540560EE527FA28B908_StaticFields
{
	// Lidgren.Network.XorShiftRandom Lidgren.Network.XorShiftRandom::Instance
	XorShiftRandom_t31C7255ACBCD4E96B483B540560EE527FA28B908* ___Instance_12;
};

// Lidgren.Network.NetConnection/ExpandMTUStatus
struct ExpandMTUStatus_tD2CB4F729AA9A77A1B7B29BB874C3DFEBD015F96 
{
	// System.Int32 Lidgren.Network.NetConnection/ExpandMTUStatus::value__
	int32_t ___value___2;
};

// System.Threading.EventWaitHandle
struct EventWaitHandle_t18F2EB0161747B0646A9A406015A61A214A1EB7E  : public WaitHandle_t08F8DB54593B241FE32E0DD0BD3D82785D3AE3D8
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

// Lidgren.Network.NetConnection
struct NetConnection_tBC8B4699CF2D1614FF259EE7E3031D8D25E31F9D  : public RuntimeObject
{
	// Lidgren.Network.NetPeer Lidgren.Network.NetConnection::m_peer
	NetPeer_tDCD3AC5FB42BE47DEE7AEEA74F327C1E0D883542* ___m_peer_2;
	// Lidgren.Network.NetPeerConfiguration Lidgren.Network.NetConnection::m_peerConfiguration
	NetPeerConfiguration_t7BA55B2118BE6EC975E65EEE156B05E72A3339DD* ___m_peerConfiguration_3;
	// Lidgren.Network.NetConnectionStatus Lidgren.Network.NetConnection::m_status
	int32_t ___m_status_4;
	// Lidgren.Network.NetConnectionStatus Lidgren.Network.NetConnection::m_outputtedStatus
	int32_t ___m_outputtedStatus_5;
	// Lidgren.Network.NetConnectionStatus Lidgren.Network.NetConnection::m_visibleStatus
	int32_t ___m_visibleStatus_6;
	// System.Net.IPEndPoint Lidgren.Network.NetConnection::m_remoteEndPoint
	IPEndPoint_t2F09CBA7A808B67724B4E2954EEDC46D910F4ECB* ___m_remoteEndPoint_7;
	// Lidgren.Network.NetSenderChannelBase[] Lidgren.Network.NetConnection::m_sendChannels
	NetSenderChannelBaseU5BU5D_tAC45A45D8CFFEB8743D1E83FBE893091945D523D* ___m_sendChannels_8;
	// Lidgren.Network.NetReceiverChannelBase[] Lidgren.Network.NetConnection::m_receiveChannels
	NetReceiverChannelBaseU5BU5D_t15A339AD4C01B1010E09FE9AFC380A0595F8FFE0* ___m_receiveChannels_9;
	// Lidgren.Network.NetOutgoingMessage Lidgren.Network.NetConnection::m_localHailMessage
	NetOutgoingMessage_t2C00CEEAEF52CDD51F8F991F2F8AFA314FEAAECB* ___m_localHailMessage_10;
	// System.Int64 Lidgren.Network.NetConnection::m_remoteUniqueIdentifier
	int64_t ___m_remoteUniqueIdentifier_11;
	// Lidgren.Network.NetQueue`1<Lidgren.Network.NetTuple`2<Lidgren.Network.NetMessageType,System.Int32>> Lidgren.Network.NetConnection::m_queuedOutgoingAcks
	NetQueue_1_tE71A99ADAE20AA707FCA1270C3C77F428EB3EE0A* ___m_queuedOutgoingAcks_12;
	// Lidgren.Network.NetQueue`1<Lidgren.Network.NetTuple`2<Lidgren.Network.NetMessageType,System.Int32>> Lidgren.Network.NetConnection::m_queuedIncomingAcks
	NetQueue_1_tE71A99ADAE20AA707FCA1270C3C77F428EB3EE0A* ___m_queuedIncomingAcks_13;
	// System.Int32 Lidgren.Network.NetConnection::m_sendBufferWritePtr
	int32_t ___m_sendBufferWritePtr_14;
	// System.Int32 Lidgren.Network.NetConnection::m_sendBufferNumMessages
	int32_t ___m_sendBufferNumMessages_15;
	// System.Object Lidgren.Network.NetConnection::m_tag
	RuntimeObject* ___m_tag_16;
	// Lidgren.Network.NetConnectionStatistics Lidgren.Network.NetConnection::m_statistics
	NetConnectionStatistics_tF5BA1B2E0C5BAB9BF01D6D815A9F3CCCA624CBAD* ___m_statistics_17;
	// System.Boolean Lidgren.Network.NetConnection::m_connectRequested
	bool ___m_connectRequested_18;
	// System.Boolean Lidgren.Network.NetConnection::m_disconnectRequested
	bool ___m_disconnectRequested_19;
	// System.Boolean Lidgren.Network.NetConnection::m_disconnectReqSendBye
	bool ___m_disconnectReqSendBye_20;
	// System.String Lidgren.Network.NetConnection::m_disconnectMessage
	String_t* ___m_disconnectMessage_21;
	// System.Boolean Lidgren.Network.NetConnection::m_connectionInitiator
	bool ___m_connectionInitiator_22;
	// Lidgren.Network.NetIncomingMessage Lidgren.Network.NetConnection::m_remoteHailMessage
	NetIncomingMessage_t5E80A584865BF84B3148130AE0CE9A0794DD0A71* ___m_remoteHailMessage_23;
	// System.Double Lidgren.Network.NetConnection::m_lastHandshakeSendTime
	double ___m_lastHandshakeSendTime_24;
	// System.Int32 Lidgren.Network.NetConnection::m_handshakeAttempts
	int32_t ___m_handshakeAttempts_25;
	// System.Double Lidgren.Network.NetConnection::m_sentPingTime
	double ___m_sentPingTime_26;
	// System.Int32 Lidgren.Network.NetConnection::m_sentPingNumber
	int32_t ___m_sentPingNumber_27;
	// System.Double Lidgren.Network.NetConnection::m_averageRoundtripTime
	double ___m_averageRoundtripTime_28;
	// System.Double Lidgren.Network.NetConnection::m_timeoutDeadline
	double ___m_timeoutDeadline_29;
	// System.Double Lidgren.Network.NetConnection::m_remoteTimeOffset
	double ___m_remoteTimeOffset_30;
	// Lidgren.Network.NetConnection/ExpandMTUStatus Lidgren.Network.NetConnection::m_expandMTUStatus
	int32_t ___m_expandMTUStatus_32;
	// System.Int32 Lidgren.Network.NetConnection::m_largestSuccessfulMTU
	int32_t ___m_largestSuccessfulMTU_33;
	// System.Int32 Lidgren.Network.NetConnection::m_smallestFailedMTU
	int32_t ___m_smallestFailedMTU_34;
	// System.Int32 Lidgren.Network.NetConnection::m_lastSentMTUAttemptSize
	int32_t ___m_lastSentMTUAttemptSize_35;
	// System.Double Lidgren.Network.NetConnection::m_lastSentMTUAttemptTime
	double ___m_lastSentMTUAttemptTime_36;
	// System.Int32 Lidgren.Network.NetConnection::m_mtuAttemptFails
	int32_t ___m_mtuAttemptFails_37;
	// System.Int32 Lidgren.Network.NetConnection::m_currentMTU
	int32_t ___m_currentMTU_38;
};

// Lidgren.Network.NetIncomingMessage
struct NetIncomingMessage_t5E80A584865BF84B3148130AE0CE9A0794DD0A71  : public NetBuffer_t540408A0C414C4D84C990C31D9E73CC671677BDC
{
	// Lidgren.Network.NetIncomingMessageType Lidgren.Network.NetIncomingMessage::m_incomingMessageType
	int32_t ___m_incomingMessageType_9;
	// System.Net.IPEndPoint Lidgren.Network.NetIncomingMessage::m_senderEndPoint
	IPEndPoint_t2F09CBA7A808B67724B4E2954EEDC46D910F4ECB* ___m_senderEndPoint_10;
	// Lidgren.Network.NetConnection Lidgren.Network.NetIncomingMessage::m_senderConnection
	NetConnection_tBC8B4699CF2D1614FF259EE7E3031D8D25E31F9D* ___m_senderConnection_11;
	// System.Int32 Lidgren.Network.NetIncomingMessage::m_sequenceNumber
	int32_t ___m_sequenceNumber_12;
	// Lidgren.Network.NetMessageType Lidgren.Network.NetIncomingMessage::m_receivedMessageType
	uint8_t ___m_receivedMessageType_13;
	// System.Boolean Lidgren.Network.NetIncomingMessage::m_isFragment
	bool ___m_isFragment_14;
	// System.Double Lidgren.Network.NetIncomingMessage::m_receiveTime
	double ___m_receiveTime_15;
};

// Lidgren.Network.NetOutgoingMessage
struct NetOutgoingMessage_t2C00CEEAEF52CDD51F8F991F2F8AFA314FEAAECB  : public NetBuffer_t540408A0C414C4D84C990C31D9E73CC671677BDC
{
	// Lidgren.Network.NetMessageType Lidgren.Network.NetOutgoingMessage::m_messageType
	uint8_t ___m_messageType_9;
	// System.Boolean Lidgren.Network.NetOutgoingMessage::m_isSent
	bool ___m_isSent_10;
	// System.Int32 Lidgren.Network.NetOutgoingMessage::m_recyclingCount
	int32_t ___m_recyclingCount_11;
	// System.Int32 Lidgren.Network.NetOutgoingMessage::m_fragmentGroup
	int32_t ___m_fragmentGroup_12;
	// System.Int32 Lidgren.Network.NetOutgoingMessage::m_fragmentGroupTotalBits
	int32_t ___m_fragmentGroupTotalBits_13;
	// System.Int32 Lidgren.Network.NetOutgoingMessage::m_fragmentChunkByteSize
	int32_t ___m_fragmentChunkByteSize_14;
	// System.Int32 Lidgren.Network.NetOutgoingMessage::m_fragmentChunkNumber
	int32_t ___m_fragmentChunkNumber_15;
};

// Lidgren.Network.NetPeer
struct NetPeer_tDCD3AC5FB42BE47DEE7AEEA74F327C1E0D883542  : public RuntimeObject
{
	// System.Int32 Lidgren.Network.NetPeer::m_listenPort
	int32_t ___m_listenPort_3;
	// System.Object Lidgren.Network.NetPeer::m_tag
	RuntimeObject* ___m_tag_4;
	// System.Object Lidgren.Network.NetPeer::m_messageReceivedEventCreationLock
	RuntimeObject* ___m_messageReceivedEventCreationLock_5;
	// System.Collections.Generic.List`1<Lidgren.Network.NetConnection> Lidgren.Network.NetPeer::m_connections
	List_1_tCB8A580EE26829F92BEF512FF7897CF3EF16121F* ___m_connections_6;
	// System.Collections.Generic.Dictionary`2<System.Net.IPEndPoint,Lidgren.Network.NetConnection> Lidgren.Network.NetPeer::m_connectionLookup
	Dictionary_2_t3E2D78B3C0E00110EEC4A719EE470D02E9E504CA* ___m_connectionLookup_7;
	// System.String Lidgren.Network.NetPeer::m_shutdownReason
	String_t* ___m_shutdownReason_8;
	// System.Int32 Lidgren.Network.NetPeer::m_lastUsedFragmentGroup
	int32_t ___m_lastUsedFragmentGroup_9;
	// System.Collections.Generic.Dictionary`2<Lidgren.Network.NetConnection,System.Collections.Generic.Dictionary`2<System.Int32,Lidgren.Network.ReceivedFragmentGroup>> Lidgren.Network.NetPeer::m_receivedFragmentGroups
	Dictionary_2_t5E8A7D75F9D9116626AABF0EF1EA79C312B5CA35* ___m_receivedFragmentGroups_10;
	// Lidgren.Network.NetPeerStatus Lidgren.Network.NetPeer::m_status
	int32_t ___m_status_11;
	// System.Threading.Thread Lidgren.Network.NetPeer::m_networkThread
	Thread_t0A773B9DE873D2DCAA7D229EAB36757B500E207F* ___m_networkThread_12;
	// System.Net.Sockets.Socket Lidgren.Network.NetPeer::m_socket
	Socket_t1F49472CDA22B581C29A258225ABF3ADA9DED67E* ___m_socket_13;
	// System.Byte[] Lidgren.Network.NetPeer::m_sendBuffer
	ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* ___m_sendBuffer_14;
	// System.Byte[] Lidgren.Network.NetPeer::m_receiveBuffer
	ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* ___m_receiveBuffer_15;
	// Lidgren.Network.NetIncomingMessage Lidgren.Network.NetPeer::m_readHelperMessage
	NetIncomingMessage_t5E80A584865BF84B3148130AE0CE9A0794DD0A71* ___m_readHelperMessage_16;
	// System.Net.EndPoint Lidgren.Network.NetPeer::m_senderRemote
	EndPoint_t6233F4E2EB9F0F2D36E187F12BE050E6D8B73564* ___m_senderRemote_17;
	// System.Object Lidgren.Network.NetPeer::m_initializeLock
	RuntimeObject* ___m_initializeLock_18;
	// System.UInt32 Lidgren.Network.NetPeer::m_frameCounter
	uint32_t ___m_frameCounter_19;
	// System.Double Lidgren.Network.NetPeer::m_lastHeartbeat
	double ___m_lastHeartbeat_20;
	// System.Double Lidgren.Network.NetPeer::m_lastSocketBind
	double ___m_lastSocketBind_21;
	// Lidgren.Network.NetUPnP Lidgren.Network.NetPeer::m_upnp
	NetUPnP_tBDA843B6A55F8DBED04BF614EEAEDB1F256D86E8* ___m_upnp_22;
	// System.Boolean Lidgren.Network.NetPeer::m_needFlushSendQueue
	bool ___m_needFlushSendQueue_23;
	// Lidgren.Network.NetPeerConfiguration Lidgren.Network.NetPeer::m_configuration
	NetPeerConfiguration_t7BA55B2118BE6EC975E65EEE156B05E72A3339DD* ___m_configuration_24;
	// Lidgren.Network.NetQueue`1<Lidgren.Network.NetIncomingMessage> Lidgren.Network.NetPeer::m_releasedIncomingMessages
	NetQueue_1_tA448F4D600FE68F21F1D458D14F14C383E6E7A86* ___m_releasedIncomingMessages_25;
	// Lidgren.Network.NetQueue`1<Lidgren.Network.NetTuple`2<System.Net.IPEndPoint,Lidgren.Network.NetOutgoingMessage>> Lidgren.Network.NetPeer::m_unsentUnconnectedMessages
	NetQueue_1_tC9331D27AD040BE0CB3D518C96119F53610EE52F* ___m_unsentUnconnectedMessages_26;
	// System.Collections.Generic.Dictionary`2<System.Net.IPEndPoint,Lidgren.Network.NetConnection> Lidgren.Network.NetPeer::m_handshakes
	Dictionary_2_t3E2D78B3C0E00110EEC4A719EE470D02E9E504CA* ___m_handshakes_27;
	// Lidgren.Network.NetPeerStatistics Lidgren.Network.NetPeer::m_statistics
	NetPeerStatistics_t88AAAF8E56D8CB028A6D4C2E745330471A4FCD32* ___m_statistics_28;
	// System.Int64 Lidgren.Network.NetPeer::m_uniqueIdentifier
	int64_t ___m_uniqueIdentifier_29;
	// System.Boolean Lidgren.Network.NetPeer::m_executeFlushSendQueue
	bool ___m_executeFlushSendQueue_30;
	// System.Threading.AutoResetEvent Lidgren.Network.NetPeer::m_messageReceivedEvent
	AutoResetEvent_t7F792F3F7AD11BEF7B411E771D98E5266A8CE7C0* ___m_messageReceivedEvent_31;
	// System.Collections.Generic.List`1<Lidgren.Network.NetTuple`2<System.Threading.SynchronizationContext,System.Threading.SendOrPostCallback>> Lidgren.Network.NetPeer::m_receiveCallbacks
	List_1_t2BEDA54616503C14F5307C4B792488DCAD745BF6* ___m_receiveCallbacks_32;
	// System.Collections.Generic.List`1<System.Byte[]> Lidgren.Network.NetPeer::m_storagePool
	List_1_tBFF9DD9FFA06F20E74F9D7AD36610BD754D353A4* ___m_storagePool_33;
	// Lidgren.Network.NetQueue`1<Lidgren.Network.NetOutgoingMessage> Lidgren.Network.NetPeer::m_outgoingMessagesPool
	NetQueue_1_tE04A2248A2948BB1FCEAAF0A1151D27B56B71EA3* ___m_outgoingMessagesPool_34;
	// Lidgren.Network.NetQueue`1<Lidgren.Network.NetIncomingMessage> Lidgren.Network.NetPeer::m_incomingMessagesPool
	NetQueue_1_tA448F4D600FE68F21F1D458D14F14C383E6E7A86* ___m_incomingMessagesPool_35;
	// System.Int32 Lidgren.Network.NetPeer::m_storagePoolBytes
	int32_t ___m_storagePoolBytes_36;
	// System.Int32 Lidgren.Network.NetPeer::m_storageSlotsUsedCount
	int32_t ___m_storageSlotsUsedCount_37;
	// System.Int32 Lidgren.Network.NetPeer::m_maxCacheCount
	int32_t ___m_maxCacheCount_38;
};

struct NetPeer_tDCD3AC5FB42BE47DEE7AEEA74F327C1E0D883542_StaticFields
{
	// System.Int32 Lidgren.Network.NetPeer::s_initializedPeersCount
	int32_t ___s_initializedPeersCount_2;
};

// Lidgren.Network.NetPeerConfiguration
struct NetPeerConfiguration_t7BA55B2118BE6EC975E65EEE156B05E72A3339DD  : public RuntimeObject
{
	// System.Boolean Lidgren.Network.NetPeerConfiguration::m_isLocked
	bool ___m_isLocked_2;
	// System.String Lidgren.Network.NetPeerConfiguration::m_appIdentifier
	String_t* ___m_appIdentifier_3;
	// System.String Lidgren.Network.NetPeerConfiguration::m_networkThreadName
	String_t* ___m_networkThreadName_4;
	// System.Net.IPAddress Lidgren.Network.NetPeerConfiguration::m_localAddress
	IPAddress_t2F4486449B0D73FF2D3B36A9FE5E9C3F63116484* ___m_localAddress_5;
	// System.Net.IPAddress Lidgren.Network.NetPeerConfiguration::m_broadcastAddress
	IPAddress_t2F4486449B0D73FF2D3B36A9FE5E9C3F63116484* ___m_broadcastAddress_6;
	// System.Boolean Lidgren.Network.NetPeerConfiguration::m_dualStack
	bool ___m_dualStack_7;
	// System.Boolean Lidgren.Network.NetPeerConfiguration::m_acceptIncomingConnections
	bool ___m_acceptIncomingConnections_8;
	// System.Int32 Lidgren.Network.NetPeerConfiguration::m_maximumConnections
	int32_t ___m_maximumConnections_9;
	// System.Int32 Lidgren.Network.NetPeerConfiguration::m_defaultOutgoingMessageCapacity
	int32_t ___m_defaultOutgoingMessageCapacity_10;
	// System.Single Lidgren.Network.NetPeerConfiguration::m_pingInterval
	float ___m_pingInterval_11;
	// System.Boolean Lidgren.Network.NetPeerConfiguration::m_useMessageRecycling
	bool ___m_useMessageRecycling_12;
	// System.Int32 Lidgren.Network.NetPeerConfiguration::m_recycledCacheMaxCount
	int32_t ___m_recycledCacheMaxCount_13;
	// System.Single Lidgren.Network.NetPeerConfiguration::m_connectionTimeout
	float ___m_connectionTimeout_14;
	// System.Boolean Lidgren.Network.NetPeerConfiguration::m_enableUPnP
	bool ___m_enableUPnP_15;
	// System.Boolean Lidgren.Network.NetPeerConfiguration::m_autoFlushSendQueue
	bool ___m_autoFlushSendQueue_16;
	// Lidgren.Network.NetUnreliableSizeBehaviour Lidgren.Network.NetPeerConfiguration::m_unreliableSizeBehaviour
	int32_t ___m_unreliableSizeBehaviour_17;
	// System.Boolean Lidgren.Network.NetPeerConfiguration::m_suppressUnreliableUnorderedAcks
	bool ___m_suppressUnreliableUnorderedAcks_18;
	// Lidgren.Network.NetIncomingMessageType Lidgren.Network.NetPeerConfiguration::m_disabledTypes
	int32_t ___m_disabledTypes_19;
	// System.Int32 Lidgren.Network.NetPeerConfiguration::m_port
	int32_t ___m_port_20;
	// System.Int32 Lidgren.Network.NetPeerConfiguration::m_receiveBufferSize
	int32_t ___m_receiveBufferSize_21;
	// System.Int32 Lidgren.Network.NetPeerConfiguration::m_sendBufferSize
	int32_t ___m_sendBufferSize_22;
	// System.Single Lidgren.Network.NetPeerConfiguration::m_resendHandshakeInterval
	float ___m_resendHandshakeInterval_23;
	// System.Int32 Lidgren.Network.NetPeerConfiguration::m_maximumHandshakeAttempts
	int32_t ___m_maximumHandshakeAttempts_24;
	// System.Single Lidgren.Network.NetPeerConfiguration::m_loss
	float ___m_loss_25;
	// System.Single Lidgren.Network.NetPeerConfiguration::m_duplicates
	float ___m_duplicates_26;
	// System.Single Lidgren.Network.NetPeerConfiguration::m_minimumOneWayLatency
	float ___m_minimumOneWayLatency_27;
	// System.Single Lidgren.Network.NetPeerConfiguration::m_randomOneWayLatency
	float ___m_randomOneWayLatency_28;
	// System.Int32 Lidgren.Network.NetPeerConfiguration::m_maximumTransmissionUnit
	int32_t ___m_maximumTransmissionUnit_29;
	// System.Boolean Lidgren.Network.NetPeerConfiguration::m_autoExpandMTU
	bool ___m_autoExpandMTU_30;
	// System.Single Lidgren.Network.NetPeerConfiguration::m_expandMTUFrequency
	float ___m_expandMTUFrequency_31;
	// System.Int32 Lidgren.Network.NetPeerConfiguration::m_expandMTUFailAttempts
	int32_t ___m_expandMTUFailAttempts_32;
};

// Lidgren.Network.NetUPnP
struct NetUPnP_tBDA843B6A55F8DBED04BF614EEAEDB1F256D86E8  : public RuntimeObject
{
	// System.String Lidgren.Network.NetUPnP::m_serviceUrl
	String_t* ___m_serviceUrl_1;
	// System.String Lidgren.Network.NetUPnP::m_serviceName
	String_t* ___m_serviceName_2;
	// Lidgren.Network.NetPeer Lidgren.Network.NetUPnP::m_peer
	NetPeer_tDCD3AC5FB42BE47DEE7AEEA74F327C1E0D883542* ___m_peer_3;
	// System.Threading.ManualResetEvent Lidgren.Network.NetUPnP::m_discoveryComplete
	ManualResetEvent_t63959486AA41A113A4353D0BF4A68E77EBA0A158* ___m_discoveryComplete_4;
	// System.Double Lidgren.Network.NetUPnP::m_discoveryResponseDeadline
	double ___m_discoveryResponseDeadline_5;
	// Lidgren.Network.UPnPStatus Lidgren.Network.NetUPnP::m_status
	int32_t ___m_status_6;
};

// System.Net.Sockets.Socket
struct Socket_t1F49472CDA22B581C29A258225ABF3ADA9DED67E  : public RuntimeObject
{
	// System.Net.Sockets.Socket/CachedEventArgs System.Net.Sockets.Socket::_cachedTaskEventArgs
	CachedEventArgs_tF0692E89962FD1A045B17BC985F838C11FB6822C* ____cachedTaskEventArgs_6;
	// System.Boolean System.Net.Sockets.Socket::is_closed
	bool ___is_closed_17;
	// System.Boolean System.Net.Sockets.Socket::is_listening
	bool ___is_listening_18;
	// System.Boolean System.Net.Sockets.Socket::useOverlappedIO
	bool ___useOverlappedIO_19;
	// System.Int32 System.Net.Sockets.Socket::linger_timeout
	int32_t ___linger_timeout_20;
	// System.Net.Sockets.AddressFamily System.Net.Sockets.Socket::addressFamily
	int32_t ___addressFamily_21;
	// System.Net.Sockets.SocketType System.Net.Sockets.Socket::socketType
	int32_t ___socketType_22;
	// System.Net.Sockets.ProtocolType System.Net.Sockets.Socket::protocolType
	int32_t ___protocolType_23;
	// System.Net.Sockets.SafeSocketHandle System.Net.Sockets.Socket::m_Handle
	SafeSocketHandle_t5A597D30D951E736B750ED09D5B3AB72F98407EE* ___m_Handle_24;
	// System.Net.EndPoint System.Net.Sockets.Socket::seed_endpoint
	EndPoint_t6233F4E2EB9F0F2D36E187F12BE050E6D8B73564* ___seed_endpoint_25;
	// System.Threading.SemaphoreSlim System.Net.Sockets.Socket::ReadSem
	SemaphoreSlim_t0D5CB5685D9BFA5BF95CEC6E7395490F933E8DB2* ___ReadSem_26;
	// System.Threading.SemaphoreSlim System.Net.Sockets.Socket::WriteSem
	SemaphoreSlim_t0D5CB5685D9BFA5BF95CEC6E7395490F933E8DB2* ___WriteSem_27;
	// System.Boolean System.Net.Sockets.Socket::is_blocking
	bool ___is_blocking_28;
	// System.Boolean System.Net.Sockets.Socket::is_bound
	bool ___is_bound_29;
	// System.Boolean System.Net.Sockets.Socket::is_connected
	bool ___is_connected_30;
	// System.Int32 System.Net.Sockets.Socket::m_IntCleanedUp
	int32_t ___m_IntCleanedUp_31;
	// System.Boolean System.Net.Sockets.Socket::connect_in_progress
	bool ___connect_in_progress_32;
	// System.Int32 System.Net.Sockets.Socket::ID
	int32_t ___ID_33;
};

struct Socket_t1F49472CDA22B581C29A258225ABF3ADA9DED67E_StaticFields
{
	// System.EventHandler`1<System.Net.Sockets.SocketAsyncEventArgs> System.Net.Sockets.Socket::AcceptCompletedHandler
	EventHandler_1_t5D3FC4609BD8133ED1226D6D49A1D8076B16A9ED* ___AcceptCompletedHandler_0;
	// System.EventHandler`1<System.Net.Sockets.SocketAsyncEventArgs> System.Net.Sockets.Socket::ReceiveCompletedHandler
	EventHandler_1_t5D3FC4609BD8133ED1226D6D49A1D8076B16A9ED* ___ReceiveCompletedHandler_1;
	// System.EventHandler`1<System.Net.Sockets.SocketAsyncEventArgs> System.Net.Sockets.Socket::SendCompletedHandler
	EventHandler_1_t5D3FC4609BD8133ED1226D6D49A1D8076B16A9ED* ___SendCompletedHandler_2;
	// System.Net.Sockets.Socket/TaskSocketAsyncEventArgs`1<System.Net.Sockets.Socket> System.Net.Sockets.Socket::s_rentedSocketSentinel
	TaskSocketAsyncEventArgs_1_tEB937620E5B15D91E5BFEFFA707CF800930F8401* ___s_rentedSocketSentinel_3;
	// System.Net.Sockets.Socket/Int32TaskSocketAsyncEventArgs System.Net.Sockets.Socket::s_rentedInt32Sentinel
	Int32TaskSocketAsyncEventArgs_t36C5FC82499ED9DAFE7F05C38EF92D77A0B248E9* ___s_rentedInt32Sentinel_4;
	// System.Threading.Tasks.Task`1<System.Int32> System.Net.Sockets.Socket::s_zeroTask
	Task_1_t4C228DE57804012969575431CFF12D57C875552D* ___s_zeroTask_5;
	// System.Object System.Net.Sockets.Socket::s_InternalSyncObject
	RuntimeObject* ___s_InternalSyncObject_7;
	// System.Boolean modreq(System.Runtime.CompilerServices.IsVolatile) System.Net.Sockets.Socket::s_SupportsIPv4
	bool ___s_SupportsIPv4_8;
	// System.Boolean modreq(System.Runtime.CompilerServices.IsVolatile) System.Net.Sockets.Socket::s_SupportsIPv6
	bool ___s_SupportsIPv6_9;
	// System.Boolean modreq(System.Runtime.CompilerServices.IsVolatile) System.Net.Sockets.Socket::s_OSSupportsIPv6
	bool ___s_OSSupportsIPv6_10;
	// System.Boolean modreq(System.Runtime.CompilerServices.IsVolatile) System.Net.Sockets.Socket::s_Initialized
	bool ___s_Initialized_11;
	// System.Boolean modreq(System.Runtime.CompilerServices.IsVolatile) System.Net.Sockets.Socket::s_LoggingEnabled
	bool ___s_LoggingEnabled_12;
	// System.Boolean modreq(System.Runtime.CompilerServices.IsVolatile) System.Net.Sockets.Socket::s_PerfCountersEnabled
	bool ___s_PerfCountersEnabled_13;
	// System.AsyncCallback System.Net.Sockets.Socket::AcceptAsyncCallback
	AsyncCallback_t7FEF460CBDCFB9C5FA2EF776984778B9A4145F4C* ___AcceptAsyncCallback_34;
	// System.IOAsyncCallback System.Net.Sockets.Socket::BeginAcceptCallback
	IOAsyncCallback_tDBBA8BBDA6B203613680E77BD4AD6320A1268388* ___BeginAcceptCallback_35;
	// System.IOAsyncCallback System.Net.Sockets.Socket::BeginAcceptReceiveCallback
	IOAsyncCallback_tDBBA8BBDA6B203613680E77BD4AD6320A1268388* ___BeginAcceptReceiveCallback_36;
	// System.AsyncCallback System.Net.Sockets.Socket::ConnectAsyncCallback
	AsyncCallback_t7FEF460CBDCFB9C5FA2EF776984778B9A4145F4C* ___ConnectAsyncCallback_37;
	// System.IOAsyncCallback System.Net.Sockets.Socket::BeginConnectCallback
	IOAsyncCallback_tDBBA8BBDA6B203613680E77BD4AD6320A1268388* ___BeginConnectCallback_38;
	// System.AsyncCallback System.Net.Sockets.Socket::DisconnectAsyncCallback
	AsyncCallback_t7FEF460CBDCFB9C5FA2EF776984778B9A4145F4C* ___DisconnectAsyncCallback_39;
	// System.IOAsyncCallback System.Net.Sockets.Socket::BeginDisconnectCallback
	IOAsyncCallback_tDBBA8BBDA6B203613680E77BD4AD6320A1268388* ___BeginDisconnectCallback_40;
	// System.AsyncCallback System.Net.Sockets.Socket::ReceiveAsyncCallback
	AsyncCallback_t7FEF460CBDCFB9C5FA2EF776984778B9A4145F4C* ___ReceiveAsyncCallback_41;
	// System.IOAsyncCallback System.Net.Sockets.Socket::BeginReceiveCallback
	IOAsyncCallback_tDBBA8BBDA6B203613680E77BD4AD6320A1268388* ___BeginReceiveCallback_42;
	// System.IOAsyncCallback System.Net.Sockets.Socket::BeginReceiveGenericCallback
	IOAsyncCallback_tDBBA8BBDA6B203613680E77BD4AD6320A1268388* ___BeginReceiveGenericCallback_43;
	// System.AsyncCallback System.Net.Sockets.Socket::ReceiveFromAsyncCallback
	AsyncCallback_t7FEF460CBDCFB9C5FA2EF776984778B9A4145F4C* ___ReceiveFromAsyncCallback_44;
	// System.IOAsyncCallback System.Net.Sockets.Socket::BeginReceiveFromCallback
	IOAsyncCallback_tDBBA8BBDA6B203613680E77BD4AD6320A1268388* ___BeginReceiveFromCallback_45;
	// System.AsyncCallback System.Net.Sockets.Socket::SendAsyncCallback
	AsyncCallback_t7FEF460CBDCFB9C5FA2EF776984778B9A4145F4C* ___SendAsyncCallback_46;
	// System.IOAsyncCallback System.Net.Sockets.Socket::BeginSendGenericCallback
	IOAsyncCallback_tDBBA8BBDA6B203613680E77BD4AD6320A1268388* ___BeginSendGenericCallback_47;
	// System.AsyncCallback System.Net.Sockets.Socket::SendToAsyncCallback
	AsyncCallback_t7FEF460CBDCFB9C5FA2EF776984778B9A4145F4C* ___SendToAsyncCallback_48;
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

// System.Net.WebHeaderCollection
struct WebHeaderCollection_tAF1CF77FB39D8E1EB782174E30566BAF55F71AE8  : public NameValueCollection_t52D1E38AB1D4ADD497A17DA305D663BB77B31DF7
{
	// System.String[] System.Net.WebHeaderCollection::m_CommonHeaders
	StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248* ___m_CommonHeaders_12;
	// System.Int32 System.Net.WebHeaderCollection::m_NumCommonHeaders
	int32_t ___m_NumCommonHeaders_13;
	// System.Collections.Specialized.NameValueCollection System.Net.WebHeaderCollection::m_InnerCollection
	NameValueCollection_t52D1E38AB1D4ADD497A17DA305D663BB77B31DF7* ___m_InnerCollection_16;
	// System.Net.WebHeaderCollectionType System.Net.WebHeaderCollection::m_Type
	uint16_t ___m_Type_17;
};

struct WebHeaderCollection_tAF1CF77FB39D8E1EB782174E30566BAF55F71AE8_StaticFields
{
	// System.Net.HeaderInfoTable System.Net.WebHeaderCollection::HInfo
	HeaderInfoTable_tD651971044220ED52EACB30E89A49178FA32D91F* ___HInfo_11;
	// System.String[] System.Net.WebHeaderCollection::s_CommonHeaderNames
	StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248* ___s_CommonHeaderNames_14;
	// System.SByte[] System.Net.WebHeaderCollection::s_CommonHeaderHints
	SByteU5BU5D_t88116DA68378C3333DB73E7D36C1A06AFAA91913* ___s_CommonHeaderHints_15;
	// System.Char[] System.Net.WebHeaderCollection::HttpTrimCharacters
	CharU5BU5D_t799905CF001DD5F13F7DBB310181FC4D8B7D0AAB* ___HttpTrimCharacters_18;
	// System.Net.WebHeaderCollection/RfcChar[] System.Net.WebHeaderCollection::RfcCharMap
	RfcCharU5BU5D_t8D79A380C46398F9D1F442FDEE0A27F77B7D1B4C* ___RfcCharMap_19;
};

// System.Net.WebRequest
struct WebRequest_t89050438AE9A5AA9221ECAE223584127F7C1294B  : public MarshalByRefObject_t8C2F4C5854177FD60439EB1FCCFC1B3CFAFE8DCE
{
	// System.Net.Security.AuthenticationLevel System.Net.WebRequest::m_AuthenticationLevel
	int32_t ___m_AuthenticationLevel_4;
	// System.Security.Principal.TokenImpersonationLevel System.Net.WebRequest::m_ImpersonationLevel
	int32_t ___m_ImpersonationLevel_5;
	// System.Net.Cache.RequestCachePolicy System.Net.WebRequest::m_CachePolicy
	RequestCachePolicy_tF15C94C5E458478914D5EB17753294BD488B0550* ___m_CachePolicy_6;
	// System.Net.Cache.RequestCacheProtocol System.Net.WebRequest::m_CacheProtocol
	RequestCacheProtocol_t43C1AC170194874A0C0B0D3B8BE9EABFB613DF85* ___m_CacheProtocol_7;
	// System.Net.Cache.RequestCacheBinding System.Net.WebRequest::m_CacheBinding
	RequestCacheBinding_t18F3F4FF8D0F77E86C2C666CEE7FD48A80C042EE* ___m_CacheBinding_8;
};

struct WebRequest_t89050438AE9A5AA9221ECAE223584127F7C1294B_StaticFields
{
	// System.Collections.ArrayList modreq(System.Runtime.CompilerServices.IsVolatile) System.Net.WebRequest::s_PrefixList
	ArrayList_t7A8E5AF0C4378015B5731ABE2BED8F2782FEEF8A* ___s_PrefixList_1;
	// System.Object System.Net.WebRequest::s_InternalSyncObject
	RuntimeObject* ___s_InternalSyncObject_2;
	// System.Net.TimerThread/Queue System.Net.WebRequest::s_DefaultTimerQueue
	Queue_t644DC21212BC432819522EDA395EB4562BE2CC47* ___s_DefaultTimerQueue_3;
	// System.Net.WebRequest/DesignerWebRequestCreate System.Net.WebRequest::webRequestCreate
	DesignerWebRequestCreate_t75F62E4DEBF416E21EAF6FBB62E43ADB83A0753E* ___webRequestCreate_9;
	// System.Net.IWebProxy modreq(System.Runtime.CompilerServices.IsVolatile) System.Net.WebRequest::s_DefaultWebProxy
	RuntimeObject* ___s_DefaultWebProxy_10;
	// System.Boolean modreq(System.Runtime.CompilerServices.IsVolatile) System.Net.WebRequest::s_DefaultWebProxyInitialized
	bool ___s_DefaultWebProxyInitialized_11;
};

// System.ArgumentException
struct ArgumentException_tAD90411542A20A9C72D5CDA3A84181D8B947A263  : public SystemException_tCC48D868298F4C0705279823E34B00F4FBDB7295
{
	// System.String System.ArgumentException::_paramName
	String_t* ____paramName_18;
};

// System.AsyncCallback
struct AsyncCallback_t7FEF460CBDCFB9C5FA2EF776984778B9A4145F4C  : public MulticastDelegate_t
{
};

// System.Runtime.InteropServices.ExternalException
struct ExternalException_t419875A3CD3C551692EDBBC99E4927E69F2E1F4C  : public SystemException_tCC48D868298F4C0705279823E34B00F4FBDB7295
{
};

// System.Threading.ManualResetEvent
struct ManualResetEvent_t63959486AA41A113A4353D0BF4A68E77EBA0A158  : public EventWaitHandle_t18F2EB0161747B0646A9A406015A61A214A1EB7E
{
};

// Lidgren.Network.NetServer
struct NetServer_tD42376D31E46BCB7E7502576EE48D3DEFCDBD342  : public NetPeer_tDCD3AC5FB42BE47DEE7AEEA74F327C1E0D883542
{
};

// System.NotImplementedException
struct NotImplementedException_t6366FE4DCF15094C51F4833B91A2AE68D4DA90E8  : public SystemException_tCC48D868298F4C0705279823E34B00F4FBDB7295
{
};

// Lidgren.Network.NetUtility/ResolveAddressCallback
struct ResolveAddressCallback_t025BC6260F915039CDB17B31BCDE78B9ED8CC3CF  : public MulticastDelegate_t
{
};

// Lidgren.Network.NetUtility/ResolveEndPointCallback
struct ResolveEndPointCallback_t5A60EB6B6BDAEA33BFEB134C8EFED8B43385049B  : public MulticastDelegate_t
{
};

// System.ComponentModel.Win32Exception
struct Win32Exception_t15A75629914EB77C816D8219D93ED78E50C74BE9  : public ExternalException_t419875A3CD3C551692EDBBC99E4927E69F2E1F4C
{
	// System.Int32 System.ComponentModel.Win32Exception::nativeErrorCode
	int32_t ___nativeErrorCode_18;
};

// System.Net.Sockets.SocketException
struct SocketException_t6D10102A62EA871BD31748E026A372DB6804083B  : public Win32Exception_t15A75629914EB77C816D8219D93ED78E50C74BE9
{
	// System.Net.EndPoint System.Net.Sockets.SocketException::m_EndPoint
	EndPoint_t6233F4E2EB9F0F2D36E187F12BE050E6D8B73564* ___m_EndPoint_19;
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
// System.UInt32[]
struct UInt32U5BU5D_t02FBD658AD156A17574ECE6106CF1FBFCC9807FA  : public RuntimeArray
{
	ALIGN_FIELD (8) uint32_t m_Items[1];

	inline uint32_t GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline uint32_t* GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, uint32_t value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
	}
	inline uint32_t GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline uint32_t* GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, uint32_t value)
	{
		m_Items[index] = value;
	}
};
// Lidgren.Network.NetIncomingMessage[]
struct NetIncomingMessageU5BU5D_tE6182F91F2C9B34755AB3E8A13305818DD434AFA  : public RuntimeArray
{
	ALIGN_FIELD (8) NetIncomingMessage_t5E80A584865BF84B3148130AE0CE9A0794DD0A71* m_Items[1];

	inline NetIncomingMessage_t5E80A584865BF84B3148130AE0CE9A0794DD0A71* GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline NetIncomingMessage_t5E80A584865BF84B3148130AE0CE9A0794DD0A71** GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, NetIncomingMessage_t5E80A584865BF84B3148130AE0CE9A0794DD0A71* value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
	inline NetIncomingMessage_t5E80A584865BF84B3148130AE0CE9A0794DD0A71* GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline NetIncomingMessage_t5E80A584865BF84B3148130AE0CE9A0794DD0A71** GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, NetIncomingMessage_t5E80A584865BF84B3148130AE0CE9A0794DD0A71* value)
	{
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
};
// Lidgren.Network.NetStoredReliableMessage[]
struct NetStoredReliableMessageU5BU5D_t23591445FC2D24CA762300B550255D630D65C634  : public RuntimeArray
{
	ALIGN_FIELD (8) NetStoredReliableMessage_t32B73B76F26B4659411CEBFF7647E6D567487D39 m_Items[1];

	inline NetStoredReliableMessage_t32B73B76F26B4659411CEBFF7647E6D567487D39 GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline NetStoredReliableMessage_t32B73B76F26B4659411CEBFF7647E6D567487D39* GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, NetStoredReliableMessage_t32B73B76F26B4659411CEBFF7647E6D567487D39 value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)&((m_Items + index)->___Message_2), (void*)NULL);
	}
	inline NetStoredReliableMessage_t32B73B76F26B4659411CEBFF7647E6D567487D39 GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline NetStoredReliableMessage_t32B73B76F26B4659411CEBFF7647E6D567487D39* GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, NetStoredReliableMessage_t32B73B76F26B4659411CEBFF7647E6D567487D39 value)
	{
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)&((m_Items + index)->___Message_2), (void*)NULL);
	}
};
// System.Net.IPAddress[]
struct IPAddressU5BU5D_t3AEDF3B94746C9023A4549F878AA47F702C9CD0D  : public RuntimeArray
{
	ALIGN_FIELD (8) IPAddress_t2F4486449B0D73FF2D3B36A9FE5E9C3F63116484* m_Items[1];

	inline IPAddress_t2F4486449B0D73FF2D3B36A9FE5E9C3F63116484* GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline IPAddress_t2F4486449B0D73FF2D3B36A9FE5E9C3F63116484** GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, IPAddress_t2F4486449B0D73FF2D3B36A9FE5E9C3F63116484* value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
	inline IPAddress_t2F4486449B0D73FF2D3B36A9FE5E9C3F63116484* GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline IPAddress_t2F4486449B0D73FF2D3B36A9FE5E9C3F63116484** GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, IPAddress_t2F4486449B0D73FF2D3B36A9FE5E9C3F63116484* value)
	{
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
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
// System.Reflection.MemberInfo[]
struct MemberInfoU5BU5D_t4CB6970BB166E8E1CFB06152B2A2284971873053  : public RuntimeArray
{
	ALIGN_FIELD (8) MemberInfo_t* m_Items[1];

	inline MemberInfo_t* GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline MemberInfo_t** GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, MemberInfo_t* value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
	inline MemberInfo_t* GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline MemberInfo_t** GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, MemberInfo_t* value)
	{
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
};
// System.Net.NetworkInformation.NetworkInterface[]
struct NetworkInterfaceU5BU5D_t62783E27F1C4A989B118CDBBE2FCBE65EE5CA080  : public RuntimeArray
{
	ALIGN_FIELD (8) NetworkInterface_t3E7DDFADB8912D0F9D001D1195EBD0FB08B7F47A* m_Items[1];

	inline NetworkInterface_t3E7DDFADB8912D0F9D001D1195EBD0FB08B7F47A* GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline NetworkInterface_t3E7DDFADB8912D0F9D001D1195EBD0FB08B7F47A** GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, NetworkInterface_t3E7DDFADB8912D0F9D001D1195EBD0FB08B7F47A* value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
	inline NetworkInterface_t3E7DDFADB8912D0F9D001D1195EBD0FB08B7F47A* GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline NetworkInterface_t3E7DDFADB8912D0F9D001D1195EBD0FB08B7F47A** GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, NetworkInterface_t3E7DDFADB8912D0F9D001D1195EBD0FB08B7F47A* value)
	{
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
};
// System.Delegate[]
struct DelegateU5BU5D_tC5AB7E8F745616680F337909D3A8E6C722CDF771  : public RuntimeArray
{
	ALIGN_FIELD (8) Delegate_t* m_Items[1];

	inline Delegate_t* GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline Delegate_t** GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, Delegate_t* value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
	inline Delegate_t* GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline Delegate_t** GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, Delegate_t* value)
	{
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
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


// System.Void Lidgren.Network.NetQueue`1<System.Object>::.ctor(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void NetQueue_1__ctor_m6246ADFF73AF0202DABF2B626345AA2597F4BD8A_gshared (NetQueue_1_tAC0CAA8AA1377F47E01B1B5969BCBC397B5F339A* __this, int32_t ___initialCapacity0, const RuntimeMethod* method) ;
// System.Void Lidgren.Network.NetQueue`1<System.Object>::Clear()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void NetQueue_1_Clear_m9CFFD6F6033B975BB92907E4685FB82C35A2E60A_gshared (NetQueue_1_tAC0CAA8AA1377F47E01B1B5969BCBC397B5F339A* __this, const RuntimeMethod* method) ;
// System.Void Lidgren.Network.NetQueue`1<System.Object>::Enqueue(T)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void NetQueue_1_Enqueue_m40E2C0CE1FC46911E7716B70AC3BA74620F7EEB2_gshared (NetQueue_1_tAC0CAA8AA1377F47E01B1B5969BCBC397B5F339A* __this, RuntimeObject* ___item0, const RuntimeMethod* method) ;
// System.Int32 Lidgren.Network.NetQueue`1<System.Object>::get_Count()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t NetQueue_1_get_Count_m8D44A7072C243643DB4ED118AAB8AB31E5A1C6BA_gshared (NetQueue_1_tAC0CAA8AA1377F47E01B1B5969BCBC397B5F339A* __this, const RuntimeMethod* method) ;
// System.Boolean Lidgren.Network.NetQueue`1<System.Object>::TryDequeue(T&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool NetQueue_1_TryDequeue_mF6CE3C114B905266E4D0840648F00464433D1816_gshared (NetQueue_1_tAC0CAA8AA1377F47E01B1B5969BCBC397B5F339A* __this, RuntimeObject** ___item0, const RuntimeMethod* method) ;
// System.Int32 System.Collections.Generic.List`1<System.Object>::get_Count()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR int32_t List_1_get_Count_m4407E4C389F22B8CEC282C15D56516658746C383_gshared_inline (List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D* __this, const RuntimeMethod* method) ;
// System.Void System.Collections.Generic.List`1<System.Object>::.ctor(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void List_1__ctor_m76CBBC3E2F0583F5AD30CE592CEA1225C06A0428_gshared (List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D* __this, int32_t ___capacity0, const RuntimeMethod* method) ;
// System.Collections.Generic.List`1/Enumerator<T> System.Collections.Generic.List`1<System.Object>::GetEnumerator()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Enumerator_t9473BAB568A27E2339D48C1F91319E0F6D244D7A List_1_GetEnumerator_mD8294A7FA2BEB1929487127D476F8EC1CDC23BFC_gshared (List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D* __this, const RuntimeMethod* method) ;
// System.Void System.Collections.Generic.List`1/Enumerator<System.Object>::Dispose()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Enumerator_Dispose_mD9DC3E3C3697830A4823047AB29A77DBBB5ED419_gshared (Enumerator_t9473BAB568A27E2339D48C1F91319E0F6D244D7A* __this, const RuntimeMethod* method) ;
// T System.Collections.Generic.List`1/Enumerator<System.Object>::get_Current()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR RuntimeObject* Enumerator_get_Current_m6330F15D18EE4F547C05DF9BF83C5EB710376027_gshared_inline (Enumerator_t9473BAB568A27E2339D48C1F91319E0F6D244D7A* __this, const RuntimeMethod* method) ;
// System.Void System.Collections.Generic.List`1<System.Object>::Add(T)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void List_1_Add_mEBCF994CC3814631017F46A387B1A192ED6C85C7_gshared_inline (List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D* __this, RuntimeObject* ___item0, const RuntimeMethod* method) ;
// System.Boolean System.Collections.Generic.List`1/Enumerator<System.Object>::MoveNext()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Enumerator_MoveNext_mE921CC8F29FBBDE7CC3209A0ED0D921D58D00BCB_gshared (Enumerator_t9473BAB568A27E2339D48C1F91319E0F6D244D7A* __this, const RuntimeMethod* method) ;

// System.Void System.Object::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Object__ctor_mE837C6B9FA8C6D5D109F4B2EC885D79919AC0EA2 (RuntimeObject* __this, const RuntimeMethod* method) ;
// System.Void Lidgren.Network.NetPeerStatistics::Reset()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void NetPeerStatistics_Reset_m515F156801D31537B82AC239CD1ED1395C859E55 (NetPeerStatistics_t88AAAF8E56D8CB028A6D4C2E745330471A4FCD32* __this, const RuntimeMethod* method) ;
// System.Void System.Threading.Monitor::Exit(System.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Monitor_Exit_m25A154960F91391E10E4CDA245ECDF4BA94D56A9 (RuntimeObject* ___obj0, const RuntimeMethod* method) ;
// System.Void System.Threading.Monitor::Enter(System.Object,System.Boolean&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Monitor_Enter_m00506757392936AA62DBE2C5FFBEE69EE920C4D4 (RuntimeObject* ___obj0, bool* ___lockTaken1, const RuntimeMethod* method) ;
// System.Void System.Text.StringBuilder::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void StringBuilder__ctor_m1D99713357DE05DAFA296633639DB55F8C30587D (StringBuilder_t* __this, const RuntimeMethod* method) ;
// System.Int32 Lidgren.Network.NetPeer::get_ConnectionsCount()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t NetPeer_get_ConnectionsCount_mE708A4F8CA40ED8F2F1C63143A8AB4603DA7FEBB (NetPeer_tDCD3AC5FB42BE47DEE7AEEA74F327C1E0D883542* __this, const RuntimeMethod* method) ;
// System.String System.Int32::ToString()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* Int32_ToString_m030E01C24E294D6762FB0B6F37CB541581F55CA5 (int32_t* __this, const RuntimeMethod* method) ;
// System.String System.String::Concat(System.String,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* String_Concat_mAF2CE02CC0CB7460753D0A1A91CCF2B1E9804C5D (String_t* ___str00, String_t* ___str11, const RuntimeMethod* method) ;
// System.Text.StringBuilder System.Text.StringBuilder::AppendLine(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR StringBuilder_t* StringBuilder_AppendLine_mF75744CE941C63E33188E22E936B71A24D3CBF88 (StringBuilder_t* __this, String_t* ___value0, const RuntimeMethod* method) ;
// System.String System.Int64::ToString()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* Int64_ToString_m284E4E55662818E38654309A41C2B07CD436F36B (int64_t* __this, const RuntimeMethod* method) ;
// System.String System.String::Concat(System.String,System.String,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* String_Concat_m9B13B47FCB3DF61144D9647DDA05F527377251B0 (String_t* ___str00, String_t* ___str11, String_t* ___str22, const RuntimeMethod* method) ;
// System.String System.String::Concat(System.String[])
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* String_Concat_m6B0734B65813C8EA093D78E5C2D16534EB6FE8C0 (StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248* ___values0, const RuntimeMethod* method) ;
// System.Void System.Random::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Random__ctor_m151183BD4F021499A98B9DE8502DAD4B12DD16AC (Random_t79716069EDE67D1D7734F60AE402D0CA3FB6B4C8* __this, const RuntimeMethod* method) ;
// System.UInt32 Lidgren.Network.NetRandomSeed::GetUInt32()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR uint32_t NetRandomSeed_GetUInt32_m848FE5010D207F240BB352D9E5B17B287C9FB8FD (const RuntimeMethod* method) ;
// System.Void System.NotImplementedException::.ctor(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void NotImplementedException__ctor_m8339D1A685E8D77CAC9D3260C06B38B5C7CA7742 (NotImplementedException_t6366FE4DCF15094C51F4833B91A2AE68D4DA90E8* __this, String_t* ___message0, const RuntimeMethod* method) ;
// System.Int32 Lidgren.Network.NetRandom::NextInt32()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t NetRandom_NextInt32_mCFA4B17E9FE690DDAD35B2F3F8420D3ECBF7249B (NetRandom_t5390B683E78A49E7984152B9490E6350D1D16AFB* __this, const RuntimeMethod* method) ;
// System.Single Lidgren.Network.NetRandom::NextSingle()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float NetRandom_NextSingle_m21FDC122CDBEF5E696AE3ED3F0B0EFD7D9ECAD69 (NetRandom_t5390B683E78A49E7984152B9490E6350D1D16AFB* __this, const RuntimeMethod* method) ;
// System.Void Lidgren.Network.MWCRandom::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MWCRandom__ctor_m2D267C4C249ACD895CDE0B00514D84FEDD3EC108 (MWCRandom_t2EE86D33187F701E26B088DA14D02651D83FAD76* __this, const RuntimeMethod* method) ;
// System.Void Lidgren.Network.NetRandom::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void NetRandom__ctor_m371927707325556AFB04D38F4D17D48735D392D0 (NetRandom_t5390B683E78A49E7984152B9490E6350D1D16AFB* __this, const RuntimeMethod* method) ;
// System.UInt64 Lidgren.Network.NetRandomSeed::GetUInt64()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR uint64_t NetRandomSeed_GetUInt64_mE14600A3CD852496F75C3C1B96A6B1D51C0E78BB (const RuntimeMethod* method) ;
// System.Void Lidgren.Network.MWCRandom::Initialize(System.UInt64)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MWCRandom_Initialize_m4F1CE0CE76FCF8373D746586F4CF318FED1A63C3 (MWCRandom_t2EE86D33187F701E26B088DA14D02651D83FAD76* __this, uint64_t ___seed0, const RuntimeMethod* method) ;
// System.Void Lidgren.Network.XorShiftRandom::Initialize(System.UInt64)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void XorShiftRandom_Initialize_mB53E44BFE960A459C23B337B88C0C9E126CB7169 (XorShiftRandom_t31C7255ACBCD4E96B483B540560EE527FA28B908* __this, uint64_t ___seed0, const RuntimeMethod* method) ;
// System.Void Lidgren.Network.XorShiftRandom::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void XorShiftRandom__ctor_mF352EA59214000CA82A5E1ED2CC67819A6B0279E (XorShiftRandom_t31C7255ACBCD4E96B483B540560EE527FA28B908* __this, const RuntimeMethod* method) ;
// System.Void Lidgren.Network.MersenneTwisterRandom::GenRandAll()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MersenneTwisterRandom_GenRandAll_mC375DED013572C410FFF79153615ECD0C9F71EF3 (MersenneTwisterRandom_tF01E9C0FB95208029F72ED8DC92F000E172E71CA* __this, const RuntimeMethod* method) ;
// System.Void Lidgren.Network.MersenneTwisterRandom::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MersenneTwisterRandom__ctor_m6348FA455B457FF95EB7AC6F879DEE4798DF6C2F (MersenneTwisterRandom_tF01E9C0FB95208029F72ED8DC92F000E172E71CA* __this, const RuntimeMethod* method) ;
// System.Void System.Array::Copy(System.Array,System.Int32,System.Array,System.Int32,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Array_Copy_m2CC3EA1129E9B8EA82E6FA31EDE0D4F87BF67EC7 (RuntimeArray* ___sourceArray0, int32_t ___sourceIndex1, RuntimeArray* ___destinationArray2, int32_t ___destinationIndex3, int32_t ___length4, const RuntimeMethod* method) ;
// System.Void System.Security.Cryptography.RNGCryptoServiceProvider::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void RNGCryptoServiceProvider__ctor_m605146E692C0209B3FFE83F7AC94335CA089CA09 (RNGCryptoServiceProvider_tAD9D75EFF3D2ED0929EEE27A53BE82AB83D78170* __this, const RuntimeMethod* method) ;
// System.Void Lidgren.Network.CryptoRandom::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void CryptoRandom__ctor_mD1708CB734A0C0BCD157E64B5B4E969D2B439AE1 (CryptoRandom_t8B21DF8737471EFF3D15D1ACB0AF83ABA4A600B8* __this, const RuntimeMethod* method) ;
// System.Guid System.Guid::NewGuid()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Guid_t Guid_NewGuid_m1827D92D71326C3F3C263F057F6E90F907617903 (const RuntimeMethod* method) ;
// System.Byte[] System.Guid::ToByteArray()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* Guid_ToByteArray_m6EBFB2F42D3760D9143050A3A8ED03F085F3AFE9 (Guid_t* __this, const RuntimeMethod* method) ;
// System.UInt64 Lidgren.Network.NetUtility::GetPlatformSeed(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR uint64_t NetUtility_GetPlatformSeed_m20045B31AFAF8B71FD6EE27BA9B05CE46AF9C32A (int32_t ___seedInc0, const RuntimeMethod* method) ;
// System.Void Lidgren.Network.NetReceiverChannelBase::.ctor(Lidgren.Network.NetConnection)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void NetReceiverChannelBase__ctor_mA040707B5F73BB55192C0F44821F5326EC315A99 (NetReceiverChannelBase_t56118523C994D57E27F048D445AFF933D49CCA3C* __this, NetConnection_tBC8B4699CF2D1614FF259EE7E3031D8D25E31F9D* ___connection0, const RuntimeMethod* method) ;
// System.Void Lidgren.Network.NetBitVector::.ctor(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void NetBitVector__ctor_mEFF54B813F6C5472ED26A05E548B460CAB39B4A5 (NetBitVector_tF8CA8B405111502BD2A21BADB51D903E2E21FF67* __this, int32_t ___bitsCapacity0, const RuntimeMethod* method) ;
// System.Void Lidgren.Network.NetBitVector::Set(System.Int32,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void NetBitVector_Set_m7E4E2CA6DD0E5A969B25A19857A3C8F01694AF3D (NetBitVector_tF8CA8B405111502BD2A21BADB51D903E2E21FF67* __this, int32_t ___bitIndex0, bool ___value1, const RuntimeMethod* method) ;
// System.Int32 Lidgren.Network.NetUtility::RelativeSequenceNumber(System.Int32,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t NetUtility_RelativeSequenceNumber_m5DE5D4F0FE867CF19738194E727E1437A81B69B7 (int32_t ___nr0, int32_t ___expected1, const RuntimeMethod* method) ;
// System.Void Lidgren.Network.NetConnection::QueueAck(Lidgren.Network.NetMessageType,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void NetConnection_QueueAck_m6C5B3CECC443C7C33B67117795A5A0307C0EC179 (NetConnection_tBC8B4699CF2D1614FF259EE7E3031D8D25E31F9D* __this, uint8_t ___tp0, int32_t ___sequenceNumber1, const RuntimeMethod* method) ;
// System.Void Lidgren.Network.NetReliableOrderedReceiver::AdvanceWindow()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void NetReliableOrderedReceiver_AdvanceWindow_mB00756688A10F370FB50B64F9012D9A707E3CE7A (NetReliableOrderedReceiver_t8AF4B8E9088E083F64FEB029207E68FD0BF5F01C* __this, const RuntimeMethod* method) ;
// System.Void Lidgren.Network.NetPeer::ReleaseMessage(Lidgren.Network.NetIncomingMessage)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void NetPeer_ReleaseMessage_m360CE8B0C167EB96DCA5DDAE43E76E6C6AA68D2B (NetPeer_tDCD3AC5FB42BE47DEE7AEEA74F327C1E0D883542* __this, NetIncomingMessage_t5E80A584865BF84B3148130AE0CE9A0794DD0A71* ___msg0, const RuntimeMethod* method) ;
// System.Boolean Lidgren.Network.NetBitVector::get_Bit(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool NetBitVector_get_Bit_mACF2056FB118F8346E8A850CB15B69046790D448 (NetBitVector_tF8CA8B405111502BD2A21BADB51D903E2E21FF67* __this, int32_t ___index0, const RuntimeMethod* method) ;
// System.Boolean Lidgren.Network.NetSenderChannelBase::NeedToSendMessages()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool NetSenderChannelBase_NeedToSendMessages_mBB0A6D332A3FD353AFD613B32A96E481AB617260 (NetSenderChannelBase_t60E3BDE4FA746EE6C8453DD201764C0B7D6948A2* __this, const RuntimeMethod* method) ;
// System.Void Lidgren.Network.NetSenderChannelBase::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void NetSenderChannelBase__ctor_m4F33557333904C43F29ED7D4153AAE87A49F8A0C (NetSenderChannelBase_t60E3BDE4FA746EE6C8453DD201764C0B7D6948A2* __this, const RuntimeMethod* method) ;
// System.Void Lidgren.Network.NetQueue`1<Lidgren.Network.NetOutgoingMessage>::.ctor(System.Int32)
inline void NetQueue_1__ctor_m66DF6F6C6BA14E66C85046A8D415C5E75508640F (NetQueue_1_tE04A2248A2948BB1FCEAAF0A1151D27B56B71EA3* __this, int32_t ___initialCapacity0, const RuntimeMethod* method)
{
	((  void (*) (NetQueue_1_tE04A2248A2948BB1FCEAAF0A1151D27B56B71EA3*, int32_t, const RuntimeMethod*))NetQueue_1__ctor_m6246ADFF73AF0202DABF2B626345AA2597F4BD8A_gshared)(__this, ___initialCapacity0, method);
}
// System.Double Lidgren.Network.NetConnection::GetResendDelay()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR double NetConnection_GetResendDelay_mA83C6F17DEC5BAE449701C938A281F6C1CBA5A6A (NetConnection_tBC8B4699CF2D1614FF259EE7E3031D8D25E31F9D* __this, const RuntimeMethod* method) ;
// System.Void Lidgren.Network.NetBitVector::Clear()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void NetBitVector_Clear_mD555550DF31C9B77DB6DEFBFF5508256A923AE6D (NetBitVector_tF8CA8B405111502BD2A21BADB51D903E2E21FF67* __this, const RuntimeMethod* method) ;
// System.Void Lidgren.Network.NetStoredReliableMessage::Reset()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void NetStoredReliableMessage_Reset_mFFC4A5507657DEE70D8C557ED904E4E5E180721F (NetStoredReliableMessage_t32B73B76F26B4659411CEBFF7647E6D567487D39* __this, const RuntimeMethod* method) ;
// System.Void Lidgren.Network.NetQueue`1<Lidgren.Network.NetOutgoingMessage>::Clear()
inline void NetQueue_1_Clear_m2D3A4A1665A1449F169FAD863EC1025C6A471FDB (NetQueue_1_tE04A2248A2948BB1FCEAAF0A1151D27B56B71EA3* __this, const RuntimeMethod* method)
{
	((  void (*) (NetQueue_1_tE04A2248A2948BB1FCEAAF0A1151D27B56B71EA3*, const RuntimeMethod*))NetQueue_1_Clear_m9CFFD6F6033B975BB92907E4685FB82C35A2E60A_gshared)(__this, method);
}
// System.Void Lidgren.Network.NetQueue`1<Lidgren.Network.NetOutgoingMessage>::Enqueue(T)
inline void NetQueue_1_Enqueue_m29381A69FDF40552A8ABA5B1385D72E71F1EB435 (NetQueue_1_tE04A2248A2948BB1FCEAAF0A1151D27B56B71EA3* __this, NetOutgoingMessage_t2C00CEEAEF52CDD51F8F991F2F8AFA314FEAAECB* ___item0, const RuntimeMethod* method)
{
	((  void (*) (NetQueue_1_tE04A2248A2948BB1FCEAAF0A1151D27B56B71EA3*, NetOutgoingMessage_t2C00CEEAEF52CDD51F8F991F2F8AFA314FEAAECB*, const RuntimeMethod*))NetQueue_1_Enqueue_m40E2C0CE1FC46911E7716B70AC3BA74620F7EEB2_gshared)(__this, ___item0, method);
}
// System.Int32 Lidgren.Network.NetQueue`1<Lidgren.Network.NetOutgoingMessage>::get_Count()
inline int32_t NetQueue_1_get_Count_m9D0B8118A5875517A26773BBA576C2006810DE22 (NetQueue_1_tE04A2248A2948BB1FCEAAF0A1151D27B56B71EA3* __this, const RuntimeMethod* method)
{
	return ((  int32_t (*) (NetQueue_1_tE04A2248A2948BB1FCEAAF0A1151D27B56B71EA3*, const RuntimeMethod*))NetQueue_1_get_Count_m8D44A7072C243643DB4ED118AAB8AB31E5A1C6BA_gshared)(__this, method);
}
// System.Int32 System.Threading.Interlocked::Increment(System.Int32&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t Interlocked_Increment_m7AC68EC482A6AFD97BCEFABA0FD45D203F3EA2E1 (int32_t* ___location0, const RuntimeMethod* method) ;
// System.Void Lidgren.Network.NetConnection::QueueSendMessage(Lidgren.Network.NetOutgoingMessage,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void NetConnection_QueueSendMessage_mCD87B7FD21EE3A2B3FF0D786ACDF6CBB4441721D (NetConnection_tBC8B4699CF2D1614FF259EE7E3031D8D25E31F9D* __this, NetOutgoingMessage_t2C00CEEAEF52CDD51F8F991F2F8AFA314FEAAECB* ___om0, int32_t ___seqNr1, const RuntimeMethod* method) ;
// System.Boolean Lidgren.Network.NetQueue`1<Lidgren.Network.NetOutgoingMessage>::TryDequeue(T&)
inline bool NetQueue_1_TryDequeue_m64BE224E287C91F5A80BC1F74C4777A5BD3BB97C (NetQueue_1_tE04A2248A2948BB1FCEAAF0A1151D27B56B71EA3* __this, NetOutgoingMessage_t2C00CEEAEF52CDD51F8F991F2F8AFA314FEAAECB** ___item0, const RuntimeMethod* method)
{
	return ((  bool (*) (NetQueue_1_tE04A2248A2948BB1FCEAAF0A1151D27B56B71EA3*, NetOutgoingMessage_t2C00CEEAEF52CDD51F8F991F2F8AFA314FEAAECB**, const RuntimeMethod*))NetQueue_1_TryDequeue_mF6CE3C114B905266E4D0840648F00464433D1816_gshared)(__this, ___item0, method);
}
// System.Void Lidgren.Network.NetReliableSenderChannel::ExecuteSend(System.Double,Lidgren.Network.NetOutgoingMessage)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void NetReliableSenderChannel_ExecuteSend_m1FCF1B56538D6FF986D39D2A3859399157FADEFE (NetReliableSenderChannel_tA9749EC67EDA9FBCCB0D40CB31EB8320C89B42C2* __this, double ___now0, NetOutgoingMessage_t2C00CEEAEF52CDD51F8F991F2F8AFA314FEAAECB* ___message1, const RuntimeMethod* method) ;
// System.Int32 System.Threading.Interlocked::Decrement(System.Int32&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t Interlocked_Decrement_mFACC375A9985A7E1A3473EECE768B1D2ECB8CEF5 (int32_t* ___location0, const RuntimeMethod* method) ;
// System.Void Lidgren.Network.NetPeer::Recycle(Lidgren.Network.NetOutgoingMessage)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void NetPeer_Recycle_m19CD3E9FAB66822D78395ABD6E23DA7F58AA178E (NetPeer_tDCD3AC5FB42BE47DEE7AEEA74F327C1E0D883542* __this, NetOutgoingMessage_t2C00CEEAEF52CDD51F8F991F2F8AFA314FEAAECB* ___msg0, const RuntimeMethod* method) ;
// System.Void Lidgren.Network.NetBitVector::set_Bit(System.Int32,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void NetBitVector_set_Bit_m2A0E5C3CBF8B711C61AF9622627398B814229BE2 (NetBitVector_tF8CA8B405111502BD2A21BADB51D903E2E21FF67* __this, int32_t ___index0, bool ___value1, const RuntimeMethod* method) ;
// System.Void Lidgren.Network.NetReliableSenderChannel::DestoreMessage(System.Double,System.Int32,System.Boolean&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void NetReliableSenderChannel_DestoreMessage_m6AEDD6C66F1B24CED8336A347C4EEF137323E86D (NetReliableSenderChannel_tA9749EC67EDA9FBCCB0D40CB31EB8320C89B42C2* __this, double ___now0, int32_t ___storeIndex1, bool* ___resetTimeout2, const RuntimeMethod* method) ;
// System.Boolean Lidgren.Network.NetBitVector::Get(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool NetBitVector_Get_mE0B3D426B63909C7F2989889D270AE4C5C3DEF55 (NetBitVector_tF8CA8B405111502BD2A21BADB51D903E2E21FF67* __this, int32_t ___bitIndex0, const RuntimeMethod* method) ;
// System.Void Lidgren.Network.NetConnection::ResetTimeout(System.Double)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void NetConnection_ResetTimeout_m7A64A58F3856CA5F0744D6854FD6B683D30EC25B (NetConnection_tBC8B4699CF2D1614FF259EE7E3031D8D25E31F9D* __this, double ___now0, const RuntimeMethod* method) ;
// System.Void Lidgren.Network.NetReliableSequencedReceiver::AdvanceWindow()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void NetReliableSequencedReceiver_AdvanceWindow_mBC1EA76BE668A8DAE0C7761DF9044A3EA948210B (NetReliableSequencedReceiver_tD29A0B141AC897E64B68250EDAEA8BD32B4FE85E* __this, const RuntimeMethod* method) ;
// System.Void Lidgren.Network.NetReliableUnorderedReceiver::AdvanceWindow()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void NetReliableUnorderedReceiver_AdvanceWindow_m9F2579C32D72AC9063A848C7E609D7CF14BA46F0 (NetReliableUnorderedReceiver_t220A30799285402D92F29CB2DCF8175041C817E7* __this, const RuntimeMethod* method) ;
// System.Void Lidgren.Network.NetPeer::.ctor(Lidgren.Network.NetPeerConfiguration)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void NetPeer__ctor_mA664869D02F67AF07AC4C4FA561FE198BCB7D49E (NetPeer_tDCD3AC5FB42BE47DEE7AEEA74F327C1E0D883542* __this, NetPeerConfiguration_t7BA55B2118BE6EC975E65EEE156B05E72A3339DD* ___config0, const RuntimeMethod* method) ;
// System.Void Lidgren.Network.NetPeerConfiguration::set_AcceptIncomingConnections(System.Boolean)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void NetPeerConfiguration_set_AcceptIncomingConnections_mEB37F905BF5640D0CD9241ABC0302F90AA43D372_inline (NetPeerConfiguration_t7BA55B2118BE6EC975E65EEE156B05E72A3339DD* __this, bool ___value0, const RuntimeMethod* method) ;
// System.Int32 System.Collections.Generic.List`1<Lidgren.Network.NetConnection>::get_Count()
inline int32_t List_1_get_Count_m2718A4E7883478B0124E79583E511312C71D8CC8_inline (List_1_tCB8A580EE26829F92BEF512FF7897CF3EF16121F* __this, const RuntimeMethod* method)
{
	return ((  int32_t (*) (List_1_tCB8A580EE26829F92BEF512FF7897CF3EF16121F*, const RuntimeMethod*))List_1_get_Count_m4407E4C389F22B8CEC282C15D56516658746C383_gshared_inline)(__this, method);
}
// System.Void Lidgren.Network.NetPeer::SendMessage(Lidgren.Network.NetOutgoingMessage,System.Collections.Generic.IList`1<Lidgren.Network.NetConnection>,Lidgren.Network.NetDeliveryMethod,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void NetPeer_SendMessage_mB9DAB98AA72E4B244D58DA334AD4939B36E4AFC2 (NetPeer_tDCD3AC5FB42BE47DEE7AEEA74F327C1E0D883542* __this, NetOutgoingMessage_t2C00CEEAEF52CDD51F8F991F2F8AFA314FEAAECB* ___msg0, RuntimeObject* ___recipients1, uint8_t ___method2, int32_t ___sequenceChannel3, const RuntimeMethod* method) ;
// System.Void System.Collections.Generic.List`1<Lidgren.Network.NetConnection>::.ctor(System.Int32)
inline void List_1__ctor_mD729DF400FADFA39FCECE0669139C521DD2D110C (List_1_tCB8A580EE26829F92BEF512FF7897CF3EF16121F* __this, int32_t ___capacity0, const RuntimeMethod* method)
{
	((  void (*) (List_1_tCB8A580EE26829F92BEF512FF7897CF3EF16121F*, int32_t, const RuntimeMethod*))List_1__ctor_m76CBBC3E2F0583F5AD30CE592CEA1225C06A0428_gshared)(__this, ___capacity0, method);
}
// System.Collections.Generic.List`1/Enumerator<T> System.Collections.Generic.List`1<Lidgren.Network.NetConnection>::GetEnumerator()
inline Enumerator_t544F92AE49BEB4DE05D485E77C4AB2E71862B6A4 List_1_GetEnumerator_mA1703FADFF65E89C664E1AC2C224E137EDCE0FAA (List_1_tCB8A580EE26829F92BEF512FF7897CF3EF16121F* __this, const RuntimeMethod* method)
{
	return ((  Enumerator_t544F92AE49BEB4DE05D485E77C4AB2E71862B6A4 (*) (List_1_tCB8A580EE26829F92BEF512FF7897CF3EF16121F*, const RuntimeMethod*))List_1_GetEnumerator_mD8294A7FA2BEB1929487127D476F8EC1CDC23BFC_gshared)(__this, method);
}
// System.Void System.Collections.Generic.List`1/Enumerator<Lidgren.Network.NetConnection>::Dispose()
inline void Enumerator_Dispose_m07181BB10C1BA5DC601AE525BD8135BC4EB56FBD (Enumerator_t544F92AE49BEB4DE05D485E77C4AB2E71862B6A4* __this, const RuntimeMethod* method)
{
	((  void (*) (Enumerator_t544F92AE49BEB4DE05D485E77C4AB2E71862B6A4*, const RuntimeMethod*))Enumerator_Dispose_mD9DC3E3C3697830A4823047AB29A77DBBB5ED419_gshared)(__this, method);
}
// T System.Collections.Generic.List`1/Enumerator<Lidgren.Network.NetConnection>::get_Current()
inline NetConnection_tBC8B4699CF2D1614FF259EE7E3031D8D25E31F9D* Enumerator_get_Current_m6E66C77AF2421CC882C1A0DD5B0BFF34A4BE4214_inline (Enumerator_t544F92AE49BEB4DE05D485E77C4AB2E71862B6A4* __this, const RuntimeMethod* method)
{
	return ((  NetConnection_tBC8B4699CF2D1614FF259EE7E3031D8D25E31F9D* (*) (Enumerator_t544F92AE49BEB4DE05D485E77C4AB2E71862B6A4*, const RuntimeMethod*))Enumerator_get_Current_m6330F15D18EE4F547C05DF9BF83C5EB710376027_gshared_inline)(__this, method);
}
// System.Void System.Collections.Generic.List`1<Lidgren.Network.NetConnection>::Add(T)
inline void List_1_Add_m8CE33AF029F57595E3FF186EE02E159E0EBB6DE3_inline (List_1_tCB8A580EE26829F92BEF512FF7897CF3EF16121F* __this, NetConnection_tBC8B4699CF2D1614FF259EE7E3031D8D25E31F9D* ___item0, const RuntimeMethod* method)
{
	((  void (*) (List_1_tCB8A580EE26829F92BEF512FF7897CF3EF16121F*, NetConnection_tBC8B4699CF2D1614FF259EE7E3031D8D25E31F9D*, const RuntimeMethod*))List_1_Add_mEBCF994CC3814631017F46A387B1A192ED6C85C7_gshared_inline)(__this, ___item0, method);
}
// System.Boolean System.Collections.Generic.List`1/Enumerator<Lidgren.Network.NetConnection>::MoveNext()
inline bool Enumerator_MoveNext_m85D3F022A9B8C14AF8EAECDBC6AD2758243E2267 (Enumerator_t544F92AE49BEB4DE05D485E77C4AB2E71862B6A4* __this, const RuntimeMethod* method)
{
	return ((  bool (*) (Enumerator_t544F92AE49BEB4DE05D485E77C4AB2E71862B6A4*, const RuntimeMethod*))Enumerator_MoveNext_mE921CC8F29FBBDE7CC3209A0ED0D921D58D00BCB_gshared)(__this, method);
}
// System.Byte[] Lidgren.Network.NetBigInteger::ToByteArrayUnsigned()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* NetBigInteger_ToByteArrayUnsigned_m3A7A392C37CD2D701E96AFEF4193B21E451808FD (NetBigInteger_t06C831F115CE5B02A3EB70F99F2C5ABA75E0FF76* __this, const RuntimeMethod* method) ;
// System.String Lidgren.Network.NetUtility::ToHexString(System.Byte[])
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* NetUtility_ToHexString_m54E357477D8D0AD283B929917378B10D8E1F380B (ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* ___data0, const RuntimeMethod* method) ;
// System.Int32 System.String::get_Length()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR int32_t String_get_Length_m42625D67623FA5CC7A44D47425CE86FB946542D2_inline (String_t* __this, const RuntimeMethod* method) ;
// System.String System.String::PadLeft(System.Int32,System.Char)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* String_PadLeft_m99DDD242908E78B71E9631EE66331E8A130EB31F (String_t* __this, int32_t ___totalWidth0, Il2CppChar ___paddingChar1, const RuntimeMethod* method) ;
// System.Byte[] Lidgren.Network.NetUtility::ToByteArray(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* NetUtility_ToByteArray_mF9C5C8DB9AB7C82FCE421683EE0FFAFF51510EA8 (String_t* ___hexString0, const RuntimeMethod* method) ;
// System.Byte[] Lidgren.Network.NetUtility::ComputeSHAHash(System.Byte[])
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* NetUtility_ComputeSHAHash_mF0A369753E62EEE4E771C5638C1CB620D0CA48AD (ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* ___bytes0, const RuntimeMethod* method) ;
// System.Void Lidgren.Network.NetBigInteger::.ctor(System.String,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void NetBigInteger__ctor_m4031CDB3BDCE25C1A09226CE4C36004FAC46ED25 (NetBigInteger_t06C831F115CE5B02A3EB70F99F2C5ABA75E0FF76* __this, String_t* ___str0, int32_t ___radix1, const RuntimeMethod* method) ;
// System.Text.Encoding System.Text.Encoding::get_UTF8()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Encoding_t65CDEF28CF20A7B8C92E85A4E808920C2465F095* Encoding_get_UTF8_m9700ADA8E0F244002B2A89B483F1B2133B8FE336 (const RuntimeMethod* method) ;
// System.Void System.Buffer::BlockCopy(System.Array,System.Int32,System.Array,System.Int32,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Buffer_BlockCopy_mD8CF7EC96ADA7A542CCA3F3C73510624E10197A9 (RuntimeArray* ___src0, int32_t ___srcOffset1, RuntimeArray* ___dst2, int32_t ___dstOffset3, int32_t ___count4, const RuntimeMethod* method) ;
// Lidgren.Network.NetBigInteger Lidgren.Network.NetBigInteger::ModPow(Lidgren.Network.NetBigInteger,Lidgren.Network.NetBigInteger)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR NetBigInteger_t06C831F115CE5B02A3EB70F99F2C5ABA75E0FF76* NetBigInteger_ModPow_mA8056171CB7863175623991760489B0DCA3EA6B1 (NetBigInteger_t06C831F115CE5B02A3EB70F99F2C5ABA75E0FF76* __this, NetBigInteger_t06C831F115CE5B02A3EB70F99F2C5ABA75E0FF76* ___exponent0, NetBigInteger_t06C831F115CE5B02A3EB70F99F2C5ABA75E0FF76* ___m1, const RuntimeMethod* method) ;
// Lidgren.Network.NetBigInteger Lidgren.Network.NetBigInteger::Multiply(Lidgren.Network.NetBigInteger)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR NetBigInteger_t06C831F115CE5B02A3EB70F99F2C5ABA75E0FF76* NetBigInteger_Multiply_m2BA38A3FB4A6A96C6A12EFAAA84593FB6F42B268 (NetBigInteger_t06C831F115CE5B02A3EB70F99F2C5ABA75E0FF76* __this, NetBigInteger_t06C831F115CE5B02A3EB70F99F2C5ABA75E0FF76* ___val0, const RuntimeMethod* method) ;
// Lidgren.Network.NetBigInteger Lidgren.Network.NetBigInteger::Add(Lidgren.Network.NetBigInteger)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR NetBigInteger_t06C831F115CE5B02A3EB70F99F2C5ABA75E0FF76* NetBigInteger_Add_mD8A74E340DA99C2FC5BB092B79A0001366C9F0FD (NetBigInteger_t06C831F115CE5B02A3EB70F99F2C5ABA75E0FF76* __this, NetBigInteger_t06C831F115CE5B02A3EB70F99F2C5ABA75E0FF76* ___value0, const RuntimeMethod* method) ;
// Lidgren.Network.NetBigInteger Lidgren.Network.NetBigInteger::Mod(Lidgren.Network.NetBigInteger)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR NetBigInteger_t06C831F115CE5B02A3EB70F99F2C5ABA75E0FF76* NetBigInteger_Mod_mA45EB5A08C840CB9206BAB63A3A470EB39629FAD (NetBigInteger_t06C831F115CE5B02A3EB70F99F2C5ABA75E0FF76* __this, NetBigInteger_t06C831F115CE5B02A3EB70F99F2C5ABA75E0FF76* ___m0, const RuntimeMethod* method) ;
// Lidgren.Network.NetBigInteger Lidgren.Network.NetBigInteger::Subtract(Lidgren.Network.NetBigInteger)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR NetBigInteger_t06C831F115CE5B02A3EB70F99F2C5ABA75E0FF76* NetBigInteger_Subtract_mA2A505CE315C790B52023E216E5D358628F88F8E (NetBigInteger_t06C831F115CE5B02A3EB70F99F2C5ABA75E0FF76* __this, NetBigInteger_t06C831F115CE5B02A3EB70F99F2C5ABA75E0FF76* ___n0, const RuntimeMethod* method) ;
// System.Void Lidgren.Network.NetXtea::.ctor(Lidgren.Network.NetPeer,System.Byte[])
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void NetXtea__ctor_mE66A210E14B876E2260B8FB6152B6EE4F8B89B7D (NetXtea_t550919425A4D12A3C995681D55B1719AB2FBD2F0* __this, NetPeer_tDCD3AC5FB42BE47DEE7AEEA74F327C1E0D883542* ___peer0, ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* ___key1, const RuntimeMethod* method) ;
// Lidgren.Network.NetBigInteger Lidgren.Network.NetSRP::ComputeMultiplier()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR NetBigInteger_t06C831F115CE5B02A3EB70F99F2C5ABA75E0FF76* NetSRP_ComputeMultiplier_m755DBE4F28AFCA07BBACBF9A500F550A70CB596C (const RuntimeMethod* method) ;
// System.TimeSpan System.TimeSpan::FromSeconds(System.Double)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR TimeSpan_t8195C5B013A2C532FEBDF0B64B6911982E750F5A TimeSpan_FromSeconds_mE585CC8180040ED064DC8B6546E6C94A129BFFC5 (double ___value0, const RuntimeMethod* method) ;
// System.String System.TimeSpan::ToString()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* TimeSpan_ToString_m44D5BF48E35E18BB8B99A86B6535DA5E847FFE92 (TimeSpan_t8195C5B013A2C532FEBDF0B64B6911982E750F5A* __this, const RuntimeMethod* method) ;
// System.String System.Double::ToString(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* Double_ToString_m70EC76E1DAD7E8B5B47AF9292189BF3711B24B75 (double* __this, String_t* ___format0, const RuntimeMethod* method) ;
// System.Int64 System.Diagnostics.Stopwatch::GetTimestamp()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int64_t Stopwatch_GetTimestamp_mD6D582A3E30369F05C829A5650BE2AE511EC807F (const RuntimeMethod* method) ;
// Lidgren.Network.NetPeer Lidgren.Network.NetConnection::get_Peer()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR NetPeer_tDCD3AC5FB42BE47DEE7AEEA74F327C1E0D883542* NetConnection_get_Peer_mD4190401C6B4D50DBDF739F47D1DD494AF7CC04F_inline (NetConnection_tBC8B4699CF2D1614FF259EE7E3031D8D25E31F9D* __this, const RuntimeMethod* method) ;
// Lidgren.Network.NetPeerConfiguration Lidgren.Network.NetPeer::get_Configuration()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR NetPeerConfiguration_t7BA55B2118BE6EC975E65EEE156B05E72A3339DD* NetPeer_get_Configuration_m45ADD4611BB6484ADBAEF24A81768E19AEB77F7B_inline (NetPeer_tDCD3AC5FB42BE47DEE7AEEA74F327C1E0D883542* __this, const RuntimeMethod* method) ;
// System.Boolean Lidgren.Network.NetPeerConfiguration::get_SuppressUnreliableUnorderedAcks()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR bool NetPeerConfiguration_get_SuppressUnreliableUnorderedAcks_m9E8972CF4FF6CB86C992334F40DC8E922042301A_inline (NetPeerConfiguration_t7BA55B2118BE6EC975E65EEE156B05E72A3339DD* __this, const RuntimeMethod* method) ;
// System.Int32 Lidgren.Network.NetBuffer::get_LengthBytes()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t NetBuffer_get_LengthBytes_mB7834EFF0C64E788397B77CAB3F51AF07A5DF3A5 (NetBuffer_t540408A0C414C4D84C990C31D9E73CC671677BDC* __this, const RuntimeMethod* method) ;
// Lidgren.Network.NetUnreliableSizeBehaviour Lidgren.Network.NetPeerConfiguration::get_UnreliableSizeBehaviour()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR int32_t NetPeerConfiguration_get_UnreliableSizeBehaviour_m8C1D20EBDDEEF517EC403FB17911127A29B961D4_inline (NetPeerConfiguration_t7BA55B2118BE6EC975E65EEE156B05E72A3339DD* __this, const RuntimeMethod* method) ;
// System.Void Lidgren.Network.NetUnreliableSenderChannel::ExecuteSend(Lidgren.Network.NetOutgoingMessage)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void NetUnreliableSenderChannel_ExecuteSend_mCDDF357AB62D89803232EAA96761008A2E009A78 (NetUnreliableSenderChannel_tA3223FD53136DB0B7FE5725D243F2513393E55B5* __this, NetOutgoingMessage_t2C00CEEAEF52CDD51F8F991F2F8AFA314FEAAECB* ___message0, const RuntimeMethod* method) ;
// System.Void Lidgren.Network.NetPeer::LogWarning(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void NetPeer_LogWarning_m2192971F3DF4443EDFCB1A4199897520163F227C (NetPeer_tDCD3AC5FB42BE47DEE7AEEA74F327C1E0D883542* __this, String_t* ___message0, const RuntimeMethod* method) ;
// System.Void System.Threading.ManualResetEvent::.ctor(System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ManualResetEvent__ctor_m361CFCF6AC28BFFF5C8790DC2B5951791A1C4CEE (ManualResetEvent_t63959486AA41A113A4353D0BF4A68E77EBA0A158* __this, bool ___initialState0, const RuntimeMethod* method) ;
// System.Double Lidgren.Network.NetTime::get_Now()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR double NetTime_get_Now_mDDB364AF74A766A60E95E4799647B7EDD823EA96 (const RuntimeMethod* method) ;
// System.Net.Sockets.Socket Lidgren.Network.NetPeer::get_Socket()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Socket_t1F49472CDA22B581C29A258225ABF3ADA9DED67E* NetPeer_get_Socket_mCC49D19E418EEF9BCB8843C3475592AA8B6A2CC8_inline (NetPeer_tDCD3AC5FB42BE47DEE7AEEA74F327C1E0D883542* __this, const RuntimeMethod* method) ;
// System.Void System.Net.Sockets.Socket::SetSocketOption(System.Net.Sockets.SocketOptionLevel,System.Net.Sockets.SocketOptionName,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Socket_SetSocketOption_mE47F5DEEA190E45317AEEE6F1506940CB8E943A1 (Socket_t1F49472CDA22B581C29A258225ABF3ADA9DED67E* __this, int32_t ___optionLevel0, int32_t ___optionName1, bool ___optionValue2, const RuntimeMethod* method) ;
// System.Net.IPAddress Lidgren.Network.NetUtility::GetBroadcastAddress()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR IPAddress_t2F4486449B0D73FF2D3B36A9FE5E9C3F63116484* NetUtility_GetBroadcastAddress_m69CC4AFCA51DE14371F00A5A25170739B1496935 (const RuntimeMethod* method) ;
// System.Void System.Net.IPEndPoint::.ctor(System.Net.IPAddress,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void IPEndPoint__ctor_m902C98F9E3F36B20B3C2E030AA91B62E2BC7A85A (IPEndPoint_t2F09CBA7A808B67724B4E2954EEDC46D910F4ECB* __this, IPAddress_t2F4486449B0D73FF2D3B36A9FE5E9C3F63116484* ___address0, int32_t ___port1, const RuntimeMethod* method) ;
// System.Void Lidgren.Network.NetPeer::RawSend(System.Byte[],System.Int32,System.Int32,System.Net.IPEndPoint)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void NetPeer_RawSend_mA47AFF8080A02D800CD75A6F6A85296A28225291 (NetPeer_tDCD3AC5FB42BE47DEE7AEEA74F327C1E0D883542* __this, ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* ___arr0, int32_t ___offset1, int32_t ___length2, IPEndPoint_t2F09CBA7A808B67724B4E2954EEDC46D910F4ECB* ___destination3, const RuntimeMethod* method) ;
// System.Void System.Xml.XmlDocument::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void XmlDocument__ctor_m09B578D51E249702C90A99B87A31ABE8CE4027DC (XmlDocument_t4DE82998E642C5C21A4A620A5278237C70D3E42B* __this, const RuntimeMethod* method) ;
// System.Net.WebRequest System.Net.WebRequest::Create(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR WebRequest_t89050438AE9A5AA9221ECAE223584127F7C1294B* WebRequest_Create_m18D598C169B53797E9B26A710442CAF2D786B04A (String_t* ___requestUriString0, const RuntimeMethod* method) ;
// System.Xml.XmlNameTable System.Xml.XmlDocument::get_NameTable()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR XmlNameTable_tBDBAACFF3DB40A8E6AF3BDC11F0FF166CF11ABB8* XmlDocument_get_NameTable_m4B913865A24AEA917172F75CBDCE94C81CCB7E2C (XmlDocument_t4DE82998E642C5C21A4A620A5278237C70D3E42B* __this, const RuntimeMethod* method) ;
// System.Void System.Xml.XmlNamespaceManager::.ctor(System.Xml.XmlNameTable)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void XmlNamespaceManager__ctor_m18E69120CE5886E06630CCCC3215D2C67FC669DB (XmlNamespaceManager_t95431ADE7A94108629DFF894819FB1A9709D810F* __this, XmlNameTable_tBDBAACFF3DB40A8E6AF3BDC11F0FF166CF11ABB8* ___nameTable0, const RuntimeMethod* method) ;
// System.Xml.XmlNode System.Xml.XmlNode::SelectSingleNode(System.String,System.Xml.XmlNamespaceManager)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR XmlNode_t3180B9B3D5C36CD58F5327D9F13458E3B3F030AF* XmlNode_SelectSingleNode_m39CC82217D76D54E61239FE67EF12020DD6E4748 (XmlNode_t3180B9B3D5C36CD58F5327D9F13458E3B3F030AF* __this, String_t* ___xpath0, XmlNamespaceManager_t95431ADE7A94108629DFF894819FB1A9709D810F* ___nsmgr1, const RuntimeMethod* method) ;
// System.Boolean System.String::Contains(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool String_Contains_m6D77B121FADA7CA5F397C0FABB65DA62DF03B6C3 (String_t* __this, String_t* ___value0, const RuntimeMethod* method) ;
// System.String Lidgren.Network.NetUPnP::CombineUrls(System.String,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* NetUPnP_CombineUrls_m93BDC49B3DA9D2D9CBE30C10F101A712EEA67C2B (String_t* ___gatewayURL0, String_t* ___subURL1, const RuntimeMethod* method) ;
// System.Boolean System.Threading.EventWaitHandle::Set()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool EventWaitHandle_Set_mDF98D67F214714A9590DF82A1C51D3D851281E4D (EventWaitHandle_t18F2EB0161747B0646A9A406015A61A214A1EB7E* __this, const RuntimeMethod* method) ;
// System.String System.String::Replace(System.String,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* String_Replace_mABDB7003A1D0AEDCAE9FF85E3DFFFBA752D2A166 (String_t* __this, String_t* ___oldValue0, String_t* ___newValue1, const RuntimeMethod* method) ;
// System.Int32 System.String::IndexOf(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t String_IndexOf_m69E9BDAFD93767C85A7FF861B453415D3B4A200F (String_t* __this, String_t* ___value0, const RuntimeMethod* method) ;
// System.String System.String::Substring(System.Int32,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* String_Substring_mB1D94F47935D22E130FF2C01DBB6A4135FBB76CE (String_t* __this, int32_t ___startIndex0, int32_t ___length1, const RuntimeMethod* method) ;
// System.Boolean Lidgren.Network.NetUPnP::CheckAvailability()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool NetUPnP_CheckAvailability_mBEDEC3186DE0A37A66CD5B71C08A374CED65C1F0 (NetUPnP_tBDA843B6A55F8DBED04BF614EEAEDB1F256D86E8* __this, const RuntimeMethod* method) ;
// System.Net.IPAddress Lidgren.Network.NetUtility::GetMyAddress(System.Net.IPAddress&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR IPAddress_t2F4486449B0D73FF2D3B36A9FE5E9C3F63116484* NetUtility_GetMyAddress_m3051AD9EA9B97026C0AD93C606B39B247759AD85 (IPAddress_t2F4486449B0D73FF2D3B36A9FE5E9C3F63116484** ___mask0, const RuntimeMethod* method) ;
// System.String System.Enum::ToString()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* Enum_ToString_m946B0B83C4470457D0FF555D862022C72BB55741 (RuntimeObject* __this, const RuntimeMethod* method) ;
// System.Globalization.CultureInfo System.Globalization.CultureInfo::get_InvariantCulture()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR CultureInfo_t9BA817D41AD55AC8BD07480DD8AC22F8FFA378E0* CultureInfo_get_InvariantCulture_m78DAB8CBE8766445310782B6E61FB7A9983AD425 (const RuntimeMethod* method) ;
// System.String System.String::ToUpper(System.Globalization.CultureInfo)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* String_ToUpper_mFC5C17C8BFF52540CC7A73E36DFC9617281325D1 (String_t* __this, CultureInfo_t9BA817D41AD55AC8BD07480DD8AC22F8FFA378E0* ___culture0, const RuntimeMethod* method) ;
// System.Xml.XmlDocument Lidgren.Network.NetUPnP::SOAPRequest(System.String,System.String,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR XmlDocument_t4DE82998E642C5C21A4A620A5278237C70D3E42B* NetUPnP_SOAPRequest_mFE3B08BAF839443A36A3333A539E3E0DB05AE145 (NetUPnP_tBDA843B6A55F8DBED04BF614EEAEDB1F256D86E8* __this, String_t* ___url0, String_t* ___soap1, String_t* ___function2, const RuntimeMethod* method) ;
// System.Void Lidgren.Network.NetUtility::Sleep(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void NetUtility_Sleep_m51A7652D14F726B5D3EEF64C78C50EFD798303CD (int32_t ___milliseconds0, const RuntimeMethod* method) ;
// System.Net.IPAddress System.Net.IPAddress::Parse(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR IPAddress_t2F4486449B0D73FF2D3B36A9FE5E9C3F63116484* IPAddress_Parse_mD7BEF4D6060D8BE776F559C5F81F195A9917CF1C (String_t* ___ipString0, const RuntimeMethod* method) ;
// System.Void Lidgren.Network.NetUtility/<>c__DisplayClass3_0::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CU3Ec__DisplayClass3_0__ctor_m1C204809AC2DA7F72E6199399BC6FB93CA3CA382 (U3CU3Ec__DisplayClass3_0_t8A9B82FCFB20DB8AF0DEB4BFF84B5BF342D6D362* __this, const RuntimeMethod* method) ;
// System.Void Lidgren.Network.NetUtility/ResolveAddressCallback::.ctor(System.Object,System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ResolveAddressCallback__ctor_m6947005CBFF0F0196EA1234FB57118E5C8D2A803 (ResolveAddressCallback_t025BC6260F915039CDB17B31BCDE78B9ED8CC3CF* __this, RuntimeObject* ___object0, intptr_t ___method1, const RuntimeMethod* method) ;
// System.Void Lidgren.Network.NetUtility::ResolveAsync(System.String,Lidgren.Network.NetUtility/ResolveAddressCallback)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void NetUtility_ResolveAsync_m361784C8A1E4D583AFD6B9C6D2502EFB1BAAF22C (String_t* ___ipOrHost0, ResolveAddressCallback_t025BC6260F915039CDB17B31BCDE78B9ED8CC3CF* ___callback1, const RuntimeMethod* method) ;
// System.Net.IPAddress Lidgren.Network.NetUtility::Resolve(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR IPAddress_t2F4486449B0D73FF2D3B36A9FE5E9C3F63116484* NetUtility_Resolve_m8DB1E743A221537111D97A7E975E46D59F4EF1BB (String_t* ___ipOrHost0, const RuntimeMethod* method) ;
// System.Void Lidgren.Network.NetUtility/<>c__DisplayClass7_0::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CU3Ec__DisplayClass7_0__ctor_m54C100B10B7B0058E6372410E183F972B621DEEE (U3CU3Ec__DisplayClass7_0_tB883D8785D0FF482B1D10D9C5244FE77BF69353A* __this, const RuntimeMethod* method) ;
// System.Boolean System.String::IsNullOrEmpty(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool String_IsNullOrEmpty_m54CF0907E7C4F3AFB2E796A13DC751ECBB8DB64A (String_t* ___value0, const RuntimeMethod* method) ;
// System.Void System.ArgumentException::.ctor(System.String,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ArgumentException__ctor_m8F9D40CE19D19B698A70F9A258640EB52DB39B62 (ArgumentException_tAD90411542A20A9C72D5CDA3A84181D8B947A263* __this, String_t* ___message0, String_t* ___paramName1, const RuntimeMethod* method) ;
// System.String System.String::Trim()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* String_Trim_mCD6D8C6D4CFD15225D12DB7D3E0544CA80FB8DA5 (String_t* __this, const RuntimeMethod* method) ;
// System.Boolean System.Net.IPAddress::TryParse(System.String,System.Net.IPAddress&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool IPAddress_TryParse_mB8DC9EE090ED3BE8F8C9D419759AA9FF4A498D3B (String_t* ___ipString0, IPAddress_t2F4486449B0D73FF2D3B36A9FE5E9C3F63116484** ___address1, const RuntimeMethod* method) ;
// System.Net.Sockets.AddressFamily System.Net.IPAddress::get_AddressFamily()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t IPAddress_get_AddressFamily_m1CE4BCCE499BD70B22F9E37B3F266F9306A98C21 (IPAddress_t2F4486449B0D73FF2D3B36A9FE5E9C3F63116484* __this, const RuntimeMethod* method) ;
// System.Void Lidgren.Network.NetUtility/ResolveAddressCallback::Invoke(System.Net.IPAddress)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ResolveAddressCallback_Invoke_m0FF0480977B8C46A93C0063B6F282E61190C426C (ResolveAddressCallback_t025BC6260F915039CDB17B31BCDE78B9ED8CC3CF* __this, IPAddress_t2F4486449B0D73FF2D3B36A9FE5E9C3F63116484* ___adr0, const RuntimeMethod* method) ;
// System.Void System.ArgumentException::.ctor(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ArgumentException__ctor_m026938A67AF9D36BB7ED27F80425D7194B514465 (ArgumentException_tAD90411542A20A9C72D5CDA3A84181D8B947A263* __this, String_t* ___message0, const RuntimeMethod* method) ;
// System.Void System.AsyncCallback::.ctor(System.Object,System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AsyncCallback__ctor_mC3C0475E930E4419AED02C7335E53B425A2D68AC (AsyncCallback_t7FEF460CBDCFB9C5FA2EF776984778B9A4145F4C* __this, RuntimeObject* ___object0, intptr_t ___method1, const RuntimeMethod* method) ;
// System.IAsyncResult System.Net.Dns::BeginGetHostEntry(System.String,System.AsyncCallback,System.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* Dns_BeginGetHostEntry_m09FA5BD3D68754D9709AAB66C7D82D2D9B7EFAEB (String_t* ___hostNameOrAddress0, AsyncCallback_t7FEF460CBDCFB9C5FA2EF776984778B9A4145F4C* ___requestCallback1, RuntimeObject* ___stateObject2, const RuntimeMethod* method) ;
// System.Net.Sockets.SocketError System.Net.Sockets.SocketException::get_SocketErrorCode()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t SocketException_get_SocketErrorCode_m84FB2D308F046A24A1355975F3BF689C988224C6 (SocketException_t6D10102A62EA871BD31748E026A372DB6804083B* __this, const RuntimeMethod* method) ;
// System.Net.IPAddress[] System.Net.Dns::GetHostAddresses(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR IPAddressU5BU5D_t3AEDF3B94746C9023A4549F878AA47F702C9CD0D* Dns_GetHostAddresses_m0592CB7DB3F5665C412BCBE8297F198748114F90 (String_t* ___hostNameOrAddress0, const RuntimeMethod* method) ;
// System.Byte[] System.BitConverter::GetBytes(System.Int64)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* BitConverter_GetBytes_m2C128EDCD9B369F1429E1A0B7F687C98526115BF (int64_t ___value0, const RuntimeMethod* method) ;
// System.String Lidgren.Network.NetUtility::ToHexString(System.Byte[],System.Int32,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* NetUtility_ToHexString_m14517A11A69DE4F4A86641139825BC7B5F6EDCC5 (ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* ___data0, int32_t ___offset1, int32_t ___length2, const RuntimeMethod* method) ;
// System.String System.String::CreateString(System.Char[])
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* String_CreateString_mFBC28D2E3EB87D497F7E702E4FFAD65F635E44DF (String_t* __this, CharU5BU5D_t799905CF001DD5F13F7DBB310181FC4D8B7D0AAB* ___val0, const RuntimeMethod* method) ;
// System.Net.IPAddress System.Net.IPEndPoint::get_Address()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR IPAddress_t2F4486449B0D73FF2D3B36A9FE5E9C3F63116484* IPEndPoint_get_Address_m72F783CB76E10E9DBDF680CCC1DAAED201BABB1C_inline (IPEndPoint_t2F09CBA7A808B67724B4E2954EEDC46D910F4ECB* __this, const RuntimeMethod* method) ;
// System.Boolean Lidgren.Network.NetUtility::IsLocal(System.Net.IPAddress)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool NetUtility_IsLocal_mF041CF604B0084FC2ED5A04312126E728384F235 (IPAddress_t2F4486449B0D73FF2D3B36A9FE5E9C3F63116484* ___remote0, const RuntimeMethod* method) ;
// System.Byte[] System.Net.IPAddress::GetAddressBytes()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* IPAddress_GetAddressBytes_m1501E0143C791E3A065E508F5535D8E206652EC9 (IPAddress_t2F4486449B0D73FF2D3B36A9FE5E9C3F63116484* __this, const RuntimeMethod* method) ;
// System.UInt32 System.BitConverter::ToUInt32(System.Byte[],System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR uint32_t BitConverter_ToUInt32_m7EFCF9D77ACD0F2DA29F69587DDF6130391E6164 (ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* ___value0, int32_t ___startIndex1, const RuntimeMethod* method) ;
// System.Byte System.Convert::ToByte(System.String,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR uint8_t Convert_ToByte_m200E739C754818844030F3E16CC31017926C853F (String_t* ___value0, int32_t ___fromBase1, const RuntimeMethod* method) ;
// System.Double System.Math::Round(System.Double,System.Int32)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR double Math_Round_mAE7072AE69091258FAA8BD5923CE4A0E492B5B7D_inline (double ___value0, int32_t ___digits1, const RuntimeMethod* method) ;
// System.String System.Double::ToString()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* Double_ToString_m7499A5D792419537DCB9470A3675CEF5117DE339 (double* __this, const RuntimeMethod* method) ;
// System.Int32 System.String::Compare(System.String,System.String,System.StringComparison)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t String_Compare_mC553A80AD870F5777F0E8B5E705B0205396B9D3E (String_t* ___strA0, String_t* ___strB1, int32_t ___comparisonType2, const RuntimeMethod* method) ;
// System.Byte[] Lidgren.Network.NetUtility::ComputeSHAHash(System.Byte[],System.Int32,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* NetUtility_ComputeSHAHash_m72E631ED319081A04FA5BD0EB7F2AB9C072A177F (ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* ___bytes0, int32_t ___offset1, int32_t ___count2, const RuntimeMethod* method) ;
// System.Int32 System.Net.IPEndPoint::get_Port()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR int32_t IPEndPoint_get_Port_mFBE1AF1C9CC7E68A46BF46AD3869CC9DC01CF429_inline (IPEndPoint_t2F09CBA7A808B67724B4E2954EEDC46D910F4ECB* __this, const RuntimeMethod* method) ;
// System.Void System.Net.IPEndPoint::set_Port(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void IPEndPoint_set_Port_m863E796C26AFF6CEACC4A8381E1B9CA2B78F41C4 (IPEndPoint_t2F09CBA7A808B67724B4E2954EEDC46D910F4ECB* __this, int32_t ___value0, const RuntimeMethod* method) ;
// System.Net.IPAddress System.Net.IPAddress::MapToIPv6()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR IPAddress_t2F4486449B0D73FF2D3B36A9FE5E9C3F63116484* IPAddress_MapToIPv6_m3D243981B6A8235516A4D8A68FC555B59675DE33 (IPAddress_t2F4486449B0D73FF2D3B36A9FE5E9C3F63116484* __this, const RuntimeMethod* method) ;
// System.Void System.Net.IPEndPoint::set_Address(System.Net.IPAddress)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void IPEndPoint_set_Address_m48F0D8096D02B90890E453ECF1616B78BB97CF63_inline (IPEndPoint_t2F09CBA7A808B67724B4E2954EEDC46D910F4ECB* __this, IPAddress_t2F4486449B0D73FF2D3B36A9FE5E9C3F63116484* ___value0, const RuntimeMethod* method) ;
// System.Int64 System.Environment::get_WorkingSet()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int64_t Environment_get_WorkingSet_mF0C2C1AEFEF1BD1A92FBFB932964BD38A4E7968B (const RuntimeMethod* method) ;
// System.Net.NetworkInformation.IPGlobalProperties System.Net.NetworkInformation.IPGlobalProperties::GetIPGlobalProperties()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR IPGlobalProperties_tA6F98E3AAD35DD4C6BF821152D3D7B092C80C26D* IPGlobalProperties_GetIPGlobalProperties_m78B851B32A1D963CC616CCA6DC7116F5EAC15753 (const RuntimeMethod* method) ;
// System.Net.NetworkInformation.NetworkInterface[] System.Net.NetworkInformation.NetworkInterface::GetAllNetworkInterfaces()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR NetworkInterfaceU5BU5D_t62783E27F1C4A989B118CDBBE2FCBE65EE5CA080* NetworkInterface_GetAllNetworkInterfaces_mD3638D31C8C05E882CE28542D17821C95FCABE9D (const RuntimeMethod* method) ;
// System.Net.NetworkInformation.NetworkInterface Lidgren.Network.NetUtility::GetNetworkInterface()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR NetworkInterface_t3E7DDFADB8912D0F9D001D1195EBD0FB08B7F47A* NetUtility_GetNetworkInterface_mB294A5009A018B95BBFD95D0A3ED2B457AA50E06 (const RuntimeMethod* method) ;
// System.Byte[] System.Net.NetworkInformation.PhysicalAddress::GetAddressBytes()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* PhysicalAddress_GetAddressBytes_m580AD31C035F8FA177C2BBADF8196EBFAD400F1B (PhysicalAddress_tBD58CB2A171D8DEFF0C882DE988D2D446EF40DEB* __this, const RuntimeMethod* method) ;
// System.Void System.Net.IPAddress::.ctor(System.Byte[])
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void IPAddress__ctor_m01F2FA932B0D4C0B2E15C6C837E3C52DDF186964 (IPAddress_t2F4486449B0D73FF2D3B36A9FE5E9C3F63116484* __this, ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* ___address0, const RuntimeMethod* method) ;
// System.Void System.Threading.Thread::Sleep(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Thread_Sleep_m63B7D29DC735584F4D80373E48C91B34FF32D1A0 (int32_t ___millisecondsTimeout0, const RuntimeMethod* method) ;
// System.Byte[] System.Security.Cryptography.HashAlgorithm::ComputeHash(System.Byte[],System.Int32,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* HashAlgorithm_ComputeHash_mFAB8CADA69B3BE03B1C974250EEC30ADF8805710 (HashAlgorithm_t299ECE61BBF4582B1F75734D43A96DDEC9B2004D* __this, ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* ___buffer0, int32_t ___offset1, int32_t ___count2, const RuntimeMethod* method) ;
// System.Boolean System.Type::op_Inequality(System.Type,System.Type)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Type_op_Inequality_m71AAC993EBBDBA44EE73847D68F71C70AF7AD1D5 (Type_t* ___left0, Type_t* ___right1, const RuntimeMethod* method) ;
// System.Security.Cryptography.SHA256 System.Security.Cryptography.SHA256::Create()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR SHA256_t6FEDD761EE6301127DAAF13320E8FD63296837F9* SHA256_Create_mCF8D7EB52BAB85B20EAE61668D40DDF0CE3EC2E8 (const RuntimeMethod* method) ;
// System.Void Lidgren.Network.NetUtility/ResolveEndPointCallback::Invoke(System.Net.IPEndPoint)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ResolveEndPointCallback_Invoke_m3A5822DF84B3E061C3C3A4F6C006A56E268FD66E (ResolveEndPointCallback_t5A60EB6B6BDAEA33BFEB134C8EFED8B43385049B* __this, IPEndPoint_t2F09CBA7A808B67724B4E2954EEDC46D910F4ECB* ___endPoint0, const RuntimeMethod* method) ;
// System.Net.IPHostEntry System.Net.Dns::EndGetHostEntry(System.IAsyncResult)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR IPHostEntry_tAAAEB0F40DB9F28BE601B5FE7DA1D76191C94490* Dns_EndGetHostEntry_mAE12F9DE6BC238443179126D0B3F5F76067CF3FF (RuntimeObject* ___asyncResult0, const RuntimeMethod* method) ;
// System.Net.IPAddress[] System.Net.IPHostEntry::get_AddressList()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR IPAddressU5BU5D_t3AEDF3B94746C9023A4549F878AA47F702C9CD0D* IPHostEntry_get_AddressList_m9D14D52EFB41C53C9C4A36D438E1333A99B7AA71_inline (IPHostEntry_tAAAEB0F40DB9F28BE601B5FE7DA1D76191C94490* __this, const RuntimeMethod* method) ;
// System.Double System.Math::Round(System.Double,System.Int32,System.MidpointRounding)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR double Math_Round_mA90F6B1668D55BC6C538EBF0302B30E406E242B0 (double ___value0, int32_t ___digits1, int32_t ___mode2, const RuntimeMethod* method) ;
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
// System.Void Lidgren.Network.NetPeerStatistics::.ctor(Lidgren.Network.NetPeer)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void NetPeerStatistics__ctor_m32C5686756F8CEB851F408B99B5602B2670156B5 (NetPeerStatistics_t88AAAF8E56D8CB028A6D4C2E745330471A4FCD32* __this, NetPeer_tDCD3AC5FB42BE47DEE7AEEA74F327C1E0D883542* ___peer0, const RuntimeMethod* method) 
{
{
		// internal NetPeerStatistics(NetPeer peer)
		Object__ctor_mE837C6B9FA8C6D5D109F4B2EC885D79919AC0EA2(__this, NULL);
		// m_peer = peer;
		NetPeer_tDCD3AC5FB42BE47DEE7AEEA74F327C1E0D883542* L_0 = ___peer0;
		__this->___m_peer_0 = L_0;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___m_peer_0), (void*)L_0);
		// Reset();
		NetPeerStatistics_Reset_m515F156801D31537B82AC239CD1ED1395C859E55(__this, NULL);
		// }
		return;
	}
}
// System.Void Lidgren.Network.NetPeerStatistics::Reset()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void NetPeerStatistics_Reset_m515F156801D31537B82AC239CD1ED1395C859E55 (NetPeerStatistics_t88AAAF8E56D8CB028A6D4C2E745330471A4FCD32* __this, const RuntimeMethod* method) 
{
{
		// m_sentPackets = 0;
		__this->___m_sentPackets_1 = 0;
		// m_receivedPackets = 0;
		__this->___m_receivedPackets_2 = 0;
		// m_sentMessages = 0;
		__this->___m_sentMessages_3 = 0;
		// m_receivedMessages = 0;
		__this->___m_receivedMessages_4 = 0;
		// m_receivedFragments = 0;
		__this->___m_receivedFragments_5 = 0;
		// m_sentBytes = 0;
		__this->___m_sentBytes_6 = 0;
		// m_receivedBytes = 0;
		__this->___m_receivedBytes_7 = 0;
		// m_bytesAllocated = 0;
		__this->___m_bytesAllocated_8 = ((int64_t)0);
		// }
		return;
	}
}
// System.Int32 Lidgren.Network.NetPeerStatistics::get_SentPackets()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t NetPeerStatistics_get_SentPackets_mE67B60C53CB23265FF55DE2FFF8B1628D963A239 (NetPeerStatistics_t88AAAF8E56D8CB028A6D4C2E745330471A4FCD32* __this, const RuntimeMethod* method) 
{
{
		// public int SentPackets { get { return m_sentPackets; } }
		int32_t L_0 = __this->___m_sentPackets_1;
		return L_0;
	}
}
// System.Int32 Lidgren.Network.NetPeerStatistics::get_ReceivedPackets()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t NetPeerStatistics_get_ReceivedPackets_m5D9576EEFD96AFE215DB1B8081BFE0C8BCD32E2C (NetPeerStatistics_t88AAAF8E56D8CB028A6D4C2E745330471A4FCD32* __this, const RuntimeMethod* method) 
{
{
		// public int ReceivedPackets { get { return m_receivedPackets; } }
		int32_t L_0 = __this->___m_receivedPackets_2;
		return L_0;
	}
}
// System.Int32 Lidgren.Network.NetPeerStatistics::get_SentMessages()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t NetPeerStatistics_get_SentMessages_m8FDB7AB8E18833EF787D39F231BF3FB05803E56B (NetPeerStatistics_t88AAAF8E56D8CB028A6D4C2E745330471A4FCD32* __this, const RuntimeMethod* method) 
{
{
		// public int SentMessages { get { return m_sentMessages; } }
		int32_t L_0 = __this->___m_sentMessages_3;
		return L_0;
	}
}
// System.Int32 Lidgren.Network.NetPeerStatistics::get_ReceivedMessages()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t NetPeerStatistics_get_ReceivedMessages_m9AB6B4C243DC6777536F54E6D51601F63FB59587 (NetPeerStatistics_t88AAAF8E56D8CB028A6D4C2E745330471A4FCD32* __this, const RuntimeMethod* method) 
{
{
		// public int ReceivedMessages { get { return m_receivedMessages; } }
		int32_t L_0 = __this->___m_receivedMessages_4;
		return L_0;
	}
}
// System.Int32 Lidgren.Network.NetPeerStatistics::get_SentBytes()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t NetPeerStatistics_get_SentBytes_m744214C02D917996C99027B3C30EB25A29F8F8BB (NetPeerStatistics_t88AAAF8E56D8CB028A6D4C2E745330471A4FCD32* __this, const RuntimeMethod* method) 
{
{
		// public int SentBytes { get { return m_sentBytes; } }
		int32_t L_0 = __this->___m_sentBytes_6;
		return L_0;
	}
}
// System.Int32 Lidgren.Network.NetPeerStatistics::get_ReceivedBytes()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t NetPeerStatistics_get_ReceivedBytes_m1F8B277E1545259A0229E56AB96125B64C67B71A (NetPeerStatistics_t88AAAF8E56D8CB028A6D4C2E745330471A4FCD32* __this, const RuntimeMethod* method) 
{
{
		// public int ReceivedBytes { get { return m_receivedBytes; } }
		int32_t L_0 = __this->___m_receivedBytes_7;
		return L_0;
	}
}
// System.Int64 Lidgren.Network.NetPeerStatistics::get_StorageBytesAllocated()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int64_t NetPeerStatistics_get_StorageBytesAllocated_mF04F30821F14D890EAA6405BBDD9D8BABAA1D9C5 (NetPeerStatistics_t88AAAF8E56D8CB028A6D4C2E745330471A4FCD32* __this, const RuntimeMethod* method) 
{
{
		// public long StorageBytesAllocated { get { return m_bytesAllocated; } }
		int64_t L_0 = __this->___m_bytesAllocated_8;
		return L_0;
	}
}
// System.Int32 Lidgren.Network.NetPeerStatistics::get_BytesInRecyclePool()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t NetPeerStatistics_get_BytesInRecyclePool_m3767A0BE48BC5C1B55CB31AB5186DF67182C5FFF (NetPeerStatistics_t88AAAF8E56D8CB028A6D4C2E745330471A4FCD32* __this, const RuntimeMethod* method) 
{
List_1_tBFF9DD9FFA06F20E74F9D7AD36610BD754D353A4* V_0 = NULL;
	bool V_1 = false;
	int32_t V_2 = 0;
	{
		// lock (m_peer.m_storagePool)
		NetPeer_tDCD3AC5FB42BE47DEE7AEEA74F327C1E0D883542* L_0 = __this->___m_peer_0;
		NullCheck(L_0);
		List_1_tBFF9DD9FFA06F20E74F9D7AD36610BD754D353A4* L_1 = L_0->___m_storagePool_33;
		V_0 = L_1;
		V_1 = (bool)0;
	}

IL_000e:
	{
		auto __finallyBlock = il2cpp::utils::Finally([&]
		{

FINALLY_0024:
			{// begin finally (depth: 1)
				{
					bool L_2 = V_1;
					if (!L_2)
					{
						goto IL_002d;
					}
				}

IL_0027:
				{
					List_1_tBFF9DD9FFA06F20E74F9D7AD36610BD754D353A4* L_3 = V_0;
					Monitor_Exit_m25A154960F91391E10E4CDA245ECDF4BA94D56A9(L_3, NULL);
				}

IL_002d:
				{
					return;
				}
			}// end finally (depth: 1)
		});
		try
		{// begin try (depth: 1)
			List_1_tBFF9DD9FFA06F20E74F9D7AD36610BD754D353A4* L_4 = V_0;
			Monitor_Enter_m00506757392936AA62DBE2C5FFBEE69EE920C4D4(L_4, (&V_1), NULL);
			// return m_peer.m_storagePoolBytes;
			NetPeer_tDCD3AC5FB42BE47DEE7AEEA74F327C1E0D883542* L_5 = __this->___m_peer_0;
			NullCheck(L_5);
			int32_t L_6 = L_5->___m_storagePoolBytes_36;
			V_2 = L_6;
			goto IL_002e;
		}// end try (depth: 1)
		catch(Il2CppExceptionWrapper& e)
		{
			__finallyBlock.StoreException(e.ex);
		}
	}

IL_002e:
	{
		// }
		int32_t L_7 = V_2;
		return L_7;
	}
}
// System.Void Lidgren.Network.NetPeerStatistics::PacketSent(System.Int32,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void NetPeerStatistics_PacketSent_m274D3FD2F23B27347D0512F183D37673DDB36157 (NetPeerStatistics_t88AAAF8E56D8CB028A6D4C2E745330471A4FCD32* __this, int32_t ___numBytes0, int32_t ___numMessages1, const RuntimeMethod* method) 
{
{
		// m_sentPackets++;
		int32_t L_0 = __this->___m_sentPackets_1;
		__this->___m_sentPackets_1 = ((int32_t)il2cpp_codegen_add(L_0, 1));
		// m_sentBytes += numBytes;
		int32_t L_1 = __this->___m_sentBytes_6;
		int32_t L_2 = ___numBytes0;
		__this->___m_sentBytes_6 = ((int32_t)il2cpp_codegen_add(L_1, L_2));
		// m_sentMessages += numMessages;
		int32_t L_3 = __this->___m_sentMessages_3;
		int32_t L_4 = ___numMessages1;
		__this->___m_sentMessages_3 = ((int32_t)il2cpp_codegen_add(L_3, L_4));
		// }
		return;
	}
}
// System.Void Lidgren.Network.NetPeerStatistics::PacketReceived(System.Int32,System.Int32,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void NetPeerStatistics_PacketReceived_mEE8669D6DFC8CCB59E47239B404485FE91E67A76 (NetPeerStatistics_t88AAAF8E56D8CB028A6D4C2E745330471A4FCD32* __this, int32_t ___numBytes0, int32_t ___numMessages1, int32_t ___numFragments2, const RuntimeMethod* method) 
{
{
		// m_receivedPackets++;
		int32_t L_0 = __this->___m_receivedPackets_2;
		__this->___m_receivedPackets_2 = ((int32_t)il2cpp_codegen_add(L_0, 1));
		// m_receivedBytes += numBytes;
		int32_t L_1 = __this->___m_receivedBytes_7;
		int32_t L_2 = ___numBytes0;
		__this->___m_receivedBytes_7 = ((int32_t)il2cpp_codegen_add(L_1, L_2));
		// m_receivedMessages += numMessages;
		int32_t L_3 = __this->___m_receivedMessages_4;
		int32_t L_4 = ___numMessages1;
		__this->___m_receivedMessages_4 = ((int32_t)il2cpp_codegen_add(L_3, L_4));
		// m_receivedFragments += numFragments;
		int32_t L_5 = __this->___m_receivedFragments_5;
		int32_t L_6 = ___numFragments2;
		__this->___m_receivedFragments_5 = ((int32_t)il2cpp_codegen_add(L_5, L_6));
		// }
		return;
	}
}
// System.String Lidgren.Network.NetPeerStatistics::ToString()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* NetPeerStatistics_ToString_m3A84594B2211AE429295A82BBD24CE3E8799C5BF (NetPeerStatistics_t88AAAF8E56D8CB028A6D4C2E745330471A4FCD32* __this, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&StringBuilder_t_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral11CE4C29D0C7FA2347C524512600FEAB96B84D10);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral3B9252E0782022A05A1A5DC8E569F6054E24A2BD);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral5A83027BA58C6703A855737A110D0A1018143201);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral5E4C76669D301F0CED3F6E8F0856461B786D1082);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral7AA4F9D664F2002ACD9C3606A0D4AE7CC3807D6E);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral849E189D85B0C93D90F5CD6EC2B6FB59CDBDA9E5);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral9F954BE9FD9E999DA1677DADC6D2CAB27412A282);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralDBEC827409AB5C91169A1D96A32D42A9529653C7);
		s_Il2CppMethodInitialized = true;
	}
StringBuilder_t* V_0 = NULL;
	int32_t V_1 = 0;
	{
		// StringBuilder bdr = new StringBuilder();
		StringBuilder_t* L_0 = (StringBuilder_t*)il2cpp_codegen_object_new(StringBuilder_t_il2cpp_TypeInfo_var);
		StringBuilder__ctor_m1D99713357DE05DAFA296633639DB55F8C30587D(L_0, /*hidden argument*/NULL);
		V_0 = L_0;
		// bdr.AppendLine(m_peer.ConnectionsCount.ToString() + " connections");
		StringBuilder_t* L_1 = V_0;
		NetPeer_tDCD3AC5FB42BE47DEE7AEEA74F327C1E0D883542* L_2 = __this->___m_peer_0;
		NullCheck(L_2);
		int32_t L_3;
		L_3 = NetPeer_get_ConnectionsCount_mE708A4F8CA40ED8F2F1C63143A8AB4603DA7FEBB(L_2, NULL);
		V_1 = L_3;
		String_t* L_4;
		L_4 = Int32_ToString_m030E01C24E294D6762FB0B6F37CB541581F55CA5((&V_1), NULL);
		String_t* L_5;
		L_5 = String_Concat_mAF2CE02CC0CB7460753D0A1A91CCF2B1E9804C5D(L_4, _stringLiteral849E189D85B0C93D90F5CD6EC2B6FB59CDBDA9E5, NULL);
		NullCheck(L_1);
		StringBuilder_t* L_6;
		L_6 = StringBuilder_AppendLine_mF75744CE941C63E33188E22E936B71A24D3CBF88(L_1, L_5, NULL);
		// bdr.AppendLine("Sent (n/a) bytes in (n/a) messages in (n/a) packets");
		StringBuilder_t* L_7 = V_0;
		NullCheck(L_7);
		StringBuilder_t* L_8;
		L_8 = StringBuilder_AppendLine_mF75744CE941C63E33188E22E936B71A24D3CBF88(L_7, _stringLiteral7AA4F9D664F2002ACD9C3606A0D4AE7CC3807D6E, NULL);
		// bdr.AppendLine("Received (n/a) bytes in (n/a) messages in (n/a) packets");
		StringBuilder_t* L_9 = V_0;
		NullCheck(L_9);
		StringBuilder_t* L_10;
		L_10 = StringBuilder_AppendLine_mF75744CE941C63E33188E22E936B71A24D3CBF88(L_9, _stringLiteral5A83027BA58C6703A855737A110D0A1018143201, NULL);
		// bdr.AppendLine("Storage allocated " + m_bytesAllocated + " bytes");
		StringBuilder_t* L_11 = V_0;
		int64_t* L_12 = (&__this->___m_bytesAllocated_8);
		String_t* L_13;
		L_13 = Int64_ToString_m284E4E55662818E38654309A41C2B07CD436F36B(L_12, NULL);
		String_t* L_14;
		L_14 = String_Concat_m9B13B47FCB3DF61144D9647DDA05F527377251B0(_stringLiteral11CE4C29D0C7FA2347C524512600FEAB96B84D10, L_13, _stringLiteral9F954BE9FD9E999DA1677DADC6D2CAB27412A282, NULL);
		NullCheck(L_11);
		StringBuilder_t* L_15;
		L_15 = StringBuilder_AppendLine_mF75744CE941C63E33188E22E936B71A24D3CBF88(L_11, L_14, NULL);
		// if (m_peer.m_storagePool != null)
		NetPeer_tDCD3AC5FB42BE47DEE7AEEA74F327C1E0D883542* L_16 = __this->___m_peer_0;
		NullCheck(L_16);
		List_1_tBFF9DD9FFA06F20E74F9D7AD36610BD754D353A4* L_17 = L_16->___m_storagePool_33;
		if (!L_17)
		{
			goto IL_00c0;
		}
	}
	{
		// bdr.AppendLine("Recycled pool " + m_peer.m_storagePoolBytes + " bytes (" + m_peer.m_storageSlotsUsedCount + " entries)");
		StringBuilder_t* L_18 = V_0;
		StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248* L_19 = (StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248*)(StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248*)SZArrayNew(StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248_il2cpp_TypeInfo_var, (uint32_t)5);
		StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248* L_20 = L_19;
		NullCheck(L_20);
		ArrayElementTypeCheck (L_20, _stringLiteral5E4C76669D301F0CED3F6E8F0856461B786D1082);
		(L_20)->SetAt(static_cast<il2cpp_array_size_t>(0), (String_t*)_stringLiteral5E4C76669D301F0CED3F6E8F0856461B786D1082);
		StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248* L_21 = L_20;
		NetPeer_tDCD3AC5FB42BE47DEE7AEEA74F327C1E0D883542* L_22 = __this->___m_peer_0;
		NullCheck(L_22);
		int32_t* L_23 = (&L_22->___m_storagePoolBytes_36);
		String_t* L_24;
		L_24 = Int32_ToString_m030E01C24E294D6762FB0B6F37CB541581F55CA5(L_23, NULL);
		NullCheck(L_21);
		ArrayElementTypeCheck (L_21, L_24);
		(L_21)->SetAt(static_cast<il2cpp_array_size_t>(1), (String_t*)L_24);
		StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248* L_25 = L_21;
		NullCheck(L_25);
		ArrayElementTypeCheck (L_25, _stringLiteralDBEC827409AB5C91169A1D96A32D42A9529653C7);
		(L_25)->SetAt(static_cast<il2cpp_array_size_t>(2), (String_t*)_stringLiteralDBEC827409AB5C91169A1D96A32D42A9529653C7);
		StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248* L_26 = L_25;
		NetPeer_tDCD3AC5FB42BE47DEE7AEEA74F327C1E0D883542* L_27 = __this->___m_peer_0;
		NullCheck(L_27);
		int32_t* L_28 = (&L_27->___m_storageSlotsUsedCount_37);
		String_t* L_29;
		L_29 = Int32_ToString_m030E01C24E294D6762FB0B6F37CB541581F55CA5(L_28, NULL);
		NullCheck(L_26);
		ArrayElementTypeCheck (L_26, L_29);
		(L_26)->SetAt(static_cast<il2cpp_array_size_t>(3), (String_t*)L_29);
		StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248* L_30 = L_26;
		NullCheck(L_30);
		ArrayElementTypeCheck (L_30, _stringLiteral3B9252E0782022A05A1A5DC8E569F6054E24A2BD);
		(L_30)->SetAt(static_cast<il2cpp_array_size_t>(4), (String_t*)_stringLiteral3B9252E0782022A05A1A5DC8E569F6054E24A2BD);
		String_t* L_31;
		L_31 = String_Concat_m6B0734B65813C8EA093D78E5C2D16534EB6FE8C0(L_30, NULL);
		NullCheck(L_18);
		StringBuilder_t* L_32;
		L_32 = StringBuilder_AppendLine_mF75744CE941C63E33188E22E936B71A24D3CBF88(L_18, L_31, NULL);
	}

IL_00c0:
	{
		// return bdr.ToString();
		StringBuilder_t* L_33 = V_0;
		NullCheck(L_33);
		String_t* L_34;
		L_34 = VirtualFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, L_33);
		return L_34;
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
// System.Void Lidgren.Network.NetRandom::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void NetRandom__ctor_m371927707325556AFB04D38F4D17D48735D392D0 (NetRandom_t5390B683E78A49E7984152B9490E6350D1D16AFB* __this, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&NetRandomSeed_t78C4CD0A1F9754C7FC65DBE87A58F24C76419A8E_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Random_t79716069EDE67D1D7734F60AE402D0CA3FB6B4C8_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
{
		// public NetRandom()
		il2cpp_codegen_runtime_class_init_inline(Random_t79716069EDE67D1D7734F60AE402D0CA3FB6B4C8_il2cpp_TypeInfo_var);
		Random__ctor_m151183BD4F021499A98B9DE8502DAD4B12DD16AC(__this, NULL);
		// Initialize(NetRandomSeed.GetUInt32());
		il2cpp_codegen_runtime_class_init_inline(NetRandomSeed_t78C4CD0A1F9754C7FC65DBE87A58F24C76419A8E_il2cpp_TypeInfo_var);
		uint32_t L_0;
		L_0 = NetRandomSeed_GetUInt32_m848FE5010D207F240BB352D9E5B17B287C9FB8FD(NULL);
		VirtualActionInvoker1< uint32_t >::Invoke(10 /* System.Void Lidgren.Network.NetRandom::Initialize(System.UInt32) */, __this, L_0);
		// }
		return;
	}
}
// System.Void Lidgren.Network.NetRandom::.ctor(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void NetRandom__ctor_m96E096BCECD095F5A59905D3B8D48A2E7C13EE27 (NetRandom_t5390B683E78A49E7984152B9490E6350D1D16AFB* __this, int32_t ___seed0, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Random_t79716069EDE67D1D7734F60AE402D0CA3FB6B4C8_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
{
		// public NetRandom(int seed)
		il2cpp_codegen_runtime_class_init_inline(Random_t79716069EDE67D1D7734F60AE402D0CA3FB6B4C8_il2cpp_TypeInfo_var);
		Random__ctor_m151183BD4F021499A98B9DE8502DAD4B12DD16AC(__this, NULL);
		// Initialize((uint)seed);
		int32_t L_0 = ___seed0;
		VirtualActionInvoker1< uint32_t >::Invoke(10 /* System.Void Lidgren.Network.NetRandom::Initialize(System.UInt32) */, __this, L_0);
		// }
		return;
	}
}
// System.Void Lidgren.Network.NetRandom::Initialize(System.UInt32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void NetRandom_Initialize_mAF5A07C896F3A9330E898D3921F87C7AE8964FF5 (NetRandom_t5390B683E78A49E7984152B9490E6350D1D16AFB* __this, uint32_t ___seed0, const RuntimeMethod* method) 
{
{
		// throw new NotImplementedException("Implement this in inherited classes");
		NotImplementedException_t6366FE4DCF15094C51F4833B91A2AE68D4DA90E8* L_0 = (NotImplementedException_t6366FE4DCF15094C51F4833B91A2AE68D4DA90E8*)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&NotImplementedException_t6366FE4DCF15094C51F4833B91A2AE68D4DA90E8_il2cpp_TypeInfo_var)));
		NotImplementedException__ctor_m8339D1A685E8D77CAC9D3260C06B38B5C7CA7742(L_0, ((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteral4D868A34BF4C64BE357F03A0502F8780A1947FAD)), /*hidden argument*/NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_0, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&NetRandom_Initialize_mAF5A07C896F3A9330E898D3921F87C7AE8964FF5_RuntimeMethod_var)));
	}
}
// System.UInt32 Lidgren.Network.NetRandom::NextUInt32()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR uint32_t NetRandom_NextUInt32_m154D8DBA6A332C58AC66EBC33CEE5869C5756C6F (NetRandom_t5390B683E78A49E7984152B9490E6350D1D16AFB* __this, const RuntimeMethod* method) 
{
{
		// throw new NotImplementedException("Implement this in inherited classes");
		NotImplementedException_t6366FE4DCF15094C51F4833B91A2AE68D4DA90E8* L_0 = (NotImplementedException_t6366FE4DCF15094C51F4833B91A2AE68D4DA90E8*)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&NotImplementedException_t6366FE4DCF15094C51F4833B91A2AE68D4DA90E8_il2cpp_TypeInfo_var)));
		NotImplementedException__ctor_m8339D1A685E8D77CAC9D3260C06B38B5C7CA7742(L_0, ((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteral4D868A34BF4C64BE357F03A0502F8780A1947FAD)), /*hidden argument*/NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_0, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&NetRandom_NextUInt32_m154D8DBA6A332C58AC66EBC33CEE5869C5756C6F_RuntimeMethod_var)));
	}
}
// System.Int32 Lidgren.Network.NetRandom::Next()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t NetRandom_Next_mA5502A72A93AD599E7E4D67DE01A60D17638313C (NetRandom_t5390B683E78A49E7984152B9490E6350D1D16AFB* __this, const RuntimeMethod* method) 
{
int32_t V_0 = 0;
	{
		// var retval = (int)(0x7FFFFFFF & NextUInt32());
		uint32_t L_0;
		L_0 = VirtualFuncInvoker0< uint32_t >::Invoke(11 /* System.UInt32 Lidgren.Network.NetRandom::NextUInt32() */, __this);
		V_0 = ((int32_t)(((int32_t)2147483647LL)&(int32_t)L_0));
		// if (retval == 0x7FFFFFFF)
		int32_t L_1 = V_0;
		if ((!(((uint32_t)L_1) == ((uint32_t)((int32_t)2147483647LL)))))
		{
			goto IL_001c;
		}
	}
	{
		// return NextInt32();
		int32_t L_2;
		L_2 = NetRandom_NextInt32_mCFA4B17E9FE690DDAD35B2F3F8420D3ECBF7249B(__this, NULL);
		return L_2;
	}

IL_001c:
	{
		// return retval;
		int32_t L_3 = V_0;
		return L_3;
	}
}
// System.Int32 Lidgren.Network.NetRandom::NextInt32()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t NetRandom_NextInt32_mCFA4B17E9FE690DDAD35B2F3F8420D3ECBF7249B (NetRandom_t5390B683E78A49E7984152B9490E6350D1D16AFB* __this, const RuntimeMethod* method) 
{
{
		// return (int)(0x7FFFFFFF & NextUInt32());
		uint32_t L_0;
		L_0 = VirtualFuncInvoker0< uint32_t >::Invoke(11 /* System.UInt32 Lidgren.Network.NetRandom::NextUInt32() */, __this);
		return ((int32_t)(((int32_t)2147483647LL)&(int32_t)L_0));
	}
}
// System.Double Lidgren.Network.NetRandom::NextDouble()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR double NetRandom_NextDouble_m6A119BA893D45BEAA54492FF5BCF6FE8830A147A (NetRandom_t5390B683E78A49E7984152B9490E6350D1D16AFB* __this, const RuntimeMethod* method) 
{
{
		// return c_realUnitInt * NextInt32();
		int32_t L_0;
		L_0 = NetRandom_NextInt32_mCFA4B17E9FE690DDAD35B2F3F8420D3ECBF7249B(__this, NULL);
		return ((double)il2cpp_codegen_multiply((4.6566128730773926E-10), ((double)L_0)));
	}
}
// System.Double Lidgren.Network.NetRandom::Sample()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR double NetRandom_Sample_m7DA39E94FB8F7DC4D51CCB42050AE73DEE663008 (NetRandom_t5390B683E78A49E7984152B9490E6350D1D16AFB* __this, const RuntimeMethod* method) 
{
{
		// return c_realUnitInt * NextInt32();
		int32_t L_0;
		L_0 = NetRandom_NextInt32_mCFA4B17E9FE690DDAD35B2F3F8420D3ECBF7249B(__this, NULL);
		return ((double)il2cpp_codegen_multiply((4.6566128730773926E-10), ((double)L_0)));
	}
}
// System.Single Lidgren.Network.NetRandom::NextSingle()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float NetRandom_NextSingle_m21FDC122CDBEF5E696AE3ED3F0B0EFD7D9ECAD69 (NetRandom_t5390B683E78A49E7984152B9490E6350D1D16AFB* __this, const RuntimeMethod* method) 
{
float V_0 = 0.0f;
	{
		// var retval = (float)(c_realUnitInt * NextInt32());
		int32_t L_0;
		L_0 = NetRandom_NextInt32_mCFA4B17E9FE690DDAD35B2F3F8420D3ECBF7249B(__this, NULL);
		V_0 = ((float)((double)il2cpp_codegen_multiply((4.6566128730773926E-10), ((double)L_0))));
		// if (retval == 1.0f)
		float L_1 = V_0;
		if ((!(((float)L_1) == ((float)(1.0f)))))
		{
			goto IL_0022;
		}
	}
	{
		// return NextSingle();
		float L_2;
		L_2 = NetRandom_NextSingle_m21FDC122CDBEF5E696AE3ED3F0B0EFD7D9ECAD69(__this, NULL);
		return L_2;
	}

IL_0022:
	{
		// return retval;
		float L_3 = V_0;
		return L_3;
	}
}
// System.Int32 Lidgren.Network.NetRandom::Next(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t NetRandom_Next_m50A0AA60A8C67E866AD0AB404B4D5EA3EEB9114E (NetRandom_t5390B683E78A49E7984152B9490E6350D1D16AFB* __this, int32_t ___maxValue0, const RuntimeMethod* method) 
{
{
		// return (int)(NextDouble() * maxValue);
		double L_0;
		L_0 = VirtualFuncInvoker0< double >::Invoke(8 /* System.Double System.Random::NextDouble() */, __this);
		int32_t L_1 = ___maxValue0;
		return il2cpp_codegen_cast_double_to_int<int32_t>(((double)il2cpp_codegen_multiply(L_0, ((double)L_1))));
	}
}
// System.Int32 Lidgren.Network.NetRandom::Next(System.Int32,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t NetRandom_Next_mEB84B06A56B823972DC70A7AD0242BB19A4932E3 (NetRandom_t5390B683E78A49E7984152B9490E6350D1D16AFB* __this, int32_t ___minValue0, int32_t ___maxValue1, const RuntimeMethod* method) 
{
{
		// return minValue + (int)(NextDouble() * (double)(maxValue - minValue));
		int32_t L_0 = ___minValue0;
		double L_1;
		L_1 = VirtualFuncInvoker0< double >::Invoke(8 /* System.Double System.Random::NextDouble() */, __this);
		int32_t L_2 = ___maxValue1;
		int32_t L_3 = ___minValue0;
		return ((int32_t)il2cpp_codegen_add(L_0, il2cpp_codegen_cast_double_to_int<int32_t>(((double)il2cpp_codegen_multiply(L_1, ((double)((int32_t)il2cpp_codegen_subtract(L_2, L_3))))))));
	}
}
// System.UInt64 Lidgren.Network.NetRandom::NextUInt64()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR uint64_t NetRandom_NextUInt64_m1C9313BC16CD4EB8F543349D65A8A154E8BFB025 (NetRandom_t5390B683E78A49E7984152B9490E6350D1D16AFB* __this, const RuntimeMethod* method) 
{
{
		// ulong retval = NextUInt32();
		uint32_t L_0;
		L_0 = VirtualFuncInvoker0< uint32_t >::Invoke(11 /* System.UInt32 Lidgren.Network.NetRandom::NextUInt32() */, __this);
		// retval |= NextUInt32() << 32;
		uint32_t L_1;
		L_1 = VirtualFuncInvoker0< uint32_t >::Invoke(11 /* System.UInt32 Lidgren.Network.NetRandom::NextUInt32() */, __this);
		// return retval;
		return ((int64_t)(((int64_t)(uint64_t)L_0)|((int64_t)(uint64_t)L_1)));
	}
}
// System.Boolean Lidgren.Network.NetRandom::NextBool()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool NetRandom_NextBool_mE7E76472A8229C25644EAB8FCDA3FA8B92E73EC8 (NetRandom_t5390B683E78A49E7984152B9490E6350D1D16AFB* __this, const RuntimeMethod* method) 
{
{
		// if (m_nextBoolIndex >= 32)
		int32_t L_0 = __this->___m_nextBoolIndex_11;
		if ((((int32_t)L_0) < ((int32_t)((int32_t)32))))
		{
			goto IL_001d;
		}
	}
	{
		// m_boolValues = NextUInt32();
		uint32_t L_1;
		L_1 = VirtualFuncInvoker0< uint32_t >::Invoke(11 /* System.UInt32 Lidgren.Network.NetRandom::NextUInt32() */, __this);
		__this->___m_boolValues_10 = L_1;
		// m_nextBoolIndex = 1;
		__this->___m_nextBoolIndex_11 = 1;
	}

IL_001d:
	{
		// var retval = ((m_boolValues >> m_nextBoolIndex) & 1) == 1;
		uint32_t L_2 = __this->___m_boolValues_10;
		int32_t L_3 = __this->___m_nextBoolIndex_11;
		// m_nextBoolIndex++;
		int32_t L_4 = __this->___m_nextBoolIndex_11;
		__this->___m_nextBoolIndex_11 = ((int32_t)il2cpp_codegen_add(L_4, 1));
		// return retval;
		return (bool)((((int32_t)((int32_t)(((int32_t)((uint32_t)L_2>>((int32_t)(L_3&((int32_t)31)))))&1))) == ((int32_t)1))? 1 : 0);
	}
}
// System.Void Lidgren.Network.NetRandom::NextBytes(System.Byte[],System.Int32,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void NetRandom_NextBytes_m7251DDCE012E86374D6CDE8D5F777AE366A54598 (NetRandom_t5390B683E78A49E7984152B9490E6350D1D16AFB* __this, ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* ___buffer0, int32_t ___offset1, int32_t ___length2, const RuntimeMethod* method) 
{
int32_t V_0 = 0;
	int32_t V_1 = 0;
	int32_t V_2 = 0;
	int32_t V_3 = 0;
	uint32_t V_4 = 0;
	int32_t V_5 = 0;
	{
		// int full = length / 4;
		int32_t L_0 = ___length2;
		V_0 = ((int32_t)(L_0/4));
		// int ptr = offset;
		int32_t L_1 = ___offset1;
		V_1 = L_1;
		// for (int i = 0; i < full; i++)
		V_3 = 0;
		goto IL_0046;
	}

IL_000a:
	{
		// uint r = NextUInt32();
		uint32_t L_2;
		L_2 = VirtualFuncInvoker0< uint32_t >::Invoke(11 /* System.UInt32 Lidgren.Network.NetRandom::NextUInt32() */, __this);
		V_4 = L_2;
		// buffer[ptr++] = (byte)r;
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_3 = ___buffer0;
		int32_t L_4 = V_1;
		int32_t L_5 = L_4;
		V_1 = ((int32_t)il2cpp_codegen_add(L_5, 1));
		uint32_t L_6 = V_4;
		NullCheck(L_3);
		(L_3)->SetAt(static_cast<il2cpp_array_size_t>(L_5), (uint8_t)((int32_t)(uint8_t)L_6));
		// buffer[ptr++] = (byte)(r >> 8);
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_7 = ___buffer0;
		int32_t L_8 = V_1;
		int32_t L_9 = L_8;
		V_1 = ((int32_t)il2cpp_codegen_add(L_9, 1));
		uint32_t L_10 = V_4;
		NullCheck(L_7);
		(L_7)->SetAt(static_cast<il2cpp_array_size_t>(L_9), (uint8_t)((int32_t)(uint8_t)((int32_t)((uint32_t)L_10>>8))));
		// buffer[ptr++] = (byte)(r >> 16);
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_11 = ___buffer0;
		int32_t L_12 = V_1;
		int32_t L_13 = L_12;
		V_1 = ((int32_t)il2cpp_codegen_add(L_13, 1));
		uint32_t L_14 = V_4;
		NullCheck(L_11);
		(L_11)->SetAt(static_cast<il2cpp_array_size_t>(L_13), (uint8_t)((int32_t)(uint8_t)((int32_t)((uint32_t)L_14>>((int32_t)16)))));
		// buffer[ptr++] = (byte)(r >> 24);
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_15 = ___buffer0;
		int32_t L_16 = V_1;
		int32_t L_17 = L_16;
		V_1 = ((int32_t)il2cpp_codegen_add(L_17, 1));
		uint32_t L_18 = V_4;
		NullCheck(L_15);
		(L_15)->SetAt(static_cast<il2cpp_array_size_t>(L_17), (uint8_t)((int32_t)(uint8_t)((int32_t)((uint32_t)L_18>>((int32_t)24)))));
		// for (int i = 0; i < full; i++)
		int32_t L_19 = V_3;
		V_3 = ((int32_t)il2cpp_codegen_add(L_19, 1));
	}

IL_0046:
	{
		// for (int i = 0; i < full; i++)
		int32_t L_20 = V_3;
		int32_t L_21 = V_0;
		if ((((int32_t)L_20) < ((int32_t)L_21)))
		{
			goto IL_000a;
		}
	}
	{
		// int rest = length - (full * 4);
		int32_t L_22 = ___length2;
		int32_t L_23 = V_0;
		V_2 = ((int32_t)il2cpp_codegen_subtract(L_22, ((int32_t)il2cpp_codegen_multiply(L_23, 4))));
		// for (int i = 0; i < rest; i++)
		V_5 = 0;
		goto IL_0069;
	}

IL_0055:
	{
		// buffer[ptr++] = (byte)NextUInt32();
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_24 = ___buffer0;
		int32_t L_25 = V_1;
		int32_t L_26 = L_25;
		V_1 = ((int32_t)il2cpp_codegen_add(L_26, 1));
		uint32_t L_27;
		L_27 = VirtualFuncInvoker0< uint32_t >::Invoke(11 /* System.UInt32 Lidgren.Network.NetRandom::NextUInt32() */, __this);
		NullCheck(L_24);
		(L_24)->SetAt(static_cast<il2cpp_array_size_t>(L_26), (uint8_t)((int32_t)(uint8_t)L_27));
		// for (int i = 0; i < rest; i++)
		int32_t L_28 = V_5;
		V_5 = ((int32_t)il2cpp_codegen_add(L_28, 1));
	}

IL_0069:
	{
		// for (int i = 0; i < rest; i++)
		int32_t L_29 = V_5;
		int32_t L_30 = V_2;
		if ((((int32_t)L_29) < ((int32_t)L_30)))
		{
			goto IL_0055;
		}
	}
	{
		// }
		return;
	}
}
// System.Void Lidgren.Network.NetRandom::NextBytes(System.Byte[])
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void NetRandom_NextBytes_mDD2FEE25E8FF5EA36A782DF48B217144D7C99078 (NetRandom_t5390B683E78A49E7984152B9490E6350D1D16AFB* __this, ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* ___buffer0, const RuntimeMethod* method) 
{
{
		// NextBytes(buffer, 0, buffer.Length);
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_0 = ___buffer0;
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_1 = ___buffer0;
		NullCheck(L_1);
		VirtualActionInvoker3< ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031*, int32_t, int32_t >::Invoke(12 /* System.Void Lidgren.Network.NetRandom::NextBytes(System.Byte[],System.Int32,System.Int32) */, __this, L_0, 0, ((int32_t)(((RuntimeArray*)L_1)->max_length)));
		// }
		return;
	}
}
// System.Void Lidgren.Network.NetRandom::.cctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void NetRandom__cctor_mA969D6F5DF479AAAB7AA266AE4DB8DF11A12CA50 (const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&MWCRandom_t2EE86D33187F701E26B088DA14D02651D83FAD76_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&NetRandom_t5390B683E78A49E7984152B9490E6350D1D16AFB_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
{
		// public static NetRandom Instance = new MWCRandom();
		MWCRandom_t2EE86D33187F701E26B088DA14D02651D83FAD76* L_0 = (MWCRandom_t2EE86D33187F701E26B088DA14D02651D83FAD76*)il2cpp_codegen_object_new(MWCRandom_t2EE86D33187F701E26B088DA14D02651D83FAD76_il2cpp_TypeInfo_var);
		MWCRandom__ctor_m2D267C4C249ACD895CDE0B00514D84FEDD3EC108(L_0, /*hidden argument*/NULL);
		((NetRandom_t5390B683E78A49E7984152B9490E6350D1D16AFB_StaticFields*)il2cpp_codegen_static_fields_for(NetRandom_t5390B683E78A49E7984152B9490E6350D1D16AFB_il2cpp_TypeInfo_var))->___Instance_8 = L_0;
		Il2CppCodeGenWriteBarrier((void**)(&((NetRandom_t5390B683E78A49E7984152B9490E6350D1D16AFB_StaticFields*)il2cpp_codegen_static_fields_for(NetRandom_t5390B683E78A49E7984152B9490E6350D1D16AFB_il2cpp_TypeInfo_var))->___Instance_8), (void*)L_0);
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
// System.Void Lidgren.Network.MWCRandom::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MWCRandom__ctor_m2D267C4C249ACD895CDE0B00514D84FEDD3EC108 (MWCRandom_t2EE86D33187F701E26B088DA14D02651D83FAD76* __this, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&NetRandomSeed_t78C4CD0A1F9754C7FC65DBE87A58F24C76419A8E_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&NetRandom_t5390B683E78A49E7984152B9490E6350D1D16AFB_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
{
		// public MWCRandom()
		il2cpp_codegen_runtime_class_init_inline(NetRandom_t5390B683E78A49E7984152B9490E6350D1D16AFB_il2cpp_TypeInfo_var);
		NetRandom__ctor_m371927707325556AFB04D38F4D17D48735D392D0(__this, NULL);
		// Initialize(NetRandomSeed.GetUInt64());
		il2cpp_codegen_runtime_class_init_inline(NetRandomSeed_t78C4CD0A1F9754C7FC65DBE87A58F24C76419A8E_il2cpp_TypeInfo_var);
		uint64_t L_0;
		L_0 = NetRandomSeed_GetUInt64_mE14600A3CD852496F75C3C1B96A6B1D51C0E78BB(NULL);
		MWCRandom_Initialize_m4F1CE0CE76FCF8373D746586F4CF318FED1A63C3(__this, L_0, NULL);
		// }
		return;
	}
}
// System.Void Lidgren.Network.MWCRandom::Initialize(System.UInt32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MWCRandom_Initialize_m587A3E1BF5C3FFCE0331167CEF7965A37607C4EA (MWCRandom_t2EE86D33187F701E26B088DA14D02651D83FAD76* __this, uint32_t ___seed0, const RuntimeMethod* method) 
{
{
		// m_w = seed;
		uint32_t L_0 = ___seed0;
		__this->___m_w_13 = L_0;
		// m_z = seed * 16777619;
		uint32_t L_1 = ___seed0;
		__this->___m_z_14 = ((int32_t)il2cpp_codegen_multiply((int32_t)L_1, ((int32_t)16777619)));
		// }
		return;
	}
}
// System.Void Lidgren.Network.MWCRandom::Initialize(System.UInt64)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MWCRandom_Initialize_m4F1CE0CE76FCF8373D746586F4CF318FED1A63C3 (MWCRandom_t2EE86D33187F701E26B088DA14D02651D83FAD76* __this, uint64_t ___seed0, const RuntimeMethod* method) 
{
{
		// m_w = (uint)seed;
		uint64_t L_0 = ___seed0;
		__this->___m_w_13 = ((int32_t)(uint32_t)L_0);
		// m_z = (uint)(seed >> 32);
		uint64_t L_1 = ___seed0;
		__this->___m_z_14 = ((int32_t)(uint32_t)((int64_t)((uint64_t)L_1>>((int32_t)32))));
		// }
		return;
	}
}
// System.UInt32 Lidgren.Network.MWCRandom::NextUInt32()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR uint32_t MWCRandom_NextUInt32_m35E2C623AE3268A70706BC6D09D0A242A8388C25 (MWCRandom_t2EE86D33187F701E26B088DA14D02651D83FAD76* __this, const RuntimeMethod* method) 
{
{
		// m_z = 36969 * (m_z & 65535) + (m_z >> 16);
		uint32_t L_0 = __this->___m_z_14;
		uint32_t L_1 = __this->___m_z_14;
		__this->___m_z_14 = ((int32_t)il2cpp_codegen_add(((int32_t)il2cpp_codegen_multiply(((int32_t)36969), ((int32_t)((int32_t)L_0&((int32_t)65535))))), ((int32_t)((uint32_t)L_1>>((int32_t)16)))));
		// m_w = 18000 * (m_w & 65535) + (m_w >> 16);
		uint32_t L_2 = __this->___m_w_13;
		uint32_t L_3 = __this->___m_w_13;
		__this->___m_w_13 = ((int32_t)il2cpp_codegen_add(((int32_t)il2cpp_codegen_multiply(((int32_t)18000), ((int32_t)((int32_t)L_2&((int32_t)65535))))), ((int32_t)((uint32_t)L_3>>((int32_t)16)))));
		// return ((m_z << 16) + m_w);
		uint32_t L_4 = __this->___m_z_14;
		uint32_t L_5 = __this->___m_w_13;
		return ((int32_t)il2cpp_codegen_add(((int32_t)((int32_t)L_4<<((int32_t)16))), (int32_t)L_5));
	}
}
// System.Void Lidgren.Network.MWCRandom::.cctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MWCRandom__cctor_m5F8B2A18B5529E4D92192B596BBA8CFD99E4BCBF (const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&MWCRandom_t2EE86D33187F701E26B088DA14D02651D83FAD76_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
{
		// public static new readonly MWCRandom Instance = new MWCRandom();
		MWCRandom_t2EE86D33187F701E26B088DA14D02651D83FAD76* L_0 = (MWCRandom_t2EE86D33187F701E26B088DA14D02651D83FAD76*)il2cpp_codegen_object_new(MWCRandom_t2EE86D33187F701E26B088DA14D02651D83FAD76_il2cpp_TypeInfo_var);
		MWCRandom__ctor_m2D267C4C249ACD895CDE0B00514D84FEDD3EC108(L_0, /*hidden argument*/NULL);
		((MWCRandom_t2EE86D33187F701E26B088DA14D02651D83FAD76_StaticFields*)il2cpp_codegen_static_fields_for(MWCRandom_t2EE86D33187F701E26B088DA14D02651D83FAD76_il2cpp_TypeInfo_var))->___Instance_12 = L_0;
		Il2CppCodeGenWriteBarrier((void**)(&((MWCRandom_t2EE86D33187F701E26B088DA14D02651D83FAD76_StaticFields*)il2cpp_codegen_static_fields_for(MWCRandom_t2EE86D33187F701E26B088DA14D02651D83FAD76_il2cpp_TypeInfo_var))->___Instance_12), (void*)L_0);
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
// System.Void Lidgren.Network.XorShiftRandom::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void XorShiftRandom__ctor_mF352EA59214000CA82A5E1ED2CC67819A6B0279E (XorShiftRandom_t31C7255ACBCD4E96B483B540560EE527FA28B908* __this, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&NetRandomSeed_t78C4CD0A1F9754C7FC65DBE87A58F24C76419A8E_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&NetRandom_t5390B683E78A49E7984152B9490E6350D1D16AFB_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
{
		// public XorShiftRandom()
		il2cpp_codegen_runtime_class_init_inline(NetRandom_t5390B683E78A49E7984152B9490E6350D1D16AFB_il2cpp_TypeInfo_var);
		NetRandom__ctor_m371927707325556AFB04D38F4D17D48735D392D0(__this, NULL);
		// Initialize(NetRandomSeed.GetUInt64());
		il2cpp_codegen_runtime_class_init_inline(NetRandomSeed_t78C4CD0A1F9754C7FC65DBE87A58F24C76419A8E_il2cpp_TypeInfo_var);
		uint64_t L_0;
		L_0 = NetRandomSeed_GetUInt64_mE14600A3CD852496F75C3C1B96A6B1D51C0E78BB(NULL);
		XorShiftRandom_Initialize_mB53E44BFE960A459C23B337B88C0C9E126CB7169(__this, L_0, NULL);
		// }
		return;
	}
}
// System.Void Lidgren.Network.XorShiftRandom::.ctor(System.UInt64)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void XorShiftRandom__ctor_m33F299835FBB20AF3D68062D450D65366B60CCF6 (XorShiftRandom_t31C7255ACBCD4E96B483B540560EE527FA28B908* __this, uint64_t ___seed0, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&NetRandom_t5390B683E78A49E7984152B9490E6350D1D16AFB_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
{
		// public XorShiftRandom(ulong seed)
		il2cpp_codegen_runtime_class_init_inline(NetRandom_t5390B683E78A49E7984152B9490E6350D1D16AFB_il2cpp_TypeInfo_var);
		NetRandom__ctor_m371927707325556AFB04D38F4D17D48735D392D0(__this, NULL);
		// Initialize(seed);
		uint64_t L_0 = ___seed0;
		XorShiftRandom_Initialize_mB53E44BFE960A459C23B337B88C0C9E126CB7169(__this, L_0, NULL);
		// }
		return;
	}
}
// System.Void Lidgren.Network.XorShiftRandom::Initialize(System.UInt32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void XorShiftRandom_Initialize_m5C9815A73E06E0890B7B7D483AFC37F356734116 (XorShiftRandom_t31C7255ACBCD4E96B483B540560EE527FA28B908* __this, uint32_t ___seed0, const RuntimeMethod* method) 
{
{
		// m_x = (uint)seed;
		uint32_t L_0 = ___seed0;
		__this->___m_x_17 = L_0;
		// m_y = c_y;
		__this->___m_y_18 = ((int32_t)362436069);
		// m_z = c_z;
		__this->___m_z_19 = ((int32_t)521288629);
		// m_w = c_w;
		__this->___m_w_20 = ((int32_t)88675123);
		// }
		return;
	}
}
// System.Void Lidgren.Network.XorShiftRandom::Initialize(System.UInt64)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void XorShiftRandom_Initialize_mB53E44BFE960A459C23B337B88C0C9E126CB7169 (XorShiftRandom_t31C7255ACBCD4E96B483B540560EE527FA28B908* __this, uint64_t ___seed0, const RuntimeMethod* method) 
{
{
		// m_x = (uint)seed;
		uint64_t L_0 = ___seed0;
		__this->___m_x_17 = ((int32_t)(uint32_t)L_0);
		// m_y = c_y;
		__this->___m_y_18 = ((int32_t)362436069);
		// m_z = (uint)(seed << 32);
		uint64_t L_1 = ___seed0;
		__this->___m_z_19 = ((int32_t)(uint32_t)((int64_t)((int64_t)L_1<<((int32_t)32))));
		// m_w = c_w;
		__this->___m_w_20 = ((int32_t)88675123);
		// }
		return;
	}
}
// System.UInt32 Lidgren.Network.XorShiftRandom::NextUInt32()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR uint32_t XorShiftRandom_NextUInt32_m9A61322A0E34AC5281CBFD3CB5F67C77472CB378 (XorShiftRandom_t31C7255ACBCD4E96B483B540560EE527FA28B908* __this, const RuntimeMethod* method) 
{
uint32_t V_0 = 0;
	uint32_t V_1 = 0;
	{
		// uint t = (m_x ^ (m_x << 11));
		uint32_t L_0 = __this->___m_x_17;
		uint32_t L_1 = __this->___m_x_17;
		V_0 = ((int32_t)((int32_t)L_0^((int32_t)((int32_t)L_1<<((int32_t)11)))));
		// m_x = m_y; m_y = m_z; m_z = m_w;
		uint32_t L_2 = __this->___m_y_18;
		__this->___m_x_17 = L_2;
		// m_x = m_y; m_y = m_z; m_z = m_w;
		uint32_t L_3 = __this->___m_z_19;
		__this->___m_y_18 = L_3;
		// m_x = m_y; m_y = m_z; m_z = m_w;
		uint32_t L_4 = __this->___m_w_20;
		__this->___m_z_19 = L_4;
		// return (m_w = (m_w ^ (m_w >> 19)) ^ (t ^ (t >> 8)));
		uint32_t L_5 = __this->___m_w_20;
		uint32_t L_6 = __this->___m_w_20;
		uint32_t L_7 = V_0;
		uint32_t L_8 = V_0;
		int32_t L_9 = ((int32_t)(((int32_t)((int32_t)L_5^((int32_t)((uint32_t)L_6>>((int32_t)19)))))^((int32_t)((int32_t)L_7^((int32_t)((uint32_t)L_8>>8))))));
		V_1 = L_9;
		__this->___m_w_20 = L_9;
		uint32_t L_10 = V_1;
		return L_10;
	}
}
// System.Void Lidgren.Network.XorShiftRandom::.cctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void XorShiftRandom__cctor_m85C827914587B682BF2B91FCAFEC11D5A917426C (const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&XorShiftRandom_t31C7255ACBCD4E96B483B540560EE527FA28B908_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
{
		// public static new readonly XorShiftRandom Instance = new XorShiftRandom();
		XorShiftRandom_t31C7255ACBCD4E96B483B540560EE527FA28B908* L_0 = (XorShiftRandom_t31C7255ACBCD4E96B483B540560EE527FA28B908*)il2cpp_codegen_object_new(XorShiftRandom_t31C7255ACBCD4E96B483B540560EE527FA28B908_il2cpp_TypeInfo_var);
		XorShiftRandom__ctor_mF352EA59214000CA82A5E1ED2CC67819A6B0279E(L_0, /*hidden argument*/NULL);
		((XorShiftRandom_t31C7255ACBCD4E96B483B540560EE527FA28B908_StaticFields*)il2cpp_codegen_static_fields_for(XorShiftRandom_t31C7255ACBCD4E96B483B540560EE527FA28B908_il2cpp_TypeInfo_var))->___Instance_12 = L_0;
		Il2CppCodeGenWriteBarrier((void**)(&((XorShiftRandom_t31C7255ACBCD4E96B483B540560EE527FA28B908_StaticFields*)il2cpp_codegen_static_fields_for(XorShiftRandom_t31C7255ACBCD4E96B483B540560EE527FA28B908_il2cpp_TypeInfo_var))->___Instance_12), (void*)L_0);
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
// System.Void Lidgren.Network.MersenneTwisterRandom::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MersenneTwisterRandom__ctor_m6348FA455B457FF95EB7AC6F879DEE4798DF6C2F (MersenneTwisterRandom_tF01E9C0FB95208029F72ED8DC92F000E172E71CA* __this, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&NetRandomSeed_t78C4CD0A1F9754C7FC65DBE87A58F24C76419A8E_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&NetRandom_t5390B683E78A49E7984152B9490E6350D1D16AFB_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
{
		// public MersenneTwisterRandom()
		il2cpp_codegen_runtime_class_init_inline(NetRandom_t5390B683E78A49E7984152B9490E6350D1D16AFB_il2cpp_TypeInfo_var);
		NetRandom__ctor_m371927707325556AFB04D38F4D17D48735D392D0(__this, NULL);
		// Initialize(NetRandomSeed.GetUInt32());
		il2cpp_codegen_runtime_class_init_inline(NetRandomSeed_t78C4CD0A1F9754C7FC65DBE87A58F24C76419A8E_il2cpp_TypeInfo_var);
		uint32_t L_0;
		L_0 = NetRandomSeed_GetUInt32_m848FE5010D207F240BB352D9E5B17B287C9FB8FD(NULL);
		VirtualActionInvoker1< uint32_t >::Invoke(10 /* System.Void Lidgren.Network.NetRandom::Initialize(System.UInt32) */, __this, L_0);
		// }
		return;
	}
}
// System.Void Lidgren.Network.MersenneTwisterRandom::.ctor(System.UInt32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MersenneTwisterRandom__ctor_mFD3C62F0188AC89B9993B46B85C59997B85DB3B0 (MersenneTwisterRandom_tF01E9C0FB95208029F72ED8DC92F000E172E71CA* __this, uint32_t ___seed0, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&NetRandom_t5390B683E78A49E7984152B9490E6350D1D16AFB_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
{
		// public MersenneTwisterRandom(uint seed)
		il2cpp_codegen_runtime_class_init_inline(NetRandom_t5390B683E78A49E7984152B9490E6350D1D16AFB_il2cpp_TypeInfo_var);
		NetRandom__ctor_m371927707325556AFB04D38F4D17D48735D392D0(__this, NULL);
		// Initialize(seed);
		uint32_t L_0 = ___seed0;
		VirtualActionInvoker1< uint32_t >::Invoke(10 /* System.Void Lidgren.Network.NetRandom::Initialize(System.UInt32) */, __this, L_0);
		// }
		return;
	}
}
// System.Void Lidgren.Network.MersenneTwisterRandom::Initialize(System.UInt32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MersenneTwisterRandom_Initialize_m919691DC6BB4404D0029D6F3B6FA4BC777DC6A8E (MersenneTwisterRandom_tF01E9C0FB95208029F72ED8DC92F000E172E71CA* __this, uint32_t ___seed0, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&UInt32U5BU5D_t02FBD658AD156A17574ECE6106CF1FBFCC9807FA_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
int32_t V_0 = 0;
	{
		// mt = new UInt32[N];
		UInt32U5BU5D_t02FBD658AD156A17574ECE6106CF1FBFCC9807FA* L_0 = (UInt32U5BU5D_t02FBD658AD156A17574ECE6106CF1FBFCC9807FA*)(UInt32U5BU5D_t02FBD658AD156A17574ECE6106CF1FBFCC9807FA*)SZArrayNew(UInt32U5BU5D_t02FBD658AD156A17574ECE6106CF1FBFCC9807FA_il2cpp_TypeInfo_var, (uint32_t)((int32_t)624));
		__this->___mt_24 = L_0;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___mt_24), (void*)L_0);
		// mti = N + 1;
		__this->___mti_25 = ((int32_t)625);
		// mag01 = new UInt32[] { 0x0U, MATRIX_A };
		UInt32U5BU5D_t02FBD658AD156A17574ECE6106CF1FBFCC9807FA* L_1 = (UInt32U5BU5D_t02FBD658AD156A17574ECE6106CF1FBFCC9807FA*)(UInt32U5BU5D_t02FBD658AD156A17574ECE6106CF1FBFCC9807FA*)SZArrayNew(UInt32U5BU5D_t02FBD658AD156A17574ECE6106CF1FBFCC9807FA_il2cpp_TypeInfo_var, (uint32_t)2);
		UInt32U5BU5D_t02FBD658AD156A17574ECE6106CF1FBFCC9807FA* L_2 = L_1;
		NullCheck(L_2);
		(L_2)->SetAt(static_cast<il2cpp_array_size_t>(1), (uint32_t)((int32_t)-1727483681));
		__this->___mag01_26 = L_2;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___mag01_26), (void*)L_2);
		// mt[0] = seed;
		UInt32U5BU5D_t02FBD658AD156A17574ECE6106CF1FBFCC9807FA* L_3 = __this->___mt_24;
		uint32_t L_4 = ___seed0;
		NullCheck(L_3);
		(L_3)->SetAt(static_cast<il2cpp_array_size_t>(0), (uint32_t)L_4);
		// for (int i = 1; i < N; i++)
		V_0 = 1;
		goto IL_006b;
	}

IL_003c:
	{
		// mt[i] = (UInt32)(1812433253 * (mt[i - 1] ^ (mt[i - 1] >> 30)) + i);
		UInt32U5BU5D_t02FBD658AD156A17574ECE6106CF1FBFCC9807FA* L_5 = __this->___mt_24;
		int32_t L_6 = V_0;
		UInt32U5BU5D_t02FBD658AD156A17574ECE6106CF1FBFCC9807FA* L_7 = __this->___mt_24;
		int32_t L_8 = V_0;
		NullCheck(L_7);
		int32_t L_9 = ((int32_t)il2cpp_codegen_subtract(L_8, 1));
		uint32_t L_10 = (L_7)->GetAt(static_cast<il2cpp_array_size_t>(L_9));
		UInt32U5BU5D_t02FBD658AD156A17574ECE6106CF1FBFCC9807FA* L_11 = __this->___mt_24;
		int32_t L_12 = V_0;
		NullCheck(L_11);
		int32_t L_13 = ((int32_t)il2cpp_codegen_subtract(L_12, 1));
		uint32_t L_14 = (L_11)->GetAt(static_cast<il2cpp_array_size_t>(L_13));
		int32_t L_15 = V_0;
		NullCheck(L_5);
		(L_5)->SetAt(static_cast<il2cpp_array_size_t>(L_6), (uint32_t)((int32_t)(uint32_t)((int64_t)il2cpp_codegen_add(((int64_t)(uint64_t)((uint32_t)((int32_t)il2cpp_codegen_multiply(((int32_t)1812433253), ((int32_t)((int32_t)L_10^((int32_t)((uint32_t)L_14>>((int32_t)30))))))))), ((int64_t)L_15)))));
		// for (int i = 1; i < N; i++)
		int32_t L_16 = V_0;
		V_0 = ((int32_t)il2cpp_codegen_add(L_16, 1));
	}

IL_006b:
	{
		// for (int i = 1; i < N; i++)
		int32_t L_17 = V_0;
		if ((((int32_t)L_17) < ((int32_t)((int32_t)624))))
		{
			goto IL_003c;
		}
	}
	{
		// }
		return;
	}
}
// System.UInt32 Lidgren.Network.MersenneTwisterRandom::NextUInt32()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR uint32_t MersenneTwisterRandom_NextUInt32_mD8E258FA54CACE8CBE3E30BEC54B7130E99688E6 (MersenneTwisterRandom_tF01E9C0FB95208029F72ED8DC92F000E172E71CA* __this, const RuntimeMethod* method) 
{
int32_t V_0 = 0;
	{
		// if (mti >= N)
		int32_t L_0 = __this->___mti_25;
		if ((((int32_t)L_0) < ((int32_t)((int32_t)624))))
		{
			goto IL_001a;
		}
	}
	{
		// GenRandAll();
		MersenneTwisterRandom_GenRandAll_mC375DED013572C410FFF79153615ECD0C9F71EF3(__this, NULL);
		// mti = 0;
		__this->___mti_25 = 0;
	}

IL_001a:
	{
		// y = mt[mti++];
		UInt32U5BU5D_t02FBD658AD156A17574ECE6106CF1FBFCC9807FA* L_1 = __this->___mt_24;
		int32_t L_2 = __this->___mti_25;
		V_0 = L_2;
		int32_t L_3 = V_0;
		__this->___mti_25 = ((int32_t)il2cpp_codegen_add(L_3, 1));
		int32_t L_4 = V_0;
		NullCheck(L_1);
		int32_t L_5 = L_4;
		uint32_t L_6 = (L_1)->GetAt(static_cast<il2cpp_array_size_t>(L_5));
		// y ^= (y >> TEMPER3);
		uint32_t L_7 = L_6;
		// y ^= (y << TEMPER4) & TEMPER1;
		int32_t L_8 = ((int32_t)((int32_t)L_7^((int32_t)((uint32_t)L_7>>((int32_t)11)))));
		// y ^= (y << TEMPER5) & TEMPER2;
		int32_t L_9 = ((int32_t)(L_8^((int32_t)(((int32_t)(L_8<<7))&((int32_t)-1658038656)))));
		// y ^= (y >> TEMPER6);
		int32_t L_10 = ((int32_t)(L_9^((int32_t)(((int32_t)(L_9<<((int32_t)15)))&((int32_t)-272236544)))));
		// return y;
		return ((int32_t)(L_10^((int32_t)((uint32_t)L_10>>((int32_t)18)))));
	}
}
// System.Void Lidgren.Network.MersenneTwisterRandom::GenRandAll()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MersenneTwisterRandom_GenRandAll_mC375DED013572C410FFF79153615ECD0C9F71EF3 (MersenneTwisterRandom_tF01E9C0FB95208029F72ED8DC92F000E172E71CA* __this, const RuntimeMethod* method) 
{
int32_t V_0 = 0;
	uint32_t V_1 = 0;
	uint32_t V_2 = 0;
	{
		// int kk = 1;
		V_0 = 1;
		// y = mt[0] & UPPER_MASK;
		UInt32U5BU5D_t02FBD658AD156A17574ECE6106CF1FBFCC9807FA* L_0 = __this->___mt_24;
		NullCheck(L_0);
		int32_t L_1 = 0;
		uint32_t L_2 = (L_0)->GetAt(static_cast<il2cpp_array_size_t>(L_1));
		V_1 = ((int32_t)((int32_t)L_2&((int32_t)-2147483648LL)));
	}

IL_0011:
	{
		// p = mt[kk];
		UInt32U5BU5D_t02FBD658AD156A17574ECE6106CF1FBFCC9807FA* L_3 = __this->___mt_24;
		int32_t L_4 = V_0;
		NullCheck(L_3);
		int32_t L_5 = L_4;
		uint32_t L_6 = (L_3)->GetAt(static_cast<il2cpp_array_size_t>(L_5));
		V_2 = L_6;
		// mt[kk - 1] = mt[kk + (M - 1)] ^ ((y | (p & LOWER_MASK)) >> 1) ^ mag01[p & 1];
		UInt32U5BU5D_t02FBD658AD156A17574ECE6106CF1FBFCC9807FA* L_7 = __this->___mt_24;
		int32_t L_8 = V_0;
		UInt32U5BU5D_t02FBD658AD156A17574ECE6106CF1FBFCC9807FA* L_9 = __this->___mt_24;
		int32_t L_10 = V_0;
		NullCheck(L_9);
		int32_t L_11 = ((int32_t)il2cpp_codegen_add(L_10, ((int32_t)396)));
		uint32_t L_12 = (L_9)->GetAt(static_cast<il2cpp_array_size_t>(L_11));
		uint32_t L_13 = V_1;
		uint32_t L_14 = V_2;
		UInt32U5BU5D_t02FBD658AD156A17574ECE6106CF1FBFCC9807FA* L_15 = __this->___mag01_26;
		uint32_t L_16 = V_2;
		NullCheck(L_15);
		int32_t L_17 = ((int32_t)((int32_t)L_16&1));
		uint32_t L_18 = (L_15)->GetAt(static_cast<il2cpp_array_size_t>(L_17));
		NullCheck(L_7);
		(L_7)->SetAt(static_cast<il2cpp_array_size_t>(((int32_t)il2cpp_codegen_subtract(L_8, 1))), (uint32_t)((int32_t)(((int32_t)((int32_t)L_12^((int32_t)((uint32_t)((int32_t)((int32_t)L_13|((int32_t)((int32_t)L_14&((int32_t)2147483647LL)))))>>1))))^(int32_t)L_18)));
		// y = p & UPPER_MASK;
		uint32_t L_19 = V_2;
		V_1 = ((int32_t)((int32_t)L_19&((int32_t)-2147483648LL)));
		// } while (++kk < N - M + 1);
		int32_t L_20 = V_0;
		int32_t L_21 = ((int32_t)il2cpp_codegen_add(L_20, 1));
		V_0 = L_21;
		if ((((int32_t)L_21) < ((int32_t)((int32_t)228))))
		{
			goto IL_0011;
		}
	}

IL_005d:
	{
		// p = mt[kk];
		UInt32U5BU5D_t02FBD658AD156A17574ECE6106CF1FBFCC9807FA* L_22 = __this->___mt_24;
		int32_t L_23 = V_0;
		NullCheck(L_22);
		int32_t L_24 = L_23;
		uint32_t L_25 = (L_22)->GetAt(static_cast<il2cpp_array_size_t>(L_24));
		V_2 = L_25;
		// mt[kk - 1] = mt[kk + (M - N - 1)] ^ ((y | (p & LOWER_MASK)) >> 1) ^ mag01[p & 1];
		UInt32U5BU5D_t02FBD658AD156A17574ECE6106CF1FBFCC9807FA* L_26 = __this->___mt_24;
		int32_t L_27 = V_0;
		UInt32U5BU5D_t02FBD658AD156A17574ECE6106CF1FBFCC9807FA* L_28 = __this->___mt_24;
		int32_t L_29 = V_0;
		NullCheck(L_28);
		int32_t L_30 = ((int32_t)il2cpp_codegen_add(L_29, ((int32_t)-228)));
		uint32_t L_31 = (L_28)->GetAt(static_cast<il2cpp_array_size_t>(L_30));
		uint32_t L_32 = V_1;
		uint32_t L_33 = V_2;
		UInt32U5BU5D_t02FBD658AD156A17574ECE6106CF1FBFCC9807FA* L_34 = __this->___mag01_26;
		uint32_t L_35 = V_2;
		NullCheck(L_34);
		int32_t L_36 = ((int32_t)((int32_t)L_35&1));
		uint32_t L_37 = (L_34)->GetAt(static_cast<il2cpp_array_size_t>(L_36));
		NullCheck(L_26);
		(L_26)->SetAt(static_cast<il2cpp_array_size_t>(((int32_t)il2cpp_codegen_subtract(L_27, 1))), (uint32_t)((int32_t)(((int32_t)((int32_t)L_31^((int32_t)((uint32_t)((int32_t)((int32_t)L_32|((int32_t)((int32_t)L_33&((int32_t)2147483647LL)))))>>1))))^(int32_t)L_37)));
		// y = p & UPPER_MASK;
		uint32_t L_38 = V_2;
		V_1 = ((int32_t)((int32_t)L_38&((int32_t)-2147483648LL)));
		// } while (++kk < N);
		int32_t L_39 = V_0;
		int32_t L_40 = ((int32_t)il2cpp_codegen_add(L_39, 1));
		V_0 = L_40;
		if ((((int32_t)L_40) < ((int32_t)((int32_t)624))))
		{
			goto IL_005d;
		}
	}
	{
		// p = mt[0];
		UInt32U5BU5D_t02FBD658AD156A17574ECE6106CF1FBFCC9807FA* L_41 = __this->___mt_24;
		NullCheck(L_41);
		int32_t L_42 = 0;
		uint32_t L_43 = (L_41)->GetAt(static_cast<il2cpp_array_size_t>(L_42));
		V_2 = L_43;
		// mt[N - 1] = mt[M - 1] ^ ((y | (p & LOWER_MASK)) >> 1) ^ mag01[p & 1];
		UInt32U5BU5D_t02FBD658AD156A17574ECE6106CF1FBFCC9807FA* L_44 = __this->___mt_24;
		UInt32U5BU5D_t02FBD658AD156A17574ECE6106CF1FBFCC9807FA* L_45 = __this->___mt_24;
		NullCheck(L_45);
		int32_t L_46 = ((int32_t)396);
		uint32_t L_47 = (L_45)->GetAt(static_cast<il2cpp_array_size_t>(L_46));
		uint32_t L_48 = V_1;
		uint32_t L_49 = V_2;
		UInt32U5BU5D_t02FBD658AD156A17574ECE6106CF1FBFCC9807FA* L_50 = __this->___mag01_26;
		uint32_t L_51 = V_2;
		NullCheck(L_50);
		int32_t L_52 = ((int32_t)((int32_t)L_51&1));
		uint32_t L_53 = (L_50)->GetAt(static_cast<il2cpp_array_size_t>(L_52));
		NullCheck(L_44);
		(L_44)->SetAt(static_cast<il2cpp_array_size_t>(((int32_t)623)), (uint32_t)((int32_t)(((int32_t)((int32_t)L_47^((int32_t)((uint32_t)((int32_t)((int32_t)L_48|((int32_t)((int32_t)L_49&((int32_t)2147483647LL)))))>>1))))^(int32_t)L_53)));
		// }
		return;
	}
}
// System.Void Lidgren.Network.MersenneTwisterRandom::.cctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MersenneTwisterRandom__cctor_m88833BA0EE88C3A149EE105D55433F9630A51EE0 (const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&MersenneTwisterRandom_tF01E9C0FB95208029F72ED8DC92F000E172E71CA_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
{
		// public static new readonly MersenneTwisterRandom Instance = new MersenneTwisterRandom();
		MersenneTwisterRandom_tF01E9C0FB95208029F72ED8DC92F000E172E71CA* L_0 = (MersenneTwisterRandom_tF01E9C0FB95208029F72ED8DC92F000E172E71CA*)il2cpp_codegen_object_new(MersenneTwisterRandom_tF01E9C0FB95208029F72ED8DC92F000E172E71CA_il2cpp_TypeInfo_var);
		MersenneTwisterRandom__ctor_m6348FA455B457FF95EB7AC6F879DEE4798DF6C2F(L_0, /*hidden argument*/NULL);
		((MersenneTwisterRandom_tF01E9C0FB95208029F72ED8DC92F000E172E71CA_StaticFields*)il2cpp_codegen_static_fields_for(MersenneTwisterRandom_tF01E9C0FB95208029F72ED8DC92F000E172E71CA_il2cpp_TypeInfo_var))->___Instance_12 = L_0;
		Il2CppCodeGenWriteBarrier((void**)(&((MersenneTwisterRandom_tF01E9C0FB95208029F72ED8DC92F000E172E71CA_StaticFields*)il2cpp_codegen_static_fields_for(MersenneTwisterRandom_tF01E9C0FB95208029F72ED8DC92F000E172E71CA_il2cpp_TypeInfo_var))->___Instance_12), (void*)L_0);
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
// System.Void Lidgren.Network.CryptoRandom::Initialize(System.UInt32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void CryptoRandom_Initialize_m7E3EDCB399F5920B71CE7C2905D54D2D19963097 (CryptoRandom_t8B21DF8737471EFF3D15D1ACB0AF83ABA4A600B8* __this, uint32_t ___seed0, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* V_0 = NULL;
	{
		// byte[] tmp = new byte[seed % 16];
		uint32_t L_0 = ___seed0;
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_1 = (ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031*)(ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031*)SZArrayNew(ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031_il2cpp_TypeInfo_var, (uint32_t)((int32_t)((uint32_t)(int32_t)L_0%(uint32_t)(int32_t)((int32_t)16))));
		V_0 = L_1;
		// m_rnd.GetBytes(tmp); // just prime it
		RandomNumberGenerator_t4E862666A2F7D55324960670C7A1B4C2D40222F3* L_2 = __this->___m_rnd_13;
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_3 = V_0;
		NullCheck(L_2);
		VirtualActionInvoker1< ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* >::Invoke(6 /* System.Void System.Security.Cryptography.RandomNumberGenerator::GetBytes(System.Byte[]) */, L_2, L_3);
		// }
		return;
	}
}
// System.UInt32 Lidgren.Network.CryptoRandom::NextUInt32()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR uint32_t CryptoRandom_NextUInt32_m8E36A81F8C09FF1908B14129F11005253DFF647D (CryptoRandom_t8B21DF8737471EFF3D15D1ACB0AF83ABA4A600B8* __this, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* V_0 = NULL;
	{
		// var bytes = new byte[4];
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_0 = (ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031*)(ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031*)SZArrayNew(ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031_il2cpp_TypeInfo_var, (uint32_t)4);
		V_0 = L_0;
		// m_rnd.GetBytes(bytes);
		RandomNumberGenerator_t4E862666A2F7D55324960670C7A1B4C2D40222F3* L_1 = __this->___m_rnd_13;
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_2 = V_0;
		NullCheck(L_1);
		VirtualActionInvoker1< ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* >::Invoke(6 /* System.Void System.Security.Cryptography.RandomNumberGenerator::GetBytes(System.Byte[]) */, L_1, L_2);
		// return (uint)bytes[0] | (((uint)bytes[1]) << 8) | (((uint)bytes[2]) << 16) | (((uint)bytes[3]) << 24);
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_3 = V_0;
		NullCheck(L_3);
		int32_t L_4 = 0;
		uint8_t L_5 = (L_3)->GetAt(static_cast<il2cpp_array_size_t>(L_4));
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_6 = V_0;
		NullCheck(L_6);
		int32_t L_7 = 1;
		uint8_t L_8 = (L_6)->GetAt(static_cast<il2cpp_array_size_t>(L_7));
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_9 = V_0;
		NullCheck(L_9);
		int32_t L_10 = 2;
		uint8_t L_11 = (L_9)->GetAt(static_cast<il2cpp_array_size_t>(L_10));
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_12 = V_0;
		NullCheck(L_12);
		int32_t L_13 = 3;
		uint8_t L_14 = (L_12)->GetAt(static_cast<il2cpp_array_size_t>(L_13));
		return ((int32_t)(((int32_t)(((int32_t)((int32_t)L_5|((int32_t)((int32_t)L_8<<8))))|((int32_t)((int32_t)L_11<<((int32_t)16)))))|((int32_t)((int32_t)L_14<<((int32_t)24)))));
	}
}
// System.Void Lidgren.Network.CryptoRandom::NextBytes(System.Byte[])
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void CryptoRandom_NextBytes_m876226B1DACDF24164193AF037C79535CE532EA9 (CryptoRandom_t8B21DF8737471EFF3D15D1ACB0AF83ABA4A600B8* __this, ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* ___buffer0, const RuntimeMethod* method) 
{
{
		// m_rnd.GetBytes(buffer);
		RandomNumberGenerator_t4E862666A2F7D55324960670C7A1B4C2D40222F3* L_0 = __this->___m_rnd_13;
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_1 = ___buffer0;
		NullCheck(L_0);
		VirtualActionInvoker1< ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* >::Invoke(6 /* System.Void System.Security.Cryptography.RandomNumberGenerator::GetBytes(System.Byte[]) */, L_0, L_1);
		// }
		return;
	}
}
// System.Void Lidgren.Network.CryptoRandom::NextBytes(System.Byte[],System.Int32,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void CryptoRandom_NextBytes_m27E5F4460DB1C1EF964EA1A9B121B8CD8F56022B (CryptoRandom_t8B21DF8737471EFF3D15D1ACB0AF83ABA4A600B8* __this, ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* ___buffer0, int32_t ___offset1, int32_t ___length2, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* V_0 = NULL;
	{
		// var bytes = new byte[length];
		int32_t L_0 = ___length2;
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_1 = (ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031*)(ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031*)SZArrayNew(ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031_il2cpp_TypeInfo_var, (uint32_t)L_0);
		V_0 = L_1;
		// m_rnd.GetBytes(bytes);
		RandomNumberGenerator_t4E862666A2F7D55324960670C7A1B4C2D40222F3* L_2 = __this->___m_rnd_13;
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_3 = V_0;
		NullCheck(L_2);
		VirtualActionInvoker1< ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* >::Invoke(6 /* System.Void System.Security.Cryptography.RandomNumberGenerator::GetBytes(System.Byte[]) */, L_2, L_3);
		// Array.Copy(bytes, 0, buffer, offset, length);
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_4 = V_0;
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_5 = ___buffer0;
		int32_t L_6 = ___offset1;
		int32_t L_7 = ___length2;
		Array_Copy_m2CC3EA1129E9B8EA82E6FA31EDE0D4F87BF67EC7((RuntimeArray*)L_4, 0, (RuntimeArray*)L_5, L_6, L_7, NULL);
		// }
		return;
	}
}
// System.Void Lidgren.Network.CryptoRandom::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void CryptoRandom__ctor_mD1708CB734A0C0BCD157E64B5B4E969D2B439AE1 (CryptoRandom_t8B21DF8737471EFF3D15D1ACB0AF83ABA4A600B8* __this, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&NetRandom_t5390B683E78A49E7984152B9490E6350D1D16AFB_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&RNGCryptoServiceProvider_tAD9D75EFF3D2ED0929EEE27A53BE82AB83D78170_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
{
		// private RandomNumberGenerator m_rnd = new RNGCryptoServiceProvider();
		RNGCryptoServiceProvider_tAD9D75EFF3D2ED0929EEE27A53BE82AB83D78170* L_0 = (RNGCryptoServiceProvider_tAD9D75EFF3D2ED0929EEE27A53BE82AB83D78170*)il2cpp_codegen_object_new(RNGCryptoServiceProvider_tAD9D75EFF3D2ED0929EEE27A53BE82AB83D78170_il2cpp_TypeInfo_var);
		RNGCryptoServiceProvider__ctor_m605146E692C0209B3FFE83F7AC94335CA089CA09(L_0, /*hidden argument*/NULL);
		__this->___m_rnd_13 = L_0;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___m_rnd_13), (void*)L_0);
		il2cpp_codegen_runtime_class_init_inline(NetRandom_t5390B683E78A49E7984152B9490E6350D1D16AFB_il2cpp_TypeInfo_var);
		NetRandom__ctor_m371927707325556AFB04D38F4D17D48735D392D0(__this, NULL);
		return;
	}
}
// System.Void Lidgren.Network.CryptoRandom::.cctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void CryptoRandom__cctor_m28F323CEC4F7D615CC3FBEBAFC1DE314E1AF49AA (const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&CryptoRandom_t8B21DF8737471EFF3D15D1ACB0AF83ABA4A600B8_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
{
		// public static new readonly CryptoRandom Instance = new CryptoRandom();
		CryptoRandom_t8B21DF8737471EFF3D15D1ACB0AF83ABA4A600B8* L_0 = (CryptoRandom_t8B21DF8737471EFF3D15D1ACB0AF83ABA4A600B8*)il2cpp_codegen_object_new(CryptoRandom_t8B21DF8737471EFF3D15D1ACB0AF83ABA4A600B8_il2cpp_TypeInfo_var);
		CryptoRandom__ctor_mD1708CB734A0C0BCD157E64B5B4E969D2B439AE1(L_0, /*hidden argument*/NULL);
		((CryptoRandom_t8B21DF8737471EFF3D15D1ACB0AF83ABA4A600B8_StaticFields*)il2cpp_codegen_static_fields_for(CryptoRandom_t8B21DF8737471EFF3D15D1ACB0AF83ABA4A600B8_il2cpp_TypeInfo_var))->___Instance_12 = L_0;
		Il2CppCodeGenWriteBarrier((void**)(&((CryptoRandom_t8B21DF8737471EFF3D15D1ACB0AF83ABA4A600B8_StaticFields*)il2cpp_codegen_static_fields_for(CryptoRandom_t8B21DF8737471EFF3D15D1ACB0AF83ABA4A600B8_il2cpp_TypeInfo_var))->___Instance_12), (void*)L_0);
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
// System.UInt32 Lidgren.Network.NetRandomSeed::GetUInt32()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR uint32_t NetRandomSeed_GetUInt32_m848FE5010D207F240BB352D9E5B17B287C9FB8FD (const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&NetRandomSeed_t78C4CD0A1F9754C7FC65DBE87A58F24C76419A8E_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
uint32_t V_0 = 0;
	uint32_t V_1 = 0;
	{
		// ulong seed = GetUInt64();
		il2cpp_codegen_runtime_class_init_inline(NetRandomSeed_t78C4CD0A1F9754C7FC65DBE87A58F24C76419A8E_il2cpp_TypeInfo_var);
		uint64_t L_0;
		L_0 = NetRandomSeed_GetUInt64_mE14600A3CD852496F75C3C1B96A6B1D51C0E78BB(NULL);
		// uint low = (uint)seed;
		uint64_t L_1 = L_0;
		V_0 = ((int32_t)(uint32_t)L_1);
		// uint high = (uint)(seed >> 32);
		V_1 = ((int32_t)(uint32_t)((int64_t)((uint64_t)L_1>>((int32_t)32))));
		// return low ^ high;
		uint32_t L_2 = V_0;
		uint32_t L_3 = V_1;
		return ((int32_t)((int32_t)L_2^(int32_t)L_3));
	}
}
// System.UInt64 Lidgren.Network.NetRandomSeed::GetUInt64()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR uint64_t NetRandomSeed_GetUInt64_mE14600A3CD852496F75C3C1B96A6B1D51C0E78BB (const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&NetRandomSeed_t78C4CD0A1F9754C7FC65DBE87A58F24C76419A8E_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&NetUtility_t0B01E9514810CE3FC3B5E83D8427CBA1C5689EFD_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* V_0 = NULL;
	Guid_t V_1;
	memset((&V_1), 0, sizeof(V_1));
	{
		// var guidBytes = Guid.NewGuid().ToByteArray();
		Guid_t L_0;
		L_0 = Guid_NewGuid_m1827D92D71326C3F3C263F057F6E90F907617903(NULL);
		V_1 = L_0;
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_1;
		L_1 = Guid_ToByteArray_m6EBFB2F42D3760D9143050A3A8ED03F085F3AFE9((&V_1), NULL);
		V_0 = L_1;
		// ulong seed =
		//     ((ulong)guidBytes[0] << (8 * 0)) |
		//     ((ulong)guidBytes[1] << (8 * 1)) |
		//     ((ulong)guidBytes[2] << (8 * 2)) |
		//     ((ulong)guidBytes[3] << (8 * 3)) |
		//     ((ulong)guidBytes[4] << (8 * 4)) |
		//     ((ulong)guidBytes[5] << (8 * 5)) |
		//     ((ulong)guidBytes[6] << (8 * 6)) |
		//     ((ulong)guidBytes[7] << (8 * 7));
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
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_14 = V_0;
		NullCheck(L_14);
		int32_t L_15 = 4;
		uint8_t L_16 = (L_14)->GetAt(static_cast<il2cpp_array_size_t>(L_15));
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_17 = V_0;
		NullCheck(L_17);
		int32_t L_18 = 5;
		uint8_t L_19 = (L_17)->GetAt(static_cast<il2cpp_array_size_t>(L_18));
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_20 = V_0;
		NullCheck(L_20);
		int32_t L_21 = 6;
		uint8_t L_22 = (L_20)->GetAt(static_cast<il2cpp_array_size_t>(L_21));
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_23 = V_0;
		NullCheck(L_23);
		int32_t L_24 = 7;
		uint8_t L_25 = (L_23)->GetAt(static_cast<il2cpp_array_size_t>(L_24));
		// return seed ^ NetUtility.GetPlatformSeed(m_seedIncrement);
		il2cpp_codegen_runtime_class_init_inline(NetRandomSeed_t78C4CD0A1F9754C7FC65DBE87A58F24C76419A8E_il2cpp_TypeInfo_var);
		int32_t L_26 = ((NetRandomSeed_t78C4CD0A1F9754C7FC65DBE87A58F24C76419A8E_StaticFields*)il2cpp_codegen_static_fields_for(NetRandomSeed_t78C4CD0A1F9754C7FC65DBE87A58F24C76419A8E_il2cpp_TypeInfo_var))->___m_seedIncrement_0;
		il2cpp_codegen_runtime_class_init_inline(NetUtility_t0B01E9514810CE3FC3B5E83D8427CBA1C5689EFD_il2cpp_TypeInfo_var);
		uint64_t L_27;
		L_27 = NetUtility_GetPlatformSeed_m20045B31AFAF8B71FD6EE27BA9B05CE46AF9C32A(L_26, NULL);
		return ((int64_t)(((int64_t)(((int64_t)(((int64_t)(((int64_t)(((int64_t)(((int64_t)(((int64_t)(((int64_t)(uint64_t)L_4)|((int64_t)(((int64_t)(uint64_t)L_7)<<8))))|((int64_t)(((int64_t)(uint64_t)L_10)<<((int32_t)16)))))|((int64_t)(((int64_t)(uint64_t)L_13)<<((int32_t)24)))))|((int64_t)(((int64_t)(uint64_t)L_16)<<((int32_t)32)))))|((int64_t)(((int64_t)(uint64_t)L_19)<<((int32_t)40)))))|((int64_t)(((int64_t)(uint64_t)L_22)<<((int32_t)48)))))|((int64_t)(((int64_t)(uint64_t)L_25)<<((int32_t)56)))))^(int64_t)L_27));
	}
}
// System.Void Lidgren.Network.NetRandomSeed::.cctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void NetRandomSeed__cctor_m61C60CEDA0F3DA71487FAF1C50CF5FC535E52207 (const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&NetRandomSeed_t78C4CD0A1F9754C7FC65DBE87A58F24C76419A8E_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
{
		// private static int m_seedIncrement = -1640531527;
		((NetRandomSeed_t78C4CD0A1F9754C7FC65DBE87A58F24C76419A8E_StaticFields*)il2cpp_codegen_static_fields_for(NetRandomSeed_t78C4CD0A1F9754C7FC65DBE87A58F24C76419A8E_il2cpp_TypeInfo_var))->___m_seedIncrement_0 = ((int32_t)-1640531527);
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
// System.Void Lidgren.Network.NetReceiverChannelBase::.ctor(Lidgren.Network.NetConnection)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void NetReceiverChannelBase__ctor_mA040707B5F73BB55192C0F44821F5326EC315A99 (NetReceiverChannelBase_t56118523C994D57E27F048D445AFF933D49CCA3C* __this, NetConnection_tBC8B4699CF2D1614FF259EE7E3031D8D25E31F9D* ___connection0, const RuntimeMethod* method) 
{
{
		// public NetReceiverChannelBase(NetConnection connection)
		Object__ctor_mE837C6B9FA8C6D5D109F4B2EC885D79919AC0EA2(__this, NULL);
		// m_connection = connection;
		NetConnection_tBC8B4699CF2D1614FF259EE7E3031D8D25E31F9D* L_0 = ___connection0;
		__this->___m_connection_1 = L_0;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___m_connection_1), (void*)L_0);
		// m_peer = connection.m_peer;
		NetConnection_tBC8B4699CF2D1614FF259EE7E3031D8D25E31F9D* L_1 = ___connection0;
		NullCheck(L_1);
		NetPeer_tDCD3AC5FB42BE47DEE7AEEA74F327C1E0D883542* L_2 = L_1->___m_peer_2;
		__this->___m_peer_0 = L_2;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___m_peer_0), (void*)L_2);
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
// System.Void Lidgren.Network.NetReliableOrderedReceiver::.ctor(Lidgren.Network.NetConnection,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void NetReliableOrderedReceiver__ctor_mFB80B57C8B2C3AE48E32667C7053272E72356FFC (NetReliableOrderedReceiver_t8AF4B8E9088E083F64FEB029207E68FD0BF5F01C* __this, NetConnection_tBC8B4699CF2D1614FF259EE7E3031D8D25E31F9D* ___connection0, int32_t ___windowSize1, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&NetBitVector_tF8CA8B405111502BD2A21BADB51D903E2E21FF67_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&NetIncomingMessageU5BU5D_tE6182F91F2C9B34755AB3E8A13305818DD434AFA_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
{
		// : base(connection)
		NetConnection_tBC8B4699CF2D1614FF259EE7E3031D8D25E31F9D* L_0 = ___connection0;
		NetReceiverChannelBase__ctor_mA040707B5F73BB55192C0F44821F5326EC315A99(__this, L_0, NULL);
		// m_windowSize = windowSize;
		int32_t L_1 = ___windowSize1;
		__this->___m_windowSize_3 = L_1;
		// m_withheldMessages = new NetIncomingMessage[windowSize];
		int32_t L_2 = ___windowSize1;
		NetIncomingMessageU5BU5D_tE6182F91F2C9B34755AB3E8A13305818DD434AFA* L_3 = (NetIncomingMessageU5BU5D_tE6182F91F2C9B34755AB3E8A13305818DD434AFA*)(NetIncomingMessageU5BU5D_tE6182F91F2C9B34755AB3E8A13305818DD434AFA*)SZArrayNew(NetIncomingMessageU5BU5D_tE6182F91F2C9B34755AB3E8A13305818DD434AFA_il2cpp_TypeInfo_var, (uint32_t)L_2);
		__this->___m_withheldMessages_5 = L_3;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___m_withheldMessages_5), (void*)L_3);
		// m_earlyReceived = new NetBitVector(windowSize);
		int32_t L_4 = ___windowSize1;
		NetBitVector_tF8CA8B405111502BD2A21BADB51D903E2E21FF67* L_5 = (NetBitVector_tF8CA8B405111502BD2A21BADB51D903E2E21FF67*)il2cpp_codegen_object_new(NetBitVector_tF8CA8B405111502BD2A21BADB51D903E2E21FF67_il2cpp_TypeInfo_var);
		NetBitVector__ctor_mEFF54B813F6C5472ED26A05E548B460CAB39B4A5(L_5, L_4, /*hidden argument*/NULL);
		__this->___m_earlyReceived_4 = L_5;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___m_earlyReceived_4), (void*)L_5);
		// }
		return;
	}
}
// System.Void Lidgren.Network.NetReliableOrderedReceiver::AdvanceWindow()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void NetReliableOrderedReceiver_AdvanceWindow_mB00756688A10F370FB50B64F9012D9A707E3CE7A (NetReliableOrderedReceiver_t8AF4B8E9088E083F64FEB029207E68FD0BF5F01C* __this, const RuntimeMethod* method) 
{
{
		// m_earlyReceived.Set(m_windowStart % m_windowSize, false);
		NetBitVector_tF8CA8B405111502BD2A21BADB51D903E2E21FF67* L_0 = __this->___m_earlyReceived_4;
		int32_t L_1 = __this->___m_windowStart_2;
		int32_t L_2 = __this->___m_windowSize_3;
		NullCheck(L_0);
		NetBitVector_Set_m7E4E2CA6DD0E5A969B25A19857A3C8F01694AF3D(L_0, ((int32_t)(L_1%L_2)), (bool)0, NULL);
		// m_windowStart = (m_windowStart + 1) % NetConstants.NumSequenceNumbers;
		int32_t L_3 = __this->___m_windowStart_2;
		__this->___m_windowStart_2 = ((int32_t)(((int32_t)il2cpp_codegen_add(L_3, 1))%((int32_t)1024)));
		// }
		return;
	}
}
// System.Void Lidgren.Network.NetReliableOrderedReceiver::ReceiveMessage(Lidgren.Network.NetIncomingMessage)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void NetReliableOrderedReceiver_ReceiveMessage_mEAA0235B7A334F40B64C7A12AA081F787DDEBABA (NetReliableOrderedReceiver_t8AF4B8E9088E083F64FEB029207E68FD0BF5F01C* __this, NetIncomingMessage_t5E80A584865BF84B3148130AE0CE9A0794DD0A71* ___message0, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&NetUtility_t0B01E9514810CE3FC3B5E83D8427CBA1C5689EFD_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
int32_t V_0 = 0;
	int32_t V_1 = 0;
	{
		// int relate = NetUtility.RelativeSequenceNumber(message.m_sequenceNumber, m_windowStart);
		NetIncomingMessage_t5E80A584865BF84B3148130AE0CE9A0794DD0A71* L_0 = ___message0;
		NullCheck(L_0);
		int32_t L_1 = L_0->___m_sequenceNumber_12;
		int32_t L_2 = __this->___m_windowStart_2;
		il2cpp_codegen_runtime_class_init_inline(NetUtility_t0B01E9514810CE3FC3B5E83D8427CBA1C5689EFD_il2cpp_TypeInfo_var);
		int32_t L_3;
		L_3 = NetUtility_RelativeSequenceNumber_m5DE5D4F0FE867CF19738194E727E1437A81B69B7(L_1, L_2, NULL);
		V_0 = L_3;
		// m_connection.QueueAck(message.m_receivedMessageType, message.m_sequenceNumber);
		NetConnection_tBC8B4699CF2D1614FF259EE7E3031D8D25E31F9D* L_4 = ((NetReceiverChannelBase_t56118523C994D57E27F048D445AFF933D49CCA3C*)__this)->___m_connection_1;
		NetIncomingMessage_t5E80A584865BF84B3148130AE0CE9A0794DD0A71* L_5 = ___message0;
		NullCheck(L_5);
		uint8_t L_6 = L_5->___m_receivedMessageType_13;
		NetIncomingMessage_t5E80A584865BF84B3148130AE0CE9A0794DD0A71* L_7 = ___message0;
		NullCheck(L_7);
		int32_t L_8 = L_7->___m_sequenceNumber_12;
		NullCheck(L_4);
		NetConnection_QueueAck_m6C5B3CECC443C7C33B67117795A5A0307C0EC179(L_4, L_6, L_8, NULL);
		// if (relate == 0)
		int32_t L_9 = V_0;
		if (L_9)
		{
			goto IL_009c;
		}
	}
	{
		// AdvanceWindow();
		NetReliableOrderedReceiver_AdvanceWindow_mB00756688A10F370FB50B64F9012D9A707E3CE7A(__this, NULL);
		// m_peer.ReleaseMessage(message);
		NetPeer_tDCD3AC5FB42BE47DEE7AEEA74F327C1E0D883542* L_10 = ((NetReceiverChannelBase_t56118523C994D57E27F048D445AFF933D49CCA3C*)__this)->___m_peer_0;
		NetIncomingMessage_t5E80A584865BF84B3148130AE0CE9A0794DD0A71* L_11 = ___message0;
		NullCheck(L_10);
		NetPeer_ReleaseMessage_m360CE8B0C167EB96DCA5DDAE43E76E6C6AA68D2B(L_10, L_11, NULL);
		// int nextSeqNr = (message.m_sequenceNumber + 1) % NetConstants.NumSequenceNumbers;
		NetIncomingMessage_t5E80A584865BF84B3148130AE0CE9A0794DD0A71* L_12 = ___message0;
		NullCheck(L_12);
		int32_t L_13 = L_12->___m_sequenceNumber_12;
		V_1 = ((int32_t)(((int32_t)il2cpp_codegen_add(L_13, 1))%((int32_t)1024)));
		goto IL_0086;
	}

IL_004f:
	{
		// message = m_withheldMessages[nextSeqNr % m_windowSize];
		NetIncomingMessageU5BU5D_tE6182F91F2C9B34755AB3E8A13305818DD434AFA* L_14 = __this->___m_withheldMessages_5;
		int32_t L_15 = V_1;
		int32_t L_16 = __this->___m_windowSize_3;
		NullCheck(L_14);
		int32_t L_17 = ((int32_t)(L_15%L_16));
		NetIncomingMessage_t5E80A584865BF84B3148130AE0CE9A0794DD0A71* L_18 = (L_14)->GetAt(static_cast<il2cpp_array_size_t>(L_17));
		___message0 = L_18;
		// m_withheldMessages[nextSeqNr % m_windowSize] = null;
		NetIncomingMessageU5BU5D_tE6182F91F2C9B34755AB3E8A13305818DD434AFA* L_19 = __this->___m_withheldMessages_5;
		int32_t L_20 = V_1;
		int32_t L_21 = __this->___m_windowSize_3;
		NullCheck(L_19);
		ArrayElementTypeCheck (L_19, NULL);
		(L_19)->SetAt(static_cast<il2cpp_array_size_t>(((int32_t)(L_20%L_21))), (NetIncomingMessage_t5E80A584865BF84B3148130AE0CE9A0794DD0A71*)NULL);
		// m_peer.ReleaseMessage(message);
		NetPeer_tDCD3AC5FB42BE47DEE7AEEA74F327C1E0D883542* L_22 = ((NetReceiverChannelBase_t56118523C994D57E27F048D445AFF933D49CCA3C*)__this)->___m_peer_0;
		NetIncomingMessage_t5E80A584865BF84B3148130AE0CE9A0794DD0A71* L_23 = ___message0;
		NullCheck(L_22);
		NetPeer_ReleaseMessage_m360CE8B0C167EB96DCA5DDAE43E76E6C6AA68D2B(L_22, L_23, NULL);
		// AdvanceWindow();
		NetReliableOrderedReceiver_AdvanceWindow_mB00756688A10F370FB50B64F9012D9A707E3CE7A(__this, NULL);
		// nextSeqNr++;
		int32_t L_24 = V_1;
		V_1 = ((int32_t)il2cpp_codegen_add(L_24, 1));
	}

IL_0086:
	{
		// while (m_earlyReceived[nextSeqNr % m_windowSize])
		NetBitVector_tF8CA8B405111502BD2A21BADB51D903E2E21FF67* L_25 = __this->___m_earlyReceived_4;
		int32_t L_26 = V_1;
		int32_t L_27 = __this->___m_windowSize_3;
		NullCheck(L_25);
		bool L_28;
		L_28 = NetBitVector_get_Bit_mACF2056FB118F8346E8A850CB15B69046790D448(L_25, ((int32_t)(L_26%L_27)), NULL);
		if (L_28)
		{
			goto IL_004f;
		}
	}
	{
		// return;
		return;
	}

IL_009c:
	{
		// if (relate < 0)
		int32_t L_29 = V_0;
		if ((((int32_t)L_29) >= ((int32_t)0)))
		{
			goto IL_00a1;
		}
	}
	{
		// return;
		return;
	}

IL_00a1:
	{
		// if (relate > m_windowSize)
		int32_t L_30 = V_0;
		int32_t L_31 = __this->___m_windowSize_3;
		if ((((int32_t)L_30) <= ((int32_t)L_31)))
		{
			goto IL_00ab;
		}
	}
	{
		// return;
		return;
	}

IL_00ab:
	{
		// m_earlyReceived.Set(message.m_sequenceNumber % m_windowSize, true);
		NetBitVector_tF8CA8B405111502BD2A21BADB51D903E2E21FF67* L_32 = __this->___m_earlyReceived_4;
		NetIncomingMessage_t5E80A584865BF84B3148130AE0CE9A0794DD0A71* L_33 = ___message0;
		NullCheck(L_33);
		int32_t L_34 = L_33->___m_sequenceNumber_12;
		int32_t L_35 = __this->___m_windowSize_3;
		NullCheck(L_32);
		NetBitVector_Set_m7E4E2CA6DD0E5A969B25A19857A3C8F01694AF3D(L_32, ((int32_t)(L_34%L_35)), (bool)1, NULL);
		// m_withheldMessages[message.m_sequenceNumber % m_windowSize] = message;
		NetIncomingMessageU5BU5D_tE6182F91F2C9B34755AB3E8A13305818DD434AFA* L_36 = __this->___m_withheldMessages_5;
		NetIncomingMessage_t5E80A584865BF84B3148130AE0CE9A0794DD0A71* L_37 = ___message0;
		NullCheck(L_37);
		int32_t L_38 = L_37->___m_sequenceNumber_12;
		int32_t L_39 = __this->___m_windowSize_3;
		NetIncomingMessage_t5E80A584865BF84B3148130AE0CE9A0794DD0A71* L_40 = ___message0;
		NullCheck(L_36);
		ArrayElementTypeCheck (L_36, L_40);
		(L_36)->SetAt(static_cast<il2cpp_array_size_t>(((int32_t)(L_38%L_39))), (NetIncomingMessage_t5E80A584865BF84B3148130AE0CE9A0794DD0A71*)L_40);
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
// System.Int32 Lidgren.Network.NetReliableSenderChannel::get_WindowSize()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t NetReliableSenderChannel_get_WindowSize_m116FFC6D326E18AEF887A1E3D754B331F5143543 (NetReliableSenderChannel_tA9749EC67EDA9FBCCB0D40CB31EB8320C89B42C2* __this, const RuntimeMethod* method) 
{
{
		// internal override int WindowSize { get { return m_windowSize; } }
		int32_t L_0 = __this->___m_windowSize_3;
		return L_0;
	}
}
// System.Boolean Lidgren.Network.NetReliableSenderChannel::NeedToSendMessages()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool NetReliableSenderChannel_NeedToSendMessages_mED9E0A521C69EB377949C36A676C066D688C6A66 (NetReliableSenderChannel_tA9749EC67EDA9FBCCB0D40CB31EB8320C89B42C2* __this, const RuntimeMethod* method) 
{
{
		// return base.NeedToSendMessages() || m_anyStoredResends;
		bool L_0;
		L_0 = NetSenderChannelBase_NeedToSendMessages_mBB0A6D332A3FD353AFD613B32A96E481AB617260(__this, NULL);
		if (L_0)
		{
			goto IL_000f;
		}
	}
	{
		bool L_1 = __this->___m_anyStoredResends_5;
		return L_1;
	}

IL_000f:
	{
		return (bool)1;
	}
}
// System.Void Lidgren.Network.NetReliableSenderChannel::.ctor(Lidgren.Network.NetConnection,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void NetReliableSenderChannel__ctor_mD7EE20217E1CAABA083DBCE75B04E667679DA437 (NetReliableSenderChannel_tA9749EC67EDA9FBCCB0D40CB31EB8320C89B42C2* __this, NetConnection_tBC8B4699CF2D1614FF259EE7E3031D8D25E31F9D* ___connection0, int32_t ___windowSize1, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&NetBitVector_tF8CA8B405111502BD2A21BADB51D903E2E21FF67_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&NetQueue_1__ctor_m66DF6F6C6BA14E66C85046A8D415C5E75508640F_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&NetQueue_1_tE04A2248A2948BB1FCEAAF0A1151D27B56B71EA3_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&NetStoredReliableMessageU5BU5D_t23591445FC2D24CA762300B550255D630D65C634_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
{
		// internal NetReliableSenderChannel(NetConnection connection, int windowSize)
		NetSenderChannelBase__ctor_m4F33557333904C43F29ED7D4153AAE87A49F8A0C(__this, NULL);
		// m_connection = connection;
		NetConnection_tBC8B4699CF2D1614FF259EE7E3031D8D25E31F9D* L_0 = ___connection0;
		__this->___m_connection_1 = L_0;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___m_connection_1), (void*)L_0);
		// m_windowSize = windowSize;
		int32_t L_1 = ___windowSize1;
		__this->___m_windowSize_3 = L_1;
		// m_windowStart = 0;
		__this->___m_windowStart_2 = 0;
		// m_sendStart = 0;
		__this->___m_sendStart_4 = 0;
		// m_anyStoredResends = false;
		__this->___m_anyStoredResends_5 = (bool)0;
		// m_receivedAcks = new NetBitVector(NetConstants.NumSequenceNumbers);
		NetBitVector_tF8CA8B405111502BD2A21BADB51D903E2E21FF67* L_2 = (NetBitVector_tF8CA8B405111502BD2A21BADB51D903E2E21FF67*)il2cpp_codegen_object_new(NetBitVector_tF8CA8B405111502BD2A21BADB51D903E2E21FF67_il2cpp_TypeInfo_var);
		NetBitVector__ctor_mEFF54B813F6C5472ED26A05E548B460CAB39B4A5(L_2, ((int32_t)1024), /*hidden argument*/NULL);
		__this->___m_receivedAcks_6 = L_2;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___m_receivedAcks_6), (void*)L_2);
		// m_storedMessages = new NetStoredReliableMessage[m_windowSize];
		int32_t L_3 = __this->___m_windowSize_3;
		NetStoredReliableMessageU5BU5D_t23591445FC2D24CA762300B550255D630D65C634* L_4 = (NetStoredReliableMessageU5BU5D_t23591445FC2D24CA762300B550255D630D65C634*)(NetStoredReliableMessageU5BU5D_t23591445FC2D24CA762300B550255D630D65C634*)SZArrayNew(NetStoredReliableMessageU5BU5D_t23591445FC2D24CA762300B550255D630D65C634_il2cpp_TypeInfo_var, (uint32_t)L_3);
		__this->___m_storedMessages_7 = L_4;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___m_storedMessages_7), (void*)L_4);
		// m_queuedSends = new NetQueue<NetOutgoingMessage>(8);
		NetQueue_1_tE04A2248A2948BB1FCEAAF0A1151D27B56B71EA3* L_5 = (NetQueue_1_tE04A2248A2948BB1FCEAAF0A1151D27B56B71EA3*)il2cpp_codegen_object_new(NetQueue_1_tE04A2248A2948BB1FCEAAF0A1151D27B56B71EA3_il2cpp_TypeInfo_var);
		NetQueue_1__ctor_m66DF6F6C6BA14E66C85046A8D415C5E75508640F(L_5, 8, /*hidden argument*/NetQueue_1__ctor_m66DF6F6C6BA14E66C85046A8D415C5E75508640F_RuntimeMethod_var);
		((NetSenderChannelBase_t60E3BDE4FA746EE6C8453DD201764C0B7D6948A2*)__this)->___m_queuedSends_0 = L_5;
		Il2CppCodeGenWriteBarrier((void**)(&((NetSenderChannelBase_t60E3BDE4FA746EE6C8453DD201764C0B7D6948A2*)__this)->___m_queuedSends_0), (void*)L_5);
		// m_resendDelay = m_connection.GetResendDelay();
		NetConnection_tBC8B4699CF2D1614FF259EE7E3031D8D25E31F9D* L_6 = __this->___m_connection_1;
		NullCheck(L_6);
		double L_7;
		L_7 = NetConnection_GetResendDelay_mA83C6F17DEC5BAE449701C938A281F6C1CBA5A6A(L_6, NULL);
		__this->___m_resendDelay_8 = L_7;
		// }
		return;
	}
}
// System.Int32 Lidgren.Network.NetReliableSenderChannel::GetAllowedSends()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t NetReliableSenderChannel_GetAllowedSends_mCF507F9B82D933F01DDD944C11BBA7A065098561 (NetReliableSenderChannel_tA9749EC67EDA9FBCCB0D40CB31EB8320C89B42C2* __this, const RuntimeMethod* method) 
{
{
		// int retval = m_windowSize - ((m_sendStart + NetConstants.NumSequenceNumbers) - m_windowStart) % NetConstants.NumSequenceNumbers;
		int32_t L_0 = __this->___m_windowSize_3;
		int32_t L_1 = __this->___m_sendStart_4;
		int32_t L_2 = __this->___m_windowStart_2;
		// return retval;
		return ((int32_t)il2cpp_codegen_subtract(L_0, ((int32_t)(((int32_t)il2cpp_codegen_subtract(((int32_t)il2cpp_codegen_add(L_1, ((int32_t)1024))), L_2))%((int32_t)1024)))));
	}
}
// System.Void Lidgren.Network.NetReliableSenderChannel::Reset()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void NetReliableSenderChannel_Reset_m3BBFBC8ED478323B39843955A2AA86984312031A (NetReliableSenderChannel_tA9749EC67EDA9FBCCB0D40CB31EB8320C89B42C2* __this, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&NetQueue_1_Clear_m2D3A4A1665A1449F169FAD863EC1025C6A471FDB_RuntimeMethod_var);
		s_Il2CppMethodInitialized = true;
	}
int32_t V_0 = 0;
	{
		// m_receivedAcks.Clear();
		NetBitVector_tF8CA8B405111502BD2A21BADB51D903E2E21FF67* L_0 = __this->___m_receivedAcks_6;
		NullCheck(L_0);
		NetBitVector_Clear_mD555550DF31C9B77DB6DEFBFF5508256A923AE6D(L_0, NULL);
		// for (int i = 0; i < m_storedMessages.Length; i++)
		V_0 = 0;
		goto IL_0024;
	}

IL_000f:
	{
		// m_storedMessages[i].Reset();
		NetStoredReliableMessageU5BU5D_t23591445FC2D24CA762300B550255D630D65C634* L_1 = __this->___m_storedMessages_7;
		int32_t L_2 = V_0;
		NullCheck(L_1);
		NetStoredReliableMessage_Reset_mFFC4A5507657DEE70D8C557ED904E4E5E180721F(((L_1)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_2))), NULL);
		// for (int i = 0; i < m_storedMessages.Length; i++)
		int32_t L_3 = V_0;
		V_0 = ((int32_t)il2cpp_codegen_add(L_3, 1));
	}

IL_0024:
	{
		// for (int i = 0; i < m_storedMessages.Length; i++)
		int32_t L_4 = V_0;
		NetStoredReliableMessageU5BU5D_t23591445FC2D24CA762300B550255D630D65C634* L_5 = __this->___m_storedMessages_7;
		NullCheck(L_5);
		if ((((int32_t)L_4) < ((int32_t)((int32_t)(((RuntimeArray*)L_5)->max_length)))))
		{
			goto IL_000f;
		}
	}
	{
		// m_anyStoredResends = false;
		__this->___m_anyStoredResends_5 = (bool)0;
		// m_queuedSends.Clear();
		NetQueue_1_tE04A2248A2948BB1FCEAAF0A1151D27B56B71EA3* L_6 = ((NetSenderChannelBase_t60E3BDE4FA746EE6C8453DD201764C0B7D6948A2*)__this)->___m_queuedSends_0;
		NullCheck(L_6);
		NetQueue_1_Clear_m2D3A4A1665A1449F169FAD863EC1025C6A471FDB(L_6, NetQueue_1_Clear_m2D3A4A1665A1449F169FAD863EC1025C6A471FDB_RuntimeMethod_var);
		// m_windowStart = 0;
		__this->___m_windowStart_2 = 0;
		// m_sendStart = 0;
		__this->___m_sendStart_4 = 0;
		// }
		return;
	}
}
// Lidgren.Network.NetSendResult Lidgren.Network.NetReliableSenderChannel::Enqueue(Lidgren.Network.NetOutgoingMessage)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t NetReliableSenderChannel_Enqueue_mBE7B625CEE36CB4C94D4800ECD67D74456E1485A (NetReliableSenderChannel_tA9749EC67EDA9FBCCB0D40CB31EB8320C89B42C2* __this, NetOutgoingMessage_t2C00CEEAEF52CDD51F8F991F2F8AFA314FEAAECB* ___message0, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&NetQueue_1_Enqueue_m29381A69FDF40552A8ABA5B1385D72E71F1EB435_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&NetQueue_1_get_Count_m9D0B8118A5875517A26773BBA576C2006810DE22_RuntimeMethod_var);
		s_Il2CppMethodInitialized = true;
	}
{
		// m_queuedSends.Enqueue(message);
		NetQueue_1_tE04A2248A2948BB1FCEAAF0A1151D27B56B71EA3* L_0 = ((NetSenderChannelBase_t60E3BDE4FA746EE6C8453DD201764C0B7D6948A2*)__this)->___m_queuedSends_0;
		NetOutgoingMessage_t2C00CEEAEF52CDD51F8F991F2F8AFA314FEAAECB* L_1 = ___message0;
		NullCheck(L_0);
		NetQueue_1_Enqueue_m29381A69FDF40552A8ABA5B1385D72E71F1EB435(L_0, L_1, NetQueue_1_Enqueue_m29381A69FDF40552A8ABA5B1385D72E71F1EB435_RuntimeMethod_var);
		// m_connection.m_peer.m_needFlushSendQueue = true; // a race condition to this variable will simply result in a single superflous call to FlushSendQueue()
		NetConnection_tBC8B4699CF2D1614FF259EE7E3031D8D25E31F9D* L_2 = __this->___m_connection_1;
		NullCheck(L_2);
		NetPeer_tDCD3AC5FB42BE47DEE7AEEA74F327C1E0D883542* L_3 = L_2->___m_peer_2;
		NullCheck(L_3);
		L_3->___m_needFlushSendQueue_23 = (bool)1;
		// if (m_queuedSends.Count <= GetAllowedSends())
		NetQueue_1_tE04A2248A2948BB1FCEAAF0A1151D27B56B71EA3* L_4 = ((NetSenderChannelBase_t60E3BDE4FA746EE6C8453DD201764C0B7D6948A2*)__this)->___m_queuedSends_0;
		NullCheck(L_4);
		int32_t L_5;
		L_5 = NetQueue_1_get_Count_m9D0B8118A5875517A26773BBA576C2006810DE22(L_4, NetQueue_1_get_Count_m9D0B8118A5875517A26773BBA576C2006810DE22_RuntimeMethod_var);
		int32_t L_6;
		L_6 = VirtualFuncInvoker0< int32_t >::Invoke(5 /* System.Int32 Lidgren.Network.NetSenderChannelBase::GetAllowedSends() */, __this);
		if ((((int32_t)L_5) > ((int32_t)L_6)))
		{
			goto IL_0032;
		}
	}
	{
		// return NetSendResult.Sent;
		return (int32_t)(1);
	}

IL_0032:
	{
		// return NetSendResult.Queued;
		return (int32_t)(2);
	}
}
// System.Void Lidgren.Network.NetReliableSenderChannel::SendQueuedMessages(System.Double)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void NetReliableSenderChannel_SendQueuedMessages_m81C68CABFCD61F5377EC1DB465DF7B1CEBCC1F05 (NetReliableSenderChannel_tA9749EC67EDA9FBCCB0D40CB31EB8320C89B42C2* __this, double ___now0, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&NetQueue_1_TryDequeue_m64BE224E287C91F5A80BC1F74C4777A5BD3BB97C_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&NetQueue_1_get_Count_m9D0B8118A5875517A26773BBA576C2006810DE22_RuntimeMethod_var);
		s_Il2CppMethodInitialized = true;
	}
int32_t V_0 = 0;
	int32_t V_1 = 0;
	NetStoredReliableMessage_t32B73B76F26B4659411CEBFF7647E6D567487D39 V_2;
	memset((&V_2), 0, sizeof(V_2));
	NetOutgoingMessage_t2C00CEEAEF52CDD51F8F991F2F8AFA314FEAAECB* V_3 = NULL;
	double V_4 = 0.0;
	NetOutgoingMessage_t2C00CEEAEF52CDD51F8F991F2F8AFA314FEAAECB* V_5 = NULL;
	{
		// m_anyStoredResends = false;
		__this->___m_anyStoredResends_5 = (bool)0;
		// for (int i = 0; i < m_storedMessages.Length; i++)
		V_1 = 0;
		goto IL_0097;
	}

IL_000e:
	{
		// var storedMsg = m_storedMessages[i];
		NetStoredReliableMessageU5BU5D_t23591445FC2D24CA762300B550255D630D65C634* L_0 = __this->___m_storedMessages_7;
		int32_t L_1 = V_1;
		NullCheck(L_0);
		int32_t L_2 = L_1;
		NetStoredReliableMessage_t32B73B76F26B4659411CEBFF7647E6D567487D39 L_3 = (L_0)->GetAt(static_cast<il2cpp_array_size_t>(L_2));
		V_2 = L_3;
		// NetOutgoingMessage om = storedMsg.Message;
		NetStoredReliableMessage_t32B73B76F26B4659411CEBFF7647E6D567487D39 L_4 = V_2;
		NetOutgoingMessage_t2C00CEEAEF52CDD51F8F991F2F8AFA314FEAAECB* L_5 = L_4.___Message_2;
		V_3 = L_5;
		// if (om == null)
		NetOutgoingMessage_t2C00CEEAEF52CDD51F8F991F2F8AFA314FEAAECB* L_6 = V_3;
		if (!L_6)
		{
			goto IL_0093;
		}
	}
	{
		// m_anyStoredResends = true;
		__this->___m_anyStoredResends_5 = (bool)1;
		// double t = storedMsg.LastSent;
		NetStoredReliableMessage_t32B73B76F26B4659411CEBFF7647E6D567487D39 L_7 = V_2;
		double L_8 = L_7.___LastSent_1;
		V_4 = L_8;
		// if (t > 0 && (now - t) > m_resendDelay)
		double L_9 = V_4;
		if ((!(((double)L_9) > ((double)(0.0)))))
		{
			goto IL_0093;
		}
	}
	{
		double L_10 = ___now0;
		double L_11 = V_4;
		double L_12 = __this->___m_resendDelay_8;
		if ((!(((double)((double)il2cpp_codegen_subtract(L_10, L_11))) > ((double)L_12))))
		{
			goto IL_0093;
		}
	}
	{
		// Interlocked.Increment(ref om.m_recyclingCount); // increment this since it's being decremented in QueueSendMessage
		NetOutgoingMessage_t2C00CEEAEF52CDD51F8F991F2F8AFA314FEAAECB* L_13 = V_3;
		NullCheck(L_13);
		int32_t* L_14 = (&L_13->___m_recyclingCount_11);
		int32_t L_15;
		L_15 = Interlocked_Increment_m7AC68EC482A6AFD97BCEFABA0FD45D203F3EA2E1(L_14, NULL);
		// m_connection.QueueSendMessage(om, storedMsg.SequenceNumber);
		NetConnection_tBC8B4699CF2D1614FF259EE7E3031D8D25E31F9D* L_16 = __this->___m_connection_1;
		NetOutgoingMessage_t2C00CEEAEF52CDD51F8F991F2F8AFA314FEAAECB* L_17 = V_3;
		NetStoredReliableMessage_t32B73B76F26B4659411CEBFF7647E6D567487D39 L_18 = V_2;
		int32_t L_19 = L_18.___SequenceNumber_3;
		NullCheck(L_16);
		NetConnection_QueueSendMessage_mCD87B7FD21EE3A2B3FF0D786ACDF6CBB4441721D(L_16, L_17, L_19, NULL);
		// m_storedMessages[i].LastSent = now;
		NetStoredReliableMessageU5BU5D_t23591445FC2D24CA762300B550255D630D65C634* L_20 = __this->___m_storedMessages_7;
		int32_t L_21 = V_1;
		NullCheck(L_20);
		double L_22 = ___now0;
		((L_20)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_21)))->___LastSent_1 = L_22;
		// m_storedMessages[i].NumSent++;
		NetStoredReliableMessageU5BU5D_t23591445FC2D24CA762300B550255D630D65C634* L_23 = __this->___m_storedMessages_7;
		int32_t L_24 = V_1;
		NullCheck(L_23);
		int32_t* L_25 = (&((L_23)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_24)))->___NumSent_0);
		int32_t* L_26 = L_25;
		int32_t L_27 = *((int32_t*)L_26);
		*((int32_t*)L_26) = (int32_t)((int32_t)il2cpp_codegen_add(L_27, 1));
	}

IL_0093:
	{
		// for (int i = 0; i < m_storedMessages.Length; i++)
		int32_t L_28 = V_1;
		V_1 = ((int32_t)il2cpp_codegen_add(L_28, 1));
	}

IL_0097:
	{
		// for (int i = 0; i < m_storedMessages.Length; i++)
		int32_t L_29 = V_1;
		NetStoredReliableMessageU5BU5D_t23591445FC2D24CA762300B550255D630D65C634* L_30 = __this->___m_storedMessages_7;
		NullCheck(L_30);
		if ((((int32_t)L_29) < ((int32_t)((int32_t)(((RuntimeArray*)L_30)->max_length)))))
		{
			goto IL_000e;
		}
	}
	{
		// int num = GetAllowedSends();
		int32_t L_31;
		L_31 = VirtualFuncInvoker0< int32_t >::Invoke(5 /* System.Int32 Lidgren.Network.NetSenderChannelBase::GetAllowedSends() */, __this);
		V_0 = L_31;
		// if (num < 1)
		int32_t L_32 = V_0;
		if ((((int32_t)L_32) >= ((int32_t)1)))
		{
			goto IL_00cd;
		}
	}
	{
		// return;
		return;
	}

IL_00b1:
	{
		// if (m_queuedSends.TryDequeue(out om))
		NetQueue_1_tE04A2248A2948BB1FCEAAF0A1151D27B56B71EA3* L_33 = ((NetSenderChannelBase_t60E3BDE4FA746EE6C8453DD201764C0B7D6948A2*)__this)->___m_queuedSends_0;
		NullCheck(L_33);
		bool L_34;
		L_34 = NetQueue_1_TryDequeue_m64BE224E287C91F5A80BC1F74C4777A5BD3BB97C(L_33, (&V_5), NetQueue_1_TryDequeue_m64BE224E287C91F5A80BC1F74C4777A5BD3BB97C_RuntimeMethod_var);
		if (!L_34)
		{
			goto IL_00c9;
		}
	}
	{
		// ExecuteSend(now, om);
		double L_35 = ___now0;
		NetOutgoingMessage_t2C00CEEAEF52CDD51F8F991F2F8AFA314FEAAECB* L_36 = V_5;
		NetReliableSenderChannel_ExecuteSend_m1FCF1B56538D6FF986D39D2A3859399157FADEFE(__this, L_35, L_36, NULL);
	}

IL_00c9:
	{
		// num--;
		int32_t L_37 = V_0;
		V_0 = ((int32_t)il2cpp_codegen_subtract(L_37, 1));
	}

IL_00cd:
	{
		// while (num > 0 && m_queuedSends.Count > 0)
		int32_t L_38 = V_0;
		if ((((int32_t)L_38) <= ((int32_t)0)))
		{
			goto IL_00df;
		}
	}
	{
		NetQueue_1_tE04A2248A2948BB1FCEAAF0A1151D27B56B71EA3* L_39 = ((NetSenderChannelBase_t60E3BDE4FA746EE6C8453DD201764C0B7D6948A2*)__this)->___m_queuedSends_0;
		NullCheck(L_39);
		int32_t L_40;
		L_40 = NetQueue_1_get_Count_m9D0B8118A5875517A26773BBA576C2006810DE22(L_39, NetQueue_1_get_Count_m9D0B8118A5875517A26773BBA576C2006810DE22_RuntimeMethod_var);
		if ((((int32_t)L_40) > ((int32_t)0)))
		{
			goto IL_00b1;
		}
	}

IL_00df:
	{
		// }
		return;
	}
}
// System.Void Lidgren.Network.NetReliableSenderChannel::ExecuteSend(System.Double,Lidgren.Network.NetOutgoingMessage)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void NetReliableSenderChannel_ExecuteSend_m1FCF1B56538D6FF986D39D2A3859399157FADEFE (NetReliableSenderChannel_tA9749EC67EDA9FBCCB0D40CB31EB8320C89B42C2* __this, double ___now0, NetOutgoingMessage_t2C00CEEAEF52CDD51F8F991F2F8AFA314FEAAECB* ___message1, const RuntimeMethod* method) 
{
int32_t V_0 = 0;
	int32_t V_1 = 0;
	{
		// int seqNr = m_sendStart;
		int32_t L_0 = __this->___m_sendStart_4;
		V_0 = L_0;
		// m_sendStart = (m_sendStart + 1) % NetConstants.NumSequenceNumbers;
		int32_t L_1 = __this->___m_sendStart_4;
		__this->___m_sendStart_4 = ((int32_t)(((int32_t)il2cpp_codegen_add(L_1, 1))%((int32_t)1024)));
		// Interlocked.Increment(ref message.m_recyclingCount);
		NetOutgoingMessage_t2C00CEEAEF52CDD51F8F991F2F8AFA314FEAAECB* L_2 = ___message1;
		NullCheck(L_2);
		int32_t* L_3 = (&L_2->___m_recyclingCount_11);
		int32_t L_4;
		L_4 = Interlocked_Increment_m7AC68EC482A6AFD97BCEFABA0FD45D203F3EA2E1(L_3, NULL);
		// m_connection.QueueSendMessage(message, seqNr);
		NetConnection_tBC8B4699CF2D1614FF259EE7E3031D8D25E31F9D* L_5 = __this->___m_connection_1;
		NetOutgoingMessage_t2C00CEEAEF52CDD51F8F991F2F8AFA314FEAAECB* L_6 = ___message1;
		int32_t L_7 = V_0;
		NullCheck(L_5);
		NetConnection_QueueSendMessage_mCD87B7FD21EE3A2B3FF0D786ACDF6CBB4441721D(L_5, L_6, L_7, NULL);
		// int storeIndex = seqNr % m_windowSize;
		int32_t L_8 = V_0;
		int32_t L_9 = __this->___m_windowSize_3;
		V_1 = ((int32_t)(L_8%L_9));
		// m_storedMessages[storeIndex].NumSent++;
		NetStoredReliableMessageU5BU5D_t23591445FC2D24CA762300B550255D630D65C634* L_10 = __this->___m_storedMessages_7;
		int32_t L_11 = V_1;
		NullCheck(L_10);
		int32_t* L_12 = (&((L_10)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_11)))->___NumSent_0);
		int32_t* L_13 = L_12;
		int32_t L_14 = *((int32_t*)L_13);
		*((int32_t*)L_13) = (int32_t)((int32_t)il2cpp_codegen_add(L_14, 1));
		// m_storedMessages[storeIndex].Message = message;
		NetStoredReliableMessageU5BU5D_t23591445FC2D24CA762300B550255D630D65C634* L_15 = __this->___m_storedMessages_7;
		int32_t L_16 = V_1;
		NullCheck(L_15);
		NetOutgoingMessage_t2C00CEEAEF52CDD51F8F991F2F8AFA314FEAAECB* L_17 = ___message1;
		((L_15)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_16)))->___Message_2 = L_17;
		Il2CppCodeGenWriteBarrier((void**)(&((L_15)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_16)))->___Message_2), (void*)L_17);
		// m_storedMessages[storeIndex].LastSent = now;
		NetStoredReliableMessageU5BU5D_t23591445FC2D24CA762300B550255D630D65C634* L_18 = __this->___m_storedMessages_7;
		int32_t L_19 = V_1;
		NullCheck(L_18);
		double L_20 = ___now0;
		((L_18)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_19)))->___LastSent_1 = L_20;
		// m_storedMessages[storeIndex].SequenceNumber = seqNr;
		NetStoredReliableMessageU5BU5D_t23591445FC2D24CA762300B550255D630D65C634* L_21 = __this->___m_storedMessages_7;
		int32_t L_22 = V_1;
		NullCheck(L_21);
		int32_t L_23 = V_0;
		((L_21)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_22)))->___SequenceNumber_3 = L_23;
		// m_anyStoredResends = true;
		__this->___m_anyStoredResends_5 = (bool)1;
		// return;
		return;
	}
}
// System.Void Lidgren.Network.NetReliableSenderChannel::DestoreMessage(System.Double,System.Int32,System.Boolean&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void NetReliableSenderChannel_DestoreMessage_m6AEDD6C66F1B24CED8336A347C4EEF137323E86D (NetReliableSenderChannel_tA9749EC67EDA9FBCCB0D40CB31EB8320C89B42C2* __this, double ___now0, int32_t ___storeIndex1, bool* ___resetTimeout2, const RuntimeMethod* method) 
{
NetStoredReliableMessage_t32B73B76F26B4659411CEBFF7647E6D567487D39 V_0;
	memset((&V_0), 0, sizeof(V_0));
	NetOutgoingMessage_t2C00CEEAEF52CDD51F8F991F2F8AFA314FEAAECB* V_1 = NULL;
	bool* G_B2_0 = NULL;
	bool* G_B1_0 = NULL;
	int32_t G_B3_0 = 0;
	bool* G_B3_1 = NULL;
	{
		// var srm = m_storedMessages[storeIndex];
		NetStoredReliableMessageU5BU5D_t23591445FC2D24CA762300B550255D630D65C634* L_0 = __this->___m_storedMessages_7;
		int32_t L_1 = ___storeIndex1;
		NullCheck(L_0);
		int32_t L_2 = L_1;
		NetStoredReliableMessage_t32B73B76F26B4659411CEBFF7647E6D567487D39 L_3 = (L_0)->GetAt(static_cast<il2cpp_array_size_t>(L_2));
		V_0 = L_3;
		// resetTimeout = (srm.NumSent == 1) && (now - srm.LastSent < kThreshold);
		bool* L_4 = ___resetTimeout2;
		NetStoredReliableMessage_t32B73B76F26B4659411CEBFF7647E6D567487D39 L_5 = V_0;
		int32_t L_6 = L_5.___NumSent_0;
		G_B1_0 = L_4;
		if ((!(((uint32_t)L_6) == ((uint32_t)1))))
		{
			G_B2_0 = L_4;
			goto IL_002c;
		}
	}
	{
		double L_7 = ___now0;
		NetStoredReliableMessage_t32B73B76F26B4659411CEBFF7647E6D567487D39 L_8 = V_0;
		double L_9 = L_8.___LastSent_1;
		G_B3_0 = ((((double)((double)il2cpp_codegen_subtract(L_7, L_9))) < ((double)(2.0)))? 1 : 0);
		G_B3_1 = G_B1_0;
		goto IL_002d;
	}

IL_002c:
	{
		G_B3_0 = 0;
		G_B3_1 = G_B2_0;
	}

IL_002d:
	{
		*((int8_t*)G_B3_1) = (int8_t)G_B3_0;
		// var storedMessage = srm.Message;
		NetStoredReliableMessage_t32B73B76F26B4659411CEBFF7647E6D567487D39 L_10 = V_0;
		NetOutgoingMessage_t2C00CEEAEF52CDD51F8F991F2F8AFA314FEAAECB* L_11 = L_10.___Message_2;
		V_1 = L_11;
		// Interlocked.Decrement(ref storedMessage.m_recyclingCount);
		NetOutgoingMessage_t2C00CEEAEF52CDD51F8F991F2F8AFA314FEAAECB* L_12 = V_1;
		NullCheck(L_12);
		int32_t* L_13 = (&L_12->___m_recyclingCount_11);
		int32_t L_14;
		L_14 = Interlocked_Decrement_mFACC375A9985A7E1A3473EECE768B1D2ECB8CEF5(L_13, NULL);
		// if (storedMessage != null)
		NetOutgoingMessage_t2C00CEEAEF52CDD51F8F991F2F8AFA314FEAAECB* L_15 = V_1;
		if (!L_15)
		{
			goto IL_005e;
		}
	}
	{
		// if (storedMessage.m_recyclingCount <= 0)
		NetOutgoingMessage_t2C00CEEAEF52CDD51F8F991F2F8AFA314FEAAECB* L_16 = V_1;
		NullCheck(L_16);
		int32_t L_17 = L_16->___m_recyclingCount_11;
		if ((((int32_t)L_17) > ((int32_t)0)))
		{
			goto IL_005e;
		}
	}
	{
		// m_connection.m_peer.Recycle(storedMessage);
		NetConnection_tBC8B4699CF2D1614FF259EE7E3031D8D25E31F9D* L_18 = __this->___m_connection_1;
		NullCheck(L_18);
		NetPeer_tDCD3AC5FB42BE47DEE7AEEA74F327C1E0D883542* L_19 = L_18->___m_peer_2;
		NetOutgoingMessage_t2C00CEEAEF52CDD51F8F991F2F8AFA314FEAAECB* L_20 = V_1;
		NullCheck(L_19);
		NetPeer_Recycle_m19CD3E9FAB66822D78395ABD6E23DA7F58AA178E(L_19, L_20, NULL);
	}

IL_005e:
	{
		// m_storedMessages[storeIndex] = new NetStoredReliableMessage();
		NetStoredReliableMessageU5BU5D_t23591445FC2D24CA762300B550255D630D65C634* L_21 = __this->___m_storedMessages_7;
		int32_t L_22 = ___storeIndex1;
		NullCheck(L_21);
		il2cpp_codegen_initobj(((L_21)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_22))), sizeof(NetStoredReliableMessage_t32B73B76F26B4659411CEBFF7647E6D567487D39));
		// }
		return;
	}
}
// System.Void Lidgren.Network.NetReliableSenderChannel::ReceiveAcknowledge(System.Double,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void NetReliableSenderChannel_ReceiveAcknowledge_m0F8AAEE4B47FEDB12EE98DAD7456E084B8AE816F (NetReliableSenderChannel_tA9749EC67EDA9FBCCB0D40CB31EB8320C89B42C2* __this, double ___now0, int32_t ___seqNr1, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&NetUtility_t0B01E9514810CE3FC3B5E83D8427CBA1C5689EFD_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
int32_t V_0 = 0;
	int32_t V_1 = 0;
	int32_t V_2 = 0;
	bool V_3 = false;
	bool V_4 = false;
	int32_t V_5 = 0;
	NetOutgoingMessage_t2C00CEEAEF52CDD51F8F991F2F8AFA314FEAAECB* V_6 = NULL;
	{
		// int relate = NetUtility.RelativeSequenceNumber(seqNr, m_windowStart);
		int32_t L_0 = ___seqNr1;
		int32_t L_1 = __this->___m_windowStart_2;
		il2cpp_codegen_runtime_class_init_inline(NetUtility_t0B01E9514810CE3FC3B5E83D8427CBA1C5689EFD_il2cpp_TypeInfo_var);
		int32_t L_2;
		L_2 = NetUtility_RelativeSequenceNumber_m5DE5D4F0FE867CF19738194E727E1437A81B69B7(L_0, L_1, NULL);
		V_0 = L_2;
		// if (relate < 0)
		int32_t L_3 = V_0;
		if ((((int32_t)L_3) >= ((int32_t)0)))
		{
			goto IL_0012;
		}
	}
	{
		// return; // late/duplicate ack
		return;
	}

IL_0012:
	{
		// if (relate == 0)
		int32_t L_4 = V_0;
		if (L_4)
		{
			goto IL_00ba;
		}
	}
	{
		// m_receivedAcks[m_windowStart] = false;
		NetBitVector_tF8CA8B405111502BD2A21BADB51D903E2E21FF67* L_5 = __this->___m_receivedAcks_6;
		int32_t L_6 = __this->___m_windowStart_2;
		NullCheck(L_5);
		NetBitVector_set_Bit_m2A0E5C3CBF8B711C61AF9622627398B814229BE2(L_5, L_6, (bool)0, NULL);
		// DestoreMessage(now, m_windowStart % m_windowSize, out resetTimeout);
		double L_7 = ___now0;
		int32_t L_8 = __this->___m_windowStart_2;
		int32_t L_9 = __this->___m_windowSize_3;
		NetReliableSenderChannel_DestoreMessage_m6AEDD6C66F1B24CED8336A347C4EEF137323E86D(__this, L_7, ((int32_t)(L_8%L_9)), (&V_3), NULL);
		// m_windowStart = (m_windowStart + 1) % NetConstants.NumSequenceNumbers;
		int32_t L_10 = __this->___m_windowStart_2;
		__this->___m_windowStart_2 = ((int32_t)(((int32_t)il2cpp_codegen_add(L_10, 1))%((int32_t)1024)));
		goto IL_0097;
	}

IL_0056:
	{
		// m_receivedAcks[m_windowStart] = false;
		NetBitVector_tF8CA8B405111502BD2A21BADB51D903E2E21FF67* L_11 = __this->___m_receivedAcks_6;
		int32_t L_12 = __this->___m_windowStart_2;
		NullCheck(L_11);
		NetBitVector_set_Bit_m2A0E5C3CBF8B711C61AF9622627398B814229BE2(L_11, L_12, (bool)0, NULL);
		// DestoreMessage(now, m_windowStart % m_windowSize, out rt);
		double L_13 = ___now0;
		int32_t L_14 = __this->___m_windowStart_2;
		int32_t L_15 = __this->___m_windowSize_3;
		NetReliableSenderChannel_DestoreMessage_m6AEDD6C66F1B24CED8336A347C4EEF137323E86D(__this, L_13, ((int32_t)(L_14%L_15)), (&V_4), NULL);
		// resetTimeout |= rt;
		bool L_16 = V_3;
		bool L_17 = V_4;
		V_3 = (bool)((int32_t)((int32_t)L_16|(int32_t)L_17));
		// m_windowStart = (m_windowStart + 1) % NetConstants.NumSequenceNumbers;
		int32_t L_18 = __this->___m_windowStart_2;
		__this->___m_windowStart_2 = ((int32_t)(((int32_t)il2cpp_codegen_add(L_18, 1))%((int32_t)1024)));
	}

IL_0097:
	{
		// while (m_receivedAcks.Get(m_windowStart))
		NetBitVector_tF8CA8B405111502BD2A21BADB51D903E2E21FF67* L_19 = __this->___m_receivedAcks_6;
		int32_t L_20 = __this->___m_windowStart_2;
		NullCheck(L_19);
		bool L_21;
		L_21 = NetBitVector_Get_mE0B3D426B63909C7F2989889D270AE4C5C3DEF55(L_19, L_20, NULL);
		if (L_21)
		{
			goto IL_0056;
		}
	}
	{
		// if (resetTimeout)
		bool L_22 = V_3;
		if (!L_22)
		{
			goto IL_00b9;
		}
	}
	{
		// m_connection.ResetTimeout(now);
		NetConnection_tBC8B4699CF2D1614FF259EE7E3031D8D25E31F9D* L_23 = __this->___m_connection_1;
		double L_24 = ___now0;
		NullCheck(L_23);
		NetConnection_ResetTimeout_m7A64A58F3856CA5F0744D6854FD6B683D30EC25B(L_23, L_24, NULL);
	}

IL_00b9:
	{
		// return;
		return;
	}

IL_00ba:
	{
		// int sendRelate = NetUtility.RelativeSequenceNumber(seqNr, m_sendStart);
		int32_t L_25 = ___seqNr1;
		int32_t L_26 = __this->___m_sendStart_4;
		il2cpp_codegen_runtime_class_init_inline(NetUtility_t0B01E9514810CE3FC3B5E83D8427CBA1C5689EFD_il2cpp_TypeInfo_var);
		int32_t L_27;
		L_27 = NetUtility_RelativeSequenceNumber_m5DE5D4F0FE867CF19738194E727E1437A81B69B7(L_25, L_26, NULL);
		V_1 = L_27;
		// if (sendRelate <= 0)
		int32_t L_28 = V_1;
		if ((((int32_t)L_28) > ((int32_t)0)))
		{
			goto IL_00e8;
		}
	}
	{
		// if (m_receivedAcks[seqNr])
		NetBitVector_tF8CA8B405111502BD2A21BADB51D903E2E21FF67* L_29 = __this->___m_receivedAcks_6;
		int32_t L_30 = ___seqNr1;
		NullCheck(L_29);
		bool L_31;
		L_31 = NetBitVector_get_Bit_mACF2056FB118F8346E8A850CB15B69046790D448(L_29, L_30, NULL);
		if (L_31)
		{
			goto IL_00ed;
		}
	}
	{
		// m_receivedAcks[seqNr] = true;
		NetBitVector_tF8CA8B405111502BD2A21BADB51D903E2E21FF67* L_32 = __this->___m_receivedAcks_6;
		int32_t L_33 = ___seqNr1;
		NullCheck(L_32);
		NetBitVector_set_Bit_m2A0E5C3CBF8B711C61AF9622627398B814229BE2(L_32, L_33, (bool)1, NULL);
		goto IL_00ed;
	}

IL_00e8:
	{
		// else if (sendRelate > 0)
		int32_t L_34 = V_1;
		if ((((int32_t)L_34) <= ((int32_t)0)))
		{
			goto IL_00ed;
		}
	}
	{
		// return;
		return;
	}

IL_00ed:
	{
		// int rnr = seqNr;
		int32_t L_35 = ___seqNr1;
		V_2 = L_35;
	}

IL_00ef:
	{
		// rnr--;
		int32_t L_36 = V_2;
		V_2 = ((int32_t)il2cpp_codegen_subtract(L_36, 1));
		// if (rnr < 0)
		int32_t L_37 = V_2;
		if ((((int32_t)L_37) >= ((int32_t)0)))
		{
			goto IL_00fd;
		}
	}
	{
		// rnr = NetConstants.NumSequenceNumbers - 1;
		V_2 = ((int32_t)1023);
	}

IL_00fd:
	{
		// if (m_receivedAcks[rnr])
		NetBitVector_tF8CA8B405111502BD2A21BADB51D903E2E21FF67* L_38 = __this->___m_receivedAcks_6;
		int32_t L_39 = V_2;
		NullCheck(L_38);
		bool L_40;
		L_40 = NetBitVector_get_Bit_mACF2056FB118F8346E8A850CB15B69046790D448(L_38, L_39, NULL);
		if (L_40)
		{
			goto IL_01ac;
		}
	}
	{
		// int slot = rnr % m_windowSize;
		int32_t L_41 = V_2;
		int32_t L_42 = __this->___m_windowSize_3;
		V_5 = ((int32_t)(L_41%L_42));
		// if (m_storedMessages[slot].NumSent == 1)
		NetStoredReliableMessageU5BU5D_t23591445FC2D24CA762300B550255D630D65C634* L_43 = __this->___m_storedMessages_7;
		int32_t L_44 = V_5;
		NullCheck(L_43);
		int32_t L_45 = ((L_43)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_44)))->___NumSent_0;
		if ((!(((uint32_t)L_45) == ((uint32_t)1))))
		{
			goto IL_01ac;
		}
	}
	{
		// NetOutgoingMessage rmsg = m_storedMessages[slot].Message;
		NetStoredReliableMessageU5BU5D_t23591445FC2D24CA762300B550255D630D65C634* L_46 = __this->___m_storedMessages_7;
		int32_t L_47 = V_5;
		NullCheck(L_46);
		NetOutgoingMessage_t2C00CEEAEF52CDD51F8F991F2F8AFA314FEAAECB* L_48 = ((L_46)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_47)))->___Message_2;
		V_6 = L_48;
		// if (now - m_storedMessages[slot].LastSent < (m_resendDelay * 0.35))
		double L_49 = ___now0;
		NetStoredReliableMessageU5BU5D_t23591445FC2D24CA762300B550255D630D65C634* L_50 = __this->___m_storedMessages_7;
		int32_t L_51 = V_5;
		NullCheck(L_50);
		double L_52 = ((L_50)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_51)))->___LastSent_1;
		double L_53 = __this->___m_resendDelay_8;
		if ((((double)((double)il2cpp_codegen_subtract(L_49, L_52))) < ((double)((double)il2cpp_codegen_multiply(L_53, (0.34999999999999998))))))
		{
			goto IL_01ac;
		}
	}
	{
		// m_storedMessages[slot].LastSent = now;
		NetStoredReliableMessageU5BU5D_t23591445FC2D24CA762300B550255D630D65C634* L_54 = __this->___m_storedMessages_7;
		int32_t L_55 = V_5;
		NullCheck(L_54);
		double L_56 = ___now0;
		((L_54)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_55)))->___LastSent_1 = L_56;
		// m_storedMessages[slot].NumSent++;
		NetStoredReliableMessageU5BU5D_t23591445FC2D24CA762300B550255D630D65C634* L_57 = __this->___m_storedMessages_7;
		int32_t L_58 = V_5;
		NullCheck(L_57);
		int32_t* L_59 = (&((L_57)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_58)))->___NumSent_0);
		int32_t* L_60 = L_59;
		int32_t L_61 = *((int32_t*)L_60);
		*((int32_t*)L_60) = (int32_t)((int32_t)il2cpp_codegen_add(L_61, 1));
		// Interlocked.Increment(ref rmsg.m_recyclingCount); // increment this since it's being decremented in QueueSendMessage
		NetOutgoingMessage_t2C00CEEAEF52CDD51F8F991F2F8AFA314FEAAECB* L_62 = V_6;
		NullCheck(L_62);
		int32_t* L_63 = (&L_62->___m_recyclingCount_11);
		int32_t L_64;
		L_64 = Interlocked_Increment_m7AC68EC482A6AFD97BCEFABA0FD45D203F3EA2E1(L_63, NULL);
		// m_connection.QueueSendMessage(rmsg, rnr);
		NetConnection_tBC8B4699CF2D1614FF259EE7E3031D8D25E31F9D* L_65 = __this->___m_connection_1;
		NetOutgoingMessage_t2C00CEEAEF52CDD51F8F991F2F8AFA314FEAAECB* L_66 = V_6;
		int32_t L_67 = V_2;
		NullCheck(L_65);
		NetConnection_QueueSendMessage_mCD87B7FD21EE3A2B3FF0D786ACDF6CBB4441721D(L_65, L_66, L_67, NULL);
	}

IL_01ac:
	{
		// } while (rnr != m_windowStart);
		int32_t L_68 = V_2;
		int32_t L_69 = __this->___m_windowStart_2;
		if ((!(((uint32_t)L_68) == ((uint32_t)L_69))))
		{
			goto IL_00ef;
		}
	}
	{
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
// System.Void Lidgren.Network.NetReliableSequencedReceiver::.ctor(Lidgren.Network.NetConnection,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void NetReliableSequencedReceiver__ctor_m8583D9E5CEBB10986F490BA830DA339AF0BF8B44 (NetReliableSequencedReceiver_tD29A0B141AC897E64B68250EDAEA8BD32B4FE85E* __this, NetConnection_tBC8B4699CF2D1614FF259EE7E3031D8D25E31F9D* ___connection0, int32_t ___windowSize1, const RuntimeMethod* method) 
{
{
		// : base(connection)
		NetConnection_tBC8B4699CF2D1614FF259EE7E3031D8D25E31F9D* L_0 = ___connection0;
		NetReceiverChannelBase__ctor_mA040707B5F73BB55192C0F44821F5326EC315A99(__this, L_0, NULL);
		// m_windowSize = windowSize;
		int32_t L_1 = ___windowSize1;
		__this->___m_windowSize_3 = L_1;
		// }
		return;
	}
}
// System.Void Lidgren.Network.NetReliableSequencedReceiver::AdvanceWindow()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void NetReliableSequencedReceiver_AdvanceWindow_mBC1EA76BE668A8DAE0C7761DF9044A3EA948210B (NetReliableSequencedReceiver_tD29A0B141AC897E64B68250EDAEA8BD32B4FE85E* __this, const RuntimeMethod* method) 
{
{
		// m_windowStart = (m_windowStart + 1) % NetConstants.NumSequenceNumbers;
		int32_t L_0 = __this->___m_windowStart_2;
		__this->___m_windowStart_2 = ((int32_t)(((int32_t)il2cpp_codegen_add(L_0, 1))%((int32_t)1024)));
		// }
		return;
	}
}
// System.Void Lidgren.Network.NetReliableSequencedReceiver::ReceiveMessage(Lidgren.Network.NetIncomingMessage)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void NetReliableSequencedReceiver_ReceiveMessage_m3CE053CF6AB76E51DE63BF1C72B7E48A4B1F0B8D (NetReliableSequencedReceiver_tD29A0B141AC897E64B68250EDAEA8BD32B4FE85E* __this, NetIncomingMessage_t5E80A584865BF84B3148130AE0CE9A0794DD0A71* ___message0, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&NetUtility_t0B01E9514810CE3FC3B5E83D8427CBA1C5689EFD_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
int32_t V_0 = 0;
	int32_t V_1 = 0;
	{
		// int nr = message.m_sequenceNumber;
		NetIncomingMessage_t5E80A584865BF84B3148130AE0CE9A0794DD0A71* L_0 = ___message0;
		NullCheck(L_0);
		int32_t L_1 = L_0->___m_sequenceNumber_12;
		V_0 = L_1;
		// int relate = NetUtility.RelativeSequenceNumber(nr, m_windowStart);
		int32_t L_2 = V_0;
		int32_t L_3 = __this->___m_windowStart_2;
		il2cpp_codegen_runtime_class_init_inline(NetUtility_t0B01E9514810CE3FC3B5E83D8427CBA1C5689EFD_il2cpp_TypeInfo_var);
		int32_t L_4;
		L_4 = NetUtility_RelativeSequenceNumber_m5DE5D4F0FE867CF19738194E727E1437A81B69B7(L_2, L_3, NULL);
		V_1 = L_4;
		// m_connection.QueueAck(message.m_receivedMessageType, nr);
		NetConnection_tBC8B4699CF2D1614FF259EE7E3031D8D25E31F9D* L_5 = ((NetReceiverChannelBase_t56118523C994D57E27F048D445AFF933D49CCA3C*)__this)->___m_connection_1;
		NetIncomingMessage_t5E80A584865BF84B3148130AE0CE9A0794DD0A71* L_6 = ___message0;
		NullCheck(L_6);
		uint8_t L_7 = L_6->___m_receivedMessageType_13;
		int32_t L_8 = V_0;
		NullCheck(L_5);
		NetConnection_QueueAck_m6C5B3CECC443C7C33B67117795A5A0307C0EC179(L_5, L_7, L_8, NULL);
		// if (relate == 0)
		int32_t L_9 = V_1;
		if (L_9)
		{
			goto IL_003c;
		}
	}
	{
		// AdvanceWindow();
		NetReliableSequencedReceiver_AdvanceWindow_mBC1EA76BE668A8DAE0C7761DF9044A3EA948210B(__this, NULL);
		// m_peer.ReleaseMessage(message);
		NetPeer_tDCD3AC5FB42BE47DEE7AEEA74F327C1E0D883542* L_10 = ((NetReceiverChannelBase_t56118523C994D57E27F048D445AFF933D49CCA3C*)__this)->___m_peer_0;
		NetIncomingMessage_t5E80A584865BF84B3148130AE0CE9A0794DD0A71* L_11 = ___message0;
		NullCheck(L_10);
		NetPeer_ReleaseMessage_m360CE8B0C167EB96DCA5DDAE43E76E6C6AA68D2B(L_10, L_11, NULL);
		// return;
		return;
	}

IL_003c:
	{
		// if (relate < 0)
		int32_t L_12 = V_1;
		if ((((int32_t)L_12) >= ((int32_t)0)))
		{
			goto IL_0041;
		}
	}
	{
		// return;
		return;
	}

IL_0041:
	{
		// if (relate > m_windowSize)
		int32_t L_13 = V_1;
		int32_t L_14 = __this->___m_windowSize_3;
		if ((((int32_t)L_13) <= ((int32_t)L_14)))
		{
			goto IL_004b;
		}
	}
	{
		// return;
		return;
	}

IL_004b:
	{
		// m_windowStart = (m_windowStart + relate) % NetConstants.NumSequenceNumbers;
		int32_t L_15 = __this->___m_windowStart_2;
		int32_t L_16 = V_1;
		__this->___m_windowStart_2 = ((int32_t)(((int32_t)il2cpp_codegen_add(L_15, L_16))%((int32_t)1024)));
		// m_peer.ReleaseMessage(message);
		NetPeer_tDCD3AC5FB42BE47DEE7AEEA74F327C1E0D883542* L_17 = ((NetReceiverChannelBase_t56118523C994D57E27F048D445AFF933D49CCA3C*)__this)->___m_peer_0;
		NetIncomingMessage_t5E80A584865BF84B3148130AE0CE9A0794DD0A71* L_18 = ___message0;
		NullCheck(L_17);
		NetPeer_ReleaseMessage_m360CE8B0C167EB96DCA5DDAE43E76E6C6AA68D2B(L_17, L_18, NULL);
		// return;
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
// System.Void Lidgren.Network.NetReliableUnorderedReceiver::.ctor(Lidgren.Network.NetConnection,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void NetReliableUnorderedReceiver__ctor_m35F0963BD82A5FCC3894C834BD6507DE873C5D96 (NetReliableUnorderedReceiver_t220A30799285402D92F29CB2DCF8175041C817E7* __this, NetConnection_tBC8B4699CF2D1614FF259EE7E3031D8D25E31F9D* ___connection0, int32_t ___windowSize1, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&NetBitVector_tF8CA8B405111502BD2A21BADB51D903E2E21FF67_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
{
		// : base(connection)
		NetConnection_tBC8B4699CF2D1614FF259EE7E3031D8D25E31F9D* L_0 = ___connection0;
		NetReceiverChannelBase__ctor_mA040707B5F73BB55192C0F44821F5326EC315A99(__this, L_0, NULL);
		// m_windowSize = windowSize;
		int32_t L_1 = ___windowSize1;
		__this->___m_windowSize_3 = L_1;
		// m_earlyReceived = new NetBitVector(windowSize);
		int32_t L_2 = ___windowSize1;
		NetBitVector_tF8CA8B405111502BD2A21BADB51D903E2E21FF67* L_3 = (NetBitVector_tF8CA8B405111502BD2A21BADB51D903E2E21FF67*)il2cpp_codegen_object_new(NetBitVector_tF8CA8B405111502BD2A21BADB51D903E2E21FF67_il2cpp_TypeInfo_var);
		NetBitVector__ctor_mEFF54B813F6C5472ED26A05E548B460CAB39B4A5(L_3, L_2, /*hidden argument*/NULL);
		__this->___m_earlyReceived_4 = L_3;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___m_earlyReceived_4), (void*)L_3);
		// }
		return;
	}
}
// System.Void Lidgren.Network.NetReliableUnorderedReceiver::AdvanceWindow()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void NetReliableUnorderedReceiver_AdvanceWindow_m9F2579C32D72AC9063A848C7E609D7CF14BA46F0 (NetReliableUnorderedReceiver_t220A30799285402D92F29CB2DCF8175041C817E7* __this, const RuntimeMethod* method) 
{
{
		// m_earlyReceived.Set(m_windowStart % m_windowSize, false);
		NetBitVector_tF8CA8B405111502BD2A21BADB51D903E2E21FF67* L_0 = __this->___m_earlyReceived_4;
		int32_t L_1 = __this->___m_windowStart_2;
		int32_t L_2 = __this->___m_windowSize_3;
		NullCheck(L_0);
		NetBitVector_Set_m7E4E2CA6DD0E5A969B25A19857A3C8F01694AF3D(L_0, ((int32_t)(L_1%L_2)), (bool)0, NULL);
		// m_windowStart = (m_windowStart + 1) % NetConstants.NumSequenceNumbers;
		int32_t L_3 = __this->___m_windowStart_2;
		__this->___m_windowStart_2 = ((int32_t)(((int32_t)il2cpp_codegen_add(L_3, 1))%((int32_t)1024)));
		// }
		return;
	}
}
// System.Void Lidgren.Network.NetReliableUnorderedReceiver::ReceiveMessage(Lidgren.Network.NetIncomingMessage)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void NetReliableUnorderedReceiver_ReceiveMessage_m8C3542B003675F82D2790FAC8BAA46F78F57C622 (NetReliableUnorderedReceiver_t220A30799285402D92F29CB2DCF8175041C817E7* __this, NetIncomingMessage_t5E80A584865BF84B3148130AE0CE9A0794DD0A71* ___message0, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&NetUtility_t0B01E9514810CE3FC3B5E83D8427CBA1C5689EFD_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
int32_t V_0 = 0;
	int32_t V_1 = 0;
	{
		// int relate = NetUtility.RelativeSequenceNumber(message.m_sequenceNumber, m_windowStart);
		NetIncomingMessage_t5E80A584865BF84B3148130AE0CE9A0794DD0A71* L_0 = ___message0;
		NullCheck(L_0);
		int32_t L_1 = L_0->___m_sequenceNumber_12;
		int32_t L_2 = __this->___m_windowStart_2;
		il2cpp_codegen_runtime_class_init_inline(NetUtility_t0B01E9514810CE3FC3B5E83D8427CBA1C5689EFD_il2cpp_TypeInfo_var);
		int32_t L_3;
		L_3 = NetUtility_RelativeSequenceNumber_m5DE5D4F0FE867CF19738194E727E1437A81B69B7(L_1, L_2, NULL);
		V_0 = L_3;
		// m_connection.QueueAck(message.m_receivedMessageType, message.m_sequenceNumber);
		NetConnection_tBC8B4699CF2D1614FF259EE7E3031D8D25E31F9D* L_4 = ((NetReceiverChannelBase_t56118523C994D57E27F048D445AFF933D49CCA3C*)__this)->___m_connection_1;
		NetIncomingMessage_t5E80A584865BF84B3148130AE0CE9A0794DD0A71* L_5 = ___message0;
		NullCheck(L_5);
		uint8_t L_6 = L_5->___m_receivedMessageType_13;
		NetIncomingMessage_t5E80A584865BF84B3148130AE0CE9A0794DD0A71* L_7 = ___message0;
		NullCheck(L_7);
		int32_t L_8 = L_7->___m_sequenceNumber_12;
		NullCheck(L_4);
		NetConnection_QueueAck_m6C5B3CECC443C7C33B67117795A5A0307C0EC179(L_4, L_6, L_8, NULL);
		// if (relate == 0)
		int32_t L_9 = V_0;
		if (L_9)
		{
			goto IL_006f;
		}
	}
	{
		// AdvanceWindow();
		NetReliableUnorderedReceiver_AdvanceWindow_m9F2579C32D72AC9063A848C7E609D7CF14BA46F0(__this, NULL);
		// m_peer.ReleaseMessage(message);
		NetPeer_tDCD3AC5FB42BE47DEE7AEEA74F327C1E0D883542* L_10 = ((NetReceiverChannelBase_t56118523C994D57E27F048D445AFF933D49CCA3C*)__this)->___m_peer_0;
		NetIncomingMessage_t5E80A584865BF84B3148130AE0CE9A0794DD0A71* L_11 = ___message0;
		NullCheck(L_10);
		NetPeer_ReleaseMessage_m360CE8B0C167EB96DCA5DDAE43E76E6C6AA68D2B(L_10, L_11, NULL);
		// int nextSeqNr = (message.m_sequenceNumber + 1) % NetConstants.NumSequenceNumbers;
		NetIncomingMessage_t5E80A584865BF84B3148130AE0CE9A0794DD0A71* L_12 = ___message0;
		NullCheck(L_12);
		int32_t L_13 = L_12->___m_sequenceNumber_12;
		V_1 = ((int32_t)(((int32_t)il2cpp_codegen_add(L_13, 1))%((int32_t)1024)));
		goto IL_0059;
	}

IL_004f:
	{
		// AdvanceWindow();
		NetReliableUnorderedReceiver_AdvanceWindow_m9F2579C32D72AC9063A848C7E609D7CF14BA46F0(__this, NULL);
		// nextSeqNr++;
		int32_t L_14 = V_1;
		V_1 = ((int32_t)il2cpp_codegen_add(L_14, 1));
	}

IL_0059:
	{
		// while (m_earlyReceived[nextSeqNr % m_windowSize])
		NetBitVector_tF8CA8B405111502BD2A21BADB51D903E2E21FF67* L_15 = __this->___m_earlyReceived_4;
		int32_t L_16 = V_1;
		int32_t L_17 = __this->___m_windowSize_3;
		NullCheck(L_15);
		bool L_18;
		L_18 = NetBitVector_get_Bit_mACF2056FB118F8346E8A850CB15B69046790D448(L_15, ((int32_t)(L_16%L_17)), NULL);
		if (L_18)
		{
			goto IL_004f;
		}
	}
	{
		// return;
		return;
	}

IL_006f:
	{
		// if (relate < 0)
		int32_t L_19 = V_0;
		if ((((int32_t)L_19) >= ((int32_t)0)))
		{
			goto IL_0074;
		}
	}
	{
		// return;
		return;
	}

IL_0074:
	{
		// if (relate > m_windowSize)
		int32_t L_20 = V_0;
		int32_t L_21 = __this->___m_windowSize_3;
		if ((((int32_t)L_20) <= ((int32_t)L_21)))
		{
			goto IL_007e;
		}
	}
	{
		// return;
		return;
	}

IL_007e:
	{
		// if (m_earlyReceived.Get(message.m_sequenceNumber % m_windowSize))
		NetBitVector_tF8CA8B405111502BD2A21BADB51D903E2E21FF67* L_22 = __this->___m_earlyReceived_4;
		NetIncomingMessage_t5E80A584865BF84B3148130AE0CE9A0794DD0A71* L_23 = ___message0;
		NullCheck(L_23);
		int32_t L_24 = L_23->___m_sequenceNumber_12;
		int32_t L_25 = __this->___m_windowSize_3;
		NullCheck(L_22);
		bool L_26;
		L_26 = NetBitVector_Get_mE0B3D426B63909C7F2989889D270AE4C5C3DEF55(L_22, ((int32_t)(L_24%L_25)), NULL);
		if (!L_26)
		{
			goto IL_0099;
		}
	}
	{
		// return;
		return;
	}

IL_0099:
	{
		// m_earlyReceived.Set(message.m_sequenceNumber % m_windowSize, true);
		NetBitVector_tF8CA8B405111502BD2A21BADB51D903E2E21FF67* L_27 = __this->___m_earlyReceived_4;
		NetIncomingMessage_t5E80A584865BF84B3148130AE0CE9A0794DD0A71* L_28 = ___message0;
		NullCheck(L_28);
		int32_t L_29 = L_28->___m_sequenceNumber_12;
		int32_t L_30 = __this->___m_windowSize_3;
		NullCheck(L_27);
		NetBitVector_Set_m7E4E2CA6DD0E5A969B25A19857A3C8F01694AF3D(L_27, ((int32_t)(L_29%L_30)), (bool)1, NULL);
		// m_peer.ReleaseMessage(message);
		NetPeer_tDCD3AC5FB42BE47DEE7AEEA74F327C1E0D883542* L_31 = ((NetReceiverChannelBase_t56118523C994D57E27F048D445AFF933D49CCA3C*)__this)->___m_peer_0;
		NetIncomingMessage_t5E80A584865BF84B3148130AE0CE9A0794DD0A71* L_32 = ___message0;
		NullCheck(L_31);
		NetPeer_ReleaseMessage_m360CE8B0C167EB96DCA5DDAE43E76E6C6AA68D2B(L_31, L_32, NULL);
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
// System.Int32 Lidgren.Network.NetSenderChannelBase::get_QueuedSendsCount()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t NetSenderChannelBase_get_QueuedSendsCount_m3FE62E6A5A1C86DD2F804E4A5761453574C0CFBA (NetSenderChannelBase_t60E3BDE4FA746EE6C8453DD201764C0B7D6948A2* __this, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&NetQueue_1_get_Count_m9D0B8118A5875517A26773BBA576C2006810DE22_RuntimeMethod_var);
		s_Il2CppMethodInitialized = true;
	}
{
		// internal int QueuedSendsCount { get { return m_queuedSends.Count; } }
		NetQueue_1_tE04A2248A2948BB1FCEAAF0A1151D27B56B71EA3* L_0 = __this->___m_queuedSends_0;
		NullCheck(L_0);
		int32_t L_1;
		L_1 = NetQueue_1_get_Count_m9D0B8118A5875517A26773BBA576C2006810DE22(L_0, NetQueue_1_get_Count_m9D0B8118A5875517A26773BBA576C2006810DE22_RuntimeMethod_var);
		return L_1;
	}
}
// System.Boolean Lidgren.Network.NetSenderChannelBase::NeedToSendMessages()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool NetSenderChannelBase_NeedToSendMessages_mBB0A6D332A3FD353AFD613B32A96E481AB617260 (NetSenderChannelBase_t60E3BDE4FA746EE6C8453DD201764C0B7D6948A2* __this, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&NetQueue_1_get_Count_m9D0B8118A5875517A26773BBA576C2006810DE22_RuntimeMethod_var);
		s_Il2CppMethodInitialized = true;
	}
{
		// internal virtual bool NeedToSendMessages() { return m_queuedSends.Count > 0; }
		NetQueue_1_tE04A2248A2948BB1FCEAAF0A1151D27B56B71EA3* L_0 = __this->___m_queuedSends_0;
		NullCheck(L_0);
		int32_t L_1;
		L_1 = NetQueue_1_get_Count_m9D0B8118A5875517A26773BBA576C2006810DE22(L_0, NetQueue_1_get_Count_m9D0B8118A5875517A26773BBA576C2006810DE22_RuntimeMethod_var);
		return (bool)((((int32_t)L_1) > ((int32_t)0))? 1 : 0);
	}
}
// System.Int32 Lidgren.Network.NetSenderChannelBase::GetFreeWindowSlots()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t NetSenderChannelBase_GetFreeWindowSlots_m9E5EB570F97B9D2477E655C8A3DA1E17167E8C2D (NetSenderChannelBase_t60E3BDE4FA746EE6C8453DD201764C0B7D6948A2* __this, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&NetQueue_1_get_Count_m9D0B8118A5875517A26773BBA576C2006810DE22_RuntimeMethod_var);
		s_Il2CppMethodInitialized = true;
	}
{
		// return GetAllowedSends() - m_queuedSends.Count;
		int32_t L_0;
		L_0 = VirtualFuncInvoker0< int32_t >::Invoke(5 /* System.Int32 Lidgren.Network.NetSenderChannelBase::GetAllowedSends() */, __this);
		NetQueue_1_tE04A2248A2948BB1FCEAAF0A1151D27B56B71EA3* L_1 = __this->___m_queuedSends_0;
		NullCheck(L_1);
		int32_t L_2;
		L_2 = NetQueue_1_get_Count_m9D0B8118A5875517A26773BBA576C2006810DE22(L_1, NetQueue_1_get_Count_m9D0B8118A5875517A26773BBA576C2006810DE22_RuntimeMethod_var);
		return ((int32_t)il2cpp_codegen_subtract(L_0, L_2));
	}
}
// System.Void Lidgren.Network.NetSenderChannelBase::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void NetSenderChannelBase__ctor_m4F33557333904C43F29ED7D4153AAE87A49F8A0C (NetSenderChannelBase_t60E3BDE4FA746EE6C8453DD201764C0B7D6948A2* __this, const RuntimeMethod* method) 
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
// System.Void Lidgren.Network.NetServer::.ctor(Lidgren.Network.NetPeerConfiguration)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void NetServer__ctor_m3233571C74632F23FA8228E0761C49FC89916BAB (NetServer_tD42376D31E46BCB7E7502576EE48D3DEFCDBD342* __this, NetPeerConfiguration_t7BA55B2118BE6EC975E65EEE156B05E72A3339DD* ___config0, const RuntimeMethod* method) 
{
{
		// : base(config)
		NetPeerConfiguration_t7BA55B2118BE6EC975E65EEE156B05E72A3339DD* L_0 = ___config0;
		NetPeer__ctor_mA664869D02F67AF07AC4C4FA561FE198BCB7D49E(__this, L_0, NULL);
		// config.AcceptIncomingConnections = true;
		NetPeerConfiguration_t7BA55B2118BE6EC975E65EEE156B05E72A3339DD* L_1 = ___config0;
		NullCheck(L_1);
		NetPeerConfiguration_set_AcceptIncomingConnections_mEB37F905BF5640D0CD9241ABC0302F90AA43D372_inline(L_1, (bool)1, NULL);
		// }
		return;
	}
}
// System.Void Lidgren.Network.NetServer::SendToAll(Lidgren.Network.NetOutgoingMessage,Lidgren.Network.NetDeliveryMethod)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void NetServer_SendToAll_mAC2DD44E4633EA69DC7E9E0BF7609D9AAD7FA2D3 (NetServer_tD42376D31E46BCB7E7502576EE48D3DEFCDBD342* __this, NetOutgoingMessage_t2C00CEEAEF52CDD51F8F991F2F8AFA314FEAAECB* ___msg0, uint8_t ___method1, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_get_Count_m2718A4E7883478B0124E79583E511312C71D8CC8_RuntimeMethod_var);
		s_Il2CppMethodInitialized = true;
	}
List_1_tCB8A580EE26829F92BEF512FF7897CF3EF16121F* V_0 = NULL;
	{
		// var all = m_connections;
		List_1_tCB8A580EE26829F92BEF512FF7897CF3EF16121F* L_0 = ((NetPeer_tDCD3AC5FB42BE47DEE7AEEA74F327C1E0D883542*)__this)->___m_connections_6;
		V_0 = L_0;
		// if (all.Count <= 0) {
		List_1_tCB8A580EE26829F92BEF512FF7897CF3EF16121F* L_1 = V_0;
		NullCheck(L_1);
		int32_t L_2;
		L_2 = List_1_get_Count_m2718A4E7883478B0124E79583E511312C71D8CC8_inline(L_1, List_1_get_Count_m2718A4E7883478B0124E79583E511312C71D8CC8_RuntimeMethod_var);
		if ((((int32_t)L_2) > ((int32_t)0)))
		{
			goto IL_0020;
		}
	}
	{
		// if (msg.m_isSent == false)
		NetOutgoingMessage_t2C00CEEAEF52CDD51F8F991F2F8AFA314FEAAECB* L_3 = ___msg0;
		NullCheck(L_3);
		bool L_4 = L_3->___m_isSent_10;
		if (L_4)
		{
			goto IL_001f;
		}
	}
	{
		// Recycle(msg);
		NetOutgoingMessage_t2C00CEEAEF52CDD51F8F991F2F8AFA314FEAAECB* L_5 = ___msg0;
		NetPeer_Recycle_m19CD3E9FAB66822D78395ABD6E23DA7F58AA178E(__this, L_5, NULL);
	}

IL_001f:
	{
		// return;
		return;
	}

IL_0020:
	{
		// SendMessage(msg, all, method, 0);
		NetOutgoingMessage_t2C00CEEAEF52CDD51F8F991F2F8AFA314FEAAECB* L_6 = ___msg0;
		List_1_tCB8A580EE26829F92BEF512FF7897CF3EF16121F* L_7 = V_0;
		uint8_t L_8 = ___method1;
		NetPeer_SendMessage_mB9DAB98AA72E4B244D58DA334AD4939B36E4AFC2(__this, L_6, L_7, L_8, 0, NULL);
		// }
		return;
	}
}
// System.Void Lidgren.Network.NetServer::SendToAll(Lidgren.Network.NetOutgoingMessage,Lidgren.Network.NetDeliveryMethod,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void NetServer_SendToAll_mFD97FB93666F3597286E4809BF3FD2FD75968855 (NetServer_tD42376D31E46BCB7E7502576EE48D3DEFCDBD342* __this, NetOutgoingMessage_t2C00CEEAEF52CDD51F8F991F2F8AFA314FEAAECB* ___msg0, uint8_t ___method1, int32_t ___sequenceChannel2, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_get_Count_m2718A4E7883478B0124E79583E511312C71D8CC8_RuntimeMethod_var);
		s_Il2CppMethodInitialized = true;
	}
List_1_tCB8A580EE26829F92BEF512FF7897CF3EF16121F* V_0 = NULL;
	{
		// var all = m_connections;
		List_1_tCB8A580EE26829F92BEF512FF7897CF3EF16121F* L_0 = ((NetPeer_tDCD3AC5FB42BE47DEE7AEEA74F327C1E0D883542*)__this)->___m_connections_6;
		V_0 = L_0;
		// if (all.Count <= 0) {
		List_1_tCB8A580EE26829F92BEF512FF7897CF3EF16121F* L_1 = V_0;
		NullCheck(L_1);
		int32_t L_2;
		L_2 = List_1_get_Count_m2718A4E7883478B0124E79583E511312C71D8CC8_inline(L_1, List_1_get_Count_m2718A4E7883478B0124E79583E511312C71D8CC8_RuntimeMethod_var);
		if ((((int32_t)L_2) > ((int32_t)0)))
		{
			goto IL_0020;
		}
	}
	{
		// if (msg.m_isSent == false)
		NetOutgoingMessage_t2C00CEEAEF52CDD51F8F991F2F8AFA314FEAAECB* L_3 = ___msg0;
		NullCheck(L_3);
		bool L_4 = L_3->___m_isSent_10;
		if (L_4)
		{
			goto IL_001f;
		}
	}
	{
		// Recycle(msg);
		NetOutgoingMessage_t2C00CEEAEF52CDD51F8F991F2F8AFA314FEAAECB* L_5 = ___msg0;
		NetPeer_Recycle_m19CD3E9FAB66822D78395ABD6E23DA7F58AA178E(__this, L_5, NULL);
	}

IL_001f:
	{
		// return;
		return;
	}

IL_0020:
	{
		// SendMessage(msg, all, method, sequenceChannel);
		NetOutgoingMessage_t2C00CEEAEF52CDD51F8F991F2F8AFA314FEAAECB* L_6 = ___msg0;
		List_1_tCB8A580EE26829F92BEF512FF7897CF3EF16121F* L_7 = V_0;
		uint8_t L_8 = ___method1;
		int32_t L_9 = ___sequenceChannel2;
		NetPeer_SendMessage_mB9DAB98AA72E4B244D58DA334AD4939B36E4AFC2(__this, L_6, L_7, L_8, L_9, NULL);
		// }
		return;
	}
}
// System.Void Lidgren.Network.NetServer::SendToAll(Lidgren.Network.NetOutgoingMessage,Lidgren.Network.NetConnection,Lidgren.Network.NetDeliveryMethod,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void NetServer_SendToAll_m7B6A83BAACA2C572237FB7061A0A0805F49CB4BB (NetServer_tD42376D31E46BCB7E7502576EE48D3DEFCDBD342* __this, NetOutgoingMessage_t2C00CEEAEF52CDD51F8F991F2F8AFA314FEAAECB* ___msg0, NetConnection_tBC8B4699CF2D1614FF259EE7E3031D8D25E31F9D* ___except1, uint8_t ___method2, int32_t ___sequenceChannel3, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Enumerator_Dispose_m07181BB10C1BA5DC601AE525BD8135BC4EB56FBD_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Enumerator_MoveNext_m85D3F022A9B8C14AF8EAECDBC6AD2758243E2267_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Enumerator_get_Current_m6E66C77AF2421CC882C1A0DD5B0BFF34A4BE4214_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_Add_m8CE33AF029F57595E3FF186EE02E159E0EBB6DE3_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_GetEnumerator_mA1703FADFF65E89C664E1AC2C224E137EDCE0FAA_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1__ctor_mD729DF400FADFA39FCECE0669139C521DD2D110C_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_get_Count_m2718A4E7883478B0124E79583E511312C71D8CC8_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_tCB8A580EE26829F92BEF512FF7897CF3EF16121F_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
List_1_tCB8A580EE26829F92BEF512FF7897CF3EF16121F* V_0 = NULL;
	List_1_tCB8A580EE26829F92BEF512FF7897CF3EF16121F* V_1 = NULL;
	Enumerator_t544F92AE49BEB4DE05D485E77C4AB2E71862B6A4 V_2;
	memset((&V_2), 0, sizeof(V_2));
	NetConnection_tBC8B4699CF2D1614FF259EE7E3031D8D25E31F9D* V_3 = NULL;
	{
		// var all = m_connections;
		List_1_tCB8A580EE26829F92BEF512FF7897CF3EF16121F* L_0 = ((NetPeer_tDCD3AC5FB42BE47DEE7AEEA74F327C1E0D883542*)__this)->___m_connections_6;
		V_0 = L_0;
		// if (all.Count <= 0) {
		List_1_tCB8A580EE26829F92BEF512FF7897CF3EF16121F* L_1 = V_0;
		NullCheck(L_1);
		int32_t L_2;
		L_2 = List_1_get_Count_m2718A4E7883478B0124E79583E511312C71D8CC8_inline(L_1, List_1_get_Count_m2718A4E7883478B0124E79583E511312C71D8CC8_RuntimeMethod_var);
		if ((((int32_t)L_2) > ((int32_t)0)))
		{
			goto IL_0020;
		}
	}
	{
		// if (msg.m_isSent == false)
		NetOutgoingMessage_t2C00CEEAEF52CDD51F8F991F2F8AFA314FEAAECB* L_3 = ___msg0;
		NullCheck(L_3);
		bool L_4 = L_3->___m_isSent_10;
		if (L_4)
		{
			goto IL_001f;
		}
	}
	{
		// Recycle(msg);
		NetOutgoingMessage_t2C00CEEAEF52CDD51F8F991F2F8AFA314FEAAECB* L_5 = ___msg0;
		NetPeer_Recycle_m19CD3E9FAB66822D78395ABD6E23DA7F58AA178E(__this, L_5, NULL);
	}

IL_001f:
	{
		// return;
		return;
	}

IL_0020:
	{
		// if (except == null)
		NetConnection_tBC8B4699CF2D1614FF259EE7E3031D8D25E31F9D* L_6 = ___except1;
		if (L_6)
		{
			goto IL_002f;
		}
	}
	{
		// SendMessage(msg, all, method, sequenceChannel);
		NetOutgoingMessage_t2C00CEEAEF52CDD51F8F991F2F8AFA314FEAAECB* L_7 = ___msg0;
		List_1_tCB8A580EE26829F92BEF512FF7897CF3EF16121F* L_8 = V_0;
		uint8_t L_9 = ___method2;
		int32_t L_10 = ___sequenceChannel3;
		NetPeer_SendMessage_mB9DAB98AA72E4B244D58DA334AD4939B36E4AFC2(__this, L_7, L_8, L_9, L_10, NULL);
		// return;
		return;
	}

IL_002f:
	{
		// List<NetConnection> recipients = new List<NetConnection>(all.Count - 1);
		List_1_tCB8A580EE26829F92BEF512FF7897CF3EF16121F* L_11 = V_0;
		NullCheck(L_11);
		int32_t L_12;
		L_12 = List_1_get_Count_m2718A4E7883478B0124E79583E511312C71D8CC8_inline(L_11, List_1_get_Count_m2718A4E7883478B0124E79583E511312C71D8CC8_RuntimeMethod_var);
		List_1_tCB8A580EE26829F92BEF512FF7897CF3EF16121F* L_13 = (List_1_tCB8A580EE26829F92BEF512FF7897CF3EF16121F*)il2cpp_codegen_object_new(List_1_tCB8A580EE26829F92BEF512FF7897CF3EF16121F_il2cpp_TypeInfo_var);
		List_1__ctor_mD729DF400FADFA39FCECE0669139C521DD2D110C(L_13, ((int32_t)il2cpp_codegen_subtract(L_12, 1)), /*hidden argument*/List_1__ctor_mD729DF400FADFA39FCECE0669139C521DD2D110C_RuntimeMethod_var);
		V_1 = L_13;
		// foreach (var conn in all)
		List_1_tCB8A580EE26829F92BEF512FF7897CF3EF16121F* L_14 = V_0;
		NullCheck(L_14);
		Enumerator_t544F92AE49BEB4DE05D485E77C4AB2E71862B6A4 L_15;
		L_15 = List_1_GetEnumerator_mA1703FADFF65E89C664E1AC2C224E137EDCE0FAA(L_14, List_1_GetEnumerator_mA1703FADFF65E89C664E1AC2C224E137EDCE0FAA_RuntimeMethod_var);
		V_2 = L_15;
	}

IL_0044:
	{
		auto __finallyBlock = il2cpp::utils::Finally([&]
		{

FINALLY_0064:
			{// begin finally (depth: 1)
				Enumerator_Dispose_m07181BB10C1BA5DC601AE525BD8135BC4EB56FBD((&V_2), Enumerator_Dispose_m07181BB10C1BA5DC601AE525BD8135BC4EB56FBD_RuntimeMethod_var);
				return;
			}// end finally (depth: 1)
		});
		try
		{// begin try (depth: 1)
			{
				goto IL_0059;
			}

IL_0046:
			{
				// foreach (var conn in all)
				NetConnection_tBC8B4699CF2D1614FF259EE7E3031D8D25E31F9D* L_16;
				L_16 = Enumerator_get_Current_m6E66C77AF2421CC882C1A0DD5B0BFF34A4BE4214_inline((&V_2), Enumerator_get_Current_m6E66C77AF2421CC882C1A0DD5B0BFF34A4BE4214_RuntimeMethod_var);
				V_3 = L_16;
				// if (conn != except)
				NetConnection_tBC8B4699CF2D1614FF259EE7E3031D8D25E31F9D* L_17 = V_3;
				NetConnection_tBC8B4699CF2D1614FF259EE7E3031D8D25E31F9D* L_18 = ___except1;
				if ((((RuntimeObject*)(NetConnection_tBC8B4699CF2D1614FF259EE7E3031D8D25E31F9D*)L_17) == ((RuntimeObject*)(NetConnection_tBC8B4699CF2D1614FF259EE7E3031D8D25E31F9D*)L_18)))
				{
					goto IL_0059;
				}
			}

IL_0052:
			{
				// recipients.Add(conn);
				List_1_tCB8A580EE26829F92BEF512FF7897CF3EF16121F* L_19 = V_1;
				NetConnection_tBC8B4699CF2D1614FF259EE7E3031D8D25E31F9D* L_20 = V_3;
				NullCheck(L_19);
				List_1_Add_m8CE33AF029F57595E3FF186EE02E159E0EBB6DE3_inline(L_19, L_20, List_1_Add_m8CE33AF029F57595E3FF186EE02E159E0EBB6DE3_RuntimeMethod_var);
			}

IL_0059:
			{
				// foreach (var conn in all)
				bool L_21;
				L_21 = Enumerator_MoveNext_m85D3F022A9B8C14AF8EAECDBC6AD2758243E2267((&V_2), Enumerator_MoveNext_m85D3F022A9B8C14AF8EAECDBC6AD2758243E2267_RuntimeMethod_var);
				if (L_21)
				{
					goto IL_0046;
				}
			}

IL_0062:
			{
				goto IL_0072;
			}
		}// end try (depth: 1)
		catch(Il2CppExceptionWrapper& e)
		{
			__finallyBlock.StoreException(e.ex);
		}
	}

IL_0072:
	{
		// if (recipients.Count > 0)
		List_1_tCB8A580EE26829F92BEF512FF7897CF3EF16121F* L_22 = V_1;
		NullCheck(L_22);
		int32_t L_23;
		L_23 = List_1_get_Count_m2718A4E7883478B0124E79583E511312C71D8CC8_inline(L_22, List_1_get_Count_m2718A4E7883478B0124E79583E511312C71D8CC8_RuntimeMethod_var);
		if ((((int32_t)L_23) <= ((int32_t)0)))
		{
			goto IL_0086;
		}
	}
	{
		// SendMessage(msg, recipients, method, sequenceChannel);
		NetOutgoingMessage_t2C00CEEAEF52CDD51F8F991F2F8AFA314FEAAECB* L_24 = ___msg0;
		List_1_tCB8A580EE26829F92BEF512FF7897CF3EF16121F* L_25 = V_1;
		uint8_t L_26 = ___method2;
		int32_t L_27 = ___sequenceChannel3;
		NetPeer_SendMessage_mB9DAB98AA72E4B244D58DA334AD4939B36E4AFC2(__this, L_24, L_25, L_26, L_27, NULL);
	}

IL_0086:
	{
		// }
		return;
	}
}
// System.String Lidgren.Network.NetServer::ToString()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* NetServer_ToString_mF94F322AD21639AA0EB3D6F478EC3626E7F91621 (NetServer_tD42376D31E46BCB7E7502576EE48D3DEFCDBD342* __this, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral0AF744421B52F4BED7B731DBE013E5B22C656BBC);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralC4922A689E4721D8F955FD6F8DFFA68DBDF04CA7);
		s_Il2CppMethodInitialized = true;
	}
int32_t V_0 = 0;
	{
		// return "[NetServer " + ConnectionsCount + " connections]";
		int32_t L_0;
		L_0 = NetPeer_get_ConnectionsCount_mE708A4F8CA40ED8F2F1C63143A8AB4603DA7FEBB(__this, NULL);
		V_0 = L_0;
		String_t* L_1;
		L_1 = Int32_ToString_m030E01C24E294D6762FB0B6F37CB541581F55CA5((&V_0), NULL);
		String_t* L_2;
		L_2 = String_Concat_m9B13B47FCB3DF61144D9647DDA05F527377251B0(_stringLiteralC4922A689E4721D8F955FD6F8DFFA68DBDF04CA7, L_1, _stringLiteral0AF744421B52F4BED7B731DBE013E5B22C656BBC, NULL);
		return L_2;
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
// Lidgren.Network.NetBigInteger Lidgren.Network.NetSRP::ComputeMultiplier()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR NetBigInteger_t06C831F115CE5B02A3EB70F99F2C5ABA75E0FF76* NetSRP_ComputeMultiplier_m755DBE4F28AFCA07BBACBF9A500F550A70CB596C (const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&NetBigInteger_t06C831F115CE5B02A3EB70F99F2C5ABA75E0FF76_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&NetSRP_tCB8425B4A061CEF6A1C0914A06C41D2745DBD951_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&NetUtility_t0B01E9514810CE3FC3B5E83D8427CBA1C5689EFD_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
String_t* V_0 = NULL;
	String_t* V_1 = NULL;
	{
		// string one = NetUtility.ToHexString(N.ToByteArrayUnsigned());
		il2cpp_codegen_runtime_class_init_inline(NetSRP_tCB8425B4A061CEF6A1C0914A06C41D2745DBD951_il2cpp_TypeInfo_var);
		NetBigInteger_t06C831F115CE5B02A3EB70F99F2C5ABA75E0FF76* L_0 = ((NetSRP_tCB8425B4A061CEF6A1C0914A06C41D2745DBD951_StaticFields*)il2cpp_codegen_static_fields_for(NetSRP_tCB8425B4A061CEF6A1C0914A06C41D2745DBD951_il2cpp_TypeInfo_var))->___N_0;
		NullCheck(L_0);
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_1;
		L_1 = NetBigInteger_ToByteArrayUnsigned_m3A7A392C37CD2D701E96AFEF4193B21E451808FD(L_0, NULL);
		il2cpp_codegen_runtime_class_init_inline(NetUtility_t0B01E9514810CE3FC3B5E83D8427CBA1C5689EFD_il2cpp_TypeInfo_var);
		String_t* L_2;
		L_2 = NetUtility_ToHexString_m54E357477D8D0AD283B929917378B10D8E1F380B(L_1, NULL);
		V_0 = L_2;
		// string two = NetUtility.ToHexString(g.ToByteArrayUnsigned());
		NetBigInteger_t06C831F115CE5B02A3EB70F99F2C5ABA75E0FF76* L_3 = ((NetSRP_tCB8425B4A061CEF6A1C0914A06C41D2745DBD951_StaticFields*)il2cpp_codegen_static_fields_for(NetSRP_tCB8425B4A061CEF6A1C0914A06C41D2745DBD951_il2cpp_TypeInfo_var))->___g_1;
		NullCheck(L_3);
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_4;
		L_4 = NetBigInteger_ToByteArrayUnsigned_m3A7A392C37CD2D701E96AFEF4193B21E451808FD(L_3, NULL);
		String_t* L_5;
		L_5 = NetUtility_ToHexString_m54E357477D8D0AD283B929917378B10D8E1F380B(L_4, NULL);
		V_1 = L_5;
		// string ccstr = one + two.PadLeft(one.Length, '0');
		String_t* L_6 = V_0;
		String_t* L_7 = V_1;
		String_t* L_8 = V_0;
		NullCheck(L_8);
		int32_t L_9;
		L_9 = String_get_Length_m42625D67623FA5CC7A44D47425CE86FB946542D2_inline(L_8, NULL);
		NullCheck(L_7);
		String_t* L_10;
		L_10 = String_PadLeft_m99DDD242908E78B71E9631EE66331E8A130EB31F(L_7, L_9, ((int32_t)48), NULL);
		String_t* L_11;
		L_11 = String_Concat_mAF2CE02CC0CB7460753D0A1A91CCF2B1E9804C5D(L_6, L_10, NULL);
		// byte[] cc = NetUtility.ToByteArray(ccstr);
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_12;
		L_12 = NetUtility_ToByteArray_mF9C5C8DB9AB7C82FCE421683EE0FFAFF51510EA8(L_11, NULL);
		// var ccHashed = NetUtility.ComputeSHAHash(cc);
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_13;
		L_13 = NetUtility_ComputeSHAHash_mF0A369753E62EEE4E771C5638C1CB620D0CA48AD(L_12, NULL);
		// return new NetBigInteger(NetUtility.ToHexString(ccHashed), 16);
		String_t* L_14;
		L_14 = NetUtility_ToHexString_m54E357477D8D0AD283B929917378B10D8E1F380B(L_13, NULL);
		NetBigInteger_t06C831F115CE5B02A3EB70F99F2C5ABA75E0FF76* L_15 = (NetBigInteger_t06C831F115CE5B02A3EB70F99F2C5ABA75E0FF76*)il2cpp_codegen_object_new(NetBigInteger_t06C831F115CE5B02A3EB70F99F2C5ABA75E0FF76_il2cpp_TypeInfo_var);
		NetBigInteger__ctor_m4031CDB3BDCE25C1A09226CE4C36004FAC46ED25(L_15, L_14, ((int32_t)16), /*hidden argument*/NULL);
		return L_15;
	}
}
// System.Byte[] Lidgren.Network.NetSRP::CreateRandomSalt()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* NetSRP_CreateRandomSalt_m2350486A3C338F2BC964ED1594CC13D1023901B4 (const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&CryptoRandom_t8B21DF8737471EFF3D15D1ACB0AF83ABA4A600B8_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* V_0 = NULL;
	{
		// byte[] retval = new byte[16];
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_0 = (ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031*)(ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031*)SZArrayNew(ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031_il2cpp_TypeInfo_var, (uint32_t)((int32_t)16));
		V_0 = L_0;
		// CryptoRandom.Instance.NextBytes(retval);
		il2cpp_codegen_runtime_class_init_inline(CryptoRandom_t8B21DF8737471EFF3D15D1ACB0AF83ABA4A600B8_il2cpp_TypeInfo_var);
		CryptoRandom_t8B21DF8737471EFF3D15D1ACB0AF83ABA4A600B8* L_1 = ((CryptoRandom_t8B21DF8737471EFF3D15D1ACB0AF83ABA4A600B8_StaticFields*)il2cpp_codegen_static_fields_for(CryptoRandom_t8B21DF8737471EFF3D15D1ACB0AF83ABA4A600B8_il2cpp_TypeInfo_var))->___Instance_12;
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_2 = V_0;
		NullCheck(L_1);
		VirtualActionInvoker1< ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* >::Invoke(9 /* System.Void System.Random::NextBytes(System.Byte[]) */, L_1, L_2);
		// return retval;
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_3 = V_0;
		return L_3;
	}
}
// System.Byte[] Lidgren.Network.NetSRP::CreateRandomEphemeral()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* NetSRP_CreateRandomEphemeral_m42EC4383A4BEFC065B86623B18FBA4E90743F43E (const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&CryptoRandom_t8B21DF8737471EFF3D15D1ACB0AF83ABA4A600B8_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* V_0 = NULL;
	{
		// byte[] retval = new byte[32];
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_0 = (ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031*)(ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031*)SZArrayNew(ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031_il2cpp_TypeInfo_var, (uint32_t)((int32_t)32));
		V_0 = L_0;
		// CryptoRandom.Instance.NextBytes(retval);
		il2cpp_codegen_runtime_class_init_inline(CryptoRandom_t8B21DF8737471EFF3D15D1ACB0AF83ABA4A600B8_il2cpp_TypeInfo_var);
		CryptoRandom_t8B21DF8737471EFF3D15D1ACB0AF83ABA4A600B8* L_1 = ((CryptoRandom_t8B21DF8737471EFF3D15D1ACB0AF83ABA4A600B8_StaticFields*)il2cpp_codegen_static_fields_for(CryptoRandom_t8B21DF8737471EFF3D15D1ACB0AF83ABA4A600B8_il2cpp_TypeInfo_var))->___Instance_12;
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_2 = V_0;
		NullCheck(L_1);
		VirtualActionInvoker1< ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* >::Invoke(9 /* System.Void System.Random::NextBytes(System.Byte[]) */, L_1, L_2);
		// return retval;
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_3 = V_0;
		return L_3;
	}
}
// System.Byte[] Lidgren.Network.NetSRP::ComputePrivateKey(System.String,System.String,System.Byte[])
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* NetSRP_ComputePrivateKey_mC7CEFA7BC889DC51A64184D3BEEB6778D1B06D98 (String_t* ___username0, String_t* ___password1, ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* ___salt2, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&NetBigInteger_t06C831F115CE5B02A3EB70F99F2C5ABA75E0FF76_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&NetUtility_t0B01E9514810CE3FC3B5E83D8427CBA1C5689EFD_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral876C4B39B6E4D0187090400768899C71D99DE90D);
		s_Il2CppMethodInitialized = true;
	}
ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* V_0 = NULL;
	ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* V_1 = NULL;
	{
		// byte[] tmp = Encoding.UTF8.GetBytes(username + ":" + password);
		Encoding_t65CDEF28CF20A7B8C92E85A4E808920C2465F095* L_0;
		L_0 = Encoding_get_UTF8_m9700ADA8E0F244002B2A89B483F1B2133B8FE336(NULL);
		String_t* L_1 = ___username0;
		String_t* L_2 = ___password1;
		String_t* L_3;
		L_3 = String_Concat_m9B13B47FCB3DF61144D9647DDA05F527377251B0(L_1, _stringLiteral876C4B39B6E4D0187090400768899C71D99DE90D, L_2, NULL);
		NullCheck(L_0);
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_4;
		L_4 = VirtualFuncInvoker1< ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031*, String_t* >::Invoke(18 /* System.Byte[] System.Text.Encoding::GetBytes(System.String) */, L_0, L_3);
		// byte[] innerHash = NetUtility.ComputeSHAHash(tmp);
		il2cpp_codegen_runtime_class_init_inline(NetUtility_t0B01E9514810CE3FC3B5E83D8427CBA1C5689EFD_il2cpp_TypeInfo_var);
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_5;
		L_5 = NetUtility_ComputeSHAHash_mF0A369753E62EEE4E771C5638C1CB620D0CA48AD(L_4, NULL);
		V_0 = L_5;
		// byte[] total = new byte[innerHash.Length + salt.Length];
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_6 = V_0;
		NullCheck(L_6);
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_7 = ___salt2;
		NullCheck(L_7);
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_8 = (ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031*)(ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031*)SZArrayNew(ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031_il2cpp_TypeInfo_var, (uint32_t)((int32_t)il2cpp_codegen_add(((int32_t)(((RuntimeArray*)L_6)->max_length)), ((int32_t)(((RuntimeArray*)L_7)->max_length)))));
		V_1 = L_8;
		// Buffer.BlockCopy(salt, 0, total, 0, salt.Length);
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_9 = ___salt2;
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_10 = V_1;
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_11 = ___salt2;
		NullCheck(L_11);
		Buffer_BlockCopy_mD8CF7EC96ADA7A542CCA3F3C73510624E10197A9((RuntimeArray*)L_9, 0, (RuntimeArray*)L_10, 0, ((int32_t)(((RuntimeArray*)L_11)->max_length)), NULL);
		// Buffer.BlockCopy(innerHash, 0, total, salt.Length, innerHash.Length);
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_12 = V_0;
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_13 = V_1;
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_14 = ___salt2;
		NullCheck(L_14);
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_15 = V_0;
		NullCheck(L_15);
		Buffer_BlockCopy_mD8CF7EC96ADA7A542CCA3F3C73510624E10197A9((RuntimeArray*)L_12, 0, (RuntimeArray*)L_13, ((int32_t)(((RuntimeArray*)L_14)->max_length)), ((int32_t)(((RuntimeArray*)L_15)->max_length)), NULL);
		// return new NetBigInteger(NetUtility.ToHexString(NetUtility.ComputeSHAHash(total)), 16).ToByteArrayUnsigned();
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_16 = V_1;
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_17;
		L_17 = NetUtility_ComputeSHAHash_mF0A369753E62EEE4E771C5638C1CB620D0CA48AD(L_16, NULL);
		String_t* L_18;
		L_18 = NetUtility_ToHexString_m54E357477D8D0AD283B929917378B10D8E1F380B(L_17, NULL);
		NetBigInteger_t06C831F115CE5B02A3EB70F99F2C5ABA75E0FF76* L_19 = (NetBigInteger_t06C831F115CE5B02A3EB70F99F2C5ABA75E0FF76*)il2cpp_codegen_object_new(NetBigInteger_t06C831F115CE5B02A3EB70F99F2C5ABA75E0FF76_il2cpp_TypeInfo_var);
		NetBigInteger__ctor_m4031CDB3BDCE25C1A09226CE4C36004FAC46ED25(L_19, L_18, ((int32_t)16), /*hidden argument*/NULL);
		NullCheck(L_19);
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_20;
		L_20 = NetBigInteger_ToByteArrayUnsigned_m3A7A392C37CD2D701E96AFEF4193B21E451808FD(L_19, NULL);
		return L_20;
	}
}
// System.Byte[] Lidgren.Network.NetSRP::ComputeServerVerifier(System.Byte[])
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* NetSRP_ComputeServerVerifier_m310C8F61A94807578F633C988E99FA6C6C2ACA00 (ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* ___privateKey0, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&NetBigInteger_t06C831F115CE5B02A3EB70F99F2C5ABA75E0FF76_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&NetSRP_tCB8425B4A061CEF6A1C0914A06C41D2745DBD951_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&NetUtility_t0B01E9514810CE3FC3B5E83D8427CBA1C5689EFD_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
NetBigInteger_t06C831F115CE5B02A3EB70F99F2C5ABA75E0FF76* V_0 = NULL;
	{
		// NetBigInteger x = new NetBigInteger(NetUtility.ToHexString(privateKey), 16);
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_0 = ___privateKey0;
		il2cpp_codegen_runtime_class_init_inline(NetUtility_t0B01E9514810CE3FC3B5E83D8427CBA1C5689EFD_il2cpp_TypeInfo_var);
		String_t* L_1;
		L_1 = NetUtility_ToHexString_m54E357477D8D0AD283B929917378B10D8E1F380B(L_0, NULL);
		NetBigInteger_t06C831F115CE5B02A3EB70F99F2C5ABA75E0FF76* L_2 = (NetBigInteger_t06C831F115CE5B02A3EB70F99F2C5ABA75E0FF76*)il2cpp_codegen_object_new(NetBigInteger_t06C831F115CE5B02A3EB70F99F2C5ABA75E0FF76_il2cpp_TypeInfo_var);
		NetBigInteger__ctor_m4031CDB3BDCE25C1A09226CE4C36004FAC46ED25(L_2, L_1, ((int32_t)16), /*hidden argument*/NULL);
		V_0 = L_2;
		// var serverVerifier = g.ModPow(x, N);
		il2cpp_codegen_runtime_class_init_inline(NetSRP_tCB8425B4A061CEF6A1C0914A06C41D2745DBD951_il2cpp_TypeInfo_var);
		NetBigInteger_t06C831F115CE5B02A3EB70F99F2C5ABA75E0FF76* L_3 = ((NetSRP_tCB8425B4A061CEF6A1C0914A06C41D2745DBD951_StaticFields*)il2cpp_codegen_static_fields_for(NetSRP_tCB8425B4A061CEF6A1C0914A06C41D2745DBD951_il2cpp_TypeInfo_var))->___g_1;
		NetBigInteger_t06C831F115CE5B02A3EB70F99F2C5ABA75E0FF76* L_4 = V_0;
		NetBigInteger_t06C831F115CE5B02A3EB70F99F2C5ABA75E0FF76* L_5 = ((NetSRP_tCB8425B4A061CEF6A1C0914A06C41D2745DBD951_StaticFields*)il2cpp_codegen_static_fields_for(NetSRP_tCB8425B4A061CEF6A1C0914A06C41D2745DBD951_il2cpp_TypeInfo_var))->___N_0;
		NullCheck(L_3);
		NetBigInteger_t06C831F115CE5B02A3EB70F99F2C5ABA75E0FF76* L_6;
		L_6 = NetBigInteger_ModPow_mA8056171CB7863175623991760489B0DCA3EA6B1(L_3, L_4, L_5, NULL);
		// return serverVerifier.ToByteArrayUnsigned();
		NullCheck(L_6);
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_7;
		L_7 = NetBigInteger_ToByteArrayUnsigned_m3A7A392C37CD2D701E96AFEF4193B21E451808FD(L_6, NULL);
		return L_7;
	}
}
// System.Byte[] Lidgren.Network.NetSRP::ComputeClientEphemeral(System.Byte[])
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* NetSRP_ComputeClientEphemeral_m6C609B514FB969EE11A32B841BEBD8B61A6011E1 (ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* ___clientPrivateEphemeral0, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&NetBigInteger_t06C831F115CE5B02A3EB70F99F2C5ABA75E0FF76_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&NetSRP_tCB8425B4A061CEF6A1C0914A06C41D2745DBD951_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&NetUtility_t0B01E9514810CE3FC3B5E83D8427CBA1C5689EFD_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
NetBigInteger_t06C831F115CE5B02A3EB70F99F2C5ABA75E0FF76* V_0 = NULL;
	{
		// NetBigInteger a = new NetBigInteger(NetUtility.ToHexString(clientPrivateEphemeral), 16);
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_0 = ___clientPrivateEphemeral0;
		il2cpp_codegen_runtime_class_init_inline(NetUtility_t0B01E9514810CE3FC3B5E83D8427CBA1C5689EFD_il2cpp_TypeInfo_var);
		String_t* L_1;
		L_1 = NetUtility_ToHexString_m54E357477D8D0AD283B929917378B10D8E1F380B(L_0, NULL);
		NetBigInteger_t06C831F115CE5B02A3EB70F99F2C5ABA75E0FF76* L_2 = (NetBigInteger_t06C831F115CE5B02A3EB70F99F2C5ABA75E0FF76*)il2cpp_codegen_object_new(NetBigInteger_t06C831F115CE5B02A3EB70F99F2C5ABA75E0FF76_il2cpp_TypeInfo_var);
		NetBigInteger__ctor_m4031CDB3BDCE25C1A09226CE4C36004FAC46ED25(L_2, L_1, ((int32_t)16), /*hidden argument*/NULL);
		V_0 = L_2;
		// NetBigInteger retval = g.ModPow(a, N);
		il2cpp_codegen_runtime_class_init_inline(NetSRP_tCB8425B4A061CEF6A1C0914A06C41D2745DBD951_il2cpp_TypeInfo_var);
		NetBigInteger_t06C831F115CE5B02A3EB70F99F2C5ABA75E0FF76* L_3 = ((NetSRP_tCB8425B4A061CEF6A1C0914A06C41D2745DBD951_StaticFields*)il2cpp_codegen_static_fields_for(NetSRP_tCB8425B4A061CEF6A1C0914A06C41D2745DBD951_il2cpp_TypeInfo_var))->___g_1;
		NetBigInteger_t06C831F115CE5B02A3EB70F99F2C5ABA75E0FF76* L_4 = V_0;
		NetBigInteger_t06C831F115CE5B02A3EB70F99F2C5ABA75E0FF76* L_5 = ((NetSRP_tCB8425B4A061CEF6A1C0914A06C41D2745DBD951_StaticFields*)il2cpp_codegen_static_fields_for(NetSRP_tCB8425B4A061CEF6A1C0914A06C41D2745DBD951_il2cpp_TypeInfo_var))->___N_0;
		NullCheck(L_3);
		NetBigInteger_t06C831F115CE5B02A3EB70F99F2C5ABA75E0FF76* L_6;
		L_6 = NetBigInteger_ModPow_mA8056171CB7863175623991760489B0DCA3EA6B1(L_3, L_4, L_5, NULL);
		// return retval.ToByteArrayUnsigned();
		NullCheck(L_6);
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_7;
		L_7 = NetBigInteger_ToByteArrayUnsigned_m3A7A392C37CD2D701E96AFEF4193B21E451808FD(L_6, NULL);
		return L_7;
	}
}
// System.Byte[] Lidgren.Network.NetSRP::ComputeServerEphemeral(System.Byte[],System.Byte[])
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* NetSRP_ComputeServerEphemeral_m18EE1338BF40CEBFACF9A64142B2C49BF10FCB4A (ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* ___serverPrivateEphemeral0, ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* ___verifier1, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&NetBigInteger_t06C831F115CE5B02A3EB70F99F2C5ABA75E0FF76_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&NetSRP_tCB8425B4A061CEF6A1C0914A06C41D2745DBD951_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&NetUtility_t0B01E9514810CE3FC3B5E83D8427CBA1C5689EFD_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
NetBigInteger_t06C831F115CE5B02A3EB70F99F2C5ABA75E0FF76* V_0 = NULL;
	NetBigInteger_t06C831F115CE5B02A3EB70F99F2C5ABA75E0FF76* V_1 = NULL;
	{
		// var b = new NetBigInteger(NetUtility.ToHexString(serverPrivateEphemeral), 16);
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_0 = ___serverPrivateEphemeral0;
		il2cpp_codegen_runtime_class_init_inline(NetUtility_t0B01E9514810CE3FC3B5E83D8427CBA1C5689EFD_il2cpp_TypeInfo_var);
		String_t* L_1;
		L_1 = NetUtility_ToHexString_m54E357477D8D0AD283B929917378B10D8E1F380B(L_0, NULL);
		NetBigInteger_t06C831F115CE5B02A3EB70F99F2C5ABA75E0FF76* L_2 = (NetBigInteger_t06C831F115CE5B02A3EB70F99F2C5ABA75E0FF76*)il2cpp_codegen_object_new(NetBigInteger_t06C831F115CE5B02A3EB70F99F2C5ABA75E0FF76_il2cpp_TypeInfo_var);
		NetBigInteger__ctor_m4031CDB3BDCE25C1A09226CE4C36004FAC46ED25(L_2, L_1, ((int32_t)16), /*hidden argument*/NULL);
		V_0 = L_2;
		// var v = new NetBigInteger(NetUtility.ToHexString(verifier), 16);
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_3 = ___verifier1;
		String_t* L_4;
		L_4 = NetUtility_ToHexString_m54E357477D8D0AD283B929917378B10D8E1F380B(L_3, NULL);
		NetBigInteger_t06C831F115CE5B02A3EB70F99F2C5ABA75E0FF76* L_5 = (NetBigInteger_t06C831F115CE5B02A3EB70F99F2C5ABA75E0FF76*)il2cpp_codegen_object_new(NetBigInteger_t06C831F115CE5B02A3EB70F99F2C5ABA75E0FF76_il2cpp_TypeInfo_var);
		NetBigInteger__ctor_m4031CDB3BDCE25C1A09226CE4C36004FAC46ED25(L_5, L_4, ((int32_t)16), /*hidden argument*/NULL);
		// var bb = g.ModPow(b, N);
		il2cpp_codegen_runtime_class_init_inline(NetSRP_tCB8425B4A061CEF6A1C0914A06C41D2745DBD951_il2cpp_TypeInfo_var);
		NetBigInteger_t06C831F115CE5B02A3EB70F99F2C5ABA75E0FF76* L_6 = ((NetSRP_tCB8425B4A061CEF6A1C0914A06C41D2745DBD951_StaticFields*)il2cpp_codegen_static_fields_for(NetSRP_tCB8425B4A061CEF6A1C0914A06C41D2745DBD951_il2cpp_TypeInfo_var))->___g_1;
		NetBigInteger_t06C831F115CE5B02A3EB70F99F2C5ABA75E0FF76* L_7 = V_0;
		NetBigInteger_t06C831F115CE5B02A3EB70F99F2C5ABA75E0FF76* L_8 = ((NetSRP_tCB8425B4A061CEF6A1C0914A06C41D2745DBD951_StaticFields*)il2cpp_codegen_static_fields_for(NetSRP_tCB8425B4A061CEF6A1C0914A06C41D2745DBD951_il2cpp_TypeInfo_var))->___N_0;
		NullCheck(L_6);
		NetBigInteger_t06C831F115CE5B02A3EB70F99F2C5ABA75E0FF76* L_9;
		L_9 = NetBigInteger_ModPow_mA8056171CB7863175623991760489B0DCA3EA6B1(L_6, L_7, L_8, NULL);
		V_1 = L_9;
		// var kv = v.Multiply(k);
		NetBigInteger_t06C831F115CE5B02A3EB70F99F2C5ABA75E0FF76* L_10 = ((NetSRP_tCB8425B4A061CEF6A1C0914A06C41D2745DBD951_StaticFields*)il2cpp_codegen_static_fields_for(NetSRP_tCB8425B4A061CEF6A1C0914A06C41D2745DBD951_il2cpp_TypeInfo_var))->___k_2;
		NullCheck(L_5);
		NetBigInteger_t06C831F115CE5B02A3EB70F99F2C5ABA75E0FF76* L_11;
		L_11 = NetBigInteger_Multiply_m2BA38A3FB4A6A96C6A12EFAAA84593FB6F42B268(L_5, L_10, NULL);
		// var B = (kv.Add(bb)).Mod(N);
		NetBigInteger_t06C831F115CE5B02A3EB70F99F2C5ABA75E0FF76* L_12 = V_1;
		NullCheck(L_11);
		NetBigInteger_t06C831F115CE5B02A3EB70F99F2C5ABA75E0FF76* L_13;
		L_13 = NetBigInteger_Add_mD8A74E340DA99C2FC5BB092B79A0001366C9F0FD(L_11, L_12, NULL);
		NetBigInteger_t06C831F115CE5B02A3EB70F99F2C5ABA75E0FF76* L_14 = ((NetSRP_tCB8425B4A061CEF6A1C0914A06C41D2745DBD951_StaticFields*)il2cpp_codegen_static_fields_for(NetSRP_tCB8425B4A061CEF6A1C0914A06C41D2745DBD951_il2cpp_TypeInfo_var))->___N_0;
		NullCheck(L_13);
		NetBigInteger_t06C831F115CE5B02A3EB70F99F2C5ABA75E0FF76* L_15;
		L_15 = NetBigInteger_Mod_mA45EB5A08C840CB9206BAB63A3A470EB39629FAD(L_13, L_14, NULL);
		// return B.ToByteArrayUnsigned();
		NullCheck(L_15);
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_16;
		L_16 = NetBigInteger_ToByteArrayUnsigned_m3A7A392C37CD2D701E96AFEF4193B21E451808FD(L_15, NULL);
		return L_16;
	}
}
// System.Byte[] Lidgren.Network.NetSRP::ComputeU(System.Byte[],System.Byte[])
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* NetSRP_ComputeU_m1B93AA18C0852B0478C066703D57100F253A3515 (ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* ___clientPublicEphemeral0, ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* ___serverPublicEphemeral1, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&NetBigInteger_t06C831F115CE5B02A3EB70F99F2C5ABA75E0FF76_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&NetUtility_t0B01E9514810CE3FC3B5E83D8427CBA1C5689EFD_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
String_t* V_0 = NULL;
	int32_t V_1 = 0;
	{
		// string one = NetUtility.ToHexString(clientPublicEphemeral);
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_0 = ___clientPublicEphemeral0;
		il2cpp_codegen_runtime_class_init_inline(NetUtility_t0B01E9514810CE3FC3B5E83D8427CBA1C5689EFD_il2cpp_TypeInfo_var);
		String_t* L_1;
		L_1 = NetUtility_ToHexString_m54E357477D8D0AD283B929917378B10D8E1F380B(L_0, NULL);
		// string two = NetUtility.ToHexString(serverPublicEphemeral);
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_2 = ___serverPublicEphemeral1;
		String_t* L_3;
		L_3 = NetUtility_ToHexString_m54E357477D8D0AD283B929917378B10D8E1F380B(L_2, NULL);
		V_0 = L_3;
		// int len = 66; //  Math.Max(one.Length, two.Length);
		V_1 = ((int32_t)66);
		// string ccstr = one.PadLeft(len, '0') + two.PadLeft(len, '0');
		int32_t L_4 = V_1;
		NullCheck(L_1);
		String_t* L_5;
		L_5 = String_PadLeft_m99DDD242908E78B71E9631EE66331E8A130EB31F(L_1, L_4, ((int32_t)48), NULL);
		String_t* L_6 = V_0;
		int32_t L_7 = V_1;
		NullCheck(L_6);
		String_t* L_8;
		L_8 = String_PadLeft_m99DDD242908E78B71E9631EE66331E8A130EB31F(L_6, L_7, ((int32_t)48), NULL);
		String_t* L_9;
		L_9 = String_Concat_mAF2CE02CC0CB7460753D0A1A91CCF2B1E9804C5D(L_5, L_8, NULL);
		// byte[] cc = NetUtility.ToByteArray(ccstr);
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_10;
		L_10 = NetUtility_ToByteArray_mF9C5C8DB9AB7C82FCE421683EE0FFAFF51510EA8(L_9, NULL);
		// var ccHashed = NetUtility.ComputeSHAHash(cc);
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_11;
		L_11 = NetUtility_ComputeSHAHash_mF0A369753E62EEE4E771C5638C1CB620D0CA48AD(L_10, NULL);
		// return new NetBigInteger(NetUtility.ToHexString(ccHashed), 16).ToByteArrayUnsigned();
		String_t* L_12;
		L_12 = NetUtility_ToHexString_m54E357477D8D0AD283B929917378B10D8E1F380B(L_11, NULL);
		NetBigInteger_t06C831F115CE5B02A3EB70F99F2C5ABA75E0FF76* L_13 = (NetBigInteger_t06C831F115CE5B02A3EB70F99F2C5ABA75E0FF76*)il2cpp_codegen_object_new(NetBigInteger_t06C831F115CE5B02A3EB70F99F2C5ABA75E0FF76_il2cpp_TypeInfo_var);
		NetBigInteger__ctor_m4031CDB3BDCE25C1A09226CE4C36004FAC46ED25(L_13, L_12, ((int32_t)16), /*hidden argument*/NULL);
		NullCheck(L_13);
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_14;
		L_14 = NetBigInteger_ToByteArrayUnsigned_m3A7A392C37CD2D701E96AFEF4193B21E451808FD(L_13, NULL);
		return L_14;
	}
}
// System.Byte[] Lidgren.Network.NetSRP::ComputeServerSessionValue(System.Byte[],System.Byte[],System.Byte[],System.Byte[])
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* NetSRP_ComputeServerSessionValue_m865CAEC7CE2268800C61B9ED7D317DC00D69E31C (ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* ___clientPublicEphemeral0, ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* ___verifier1, ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* ___udata2, ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* ___serverPrivateEphemeral3, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&NetBigInteger_t06C831F115CE5B02A3EB70F99F2C5ABA75E0FF76_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&NetSRP_tCB8425B4A061CEF6A1C0914A06C41D2745DBD951_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&NetUtility_t0B01E9514810CE3FC3B5E83D8427CBA1C5689EFD_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
NetBigInteger_t06C831F115CE5B02A3EB70F99F2C5ABA75E0FF76* V_0 = NULL;
	NetBigInteger_t06C831F115CE5B02A3EB70F99F2C5ABA75E0FF76* V_1 = NULL;
	NetBigInteger_t06C831F115CE5B02A3EB70F99F2C5ABA75E0FF76* V_2 = NULL;
	{
		// var A = new NetBigInteger(NetUtility.ToHexString(clientPublicEphemeral), 16);
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_0 = ___clientPublicEphemeral0;
		il2cpp_codegen_runtime_class_init_inline(NetUtility_t0B01E9514810CE3FC3B5E83D8427CBA1C5689EFD_il2cpp_TypeInfo_var);
		String_t* L_1;
		L_1 = NetUtility_ToHexString_m54E357477D8D0AD283B929917378B10D8E1F380B(L_0, NULL);
		NetBigInteger_t06C831F115CE5B02A3EB70F99F2C5ABA75E0FF76* L_2 = (NetBigInteger_t06C831F115CE5B02A3EB70F99F2C5ABA75E0FF76*)il2cpp_codegen_object_new(NetBigInteger_t06C831F115CE5B02A3EB70F99F2C5ABA75E0FF76_il2cpp_TypeInfo_var);
		NetBigInteger__ctor_m4031CDB3BDCE25C1A09226CE4C36004FAC46ED25(L_2, L_1, ((int32_t)16), /*hidden argument*/NULL);
		V_0 = L_2;
		// var v = new NetBigInteger(NetUtility.ToHexString(verifier), 16);
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_3 = ___verifier1;
		String_t* L_4;
		L_4 = NetUtility_ToHexString_m54E357477D8D0AD283B929917378B10D8E1F380B(L_3, NULL);
		NetBigInteger_t06C831F115CE5B02A3EB70F99F2C5ABA75E0FF76* L_5 = (NetBigInteger_t06C831F115CE5B02A3EB70F99F2C5ABA75E0FF76*)il2cpp_codegen_object_new(NetBigInteger_t06C831F115CE5B02A3EB70F99F2C5ABA75E0FF76_il2cpp_TypeInfo_var);
		NetBigInteger__ctor_m4031CDB3BDCE25C1A09226CE4C36004FAC46ED25(L_5, L_4, ((int32_t)16), /*hidden argument*/NULL);
		// var u = new NetBigInteger(NetUtility.ToHexString(udata), 16);
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_6 = ___udata2;
		String_t* L_7;
		L_7 = NetUtility_ToHexString_m54E357477D8D0AD283B929917378B10D8E1F380B(L_6, NULL);
		NetBigInteger_t06C831F115CE5B02A3EB70F99F2C5ABA75E0FF76* L_8 = (NetBigInteger_t06C831F115CE5B02A3EB70F99F2C5ABA75E0FF76*)il2cpp_codegen_object_new(NetBigInteger_t06C831F115CE5B02A3EB70F99F2C5ABA75E0FF76_il2cpp_TypeInfo_var);
		NetBigInteger__ctor_m4031CDB3BDCE25C1A09226CE4C36004FAC46ED25(L_8, L_7, ((int32_t)16), /*hidden argument*/NULL);
		V_1 = L_8;
		// var b = new NetBigInteger(NetUtility.ToHexString(serverPrivateEphemeral), 16);
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_9 = ___serverPrivateEphemeral3;
		String_t* L_10;
		L_10 = NetUtility_ToHexString_m54E357477D8D0AD283B929917378B10D8E1F380B(L_9, NULL);
		NetBigInteger_t06C831F115CE5B02A3EB70F99F2C5ABA75E0FF76* L_11 = (NetBigInteger_t06C831F115CE5B02A3EB70F99F2C5ABA75E0FF76*)il2cpp_codegen_object_new(NetBigInteger_t06C831F115CE5B02A3EB70F99F2C5ABA75E0FF76_il2cpp_TypeInfo_var);
		NetBigInteger__ctor_m4031CDB3BDCE25C1A09226CE4C36004FAC46ED25(L_11, L_10, ((int32_t)16), /*hidden argument*/NULL);
		V_2 = L_11;
		// NetBigInteger retval = v.ModPow(u, N).Multiply(A).Mod(N).ModPow(b, N).Mod(N);
		NetBigInteger_t06C831F115CE5B02A3EB70F99F2C5ABA75E0FF76* L_12 = V_1;
		il2cpp_codegen_runtime_class_init_inline(NetSRP_tCB8425B4A061CEF6A1C0914A06C41D2745DBD951_il2cpp_TypeInfo_var);
		NetBigInteger_t06C831F115CE5B02A3EB70F99F2C5ABA75E0FF76* L_13 = ((NetSRP_tCB8425B4A061CEF6A1C0914A06C41D2745DBD951_StaticFields*)il2cpp_codegen_static_fields_for(NetSRP_tCB8425B4A061CEF6A1C0914A06C41D2745DBD951_il2cpp_TypeInfo_var))->___N_0;
		NullCheck(L_5);
		NetBigInteger_t06C831F115CE5B02A3EB70F99F2C5ABA75E0FF76* L_14;
		L_14 = NetBigInteger_ModPow_mA8056171CB7863175623991760489B0DCA3EA6B1(L_5, L_12, L_13, NULL);
		NetBigInteger_t06C831F115CE5B02A3EB70F99F2C5ABA75E0FF76* L_15 = V_0;
		NullCheck(L_14);
		NetBigInteger_t06C831F115CE5B02A3EB70F99F2C5ABA75E0FF76* L_16;
		L_16 = NetBigInteger_Multiply_m2BA38A3FB4A6A96C6A12EFAAA84593FB6F42B268(L_14, L_15, NULL);
		NetBigInteger_t06C831F115CE5B02A3EB70F99F2C5ABA75E0FF76* L_17 = ((NetSRP_tCB8425B4A061CEF6A1C0914A06C41D2745DBD951_StaticFields*)il2cpp_codegen_static_fields_for(NetSRP_tCB8425B4A061CEF6A1C0914A06C41D2745DBD951_il2cpp_TypeInfo_var))->___N_0;
		NullCheck(L_16);
		NetBigInteger_t06C831F115CE5B02A3EB70F99F2C5ABA75E0FF76* L_18;
		L_18 = NetBigInteger_Mod_mA45EB5A08C840CB9206BAB63A3A470EB39629FAD(L_16, L_17, NULL);
		NetBigInteger_t06C831F115CE5B02A3EB70F99F2C5ABA75E0FF76* L_19 = V_2;
		NetBigInteger_t06C831F115CE5B02A3EB70F99F2C5ABA75E0FF76* L_20 = ((NetSRP_tCB8425B4A061CEF6A1C0914A06C41D2745DBD951_StaticFields*)il2cpp_codegen_static_fields_for(NetSRP_tCB8425B4A061CEF6A1C0914A06C41D2745DBD951_il2cpp_TypeInfo_var))->___N_0;
		NullCheck(L_18);
		NetBigInteger_t06C831F115CE5B02A3EB70F99F2C5ABA75E0FF76* L_21;
		L_21 = NetBigInteger_ModPow_mA8056171CB7863175623991760489B0DCA3EA6B1(L_18, L_19, L_20, NULL);
		NetBigInteger_t06C831F115CE5B02A3EB70F99F2C5ABA75E0FF76* L_22 = ((NetSRP_tCB8425B4A061CEF6A1C0914A06C41D2745DBD951_StaticFields*)il2cpp_codegen_static_fields_for(NetSRP_tCB8425B4A061CEF6A1C0914A06C41D2745DBD951_il2cpp_TypeInfo_var))->___N_0;
		NullCheck(L_21);
		NetBigInteger_t06C831F115CE5B02A3EB70F99F2C5ABA75E0FF76* L_23;
		L_23 = NetBigInteger_Mod_mA45EB5A08C840CB9206BAB63A3A470EB39629FAD(L_21, L_22, NULL);
		// return retval.ToByteArrayUnsigned();
		NullCheck(L_23);
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_24;
		L_24 = NetBigInteger_ToByteArrayUnsigned_m3A7A392C37CD2D701E96AFEF4193B21E451808FD(L_23, NULL);
		return L_24;
	}
}
// System.Byte[] Lidgren.Network.NetSRP::ComputeClientSessionValue(System.Byte[],System.Byte[],System.Byte[],System.Byte[])
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* NetSRP_ComputeClientSessionValue_mEE1751D25A538A34C3F8D0BD095C1952022EBE30 (ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* ___serverPublicEphemeral0, ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* ___xdata1, ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* ___udata2, ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* ___clientPrivateEphemeral3, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&NetBigInteger_t06C831F115CE5B02A3EB70F99F2C5ABA75E0FF76_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&NetSRP_tCB8425B4A061CEF6A1C0914A06C41D2745DBD951_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&NetUtility_t0B01E9514810CE3FC3B5E83D8427CBA1C5689EFD_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
NetBigInteger_t06C831F115CE5B02A3EB70F99F2C5ABA75E0FF76* V_0 = NULL;
	NetBigInteger_t06C831F115CE5B02A3EB70F99F2C5ABA75E0FF76* V_1 = NULL;
	NetBigInteger_t06C831F115CE5B02A3EB70F99F2C5ABA75E0FF76* V_2 = NULL;
	NetBigInteger_t06C831F115CE5B02A3EB70F99F2C5ABA75E0FF76* V_3 = NULL;
	{
		// var B = new NetBigInteger(NetUtility.ToHexString(serverPublicEphemeral), 16);
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_0 = ___serverPublicEphemeral0;
		il2cpp_codegen_runtime_class_init_inline(NetUtility_t0B01E9514810CE3FC3B5E83D8427CBA1C5689EFD_il2cpp_TypeInfo_var);
		String_t* L_1;
		L_1 = NetUtility_ToHexString_m54E357477D8D0AD283B929917378B10D8E1F380B(L_0, NULL);
		NetBigInteger_t06C831F115CE5B02A3EB70F99F2C5ABA75E0FF76* L_2 = (NetBigInteger_t06C831F115CE5B02A3EB70F99F2C5ABA75E0FF76*)il2cpp_codegen_object_new(NetBigInteger_t06C831F115CE5B02A3EB70F99F2C5ABA75E0FF76_il2cpp_TypeInfo_var);
		NetBigInteger__ctor_m4031CDB3BDCE25C1A09226CE4C36004FAC46ED25(L_2, L_1, ((int32_t)16), /*hidden argument*/NULL);
		// var x = new NetBigInteger(NetUtility.ToHexString(xdata), 16);
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_3 = ___xdata1;
		String_t* L_4;
		L_4 = NetUtility_ToHexString_m54E357477D8D0AD283B929917378B10D8E1F380B(L_3, NULL);
		NetBigInteger_t06C831F115CE5B02A3EB70F99F2C5ABA75E0FF76* L_5 = (NetBigInteger_t06C831F115CE5B02A3EB70F99F2C5ABA75E0FF76*)il2cpp_codegen_object_new(NetBigInteger_t06C831F115CE5B02A3EB70F99F2C5ABA75E0FF76_il2cpp_TypeInfo_var);
		NetBigInteger__ctor_m4031CDB3BDCE25C1A09226CE4C36004FAC46ED25(L_5, L_4, ((int32_t)16), /*hidden argument*/NULL);
		V_0 = L_5;
		// var u = new NetBigInteger(NetUtility.ToHexString(udata), 16);
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_6 = ___udata2;
		String_t* L_7;
		L_7 = NetUtility_ToHexString_m54E357477D8D0AD283B929917378B10D8E1F380B(L_6, NULL);
		NetBigInteger_t06C831F115CE5B02A3EB70F99F2C5ABA75E0FF76* L_8 = (NetBigInteger_t06C831F115CE5B02A3EB70F99F2C5ABA75E0FF76*)il2cpp_codegen_object_new(NetBigInteger_t06C831F115CE5B02A3EB70F99F2C5ABA75E0FF76_il2cpp_TypeInfo_var);
		NetBigInteger__ctor_m4031CDB3BDCE25C1A09226CE4C36004FAC46ED25(L_8, L_7, ((int32_t)16), /*hidden argument*/NULL);
		V_1 = L_8;
		// var a = new NetBigInteger(NetUtility.ToHexString(clientPrivateEphemeral), 16);
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_9 = ___clientPrivateEphemeral3;
		String_t* L_10;
		L_10 = NetUtility_ToHexString_m54E357477D8D0AD283B929917378B10D8E1F380B(L_9, NULL);
		NetBigInteger_t06C831F115CE5B02A3EB70F99F2C5ABA75E0FF76* L_11 = (NetBigInteger_t06C831F115CE5B02A3EB70F99F2C5ABA75E0FF76*)il2cpp_codegen_object_new(NetBigInteger_t06C831F115CE5B02A3EB70F99F2C5ABA75E0FF76_il2cpp_TypeInfo_var);
		NetBigInteger__ctor_m4031CDB3BDCE25C1A09226CE4C36004FAC46ED25(L_11, L_10, ((int32_t)16), /*hidden argument*/NULL);
		V_2 = L_11;
		// var bx = g.ModPow(x, N);
		il2cpp_codegen_runtime_class_init_inline(NetSRP_tCB8425B4A061CEF6A1C0914A06C41D2745DBD951_il2cpp_TypeInfo_var);
		NetBigInteger_t06C831F115CE5B02A3EB70F99F2C5ABA75E0FF76* L_12 = ((NetSRP_tCB8425B4A061CEF6A1C0914A06C41D2745DBD951_StaticFields*)il2cpp_codegen_static_fields_for(NetSRP_tCB8425B4A061CEF6A1C0914A06C41D2745DBD951_il2cpp_TypeInfo_var))->___g_1;
		NetBigInteger_t06C831F115CE5B02A3EB70F99F2C5ABA75E0FF76* L_13 = V_0;
		NetBigInteger_t06C831F115CE5B02A3EB70F99F2C5ABA75E0FF76* L_14 = ((NetSRP_tCB8425B4A061CEF6A1C0914A06C41D2745DBD951_StaticFields*)il2cpp_codegen_static_fields_for(NetSRP_tCB8425B4A061CEF6A1C0914A06C41D2745DBD951_il2cpp_TypeInfo_var))->___N_0;
		NullCheck(L_12);
		NetBigInteger_t06C831F115CE5B02A3EB70F99F2C5ABA75E0FF76* L_15;
		L_15 = NetBigInteger_ModPow_mA8056171CB7863175623991760489B0DCA3EA6B1(L_12, L_13, L_14, NULL);
		V_3 = L_15;
		// var btmp = B.Add(N.Multiply(k)).Subtract(bx.Multiply(k)).Mod(N);
		NetBigInteger_t06C831F115CE5B02A3EB70F99F2C5ABA75E0FF76* L_16 = ((NetSRP_tCB8425B4A061CEF6A1C0914A06C41D2745DBD951_StaticFields*)il2cpp_codegen_static_fields_for(NetSRP_tCB8425B4A061CEF6A1C0914A06C41D2745DBD951_il2cpp_TypeInfo_var))->___N_0;
		NetBigInteger_t06C831F115CE5B02A3EB70F99F2C5ABA75E0FF76* L_17 = ((NetSRP_tCB8425B4A061CEF6A1C0914A06C41D2745DBD951_StaticFields*)il2cpp_codegen_static_fields_for(NetSRP_tCB8425B4A061CEF6A1C0914A06C41D2745DBD951_il2cpp_TypeInfo_var))->___k_2;
		NullCheck(L_16);
		NetBigInteger_t06C831F115CE5B02A3EB70F99F2C5ABA75E0FF76* L_18;
		L_18 = NetBigInteger_Multiply_m2BA38A3FB4A6A96C6A12EFAAA84593FB6F42B268(L_16, L_17, NULL);
		NullCheck(L_2);
		NetBigInteger_t06C831F115CE5B02A3EB70F99F2C5ABA75E0FF76* L_19;
		L_19 = NetBigInteger_Add_mD8A74E340DA99C2FC5BB092B79A0001366C9F0FD(L_2, L_18, NULL);
		NetBigInteger_t06C831F115CE5B02A3EB70F99F2C5ABA75E0FF76* L_20 = V_3;
		NetBigInteger_t06C831F115CE5B02A3EB70F99F2C5ABA75E0FF76* L_21 = ((NetSRP_tCB8425B4A061CEF6A1C0914A06C41D2745DBD951_StaticFields*)il2cpp_codegen_static_fields_for(NetSRP_tCB8425B4A061CEF6A1C0914A06C41D2745DBD951_il2cpp_TypeInfo_var))->___k_2;
		NullCheck(L_20);
		NetBigInteger_t06C831F115CE5B02A3EB70F99F2C5ABA75E0FF76* L_22;
		L_22 = NetBigInteger_Multiply_m2BA38A3FB4A6A96C6A12EFAAA84593FB6F42B268(L_20, L_21, NULL);
		NullCheck(L_19);
		NetBigInteger_t06C831F115CE5B02A3EB70F99F2C5ABA75E0FF76* L_23;
		L_23 = NetBigInteger_Subtract_mA2A505CE315C790B52023E216E5D358628F88F8E(L_19, L_22, NULL);
		NetBigInteger_t06C831F115CE5B02A3EB70F99F2C5ABA75E0FF76* L_24 = ((NetSRP_tCB8425B4A061CEF6A1C0914A06C41D2745DBD951_StaticFields*)il2cpp_codegen_static_fields_for(NetSRP_tCB8425B4A061CEF6A1C0914A06C41D2745DBD951_il2cpp_TypeInfo_var))->___N_0;
		NullCheck(L_23);
		NetBigInteger_t06C831F115CE5B02A3EB70F99F2C5ABA75E0FF76* L_25;
		L_25 = NetBigInteger_Mod_mA45EB5A08C840CB9206BAB63A3A470EB39629FAD(L_23, L_24, NULL);
		// return btmp.ModPow(x.Multiply(u).Add(a), N).ToByteArrayUnsigned();
		NetBigInteger_t06C831F115CE5B02A3EB70F99F2C5ABA75E0FF76* L_26 = V_0;
		NetBigInteger_t06C831F115CE5B02A3EB70F99F2C5ABA75E0FF76* L_27 = V_1;
		NullCheck(L_26);
		NetBigInteger_t06C831F115CE5B02A3EB70F99F2C5ABA75E0FF76* L_28;
		L_28 = NetBigInteger_Multiply_m2BA38A3FB4A6A96C6A12EFAAA84593FB6F42B268(L_26, L_27, NULL);
		NetBigInteger_t06C831F115CE5B02A3EB70F99F2C5ABA75E0FF76* L_29 = V_2;
		NullCheck(L_28);
		NetBigInteger_t06C831F115CE5B02A3EB70F99F2C5ABA75E0FF76* L_30;
		L_30 = NetBigInteger_Add_mD8A74E340DA99C2FC5BB092B79A0001366C9F0FD(L_28, L_29, NULL);
		NetBigInteger_t06C831F115CE5B02A3EB70F99F2C5ABA75E0FF76* L_31 = ((NetSRP_tCB8425B4A061CEF6A1C0914A06C41D2745DBD951_StaticFields*)il2cpp_codegen_static_fields_for(NetSRP_tCB8425B4A061CEF6A1C0914A06C41D2745DBD951_il2cpp_TypeInfo_var))->___N_0;
		NullCheck(L_25);
		NetBigInteger_t06C831F115CE5B02A3EB70F99F2C5ABA75E0FF76* L_32;
		L_32 = NetBigInteger_ModPow_mA8056171CB7863175623991760489B0DCA3EA6B1(L_25, L_30, L_31, NULL);
		NullCheck(L_32);
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_33;
		L_33 = NetBigInteger_ToByteArrayUnsigned_m3A7A392C37CD2D701E96AFEF4193B21E451808FD(L_32, NULL);
		return L_33;
	}
}
// Lidgren.Network.NetXtea Lidgren.Network.NetSRP::CreateEncryption(Lidgren.Network.NetPeer,System.Byte[])
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR NetXtea_t550919425A4D12A3C995681D55B1719AB2FBD2F0* NetSRP_CreateEncryption_m91A3745FECEDFA2BF8B7112DE2D0B4260E0E6111 (NetPeer_tDCD3AC5FB42BE47DEE7AEEA74F327C1E0D883542* ___peer0, ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* ___sessionValue1, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&NetUtility_t0B01E9514810CE3FC3B5E83D8427CBA1C5689EFD_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&NetXtea_t550919425A4D12A3C995681D55B1719AB2FBD2F0_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* V_0 = NULL;
	ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* V_1 = NULL;
	int32_t V_2 = 0;
	int32_t V_3 = 0;
	{
		// var hash = NetUtility.ComputeSHAHash(sessionValue);
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_0 = ___sessionValue1;
		il2cpp_codegen_runtime_class_init_inline(NetUtility_t0B01E9514810CE3FC3B5E83D8427CBA1C5689EFD_il2cpp_TypeInfo_var);
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_1;
		L_1 = NetUtility_ComputeSHAHash_mF0A369753E62EEE4E771C5638C1CB620D0CA48AD(L_0, NULL);
		V_0 = L_1;
		// var key = new byte[16];
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_2 = (ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031*)(ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031*)SZArrayNew(ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031_il2cpp_TypeInfo_var, (uint32_t)((int32_t)16));
		V_1 = L_2;
		// for(int i=0;i<16;i++)
		V_2 = 0;
		goto IL_0042;
	}

IL_0013:
	{
		// key[i] = hash[i];
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_3 = V_1;
		int32_t L_4 = V_2;
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_5 = V_0;
		int32_t L_6 = V_2;
		NullCheck(L_5);
		int32_t L_7 = L_6;
		uint8_t L_8 = (L_5)->GetAt(static_cast<il2cpp_array_size_t>(L_7));
		NullCheck(L_3);
		(L_3)->SetAt(static_cast<il2cpp_array_size_t>(L_4), (uint8_t)L_8);
		// for (int j = 1; j < hash.Length / 16; j++)
		V_3 = 1;
		goto IL_0035;
	}

IL_001d:
	{
		// key[i] ^= hash[i + (j * 16)];
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_9 = V_1;
		int32_t L_10 = V_2;
		NullCheck(L_9);
		uint8_t* L_11 = ((L_9)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_10)));
		int32_t L_12 = *((uint8_t*)L_11);
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_13 = V_0;
		int32_t L_14 = V_2;
		int32_t L_15 = V_3;
		NullCheck(L_13);
		int32_t L_16 = ((int32_t)il2cpp_codegen_add(L_14, ((int32_t)il2cpp_codegen_multiply(L_15, ((int32_t)16)))));
		uint8_t L_17 = (L_13)->GetAt(static_cast<il2cpp_array_size_t>(L_16));
		*((int8_t*)L_11) = (int8_t)((int32_t)(uint8_t)((int32_t)(L_12^(int32_t)L_17)));
		// for (int j = 1; j < hash.Length / 16; j++)
		int32_t L_18 = V_3;
		V_3 = ((int32_t)il2cpp_codegen_add(L_18, 1));
	}

IL_0035:
	{
		// for (int j = 1; j < hash.Length / 16; j++)
		int32_t L_19 = V_3;
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_20 = V_0;
		NullCheck(L_20);
		if ((((int32_t)L_19) < ((int32_t)((int32_t)(((int32_t)(((RuntimeArray*)L_20)->max_length))/((int32_t)16))))))
		{
			goto IL_001d;
		}
	}
	{
		// for(int i=0;i<16;i++)
		int32_t L_21 = V_2;
		V_2 = ((int32_t)il2cpp_codegen_add(L_21, 1));
	}

IL_0042:
	{
		// for(int i=0;i<16;i++)
		int32_t L_22 = V_2;
		if ((((int32_t)L_22) < ((int32_t)((int32_t)16))))
		{
			goto IL_0013;
		}
	}
	{
		// return new NetXtea(peer, key);
		NetPeer_tDCD3AC5FB42BE47DEE7AEEA74F327C1E0D883542* L_23 = ___peer0;
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_24 = V_1;
		NetXtea_t550919425A4D12A3C995681D55B1719AB2FBD2F0* L_25 = (NetXtea_t550919425A4D12A3C995681D55B1719AB2FBD2F0*)il2cpp_codegen_object_new(NetXtea_t550919425A4D12A3C995681D55B1719AB2FBD2F0_il2cpp_TypeInfo_var);
		NetXtea__ctor_mE66A210E14B876E2260B8FB6152B6EE4F8B89B7D(L_25, L_23, L_24, /*hidden argument*/NULL);
		return L_25;
	}
}
// System.Void Lidgren.Network.NetSRP::.cctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void NetSRP__cctor_mAE3D9BC3D67AD86F61D39C031F0A5AD78E1FF9F0 (const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&NetBigInteger_t06C831F115CE5B02A3EB70F99F2C5ABA75E0FF76_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&NetSRP_tCB8425B4A061CEF6A1C0914A06C41D2745DBD951_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral3489643EFE94266F20613DEAA99FFCC76C044707);
		s_Il2CppMethodInitialized = true;
	}
{
		// private static readonly NetBigInteger N = new NetBigInteger("0115b8b692e0e045692cf280b436735c77a5a9e8a9e7ed56c965f87db5b2a2ece3", 16);
		NetBigInteger_t06C831F115CE5B02A3EB70F99F2C5ABA75E0FF76* L_0 = (NetBigInteger_t06C831F115CE5B02A3EB70F99F2C5ABA75E0FF76*)il2cpp_codegen_object_new(NetBigInteger_t06C831F115CE5B02A3EB70F99F2C5ABA75E0FF76_il2cpp_TypeInfo_var);
		NetBigInteger__ctor_m4031CDB3BDCE25C1A09226CE4C36004FAC46ED25(L_0, _stringLiteral3489643EFE94266F20613DEAA99FFCC76C044707, ((int32_t)16), /*hidden argument*/NULL);
		((NetSRP_tCB8425B4A061CEF6A1C0914A06C41D2745DBD951_StaticFields*)il2cpp_codegen_static_fields_for(NetSRP_tCB8425B4A061CEF6A1C0914A06C41D2745DBD951_il2cpp_TypeInfo_var))->___N_0 = L_0;
		Il2CppCodeGenWriteBarrier((void**)(&((NetSRP_tCB8425B4A061CEF6A1C0914A06C41D2745DBD951_StaticFields*)il2cpp_codegen_static_fields_for(NetSRP_tCB8425B4A061CEF6A1C0914A06C41D2745DBD951_il2cpp_TypeInfo_var))->___N_0), (void*)L_0);
		// private static readonly NetBigInteger g = NetBigInteger.Two;
		il2cpp_codegen_runtime_class_init_inline(NetBigInteger_t06C831F115CE5B02A3EB70F99F2C5ABA75E0FF76_il2cpp_TypeInfo_var);
		NetBigInteger_t06C831F115CE5B02A3EB70F99F2C5ABA75E0FF76* L_1 = ((NetBigInteger_t06C831F115CE5B02A3EB70F99F2C5ABA75E0FF76_StaticFields*)il2cpp_codegen_static_fields_for(NetBigInteger_t06C831F115CE5B02A3EB70F99F2C5ABA75E0FF76_il2cpp_TypeInfo_var))->___Two_6;
		((NetSRP_tCB8425B4A061CEF6A1C0914A06C41D2745DBD951_StaticFields*)il2cpp_codegen_static_fields_for(NetSRP_tCB8425B4A061CEF6A1C0914A06C41D2745DBD951_il2cpp_TypeInfo_var))->___g_1 = L_1;
		Il2CppCodeGenWriteBarrier((void**)(&((NetSRP_tCB8425B4A061CEF6A1C0914A06C41D2745DBD951_StaticFields*)il2cpp_codegen_static_fields_for(NetSRP_tCB8425B4A061CEF6A1C0914A06C41D2745DBD951_il2cpp_TypeInfo_var))->___g_1), (void*)L_1);
		// private static readonly NetBigInteger k = ComputeMultiplier();
		NetBigInteger_t06C831F115CE5B02A3EB70F99F2C5ABA75E0FF76* L_2;
		L_2 = NetSRP_ComputeMultiplier_m755DBE4F28AFCA07BBACBF9A500F550A70CB596C(NULL);
		((NetSRP_tCB8425B4A061CEF6A1C0914A06C41D2745DBD951_StaticFields*)il2cpp_codegen_static_fields_for(NetSRP_tCB8425B4A061CEF6A1C0914A06C41D2745DBD951_il2cpp_TypeInfo_var))->___k_2 = L_2;
		Il2CppCodeGenWriteBarrier((void**)(&((NetSRP_tCB8425B4A061CEF6A1C0914A06C41D2745DBD951_StaticFields*)il2cpp_codegen_static_fields_for(NetSRP_tCB8425B4A061CEF6A1C0914A06C41D2745DBD951_il2cpp_TypeInfo_var))->___k_2), (void*)L_2);
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
// Conversion methods for marshalling of: Lidgren.Network.NetStoredReliableMessage
IL2CPP_EXTERN_C void NetStoredReliableMessage_t32B73B76F26B4659411CEBFF7647E6D567487D39_marshal_pinvoke(const NetStoredReliableMessage_t32B73B76F26B4659411CEBFF7647E6D567487D39& unmarshaled, NetStoredReliableMessage_t32B73B76F26B4659411CEBFF7647E6D567487D39_marshaled_pinvoke& marshaled)
{
	Exception_t* ___Message_2Exception = il2cpp_codegen_get_marshal_directive_exception("Cannot marshal field 'Message' of type 'NetStoredReliableMessage': Reference type field marshaling is not supported.");
	IL2CPP_RAISE_MANAGED_EXCEPTION(___Message_2Exception, NULL);
}
IL2CPP_EXTERN_C void NetStoredReliableMessage_t32B73B76F26B4659411CEBFF7647E6D567487D39_marshal_pinvoke_back(const NetStoredReliableMessage_t32B73B76F26B4659411CEBFF7647E6D567487D39_marshaled_pinvoke& marshaled, NetStoredReliableMessage_t32B73B76F26B4659411CEBFF7647E6D567487D39& unmarshaled)
{
	Exception_t* ___Message_2Exception = il2cpp_codegen_get_marshal_directive_exception("Cannot marshal field 'Message' of type 'NetStoredReliableMessage': Reference type field marshaling is not supported.");
	IL2CPP_RAISE_MANAGED_EXCEPTION(___Message_2Exception, NULL);
}
// Conversion method for clean up from marshalling of: Lidgren.Network.NetStoredReliableMessage
IL2CPP_EXTERN_C void NetStoredReliableMessage_t32B73B76F26B4659411CEBFF7647E6D567487D39_marshal_pinvoke_cleanup(NetStoredReliableMessage_t32B73B76F26B4659411CEBFF7647E6D567487D39_marshaled_pinvoke& marshaled)
{
}
// Conversion methods for marshalling of: Lidgren.Network.NetStoredReliableMessage
IL2CPP_EXTERN_C void NetStoredReliableMessage_t32B73B76F26B4659411CEBFF7647E6D567487D39_marshal_com(const NetStoredReliableMessage_t32B73B76F26B4659411CEBFF7647E6D567487D39& unmarshaled, NetStoredReliableMessage_t32B73B76F26B4659411CEBFF7647E6D567487D39_marshaled_com& marshaled)
{
	Exception_t* ___Message_2Exception = il2cpp_codegen_get_marshal_directive_exception("Cannot marshal field 'Message' of type 'NetStoredReliableMessage': Reference type field marshaling is not supported.");
	IL2CPP_RAISE_MANAGED_EXCEPTION(___Message_2Exception, NULL);
}
IL2CPP_EXTERN_C void NetStoredReliableMessage_t32B73B76F26B4659411CEBFF7647E6D567487D39_marshal_com_back(const NetStoredReliableMessage_t32B73B76F26B4659411CEBFF7647E6D567487D39_marshaled_com& marshaled, NetStoredReliableMessage_t32B73B76F26B4659411CEBFF7647E6D567487D39& unmarshaled)
{
	Exception_t* ___Message_2Exception = il2cpp_codegen_get_marshal_directive_exception("Cannot marshal field 'Message' of type 'NetStoredReliableMessage': Reference type field marshaling is not supported.");
	IL2CPP_RAISE_MANAGED_EXCEPTION(___Message_2Exception, NULL);
}
// Conversion method for clean up from marshalling of: Lidgren.Network.NetStoredReliableMessage
IL2CPP_EXTERN_C void NetStoredReliableMessage_t32B73B76F26B4659411CEBFF7647E6D567487D39_marshal_com_cleanup(NetStoredReliableMessage_t32B73B76F26B4659411CEBFF7647E6D567487D39_marshaled_com& marshaled)
{
}
// System.Void Lidgren.Network.NetStoredReliableMessage::Reset()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void NetStoredReliableMessage_Reset_mFFC4A5507657DEE70D8C557ED904E4E5E180721F (NetStoredReliableMessage_t32B73B76F26B4659411CEBFF7647E6D567487D39* __this, const RuntimeMethod* method) 
{
{
		// NumSent = 0;
		__this->___NumSent_0 = 0;
		// LastSent = 0.0;
		__this->___LastSent_1 = (0.0);
		// Message = null;
		__this->___Message_2 = (NetOutgoingMessage_t2C00CEEAEF52CDD51F8F991F2F8AFA314FEAAECB*)NULL;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___Message_2), (void*)(NetOutgoingMessage_t2C00CEEAEF52CDD51F8F991F2F8AFA314FEAAECB*)NULL);
		// }
		return;
	}
}
IL2CPP_EXTERN_C  void NetStoredReliableMessage_Reset_mFFC4A5507657DEE70D8C557ED904E4E5E180721F_AdjustorThunk (RuntimeObject* __this, const RuntimeMethod* method)
{
NetStoredReliableMessage_t32B73B76F26B4659411CEBFF7647E6D567487D39* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<NetStoredReliableMessage_t32B73B76F26B4659411CEBFF7647E6D567487D39*>(__this + _offset);
	NetStoredReliableMessage_Reset_mFFC4A5507657DEE70D8C557ED904E4E5E180721F(_thisAdjusted, method);
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.String Lidgren.Network.NetTime::ToReadable(System.Double)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* NetTime_ToReadable_mF6CA9C80EE1C9B03D97E429F5DB9477BC426A37F (double ___seconds0, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&TimeSpan_t8195C5B013A2C532FEBDF0B64B6911982E750F5A_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral3366F334BA687B5F09C809786A02BFA24ADA8FE4);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralB15D8BB6ED8882FE2991E7CFC731A0E16DD9C8D4);
		s_Il2CppMethodInitialized = true;
	}
TimeSpan_t8195C5B013A2C532FEBDF0B64B6911982E750F5A V_0;
	memset((&V_0), 0, sizeof(V_0));
	double V_1 = 0.0;
	{
		// if (seconds > 60)
		double L_0 = ___seconds0;
		if ((!(((double)L_0) > ((double)(60.0)))))
		{
			goto IL_0021;
		}
	}
	{
		// return TimeSpan.FromSeconds(seconds).ToString();
		double L_1 = ___seconds0;
		il2cpp_codegen_runtime_class_init_inline(TimeSpan_t8195C5B013A2C532FEBDF0B64B6911982E750F5A_il2cpp_TypeInfo_var);
		TimeSpan_t8195C5B013A2C532FEBDF0B64B6911982E750F5A L_2;
		L_2 = TimeSpan_FromSeconds_mE585CC8180040ED064DC8B6546E6C94A129BFFC5(L_1, NULL);
		V_0 = L_2;
		String_t* L_3;
		L_3 = TimeSpan_ToString_m44D5BF48E35E18BB8B99A86B6535DA5E847FFE92((&V_0), NULL);
		return L_3;
	}

IL_0021:
	{
		// return (seconds * 1000.0).ToString("N2") + " ms";
		double L_4 = ___seconds0;
		V_1 = ((double)il2cpp_codegen_multiply(L_4, (1000.0)));
		String_t* L_5;
		L_5 = Double_ToString_m70EC76E1DAD7E8B5B47AF9292189BF3711B24B75((&V_1), _stringLiteral3366F334BA687B5F09C809786A02BFA24ADA8FE4, NULL);
		String_t* L_6;
		L_6 = String_Concat_mAF2CE02CC0CB7460753D0A1A91CCF2B1E9804C5D(L_5, _stringLiteralB15D8BB6ED8882FE2991E7CFC731A0E16DD9C8D4, NULL);
		return L_6;
	}
}
// System.Double Lidgren.Network.NetTime::get_Now()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR double NetTime_get_Now_mDDB364AF74A766A60E95E4799647B7EDD823EA96 (const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&NetTime_tF7D62D28C9302513C9535DE2F9B41553B2548DE7_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Stopwatch_tA188A210449E22C07053A7D3014DD182C7369043_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
{
		// public static double Now { get { return (double)(Stopwatch.GetTimestamp() - s_timeInitialized) * s_dInvFreq; } }
		il2cpp_codegen_runtime_class_init_inline(Stopwatch_tA188A210449E22C07053A7D3014DD182C7369043_il2cpp_TypeInfo_var);
		int64_t L_0;
		L_0 = Stopwatch_GetTimestamp_mD6D582A3E30369F05C829A5650BE2AE511EC807F(NULL);
		il2cpp_codegen_runtime_class_init_inline(NetTime_tF7D62D28C9302513C9535DE2F9B41553B2548DE7_il2cpp_TypeInfo_var);
		int64_t L_1 = ((NetTime_tF7D62D28C9302513C9535DE2F9B41553B2548DE7_StaticFields*)il2cpp_codegen_static_fields_for(NetTime_tF7D62D28C9302513C9535DE2F9B41553B2548DE7_il2cpp_TypeInfo_var))->___s_timeInitialized_0;
		double L_2 = ((NetTime_tF7D62D28C9302513C9535DE2F9B41553B2548DE7_StaticFields*)il2cpp_codegen_static_fields_for(NetTime_tF7D62D28C9302513C9535DE2F9B41553B2548DE7_il2cpp_TypeInfo_var))->___s_dInvFreq_1;
		return ((double)il2cpp_codegen_multiply(((double)((int64_t)il2cpp_codegen_subtract(L_0, L_1))), L_2));
	}
}
// System.Void Lidgren.Network.NetTime::.cctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void NetTime__cctor_m146FF8FCCAC7924A13B8806C0E9704E35C077A8A (const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&NetTime_tF7D62D28C9302513C9535DE2F9B41553B2548DE7_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Stopwatch_tA188A210449E22C07053A7D3014DD182C7369043_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
{
		// private static readonly long s_timeInitialized = Stopwatch.GetTimestamp();
		il2cpp_codegen_runtime_class_init_inline(Stopwatch_tA188A210449E22C07053A7D3014DD182C7369043_il2cpp_TypeInfo_var);
		int64_t L_0;
		L_0 = Stopwatch_GetTimestamp_mD6D582A3E30369F05C829A5650BE2AE511EC807F(NULL);
		((NetTime_tF7D62D28C9302513C9535DE2F9B41553B2548DE7_StaticFields*)il2cpp_codegen_static_fields_for(NetTime_tF7D62D28C9302513C9535DE2F9B41553B2548DE7_il2cpp_TypeInfo_var))->___s_timeInitialized_0 = L_0;
		// private static readonly double s_dInvFreq = 1.0 / (double)Stopwatch.Frequency;
		int64_t L_1 = ((Stopwatch_tA188A210449E22C07053A7D3014DD182C7369043_StaticFields*)il2cpp_codegen_static_fields_for(Stopwatch_tA188A210449E22C07053A7D3014DD182C7369043_il2cpp_TypeInfo_var))->___Frequency_0;
		((NetTime_tF7D62D28C9302513C9535DE2F9B41553B2548DE7_StaticFields*)il2cpp_codegen_static_fields_for(NetTime_tF7D62D28C9302513C9535DE2F9B41553B2548DE7_il2cpp_TypeInfo_var))->___s_dInvFreq_1 = ((double)((1.0)/((double)L_1)));
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
// System.Int32 Lidgren.Network.NetUnreliableSenderChannel::get_WindowSize()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t NetUnreliableSenderChannel_get_WindowSize_m246C7236FB466D8B5B233D821FEF08EA9EB3EA4D (NetUnreliableSenderChannel_tA3223FD53136DB0B7FE5725D243F2513393E55B5* __this, const RuntimeMethod* method) 
{
{
		// internal override int WindowSize { get { return m_windowSize; } }
		int32_t L_0 = __this->___m_windowSize_3;
		return L_0;
	}
}
// System.Void Lidgren.Network.NetUnreliableSenderChannel::.ctor(Lidgren.Network.NetConnection,System.Int32,Lidgren.Network.NetDeliveryMethod)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void NetUnreliableSenderChannel__ctor_m4FAB98EAC9B17F9A15CCD29869F6284431EB0F05 (NetUnreliableSenderChannel_tA3223FD53136DB0B7FE5725D243F2513393E55B5* __this, NetConnection_tBC8B4699CF2D1614FF259EE7E3031D8D25E31F9D* ___connection0, int32_t ___windowSize1, uint8_t ___method2, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&NetBitVector_tF8CA8B405111502BD2A21BADB51D903E2E21FF67_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&NetQueue_1__ctor_m66DF6F6C6BA14E66C85046A8D415C5E75508640F_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&NetQueue_1_tE04A2248A2948BB1FCEAAF0A1151D27B56B71EA3_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
{
		// internal NetUnreliableSenderChannel(NetConnection connection, int windowSize, NetDeliveryMethod method)
		NetSenderChannelBase__ctor_m4F33557333904C43F29ED7D4153AAE87A49F8A0C(__this, NULL);
		// m_connection = connection;
		NetConnection_tBC8B4699CF2D1614FF259EE7E3031D8D25E31F9D* L_0 = ___connection0;
		__this->___m_connection_1 = L_0;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___m_connection_1), (void*)L_0);
		// m_windowSize = windowSize;
		int32_t L_1 = ___windowSize1;
		__this->___m_windowSize_3 = L_1;
		// m_windowStart = 0;
		__this->___m_windowStart_2 = 0;
		// m_sendStart = 0;
		__this->___m_sendStart_4 = 0;
		// m_receivedAcks = new NetBitVector(NetConstants.NumSequenceNumbers);
		NetBitVector_tF8CA8B405111502BD2A21BADB51D903E2E21FF67* L_2 = (NetBitVector_tF8CA8B405111502BD2A21BADB51D903E2E21FF67*)il2cpp_codegen_object_new(NetBitVector_tF8CA8B405111502BD2A21BADB51D903E2E21FF67_il2cpp_TypeInfo_var);
		NetBitVector__ctor_mEFF54B813F6C5472ED26A05E548B460CAB39B4A5(L_2, ((int32_t)1024), /*hidden argument*/NULL);
		__this->___m_receivedAcks_6 = L_2;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___m_receivedAcks_6), (void*)L_2);
		// m_queuedSends = new NetQueue<NetOutgoingMessage>(8);
		NetQueue_1_tE04A2248A2948BB1FCEAAF0A1151D27B56B71EA3* L_3 = (NetQueue_1_tE04A2248A2948BB1FCEAAF0A1151D27B56B71EA3*)il2cpp_codegen_object_new(NetQueue_1_tE04A2248A2948BB1FCEAAF0A1151D27B56B71EA3_il2cpp_TypeInfo_var);
		NetQueue_1__ctor_m66DF6F6C6BA14E66C85046A8D415C5E75508640F(L_3, 8, /*hidden argument*/NetQueue_1__ctor_m66DF6F6C6BA14E66C85046A8D415C5E75508640F_RuntimeMethod_var);
		((NetSenderChannelBase_t60E3BDE4FA746EE6C8453DD201764C0B7D6948A2*)__this)->___m_queuedSends_0 = L_3;
		Il2CppCodeGenWriteBarrier((void**)(&((NetSenderChannelBase_t60E3BDE4FA746EE6C8453DD201764C0B7D6948A2*)__this)->___m_queuedSends_0), (void*)L_3);
		// m_doFlowControl = true;
		__this->___m_doFlowControl_5 = (bool)1;
		// if (method == NetDeliveryMethod.Unreliable && connection.Peer.Configuration.SuppressUnreliableUnorderedAcks == true)
		uint8_t L_4 = ___method2;
		if ((!(((uint32_t)L_4) == ((uint32_t)1))))
		{
			goto IL_0062;
		}
	}
	{
		NetConnection_tBC8B4699CF2D1614FF259EE7E3031D8D25E31F9D* L_5 = ___connection0;
		NullCheck(L_5);
		NetPeer_tDCD3AC5FB42BE47DEE7AEEA74F327C1E0D883542* L_6;
		L_6 = NetConnection_get_Peer_mD4190401C6B4D50DBDF739F47D1DD494AF7CC04F_inline(L_5, NULL);
		NullCheck(L_6);
		NetPeerConfiguration_t7BA55B2118BE6EC975E65EEE156B05E72A3339DD* L_7;
		L_7 = NetPeer_get_Configuration_m45ADD4611BB6484ADBAEF24A81768E19AEB77F7B_inline(L_6, NULL);
		NullCheck(L_7);
		bool L_8;
		L_8 = NetPeerConfiguration_get_SuppressUnreliableUnorderedAcks_m9E8972CF4FF6CB86C992334F40DC8E922042301A_inline(L_7, NULL);
		if (!L_8)
		{
			goto IL_0062;
		}
	}
	{
		// m_doFlowControl = false;
		__this->___m_doFlowControl_5 = (bool)0;
	}

IL_0062:
	{
		// }
		return;
	}
}
// System.Int32 Lidgren.Network.NetUnreliableSenderChannel::GetAllowedSends()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t NetUnreliableSenderChannel_GetAllowedSends_mE47B0D3415D8B530BAE9FDD745AD773D4575A424 (NetUnreliableSenderChannel_tA3223FD53136DB0B7FE5725D243F2513393E55B5* __this, const RuntimeMethod* method) 
{
{
		// if (!m_doFlowControl)
		bool L_0 = __this->___m_doFlowControl_5;
		if (L_0)
		{
			goto IL_000e;
		}
	}
	{
		// return int.MaxValue; // always allowed to send without flow control!
		return ((int32_t)2147483647LL);
	}

IL_000e:
	{
		// int retval = m_windowSize - ((m_sendStart + NetConstants.NumSequenceNumbers) - m_windowStart) % m_windowSize;
		int32_t L_1 = __this->___m_windowSize_3;
		int32_t L_2 = __this->___m_sendStart_4;
		int32_t L_3 = __this->___m_windowStart_2;
		int32_t L_4 = __this->___m_windowSize_3;
		// return retval;
		return ((int32_t)il2cpp_codegen_subtract(L_1, ((int32_t)(((int32_t)il2cpp_codegen_subtract(((int32_t)il2cpp_codegen_add(L_2, ((int32_t)1024))), L_3))%L_4))));
	}
}
// System.Void Lidgren.Network.NetUnreliableSenderChannel::Reset()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void NetUnreliableSenderChannel_Reset_mC4D02CDD2BA4005ABA6C6B661EAA11CDB7681925 (NetUnreliableSenderChannel_tA3223FD53136DB0B7FE5725D243F2513393E55B5* __this, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&NetQueue_1_Clear_m2D3A4A1665A1449F169FAD863EC1025C6A471FDB_RuntimeMethod_var);
		s_Il2CppMethodInitialized = true;
	}
{
		// m_receivedAcks.Clear();
		NetBitVector_tF8CA8B405111502BD2A21BADB51D903E2E21FF67* L_0 = __this->___m_receivedAcks_6;
		NullCheck(L_0);
		NetBitVector_Clear_mD555550DF31C9B77DB6DEFBFF5508256A923AE6D(L_0, NULL);
		// m_queuedSends.Clear();
		NetQueue_1_tE04A2248A2948BB1FCEAAF0A1151D27B56B71EA3* L_1 = ((NetSenderChannelBase_t60E3BDE4FA746EE6C8453DD201764C0B7D6948A2*)__this)->___m_queuedSends_0;
		NullCheck(L_1);
		NetQueue_1_Clear_m2D3A4A1665A1449F169FAD863EC1025C6A471FDB(L_1, NetQueue_1_Clear_m2D3A4A1665A1449F169FAD863EC1025C6A471FDB_RuntimeMethod_var);
		// m_windowStart = 0;
		__this->___m_windowStart_2 = 0;
		// m_sendStart = 0;
		__this->___m_sendStart_4 = 0;
		// }
		return;
	}
}
// Lidgren.Network.NetSendResult Lidgren.Network.NetUnreliableSenderChannel::Enqueue(Lidgren.Network.NetOutgoingMessage)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t NetUnreliableSenderChannel_Enqueue_m9AA61D2C6D1433C837C91728FFA3AABA622A9708 (NetUnreliableSenderChannel_tA3223FD53136DB0B7FE5725D243F2513393E55B5* __this, NetOutgoingMessage_t2C00CEEAEF52CDD51F8F991F2F8AFA314FEAAECB* ___message0, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&NetQueue_1_Enqueue_m29381A69FDF40552A8ABA5B1385D72E71F1EB435_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&NetQueue_1_get_Count_m9D0B8118A5875517A26773BBA576C2006810DE22_RuntimeMethod_var);
		s_Il2CppMethodInitialized = true;
	}
int32_t V_0 = 0;
	{
		// int queueLen = m_queuedSends.Count + 1;
		NetQueue_1_tE04A2248A2948BB1FCEAAF0A1151D27B56B71EA3* L_0 = ((NetSenderChannelBase_t60E3BDE4FA746EE6C8453DD201764C0B7D6948A2*)__this)->___m_queuedSends_0;
		NullCheck(L_0);
		int32_t L_1;
		L_1 = NetQueue_1_get_Count_m9D0B8118A5875517A26773BBA576C2006810DE22(L_0, NetQueue_1_get_Count_m9D0B8118A5875517A26773BBA576C2006810DE22_RuntimeMethod_var);
		// int left = GetAllowedSends();
		int32_t L_2;
		L_2 = VirtualFuncInvoker0< int32_t >::Invoke(5 /* System.Int32 Lidgren.Network.NetSenderChannelBase::GetAllowedSends() */, __this);
		V_0 = L_2;
		// if (queueLen > left || (message.LengthBytes > m_connection.m_currentMTU && m_connection.m_peerConfiguration.UnreliableSizeBehaviour == NetUnreliableSizeBehaviour.DropAboveMTU))
		int32_t L_3 = V_0;
		if ((((int32_t)((int32_t)il2cpp_codegen_add(L_1, 1))) > ((int32_t)L_3)))
		{
			goto IL_003d;
		}
	}
	{
		NetOutgoingMessage_t2C00CEEAEF52CDD51F8F991F2F8AFA314FEAAECB* L_4 = ___message0;
		NullCheck(L_4);
		int32_t L_5;
		L_5 = NetBuffer_get_LengthBytes_mB7834EFF0C64E788397B77CAB3F51AF07A5DF3A5(L_4, NULL);
		NetConnection_tBC8B4699CF2D1614FF259EE7E3031D8D25E31F9D* L_6 = __this->___m_connection_1;
		NullCheck(L_6);
		int32_t L_7 = L_6->___m_currentMTU_38;
		if ((((int32_t)L_5) <= ((int32_t)L_7)))
		{
			goto IL_003f;
		}
	}
	{
		NetConnection_tBC8B4699CF2D1614FF259EE7E3031D8D25E31F9D* L_8 = __this->___m_connection_1;
		NullCheck(L_8);
		NetPeerConfiguration_t7BA55B2118BE6EC975E65EEE156B05E72A3339DD* L_9 = L_8->___m_peerConfiguration_3;
		NullCheck(L_9);
		int32_t L_10;
		L_10 = NetPeerConfiguration_get_UnreliableSizeBehaviour_m8C1D20EBDDEEF517EC403FB17911127A29B961D4_inline(L_9, NULL);
		if ((!(((uint32_t)L_10) == ((uint32_t)2))))
		{
			goto IL_003f;
		}
	}

IL_003d:
	{
		// return NetSendResult.Dropped;
		return (int32_t)(3);
	}

IL_003f:
	{
		// m_queuedSends.Enqueue(message);
		NetQueue_1_tE04A2248A2948BB1FCEAAF0A1151D27B56B71EA3* L_11 = ((NetSenderChannelBase_t60E3BDE4FA746EE6C8453DD201764C0B7D6948A2*)__this)->___m_queuedSends_0;
		NetOutgoingMessage_t2C00CEEAEF52CDD51F8F991F2F8AFA314FEAAECB* L_12 = ___message0;
		NullCheck(L_11);
		NetQueue_1_Enqueue_m29381A69FDF40552A8ABA5B1385D72E71F1EB435(L_11, L_12, NetQueue_1_Enqueue_m29381A69FDF40552A8ABA5B1385D72E71F1EB435_RuntimeMethod_var);
		// m_connection.m_peer.m_needFlushSendQueue = true; // a race condition to this variable will simply result in a single superflous call to FlushSendQueue()
		NetConnection_tBC8B4699CF2D1614FF259EE7E3031D8D25E31F9D* L_13 = __this->___m_connection_1;
		NullCheck(L_13);
		NetPeer_tDCD3AC5FB42BE47DEE7AEEA74F327C1E0D883542* L_14 = L_13->___m_peer_2;
		NullCheck(L_14);
		L_14->___m_needFlushSendQueue_23 = (bool)1;
		// return NetSendResult.Sent;
		return (int32_t)(1);
	}
}
// System.Void Lidgren.Network.NetUnreliableSenderChannel::SendQueuedMessages(System.Double)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void NetUnreliableSenderChannel_SendQueuedMessages_mAA2C74510455C9025DC00FCD9E9FB7973996F6EB (NetUnreliableSenderChannel_tA3223FD53136DB0B7FE5725D243F2513393E55B5* __this, double ___now0, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&NetQueue_1_TryDequeue_m64BE224E287C91F5A80BC1F74C4777A5BD3BB97C_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&NetQueue_1_get_Count_m9D0B8118A5875517A26773BBA576C2006810DE22_RuntimeMethod_var);
		s_Il2CppMethodInitialized = true;
	}
int32_t V_0 = 0;
	NetOutgoingMessage_t2C00CEEAEF52CDD51F8F991F2F8AFA314FEAAECB* V_1 = NULL;
	{
		// int num = GetAllowedSends();
		int32_t L_0;
		L_0 = VirtualFuncInvoker0< int32_t >::Invoke(5 /* System.Int32 Lidgren.Network.NetSenderChannelBase::GetAllowedSends() */, __this);
		V_0 = L_0;
		// if (num < 1)
		int32_t L_1 = V_0;
		if ((((int32_t)L_1) >= ((int32_t)1)))
		{
			goto IL_0026;
		}
	}
	{
		// return;
		return;
	}

IL_000c:
	{
		// if (m_queuedSends.TryDequeue(out om))
		NetQueue_1_tE04A2248A2948BB1FCEAAF0A1151D27B56B71EA3* L_2 = ((NetSenderChannelBase_t60E3BDE4FA746EE6C8453DD201764C0B7D6948A2*)__this)->___m_queuedSends_0;
		NullCheck(L_2);
		bool L_3;
		L_3 = NetQueue_1_TryDequeue_m64BE224E287C91F5A80BC1F74C4777A5BD3BB97C(L_2, (&V_1), NetQueue_1_TryDequeue_m64BE224E287C91F5A80BC1F74C4777A5BD3BB97C_RuntimeMethod_var);
		if (!L_3)
		{
			goto IL_0022;
		}
	}
	{
		// ExecuteSend(om);
		NetOutgoingMessage_t2C00CEEAEF52CDD51F8F991F2F8AFA314FEAAECB* L_4 = V_1;
		NetUnreliableSenderChannel_ExecuteSend_mCDDF357AB62D89803232EAA96761008A2E009A78(__this, L_4, NULL);
	}

IL_0022:
	{
		// num--;
		int32_t L_5 = V_0;
		V_0 = ((int32_t)il2cpp_codegen_subtract(L_5, 1));
	}

IL_0026:
	{
		// while (num > 0 && m_queuedSends.Count > 0)
		int32_t L_6 = V_0;
		if ((((int32_t)L_6) <= ((int32_t)0)))
		{
			goto IL_0038;
		}
	}
	{
		NetQueue_1_tE04A2248A2948BB1FCEAAF0A1151D27B56B71EA3* L_7 = ((NetSenderChannelBase_t60E3BDE4FA746EE6C8453DD201764C0B7D6948A2*)__this)->___m_queuedSends_0;
		NullCheck(L_7);
		int32_t L_8;
		L_8 = NetQueue_1_get_Count_m9D0B8118A5875517A26773BBA576C2006810DE22(L_7, NetQueue_1_get_Count_m9D0B8118A5875517A26773BBA576C2006810DE22_RuntimeMethod_var);
		if ((((int32_t)L_8) > ((int32_t)0)))
		{
			goto IL_000c;
		}
	}

IL_0038:
	{
		// }
		return;
	}
}
// System.Void Lidgren.Network.NetUnreliableSenderChannel::ExecuteSend(Lidgren.Network.NetOutgoingMessage)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void NetUnreliableSenderChannel_ExecuteSend_mCDDF357AB62D89803232EAA96761008A2E009A78 (NetUnreliableSenderChannel_tA3223FD53136DB0B7FE5725D243F2513393E55B5* __this, NetOutgoingMessage_t2C00CEEAEF52CDD51F8F991F2F8AFA314FEAAECB* ___message0, const RuntimeMethod* method) 
{
int32_t V_0 = 0;
	{
		// int seqNr = m_sendStart;
		int32_t L_0 = __this->___m_sendStart_4;
		V_0 = L_0;
		// m_sendStart = (m_sendStart + 1) % NetConstants.NumSequenceNumbers;
		int32_t L_1 = __this->___m_sendStart_4;
		__this->___m_sendStart_4 = ((int32_t)(((int32_t)il2cpp_codegen_add(L_1, 1))%((int32_t)1024)));
		// m_connection.QueueSendMessage(message, seqNr);
		NetConnection_tBC8B4699CF2D1614FF259EE7E3031D8D25E31F9D* L_2 = __this->___m_connection_1;
		NetOutgoingMessage_t2C00CEEAEF52CDD51F8F991F2F8AFA314FEAAECB* L_3 = ___message0;
		int32_t L_4 = V_0;
		NullCheck(L_2);
		NetConnection_QueueSendMessage_mCD87B7FD21EE3A2B3FF0D786ACDF6CBB4441721D(L_2, L_3, L_4, NULL);
		// if (message.m_recyclingCount <= 0)
		NetOutgoingMessage_t2C00CEEAEF52CDD51F8F991F2F8AFA314FEAAECB* L_5 = ___message0;
		NullCheck(L_5);
		int32_t L_6 = L_5->___m_recyclingCount_11;
		if ((((int32_t)L_6) > ((int32_t)0)))
		{
			goto IL_0042;
		}
	}
	{
		// m_connection.m_peer.Recycle(message);
		NetConnection_tBC8B4699CF2D1614FF259EE7E3031D8D25E31F9D* L_7 = __this->___m_connection_1;
		NullCheck(L_7);
		NetPeer_tDCD3AC5FB42BE47DEE7AEEA74F327C1E0D883542* L_8 = L_7->___m_peer_2;
		NetOutgoingMessage_t2C00CEEAEF52CDD51F8F991F2F8AFA314FEAAECB* L_9 = ___message0;
		NullCheck(L_8);
		NetPeer_Recycle_m19CD3E9FAB66822D78395ABD6E23DA7F58AA178E(L_8, L_9, NULL);
	}

IL_0042:
	{
		// return;
		return;
	}
}
// System.Void Lidgren.Network.NetUnreliableSenderChannel::ReceiveAcknowledge(System.Double,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void NetUnreliableSenderChannel_ReceiveAcknowledge_m538B45BDDEB685E7A8BA5AAD2B541F275EF00560 (NetUnreliableSenderChannel_tA3223FD53136DB0B7FE5725D243F2513393E55B5* __this, double ___now0, int32_t ___seqNr1, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&NetUtility_t0B01E9514810CE3FC3B5E83D8427CBA1C5689EFD_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral48BEAF85DA57187170C6471DAC10BD67D02A40BB);
		s_Il2CppMethodInitialized = true;
	}
int32_t V_0 = 0;
	{
		// if (m_doFlowControl == false)
		bool L_0 = __this->___m_doFlowControl_5;
		if (L_0)
		{
			goto IL_001e;
		}
	}
	{
		// m_connection.m_peer.LogWarning("SuppressUnreliableUnorderedAcks sender/receiver mismatch!");
		NetConnection_tBC8B4699CF2D1614FF259EE7E3031D8D25E31F9D* L_1 = __this->___m_connection_1;
		NullCheck(L_1);
		NetPeer_tDCD3AC5FB42BE47DEE7AEEA74F327C1E0D883542* L_2 = L_1->___m_peer_2;
		NullCheck(L_2);
		NetPeer_LogWarning_m2192971F3DF4443EDFCB1A4199897520163F227C(L_2, _stringLiteral48BEAF85DA57187170C6471DAC10BD67D02A40BB, NULL);
		// return;
		return;
	}

IL_001e:
	{
		// int relate = NetUtility.RelativeSequenceNumber(seqNr, m_windowStart);
		int32_t L_3 = ___seqNr1;
		int32_t L_4 = __this->___m_windowStart_2;
		il2cpp_codegen_runtime_class_init_inline(NetUtility_t0B01E9514810CE3FC3B5E83D8427CBA1C5689EFD_il2cpp_TypeInfo_var);
		int32_t L_5;
		L_5 = NetUtility_RelativeSequenceNumber_m5DE5D4F0FE867CF19738194E727E1437A81B69B7(L_3, L_4, NULL);
		V_0 = L_5;
		// if (relate < 0)
		int32_t L_6 = V_0;
		if ((((int32_t)L_6) >= ((int32_t)0)))
		{
			goto IL_0030;
		}
	}
	{
		// return; // late/duplicate ack
		return;
	}

IL_0030:
	{
		// if (relate == 0)
		int32_t L_7 = V_0;
		if (L_7)
		{
			goto IL_005a;
		}
	}
	{
		// m_receivedAcks[m_windowStart] = false;
		NetBitVector_tF8CA8B405111502BD2A21BADB51D903E2E21FF67* L_8 = __this->___m_receivedAcks_6;
		int32_t L_9 = __this->___m_windowStart_2;
		NullCheck(L_8);
		NetBitVector_set_Bit_m2A0E5C3CBF8B711C61AF9622627398B814229BE2(L_8, L_9, (bool)0, NULL);
		// m_windowStart = (m_windowStart + 1) % NetConstants.NumSequenceNumbers;
		int32_t L_10 = __this->___m_windowStart_2;
		__this->___m_windowStart_2 = ((int32_t)(((int32_t)il2cpp_codegen_add(L_10, 1))%((int32_t)1024)));
		// return;
		return;
	}

IL_005a:
	{
		// m_receivedAcks[seqNr] = true;
		NetBitVector_tF8CA8B405111502BD2A21BADB51D903E2E21FF67* L_11 = __this->___m_receivedAcks_6;
		int32_t L_12 = ___seqNr1;
		NullCheck(L_11);
		NetBitVector_set_Bit_m2A0E5C3CBF8B711C61AF9622627398B814229BE2(L_11, L_12, (bool)1, NULL);
		goto IL_008f;
	}

IL_0069:
	{
		// m_receivedAcks[m_windowStart] = false;
		NetBitVector_tF8CA8B405111502BD2A21BADB51D903E2E21FF67* L_13 = __this->___m_receivedAcks_6;
		int32_t L_14 = __this->___m_windowStart_2;
		NullCheck(L_13);
		NetBitVector_set_Bit_m2A0E5C3CBF8B711C61AF9622627398B814229BE2(L_13, L_14, (bool)0, NULL);
		// m_windowStart = (m_windowStart + 1) % NetConstants.NumSequenceNumbers;
		int32_t L_15 = __this->___m_windowStart_2;
		__this->___m_windowStart_2 = ((int32_t)(((int32_t)il2cpp_codegen_add(L_15, 1))%((int32_t)1024)));
	}

IL_008f:
	{
		// while (m_windowStart != seqNr)
		int32_t L_16 = __this->___m_windowStart_2;
		int32_t L_17 = ___seqNr1;
		if ((!(((uint32_t)L_16) == ((uint32_t)L_17))))
		{
			goto IL_0069;
		}
	}
	{
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
// System.Void Lidgren.Network.NetUnreliableSequencedReceiver::.ctor(Lidgren.Network.NetConnection)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void NetUnreliableSequencedReceiver__ctor_mF423D9050163A4A0E88EC7A44450657A63F96535 (NetUnreliableSequencedReceiver_t57B31E1EC305B1BF46565AEA3DB94CD7DCE328B7* __this, NetConnection_tBC8B4699CF2D1614FF259EE7E3031D8D25E31F9D* ___connection0, const RuntimeMethod* method) 
{
{
		// private int m_lastReceivedSequenceNumber = -1;
		__this->___m_lastReceivedSequenceNumber_2 = (-1);
		// : base(connection)
		NetConnection_tBC8B4699CF2D1614FF259EE7E3031D8D25E31F9D* L_0 = ___connection0;
		NetReceiverChannelBase__ctor_mA040707B5F73BB55192C0F44821F5326EC315A99(__this, L_0, NULL);
		// }
		return;
	}
}
// System.Void Lidgren.Network.NetUnreliableSequencedReceiver::ReceiveMessage(Lidgren.Network.NetIncomingMessage)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void NetUnreliableSequencedReceiver_ReceiveMessage_m7C4F32B08ED4121309FDDE305EBF71181BB3DCD8 (NetUnreliableSequencedReceiver_t57B31E1EC305B1BF46565AEA3DB94CD7DCE328B7* __this, NetIncomingMessage_t5E80A584865BF84B3148130AE0CE9A0794DD0A71* ___msg0, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&NetUtility_t0B01E9514810CE3FC3B5E83D8427CBA1C5689EFD_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
int32_t V_0 = 0;
	{
		// int nr = msg.m_sequenceNumber;
		NetIncomingMessage_t5E80A584865BF84B3148130AE0CE9A0794DD0A71* L_0 = ___msg0;
		NullCheck(L_0);
		int32_t L_1 = L_0->___m_sequenceNumber_12;
		V_0 = L_1;
		// m_connection.QueueAck(msg.m_receivedMessageType, nr);
		NetConnection_tBC8B4699CF2D1614FF259EE7E3031D8D25E31F9D* L_2 = ((NetReceiverChannelBase_t56118523C994D57E27F048D445AFF933D49CCA3C*)__this)->___m_connection_1;
		NetIncomingMessage_t5E80A584865BF84B3148130AE0CE9A0794DD0A71* L_3 = ___msg0;
		NullCheck(L_3);
		uint8_t L_4 = L_3->___m_receivedMessageType_13;
		int32_t L_5 = V_0;
		NullCheck(L_2);
		NetConnection_QueueAck_m6C5B3CECC443C7C33B67117795A5A0307C0EC179(L_2, L_4, L_5, NULL);
		// int relate = NetUtility.RelativeSequenceNumber(nr, m_lastReceivedSequenceNumber + 1);
		int32_t L_6 = V_0;
		int32_t L_7 = __this->___m_lastReceivedSequenceNumber_2;
		il2cpp_codegen_runtime_class_init_inline(NetUtility_t0B01E9514810CE3FC3B5E83D8427CBA1C5689EFD_il2cpp_TypeInfo_var);
		int32_t L_8;
		L_8 = NetUtility_RelativeSequenceNumber_m5DE5D4F0FE867CF19738194E727E1437A81B69B7(L_6, ((int32_t)il2cpp_codegen_add(L_7, 1)), NULL);
		// if (relate < 0)
		if ((((int32_t)L_8) >= ((int32_t)0)))
		{
			goto IL_002b;
		}
	}
	{
		// return; // drop if late
		return;
	}

IL_002b:
	{
		// m_lastReceivedSequenceNumber = nr;
		int32_t L_9 = V_0;
		__this->___m_lastReceivedSequenceNumber_2 = L_9;
		// m_peer.ReleaseMessage(msg);
		NetPeer_tDCD3AC5FB42BE47DEE7AEEA74F327C1E0D883542* L_10 = ((NetReceiverChannelBase_t56118523C994D57E27F048D445AFF933D49CCA3C*)__this)->___m_peer_0;
		NetIncomingMessage_t5E80A584865BF84B3148130AE0CE9A0794DD0A71* L_11 = ___msg0;
		NullCheck(L_10);
		NetPeer_ReleaseMessage_m360CE8B0C167EB96DCA5DDAE43E76E6C6AA68D2B(L_10, L_11, NULL);
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
// System.Void Lidgren.Network.NetUnreliableUnorderedReceiver::.ctor(Lidgren.Network.NetConnection)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void NetUnreliableUnorderedReceiver__ctor_m1417604E5461F677FF72E53ACFFDA7128DC44B61 (NetUnreliableUnorderedReceiver_t0E05BC9C7DF55EA30AF87AFC80106005C57A5131* __this, NetConnection_tBC8B4699CF2D1614FF259EE7E3031D8D25E31F9D* ___connection0, const RuntimeMethod* method) 
{
{
		// : base(connection)
		NetConnection_tBC8B4699CF2D1614FF259EE7E3031D8D25E31F9D* L_0 = ___connection0;
		NetReceiverChannelBase__ctor_mA040707B5F73BB55192C0F44821F5326EC315A99(__this, L_0, NULL);
		// m_doFlowControl = connection.Peer.Configuration.SuppressUnreliableUnorderedAcks == false;
		NetConnection_tBC8B4699CF2D1614FF259EE7E3031D8D25E31F9D* L_1 = ___connection0;
		NullCheck(L_1);
		NetPeer_tDCD3AC5FB42BE47DEE7AEEA74F327C1E0D883542* L_2;
		L_2 = NetConnection_get_Peer_mD4190401C6B4D50DBDF739F47D1DD494AF7CC04F_inline(L_1, NULL);
		NullCheck(L_2);
		NetPeerConfiguration_t7BA55B2118BE6EC975E65EEE156B05E72A3339DD* L_3;
		L_3 = NetPeer_get_Configuration_m45ADD4611BB6484ADBAEF24A81768E19AEB77F7B_inline(L_2, NULL);
		NullCheck(L_3);
		bool L_4;
		L_4 = NetPeerConfiguration_get_SuppressUnreliableUnorderedAcks_m9E8972CF4FF6CB86C992334F40DC8E922042301A_inline(L_3, NULL);
		__this->___m_doFlowControl_2 = (bool)((((int32_t)L_4) == ((int32_t)0))? 1 : 0);
		// }
		return;
	}
}
// System.Void Lidgren.Network.NetUnreliableUnorderedReceiver::ReceiveMessage(Lidgren.Network.NetIncomingMessage)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void NetUnreliableUnorderedReceiver_ReceiveMessage_m4081D6C06CC69A500E565546C05E020DA3F4263A (NetUnreliableUnorderedReceiver_t0E05BC9C7DF55EA30AF87AFC80106005C57A5131* __this, NetIncomingMessage_t5E80A584865BF84B3148130AE0CE9A0794DD0A71* ___msg0, const RuntimeMethod* method) 
{
{
		// if (m_doFlowControl)
		bool L_0 = __this->___m_doFlowControl_2;
		if (!L_0)
		{
			goto IL_001f;
		}
	}
	{
		// m_connection.QueueAck(msg.m_receivedMessageType, msg.m_sequenceNumber);
		NetConnection_tBC8B4699CF2D1614FF259EE7E3031D8D25E31F9D* L_1 = ((NetReceiverChannelBase_t56118523C994D57E27F048D445AFF933D49CCA3C*)__this)->___m_connection_1;
		NetIncomingMessage_t5E80A584865BF84B3148130AE0CE9A0794DD0A71* L_2 = ___msg0;
		NullCheck(L_2);
		uint8_t L_3 = L_2->___m_receivedMessageType_13;
		NetIncomingMessage_t5E80A584865BF84B3148130AE0CE9A0794DD0A71* L_4 = ___msg0;
		NullCheck(L_4);
		int32_t L_5 = L_4->___m_sequenceNumber_12;
		NullCheck(L_1);
		NetConnection_QueueAck_m6C5B3CECC443C7C33B67117795A5A0307C0EC179(L_1, L_3, L_5, NULL);
	}

IL_001f:
	{
		// m_peer.ReleaseMessage(msg);
		NetPeer_tDCD3AC5FB42BE47DEE7AEEA74F327C1E0D883542* L_6 = ((NetReceiverChannelBase_t56118523C994D57E27F048D445AFF933D49CCA3C*)__this)->___m_peer_0;
		NetIncomingMessage_t5E80A584865BF84B3148130AE0CE9A0794DD0A71* L_7 = ___msg0;
		NullCheck(L_6);
		NetPeer_ReleaseMessage_m360CE8B0C167EB96DCA5DDAE43E76E6C6AA68D2B(L_6, L_7, NULL);
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
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// Lidgren.Network.UPnPStatus Lidgren.Network.NetUPnP::get_Status()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t NetUPnP_get_Status_m4517463149E6F0A0ABC9D70D7573965103D695CF (NetUPnP_tBDA843B6A55F8DBED04BF614EEAEDB1F256D86E8* __this, const RuntimeMethod* method) 
{
{
		// public UPnPStatus Status { get { return m_status; } }
		int32_t L_0 = __this->___m_status_6;
		return L_0;
	}
}
// System.Void Lidgren.Network.NetUPnP::.ctor(Lidgren.Network.NetPeer)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void NetUPnP__ctor_mCD6AB41B5CBEE987E9CF674B3D5EE338BC5F5152 (NetUPnP_tBDA843B6A55F8DBED04BF614EEAEDB1F256D86E8* __this, NetPeer_tDCD3AC5FB42BE47DEE7AEEA74F327C1E0D883542* ___peer0, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ManualResetEvent_t63959486AA41A113A4353D0BF4A68E77EBA0A158_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralDA39A3EE5E6B4B0D3255BFEF95601890AFD80709);
		s_Il2CppMethodInitialized = true;
	}
{
		// private string m_serviceName = "";
		__this->___m_serviceName_2 = _stringLiteralDA39A3EE5E6B4B0D3255BFEF95601890AFD80709;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___m_serviceName_2), (void*)_stringLiteralDA39A3EE5E6B4B0D3255BFEF95601890AFD80709);
		// private ManualResetEvent m_discoveryComplete = new ManualResetEvent(false);
		ManualResetEvent_t63959486AA41A113A4353D0BF4A68E77EBA0A158* L_0 = (ManualResetEvent_t63959486AA41A113A4353D0BF4A68E77EBA0A158*)il2cpp_codegen_object_new(ManualResetEvent_t63959486AA41A113A4353D0BF4A68E77EBA0A158_il2cpp_TypeInfo_var);
		ManualResetEvent__ctor_m361CFCF6AC28BFFF5C8790DC2B5951791A1C4CEE(L_0, (bool)0, /*hidden argument*/NULL);
		__this->___m_discoveryComplete_4 = L_0;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___m_discoveryComplete_4), (void*)L_0);
		// public NetUPnP(NetPeer peer)
		Object__ctor_mE837C6B9FA8C6D5D109F4B2EC885D79919AC0EA2(__this, NULL);
		// m_peer = peer;
		NetPeer_tDCD3AC5FB42BE47DEE7AEEA74F327C1E0D883542* L_1 = ___peer0;
		__this->___m_peer_3 = L_1;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___m_peer_3), (void*)L_1);
		// m_discoveryResponseDeadline = double.MinValue;
		__this->___m_discoveryResponseDeadline_5 = (-1.7976931348623157E+308);
		// }
		return;
	}
}
// System.Void Lidgren.Network.NetUPnP::Discover(Lidgren.Network.NetPeer)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void NetUPnP_Discover_m27FF63DED921CBE7BFE709B2837996B1AB36F7A9 (NetUPnP_tBDA843B6A55F8DBED04BF614EEAEDB1F256D86E8* __this, NetPeer_tDCD3AC5FB42BE47DEE7AEEA74F327C1E0D883542* ___peer0, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IPEndPoint_t2F09CBA7A808B67724B4E2954EEDC46D910F4ECB_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&NetTime_tF7D62D28C9302513C9535DE2F9B41553B2548DE7_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&NetUtility_t0B01E9514810CE3FC3B5E83D8427CBA1C5689EFD_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralD8BEF597D4648B03343F2A7F25B08E6FCC313671);
		s_Il2CppMethodInitialized = true;
	}
String_t* V_0 = NULL;
	ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* V_1 = NULL;
	{
		//             string str =
		// "M-SEARCH * HTTP/1.1\r\n" +
		// "HOST: 239.255.255.250:1900\r\n" +
		// "ST:upnp:rootdevice\r\n" +
		// "MAN:\"ssdp:discover\"\r\n" +
		// "MX:3\r\n\r\n";
		V_0 = _stringLiteralD8BEF597D4648B03343F2A7F25B08E6FCC313671;
		// m_discoveryResponseDeadline = NetTime.Now + 6.0; // arbitrarily chosen number, router gets 6 seconds to respond
		il2cpp_codegen_runtime_class_init_inline(NetTime_tF7D62D28C9302513C9535DE2F9B41553B2548DE7_il2cpp_TypeInfo_var);
		double L_0;
		L_0 = NetTime_get_Now_mDDB364AF74A766A60E95E4799647B7EDD823EA96(NULL);
		__this->___m_discoveryResponseDeadline_5 = ((double)il2cpp_codegen_add(L_0, (6.0)));
		// m_status = UPnPStatus.Discovering;
		__this->___m_status_6 = 0;
		// byte[] arr = System.Text.Encoding.UTF8.GetBytes(str);
		Encoding_t65CDEF28CF20A7B8C92E85A4E808920C2465F095* L_1;
		L_1 = Encoding_get_UTF8_m9700ADA8E0F244002B2A89B483F1B2133B8FE336(NULL);
		String_t* L_2 = V_0;
		NullCheck(L_1);
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_3;
		L_3 = VirtualFuncInvoker1< ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031*, String_t* >::Invoke(18 /* System.Byte[] System.Text.Encoding::GetBytes(System.String) */, L_1, L_2);
		V_1 = L_3;
		// peer.Socket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.Broadcast, true);
		NetPeer_tDCD3AC5FB42BE47DEE7AEEA74F327C1E0D883542* L_4 = ___peer0;
		NullCheck(L_4);
		Socket_t1F49472CDA22B581C29A258225ABF3ADA9DED67E* L_5;
		L_5 = NetPeer_get_Socket_mCC49D19E418EEF9BCB8843C3475592AA8B6A2CC8_inline(L_4, NULL);
		NullCheck(L_5);
		Socket_SetSocketOption_mE47F5DEEA190E45317AEEE6F1506940CB8E943A1(L_5, ((int32_t)65535), ((int32_t)32), (bool)1, NULL);
		// peer.RawSend(arr, 0, arr.Length, new NetEndPoint(NetUtility.GetBroadcastAddress(), 1900));
		NetPeer_tDCD3AC5FB42BE47DEE7AEEA74F327C1E0D883542* L_6 = ___peer0;
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_7 = V_1;
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_8 = V_1;
		NullCheck(L_8);
		il2cpp_codegen_runtime_class_init_inline(NetUtility_t0B01E9514810CE3FC3B5E83D8427CBA1C5689EFD_il2cpp_TypeInfo_var);
		IPAddress_t2F4486449B0D73FF2D3B36A9FE5E9C3F63116484* L_9;
		L_9 = NetUtility_GetBroadcastAddress_m69CC4AFCA51DE14371F00A5A25170739B1496935(NULL);
		IPEndPoint_t2F09CBA7A808B67724B4E2954EEDC46D910F4ECB* L_10 = (IPEndPoint_t2F09CBA7A808B67724B4E2954EEDC46D910F4ECB*)il2cpp_codegen_object_new(IPEndPoint_t2F09CBA7A808B67724B4E2954EEDC46D910F4ECB_il2cpp_TypeInfo_var);
		IPEndPoint__ctor_m902C98F9E3F36B20B3C2E030AA91B62E2BC7A85A(L_10, L_9, ((int32_t)1900), /*hidden argument*/NULL);
		NullCheck(L_6);
		NetPeer_RawSend_mA47AFF8080A02D800CD75A6F6A85296A28225291(L_6, L_7, 0, ((int32_t)(((RuntimeArray*)L_8)->max_length)), L_10, NULL);
		// peer.Socket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.Broadcast, false);
		NetPeer_tDCD3AC5FB42BE47DEE7AEEA74F327C1E0D883542* L_11 = ___peer0;
		NullCheck(L_11);
		Socket_t1F49472CDA22B581C29A258225ABF3ADA9DED67E* L_12;
		L_12 = NetPeer_get_Socket_mCC49D19E418EEF9BCB8843C3475592AA8B6A2CC8_inline(L_11, NULL);
		NullCheck(L_12);
		Socket_SetSocketOption_mE47F5DEEA190E45317AEEE6F1506940CB8E943A1(L_12, ((int32_t)65535), ((int32_t)32), (bool)0, NULL);
		// }
		return;
	}
}
// System.Void Lidgren.Network.NetUPnP::CheckForDiscoveryTimeout()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void NetUPnP_CheckForDiscoveryTimeout_m5719180A78201CD67521D0DF7B92CC08C6EA91C8 (NetUPnP_tBDA843B6A55F8DBED04BF614EEAEDB1F256D86E8* __this, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&NetTime_tF7D62D28C9302513C9535DE2F9B41553B2548DE7_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
{
		// if ((m_status != UPnPStatus.Discovering) || (NetTime.Now < m_discoveryResponseDeadline))
		int32_t L_0 = __this->___m_status_6;
		if (L_0)
		{
			goto IL_0015;
		}
	}
	{
		il2cpp_codegen_runtime_class_init_inline(NetTime_tF7D62D28C9302513C9535DE2F9B41553B2548DE7_il2cpp_TypeInfo_var);
		double L_1;
		L_1 = NetTime_get_Now_mDDB364AF74A766A60E95E4799647B7EDD823EA96(NULL);
		double L_2 = __this->___m_discoveryResponseDeadline_5;
		if ((!(((double)L_1) < ((double)L_2))))
		{
			goto IL_0016;
		}
	}

IL_0015:
	{
		// return;
		return;
	}

IL_0016:
	{
		// m_status = UPnPStatus.NotAvailable;
		__this->___m_status_6 = 1;
		// }
		return;
	}
}
// System.Void Lidgren.Network.NetUPnP::ExtractServiceUrl(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void NetUPnP_ExtractServiceUrl_m64A495478F6737BD4415CF8FB2C622CF77FF2490 (NetUPnP_tBDA843B6A55F8DBED04BF614EEAEDB1F256D86E8* __this, String_t* ___resp0, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IDisposable_t030E0496B4E0E4E4F086825007979AF51F7248C5_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&WebRequest_t89050438AE9A5AA9221ECAE223584127F7C1294B_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&XmlDocument_t4DE82998E642C5C21A4A620A5278237C70D3E42B_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&XmlNamespaceManager_t95431ADE7A94108629DFF894819FB1A9709D810F_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral1B22BF18C56863E5B7EB7520B9741A85F61B6BC6);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral36A681C495A31FB315D7D4FE550319B4413084C2);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral40695C7AB1EB25BBB42D193B8DD12787571410BC);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral8F5312EFB7BCEA437BD477CADD56369CE463213B);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralBB90FA8EAC2B192B0155029DA99BED2806431413);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralDE4E77B5141B532F175AF1BD80D5F19B0F6A6C24);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralE03DC21A0CCF764B6DC5FB0D23ADB632409A427E);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralF0FEDFF01B5EC752DBD3BE0CD53AD377827EAB7F);
		s_Il2CppMethodInitialized = true;
	}
XmlDocument_t4DE82998E642C5C21A4A620A5278237C70D3E42B* V_0 = NULL;
	XmlNamespaceManager_t95431ADE7A94108629DFF894819FB1A9709D810F* V_1 = NULL;
	XmlNode_t3180B9B3D5C36CD58F5327D9F13458E3B3F030AF* V_2 = NULL;
	WebResponse_t7CDE1F20895C8D5AD392425F9AD4BE8E8696B682* V_3 = NULL;
	il2cpp::utils::ExceptionSupportStack<RuntimeObject*, 1> __active_exceptions;

IL_0000:
	try
	{// begin try (depth: 1)
		{
			// XmlDocument desc = new XmlDocument();
			XmlDocument_t4DE82998E642C5C21A4A620A5278237C70D3E42B* L_0 = (XmlDocument_t4DE82998E642C5C21A4A620A5278237C70D3E42B*)il2cpp_codegen_object_new(XmlDocument_t4DE82998E642C5C21A4A620A5278237C70D3E42B_il2cpp_TypeInfo_var);
			XmlDocument__ctor_m09B578D51E249702C90A99B87A31ABE8CE4027DC(L_0, /*hidden argument*/NULL);
			V_0 = L_0;
			// using (var response = WebRequest.Create(resp).GetResponse())
			String_t* L_1 = ___resp0;
			il2cpp_codegen_runtime_class_init_inline(WebRequest_t89050438AE9A5AA9221ECAE223584127F7C1294B_il2cpp_TypeInfo_var);
			WebRequest_t89050438AE9A5AA9221ECAE223584127F7C1294B* L_2;
			L_2 = WebRequest_Create_m18D598C169B53797E9B26A710442CAF2D786B04A(L_1, NULL);
			NullCheck(L_2);
			WebResponse_t7CDE1F20895C8D5AD392425F9AD4BE8E8696B682* L_3;
			L_3 = VirtualFuncInvoker0< WebResponse_t7CDE1F20895C8D5AD392425F9AD4BE8E8696B682* >::Invoke(23 /* System.Net.WebResponse System.Net.WebRequest::GetResponse() */, L_2);
			V_3 = L_3;
		}

IL_0012:
		{
			auto __finallyBlock = il2cpp::utils::Finally([&]
			{

FINALLY_0020:
				{// begin finally (depth: 2)
					{
						WebResponse_t7CDE1F20895C8D5AD392425F9AD4BE8E8696B682* L_4 = V_3;
						if (!L_4)
						{
							goto IL_0029;
						}
					}

IL_0023:
					{
						WebResponse_t7CDE1F20895C8D5AD392425F9AD4BE8E8696B682* L_5 = V_3;
						NullCheck(L_5);
						InterfaceActionInvoker0::Invoke(0 /* System.Void System.IDisposable::Dispose() */, IDisposable_t030E0496B4E0E4E4F086825007979AF51F7248C5_il2cpp_TypeInfo_var, L_5);
					}

IL_0029:
					{
						return;
					}
				}// end finally (depth: 2)
			});
			try
			{// begin try (depth: 2)
				// desc.Load(response.GetResponseStream());
				XmlDocument_t4DE82998E642C5C21A4A620A5278237C70D3E42B* L_6 = V_0;
				WebResponse_t7CDE1F20895C8D5AD392425F9AD4BE8E8696B682* L_7 = V_3;
				NullCheck(L_7);
				Stream_tF844051B786E8F7F4244DBD218D74E8617B9A2DE* L_8;
				L_8 = VirtualFuncInvoker0< Stream_tF844051B786E8F7F4244DBD218D74E8617B9A2DE* >::Invoke(12 /* System.IO.Stream System.Net.WebResponse::GetResponseStream() */, L_7);
				NullCheck(L_6);
				VirtualActionInvoker1< Stream_tF844051B786E8F7F4244DBD218D74E8617B9A2DE* >::Invoke(71 /* System.Void System.Xml.XmlDocument::Load(System.IO.Stream) */, L_6, L_8);
				goto IL_002a;
			}// end try (depth: 2)
			catch(Il2CppExceptionWrapper& e)
			{
				__finallyBlock.StoreException(e.ex);
			}
		}

IL_002a:
		{
			// XmlNamespaceManager nsMgr = new XmlNamespaceManager(desc.NameTable);
			XmlDocument_t4DE82998E642C5C21A4A620A5278237C70D3E42B* L_9 = V_0;
			NullCheck(L_9);
			XmlNameTable_tBDBAACFF3DB40A8E6AF3BDC11F0FF166CF11ABB8* L_10;
			L_10 = XmlDocument_get_NameTable_m4B913865A24AEA917172F75CBDCE94C81CCB7E2C(L_9, NULL);
			XmlNamespaceManager_t95431ADE7A94108629DFF894819FB1A9709D810F* L_11 = (XmlNamespaceManager_t95431ADE7A94108629DFF894819FB1A9709D810F*)il2cpp_codegen_object_new(XmlNamespaceManager_t95431ADE7A94108629DFF894819FB1A9709D810F_il2cpp_TypeInfo_var);
			XmlNamespaceManager__ctor_m18E69120CE5886E06630CCCC3215D2C67FC669DB(L_11, L_10, /*hidden argument*/NULL);
			V_1 = L_11;
			// nsMgr.AddNamespace("tns", "urn:schemas-upnp-org:device-1-0");
			XmlNamespaceManager_t95431ADE7A94108629DFF894819FB1A9709D810F* L_12 = V_1;
			NullCheck(L_12);
			VirtualActionInvoker2< String_t*, String_t* >::Invoke(12 /* System.Void System.Xml.XmlNamespaceManager::AddNamespace(System.String,System.String) */, L_12, _stringLiteral36A681C495A31FB315D7D4FE550319B4413084C2, _stringLiteralDE4E77B5141B532F175AF1BD80D5F19B0F6A6C24);
			// XmlNode typen = desc.SelectSingleNode("//tns:device/tns:deviceType/text()", nsMgr);
			XmlDocument_t4DE82998E642C5C21A4A620A5278237C70D3E42B* L_13 = V_0;
			XmlNamespaceManager_t95431ADE7A94108629DFF894819FB1A9709D810F* L_14 = V_1;
			NullCheck(L_13);
			XmlNode_t3180B9B3D5C36CD58F5327D9F13458E3B3F030AF* L_15;
			L_15 = XmlNode_SelectSingleNode_m39CC82217D76D54E61239FE67EF12020DD6E4748(L_13, _stringLiteral8F5312EFB7BCEA437BD477CADD56369CE463213B, L_14, NULL);
			// if (!typen.Value.Contains("InternetGatewayDevice"))
			NullCheck(L_15);
			String_t* L_16;
			L_16 = VirtualFuncInvoker0< String_t* >::Invoke(9 /* System.String System.Xml.XmlNode::get_Value() */, L_15);
			NullCheck(L_16);
			bool L_17;
			L_17 = String_Contains_m6D77B121FADA7CA5F397C0FABB65DA62DF03B6C3(L_16, _stringLiteralF0FEDFF01B5EC752DBD3BE0CD53AD377827EAB7F, NULL);
			if (L_17)
			{
				goto IL_0068;
			}
		}

IL_0063:
		{
			// return;
			goto IL_00ea;
		}

IL_0068:
		{
			// m_serviceName = "WANIPConnection";
			__this->___m_serviceName_2 = _stringLiteralE03DC21A0CCF764B6DC5FB0D23ADB632409A427E;
			Il2CppCodeGenWriteBarrier((void**)(&__this->___m_serviceName_2), (void*)_stringLiteralE03DC21A0CCF764B6DC5FB0D23ADB632409A427E);
			// XmlNode node = desc.SelectSingleNode("//tns:service[tns:serviceType=\"urn:schemas-upnp-org:service:" + m_serviceName + ":1\"]/tns:controlURL/text()", nsMgr);
			XmlDocument_t4DE82998E642C5C21A4A620A5278237C70D3E42B* L_18 = V_0;
			String_t* L_19 = __this->___m_serviceName_2;
			String_t* L_20;
			L_20 = String_Concat_m9B13B47FCB3DF61144D9647DDA05F527377251B0(_stringLiteral1B22BF18C56863E5B7EB7520B9741A85F61B6BC6, L_19, _stringLiteral40695C7AB1EB25BBB42D193B8DD12787571410BC, NULL);
			XmlNamespaceManager_t95431ADE7A94108629DFF894819FB1A9709D810F* L_21 = V_1;
			NullCheck(L_18);
			XmlNode_t3180B9B3D5C36CD58F5327D9F13458E3B3F030AF* L_22;
			L_22 = XmlNode_SelectSingleNode_m39CC82217D76D54E61239FE67EF12020DD6E4748(L_18, L_20, L_21, NULL);
			V_2 = L_22;
			// if (node == null)
			XmlNode_t3180B9B3D5C36CD58F5327D9F13458E3B3F030AF* L_23 = V_2;
			if (L_23)
			{
				goto IL_00c0;
			}
		}

IL_0093:
		{
			// m_serviceName = "WANPPPConnection";
			__this->___m_serviceName_2 = _stringLiteralBB90FA8EAC2B192B0155029DA99BED2806431413;
			Il2CppCodeGenWriteBarrier((void**)(&__this->___m_serviceName_2), (void*)_stringLiteralBB90FA8EAC2B192B0155029DA99BED2806431413);
			// node = desc.SelectSingleNode("//tns:service[tns:serviceType=\"urn:schemas-upnp-org:service:" + m_serviceName + ":1\"]/tns:controlURL/text()", nsMgr);
			XmlDocument_t4DE82998E642C5C21A4A620A5278237C70D3E42B* L_24 = V_0;
			String_t* L_25 = __this->___m_serviceName_2;
			String_t* L_26;
			L_26 = String_Concat_m9B13B47FCB3DF61144D9647DDA05F527377251B0(_stringLiteral1B22BF18C56863E5B7EB7520B9741A85F61B6BC6, L_25, _stringLiteral40695C7AB1EB25BBB42D193B8DD12787571410BC, NULL);
			XmlNamespaceManager_t95431ADE7A94108629DFF894819FB1A9709D810F* L_27 = V_1;
			NullCheck(L_24);
			XmlNode_t3180B9B3D5C36CD58F5327D9F13458E3B3F030AF* L_28;
			L_28 = XmlNode_SelectSingleNode_m39CC82217D76D54E61239FE67EF12020DD6E4748(L_24, L_26, L_27, NULL);
			V_2 = L_28;
			// if (node == null)
			XmlNode_t3180B9B3D5C36CD58F5327D9F13458E3B3F030AF* L_29 = V_2;
			if (L_29)
			{
				goto IL_00c0;
			}
		}

IL_00be:
		{
			// return;
			goto IL_00ea;
		}

IL_00c0:
		{
			// m_serviceUrl = CombineUrls(resp, node.Value);
			String_t* L_30 = ___resp0;
			XmlNode_t3180B9B3D5C36CD58F5327D9F13458E3B3F030AF* L_31 = V_2;
			NullCheck(L_31);
			String_t* L_32;
			L_32 = VirtualFuncInvoker0< String_t* >::Invoke(9 /* System.String System.Xml.XmlNode::get_Value() */, L_31);
			String_t* L_33;
			L_33 = NetUPnP_CombineUrls_m93BDC49B3DA9D2D9CBE30C10F101A712EEA67C2B(L_30, L_32, NULL);
			__this->___m_serviceUrl_1 = L_33;
			Il2CppCodeGenWriteBarrier((void**)(&__this->___m_serviceUrl_1), (void*)L_33);
			// m_status = UPnPStatus.Available;
			__this->___m_status_6 = 2;
			// m_discoveryComplete.Set();
			ManualResetEvent_t63959486AA41A113A4353D0BF4A68E77EBA0A158* L_34 = __this->___m_discoveryComplete_4;
			NullCheck(L_34);
			bool L_35;
			L_35 = EventWaitHandle_Set_mDF98D67F214714A9590DF82A1C51D3D851281E4D(L_34, NULL);
			// }
			goto IL_00ea;
		}
	}// end try (depth: 1)
	catch(Il2CppExceptionWrapper& e)
	{
		if(il2cpp_codegen_class_is_assignable_from (((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&RuntimeObject_il2cpp_TypeInfo_var)), il2cpp_codegen_object_class(e.ex)))
		{
			IL2CPP_PUSH_ACTIVE_EXCEPTION(e.ex);
			goto CATCH_00e7;
		}
		throw e;
	}

CATCH_00e7:
	{// begin catch(System.Object)
		// catch
		// return;
		IL2CPP_POP_ACTIVE_EXCEPTION();
		goto IL_00ea;
	}// end catch (depth: 1)

IL_00ea:
	{
		// }
		return;
	}
}
// System.String Lidgren.Network.NetUPnP::CombineUrls(System.String,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* NetUPnP_CombineUrls_m93BDC49B3DA9D2D9CBE30C10F101A712EEA67C2B (String_t* ___gatewayURL0, String_t* ___subURL1, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral3AE148F4539A6130C80EF45C5441F068ADBF8C8C);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral86BBAACC00198DBB3046818AD3FC2AA10AE48DE1);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralDA39A3EE5E6B4B0D3255BFEF95601890AFD80709);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralF3E84B722399601AD7E281754E917478AA9AD48D);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralFF7805784057B58BBD0371A720C775271F690CA2);
		s_Il2CppMethodInitialized = true;
	}
int32_t V_0 = 0;
	{
		// if ((subURL.Contains("http:")) || (subURL.Contains(".")))
		String_t* L_0 = ___subURL1;
		NullCheck(L_0);
		bool L_1;
		L_1 = String_Contains_m6D77B121FADA7CA5F397C0FABB65DA62DF03B6C3(L_0, _stringLiteralFF7805784057B58BBD0371A720C775271F690CA2, NULL);
		if (L_1)
		{
			goto IL_001a;
		}
	}
	{
		String_t* L_2 = ___subURL1;
		NullCheck(L_2);
		bool L_3;
		L_3 = String_Contains_m6D77B121FADA7CA5F397C0FABB65DA62DF03B6C3(L_2, _stringLiteralF3E84B722399601AD7E281754E917478AA9AD48D, NULL);
		if (!L_3)
		{
			goto IL_001c;
		}
	}

IL_001a:
	{
		// return subURL;
		String_t* L_4 = ___subURL1;
		return L_4;
	}

IL_001c:
	{
		// gatewayURL = gatewayURL.Replace("http://", "");  // strip any protocol
		String_t* L_5 = ___gatewayURL0;
		NullCheck(L_5);
		String_t* L_6;
		L_6 = String_Replace_mABDB7003A1D0AEDCAE9FF85E3DFFFBA752D2A166(L_5, _stringLiteral3AE148F4539A6130C80EF45C5441F068ADBF8C8C, _stringLiteralDA39A3EE5E6B4B0D3255BFEF95601890AFD80709, NULL);
		___gatewayURL0 = L_6;
		// int n = gatewayURL.IndexOf("/");
		String_t* L_7 = ___gatewayURL0;
		NullCheck(L_7);
		int32_t L_8;
		L_8 = String_IndexOf_m69E9BDAFD93767C85A7FF861B453415D3B4A200F(L_7, _stringLiteral86BBAACC00198DBB3046818AD3FC2AA10AE48DE1, NULL);
		V_0 = L_8;
		// if (n != -1)
		int32_t L_9 = V_0;
		if ((((int32_t)L_9) == ((int32_t)(-1))))
		{
			goto IL_0048;
		}
	}
	{
		// gatewayURL = gatewayURL.Substring(0, n);  // Use first portion of URL
		String_t* L_10 = ___gatewayURL0;
		int32_t L_11 = V_0;
		NullCheck(L_10);
		String_t* L_12;
		L_12 = String_Substring_mB1D94F47935D22E130FF2C01DBB6A4135FBB76CE(L_10, 0, L_11, NULL);
		___gatewayURL0 = L_12;
	}

IL_0048:
	{
		// return "http://" + gatewayURL + subURL;
		String_t* L_13 = ___gatewayURL0;
		String_t* L_14 = ___subURL1;
		String_t* L_15;
		L_15 = String_Concat_m9B13B47FCB3DF61144D9647DDA05F527377251B0(_stringLiteral3AE148F4539A6130C80EF45C5441F068ADBF8C8C, L_13, L_14, NULL);
		return L_15;
	}
}
// System.Boolean Lidgren.Network.NetUPnP::CheckAvailability()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool NetUPnP_CheckAvailability_mBEDEC3186DE0A37A66CD5B71C08A374CED65C1F0 (NetUPnP_tBDA843B6A55F8DBED04BF614EEAEDB1F256D86E8* __this, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&NetTime_tF7D62D28C9302513C9535DE2F9B41553B2548DE7_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
int32_t V_0 = 0;
	{
		// switch (m_status)
		int32_t L_0 = __this->___m_status_6;
		V_0 = L_0;
		int32_t L_1 = V_0;
		switch (L_1)
		{
			case 0:
			{
				goto IL_001f;
			}
			case 1:
			{
				goto IL_001b;
			}
			case 2:
			{
				goto IL_001d;
			}
		}
	}
	{
		goto IL_0049;
	}

IL_001b:
	{
		// return false;
		return (bool)0;
	}

IL_001d:
	{
		// return true;
		return (bool)1;
	}

IL_001f:
	{
		// if (m_discoveryComplete.WaitOne(c_discoveryTimeOutMillis))
		ManualResetEvent_t63959486AA41A113A4353D0BF4A68E77EBA0A158* L_2 = __this->___m_discoveryComplete_4;
		NullCheck(L_2);
		bool L_3;
		L_3 = VirtualFuncInvoker1< bool, int32_t >::Invoke(12 /* System.Boolean System.Threading.WaitHandle::WaitOne(System.Int32) */, L_2, ((int32_t)1000));
		if (!L_3)
		{
			goto IL_0033;
		}
	}
	{
		// return true;
		return (bool)1;
	}

IL_0033:
	{
		// if (NetTime.Now > m_discoveryResponseDeadline)
		il2cpp_codegen_runtime_class_init_inline(NetTime_tF7D62D28C9302513C9535DE2F9B41553B2548DE7_il2cpp_TypeInfo_var);
		double L_4;
		L_4 = NetTime_get_Now_mDDB364AF74A766A60E95E4799647B7EDD823EA96(NULL);
		double L_5 = __this->___m_discoveryResponseDeadline_5;
		if ((!(((double)L_4) > ((double)L_5))))
		{
			goto IL_0047;
		}
	}
	{
		// m_status = UPnPStatus.NotAvailable;
		__this->___m_status_6 = 1;
	}

IL_0047:
	{
		// return false;
		return (bool)0;
	}

IL_0049:
	{
		// return false;
		return (bool)0;
	}
}
// System.Boolean Lidgren.Network.NetUPnP::ForwardPort(System.Int32,System.String,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool NetUPnP_ForwardPort_m3B449043DD117F8C01C810CB4414ACDBF83B57BF (NetUPnP_tBDA843B6A55F8DBED04BF614EEAEDB1F256D86E8* __this, int32_t ___externalPort0, String_t* ___description1, int32_t ___internalPort2, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&CultureInfo_t9BA817D41AD55AC8BD07480DD8AC22F8FFA378E0_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&NetUtility_t0B01E9514810CE3FC3B5E83D8427CBA1C5689EFD_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ProtocolType_t104D087F8C40460E0FE8D38659949AEA910CD20A_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral0DBE744A44DDF9503B87CCBF0390BB7C764CB0ED);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral1AD0CE271AA2DFAD431E2FC69D0587B6C1CAFA18);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral3AFB31AEFC546297555B36EF940F37C1ADCCC7CA);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral3D0EA11AB4A233A3D304D0CF23569AB865DDE70F);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral52EBA66B2A9CA363162F4B34A1E22C620301D799);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral92CB236B774CCCCF0E79BFC374F88CD76084EE69);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral9B16626643AD985A74711905C5E491E882840AC2);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralB1037556B1B0A0647BA76414559E0C28B2D7DD16);
		s_Il2CppMethodInitialized = true;
	}
IPAddress_t2F4486449B0D73FF2D3B36A9FE5E9C3F63116484* V_0 = NULL;
	IPAddress_t2F4486449B0D73FF2D3B36A9FE5E9C3F63116484* V_1 = NULL;
	int32_t V_2 = 0;
	Exception_t* V_3 = NULL;
	bool V_4 = false;
	il2cpp::utils::ExceptionSupportStack<RuntimeObject*, 1> __active_exceptions;
	{
		// if (!CheckAvailability())
		bool L_0;
		L_0 = NetUPnP_CheckAvailability_mBEDEC3186DE0A37A66CD5B71C08A374CED65C1F0(__this, NULL);
		if (L_0)
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
		// var client = NetUtility.GetMyAddress(out mask);
		il2cpp_codegen_runtime_class_init_inline(NetUtility_t0B01E9514810CE3FC3B5E83D8427CBA1C5689EFD_il2cpp_TypeInfo_var);
		IPAddress_t2F4486449B0D73FF2D3B36A9FE5E9C3F63116484* L_1;
		L_1 = NetUtility_GetMyAddress_m3051AD9EA9B97026C0AD93C606B39B247759AD85((&V_0), NULL);
		V_1 = L_1;
		// if (client == null)
		IPAddress_t2F4486449B0D73FF2D3B36A9FE5E9C3F63116484* L_2 = V_1;
		if (L_2)
		{
			goto IL_0017;
		}
	}
	{
		// return false;
		return (bool)0;
	}

IL_0017:
	{
		// if (internalPort == 0)
		int32_t L_3 = ___internalPort2;
		if (L_3)
		{
			goto IL_001d;
		}
	}
	{
		// internalPort = externalPort;
		int32_t L_4 = ___externalPort0;
		___internalPort2 = L_4;
	}

IL_001d:
	{
	}

IL_001e:
	try
	{// begin try (depth: 1)
		// SOAPRequest(m_serviceUrl,
		//     "<u:AddPortMapping xmlns:u=\"urn:schemas-upnp-org:service:" + m_serviceName + ":1\">" +
		//     "<NewRemoteHost></NewRemoteHost>" +
		//     "<NewExternalPort>" + externalPort.ToString() + "</NewExternalPort>" +
		//     "<NewProtocol>" + ProtocolType.Udp.ToString().ToUpper(System.Globalization.CultureInfo.InvariantCulture) + "</NewProtocol>" +
		//     "<NewInternalPort>" + internalPort.ToString() + "</NewInternalPort>" +
		//     "<NewInternalClient>" + client.ToString() + "</NewInternalClient>" +
		//     "<NewEnabled>1</NewEnabled>" +
		//     "<NewPortMappingDescription>" + description + "</NewPortMappingDescription>" +
		//     "<NewLeaseDuration>0</NewLeaseDuration>" +
		//     "</u:AddPortMapping>",
		//     "AddPortMapping");
		String_t* L_5 = __this->___m_serviceUrl_1;
		StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248* L_6 = (StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248*)(StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248*)SZArrayNew(StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248_il2cpp_TypeInfo_var, (uint32_t)((int32_t)13));
		StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248* L_7 = L_6;
		NullCheck(L_7);
		ArrayElementTypeCheck (L_7, _stringLiteral52EBA66B2A9CA363162F4B34A1E22C620301D799);
		(L_7)->SetAt(static_cast<il2cpp_array_size_t>(0), (String_t*)_stringLiteral52EBA66B2A9CA363162F4B34A1E22C620301D799);
		StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248* L_8 = L_7;
		String_t* L_9 = __this->___m_serviceName_2;
		NullCheck(L_8);
		ArrayElementTypeCheck (L_8, L_9);
		(L_8)->SetAt(static_cast<il2cpp_array_size_t>(1), (String_t*)L_9);
		StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248* L_10 = L_8;
		NullCheck(L_10);
		ArrayElementTypeCheck (L_10, _stringLiteral1AD0CE271AA2DFAD431E2FC69D0587B6C1CAFA18);
		(L_10)->SetAt(static_cast<il2cpp_array_size_t>(2), (String_t*)_stringLiteral1AD0CE271AA2DFAD431E2FC69D0587B6C1CAFA18);
		StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248* L_11 = L_10;
		String_t* L_12;
		L_12 = Int32_ToString_m030E01C24E294D6762FB0B6F37CB541581F55CA5((&___externalPort0), NULL);
		NullCheck(L_11);
		ArrayElementTypeCheck (L_11, L_12);
		(L_11)->SetAt(static_cast<il2cpp_array_size_t>(3), (String_t*)L_12);
		StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248* L_13 = L_11;
		NullCheck(L_13);
		ArrayElementTypeCheck (L_13, _stringLiteral3AFB31AEFC546297555B36EF940F37C1ADCCC7CA);
		(L_13)->SetAt(static_cast<il2cpp_array_size_t>(4), (String_t*)_stringLiteral3AFB31AEFC546297555B36EF940F37C1ADCCC7CA);
		StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248* L_14 = L_13;
		V_2 = ((int32_t)17);
		Il2CppFakeBox<int32_t> L_15(ProtocolType_t104D087F8C40460E0FE8D38659949AEA910CD20A_il2cpp_TypeInfo_var, (&V_2));
		String_t* L_16;
		L_16 = Enum_ToString_m946B0B83C4470457D0FF555D862022C72BB55741((Enum_t2A1A94B24E3B776EEF4E5E485E290BB9D4D072E2*)(&L_15), NULL);
		il2cpp_codegen_runtime_class_init_inline(CultureInfo_t9BA817D41AD55AC8BD07480DD8AC22F8FFA378E0_il2cpp_TypeInfo_var);
		CultureInfo_t9BA817D41AD55AC8BD07480DD8AC22F8FFA378E0* L_17;
		L_17 = CultureInfo_get_InvariantCulture_m78DAB8CBE8766445310782B6E61FB7A9983AD425(NULL);
		NullCheck(L_16);
		String_t* L_18;
		L_18 = String_ToUpper_mFC5C17C8BFF52540CC7A73E36DFC9617281325D1(L_16, L_17, NULL);
		NullCheck(L_14);
		ArrayElementTypeCheck (L_14, L_18);
		(L_14)->SetAt(static_cast<il2cpp_array_size_t>(5), (String_t*)L_18);
		StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248* L_19 = L_14;
		NullCheck(L_19);
		ArrayElementTypeCheck (L_19, _stringLiteral92CB236B774CCCCF0E79BFC374F88CD76084EE69);
		(L_19)->SetAt(static_cast<il2cpp_array_size_t>(6), (String_t*)_stringLiteral92CB236B774CCCCF0E79BFC374F88CD76084EE69);
		StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248* L_20 = L_19;
		String_t* L_21;
		L_21 = Int32_ToString_m030E01C24E294D6762FB0B6F37CB541581F55CA5((&___internalPort2), NULL);
		NullCheck(L_20);
		ArrayElementTypeCheck (L_20, L_21);
		(L_20)->SetAt(static_cast<il2cpp_array_size_t>(7), (String_t*)L_21);
		StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248* L_22 = L_20;
		NullCheck(L_22);
		ArrayElementTypeCheck (L_22, _stringLiteral9B16626643AD985A74711905C5E491E882840AC2);
		(L_22)->SetAt(static_cast<il2cpp_array_size_t>(8), (String_t*)_stringLiteral9B16626643AD985A74711905C5E491E882840AC2);
		StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248* L_23 = L_22;
		IPAddress_t2F4486449B0D73FF2D3B36A9FE5E9C3F63116484* L_24 = V_1;
		NullCheck(L_24);
		String_t* L_25;
		L_25 = VirtualFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, L_24);
		NullCheck(L_23);
		ArrayElementTypeCheck (L_23, L_25);
		(L_23)->SetAt(static_cast<il2cpp_array_size_t>(((int32_t)9)), (String_t*)L_25);
		StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248* L_26 = L_23;
		NullCheck(L_26);
		ArrayElementTypeCheck (L_26, _stringLiteralB1037556B1B0A0647BA76414559E0C28B2D7DD16);
		(L_26)->SetAt(static_cast<il2cpp_array_size_t>(((int32_t)10)), (String_t*)_stringLiteralB1037556B1B0A0647BA76414559E0C28B2D7DD16);
		StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248* L_27 = L_26;
		String_t* L_28 = ___description1;
		NullCheck(L_27);
		ArrayElementTypeCheck (L_27, L_28);
		(L_27)->SetAt(static_cast<il2cpp_array_size_t>(((int32_t)11)), (String_t*)L_28);
		StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248* L_29 = L_27;
		NullCheck(L_29);
		ArrayElementTypeCheck (L_29, _stringLiteral3D0EA11AB4A233A3D304D0CF23569AB865DDE70F);
		(L_29)->SetAt(static_cast<il2cpp_array_size_t>(((int32_t)12)), (String_t*)_stringLiteral3D0EA11AB4A233A3D304D0CF23569AB865DDE70F);
		String_t* L_30;
		L_30 = String_Concat_m6B0734B65813C8EA093D78E5C2D16534EB6FE8C0(L_29, NULL);
		XmlDocument_t4DE82998E642C5C21A4A620A5278237C70D3E42B* L_31;
		L_31 = NetUPnP_SOAPRequest_mFE3B08BAF839443A36A3333A539E3E0DB05AE145(__this, L_5, L_30, _stringLiteral0DBE744A44DDF9503B87CCBF0390BB7C764CB0ED, NULL);
		// NetUtility.Sleep(50);
		il2cpp_codegen_runtime_class_init_inline(NetUtility_t0B01E9514810CE3FC3B5E83D8427CBA1C5689EFD_il2cpp_TypeInfo_var);
		NetUtility_Sleep_m51A7652D14F726B5D3EEF64C78C50EFD798303CD(((int32_t)50), NULL);
		// }
		goto IL_00e9;
	}// end try (depth: 1)
	catch(Il2CppExceptionWrapper& e)
	{
		if(il2cpp_codegen_class_is_assignable_from (((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&Exception_t_il2cpp_TypeInfo_var)), il2cpp_codegen_object_class(e.ex)))
		{
			IL2CPP_PUSH_ACTIVE_EXCEPTION(e.ex);
			goto CATCH_00c8;
		}
		throw e;
	}

CATCH_00c8:
	{// begin catch(System.Exception)
		// catch (Exception ex)
		V_3 = ((Exception_t*)IL2CPP_GET_ACTIVE_EXCEPTION(Exception_t*));
		// m_peer.LogWarning("UPnP port forward failed: " + ex.Message);
		NetPeer_tDCD3AC5FB42BE47DEE7AEEA74F327C1E0D883542* L_32 = __this->___m_peer_3;
		Exception_t* L_33 = V_3;
		NullCheck(L_33);
		String_t* L_34;
		L_34 = VirtualFuncInvoker0< String_t* >::Invoke(5 /* System.String System.Exception::get_Message() */, L_33);
		String_t* L_35;
		L_35 = String_Concat_mAF2CE02CC0CB7460753D0A1A91CCF2B1E9804C5D(((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteralF822C1F6D3A5E12491A8E4E81D846C56CEC9DA65)), L_34, NULL);
		NullCheck(L_32);
		NetPeer_LogWarning_m2192971F3DF4443EDFCB1A4199897520163F227C(L_32, L_35, NULL);
		// return false;
		V_4 = (bool)0;
		IL2CPP_POP_ACTIVE_EXCEPTION();
		goto IL_00eb;
	}// end catch (depth: 1)

IL_00e9:
	{
		// return true;
		return (bool)1;
	}

IL_00eb:
	{
		// }
		bool L_36 = V_4;
		return L_36;
	}
}
// System.Boolean Lidgren.Network.NetUPnP::DeleteForwardingRule(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool NetUPnP_DeleteForwardingRule_mEF0C6DA9B40D6878A2FF031B7D241E1259B448E4 (NetUPnP_tBDA843B6A55F8DBED04BF614EEAEDB1F256D86E8* __this, int32_t ___externalPort0, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&CultureInfo_t9BA817D41AD55AC8BD07480DD8AC22F8FFA378E0_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ProtocolType_t104D087F8C40460E0FE8D38659949AEA910CD20A_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral1AD0CE271AA2DFAD431E2FC69D0587B6C1CAFA18);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral3930A1937087B284E8C5AADF61F618FF4786362A);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral3AFB31AEFC546297555B36EF940F37C1ADCCC7CA);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral6A9C16890A6DC07573195A8A76F9E8CFF701C48B);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralACDB66C1A5ADC16347A6D0A2A0870CACE5E78073);
		s_Il2CppMethodInitialized = true;
	}
int32_t V_0 = 0;
	bool V_1 = false;
	Exception_t* V_2 = NULL;
	il2cpp::utils::ExceptionSupportStack<RuntimeObject*, 1> __active_exceptions;
	{
		// if (!CheckAvailability())
		bool L_0;
		L_0 = NetUPnP_CheckAvailability_mBEDEC3186DE0A37A66CD5B71C08A374CED65C1F0(__this, NULL);
		if (L_0)
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
	}

IL_000b:
	try
	{// begin try (depth: 1)
		// SOAPRequest(m_serviceUrl,
		// "<u:DeletePortMapping xmlns:u=\"urn:schemas-upnp-org:service:" + m_serviceName + ":1\">" +
		// "<NewRemoteHost>" +
		// "</NewRemoteHost>" +
		// "<NewExternalPort>" + externalPort + "</NewExternalPort>" +
		// "<NewProtocol>" + ProtocolType.Udp.ToString().ToUpper(System.Globalization.CultureInfo.InvariantCulture) + "</NewProtocol>" +
		// "</u:DeletePortMapping>", "DeletePortMapping");
		String_t* L_1 = __this->___m_serviceUrl_1;
		StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248* L_2 = (StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248*)(StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248*)SZArrayNew(StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248_il2cpp_TypeInfo_var, (uint32_t)7);
		StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248* L_3 = L_2;
		NullCheck(L_3);
		ArrayElementTypeCheck (L_3, _stringLiteralACDB66C1A5ADC16347A6D0A2A0870CACE5E78073);
		(L_3)->SetAt(static_cast<il2cpp_array_size_t>(0), (String_t*)_stringLiteralACDB66C1A5ADC16347A6D0A2A0870CACE5E78073);
		StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248* L_4 = L_3;
		String_t* L_5 = __this->___m_serviceName_2;
		NullCheck(L_4);
		ArrayElementTypeCheck (L_4, L_5);
		(L_4)->SetAt(static_cast<il2cpp_array_size_t>(1), (String_t*)L_5);
		StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248* L_6 = L_4;
		NullCheck(L_6);
		ArrayElementTypeCheck (L_6, _stringLiteral1AD0CE271AA2DFAD431E2FC69D0587B6C1CAFA18);
		(L_6)->SetAt(static_cast<il2cpp_array_size_t>(2), (String_t*)_stringLiteral1AD0CE271AA2DFAD431E2FC69D0587B6C1CAFA18);
		StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248* L_7 = L_6;
		String_t* L_8;
		L_8 = Int32_ToString_m030E01C24E294D6762FB0B6F37CB541581F55CA5((&___externalPort0), NULL);
		NullCheck(L_7);
		ArrayElementTypeCheck (L_7, L_8);
		(L_7)->SetAt(static_cast<il2cpp_array_size_t>(3), (String_t*)L_8);
		StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248* L_9 = L_7;
		NullCheck(L_9);
		ArrayElementTypeCheck (L_9, _stringLiteral3AFB31AEFC546297555B36EF940F37C1ADCCC7CA);
		(L_9)->SetAt(static_cast<il2cpp_array_size_t>(4), (String_t*)_stringLiteral3AFB31AEFC546297555B36EF940F37C1ADCCC7CA);
		StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248* L_10 = L_9;
		V_0 = ((int32_t)17);
		Il2CppFakeBox<int32_t> L_11(ProtocolType_t104D087F8C40460E0FE8D38659949AEA910CD20A_il2cpp_TypeInfo_var, (&V_0));
		String_t* L_12;
		L_12 = Enum_ToString_m946B0B83C4470457D0FF555D862022C72BB55741((Enum_t2A1A94B24E3B776EEF4E5E485E290BB9D4D072E2*)(&L_11), NULL);
		il2cpp_codegen_runtime_class_init_inline(CultureInfo_t9BA817D41AD55AC8BD07480DD8AC22F8FFA378E0_il2cpp_TypeInfo_var);
		CultureInfo_t9BA817D41AD55AC8BD07480DD8AC22F8FFA378E0* L_13;
		L_13 = CultureInfo_get_InvariantCulture_m78DAB8CBE8766445310782B6E61FB7A9983AD425(NULL);
		NullCheck(L_12);
		String_t* L_14;
		L_14 = String_ToUpper_mFC5C17C8BFF52540CC7A73E36DFC9617281325D1(L_12, L_13, NULL);
		NullCheck(L_10);
		ArrayElementTypeCheck (L_10, L_14);
		(L_10)->SetAt(static_cast<il2cpp_array_size_t>(5), (String_t*)L_14);
		StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248* L_15 = L_10;
		NullCheck(L_15);
		ArrayElementTypeCheck (L_15, _stringLiteral6A9C16890A6DC07573195A8A76F9E8CFF701C48B);
		(L_15)->SetAt(static_cast<il2cpp_array_size_t>(6), (String_t*)_stringLiteral6A9C16890A6DC07573195A8A76F9E8CFF701C48B);
		String_t* L_16;
		L_16 = String_Concat_m6B0734B65813C8EA093D78E5C2D16534EB6FE8C0(L_15, NULL);
		XmlDocument_t4DE82998E642C5C21A4A620A5278237C70D3E42B* L_17;
		L_17 = NetUPnP_SOAPRequest_mFE3B08BAF839443A36A3333A539E3E0DB05AE145(__this, L_1, L_16, _stringLiteral3930A1937087B284E8C5AADF61F618FF4786362A, NULL);
		// return true;
		V_1 = (bool)1;
		goto IL_009c;
	}// end try (depth: 1)
	catch(Il2CppExceptionWrapper& e)
	{
		if(il2cpp_codegen_class_is_assignable_from (((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&Exception_t_il2cpp_TypeInfo_var)), il2cpp_codegen_object_class(e.ex)))
		{
			IL2CPP_PUSH_ACTIVE_EXCEPTION(e.ex);
			goto CATCH_007c;
		}
		throw e;
	}

CATCH_007c:
	{// begin catch(System.Exception)
		// catch (Exception ex)
		V_2 = ((Exception_t*)IL2CPP_GET_ACTIVE_EXCEPTION(Exception_t*));
		// m_peer.LogWarning("UPnP delete forwarding rule failed: " + ex.Message);
		NetPeer_tDCD3AC5FB42BE47DEE7AEEA74F327C1E0D883542* L_18 = __this->___m_peer_3;
		Exception_t* L_19 = V_2;
		NullCheck(L_19);
		String_t* L_20;
		L_20 = VirtualFuncInvoker0< String_t* >::Invoke(5 /* System.String System.Exception::get_Message() */, L_19);
		String_t* L_21;
		L_21 = String_Concat_mAF2CE02CC0CB7460753D0A1A91CCF2B1E9804C5D(((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteral78F7AFA5D1330C70AD3BBBEB7F8766F2C4D9E603)), L_20, NULL);
		NullCheck(L_18);
		NetPeer_LogWarning_m2192971F3DF4443EDFCB1A4199897520163F227C(L_18, L_21, NULL);
		// return false;
		V_1 = (bool)0;
		IL2CPP_POP_ACTIVE_EXCEPTION();
		goto IL_009c;
	}// end catch (depth: 1)

IL_009c:
	{
		// }
		bool L_22 = V_1;
		return L_22;
	}
}
// System.Net.IPAddress Lidgren.Network.NetUPnP::GetExternalIP()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR IPAddress_t2F4486449B0D73FF2D3B36A9FE5E9C3F63116484* NetUPnP_GetExternalIP_mE48D54DA18A7DEB88D3B82BE7F592C185AC10745 (NetUPnP_tBDA843B6A55F8DBED04BF614EEAEDB1F256D86E8* __this, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IPAddress_t2F4486449B0D73FF2D3B36A9FE5E9C3F63116484_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&XmlNamespaceManager_t95431ADE7A94108629DFF894819FB1A9709D810F_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral08A267223F99ED7C786E1899CC41C2D0CAEE5774);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral2EA39FD1A6510BEA527E847A17EE16B182F1A174);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral36A681C495A31FB315D7D4FE550319B4413084C2);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral9874DEA2D36B50B6344F39E1E4852E1B8D35BC08);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralCEC24757C254A874F3A0F3564E4D6967511B49A0);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralDE4E77B5141B532F175AF1BD80D5F19B0F6A6C24);
		s_Il2CppMethodInitialized = true;
	}
XmlNamespaceManager_t95431ADE7A94108629DFF894819FB1A9709D810F* V_0 = NULL;
	IPAddress_t2F4486449B0D73FF2D3B36A9FE5E9C3F63116484* V_1 = NULL;
	Exception_t* V_2 = NULL;
	il2cpp::utils::ExceptionSupportStack<RuntimeObject*, 1> __active_exceptions;
	{
		// if (!CheckAvailability())
		bool L_0;
		L_0 = NetUPnP_CheckAvailability_mBEDEC3186DE0A37A66CD5B71C08A374CED65C1F0(__this, NULL);
		if (L_0)
		{
			goto IL_000a;
		}
	}
	{
		// return null;
		return (IPAddress_t2F4486449B0D73FF2D3B36A9FE5E9C3F63116484*)NULL;
	}

IL_000a:
	{
	}

IL_000b:
	try
	{// begin try (depth: 1)
		// XmlDocument xdoc = SOAPRequest(m_serviceUrl, "<u:GetExternalIPAddress xmlns:u=\"urn:schemas-upnp-org:service:" + m_serviceName + ":1\">" +
		// "</u:GetExternalIPAddress>", "GetExternalIPAddress");
		String_t* L_1 = __this->___m_serviceUrl_1;
		String_t* L_2 = __this->___m_serviceName_2;
		String_t* L_3;
		L_3 = String_Concat_m9B13B47FCB3DF61144D9647DDA05F527377251B0(_stringLiteral2EA39FD1A6510BEA527E847A17EE16B182F1A174, L_2, _stringLiteralCEC24757C254A874F3A0F3564E4D6967511B49A0, NULL);
		XmlDocument_t4DE82998E642C5C21A4A620A5278237C70D3E42B* L_4;
		L_4 = NetUPnP_SOAPRequest_mFE3B08BAF839443A36A3333A539E3E0DB05AE145(__this, L_1, L_3, _stringLiteral08A267223F99ED7C786E1899CC41C2D0CAEE5774, NULL);
		// XmlNamespaceManager nsMgr = new XmlNamespaceManager(xdoc.NameTable);
		XmlDocument_t4DE82998E642C5C21A4A620A5278237C70D3E42B* L_5 = L_4;
		NullCheck(L_5);
		XmlNameTable_tBDBAACFF3DB40A8E6AF3BDC11F0FF166CF11ABB8* L_6;
		L_6 = XmlDocument_get_NameTable_m4B913865A24AEA917172F75CBDCE94C81CCB7E2C(L_5, NULL);
		XmlNamespaceManager_t95431ADE7A94108629DFF894819FB1A9709D810F* L_7 = (XmlNamespaceManager_t95431ADE7A94108629DFF894819FB1A9709D810F*)il2cpp_codegen_object_new(XmlNamespaceManager_t95431ADE7A94108629DFF894819FB1A9709D810F_il2cpp_TypeInfo_var);
		XmlNamespaceManager__ctor_m18E69120CE5886E06630CCCC3215D2C67FC669DB(L_7, L_6, /*hidden argument*/NULL);
		V_0 = L_7;
		// nsMgr.AddNamespace("tns", "urn:schemas-upnp-org:device-1-0");
		XmlNamespaceManager_t95431ADE7A94108629DFF894819FB1A9709D810F* L_8 = V_0;
		NullCheck(L_8);
		VirtualActionInvoker2< String_t*, String_t* >::Invoke(12 /* System.Void System.Xml.XmlNamespaceManager::AddNamespace(System.String,System.String) */, L_8, _stringLiteral36A681C495A31FB315D7D4FE550319B4413084C2, _stringLiteralDE4E77B5141B532F175AF1BD80D5F19B0F6A6C24);
		// string IP = xdoc.SelectSingleNode("//NewExternalIPAddress/text()", nsMgr).Value;
		XmlNamespaceManager_t95431ADE7A94108629DFF894819FB1A9709D810F* L_9 = V_0;
		NullCheck(L_5);
		XmlNode_t3180B9B3D5C36CD58F5327D9F13458E3B3F030AF* L_10;
		L_10 = XmlNode_SelectSingleNode_m39CC82217D76D54E61239FE67EF12020DD6E4748(L_5, _stringLiteral9874DEA2D36B50B6344F39E1E4852E1B8D35BC08, L_9, NULL);
		NullCheck(L_10);
		String_t* L_11;
		L_11 = VirtualFuncInvoker0< String_t* >::Invoke(9 /* System.String System.Xml.XmlNode::get_Value() */, L_10);
		// return IPAddress.Parse(IP);
		il2cpp_codegen_runtime_class_init_inline(IPAddress_t2F4486449B0D73FF2D3B36A9FE5E9C3F63116484_il2cpp_TypeInfo_var);
		IPAddress_t2F4486449B0D73FF2D3B36A9FE5E9C3F63116484* L_12;
		L_12 = IPAddress_Parse_mD7BEF4D6060D8BE776F559C5F81F195A9917CF1C(L_11, NULL);
		V_1 = L_12;
		goto IL_0085;
	}// end try (depth: 1)
	catch(Il2CppExceptionWrapper& e)
	{
		if(il2cpp_codegen_class_is_assignable_from (((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&Exception_t_il2cpp_TypeInfo_var)), il2cpp_codegen_object_class(e.ex)))
		{
			IL2CPP_PUSH_ACTIVE_EXCEPTION(e.ex);
			goto CATCH_0065;
		}
		throw e;
	}

CATCH_0065:
	{// begin catch(System.Exception)
		// catch (Exception ex)
		V_2 = ((Exception_t*)IL2CPP_GET_ACTIVE_EXCEPTION(Exception_t*));
		// m_peer.LogWarning("Failed to get external IP: " + ex.Message);
		NetPeer_tDCD3AC5FB42BE47DEE7AEEA74F327C1E0D883542* L_13 = __this->___m_peer_3;
		Exception_t* L_14 = V_2;
		NullCheck(L_14);
		String_t* L_15;
		L_15 = VirtualFuncInvoker0< String_t* >::Invoke(5 /* System.String System.Exception::get_Message() */, L_14);
		String_t* L_16;
		L_16 = String_Concat_mAF2CE02CC0CB7460753D0A1A91CCF2B1E9804C5D(((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteralBCE589EF40970A3617C61809C44D0ACCD7EFDCDA)), L_15, NULL);
		NullCheck(L_13);
		NetPeer_LogWarning_m2192971F3DF4443EDFCB1A4199897520163F227C(L_13, L_16, NULL);
		// return null;
		V_1 = (IPAddress_t2F4486449B0D73FF2D3B36A9FE5E9C3F63116484*)NULL;
		IL2CPP_POP_ACTIVE_EXCEPTION();
		goto IL_0085;
	}// end catch (depth: 1)

IL_0085:
	{
		// }
		IPAddress_t2F4486449B0D73FF2D3B36A9FE5E9C3F63116484* L_17 = V_1;
		return L_17;
	}
}
// System.Xml.XmlDocument Lidgren.Network.NetUPnP::SOAPRequest(System.String,System.String,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR XmlDocument_t4DE82998E642C5C21A4A620A5278237C70D3E42B* NetUPnP_SOAPRequest_mFE3B08BAF839443A36A3333A539E3E0DB05AE145 (NetUPnP_tBDA843B6A55F8DBED04BF614EEAEDB1F256D86E8* __this, String_t* ___url0, String_t* ___soap1, String_t* ___function2, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IDisposable_t030E0496B4E0E4E4F086825007979AF51F7248C5_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&WebRequest_t89050438AE9A5AA9221ECAE223584127F7C1294B_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&XmlDocument_t4DE82998E642C5C21A4A620A5278237C70D3E42B_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral08D30F14509C8365E327175A5D6557EFD61BA45C);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral14E338D17C42E552FA7AF42CDAE40CA1F0E8A04D);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral293FD0A62157C0798F2DBF19E2A112B2F32964A6);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral2A04459105AE2163347709664ECD535E3E105DF5);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralB6820E3EE92F6889A3D523074454DC3D1830FF96);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralC62C64F00567C5368CAE37F4E64E1E82FF785677);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralD780C0360D4AE4D11F08385D4437D757F04827FA);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralE935C3A9AABA7F6F869D63A22759322AA75593AD);
		s_Il2CppMethodInitialized = true;
	}
String_t* V_0 = NULL;
	WebRequest_t89050438AE9A5AA9221ECAE223584127F7C1294B* V_1 = NULL;
	ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* V_2 = NULL;
	WebResponse_t7CDE1F20895C8D5AD392425F9AD4BE8E8696B682* V_3 = NULL;
	Stream_tF844051B786E8F7F4244DBD218D74E8617B9A2DE* V_4 = NULL;
	XmlDocument_t4DE82998E642C5C21A4A620A5278237C70D3E42B* V_5 = NULL;
	{
		// string req = "<?xml version=\"1.0\"?>" +
		// "<s:Envelope xmlns:s=\"http://schemas.xmlsoap.org/soap/envelope/\" s:encodingStyle=\"http://schemas.xmlsoap.org/soap/encoding/\">" +
		// "<s:Body>" +
		// soap +
		// "</s:Body>" +
		// "</s:Envelope>";
		String_t* L_0 = ___soap1;
		String_t* L_1;
		L_1 = String_Concat_m9B13B47FCB3DF61144D9647DDA05F527377251B0(_stringLiteralB6820E3EE92F6889A3D523074454DC3D1830FF96, L_0, _stringLiteralE935C3A9AABA7F6F869D63A22759322AA75593AD, NULL);
		V_0 = L_1;
		// WebRequest r = HttpWebRequest.Create(url);
		String_t* L_2 = ___url0;
		il2cpp_codegen_runtime_class_init_inline(WebRequest_t89050438AE9A5AA9221ECAE223584127F7C1294B_il2cpp_TypeInfo_var);
		WebRequest_t89050438AE9A5AA9221ECAE223584127F7C1294B* L_3;
		L_3 = WebRequest_Create_m18D598C169B53797E9B26A710442CAF2D786B04A(L_2, NULL);
		V_1 = L_3;
		// r.Method = "POST";
		WebRequest_t89050438AE9A5AA9221ECAE223584127F7C1294B* L_4 = V_1;
		NullCheck(L_4);
		VirtualActionInvoker1< String_t* >::Invoke(10 /* System.Void System.Net.WebRequest::set_Method(System.String) */, L_4, _stringLiteral14E338D17C42E552FA7AF42CDAE40CA1F0E8A04D);
		// byte[] b = System.Text.Encoding.UTF8.GetBytes(req);
		Encoding_t65CDEF28CF20A7B8C92E85A4E808920C2465F095* L_5;
		L_5 = Encoding_get_UTF8_m9700ADA8E0F244002B2A89B483F1B2133B8FE336(NULL);
		String_t* L_6 = V_0;
		NullCheck(L_5);
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_7;
		L_7 = VirtualFuncInvoker1< ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031*, String_t* >::Invoke(18 /* System.Byte[] System.Text.Encoding::GetBytes(System.String) */, L_5, L_6);
		V_2 = L_7;
		// r.Headers.Add("SOAPACTION", "\"urn:schemas-upnp-org:service:" + m_serviceName + ":1#" + function + "\"");
		WebRequest_t89050438AE9A5AA9221ECAE223584127F7C1294B* L_8 = V_1;
		NullCheck(L_8);
		WebHeaderCollection_tAF1CF77FB39D8E1EB782174E30566BAF55F71AE8* L_9;
		L_9 = VirtualFuncInvoker0< WebHeaderCollection_tAF1CF77FB39D8E1EB782174E30566BAF55F71AE8* >::Invoke(12 /* System.Net.WebHeaderCollection System.Net.WebRequest::get_Headers() */, L_8);
		StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248* L_10 = (StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248*)(StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248*)SZArrayNew(StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248_il2cpp_TypeInfo_var, (uint32_t)5);
		StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248* L_11 = L_10;
		NullCheck(L_11);
		ArrayElementTypeCheck (L_11, _stringLiteral293FD0A62157C0798F2DBF19E2A112B2F32964A6);
		(L_11)->SetAt(static_cast<il2cpp_array_size_t>(0), (String_t*)_stringLiteral293FD0A62157C0798F2DBF19E2A112B2F32964A6);
		StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248* L_12 = L_11;
		String_t* L_13 = __this->___m_serviceName_2;
		NullCheck(L_12);
		ArrayElementTypeCheck (L_12, L_13);
		(L_12)->SetAt(static_cast<il2cpp_array_size_t>(1), (String_t*)L_13);
		StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248* L_14 = L_12;
		NullCheck(L_14);
		ArrayElementTypeCheck (L_14, _stringLiteralD780C0360D4AE4D11F08385D4437D757F04827FA);
		(L_14)->SetAt(static_cast<il2cpp_array_size_t>(2), (String_t*)_stringLiteralD780C0360D4AE4D11F08385D4437D757F04827FA);
		StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248* L_15 = L_14;
		String_t* L_16 = ___function2;
		NullCheck(L_15);
		ArrayElementTypeCheck (L_15, L_16);
		(L_15)->SetAt(static_cast<il2cpp_array_size_t>(3), (String_t*)L_16);
		StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248* L_17 = L_15;
		NullCheck(L_17);
		ArrayElementTypeCheck (L_17, _stringLiteralC62C64F00567C5368CAE37F4E64E1E82FF785677);
		(L_17)->SetAt(static_cast<il2cpp_array_size_t>(4), (String_t*)_stringLiteralC62C64F00567C5368CAE37F4E64E1E82FF785677);
		String_t* L_18;
		L_18 = String_Concat_m6B0734B65813C8EA093D78E5C2D16534EB6FE8C0(L_17, NULL);
		NullCheck(L_9);
		VirtualActionInvoker2< String_t*, String_t* >::Invoke(15 /* System.Void System.Collections.Specialized.NameValueCollection::Add(System.String,System.String) */, L_9, _stringLiteral2A04459105AE2163347709664ECD535E3E105DF5, L_18);
		// r.ContentType = "text/xml; charset=\"utf-8\"";
		WebRequest_t89050438AE9A5AA9221ECAE223584127F7C1294B* L_19 = V_1;
		NullCheck(L_19);
		VirtualActionInvoker1< String_t* >::Invoke(15 /* System.Void System.Net.WebRequest::set_ContentType(System.String) */, L_19, _stringLiteral08D30F14509C8365E327175A5D6557EFD61BA45C);
		// r.ContentLength = b.Length;
		WebRequest_t89050438AE9A5AA9221ECAE223584127F7C1294B* L_20 = V_1;
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_21 = V_2;
		NullCheck(L_21);
		NullCheck(L_20);
		VirtualActionInvoker1< int64_t >::Invoke(14 /* System.Void System.Net.WebRequest::set_ContentLength(System.Int64) */, L_20, ((int64_t)((int32_t)(((RuntimeArray*)L_21)->max_length))));
		// r.GetRequestStream().Write(b, 0, b.Length);
		WebRequest_t89050438AE9A5AA9221ECAE223584127F7C1294B* L_22 = V_1;
		NullCheck(L_22);
		Stream_tF844051B786E8F7F4244DBD218D74E8617B9A2DE* L_23;
		L_23 = VirtualFuncInvoker0< Stream_tF844051B786E8F7F4244DBD218D74E8617B9A2DE* >::Invoke(22 /* System.IO.Stream System.Net.WebRequest::GetRequestStream() */, L_22);
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_24 = V_2;
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_25 = V_2;
		NullCheck(L_25);
		NullCheck(L_23);
		VirtualActionInvoker3< ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031*, int32_t, int32_t >::Invoke(35 /* System.Void System.IO.Stream::Write(System.Byte[],System.Int32,System.Int32) */, L_23, L_24, 0, ((int32_t)(((RuntimeArray*)L_25)->max_length)));
		// using (WebResponse wres = r.GetResponse()) {
		WebRequest_t89050438AE9A5AA9221ECAE223584127F7C1294B* L_26 = V_1;
		NullCheck(L_26);
		WebResponse_t7CDE1F20895C8D5AD392425F9AD4BE8E8696B682* L_27;
		L_27 = VirtualFuncInvoker0< WebResponse_t7CDE1F20895C8D5AD392425F9AD4BE8E8696B682* >::Invoke(23 /* System.Net.WebResponse System.Net.WebRequest::GetResponse() */, L_26);
		V_3 = L_27;
	}

IL_009b:
	{
		auto __finallyBlock = il2cpp::utils::Finally([&]
		{

FINALLY_00b4:
			{// begin finally (depth: 1)
				{
					WebResponse_t7CDE1F20895C8D5AD392425F9AD4BE8E8696B682* L_28 = V_3;
					if (!L_28)
					{
						goto IL_00bd;
					}
				}

IL_00b7:
				{
					WebResponse_t7CDE1F20895C8D5AD392425F9AD4BE8E8696B682* L_29 = V_3;
					NullCheck(L_29);
					InterfaceActionInvoker0::Invoke(0 /* System.Void System.IDisposable::Dispose() */, IDisposable_t030E0496B4E0E4E4F086825007979AF51F7248C5_il2cpp_TypeInfo_var, L_29);
				}

IL_00bd:
				{
					return;
				}
			}// end finally (depth: 1)
		});
		try
		{// begin try (depth: 1)
			// XmlDocument resp = new XmlDocument();
			XmlDocument_t4DE82998E642C5C21A4A620A5278237C70D3E42B* L_30 = (XmlDocument_t4DE82998E642C5C21A4A620A5278237C70D3E42B*)il2cpp_codegen_object_new(XmlDocument_t4DE82998E642C5C21A4A620A5278237C70D3E42B_il2cpp_TypeInfo_var);
			XmlDocument__ctor_m09B578D51E249702C90A99B87A31ABE8CE4027DC(L_30, /*hidden argument*/NULL);
			// Stream ress = wres.GetResponseStream();
			WebResponse_t7CDE1F20895C8D5AD392425F9AD4BE8E8696B682* L_31 = V_3;
			NullCheck(L_31);
			Stream_tF844051B786E8F7F4244DBD218D74E8617B9A2DE* L_32;
			L_32 = VirtualFuncInvoker0< Stream_tF844051B786E8F7F4244DBD218D74E8617B9A2DE* >::Invoke(12 /* System.IO.Stream System.Net.WebResponse::GetResponseStream() */, L_31);
			V_4 = L_32;
			// resp.Load(ress);
			XmlDocument_t4DE82998E642C5C21A4A620A5278237C70D3E42B* L_33 = L_30;
			Stream_tF844051B786E8F7F4244DBD218D74E8617B9A2DE* L_34 = V_4;
			NullCheck(L_33);
			VirtualActionInvoker1< Stream_tF844051B786E8F7F4244DBD218D74E8617B9A2DE* >::Invoke(71 /* System.Void System.Xml.XmlDocument::Load(System.IO.Stream) */, L_33, L_34);
			// return resp;
			V_5 = L_33;
			goto IL_00be;
		}// end try (depth: 1)
		catch(Il2CppExceptionWrapper& e)
		{
			__finallyBlock.StoreException(e.ex);
		}
	}

IL_00be:
	{
		// }
		XmlDocument_t4DE82998E642C5C21A4A620A5278237C70D3E42B* L_35 = V_5;
		return L_35;
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
// System.Void Lidgren.Network.NetUtility::ResolveAsync(System.String,System.Int32,Lidgren.Network.NetUtility/ResolveEndPointCallback)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void NetUtility_ResolveAsync_mFABDD43BCDB8807ED70ED371BFCAEBBBCC545FCD (String_t* ___ipOrHost0, int32_t ___port1, ResolveEndPointCallback_t5A60EB6B6BDAEA33BFEB134C8EFED8B43385049B* ___callback2, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&NetUtility_t0B01E9514810CE3FC3B5E83D8427CBA1C5689EFD_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ResolveAddressCallback_t025BC6260F915039CDB17B31BCDE78B9ED8CC3CF_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&U3CU3Ec__DisplayClass3_0_U3CResolveAsyncU3Eb__0_m062212D8E00D13552A2546A577F790E095E6373D_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&U3CU3Ec__DisplayClass3_0_t8A9B82FCFB20DB8AF0DEB4BFF84B5BF342D6D362_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
U3CU3Ec__DisplayClass3_0_t8A9B82FCFB20DB8AF0DEB4BFF84B5BF342D6D362* V_0 = NULL;
	{
		U3CU3Ec__DisplayClass3_0_t8A9B82FCFB20DB8AF0DEB4BFF84B5BF342D6D362* L_0 = (U3CU3Ec__DisplayClass3_0_t8A9B82FCFB20DB8AF0DEB4BFF84B5BF342D6D362*)il2cpp_codegen_object_new(U3CU3Ec__DisplayClass3_0_t8A9B82FCFB20DB8AF0DEB4BFF84B5BF342D6D362_il2cpp_TypeInfo_var);
		U3CU3Ec__DisplayClass3_0__ctor_m1C204809AC2DA7F72E6199399BC6FB93CA3CA382(L_0, /*hidden argument*/NULL);
		V_0 = L_0;
		U3CU3Ec__DisplayClass3_0_t8A9B82FCFB20DB8AF0DEB4BFF84B5BF342D6D362* L_1 = V_0;
		ResolveEndPointCallback_t5A60EB6B6BDAEA33BFEB134C8EFED8B43385049B* L_2 = ___callback2;
		NullCheck(L_1);
		L_1->___callback_0 = L_2;
		Il2CppCodeGenWriteBarrier((void**)(&L_1->___callback_0), (void*)L_2);
		U3CU3Ec__DisplayClass3_0_t8A9B82FCFB20DB8AF0DEB4BFF84B5BF342D6D362* L_3 = V_0;
		int32_t L_4 = ___port1;
		NullCheck(L_3);
		L_3->___port_1 = L_4;
		// ResolveAsync(ipOrHost, delegate(NetAddress adr)
		// {
		//     if (adr == null)
		//     {
		//         callback(null);
		//     }
		//     else
		//     {
		//         callback(new NetEndPoint(adr, port));
		//     }
		// });
		String_t* L_5 = ___ipOrHost0;
		U3CU3Ec__DisplayClass3_0_t8A9B82FCFB20DB8AF0DEB4BFF84B5BF342D6D362* L_6 = V_0;
		ResolveAddressCallback_t025BC6260F915039CDB17B31BCDE78B9ED8CC3CF* L_7 = (ResolveAddressCallback_t025BC6260F915039CDB17B31BCDE78B9ED8CC3CF*)il2cpp_codegen_object_new(ResolveAddressCallback_t025BC6260F915039CDB17B31BCDE78B9ED8CC3CF_il2cpp_TypeInfo_var);
		ResolveAddressCallback__ctor_m6947005CBFF0F0196EA1234FB57118E5C8D2A803(L_7, L_6, (intptr_t)((void*)U3CU3Ec__DisplayClass3_0_U3CResolveAsyncU3Eb__0_m062212D8E00D13552A2546A577F790E095E6373D_RuntimeMethod_var), /*hidden argument*/NULL);
		il2cpp_codegen_runtime_class_init_inline(NetUtility_t0B01E9514810CE3FC3B5E83D8427CBA1C5689EFD_il2cpp_TypeInfo_var);
		NetUtility_ResolveAsync_m361784C8A1E4D583AFD6B9C6D2502EFB1BAAF22C(L_5, L_7, NULL);
		// }
		return;
	}
}
// System.Net.IPEndPoint Lidgren.Network.NetUtility::Resolve(System.String,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR IPEndPoint_t2F09CBA7A808B67724B4E2954EEDC46D910F4ECB* NetUtility_Resolve_m6C6641695A9E78672BD25CB18414382F93D8AB0D (String_t* ___ipOrHost0, int32_t ___port1, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IPEndPoint_t2F09CBA7A808B67724B4E2954EEDC46D910F4ECB_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&NetUtility_t0B01E9514810CE3FC3B5E83D8427CBA1C5689EFD_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
IPAddress_t2F4486449B0D73FF2D3B36A9FE5E9C3F63116484* V_0 = NULL;
	{
		// var adr = Resolve(ipOrHost);
		String_t* L_0 = ___ipOrHost0;
		il2cpp_codegen_runtime_class_init_inline(NetUtility_t0B01E9514810CE3FC3B5E83D8427CBA1C5689EFD_il2cpp_TypeInfo_var);
		IPAddress_t2F4486449B0D73FF2D3B36A9FE5E9C3F63116484* L_1;
		L_1 = NetUtility_Resolve_m8DB1E743A221537111D97A7E975E46D59F4EF1BB(L_0, NULL);
		V_0 = L_1;
		// return adr == null ? null : new NetEndPoint(adr, port);
		IPAddress_t2F4486449B0D73FF2D3B36A9FE5E9C3F63116484* L_2 = V_0;
		if (!L_2)
		{
			goto IL_0012;
		}
	}
	{
		IPAddress_t2F4486449B0D73FF2D3B36A9FE5E9C3F63116484* L_3 = V_0;
		int32_t L_4 = ___port1;
		IPEndPoint_t2F09CBA7A808B67724B4E2954EEDC46D910F4ECB* L_5 = (IPEndPoint_t2F09CBA7A808B67724B4E2954EEDC46D910F4ECB*)il2cpp_codegen_object_new(IPEndPoint_t2F09CBA7A808B67724B4E2954EEDC46D910F4ECB_il2cpp_TypeInfo_var);
		IPEndPoint__ctor_m902C98F9E3F36B20B3C2E030AA91B62E2BC7A85A(L_5, L_3, L_4, /*hidden argument*/NULL);
		return L_5;
	}

IL_0012:
	{
		return (IPEndPoint_t2F09CBA7A808B67724B4E2954EEDC46D910F4ECB*)NULL;
	}
}
// System.Net.IPAddress Lidgren.Network.NetUtility::GetCachedBroadcastAddress()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR IPAddress_t2F4486449B0D73FF2D3B36A9FE5E9C3F63116484* NetUtility_GetCachedBroadcastAddress_mA6134D1CEBD539E92CA832D7D9325476F2CD3DFA (const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&NetUtility_t0B01E9514810CE3FC3B5E83D8427CBA1C5689EFD_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
{
		// if (s_broadcastAddress == null)
		il2cpp_codegen_runtime_class_init_inline(NetUtility_t0B01E9514810CE3FC3B5E83D8427CBA1C5689EFD_il2cpp_TypeInfo_var);
		IPAddress_t2F4486449B0D73FF2D3B36A9FE5E9C3F63116484* L_0 = ((NetUtility_t0B01E9514810CE3FC3B5E83D8427CBA1C5689EFD_StaticFields*)il2cpp_codegen_static_fields_for(NetUtility_t0B01E9514810CE3FC3B5E83D8427CBA1C5689EFD_il2cpp_TypeInfo_var))->___s_broadcastAddress_1;
		if (L_0)
		{
			goto IL_0011;
		}
	}
	{
		// s_broadcastAddress = GetBroadcastAddress();
		il2cpp_codegen_runtime_class_init_inline(NetUtility_t0B01E9514810CE3FC3B5E83D8427CBA1C5689EFD_il2cpp_TypeInfo_var);
		IPAddress_t2F4486449B0D73FF2D3B36A9FE5E9C3F63116484* L_1;
		L_1 = NetUtility_GetBroadcastAddress_m69CC4AFCA51DE14371F00A5A25170739B1496935(NULL);
		((NetUtility_t0B01E9514810CE3FC3B5E83D8427CBA1C5689EFD_StaticFields*)il2cpp_codegen_static_fields_for(NetUtility_t0B01E9514810CE3FC3B5E83D8427CBA1C5689EFD_il2cpp_TypeInfo_var))->___s_broadcastAddress_1 = L_1;
		Il2CppCodeGenWriteBarrier((void**)(&((NetUtility_t0B01E9514810CE3FC3B5E83D8427CBA1C5689EFD_StaticFields*)il2cpp_codegen_static_fields_for(NetUtility_t0B01E9514810CE3FC3B5E83D8427CBA1C5689EFD_il2cpp_TypeInfo_var))->___s_broadcastAddress_1), (void*)L_1);
	}

IL_0011:
	{
		// return s_broadcastAddress;
		il2cpp_codegen_runtime_class_init_inline(NetUtility_t0B01E9514810CE3FC3B5E83D8427CBA1C5689EFD_il2cpp_TypeInfo_var);
		IPAddress_t2F4486449B0D73FF2D3B36A9FE5E9C3F63116484* L_2 = ((NetUtility_t0B01E9514810CE3FC3B5E83D8427CBA1C5689EFD_StaticFields*)il2cpp_codegen_static_fields_for(NetUtility_t0B01E9514810CE3FC3B5E83D8427CBA1C5689EFD_il2cpp_TypeInfo_var))->___s_broadcastAddress_1;
		return L_2;
	}
}
// System.Void Lidgren.Network.NetUtility::ResolveAsync(System.String,Lidgren.Network.NetUtility/ResolveAddressCallback)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void NetUtility_ResolveAsync_m361784C8A1E4D583AFD6B9C6D2502EFB1BAAF22C (String_t* ___ipOrHost0, ResolveAddressCallback_t025BC6260F915039CDB17B31BCDE78B9ED8CC3CF* ___callback1, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AsyncCallback_t7FEF460CBDCFB9C5FA2EF776984778B9A4145F4C_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IPAddress_t2F4486449B0D73FF2D3B36A9FE5E9C3F63116484_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&U3CU3Ec__DisplayClass7_0_U3CResolveAsyncU3Eb__0_mF089B3B4BCAE0306728BCD87C51A27A1FF559ED9_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&U3CU3Ec__DisplayClass7_0_tB883D8785D0FF482B1D10D9C5244FE77BF69353A_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
U3CU3Ec__DisplayClass7_0_tB883D8785D0FF482B1D10D9C5244FE77BF69353A* V_0 = NULL;
	IPAddress_t2F4486449B0D73FF2D3B36A9FE5E9C3F63116484* V_1 = NULL;
	il2cpp::utils::ExceptionSupportStack<RuntimeObject*, 1> __active_exceptions;
	{
		U3CU3Ec__DisplayClass7_0_tB883D8785D0FF482B1D10D9C5244FE77BF69353A* L_0 = (U3CU3Ec__DisplayClass7_0_tB883D8785D0FF482B1D10D9C5244FE77BF69353A*)il2cpp_codegen_object_new(U3CU3Ec__DisplayClass7_0_tB883D8785D0FF482B1D10D9C5244FE77BF69353A_il2cpp_TypeInfo_var);
		U3CU3Ec__DisplayClass7_0__ctor_m54C100B10B7B0058E6372410E183F972B621DEEE(L_0, /*hidden argument*/NULL);
		V_0 = L_0;
		U3CU3Ec__DisplayClass7_0_tB883D8785D0FF482B1D10D9C5244FE77BF69353A* L_1 = V_0;
		ResolveAddressCallback_t025BC6260F915039CDB17B31BCDE78B9ED8CC3CF* L_2 = ___callback1;
		NullCheck(L_1);
		L_1->___callback_1 = L_2;
		Il2CppCodeGenWriteBarrier((void**)(&L_1->___callback_1), (void*)L_2);
		// if (string.IsNullOrEmpty(ipOrHost))
		String_t* L_3 = ___ipOrHost0;
		bool L_4;
		L_4 = String_IsNullOrEmpty_m54CF0907E7C4F3AFB2E796A13DC751ECBB8DB64A(L_3, NULL);
		if (!L_4)
		{
			goto IL_0025;
		}
	}
	{
		// throw new ArgumentException("Supplied string must not be empty", "ipOrHost");
		ArgumentException_tAD90411542A20A9C72D5CDA3A84181D8B947A263* L_5 = (ArgumentException_tAD90411542A20A9C72D5CDA3A84181D8B947A263*)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&ArgumentException_tAD90411542A20A9C72D5CDA3A84181D8B947A263_il2cpp_TypeInfo_var)));
		ArgumentException__ctor_m8F9D40CE19D19B698A70F9A258640EB52DB39B62(L_5, ((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteral8CB509FEC517C5EC041C9CEAB337EA4C0B0E596A)), ((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteralC5953BAEAE1C4C9506A8190E5A75FB0FBD272ED1)), /*hidden argument*/NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_5, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&NetUtility_ResolveAsync_m361784C8A1E4D583AFD6B9C6D2502EFB1BAAF22C_RuntimeMethod_var)));
	}

IL_0025:
	{
		// ipOrHost = ipOrHost.Trim();
		String_t* L_6 = ___ipOrHost0;
		NullCheck(L_6);
		String_t* L_7;
		L_7 = String_Trim_mCD6D8C6D4CFD15225D12DB7D3E0544CA80FB8DA5(L_6, NULL);
		___ipOrHost0 = L_7;
		// NetAddress ipAddress = null;
		V_1 = (IPAddress_t2F4486449B0D73FF2D3B36A9FE5E9C3F63116484*)NULL;
		// if (NetAddress.TryParse(ipOrHost, out ipAddress))
		String_t* L_8 = ___ipOrHost0;
		il2cpp_codegen_runtime_class_init_inline(IPAddress_t2F4486449B0D73FF2D3B36A9FE5E9C3F63116484_il2cpp_TypeInfo_var);
		bool L_9;
		L_9 = IPAddress_TryParse_mB8DC9EE090ED3BE8F8C9D419759AA9FF4A498D3B(L_8, (&V_1), NULL);
		if (!L_9)
		{
			goto IL_0064;
		}
	}
	{
		// if (ipAddress.AddressFamily == AddressFamily.InterNetwork || ipAddress.AddressFamily == AddressFamily.InterNetworkV6)
		IPAddress_t2F4486449B0D73FF2D3B36A9FE5E9C3F63116484* L_10 = V_1;
		NullCheck(L_10);
		int32_t L_11;
		L_11 = IPAddress_get_AddressFamily_m1CE4BCCE499BD70B22F9E37B3F266F9306A98C21(L_10, NULL);
		if ((((int32_t)L_11) == ((int32_t)2)))
		{
			goto IL_004c;
		}
	}
	{
		IPAddress_t2F4486449B0D73FF2D3B36A9FE5E9C3F63116484* L_12 = V_1;
		NullCheck(L_12);
		int32_t L_13;
		L_13 = IPAddress_get_AddressFamily_m1CE4BCCE499BD70B22F9E37B3F266F9306A98C21(L_12, NULL);
		if ((!(((uint32_t)L_13) == ((uint32_t)((int32_t)23)))))
		{
			goto IL_0059;
		}
	}

IL_004c:
	{
		// callback(ipAddress);
		U3CU3Ec__DisplayClass7_0_tB883D8785D0FF482B1D10D9C5244FE77BF69353A* L_14 = V_0;
		NullCheck(L_14);
		ResolveAddressCallback_t025BC6260F915039CDB17B31BCDE78B9ED8CC3CF* L_15 = L_14->___callback_1;
		IPAddress_t2F4486449B0D73FF2D3B36A9FE5E9C3F63116484* L_16 = V_1;
		NullCheck(L_15);
		ResolveAddressCallback_Invoke_m0FF0480977B8C46A93C0063B6F282E61190C426C(L_15, L_16, NULL);
		// return;
		return;
	}

IL_0059:
	{
		// throw new ArgumentException("This method will not currently resolve other than ipv4 addresses");
		ArgumentException_tAD90411542A20A9C72D5CDA3A84181D8B947A263* L_17 = (ArgumentException_tAD90411542A20A9C72D5CDA3A84181D8B947A263*)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&ArgumentException_tAD90411542A20A9C72D5CDA3A84181D8B947A263_il2cpp_TypeInfo_var)));
		ArgumentException__ctor_m026938A67AF9D36BB7ED27F80425D7194B514465(L_17, ((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteral2C6D55A7C7BB624D69C05CC09678AAF3F3D49A19)), /*hidden argument*/NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_17, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&NetUtility_ResolveAsync_m361784C8A1E4D583AFD6B9C6D2502EFB1BAAF22C_RuntimeMethod_var)));
	}

IL_0064:
	{
	}

IL_0065:
	try
	{// begin try (depth: 1)
		// Dns.BeginGetHostEntry(ipOrHost, delegate(IAsyncResult result)
		// {
		//     try
		//     {
		//         entry = Dns.EndGetHostEntry(result);
		//     }
		//     catch (SocketException ex)
		//     {
		//         if (ex.SocketErrorCode == SocketError.HostNotFound)
		//         {
		//             //LogWrite(string.Format(CultureInfo.InvariantCulture, "Failed to resolve host '{0}'.", ipOrHost));
		//             callback(null);
		//             return;
		//         }
		//         else
		//         {
		//             throw;
		//         }
		//     }
		// 
		//     if (entry == null)
		//     {
		//         callback(null);
		//         return;
		//     }
		// 
		//     // check each entry for a valid IP address
		//     foreach (var ipCurrent in entry.AddressList)
		//     {
		//         if (ipCurrent.AddressFamily == AddressFamily.InterNetwork || ipCurrent.AddressFamily == AddressFamily.InterNetworkV6)
		//         {
		//             callback(ipCurrent);
		//             return;
		//         }
		//     }
		// 
		//     callback(null);
		// }, null);
		String_t* L_18 = ___ipOrHost0;
		U3CU3Ec__DisplayClass7_0_tB883D8785D0FF482B1D10D9C5244FE77BF69353A* L_19 = V_0;
		AsyncCallback_t7FEF460CBDCFB9C5FA2EF776984778B9A4145F4C* L_20 = (AsyncCallback_t7FEF460CBDCFB9C5FA2EF776984778B9A4145F4C*)il2cpp_codegen_object_new(AsyncCallback_t7FEF460CBDCFB9C5FA2EF776984778B9A4145F4C_il2cpp_TypeInfo_var);
		AsyncCallback__ctor_mC3C0475E930E4419AED02C7335E53B425A2D68AC(L_20, L_19, (intptr_t)((void*)U3CU3Ec__DisplayClass7_0_U3CResolveAsyncU3Eb__0_mF089B3B4BCAE0306728BCD87C51A27A1FF559ED9_RuntimeMethod_var), /*hidden argument*/NULL);
		RuntimeObject* L_21;
		L_21 = Dns_BeginGetHostEntry_m09FA5BD3D68754D9709AAB66C7D82D2D9B7EFAEB(L_18, L_20, NULL, NULL);
		// }
		goto IL_0099;
	}// end try (depth: 1)
	catch(Il2CppExceptionWrapper& e)
	{
		if(il2cpp_codegen_class_is_assignable_from (((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&SocketException_t6D10102A62EA871BD31748E026A372DB6804083B_il2cpp_TypeInfo_var)), il2cpp_codegen_object_class(e.ex)))
		{
			IL2CPP_PUSH_ACTIVE_EXCEPTION(e.ex);
			goto CATCH_007b;
		}
		throw e;
	}

CATCH_007b:
	{// begin catch(System.Net.Sockets.SocketException)
		{
			// if (ex.SocketErrorCode == SocketError.HostNotFound)
			NullCheck(((SocketException_t6D10102A62EA871BD31748E026A372DB6804083B*)IL2CPP_GET_ACTIVE_EXCEPTION(SocketException_t6D10102A62EA871BD31748E026A372DB6804083B*)));
			int32_t L_22;
			L_22 = SocketException_get_SocketErrorCode_m84FB2D308F046A24A1355975F3BF689C988224C6(((SocketException_t6D10102A62EA871BD31748E026A372DB6804083B*)IL2CPP_GET_ACTIVE_EXCEPTION(SocketException_t6D10102A62EA871BD31748E026A372DB6804083B*)), NULL);
			if ((!(((uint32_t)L_22) == ((uint32_t)((int32_t)11001)))))
			{
				goto IL_0095;
			}
		}

IL_0087:
		{
			// callback(null);
			U3CU3Ec__DisplayClass7_0_tB883D8785D0FF482B1D10D9C5244FE77BF69353A* L_23 = V_0;
			NullCheck(L_23);
			ResolveAddressCallback_t025BC6260F915039CDB17B31BCDE78B9ED8CC3CF* L_24 = L_23->___callback_1;
			NullCheck(L_24);
			ResolveAddressCallback_Invoke_m0FF0480977B8C46A93C0063B6F282E61190C426C(L_24, (IPAddress_t2F4486449B0D73FF2D3B36A9FE5E9C3F63116484*)NULL, NULL);
			goto IL_0097;
		}

IL_0095:
		{
			// throw;
			IL2CPP_RAISE_MANAGED_EXCEPTION(IL2CPP_GET_ACTIVE_EXCEPTION(Exception_t*), ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&NetUtility_ResolveAsync_m361784C8A1E4D583AFD6B9C6D2502EFB1BAAF22C_RuntimeMethod_var)));
		}

IL_0097:
		{
			// }
			IL2CPP_POP_ACTIVE_EXCEPTION();
			goto IL_0099;
		}
	}// end catch (depth: 1)

IL_0099:
	{
		// }
		return;
	}
}
// System.Net.IPAddress Lidgren.Network.NetUtility::Resolve(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR IPAddress_t2F4486449B0D73FF2D3B36A9FE5E9C3F63116484* NetUtility_Resolve_m8DB1E743A221537111D97A7E975E46D59F4EF1BB (String_t* ___ipOrHost0, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IPAddress_t2F4486449B0D73FF2D3B36A9FE5E9C3F63116484_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
IPAddress_t2F4486449B0D73FF2D3B36A9FE5E9C3F63116484* V_0 = NULL;
	IPAddressU5BU5D_t3AEDF3B94746C9023A4549F878AA47F702C9CD0D* V_1 = NULL;
	IPAddress_t2F4486449B0D73FF2D3B36A9FE5E9C3F63116484* V_2 = NULL;
	IPAddressU5BU5D_t3AEDF3B94746C9023A4549F878AA47F702C9CD0D* V_3 = NULL;
	int32_t V_4 = 0;
	IPAddress_t2F4486449B0D73FF2D3B36A9FE5E9C3F63116484* V_5 = NULL;
	il2cpp::utils::ExceptionSupportStack<RuntimeObject*, 1> __active_exceptions;
	{
		// if (string.IsNullOrEmpty(ipOrHost))
		String_t* L_0 = ___ipOrHost0;
		bool L_1;
		L_1 = String_IsNullOrEmpty_m54CF0907E7C4F3AFB2E796A13DC751ECBB8DB64A(L_0, NULL);
		if (!L_1)
		{
			goto IL_0018;
		}
	}
	{
		// throw new ArgumentException("Supplied string must not be empty", "ipOrHost");
		ArgumentException_tAD90411542A20A9C72D5CDA3A84181D8B947A263* L_2 = (ArgumentException_tAD90411542A20A9C72D5CDA3A84181D8B947A263*)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&ArgumentException_tAD90411542A20A9C72D5CDA3A84181D8B947A263_il2cpp_TypeInfo_var)));
		ArgumentException__ctor_m8F9D40CE19D19B698A70F9A258640EB52DB39B62(L_2, ((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteral8CB509FEC517C5EC041C9CEAB337EA4C0B0E596A)), ((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteralC5953BAEAE1C4C9506A8190E5A75FB0FBD272ED1)), /*hidden argument*/NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_2, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&NetUtility_Resolve_m8DB1E743A221537111D97A7E975E46D59F4EF1BB_RuntimeMethod_var)));
	}

IL_0018:
	{
		// ipOrHost = ipOrHost.Trim();
		String_t* L_3 = ___ipOrHost0;
		NullCheck(L_3);
		String_t* L_4;
		L_4 = String_Trim_mCD6D8C6D4CFD15225D12DB7D3E0544CA80FB8DA5(L_3, NULL);
		___ipOrHost0 = L_4;
		// NetAddress ipAddress = null;
		V_0 = (IPAddress_t2F4486449B0D73FF2D3B36A9FE5E9C3F63116484*)NULL;
		// if (NetAddress.TryParse(ipOrHost, out ipAddress))
		String_t* L_5 = ___ipOrHost0;
		il2cpp_codegen_runtime_class_init_inline(IPAddress_t2F4486449B0D73FF2D3B36A9FE5E9C3F63116484_il2cpp_TypeInfo_var);
		bool L_6;
		L_6 = IPAddress_TryParse_mB8DC9EE090ED3BE8F8C9D419759AA9FF4A498D3B(L_5, (&V_0), NULL);
		if (!L_6)
		{
			goto IL_004c;
		}
	}
	{
		// if (ipAddress.AddressFamily == AddressFamily.InterNetwork || ipAddress.AddressFamily == AddressFamily.InterNetworkV6)
		IPAddress_t2F4486449B0D73FF2D3B36A9FE5E9C3F63116484* L_7 = V_0;
		NullCheck(L_7);
		int32_t L_8;
		L_8 = IPAddress_get_AddressFamily_m1CE4BCCE499BD70B22F9E37B3F266F9306A98C21(L_7, NULL);
		if ((((int32_t)L_8) == ((int32_t)2)))
		{
			goto IL_003f;
		}
	}
	{
		IPAddress_t2F4486449B0D73FF2D3B36A9FE5E9C3F63116484* L_9 = V_0;
		NullCheck(L_9);
		int32_t L_10;
		L_10 = IPAddress_get_AddressFamily_m1CE4BCCE499BD70B22F9E37B3F266F9306A98C21(L_9, NULL);
		if ((!(((uint32_t)L_10) == ((uint32_t)((int32_t)23)))))
		{
			goto IL_0041;
		}
	}

IL_003f:
	{
		// return ipAddress;
		IPAddress_t2F4486449B0D73FF2D3B36A9FE5E9C3F63116484* L_11 = V_0;
		return L_11;
	}

IL_0041:
	{
		// throw new ArgumentException("This method will not currently resolve other than IPv4 or IPv6 addresses");
		ArgumentException_tAD90411542A20A9C72D5CDA3A84181D8B947A263* L_12 = (ArgumentException_tAD90411542A20A9C72D5CDA3A84181D8B947A263*)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&ArgumentException_tAD90411542A20A9C72D5CDA3A84181D8B947A263_il2cpp_TypeInfo_var)));
		ArgumentException__ctor_m026938A67AF9D36BB7ED27F80425D7194B514465(L_12, ((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteral409FAF38FC25C13F705C019133CD49F11F11878B)), /*hidden argument*/NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_12, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&NetUtility_Resolve_m8DB1E743A221537111D97A7E975E46D59F4EF1BB_RuntimeMethod_var)));
	}

IL_004c:
	{
	}

IL_004d:
	try
	{// begin try (depth: 1)
		{
			// var addresses = Dns.GetHostAddresses(ipOrHost);
			String_t* L_13 = ___ipOrHost0;
			IPAddressU5BU5D_t3AEDF3B94746C9023A4549F878AA47F702C9CD0D* L_14;
			L_14 = Dns_GetHostAddresses_m0592CB7DB3F5665C412BCBE8297F198748114F90(L_13, NULL);
			V_1 = L_14;
			// if (addresses == null)
			IPAddressU5BU5D_t3AEDF3B94746C9023A4549F878AA47F702C9CD0D* L_15 = V_1;
			if (L_15)
			{
				goto IL_005b;
			}
		}

IL_0057:
		{
			// return null;
			V_2 = (IPAddress_t2F4486449B0D73FF2D3B36A9FE5E9C3F63116484*)NULL;
			goto IL_00a5;
		}

IL_005b:
		{
			// foreach (var address in addresses)
			IPAddressU5BU5D_t3AEDF3B94746C9023A4549F878AA47F702C9CD0D* L_16 = V_1;
			V_3 = L_16;
			V_4 = 0;
			goto IL_0088;
		}

IL_0062:
		{
			// foreach (var address in addresses)
			IPAddressU5BU5D_t3AEDF3B94746C9023A4549F878AA47F702C9CD0D* L_17 = V_3;
			int32_t L_18 = V_4;
			NullCheck(L_17);
			int32_t L_19 = L_18;
			IPAddress_t2F4486449B0D73FF2D3B36A9FE5E9C3F63116484* L_20 = (L_17)->GetAt(static_cast<il2cpp_array_size_t>(L_19));
			V_5 = L_20;
			// if (address.AddressFamily == AddressFamily.InterNetwork || address.AddressFamily == AddressFamily.InterNetworkV6)
			IPAddress_t2F4486449B0D73FF2D3B36A9FE5E9C3F63116484* L_21 = V_5;
			NullCheck(L_21);
			int32_t L_22;
			L_22 = IPAddress_get_AddressFamily_m1CE4BCCE499BD70B22F9E37B3F266F9306A98C21(L_21, NULL);
			if ((((int32_t)L_22) == ((int32_t)2)))
			{
				goto IL_007d;
			}
		}

IL_0072:
		{
			IPAddress_t2F4486449B0D73FF2D3B36A9FE5E9C3F63116484* L_23 = V_5;
			NullCheck(L_23);
			int32_t L_24;
			L_24 = IPAddress_get_AddressFamily_m1CE4BCCE499BD70B22F9E37B3F266F9306A98C21(L_23, NULL);
			if ((!(((uint32_t)L_24) == ((uint32_t)((int32_t)23)))))
			{
				goto IL_0082;
			}
		}

IL_007d:
		{
			// return address;
			IPAddress_t2F4486449B0D73FF2D3B36A9FE5E9C3F63116484* L_25 = V_5;
			V_2 = L_25;
			goto IL_00a5;
		}

IL_0082:
		{
			int32_t L_26 = V_4;
			V_4 = ((int32_t)il2cpp_codegen_add(L_26, 1));
		}

IL_0088:
		{
			// foreach (var address in addresses)
			int32_t L_27 = V_4;
			IPAddressU5BU5D_t3AEDF3B94746C9023A4549F878AA47F702C9CD0D* L_28 = V_3;
			NullCheck(L_28);
			if ((((int32_t)L_27) < ((int32_t)((int32_t)(((RuntimeArray*)L_28)->max_length)))))
			{
				goto IL_0062;
			}
		}

IL_008f:
		{
			// return null;
			V_2 = (IPAddress_t2F4486449B0D73FF2D3B36A9FE5E9C3F63116484*)NULL;
			goto IL_00a5;
		}
	}// end try (depth: 1)
	catch(Il2CppExceptionWrapper& e)
	{
		if(il2cpp_codegen_class_is_assignable_from (((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&SocketException_t6D10102A62EA871BD31748E026A372DB6804083B_il2cpp_TypeInfo_var)), il2cpp_codegen_object_class(e.ex)))
		{
			IL2CPP_PUSH_ACTIVE_EXCEPTION(e.ex);
			goto CATCH_0093;
		}
		throw e;
	}

CATCH_0093:
	{// begin catch(System.Net.Sockets.SocketException)
		{
			// if (ex.SocketErrorCode == SocketError.HostNotFound)
			NullCheck(((SocketException_t6D10102A62EA871BD31748E026A372DB6804083B*)IL2CPP_GET_ACTIVE_EXCEPTION(SocketException_t6D10102A62EA871BD31748E026A372DB6804083B*)));
			int32_t L_29;
			L_29 = SocketException_get_SocketErrorCode_m84FB2D308F046A24A1355975F3BF689C988224C6(((SocketException_t6D10102A62EA871BD31748E026A372DB6804083B*)IL2CPP_GET_ACTIVE_EXCEPTION(SocketException_t6D10102A62EA871BD31748E026A372DB6804083B*)), NULL);
			if ((!(((uint32_t)L_29) == ((uint32_t)((int32_t)11001)))))
			{
				goto IL_00a3;
			}
		}

IL_009f:
		{
			// return null;
			V_2 = (IPAddress_t2F4486449B0D73FF2D3B36A9FE5E9C3F63116484*)NULL;
			IL2CPP_POP_ACTIVE_EXCEPTION();
			goto IL_00a5;
		}

IL_00a3:
		{
			// throw;
			IL2CPP_RAISE_MANAGED_EXCEPTION(IL2CPP_GET_ACTIVE_EXCEPTION(Exception_t*), ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&NetUtility_Resolve_m8DB1E743A221537111D97A7E975E46D59F4EF1BB_RuntimeMethod_var)));
		}
	}// end catch (depth: 1)

IL_00a5:
	{
		// }
		IPAddress_t2F4486449B0D73FF2D3B36A9FE5E9C3F63116484* L_30 = V_2;
		return L_30;
	}
}
// System.String Lidgren.Network.NetUtility::ToHexString(System.Int64)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* NetUtility_ToHexString_m6A45FD065FC0E33F4DE690A05BF9F3CA5DCB22C6 (int64_t ___data0, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&BitConverter_t6E99605185963BC12B3D369E13F2B88997E64A27_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&NetUtility_t0B01E9514810CE3FC3B5E83D8427CBA1C5689EFD_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
{
		// return ToHexString(BitConverter.GetBytes(data));
		int64_t L_0 = ___data0;
		il2cpp_codegen_runtime_class_init_inline(BitConverter_t6E99605185963BC12B3D369E13F2B88997E64A27_il2cpp_TypeInfo_var);
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_1;
		L_1 = BitConverter_GetBytes_m2C128EDCD9B369F1429E1A0B7F687C98526115BF(L_0, NULL);
		il2cpp_codegen_runtime_class_init_inline(NetUtility_t0B01E9514810CE3FC3B5E83D8427CBA1C5689EFD_il2cpp_TypeInfo_var);
		String_t* L_2;
		L_2 = NetUtility_ToHexString_m54E357477D8D0AD283B929917378B10D8E1F380B(L_1, NULL);
		return L_2;
	}
}
// System.String Lidgren.Network.NetUtility::ToHexString(System.Byte[])
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* NetUtility_ToHexString_m54E357477D8D0AD283B929917378B10D8E1F380B (ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* ___data0, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&NetUtility_t0B01E9514810CE3FC3B5E83D8427CBA1C5689EFD_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
{
		// return ToHexString(data, 0, data.Length);
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_0 = ___data0;
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_1 = ___data0;
		NullCheck(L_1);
		il2cpp_codegen_runtime_class_init_inline(NetUtility_t0B01E9514810CE3FC3B5E83D8427CBA1C5689EFD_il2cpp_TypeInfo_var);
		String_t* L_2;
		L_2 = NetUtility_ToHexString_m14517A11A69DE4F4A86641139825BC7B5F6EDCC5(L_0, 0, ((int32_t)(((RuntimeArray*)L_1)->max_length)), NULL);
		return L_2;
	}
}
// System.String Lidgren.Network.NetUtility::ToHexString(System.Byte[],System.Int32,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* NetUtility_ToHexString_m14517A11A69DE4F4A86641139825BC7B5F6EDCC5 (ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* ___data0, int32_t ___offset1, int32_t ___length2, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&CharU5BU5D_t799905CF001DD5F13F7DBB310181FC4D8B7D0AAB_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
CharU5BU5D_t799905CF001DD5F13F7DBB310181FC4D8B7D0AAB* V_0 = NULL;
	uint8_t V_1 = 0x0;
	int32_t V_2 = 0;
	int32_t G_B3_0 = 0;
	CharU5BU5D_t799905CF001DD5F13F7DBB310181FC4D8B7D0AAB* G_B3_1 = NULL;
	int32_t G_B2_0 = 0;
	CharU5BU5D_t799905CF001DD5F13F7DBB310181FC4D8B7D0AAB* G_B2_1 = NULL;
	int32_t G_B4_0 = 0;
	int32_t G_B4_1 = 0;
	CharU5BU5D_t799905CF001DD5F13F7DBB310181FC4D8B7D0AAB* G_B4_2 = NULL;
	int32_t G_B6_0 = 0;
	CharU5BU5D_t799905CF001DD5F13F7DBB310181FC4D8B7D0AAB* G_B6_1 = NULL;
	int32_t G_B5_0 = 0;
	CharU5BU5D_t799905CF001DD5F13F7DBB310181FC4D8B7D0AAB* G_B5_1 = NULL;
	int32_t G_B7_0 = 0;
	int32_t G_B7_1 = 0;
	CharU5BU5D_t799905CF001DD5F13F7DBB310181FC4D8B7D0AAB* G_B7_2 = NULL;
	{
		// char[] c = new char[length * 2];
		int32_t L_0 = ___length2;
		CharU5BU5D_t799905CF001DD5F13F7DBB310181FC4D8B7D0AAB* L_1 = (CharU5BU5D_t799905CF001DD5F13F7DBB310181FC4D8B7D0AAB*)(CharU5BU5D_t799905CF001DD5F13F7DBB310181FC4D8B7D0AAB*)SZArrayNew(CharU5BU5D_t799905CF001DD5F13F7DBB310181FC4D8B7D0AAB_il2cpp_TypeInfo_var, (uint32_t)((int32_t)il2cpp_codegen_multiply(L_0, 2)));
		V_0 = L_1;
		// for (int i = 0; i < length; ++i)
		V_2 = 0;
		goto IL_0050;
	}

IL_000d:
	{
		// b = ((byte)(data[offset + i] >> 4));
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_2 = ___data0;
		int32_t L_3 = ___offset1;
		int32_t L_4 = V_2;
		NullCheck(L_2);
		int32_t L_5 = ((int32_t)il2cpp_codegen_add(L_3, L_4));
		uint8_t L_6 = (L_2)->GetAt(static_cast<il2cpp_array_size_t>(L_5));
		V_1 = (uint8_t)((int32_t)(uint8_t)((int32_t)((int32_t)L_6>>4)));
		// c[i * 2] = (char)(b > 9 ? b + 0x37 : b + 0x30);
		CharU5BU5D_t799905CF001DD5F13F7DBB310181FC4D8B7D0AAB* L_7 = V_0;
		int32_t L_8 = V_2;
		uint8_t L_9 = V_1;
		G_B2_0 = ((int32_t)il2cpp_codegen_multiply(L_8, 2));
		G_B2_1 = L_7;
		if ((((int32_t)L_9) > ((int32_t)((int32_t)9))))
		{
			G_B3_0 = ((int32_t)il2cpp_codegen_multiply(L_8, 2));
			G_B3_1 = L_7;
			goto IL_0025;
		}
	}
	{
		uint8_t L_10 = V_1;
		G_B4_0 = ((int32_t)il2cpp_codegen_add((int32_t)L_10, ((int32_t)48)));
		G_B4_1 = G_B2_0;
		G_B4_2 = G_B2_1;
		goto IL_0029;
	}

IL_0025:
	{
		uint8_t L_11 = V_1;
		G_B4_0 = ((int32_t)il2cpp_codegen_add((int32_t)L_11, ((int32_t)55)));
		G_B4_1 = G_B3_0;
		G_B4_2 = G_B3_1;
	}

IL_0029:
	{
		NullCheck(G_B4_2);
		(G_B4_2)->SetAt(static_cast<il2cpp_array_size_t>(G_B4_1), (Il2CppChar)((int32_t)(uint16_t)G_B4_0));
		// b = ((byte)(data[offset + i] & 0xF));
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_12 = ___data0;
		int32_t L_13 = ___offset1;
		int32_t L_14 = V_2;
		NullCheck(L_12);
		int32_t L_15 = ((int32_t)il2cpp_codegen_add(L_13, L_14));
		uint8_t L_16 = (L_12)->GetAt(static_cast<il2cpp_array_size_t>(L_15));
		V_1 = (uint8_t)((int32_t)(uint8_t)((int32_t)((int32_t)L_16&((int32_t)15))));
		// c[i * 2 + 1] = (char)(b > 9 ? b + 0x37 : b + 0x30);
		CharU5BU5D_t799905CF001DD5F13F7DBB310181FC4D8B7D0AAB* L_17 = V_0;
		int32_t L_18 = V_2;
		uint8_t L_19 = V_1;
		G_B5_0 = ((int32_t)il2cpp_codegen_add(((int32_t)il2cpp_codegen_multiply(L_18, 2)), 1));
		G_B5_1 = L_17;
		if ((((int32_t)L_19) > ((int32_t)((int32_t)9))))
		{
			G_B6_0 = ((int32_t)il2cpp_codegen_add(((int32_t)il2cpp_codegen_multiply(L_18, 2)), 1));
			G_B6_1 = L_17;
			goto IL_0046;
		}
	}
	{
		uint8_t L_20 = V_1;
		G_B7_0 = ((int32_t)il2cpp_codegen_add((int32_t)L_20, ((int32_t)48)));
		G_B7_1 = G_B5_0;
		G_B7_2 = G_B5_1;
		goto IL_004a;
	}

IL_0046:
	{
		uint8_t L_21 = V_1;
		G_B7_0 = ((int32_t)il2cpp_codegen_add((int32_t)L_21, ((int32_t)55)));
		G_B7_1 = G_B6_0;
		G_B7_2 = G_B6_1;
	}

IL_004a:
	{
		NullCheck(G_B7_2);
		(G_B7_2)->SetAt(static_cast<il2cpp_array_size_t>(G_B7_1), (Il2CppChar)((int32_t)(uint16_t)G_B7_0));
		// for (int i = 0; i < length; ++i)
		int32_t L_22 = V_2;
		V_2 = ((int32_t)il2cpp_codegen_add(L_22, 1));
	}

IL_0050:
	{
		// for (int i = 0; i < length; ++i)
		int32_t L_23 = V_2;
		int32_t L_24 = ___length2;
		if ((((int32_t)L_23) < ((int32_t)L_24)))
		{
			goto IL_000d;
		}
	}
	{
		// return new string(c);
		CharU5BU5D_t799905CF001DD5F13F7DBB310181FC4D8B7D0AAB* L_25 = V_0;
		String_t* L_26;
		L_26 = String_CreateString_mFBC28D2E3EB87D497F7E702E4FFAD65F635E44DF(NULL, L_25, NULL);
		return L_26;
	}
}
// System.Boolean Lidgren.Network.NetUtility::IsLocal(System.Net.IPEndPoint)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool NetUtility_IsLocal_m73B23C8AE503E2E3CFF11FBAAD6B617A26CDA235 (IPEndPoint_t2F09CBA7A808B67724B4E2954EEDC46D910F4ECB* ___endPoint0, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&NetUtility_t0B01E9514810CE3FC3B5E83D8427CBA1C5689EFD_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
{
		// if (endPoint == null)
		IPEndPoint_t2F09CBA7A808B67724B4E2954EEDC46D910F4ECB* L_0 = ___endPoint0;
		if (L_0)
		{
			goto IL_0005;
		}
	}
	{
		// return false;
		return (bool)0;
	}

IL_0005:
	{
		// return IsLocal(endPoint.Address);
		IPEndPoint_t2F09CBA7A808B67724B4E2954EEDC46D910F4ECB* L_1 = ___endPoint0;
		NullCheck(L_1);
		IPAddress_t2F4486449B0D73FF2D3B36A9FE5E9C3F63116484* L_2;
		L_2 = IPEndPoint_get_Address_m72F783CB76E10E9DBDF680CCC1DAAED201BABB1C_inline(L_1, NULL);
		il2cpp_codegen_runtime_class_init_inline(NetUtility_t0B01E9514810CE3FC3B5E83D8427CBA1C5689EFD_il2cpp_TypeInfo_var);
		bool L_3;
		L_3 = NetUtility_IsLocal_mF041CF604B0084FC2ED5A04312126E728384F235(L_2, NULL);
		return L_3;
	}
}
// System.Boolean Lidgren.Network.NetUtility::IsLocal(System.Net.IPAddress)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool NetUtility_IsLocal_mF041CF604B0084FC2ED5A04312126E728384F235 (IPAddress_t2F4486449B0D73FF2D3B36A9FE5E9C3F63116484* ___remote0, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&BitConverter_t6E99605185963BC12B3D369E13F2B88997E64A27_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&NetUtility_t0B01E9514810CE3FC3B5E83D8427CBA1C5689EFD_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
IPAddress_t2F4486449B0D73FF2D3B36A9FE5E9C3F63116484* V_0 = NULL;
	IPAddress_t2F4486449B0D73FF2D3B36A9FE5E9C3F63116484* V_1 = NULL;
	uint32_t V_2 = 0;
	uint32_t V_3 = 0;
	{
		// var local = GetMyAddress(out mask);
		il2cpp_codegen_runtime_class_init_inline(NetUtility_t0B01E9514810CE3FC3B5E83D8427CBA1C5689EFD_il2cpp_TypeInfo_var);
		IPAddress_t2F4486449B0D73FF2D3B36A9FE5E9C3F63116484* L_0;
		L_0 = NetUtility_GetMyAddress_m3051AD9EA9B97026C0AD93C606B39B247759AD85((&V_0), NULL);
		V_1 = L_0;
		// if (mask == null)
		IPAddress_t2F4486449B0D73FF2D3B36A9FE5E9C3F63116484* L_1 = V_0;
		if (L_1)
		{
			goto IL_000d;
		}
	}
	{
		// return false;
		return (bool)0;
	}

IL_000d:
	{
		// uint maskBits = BitConverter.ToUInt32(mask.GetAddressBytes(), 0);
		IPAddress_t2F4486449B0D73FF2D3B36A9FE5E9C3F63116484* L_2 = V_0;
		NullCheck(L_2);
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_3;
		L_3 = IPAddress_GetAddressBytes_m1501E0143C791E3A065E508F5535D8E206652EC9(L_2, NULL);
		il2cpp_codegen_runtime_class_init_inline(BitConverter_t6E99605185963BC12B3D369E13F2B88997E64A27_il2cpp_TypeInfo_var);
		uint32_t L_4;
		L_4 = BitConverter_ToUInt32_m7EFCF9D77ACD0F2DA29F69587DDF6130391E6164(L_3, 0, NULL);
		V_2 = L_4;
		// uint remoteBits = BitConverter.ToUInt32(remote.GetAddressBytes(), 0);
		IPAddress_t2F4486449B0D73FF2D3B36A9FE5E9C3F63116484* L_5 = ___remote0;
		NullCheck(L_5);
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_6;
		L_6 = IPAddress_GetAddressBytes_m1501E0143C791E3A065E508F5535D8E206652EC9(L_5, NULL);
		uint32_t L_7;
		L_7 = BitConverter_ToUInt32_m7EFCF9D77ACD0F2DA29F69587DDF6130391E6164(L_6, 0, NULL);
		// uint localBits = BitConverter.ToUInt32(local.GetAddressBytes(), 0);
		IPAddress_t2F4486449B0D73FF2D3B36A9FE5E9C3F63116484* L_8 = V_1;
		NullCheck(L_8);
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_9;
		L_9 = IPAddress_GetAddressBytes_m1501E0143C791E3A065E508F5535D8E206652EC9(L_8, NULL);
		uint32_t L_10;
		L_10 = BitConverter_ToUInt32_m7EFCF9D77ACD0F2DA29F69587DDF6130391E6164(L_9, 0, NULL);
		V_3 = L_10;
		// return ((remoteBits & maskBits) == (localBits & maskBits));
		uint32_t L_11 = V_2;
		uint32_t L_12 = V_3;
		uint32_t L_13 = V_2;
		return (bool)((((int32_t)((int32_t)((int32_t)L_7&(int32_t)L_11))) == ((int32_t)((int32_t)((int32_t)L_12&(int32_t)L_13))))? 1 : 0);
	}
}
// System.Int32 Lidgren.Network.NetUtility::BitsToHoldUInt(System.UInt32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t NetUtility_BitsToHoldUInt_m52EFD32D73B829357952441E49AEF366AE1DEF7C (uint32_t ___value0, const RuntimeMethod* method) 
{
int32_t V_0 = 0;
	{
		// int bits = 1;
		V_0 = 1;
		goto IL_0008;
	}

IL_0004:
	{
		// bits++;
		int32_t L_0 = V_0;
		V_0 = ((int32_t)il2cpp_codegen_add(L_0, 1));
	}

IL_0008:
	{
		// while ((value >>= 1) != 0)
		uint32_t L_1 = ___value0;
		int32_t L_2 = ((int32_t)((uint32_t)L_1>>1));
		___value0 = L_2;
		if (L_2)
		{
			goto IL_0004;
		}
	}
	{
		// return bits;
		int32_t L_3 = V_0;
		return L_3;
	}
}
// System.Int32 Lidgren.Network.NetUtility::BitsToHoldUInt64(System.UInt64)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t NetUtility_BitsToHoldUInt64_mA587A2C654288D8F7EB55899040AE2D5BF30D7ED (uint64_t ___value0, const RuntimeMethod* method) 
{
int32_t V_0 = 0;
	{
		// int bits = 1;
		V_0 = 1;
		goto IL_0008;
	}

IL_0004:
	{
		// bits++;
		int32_t L_0 = V_0;
		V_0 = ((int32_t)il2cpp_codegen_add(L_0, 1));
	}

IL_0008:
	{
		// while ((value >>= 1) != 0)
		uint64_t L_1 = ___value0;
		int64_t L_2 = ((int64_t)((uint64_t)L_1>>1));
		___value0 = L_2;
		if (L_2)
		{
			goto IL_0004;
		}
	}
	{
		// return bits;
		int32_t L_3 = V_0;
		return L_3;
	}
}
// System.Int32 Lidgren.Network.NetUtility::BytesToHoldBits(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t NetUtility_BytesToHoldBits_m2258437C17102F82709C0FAEE252BD29E8DAFF35 (int32_t ___numBits0, const RuntimeMethod* method) 
{
{
		// return (numBits + 7) / 8;
		int32_t L_0 = ___numBits0;
		return ((int32_t)(((int32_t)il2cpp_codegen_add(L_0, 7))/8));
	}
}
// System.UInt32 Lidgren.Network.NetUtility::SwapByteOrder(System.UInt32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR uint32_t NetUtility_SwapByteOrder_m24E08E5C63F4AC8C5E29CEFD76D92A4DCE398BA7 (uint32_t ___value0, const RuntimeMethod* method) 
{
{
		// return
		//     ((value & 0xff000000) >> 24) |
		//     ((value & 0x00ff0000) >> 8) |
		//     ((value & 0x0000ff00) << 8) |
		//     ((value & 0x000000ff) << 24);
		uint32_t L_0 = ___value0;
		uint32_t L_1 = ___value0;
		uint32_t L_2 = ___value0;
		uint32_t L_3 = ___value0;
		return ((int32_t)(((int32_t)(((int32_t)(((int32_t)((uint32_t)((int32_t)((int32_t)L_0&((int32_t)-16777216)))>>((int32_t)24)))|((int32_t)((uint32_t)((int32_t)((int32_t)L_1&((int32_t)16711680)))>>8))))|((int32_t)(((int32_t)((int32_t)L_2&((int32_t)65280)))<<8))))|((int32_t)(((int32_t)((int32_t)L_3&((int32_t)255)))<<((int32_t)24)))));
	}
}
// System.UInt64 Lidgren.Network.NetUtility::SwapByteOrder(System.UInt64)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR uint64_t NetUtility_SwapByteOrder_mE2B014EE47C891CBFBDC435AF4C913377CCF4C40 (uint64_t ___value0, const RuntimeMethod* method) 
{
{
		// return
		//     ((value & 0xff00000000000000L) >> 56) |
		//     ((value & 0x00ff000000000000L) >> 40) |
		//     ((value & 0x0000ff0000000000L) >> 24) |
		//     ((value & 0x000000ff00000000L) >> 8) |
		//     ((value & 0x00000000ff000000L) << 8) |
		//     ((value & 0x0000000000ff0000L) << 24) |
		//     ((value & 0x000000000000ff00L) << 40) |
		//     ((value & 0x00000000000000ffL) << 56);
		uint64_t L_0 = ___value0;
		uint64_t L_1 = ___value0;
		uint64_t L_2 = ___value0;
		uint64_t L_3 = ___value0;
		uint64_t L_4 = ___value0;
		uint64_t L_5 = ___value0;
		uint64_t L_6 = ___value0;
		uint64_t L_7 = ___value0;
		return ((int64_t)(((int64_t)(((int64_t)(((int64_t)(((int64_t)(((int64_t)(((int64_t)(((int64_t)((uint64_t)((int64_t)((int64_t)L_0&((int64_t)-72057594037927936LL)))>>((int32_t)56)))|((int64_t)((uint64_t)((int64_t)((int64_t)L_1&((int64_t)71776119061217280LL)))>>((int32_t)40)))))|((int64_t)((uint64_t)((int64_t)((int64_t)L_2&((int64_t)280375465082880LL)))>>((int32_t)24)))))|((int64_t)((uint64_t)((int64_t)((int64_t)L_3&((int64_t)1095216660480LL)))>>8))))|((int64_t)(((int64_t)((int64_t)L_4&((int64_t)(uint64_t)((uint32_t)((int32_t)-16777216)))))<<8))))|((int64_t)(((int64_t)((int64_t)L_5&((int64_t)((int32_t)16711680))))<<((int32_t)24)))))|((int64_t)(((int64_t)((int64_t)L_6&((int64_t)((int32_t)65280))))<<((int32_t)40)))))|((int64_t)(((int64_t)((int64_t)L_7&((int64_t)((int32_t)255))))<<((int32_t)56)))));
	}
}
// System.Boolean Lidgren.Network.NetUtility::CompareElements(System.Byte[],System.Byte[])
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool NetUtility_CompareElements_m977006D0C765A8856AB2B5A856D3A69248F536E6 (ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* ___one0, ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* ___two1, const RuntimeMethod* method) 
{
int32_t V_0 = 0;
	{
		// if (one.Length != two.Length)
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_0 = ___one0;
		NullCheck(L_0);
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_1 = ___two1;
		NullCheck(L_1);
		if ((((int32_t)((int32_t)(((RuntimeArray*)L_0)->max_length))) == ((int32_t)((int32_t)(((RuntimeArray*)L_1)->max_length)))))
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
		// for (int i = 0; i < one.Length; i++)
		V_0 = 0;
		goto IL_001c;
	}

IL_000e:
	{
		// if (one[i] != two[i])
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_2 = ___one0;
		int32_t L_3 = V_0;
		NullCheck(L_2);
		int32_t L_4 = L_3;
		uint8_t L_5 = (L_2)->GetAt(static_cast<il2cpp_array_size_t>(L_4));
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_6 = ___two1;
		int32_t L_7 = V_0;
		NullCheck(L_6);
		int32_t L_8 = L_7;
		uint8_t L_9 = (L_6)->GetAt(static_cast<il2cpp_array_size_t>(L_8));
		if ((((int32_t)L_5) == ((int32_t)L_9)))
		{
			goto IL_0018;
		}
	}
	{
		// return false;
		return (bool)0;
	}

IL_0018:
	{
		// for (int i = 0; i < one.Length; i++)
		int32_t L_10 = V_0;
		V_0 = ((int32_t)il2cpp_codegen_add(L_10, 1));
	}

IL_001c:
	{
		// for (int i = 0; i < one.Length; i++)
		int32_t L_11 = V_0;
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_12 = ___one0;
		NullCheck(L_12);
		if ((((int32_t)L_11) < ((int32_t)((int32_t)(((RuntimeArray*)L_12)->max_length)))))
		{
			goto IL_000e;
		}
	}
	{
		// return true;
		return (bool)1;
	}
}
// System.Byte[] Lidgren.Network.NetUtility::ToByteArray(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* NetUtility_ToByteArray_mF9C5C8DB9AB7C82FCE421683EE0FFAFF51510EA8 (String_t* ___hexString0, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Convert_t7097FF336D592F7C06D88A98349A44646F91EFFC_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* V_0 = NULL;
	int32_t V_1 = 0;
	{
		// byte[] retval = new byte[hexString.Length / 2];
		String_t* L_0 = ___hexString0;
		NullCheck(L_0);
		int32_t L_1;
		L_1 = String_get_Length_m42625D67623FA5CC7A44D47425CE86FB946542D2_inline(L_0, NULL);
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_2 = (ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031*)(ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031*)SZArrayNew(ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031_il2cpp_TypeInfo_var, (uint32_t)((int32_t)(L_1/2)));
		V_0 = L_2;
		// for (int i = 0; i < hexString.Length; i += 2)
		V_1 = 0;
		goto IL_002a;
	}

IL_0012:
	{
		// retval[i / 2] = Convert.ToByte(hexString.Substring(i, 2), 16);
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_3 = V_0;
		int32_t L_4 = V_1;
		String_t* L_5 = ___hexString0;
		int32_t L_6 = V_1;
		NullCheck(L_5);
		String_t* L_7;
		L_7 = String_Substring_mB1D94F47935D22E130FF2C01DBB6A4135FBB76CE(L_5, L_6, 2, NULL);
		il2cpp_codegen_runtime_class_init_inline(Convert_t7097FF336D592F7C06D88A98349A44646F91EFFC_il2cpp_TypeInfo_var);
		uint8_t L_8;
		L_8 = Convert_ToByte_m200E739C754818844030F3E16CC31017926C853F(L_7, ((int32_t)16), NULL);
		NullCheck(L_3);
		(L_3)->SetAt(static_cast<il2cpp_array_size_t>(((int32_t)(L_4/2))), (uint8_t)L_8);
		// for (int i = 0; i < hexString.Length; i += 2)
		int32_t L_9 = V_1;
		V_1 = ((int32_t)il2cpp_codegen_add(L_9, 2));
	}

IL_002a:
	{
		// for (int i = 0; i < hexString.Length; i += 2)
		int32_t L_10 = V_1;
		String_t* L_11 = ___hexString0;
		NullCheck(L_11);
		int32_t L_12;
		L_12 = String_get_Length_m42625D67623FA5CC7A44D47425CE86FB946542D2_inline(L_11, NULL);
		if ((((int32_t)L_10) < ((int32_t)L_12)))
		{
			goto IL_0012;
		}
	}
	{
		// return retval;
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_13 = V_0;
		return L_13;
	}
}
// System.String Lidgren.Network.NetUtility::ToHumanReadable(System.Int64)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* NetUtility_ToHumanReadable_m2EB2ED497DBC8A23728B234039303892880F9259 (int64_t ___bytes0, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Math_tEB65DE7CA8B083C412C969C92981C030865486CE_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral4586384AE33FFDAB4C9542726BF7EC462C46F8D1);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral9F954BE9FD9E999DA1677DADC6D2CAB27412A282);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralE876EC859F6B9C3D005838181FBD73930F2D8F22);
		s_Il2CppMethodInitialized = true;
	}
double V_0 = 0.0;
	{
		// if (bytes < 4000) // 1-4 kb is printed in bytes
		int64_t L_0 = ___bytes0;
		if ((((int64_t)L_0) >= ((int64_t)((int64_t)((int32_t)4000)))))
		{
			goto IL_001b;
		}
	}
	{
		// return bytes + " bytes";
		String_t* L_1;
		L_1 = Int64_ToString_m284E4E55662818E38654309A41C2B07CD436F36B((&___bytes0), NULL);
		String_t* L_2;
		L_2 = String_Concat_mAF2CE02CC0CB7460753D0A1A91CCF2B1E9804C5D(L_1, _stringLiteral9F954BE9FD9E999DA1677DADC6D2CAB27412A282, NULL);
		return L_2;
	}

IL_001b:
	{
		// if (bytes < 1000 * 1000) // 4-999 kb is printed in kb
		int64_t L_3 = ___bytes0;
		if ((((int64_t)L_3) >= ((int64_t)((int64_t)((int32_t)1000000)))))
		{
			goto IL_0049;
		}
	}
	{
		// return Math.Round(((double)bytes / 1000.0), 2) + " kilobytes";
		int64_t L_4 = ___bytes0;
		il2cpp_codegen_runtime_class_init_inline(Math_tEB65DE7CA8B083C412C969C92981C030865486CE_il2cpp_TypeInfo_var);
		double L_5;
		L_5 = Math_Round_mAE7072AE69091258FAA8BD5923CE4A0E492B5B7D_inline(((double)(((double)L_4)/(1000.0))), 2, NULL);
		V_0 = L_5;
		String_t* L_6;
		L_6 = Double_ToString_m7499A5D792419537DCB9470A3675CEF5117DE339((&V_0), NULL);
		String_t* L_7;
		L_7 = String_Concat_mAF2CE02CC0CB7460753D0A1A91CCF2B1E9804C5D(L_6, _stringLiteralE876EC859F6B9C3D005838181FBD73930F2D8F22, NULL);
		return L_7;
	}

IL_0049:
	{
		// return Math.Round(((double)bytes / (1000.0 * 1000.0)), 2) + " megabytes"; // else megabytes
		int64_t L_8 = ___bytes0;
		il2cpp_codegen_runtime_class_init_inline(Math_tEB65DE7CA8B083C412C969C92981C030865486CE_il2cpp_TypeInfo_var);
		double L_9;
		L_9 = Math_Round_mAE7072AE69091258FAA8BD5923CE4A0E492B5B7D_inline(((double)(((double)L_8)/(1000000.0))), 2, NULL);
		V_0 = L_9;
		String_t* L_10;
		L_10 = Double_ToString_m7499A5D792419537DCB9470A3675CEF5117DE339((&V_0), NULL);
		String_t* L_11;
		L_11 = String_Concat_mAF2CE02CC0CB7460753D0A1A91CCF2B1E9804C5D(L_10, _stringLiteral4586384AE33FFDAB4C9542726BF7EC462C46F8D1, NULL);
		return L_11;
	}
}
// System.Int32 Lidgren.Network.NetUtility::RelativeSequenceNumber(System.Int32,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t NetUtility_RelativeSequenceNumber_m5DE5D4F0FE867CF19738194E727E1437A81B69B7 (int32_t ___nr0, int32_t ___expected1, const RuntimeMethod* method) 
{
{
		// return (nr - expected + NetConstants.NumSequenceNumbers + (NetConstants.NumSequenceNumbers / 2)) % NetConstants.NumSequenceNumbers - (NetConstants.NumSequenceNumbers / 2);
		int32_t L_0 = ___nr0;
		int32_t L_1 = ___expected1;
		return ((int32_t)il2cpp_codegen_subtract(((int32_t)(((int32_t)il2cpp_codegen_add(((int32_t)il2cpp_codegen_add(((int32_t)il2cpp_codegen_subtract(L_0, L_1)), ((int32_t)1024))), ((int32_t)512)))%((int32_t)1024))), ((int32_t)512)));
	}
}
// System.Int32 Lidgren.Network.NetUtility::GetWindowSize(Lidgren.Network.NetDeliveryMethod)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t NetUtility_GetWindowSize_mE773277DAE62C09BD601426434340B14EF326D96 (uint8_t ___method0, const RuntimeMethod* method) 
{
{
		uint8_t L_0 = ___method0;
		if ((!(((uint32_t)L_0) <= ((uint32_t)2))))
		{
			goto IL_000f;
		}
	}
	{
		uint8_t L_1 = ___method0;
		if (!L_1)
		{
			goto IL_001d;
		}
	}
	{
		uint8_t L_2 = ___method0;
		if ((!(((uint32_t)((int32_t)il2cpp_codegen_subtract((int32_t)L_2, 1))) > ((uint32_t)1))))
		{
			goto IL_001f;
		}
	}
	{
		goto IL_0028;
	}

IL_000f:
	{
		uint8_t L_3 = ___method0;
		if ((!(((uint32_t)((int32_t)il2cpp_codegen_subtract((int32_t)L_3, ((int32_t)34)))) > ((uint32_t)1))))
		{
			goto IL_0028;
		}
	}
	{
		uint8_t L_4 = ___method0;
		if ((((int32_t)L_4) == ((int32_t)((int32_t)67))))
		{
			goto IL_0025;
		}
	}
	{
		goto IL_0028;
	}

IL_001d:
	{
		// return 0;
		return 0;
	}

IL_001f:
	{
		// return NetConstants.UnreliableWindowSize;
		return ((int32_t)128);
	}

IL_0025:
	{
		// return NetConstants.ReliableOrderedWindowSize;
		return ((int32_t)64);
	}

IL_0028:
	{
		// return NetConstants.DefaultWindowSize;
		return ((int32_t)64);
	}
}
// System.Void Lidgren.Network.NetUtility::SortMembersList(System.Reflection.MemberInfo[])
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void NetUtility_SortMembersList_m777BF91CCD67FA368767ABCA7074B7FF2174E686 (MemberInfoU5BU5D_t4CB6970BB166E8E1CFB06152B2A2284971873053* ___list0, const RuntimeMethod* method) 
{
int32_t V_0 = 0;
	int32_t V_1 = 0;
	MemberInfo_t* V_2 = NULL;
	int32_t V_3 = 0;
	{
		// h = 1;
		V_0 = 1;
		goto IL_000a;
	}

IL_0004:
	{
		// h = 3 * h + 1;
		int32_t L_0 = V_0;
		V_0 = ((int32_t)il2cpp_codegen_add(((int32_t)il2cpp_codegen_multiply(3, L_0)), 1));
	}

IL_000a:
	{
		// while (h * 3 + 1 <= list.Length)
		int32_t L_1 = V_0;
		MemberInfoU5BU5D_t4CB6970BB166E8E1CFB06152B2A2284971873053* L_2 = ___list0;
		NullCheck(L_2);
		if ((((int32_t)((int32_t)il2cpp_codegen_add(((int32_t)il2cpp_codegen_multiply(L_1, 3)), 1))) <= ((int32_t)((int32_t)(((RuntimeArray*)L_2)->max_length)))))
		{
			goto IL_0004;
		}
	}
	{
		goto IL_005f;
	}

IL_0016:
	{
		// for (int i = h - 1; i < list.Length; i++)
		int32_t L_3 = V_0;
		V_3 = ((int32_t)il2cpp_codegen_subtract(L_3, 1));
		goto IL_0055;
	}

IL_001c:
	{
		// tmp = list[i];
		MemberInfoU5BU5D_t4CB6970BB166E8E1CFB06152B2A2284971873053* L_4 = ___list0;
		int32_t L_5 = V_3;
		NullCheck(L_4);
		int32_t L_6 = L_5;
		MemberInfo_t* L_7 = (L_4)->GetAt(static_cast<il2cpp_array_size_t>(L_6));
		V_2 = L_7;
		// j = i;
		int32_t L_8 = V_3;
		V_1 = L_8;
	}

IL_0022:
	{
		// if (j >= h)
		int32_t L_9 = V_1;
		int32_t L_10 = V_0;
		if ((((int32_t)L_9) < ((int32_t)L_10)))
		{
			goto IL_004d;
		}
	}
	{
		// if (string.Compare(list[j - h].Name, tmp.Name, StringComparison.InvariantCulture) > 0)
		MemberInfoU5BU5D_t4CB6970BB166E8E1CFB06152B2A2284971873053* L_11 = ___list0;
		int32_t L_12 = V_1;
		int32_t L_13 = V_0;
		NullCheck(L_11);
		int32_t L_14 = ((int32_t)il2cpp_codegen_subtract(L_12, L_13));
		MemberInfo_t* L_15 = (L_11)->GetAt(static_cast<il2cpp_array_size_t>(L_14));
		NullCheck(L_15);
		String_t* L_16;
		L_16 = VirtualFuncInvoker0< String_t* >::Invoke(8 /* System.String System.Reflection.MemberInfo::get_Name() */, L_15);
		MemberInfo_t* L_17 = V_2;
		NullCheck(L_17);
		String_t* L_18;
		L_18 = VirtualFuncInvoker0< String_t* >::Invoke(8 /* System.String System.Reflection.MemberInfo::get_Name() */, L_17);
		int32_t L_19;
		L_19 = String_Compare_mC553A80AD870F5777F0E8B5E705B0205396B9D3E(L_16, L_18, 2, NULL);
		if ((((int32_t)L_19) <= ((int32_t)0)))
		{
			goto IL_004d;
		}
	}
	{
		// list[j] = list[j - h];
		MemberInfoU5BU5D_t4CB6970BB166E8E1CFB06152B2A2284971873053* L_20 = ___list0;
		int32_t L_21 = V_1;
		MemberInfoU5BU5D_t4CB6970BB166E8E1CFB06152B2A2284971873053* L_22 = ___list0;
		int32_t L_23 = V_1;
		int32_t L_24 = V_0;
		NullCheck(L_22);
		int32_t L_25 = ((int32_t)il2cpp_codegen_subtract(L_23, L_24));
		MemberInfo_t* L_26 = (L_22)->GetAt(static_cast<il2cpp_array_size_t>(L_25));
		NullCheck(L_20);
		ArrayElementTypeCheck (L_20, L_26);
		(L_20)->SetAt(static_cast<il2cpp_array_size_t>(L_21), (MemberInfo_t*)L_26);
		// j -= h;
		int32_t L_27 = V_1;
		int32_t L_28 = V_0;
		V_1 = ((int32_t)il2cpp_codegen_subtract(L_27, L_28));
		goto IL_0022;
	}

IL_004d:
	{
		// list[j] = tmp;
		MemberInfoU5BU5D_t4CB6970BB166E8E1CFB06152B2A2284971873053* L_29 = ___list0;
		int32_t L_30 = V_1;
		MemberInfo_t* L_31 = V_2;
		NullCheck(L_29);
		ArrayElementTypeCheck (L_29, L_31);
		(L_29)->SetAt(static_cast<il2cpp_array_size_t>(L_30), (MemberInfo_t*)L_31);
		// for (int i = h - 1; i < list.Length; i++)
		int32_t L_32 = V_3;
		V_3 = ((int32_t)il2cpp_codegen_add(L_32, 1));
	}

IL_0055:
	{
		// for (int i = h - 1; i < list.Length; i++)
		int32_t L_33 = V_3;
		MemberInfoU5BU5D_t4CB6970BB166E8E1CFB06152B2A2284971873053* L_34 = ___list0;
		NullCheck(L_34);
		if ((((int32_t)L_33) < ((int32_t)((int32_t)(((RuntimeArray*)L_34)->max_length)))))
		{
			goto IL_001c;
		}
	}
	{
		// h /= 3;
		int32_t L_35 = V_0;
		V_0 = ((int32_t)(L_35/3));
	}

IL_005f:
	{
		// while (h > 0)
		int32_t L_36 = V_0;
		if ((((int32_t)L_36) > ((int32_t)0)))
		{
			goto IL_0016;
		}
	}
	{
		// }
		return;
	}
}
// Lidgren.Network.NetDeliveryMethod Lidgren.Network.NetUtility::GetDeliveryMethod(Lidgren.Network.NetMessageType)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR uint8_t NetUtility_GetDeliveryMethod_mF3833B64F87DF4AD37A3D18F3271E9DC9F896088 (uint8_t ___mtp0, const RuntimeMethod* method) 
{
{
		// if (mtp >= NetMessageType.UserReliableOrdered1)
		uint8_t L_0 = ___mtp0;
		if ((((int32_t)L_0) < ((int32_t)((int32_t)67))))
		{
			goto IL_0008;
		}
	}
	{
		// return NetDeliveryMethod.ReliableOrdered;
		return (uint8_t)(((int32_t)67));
	}

IL_0008:
	{
		// else if (mtp >= NetMessageType.UserReliableSequenced1)
		uint8_t L_1 = ___mtp0;
		if ((((int32_t)L_1) < ((int32_t)((int32_t)35))))
		{
			goto IL_0010;
		}
	}
	{
		// return NetDeliveryMethod.ReliableSequenced;
		return (uint8_t)(((int32_t)35));
	}

IL_0010:
	{
		// else if (mtp >= NetMessageType.UserReliableUnordered)
		uint8_t L_2 = ___mtp0;
		if ((((int32_t)L_2) < ((int32_t)((int32_t)34))))
		{
			goto IL_0018;
		}
	}
	{
		// return NetDeliveryMethod.ReliableUnordered;
		return (uint8_t)(((int32_t)34));
	}

IL_0018:
	{
		// else if (mtp >= NetMessageType.UserSequenced1)
		uint8_t L_3 = ___mtp0;
		if ((((int32_t)L_3) < ((int32_t)2)))
		{
			goto IL_001e;
		}
	}
	{
		// return NetDeliveryMethod.UnreliableSequenced;
		return (uint8_t)(2);
	}

IL_001e:
	{
		// return NetDeliveryMethod.Unreliable;
		return (uint8_t)(1);
	}
}
// System.Byte[] Lidgren.Network.NetUtility::ComputeSHAHash(System.Byte[])
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* NetUtility_ComputeSHAHash_mF0A369753E62EEE4E771C5638C1CB620D0CA48AD (ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* ___bytes0, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&NetUtility_t0B01E9514810CE3FC3B5E83D8427CBA1C5689EFD_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
{
		// return ComputeSHAHash(bytes, 0, bytes.Length);
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_0 = ___bytes0;
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_1 = ___bytes0;
		NullCheck(L_1);
		il2cpp_codegen_runtime_class_init_inline(NetUtility_t0B01E9514810CE3FC3B5E83D8427CBA1C5689EFD_il2cpp_TypeInfo_var);
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_2;
		L_2 = NetUtility_ComputeSHAHash_m72E631ED319081A04FA5BD0EB7F2AB9C072A177F(L_0, 0, ((int32_t)(((RuntimeArray*)L_1)->max_length)), NULL);
		return L_2;
	}
}
// System.Void Lidgren.Network.NetUtility::CopyEndpoint(System.Net.IPEndPoint,System.Net.IPEndPoint)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void NetUtility_CopyEndpoint_m04DF55981AD1A6C9C6330A9AA5C0D562638B2E82 (IPEndPoint_t2F09CBA7A808B67724B4E2954EEDC46D910F4ECB* ___src0, IPEndPoint_t2F09CBA7A808B67724B4E2954EEDC46D910F4ECB* ___dst1, const RuntimeMethod* method) 
{
{
		// dst.Port = src.Port;
		IPEndPoint_t2F09CBA7A808B67724B4E2954EEDC46D910F4ECB* L_0 = ___dst1;
		IPEndPoint_t2F09CBA7A808B67724B4E2954EEDC46D910F4ECB* L_1 = ___src0;
		NullCheck(L_1);
		int32_t L_2;
		L_2 = IPEndPoint_get_Port_mFBE1AF1C9CC7E68A46BF46AD3869CC9DC01CF429_inline(L_1, NULL);
		NullCheck(L_0);
		IPEndPoint_set_Port_m863E796C26AFF6CEACC4A8381E1B9CA2B78F41C4(L_0, L_2, NULL);
		// if (src.AddressFamily == AddressFamily.InterNetwork)
		IPEndPoint_t2F09CBA7A808B67724B4E2954EEDC46D910F4ECB* L_3 = ___src0;
		NullCheck(L_3);
		int32_t L_4;
		L_4 = VirtualFuncInvoker0< int32_t >::Invoke(4 /* System.Net.Sockets.AddressFamily System.Net.EndPoint::get_AddressFamily() */, L_3);
		if ((!(((uint32_t)L_4) == ((uint32_t)2))))
		{
			goto IL_0027;
		}
	}
	{
		// dst.Address = src.Address.MapToIPv6();
		IPEndPoint_t2F09CBA7A808B67724B4E2954EEDC46D910F4ECB* L_5 = ___dst1;
		IPEndPoint_t2F09CBA7A808B67724B4E2954EEDC46D910F4ECB* L_6 = ___src0;
		NullCheck(L_6);
		IPAddress_t2F4486449B0D73FF2D3B36A9FE5E9C3F63116484* L_7;
		L_7 = IPEndPoint_get_Address_m72F783CB76E10E9DBDF680CCC1DAAED201BABB1C_inline(L_6, NULL);
		NullCheck(L_7);
		IPAddress_t2F4486449B0D73FF2D3B36A9FE5E9C3F63116484* L_8;
		L_8 = IPAddress_MapToIPv6_m3D243981B6A8235516A4D8A68FC555B59675DE33(L_7, NULL);
		NullCheck(L_5);
		IPEndPoint_set_Address_m48F0D8096D02B90890E453ECF1616B78BB97CF63_inline(L_5, L_8, NULL);
		return;
	}

IL_0027:
	{
		// dst.Address = src.Address;
		IPEndPoint_t2F09CBA7A808B67724B4E2954EEDC46D910F4ECB* L_9 = ___dst1;
		IPEndPoint_t2F09CBA7A808B67724B4E2954EEDC46D910F4ECB* L_10 = ___src0;
		NullCheck(L_10);
		IPAddress_t2F4486449B0D73FF2D3B36A9FE5E9C3F63116484* L_11;
		L_11 = IPEndPoint_get_Address_m72F783CB76E10E9DBDF680CCC1DAAED201BABB1C_inline(L_10, NULL);
		NullCheck(L_9);
		IPEndPoint_set_Address_m48F0D8096D02B90890E453ECF1616B78BB97CF63_inline(L_9, L_11, NULL);
		// }
		return;
	}
}
// System.Net.IPEndPoint Lidgren.Network.NetUtility::MapToIPv6(System.Net.IPEndPoint)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR IPEndPoint_t2F09CBA7A808B67724B4E2954EEDC46D910F4ECB* NetUtility_MapToIPv6_mDE7A0D670EC9C46B68C9C9C0AA24274F77A962A4 (IPEndPoint_t2F09CBA7A808B67724B4E2954EEDC46D910F4ECB* ___endPoint0, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IPEndPoint_t2F09CBA7A808B67724B4E2954EEDC46D910F4ECB_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
{
		// if (endPoint.AddressFamily == AddressFamily.InterNetwork)
		IPEndPoint_t2F09CBA7A808B67724B4E2954EEDC46D910F4ECB* L_0 = ___endPoint0;
		NullCheck(L_0);
		int32_t L_1;
		L_1 = VirtualFuncInvoker0< int32_t >::Invoke(4 /* System.Net.Sockets.AddressFamily System.Net.EndPoint::get_AddressFamily() */, L_0);
		if ((!(((uint32_t)L_1) == ((uint32_t)2))))
		{
			goto IL_0020;
		}
	}
	{
		// return new IPEndPoint(endPoint.Address.MapToIPv6(), endPoint.Port);
		IPEndPoint_t2F09CBA7A808B67724B4E2954EEDC46D910F4ECB* L_2 = ___endPoint0;
		NullCheck(L_2);
		IPAddress_t2F4486449B0D73FF2D3B36A9FE5E9C3F63116484* L_3;
		L_3 = IPEndPoint_get_Address_m72F783CB76E10E9DBDF680CCC1DAAED201BABB1C_inline(L_2, NULL);
		NullCheck(L_3);
		IPAddress_t2F4486449B0D73FF2D3B36A9FE5E9C3F63116484* L_4;
		L_4 = IPAddress_MapToIPv6_m3D243981B6A8235516A4D8A68FC555B59675DE33(L_3, NULL);
		IPEndPoint_t2F09CBA7A808B67724B4E2954EEDC46D910F4ECB* L_5 = ___endPoint0;
		NullCheck(L_5);
		int32_t L_6;
		L_6 = IPEndPoint_get_Port_mFBE1AF1C9CC7E68A46BF46AD3869CC9DC01CF429_inline(L_5, NULL);
		IPEndPoint_t2F09CBA7A808B67724B4E2954EEDC46D910F4ECB* L_7 = (IPEndPoint_t2F09CBA7A808B67724B4E2954EEDC46D910F4ECB*)il2cpp_codegen_object_new(IPEndPoint_t2F09CBA7A808B67724B4E2954EEDC46D910F4ECB_il2cpp_TypeInfo_var);
		IPEndPoint__ctor_m902C98F9E3F36B20B3C2E030AA91B62E2BC7A85A(L_7, L_4, L_6, /*hidden argument*/NULL);
		return L_7;
	}

IL_0020:
	{
		// return endPoint;
		IPEndPoint_t2F09CBA7A808B67724B4E2954EEDC46D910F4ECB* L_8 = ___endPoint0;
		return L_8;
	}
}
// System.UInt64 Lidgren.Network.NetUtility::GetPlatformSeed(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR uint64_t NetUtility_GetPlatformSeed_m20045B31AFAF8B71FD6EE27BA9B05CE46AF9C32A (int32_t ___seedInc0, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Stopwatch_tA188A210449E22C07053A7D3014DD182C7369043_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
{
		// ulong seed = (ulong)System.Diagnostics.Stopwatch.GetTimestamp();
		il2cpp_codegen_runtime_class_init_inline(Stopwatch_tA188A210449E22C07053A7D3014DD182C7369043_il2cpp_TypeInfo_var);
		int64_t L_0;
		L_0 = Stopwatch_GetTimestamp_mD6D582A3E30369F05C829A5650BE2AE511EC807F(NULL);
		// return seed ^ ((ulong)Environment.WorkingSet + (ulong)seedInc);
		int64_t L_1;
		L_1 = Environment_get_WorkingSet_mF0C2C1AEFEF1BD1A92FBFB932964BD38A4E7968B(NULL);
		int32_t L_2 = ___seedInc0;
		return ((int64_t)(L_0^((int64_t)il2cpp_codegen_add(L_1, ((int64_t)L_2)))));
	}
}
// System.Double Lidgren.Network.NetUtility::get_Now()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR double NetUtility_get_Now_m9DE58F5FB397B6EE9ACA63701CC2F745C6850DFA (const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&NetUtility_t0B01E9514810CE3FC3B5E83D8427CBA1C5689EFD_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Stopwatch_tA188A210449E22C07053A7D3014DD182C7369043_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
{
		// public static double Now { get { return (double)(Stopwatch.GetTimestamp() - s_timeInitialized) * s_dInvFreq; } }
		il2cpp_codegen_runtime_class_init_inline(Stopwatch_tA188A210449E22C07053A7D3014DD182C7369043_il2cpp_TypeInfo_var);
		int64_t L_0;
		L_0 = Stopwatch_GetTimestamp_mD6D582A3E30369F05C829A5650BE2AE511EC807F(NULL);
		il2cpp_codegen_runtime_class_init_inline(NetUtility_t0B01E9514810CE3FC3B5E83D8427CBA1C5689EFD_il2cpp_TypeInfo_var);
		int64_t L_1 = ((NetUtility_t0B01E9514810CE3FC3B5E83D8427CBA1C5689EFD_StaticFields*)il2cpp_codegen_static_fields_for(NetUtility_t0B01E9514810CE3FC3B5E83D8427CBA1C5689EFD_il2cpp_TypeInfo_var))->___s_timeInitialized_2;
		double L_2 = ((NetUtility_t0B01E9514810CE3FC3B5E83D8427CBA1C5689EFD_StaticFields*)il2cpp_codegen_static_fields_for(NetUtility_t0B01E9514810CE3FC3B5E83D8427CBA1C5689EFD_il2cpp_TypeInfo_var))->___s_dInvFreq_3;
		return ((double)il2cpp_codegen_multiply(((double)((int64_t)il2cpp_codegen_subtract(L_0, L_1))), L_2));
	}
}
// System.Net.NetworkInformation.NetworkInterface Lidgren.Network.NetUtility::GetNetworkInterface()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR NetworkInterface_t3E7DDFADB8912D0F9D001D1195EBD0FB08B7F47A* NetUtility_GetNetworkInterface_mB294A5009A018B95BBFD95D0A3ED2B457AA50E06 (const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IDisposable_t030E0496B4E0E4E4F086825007979AF51F7248C5_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IEnumerator_1_tA218C3658C89562941B7435E73E48E2EDC26D9BD_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IEnumerator_t7B609C2FFA6EB5167D9C62A0C32A21DE2F666DAA_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
NetworkInterfaceU5BU5D_t62783E27F1C4A989B118CDBBE2FCBE65EE5CA080* V_0 = NULL;
	NetworkInterface_t3E7DDFADB8912D0F9D001D1195EBD0FB08B7F47A* V_1 = NULL;
	NetworkInterfaceU5BU5D_t62783E27F1C4A989B118CDBBE2FCBE65EE5CA080* V_2 = NULL;
	int32_t V_3 = 0;
	NetworkInterface_t3E7DDFADB8912D0F9D001D1195EBD0FB08B7F47A* V_4 = NULL;
	RuntimeObject* V_5 = NULL;
	UnicastIPAddressInformation_t4ACCADE9FBC1F8243A602439C94301E2C30295F3* V_6 = NULL;
	NetworkInterface_t3E7DDFADB8912D0F9D001D1195EBD0FB08B7F47A* V_7 = NULL;
	{
		// var computerProperties = IPGlobalProperties.GetIPGlobalProperties();
		IPGlobalProperties_tA6F98E3AAD35DD4C6BF821152D3D7B092C80C26D* L_0;
		L_0 = IPGlobalProperties_GetIPGlobalProperties_m78B851B32A1D963CC616CCA6DC7116F5EAC15753(NULL);
		// if (computerProperties == null)
		if (L_0)
		{
			goto IL_0009;
		}
	}
	{
		// return null;
		return (NetworkInterface_t3E7DDFADB8912D0F9D001D1195EBD0FB08B7F47A*)NULL;
	}

IL_0009:
	{
		// var nics = NetworkInterface.GetAllNetworkInterfaces();
		NetworkInterfaceU5BU5D_t62783E27F1C4A989B118CDBBE2FCBE65EE5CA080* L_1;
		L_1 = NetworkInterface_GetAllNetworkInterfaces_mD3638D31C8C05E882CE28542D17821C95FCABE9D(NULL);
		V_0 = L_1;
		// if (nics == null || nics.Length < 1)
		NetworkInterfaceU5BU5D_t62783E27F1C4A989B118CDBBE2FCBE65EE5CA080* L_2 = V_0;
		if (!L_2)
		{
			goto IL_0018;
		}
	}
	{
		NetworkInterfaceU5BU5D_t62783E27F1C4A989B118CDBBE2FCBE65EE5CA080* L_3 = V_0;
		NullCheck(L_3);
		if ((((int32_t)((int32_t)(((RuntimeArray*)L_3)->max_length))) >= ((int32_t)1)))
		{
			goto IL_001a;
		}
	}

IL_0018:
	{
		// return null;
		return (NetworkInterface_t3E7DDFADB8912D0F9D001D1195EBD0FB08B7F47A*)NULL;
	}

IL_001a:
	{
		// NetworkInterface best = null;
		V_1 = (NetworkInterface_t3E7DDFADB8912D0F9D001D1195EBD0FB08B7F47A*)NULL;
		// foreach (NetworkInterface adapter in nics)
		NetworkInterfaceU5BU5D_t62783E27F1C4A989B118CDBBE2FCBE65EE5CA080* L_4 = V_0;
		V_2 = L_4;
		V_3 = 0;
		goto IL_00b4;
	}

IL_0025:
	{
		// foreach (NetworkInterface adapter in nics)
		NetworkInterfaceU5BU5D_t62783E27F1C4A989B118CDBBE2FCBE65EE5CA080* L_5 = V_2;
		int32_t L_6 = V_3;
		NullCheck(L_5);
		int32_t L_7 = L_6;
		NetworkInterface_t3E7DDFADB8912D0F9D001D1195EBD0FB08B7F47A* L_8 = (L_5)->GetAt(static_cast<il2cpp_array_size_t>(L_7));
		V_4 = L_8;
		// if (adapter.NetworkInterfaceType == NetworkInterfaceType.Loopback || adapter.NetworkInterfaceType == NetworkInterfaceType.Unknown)
		NetworkInterface_t3E7DDFADB8912D0F9D001D1195EBD0FB08B7F47A* L_9 = V_4;
		NullCheck(L_9);
		int32_t L_10;
		L_10 = VirtualFuncInvoker0< int32_t >::Invoke(7 /* System.Net.NetworkInformation.NetworkInterfaceType System.Net.NetworkInformation.NetworkInterface::get_NetworkInterfaceType() */, L_9);
		if ((((int32_t)L_10) == ((int32_t)((int32_t)24))))
		{
			goto IL_00b0;
		}
	}
	{
		NetworkInterface_t3E7DDFADB8912D0F9D001D1195EBD0FB08B7F47A* L_11 = V_4;
		NullCheck(L_11);
		int32_t L_12;
		L_12 = VirtualFuncInvoker0< int32_t >::Invoke(7 /* System.Net.NetworkInformation.NetworkInterfaceType System.Net.NetworkInformation.NetworkInterface::get_NetworkInterfaceType() */, L_11);
		if ((((int32_t)L_12) == ((int32_t)1)))
		{
			goto IL_00b0;
		}
	}
	{
		// if (!adapter.Supports(NetworkInterfaceComponent.IPv4))
		NetworkInterface_t3E7DDFADB8912D0F9D001D1195EBD0FB08B7F47A* L_13 = V_4;
		NullCheck(L_13);
		bool L_14;
		L_14 = VirtualFuncInvoker1< bool, int32_t >::Invoke(8 /* System.Boolean System.Net.NetworkInformation.NetworkInterface::Supports(System.Net.NetworkInformation.NetworkInterfaceComponent) */, L_13, 0);
		if (!L_14)
		{
			goto IL_00b0;
		}
	}
	{
		// if (best == null)
		NetworkInterface_t3E7DDFADB8912D0F9D001D1195EBD0FB08B7F47A* L_15 = V_1;
		if (L_15)
		{
			goto IL_004f;
		}
	}
	{
		// best = adapter;
		NetworkInterface_t3E7DDFADB8912D0F9D001D1195EBD0FB08B7F47A* L_16 = V_4;
		V_1 = L_16;
	}

IL_004f:
	{
		// if (adapter.OperationalStatus != OperationalStatus.Up)
		NetworkInterface_t3E7DDFADB8912D0F9D001D1195EBD0FB08B7F47A* L_17 = V_4;
		NullCheck(L_17);
		int32_t L_18;
		L_18 = VirtualFuncInvoker0< int32_t >::Invoke(5 /* System.Net.NetworkInformation.OperationalStatus System.Net.NetworkInformation.NetworkInterface::get_OperationalStatus() */, L_17);
		if ((!(((uint32_t)L_18) == ((uint32_t)1))))
		{
			goto IL_00b0;
		}
	}
	{
		// IPInterfaceProperties properties = adapter.GetIPProperties();
		NetworkInterface_t3E7DDFADB8912D0F9D001D1195EBD0FB08B7F47A* L_19 = V_4;
		NullCheck(L_19);
		IPInterfaceProperties_t60A00D504E4F72CAFE4C0AE4DA6A062B44D1512F* L_20;
		L_20 = VirtualFuncInvoker0< IPInterfaceProperties_t60A00D504E4F72CAFE4C0AE4DA6A062B44D1512F* >::Invoke(4 /* System.Net.NetworkInformation.IPInterfaceProperties System.Net.NetworkInformation.NetworkInterface::GetIPProperties() */, L_19);
		// foreach (UnicastIPAddressInformation unicastAddress in properties.UnicastAddresses)
		NullCheck(L_20);
		UnicastIPAddressInformationCollection_tB4D61C9127DFB4168CA3855020CCEB59B75C6EDA* L_21;
		L_21 = VirtualFuncInvoker0< UnicastIPAddressInformationCollection_tB4D61C9127DFB4168CA3855020CCEB59B75C6EDA* >::Invoke(4 /* System.Net.NetworkInformation.UnicastIPAddressInformationCollection System.Net.NetworkInformation.IPInterfaceProperties::get_UnicastAddresses() */, L_20);
		NullCheck(L_21);
		RuntimeObject* L_22;
		L_22 = VirtualFuncInvoker0< RuntimeObject* >::Invoke(18 /* System.Collections.Generic.IEnumerator`1<System.Net.NetworkInformation.UnicastIPAddressInformation> System.Net.NetworkInformation.UnicastIPAddressInformationCollection::GetEnumerator() */, L_21);
		V_5 = L_22;
	}

IL_006c:
	{
		auto __finallyBlock = il2cpp::utils::Finally([&]
		{

FINALLY_00a4:
			{// begin finally (depth: 1)
				{
					RuntimeObject* L_23 = V_5;
					if (!L_23)
					{
						goto IL_00af;
					}
				}

IL_00a8:
				{
					RuntimeObject* L_24 = V_5;
					NullCheck(L_24);
					InterfaceActionInvoker0::Invoke(0 /* System.Void System.IDisposable::Dispose() */, IDisposable_t030E0496B4E0E4E4F086825007979AF51F7248C5_il2cpp_TypeInfo_var, L_24);
				}

IL_00af:
				{
					return;
				}
			}// end finally (depth: 1)
		});
		try
		{// begin try (depth: 1)
			{
				goto IL_0099;
			}

IL_006e:
			{
				// foreach (UnicastIPAddressInformation unicastAddress in properties.UnicastAddresses)
				RuntimeObject* L_25 = V_5;
				NullCheck(L_25);
				UnicastIPAddressInformation_t4ACCADE9FBC1F8243A602439C94301E2C30295F3* L_26;
				L_26 = InterfaceFuncInvoker0< UnicastIPAddressInformation_t4ACCADE9FBC1F8243A602439C94301E2C30295F3* >::Invoke(0 /* T System.Collections.Generic.IEnumerator`1<System.Net.NetworkInformation.UnicastIPAddressInformation>::get_Current() */, IEnumerator_1_tA218C3658C89562941B7435E73E48E2EDC26D9BD_il2cpp_TypeInfo_var, L_25);
				V_6 = L_26;
				// if (unicastAddress != null && unicastAddress.Address != null && unicastAddress.Address.AddressFamily == AddressFamily.InterNetwork)
				UnicastIPAddressInformation_t4ACCADE9FBC1F8243A602439C94301E2C30295F3* L_27 = V_6;
				if (!L_27)
				{
					goto IL_0099;
				}
			}

IL_007b:
			{
				UnicastIPAddressInformation_t4ACCADE9FBC1F8243A602439C94301E2C30295F3* L_28 = V_6;
				NullCheck(L_28);
				IPAddress_t2F4486449B0D73FF2D3B36A9FE5E9C3F63116484* L_29;
				L_29 = VirtualFuncInvoker0< IPAddress_t2F4486449B0D73FF2D3B36A9FE5E9C3F63116484* >::Invoke(4 /* System.Net.IPAddress System.Net.NetworkInformation.IPAddressInformation::get_Address() */, L_28);
				if (!L_29)
				{
					goto IL_0099;
				}
			}

IL_0084:
			{
				UnicastIPAddressInformation_t4ACCADE9FBC1F8243A602439C94301E2C30295F3* L_30 = V_6;
				NullCheck(L_30);
				IPAddress_t2F4486449B0D73FF2D3B36A9FE5E9C3F63116484* L_31;
				L_31 = VirtualFuncInvoker0< IPAddress_t2F4486449B0D73FF2D3B36A9FE5E9C3F63116484* >::Invoke(4 /* System.Net.IPAddress System.Net.NetworkInformation.IPAddressInformation::get_Address() */, L_30);
				NullCheck(L_31);
				int32_t L_32;
				L_32 = IPAddress_get_AddressFamily_m1CE4BCCE499BD70B22F9E37B3F266F9306A98C21(L_31, NULL);
				if ((!(((uint32_t)L_32) == ((uint32_t)2))))
				{
					goto IL_0099;
				}
			}

IL_0093:
			{
				// return adapter;
				NetworkInterface_t3E7DDFADB8912D0F9D001D1195EBD0FB08B7F47A* L_33 = V_4;
				V_7 = L_33;
				goto IL_00bf;
			}

IL_0099:
			{
				// foreach (UnicastIPAddressInformation unicastAddress in properties.UnicastAddresses)
				RuntimeObject* L_34 = V_5;
				NullCheck(L_34);
				bool L_35;
				L_35 = InterfaceFuncInvoker0< bool >::Invoke(0 /* System.Boolean System.Collections.IEnumerator::MoveNext() */, IEnumerator_t7B609C2FFA6EB5167D9C62A0C32A21DE2F666DAA_il2cpp_TypeInfo_var, L_34);
				if (L_35)
				{
					goto IL_006e;
				}
			}

IL_00a2:
			{
				goto IL_00b0;
			}
		}// end try (depth: 1)
		catch(Il2CppExceptionWrapper& e)
		{
			__finallyBlock.StoreException(e.ex);
		}
	}

IL_00b0:
	{
		int32_t L_36 = V_3;
		V_3 = ((int32_t)il2cpp_codegen_add(L_36, 1));
	}

IL_00b4:
	{
		// foreach (NetworkInterface adapter in nics)
		int32_t L_37 = V_3;
		NetworkInterfaceU5BU5D_t62783E27F1C4A989B118CDBBE2FCBE65EE5CA080* L_38 = V_2;
		NullCheck(L_38);
		if ((((int32_t)L_37) < ((int32_t)((int32_t)(((RuntimeArray*)L_38)->max_length)))))
		{
			goto IL_0025;
		}
	}
	{
		// return best;
		NetworkInterface_t3E7DDFADB8912D0F9D001D1195EBD0FB08B7F47A* L_39 = V_1;
		return L_39;
	}

IL_00bf:
	{
		// }
		NetworkInterface_t3E7DDFADB8912D0F9D001D1195EBD0FB08B7F47A* L_40 = V_7;
		return L_40;
	}
}
// System.Byte[] Lidgren.Network.NetUtility::GetMacAddressBytes()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* NetUtility_GetMacAddressBytes_mD5789396E392D19E71E8E29017F4B74F9F72B3A2 (const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&NetUtility_t0B01E9514810CE3FC3B5E83D8427CBA1C5689EFD_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
NetworkInterface_t3E7DDFADB8912D0F9D001D1195EBD0FB08B7F47A* V_0 = NULL;
	{
		// var ni = GetNetworkInterface();
		il2cpp_codegen_runtime_class_init_inline(NetUtility_t0B01E9514810CE3FC3B5E83D8427CBA1C5689EFD_il2cpp_TypeInfo_var);
		NetworkInterface_t3E7DDFADB8912D0F9D001D1195EBD0FB08B7F47A* L_0;
		L_0 = NetUtility_GetNetworkInterface_mB294A5009A018B95BBFD95D0A3ED2B457AA50E06(NULL);
		V_0 = L_0;
		// if (ni == null)
		NetworkInterface_t3E7DDFADB8912D0F9D001D1195EBD0FB08B7F47A* L_1 = V_0;
		if (L_1)
		{
			goto IL_000b;
		}
	}
	{
		// return null;
		return (ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031*)NULL;
	}

IL_000b:
	{
		// return ni.GetPhysicalAddress().GetAddressBytes();
		NetworkInterface_t3E7DDFADB8912D0F9D001D1195EBD0FB08B7F47A* L_2 = V_0;
		NullCheck(L_2);
		PhysicalAddress_tBD58CB2A171D8DEFF0C882DE988D2D446EF40DEB* L_3;
		L_3 = VirtualFuncInvoker0< PhysicalAddress_tBD58CB2A171D8DEFF0C882DE988D2D446EF40DEB* >::Invoke(6 /* System.Net.NetworkInformation.PhysicalAddress System.Net.NetworkInformation.NetworkInterface::GetPhysicalAddress() */, L_2);
		NullCheck(L_3);
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_4;
		L_4 = PhysicalAddress_GetAddressBytes_m580AD31C035F8FA177C2BBADF8196EBFAD400F1B(L_3, NULL);
		return L_4;
	}
}
// System.Net.IPAddress Lidgren.Network.NetUtility::GetBroadcastAddress()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR IPAddress_t2F4486449B0D73FF2D3B36A9FE5E9C3F63116484* NetUtility_GetBroadcastAddress_m69CC4AFCA51DE14371F00A5A25170739B1496935 (const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IDisposable_t030E0496B4E0E4E4F086825007979AF51F7248C5_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IEnumerator_1_tA218C3658C89562941B7435E73E48E2EDC26D9BD_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IEnumerator_t7B609C2FFA6EB5167D9C62A0C32A21DE2F666DAA_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IPAddress_t2F4486449B0D73FF2D3B36A9FE5E9C3F63116484_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&NetUtility_t0B01E9514810CE3FC3B5E83D8427CBA1C5689EFD_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
NetworkInterface_t3E7DDFADB8912D0F9D001D1195EBD0FB08B7F47A* V_0 = NULL;
	RuntimeObject* V_1 = NULL;
	UnicastIPAddressInformation_t4ACCADE9FBC1F8243A602439C94301E2C30295F3* V_2 = NULL;
	ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* V_3 = NULL;
	ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* V_4 = NULL;
	ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* V_5 = NULL;
	int32_t V_6 = 0;
	IPAddress_t2F4486449B0D73FF2D3B36A9FE5E9C3F63116484* V_7 = NULL;
	{
		// var ni = GetNetworkInterface();
		il2cpp_codegen_runtime_class_init_inline(NetUtility_t0B01E9514810CE3FC3B5E83D8427CBA1C5689EFD_il2cpp_TypeInfo_var);
		NetworkInterface_t3E7DDFADB8912D0F9D001D1195EBD0FB08B7F47A* L_0;
		L_0 = NetUtility_GetNetworkInterface_mB294A5009A018B95BBFD95D0A3ED2B457AA50E06(NULL);
		V_0 = L_0;
		// if (ni == null)
		NetworkInterface_t3E7DDFADB8912D0F9D001D1195EBD0FB08B7F47A* L_1 = V_0;
		if (L_1)
		{
			goto IL_000b;
		}
	}
	{
		// return null;
		return (IPAddress_t2F4486449B0D73FF2D3B36A9FE5E9C3F63116484*)NULL;
	}

IL_000b:
	{
		// var properties = ni.GetIPProperties();
		NetworkInterface_t3E7DDFADB8912D0F9D001D1195EBD0FB08B7F47A* L_2 = V_0;
		NullCheck(L_2);
		IPInterfaceProperties_t60A00D504E4F72CAFE4C0AE4DA6A062B44D1512F* L_3;
		L_3 = VirtualFuncInvoker0< IPInterfaceProperties_t60A00D504E4F72CAFE4C0AE4DA6A062B44D1512F* >::Invoke(4 /* System.Net.NetworkInformation.IPInterfaceProperties System.Net.NetworkInformation.NetworkInterface::GetIPProperties() */, L_2);
		// foreach (UnicastIPAddressInformation unicastAddress in properties.UnicastAddresses)
		NullCheck(L_3);
		UnicastIPAddressInformationCollection_tB4D61C9127DFB4168CA3855020CCEB59B75C6EDA* L_4;
		L_4 = VirtualFuncInvoker0< UnicastIPAddressInformationCollection_tB4D61C9127DFB4168CA3855020CCEB59B75C6EDA* >::Invoke(4 /* System.Net.NetworkInformation.UnicastIPAddressInformationCollection System.Net.NetworkInformation.IPInterfaceProperties::get_UnicastAddresses() */, L_3);
		NullCheck(L_4);
		RuntimeObject* L_5;
		L_5 = VirtualFuncInvoker0< RuntimeObject* >::Invoke(18 /* System.Collections.Generic.IEnumerator`1<System.Net.NetworkInformation.UnicastIPAddressInformation> System.Net.NetworkInformation.UnicastIPAddressInformationCollection::GetEnumerator() */, L_4);
		V_1 = L_5;
	}

IL_001c:
	{
		auto __finallyBlock = il2cpp::utils::Finally([&]
		{

FINALLY_00bc:
			{// begin finally (depth: 1)
				{
					RuntimeObject* L_6 = V_1;
					if (!L_6)
					{
						goto IL_00c5;
					}
				}

IL_00bf:
				{
					RuntimeObject* L_7 = V_1;
					NullCheck(L_7);
					InterfaceActionInvoker0::Invoke(0 /* System.Void System.IDisposable::Dispose() */, IDisposable_t030E0496B4E0E4E4F086825007979AF51F7248C5_il2cpp_TypeInfo_var, L_7);
				}

IL_00c5:
				{
					return;
				}
			}// end finally (depth: 1)
		});
		try
		{// begin try (depth: 1)
			{
				goto IL_00af;
			}

IL_0021:
			{
				// foreach (UnicastIPAddressInformation unicastAddress in properties.UnicastAddresses)
				RuntimeObject* L_8 = V_1;
				NullCheck(L_8);
				UnicastIPAddressInformation_t4ACCADE9FBC1F8243A602439C94301E2C30295F3* L_9;
				L_9 = InterfaceFuncInvoker0< UnicastIPAddressInformation_t4ACCADE9FBC1F8243A602439C94301E2C30295F3* >::Invoke(0 /* T System.Collections.Generic.IEnumerator`1<System.Net.NetworkInformation.UnicastIPAddressInformation>::get_Current() */, IEnumerator_1_tA218C3658C89562941B7435E73E48E2EDC26D9BD_il2cpp_TypeInfo_var, L_8);
				V_2 = L_9;
				// if (unicastAddress != null && unicastAddress.Address != null && unicastAddress.Address.AddressFamily == AddressFamily.InterNetwork)
				UnicastIPAddressInformation_t4ACCADE9FBC1F8243A602439C94301E2C30295F3* L_10 = V_2;
				if (!L_10)
				{
					goto IL_00af;
				}
			}

IL_002e:
			{
				UnicastIPAddressInformation_t4ACCADE9FBC1F8243A602439C94301E2C30295F3* L_11 = V_2;
				NullCheck(L_11);
				IPAddress_t2F4486449B0D73FF2D3B36A9FE5E9C3F63116484* L_12;
				L_12 = VirtualFuncInvoker0< IPAddress_t2F4486449B0D73FF2D3B36A9FE5E9C3F63116484* >::Invoke(4 /* System.Net.IPAddress System.Net.NetworkInformation.IPAddressInformation::get_Address() */, L_11);
				if (!L_12)
				{
					goto IL_00af;
				}
			}

IL_0036:
			{
				UnicastIPAddressInformation_t4ACCADE9FBC1F8243A602439C94301E2C30295F3* L_13 = V_2;
				NullCheck(L_13);
				IPAddress_t2F4486449B0D73FF2D3B36A9FE5E9C3F63116484* L_14;
				L_14 = VirtualFuncInvoker0< IPAddress_t2F4486449B0D73FF2D3B36A9FE5E9C3F63116484* >::Invoke(4 /* System.Net.IPAddress System.Net.NetworkInformation.IPAddressInformation::get_Address() */, L_13);
				NullCheck(L_14);
				int32_t L_15;
				L_15 = IPAddress_get_AddressFamily_m1CE4BCCE499BD70B22F9E37B3F266F9306A98C21(L_14, NULL);
				if ((!(((uint32_t)L_15) == ((uint32_t)2))))
				{
					goto IL_00af;
				}
			}

IL_0044:
			{
				// var mask = unicastAddress.IPv4Mask;
				UnicastIPAddressInformation_t4ACCADE9FBC1F8243A602439C94301E2C30295F3* L_16 = V_2;
				NullCheck(L_16);
				IPAddress_t2F4486449B0D73FF2D3B36A9FE5E9C3F63116484* L_17;
				L_17 = VirtualFuncInvoker0< IPAddress_t2F4486449B0D73FF2D3B36A9FE5E9C3F63116484* >::Invoke(5 /* System.Net.IPAddress System.Net.NetworkInformation.UnicastIPAddressInformation::get_IPv4Mask() */, L_16);
				// byte[] ipAdressBytes = unicastAddress.Address.GetAddressBytes();
				UnicastIPAddressInformation_t4ACCADE9FBC1F8243A602439C94301E2C30295F3* L_18 = V_2;
				NullCheck(L_18);
				IPAddress_t2F4486449B0D73FF2D3B36A9FE5E9C3F63116484* L_19;
				L_19 = VirtualFuncInvoker0< IPAddress_t2F4486449B0D73FF2D3B36A9FE5E9C3F63116484* >::Invoke(4 /* System.Net.IPAddress System.Net.NetworkInformation.IPAddressInformation::get_Address() */, L_18);
				NullCheck(L_19);
				ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_20;
				L_20 = IPAddress_GetAddressBytes_m1501E0143C791E3A065E508F5535D8E206652EC9(L_19, NULL);
				V_3 = L_20;
				// byte[] subnetMaskBytes = mask.GetAddressBytes();
				NullCheck(L_17);
				ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_21;
				L_21 = IPAddress_GetAddressBytes_m1501E0143C791E3A065E508F5535D8E206652EC9(L_17, NULL);
				V_4 = L_21;
				// if (ipAdressBytes.Length != subnetMaskBytes.Length)
				ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_22 = V_3;
				NullCheck(L_22);
				ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_23 = V_4;
				NullCheck(L_23);
				if ((((int32_t)((int32_t)(((RuntimeArray*)L_22)->max_length))) == ((int32_t)((int32_t)(((RuntimeArray*)L_23)->max_length)))))
				{
					goto IL_0071;
				}
			}

IL_0066:
			{
				// throw new ArgumentException("Lengths of IP address and subnet mask do not match.");
				ArgumentException_tAD90411542A20A9C72D5CDA3A84181D8B947A263* L_24 = (ArgumentException_tAD90411542A20A9C72D5CDA3A84181D8B947A263*)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&ArgumentException_tAD90411542A20A9C72D5CDA3A84181D8B947A263_il2cpp_TypeInfo_var)));
				ArgumentException__ctor_m026938A67AF9D36BB7ED27F80425D7194B514465(L_24, ((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteral9AB7AE2A6D393ADACFEBBBF239951E42C5ACA0E8)), /*hidden argument*/NULL);
				IL2CPP_RAISE_MANAGED_EXCEPTION(L_24, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&NetUtility_GetBroadcastAddress_m69CC4AFCA51DE14371F00A5A25170739B1496935_RuntimeMethod_var)));
			}

IL_0071:
			{
				// byte[] broadcastAddress = new byte[ipAdressBytes.Length];
				ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_25 = V_3;
				NullCheck(L_25);
				ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_26 = (ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031*)(ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031*)SZArrayNew(ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031_il2cpp_TypeInfo_var, (uint32_t)((int32_t)(((RuntimeArray*)L_25)->max_length)));
				V_5 = L_26;
				// for (int i = 0; i < broadcastAddress.Length; i++)
				V_6 = 0;
				goto IL_009c;
			}

IL_0080:
			{
				// broadcastAddress[i] = (byte)(ipAdressBytes[i] | (subnetMaskBytes[i] ^ 255));
				ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_27 = V_5;
				int32_t L_28 = V_6;
				ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_29 = V_3;
				int32_t L_30 = V_6;
				NullCheck(L_29);
				int32_t L_31 = L_30;
				uint8_t L_32 = (L_29)->GetAt(static_cast<il2cpp_array_size_t>(L_31));
				ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_33 = V_4;
				int32_t L_34 = V_6;
				NullCheck(L_33);
				int32_t L_35 = L_34;
				uint8_t L_36 = (L_33)->GetAt(static_cast<il2cpp_array_size_t>(L_35));
				NullCheck(L_27);
				(L_27)->SetAt(static_cast<il2cpp_array_size_t>(L_28), (uint8_t)((int32_t)(uint8_t)((int32_t)((int32_t)L_32|((int32_t)((int32_t)L_36^((int32_t)255)))))));
				// for (int i = 0; i < broadcastAddress.Length; i++)
				int32_t L_37 = V_6;
				V_6 = ((int32_t)il2cpp_codegen_add(L_37, 1));
			}

IL_009c:
			{
				// for (int i = 0; i < broadcastAddress.Length; i++)
				int32_t L_38 = V_6;
				ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_39 = V_5;
				NullCheck(L_39);
				if ((((int32_t)L_38) < ((int32_t)((int32_t)(((RuntimeArray*)L_39)->max_length)))))
				{
					goto IL_0080;
				}
			}

IL_00a4:
			{
				// return new IPAddress(broadcastAddress);
				ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_40 = V_5;
				IPAddress_t2F4486449B0D73FF2D3B36A9FE5E9C3F63116484* L_41 = (IPAddress_t2F4486449B0D73FF2D3B36A9FE5E9C3F63116484*)il2cpp_codegen_object_new(IPAddress_t2F4486449B0D73FF2D3B36A9FE5E9C3F63116484_il2cpp_TypeInfo_var);
				IPAddress__ctor_m01F2FA932B0D4C0B2E15C6C837E3C52DDF186964(L_41, L_40, /*hidden argument*/NULL);
				V_7 = L_41;
				goto IL_00cc;
			}

IL_00af:
			{
				// foreach (UnicastIPAddressInformation unicastAddress in properties.UnicastAddresses)
				RuntimeObject* L_42 = V_1;
				NullCheck(L_42);
				bool L_43;
				L_43 = InterfaceFuncInvoker0< bool >::Invoke(0 /* System.Boolean System.Collections.IEnumerator::MoveNext() */, IEnumerator_t7B609C2FFA6EB5167D9C62A0C32A21DE2F666DAA_il2cpp_TypeInfo_var, L_42);
				if (L_43)
				{
					goto IL_0021;
				}
			}

IL_00ba:
			{
				goto IL_00c6;
			}
		}// end try (depth: 1)
		catch(Il2CppExceptionWrapper& e)
		{
			__finallyBlock.StoreException(e.ex);
		}
	}

IL_00c6:
	{
		// return IPAddress.Broadcast;
		il2cpp_codegen_runtime_class_init_inline(IPAddress_t2F4486449B0D73FF2D3B36A9FE5E9C3F63116484_il2cpp_TypeInfo_var);
		IPAddress_t2F4486449B0D73FF2D3B36A9FE5E9C3F63116484* L_44 = ((IPAddress_t2F4486449B0D73FF2D3B36A9FE5E9C3F63116484_StaticFields*)il2cpp_codegen_static_fields_for(IPAddress_t2F4486449B0D73FF2D3B36A9FE5E9C3F63116484_il2cpp_TypeInfo_var))->___Broadcast_2;
		return L_44;
	}

IL_00cc:
	{
		// }
		IPAddress_t2F4486449B0D73FF2D3B36A9FE5E9C3F63116484* L_45 = V_7;
		return L_45;
	}
}
// System.Net.IPAddress Lidgren.Network.NetUtility::GetMyAddress(System.Net.IPAddress&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR IPAddress_t2F4486449B0D73FF2D3B36A9FE5E9C3F63116484* NetUtility_GetMyAddress_m3051AD9EA9B97026C0AD93C606B39B247759AD85 (IPAddress_t2F4486449B0D73FF2D3B36A9FE5E9C3F63116484** ___mask0, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IDisposable_t030E0496B4E0E4E4F086825007979AF51F7248C5_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IEnumerator_1_tA218C3658C89562941B7435E73E48E2EDC26D9BD_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IEnumerator_t7B609C2FFA6EB5167D9C62A0C32A21DE2F666DAA_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&NetUtility_t0B01E9514810CE3FC3B5E83D8427CBA1C5689EFD_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
NetworkInterface_t3E7DDFADB8912D0F9D001D1195EBD0FB08B7F47A* V_0 = NULL;
	RuntimeObject* V_1 = NULL;
	UnicastIPAddressInformation_t4ACCADE9FBC1F8243A602439C94301E2C30295F3* V_2 = NULL;
	IPAddress_t2F4486449B0D73FF2D3B36A9FE5E9C3F63116484* V_3 = NULL;
	{
		// var ni = GetNetworkInterface();
		il2cpp_codegen_runtime_class_init_inline(NetUtility_t0B01E9514810CE3FC3B5E83D8427CBA1C5689EFD_il2cpp_TypeInfo_var);
		NetworkInterface_t3E7DDFADB8912D0F9D001D1195EBD0FB08B7F47A* L_0;
		L_0 = NetUtility_GetNetworkInterface_mB294A5009A018B95BBFD95D0A3ED2B457AA50E06(NULL);
		V_0 = L_0;
		// if (ni == null)
		NetworkInterface_t3E7DDFADB8912D0F9D001D1195EBD0FB08B7F47A* L_1 = V_0;
		if (L_1)
		{
			goto IL_000e;
		}
	}
	{
		// mask = null;
		IPAddress_t2F4486449B0D73FF2D3B36A9FE5E9C3F63116484** L_2 = ___mask0;
		*((RuntimeObject**)L_2) = (RuntimeObject*)NULL;
		Il2CppCodeGenWriteBarrier((void**)(RuntimeObject**)L_2, (void*)(RuntimeObject*)NULL);
		// return null;
		return (IPAddress_t2F4486449B0D73FF2D3B36A9FE5E9C3F63116484*)NULL;
	}

IL_000e:
	{
		// IPInterfaceProperties properties = ni.GetIPProperties();
		NetworkInterface_t3E7DDFADB8912D0F9D001D1195EBD0FB08B7F47A* L_3 = V_0;
		NullCheck(L_3);
		IPInterfaceProperties_t60A00D504E4F72CAFE4C0AE4DA6A062B44D1512F* L_4;
		L_4 = VirtualFuncInvoker0< IPInterfaceProperties_t60A00D504E4F72CAFE4C0AE4DA6A062B44D1512F* >::Invoke(4 /* System.Net.NetworkInformation.IPInterfaceProperties System.Net.NetworkInformation.NetworkInterface::GetIPProperties() */, L_3);
		// foreach (UnicastIPAddressInformation unicastAddress in properties.UnicastAddresses)
		NullCheck(L_4);
		UnicastIPAddressInformationCollection_tB4D61C9127DFB4168CA3855020CCEB59B75C6EDA* L_5;
		L_5 = VirtualFuncInvoker0< UnicastIPAddressInformationCollection_tB4D61C9127DFB4168CA3855020CCEB59B75C6EDA* >::Invoke(4 /* System.Net.NetworkInformation.UnicastIPAddressInformationCollection System.Net.NetworkInformation.IPInterfaceProperties::get_UnicastAddresses() */, L_4);
		NullCheck(L_5);
		RuntimeObject* L_6;
		L_6 = VirtualFuncInvoker0< RuntimeObject* >::Invoke(18 /* System.Collections.Generic.IEnumerator`1<System.Net.NetworkInformation.UnicastIPAddressInformation> System.Net.NetworkInformation.UnicastIPAddressInformationCollection::GetEnumerator() */, L_5);
		V_1 = L_6;
	}

IL_001f:
	{
		auto __finallyBlock = il2cpp::utils::Finally([&]
		{

FINALLY_005c:
			{// begin finally (depth: 1)
				{
					RuntimeObject* L_7 = V_1;
					if (!L_7)
					{
						goto IL_0065;
					}
				}

IL_005f:
				{
					RuntimeObject* L_8 = V_1;
					NullCheck(L_8);
					InterfaceActionInvoker0::Invoke(0 /* System.Void System.IDisposable::Dispose() */, IDisposable_t030E0496B4E0E4E4F086825007979AF51F7248C5_il2cpp_TypeInfo_var, L_8);
				}

IL_0065:
				{
					return;
				}
			}// end finally (depth: 1)
		});
		try
		{// begin try (depth: 1)
			{
				goto IL_0052;
			}

IL_0021:
			{
				// foreach (UnicastIPAddressInformation unicastAddress in properties.UnicastAddresses)
				RuntimeObject* L_9 = V_1;
				NullCheck(L_9);
				UnicastIPAddressInformation_t4ACCADE9FBC1F8243A602439C94301E2C30295F3* L_10;
				L_10 = InterfaceFuncInvoker0< UnicastIPAddressInformation_t4ACCADE9FBC1F8243A602439C94301E2C30295F3* >::Invoke(0 /* T System.Collections.Generic.IEnumerator`1<System.Net.NetworkInformation.UnicastIPAddressInformation>::get_Current() */, IEnumerator_1_tA218C3658C89562941B7435E73E48E2EDC26D9BD_il2cpp_TypeInfo_var, L_9);
				V_2 = L_10;
				// if (unicastAddress != null && unicastAddress.Address != null && unicastAddress.Address.AddressFamily == AddressFamily.InterNetwork)
				UnicastIPAddressInformation_t4ACCADE9FBC1F8243A602439C94301E2C30295F3* L_11 = V_2;
				if (!L_11)
				{
					goto IL_0052;
				}
			}

IL_002b:
			{
				UnicastIPAddressInformation_t4ACCADE9FBC1F8243A602439C94301E2C30295F3* L_12 = V_2;
				NullCheck(L_12);
				IPAddress_t2F4486449B0D73FF2D3B36A9FE5E9C3F63116484* L_13;
				L_13 = VirtualFuncInvoker0< IPAddress_t2F4486449B0D73FF2D3B36A9FE5E9C3F63116484* >::Invoke(4 /* System.Net.IPAddress System.Net.NetworkInformation.IPAddressInformation::get_Address() */, L_12);
				if (!L_13)
				{
					goto IL_0052;
				}
			}

IL_0033:
			{
				UnicastIPAddressInformation_t4ACCADE9FBC1F8243A602439C94301E2C30295F3* L_14 = V_2;
				NullCheck(L_14);
				IPAddress_t2F4486449B0D73FF2D3B36A9FE5E9C3F63116484* L_15;
				L_15 = VirtualFuncInvoker0< IPAddress_t2F4486449B0D73FF2D3B36A9FE5E9C3F63116484* >::Invoke(4 /* System.Net.IPAddress System.Net.NetworkInformation.IPAddressInformation::get_Address() */, L_14);
				NullCheck(L_15);
				int32_t L_16;
				L_16 = IPAddress_get_AddressFamily_m1CE4BCCE499BD70B22F9E37B3F266F9306A98C21(L_15, NULL);
				if ((!(((uint32_t)L_16) == ((uint32_t)2))))
				{
					goto IL_0052;
				}
			}

IL_0041:
			{
				// mask = unicastAddress.IPv4Mask;
				IPAddress_t2F4486449B0D73FF2D3B36A9FE5E9C3F63116484** L_17 = ___mask0;
				UnicastIPAddressInformation_t4ACCADE9FBC1F8243A602439C94301E2C30295F3* L_18 = V_2;
				NullCheck(L_18);
				IPAddress_t2F4486449B0D73FF2D3B36A9FE5E9C3F63116484* L_19;
				L_19 = VirtualFuncInvoker0< IPAddress_t2F4486449B0D73FF2D3B36A9FE5E9C3F63116484* >::Invoke(5 /* System.Net.IPAddress System.Net.NetworkInformation.UnicastIPAddressInformation::get_IPv4Mask() */, L_18);
				*((RuntimeObject**)L_17) = (RuntimeObject*)L_19;
				Il2CppCodeGenWriteBarrier((void**)(RuntimeObject**)L_17, (void*)(RuntimeObject*)L_19);
				// return unicastAddress.Address;
				UnicastIPAddressInformation_t4ACCADE9FBC1F8243A602439C94301E2C30295F3* L_20 = V_2;
				NullCheck(L_20);
				IPAddress_t2F4486449B0D73FF2D3B36A9FE5E9C3F63116484* L_21;
				L_21 = VirtualFuncInvoker0< IPAddress_t2F4486449B0D73FF2D3B36A9FE5E9C3F63116484* >::Invoke(4 /* System.Net.IPAddress System.Net.NetworkInformation.IPAddressInformation::get_Address() */, L_20);
				V_3 = L_21;
				goto IL_006b;
			}

IL_0052:
			{
				// foreach (UnicastIPAddressInformation unicastAddress in properties.UnicastAddresses)
				RuntimeObject* L_22 = V_1;
				NullCheck(L_22);
				bool L_23;
				L_23 = InterfaceFuncInvoker0< bool >::Invoke(0 /* System.Boolean System.Collections.IEnumerator::MoveNext() */, IEnumerator_t7B609C2FFA6EB5167D9C62A0C32A21DE2F666DAA_il2cpp_TypeInfo_var, L_22);
				if (L_23)
				{
					goto IL_0021;
				}
			}

IL_005a:
			{
				goto IL_0066;
			}
		}// end try (depth: 1)
		catch(Il2CppExceptionWrapper& e)
		{
			__finallyBlock.StoreException(e.ex);
		}
	}

IL_0066:
	{
		// mask = null;
		IPAddress_t2F4486449B0D73FF2D3B36A9FE5E9C3F63116484** L_24 = ___mask0;
		*((RuntimeObject**)L_24) = (RuntimeObject*)NULL;
		Il2CppCodeGenWriteBarrier((void**)(RuntimeObject**)L_24, (void*)(RuntimeObject*)NULL);
		// return null;
		return (IPAddress_t2F4486449B0D73FF2D3B36A9FE5E9C3F63116484*)NULL;
	}

IL_006b:
	{
		// }
		IPAddress_t2F4486449B0D73FF2D3B36A9FE5E9C3F63116484* L_25 = V_3;
		return L_25;
	}
}
// System.Void Lidgren.Network.NetUtility::Sleep(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void NetUtility_Sleep_m51A7652D14F726B5D3EEF64C78C50EFD798303CD (int32_t ___milliseconds0, const RuntimeMethod* method) 
{
{
		// System.Threading.Thread.Sleep(milliseconds);
		int32_t L_0 = ___milliseconds0;
		Thread_Sleep_m63B7D29DC735584F4D80373E48C91B34FF32D1A0(L_0, NULL);
		// }
		return;
	}
}
// System.Net.IPAddress Lidgren.Network.NetUtility::CreateAddressFromBytes(System.Byte[])
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR IPAddress_t2F4486449B0D73FF2D3B36A9FE5E9C3F63116484* NetUtility_CreateAddressFromBytes_m56825BB58F0778D4E42746332F4BB190239C495B (ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* ___bytes0, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IPAddress_t2F4486449B0D73FF2D3B36A9FE5E9C3F63116484_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
{
		// return new IPAddress(bytes);
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_0 = ___bytes0;
		IPAddress_t2F4486449B0D73FF2D3B36A9FE5E9C3F63116484* L_1 = (IPAddress_t2F4486449B0D73FF2D3B36A9FE5E9C3F63116484*)il2cpp_codegen_object_new(IPAddress_t2F4486449B0D73FF2D3B36A9FE5E9C3F63116484_il2cpp_TypeInfo_var);
		IPAddress__ctor_m01F2FA932B0D4C0B2E15C6C837E3C52DDF186964(L_1, L_0, /*hidden argument*/NULL);
		return L_1;
	}
}
// System.Byte[] Lidgren.Network.NetUtility::ComputeSHAHash(System.Byte[],System.Int32,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* NetUtility_ComputeSHAHash_m72E631ED319081A04FA5BD0EB7F2AB9C072A177F (ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* ___bytes0, int32_t ___offset1, int32_t ___count2, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&NetUtility_t0B01E9514810CE3FC3B5E83D8427CBA1C5689EFD_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
{
		// return s_sha.ComputeHash(bytes, offset, count);
		il2cpp_codegen_runtime_class_init_inline(NetUtility_t0B01E9514810CE3FC3B5E83D8427CBA1C5689EFD_il2cpp_TypeInfo_var);
		SHA256_t6FEDD761EE6301127DAAF13320E8FD63296837F9* L_0 = ((NetUtility_t0B01E9514810CE3FC3B5E83D8427CBA1C5689EFD_StaticFields*)il2cpp_codegen_static_fields_for(NetUtility_t0B01E9514810CE3FC3B5E83D8427CBA1C5689EFD_il2cpp_TypeInfo_var))->___s_sha_4;
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_1 = ___bytes0;
		int32_t L_2 = ___offset1;
		int32_t L_3 = ___count2;
		NullCheck(L_0);
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_4;
		L_4 = HashAlgorithm_ComputeHash_mFAB8CADA69B3BE03B1C974250EEC30ADF8805710(L_0, L_1, L_2, L_3, NULL);
		return L_4;
	}
}
// System.Void Lidgren.Network.NetUtility::.cctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void NetUtility__cctor_m1710CB911C1F69AA57110BA75A0A48D9AF7F7813 (const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&NetUtility__cctor_m1710CB911C1F69AA57110BA75A0A48D9AF7F7813_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&NetUtility_t0B01E9514810CE3FC3B5E83D8427CBA1C5689EFD_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Stopwatch_tA188A210449E22C07053A7D3014DD182C7369043_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Type_GetType_m80C621C4D91A89DDEE6D3DDF343925B30F99BC45_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Type_t_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralA18A4AE569C5BE88A9C406093C040EFEBFF78C5E);
		s_Il2CppMethodInitialized = true;
	}
{
		// private static readonly bool IsMono = Type.GetType("Mono.Runtime") != null;
		il2cpp_codegen_runtime_class_init_inline(Type_t_il2cpp_TypeInfo_var);
		Type_t* L_0;
		L_0 = il2cpp_codegen_get_type(_stringLiteralA18A4AE569C5BE88A9C406093C040EFEBFF78C5E, Type_GetType_m80C621C4D91A89DDEE6D3DDF343925B30F99BC45_RuntimeMethod_var, NetUtility__cctor_m1710CB911C1F69AA57110BA75A0A48D9AF7F7813_RuntimeMethod_var);
		bool L_1;
		L_1 = Type_op_Inequality_m71AAC993EBBDBA44EE73847D68F71C70AF7AD1D5(L_0, (Type_t*)NULL, NULL);
		((NetUtility_t0B01E9514810CE3FC3B5E83D8427CBA1C5689EFD_StaticFields*)il2cpp_codegen_static_fields_for(NetUtility_t0B01E9514810CE3FC3B5E83D8427CBA1C5689EFD_il2cpp_TypeInfo_var))->___IsMono_0 = L_1;
		// private static readonly long s_timeInitialized = Stopwatch.GetTimestamp();
		il2cpp_codegen_runtime_class_init_inline(Stopwatch_tA188A210449E22C07053A7D3014DD182C7369043_il2cpp_TypeInfo_var);
		int64_t L_2;
		L_2 = Stopwatch_GetTimestamp_mD6D582A3E30369F05C829A5650BE2AE511EC807F(NULL);
		((NetUtility_t0B01E9514810CE3FC3B5E83D8427CBA1C5689EFD_StaticFields*)il2cpp_codegen_static_fields_for(NetUtility_t0B01E9514810CE3FC3B5E83D8427CBA1C5689EFD_il2cpp_TypeInfo_var))->___s_timeInitialized_2 = L_2;
		// private static readonly double s_dInvFreq = 1.0 / (double)Stopwatch.Frequency;
		int64_t L_3 = ((Stopwatch_tA188A210449E22C07053A7D3014DD182C7369043_StaticFields*)il2cpp_codegen_static_fields_for(Stopwatch_tA188A210449E22C07053A7D3014DD182C7369043_il2cpp_TypeInfo_var))->___Frequency_0;
		((NetUtility_t0B01E9514810CE3FC3B5E83D8427CBA1C5689EFD_StaticFields*)il2cpp_codegen_static_fields_for(NetUtility_t0B01E9514810CE3FC3B5E83D8427CBA1C5689EFD_il2cpp_TypeInfo_var))->___s_dInvFreq_3 = ((double)((1.0)/((double)L_3)));
		// private static readonly SHA256 s_sha = SHA256.Create();
		SHA256_t6FEDD761EE6301127DAAF13320E8FD63296837F9* L_4;
		L_4 = SHA256_Create_mCF8D7EB52BAB85B20EAE61668D40DDF0CE3EC2E8(NULL);
		((NetUtility_t0B01E9514810CE3FC3B5E83D8427CBA1C5689EFD_StaticFields*)il2cpp_codegen_static_fields_for(NetUtility_t0B01E9514810CE3FC3B5E83D8427CBA1C5689EFD_il2cpp_TypeInfo_var))->___s_sha_4 = L_4;
		Il2CppCodeGenWriteBarrier((void**)(&((NetUtility_t0B01E9514810CE3FC3B5E83D8427CBA1C5689EFD_StaticFields*)il2cpp_codegen_static_fields_for(NetUtility_t0B01E9514810CE3FC3B5E83D8427CBA1C5689EFD_il2cpp_TypeInfo_var))->___s_sha_4), (void*)L_4);
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
// System.Void Lidgren.Network.NetUtility/ResolveEndPointCallback::.ctor(System.Object,System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ResolveEndPointCallback__ctor_m7D63A25F71B5A73A88AF946098FC9FCD7CB69E8C (ResolveEndPointCallback_t5A60EB6B6BDAEA33BFEB134C8EFED8B43385049B* __this, RuntimeObject* ___object0, intptr_t ___method1, const RuntimeMethod* method) 
{
__this->___method_ptr_0 = il2cpp_codegen_get_method_pointer((RuntimeMethod*)___method1);
	__this->___method_3 = ___method1;
	__this->___m_target_2 = ___object0;
	Il2CppCodeGenWriteBarrier((void**)(&__this->___m_target_2), (void*)___object0);
}
// System.Void Lidgren.Network.NetUtility/ResolveEndPointCallback::Invoke(System.Net.IPEndPoint)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ResolveEndPointCallback_Invoke_m3A5822DF84B3E061C3C3A4F6C006A56E268FD66E (ResolveEndPointCallback_t5A60EB6B6BDAEA33BFEB134C8EFED8B43385049B* __this, IPEndPoint_t2F09CBA7A808B67724B4E2954EEDC46D910F4ECB* ___endPoint0, const RuntimeMethod* method) 
{
DelegateU5BU5D_tC5AB7E8F745616680F337909D3A8E6C722CDF771* delegateArrayToInvoke = __this->___delegates_13;
	Delegate_t** delegatesToInvoke;
	il2cpp_array_size_t length;
	if (delegateArrayToInvoke != NULL)
	{
		length = delegateArrayToInvoke->max_length;
		delegatesToInvoke = reinterpret_cast<Delegate_t**>(delegateArrayToInvoke->GetAddressAtUnchecked(0));
	}
	else
	{
		length = 1;
		delegatesToInvoke = reinterpret_cast<Delegate_t**>(&__this);
	}

	for (il2cpp_array_size_t i = 0; i < length; i++)
	{
		Delegate_t* currentDelegate = delegatesToInvoke[i];
		Il2CppMethodPointer targetMethodPointer = currentDelegate->___method_ptr_0;
		RuntimeObject* targetThis = currentDelegate->___m_target_2;
		RuntimeMethod* targetMethod = (RuntimeMethod*)(currentDelegate->___method_3);
		if (!currentDelegate->___method_is_virtual_12)
		{
			il2cpp_codegen_raise_execution_engine_exception_if_method_is_not_found(targetMethod);
		}
		bool ___methodIsStatic = MethodIsStatic(targetMethod);
		int ___parameterCount = il2cpp_codegen_method_parameter_count(targetMethod);
		if (___methodIsStatic)
		{
			if (___parameterCount == 1)
			{
				// open
				typedef void (*FunctionPointerType) (IPEndPoint_t2F09CBA7A808B67724B4E2954EEDC46D910F4ECB*, const RuntimeMethod*);
				((FunctionPointerType)targetMethodPointer)(___endPoint0, targetMethod);
			}
			else
			{
				// closed
				typedef void (*FunctionPointerType) (void*, IPEndPoint_t2F09CBA7A808B67724B4E2954EEDC46D910F4ECB*, const RuntimeMethod*);
				((FunctionPointerType)targetMethodPointer)(targetThis, ___endPoint0, targetMethod);
			}
		}
		else if (___parameterCount != 1)
		{
			// open
			if (currentDelegate->___method_is_virtual_12)
			{
				if (il2cpp_codegen_method_is_generic_instance(targetMethod))
				{
					if (il2cpp_codegen_method_is_interface_method(targetMethod))
						GenericInterfaceActionInvoker0::Invoke(targetMethod, ___endPoint0);
					else
						GenericVirtualActionInvoker0::Invoke(targetMethod, ___endPoint0);
				}
				else
				{
					if (il2cpp_codegen_method_is_interface_method(targetMethod))
						InterfaceActionInvoker0::Invoke(il2cpp_codegen_method_get_slot(targetMethod), il2cpp_codegen_method_get_declaring_type(targetMethod), ___endPoint0);
					else
						VirtualActionInvoker0::Invoke(il2cpp_codegen_method_get_slot(targetMethod), ___endPoint0);
				}
			}
			else
			{
				typedef void (*FunctionPointerType) (IPEndPoint_t2F09CBA7A808B67724B4E2954EEDC46D910F4ECB*, const RuntimeMethod*);
				((FunctionPointerType)targetMethodPointer)(___endPoint0, targetMethod);
			}
		}
		else
		{
			// closed
			typedef void (*FunctionPointerType) (void*, IPEndPoint_t2F09CBA7A808B67724B4E2954EEDC46D910F4ECB*, const RuntimeMethod*);
			((FunctionPointerType)targetMethodPointer)(targetThis, ___endPoint0, targetMethod);
		}
	}
}
// System.IAsyncResult Lidgren.Network.NetUtility/ResolveEndPointCallback::BeginInvoke(System.Net.IPEndPoint,System.AsyncCallback,System.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* ResolveEndPointCallback_BeginInvoke_mCA8313AF0EAACB8174F77754EEF863517D7CAAE5 (ResolveEndPointCallback_t5A60EB6B6BDAEA33BFEB134C8EFED8B43385049B* __this, IPEndPoint_t2F09CBA7A808B67724B4E2954EEDC46D910F4ECB* ___endPoint0, AsyncCallback_t7FEF460CBDCFB9C5FA2EF776984778B9A4145F4C* ___callback1, RuntimeObject* ___object2, const RuntimeMethod* method) 
{
void *__d_args[2] = {0};
	__d_args[0] = ___endPoint0;
	return (RuntimeObject*)il2cpp_codegen_delegate_begin_invoke((RuntimeDelegate*)__this, __d_args, (RuntimeDelegate*)___callback1, (RuntimeObject*)___object2);;
}
// System.Void Lidgren.Network.NetUtility/ResolveEndPointCallback::EndInvoke(System.IAsyncResult)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ResolveEndPointCallback_EndInvoke_mC2B99D7AC437906CA7BB6B4D8C9AF5684524A1A4 (ResolveEndPointCallback_t5A60EB6B6BDAEA33BFEB134C8EFED8B43385049B* __this, RuntimeObject* ___result0, const RuntimeMethod* method) 
{
il2cpp_codegen_delegate_end_invoke((Il2CppAsyncResult*) ___result0, 0);
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void Lidgren.Network.NetUtility/ResolveAddressCallback::.ctor(System.Object,System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ResolveAddressCallback__ctor_m6947005CBFF0F0196EA1234FB57118E5C8D2A803 (ResolveAddressCallback_t025BC6260F915039CDB17B31BCDE78B9ED8CC3CF* __this, RuntimeObject* ___object0, intptr_t ___method1, const RuntimeMethod* method) 
{
__this->___method_ptr_0 = il2cpp_codegen_get_method_pointer((RuntimeMethod*)___method1);
	__this->___method_3 = ___method1;
	__this->___m_target_2 = ___object0;
	Il2CppCodeGenWriteBarrier((void**)(&__this->___m_target_2), (void*)___object0);
}
// System.Void Lidgren.Network.NetUtility/ResolveAddressCallback::Invoke(System.Net.IPAddress)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ResolveAddressCallback_Invoke_m0FF0480977B8C46A93C0063B6F282E61190C426C (ResolveAddressCallback_t025BC6260F915039CDB17B31BCDE78B9ED8CC3CF* __this, IPAddress_t2F4486449B0D73FF2D3B36A9FE5E9C3F63116484* ___adr0, const RuntimeMethod* method) 
{
DelegateU5BU5D_tC5AB7E8F745616680F337909D3A8E6C722CDF771* delegateArrayToInvoke = __this->___delegates_13;
	Delegate_t** delegatesToInvoke;
	il2cpp_array_size_t length;
	if (delegateArrayToInvoke != NULL)
	{
		length = delegateArrayToInvoke->max_length;
		delegatesToInvoke = reinterpret_cast<Delegate_t**>(delegateArrayToInvoke->GetAddressAtUnchecked(0));
	}
	else
	{
		length = 1;
		delegatesToInvoke = reinterpret_cast<Delegate_t**>(&__this);
	}

	for (il2cpp_array_size_t i = 0; i < length; i++)
	{
		Delegate_t* currentDelegate = delegatesToInvoke[i];
		Il2CppMethodPointer targetMethodPointer = currentDelegate->___method_ptr_0;
		RuntimeObject* targetThis = currentDelegate->___m_target_2;
		RuntimeMethod* targetMethod = (RuntimeMethod*)(currentDelegate->___method_3);
		if (!currentDelegate->___method_is_virtual_12)
		{
			il2cpp_codegen_raise_execution_engine_exception_if_method_is_not_found(targetMethod);
		}
		bool ___methodIsStatic = MethodIsStatic(targetMethod);
		int ___parameterCount = il2cpp_codegen_method_parameter_count(targetMethod);
		if (___methodIsStatic)
		{
			if (___parameterCount == 1)
			{
				// open
				typedef void (*FunctionPointerType) (IPAddress_t2F4486449B0D73FF2D3B36A9FE5E9C3F63116484*, const RuntimeMethod*);
				((FunctionPointerType)targetMethodPointer)(___adr0, targetMethod);
			}
			else
			{
				// closed
				typedef void (*FunctionPointerType) (void*, IPAddress_t2F4486449B0D73FF2D3B36A9FE5E9C3F63116484*, const RuntimeMethod*);
				((FunctionPointerType)targetMethodPointer)(targetThis, ___adr0, targetMethod);
			}
		}
		else if (___parameterCount != 1)
		{
			// open
			if (currentDelegate->___method_is_virtual_12)
			{
				if (il2cpp_codegen_method_is_generic_instance(targetMethod))
				{
					if (il2cpp_codegen_method_is_interface_method(targetMethod))
						GenericInterfaceActionInvoker0::Invoke(targetMethod, ___adr0);
					else
						GenericVirtualActionInvoker0::Invoke(targetMethod, ___adr0);
				}
				else
				{
					if (il2cpp_codegen_method_is_interface_method(targetMethod))
						InterfaceActionInvoker0::Invoke(il2cpp_codegen_method_get_slot(targetMethod), il2cpp_codegen_method_get_declaring_type(targetMethod), ___adr0);
					else
						VirtualActionInvoker0::Invoke(il2cpp_codegen_method_get_slot(targetMethod), ___adr0);
				}
			}
			else
			{
				typedef void (*FunctionPointerType) (IPAddress_t2F4486449B0D73FF2D3B36A9FE5E9C3F63116484*, const RuntimeMethod*);
				((FunctionPointerType)targetMethodPointer)(___adr0, targetMethod);
			}
		}
		else
		{
			// closed
			typedef void (*FunctionPointerType) (void*, IPAddress_t2F4486449B0D73FF2D3B36A9FE5E9C3F63116484*, const RuntimeMethod*);
			((FunctionPointerType)targetMethodPointer)(targetThis, ___adr0, targetMethod);
		}
	}
}
// System.IAsyncResult Lidgren.Network.NetUtility/ResolveAddressCallback::BeginInvoke(System.Net.IPAddress,System.AsyncCallback,System.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* ResolveAddressCallback_BeginInvoke_m5CE3BF9DD1708B00DC90C9BB0A62AB9BE17D7E3F (ResolveAddressCallback_t025BC6260F915039CDB17B31BCDE78B9ED8CC3CF* __this, IPAddress_t2F4486449B0D73FF2D3B36A9FE5E9C3F63116484* ___adr0, AsyncCallback_t7FEF460CBDCFB9C5FA2EF776984778B9A4145F4C* ___callback1, RuntimeObject* ___object2, const RuntimeMethod* method) 
{
void *__d_args[2] = {0};
	__d_args[0] = ___adr0;
	return (RuntimeObject*)il2cpp_codegen_delegate_begin_invoke((RuntimeDelegate*)__this, __d_args, (RuntimeDelegate*)___callback1, (RuntimeObject*)___object2);;
}
// System.Void Lidgren.Network.NetUtility/ResolveAddressCallback::EndInvoke(System.IAsyncResult)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ResolveAddressCallback_EndInvoke_mB5ECDF3071E0884F6EB7DA75B92A43AD0B246C57 (ResolveAddressCallback_t025BC6260F915039CDB17B31BCDE78B9ED8CC3CF* __this, RuntimeObject* ___result0, const RuntimeMethod* method) 
{
il2cpp_codegen_delegate_end_invoke((Il2CppAsyncResult*) ___result0, 0);
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void Lidgren.Network.NetUtility/<>c__DisplayClass3_0::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CU3Ec__DisplayClass3_0__ctor_m1C204809AC2DA7F72E6199399BC6FB93CA3CA382 (U3CU3Ec__DisplayClass3_0_t8A9B82FCFB20DB8AF0DEB4BFF84B5BF342D6D362* __this, const RuntimeMethod* method) 
{
{
		Object__ctor_mE837C6B9FA8C6D5D109F4B2EC885D79919AC0EA2(__this, NULL);
		return;
	}
}
// System.Void Lidgren.Network.NetUtility/<>c__DisplayClass3_0::<ResolveAsync>b__0(System.Net.IPAddress)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CU3Ec__DisplayClass3_0_U3CResolveAsyncU3Eb__0_m062212D8E00D13552A2546A577F790E095E6373D (U3CU3Ec__DisplayClass3_0_t8A9B82FCFB20DB8AF0DEB4BFF84B5BF342D6D362* __this, IPAddress_t2F4486449B0D73FF2D3B36A9FE5E9C3F63116484* ___adr0, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IPEndPoint_t2F09CBA7A808B67724B4E2954EEDC46D910F4ECB_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
{
		// if (adr == null)
		IPAddress_t2F4486449B0D73FF2D3B36A9FE5E9C3F63116484* L_0 = ___adr0;
		if (L_0)
		{
			goto IL_0010;
		}
	}
	{
		// callback(null);
		ResolveEndPointCallback_t5A60EB6B6BDAEA33BFEB134C8EFED8B43385049B* L_1 = __this->___callback_0;
		NullCheck(L_1);
		ResolveEndPointCallback_Invoke_m3A5822DF84B3E061C3C3A4F6C006A56E268FD66E(L_1, (IPEndPoint_t2F09CBA7A808B67724B4E2954EEDC46D910F4ECB*)NULL, NULL);
		return;
	}

IL_0010:
	{
		// callback(new NetEndPoint(adr, port));
		ResolveEndPointCallback_t5A60EB6B6BDAEA33BFEB134C8EFED8B43385049B* L_2 = __this->___callback_0;
		IPAddress_t2F4486449B0D73FF2D3B36A9FE5E9C3F63116484* L_3 = ___adr0;
		int32_t L_4 = __this->___port_1;
		IPEndPoint_t2F09CBA7A808B67724B4E2954EEDC46D910F4ECB* L_5 = (IPEndPoint_t2F09CBA7A808B67724B4E2954EEDC46D910F4ECB*)il2cpp_codegen_object_new(IPEndPoint_t2F09CBA7A808B67724B4E2954EEDC46D910F4ECB_il2cpp_TypeInfo_var);
		IPEndPoint__ctor_m902C98F9E3F36B20B3C2E030AA91B62E2BC7A85A(L_5, L_3, L_4, /*hidden argument*/NULL);
		NullCheck(L_2);
		ResolveEndPointCallback_Invoke_m3A5822DF84B3E061C3C3A4F6C006A56E268FD66E(L_2, L_5, NULL);
		// });
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
// System.Void Lidgren.Network.NetUtility/<>c__DisplayClass7_0::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CU3Ec__DisplayClass7_0__ctor_m54C100B10B7B0058E6372410E183F972B621DEEE (U3CU3Ec__DisplayClass7_0_tB883D8785D0FF482B1D10D9C5244FE77BF69353A* __this, const RuntimeMethod* method) 
{
{
		Object__ctor_mE837C6B9FA8C6D5D109F4B2EC885D79919AC0EA2(__this, NULL);
		return;
	}
}
// System.Void Lidgren.Network.NetUtility/<>c__DisplayClass7_0::<ResolveAsync>b__0(System.IAsyncResult)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CU3Ec__DisplayClass7_0_U3CResolveAsyncU3Eb__0_mF089B3B4BCAE0306728BCD87C51A27A1FF559ED9 (U3CU3Ec__DisplayClass7_0_tB883D8785D0FF482B1D10D9C5244FE77BF69353A* __this, RuntimeObject* ___result0, const RuntimeMethod* method) 
{
IPAddressU5BU5D_t3AEDF3B94746C9023A4549F878AA47F702C9CD0D* V_0 = NULL;
	int32_t V_1 = 0;
	IPAddress_t2F4486449B0D73FF2D3B36A9FE5E9C3F63116484* V_2 = NULL;
	il2cpp::utils::ExceptionSupportStack<RuntimeObject*, 1> __active_exceptions;

IL_0000:
	try
	{// begin try (depth: 1)
		// entry = Dns.EndGetHostEntry(result);
		RuntimeObject* L_0 = ___result0;
		IPHostEntry_tAAAEB0F40DB9F28BE601B5FE7DA1D76191C94490* L_1;
		L_1 = Dns_EndGetHostEntry_mAE12F9DE6BC238443179126D0B3F5F76067CF3FF(L_0, NULL);
		__this->___entry_0 = L_1;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___entry_0), (void*)L_1);
		// }
		goto IL_002a;
	}// end try (depth: 1)
	catch(Il2CppExceptionWrapper& e)
	{
		if(il2cpp_codegen_class_is_assignable_from (((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&SocketException_t6D10102A62EA871BD31748E026A372DB6804083B_il2cpp_TypeInfo_var)), il2cpp_codegen_object_class(e.ex)))
		{
			IL2CPP_PUSH_ACTIVE_EXCEPTION(e.ex);
			goto CATCH_000e;
		}
		throw e;
	}

CATCH_000e:
	{// begin catch(System.Net.Sockets.SocketException)
		{
			// if (ex.SocketErrorCode == SocketError.HostNotFound)
			NullCheck(((SocketException_t6D10102A62EA871BD31748E026A372DB6804083B*)IL2CPP_GET_ACTIVE_EXCEPTION(SocketException_t6D10102A62EA871BD31748E026A372DB6804083B*)));
			int32_t L_2;
			L_2 = SocketException_get_SocketErrorCode_m84FB2D308F046A24A1355975F3BF689C988224C6(((SocketException_t6D10102A62EA871BD31748E026A372DB6804083B*)IL2CPP_GET_ACTIVE_EXCEPTION(SocketException_t6D10102A62EA871BD31748E026A372DB6804083B*)), NULL);
			if ((!(((uint32_t)L_2) == ((uint32_t)((int32_t)11001)))))
			{
				goto IL_0028;
			}
		}

IL_001a:
		{
			// callback(null);
			ResolveAddressCallback_t025BC6260F915039CDB17B31BCDE78B9ED8CC3CF* L_3 = __this->___callback_1;
			NullCheck(L_3);
			ResolveAddressCallback_Invoke_m0FF0480977B8C46A93C0063B6F282E61190C426C(L_3, (IPAddress_t2F4486449B0D73FF2D3B36A9FE5E9C3F63116484*)NULL, NULL);
			// return;
			IL2CPP_POP_ACTIVE_EXCEPTION();
			goto IL_0089;
		}

IL_0028:
		{
			// throw;
			IL2CPP_RAISE_MANAGED_EXCEPTION(IL2CPP_GET_ACTIVE_EXCEPTION(Exception_t*), ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&U3CU3Ec__DisplayClass7_0_U3CResolveAsyncU3Eb__0_mF089B3B4BCAE0306728BCD87C51A27A1FF559ED9_RuntimeMethod_var)));
		}
	}// end catch (depth: 1)

IL_002a:
	{
		// if (entry == null)
		IPHostEntry_tAAAEB0F40DB9F28BE601B5FE7DA1D76191C94490* L_4 = __this->___entry_0;
		if (L_4)
		{
			goto IL_003f;
		}
	}
	{
		// callback(null);
		ResolveAddressCallback_t025BC6260F915039CDB17B31BCDE78B9ED8CC3CF* L_5 = __this->___callback_1;
		NullCheck(L_5);
		ResolveAddressCallback_Invoke_m0FF0480977B8C46A93C0063B6F282E61190C426C(L_5, (IPAddress_t2F4486449B0D73FF2D3B36A9FE5E9C3F63116484*)NULL, NULL);
		// return;
		return;
	}

IL_003f:
	{
		// foreach (var ipCurrent in entry.AddressList)
		IPHostEntry_tAAAEB0F40DB9F28BE601B5FE7DA1D76191C94490* L_6 = __this->___entry_0;
		NullCheck(L_6);
		IPAddressU5BU5D_t3AEDF3B94746C9023A4549F878AA47F702C9CD0D* L_7;
		L_7 = IPHostEntry_get_AddressList_m9D14D52EFB41C53C9C4A36D438E1333A99B7AA71_inline(L_6, NULL);
		V_0 = L_7;
		V_1 = 0;
		goto IL_0077;
	}

IL_004f:
	{
		// foreach (var ipCurrent in entry.AddressList)
		IPAddressU5BU5D_t3AEDF3B94746C9023A4549F878AA47F702C9CD0D* L_8 = V_0;
		int32_t L_9 = V_1;
		NullCheck(L_8);
		int32_t L_10 = L_9;
		IPAddress_t2F4486449B0D73FF2D3B36A9FE5E9C3F63116484* L_11 = (L_8)->GetAt(static_cast<il2cpp_array_size_t>(L_10));
		V_2 = L_11;
		// if (ipCurrent.AddressFamily == AddressFamily.InterNetwork || ipCurrent.AddressFamily == AddressFamily.InterNetworkV6)
		IPAddress_t2F4486449B0D73FF2D3B36A9FE5E9C3F63116484* L_12 = V_2;
		NullCheck(L_12);
		int32_t L_13;
		L_13 = IPAddress_get_AddressFamily_m1CE4BCCE499BD70B22F9E37B3F266F9306A98C21(L_12, NULL);
		if ((((int32_t)L_13) == ((int32_t)2)))
		{
			goto IL_0066;
		}
	}
	{
		IPAddress_t2F4486449B0D73FF2D3B36A9FE5E9C3F63116484* L_14 = V_2;
		NullCheck(L_14);
		int32_t L_15;
		L_15 = IPAddress_get_AddressFamily_m1CE4BCCE499BD70B22F9E37B3F266F9306A98C21(L_14, NULL);
		if ((!(((uint32_t)L_15) == ((uint32_t)((int32_t)23)))))
		{
			goto IL_0073;
		}
	}

IL_0066:
	{
		// callback(ipCurrent);
		ResolveAddressCallback_t025BC6260F915039CDB17B31BCDE78B9ED8CC3CF* L_16 = __this->___callback_1;
		IPAddress_t2F4486449B0D73FF2D3B36A9FE5E9C3F63116484* L_17 = V_2;
		NullCheck(L_16);
		ResolveAddressCallback_Invoke_m0FF0480977B8C46A93C0063B6F282E61190C426C(L_16, L_17, NULL);
		// return;
		return;
	}

IL_0073:
	{
		int32_t L_18 = V_1;
		V_1 = ((int32_t)il2cpp_codegen_add(L_18, 1));
	}

IL_0077:
	{
		// foreach (var ipCurrent in entry.AddressList)
		int32_t L_19 = V_1;
		IPAddressU5BU5D_t3AEDF3B94746C9023A4549F878AA47F702C9CD0D* L_20 = V_0;
		NullCheck(L_20);
		if ((((int32_t)L_19) < ((int32_t)((int32_t)(((RuntimeArray*)L_20)->max_length)))))
		{
			goto IL_004f;
		}
	}
	{
		// callback(null);
		ResolveAddressCallback_t025BC6260F915039CDB17B31BCDE78B9ED8CC3CF* L_21 = __this->___callback_1;
		NullCheck(L_21);
		ResolveAddressCallback_Invoke_m0FF0480977B8C46A93C0063B6F282E61190C426C(L_21, (IPAddress_t2F4486449B0D73FF2D3B36A9FE5E9C3F63116484*)NULL, NULL);
	}

IL_0089:
	{
		// }, null);
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
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void NetPeerConfiguration_set_AcceptIncomingConnections_mEB37F905BF5640D0CD9241ABC0302F90AA43D372_inline (NetPeerConfiguration_t7BA55B2118BE6EC975E65EEE156B05E72A3339DD* __this, bool ___value0, const RuntimeMethod* method) 
{
{
		// set { m_acceptIncomingConnections = value; }
		bool L_0 = ___value0;
		__this->___m_acceptIncomingConnections_8 = L_0;
		// set { m_acceptIncomingConnections = value; }
		return;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR int32_t String_get_Length_m42625D67623FA5CC7A44D47425CE86FB946542D2_inline (String_t* __this, const RuntimeMethod* method) 
{
{
		int32_t L_0 = __this->____stringLength_4;
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR NetPeer_tDCD3AC5FB42BE47DEE7AEEA74F327C1E0D883542* NetConnection_get_Peer_mD4190401C6B4D50DBDF739F47D1DD494AF7CC04F_inline (NetConnection_tBC8B4699CF2D1614FF259EE7E3031D8D25E31F9D* __this, const RuntimeMethod* method) 
{
{
		// public NetPeer Peer { get { return m_peer; } }
		NetPeer_tDCD3AC5FB42BE47DEE7AEEA74F327C1E0D883542* L_0 = __this->___m_peer_2;
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR NetPeerConfiguration_t7BA55B2118BE6EC975E65EEE156B05E72A3339DD* NetPeer_get_Configuration_m45ADD4611BB6484ADBAEF24A81768E19AEB77F7B_inline (NetPeer_tDCD3AC5FB42BE47DEE7AEEA74F327C1E0D883542* __this, const RuntimeMethod* method) 
{
{
		// public NetPeerConfiguration Configuration { get { return m_configuration; } }
		NetPeerConfiguration_t7BA55B2118BE6EC975E65EEE156B05E72A3339DD* L_0 = __this->___m_configuration_24;
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR bool NetPeerConfiguration_get_SuppressUnreliableUnorderedAcks_m9E8972CF4FF6CB86C992334F40DC8E922042301A_inline (NetPeerConfiguration_t7BA55B2118BE6EC975E65EEE156B05E72A3339DD* __this, const RuntimeMethod* method) 
{
{
		// get { return m_suppressUnreliableUnorderedAcks; }
		bool L_0 = __this->___m_suppressUnreliableUnorderedAcks_18;
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR int32_t NetPeerConfiguration_get_UnreliableSizeBehaviour_m8C1D20EBDDEEF517EC403FB17911127A29B961D4_inline (NetPeerConfiguration_t7BA55B2118BE6EC975E65EEE156B05E72A3339DD* __this, const RuntimeMethod* method) 
{
{
		// get { return m_unreliableSizeBehaviour; }
		int32_t L_0 = __this->___m_unreliableSizeBehaviour_17;
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Socket_t1F49472CDA22B581C29A258225ABF3ADA9DED67E* NetPeer_get_Socket_mCC49D19E418EEF9BCB8843C3475592AA8B6A2CC8_inline (NetPeer_tDCD3AC5FB42BE47DEE7AEEA74F327C1E0D883542* __this, const RuntimeMethod* method) 
{
{
		// public Socket Socket { get { return m_socket; } }
		Socket_t1F49472CDA22B581C29A258225ABF3ADA9DED67E* L_0 = __this->___m_socket_13;
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR IPAddress_t2F4486449B0D73FF2D3B36A9FE5E9C3F63116484* IPEndPoint_get_Address_m72F783CB76E10E9DBDF680CCC1DAAED201BABB1C_inline (IPEndPoint_t2F09CBA7A808B67724B4E2954EEDC46D910F4ECB* __this, const RuntimeMethod* method) 
{
{
		IPAddress_t2F4486449B0D73FF2D3B36A9FE5E9C3F63116484* L_0 = __this->____address_2;
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR double Math_Round_mAE7072AE69091258FAA8BD5923CE4A0E492B5B7D_inline (double ___value0, int32_t ___digits1, const RuntimeMethod* method) 
{
static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Math_tEB65DE7CA8B083C412C969C92981C030865486CE_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
{
		double L_0 = ___value0;
		int32_t L_1 = ___digits1;
		il2cpp_codegen_runtime_class_init_inline(Math_tEB65DE7CA8B083C412C969C92981C030865486CE_il2cpp_TypeInfo_var);
		double L_2;
		L_2 = Math_Round_mA90F6B1668D55BC6C538EBF0302B30E406E242B0(L_0, L_1, 0, NULL);
		return L_2;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR int32_t IPEndPoint_get_Port_mFBE1AF1C9CC7E68A46BF46AD3869CC9DC01CF429_inline (IPEndPoint_t2F09CBA7A808B67724B4E2954EEDC46D910F4ECB* __this, const RuntimeMethod* method) 
{
{
		int32_t L_0 = __this->____port_3;
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void IPEndPoint_set_Address_m48F0D8096D02B90890E453ECF1616B78BB97CF63_inline (IPEndPoint_t2F09CBA7A808B67724B4E2954EEDC46D910F4ECB* __this, IPAddress_t2F4486449B0D73FF2D3B36A9FE5E9C3F63116484* ___value0, const RuntimeMethod* method) 
{
{
		IPAddress_t2F4486449B0D73FF2D3B36A9FE5E9C3F63116484* L_0 = ___value0;
		__this->____address_2 = L_0;
		Il2CppCodeGenWriteBarrier((void**)(&__this->____address_2), (void*)L_0);
		return;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR IPAddressU5BU5D_t3AEDF3B94746C9023A4549F878AA47F702C9CD0D* IPHostEntry_get_AddressList_m9D14D52EFB41C53C9C4A36D438E1333A99B7AA71_inline (IPHostEntry_tAAAEB0F40DB9F28BE601B5FE7DA1D76191C94490* __this, const RuntimeMethod* method) 
{
{
		IPAddressU5BU5D_t3AEDF3B94746C9023A4549F878AA47F702C9CD0D* L_0 = __this->___addressList_2;
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
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR RuntimeObject* Enumerator_get_Current_m6330F15D18EE4F547C05DF9BF83C5EB710376027_gshared_inline (Enumerator_t9473BAB568A27E2339D48C1F91319E0F6D244D7A* __this, const RuntimeMethod* method) 
{
{
		RuntimeObject* L_0 = (RuntimeObject*)__this->____current_3;
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
