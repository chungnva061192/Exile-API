using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace ExileCore2.Shared.Nodes
{
	// Token: 0x020000FF RID: 255
	public class ContentNode<T> : IContentNodeBase where T : class
	{
		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x060007E2 RID: 2018 RVA: 0x00189E84 File Offset: 0x00189E84
		// (set) Token: 0x060007E3 RID: 2019 RVA: 0x00189E8C File Offset: 0x00189E8C
		public List<T> Content
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

		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x060007E4 RID: 2020 RVA: 0x00189E98 File Offset: 0x00189E98
		// (set) Token: 0x060007E5 RID: 2021 RVA: 0x00189EA0 File Offset: 0x00189EA0
		[JsonIgnore]
		public bool EnableControls
		{
			[CompilerGenerated]
			get
			{
				return this != null;
			}
			[CompilerGenerated]
			set
			{
				this;
				value;
			}
		}

		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x060007E6 RID: 2022 RVA: 0x00189EAC File Offset: 0x00189EAC
		// (set) Token: 0x060007E7 RID: 2023 RVA: 0x00189EB4 File Offset: 0x00189EB4
		[JsonIgnore]
		public bool EnableItemCollapsing
		{
			[CompilerGenerated]
			get
			{
				return this != null;
			}
			[CompilerGenerated]
			set
			{
				this;
				value;
			}
		}

		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x060007E8 RID: 2024 RVA: 0x00189EC0 File Offset: 0x00189EC0
		// (set) Token: 0x060007E9 RID: 2025 RVA: 0x00189EC8 File Offset: 0x00189EC8
		[JsonIgnore]
		public bool UseFlatItems
		{
			[CompilerGenerated]
			get
			{
				return this != null;
			}
			[CompilerGenerated]
			set
			{
				this;
				value;
			}
		}

		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x060007EA RID: 2026 RVA: 0x00189ED4 File Offset: 0x00189ED4
		// (set) Token: 0x060007EB RID: 2027 RVA: 0x00189EDC File Offset: 0x00189EDC
		[JsonIgnore]
		public Func<T> ItemFactory
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

		// Token: 0x060007EC RID: 2028 RVA: 0x00189EE8 File Offset: 0x00189EE8
		public bool Remove(object item)
		{
			/*
An exception occurred when decompiling this method (060007EC)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean ExileCore2.Shared.Nodes.ContentNode`1::Remove(System.Object)

 ---> System.Exception: Inconsistent stack size at IL_13
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 443
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.Build(MethodDef methodDef, Boolean optimize, DecompilerContext context) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 271
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 112
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
		}

		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x060007ED RID: 2029 RVA: 0x00189F3C File Offset: 0x00189F3C
		// (set) Token: 0x060007EE RID: 2030 RVA: 0x00189F44 File Offset: 0x00189F44
		[JsonIgnore]
		public Action<T> OnRemove
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

		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x060007EF RID: 2031 RVA: 0x00189F50 File Offset: 0x00189F50
		[JsonIgnore]
		IEnumerable<object> IContentNodeBase.Content
		{
			get
			{
				return this;
			}
		}

		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x060007F0 RID: 2032 RVA: 0x00189F58 File Offset: 0x00189F58
		[JsonIgnore]
		Action IContentNodeBase.SpawnItem
		{
			get
			{
				/*
An exception occurred when decompiling this method (060007F0)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Action ExileCore2.Shared.Nodes.ContentNode`1::ExileCore2.Shared.Nodes.IContentNodeBase.get_SpawnItem()

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

		// Token: 0x060007F1 RID: 2033 RVA: 0x00189F98 File Offset: 0x00189F98
		public ContentNode()
		{
			this;
			this;
			1;
			this;
			1;
			this;
		}
	}
}
