using System;
using ExileCore2.PoEMemory.FilesInMemory.Betrayal;

namespace ExileCore2.PoEMemory.MemoryObjects.Betrayal
{
	// Token: 0x0200021A RID: 538
	public class BetrayalChoiceAction : RemoteMemoryObject
	{
		// Token: 0x1700055D RID: 1373
		// (get) Token: 0x0600105E RID: 4190 RVA: 0x001A38A4 File Offset: 0x001A38A4
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

		// Token: 0x1700055E RID: 1374
		// (get) Token: 0x0600105F RID: 4191 RVA: 0x001A38C8 File Offset: 0x001A38C8
		public BetrayalChoice Choice
		{
			get
			{
				this;
				return this + 8L;
			}
		}

		// Token: 0x06001060 RID: 4192 RVA: 0x001A38F4 File Offset: 0x001A38F4
		public override string ToString()
		{
			/*
An exception occurred when decompiling this method (06001060)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String ExileCore2.PoEMemory.MemoryObjects.Betrayal.BetrayalChoiceAction::ToString()

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

		// Token: 0x06001061 RID: 4193 RVA: 0x001A3928 File Offset: 0x001A3928
		public BetrayalChoiceAction()
		{
			this;
		}
	}
}
