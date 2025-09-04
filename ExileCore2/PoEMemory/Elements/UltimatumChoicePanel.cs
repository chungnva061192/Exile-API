using System;
using System.Collections.Generic;
using ExileCore2.PoEMemory.FilesInMemory.Ultimatum;
using ExileCore2.Shared.Cache;
using GameOffsets2;

namespace ExileCore2.PoEMemory.Elements
{
	// Token: 0x020002E8 RID: 744
	public class UltimatumChoicePanel : Element
	{
		// Token: 0x060014C3 RID: 5315 RVA: 0x001B06DC File Offset: 0x001B06DC
		public UltimatumChoicePanel()
		{
			this;
			this;
			this;
		}

		// Token: 0x1700078D RID: 1933
		// (get) Token: 0x060014C4 RID: 5316 RVA: 0x001B06F4 File Offset: 0x001B06F4
		public List<UltimatumModifier> Modifiers
		{
			get
			{
				UltimatumChoicePanel ultimatumChoicePanel = this;
				while ((ultimatumChoicePanel = ultimatumChoicePanel) != null)
				{
				}
				return this;
			}
		}

		// Token: 0x1700078E RID: 1934
		// (get) Token: 0x060014C5 RID: 5317 RVA: 0x001B0748 File Offset: 0x001B0748
		public List<UltimatumChoiceElement> ChoiceElements
		{
			get
			{
				/*
An exception occurred when decompiling this method (060014C5)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.Generic.List`1<ExileCore2.PoEMemory.Elements.UltimatumChoiceElement> ExileCore2.PoEMemory.Elements.UltimatumChoicePanel::get_ChoiceElements()

 ---> System.Exception: Inconsistent stack size at IL_07
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 443
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.Build(MethodDef methodDef, Boolean optimize, DecompilerContext context) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 271
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 112
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
			}
		}

		// Token: 0x1700078F RID: 1935
		// (get) Token: 0x060014C6 RID: 5318 RVA: 0x001B0768 File Offset: 0x001B0768
		public int SelectedChoice
		{
			get
			{
				return this;
			}
		}

		// Token: 0x0400826A RID: 33386
		private readonly CachedValue<UltimatumPanelOffsets> _cache;
	}
}
