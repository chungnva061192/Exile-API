using System;

namespace ExileCore2.PoEMemory.MemoryObjects.Heist
{
	// Token: 0x02000216 RID: 534
	public class HeistChestRewardTypeRecord : RemoteMemoryObject
	{
		// Token: 0x17000540 RID: 1344
		// (get) Token: 0x06001036 RID: 4150 RVA: 0x001A3264 File Offset: 0x001A3264
		public string Id
		{
			get
			{
				this;
				this;
				this;
				return 1;
			}
		}

		// Token: 0x17000541 RID: 1345
		// (get) Token: 0x06001037 RID: 4151 RVA: 0x001A3288 File Offset: 0x001A3288
		public string Art
		{
			get
			{
				this;
				this;
				this + 8L;
				return 1;
			}
		}

		// Token: 0x17000542 RID: 1346
		// (get) Token: 0x06001038 RID: 4152 RVA: 0x001A32B0 File Offset: 0x001A32B0
		public string Name
		{
			get
			{
				this;
				this;
				this + 16L;
				return 1;
			}
		}

		// Token: 0x17000543 RID: 1347
		// (get) Token: 0x06001039 RID: 4153 RVA: 0x001A32D8 File Offset: 0x001A32D8
		public int MinimumDropLevel
		{
			get
			{
				this;
				return this + 40L;
			}
		}

		// Token: 0x17000544 RID: 1348
		// (get) Token: 0x0600103A RID: 4154 RVA: 0x001A32F0 File Offset: 0x001A32F0
		public int MaximumDropLevel
		{
			get
			{
				this;
				return this + 44L;
			}
		}

		// Token: 0x17000545 RID: 1349
		// (get) Token: 0x0600103B RID: 4155 RVA: 0x001A3308 File Offset: 0x001A3308
		public int Weight
		{
			get
			{
				this;
				return this + 48L;
			}
		}

		// Token: 0x17000546 RID: 1350
		// (get) Token: 0x0600103C RID: 4156 RVA: 0x001A3320 File Offset: 0x001A3320
		public string RoomName
		{
			get
			{
				this;
				this;
				this + 52L;
				return 1;
			}
		}

		// Token: 0x17000547 RID: 1351
		// (get) Token: 0x0600103D RID: 4157 RVA: 0x001A3348 File Offset: 0x001A3348
		public int RequiredJobLevel
		{
			get
			{
				this;
				return this + 60L;
			}
		}

		// Token: 0x17000548 RID: 1352
		// (get) Token: 0x0600103E RID: 4158 RVA: 0x001A3360 File Offset: 0x001A3360
		public HeistJobRecord RequiredJob
		{
			get
			{
				this;
				this + 68L;
				return new int[]
				{
					8
				};
			}
		}

		// Token: 0x0600103F RID: 4159 RVA: 0x001A3398 File Offset: 0x001A3398
		public override string ToString()
		{
			/*
An exception occurred when decompiling this method (0600103F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String ExileCore2.PoEMemory.MemoryObjects.Heist.HeistChestRewardTypeRecord::ToString()

 ---> System.Exception: Inconsistent stack size at IL_03
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 443
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.Build(MethodDef methodDef, Boolean optimize, DecompilerContext context) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 271
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 112
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
		}

		// Token: 0x06001040 RID: 4160 RVA: 0x001A33B0 File Offset: 0x001A33B0
		public HeistChestRewardTypeRecord()
		{
			this;
		}
	}
}
