﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.6.6
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:\Users\anyur\Documents\prog\C#\MyExcel\MyExcel.g4 by ANTLR 4.6.6

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace MyExcel {
using Antlr4.Runtime.Misc;
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="MyExcelParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.6")]
[System.CLSCompliant(false)]
public interface IMyExcelListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by the <c>ParenthesizedExpr</c>
	/// labeled alternative in <see cref="MyExcelParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterParenthesizedExpr([NotNull] MyExcelParser.ParenthesizedExprContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ParenthesizedExpr</c>
	/// labeled alternative in <see cref="MyExcelParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitParenthesizedExpr([NotNull] MyExcelParser.ParenthesizedExprContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>ExponentialExpr</c>
	/// labeled alternative in <see cref="MyExcelParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExponentialExpr([NotNull] MyExcelParser.ExponentialExprContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ExponentialExpr</c>
	/// labeled alternative in <see cref="MyExcelParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExponentialExpr([NotNull] MyExcelParser.ExponentialExprContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>MultiplicativeExpr</c>
	/// labeled alternative in <see cref="MyExcelParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMultiplicativeExpr([NotNull] MyExcelParser.MultiplicativeExprContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>MultiplicativeExpr</c>
	/// labeled alternative in <see cref="MyExcelParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMultiplicativeExpr([NotNull] MyExcelParser.MultiplicativeExprContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>AdditiveExpr</c>
	/// labeled alternative in <see cref="MyExcelParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAdditiveExpr([NotNull] MyExcelParser.AdditiveExprContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>AdditiveExpr</c>
	/// labeled alternative in <see cref="MyExcelParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAdditiveExpr([NotNull] MyExcelParser.AdditiveExprContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>ComparativeExpr</c>
	/// labeled alternative in <see cref="MyExcelParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterComparativeExpr([NotNull] MyExcelParser.ComparativeExprContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ComparativeExpr</c>
	/// labeled alternative in <see cref="MyExcelParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitComparativeExpr([NotNull] MyExcelParser.ComparativeExprContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>MinExpr</c>
	/// labeled alternative in <see cref="MyExcelParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMinExpr([NotNull] MyExcelParser.MinExprContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>MinExpr</c>
	/// labeled alternative in <see cref="MyExcelParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMinExpr([NotNull] MyExcelParser.MinExprContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>MaxExpr</c>
	/// labeled alternative in <see cref="MyExcelParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMaxExpr([NotNull] MyExcelParser.MaxExprContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>MaxExpr</c>
	/// labeled alternative in <see cref="MyExcelParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMaxExpr([NotNull] MyExcelParser.MaxExprContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>NotExpr</c>
	/// labeled alternative in <see cref="MyExcelParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNotExpr([NotNull] MyExcelParser.NotExprContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>NotExpr</c>
	/// labeled alternative in <see cref="MyExcelParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNotExpr([NotNull] MyExcelParser.NotExprContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>NumberExpr</c>
	/// labeled alternative in <see cref="MyExcelParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNumberExpr([NotNull] MyExcelParser.NumberExprContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>NumberExpr</c>
	/// labeled alternative in <see cref="MyExcelParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNumberExpr([NotNull] MyExcelParser.NumberExprContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>IdentifierExpr</c>
	/// labeled alternative in <see cref="MyExcelParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIdentifierExpr([NotNull] MyExcelParser.IdentifierExprContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>IdentifierExpr</c>
	/// labeled alternative in <see cref="MyExcelParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIdentifierExpr([NotNull] MyExcelParser.IdentifierExprContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="MyExcelParser.compileUnit"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCompileUnit([NotNull] MyExcelParser.CompileUnitContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MyExcelParser.compileUnit"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCompileUnit([NotNull] MyExcelParser.CompileUnitContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="MyExcelParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExpression([NotNull] MyExcelParser.ExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MyExcelParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExpression([NotNull] MyExcelParser.ExpressionContext context);
}
} // namespace MyExcel