using System;

namespace ExileCore2.PoEMemory.FilesInMemory
{
	// Token: 0x02000244 RID: 580
	public class MiscAnimatedDat : RemoteMemoryObject
	{
		// Token: 0x170005F8 RID: 1528
		// (get) Token: 0x0600115F RID: 4447 RVA: 0x001A6F68 File Offset: 0x001A6F68
		public string Id
		{
			get
			{
				this;
				this;
				this;
				return 1;
			}
		}

		// Token: 0x170005F9 RID: 1529
		// (get) Token: 0x06001160 RID: 4448 RVA: 0x001A6F8C File Offset: 0x001A6F8C
		public string AOFile
		{
			get
			{
				this;
				this;
				this + 8L;
				return 1;
			}
		}

		// Token: 0x170005FA RID: 1530
		// (get) Token: 0x06001161 RID: 4449 RVA: 0x001A6FB4 File Offset: 0x001A6FB4
		public int BaseSize
		{
			get
			{
				this;
				return this + 36L;
			}
		}

		// Token: 0x170005FB RID: 1531
		// (get) Token: 0x06001162 RID: 4450 RVA: 0x001A6FCC File Offset: 0x001A6FCC
		public uint Hash
		{
			get
			{
				this;
				return this + 40L;
			}
		}

		// Token: 0x06001163 RID: 4451 RVA: 0x001A6FE4 File Offset: 0x001A6FE4
		public override string ToString()
		{
			/*
An exception occurred when decompiling this method (06001163)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String ExileCore2.PoEMemory.FilesInMemory.MiscAnimatedDat::ToString()

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

		// Token: 0x06001164 RID: 4452 RVA: 0x001A700C File Offset: 0x001A700C
		public MiscAnimatedDat()
		{
			this;
		}
	}
}
