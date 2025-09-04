using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using ExileCore2.PoEMemory.FilesInMemory;

namespace ExileCore2.PoEMemory.MemoryObjects
{
	// Token: 0x020001F9 RID: 505
	public class MonsterVariety : RemoteMemoryObject
	{
		// Token: 0x17000480 RID: 1152
		// (get) Token: 0x06000F1E RID: 3870 RVA: 0x001A0D60 File Offset: 0x001A0D60
		// (set) Token: 0x06000F1F RID: 3871 RVA: 0x001A0D68 File Offset: 0x001A0D68
		public int Id
		{
			[CompilerGenerated]
			get
			{
				return this;
			}
			[CompilerGenerated]
			internal set
			{
				this;
				value;
			}
		}

		// Token: 0x17000481 RID: 1153
		// (get) Token: 0x06000F20 RID: 3872 RVA: 0x001A0D74 File Offset: 0x001A0D74
		public string VarietyId
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000F20)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String ExileCore2.PoEMemory.MemoryObjects.MonsterVariety::get_VarietyId()

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
		}

		// Token: 0x17000482 RID: 1154
		// (get) Token: 0x06000F21 RID: 3873 RVA: 0x001A0DB8 File Offset: 0x001A0DB8
		public long MonsterTypePtr
		{
			get
			{
				this;
				return this + 8L;
			}
		}

		// Token: 0x17000483 RID: 1155
		// (get) Token: 0x06000F22 RID: 3874 RVA: 0x001A0DD0 File Offset: 0x001A0DD0
		public int ObjectSize
		{
			get
			{
				this;
				return this + 28L;
			}
		}

		// Token: 0x17000484 RID: 1156
		// (get) Token: 0x06000F23 RID: 3875 RVA: 0x001A0DE8 File Offset: 0x001A0DE8
		public int MinimumAttackDistance
		{
			get
			{
				this;
				return this + 32L;
			}
		}

		// Token: 0x17000485 RID: 1157
		// (get) Token: 0x06000F24 RID: 3876 RVA: 0x001A0E00 File Offset: 0x001A0E00
		public int MaximumAttackDistance
		{
			get
			{
				this;
				return this + 36L;
			}
		}

		// Token: 0x17000486 RID: 1158
		// (get) Token: 0x06000F25 RID: 3877 RVA: 0x001A0E18 File Offset: 0x001A0E18
		public List<string> ACTFiles
		{
			get
			{
				this;
				this + 40L;
				this;
				return this;
			}
		}

		// Token: 0x17000487 RID: 1159
		// (get) Token: 0x06000F26 RID: 3878 RVA: 0x001A0E50 File Offset: 0x001A0E50
		public List<string> AOFiles
		{
			get
			{
				this;
				this + 56L;
				this;
				return this;
			}
		}

		// Token: 0x17000488 RID: 1160
		// (get) Token: 0x06000F27 RID: 3879 RVA: 0x001A0E88 File Offset: 0x001A0E88
		public string BaseMonsterTypeIndex
		{
			get
			{
				this;
				this;
				this + 72L;
				return 1;
			}
		}

		// Token: 0x17000489 RID: 1161
		// (get) Token: 0x06000F28 RID: 3880 RVA: 0x001A0EB0 File Offset: 0x001A0EB0
		public IEnumerable<ModsDat.ModRecord> Mods
		{
			get
			{
				this;
				IEnumerable<ModsDat.ModRecord> result = this + 80L;
				MonsterVariety monsterVariety = this;
				while ((monsterVariety = monsterVariety) != null)
				{
				}
				return result;
			}
		}

		// Token: 0x1700048A RID: 1162
		// (get) Token: 0x06000F29 RID: 3881 RVA: 0x001A0F28 File Offset: 0x001A0F28
		public int ModelSizeMultiplier
		{
			get
			{
				this;
				return this + 116L;
			}
		}

		// Token: 0x1700048B RID: 1163
		// (get) Token: 0x06000F2A RID: 3882 RVA: 0x001A0F40 File Offset: 0x001A0F40
		public int ExperienceMultiplier
		{
			get
			{
				return this + this;
			}
		}

		// Token: 0x1700048C RID: 1164
		// (get) Token: 0x06000F2B RID: 3883 RVA: 0x001A0F5C File Offset: 0x001A0F5C
		public int CriticalStrikeChance
		{
			get
			{
				return this + this;
			}
		}

		// Token: 0x1700048D RID: 1165
		// (get) Token: 0x06000F2C RID: 3884 RVA: 0x001A0F78 File Offset: 0x001A0F78
		public string AISFile
		{
			get
			{
				this;
				this + this;
				return 1;
			}
		}

		// Token: 0x1700048E RID: 1166
		// (get) Token: 0x06000F2D RID: 3885 RVA: 0x001A0FA4 File Offset: 0x001A0FA4
		public string MonsterName
		{
			get
			{
				this;
				this + this;
				return 1;
			}
		}

		// Token: 0x1700048F RID: 1167
		// (get) Token: 0x06000F2E RID: 3886 RVA: 0x001A0FD0 File Offset: 0x001A0FD0
		public int DamageMultiplier
		{
			get
			{
				return this + this;
			}
		}

		// Token: 0x17000490 RID: 1168
		// (get) Token: 0x06000F2F RID: 3887 RVA: 0x001A0FEC File Offset: 0x001A0FEC
		public int LifeMultiplier
		{
			get
			{
				return this + this;
			}
		}

		// Token: 0x17000491 RID: 1169
		// (get) Token: 0x06000F30 RID: 3888 RVA: 0x001A1008 File Offset: 0x001A1008
		public int AttackSpeed
		{
			get
			{
				return this + this;
			}
		}

		// Token: 0x06000F31 RID: 3889 RVA: 0x001A1024 File Offset: 0x001A1024
		public override string ToString()
		{
			/*
An exception occurred when decompiling this method (06000F31)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String ExileCore2.PoEMemory.MemoryObjects.MonsterVariety::ToString()

 ---> System.Exception: Inconsistent stack size at IL_1D
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 443
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.Build(MethodDef methodDef, Boolean optimize, DecompilerContext context) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 271
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 112
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
		}

		// Token: 0x06000F32 RID: 3890 RVA: 0x001A1098 File Offset: 0x001A1098
		public MonsterVariety()
		{
			this;
		}

		// Token: 0x0400802D RID: 32813
		private string _varietyId;
	}
}
