using System;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using ExileCore2.Shared.Enums;

namespace ExileCore2
{
	// Token: 0x02000086 RID: 134
	public class PluginPanel
	{
		// Token: 0x0600043F RID: 1087 RVA: 0x0017B328 File Offset: 0x0017B328
		public PluginPanel(Vector2 startDrawPoint, Direction direction = Direction.Down)
		{
			this;
			direction;
			this;
			startDrawPoint;
		}

		// Token: 0x06000440 RID: 1088 RVA: 0x0017B33C File Offset: 0x0017B33C
		public PluginPanel(Direction direction = Direction.Down)
		{
			this;
			this;
			this;
		}

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x06000441 RID: 1089 RVA: 0x0017B368 File Offset: 0x0017B368
		public bool Used
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000441)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean ExileCore2.PluginPanel::get_Used()

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
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x06000442 RID: 1090 RVA: 0x0017B394 File Offset: 0x0017B394
		// (set) Token: 0x06000443 RID: 1091 RVA: 0x0017B39C File Offset: 0x0017B39C
		public Vector2 StartDrawPoint
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

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x06000444 RID: 1092 RVA: 0x0017B3A8 File Offset: 0x0017B3A8
		public Vector2 Margin
		{
			[CompilerGenerated]
			get
			{
				return this;
			}
		}

		// Token: 0x06000445 RID: 1093 RVA: 0x0017B3B0 File Offset: 0x0017B3B0
		public void WantUse(Func<bool> enabled)
		{
			this;
			enabled;
		}

		// Token: 0x04000270 RID: 624
		private readonly List<Func<bool>> _settings;
	}
}
