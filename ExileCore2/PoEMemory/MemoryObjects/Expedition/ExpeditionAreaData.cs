using System;
using System.Collections.Generic;
using ExileCore2.Shared.Cache;
using GameOffsets2.Components.LeagueSpecific;

namespace ExileCore2.PoEMemory.MemoryObjects.Expedition
{
	// Token: 0x02000219 RID: 537
	public class ExpeditionAreaData : RemoteMemoryObject
	{
		// Token: 0x06001057 RID: 4183 RVA: 0x001A3754 File Offset: 0x001A3754
		public ExpeditionAreaData()
		{
			this;
			this;
			this;
		}

		// Token: 0x17000559 RID: 1369
		// (get) Token: 0x06001058 RID: 4184 RVA: 0x001A3778 File Offset: 0x001A3778
		public ExpeditionAreaDataOffsets ExpeditionAreaDataStruct
		{
			get
			{
				return this;
			}
		}

		// Token: 0x1700055A RID: 1370
		// (get) Token: 0x06001059 RID: 4185 RVA: 0x001A3788 File Offset: 0x001A3788
		public string Name
		{
			get
			{
				this;
				this;
				this;
				(new int[2])[1] = 8;
				return 1;
			}
		}

		// Token: 0x1700055B RID: 1371
		// (get) Token: 0x0600105A RID: 4186 RVA: 0x001A37B8 File Offset: 0x001A37B8
		public string Faction
		{
			get
			{
				this;
				this;
				this + 16L;
				(new int[1])[0] = 8;
				return 1;
			}
		}

		// Token: 0x1700055C RID: 1372
		// (get) Token: 0x0600105B RID: 4187 RVA: 0x001A37EC File Offset: 0x001A37EC
		public List<ItemMod> ImplicitMods
		{
			get
			{
				this;
				this;
				return this;
			}
		}

		// Token: 0x0600105C RID: 4188 RVA: 0x001A3814 File Offset: 0x001A3814
		private List<ItemMod> GetMods(long startOffset, long endOffset)
		{
			/*
An exception occurred when decompiling this method (0600105C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.Generic.List`1<ExileCore2.PoEMemory.MemoryObjects.ItemMod> ExileCore2.PoEMemory.MemoryObjects.Expedition.ExpeditionAreaData::GetMods(System.Int64,System.Int64)

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

		// Token: 0x0400806B RID: 32875
		public const int StructSize = 192;

		// Token: 0x0400806C RID: 32876
		private readonly CachedValue<ExpeditionAreaDataOffsets> _cachedValue;
	}
}
