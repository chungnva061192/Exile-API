using System;
using System.Collections.Generic;

namespace ExileCore2.PoEMemory.Elements
{
	// Token: 0x020002AE RID: 686
	public class ChallengePanelTabContainer : Element
	{
		// Token: 0x170006E8 RID: 1768
		// (get) Token: 0x06001395 RID: 5013 RVA: 0x001ADD48 File Offset: 0x001ADD48
		public List<ChallengePanelTabContainerTabInfo> TabInfoList
		{
			get
			{
				this;
				this + this;
				return 48;
			}
		}

		// Token: 0x170006E9 RID: 1769
		// (get) Token: 0x06001396 RID: 5014 RVA: 0x001ADD74 File Offset: 0x001ADD74
		public BestiaryTab BestiaryTab
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001396)

ICSharpCode.Decompiler.DecompilerException: Error decompiling ExileCore2.PoEMemory.Elements.BestiaryTab ExileCore2.PoEMemory.Elements.ChallengePanelTabContainer::get_BestiaryTab()

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
		}

		// Token: 0x06001397 RID: 5015 RVA: 0x001ADDD8 File Offset: 0x001ADDD8
		public ChallengePanelTabContainer()
		{
			this;
		}

		// Token: 0x0400821C RID: 33308
		private BestiaryTab _bestiaryTab;
	}
}
