using System;
using ExileCore2.Shared.Cache;
using ExileCore2.Shared.Enums;
using GameOffsets2;

namespace ExileCore2.PoEMemory.Components
{
	// Token: 0x02000325 RID: 805
	public class Base : Component
	{
		// Token: 0x060015F2 RID: 5618 RVA: 0x001B2ED0 File Offset: 0x001B2ED0
		public Base()
		{
			this;
			this;
			this;
			this;
			this;
		}

		// Token: 0x17000840 RID: 2112
		// (get) Token: 0x060015F3 RID: 5619 RVA: 0x001B2F08 File Offset: 0x001B2F08
		public BaseComponentOffsets BaseStruct
		{
			get
			{
				return this;
			}
		}

		// Token: 0x17000841 RID: 2113
		// (get) Token: 0x060015F4 RID: 5620 RVA: 0x001B2F18 File Offset: 0x001B2F18
		public ItemInfoData Info
		{
			get
			{
				return this;
			}
		}

		// Token: 0x17000842 RID: 2114
		// (get) Token: 0x060015F5 RID: 5621 RVA: 0x001B2F28 File Offset: 0x001B2F28
		public string Name
		{
			get
			{
				/*
An exception occurred when decompiling this method (060015F5)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String ExileCore2.PoEMemory.Components.Base::get_Name()

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

		// Token: 0x17000843 RID: 2115
		// (get) Token: 0x060015F6 RID: 5622 RVA: 0x001B2F58 File Offset: 0x001B2F58
		public string FlavourText
		{
			get
			{
				this;
				this;
				this + 10L;
				return 1;
			}
		}

		// Token: 0x17000844 RID: 2116
		// (get) Token: 0x060015F7 RID: 5623 RVA: 0x001B2F8C File Offset: 0x001B2F8C
		public byte ItemCellsSizeX
		{
			get
			{
				return this;
			}
		}

		// Token: 0x17000845 RID: 2117
		// (get) Token: 0x060015F8 RID: 5624 RVA: 0x001B2FA0 File Offset: 0x001B2FA0
		public byte ItemCellsSizeY
		{
			get
			{
				return this;
			}
		}

		// Token: 0x17000846 RID: 2118
		// (get) Token: 0x060015F9 RID: 5625 RVA: 0x001B2FB4 File Offset: 0x001B2FB4
		public byte CurrencyItemLevel
		{
			get
			{
				return this;
			}
		}

		// Token: 0x17000847 RID: 2119
		// (get) Token: 0x060015FA RID: 5626 RVA: 0x001B2FC8 File Offset: 0x001B2FC8
		public Influence InfluenceFlag
		{
			get
			{
				return this;
			}
		}

		// Token: 0x17000848 RID: 2120
		// (get) Token: 0x060015FB RID: 5627 RVA: 0x001B2FDC File Offset: 0x001B2FDC
		public bool isShaper
		{
			get
			{
				return (this & 1) == 1;
			}
		}

		// Token: 0x17000849 RID: 2121
		// (get) Token: 0x060015FC RID: 5628 RVA: 0x001B2FEC File Offset: 0x001B2FEC
		public bool isElder
		{
			get
			{
				return (this & 2) == 2;
			}
		}

		// Token: 0x1700084A RID: 2122
		// (get) Token: 0x060015FD RID: 5629 RVA: 0x001B2FFC File Offset: 0x001B2FFC
		public bool isCrusader
		{
			get
			{
				return (this & 4) == 4;
			}
		}

		// Token: 0x1700084B RID: 2123
		// (get) Token: 0x060015FE RID: 5630 RVA: 0x001B300C File Offset: 0x001B300C
		public bool isHunter
		{
			get
			{
				return (this & 16) == 16;
			}
		}

		// Token: 0x1700084C RID: 2124
		// (get) Token: 0x060015FF RID: 5631 RVA: 0x001B301C File Offset: 0x001B301C
		public bool isRedeemer
		{
			get
			{
				return (this & 8) == 8;
			}
		}

		// Token: 0x1700084D RID: 2125
		// (get) Token: 0x06001600 RID: 5632 RVA: 0x001B302C File Offset: 0x001B302C
		public bool isWarlord
		{
			get
			{
				return (this & 32) == 32;
			}
		}

		// Token: 0x1700084E RID: 2126
		// (get) Token: 0x06001601 RID: 5633 RVA: 0x001B303C File Offset: 0x001B303C
		public bool isSynthesized
		{
			get
			{
				return this + this == 1;
			}
		}

		// Token: 0x1700084F RID: 2127
		// (get) Token: 0x06001602 RID: 5634 RVA: 0x001B305C File Offset: 0x001B305C
		public bool isCorrupted
		{
			get
			{
				return (this & 1) == 1;
			}
		}

		// Token: 0x17000850 RID: 2128
		// (get) Token: 0x06001603 RID: 5635 RVA: 0x001B3074 File Offset: 0x001B3074
		public int UnspentAbsorbedCorruption
		{
			get
			{
				return this;
			}
		}

		// Token: 0x17000851 RID: 2129
		// (get) Token: 0x06001604 RID: 5636 RVA: 0x001B3088 File Offset: 0x001B3088
		public int ScourgedTier
		{
			get
			{
				return this;
			}
		}

		// Token: 0x17000852 RID: 2130
		// (get) Token: 0x06001605 RID: 5637 RVA: 0x001B309C File Offset: 0x001B309C
		public string PublicPrice
		{
			get
			{
				this;
				return this;
			}
		}

		// Token: 0x040082B7 RID: 33463
		private readonly CachedValue<BaseComponentOffsets> _cachedValue;

		// Token: 0x040082B8 RID: 33464
		private readonly CachedValue<ItemInfoData> _itemInfoData;

		// Token: 0x040082B9 RID: 33465
		private string _name;
	}
}
