using System;

namespace ExileCore2.PoEMemory.FilesInMemory
{
	// Token: 0x02000225 RID: 549
	public class AtlasPrimordialAltarChoice : RemoteMemoryObject
	{
		// Token: 0x170005AD RID: 1453
		// (get) Token: 0x060010CC RID: 4300 RVA: 0x001A4EA0 File Offset: 0x001A4EA0
		public ModsDat.ModRecord Mod
		{
			get
			{
				this;
				return this;
			}
		}

		// Token: 0x170005AE RID: 1454
		// (get) Token: 0x060010CD RID: 4301 RVA: 0x001A4EC8 File Offset: 0x001A4EC8
		public AtlasPrimordialAltarChoiceType Type
		{
			get
			{
				this;
				return this + 16L;
			}
		}

		// Token: 0x060010CE RID: 4302 RVA: 0x001A4EF4 File Offset: 0x001A4EF4
		public override string ToString()
		{
			/*
An exception occurred when decompiling this method (060010CE)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String ExileCore2.PoEMemory.FilesInMemory.AtlasPrimordialAltarChoice::ToString()

 ---> System.Exception: Inconsistent stack size at IL_0E
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 443
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.Build(MethodDef methodDef, Boolean optimize, DecompilerContext context) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 271
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 112
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
		}

		// Token: 0x060010CF RID: 4303 RVA: 0x001A4F40 File Offset: 0x001A4F40
		public AtlasPrimordialAltarChoice()
		{
			this;
		}
	}
}
