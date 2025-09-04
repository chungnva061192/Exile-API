using System;
using ExileCore2.PoEMemory.Models;

namespace ExileCore2.PoEMemory.MemoryObjects
{
	// Token: 0x020001FC RID: 508
	public class PlacedCurrencyExchangeOrder : RemoteMemoryObject
	{
		// Token: 0x17000492 RID: 1170
		// (get) Token: 0x06000F3B RID: 3899 RVA: 0x001A11AC File Offset: 0x001A11AC
		public DateTimeOffset CreationDate
		{
			get
			{
				this;
				return this;
			}
		}

		// Token: 0x17000493 RID: 1171
		// (get) Token: 0x06000F3C RID: 3900 RVA: 0x001A11C8 File Offset: 0x001A11C8
		public int PlayerOrderId
		{
			get
			{
				this;
				return this + 40L;
			}
		}

		// Token: 0x17000494 RID: 1172
		// (get) Token: 0x06000F3D RID: 3901 RVA: 0x001A11E0 File Offset: 0x001A11E0
		public uint OfferedItemHash
		{
			get
			{
				this;
				return this + 44L;
			}
		}

		// Token: 0x17000495 RID: 1173
		// (get) Token: 0x06000F3E RID: 3902 RVA: 0x001A11F8 File Offset: 0x001A11F8
		public BaseItemType OfferedItemType
		{
			get
			{
				return this;
			}
		}

		// Token: 0x17000496 RID: 1174
		// (get) Token: 0x06000F3F RID: 3903 RVA: 0x001A1214 File Offset: 0x001A1214
		public uint WantedItemHash
		{
			get
			{
				this;
				return this + 48L;
			}
		}

		// Token: 0x17000497 RID: 1175
		// (get) Token: 0x06000F40 RID: 3904 RVA: 0x001A122C File Offset: 0x001A122C
		public BaseItemType WantedItemType
		{
			get
			{
				return this;
			}
		}

		// Token: 0x17000498 RID: 1176
		// (get) Token: 0x06000F41 RID: 3905 RVA: 0x001A1248 File Offset: 0x001A1248
		public int OriginalOfferedItemStackSize
		{
			get
			{
				this;
				return this + 52L;
			}
		}

		// Token: 0x17000499 RID: 1177
		// (get) Token: 0x06000F42 RID: 3906 RVA: 0x001A1260 File Offset: 0x001A1260
		public int OfferedItemStackSize
		{
			get
			{
				this;
				return this + 56L;
			}
		}

		// Token: 0x1700049A RID: 1178
		// (get) Token: 0x06000F43 RID: 3907 RVA: 0x001A1278 File Offset: 0x001A1278
		public int WantedItemStackSize
		{
			get
			{
				this;
				return this + 60L;
			}
		}

		// Token: 0x1700049B RID: 1179
		// (get) Token: 0x06000F44 RID: 3908 RVA: 0x001A1290 File Offset: 0x001A1290
		public int GoldCost
		{
			get
			{
				this;
				return this + 64L;
			}
		}

		// Token: 0x1700049C RID: 1180
		// (get) Token: 0x06000F45 RID: 3909 RVA: 0x001A12A8 File Offset: 0x001A12A8
		public int OfferedItemRatioPart
		{
			get
			{
				this;
				return this + 72L;
			}
		}

		// Token: 0x1700049D RID: 1181
		// (get) Token: 0x06000F46 RID: 3910 RVA: 0x001A12C0 File Offset: 0x001A12C0
		public int WantedItemRatioPart
		{
			get
			{
				this;
				return this + 74L;
			}
		}

		// Token: 0x1700049E RID: 1182
		// (get) Token: 0x06000F47 RID: 3911 RVA: 0x001A12D8 File Offset: 0x001A12D8
		public int CompetingOfferedItemRatioPart
		{
			get
			{
				this;
				return this + 76L;
			}
		}

		// Token: 0x1700049F RID: 1183
		// (get) Token: 0x06000F48 RID: 3912 RVA: 0x001A12F0 File Offset: 0x001A12F0
		public int CompetingWantedItemRatioPart
		{
			get
			{
				this;
				return this + 78L;
			}
		}

		// Token: 0x170004A0 RID: 1184
		// (get) Token: 0x06000F49 RID: 3913 RVA: 0x001A1308 File Offset: 0x001A1308
		public bool IsCompleted
		{
			get
			{
				return this > 0;
			}
		}

		// Token: 0x170004A1 RID: 1185
		// (get) Token: 0x06000F4A RID: 3914 RVA: 0x001A1314 File Offset: 0x001A1314
		public bool IsCanceled
		{
			get
			{
				return this == 3;
			}
		}

		// Token: 0x170004A2 RID: 1186
		// (get) Token: 0x06000F4B RID: 3915 RVA: 0x001A1320 File Offset: 0x001A1320
		private byte State
		{
			get
			{
				this;
				return this + 80L;
			}
		}

		// Token: 0x06000F4C RID: 3916 RVA: 0x001A1338 File Offset: 0x001A1338
		public override string ToString()
		{
			/*
An exception occurred when decompiling this method (06000F4C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String ExileCore2.PoEMemory.MemoryObjects.PlacedCurrencyExchangeOrder::ToString()

 ---> System.Exception: Inconsistent stack size at IL_09
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 443
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.Build(MethodDef methodDef, Boolean optimize, DecompilerContext context) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 271
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 112
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
		}

		// Token: 0x06000F4D RID: 3917 RVA: 0x001A13D4 File Offset: 0x001A13D4
		public PlacedCurrencyExchangeOrder()
		{
			this;
		}
	}
}
