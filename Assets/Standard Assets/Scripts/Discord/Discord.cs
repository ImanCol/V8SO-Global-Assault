using System;
using System.Runtime.InteropServices;
using UnityEngine;

namespace Discord
{
    // Token: 0x0200002F RID: 47
    public class Discord : IDisposable
    {
        // Token: 0x06000045 RID: 69
        [DllImport("discord_game_sdk", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        private static extern Result DiscordCreate(uint version, ref Discord.FFICreateParams createParams, out IntPtr manager);

        // Token: 0x17000005 RID: 5
        // (get) Token: 0x06000046 RID: 70 RVA: 0x00003B16 File Offset: 0x00001D16
        private Discord.FFIMethods Methods
        {
            get
            {
                if (this.MethodsStructure == null)
                {
                    this.MethodsStructure = Marshal.PtrToStructure(this.MethodsPtr, typeof(Discord.FFIMethods));
                }
                return (Discord.FFIMethods)this.MethodsStructure;
            }
        }

        // Token: 0x06000047 RID: 71 RVA: 0x00003B48 File Offset: 0x00001D48
        public Discord(long clientId, ulong flags)
        {
            Discord.FFICreateParams fficreateParams;
            fficreateParams.ClientId = clientId;
            fficreateParams.Flags = flags;
            this.Events = default(Discord.FFIEvents);
            this.EventsPtr = Marshal.AllocHGlobal(Marshal.SizeOf<Discord.FFIEvents>(this.Events));
            fficreateParams.Events = this.EventsPtr;
            this.SelfHandle = GCHandle.Alloc(this);
            fficreateParams.EventData = GCHandle.ToIntPtr(this.SelfHandle);
            this.ApplicationEvents = default(ApplicationManager.FFIEvents);
            this.ApplicationEventsPtr = Marshal.AllocHGlobal(Marshal.SizeOf<ApplicationManager.FFIEvents>(this.ApplicationEvents));
            fficreateParams.ApplicationEvents = this.ApplicationEventsPtr;
            fficreateParams.ApplicationVersion = 1U;
            this.UserEvents = default(UserManager.FFIEvents);
            this.UserEventsPtr = Marshal.AllocHGlobal(Marshal.SizeOf<UserManager.FFIEvents>(this.UserEvents));
            fficreateParams.UserEvents = this.UserEventsPtr;
            fficreateParams.UserVersion = 1U;
            this.ImageEvents = default(ImageManager.FFIEvents);
            this.ImageEventsPtr = Marshal.AllocHGlobal(Marshal.SizeOf<ImageManager.FFIEvents>(this.ImageEvents));
            fficreateParams.ImageEvents = this.ImageEventsPtr;
            fficreateParams.ImageVersion = 1U;
            this.ActivityEvents = default(ActivityManager.FFIEvents);
            this.ActivityEventsPtr = Marshal.AllocHGlobal(Marshal.SizeOf<ActivityManager.FFIEvents>(this.ActivityEvents));
            fficreateParams.ActivityEvents = this.ActivityEventsPtr;
            fficreateParams.ActivityVersion = 1U;
            this.RelationshipEvents = default(RelationshipManager.FFIEvents);
            this.RelationshipEventsPtr = Marshal.AllocHGlobal(Marshal.SizeOf<RelationshipManager.FFIEvents>(this.RelationshipEvents));
            fficreateParams.RelationshipEvents = this.RelationshipEventsPtr;
            fficreateParams.RelationshipVersion = 1U;
            this.LobbyEvents = default(LobbyManager.FFIEvents);
            this.LobbyEventsPtr = Marshal.AllocHGlobal(Marshal.SizeOf<LobbyManager.FFIEvents>(this.LobbyEvents));
            fficreateParams.LobbyEvents = this.LobbyEventsPtr;
            fficreateParams.LobbyVersion = 1U;
            this.NetworkEvents = default(NetworkManager.FFIEvents);
            this.NetworkEventsPtr = Marshal.AllocHGlobal(Marshal.SizeOf<NetworkManager.FFIEvents>(this.NetworkEvents));
            fficreateParams.NetworkEvents = this.NetworkEventsPtr;
            fficreateParams.NetworkVersion = 1U;
            this.OverlayEvents = default(OverlayManager.FFIEvents);
            this.OverlayEventsPtr = Marshal.AllocHGlobal(Marshal.SizeOf<OverlayManager.FFIEvents>(this.OverlayEvents));
            fficreateParams.OverlayEvents = this.OverlayEventsPtr;
            fficreateParams.OverlayVersion = 1U;
            this.StorageEvents = default(StorageManager.FFIEvents);
            this.StorageEventsPtr = Marshal.AllocHGlobal(Marshal.SizeOf<StorageManager.FFIEvents>(this.StorageEvents));
            fficreateParams.StorageEvents = this.StorageEventsPtr;
            fficreateParams.StorageVersion = 1U;
            this.StoreEvents = default(StoreManager.FFIEvents);
            this.StoreEventsPtr = Marshal.AllocHGlobal(Marshal.SizeOf<StoreManager.FFIEvents>(this.StoreEvents));
            fficreateParams.StoreEvents = this.StoreEventsPtr;
            fficreateParams.StoreVersion = 1U;
            this.VoiceEvents = default(VoiceManager.FFIEvents);
            this.VoiceEventsPtr = Marshal.AllocHGlobal(Marshal.SizeOf<VoiceManager.FFIEvents>(this.VoiceEvents));
            fficreateParams.VoiceEvents = this.VoiceEventsPtr;
            fficreateParams.VoiceVersion = 1U;
            this.AchievementEvents = default(AchievementManager.FFIEvents);
            this.AchievementEventsPtr = Marshal.AllocHGlobal(Marshal.SizeOf<AchievementManager.FFIEvents>(this.AchievementEvents));
            fficreateParams.AchievementEvents = this.AchievementEventsPtr;
            fficreateParams.AchievementVersion = 1U;
            this.InitEvents(this.EventsPtr, ref this.Events);
            Result result = Discord.DiscordCreate(2U, ref fficreateParams, out this.MethodsPtr);
            if (result != Result.Ok)
            {
                this.Dispose();
                throw new ResultException(result);
            }
        }

        // Token: 0x06000048 RID: 72 RVA: 0x00003E7D File Offset: 0x0000207D
        private void InitEvents(IntPtr eventsPtr, ref Discord.FFIEvents events)
        {
            Marshal.StructureToPtr<Discord.FFIEvents>(events, eventsPtr, false);
        }

        // Token: 0x06000049 RID: 73 RVA: 0x00003E8C File Offset: 0x0000208C
        public void Dispose()
        {
            if (this.MethodsPtr != IntPtr.Zero)
            {
                this.Methods.Destroy(this.MethodsPtr);
            }
            this.SelfHandle.Free();
            Marshal.FreeHGlobal(this.EventsPtr);
            Marshal.FreeHGlobal(this.ApplicationEventsPtr);
            Marshal.FreeHGlobal(this.UserEventsPtr);
            Marshal.FreeHGlobal(this.ImageEventsPtr);
            Marshal.FreeHGlobal(this.ActivityEventsPtr);
            Marshal.FreeHGlobal(this.RelationshipEventsPtr);
            Marshal.FreeHGlobal(this.LobbyEventsPtr);
            Marshal.FreeHGlobal(this.NetworkEventsPtr);
            Marshal.FreeHGlobal(this.OverlayEventsPtr);
            Marshal.FreeHGlobal(this.StorageEventsPtr);
            Marshal.FreeHGlobal(this.StoreEventsPtr);
            Marshal.FreeHGlobal(this.VoiceEventsPtr);
            Marshal.FreeHGlobal(this.AchievementEventsPtr);
            if (this.setLogHook != null)
            {
                this.setLogHook.Value.Free();
            }
        }

        // Token: 0x0600004A RID: 74 RVA: 0x00003F7C File Offset: 0x0000217C
        public void RunCallbacks()
        {

            //#if UNITY_EDITOR
            Result result = this.Methods.RunCallbacks(this.MethodsPtr);
            if (result != Result.Ok)
            {
                throw new ResultException(result);
            }
            //#endif
        }

        // Token: 0x0600004B RID: 75 RVA: 0x00003FAC File Offset: 0x000021AC
        [MonoPInvokeCallback]
        private static void SetLogHookCallbackImpl(IntPtr ptr, LogLevel level, string message)
        {
            ((Discord.SetLogHookHandler)GCHandle.FromIntPtr(ptr).Target)(level, message);
        }

        // Token: 0x0600004C RID: 76 RVA: 0x00003FD4 File Offset: 0x000021D4
        public void SetLogHook(LogLevel minLevel, Discord.SetLogHookHandler callback)
        {
            if (this.setLogHook != null)
            {
                this.setLogHook.Value.Free();
            }
            this.setLogHook = new GCHandle?(GCHandle.Alloc(callback));
            this.Methods.SetLogHook(this.MethodsPtr, minLevel, GCHandle.ToIntPtr(this.setLogHook.Value), new Discord.FFIMethods.SetLogHookCallback(Discord.SetLogHookCallbackImpl));
        }

        // Token: 0x0600004D RID: 77 RVA: 0x00004045 File Offset: 0x00002245
        public ApplicationManager GetApplicationManager()
        {
            if (this.ApplicationManagerInstance == null)
            {
                this.ApplicationManagerInstance = new ApplicationManager(this.Methods.GetApplicationManager(this.MethodsPtr), this.ApplicationEventsPtr, ref this.ApplicationEvents);
            }
            return this.ApplicationManagerInstance;
        }

        // Token: 0x0600004E RID: 78 RVA: 0x00004082 File Offset: 0x00002282
        public UserManager GetUserManager()
        {
            if (this.UserManagerInstance == null)
            {
                this.UserManagerInstance = new UserManager(this.Methods.GetUserManager(this.MethodsPtr), this.UserEventsPtr, ref this.UserEvents);
            }
            return this.UserManagerInstance;
        }

        // Token: 0x0600004F RID: 79 RVA: 0x000040BF File Offset: 0x000022BF
        public ImageManager GetImageManager()
        {
            if (this.ImageManagerInstance == null)
            {
                this.ImageManagerInstance = new ImageManager(this.Methods.GetImageManager(this.MethodsPtr), this.ImageEventsPtr, ref this.ImageEvents);
            }
            return this.ImageManagerInstance;
        }

        // Token: 0x06000050 RID: 80 RVA: 0x000040FC File Offset: 0x000022FC
        public ActivityManager GetActivityManager()
        {
            if (this.ActivityManagerInstance == null)
            {
                this.ActivityManagerInstance = new ActivityManager(this.Methods.GetActivityManager(this.MethodsPtr), this.ActivityEventsPtr, ref this.ActivityEvents);
            }
            return this.ActivityManagerInstance;
        }

        // Token: 0x06000051 RID: 81 RVA: 0x00004139 File Offset: 0x00002339
        public RelationshipManager GetRelationshipManager()
        {
            if (this.RelationshipManagerInstance == null)
            {
                this.RelationshipManagerInstance = new RelationshipManager(this.Methods.GetRelationshipManager(this.MethodsPtr), this.RelationshipEventsPtr, ref this.RelationshipEvents);
            }
            return this.RelationshipManagerInstance;
        }

        // Token: 0x06000052 RID: 82 RVA: 0x00004176 File Offset: 0x00002376
        public LobbyManager GetLobbyManager()
        {
            if (this.LobbyManagerInstance == null)
            {
                this.LobbyManagerInstance = new LobbyManager(this.Methods.GetLobbyManager(this.MethodsPtr), this.LobbyEventsPtr, ref this.LobbyEvents);
            }
            return this.LobbyManagerInstance;
        }

        // Token: 0x06000053 RID: 83 RVA: 0x000041B3 File Offset: 0x000023B3
        public NetworkManager GetNetworkManager()
        {
            if (this.NetworkManagerInstance == null)
            {
                this.NetworkManagerInstance = new NetworkManager(this.Methods.GetNetworkManager(this.MethodsPtr), this.NetworkEventsPtr, ref this.NetworkEvents);
            }
            return this.NetworkManagerInstance;
        }

        // Token: 0x06000054 RID: 84 RVA: 0x000041F0 File Offset: 0x000023F0
        public OverlayManager GetOverlayManager()
        {
            if (this.OverlayManagerInstance == null)
            {
                this.OverlayManagerInstance = new OverlayManager(this.Methods.GetOverlayManager(this.MethodsPtr), this.OverlayEventsPtr, ref this.OverlayEvents);
            }
            return this.OverlayManagerInstance;
        }

        // Token: 0x06000055 RID: 85 RVA: 0x0000422D File Offset: 0x0000242D
        public StorageManager GetStorageManager()
        {
            if (this.StorageManagerInstance == null)
            {
                this.StorageManagerInstance = new StorageManager(this.Methods.GetStorageManager(this.MethodsPtr), this.StorageEventsPtr, ref this.StorageEvents);
            }
            return this.StorageManagerInstance;
        }

        // Token: 0x06000056 RID: 86 RVA: 0x0000426A File Offset: 0x0000246A
        public StoreManager GetStoreManager()
        {
            if (this.StoreManagerInstance == null)
            {
                this.StoreManagerInstance = new StoreManager(this.Methods.GetStoreManager(this.MethodsPtr), this.StoreEventsPtr, ref this.StoreEvents);
            }
            return this.StoreManagerInstance;
        }

        // Token: 0x06000057 RID: 87 RVA: 0x000042A7 File Offset: 0x000024A7
        public VoiceManager GetVoiceManager()
        {
            if (this.VoiceManagerInstance == null)
            {
                this.VoiceManagerInstance = new VoiceManager(this.Methods.GetVoiceManager(this.MethodsPtr), this.VoiceEventsPtr, ref this.VoiceEvents);
            }
            return this.VoiceManagerInstance;
        }

        // Token: 0x06000058 RID: 88 RVA: 0x000042E4 File Offset: 0x000024E4
        public AchievementManager GetAchievementManager()
        {
            if (this.AchievementManagerInstance == null)
            {
                this.AchievementManagerInstance = new AchievementManager(this.Methods.GetAchievementManager(this.MethodsPtr), this.AchievementEventsPtr, ref this.AchievementEvents);
            }
            return this.AchievementManagerInstance;
        }

        // Token: 0x040000EC RID: 236
        private GCHandle SelfHandle;

        // Token: 0x040000ED RID: 237
        private IntPtr EventsPtr;

        // Token: 0x040000EE RID: 238
        private Discord.FFIEvents Events;

        // Token: 0x040000EF RID: 239
        private IntPtr ApplicationEventsPtr;

        // Token: 0x040000F0 RID: 240
        private ApplicationManager.FFIEvents ApplicationEvents;

        // Token: 0x040000F1 RID: 241
        internal ApplicationManager ApplicationManagerInstance;

        // Token: 0x040000F2 RID: 242
        private IntPtr UserEventsPtr;

        // Token: 0x040000F3 RID: 243
        private UserManager.FFIEvents UserEvents;

        // Token: 0x040000F4 RID: 244
        internal UserManager UserManagerInstance;

        // Token: 0x040000F5 RID: 245
        private IntPtr ImageEventsPtr;

        // Token: 0x040000F6 RID: 246
        private ImageManager.FFIEvents ImageEvents;

        // Token: 0x040000F7 RID: 247
        internal ImageManager ImageManagerInstance;

        // Token: 0x040000F8 RID: 248
        private IntPtr ActivityEventsPtr;

        // Token: 0x040000F9 RID: 249
        private ActivityManager.FFIEvents ActivityEvents;

        // Token: 0x040000FA RID: 250
        internal ActivityManager ActivityManagerInstance;

        // Token: 0x040000FB RID: 251
        private IntPtr RelationshipEventsPtr;

        // Token: 0x040000FC RID: 252
        private RelationshipManager.FFIEvents RelationshipEvents;

        // Token: 0x040000FD RID: 253
        internal RelationshipManager RelationshipManagerInstance;

        // Token: 0x040000FE RID: 254
        private IntPtr LobbyEventsPtr;

        // Token: 0x040000FF RID: 255
        private LobbyManager.FFIEvents LobbyEvents;

        // Token: 0x04000100 RID: 256
        internal LobbyManager LobbyManagerInstance;

        // Token: 0x04000101 RID: 257
        private IntPtr NetworkEventsPtr;

        // Token: 0x04000102 RID: 258
        private NetworkManager.FFIEvents NetworkEvents;

        // Token: 0x04000103 RID: 259
        internal NetworkManager NetworkManagerInstance;

        // Token: 0x04000104 RID: 260
        private IntPtr OverlayEventsPtr;

        // Token: 0x04000105 RID: 261
        private OverlayManager.FFIEvents OverlayEvents;

        // Token: 0x04000106 RID: 262
        internal OverlayManager OverlayManagerInstance;

        // Token: 0x04000107 RID: 263
        private IntPtr StorageEventsPtr;

        // Token: 0x04000108 RID: 264
        private StorageManager.FFIEvents StorageEvents;

        // Token: 0x04000109 RID: 265
        internal StorageManager StorageManagerInstance;

        // Token: 0x0400010A RID: 266
        private IntPtr StoreEventsPtr;

        // Token: 0x0400010B RID: 267
        private StoreManager.FFIEvents StoreEvents;

        // Token: 0x0400010C RID: 268
        internal StoreManager StoreManagerInstance;

        // Token: 0x0400010D RID: 269
        private IntPtr VoiceEventsPtr;

        // Token: 0x0400010E RID: 270
        private VoiceManager.FFIEvents VoiceEvents;

        // Token: 0x0400010F RID: 271
        internal VoiceManager VoiceManagerInstance;

        // Token: 0x04000110 RID: 272
        private IntPtr AchievementEventsPtr;

        // Token: 0x04000111 RID: 273
        private AchievementManager.FFIEvents AchievementEvents;

        // Token: 0x04000112 RID: 274
        internal AchievementManager AchievementManagerInstance;

        // Token: 0x04000113 RID: 275
        private IntPtr MethodsPtr;

        // Token: 0x04000114 RID: 276
        private object MethodsStructure;

        // Token: 0x04000115 RID: 277
        private GCHandle? setLogHook;

        // Token: 0x0200004F RID: 79
        internal struct FFIEvents
        {
        }

        // Token: 0x02000050 RID: 80
        internal struct FFIMethods
        {
            // Token: 0x04000166 RID: 358
            internal Discord.FFIMethods.DestroyHandler Destroy;

            // Token: 0x04000167 RID: 359
            internal Discord.FFIMethods.RunCallbacksMethod RunCallbacks;

            // Token: 0x04000168 RID: 360
            internal Discord.FFIMethods.SetLogHookMethod SetLogHook;

            // Token: 0x04000169 RID: 361
            internal Discord.FFIMethods.GetApplicationManagerMethod GetApplicationManager;

            // Token: 0x0400016A RID: 362
            internal Discord.FFIMethods.GetUserManagerMethod GetUserManager;

            // Token: 0x0400016B RID: 363
            internal Discord.FFIMethods.GetImageManagerMethod GetImageManager;

            // Token: 0x0400016C RID: 364
            internal Discord.FFIMethods.GetActivityManagerMethod GetActivityManager;

            // Token: 0x0400016D RID: 365
            internal Discord.FFIMethods.GetRelationshipManagerMethod GetRelationshipManager;

            // Token: 0x0400016E RID: 366
            internal Discord.FFIMethods.GetLobbyManagerMethod GetLobbyManager;

            // Token: 0x0400016F RID: 367
            internal Discord.FFIMethods.GetNetworkManagerMethod GetNetworkManager;

            // Token: 0x04000170 RID: 368
            internal Discord.FFIMethods.GetOverlayManagerMethod GetOverlayManager;

            // Token: 0x04000171 RID: 369
            internal Discord.FFIMethods.GetStorageManagerMethod GetStorageManager;

            // Token: 0x04000172 RID: 370
            internal Discord.FFIMethods.GetStoreManagerMethod GetStoreManager;

            // Token: 0x04000173 RID: 371
            internal Discord.FFIMethods.GetVoiceManagerMethod GetVoiceManager;

            // Token: 0x04000174 RID: 372
            internal Discord.FFIMethods.GetAchievementManagerMethod GetAchievementManager;

            // Token: 0x020000B5 RID: 181
            // (Invoke) Token: 0x06000293 RID: 659
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void DestroyHandler(IntPtr MethodsPtr);

            // Token: 0x020000B6 RID: 182
            // (Invoke) Token: 0x06000297 RID: 663
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate Result RunCallbacksMethod(IntPtr methodsPtr);

            // Token: 0x020000B7 RID: 183
            // (Invoke) Token: 0x0600029B RID: 667
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void SetLogHookCallback(IntPtr ptr, LogLevel level, [MarshalAs(UnmanagedType.LPStr)] string message);

            // Token: 0x020000B8 RID: 184
            // (Invoke) Token: 0x0600029F RID: 671
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void SetLogHookMethod(IntPtr methodsPtr, LogLevel minLevel, IntPtr callbackData, Discord.FFIMethods.SetLogHookCallback callback);

            // Token: 0x020000B9 RID: 185
            // (Invoke) Token: 0x060002A3 RID: 675
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate IntPtr GetApplicationManagerMethod(IntPtr discordPtr);

            // Token: 0x020000BA RID: 186
            // (Invoke) Token: 0x060002A7 RID: 679
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate IntPtr GetUserManagerMethod(IntPtr discordPtr);

            // Token: 0x020000BB RID: 187
            // (Invoke) Token: 0x060002AB RID: 683
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate IntPtr GetImageManagerMethod(IntPtr discordPtr);

            // Token: 0x020000BC RID: 188
            // (Invoke) Token: 0x060002AF RID: 687
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate IntPtr GetActivityManagerMethod(IntPtr discordPtr);

            // Token: 0x020000BD RID: 189
            // (Invoke) Token: 0x060002B3 RID: 691
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate IntPtr GetRelationshipManagerMethod(IntPtr discordPtr);

            // Token: 0x020000BE RID: 190
            // (Invoke) Token: 0x060002B7 RID: 695
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate IntPtr GetLobbyManagerMethod(IntPtr discordPtr);

            // Token: 0x020000BF RID: 191
            // (Invoke) Token: 0x060002BB RID: 699
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate IntPtr GetNetworkManagerMethod(IntPtr discordPtr);

            // Token: 0x020000C0 RID: 192
            // (Invoke) Token: 0x060002BF RID: 703
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate IntPtr GetOverlayManagerMethod(IntPtr discordPtr);

            // Token: 0x020000C1 RID: 193
            // (Invoke) Token: 0x060002C3 RID: 707
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate IntPtr GetStorageManagerMethod(IntPtr discordPtr);

            // Token: 0x020000C2 RID: 194
            // (Invoke) Token: 0x060002C7 RID: 711
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate IntPtr GetStoreManagerMethod(IntPtr discordPtr);

            // Token: 0x020000C3 RID: 195
            // (Invoke) Token: 0x060002CB RID: 715
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate IntPtr GetVoiceManagerMethod(IntPtr discordPtr);

            // Token: 0x020000C4 RID: 196
            // (Invoke) Token: 0x060002CF RID: 719
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate IntPtr GetAchievementManagerMethod(IntPtr discordPtr);
        }

        // Token: 0x02000051 RID: 81
        internal struct FFICreateParams
        {
            // Token: 0x04000175 RID: 373
            internal long ClientId;

            // Token: 0x04000176 RID: 374
            internal ulong Flags;

            // Token: 0x04000177 RID: 375
            internal IntPtr Events;

            // Token: 0x04000178 RID: 376
            internal IntPtr EventData;

            // Token: 0x04000179 RID: 377
            internal IntPtr ApplicationEvents;

            // Token: 0x0400017A RID: 378
            internal uint ApplicationVersion;

            // Token: 0x0400017B RID: 379
            internal IntPtr UserEvents;

            // Token: 0x0400017C RID: 380
            internal uint UserVersion;

            // Token: 0x0400017D RID: 381
            internal IntPtr ImageEvents;

            // Token: 0x0400017E RID: 382
            internal uint ImageVersion;

            // Token: 0x0400017F RID: 383
            internal IntPtr ActivityEvents;

            // Token: 0x04000180 RID: 384
            internal uint ActivityVersion;

            // Token: 0x04000181 RID: 385
            internal IntPtr RelationshipEvents;

            // Token: 0x04000182 RID: 386
            internal uint RelationshipVersion;

            // Token: 0x04000183 RID: 387
            internal IntPtr LobbyEvents;

            // Token: 0x04000184 RID: 388
            internal uint LobbyVersion;

            // Token: 0x04000185 RID: 389
            internal IntPtr NetworkEvents;

            // Token: 0x04000186 RID: 390
            internal uint NetworkVersion;

            // Token: 0x04000187 RID: 391
            internal IntPtr OverlayEvents;

            // Token: 0x04000188 RID: 392
            internal uint OverlayVersion;

            // Token: 0x04000189 RID: 393
            internal IntPtr StorageEvents;

            // Token: 0x0400018A RID: 394
            internal uint StorageVersion;

            // Token: 0x0400018B RID: 395
            internal IntPtr StoreEvents;

            // Token: 0x0400018C RID: 396
            internal uint StoreVersion;

            // Token: 0x0400018D RID: 397
            internal IntPtr VoiceEvents;

            // Token: 0x0400018E RID: 398
            internal uint VoiceVersion;

            // Token: 0x0400018F RID: 399
            internal IntPtr AchievementEvents;

            // Token: 0x04000190 RID: 400
            internal uint AchievementVersion;
        }

        // Token: 0x02000052 RID: 82
        // (Invoke) Token: 0x0600015F RID: 351
        public delegate void SetLogHookHandler(LogLevel level, string message);
    }
}
