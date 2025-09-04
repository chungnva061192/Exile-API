using System;
using System.Numerics;
using ExileCore2.PoEMemory.Elements;
using ExileCore2.Shared.Cache;
using GameOffsets2;
using GameOffsets2.Native;

namespace ExileCore2.PoEMemory.MemoryObjects
{
	// Token: 0x020001E3 RID: 483
	public class IngameState : RemoteMemoryObject
	{
		// Token: 0x06000DF9 RID: 3577 RVA: 0x0019D2E4 File Offset: 0x0019D2E4
		public IngameState()
		{
			this;
			this;
			this;
			this;
			this;
			this;
			this;
			this;
			this;
			this;
			this;
			this;
			this;
			this;
			this;
			this;
			this;
			this;
			this;
			this;
			this;
			this;
			this;
			this;
			this;
			this;
		}

		// Token: 0x170003DF RID: 991
		// (get) Token: 0x06000DFA RID: 3578 RVA: 0x0019D41C File Offset: 0x0019D41C
		public Camera Camera
		{
			get
			{
				return this;
			}
		}

		// Token: 0x170003E0 RID: 992
		// (get) Token: 0x06000DFB RID: 3579 RVA: 0x0019D42C File Offset: 0x0019D42C
		public IngameData Data
		{
			get
			{
				return this;
			}
		}

		// Token: 0x170003E1 RID: 993
		// (get) Token: 0x06000DFC RID: 3580 RVA: 0x0019D43C File Offset: 0x0019D43C
		public bool InGame
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000DFC)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean ExileCore2.PoEMemory.MemoryObjects.IngameState::get_InGame()

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

		// Token: 0x170003E2 RID: 994
		// (get) Token: 0x06000DFD RID: 3581 RVA: 0x0019D450 File Offset: 0x0019D450
		public ServerData ServerData
		{
			get
			{
				IngameState ingameState = this;
				while ((ingameState = ingameState) != null)
				{
				}
				int num = 0;
				for (;;)
				{
					num = (int)((long)num);
				}
			}
		}

		// Token: 0x170003E3 RID: 995
		// (get) Token: 0x06000DFE RID: 3582 RVA: 0x0019D484 File Offset: 0x0019D484
		public IngameUIElements IngameUi
		{
			get
			{
				return this;
			}
		}

		// Token: 0x170003E4 RID: 996
		// (get) Token: 0x06000DFF RID: 3583 RVA: 0x0019D494 File Offset: 0x0019D494
		public Element UIRoot
		{
			get
			{
				return this;
			}
		}

		// Token: 0x170003E5 RID: 997
		// (get) Token: 0x06000E00 RID: 3584 RVA: 0x0019D4A4 File Offset: 0x0019D4A4
		public ShortcutSettings ShortcutSettings
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000E00)

ICSharpCode.Decompiler.DecompilerException: Error decompiling ExileCore2.PoEMemory.Elements.ShortcutSettings ExileCore2.PoEMemory.MemoryObjects.IngameState::get_ShortcutSettings()

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

		// Token: 0x170003E6 RID: 998
		// (get) Token: 0x06000E01 RID: 3585 RVA: 0x0019D4C0 File Offset: 0x0019D4C0
		public int ZoneSwitchCounter
		{
			get
			{
				return this;
			}
		}

		// Token: 0x170003E7 RID: 999
		// (get) Token: 0x06000E02 RID: 3586 RVA: 0x0019D4D4 File Offset: 0x0019D4D4
		public Element UIHover
		{
			get
			{
				return this;
			}
		}

		// Token: 0x170003E8 RID: 1000
		// (get) Token: 0x06000E03 RID: 3587 RVA: 0x0019D4E4 File Offset: 0x0019D4E4
		public float UIHoverX
		{
			get
			{
				return this;
			}
		}

		// Token: 0x170003E9 RID: 1001
		// (get) Token: 0x06000E04 RID: 3588 RVA: 0x0019D4F8 File Offset: 0x0019D4F8
		public float UIHoverY
		{
			get
			{
				return this;
			}
		}

		// Token: 0x170003EA RID: 1002
		// (get) Token: 0x06000E05 RID: 3589 RVA: 0x0019D50C File Offset: 0x0019D50C
		public Element UIHoverElement
		{
			get
			{
				return this;
			}
		}

		// Token: 0x170003EB RID: 1003
		// (get) Token: 0x06000E06 RID: 3590 RVA: 0x0019D51C File Offset: 0x0019D51C
		public Element UIHoverTooltip
		{
			get
			{
				return this;
			}
		}

		// Token: 0x170003EC RID: 1004
		// (get) Token: 0x06000E07 RID: 3591 RVA: 0x0019D524 File Offset: 0x0019D524
		public float CurentUElementPosX
		{
			get
			{
				return this;
			}
		}

		// Token: 0x170003ED RID: 1005
		// (get) Token: 0x06000E08 RID: 3592 RVA: 0x0019D538 File Offset: 0x0019D538
		public float CurentUElementPosY
		{
			get
			{
				return this;
			}
		}

		// Token: 0x170003EE RID: 1006
		// (get) Token: 0x06000E09 RID: 3593 RVA: 0x0019D54C File Offset: 0x0019D54C
		public int MousePosX
		{
			get
			{
				return this;
			}
		}

		// Token: 0x170003EF RID: 1007
		// (get) Token: 0x06000E0A RID: 3594 RVA: 0x0019D560 File Offset: 0x0019D560
		public int MousePosY
		{
			get
			{
				return this;
			}
		}

		// Token: 0x170003F0 RID: 1008
		// (get) Token: 0x06000E0B RID: 3595 RVA: 0x0019D574 File Offset: 0x0019D574
		public long EntityLabelMap
		{
			get
			{
				return this;
			}
		}

		// Token: 0x170003F1 RID: 1009
		// (get) Token: 0x06000E0C RID: 3596 RVA: 0x0019D588 File Offset: 0x0019D588
		public TimeSpan TimeInGame
		{
			get
			{
				return this;
			}
		}

		// Token: 0x170003F2 RID: 1010
		// (get) Token: 0x06000E0D RID: 3597 RVA: 0x0019D5A0 File Offset: 0x0019D5A0
		public float TimeInGameF
		{
			get
			{
				return this;
			}
		}

		// Token: 0x06000E0E RID: 3598 RVA: 0x0019D5B0 File Offset: 0x0019D5B0
		public void UpdateData()
		{
			this;
		}

		// Token: 0x06000E0F RID: 3599 RVA: 0x0019D5C0 File Offset: 0x0019D5C0
		// Note: this type is marked as 'beforefieldinit'.
		static IngameState()
		{
			/*
An exception occurred when decompiling this method (06000E0F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void ExileCore2.PoEMemory.MemoryObjects.IngameState::.cctor()

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

		// Token: 0x04007FC6 RID: 32710
		private readonly CachedValue<Camera> _camera;

		// Token: 0x04007FC7 RID: 32711
		private readonly CachedValue<Vector2> _CurrentUIElementPos;

		// Token: 0x04007FC8 RID: 32712
		private readonly CachedValue<Vector2i> _MousePos;

		// Token: 0x04007FC9 RID: 32713
		private readonly CachedValue<EntityLabelMapOffsets> _EntityLabelMap;

		// Token: 0x04007FCA RID: 32714
		private readonly CachedValue<IngameData> _ingameData;

		// Token: 0x04007FCB RID: 32715
		private readonly CachedValue<IngameStateOffsets> _ingameState;

		// Token: 0x04007FCC RID: 32716
		private readonly CachedValue<IngameUIElements> _ingameUi;

		// Token: 0x04007FCD RID: 32717
		private readonly CachedValue<float> _TimeInGameF;

		// Token: 0x04007FCE RID: 32718
		private readonly CachedValue<Element> _UIHover;

		// Token: 0x04007FCF RID: 32719
		private readonly CachedValue<Element> _UIHoverElement;

		// Token: 0x04007FD0 RID: 32720
		private readonly CachedValue<Vector2> _UIHoverPos;

		// Token: 0x04007FD1 RID: 32721
		private readonly CachedValue<Element> _UIRoot;

		// Token: 0x04007FD2 RID: 32722
		private static readonly int WorldDataOffset;

		// Token: 0x04007FD3 RID: 32723
		private static readonly int CameraOffset;
	}
}
