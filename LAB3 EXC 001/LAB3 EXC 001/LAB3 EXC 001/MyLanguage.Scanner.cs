using System;
using System.Collections.Generic;
using System.Text;

namespace LAB3_EXC_001
{
    internal partial class MyLanguageScanner
    {

        void GetNumber()
        {
            yylval.s = yytext;
            yylval.n = int.Parse(yytext);
        }

		public override void yyerror(string format, params object[] args)
		{
			base.yyerror(format, args);
			Console.WriteLine(format, args);
			Console.WriteLine();
		}
    }
}
