parser grammar Parser1;
@parser::header {using System;}
@parser::members 
{
	bool kev;
	int loop_times = 0;
	Dictionary<string, int>var_table = new Dictionary<string, int>();
}

options {tokenVocab = Lexer1;}

main_rule
	: statements
	;
statements : statements statement SEMICOMMA
		   | statement SEMICOMMA
	;
statement : operation
		  | declare
		  | INPUT LEFTSP VARIABLE RIGHTSP {var_table[$VARIABLE.text] = int.Parse(Console.ReadLine());}
		  | OUTPUT LEFTSP expression RIGHTSP { 
				if($expression.exprVar < 0)
				{
					Console.Write("{0} is a negative ", $expression.exprVar);
				}
				else if($expression.exprVar > 0)
				{
					Console.Write("{0} is a positive ", $expression.exprVar);
				}
				else
				{
					Console.Write("{0} is a zero.\n", $expression.exprVar);
				}
				if($expression.exprVar != 0)
				{
					if($expression.exprVar % 2 == 1)
					{
						Console.Write("odd number.\n");
					}
					else if($expression.exprVar % 2 == 0)
					{
						Console.Write("even number.\n", $expression.exprVar);
					}
				}


			}
		  ;

operation : VARIABLE EQUAL expression	{ var_table[$VARIABLE.text]=$expression.exprVar; }
		;

declare : var_type var_list
		;

var_type : INT
		;

var_list : var_init
		| var_init COMMA var_list
		;

var_init : VARIABLE							{var_table.Add($VARIABLE.text, 0);}
		|  VARIABLE EQUAL expression		{var_table.Add($VARIABLE.text, $expression.exprVar);}
		;
expression returns [int exprVar]
	: term { $exprVar = $term.termVar;}
	(
		PLUS term { $exprVar += $term.termVar; }
		|
		MINUS term { $exprVar -= $term.termVar; }
	)*
	;

term returns [int termVar]
	: factor { $termVar = $factor.factorVar; }
	(
		MULT factor { $termVar *= $factor.factorVar; }
		|
		DIV factor { $termVar /= $factor.factorVar; }
		|
		MOD factor { $termVar %= $factor.factorVar; }
	)*
	;

factor returns [int factorVar]
	: NUMBER {$factorVar = int.Parse($NUMBER.text); }
	| VARIABLE {$factorVar = var_table[$VARIABLE.text]; }
	;

compileUnit
	:	EOF
	;
