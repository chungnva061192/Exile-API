using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using ExileCore2.Shared.Attributes;
using ExileCore2.Shared.Nodes;
using Newtonsoft.Json;
using Serilog.Events;

namespace ExileCore2
{
	// Token: 0x0200001F RID: 31
	[Submenu]
	public class CorePluginSettings
	{
		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060000F5 RID: 245 RVA: 0x0016D6E4 File Offset: 0x0016D6E4
		// (set) Token: 0x060000F6 RID: 246 RVA: 0x0016D6EC File Offset: 0x0016D6EC
		[Menu("Load source plugins in parallel", "Requires restart to apply. When you use a lot of plugins this option can improve the load time.")]
		public ToggleNode MultiThreadLoadPlugins
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

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060000F7 RID: 247 RVA: 0x0016D6F8 File Offset: 0x0016D6F8
		// (set) Token: 0x060000F8 RID: 248 RVA: 0x0016D700 File Offset: 0x0016D700
		[Menu("Avoid locking plugin dlls", "Requires restart to apply. Only enable this if you need to do live dll replacement without restarting.")]
		public ToggleNode AvoidLockingDllFiles
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

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060000F9 RID: 249 RVA: 0x0016D70C File Offset: 0x0016D70C
		// (set) Token: 0x060000FA RID: 250 RVA: 0x0016D714 File Offset: 0x0016D714
		[Menu(null, "Requires restart to apply. Load plugins from source even if there is a compiled plugin with the same name")]
		public ToggleNode PreferSourcePlugins
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

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060000FB RID: 251 RVA: 0x0016D720 File Offset: 0x0016D720
		// (set) Token: 0x060000FC RID: 252 RVA: 0x0016D728 File Offset: 0x0016D728
		[Menu(null, "Start one build using a graph with all plugins included. Decreases total build time")]
		[JsonProperty("BuildAllPluginsAtOnce_v2")]
		public ToggleNode BuildAllPluginsAtOnce
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

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060000FD RID: 253 RVA: 0x0016D734 File Offset: 0x0016D734
		// (set) Token: 0x060000FE RID: 254 RVA: 0x0016D73C File Offset: 0x0016D73C
		public ToggleNode CachePluginCompilationResults
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

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060000FF RID: 255 RVA: 0x0016D748 File Offset: 0x0016D748
		// (set) Token: 0x06000100 RID: 256 RVA: 0x0016D750 File Offset: 0x0016D750
		[Menu(null, "You probably don't want to enable this")]
		public ToggleNode IgnoreReferenceChangesForCompilationCache
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

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x06000101 RID: 257 RVA: 0x0016D75C File Offset: 0x0016D75C
		// (set) Token: 0x06000102 RID: 258 RVA: 0x0016D764 File Offset: 0x0016D764
		[JsonIgnore]
		public ButtonNode ResetCompilationCache
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

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x06000103 RID: 259 RVA: 0x0016D770 File Offset: 0x0016D770
		// (set) Token: 0x06000104 RID: 260 RVA: 0x0016D778 File Offset: 0x0016D778
		public CorePluginSettings.PluginFolderSettings FolderSettings
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

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x06000105 RID: 261 RVA: 0x0016D784 File Offset: 0x0016D784
		// (set) Token: 0x06000106 RID: 262 RVA: 0x0016D78C File Offset: 0x0016D78C
		public CorePluginSettings.PluginNotificationSettings NotificationSettings
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

		// Token: 0x06000107 RID: 263 RVA: 0x0016D798 File Offset: 0x0016D798
		public CorePluginSettings()
		{
			this;
			0;
			this;
			0;
			this;
			0;
			this;
			1;
			this;
			1;
			this;
			0;
			this;
			this;
			this;
			this;
		}

		// Token: 0x02000020 RID: 32
		[Submenu(RenderMethod = "Render", CollapsedByDefault = true, EnableSelfDrawCollapsing = true)]
		public class PluginFolderSettings
		{
			// Token: 0x06000108 RID: 264 RVA: 0x0016D818 File Offset: 0x0016D818
			public void Render()
			{
				/*
An exception occurred when decompiling this method (06000108)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void ExileCore2.CorePluginSettings/PluginFolderSettings::Render()

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

			// Token: 0x06000109 RID: 265 RVA: 0x0016DA7C File Offset: 0x0016DA7C
			public PluginFolderSettings()
			{
				this;
				this;
				this;
			}

			// Token: 0x04000099 RID: 153
			public List<CorePluginSettings.PluginFolderSettings.PluginFolder> PluginFolders;

			// Token: 0x0400009A RID: 154
			public Dictionary<string, Guid?> PluginFolderMapping;

			// Token: 0x02000021 RID: 33
			public class PluginFolder
			{
				// Token: 0x17000049 RID: 73
				// (get) Token: 0x0600010A RID: 266 RVA: 0x0016DA9C File Offset: 0x0016DA9C
				// (set) Token: 0x0600010B RID: 267 RVA: 0x0016DAA4 File Offset: 0x0016DAA4
				public Guid Id
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

				// Token: 0x0600010C RID: 268 RVA: 0x0016DAB0 File Offset: 0x0016DAB0
				public PluginFolder()
				{
					this;
					this;
				}

				// Token: 0x0400009C RID: 156
				public string Name;

				// Token: 0x0400009D RID: 157
				public bool CollapsedByDefault;
			}
		}

		// Token: 0x02000023 RID: 35
		[Submenu(CollapsedByDefault = true)]
		public class PluginNotificationSettings
		{
			// Token: 0x1700004A RID: 74
			// (get) Token: 0x06000110 RID: 272 RVA: 0x0016DAE8 File Offset: 0x0016DAE8
			// (set) Token: 0x06000111 RID: 273 RVA: 0x0016DAF0 File Offset: 0x0016DAF0
			public ToggleNode Show
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

			// Token: 0x1700004B RID: 75
			// (get) Token: 0x06000112 RID: 274 RVA: 0x0016DAFC File Offset: 0x0016DAFC
			// (set) Token: 0x06000113 RID: 275 RVA: 0x0016DB04 File Offset: 0x0016DB04
			public ToggleNode ShowWhenNoNotifications
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

			// Token: 0x1700004C RID: 76
			// (get) Token: 0x06000114 RID: 276 RVA: 0x0016DB10 File Offset: 0x0016DB10
			// (set) Token: 0x06000115 RID: 277 RVA: 0x0016DB18 File Offset: 0x0016DB18
			public ToggleNode MoveWhenSettingsOpen
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

			// Token: 0x1700004D RID: 77
			// (get) Token: 0x06000116 RID: 278 RVA: 0x0016DB24 File Offset: 0x0016DB24
			// (set) Token: 0x06000117 RID: 279 RVA: 0x0016DB2C File Offset: 0x0016DB2C
			public ListNode MinMapEventLevel
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

			// Token: 0x1700004E RID: 78
			// (get) Token: 0x06000118 RID: 280 RVA: 0x0016DB38 File Offset: 0x0016DB38
			// (set) Token: 0x06000119 RID: 281 RVA: 0x0016DB40 File Offset: 0x0016DB40
			public ListNode MinEventLevel
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

			// Token: 0x1700004F RID: 79
			// (get) Token: 0x0600011A RID: 282 RVA: 0x0016DB4C File Offset: 0x0016DB4C
			// (set) Token: 0x0600011B RID: 283 RVA: 0x0016DB54 File Offset: 0x0016DB54
			public ColorNode VerboseNotificationColor
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

			// Token: 0x17000050 RID: 80
			// (get) Token: 0x0600011C RID: 284 RVA: 0x0016DB60 File Offset: 0x0016DB60
			// (set) Token: 0x0600011D RID: 285 RVA: 0x0016DB68 File Offset: 0x0016DB68
			public ColorNode DebugNotificationColor
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

			// Token: 0x17000051 RID: 81
			// (get) Token: 0x0600011E RID: 286 RVA: 0x0016DB74 File Offset: 0x0016DB74
			// (set) Token: 0x0600011F RID: 287 RVA: 0x0016DB7C File Offset: 0x0016DB7C
			public ColorNode InfoNotificationColor
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

			// Token: 0x17000052 RID: 82
			// (get) Token: 0x06000120 RID: 288 RVA: 0x0016DB88 File Offset: 0x0016DB88
			// (set) Token: 0x06000121 RID: 289 RVA: 0x0016DB90 File Offset: 0x0016DB90
			public ColorNode WarningNotificationColor
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

			// Token: 0x17000053 RID: 83
			// (get) Token: 0x06000122 RID: 290 RVA: 0x0016DB9C File Offset: 0x0016DB9C
			// (set) Token: 0x06000123 RID: 291 RVA: 0x0016DBA4 File Offset: 0x0016DBA4
			public ColorNode ErrorNotificationColor
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

			// Token: 0x17000054 RID: 84
			// (get) Token: 0x06000124 RID: 292 RVA: 0x0016DBB0 File Offset: 0x0016DBB0
			// (set) Token: 0x06000125 RID: 293 RVA: 0x0016DBB8 File Offset: 0x0016DBB8
			public ColorNode FatalNotificationColor
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

			// Token: 0x17000055 RID: 85
			// (get) Token: 0x06000126 RID: 294 RVA: 0x0016DBC4 File Offset: 0x0016DBC4
			// (set) Token: 0x06000127 RID: 295 RVA: 0x0016DBCC File Offset: 0x0016DBCC
			public CorePluginSettings.PluginNotificationSettings.Categories CategoriesSettings
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

			// Token: 0x06000128 RID: 296 RVA: 0x0016DBD8 File Offset: 0x0016DBD8
			public PluginNotificationSettings()
			{
				/*
An exception occurred when decompiling this method (06000128)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void ExileCore2.CorePluginSettings/PluginNotificationSettings::.ctor()

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

			// Token: 0x02000024 RID: 36
			[Submenu(RenderMethod = "Render", CollapsedByDefault = true, EnableSelfDrawCollapsing = true)]
			public class Categories
			{
				// Token: 0x06000129 RID: 297 RVA: 0x0016DD28 File Offset: 0x0016DD28
				public void Render()
				{
					/*
An exception occurred when decompiling this method (06000129)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void ExileCore2.CorePluginSettings/PluginNotificationSettings/Categories::Render()

 ---> System.Exception: Inconsistent stack size at IL_15
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 443
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.Build(MethodDef methodDef, Boolean optimize, DecompilerContext context) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 271
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 112
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
				}

				// Token: 0x0600012A RID: 298 RVA: 0x0016E000 File Offset: 0x0016E000
				public Categories()
				{
					this;
					this;
					"";
					this;
				}

				// Token: 0x0600012B RID: 299 RVA: 0x0016E020 File Offset: 0x0016E020
				// Note: this type is marked as 'beforefieldinit'.
				static Categories()
				{
					Enum.GetValues<LogEventLevel>();
				}

				// Token: 0x040000AC RID: 172
				private static readonly List<string> LogEventLevelValues;

				// Token: 0x040000AD RID: 173
				public Dictionary<string, CorePluginSettings.PluginNotificationSettings.Categories.PerPluginSettings> Plugins;

				// Token: 0x040000AE RID: 174
				private string _filter;

				// Token: 0x02000025 RID: 37
				public class PerPluginSettings
				{
					// Token: 0x0600012D RID: 301 RVA: 0x0016E06C File Offset: 0x0016E06C
					public PerPluginSettings()
					{
						this;
						"";
						this;
						"";
						this;
						"";
						this;
						"";
						this;
						this;
					}

					// Token: 0x040000AF RID: 175
					public string CategoryBlacklistRegex;

					// Token: 0x040000B0 RID: 176
					public string MapCategoryBlacklistRegex;

					// Token: 0x040000B1 RID: 177
					public string IdBlacklistRegex;

					// Token: 0x040000B2 RID: 178
					public string MapIdBlacklistRegex;

					// Token: 0x040000B3 RID: 179
					public List<CorePluginSettings.PluginNotificationSettings.Categories.PerPluginSettings.LevelMapping> LevelMappings;

					// Token: 0x02000026 RID: 38
					public class LevelMapping
					{
						// Token: 0x0600012E RID: 302 RVA: 0x0016E0AC File Offset: 0x0016E0AC
						public LevelMapping()
						{
							this;
							"";
							this;
							"";
							this;
							2;
							this;
							"";
							this;
						}

						// Token: 0x040000B4 RID: 180
						public string CategoryRegex;

						// Token: 0x040000B5 RID: 181
						public string IdRegex;

						// Token: 0x040000B6 RID: 182
						public LogEventLevel Level;

						// Token: 0x040000B7 RID: 183
						internal string LevelInput;
					}
				}
			}
		}
	}
}
