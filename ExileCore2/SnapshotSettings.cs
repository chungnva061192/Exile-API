using System;
using System.Runtime.CompilerServices;
using ExileCore2.Shared.Attributes;
using ExileCore2.Shared.Nodes;
using Newtonsoft.Json;

namespace ExileCore2
{
	// Token: 0x020000A5 RID: 165
	[Submenu(CollapsedByDefault = true)]
	public class SnapshotSettings
	{
		// Token: 0x17000101 RID: 257
		// (get) Token: 0x060004CE RID: 1230 RVA: 0x0017E348 File Offset: 0x0017E348
		// (set) Token: 0x060004CF RID: 1231 RVA: 0x0017E350 File Offset: 0x0017E350
		[JsonIgnore]
		public ButtonNode TakeSnapshot
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

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x060004D0 RID: 1232 RVA: 0x0017E35C File Offset: 0x0017E35C
		// (set) Token: 0x060004D1 RID: 1233 RVA: 0x0017E364 File Offset: 0x0017E364
		[JsonIgnore]
		public ButtonNode ClearSnapshots
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

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x060004D2 RID: 1234 RVA: 0x0017E370 File Offset: 0x0017E370
		// (set) Token: 0x060004D3 RID: 1235 RVA: 0x0017E378 File Offset: 0x0017E378
		public HotkeyNodeV2 TakeSnapshotHotkey
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

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x060004D4 RID: 1236 RVA: 0x0017E384 File Offset: 0x0017E384
		// (set) Token: 0x060004D5 RID: 1237 RVA: 0x0017E38C File Offset: 0x0017E38C
		public ToggleNode FreezeProcessDuringSnapshot
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

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x060004D6 RID: 1238 RVA: 0x0017E398 File Offset: 0x0017E398
		// (set) Token: 0x060004D7 RID: 1239 RVA: 0x0017E3A0 File Offset: 0x0017E3A0
		[JsonIgnore]
		public SnapshotSettings.RenderList SnapshotList
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

		// Token: 0x060004D8 RID: 1240 RVA: 0x0017E3AC File Offset: 0x0017E3AC
		public SnapshotSettings()
		{
			this;
			this;
			this;
			0;
			this;
			0;
			this;
			this;
		}

		// Token: 0x020000A6 RID: 166
		[Submenu(RenderMethod = "Render")]
		public class RenderList
		{
			// Token: 0x060004D9 RID: 1241 RVA: 0x0017E3FC File Offset: 0x0017E3FC
			public void Render()
			{
				/*
An exception occurred when decompiling this method (060004D9)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void ExileCore2.SnapshotSettings/RenderList::Render()

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

			// Token: 0x060004DA RID: 1242 RVA: 0x0017E6C8 File Offset: 0x0017E6C8
			public RenderList()
			{
				this;
			}
		}
	}
}
