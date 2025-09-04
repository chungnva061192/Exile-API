using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Threading;
using ExileCore2.PoEMemory;
using ExileCore2.PoEMemory.MemoryObjects;
using ExileCore2.Shared;
using ExileCore2.Shared.Cache;
using ExileCore2.Shared.Interfaces;

namespace ExileCore2
{
	// Token: 0x02000047 RID: 71
	public class GameController : IDisposable
	{
		// Token: 0x06000262 RID: 610 RVA: 0x00171A90 File Offset: 0x00171A90
		public GameController(Memory memory, SoundController soundController, SettingsContainer settings)
		{
			/*
An exception occurred when decompiling this method (06000262)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void ExileCore2.GameController::.ctor(ExileCore2.Memory,ExileCore2.SoundController,ExileCore2.SettingsContainer)

 ---> System.Exception: Inconsistent stack size at IL_25
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 443
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.Build(MethodDef methodDef, Boolean optimize, DecompilerContext context) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 271
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 112
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x06000263 RID: 611 RVA: 0x00171D58 File Offset: 0x00171D58
		public CancellationToken ControllerCancellation
		{
			get
			{
				return this;
			}
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x06000264 RID: 612 RVA: 0x00171D68 File Offset: 0x00171D68
		public TimeSpan ActivePeriod
		{
			get
			{
				return this;
			}
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x06000265 RID: 613 RVA: 0x00171D78 File Offset: 0x00171D78
		public TheGame Game
		{
			[CompilerGenerated]
			get
			{
				return this;
			}
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x06000266 RID: 614 RVA: 0x00171D80 File Offset: 0x00171D80
		public AreaController Area
		{
			[CompilerGenerated]
			get
			{
				return this;
			}
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x06000267 RID: 615 RVA: 0x00171D88 File Offset: 0x00171D88
		public GameWindow Window
		{
			[CompilerGenerated]
			get
			{
				return this;
			}
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x06000268 RID: 616 RVA: 0x00171D90 File Offset: 0x00171D90
		public IngameState IngameState
		{
			get
			{
				return this;
			}
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x06000269 RID: 617 RVA: 0x00171DA0 File Offset: 0x00171DA0
		public FilesContainer Files
		{
			get
			{
				return this;
			}
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x0600026A RID: 618 RVA: 0x00171DB0 File Offset: 0x00171DB0
		public Entity Player
		{
			get
			{
				return this;
			}
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x0600026B RID: 619 RVA: 0x00171DC0 File Offset: 0x00171DC0
		// (set) Token: 0x0600026C RID: 620 RVA: 0x00171DC8 File Offset: 0x00171DC8
		public bool IsForeGroundCache
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

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x0600026D RID: 621 RVA: 0x00171DD4 File Offset: 0x00171DD4
		// (set) Token: 0x0600026E RID: 622 RVA: 0x00171DDC File Offset: 0x00171DDC
		public bool InGame
		{
			[CompilerGenerated]
			get
			{
				return this != null;
			}
			[CompilerGenerated]
			private set
			{
				this;
				value;
			}
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x0600026F RID: 623 RVA: 0x00171DE8 File Offset: 0x00171DE8
		// (set) Token: 0x06000270 RID: 624 RVA: 0x00171DF0 File Offset: 0x00171DF0
		public bool IsLoading
		{
			[CompilerGenerated]
			get
			{
				return this != null;
			}
			[CompilerGenerated]
			private set
			{
				this;
				value;
			}
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x06000271 RID: 625 RVA: 0x00171DFC File Offset: 0x00171DFC
		public PluginPanel LeftPanel
		{
			[CompilerGenerated]
			get
			{
				return this;
			}
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x06000272 RID: 626 RVA: 0x00171E04 File Offset: 0x00171E04
		public PluginPanel UnderPanel
		{
			[CompilerGenerated]
			get
			{
				return this;
			}
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x06000273 RID: 627 RVA: 0x00171E0C File Offset: 0x00171E0C
		public IMemory Memory
		{
			[CompilerGenerated]
			get
			{
				return this;
			}
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x06000274 RID: 628 RVA: 0x00171E14 File Offset: 0x00171E14
		public SoundController SoundController
		{
			[CompilerGenerated]
			get
			{
				return this;
			}
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x06000275 RID: 629 RVA: 0x00171E1C File Offset: 0x00171E1C
		public SettingsContainer Settings
		{
			[CompilerGenerated]
			get
			{
				return this;
			}
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x06000276 RID: 630 RVA: 0x00171E24 File Offset: 0x00171E24
		public EntityListWrapper EntityListWrapper
		{
			[CompilerGenerated]
			get
			{
				return this;
			}
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x06000277 RID: 631 RVA: 0x00171E2C File Offset: 0x00171E2C
		// (set) Token: 0x06000278 RID: 632 RVA: 0x00171E34 File Offset: 0x00171E34
		public Cache Cache
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

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x06000279 RID: 633 RVA: 0x00171E40 File Offset: 0x00171E40
		public double DeltaTime
		{
			get
			{
				return this;
			}
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x0600027A RID: 634 RVA: 0x00171E50 File Offset: 0x00171E50
		public bool Initialized
		{
			[CompilerGenerated]
			get
			{
				return this != null;
			}
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x0600027B RID: 635 RVA: 0x00171E58 File Offset: 0x00171E58
		public ICollection<Entity> Entities
		{
			get
			{
				return this;
			}
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x0600027C RID: 636 RVA: 0x00171E68 File Offset: 0x00171E68
		public Dictionary<string, object> Debug
		{
			[CompilerGenerated]
			get
			{
				return this;
			}
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x0600027D RID: 637 RVA: 0x00171E70 File Offset: 0x00171E70
		public bool IsUsingController
		{
			get
			{
				return this == 2;
			}
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x0600027E RID: 638 RVA: 0x00171E80 File Offset: 0x00171E80
		public bool IsWaitingForDelayedAreaChange
		{
			get
			{
				return this != null;
			}
		}

		// Token: 0x0600027F RID: 639 RVA: 0x00171E90 File Offset: 0x00171E90
		public void Dispose()
		{
			/*
An exception occurred when decompiling this method (0600027F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void ExileCore2.GameController::Dispose()

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

		// Token: 0x14000006 RID: 6
		// (add) Token: 0x06000280 RID: 640 RVA: 0x00171F30 File Offset: 0x00171F30
		// (remove) Token: 0x06000281 RID: 641 RVA: 0x00171F64 File Offset: 0x00171F64
		public static event Action<bool> eIsForegroundChanged
		{
			[CompilerGenerated]
			add
			{
				/*
An exception occurred when decompiling this method (06000280)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void ExileCore2.GameController::add_eIsForegroundChanged(System.Action`1<System.Boolean>)

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
			[CompilerGenerated]
			remove
			{
				/*
An exception occurred when decompiling this method (06000281)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void ExileCore2.GameController::remove_eIsForegroundChanged(System.Action`1<System.Boolean>)

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

		// Token: 0x06000282 RID: 642 RVA: 0x00171F98 File Offset: 0x00171F98
		public void Tick()
		{
			/*
An exception occurred when decompiling this method (06000282)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void ExileCore2.GameController::Tick()

 ---> System.Exception: Inconsistent stack size at IL_38
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 443
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.Build(MethodDef methodDef, Boolean optimize, DecompilerContext context) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 271
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 112
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
		}

		// Token: 0x06000283 RID: 643 RVA: 0x00172174 File Offset: 0x00172174
		internal void RunBeforeFrameTasks()
		{
			/*
An exception occurred when decompiling this method (06000283)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void ExileCore2.GameController::RunBeforeFrameTasks()

 ---> System.Exception: Inconsistent stack size at IL_04
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 443
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.Build(MethodDef methodDef, Boolean optimize, DecompilerContext context) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 271
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 112
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
		}

		// Token: 0x06000284 RID: 644 RVA: 0x00172458 File Offset: 0x00172458
		private Vector2 GetLeftCornerMap()
		{
			/*
An exception occurred when decompiling this method (06000284)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Numerics.Vector2 ExileCore2.GameController::GetLeftCornerMap()

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

		// Token: 0x06000285 RID: 645 RVA: 0x00172568 File Offset: 0x00172568
		private Vector2 GetUnderCornerMap()
		{
			/*
An exception occurred when decompiling this method (06000285)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Numerics.Vector2 ExileCore2.GameController::GetUnderCornerMap()

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

		// Token: 0x06000286 RID: 646 RVA: 0x00172580 File Offset: 0x00172580
		public void RegisterInspector(Action<object, string> inspectAction)
		{
			this;
			inspectAction;
		}

		// Token: 0x06000287 RID: 647 RVA: 0x0017258C File Offset: 0x0017258C
		public void InspectObject(object obj, string name)
		{
			GameController gameController = this;
			while ((gameController = gameController) != null)
			{
			}
			throw "No inspector registered";
		}

		// Token: 0x06000288 RID: 648 RVA: 0x001725AC File Offset: 0x001725AC
		// Note: this type is marked as 'beforefieldinit'.
		static GameController()
		{
			GameController.<>c.<>9;
		}

		// Token: 0x04000157 RID: 343
		private readonly CoreSettings _settings;

		// Token: 0x04000158 RID: 344
		private readonly DebugInformation debDeltaTime;

		// Token: 0x04000159 RID: 345
		private readonly TimeCache<Vector2> _leftCornerMap;

		// Token: 0x0400015A RID: 346
		private readonly TimeCache<Vector2> _underCornerMap;

		// Token: 0x0400015B RID: 347
		private bool IsForeGroundLast;

		// Token: 0x0400015C RID: 348
		private bool _everWasInGame;

		// Token: 0x0400015D RID: 349
		private bool _wasPreGame;

		// Token: 0x0400015E RID: 350
		public readonly PluginBridge PluginBridge;

		// Token: 0x0400015F RID: 351
		private readonly List<IDisposable> _attachments;

		// Token: 0x04000160 RID: 352
		private Action<object, string> _debugInspector;

		// Token: 0x04000161 RID: 353
		private readonly Stopwatch _sinceCreation;

		// Token: 0x04000162 RID: 354
		private readonly CancellationTokenSource _controllerCancellationTokenSource;

		// Token: 0x04000173 RID: 371
		internal readonly ConcurrentDictionary<string, Action> BeforeFrameActions;

		// Token: 0x04000174 RID: 372
		internal readonly ConcurrentDictionary<string, Func<SyncTask<bool>>> BeforeFrameSyncTasks;

		// Token: 0x04000175 RID: 373
		private readonly ConcurrentDictionary<string, SyncTask<bool>> _activeBeforeFrameSyncTasks;
	}
}
