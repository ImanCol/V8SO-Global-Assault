using System;
using System.Runtime.InteropServices;

namespace Discord
{
	public class RelationshipManager
	{
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

		public event RelationshipManager.RefreshHandler OnRefresh;

		public event RelationshipManager.RelationshipUpdateHandler OnRelationshipUpdate;

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

		private void InitEvents(IntPtr eventsPtr, ref RelationshipManager.FFIEvents events)
		{
			//events.OnRefresh = new RelationshipManager.FFIEvents.RefreshHandler(RelationshipManager.OnRefreshImpl);
			//events.OnRelationshipUpdate = new RelationshipManager.FFIEvents.RelationshipUpdateHandler(RelationshipManager.OnRelationshipUpdateImpl);
			Marshal.StructureToPtr<RelationshipManager.FFIEvents>(events, eventsPtr, false);
		}

		[MonoPInvokeCallback]
		private static bool FilterCallbackImpl(IntPtr ptr, ref Relationship relationship)
		{
			return ((RelationshipManager.FilterHandler)GCHandle.FromIntPtr(ptr).Target)(ref relationship);
		}

		public void Filter(RelationshipManager.FilterHandler callback)
		{
			GCHandle value = GCHandle.Alloc(callback);
			this.Methods.Filter(this.MethodsPtr, GCHandle.ToIntPtr(value), new RelationshipManager.FFIMethods.FilterCallback(RelationshipManager.FilterCallbackImpl));
			value.Free();
		}

		public int Count()
		{
			int result = 0;
			Result result2 = this.Methods.Count(this.MethodsPtr, ref result);
			if (result2 != Result.Ok)
			{
				throw new ResultException(result2);
			}
			return result;
		}

		public Relationship Get(long userId)
		{
			Relationship result = default(Relationship);
			Result result2 = this.Methods.Get(this.MethodsPtr, userId, ref result);
			if (result2 != Result.Ok)
			{
				throw new ResultException(result2);
			}
			return result;
		}

		public Relationship GetAt(uint index)
		{
			Relationship result = default(Relationship);
			Result result2 = this.Methods.GetAt(this.MethodsPtr, index, ref result);
			if (result2 != Result.Ok)
			{
				throw new ResultException(result2);
			}
			return result;
		}

		[MonoPInvokeCallback]
		private static void OnRefreshImpl(IntPtr ptr)
		{
			Discord discord = (Discord)GCHandle.FromIntPtr(ptr).Target;
			if (discord.RelationshipManagerInstance.OnRefresh != null)
			{
				discord.RelationshipManagerInstance.OnRefresh();
			}
		}

		[MonoPInvokeCallback]
		private static void OnRelationshipUpdateImpl(IntPtr ptr, ref Relationship relationship)
		{
			Discord discord = (Discord)GCHandle.FromIntPtr(ptr).Target;
			if (discord.RelationshipManagerInstance.OnRelationshipUpdate != null)
			{
				discord.RelationshipManagerInstance.OnRelationshipUpdate(ref relationship);
			}
		}

		private IntPtr MethodsPtr;

		private object MethodsStructure;

		internal struct FFIEvents
		{




			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void RefreshHandler(IntPtr ptr);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void RelationshipUpdateHandler(IntPtr ptr, ref Relationship relationship);
		}

		internal struct FFIMethods
		{
			internal RelationshipManager.FFIMethods.FilterMethod Filter;

			internal RelationshipManager.FFIMethods.CountMethod Count;

			internal RelationshipManager.FFIMethods.GetMethod Get;

			internal RelationshipManager.FFIMethods.GetAtMethod GetAt;

			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate bool FilterCallback(IntPtr ptr, ref Relationship relationship);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void FilterMethod(IntPtr methodsPtr, IntPtr callbackData, RelationshipManager.FFIMethods.FilterCallback callback);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate Result CountMethod(IntPtr methodsPtr, ref int count);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate Result GetMethod(IntPtr methodsPtr, long userId, ref Relationship relationship);

			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate Result GetAtMethod(IntPtr methodsPtr, uint index, ref Relationship relationship);
		}

		public delegate bool FilterHandler(ref Relationship relationship);

		public delegate void RefreshHandler();

		public delegate void RelationshipUpdateHandler(ref Relationship relationship);
	}
}
