using System;
using System.Runtime.CompilerServices;

namespace ExileCore2.PoEMemory.Models
{
	// Token: 0x020001A8 RID: 424
	public class BaseItemType
	{
		// Token: 0x170002E4 RID: 740
		// (get) Token: 0x06000C04 RID: 3076 RVA: 0x001960A0 File Offset: 0x001960A0
		// (set) Token: 0x06000C05 RID: 3077 RVA: 0x001960A8 File Offset: 0x001960A8
		public string Metadata
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

		// Token: 0x170002E5 RID: 741
		// (get) Token: 0x06000C06 RID: 3078 RVA: 0x001960B4 File Offset: 0x001960B4
		// (set) Token: 0x06000C07 RID: 3079 RVA: 0x001960BC File Offset: 0x001960BC
		public string ClassName
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

		// Token: 0x170002E6 RID: 742
		// (get) Token: 0x06000C08 RID: 3080 RVA: 0x001960C8 File Offset: 0x001960C8
		// (set) Token: 0x06000C09 RID: 3081 RVA: 0x001960D0 File Offset: 0x001960D0
		public int Width
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

		// Token: 0x170002E7 RID: 743
		// (get) Token: 0x06000C0A RID: 3082 RVA: 0x001960DC File Offset: 0x001960DC
		// (set) Token: 0x06000C0B RID: 3083 RVA: 0x001960E4 File Offset: 0x001960E4
		public int Height
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

		// Token: 0x170002E8 RID: 744
		// (get) Token: 0x06000C0C RID: 3084 RVA: 0x001960F0 File Offset: 0x001960F0
		// (set) Token: 0x06000C0D RID: 3085 RVA: 0x001960F8 File Offset: 0x001960F8
		public int DropLevel
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

		// Token: 0x170002E9 RID: 745
		// (get) Token: 0x06000C0E RID: 3086 RVA: 0x00196104 File Offset: 0x00196104
		// (set) Token: 0x06000C0F RID: 3087 RVA: 0x0019610C File Offset: 0x0019610C
		public string BaseName
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

		// Token: 0x170002EA RID: 746
		// (get) Token: 0x06000C10 RID: 3088 RVA: 0x00196118 File Offset: 0x00196118
		// (set) Token: 0x06000C11 RID: 3089 RVA: 0x00196120 File Offset: 0x00196120
		public string[] Tags
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

		// Token: 0x170002EB RID: 747
		// (get) Token: 0x06000C12 RID: 3090 RVA: 0x0019612C File Offset: 0x0019612C
		// (set) Token: 0x06000C13 RID: 3091 RVA: 0x00196134 File Offset: 0x00196134
		public string[] MoreTagsFromPath
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

		// Token: 0x170002EC RID: 748
		// (get) Token: 0x06000C14 RID: 3092 RVA: 0x00196140 File Offset: 0x00196140
		// (set) Token: 0x06000C15 RID: 3093 RVA: 0x00196148 File Offset: 0x00196148
		public uint Hash
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

		// Token: 0x06000C16 RID: 3094 RVA: 0x00196154 File Offset: 0x00196154
		public override string ToString()
		{
			/*
An exception occurred when decompiling this method (06000C16)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String ExileCore2.PoEMemory.Models.BaseItemType::ToString()

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

		// Token: 0x06000C17 RID: 3095 RVA: 0x001961F8 File Offset: 0x001961F8
		public BaseItemType()
		{
			this;
		}
	}
}
