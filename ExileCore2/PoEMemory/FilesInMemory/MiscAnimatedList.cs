using System;
using System.Collections.Frozen;
using ExileCore2.Shared.Interfaces;

namespace ExileCore2.PoEMemory.FilesInMemory
{
	// Token: 0x02000245 RID: 581
	public class MiscAnimatedList : UniversalFileWrapper<MiscAnimatedDat>
	{
		// Token: 0x06001165 RID: 4453 RVA: 0x001A7018 File Offset: 0x001A7018
		public MiscAnimatedList(IMemory mem, Func<long> address)
		{
			this;
			mem;
			address;
		}

		// Token: 0x06001166 RID: 4454 RVA: 0x001A7024 File Offset: 0x001A7024
		public MiscAnimatedDat GetByAOFile(string aoFile)
		{
			/*
An exception occurred when decompiling this method (06001166)

ICSharpCode.Decompiler.DecompilerException: Error decompiling ExileCore2.PoEMemory.FilesInMemory.MiscAnimatedDat ExileCore2.PoEMemory.FilesInMemory.MiscAnimatedList::GetByAOFile(System.String)

 ---> System.Exception: Inconsistent stack size at IL_0C
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 443
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.Build(MethodDef methodDef, Boolean optimize, DecompilerContext context) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 271
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 112
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
		}

		// Token: 0x06001167 RID: 4455 RVA: 0x001A7058 File Offset: 0x001A7058
		protected override void OnAllEntriesAdded()
		{
			MiscAnimatedList miscAnimatedList = this;
			while ((miscAnimatedList = miscAnimatedList) != null)
			{
			}
			MiscAnimatedList miscAnimatedList2 = this;
			while ((miscAnimatedList2 = miscAnimatedList2) != null)
			{
			}
			MiscAnimatedList miscAnimatedList3 = this;
			while ((miscAnimatedList3 = miscAnimatedList3) != null)
			{
			}
			this;
			null;
		}

		// Token: 0x040080D5 RID: 32981
		private FrozenDictionary<string, MiscAnimatedDat> _entriesByAOFile;
	}
}
