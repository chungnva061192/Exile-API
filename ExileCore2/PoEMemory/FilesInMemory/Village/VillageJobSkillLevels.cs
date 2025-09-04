using System;
using System.Collections.Generic;
using ExileCore2.Shared.Interfaces;

namespace ExileCore2.PoEMemory.FilesInMemory.Village
{
	// Token: 0x0200028C RID: 652
	public class VillageJobSkillLevels : UniversalFileWrapper<VillageJobSkillLevel>
	{
		// Token: 0x060012F2 RID: 4850 RVA: 0x001AC28C File Offset: 0x001AC28C
		public VillageJobSkillLevels(IMemory mem, Func<long> address)
		{
			this;
			this;
			mem;
			address;
		}

		// Token: 0x060012F3 RID: 4851 RVA: 0x001AC2A4 File Offset: 0x001AC2A4
		protected override void EntryAdded(long addr, VillageJobSkillLevel entry)
		{
			this;
			entry;
			entry;
		}

		// Token: 0x060012F4 RID: 4852 RVA: 0x001AC2BC File Offset: 0x001AC2BC
		public VillageJobSkillLevel GetByLevel(int level)
		{
			/*
An exception occurred when decompiling this method (060012F4)

ICSharpCode.Decompiler.DecompilerException: Error decompiling ExileCore2.PoEMemory.FilesInMemory.Village.VillageJobSkillLevel ExileCore2.PoEMemory.FilesInMemory.Village.VillageJobSkillLevels::GetByLevel(System.Int32)

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

		// Token: 0x060012F5 RID: 4853 RVA: 0x001AC2E4 File Offset: 0x001AC2E4
		protected override void OnReload()
		{
			this;
		}

		// Token: 0x040081E0 RID: 33248
		private readonly Dictionary<int, VillageJobSkillLevel> _bySkillLevel;
	}
}
