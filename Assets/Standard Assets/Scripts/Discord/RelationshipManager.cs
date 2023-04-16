using System;
using System.Runtime.InteropServices;

namespace Discord
{
	// Token: 0x02000034 RID: 52
	public class RelationshipManager
	{
		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600007A RID: 122 RVA: 0x000049C0 File Offset: 0x00002BC0
		private RelationshipManager.FFIMethods Methods
		{
			get
			{
				if (this.MethodsStructure == null)
				{
					this.MethodsStructure = Marshal.PtrToStructure(this.MethodsPtr, typeof(RelationshipManager.FFIMethods));
				}
				return (RelationshipManager.FFIMethods)this.MethodsStructure;
			}
		}

		// Token: 0x14000006 RID: 6
		// (add) Token: 0x0600007B RID: 123 RVA: 0x000049F0 File Offset: 0x00002BF0
		// (remove) Token: 0x0600007C RID: 124 RVA: 0x00004A28 File Offset: 0x00002C28
		public event RelationshipManager.RefreshHandler OnRefresh;

		// Token: 0x14000007 RID: 7
		// (add) Token: 0x0600007D RID: 125 RVA: 0x00004A60 File Offset: 0x00002C60
		// (remove) Token: 0x0600007E RID: 126 RVA: 0x00004A98 File Offset: 0x00002C98
		public event RelationshipManager.RelationshipUpdateHandler OnRelationshipUpdate;

		// Token: 0x0600007F RID: 127 RVA: 0x00004AD0 File Offset: 0x00002CD0
		internal RelationshipManager(IntPtr ptr, IntPtr eventsPtr, ref RelationshipManager.FFIEvents events)
		{
			if (eventsPtr == IntPtr.Zero)
			{
				throw new ResultException(Result.InternalError);
			}
			this.InitEvents(eventsPtr, ref events);
			this.MethodsPtr = ptr;
			if (this.MethodsPtr == IntPtr.Zero)
			{
				throw new ResultException(Result.InternalError);
			}
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00004B1F File Offset: 0x00002D1F
		private void InitEvents(IntPtr eventsPtr, ref RelationshipManager.FFIEvents events)
		{
			events.OnRefresh = new RelationshipManager.FFIEvents.RefreshHandler(RelationshipManager.OnRefreshImpl);
			events.OnRelationshipUpdate = new RelationshipManager.FFIEvents.RelationshipUpdateHandler(RelationshipManager.OnRelationshipUpdateImpl);
			Marshal.StructureToPtr<RelationshipManager.FFIEvents>(events, eventsPtr, false);
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00004B54 File Offset: 0x00002D54
		[MonoPInvokeCallback]
		private static bool FilterCallbackImpl(IntPtr ptr, ref Relationship relationship)
		{
			return ((RelationshipManager.FilterHandler)GCHandle.FromIntPtr(ptr).Target)(ref relationship);
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00004B7C File Offset: 0x00002D7C
		public void Filter(RelationshipManager.FilterHandler callback)
		{
			GCHandle gchandle = GCHandle.Alloc(callback);
			this.Methods.Filter(this.MethodsPtr, GCHandle.ToIntPtr(gchandle), new RelationshipManager.FFIMethods.FilterCallback(RelationshipManager.FilterCallbackImpl));
			gchandle.Free();
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00004BC0 File Offset: 0x00002DC0
		public int Count()
		{
			int num = 0;
			Result result = this.Methods.Count(this.MethodsPtr, ref num);
			if (result != Result.Ok)
			{
				throw new ResultException(result);
			}
			return num;
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00004BF4 File Offset: 0x00002DF4
		public Relationship Get(long userId)
		{
			Relationship relationship = default(Relationship);
			Result result = this.Methods.Get(this.MethodsPtr, userId, ref relationship);
			if (result != Result.Ok)
			{
				throw new ResultException(result);
			}
			return relationship;
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00004C30 File Offset: 0x00002E30
		public Relationship GetAt(uint index)
		{
			Relationship relationship = default(Relationship);
			Result result = this.Methods.GetAt(this.MethodsPtr, index, ref relationship);
			if (result != Result.Ok)
			{
				throw new ResultException(result);
			}
			return relationship;
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00004C6C File Offset: 0x00002E6C
		[MonoPInvokeCallback]
		private static void OnRefreshImpl(IntPtr ptr)
		{
			Discord discord = (Discord)GCHandle.FromIntPtr(ptr).Target;
			if (discord.RelationshipManagerInstance.OnRefresh != null)
			{
				discord.RelationshipManagerInstance.OnRefresh();
			}
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00004CAC File Offset: 0x00002EAC
		[MonoPInvokeCallback]
		private static void OnRelationshipUpdateImpl(IntPtr ptr, ref Relationship relationship)
		{
			Discord discord = (Discord)GCHandle.FromIntPtr(ptr).Target;
			if (discord.RelationshipManagerInstance.OnRelationshipUpdate != null)
			{
				discord.RelationshipManagerInstance.OnRelationshipUpdate(ref relationship);
			}
		}

		// Token: 0x0400011D RID: 285
		private IntPtr MethodsPtr;

		// Token: 0x0400011E RID: 286
		private object MethodsStructure;

		// Token: 0x0200005F RID: 95
		internal struct FFIEvents
		{
			// Token: 0x0400019E RID: 414
			internal RelationshipManager.FFIEvents.RefreshHandler OnRefresh;

			// Token: 0x0400019F RID: 415
			internal RelationshipManager.FFIEvents.RelationshipUpdateHandler OnRelationshipUpdate;

			// Token: 0x020000D7 RID: 215
			// (Invoke) Token: 0x0600031B RID: 795
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void RefreshHandler(IntPtr ptr);

			// Token: 0x020000D8 RID: 216
			// (Invoke) Token: 0x0600031F RID: 799
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void RelationshipUpdateHandler(IntPtr ptr, ref Relationship relationship);
		}

		// Token: 0x02000060 RID: 96
		internal struct FFIMethods
		{
			// Token: 0x040001A0 RID: 416
			internal RelationshipManager.FFIMethods.FilterMethod Filter;

			// Token: 0x040001A1 RID: 417
			internal RelationshipManager.FFIMethods.CountMethod Count;

			// Token: 0x040001A2 RID: 418
			internal RelationshipManager.FFIMethods.GetMethod Get;

			// Token: 0x040001A3 RID: 419
			internal RelationshipManager.FFIMethods.GetAtMethod GetAt;

			// Token: 0x020000D9 RID: 217
			// (Invoke) Token: 0x06000323 RID: 803
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate bool FilterCallback(IntPtr ptr, ref Relationship relationship);

			// Token: 0x020000DA RID: 218
			// (Invoke) Token: 0x06000327 RID: 807
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void FilterMethod(IntPtr methodsPtr, IntPtr callbackData, RelationshipManager.FFIMethods.FilterCallback callback);

			// Token: 0x020000DB RID: 219
			// (Invoke) Token: 0x0600032B RID: 811
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate Result CountMethod(IntPtr methodsPtr, ref int count);

			// Token: 0x020000DC RID: 220
			// (Invoke) Token: 0x0600032F RID: 815
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate Result GetMethod(IntPtr methodsPtr, long userId, ref Relationship relationship);

			// Token: 0x020000DD RID: 221
			// (Invoke) Token: 0x06000333 RID: 819
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate Result GetAtMethod(IntPtr methodsPtr, uint index, ref Relationship relationship);
		}

		// Token: 0x02000061 RID: 97
		// (Invoke) Token: 0x0600017B RID: 379
		public delegate bool FilterHandler(ref Relationship relationship);

		// Token: 0x02000062 RID: 98
		// (Invoke) Token: 0x0600017F RID: 383
		public delegate void RefreshHandler();

		// Token: 0x02000063 RID: 99
		// (Invoke) Token: 0x06000183 RID: 387
		public delegate void RelationshipUpdateHandler(ref Relationship relationship);
	}
}
