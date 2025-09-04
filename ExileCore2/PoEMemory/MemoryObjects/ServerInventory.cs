using System;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using ExileCore2.Shared;
using ExileCore2.Shared.Cache;
using ExileCore2.Shared.Enums;
using GameOffsets2;
using GameOffsets2.Native;

namespace ExileCore2.PoEMemory.MemoryObjects
{
	// Token: 0x0200020A RID: 522
	public class ServerInventory : RemoteMemoryObject
	{
		// Token: 0x06000FC7 RID: 4039 RVA: 0x001A23C8 File Offset: 0x001A23C8
		public ServerInventory()
		{
			this;
			this;
			this;
			this;
			this;
		}

		// Token: 0x170004F8 RID: 1272
		// (get) Token: 0x06000FC8 RID: 4040 RVA: 0x001A2400 File Offset: 0x001A2400
		private ServerInventoryOffsets Struct
		{
			get
			{
				return this;
			}
		}

		// Token: 0x170004F9 RID: 1273
		// (get) Token: 0x06000FC9 RID: 4041 RVA: 0x001A2410 File Offset: 0x001A2410
		public InventoryTypeE InventType
		{
			get
			{
				return this;
			}
		}

		// Token: 0x170004FA RID: 1274
		// (get) Token: 0x06000FCA RID: 4042 RVA: 0x001A2420 File Offset: 0x001A2420
		public InventorySlotE InventSlot
		{
			get
			{
				return this;
			}
		}

		// Token: 0x170004FB RID: 1275
		// (get) Token: 0x06000FCB RID: 4043 RVA: 0x001A2430 File Offset: 0x001A2430
		public int Columns
		{
			get
			{
				return this;
			}
		}

		// Token: 0x170004FC RID: 1276
		// (get) Token: 0x06000FCC RID: 4044 RVA: 0x001A2440 File Offset: 0x001A2440
		public int Rows
		{
			get
			{
				return this;
			}
		}

		// Token: 0x170004FD RID: 1277
		// (get) Token: 0x06000FCD RID: 4045 RVA: 0x001A2450 File Offset: 0x001A2450
		public bool IsRequested
		{
			get
			{
				return this == 1;
			}
		}

		// Token: 0x170004FE RID: 1278
		// (get) Token: 0x06000FCE RID: 4046 RVA: 0x001A2460 File Offset: 0x001A2460
		public long ItemCount
		{
			get
			{
				return this;
			}
		}

		// Token: 0x170004FF RID: 1279
		// (get) Token: 0x06000FCF RID: 4047 RVA: 0x001A2470 File Offset: 0x001A2470
		public int ServerRequestCounter
		{
			get
			{
				return this;
			}
		}

		// Token: 0x17000500 RID: 1280
		// (get) Token: 0x06000FD0 RID: 4048 RVA: 0x001A2480 File Offset: 0x001A2480
		public IList<ServerInventory.InventSlotItem> InventorySlotItems
		{
			get
			{
				this;
				return this;
			}
		}

		// Token: 0x17000501 RID: 1281
		// (get) Token: 0x06000FD1 RID: 4049 RVA: 0x001A24A4 File Offset: 0x001A24A4
		public long Hash
		{
			get
			{
				return this;
			}
		}

		// Token: 0x17000502 RID: 1282
		// (get) Token: 0x06000FD2 RID: 4050 RVA: 0x001A24B4 File Offset: 0x001A24B4
		public IList<Entity> Items
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000FD2)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.Generic.IList`1<ExileCore2.PoEMemory.MemoryObjects.Entity> ExileCore2.PoEMemory.MemoryObjects.ServerInventory::get_Items()

 ---> System.ArgumentOutOfRangeException: Non-negative number required. (Parameter 'length')
   at System.Array.Copy(Array sourceArray, Int32 sourceIndex, Array destinationArray, Int32 destinationIndex, Int32 length, Boolean reliable)
   at System.Array.Copy(Array sourceArray, Array destinationArray, Int32 length)
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackSlot.ModifyStack(StackSlot[] stack, Int32 popCount, Int32 pushCount, ByteCode pushDefinition) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 48
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 387
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.Build(MethodDef methodDef, Boolean optimize, DecompilerContext context) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 271
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 112
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
			}
		}

		// Token: 0x17000503 RID: 1283
		public ServerInventory.InventSlotItem this[int x, int y]
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000FD3)

ICSharpCode.Decompiler.DecompilerException: Error decompiling ExileCore2.PoEMemory.MemoryObjects.ServerInventory/InventSlotItem ExileCore2.PoEMemory.MemoryObjects.ServerInventory::get_Item(System.Int32,System.Int32)

 ---> System.Exception: Inconsistent stack size at IL_0B
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 443
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.Build(MethodDef methodDef, Boolean optimize, DecompilerContext context) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 271
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 112
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
			}
		}

		// Token: 0x06000FD4 RID: 4052 RVA: 0x001A2534 File Offset: 0x001A2534
		public Dictionary<int, ServerInventory.InventSlotItem> ReadHashMap(long pointer, int limitMax)
		{
			/*
An exception occurred when decompiling this method (06000FD4)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.Generic.Dictionary`2<System.Int32,ExileCore2.PoEMemory.MemoryObjects.ServerInventory/InventSlotItem> ExileCore2.PoEMemory.MemoryObjects.ServerInventory::ReadHashMap(System.Int64,System.Int32)

 ---> System.OverflowException: Arithmetic operation resulted in an overflow.
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackSlot.ModifyStack(StackSlot[] stack, Int32 popCount, Int32 pushCount, ByteCode pushDefinition) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 47
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 387
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.Build(MethodDef methodDef, Boolean optimize, DecompilerContext context) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 271
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 112
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
		}

		// Token: 0x04008050 RID: 32848
		private readonly CachedValue<ServerInventoryOffsets> cachedValue;

		// Token: 0x04008051 RID: 32849
		private readonly CachedValue<List<ServerInventory.InventSlotItem>> _itemsByPositionCache;

		// Token: 0x04008052 RID: 32850
		private const int HashReadLimit = 1000;

		// Token: 0x0200020B RID: 523
		public class HashNode : RemoteMemoryObject
		{
			// Token: 0x06000FD8 RID: 4056 RVA: 0x001A26B0 File Offset: 0x001A26B0
			public HashNode()
			{
				this;
				this;
				this;
			}

			// Token: 0x17000504 RID: 1284
			// (get) Token: 0x06000FD9 RID: 4057 RVA: 0x001A26D4 File Offset: 0x001A26D4
			private NativeHashNode NativeHashNode
			{
				get
				{
					return this;
				}
			}

			// Token: 0x17000505 RID: 1285
			// (get) Token: 0x06000FDA RID: 4058 RVA: 0x001A26E4 File Offset: 0x001A26E4
			public ServerInventory.HashNode Previous
			{
				get
				{
					this;
					return this;
				}
			}

			// Token: 0x17000506 RID: 1286
			// (get) Token: 0x06000FDB RID: 4059 RVA: 0x001A26F8 File Offset: 0x001A26F8
			public ServerInventory.HashNode Root
			{
				get
				{
					this;
					return this;
				}
			}

			// Token: 0x17000507 RID: 1287
			// (get) Token: 0x06000FDC RID: 4060 RVA: 0x001A270C File Offset: 0x001A270C
			public ServerInventory.HashNode Next
			{
				get
				{
					this;
					return this;
				}
			}

			// Token: 0x17000508 RID: 1288
			// (get) Token: 0x06000FDD RID: 4061 RVA: 0x001A2720 File Offset: 0x001A2720
			public bool IsNull
			{
				get
				{
					return this != 0;
				}
			}

			// Token: 0x17000509 RID: 1289
			// (get) Token: 0x06000FDE RID: 4062 RVA: 0x001A2730 File Offset: 0x001A2730
			public int Key
			{
				get
				{
					return this;
				}
			}

			// Token: 0x1700050A RID: 1290
			// (get) Token: 0x06000FDF RID: 4063 RVA: 0x001A2740 File Offset: 0x001A2740
			public ServerInventory.InventSlotItem Value1
			{
				get
				{
					this;
					return this;
				}
			}

			// Token: 0x04008053 RID: 32851
			private readonly FrameCache<NativeHashNode> frameCache;
		}

		// Token: 0x0200020C RID: 524
		public class InventSlotItem : RemoteMemoryObject
		{
			// Token: 0x06000FE1 RID: 4065 RVA: 0x001A2768 File Offset: 0x001A2768
			public InventSlotItem()
			{
				this;
				this;
				this;
			}

			// Token: 0x1700050B RID: 1291
			// (get) Token: 0x06000FE2 RID: 4066 RVA: 0x001A278C File Offset: 0x001A278C
			public Vector2 InventoryPosition
			{
				get
				{
					/*
An exception occurred when decompiling this method (06000FE2)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Numerics.Vector2 ExileCore2.PoEMemory.MemoryObjects.ServerInventory/InventSlotItem::get_InventoryPosition()

 ---> System.OverflowException: Arithmetic operation resulted in an overflow.
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackSlot.ModifyStack(StackSlot[] stack, Int32 popCount, Int32 pushCount, ByteCode pushDefinition) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 47
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 387
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.Build(MethodDef methodDef, Boolean optimize, DecompilerContext context) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 271
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 112
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
				}
			}

			// Token: 0x1700050C RID: 1292
			// (get) Token: 0x06000FE3 RID: 4067 RVA: 0x001A27A8 File Offset: 0x001A27A8
			public ServerInventory.InventSlotItem.ItemMinMaxLocation Location
			{
				get
				{
					this;
					return this + 8L;
				}
			}

			// Token: 0x1700050D RID: 1293
			// (get) Token: 0x06000FE4 RID: 4068 RVA: 0x001A27C0 File Offset: 0x001A27C0
			public Entity Item
			{
				get
				{
					return this;
				}
			}

			// Token: 0x1700050E RID: 1294
			// (get) Token: 0x06000FE5 RID: 4069 RVA: 0x001A27D0 File Offset: 0x001A27D0
			public int PosX
			{
				get
				{
					this;
					return this + 8L;
				}
			}

			// Token: 0x1700050F RID: 1295
			// (get) Token: 0x06000FE6 RID: 4070 RVA: 0x001A27E8 File Offset: 0x001A27E8
			public int PosY
			{
				get
				{
					this;
					return this + 12L;
				}
			}

			// Token: 0x17000510 RID: 1296
			// (get) Token: 0x06000FE7 RID: 4071 RVA: 0x001A2800 File Offset: 0x001A2800
			public int SizeX
			{
				get
				{
					this;
					return this + 16L - this;
				}
			}

			// Token: 0x17000511 RID: 1297
			// (get) Token: 0x06000FE8 RID: 4072 RVA: 0x001A2820 File Offset: 0x001A2820
			public int SizeY
			{
				get
				{
					this;
					return this + 20L - this;
				}
			}

			// Token: 0x17000512 RID: 1298
			// (get) Token: 0x06000FE9 RID: 4073 RVA: 0x001A2840 File Offset: 0x001A2840
			public int Version
			{
				get
				{
					this;
					return this + 24L;
				}
			}

			// Token: 0x17000513 RID: 1299
			// (get) Token: 0x06000FEA RID: 4074 RVA: 0x001A2858 File Offset: 0x001A2858
			private RectangleF ClientRect
			{
				get
				{
					return this;
				}
			}

			// Token: 0x06000FEB RID: 4075 RVA: 0x001A2860 File Offset: 0x001A2860
			public RectangleF GetClientRect()
			{
				/*
An exception occurred when decompiling this method (06000FEB)

ICSharpCode.Decompiler.DecompilerException: Error decompiling ExileCore2.Shared.RectangleF ExileCore2.PoEMemory.MemoryObjects.ServerInventory/InventSlotItem::GetClientRect()

 ---> System.OverflowException: Arithmetic operation resulted in an overflow.
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackSlot.ModifyStack(StackSlot[] stack, Int32 popCount, Int32 pushCount, ByteCode pushDefinition) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 47
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 387
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.Build(MethodDef methodDef, Boolean optimize, DecompilerContext context) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 271
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 112
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
			}

			// Token: 0x06000FEC RID: 4076 RVA: 0x001A28C4 File Offset: 0x001A28C4
			public override string ToString()
			{
				/*
An exception occurred when decompiling this method (06000FEC)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String ExileCore2.PoEMemory.MemoryObjects.ServerInventory/InventSlotItem::ToString()

 ---> System.Exception: Inconsistent stack size at IL_15
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 443
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.Build(MethodDef methodDef, Boolean optimize, DecompilerContext context) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 271
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 112
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
			}

			// Token: 0x04008054 RID: 32852
			private readonly CachedValue<Entity> _itemCache;

			// Token: 0x0200020D RID: 525
			public struct ItemMinMaxLocation
			{
				// Token: 0x17000514 RID: 1300
				// (get) Token: 0x06000FEE RID: 4078 RVA: 0x001A2930 File Offset: 0x001A2930
				// (set) Token: 0x06000FEF RID: 4079 RVA: 0x001A2938 File Offset: 0x001A2938
				private int XMin
				{
					[CompilerGenerated]
					readonly get
					{
						return ref this;
					}
					[CompilerGenerated]
					set
					{
						ref this;
						value;
					}
				}

				// Token: 0x17000515 RID: 1301
				// (get) Token: 0x06000FF0 RID: 4080 RVA: 0x001A2944 File Offset: 0x001A2944
				// (set) Token: 0x06000FF1 RID: 4081 RVA: 0x001A294C File Offset: 0x001A294C
				private int YMin
				{
					[CompilerGenerated]
					readonly get
					{
						return ref this;
					}
					[CompilerGenerated]
					set
					{
						ref this;
						value;
					}
				}

				// Token: 0x17000516 RID: 1302
				// (get) Token: 0x06000FF2 RID: 4082 RVA: 0x001A2958 File Offset: 0x001A2958
				// (set) Token: 0x06000FF3 RID: 4083 RVA: 0x001A2960 File Offset: 0x001A2960
				private int XMax
				{
					[CompilerGenerated]
					readonly get
					{
						return ref this;
					}
					[CompilerGenerated]
					set
					{
						ref this;
						value;
					}
				}

				// Token: 0x17000517 RID: 1303
				// (get) Token: 0x06000FF4 RID: 4084 RVA: 0x001A296C File Offset: 0x001A296C
				// (set) Token: 0x06000FF5 RID: 4085 RVA: 0x001A2974 File Offset: 0x001A2974
				private int YMax
				{
					[CompilerGenerated]
					readonly get
					{
						return ref this;
					}
					[CompilerGenerated]
					set
					{
						ref this;
						value;
					}
				}

				// Token: 0x06000FF6 RID: 4086 RVA: 0x001A2980 File Offset: 0x001A2980
				public RectangleF GetItemRect(float invStartX, float invStartY, float cellsize)
				{
					/*
An exception occurred when decompiling this method (06000FF6)

ICSharpCode.Decompiler.DecompilerException: Error decompiling ExileCore2.Shared.RectangleF ExileCore2.PoEMemory.MemoryObjects.ServerInventory/InventSlotItem/ItemMinMaxLocation::GetItemRect(System.Single,System.Single,System.Single)

 ---> System.Exception: Inconsistent stack size at IL_1A
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 443
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.Build(MethodDef methodDef, Boolean optimize, DecompilerContext context) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 271
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 112
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
				}

				// Token: 0x17000518 RID: 1304
				// (get) Token: 0x06000FF7 RID: 4087 RVA: 0x001A29D0 File Offset: 0x001A29D0
				public Vector2 InventoryPosition
				{
					get
					{
						ref this;
						return ref this;
					}
				}

				// Token: 0x06000FF8 RID: 4088 RVA: 0x001A29E8 File Offset: 0x001A29E8
				public override string ToString()
				{
					/*
An exception occurred when decompiling this method (06000FF8)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String ExileCore2.PoEMemory.MemoryObjects.ServerInventory/InventSlotItem/ItemMinMaxLocation::ToString()

 ---> System.Exception: Inconsistent stack size at IL_2A
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 443
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.Build(MethodDef methodDef, Boolean optimize, DecompilerContext context) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 271
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 112
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
				}
			}
		}
	}
}
