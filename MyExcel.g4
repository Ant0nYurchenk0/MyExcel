grammar MyExcel;

/*
* Parser Rules
*/
compileUnit : expression EOF;
expression :
LPAREN expression RPAREN #ParenthesizedExpr
| expression EXPONENT expression #ExponentialExpr
| expression operatorToken=(MULTIPLY | DIVIDE) expression #MultiplicativeExpr
| expression operatorToken=(ADD | SUBTRACT) expression #AdditiveExpr
| expression operatorToken=(EQUALITY | GREATER | LESS) expression #ComparativeExpr
| operatorToken=MIN LPAREN expression ',' expression RPAREN #MinExpr
| operatorToken=MAX LPAREN expression ',' expression RPAREN #MaxExpr
| operatorToken=NOT LPAREN expression RPAREN #NotExpr
| NUMBER #NumberExpr
| IDENTIFIER #IdentifierExpr
;
/*
* Lexer Rules
*/
NUMBER : INT ('.' INT)?;
IDENTIFIER : [A-Z]+[1-9][0-9]*;
INT : ('0'..'9')+;
EXPONENT : '^';
MULTIPLY : '*';
DIVIDE : '/';
SUBTRACT : '-';
ADD : '+';
LPAREN : '(';
RPAREN : ')';
EQUALITY: '=';
GREATER: '>';
LESS: '<';
MAX: 'max';
MIN: 'min';
NOT: 'not';
WS : [ \t\r\n] -> channel(HIDDEN);