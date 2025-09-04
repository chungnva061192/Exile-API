using System;
using System.Runtime.CompilerServices;

namespace ExileCore2.PoEMemory.MemoryObjects
{
	// Token: 0x020001F5 RID: 501
	public class MapSubInventoryInfo
	{
		// Token: 0x17000472 RID: 1138
		// (get) Token: 0x06000EF8 RID: 3832 RVA: 0x001A0434 File Offset: 0x001A0434
		// (set) Token: 0x06000EF9 RID: 3833 RVA: 0x001A043C File Offset: 0x001A043C
		public int Tier
		{
			[CompilerGenerated]
			get
			{
				return this;
			}
			[CompilerGenerated]
			set
			{
				this;
				value;
			}
		}

		// Token: 0x17000473 RID: 1139
		// (get) Token: 0x06000EFA RID: 3834 RVA: 0x001A0448 File Offset: 0x001A0448
		// (set) Token: 0x06000EFB RID: 3835 RVA: 0x001A0450 File Offset: 0x001A0450
		public int Count
		{
			[CompilerGenerated]
			get
			{
				return this;
			}
			[CompilerGenerated]
			set
			{
				this;
				value;
			}
		}

		// Token: 0x17000474 RID: 1140
		// (get) Token: 0x06000EFC RID: 3836 RVA: 0x001A045C File Offset: 0x001A045C
		// (set) Token: 0x06000EFD RID: 3837 RVA: 0x001A0464 File Offset: 0x001A0464
		public string MapName
		{
			[CompilerGenerated]
			get
			{
				return this;
			}
			[CompilerGenerated]
			set
			{
				this;
				value;
			}
		}

		// Token: 0x06000EFE RID: 3838 RVA: 0x001A0470 File Offset: 0x001A0470
		public override string ToString()
		{
			/*
An exception occurred when decompiling this method (06000EFE)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String ExileCore2.PoEMemory.MemoryObjects.MapSubInventoryInfo::ToString()

 ---> System.Exception: Inconsistent stack size at IL_1D
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 443
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.Build(MethodDef methodDef, Boolean optimize, DecompilerContext context) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 271
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 112
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
		}

		// Token: 0x06000EFF RID: 3839 RVA: 0x001A04E4 File Offset: 0x001A04E4
		public MapSubInventoryInfo()
		{
			this;
		}
	}
}
