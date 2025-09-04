using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using ExileCore2.Shared.Cache;
using ExileCore2.Shared.Interfaces;

namespace ExileCore2.PoEMemory
{
	// Token: 0x02000192 RID: 402
	public abstract class FileInMemory
	{
		// Token: 0x06000AB8 RID: 2744 RVA: 0x00192858 File Offset: 0x00192858
		protected FileInMemory(IMemory m, Func<long> address)
		{
			this;
			this;
			m;
			this;
			address;
			this;
			address;
			this;
			this;
		}

		// Token: 0x17000257 RID: 599
		// (get) Token: 0x06000AB9 RID: 2745 RVA: 0x00192890 File Offset: 0x00192890
		public IMemory M
		{
			[CompilerGenerated]
			get
			{
				return this;
			}
		}

		// Token: 0x17000258 RID: 600
		// (get) Token: 0x06000ABA RID: 2746 RVA: 0x00192898 File Offset: 0x00192898
		// (set) Token: 0x06000ABB RID: 2747 RVA: 0x001928A0 File Offset: 0x001928A0
		public long Address
		{
			[CompilerGenerated]
			get
			{
				return this;
			}
			[CompilerGenerated]
			protected set
			{
				this;
				value;
			}
		}

		// Token: 0x17000259 RID: 601
		// (get) Token: 0x06000ABC RID: 2748 RVA: 0x001928AC File Offset: 0x001928AC
		public string FileName
		{
			get
			{
				this;
				this + 24L;
				return this;
			}
		}

		// Token: 0x1700025A RID: 602
		// (get) Token: 0x06000ABD RID: 2749 RVA: 0x001928D4 File Offset: 0x001928D4
		protected long FirstRecord
		{
			get
			{
				this;
				this + 64L;
				return new int[1];
			}
		}

		// Token: 0x1700025B RID: 603
		// (get) Token: 0x06000ABE RID: 2750 RVA: 0x001928F8 File Offset: 0x001928F8
		protected long LastRecord
		{
			get
			{
				this;
				this + 64L;
				return new int[]
				{
					8
				};
			}
		}

		// Token: 0x1700025C RID: 604
		// (get) Token: 0x06000ABF RID: 2751 RVA: 0x00192920 File Offset: 0x00192920
		protected long FirstArrItem
		{
			get
			{
				this;
				this + 64L;
				return new int[]
				{
					32
				};
			}
		}

		// Token: 0x1700025D RID: 605
		// (get) Token: 0x06000AC0 RID: 2752 RVA: 0x00192948 File Offset: 0x00192948
		protected long LastArrItem
		{
			get
			{
				this;
				this + 64L;
				return new int[]
				{
					40
				};
			}
		}

		// Token: 0x1700025E RID: 606
		// (get) Token: 0x06000AC1 RID: 2753 RVA: 0x00192970 File Offset: 0x00192970
		protected virtual int NumberOfRecords
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000AC1)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 ExileCore2.PoEMemory.FileInMemory::get_NumberOfRecords()

 ---> System.Exception: Inconsistent stack size at IL_06
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

		// Token: 0x1700025F RID: 607
		// (get) Token: 0x06000AC2 RID: 2754 RVA: 0x001929A8 File Offset: 0x001929A8
		protected virtual long RecordLength
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000AC2)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int64 ExileCore2.PoEMemory.FileInMemory::get_RecordLength()

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
		}

		// Token: 0x17000260 RID: 608
		// (get) Token: 0x06000AC3 RID: 2755 RVA: 0x001929E8 File Offset: 0x001929E8
		protected virtual int? ArrayPointerStride
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000AC3)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Nullable`1<System.Int32> ExileCore2.PoEMemory.FileInMemory::get_ArrayPointerStride()

 ---> System.OverflowException: Arithmetic operation resulted in an overflow.
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackSlot.ModifyStack(StackSlot[] stack, Int32 popCount, Int32 pushCount, ByteCode pushDefinition) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 47
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 387
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.Build(MethodDef methodDef, Boolean optimize, DecompilerContext context) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 271
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 112
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
			}
		}

		// Token: 0x06000AC4 RID: 2756 RVA: 0x00192AE8 File Offset: 0x00192AE8
		protected IEnumerable<long> RecordAddresses()
		{
			-2;
			return this;
		}

		// Token: 0x04007E10 RID: 32272
		protected readonly Func<long> FAddress;

		// Token: 0x04007E11 RID: 32273
		protected readonly CachedValue<long> FAddressCache;
	}
}
