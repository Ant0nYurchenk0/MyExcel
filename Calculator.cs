using Antlr4.Runtime;
using System;
using System.Collections.Generic;

namespace MyExcel
{
    public static class Calculator
    {
        public static Dictionary<string, bool> Registry = new Dictionary<string, bool>();
        public static string PrvtEvaluate(string expression)
        {
            try
            {
                var lexer = new MyExcelLexer(new AntlrInputStream(expression));
                lexer.RemoveErrorListeners();
                lexer.AddErrorListener(new ThrowExceptionErrorListener());
                var tokens = new CommonTokenStream(lexer);
                var parser = new MyExcelParser(tokens);
                var tree = parser.compileUnit();
                var visitor = new MyExcelVisitor();
                return Convert.ToString(visitor.Visit(tree));
            }
            catch (NullReferenceException)
            {
                return "0";
            }
        }
        public static string Evaluate(string expression)
        {
            Registry.Clear();
            foreach(var item in MyExcelVisitor.tableIdentifier)
            {
                Registry[item.Value.Name] = false;
            }
            return PrvtEvaluate(expression);
        }
        
    }
}