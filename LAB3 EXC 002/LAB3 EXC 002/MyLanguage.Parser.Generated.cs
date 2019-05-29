// This code was generated by the Gardens Point Parser Generator
// Copyright (c) Wayne Kelly, John Gough, QUT 2005-2014
// (see accompanying GPPGcopyright.rtf)

// GPPG version 1.5.2
// Machine:  C4-036
// DateTime: 2019/5/11 �W�� 11:04:46
// UserName: C4
// Input file <MyLanguage.Language.grammar.y - 2019/5/11 �W�� 11:04:44>

// options: no-lines gplex

using System;
using System.Collections.Generic;
using System.CodeDom.Compiler;
using System.Globalization;
using System.Text;
using QUT.Gppg;

namespace LAB3_EXC_002
{
internal enum Token {error=2,EOF=3,INTEGER=4,FLOAT=5,OP_PLUS=6,
    OP_SUB=7,OP_MUL=8,OP_DIV=9,OP_EQUAL=10,LEFT_SMALL=11,RIGHT_SMALL=12,
    COMMA=13,SEMICOMMA=14,EXP_FUNC=15,TYPE_DOUBLE=16,VARIABLE=17};

internal partial struct ValueType
{ 
			public int n; 
			public double d;
			public string s; 
			
	   }
// Abstract base class for GPLEX scanners
[GeneratedCodeAttribute( "Gardens Point Parser Generator", "1.5.2")]
internal abstract class ScanBase : AbstractScanner<ValueType,LexLocation> {
  private LexLocation __yylloc = new LexLocation();
  public override LexLocation yylloc { get { return __yylloc; } set { __yylloc = value; } }
  protected virtual bool yywrap() { return true; }
}

// Utility class for encapsulating token information
[GeneratedCodeAttribute( "Gardens Point Parser Generator", "1.5.2")]
internal class ScanObj {
  public int token;
  public ValueType yylval;
  public LexLocation yylloc;
  public ScanObj( int t, ValueType val, LexLocation loc ) {
    this.token = t; this.yylval = val; this.yylloc = loc;
  }
}

[GeneratedCodeAttribute( "Gardens Point Parser Generator", "1.5.2")]
internal partial class MyLanguageParser: ShiftReduceParser<ValueType, LexLocation>
{
  // Verbatim content from MyLanguage.Language.grammar.y - 2019/5/11 �W�� 11:04:44
	Dictionary<string, double>var_table = new Dictionary<string, double>();
  // End verbatim content from MyLanguage.Language.grammar.y - 2019/5/11 �W�� 11:04:44

#pragma warning disable 649
  private static Dictionary<int, string> aliases;
#pragma warning restore 649
  private static Rule[] rules = new Rule[26];
  private static State[] states = new State[46];
  private static string[] nonTerms = new string[] {
      "main", "$accept", "statements", "statement", "operation", "declare", "expression", 
      "var_type", "var_list", "var_init", "term", "factor", "number", };

  static MyLanguageParser() {
    states[0] = new State(new int[]{17,7,16,43},new int[]{-1,1,-3,3,-4,44,-5,6,-6,34,-8,35});
    states[1] = new State(new int[]{3,2});
    states[2] = new State(-1);
    states[3] = new State(new int[]{17,7,16,43,3,-2},new int[]{-4,4,-5,6,-6,34,-8,35});
    states[4] = new State(new int[]{14,5});
    states[5] = new State(-3);
    states[6] = new State(-5);
    states[7] = new State(new int[]{10,8});
    states[8] = new State(new int[]{4,15,5,16,7,17,15,19,11,29},new int[]{-7,9,-11,32,-12,33,-13,14});
    states[9] = new State(new int[]{6,10,7,25,14,-7});
    states[10] = new State(new int[]{4,15,5,16,7,17,15,19,11,29},new int[]{-11,11,-12,33,-13,14});
    states[11] = new State(new int[]{8,12,9,27,6,-15,7,-15,14,-15,13,-15,12,-15});
    states[12] = new State(new int[]{4,15,5,16,7,17,15,19,11,29},new int[]{-12,13,-13,14});
    states[13] = new State(-18);
    states[14] = new State(-20);
    states[15] = new State(-24);
    states[16] = new State(-25);
    states[17] = new State(new int[]{4,15,5,16},new int[]{-13,18});
    states[18] = new State(-21);
    states[19] = new State(new int[]{11,20});
    states[20] = new State(new int[]{4,15,5,16,7,17,15,19,11,29},new int[]{-7,21,-11,32,-12,33,-13,14});
    states[21] = new State(new int[]{13,22,6,10,7,25});
    states[22] = new State(new int[]{4,15,5,16,7,17,15,19,11,29},new int[]{-7,23,-11,32,-12,33,-13,14});
    states[23] = new State(new int[]{12,24,6,10,7,25});
    states[24] = new State(-22);
    states[25] = new State(new int[]{4,15,5,16,7,17,15,19,11,29},new int[]{-11,26,-12,33,-13,14});
    states[26] = new State(new int[]{8,12,9,27,6,-16,7,-16,14,-16,13,-16,12,-16});
    states[27] = new State(new int[]{4,15,5,16,7,17,15,19,11,29},new int[]{-12,28,-13,14});
    states[28] = new State(-19);
    states[29] = new State(new int[]{4,15,5,16,7,17,15,19,11,29},new int[]{-7,30,-11,32,-12,33,-13,14});
    states[30] = new State(new int[]{12,31,6,10,7,25});
    states[31] = new State(-23);
    states[32] = new State(new int[]{8,12,9,27,6,-14,7,-14,14,-14,13,-14,12,-14});
    states[33] = new State(-17);
    states[34] = new State(-6);
    states[35] = new State(new int[]{17,40},new int[]{-9,36,-10,37});
    states[36] = new State(-8);
    states[37] = new State(new int[]{13,38,14,-10});
    states[38] = new State(new int[]{17,40},new int[]{-9,39,-10,37});
    states[39] = new State(-11);
    states[40] = new State(new int[]{10,41,13,-12,14,-12});
    states[41] = new State(new int[]{4,15,5,16,7,17,15,19,11,29},new int[]{-7,42,-11,32,-12,33,-13,14});
    states[42] = new State(new int[]{6,10,7,25,13,-13,14,-13});
    states[43] = new State(-9);
    states[44] = new State(new int[]{14,45});
    states[45] = new State(-4);

    for (int sNo = 0; sNo < states.Length; sNo++) states[sNo].number = sNo;

    rules[1] = new Rule(-2, new int[]{-1,3});
    rules[2] = new Rule(-1, new int[]{-3});
    rules[3] = new Rule(-3, new int[]{-3,-4,14});
    rules[4] = new Rule(-3, new int[]{-4,14});
    rules[5] = new Rule(-4, new int[]{-5});
    rules[6] = new Rule(-4, new int[]{-6});
    rules[7] = new Rule(-5, new int[]{17,10,-7});
    rules[8] = new Rule(-6, new int[]{-8,-9});
    rules[9] = new Rule(-8, new int[]{16});
    rules[10] = new Rule(-9, new int[]{-10});
    rules[11] = new Rule(-9, new int[]{-10,13,-9});
    rules[12] = new Rule(-10, new int[]{17});
    rules[13] = new Rule(-10, new int[]{17,10,-7});
    rules[14] = new Rule(-7, new int[]{-11});
    rules[15] = new Rule(-7, new int[]{-7,6,-11});
    rules[16] = new Rule(-7, new int[]{-7,7,-11});
    rules[17] = new Rule(-11, new int[]{-12});
    rules[18] = new Rule(-11, new int[]{-11,8,-12});
    rules[19] = new Rule(-11, new int[]{-11,9,-12});
    rules[20] = new Rule(-12, new int[]{-13});
    rules[21] = new Rule(-12, new int[]{7,-13});
    rules[22] = new Rule(-12, new int[]{15,11,-7,13,-7,12});
    rules[23] = new Rule(-12, new int[]{11,-7,12});
    rules[24] = new Rule(-13, new int[]{4});
    rules[25] = new Rule(-13, new int[]{5});
  }

  protected override void Initialize() {
    this.InitSpecialTokens((int)Token.error, (int)Token.EOF);
    this.InitStates(states);
    this.InitRules(rules);
    this.InitNonTerminals(nonTerms);
  }

  protected override void DoAction(int action)
  {
#pragma warning disable 162, 1522
    switch (action)
    {
      case 3: // statements -> statements, statement, SEMICOMMA
{
			foreach(KeyValuePair<string, double> v in var_table)
			{
				Console.Write("{0} = {1}\n", v.Key, v.Value);
			}
		}
        break;
      case 4: // statements -> statement, SEMICOMMA
{
			foreach(KeyValuePair<string, double> v in var_table)
			{
				Console.Write("{0} = {1}\n", v.Key, v.Value);
			}
		}
        break;
      case 7: // operation -> VARIABLE, OP_EQUAL, expression
{ var_table[ValueStack[ValueStack.Depth-3].s]=ValueStack[ValueStack.Depth-1].d; }
        break;
      case 12: // var_init -> VARIABLE
{var_table.Add(ValueStack[ValueStack.Depth-1].s, 0);}
        break;
      case 13: // var_init -> VARIABLE, OP_EQUAL, expression
{var_table.Add(ValueStack[ValueStack.Depth-3].s, ValueStack[ValueStack.Depth-1].d);}
        break;
      case 14: // expression -> term
{CurrentSemanticValue.d=ValueStack[ValueStack.Depth-1].d;}
        break;
      case 15: // expression -> expression, OP_PLUS, term
{CurrentSemanticValue.d=ValueStack[ValueStack.Depth-3].d+ValueStack[ValueStack.Depth-1].d;}
        break;
      case 16: // expression -> expression, OP_SUB, term
{CurrentSemanticValue.d=ValueStack[ValueStack.Depth-3].d-ValueStack[ValueStack.Depth-1].d;}
        break;
      case 17: // term -> factor
{CurrentSemanticValue.d=ValueStack[ValueStack.Depth-1].d;}
        break;
      case 18: // term -> term, OP_MUL, factor
{CurrentSemanticValue.d=ValueStack[ValueStack.Depth-3].d*ValueStack[ValueStack.Depth-1].d;}
        break;
      case 19: // term -> term, OP_DIV, factor
{CurrentSemanticValue.d=ValueStack[ValueStack.Depth-3].d/ValueStack[ValueStack.Depth-1].d;}
        break;
      case 20: // factor -> number
{CurrentSemanticValue.d=ValueStack[ValueStack.Depth-1].d;}
        break;
      case 21: // factor -> OP_SUB, number
{CurrentSemanticValue.d=-ValueStack[ValueStack.Depth-1].d;}
        break;
      case 22: // factor -> EXP_FUNC, LEFT_SMALL, expression, COMMA, expression, RIGHT_SMALL
{CurrentSemanticValue.d=Math.Pow(ValueStack[ValueStack.Depth-4].d, ValueStack[ValueStack.Depth-2].d);}
        break;
      case 23: // factor -> LEFT_SMALL, expression, RIGHT_SMALL
{CurrentSemanticValue.d=ValueStack[ValueStack.Depth-2].d;}
        break;
      case 24: // number -> INTEGER
{CurrentSemanticValue.d=ValueStack[ValueStack.Depth-1].n;}
        break;
      case 25: // number -> FLOAT
{CurrentSemanticValue.d=ValueStack[ValueStack.Depth-1].d;}
        break;
    }
#pragma warning restore 162, 1522
  }

  protected override string TerminalToString(int terminal)
  {
    if (aliases != null && aliases.ContainsKey(terminal))
        return aliases[terminal];
    else if (((Token)terminal).ToString() != terminal.ToString(CultureInfo.InvariantCulture))
        return ((Token)terminal).ToString();
    else
        return CharToString((char)terminal);
  }

}
}