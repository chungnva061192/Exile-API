using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using ExileCore2.Shared.Enums;
using ExileCore2.Shared.Interfaces;

namespace ExileCore2.PoEMemory
{
	// Token: 0x0200019E RID: 414
	public class Offsets
	{
		// Token: 0x170002CA RID: 714
		// (get) Token: 0x06000BB5 RID: 2997 RVA: 0x00195414 File Offset: 0x00195414
		// (set) Token: 0x06000BB6 RID: 2998 RVA: 0x0019541C File Offset: 0x0019541C
		public long AreaChangeCount
		{
			[CompilerGenerated]
			get
			{
				return this;
			}
			[CompilerGenerated]
			private set
			{
				this;
				value;
			}
		}

		// Token: 0x170002CB RID: 715
		// (get) Token: 0x06000BB7 RID: 2999 RVA: 0x00195428 File Offset: 0x00195428
		// (set) Token: 0x06000BB8 RID: 3000 RVA: 0x00195430 File Offset: 0x00195430
		public long Base
		{
			[CompilerGenerated]
			get
			{
				return this;
			}
			[CompilerGenerated]
			private set
			{
				this;
				value;
			}
		}

		// Token: 0x170002CC RID: 716
		// (get) Token: 0x06000BB9 RID: 3001 RVA: 0x0019543C File Offset: 0x0019543C
		// (set) Token: 0x06000BBA RID: 3002 RVA: 0x00195444 File Offset: 0x00195444
		public string ExeName
		{
			[CompilerGenerated]
			get
			{
				return this;
			}
			[CompilerGenerated]
			private set
			{
				this;
				value;
			}
		}

		// Token: 0x170002CD RID: 717
		// (get) Token: 0x06000BBB RID: 3003 RVA: 0x00195450 File Offset: 0x00195450
		// (set) Token: 0x06000BBC RID: 3004 RVA: 0x00195458 File Offset: 0x00195458
		public long FileRoot
		{
			[CompilerGenerated]
			get
			{
				return this;
			}
			[CompilerGenerated]
			private set
			{
				this;
				value;
			}
		}

		// Token: 0x170002CE RID: 718
		// (get) Token: 0x06000BBD RID: 3005 RVA: 0x00195464 File Offset: 0x00195464
		// (set) Token: 0x06000BBE RID: 3006 RVA: 0x0019546C File Offset: 0x0019546C
		public long GameStateOffset
		{
			[CompilerGenerated]
			get
			{
				return this;
			}
			[CompilerGenerated]
			private set
			{
				this;
				value;
			}
		}

		// Token: 0x170002CF RID: 719
		// (get) Token: 0x06000BBF RID: 3007 RVA: 0x00195478 File Offset: 0x00195478
		// (set) Token: 0x06000BC0 RID: 3008 RVA: 0x00195480 File Offset: 0x00195480
		public long DiagnosticInfoTypeOffset
		{
			[CompilerGenerated]
			get
			{
				return this;
			}
			[CompilerGenerated]
			private set
			{
				this;
				value;
			}
		}

		// Token: 0x06000BC1 RID: 3009 RVA: 0x0019548C File Offset: 0x0019548C
		public Dictionary<OffsetsName, long> DoPatternScans(IMemory m)
		{
			/*
An exception occurred when decompiling this method (06000BC1)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.Generic.Dictionary`2<ExileCore2.Shared.Enums.OffsetsName,System.Int64> ExileCore2.PoEMemory.Offsets::DoPatternScans(ExileCore2.Shared.Interfaces.IMemory)

 ---> System.ArgumentOutOfRangeException: Non-negative number required. (Parameter 'length')
   at System.Array.Copy(Array sourceArray, Int32 sourceIndex, Array destinationArray, Int32 destinationIndex, Int32 length, Boolean reliable)
   at System.Array.Copy(Array sourceArray, Array destinationArray, Int32 length)
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackSlot.ModifyStack(StackSlot[] stack, Int32 popCount, Int32 pushCount, ByteCode pushDefinition) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 48
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 387
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.Build(MethodDef methodDef, Boolean optimize, DecompilerContext context) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 271
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 112
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
		}

		// Token: 0x06000BC2 RID: 3010 RVA: 0x00195734 File Offset: 0x00195734
		public Offsets()
		{
			this;
		}

		// Token: 0x06000BC3 RID: 3011 RVA: 0x00195740 File Offset: 0x00195740
		// Note: this type is marked as 'beforefieldinit'.
		static Offsets()
		{
			/*
An exception occurred when decompiling this method (06000BC3)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void ExileCore2.PoEMemory.Offsets::.cctor()

 ---> System.ArgumentOutOfRangeException: Non-negative number required. (Parameter 'length')
   at System.Array.Copy(Array sourceArray, Int32 sourceIndex, Array destinationArray, Int32 destinationIndex, Int32 length, Boolean reliable)
   at System.Array.Copy(Array sourceArray, Array destinationArray, Int32 length)
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackSlot.ModifyStack(StackSlot[] stack, Int32 popCount, Int32 pushCount, ByteCode pushDefinition) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 48
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 387
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.Build(MethodDef methodDef, Boolean optimize, DecompilerContext context) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 271
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 112
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
		}

		// Token: 0x06000BC4 RID: 3012 RVA: 0x001958A8 File Offset: 0x001958A8
		[CompilerGenerated]
		internal static long <DoPatternScans>g__ReadRelativeAddress|38_2(IPattern pattern, OffsetsName offsetName, ref Offsets.<>c__DisplayClass38_0)
		{
			/*
An exception occurred when decompiling this method (06000BC4)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int64 ExileCore2.PoEMemory.Offsets::<DoPatternScans>g__ReadRelativeAddress|38_2(ExileCore2.Shared.Interfaces.IPattern,ExileCore2.Shared.Enums.OffsetsName,ExileCore2.PoEMemory.Offsets/<>c__DisplayClass38_0&)

 ---> System.Exception: Inconsistent stack size at IL_18
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 443
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.Build(MethodDef methodDef, Boolean optimize, DecompilerContext context) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 271
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 112
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
		}

		// Token: 0x04007E9E RID: 32414
		public static readonly Offsets Regular;

		// Token: 0x04007E9F RID: 32415
		public static readonly Offsets Korean;

		// Token: 0x04007EA0 RID: 32416
		public static readonly Offsets Steam;

		// Token: 0x04007EA1 RID: 32417
		public static readonly Offsets Epic;

		// Token: 0x04007EA2 RID: 32418
		private static readonly Pattern basePtrPattern;

		// Token: 0x04007EA3 RID: 32419
		private static readonly StringPattern FileRootPattern;

		// Token: 0x04007EA4 RID: 32420
		private static readonly StringPattern AreaChangePattern;

		// Token: 0x04007EA5 RID: 32421
		private static readonly Pattern isLoadingScreenPattern;

		// Token: 0x04007EA6 RID: 32422
		private static readonly Pattern GameStatePattern;

		// Token: 0x04007EA7 RID: 32423
		private static readonly StringPattern DiagnosticInfoTypePattern;

		// Token: 0x04007EA8 RID: 32424
		private static readonly StringPattern BlackBarSizePattern;

		// Token: 0x04007EA9 RID: 32425
		private static readonly StringPattern TerrainRotationSelectorPattern;

		// Token: 0x04007EAA RID: 32426
		private static readonly StringPattern TerrainRotationHelperPattern;

		// Token: 0x04007EAB RID: 32427
		private static readonly StringPattern InputModePattern;
	}
}
