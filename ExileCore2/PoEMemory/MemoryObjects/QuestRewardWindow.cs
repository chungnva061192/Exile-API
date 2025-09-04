using System;
using System.Collections.Generic;

namespace ExileCore2.PoEMemory.MemoryObjects
{
	// Token: 0x020001FE RID: 510
	public class QuestRewardWindow : Element
	{
		// Token: 0x06000F54 RID: 3924 RVA: 0x001A1508 File Offset: 0x001A1508
		public IList<ValueTuple<Entity, Element>> GetPossibleRewards()
		{
			/*
An exception occurred when decompiling this method (06000F54)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.Generic.IList`1<System.ValueTuple`2<ExileCore2.PoEMemory.MemoryObjects.Entity,ExileCore2.PoEMemory.Element>> ExileCore2.PoEMemory.MemoryObjects.QuestRewardWindow::GetPossibleRewards()

 ---> System.Exception: Inconsistent stack size at IL_11
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 443
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.Build(MethodDef methodDef, Boolean optimize, DecompilerContext context) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 271
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 112
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
		}

		// Token: 0x170004A7 RID: 1191
		// (get) Token: 0x06000F55 RID: 3925 RVA: 0x001A15D8 File Offset: 0x001A15D8
		public Element CancelButton
		{
			get
			{
				this;
				return 3;
			}
		}

		// Token: 0x170004A8 RID: 1192
		// (get) Token: 0x06000F56 RID: 3926 RVA: 0x001A15E4 File Offset: 0x001A15E4
		public Element SelectOneRewardString
		{
			get
			{
				this;
				return 0;
			}
		}

		// Token: 0x06000F57 RID: 3927 RVA: 0x001A15F0 File Offset: 0x001A15F0
		public QuestRewardWindow()
		{
			this;
		}
	}
}
