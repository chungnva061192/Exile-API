using System;
using System.Runtime.InteropServices;

namespace ExileCore2.PoEMemory.Elements.Village
{
	// Token: 0x020002F0 RID: 752
	public class CurrencyExchangeStock : StructuredRemoteMemoryObject<CurrencyExchangeStock.CurrencyExchangeStockOffsets>
	{
		// Token: 0x170007A4 RID: 1956
		// (get) Token: 0x060014E4 RID: 5348 RVA: 0x001B0B20 File Offset: 0x001B0B20
		public int Get
		{
			get
			{
				return this;
			}
		}

		// Token: 0x170007A5 RID: 1957
		// (get) Token: 0x060014E5 RID: 5349 RVA: 0x001B0B30 File Offset: 0x001B0B30
		public int Give
		{
			get
			{
				return this;
			}
		}

		// Token: 0x170007A6 RID: 1958
		// (get) Token: 0x060014E6 RID: 5350 RVA: 0x001B0B40 File Offset: 0x001B0B40
		public int ListedCount
		{
			get
			{
				return this;
			}
		}

		// Token: 0x060014E7 RID: 5351 RVA: 0x001B0B50 File Offset: 0x001B0B50
		public override string ToString()
		{
			/*
An exception occurred when decompiling this method (060014E7)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String ExileCore2.PoEMemory.Elements.Village.CurrencyExchangeStock::ToString()

 ---> System.Exception: Inconsistent stack size at IL_16
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 443
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.Build(MethodDef methodDef, Boolean optimize, DecompilerContext context) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 271
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 112
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
		}

		// Token: 0x060014E8 RID: 5352 RVA: 0x001B0BB8 File Offset: 0x001B0BB8
		public CurrencyExchangeStock()
		{
			this;
		}

		// Token: 0x020002F1 RID: 753
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		public struct CurrencyExchangeStockOffsets
		{
			// Token: 0x04008271 RID: 33393
			[FieldOffset(0)]
			public ushort Get;

			// Token: 0x04008272 RID: 33394
			[FieldOffset(2)]
			public ushort Give;

			// Token: 0x04008273 RID: 33395
			[FieldOffset(8)]
			public int ListedCount;
		}
	}
}
