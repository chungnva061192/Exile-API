using System;
using System.Collections.Generic;
using ExileCore2.PoEMemory.Elements.InventoryElements;
using ExileCore2.PoEMemory.FilesInMemory.Ultimatum;
using ExileCore2.Shared.Cache;
using GameOffsets2;

namespace ExileCore2.PoEMemory.Elements
{
	// Token: 0x020002E6 RID: 742
	public class UltimatumPanel : Element
	{
		// Token: 0x060014B7 RID: 5303 RVA: 0x001B0590 File Offset: 0x001B0590
		public UltimatumPanel()
		{
			this;
			this;
			this;
		}

		// Token: 0x17000786 RID: 1926
		// (get) Token: 0x060014B8 RID: 5304 RVA: 0x001B05B4 File Offset: 0x001B05B4
		public UltimatumChoicePanel ChoicesPanel
		{
			get
			{
				/*
An exception occurred when decompiling this method (060014B8)

ICSharpCode.Decompiler.DecompilerException: Error decompiling ExileCore2.PoEMemory.Elements.UltimatumChoicePanel ExileCore2.PoEMemory.Elements.UltimatumPanel::get_ChoicesPanel()

 ---> System.Exception: Inconsistent stack size at IL_14
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

		// Token: 0x17000787 RID: 1927
		// (get) Token: 0x060014B9 RID: 5305 RVA: 0x001B05D8 File Offset: 0x001B05D8
		public Element ConfirmButton
		{
			get
			{
				this;
				int[] array = new int[3];
				array[0] = 2;
				array[1] = 6;
				return array;
			}
		}

		// Token: 0x17000788 RID: 1928
		// (get) Token: 0x060014BA RID: 5306 RVA: 0x001B05F0 File Offset: 0x001B05F0
		public int SelectedChoice
		{
			get
			{
				return this;
			}
		}

		// Token: 0x17000789 RID: 1929
		// (get) Token: 0x060014BB RID: 5307 RVA: 0x001B0604 File Offset: 0x001B0604
		public List<UltimatumModifier> Modifiers
		{
			get
			{
				UltimatumPanel ultimatumPanel = this;
				while ((ultimatumPanel = ultimatumPanel) != null)
				{
				}
				return this;
			}
		}

		// Token: 0x1700078A RID: 1930
		// (get) Token: 0x060014BC RID: 5308 RVA: 0x001B0658 File Offset: 0x001B0658
		public List<UltimatumChoiceElement> ChoicesElements
		{
			get
			{
				return this;
			}
		}

		// Token: 0x1700078B RID: 1931
		// (get) Token: 0x060014BD RID: 5309 RVA: 0x001B0668 File Offset: 0x001B0668
		public Element InventoryElement
		{
			get
			{
				this;
				return new int[3];
			}
		}

		// Token: 0x1700078C RID: 1932
		// (get) Token: 0x060014BE RID: 5310 RVA: 0x001B0684 File Offset: 0x001B0684
		public NormalInventoryItem NextRewardItem
		{
			get
			{
				this;
				return 1;
			}
		}

		// Token: 0x04008267 RID: 33383
		private readonly CachedValue<UltimatumPanelOffsets> _cache;
	}
}
