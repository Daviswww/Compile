%namespace LAB3_EXC_001
%partial
%parsertype MyLanguageParser
%visibility internal
%tokentype Token

%union { 
			public int n; 
			public double d;
			public string s; 
			
	   }

%start main

%token INTEGER, FLOAT, OP_PLUS, OP_SUB, OP_MUL, OP_DIV, OP_EQUAL
%token LEFT_SMALL, RIGHT_SMALL, COMMA, SEMICMMA, EXP_FUNC, TYPE_DOUBLE, VARIABLE

%{
	Dictionary<string, double>var_table = new Dictionary<string, double>();
%}

%%

main   : declare
		{
			foreach(KeyValuePair<string, double> v in var_table)
			{
				Console.Write("{0} = {1}\n", v.Key, v.Value);
			}
		}
       ;
	   
declare : var_type var_list SEMICMMA
		;

var_type : TYPE_DOUBLE
		;

var_list : var_init
		| var_init COMMA var_list
		;

var_init : VARIABLE							{var_table.Add($1.s, 0);}
		|	VARIABLE OP_EQUAL expression	{var_table.Add($1.s, $3.d);}
		;

expression : term							{$$.d=$1.d;}
		| expression OP_PLUS term			{$$.d=$1.d+$3.d;}
		| expression OP_SUB term			{$$.d=$1.d-$3.d;}
		;
term : factor								{$$.d=$1.d;}
		| term OP_MUL factor				{$$.d=$1.d*$3.d;}
		| term OP_DIV factor				{$$.d=$1.d/$3.d;}
		;
factor : number								{$$.d=$1.d;}
		| OP_SUB number						{$$.d=-$2.d;}
		| EXP_FUNC LEFT_SMALL expression COMMA expression RIGHT_SMALL
		{$$.d=Math.Pow($3.d, $5.d);}
		| LEFT_SMALL expression RIGHT_SMALL	{$$.d=$2.d;}
		;
number : INTEGER							{$$.d=$1.n;}
		| FLOAT								{$$.d=$1.d;}
		;
%%