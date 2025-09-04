using System;
using ExileCore2.PoEMemory.MemoryObjects;

namespace ExileCore2.Shared.Interfaces
{
	// Token: 0x0200011C RID: 284
	public interface IPlugin : IDisposable
	{
		// Token: 0x170001D1 RID: 465
		// (get) Token: 0x060008BD RID: 2237
		// (set) Token: 0x060008BE RID: 2238
		bool Initialized { get; set; }

		// Token: 0x170001D2 RID: 466
		// (get) Token: 0x060008BF RID: 2239
		ISettings _Settings { get; }

		// Token: 0x170001D3 RID: 467
		// (get) Token: 0x060008C0 RID: 2240
		bool CanUseMultiThreading { get; }

		// Token: 0x170001D4 RID: 468
		// (get) Token: 0x060008C1 RID: 2241
		bool Force { get; }

		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x060008C2 RID: 2242
		// (set) Token: 0x060008C3 RID: 2243
		string DirectoryName { get; set; }

		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x060008C4 RID: 2244
		// (set) Token: 0x060008C5 RID: 2245
		string DirectoryFullName { get; set; }

		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x060008C6 RID: 2246
		string InternalName { get; }

		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x060008C7 RID: 2247
		string Name { get; }

		// Token: 0x170001D9 RID: 473
		// (get) Token: 0x060008C8 RID: 2248
		string Description { get; }

		// Token: 0x170001DA RID: 474
		// (get) Token: 0x060008C9 RID: 2249
		int Order { get; }

		// Token: 0x060008CA RID: 2250
		void DrawSettings();

		// Token: 0x060008CB RID: 2251
		void OnLoad();

		// Token: 0x060008CC RID: 2252
		void OnUnload();

		// Token: 0x060008CD RID: 2253
		bool Initialise();

		// Token: 0x060008CE RID: 2254
		void Tick();

		// Token: 0x060008CF RID: 2255
		void Render();

		// Token: 0x060008D0 RID: 2256
		void OnClose();

		// Token: 0x060008D1 RID: 2257
		void SetApi(GameController gameController, Graphics graphics, PluginManager pluginManager);

		// Token: 0x060008D2 RID: 2258
		void OnPluginSelectedInMenu();

		// Token: 0x060008D3 RID: 2259
		void EntityAdded(Entity entity);

		// Token: 0x060008D4 RID: 2260
		void EntityRemoved(Entity entity);

		// Token: 0x060008D5 RID: 2261
		void EntityAddedAny(Entity entity);

		// Token: 0x060008D6 RID: 2262
		void AreaChange(AreaInstance area);

		// Token: 0x060008D7 RID: 2263
		void ReceiveEvent(string eventId, object args);

		// Token: 0x060008D8 RID: 2264
		void _LoadSettings();

		// Token: 0x060008D9 RID: 2265
		void _SaveSettings();

		// Token: 0x060008DA RID: 2266
		void OnPluginDestroyForHotReload();
	}
}
