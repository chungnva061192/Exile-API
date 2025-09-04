using System;
using System.Collections.Generic;
using ExileCore2.PoEMemory.MemoryObjects;

namespace ExileCore2.PoEMemory.FilesInMemory.Atlas
{
	// Token: 0x020002A1 RID: 673
	public class EndgameMap : RemoteMemoryObject
	{
		// Token: 0x170006C9 RID: 1737
		// (get) Token: 0x06001356 RID: 4950 RVA: 0x001AD3EC File Offset: 0x001AD3EC
		public List<EndgameMapBiome> Biomes
		{
			get
			{
				this;
				List<EndgameMapBiome> result = this + 4L;
				EndgameMap endgameMap = this;
				while ((endgameMap = endgameMap) != null)
				{
				}
				return result;
			}
		}

		// Token: 0x170006CA RID: 1738
		// (get) Token: 0x06001357 RID: 4951 RVA: 0x001AD444 File Offset: 0x001AD444
		public WorldArea Area
		{
			get
			{
				this;
				return this + 52L;
			}
		}

		// Token: 0x06001358 RID: 4952 RVA: 0x001AD470 File Offset: 0x001AD470
		public override string ToString()
		{
			/*
An exception occurred when decompiling this method (06001358)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String ExileCore2.PoEMemory.FilesInMemory.Atlas.EndgameMap::ToString()

 ---> System.Exception: Inconsistent stack size at IL_06
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 443
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.Build(MethodDef methodDef, Boolean optimize, DecompilerContext context) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 271
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 112
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
		}

		// Token: 0x06001359 RID: 4953 RVA: 0x001AD4A0 File Offset: 0x001AD4A0
		public EndgameMap()
		{
			this;
		}
	}
}
