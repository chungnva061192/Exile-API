using System;
using System.Runtime.CompilerServices;
using ExileCore2.Shared.Attributes;
using ExileCore2.Shared.Interfaces;
using ExileCore2.Shared.Nodes;
using Newtonsoft.Json;

namespace ExileCore2
{
	// Token: 0x0200002A RID: 42
	public class CoreSettings : ISettings
	{
		// Token: 0x1700005D RID: 93
		// (get) Token: 0x06000146 RID: 326 RVA: 0x0016E274 File Offset: 0x0016E274
		// (set) Token: 0x06000147 RID: 327 RVA: 0x0016E27C File Offset: 0x0016E27C
		[Menu("Refresh area")]
		[JsonIgnore]
		public ButtonNode RefreshArea
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

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x06000148 RID: 328 RVA: 0x0016E288 File Offset: 0x0016E288
		// (set) Token: 0x06000149 RID: 329 RVA: 0x0016E290 File Offset: 0x0016E290
		[JsonIgnore]
		public ButtonNode ReloadFiles
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

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x0600014A RID: 330 RVA: 0x0016E29C File Offset: 0x0016E29C
		// (set) Token: 0x0600014B RID: 331 RVA: 0x0016E2A4 File Offset: 0x0016E2A4
		[JsonIgnore]
		public ButtonNode ClearEntityCache
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

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x0600014C RID: 332 RVA: 0x0016E2B0 File Offset: 0x0016E2B0
		// (set) Token: 0x0600014D RID: 333 RVA: 0x0016E2B8 File Offset: 0x0016E2B8
		[Menu(null, "Uses more memory, should be faster")]
		public ToggleNode UseNewMemoryBackend
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

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x0600014E RID: 334 RVA: 0x0016E2C4 File Offset: 0x0016E2C4
		// (set) Token: 0x0600014F RID: 335 RVA: 0x0016E2CC File Offset: 0x0016E2CC
		[Menu("List profiles", "Currently not works. Soon.")]
		public ListNode Profiles
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

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x06000150 RID: 336 RVA: 0x0016E2D8 File Offset: 0x0016E2D8
		// (set) Token: 0x06000151 RID: 337 RVA: 0x0016E2E0 File Offset: 0x0016E2E0
		[Menu("Current Menu Theme")]
		public ListNode Theme
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

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x06000152 RID: 338 RVA: 0x0016E2EC File Offset: 0x0016E2EC
		// (set) Token: 0x06000153 RID: 339 RVA: 0x0016E2F4 File Offset: 0x0016E2F4
		public HotkeyNodeV2 MainMenuKeyToggle
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

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x06000154 RID: 340 RVA: 0x0016E300 File Offset: 0x0016E300
		// (set) Token: 0x06000155 RID: 341 RVA: 0x0016E308 File Offset: 0x0016E308
		public HotkeyNodeV2 PauseAllPluginsHotkey
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

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x06000156 RID: 342 RVA: 0x0016E314 File Offset: 0x0016E314
		// (set) Token: 0x06000157 RID: 343 RVA: 0x0016E31C File Offset: 0x0016E31C
		public CorePluginSettings PluginSettings
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

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x06000158 RID: 344 RVA: 0x0016E328 File Offset: 0x0016E328
		// (set) Token: 0x06000159 RID: 345 RVA: 0x0016E330 File Offset: 0x0016E330
		public CorePerformanceSettings PerformanceSettings
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

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x0600015A RID: 346 RVA: 0x0016E33C File Offset: 0x0016E33C
		// (set) Token: 0x0600015B RID: 347 RVA: 0x0016E344 File Offset: 0x0016E344
		public ToggleNode AttachToMainProcessWindow
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

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x0600015C RID: 348 RVA: 0x0016E350 File Offset: 0x0016E350
		// (set) Token: 0x0600015D RID: 349 RVA: 0x0016E358 File Offset: 0x0016E358
		public ToggleNode TryLoadingStatDescriptionsFromGameData
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

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x0600015E RID: 350 RVA: 0x0016E364 File Offset: 0x0016E364
		// (set) Token: 0x0600015F RID: 351 RVA: 0x0016E36C File Offset: 0x0016E36C
		public ToggleNode RepairInvalidGameAddress
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

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x06000160 RID: 352 RVA: 0x0016E378 File Offset: 0x0016E378
		// (set) Token: 0x06000161 RID: 353 RVA: 0x0016E380 File Offset: 0x0016E380
		public RangeNode<float> AreaRefreshDelay
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

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x06000162 RID: 354 RVA: 0x0016E38C File Offset: 0x0016E38C
		// (set) Token: 0x06000163 RID: 355 RVA: 0x0016E394 File Offset: 0x0016E394
		public ToggleNode CacheEntitiesBetweenZones
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

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x06000164 RID: 356 RVA: 0x0016E3A0 File Offset: 0x0016E3A0
		// (set) Token: 0x06000165 RID: 357 RVA: 0x0016E3A8 File Offset: 0x0016E3A8
		public RangeNode<float> GlobalEntityCacheExpirationMinutes
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

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x06000166 RID: 358 RVA: 0x0016E3B4 File Offset: 0x0016E3B4
		// (set) Token: 0x06000167 RID: 359 RVA: 0x0016E3BC File Offset: 0x0016E3BC
		public ToggleNode UseOldStyleListNode
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

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x06000168 RID: 360 RVA: 0x0016E3C8 File Offset: 0x0016E3C8
		// (set) Token: 0x06000169 RID: 361 RVA: 0x0016E3D0 File Offset: 0x0016E3D0
		[Menu("Enable VSync")]
		public ToggleNode EnableVSync
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

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x0600016A RID: 362 RVA: 0x0016E3DC File Offset: 0x0016E3DC
		// (set) Token: 0x0600016B RID: 363 RVA: 0x0016E3E4 File Offset: 0x0016E3E4
		public CoreFontSettings FontSettings
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

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x0600016C RID: 364 RVA: 0x0016E3F0 File Offset: 0x0016E3F0
		// (set) Token: 0x0600016D RID: 365 RVA: 0x0016E3F8 File Offset: 0x0016E3F8
		[Menu(null, "If you use a large custom cursor, this can help see tooltips better")]
		public RangeNode<float> MouseCursorScale
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

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x0600016E RID: 366 RVA: 0x0016E404 File Offset: 0x0016E404
		// (set) Token: 0x0600016F RID: 367 RVA: 0x0016E40C File Offset: 0x0016E40C
		public RangeNode<int> Volume
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

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x06000170 RID: 368 RVA: 0x0016E418 File Offset: 0x0016E418
		// (set) Token: 0x06000171 RID: 369 RVA: 0x0016E420 File Offset: 0x0016E420
		public ToggleNode ShowDebugWindow
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

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x06000172 RID: 370 RVA: 0x0016E42C File Offset: 0x0016E42C
		// (set) Token: 0x06000173 RID: 371 RVA: 0x0016E434 File Offset: 0x0016E434
		public ToggleNode ShowLogWindow
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

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x06000174 RID: 372 RVA: 0x0016E440 File Offset: 0x0016E440
		// (set) Token: 0x06000175 RID: 373 RVA: 0x0016E448 File Offset: 0x0016E448
		public CoreLoggingSettings LoggingSettings
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

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x06000176 RID: 374 RVA: 0x0016E454 File Offset: 0x0016E454
		// (set) Token: 0x06000177 RID: 375 RVA: 0x0016E45C File Offset: 0x0016E45C
		public CoreDebugSettings DebugSettings
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

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x06000178 RID: 376 RVA: 0x0016E468 File Offset: 0x0016E468
		// (set) Token: 0x06000179 RID: 377 RVA: 0x0016E470 File Offset: 0x0016E470
		public ToggleNode Enable
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

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x0600017A RID: 378 RVA: 0x0016E47C File Offset: 0x0016E47C
		// (set) Token: 0x0600017B RID: 379 RVA: 0x0016E484 File Offset: 0x0016E484
		public ToggleNode ForceForeground
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

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x0600017C RID: 380 RVA: 0x0016E490 File Offset: 0x0016E490
		// (set) Token: 0x0600017D RID: 381 RVA: 0x0016E498 File Offset: 0x0016E498
		[Menu(null, "Set to 0 to disable")]
		public RangeNode<int> FileReloadPeriod
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

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x0600017E RID: 382 RVA: 0x0016E4A4 File Offset: 0x0016E4A4
		// (set) Token: 0x0600017F RID: 383 RVA: 0x0016E4AC File Offset: 0x0016E4AC
		[Menu(null, "If you have a widescreen display and use some sort of a hack to force poe to render without black bars, you might need this")]
		public ToggleNode DisableBlackBarAdjustment
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

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x06000180 RID: 384 RVA: 0x0016E4B8 File Offset: 0x0016E4B8
		// (set) Token: 0x06000181 RID: 385 RVA: 0x0016E4C0 File Offset: 0x0016E4C0
		[JsonIgnore]
		public ButtonNode ReloadPlugins
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

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x06000182 RID: 386 RVA: 0x0016E4CC File Offset: 0x0016E4CC
		// (set) Token: 0x06000183 RID: 387 RVA: 0x0016E4D4 File Offset: 0x0016E4D4
		[JsonIgnore]
		[ConditionalDisplay("IsRunningAsAdmin", false)]
		public ButtonNode RestartAsAdmin
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

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x06000184 RID: 388 RVA: 0x0016E4E0 File Offset: 0x0016E4E0
		// (set) Token: 0x06000185 RID: 389 RVA: 0x0016E4E8 File Offset: 0x0016E4E8
		public SnapshotSettings SnapshotSettings
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

		// Token: 0x06000186 RID: 390 RVA: 0x0016E4F4 File Offset: 0x0016E4F4
		public bool IsRunningAsAdmin()
		{
			/*
An exception occurred when decompiling this method (06000186)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean ExileCore2.CoreSettings::IsRunningAsAdmin()

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

		// Token: 0x06000187 RID: 391 RVA: 0x0016E50C File Offset: 0x0016E50C
		public CoreSettings()
		{
			/*
An exception occurred when decompiling this method (06000187)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void ExileCore2.CoreSettings::.ctor()

 ---> System.Exception: Unknown OpCode: Stloc_0
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformByteCode(ILExpression byteCode) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 1101
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformExpression(ILExpression expr) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 414
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformNode(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 270
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformBlock(ILBlock block) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 254
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 151
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
		}

		// Token: 0x040000E4 RID: 228
		public int IconPickerIconsPerRow;

		// Token: 0x040000E5 RID: 229
		public int IconPickerIconSize;
	}
}
