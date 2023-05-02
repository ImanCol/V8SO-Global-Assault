#include "pch-c.h"
#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif


#include "codegen/il2cpp-codegen-metadata.h"





// 0x00000001 System.Void Unity.Services.Wire.Internal.Client::.ctor(Unity.Services.Wire.Internal.Configuration,Unity.Services.Core.Scheduler.Internal.IActionScheduler,Unity.Services.Core.Telemetry.Internal.IMetrics,Unity.Services.Core.Threading.Internal.IUnityThreadUtils)
extern void Client__ctor_m6CAAB061A911F3EDBF90C2A1E39CD656C6805F73 (void);
// 0x00000002 System.Void Unity.Services.Wire.Internal.Client::SetupDirectClient()
extern void Client_SetupDirectClient_m350737B58870B3CBD955FC8A6C691C993BC5B96B (void);
// 0x00000003 System.Threading.Tasks.Task`1<Unity.Services.Wire.Internal.Reply> Unity.Services.Wire.Internal.Client::SendCommandAsync(System.UInt32,Unity.Services.Wire.Internal.Message)
extern void Client_SendCommandAsync_m4A782FCA2F1CD5F55672D3C90F088B80AE05A970 (void);
// 0x00000004 System.Threading.Tasks.Task`1<System.Boolean> Unity.Services.Wire.Internal.Client::PingAsync()
extern void Client_PingAsync_mC9FF7E9BF09A1AEF6AD1993C26957A7D5BDC4487 (void);
// 0x00000005 System.Void Unity.Services.Wire.Internal.Client::OnPingInterrupted(System.Exception)
extern void Client_OnPingInterrupted_mAB6BFE50435302EE73E3190E62AE11DAFCF018C3 (void);
// 0x00000006 System.Void Unity.Services.Wire.Internal.Client::Disconnect()
extern void Client_Disconnect_mA4C9530BC0C96E024B97311C2CB7C14F954C0FFE (void);
// 0x00000007 System.Threading.Tasks.Task Unity.Services.Wire.Internal.Client::ConnectAsync()
extern void Client_ConnectAsync_m0D0D03C7D64451F06F1630163BFCBF2766C989CD (void);
// 0x00000008 System.Void Unity.Services.Wire.Internal.Client::InitWebsocket()
extern void Client_InitWebsocket_m15C404A2A2D8C59379EC16C6291E50EF826E76C5 (void);
// 0x00000009 System.Boolean Unity.Services.Wire.Internal.Client::ShouldReconnect(Unity.Services.Wire.Internal.CentrifugeCloseCode)
extern void Client_ShouldReconnect_mCBE947C40F19A61D0AABDEB40759D8E72C57B5E1 (void);
// 0x0000000A System.Void Unity.Services.Wire.Internal.Client::ChangeConnectionState(Unity.Services.Wire.Internal.Client/ConnectionState)
extern void Client_ChangeConnectionState_mA8A02AA0E69DB1211E8EE7D16CED5199078BF29A (void);
// 0x0000000B System.Void Unity.Services.Wire.Internal.Client::HandlePublications(Unity.Services.Wire.Internal.Reply)
extern void Client_HandlePublications_mA6E55C31E93A129F36DAD4E5F529C15CF1D3FF0E (void);
// 0x0000000C System.Void Unity.Services.Wire.Internal.Client::HandlePushMessage(Unity.Services.Wire.Internal.Reply)
extern void Client_HandlePushMessage_mE6E534B79617BD8E0F71E786D2035EBDFD85257E (void);
// 0x0000000D Unity.Services.Wire.Internal.Subscription Unity.Services.Wire.Internal.Client::GetSubscriptionForReply(Unity.Services.Wire.Internal.Reply)
extern void Client_GetSubscriptionForReply_mF6FDC406E8058338B5C725D61D2088E7B6124A7E (void);
// 0x0000000E System.Void Unity.Services.Wire.Internal.Client::HandleCommandReply(Unity.Services.Wire.Internal.Reply)
extern void Client_HandleCommandReply_m4AF9979EF80DE6B44D601FAE8F55D82907E35800 (void);
// 0x0000000F System.Threading.Tasks.Task Unity.Services.Wire.Internal.Client::SubscribeAsync(Unity.Services.Wire.Internal.Subscription)
extern void Client_SubscribeAsync_m87A53AE1DF7A1149F8B54551AA04D6A844993A9A (void);
// 0x00000010 Unity.Services.Wire.Internal.IChannel Unity.Services.Wire.Internal.Client::CreateChannel(Unity.Services.Wire.Internal.IChannelTokenProvider)
extern void Client_CreateChannel_m9C45A243F1B05A83B7275930FD091AF91854F647 (void);
// 0x00000011 System.Threading.Tasks.Task Unity.Services.Wire.Internal.Client::UnsubscribeAsync(Unity.Services.Wire.Internal.Subscription)
extern void Client_UnsubscribeAsync_m19C5EACFAB7624F04800FB6B061BAD08C304C5B3 (void);
// 0x00000012 System.Void Unity.Services.Wire.Internal.Client::<.ctor>b__16_0(System.Int32)
extern void Client_U3C_ctorU3Eb__16_0_mAC425236D6BE7B39891A7336CF89900EC480F881 (void);
// 0x00000013 System.Void Unity.Services.Wire.Internal.Client::<InitWebsocket>b__23_0()
extern void Client_U3CInitWebsocketU3Eb__23_0_m8FE896320DB67E471C771184058CBD4FF4A84B53 (void);
// 0x00000014 System.Void Unity.Services.Wire.Internal.Client::<InitWebsocket>b__23_1(System.Byte[])
extern void Client_U3CInitWebsocketU3Eb__23_1_m076D3CFDCC45906F30400A6E998940EB5BAA72CE (void);
// 0x00000015 System.Void Unity.Services.Wire.Internal.Client::<InitWebsocket>b__23_2(System.String)
extern void Client_U3CInitWebsocketU3Eb__23_2_m4C690CFA440DB3EB6F63FA2DFC198DF9295E94A7 (void);
// 0x00000016 System.Void Unity.Services.Wire.Internal.Client::<InitWebsocket>b__23_3(Unity.Services.Wire.Internal.WebSocketCloseCode)
extern void Client_U3CInitWebsocketU3Eb__23_3_mAA05736FB86F2CA81AAD0AB936D8FB53BEC4FBB0 (void);
// 0x00000017 System.Threading.Tasks.Task Unity.Services.Wire.Internal.Client::<InitWebsocket>b__23_4()
extern void Client_U3CInitWebsocketU3Eb__23_4_mF0BB39C1D046B0A8178B208652EE710BAF631389 (void);
// 0x00000018 System.Void Unity.Services.Wire.Internal.Client/<SendCommandAsync>d__18::MoveNext()
extern void U3CSendCommandAsyncU3Ed__18_MoveNext_mC5CBA3784A07A5EE5D7EFB991D3A8C5C035FB088 (void);
// 0x00000019 System.Void Unity.Services.Wire.Internal.Client/<SendCommandAsync>d__18::SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine)
extern void U3CSendCommandAsyncU3Ed__18_SetStateMachine_m4ECBCAEF4F92F7F44C437EFC22021E19ED317378 (void);
// 0x0000001A System.Void Unity.Services.Wire.Internal.Client/<PingAsync>d__19::MoveNext()
extern void U3CPingAsyncU3Ed__19_MoveNext_m70277838B26AEA687BD5C40E98B93C248C0EE662 (void);
// 0x0000001B System.Void Unity.Services.Wire.Internal.Client/<PingAsync>d__19::SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine)
extern void U3CPingAsyncU3Ed__19_SetStateMachine_m1336C48F6CDC3DCF5305FDC64F2DC18F003AA4C4 (void);
// 0x0000001C System.Void Unity.Services.Wire.Internal.Client/<ConnectAsync>d__22::MoveNext()
extern void U3CConnectAsyncU3Ed__22_MoveNext_m9EAF05B00B57DF251AA88492984C4DC66F30D8CC (void);
// 0x0000001D System.Void Unity.Services.Wire.Internal.Client/<ConnectAsync>d__22::SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine)
extern void U3CConnectAsyncU3Ed__22_SetStateMachine_m168F47CB9F5A243E38254AD97461251D2B02077E (void);
// 0x0000001E System.Void Unity.Services.Wire.Internal.Client/<SubscribeAsync>d__30::MoveNext()
extern void U3CSubscribeAsyncU3Ed__30_MoveNext_m30E8A3C188DCE3E2155F73AEB21A789E510371C8 (void);
// 0x0000001F System.Void Unity.Services.Wire.Internal.Client/<SubscribeAsync>d__30::SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine)
extern void U3CSubscribeAsyncU3Ed__30_SetStateMachine_mF0E4EF59D34AEEFEC87328ABD051106F2863BE52 (void);
// 0x00000020 System.Void Unity.Services.Wire.Internal.Client/<>c__DisplayClass31_0::.ctor()
extern void U3CU3Ec__DisplayClass31_0__ctor_m949CFB488B6F11F05669F64AB4DE5F1C1F9A555B (void);
// 0x00000021 System.Void Unity.Services.Wire.Internal.Client/<>c__DisplayClass31_0::<CreateChannel>b__0(System.Threading.Tasks.TaskCompletionSource`1<System.Boolean>)
extern void U3CU3Ec__DisplayClass31_0_U3CCreateChannelU3Eb__0_m4B6FA4FABD1C64481D39841A890D7372BF534B3A (void);
// 0x00000022 System.Void Unity.Services.Wire.Internal.Client/<>c__DisplayClass31_0::<CreateChannel>b__1(System.Threading.Tasks.TaskCompletionSource`1<System.Boolean>)
extern void U3CU3Ec__DisplayClass31_0_U3CCreateChannelU3Eb__1_m152D356FD9AC966ACC1EABC547C9EEAC785FB71E (void);
// 0x00000023 System.Void Unity.Services.Wire.Internal.Client/<>c__DisplayClass31_0::<CreateChannel>b__2()
extern void U3CU3Ec__DisplayClass31_0_U3CCreateChannelU3Eb__2_m2F67C59CC9EBCBEA0C636E99E6B1F92C57499DC6 (void);
// 0x00000024 System.Void Unity.Services.Wire.Internal.Client/<>c__DisplayClass31_0::<CreateChannel>b__3()
extern void U3CU3Ec__DisplayClass31_0_U3CCreateChannelU3Eb__3_m6FB435F566A6F7F164C08E89804DEC1A6B06D386 (void);
// 0x00000025 System.Void Unity.Services.Wire.Internal.Client/<>c__DisplayClass31_0/<<CreateChannel>b__0>d::MoveNext()
extern void U3CU3CCreateChannelU3Eb__0U3Ed_MoveNext_m1B81EC825A86D84DC6F738340AB292A88F9A4BC9 (void);
// 0x00000026 System.Void Unity.Services.Wire.Internal.Client/<>c__DisplayClass31_0/<<CreateChannel>b__0>d::SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine)
extern void U3CU3CCreateChannelU3Eb__0U3Ed_SetStateMachine_m8FFDE42F9D2EF6EDB395979E411AD40E6C251E52 (void);
// 0x00000027 System.Void Unity.Services.Wire.Internal.Client/<>c__DisplayClass31_0/<<CreateChannel>b__1>d::MoveNext()
extern void U3CU3CCreateChannelU3Eb__1U3Ed_MoveNext_mB70B3EB967112BF674E9571FC9F295A079A80828 (void);
// 0x00000028 System.Void Unity.Services.Wire.Internal.Client/<>c__DisplayClass31_0/<<CreateChannel>b__1>d::SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine)
extern void U3CU3CCreateChannelU3Eb__1U3Ed_SetStateMachine_m42E7817CAD2C56FA1D154CFEE142FBEB04D2373A (void);
// 0x00000029 System.Void Unity.Services.Wire.Internal.Client/<UnsubscribeAsync>d__32::MoveNext()
extern void U3CUnsubscribeAsyncU3Ed__32_MoveNext_m19AE7F04ADB21AD2D6E624297E3974147FBCF9CB (void);
// 0x0000002A System.Void Unity.Services.Wire.Internal.Client/<UnsubscribeAsync>d__32::SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine)
extern void U3CUnsubscribeAsyncU3Ed__32_SetStateMachine_m807463D3132C01F6C18DC03C2B27FAE6C8BAE7D4 (void);
// 0x0000002B System.Void Unity.Services.Wire.Internal.Client/<<InitWebsocket>b__23_0>d::MoveNext()
extern void U3CU3CInitWebsocketU3Eb__23_0U3Ed_MoveNext_m2C1B7E3261362E6A8C955C7C6DD863E743B8B287 (void);
// 0x0000002C System.Void Unity.Services.Wire.Internal.Client/<<InitWebsocket>b__23_0>d::SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine)
extern void U3CU3CInitWebsocketU3Eb__23_0U3Ed_SetStateMachine_m84728E19C6B61D0103671D24BD0DEED4E4BBDAF8 (void);
// 0x0000002D System.Void Unity.Services.Wire.Internal.Client/<<InitWebsocket>b__23_4>d::MoveNext()
extern void U3CU3CInitWebsocketU3Eb__23_4U3Ed_MoveNext_mE1533FE88894AF6EE00D3A569BD097C297074B0A (void);
// 0x0000002E System.Void Unity.Services.Wire.Internal.Client/<<InitWebsocket>b__23_4>d::SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine)
extern void U3CU3CInitWebsocketU3Eb__23_4U3Ed_SetStateMachine_m9112CBF1A820AE64AEAFFB373189584A190873E6 (void);
// 0x0000002F System.Void Unity.Services.Wire.Internal.Client/<<InitWebsocket>b__23_3>d::MoveNext()
extern void U3CU3CInitWebsocketU3Eb__23_3U3Ed_MoveNext_m608E4397BF86FE02A55C3CFA544515FBC65A05CC (void);
// 0x00000030 System.Void Unity.Services.Wire.Internal.Client/<<InitWebsocket>b__23_3>d::SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine)
extern void U3CU3CInitWebsocketU3Eb__23_3U3Ed_SetStateMachine_m8A3E52A0112869DCA40392551A6275F2AE64B729 (void);
// 0x00000031 System.Void Unity.Services.Wire.Internal.CommandManager::.ctor(Unity.Services.Wire.Internal.Configuration,Unity.Services.Core.Scheduler.Internal.IActionScheduler)
extern void CommandManager__ctor_mDB2AB302A1D9FFCA31DDC11B19BBF1AE2337B8B8 (void);
// 0x00000032 System.Void Unity.Services.Wire.Internal.CommandManager::RegisterCommand(System.UInt32)
extern void CommandManager_RegisterCommand_m499EA52A16E50AAF0CAEA60B77C5DCD9FF599668 (void);
// 0x00000033 System.Threading.Tasks.Task`1<Unity.Services.Wire.Internal.Reply> Unity.Services.Wire.Internal.CommandManager::WaitForCommandAsync(System.UInt32)
extern void CommandManager_WaitForCommandAsync_m19454F5D83FEBC8085B8AF543503D257C11F6995 (void);
// 0x00000034 System.Void Unity.Services.Wire.Internal.CommandManager::OnDisconnect(System.Exception)
extern void CommandManager_OnDisconnect_m3DE7DEE21B8521F111BF9DED2F86FBD816437107 (void);
// 0x00000035 System.Void Unity.Services.Wire.Internal.CommandManager::OnCommandReplyReceived(Unity.Services.Wire.Internal.Reply)
extern void CommandManager_OnCommandReplyReceived_mF706C17D158D7632B52BAC449E342F06A528B26F (void);
// 0x00000036 System.Exception Unity.Services.Wire.Internal.CommandManager::CentrifugeErrorToException(Unity.Services.Wire.Internal.CentrifugeError)
extern void CommandManager_CentrifugeErrorToException_mF241B057243EA3DAF0F0816B89DF8BBEB9F2DA76 (void);
// 0x00000037 System.Void Unity.Services.Wire.Internal.CommandManager/<>c__DisplayClass4_0::.ctor()
extern void U3CU3Ec__DisplayClass4_0__ctor_m9362DE73C9A175229CB0DCBEFCD99D482BBC2AD4 (void);
// 0x00000038 System.Void Unity.Services.Wire.Internal.CommandManager/<>c__DisplayClass4_0::<RegisterCommand>b__0()
extern void U3CU3Ec__DisplayClass4_0_U3CRegisterCommandU3Eb__0_mCCA1DF68C5AA0F0BBFF502CE95488E3CC8B4C259 (void);
// 0x00000039 System.Void Unity.Services.Wire.Internal.CommandManager/<WaitForCommandAsync>d__5::MoveNext()
extern void U3CWaitForCommandAsyncU3Ed__5_MoveNext_mF581A48ADC1897BD903F2B2530A0DE05910D42B8 (void);
// 0x0000003A System.Void Unity.Services.Wire.Internal.CommandManager/<WaitForCommandAsync>d__5::SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine)
extern void U3CWaitForCommandAsyncU3Ed__5_SetStateMachine_mE13865B8D7D00349E5E19CF11AF2D25BCCE4670D (void);
// 0x0000003B System.Void Unity.Services.Wire.Internal.ISubscriptionRepository::add_SubscriptionCountChanged(System.Action`1<System.Int32>)
// 0x0000003C System.Void Unity.Services.Wire.Internal.ISubscriptionRepository::remove_SubscriptionCountChanged(System.Action`1<System.Int32>)
// 0x0000003D System.Boolean Unity.Services.Wire.Internal.ISubscriptionRepository::IsAlreadySubscribed(Unity.Services.Wire.Internal.Subscription)
// 0x0000003E System.Boolean Unity.Services.Wire.Internal.ISubscriptionRepository::IsRecovering(Unity.Services.Wire.Internal.Subscription)
// 0x0000003F System.Void Unity.Services.Wire.Internal.ISubscriptionRepository::OnSubscriptionComplete(Unity.Services.Wire.Internal.Subscription,Unity.Services.Wire.Internal.Reply)
// 0x00000040 Unity.Services.Wire.Internal.Subscription Unity.Services.Wire.Internal.ISubscriptionRepository::GetSub(Unity.Services.Wire.Internal.Subscription)
// 0x00000041 Unity.Services.Wire.Internal.Subscription Unity.Services.Wire.Internal.ISubscriptionRepository::GetSub(System.String)
// 0x00000042 System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,Unity.Services.Wire.Internal.Subscription>> Unity.Services.Wire.Internal.ISubscriptionRepository::GetAll()
// 0x00000043 System.Void Unity.Services.Wire.Internal.ISubscriptionRepository::RemoveSub(Unity.Services.Wire.Internal.Subscription)
// 0x00000044 System.Void Unity.Services.Wire.Internal.ISubscriptionRepository::OnSocketClosed()
// 0x00000045 System.Void Unity.Services.Wire.Internal.ISubscriptionRepository::RecoverSubscriptions(Unity.Services.Wire.Internal.Reply)
// 0x00000046 System.Boolean Unity.Services.Wire.Internal.ISubscriptionRepository::get_IsEmpty()
// 0x00000047 System.Boolean Unity.Services.Wire.Internal.ISubscriptionRepository::ServerHasSubscription(Unity.Services.Wire.Internal.Subscription)
// 0x00000048 System.Void Unity.Services.Wire.Internal.ISubscriptionRepository::PromoteSubscriptionHandle(Unity.Services.Wire.Internal.Subscription)
// 0x00000049 System.Boolean Unity.Services.Wire.Internal.ConcurrentDictSubscriptionRepository::get_IsEmpty()
extern void ConcurrentDictSubscriptionRepository_get_IsEmpty_mDCBDA8F41BD693E70C3356F2E2D9E09D1391518E (void);
// 0x0000004A System.Void Unity.Services.Wire.Internal.ConcurrentDictSubscriptionRepository::add_SubscriptionCountChanged(System.Action`1<System.Int32>)
extern void ConcurrentDictSubscriptionRepository_add_SubscriptionCountChanged_m0A8DCA26F7820BE331EFD66370768F381EE3C90B (void);
// 0x0000004B System.Void Unity.Services.Wire.Internal.ConcurrentDictSubscriptionRepository::remove_SubscriptionCountChanged(System.Action`1<System.Int32>)
extern void ConcurrentDictSubscriptionRepository_remove_SubscriptionCountChanged_mDAF7A34C202545B1C67572A653C26C6F573E9934 (void);
// 0x0000004C System.Void Unity.Services.Wire.Internal.ConcurrentDictSubscriptionRepository::.ctor()
extern void ConcurrentDictSubscriptionRepository__ctor_m5B5A05C1E3BAA1838CB14243E41B7C22509BA92E (void);
// 0x0000004D System.Boolean Unity.Services.Wire.Internal.ConcurrentDictSubscriptionRepository::IsAlreadySubscribed(System.String)
extern void ConcurrentDictSubscriptionRepository_IsAlreadySubscribed_m307986E233B9A62AFB6D953D15FF54CA48E68660 (void);
// 0x0000004E System.Boolean Unity.Services.Wire.Internal.ConcurrentDictSubscriptionRepository::IsAlreadySubscribed(Unity.Services.Wire.Internal.Subscription)
extern void ConcurrentDictSubscriptionRepository_IsAlreadySubscribed_m9F4E28AB1C888C91E173810180E2FAD563EB68B5 (void);
// 0x0000004F System.Boolean Unity.Services.Wire.Internal.ConcurrentDictSubscriptionRepository::IsRecovering(Unity.Services.Wire.Internal.Subscription)
extern void ConcurrentDictSubscriptionRepository_IsRecovering_m220BD078856898E48B5E087BF4278677F4454F65 (void);
// 0x00000050 System.Void Unity.Services.Wire.Internal.ConcurrentDictSubscriptionRepository::OnSubscriptionComplete(Unity.Services.Wire.Internal.Subscription,Unity.Services.Wire.Internal.Reply)
extern void ConcurrentDictSubscriptionRepository_OnSubscriptionComplete_m314D2CB2255FFE68A681CEA142C691FCB5813CE2 (void);
// 0x00000051 Unity.Services.Wire.Internal.Subscription Unity.Services.Wire.Internal.ConcurrentDictSubscriptionRepository::GetSub(System.String)
extern void ConcurrentDictSubscriptionRepository_GetSub_m884B96E9B4108783450F8EF75EC897D416CE79E9 (void);
// 0x00000052 Unity.Services.Wire.Internal.Subscription Unity.Services.Wire.Internal.ConcurrentDictSubscriptionRepository::GetSub(Unity.Services.Wire.Internal.Subscription)
extern void ConcurrentDictSubscriptionRepository_GetSub_m6C04A118C93DAFEF4F97AC40BAF592F3E44E312D (void);
// 0x00000053 System.Void Unity.Services.Wire.Internal.ConcurrentDictSubscriptionRepository::RemoveSub(Unity.Services.Wire.Internal.Subscription)
extern void ConcurrentDictSubscriptionRepository_RemoveSub_mEDAC86ABEC24DF508F14DABAA14CC5B1B1051461 (void);
// 0x00000054 System.Boolean Unity.Services.Wire.Internal.ConcurrentDictSubscriptionRepository::ServerHasSubscription(Unity.Services.Wire.Internal.Subscription)
extern void ConcurrentDictSubscriptionRepository_ServerHasSubscription_m1EA451103899960453F16A5E57E1FB0514989777 (void);
// 0x00000055 System.Void Unity.Services.Wire.Internal.ConcurrentDictSubscriptionRepository::PromoteSubscriptionHandle(Unity.Services.Wire.Internal.Subscription)
extern void ConcurrentDictSubscriptionRepository_PromoteSubscriptionHandle_mD6338FD0FF16F1BA1F2910A87853A940980F2F8D (void);
// 0x00000056 System.Void Unity.Services.Wire.Internal.ConcurrentDictSubscriptionRepository::AddSub(Unity.Services.Wire.Internal.Subscription)
extern void ConcurrentDictSubscriptionRepository_AddSub_m8D3523110C4753052AC50CFB85D370F78E0AC172 (void);
// 0x00000057 System.Void Unity.Services.Wire.Internal.ConcurrentDictSubscriptionRepository::AddSubscriptionHandle(Unity.Services.Wire.Internal.SubscriptionHandle)
extern void ConcurrentDictSubscriptionRepository_AddSubscriptionHandle_mB8596DC4E17AFF43CE13431F4E918BE5CC86600A (void);
// 0x00000058 System.Void Unity.Services.Wire.Internal.ConcurrentDictSubscriptionRepository::OnSocketClosed()
extern void ConcurrentDictSubscriptionRepository_OnSocketClosed_m6E3D436904775E76E0F51246C44881E42F1EDEDC (void);
// 0x00000059 System.Void Unity.Services.Wire.Internal.ConcurrentDictSubscriptionRepository::RecoverSubscriptions(Unity.Services.Wire.Internal.Reply)
extern void ConcurrentDictSubscriptionRepository_RecoverSubscriptions_m64F85DC515D6C46626FB00F33A446A5A973BD8C7 (void);
// 0x0000005A System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,Unity.Services.Wire.Internal.Subscription>> Unity.Services.Wire.Internal.ConcurrentDictSubscriptionRepository::GetAll()
extern void ConcurrentDictSubscriptionRepository_GetAll_mE2D2026158799FFEB5C6C5AD919397C639ECEDA3 (void);
// 0x0000005B System.Void Unity.Services.Wire.Internal.CentrifugeError::.ctor()
extern void CentrifugeError__ctor_mF36E82A55ABD8585DC741B7984E6EEA8D6BB4A57 (void);
// 0x0000005C System.UInt32 Unity.Services.Wire.Internal.CommandID::GenerateNewId()
extern void CommandID_GenerateNewId_mDCA50A36C15BC69EB62CDAB2EF3B0960DF64F326 (void);
// 0x0000005D System.String Unity.Services.Wire.Internal.Message::Serialize()
extern void Message_Serialize_mCC4D5CB45472189D88BCF16C41052A879E554D8C (void);
// 0x0000005E System.Byte[] Unity.Services.Wire.Internal.Message::GetBytes()
extern void Message_GetBytes_m0A192CCC12E1180CB314892A9FE93B6C4950ABF6 (void);
// 0x0000005F System.String Unity.Services.Wire.Internal.Message::GetMethod()
// 0x00000060 System.Void Unity.Services.Wire.Internal.Message::.ctor()
extern void Message__ctor_mDFCDF1E53B7F559C3E2E2663D7DD6534D165329B (void);
// 0x00000061 System.Void Unity.Services.Wire.Internal.Command`1::.ctor(Unity.Services.Wire.Internal.Message/Method,RequestClass)
// 0x00000062 Unity.Services.Wire.Internal.Command`1<RequestClass> Unity.Services.Wire.Internal.Command`1::FromJSON(System.Byte[])
// 0x00000063 System.String Unity.Services.Wire.Internal.Command`1::GetMethod()
// 0x00000064 System.Void Unity.Services.Wire.Internal.ConnectRequest::.ctor(System.String)
extern void ConnectRequest__ctor_m9E0005FFD34CFF0B0D4846D117FC431B9ECE5A64 (void);
// 0x00000065 System.Void Unity.Services.Wire.Internal.ConnectRequest::.ctor(System.String,System.Collections.Generic.Dictionary`2<System.String,Unity.Services.Wire.Internal.SubscribeRequest>)
extern void ConnectRequest__ctor_m158F3339C5019437245A04DF6557D968935AF741 (void);
// 0x00000066 System.String Unity.Services.Wire.Internal.ConnectRequest::GetMethod()
extern void ConnectRequest_GetMethod_m81636D10D9E5AADD3BF09C93B3284B88265B023C (void);
// 0x00000067 System.Threading.Tasks.Task`1<System.Collections.Generic.Dictionary`2<System.String,Unity.Services.Wire.Internal.SubscribeRequest>> Unity.Services.Wire.Internal.SubscribeRequest::getRequestFromRepo(Unity.Services.Wire.Internal.ISubscriptionRepository)
extern void SubscribeRequest_getRequestFromRepo_m4A95CD59A368B47550BFFC78FF86775E7BFE29A0 (void);
// 0x00000068 System.String Unity.Services.Wire.Internal.SubscribeRequest::GetMethod()
extern void SubscribeRequest_GetMethod_mA7A3D03F927D506681AB137CC45FFA88267E57D9 (void);
// 0x00000069 System.Void Unity.Services.Wire.Internal.SubscribeRequest::.ctor()
extern void SubscribeRequest__ctor_m41177C54A1CB9118E3A1B78379264284AA39ADB5 (void);
// 0x0000006A System.Void Unity.Services.Wire.Internal.SubscribeRequest/<getRequestFromRepo>d__5::MoveNext()
extern void U3CgetRequestFromRepoU3Ed__5_MoveNext_mFF5CADB8708DCCBA517D3898A27F52B511AD6060 (void);
// 0x0000006B System.Void Unity.Services.Wire.Internal.SubscribeRequest/<getRequestFromRepo>d__5::SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine)
extern void U3CgetRequestFromRepoU3Ed__5_SetStateMachine_m3875AF79AA83DFCEBE86C9A0230D2916EF47B833 (void);
// 0x0000006C System.String Unity.Services.Wire.Internal.UnsubscribeRequest::GetMethod()
extern void UnsubscribeRequest_GetMethod_mEDE3FC5C70F797AADA53E710FAD710D509A38704 (void);
// 0x0000006D System.Void Unity.Services.Wire.Internal.UnsubscribeRequest::.ctor()
extern void UnsubscribeRequest__ctor_mBE808DE13CE6AFB6ED0D7EDE9B9DC6064BA8F3F0 (void);
// 0x0000006E System.Void Unity.Services.Wire.Internal.SubscribeResult::.ctor()
extern void SubscribeResult__ctor_m81BA388CA0379BB248BC0877B7B38458C479AE62 (void);
// 0x0000006F System.Void Unity.Services.Wire.Internal.ClientInfo::.ctor()
extern void ClientInfo__ctor_m97BB0376514FF65B8D8116B27EBB28BFABF5B0E1 (void);
// 0x00000070 System.Void Unity.Services.Wire.Internal.Reply::.ctor(System.UInt32,Unity.Services.Wire.Internal.CentrifugeError,Unity.Services.Wire.Internal.Result)
extern void Reply__ctor_m10C30FBB23033703D17FD1732AED9C9F3B89F69F (void);
// 0x00000071 Unity.Services.Wire.Internal.Reply Unity.Services.Wire.Internal.Reply::FromJson(System.Byte[])
extern void Reply_FromJson_m38A8C1CF31BB337E458BFA45B2401C6289356116 (void);
// 0x00000072 Unity.Services.Wire.Internal.Reply Unity.Services.Wire.Internal.Reply::FromJson(System.String)
extern void Reply_FromJson_m9E9FDA6EB61BBBE87FC6231C02FE841395B9556B (void);
// 0x00000073 System.Byte[] Unity.Services.Wire.Internal.Reply::ToJson()
extern void Reply_ToJson_mD8D0D8B973DBA85031EBBE06956E616FDFFDF925 (void);
// 0x00000074 System.Boolean Unity.Services.Wire.Internal.Reply::HasError()
extern void Reply_HasError_m84A554BF0C72D1D1ACFD413978F2E728AB1AAA6A (void);
// 0x00000075 Unity.Services.Wire.Internal.ConnectResult Unity.Services.Wire.Internal.Result::ToConnectionResult()
extern void Result_ToConnectionResult_m6B70DCC0E6F9D1E275604522F51CA64FFBDA8C19 (void);
// 0x00000076 Unity.Services.Wire.Internal.SubscribeResult Unity.Services.Wire.Internal.Result::ToSubscribeResult()
extern void Result_ToSubscribeResult_m3D49D83597186280A21DF7F5BE3B029A1DD2CD84 (void);
// 0x00000077 System.Void Unity.Services.Wire.Internal.Result::.ctor()
extern void Result__ctor_m69D0B573B49FEC03EA5CCF81CC7A7747EF422D6E (void);
// 0x00000078 System.Void Unity.Services.Wire.Internal.ConnectResult::.ctor()
extern void ConnectResult__ctor_mFEA0A0B544F09356BBBB64EBD46A77F8B49C81ED (void);
// 0x00000079 System.Void Unity.Services.Wire.Internal.PingRequest::.ctor()
extern void PingRequest__ctor_m800ABD6D9348277C0CE0E0F45294A258E5400C77 (void);
// 0x0000007A System.Void Unity.Services.Wire.Internal.PingResult::.ctor()
extern void PingResult__ctor_m33E6A94E35E32B0CB69ED24704F8234FC571016B (void);
// 0x0000007B System.Void Unity.Services.Wire.Internal.CentrifugePayload::.ctor()
extern void CentrifugePayload__ctor_m0AD46B76E77ABD191EC41CFD1E56609699669B1D (void);
// 0x0000007C System.Collections.Generic.IEnumerable`1<System.String> Unity.Services.Wire.Internal.BatchMessages::SplitMessages(System.String)
extern void BatchMessages_SplitMessages_mD7604E8FF25D5A2260986757F3414C7A2D102FE8 (void);
// 0x0000007D System.Collections.Generic.IEnumerable`1<System.String> Unity.Services.Wire.Internal.BatchMessages::SplitMessages(System.Byte[])
extern void BatchMessages_SplitMessages_m73BB9C0D5510E54C10F5338D8196BF6DCFF47B30 (void);
// 0x0000007E System.Void Unity.Services.Wire.Internal.BatchMessages::FixJsonSplit(System.String[]&)
extern void BatchMessages_FixJsonSplit_mD41A0362F5DF538275F556660FB253B56BDD2D44 (void);
// 0x0000007F System.Void Unity.Services.Wire.Internal.Subscription::add_MessageReceived(System.Action`1<System.String>)
extern void Subscription_add_MessageReceived_m45F687C9418C3E26F7903AD46E2ACE7470CD0C72 (void);
// 0x00000080 System.Void Unity.Services.Wire.Internal.Subscription::remove_MessageReceived(System.Action`1<System.String>)
extern void Subscription_remove_MessageReceived_m5BE7378074118954C05290EBE2ED2AB24269390D (void);
// 0x00000081 System.Void Unity.Services.Wire.Internal.Subscription::add_BinaryMessageReceived(System.Action`1<System.Byte[]>)
extern void Subscription_add_BinaryMessageReceived_m7B138B43B29146A14A24CC2C9CF872DA6CAA5987 (void);
// 0x00000082 System.Void Unity.Services.Wire.Internal.Subscription::remove_BinaryMessageReceived(System.Action`1<System.Byte[]>)
extern void Subscription_remove_BinaryMessageReceived_m579B51F514977EC0C7C707BCEC1FF3030A76E572 (void);
// 0x00000083 System.Void Unity.Services.Wire.Internal.Subscription::add_KickReceived(System.Action)
extern void Subscription_add_KickReceived_m5AEF149F83D56B7FF98196CFF972B4BAAF0D7626 (void);
// 0x00000084 System.Void Unity.Services.Wire.Internal.Subscription::remove_KickReceived(System.Action)
extern void Subscription_remove_KickReceived_mFAB75764B0CFB55C72E3E710A7EF70E3038AD5E2 (void);
// 0x00000085 System.Void Unity.Services.Wire.Internal.Subscription::add_NewStateReceived(System.Action`1<Unity.Services.Wire.Internal.SubscriptionState>)
extern void Subscription_add_NewStateReceived_mCE68E2C38BA11E851901A675DE659FEA7EC22D6F (void);
// 0x00000086 System.Void Unity.Services.Wire.Internal.Subscription::remove_NewStateReceived(System.Action`1<Unity.Services.Wire.Internal.SubscriptionState>)
extern void Subscription_remove_NewStateReceived_mAA9C3B52DC9842B0E979EF9DB8F27FC94EA28401 (void);
// 0x00000087 System.Void Unity.Services.Wire.Internal.Subscription::add_UnsubscribeReceived(System.Action`1<System.Threading.Tasks.TaskCompletionSource`1<System.Boolean>>)
extern void Subscription_add_UnsubscribeReceived_m79B4A788760B43316DC0125B2010776057FD9CCF (void);
// 0x00000088 System.Void Unity.Services.Wire.Internal.Subscription::remove_UnsubscribeReceived(System.Action`1<System.Threading.Tasks.TaskCompletionSource`1<System.Boolean>>)
extern void Subscription_remove_UnsubscribeReceived_m630A4BFD1FFDC1C93532B921BF299533B04D0E77 (void);
// 0x00000089 System.Void Unity.Services.Wire.Internal.Subscription::add_SubscribeReceived(System.Action`1<System.Threading.Tasks.TaskCompletionSource`1<System.Boolean>>)
extern void Subscription_add_SubscribeReceived_m4E0FA5F3E71142081031A98747B69B402FFD0D9F (void);
// 0x0000008A System.Void Unity.Services.Wire.Internal.Subscription::remove_SubscribeReceived(System.Action`1<System.Threading.Tasks.TaskCompletionSource`1<System.Boolean>>)
extern void Subscription_remove_SubscribeReceived_m515DFB1CCDE7305D0BAA1E2E0C1334FB9B350E43 (void);
// 0x0000008B System.Void Unity.Services.Wire.Internal.Subscription::add_ErrorReceived(System.Action`1<System.String>)
extern void Subscription_add_ErrorReceived_m34BF0846B62F7BD4F5414B321ECE24A6A6B07B5E (void);
// 0x0000008C System.Void Unity.Services.Wire.Internal.Subscription::remove_ErrorReceived(System.Action`1<System.String>)
extern void Subscription_remove_ErrorReceived_m03A1D0471B2C6B73BD7F216666A8248E19F0D861 (void);
// 0x0000008D System.Void Unity.Services.Wire.Internal.Subscription::add_DisposeReceived(System.Action)
extern void Subscription_add_DisposeReceived_m23C473626CE7507C8C77166808D30FAFC130002F (void);
// 0x0000008E System.Void Unity.Services.Wire.Internal.Subscription::remove_DisposeReceived(System.Action)
extern void Subscription_remove_DisposeReceived_m1AE439FAA1273F0197BED8F35DF712EE6EA7524B (void);
// 0x0000008F System.Boolean Unity.Services.Wire.Internal.Subscription::get_IsConnected()
extern void Subscription_get_IsConnected_mB9216ABBCDBAE0D46F3B5B8B1331AD39E047B38E (void);
// 0x00000090 System.Void Unity.Services.Wire.Internal.Subscription::.ctor(Unity.Services.Wire.Internal.IChannelTokenProvider,Unity.Services.Core.Threading.Internal.IUnityThreadUtils)
extern void Subscription__ctor_m7FFEBE40A4E2C06ADEBE152ECA6285DF4E735C4A (void);
// 0x00000091 System.Threading.Tasks.Task`1<System.String> Unity.Services.Wire.Internal.Subscription::RetrieveTokenAsync()
extern void Subscription_RetrieveTokenAsync_m04C551A5D474A468F4D31107EAEA92F51457EC3B (void);
// 0x00000092 System.Void Unity.Services.Wire.Internal.Subscription::ValidateTokenData(System.String,System.String)
extern void Subscription_ValidateTokenData_m36FF0626FDA7145EDA7C117648F5FE361098B62E (void);
// 0x00000093 System.Void Unity.Services.Wire.Internal.Subscription::OnMessageReceived(Unity.Services.Wire.Internal.Reply)
extern void Subscription_OnMessageReceived_m0853AAB92286C5996089095611A223CCC6CD3403 (void);
// 0x00000094 System.Void Unity.Services.Wire.Internal.Subscription::OnUnsubscriptionComplete()
extern void Subscription_OnUnsubscriptionComplete_mDB9EDA65B042F48DB994661EF0DA768F3EF25E08 (void);
// 0x00000095 System.Void Unity.Services.Wire.Internal.Subscription::OnKickReceived()
extern void Subscription_OnKickReceived_m7683A7B7E9792652FDF33C9FEE0E326785163DD5 (void);
// 0x00000096 System.Void Unity.Services.Wire.Internal.Subscription::OnConnectivityChangeReceived(System.Boolean)
extern void Subscription_OnConnectivityChangeReceived_m619708B123B70CE26827D2A84CA64FF32D0FDEB8 (void);
// 0x00000097 System.Void Unity.Services.Wire.Internal.Subscription::Finalize()
extern void Subscription_Finalize_mDC064A5C9B5EF53C03EAAF2F20A15163C5F6538A (void);
// 0x00000098 System.Void Unity.Services.Wire.Internal.Subscription::Dispose()
extern void Subscription_Dispose_m98EC655F45EAB329460428C69115B9BEB2F57EB7 (void);
// 0x00000099 System.Void Unity.Services.Wire.Internal.Subscription::Dispose(System.Boolean)
extern void Subscription_Dispose_m49B62DA76576EE90828E773618B61D1155E1060E (void);
// 0x0000009A System.Threading.Tasks.Task Unity.Services.Wire.Internal.Subscription::SubscribeAsync()
extern void Subscription_SubscribeAsync_m7F3C5520AF0F3C1DB793D89704EB6936821FD59C (void);
// 0x0000009B System.Threading.Tasks.Task Unity.Services.Wire.Internal.Subscription::UnsubscribeAsync()
extern void Subscription_UnsubscribeAsync_m9456CFFF76626818FB007E05C68B2D9DD6BCC17A (void);
// 0x0000009C System.Void Unity.Services.Wire.Internal.Subscription::OnError(System.String)
extern void Subscription_OnError_mEA9D3AEB1F15B385B5FD262AFF7B65FAFED1C526 (void);
// 0x0000009D System.Void Unity.Services.Wire.Internal.Subscription::<OnKickReceived>b__38_0()
extern void Subscription_U3COnKickReceivedU3Eb__38_0_m701C160E7FFD7A397249E7B1AB75FDACE9D1DFDD (void);
// 0x0000009E System.Void Unity.Services.Wire.Internal.Subscription/<RetrieveTokenAsync>d__34::MoveNext()
extern void U3CRetrieveTokenAsyncU3Ed__34_MoveNext_mFC04DF66014CE710F1BB1D4CC31B2251179C5A92 (void);
// 0x0000009F System.Void Unity.Services.Wire.Internal.Subscription/<RetrieveTokenAsync>d__34::SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine)
extern void U3CRetrieveTokenAsyncU3Ed__34_SetStateMachine_m830A1FB515BA7CD10A5C47F26091327A77569001 (void);
// 0x000000A0 System.Void Unity.Services.Wire.Internal.Subscription/<>c__DisplayClass36_0::.ctor()
extern void U3CU3Ec__DisplayClass36_0__ctor_mA833E461FD9151626A52C07D0243F90178013C2D (void);
// 0x000000A1 System.Void Unity.Services.Wire.Internal.Subscription/<>c__DisplayClass36_0::<OnMessageReceived>b__0()
extern void U3CU3Ec__DisplayClass36_0_U3COnMessageReceivedU3Eb__0_m5F9479CB9C9EEE19D5EE96E107142D08DFD036CE (void);
// 0x000000A2 System.Void Unity.Services.Wire.Internal.Subscription/<>c__DisplayClass36_0::<OnMessageReceived>b__1()
extern void U3CU3Ec__DisplayClass36_0_U3COnMessageReceivedU3Eb__1_m160541AA58B3248C4B70F467336AA68126C9F8F7 (void);
// 0x000000A3 System.Void Unity.Services.Wire.Internal.WireMessage::.ctor()
extern void WireMessage__ctor_mB9B3B62E1A47EF900B57DC3117AAA8FC6648EF7C (void);
// 0x000000A4 System.Void Unity.Services.Wire.Internal.Configuration::.ctor()
extern void Configuration__ctor_mA9C1953CECDB2A5D27FD82531DAEB4A596B131D8 (void);
// 0x000000A5 System.Void Unity.Services.Wire.Internal.NoChannelPublicationException::.ctor(System.String)
extern void NoChannelPublicationException__ctor_mE6623605021328CDA669765F2EFF3A3CB88082ED (void);
// 0x000000A6 System.Void Unity.Services.Wire.Internal.AlreadySubscribedException::.ctor(System.String)
extern void AlreadySubscribedException__ctor_mF5BC71FA65DB0ABECB651B98959856ECD240F844 (void);
// 0x000000A7 System.Void Unity.Services.Wire.Internal.AlreadyUnsubscribedException::.ctor(System.String)
extern void AlreadyUnsubscribedException__ctor_m07CA9ADBE6B33ADFC385C426235327E900FD275A (void);
// 0x000000A8 System.Void Unity.Services.Wire.Internal.UnknownCommandReplyException::.ctor(System.UInt32)
extern void UnknownCommandReplyException__ctor_m4780EE3FB8E8CD9F9A9F1CBE2060F017AF381D9C (void);
// 0x000000A9 System.Void Unity.Services.Wire.Internal.CommandInterruptedException::.ctor(System.String,Unity.Services.Wire.Internal.CentrifugeCloseCode)
extern void CommandInterruptedException__ctor_m869E30D5591AEFC463BD522A95C4741B48E57ECB (void);
// 0x000000AA Unity.Services.Wire.Internal.CentrifugeCloseCode Unity.Services.Wire.Internal.CommandInterruptedException::get_m_Code()
extern void CommandInterruptedException_get_m_Code_mAEACB41BACF9DB5CDC09907FB385169724105CB2 (void);
// 0x000000AB System.Void Unity.Services.Wire.Internal.CommandInterruptedException::set_m_Code(Unity.Services.Wire.Internal.CentrifugeCloseCode)
extern void CommandInterruptedException_set_m_Code_m73910E7D09C1CA6F0D27A0CD235FB98BF9DAAC79 (void);
// 0x000000AC System.Void Unity.Services.Wire.Internal.CommandNotFoundException::.ctor(System.UInt32)
extern void CommandNotFoundException__ctor_m459973D71326AA3AD6335B41553E40988DF6805D (void);
// 0x000000AD System.Void Unity.Services.Wire.Internal.CommandAlreadyExists::.ctor(System.UInt32)
extern void CommandAlreadyExists__ctor_m97DAFCF8BE60C46EBA8E8A3ADD46E6A660C51B8C (void);
// 0x000000AE System.Void Unity.Services.Wire.Internal.EmptyChannelException::.ctor()
extern void EmptyChannelException__ctor_mF8111C786C460C113E9C0FDEF7201D4915E80807 (void);
// 0x000000AF System.Void Unity.Services.Wire.Internal.EmptyTokenException::.ctor()
extern void EmptyTokenException__ctor_m2F8B8F6650767F4CFD987B131478F950206F369A (void);
// 0x000000B0 System.Void Unity.Services.Wire.Internal.ChannelChangedException::.ctor(System.String,System.String)
extern void ChannelChangedException__ctor_m59ABD0EBFBBB5632DBA132AAF06C4D749376F872 (void);
// 0x000000B1 System.Void Unity.Services.Wire.Internal.ConnectionFailedException::.ctor(System.String)
extern void ConnectionFailedException__ctor_m6C3B3C64D49A03E922EA3094B9024C77E354A0BC (void);
// 0x000000B2 Unity.Services.Wire.Internal.IChannel Unity.Services.Wire.Internal.IWireDirect::CreateChannel(System.String,Unity.Services.Wire.Internal.IChannelTokenProvider)
// 0x000000B3 System.String Unity.Services.Wire.Internal.SubscriptionHandle::get_ChannelName()
extern void SubscriptionHandle_get_ChannelName_m4A4DA05A9668E0D1A335EFE9C5527D23272D15D5 (void);
// 0x000000B4 System.Void Unity.Services.Wire.Internal.SubscriptionHandle::.ctor(System.String)
extern void SubscriptionHandle__ctor_mE98AD94ACB75CAEB9535EC4FA70D52D6DA92FBA1 (void);
// 0x000000B5 System.Single Unity.Services.Wire.Internal.IBackoffStrategy::GetNext()
// 0x000000B6 System.Void Unity.Services.Wire.Internal.IBackoffStrategy::Reset()
// 0x000000B7 System.Void Unity.Services.Wire.Internal.ExponentialBackoffStrategy::.ctor()
extern void ExponentialBackoffStrategy__ctor_m81E0608C058DFB6CD18719A50130800FB8B7692D (void);
// 0x000000B8 System.Single Unity.Services.Wire.Internal.ExponentialBackoffStrategy::GetDuration(System.Int32)
extern void ExponentialBackoffStrategy_GetDuration_m71158DF55EA83F61AFED437128C1CD8E73D8A4EA (void);
// 0x000000B9 System.Single Unity.Services.Wire.Internal.ExponentialBackoffStrategy::GetNext()
extern void ExponentialBackoffStrategy_GetNext_mAF0C6B53ABB6A531CA2A8F62461BF2B52829B016 (void);
// 0x000000BA System.Void Unity.Services.Wire.Internal.ExponentialBackoffStrategy::Reset()
extern void ExponentialBackoffStrategy_Reset_mA584E4587BD4BA90872766187B3CDBF8BC5DE2D4 (void);
// 0x000000BB System.Void Unity.Services.Wire.Internal.Logger::Log(System.Object)
extern void Logger_Log_mA52171C1BE8D493F4F9FEE07297B50821B098478 (void);
// 0x000000BC System.Void Unity.Services.Wire.Internal.Logger::LogWarning(System.Object)
extern void Logger_LogWarning_mE49195EB926D5A13B5419BF27601488969509D09 (void);
// 0x000000BD System.Void Unity.Services.Wire.Internal.Logger::LogError(System.Object)
extern void Logger_LogError_mDC5B814CA58DE578418098FB6B782BA674B5CF04 (void);
// 0x000000BE System.Void Unity.Services.Wire.Internal.Logger::LogException(System.Exception)
extern void Logger_LogException_m420D5BE679DE3DC9D7167BBCEC556E2416E3F5E2 (void);
// 0x000000BF System.Void Unity.Services.Wire.Internal.Logger::LogAssertion(System.Object)
extern void Logger_LogAssertion_m4559D96C458DBB023092C028B3791BF33CE7F2C2 (void);
// 0x000000C0 System.Void Unity.Services.Wire.Internal.Logger::LogVerbose(System.Object)
extern void Logger_LogVerbose_m76EDDE40ADDAF928AA6196923E2C0B92BB3419AE (void);
// 0x000000C1 System.Void Unity.Services.Wire.Internal.Logger::.ctor()
extern void Logger__ctor_m016B3C2D5D6B66552345943DDD3172F87315D5FB (void);
// 0x000000C2 System.Void Unity.Services.Wire.Internal.WebSocketOpenEventHandler::.ctor(System.Object,System.IntPtr)
extern void WebSocketOpenEventHandler__ctor_m4CE276D4FBE9B39B2FF74013D584185B4A042E85 (void);
// 0x000000C3 System.Void Unity.Services.Wire.Internal.WebSocketOpenEventHandler::Invoke()
extern void WebSocketOpenEventHandler_Invoke_m78C0EDC577D77C8D8C9E881F7A2DD30C7A5C3A0F (void);
// 0x000000C4 System.IAsyncResult Unity.Services.Wire.Internal.WebSocketOpenEventHandler::BeginInvoke(System.AsyncCallback,System.Object)
extern void WebSocketOpenEventHandler_BeginInvoke_mE243F53957CDB1226346AD1A37DAB7FB586B78D8 (void);
// 0x000000C5 System.Void Unity.Services.Wire.Internal.WebSocketOpenEventHandler::EndInvoke(System.IAsyncResult)
extern void WebSocketOpenEventHandler_EndInvoke_m7D483E627676511115C4994383EB185FCFB5E3FA (void);
// 0x000000C6 System.Void Unity.Services.Wire.Internal.WebSocketMessageEventHandler::.ctor(System.Object,System.IntPtr)
extern void WebSocketMessageEventHandler__ctor_mD26E17264C5EF10FD664F79FB2F93EB455D2D219 (void);
// 0x000000C7 System.Void Unity.Services.Wire.Internal.WebSocketMessageEventHandler::Invoke(System.Byte[])
extern void WebSocketMessageEventHandler_Invoke_m4D6F19944357D3B390992DE3C5B1D3AB96251E2D (void);
// 0x000000C8 System.IAsyncResult Unity.Services.Wire.Internal.WebSocketMessageEventHandler::BeginInvoke(System.Byte[],System.AsyncCallback,System.Object)
extern void WebSocketMessageEventHandler_BeginInvoke_m204A7623711DA8D75CC30EFF829E983B4AC538FD (void);
// 0x000000C9 System.Void Unity.Services.Wire.Internal.WebSocketMessageEventHandler::EndInvoke(System.IAsyncResult)
extern void WebSocketMessageEventHandler_EndInvoke_mF36B13E3563FC5DF7F7EBBA53F823251FD6066F8 (void);
// 0x000000CA System.Void Unity.Services.Wire.Internal.WebSocketErrorEventHandler::.ctor(System.Object,System.IntPtr)
extern void WebSocketErrorEventHandler__ctor_mABD1C28DFEF019AADA85BE67DBD931DE656ED74A (void);
// 0x000000CB System.Void Unity.Services.Wire.Internal.WebSocketErrorEventHandler::Invoke(System.String)
extern void WebSocketErrorEventHandler_Invoke_m85C658759A7A273BC1ED9EA555AA94C95AF28909 (void);
// 0x000000CC System.IAsyncResult Unity.Services.Wire.Internal.WebSocketErrorEventHandler::BeginInvoke(System.String,System.AsyncCallback,System.Object)
extern void WebSocketErrorEventHandler_BeginInvoke_m816A057D0587E804397213860F631C433DCC6657 (void);
// 0x000000CD System.Void Unity.Services.Wire.Internal.WebSocketErrorEventHandler::EndInvoke(System.IAsyncResult)
extern void WebSocketErrorEventHandler_EndInvoke_m857F77A3AE6C6596B3E242254DF95554EC7B7874 (void);
// 0x000000CE System.Void Unity.Services.Wire.Internal.WebSocketCloseEventHandler::.ctor(System.Object,System.IntPtr)
extern void WebSocketCloseEventHandler__ctor_mFFECBF82993F785F4E4CF7C6069A740B6C44A5AE (void);
// 0x000000CF System.Void Unity.Services.Wire.Internal.WebSocketCloseEventHandler::Invoke(Unity.Services.Wire.Internal.WebSocketCloseCode)
extern void WebSocketCloseEventHandler_Invoke_m8EFE2454A7924329C5705F40F77309D1F9B6342B (void);
// 0x000000D0 System.IAsyncResult Unity.Services.Wire.Internal.WebSocketCloseEventHandler::BeginInvoke(Unity.Services.Wire.Internal.WebSocketCloseCode,System.AsyncCallback,System.Object)
extern void WebSocketCloseEventHandler_BeginInvoke_m7C7EA5E4EAA5FF1982529354020D359DE8EB9FE2 (void);
// 0x000000D1 System.Void Unity.Services.Wire.Internal.WebSocketCloseEventHandler::EndInvoke(System.IAsyncResult)
extern void WebSocketCloseEventHandler_EndInvoke_m03B5AA836C8292F29F74EDEE21C68EFE4F4034C4 (void);
// 0x000000D2 System.Void Unity.Services.Wire.Internal.IWebSocket::Connect()
// 0x000000D3 System.Void Unity.Services.Wire.Internal.IWebSocket::Close(Unity.Services.Wire.Internal.WebSocketCloseCode,System.String)
// 0x000000D4 System.Void Unity.Services.Wire.Internal.IWebSocket::Send(System.Byte[])
// 0x000000D5 Unity.Services.Wire.Internal.WebSocketState Unity.Services.Wire.Internal.IWebSocket::GetState()
// 0x000000D6 System.Void Unity.Services.Wire.Internal.IWebSocket::add_OnOpen(Unity.Services.Wire.Internal.WebSocketOpenEventHandler)
// 0x000000D7 System.Void Unity.Services.Wire.Internal.IWebSocket::remove_OnOpen(Unity.Services.Wire.Internal.WebSocketOpenEventHandler)
// 0x000000D8 System.Void Unity.Services.Wire.Internal.IWebSocket::add_OnMessage(Unity.Services.Wire.Internal.WebSocketMessageEventHandler)
// 0x000000D9 System.Void Unity.Services.Wire.Internal.IWebSocket::remove_OnMessage(Unity.Services.Wire.Internal.WebSocketMessageEventHandler)
// 0x000000DA System.Void Unity.Services.Wire.Internal.IWebSocket::add_OnError(Unity.Services.Wire.Internal.WebSocketErrorEventHandler)
// 0x000000DB System.Void Unity.Services.Wire.Internal.IWebSocket::remove_OnError(Unity.Services.Wire.Internal.WebSocketErrorEventHandler)
// 0x000000DC System.Void Unity.Services.Wire.Internal.IWebSocket::add_OnClose(Unity.Services.Wire.Internal.WebSocketCloseEventHandler)
// 0x000000DD System.Void Unity.Services.Wire.Internal.IWebSocket::remove_OnClose(Unity.Services.Wire.Internal.WebSocketCloseEventHandler)
// 0x000000DE Unity.Services.Wire.Internal.WebSocketCloseCode Unity.Services.Wire.Internal.WebSocketHelpers::ParseCloseCodeEnum(System.Int32)
extern void WebSocketHelpers_ParseCloseCodeEnum_m48D7C6C411E03356333AC77CC492513475BFEF3A (void);
// 0x000000DF Unity.Services.Wire.Internal.WebSocketException Unity.Services.Wire.Internal.WebSocketHelpers::GetErrorMessageFromCode(System.Int32,System.Exception)
extern void WebSocketHelpers_GetErrorMessageFromCode_mFBE1313B5B067E24DCFA88574B5693E37D4B7AE1 (void);
// 0x000000E0 System.Void Unity.Services.Wire.Internal.WebSocketException::.ctor()
extern void WebSocketException__ctor_mB72C4DF47F523BCA1F369DE425EEE9AB142BD813 (void);
// 0x000000E1 System.Void Unity.Services.Wire.Internal.WebSocketException::.ctor(System.String)
extern void WebSocketException__ctor_m3F3B6F9D988452EA0CF3F75A8106A6D552204540 (void);
// 0x000000E2 System.Void Unity.Services.Wire.Internal.WebSocketException::.ctor(System.String,System.Exception)
extern void WebSocketException__ctor_m7CFEA70EB07D5F5573F2F3FB039E56EA3EAE9349 (void);
// 0x000000E3 System.Void Unity.Services.Wire.Internal.WebSocketUnexpectedException::.ctor()
extern void WebSocketUnexpectedException__ctor_m445C60EB439D6A1C96E14825DD81B94E48897A54 (void);
// 0x000000E4 System.Void Unity.Services.Wire.Internal.WebSocketUnexpectedException::.ctor(System.String)
extern void WebSocketUnexpectedException__ctor_mDA5FAC04E11751B66C23BAAF9D0577A6E08AF19D (void);
// 0x000000E5 System.Void Unity.Services.Wire.Internal.WebSocketUnexpectedException::.ctor(System.String,System.Exception)
extern void WebSocketUnexpectedException__ctor_mB0985E7AA80EF8AFF67DC1FF871D6758161AAE1A (void);
// 0x000000E6 System.Void Unity.Services.Wire.Internal.WebSocketInvalidArgumentException::.ctor()
extern void WebSocketInvalidArgumentException__ctor_m0431EF78E65CFE832AA8F368F58D2631357227C7 (void);
// 0x000000E7 System.Void Unity.Services.Wire.Internal.WebSocketInvalidArgumentException::.ctor(System.String)
extern void WebSocketInvalidArgumentException__ctor_m4A63E13D64761D40203A63FB3F62F7FF99CDBBA6 (void);
// 0x000000E8 System.Void Unity.Services.Wire.Internal.WebSocketInvalidArgumentException::.ctor(System.String,System.Exception)
extern void WebSocketInvalidArgumentException__ctor_mD44FB76474482D262CCA6D9ED1DC2625ABB95ADD (void);
// 0x000000E9 System.Void Unity.Services.Wire.Internal.WebSocketInvalidStateException::.ctor()
extern void WebSocketInvalidStateException__ctor_mFECB7DAB2B034ECB7E637A220504AE467A27D476 (void);
// 0x000000EA System.Void Unity.Services.Wire.Internal.WebSocketInvalidStateException::.ctor(System.String)
extern void WebSocketInvalidStateException__ctor_m8EEA7D5B08A38CD70AC518549234843B9F804F5B (void);
// 0x000000EB System.Void Unity.Services.Wire.Internal.WebSocketInvalidStateException::.ctor(System.String,System.Exception)
extern void WebSocketInvalidStateException__ctor_mC7A4D01C4F68D4D1535C159D6FD093001D5B47B7 (void);
// 0x000000EC System.Void Unity.Services.Wire.Internal.WebSocket::add_OnOpen(Unity.Services.Wire.Internal.WebSocketOpenEventHandler)
extern void WebSocket_add_OnOpen_m2E47C8F9B0386410826B972E2F8C218CAE7C62F4 (void);
// 0x000000ED System.Void Unity.Services.Wire.Internal.WebSocket::remove_OnOpen(Unity.Services.Wire.Internal.WebSocketOpenEventHandler)
extern void WebSocket_remove_OnOpen_m9A958EC3375B2FA1FE6933C99D1D870D72CAADA9 (void);
// 0x000000EE System.Void Unity.Services.Wire.Internal.WebSocket::add_OnMessage(Unity.Services.Wire.Internal.WebSocketMessageEventHandler)
extern void WebSocket_add_OnMessage_mFED91C2936642A23A25EAD8264C01A421871BE55 (void);
// 0x000000EF System.Void Unity.Services.Wire.Internal.WebSocket::remove_OnMessage(Unity.Services.Wire.Internal.WebSocketMessageEventHandler)
extern void WebSocket_remove_OnMessage_mA8F4631C6E7AD21C36FE60E3E0890D08891DBE68 (void);
// 0x000000F0 System.Void Unity.Services.Wire.Internal.WebSocket::add_OnError(Unity.Services.Wire.Internal.WebSocketErrorEventHandler)
extern void WebSocket_add_OnError_mF178FCDEB03C6DA7E86C3F544976B1ECDC3EE4A3 (void);
// 0x000000F1 System.Void Unity.Services.Wire.Internal.WebSocket::remove_OnError(Unity.Services.Wire.Internal.WebSocketErrorEventHandler)
extern void WebSocket_remove_OnError_mDDE186E417B557A32576C7A7542A9C924F044FCA (void);
// 0x000000F2 System.Void Unity.Services.Wire.Internal.WebSocket::add_OnClose(Unity.Services.Wire.Internal.WebSocketCloseEventHandler)
extern void WebSocket_add_OnClose_m3C759459600A0E4E286E157D5428BD0ABB1D38DA (void);
// 0x000000F3 System.Void Unity.Services.Wire.Internal.WebSocket::remove_OnClose(Unity.Services.Wire.Internal.WebSocketCloseEventHandler)
extern void WebSocket_remove_OnClose_m358BE0CC5FA21094224740D0AE613C24E1EFB613 (void);
// 0x000000F4 System.Void Unity.Services.Wire.Internal.WebSocket::.ctor(System.String)
extern void WebSocket__ctor_mC2CFC1A906C87165F296A3BD1E27CCC3A376C898 (void);
// 0x000000F5 System.Void Unity.Services.Wire.Internal.WebSocket::Connect()
extern void WebSocket_Connect_mFAACFA7D3CF1C9CE8DAF07781692ECDBAF5C2D90 (void);
// 0x000000F6 System.Void Unity.Services.Wire.Internal.WebSocket::Close(Unity.Services.Wire.Internal.WebSocketCloseCode,System.String)
extern void WebSocket_Close_m2FBA1D7F38EE12EF5295F65D7F52E7F739FEA0F8 (void);
// 0x000000F7 System.Void Unity.Services.Wire.Internal.WebSocket::Send(System.Byte[])
extern void WebSocket_Send_m201FEC1DFB34DF7487DFD44050ED2AFC460195C5 (void);
// 0x000000F8 Unity.Services.Wire.Internal.WebSocketState Unity.Services.Wire.Internal.WebSocket::GetState()
extern void WebSocket_GetState_m2504AAA5F479468261F43D0B6A50230EE943F557 (void);
// 0x000000F9 System.Void Unity.Services.Wire.Internal.WebSocket::<.ctor>b__13_0(System.Object,System.EventArgs)
extern void WebSocket_U3C_ctorU3Eb__13_0_m02D2BFCC0D6A0935C31DE7E6F068C91F69CA246C (void);
// 0x000000FA System.Void Unity.Services.Wire.Internal.WebSocket::<.ctor>b__13_1(System.Object,WebSocketSharp.MessageEventArgs)
extern void WebSocket_U3C_ctorU3Eb__13_1_m96BBBC10EEBFCBD3B34303C5FC16BC8D4662F8D7 (void);
// 0x000000FB System.Void Unity.Services.Wire.Internal.WebSocket::<.ctor>b__13_2(System.Object,WebSocketSharp.ErrorEventArgs)
extern void WebSocket_U3C_ctorU3Eb__13_2_m1ED7892EB02607B10804569109750AB65550FA85 (void);
// 0x000000FC System.Void Unity.Services.Wire.Internal.WebSocket::<.ctor>b__13_3(System.Object,WebSocketSharp.CloseEventArgs)
extern void WebSocket_U3C_ctorU3Eb__13_3_mCAB87C81C3AF878444605DDD71269BF4BEFE6270 (void);
// 0x000000FD Unity.Services.Wire.Internal.WebSocket Unity.Services.Wire.Internal.WebSocketFactory::CreateInstance(System.String)
extern void WebSocketFactory_CreateInstance_m70705453AED536162DF62EED8F92227723B24ADD (void);
// 0x000000FE System.Void Unity.Services.Wire.Internal.WireDirect::.ctor(Unity.Services.Core.Scheduler.Internal.IActionScheduler,Unity.Services.Core.Telemetry.Internal.IMetrics,Unity.Services.Core.Threading.Internal.IUnityThreadUtils,Unity.Services.Authentication.Internal.IAccessToken)
extern void WireDirect__ctor_m1D0E9E45D06AEDDCB39A9D32A01D0B0183D3C13F (void);
// 0x000000FF Unity.Services.Wire.Internal.IChannel Unity.Services.Wire.Internal.WireDirect::CreateChannel(System.String,Unity.Services.Wire.Internal.IChannelTokenProvider)
extern void WireDirect_CreateChannel_mFDD57AD3106C2E7CCB3E94BD03F33E8D01C6B882 (void);
// 0x00000100 System.Void Unity.Services.Wire.Internal.WireDirectServiceProvider::Register()
extern void WireDirectServiceProvider_Register_m569BBD6F08BF4DC18AC5225A86A9ED9AAE94CEC7 (void);
// 0x00000101 System.Threading.Tasks.Task Unity.Services.Wire.Internal.WireDirectServiceProvider::Initialize(Unity.Services.Core.Internal.CoreRegistry)
extern void WireDirectServiceProvider_Initialize_mCE354346E50EB83F11DBA4DE6D810B21F6F1C2A4 (void);
// 0x00000102 System.Void Unity.Services.Wire.Internal.WireDirectServiceProvider::.ctor()
extern void WireDirectServiceProvider__ctor_m541E481F9AF866E4281580D6FB5BB79FD3AD9BE5 (void);
static Il2CppMethodPointer s_methodPointers[258] = 
{
	Client__ctor_m6CAAB061A911F3EDBF90C2A1E39CD656C6805F73,
	Client_SetupDirectClient_m350737B58870B3CBD955FC8A6C691C993BC5B96B,
	Client_SendCommandAsync_m4A782FCA2F1CD5F55672D3C90F088B80AE05A970,
	Client_PingAsync_mC9FF7E9BF09A1AEF6AD1993C26957A7D5BDC4487,
	Client_OnPingInterrupted_mAB6BFE50435302EE73E3190E62AE11DAFCF018C3,
	Client_Disconnect_mA4C9530BC0C96E024B97311C2CB7C14F954C0FFE,
	Client_ConnectAsync_m0D0D03C7D64451F06F1630163BFCBF2766C989CD,
	Client_InitWebsocket_m15C404A2A2D8C59379EC16C6291E50EF826E76C5,
	Client_ShouldReconnect_mCBE947C40F19A61D0AABDEB40759D8E72C57B5E1,
	Client_ChangeConnectionState_mA8A02AA0E69DB1211E8EE7D16CED5199078BF29A,
	Client_HandlePublications_mA6E55C31E93A129F36DAD4E5F529C15CF1D3FF0E,
	Client_HandlePushMessage_mE6E534B79617BD8E0F71E786D2035EBDFD85257E,
	Client_GetSubscriptionForReply_mF6FDC406E8058338B5C725D61D2088E7B6124A7E,
	Client_HandleCommandReply_m4AF9979EF80DE6B44D601FAE8F55D82907E35800,
	Client_SubscribeAsync_m87A53AE1DF7A1149F8B54551AA04D6A844993A9A,
	Client_CreateChannel_m9C45A243F1B05A83B7275930FD091AF91854F647,
	Client_UnsubscribeAsync_m19C5EACFAB7624F04800FB6B061BAD08C304C5B3,
	Client_U3C_ctorU3Eb__16_0_mAC425236D6BE7B39891A7336CF89900EC480F881,
	Client_U3CInitWebsocketU3Eb__23_0_m8FE896320DB67E471C771184058CBD4FF4A84B53,
	Client_U3CInitWebsocketU3Eb__23_1_m076D3CFDCC45906F30400A6E998940EB5BAA72CE,
	Client_U3CInitWebsocketU3Eb__23_2_m4C690CFA440DB3EB6F63FA2DFC198DF9295E94A7,
	Client_U3CInitWebsocketU3Eb__23_3_mAA05736FB86F2CA81AAD0AB936D8FB53BEC4FBB0,
	Client_U3CInitWebsocketU3Eb__23_4_mF0BB39C1D046B0A8178B208652EE710BAF631389,
	U3CSendCommandAsyncU3Ed__18_MoveNext_mC5CBA3784A07A5EE5D7EFB991D3A8C5C035FB088,
	U3CSendCommandAsyncU3Ed__18_SetStateMachine_m4ECBCAEF4F92F7F44C437EFC22021E19ED317378,
	U3CPingAsyncU3Ed__19_MoveNext_m70277838B26AEA687BD5C40E98B93C248C0EE662,
	U3CPingAsyncU3Ed__19_SetStateMachine_m1336C48F6CDC3DCF5305FDC64F2DC18F003AA4C4,
	U3CConnectAsyncU3Ed__22_MoveNext_m9EAF05B00B57DF251AA88492984C4DC66F30D8CC,
	U3CConnectAsyncU3Ed__22_SetStateMachine_m168F47CB9F5A243E38254AD97461251D2B02077E,
	U3CSubscribeAsyncU3Ed__30_MoveNext_m30E8A3C188DCE3E2155F73AEB21A789E510371C8,
	U3CSubscribeAsyncU3Ed__30_SetStateMachine_mF0E4EF59D34AEEFEC87328ABD051106F2863BE52,
	U3CU3Ec__DisplayClass31_0__ctor_m949CFB488B6F11F05669F64AB4DE5F1C1F9A555B,
	U3CU3Ec__DisplayClass31_0_U3CCreateChannelU3Eb__0_m4B6FA4FABD1C64481D39841A890D7372BF534B3A,
	U3CU3Ec__DisplayClass31_0_U3CCreateChannelU3Eb__1_m152D356FD9AC966ACC1EABC547C9EEAC785FB71E,
	U3CU3Ec__DisplayClass31_0_U3CCreateChannelU3Eb__2_m2F67C59CC9EBCBEA0C636E99E6B1F92C57499DC6,
	U3CU3Ec__DisplayClass31_0_U3CCreateChannelU3Eb__3_m6FB435F566A6F7F164C08E89804DEC1A6B06D386,
	U3CU3CCreateChannelU3Eb__0U3Ed_MoveNext_m1B81EC825A86D84DC6F738340AB292A88F9A4BC9,
	U3CU3CCreateChannelU3Eb__0U3Ed_SetStateMachine_m8FFDE42F9D2EF6EDB395979E411AD40E6C251E52,
	U3CU3CCreateChannelU3Eb__1U3Ed_MoveNext_mB70B3EB967112BF674E9571FC9F295A079A80828,
	U3CU3CCreateChannelU3Eb__1U3Ed_SetStateMachine_m42E7817CAD2C56FA1D154CFEE142FBEB04D2373A,
	U3CUnsubscribeAsyncU3Ed__32_MoveNext_m19AE7F04ADB21AD2D6E624297E3974147FBCF9CB,
	U3CUnsubscribeAsyncU3Ed__32_SetStateMachine_m807463D3132C01F6C18DC03C2B27FAE6C8BAE7D4,
	U3CU3CInitWebsocketU3Eb__23_0U3Ed_MoveNext_m2C1B7E3261362E6A8C955C7C6DD863E743B8B287,
	U3CU3CInitWebsocketU3Eb__23_0U3Ed_SetStateMachine_m84728E19C6B61D0103671D24BD0DEED4E4BBDAF8,
	U3CU3CInitWebsocketU3Eb__23_4U3Ed_MoveNext_mE1533FE88894AF6EE00D3A569BD097C297074B0A,
	U3CU3CInitWebsocketU3Eb__23_4U3Ed_SetStateMachine_m9112CBF1A820AE64AEAFFB373189584A190873E6,
	U3CU3CInitWebsocketU3Eb__23_3U3Ed_MoveNext_m608E4397BF86FE02A55C3CFA544515FBC65A05CC,
	U3CU3CInitWebsocketU3Eb__23_3U3Ed_SetStateMachine_m8A3E52A0112869DCA40392551A6275F2AE64B729,
	CommandManager__ctor_mDB2AB302A1D9FFCA31DDC11B19BBF1AE2337B8B8,
	CommandManager_RegisterCommand_m499EA52A16E50AAF0CAEA60B77C5DCD9FF599668,
	CommandManager_WaitForCommandAsync_m19454F5D83FEBC8085B8AF543503D257C11F6995,
	CommandManager_OnDisconnect_m3DE7DEE21B8521F111BF9DED2F86FBD816437107,
	CommandManager_OnCommandReplyReceived_mF706C17D158D7632B52BAC449E342F06A528B26F,
	CommandManager_CentrifugeErrorToException_mF241B057243EA3DAF0F0816B89DF8BBEB9F2DA76,
	U3CU3Ec__DisplayClass4_0__ctor_m9362DE73C9A175229CB0DCBEFCD99D482BBC2AD4,
	U3CU3Ec__DisplayClass4_0_U3CRegisterCommandU3Eb__0_mCCA1DF68C5AA0F0BBFF502CE95488E3CC8B4C259,
	U3CWaitForCommandAsyncU3Ed__5_MoveNext_mF581A48ADC1897BD903F2B2530A0DE05910D42B8,
	U3CWaitForCommandAsyncU3Ed__5_SetStateMachine_mE13865B8D7D00349E5E19CF11AF2D25BCCE4670D,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	ConcurrentDictSubscriptionRepository_get_IsEmpty_mDCBDA8F41BD693E70C3356F2E2D9E09D1391518E,
	ConcurrentDictSubscriptionRepository_add_SubscriptionCountChanged_m0A8DCA26F7820BE331EFD66370768F381EE3C90B,
	ConcurrentDictSubscriptionRepository_remove_SubscriptionCountChanged_mDAF7A34C202545B1C67572A653C26C6F573E9934,
	ConcurrentDictSubscriptionRepository__ctor_m5B5A05C1E3BAA1838CB14243E41B7C22509BA92E,
	ConcurrentDictSubscriptionRepository_IsAlreadySubscribed_m307986E233B9A62AFB6D953D15FF54CA48E68660,
	ConcurrentDictSubscriptionRepository_IsAlreadySubscribed_m9F4E28AB1C888C91E173810180E2FAD563EB68B5,
	ConcurrentDictSubscriptionRepository_IsRecovering_m220BD078856898E48B5E087BF4278677F4454F65,
	ConcurrentDictSubscriptionRepository_OnSubscriptionComplete_m314D2CB2255FFE68A681CEA142C691FCB5813CE2,
	ConcurrentDictSubscriptionRepository_GetSub_m884B96E9B4108783450F8EF75EC897D416CE79E9,
	ConcurrentDictSubscriptionRepository_GetSub_m6C04A118C93DAFEF4F97AC40BAF592F3E44E312D,
	ConcurrentDictSubscriptionRepository_RemoveSub_mEDAC86ABEC24DF508F14DABAA14CC5B1B1051461,
	ConcurrentDictSubscriptionRepository_ServerHasSubscription_m1EA451103899960453F16A5E57E1FB0514989777,
	ConcurrentDictSubscriptionRepository_PromoteSubscriptionHandle_mD6338FD0FF16F1BA1F2910A87853A940980F2F8D,
	ConcurrentDictSubscriptionRepository_AddSub_m8D3523110C4753052AC50CFB85D370F78E0AC172,
	ConcurrentDictSubscriptionRepository_AddSubscriptionHandle_mB8596DC4E17AFF43CE13431F4E918BE5CC86600A,
	ConcurrentDictSubscriptionRepository_OnSocketClosed_m6E3D436904775E76E0F51246C44881E42F1EDEDC,
	ConcurrentDictSubscriptionRepository_RecoverSubscriptions_m64F85DC515D6C46626FB00F33A446A5A973BD8C7,
	ConcurrentDictSubscriptionRepository_GetAll_mE2D2026158799FFEB5C6C5AD919397C639ECEDA3,
	CentrifugeError__ctor_mF36E82A55ABD8585DC741B7984E6EEA8D6BB4A57,
	CommandID_GenerateNewId_mDCA50A36C15BC69EB62CDAB2EF3B0960DF64F326,
	Message_Serialize_mCC4D5CB45472189D88BCF16C41052A879E554D8C,
	Message_GetBytes_m0A192CCC12E1180CB314892A9FE93B6C4950ABF6,
	NULL,
	Message__ctor_mDFCDF1E53B7F559C3E2E2663D7DD6534D165329B,
	NULL,
	NULL,
	NULL,
	ConnectRequest__ctor_m9E0005FFD34CFF0B0D4846D117FC431B9ECE5A64,
	ConnectRequest__ctor_m158F3339C5019437245A04DF6557D968935AF741,
	ConnectRequest_GetMethod_m81636D10D9E5AADD3BF09C93B3284B88265B023C,
	SubscribeRequest_getRequestFromRepo_m4A95CD59A368B47550BFFC78FF86775E7BFE29A0,
	SubscribeRequest_GetMethod_mA7A3D03F927D506681AB137CC45FFA88267E57D9,
	SubscribeRequest__ctor_m41177C54A1CB9118E3A1B78379264284AA39ADB5,
	U3CgetRequestFromRepoU3Ed__5_MoveNext_mFF5CADB8708DCCBA517D3898A27F52B511AD6060,
	U3CgetRequestFromRepoU3Ed__5_SetStateMachine_m3875AF79AA83DFCEBE86C9A0230D2916EF47B833,
	UnsubscribeRequest_GetMethod_mEDE3FC5C70F797AADA53E710FAD710D509A38704,
	UnsubscribeRequest__ctor_mBE808DE13CE6AFB6ED0D7EDE9B9DC6064BA8F3F0,
	SubscribeResult__ctor_m81BA388CA0379BB248BC0877B7B38458C479AE62,
	ClientInfo__ctor_m97BB0376514FF65B8D8116B27EBB28BFABF5B0E1,
	Reply__ctor_m10C30FBB23033703D17FD1732AED9C9F3B89F69F,
	Reply_FromJson_m38A8C1CF31BB337E458BFA45B2401C6289356116,
	Reply_FromJson_m9E9FDA6EB61BBBE87FC6231C02FE841395B9556B,
	Reply_ToJson_mD8D0D8B973DBA85031EBBE06956E616FDFFDF925,
	Reply_HasError_m84A554BF0C72D1D1ACFD413978F2E728AB1AAA6A,
	Result_ToConnectionResult_m6B70DCC0E6F9D1E275604522F51CA64FFBDA8C19,
	Result_ToSubscribeResult_m3D49D83597186280A21DF7F5BE3B029A1DD2CD84,
	Result__ctor_m69D0B573B49FEC03EA5CCF81CC7A7747EF422D6E,
	ConnectResult__ctor_mFEA0A0B544F09356BBBB64EBD46A77F8B49C81ED,
	PingRequest__ctor_m800ABD6D9348277C0CE0E0F45294A258E5400C77,
	PingResult__ctor_m33E6A94E35E32B0CB69ED24704F8234FC571016B,
	CentrifugePayload__ctor_m0AD46B76E77ABD191EC41CFD1E56609699669B1D,
	BatchMessages_SplitMessages_mD7604E8FF25D5A2260986757F3414C7A2D102FE8,
	BatchMessages_SplitMessages_m73BB9C0D5510E54C10F5338D8196BF6DCFF47B30,
	BatchMessages_FixJsonSplit_mD41A0362F5DF538275F556660FB253B56BDD2D44,
	Subscription_add_MessageReceived_m45F687C9418C3E26F7903AD46E2ACE7470CD0C72,
	Subscription_remove_MessageReceived_m5BE7378074118954C05290EBE2ED2AB24269390D,
	Subscription_add_BinaryMessageReceived_m7B138B43B29146A14A24CC2C9CF872DA6CAA5987,
	Subscription_remove_BinaryMessageReceived_m579B51F514977EC0C7C707BCEC1FF3030A76E572,
	Subscription_add_KickReceived_m5AEF149F83D56B7FF98196CFF972B4BAAF0D7626,
	Subscription_remove_KickReceived_mFAB75764B0CFB55C72E3E710A7EF70E3038AD5E2,
	Subscription_add_NewStateReceived_mCE68E2C38BA11E851901A675DE659FEA7EC22D6F,
	Subscription_remove_NewStateReceived_mAA9C3B52DC9842B0E979EF9DB8F27FC94EA28401,
	Subscription_add_UnsubscribeReceived_m79B4A788760B43316DC0125B2010776057FD9CCF,
	Subscription_remove_UnsubscribeReceived_m630A4BFD1FFDC1C93532B921BF299533B04D0E77,
	Subscription_add_SubscribeReceived_m4E0FA5F3E71142081031A98747B69B402FFD0D9F,
	Subscription_remove_SubscribeReceived_m515DFB1CCDE7305D0BAA1E2E0C1334FB9B350E43,
	Subscription_add_ErrorReceived_m34BF0846B62F7BD4F5414B321ECE24A6A6B07B5E,
	Subscription_remove_ErrorReceived_m03A1D0471B2C6B73BD7F216666A8248E19F0D861,
	Subscription_add_DisposeReceived_m23C473626CE7507C8C77166808D30FAFC130002F,
	Subscription_remove_DisposeReceived_m1AE439FAA1273F0197BED8F35DF712EE6EA7524B,
	Subscription_get_IsConnected_mB9216ABBCDBAE0D46F3B5B8B1331AD39E047B38E,
	Subscription__ctor_m7FFEBE40A4E2C06ADEBE152ECA6285DF4E735C4A,
	Subscription_RetrieveTokenAsync_m04C551A5D474A468F4D31107EAEA92F51457EC3B,
	Subscription_ValidateTokenData_m36FF0626FDA7145EDA7C117648F5FE361098B62E,
	Subscription_OnMessageReceived_m0853AAB92286C5996089095611A223CCC6CD3403,
	Subscription_OnUnsubscriptionComplete_mDB9EDA65B042F48DB994661EF0DA768F3EF25E08,
	Subscription_OnKickReceived_m7683A7B7E9792652FDF33C9FEE0E326785163DD5,
	Subscription_OnConnectivityChangeReceived_m619708B123B70CE26827D2A84CA64FF32D0FDEB8,
	Subscription_Finalize_mDC064A5C9B5EF53C03EAAF2F20A15163C5F6538A,
	Subscription_Dispose_m98EC655F45EAB329460428C69115B9BEB2F57EB7,
	Subscription_Dispose_m49B62DA76576EE90828E773618B61D1155E1060E,
	Subscription_SubscribeAsync_m7F3C5520AF0F3C1DB793D89704EB6936821FD59C,
	Subscription_UnsubscribeAsync_m9456CFFF76626818FB007E05C68B2D9DD6BCC17A,
	Subscription_OnError_mEA9D3AEB1F15B385B5FD262AFF7B65FAFED1C526,
	Subscription_U3COnKickReceivedU3Eb__38_0_m701C160E7FFD7A397249E7B1AB75FDACE9D1DFDD,
	U3CRetrieveTokenAsyncU3Ed__34_MoveNext_mFC04DF66014CE710F1BB1D4CC31B2251179C5A92,
	U3CRetrieveTokenAsyncU3Ed__34_SetStateMachine_m830A1FB515BA7CD10A5C47F26091327A77569001,
	U3CU3Ec__DisplayClass36_0__ctor_mA833E461FD9151626A52C07D0243F90178013C2D,
	U3CU3Ec__DisplayClass36_0_U3COnMessageReceivedU3Eb__0_m5F9479CB9C9EEE19D5EE96E107142D08DFD036CE,
	U3CU3Ec__DisplayClass36_0_U3COnMessageReceivedU3Eb__1_m160541AA58B3248C4B70F467336AA68126C9F8F7,
	WireMessage__ctor_mB9B3B62E1A47EF900B57DC3117AAA8FC6648EF7C,
	Configuration__ctor_mA9C1953CECDB2A5D27FD82531DAEB4A596B131D8,
	NoChannelPublicationException__ctor_mE6623605021328CDA669765F2EFF3A3CB88082ED,
	AlreadySubscribedException__ctor_mF5BC71FA65DB0ABECB651B98959856ECD240F844,
	AlreadyUnsubscribedException__ctor_m07CA9ADBE6B33ADFC385C426235327E900FD275A,
	UnknownCommandReplyException__ctor_m4780EE3FB8E8CD9F9A9F1CBE2060F017AF381D9C,
	CommandInterruptedException__ctor_m869E30D5591AEFC463BD522A95C4741B48E57ECB,
	CommandInterruptedException_get_m_Code_mAEACB41BACF9DB5CDC09907FB385169724105CB2,
	CommandInterruptedException_set_m_Code_m73910E7D09C1CA6F0D27A0CD235FB98BF9DAAC79,
	CommandNotFoundException__ctor_m459973D71326AA3AD6335B41553E40988DF6805D,
	CommandAlreadyExists__ctor_m97DAFCF8BE60C46EBA8E8A3ADD46E6A660C51B8C,
	EmptyChannelException__ctor_mF8111C786C460C113E9C0FDEF7201D4915E80807,
	EmptyTokenException__ctor_m2F8B8F6650767F4CFD987B131478F950206F369A,
	ChannelChangedException__ctor_m59ABD0EBFBBB5632DBA132AAF06C4D749376F872,
	ConnectionFailedException__ctor_m6C3B3C64D49A03E922EA3094B9024C77E354A0BC,
	NULL,
	SubscriptionHandle_get_ChannelName_m4A4DA05A9668E0D1A335EFE9C5527D23272D15D5,
	SubscriptionHandle__ctor_mE98AD94ACB75CAEB9535EC4FA70D52D6DA92FBA1,
	NULL,
	NULL,
	ExponentialBackoffStrategy__ctor_m81E0608C058DFB6CD18719A50130800FB8B7692D,
	ExponentialBackoffStrategy_GetDuration_m71158DF55EA83F61AFED437128C1CD8E73D8A4EA,
	ExponentialBackoffStrategy_GetNext_mAF0C6B53ABB6A531CA2A8F62461BF2B52829B016,
	ExponentialBackoffStrategy_Reset_mA584E4587BD4BA90872766187B3CDBF8BC5DE2D4,
	Logger_Log_mA52171C1BE8D493F4F9FEE07297B50821B098478,
	Logger_LogWarning_mE49195EB926D5A13B5419BF27601488969509D09,
	Logger_LogError_mDC5B814CA58DE578418098FB6B782BA674B5CF04,
	Logger_LogException_m420D5BE679DE3DC9D7167BBCEC556E2416E3F5E2,
	Logger_LogAssertion_m4559D96C458DBB023092C028B3791BF33CE7F2C2,
	Logger_LogVerbose_m76EDDE40ADDAF928AA6196923E2C0B92BB3419AE,
	Logger__ctor_m016B3C2D5D6B66552345943DDD3172F87315D5FB,
	WebSocketOpenEventHandler__ctor_m4CE276D4FBE9B39B2FF74013D584185B4A042E85,
	WebSocketOpenEventHandler_Invoke_m78C0EDC577D77C8D8C9E881F7A2DD30C7A5C3A0F,
	WebSocketOpenEventHandler_BeginInvoke_mE243F53957CDB1226346AD1A37DAB7FB586B78D8,
	WebSocketOpenEventHandler_EndInvoke_m7D483E627676511115C4994383EB185FCFB5E3FA,
	WebSocketMessageEventHandler__ctor_mD26E17264C5EF10FD664F79FB2F93EB455D2D219,
	WebSocketMessageEventHandler_Invoke_m4D6F19944357D3B390992DE3C5B1D3AB96251E2D,
	WebSocketMessageEventHandler_BeginInvoke_m204A7623711DA8D75CC30EFF829E983B4AC538FD,
	WebSocketMessageEventHandler_EndInvoke_mF36B13E3563FC5DF7F7EBBA53F823251FD6066F8,
	WebSocketErrorEventHandler__ctor_mABD1C28DFEF019AADA85BE67DBD931DE656ED74A,
	WebSocketErrorEventHandler_Invoke_m85C658759A7A273BC1ED9EA555AA94C95AF28909,
	WebSocketErrorEventHandler_BeginInvoke_m816A057D0587E804397213860F631C433DCC6657,
	WebSocketErrorEventHandler_EndInvoke_m857F77A3AE6C6596B3E242254DF95554EC7B7874,
	WebSocketCloseEventHandler__ctor_mFFECBF82993F785F4E4CF7C6069A740B6C44A5AE,
	WebSocketCloseEventHandler_Invoke_m8EFE2454A7924329C5705F40F77309D1F9B6342B,
	WebSocketCloseEventHandler_BeginInvoke_m7C7EA5E4EAA5FF1982529354020D359DE8EB9FE2,
	WebSocketCloseEventHandler_EndInvoke_m03B5AA836C8292F29F74EDEE21C68EFE4F4034C4,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	WebSocketHelpers_ParseCloseCodeEnum_m48D7C6C411E03356333AC77CC492513475BFEF3A,
	WebSocketHelpers_GetErrorMessageFromCode_mFBE1313B5B067E24DCFA88574B5693E37D4B7AE1,
	WebSocketException__ctor_mB72C4DF47F523BCA1F369DE425EEE9AB142BD813,
	WebSocketException__ctor_m3F3B6F9D988452EA0CF3F75A8106A6D552204540,
	WebSocketException__ctor_m7CFEA70EB07D5F5573F2F3FB039E56EA3EAE9349,
	WebSocketUnexpectedException__ctor_m445C60EB439D6A1C96E14825DD81B94E48897A54,
	WebSocketUnexpectedException__ctor_mDA5FAC04E11751B66C23BAAF9D0577A6E08AF19D,
	WebSocketUnexpectedException__ctor_mB0985E7AA80EF8AFF67DC1FF871D6758161AAE1A,
	WebSocketInvalidArgumentException__ctor_m0431EF78E65CFE832AA8F368F58D2631357227C7,
	WebSocketInvalidArgumentException__ctor_m4A63E13D64761D40203A63FB3F62F7FF99CDBBA6,
	WebSocketInvalidArgumentException__ctor_mD44FB76474482D262CCA6D9ED1DC2625ABB95ADD,
	WebSocketInvalidStateException__ctor_mFECB7DAB2B034ECB7E637A220504AE467A27D476,
	WebSocketInvalidStateException__ctor_m8EEA7D5B08A38CD70AC518549234843B9F804F5B,
	WebSocketInvalidStateException__ctor_mC7A4D01C4F68D4D1535C159D6FD093001D5B47B7,
	WebSocket_add_OnOpen_m2E47C8F9B0386410826B972E2F8C218CAE7C62F4,
	WebSocket_remove_OnOpen_m9A958EC3375B2FA1FE6933C99D1D870D72CAADA9,
	WebSocket_add_OnMessage_mFED91C2936642A23A25EAD8264C01A421871BE55,
	WebSocket_remove_OnMessage_mA8F4631C6E7AD21C36FE60E3E0890D08891DBE68,
	WebSocket_add_OnError_mF178FCDEB03C6DA7E86C3F544976B1ECDC3EE4A3,
	WebSocket_remove_OnError_mDDE186E417B557A32576C7A7542A9C924F044FCA,
	WebSocket_add_OnClose_m3C759459600A0E4E286E157D5428BD0ABB1D38DA,
	WebSocket_remove_OnClose_m358BE0CC5FA21094224740D0AE613C24E1EFB613,
	WebSocket__ctor_mC2CFC1A906C87165F296A3BD1E27CCC3A376C898,
	WebSocket_Connect_mFAACFA7D3CF1C9CE8DAF07781692ECDBAF5C2D90,
	WebSocket_Close_m2FBA1D7F38EE12EF5295F65D7F52E7F739FEA0F8,
	WebSocket_Send_m201FEC1DFB34DF7487DFD44050ED2AFC460195C5,
	WebSocket_GetState_m2504AAA5F479468261F43D0B6A50230EE943F557,
	WebSocket_U3C_ctorU3Eb__13_0_m02D2BFCC0D6A0935C31DE7E6F068C91F69CA246C,
	WebSocket_U3C_ctorU3Eb__13_1_m96BBBC10EEBFCBD3B34303C5FC16BC8D4662F8D7,
	WebSocket_U3C_ctorU3Eb__13_2_m1ED7892EB02607B10804569109750AB65550FA85,
	WebSocket_U3C_ctorU3Eb__13_3_mCAB87C81C3AF878444605DDD71269BF4BEFE6270,
	WebSocketFactory_CreateInstance_m70705453AED536162DF62EED8F92227723B24ADD,
	WireDirect__ctor_m1D0E9E45D06AEDDCB39A9D32A01D0B0183D3C13F,
	WireDirect_CreateChannel_mFDD57AD3106C2E7CCB3E94BD03F33E8D01C6B882,
	WireDirectServiceProvider_Register_m569BBD6F08BF4DC18AC5225A86A9ED9AAE94CEC7,
	WireDirectServiceProvider_Initialize_mCE354346E50EB83F11DBA4DE6D810B21F6F1C2A4,
	WireDirectServiceProvider__ctor_m541E481F9AF866E4281580D6FB5BB79FD3AD9BE5,
};
extern void U3CSendCommandAsyncU3Ed__18_MoveNext_mC5CBA3784A07A5EE5D7EFB991D3A8C5C035FB088_AdjustorThunk (void);
extern void U3CSendCommandAsyncU3Ed__18_SetStateMachine_m4ECBCAEF4F92F7F44C437EFC22021E19ED317378_AdjustorThunk (void);
extern void U3CPingAsyncU3Ed__19_MoveNext_m70277838B26AEA687BD5C40E98B93C248C0EE662_AdjustorThunk (void);
extern void U3CPingAsyncU3Ed__19_SetStateMachine_m1336C48F6CDC3DCF5305FDC64F2DC18F003AA4C4_AdjustorThunk (void);
extern void U3CConnectAsyncU3Ed__22_MoveNext_m9EAF05B00B57DF251AA88492984C4DC66F30D8CC_AdjustorThunk (void);
extern void U3CConnectAsyncU3Ed__22_SetStateMachine_m168F47CB9F5A243E38254AD97461251D2B02077E_AdjustorThunk (void);
extern void U3CSubscribeAsyncU3Ed__30_MoveNext_m30E8A3C188DCE3E2155F73AEB21A789E510371C8_AdjustorThunk (void);
extern void U3CSubscribeAsyncU3Ed__30_SetStateMachine_mF0E4EF59D34AEEFEC87328ABD051106F2863BE52_AdjustorThunk (void);
extern void U3CU3CCreateChannelU3Eb__0U3Ed_MoveNext_m1B81EC825A86D84DC6F738340AB292A88F9A4BC9_AdjustorThunk (void);
extern void U3CU3CCreateChannelU3Eb__0U3Ed_SetStateMachine_m8FFDE42F9D2EF6EDB395979E411AD40E6C251E52_AdjustorThunk (void);
extern void U3CU3CCreateChannelU3Eb__1U3Ed_MoveNext_mB70B3EB967112BF674E9571FC9F295A079A80828_AdjustorThunk (void);
extern void U3CU3CCreateChannelU3Eb__1U3Ed_SetStateMachine_m42E7817CAD2C56FA1D154CFEE142FBEB04D2373A_AdjustorThunk (void);
extern void U3CUnsubscribeAsyncU3Ed__32_MoveNext_m19AE7F04ADB21AD2D6E624297E3974147FBCF9CB_AdjustorThunk (void);
extern void U3CUnsubscribeAsyncU3Ed__32_SetStateMachine_m807463D3132C01F6C18DC03C2B27FAE6C8BAE7D4_AdjustorThunk (void);
extern void U3CU3CInitWebsocketU3Eb__23_0U3Ed_MoveNext_m2C1B7E3261362E6A8C955C7C6DD863E743B8B287_AdjustorThunk (void);
extern void U3CU3CInitWebsocketU3Eb__23_0U3Ed_SetStateMachine_m84728E19C6B61D0103671D24BD0DEED4E4BBDAF8_AdjustorThunk (void);
extern void U3CU3CInitWebsocketU3Eb__23_4U3Ed_MoveNext_mE1533FE88894AF6EE00D3A569BD097C297074B0A_AdjustorThunk (void);
extern void U3CU3CInitWebsocketU3Eb__23_4U3Ed_SetStateMachine_m9112CBF1A820AE64AEAFFB373189584A190873E6_AdjustorThunk (void);
extern void U3CU3CInitWebsocketU3Eb__23_3U3Ed_MoveNext_m608E4397BF86FE02A55C3CFA544515FBC65A05CC_AdjustorThunk (void);
extern void U3CU3CInitWebsocketU3Eb__23_3U3Ed_SetStateMachine_m8A3E52A0112869DCA40392551A6275F2AE64B729_AdjustorThunk (void);
extern void U3CWaitForCommandAsyncU3Ed__5_MoveNext_mF581A48ADC1897BD903F2B2530A0DE05910D42B8_AdjustorThunk (void);
extern void U3CWaitForCommandAsyncU3Ed__5_SetStateMachine_mE13865B8D7D00349E5E19CF11AF2D25BCCE4670D_AdjustorThunk (void);
extern void U3CgetRequestFromRepoU3Ed__5_MoveNext_mFF5CADB8708DCCBA517D3898A27F52B511AD6060_AdjustorThunk (void);
extern void U3CgetRequestFromRepoU3Ed__5_SetStateMachine_m3875AF79AA83DFCEBE86C9A0230D2916EF47B833_AdjustorThunk (void);
extern void U3CRetrieveTokenAsyncU3Ed__34_MoveNext_mFC04DF66014CE710F1BB1D4CC31B2251179C5A92_AdjustorThunk (void);
extern void U3CRetrieveTokenAsyncU3Ed__34_SetStateMachine_m830A1FB515BA7CD10A5C47F26091327A77569001_AdjustorThunk (void);
static Il2CppTokenAdjustorThunkPair s_adjustorThunks[26] = 
{
	{ 0x06000018, U3CSendCommandAsyncU3Ed__18_MoveNext_mC5CBA3784A07A5EE5D7EFB991D3A8C5C035FB088_AdjustorThunk },
	{ 0x06000019, U3CSendCommandAsyncU3Ed__18_SetStateMachine_m4ECBCAEF4F92F7F44C437EFC22021E19ED317378_AdjustorThunk },
	{ 0x0600001A, U3CPingAsyncU3Ed__19_MoveNext_m70277838B26AEA687BD5C40E98B93C248C0EE662_AdjustorThunk },
	{ 0x0600001B, U3CPingAsyncU3Ed__19_SetStateMachine_m1336C48F6CDC3DCF5305FDC64F2DC18F003AA4C4_AdjustorThunk },
	{ 0x0600001C, U3CConnectAsyncU3Ed__22_MoveNext_m9EAF05B00B57DF251AA88492984C4DC66F30D8CC_AdjustorThunk },
	{ 0x0600001D, U3CConnectAsyncU3Ed__22_SetStateMachine_m168F47CB9F5A243E38254AD97461251D2B02077E_AdjustorThunk },
	{ 0x0600001E, U3CSubscribeAsyncU3Ed__30_MoveNext_m30E8A3C188DCE3E2155F73AEB21A789E510371C8_AdjustorThunk },
	{ 0x0600001F, U3CSubscribeAsyncU3Ed__30_SetStateMachine_mF0E4EF59D34AEEFEC87328ABD051106F2863BE52_AdjustorThunk },
	{ 0x06000025, U3CU3CCreateChannelU3Eb__0U3Ed_MoveNext_m1B81EC825A86D84DC6F738340AB292A88F9A4BC9_AdjustorThunk },
	{ 0x06000026, U3CU3CCreateChannelU3Eb__0U3Ed_SetStateMachine_m8FFDE42F9D2EF6EDB395979E411AD40E6C251E52_AdjustorThunk },
	{ 0x06000027, U3CU3CCreateChannelU3Eb__1U3Ed_MoveNext_mB70B3EB967112BF674E9571FC9F295A079A80828_AdjustorThunk },
	{ 0x06000028, U3CU3CCreateChannelU3Eb__1U3Ed_SetStateMachine_m42E7817CAD2C56FA1D154CFEE142FBEB04D2373A_AdjustorThunk },
	{ 0x06000029, U3CUnsubscribeAsyncU3Ed__32_MoveNext_m19AE7F04ADB21AD2D6E624297E3974147FBCF9CB_AdjustorThunk },
	{ 0x0600002A, U3CUnsubscribeAsyncU3Ed__32_SetStateMachine_m807463D3132C01F6C18DC03C2B27FAE6C8BAE7D4_AdjustorThunk },
	{ 0x0600002B, U3CU3CInitWebsocketU3Eb__23_0U3Ed_MoveNext_m2C1B7E3261362E6A8C955C7C6DD863E743B8B287_AdjustorThunk },
	{ 0x0600002C, U3CU3CInitWebsocketU3Eb__23_0U3Ed_SetStateMachine_m84728E19C6B61D0103671D24BD0DEED4E4BBDAF8_AdjustorThunk },
	{ 0x0600002D, U3CU3CInitWebsocketU3Eb__23_4U3Ed_MoveNext_mE1533FE88894AF6EE00D3A569BD097C297074B0A_AdjustorThunk },
	{ 0x0600002E, U3CU3CInitWebsocketU3Eb__23_4U3Ed_SetStateMachine_m9112CBF1A820AE64AEAFFB373189584A190873E6_AdjustorThunk },
	{ 0x0600002F, U3CU3CInitWebsocketU3Eb__23_3U3Ed_MoveNext_m608E4397BF86FE02A55C3CFA544515FBC65A05CC_AdjustorThunk },
	{ 0x06000030, U3CU3CInitWebsocketU3Eb__23_3U3Ed_SetStateMachine_m8A3E52A0112869DCA40392551A6275F2AE64B729_AdjustorThunk },
	{ 0x06000039, U3CWaitForCommandAsyncU3Ed__5_MoveNext_mF581A48ADC1897BD903F2B2530A0DE05910D42B8_AdjustorThunk },
	{ 0x0600003A, U3CWaitForCommandAsyncU3Ed__5_SetStateMachine_mE13865B8D7D00349E5E19CF11AF2D25BCCE4670D_AdjustorThunk },
	{ 0x0600006A, U3CgetRequestFromRepoU3Ed__5_MoveNext_mFF5CADB8708DCCBA517D3898A27F52B511AD6060_AdjustorThunk },
	{ 0x0600006B, U3CgetRequestFromRepoU3Ed__5_SetStateMachine_m3875AF79AA83DFCEBE86C9A0230D2916EF47B833_AdjustorThunk },
	{ 0x0600009E, U3CRetrieveTokenAsyncU3Ed__34_MoveNext_mFC04DF66014CE710F1BB1D4CC31B2251179C5A92_AdjustorThunk },
	{ 0x0600009F, U3CRetrieveTokenAsyncU3Ed__34_SetStateMachine_m830A1FB515BA7CD10A5C47F26091327A77569001_AdjustorThunk },
};
static const int32_t s_InvokerIndices[258] = 
{
	1567,
	7470,
	2839,
	7328,
	6126,
	7470,
	7328,
	7470,
	5284,
	6093,
	6126,
	6126,
	4867,
	6126,
	4867,
	4867,
	4867,
	6093,
	7470,
	6126,
	6126,
	6093,
	7328,
	7470,
	6126,
	7470,
	6126,
	7470,
	6126,
	7470,
	6126,
	7470,
	6126,
	6126,
	7470,
	7470,
	7470,
	6126,
	7470,
	6126,
	7470,
	6126,
	7470,
	6126,
	7470,
	6126,
	7470,
	6126,
	3749,
	6093,
	4863,
	6126,
	6126,
	4867,
	7470,
	7470,
	7470,
	6126,
	6126,
	6126,
	5319,
	5319,
	3749,
	4867,
	4867,
	7328,
	6126,
	7470,
	6126,
	7375,
	5319,
	6126,
	7375,
	6126,
	6126,
	7470,
	5319,
	5319,
	5319,
	3749,
	4867,
	4867,
	6126,
	5319,
	6126,
	6126,
	6126,
	7470,
	6126,
	7328,
	7470,
	12298,
	7328,
	7328,
	7328,
	7470,
	-1,
	-1,
	-1,
	6126,
	3749,
	7328,
	11293,
	7328,
	7470,
	7470,
	6126,
	7328,
	7470,
	7470,
	7470,
	2221,
	11293,
	11293,
	7328,
	7375,
	7328,
	7328,
	7470,
	7470,
	7470,
	7470,
	7470,
	11293,
	11293,
	11544,
	6126,
	6126,
	6126,
	6126,
	6126,
	6126,
	6126,
	6126,
	6126,
	6126,
	6126,
	6126,
	6126,
	6126,
	6126,
	6126,
	7375,
	3749,
	7328,
	3749,
	6126,
	7470,
	7470,
	6170,
	7470,
	7470,
	6170,
	7328,
	7328,
	6126,
	7470,
	7470,
	6126,
	7470,
	7470,
	7470,
	7470,
	7470,
	6126,
	6126,
	6126,
	6093,
	3745,
	7292,
	6093,
	6093,
	6093,
	7470,
	7470,
	3749,
	6126,
	2857,
	7328,
	6126,
	7387,
	7470,
	7470,
	5645,
	7387,
	7470,
	11555,
	11555,
	11555,
	11555,
	11555,
	11555,
	7470,
	3747,
	7470,
	2857,
	6126,
	3747,
	6126,
	1892,
	6126,
	3747,
	6126,
	1892,
	6126,
	3747,
	6093,
	1857,
	6126,
	7470,
	3505,
	6126,
	7292,
	6126,
	6126,
	6126,
	6126,
	6126,
	6126,
	6126,
	6126,
	11082,
	9841,
	7470,
	6126,
	3749,
	7470,
	6126,
	3749,
	7470,
	6126,
	3749,
	7470,
	6126,
	3749,
	6126,
	6126,
	6126,
	6126,
	6126,
	6126,
	6126,
	6126,
	6126,
	7470,
	3505,
	6126,
	7292,
	3749,
	3749,
	3749,
	3749,
	11293,
	1567,
	2857,
	12344,
	4867,
	7470,
};
static const Il2CppTokenRangePair s_rgctxIndices[1] = 
{
	{ 0x0200001A, { 0, 1 } },
};
extern const uint32_t g_rgctx_JsonUtility_FromJson_TisCommand_1_tC3500DF79F5E79A24A878F1A8413E34AF3BE18F3_m28617AC941C9A15C3A6F956664851C97D5D4CF63;
static const Il2CppRGCTXDefinition s_rgctxValues[1] = 
{
	{ (Il2CppRGCTXDataType)3, (const void *)&g_rgctx_JsonUtility_FromJson_TisCommand_1_tC3500DF79F5E79A24A878F1A8413E34AF3BE18F3_m28617AC941C9A15C3A6F956664851C97D5D4CF63 },
};
IL2CPP_EXTERN_C const Il2CppCodeGenModule g_Unity_Services_Multiplay_Wire_Internal_CodeGenModule;
const Il2CppCodeGenModule g_Unity_Services_Multiplay_Wire_Internal_CodeGenModule = 
{
	"Unity.Services.Multiplay.Wire.Internal.dll",
	258,
	s_methodPointers,
	26,
	s_adjustorThunks,
	s_InvokerIndices,
	0,
	NULL,
	1,
	s_rgctxIndices,
	1,
	s_rgctxValues,
	NULL,
	NULL, // module initializer,
	NULL,
	NULL,
	NULL,
};
