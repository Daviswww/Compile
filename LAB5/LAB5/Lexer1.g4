lexer grammar Lexer1;
@lexer::header {using System;}
@lexer::members {}
INPUT
	:'input'
	;

OUTPUT
	:'output'
	;

LEFTSP
	:'('
	;

RIGHTSP
	:')'
	;		 

PLUS
	: '+'
	;

MINUS
	: '-'
	;

MULT
	: '*'
	;

DIV
	: '/'
	;

MOD
	: '%'
	;
EQUAL
	: '='
	;

COMMA
	: ','
	;

SEMICOMMA
	: ';'
	;

NUMBER
	: ('0'..'9')+
	;
INT
	: 'int'
	;

VARIABLE
	: ('_' | 'a'..'z' | 'A'..'Z')('_' | 'a'..'z' | 'A'..'Z'|'0'..'9')*
	;

SEMICMMA
	: ';'
	;

WS
	: ('\t'|' '|'\r'|'\n'|'\u000C')+->channel(HIDDEN)
	;
