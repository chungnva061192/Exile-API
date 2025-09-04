using System;
using System.Runtime.CompilerServices;
using ExileCore2.Shared.Cache;
using GameOffsets2;

namespace ExileCore2.PoEMemory.Elements.Sanctum
{
	// Token: 0x020002F6 RID: 758
	public class SanctumFloorWindowDataSelector : RemoteMemoryObject
	{
		// Token: 0x170007B3 RID: 1971
		// (get) Token: 0x06001500 RID: 5376 RVA: 0x001B0EC4 File Offset: 0x001B0EC4
		// (set) Token: 0x06001501 RID: 5377 RVA: 0x001B0ECC File Offset: 0x001B0ECC
		public bool IsOutsidePtr
		{
			[CompilerGenerated]
			get
			{
				return this != null;
			}
			[CompilerGenerated]
			set
			{
				this;
				value;
			}
		}

		// Token: 0x06001502 RID: 5378 RVA: 0x001B0ED8 File Offset: 0x001B0ED8
		public SanctumFloorWindowDataSelector()
		{
			this;
			this;
			this;
		}

		// Token: 0x170007B4 RID: 1972
		// (get) Token: 0x06001503 RID: 5379 RVA: 0x001B0EF0 File Offset: 0x001B0EF0
		public SanctumFloorData FloorData
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001503)

ICSharpCode.Decompiler.DecompilerException: Error decompiling ExileCore2.PoEMemory.Elements.Sanctum.SanctumFloorData ExileCore2.PoEMemory.Elements.Sanctum.SanctumFloorWindowDataSelector::get_FloorData()

 ---> System.Exception: Inconsistent stack size at IL_13
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

		// Token: 0x170007B5 RID: 1973
		// (get) Token: 0x06001504 RID: 5380 RVA: 0x001B0F60 File Offset: 0x001B0F60
		public int Gold
		{
			get
			{
				return this;
			}
		}

		// Token: 0x170007B6 RID: 1974
		// (get) Token: 0x06001505 RID: 5381 RVA: 0x001B0F74 File Offset: 0x001B0F74
		public int CurrentResolve
		{
			get
			{
				return this;
			}
		}

		// Token: 0x170007B7 RID: 1975
		// (get) Token: 0x06001506 RID: 5382 RVA: 0x001B0F88 File Offset: 0x001B0F88
		public int MaxResolve
		{
			get
			{
				return this;
			}
		}

		// Token: 0x170007B8 RID: 1976
		// (get) Token: 0x06001507 RID: 5383 RVA: 0x001B0F9C File Offset: 0x001B0F9C
		public int Inspiration
		{
			get
			{
				return this;
			}
		}

		// Token: 0x0400827A RID: 33402
		private readonly CachedValue<SanctumFloorWindowDataOffsets> _cachedValue;
	}
}
