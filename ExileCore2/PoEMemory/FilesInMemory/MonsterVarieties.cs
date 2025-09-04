using System;
using System.Collections.Generic;
using ExileCore2.PoEMemory.MemoryObjects;
using ExileCore2.Shared.Interfaces;

namespace ExileCore2.PoEMemory.FilesInMemory
{
	// Token: 0x0200024E RID: 590
	public class MonsterVarieties : UniversalFileWrapper<MonsterVariety>
	{
		// Token: 0x0600119A RID: 4506 RVA: 0x001A7A0C File Offset: 0x001A7A0C
		public MonsterVarieties(IMemory m, Func<long> address)
		{
			this;
			this;
			m;
			address;
		}

		// Token: 0x17000612 RID: 1554
		// (get) Token: 0x0600119B RID: 4507 RVA: 0x001A7A24 File Offset: 0x001A7A24
		public new IList<MonsterVariety> EntriesList
		{
			get
			{
				return this;
			}
		}

		// Token: 0x0600119C RID: 4508 RVA: 0x001A7A34 File Offset: 0x001A7A34
		public MonsterVariety TranslateFromMetadata(string path)
		{
			/*
An exception occurred when decompiling this method (0600119C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling ExileCore2.PoEMemory.MemoryObjects.MonsterVariety ExileCore2.PoEMemory.FilesInMemory.MonsterVarieties::TranslateFromMetadata(System.String)

 ---> System.Exception: Inconsistent stack size at IL_08
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 443
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.Build(MethodDef methodDef, Boolean optimize, DecompilerContext context) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 271
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 112
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
		}

		// Token: 0x0600119D RID: 4509 RVA: 0x001A7A60 File Offset: 0x001A7A60
		protected override void EntryAdded(long addr, MonsterVariety entry)
		{
			this;
			entry;
			entry;
		}

		// Token: 0x040080FE RID: 33022
		private readonly Dictionary<string, MonsterVariety> MonsterVarietyMetadataDictionary;
	}
}
