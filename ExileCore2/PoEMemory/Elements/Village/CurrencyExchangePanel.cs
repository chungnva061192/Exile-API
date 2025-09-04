using System;
using System.Collections.Generic;
using ExileCore2.PoEMemory.MemoryObjects;
using ExileCore2.PoEMemory.Models;
using ExileCore2.Shared.Cache;
using GameOffsets2;

namespace ExileCore2.PoEMemory.Elements.Village
{
	// Token: 0x020002EE RID: 750
	public class CurrencyExchangePanel : Element
	{
		// Token: 0x060014D6 RID: 5334 RVA: 0x001B08F4 File Offset: 0x001B08F4
		public CurrencyExchangePanel()
		{
			this;
			this;
			this;
		}

		// Token: 0x17000798 RID: 1944
		// (get) Token: 0x060014D7 RID: 5335 RVA: 0x001B090C File Offset: 0x001B090C
		public BaseItemType OfferedItemType
		{
			get
			{
				return this;
			}
		}

		// Token: 0x17000799 RID: 1945
		// (get) Token: 0x060014D8 RID: 5336 RVA: 0x001B0934 File Offset: 0x001B0934
		public BaseItemType WantedItemType
		{
			get
			{
				return this;
			}
		}

		// Token: 0x1700079A RID: 1946
		// (get) Token: 0x060014D9 RID: 5337 RVA: 0x001B095C File Offset: 0x001B095C
		private List<CurrencyExchangeStock> Stock1
		{
			get
			{
				this;
				return this;
			}
		}

		// Token: 0x1700079B RID: 1947
		// (get) Token: 0x060014DA RID: 5338 RVA: 0x001B0984 File Offset: 0x001B0984
		private List<CurrencyExchangeStock> Stock2
		{
			get
			{
				this;
				return this;
			}
		}

		// Token: 0x1700079C RID: 1948
		// (get) Token: 0x060014DB RID: 5339 RVA: 0x001B09AC File Offset: 0x001B09AC
		public List<CurrencyExchangeStock> WantedItemStock
		{
			get
			{
				/*
An exception occurred when decompiling this method (060014DB)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.Generic.List`1<ExileCore2.PoEMemory.Elements.Village.CurrencyExchangeStock> ExileCore2.PoEMemory.Elements.Village.CurrencyExchangePanel::get_WantedItemStock()

 ---> System.Exception: Inconsistent stack size at IL_0D
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

		// Token: 0x1700079D RID: 1949
		// (get) Token: 0x060014DC RID: 5340 RVA: 0x001B0A0C File Offset: 0x001B0A0C
		public List<CurrencyExchangeStock> OfferedItemStock
		{
			get
			{
				/*
An exception occurred when decompiling this method (060014DC)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.Generic.List`1<ExileCore2.PoEMemory.Elements.Village.CurrencyExchangeStock> ExileCore2.PoEMemory.Elements.Village.CurrencyExchangePanel::get_OfferedItemStock()

 ---> System.Exception: Inconsistent stack size at IL_0D
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

		// Token: 0x1700079E RID: 1950
		// (get) Token: 0x060014DD RID: 5341 RVA: 0x001B0A6C File Offset: 0x001B0A6C
		public short MarketRateGet
		{
			get
			{
				return this;
			}
		}

		// Token: 0x1700079F RID: 1951
		// (get) Token: 0x060014DE RID: 5342 RVA: 0x001B0A80 File Offset: 0x001B0A80
		public short MarketRateGive
		{
			get
			{
				return this;
			}
		}

		// Token: 0x170007A0 RID: 1952
		// (get) Token: 0x060014DF RID: 5343 RVA: 0x001B0A94 File Offset: 0x001B0A94
		public CurrencyExchangeCurrencyPickerElement CurrencyPicker
		{
			get
			{
				this;
				return this;
			}
		}

		// Token: 0x170007A1 RID: 1953
		// (get) Token: 0x060014E0 RID: 5344 RVA: 0x001B0AAC File Offset: 0x001B0AAC
		public List<CurrencyExchangePanelOrderElement> OrderElements
		{
			get
			{
				this;
				return this;
			}
		}

		// Token: 0x170007A2 RID: 1954
		// (get) Token: 0x060014E1 RID: 5345 RVA: 0x001B0ACC File Offset: 0x001B0ACC
		public List<PlacedCurrencyExchangeOrder> Orders
		{
			get
			{
				this;
				this;
				return 88;
			}
		}

		// Token: 0x0400826F RID: 33391
		private readonly CachedValue<CurrencyExchangePanelOffsets> _cache;
	}
}
