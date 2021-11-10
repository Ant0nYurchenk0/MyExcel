using Antlr4.Runtime;
using System;
namespace MyExcel
{
    class ThrowExceptionErrorListener : BaseErrorListener, IAntlrErrorListener<int>
{
        //BaseErrorListener implementation
        public override void SyntaxError(IRecognizer recognizer, IToken offendingSymbol, int line, int charPositionInLine, string
        msg, RecognitionException e)
        {
            throw new ArgumentException(" Invalid Expression: {0}", msg, e);
        }
        //IAntlrErrorListener&lt;int&gt; implementation
        public void SyntaxError(IRecognizer recognizer, int offendingSymbol, int line, int charPositionInLine, string msg,
        RecognitionException e)
        {
            throw new ArgumentException(" Invalid Expression: {0}", msg, e);
        }
    }
}