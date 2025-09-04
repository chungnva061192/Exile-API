using System;
using System.Collections.Generic;
using ExileCore2.Shared.Interfaces;

namespace ExileCore2.PoEMemory.FilesInMemory.Village
{
	// Token: 0x02000288 RID: 648
	public class VillageJobs : UniversalFileWrapper<VillageJob>
	{
		// Token: 0x060012E1 RID: 4833 RVA: 0x001ABF70 File Offset: 0x001ABF70
		public VillageJobs(IMemory mem, Func<long> address)
		{
			this;
			this;
			mem;
			address;
		}

		// Token: 0x060012E2 RID: 4834 RVA: 0x001ABF88 File Offset: 0x001ABF88
		protected override void EntryAdded(long addr, VillageJob entry)
		{
			this;
			entry;
			entry;
		}

		// Token: 0x060012E3 RID: 4835 RVA: 0x001ABFA0 File Offset: 0x001ABFA0
		protected override void OnReload()
		{
			this;
		}

		// Token: 0x060012E4 RID: 4836 RVA: 0x001ABFB0 File Offset: 0x001ABFB0
		public VillageJob GetByName(string name)
		{
			/*
An exception occurred when decompiling this method (060012E4)

ICSharpCode.Decompiler.DecompilerException: Error decompiling ExileCore2.PoEMemory.FilesInMemory.Village.VillageJob ExileCore2.PoEMemory.FilesInMemory.Village.VillageJobs::GetByName(System.String)

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

		// Token: 0x040081D7 RID: 33239
		private readonly Dictionary<string, VillageJob> _byName;
	}
}
