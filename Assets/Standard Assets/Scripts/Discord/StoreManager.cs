using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Discord
{
	// Token: 0x02000039 RID: 57
	public class StoreManager
	{
		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000104 RID: 260 RVA: 0x00006924 File Offset: 0x00004B24
		private StoreManager.FFIMethods Methods
		{
			get
			{
				if (this.MethodsStructure == null)
				{
					this.MethodsStructure = Marshal.PtrToStructure(this.MethodsPtr, typeof(StoreManager.FFIMethods));
				}
				return (StoreManager.FFIMethods)this.MethodsStructure;
			}
		}

		// Token: 0x14000013 RID: 19
		// (add) Token: 0x06000105 RID: 261 RVA: 0x00006954 File Offset: 0x00004B54
		// (remove) Token: 0x06000106 RID: 262 RVA: 0x0000698C File Offset: 0x00004B8C
		public event StoreManager.EntitlementCreateHandler OnEntitlementCreate;

		// Token: 0x14000014 RID: 20
		// (add) Token: 0x06000107 RID: 263 RVA: 0x000069C4 File Offset: 0x00004BC4
		// (remove) Token: 0x06000108 RID: 264 RVA: 0x000069FC File Offset: 0x00004BFC
		public event StoreManager.EntitlementDeleteHandler OnEntitlementDelete;

		// Token: 0x06000109 RID: 265 RVA: 0x00006A34 File Offset: 0x00004C34
		internal StoreManager(IntPtr ptr, IntPtr eventsPtr, ref StoreManager.FFIEvents events)
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

		// Token: 0x0600010A RID: 266 RVA: 0x00006A83 File Offset: 0x00004C83
		private void InitEvents(IntPtr eventsPtr, ref StoreManager.FFIEvents events)
		{
			events.OnEntitlementCreate = new StoreManager.FFIEvents.EntitlementCreateHandler(StoreManager.OnEntitlementCreateImpl);
			events.OnEntitlementDelete = new StoreManager.FFIEvents.EntitlementDeleteHandler(StoreManager.OnEntitlementDeleteImpl);
			Marshal.StructureToPtr<StoreManager.FFIEvents>(events, eventsPtr, false);
		}

		// Token: 0x0600010B RID: 267 RVA: 0x00006AB8 File Offset: 0x00004CB8
		[MonoPInvokeCallback]
		private static void FetchSkusCallbackImpl(IntPtr ptr, Result result)
		{
			GCHandle gchandle = GCHandle.FromIntPtr(ptr);
			StoreManager.FetchSkusHandler fetchSkusHandler = (StoreManager.FetchSkusHandler)gchandle.Target;
			gchandle.Free();
			fetchSkusHandler(result);
		}

		// Token: 0x0600010C RID: 268 RVA: 0x00006AE8 File Offset: 0x00004CE8
		public void FetchSkus(StoreManager.FetchSkusHandler callback)
		{
			GCHandle gchandle = GCHandle.Alloc(callback);
			this.Methods.FetchSkus(this.MethodsPtr, GCHandle.ToIntPtr(gchandle), new StoreManager.FFIMethods.FetchSkusCallback(StoreManager.FetchSkusCallbackImpl));
		}

		// Token: 0x0600010D RID: 269 RVA: 0x00006B24 File Offset: 0x00004D24
		public int CountSkus()
		{
			int num = 0;
			this.Methods.CountSkus(this.MethodsPtr, ref num);
			return num;
		}

		// Token: 0x0600010E RID: 270 RVA: 0x00006B4C File Offset: 0x00004D4C
		public Sku GetSku(long skuId)
		{
			Sku sku = default(Sku);
			Result result = this.Methods.GetSku(this.MethodsPtr, skuId, ref sku);
			if (result != Result.Ok)
			{
				throw new ResultException(result);
			}
			return sku;
		}

		// Token: 0x0600010F RID: 271 RVA: 0x00006B88 File Offset: 0x00004D88
		public Sku GetSkuAt(int index)
		{
			Sku sku = default(Sku);
			Result result = this.Methods.GetSkuAt(this.MethodsPtr, index, ref sku);
			if (result != Result.Ok)
			{
				throw new ResultException(result);
			}
			return sku;
		}

		// Token: 0x06000110 RID: 272 RVA: 0x00006BC4 File Offset: 0x00004DC4
		[MonoPInvokeCallback]
		private static void FetchEntitlementsCallbackImpl(IntPtr ptr, Result result)
		{
			GCHandle gchandle = GCHandle.FromIntPtr(ptr);
			StoreManager.FetchEntitlementsHandler fetchEntitlementsHandler = (StoreManager.FetchEntitlementsHandler)gchandle.Target;
			gchandle.Free();
			fetchEntitlementsHandler(result);
		}

		// Token: 0x06000111 RID: 273 RVA: 0x00006BF4 File Offset: 0x00004DF4
		public void FetchEntitlements(StoreManager.FetchEntitlementsHandler callback)
		{
			GCHandle gchandle = GCHandle.Alloc(callback);
			this.Methods.FetchEntitlements(this.MethodsPtr, GCHandle.ToIntPtr(gchandle), new StoreManager.FFIMethods.FetchEntitlementsCallback(StoreManager.FetchEntitlementsCallbackImpl));
		}

		// Token: 0x06000112 RID: 274 RVA: 0x00006C30 File Offset: 0x00004E30
		public int CountEntitlements()
		{
			int num = 0;
			this.Methods.CountEntitlements(this.MethodsPtr, ref num);
			return num;
		}

		// Token: 0x06000113 RID: 275 RVA: 0x00006C58 File Offset: 0x00004E58
		public Entitlement GetEntitlement(long entitlementId)
		{
			Entitlement entitlement = default(Entitlement);
			Result result = this.Methods.GetEntitlement(this.MethodsPtr, entitlementId, ref entitlement);
			if (result != Result.Ok)
			{
				throw new ResultException(result);
			}
			return entitlement;
		}

		// Token: 0x06000114 RID: 276 RVA: 0x00006C94 File Offset: 0x00004E94
		public Entitlement GetEntitlementAt(int index)
		{
			Entitlement entitlement = default(Entitlement);
			Result result = this.Methods.GetEntitlementAt(this.MethodsPtr, index, ref entitlement);
			if (result != Result.Ok)
			{
				throw new ResultException(result);
			}
			return entitlement;
		}

		// Token: 0x06000115 RID: 277 RVA: 0x00006CD0 File Offset: 0x00004ED0
		public bool HasSkuEntitlement(long skuId)
		{
			bool flag = false;
			Result result = this.Methods.HasSkuEntitlement(this.MethodsPtr, skuId, ref flag);
			if (result != Result.Ok)
			{
				throw new ResultException(result);
			}
			return flag;
		}

		// Token: 0x06000116 RID: 278 RVA: 0x00006D04 File Offset: 0x00004F04
		[MonoPInvokeCallback]
		private static void StartPurchaseCallbackImpl(IntPtr ptr, Result result)
		{
			GCHandle gchandle = GCHandle.FromIntPtr(ptr);
			StoreManager.StartPurchaseHandler startPurchaseHandler = (StoreManager.StartPurchaseHandler)gchandle.Target;
			gchandle.Free();
			startPurchaseHandler(result);
		}

		// Token: 0x06000117 RID: 279 RVA: 0x00006D34 File Offset: 0x00004F34
		public void StartPurchase(long skuId, StoreManager.StartPurchaseHandler callback)
		{
			GCHandle gchandle = GCHandle.Alloc(callback);
			this.Methods.StartPurchase(this.MethodsPtr, skuId, GCHandle.ToIntPtr(gchandle), new StoreManager.FFIMethods.StartPurchaseCallback(StoreManager.StartPurchaseCallbackImpl));
		}

		// Token: 0x06000118 RID: 280 RVA: 0x00006D74 File Offset: 0x00004F74
		[MonoPInvokeCallback]
		private static void OnEntitlementCreateImpl(IntPtr ptr, ref Entitlement entitlement)
		{
			Discord discord = (Discord)GCHandle.FromIntPtr(ptr).Target;
			if (discord.StoreManagerInstance.OnEntitlementCreate != null)
			{
				discord.StoreManagerInstance.OnEntitlementCreate(ref entitlement);
			}
		}

		// Token: 0x06000119 RID: 281 RVA: 0x00006DB4 File Offset: 0x00004FB4
		[MonoPInvokeCallback]
		private static void OnEntitlementDeleteImpl(IntPtr ptr, ref Entitlement entitlement)
		{
			Discord discord = (Discord)GCHandle.FromIntPtr(ptr).Target;
			if (discord.StoreManagerInstance.OnEntitlementDelete != null)
			{
				discord.StoreManagerInstance.OnEntitlementDelete(ref entitlement);
			}
		}

		// Token: 0x0600011A RID: 282 RVA: 0x00006DF4 File Offset: 0x00004FF4
		public IEnumerable<Entitlement> GetEntitlements()
		{
			int num = this.CountEntitlements();
			List<Entitlement> list = new List<Entitlement>();
			for (int i = 0; i < num; i++)
			{
				list.Add(this.GetEntitlementAt(i));
			}
			return list;
		}

		// Token: 0x0600011B RID: 283 RVA: 0x00006E28 File Offset: 0x00005028
		public IEnumerable<Sku> GetSkus()
		{
			int num = this.CountSkus();
			List<Sku> list = new List<Sku>();
			for (int i = 0; i < num; i++)
			{
				list.Add(this.GetSkuAt(i));
			}
			return list;
		}

		// Token: 0x04000134 RID: 308
		private IntPtr MethodsPtr;

		// Token: 0x04000135 RID: 309
		private object MethodsStructure;

		// Token: 0x02000089 RID: 137
		internal struct FFIEvents
		{
			// Token: 0x040001E9 RID: 489
			internal StoreManager.FFIEvents.EntitlementCreateHandler OnEntitlementCreate;

			// Token: 0x040001EA RID: 490
			internal StoreManager.FFIEvents.EntitlementDeleteHandler OnEntitlementDelete;

			// Token: 0x02000135 RID: 309
			// (Invoke) Token: 0x06000493 RID: 1171
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void EntitlementCreateHandler(IntPtr ptr, ref Entitlement entitlement);

			// Token: 0x02000136 RID: 310
			// (Invoke) Token: 0x06000497 RID: 1175
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void EntitlementDeleteHandler(IntPtr ptr, ref Entitlement entitlement);
		}

		// Token: 0x0200008A RID: 138
		internal struct FFIMethods
		{
			// Token: 0x040001EB RID: 491
			internal StoreManager.FFIMethods.FetchSkusMethod FetchSkus;

			// Token: 0x040001EC RID: 492
			internal StoreManager.FFIMethods.CountSkusMethod CountSkus;

			// Token: 0x040001ED RID: 493
			internal StoreManager.FFIMethods.GetSkuMethod GetSku;

			// Token: 0x040001EE RID: 494
			internal StoreManager.FFIMethods.GetSkuAtMethod GetSkuAt;

			// Token: 0x040001EF RID: 495
			internal StoreManager.FFIMethods.FetchEntitlementsMethod FetchEntitlements;

			// Token: 0x040001F0 RID: 496
			internal StoreManager.FFIMethods.CountEntitlementsMethod CountEntitlements;

			// Token: 0x040001F1 RID: 497
			internal StoreManager.FFIMethods.GetEntitlementMethod GetEntitlement;

			// Token: 0x040001F2 RID: 498
			internal StoreManager.FFIMethods.GetEntitlementAtMethod GetEntitlementAt;

			// Token: 0x040001F3 RID: 499
			internal StoreManager.FFIMethods.HasSkuEntitlementMethod HasSkuEntitlement;

			// Token: 0x040001F4 RID: 500
			internal StoreManager.FFIMethods.StartPurchaseMethod StartPurchase;

			// Token: 0x02000137 RID: 311
			// (Invoke) Token: 0x0600049B RID: 1179
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void FetchSkusCallback(IntPtr ptr, Result result);

			// Token: 0x02000138 RID: 312
			// (Invoke) Token: 0x0600049F RID: 1183
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void FetchSkusMethod(IntPtr methodsPtr, IntPtr callbackData, StoreManager.FFIMethods.FetchSkusCallback callback);

			// Token: 0x02000139 RID: 313
			// (Invoke) Token: 0x060004A3 RID: 1187
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void CountSkusMethod(IntPtr methodsPtr, ref int count);

			// Token: 0x0200013A RID: 314
			// (Invoke) Token: 0x060004A7 RID: 1191
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate Result GetSkuMethod(IntPtr methodsPtr, long skuId, ref Sku sku);

			// Token: 0x0200013B RID: 315
			// (Invoke) Token: 0x060004AB RID: 1195
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate Result GetSkuAtMethod(IntPtr methodsPtr, int index, ref Sku sku);

			// Token: 0x0200013C RID: 316
			// (Invoke) Token: 0x060004AF RID: 1199
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void FetchEntitlementsCallback(IntPtr ptr, Result result);

			// Token: 0x0200013D RID: 317
			// (Invoke) Token: 0x060004B3 RID: 1203
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void FetchEntitlementsMethod(IntPtr methodsPtr, IntPtr callbackData, StoreManager.FFIMethods.FetchEntitlementsCallback callback);

			// Token: 0x0200013E RID: 318
			// (Invoke) Token: 0x060004B7 RID: 1207
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void CountEntitlementsMethod(IntPtr methodsPtr, ref int count);

			// Token: 0x0200013F RID: 319
			// (Invoke) Token: 0x060004BB RID: 1211
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate Result GetEntitlementMethod(IntPtr methodsPtr, long entitlementId, ref Entitlement entitlement);

			// Token: 0x02000140 RID: 320
			// (Invoke) Token: 0x060004BF RID: 1215
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate Result GetEntitlementAtMethod(IntPtr methodsPtr, int index, ref Entitlement entitlement);

			// Token: 0x02000141 RID: 321
			// (Invoke) Token: 0x060004C3 RID: 1219
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate Result HasSkuEntitlementMethod(IntPtr methodsPtr, long skuId, ref bool hasEntitlement);

			// Token: 0x02000142 RID: 322
			// (Invoke) Token: 0x060004C7 RID: 1223
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void StartPurchaseCallback(IntPtr ptr, Result result);

			// Token: 0x02000143 RID: 323
			// (Invoke) Token: 0x060004CB RID: 1227
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void StartPurchaseMethod(IntPtr methodsPtr, long skuId, IntPtr callbackData, StoreManager.FFIMethods.StartPurchaseCallback callback);
		}

		// Token: 0x0200008B RID: 139
		// (Invoke) Token: 0x060001FB RID: 507
		public delegate void FetchSkusHandler(Result result);

		// Token: 0x0200008C RID: 140
		// (Invoke) Token: 0x060001FF RID: 511
		public delegate void FetchEntitlementsHandler(Result result);

		// Token: 0x0200008D RID: 141
		// (Invoke) Token: 0x06000203 RID: 515
		public delegate void StartPurchaseHandler(Result result);

		// Token: 0x0200008E RID: 142
		// (Invoke) Token: 0x06000207 RID: 519
		public delegate void EntitlementCreateHandler(ref Entitlement entitlement);

		// Token: 0x0200008F RID: 143
		// (Invoke) Token: 0x0600020B RID: 523
		public delegate void EntitlementDeleteHandler(ref Entitlement entitlement);
	}
}
