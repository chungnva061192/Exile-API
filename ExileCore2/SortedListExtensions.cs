using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;
using System.Reflection;

namespace ExileCore2
{
	// Token: 0x020000AA RID: 170
	public static class SortedListExtensions
	{
		// Token: 0x060004E1 RID: 1249 RVA: 0x0017EC78 File Offset: 0x0017EC78
		public static bool TryGetLowerBound(this SortedList<long, byte[]> list, long key, [NotNullWhen(true)] out long lowerBoundKey, [NotNullWhen(true)] out byte[] lowerBoundValue)
		{
			/*
An exception occurred when decompiling this method (060004E1)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean ExileCore2.SortedListExtensions::TryGetLowerBound(System.Collections.Generic.SortedList`2<System.Int64,System.Byte[]>,System.Int64,System.Int64&,System.Byte[]&)

 ---> System.Exception: Inconsistent stack size at IL_0D
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 443
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.Build(MethodDef methodDef, Boolean optimize, DecompilerContext context) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 271
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 112
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
		}

		// Token: 0x060004E2 RID: 1250 RVA: 0x0017ED00 File Offset: 0x0017ED00
		private static Func<TSource, TResult> GetGetter<TSource, TResult>(FieldInfo field)
		{
			ParameterExpression parameterExpression = Expression.Parameter(typeof(TSource));
			return Expression.Lambda<Func<TSource, TResult>>(Expression.Field(parameterExpression, field), new ParameterExpression[]
			{
				parameterExpression
			}).Compile();
		}

		// Token: 0x060004E3 RID: 1251 RVA: 0x0017ED40 File Offset: 0x0017ED40
		// Note: this type is marked as 'beforefieldinit'.
		static SortedListExtensions()
		{
			typeof(SortedList<long, byte[]>).TypeHandle;
			"keys";
			36;
			typeof(SortedList<long, byte[]>).TypeHandle;
			"_size";
			36;
			typeof(SortedList<long, byte[]>).TypeHandle;
			"comparer";
			36;
		}

		// Token: 0x040002F1 RID: 753
		private static readonly Func<SortedList<long, byte[]>, long[]> KeysGetter;

		// Token: 0x040002F2 RID: 754
		private static readonly Func<SortedList<long, byte[]>, int> SizeGetter;

		// Token: 0x040002F3 RID: 755
		private static readonly Func<SortedList<long, byte[]>, IComparer<long>> ComparerGetter;
	}
}
