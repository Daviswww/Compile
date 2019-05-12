%namespace LAB3_EXC_001
%scannertype MyLanguageScanner
%visibility internal
%tokentype Token

%option stack, minimize, parser, verbose, persistbuffer, noembedbuffers 



%{
int ToInt(string str) {return Int32.Parse(str);}
double ToDouble(string str) {return Double.Parse(str);}
%}

%%

[0-9]+					{yylval.n = ToInt(yytext); return (int)Token.INTEGER;}
[0-9]*\.[0-9]+			{yylval.d = ToDouble(yytext); return (int)Token.FLOAT;}
\+						{yylval.s = yytext; return (int)Token.OP_PLUS;}
\-						{yylval.s = yytext; return (int)Token.OP_SUB;}
\*						{yylval.s = yytext; return (int)Token.OP_MUL;}
\/						{yylval.s = yytext; return (int)Token.OP_DIV;}
\=						{yylval.s = yytext; return (int)Token.OP_EQUAL;}
\(						{yylval.s = yytext; return (int)Token.LEFT_SMALL;}
\)						{yylval.s = yytext; return (int)Token.RIGHT_SMALL;}
\,						{yylval.s = yytext; return (int)Token.COMMA;}
\;						{yylval.s = yytext; return (int)Token.SEMICMMA;}
exp						{yylval.s = yytext; return (int)Token.EXP_FUNC;}
double					{yylval.s = yytext; return (int)Token.TYPE_DOUBLE;}
[_a-zA-Z][_a-zA-Z0-9]*	{yylval.s = yytext; return (int)Token.VARIABLE;}
[.\n]					{}
%%