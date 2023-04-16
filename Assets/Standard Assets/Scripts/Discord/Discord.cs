using System;
using System.Runtime.InteropServices;

namespace Discord
{
	public class Discord : IDisposable
	{
		[DllImport("discord_game_sdk", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		private static extern Result DiscordCreate(uint version, ref Discord.FFICreateParams createParams, out IntPtr manager);

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
			fficreateParams.ApplicationVersion = 1u;
			this.UserEvents = default(UserManager.FFIEvents);
			this.UserEventsPtr = Marshal.AllocHGlobal(Marshal.SizeOf<UserManager.FFIEvents>(this.UserEvents));
			fficreateParams.UserEvents = this.UserEventsPtr;
			fficreateParams.UserVersion = 1u;
			this.ImageEvents = default(ImageManager.FFIEvents);
			this.ImageEventsPtr = Marshal.AllocHGlobal(Marshal.SizeOf<ImageManager.FFIEvents>(this.ImageEvents));
			fficreateParams.ImageEvents = this.ImageEventsPtr;
			fficreateParams.ImageVersion = 1u;
			this.ActivityEvents = default(ActivityManager.FFIEvents);
			this.ActivityEventsPtr = Marshal.AllocHGlobal(Marshal.SizeOf<ActivityManager.FFIEvents>(this.ActivityEvents));
			fficreateParams.ActivityEvents = this.ActivityEventsPtr;
			fficreateParams.ActivityVersion = 1u;
			this.RelationshipEvents = default(RelationshipManager.FFIEvents);
			this.RelationshipEventsPtr = Marshal.AllocHGlobal(Marshal.SizeOf<RelationshipManager.FFIEvents>(this.RelationshipEvents));
			fficreateParams.RelationshipEvents = this.RelationshipEventsPtr;
			fficreateParams.RelationshipVersion = 1u;
			this.LobbyEvents = default(LobbyManager.FFIEvents);
			this.LobbyEventsPtr = Marshal.AllocHGlobal(Marshal.SizeOf<LobbyManager.FFIEvents>(this.LobbyEvents));
			fficreateParams.LobbyEvents = this.LobbyEventsPtr;
			fficreateParams.LobbyVersion = 1u;
			this.NetworkEvents = default(NetworkManager.FFIEvents);
			this.NetworkEventsPtr = Marshal.AllocHGlobal(Marshal.SizeOf<NetworkManager.FFIEvents>(this.NetworkEvents));
			fficreateParams.NetworkEvents = this.NetworkEventsPtr;
			fficreateParams.NetworkVersion = 1u;
			this.OverlayEvents = default(OverlayManager.FFIEvents);
			this.OverlayEventsPtr = Marshal.AllocHGlobal(Marshal.SizeOf<OverlayManager.FFIEvents>(this.OverlayEvents));
			fficreateParams.OverlayEvents = this.OverlayEventsPtr;
			fficreateParams.OverlayVersion = 1u;
			this.StorageEvents = default(StorageManager.FFIEvents);
			this.StorageEventsPtr = Marshal.AllocHGlobal(Marshal.SizeOf<StorageManager.FFIEvents>(this.StorageEvents));
			fficreateParams.StorageEvents = this.StorageEventsPtr;
			fficreateParams.StorageVersion = 1u;
			this.StoreEvents = default(StoreManager.FFIEvents);
			this.StoreEventsPtr = Marshal.AllocHGlobal(Marshal.SizeOf<StoreManager.FFIEvents>(this.StoreEvents));
			fficreateParams.StoreEvents = this.StoreEventsPtr;
			fficreateParams.StoreVersion = 1u;
			this.VoiceEvents = default(VoiceManager.FFIEvents);
			this.VoiceEventsPtr = Marshal.AllocHGlobal(Marshal.SizeOf<VoiceManager.FFIEvents>(this.VoiceEvents));
			fficreateParams.VoiceEvents = this.VoiceEventsPtr;
			fficreateParams.VoiceVersion = 1u;
			this.AchievementEvents = default(AchievementManager.FFIEvents);
			this.AchievementEventsPtr = Marshal.AllocHGlobal(Marshal.SizeOf<AchievementManager.FFIEvents>(this.AchievementEvents));
			fficreateParams.AchievementEvents = this.AchievementEventsPtr;
			fficreateParams.AchievementVersion = 1u;
			this.InitEvents(this.EventsPtr, ref this.Events);
			Result result = Discord.DiscordCreate(2u, ref fficreateParams, out this.MethodsPtr);
			if (result != Result.Ok)
			{
				this.Dispose();
				throw new ResultException(result);
			}
		}

		private void InitEvents(IntPtr eventsPtr, ref Discord.FFIEvents events)
		{
			Marshal.StructureToPtr<Discord.FFIEvents>(events, eventsPtr, false);
		}

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

		public void RunCallbacks()
		{
			Result result = this.Methods.RunCallbacks(this.MethodsPtr);
			if (result != Result.Ok)
			{
				throw new ResultException(result);
			}
		}

		[MonoPInvokeCallback]
		private static void SetLogHookCallbackImpl(IntPtr ptr, LogLevel level, string message)
		{
			((Discord.SetLogHookHandler)GCHandle.FromIntPtr(ptr).Target)(level, message);
		}

		public void SetLogHook(LogLevel minLevel, Discord.SetLogHookHandler callback)
		{
			if (this.setLogHook != null)
			{
				this.setLogHook.Value.Free();
			}
			this.setLogHook = new GCHandle?(GCHandle.Alloc(callback));
			this.Methods.SetLogHook(this.MethodsPtr, minLevel, GCHandle.ToIntPtr(this.setLogHook.Value), new Discord.FFIMethods.SetLogHookCallback(Discord.SetLogHookCallbackImpl));
		}

		public ApplicationManager GetApplicationManager()
		{
			if (this.ApplicationManagerInstance == null)
			{
				this.ApplicationManagerInstance = new ApplicationManager(this.Methods.GetApplicationManager(this.MethodsPtr), this.ApplicationEventsPtr, ref this.ApplicationEvents);
			}
			return this.ApplicationManagerInstance;
		}

		public UserManager GetUserManager()
		{
			if (this.UserManagerInstance == null)
			{
				this.UserManagerInstance = new UserManager(this.Methods.GetUserManager(this.MethodsPtr), this.UserEventsPtr, ref this.UserEvents);
			}
			return this.UserManagerInstance;
		}

		public ImageManager GetImageManager()
		{
			if (this.ImageManagerInstance == null)
			{
				this.ImageManagerInstance = new ImageManager(this.Methods.GetImageManager(this.MethodsPtr), this.ImageEventsPtr, ref this.ImageEvents);
			}
			return this.ImageManagerInstance;
		}

		public ActivityManager GetActivityManager()
		{
			if (this.ActivityManagerInstance == null)
			{
				this.ActivityManagerInstance = new ActivityManager(this.Methods.GetActivityManager(this.MethodsPtr), this.ActivityEventsPtr, ref this.ActivityEvents);
			}
			return this.ActivityManagerInstance;
		}

		public RelationshipManager GetRelationshipManager()
		{
			if (this.RelationshipManagerInstance == null)
			{
				this.RelationshipManagerInstance = new RelationshipManager(this.Methods.GetRelationshipManager(this.MethodsPtr), this.RelationshipEventsPtr, ref this.RelationshipEvents);
			}
			return this.RelationshipManagerInstance;
		}

		public LobbyManager GetLobbyManager()
		{
			if (this.LobbyManagerInstance == null)
			{
				this.LobbyManagerInstance = new LobbyManager(this.Methods.GetLobbyManager(this.MethodsPtr), this.LobbyEventsPtr, ref this.LobbyEvents);
			}
			return this.LobbyManagerInstance;
		}

		public NetworkManager GetNetworkManager()
		{
			if (this.NetworkManagerInstance == null)
			{
				this.NetworkManagerInstance = new NetworkManager(this.Methods.GetNetworkManager(this.MethodsPtr), this.NetworkEventsPtr, ref this.NetworkEvents);
			}
			return this.NetworkManagerInstance;
		}

		public OverlayManager GetOverlayManager()
		{
			if (this.OverlayManagerInstance == null)
			{
				this.OverlayManagerInstance = new OverlayManager(this.Methods.GetOverlayManager(this.MethodsPtr), this.OverlayEventsPtr, ref this.OverlayEvents);
			}
			return this.OverlayManagerInstance;
		}

		public StorageManager GetStorageManager()
		{
			if (this.StorageManagerInstance == null)
			{
				this.StorageManagerInstance = new StorageManager(this.Methods.GetStorageManager(this.MethodsPtr), this.StorageEventsPtr, ref this.StorageEvents);
			}
			return this.StorageManagerInstance;
		}

		public StoreManager GetStoreManager()
		{
			if (this.StoreManagerInstance == null)
			{
				this.StoreManagerInstance = new StoreManager(this.Methods.GetStoreManager(this.MethodsPtr), this.StoreEventsPtr, ref this.StoreEvents);
			}
			return this.StoreManagerInstance;
		}

		public VoiceManager GetVoiceManager()
		{
			if (this.VoiceManagerInstance == null)
			{
				this.VoiceManagerInstance = new VoiceManager(this.Methods.GetVoiceManager(this.MethodsPtr), this.VoiceEventsPtr, ref this.VoiceEvents);
			}
			return this.VoiceManagerInstance;
		}

		public AchievementManager GetAchievementManager()
		{
			if (this.AchievementManagerInstance == null)
			{
				this.AchievementManagerInstance = new AchievementManager(this.Methods.GetAchievementManager(this.MethodsPtr), this.AchievementEventsPtr, ref this.AchievementEvents);
			}
			return this.AchievementManagerInstance;
		}

		private GCHandle SelfHandle;

		private IntPtr EventsPtr;

		private Discord.FFIEvents Events;

		private IntPtr ApplicationEventsPtr;

		private ApplicationManager.FFIEvents ApplicationEvents;

		internal ApplicationManager ApplicationManagerInstance;

		private IntPtr UserEventsPtr;

		private UserManager.FFIEvents UserEvents;

		internal UserManager UserManagerInstance;

		private IntPtr ImageEventsPtr;

		private ImageManager.FFIEvents ImageEvents;

		internal ImageManager ImageManagerInstance;

		private IntPtr ActivityEventsPtr;

		private ActivityManager.FFIEvents ActivityEvents;

		internal ActivityManager ActivityManagerInstance;

		private IntPtr RelationshipEventsPtr;

		private RelationshipManager.FFIEvents RelationshipEvents;

		internal RelationshipManager RelationshipManagerInstance;

		private IntPtr LobbyEventsPtr;

		private LobbyManager.FFIEvents LobbyEvents;

		internal LobbyManager LobbyManagerInstance;

		private IntPtr NetworkEventsPtr;

		private NetworkManager.FFIEvents NetworkEvents;

		internal NetworkManager NetworkManagerInstance;

		private IntPtr OverlayEventsPtr;

		private OverlayManager.FFIEvents OverlayEvents;

		internal OverlayManager OverlayManagerInstance;

		private IntPtr StorageEventsPtr;

		private StorageManager.FFIEvents StorageEvents;

		internal StorageManager StorageManagerInstance;

		private IntPtr StoreEventsPtr;

		private StoreManager.FFIEvents StoreEvents;

		internal StoreManager StoreManagerInstance;

		private IntPtr VoiceEventsPtr;

		private VoiceManager.FFIEvents VoiceEvents;

		internal VoiceManager VoiceManagerInstance;

		private IntPtr AchievementEventsPtr;

		private AchievementManager.FFIEvents AchievementEvents;

		internal AchievementManager AchievementManagerInstance;

		private IntPtr MethodsPtr;

		private object MethodsStructure;

		private GCHandle? setLogHook;

		internal struct FFIEvents
		{
		}

		internal struct FFIMethods
		{
			internal Discord.FFIMethods.DestroyHandler Destroy;

			internal Discord.FFIMethods.RunCallbacksMethod RunCallbacks;

			internal Discord.FFIMethods.SetLogHookMethod SetLogHook;

			internal Discord.FFIMethods.GetApplicationManagerMethod GetApplicationManager;

			internal Discord.FFIMethods.GetUserManagerMethod GetUserManager;

			internal Discord.FFIMethods.GetImageManagerMethod GetImageManager;

			internal Discord.FFIMethods.GetActivityManagerMethod GetActivityManager;

			internal Discord.FFIMethods.GetRelationshipManagerMethod GetRelationshipManager;

			internal Discord.FFIMethods.GetLobbyManagerMethod GetLobbyManager;

			internal Discord.FFIMethods.GetNetworkManagerMethod GetNetworkManager;

			internal Discord.FFIMethods.GetOverlayManagerMethod GetOverlayManager;

			internal Discord.FFIMethods.GetStorageManagerMethod GetStorageManager;

			internal Discord.FFIMethods.GetStoreManagerMethod GetStoreManager;

			internal Discord.FFIMethods.GetVoiceManagerMethod GetVoiceManager;

			internal Discord.FFIMethods.GetAchievementManagerMethod GetAchievementManager;

			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void DestroyHandler(IntPtr MethodsPtr);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate Result RunCallbacksMethod(IntPtr methodsPtr);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void SetLogHookCallback(IntPtr ptr, LogLevel level, [MarshalAs(UnmanagedType.LPStr)] string message);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void SetLogHookMethod(IntPtr methodsPtr, LogLevel minLevel, IntPtr callbackData, Discord.FFIMethods.SetLogHookCallback callback);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate IntPtr GetApplicationManagerMethod(IntPtr discordPtr);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate IntPtr GetUserManagerMethod(IntPtr discordPtr);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate IntPtr GetImageManagerMethod(IntPtr discordPtr);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate IntPtr GetActivityManagerMethod(IntPtr discordPtr);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate IntPtr GetRelationshipManagerMethod(IntPtr discordPtr);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate IntPtr GetLobbyManagerMethod(IntPtr discordPtr);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate IntPtr GetNetworkManagerMethod(IntPtr discordPtr);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate IntPtr GetOverlayManagerMethod(IntPtr discordPtr);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate IntPtr GetStorageManagerMethod(IntPtr discordPtr);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate IntPtr GetStoreManagerMethod(IntPtr discordPtr);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate IntPtr GetVoiceManagerMethod(IntPtr discordPtr);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate IntPtr GetAchievementManagerMethod(IntPtr discordPtr);
		}

		internal struct FFICreateParams
		{
			internal long ClientId;

			internal ulong Flags;

			internal IntPtr Events;

			internal IntPtr EventData;

			internal IntPtr ApplicationEvents;

			internal uint ApplicationVersion;

			internal IntPtr UserEvents;

			internal uint UserVersion;

			internal IntPtr ImageEvents;

			internal uint ImageVersion;

			internal IntPtr ActivityEvents;

			internal uint ActivityVersion;

			internal IntPtr RelationshipEvents;

			internal uint RelationshipVersion;

			internal IntPtr LobbyEvents;

			internal uint LobbyVersion;

			internal IntPtr NetworkEvents;

			internal uint NetworkVersion;

			internal IntPtr OverlayEvents;

			internal uint OverlayVersion;

			internal IntPtr StorageEvents;

			internal uint StorageVersion;

			internal IntPtr StoreEvents;

			internal uint StoreVersion;

			internal IntPtr VoiceEvents;

			internal uint VoiceVersion;

			internal IntPtr AchievementEvents;

			internal uint AchievementVersion;
		}

		public delegate void SetLogHookHandler(LogLevel level, string message);
	}
}
