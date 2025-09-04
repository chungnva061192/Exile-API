using System;
using System.Collections.Generic;

namespace ExileCore2.PoEMemory.FilesInMemory
{
	// Token: 0x02000236 RID: 566
	public class GroundEffectDat : RemoteMemoryObject
	{
		// Token: 0x170005E1 RID: 1505
		// (get) Token: 0x06001127 RID: 4391 RVA: 0x001A647C File Offset: 0x001A647C
		public GroundEffectTypeDat Type
		{
			get
			{
				this;
				return this;
			}
		}

		// Token: 0x170005E2 RID: 1506
		// (get) Token: 0x06001128 RID: 4392 RVA: 0x001A64A4 File Offset: 0x001A64A4
		public BuffVisual BuffVisual
		{
			get
			{
				this;
				return this + 24L;
			}
		}

		// Token: 0x170005E3 RID: 1507
		// (get) Token: 0x06001129 RID: 4393 RVA: 0x001A64D0 File Offset: 0x001A64D0
		public List<string> AOFiles
		{
			get
			{
				this;
				this + 61L;
				this;
				8;
				return this;
			}
		}

		// Token: 0x170005E4 RID: 1508
		// (get) Token: 0x0600112A RID: 4394 RVA: 0x001A650C File Offset: 0x001A650C
		public float BaseSize
		{
			get
			{
				this;
				return this + 40L;
			}
		}

		// Token: 0x0600112B RID: 4395 RVA: 0x001A6524 File Offset: 0x001A6524
		public override string ToString()
		{
			/*
An exception occurred when decompiling this method (0600112B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String ExileCore2.PoEMemory.FilesInMemory.GroundEffectDat::ToString()

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

		// Token: 0x0600112C RID: 4396 RVA: 0x001A657C File Offset: 0x001A657C
		public GroundEffectDat()
		{
			this;
		}
	}
}
