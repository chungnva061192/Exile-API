using System;
using ExileCore2.PoEMemory.FilesInMemory;

namespace ExileCore2.PoEMemory.MemoryObjects.Heist
{
	// Token: 0x02000217 RID: 535
	public class HeistJobRecord : RemoteMemoryObject
	{
		// Token: 0x17000549 RID: 1353
		// (get) Token: 0x06001041 RID: 4161 RVA: 0x001A33BC File Offset: 0x001A33BC
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

		// Token: 0x1700054A RID: 1354
		// (get) Token: 0x06001042 RID: 4162 RVA: 0x001A33E0 File Offset: 0x001A33E0
		public string Name
		{
			get
			{
				this;
				this;
				this + 8L;
				return 1;
			}
		}

		// Token: 0x1700054B RID: 1355
		// (get) Token: 0x06001043 RID: 4163 RVA: 0x001A3408 File Offset: 0x001A3408
		public string RequiredSkillIcon
		{
			get
			{
				this;
				this;
				this + 16L;
				return 1;
			}
		}

		// Token: 0x1700054C RID: 1356
		// (get) Token: 0x06001044 RID: 4164 RVA: 0x001A3430 File Offset: 0x001A3430
		public string SkillIcon
		{
			get
			{
				this;
				this;
				this + 24L;
				return 1;
			}
		}

		// Token: 0x1700054D RID: 1357
		// (get) Token: 0x06001045 RID: 4165 RVA: 0x001A3458 File Offset: 0x001A3458
		public string MapIcon
		{
			get
			{
				this;
				this;
				this + 40L;
				return 1;
			}
		}

		// Token: 0x1700054E RID: 1358
		// (get) Token: 0x06001046 RID: 4166 RVA: 0x001A3480 File Offset: 0x001A3480
		public StatsDat.StatRecord LevelStat
		{
			get
			{
				this;
				return this + 48L;
			}
		}

		// Token: 0x1700054F RID: 1359
		// (get) Token: 0x06001047 RID: 4167 RVA: 0x001A34AC File Offset: 0x001A34AC
		public StatsDat.StatRecord AlertStat
		{
			get
			{
				this;
				return this + 64L;
			}
		}

		// Token: 0x17000550 RID: 1360
		// (get) Token: 0x06001048 RID: 4168 RVA: 0x001A34D8 File Offset: 0x001A34D8
		public StatsDat.StatRecord AlarmStat
		{
			get
			{
				this;
				return this + 80L;
			}
		}

		// Token: 0x17000551 RID: 1361
		// (get) Token: 0x06001049 RID: 4169 RVA: 0x001A3504 File Offset: 0x001A3504
		public StatsDat.StatRecord CostStat
		{
			get
			{
				this;
				return this + 96L;
			}
		}

		// Token: 0x17000552 RID: 1362
		// (get) Token: 0x0600104A RID: 4170 RVA: 0x001A3530 File Offset: 0x001A3530
		public StatsDat.StatRecord ExperienceGainStat
		{
			get
			{
				this;
				return this + 112L;
			}
		}

		// Token: 0x0600104B RID: 4171 RVA: 0x001A355C File Offset: 0x001A355C
		public override string ToString()
		{
			/*
An exception occurred when decompiling this method (0600104B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String ExileCore2.PoEMemory.MemoryObjects.Heist.HeistJobRecord::ToString()

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

		// Token: 0x0600104C RID: 4172 RVA: 0x001A3574 File Offset: 0x001A3574
		public HeistJobRecord()
		{
			this;
		}
	}
}
